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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, JLCAJKOLHGA
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum NLIHBDKLJFB
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
		private NetworkManager IBFOMOJHANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, DKHMDEBGIMI> BGBACPPPMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BCHHLBEKOFD OLPAHPKFDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] FDGIGIHHLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private NLIHBDKLJFB CMPIPBINMCK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong CODFGBMDFHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool INPKLAIKLGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x54A0040", Offset = "0x549EA40", VA = "0x1854A0040", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x549F540", Offset = "0x549DF40", VA = "0x18549F540")]
		public void RecRoom_SetEncryptionInfo(ulong BLDAHBCMFBE, byte[] FHLJKJHFEEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x549F520", Offset = "0x549DF20", VA = "0x18549F520")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x549F3F0", Offset = "0x549DDF0", VA = "0x18549F3F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x549FF40", Offset = "0x549E940", VA = "0x18549FF40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x549F740", Offset = "0x549E140", VA = "0x18549F740", Slot = "6")]
		public override void Send(ulong MGCALJGHCJP, ArraySegment<byte> OBAHLGOPPIK, NetworkDelivery IELCDNMNNEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x549F4E0", Offset = "0x549DEE0", VA = "0x18549F4E0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong MGCALJGHCJP, [Out] ArraySegment<byte> DNNAMOOCONL, [Out] float PIMHLFGAGPF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x549FA30", Offset = "0x549E430", VA = "0x18549FA30", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x549FE60", Offset = "0x549E860", VA = "0x18549FE60", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x549E9B0", Offset = "0x549D3B0", VA = "0x18549E9B0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong MGCALJGHCJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x549E860", Offset = "0x549D260", VA = "0x18549E860", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x549ECF0", Offset = "0x549D6F0", VA = "0x18549ECF0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong MGCALJGHCJP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x549F9C0", Offset = "0x549E3C0", VA = "0x18549F9C0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x549F090", Offset = "0x549DA90", VA = "0x18549F090", Slot = "14")]
		public override void Initialize([Optional] NetworkManager IBFOMOJHANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x549EB20", Offset = "0x549D520", VA = "0x18549EB20")]
		private OCANLLCHEJB FEBPFPGLIOG(NetworkDelivery AKDFFJNHJJN)
		{
			return default(OCANLLCHEJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x549EDC0", Offset = "0x549D7C0", VA = "0x18549EDC0", Slot = "15")]
		private void IFBGDCEFJLP(DKHMDEBGIMI GAAFMINIKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x549F2B0", Offset = "0x549DCB0", VA = "0x18549F2B0", Slot = "16")]
		private void NCKBNMEEGEH(DKHMDEBGIMI GAAFMINIKPA, NPCFFNJJDIN LPJNCIBGGKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "17")]
		private void ALPKIHJKONP(IPEndPoint EIBEDFFKGBE, SocketError BCEEIBKJCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x549EE80", Offset = "0x549D880", VA = "0x18549EE80", Slot = "18")]
		private void IKHFOCAKNDG(DKHMDEBGIMI GAAFMINIKPA, LGDCCNPEFLC HPEAJCENMCM, byte HMJGDPAEADK, OCANLLCHEJB FJEBLJKAFPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x549EBF0", Offset = "0x549D5F0", VA = "0x18549EBF0")]
		private void FFDJPMFLBBK(int DDIMFHFNGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "19")]
		private void JJOEKKIMJGD(IPEndPoint HEKEGJLELJB, LGDCCNPEFLC HPEAJCENMCM, CMPIPFKJMIB DIIKHMAMDJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "20")]
		private void PEKCBJEFCAD(DKHMDEBGIMI GAAFMINIKPA, int OAMOBJCKMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x549F250", Offset = "0x549DC50", VA = "0x18549F250", Slot = "21")]
		private void LPHDDJBBFMJ(GKODGNOBJEH GOAJPHFIKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x549ED90", Offset = "0x549D790", VA = "0x18549ED90")]
		private ulong HLMEKHLFHID(DKHMDEBGIMI GAAFMINIKPA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x549ECD0", Offset = "0x549D6D0", VA = "0x18549ECD0")]
		private static int GENBMMMEEDE(float GPIPKOHJNJJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x549FF60", Offset = "0x549E960", VA = "0x18549FF60")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class IJHAMIHGGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly DKHMDEBGIMI EGADJDCAKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<EJEGFFJDIFD> PCPJOBBJGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int EPHKGJDCENH;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x549E3D0", Offset = "0x549CDD0", VA = "0x18549E3D0")]
	protected IJHAMIHGGPA(DKHMDEBGIMI GAAFMINIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x549E370", Offset = "0x549CD70", VA = "0x18549E370")]
	public void OFCKBIOBEOL(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x549E2F0", Offset = "0x549CCF0", VA = "0x18549E2F0")]
	protected void NGICJFKDMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x549E2B0", Offset = "0x549CCB0", VA = "0x18549E2B0")]
	public bool IODMIKIHLND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool KHNKBBGJBHB();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MIDBFKMKEKI(EJEGFFJDIFD PLIKBMJHGLO);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum MFDLKOABIIJ
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
public class GKODGNOBJEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BCHHLBEKOFD AOKOAKCLCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int LGPGKFLKOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FMDJOAGKGLE ADOHIJJGOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint LENBAGHPGIA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal MFDLKOABIIJ CGGLICFNDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B7DC0", Offset = "0x7B67C0", VA = "0x1807B7DC0")]
		[CompilerGenerated]
		get
		{
			return default(MFDLKOABIIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C1560", Offset = "0x8BFF60", VA = "0x1808C1560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x549CDC0", Offset = "0x549B7C0", VA = "0x18549CDC0")]
	internal void CPMNBOEAGMI(FMDJOAGKGLE KDKNEOFLIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x549CD90", Offset = "0x549B790", VA = "0x18549CD90")]
	private bool BMCLOMKEFCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x549CE80", Offset = "0x549B880", VA = "0x18549CE80")]
	internal GKODGNOBJEH(IPEndPoint HEKEGJLELJB, FMDJOAGKGLE KPEIEGPAHCH, BCHHLBEKOFD PHGMCBKDBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x549CE20", Offset = "0x549B820", VA = "0x18549CE20")]
	public DKHMDEBGIMI FODPKCMJFIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CMPIPFKJMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KAGMONALHEH
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
public struct NPCFFNJJDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public KAGMONALHEH FPHJAFOOAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError ELJNCIGONMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public LGDCCNPEFLC MKCOBKKCNLB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JLCAJKOLHGA
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDGLGJBNAPB(DKHMDEBGIMI GAAFMINIKPA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDNLDOPEKNA(DKHMDEBGIMI GAAFMINIKPA, NPCFFNJJDIN LPJNCIBGGKE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CBLBDABNJLH(IPEndPoint EIBEDFFKGBE, SocketError BCEEIBKJCDD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LDDOMODLDMK(DKHMDEBGIMI GAAFMINIKPA, LGDCCNPEFLC HPEAJCENMCM, byte HMJGDPAEADK, OCANLLCHEJB FJEBLJKAFPK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IGILCDFEEIG(IPEndPoint HEKEGJLELJB, LGDCCNPEFLC HPEAJCENMCM, CMPIPFKJMIB DIIKHMAMDJE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGADJAFCLHI(DKHMDEBGIMI GAAFMINIKPA, int OAMOBJCKMJG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOLPCJFCDFN(GKODGNOBJEH GOAJPHFIKLF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NJHJBCEJBKG
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABAMPMMLBEJ(DKHMDEBGIMI GAAFMINIKPA, object KAPEMEGKCFG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PCIEBJIDFGG
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFPBCIOOFDP(OMHOHPCAANJ PLIKBMJHGLO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KBJKEOLPIKB
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCFGMLENJKO(DKHMDEBGIMI GAAFMINIKPA, IPEndPoint JOALLEFPHFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FMDJOAGKGLE
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int PDJDLGDCKLF = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long OHAFBMIPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte LLDFBAAHHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] AEHCCNANKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly FENDLGDKDDD KGACILCCGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int ENJOGKEGHEI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x549CD20", Offset = "0x549B720", VA = "0x18549CD20")]
	private FMDJOAGKGLE(long HPJAAJODHAL, byte MLICCJPOHLD, int DGJIHKHJFEB, byte[] EEILKEGCKMG, FENDLGDKDDD OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x549C8C0", Offset = "0x549B2C0", VA = "0x18549C8C0")]
	public static int EDCFANEHNBN(EJEGFFJDIFD PLIKBMJHGLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x549C920", Offset = "0x549B320", VA = "0x18549C920")]
	public static FMDJOAGKGLE KLBINMLCCPD(EJEGFFJDIFD PLIKBMJHGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x549CB40", Offset = "0x549B540", VA = "0x18549CB40")]
	public static EJEGFFJDIFD PAMNIOGNMJA(PNCOIDBAFPJ OAJKKFJALDC, SocketAddress PJJLJPFHKIM, long AFMIOBFDDEO, int DGJIHKHJFEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class AHFGFANDAEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long OHAFBMIPEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte LLDFBAAHHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int ENJOGKEGHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool IEKLAJLMILJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x548DB00", Offset = "0x548C500", VA = "0x18548DB00")]
	private AHFGFANDAEP(long HPJAAJODHAL, byte MLICCJPOHLD, int OCGFBKPGNNG, bool GGKJOMFGFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x548D8C0", Offset = "0x548C2C0", VA = "0x18548D8C0")]
	public static AHFGFANDAEP KLBINMLCCPD(EJEGFFJDIFD PLIKBMJHGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x548DA10", Offset = "0x548C410", VA = "0x18548DA10")]
	public static EJEGFFJDIFD PAMNIOGNMJA(long AFMIOBFDDEO, byte CIJIKLONJLJ, int NCFACJDJILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x548D7C0", Offset = "0x548C1C0", VA = "0x18548D7C0")]
	public static EJEGFFJDIFD BJIKEKADKCE(DKHMDEBGIMI GAAFMINIKPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum JDKMEIJLFMJ
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ENBKOIBAOIO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APFFEOKFEED(IPEndPoint JKALFJNCBFN, IPEndPoint HEKEGJLELJB, string BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNBAAICIFPI(IPEndPoint FPAKFPNOFCJ, JDKMEIJLFMJ AKDFFJNHJJN, string BDAPLOBBPIE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class IHAMIKGKMHP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct JAHFFOIFIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint GAKBGKCJBEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint LENBAGHPGIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string EMDMFNPCAIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct EDIGADHANIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint IJCPPIJILKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JDKMEIJLFMJ KBCPOJJINMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string EMDMFNPCAIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class DMNBMHFJACP
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint IMDNBBEDBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string EMDMFNPCAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public DMNBMHFJACP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PBBHKGAJJMF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint IMDNBBEDBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint EJOPPBOENOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string EMDMFNPCAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public PBBHKGAJJMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KJPJAGDMGBF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EMDMFNPCAIK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KGDMDBMMLLK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x792750", Offset = "0x791150", VA = "0x180792750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public KJPJAGDMGBF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BCHHLBEKOFD LGNELHBELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<JAHFFOIFIDG> IIOAELIEAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<EDIGADHANIM> MPNGFHHFBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FENDLGDKDDD MNPFBOJGIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PNCOIDBAFPJ JHOIBLLLDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NKHKCGMKFCE NGKJFJGEEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ENBKOIBAOIO BNBKILDMIHG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int CFNBMDOPOCA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool CECHMDALLJK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x549DE60", Offset = "0x549C860", VA = "0x18549DE60")]
	internal IHAMIKGKMHP(BCHHLBEKOFD MCBJAKHFHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x549DBA0", Offset = "0x549C5A0", VA = "0x18549DBA0")]
	internal void EDGFIPBPHFA(IPEndPoint KDHKLBPJJAL, EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2633280", Offset = "0x2631C80", VA = "0x182633280")]
	private void AGBOLNHIJKC<T>(T PLIKBMJHGLO, IPEndPoint DMFBOAFMPLH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x549D870", Offset = "0x549C270", VA = "0x18549D870")]
	private void APFFEOKFEED(DMNBMHFJACP JBKPKFGJEDA, IPEndPoint KDHKLBPJJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x549DD00", Offset = "0x549C700", VA = "0x18549DD00")]
	private void KANKCCDOPAM(PBBHKGAJJMF JBKPKFGJEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x549DA00", Offset = "0x549C400", VA = "0x18549DA00")]
	private void BBPBGGEDPCI(KJPJAGDMGBF JBKPKFGJEDA, IPEndPoint KDHKLBPJJAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OCANLLCHEJB : byte
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
public enum LNMGJLEFJLI : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NEDCPEOCKJP
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] LAKFGABCNPP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int CKIMGBCFDAI;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int MFPDPJKAJFE;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MCNJJOAHGJF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x549D860", Offset = "0x549C260", VA = "0x18549D860")]
	public MCNJJOAHGJF(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class POHJFDLGEBP : MCNJJOAHGJF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x549D860", Offset = "0x549C260", VA = "0x18549D860")]
	public POHJFDLGEBP(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NKLELNFFLDK
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
public interface PKOIFPADHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDMNFOANNMB(NKLELNFFLDK CPHNJLMKMOM, string IKBGKMEDHKI, params object[] BFAMAJEDCBA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NCDMFBJELPL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static PKOIFPADHCA MKCPFKNKNJC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object DFILAGHIFGM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x54A0DE0", Offset = "0x549F7E0", VA = "0x1854A0DE0")]
	private static void PLOMDMBBHOC(NKLELNFFLDK NIAFLHHAIAA, string IKBGKMEDHKI, params object[] BFAMAJEDCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x54A0D20", Offset = "0x549F720", VA = "0x1854A0D20")]
	internal static void CPMGJAKFHDJ(string IKBGKMEDHKI, params object[] BFAMAJEDCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x54A0CC0", Offset = "0x549F6C0", VA = "0x1854A0CC0")]
	internal static void AFBEPEMGJNB(string IKBGKMEDHKI, params object[] BFAMAJEDCBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x54A0D80", Offset = "0x549F780", VA = "0x1854A0D80")]
	internal static void FHKKENMAMDC(string IKBGKMEDHKI, params object[] BFAMAJEDCBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HELLOGKDKCB
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class LGDCCNPEFLC : FENDLGDKDDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private EJEGFFJDIFD MKAIHEHNHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BCHHLBEKOFD ODMNLGLFIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly IMHHCLLBCMN MDLIFHLAEHO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x549E630", Offset = "0x549D030", VA = "0x18549E630")]
	internal LGDCCNPEFLC(BCHHLBEKOFD FHOCAIDBAPC, IMHHCLLBCMN JPJNABHKFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x549E510", Offset = "0x549CF10", VA = "0x18549E510")]
	internal void NEIBOMJMEGI(EJEGFFJDIFD PLIKBMJHGLO, int DIBAKFHNBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x549E580", Offset = "0x549CF80", VA = "0x18549E580")]
	internal void NNKJCMPBEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x549E600", Offset = "0x549D000", VA = "0x18549E600")]
	public void PGDEHKKNLAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class IMHHCLLBCMN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum JGCHONHFLNP
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
	public IMHHCLLBCMN JDJFMHPKACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public JGCHONHFLNP KBCPOJJINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public DKHMDEBGIMI EGADJDCAKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint LENBAGHPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object OGHPPAKELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int INJJLNLPBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError BNJBIGJECFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public KAGMONALHEH CBIHGAKPKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public GKODGNOBJEH MFHPLPEFPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public OCANLLCHEJB LDPHMGIKPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte ACLOBKGCMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly LGDCCNPEFLC NHLEKBNNIAE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x549E470", Offset = "0x549CE70", VA = "0x18549E470")]
	public IMHHCLLBCMN(BCHHLBEKOFD FHOCAIDBAPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BCHHLBEKOFD : IEnumerable<DKHMDEBGIMI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class OGFCAKNBJGM : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x54A1680", Offset = "0x54A0080", VA = "0x1854A1680", Slot = "4")]
		public bool Equals(IPEndPoint MGCANBJCGMI, IPEndPoint MMANNCDCEPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B380", Offset = "0x4F79D80", VA = "0x184F7B380", Slot = "5")]
		public int GetHashCode(IPEndPoint GKNPKJAGNGH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public OGFCAKNBJGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct CBINHEHGAGA : IEnumerator<DKHMDEBGIMI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly DKHMDEBGIMI EHBJPNGPDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private DKHMDEBGIMI KECAGOPAFLH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DKHMDEBGIMI POOCAABBIHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x886ED0", Offset = "0x8858D0", VA = "0x180886ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x886ED0", Offset = "0x8858D0", VA = "0x180886ED0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xE9AAB0", Offset = "0xE994B0", VA = "0x180E9AAB0")]
		public CBINHEHGAGA(DKHMDEBGIMI PGDPOBPBAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5494CA0", Offset = "0x54936A0", VA = "0x185494CA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5494CF0", Offset = "0x54936F0", VA = "0x185494CF0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread NLLIFHPOHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool DEJEAINFHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent PMBACLMPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<IMHHCLLBCMN> BJPANLMLOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<IMHHCLLBCMN> GNNCNFOFMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IMHHCLLBCMN JCLIALEBMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly JLCAJKOLHGA OHFNHFCMCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NJHJBCEJBKG HIOHANNPJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PCIEBJIDFGG ONCMOHDAADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KBJKEOLPIKB ADJBLCPLDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, DKHMDEBGIMI> AFCIIAPHDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, GKODGNOBJEH> BPIJDIBCEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, HIKLNHGAPBO> BMKDNMAHAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim LKHEDNHODLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private DKHMDEBGIMI IHMFKIBIJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GPGJKIDFHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<DKHMDEBGIMI> LKMAMMJBDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private DKHMDEBGIMI[] PFJPHMMDAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly NMIEPDAGDLN NOGLFDIAAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int JEMKEEAHFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> MMKIHIGKIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte DILOPAILBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object POIIKCKJKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool OHEJLPKPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool JAGGDCIDOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int GBGJOIKDOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KHOFLJJOIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int LNEJOIHOCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int MAIIEEIEIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool GPMGCHIIKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MAFNINOBKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GNEMGPMILFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int EDCOLIJMJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int NGDEJNMNOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool CECHMDALLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool DKDNKFJMPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool IFHFFGGHAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool ADIPGHFLEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int OHMKCFMONCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int PJNAAKJBGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EKHEBAFHIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly EFCNMDBBFJI PMKLKKBJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool BCOONJMJGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly IHAMIKGKMHP OAJHLBEOIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LMNJMHCLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public HELLOGKDKCB ANPEGKPDMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int HLBPEHAANIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool BIDOODAKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool DPNKDAOHMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OMFFCBPEDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool BONHGCFDIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private EJEGFFJDIFD NDDONOBMNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int MGHPLJBJEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object MHEOIHJEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private EJEGFFJDIFD BJBJCFFOJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int LJBOLBLLIKB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int BBBKFKCCFKP = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int BAOEIAIMILO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PPGEKAPPNEC FKLICCMKCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PPGEKAPPNEC IGHPHCHNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread BGFEHAIMKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread NIMNLNEOFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint ADNOEPDIKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint NFEJAABAOOE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] AAFIJMJPOJE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] JILJEGHLDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<LHIHENBBEJC, IPEndPoint> FDCLECHLPMO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress ABGAOJPDPGK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool HDPMKMGJPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int CMFPIDIKLEP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JMJJOCFOJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9D4EE0", Offset = "0x9D38E0", VA = "0x1809D4EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA63660", Offset = "0xA62060", VA = "0x180A63660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CDEADLLDIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15577B0", Offset = "0x15561B0", VA = "0x1815577B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x15573F0", Offset = "0x1555DF0", VA = "0x1815573F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte INDPHAPBDKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84ADB0", Offset = "0x8497B0", VA = "0x18084ADB0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KHNLKOGDAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5492560", Offset = "0x5490F60", VA = "0x185492560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short KBIHLOHNNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x548F520", Offset = "0x548DF20", VA = "0x18548F520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5494180", Offset = "0x5492B80", VA = "0x185494180")]
	public void OIGADINENJP(IPEndPoint EIBEDFFKGBE, byte[] FHLJKJHFEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x54927F0", Offset = "0x54911F0", VA = "0x1854927F0")]
	public void KNCBAINNBMP(IPEndPoint EIBEDFFKGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5490480", Offset = "0x548EE80", VA = "0x185490480")]
	private bool FJOHOHAENNK(IPEndPoint EIBEDFFKGBE, [Out] DKHMDEBGIMI GAAFMINIKPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5492940", Offset = "0x5491340", VA = "0x185492940")]
	private void KOMBGNDHAGJ(DKHMDEBGIMI GAAFMINIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5494220", Offset = "0x5492C20", VA = "0x185494220")]
	private void OJKJOGHEDIF(DKHMDEBGIMI GAAFMINIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5492F40", Offset = "0x5491940", VA = "0x185492F40")]
	private void LGHBFJFPBGI(DKHMDEBGIMI GAAFMINIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x54944D0", Offset = "0x5492ED0", VA = "0x1854944D0")]
	public BCHHLBEKOFD(JLCAJKOLHGA PHGMCBKDBHH, [Optional] NMIEPDAGDLN LKNJNBLBDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5492510", Offset = "0x5490F10", VA = "0x185492510")]
	internal void ILGELHMIJMI(DKHMDEBGIMI BNOGIGLHHCJ, int OAMOBJCKMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x548EEB0", Offset = "0x548D8B0", VA = "0x18548EEB0")]
	internal void CKLBGKFGIPJ(DKHMDEBGIMI BNOGIGLHHCJ, object KAPEMEGKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5492580", Offset = "0x5490F80", VA = "0x185492580")]
	internal void KDGODHGFNNN(DKHMDEBGIMI GAAFMINIKPA, KAGMONALHEH OPBOHICBHLE, SocketError MHNLJOLKAEG, EJEGFFJDIFD KMDMCPBDECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x548FBB0", Offset = "0x548E5B0", VA = "0x18548FBB0")]
	private void DLMEBAIOEHN(DKHMDEBGIMI GAAFMINIKPA, KAGMONALHEH OPBOHICBHLE, SocketError MHNLJOLKAEG, bool JAAMGDODLLF, byte[] OBAHLGOPPIK, int OHBFODPGDGE, int MPNHPMPEEBM, EJEGFFJDIFD KMDMCPBDECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x548DB50", Offset = "0x548C550", VA = "0x18548DB50")]
	private void AENLKAAGENF(IMHHCLLBCMN.JGCHONHFLNP AKDFFJNHJJN, [Optional] DKHMDEBGIMI GAAFMINIKPA, [Optional] IPEndPoint HEKEGJLELJB, SocketError NIKHIGGENJG = SocketError.Success, int OAMOBJCKMJG = 0, KAGMONALHEH LLHIIAPKCDE = KAGMONALHEH.ConnectionFailed, [Optional] GKODGNOBJEH OIHAAFANLMF, OCANLLCHEJB FJEBLJKAFPK = OCANLLCHEJB.Unreliable, byte HMJGDPAEADK = 0, [Optional] EJEGFFJDIFD LBBGDAAHBBM, [Optional] object KAPEMEGKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5490510", Offset = "0x548EF10", VA = "0x185490510")]
	private void GCEEAICOGHO(IMHHCLLBCMN JPJNABHKFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x548FC90", Offset = "0x548E690", VA = "0x18548FC90")]
	internal void EMDIEONPMBK(IMHHCLLBCMN JPJNABHKFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5492C00", Offset = "0x5491600", VA = "0x185492C00")]
	private void LFAKKJAKKNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5493500", Offset = "0x5491F00", VA = "0x185493500")]
	private void NDEGKMHPEOI(int IBBAJIMGAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x548EF00", Offset = "0x548D900", VA = "0x18548EF00")]
	internal DKHMDEBGIMI CNIHLOCNGOD(GKODGNOBJEH GOAJPHFIKLF, byte[] JIGDOPHFHPF, int OHBFODPGDGE, int FJADIACPEIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5494270", Offset = "0x5492C70", VA = "0x185494270")]
	private int PCFOGJAFAKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x548F5E0", Offset = "0x548DFE0", VA = "0x18548F5E0")]
	private void DLDEBPDMHOL(IPEndPoint HEKEGJLELJB, DKHMDEBGIMI KJFKCKKIIKG, FMDJOAGKGLE MABCCGNJFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x54915F0", Offset = "0x548FFF0", VA = "0x1854915F0")]
	private void HJGBMBFMCJB(EJEGFFJDIFD PLIKBMJHGLO, IPEndPoint HEKEGJLELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5490050", Offset = "0x548EA50", VA = "0x185490050")]
	internal void FGMIGDIFBOJ(EJEGFFJDIFD PLIKBMJHGLO, OCANLLCHEJB HPFAEJLAJGE, byte HMJGDPAEADK, int DIBAKFHNBCO, DKHMDEBGIMI BNOGIGLHHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5493FE0", Offset = "0x54929E0", VA = "0x185493FE0")]
	public bool NGCMLJIFGEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5493FF0", Offset = "0x54929F0", VA = "0x185493FF0")]
	public bool NGCMLJIFGEC(IPAddress EOCCJMMNDGN, IPAddress IDOAKABCAPK, int JCNKMPFHPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5494010", Offset = "0x5492A10", VA = "0x185494010")]
	public bool NGCMLJIFGEC(int JCNKMPFHPDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x548ED10", Offset = "0x548D710", VA = "0x18548ED10")]
	public void CGMGJHJLNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x54910A0", Offset = "0x548FAA0", VA = "0x1854910A0")]
	public DKHMDEBGIMI GCFJBNHJCMD(string HDOEPEJDOJC, int JCNKMPFHPDH, string FHLJKJHFEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5491180", Offset = "0x548FB80", VA = "0x185491180")]
	public DKHMDEBGIMI GCFJBNHJCMD(string HDOEPEJDOJC, int JCNKMPFHPDH, PNCOIDBAFPJ MNHAIPCCEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5490CD0", Offset = "0x548F6D0", VA = "0x185490CD0")]
	public DKHMDEBGIMI GCFJBNHJCMD(IPEndPoint DMFBOAFMPLH, PNCOIDBAFPJ MNHAIPCCEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x54931A0", Offset = "0x5491BA0", VA = "0x1854931A0")]
	public void LPJFMDFGPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x54931B0", Offset = "0x5491BB0", VA = "0x1854931B0")]
	public void LPJFMDFGPHO(bool AMKELMIJGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x548EA10", Offset = "0x548D410", VA = "0x18548EA10")]
	public void BLECGONHMAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x548EB10", Offset = "0x548D510", VA = "0x18548EB10")]
	public void BLECGONHMAG(byte[] OBAHLGOPPIK, int OHBFODPGDGE, int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x548FB00", Offset = "0x548E500", VA = "0x18548FB00")]
	public void DLMEBAIOEHN(DKHMDEBGIMI GAAFMINIKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x548FA40", Offset = "0x548E440", VA = "0x18548FA40")]
	public void DLMEBAIOEHN(DKHMDEBGIMI GAAFMINIKPA, byte[] OBAHLGOPPIK, int OHBFODPGDGE, int MPNHPMPEEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x54942F0", Offset = "0x5492CF0", VA = "0x1854942F0", Slot = "4")]
	private IEnumerator<DKHMDEBGIMI> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5494380", Offset = "0x5492D80", VA = "0x185494380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5492340", Offset = "0x5490D40", VA = "0x185492340")]
	private EJEGFFJDIFD HMOFHAEDMAJ(GCOIFMGELOJ NPDAMELJOLL, int DDIMFHFNGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5492430", Offset = "0x5490E30", VA = "0x185492430")]
	private EJEGFFJDIFD HMOFHAEDMAJ(GCOIFMGELOJ NPDAMELJOLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x548DF10", Offset = "0x548C910", VA = "0x18548DF10")]
	internal EJEGFFJDIFD ANAKKMIMMDC(int DDIMFHFNGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x548FD90", Offset = "0x548E790", VA = "0x18548FD90")]
	internal void FBKPLOOMLPM(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5494410", Offset = "0x5492E10", VA = "0x185494410")]
	static BCHHLBEKOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x9D4EE0", Offset = "0x9D38E0", VA = "0x1809D4EE0")]
	private bool ILFJJNBKGKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5494090", Offset = "0x5492A90", VA = "0x185494090")]
	private void OAGOPMMPIPJ(IPEndPoint BAALEMNDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x548EC30", Offset = "0x548D630", VA = "0x18548EC30")]
	private void BPJPFLHNNPP(IPEndPoint BAALEMNDMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5492650", Offset = "0x5491050", VA = "0x185492650")]
	private bool KKJFFMEFJLF(SocketException KHDPHPEGJEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x548E740", Offset = "0x548D140", VA = "0x18548E740")]
	private void BIJNNBPCPCP(PPGEKAPPNEC MCBJAKHFHFC, EndPoint DLLIMCKEEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5491260", Offset = "0x548FC60", VA = "0x185491260")]
	private void GPMKLACIEJG(object HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5493820", Offset = "0x5492220", VA = "0x185493820")]
	public bool NGCMLJIFGEC(IPAddress EOCCJMMNDGN, IPAddress IDOAKABCAPK, int JCNKMPFHPDH, bool MEFHNGEGCED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x548FFF0", Offset = "0x548E9F0", VA = "0x18548FFF0")]
	internal int FCGDMLJFCNN(EJEGFFJDIFD PLIKBMJHGLO, IPEndPoint HEKEGJLELJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x548E140", Offset = "0x548CB40", VA = "0x18548E140")]
	internal int APNIHOFNFDK(EJEGFFJDIFD PLIKBMJHGLO, IPEndPoint HEKEGJLELJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x548E180", Offset = "0x548CB80", VA = "0x18548E180")]
	internal int APNIHOFNFDK(byte[] BKNCBJIACBJ, int OHBFODPGDGE, int FJADIACPEIM, IPEndPoint HEKEGJLELJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5490310", Offset = "0x548ED10", VA = "0x185490310")]
	internal void FHNAFGLKOGD(bool PLJOBNCEBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GCOIFMGELOJ : byte
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
internal sealed class EJEGFFJDIFD
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int HCIIIPLOFIG;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] DKOHGEPOENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] CGCCKODLJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int DGFKKGBDDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object OGHPPAKELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public EJEGFFJDIFD JDJFMHPKACE;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GCOIFMGELOJ CKFIJHAIONC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x549A650", Offset = "0x5499050", VA = "0x18549A650")]
		get
		{
			return default(GCOIFMGELOJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x549A850", Offset = "0x5499250", VA = "0x18549A850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte LLDFBAAHHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x549A560", Offset = "0x5498F60", VA = "0x18549A560")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x549A960", Offset = "0x5499360", VA = "0x18549A960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LJOJOFKFPFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x549A900", Offset = "0x5499300", VA = "0x18549A900")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x549A9A0", Offset = "0x54993A0", VA = "0x18549A9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HKLINKEEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x549A400", Offset = "0x5498E00", VA = "0x18549A400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte OMJAFFEPBNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x549A820", Offset = "0x5499220", VA = "0x18549A820")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x549A530", Offset = "0x5498F30", VA = "0x18549A530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CGNBLJANCIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x549A5F0", Offset = "0x5498FF0", VA = "0x18549A5F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x549A8C0", Offset = "0x54992C0", VA = "0x18549A8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JNHKAPNHCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x549A590", Offset = "0x5498F90", VA = "0x18549A590")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x549A680", Offset = "0x5499080", VA = "0x18549A680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort BKLJLENCOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x549A7C0", Offset = "0x54991C0", VA = "0x18549A7C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x549A9E0", Offset = "0x54993E0", VA = "0x18549A9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x549AA20", Offset = "0x5499420", VA = "0x18549AA20")]
	static EJEGFFJDIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x549A890", Offset = "0x5499290", VA = "0x18549A890")]
	public void LAIHOFCMFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x549AD00", Offset = "0x5499700", VA = "0x18549AD00")]
	public EJEGFFJDIFD(int DDIMFHFNGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x549AD70", Offset = "0x5499770", VA = "0x18549AD70")]
	public EJEGFFJDIFD(GCOIFMGELOJ NPDAMELJOLL, int DDIMFHFNGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x549A4C0", Offset = "0x5498EC0", VA = "0x18549A4C0")]
	public static int ACGPPNFMBKE(GCOIFMGELOJ NPDAMELJOLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x549A430", Offset = "0x5498E30", VA = "0x18549A430")]
	public int ACGPPNFMBKE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x549A6C0", Offset = "0x54990C0", VA = "0x18549A6C0")]
	public bool HAJMEFLBFDI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum JGIDHMLOADL : byte
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
internal enum HDOKEGIPNBC
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
internal enum LEELNDLCKND
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum LAMALKBINPB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DKHMDEBGIMI
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class DMPDKMKJOGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public EJEGFFJDIFD[] PMJEKAANDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int CCGCBODNGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int OLHFHMINEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte OMJAFFEPBNB;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public DMPDKMKJOGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void ECHJILMOCHN(ulong KGEKONHBOIG, int PBBEDGPBDKM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int LLCPHJCBHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int BGHPOAIFCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int OJBPNLPFOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double MEHDFHKOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BMOJPANBPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int EHEFEFFBPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int LPMMMPGHELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch LECDKDHJLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int MLMEDPJNINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long AFIBKHHAKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object HMGGMNAEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal DKHMDEBGIMI OKIOKEIHKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal DKHMDEBGIMI PPKAJMFAKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<EJEGFFJDIFD> IAEENPFDEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<IJHAMIHGGPA> AINBCCFFBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly IJHAMIHGGPA[] FHEGIHBMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int GPHDPCMPACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int HCOLHNDHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool PALPBAFMAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int GCBCKIPEEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int HOHDEAEGOHD;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int JDBFOGCDBEO = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int PEKCLMJMPCH = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object HFCDJNBHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CPIJMEKEAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, DMPDKMKJOGB> ENMOHHMBPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> IACCBJKNIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly EJEGFFJDIFD EJDOFJBHLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int JNPJODFHFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int FOLJEAKPHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint BHDFCABAPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IKPGHLFNOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int CFHBNCEIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long HOBLLPMKNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte JJFDMOMEHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private JGIDHMLOADL AIHGMICNJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private EJEGFFJDIFD GJMHLHPNIEP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int IEHPFCHGCPI = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int BPKAOJHALDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EJEGFFJDIFD BJJPBBIIDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly EJEGFFJDIFD NAPAEMDEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly EJEGFFJDIFD PNENOOIBJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly EJEGFFJDIFD PDEAMLLEINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LNMGJLEFJLI ECENDADKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly BCHHLBEKOFD BLFJMJPLCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int MILBLOILOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object DCPEDPINLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly EFCNMDBBFJI PMKLKKBJJOM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte LNCJNDBFKBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA11060", Offset = "0xA0FA60", VA = "0x180A11060")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5497490", Offset = "0x5495E90", VA = "0x185497490")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DIGADEBGIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8C3BA0", Offset = "0x8C25A0", VA = "0x1808C3BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JGIDHMLOADL IAJMAKIECIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1573000", Offset = "0x1571A00", VA = "0x181573000")]
		get
		{
			return default(JGIDHMLOADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long EBMAPKBNKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x79CDE0", Offset = "0x79B7E0", VA = "0x18079CDE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IIJIECKJMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAC66D0", Offset = "0xAC50D0", VA = "0x180AC66D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1395D90", Offset = "0x1394790", VA = "0x181395D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PGNELAOMPHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5495DE0", Offset = "0x54947E0", VA = "0x185495DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NCIDMLGLNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x79F110", Offset = "0x79DB10", VA = "0x18079F110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LBCPHDIKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1743DA0", Offset = "0x17427A0", VA = "0x181743DA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event ECHJILMOCHN CJDMKGKKKDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x54964D0", Offset = "0x5494ED0", VA = "0x1854964D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5496A80", Offset = "0x5495480", VA = "0x185496A80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x54999D0", Offset = "0x54983D0", VA = "0x1854999D0")]
	internal DKHMDEBGIMI(BCHHLBEKOFD OLBEHBHIPJE, IPEndPoint HEKEGJLELJB, int KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5498190", Offset = "0x5496B90", VA = "0x185498190")]
	internal void MFFBKFDCNKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x54988E0", Offset = "0x54972E0", VA = "0x1854988E0")]
	internal void PAKKIPDLFEO(IPEndPoint ECFHHCNFCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5496840", Offset = "0x5495240", VA = "0x185496840")]
	internal void BEHKHHFBBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5496E70", Offset = "0x5495870", VA = "0x185496E70")]
	private void EIOINJACNPE(int NLJEFFKNIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5497540", Offset = "0x5495F40", VA = "0x185497540")]
	private void FJKLEOFDGLB(int KKOGDAEPHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x54968D0", Offset = "0x54952D0", VA = "0x1854968D0")]
	private IJHAMIHGGPA BFOPALDKIMM(byte NBCDDECIMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5499660", Offset = "0x5498060", VA = "0x185499660")]
	internal DKHMDEBGIMI(BCHHLBEKOFD OLBEHBHIPJE, IPEndPoint HEKEGJLELJB, int KABOEEEDCAB, byte CIJIKLONJLJ, PNCOIDBAFPJ OAJKKFJALDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x54997F0", Offset = "0x54981F0", VA = "0x1854997F0")]
	internal DKHMDEBGIMI(BCHHLBEKOFD OLBEHBHIPJE, GKODGNOBJEH GOAJPHFIKLF, int KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5497580", Offset = "0x5495F80", VA = "0x185497580")]
	internal void FKODAIBJEAJ(FMDJOAGKGLE GPAJIPPINFJ, byte[] OBAHLGOPPIK, int OHBFODPGDGE, int FJADIACPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5498860", Offset = "0x5497260", VA = "0x185498860")]
	internal bool OGHIOKHNGMF(AHFGFANDAEP PLIKBMJHGLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x54964A0", Offset = "0x5494EA0", VA = "0x1854964A0")]
	public void AGBOLNHIJKC(byte[] OBAHLGOPPIK, int OHBFODPGDGE, int FJADIACPEIM, OCANLLCHEJB BFKMPGOIOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5496F40", Offset = "0x5495940", VA = "0x185496F40")]
	private void EJADEPEGAEB(byte[] OBAHLGOPPIK, int OHBFODPGDGE, int FJADIACPEIM, byte HMJGDPAEADK, OCANLLCHEJB FJEBLJKAFPK, object KAPEMEGKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x54995B0", Offset = "0x5497FB0", VA = "0x1854995B0")]
	public void POJGPHKBILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5497950", Offset = "0x5496350", VA = "0x185497950")]
	internal LEELNDLCKND JFFEBFFBIOP(EJEGFFJDIFD PLIKBMJHGLO)
	{
		return default(LEELNDLCKND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5496B30", Offset = "0x5495530", VA = "0x185496B30")]
	internal void BMEOMBMAEHL(IJHAMIHGGPA NPLIABJLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x54992A0", Offset = "0x5497CA0", VA = "0x1854992A0")]
	internal LAMALKBINPB PMKHLMFBGCH(byte[] OBAHLGOPPIK, int OHBFODPGDGE, int FJADIACPEIM, bool JAAMGDODLLF)
	{
		return default(LAMALKBINPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5497A30", Offset = "0x5496430", VA = "0x185497A30")]
	private void JNAOGFENGKG(int CCKNPGIBGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5498910", Offset = "0x5497310", VA = "0x185498910")]
	internal void PEMEMOOEMON(OCANLLCHEJB HPFAEJLAJGE, EJEGFFJDIFD PGDPOBPBAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5497C40", Offset = "0x5496640", VA = "0x185497C40")]
	private void KNNIJPDMCCK(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x54975D0", Offset = "0x5495FD0", VA = "0x1854975D0")]
	private void IDMLAAKEAFG(int HNNKCGDCJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5496B90", Offset = "0x5495590", VA = "0x185496B90")]
	internal HDOKEGIPNBC DLDEBPDMHOL(FMDJOAGKGLE MABCCGNJFNE)
	{
		return default(HDOKEGIPNBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x54981B0", Offset = "0x5496BB0", VA = "0x1854981B0")]
	internal void MIDBFKMKEKI(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5496D50", Offset = "0x5495750", VA = "0x185496D50")]
	private void EBIMIALNLOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5497A70", Offset = "0x5496470", VA = "0x185497A70")]
	internal void KLEOJLIMBPL(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5495DF0", Offset = "0x54947F0", VA = "0x185495DF0")]
	internal void ADFCFFECPNL(int HNNKCGDCJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5496580", Offset = "0x5494F80", VA = "0x185496580")]
	internal void AOHCGAGDOBC(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EFCNMDBBFJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long HCMBLLMDJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long BCKCCCEEBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long OGFCMDAJPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long GDNCICDALDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long PPHBNKCDIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long LCJPJJFHHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long FBGOIFPHEBJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long NIGFLEEHNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5499ED0", Offset = "0x54988D0", VA = "0x185499ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long PMBGMBMHFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x549A0A0", Offset = "0x5498AA0", VA = "0x18549A0A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long HNIGHEMFCJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5499FB0", Offset = "0x54989B0", VA = "0x185499FB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long APOOADNACLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5499F20", Offset = "0x5498920", VA = "0x185499F20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MHBMHDPIHCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x549A0B0", Offset = "0x5498AB0", VA = "0x18549A0B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long PLFJINDBMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x549A020", Offset = "0x5498A20", VA = "0x18549A020")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private LNMGJLEFJLI CFPEODAGCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x19A3100", Offset = "0x19A1B00", VA = "0x1819A3100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double MGBLEOEPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5499FC0", Offset = "0x54989C0", VA = "0x185499FC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x549A040", Offset = "0x5498A40", VA = "0x18549A040")]
	public void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5499EF0", Offset = "0x54988F0", VA = "0x185499EF0")]
	public void BMFPPNMHJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5499EE0", Offset = "0x54988E0", VA = "0x185499EE0")]
	public void BJMDACMFHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5499F30", Offset = "0x5498930", VA = "0x185499F30")]
	public void CGNIFKADEHB(long NCMIAMADLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x549A030", Offset = "0x5498A30", VA = "0x18549A030")]
	public void IKOJINBFKOH(long FMKNKFOOKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5499F80", Offset = "0x5498980", VA = "0x185499F80")]
	public void DIFPJHBIEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5499F40", Offset = "0x5498940", VA = "0x185499F40")]
	public void CNLHNIGCNDC(long PGNGFCNPNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x549A0C0", Offset = "0x5498AC0", VA = "0x18549A0C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5499E30", Offset = "0x5498830", VA = "0x185499E30")]
	public void AGKEMANINBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EFCNMDBBFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EOCLFMHOOIH
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> LKGIGPLAACL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x549AE80", Offset = "0x5499880", VA = "0x18549AE80")]
	public static IPEndPoint FFBCLABCBPE(string JLAILJPJAGP, int JCNKMPFHPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x549B0D0", Offset = "0x5499AD0", VA = "0x18549B0D0")]
	public static IPAddress KBBLMPIMKHO(string JLAILJPJAGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x549B2A0", Offset = "0x5499CA0", VA = "0x18549B2A0")]
	public static IPAddress KBBLMPIMKHO(string JLAILJPJAGP, AddressFamily IOPALJANABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x549B330", Offset = "0x5499D30", VA = "0x18549B330")]
	internal static int KEFGMLABCCN(int PGGNNGJLAEL, int OOBBCNDHGMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x24BA510", Offset = "0x24B8F10", VA = "0x1824BA510")]
	internal static T[] PCDMEBAIALP<T>(int MPNHPMPEEBM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CEDCLGPIFLI : IJHAMIHGGPA
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct CAMHKBOMMNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private EJEGFFJDIFD MKAIHEHNHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long BFNKDGIFFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool FFGLKNDCLDJ;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5494C00", Offset = "0x5493600", VA = "0x185494C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5494BE0", Offset = "0x54935E0", VA = "0x185494BE0")]
		public void KKNCHBJCPHM(EJEGFFJDIFD PLIKBMJHGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5494B20", Offset = "0x5493520", VA = "0x185494B20")]
		public bool BNPEKMMBIFN(long OAHMJLCAOEG, DKHMDEBGIMI GAAFMINIKPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5494B90", Offset = "0x5493590", VA = "0x185494B90")]
		public bool JOBLGFAFDNE(DKHMDEBGIMI GAAFMINIKPA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly EJEGFFJDIFD MCNAENKEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly CAMHKBOMMNH[] OMBLJFLIBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly EJEGFFJDIFD[] HNHEJCOHAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] FFEIIFJFDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int ACAJMPGLNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int CBNNJICBPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int HLICNPLBPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int EKOPJGLKNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KEJEFPNCPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly OCANLLCHEJB ODIMGMIJAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool PKCAAMIGJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int KPPPGIOBKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte DAMHGFHPGAL;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5495C10", Offset = "0x5494610", VA = "0x185495C10")]
	public CEDCLGPIFLI(DKHMDEBGIMI GAAFMINIKPA, bool NOENHDCLOOD, byte KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x54951F0", Offset = "0x5493BF0", VA = "0x1854951F0")]
	private void LFCFHCAAEOP(EJEGFFJDIFD PLIKBMJHGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5494D40", Offset = "0x5493740", VA = "0x185494D40", Slot = "4")]
	protected override bool KHNKBBGJBHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x54955B0", Offset = "0x5493FB0", VA = "0x1854955B0", Slot = "5")]
	public override bool MIDBFKMKEKI(EJEGFFJDIFD PLIKBMJHGLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class HJGOAFNPIGB : IJHAMIHGGPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int JLABFPCHIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort CBNNJICBPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool EMFOIFOILFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private EJEGFFJDIFD CNBOEOHEGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly EJEGFFJDIFD AOKBDICOKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool JGKJMGEGJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte DAMHGFHPGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long PINNNBCHFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x549D7A0", Offset = "0x549C1A0", VA = "0x18549D7A0")]
	public HJGOAFNPIGB(DKHMDEBGIMI GAAFMINIKPA, bool FBLMIDDLBKP, byte KABOEEEDCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x549CFF0", Offset = "0x549B9F0", VA = "0x18549CFF0", Slot = "4")]
	protected override bool KHNKBBGJBHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x549D490", Offset = "0x549BE90", VA = "0x18549D490", Slot = "5")]
	public override bool MIDBFKMKEKI(EJEGFFJDIFD PLIKBMJHGLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NPMLLKNAEOL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EPNGDCLAPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong OGAMNAMFONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double JDJEMBHBPLJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct BMGALJFFBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int DHMGCDKFKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float ENKBNOMAKJO;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x548D590", Offset = "0x548BF90", VA = "0x18548D590")]
	private static void FGNKLIPIFGC(byte[] LMJJBGCJLAL, int IACEHNBBCDL, ulong OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x54A1520", Offset = "0x549FF20", VA = "0x1854A1520")]
	private static void FGNKLIPIFGC(byte[] LMJJBGCJLAL, int IACEHNBBCDL, int OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x54A1590", Offset = "0x549FF90", VA = "0x1854A1590")]
	public static void FGNKLIPIFGC(byte[] LMJJBGCJLAL, int IACEHNBBCDL, short OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x54A1660", Offset = "0x54A0060", VA = "0x1854A1660")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, double BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x54A15E0", Offset = "0x549FFE0", VA = "0x1854A15E0")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x54A1590", Offset = "0x549FF90", VA = "0x1854A1590")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, short BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x54A1590", Offset = "0x549FF90", VA = "0x1854A1590")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, ushort BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x54A1520", Offset = "0x549FF20", VA = "0x1854A1520")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, int BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x54A1520", Offset = "0x549FF20", VA = "0x1854A1520")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, uint BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x54A15D0", Offset = "0x549FFD0", VA = "0x1854A15D0")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, long BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x54A15D0", Offset = "0x549FFD0", VA = "0x1854A15D0")]
	public static void GFGLBADANKO(byte[] MCPLLDADFCM, int MGKCHJOOGGA, ulong BEEGCHJLJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FENDLGDKDDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] GJLKFMHOHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int BKBOEDPGEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int ADKEMKOBDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int EELJMMPIJBE;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] CGCCKODLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int MBABOKDBHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GPDPDDHIMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x549B6C0", Offset = "0x549A0C0", VA = "0x18549B6C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IMKNBHHJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1C426A0", Offset = "0x1C410A0", VA = "0x181C426A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EFAIDLOBOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x549B4E0", Offset = "0x5499EE0", VA = "0x18549B4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x549BAE0", Offset = "0x549A4E0", VA = "0x18549BAE0")]
	public void NEIBOMJMEGI(byte[] DMOGDONOGKM, int IACEHNBBCDL, int GLAOHEGFMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public FENDLGDKDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x549BFE0", Offset = "0x549A9E0", VA = "0x18549BFE0")]
	public FENDLGDKDDD(byte[] DMOGDONOGKM, int IACEHNBBCDL, int GLAOHEGFMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x549BF10", Offset = "0x549A910", VA = "0x18549BF10")]
	public IPEndPoint PLDHFIMHFNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x549B770", Offset = "0x549A170", VA = "0x18549B770")]
	public byte LBHLAEOEOCJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x549B770", Offset = "0x549A170", VA = "0x18549B770")]
	public sbyte OPFHBEFHLIB()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25DF860", Offset = "0x25DE260", VA = "0x1825DF860")]
	public T[] BGAHBODGGIM<T>(ushort DDIMFHFNGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x549B3F0", Offset = "0x5499DF0", VA = "0x18549B3F0")]
	public bool[] AHDNFEBJKFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x549BB20", Offset = "0x549A520", VA = "0x18549BB20")]
	public ushort[] NGPLBGNCGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x549B7B0", Offset = "0x549A1B0", VA = "0x18549B7B0")]
	public short[] LFEBKIANKJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x549BE20", Offset = "0x549A820", VA = "0x18549BE20")]
	public int[] PANAMIOGOAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x549B680", Offset = "0x549A080", VA = "0x18549B680")]
	public uint[] GGIGNCHMDAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x549BE60", Offset = "0x549A860", VA = "0x18549BE60")]
	public float[] PDAPICFOKNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x549B640", Offset = "0x549A040", VA = "0x18549B640")]
	public double[] FOOGPFEKOJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x549B6F0", Offset = "0x549A0F0", VA = "0x18549B6F0")]
	public long[] KCHOKJHIFMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x549BB60", Offset = "0x549A560", VA = "0x18549BB60")]
	public ulong[] NLMAFDHHMHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x549B940", Offset = "0x549A340", VA = "0x18549B940")]
	public string[] MPAALOGHDDB(int GOCLJKJBDFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x549B430", Offset = "0x5499E30", VA = "0x18549B430")]
	public bool AHMBPBFNLGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x549B470", Offset = "0x5499E70", VA = "0x18549B470")]
	public char DEJBBIMAKJN()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x549B470", Offset = "0x5499E70", VA = "0x18549B470")]
	public ushort CGINHMEHBNH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x549B8D0", Offset = "0x549A2D0", VA = "0x18549B8D0")]
	public short LOHKDCBABJH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x549B560", Offset = "0x5499F60", VA = "0x18549B560")]
	public long FBIOOKMNGJK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x549BA70", Offset = "0x549A470", VA = "0x18549BA70")]
	public ulong NBLBJAOOBDO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x549B4F0", Offset = "0x5499EF0", VA = "0x18549B4F0")]
	public int EMBPJFKMLMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x549BEA0", Offset = "0x549A8A0", VA = "0x18549BEA0")]
	public uint PGIONLJCDEF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x549B5D0", Offset = "0x5499FD0", VA = "0x18549B5D0")]
	public float FMAANEEEMPA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x549B7F0", Offset = "0x549A1F0", VA = "0x18549B7F0")]
	public double LGDPOIGFONF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x549BBA0", Offset = "0x549A5A0", VA = "0x18549BBA0")]
	public string OGMCCNGEMGD(int EGDOBNLMLOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x549B860", Offset = "0x549A260", VA = "0x18549B860")]
	public ArraySegment<byte> LKNCIANDPMA(int MPNHPMPEEBM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x549BDE0", Offset = "0x549A7E0", VA = "0x18549BDE0")]
	public sbyte[] OIINCNFCCHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x549B730", Offset = "0x549A130", VA = "0x18549B730")]
	public byte[] KGLHONANAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x549B6D0", Offset = "0x549A0D0", VA = "0x18549B6D0")]
	public void JOBLGFAFDNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PNCOIDBAFPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] GJLKFMHOHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int BKBOEDPGEBN;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int OICOFAAMAEI = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool LJMEAEOHCAM;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding DLIHDBCBDNC;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int FJHEFJPECGJ = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] IBLGLOLCLFF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] KGACILCCGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PPDKOADJGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x54A37B0", Offset = "0x54A21B0", VA = "0x1854A37B0")]
	public PNCOIDBAFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x54A3830", Offset = "0x54A2230", VA = "0x1854A3830")]
	public PNCOIDBAFPJ(bool BGNCDNFELNN, int DPJNPPKPAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x54A3050", Offset = "0x54A1A50", VA = "0x1854A3050")]
	public static PNCOIDBAFPJ GJNGPDFCBEH(string BEEGCHJLJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x54A2FB0", Offset = "0x54A19B0", VA = "0x1854A2FB0")]
	public void DIBAHDFCNHP(int CNMCHNAHALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1CBBFB0", Offset = "0x1CBA9B0", VA = "0x181CBBFB0")]
	public void JGPBMMKLMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x54A3560", Offset = "0x54A1F60", VA = "0x1854A3560")]
	public void HEBBLJDOPEN(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x54A3600", Offset = "0x54A2000", VA = "0x1854A3600")]
	public void HEBBLJDOPEN(double BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x54A33D0", Offset = "0x54A1DD0", VA = "0x1854A33D0")]
	public void HEBBLJDOPEN(long BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x54A33D0", Offset = "0x54A1DD0", VA = "0x1854A33D0")]
	public void HEBBLJDOPEN(ulong BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x54A3120", Offset = "0x54A1B20", VA = "0x1854A3120")]
	public void HEBBLJDOPEN(int BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x54A3120", Offset = "0x54A1B20", VA = "0x1854A3120")]
	public void HEBBLJDOPEN(uint BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x54A34F0", Offset = "0x54A1EF0", VA = "0x1854A34F0")]
	public void HEBBLJDOPEN(char BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x54A34F0", Offset = "0x54A1EF0", VA = "0x1854A34F0")]
	public void HEBBLJDOPEN(ushort BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x54A34F0", Offset = "0x54A1EF0", VA = "0x1854A34F0")]
	public void HEBBLJDOPEN(short BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x54A30C0", Offset = "0x54A1AC0", VA = "0x1854A30C0")]
	public void HEBBLJDOPEN(sbyte BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x54A30C0", Offset = "0x54A1AC0", VA = "0x1854A30C0")]
	public void HEBBLJDOPEN(byte BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x54A36B0", Offset = "0x54A20B0", VA = "0x1854A36B0")]
	public void HEBBLJDOPEN(byte[] OBAHLGOPPIK, int IACEHNBBCDL, int FJADIACPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x54A2ED0", Offset = "0x54A18D0", VA = "0x1854A2ED0")]
	public void KGIBEDOJMKC(sbyte[] OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x54A2ED0", Offset = "0x54A18D0", VA = "0x1854A2ED0")]
	public void LBLIACJGLNL(byte[] OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x54A3650", Offset = "0x54A2050", VA = "0x1854A3650")]
	public void HEBBLJDOPEN(bool BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x54A2B60", Offset = "0x54A1560", VA = "0x1854A2B60")]
	public void CDHNCINIGDC(Array PDKNOJBNIFO, int BJEAHDHHJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x54A2DF0", Offset = "0x54A17F0", VA = "0x1854A2DF0")]
	public void CDHNCINIGDC(float[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54A2A80", Offset = "0x54A1480", VA = "0x1854A2A80")]
	public void CDHNCINIGDC(double[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x54A2A80", Offset = "0x54A1480", VA = "0x1854A2A80")]
	public void CDHNCINIGDC(long[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x54A2A80", Offset = "0x54A1480", VA = "0x1854A2A80")]
	public void CDHNCINIGDC(ulong[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x54A2DF0", Offset = "0x54A17F0", VA = "0x1854A2DF0")]
	public void CDHNCINIGDC(int[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x54A2DF0", Offset = "0x54A17F0", VA = "0x1854A2DF0")]
	public void CDHNCINIGDC(uint[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x54A2C40", Offset = "0x54A1640", VA = "0x1854A2C40")]
	public void CDHNCINIGDC(ushort[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x54A2C40", Offset = "0x54A1640", VA = "0x1854A2C40")]
	public void CDHNCINIGDC(short[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x54A2ED0", Offset = "0x54A18D0", VA = "0x1854A2ED0")]
	public void CDHNCINIGDC(bool[] BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x54A2D20", Offset = "0x54A1720", VA = "0x1854A2D20")]
	public void CDHNCINIGDC(string[] BEEGCHJLJFC, int NIAGNPOGFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x54A3420", Offset = "0x54A1E20", VA = "0x1854A3420")]
	public void HEBBLJDOPEN(IPEndPoint EIBEDFFKGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x54A31B0", Offset = "0x54A1BB0", VA = "0x1854A31B0")]
	public void HEBBLJDOPEN(string BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x54A31C0", Offset = "0x54A1BC0", VA = "0x1854A31C0")]
	public void HEBBLJDOPEN(string BEEGCHJLJFC, int EGDOBNLMLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NKHKCGMKFCE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DFOGJFBBIKO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong MILBLOILOEA;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4F5CE90", Offset = "0x4F5B890", VA = "0x184F5CE90")]
		static DFOGJFBBIKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void OLJHCECGEBG(FENDLGDKDDD HPEAJCENMCM, object KAPEMEGKCFG);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NAMBOCIJNOK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public NKHKCGMKFCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public NAMBOCIJNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3E354D0", Offset = "0x3E33ED0", VA = "0x183E354D0")]
		internal void CEAAHHGHABO(FENDLGDKDDD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GAKJBIBMLKH<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NKHKCGMKFCE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public GAKJBIBMLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x36971C0", Offset = "0x3695BC0", VA = "0x1836971C0")]
		internal void CEAAHHGHABO(FENDLGDKDDD reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly AAOLKICILIG PDFBEIIJNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, OLJHCECGEBG> MBMCGFLAIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly PNCOIDBAFPJ ICHMNDABGAP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x54A13A0", Offset = "0x549FDA0", VA = "0x1854A13A0")]
	public NKHKCGMKFCE(int GOCLJKJBDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x23BBD30", Offset = "0x23BA730", VA = "0x1823BBD30", Slot = "4")]
	protected virtual ulong PHLHKABKECK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x54A1270", Offset = "0x549FC70", VA = "0x1854A1270", Slot = "5")]
	protected virtual OLJHCECGEBG PDEDLPMPLFG(FENDLGDKDDD HPEAJCENMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27484D0", Offset = "0x2746ED0", VA = "0x1827484D0", Slot = "6")]
	protected virtual void COABPDDCBIG<T>(PNCOIDBAFPJ HAMBOEKDHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54A11A0", Offset = "0x549FBA0", VA = "0x1854A11A0")]
	public void DMBDAGNHKAD(FENDLGDKDDD HPEAJCENMCM, object KAPEMEGKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2748840", Offset = "0x2747240", VA = "0x182748840")]
	public void MEADCPKNNFG<T>(PNCOIDBAFPJ HAMBOEKDHKF, T PLIKBMJHGLO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x54A1220", Offset = "0x549FC20", VA = "0x1854A1220")]
	public void EADMAKPNGNH(FENDLGDKDDD HPEAJCENMCM, object KAPEMEGKCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27486C0", Offset = "0x27470C0", VA = "0x1827486C0")]
	public void JLHMGAOEMBF<T>(Action<T> PKNNGJDPAKK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2748540", Offset = "0x2746F40", VA = "0x182748540")]
	public void JLHMGAOEMBF<T, TUserData>(Action<T, TUserData> PKNNGJDPAKK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IEONIOFINHL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x549D860", Offset = "0x549C260", VA = "0x18549D860")]
	public IEONIOFINHL(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FHOBEOLPPAN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x549C040", Offset = "0x549AA40", VA = "0x18549C040")]
	public FHOBEOLPPAN(string BKNCBJIACBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class AAOLKICILIG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LLMINNAOAEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BAKJGECAECN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LLMINNAOAEE KBCPOJJINMM;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x46DDEE0", Offset = "0x46DC8E0", VA = "0x1846DDEE0", Slot = "4")]
		public virtual void KKNCHBJCPHM(MethodInfo KPMHEOLFEJF, MethodInfo JGLGDFKHKLL, LLMINNAOAEE AKDFFJNHJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MDLGFIPHLBB(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LNENIOAOEHN(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		protected BAKJGECAECN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CJDAKPJHDAE<TClass, TProperty> : BAKJGECAECN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> IEKPDBOGMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> MHIOIJMBPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> PKOGPEEJJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> LAIJNDICGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> HPFFELNOMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> NNGCIMHIAEI;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4CA60F0", Offset = "0x4CA4AF0", VA = "0x184CA60F0", Slot = "7")]
		public override void EGOBIDHFHAG(TClass DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4CA5750", Offset = "0x4CA4150", VA = "0x184CA5750", Slot = "8")]
		public override void BPAJFMKKNKL(TClass DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4CAC1B0", Offset = "0x4CAABB0", VA = "0x184CAC1B0", Slot = "9")]
		public override void MDLGFIPHLBB(TClass DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB8F0", Offset = "0x4CAA2F0", VA = "0x184CAB8F0", Slot = "10")]
		public override void LNENIOAOEHN(TClass DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4CA6390", Offset = "0x4CA4D90", VA = "0x184CA6390")]
		protected TProperty[] FIMMMEKPIDN(TClass DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4CA4C60", Offset = "0x4CA3660", VA = "0x184CA4C60")]
		protected TProperty[] BBINMEPJKBP(TClass DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4CA9850", Offset = "0x4CA8250", VA = "0x184CA9850", Slot = "4")]
		public override void KKNCHBJCPHM(MethodInfo KPMHEOLFEJF, MethodInfo JGLGDFKHKLL, LLMINNAOAEE AKDFFJNHJJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3A03C70", Offset = "0x3A02670", VA = "0x183A03C70")]
		protected CJDAKPJHDAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class PNKLIPGENAO<TClass, TProperty> : CJDAKPJHDAE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void HMMCPHIMPLB(FENDLGDKDDD HJICGNIAELL, [Out] TProperty ANGCHNLANFH);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OABAHPINCBF(PNCOIDBAFPJ JNEGICJFFGC, TProperty ANGCHNLANFH);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x40A5450", Offset = "0x40A3E50", VA = "0x1840A5450", Slot = "5")]
		public override void DFBALIAHHGL(TClass DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x40A5690", Offset = "0x40A4090", VA = "0x1840A5690", Slot = "6")]
		public override void MEADCPKNNFG(TClass DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x40A55F0", Offset = "0x40A3FF0", VA = "0x1840A55F0", Slot = "7")]
		public override void EGOBIDHFHAG(TClass DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x40A5310", Offset = "0x40A3D10", VA = "0x1840A5310", Slot = "8")]
		public override void BPAJFMKKNKL(TClass DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3241C80", Offset = "0x3240680", VA = "0x183241C80")]
		protected PNKLIPGENAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class CCKNKHKEBGG<T> : CJDAKPJHDAE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4AF88B0", Offset = "0x4AF72B0", VA = "0x184AF88B0", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B466F0", Offset = "0x3B450F0", VA = "0x183B466F0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4AF8920", Offset = "0x4AF7320", VA = "0x184AF8920", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3793EC0", Offset = "0x37928C0", VA = "0x183793EC0", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public CCKNKHKEBGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class KOLIAANBOCC<T> : CJDAKPJHDAE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3B46610", Offset = "0x3B45010", VA = "0x183B46610", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3B466F0", Offset = "0x3B450F0", VA = "0x183B466F0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3B46680", Offset = "0x3B45080", VA = "0x183B46680", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3793EC0", Offset = "0x37928C0", VA = "0x183793EC0", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public KOLIAANBOCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class MKELPHPCACG<T> : CJDAKPJHDAE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA600", Offset = "0x3DE9000", VA = "0x183DEA600", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA6E0", Offset = "0x3DE90E0", VA = "0x183DEA6E0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA670", Offset = "0x3DE9070", VA = "0x183DEA670", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA5A0", Offset = "0x3DE8FA0", VA = "0x183DEA5A0", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public MKELPHPCACG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NOPIJOFDIAH<T> : CJDAKPJHDAE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EBACF0", Offset = "0x3EB96F0", VA = "0x183EBACF0", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA6E0", Offset = "0x3DE90E0", VA = "0x183DEA6E0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EBAD60", Offset = "0x3EB9760", VA = "0x183EBAD60", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA5A0", Offset = "0x3DE8FA0", VA = "0x183DEA5A0", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public NOPIJOFDIAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class ECKGOGPBMDC<T> : CJDAKPJHDAE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3233C80", Offset = "0x3232680", VA = "0x183233C80", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3233D60", Offset = "0x3232760", VA = "0x183233D60", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3233CF0", Offset = "0x32326F0", VA = "0x183233CF0", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3233C20", Offset = "0x3232620", VA = "0x183233C20", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public ECKGOGPBMDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class MCHGDEPPOKH<T> : CJDAKPJHDAE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBD20", Offset = "0x3DCA720", VA = "0x183DCBD20", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3233D60", Offset = "0x3232760", VA = "0x183233D60", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBD90", Offset = "0x3DCA790", VA = "0x183DCBD90", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3233C20", Offset = "0x3232620", VA = "0x183233C20", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public MCHGDEPPOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AEMDMGFOGLN<T> : CJDAKPJHDAE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x36685C0", Offset = "0x3666FC0", VA = "0x1836685C0", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x36686A0", Offset = "0x36670A0", VA = "0x1836686A0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3668630", Offset = "0x3667030", VA = "0x183668630", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3668560", Offset = "0x3666F60", VA = "0x183668560", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public AEMDMGFOGLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class JJOCMLBHKNF<T> : CJDAKPJHDAE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x36685C0", Offset = "0x3666FC0", VA = "0x1836685C0", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x36686A0", Offset = "0x36670A0", VA = "0x1836686A0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A345E0", Offset = "0x3A32FE0", VA = "0x183A345E0", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3668560", Offset = "0x3666F60", VA = "0x183668560", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public JJOCMLBHKNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class HPDMNMFKOGG<T> : CJDAKPJHDAE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3793F20", Offset = "0x3792920", VA = "0x183793F20", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3794000", Offset = "0x3792A00", VA = "0x183794000", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3793F90", Offset = "0x3792990", VA = "0x183793F90", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3793EC0", Offset = "0x37928C0", VA = "0x183793EC0", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public HPDMNMFKOGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PGEMADGGMOL<T> : CJDAKPJHDAE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4093670", Offset = "0x4092070", VA = "0x184093670", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4093750", Offset = "0x4092150", VA = "0x184093750", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x40936E0", Offset = "0x40920E0", VA = "0x1840936E0", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3233C20", Offset = "0x3232620", VA = "0x183233C20", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public PGEMADGGMOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class IJCBMLELODC<T> : CJDAKPJHDAE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3844F10", Offset = "0x3843910", VA = "0x183844F10", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3844FF0", Offset = "0x38439F0", VA = "0x183844FF0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3844F80", Offset = "0x3843980", VA = "0x183844F80", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3668560", Offset = "0x3666F60", VA = "0x183668560", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3233DC0", Offset = "0x32327C0", VA = "0x183233DC0")]
		public IJCBMLELODC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FIDLDHDFHMB<T> : PNKLIPGENAO<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x35C1DF0", Offset = "0x35C07F0", VA = "0x1835C1DF0", Slot = "12")]
		protected override void OABAHPINCBF(PNCOIDBAFPJ JNEGICJFFGC, char ANGCHNLANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x35C1DC0", Offset = "0x35C07C0", VA = "0x1835C1DC0", Slot = "11")]
		protected override void HMMCPHIMPLB(FENDLGDKDDD HJICGNIAELL, [Out] char ANGCHNLANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		public FIDLDHDFHMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class KAEOIEENGID<T> : PNKLIPGENAO<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A95AD0", Offset = "0x3A944D0", VA = "0x183A95AD0", Slot = "12")]
		protected override void OABAHPINCBF(PNCOIDBAFPJ JNEGICJFFGC, IPEndPoint ANGCHNLANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A95A90", Offset = "0x3A94490", VA = "0x183A95A90", Slot = "11")]
		protected override void HMMCPHIMPLB(FENDLGDKDDD HJICGNIAELL, [Out] IPEndPoint ANGCHNLANFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x326D010", Offset = "0x326BA10", VA = "0x18326D010")]
		public KAEOIEENGID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class PNMCGBACFFD<T> : CJDAKPJHDAE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int NKEHJEDMNJO;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x40A5930", Offset = "0x40A4330", VA = "0x1840A5930")]
		public PNMCGBACFFD(int EGDOBNLMLOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40A57E0", Offset = "0x40A41E0", VA = "0x1840A57E0", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x40A58C0", Offset = "0x40A42C0", VA = "0x1840A58C0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x40A5850", Offset = "0x40A4250", VA = "0x1840A5850", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x40A5770", Offset = "0x40A4170", VA = "0x1840A5770", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BLPCFMIGEAH<T> : BAKJGECAECN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo CKFIJHAIONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type KDHEMCMKEHN;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4813590", Offset = "0x4811F90", VA = "0x184813590")]
		public BLPCFMIGEAH(PropertyInfo NPDAMELJOLL, Type FKDJHPAJFEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4813300", Offset = "0x4811D00", VA = "0x184813300", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x48134E0", Offset = "0x4811EE0", VA = "0x1848134E0", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x48133C0", Offset = "0x4811DC0", VA = "0x1848133C0", Slot = "7")]
		public override void EGOBIDHFHAG(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x48132A0", Offset = "0x4811CA0", VA = "0x1848132A0", Slot = "8")]
		public override void BPAJFMKKNKL(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4813480", Offset = "0x4811E80", VA = "0x184813480", Slot = "9")]
		public override void MDLGFIPHLBB(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4813420", Offset = "0x4811E20", VA = "0x184813420", Slot = "10")]
		public override void LNENIOAOEHN(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FHOOLJACDBK<T> : BLPCFMIGEAH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3231EA0", Offset = "0x32308A0", VA = "0x183231EA0")]
		public FHOOLJACDBK(PropertyInfo NPDAMELJOLL, Type FKDJHPAJFEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x35C1870", Offset = "0x35C0270", VA = "0x1835C1870", Slot = "5")]
		public override void DFBALIAHHGL(T DJNICMGJOON, FENDLGDKDDD HJICGNIAELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x35C1930", Offset = "0x35C0330", VA = "0x1835C1930", Slot = "6")]
		public override void MEADCPKNNFG(T DJNICMGJOON, PNCOIDBAFPJ JNEGICJFFGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class NABGKKHOKDF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static NABGKKHOKDF<T> KHPIFBDMEAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly BAKJGECAECN<T>[] PAJINJONGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int MHFJDIFIJNH;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E35430", Offset = "0x3E33E30", VA = "0x183E35430")]
		public NABGKKHOKDF(List<BAKJGECAECN<T>> CLOFMFOBOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E35380", Offset = "0x3E33D80", VA = "0x183E35380")]
		public void MEADCPKNNFG(T GKNPKJAGNGH, PNCOIDBAFPJ HAMBOEKDHKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E352D0", Offset = "0x3E33CD0", VA = "0x183E352D0")]
		public void DFBALIAHHGL(T GKNPKJAGNGH, FENDLGDKDDD HPEAJCENMCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class KNHABHOGHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BAKJGECAECN<T> DKMKPEOPLDE<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private PNCOIDBAFPJ JEHKJHDCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int JGGEEMNAKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, KNHABHOGHLH> AAMAENPAGIG;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x548D720", Offset = "0x548C120", VA = "0x18548D720")]
	public AAOLKICILIG(int GOCLJKJBDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D520", Offset = "0x2C2BF20", VA = "0x182C2D520")]
	private NABGKKHOKDF<T> INAOBOHCHGM<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x23ACA00", Offset = "0x23AB400", VA = "0x1823ACA00")]
	public void COHNJNIDPMK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C2D4A0", Offset = "0x2C2BEA0", VA = "0x182C2D4A0")]
	public bool DCJJDHFPDEL<T>(FENDLGDKDDD HPEAJCENMCM, T DMFBOAFMPLH) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C2E410", Offset = "0x2C2CE10", VA = "0x182C2E410")]
	public void JLKDILEIJOC<T>(PNCOIDBAFPJ HAMBOEKDHKF, T GKNPKJAGNGH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OMHOHPCAANJ
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime PCFEDHPOFDI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] FNKFEPPGFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CLIEAOCGKFJ LNAEFAAEOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x54A2560", Offset = "0x54A0F60", VA = "0x1854A2560")]
		get
		{
			return default(CLIEAOCGKFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OFIPKOKMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x54A1A80", Offset = "0x54A0480", VA = "0x1854A1A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x54A1CB0", Offset = "0x54A06B0", VA = "0x1854A1CB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BBCEPCNDOLD NBLOOFOANDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x54A17C0", Offset = "0x54A01C0", VA = "0x1854A17C0")]
		get
		{
			return default(BBCEPCNDOLD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x54A16F0", Offset = "0x54A00F0", VA = "0x1854A16F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PHDNJLEAJML
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x54A2410", Offset = "0x54A0E10", VA = "0x1854A2410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint AMANHCBOKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x54A1D20", Offset = "0x54A0720", VA = "0x1854A1D20")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? DCNNMEOBBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x54A19C0", Offset = "0x54A03C0", VA = "0x1854A19C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KNNJABJLJAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x54A1CF0", Offset = "0x54A06F0", VA = "0x1854A1CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? FFOLMMGCCNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x54A1A50", Offset = "0x54A0450", VA = "0x1854A1A50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x54A17F0", Offset = "0x54A01F0", VA = "0x1854A17F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? ABAHDGJJOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA30D40", Offset = "0xA2F740", VA = "0x180A30D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x890B90", Offset = "0x88F590", VA = "0x180890B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x54A2760", Offset = "0x54A1160", VA = "0x1854A2760")]
	public OMHOHPCAANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x54A26B0", Offset = "0x54A10B0", VA = "0x1854A26B0")]
	internal OMHOHPCAANJ(byte[] MCPLLDADFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x54A2440", Offset = "0x54A0E40", VA = "0x1854A2440")]
	public static OMHOHPCAANJ PCJNCILNHFB(byte[] MCPLLDADFCM, DateTime HENHDNLJHIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x54A1AB0", Offset = "0x54A04B0", VA = "0x1854A1AB0")]
	internal void IBAGHJPPNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x54A1FA0", Offset = "0x54A09A0", VA = "0x1854A1FA0")]
	private void NPHNHJCNAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x54A1DA0", Offset = "0x54A07A0", VA = "0x1854A1DA0")]
	private DateTime? KNILMKBGICE(int IACEHNBBCDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x54A2240", Offset = "0x54A0C40", VA = "0x1854A2240")]
	private void PAIJOBNCFPD(int IACEHNBBCDL, DateTime? BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54A2170", Offset = "0x54A0B70", VA = "0x1854A2170")]
	private ulong OLKCLOOPBOA(int IACEHNBBCDL)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x54A2590", Offset = "0x54A0F90", VA = "0x1854A2590")]
	private void PMEBMAEMPFP(int IACEHNBBCDL, ulong BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x54A1730", Offset = "0x54A0130", VA = "0x1854A1730")]
	private uint CDBCCEOCPLO(int IACEHNBBCDL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x537D330", Offset = "0x537BD30", VA = "0x18537D330")]
	private static uint DMIOKBHPNCN(uint MGCANBJCGMI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x54A19F0", Offset = "0x54A03F0", VA = "0x1854A19F0")]
	private static ulong DMIOKBHPNCN(ulong MGCANBJCGMI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CLIEAOCGKFJ
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
public enum BBCEPCNDOLD
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HIKLNHGAPBO
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int FIHLHOFNCEM = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int LBOMOHOIEAI = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int NGNJNKEEMHB = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint PHFLNBHDDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int MCJACCHINBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int AGCGGMKDMAP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MLLPKNBILJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x549CFE0", Offset = "0x549B9E0", VA = "0x18549CFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x549CEF0", Offset = "0x549B8F0", VA = "0x18549CEF0")]
	public bool AGBOLNHIJKC(PPGEKAPPNEC MCBJAKHFHFC, int AFJGHIJFDOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class FKFKKHAJDOK : PPGEKAPPNEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket MCBJAKHFHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BCHHLBEKOFD OLBEHBHIPJE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short KBIHLOHNNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x549C100", Offset = "0x549AB00", VA = "0x18549C100", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int CCDAJKICBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x549C120", Offset = "0x549AB20", VA = "0x18549C120", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint GAKBGKCJBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x549C700", Offset = "0x549B100", VA = "0x18549C700", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily CAHJBELMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BAA320", Offset = "0x3BA8D20", VA = "0x183BAA320", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x549C810", Offset = "0x549B210", VA = "0x18549C810")]
	public FKFKKHAJDOK(AddressFamily IOPALJANABM, BCHHLBEKOFD OLBEHBHIPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x549C140", Offset = "0x549AB40", VA = "0x18549C140", Slot = "8")]
	public bool FIKBKOPLEFO(IPEndPoint EIBEDFFKGBE, HELLOGKDKCB NNNLIPALNCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x549C0A0", Offset = "0x549AAA0", VA = "0x18549C0A0", Slot = "9")]
	public int AJDOJEOJDKN(byte[] LMJJBGCJLAL, int IACEHNBBCDL, int DDIMFHFNGHG, IPEndPoint HEKEGJLELJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x549C720", Offset = "0x549B120", VA = "0x18549C720", Slot = "10")]
	public int OMCNJDIGAEP(byte[] LMJJBGCJLAL, EndPoint LHJMHHJMADO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x549C0E0", Offset = "0x549AAE0", VA = "0x18549C0E0", Slot = "11")]
	public void BEKNJAJKGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface PPGEKAPPNEC
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short KBIHLOHNNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int CCDAJKICBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint GAKBGKCJBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily CAHJBELMJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FIKBKOPLEFO(IPEndPoint EIBEDFFKGBE, HELLOGKDKCB NNNLIPALNCN);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int AJDOJEOJDKN(byte[] LMJJBGCJLAL, int IACEHNBBCDL, int DDIMFHFNGHG, IPEndPoint HEKEGJLELJB);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OMCNJDIGAEP(byte[] LMJJBGCJLAL, EndPoint HEKEGJLELJB);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BEKNJAJKGCF();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct LHIHENBBEJC : IEquatable<LHIHENBBEJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long DMJLIDHHOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long KGNCGNAGFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long BLDLBBMDDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int BBGBGOPGPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int DOBOPFALCNP;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x549E770", Offset = "0x549D170", VA = "0x18549E770")]
	public LHIHENBBEJC(byte[] HDOEPEJDOJC, int IBLNGJPPNON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7B7DC0", Offset = "0x7B67C0", VA = "0x1807B7DC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x549E680", Offset = "0x549D080", VA = "0x18549E680", Slot = "4")]
	public bool Equals(LHIHENBBEJC CGDFJMJIABO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x549E6C0", Offset = "0x549D0C0", VA = "0x18549E6C0", Slot = "0")]
	public override bool Equals(object GKNPKJAGNGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class CBNJICFDPCG : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] ONLPLNCACJB;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class NMIEPDAGDLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int KHNLKOGDAIH;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x794E20", Offset = "0x793820", VA = "0x180794E20")]
	protected NMIEPDAGDLN(int ELDPAFABJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EBEICAPAMHH(IPEndPoint EIBEDFFKGBE, byte[] OBAHLGOPPIK, int IACEHNBBCDL, int FJADIACPEIM);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NLINOAMKJDM(IPEndPoint EIBEDFFKGBE, byte[] OBAHLGOPPIK, int IACEHNBBCDL, int FJADIACPEIM);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MACCGPJIBNB : NMIEPDAGDLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider BMCOHIKHKNK;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator BFDMLPEHFAP;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x54A0CA0", Offset = "0x549F6A0", VA = "0x1854A0CA0")]
	public MACCGPJIBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x54A01D0", Offset = "0x549EBD0", VA = "0x1854A01D0")]
	public void CKECKHHOLJC(IPEndPoint EIBEDFFKGBE, byte[] FHLJKJHFEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x54A00F0", Offset = "0x549EAF0", VA = "0x1854A00F0")]
	public void BEEAOCFNNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x54A0060", Offset = "0x549EA60", VA = "0x1854A0060")]
	private byte[] APLOAGLMFLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x54A0410", Offset = "0x549EE10", VA = "0x1854A0410", Slot = "4")]
	public override void EBEICAPAMHH(IPEndPoint EIBEDFFKGBE, byte[] OBAHLGOPPIK, int IACEHNBBCDL, int FJADIACPEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x54A08A0", Offset = "0x549F2A0", VA = "0x1854A08A0", Slot = "5")]
	public override void NLINOAMKJDM(IPEndPoint EIBEDFFKGBE, byte[] OBAHLGOPPIK, int IACEHNBBCDL, int FJADIACPEIM)
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
