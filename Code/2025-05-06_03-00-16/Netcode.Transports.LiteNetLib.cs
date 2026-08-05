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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, DANECHFAMOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HLMGLHNGOMC
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
		private NetworkManager OIFDKEIIEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GPEALFFHPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, IOJOOLBIBAE> FLFOLDFAOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IFOIFEECBLM FCBGIMMHFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch OADPGBHDMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] CJODCGGBDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HLMGLHNGOMC OAJOAJAHPOO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong KHBFHLHNAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool NBIPGINPLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6DB22A0", Offset = "0x6DB0AA0", VA = "0x186DB22A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1820", Offset = "0x6DB0020", VA = "0x186DB1820")]
		public void RecRoom_SetEncryptionInfo(ulong BNFCHBBMBNG, byte[] BELIEAFHDAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1800", Offset = "0x6DB0000", VA = "0x186DB1800")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DB16D0", Offset = "0x6DAFED0", VA = "0x186DB16D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6DB21A0", Offset = "0x6DB09A0", VA = "0x186DB21A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1940", Offset = "0x6DB0140", VA = "0x186DB1940", Slot = "6")]
		public override void Send(ulong AOKFPIHOGDG, ArraySegment<byte> NFNBKNAJBPN, NetworkDelivery MJAEPMKLKIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB17C0", Offset = "0x6DAFFC0", VA = "0x186DB17C0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong AOKFPIHOGDG, [Out] ArraySegment<byte> JDGDKOENECG, [Out] float PIKMGCACEHM)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1C30", Offset = "0x6DB0430", VA = "0x186DB1C30", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB20C0", Offset = "0x6DB08C0", VA = "0x186DB20C0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0FE0", Offset = "0x6DAF7E0", VA = "0x186DB0FE0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong AOKFPIHOGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0EF0", Offset = "0x6DAF6F0", VA = "0x186DB0EF0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1150", Offset = "0x6DAF950", VA = "0x186DB1150", Slot = "13")]
		public override ulong GetCurrentRtt(ulong AOKFPIHOGDG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1BC0", Offset = "0x6DB03C0", VA = "0x186DB1BC0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DB11F0", Offset = "0x6DAF9F0", VA = "0x186DB11F0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager OIFDKEIIEPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1600", Offset = "0x6DAFE00", VA = "0x186DB1600")]
		private PLCPIDHJMMI OJBIGHDAHPD(NetworkDelivery PIJHKCJDAHO)
		{
			return default(PLCPIDHJMMI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0C20", Offset = "0x6DAF420", VA = "0x186DB0C20", Slot = "16")]
		private void AGHPGJMGEPN(IOJOOLBIBAE EAFDOIEFHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1400", Offset = "0x6DAFC00", VA = "0x186DB1400", Slot = "17")]
		private void JIFDNOOOCPH(IOJOOLBIBAE EAFDOIEFHMG, IMIKOAGOLOA MLKEIDOPIPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "18")]
		private void ANHPOFGPLOD(IPEndPoint OKMHFFMMIDG, SocketError JBAJFIPPDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0CE0", Offset = "0x6DAF4E0", VA = "0x186DB0CE0", Slot = "19")]
		private void DJLIDGAKHDI(IOJOOLBIBAE EAFDOIEFHMG, NHDECIILFIM DMPKKEDJKBJ, byte MMEIPMFAFEF, PLCPIDHJMMI BPCFIIJJHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1500", Offset = "0x6DAFD00", VA = "0x186DB1500")]
		private void MHHGCDBHIOA(int LBLAFDELPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "20")]
		private void GLAKBBDKEIH(IPEndPoint NEGIEBGCAGJ, NHDECIILFIM DMPKKEDJKBJ, FCAJLHPFCNP AKOHFFNCDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "21")]
		private void BMELBOCNNKF(IOJOOLBIBAE EAFDOIEFHMG, int DFGJICFBIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB10F0", Offset = "0x6DAF8F0", VA = "0x186DB10F0", Slot = "22")]
		private void EIBFBHMHJMF(JOKJPMAJDPO JHLBOHEIAIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB14D0", Offset = "0x6DAFCD0", VA = "0x186DB14D0")]
		private ulong JOMMJNFBLKJ(IOJOOLBIBAE EAFDOIEFHMG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB15E0", Offset = "0x6DAFDE0", VA = "0x186DB15E0")]
		private static int MJNLFFAMCNK(float FOLPOAMFDOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DB21C0", Offset = "0x6DB09C0", VA = "0x186DB21C0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class APIEBLCJJPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly IOJOOLBIBAE HCDALKCGLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<MHDNFEKAFBE> APAILPNGMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int LDKLOGBMCPL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CCD0", Offset = "0x6D9B4D0", VA = "0x186D9CCD0")]
	protected APIEBLCJJPB(IOJOOLBIBAE EAFDOIEFHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CBF0", Offset = "0x6D9B3F0", VA = "0x186D9CBF0")]
	public void HNJJIOOHBMP(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CC50", Offset = "0x6D9B450", VA = "0x186D9CC50")]
	protected void ODEKJMOIDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CBB0", Offset = "0x6D9B3B0", VA = "0x186D9CBB0")]
	public bool BDEGKKDGLKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool PDLIHAMFOPK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool BJIINABMHEP(MHDNFEKAFBE MCEIPPDGOOF);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum NDLILHFGGLG
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
public class JOKJPMAJDPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly IFOIFEECBLM BOEFGAMGCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int JCMKEPPKJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal FNKNALLNMJD HDELKIKADHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint JCFJMMNJIHG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal NDLILHFGGLG JBGJDBLIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330")]
		[CompilerGenerated]
		get
		{
			return default(NDLILHFGGLG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C3C0", VA = "0x180D3DBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DAED80", Offset = "0x6DAD580", VA = "0x186DAED80")]
	internal void LADNBNCIEAC(FNKNALLNMJD PKIAAFIEKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DAECF0", Offset = "0x6DAD4F0", VA = "0x186DAECF0")]
	private bool IKMIHCDGGCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEDE0", Offset = "0x6DAD5E0", VA = "0x186DAEDE0")]
	internal JOKJPMAJDPO(IPEndPoint NEGIEBGCAGJ, FNKNALLNMJD JKKAELHHBIG, IFOIFEECBLM CEFGONEHBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAED20", Offset = "0x6DAD520", VA = "0x186DAED20")]
	public IOJOOLBIBAE KCNMAIDHJBO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FCAJLHPFCNP
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NMOANDECOKI
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
public struct IMIKOAGOLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NMOANDECOKI PPHPHPLNKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError PNHPAEFOLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NHDECIILFIM LOBPMMDIJNI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DANECHFAMOD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKNEACAANFG(IOJOOLBIBAE EAFDOIEFHMG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNJNJLOJFEL(IOJOOLBIBAE EAFDOIEFHMG, IMIKOAGOLOA MLKEIDOPIPL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AAPBMGBBEON(IPEndPoint OKMHFFMMIDG, SocketError JBAJFIPPDPB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJHKDFNNMAL(IOJOOLBIBAE EAFDOIEFHMG, NHDECIILFIM DMPKKEDJKBJ, byte MMEIPMFAFEF, PLCPIDHJMMI BPCFIIJJHMD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJGCKNKMMPM(IPEndPoint NEGIEBGCAGJ, NHDECIILFIM DMPKKEDJKBJ, FCAJLHPFCNP AKOHFFNCDKC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHNFOLDJNLM(IOJOOLBIBAE EAFDOIEFHMG, int DFGJICFBIPD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMFHDFODJKP(JOKJPMAJDPO JHLBOHEIAIJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PHBEBLCNHFI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEOFIGBIIEN(IOJOOLBIBAE EAFDOIEFHMG, object ONDFEGPOKLD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FMNIHBIKJDI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFANMCLGLEL(APJMNMLBNEG MCEIPPDGOOF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JMKACCJONNM
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFBOGDHHLIE(IOJOOLBIBAE EAFDOIEFHMG, IPEndPoint HFBNGOFADEK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FNKNALLNMJD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int CNMFJKCBIFP = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long MLJPCNCPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte IKDEFOOCBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] FKKLOHCELLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly KKKJNIJJMGH BADLMALNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int PGOFBEOHBNN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1200", Offset = "0x6D9FA00", VA = "0x186DA1200")]
	private FNKNALLNMJD(long BCLIPHAPABL, byte BFGOGBAIKFK, int DGLFHMAFDAJ, byte[] IEGKHHAANPO, KKKJNIJJMGH NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0F80", Offset = "0x6D9F780", VA = "0x186DA0F80")]
	public static int LEFOGEHNONK(MHDNFEKAFBE MCEIPPDGOOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0FE0", Offset = "0x6D9F7E0", VA = "0x186DA0FE0")]
	public static FNKNALLNMJD ODPBOEPBPLG(MHDNFEKAFBE MCEIPPDGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0DA0", Offset = "0x6D9F5A0", VA = "0x186DA0DA0")]
	public static MHDNFEKAFBE GOBOEHAMKPB(CMBFMCAKCGJ DECDNLPOOAN, SocketAddress GDHHCMCPGBM, long INGJKDCHDHP, int DGLFHMAFDAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PNGLOFIALNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long MLJPCNCPAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte IKDEFOOCBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int PGOFBEOHBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool BPJOJIPAOEA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DB36A0", Offset = "0x6DB1EA0", VA = "0x186DB36A0")]
	private PNGLOFIALNK(long BCLIPHAPABL, byte BFGOGBAIKFK, int LGFGIEMJFIP, bool JDMCCEJFNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3550", Offset = "0x6DB1D50", VA = "0x186DB3550")]
	public static PNGLOFIALNK ODPBOEPBPLG(MHDNFEKAFBE MCEIPPDGOOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3460", Offset = "0x6DB1C60", VA = "0x186DB3460")]
	public static MHDNFEKAFBE GOBOEHAMKPB(long INGJKDCHDHP, byte PHFOLMNHLCP, int LKHCPGADHKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3360", Offset = "0x6DB1B60", VA = "0x186DB3360")]
	public static MHDNFEKAFBE FEDEBBILMIP(IOJOOLBIBAE EAFDOIEFHMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum KCENIMCKOFC
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FCLLGAAMOCH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DJDIEJOIMAE(IPEndPoint FABLIMPKGME, IPEndPoint NEGIEBGCAGJ, string JILOCOLKOMJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMBMBHGMPJC(IPEndPoint IODHAJCCCMC, KCENIMCKOFC PIJHKCJDAHO, string JILOCOLKOMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PNONJNILCAE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct FHHAFFJONCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint KEAEAFOEGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint JCFJMMNJIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string AKDFEJKGFPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HJEBMLFGEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint DIEAKDKOPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KCENIMCKOFC PALJBODIBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string AKDFEJKGFPO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class PCOPCFKEFCH
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint GPLOJECPHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string AKDFEJKGFPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public PCOPCFKEFCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class CBNJGMAJBPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GPLOJECPHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint OEGAEDHIBFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string AKDFEJKGFPO
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public CBNJGMAJBPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class BHONNLMEILL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AKDFEJKGFPO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KAHFHAGGCFC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA85410", Offset = "0xA83C10", VA = "0x180A85410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9E1B40", Offset = "0x9E0340", VA = "0x1809E1B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BHONNLMEILL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly IFOIFEECBLM IFLCHLBCBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<FHHAFFJONCG> NGKJDDMJBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<HJEBMLFGEFE> OGACNPGGBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KKKJNIJJMGH BELNIBCGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly CMBFMCAKCGJ LAJNJGHCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly AMNLGHJGBNC NIDHNHJFDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private FCLLGAAMOCH AGNKJOHPEGO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int POCFPMMFHPE = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool BDNMIDNBAKH;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3D00", Offset = "0x6DB2500", VA = "0x186DB3D00")]
	internal PNONJNILCAE(IFOIFEECBLM GLIMIFHIGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3B80", Offset = "0x6DB2380", VA = "0x186DB3B80")]
	internal void IJPEEAOMFBL(IPEndPoint LGNFPJENBNM, MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3999A40", Offset = "0x3998240", VA = "0x183999A40")]
	private void INCLKNPFIPO<T>(T MCEIPPDGOOF, IPEndPoint ALLFIKNKLHM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DB36F0", Offset = "0x6DB1EF0", VA = "0x186DB36F0")]
	private void DJDIEJOIMAE(PCOPCFKEFCH BNMLMKMHNPE, IPEndPoint LGNFPJENBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3A20", Offset = "0x6DB2220", VA = "0x186DB3A20")]
	private void EJNJNMBLNJF(CBNJGMAJBPD BNMLMKMHNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3880", Offset = "0x6DB2080", VA = "0x186DB3880")]
	private void EAOMMNMDIAI(BHONNLMEILL BNMLMKMHNPE, IPEndPoint LGNFPJENBNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum PLCPIDHJMMI : byte
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
public enum DCGNJCMCJLL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NHGLKNPNMEI
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] KGJEFEPBNDG;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int HGAFJMJGBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int PAOKOIJPBJI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CDBPIJDANAG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F5F0", Offset = "0x6D9DDF0", VA = "0x186D9F5F0")]
	public CDBPIJDANAG(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FNGFHOBEOHM : CDBPIJDANAG
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F5F0", Offset = "0x6D9DDF0", VA = "0x186D9F5F0")]
	public FNGFHOBEOHM(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum APPCAMCPGFA
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
public interface EFEBALKOPGF
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFOBMBMMPKK(APPCAMCPGFA LEIIPDHBCHM, string NECPKEMHBDH, params object[] FHMAIKMLNLH);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PCAHABHMECO
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static EFEBALKOPGF PHMOGNCGJNA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object IFJEABLFPEI;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2FC0", Offset = "0x6DB17C0", VA = "0x186DB2FC0")]
	private static void GEPBEMIDFDE(APPCAMCPGFA PFGBKEGHOCM, string NECPKEMHBDH, params object[] FHMAIKMLNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2F60", Offset = "0x6DB1760", VA = "0x186DB2F60")]
	internal static void FEIPAGLEJND(string NECPKEMHBDH, params object[] FHMAIKMLNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3250", Offset = "0x6DB1A50", VA = "0x186DB3250")]
	internal static void OFOCMPPHDLA(string NECPKEMHBDH, params object[] FHMAIKMLNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DB31F0", Offset = "0x6DB19F0", VA = "0x186DB31F0")]
	internal static void GFBGKEGGCPK(string NECPKEMHBDH, params object[] FHMAIKMLNLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum JDJKOFHBLMB
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NHDECIILFIM : KKKJNIJJMGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private MHDNFEKAFBE CGDJGCBOJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly IFOIFEECBLM FDKAIIPDAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly ACEFIKJCADE IGKGDBFKHEH;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2E40", Offset = "0x6DB1640", VA = "0x186DB2E40")]
	internal NHDECIILFIM(IFOIFEECBLM IPKPNIAEJDE, ACEFIKJCADE AHDJGIKMPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2DA0", Offset = "0x6DB15A0", VA = "0x186DB2DA0")]
	internal void GMDOLGGBNHB(MHDNFEKAFBE MCEIPPDGOOF, int IFMBFJNHHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2D20", Offset = "0x6DB1520", VA = "0x186DB2D20")]
	internal void EIMENAIAJCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2E10", Offset = "0x6DB1610", VA = "0x186DB2E10")]
	public void NHLNDEDKGHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class ACEFIKJCADE
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum EPKIAHDFMCM
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
	public ACEFIKJCADE BMGLGMIMDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public EPKIAHDFMCM PALJBODIBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public IOJOOLBIBAE HCDALKCGLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint JCFJMMNJIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object MENIMECNOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int LCEFFCDHGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError LJCCNHFIBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NMOANDECOKI LGDAJBFBIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public JOKJPMAJDPO DCGKPNICMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public PLCPIDHJMMI BAAAOAFBPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte KPIHENIDGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly NHDECIILFIM CMBLANELMPK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C730", Offset = "0x6D9AF30", VA = "0x186D9C730")]
	public ACEFIKJCADE(IFOIFEECBLM IPKPNIAEJDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IFOIFEECBLM : IEnumerable<IOJOOLBIBAE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class GBBLNDKOLAF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1270", Offset = "0x6D9FA70", VA = "0x186DA1270", Slot = "4")]
		public bool Equals(IPEndPoint LEFBJAGNHCD, IPEndPoint LLGPJHIECFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68F8CA0", Offset = "0x68F74A0", VA = "0x1868F8CA0", Slot = "5")]
		public int GetHashCode(IPEndPoint PNHCNFOFAFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GBBLNDKOLAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct HMGHKKBEDPN : IEnumerator<IOJOOLBIBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly IOJOOLBIBAE BLBGDAMHAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private IOJOOLBIBAE FPBKHOGPMFD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IOJOOLBIBAE IECKFCICFIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD68560", Offset = "0xD66D60", VA = "0x180D68560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x19A5460", Offset = "0x19A3C60", VA = "0x1819A5460")]
		public HMGHKKBEDPN(IOJOOLBIBAE GOHMPMCJCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2630", Offset = "0x6DA0E30", VA = "0x186DA2630", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2680", Offset = "0x6DA0E80", VA = "0x186DA2680", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread EIJLKMGBIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool JOBBDIPIBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool MGPDOEIEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private NBMLAANFMKD JFIMADLMGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent BBDHCPJGLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<ACEFIKJCADE> EFGMKONMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<ACEFIKJCADE> IKHPKKLKDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private ACEFIKJCADE EHDGOHHFEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly DANECHFAMOD KNGAMKNFMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly PHBEBLCNHFI BCEJFGFNJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FMNIHBIKJDI LJEEANBJNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JMKACCJONNM EJLCJPBODBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, IOJOOLBIBAE> OGKOIKDDNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, JOKJPMAJDPO> AHHIPDAIAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, LBFOKNDGJBF> NEGCEKJMIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim NOGPKAALFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private IOJOOLBIBAE ALJJGKBGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int CGMAODIGMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<IOJOOLBIBAE> IKNMJGHHABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private IOJOOLBIBAE[] ABPPOPGEEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OHEMLIOABEO LIAJGLICGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int JCNNPMPHAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> IBKELIMMOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte AMEMFOPMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object BFKELPJDKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool KJHKALNEMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool NNKHGEAEKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int CGBADENIBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int AEGLALEHEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CPIKCAGOMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int EIMLGOJPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool AFHMAMINKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool GMHDLPMHKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int GNBHAJKKPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int KEMOLMNAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int OHIGNPIMDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool BDNMIDNBAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool DICAADFPCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool KMMHEHCFHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool JNCKCJANDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int NJJFDLIKADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int BDDCEAKBPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool KOHOIEOLCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly JPPLHJENPNG DACGPPODMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool DCKMNLKDILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly PNONJNILCAE NGKBHMPLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool AILKOKEFPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public JDJKOFHBLMB AGIGKJGCEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int LOEGOJHMAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool PGLOJJPOJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool OOEPANGIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool NOIHNLNCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool BDCEKCBOHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MHDNFEKAFBE IHFEMGNCGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int JAMAGLLPPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object NFIBBLJMCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private MHDNFEKAFBE NOAMCCIAEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GMEKGJOLNKE;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int NHNBNFIPOPB = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int PPPMDMCDOMO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private FCLHOGCCINP GJBDPOPOGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private FCLHOGCCINP MJNNJPPDFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread PHLJMMIOFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread BPDGDPAHJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint CMKMEAPHICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint LJHIGDOFDBI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] GFOKOGADOKE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] OMCLPAEPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<BLNIALOFMDO, IPEndPoint> MLNPEMLICBA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress EEBJEIPKJMG;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool EHDFBLJGAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int CGAIEPEANAD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PDMBDPNPPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1412020", Offset = "0x1410820", VA = "0x181412020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1E02BC0", Offset = "0x1E013C0", VA = "0x181E02BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AGMBDDOIJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x151A700", Offset = "0x1518F00", VA = "0x18151A700")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E02BD0", Offset = "0x1E013D0", VA = "0x181E02BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte JBKMLEEMAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xF1E460", Offset = "0xF1CC60", VA = "0x180F1E460")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MAOFHBEMMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6DA7CD0", Offset = "0x6DA64D0", VA = "0x186DA7CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short KOHJEMNJDDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA6AD0", Offset = "0x6DA52D0", VA = "0x186DA6AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DA68B0", Offset = "0x6DA50B0", VA = "0x186DA68B0")]
	public void FBPNOLCGANP(IPEndPoint OKMHFFMMIDG, byte[] BELIEAFHDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3750", Offset = "0x6DA1F50", VA = "0x186DA3750")]
	public void BJCIIHBOJDO(IPEndPoint OKMHFFMMIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6D20", Offset = "0x6DA5520", VA = "0x186DA6D20")]
	private bool GBEIAMGIGKB(IPEndPoint OKMHFFMMIDG, [Out] IOJOOLBIBAE EAFDOIEFHMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7CF0", Offset = "0x6DA64F0", VA = "0x186DA7CF0")]
	private void HDPPHAAGLJL(IOJOOLBIBAE EAFDOIEFHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6850", Offset = "0x6DA5050", VA = "0x186DA6850")]
	private void FBCFLHHFOIF(IOJOOLBIBAE EAFDOIEFHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8AC0", Offset = "0x6DA72C0", VA = "0x186DA8AC0")]
	private void NJOBNCLPKJJ(IOJOOLBIBAE EAFDOIEFHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9F20", Offset = "0x6DA8720", VA = "0x186DA9F20")]
	public IFOIFEECBLM(DANECHFAMOD CEFGONEHBDD, [Optional] OHEMLIOABEO ONIEDMJGOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA88C0", Offset = "0x6DA70C0", VA = "0x186DA88C0")]
	internal void MPPEAMNNJFE(IOJOOLBIBAE KACLLDNCEPD, int DFGJICFBIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3350", Offset = "0x6DA1B50", VA = "0x186DA3350")]
	internal void ANIAPKKDFAA(IOJOOLBIBAE KACLLDNCEPD, object ONDFEGPOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8560", Offset = "0x6DA6D60", VA = "0x186DA8560")]
	internal void KGOINBPJCBF(IOJOOLBIBAE EAFDOIEFHMG, NMOANDECOKI NLGEMFKLFCF, SocketError BANNMJOAPHJ, MHDNFEKAFBE BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8D90", Offset = "0x6DA7590", VA = "0x186DA8D90")]
	private void NMPGEPPAHPN(IOJOOLBIBAE EAFDOIEFHMG, NMOANDECOKI NLGEMFKLFCF, SocketError BANNMJOAPHJ, bool IOHDICMKADP, byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int PCFOAHIEPDL, MHDNFEKAFBE BKLKAFKNCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6DA78F0", Offset = "0x6DA60F0", VA = "0x186DA78F0")]
	private void GLBCDENBEOG(ACEFIKJCADE.EPKIAHDFMCM PIJHKCJDAHO, [Optional] IOJOOLBIBAE EAFDOIEFHMG, [Optional] IPEndPoint NEGIEBGCAGJ, SocketError JBAPMMNBLOM = SocketError.Success, int DFGJICFBIPD = 0, NMOANDECOKI HCBOOBGMCPH = NMOANDECOKI.ConnectionFailed, [Optional] JOKJPMAJDPO NOFHIKBJPGN, PLCPIDHJMMI BPCFIIJJHMD = PLCPIDHJMMI.Unreliable, byte MMEIPMFAFEF = 0, [Optional] MHDNFEKAFBE JLPMCJHDDIG, [Optional] object ONDFEGPOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6DA26D0", Offset = "0x6DA0ED0", VA = "0x186DA26D0")]
	private void AEEBHPCMAJD(ACEFIKJCADE AHDJGIKMPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6C10", Offset = "0x6DA5410", VA = "0x186DA6C10")]
	internal void FMAGPHHPIGK(ACEFIKJCADE AHDJGIKMPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3400", Offset = "0x6DA1C00", VA = "0x186DA3400")]
	private void BFCACEIDEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DA85A0", Offset = "0x6DA6DA0", VA = "0x186DA85A0")]
	private void MAFMNJJBPGL(int KFNBNOHKEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3A60", Offset = "0x6DA2260", VA = "0x186DA3A60")]
	internal IOJOOLBIBAE BONFNGHLKLG(JOKJPMAJDPO JHLBOHEIAIJ, byte[] EBPAKMDEFLA, int MLFBDFDDHEO, int IMNFCKGEMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6B90", Offset = "0x6DA5390", VA = "0x186DA6B90")]
	private int FHJEPJFKEJC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2EA0", Offset = "0x6DA16A0", VA = "0x186DA2EA0")]
	private void AEMOEPKJHNA(IPEndPoint NEGIEBGCAGJ, IOJOOLBIBAE KJMMPMCDANN, FNKNALLNMJD KPCGJLBCEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4B60", Offset = "0x6DA3360", VA = "0x186DA4B60")]
	private void EIKAJPAIADC(MHDNFEKAFBE MCEIPPDGOOF, IPEndPoint NEGIEBGCAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9A40", Offset = "0x6DA8240", VA = "0x186DA9A40")]
	internal void ODBKEPCKAJM(MHDNFEKAFBE MCEIPPDGOOF, PLCPIDHJMMI DHJOJHBFIIF, byte MMEIPMFAFEF, int IFMBFJNHHIF, IOJOOLBIBAE KACLLDNCEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA77E0", Offset = "0x6DA5FE0", VA = "0x186DA77E0")]
	public bool GIABKOFDCIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA78D0", Offset = "0x6DA60D0", VA = "0x186DA78D0")]
	public bool GIABKOFDCIF(IPAddress OAGHNJJDIMP, IPAddress LBPJIFMJBHJ, int IFDAMJHJJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7850", Offset = "0x6DA6050", VA = "0x186DA7850")]
	public bool GIABKOFDCIF(int IFDAMJHJJPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8910", Offset = "0x6DA7110", VA = "0x186DA8910")]
	public void NGBCLKOCGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6010", Offset = "0x6DA4810", VA = "0x186DA6010")]
	public IOJOOLBIBAE EJLILCFCHEC(string LEHJJMPDHIA, int IFDAMJHJJPI, string BELIEAFHDAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA5F30", Offset = "0x6DA4730", VA = "0x186DA5F30")]
	public IOJOOLBIBAE EJLILCFCHEC(string LEHJJMPDHIA, int IFDAMJHJJPI, CMBFMCAKCGJ CKILPFALACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DA60F0", Offset = "0x6DA48F0", VA = "0x186DA60F0")]
	public IOJOOLBIBAE EJLILCFCHEC(IPEndPoint ALLFIKNKLHM, CMBFMCAKCGJ CKILPFALACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8040", Offset = "0x6DA6840", VA = "0x186DA8040")]
	public void HLPFPMIACMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DA8050", Offset = "0x6DA6850", VA = "0x186DA8050")]
	public void HLPFPMIACMD(bool JKAHCCCHFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4150", Offset = "0x6DA2950", VA = "0x186DA4150")]
	public void CEBLCHGAKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4080", Offset = "0x6DA2880", VA = "0x186DA4080")]
	public void CEBLCHGAKMK(byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6DA91A0", Offset = "0x6DA79A0", VA = "0x186DA91A0")]
	public void NMPGEPPAHPN(IOJOOLBIBAE EAFDOIEFHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6DA91E0", Offset = "0x6DA79E0", VA = "0x186DA91E0")]
	public void NMPGEPPAHPN(IOJOOLBIBAE EAFDOIEFHMG, byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int PCFOAHIEPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9D40", Offset = "0x6DA8540", VA = "0x186DA9D40", Slot = "4")]
	private IEnumerator<IOJOOLBIBAE> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9DD0", Offset = "0x6DA85D0", VA = "0x186DA9DD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3980", Offset = "0x6DA2180", VA = "0x186DA3980")]
	private MHDNFEKAFBE BMOIAKEHJDG(HKAKPMHAGFE KIIAJPLCJIE, int LBLAFDELPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA38A0", Offset = "0x6DA20A0", VA = "0x186DA38A0")]
	private MHDNFEKAFBE BMOIAKEHJDG(HKAKPMHAGFE KIIAJPLCJIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4200", Offset = "0x6DA2A00", VA = "0x186DA4200")]
	internal MHDNFEKAFBE CEDNEEEJPDH(int LBLAFDELPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA6DC0", Offset = "0x6DA55C0", VA = "0x186DA6DC0")]
	internal void GDJJMIKKGMD(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9E60", Offset = "0x6DA8660", VA = "0x186DA9E60")]
	static IFOIFEECBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1412020", Offset = "0x1410820", VA = "0x181412020")]
	private bool DJIPACMCJML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6DA49E0", Offset = "0x6DA31E0", VA = "0x186DA49E0")]
	private void EFKNFLJMELN(IPEndPoint HFACPCAPDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4700", Offset = "0x6DA2F00", VA = "0x186DA4700")]
	private void DEECBCOCDAB(IPEndPoint HFACPCAPDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6DA83B0", Offset = "0x6DA6BB0", VA = "0x186DA83B0")]
	private bool IPNMPDKBDGP(SocketException IIIACJLJMAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9D20", Offset = "0x6DA8520", VA = "0x186DA9D20")]
	private void ODPJLLCGHCE(NBMLAANFMKD GLIMIFHIGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4440", Offset = "0x6DA2C40", VA = "0x186DA4440")]
	private void CLLBAIJAMHD(FCLHOGCCINP GLIMIFHIGMB, EndPoint MAOIAOGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6DA64D0", Offset = "0x6DA4CD0", VA = "0x186DA64D0")]
	private void ENBEBFFPHCE(object LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6DA7020", Offset = "0x6DA5820", VA = "0x186DA7020")]
	public bool GIABKOFDCIF(IPAddress OAGHNJJDIMP, IPAddress LBPJIFMJBHJ, int IFDAMJHJJPI, bool BEFAOMCDNJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6DA33A0", Offset = "0x6DA1BA0", VA = "0x186DA33A0")]
	internal int BBGMMINBFOJ(MHDNFEKAFBE MCEIPPDGOOF, IPEndPoint NEGIEBGCAGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9A00", Offset = "0x6DA8200", VA = "0x186DA9A00")]
	internal int OCOPNFLLDEP(MHDNFEKAFBE MCEIPPDGOOF, IPEndPoint NEGIEBGCAGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6DA9220", Offset = "0x6DA7A20", VA = "0x186DA9220")]
	internal int OCOPNFLLDEP(byte[] NJAAPDELBNN, int MLFBDFDDHEO, int IMNFCKGEMOH, IPEndPoint NEGIEBGCAGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA4860", Offset = "0x6DA3060", VA = "0x186DA4860")]
	internal void EDFJKFMFLGA(bool EAJNDDFELBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum HKAKPMHAGFE : byte
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
internal sealed class MHDNFEKAFBE
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int JLNFINHEFHI;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] BCJHOCCDEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] CAFGDPEPPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int OABHEPHNFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object MENIMECNOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public MHDNFEKAFBE BMGLGMIMDJJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public HKAKPMHAGFE JCNPKOPOKBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2400", Offset = "0x6DB0C00", VA = "0x186DB2400")]
		get
		{
			return default(HKAKPMHAGFE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6DB23C0", Offset = "0x6DB0BC0", VA = "0x186DB23C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte IKDEFOOCBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6DB27B0", Offset = "0x6DB0FB0", VA = "0x186DB27B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6DB26C0", Offset = "0x6DB0EC0", VA = "0x186DB26C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort OKKBJPBHFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DB24F0", Offset = "0x6DB0CF0", VA = "0x186DB24F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2700", Offset = "0x6DB0F00", VA = "0x186DB2700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EMECEGNBPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2740", Offset = "0x6DB0F40", VA = "0x186DB2740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte ALCPFOAHBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2600", Offset = "0x6DB0E00", VA = "0x186DB2600")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2590", Offset = "0x6DB0D90", VA = "0x186DB2590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort BOJFCFOKPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2490", Offset = "0x6DB0C90", VA = "0x186DB2490")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6DB25C0", Offset = "0x6DB0DC0", VA = "0x186DB25C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort GDJDEHMLEAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2430", Offset = "0x6DB0C30", VA = "0x186DB2430")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2550", Offset = "0x6DB0D50", VA = "0x186DB2550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort HNFHNLINDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2630", Offset = "0x6DB0E30", VA = "0x186DB2630")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2770", Offset = "0x6DB0F70", VA = "0x186DB2770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6DB28E0", Offset = "0x6DB10E0", VA = "0x186DB28E0")]
	static MHDNFEKAFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2690", Offset = "0x6DB0E90", VA = "0x186DB2690")]
	public void JJNIFCBBLJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2CB0", Offset = "0x6DB14B0", VA = "0x186DB2CB0")]
	public MHDNFEKAFBE(int LBLAFDELPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2BA0", Offset = "0x6DB13A0", VA = "0x186DB2BA0")]
	public MHDNFEKAFBE(HKAKPMHAGFE KIIAJPLCJIE, int LBLAFDELPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6DB22C0", Offset = "0x6DB0AC0", VA = "0x186DB22C0")]
	public static int ABCDAOMEPMF(HKAKPMHAGFE KIIAJPLCJIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2330", Offset = "0x6DB0B30", VA = "0x186DB2330")]
	public int ABCDAOMEPMF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6DB27E0", Offset = "0x6DB0FE0", VA = "0x186DB27E0")]
	public bool OOAABMLECBF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum KKGDDCCJPEB : byte
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
internal enum OAOFHDFMOEB
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
internal enum FIPEEMOBJEB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum DNNGENFFLEA
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IOJOOLBIBAE
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class MCJKLBPOEIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public MHDNFEKAFBE[] FAKHHALPLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int NDAAEACHIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int FJDPJOHLEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte ALCPFOAHBFK;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public MCJKLBPOEIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void EPAGNKIFKBB(ulong OLLIBIGCIHG, int INMCNJLBMDC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int GEPDLAEFKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int MJPMAMAJDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int LEKLLGKMPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double IPFJACEAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int OBHFIJOKPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int NBJFFMCKBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int HMHCPECDHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch IJAAICCHEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int AHDDGHLPMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long BCBKLDNGFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object GGNIGAJGIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal IOJOOLBIBAE KICKEEALMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal IOJOOLBIBAE GJFCBJNKBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<MHDNFEKAFBE> ACJPMIJMLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<APIEBLCJJPB> CNLHAPBPPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly APIEBLCJJPB[] AOMIPEGIKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int EEACMMCDCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int EALNPLLMGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool LHLKMDGMGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int OPOCAMAAMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int BBAOCODCAPH;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int IBFBEDABLNK = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int HPHPNLNGIAP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object APLAOMCFLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int IEEBGELFDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, MCJKLBPOEIK> OGLEBNCILNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> JMLINPOEALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly MHDNFEKAFBE IJGKEMPLOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int BHJEHIJKBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int FPPPIDLAPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint BCNFLLLCPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int OPJNEJIDCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int DALOINGNGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long GINPMKFGEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte HPLIGACCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private KKGDDCCJPEB PBHGNLOPAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private MHDNFEKAFBE CEKNAHOFDBD;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int LHGDCJMGKNB = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int HIHDHGKFDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly MHDNFEKAFBE LGMLHBJDKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MHDNFEKAFBE GBLNKAOICDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly MHDNFEKAFBE NBIHENIDOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly MHDNFEKAFBE BFLJFCNINIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private DCGNJCMCJLL GLMPDFBEMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly IFOIFEECBLM FHLDAFMFGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int NGHJMEDCGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object FFMOLMBIDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly JPPLHJENPNG DACGPPODMGM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte CENONDCNDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA7B0A0", Offset = "0xA798A0", VA = "0x180A7B0A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6DAB520", Offset = "0x6DA9D20", VA = "0x186DAB520")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint GHEKMMCEJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC95FB0", Offset = "0xC947B0", VA = "0x180C95FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KKGDDCCJPEB HPEFHHJOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB701C0", Offset = "0xB6E9C0", VA = "0x180B701C0")]
		get
		{
			return default(KKGDDCCJPEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long OLPJFKDGBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9E71B0", Offset = "0x9E59B0", VA = "0x1809E71B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FKLBHIHBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x151A6D0", Offset = "0x1518ED0", VA = "0x18151A6D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1E02CA0", Offset = "0x1E014A0", VA = "0x181E02CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NFDCECFJOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC770", Offset = "0x6DAAF70", VA = "0x186DAC770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HGKCMCIIMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double MHJDFDBCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4A60DA0", Offset = "0x4A5F5A0", VA = "0x184A60DA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EPAGNKIFKBB IBCCEJODINN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6DAC7D0", Offset = "0x6DAAFD0", VA = "0x186DAC7D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DADF10", Offset = "0x6DAC710", VA = "0x186DADF10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE330", Offset = "0x6DACB30", VA = "0x186DAE330")]
	internal IOJOOLBIBAE(IFOIFEECBLM LDOFAFFCGAM, IPEndPoint NEGIEBGCAGJ, int MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB750", Offset = "0x6DA9F50", VA = "0x186DAB750")]
	internal void FELNLDEPNAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB5D0", Offset = "0x6DA9DD0", VA = "0x186DAB5D0")]
	internal void DIAJKMCNPIF(IPEndPoint HDLGECGAPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6DABCC0", Offset = "0x6DAA4C0", VA = "0x186DABCC0")]
	internal void GEINCDEBEMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6DADE40", Offset = "0x6DAC640", VA = "0x186DADE40")]
	private void PJKGGMBLJOH(int KJPJJPFONNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6DAAE20", Offset = "0x6DA9620", VA = "0x186DAAE20")]
	private void AOBKABLPDHK(int CCLKMBJBHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6DADC10", Offset = "0x6DAC410", VA = "0x186DADC10")]
	private APIEBLCJJPB PBBNMOPPJEN(byte IGNBGDBAAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE1A0", Offset = "0x6DAC9A0", VA = "0x186DAE1A0")]
	internal IOJOOLBIBAE(IFOIFEECBLM LDOFAFFCGAM, IPEndPoint NEGIEBGCAGJ, int MLBCMOLHELH, byte PHFOLMNHLCP, CMBFMCAKCGJ DECDNLPOOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DADFC0", Offset = "0x6DAC7C0", VA = "0x186DADFC0")]
	internal IOJOOLBIBAE(IFOIFEECBLM LDOFAFFCGAM, JOKJPMAJDPO JHLBOHEIAIJ, int MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC780", Offset = "0x6DAAF80", VA = "0x186DAC780")]
	internal void KGNNDJPIPIH(FNKNALLNMJD OOAFPBCKEDH, byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6DADDC0", Offset = "0x6DAC5C0", VA = "0x186DADDC0")]
	internal bool PEJMEAOHOJN(PNGLOFIALNK MCEIPPDGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC740", Offset = "0x6DAAF40", VA = "0x186DAC740")]
	public void INCLKNPFIPO(byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int IMNFCKGEMOH, PLCPIDHJMMI AKIEDMONOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA8C0", Offset = "0x6DA90C0", VA = "0x186DAA8C0")]
	private void AHOHOPEAPLK(byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int IMNFCKGEMOH, byte MMEIPMFAFEF, PLCPIDHJMMI BPCFIIJJHMD, object ONDFEGPOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6DABD50", Offset = "0x6DAA550", VA = "0x186DABD50")]
	public void GOCJGLJFFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6DACF40", Offset = "0x6DAB740", VA = "0x186DACF40")]
	internal FIPEEMOBJEB MOCKEJBJHPB(MHDNFEKAFBE MCEIPPDGOOF)
	{
		return default(FIPEEMOBJEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD220", Offset = "0x6DABA20", VA = "0x186DAD220")]
	internal void ONAGLEBNBAK(APIEBLCJJPB DOOLFGIGJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC0A0", Offset = "0x6DAA8A0", VA = "0x186DAC0A0")]
	internal DNNGENFFLEA HOPGGEGCMCG(byte[] NFNBKNAJBPN, int MLFBDFDDHEO, int IMNFCKGEMOH, bool IOHDICMKADP)
	{
		return default(DNNGENFFLEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC060", Offset = "0x6DAA860", VA = "0x186DAC060")]
	private void HJKDENAHAEG(int HDEOOPJNGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD280", Offset = "0x6DABA80", VA = "0x186DAD280")]
	internal void ONHJLMIBMKA(PLCPIDHJMMI DHJOJHBFIIF, MHDNFEKAFBE GOHMPMCJCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB770", Offset = "0x6DA9F70", VA = "0x186DAB770")]
	private void FKEBBOIGPIE(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC3B0", Offset = "0x6DAABB0", VA = "0x186DAC3B0")]
	private void IKGCMKPMAGP(int LMCBAJKHEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DAA700", Offset = "0x6DA8F00", VA = "0x186DAA700")]
	internal OAOFHDFMOEB AEMOEPKJHNA(FNKNALLNMJD KPCGJLBCEPB)
	{
		return default(OAOFHDFMOEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6DAAE60", Offset = "0x6DA9660", VA = "0x186DAAE60")]
	internal void BJIINABMHEP(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DAB600", Offset = "0x6DA9E00", VA = "0x186DAB600")]
	private void DLEGHLLONBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAD020", Offset = "0x6DAB820", VA = "0x186DAD020")]
	internal void NBOPNHAMLGO(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAC880", Offset = "0x6DAB080", VA = "0x186DAC880")]
	internal void MAEEPMKIKNH(int LMCBAJKHEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6DABDA0", Offset = "0x6DAA5A0", VA = "0x186DABDA0")]
	internal void HDGFLOMKFAP(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JPPLHJENPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long GFFLMFDHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long DDLIGPIKEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long MLHMIPJLEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long BAKGOGICFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long LFACAPOADGN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long LCJKJMIAOPE;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long GPFDILFDKHF;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long EBKBHMIAKOP;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long LDEGOCPKNHB;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long EMDDKECGLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long DJLAPGMCBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long NINICFMNGKN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long PFCMEPJCMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF030", Offset = "0x6DAD830", VA = "0x186DAF030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KJBPAMFBOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEE60", Offset = "0x6DAD660", VA = "0x186DAEE60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long CHNJKMEJGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEFB0", Offset = "0x6DAD7B0", VA = "0x186DAEFB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long JFAHPKPEDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF020", Offset = "0x6DAD820", VA = "0x186DAF020")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long CNJFCGCCNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF1B0", Offset = "0x6DAD9B0", VA = "0x186DAF1B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long FIDODADKPCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEE50", Offset = "0x6DAD650", VA = "0x186DAEE50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long LDFDLHFPENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEED0", Offset = "0x6DAD6D0", VA = "0x186DAEED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long ELNKKNGFOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF170", Offset = "0x6DAD970", VA = "0x186DAF170")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private DCGNJCMCJLL PGAGFNCJAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEEC0", Offset = "0x6DAD6C0", VA = "0x186DAEEC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double FILLMAPGACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEFC0", Offset = "0x6DAD7C0", VA = "0x186DAEFC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF1C0", Offset = "0x6DAD9C0", VA = "0x186DAF1C0")]
	public void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF260", Offset = "0x6DADA60", VA = "0x186DAF260")]
	public void PHGLFPKPCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEE70", Offset = "0x6DAD670", VA = "0x186DAEE70")]
	public void EIAHOBPBAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF110", Offset = "0x6DAD910", VA = "0x186DAF110")]
	public void MKPHINHPBMF(long HKBBCAKCMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF200", Offset = "0x6DADA00", VA = "0x186DAF200")]
	public void PBCDGFOJNAP(long PAJGAJFMFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF0B0", Offset = "0x6DAD8B0", VA = "0x186DAF0B0")]
	public void LOCEHFBPCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF040", Offset = "0x6DAD840", VA = "0x186DAF040")]
	public void LNPCBHBGBME(long FJPOLGJBDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF2C0", Offset = "0x6DADAC0", VA = "0x186DAF2C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEF10", Offset = "0x6DAD710", VA = "0x186DAEF10")]
	public void GHOPPHMOOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public JPPLHJENPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JFNGJPEPEHP
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> EOMGNEPCNFI;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE7B0", Offset = "0x6DACFB0", VA = "0x186DAE7B0")]
	public static IPEndPoint GIAIBNFFLON(string EHHPFDLGFLC, int IFDAMJHJJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEA00", Offset = "0x6DAD200", VA = "0x186DAEA00")]
	public static IPAddress KOAPIPDAGNP(string EHHPFDLGFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEBD0", Offset = "0x6DAD3D0", VA = "0x186DAEBD0")]
	public static IPAddress KOAPIPDAGNP(string EHHPFDLGFLC, AddressFamily DHMCMGCKCFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE780", Offset = "0x6DACF80", VA = "0x186DAE780")]
	internal static int FMHMCDHKNIA(int FDHAEHAFJOL, int DLFHPGCLELE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x3806FB0", Offset = "0x38057B0", VA = "0x183806FB0")]
	internal static T[] CDBLIAPPHEL<T>(int PCFOAHIEPDL) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BLEGFINIIAC : APIEBLCJJPB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct IMFKAAJMCAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private MHDNFEKAFBE CGDJGCBOJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long FAMOCJNFDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool DENJCOINLNB;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA660", Offset = "0x6DA8E60", VA = "0x186DAA660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA580", Offset = "0x6DA8D80", VA = "0x186DAA580")]
		public void ILJHHMHPGDK(MHDNFEKAFBE MCEIPPDGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA5F0", Offset = "0x6DA8DF0", VA = "0x186DAA5F0")]
		public bool OBHJGPMJKLP(long NAOOGCLJBCC, IOJOOLBIBAE EAFDOIEFHMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6DAA5A0", Offset = "0x6DA8DA0", VA = "0x186DAA5A0")]
		public bool NNEMBDPLFBE(IOJOOLBIBAE EAFDOIEFHMG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly MHDNFEKAFBE LBCBHKNMPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly IMFKAAJMCAP[] DPGKFEBJEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly MHDNFEKAFBE[] LCJMOCALMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] GCELEAJMALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int BKDGAJKNBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int BHFAEEPPDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int OLMGNAAFFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int EFMPDLALAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool CPDINADGCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly PLCPIDHJMMI PPDHJEMAKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool DKGEMCKHOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int FGOMAJFFMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte EOECEPJOAAN;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F000", Offset = "0x6D9D800", VA = "0x186D9F000")]
	public BLEGFINIIAC(IOJOOLBIBAE EAFDOIEFHMG, bool AADANAMGGED, byte MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E770", Offset = "0x6D9CF70", VA = "0x186D9E770")]
	private void BPHFKANFDDH(MHDNFEKAFBE MCEIPPDGOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EB30", Offset = "0x6D9D330", VA = "0x186D9EB30", Slot = "4")]
	protected override bool PDLIHAMFOPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E110", Offset = "0x6D9C910", VA = "0x186D9E110", Slot = "5")]
	public override bool BJIINABMHEP(MHDNFEKAFBE MCEIPPDGOOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class HDJJJNEFFOC : APIEBLCJJPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int IELPOMDADLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort BHFAEEPPDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool ANFBKDGGNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private MHDNFEKAFBE GNBLPHLLGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly MHDNFEKAFBE PCFOHIAHAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool JAMFNHDFAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte EOECEPJOAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long NLPOGPADMGI;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2570", Offset = "0x6DA0D70", VA = "0x186DA2570")]
	public HDJJJNEFFOC(IOJOOLBIBAE EAFDOIEFHMG, bool OPFMMGAPIHA, byte MLBCMOLHELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6DA20B0", Offset = "0x6DA08B0", VA = "0x186DA20B0", Slot = "4")]
	protected override bool PDLIHAMFOPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1DD0", Offset = "0x6DA05D0", VA = "0x186DA1DD0", Slot = "5")]
	public override bool BJIINABMHEP(MHDNFEKAFBE MCEIPPDGOOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EEHEONBLKJA
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EKNHLDKNPCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong FJLBIIGDHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double BMIOLEJHKKA;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct GLLCMIMEFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int BENENDBIOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float GLJCJACPJBG;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C1F0", Offset = "0x6D9A9F0", VA = "0x186D9C1F0")]
	private static void EDJPOEEFAMB(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, ulong NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0440", Offset = "0x6D9EC40", VA = "0x186DA0440")]
	private static void EDJPOEEFAMB(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, int NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA04B0", Offset = "0x6D9ECB0", VA = "0x186DA04B0")]
	public static void EDJPOEEFAMB(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, short NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0500", Offset = "0x6D9ED00", VA = "0x186DA0500")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, double OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0520", Offset = "0x6D9ED20", VA = "0x186DA0520")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA04B0", Offset = "0x6D9ECB0", VA = "0x186DA04B0")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, short OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA04B0", Offset = "0x6D9ECB0", VA = "0x186DA04B0")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, ushort OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0440", Offset = "0x6D9EC40", VA = "0x186DA0440")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0440", Offset = "0x6D9EC40", VA = "0x186DA0440")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, uint OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6DA04F0", Offset = "0x6D9ECF0", VA = "0x186DA04F0")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, long OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6DA04F0", Offset = "0x6D9ECF0", VA = "0x186DA04F0")]
	public static void FLLONJAPKKH(byte[] FLMLKMBDILC, int IFOFOJHAFEG, ulong OPMIAMEJKDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KKKJNIJJMGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] CJGIMNHODLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int LEPDGHHJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int MJBPLGFGBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int MKHMJEBKMPI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] CAFGDPEPPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CGLNPMLANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int ONMDLNJCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0530", Offset = "0x6DAED30", VA = "0x186DB0530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BJLGNBEFKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x263FE00", Offset = "0x263E600", VA = "0x18263FE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DLHMALINDOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6DB09F0", Offset = "0x6DAF1F0", VA = "0x186DB09F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0410", Offset = "0x6DAEC10", VA = "0x186DB0410")]
	public void GMDOLGGBNHB(byte[] MDFGJCKGNHP, int BFKGIFAKMAP, int IGDODBOHILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public KKKJNIJJMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0AC0", Offset = "0x6DAF2C0", VA = "0x186DB0AC0")]
	public KKKJNIJJMGH(byte[] MDFGJCKGNHP, int BFKGIFAKMAP, int IGDODBOHILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB02D0", Offset = "0x6DAEAD0", VA = "0x186DB02D0")]
	public IPEndPoint FMAMMBPPDBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFF40", Offset = "0x6DAE740", VA = "0x186DAFF40")]
	public byte DDOKMHPIEPO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFF40", Offset = "0x6DAE740", VA = "0x186DAFF40")]
	public sbyte IAAKCAGINOI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x383E050", Offset = "0x383C850", VA = "0x18383E050")]
	public T[] LGMMLONBGMB<T>(ushort LBLAFDELPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0A00", Offset = "0x6DAF200", VA = "0x186DB0A00")]
	public bool[] PFLHFNHCGHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6DB08A0", Offset = "0x6DAF0A0", VA = "0x186DB08A0")]
	public ushort[] KICDNDBCPLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFEC0", Offset = "0x6DAE6C0", VA = "0x186DAFEC0")]
	public short[] CJDEKGADLCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0A40", Offset = "0x6DAF240", VA = "0x186DB0A40")]
	public int[] PHBCEKAEFLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6DB09B0", Offset = "0x6DAF1B0", VA = "0x186DB09B0")]
	public uint[] OMNEHALDJEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0820", Offset = "0x6DAF020", VA = "0x186DB0820")]
	public float[] JODGIJJLGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0770", Offset = "0x6DAEF70", VA = "0x186DB0770")]
	public double[] IMEJABMLPDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFF00", Offset = "0x6DAE700", VA = "0x186DAFF00")]
	public long[] CJKHNKNFPMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0A80", Offset = "0x6DAF280", VA = "0x186DB0A80")]
	public ulong[] PLCEIAECLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0540", Offset = "0x6DAED40", VA = "0x186DB0540")]
	public string[] HIADBJAHDPO(int DDEHMNJCIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0950", Offset = "0x6DAF150", VA = "0x186DB0950")]
	public bool NGKLMLKGFHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB04C0", Offset = "0x6DAECC0", VA = "0x186DB04C0")]
	public char LLKHEGABNFH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB04C0", Offset = "0x6DAECC0", VA = "0x186DB04C0")]
	public ushort HAKOAAEGCAK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0700", Offset = "0x6DAEF00", VA = "0x186DB0700")]
	public short ILJMIEBFPOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB08E0", Offset = "0x6DAF0E0", VA = "0x186DB08E0")]
	public long MADDEBPHJEE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0450", Offset = "0x6DAEC50", VA = "0x186DB0450")]
	public ulong GOABMKFPGBD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6DB01F0", Offset = "0x6DAE9F0", VA = "0x186DB01F0")]
	public int FADAAMKHIIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0690", Offset = "0x6DAEE90", VA = "0x186DB0690")]
	public uint HJAELBFKKEM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6DB03A0", Offset = "0x6DAEBA0", VA = "0x186DB03A0")]
	public float GAPMKNIFDGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6DB07B0", Offset = "0x6DAEFB0", VA = "0x186DB07B0")]
	public double JICDGANMPIB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFF80", Offset = "0x6DAE780", VA = "0x186DAFF80")]
	public string DLJEFEGHCIF(int CFPHIOFNMLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0260", Offset = "0x6DAEA60", VA = "0x186DB0260")]
	public ArraySegment<byte> FGCILIJKLLL(int PCFOAHIEPDL)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6DB01B0", Offset = "0x6DAE9B0", VA = "0x186DB01B0")]
	public sbyte[] DMNNCLEKPNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0860", Offset = "0x6DAF060", VA = "0x186DB0860")]
	public byte[] KEINDMHLJGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0990", Offset = "0x6DAF190", VA = "0x186DB0990")]
	public void NNEMBDPLFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CMBFMCAKCGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] CJGIMNHODLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int LEPDGHHJIBO;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int MEBNLKLDPPH = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool EFNEMJODJFO;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding HHLAKJOAKMN;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int HMGKKJOAKJD = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] MJBNLAGMIEA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] BADLMALNNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int GJDKFIAMFHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0320", Offset = "0x6D9EB20", VA = "0x186DA0320")]
	public CMBFMCAKCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA03A0", Offset = "0x6D9EBA0", VA = "0x186DA03A0")]
	public CMBFMCAKCGJ(bool MACEJLHOPHH, int PPEMPILPLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F6E0", Offset = "0x6D9DEE0", VA = "0x186D9F6E0")]
	public static CMBFMCAKCGJ BADGNPPKOJM(string OPMIAMEJKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F750", Offset = "0x6D9DF50", VA = "0x186D9F750")]
	public void INGALBPBOGA(int DAMNAOHIEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xCF4B40", Offset = "0xCF3340", VA = "0x180CF4B40")]
	public void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0200", Offset = "0x6D9EA00", VA = "0x186DA0200")]
	public void OHDBJPMBMBB(float OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FC40", Offset = "0x6D9E440", VA = "0x186D9FC40")]
	public void OHDBJPMBMBB(double OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FCF0", Offset = "0x6D9E4F0", VA = "0x186D9FCF0")]
	public void OHDBJPMBMBB(long OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FCF0", Offset = "0x6D9E4F0", VA = "0x186D9FCF0")]
	public void OHDBJPMBMBB(ulong OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0170", Offset = "0x6D9E970", VA = "0x186DA0170")]
	public void OHDBJPMBMBB(int OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0170", Offset = "0x6D9E970", VA = "0x186DA0170")]
	public void OHDBJPMBMBB(uint OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FD40", Offset = "0x6D9E540", VA = "0x186D9FD40")]
	public void OHDBJPMBMBB(char OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FD40", Offset = "0x6D9E540", VA = "0x186D9FD40")]
	public void OHDBJPMBMBB(ushort OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FD40", Offset = "0x6D9E540", VA = "0x186D9FD40")]
	public void OHDBJPMBMBB(short OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FC90", Offset = "0x6D9E490", VA = "0x186D9FC90")]
	public void OHDBJPMBMBB(sbyte OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FC90", Offset = "0x6D9E490", VA = "0x186D9FC90")]
	public void OHDBJPMBMBB(byte OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0100", Offset = "0x6D9E900", VA = "0x186DA0100")]
	public void OHDBJPMBMBB(byte[] NFNBKNAJBPN, int BFKGIFAKMAP, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F600", Offset = "0x6D9DE00", VA = "0x186D9F600")]
	public void OMDCDMILHBP(sbyte[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F600", Offset = "0x6D9DE00", VA = "0x186D9F600")]
	public void AJOFHELDJAH(byte[] NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FDC0", Offset = "0x6D9E5C0", VA = "0x186D9FDC0")]
	public void OHDBJPMBMBB(bool OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F9B0", Offset = "0x6D9E1B0", VA = "0x186D9F9B0")]
	public void NJBDAEGEELJ(Array IOKIAEJLJPI, int HOIGPMKOIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F8D0", Offset = "0x6D9E0D0", VA = "0x186D9F8D0")]
	public void NJBDAEGEELJ(float[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA90", Offset = "0x6D9E290", VA = "0x186D9FA90")]
	public void NJBDAEGEELJ(double[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA90", Offset = "0x6D9E290", VA = "0x186D9FA90")]
	public void NJBDAEGEELJ(long[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA90", Offset = "0x6D9E290", VA = "0x186D9FA90")]
	public void NJBDAEGEELJ(ulong[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F8D0", Offset = "0x6D9E0D0", VA = "0x186D9F8D0")]
	public void NJBDAEGEELJ(int[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F8D0", Offset = "0x6D9E0D0", VA = "0x186D9F8D0")]
	public void NJBDAEGEELJ(uint[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F7F0", Offset = "0x6D9DFF0", VA = "0x186D9F7F0")]
	public void NJBDAEGEELJ(ushort[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F7F0", Offset = "0x6D9DFF0", VA = "0x186D9F7F0")]
	public void NJBDAEGEELJ(short[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F600", Offset = "0x6D9DE00", VA = "0x186D9F600")]
	public void NJBDAEGEELJ(bool[] OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FB70", Offset = "0x6D9E370", VA = "0x186D9FB70")]
	public void NJBDAEGEELJ(string[] OPMIAMEJKDH, int COEKHCCIFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FE20", Offset = "0x6D9E620", VA = "0x186D9FE20")]
	public void OHDBJPMBMBB(IPEndPoint OKMHFFMMIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FDB0", Offset = "0x6D9E5B0", VA = "0x186D9FDB0")]
	public void OHDBJPMBMBB(string OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FEF0", Offset = "0x6D9E6F0", VA = "0x186D9FEF0")]
	public void OHDBJPMBMBB(string OPMIAMEJKDH, int CFPHIOFNMLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AMNLGHJGBNC
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class CFLGLCJDIHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong NGHJMEDCGPM;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x63E58D0", Offset = "0x63E40D0", VA = "0x1863E58D0")]
		static CFLGLCJDIHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void PLJILIHOHCD(KKKJNIJJMGH DMPKKEDJKBJ, object ONDFEGPOKLD);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OEDJAALGLFO<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AMNLGHJGBNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public OEDJAALGLFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5467120", Offset = "0x5465920", VA = "0x185467120")]
		internal void FJMFHJOLPAE(KKKJNIJJMGH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class HHMPPCGFCIO<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AMNLGHJGBNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HHMPPCGFCIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4F230", Offset = "0x4A4DA30", VA = "0x184A4F230")]
		internal void FJMFHJOLPAE(KKKJNIJJMGH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly KDCNENOJJMF NIJGNNKCALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, PLJILIHOHCD> MBKNAFLNGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly CMBFMCAKCGJ IBNBDGHDPLB;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CA30", Offset = "0x6D9B230", VA = "0x186D9CA30")]
	public AMNLGHJGBNC(int DDEHMNJCIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x358A3C0", Offset = "0x3588BC0", VA = "0x18358A3C0", Slot = "4")]
	protected virtual ulong AAPOGCKAEOL<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C900", Offset = "0x6D9B100", VA = "0x186D9C900", Slot = "5")]
	protected virtual PLJILIHOHCD NKNGJGGABNP(KKKJNIJJMGH DMPKKEDJKBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3F0EE10", Offset = "0x3F0D610", VA = "0x183F0EE10", Slot = "6")]
	protected virtual void HGFKLLMPDAP<T>(CMBFMCAKCGJ HIKMEOJBJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C830", Offset = "0x6D9B030", VA = "0x186D9C830")]
	public void JJOLPGMIJEC(KKKJNIJJMGH DMPKKEDJKBJ, object ONDFEGPOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3F0ED60", Offset = "0x3F0D560", VA = "0x183F0ED60")]
	public void AMAEHFOLFGF<T>(CMBFMCAKCGJ HIKMEOJBJOJ, T MCEIPPDGOOF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C8B0", Offset = "0x6D9B0B0", VA = "0x186D9C8B0")]
	public void LPBODEGNKCH(KKKJNIJJMGH DMPKKEDJKBJ, object ONDFEGPOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3F0F040", Offset = "0x3F0D840", VA = "0x183F0F040")]
	public void KDMGNCEFHPE<T>(Action<T> FIMKIABIEMM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3F0EE80", Offset = "0x3F0D680", VA = "0x183F0EE80")]
	public void KDMGNCEFHPE<T, TUserData>(Action<T, TUserData> FIMKIABIEMM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IDPPGENBJLL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F5F0", Offset = "0x6D9DDF0", VA = "0x186D9F5F0")]
	public IDPPGENBJLL(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class AGEFHIHOBMB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C7D0", Offset = "0x6D9AFD0", VA = "0x186D9C7D0")]
	public AGEFHIHOBMB(string NJAAPDELBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class KDCNENOJJMF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum BCCEPMGHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class NJPFMMNOAFP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public BCCEPMGHPMG PALJBODIBGP;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x534D9F0", Offset = "0x534C1F0", VA = "0x18534D9F0", Slot = "4")]
		public virtual void ILJHHMHPGDK(MethodInfo FLMIJEKCHNK, MethodInfo LCIPGDGKCON, BCCEPMGHPMG PIJHKCJDAHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void AEKODBDMANG(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void IACCDGEHCKC(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		protected NJPFMMNOAFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class POFPGJKHJJK<TClass, TProperty> : NJPFMMNOAFP<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> CHMBAKFKLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> AKNEDIEEGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> CJPCEKDLKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> CBAJIIBECIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> BJMLDLOAPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> BNPNDNKDBHK;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5589FD0", Offset = "0x55887D0", VA = "0x185589FD0", Slot = "7")]
		public override void MAKEJDDOIBA(TClass DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x558B230", Offset = "0x5589A30", VA = "0x18558B230", Slot = "8")]
		public override void OCOHCOEGFIK(TClass DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5583CA0", Offset = "0x55824A0", VA = "0x185583CA0", Slot = "9")]
		public override void AEKODBDMANG(TClass DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5584C90", Offset = "0x5583490", VA = "0x185584C90", Slot = "10")]
		public override void IACCDGEHCKC(TClass DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5584640", Offset = "0x5582E40", VA = "0x185584640")]
		protected TProperty[] HKJNOKILHJE(TClass DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5589BD0", Offset = "0x55883D0", VA = "0x185589BD0")]
		protected TProperty[] JGKMDNFPAMC(TClass DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5585850", Offset = "0x5584050", VA = "0x185585850", Slot = "4")]
		public override void ILJHHMHPGDK(MethodInfo FLMIJEKCHNK, MethodInfo LCIPGDGKCON, BCCEPMGHPMG PIJHKCJDAHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4436F50", Offset = "0x4435750", VA = "0x184436F50")]
		protected POFPGJKHJJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class CPKOLOKINHC<TClass, TProperty> : POFPGJKHJJK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void MOEKIJPIDAN(KKKJNIJJMGH GGILEDABHIF, [Out] TProperty KAFFEELNDFI);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void DLMLHMBDLMC(CMBFMCAKCGJ FHHDKECCOLA, TProperty KAFFEELNDFI);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x64E4080", Offset = "0x64E2880", VA = "0x1864E4080", Slot = "5")]
		public override void OABFAPACBPL(TClass DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x64E3D60", Offset = "0x64E2560", VA = "0x1864E3D60", Slot = "6")]
		public override void AMAEHFOLFGF(TClass DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x64E3E60", Offset = "0x64E2660", VA = "0x1864E3E60", Slot = "7")]
		public override void MAKEJDDOIBA(TClass DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x64E41E0", Offset = "0x64E29E0", VA = "0x1864E41E0", Slot = "8")]
		public override void OCOHCOEGFIK(TClass DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4B97B30", Offset = "0x4B96330", VA = "0x184B97B30")]
		protected CPKOLOKINHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class MDFFBOOOCGI<T> : POFPGJKHJJK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x51F1880", Offset = "0x51F0080", VA = "0x1851F1880", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x51F1790", Offset = "0x51EFF90", VA = "0x1851F1790", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x51F1800", Offset = "0x51F0000", VA = "0x1851F1800", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x51F1900", Offset = "0x51F0100", VA = "0x1851F1900", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public MDFFBOOOCGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class MDPLDLIKOMH<T> : POFPGJKHJJK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x51F3400", Offset = "0x51F1C00", VA = "0x1851F3400", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x51F1790", Offset = "0x51EFF90", VA = "0x1851F1790", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x51F3380", Offset = "0x51F1B80", VA = "0x1851F3380", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x51F1900", Offset = "0x51F0100", VA = "0x1851F1900", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public MDPLDLIKOMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FAPCDHFCCHJ<T> : POFPGJKHJJK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4860110", Offset = "0x485E910", VA = "0x184860110", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4860020", Offset = "0x485E820", VA = "0x184860020", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4860090", Offset = "0x485E890", VA = "0x184860090", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4860190", Offset = "0x485E990", VA = "0x184860190", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public FAPCDHFCCHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class LMCGMFLLPMP<T> : POFPGJKHJJK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x500E960", Offset = "0x500D160", VA = "0x18500E960", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4860020", Offset = "0x485E820", VA = "0x184860020", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x500E8E0", Offset = "0x500D0E0", VA = "0x18500E8E0", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4860190", Offset = "0x485E990", VA = "0x184860190", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public LMCGMFLLPMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MCJGIOJDDNG<T> : POFPGJKHJJK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x51EF3C0", Offset = "0x51EDBC0", VA = "0x1851EF3C0", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x51EF2D0", Offset = "0x51EDAD0", VA = "0x1851EF2D0", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x51EF340", Offset = "0x51EDB40", VA = "0x1851EF340", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4B70CB0", Offset = "0x4B6F4B0", VA = "0x184B70CB0", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public MCJGIOJDDNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class MDHIGMPHIIN<T> : POFPGJKHJJK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x51F2290", Offset = "0x51F0A90", VA = "0x1851F2290", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x51EF2D0", Offset = "0x51EDAD0", VA = "0x1851EF2D0", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x51F2210", Offset = "0x51F0A10", VA = "0x1851F2210", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B70CB0", Offset = "0x4B6F4B0", VA = "0x184B70CB0", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public MDHIGMPHIIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class JCJDFPHLCNH<T> : POFPGJKHJJK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4956480", Offset = "0x4954C80", VA = "0x184956480", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4956390", Offset = "0x4954B90", VA = "0x184956390", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4D5B610", Offset = "0x4D59E10", VA = "0x184D5B610", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4956500", Offset = "0x4954D00", VA = "0x184956500", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public JCJDFPHLCNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AABBLEBMBMM<T> : POFPGJKHJJK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4956480", Offset = "0x4954C80", VA = "0x184956480", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4956390", Offset = "0x4954B90", VA = "0x184956390", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4956400", Offset = "0x4954C00", VA = "0x184956400", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4956500", Offset = "0x4954D00", VA = "0x184956500", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public AABBLEBMBMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class NDBHFDNHIPB<T> : POFPGJKHJJK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x52DF200", Offset = "0x52DDA00", VA = "0x1852DF200", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x52DF110", Offset = "0x52DD910", VA = "0x1852DF110", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x52DF180", Offset = "0x52DD980", VA = "0x1852DF180", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x51F1900", Offset = "0x51F0100", VA = "0x1851F1900", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public NDBHFDNHIPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class IGCBPNMBKNO<T> : POFPGJKHJJK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4B70C30", Offset = "0x4B6F430", VA = "0x184B70C30", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4B70B40", Offset = "0x4B6F340", VA = "0x184B70B40", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4B70BB0", Offset = "0x4B6F3B0", VA = "0x184B70BB0", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4B70CB0", Offset = "0x4B6F4B0", VA = "0x184B70CB0", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public IGCBPNMBKNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class LGPEPDFPMNK<T> : POFPGJKHJJK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4FDD5D0", Offset = "0x4FDBDD0", VA = "0x184FDD5D0", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FDD4E0", Offset = "0x4FDBCE0", VA = "0x184FDD4E0", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4FDD550", Offset = "0x4FDBD50", VA = "0x184FDD550", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4956500", Offset = "0x4954D00", VA = "0x184956500", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4860200", Offset = "0x485EA00", VA = "0x184860200")]
		public LGPEPDFPMNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KMEJFGNHBLM<T> : CPKOLOKINHC<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C5D0", Offset = "0x4F3ADD0", VA = "0x184F3C5D0", Slot = "12")]
		protected override void DLMLHMBDLMC(CMBFMCAKCGJ FHHDKECCOLA, char KAFFEELNDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C600", Offset = "0x4F3AE00", VA = "0x184F3C600", Slot = "11")]
		protected override void MOEKIJPIDAN(KKKJNIJJMGH GGILEDABHIF, [Out] char KAFFEELNDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
		public KMEJFGNHBLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class IMFKMJFCLJF<T> : CPKOLOKINHC<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4B843D0", Offset = "0x4B82BD0", VA = "0x184B843D0", Slot = "12")]
		protected override void DLMLHMBDLMC(CMBFMCAKCGJ FHHDKECCOLA, IPEndPoint KAFFEELNDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4B84400", Offset = "0x4B82C00", VA = "0x184B84400", Slot = "11")]
		protected override void MOEKIJPIDAN(KKKJNIJJMGH GGILEDABHIF, [Out] IPEndPoint KAFFEELNDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x43AA000", Offset = "0x43A8800", VA = "0x1843AA000")]
		public IMFKMJFCLJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class OFACBFKNGLG<T> : POFPGJKHJJK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int DEMFFEENDON;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x546A270", Offset = "0x5468A70", VA = "0x18546A270")]
		public OFACBFKNGLG(int CFPHIOFNMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x546A170", Offset = "0x5468970", VA = "0x18546A170", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x546A070", Offset = "0x5468870", VA = "0x18546A070", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x546A0F0", Offset = "0x54688F0", VA = "0x18546A0F0", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x546A1F0", Offset = "0x54689F0", VA = "0x18546A1F0", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BBDJENLBPGD<T> : NJPFMMNOAFP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo JCNPKOPOKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type PAOEGJHNLGA;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D91610", Offset = "0x5D8FE10", VA = "0x185D91610")]
		public BBDJENLBPGD(PropertyInfo KIIAJPLCJIE, Type NIAPHHDHJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D914F0", Offset = "0x5D8FCF0", VA = "0x185D914F0", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D91380", Offset = "0x5D8FB80", VA = "0x185D91380", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D91490", Offset = "0x5D8FC90", VA = "0x185D91490", Slot = "7")]
		public override void MAKEJDDOIBA(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D915B0", Offset = "0x5D8FDB0", VA = "0x185D915B0", Slot = "8")]
		public override void OCOHCOEGFIK(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D91320", Offset = "0x5D8FB20", VA = "0x185D91320", Slot = "9")]
		public override void AEKODBDMANG(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D91430", Offset = "0x5D8FC30", VA = "0x185D91430", Slot = "10")]
		public override void IACCDGEHCKC(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class OEABIHEFKCI<T> : BBDJENLBPGD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x48E8AC0", Offset = "0x48E72C0", VA = "0x1848E8AC0")]
		public OEABIHEFKCI(PropertyInfo KIIAJPLCJIE, Type NIAPHHDHJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5466660", Offset = "0x5464E60", VA = "0x185466660", Slot = "5")]
		public override void OABFAPACBPL(T DHOMPJEKJNK, KKKJNIJJMGH GGILEDABHIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x54665B0", Offset = "0x5464DB0", VA = "0x1854665B0", Slot = "6")]
		public override void AMAEHFOLFGF(T DHOMPJEKJNK, CMBFMCAKCGJ FHHDKECCOLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class GNFHGDHGHKP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static GNFHGDHGHKP<T> DJLOIKDDKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly NJPFMMNOAFP<T>[] IBLIPOMDKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int AANOAFOMNPI;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x49D4FF0", Offset = "0x49D37F0", VA = "0x1849D4FF0")]
		public GNFHGDHGHKP(List<NJPFMMNOAFP<T>> BMPOHLOBJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x49D4E90", Offset = "0x49D3690", VA = "0x1849D4E90")]
		public void AMAEHFOLFGF(T PNHCNFOFAFI, CMBFMCAKCGJ HIKMEOJBJOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x49D4F40", Offset = "0x49D3740", VA = "0x1849D4F40")]
		public void OABFAPACBPL(T PNHCNFOFAFI, KKKJNIJJMGH DMPKKEDJKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class NOANPFHGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract NJPFMMNOAFP<T> EFPADONOPCC<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private CMBFMCAKCGJ MKFKEGHKPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int JJEDLGODMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, NOANPFHGNCE> MOBFEAKCMAH;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF600", Offset = "0x6DADE00", VA = "0x186DAF600")]
	public KDCNENOJJMF(int DDEHMNJCIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3835210", Offset = "0x3833A10", VA = "0x183835210")]
	private GNFHGDHGHKP<T> BFAHCBPFOPE<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x358DAE0", Offset = "0x358C2E0", VA = "0x18358DAE0")]
	public void JNEAPGDNFGC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x38363C0", Offset = "0x3834BC0", VA = "0x1838363C0")]
	public bool MPBEICGIKAG<T>(KKKJNIJJMGH DMPKKEDJKBJ, T ALLFIKNKLHM) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3836330", Offset = "0x3834B30", VA = "0x183836330")]
	public void LIJGMGKAKKG<T>(CMBFMCAKCGJ HIKMEOJBJOJ, T PNHCNFOFAFI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class APJMNMLBNEG
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime FFIJLNLIJGD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] PCMFLLPELIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MPDNBGCKHIJ KHKOAIFCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D6B0", Offset = "0x6D9BEB0", VA = "0x186D9D6B0")]
		get
		{
			return default(MPDNBGCKHIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JFHJBFPKKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DC30", Offset = "0x6D9C430", VA = "0x186D9DC30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D840", Offset = "0x6D9C040", VA = "0x186D9D840")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FJNKJOIECBI POPKGEDJDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D6E0", Offset = "0x6D9BEE0", VA = "0x186D9D6E0")]
		get
		{
			return default(FJNKJOIECBI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CF70", Offset = "0x6D9B770", VA = "0x186D9CF70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int KHGKJOBKKOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D910", Offset = "0x6D9C110", VA = "0x186D9D910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint PAGOOOANFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DC60", Offset = "0x6D9C460", VA = "0x186D9DC60")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? HOHOMAECALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CD70", Offset = "0x6D9B570", VA = "0x186D9CD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? FOJPCBDHMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D390", Offset = "0x6D9BB90", VA = "0x186D9D390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? EINAIOLDGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D3C0", Offset = "0x6D9BBC0", VA = "0x186D9D3C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D9CDA0", Offset = "0x6D9B5A0", VA = "0x186D9CDA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? LOKLLKIBHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xBEBD90", Offset = "0xBEA590", VA = "0x180BEBD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xDA40F0", Offset = "0xDA28F0", VA = "0x180DA40F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DD40", Offset = "0x6D9C540", VA = "0x186D9DD40")]
	public APJMNMLBNEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E060", Offset = "0x6D9C860", VA = "0x186D9E060")]
	internal APJMNMLBNEG(byte[] FLMLKMBDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DB10", Offset = "0x6D9C310", VA = "0x186D9DB10")]
	public static APJMNMLBNEG LOPHFDMIHDK(byte[] FLMLKMBDILC, DateTime CHIAACOACBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6D9CFB0", Offset = "0x6D9B7B0", VA = "0x186D9CFB0")]
	internal void FFPFCLFHJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D1B0", Offset = "0x6D9B9B0", VA = "0x186D9D1B0")]
	private void FJKGMNNGMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D4B0", Offset = "0x6D9BCB0", VA = "0x186D9D4B0")]
	private DateTime? GICJLHFMEBJ(int BFKGIFAKMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D940", Offset = "0x6D9C140", VA = "0x186D9D940")]
	private void LMBPFDMOJAA(int BFKGIFAKMAP, DateTime? OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D710", Offset = "0x6D9BF10", VA = "0x186D9D710")]
	private ulong IFJBMHALNOJ(int BFKGIFAKMAP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D3F0", Offset = "0x6D9BBF0", VA = "0x186D9D3F0")]
	private void GGALAFPFOKK(int BFKGIFAKMAP, ulong OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D880", Offset = "0x6D9C080", VA = "0x186D9D880")]
	private uint KEJBCNANABC(int BFKGIFAKMAP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C68E90", Offset = "0x6C67690", VA = "0x186C68E90")]
	private static uint JFFIFKNPKOO(uint LEFBJAGNHCD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D7E0", Offset = "0x6D9BFE0", VA = "0x186D9D7E0")]
	private static ulong JFFIFKNPKOO(ulong LEFBJAGNHCD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum MPDNBGCKHIJ
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
public enum FJNKJOIECBI
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LBFOKNDGJBF
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int ADHHNICGDKB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int OGMDBHMAMDP = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int OHIHKGDIHEL = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint JOMLLJJDFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int OJHAHGBNBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int ADBJALPHGKA;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool KIIIALHCOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0B20", Offset = "0x6DAF320", VA = "0x186DB0B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0B30", Offset = "0x6DAF330", VA = "0x186DB0B30")]
	public bool INCLKNPFIPO(FCLHOGCCINP GLIMIFHIGMB, int OIKKJHNFKFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class KGMINDNHBLL : FCLHOGCCINP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket GLIMIFHIGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly IFOIFEECBLM LDOFAFFCGAM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short KOHJEMNJDDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF6C0", Offset = "0x6DADEC0", VA = "0x186DAF6C0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int JEGOKLHCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6DAFCA0", Offset = "0x6DAE4A0", VA = "0x186DAFCA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint KEAEAFOEGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF6A0", Offset = "0x6DADEA0", VA = "0x186DAF6A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily NBFCPNODNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4FB3B30", Offset = "0x4FB2330", VA = "0x184FB3B30", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFE10", Offset = "0x6DAE610", VA = "0x186DAFE10")]
	public KGMINDNHBLL(AddressFamily DHMCMGCKCFN, IFOIFEECBLM LDOFAFFCGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF6E0", Offset = "0x6DADEE0", VA = "0x186DAF6E0", Slot = "8")]
	public bool GDPGNPDDAFO(IPEndPoint OKMHFFMMIDG, JDJKOFHBLMB EDKALIPMGMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFDB0", Offset = "0x6DAE5B0", VA = "0x186DAFDB0", Slot = "9")]
	public int KPOOJFNFHCP(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, int LBLAFDELPAC, IPEndPoint NEGIEBGCAGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFCC0", Offset = "0x6DAE4C0", VA = "0x186DAFCC0", Slot = "10")]
	public int JKDJLACLLPL(byte[] HOAEKOMMHIH, EndPoint ABMMHIEFKFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFDF0", Offset = "0x6DAE5F0", VA = "0x186DAFDF0", Slot = "11")]
	public void NHECAKKNJMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface FCLHOGCCINP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short KOHJEMNJDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int JEGOKLHCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint KEAEAFOEGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily NBFCPNODNAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDPGNPDDAFO(IPEndPoint OKMHFFMMIDG, JDJKOFHBLMB EDKALIPMGMP);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KPOOJFNFHCP(byte[] HOAEKOMMHIH, int BFKGIFAKMAP, int LBLAFDELPAC, IPEndPoint NEGIEBGCAGJ);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JKDJLACLLPL(byte[] HOAEKOMMHIH, EndPoint NEGIEBGCAGJ);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NHECAKKNJMG();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct BLNIALOFMDO : IEquatable<BLNIALOFMDO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long LFMDMDGCHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long PPKNDOBEENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long KCOLOOFEGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int HFKKGEBLDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int OFDHJPGFDEI;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F2C0", Offset = "0x6D9DAC0", VA = "0x186D9F2C0")]
	public BLNIALOFMDO(byte[] LEHJJMPDHIA, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F380", Offset = "0x6D9DB80", VA = "0x186D9F380")]
	public BLNIALOFMDO(Span<byte> LEHJJMPDHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xA07330", Offset = "0xA05B30", VA = "0x180A07330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F1D0", Offset = "0x6D9D9D0", VA = "0x186D9F1D0", Slot = "4")]
	public bool Equals(BLNIALOFMDO PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F210", Offset = "0x6D9DA10", VA = "0x186D9F210", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class CPPBBEICAPJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] NABBCOKFNMG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NBMLAANFMKD
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void HBDOGFBPCJN(IPEndPoint LEHJJMPDHIA, Span<byte> NFNBKNAJBPN);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string LHNJOLHDCPJ = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int OHKHMKLILFL = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int JOAPJJIIKDD = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<BLNIALOFMDO, IPEndPoint> DLHAMCPMKNI;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static HBDOGFBPCJN OEBODINHOEN;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	internal void HNFFBDGKHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	internal void IJLGFKHBOFN(IPEndPoint NEGIEBGCAGJ, Span<byte> NFNBKNAJBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class OHEMLIOABEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int MAOFHBEMMGC;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9EBF30", Offset = "0x9EA730", VA = "0x1809EBF30")]
	protected OHEMLIOABEO(int LKCMOEBAHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void MDEIMJELNAJ(IPEndPoint OKMHFFMMIDG, byte[] NFNBKNAJBPN, int BFKGIFAKMAP, int IMNFCKGEMOH);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JMIPEBHKLOK(IPEndPoint OKMHFFMMIDG, byte[] NFNBKNAJBPN, int BFKGIFAKMAP, int IMNFCKGEMOH);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GHHLFJHMNNC : OHEMLIOABEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] BELIEAFHDAH;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator PDMCFOJONAP;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x2780D10", Offset = "0x277F510", VA = "0x182780D10")]
	public GHHLFJHMNNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1BD0", Offset = "0x6DA03D0", VA = "0x186DA1BD0")]
	public void NFHGGEAHDEH(IPEndPoint OKMHFFMMIDG, byte[] BELIEAFHDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6DA12E0", Offset = "0x6D9FAE0", VA = "0x186DA12E0")]
	public void IOKJODPDLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1720", Offset = "0x6D9FF20", VA = "0x186DA1720", Slot = "4")]
	public override void MDEIMJELNAJ(IPEndPoint OKMHFFMMIDG, byte[] NFNBKNAJBPN, int BFKGIFAKMAP, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA13C0", Offset = "0x6D9FBC0", VA = "0x186DA13C0", Slot = "5")]
	public override void JMIPEBHKLOK(IPEndPoint OKMHFFMMIDG, byte[] NFNBKNAJBPN, int BFKGIFAKMAP, int IMNFCKGEMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct EIMKLOGGNEL
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void HMCOLFKFMPO([NoAlias] byte* KFOHEHKMIJF, [NoAlias] byte* BELIEAFHDAH, [NoAlias] byte* HMABELENCNL, int IMNFCKGEMOH);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class JOCIHLJMJAI
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr LKJJNMILKIP;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr IDIAPMAKFBP;

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB43A0", Offset = "0x6DB2BA0", VA = "0x186DB43A0")]
		[BurstDiscard]
		private static void FFADLGKCKGP(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB4250", Offset = "0x6DB2A50", VA = "0x186DB4250")]
		private static IntPtr EKBBDNIEDIN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB46F0", Offset = "0x6DB2EF0", VA = "0x186DB46F0")]
		public static void JLDIAGODANP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
		public static void NPIOKLMMDIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6DB44C0", Offset = "0x6DB2CC0", VA = "0x186DB44C0")]
		public unsafe static void GINPGABDCGP([NoAlias] byte* KFOHEHKMIJF, [NoAlias] byte* BELIEAFHDAH, [NoAlias] byte* HMABELENCNL, int IMNFCKGEMOH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint BELIEAFHDAH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint HMABELENCNL[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint HPMKOMFBFHA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint LHFJJPKILGJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint ADGBAJLAJCN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint KCLMIBKMJLE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint PNEKKEBFOPO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint AOBKEPLONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint PEOGEGNGBJJ[8];

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0D20", Offset = "0x6D9F520", VA = "0x186DA0D20")]
	private void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0B90", Offset = "0x6D9F390", VA = "0x186DA0B90")]
	private uint EGDFHMGNJNA(uint AALALMNDJKO, int LAHNFBAFDMD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C2E0", Offset = "0x6D9AAE0", VA = "0x186D9C2E0")]
	private void GHADKGODGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C520", Offset = "0x6D9AD20", VA = "0x186D9C520")]
	private void MEMMIKOFOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C390", Offset = "0x6D9AB90", VA = "0x186D9C390")]
	private void GLECDCPGBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6D9C420", Offset = "0x6D9AC20", VA = "0x186D9C420")]
	private void JKFEHNBFAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0CC0", Offset = "0x6D9F4C0", VA = "0x186DA0CC0")]
	private void MJEMGKBNMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0610", Offset = "0x6D9EE10", VA = "0x186DA0610")]
	private unsafe void CPOPBOMLALL(byte* KFOHEHKMIJF, uint* BELIEAFHDAH, uint* HMABELENCNL, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0A30", Offset = "0x6D9F230", VA = "0x186DA0A30")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DPFMJAGPFJO([NoAlias] byte* KFOHEHKMIJF, [NoAlias] byte* BELIEAFHDAH, [NoAlias] byte* HMABELENCNL, int IMNFCKGEMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0AB0", Offset = "0x6D9F2B0", VA = "0x186DA0AB0")]
	public static void DPFMJAGPFJO(Span<byte> KFOHEHKMIJF, Span<byte> BELIEAFHDAH, Span<byte> HMABELENCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0BC0", Offset = "0x6D9F3C0", VA = "0x186DA0BC0")]
	public static void IKBCEDBJPGD(Span<byte> KFOHEHKMIJF, Span<byte> BELIEAFHDAH, Span<byte> HMABELENCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6DA05A0", Offset = "0x6D9EDA0", VA = "0x186DA05A0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BNFOAGMDEEB([NoAlias] byte* KFOHEHKMIJF, [NoAlias] byte* BELIEAFHDAH, [NoAlias] byte* HMABELENCNL, int IMNFCKGEMOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4790", Offset = "0x6DB2F90", VA = "0x186DB4790")]
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
