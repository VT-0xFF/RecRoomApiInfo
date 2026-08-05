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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CLPHGPJLHEO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum BJIBCKEFMPA
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
		private NetworkManager GEONOELKFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, FPGEINFCCCA> GAJDGLHJBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CLADPEJAMAE LDPPDNLMKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] NOLLAFAEFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BJIBCKEFMPA OFFKMEFNJHP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong GKHKJGIEIPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EAJGPMMNBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D15E40", Offset = "0x5D15240", VA = "0x185D15E40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D153A0", Offset = "0x5D147A0", VA = "0x185D153A0")]
		public void RecRoom_SetEncryptionInfo(ulong GECJPFHMLBN, byte[] PEDCMDADFIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D15380", Offset = "0x5D14780", VA = "0x185D15380")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D15180", Offset = "0x5D14580", VA = "0x185D15180")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D15D40", Offset = "0x5D15140", VA = "0x185D15D40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D15540", Offset = "0x5D14940", VA = "0x185D15540", Slot = "6")]
		public override void Send(ulong HEPLMLLCCGN, ArraySegment<byte> LDNEPNAGEGN, NetworkDelivery EAGHPODDFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D15340", Offset = "0x5D14740", VA = "0x185D15340", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong HEPLMLLCCGN, [Out] ArraySegment<byte> OGPKCLEACHE, [Out] float ECPAENHCFMN)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D15830", Offset = "0x5D14C30", VA = "0x185D15830", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D15C60", Offset = "0x5D15060", VA = "0x185D15C60", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D14920", Offset = "0x5D13D20", VA = "0x185D14920", Slot = "10")]
		public override void DisconnectRemoteClient(ulong HEPLMLLCCGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D147D0", Offset = "0x5D13BD0", VA = "0x185D147D0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D14A90", Offset = "0x5D13E90", VA = "0x185D14A90", Slot = "12")]
		public override ulong GetCurrentRtt(ulong HEPLMLLCCGN)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D157C0", Offset = "0x5D14BC0", VA = "0x185D157C0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D14D90", Offset = "0x5D14190", VA = "0x185D14D90", Slot = "14")]
		public override void Initialize([Optional] NetworkManager GEONOELKFIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D15270", Offset = "0x5D14670", VA = "0x185D15270")]
		private GOFOCEGAFME PCOFOHGAAMC(NetworkDelivery EPPKBKJHHHJ)
		{
			return default(GOFOCEGAFME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D14B30", Offset = "0x5D13F30", VA = "0x185D14B30", Slot = "15")]
		private void HICKBBMLCPF(FPGEINFCCCA IOAKIFIGGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D14BF0", Offset = "0x5D13FF0", VA = "0x185D14BF0", Slot = "16")]
		private void HJPNNOBOHGB(FPGEINFCCCA IOAKIFIGGBH, GDFAKGJNHFC OOOJLOGALGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "17")]
		private void JDKCFFPDGCC(IPEndPoint MDGDCOHGNED, SocketError EKPJJCOMIHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D14F70", Offset = "0x5D14370", VA = "0x185D14F70", Slot = "18")]
		private void KEJPGNFIPJL(FPGEINFCCCA IOAKIFIGGBH, AKCJJKEHLOI CKPGDBBGEAK, byte MIMEEFAJLJF, GOFOCEGAFME NIDOEDMFKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D146C0", Offset = "0x5D13AC0", VA = "0x185D146C0")]
		private void BNDPKOKBIBE(int CGDIEJGGJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "19")]
		private void MHENMKKOCGI(IPEndPoint NINOEBFNAIG, AKCJJKEHLOI CKPGDBBGEAK, NBAOHALICIG IHHJBDJAIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "20")]
		private void BMKNPOICGCL(FPGEINFCCCA IOAKIFIGGBH, int PIAOFBBDFNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D14D30", Offset = "0x5D14130", VA = "0x185D14D30", Slot = "21")]
		private void IBIINMFCEFP(KGNIFLPPDCG BNAGIPDFDCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D147A0", Offset = "0x5D13BA0", VA = "0x185D147A0")]
		private ulong DFPBJEGECPH(FPGEINFCCCA IOAKIFIGGBH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D14F50", Offset = "0x5D14350", VA = "0x185D14F50")]
		private static int KCLIGCIPACJ(float NEHLEIDGFCE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D15D60", Offset = "0x5D15160", VA = "0x185D15D60")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class OFAGDPNJGEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly FPGEINFCCCA EBNDPNIBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<DKOAKLPCBMN> AHBHHFCEBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int DDOPGKGCHEH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D172D0", Offset = "0x5D166D0", VA = "0x185D172D0")]
	protected OFAGDPNJGEB(FPGEINFCCCA IOAKIFIGGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D17270", Offset = "0x5D16670", VA = "0x185D17270")]
	public void LMMKGKHNCOL(DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D171F0", Offset = "0x5D165F0", VA = "0x185D171F0")]
	protected void CBMGNLDECIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D171B0", Offset = "0x5D165B0", VA = "0x185D171B0")]
	public bool BDJKFJJOMCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool AKFGLFJEBAD();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool OCMFKDNLIHL(DKOAKLPCBMN LAADNNJHANL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum LJOLMKDHHOJ
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
public class KGNIFLPPDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CLADPEJAMAE JBEPIGKNOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int OBFFDALNKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal NNMJPEHKEPJ NKJPJAGMGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint HMAGFDMJIHO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LJOLMKDHHOJ BDLIBMMJKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x873980", Offset = "0x872D80", VA = "0x180873980")]
		[CompilerGenerated]
		get
		{
			return default(LJOLMKDHHOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBA3F50", Offset = "0xBA3350", VA = "0x180BA3F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D13AD0", Offset = "0x5D12ED0", VA = "0x185D13AD0")]
	internal void GIBNOPIGJAE(NNMJPEHKEPJ FCAIKAGJBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D13B30", Offset = "0x5D12F30", VA = "0x185D13B30")]
	private bool MGGCHEPJNMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D13B60", Offset = "0x5D12F60", VA = "0x185D13B60")]
	internal KGNIFLPPDCG(IPEndPoint NINOEBFNAIG, NNMJPEHKEPJ JHEJAHOJNHP, CLADPEJAMAE GAIJEBPOFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D13A70", Offset = "0x5D12E70", VA = "0x185D13A70")]
	public FPGEINFCCCA ADIKHNFLBHG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NBAOHALICIG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DLGGEAAFBOJ
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
public struct GDFAKGJNHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DLGGEAAFBOJ JPCBFGBKGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError OOGFGEJDJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public AKCJJKEHLOI BPHEEJDELKC;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CLPHGPJLHEO
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJOCMFGHKMH(FPGEINFCCCA IOAKIFIGGBH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOGPOPNNINB(FPGEINFCCCA IOAKIFIGGBH, GDFAKGJNHFC OOOJLOGALGK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CKINOMEPPBF(IPEndPoint MDGDCOHGNED, SocketError EKPJJCOMIHE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGIHDKKBGJP(FPGEINFCCCA IOAKIFIGGBH, AKCJJKEHLOI CKPGDBBGEAK, byte MIMEEFAJLJF, GOFOCEGAFME NIDOEDMFKAG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGDAHMCCBEA(IPEndPoint NINOEBFNAIG, AKCJJKEHLOI CKPGDBBGEAK, NBAOHALICIG IHHJBDJAIEA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILOAODJNBNH(FPGEINFCCCA IOAKIFIGGBH, int PIAOFBBDFNP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPJMGAKGIPK(KGNIFLPPDCG BNAGIPDFDCE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GOAHBGGAHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBOMOIJHEOE(FPGEINFCCCA IOAKIFIGGBH, object JJPBEPEALHF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MKLBADOBLJH
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NJPEBIIKLII(CLEFHPCOHPH LAADNNJHANL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GIABLMKIIBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMBCJHKFHN(FPGEINFCCCA IOAKIFIGGBH, IPEndPoint AHDDNNFNGMA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class NNMJPEHKEPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NJKJDEFBJIP = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long DADFCBGOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte LPMKGEKHPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] FDJFDIFLLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly GEMHGOCGBBK GAMKDEPHLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int BKOKCAMOFCF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D17040", Offset = "0x5D16440", VA = "0x185D17040")]
	private NNMJPEHKEPJ(long AFJCBMAFAEI, byte EEOJBDIDHJM, int OCKGPBNMNLE, byte[] CLIAPELGJNC, GEMHGOCGBBK LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D16FE0", Offset = "0x5D163E0", VA = "0x185D16FE0")]
	public static int PFLNEDFCKPO(DKOAKLPCBMN LAADNNJHANL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D16BE0", Offset = "0x5D15FE0", VA = "0x185D16BE0")]
	public static NNMJPEHKEPJ HONDACIBOLA(DKOAKLPCBMN LAADNNJHANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D16E00", Offset = "0x5D16200", VA = "0x185D16E00")]
	public static DKOAKLPCBMN NDOJFJIHHCM(PCNCFLKAHOI BJNFFLBOJMB, SocketAddress EEIHBBHPPKO, long PIHMPDBOCJJ, int OCKGPBNMNLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HCKEBLBCIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long DADFCBGOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte LPMKGEKHPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int BKOKCAMOFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool KKKOAPKJLHI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D12E90", Offset = "0x5D12290", VA = "0x185D12E90")]
	private HCKEBLBCIDF(long AFJCBMAFAEI, byte EEOJBDIDHJM, int BCCCGMBELJJ, bool JFGBOODIMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D12B50", Offset = "0x5D11F50", VA = "0x185D12B50")]
	public static HCKEBLBCIDF HONDACIBOLA(DKOAKLPCBMN LAADNNJHANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D12DA0", Offset = "0x5D121A0", VA = "0x185D12DA0")]
	public static DKOAKLPCBMN NDOJFJIHHCM(long PIHMPDBOCJJ, byte NAOEANEHLBN, int PHANNBIAEDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D12CA0", Offset = "0x5D120A0", VA = "0x185D12CA0")]
	public static DKOAKLPCBMN LBLMLDKBDHL(FPGEINFCCCA IOAKIFIGGBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum KHLPOKBLAFO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface OMDBIBDBOAH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKHMDEIFHGJ(IPEndPoint OOJHIGDOHIP, IPEndPoint NINOEBFNAIG, string IAIFDAAIBBN);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEDPMMMBIPE(IPEndPoint JKGCJJLEJNG, KHLPOKBLAFO EPPKBKJHHHJ, string IAIFDAAIBBN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JLGCBPCBMEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OJLGKAEGKHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint JNAGDFKPJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint HMAGFDMJIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string OCCFHHIPPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct PKGHGPHGIOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint NDDBPCEJIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KHLPOKBLAFO CJOIENFDBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string OCCFHHIPPPA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class MIOILKLGMME
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint MKEBBKADEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string OCCFHHIPPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public MIOILKLGMME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class ECDIKMNGDOP
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint MKEBBKADEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint AKGCGADOCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string OCCFHHIPPPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public ECDIKMNGDOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class GGDFPAOMAMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OCCFHHIPPPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CHKGJPDKOGO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x95D500", Offset = "0x95C900", VA = "0x18095D500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x854F60", Offset = "0x854360", VA = "0x180854F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public GGDFPAOMAMH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CLADPEJAMAE CNEJMPNHPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OJLGKAEGKHG> CDPOKFHJDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<PKGHGPHGIOG> FKGLPGMLJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GEMHGOCGBBK CEDIJFMMAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PCNCFLKAHOI BBOCDHINKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly MODENHEAOAM BEIMEAIGDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private OMDBIBDBOAH DPKPEDOGKOH;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LAIMOHGDKKF = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool LNDKPLFLEJC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D134E0", Offset = "0x5D128E0", VA = "0x185D134E0")]
	internal JLGCBPCBMEJ(CLADPEJAMAE CIDLNIABKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D13380", Offset = "0x5D12780", VA = "0x185D13380")]
	internal void NEGLBKPLJBC(IPEndPoint EDKOHLPBCBP, DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BDCEF0", Offset = "0x2BDC2F0", VA = "0x182BDCEF0")]
	private void HKOFOPFBJBM<T>(T LAADNNJHANL, IPEndPoint KMCPIOGEAKL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D131F0", Offset = "0x5D125F0", VA = "0x185D131F0")]
	private void MKHMDEIFHGJ(MIOILKLGMME EHFMLFLFKPO, IPEndPoint EDKOHLPBCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D13090", Offset = "0x5D12490", VA = "0x185D13090")]
	private void KBJLNKOJKAJ(ECDIKMNGDOP EHFMLFLFKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D12EF0", Offset = "0x5D122F0", VA = "0x185D12EF0")]
	private void BEEDPLIGIKO(GGDFPAOMAMH EHFMLFLFKPO, IPEndPoint EDKOHLPBCBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum GOFOCEGAFME : byte
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
public enum LKIPDPDHAKL : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GBMIEACIIJC
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] LBMMDONMPHL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int HIIIDFBMIPL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int MDOFNPMAJKF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IPJHBIJPECI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D12EE0", Offset = "0x5D122E0", VA = "0x185D12EE0")]
	public IPJHBIJPECI(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PDGNCHJEECM : IPJHBIJPECI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D12EE0", Offset = "0x5D122E0", VA = "0x185D12EE0")]
	public PDGNCHJEECM(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OPAFFEIBECB
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
public interface FBJDMJCDKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLCGAPNJHMM(OPAFFEIBECB GHOMNPIHGKK, string AIAOKDOODNM, params object[] JEKDODJMDHN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LJKMCGKOJCG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static FBJDMJCDKOC IKCJBMPGCAG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object ICACAIJDPHN;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D13E70", Offset = "0x5D13270", VA = "0x185D13E70")]
	private static void FDKNGOACHPH(OPAFFEIBECB APNOJOKPFJN, string AIAOKDOODNM, params object[] JEKDODJMDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D13DB0", Offset = "0x5D131B0", VA = "0x185D13DB0")]
	internal static void EJPLHODDGEC(string AIAOKDOODNM, params object[] JEKDODJMDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D13E10", Offset = "0x5D13210", VA = "0x185D13E10")]
	internal static void ELIKPFOHJFH(string AIAOKDOODNM, params object[] JEKDODJMDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D13D50", Offset = "0x5D13150", VA = "0x185D13D50")]
	internal static void EHBENGFNGAL(string AIAOKDOODNM, params object[] JEKDODJMDHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum MGOOFMLBDFI
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AKCJJKEHLOI : GEMHGOCGBBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DKOAKLPCBMN DGPJKGFPCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CLADPEJAMAE LOEEFAALGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KAJMCNEGBHO PHLNDBCGJHM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D025F0", Offset = "0x5D019F0", VA = "0x185D025F0")]
	internal AKCJJKEHLOI(CLADPEJAMAE BENNAIJLPHL, KAJMCNEGBHO DBNKKPNHHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D02550", Offset = "0x5D01950", VA = "0x185D02550")]
	internal void KEEIKHMBODP(DKOAKLPCBMN LAADNNJHANL, int PBBCHLLGBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D024D0", Offset = "0x5D018D0", VA = "0x185D024D0")]
	internal void EFADMANAAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D025C0", Offset = "0x5D019C0", VA = "0x185D025C0")]
	public void KIFCHJMDLPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KAJMCNEGBHO
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum ADHNNOKLPNL
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
	public KAJMCNEGBHO DLIKKPIGMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public ADHNNOKLPNL CJOIENFDBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public FPGEINFCCCA EBNDPNIBBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint HMAGFDMJIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object LCLKECPAMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int MJHHPPEDKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError HJMFPFKFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public DLGGEAAFBOJ IGELGPOFILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public KGNIFLPPDCG CPBOENGGEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GOFOCEGAFME ALKHDJNNKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte EPOAKMGNEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly AKCJJKEHLOI EKOIFGHIDAA;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D139D0", Offset = "0x5D12DD0", VA = "0x185D139D0")]
	public KAJMCNEGBHO(CLADPEJAMAE BENNAIJLPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CLADPEJAMAE : IEnumerable<FPGEINFCCCA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class FPHLDHOOLJC : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D115B0", Offset = "0x5D109B0", VA = "0x185D115B0", Slot = "4")]
		public bool Equals(IPEndPoint PCHHOKEGOFA, IPEndPoint PDEIPLKJFKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57B5320", Offset = "0x57B4720", VA = "0x1857B5320", Slot = "5")]
		public int GetHashCode(IPEndPoint LALIGKIKEBM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public FPHLDHOOLJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct JMLLGFGDFNK : IEnumerator<FPGEINFCCCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly FPGEINFCCCA MDBBPAEHNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private FPGEINFCCCA NLOEEMHIFEG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FPGEINFCCCA AKMKAIGAIOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x99D390", Offset = "0x99C790", VA = "0x18099D390", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x99D390", Offset = "0x99C790", VA = "0x18099D390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x11CE1B0", Offset = "0x11CD5B0", VA = "0x1811CE1B0")]
		public JMLLGFGDFNK(FPGEINFCCCA MMNGAEPEJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D13930", Offset = "0x5D12D30", VA = "0x185D13930", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D13980", Offset = "0x5D12D80", VA = "0x185D13980", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread KLAIOAFLOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool OAIBPLLFGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent JLLINMHIACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KAJMCNEGBHO> OLDCAMHOGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KAJMCNEGBHO> PHFAJOODGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private KAJMCNEGBHO CFLINJAPAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CLPHGPJLHEO KIDIJKOFNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly GOAHBGGAHCH LKKENEEJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly MKLBADOBLJH HDMCNHNFECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GIABLMKIIBJ JILJEKLJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, FPGEINFCCCA> DCJIHFIFHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, KGNIFLPPDCG> PEJIIPHKGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, OAKMGMCPAHB> JDJLDJEGHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim KKIHFKOCHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private FPGEINFCCCA BKHKAHODDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int IOKMNEIBMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<FPGEINFCCCA> NEBBLOLHILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private FPGEINFCCCA[] PGKOJLACBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KMHDKIABKLD HLNDHCCBJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int MPPGJGLGNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> MCGDLBFPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte MADIDEBNLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object GLKFJLOOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool LMDLAOCILCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool PNOCMCDDODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int PPJGIDPKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int EJIIJDPLDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int ANHPODPGHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HNDLFLOLIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool GBOHLBGIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FFALFCPEOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JBLJADJHECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LAJDBLJHOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int NJILEMCODOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool LNDKPLFLEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool EGICOAMIIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KPDGAPIAFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool EPONFFBCDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int JBBCEGOEODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int FACAGNONBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PKKNBBCODOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly DBJAOBOHLMI KHMALOLBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool BCCMCILOOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly JLGCBPCBMEJ MCNNLLBIOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool KNPIHFIGKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public MGOOFMLBDFI GCFMIINOJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int BICECNKLDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool JMLLLLDPFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool CBEFIPDPAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool CNFNLPDPFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool JFFPNPGEFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private DKOAKLPCBMN FOBEKHDCICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int IALFADNCFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object KFCFACOKOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DKOAKLPCBMN FJIPBMEKNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int ICJMPHJNBLN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int NOGANJELIHJ = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int EHAMKAGFGMD = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LIGLJHDIDHF ELKIJAGCGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LIGLJHDIDHF JLDCCCFFLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread IJJFFKLCMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NKBGICIAPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint MGIEMBNFBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint DJGFDKBENCK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] EHLADEAGPCA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] DBIJPGDJBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<MEPKDJPOFKD, IPEndPoint> FKJMONPBKFE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress IKLFDPLFEEL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool ENALGBOGGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int MLEFLGOHOKM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NBFCMJAOFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCA9C30", Offset = "0xCA9030", VA = "0x180CA9C30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xD79630", Offset = "0xD78A30", VA = "0x180D79630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FFHNKMIHCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15D08E0", Offset = "0x15CFCE0", VA = "0x1815D08E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1902030", Offset = "0x1901430", VA = "0x181902030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte GPLKHFCAKBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x988890", Offset = "0x987C90", VA = "0x180988890")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FHALBLCLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D02990", Offset = "0x5D01D90", VA = "0x185D02990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short IILNPCIDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D029B0", Offset = "0x5D01DB0", VA = "0x185D029B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D04A20", Offset = "0x5D03E20", VA = "0x185D04A20")]
	public void GMFKDHAPNGF(IPEndPoint MDGDCOHGNED, byte[] PEDCMDADFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D02840", Offset = "0x5D01C40", VA = "0x185D02840")]
	public void AHJNHHGIJHN(IPEndPoint MDGDCOHGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D05730", Offset = "0x5D04B30", VA = "0x185D05730")]
	private bool IGPENLCAEAO(IPEndPoint MDGDCOHGNED, [Out] FPGEINFCCCA IOAKIFIGGBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D03E00", Offset = "0x5D03200", VA = "0x185D03E00")]
	private void EOONKOMKJIP(FPGEINFCCCA IOAKIFIGGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D06E20", Offset = "0x5D06220", VA = "0x185D06E20")]
	private void NDBEPHEBMIB(FPGEINFCCCA IOAKIFIGGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D02C10", Offset = "0x5D02010", VA = "0x185D02C10")]
	private void BPFMOHHNKEB(FPGEINFCCCA IOAKIFIGGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D093F0", Offset = "0x5D087F0", VA = "0x185D093F0")]
	public CLADPEJAMAE(CLPHGPJLHEO GAIJEBPOFHJ, [Optional] KMHDKIABKLD NPNKPKILIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D07DE0", Offset = "0x5D071E0", VA = "0x185D07DE0")]
	internal void OIKLFLFABKE(FPGEINFCCCA HFBPGANKDPG, int PIAOFBBDFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D03040", Offset = "0x5D02440", VA = "0x185D03040")]
	internal void DIPGHGLHGHB(FPGEINFCCCA HFBPGANKDPG, object JJPBEPEALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5D06690", Offset = "0x5D05A90", VA = "0x185D06690")]
	internal void KBGKHCOGIOG(FPGEINFCCCA IOAKIFIGGBH, DLGGEAAFBOJ PCEHLDFDGKI, SocketError IAKIAFAJICF, DKOAKLPCBMN CNFOCMAJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D06C80", Offset = "0x5D06080", VA = "0x185D06C80")]
	private void MOPIKELMMOK(FPGEINFCCCA IOAKIFIGGBH, DLGGEAAFBOJ PCEHLDFDGKI, SocketError IAKIAFAJICF, bool MCCPONPGBFK, byte[] LDNEPNAGEGN, int DEABOIPAFEI, int MLMABEGDEJH, DKOAKLPCBMN CNFOCMAJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D03940", Offset = "0x5D02D40", VA = "0x185D03940")]
	private void ELCHCANHEHG(KAJMCNEGBHO.ADHNNOKLPNL EPPKBKJHHHJ, [Optional] FPGEINFCCCA IOAKIFIGGBH, [Optional] IPEndPoint NINOEBFNAIG, SocketError AKHNJOEGAAO = SocketError.Success, int PIAOFBBDFNP = 0, DLGGEAAFBOJ JHCFPJPCBEJ = DLGGEAAFBOJ.ConnectionFailed, [Optional] KGNIFLPPDCG EDPDMPOJDPL, GOFOCEGAFME NIDOEDMFKAG = GOFOCEGAFME.Unreliable, byte MIMEEFAJLJF = 0, [Optional] DKOAKLPCBMN LFEMCAIELAP, [Optional] object JJPBEPEALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D04F70", Offset = "0x5D04370", VA = "0x185D04F70")]
	private void IACEBDMJPKI(KAJMCNEGBHO DBNKKPNHHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D03D00", Offset = "0x5D03100", VA = "0x185D03D00")]
	internal void EMGCDKBBFKP(KAJMCNEGBHO DBNKKPNHHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D07880", Offset = "0x5D06C80", VA = "0x185D07880")]
	private void ODIGPFNMBKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D04700", Offset = "0x5D03B00", VA = "0x185D04700")]
	private void GCJNAFPOMLL(int CKLEPIJBMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D059B0", Offset = "0x5D04DB0", VA = "0x185D059B0")]
	internal FPGEINFCCCA JDHKFHCDMAA(KGNIFLPPDCG BNAGIPDFDCE, byte[] KNOMCLALDIO, int DEABOIPAFEI, int CHJNEOPKHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D057C0", Offset = "0x5D04BC0", VA = "0x185D057C0")]
	private int IIOCOANFDDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D06230", Offset = "0x5D05630", VA = "0x185D06230")]
	private void JPBIDJPOIPO(IPEndPoint NINOEBFNAIG, FPGEINFCCCA IBEEGDBBOED, NNMJPEHKEPJ BHHJMKGKNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D08450", Offset = "0x5D07850", VA = "0x185D08450")]
	private void PPLMMNEDIDF(DKOAKLPCBMN LAADNNJHANL, IPEndPoint NINOEBFNAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D07E30", Offset = "0x5D07230", VA = "0x185D07E30")]
	internal void ONNJAENEDDP(DKOAKLPCBMN LAADNNJHANL, GOFOCEGAFME BAGEENCOBFH, byte MIMEEFAJLJF, int PBBCHLLGBGD, FPGEINFCCCA HFBPGANKDPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D07010", Offset = "0x5D06410", VA = "0x185D07010")]
	public bool OBMMDJGNFBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D07860", Offset = "0x5D06C60", VA = "0x185D07860")]
	public bool OBMMDJGNFBM(IPAddress DKECFMNLKLK, IPAddress FEEFKBHGGMJ, int HDOKGLCAPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D077E0", Offset = "0x5D06BE0", VA = "0x185D077E0")]
	public bool OBMMDJGNFBM(int HDOKGLCAPFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D02A70", Offset = "0x5D01E70", VA = "0x185D02A70")]
	public void BJADJBEIDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D033B0", Offset = "0x5D027B0", VA = "0x185D033B0")]
	public FPGEINFCCCA EFCAGDMAOAB(string MNFLPNCDDMI, int HDOKGLCAPFN, string PEDCMDADFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D03860", Offset = "0x5D02C60", VA = "0x185D03860")]
	public FPGEINFCCCA EFCAGDMAOAB(string MNFLPNCDDMI, int HDOKGLCAPFN, PCNCFLKAHOI MFOBOFDPFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D03490", Offset = "0x5D02890", VA = "0x185D03490")]
	public FPGEINFCCCA EFCAGDMAOAB(IPEndPoint KMCPIOGEAKL, PCNCFLKAHOI MFOBOFDPFBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D08440", Offset = "0x5D07840", VA = "0x185D08440")]
	public void PJFGNNEKLMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D080F0", Offset = "0x5D074F0", VA = "0x185D080F0")]
	public void PJFGNNEKLMG(bool PNEIONBHKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D07BC0", Offset = "0x5D06FC0", VA = "0x185D07BC0")]
	public void OFDPHLNHIJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D07CC0", Offset = "0x5D070C0", VA = "0x185D07CC0")]
	public void OFDPHLNHIJM(byte[] LDNEPNAGEGN, int DEABOIPAFEI, int MLMABEGDEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D06BD0", Offset = "0x5D05FD0", VA = "0x185D06BD0")]
	public void MOPIKELMMOK(FPGEINFCCCA IOAKIFIGGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D06D60", Offset = "0x5D06160", VA = "0x185D06D60")]
	public void MOPIKELMMOK(FPGEINFCCCA IOAKIFIGGBH, byte[] LDNEPNAGEGN, int DEABOIPAFEI, int MLMABEGDEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D09210", Offset = "0x5D08610", VA = "0x185D09210", Slot = "4")]
	private IEnumerator<FPGEINFCCCA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D092A0", Offset = "0x5D086A0", VA = "0x185D092A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D02E70", Offset = "0x5D02270", VA = "0x185D02E70")]
	private DKOAKLPCBMN DCJEOPBLOJG(AIDNGLJNNOA GEGAKMCPGBL, int CGDIEJGGJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D02F60", Offset = "0x5D02360", VA = "0x185D02F60")]
	private DKOAKLPCBMN DCJEOPBLOJG(AIDNGLJNNOA GEGAKMCPGBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D03180", Offset = "0x5D02580", VA = "0x185D03180")]
	internal DKOAKLPCBMN ECEHJFEBJEI(int CGDIEJGGJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D05FD0", Offset = "0x5D053D0", VA = "0x185D05FD0")]
	internal void JLFLLOBILBA(DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D09330", Offset = "0x5D08730", VA = "0x185D09330")]
	static CLADPEJAMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xCA9C30", Offset = "0xCA9030", VA = "0x180CA9C30")]
	private bool MGBFPLDKMLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D03090", Offset = "0x5D02490", VA = "0x185D03090")]
	private void EBAGIPANFBC(IPEndPoint NCHGGJJOALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D06760", Offset = "0x5D05B60", VA = "0x185D06760")]
	private void KODKEEAFBDK(IPEndPoint NCHGGJJOALI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D06E70", Offset = "0x5D06270", VA = "0x185D06E70")]
	private bool NEICMGCMBHH(SocketException PIBFNCHIFEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D04CA0", Offset = "0x5D040A0", VA = "0x185D04CA0")]
	private void HOAGOAMGBMK(LIGLJHDIDHF CIDLNIABKGF, EndPoint KLDPJDLMFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D06840", Offset = "0x5D05C40", VA = "0x185D06840")]
	private void KPHFDOBDANA(object AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D07020", Offset = "0x5D06420", VA = "0x185D07020")]
	public bool OBMMDJGNFBM(IPAddress DKECFMNLKLK, IPAddress FEEFKBHGGMJ, int HDOKGLCAPFN, bool LKIPEAGOMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D04C40", Offset = "0x5D04040", VA = "0x185D04C40")]
	internal int HIPDEAEKLEI(DKOAKLPCBMN LAADNNJHANL, IPEndPoint NINOEBFNAIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D046C0", Offset = "0x5D03AC0", VA = "0x185D046C0")]
	internal int FMJLDBLMCLK(DKOAKLPCBMN LAADNNJHANL, IPEndPoint NINOEBFNAIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D040C0", Offset = "0x5D034C0", VA = "0x185D040C0")]
	internal int FMJLDBLMCLK(byte[] PBDOHNMILPN, int DEABOIPAFEI, int CHJNEOPKHME, IPEndPoint NINOEBFNAIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D05840", Offset = "0x5D04C40", VA = "0x185D05840")]
	internal void IMNHKBHDNED(bool FCPPOPAHJEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum AIDNGLJNNOA : byte
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
internal sealed class DKOAKLPCBMN
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int FPENLFKKFMP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] HILDDMEHGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] GKODDAMIDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int MBPNHHIKNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object LCLKECPAMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public DKOAKLPCBMN DLIKKPIGMNG;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AIDNGLJNNOA PLHCOPFFLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BEB0", Offset = "0x5D0B2B0", VA = "0x185D0BEB0")]
		get
		{
			return default(AIDNGLJNNOA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BF10", Offset = "0x5D0B310", VA = "0x185D0BF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte LPMKGEKHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C3A0", Offset = "0x5D0B7A0", VA = "0x185D0C3A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C2F0", Offset = "0x5D0B6F0", VA = "0x185D0C2F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LHDEBCFIDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BE50", Offset = "0x5D0B250", VA = "0x185D0BE50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BFB0", Offset = "0x5D0B3B0", VA = "0x185D0BFB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EADACNJDGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C330", Offset = "0x5D0B730", VA = "0x185D0C330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LFCKMECGFEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BF80", Offset = "0x5D0B380", VA = "0x185D0BF80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BF50", Offset = "0x5D0B350", VA = "0x185D0BF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JINBLBOJEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C050", Offset = "0x5D0B450", VA = "0x185D0C050")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C360", Offset = "0x5D0B760", VA = "0x185D0C360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort GDLIDADNOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BFF0", Offset = "0x5D0B3F0", VA = "0x185D0BFF0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BE10", Offset = "0x5D0B210", VA = "0x185D0BE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DAGBMCPEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C3D0", Offset = "0x5D0B7D0", VA = "0x185D0C3D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C2B0", Offset = "0x5D0B6B0", VA = "0x185D0C2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C430", Offset = "0x5D0B830", VA = "0x185D0C430")]
	static DKOAKLPCBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BEE0", Offset = "0x5D0B2E0", VA = "0x185D0BEE0")]
	public void CFANPIHHCGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C710", Offset = "0x5D0BB10", VA = "0x185D0C710")]
	public DKOAKLPCBMN(int CGDIEJGGJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C780", Offset = "0x5D0BB80", VA = "0x185D0C780")]
	public DKOAKLPCBMN(AIDNGLJNNOA GEGAKMCPGBL, int CGDIEJGGJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C140", Offset = "0x5D0B540", VA = "0x185D0C140")]
	public static int IMGFLDLJOBE(AIDNGLJNNOA GEGAKMCPGBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C0B0", Offset = "0x5D0B4B0", VA = "0x185D0C0B0")]
	public int IMGFLDLJOBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C1B0", Offset = "0x5D0B5B0", VA = "0x185D0C1B0")]
	public bool JALEIJHGANA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum PNGLBGFJDIM : byte
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
internal enum IDGDHLPDDDA
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
internal enum LPPHFDAOJCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum AFFHNOOOEPP
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class FPGEINFCCCA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class EEHEHNKIOHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DKOAKLPCBMN[] CANPMFABALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int JLEPDHIFODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int GEKDBLJBAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte LFCKMECGFEI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public EEHEHNKIOHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void KJOJMLBCHPB(ulong APCHJKDKLFI, int MALKAHMKDAN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int DDHIAKLNIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int JBAPEOMEHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int HBKKJLGKCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double PNNHMFFJPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int ALBFGDPBPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int OGJHNMHDCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int EELKJJMLHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch GGAHEHKCKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FFKCDPILBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PCHJPDFJAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object BHNMFHHNDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal FPGEINFCCCA FBOOBGFKBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal FPGEINFCCCA FNDNCAMLPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<DKOAKLPCBMN> ENONCFAAHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<OFAGDPNJGEB> FCHKGCFKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OFAGDPNJGEB[] BJEGEBKLMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int ILCGGIIMDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int DMDJBOHPBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool GAICIBJOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int BJALPBABEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int PEPIDJFBLNP;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int MMMJPOFIFCE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int EFIIEFMGKKP = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object IHHHPJIKFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KCBFCPLGMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, EEHEHNKIOHE> GALIFBONNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> DBMDJJHJAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DKOAKLPCBMN ANFPJLHAEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int GPICGALKMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int NCOBGEBHGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint PGONHFILJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IENDKAPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int GDGPIADPNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long CHIKCPKHBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte BLELCDMHGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private PNGLBGFJDIM KMNFPBIKALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private DKOAKLPCBMN OBPGFGDJMBM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int KHLLFPDDCAJ = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int IGFHHBKLLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly DKOAKLPCBMN CEGPDKMDLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly DKOAKLPCBMN FMOEGKKAEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly DKOAKLPCBMN GFNBAFHFJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly DKOAKLPCBMN EFMMJBDAIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LKIPDPDHAKL CIFLPPKHMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly CLADPEJAMAE BIMCNEOBLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int PIBGEMNFMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object EFOGMLLEJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly DBJAOBOHLMI KHMALOLBCDA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte GGHOPEKJBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xCECB40", Offset = "0xCEBF40", VA = "0x180CECB40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F6C0", Offset = "0x5D0EAC0", VA = "0x185D0F6C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint JCGBFBDECEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AAEF0", Offset = "0x9AA2F0", VA = "0x1809AAEF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PNGLBGFJDIM PDJAIBIMOKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x140F4E0", Offset = "0x140E8E0", VA = "0x18140F4E0")]
		get
		{
			return default(PNGLBGFJDIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KNDDKADDMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84CD60", Offset = "0x84C160", VA = "0x18084CD60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CKEBNBNIBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xDBD260", Offset = "0xDBC660", VA = "0x180DBD260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x16C0C20", Offset = "0x16C0020", VA = "0x1816C0C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int MHJDANMOEGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D3A0", Offset = "0x5D0C7A0", VA = "0x185D0D3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int POPOHCBFGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85B590", Offset = "0x85A990", VA = "0x18085B590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double MBEHAMIOEEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1B70CE0", Offset = "0x1B700E0", VA = "0x181B70CE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KJOJMLBCHPB CNFMNKEKLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D10330", Offset = "0x5D0F730", VA = "0x185D10330")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D0F9B0", Offset = "0x5D0EDB0", VA = "0x185D0F9B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D11150", Offset = "0x5D10550", VA = "0x185D11150")]
	internal FPGEINFCCCA(CLADPEJAMAE DKPAEGMCHDL, IPEndPoint NINOEBFNAIG, int GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D10310", Offset = "0x5D0F710", VA = "0x185D10310")]
	internal void NJBOKEILAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FCC0", Offset = "0x5D0F0C0", VA = "0x185D0FCC0")]
	internal void LMMADDNGOPN(IPEndPoint DEHBCMKGNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E4B0", Offset = "0x5D0D8B0", VA = "0x185D0E4B0")]
	internal void FDHGFHJPOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FCF0", Offset = "0x5D0F0F0", VA = "0x185D0FCF0")]
	private void MCBMBGOKAJH(int ECGLPJBBOKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F5A0", Offset = "0x5D0E9A0", VA = "0x185D0F5A0")]
	private void ILOJMHHNOIC(int NMGJFBLDKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FA60", Offset = "0x5D0EE60", VA = "0x185D0FA60")]
	private OFAGDPNJGEB LKAGLOPFGLK(byte NIMLCNCKAOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D10DE0", Offset = "0x5D101E0", VA = "0x185D10DE0")]
	internal FPGEINFCCCA(CLADPEJAMAE DKPAEGMCHDL, IPEndPoint NINOEBFNAIG, int GNBDDFJPEIA, byte NAOEANEHLBN, PCNCFLKAHOI BJNFFLBOJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D10F70", Offset = "0x5D10370", VA = "0x185D10F70")]
	internal FPGEINFCCCA(CLADPEJAMAE DKPAEGMCHDL, KGNIFLPPDCG BNAGIPDFDCE, int GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D10D90", Offset = "0x5D10190", VA = "0x185D10D90")]
	internal void PEMGCKOLPKO(NNMJPEHKEPJ HGGPBPDGKBH, byte[] LDNEPNAGEGN, int DEABOIPAFEI, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F770", Offset = "0x5D0EB70", VA = "0x185D0F770")]
	internal bool JLKIGMIANFK(HCKEBLBCIDF LAADNNJHANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E690", Offset = "0x5D0DA90", VA = "0x185D0E690")]
	public void HKOFOPFBJBM(byte[] LDNEPNAGEGN, int DEABOIPAFEI, int CHJNEOPKHME, GOFOCEGAFME ANGMLGCFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FDC0", Offset = "0x5D0F1C0", VA = "0x185D0FDC0")]
	private void NDIFDNMBJFG(byte[] LDNEPNAGEGN, int DEABOIPAFEI, int CHJNEOPKHME, byte MIMEEFAJLJF, GOFOCEGAFME NIDOEDMFKAG, object JJPBEPEALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D0FC10", Offset = "0x5D0F010", VA = "0x185D0FC10")]
	public void LKILKKBNNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F5E0", Offset = "0x5D0E9E0", VA = "0x185D0F5E0")]
	internal LPPHFDAOJCJ IMMFBHJEBAN(DKOAKLPCBMN LAADNNJHANL)
	{
		return default(LPPHFDAOJCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D3B0", Offset = "0x5D0C7B0", VA = "0x185D0D3B0")]
	internal void BPFABAPBHNE(OFAGDPNJGEB LFAAEDCCHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D410", Offset = "0x5D0C810", VA = "0x185D0D410")]
	internal AFFHNOOOEPP CFIMNKJBCKE(byte[] LDNEPNAGEGN, int DEABOIPAFEI, int CHJNEOPKHME, bool MCCPONPGBFK)
	{
		return default(AFFHNOOOEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D10D50", Offset = "0x5D10150", VA = "0x185D10D50")]
	private void OOOECIMFMHI(int FHLGBKIGKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EC10", Offset = "0x5D0E010", VA = "0x185D0EC10")]
	internal void HOFKOCGLLOG(GOFOCEGAFME BAGEENCOBFH, DKOAKLPCBMN MMNGAEPEJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E6C0", Offset = "0x5D0DAC0", VA = "0x185D0E6C0")]
	private void HLGNPGLNJEA(DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E130", Offset = "0x5D0D530", VA = "0x185D0E130")]
	private void EHHOGFLBMGO(int OBMBAKPLLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F7F0", Offset = "0x5D0EBF0", VA = "0x185D0F7F0")]
	internal IDGDHLPDDDA JPBIDJPOIPO(NNMJPEHKEPJ BHHJMKGKNBF)
	{
		return default(IDGDHLPDDDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D103E0", Offset = "0x5D0F7E0", VA = "0x185D103E0")]
	internal void OCMFKDNLIHL(DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E540", Offset = "0x5D0D940", VA = "0x185D0E540")]
	private void HAJLHFKKFDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D720", Offset = "0x5D0CB20", VA = "0x185D0D720")]
	internal void DGCOAFKLKHI(DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D930", Offset = "0x5D0CD30", VA = "0x185D0D930")]
	internal void DKKALNJCGIH(int OBMBAKPLLKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D10A90", Offset = "0x5D0FE90", VA = "0x185D10A90")]
	internal void OLHAJDBBCKL(DKOAKLPCBMN LAADNNJHANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DBJAOBOHLMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long MLOMLMMKIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long GOHEHGCNAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long LEOLLNCCMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long GCGEDDFGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HIMFKEACEED;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long CJFENJAJEOF;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long IBMJHJBDAMO;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long NBBAEMNFKJA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long MIJHFNKAMNM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long AFFKNODPPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long NCMECHNACHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long MALAFHMELBG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long MIKFPPFDKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B7F0", Offset = "0x5D0ABF0", VA = "0x185D0B7F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GJELFMAPOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B8F0", Offset = "0x5D0ACF0", VA = "0x185D0B8F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long DLJIKGFDEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BAB0", Offset = "0x5D0AEB0", VA = "0x185D0BAB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long KIPPHMFOOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B7E0", Offset = "0x5D0ABE0", VA = "0x185D0B7E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long HFEGDOAKFEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BAC0", Offset = "0x5D0AEC0", VA = "0x185D0BAC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LPBGPMKKOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B9D0", Offset = "0x5D0ADD0", VA = "0x185D0B9D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long MIAIODBMGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B700", Offset = "0x5D0AB00", VA = "0x185D0B700")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long OJJJCKPNKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B7A0", Offset = "0x5D0ABA0", VA = "0x185D0B7A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private LKIPDPDHAKL CPIPOHEEPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B8E0", Offset = "0x5D0ACE0", VA = "0x185D0B8E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double ECMOEKLDLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B740", Offset = "0x5D0AB40", VA = "0x185D0B740")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B800", Offset = "0x5D0AC00", VA = "0x185D0B800")]
	public void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B970", Offset = "0x5D0AD70", VA = "0x185D0B970")]
	public void LDDMMHBEINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B630", Offset = "0x5D0AA30", VA = "0x185D0B630")]
	public void ABICMHHEHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B900", Offset = "0x5D0AD00", VA = "0x185D0B900")]
	public void KPFAMKCDHFM(long PPMMCLIBLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BA40", Offset = "0x5D0AE40", VA = "0x185D0BA40")]
	public void OKJGFGOBJHA(long BFPFKFPCOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B9E0", Offset = "0x5D0ADE0", VA = "0x185D0B9E0")]
	public void LMMKKOMFJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B680", Offset = "0x5D0AA80", VA = "0x185D0B680")]
	public void ADNAKCCELIL(long GGCCEKLFDON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BAD0", Offset = "0x5D0AED0", VA = "0x185D0BAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B840", Offset = "0x5D0AC40", VA = "0x185D0B840")]
	public void GJKCDMPIBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public DBJAOBOHLMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LNAMLCJPCFI
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> EPBKOIKMIMH;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D143E0", Offset = "0x5D137E0", VA = "0x185D143E0")]
	public static IPEndPoint NHMLHEFFCFL(string KHINEAGCOBA, int HDOKGLCAPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D14180", Offset = "0x5D13580", VA = "0x185D14180")]
	public static IPAddress JKDLGNNJOCI(string KHINEAGCOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D14350", Offset = "0x5D13750", VA = "0x185D14350")]
	public static IPAddress JKDLGNNJOCI(string KHINEAGCOBA, AddressFamily JFDAKOJAPFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D14150", Offset = "0x5D13550", VA = "0x185D14150")]
	internal static int HAJBHJHDPNK(int BKEBOAPMCEL, int BOKHLHOAOCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C3E350", Offset = "0x2C3D750", VA = "0x182C3E350")]
	internal static T[] CEECDCBAHFC<T>(int MLMABEGDEJH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PNGGJIAPLIE : OFAGDPNJGEB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct LIFGNPJFGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private DKOAKLPCBMN DGPJKGFPCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long PFAFJCEEPAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool FDAEFMINFGM;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D13CB0", Offset = "0x5D130B0", VA = "0x185D13CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D13BD0", Offset = "0x5D12FD0", VA = "0x185D13BD0")]
		public void BGMBKGHFJON(DKOAKLPCBMN LAADNNJHANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D13C40", Offset = "0x5D13040", VA = "0x185D13C40")]
		public bool MBJMLONGPLE(long AAMNMBGKMBE, FPGEINFCCCA IOAKIFIGGBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D13BF0", Offset = "0x5D12FF0", VA = "0x185D13BF0")]
		public bool IHJLNMEMMCN(FPGEINFCCCA IOAKIFIGGBH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly DKOAKLPCBMN DKDIGCCGBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly LIFGNPJFGNH[] OMADCNEJBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly DKOAKLPCBMN[] BJAAJCFGGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] HJJBPDIDFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int GHMMGAHMHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int JDHFONKPHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int MOLHNDLLPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int EFEGDIKNNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool AHLCDENGIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly GOFOCEGAFME INFBGPJCDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool GJHLFOJNJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int LPGNBGADNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte JKNHPMBLKGB;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D190D0", Offset = "0x5D184D0", VA = "0x185D190D0")]
	public PNGGJIAPLIE(FPGEINFCCCA IOAKIFIGGBH, bool EIJLLMILANE, byte GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D18D30", Offset = "0x5D18130", VA = "0x185D18D30")]
	private void PEAAKPOBMMD(DKOAKLPCBMN LAADNNJHANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D18220", Offset = "0x5D17620", VA = "0x185D18220", Slot = "4")]
	protected override bool AKFGLFJEBAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D186D0", Offset = "0x5D17AD0", VA = "0x185D186D0", Slot = "5")]
	public override bool OCMFKDNLIHL(DKOAKLPCBMN LAADNNJHANL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CNOBLMBMFHI : OFAGDPNJGEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int BHOEDAPKLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort JDHFONKPHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool GGAPBICLJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private DKOAKLPCBMN PFBEFAAHPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly DKOAKLPCBMN JFCBIOEDIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool JKDPEHFIJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte JKNHPMBLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long MNACDJJPDNC;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B570", Offset = "0x5D0A970", VA = "0x185D0B570")]
	public CNOBLMBMFHI(FPGEINFCCCA IOAKIFIGGBH, bool DMMCDBHOMPA, byte GNBDDFJPEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5D0ADD0", Offset = "0x5D0A1D0", VA = "0x185D0ADD0", Slot = "4")]
	protected override bool AKFGLFJEBAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B290", Offset = "0x5D0A690", VA = "0x185D0B290", Slot = "5")]
	public override bool OCMFKDNLIHL(DKOAKLPCBMN LAADNNJHANL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AKNPIKPDKHP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct KHBGIOCMCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong FLNBGFPLFPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double NPEMCMNGIAI;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FDCLAINHHAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int JDDJEGFEMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float PAEODIAAMCJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D01EF0", Offset = "0x5D012F0", VA = "0x185D01EF0")]
	private static void BHKLCIJMBHD(byte[] OAAIHOHLDCK, int BILMLHHHLMM, ulong LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D02640", Offset = "0x5D01A40", VA = "0x185D02640")]
	private static void BHKLCIJMBHD(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D026B0", Offset = "0x5D01AB0", VA = "0x185D026B0")]
	public static void BHKLCIJMBHD(byte[] OAAIHOHLDCK, int BILMLHHHLMM, short LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D026F0", Offset = "0x5D01AF0", VA = "0x185D026F0")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, double OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D02720", Offset = "0x5D01B20", VA = "0x185D02720")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D026B0", Offset = "0x5D01AB0", VA = "0x185D026B0")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, short OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D026B0", Offset = "0x5D01AB0", VA = "0x185D026B0")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, ushort OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D02640", Offset = "0x5D01A40", VA = "0x185D02640")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D02640", Offset = "0x5D01A40", VA = "0x185D02640")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, uint OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5D02710", Offset = "0x5D01B10", VA = "0x185D02710")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, long OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5D02710", Offset = "0x5D01B10", VA = "0x185D02710")]
	public static void JDBIDKBEMHM(byte[] PLMCKIPFEOJ, int OCDCDAOIAHP, ulong OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GEMHGOCGBBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] BFJEEJKDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int AFEMHMGKLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int NCHDHNADKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int KGFGEDMOALA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] GKODDAMIDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int CBMNPKPILJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9874E0", Offset = "0x9868E0", VA = "0x1809874E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HIDNCNJPFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D11B60", Offset = "0x5D10F60", VA = "0x185D11B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PFIPOOJNKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1EF44A0", Offset = "0x1EF38A0", VA = "0x181EF44A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int EOLJKHOLPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5D11A40", Offset = "0x5D10E40", VA = "0x185D11A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D11EC0", Offset = "0x5D112C0", VA = "0x185D11EC0")]
	public void KEEIKHMBODP(byte[] LMADGEINEAF, int BILMLHHHLMM, int KOKFPHAMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public GEMHGOCGBBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D122F0", Offset = "0x5D116F0", VA = "0x185D122F0")]
	public GEMHGOCGBBK(byte[] LMADGEINEAF, int BILMLHHHLMM, int KOKFPHAMMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5D11A90", Offset = "0x5D10E90", VA = "0x185D11A90")]
	public IPEndPoint HAGGJKIHPLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5D11BD0", Offset = "0x5D10FD0", VA = "0x185D11BD0")]
	public byte IMKPFBBGJFE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D11BD0", Offset = "0x5D10FD0", VA = "0x185D11BD0")]
	public sbyte ODDHBDNDONN()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B5D500", Offset = "0x2B5C900", VA = "0x182B5D500")]
	public T[] GMOJPEGIOCJ<T>(ushort CGDIEJGGJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D11B70", Offset = "0x5D10F70", VA = "0x185D11B70")]
	public bool[] IAMBBGGHEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D120D0", Offset = "0x5D114D0", VA = "0x185D120D0")]
	public ushort[] NPEJPNKBLNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D11860", Offset = "0x5D10C60", VA = "0x185D11860")]
	public short[] CNIAHOPEKKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D11820", Offset = "0x5D10C20", VA = "0x185D11820")]
	public int[] CNCHKGKMLMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D11700", Offset = "0x5D10B00", VA = "0x185D11700")]
	public uint[] AMOCCPFNIMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D119C0", Offset = "0x5D10DC0", VA = "0x185D119C0")]
	public float[] FFNABCBFMAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D11A00", Offset = "0x5D10E00", VA = "0x185D11A00")]
	public double[] FHAJPLHGLGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D11FE0", Offset = "0x5D113E0", VA = "0x185D11FE0")]
	public long[] KKABAODBNLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D12110", Offset = "0x5D11510", VA = "0x185D12110")]
	public ulong[] OBPKEHPDFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D121C0", Offset = "0x5D115C0", VA = "0x185D121C0")]
	public string[] PCFCIKKENKN(int ELEIOFCFCJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D11910", Offset = "0x5D10D10", VA = "0x185D11910")]
	public bool DBCPCLDFCEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D117B0", Offset = "0x5D10BB0", VA = "0x185D117B0")]
	public char HOLHFHKMCOF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D117B0", Offset = "0x5D10BB0", VA = "0x185D117B0")]
	public ushort BHKIADMHEIH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D11950", Offset = "0x5D10D50", VA = "0x185D11950")]
	public short FCKJPALGFNH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D12150", Offset = "0x5D11550", VA = "0x185D12150")]
	public long OEKLIMFAOEJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D11740", Offset = "0x5D10B40", VA = "0x185D11740")]
	public ulong BFECNHNNEOG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D11C10", Offset = "0x5D11010", VA = "0x185D11C10")]
	public int IOMIBAJMAJG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D11F70", Offset = "0x5D11370", VA = "0x185D11F70")]
	public uint KGBMDKCKOLA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D12020", Offset = "0x5D11420", VA = "0x185D12020")]
	public float LAENCKPHAPC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D11F00", Offset = "0x5D11300", VA = "0x185D11F00")]
	public double KFBJNHKOEHG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D11C80", Offset = "0x5D11080", VA = "0x185D11C80")]
	public string JLIHLDGHIPJ(int AOMPLLKPDNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D118A0", Offset = "0x5D10CA0", VA = "0x185D118A0")]
	public ArraySegment<byte> COBFDLFBJHD(int MLMABEGDEJH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D12090", Offset = "0x5D11490", VA = "0x185D12090")]
	public sbyte[] LALBDIDJCPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D11A50", Offset = "0x5D10E50", VA = "0x185D11A50")]
	public byte[] GPOPBAIAKPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5D11BB0", Offset = "0x5D10FB0", VA = "0x185D11BB0")]
	public void IHJLNMEMMCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PCNCFLKAHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] BFJEEJKDNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int AFEMHMGKLPL;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int GPHACIANKIF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool PGKKCKKOICL;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding DLNAIHHHHAJ;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int ONBNNEBDPOH = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] MIGBCAIAPPI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GAMKDEPHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int LHAGCGMDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8517F0", Offset = "0x850BF0", VA = "0x1808517F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D181A0", Offset = "0x5D175A0", VA = "0x185D181A0")]
	public PCNCFLKAHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D18100", Offset = "0x5D17500", VA = "0x185D18100")]
	public PCNCFLKAHOI(bool DBAAOANMLGJ, int CICIFBIFCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5D173D0", Offset = "0x5D167D0", VA = "0x185D173D0")]
	public static PCNCFLKAHOI AKIEGMAEODJ(string OBEEJPGJPFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5D17970", Offset = "0x5D16D70", VA = "0x185D17970")]
	public void LIODHHAPHOC(int DNJIPLMCGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6DF20", Offset = "0x1F6D320", VA = "0x181F6DF20")]
	public void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5D17FD0", Offset = "0x5D173D0", VA = "0x185D17FD0")]
	public void OOFEDFELHLG(float OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5D17D60", Offset = "0x5D17160", VA = "0x185D17D60")]
	public void OOFEDFELHLG(double OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D17B70", Offset = "0x5D16F70", VA = "0x185D17B70")]
	public void OOFEDFELHLG(long OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D17B70", Offset = "0x5D16F70", VA = "0x185D17B70")]
	public void OOFEDFELHLG(ulong OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D17A10", Offset = "0x5D16E10", VA = "0x185D17A10")]
	public void OOFEDFELHLG(int OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D17A10", Offset = "0x5D16E10", VA = "0x185D17A10")]
	public void OOFEDFELHLG(uint OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C20", Offset = "0x5D17020", VA = "0x185D17C20")]
	public void OOFEDFELHLG(char OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C20", Offset = "0x5D17020", VA = "0x185D17C20")]
	public void OOFEDFELHLG(ushort OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C20", Offset = "0x5D17020", VA = "0x185D17C20")]
	public void OOFEDFELHLG(short OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5D17AA0", Offset = "0x5D16EA0", VA = "0x185D17AA0")]
	public void OOFEDFELHLG(sbyte OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D17AA0", Offset = "0x5D16EA0", VA = "0x185D17AA0")]
	public void OOFEDFELHLG(byte OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D17B00", Offset = "0x5D16F00", VA = "0x185D17B00")]
	public void OOFEDFELHLG(byte[] LDNEPNAGEGN, int BILMLHHHLMM, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D17440", Offset = "0x5D16840", VA = "0x185D17440")]
	public void EAPLLOEMMDL(sbyte[] LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D17440", Offset = "0x5D16840", VA = "0x185D17440")]
	public void NNAOEHODKIF(byte[] LDNEPNAGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D17BC0", Offset = "0x5D16FC0", VA = "0x185D17BC0")]
	public void OOFEDFELHLG(bool OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D17520", Offset = "0x5D16920", VA = "0x185D17520")]
	public void GCDFNEPMPDL(Array FGNPEDBIABE, int LAHLKDOHBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D17890", Offset = "0x5D16C90", VA = "0x185D17890")]
	public void GCDFNEPMPDL(float[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D17600", Offset = "0x5D16A00", VA = "0x185D17600")]
	public void GCDFNEPMPDL(double[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D17600", Offset = "0x5D16A00", VA = "0x185D17600")]
	public void GCDFNEPMPDL(long[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D17600", Offset = "0x5D16A00", VA = "0x185D17600")]
	public void GCDFNEPMPDL(ulong[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D17890", Offset = "0x5D16C90", VA = "0x185D17890")]
	public void GCDFNEPMPDL(int[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D17890", Offset = "0x5D16C90", VA = "0x185D17890")]
	public void GCDFNEPMPDL(uint[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D177B0", Offset = "0x5D16BB0", VA = "0x185D177B0")]
	public void GCDFNEPMPDL(ushort[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D177B0", Offset = "0x5D16BB0", VA = "0x185D177B0")]
	public void GCDFNEPMPDL(short[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D17440", Offset = "0x5D16840", VA = "0x185D17440")]
	public void GCDFNEPMPDL(bool[] OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D176E0", Offset = "0x5D16AE0", VA = "0x185D176E0")]
	public void GCDFNEPMPDL(string[] OBEEJPGJPFD, int GPMGBDOOILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C90", Offset = "0x5D17090", VA = "0x185D17C90")]
	public void OOFEDFELHLG(IPEndPoint MDGDCOHGNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5D17DB0", Offset = "0x5D171B0", VA = "0x185D17DB0")]
	public void OOFEDFELHLG(string OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D17DC0", Offset = "0x5D171C0", VA = "0x185D17DC0")]
	public void OOFEDFELHLG(string OBEEJPGJPFD, int AOMPLLKPDNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MODENHEAOAM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DLLOHAOAMIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong PIBGEMNFMPP;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x57A2B80", Offset = "0x57A1F80", VA = "0x1857A2B80")]
		static DLLOHAOAMIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void CEBJFMPPKOK(GEMHGOCGBBK CKPGDBBGEAK, object JJPBEPEALHF);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class ILDJBOICLNI<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public MODENHEAOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public ILDJBOICLNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E73420", Offset = "0x3E72820", VA = "0x183E73420")]
		internal void CFFJGKDCGBA(GEMHGOCGBBK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class NBJGBPAFLBK<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public MODENHEAOAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public NBJGBPAFLBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x44E60F0", Offset = "0x44E54F0", VA = "0x1844E60F0")]
		internal void CFFJGKDCGBA(GEMHGOCGBBK reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly BNDIDKINIBP NHNAFKOMGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, CEBJFMPPKOK> NDBEANJCACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly PCNCFLKAHOI JLJGABMJPLO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D16A60", Offset = "0x5D15E60", VA = "0x185D16A60")]
	public MODENHEAOAM(int ELEIOFCFCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x28E1090", Offset = "0x28E0490", VA = "0x1828E1090", Slot = "4")]
	protected virtual ulong LGDOPAGJNMB<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D168E0", Offset = "0x5D15CE0", VA = "0x185D168E0", Slot = "5")]
	protected virtual CEBJFMPPKOK IMBLGHIPOHB(GEMHGOCGBBK CKPGDBBGEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2C56DE0", Offset = "0x2C561E0", VA = "0x182C56DE0", Slot = "6")]
	protected virtual void CEGIEBNHOEB<T>(PCNCFLKAHOI CCOPEDCAMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D16860", Offset = "0x5D15C60", VA = "0x185D16860")]
	public void IBGKEFOPEOF(GEMHGOCGBBK CKPGDBBGEAK, object JJPBEPEALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C571D0", Offset = "0x2C565D0", VA = "0x182C571D0")]
	public void LLPOKIINHBD<T>(PCNCFLKAHOI CCOPEDCAMKJ, T LAADNNJHANL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5D16A10", Offset = "0x5D15E10", VA = "0x185D16A10")]
	public void NHFAOOCADNC(GEMHGOCGBBK CKPGDBBGEAK, object JJPBEPEALHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2C57010", Offset = "0x2C56410", VA = "0x182C57010")]
	public void CKDOEPLHCCH<T>(Action<T> FNOBJFJBBNN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2C56E50", Offset = "0x2C56250", VA = "0x182C56E50")]
	public void CKDOEPLHCCH<T, TUserData>(Action<T, TUserData> FNOBJFJBBNN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PMOGPNCNDLL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5D12EE0", Offset = "0x5D122E0", VA = "0x185D12EE0")]
	public PMOGPNCNDLL(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class OKFOELPCANL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D17370", Offset = "0x5D16770", VA = "0x185D17370")]
	public OKFOELPCANL(string PBDOHNMILPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BNDIDKINIBP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum AFPNOIIHNNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BPDAHCGPNDC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AFPNOIIHNNP CJOIENFDBCH;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF8F0", Offset = "0x4EAECF0", VA = "0x184EAF8F0", Slot = "4")]
		public virtual void BGMBKGHFJON(MethodInfo AGHIJICOPNJ, MethodInfo LPAAECOBNCO, AFPNOIIHNNP EPPKBKJHHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FGFCGLKHFPP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LCMDOFALODM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		protected BPDAHCGPNDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class FMIALMHMMCM<TClass, TProperty> : BPDAHCGPNDC<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> GLMBKLLLKLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> APNHHIFCNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> DHOJCJLDAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> ALMMJAFDEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> DKENIOLJLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> GOJJOBFFJCH;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F7C0", Offset = "0x3C2EBC0", VA = "0x183C2F7C0", Slot = "7")]
		public override void HCPBNPDMOHO(TClass EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C31230", Offset = "0x3C30630", VA = "0x183C31230", Slot = "8")]
		public override void MNNPIMCHMKM(TClass EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E800", Offset = "0x3C2DC00", VA = "0x183C2E800", Slot = "9")]
		public override void FGFCGLKHFPP(TClass EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C30430", Offset = "0x3C2F830", VA = "0x183C30430", Slot = "10")]
		public override void LCMDOFALODM(TClass EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C2FDE0", Offset = "0x3C2F1E0", VA = "0x183C2FDE0")]
		protected TProperty[] IGLJDPCPFDP(TClass EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C315B0", Offset = "0x3C309B0", VA = "0x183C315B0")]
		protected TProperty[] OCLHBCIAADO(TClass EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C2BA20", Offset = "0x3C2AE20", VA = "0x183C2BA20", Slot = "4")]
		public override void BGMBKGHFJON(MethodInfo AGHIJICOPNJ, MethodInfo LPAAECOBNCO, AFPNOIIHNNP EPPKBKJHHHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C09570", Offset = "0x3C08970", VA = "0x183C09570")]
		protected FMIALMHMMCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class IIDFKMDLGHG<TClass, TProperty> : FMIALMHMMCM<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void IHEDAFPKJDI(GEMHGOCGBBK LONPDOIHFKH, [Out] TProperty OOODMGDHKDD);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void DFDPDCMPEKB(PCNCFLKAHOI GBJEKHMFAAD, TProperty OOODMGDHKDD);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DCC0", Offset = "0x3E4D0C0", VA = "0x183E4DCC0", Slot = "5")]
		public override void KLMIKLLHGOP(TClass EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DD60", Offset = "0x3E4D160", VA = "0x183E4DD60", Slot = "6")]
		public override void LLPOKIINHBD(TClass EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DB60", Offset = "0x3E4CF60", VA = "0x183E4DB60", Slot = "7")]
		public override void HCPBNPDMOHO(TClass EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DE60", Offset = "0x3E4D260", VA = "0x183E4DE60", Slot = "8")]
		public override void MNNPIMCHMKM(TClass EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3E4DFE0", Offset = "0x3E4D3E0", VA = "0x183E4DFE0")]
		protected IIDFKMDLGHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class HLGNEKFPKIK<T> : FMIALMHMMCM<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C840", Offset = "0x3D8BC40", VA = "0x183D8C840", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3D28700", Offset = "0x3D27B00", VA = "0x183D28700", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C7C0", Offset = "0x3D8BBC0", VA = "0x183D8C7C0", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3D28770", Offset = "0x3D27B70", VA = "0x183D28770", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public HLGNEKFPKIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class GONHGJOMFON<T> : FMIALMHMMCM<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3D28680", Offset = "0x3D27A80", VA = "0x183D28680", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3D28700", Offset = "0x3D27B00", VA = "0x183D28700", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3D28600", Offset = "0x3D27A00", VA = "0x183D28600", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3D28770", Offset = "0x3D27B70", VA = "0x183D28770", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public GONHGJOMFON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KCBICHIGBIH<T> : FMIALMHMMCM<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4120D10", Offset = "0x4120110", VA = "0x184120D10", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4120D90", Offset = "0x4120190", VA = "0x184120D90", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4120C90", Offset = "0x4120090", VA = "0x184120C90", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4120E00", Offset = "0x4120200", VA = "0x184120E00", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public KCBICHIGBIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class BBHJEOHNCJH<T> : FMIALMHMMCM<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4E84500", Offset = "0x4E83900", VA = "0x184E84500", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4120D90", Offset = "0x4120190", VA = "0x184120D90", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4E84480", Offset = "0x4E83880", VA = "0x184E84480", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4120E00", Offset = "0x4120200", VA = "0x184120E00", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public BBHJEOHNCJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class CALAAPEDBIM<T> : FMIALMHMMCM<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F160", Offset = "0x4F3E560", VA = "0x184F3F160", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x44284D0", Offset = "0x44278D0", VA = "0x1844284D0", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F0E0", Offset = "0x4F3E4E0", VA = "0x184F3F0E0", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4428540", Offset = "0x4427940", VA = "0x184428540", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public CALAAPEDBIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class MCDIDHGCKPK<T> : FMIALMHMMCM<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4428450", Offset = "0x4427850", VA = "0x184428450", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44284D0", Offset = "0x44278D0", VA = "0x1844284D0", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44283D0", Offset = "0x44277D0", VA = "0x1844283D0", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4428540", Offset = "0x4427940", VA = "0x184428540", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public MCDIDHGCKPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CKADGAHJJBJ<T> : FMIALMHMMCM<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E7D0", Offset = "0x4E9DBD0", VA = "0x184E9E7D0", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E850", Offset = "0x4E9DC50", VA = "0x184E9E850", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5037540", Offset = "0x5036940", VA = "0x185037540", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x442ADE0", Offset = "0x442A1E0", VA = "0x18442ADE0", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public CKADGAHJJBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class BKDKDFJHABN<T> : FMIALMHMMCM<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E7D0", Offset = "0x4E9DBD0", VA = "0x184E9E7D0", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E850", Offset = "0x4E9DC50", VA = "0x184E9E850", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E750", Offset = "0x4E9DB50", VA = "0x184E9E750", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x442ADE0", Offset = "0x442A1E0", VA = "0x18442ADE0", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public BKDKDFJHABN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BJMNIGMDKKB<T> : FMIALMHMMCM<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E400", Offset = "0x4E9D800", VA = "0x184E9E400", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E480", Offset = "0x4E9D880", VA = "0x184E9E480", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E380", Offset = "0x4E9D780", VA = "0x184E9E380", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D28770", Offset = "0x3D27B70", VA = "0x183D28770", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public BJMNIGMDKKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DEMAMHOBNGN<T> : FMIALMHMMCM<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5788950", Offset = "0x5787D50", VA = "0x185788950", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x57889D0", Offset = "0x5787DD0", VA = "0x1857889D0", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x57888D0", Offset = "0x5787CD0", VA = "0x1857888D0", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4428540", Offset = "0x4427940", VA = "0x184428540", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public DEMAMHOBNGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MCPHNJHDPPC<T> : FMIALMHMMCM<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x442ACF0", Offset = "0x442A0F0", VA = "0x18442ACF0", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x442AD70", Offset = "0x442A170", VA = "0x18442AD70", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x442AC70", Offset = "0x442A070", VA = "0x18442AC70", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x442ADE0", Offset = "0x442A1E0", VA = "0x18442ADE0", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D184D0", Offset = "0x3D178D0", VA = "0x183D184D0")]
		public MCPHNJHDPPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KDJMDABCEII<T> : IIDFKMDLGHG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x417B010", Offset = "0x417A410", VA = "0x18417B010", Slot = "12")]
		protected override void DFDPDCMPEKB(PCNCFLKAHOI GBJEKHMFAAD, char OOODMGDHKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x417B040", Offset = "0x417A440", VA = "0x18417B040", Slot = "11")]
		protected override void IHEDAFPKJDI(GEMHGOCGBBK LONPDOIHFKH, [Out] char OOODMGDHKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		public KDJMDABCEII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class GKDPODKAHJJ<T> : IIDFKMDLGHG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D19890", Offset = "0x3D18C90", VA = "0x183D19890", Slot = "12")]
		protected override void DFDPDCMPEKB(PCNCFLKAHOI GBJEKHMFAAD, IPEndPoint OOODMGDHKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D198C0", Offset = "0x3D18CC0", VA = "0x183D198C0", Slot = "11")]
		protected override void IHEDAFPKJDI(GEMHGOCGBBK LONPDOIHFKH, [Out] IPEndPoint OOODMGDHKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D19900", Offset = "0x3D18D00", VA = "0x183D19900")]
		public GKDPODKAHJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BKAKFFACJPC<T> : FMIALMHMMCM<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int BDCLCOMANMK;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E6F0", Offset = "0x4E9DAF0", VA = "0x184E9E6F0")]
		public BKAKFFACJPC(int AOMPLLKPDNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E570", Offset = "0x4E9D970", VA = "0x184E9E570", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E5F0", Offset = "0x4E9D9F0", VA = "0x184E9E5F0", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E4F0", Offset = "0x4E9D8F0", VA = "0x184E9E4F0", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4E9E670", Offset = "0x4E9DA70", VA = "0x184E9E670", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BHBBFEAIDIF<T> : BPDAHCGPNDC<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo PLHCOPFFLKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type MEJNBBOBBGP;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E95A50", Offset = "0x4E94E50", VA = "0x184E95A50")]
		public BHBBFEAIDIF(PropertyInfo GEGAKMCPGBL, Type HILGJLMAGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E95820", Offset = "0x4E94C20", VA = "0x184E95820", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4E95940", Offset = "0x4E94D40", VA = "0x184E95940", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4E957C0", Offset = "0x4E94BC0", VA = "0x184E957C0", Slot = "7")]
		public override void HCPBNPDMOHO(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4E959F0", Offset = "0x4E94DF0", VA = "0x184E959F0", Slot = "8")]
		public override void MNNPIMCHMKM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4E95760", Offset = "0x4E94B60", VA = "0x184E95760", Slot = "9")]
		public override void FGFCGLKHFPP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E958E0", Offset = "0x4E94CE0", VA = "0x184E958E0", Slot = "10")]
		public override void LCMDOFALODM(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BNBJGMMGNMJ<T> : BHBBFEAIDIF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C14210", Offset = "0x3C13610", VA = "0x183C14210")]
		public BNBJGMMGNMJ(PropertyInfo GEGAKMCPGBL, Type HILGJLMAGFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3EF0", Offset = "0x4EA32F0", VA = "0x184EA3EF0", Slot = "5")]
		public override void KLMIKLLHGOP(T EEOPLIFEJNO, GEMHGOCGBBK LONPDOIHFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3FB0", Offset = "0x4EA33B0", VA = "0x184EA3FB0", Slot = "6")]
		public override void LLPOKIINHBD(T EEOPLIFEJNO, PCNCFLKAHOI GBJEKHMFAAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class DGMACOHHKBK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static DGMACOHHKBK<T> CLHFPJDPLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly BPDAHCGPNDC<T>[] MBDFCNCFOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int NDGLGKOHDIC;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x578BB10", Offset = "0x578AF10", VA = "0x18578BB10")]
		public DGMACOHHKBK(List<BPDAHCGPNDC<T>> NFPLFICDCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x578BA60", Offset = "0x578AE60", VA = "0x18578BA60")]
		public void LLPOKIINHBD(T LALIGKIKEBM, PCNCFLKAHOI CCOPEDCAMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x578B9B0", Offset = "0x578ADB0", VA = "0x18578B9B0")]
		public void KLMIKLLHGOP(T LALIGKIKEBM, GEMHGOCGBBK CKPGDBBGEAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class DLGKLHFDPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BPDAHCGPNDC<T> PJLOLBBNKPI<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private PCNCFLKAHOI JPJOMHFPIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int MMMHHOMKNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, DLGKLHFDPIC> JMJJEHFEMEA;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D027A0", Offset = "0x5D01BA0", VA = "0x185D027A0")]
	public BNDIDKINIBP(int ELEIOFCFCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28F5CF0", Offset = "0x28F50F0", VA = "0x1828F5CF0")]
	private DGMACOHHKBK<T> EMPBALFEMEM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28F6F50", Offset = "0x28F6350", VA = "0x1828F6F50")]
	public void NLGJOIAOEAN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x28F6E20", Offset = "0x28F6220", VA = "0x1828F6E20")]
	public bool JLCLGLEKPEG<T>(GEMHGOCGBBK CKPGDBBGEAK, T KMCPIOGEAKL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x28F6EC0", Offset = "0x28F62C0", VA = "0x1828F6EC0")]
	public void KPIBKDOHBCB<T>(PCNCFLKAHOI CCOPEDCAMKJ, T LALIGKIKEBM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CLEFHPCOHPH
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime DMFINBHHJPO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] IGDJKEEINCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LMDCJFJFEOK ENAOIGJIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D09D10", Offset = "0x5D09110", VA = "0x185D09D10")]
		get
		{
			return default(LMDCJFJFEOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PCDHJAIPDBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D09CE0", Offset = "0x5D090E0", VA = "0x185D09CE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D09CA0", Offset = "0x5D090A0", VA = "0x185D09CA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public KKGHONGOPCE JFNMPEKEIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D09A40", Offset = "0x5D08E40", VA = "0x185D09A40")]
		get
		{
			return default(KKGHONGOPCE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A960", Offset = "0x5D09D60", VA = "0x185D0A960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DLPNBHBHNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A7F0", Offset = "0x5D09BF0", VA = "0x185D0A7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint CGLFCLMOEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A820", Offset = "0x5D09C20", VA = "0x185D0A820")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? BBCLCAEENNI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A090", Offset = "0x5D09490", VA = "0x185D0A090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? GDCJJHAAMKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A8A0", Offset = "0x5D09CA0", VA = "0x185D0A8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? MNMMPAEDNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D09C70", Offset = "0x5D09070", VA = "0x185D09C70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A450", Offset = "0x5D09850", VA = "0x185D0A450")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? KHMECIJFGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xD2CB60", Offset = "0xD2BF60", VA = "0x180D2CB60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xB538D0", Offset = "0xB52CD0", VA = "0x180B538D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AA00", Offset = "0x5D09E00", VA = "0x185D0AA00")]
	public CLEFHPCOHPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AD20", Offset = "0x5D0A120", VA = "0x185D0AD20")]
	internal CLEFHPCOHPH(byte[] PLMCKIPFEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D09F10", Offset = "0x5D09310", VA = "0x185D09F10")]
	public static CLEFHPCOHPH HMJCKOBFJDD(byte[] PLMCKIPFEOJ, DateTime JACFFMMCCFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A250", Offset = "0x5D09650", VA = "0x185D0A250")]
	internal void MMIHMICKNGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A620", Offset = "0x5D09A20", VA = "0x185D0A620")]
	private void NECEHLHPAOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D09A70", Offset = "0x5D08E70", VA = "0x185D09A70")]
	private DateTime? CFNDMCILAMF(int BILMLHHHLMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D09D40", Offset = "0x5D09140", VA = "0x185D09D40")]
	private void HLGBIJLBNIH(int BILMLHHHLMM, DateTime? OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A0C0", Offset = "0x5D094C0", VA = "0x185D0A0C0")]
	private ulong KPFCMCLJGPF(int BILMLHHHLMM)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A190", Offset = "0x5D09590", VA = "0x185D0A190")]
	private void MAKIMLEOGMC(int BILMLHHHLMM, ulong OBEEJPGJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A8D0", Offset = "0x5D09CD0", VA = "0x185D0A8D0")]
	private uint OIJGMOEFCEF(int BILMLHHHLMM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5BD6730", Offset = "0x5BD5B30", VA = "0x185BD6730")]
	private static uint IBDJJOMAECI(uint PCHHOKEGOFA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A030", Offset = "0x5D09430", VA = "0x185D0A030")]
	private static ulong IBDJJOMAECI(ulong PCHHOKEGOFA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum LMDCJFJFEOK
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
public enum KKGHONGOPCE
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class OAKMGMCPAHB
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int AMHGDBNFCND = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int HBMEKIFJJOA = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int DAKPEBCCIDM = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint PHJJNIJAIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int DJMELAAIDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int PBPHBPIPGLH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PDCHLCOCHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D170B0", Offset = "0x5D164B0", VA = "0x185D170B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D170C0", Offset = "0x5D164C0", VA = "0x185D170C0")]
	public bool HKOFOPFBJBM(LIGLJHDIDHF CIDLNIABKGF, int DMLNLLKJOKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class MGAGPHBABNI : LIGLJHDIDHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket CIDLNIABKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly CLADPEJAMAE DKPAEGMCHDL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short IILNPCIDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D16040", Offset = "0x5D15440", VA = "0x185D16040", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NKPIDDNFLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5D16060", Offset = "0x5D15460", VA = "0x185D16060", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint JNAGDFKPJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5D16770", Offset = "0x5D15B70", VA = "0x185D16770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily DEGICKCGFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4203080", Offset = "0x4202480", VA = "0x184203080", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D167B0", Offset = "0x5D15BB0", VA = "0x185D167B0")]
	public MGAGPHBABNI(AddressFamily JFDAKOJAPFC, CLADPEJAMAE DKPAEGMCHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D16080", Offset = "0x5D15480", VA = "0x185D16080", Slot = "8")]
	public bool FMKMKHDNLCO(IPEndPoint MDGDCOHGNED, MGOOFMLBDFI HLAKJLKPAJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D16640", Offset = "0x5D15A40", VA = "0x185D16640", Slot = "9")]
	public int KHNPANJAHKE(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int CGDIEJGGJMK, IPEndPoint NINOEBFNAIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D16680", Offset = "0x5D15A80", VA = "0x185D16680", Slot = "10")]
	public int MJMJFFMLNIO(byte[] OAAIHOHLDCK, EndPoint HMACLAJJPHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D16790", Offset = "0x5D15B90", VA = "0x185D16790", Slot = "11")]
	public void PHAAJGEPJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface LIGLJHDIDHF
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short IILNPCIDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int NKPIDDNFLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint JNAGDFKPJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily DEGICKCGFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FMKMKHDNLCO(IPEndPoint MDGDCOHGNED, MGOOFMLBDFI HLAKJLKPAJL);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KHNPANJAHKE(byte[] OAAIHOHLDCK, int BILMLHHHLMM, int CGDIEJGGJMK, IPEndPoint NINOEBFNAIG);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MJMJFFMLNIO(byte[] OAAIHOHLDCK, EndPoint NINOEBFNAIG);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PHAAJGEPJHI();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct MEPKDJPOFKD : IEquatable<MEPKDJPOFKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long EADIFKJFFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long EKIMLGJDBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long KJMIEDNPDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int HGDAGFCCKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int OGFPFBKFJKG;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5D15F50", Offset = "0x5D15350", VA = "0x185D15F50")]
	public MEPKDJPOFKD(byte[] MNFLPNCDDMI, int OKDJDFHCIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x873980", Offset = "0x872D80", VA = "0x180873980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5D15E60", Offset = "0x5D15260", VA = "0x185D15E60", Slot = "4")]
	public bool Equals(MEPKDJPOFKD IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5D15EA0", Offset = "0x5D152A0", VA = "0x185D15EA0", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AEBNJPLPHGH : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] HIMHCKNONJB;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class KMHDKIABKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int FHALBLCLMGI;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
	protected KMHDKIABKLD(int MJPKNFGKFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IFMMMMLMJCE(IPEndPoint MDGDCOHGNED, byte[] LDNEPNAGEGN, int BILMLHHHLMM, int CHJNEOPKHME);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DILOOGKMIDE(IPEndPoint MDGDCOHGNED, byte[] LDNEPNAGEGN, int BILMLHHHLMM, int CHJNEOPKHME);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DMILMFGECIK : KMHDKIABKLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] PEDCMDADFIN;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator BHDIGDMOPKA;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x200D1E0", Offset = "0x200C5E0", VA = "0x18200D1E0")]
	public DMILMFGECIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CC00", Offset = "0x5D0C000", VA = "0x185D0CC00")]
	public void HCDMNEJEKJH(IPEndPoint MDGDCOHGNED, byte[] PEDCMDADFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D260", Offset = "0x5D0C660", VA = "0x185D0D260")]
	public void KKKAECAJCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CDB0", Offset = "0x5D0C1B0", VA = "0x185D0CDB0", Slot = "4")]
	public override void IFMMMMLMJCE(IPEndPoint MDGDCOHGNED, byte[] LDNEPNAGEGN, int BILMLHHHLMM, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C890", Offset = "0x5D0BC90", VA = "0x185D0C890", Slot = "5")]
	public override void DILOOGKMIDE(IPEndPoint MDGDCOHGNED, byte[] LDNEPNAGEGN, int BILMLHHHLMM, int CHJNEOPKHME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct GJJKAFHBLLE
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void BJPNKFIBGPM([NoAlias] byte* DCMOCJIGADE, [NoAlias] byte* PEDCMDADFIN, [NoAlias] byte* ILODLALOLND, int CHJNEOPKHME);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class PKIFNAFAOPH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr FKCEPGGMODK;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr FHDDFOCEMOB;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D19500", Offset = "0x5D18900", VA = "0x185D19500")]
		[BurstDiscard]
		private static void IBGIIDELBOH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5D193A0", Offset = "0x5D187A0", VA = "0x185D193A0")]
		private static IntPtr HMFLDKIJPMF()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5D19870", Offset = "0x5D18C70", VA = "0x185D19870")]
		public static void PPALEDONJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
		public static void MGIGIPLLEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5D19630", Offset = "0x5D18A30", VA = "0x185D19630")]
		public unsafe static void KGLFFAEFCMK([NoAlias] byte* DCMOCJIGADE, [NoAlias] byte* PEDCMDADFIN, [NoAlias] byte* ILODLALOLND, int CHJNEOPKHME)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint PEDCMDADFIN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint ILODLALOLND[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint GOPCEJFCHLF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint MJNOCKCCINJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint CCLOCDPDLFH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint ANIKLKMMALF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint LIGFEHGFHKM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint KNPFNMFLEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint KBANEAHCGBA[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D123F0", Offset = "0x5D117F0", VA = "0x185D123F0")]
	private void FCLPPFCBMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5D12350", Offset = "0x5D11750", VA = "0x185D12350")]
	private uint DJJKLICGGPA(uint LMJDILMPEPB, int NMOAEJIJOGK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5D01FE0", Offset = "0x5D013E0", VA = "0x185D01FE0")]
	private void CLJEOIEBJDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5D02090", Offset = "0x5D01490", VA = "0x185D02090")]
	private void FEKKCALBLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5D022A0", Offset = "0x5D016A0", VA = "0x185D022A0")]
	private void MEAHIGLMJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5D02330", Offset = "0x5D01730", VA = "0x185D02330")]
	private void MGELNNDHFGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5D12470", Offset = "0x5D11870", VA = "0x185D12470")]
	private void FJEKDHCEEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5D12630", Offset = "0x5D11A30", VA = "0x185D12630")]
	private unsafe void HLLEBMKKOCN(byte* DCMOCJIGADE, uint* PEDCMDADFIN, uint* ILODLALOLND, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5D125B0", Offset = "0x5D119B0", VA = "0x185D125B0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void GPEPJCGNEHO([NoAlias] byte* DCMOCJIGADE, [NoAlias] byte* PEDCMDADFIN, [NoAlias] byte* ILODLALOLND, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5D124D0", Offset = "0x5D118D0", VA = "0x185D124D0")]
	public static void GPEPJCGNEHO(Span<byte> DCMOCJIGADE, Span<byte> PEDCMDADFIN, Span<byte> ILODLALOLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5D12A50", Offset = "0x5D11E50", VA = "0x185D12A50")]
	public static void JCJPPNHFGLG(Span<byte> DCMOCJIGADE, Span<byte> PEDCMDADFIN, Span<byte> ILODLALOLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5D12380", Offset = "0x5D11780", VA = "0x185D12380")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void EMOJNCGPEPG([NoAlias] byte* DCMOCJIGADE, [NoAlias] byte* PEDCMDADFIN, [NoAlias] byte* ILODLALOLND, int CHJNEOPKHME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5D19920", Offset = "0x5D18D20", VA = "0x185D19920")]
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
