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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NCDBEBLDIGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum BDKMBEDOLEE
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
		private NetworkManager EODHCFIGGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool FHKODOMEGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, KKCLOBJMJHA> CBGOGLKMJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private HFMDBGMAHCC OCFGDKDEHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch ALICCJMIGID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] LMLJIKKOBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BDKMBEDOLEE GPKIEHLJBGO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong HFLMFDKLIIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MOJNHDHPCDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6BC5B90", Offset = "0x6BC4590", VA = "0x186BC5B90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5110", Offset = "0x6BC3B10", VA = "0x186BC5110")]
		public void RecRoom_SetEncryptionInfo(ulong OAEMGMHJCPB, byte[] NJBPFCDJFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BC50F0", Offset = "0x6BC3AF0", VA = "0x186BC50F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4FC0", Offset = "0x6BC39C0", VA = "0x186BC4FC0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5A90", Offset = "0x6BC4490", VA = "0x186BC5A90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5230", Offset = "0x6BC3C30", VA = "0x186BC5230", Slot = "6")]
		public override void Send(ulong GFDJFLGIFIE, ArraySegment<byte> DFPGGEDGGGN, NetworkDelivery OFFJNNOINML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC50B0", Offset = "0x6BC3AB0", VA = "0x186BC50B0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong GFDJFLGIFIE, [Out] ArraySegment<byte> ECGNDACMANN, [Out] float FNOGJNCMCDN)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5520", Offset = "0x6BC3F20", VA = "0x186BC5520", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6BC59B0", Offset = "0x6BC43B0", VA = "0x186BC59B0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC47D0", Offset = "0x6BC31D0", VA = "0x186BC47D0", Slot = "11")]
		public override void DisconnectRemoteClient(ulong GFDJFLGIFIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC46E0", Offset = "0x6BC30E0", VA = "0x186BC46E0", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4B10", Offset = "0x6BC3510", VA = "0x186BC4B10", Slot = "13")]
		public override ulong GetCurrentRtt(ulong GFDJFLGIFIE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BC54B0", Offset = "0x6BC3EB0", VA = "0x186BC54B0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4C80", Offset = "0x6BC3680", VA = "0x186BC4C80", Slot = "15")]
		public override void Initialize([Optional] NetworkManager EODHCFIGGFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4BB0", Offset = "0x6BC35B0", VA = "0x186BC4BB0")]
		private PEGNAIILGMK HBIEJJCGIKA(NetworkDelivery OHCGINPDMEI)
		{
			return default(PEGNAIILGMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4620", Offset = "0x6BC3020", VA = "0x186BC4620", Slot = "16")]
		private void CHHKHALGOBH(KKCLOBJMJHA KIIKJJKAEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4EF0", Offset = "0x6BC38F0", VA = "0x186BC4EF0", Slot = "17")]
		private void KKPCEDNMHNN(KKCLOBJMJHA KIIKJJKAEGH, MJOBGJFBLJL LLMFBAPNEGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "18")]
		private void GOCOBIBIDLD(IPEndPoint CAJFODPDOMM, SocketError PNAOOGKAEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BC48E0", Offset = "0x6BC32E0", VA = "0x186BC48E0", Slot = "19")]
		private void FNCGPLLLGDF(KKCLOBJMJHA KIIKJJKAEGH, PELHEKIJIGC BDHKEKKPKBC, byte KEFOCPMEJEH, PEGNAIILGMK EHODKPNLOLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4510", Offset = "0x6BC2F10", VA = "0x186BC4510")]
		private void ANGLEOMIKPJ(int PICLDLMFMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "20")]
		private void NFFACBHMKPL(IPEndPoint LBKKPFODLCH, PELHEKIJIGC BDHKEKKPKBC, IKMGCLELIJF GFLHGADMCAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "21")]
		private void LFOAEEHDADP(KKCLOBJMJHA KIIKJJKAEGH, int LNHLOBCPLNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4E90", Offset = "0x6BC3890", VA = "0x186BC4E90", Slot = "22")]
		private void KIADMAMOHFK(DCFLIPOBPOJ EELGNOJLLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC45F0", Offset = "0x6BC2FF0", VA = "0x186BC45F0")]
		private ulong BOCJIEOMIPN(KKCLOBJMJHA KIIKJJKAEGH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4AF0", Offset = "0x6BC34F0", VA = "0x186BC4AF0")]
		private static int GPNKBPLKPIJ(float KFGHOINKLDG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BC5AB0", Offset = "0x6BC44B0", VA = "0x186BC5AB0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class ALCLBFEFELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly KKCLOBJMJHA OBFGHCMGGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ConcurrentQueue<BPDEDHBPICL> FMCCHCDKLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int PGHLNMFIBEP;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0E20", Offset = "0x6BAF820", VA = "0x186BB0E20")]
	protected ALCLBFEFELL(KKCLOBJMJHA KIIKJJKAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0D00", Offset = "0x6BAF700", VA = "0x186BB0D00")]
	public void BDBGGIFFMOI(BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0DA0", Offset = "0x6BAF7A0", VA = "0x186BB0DA0")]
	protected void IMCDCILBPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0D60", Offset = "0x6BAF760", VA = "0x186BB0D60")]
	public bool DCMHMDDBCFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool OJDDKFLCNIK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CJHMJDBDEMM(BPDEDHBPICL CBIMINNEJOD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KNKMCJDLDAD
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
public class DCFLIPOBPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly HFMDBGMAHCC BHKIOGKKLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private int CBAHPNIJLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal GMECDJMMGHP PBHMDPOPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly IPEndPoint BFNJAICAKPL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KNKMCJDLDAD KIEKGOJDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D5A10", Offset = "0x9D4410", VA = "0x1809D5A10")]
		[CompilerGenerated]
		get
		{
			return default(KNKMCJDLDAD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCD2F80", Offset = "0xCD1980", VA = "0x180CD2F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2800", Offset = "0x6BB1200", VA = "0x186BB2800")]
	internal void IBLENDMDMLD(GMECDJMMGHP GMLECEGGKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BB28C0", Offset = "0x6BB12C0", VA = "0x186BB28C0")]
	private bool ONOKOGOBKCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BB28F0", Offset = "0x6BB12F0", VA = "0x186BB28F0")]
	internal DCFLIPOBPOJ(IPEndPoint LBKKPFODLCH, GMECDJMMGHP BIILAJKBDDI, HFMDBGMAHCC LENLMBAPKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2860", Offset = "0x6BB1260", VA = "0x186BB2860")]
	public KKCLOBJMJHA LIPMMLADAMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum IKMGCLELIJF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum AKLBANONHBL
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
public struct MJOBGJFBLJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public AKLBANONHBL KEBICCJGCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public SocketError DEEEHANAFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public PELHEKIJIGC BEJCMFJKCCM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NCDBEBLDIGD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKPONIMCFAB(KKCLOBJMJHA KIIKJJKAEGH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFCPFEPJAJL(KKCLOBJMJHA KIIKJJKAEGH, MJOBGJFBLJL LLMFBAPNEGM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHMOHMLLBHK(IPEndPoint CAJFODPDOMM, SocketError PNAOOGKAEFC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHAADAPDPPA(KKCLOBJMJHA KIIKJJKAEGH, PELHEKIJIGC BDHKEKKPKBC, byte KEFOCPMEJEH, PEGNAIILGMK EHODKPNLOLC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KEHDOLLEHCD(IPEndPoint LBKKPFODLCH, PELHEKIJIGC BDHKEKKPKBC, IKMGCLELIJF GFLHGADMCAD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void POGJLKHCBGE(KKCLOBJMJHA KIIKJJKAEGH, int LNHLOBCPLNA);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LBPPBLKOHEN(DCFLIPOBPOJ EELGNOJLLOB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JGOOAEHAJAK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIONJJMNNEO(KKCLOBJMJHA KIIKJJKAEGH, object IOMOKKAIBLH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BCPPJNGMILI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFJHEINFADO(LECAHECPANG CBIMINNEJOD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface FGIGCCHAOPG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCHPBCHCEIN(KKCLOBJMJHA KIIKJJKAEGH, IPEndPoint KFGPJOOIHJD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class GMECDJMMGHP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const int OOHDLABKNGI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly long KNHKFHLCNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public byte LOGACIOKKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly byte[] GCDDPNCAIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly JNHELJKFMLK LPLAAGCJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly int BJCMBBOPJEE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2E90", Offset = "0x6BB1890", VA = "0x186BB2E90")]
	private GMECDJMMGHP(long NMCMHKANDAL, byte JIJOCLIJJOK, int CEJEEJJKEJL, byte[] DGIPOBENPPA, JNHELJKFMLK DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2E30", Offset = "0x6BB1830", VA = "0x186BB2E30")]
	public static int NBFPNLNFNHJ(BPDEDHBPICL CBIMINNEJOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2C10", Offset = "0x6BB1610", VA = "0x186BB2C10")]
	public static GMECDJMMGHP BDFLEPOCNFK(BPDEDHBPICL CBIMINNEJOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2A30", Offset = "0x6BB1430", VA = "0x186BB2A30")]
	public static BPDEDHBPICL APJHJNEDLBK(KHLMPEHHMJA PHPHICALAKD, SocketAddress OINFMIKNOOH, long JPPNEHIHMAF, int CEJEEJJKEJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class CNHIHFADGMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly long KNHKFHLCNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly byte LOGACIOKKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly int BJCMBBOPJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly bool PLHHAPKNNMG;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BB27B0", Offset = "0x6BB11B0", VA = "0x186BB27B0")]
	private CNHIHFADGMN(long NMCMHKANDAL, byte JIJOCLIJJOK, int CKMGKKNLFFG, bool BBJIEGFLDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2560", Offset = "0x6BB0F60", VA = "0x186BB2560")]
	public static CNHIHFADGMN BDFLEPOCNFK(BPDEDHBPICL CBIMINNEJOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2470", Offset = "0x6BB0E70", VA = "0x186BB2470")]
	public static BPDEDHBPICL APJHJNEDLBK(long JPPNEHIHMAF, byte KGDKMMENILG, int PEBMGINKDMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB26B0", Offset = "0x6BB10B0", VA = "0x186BB26B0")]
	public static BPDEDHBPICL HELDDFFNDGP(KKCLOBJMJHA KIIKJJKAEGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum AKGGJMNLKDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JKJPMOCNFCJ
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEIJMPEDFHH(IPEndPoint IOPLDENLKMK, IPEndPoint LBKKPFODLCH, string GNAAILLDOKI);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIPBNIEECAB(IPEndPoint DLCELNIOMFI, AKGGJMNLKDJ OHCGINPDMEI, string GNAAILLDOKI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CLMPFOHCGGP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct CIJDEGNELMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public IPEndPoint PDMOFNOCBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint BFNJAICAKPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string PLJNONKKEDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FJICFCANPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint HPEAEHDCMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AKGGJMNLKDJ ABBLELNBDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string PLJNONKKEDA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class HLLKJKMNKNE
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint OFJNOOAIPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string PLJNONKKEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public HLLKJKMNKNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class FIOBBILNAGO
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint OFJNOOAIPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LPOPFFFMBOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string PLJNONKKEDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public FIOBBILNAGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class JOKGLKPKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PLJNONKKEDA
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OMGCCGMHPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA45A60", Offset = "0xA44460", VA = "0x180A45A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9BABA0", Offset = "0x9B95A0", VA = "0x1809BABA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JOKGLKPKBBG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HFMDBGMAHCC FGIKOMFLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ConcurrentQueue<CIJDEGNELMB> ADFLADMHMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ConcurrentQueue<FJICFCANPLM> MMLPFABMDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JNHELJKFMLK LPKAHEDMIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KHLMPEHHMJA IJJIPKEAKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly AFGKFCIGOOA GHDNEABJADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private JKJPMOCNFCJ CCKAGGKADGO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int EMLECIHELEC = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool GIFBGNEFBIO;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2020", Offset = "0x6BB0A20", VA = "0x186BB2020")]
	internal CLMPFOHCGGP(HFMDBGMAHCC IENDDBOLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1EA0", Offset = "0x6BB08A0", VA = "0x186BB1EA0")]
	internal void NCHKPODICAO(IPEndPoint PECGPCLOJMJ, BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3424C00", Offset = "0x3423600", VA = "0x183424C00")]
	private void BPJNPCBNDJL<T>(T CBIMINNEJOD, IPEndPoint HIKBDNMPFJK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1BB0", Offset = "0x6BB05B0", VA = "0x186BB1BB0")]
	private void EEIJMPEDFHH(HLLKJKMNKNE AFGFAGHIDPI, IPEndPoint PECGPCLOJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1D40", Offset = "0x6BB0740", VA = "0x186BB1D40")]
	private void IPBIPJJCOLF(FIOBBILNAGO AFGFAGHIDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1A20", Offset = "0x6BB0420", VA = "0x186BB1A20")]
	private void DKJFHCMKAKE(JOKGLKPKBBG AFGFAGHIDPI, IPEndPoint PECGPCLOJMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum PEGNAIILGMK : byte
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
public enum NGBFDGNABBL : long
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EFPEOGFHONB
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal static readonly int[] LPNNFEJEJOL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly int DLAPECNBFNB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly int ELOCOOMFFFN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IOANHAFIBCF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE00", Offset = "0x6BB9800", VA = "0x186BBAE00")]
	public IOANHAFIBCF(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LIHKEDOJKJF : IOANHAFIBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE00", Offset = "0x6BB9800", VA = "0x186BBAE00")]
	public LIHKEDOJKJF(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PLDONJFLLMN
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
public interface PJHDLKJHCNI
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COCJGJOOCGB(PLDONJFLLMN GMIJLFKOMMB, string FHBIJDIKBHA, params object[] CPDOLKLJBKL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class JJPOMCBDGOM
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static PJHDLKJHCNI MOBAODPIOBH;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly object GANIBDMBFCM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC0F0", Offset = "0x6BBAAF0", VA = "0x186BBC0F0")]
	private static void NEGIMCAGOEB(PLDONJFLLMN KOOAMBEECGM, string FHBIJDIKBHA, params object[] CPDOLKLJBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC090", Offset = "0x6BBAA90", VA = "0x186BBC090")]
	internal static void LMMCJINBBDE(string FHBIJDIKBHA, params object[] CPDOLKLJBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC030", Offset = "0x6BBAA30", VA = "0x186BBC030")]
	internal static void HBOCJNNNNFN(string FHBIJDIKBHA, params object[] CPDOLKLJBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC320", Offset = "0x6BBAD20", VA = "0x186BBC320")]
	internal static void OJPFBHIMGGB(string FHBIJDIKBHA, params object[] CPDOLKLJBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum BHFNOKNMIKO
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class PELHEKIJIGC : JNHELJKFMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private BPDEDHBPICL PNBELHJDIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HFMDBGMAHCC DLCNKJBLPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly IMGKEMBNEFG PJGCHHLHMBO;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BC75E0", Offset = "0x6BC5FE0", VA = "0x186BC75E0")]
	internal PELHEKIJIGC(HFMDBGMAHCC GIGHOMPCPHH, IMGKEMBNEFG DKOJJABANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BC74C0", Offset = "0x6BC5EC0", VA = "0x186BC74C0")]
	internal void FLIKPCMPFNI(BPDEDHBPICL CBIMINNEJOD, int JFNMADEPLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7530", Offset = "0x6BC5F30", VA = "0x186BC7530")]
	internal void IOCKDGJDKIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC75B0", Offset = "0x6BC5FB0", VA = "0x186BC75B0")]
	public void JBLNLMHEHAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class IMGKEMBNEFG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum ICPCJJAHHPN
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
	public IMGKEMBNEFG AJHMAPOACNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public ICPCJJAHHPN ABBLELNBDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public KKCLOBJMJHA OBFGHCMGGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public IPEndPoint BFNJAICAKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public object OJKFIABACJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int DEPOGIHEGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SocketError INLDPFKAPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public AKLBANONHBL FLHLOOOLOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public DCFLIPOBPOJ DJOGDJMOGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public PEGNAIILGMK OGMPOJEELFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public byte AFACFLOEDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public readonly PELHEKIJIGC NAOCAHPECDL;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAD60", Offset = "0x6BB9760", VA = "0x186BBAD60")]
	public IMGKEMBNEFG(HFMDBGMAHCC GIGHOMPCPHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HFMDBGMAHCC : IEnumerable<KKCLOBJMJHA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class KLMFDABDHDJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC2B90", Offset = "0x6BC1590", VA = "0x186BC2B90", Slot = "4")]
		public bool Equals(IPEndPoint CJBFFOKBLHB, IPEndPoint CNBLFOFLDDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3F40740", Offset = "0x3F3F140", VA = "0x183F40740", Slot = "5")]
		public int GetHashCode(IPEndPoint OIIGDBLKEDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KLMFDABDHDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct POOEGIAKCJB : IEnumerator<KKCLOBJMJHA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly KKCLOBJMJHA IICLNFEBEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private KKCLOBJMJHA GBEJNEGIHGC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KKCLOBJMJHA GNNLOKFDOIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xD0E7A0", Offset = "0xD0D1A0", VA = "0x180D0E7A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1906E10", Offset = "0x1905810", VA = "0x181906E10")]
		public POOEGIAKCJB(KKCLOBJMJHA GJPBKNDCAIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7630", Offset = "0x6BC6030", VA = "0x186BC7630", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7680", Offset = "0x6BC6080", VA = "0x186BC7680", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Thread AHNHBFFCBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool PJGFEBHNOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private bool MKOBCNJFNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private ALFNLLPJONJ INELHFDMAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AutoResetEvent BNDKMMGBGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Queue<IMGKEMBNEFG> OKFBGIHKLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<IMGKEMBNEFG> MKOMMOGLGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private IMGKEMBNEFG EANCLEPNCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NCDBEBLDIGD ELDNDMKGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly JGOOAEHAJAK DGGLILCFLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly BCPPJNGMILI DHKMLPHNACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly FGIGCCHAOPG PPCLMAEHAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly Dictionary<IPEndPoint, KKCLOBJMJHA> POEGIKFCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, DCFLIPOBPOJ> BHHEDNNJFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, CHBOJILABLJ> CBHODGEKGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly ReaderWriterLockSlim PDAALGNIHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private KKCLOBJMJHA NACMBLJJLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int JBGBAKOFCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly List<KKCLOBJMJHA> MOFDOOBOFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private KKCLOBJMJHA[] GPDFJHKJHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly BFGMJIBAKNN PCEELDMNOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private int LCMHAHPPEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ConcurrentQueue<int> OPPNPCJEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private byte HDOFAMCHMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly object AFLHKCCGGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool DDCMIKKPOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool FEMBIEAOHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public int EAPGLJOBKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int FLGDPBHOAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int COPMFNIOPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int GFAKDJEHMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool ILDEMKHKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE5")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool CJJLFMHIHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int OPCFDAHNJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int NGABCDDFNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int LJKKKNJICHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool GIFBGNEFBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF5")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool IHLDFAIKBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF6")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool ADBNALIEDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF7")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool PLFOMGHEPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int JCENKDEBLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int KOIPMLMCMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool BLPJKMILOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly MKJNPKOEEMD JEIEFKLGGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool OLAOIIDOLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly CLMPFOHCGGP FMOCEJPMOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool OFDKPKDECMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public BHFNOKNMIKO DECANEIBPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int LOHKIEKDHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool MENJCANHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x135")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool BBKBHOBMBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x136")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool KKLFMCCBJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x137")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool GFAKHNBJDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private BPDEDHBPICL MOKLOLIKNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int JCIJEOELBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object JLHJBMMJEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BPDEDHBPICL INBKKKMPEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int FNEJFIMENFM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const int LOADACKIMBC = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const int EKDBBHEFADA = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private KBJDEPEECJO LOMFOKIBELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private KBJDEPEECJO OGPBCMBOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Thread GJJBKIIHBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Thread LKIBCDCBIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IPEndPoint NDBOBPKFLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private IPEndPoint IEECJHNCEHM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	[ThreadStatic]
	private static byte[] ENLNNCEKBEM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	[ThreadStatic]
	private static byte[] CFIEONLCPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<KDNMJHJFPON, IPEndPoint> JHMFHCJOCDD;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly IPAddress AOGINMPFLCH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly bool HPNPIILDKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public int LAPDCOHDCEK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PCJFIPKPGAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x137BC70", Offset = "0x137A670", VA = "0x18137BC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BC50", Offset = "0x1D5A650", VA = "0x181D5BC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FCHPDKDGOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1483EB0", Offset = "0x14828B0", VA = "0x181483EB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BA90", Offset = "0x1D5A490", VA = "0x181D5BA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PGFJFNIHHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA40", Offset = "0xE8A440", VA = "0x180E8BA40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KCCDDBIPBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3CC0", Offset = "0x6BB26C0", VA = "0x186BB3CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short PHBGPMNKKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5270", Offset = "0x6BB3C70", VA = "0x186BB5270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6210", Offset = "0x6BB4C10", VA = "0x186BB6210")]
	public void JJBPLGEINNG(IPEndPoint CAJFODPDOMM, byte[] NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6A60", Offset = "0x6BB5460", VA = "0x186BB6A60")]
	public void KOJAALLFDGA(IPEndPoint CAJFODPDOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BB38C0", Offset = "0x6BB22C0", VA = "0x186BB38C0")]
	private bool BGBHFHKOKDO(IPEndPoint CAJFODPDOMM, [Out] KKCLOBJMJHA KIIKJJKAEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4540", Offset = "0x6BB2F40", VA = "0x186BB4540")]
	private void FPLNLAPHLKF(KKCLOBJMJHA KIIKJJKAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BB37F0", Offset = "0x6BB21F0", VA = "0x186BB37F0")]
	private void AFBPDGCBEKN(KKCLOBJMJHA KIIKJJKAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5850", Offset = "0x6BB4250", VA = "0x186BB5850")]
	private void JBDNIPMMKOM(KKCLOBJMJHA KIIKJJKAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA700", Offset = "0x6BB9100", VA = "0x186BBA700")]
	public HFMDBGMAHCC(NCDBEBLDIGD LENLMBAPKJM, [Optional] BFGMJIBAKNN KHFMPLBINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3850", Offset = "0x6BB2250", VA = "0x186BB3850")]
	internal void BCPPGEDGFCJ(KKCLOBJMJHA FHDIANMLEHA, int LNHLOBCPLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5800", Offset = "0x6BB4200", VA = "0x186BB5800")]
	internal void IONNCGFMIMJ(KKCLOBJMJHA FHDIANMLEHA, object IOMOKKAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4F10", Offset = "0x6BB3910", VA = "0x186BB4F10")]
	internal void GFGBMMHEMLK(KKCLOBJMJHA KIIKJJKAEGH, AKLBANONHBL NBAKHABPJGI, SocketError PDJCOGCIBLP, BPDEDHBPICL GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3DC0", Offset = "0x6BB27C0", VA = "0x186BB3DC0")]
	private void DEJMAELKMMO(KKCLOBJMJHA KIIKJJKAEGH, AKLBANONHBL NBAKHABPJGI, SocketError PDJCOGCIBLP, bool JDEIJIAFEMH, byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int PGJKBFGEJNK, BPDEDHBPICL GLECKDJIKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BB7F80", Offset = "0x6BB6980", VA = "0x186BB7F80")]
	private void LFAHDENNHHN(IMGKEMBNEFG.ICPCJJAHHPN OHCGINPDMEI, [Optional] KKCLOBJMJHA KIIKJJKAEGH, [Optional] IPEndPoint LBKKPFODLCH, SocketError CCAPIJPBJLK = SocketError.Success, int LNHLOBCPLNA = 0, AKLBANONHBL FPGFDCGPEIL = AKLBANONHBL.ConnectionFailed, [Optional] DCFLIPOBPOJ EKLMFCBCKHM, PEGNAIILGMK EHODKPNLOLC = PEGNAIILGMK.Unreliable, byte KEFOCPMEJEH = 0, [Optional] BPDEDHBPICL LHFMNNACNAG, [Optional] object IOMOKKAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BB91C0", Offset = "0x6BB7BC0", VA = "0x186BB91C0")]
	private void MLKOHFILHJJ(IMGKEMBNEFG DKOJJABANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4430", Offset = "0x6BB2E30", VA = "0x186BB4430")]
	internal void EBKLFACFAHE(IMGKEMBNEFG DKOJJABANLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4890", Offset = "0x6BB3290", VA = "0x186BB4890")]
	private void GBEACIHIBKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4F50", Offset = "0x6BB3950", VA = "0x186BB4F50")]
	private void HMIHCPIGKBA(int AIIKMDJKIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BB2F00", Offset = "0x6BB1900", VA = "0x186BB2F00")]
	internal KKCLOBJMJHA ACDJICJGFHB(DCFLIPOBPOJ EELGNOJLLOB, byte[] FDPBOOCEPAH, int GJCFLJFIOAP, int ENHEICOLGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5610", Offset = "0x6BB4010", VA = "0x186BB5610")]
	private int IFGICCBNPED()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6BB65B0", Offset = "0x6BB4FB0", VA = "0x186BB65B0")]
	private void KNLAEPGCLHA(IPEndPoint LBKKPFODLCH, KKCLOBJMJHA IKLCIHGAJNF, GMECDJMMGHP KIEINCIBKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6BB0", Offset = "0x6BB55B0", VA = "0x186BB6BB0")]
	private void LEEFPCKJACN(BPDEDHBPICL CBIMINNEJOD, IPEndPoint LBKKPFODLCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5330", Offset = "0x6BB3D30", VA = "0x186BB5330")]
	internal void ICPCALIGKHF(BPDEDHBPICL CBIMINNEJOD, PEGNAIILGMK JFAABKHDGLM, byte KEFOCPMEJEH, int JFNMADEPLOH, KKCLOBJMJHA FHDIANMLEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB90B0", Offset = "0x6BB7AB0", VA = "0x186BB90B0")]
	public bool MBHBHBLMGNA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9120", Offset = "0x6BB7B20", VA = "0x186BB9120")]
	public bool MBHBHBLMGNA(IPAddress EFDOCGMPIIO, IPAddress KLMJJGEBAIM, int NCJFFOCEFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9140", Offset = "0x6BB7B40", VA = "0x186BB9140")]
	public bool MBHBHBLMGNA(int NCJFFOCEFFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4BE0", Offset = "0x6BB35E0", VA = "0x186BB4BE0")]
	public void GBIAEPIHIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8740", Offset = "0x6BB7140", VA = "0x186BB8740")]
	public KKCLOBJMJHA MAJPJBBNHHP(string MJMDMDPCBDE, int NCJFFOCEFFI, string NJBPFCDJFGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8820", Offset = "0x6BB7220", VA = "0x186BB8820")]
	public KKCLOBJMJHA MAJPJBBNHHP(string MJMDMDPCBDE, int NCJFFOCEFFI, KHLMPEHHMJA ALLFHFPMHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8360", Offset = "0x6BB6D60", VA = "0x186BB8360")]
	public KKCLOBJMJHA MAJPJBBNHHP(IPEndPoint HIKBDNMPFJK, KHLMPEHHMJA ALLFHFPMHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3CB0", Offset = "0x6BB26B0", VA = "0x186BB3CB0")]
	public void BIEPMDDMFPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3960", Offset = "0x6BB2360", VA = "0x186BB3960")]
	public void BIEPMDDMFPH(bool KFGJGGJCIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6430", Offset = "0x6BB4E30", VA = "0x186BB6430")]
	public void JPHGGFGOGPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6BB64E0", Offset = "0x6BB4EE0", VA = "0x186BB64E0")]
	public void JPHGGFGOGPO(byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3D80", Offset = "0x6BB2780", VA = "0x186BB3D80")]
	public void DEJMAELKMMO(KKCLOBJMJHA KIIKJJKAEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3D40", Offset = "0x6BB2740", VA = "0x186BB3D40")]
	public void DEJMAELKMMO(KKCLOBJMJHA KIIKJJKAEGH, byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int PGJKBFGEJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA520", Offset = "0x6BB8F20", VA = "0x186BBA520", Slot = "4")]
	private IEnumerator<KKCLOBJMJHA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA5B0", Offset = "0x6BB8FB0", VA = "0x186BBA5B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5B20", Offset = "0x6BB4520", VA = "0x186BB5B20")]
	private BPDEDHBPICL JDADGPKCMJO(HHIKGKNGHMJ LDIFMBFDAPL, int PICLDLMFMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5C00", Offset = "0x6BB4600", VA = "0x186BB5C00")]
	private BPDEDHBPICL JDADGPKCMJO(HHIKGKNGHMJ LDIFMBFDAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA2E0", Offset = "0x6BB8CE0", VA = "0x186BBA2E0")]
	internal BPDEDHBPICL PPAJADBIMGK(int PICLDLMFMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6BB41D0", Offset = "0x6BB2BD0", VA = "0x186BB41D0")]
	internal void DMFJNEGOMIN(BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA640", Offset = "0x6BB9040", VA = "0x186BBA640")]
	static HFMDBGMAHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x137BC70", Offset = "0x137A670", VA = "0x18137BC70")]
	private bool LNAJNJCEACL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4D90", Offset = "0x6BB3790", VA = "0x186BB4D90")]
	private void GBLBFECGDDB(IPEndPoint FAICFBGPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9960", Offset = "0x6BB8360", VA = "0x186BB9960")]
	private void NEPIEKFEEIG(IPEndPoint FAICFBGPABG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5CE0", Offset = "0x6BB46E0", VA = "0x186BB5CE0")]
	private bool JDMJAKLOLEI(SocketException GKNCIBMNAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BB38A0", Offset = "0x6BB22A0", VA = "0x186BB38A0")]
	private void BDIGOCJBDIF(ALFNLLPJONJ IENDDBOLCPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3520", Offset = "0x6BB1F20", VA = "0x186BB3520")]
	private void ACHJKFONJPH(KBJDEPEECJO IENDDBOLCPK, EndPoint EKIBJOBOOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5E90", Offset = "0x6BB4890", VA = "0x186BB5E90")]
	private void JHGBIGGKJEA(object JCFJJCIGDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6BB8900", Offset = "0x6BB7300", VA = "0x186BB8900")]
	public bool MBHBHBLMGNA(IPAddress EFDOCGMPIIO, IPAddress KLMJJGEBAIM, int NCJFFOCEFFI, bool MNCHCKNFLKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6BB3CE0", Offset = "0x6BB26E0", VA = "0x186BB3CE0")]
	internal int CMAIPCADOFJ(BPDEDHBPICL CBIMINNEJOD, IPEndPoint LBKKPFODLCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6BBA2A0", Offset = "0x6BB8CA0", VA = "0x186BBA2A0")]
	internal int PBFCNIOADPI(BPDEDHBPICL CBIMINNEJOD, IPEndPoint LBKKPFODLCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9AC0", Offset = "0x6BB84C0", VA = "0x186BB9AC0")]
	internal int PBFCNIOADPI(byte[] FLPDJFEEMLN, int GJCFLJFIOAP, int ENHEICOLGJO, IPEndPoint LBKKPFODLCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5690", Offset = "0x6BB4090", VA = "0x186BB5690")]
	internal void IHHGPFCFOCJ(bool LMEEALMJGAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum HHIKGKNGHMJ : byte
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
internal sealed class BPDEDHBPICL
{
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int LJHKMNPHOLG;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int[] IDOAOBGFCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public byte[] MIPPOOKPMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public int FPLMNCHJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public object OJKFIABACJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public BPDEDHBPICL AJHMAPOACNG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public HHIKGKNGHMJ LDBNNDPEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0EC0", Offset = "0x6BAF8C0", VA = "0x186BB0EC0")]
		get
		{
			return default(HHIKGKNGHMJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1030", Offset = "0x6BAFA30", VA = "0x186BB1030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte LOGACIOKKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1450", Offset = "0x6BAFE50", VA = "0x186BB1450")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1240", Offset = "0x6BAFC40", VA = "0x186BB1240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LBHEIOFHAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0F30", Offset = "0x6BAF930", VA = "0x186BB0F30")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BB13B0", Offset = "0x6BAFDB0", VA = "0x186BB13B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AGGGDANEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1210", Offset = "0x6BAFC10", VA = "0x186BB1210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte OCMILHLEMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1070", Offset = "0x6BAFA70", VA = "0x186BB1070")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1280", Offset = "0x6BAFC80", VA = "0x186BB1280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort PJHOOKKAIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6BB13F0", Offset = "0x6BAFDF0", VA = "0x186BB13F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6BB10A0", Offset = "0x6BAFAA0", VA = "0x186BB10A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ONNBCJNONCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1480", Offset = "0x6BAFE80", VA = "0x186BB1480")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0EF0", Offset = "0x6BAF8F0", VA = "0x186BB0EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DFPDOMOEPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0F90", Offset = "0x6BAF990", VA = "0x186BB0F90")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0FF0", Offset = "0x6BAF9F0", VA = "0x186BB0FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6BB14E0", Offset = "0x6BAFEE0", VA = "0x186BB14E0")]
	static BPDEDHBPICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BB10E0", Offset = "0x6BAFAE0", VA = "0x186BB10E0")]
	public void JBIPIBNBMFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6BB17A0", Offset = "0x6BB01A0", VA = "0x186BB17A0")]
	public BPDEDHBPICL(int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1810", Offset = "0x6BB0210", VA = "0x186BB1810")]
	public BPDEDHBPICL(HHIKGKNGHMJ LDIFMBFDAPL, int PICLDLMFMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6BB12B0", Offset = "0x6BAFCB0", VA = "0x186BB12B0")]
	public static int LBGKIIPPPGF(HHIKGKNGHMJ LDIFMBFDAPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1320", Offset = "0x6BAFD20", VA = "0x186BB1320")]
	public int LBGKIIPPPGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1110", Offset = "0x6BAFB10", VA = "0x186BB1110")]
	public bool JBKGDPBMDEB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum CANPKOJCFEH : byte
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
internal enum DOMFGCHOHKL
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
internal enum OGILCOLEPAG
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum KIOENBHPCLH
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class KKCLOBJMJHA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CLFLJEHPNID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BPDEDHBPICL[] LJKHDPJMFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int GNHJCGFJKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int CDHICMPGDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public byte OCMILHLEMID;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public CLFLJEHPNID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void ABHDLGECIDI(ulong BPBLDHBLNDA, int NLDNFEICFEK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int INMHJFJPDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int AMOLNCOGIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int NOLENJNAKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private double FFCHINPPOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int IAAKBKDLMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int AIEPHENELGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int PIJNFOIKAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Stopwatch EDOKCEFNLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int OIFHFCEPEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private long APOOCMMFION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly object EHFIAMEOCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	internal KKCLOBJMJHA PGIGFJBNIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	internal KKCLOBJMJHA JCAKFPDPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly Queue<BPDEDHBPICL> JNLLHPEEDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly ConcurrentQueue<ALCLBFEFELL> FCFBIKCMLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly ALCLBFEFELL[] EEFNILMBHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int DIGKNBANHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int JLCFAPBMJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private bool FGANMFLGJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int KGHPBHCGBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int OFBHKINGKPL;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private const int HFLAJGJPPIB = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private const int DENIJHKHIBB = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly object JCHIPHNMHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int HEBHDFHPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly Dictionary<ushort, CLFLJEHPNID> HBNGOILPFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly Dictionary<ushort, ushort> FDCAOOCONGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly BPDEDHBPICL IDFOMAGEKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HLABIJLJDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int DBPHKPFCNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private IPEndPoint MCNFFLGEEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int OAECHABEHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int AGBOFGCPLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private long BLOOHNALNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private byte CHPPOJIBCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private CANPKOJCFEH DOJMGBKCAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private BPDEDHBPICL BBDIBLALNFP;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const int GHPHMEFHMFO = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int BBIJNANHFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly BPDEDHBPICL AFFDMOFGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly BPDEDHBPICL ICLJHKKJFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly BPDEDHBPICL OCCPECHPDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly BPDEDHBPICL IGBGOBGBEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private NGBFDGNABBL CHJLHGHAKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly HFMDBGMAHCC PLNOAPAGEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly int FIGDAIADJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public object BJBDDOOLLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly MKJNPKOEEMD JEIEFKLGGJA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte EICNJHPPNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B230", Offset = "0xA29C30", VA = "0x180A2B230")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0930", Offset = "0x6BBF330", VA = "0x186BC0930")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint EGLBJJGNJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC467D0", Offset = "0xC451D0", VA = "0x180C467D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CANPKOJCFEH MFEAHPJNHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB1FDA0", Offset = "0xB1E7A0", VA = "0x180B1FDA0")]
		get
		{
			return default(CANPKOJCFEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long CIMFJIBDNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1830", Offset = "0x9B0230", VA = "0x1809B1830")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FOLDOHOCLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1483E80", Offset = "0x1482880", VA = "0x181483E80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1D5BC40", Offset = "0x1D5A640", VA = "0x181D5BC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int FNKKMCBGACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0830", Offset = "0x6BBF230", VA = "0x186BC0830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int PPAPHEHOJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9BCF90", Offset = "0x9BB990", VA = "0x1809BCF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double MHJOGFHBNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4950BE0", Offset = "0x494F5E0", VA = "0x184950BE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event ABHDLGECIDI GJDEFLAFNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC0840", Offset = "0x6BBF240", VA = "0x186BC0840")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6BC22D0", Offset = "0x6BC0CD0", VA = "0x186BC22D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2740", Offset = "0x6BC1140", VA = "0x186BC2740")]
	internal KKCLOBJMJHA(HFMDBGMAHCC HMFPDNKOIBO, IPEndPoint LBKKPFODLCH, int ICHIIHCEGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0000", Offset = "0x6BBEA00", VA = "0x186BC0000")]
	internal void IFEOIIFIPIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF8C0", Offset = "0x6BBE2C0", VA = "0x186BBF8C0")]
	internal void FOCNCIENINI(IPEndPoint AFEPOFAMJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1530", Offset = "0x6BBFF30", VA = "0x186BC1530")]
	internal void LGFEPAFCBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF8F0", Offset = "0x6BBE2F0", VA = "0x186BBF8F0")]
	private void GIKLDNEKKDF(int INPBPLHNDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6BC08F0", Offset = "0x6BBF2F0", VA = "0x186BC08F0")]
	private void KAFFKJNPJJB(int FDBNKMGFGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2120", Offset = "0x6BC0B20", VA = "0x186BC2120")]
	private ALCLBFEFELL PCCCILBAFII(byte AIBKCJCMBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6BC23D0", Offset = "0x6BC0DD0", VA = "0x186BC23D0")]
	internal KKCLOBJMJHA(HFMDBGMAHCC HMFPDNKOIBO, IPEndPoint LBKKPFODLCH, int ICHIIHCEGJD, byte KGDKMMENILG, KHLMPEHHMJA PHPHICALAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2560", Offset = "0x6BC0F60", VA = "0x186BC2560")]
	internal KKCLOBJMJHA(HFMDBGMAHCC HMFPDNKOIBO, DCFLIPOBPOJ EELGNOJLLOB, int ICHIIHCEGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF560", Offset = "0x6BBDF60", VA = "0x186BBF560")]
	internal void FHLGLPCPBPB(GMECDJMMGHP GDDHLHOOLLA, byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1B50", Offset = "0x6BC0550", VA = "0x186BC1B50")]
	internal bool MOFJCKCLDPP(CNHIHFADGMN CBIMINNEJOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEB10", Offset = "0x6BBD510", VA = "0x186BBEB10")]
	public void BPJNPCBNDJL(byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int ENHEICOLGJO, PEGNAIILGMK LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6BBFAA0", Offset = "0x6BBE4A0", VA = "0x186BBFAA0")]
	private void IENOICHJCFK(byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int ENHEICOLGJO, byte KEFOCPMEJEH, PEGNAIILGMK EHODKPNLOLC, object IOMOKKAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2380", Offset = "0x6BC0D80", VA = "0x186BC2380")]
	public void PLGGHNDMJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF9C0", Offset = "0x6BBE3C0", VA = "0x186BBF9C0")]
	internal OGILCOLEPAG GPGAJLPHEBM(BPDEDHBPICL CBIMINNEJOD)
	{
		return default(OGILCOLEPAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF200", Offset = "0x6BBDC00", VA = "0x186BBF200")]
	internal void DFFCPNCNHFG(ALCLBFEFELL OCCIOBBLGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF5B0", Offset = "0x6BBDFB0", VA = "0x186BBF5B0")]
	internal KIOENBHPCLH FNLNIHHLFAL(byte[] DFPGGEDGGGN, int GJCFLJFIOAP, int ENHEICOLGJO, bool JDEIJIAFEMH)
	{
		return default(KIOENBHPCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF260", Offset = "0x6BBDC60", VA = "0x186BBF260")]
	private void DNEIFKBCPIH(int FDHEMOCBKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0BA0", Offset = "0x6BBF5A0", VA = "0x186BC0BA0")]
	internal void LBDPPDBCNJA(PEGNAIILGMK JFAABKHDGLM, BPDEDHBPICL GJPBKNDCAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BC1BD0", Offset = "0x6BC05D0", VA = "0x186BC1BD0")]
	private void OOKHKDFOALA(BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6BC17C0", Offset = "0x6BC01C0", VA = "0x186BC17C0")]
	private void MELGPGHJLOE(int GFOGDPEAFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6BC09E0", Offset = "0x6BBF3E0", VA = "0x186BC09E0")]
	internal DOMFGCHOHKL KNLAEPGCLHA(GMECDJMMGHP KIEINCIBKEF)
	{
		return default(DOMFGCHOHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEB40", Offset = "0x6BBD540", VA = "0x186BBEB40")]
	internal void CJHMJDBDEMM(BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6BC06E0", Offset = "0x6BBF0E0", VA = "0x186BC06E0")]
	private void JEBBBOHAPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6BC15C0", Offset = "0x6BBFFC0", VA = "0x186BC15C0")]
	internal void MECJDCMBFHC(BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6BC0020", Offset = "0x6BBEA20", VA = "0x186BC0020")]
	internal void IPDLKHCHONO(int GFOGDPEAFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6BBF2A0", Offset = "0x6BBDCA0", VA = "0x186BBF2A0")]
	internal void FBGEANMKPIP(BPDEDHBPICL CBIMINNEJOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MKJNPKOEEMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long OAGJLKEEFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long CFKCIAMLDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long NGAPGHHAEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long IFOBGIFKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long DLDGNKLJCNF;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long JBEKIJHEFDJ;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static long NHKOIAACDJJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static long ACMBCELIMMN;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long KCGDECMCAPP;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long KLCNBEFKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private long BCNENKLJLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private long IBMOGBJOEFL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long MKNKPHAOLII
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6680", Offset = "0x6BC5080", VA = "0x186BC6680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LNIMDALDAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6560", Offset = "0x6BC4F60", VA = "0x186BC6560")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LBBFOAOBKPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6450", Offset = "0x6BC4E50", VA = "0x186BC6450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DHIMOIPDLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6510", Offset = "0x6BC4F10", VA = "0x186BC6510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long LAOMAOLJJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6BC64C0", Offset = "0x6BC4EC0", VA = "0x186BC64C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LAJJHIGEBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6700", Offset = "0x6BC5100", VA = "0x186BC6700")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long HPPJPAHFAGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6BC64D0", Offset = "0x6BC4ED0", VA = "0x186BC64D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long KCEBLOLPIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6520", Offset = "0x6BC4F20", VA = "0x186BC6520")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private NGBFDGNABBL FGNFMKBKNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6710", Offset = "0x6BC5110", VA = "0x186BC6710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double ELDGLMAPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6BC6720", Offset = "0x6BC5120", VA = "0x186BC6720")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6780", Offset = "0x6BC5180", VA = "0x186BC6780")]
	public void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6570", Offset = "0x6BC4F70", VA = "0x186BC6570")]
	public void JPONPDPJMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6BC65D0", Offset = "0x6BC4FD0", VA = "0x186BC65D0")]
	public void LIBOIGECPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6620", Offset = "0x6BC5020", VA = "0x186BC6620")]
	public void LPFADCDKMAA(long EJNNJBBNKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6BC67C0", Offset = "0x6BC51C0", VA = "0x186BC67C0")]
	public void PGAEIJAPKOL(long JICNNKNADID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6460", Offset = "0x6BC4E60", VA = "0x186BC6460")]
	public void BLIPHJBINBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6690", Offset = "0x6BC5090", VA = "0x186BC6690")]
	public void MJNNJDHFAFM(long ONMGJJANEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6820", Offset = "0x6BC5220", VA = "0x186BC6820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6BC63B0", Offset = "0x6BC4DB0", VA = "0x186BC63B0")]
	public void AJIMIHHHPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public MKJNPKOEEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KNOEPELGBJH
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly List<string> BFINHJNBADM;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2E90", Offset = "0x6BC1890", VA = "0x186BC2E90")]
	public static IPEndPoint OHBMDNBHNNM(string KHCGHCCBNOD, int NCJFFOCEFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2C90", Offset = "0x6BC1690", VA = "0x186BC2C90")]
	public static IPAddress CAKAABGMNAA(string KHCGHCCBNOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2C00", Offset = "0x6BC1600", VA = "0x186BC2C00")]
	public static IPAddress CAKAABGMNAA(string KHCGHCCBNOD, AddressFamily HCNCKPDIDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6BC2E60", Offset = "0x6BC1860", VA = "0x186BC2E60")]
	internal static int FBNOOAIJDNP(int AIENEDDFBCB, int GPKHBKNCBDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x371CE40", Offset = "0x371B840", VA = "0x18371CE40")]
	internal static T[] BIFFGBNBJJJ<T>(int PGJKBFGEJNK) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JHLPMLOGPLB : ALCLBFEFELL
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct AIOOKPBILLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private BPDEDHBPICL PNBELHJDIFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private long CBFCDNDEAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private bool EMOPIPHGDFK;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0C60", Offset = "0x6BAF660", VA = "0x186BB0C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0B80", Offset = "0x6BAF580", VA = "0x186BB0B80")]
		public void JCFABLNPBJM(BPDEDHBPICL CBIMINNEJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0BA0", Offset = "0x6BAF5A0", VA = "0x186BB0BA0")]
		public bool KFLGOGIKENB(long KOCGPIEMEIF, KKCLOBJMJHA KIIKJJKAEGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6BB0C10", Offset = "0x6BAF610", VA = "0x186BB0C10")]
		public bool OPINELCICKH(KKCLOBJMJHA KIIKJJKAEGH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly BPDEDHBPICL MKDICKBEMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly AIOOKPBILLD[] NNPIEFBACLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly BPDEDHBPICL[] CIDDDAMLNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly bool[] MNKHFEPPAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int NEOEJBOHBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int JOHPNKKJHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private int CIEDIDJKOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int AKDFAOGGNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private bool JGKIBNNEBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly PEGNAIILGMK BLLCEFHFPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly bool NNIMEEIHNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly int GNEFLFCGBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly byte JIGKCFKFCCA;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BBBE60", Offset = "0x6BBA860", VA = "0x186BBBE60")]
	public JHLPMLOGPLB(KKCLOBJMJHA KIIKJJKAEGH, bool IGFJOAMFAAH, byte ICHIIHCEGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BBBAA0", Offset = "0x6BBA4A0", VA = "0x186BBBAA0")]
	private void PJJNBJCPCFK(BPDEDHBPICL CBIMINNEJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6BBB5D0", Offset = "0x6BB9FD0", VA = "0x186BBB5D0", Slot = "4")]
	protected override bool OJDDKFLCNIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAF70", Offset = "0x6BB9970", VA = "0x186BBAF70", Slot = "5")]
	public override bool CJHMJDBDEMM(BPDEDHBPICL CBIMINNEJOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OLMDFALGLIK : ALCLBFEFELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private int JFCPLBNKACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private ushort JOHPNKKJHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly bool POFLEAGDILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private BPDEDHBPICL AHGBOIJAFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly BPDEDHBPICL CALAFBGMFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private bool CEMENGBPOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly byte JIGKCFKFCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private long MJNNNLBOEDH;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7400", Offset = "0x6BC5E00", VA = "0x186BC7400")]
	public OLMDFALGLIK(KKCLOBJMJHA KIIKJJKAEGH, bool KMAHKCOMFJO, byte ICHIIHCEGJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6F40", Offset = "0x6BC5940", VA = "0x186BC6F40", Slot = "4")]
	protected override bool OJDDKFLCNIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6C60", Offset = "0x6BC5660", VA = "0x186BC6C60", Slot = "5")]
	public override bool CJHMJDBDEMM(BPDEDHBPICL CBIMINNEJOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class JABGGMLHLPL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EMFDOBEGPGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public ulong HGFJBBBAFHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public double NJFMGPHHMAC;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OEIKOFGJOIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int FMLPJFDCLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float MHEHFNGOLOL;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF730", Offset = "0x6BAE130", VA = "0x186BAF730")]
	private static void CBKEJHMMPMF(byte[] KGINKPKLCFG, int LMGBAALNFHC, ulong DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE10", Offset = "0x6BB9810", VA = "0x186BBAE10")]
	private static void CBKEJHMMPMF(byte[] KGINKPKLCFG, int LMGBAALNFHC, int DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE80", Offset = "0x6BB9880", VA = "0x186BBAE80")]
	public static void CBKEJHMMPMF(byte[] KGINKPKLCFG, int LMGBAALNFHC, short DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAF50", Offset = "0x6BB9950", VA = "0x186BBAF50")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, double PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAED0", Offset = "0x6BB98D0", VA = "0x186BBAED0")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE80", Offset = "0x6BB9880", VA = "0x186BBAE80")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, short PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE80", Offset = "0x6BB9880", VA = "0x186BBAE80")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, ushort PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE10", Offset = "0x6BB9810", VA = "0x186BBAE10")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, int PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE10", Offset = "0x6BB9810", VA = "0x186BBAE10")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, uint PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAEC0", Offset = "0x6BB98C0", VA = "0x186BBAEC0")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAEC0", Offset = "0x6BB98C0", VA = "0x186BBAEC0")]
	public static void DFKJAFAIKKD(byte[] OHAFLBCBHHH, int FNEPEEDFAPL, ulong PPJFMHBDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JNHELJKFMLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] JAGGFOKDKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int KJAGGFFFNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	protected int FABGKMKEFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private int EAAPEAKEKNF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] MIPPOOKPMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int MCLOGAJAHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB86090", Offset = "0xB84A90", VA = "0x180B86090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DKGCECIDDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC470", Offset = "0x6BBAE70", VA = "0x186BBC470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BGGFDICOLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x259E690", Offset = "0x259D090", VA = "0x18259E690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FFOCMLGIPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC980", Offset = "0x6BBB380", VA = "0x186BBC980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC940", Offset = "0x6BBB340", VA = "0x186BBC940")]
	public void FLIKPCMPFNI(byte[] HBNNPNFAEOC, int LMGBAALNFHC, int LDMIJBGHBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public JNHELJKFMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD030", Offset = "0x6BBBA30", VA = "0x186BBD030")]
	public JNHELJKFMLK(byte[] HBNNPNFAEOC, int LMGBAALNFHC, int LDMIJBGHBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCA70", Offset = "0x6BBB470", VA = "0x186BBCA70")]
	public IPEndPoint JCBFGIBNGKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC430", Offset = "0x6BBAE30", VA = "0x186BBC430")]
	public byte ADHPNPGAMAC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC430", Offset = "0x6BBAE30", VA = "0x186BBC430")]
	public sbyte GJGJEHELOJG()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x36E72B0", Offset = "0x36E5CB0", VA = "0x1836E72B0")]
	public T[] JHOMLMNONJC<T>(ushort PICLDLMFMMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC7D0", Offset = "0x6BBB1D0", VA = "0x186BBC7D0")]
	public bool[] EBFBMHEIIAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCD90", Offset = "0x6BBB790", VA = "0x186BBCD90")]
	public ushort[] NFPHCFMOGPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC810", Offset = "0x6BBB210", VA = "0x186BBC810")]
	public short[] EIECIOPLEFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCBC0", Offset = "0x6BBB5C0", VA = "0x186BBCBC0")]
	public int[] LKIIPGOAFHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC850", Offset = "0x6BBB250", VA = "0x186BBC850")]
	public uint[] FFPCMPHBPJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCB40", Offset = "0x6BBB540", VA = "0x186BBCB40")]
	public float[] JOEIKGMABIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC890", Offset = "0x6BBB290", VA = "0x186BBC890")]
	public double[] FIDPOGMFPHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCCE0", Offset = "0x6BBB6E0", VA = "0x186BBCCE0")]
	public long[] NBLCIBKAFOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC720", Offset = "0x6BBB120", VA = "0x186BBC720")]
	public ulong[] BMLEOJGDOOL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCE10", Offset = "0x6BBB810", VA = "0x186BBCE10")]
	public string[] OJMLMFLGGEB(int NJIJPMPCOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCF80", Offset = "0x6BBB980", VA = "0x186BBCF80")]
	public bool PMMCHGOFMJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCD20", Offset = "0x6BBB720", VA = "0x186BBCD20")]
	public char OIJLFEDKCDI()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCD20", Offset = "0x6BBB720", VA = "0x186BBCD20")]
	public ushort NBOGNGKDAIP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCC00", Offset = "0x6BBB600", VA = "0x186BBCC00")]
	public short LLGAKBPAMCK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCC70", Offset = "0x6BBB670", VA = "0x186BBCC70")]
	public long MBEKGFOBLMF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCA00", Offset = "0x6BBB400", VA = "0x186BBCA00")]
	public ulong GPHGMJCGICM()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC990", Offset = "0x6BBB390", VA = "0x186BBC990")]
	public int GOOKALLNIBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC6B0", Offset = "0x6BBB0B0", VA = "0x186BBC6B0")]
	public uint BAKKKCCKHGL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCFC0", Offset = "0x6BBB9C0", VA = "0x186BBCFC0")]
	public float PNAAKJBNGLB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC8D0", Offset = "0x6BBB2D0", VA = "0x186BBC8D0")]
	public double FIGGDILMKPE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC480", Offset = "0x6BBAE80", VA = "0x186BBC480")]
	public string APGCIBCFEHL(int FBDEAAOGBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6BBC760", Offset = "0x6BBB160", VA = "0x186BBC760")]
	public ArraySegment<byte> DJGGDAMFPDE(int PGJKBFGEJNK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCDD0", Offset = "0x6BBB7D0", VA = "0x186BBCDD0")]
	public sbyte[] NLCBKNEEPDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCB80", Offset = "0x6BBB580", VA = "0x186BBCB80")]
	public byte[] LCEFDNJOEPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6BBCF60", Offset = "0x6BBB960", VA = "0x186BBCF60")]
	public void OPINELCICKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KHLMPEHHMJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected byte[] JAGGFOKDKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int KJAGGFFFNEF;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private const int PFDNLMKFFOC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly bool OHHHMLLMJEG;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public static readonly UTF8Encoding CFBNIJMPKPH;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const int DIMDFJJLECK = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly byte[] DLLDJKIHOIM;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] LPLAAGCJFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int NIKDNFEJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBEA90", Offset = "0x6BBD490", VA = "0x186BBEA90")]
	public KHLMPEHHMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE9F0", Offset = "0x6BBD3F0", VA = "0x186BBE9F0")]
	public KHLMPEHHMJA(bool BHCAMCAHKFM, int ILPBEHILGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDDB0", Offset = "0x6BBC7B0", VA = "0x186BBDDB0")]
	public static KHLMPEHHMJA DNOFCDIBPHK(string PPJFMHBDGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE270", Offset = "0x6BBCC70", VA = "0x186BBE270")]
	public void JBMELDJEANA(int CMLICKDGMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0xCA5F60", Offset = "0xCA4960", VA = "0x180CA5F60")]
	public void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE520", Offset = "0x6BBCF20", VA = "0x186BBE520")]
	public void PMGFAFGNCOB(float PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE8A0", Offset = "0x6BBD2A0", VA = "0x186BBE8A0")]
	public void PMGFAFGNCOB(double PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE470", Offset = "0x6BBCE70", VA = "0x186BBE470")]
	public void PMGFAFGNCOB(long PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE470", Offset = "0x6BBCE70", VA = "0x186BBE470")]
	public void PMGFAFGNCOB(ulong PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE3E0", Offset = "0x6BBCDE0", VA = "0x186BBE3E0")]
	public void PMGFAFGNCOB(int PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE3E0", Offset = "0x6BBCDE0", VA = "0x186BBE3E0")]
	public void PMGFAFGNCOB(uint PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE830", Offset = "0x6BBD230", VA = "0x186BBE830")]
	public void PMGFAFGNCOB(char PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE830", Offset = "0x6BBD230", VA = "0x186BBE830")]
	public void PMGFAFGNCOB(ushort PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE830", Offset = "0x6BBD230", VA = "0x186BBE830")]
	public void PMGFAFGNCOB(short PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE7D0", Offset = "0x6BBD1D0", VA = "0x186BBE7D0")]
	public void PMGFAFGNCOB(sbyte PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE7D0", Offset = "0x6BBD1D0", VA = "0x186BBE7D0")]
	public void PMGFAFGNCOB(byte PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE8F0", Offset = "0x6BBD2F0", VA = "0x186BBE8F0")]
	public void PMGFAFGNCOB(byte[] DFPGGEDGGGN, int LMGBAALNFHC, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDCD0", Offset = "0x6BBC6D0", VA = "0x186BBDCD0")]
	public void BNPOMJNKAKF(sbyte[] DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDCD0", Offset = "0x6BBC6D0", VA = "0x186BBDCD0")]
	public void IKIDPLEEHMN(byte[] DFPGGEDGGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE4C0", Offset = "0x6BBCEC0", VA = "0x186BBE4C0")]
	public void PMGFAFGNCOB(bool PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDF00", Offset = "0x6BBC900", VA = "0x186BBDF00")]
	public void IHNHFGHDAIL(Array FFMGEAMPHBP, int DGLHMLFJNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE0C0", Offset = "0x6BBCAC0", VA = "0x186BBE0C0")]
	public void IHNHFGHDAIL(float[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDFE0", Offset = "0x6BBC9E0", VA = "0x186BBDFE0")]
	public void IHNHFGHDAIL(double[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDFE0", Offset = "0x6BBC9E0", VA = "0x186BBDFE0")]
	public void IHNHFGHDAIL(long[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDFE0", Offset = "0x6BBC9E0", VA = "0x186BBDFE0")]
	public void IHNHFGHDAIL(ulong[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE0C0", Offset = "0x6BBCAC0", VA = "0x186BBE0C0")]
	public void IHNHFGHDAIL(int[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE0C0", Offset = "0x6BBCAC0", VA = "0x186BBE0C0")]
	public void IHNHFGHDAIL(uint[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDE20", Offset = "0x6BBC820", VA = "0x186BBDE20")]
	public void IHNHFGHDAIL(ushort[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDE20", Offset = "0x6BBC820", VA = "0x186BBDE20")]
	public void IHNHFGHDAIL(short[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDCD0", Offset = "0x6BBC6D0", VA = "0x186BBDCD0")]
	public void IHNHFGHDAIL(bool[] PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE1A0", Offset = "0x6BBCBA0", VA = "0x186BBE1A0")]
	public void IHNHFGHDAIL(string[] PPJFMHBDGNA, int IIANODOCLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE310", Offset = "0x6BBCD10", VA = "0x186BBE310")]
	public void PMGFAFGNCOB(IPEndPoint CAJFODPDOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE960", Offset = "0x6BBD360", VA = "0x186BBE960")]
	public void PMGFAFGNCOB(string PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6BBE5C0", Offset = "0x6BBCFC0", VA = "0x186BBE5C0")]
	public void PMGFAFGNCOB(string PPJFMHBDGNA, int FBDEAAOGBII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AFGKFCIGOOA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class LOKHELMAGPJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly ulong FIGDAIADJGM;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4EEDEC0", Offset = "0x4EEC8C0", VA = "0x184EEDEC0")]
		static LOKHELMAGPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void DGKKAANNPHH(JNHELJKFMLK BDHKEKKPKBC, object IOMOKKAIBLH);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class IDJKFMABLGK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AFGKFCIGOOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IDJKFMABLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4A73A70", Offset = "0x4A72470", VA = "0x184A73A70")]
		internal void IPOCCMBNJMN(JNHELJKFMLK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ONGLGECDBBN<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AFGKFCIGOOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public ONGLGECDBBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x52EF330", Offset = "0x52EDD30", VA = "0x1852EF330")]
		internal void IPOCCMBNJMN(JNHELJKFMLK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly NODFDFMKKKJ JBKLMGAKKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<ulong, DGKKAANNPHH> LAOJFPFOBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly KHLMPEHHMJA KLHHHFDECAA;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFF10", Offset = "0x6BAE910", VA = "0x186BAFF10")]
	public AFGKFCIGOOA(int NJIJPMPCOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x33BBD80", Offset = "0x33BA780", VA = "0x1833BBD80", Slot = "4")]
	protected virtual ulong ADIGJILKDHC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFD10", Offset = "0x6BAE710", VA = "0x186BAFD10", Slot = "5")]
	protected virtual DGKKAANNPHH GOKCBOICHEL(JNHELJKFMLK BDHKEKKPKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA720", Offset = "0x3DA9120", VA = "0x183DAA720", Slot = "6")]
	protected virtual void CIEKFDFIFAC<T>(KHLMPEHHMJA IFAFIMFGJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFE40", Offset = "0x6BAE840", VA = "0x186BAFE40")]
	public void HHGEKOAGLNN(JNHELJKFMLK BDHKEKKPKBC, object IOMOKKAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA790", Offset = "0x3DA9190", VA = "0x183DAA790")]
	public void EIMCNBJPGEJ<T>(KHLMPEHHMJA IFAFIMFGJBL, T CBIMINNEJOD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFEC0", Offset = "0x6BAE8C0", VA = "0x186BAFEC0")]
	public void MKBNLNEHNFI(JNHELJKFMLK BDHKEKKPKBC, object IOMOKKAIBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA560", Offset = "0x3DA8F60", VA = "0x183DAA560")]
	public void CAEKNLKFKEM<T>(Action<T> FCMGLEOEJFD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3DAA3A0", Offset = "0x3DA8DA0", VA = "0x183DAA3A0")]
	public void CAEKNLKFKEM<T, TUserData>(Action<T, TUserData> FCMGLEOEJFD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PBBCCIDONNE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBAE00", Offset = "0x6BB9800", VA = "0x186BBAE00")]
	public PBBCCIDONNE(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MPBELPNIMHD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6B60", Offset = "0x6BC5560", VA = "0x186BC6B60")]
	public MPBELPNIMHD(string FLPDJFEEMLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NODFDFMKKKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum HBBBLKDNNMO
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class PHNBHFNCMKH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public HBBBLKDNNMO ABBLELNBDOD;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x53D5580", Offset = "0x53D3F80", VA = "0x1853D5580", Slot = "4")]
		public virtual void JCFABLNPBJM(MethodInfo IOCMBKDACGN, MethodInfo FDPCEJHLKCO, HBBBLKDNNMO OHCGINPDMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MABGGIDCFFO(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG);

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void FDIGOFOAKOH(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		protected PHNBHFNCMKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class ELNAGLGCKLE<TClass, TProperty> : PHNBHFNCMKH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, TProperty> ONBFAHMGFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, TProperty> LCDHECPEHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		protected Func<TClass, TProperty[]> IEOFPFKANGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Action<TClass, TProperty[]> CJEJEAHPOAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Func<TClass, List<TProperty>> IJFJAEODMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Action<TClass, List<TProperty>> IOKBMCEELHO;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x438B400", Offset = "0x4389E00", VA = "0x18438B400", Slot = "7")]
		public override void LNBMLCIDJKN(TClass HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x438CF20", Offset = "0x438B920", VA = "0x18438CF20", Slot = "8")]
		public override void NAOCGIMPHNN(TClass HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x438BF60", Offset = "0x438A960", VA = "0x18438BF60", Slot = "9")]
		public override void MABGGIDCFFO(TClass HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x43858B0", Offset = "0x43842B0", VA = "0x1843858B0", Slot = "10")]
		public override void FDIGOFOAKOH(TClass HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x438ACD0", Offset = "0x43896D0", VA = "0x18438ACD0")]
		protected TProperty[] JCKKECLLBIP(TClass HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4386330", Offset = "0x4384D30", VA = "0x184386330")]
		protected TProperty[] IEEFCKKAEOP(TClass HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4387490", Offset = "0x4385E90", VA = "0x184387490", Slot = "4")]
		public override void JCFABLNPBJM(MethodInfo IOCMBKDACGN, MethodInfo FDPCEJHLKCO, HBBBLKDNNMO OHCGINPDMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x438D000", Offset = "0x438BA00", VA = "0x18438D000")]
		protected ELNAGLGCKLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class CDOBGGJOLKI<TClass, TProperty> : ELNAGLGCKLE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void LBAGDOBGBFJ(JNHELJKFMLK LIFAHFCIJCG, [Out] TProperty EDOLCPLANBI);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void BPEKELEIGBA(KHLMPEHHMJA DBLNEKCBDJI, TProperty EDOLCPLANBI);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x65604B0", Offset = "0x655EEB0", VA = "0x1865604B0", Slot = "5")]
		public override void GEMJEIFKNLH(TClass HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6560390", Offset = "0x655ED90", VA = "0x186560390", Slot = "6")]
		public override void EIMCNBJPGEJ(TClass HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6560550", Offset = "0x655EF50", VA = "0x186560550", Slot = "7")]
		public override void LNBMLCIDJKN(TClass HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6560790", Offset = "0x655F190", VA = "0x186560790", Slot = "8")]
		public override void NAOCGIMPHNN(TClass HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3F278D0", Offset = "0x3F262D0", VA = "0x183F278D0")]
		protected CDOBGGJOLKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class FDLJLCCPOBK<T> : ELNAGLGCKLE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x47B8C90", Offset = "0x47B7690", VA = "0x1847B8C90", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x47B8C20", Offset = "0x47B7620", VA = "0x1847B8C20", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x47B8D10", Offset = "0x47B7710", VA = "0x1847B8D10", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x47B8D90", Offset = "0x47B7790", VA = "0x1847B8D90", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public FDLJLCCPOBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class IEFCNGGDKAH<T> : ELNAGLGCKLE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4A78930", Offset = "0x4A77330", VA = "0x184A78930", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x47B8C20", Offset = "0x47B7620", VA = "0x1847B8C20", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4A789B0", Offset = "0x4A773B0", VA = "0x184A789B0", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x47B8D90", Offset = "0x47B7790", VA = "0x1847B8D90", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public IEFCNGGDKAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BEEFHJNNHNE<T> : ELNAGLGCKLE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6461EE0", Offset = "0x64608E0", VA = "0x186461EE0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A230", Offset = "0x4C98C30", VA = "0x184C9A230", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6461F60", Offset = "0x6460960", VA = "0x186461F60", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A3A0", Offset = "0x4C98DA0", VA = "0x184C9A3A0", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public BEEFHJNNHNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class ADLABMPGMMN<T> : ELNAGLGCKLE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A2A0", Offset = "0x4C98CA0", VA = "0x184C9A2A0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A230", Offset = "0x4C98C30", VA = "0x184C9A230", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A320", Offset = "0x4C98D20", VA = "0x184C9A320", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A3A0", Offset = "0x4C98DA0", VA = "0x184C9A3A0", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public ADLABMPGMMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DEEKNAHAFBK<T> : ELNAGLGCKLE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDCC0", Offset = "0x3EEC6C0", VA = "0x183EEDCC0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDC50", Offset = "0x3EEC650", VA = "0x183EEDC50", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDD40", Offset = "0x3EEC740", VA = "0x183EEDD40", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDDC0", Offset = "0x3EEC7C0", VA = "0x183EEDDC0", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public DEEKNAHAFBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NMNODMINCMP<T> : ELNAGLGCKLE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x51BE190", Offset = "0x51BCB90", VA = "0x1851BE190", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDC50", Offset = "0x3EEC650", VA = "0x183EEDC50", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x51BE210", Offset = "0x51BCC10", VA = "0x1851BE210", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDDC0", Offset = "0x3EEC7C0", VA = "0x183EEDDC0", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public NMNODMINCMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class JCHAIOOMGOG<T> : ELNAGLGCKLE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DDC0", Offset = "0x4C8C7C0", VA = "0x184C8DDC0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DD50", Offset = "0x4C8C750", VA = "0x184C8DD50", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DE40", Offset = "0x4C8C840", VA = "0x184C8DE40", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x48C8060", Offset = "0x48C6A60", VA = "0x1848C8060", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public JCHAIOOMGOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class OPOPHEODHGN<T> : ELNAGLGCKLE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DDC0", Offset = "0x4C8C7C0", VA = "0x184C8DDC0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C8DD50", Offset = "0x4C8C750", VA = "0x184C8DD50", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x532F370", Offset = "0x532DD70", VA = "0x18532F370", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x48C8060", Offset = "0x48C6A60", VA = "0x1848C8060", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public OPOPHEODHGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class HECDIBGKDPI<T> : ELNAGLGCKLE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4947CF0", Offset = "0x49466F0", VA = "0x184947CF0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4947C80", Offset = "0x4946680", VA = "0x184947C80", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4947D70", Offset = "0x4946770", VA = "0x184947D70", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x47B8D90", Offset = "0x47B7790", VA = "0x1847B8D90", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public HECDIBGKDPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class GNLGIMDICKC<T> : ELNAGLGCKLE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x48F4260", Offset = "0x48F2C60", VA = "0x1848F4260", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x48F41F0", Offset = "0x48F2BF0", VA = "0x1848F41F0", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x48F42E0", Offset = "0x48F2CE0", VA = "0x1848F42E0", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDDC0", Offset = "0x3EEC7C0", VA = "0x183EEDDC0", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public GNLGIMDICKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GHAFPNKGMLP<T> : ELNAGLGCKLE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x48C7F60", Offset = "0x48C6960", VA = "0x1848C7F60", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x48C7EF0", Offset = "0x48C68F0", VA = "0x1848C7EF0", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x48C7FE0", Offset = "0x48C69E0", VA = "0x1848C7FE0", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x48C8060", Offset = "0x48C6A60", VA = "0x1848C8060", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3EEDE30", Offset = "0x3EEC830", VA = "0x183EEDE30")]
		public GHAFPNKGMLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class OHPNPCFHGGJ<T> : CDOBGGJOLKI<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x52D97D0", Offset = "0x52D81D0", VA = "0x1852D97D0", Slot = "12")]
		protected override void BPEKELEIGBA(KHLMPEHHMJA DBLNEKCBDJI, char EDOLCPLANBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x52D9800", Offset = "0x52D8200", VA = "0x1852D9800", Slot = "11")]
		protected override void LBAGDOBGBFJ(JNHELJKFMLK LIFAHFCIJCG, [Out] char EDOLCPLANBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x431C530", Offset = "0x431AF30", VA = "0x18431C530")]
		public OHPNPCFHGGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class BPLLPNGGPKK<T> : CDOBGGJOLKI<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x64C3BF0", Offset = "0x64C25F0", VA = "0x1864C3BF0", Slot = "12")]
		protected override void BPEKELEIGBA(KHLMPEHHMJA DBLNEKCBDJI, IPEndPoint EDOLCPLANBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x64C3C20", Offset = "0x64C2620", VA = "0x1864C3C20", Slot = "11")]
		protected override void LBAGDOBGBFJ(JNHELJKFMLK LIFAHFCIJCG, [Out] IPEndPoint EDOLCPLANBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x431C530", Offset = "0x431AF30", VA = "0x18431C530")]
		public BPLLPNGGPKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class IGPIEOPIIKF<T> : ELNAGLGCKLE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly int PJGFAIHIGHH;

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4A804E0", Offset = "0x4A7EEE0", VA = "0x184A804E0")]
		public IGPIEOPIIKF(int FBDEAAOGBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4A80360", Offset = "0x4A7ED60", VA = "0x184A80360", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4A802E0", Offset = "0x4A7ECE0", VA = "0x184A802E0", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4A803E0", Offset = "0x4A7EDE0", VA = "0x184A803E0", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4A80460", Offset = "0x4A7EE60", VA = "0x184A80460", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JAELJMOKDBB<T> : PHNBHFNCMKH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected readonly PropertyInfo LDBNNDPEJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected readonly Type CLJLMBKGCKE;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4C88FA0", Offset = "0x4C879A0", VA = "0x184C88FA0")]
		public JAELJMOKDBB(PropertyInfo LDIFMBFDAPL, Type CFKJNCHBIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4C88DC0", Offset = "0x4C877C0", VA = "0x184C88DC0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C88CB0", Offset = "0x4C876B0", VA = "0x184C88CB0", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4C88E80", Offset = "0x4C87880", VA = "0x184C88E80", Slot = "7")]
		public override void LNBMLCIDJKN(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4C88F40", Offset = "0x4C87940", VA = "0x184C88F40", Slot = "8")]
		public override void NAOCGIMPHNN(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4C88EE0", Offset = "0x4C878E0", VA = "0x184C88EE0", Slot = "9")]
		public override void MABGGIDCFFO(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4C88D60", Offset = "0x4C87760", VA = "0x184C88D60", Slot = "10")]
		public override void FDIGOFOAKOH(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class NDAJHJJLNLB<T> : JAELJMOKDBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4355C10", Offset = "0x4354610", VA = "0x184355C10")]
		public NDAJHJJLNLB(PropertyInfo LDIFMBFDAPL, Type CFKJNCHBIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5197BA0", Offset = "0x51965A0", VA = "0x185197BA0", Slot = "5")]
		public override void GEMJEIFKNLH(T HEPFGEKCLAL, JNHELJKFMLK LIFAHFCIJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5197AF0", Offset = "0x51964F0", VA = "0x185197AF0", Slot = "6")]
		public override void EIMCNBJPGEJ(T HEPFGEKCLAL, KHLMPEHHMJA DBLNEKCBDJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class CBMJCOABJBK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static CBMJCOABJBK<T> LALLOKGAEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly PHNBHFNCMKH<T>[] IBADHIIFBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly int FPJPMKIBBKG;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6544370", Offset = "0x6542D70", VA = "0x186544370")]
		public CBMJCOABJBK(List<PHNBHFNCMKH<T>> PABPBOHGILD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6544210", Offset = "0x6542C10", VA = "0x186544210")]
		public void EIMCNBJPGEJ(T OIIGDBLKEDN, KHLMPEHHMJA IFAFIMFGJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x65442C0", Offset = "0x6542CC0", VA = "0x1865442C0")]
		public void GEMJEIFKNLH(T OIIGDBLKEDN, JNHELJKFMLK BDHKEKKPKBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class GCGHMOOAEML
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract PHNBHFNCMKH<T> BLCCCENAIKI<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private KHLMPEHHMJA OMBJEOGCIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int MIOMHLEDPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Dictionary<Type, GCGHMOOAEML> MKNEHFFNPCN;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6BC0", Offset = "0x6BC55C0", VA = "0x186BC6BC0")]
	public NODFDFMKKKJ(int NJIJPMPCOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x37F1770", Offset = "0x37F0170", VA = "0x1837F1770")]
	private CBMJCOABJBK<T> LDJHLAMMFMF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x341E860", Offset = "0x341D260", VA = "0x18341E860")]
	public void BLLBFFICICF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x37F16D0", Offset = "0x37F00D0", VA = "0x1837F16D0")]
	public bool DHOLDBOACBA<T>(JNHELJKFMLK BDHKEKKPKBC, T HIKBDNMPFJK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x37F1640", Offset = "0x37F0040", VA = "0x1837F1640")]
	public void CFLEALCFLNK<T>(KHLMPEHHMJA IFAFIMFGJBL, T OIIGDBLKEDN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LECAHECPANG
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static readonly DateTime CABJABMIAED;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] ONBNBKAMEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IFHMGJPHHLB LFLPMHBBECO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3880", Offset = "0x6BC2280", VA = "0x186BC3880")]
		get
		{
			return default(IFHMGJPHHLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int EIBNCKMBNGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6BC4080", Offset = "0x6BC2A80", VA = "0x186BC4080")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3F70", Offset = "0x6BC2970", VA = "0x186BC3F70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PIMMCAPIKIP FCKDCNLJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3650", Offset = "0x6BC2050", VA = "0x186BC3650")]
		get
		{
			return default(PIMMCAPIKIP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3930", Offset = "0x6BC2330", VA = "0x186BC3930")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int AHBMMOMPCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3170", Offset = "0x6BC1B70", VA = "0x186BC3170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint LCAGBDBDGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6BC38B0", Offset = "0x6BC22B0", VA = "0x186BC38B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? IHFEAMHNLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3970", Offset = "0x6BC2370", VA = "0x186BC3970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? NEJOBNBKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BC40B0", Offset = "0x6BC2AB0", VA = "0x186BC40B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? NBJOPHIBPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3850", Offset = "0x6BC2250", VA = "0x186BC3850")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6BC3BA0", Offset = "0x6BC25A0", VA = "0x186BC3BA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BBEOIKLODEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xB9B420", Offset = "0xB99E20", VA = "0x180B9B420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xD56650", Offset = "0xD55050", VA = "0x180D56650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6BC41F0", Offset = "0x6BC2BF0", VA = "0x186BC41F0")]
	public LECAHECPANG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6BC4140", Offset = "0x6BC2B40", VA = "0x186BC4140")]
	internal LECAHECPANG(byte[] OHAFLBCBHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3530", Offset = "0x6BC1F30", VA = "0x186BC3530")]
	public static LECAHECPANG EMEOFKCKMHM(byte[] OHAFLBCBHHH, DateTime EKBMEGDBGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3D70", Offset = "0x6BC2770", VA = "0x186BC3D70")]
	internal void JIBAFIOBHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6BC31A0", Offset = "0x6BC1BA0", VA = "0x186BC31A0")]
	private void CFPFEIOGLPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6BC39A0", Offset = "0x6BC23A0", VA = "0x186BC39A0")]
	private DateTime? JCGAAJGCJFF(int LMGBAALNFHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3680", Offset = "0x6BC2080", VA = "0x186BC3680")]
	private void GILHCPOJJGM(int LMGBAALNFHC, DateTime? PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3FB0", Offset = "0x6BC29B0", VA = "0x186BC3FB0")]
	private ulong LBEOBJILPJN(int LMGBAALNFHC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3410", Offset = "0x6BC1E10", VA = "0x186BC3410")]
	private void DOOGFHCJFGO(int LMGBAALNFHC, ulong PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6BC3380", Offset = "0x6BC1D80", VA = "0x186BC3380")]
	private uint DOFIMNIBODO(int LMGBAALNFHC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D1D0", Offset = "0x6A7BBD0", VA = "0x186A7D1D0")]
	private static uint EIKPEEOJKDA(uint CJBFFOKBLHB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BC34D0", Offset = "0x6BC1ED0", VA = "0x186BC34D0")]
	private static ulong EIKPEEOJKDA(ulong CJBFFOKBLHB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum IFHMGJPHHLB
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
public enum PIMMCAPIKIP
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class CHBOJILABLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private const int GGKOFJOKLBC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private const int JALGIHLFKON = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public const int IGPNBFJJNJC = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly IPEndPoint PJNHOBFHKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private int KDLKPEBJFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private int DNMHGBDCAPG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AHJGCJKFILD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1A10", Offset = "0x6BB0410", VA = "0x186BB1A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BB1920", Offset = "0x6BB0320", VA = "0x186BB1920")]
	public bool BPJNPCBNDJL(KBJDEPEECJO IENDDBOLCPK, int KDFJLNMBGOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class KFMPLBPANND : KBJDEPEECJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Socket IENDDBOLCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly HFMDBGMAHCC HMFPDNKOIBO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short PHBGPMNKKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD620", Offset = "0x6BBC020", VA = "0x186BBD620", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int OKFNPALHCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6BBD600", Offset = "0x6BBC000", VA = "0x186BBD600", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint PDMOFNOCBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6BBDC00", Offset = "0x6BBC600", VA = "0x186BBDC00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily GNAOBHJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4E976E0", Offset = "0x4E960E0", VA = "0x184E976E0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6BBDC20", Offset = "0x6BBC620", VA = "0x186BBDC20")]
	public KFMPLBPANND(AddressFamily HCNCKPDIDHF, HFMDBGMAHCC HMFPDNKOIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD640", Offset = "0x6BBC040", VA = "0x186BBD640", Slot = "8")]
	public bool MNPNBGFPKBC(IPEndPoint CAJFODPDOMM, BHFNOKNMIKO BBALGPMMHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD5C0", Offset = "0x6BBBFC0", VA = "0x186BBD5C0", Slot = "9")]
	public int EMCOCPKHLHG(byte[] KGINKPKLCFG, int LMGBAALNFHC, int PICLDLMFMMM, IPEndPoint LBKKPFODLCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD4D0", Offset = "0x6BBBED0", VA = "0x186BBD4D0", Slot = "10")]
	public int EJBEPBAOMGN(byte[] KGINKPKLCFG, EndPoint IGNEOGBHPPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD4B0", Offset = "0x6BBBEB0", VA = "0x186BBD4B0", Slot = "11")]
	public void AOBLOIOLDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface KBJDEPEECJO
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short PHBGPMNKKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int OKFNPALHCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint PDMOFNOCBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily GNAOBHJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MNPNBGFPKBC(IPEndPoint CAJFODPDOMM, BHFNOKNMIKO BBALGPMMHAI);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int EMCOCPKHLHG(byte[] KGINKPKLCFG, int LMGBAALNFHC, int PICLDLMFMMM, IPEndPoint LBKKPFODLCH);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EJBEPBAOMGN(byte[] KGINKPKLCFG, EndPoint LBKKPFODLCH);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AOBLOIOLDDN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct KDNMJHJFPON : IEquatable<KDNMJHJFPON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly long KCDKKBOMCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly long MBEHEMAPOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly long MDFOBHAMHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly int MEEDELGBPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly int DDFBLJEINFK;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD180", Offset = "0x6BBBB80", VA = "0x186BBD180")]
	public KDNMJHJFPON(byte[] MJMDMDPCBDE, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD240", Offset = "0x6BBBC40", VA = "0x186BBD240")]
	public KDNMJHJFPON(Span<byte> MJMDMDPCBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9D5A10", Offset = "0x9D4410", VA = "0x1809D5A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD090", Offset = "0x6BBBA90", VA = "0x186BBD090", Slot = "4")]
	public bool Equals(KDNMJHJFPON OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6BBD0D0", Offset = "0x6BBBAD0", VA = "0x186BBD0D0", Slot = "0")]
	public override bool Equals(object OIIGDBLKEDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MICFAAOCEFD : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public readonly byte[] CIIDGMPGMEO;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class ALFNLLPJONJ
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal delegate void AMCNNKCDJII(IPEndPoint MJMDMDPCBDE, Span<byte> DFPGGEDGGGN);

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private const string HAKKBODOGBO = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private const int HGCADLPCBJO = 16;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private const int GCIPJHNBMKL = 28;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static Dictionary<KDNMJHJFPON, IPEndPoint> DGEGEHOMPAG;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static AMCNNKCDJII ONKHFNEEOID;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	internal void GKLBIPKCNMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	internal void EFAAHEOJODM(IPEndPoint LBKKPFODLCH, Span<byte> DFPGGEDGGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class BFGMJIBAKNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public readonly int KCCDDBIPBAH;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9ACFC0", Offset = "0x9AB9C0", VA = "0x1809ACFC0")]
	protected BFGMJIBAKNN(int CODGOOMPFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CHLMDHEFHHN(IPEndPoint CAJFODPDOMM, byte[] DFPGGEDGGGN, int LMGBAALNFHC, int ENHEICOLGJO);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void KPPKLKCHKDM(IPEndPoint CAJFODPDOMM, byte[] DFPGGEDGGGN, int LMGBAALNFHC, int ENHEICOLGJO);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class AHNBFDJBFOI : BFGMJIBAKNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private byte[] NJBPFCDJFGD;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly RandomNumberGenerator CJODGKCNNII;

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x26C3830", Offset = "0x26C2230", VA = "0x1826C3830")]
	public AHNBFDJBFOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0620", Offset = "0x6BAF020", VA = "0x186BB0620")]
	public void KKBFFEBEIEN(IPEndPoint CAJFODPDOMM, byte[] NJBPFCDJFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0540", Offset = "0x6BAEF40", VA = "0x186BB0540")]
	public void IPDFJAILHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6BB0090", Offset = "0x6BAEA90", VA = "0x186BB0090", Slot = "4")]
	public override void CHLMDHEFHHN(IPEndPoint CAJFODPDOMM, byte[] DFPGGEDGGGN, int LMGBAALNFHC, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6BB07D0", Offset = "0x6BAF1D0", VA = "0x186BB07D0", Slot = "5")]
	public override void KPPKLKCHKDM(IPEndPoint CAJFODPDOMM, byte[] DFPGGEDGGGN, int LMGBAALNFHC, int ENHEICOLGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[BurstCompile]
internal struct MJGOENNFCNN
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public unsafe delegate void FFLAEOPCCPP([NoAlias] byte* OHNCDBKHLPH, [NoAlias] byte* NJBPFCDJFGD, [NoAlias] byte* IOFGMGMEHJJ, int ENHEICOLGJO);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	internal static class JICLLBOOAHI
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private static IntPtr GOCHLBEEEIN;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private static IntPtr NNEKHHEKKMM;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6BC77D0", Offset = "0x6BC61D0", VA = "0x186BC77D0")]
		[BurstDiscard]
		private static void ADGHCEHFKMH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6BC78F0", Offset = "0x6BC62F0", VA = "0x186BC78F0")]
		private static IntPtr IPJKLEBKHKH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7A40", Offset = "0x6BC6440", VA = "0x186BC7A40")]
		public static void MCLBKMHEBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
		public static void ELAEPFFNBKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6BC7AE0", Offset = "0x6BC64E0", VA = "0x186BC7AE0")]
		public unsafe static void PADLNKFJPNL([NoAlias] byte* OHNCDBKHLPH, [NoAlias] byte* NJBPFCDJFGD, [NoAlias] byte* IOFGMGMEHJJ, int ENHEICOLGJO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private unsafe fixed uint NJBPFCDJFGD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private unsafe fixed uint IOFGMGMEHJJ[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private unsafe fixed uint BPPPHFHBKIJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private unsafe fixed uint OOAECINKJCN[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private unsafe fixed uint LPDMBIILGPE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint NFMHLBBDDHO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint MHOBFIFAGLF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private uint GJLHABOCECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint ELGCFHPJOFO[8];

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6330", Offset = "0x6BC4D30", VA = "0x186BC6330")]
	private void OPIOKFDHGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6300", Offset = "0x6BC4D00", VA = "0x186BC6300")]
	private uint MDCLIIIPFCO(uint LFDANFLODKB, int OIIOIGPIKMN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFC60", Offset = "0x6BAE660", VA = "0x186BAFC60")]
	private void JOCFAJMECMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6BAFA50", Offset = "0x6BAE450", VA = "0x186BAFA50")]
	private void JHPILNDGAPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF9C0", Offset = "0x6BAE3C0", VA = "0x186BAF9C0")]
	private void FAIPAJBKPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6BAF8C0", Offset = "0x6BAE2C0", VA = "0x186BAF8C0")]
	private void BOBPNKJPJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6230", Offset = "0x6BC4C30", VA = "0x186BC6230")]
	private void JDNJPKPPKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5BB0", Offset = "0x6BC45B0", VA = "0x186BC5BB0")]
	private unsafe void CKAJNLCDEFO(byte* OHNCDBKHLPH, uint* NJBPFCDJFGD, uint* IOFGMGMEHJJ, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6BC60B0", Offset = "0x6BC4AB0", VA = "0x186BC60B0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void FIICGDMNEOI([NoAlias] byte* OHNCDBKHLPH, [NoAlias] byte* NJBPFCDJFGD, [NoAlias] byte* IOFGMGMEHJJ, int ENHEICOLGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6BC5FD0", Offset = "0x6BC49D0", VA = "0x186BC5FD0")]
	public static void FIICGDMNEOI(Span<byte> OHNCDBKHLPH, Span<byte> NJBPFCDJFGD, Span<byte> IOFGMGMEHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6130", Offset = "0x6BC4B30", VA = "0x186BC6130")]
	public static void HJOGGNKHOBG(Span<byte> OHNCDBKHLPH, Span<byte> NJBPFCDJFGD, Span<byte> IOFGMGMEHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6BC6290", Offset = "0x6BC4C90", VA = "0x186BC6290")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JLNBPPJFDKE([NoAlias] byte* OHNCDBKHLPH, [NoAlias] byte* NJBPFCDJFGD, [NoAlias] byte* IOFGMGMEHJJ, int ENHEICOLGJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6BC7D10", Offset = "0x6BC6710", VA = "0x186BC7D10")]
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
