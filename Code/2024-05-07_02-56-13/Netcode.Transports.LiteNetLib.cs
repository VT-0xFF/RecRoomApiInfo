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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, KDPNCBELFLI
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum NGDJKDFODPJ
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
		private NetworkManager KFDOMGBPFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, KLMIPPCJNIJ> LADIBBKNANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EMHCIDGBHAF KLMALKEJJEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] EALFMFLJALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NGDJKDFODPJ FBILADKIBLE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong AJEPGNGLIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool AKOHBJDOOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x566F9F0", Offset = "0x566EBF0", VA = "0x18566F9F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x566EEA0", Offset = "0x566E0A0", VA = "0x18566EEA0")]
		public void RecRoom_SetEncryptionInfo(ulong HLBOPJOENNA, byte[] GOBGGNLGONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x566EE80", Offset = "0x566E080", VA = "0x18566EE80")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x566ED30", Offset = "0x566DF30", VA = "0x18566ED30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x566F8F0", Offset = "0x566EAF0", VA = "0x18566F8F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x566F0A0", Offset = "0x566E2A0", VA = "0x18566F0A0", Slot = "6")]
		public override void Send(ulong EGPEDDDFDOG, ArraySegment<byte> FODGEDCJIDC, NetworkDelivery DKIDIJFDMOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x566EE40", Offset = "0x566E040", VA = "0x18566EE40", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong EGPEDDDFDOG, [Out] ArraySegment<byte> AENCBMJJMMB, [Out] float OLNOJCAGPBF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x566F390", Offset = "0x566E590", VA = "0x18566F390", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x566F810", Offset = "0x566EA10", VA = "0x18566F810", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x566E400", Offset = "0x566D600", VA = "0x18566E400", Slot = "10")]
		public override void DisconnectRemoteClient(ulong EGPEDDDFDOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x566E2B0", Offset = "0x566D4B0", VA = "0x18566E2B0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x566E720", Offset = "0x566D920", VA = "0x18566E720", Slot = "12")]
		public override ulong GetCurrentRtt(ulong EGPEDDDFDOG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x566F320", Offset = "0x566E520", VA = "0x18566F320", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x566E7C0", Offset = "0x566D9C0", VA = "0x18566E7C0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager KFDOMGBPFOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x566E650", Offset = "0x566D850", VA = "0x18566E650")]
		private EGHEECAHHOP GIGIILOADOC(NetworkDelivery FLPJMDMACMC)
		{
			return default(EGHEECAHHOP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x566E1F0", Offset = "0x566D3F0", VA = "0x18566E1F0", Slot = "15")]
		private void CIFKLIMDMCB(KLMIPPCJNIJ GJMJGOPJMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x566EB90", Offset = "0x566DD90", VA = "0x18566EB90", Slot = "16")]
		private void KJNDBOBPICI(KLMIPPCJNIJ GJMJGOPJMFI, NBEFJIHBDJE EOBCDDKMJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "17")]
		private void DOEAGOMPHGF(IPEndPoint DNBBAENCDNF, SocketError IKHCEJKIDKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x566E980", Offset = "0x566DB80", VA = "0x18566E980", Slot = "18")]
		private void KGACDNHHKBJ(KLMIPPCJNIJ GJMJGOPJMFI, JPHEKBAIKOC CAMFAGAEHOD, byte LIIHKMPKGHP, EGHEECAHHOP DAMPGHOAAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x566E570", Offset = "0x566D770", VA = "0x18566E570")]
		private void FLGBAFGAEAE(int MKJBDDDPMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "19")]
		private void CGGKNCCFKKP(IPEndPoint AFOKIPAMHJF, JPHEKBAIKOC CAMFAGAEHOD, IEFINKDNMIN JFHAHJALGMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "20")]
		private void NOOFLLODOON(KLMIPPCJNIJ GJMJGOPJMFI, int HEMOEBGMFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x566ECD0", Offset = "0x566DED0", VA = "0x18566ECD0", Slot = "21")]
		private void MBPACFIHDBH(FNGAJIOMBOE AIJPHINHCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x566E1C0", Offset = "0x566D3C0", VA = "0x18566E1C0")]
		private ulong BNKAFIEDAOL(KLMIPPCJNIJ GJMJGOPJMFI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x566EE20", Offset = "0x566E020", VA = "0x18566EE20")]
		private static int PPMNKMFBLKO(float IJJNDFLLAHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x566F910", Offset = "0x566EB10", VA = "0x18566F910")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class DCCMEDHIMAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly KLMIPPCJNIJ DMJMJBCPHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<PDEBGCPJHMF> BLJJOAMEOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KKOGOBJIMGE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x565D900", Offset = "0x565CB00", VA = "0x18565D900")]
	protected DCCMEDHIMAK(KLMIPPCJNIJ GJMJGOPJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x565D860", Offset = "0x565CA60", VA = "0x18565D860")]
	public void CJJJMBNEJOG(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x565D7E0", Offset = "0x565C9E0", VA = "0x18565D7E0")]
	protected void BDDBNJJFILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x565D8C0", Offset = "0x565CAC0", VA = "0x18565D8C0")]
	public bool GCGKNDPJDLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool EMIFIENEKCF();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GPNCGCKJJMH(PDEBGCPJHMF FEKNLHNDIKD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BIOMPJOJBPD
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
public class FNGAJIOMBOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EMHCIDGBHAF DECOBPGFNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int OEEMKHNLOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LOGEMLKEADL KPHFBIPCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint CNBFABJDPHL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BIOMPJOJBPD KOCODHOGHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE60", Offset = "0x7DC060", VA = "0x1807DCE60")]
		[CompilerGenerated]
		get
		{
			return default(BIOMPJOJBPD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98BD90", Offset = "0x98AF90", VA = "0x18098BD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5667390", Offset = "0x5666590", VA = "0x185667390")]
	internal void EIJDPBFLKKB(LOGEMLKEADL AKCHDIOAADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56673F0", Offset = "0x56665F0", VA = "0x1856673F0")]
	private bool KJDLBNMCHIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5667420", Offset = "0x5666620", VA = "0x185667420")]
	internal FNGAJIOMBOE(IPEndPoint AFOKIPAMHJF, LOGEMLKEADL KDIECBMEOLG, EMHCIDGBHAF KLDIIAKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5667330", Offset = "0x5666530", VA = "0x185667330")]
	public KLMIPPCJNIJ CEKOLPMCEJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IEFINKDNMIN
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EHHFGJCFIPJ
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
public struct NBEFJIHBDJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public EHHFGJCFIPJ GFHHFLBAIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError LCONILEGNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public JPHEKBAIKOC KEMGIKKMIMF;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KDPNCBELFLI
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBFCANJDLJK(KLMIPPCJNIJ GJMJGOPJMFI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEKABPIINHD(KLMIPPCJNIJ GJMJGOPJMFI, NBEFJIHBDJE EOBCDDKMJPJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IAAIHJAMKDH(IPEndPoint DNBBAENCDNF, SocketError IKHCEJKIDKM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKKKJHJDIGG(KLMIPPCJNIJ GJMJGOPJMFI, JPHEKBAIKOC CAMFAGAEHOD, byte LIIHKMPKGHP, EGHEECAHHOP DAMPGHOAAIN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DEBBALEJBKF(IPEndPoint AFOKIPAMHJF, JPHEKBAIKOC CAMFAGAEHOD, IEFINKDNMIN JFHAHJALGMK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFHPFADBCNM(KLMIPPCJNIJ GJMJGOPJMFI, int HEMOEBGMFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFHHPMGELLM(FNGAJIOMBOE AIJPHINHCJO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ILCKAOHBOIF
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHDMAFGKGNN(KLMIPPCJNIJ GJMJGOPJMFI, object BCDPMPBOFDA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HBGFJAIFLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CNOJEEJCIBI(JFHFKMDGKFO FEKNLHNDIKD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GJMEGPJPEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEAHFALCIAI(KLMIPPCJNIJ GJMJGOPJMFI, IPEndPoint NKMIAINFOKK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LOGEMLKEADL
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int GKBCLEKDOPO = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long OECAAEHLIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte JBHDLGHNFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] GAADAMLLCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly OLJPDINKIPG HCKHOAGNJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int BAFPAKBMIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x566E150", Offset = "0x566D350", VA = "0x18566E150")]
	private LOGEMLKEADL(long HNMFHFNOCGD, byte ALMFNLDECMF, int CGNAIHEOONH, byte[] FIPMBHOPDIB, OLJPDINKIPG FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x566E0F0", Offset = "0x566D2F0", VA = "0x18566E0F0")]
	public static int PFPOMEPNHPF(PDEBGCPJHMF FEKNLHNDIKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x566DCF0", Offset = "0x566CEF0", VA = "0x18566DCF0")]
	public static LOGEMLKEADL AJHNBGOGIJA(PDEBGCPJHMF FEKNLHNDIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x566DF10", Offset = "0x566D110", VA = "0x18566DF10")]
	public static PDEBGCPJHMF KKCPIOJNABG(FLOKACNOMCJ GMIKLKHKHAP, SocketAddress FAEJBHBPBDJ, long LCKHGNNPJKI, int CGNAIHEOONH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class CPONLCMNOHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long OECAAEHLIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte JBHDLGHNFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int BAFPAKBMIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool DALICEJLEOF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x565D790", Offset = "0x565C990", VA = "0x18565D790")]
	private CPONLCMNOHB(long HNMFHFNOCGD, byte ALMFNLDECMF, int FKGLNCNCCPD, bool AHIEBHNBAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x565D450", Offset = "0x565C650", VA = "0x18565D450")]
	public static CPONLCMNOHB AJHNBGOGIJA(PDEBGCPJHMF FEKNLHNDIKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x565D6A0", Offset = "0x565C8A0", VA = "0x18565D6A0")]
	public static PDEBGCPJHMF KKCPIOJNABG(long LCKHGNNPJKI, byte DFBBIJMDKGP, int ONHNGPIHPDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x565D5A0", Offset = "0x565C7A0", VA = "0x18565D5A0")]
	public static PDEBGCPJHMF JIJMEFOFHBK(KLMIPPCJNIJ GJMJGOPJMFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum ALLGBALJNIP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BFLCABEEALJ
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHEFBNOIGDA(IPEndPoint OHDLMHACIOA, IPEndPoint AFOKIPAMHJF, string FCKLPDKGPKE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMNNKJCIDLP(IPEndPoint PBCMAFFBBHL, ALLGBALJNIP FLPJMDMACMC, string FCKLPDKGPKE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EHLHHAGILHG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct HKOFKOGNCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint HPBAFNLLCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint CNBFABJDPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string MHFGINAPALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct AKJMIHNPBBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint MBLJCLHDOOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ALLGBALJNIP DIOCHMJOOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string MHFGINAPALI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class MDJGECOJFON
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint PEIKHHPLIAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string MHFGINAPALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public MDJGECOJFON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HCLAKIHPHAE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint PEIKHHPLIAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LKOJBMCCPGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string MHFGINAPALI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HCLAKIHPHAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class DHIFLAHNLGL
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MHFGINAPALI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FIKEBFLBFCH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x85F3E0", Offset = "0x85E5E0", VA = "0x18085F3E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA960", Offset = "0x7B9B60", VA = "0x1807BA960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DHIFLAHNLGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EMHCIDGBHAF MAKEMDGIFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<HKOFKOGNCCA> LGCAGCCGPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<AKJMIHNPBBF> IPEJCJFMCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly OLJPDINKIPG PBPBFIDNAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FLOKACNOMCJ KEDKDGEIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EKAPEPJOCBI ABCHHAALIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private BFLCABEEALJ ANGPEAJJNNB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int BPMAIHKKOIM = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool GDJOIGEDNMK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x565ED40", Offset = "0x565DF40", VA = "0x18565ED40")]
	internal EHLHHAGILHG(EMHCIDGBHAF GFMGJEBPFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x565E750", Offset = "0x565D950", VA = "0x18565E750")]
	internal void CAJJCGLNDBM(IPEndPoint AIOGBEEJJMJ, PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x277B600", Offset = "0x277A800", VA = "0x18277B600")]
	private void HFLPBOLMPEP<T>(T FEKNLHNDIKD, IPEndPoint IOCBLPNBBJM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x565EBB0", Offset = "0x565DDB0", VA = "0x18565EBB0")]
	private void HHEFBNOIGDA(MDJGECOJFON GLOOKIDAMKE, IPEndPoint AIOGBEEJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x565E8B0", Offset = "0x565DAB0", VA = "0x18565E8B0")]
	private void DAAABEABIKO(HCLAKIHPHAE GLOOKIDAMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x565EA10", Offset = "0x565DC10", VA = "0x18565EA10")]
	private void HEINCDJKCAP(DHIFLAHNLGL GLOOKIDAMKE, IPEndPoint AIOGBEEJJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EGHEECAHHOP : byte
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
public enum DBMCMOCOFJA : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class OCDACBBCNEG
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] EGCKBGCFKCA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int KDOAEMDEKMG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int INFPPCOBJNL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CEBEJKMLADC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x565D3A0", Offset = "0x565C5A0", VA = "0x18565D3A0")]
	public CEBEJKMLADC(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CADNHPIPLMM : CEBEJKMLADC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x565D3A0", Offset = "0x565C5A0", VA = "0x18565D3A0")]
	public CADNHPIPLMM(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LJOPOJMGOCC
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
public interface LNMHKIBJKDL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMEBKACLPLH(LJOPOJMGOCC ENKMBGKFHPI, string ENONAODCGNA, params object[] JPEJCADBOCG);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BMJKDAFKLON
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static LNMHKIBJKDL BDNNHGANLLG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object DMJCGMFGKIM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x565CFB0", Offset = "0x565C1B0", VA = "0x18565CFB0")]
	private static void BFDCBOOKCIK(LJOPOJMGOCC JAGPKOFJGFF, string ENONAODCGNA, params object[] JPEJCADBOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x565D290", Offset = "0x565C490", VA = "0x18565D290")]
	internal static void MFPBNFPAGBM(string ENONAODCGNA, params object[] JPEJCADBOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x565D230", Offset = "0x565C430", VA = "0x18565D230")]
	internal static void HACHFGHLAHL(string ENONAODCGNA, params object[] JPEJCADBOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x565D1D0", Offset = "0x565C3D0", VA = "0x18565D1D0")]
	internal static void GECCKICCJGN(string ENONAODCGNA, params object[] JPEJCADBOCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DFBDDOEPFPL
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JPHEKBAIKOC : OLJPDINKIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private PDEBGCPJHMF HLAHCJOELDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EMHCIDGBHAF BFAIKGKPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KEDDLLNHHDP FFOHKGOGMFN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5669A70", Offset = "0x5668C70", VA = "0x185669A70")]
	internal JPHEKBAIKOC(EMHCIDGBHAF ANAEOGBFNHN, KEDDLLNHHDP NPNJKIAOAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5669980", Offset = "0x5668B80", VA = "0x185669980")]
	internal void HHFJAFEECOL(PDEBGCPJHMF FEKNLHNDIKD, int OCFKLPFJACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x56699F0", Offset = "0x5668BF0", VA = "0x1856699F0")]
	internal void OEMICNKGCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5669950", Offset = "0x5668B50", VA = "0x185669950")]
	public void BMOFOPFPPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KEDDLLNHHDP
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum DBGFAMDBDMM
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
	public KEDDLLNHHDP GNHHBJIJMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public DBGFAMDBDMM DIOCHMJOOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public KLMIPPCJNIJ DMJMJBCPHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint CNBFABJDPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object JGOGPPCAMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int PLNJMDMOHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JDDINAIHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public EHHFGJCFIPJ KBILHGGIPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public FNGAJIOMBOE CIAOKPMMADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public EGHEECAHHOP KBDGEKIOPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte LHHLJHLLLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly JPHEKBAIKOC NIAEFPNPJGG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5669AC0", Offset = "0x5668CC0", VA = "0x185669AC0")]
	public KEDDLLNHHDP(EMHCIDGBHAF ANAEOGBFNHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EMHCIDGBHAF : IEnumerable<KLMIPPCJNIJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class BDHCJINEBJG : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x565CDC0", Offset = "0x565BFC0", VA = "0x18565CDC0", Slot = "4")]
		public bool Equals(IPEndPoint KPEEHKEJDAP, IPEndPoint OEKGMAOIIKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x513FB30", Offset = "0x513ED30", VA = "0x18513FB30", Slot = "5")]
		public int GetHashCode(IPEndPoint JFJMICPDNDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BDHCJINEBJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct CBPCONHDNJG : IEnumerator<KLMIPPCJNIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly KLMIPPCJNIJ ODDAEELMNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private KLMIPPCJNIJ AKDGGEKIBBO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KLMIPPCJNIJ DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9154B0", Offset = "0x9146B0", VA = "0x1809154B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF88900", Offset = "0xF87B00", VA = "0x180F88900")]
		public CBPCONHDNJG(KLMIPPCJNIJ MBFPHKFMHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x565D3B0", Offset = "0x565C5B0", VA = "0x18565D3B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x565D400", Offset = "0x565C600", VA = "0x18565D400", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread KPDCFNOGPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool GJKDFKFNNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent NLKBPONHHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KEDDLLNHHDP> OFILNADDFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KEDDLLNHHDP> NJHHIKCHIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private KEDDLLNHHDP LNLEELIANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly KDPNCBELFLI LBIOHGANBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ILCKAOHBOIF PCPFKODLKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HBGFJAIFLGH DCCMCDPLGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GJMEGPJPEJG JHEJIBOGECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, KLMIPPCJNIJ> NODNPBAGKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, FNGAJIOMBOE> JCJMGLJFEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, LIFCNNDCNJO> OALKLHNBCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim FDKAJLPBMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private KLMIPPCJNIJ OGDADAPDADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int NICMIDHMFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<KLMIPPCJNIJ> JHNPHENHOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private KLMIPPCJNIJ[] AGNMHNAGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly DELJDOMEHBA HFCBBJODJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int NBMEICNLMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> JBKKGHENDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte CFHNACACFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object CDLKALGLOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IINEOEOAIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool AAELPFEDLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BFDNHAJJOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int LLBHHHFLGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int BGMOOMFGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int JAOJBPGAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool NECPIKPAFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool KCFONNCEFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int BMOILDGNAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int ACEDCOIELBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int DBOKKAJNOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool GDJOIGEDNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool NFGMJPHJLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KGKOMOAJOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool BKJHKAABIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int CFHLCANIBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int PEBMKIPDKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PDELPKNFHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly MPMDALLOFGO KEJNAKDFBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool BECKNFJCIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly EHLHHAGILHG DHBCOFGDGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool OPBLEMBPDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public DFBDDOEPFPL PJCAAJFEKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int GLMCLOEKNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool CDEFPDAHAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GEFGICIFNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool CPJIHDMJPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool KMJLDFKNEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private PDEBGCPJHMF BFNEDJHFGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int GLMINGCCINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object PCCLCICGKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PDEBGCPJHMF AGCDMMGFJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int CHHFAHKHDKE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int KLNCEHBJHDH = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int PMKEOEFIMAM = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DBEFEJCJIHA BMFMNKOKAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private DBEFEJCJIHA BMFAGPMLEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OFBINCAILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread FHOPMEMJODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint CEKJDMJCGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint CJDECAGEHFF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] PMGPGNJHFIA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] FNPIEOAHEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<BAFIPLDJBBA, IPEndPoint> HKAKLLGJCNI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress KDACKDJNGGO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool CMAILJKBMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int LMENFCEKHFA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AMOGPFFCJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA6E2A0", Offset = "0xA6D4A0", VA = "0x180A6E2A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB37A60", Offset = "0xB36C60", VA = "0x180B37A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PLGFMJIPMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x133F3D0", Offset = "0x133E5D0", VA = "0x18133F3D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x16622E0", Offset = "0x16614E0", VA = "0x1816622E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte KFKNEDNOCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D84D0", Offset = "0x8D76D0", VA = "0x1808D84D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DIBEMDMCPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5660850", Offset = "0x565FA50", VA = "0x185660850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short HGBEKCIMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x565FE30", Offset = "0x565F030", VA = "0x18565FE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x565FEF0", Offset = "0x565F0F0", VA = "0x18565FEF0")]
	public void BCKELJNNLII(IPEndPoint DNBBAENCDNF, byte[] GOBGGNLGONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5664B70", Offset = "0x5663D70", VA = "0x185664B70")]
	public void NKJODAMKMMM(IPEndPoint DNBBAENCDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5661020", Offset = "0x5660220", VA = "0x185661020")]
	private bool FALOCDHPAIB(IPEndPoint DNBBAENCDNF, [Out] KLMIPPCJNIJ GJMJGOPJMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5665A00", Offset = "0x5664C00", VA = "0x185665A00")]
	private void PHKLIIGKHEJ(KLMIPPCJNIJ GJMJGOPJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x56632B0", Offset = "0x56624B0", VA = "0x1856632B0")]
	private void JDAEHPOABMK(KLMIPPCJNIJ GJMJGOPJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5665480", Offset = "0x5664680", VA = "0x185665480")]
	private void OAFLOJILMHA(KLMIPPCJNIJ GJMJGOPJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5665EA0", Offset = "0x56650A0", VA = "0x185665EA0")]
	public EMHCIDGBHAF(KDPNCBELFLI KLDIIAKIDAD, [Optional] DELJDOMEHBA HHCALGEOIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5664580", Offset = "0x5663780", VA = "0x185664580")]
	internal void MOJPDFOIHMP(KLMIPPCJNIJ HMCKDKILILJ, int HEMOEBGMFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56610B0", Offset = "0x56602B0", VA = "0x1856610B0")]
	internal void FBFDKEPJDHG(KLMIPPCJNIJ HMCKDKILILJ, object BCDPMPBOFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5662610", Offset = "0x5661810", VA = "0x185662610")]
	internal void GOPJMPJDKAA(KLMIPPCJNIJ GJMJGOPJMFI, EHHFGJCFIPJ LGGFDGCPFCF, SocketError KHENLBHDFHM, PDEBGCPJHMF HDJHHNJLPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x56644A0", Offset = "0x56636A0", VA = "0x1856644A0")]
	private void LKOAJDOOKBG(KLMIPPCJNIJ GJMJGOPJMFI, EHHFGJCFIPJ LGGFDGCPFCF, SocketError KHENLBHDFHM, bool FCLAIJBMLJG, byte[] FODGEDCJIDC, int PFGKDMDHLBN, int KIGJDGACGDD, PDEBGCPJHMF HDJHHNJLPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5660870", Offset = "0x565FA70", VA = "0x185660870")]
	private void DDLFHHJFFEB(KEDDLLNHHDP.DBGFAMDBDMM FLPJMDMACMC, [Optional] KLMIPPCJNIJ GJMJGOPJMFI, [Optional] IPEndPoint AFOKIPAMHJF, SocketError PIMNPCCLOAF = SocketError.Success, int HEMOEBGMFDJ = 0, EHHFGJCFIPJ JIPCICGLECC = EHHFGJCFIPJ.ConnectionFailed, [Optional] FNGAJIOMBOE PLGBMKEJBEP, EGHEECAHHOP DAMPGHOAAIN = EGHEECAHHOP.Unreliable, byte LIIHKMPKGHP = 0, [Optional] PDEBGCPJHMF MMHABPEGJDO, [Optional] object BCDPMPBOFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5662980", Offset = "0x5661B80", VA = "0x185662980")]
	private void IHJGDBCAOLB(KEDDLLNHHDP NPNJKIAOAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56626E0", Offset = "0x56618E0", VA = "0x1856626E0")]
	internal void HCBFPEJGCNE(KEDDLLNHHDP NPNJKIAOAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56639E0", Offset = "0x5662BE0", VA = "0x1856639E0")]
	private void JNAKBKPDBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x565FB10", Offset = "0x565ED10", VA = "0x18565FB10")]
	private void ACNKEKBOBNL(int DNJGJLEKIIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5663D20", Offset = "0x5662F20", VA = "0x185663D20")]
	internal KLMIPPCJNIJ KEMEHKOHBIF(FNGAJIOMBOE AIJPHINHCJO, byte[] JNHHJBMBFJK, int PFGKDMDHLBN, int HHOELNLHIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5664AF0", Offset = "0x5663CF0", VA = "0x185664AF0")]
	private int NDGCNKNJIBA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5661460", Offset = "0x5660660", VA = "0x185661460")]
	private void FPGHGCLEOEH(IPEndPoint AFOKIPAMHJF, KLMIPPCJNIJ PLOMNDOFDOL, LOGEMLKEADL FBBBCKDEHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56618C0", Offset = "0x5660AC0", VA = "0x1856618C0")]
	private void GJGBEFLDBPC(PDEBGCPJHMF FEKNLHNDIKD, IPEndPoint AFOKIPAMHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5665740", Offset = "0x5664940", VA = "0x185665740")]
	internal void PHJOJDIHEHE(PDEBGCPJHMF FEKNLHNDIKD, EGHEECAHHOP LJEALFGEAGN, byte LIIHKMPKGHP, int OCFKLPFJACH, KLMIPPCJNIJ HMCKDKILILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5660740", Offset = "0x565F940", VA = "0x185660740")]
	public bool CHNNBJODNMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56607B0", Offset = "0x565F9B0", VA = "0x1856607B0")]
	public bool CHNNBJODNMB(IPAddress ALKPMAILEMA, IPAddress LCFLKOGKOPL, int GFJEDKIAAJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56607D0", Offset = "0x565F9D0", VA = "0x1856607D0")]
	public bool CHNNBJODNMB(int GFJEDKIAAJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x56627E0", Offset = "0x56619E0", VA = "0x1856627E0")]
	public void HKJLPJKPFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5664FD0", Offset = "0x56641D0", VA = "0x185664FD0")]
	public KLMIPPCJNIJ NMMEILHHKCD(string LEEOLPPCLJD, int GFJEDKIAAJH, string GOBGGNLGONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5664EF0", Offset = "0x56640F0", VA = "0x185664EF0")]
	public KLMIPPCJNIJ NMMEILHHKCD(string LEEOLPPCLJD, int GFJEDKIAAJH, FLOKACNOMCJ PGGAHHKFOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x56650B0", Offset = "0x56642B0", VA = "0x1856650B0")]
	public KLMIPPCJNIJ NMMEILHHKCD(IPEndPoint IOCBLPNBBJM, FLOKACNOMCJ PGGAHHKFOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5661100", Offset = "0x5660300", VA = "0x185661100")]
	public void FJMPAKPHLPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5661110", Offset = "0x5660310", VA = "0x185661110")]
	public void FJMPAKPHLPM(bool IOCIDDDJFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5660D20", Offset = "0x565FF20", VA = "0x185660D20")]
	public void EGBBKGLALPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5660E20", Offset = "0x5660020", VA = "0x185660E20")]
	public void EGBBKGLALPD(byte[] FODGEDCJIDC, int PFGKDMDHLBN, int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x56643F0", Offset = "0x56635F0", VA = "0x1856643F0")]
	public void LKOAJDOOKBG(KLMIPPCJNIJ GJMJGOPJMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5664330", Offset = "0x5663530", VA = "0x185664330")]
	public void LKOAJDOOKBG(KLMIPPCJNIJ GJMJGOPJMFI, byte[] FODGEDCJIDC, int PFGKDMDHLBN, int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5665CC0", Offset = "0x5664EC0", VA = "0x185665CC0", Slot = "4")]
	private IEnumerator<KLMIPPCJNIJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5665D50", Offset = "0x5664F50", VA = "0x185665D50", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5663630", Offset = "0x5662830", VA = "0x185663630")]
	private PDEBGCPJHMF JHEBMEFHDHL(MIFCNNHNIMA KCBHGLJDNNP, int MKJBDDDPMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5663550", Offset = "0x5662750", VA = "0x185663550")]
	private PDEBGCPJHMF JHEBMEFHDHL(MIFCNNHNIMA KCBHGLJDNNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5664CC0", Offset = "0x5663EC0", VA = "0x185664CC0")]
	internal PDEBGCPJHMF NLCBKMGBMHG(int MKJBDDDPMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5663300", Offset = "0x5662500", VA = "0x185663300")]
	internal void JGEDDGIPCID(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5665DE0", Offset = "0x5664FE0", VA = "0x185665DE0")]
	static EMHCIDGBHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA6E2A0", Offset = "0xA6D4A0", VA = "0x180A6E2A0")]
	private bool LBCIKBPNKEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5660C30", Offset = "0x565FE30", VA = "0x185660C30")]
	private void EBKOHDGKENB(IPEndPoint EJAPKJMEMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5660F40", Offset = "0x5660140", VA = "0x185660F40")]
	private void EMHGFJBDLFM(IPEndPoint EJAPKJMEMCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5664950", Offset = "0x5663B50", VA = "0x185664950")]
	private bool MPJDLJHPOKD(SocketException PGAHDJGBLJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5663710", Offset = "0x5662910", VA = "0x185663710")]
	private void JKJMIKMCLHB(DBEFEJCJIHA GFMGJEBPFKF, EndPoint IPKHGCKOOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x56645D0", Offset = "0x56637D0", VA = "0x1856645D0")]
	private void MPFDFPECICD(object OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x565FF90", Offset = "0x565F190", VA = "0x18565FF90")]
	public bool CHNNBJODNMB(IPAddress ALKPMAILEMA, IPAddress LCFLKOGKOPL, int GFJEDKIAAJH, bool ONGDLMPLDHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56656E0", Offset = "0x56648E0", VA = "0x1856656E0")]
	internal int OOBEFAMGMFB(PDEBGCPJHMF FEKNLHNDIKD, IPEndPoint AFOKIPAMHJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x565F510", Offset = "0x565E710", VA = "0x18565F510")]
	internal int ABOAFLALCPD(PDEBGCPJHMF FEKNLHNDIKD, IPEndPoint AFOKIPAMHJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x565F550", Offset = "0x565E750", VA = "0x18565F550")]
	internal int ABOAFLALCPD(byte[] JGNAJPMGGNE, int PFGKDMDHLBN, int HHOELNLHIEN, IPEndPoint AFOKIPAMHJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5663140", Offset = "0x5662340", VA = "0x185663140")]
	internal void JAMLEGAKECO(bool DPGHDOPCIEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum MIFCNNHNIMA : byte
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
internal sealed class PDEBGCPJHMF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int IMOPIHNLJJK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] PHHOKECPGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] PKANBHGLAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int JPOIEEJJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object JGOGPPCAMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public PDEBGCPJHMF GNHHBJIJMBA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MIFCNNHNIMA JADHKKBJOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5672870", Offset = "0x5671A70", VA = "0x185672870")]
		get
		{
			return default(MIFCNNHNIMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x56728A0", Offset = "0x5671AA0", VA = "0x1856728A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte JBHDLGHNFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5672630", Offset = "0x5671830", VA = "0x185672630")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5672690", Offset = "0x5671890", VA = "0x185672690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort IPNMMMMAAJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5672810", Offset = "0x5671A10", VA = "0x185672810")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x56727D0", Offset = "0x56719D0", VA = "0x1856727D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MFBHBAJLMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5672660", Offset = "0x5671860", VA = "0x185672660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PLFGHFFDKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5672360", Offset = "0x5671560", VA = "0x185672360")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x56725C0", Offset = "0x56717C0", VA = "0x1856725C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort HHOHFGKDEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x56723D0", Offset = "0x56715D0", VA = "0x1856723D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5672390", Offset = "0x5671590", VA = "0x185672390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort GIELAAJDIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5672300", Offset = "0x5671500", VA = "0x185672300")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x56728E0", Offset = "0x5671AE0", VA = "0x1856728E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort PLCIPBPEPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5672430", Offset = "0x5671630", VA = "0x185672430")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x56725F0", Offset = "0x56717F0", VA = "0x1856725F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5672920", Offset = "0x5671B20", VA = "0x185672920")]
	static PDEBGCPJHMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5672590", Offset = "0x5671790", VA = "0x185672590")]
	public void DEEDHAGPDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5672CF0", Offset = "0x5671EF0", VA = "0x185672CF0")]
	public PDEBGCPJHMF(int MKJBDDDPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5672BE0", Offset = "0x5671DE0", VA = "0x185672BE0")]
	public PDEBGCPJHMF(MIFCNNHNIMA KCBHGLJDNNP, int MKJBDDDPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5672490", Offset = "0x5671690", VA = "0x185672490")]
	public static int DBHBLFBIEGA(MIFCNNHNIMA KCBHGLJDNNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5672500", Offset = "0x5671700", VA = "0x185672500")]
	public int DBHBLFBIEGA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x56726D0", Offset = "0x56718D0", VA = "0x1856726D0")]
	public bool LBOCOOAPKDJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum OJLIGCDMEIJ : byte
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
internal enum BPAMLOLHPHB
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
internal enum ACBGJJHJOFI
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum CHIOOIBPMNO
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class KLMIPPCJNIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class IPCPNAFCIBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PDEBGCPJHMF[] NNFEHFCALCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int CEGBGHIMHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PMPGIEPKDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte PLFGHFFDKDD;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IPCPNAFCIBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void MAHDIGOIBOJ(ulong AGKNCPKJDHA, int POMBGBPKFAH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int EMGKGCBFOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int DNCGBJANBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int LOELLANOMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FGFPJIPACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int FPLGNHLADFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int BJFHPNNNJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int IIFAMEFMALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch GEBJBLFEHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int JGMFOFEMFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FLBKJHNGHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object IFDKFFHEFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal KLMIPPCJNIJ ECDINHOEKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal KLMIPPCJNIJ IFNDEBNJDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<PDEBGCPJHMF> OKHEPBMFPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<DCCMEDHIMAK> IGELKLLIMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DCCMEDHIMAK[] OCLKKCMNCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int BBOKGMBNGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int DOPACCNLEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool FMHACJDGJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int LECKNOMPADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int JLMNDMIHOOE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int DBMLAGGNMHI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int KAJNNBFBBIA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DBGEHAADPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PIDJOOPABGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, IPCPNAFCIBP> EDOHDNLIHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> ABCGJOAIJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly PDEBGCPJHMF EHHJFFJELNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int KLOMFNOKOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int MNBLNFODFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint PMBDAGBIIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int GHAOLELHCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int EAKOPKFMJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long KDCJPKJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte EJCIGBEJICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private OJLIGCDMEIJ ACJCOCPLGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private PDEBGCPJHMF FKJGNDLHFJH;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int DGPKBIAFAJB = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int COMPNNDBFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly PDEBGCPJHMF KEHKKHJOPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly PDEBGCPJHMF JPHGMKDHDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly PDEBGCPJHMF ACNKNOLCPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly PDEBGCPJHMF KPFJGAEEPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private DBMCMOCOFJA BANMIKDIDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly EMHCIDGBHAF DFHBELCMBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int GHMLFHHEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object OJFJNJIEFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly MPMDALLOFGO KEJNAKDFBFF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte DHGKFDGCFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xACC640", Offset = "0xACB840", VA = "0x180ACC640")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x566CEE0", Offset = "0x566C0E0", VA = "0x18566CEE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DNNKBMGLPCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E2090", Offset = "0x8E1290", VA = "0x1808E2090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OJLIGCDMEIJ AKFBDNDDKJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x167E8E0", Offset = "0x167DAE0", VA = "0x18167E8E0")]
		get
		{
			return default(OJLIGCDMEIJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long OHHOOHKLKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BC070", Offset = "0x7BB270", VA = "0x1807BC070")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KJAJPLDGBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB7BCD0", Offset = "0xB7AED0", VA = "0x180B7BCD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x148F900", Offset = "0x148EB00", VA = "0x18148F900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LMPMHOGIOGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x566C850", Offset = "0x566BA50", VA = "0x18566C850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AHMKKNENDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3320", VA = "0x1807C4120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double ABJCPLBKAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x18A2770", Offset = "0x18A1970", VA = "0x1818A2770")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MAHDIGOIBOJ LCOFLIHEAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x566CE30", Offset = "0x566C030", VA = "0x18566CE30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x566C480", Offset = "0x566B680", VA = "0x18566C480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x566D5B0", Offset = "0x566C7B0", VA = "0x18566D5B0")]
	internal KLMIPPCJNIJ(EMHCIDGBHAF ONKIOKNDNAK, IPEndPoint AFOKIPAMHJF, int JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5669D30", Offset = "0x5668F30", VA = "0x185669D30")]
	internal void AMNCOOBPABE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x566B100", Offset = "0x566A300", VA = "0x18566B100")]
	internal void GNIMPJPHEMC(IPEndPoint LJBMPNOEOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x566BD30", Offset = "0x566AF30", VA = "0x18566BD30")]
	internal void HCOJFMPANIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x566C3B0", Offset = "0x566B5B0", VA = "0x18566C3B0")]
	private void KICCEJCJGJF(int EIHDACCIKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x566D390", Offset = "0x566C590", VA = "0x18566D390")]
	private void OJJCKMDJDDD(int JFLECKNOLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x566A8A0", Offset = "0x5669AA0", VA = "0x18566A8A0")]
	private DCCMEDHIMAK GBIHGOFCMJG(byte HPIPPKAMAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x566DA00", Offset = "0x566CC00", VA = "0x18566DA00")]
	internal KLMIPPCJNIJ(EMHCIDGBHAF ONKIOKNDNAK, IPEndPoint AFOKIPAMHJF, int JNIKIHKLGAD, byte DFBBIJMDKGP, FLOKACNOMCJ GMIKLKHKHAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x566D3D0", Offset = "0x566C5D0", VA = "0x18566D3D0")]
	internal KLMIPPCJNIJ(EMHCIDGBHAF ONKIOKNDNAK, FNGAJIOMBOE AIJPHINHCJO, int JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x566D340", Offset = "0x566C540", VA = "0x18566D340")]
	internal void ODBDINDFNEH(LOGEMLKEADL GKGODONKEAN, byte[] FODGEDCJIDC, int PFGKDMDHLBN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x566C860", Offset = "0x566BA60", VA = "0x18566C860")]
	internal bool MEBHBCCFCJE(CPONLCMNOHB FEKNLHNDIKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x566BDC0", Offset = "0x566AFC0", VA = "0x18566BDC0")]
	public void HFLPBOLMPEP(byte[] FODGEDCJIDC, int PFGKDMDHLBN, int HHOELNLHIEN, EGHEECAHHOP LDPJIDDAJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x566C8E0", Offset = "0x566BAE0", VA = "0x18566C8E0")]
	private void MJFONMPHLKO(byte[] FODGEDCJIDC, int PFGKDMDHLBN, int HHOELNLHIEN, byte LIIHKMPKGHP, EGHEECAHHOP DAMPGHOAAIN, object BCDPMPBOFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x566C220", Offset = "0x566B420", VA = "0x18566C220")]
	public void HPLEIKAGOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x566C2D0", Offset = "0x566B4D0", VA = "0x18566C2D0")]
	internal ACBGJJHJOFI IMCNNFCDGNG(PDEBGCPJHMF FEKNLHNDIKD)
	{
		return default(ACBGJJHJOFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x566C530", Offset = "0x566B730", VA = "0x18566C530")]
	internal void LCNCNNEGFEK(DCCMEDHIMAK JHJBOMCOKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x566BF10", Offset = "0x566B110", VA = "0x18566BF10")]
	internal CHIOOIBPMNO HLEFENGDDFH(byte[] FODGEDCJIDC, int PFGKDMDHLBN, int HHOELNLHIEN, bool FCLAIJBMLJG)
	{
		return default(CHIOOIBPMNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x566D300", Offset = "0x566C500", VA = "0x18566D300")]
	private void OCMIBMNFOFF(int AHIBHOJFIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5669D50", Offset = "0x5668F50", VA = "0x185669D50")]
	internal void CJOGBMGHEOM(EGHEECAHHOP LJEALFGEAGN, PDEBGCPJHMF MBFPHKFMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x566B130", Offset = "0x566A330", VA = "0x18566B130")]
	private void GPKAPKIOALB(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x566CF90", Offset = "0x566C190", VA = "0x18566CF90")]
	private void NECGLDHNBBD(int NJLEMDJHIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x566A6E0", Offset = "0x56698E0", VA = "0x18566A6E0")]
	internal BPAMLOLHPHB FPGHGCLEOEH(LOGEMLKEADL FBBBCKDEHKM)
	{
		return default(BPAMLOLHPHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x566B680", Offset = "0x566A880", VA = "0x18566B680")]
	internal void GPNCGCKJJMH(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x566BDF0", Offset = "0x566AFF0", VA = "0x18566BDF0")]
	private void HJCOMPLNHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5669B60", Offset = "0x5668D60", VA = "0x185669B60")]
	internal void ALJBBEOIBNJ(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x566AA50", Offset = "0x5669C50", VA = "0x18566AA50")]
	internal void GKEPGFOADJA(int NJLEMDJHIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x566C590", Offset = "0x566B790", VA = "0x18566C590")]
	internal void LPGNHKNHGLI(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MPMDALLOFGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long ICBHJKDFGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long JKKEILDGNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long JCOILMGHFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long CGALGLBIKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long PNAJDBGENHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long INCCNMIJMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long LFCOGCANHHD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long BAGJGECIHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5670B50", Offset = "0x566FD50", VA = "0x185670B50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long FFMPGLPEKAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5670C50", Offset = "0x566FE50", VA = "0x185670C50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long ECGPBJJJKHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5670C40", Offset = "0x566FE40", VA = "0x185670C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DEPHENOCFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5670BF0", Offset = "0x566FDF0", VA = "0x185670BF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long FOAONGOJMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5670C00", Offset = "0x566FE00", VA = "0x185670C00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long AHCBKDIDLJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5670B60", Offset = "0x566FD60", VA = "0x185670B60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DBMCMOCOFJA MJLAPMLJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1B19440", Offset = "0x1B18640", VA = "0x181B19440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double ILOCCILPAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5670B80", Offset = "0x566FD80", VA = "0x185670B80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5670C60", Offset = "0x566FE60", VA = "0x185670C60")]
	public void MNHGCJGIAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5670CC0", Offset = "0x566FEC0", VA = "0x185670CC0")]
	public void NFPPEEJFJGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5670B70", Offset = "0x566FD70", VA = "0x185670B70")]
	public void IIIGOLOLGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5670CF0", Offset = "0x566FEF0", VA = "0x185670CF0")]
	public void OJDBDDOIBBM(long GNCKAOGGOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5670BE0", Offset = "0x566FDE0", VA = "0x185670BE0")]
	public void JHFOGEKNGGD(long KKFNEPKGCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5670C10", Offset = "0x566FE10", VA = "0x185670C10")]
	public void KKNGMGBLLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5670D00", Offset = "0x566FF00", VA = "0x185670D00")]
	public void PELAMAFGKKG(long HGCNDBJEDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5670D40", Offset = "0x566FF40", VA = "0x185670D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5670AB0", Offset = "0x566FCB0", VA = "0x185670AB0")]
	public void BKMCHPJFGKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MPMDALLOFGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NKKKFBEGJLL
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> EMFJPJIPILJ;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x56712E0", Offset = "0x56704E0", VA = "0x1856712E0")]
	public static IPEndPoint IAKHHLDHMLI(string DLONLDDAPNP, int GFJEDKIAAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5671110", Offset = "0x5670310", VA = "0x185671110")]
	public static IPAddress CBPOLMCLCOH(string DLONLDDAPNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5671080", Offset = "0x5670280", VA = "0x185671080")]
	public static IPAddress CBPOLMCLCOH(string DLONLDDAPNP, AddressFamily MCLJCAHPHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5671530", Offset = "0x5670730", VA = "0x185671530")]
	internal static int OINHFDPMMLP(int DLJHBOKIEPE, int AHDCPLGCKKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A133E0", Offset = "0x2A125E0", VA = "0x182A133E0")]
	internal static T[] GILLPIALPPJ<T>(int KIGJDGACGDD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MEOKMOHHNCM : DCCMEDHIMAK
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BLHIJEPKJEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private PDEBGCPJHMF HLAHCJOELDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long GBMDAECNBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool HCOMNIEEILC;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x565CF10", Offset = "0x565C110", VA = "0x18565CF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x565CEA0", Offset = "0x565C0A0", VA = "0x18565CEA0")]
		public void KBPFNBLAFON(PDEBGCPJHMF FEKNLHNDIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x565CE30", Offset = "0x565C030", VA = "0x18565CE30")]
		public bool IEAHLIHLGND(long CACKBAIGOKL, KLMIPPCJNIJ GJMJGOPJMFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x565CEC0", Offset = "0x565C0C0", VA = "0x18565CEC0")]
		public bool NDGKPACNNFE(KLMIPPCJNIJ GJMJGOPJMFI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly PDEBGCPJHMF OFGMDOAAOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly BLHIJEPKJEJ[] CJPJFCGKANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly PDEBGCPJHMF[] OBHFLFLEAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] LPLLJPJPJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int KDPBGDAAFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int NIDEMBENIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int KNPBBIJGJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int CMJFCMJLDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool EBHBILCGKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly EGHEECAHHOP JCKNCFDONML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool PPEBEJCAFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int KBABMJGFLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte GNHCHINHEAG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x56708E0", Offset = "0x566FAE0", VA = "0x1856708E0")]
	public MEOKMOHHNCM(KLMIPPCJNIJ GJMJGOPJMFI, bool GLFAJCLGOGO, byte JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5670520", Offset = "0x566F720", VA = "0x185670520")]
	private void KEIDFLENDEA(PDEBGCPJHMF FEKNLHNDIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x566FA10", Offset = "0x566EC10", VA = "0x18566FA10", Slot = "4")]
	protected override bool EMIFIENEKCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x566FEC0", Offset = "0x566F0C0", VA = "0x18566FEC0", Slot = "5")]
	public override bool GPNCGCKJJMH(PDEBGCPJHMF FEKNLHNDIKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JMNGHCJKJGM : DCCMEDHIMAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int DOGBOGHDKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort NIDEMBENIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool OFDMHEBJCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private PDEBGCPJHMF FFLPEAFOELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly PDEBGCPJHMF PAEKONFKMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool JEHOOMLPKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte GNHCHINHEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long MDDMFCJBIOI;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5669890", Offset = "0x5668A90", VA = "0x185669890")]
	public JMNGHCJKJGM(KLMIPPCJNIJ GJMJGOPJMFI, bool APJMCHIHDJA, byte JNIKIHKLGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x56690E0", Offset = "0x56682E0", VA = "0x1856690E0", Slot = "4")]
	protected override bool EMIFIENEKCF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5669580", Offset = "0x5668780", VA = "0x185669580", Slot = "5")]
	public override bool GPNCGCKJJMH(PDEBGCPJHMF FEKNLHNDIKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DDDHGLAFHIG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct DGIJKMHKIBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong MPDDFHOECJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double DGMICMBOAJA;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KHGNLJHEJAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int LNFFEKNEKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float EIPMKIEPIBM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x565CA50", Offset = "0x565BC50", VA = "0x18565CA50")]
	private static void JPIMBJMMPEH(byte[] BCDEBAAMJOP, int BJPGLMJPACN, ulong FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x565DA90", Offset = "0x565CC90", VA = "0x18565DA90")]
	private static void JPIMBJMMPEH(byte[] BCDEBAAMJOP, int BJPGLMJPACN, int FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x565DA50", Offset = "0x565CC50", VA = "0x18565DA50")]
	public static void JPIMBJMMPEH(byte[] BCDEBAAMJOP, int BJPGLMJPACN, short FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x565DA30", Offset = "0x565CC30", VA = "0x18565DA30")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, double NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x565D9A0", Offset = "0x565CBA0", VA = "0x18565D9A0")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x565DA50", Offset = "0x565CC50", VA = "0x18565DA50")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, short NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x565DA50", Offset = "0x565CC50", VA = "0x18565DA50")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, ushort NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x565DA90", Offset = "0x565CC90", VA = "0x18565DA90")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x565DA90", Offset = "0x565CC90", VA = "0x18565DA90")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, uint NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x565DA20", Offset = "0x565CC20", VA = "0x18565DA20")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, long NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x565DA20", Offset = "0x565CC20", VA = "0x18565DA20")]
	public static void BANJBNJDIAG(byte[] CGAHJPHALBC, int LCKACGDGBMN, ulong NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OLJPDINKIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] OCGPEKKJCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int MFFACGNJNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int DAINJPFGABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int HJCCKGGLLDC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] PKANBHGLAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LFIKEHNMHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HONIFODDFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5671EA0", Offset = "0x56710A0", VA = "0x185671EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool ENGHJOLIFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D617A0", Offset = "0x1D609A0", VA = "0x181D617A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IBPIJKHAJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5671E90", Offset = "0x5671090", VA = "0x185671E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5671E50", Offset = "0x5671050", VA = "0x185671E50")]
	public void HHFJAFEECOL(byte[] GBHPBJPAFFB, int BJPGLMJPACN, int DJPNICJMILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public OLJPDINKIPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x56722A0", Offset = "0x56714A0", VA = "0x1856722A0")]
	public OLJPDINKIPG(byte[] GBHPBJPAFFB, int BJPGLMJPACN, int DJPNICJMILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5671AA0", Offset = "0x5670CA0", VA = "0x185671AA0")]
	public IPEndPoint FNAHJPCOAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5671A60", Offset = "0x5670C60", VA = "0x185671A60")]
	public byte IILJMMBOJBM()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5671A60", Offset = "0x5670C60", VA = "0x185671A60")]
	public sbyte FIAOKPCDHJD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2A4B200", Offset = "0x2A4A400", VA = "0x182A4B200")]
	public T[] CKHCIKPFEFN<T>(ushort MKJBDDDPMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5671A20", Offset = "0x5670C20", VA = "0x185671A20")]
	public bool[] FFBACLHCFME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x56721E0", Offset = "0x56713E0", VA = "0x1856721E0")]
	public ushort[] OFKPEJKLKBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5672260", Offset = "0x5671460", VA = "0x185672260")]
	public short[] PGCHNHLGKBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5671700", Offset = "0x5670900", VA = "0x185671700")]
	public int[] AEDOJADJAOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5672220", Offset = "0x5671420", VA = "0x185672220")]
	public uint[] OMFPOOIMNIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x56716C0", Offset = "0x56708C0", VA = "0x1856716C0")]
	public float[] ABDOLLMKGJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5671BE0", Offset = "0x5670DE0", VA = "0x185671BE0")]
	public double[] GNMNNNGCGNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5671F20", Offset = "0x5671120", VA = "0x185671F20")]
	public long[] LCHDGIKAPKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5671970", Offset = "0x5670B70", VA = "0x185671970")]
	public ulong[] EKACAFEAFDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5671FE0", Offset = "0x56711E0", VA = "0x185671FE0")]
	public string[] MALCGPOJCOA(int OENIFFBJOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5671F60", Offset = "0x5671160", VA = "0x185671F60")]
	public bool LMIHHCDKIEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x56719B0", Offset = "0x5670BB0", VA = "0x1856719B0")]
	public char ELHJKHFLAKO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x56719B0", Offset = "0x5670BB0", VA = "0x1856719B0")]
	public ushort JCGJBMBDLKB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5671EB0", Offset = "0x56710B0", VA = "0x185671EB0")]
	public short JOLDNJACFIN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x56717B0", Offset = "0x56709B0", VA = "0x1856717B0")]
	public long BFDLOJCGHOP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5671740", Offset = "0x5670940", VA = "0x185671740")]
	public ulong AHKGMPMAEFN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5671890", Offset = "0x5670A90", VA = "0x185671890")]
	public int DMDEGOJOLHC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5671820", Offset = "0x5670A20", VA = "0x185671820")]
	public uint CHADOMOGJNM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5671900", Offset = "0x5670B00", VA = "0x185671900")]
	public float EAGBCPOHKCJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5672170", Offset = "0x5671370", VA = "0x185672170")]
	public double NMPFPFDDJNH()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5671C20", Offset = "0x5670E20", VA = "0x185671C20")]
	public string HHCAKKEONPN(int EPLLLIOIBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5671B70", Offset = "0x5670D70", VA = "0x185671B70")]
	public ArraySegment<byte> GEEDPDEGJJD(int KIGJDGACGDD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5672110", Offset = "0x5671310", VA = "0x185672110")]
	public sbyte[] MEINNKADNMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5671FA0", Offset = "0x56711A0", VA = "0x185671FA0")]
	public byte[] MAKCEEFCECM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5672150", Offset = "0x5671350", VA = "0x185672150")]
	public void NDGKPACNNFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FLOKACNOMCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] OCGPEKKJCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int MFFACGNJNBK;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int NOPOLFAGJPC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool LELFJFLNKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding DFCFHAOONMM;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int ENHGMCONABH = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] CKCIJDKKAJI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] HCKHOAGNJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FPAACNPAGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5667210", Offset = "0x5666410", VA = "0x185667210")]
	public FLOKACNOMCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5667290", Offset = "0x5666490", VA = "0x185667290")]
	public FLOKACNOMCJ(bool PCPOLJGMPEI, int OBFGGCFPFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5666C30", Offset = "0x5665E30", VA = "0x185666C30")]
	public static FLOKACNOMCJ GJDPICCEOIL(string NICEPFIEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x56670F0", Offset = "0x56662F0", VA = "0x1856670F0")]
	public void PAPJABIHDMA(int GAJHCGJHEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1DDB440", Offset = "0x1DDA640", VA = "0x181DDB440")]
	public void MNHGCJGIAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5666B90", Offset = "0x5665D90", VA = "0x185666B90")]
	public void BMKMPPHBAEO(float NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5666AD0", Offset = "0x5665CD0", VA = "0x185666AD0")]
	public void BMKMPPHBAEO(double NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5666A80", Offset = "0x5665C80", VA = "0x185666A80")]
	public void BMKMPPHBAEO(long NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5666A80", Offset = "0x5665C80", VA = "0x185666A80")]
	public void BMKMPPHBAEO(ulong NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5666920", Offset = "0x5665B20", VA = "0x185666920")]
	public void BMKMPPHBAEO(int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5666920", Offset = "0x5665B20", VA = "0x185666920")]
	public void BMKMPPHBAEO(uint NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x56668B0", Offset = "0x5665AB0", VA = "0x1856668B0")]
	public void BMKMPPHBAEO(char NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x56668B0", Offset = "0x5665AB0", VA = "0x1856668B0")]
	public void BMKMPPHBAEO(ushort NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x56668B0", Offset = "0x5665AB0", VA = "0x1856668B0")]
	public void BMKMPPHBAEO(short NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5666840", Offset = "0x5665A40", VA = "0x185666840")]
	public void BMKMPPHBAEO(sbyte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5666840", Offset = "0x5665A40", VA = "0x185666840")]
	public void BMKMPPHBAEO(byte NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5666B20", Offset = "0x5665D20", VA = "0x185666B20")]
	public void BMKMPPHBAEO(byte[] FODGEDCJIDC, int BJPGLMJPACN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x56664F0", Offset = "0x56656F0", VA = "0x1856664F0")]
	public void DLAFOKNMOHM(sbyte[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x56664F0", Offset = "0x56656F0", VA = "0x1856664F0")]
	public void AGFOCHCKGPF(byte[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x56667E0", Offset = "0x56659E0", VA = "0x1856667E0")]
	public void BMKMPPHBAEO(bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5666E60", Offset = "0x5666060", VA = "0x185666E60")]
	public void MBEBGKLECMN(Array CGILHHJCFOL, int LEJODBCGJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5667010", Offset = "0x5666210", VA = "0x185667010")]
	public void MBEBGKLECMN(float[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5666D80", Offset = "0x5665F80", VA = "0x185666D80")]
	public void MBEBGKLECMN(double[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5666D80", Offset = "0x5665F80", VA = "0x185666D80")]
	public void MBEBGKLECMN(long[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5666D80", Offset = "0x5665F80", VA = "0x185666D80")]
	public void MBEBGKLECMN(ulong[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5667010", Offset = "0x5666210", VA = "0x185667010")]
	public void MBEBGKLECMN(int[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5667010", Offset = "0x5666210", VA = "0x185667010")]
	public void MBEBGKLECMN(uint[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5666CA0", Offset = "0x5665EA0", VA = "0x185666CA0")]
	public void MBEBGKLECMN(ushort[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5666CA0", Offset = "0x5665EA0", VA = "0x185666CA0")]
	public void MBEBGKLECMN(short[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x56664F0", Offset = "0x56656F0", VA = "0x1856664F0")]
	public void MBEBGKLECMN(bool[] NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5666F40", Offset = "0x5666140", VA = "0x185666F40")]
	public void MBEBGKLECMN(string[] NICEPFIEJED, int KCCNGMDFALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56669B0", Offset = "0x5665BB0", VA = "0x1856669B0")]
	public void BMKMPPHBAEO(IPEndPoint DNBBAENCDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x56668A0", Offset = "0x5665AA0", VA = "0x1856668A0")]
	public void BMKMPPHBAEO(string NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x56665D0", Offset = "0x56657D0", VA = "0x1856665D0")]
	public void BMKMPPHBAEO(string NICEPFIEJED, int EPLLLIOIBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class EKAPEPJOCBI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class CMIADNINGLA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong GHMLFHHEGMK;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4C3B680", Offset = "0x4C3A880", VA = "0x184C3B680")]
		static CMIADNINGLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void GDJHKPHLJCI(OLJPDINKIPG CAMFAGAEHOD, object BCDPMPBOFDA);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LEOHBHCEKOP<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public EKAPEPJOCBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LEOHBHCEKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3D290A0", Offset = "0x3D282A0", VA = "0x183D290A0")]
		internal void KENBKFJPHEB(OLJPDINKIPG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CCGKDEPEAHJ<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public EKAPEPJOCBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CCGKDEPEAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4B560B0", Offset = "0x4B552B0", VA = "0x184B560B0")]
		internal void KENBKFJPHEB(OLJPDINKIPG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly IMHEEFMGDMF CDCNPEKGDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, GDJHKPHLJCI> OFIHFEAKBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FLOKACNOMCJ EEOPBJAEDIF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x565F390", Offset = "0x565E590", VA = "0x18565F390")]
	public EKAPEPJOCBI(int OENIFFBJOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F00", Offset = "0x26A5100", VA = "0x1826A5F00", Slot = "4")]
	protected virtual ulong AIMDPDHABDK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x565F260", Offset = "0x565E460", VA = "0x18565F260", Slot = "5")]
	protected virtual GDJHKPHLJCI OONAOFPBMBP(OLJPDINKIPG CAMFAGAEHOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x277BE50", Offset = "0x277B050", VA = "0x18277BE50", Slot = "6")]
	protected virtual void ODFJOCHLOPG<T>(FLOKACNOMCJ KPDGEKKKOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x565F1E0", Offset = "0x565E3E0", VA = "0x18565F1E0")]
	public void LDBAJPGHJPN(OLJPDINKIPG CAMFAGAEHOD, object BCDPMPBOFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x277BEC0", Offset = "0x277B0C0", VA = "0x18277BEC0")]
	public void PDEJFMIBDBD<T>(FLOKACNOMCJ KPDGEKKKOHO, T FEKNLHNDIKD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x565F190", Offset = "0x565E390", VA = "0x18565F190")]
	public void KKPCPMPAION(OLJPDINKIPG CAMFAGAEHOD, object BCDPMPBOFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x277BCD0", Offset = "0x277AED0", VA = "0x18277BCD0")]
	public void INICDONHOOF<T>(Action<T> EJOJIBAAHOG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x277BB50", Offset = "0x277AD50", VA = "0x18277BB50")]
	public void INICDONHOOF<T, TUserData>(Action<T, TUserData> EJOJIBAAHOG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NPOONKKILLN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x565D3A0", Offset = "0x565C5A0", VA = "0x18565D3A0")]
	public NPOONKKILLN(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LFOHBGBDKDM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x566DB90", Offset = "0x566CD90", VA = "0x18566DB90")]
	public LFOHBGBDKDM(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class IMHEEFMGDMF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum IMLDLIHJJAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class LICFOIEMNEH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public IMLDLIHJJAP DIOCHMJOOOE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3D65710", Offset = "0x3D64910", VA = "0x183D65710", Slot = "4")]
		public virtual void KBPFNBLAFON(MethodInfo DFKACHGFPKF, MethodInfo IPGEGJGGOIF, IMLDLIHJJAP FLPJMDMACMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KMDPNKBGBNC(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ELALDEIOIMI(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		protected LICFOIEMNEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class NGFMEIDICHJ<TClass, TProperty> : LICFOIEMNEH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> DDKHHKDCPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> BLFJMLNJBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> AIKBLPEMLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> PBBGIBGFIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> BDPBAADNILG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> EFLEKAHGIKL;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x403A500", Offset = "0x4039700", VA = "0x18403A500", Slot = "7")]
		public override void EOLHAPBBBGP(TClass HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4038E40", Offset = "0x4038040", VA = "0x184038E40", Slot = "8")]
		public override void CGDOICNIHIB(TClass HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x403FBC0", Offset = "0x403EDC0", VA = "0x18403FBC0", Slot = "9")]
		public override void KMDPNKBGBNC(TClass HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4039FC0", Offset = "0x40391C0", VA = "0x184039FC0", Slot = "10")]
		public override void ELALDEIOIMI(TClass HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x40389D0", Offset = "0x4037BD0", VA = "0x1840389D0")]
		protected TProperty[] CDBANKMKLMA(TClass HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x403ACE0", Offset = "0x4039EE0", VA = "0x18403ACE0")]
		protected TProperty[] FHHCKMLHNPE(TClass HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x403EA80", Offset = "0x403DC80", VA = "0x18403EA80", Slot = "4")]
		public override void KBPFNBLAFON(MethodInfo DFKACHGFPKF, MethodInfo IPGEGJGGOIF, IMLDLIHJJAP FLPJMDMACMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3A44620", Offset = "0x3A43820", VA = "0x183A44620")]
		protected NGFMEIDICHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DLNGCLOAHAG<TClass, TProperty> : NGFMEIDICHJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void ECLMJLHIEIC(OLJPDINKIPG JPCMMEHHHNC, [Out] TProperty NMHCDGLGALC);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void GOIIFEKNHGP(FLOKACNOMCJ KLBKDHONFBL, TProperty NMHCDGLGALC);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5132570", Offset = "0x5131770", VA = "0x185132570", Slot = "5")]
		public override void AGJBOGGPKJE(TClass HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5132960", Offset = "0x5131B60", VA = "0x185132960", Slot = "6")]
		public override void PDEJFMIBDBD(TClass HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5132850", Offset = "0x5131A50", VA = "0x185132850", Slot = "7")]
		public override void EOLHAPBBBGP(TClass HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5132670", Offset = "0x5131870", VA = "0x185132670", Slot = "8")]
		public override void CGDOICNIHIB(TClass HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x37FA320", Offset = "0x37F9520", VA = "0x1837FA320")]
		protected DLNGCLOAHAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class PDPGPOJGPPE<T> : NGFMEIDICHJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x42648F0", Offset = "0x4263AF0", VA = "0x1842648F0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4264A00", Offset = "0x4263C00", VA = "0x184264A00", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x42649A0", Offset = "0x4263BA0", VA = "0x1842649A0", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4264950", Offset = "0x4263B50", VA = "0x184264950", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public PDPGPOJGPPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class CDBPOPHDNHL<T> : NGFMEIDICHJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4B589F0", Offset = "0x4B57BF0", VA = "0x184B589F0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4264A00", Offset = "0x4263C00", VA = "0x184264A00", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4B58A50", Offset = "0x4B57C50", VA = "0x184B58A50", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4264950", Offset = "0x4263B50", VA = "0x184264950", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public CDBPOPHDNHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KKHKLEAAFPD<T> : NGFMEIDICHJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A530", Offset = "0x3C99730", VA = "0x183C9A530", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CBE0", Offset = "0x3C1BDE0", VA = "0x183C1CBE0", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A590", Offset = "0x3C99790", VA = "0x183C9A590", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CB30", Offset = "0x3C1BD30", VA = "0x183C1CB30", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public KKHKLEAAFPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class JJACIBDBLCF<T> : NGFMEIDICHJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CAD0", Offset = "0x3C1BCD0", VA = "0x183C1CAD0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CBE0", Offset = "0x3C1BDE0", VA = "0x183C1CBE0", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CB80", Offset = "0x3C1BD80", VA = "0x183C1CB80", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CB30", Offset = "0x3C1BD30", VA = "0x183C1CB30", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public JJACIBDBLCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class BCINNANMDIB<T> : NGFMEIDICHJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4891F00", Offset = "0x4891100", VA = "0x184891F00", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x427BD80", Offset = "0x427AF80", VA = "0x18427BD80", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4891F60", Offset = "0x4891160", VA = "0x184891F60", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C66990", Offset = "0x3C65B90", VA = "0x183C66990", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public BCINNANMDIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class POLHIBHEAKD<T> : NGFMEIDICHJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x427BCC0", Offset = "0x427AEC0", VA = "0x18427BCC0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x427BD80", Offset = "0x427AF80", VA = "0x18427BD80", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x427BD20", Offset = "0x427AF20", VA = "0x18427BD20", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C66990", Offset = "0x3C65B90", VA = "0x183C66990", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public POLHIBHEAKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PIILCALHOIC<T> : NGFMEIDICHJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C5A0", Offset = "0x3D1B7A0", VA = "0x183D1C5A0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C6B0", Offset = "0x3D1B8B0", VA = "0x183D1C6B0", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x42736F0", Offset = "0x42728F0", VA = "0x1842736F0", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C600", Offset = "0x3D1B800", VA = "0x183D1C600", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public PIILCALHOIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class LBHGPBELONL<T> : NGFMEIDICHJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C5A0", Offset = "0x3D1B7A0", VA = "0x183D1C5A0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C6B0", Offset = "0x3D1B8B0", VA = "0x183D1C6B0", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C650", Offset = "0x3D1B850", VA = "0x183D1C650", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C600", Offset = "0x3D1B800", VA = "0x183D1C600", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public LBHGPBELONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DLJJCIGEJGB<T> : NGFMEIDICHJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5130180", Offset = "0x512F380", VA = "0x185130180", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5130240", Offset = "0x512F440", VA = "0x185130240", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x51301E0", Offset = "0x512F3E0", VA = "0x1851301E0", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4264950", Offset = "0x4263B50", VA = "0x184264950", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public DLJJCIGEJGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class KBDKJHJCOBK<T> : NGFMEIDICHJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C66930", Offset = "0x3C65B30", VA = "0x183C66930", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C66A40", Offset = "0x3C65C40", VA = "0x183C66A40", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C669E0", Offset = "0x3C65BE0", VA = "0x183C669E0", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C66990", Offset = "0x3C65B90", VA = "0x183C66990", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public KBDKJHJCOBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PDNPPHFONLB<T> : NGFMEIDICHJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42647E0", Offset = "0x42639E0", VA = "0x1842647E0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x42648A0", Offset = "0x4263AA0", VA = "0x1842648A0", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4264840", Offset = "0x4263A40", VA = "0x184264840", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C600", Offset = "0x3D1B800", VA = "0x183D1C600", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CC30", Offset = "0x3C1BE30", VA = "0x183C1CC30")]
		public PDNPPHFONLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class BBFBCPKNJHH<T> : DLNGCLOAHAG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4890FE0", Offset = "0x48901E0", VA = "0x184890FE0", Slot = "12")]
		protected override void GOIIFEKNHGP(FLOKACNOMCJ KLBKDHONFBL, char NMHCDGLGALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4890FB0", Offset = "0x48901B0", VA = "0x184890FB0", Slot = "11")]
		protected override void ECLMJLHIEIC(OLJPDINKIPG JPCMMEHHHNC, [Out] char NMHCDGLGALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3993840", Offset = "0x3992A40", VA = "0x183993840")]
		public BBFBCPKNJHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KIFNOMMCJMA<T> : DLNGCLOAHAG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C94C40", Offset = "0x3C93E40", VA = "0x183C94C40", Slot = "12")]
		protected override void GOIIFEKNHGP(FLOKACNOMCJ KLBKDHONFBL, IPEndPoint NMHCDGLGALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C94C00", Offset = "0x3C93E00", VA = "0x183C94C00", Slot = "11")]
		protected override void ECLMJLHIEIC(OLJPDINKIPG JPCMMEHHHNC, [Out] IPEndPoint NMHCDGLGALC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3993840", Offset = "0x3992A40", VA = "0x183993840")]
		public KIFNOMMCJMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class FDPABONJJPJ<T> : NGFMEIDICHJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int CDJPOICJGCE;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x37F6F80", Offset = "0x37F6180", VA = "0x1837F6F80")]
		public FDPABONJJPJ(int EPLLLIOIBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x37F6DE0", Offset = "0x37F5FE0", VA = "0x1837F6DE0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x37F6F20", Offset = "0x37F6120", VA = "0x1837F6F20", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x37F6EB0", Offset = "0x37F60B0", VA = "0x1837F6EB0", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x37F6E50", Offset = "0x37F6050", VA = "0x1837F6E50", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class EHJNGFBNCLK<T> : LICFOIEMNEH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo JADHKKBJOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type GFMBHELHAEF;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3479A50", Offset = "0x3478C50", VA = "0x183479A50")]
		public EHJNGFBNCLK(PropertyInfo KCBHGLJDNNP, Type FLHDIDDDAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3479760", Offset = "0x3478960", VA = "0x183479760", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x34799A0", Offset = "0x3478BA0", VA = "0x1834799A0", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x34798E0", Offset = "0x3478AE0", VA = "0x1834798E0", Slot = "7")]
		public override void EOLHAPBBBGP(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3479820", Offset = "0x3478A20", VA = "0x183479820", Slot = "8")]
		public override void CGDOICNIHIB(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3479940", Offset = "0x3478B40", VA = "0x183479940", Slot = "9")]
		public override void KMDPNKBGBNC(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3479880", Offset = "0x3478A80", VA = "0x183479880", Slot = "10")]
		public override void ELALDEIOIMI(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class LFEPANBOEFF<T> : EHJNGFBNCLK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3462990", Offset = "0x3461B90", VA = "0x183462990")]
		public LFEPANBOEFF(PropertyInfo KCBHGLJDNNP, Type FLHDIDDDAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BAB0", Offset = "0x3D2ACB0", VA = "0x183D2BAB0", Slot = "5")]
		public override void AGJBOGGPKJE(T HFADLFKDACP, OLJPDINKIPG JPCMMEHHHNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BB70", Offset = "0x3D2AD70", VA = "0x183D2BB70", Slot = "6")]
		public override void PDEJFMIBDBD(T HFADLFKDACP, FLOKACNOMCJ KLBKDHONFBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class NJKALLLLOKB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static NJKALLLLOKB<T> KMGHIJMKCHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly LICFOIEMNEH<T>[] FFAEIGBHPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int CINHDJPEDLC;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4078BB0", Offset = "0x4077DB0", VA = "0x184078BB0")]
		public NJKALLLLOKB(List<LICFOIEMNEH<T>> LBBDABGKLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4078B00", Offset = "0x4077D00", VA = "0x184078B00")]
		public void PDEJFMIBDBD(T JFJMICPDNDH, FLOKACNOMCJ KPDGEKKKOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4078A50", Offset = "0x4077C50", VA = "0x184078A50")]
		public void AGJBOGGPKJE(T JFJMICPDNDH, OLJPDINKIPG CAMFAGAEHOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class OMDNDPHGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract LICFOIEMNEH<T> OLBNKGLEPPK<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private FLOKACNOMCJ KELOCFBDJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int MCHFPBHMODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, OMDNDPHGOJO> EDHPNFLJKHI;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5667CB0", Offset = "0x5666EB0", VA = "0x185667CB0")]
	public IMHEEFMGDMF(int OENIFFBJOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x292FA30", Offset = "0x292EC30", VA = "0x18292FA30")]
	private NJKALLLLOKB<T> PBJOBINOGOD<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x28ECA90", Offset = "0x28EBC90", VA = "0x1828ECA90")]
	public void FPMBLPAHIMD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x292F950", Offset = "0x292EB50", VA = "0x18292F950")]
	public bool LKMADFBDLGL<T>(OLJPDINKIPG CAMFAGAEHOD, T IOCBLPNBBJM) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x292F9D0", Offset = "0x292EBD0", VA = "0x18292F9D0")]
	public void OHDBDPJBHPM<T>(FLOKACNOMCJ KPDGEKKKOHO, T JFJMICPDNDH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class JFHFKMDGKFO
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime HJECPOGIEOJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] MNKEOMKCPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OBBKOPDNHJF OIJKKCBOGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5668A50", Offset = "0x5667C50", VA = "0x185668A50")]
		get
		{
			return default(OBBKOPDNHJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BFGIOIPIODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5668A20", Offset = "0x5667C20", VA = "0x185668A20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5668580", Offset = "0x5667780", VA = "0x185668580")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LIDEONMDJLP GPFBBJKAKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5667D50", Offset = "0x5666F50", VA = "0x185667D50")]
		get
		{
			return default(LIDEONMDJLP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x56689E0", Offset = "0x5667BE0", VA = "0x1856689E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NPIKPKONAKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5668720", Offset = "0x5667920", VA = "0x185668720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint HGKANCAALFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5668870", Offset = "0x5667A70", VA = "0x185668870")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? JIGLHEHNPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5668C80", Offset = "0x5667E80", VA = "0x185668C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? IKIJMEJEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5668120", Offset = "0x5667320", VA = "0x185668120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CHNCNLMHHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x56688F0", Offset = "0x5667AF0", VA = "0x1856688F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x56683B0", Offset = "0x56675B0", VA = "0x1856683B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? OLMJAGHJCIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAEBD30", Offset = "0xAEAF30", VA = "0x180AEBD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x91B500", Offset = "0x91A700", VA = "0x18091B500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5668DC0", Offset = "0x5667FC0", VA = "0x185668DC0")]
	public JFHFKMDGKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5668D10", Offset = "0x5667F10", VA = "0x185668D10")]
	internal JFHFKMDGKFO(byte[] CGAHJPHALBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5668750", Offset = "0x5667950", VA = "0x185668750")]
	public static JFHFKMDGKFO FGKGAJCJJNA(byte[] CGAHJPHALBC, DateTime EIHMPAHCACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5668150", Offset = "0x5667350", VA = "0x185668150")]
	internal void BNNBIHIDKBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5667F50", Offset = "0x5667150", VA = "0x185667F50")]
	private void BGAAHJGLJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5668A80", Offset = "0x5667C80", VA = "0x185668A80")]
	private DateTime? OLGPELMFMID(int BJPGLMJPACN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5667D80", Offset = "0x5666F80", VA = "0x185667D80")]
	private void ALFBLDPCMKL(int BJPGLMJPACN, DateTime? NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x56685C0", Offset = "0x56677C0", VA = "0x1856685C0")]
	private ulong DCICPMCMEFG(int BJPGLMJPACN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5668920", Offset = "0x5667B20", VA = "0x185668920")]
	private void KCEMFDEPCFH(int BJPGLMJPACN, ulong NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5668690", Offset = "0x5667890", VA = "0x185668690")]
	private uint DMFFGKMBFGP(int BJPGLMJPACN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x553FFC0", Offset = "0x553F1C0", VA = "0x18553FFC0")]
	private static uint CGPJFCDCBEJ(uint KPEEHKEJDAP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5668350", Offset = "0x5667550", VA = "0x185668350")]
	private static ulong CGPJFCDCBEJ(ulong KPEEHKEJDAP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum OBBKOPDNHJF
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
public enum LIDEONMDJLP
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LIFCNNDCNJO
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int KOHHGPNKHHO = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int BJMDHBCHICF = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int BEBDDIEJCEK = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint KHOMHJPKCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int PJCHPLCGKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int ABKOEKBJGKD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GAOLLJINDPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x566DBF0", Offset = "0x566CDF0", VA = "0x18566DBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x566DC00", Offset = "0x566CE00", VA = "0x18566DC00")]
	public bool HFLPBOLMPEP(DBEFEJCJIHA GFMGJEBPFKF, int HOGBMKKOGBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class IJOGOBKMMLP : DBEFEJCJIHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket GFMGJEBPFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly EMHCIDGBHAF ONKIOKNDNAK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short HGBEKCIMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5667580", Offset = "0x5666780", VA = "0x185667580", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int PFEOGNLMFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5667BE0", Offset = "0x5666DE0", VA = "0x185667BE0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint HPBAFNLLCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x56675E0", Offset = "0x56667E0", VA = "0x1856675E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily LLENFCBPLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D07E20", Offset = "0x3D07020", VA = "0x183D07E20", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5667C00", Offset = "0x5666E00", VA = "0x185667C00")]
	public IJOGOBKMMLP(AddressFamily MCLJCAHPHIH, EMHCIDGBHAF ONKIOKNDNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5667620", Offset = "0x5666820", VA = "0x185667620", Slot = "8")]
	public bool HHIKPOOHMOJ(IPEndPoint DNBBAENCDNF, DFBDDOEPFPL AKNKONGNMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x56675A0", Offset = "0x56667A0", VA = "0x1856675A0", Slot = "9")]
	public int EBALEKKGJAK(byte[] BCDEBAAMJOP, int BJPGLMJPACN, int MKJBDDDPMKM, IPEndPoint AFOKIPAMHJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5667490", Offset = "0x5666690", VA = "0x185667490", Slot = "10")]
	public int ACJFFJINDLI(byte[] BCDEBAAMJOP, EndPoint MECODOOBCIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5667600", Offset = "0x5666800", VA = "0x185667600", Slot = "11")]
	public void GPHIJBCKBMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface DBEFEJCJIHA
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short HGBEKCIMHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int PFEOGNLMFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint HPBAFNLLCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily LLENFCBPLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HHIKPOOHMOJ(IPEndPoint DNBBAENCDNF, DFBDDOEPFPL AKNKONGNMCF);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int EBALEKKGJAK(byte[] BCDEBAAMJOP, int BJPGLMJPACN, int MKJBDDDPMKM, IPEndPoint AFOKIPAMHJF);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int ACJFFJINDLI(byte[] BCDEBAAMJOP, EndPoint AFOKIPAMHJF);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GPHIJBCKBMA();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct BAFIPLDJBBA : IEquatable<BAFIPLDJBBA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long PEBCFMHDAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long OGPGAHIILAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long MGMMAAJPPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int ELNKFJGHFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int FCCIADDMMOP;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x565CCD0", Offset = "0x565BED0", VA = "0x18565CCD0")]
	public BAFIPLDJBBA(byte[] LEEOLPPCLJD, int FHMOKMIGIBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7DCE60", Offset = "0x7DC060", VA = "0x1807DCE60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x565CBE0", Offset = "0x565BDE0", VA = "0x18565CBE0", Slot = "4")]
	public bool Equals(BAFIPLDJBBA NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x565CC20", Offset = "0x565BE20", VA = "0x18565CC20", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class IIGIFFPFCJN : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] GIHDELAMDFH;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class DELJDOMEHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int DIBEMDMCPBC;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
	protected DELJDOMEHBA(int BJMMPENCGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IGIIEAOFFED(IPEndPoint DNBBAENCDNF, byte[] FODGEDCJIDC, int BJPGLMJPACN, int HHOELNLHIEN);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LCOFFDHDNGM(IPEndPoint DNBBAENCDNF, byte[] FODGEDCJIDC, int BJPGLMJPACN, int HHOELNLHIEN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DJJANOOODNO : DELJDOMEHBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider EKDJDMBHEPK;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator NMAKCONFKGK;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x565E730", Offset = "0x565D930", VA = "0x18565E730")]
	public DJJANOOODNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x565DB00", Offset = "0x565CD00", VA = "0x18565DB00")]
	public void AKGBICKLKBM(IPEndPoint DNBBAENCDNF, byte[] GOBGGNLGONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x565DD40", Offset = "0x565CF40", VA = "0x18565DD40")]
	public void FLHINGMJMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x565E2B0", Offset = "0x565D4B0", VA = "0x18565E2B0")]
	private byte[] JBEIAAJHNII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x565DE20", Offset = "0x565D020", VA = "0x18565DE20", Slot = "4")]
	public override void IGIIEAOFFED(IPEndPoint DNBBAENCDNF, byte[] FODGEDCJIDC, int BJPGLMJPACN, int HHOELNLHIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x565E340", Offset = "0x565D540", VA = "0x18565E340", Slot = "5")]
	public override void LCOFFDHDNGM(IPEndPoint DNBBAENCDNF, byte[] FODGEDCJIDC, int BJPGLMJPACN, int HHOELNLHIEN)
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
