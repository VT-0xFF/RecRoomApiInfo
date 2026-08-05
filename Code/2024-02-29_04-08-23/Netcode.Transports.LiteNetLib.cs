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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, AGEJCHJLAIA
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum BOOJAAGEPNA
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
		private NetworkManager LOOOKBBGJGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, IDBCAHNGOJD> GAENIHFIILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KAAHPFEGNNI ADNOPJMMEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] HMKFHAHOAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BOOJAAGEPNA HMEJJOMAHMO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong OCAEMNACDLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool HPIOKMNGKJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x549DB70", Offset = "0x549C970", VA = "0x18549DB70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x549D070", Offset = "0x549BE70", VA = "0x18549D070")]
		public void RecRoom_SetEncryptionInfo(ulong KLNKNCGHOPA, byte[] JCMGBFKGKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x549D050", Offset = "0x549BE50", VA = "0x18549D050")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x549CE60", Offset = "0x549BC60", VA = "0x18549CE60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x549DA70", Offset = "0x549C870", VA = "0x18549DA70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x549D270", Offset = "0x549C070", VA = "0x18549D270", Slot = "6")]
		public override void Send(ulong OEADNCMGLNB, ArraySegment<byte> OMHIFBJFAGA, NetworkDelivery IEODGLGACKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x549D010", Offset = "0x549BE10", VA = "0x18549D010", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong OEADNCMGLNB, [Out] ArraySegment<byte> FCMJAHOHNCO, [Out] float LCDKONDFMFD)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x549D560", Offset = "0x549C360", VA = "0x18549D560", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x549D990", Offset = "0x549C790", VA = "0x18549D990", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x549C720", Offset = "0x549B520", VA = "0x18549C720", Slot = "10")]
		public override void DisconnectRemoteClient(ulong OEADNCMGLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x549C5D0", Offset = "0x549B3D0", VA = "0x18549C5D0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x549C9C0", Offset = "0x549B7C0", VA = "0x18549C9C0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong OEADNCMGLNB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x549D4F0", Offset = "0x549C2F0", VA = "0x18549D4F0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x549CA60", Offset = "0x549B860", VA = "0x18549CA60", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LOOOKBBGJGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x549C890", Offset = "0x549B690", VA = "0x18549C890")]
		private LMCNFEONNPI EIBHMPDJKNB(NetworkDelivery HFFNCGFKMBJ)
		{
			return default(LMCNFEONNPI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x549CF50", Offset = "0x549BD50", VA = "0x18549CF50", Slot = "15")]
		private void PIKCILEPNCH(IDBCAHNGOJD DMNOEGJPEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x549CD00", Offset = "0x549BB00", VA = "0x18549CD00", Slot = "16")]
		private void MJCFMIDGMIB(IDBCAHNGOJD DMNOEGJPEJB, OMPLPOIGHGC BOLCMEOLBIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "17")]
		private void FKGKMIPGEHK(IPEndPoint EMNEFEFNGKP, SocketError GGCMONANBGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x549C3C0", Offset = "0x549B1C0", VA = "0x18549C3C0", Slot = "18")]
		private void BAGBEBGFOJI(IDBCAHNGOJD DMNOEGJPEJB, MLEFOPGMJBA FECOEFBKMHD, byte HEOKACECEKH, LMCNFEONNPI MNINFEPJNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x549CC20", Offset = "0x549BA20", VA = "0x18549CC20")]
		private void KCPPNPOHDNG(int DDGPJFNNFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "19")]
		private void DPEFFFEOPJH(IPEndPoint LABACEAPCEH, MLEFOPGMJBA FECOEFBKMHD, BPNFLGFPFEE GHJLJIDKADO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "20")]
		private void LKIOJJHPFEN(IDBCAHNGOJD DMNOEGJPEJB, int FPJDDCBLFAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x549C960", Offset = "0x549B760", VA = "0x18549C960", Slot = "21")]
		private void EICNENCHNPO(KFHKOBNLECB MIMLCIHLPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x549C390", Offset = "0x549B190", VA = "0x18549C390")]
		private ulong ALGKEGJFMPO(IDBCAHNGOJD DMNOEGJPEJB)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x549CE40", Offset = "0x549BC40", VA = "0x18549CE40")]
		private static int NDHKCCEILDP(float JDMCAOCKBDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x549DA90", Offset = "0x549C890", VA = "0x18549DA90")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class JKHANEEEPOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly IDBCAHNGOJD OCJJGNFFANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<NIHOHFLKDLK> KNCKAMAOEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HDEKKLMOIOG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x54936E0", Offset = "0x54924E0", VA = "0x1854936E0")]
	protected JKHANEEEPOA(IDBCAHNGOJD DMNOEGJPEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5493680", Offset = "0x5492480", VA = "0x185493680")]
	public void PFAMALOGPJI(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5493600", Offset = "0x5492400", VA = "0x185493600")]
	protected void NIIKEEPOBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x54935C0", Offset = "0x54923C0", VA = "0x1854935C0")]
	public bool KKPBEBFACJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool HKDMCNJILKL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LCDGNFEALEI(NIHOHFLKDLK PIKEFGBMHFN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum FCBHPNHENBG
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
public class KFHKOBNLECB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KAAHPFEGNNI MLJIIJOCKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int AAOJCFIEAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EDPDCLJFHOE HJNILGMHAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint DGBCIADLIKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal FCBHPNHENBG PKHEOGNPMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D1590", Offset = "0x7D0390", VA = "0x1807D1590")]
		[CompilerGenerated]
		get
		{
			return default(FCBHPNHENBG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDE0", Offset = "0x8CABE0", VA = "0x1808CBDE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x549AB70", Offset = "0x5499970", VA = "0x18549AB70")]
	internal void IANHDGDDDJO(EDPDCLJFHOE KOIGCMBBEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x549ABD0", Offset = "0x54999D0", VA = "0x18549ABD0")]
	private bool KBEPBONAJJH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x549AC60", Offset = "0x5499A60", VA = "0x18549AC60")]
	internal KFHKOBNLECB(IPEndPoint LABACEAPCEH, EDPDCLJFHOE FNPBIECBDNN, KAAHPFEGNNI HICJEGPANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x549AC00", Offset = "0x5499A00", VA = "0x18549AC00")]
	public IDBCAHNGOJD MAGGNEEMCIK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum BPNFLGFPFEE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DJODEMIPGII
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
public struct OMPLPOIGHGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DJODEMIPGII AFLKDJLCICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError GBGNLAMNCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MLEFOPGMJBA EHCDGBMICNO;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AGEJCHJLAIA
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFPHOJFPLPG(IDBCAHNGOJD DMNOEGJPEJB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIOIFKFKFPG(IDBCAHNGOJD DMNOEGJPEJB, OMPLPOIGHGC BOLCMEOLBIO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MICFGEBDDMB(IPEndPoint EMNEFEFNGKP, SocketError GGCMONANBGG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMLJHPPFFHJ(IDBCAHNGOJD DMNOEGJPEJB, MLEFOPGMJBA FECOEFBKMHD, byte HEOKACECEKH, LMCNFEONNPI MNINFEPJNAL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JBDDOBKKBJA(IPEndPoint LABACEAPCEH, MLEFOPGMJBA FECOEFBKMHD, BPNFLGFPFEE GHJLJIDKADO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LJDKJILIJCO(IDBCAHNGOJD DMNOEGJPEJB, int FPJDDCBLFAO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJMFEBHECGH(KFHKOBNLECB MIMLCIHLPAB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JPNGCGIAING
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBHDHANEPJO(IDBCAHNGOJD DMNOEGJPEJB, object PHFNNADJJGH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JCHHLLADLJF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMLJMIPMFIN(DICGFKJDBLM PIKEFGBMHFN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KEENDJCBJBA
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AALKBOBLDIC(IDBCAHNGOJD DMNOEGJPEJB, IPEndPoint IPMCPHKPOHA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class EDPDCLJFHOE
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NNJLMCOCEMA = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long BOKJCHDCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte FIJAJJOPINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] GDGDGDEPJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NFDMAHAPLAN GHKHBJDIPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int CEPHJANCPPN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x548E170", Offset = "0x548CF70", VA = "0x18548E170")]
	private EDPDCLJFHOE(long GFOJCMDMPKI, byte BLALDIPFMHG, int IOGJGBJCGKK, byte[] FIIPAJIALPI, NFDMAHAPLAN OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x548DF30", Offset = "0x548CD30", VA = "0x18548DF30")]
	public static int GDFMFOPELBL(NIHOHFLKDLK PIKEFGBMHFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x548DD10", Offset = "0x548CB10", VA = "0x18548DD10")]
	public static EDPDCLJFHOE AKANOBPEEKA(NIHOHFLKDLK PIKEFGBMHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x548DF90", Offset = "0x548CD90", VA = "0x18548DF90")]
	public static NIHOHFLKDLK LKODFLFCHJF(KMBHBOADCDH CMHNINJFKPO, SocketAddress KNHHGINJAKJ, long FBMLDAFFECI, int IOGJGBJCGKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class NBHEHLONEJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long BOKJCHDCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte FIJAJJOPINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int CEPHJANCPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool BAFGFELJKKE;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x549F050", Offset = "0x549DE50", VA = "0x18549F050")]
	private NBHEHLONEJF(long GFOJCMDMPKI, byte BLALDIPFMHG, int OHEDCNJEHFA, bool LFHOOKPPNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x549ED10", Offset = "0x549DB10", VA = "0x18549ED10")]
	public static NBHEHLONEJF AKANOBPEEKA(NIHOHFLKDLK PIKEFGBMHFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x549EF60", Offset = "0x549DD60", VA = "0x18549EF60")]
	public static NIHOHFLKDLK LKODFLFCHJF(long FBMLDAFFECI, byte DONCGHLEOMN, int PPKGLFFOGEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x549EE60", Offset = "0x549DC60", VA = "0x18549EE60")]
	public static NIHOHFLKDLK BFLPJDDFIJO(IDBCAHNGOJD DMNOEGJPEJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DEPKLFHGIFM
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AJLOEINHJMM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPCCBINHACL(IPEndPoint CCOMFEFBBND, IPEndPoint LABACEAPCEH, string NBGOKNOECBH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKLEGHKHEDA(IPEndPoint NHINALNHABN, DEPKLFHGIFM HFFNCGFKMBJ, string NBGOKNOECBH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class BNCGHJFHEGN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OAEHOGJCCPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint HFADMFMKKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint DGBCIADLIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string LDAEPLDKKFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct NMGJMNLBOJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint LFCNOMCIAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DEPKLFHGIFM KKPIOFNDDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string LDAEPLDKKFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class CKPMPHJDCBL
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint IGLAFOJNBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LDAEPLDKKFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CKPMPHJDCBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class LDFACMKEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint IGLAFOJNBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint GMOGNGBDOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LDAEPLDKKFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public LDFACMKEJMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class JKGJHJOMFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LDAEPLDKKFP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HGAKLOEBGIF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x822960", Offset = "0x821760", VA = "0x180822960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3330", Offset = "0x7B2130", VA = "0x1807B3330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JKGJHJOMFKJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KAAHPFEGNNI EGPPBEJBMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OAEHOGJCCPC> IIGGDBAMGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<NMGJMNLBOJF> BMPPOBEGKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NFDMAHAPLAN KCGANMIEHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KMBHBOADCDH KAKEBIJONFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JMADCFGNFKG LFIMMBDJLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private AJLOEINHJMM OPMECBEMBFI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int DDLNKKADMKO = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool JEEHICNEAPF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x548C220", Offset = "0x548B020", VA = "0x18548C220")]
	internal BNCGHJFHEGN(KAAHPFEGNNI OHEEICIOAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x548BDD0", Offset = "0x548ABD0", VA = "0x18548BDD0")]
	internal void AIKJNGIPIOF(IPEndPoint EACBFNOFPKF, NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24EAE40", Offset = "0x24E9C40", VA = "0x1824EAE40")]
	private void KDALOMEDGDM<T>(T PIKEFGBMHFN, IPEndPoint KAKJJOAALHM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x548BF30", Offset = "0x548AD30", VA = "0x18548BF30")]
	private void IPCCBINHACL(CKPMPHJDCBL KNOFDAINCJF, IPEndPoint EACBFNOFPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x548C0C0", Offset = "0x548AEC0", VA = "0x18548C0C0")]
	private void JNKNFNCCHOC(LDFACMKEJMN KNOFDAINCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x548BC30", Offset = "0x548AA30", VA = "0x18548BC30")]
	private void AFNCIELKFIA(JKGJHJOMFKJ KNOFDAINCJF, IPEndPoint EACBFNOFPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum LMCNFEONNPI : byte
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
public enum FEKKDBCHNIL : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CPAADKPNINI
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] PAGOLENEABC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int PJPILOACILM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int PEEGNJBLICI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LCONMDOOMLJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x548C7F0", Offset = "0x548B5F0", VA = "0x18548C7F0")]
	public LCONMDOOMLJ(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CBJDCEFOEDI : LCONMDOOMLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x548C7F0", Offset = "0x548B5F0", VA = "0x18548C7F0")]
	public CBJDCEFOEDI(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MGJEHCAINBN
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
public interface GFOMHDKDFJH
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHFBKPFJJKB(MGJEHCAINBN ODBAJNFEEBO, string BFHMEKKAMJH, params object[] BBFBHKMAMKC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HKNNDAHNFOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static GFOMHDKDFJH MAHPHOKDIDJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object OONKMKJFKMF;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x548E4A0", Offset = "0x548D2A0", VA = "0x18548E4A0")]
	private static void PDJJKDLBBKF(MGJEHCAINBN KIKDCJMFNDF, string BFHMEKKAMJH, params object[] BBFBHKMAMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x548E3E0", Offset = "0x548D1E0", VA = "0x18548E3E0")]
	internal static void EANKBANNFBN(string BFHMEKKAMJH, params object[] BBFBHKMAMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x548E380", Offset = "0x548D180", VA = "0x18548E380")]
	internal static void ANDEEDFMLMF(string BFHMEKKAMJH, params object[] BBFBHKMAMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x548E440", Offset = "0x548D240", VA = "0x18548E440")]
	internal static void JMPKEJGDBHF(string BFHMEKKAMJH, params object[] BBFBHKMAMKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LOOCEJCDDLN
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MLEFOPGMJBA : NFDMAHAPLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NIHOHFLKDLK ENPPLOKIPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KAAHPFEGNNI NBKLCDBNHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KCALLJHJPMP PFBFAFMKHDG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x549DD20", Offset = "0x549CB20", VA = "0x18549DD20")]
	internal MLEFOPGMJBA(KAAHPFEGNNI IEHBMNBOFCL, KCALLJHJPMP PGDDKLDNGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x549DC30", Offset = "0x549CA30", VA = "0x18549DC30")]
	internal void NMCHPBAJJJD(NIHOHFLKDLK PIKEFGBMHFN, int KHJMDLLONIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x549DCA0", Offset = "0x549CAA0", VA = "0x18549DCA0")]
	internal void OGFHMPIIPIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x549DC00", Offset = "0x549CA00", VA = "0x18549DC00")]
	public void IBBOHHAFPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KCALLJHJPMP
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum EPBCBCCLOJK
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
	public KCALLJHJPMP HPALBOJMJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public EPBCBCCLOJK KKPIOFNDDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public IDBCAHNGOJD OCJJGNFFANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint DGBCIADLIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object HHIAFBMIPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int IECNJOGJLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError LMKPBEKBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public DJODEMIPGII ONLGCNGKMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public KFHKOBNLECB JNMLGHGNCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public LMCNFEONNPI BJOIKMMIDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte JALPJGPJMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly MLEFOPGMJBA MLADKAIGPPJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x549AAD0", Offset = "0x54998D0", VA = "0x18549AAD0")]
	public KCALLJHJPMP(KAAHPFEGNNI IEHBMNBOFCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KAAHPFEGNNI : IEnumerable<IDBCAHNGOJD>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class MDDDPDMJJGO : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x549DB90", Offset = "0x549C990", VA = "0x18549DB90", Slot = "4")]
		public bool Equals(IPEndPoint AHPBAINPGNA, IPEndPoint KMGCEBLELOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B530", Offset = "0x4F5A330", VA = "0x184F5B530", Slot = "5")]
		public int GetHashCode(IPEndPoint NHLNHJGAONN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public MDDDPDMJJGO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct DNFLGJKDHFK : IEnumerator<IDBCAHNGOJD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly IDBCAHNGOJD KANPMJGNCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private IDBCAHNGOJD FINAAKMNIKI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IDBCAHNGOJD ODMJFPGIBHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x898230", Offset = "0x897030", VA = "0x180898230", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x898230", Offset = "0x897030", VA = "0x180898230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xECE960", Offset = "0xECD760", VA = "0x180ECE960")]
		public DNFLGJKDHFK(IDBCAHNGOJD KADGOLMMJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x548DC70", Offset = "0x548CA70", VA = "0x18548DC70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x548DCC0", Offset = "0x548CAC0", VA = "0x18548DCC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread HBOEFGNJDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool IDGPBBAFDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent LEBOLLIBPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KCALLJHJPMP> PPIKHBPLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KCALLJHJPMP> HHBHPBOFAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private KCALLJHJPMP JHDNFFIDHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AGEJCHJLAIA LFMKEJMMOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly JPNGCGIAING DCJKGCHOLFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly JCHHLLADLJF MAOFJBOIJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KEENDJCBJBA BGOHIPLHPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, IDBCAHNGOJD> ANMLLACDDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, KFHKOBNLECB> AICAANPGAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, EPCMFILDHDM> NNPJGCHLBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim AIKPELPHOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IDBCAHNGOJD DLIEFGAGPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int INFLKFFGGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<IDBCAHNGOJD> JOLHBFPDNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private IDBCAHNGOJD[] AGNMGDELEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly OKLOCIEBHHJ PBAEAIKJBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int CAECLMGLDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> LCFKBBLHDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte EEKMFOFFJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object BBKFBHIBKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool HCENLDIPNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool LPCBCJDKHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int IMKDGHIJDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MMIIEKMPGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int CNOKLFIDEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int HADCPDCICGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool ICLIBKPIHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool IGGFFGLDEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CCGMMHNJHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BBOHCKDJIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int JBDDOENODIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool JEEHICNEAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool KJBEJEJKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HGJDOICNDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KBNMPFHNFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NNKHPMFEDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int AGDAKDLFFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool ADNHJKJJCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly JBOFCHHMIEI CICBLNBPDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool JPJMLDNCJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly BNCGHJFHEGN ACLGAFLAPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool HKIIBFCEIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LOOCEJCDDLN CHKODHJMNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int HJILINOHMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GILHPBDELEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool AMBKPAFILHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GLGDJDBMHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool DFMFBHKPNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NIHOHFLKDLK MMJECHDFNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int OCFNJPIOHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object PPFGCODMCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NIHOHFLKDLK MCNFMPNGKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int KGBKIOPENEN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int KONFCFMAJMG = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int BABLFBNHDIJ = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JLELFCFHMNE ONPEJCFLCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private JLELFCFHMNE FJLBDJNJMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DICIDGGNPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NNLJNPIJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint JMFPOLBGBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint OOECIFMDNKK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] ENPBPKFGACL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] FCKBHFHDHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<MMIBPIBICLE, IPEndPoint> NGGJOGOGFPK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress NLMOLCBCDGA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool FNNMMNEGKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GDPABGAOMML;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DMGODNIOIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF970", Offset = "0x9EE770", VA = "0x1809EF970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA7CB00", Offset = "0xA7B900", VA = "0x180A7CB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HFPBBMHMFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1575E70", Offset = "0x1574C70", VA = "0x181575E70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1575660", Offset = "0x1574460", VA = "0x181575660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PLOGJACPBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8597B0", Offset = "0x8585B0", VA = "0x1808597B0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LNDPOCECMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5495940", Offset = "0x5494740", VA = "0x185495940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short FIIGPDGFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5493B00", Offset = "0x5492900", VA = "0x185493B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x54958A0", Offset = "0x54946A0", VA = "0x1854958A0")]
	public void DHIDPPCOHED(IPEndPoint EMNEFEFNGKP, byte[] JCMGBFKGKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x54940F0", Offset = "0x5492EF0", VA = "0x1854940F0")]
	public void BFGHNDECPBD(IPEndPoint EMNEFEFNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5495960", Offset = "0x5494760", VA = "0x185495960")]
	private bool EDENLILILCE(IPEndPoint EMNEFEFNGKP, [Out] IDBCAHNGOJD DMNOEGJPEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5499400", Offset = "0x5498200", VA = "0x185499400")]
	private void OKNJONKOHIM(IDBCAHNGOJD DMNOEGJPEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5494470", Offset = "0x5493270", VA = "0x185494470")]
	private void BOPACHNDBJJ(IDBCAHNGOJD DMNOEGJPEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5498290", Offset = "0x5497090", VA = "0x185498290")]
	private void MLADNLGEMFH(IDBCAHNGOJD DMNOEGJPEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x549A480", Offset = "0x5499280", VA = "0x18549A480")]
	public KAAHPFEGNNI(AGEJCHJLAIA HICJEGPANEK, [Optional] OKLOCIEBHHJ KECHFNMBCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54969C0", Offset = "0x54957C0", VA = "0x1854969C0")]
	internal void HDLFLIOCLCB(IDBCAHNGOJD HIMPGABGNLC, int FPJDDCBLFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5497720", Offset = "0x5496520", VA = "0x185497720")]
	internal void JGCNMCCKCEJ(IDBCAHNGOJD HIMPGABGNLC, object PHFNNADJJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5494020", Offset = "0x5492E20", VA = "0x185494020")]
	internal void BAELHANKLPP(IDBCAHNGOJD DMNOEGJPEJB, DJODEMIPGII IIMECKHJEHG, SocketError OCJNHAJPOPK, NIHOHFLKDLK BBMDMLIDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x54952D0", Offset = "0x54940D0", VA = "0x1854952D0")]
	private void CMHFBCFPPND(IDBCAHNGOJD DMNOEGJPEJB, DJODEMIPGII IIMECKHJEHG, SocketError OCJNHAJPOPK, bool KCOHBBNEOFL, byte[] OMHIFBJFAGA, int IFADIJDFJBM, int BPFMGMBDOBA, NIHOHFLKDLK BBMDMLIDKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5499CC0", Offset = "0x5498AC0", VA = "0x185499CC0")]
	private void PMHIJACEGON(KCALLJHJPMP.EPBCBCCLOJK HFFNCGFKMBJ, [Optional] IDBCAHNGOJD DMNOEGJPEJB, [Optional] IPEndPoint LABACEAPCEH, SocketError KIPCEGJGNGF = SocketError.Success, int FPJDDCBLFAO = 0, DJODEMIPGII DLMKAJBODKI = DJODEMIPGII.ConnectionFailed, [Optional] KFHKOBNLECB PMGKIHCDKLL, LMCNFEONNPI MNINFEPJNAL = LMCNFEONNPI.Unreliable, byte HEOKACECEKH = 0, [Optional] NIHOHFLKDLK DDAJPKGPEMD, [Optional] object PHFNNADJJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5495D10", Offset = "0x5494B10", VA = "0x185495D10")]
	private void FFPFGHAHMNL(KCALLJHJPMP PGDDKLDNGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5497060", Offset = "0x5495E60", VA = "0x185497060")]
	internal void IIIFFIMKOIB(KCALLJHJPMP PGDDKLDNGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x54973E0", Offset = "0x54961E0", VA = "0x1854973E0")]
	private void JCNGJIDPLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x54959F0", Offset = "0x54947F0", VA = "0x1854959F0")]
	private void FDCCKAOMMEB(int NLEPJGLGNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5498DE0", Offset = "0x5497BE0", VA = "0x185498DE0")]
	internal IDBCAHNGOJD OGDMCGFKBIO(KFHKOBNLECB MIMLCIHLPAB, byte[] LEOJDEJMOIE, int IFADIJDFJBM, int FAPCCJLFBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5497940", Offset = "0x5496740", VA = "0x185497940")]
	private int KAPHIFOACNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5493BC0", Offset = "0x54929C0", VA = "0x185493BC0")]
	private void ALIKCACKJBJ(IPEndPoint LABACEAPCEH, IDBCAHNGOJD JNKOGBFOBEN, EDPDCLJFHOE COIFHMJFNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x54944C0", Offset = "0x54932C0", VA = "0x1854944C0")]
	private void CLFKMLLKNMI(NIHOHFLKDLK PIKEFGBMHFN, IPEndPoint LABACEAPCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5496DA0", Offset = "0x5495BA0", VA = "0x185496DA0")]
	internal void IEPFKKAANOO(NIHOHFLKDLK PIKEFGBMHFN, LMCNFEONNPI NLCJLEOLBHL, byte HEOKACECEKH, int KHJMDLLONIJ, IDBCAHNGOJD HIMPGABGNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x54979C0", Offset = "0x54967C0", VA = "0x1854979C0")]
	public bool KJBAIGHFNON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5498210", Offset = "0x5497010", VA = "0x185498210")]
	public bool KJBAIGHFNON(IPAddress KAGCKIGGAAK, IPAddress PMJEPBCILLL, int FAMNEKFAODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5498190", Offset = "0x5496F90", VA = "0x185498190")]
	public bool KJBAIGHFNON(int FAMNEKFAODD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5496730", Offset = "0x5495530", VA = "0x185496730")]
	public void GHEMMJDJLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x54988C0", Offset = "0x54976C0", VA = "0x1854988C0")]
	public IDBCAHNGOJD MLPNGEDMEKA(string EHNFDGMHPMM, int FAMNEKFAODD, string JCMGBFKGKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x54989A0", Offset = "0x54977A0", VA = "0x1854989A0")]
	public IDBCAHNGOJD MLPNGEDMEKA(string EHNFDGMHPMM, int FAMNEKFAODD, KMBHBOADCDH HJLCHGNFOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x54984F0", Offset = "0x54972F0", VA = "0x1854984F0")]
	public IDBCAHNGOJD MLPNGEDMEKA(IPEndPoint KAKJJOAALHM, KMBHBOADCDH HJLCHGNFOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5498DD0", Offset = "0x5497BD0", VA = "0x185498DD0")]
	public void MMCMCIPEMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5498A80", Offset = "0x5497880", VA = "0x185498A80")]
	public void MMCMCIPEMLI(bool JFLPHOMPGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x549A080", Offset = "0x5498E80", VA = "0x18549A080")]
	public void PNLDFHKBNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x549A180", Offset = "0x5498F80", VA = "0x18549A180")]
	public void PNLDFHKBNPE(byte[] OMHIFBJFAGA, int IFADIJDFJBM, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x54953B0", Offset = "0x54941B0", VA = "0x1854953B0")]
	public void CMHFBCFPPND(IDBCAHNGOJD DMNOEGJPEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5495210", Offset = "0x5494010", VA = "0x185495210")]
	public void CMHFBCFPPND(IDBCAHNGOJD DMNOEGJPEJB, byte[] OMHIFBJFAGA, int IFADIJDFJBM, int BPFMGMBDOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x549A2A0", Offset = "0x54990A0", VA = "0x18549A2A0", Slot = "4")]
	private IEnumerator<IDBCAHNGOJD> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x549A330", Offset = "0x5499130", VA = "0x18549A330", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5497850", Offset = "0x5496650", VA = "0x185497850")]
	private NIHOHFLKDLK JGNPLCJKCGJ(NHPMGDOOOCG EDANCLIIPKG, int DDGPJFNNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5497770", Offset = "0x5496570", VA = "0x185497770")]
	private NIHOHFLKDLK JGNPLCJKCGJ(NHPMGDOOOCG EDANCLIIPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5494240", Offset = "0x5493040", VA = "0x185494240")]
	internal NIHOHFLKDLK BFKPEHJFGBA(int DDGPJFNNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x54964D0", Offset = "0x54952D0", VA = "0x1854964D0")]
	internal void FJBAKMAGBAP(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x549A3C0", Offset = "0x54991C0", VA = "0x18549A3C0")]
	static KAAHPFEGNNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9EF970", Offset = "0x9EE770", VA = "0x1809EF970")]
	private bool FNOLGJBGBBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x54968D0", Offset = "0x54956D0", VA = "0x1854968D0")]
	private void GJGHHKEBBJM(IPEndPoint FGPIIEFFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5497300", Offset = "0x5496100", VA = "0x185497300")]
	private void JBJCFHIKPLH(IPEndPoint FGPIIEFFOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5497160", Offset = "0x5495F60", VA = "0x185497160")]
	private bool IMNFCHLBCID(SocketException PIJHOBKPGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5495460", Offset = "0x5494260", VA = "0x185495460")]
	private void CMMMNDDAOHB(JLELFCFHMNE OHEEICIOAAG, EndPoint IBDDEJBBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5496A10", Offset = "0x5495810", VA = "0x185496A10")]
	private void HGFKLIKKGJL(object DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x54979D0", Offset = "0x54967D0", VA = "0x1854979D0")]
	public bool KJBAIGHFNON(IPAddress KAGCKIGGAAK, IPAddress PMJEPBCILLL, int FAMNEKFAODD, bool IBFHFKDEDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5498230", Offset = "0x5497030", VA = "0x185498230")]
	internal int KKPBAMNPMKE(NIHOHFLKDLK PIKEFGBMHFN, IPEndPoint LABACEAPCEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5499C80", Offset = "0x5498A80", VA = "0x185499C80")]
	internal int PHGMKPJOOLP(NIHOHFLKDLK PIKEFGBMHFN, IPEndPoint LABACEAPCEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x54996C0", Offset = "0x54984C0", VA = "0x1854996C0")]
	internal int PHGMKPJOOLP(byte[] EMKENBOOEOH, int IFADIJDFJBM, int FAPCCJLFBAA, IPEndPoint LABACEAPCEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5495730", Offset = "0x5494530", VA = "0x185495730")]
	internal void CPDKHOGCDFE(bool OAIKKBLDNEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum NHPMGDOOOCG : byte
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
internal sealed class NIHOHFLKDLK
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int MHBPCLJHJJD;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] BCNNKKEEPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] FOLFAIELIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int MLMGACONFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object HHIAFBMIPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NIHOHFLKDLK HPALBOJMJAD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NHPMGDOOOCG APCMECOMLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x54A0F60", Offset = "0x549FD60", VA = "0x1854A0F60")]
		get
		{
			return default(NHPMGDOOOCG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x54A1060", Offset = "0x549FE60", VA = "0x1854A1060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte FIJAJJOPINB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x54A11A0", Offset = "0x549FFA0", VA = "0x1854A11A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x54A1100", Offset = "0x549FF00", VA = "0x1854A1100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort DNIKDDCNMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x54A1140", Offset = "0x549FF40", VA = "0x1854A1140")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x54A1370", Offset = "0x54A0170", VA = "0x1854A1370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PELEDGIFCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x54A1310", Offset = "0x54A0110", VA = "0x1854A1310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte AMDFLMKGEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x54A1340", Offset = "0x54A0140", VA = "0x1854A1340")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x54A0ED0", Offset = "0x549FCD0", VA = "0x1854A0ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CLIKCBHAIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x54A0F00", Offset = "0x549FD00", VA = "0x1854A0F00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x54A11D0", Offset = "0x549FFD0", VA = "0x1854A11D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort EDJEKGEAGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x54A1000", Offset = "0x549FE00", VA = "0x1854A1000")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x54A0FC0", Offset = "0x549FDC0", VA = "0x1854A0FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort MBBAKIJFJJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x54A10A0", Offset = "0x549FEA0", VA = "0x1854A10A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x54A0D90", Offset = "0x549FB90", VA = "0x1854A0D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x54A13B0", Offset = "0x54A01B0", VA = "0x1854A13B0")]
	static NIHOHFLKDLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x54A0F90", Offset = "0x549FD90", VA = "0x1854A0F90")]
	public void GKFJFNPNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x54A17A0", Offset = "0x54A05A0", VA = "0x1854A17A0")]
	public NIHOHFLKDLK(int DDGPJFNNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x54A1690", Offset = "0x54A0490", VA = "0x1854A1690")]
	public NIHOHFLKDLK(NHPMGDOOOCG EDANCLIIPKG, int DDGPJFNNFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x54A12A0", Offset = "0x54A00A0", VA = "0x1854A12A0")]
	public static int MILFMKNLHJN(NHPMGDOOOCG EDANCLIIPKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x54A1210", Offset = "0x54A0010", VA = "0x1854A1210")]
	public int MILFMKNLHJN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x54A0DD0", Offset = "0x549FBD0", VA = "0x1854A0DD0")]
	public bool CCCBJDGELAA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum BHHBLAFNHHA : byte
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
internal enum KJINBFGMMDK
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
internal enum LFBKOCBFOEM
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum EAJMLJANLJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IDBCAHNGOJD
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GKHLBMHAMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NIHOHFLKDLK[] FJJNGKKNEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int AFJMAPINJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int KAEIJHHEILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte AMDFLMKGEKI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public GKHLBMHAMKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void LDAIAFNDFAA(ulong KHFIDEEECLA, int NGJOPEBMKHF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int FBIPHGEPJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int MMCJPCEFAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int NPONNMBBINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FGMCEMHKHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int KPFBEOPANAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int IIAONDGKABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int JNJONPFDCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch KJLDPMECJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int LJHGOOEIPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long EPILKPBOEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object MLMKMHIBNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal IDBCAHNGOJD HBHJPIBNPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal IDBCAHNGOJD NDFPIEFEPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<NIHOHFLKDLK> OCKEPOFGAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<JKHANEEEPOA> MMJCBNKNNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly JKHANEEEPOA[] EBABINADKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int IJHLPJBGEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int OGPCBEDBMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool KKKPPHKFHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int DECJLKAGDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int HAOCJKMPBLE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CBJPLOPNNPI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int MJPCPOCDCPO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object BBENJOFHNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int MEPKMJPKMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GKHLBMHAMKC> OGGDBAFMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CGNLMDALIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NIHOHFLKDLK EKGEECEFPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int ACPMJALLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int ODGAMDOEPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint KJFLNJDOEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int HICCCGIGHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int ACGDKBMEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long ACDDMFDIGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte FGCLOGCNGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private BHHBLAFNHHA JFIMPAMPMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NIHOHFLKDLK PKBKFFADBEK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int GMMFJALFEKF = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int OEHALIKLMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly NIHOHFLKDLK ACAAFGJAHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly NIHOHFLKDLK IEDHHFHNBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly NIHOHFLKDLK JLKBHAEPNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly NIHOHFLKDLK DKIJGMDFOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private FEKKDBCHNIL FNCDJCHPFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly KAAHPFEGNNI LAEBACNDEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int FFDOGOLOLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object GPOOOOGHCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly JBOFCHHMIEI CICBLNBPDOJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte FFAGOPOOGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA17B00", Offset = "0xA16900", VA = "0x180A17B00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x54904A0", Offset = "0x548F2A0", VA = "0x1854904A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint HFLEMJBIBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7FEDD0", Offset = "0x7FDBD0", VA = "0x1807FEDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BHHBLAFNHHA POGFKDCNIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x15919D0", Offset = "0x15907D0", VA = "0x1815919D0")]
		get
		{
			return default(BHHBLAFNHHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long HIGBDLNHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6A0", Offset = "0x7AE4A0", VA = "0x1807AF6A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PDDANIPAMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xADB9D0", Offset = "0xADA7D0", VA = "0x180ADB9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x13CC300", Offset = "0x13CB100", VA = "0x1813CC300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DIBNMFGNPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5490B00", Offset = "0x548F900", VA = "0x185490B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NGNFDMAHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B91C0", Offset = "0x7B7FC0", VA = "0x1807B91C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double CLNAPCJFGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x17A2FB0", Offset = "0x17A1DB0", VA = "0x1817A2FB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LDAIAFNDFAA LIMIABOBGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5491F50", Offset = "0x5490D50", VA = "0x185491F50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x548EFF0", Offset = "0x548DDF0", VA = "0x18548EFF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5492370", Offset = "0x5491170", VA = "0x185492370")]
	internal IDBCAHNGOJD(KAAHPFEGNNI CKCLPBCNAHO, IPEndPoint LABACEAPCEH, int DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5491CF0", Offset = "0x5490AF0", VA = "0x185491CF0")]
	internal void NNFGMBGFMAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x548EC00", Offset = "0x548DA00", VA = "0x18548EC00")]
	internal void BAOOEDEMEHJ(IPEndPoint ALNNKDPFPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5490B40", Offset = "0x548F940", VA = "0x185490B40")]
	internal void KEKJELDDJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5491C20", Offset = "0x5490A20", VA = "0x185491C20")]
	private void MHOFDDNJHEA(int MAHFLBFENGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x548EFB0", Offset = "0x548DDB0", VA = "0x18548EFB0")]
	private void DHGLCGLCMOH(int ADGBCDFPEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5491D10", Offset = "0x5490B10", VA = "0x185491D10")]
	private JKHANEEEPOA OBJHHCOIKPJ(byte PKGDCCCLANB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x54921E0", Offset = "0x5490FE0", VA = "0x1854921E0")]
	internal IDBCAHNGOJD(KAAHPFEGNNI CKCLPBCNAHO, IPEndPoint LABACEAPCEH, int DGIBOINMLED, byte DONCGHLEOMN, KMBHBOADCDH CMHNINJFKPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5492000", Offset = "0x5490E00", VA = "0x185492000")]
	internal IDBCAHNGOJD(KAAHPFEGNNI CKCLPBCNAHO, KFHKOBNLECB MIMLCIHLPAB, int DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5491F00", Offset = "0x5490D00", VA = "0x185491F00")]
	internal void PCCPOAABHPL(EDPDCLJFHOE ELLOIDBEOEL, byte[] OMHIFBJFAGA, int IFADIJDFJBM, int FAPCCJLFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x548F3B0", Offset = "0x548E1B0", VA = "0x18548F3B0")]
	internal bool GCNOEJBCBOH(NBHEHLONEJF PIKEFGBMHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5490B10", Offset = "0x548F910", VA = "0x185490B10")]
	public void KDALOMEDGDM(byte[] OMHIFBJFAGA, int IFADIJDFJBM, int FAPCCJLFBAA, LMCNFEONNPI BAPOGPMCDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x548F430", Offset = "0x548E230", VA = "0x18548F430")]
	private void HHBJFAIFPDM(byte[] OMHIFBJFAGA, int IFADIJDFJBM, int FAPCCJLFBAA, byte HEOKACECEKH, LMCNFEONNPI MNINFEPJNAL, object PHFNNADJJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x548F980", Offset = "0x548E780", VA = "0x18548F980")]
	public void IIKJAMKHBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x54903C0", Offset = "0x548F1C0", VA = "0x1854903C0")]
	internal LFBKOCBFOEM JECMGAAPGPG(NIHOHFLKDLK PIKEFGBMHFN)
	{
		return default(LFBKOCBFOEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5490550", Offset = "0x548F350", VA = "0x185490550")]
	internal void JPJIMIMILFD(JKHANEEEPOA KOHECKJDOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x548F0A0", Offset = "0x548DEA0", VA = "0x18548F0A0")]
	internal EAJMLJANLJJ ENOKKABCJNI(byte[] OMHIFBJFAGA, int IFADIJDFJBM, int FAPCCJLFBAA, bool KCOHBBNEOFL)
	{
		return default(EAJMLJANLJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5491EC0", Offset = "0x5490CC0", VA = "0x185491EC0")]
	private void OODBAPKHOLJ(int ECFCHABGIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x548FA30", Offset = "0x548E830", VA = "0x18548FA30")]
	internal void JCINEGEALDI(LMCNFEONNPI NLCJLEOLBHL, NIHOHFLKDLK KADGOLMMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x54905B0", Offset = "0x548F3B0", VA = "0x1854905B0")]
	private void KAGCAPLCLOO(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x548EC30", Offset = "0x548DA30", VA = "0x18548EC30")]
	private void CMOKJGOLIKN(int KNBDFHCBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x548EA40", Offset = "0x548D840", VA = "0x18548EA40")]
	internal KJINBFGMMDK ALIKCACKJBJ(EDPDCLJFHOE COIFHMJFNFD)
	{
		return default(KJINBFGMMDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5490BD0", Offset = "0x548F9D0", VA = "0x185490BD0")]
	internal void LCDGNFEALEI(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5491280", Offset = "0x5490080", VA = "0x185491280")]
	private void LDCAFCDPHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5491A50", Offset = "0x5490850", VA = "0x185491A50")]
	internal void MDLCKMFFBGE(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x54913A0", Offset = "0x54901A0", VA = "0x1854913A0")]
	internal void LLIADGIKINC(int KNBDFHCBHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x548E780", Offset = "0x548D580", VA = "0x18548E780")]
	internal void AECIOGNPOPK(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JBOFCHHMIEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PKDAIGMAHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long OBBFFCIPLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long OIJMFFPHHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HBMDCCCKOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long MCNDIJKOCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long FONPJCHFGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long MEBJOIMOIJC;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long HAKBLAMCBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x54927D0", Offset = "0x54915D0", VA = "0x1854927D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LOMHOCHKGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5492A50", Offset = "0x5491850", VA = "0x185492A50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BPNHOAGBFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x54929C0", Offset = "0x54917C0", VA = "0x1854929C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long OFODJLIPLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x54929E0", Offset = "0x54917E0", VA = "0x1854929E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long FKJBKGBGPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x54928B0", Offset = "0x54916B0", VA = "0x1854928B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long NHNFGKIODKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x54929D0", Offset = "0x54917D0", VA = "0x1854929D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private FEKKDBCHNIL NBLDDCOKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x19FFE10", Offset = "0x19FEC10", VA = "0x1819FFE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double MAPCHKENOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x54927E0", Offset = "0x54915E0", VA = "0x1854927E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x54929F0", Offset = "0x54917F0", VA = "0x1854929F0")]
	public void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5492870", Offset = "0x5491670", VA = "0x185492870")]
	public void FJJCCCNHNPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54928A0", Offset = "0x54916A0", VA = "0x1854928A0")]
	public void GDIFLABJMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x54929A0", Offset = "0x54917A0", VA = "0x1854929A0")]
	public void KFLOJLJGGAF(long LIBBPFFIDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x54929B0", Offset = "0x54917B0", VA = "0x1854929B0")]
	public void LDJENIIILJO(long JKJPBACJJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5492840", Offset = "0x5491640", VA = "0x185492840")]
	public void FFNMOBIFNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x54928C0", Offset = "0x54916C0", VA = "0x1854928C0")]
	public void IOHHAHOJDDL(long GCEIHENPOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5492A60", Offset = "0x5491860", VA = "0x185492A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5492900", Offset = "0x5491700", VA = "0x185492900")]
	public void JDEPAKKMLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public JBOFCHHMIEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class ADEDNNMIDEB
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> JHKCLNPJOIO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x548B950", Offset = "0x548A750", VA = "0x18548B950")]
	public static IPEndPoint FGEIANEHOAF(string DCOKJNFPNNN, int FAMNEKFAODD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x548B750", Offset = "0x548A550", VA = "0x18548B750")]
	public static IPAddress CGIFBMOGLCL(string DCOKJNFPNNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x548B6C0", Offset = "0x548A4C0", VA = "0x18548B6C0")]
	public static IPAddress CGIFBMOGLCL(string DCOKJNFPNNN, AddressFamily FMAEBGPLGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x548B920", Offset = "0x548A720", VA = "0x18548B920")]
	internal static int EFEFFDAMICE(int JGLMBGFBBCA, int IJJEODPJDDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2CC00E0", Offset = "0x2CBEEE0", VA = "0x182CC00E0")]
	internal static T[] GNNGKGKIAPN<T>(int BPFMGMBDOBA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class NIBNDKAAPLE : JKHANEEEPOA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BNFMHDBDJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private NIHOHFLKDLK ENPPLOKIPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long DEAGJIHNLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool IGPGCNJOHBB;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x548C750", Offset = "0x548B550", VA = "0x18548C750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x548C670", Offset = "0x548B470", VA = "0x18548C670")]
		public void AFGFMMMFKEL(NIHOHFLKDLK PIKEFGBMHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x548C6E0", Offset = "0x548B4E0", VA = "0x18548C6E0")]
		public bool CMAEGNMMEGD(long PLKNIACIGLP, IDBCAHNGOJD DMNOEGJPEJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x548C690", Offset = "0x548B490", VA = "0x18548C690")]
		public bool BBGCGJHDDBK(IDBCAHNGOJD DMNOEGJPEJB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly NIHOHFLKDLK FONDODNJOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly BNFMHDBDJEG[] GJBOJANPDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly NIHOHFLKDLK[] AMAODPDHPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] OIIDGFEMFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int NPGJNBMHMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int OBMPFPIOIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int EKHEJEDDEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int BJMDCIOEBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool JMLEBIIBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly LMCNFEONNPI BEKLBLGFDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool JFPIGIMBGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int BAJNMCBHNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte DMLDILPLJKN;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x54A0BC0", Offset = "0x549F9C0", VA = "0x1854A0BC0")]
	public NIBNDKAAPLE(IDBCAHNGOJD DMNOEGJPEJB, bool GFNJABPPNHE, byte DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x549FCF0", Offset = "0x549EAF0", VA = "0x18549FCF0")]
	private void BIDIEOFMOGD(NIHOHFLKDLK PIKEFGBMHFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x54A00B0", Offset = "0x549EEB0", VA = "0x1854A00B0", Slot = "4")]
	protected override bool HKDMCNJILKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x54A0560", Offset = "0x549F360", VA = "0x1854A0560", Slot = "5")]
	public override bool LCDGNFEALEI(NIHOHFLKDLK PIKEFGBMHFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KICNINAJIEK : JKHANEEEPOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int JELKMDCNIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort OBMPFPIOIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool KBOJIJAKGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private NIHOHFLKDLK GAFNHOIFFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly NIHOHFLKDLK KCONNAIAFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool DDCPOGGIKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte DMLDILPLJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long KMICIPOILFP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x549B480", Offset = "0x549A280", VA = "0x18549B480")]
	public KICNINAJIEK(IDBCAHNGOJD DMNOEGJPEJB, bool GBKENJOKFOH, byte DGIBOINMLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x549ACD0", Offset = "0x5499AD0", VA = "0x18549ACD0", Slot = "4")]
	protected override bool HKDMCNJILKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x549B170", Offset = "0x5499F70", VA = "0x18549B170", Slot = "5")]
	public override bool LCDGNFEALEI(NIHOHFLKDLK PIKEFGBMHFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class MMIENCCAAPO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct JOMGCIOAKNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong PNAALJMOILE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double CHEIMIOGDIO;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct MGIKCBKCJDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int IIDCDMGAHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float PMJAMJHLBEM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x548B5D0", Offset = "0x548A3D0", VA = "0x18548B5D0")]
	private static void DAIIIKGIAMI(byte[] CDNPBOBHCMP, int OOCJLKADJBK, ulong OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x549DF50", Offset = "0x549CD50", VA = "0x18549DF50")]
	private static void DAIIIKGIAMI(byte[] CDNPBOBHCMP, int OOCJLKADJBK, int OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x549DFC0", Offset = "0x549CDC0", VA = "0x18549DFC0")]
	public static void DAIIIKGIAMI(byte[] CDNPBOBHCMP, int OOCJLKADJBK, short OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x549E000", Offset = "0x549CE00", VA = "0x18549E000")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, double NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x549E030", Offset = "0x549CE30", VA = "0x18549E030")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x549DFC0", Offset = "0x549CDC0", VA = "0x18549DFC0")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, short NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x549DFC0", Offset = "0x549CDC0", VA = "0x18549DFC0")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, ushort NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x549DF50", Offset = "0x549CD50", VA = "0x18549DF50")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, int NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x549DF50", Offset = "0x549CD50", VA = "0x18549DF50")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, uint NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x549E020", Offset = "0x549CE20", VA = "0x18549E020")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, long NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x549E020", Offset = "0x549CE20", VA = "0x18549E020")]
	public static void NAOBDDHEIHL(byte[] JAHCJGGEGHK, int BKOJFCPJPEL, ulong NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NFDMAHAPLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] ADFGBCCJBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int PNJDPKHAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int NDOBLPFOJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int COGPEKNHLLG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] FOLFAIELIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LIIFDIEKDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FDLDJAMAEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x549F6F0", Offset = "0x549E4F0", VA = "0x18549F6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool FPINCHFCJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1CABD70", Offset = "0x1CAAB70", VA = "0x181CABD70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GAKGPLHIIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x549FC80", Offset = "0x549EA80", VA = "0x18549FC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x549F990", Offset = "0x549E790", VA = "0x18549F990")]
	public void NMCHPBAJJJD(byte[] DIIPJIMFFMD, int OOCJLKADJBK, int JLHBICDCDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public NFDMAHAPLAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x549FC90", Offset = "0x549EA90", VA = "0x18549FC90")]
	public NFDMAHAPLAN(byte[] DIIPJIMFFMD, int OOCJLKADJBK, int JLHBICDCDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x549F530", Offset = "0x549E330", VA = "0x18549F530")]
	public IPEndPoint FIEJLMDFAMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x549F1B0", Offset = "0x549DFB0", VA = "0x18549F1B0")]
	public byte JCJHOCGGCEA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x549F1B0", Offset = "0x549DFB0", VA = "0x18549F1B0")]
	public sbyte CDEECNNHHBP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x282C210", Offset = "0x282B010", VA = "0x18282C210")]
	public T[] OCLMHEEDOMB<T>(ushort DDGPJFNNFJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x549F260", Offset = "0x549E060", VA = "0x18549F260")]
	public bool[] CNGGEAKBGDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x549F600", Offset = "0x549E400", VA = "0x18549F600")]
	public ushort[] GGBOFIOCLIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x549F950", Offset = "0x549E750", VA = "0x18549F950")]
	public short[] NHOMAMJBMGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x549F2E0", Offset = "0x549E0E0", VA = "0x18549F2E0")]
	public int[] DIDKJKHDFMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x549F6B0", Offset = "0x549E4B0", VA = "0x18549F6B0")]
	public uint[] IOLBIGHHBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x549F2A0", Offset = "0x549E0A0", VA = "0x18549F2A0")]
	public float[] DHCJHFODDPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x549F8D0", Offset = "0x549E6D0", VA = "0x18549F8D0")]
	public double[] NEDDGNKMGII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x549F170", Offset = "0x549DF70", VA = "0x18549F170")]
	public long[] BLCMLCMOKIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x549F0A0", Offset = "0x549DEA0", VA = "0x18549F0A0")]
	public ulong[] AGKJBAECHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x549F400", Offset = "0x549E200", VA = "0x18549F400")]
	public string[] FHKDEELEDKM(int EDPAKKDDOHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x549F770", Offset = "0x549E570", VA = "0x18549F770")]
	public bool JNOHBPDHCBI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x549F390", Offset = "0x549E190", VA = "0x18549F390")]
	public char DPANOBAILKB()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x549F390", Offset = "0x549E190", VA = "0x18549F390")]
	public ushort EGEIMGEKLAE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x549F1F0", Offset = "0x549DFF0", VA = "0x18549F1F0")]
	public short CJLHLGPDKEO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x549F860", Offset = "0x549E660", VA = "0x18549F860")]
	public long LGKOJFBFIKE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x549F0E0", Offset = "0x549DEE0", VA = "0x18549F0E0")]
	public ulong AJPNKFLNJOO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x549FC10", Offset = "0x549EA10", VA = "0x18549FC10")]
	public int OIEGHLOGMLM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x549F640", Offset = "0x549E440", VA = "0x18549F640")]
	public uint ICEFOBOFLMN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x549F700", Offset = "0x549E500", VA = "0x18549F700")]
	public float JMBMOFEMIOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x549F320", Offset = "0x549E120", VA = "0x18549F320")]
	public double DKANCIEBMLK()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x549F9D0", Offset = "0x549E7D0", VA = "0x18549F9D0")]
	public string OBPIMILHDDK(int ENMILGMCCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x549F7F0", Offset = "0x549E5F0", VA = "0x18549F7F0")]
	public ArraySegment<byte> KOEELOCLEDA(int BPFMGMBDOBA)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x549F910", Offset = "0x549E710", VA = "0x18549F910")]
	public sbyte[] NHMDCHIMKJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x549F7B0", Offset = "0x549E5B0", VA = "0x18549F7B0")]
	public byte[] KAAKKOMJEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x549F150", Offset = "0x549DF50", VA = "0x18549F150")]
	public void BBGCGJHDDBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KMBHBOADCDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] ADFGBCCJBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int PNJDPKHAEMH;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int JIIBADNIIFK = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool HHPHPFCKDPN;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding JNOCKONCMHB;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int ALLBKLJNIPA = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] OKDFEFKDLKM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] GHKHBJDIPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int AAKPPKIKEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x549C270", Offset = "0x549B070", VA = "0x18549C270")]
	public KMBHBOADCDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x549C2F0", Offset = "0x549B0F0", VA = "0x18549C2F0")]
	public KMBHBOADCDH(bool DFIFJOHHDCK, int MODMJFMHILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x549BA70", Offset = "0x549A870", VA = "0x18549BA70")]
	public static KMBHBOADCDH BEFBJCCMEJP(string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x549C140", Offset = "0x549AF40", VA = "0x18549C140")]
	public void MKBAMDCMAOL(int LLIGBPJDKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D25680", Offset = "0x1D24480", VA = "0x181D25680")]
	public void MNGHADJNDMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x549BC30", Offset = "0x549AA30", VA = "0x18549BC30")]
	public void IMMNDBPCBBJ(float NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x549C0F0", Offset = "0x549AEF0", VA = "0x18549C0F0")]
	public void IMMNDBPCBBJ(double NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x549BBE0", Offset = "0x549A9E0", VA = "0x18549BBE0")]
	public void IMMNDBPCBBJ(long NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x549BBE0", Offset = "0x549A9E0", VA = "0x18549BBE0")]
	public void IMMNDBPCBBJ(ulong NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x549BB50", Offset = "0x549A950", VA = "0x18549BB50")]
	public void IMMNDBPCBBJ(int NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x549BB50", Offset = "0x549A950", VA = "0x18549BB50")]
	public void IMMNDBPCBBJ(uint NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x549BAE0", Offset = "0x549A8E0", VA = "0x18549BAE0")]
	public void IMMNDBPCBBJ(char NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x549BAE0", Offset = "0x549A8E0", VA = "0x18549BAE0")]
	public void IMMNDBPCBBJ(ushort NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x549BAE0", Offset = "0x549A8E0", VA = "0x18549BAE0")]
	public void IMMNDBPCBBJ(short NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x549C030", Offset = "0x549AE30", VA = "0x18549C030")]
	public void IMMNDBPCBBJ(sbyte NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x549C030", Offset = "0x549AE30", VA = "0x18549C030")]
	public void IMMNDBPCBBJ(byte NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x549BFC0", Offset = "0x549ADC0", VA = "0x18549BFC0")]
	public void IMMNDBPCBBJ(byte[] OMHIFBJFAGA, int OOCJLKADJBK, int FAPCCJLFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x549B540", Offset = "0x549A340", VA = "0x18549B540")]
	public void AKHGLAEKDAI(sbyte[] OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x549B540", Offset = "0x549A340", VA = "0x18549B540")]
	public void FKBNKNALBLB(byte[] OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x549C090", Offset = "0x549AE90", VA = "0x18549C090")]
	public void IMMNDBPCBBJ(bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x549B990", Offset = "0x549A790", VA = "0x18549B990")]
	public void AKKBOMLOLJG(Array NEJIMKHBJEM, int KPBGIEBDPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x549B700", Offset = "0x549A500", VA = "0x18549B700")]
	public void AKKBOMLOLJG(float[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x549B7E0", Offset = "0x549A5E0", VA = "0x18549B7E0")]
	public void AKKBOMLOLJG(double[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x549B7E0", Offset = "0x549A5E0", VA = "0x18549B7E0")]
	public void AKKBOMLOLJG(long[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x549B7E0", Offset = "0x549A5E0", VA = "0x18549B7E0")]
	public void AKKBOMLOLJG(ulong[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x549B700", Offset = "0x549A500", VA = "0x18549B700")]
	public void AKKBOMLOLJG(int[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x549B700", Offset = "0x549A500", VA = "0x18549B700")]
	public void AKKBOMLOLJG(uint[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x549B620", Offset = "0x549A420", VA = "0x18549B620")]
	public void AKKBOMLOLJG(ushort[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x549B620", Offset = "0x549A420", VA = "0x18549B620")]
	public void AKKBOMLOLJG(short[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x549B540", Offset = "0x549A340", VA = "0x18549B540")]
	public void AKKBOMLOLJG(bool[] NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x549B8C0", Offset = "0x549A6C0", VA = "0x18549B8C0")]
	public void AKKBOMLOLJG(string[] NKKIECLCEML, int CCCPKBCHJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x549BEF0", Offset = "0x549ACF0", VA = "0x18549BEF0")]
	public void IMMNDBPCBBJ(IPEndPoint EMNEFEFNGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x549BEE0", Offset = "0x549ACE0", VA = "0x18549BEE0")]
	public void IMMNDBPCBBJ(string NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x549BCD0", Offset = "0x549AAD0", VA = "0x18549BCD0")]
	public void IMMNDBPCBBJ(string NKKIECLCEML, int ENMILGMCCJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JMADCFGNFKG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class GDOBKKBGGAN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong FFDOGOLOLOK;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3692A60", Offset = "0x3691860", VA = "0x183692A60")]
		static GDOBKKBGGAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void HMGGNLNFBDA(NFDMAHAPLAN FECOEFBKMHD, object PHFNNADJJGH);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NLFCFLKPEOM<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public JMADCFGNFKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NLFCFLKPEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3E75FD0", Offset = "0x3E74DD0", VA = "0x183E75FD0")]
		internal void FOJNCDNCLFM(NFDMAHAPLAN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JFFFCEBBMDM<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public JMADCFGNFKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public JFFFCEBBMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3A28870", Offset = "0x3A27670", VA = "0x183A28870")]
		internal void FOJNCDNCLFM(NFDMAHAPLAN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly ENLNLFCJBKJ KLBNIGGGAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, HMGGNLNFBDA> CGKGOLAJPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly KMBHBOADCDH PODACLHFAJK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5493980", Offset = "0x5492780", VA = "0x185493980")]
	public JMADCFGNFKG(int EDPAKKDDOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0", Slot = "4")]
	protected virtual ulong OJALKCGDPNG<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5493800", Offset = "0x5492600", VA = "0x185493800", Slot = "5")]
	protected virtual HMGGNLNFBDA ENOHKKCPCAF(NFDMAHAPLAN FECOEFBKMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x275EDE0", Offset = "0x275DBE0", VA = "0x18275EDE0", Slot = "6")]
	protected virtual void LLMDHFJEJBO<T>(KMBHBOADCDH HNIKDBEHAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5493780", Offset = "0x5492580", VA = "0x185493780")]
	public void BLGHBOOKIJH(NFDMAHAPLAN FECOEFBKMHD, object PHFNNADJJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x275ED50", Offset = "0x275DB50", VA = "0x18275ED50")]
	public void KIKABBCJOMK<T>(KMBHBOADCDH HNIKDBEHAFP, T PIKEFGBMHFN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5493930", Offset = "0x5492730", VA = "0x185493930")]
	public void ILKFLMHMLLB(NFDMAHAPLAN FECOEFBKMHD, object PHFNNADJJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x275EBD0", Offset = "0x275D9D0", VA = "0x18275EBD0")]
	public void FAHIIFJBBHB<T>(Action<T> IJFMJIJELPI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x275EA50", Offset = "0x275D850", VA = "0x18275EA50")]
	public void FAHIIFJBBHB<T, TUserData>(Action<T, TUserData> IJFMJIJELPI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class GKLCEFDPKPK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x548C7F0", Offset = "0x548B5F0", VA = "0x18548C7F0")]
	public GKLCEFDPKPK(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class OKAHBKBGOMK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x54A1810", Offset = "0x54A0610", VA = "0x1854A1810")]
	public OKAHBKBGOMK(string EMKENBOOEOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ENLNLFCJBKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum KIFGOCPNNJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class HMELHNHHBML<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public KIFGOCPNNJI KKPIOFNDDGK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x37B17A0", Offset = "0x37B05A0", VA = "0x1837B17A0", Slot = "4")]
		public virtual void AFGFMMMFKEL(MethodInfo KJECNPIMGEJ, MethodInfo GJNHLFPPFCA, KIFGOCPNNJI HFFNCGFKMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GEGDMDHNHIJ(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void FGBAMBAMKDA(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		protected HMELHNHHBML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class PMHKMIDHDPK<TClass, TProperty> : HMELHNHHBML<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> AJPPDCMHHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> GEKGNCHNFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> EDOHCPEIJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> NBOJMAOLMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> MEECFAJBBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> AOHGMOCDIHO;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x40580D0", Offset = "0x4056ED0", VA = "0x1840580D0", Slot = "7")]
		public override void INNPFPIOCPB(TClass LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4058DF0", Offset = "0x4057BF0", VA = "0x184058DF0", Slot = "8")]
		public override void PJDFJLDOPAN(TClass LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4057D50", Offset = "0x4056B50", VA = "0x184057D50", Slot = "9")]
		public override void GEGDMDHNHIJ(TClass LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x40572D0", Offset = "0x40560D0", VA = "0x1840572D0", Slot = "10")]
		public override void FGBAMBAMKDA(TClass LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4056C20", Offset = "0x4055A20", VA = "0x184056C20")]
		protected TProperty[] BGAGIBOECKN(TClass LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4056D20", Offset = "0x4055B20", VA = "0x184056D20")]
		protected TProperty[] COBMIHKKGDB(TClass LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4054F60", Offset = "0x4053D60", VA = "0x184054F60", Slot = "4")]
		public override void AFGFMMMFKEL(MethodInfo KJECNPIMGEJ, MethodInfo GJNHLFPPFCA, KIFGOCPNNJI HFFNCGFKMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x386F490", Offset = "0x386E290", VA = "0x18386F490")]
		protected PMHKMIDHDPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class ADHMOCKHGAA<TClass, TProperty> : PMHKMIDHDPK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void PFGEOPMKIMD(NFDMAHAPLAN KEGMCPHLHED, [Out] TProperty MKKFNLKHOHA);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void NBKKAADJCNM(KMBHBOADCDH JMEBBPBFDEK, TProperty MKKFNLKHOHA);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x366E930", Offset = "0x366D730", VA = "0x18366E930", Slot = "5")]
		public override void LBOGEFKGOMK(TClass LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x366E850", Offset = "0x366D650", VA = "0x18366E850", Slot = "6")]
		public override void KIKABBCJOMK(TClass LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x366E710", Offset = "0x366D510", VA = "0x18366E710", Slot = "7")]
		public override void INNPFPIOCPB(TClass LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x366EA30", Offset = "0x366D830", VA = "0x18366EA30", Slot = "8")]
		public override void PJDFJLDOPAN(TClass LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x366EB70", Offset = "0x366D970", VA = "0x18366EB70")]
		protected ADHMOCKHGAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class COMODJJKALF<T> : PMHKMIDHDPK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4A63B70", Offset = "0x4A62970", VA = "0x184A63B70", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B131A0", Offset = "0x3B11FA0", VA = "0x183B131A0", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4A63B00", Offset = "0x4A62900", VA = "0x184A63B00", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3786360", Offset = "0x3785160", VA = "0x183786360", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public COMODJJKALF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class KOABDFJFAGH<T> : PMHKMIDHDPK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3B13200", Offset = "0x3B12000", VA = "0x183B13200", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3B131A0", Offset = "0x3B11FA0", VA = "0x183B131A0", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3B13130", Offset = "0x3B11F30", VA = "0x183B13130", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3786360", Offset = "0x3785160", VA = "0x183786360", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public KOABDFJFAGH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class POIJBAMIKMM<T> : PMHKMIDHDPK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x405CA60", Offset = "0x405B860", VA = "0x18405CA60", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x405CA00", Offset = "0x405B800", VA = "0x18405CA00", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x405C990", Offset = "0x405B790", VA = "0x18405C990", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x405CAD0", Offset = "0x405B8D0", VA = "0x18405CAD0", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public POIJBAMIKMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class CMAOJIBDBPA<T> : PMHKMIDHDPK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4A58B20", Offset = "0x4A57920", VA = "0x184A58B20", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x405CA00", Offset = "0x405B800", VA = "0x18405CA00", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4A58AB0", Offset = "0x4A578B0", VA = "0x184A58AB0", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x405CAD0", Offset = "0x405B8D0", VA = "0x18405CAD0", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public CMAOJIBDBPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class COKJCGENKFF<T> : PMHKMIDHDPK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FCD0", Offset = "0x4A5EAD0", VA = "0x184A5FCD0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FC70", Offset = "0x4A5EA70", VA = "0x184A5FC70", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FC00", Offset = "0x4A5EA00", VA = "0x184A5FC00", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3679550", Offset = "0x3678350", VA = "0x183679550", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public COKJCGENKFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CPFGIDIGMPN<T> : PMHKMIDHDPK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4A692C0", Offset = "0x4A680C0", VA = "0x184A692C0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FC70", Offset = "0x4A5EA70", VA = "0x184A5FC70", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4A69250", Offset = "0x4A68050", VA = "0x184A69250", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3679550", Offset = "0x3678350", VA = "0x183679550", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public CPFGIDIGMPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class APFMFHKHLPF<T> : PMHKMIDHDPK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x373C3C0", Offset = "0x373B1C0", VA = "0x18373C3C0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x373C360", Offset = "0x373B160", VA = "0x18373C360", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x373C2F0", Offset = "0x373B0F0", VA = "0x18373C2F0", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x373C430", Offset = "0x373B230", VA = "0x18373C430", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public APFMFHKHLPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class JODLOEIIKBC<T> : PMHKMIDHDPK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x373C3C0", Offset = "0x373B1C0", VA = "0x18373C3C0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x373C360", Offset = "0x373B160", VA = "0x18373C360", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A61AA0", Offset = "0x3A608A0", VA = "0x183A61AA0", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x373C430", Offset = "0x373B230", VA = "0x18373C430", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public JODLOEIIKBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class HGNNLGMEIOO<T> : PMHKMIDHDPK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x37862F0", Offset = "0x37850F0", VA = "0x1837862F0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3786290", Offset = "0x3785090", VA = "0x183786290", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3786220", Offset = "0x3785020", VA = "0x183786220", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3786360", Offset = "0x3785160", VA = "0x183786360", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public HGNNLGMEIOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class AGGGAMFBFEP<T> : PMHKMIDHDPK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x36794E0", Offset = "0x36782E0", VA = "0x1836794E0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3679480", Offset = "0x3678280", VA = "0x183679480", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3679410", Offset = "0x3678210", VA = "0x183679410", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3679550", Offset = "0x3678350", VA = "0x183679550", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public AGGGAMFBFEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PEFNJHOELCE<T> : PMHKMIDHDPK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x403CE00", Offset = "0x403BC00", VA = "0x18403CE00", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x403CDA0", Offset = "0x403BBA0", VA = "0x18403CDA0", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x403CD30", Offset = "0x403BB30", VA = "0x18403CD30", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x373C430", Offset = "0x373B230", VA = "0x18373C430", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x36795B0", Offset = "0x36783B0", VA = "0x1836795B0")]
		public PEFNJHOELCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HBOJJMOEFEM<T> : ADHMOCKHGAA<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3703B60", Offset = "0x3702960", VA = "0x183703B60", Slot = "12")]
		protected override void NBKKAADJCNM(KMBHBOADCDH JMEBBPBFDEK, char MKKFNLKHOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3703B90", Offset = "0x3702990", VA = "0x183703B90", Slot = "11")]
		protected override void PFGEOPMKIMD(NFDMAHAPLAN KEGMCPHLHED, [Out] char MKKFNLKHOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x32544B0", Offset = "0x32532B0", VA = "0x1832544B0")]
		public HBOJJMOEFEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ELKCHFCGPPI<T> : ADHMOCKHGAA<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x32544D0", Offset = "0x32532D0", VA = "0x1832544D0", Slot = "12")]
		protected override void NBKKAADJCNM(KMBHBOADCDH JMEBBPBFDEK, IPEndPoint MKKFNLKHOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3254500", Offset = "0x3253300", VA = "0x183254500", Slot = "11")]
		protected override void PFGEOPMKIMD(NFDMAHAPLAN KEGMCPHLHED, [Out] IPEndPoint MKKFNLKHOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x32544B0", Offset = "0x32532B0", VA = "0x1832544B0")]
		public ELKCHFCGPPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class GKMILMONKJB<T> : PMHKMIDHDPK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int AHJGLAAOLKJ;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x36CF0F0", Offset = "0x36CDEF0", VA = "0x1836CF0F0")]
		public GKMILMONKJB(int ENMILGMCCJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x36CF010", Offset = "0x36CDE10", VA = "0x1836CF010", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x36CEFA0", Offset = "0x36CDDA0", VA = "0x1836CEFA0", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x36CEF30", Offset = "0x36CDD30", VA = "0x1836CEF30", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x36CF080", Offset = "0x36CDE80", VA = "0x1836CF080", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class IDCADKNKJCP<T> : HMELHNHHBML<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo APCMECOMLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type BHINMPKLAFJ;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3845910", Offset = "0x3844710", VA = "0x183845910")]
		public IDCADKNKJCP(PropertyInfo EDANCLIIPKG, Type AKIMNJKPNCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x38457F0", Offset = "0x38445F0", VA = "0x1838457F0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3845740", Offset = "0x3844540", VA = "0x183845740", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x38456E0", Offset = "0x38444E0", VA = "0x1838456E0", Slot = "7")]
		public override void INNPFPIOCPB(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x38458B0", Offset = "0x38446B0", VA = "0x1838458B0", Slot = "8")]
		public override void PJDFJLDOPAN(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3845680", Offset = "0x3844480", VA = "0x183845680", Slot = "9")]
		public override void GEGDMDHNHIJ(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3845620", Offset = "0x3844420", VA = "0x183845620", Slot = "10")]
		public override void FGBAMBAMKDA(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class AOIECDFJPND<T> : IDCADKNKJCP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3257860", Offset = "0x3256660", VA = "0x183257860")]
		public AOIECDFJPND(PropertyInfo EDANCLIIPKG, Type AKIMNJKPNCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x373A3A0", Offset = "0x37391A0", VA = "0x18373A3A0", Slot = "5")]
		public override void LBOGEFKGOMK(T LBGHJGBGHKO, NFDMAHAPLAN KEGMCPHLHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x373A2F0", Offset = "0x37390F0", VA = "0x18373A2F0", Slot = "6")]
		public override void KIKABBCJOMK(T LBGHJGBGHKO, KMBHBOADCDH JMEBBPBFDEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class HLLNFMPBPPO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static HLLNFMPBPPO<T> AHFNEPHAKHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly HMELHNHHBML<T>[] IABGPEPOBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int AJIMCBBPJGD;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x37A97E0", Offset = "0x37A85E0", VA = "0x1837A97E0")]
		public HLLNFMPBPPO(List<HMELHNHHBML<T>> PJNMKOBPMGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x37A9680", Offset = "0x37A8480", VA = "0x1837A9680")]
		public void KIKABBCJOMK(T NHLNHJGAONN, KMBHBOADCDH HNIKDBEHAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x37A9730", Offset = "0x37A8530", VA = "0x1837A9730")]
		public void LBOGEFKGOMK(T NHLNHJGAONN, NFDMAHAPLAN FECOEFBKMHD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class OAIJBFBIFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HMELHNHHBML<T> IKJEAFPPDKF<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private KMBHBOADCDH IGEEMNEBKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int EDJNLOMGCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, OAIJBFBIFJK> JPKAMBEKHID;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x548E1E0", Offset = "0x548CFE0", VA = "0x18548E1E0")]
	public ENLNLFCJBKJ(int EDPAKKDDOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x25CBDE0", Offset = "0x25CABE0", VA = "0x1825CBDE0")]
	private HLLNFMPBPPO<T> KAPDHHCPLAO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x256F0A0", Offset = "0x256DEA0", VA = "0x18256F0A0")]
	public void NLHDMBJLIGN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x25CBD00", Offset = "0x25CAB00", VA = "0x1825CBD00")]
	public bool CINNELLPCMC<T>(NFDMAHAPLAN FECOEFBKMHD, T KAKJJOAALHM) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x25CBD80", Offset = "0x25CAB80", VA = "0x1825CBD80")]
	public void FILLENIGNNA<T>(KMBHBOADCDH HNIKDBEHAFP, T NHLNHJGAONN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DICGFKJDBLM
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime HENPPANKPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] EFAGEEFKDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IPIILMCINCN DJLFKKFKNII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x548C8E0", Offset = "0x548B6E0", VA = "0x18548C8E0")]
		get
		{
			return default(IPIILMCINCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FPDABJNLJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x548D460", Offset = "0x548C260", VA = "0x18548D460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x548CDB0", Offset = "0x548BBB0", VA = "0x18548CDB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CGCICEPHCAD PKLBAHNBPLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x548CDF0", Offset = "0x548BBF0", VA = "0x18548CDF0")]
		get
		{
			return default(CGCICEPHCAD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x548D220", Offset = "0x548C020", VA = "0x18548D220")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JHHAKPPJBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x548D810", Offset = "0x548C610", VA = "0x18548D810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint AEPDJJHINPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x548CEB0", Offset = "0x548BCB0", VA = "0x18548CEB0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? HNOLNIBLAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x548CE80", Offset = "0x548BC80", VA = "0x18548CE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? PLHCMNHLDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x548CE20", Offset = "0x548BC20", VA = "0x18548CE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KMHBBCOPCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x548CE50", Offset = "0x548BC50", VA = "0x18548CE50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x548CF30", Offset = "0x548BD30", VA = "0x18548CF30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? HCGHLKNLAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA34F00", Offset = "0xA33D00", VA = "0x180A34F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x89FD70", Offset = "0x89EB70", VA = "0x18089FD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x548D8A0", Offset = "0x548C6A0", VA = "0x18548D8A0")]
	public DICGFKJDBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x548DBC0", Offset = "0x548C9C0", VA = "0x18548DBC0")]
	internal DICGFKJDBLM(byte[] JAHCJGGEGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x548D490", Offset = "0x548C290", VA = "0x18548D490")]
	public static DICGFKJDBLM MOFKMIMMJKF(byte[] JAHCJGGEGHK, DateTime GNCNKLOEONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x548C910", Offset = "0x548B710", VA = "0x18548C910")]
	internal void ALHOAHBKKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x548D640", Offset = "0x548C440", VA = "0x18548D640")]
	private void NCBIGIHONIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x548D260", Offset = "0x548C060", VA = "0x18548D260")]
	private DateTime? LLHJCMEGCCE(int OOCJLKADJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x548CBE0", Offset = "0x548B9E0", VA = "0x18548CBE0")]
	private void BJFAJPHMJCL(int OOCJLKADJBK, DateTime? NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x548CB10", Offset = "0x548B910", VA = "0x18548CB10")]
	private ulong BALKBPPBCHN(int OOCJLKADJBK)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x548D160", Offset = "0x548BF60", VA = "0x18548D160")]
	private void LBLJGCOIIFK(int OOCJLKADJBK, ulong NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x548D5B0", Offset = "0x548C3B0", VA = "0x18548D5B0")]
	private uint MOMGLHICHFE(int OOCJLKADJBK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x536E190", Offset = "0x536CF90", VA = "0x18536E190")]
	private static uint KKMNGEJIKKB(uint AHPBAINPGNA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x548D100", Offset = "0x548BF00", VA = "0x18548D100")]
	private static ulong KKMNGEJIKKB(ulong AHPBAINPGNA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum IPIILMCINCN
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
public enum CGCICEPHCAD
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EPCMFILDHDM
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int IAEJKCKGEOE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int POOFMMIBBIM = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int IEFOJKDIGFI = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint APCNEJOFNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int MODKMPNNFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int LMBCFJMIMDJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IGLCJJPBFPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x548E280", Offset = "0x548D080", VA = "0x18548E280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x548E290", Offset = "0x548D090", VA = "0x18548E290")]
	public bool KDALOMEDGDM(JLELFCFHMNE OHEEICIOAAG, int JKFFGJGCLAE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class JGANECHDAGN : JLELFCFHMNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket OHEEICIOAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly KAAHPFEGNNI CKCLPBCNAHO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short FIIGPDGFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5492DA0", Offset = "0x5491BA0", VA = "0x185492DA0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int ADFMGMCPAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5492DC0", Offset = "0x5491BC0", VA = "0x185492DC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint HFADMFMKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x54934D0", Offset = "0x54922D0", VA = "0x1854934D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily GDKLOBAKJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3B8B4E0", Offset = "0x3B8A2E0", VA = "0x183B8B4E0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5493510", Offset = "0x5492310", VA = "0x185493510")]
	public JGANECHDAGN(AddressFamily FMAEBGPLGDL, KAAHPFEGNNI CKCLPBCNAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5492ED0", Offset = "0x5491CD0", VA = "0x185492ED0", Slot = "8")]
	public bool EGHOCEDPNOG(IPEndPoint EMNEFEFNGKP, LOOCEJCDDLN BBPPPBELFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5493490", Offset = "0x5492290", VA = "0x185493490", Slot = "9")]
	public int KJKNLHHLOEO(byte[] CDNPBOBHCMP, int OOCJLKADJBK, int DDGPJFNNFJK, IPEndPoint LABACEAPCEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5492DE0", Offset = "0x5491BE0", VA = "0x185492DE0", Slot = "10")]
	public int AOGIILPEGBH(byte[] CDNPBOBHCMP, EndPoint LPDBMKAOHIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x54934F0", Offset = "0x54922F0", VA = "0x1854934F0", Slot = "11")]
	public void MCPNIJMLOIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface JLELFCFHMNE
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short FIIGPDGFMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int ADFMGMCPAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint HFADMFMKKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily GDKLOBAKJNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EGHOCEDPNOG(IPEndPoint EMNEFEFNGKP, LOOCEJCDDLN BBPPPBELFCF);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KJKNLHHLOEO(byte[] CDNPBOBHCMP, int OOCJLKADJBK, int DDGPJFNNFJK, IPEndPoint LABACEAPCEH);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AOGIILPEGBH(byte[] CDNPBOBHCMP, EndPoint LABACEAPCEH);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MCPNIJMLOIE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct MMIBPIBICLE : IEquatable<MMIBPIBICLE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long KEFPFLBOLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long HJEPINAGENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long HDPOMLHFOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int NOGHLPNDPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int JHLGGIBHCPN;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x549DE60", Offset = "0x549CC60", VA = "0x18549DE60")]
	public MMIBPIBICLE(byte[] EHNFDGMHPMM, int CAMEJMCIOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7D1590", Offset = "0x7D0390", VA = "0x1807D1590", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x549DE20", Offset = "0x549CC20", VA = "0x18549DE20", Slot = "4")]
	public bool Equals(MMIBPIBICLE FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x549DD70", Offset = "0x549CB70", VA = "0x18549DD70", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class IFGMNMHGFLL : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] PEMKBJHBBIM;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class OKLOCIEBHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int LNDPOCECMIC;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
	protected OKLOCIEBHHJ(int DAOMMFCPCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BPOPGCGOGMI(IPEndPoint EMNEFEFNGKP, byte[] OMHIFBJFAGA, int OOCJLKADJBK, int FAPCCJLFBAA);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CJCOGKEFIHP(IPEndPoint EMNEFEFNGKP, byte[] OMHIFBJFAGA, int OOCJLKADJBK, int FAPCCJLFBAA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MOBJGHNAIII : OKLOCIEBHHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider DBJJNHLGBGC;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator MFFMAGGKKMG;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x549ECF0", Offset = "0x549DAF0", VA = "0x18549ECF0")]
	public MOBJGHNAIII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x549EA50", Offset = "0x549D850", VA = "0x18549EA50")]
	public void JDGNBKNBJHF(IPEndPoint EMNEFEFNGKP, byte[] JCMGBFKGKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x549E0B0", Offset = "0x549CEB0", VA = "0x18549E0B0")]
	public void ALEDJPNKDEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x549E9C0", Offset = "0x549D7C0", VA = "0x18549E9C0")]
	private byte[] FFFKNPDGIKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x549E190", Offset = "0x549CF90", VA = "0x18549E190", Slot = "4")]
	public override void BPOPGCGOGMI(IPEndPoint EMNEFEFNGKP, byte[] OMHIFBJFAGA, int OOCJLKADJBK, int FAPCCJLFBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x549E620", Offset = "0x549D420", VA = "0x18549E620", Slot = "5")]
	public override void CJCOGKEFIHP(IPEndPoint EMNEFEFNGKP, byte[] OMHIFBJFAGA, int OOCJLKADJBK, int FAPCCJLFBAA)
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
