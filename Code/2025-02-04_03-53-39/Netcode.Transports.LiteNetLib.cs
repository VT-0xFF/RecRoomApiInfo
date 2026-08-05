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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BGGCLJIPPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum OJCKDJBKFKJ
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
		private NetworkManager JODEHPMKNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, NILFFKBDMAH> HDOJPFDOJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NIAGDHJGDNP CBHFMDFFDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] NOCPPIIEMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OJCKDJBKFKJ JIPDPFGCKDH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong GCMLJOCFELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OJAGHMJHFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x65FD570", Offset = "0x65FC370", VA = "0x1865FD570", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x65FCB50", Offset = "0x65FB950", VA = "0x1865FCB50")]
		public void RecRoom_SetEncryptionInfo(ulong BMBKIBBMJEM, byte[] FFOHLCGHDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x65FCB30", Offset = "0x65FB930", VA = "0x1865FCB30")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65FC920", Offset = "0x65FB720", VA = "0x1865FC920")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65FD470", Offset = "0x65FC270", VA = "0x1865FD470")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65FCC70", Offset = "0x65FBA70", VA = "0x1865FCC70", Slot = "6")]
		public override void Send(ulong DEKOGMDJDDJ, ArraySegment<byte> JOAPLPPIFPC, NetworkDelivery LGAJJCEPOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x65FCAF0", Offset = "0x65FB8F0", VA = "0x1865FCAF0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DEKOGMDJDDJ, [Out] ArraySegment<byte> KGDIEBJBNPG, [Out] float FBLMAHFHJNA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65FCF60", Offset = "0x65FBD60", VA = "0x1865FCF60", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65FD390", Offset = "0x65FC190", VA = "0x1865FD390", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65FC160", Offset = "0x65FAF60", VA = "0x1865FC160", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DEKOGMDJDDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65FC070", Offset = "0x65FAE70", VA = "0x1865FC070", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65FC550", Offset = "0x65FB350", VA = "0x1865FC550", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DEKOGMDJDDJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x65FCEF0", Offset = "0x65FBCF0", VA = "0x1865FCEF0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x65FC650", Offset = "0x65FB450", VA = "0x1865FC650", Slot = "14")]
		public override void Initialize([Optional] NetworkManager JODEHPMKNOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65FC270", Offset = "0x65FB070", VA = "0x1865FC270")]
		private OLBIKBAJCMG EGEGAPIFCGG(NetworkDelivery OBDHBADPJNM)
		{
			return default(OLBIKBAJCMG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65FC810", Offset = "0x65FB610", VA = "0x1865FC810", Slot = "15")]
		private void JCBOGIBCDCG(NILFFKBDMAH OMLCHDGLMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x65FBFB0", Offset = "0x65FADB0", VA = "0x1865FBFB0", Slot = "16")]
		private void BNKNMPMAENP(NILFFKBDMAH OMLCHDGLMLH, BMLKKEJPKAM AHKINAHGIBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "17")]
		private void NDIBJIFDKFH(IPEndPoint GHCCKKBLGIG, SocketError APDKDHLEANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65FC340", Offset = "0x65FB140", VA = "0x1865FC340", Slot = "18")]
		private void FNNGMGDEPPC(NILFFKBDMAH OMLCHDGLMLH, HJDLCNGFIMK GGBMOFKDHMN, byte IPPLHFHEGNL, OLBIKBAJCMG IGOFCCIENBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65FCA10", Offset = "0x65FB810", VA = "0x1865FCA10")]
		private void PDJKEMHNBFL(int IECADCKMGOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "19")]
		private void KJMNLEDHMII(IPEndPoint IADNGEJPALM, HJDLCNGFIMK GGBMOFKDHMN, DIKDJBHGGJN KKIOHACJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "20")]
		private void ADOJIFHILJL(NILFFKBDMAH OMLCHDGLMLH, int MGJBMLPGILC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65FC5F0", Offset = "0x65FB3F0", VA = "0x1865FC5F0", Slot = "21")]
		private void HCKJIKJGJEB(CGMBDKKDBNO HJFGAIAKKLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65FC8F0", Offset = "0x65FB6F0", VA = "0x1865FC8F0")]
		private ulong OOBLNOHNMPG(NILFFKBDMAH OMLCHDGLMLH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65FC8D0", Offset = "0x65FB6D0", VA = "0x1865FC8D0")]
		private static int LKIHMIFNKJI(float CIOLBCCFHKE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65FD490", Offset = "0x65FC290", VA = "0x1865FD490")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class AJAHFCHMMJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NILFFKBDMAH NBLDDANDOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<GCEBFBELFHH> LFFKBNKGBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HKPONDPAJEO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65F3B20", Offset = "0x65F2920", VA = "0x1865F3B20")]
	protected AJAHFCHMMJP(NILFFKBDMAH OMLCHDGLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65F3AC0", Offset = "0x65F28C0", VA = "0x1865F3AC0")]
	public void OEOMKOPHHDM(GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65F3A00", Offset = "0x65F2800", VA = "0x1865F3A00")]
	protected void AKBGBFJLMEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65F3A80", Offset = "0x65F2880", VA = "0x1865F3A80")]
	public bool NEFDMNNNONC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool IFGFGEBNHBN();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GHCBGPLJNPE(GCEBFBELFHH GHEOJFFKDGB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KOKLFNIBOHE
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
public class CGMBDKKDBNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NIAGDHJGDNP FFJEHPBLDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int LFJGGLKMCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CFMOHIFIJOJ KHCBMDCEPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint HPOFCFPLKND;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KOKLFNIBOHE MCGKLNEDEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x91E390", Offset = "0x91D190", VA = "0x18091E390")]
		[CompilerGenerated]
		get
		{
			return default(KOKLFNIBOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC11180", Offset = "0xC0FF80", VA = "0x180C11180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65F4F90", Offset = "0x65F3D90", VA = "0x1865F4F90")]
	internal void KCOFMPBMAEK(CFMOHIFIJOJ MJBEMJPKMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65F4F00", Offset = "0x65F3D00", VA = "0x1865F4F00")]
	private bool BFLDJFHAPLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65F4FF0", Offset = "0x65F3DF0", VA = "0x1865F4FF0")]
	internal CGMBDKKDBNO(IPEndPoint IADNGEJPALM, CFMOHIFIJOJ LFFKOEAGADG, NIAGDHJGDNP DJDAKCILPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65F4F30", Offset = "0x65F3D30", VA = "0x1865F4F30")]
	public NILFFKBDMAH GNICPOACNNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DIKDJBHGGJN
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GNLMGJOKDLP
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
public struct BMLKKEJPKAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GNLMGJOKDLP MMHNAPJHLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BOCGMCAPIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HJDLCNGFIMK IJGHGCLHINE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BGGCLJIPPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCENIJJIFCF(NILFFKBDMAH OMLCHDGLMLH);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KODICAMCPEH(NILFFKBDMAH OMLCHDGLMLH, BMLKKEJPKAM AHKINAHGIBD);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLFDEKFPGFN(IPEndPoint GHCCKKBLGIG, SocketError APDKDHLEANI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPJCEDAHMFI(NILFFKBDMAH OMLCHDGLMLH, HJDLCNGFIMK GGBMOFKDHMN, byte IPPLHFHEGNL, OLBIKBAJCMG IGOFCCIENBC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAEIIGPJGCL(IPEndPoint IADNGEJPALM, HJDLCNGFIMK GGBMOFKDHMN, DIKDJBHGGJN KKIOHACJCNE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PPJENPJCDKK(NILFFKBDMAH OMLCHDGLMLH, int MGJBMLPGILC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ELIBJNGPMEJ(CGMBDKKDBNO HJFGAIAKKLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DBHIOJALLHF
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBJJDCDPGAB(NILFFKBDMAH OMLCHDGLMLH, object OGGEJOHOGGN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HFDIPONMGEB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLBCAOFBNDB(LIMENKBEBJN GHEOJFFKDGB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MJLFAEBCLBC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGBLCHPBGJJ(NILFFKBDMAH OMLCHDGLMLH, IPEndPoint LAEIGFIPCOI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class CFMOHIFIJOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int DHKEGPBBAJG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long NMJPEIEHOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte PBENEPEFDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] JNDHCOLFJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly BILADOAKOAG COGAKILOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int JMGGCGHCDIA;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65F4E90", Offset = "0x65F3C90", VA = "0x1865F4E90")]
	private CFMOHIFIJOJ(long MOIBEGDNHEK, byte EAHMPBBCIJF, int ADODGOLJGFP, byte[] GNFFJNKFLOE, BILADOAKOAG JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65F4A30", Offset = "0x65F3830", VA = "0x1865F4A30")]
	public static int BPMCOPHFDOM(GCEBFBELFHH GHEOJFFKDGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x65F4A90", Offset = "0x65F3890", VA = "0x1865F4A90")]
	public static CFMOHIFIJOJ HAAGHLEEBJE(GCEBFBELFHH GHEOJFFKDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x65F4CB0", Offset = "0x65F3AB0", VA = "0x1865F4CB0")]
	public static GCEBFBELFHH OOGGPNIKKIE(DFHMBPOKAIH BGCDPBPKCCL, SocketAddress JPEDDLBCJFO, long EDNOBBILKGI, int ADODGOLJGFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HCGKLBGHNAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long NMJPEIEHOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte PBENEPEFDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int JMGGCGHCDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool POMKLKGOJGG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x65F7D60", Offset = "0x65F6B60", VA = "0x1865F7D60")]
	private HCGKLBGHNAJ(long MOIBEGDNHEK, byte EAHMPBBCIJF, int ILJHKFGBOOO, bool KFJKNBNPFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65F7B20", Offset = "0x65F6920", VA = "0x1865F7B20")]
	public static HCGKLBGHNAJ HAAGHLEEBJE(GCEBFBELFHH GHEOJFFKDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65F7C70", Offset = "0x65F6A70", VA = "0x1865F7C70")]
	public static GCEBFBELFHH OOGGPNIKKIE(long EDNOBBILKGI, byte BCNAFMNBDIA, int PENCBBNBCAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65F7A20", Offset = "0x65F6820", VA = "0x1865F7A20")]
	public static GCEBFBELFHH EBPHPFKDDPB(NILFFKBDMAH OMLCHDGLMLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum ACBGCLIONCE
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NBHLLEJFLPO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKCOGLGMOML(IPEndPoint PKCIEKPKHNB, IPEndPoint IADNGEJPALM, string HACFGBHNOCC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHIAEGBOHFE(IPEndPoint GALMADCNNEL, ACBGCLIONCE OBDHBADPJNM, string HACFGBHNOCC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PJPNFMHIGNK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MFHHGAHOLPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint IOBKEGNAGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint HPOFCFPLKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string PGMDPJPDGIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct ONIIIDLMPKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint BEOEPKIFIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ACBGCLIONCE LPNEJLDPBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string PGMDPJPDGIO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class ECCIMFNJENB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint EPCBJPINEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string PGMDPJPDGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ECCIMFNJENB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PPIJHLFHGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint EPCBJPINEMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint PFHJOIDBCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string PGMDPJPDGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PPIJHLFHGHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class AKDEJENBCEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PGMDPJPDGIO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JEAGHFEJOOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8FE800", Offset = "0x8FD600", VA = "0x1808FE800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AKDEJENBCEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NIAGDHJGDNP CCBFEIFBHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<MFHHGAHOLPE> CGGGDABIIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<ONIIIDLMPKB> DBJCMGOGHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BILADOAKOAG IJGEDGCDNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DFHMBPOKAIH PFNPDFAODCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JNIGLOEPCKM KJPCBHDHKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NBHLLEJFLPO AAFOOBAFBII;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LJJDBGONEDF = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DMAJDBGFIHD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x660A8A0", Offset = "0x66096A0", VA = "0x18660A8A0")]
	internal PJPNFMHIGNK(NIAGDHJGDNP LGNONKPKKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x660A2B0", Offset = "0x66090B0", VA = "0x18660A2B0")]
	internal void AAECOBADPFB(IPEndPoint FCLIDAMDJGJ, GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34A2750", Offset = "0x34A1550", VA = "0x1834A2750")]
	private void LPEMHFLBMBD<T>(T GHEOJFFKDGB, IPEndPoint OBIPBFFAILK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x660A590", Offset = "0x6609390", VA = "0x18660A590")]
	private void GKCOGLGMOML(ECCIMFNJENB MCPCIAMCAKL, IPEndPoint FCLIDAMDJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x660A430", Offset = "0x6609230", VA = "0x18660A430")]
	private void CFBKKBPABLG(PPIJHLFHGHJ MCPCIAMCAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x660A710", Offset = "0x6609510", VA = "0x18660A710")]
	private void IKLHOICHJNO(AKDEJENBCEH MCPCIAMCAKL, IPEndPoint FCLIDAMDJGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum OLBIKBAJCMG : byte
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
public enum ADGJMCBJGMP : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HBPPCGKECMP
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] AMFKJPMEAMB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int KHCFDCCPLCL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HHIIOHGECDC;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DLNIEIEBAPO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65F6930", Offset = "0x65F5730", VA = "0x1865F6930")]
	public DLNIEIEBAPO(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FMLFKMBMDJF : DLNIEIEBAPO
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65F6930", Offset = "0x65F5730", VA = "0x1865F6930")]
	public FMLFKMBMDJF(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CDEOBGGAFMP
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
public interface EJBKHBBBJGP
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNGIAAFMIFG(CDEOBGGAFMP HODEHKGMDDA, string MBNPKKJMDHG, params object[] EHEEIKICBAM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GKHGLEHNHDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static EJBKHBBBJGP FNLDAALNKHA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object GOKFAPMLDEG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x65F7480", Offset = "0x65F6280", VA = "0x1865F7480")]
	private static void KPEJPPDMDDA(CDEOBGGAFMP BGHCADGDJOL, string MBNPKKJMDHG, params object[] EHEEIKICBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x65F76B0", Offset = "0x65F64B0", VA = "0x1865F76B0")]
	internal static void MCNGLNIGPBC(string MBNPKKJMDHG, params object[] EHEEIKICBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x65F7420", Offset = "0x65F6220", VA = "0x1865F7420")]
	internal static void ECNKLPCADJJ(string MBNPKKJMDHG, params object[] EHEEIKICBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x65F73C0", Offset = "0x65F61C0", VA = "0x1865F73C0")]
	internal static void AFHILJCNFBJ(string MBNPKKJMDHG, params object[] EHEEIKICBAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum OGFDHDGCIAL
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HJDLCNGFIMK : BILADOAKOAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private GCEBFBELFHH BCANNHMCKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly NIAGDHJGDNP FJIEBOEACFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DCBCPCCLDKM EOHPBLABAAE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x65F7ED0", Offset = "0x65F6CD0", VA = "0x1865F7ED0")]
	internal HJDLCNGFIMK(NIAGDHJGDNP HLDNIAJEGKP, DCBCPCCLDKM GIDKEBKJBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65F7E30", Offset = "0x65F6C30", VA = "0x1865F7E30")]
	internal void GFJHFPABKCJ(GCEBFBELFHH GHEOJFFKDGB, int ONLCJOMHFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x65F7DB0", Offset = "0x65F6BB0", VA = "0x1865F7DB0")]
	internal void FHNIKFLCLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65F7EA0", Offset = "0x65F6CA0", VA = "0x1865F7EA0")]
	public void OADOOOPEEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class DCBCPCCLDKM
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum ELHMABBMIJH
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
	public DCBCPCCLDKM HGAKFPEEOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public ELHMABBMIJH LPNEJLDPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NILFFKBDMAH NBLDDANDOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint HPOFCFPLKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object DLCFDNAMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int JJICNLHNNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError ELFGBEIOONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public GNLMGJOKDLP KFHCGCOABKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public CGMBDKKDBNO CDLAPMEEKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public OLBIKBAJCMG ADCPAGNLLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte KCOLPBCFFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HJDLCNGFIMK ACDKMJJLCFL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65F5A40", Offset = "0x65F4840", VA = "0x1865F5A40")]
	public DCBCPCCLDKM(NIAGDHJGDNP HLDNIAJEGKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NIAGDHJGDNP : IEnumerable<NILFFKBDMAH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class PABLJNGJNJL : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x660A240", Offset = "0x6609040", VA = "0x18660A240", Slot = "4")]
		public bool Equals(IPEndPoint LBONEMFCDEA, IPEndPoint IOKFBHNPJAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6137F30", Offset = "0x6136D30", VA = "0x186137F30", Slot = "5")]
		public int GetHashCode(IPEndPoint JOOHPPHJKMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PABLJNGJNJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct AIHHBJPBOLP : IEnumerator<NILFFKBDMAH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly NILFFKBDMAH ICMLCMDOHON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NILFFKBDMAH HIHAEANNJHC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NILFFKBDMAH ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC534D0", Offset = "0xC522D0", VA = "0x180C534D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC534D0", Offset = "0xC522D0", VA = "0x180C534D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x17BC480", Offset = "0x17BB280", VA = "0x1817BC480")]
		public AIHHBJPBOLP(NILFFKBDMAH HLIJNINJIMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65F3960", Offset = "0x65F2760", VA = "0x1865F3960", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65F39B0", Offset = "0x65F27B0", VA = "0x1865F39B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread NFBMHJNCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool FIPIAALHBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent LBNOIEAJNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<DCBCPCCLDKM> ENFCBPHJONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<DCBCPCCLDKM> KOCNKLFAGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private DCBCPCCLDKM AOPBDOKCLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BGGCLJIPPLJ NGLGDJKIEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly DBHIOJALLHF DIABHOMKJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HFDIPONMGEB LILKLGDFLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MJLFAEBCLBC PCGFMBIJOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, NILFFKBDMAH> NFOCHFHHHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, CGMBDKKDBNO> OODPJENDCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, NKBMHFJPMMD> FHHIEMLBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim LEPOJIHPNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NILFFKBDMAH CDIPCALFAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int PPPIDHEMJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NILFFKBDMAH> HBCKMHINPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NILFFKBDMAH[] CPLKHPDCFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GNADBKLDENN LOFLBDKGDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int CGLNMEKLAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> KKFDDAKHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte PGCMNKBGDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object JJLANLKCDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool GNMDPBBFLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool CMKEPBNBKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LJFHJOCMEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int GOCLCNBEHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int FOOOENNGCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GPGOGABJDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool HMNEHOPAOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool IKEPKNKEIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JJNMPNDCCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DFAFGALHCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int GFGOGKJLDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DMAJDBGFIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool KMMKJKCGGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool POHJCKEECJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool LNJFMPDFJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int PKMFAOMADIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int OEMCJFGJPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EHGEHKKFEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly DBHCFENBMCL GPLLMKEOJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool EKGFGEBIOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly PJPNFMHIGNK BFELFGNJKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool OGHHADAPENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public OGFDHDGCIAL IGPOFGLPMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int FCCNCJAFLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool LPCMFMGNPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool POLJIJGDHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool EBFOPOANBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool OEOIKPECDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private GCEBFBELFHH OMGBGGOBJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int CLGEBBHMKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object GNGCAFLDHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private GCEBFBELFHH KIKBNHJANIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MLJJPDKGGFP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int KMFOGEJFCOJ = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int PHHGJHCJMAD = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IDOCMNIOIEL CLNDBAPPDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private IDOCMNIOIEL KGCBAIEAHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DBDFBIMNNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread AOAKEAPCKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint CMFODCAMIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint NFDDBLOBEBN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] DMOOAEFGIBA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] EHHEJGCEEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<CKMGKKCOPOD, IPEndPoint> BFGFCIGDEOI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress KMMBJAGFKHG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool HGKFHIDDHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int ECLBKJHEFAI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool INEEGELCNIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12F1070", Offset = "0x12EFE70", VA = "0x1812F1070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x12F0BC0", Offset = "0x12EF9C0", VA = "0x1812F0BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OHAKGODNMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1DF1A60", Offset = "0x1DF0860", VA = "0x181DF1A60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2087A80", Offset = "0x2086880", VA = "0x182087A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte NGACCIHIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB54330", Offset = "0xB53130", VA = "0x180B54330")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MIGJLFGACIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6603EE0", Offset = "0x6602CE0", VA = "0x186603EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short MIGEACCBNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6603390", Offset = "0x6602190", VA = "0x186603390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6604DC0", Offset = "0x6603BC0", VA = "0x186604DC0")]
	public void ONEJGHMMMJG(IPEndPoint GHCCKKBLGIG, byte[] FFOHLCGHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65FF8B0", Offset = "0x65FE6B0", VA = "0x1865FF8B0")]
	public void EIEFOPGMBMC(IPEndPoint GHCCKKBLGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6601F30", Offset = "0x6600D30", VA = "0x186601F30")]
	private bool GOECAMDPCAL(IPEndPoint GHCCKKBLGIG, [Out] NILFFKBDMAH OMLCHDGLMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6602D40", Offset = "0x6601B40", VA = "0x186602D40")]
	private void KDGOJAGDGNI(NILFFKBDMAH OMLCHDGLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x65FF690", Offset = "0x65FE490", VA = "0x1865FF690")]
	private void DIPJPHDJKBE(NILFFKBDMAH OMLCHDGLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6601FC0", Offset = "0x6600DC0", VA = "0x186601FC0")]
	private void HKMJDABKAIC(NILFFKBDMAH OMLCHDGLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x66051C0", Offset = "0x6603FC0", VA = "0x1866051C0")]
	public NIAGDHJGDNP(BGGCLJIPPLJ DJDAKCILPLD, [Optional] GNADBKLDENN PEKHFHDAOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x65FEAE0", Offset = "0x65FD8E0", VA = "0x1865FEAE0")]
	internal void BIGKHOCHOLK(NILFFKBDMAH JIIAMPAIKDI, int MGJBMLPGILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6603340", Offset = "0x6602140", VA = "0x186603340")]
	internal void KNMFCFHLBKC(NILFFKBDMAH JIIAMPAIKDI, object OGGEJOHOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6602A00", Offset = "0x6601800", VA = "0x186602A00")]
	internal void IGFHHBBMCNH(NILFFKBDMAH OMLCHDGLMLH, GNLMGJOKDLP ADJDIHDFFBH, SocketError GAEOOKPILKD, GCEBFBELFHH NEPCFFIOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x65FDD90", Offset = "0x65FCB90", VA = "0x1865FDD90")]
	private void AILPDAGFJHG(NILFFKBDMAH OMLCHDGLMLH, GNLMGJOKDLP ADJDIHDFFBH, SocketError GAEOOKPILKD, bool MKKNPGPEIPF, byte[] JOAPLPPIFPC, int EBKPEOBONHB, int BMGBDLLODJK, GCEBFBELFHH NEPCFFIOLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6603B00", Offset = "0x6602900", VA = "0x186603B00")]
	private void NDMGDDOKKBF(DCBCPCCLDKM.ELHMABBMIJH OBDHBADPJNM, [Optional] NILFFKBDMAH OMLCHDGLMLH, [Optional] IPEndPoint IADNGEJPALM, SocketError INHEKIONAPA = SocketError.Success, int MGJBMLPGILC = 0, GNLMGJOKDLP MBHHMALNANA = GNLMGJOKDLP.ConnectionFailed, [Optional] CGMBDKKDBNO AOFJFHAKIMH, OLBIKBAJCMG IGOFCCIENBC = OLBIKBAJCMG.Unreliable, byte IPPLHFHEGNL = 0, [Optional] GCEBFBELFHH GNCMJKOHJBE, [Optional] object OGGEJOHOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6601440", Offset = "0x6600240", VA = "0x186601440")]
	private void FHLAKJDOGNH(DCBCPCCLDKM GIDKEBKJBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6604CB0", Offset = "0x6603AB0", VA = "0x186604CB0")]
	internal void OELBLAKLHJF(DCBCPCCLDKM GIDKEBKJBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6601BF0", Offset = "0x66009F0", VA = "0x186601BF0")]
	private void GCJPJKLKFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6603020", Offset = "0x6601E20", VA = "0x186603020")]
	private void KJOMMFGADOH(int DNDMILLKNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6602230", Offset = "0x6601030", VA = "0x186602230")]
	internal NILFFKBDMAH ICMIEBDKANM(CGMBDKKDBNO HJFGAIAKKLJ, byte[] JOHIDJNGDHE, int EBKPEOBONHB, int AIIKLGOLFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6602B50", Offset = "0x6601950", VA = "0x186602B50")]
	private int ILOHBBDNJLA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65FF1E0", Offset = "0x65FDFE0", VA = "0x1865FF1E0")]
	private void DAFKKEMPBIG(IPEndPoint IADNGEJPALM, NILFFKBDMAH MJJGPDGNHIA, CFMOHIFIJOJ OMMFJAGIEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6600060", Offset = "0x65FEE60", VA = "0x186600060")]
	private void FHEHIGBGHLM(GCEBFBELFHH GHEOJFFKDGB, IPEndPoint IADNGEJPALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66049D0", Offset = "0x66037D0", VA = "0x1866049D0")]
	internal void OEDLMKNCPCH(GCEBFBELFHH GHEOJFFKDGB, OLBIKBAJCMG FGIGJEMMGAB, byte IPPLHFHEGNL, int ONLCJOMHFJD, NILFFKBDMAH JIIAMPAIKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66049A0", Offset = "0x66037A0", VA = "0x1866049A0")]
	public bool ODCOABNFDHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x66049B0", Offset = "0x66037B0", VA = "0x1866049B0")]
	public bool ODCOABNFDHI(IPAddress ALCKNFAKANA, IPAddress PFFHCCHILDH, int BDPAHNFLHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6604920", Offset = "0x6603720", VA = "0x186604920")]
	public bool ODCOABNFDHI(int BDPAHNFLHBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6602850", Offset = "0x6601650", VA = "0x186602850")]
	public void IFILNPHDNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x65FE770", Offset = "0x65FD570", VA = "0x1865FE770")]
	public NILFFKBDMAH APDOJNBHPMF(string FPFPCKOIAOK, int BDPAHNFLHBO, string FFOHLCGHDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x65FE850", Offset = "0x65FD650", VA = "0x1865FE850")]
	public NILFFKBDMAH APDOJNBHPMF(string FPFPCKOIAOK, int BDPAHNFLHBO, DFHMBPOKAIH IKJKLBPFKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x65FE3A0", Offset = "0x65FD1A0", VA = "0x1865FE3A0")]
	public NILFFKBDMAH APDOJNBHPMF(IPEndPoint OBIPBFFAILK, DFHMBPOKAIH IKJKLBPFKDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x65FEE80", Offset = "0x65FDC80", VA = "0x1865FEE80")]
	public void BIPLBHKIMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x65FEB30", Offset = "0x65FD930", VA = "0x1865FEB30")]
	public void BIPLBHKIMPL(bool MCIJADNLNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6602C90", Offset = "0x6601A90", VA = "0x186602C90")]
	public void JGODALGGBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6602BD0", Offset = "0x66019D0", VA = "0x186602BD0")]
	public void JGODALGGBLF(byte[] JOAPLPPIFPC, int EBKPEOBONHB, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x65FE1F0", Offset = "0x65FCFF0", VA = "0x1865FE1F0")]
	public void AILPDAGFJHG(NILFFKBDMAH OMLCHDGLMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x65FE1B0", Offset = "0x65FCFB0", VA = "0x1865FE1B0")]
	public void AILPDAGFJHG(NILFFKBDMAH OMLCHDGLMLH, byte[] JOAPLPPIFPC, int EBKPEOBONHB, int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6604FE0", Offset = "0x6603DE0", VA = "0x186604FE0", Slot = "4")]
	private IEnumerator<NILFFKBDMAH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6605070", Offset = "0x6603E70", VA = "0x186605070", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x65FF6E0", Offset = "0x65FE4E0", VA = "0x1865FF6E0")]
	private GCEBFBELFHH EAGMHNCDBGP(LHJPOCIGCNN AMBDMECJFHI, int IECADCKMGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x65FF7D0", Offset = "0x65FE5D0", VA = "0x1865FF7D0")]
	private GCEBFBELFHH EAGMHNCDBGP(LHJPOCIGCNN AMBDMECJFHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x65FEF90", Offset = "0x65FDD90", VA = "0x1865FEF90")]
	internal GCEBFBELFHH COMGDKEEGOM(int IECADCKMGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6603F00", Offset = "0x6602D00", VA = "0x186603F00")]
	internal void OAGKEALCNGJ(GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6605100", Offset = "0x6603F00", VA = "0x186605100")]
	static NIAGDHJGDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12F1070", Offset = "0x12EFE70", VA = "0x1812F1070")]
	private bool KPNNPKOKIEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6602A40", Offset = "0x6601840", VA = "0x186602A40")]
	private void IJMLOLFJCCN(IPEndPoint KLGINMENGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x65FEE90", Offset = "0x65FDC90", VA = "0x1865FEE90")]
	private void BPIBKJINFOP(IPEndPoint KLGINMENGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x65FE930", Offset = "0x65FD730", VA = "0x1865FE930")]
	private bool BFGLABKMJFL(SocketException JGLOLGKKBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6603450", Offset = "0x6602250", VA = "0x186603450")]
	private void MIHIJNPEEKG(IDOCMNIOIEL LGNONKPKKNF, EndPoint LAOLLHICKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6603770", Offset = "0x6602570", VA = "0x186603770")]
	private void MOOIECGLJOD(object DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6604170", Offset = "0x6602F70", VA = "0x186604170")]
	public bool ODCOABNFDHI(IPAddress ALCKNFAKANA, IPAddress PFFHCCHILDH, int BDPAHNFLHBO, bool AGDAAPACMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6603710", Offset = "0x6602510", VA = "0x186603710")]
	internal int MKFPLNFJLFB(GCEBFBELFHH GHEOJFFKDGB, IPEndPoint IADNGEJPALM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6600020", Offset = "0x65FEE20", VA = "0x186600020")]
	internal int EMEGJIHEMPN(GCEBFBELFHH GHEOJFFKDGB, IPEndPoint IADNGEJPALM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x65FFA00", Offset = "0x65FE800", VA = "0x1865FFA00")]
	internal int EMEGJIHEMPN(byte[] KKBJAPCBOHH, int EBKPEOBONHB, int AIIKLGOLFIK, IPEndPoint IADNGEJPALM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x65FE230", Offset = "0x65FD030", VA = "0x1865FE230")]
	internal void AJJFJAPGDKD(bool LLMNILOLHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LHJPOCIGCNN : byte
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
internal sealed class GCEBFBELFHH
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int PCBLCEFDJNB;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] JCGPEAOIOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] DNFJLBEBJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int JCGPAOIEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object DLCFDNAMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public GCEBFBELFHH HGAKFPEEOJK;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LHJPOCIGCNN FKJEHBJEJAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x65F6CA0", Offset = "0x65F5AA0", VA = "0x1865F6CA0")]
		get
		{
			return default(LHJPOCIGCNN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x65F69E0", Offset = "0x65F57E0", VA = "0x1865F69E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte PBENEPEFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x65F6C30", Offset = "0x65F5A30", VA = "0x1865F6C30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x65F6EC0", Offset = "0x65F5CC0", VA = "0x1865F6EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort ACBNJBJPOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x65F6D00", Offset = "0x65F5B00", VA = "0x1865F6D00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x65F6C60", Offset = "0x65F5A60", VA = "0x1865F6C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FFFMLFPAHND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x65F6BC0", Offset = "0x65F59C0", VA = "0x1865F6BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte ODFJEIJAJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65F6CD0", Offset = "0x65F5AD0", VA = "0x1865F6CD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x65F6E90", Offset = "0x65F5C90", VA = "0x1865F6E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CHJONBCMPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65F6B20", Offset = "0x65F5920", VA = "0x1865F6B20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65F6B80", Offset = "0x65F5980", VA = "0x1865F6B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort GGOMDMMAKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65F6940", Offset = "0x65F5740", VA = "0x1865F6940")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65F69A0", Offset = "0x65F57A0", VA = "0x1865F69A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort AOCMADGBIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x65F6F00", Offset = "0x65F5D00", VA = "0x1865F6F00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x65F6BF0", Offset = "0x65F59F0", VA = "0x1865F6BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65F6F60", Offset = "0x65F5D60", VA = "0x1865F6F60")]
	static GCEBFBELFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65F6D60", Offset = "0x65F5B60", VA = "0x1865F6D60")]
	public void NGCOONBFBPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x65F7240", Offset = "0x65F6040", VA = "0x1865F7240")]
	public GCEBFBELFHH(int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65F72B0", Offset = "0x65F60B0", VA = "0x1865F72B0")]
	public GCEBFBELFHH(LHJPOCIGCNN AMBDMECJFHI, int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x65F6AB0", Offset = "0x65F58B0", VA = "0x1865F6AB0")]
	public static int FFOGIGFIALK(LHJPOCIGCNN AMBDMECJFHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x65F6A20", Offset = "0x65F5820", VA = "0x1865F6A20")]
	public int FFOGIGFIALK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x65F6D90", Offset = "0x65F5B90", VA = "0x1865F6D90")]
	public bool OECIGILDCGL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum JEONHIOHFPL : byte
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
internal enum BJOLOLOEFAI
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
internal enum ECOMJHEAJPA
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum MPPPDOFMJFO
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NILFFKBDMAH
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class KLILNEDGBJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public GCEBFBELFHH[] BHKGJEBMGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int PNHFMGKLEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int MKNBDEHLAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte ODFJEIJAJGG;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public KLILNEDGBJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void IMPEIAJCCPI(ulong MMKHLIDIJPL, int ALPKONHMOIK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int ACKBGJOLJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int BPEJBEEJNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int PMKAAJNJGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double IIMGBMJEDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BLDCAGOIBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int AHKLBFCHOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int KMIDIOAFHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch MAHDFBEDPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FFCIODCJKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long GNHLBCCKCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object HMGODKDAODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal NILFFKBDMAH HKLLOMEBFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal NILFFKBDMAH GJHNCKDNBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<GCEBFBELFHH> DKIODCCLJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<AJAHFCHMMJP> KHFCGAKMCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly AJAHFCHMMJP[] AMBHCLJGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int CPAGHKGLOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int LKHKHKIODLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool MGEIDGFEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int AFEJCOALHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int EFBJKLPAFJM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int IJMJOJEDNJI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int HPPNKAAMIDD = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object IEJGOPMJHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int GPJKEBHDOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, KLILNEDGBJK> DNLEJMCFHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CCIAMBILDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly GCEBFBELFHH BHFMKFEJPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int JNNDOBBDKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int LDPBIPJKKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint KFMLANGJGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int MNCBMGDALPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int PDGEPEFNIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long CDHIMDFDEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte OEMBCILCMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private JEONHIOHFPL LEOMHODLGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private GCEBFBELFHH MFDIKOENNNJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int GGGIIGPEAJD = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int PEDNPLGGIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GCEBFBELFHH PBOIGOBFNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly GCEBFBELFHH HBPJEENNONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly GCEBFBELFHH GFPFABIMKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly GCEBFBELFHH FJFFEBJPIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private ADGJMCBJGMP ANCCBOHFENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly NIAGDHJGDNP DLLLCIHCMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int OFAGBBGFDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object FJLHKMHMACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly DBHCFENBMCL GPLLMKEOJFG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte MJODAJDLIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AD7A0", Offset = "0x9AC5A0", VA = "0x1809AD7A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x66085C0", Offset = "0x66073C0", VA = "0x1866085C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint BIPAGGMJDCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB86D40", Offset = "0xB85B40", VA = "0x180B86D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JEONHIOHFPL BECEAEDOIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA67B50", Offset = "0xA66950", VA = "0x180A67B50")]
		get
		{
			return default(JEONHIOHFPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long JOJKAOHHLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x904780", Offset = "0x903580", VA = "0x180904780")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GHNPGJAHLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1331A30", Offset = "0x1330830", VA = "0x181331A30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F520", Offset = "0x1C0E320", VA = "0x181C0F520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JNDLDJPAEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x66069C0", Offset = "0x66057C0", VA = "0x1866069C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int OJJLKMCLGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x905060", Offset = "0x903E60", VA = "0x180905060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double JFJFNGALAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5620140", Offset = "0x561EF40", VA = "0x185620140")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IMPEIAJCCPI NOMMOOAPJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6608510", Offset = "0x6607310", VA = "0x186608510")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6606A10", Offset = "0x6605810", VA = "0x186606A10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x66092F0", Offset = "0x66080F0", VA = "0x1866092F0")]
	internal NILFFKBDMAH(NIAGDHJGDNP FHPLDANHGOC, IPEndPoint IADNGEJPALM, int MIFPCBFGGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x66061B0", Offset = "0x6604FB0", VA = "0x1866061B0")]
	internal void AILGMDHAHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x66086A0", Offset = "0x66074A0", VA = "0x1866086A0")]
	internal void NAJIMDDNAJI(IPEndPoint APGANNKAELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6607820", Offset = "0x6606620", VA = "0x186607820")]
	internal void HKHNCPJJCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66068F0", Offset = "0x66056F0", VA = "0x1866068F0")]
	private void EEAIHOALFKO(int LFFMGJFIGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x66069D0", Offset = "0x66057D0", VA = "0x1866069D0")]
	private void EOBLMBLCAPK(int IPKJDMPMJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6608F60", Offset = "0x6607D60", VA = "0x186608F60")]
	private AJAHFCHMMJP PNGKBOBBDJM(byte NBNGIGCCLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6609750", Offset = "0x6608550", VA = "0x186609750")]
	internal NILFFKBDMAH(NIAGDHJGDNP FHPLDANHGOC, IPEndPoint IADNGEJPALM, int MIFPCBFGGLI, byte BCNAFMNBDIA, DFHMBPOKAIH BGCDPBPKCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6609110", Offset = "0x6607F10", VA = "0x186609110")]
	internal NILFFKBDMAH(NIAGDHJGDNP FHPLDANHGOC, CGMBDKKDBNO HJFGAIAKKLJ, int MIFPCBFGGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x66076F0", Offset = "0x66064F0", VA = "0x1866076F0")]
	internal void GNABHBNGPNL(CFMOHIFIJOJ FAELKGFLFKG, byte[] JOAPLPPIFPC, int EBKPEOBONHB, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6607FC0", Offset = "0x6606DC0", VA = "0x186607FC0")]
	internal bool KGCGIBKHFDH(HCGKLBGHNAJ GHEOJFFKDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6608670", Offset = "0x6607470", VA = "0x186608670")]
	public void LPEMHFLBMBD(byte[] JOAPLPPIFPC, int EBKPEOBONHB, int AIIKLGOLFIK, OLBIKBAJCMG IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66061D0", Offset = "0x6604FD0", VA = "0x1866061D0")]
	private void CJAFGDONKBI(byte[] JOAPLPPIFPC, int EBKPEOBONHB, int AIIKLGOLFIK, byte IPPLHFHEGNL, OLBIKBAJCMG IGOFCCIENBC, object OGGEJOHOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6607F70", Offset = "0x6606D70", VA = "0x186607F70")]
	public void ILOJKOIIEKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6607740", Offset = "0x6606540", VA = "0x186607740")]
	internal ECOMJHEAJPA HKBBOJDFBBL(GCEBFBELFHH GHEOJFFKDGB)
	{
		return default(ECOMJHEAJPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6608710", Offset = "0x6607510", VA = "0x186608710")]
	internal void OHMIAOGPMDO(AJAHFCHMMJP JHAFGNCABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6608770", Offset = "0x6607570", VA = "0x186608770")]
	internal MPPPDOFMJFO OJAKBHGBPAD(byte[] JOAPLPPIFPC, int EBKPEOBONHB, int AIIKLGOLFIK, bool MKKNPGPEIPF)
	{
		return default(MPPPDOFMJFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x66086D0", Offset = "0x66074D0", VA = "0x1866086D0")]
	private void ODLAKBEHCCL(int EFNCLKCEJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6605810", Offset = "0x6604610", VA = "0x186605810")]
	internal void ABIJIMGFKOA(OLBIKBAJCMG FGIGJEMMGAB, GCEBFBELFHH HLIJNINJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6606AC0", Offset = "0x66058C0", VA = "0x186606AC0")]
	private void GEBEFPPOOCE(GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6608A80", Offset = "0x6607880", VA = "0x186608A80")]
	private void OKKLIDNBMIH(int GLDLKCMKFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6606730", Offset = "0x6605530", VA = "0x186606730")]
	internal BJOLOLOEFAI DAFKKEMPBIG(CFMOHIFIJOJ OMMFJAGIEMG)
	{
		return default(BJOLOLOEFAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6607030", Offset = "0x6605E30", VA = "0x186607030")]
	internal void GHCBGPLJNPE(GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6608E10", Offset = "0x6607C10", VA = "0x186608E10")]
	private void PFPMKNEHGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6608040", Offset = "0x6606E40", VA = "0x186608040")]
	internal void KIDDAILGCJD(GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x66078B0", Offset = "0x66066B0", VA = "0x1866078B0")]
	internal void IGIPDIBMNHA(int GLDLKCMKFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6608250", Offset = "0x6607050", VA = "0x186608250")]
	internal void LIBLDFHMMJK(GCEBFBELFHH GHEOJFFKDGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DBHCFENBMCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long MPGPMBJKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long FBAHENDEHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long GICNPIOKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HBAGFPCMOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long ENNLKHDPDNI;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long DEECLHBFPKP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long HEEOKLEDLBD;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long OJHBOFPBMJD;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long FHNDHGOMHJK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long KOIEHKIKNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long NMIHIMDLENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long KDBEHEJBBJD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long EBNNDLKJPKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x65F5570", Offset = "0x65F4370", VA = "0x1865F5570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long IGJLGFNHEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x65F5250", Offset = "0x65F4050", VA = "0x1865F5250")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LPCLPGLMOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x65F5560", Offset = "0x65F4360", VA = "0x1865F5560")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long HGDKABCHEID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x65F5550", Offset = "0x65F4350", VA = "0x1865F5550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long COJOKKKDGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x65F5240", Offset = "0x65F4040", VA = "0x1865F5240")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long JEBABNFEOPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x65F5580", Offset = "0x65F4380", VA = "0x1865F5580")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long AIIDDJJBDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x65F56A0", Offset = "0x65F44A0", VA = "0x1865F56A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long NFIGPBFIHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x65F5600", Offset = "0x65F4400", VA = "0x1865F5600")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private ADGJMCBJGMP ENBGFNNFDHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x65F54C0", Offset = "0x65F42C0", VA = "0x1865F54C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double OKEBMKOKALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x65F5420", Offset = "0x65F4220", VA = "0x1865F5420")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x65F5480", Offset = "0x65F4280", VA = "0x1865F5480")]
	public void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x65F52D0", Offset = "0x65F40D0", VA = "0x1865F52D0")]
	public void DHIALHDJIFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x65F5330", Offset = "0x65F4130", VA = "0x1865F5330")]
	public void FBFDHJOCAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x65F5260", Offset = "0x65F4060", VA = "0x1865F5260")]
	public void CGLHAKJENNF(long LBEOBIBGEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x65F5590", Offset = "0x65F4390", VA = "0x1865F5590")]
	public void KGMHJLPOBLD(long PHNJPACEMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x65F5640", Offset = "0x65F4440", VA = "0x1865F5640")]
	public void NJNMECIGBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x65F54D0", Offset = "0x65F42D0", VA = "0x1865F54D0")]
	public void HAPNFPNLHMI(long PIGBFKHDBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x65F56E0", Offset = "0x65F44E0", VA = "0x1865F56E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x65F5380", Offset = "0x65F4180", VA = "0x1865F5380")]
	public void FOHONGIGNGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public DBHCFENBMCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KBDPCAJDNCF
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> MIJJLCAIIPE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x65F9DE0", Offset = "0x65F8BE0", VA = "0x1865F9DE0")]
	public static IPEndPoint BAMNNCFMAJA(string IEMAONCHCEO, int BDPAHNFLHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x65F9C10", Offset = "0x65F8A10", VA = "0x1865F9C10")]
	public static IPAddress APMNPIBNIFM(string IEMAONCHCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x65F9B80", Offset = "0x65F8980", VA = "0x1865F9B80")]
	public static IPAddress APMNPIBNIFM(string IEMAONCHCEO, AddressFamily GADMJEBBOAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x65FA030", Offset = "0x65F8E30", VA = "0x1865FA030")]
	internal static int BMPNDFBDDNF(int OMMOEGAICAN, int KLINFFNPOHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x336DE20", Offset = "0x336CC20", VA = "0x18336DE20")]
	internal static T[] BMHPNJOBHOM<T>(int BMGBDLLODJK) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HMFEMGAILPJ : AJAHFCHMMJP
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct GLBEADEPGMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private GCEBFBELFHH BCANNHMCKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long AJOAMGJGMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool OIPACOOCPOE;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x65F78A0", Offset = "0x65F66A0", VA = "0x1865F78A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x65F77C0", Offset = "0x65F65C0", VA = "0x1865F77C0")]
		public void EODJIAICOIO(GCEBFBELFHH GHEOJFFKDGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x65F77E0", Offset = "0x65F65E0", VA = "0x1865F77E0")]
		public bool NBEAIIGDDBN(long NCBOLHCLIAA, NILFFKBDMAH OMLCHDGLMLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x65F7850", Offset = "0x65F6650", VA = "0x1865F7850")]
		public bool NCEIDOKFHPG(NILFFKBDMAH OMLCHDGLMLH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly GCEBFBELFHH FNOFHGLIIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly GLBEADEPGMF[] CGHHMLEMHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly GCEBFBELFHH[] LGIHHNCGEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] HLPJAMGKLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int LKOBJDNHDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int JKDIHGANGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int BNNOMHAABKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int BNFPDEOOPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool MFAKELBLJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly OLBIKBAJCMG HLGMOECDMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool CBNCGCEHHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int GDFOLFOKMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte GPBFKFCFMLJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x65F8E10", Offset = "0x65F7C10", VA = "0x1865F8E10")]
	public HMFEMGAILPJ(NILFFKBDMAH OMLCHDGLMLH, bool DABOBEMKBOD, byte MIFPCBFGGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x65F7F20", Offset = "0x65F6D20", VA = "0x1865F7F20")]
	private void BGABAKMJPFA(GCEBFBELFHH GHEOJFFKDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x65F8940", Offset = "0x65F7740", VA = "0x1865F8940", Slot = "4")]
	protected override bool IFGFGEBNHBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x65F82E0", Offset = "0x65F70E0", VA = "0x1865F82E0", Slot = "5")]
	public override bool GHCBGPLJNPE(GCEBFBELFHH GHEOJFFKDGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class NPIPBKFFMAL : AJAHFCHMMJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int OCPFIMPGBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort JKDIHGANGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool BMKNBNPDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private GCEBFBELFHH ONOHPDMEJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly GCEBFBELFHH LNDOIIGBDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool BEHAGNDJDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte GPBFKFCFMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long MODOJPDEJKJ;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x660A180", Offset = "0x6608F80", VA = "0x18660A180")]
	public NPIPBKFFMAL(NILFFKBDMAH OMLCHDGLMLH, bool CHHJLPNIIMH, byte MIFPCBFGGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6609CC0", Offset = "0x6608AC0", VA = "0x186609CC0", Slot = "4")]
	protected override bool IFGFGEBNHBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x66099E0", Offset = "0x66087E0", VA = "0x1866099E0", Slot = "5")]
	public override bool GHCBGPLJNPE(GCEBFBELFHH GHEOJFFKDGB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BPGNBKJGDBP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OPPFHAJMHEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong NAPHKOFEADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double PJDIOBFCPGL;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct NAKFAHEOBIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int CDOMDDIPGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float EFCJCEHKGBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x65F3320", Offset = "0x65F2120", VA = "0x1865F3320")]
	private static void PIGAJNEBMJC(byte[] FBEHCHGAOLI, int DACBEFNKNPO, ulong JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x65F49C0", Offset = "0x65F37C0", VA = "0x1865F49C0")]
	private static void PIGAJNEBMJC(byte[] FBEHCHGAOLI, int DACBEFNKNPO, int JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x65F4950", Offset = "0x65F3750", VA = "0x1865F4950")]
	public static void PIGAJNEBMJC(byte[] FBEHCHGAOLI, int DACBEFNKNPO, short JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x65F4990", Offset = "0x65F3790", VA = "0x1865F4990")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, double IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x65F48D0", Offset = "0x65F36D0", VA = "0x1865F48D0")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x65F4950", Offset = "0x65F3750", VA = "0x1865F4950")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, short IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x65F4950", Offset = "0x65F3750", VA = "0x1865F4950")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, ushort IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x65F49C0", Offset = "0x65F37C0", VA = "0x1865F49C0")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x65F49C0", Offset = "0x65F37C0", VA = "0x1865F49C0")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, uint IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x65F49B0", Offset = "0x65F37B0", VA = "0x1865F49B0")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x65F49B0", Offset = "0x65F37B0", VA = "0x1865F49B0")]
	public static void OMFPBKFHMCO(byte[] MDJJEFJEKNO, int GJCOHOCILFF, ulong IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BILADOAKOAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] GAMLGJDLMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int ELCMECDLBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int GIEFOOAONKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int GGBFKFHODCI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] DNFJLBEBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int IDIMHDGKIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IKJFMONLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x65F3F10", Offset = "0x65F2D10", VA = "0x1865F3F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PGKJJLOCNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2436450", Offset = "0x2435250", VA = "0x182436450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int AEGOEAJGHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x65F43B0", Offset = "0x65F31B0", VA = "0x1865F43B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x65F4000", Offset = "0x65F2E00", VA = "0x1865F4000")]
	public void GFJHFPABKCJ(byte[] EDLHCINOAKH, int DACBEFNKNPO, int BOHGOHLPNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public BILADOAKOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65F4870", Offset = "0x65F3670", VA = "0x1865F4870")]
	public BILADOAKOAG(byte[] EDLHCINOAKH, int DACBEFNKNPO, int BOHGOHLPNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65F3E40", Offset = "0x65F2C40", VA = "0x1865F3E40")]
	public IPEndPoint EPDLONFDGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x65F3DC0", Offset = "0x65F2BC0", VA = "0x1865F3DC0")]
	public byte CNELEJOPCJB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65F3DC0", Offset = "0x65F2BC0", VA = "0x1865F3DC0")]
	public sbyte JEIKDLCGIDE()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3091600", Offset = "0x3090400", VA = "0x183091600")]
	public T[] EJBOPCAGLKJ<T>(ushort IECADCKMGOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x65F4750", Offset = "0x65F3550", VA = "0x1865F4750")]
	public bool[] OIOIBFLJEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65F46A0", Offset = "0x65F34A0", VA = "0x1865F46A0")]
	public ushort[] NIBLBGCNLEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x65F4040", Offset = "0x65F2E40", VA = "0x1865F4040")]
	public short[] HBPCEJNDPFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x65F45C0", Offset = "0x65F33C0", VA = "0x1865F45C0")]
	public int[] MMDPJMFHCNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x65F3E00", Offset = "0x65F2C00", VA = "0x1865F3E00")]
	public uint[] CNJKHJFOKND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65F3CA0", Offset = "0x65F2AA0", VA = "0x1865F3CA0")]
	public float[] BCDNAKOJGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x65F4580", Offset = "0x65F3380", VA = "0x1865F4580")]
	public double[] LLBIKCGHKNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x65F3C60", Offset = "0x65F2A60", VA = "0x1865F3C60")]
	public long[] ADFLGEDPMHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x65F4330", Offset = "0x65F3130", VA = "0x1865F4330")]
	public ulong[] ILEEENDACFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x65F43C0", Offset = "0x65F31C0", VA = "0x1865F43C0")]
	public string[] JPBJBHALGME(int PHMCMFKEPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x65F4600", Offset = "0x65F3400", VA = "0x1865F4600")]
	public bool NAJOIKINJLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x65F4080", Offset = "0x65F2E80", VA = "0x1865F4080")]
	public char HOOENIEDHEK()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x65F4080", Offset = "0x65F2E80", VA = "0x1865F4080")]
	public ushort PLHKNCNCGLI()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x65F3D50", Offset = "0x65F2B50", VA = "0x1865F3D50")]
	public short CIMILCGEODJ()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x65F46E0", Offset = "0x65F34E0", VA = "0x1865F46E0")]
	public long ODEIFBDDELN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x65F3F90", Offset = "0x65F2D90", VA = "0x1865F3F90")]
	public ulong FLKFKONFGAG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x65F4790", Offset = "0x65F3590", VA = "0x1865F4790")]
	public int PCCCIKMEHOJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x65F3F20", Offset = "0x65F2D20", VA = "0x1865F3F20")]
	public uint FIFLGHLBEGO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x65F4800", Offset = "0x65F3600", VA = "0x1865F4800")]
	public float PIJLIOKFGDD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x65F4510", Offset = "0x65F3310", VA = "0x1865F4510")]
	public double KIMOCALKONL()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x65F40F0", Offset = "0x65F2EF0", VA = "0x1865F40F0")]
	public string IHPEODFPIEC(int FICGKJMEBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x65F3CE0", Offset = "0x65F2AE0", VA = "0x1865F3CE0")]
	public ArraySegment<byte> BCPFCOMCJKN(int BMGBDLLODJK)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65F4370", Offset = "0x65F3170", VA = "0x1865F4370")]
	public sbyte[] ILJPNCLIBOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x65F4660", Offset = "0x65F3460", VA = "0x1865F4660")]
	public byte[] NFAJKOMMIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x65F4640", Offset = "0x65F3440", VA = "0x1865F4640")]
	public void NCEIDOKFHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DFHMBPOKAIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] GAMLGJDLMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int ELCMECDLBDG;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int DLNJBLCJFEL = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool LPEDIIIILGF;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding BNKGONJOBOE;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int PAPBLACMALJ = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] JAMPDGOBKGK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] COGAKILOFHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BNJCPJCFEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x65F6810", Offset = "0x65F5610", VA = "0x1865F6810")]
	public DFHMBPOKAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x65F6890", Offset = "0x65F5690", VA = "0x1865F6890")]
	public DFHMBPOKAIH(bool CBFBCFIEBHO, int EKIGEFAFEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x65F6710", Offset = "0x65F5510", VA = "0x1865F6710")]
	public static DFHMBPOKAIH NBKLDFHFHOI(string IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x65F6010", Offset = "0x65F4E10", VA = "0x1865F6010")]
	public void GMLEPEBAIDF(int KIKANACJFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24AFD10", Offset = "0x24AEB10", VA = "0x1824AFD10")]
	public void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x65F6490", Offset = "0x65F5290", VA = "0x1865F6490")]
	public void KKINBNMJMLD(float IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x65F66C0", Offset = "0x65F54C0", VA = "0x1865F66C0")]
	public void KKINBNMJMLD(double IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x65F65A0", Offset = "0x65F53A0", VA = "0x1865F65A0")]
	public void KKINBNMJMLD(long IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x65F65A0", Offset = "0x65F53A0", VA = "0x1865F65A0")]
	public void KKINBNMJMLD(ulong IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x65F60B0", Offset = "0x65F4EB0", VA = "0x1865F60B0")]
	public void KKINBNMJMLD(int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x65F60B0", Offset = "0x65F4EB0", VA = "0x1865F60B0")]
	public void KKINBNMJMLD(uint IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x65F6350", Offset = "0x65F5150", VA = "0x1865F6350")]
	public void KKINBNMJMLD(char IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x65F6350", Offset = "0x65F5150", VA = "0x1865F6350")]
	public void KKINBNMJMLD(ushort IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x65F6350", Offset = "0x65F5150", VA = "0x1865F6350")]
	public void KKINBNMJMLD(short IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x65F6660", Offset = "0x65F5460", VA = "0x1865F6660")]
	public void KKINBNMJMLD(sbyte IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x65F6660", Offset = "0x65F5460", VA = "0x1865F6660")]
	public void KKINBNMJMLD(byte IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x65F6530", Offset = "0x65F5330", VA = "0x1865F6530")]
	public void KKINBNMJMLD(byte[] JOAPLPPIFPC, int DACBEFNKNPO, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x65F5AE0", Offset = "0x65F48E0", VA = "0x1865F5AE0")]
	public void HHNNGNDJOCO(sbyte[] JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x65F5AE0", Offset = "0x65F48E0", VA = "0x1865F5AE0")]
	public void AFMBIAPKJEM(byte[] JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x65F65F0", Offset = "0x65F53F0", VA = "0x1865F65F0")]
	public void KKINBNMJMLD(bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x65F5CA0", Offset = "0x65F4AA0", VA = "0x1865F5CA0")]
	public void FKPHDNKHLLC(Array BAINIFMGFOO, int GDOBDCPHLNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x65F5BC0", Offset = "0x65F49C0", VA = "0x1865F5BC0")]
	public void FKPHDNKHLLC(float[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x65F5F30", Offset = "0x65F4D30", VA = "0x1865F5F30")]
	public void FKPHDNKHLLC(double[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x65F5F30", Offset = "0x65F4D30", VA = "0x1865F5F30")]
	public void FKPHDNKHLLC(long[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x65F5F30", Offset = "0x65F4D30", VA = "0x1865F5F30")]
	public void FKPHDNKHLLC(ulong[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x65F5BC0", Offset = "0x65F49C0", VA = "0x1865F5BC0")]
	public void FKPHDNKHLLC(int[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x65F5BC0", Offset = "0x65F49C0", VA = "0x1865F5BC0")]
	public void FKPHDNKHLLC(uint[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x65F5D80", Offset = "0x65F4B80", VA = "0x1865F5D80")]
	public void FKPHDNKHLLC(ushort[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x65F5D80", Offset = "0x65F4B80", VA = "0x1865F5D80")]
	public void FKPHDNKHLLC(short[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x65F5AE0", Offset = "0x65F48E0", VA = "0x1865F5AE0")]
	public void FKPHDNKHLLC(bool[] IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x65F5E60", Offset = "0x65F4C60", VA = "0x1865F5E60")]
	public void FKPHDNKHLLC(string[] IPHILEOFJLB, int JNHLJJBHHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x65F63C0", Offset = "0x65F51C0", VA = "0x1865F63C0")]
	public void KKINBNMJMLD(IPEndPoint GHCCKKBLGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x65F6650", Offset = "0x65F5450", VA = "0x1865F6650")]
	public void KKINBNMJMLD(string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x65F6140", Offset = "0x65F4F40", VA = "0x1865F6140")]
	public void KKINBNMJMLD(string IPHILEOFJLB, int FICGKJMEBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JNIGLOEPCKM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JGKILFHLGBB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong OFAGBBGFDNF;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x48BF470", Offset = "0x48BE270", VA = "0x1848BF470")]
		static JGKILFHLGBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void IMOLDPEAPLM(BILADOAKOAG GGBMOFKDHMN, object OGGEJOHOGGN);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JDPDGHEEDGI<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public JNIGLOEPCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JDPDGHEEDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x48B9E00", Offset = "0x48B8C00", VA = "0x1848B9E00")]
		internal void CEIDJDPHEJH(BILADOAKOAG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CGKECGELKBE<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JNIGLOEPCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CGKECGELKBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5952730", Offset = "0x5951530", VA = "0x185952730")]
		internal void CEIDJDPHEJH(BILADOAKOAG reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly ANGPFOPNFPA DJOENEPOLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, IMOLDPEAPLM> DCDGDNIOMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly DFHMBPOKAIH MEEHCIJMBPJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x65F9A00", Offset = "0x65F8800", VA = "0x1865F9A00")]
	public JNIGLOEPCKM(int PHMCMFKEPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3093530", Offset = "0x3092330", VA = "0x183093530", Slot = "4")]
	protected virtual ulong MAPMLGBPNLE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x65F9850", Offset = "0x65F8650", VA = "0x1865F9850", Slot = "5")]
	protected virtual IMOLDPEAPLM NOELLODDCKD(BILADOAKOAG GGBMOFKDHMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3344430", Offset = "0x3343230", VA = "0x183344430", Slot = "6")]
	protected virtual void GMPGCDGONEJ<T>(DFHMBPOKAIH FEBAHPCKNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x65F9980", Offset = "0x65F8780", VA = "0x1865F9980")]
	public void OFJNGDHIOJD(BILADOAKOAG GGBMOFKDHMN, object OGGEJOHOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x33444A0", Offset = "0x33432A0", VA = "0x1833444A0")]
	public void NAJLPFPGFAP<T>(DFHMBPOKAIH FEBAHPCKNJP, T GHEOJFFKDGB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x65F9800", Offset = "0x65F8600", VA = "0x1865F9800")]
	public void JEECEMGOFBP(BILADOAKOAG GGBMOFKDHMN, object OGGEJOHOGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3344710", Offset = "0x3343510", VA = "0x183344710")]
	public void PCPIMGDLJIC<T>(Action<T> PMPBFGCCIIO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3344550", Offset = "0x3343350", VA = "0x183344550")]
	public void PCPIMGDLJIC<T, TUserData>(Action<T, TUserData> PMPBFGCCIIO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PMEHDCGOGCL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x65F6930", Offset = "0x65F5730", VA = "0x1865F6930")]
	public PMEHDCGOGCL(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class AEMHCKIJDMK : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x65F3900", Offset = "0x65F2700", VA = "0x1865F3900")]
	public AEMHCKIJDMK(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ANGPFOPNFPA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum NBDPLPMFLDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class ANPLKOOPPNJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public NBDPLPMFLDO LPNEJLDPBGO;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x452B0E0", Offset = "0x4529EE0", VA = "0x18452B0E0", Slot = "4")]
		public virtual void EODJIAICOIO(MethodInfo OOHPFHKNMJD, MethodInfo LIPNOIIILAI, NBDPLPMFLDO OBDHBADPJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ONKBHMABAJL(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ANIIEOMFPLP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		protected ANPLKOOPPNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MJGOGKGKGGB<TClass, TProperty> : ANPLKOOPPNJ<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> POKPPGBCOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> DLAFPPMDBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> POFLDIOMEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> KJJKCDJIDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> MGDEDNHIJIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> AEMKOFMPMEO;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4CA56B0", Offset = "0x4CA44B0", VA = "0x184CA56B0", Slot = "7")]
		public override void LMCOHENIIKD(TClass NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4CA4B50", Offset = "0x4CA3950", VA = "0x184CA4B50", Slot = "8")]
		public override void LEBMDHPKNFL(TClass NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4CA6AD0", Offset = "0x4CA58D0", VA = "0x184CA6AD0", Slot = "9")]
		public override void ONKBHMABAJL(TClass NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4C9FE00", Offset = "0x4C9EC00", VA = "0x184C9FE00", Slot = "10")]
		public override void ANIIEOMFPLP(TClass NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4C9FEE0", Offset = "0x4C9ECE0", VA = "0x184C9FEE0")]
		protected TProperty[] CPOCECABMBF(TClass NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4CA4910", Offset = "0x4CA3710", VA = "0x184CA4910")]
		protected TProperty[] ILBBNMJIIBP(TClass NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4CA1C10", Offset = "0x4CA0A10", VA = "0x184CA1C10", Slot = "4")]
		public override void EODJIAICOIO(MethodInfo OOHPFHKNMJD, MethodInfo LIPNOIIILAI, NBDPLPMFLDO OBDHBADPJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x44AE930", Offset = "0x44AD730", VA = "0x1844AE930")]
		protected MJGOGKGKGGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class PAHFGBCABKJ<TClass, TProperty> : MJGOGKGKGGB<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void NAFFALMMECA(BILADOAKOAG MLFMLAODHNL, [Out] TProperty CDHJOKPCHON);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void GEOHOFFOMON(DFHMBPOKAIH DMBNCEPMGLK, TProperty CDHJOKPCHON);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF420", Offset = "0x4EFE220", VA = "0x184EFF420", Slot = "5")]
		public override void EJOFNMKAHAB(TClass NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF7C0", Offset = "0x4EFE5C0", VA = "0x184EFF7C0", Slot = "6")]
		public override void NAJLPFPGFAP(TClass NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF640", Offset = "0x4EFE440", VA = "0x184EFF640", Slot = "7")]
		public override void LMCOHENIIKD(TClass NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF4C0", Offset = "0x4EFE2C0", VA = "0x184EFF4C0", Slot = "8")]
		public override void LEBMDHPKNFL(TClass NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4383670", Offset = "0x4382470", VA = "0x184383670")]
		protected PAHFGBCABKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class GHGACEFOCEJ<T> : MJGOGKGKGGB<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x44C2090", Offset = "0x44C0E90", VA = "0x1844C2090", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x44C2200", Offset = "0x44C1000", VA = "0x1844C2200", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x44C2180", Offset = "0x44C0F80", VA = "0x1844C2180", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x44C2110", Offset = "0x44C0F10", VA = "0x1844C2110", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public GHGACEFOCEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class CPBGNAHCJLO<T> : MJGOGKGKGGB<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5A55BD0", Offset = "0x5A549D0", VA = "0x185A55BD0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x44C2200", Offset = "0x44C1000", VA = "0x1844C2200", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5A55C50", Offset = "0x5A54A50", VA = "0x185A55C50", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x44C2110", Offset = "0x44C0F10", VA = "0x1844C2110", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public CPBGNAHCJLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class HKDCCJDCOML<T> : MJGOGKGKGGB<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x457F9E0", Offset = "0x457E7E0", VA = "0x18457F9E0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x457FB50", Offset = "0x457E950", VA = "0x18457FB50", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x457FAD0", Offset = "0x457E8D0", VA = "0x18457FAD0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x457FA60", Offset = "0x457E860", VA = "0x18457FA60", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public HKDCCJDCOML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class NEJIIFJLLON<T> : MJGOGKGKGGB<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4D25C50", Offset = "0x4D24A50", VA = "0x184D25C50", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x457FB50", Offset = "0x457E950", VA = "0x18457FB50", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4D25CD0", Offset = "0x4D24AD0", VA = "0x184D25CD0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x457FA60", Offset = "0x457E860", VA = "0x18457FA60", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public NEJIIFJLLON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GBGFLKFDOMO<T> : MJGOGKGKGGB<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x44A24F0", Offset = "0x44A12F0", VA = "0x1844A24F0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x44A2660", Offset = "0x44A1460", VA = "0x1844A2660", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x44A25E0", Offset = "0x44A13E0", VA = "0x1844A25E0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x44A2570", Offset = "0x44A1370", VA = "0x1844A2570", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public GBGFLKFDOMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class NMBIOIILPAE<T> : MJGOGKGKGGB<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4D31B10", Offset = "0x4D30910", VA = "0x184D31B10", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44A2660", Offset = "0x44A1460", VA = "0x1844A2660", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4D31B90", Offset = "0x4D30990", VA = "0x184D31B90", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x44A2570", Offset = "0x44A1370", VA = "0x1844A2570", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public NMBIOIILPAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class BMGNJENAFFM<T> : MJGOGKGKGGB<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x49D7B50", Offset = "0x49D6950", VA = "0x1849D7B50", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x49D7C50", Offset = "0x49D6A50", VA = "0x1849D7C50", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5682020", Offset = "0x5680E20", VA = "0x185682020", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x46F9690", Offset = "0x46F8490", VA = "0x1846F9690", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public BMGNJENAFFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class KNIKLGKICJF<T> : MJGOGKGKGGB<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x49D7B50", Offset = "0x49D6950", VA = "0x1849D7B50", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x49D7C50", Offset = "0x49D6A50", VA = "0x1849D7C50", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x49D7BD0", Offset = "0x49D69D0", VA = "0x1849D7BD0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x46F9690", Offset = "0x46F8490", VA = "0x1846F9690", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public KNIKLGKICJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JLLMGKGEDOI<T> : MJGOGKGKGGB<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x48D2570", Offset = "0x48D1370", VA = "0x1848D2570", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x48D2670", Offset = "0x48D1470", VA = "0x1848D2670", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x48D25F0", Offset = "0x48D13F0", VA = "0x1848D25F0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x44C2110", Offset = "0x44C0F10", VA = "0x1844C2110", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public JLLMGKGEDOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class HMAKDOOPGEA<T> : MJGOGKGKGGB<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4594DC0", Offset = "0x4593BC0", VA = "0x184594DC0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4594EC0", Offset = "0x4593CC0", VA = "0x184594EC0", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4594E40", Offset = "0x4593C40", VA = "0x184594E40", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x44A2570", Offset = "0x44A1370", VA = "0x1844A2570", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public HMAKDOOPGEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class IPKMGBACHPN<T> : MJGOGKGKGGB<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x46F9610", Offset = "0x46F8410", VA = "0x1846F9610", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x46F9780", Offset = "0x46F8580", VA = "0x1846F9780", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x46F9700", Offset = "0x46F8500", VA = "0x1846F9700", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x46F9690", Offset = "0x46F8490", VA = "0x1846F9690", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x437E9B0", Offset = "0x437D7B0", VA = "0x18437E9B0")]
		public IPKMGBACHPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class MCCJIMIHPNJ<T> : PAHFGBCABKJ<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4C87510", Offset = "0x4C86310", VA = "0x184C87510", Slot = "12")]
		protected override void GEOHOFFOMON(DFHMBPOKAIH DMBNCEPMGLK, char CDHJOKPCHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C87540", Offset = "0x4C86340", VA = "0x184C87540", Slot = "11")]
		protected override void NAFFALMMECA(BILADOAKOAG MLFMLAODHNL, [Out] char CDHJOKPCHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3F36020", Offset = "0x3F34E20", VA = "0x183F36020")]
		public MCCJIMIHPNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ACPMDBPICJE<T> : PAHFGBCABKJ<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x447D600", Offset = "0x447C400", VA = "0x18447D600", Slot = "12")]
		protected override void GEOHOFFOMON(DFHMBPOKAIH DMBNCEPMGLK, IPEndPoint CDHJOKPCHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x447D630", Offset = "0x447C430", VA = "0x18447D630", Slot = "11")]
		protected override void NAFFALMMECA(BILADOAKOAG MLFMLAODHNL, [Out] IPEndPoint CDHJOKPCHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F36020", Offset = "0x3F34E20", VA = "0x183F36020")]
		public ACPMDBPICJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class GIAGPCBPMPB<T> : MJGOGKGKGGB<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int BAEFLFOPOMG;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x44C2AB0", Offset = "0x44C18B0", VA = "0x1844C2AB0")]
		public GIAGPCBPMPB(int FICGKJMEBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x44C28B0", Offset = "0x44C16B0", VA = "0x1844C28B0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x44C2A30", Offset = "0x44C1830", VA = "0x1844C2A30", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x44C29B0", Offset = "0x44C17B0", VA = "0x1844C29B0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x44C2930", Offset = "0x44C1730", VA = "0x1844C2930", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class OGMOCGGPPAP<T> : ANPLKOOPPNJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo FKJEHBJEJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type MHDOPELBPCL;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4E42540", Offset = "0x4E41340", VA = "0x184E42540")]
		public OGMOCGGPPAP(PropertyInfo AMBDMECJFHI, Type MJAJMLJJAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4E422B0", Offset = "0x4E410B0", VA = "0x184E422B0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4E42430", Offset = "0x4E41230", VA = "0x184E42430", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4E423D0", Offset = "0x4E411D0", VA = "0x184E423D0", Slot = "7")]
		public override void LMCOHENIIKD(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4E42370", Offset = "0x4E41170", VA = "0x184E42370", Slot = "8")]
		public override void LEBMDHPKNFL(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4E424E0", Offset = "0x4E412E0", VA = "0x184E424E0", Slot = "9")]
		public override void ONKBHMABAJL(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E42250", Offset = "0x4E41050", VA = "0x184E42250", Slot = "10")]
		public override void ANIIEOMFPLP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class OPOBPJEDBOA<T> : OGMOCGGPPAP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x44803C0", Offset = "0x447F1C0", VA = "0x1844803C0")]
		public OPOBPJEDBOA(PropertyInfo AMBDMECJFHI, Type MJAJMLJJAFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E5ACE0", Offset = "0x4E59AE0", VA = "0x184E5ACE0", Slot = "5")]
		public override void EJOFNMKAHAB(T NCLOAEFMJEL, BILADOAKOAG MLFMLAODHNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E5ADA0", Offset = "0x4E59BA0", VA = "0x184E5ADA0", Slot = "6")]
		public override void NAJLPFPGFAP(T NCLOAEFMJEL, DFHMBPOKAIH DMBNCEPMGLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class BEALMLPMJOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static BEALMLPMJOB<T> GGJCMHODIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly ANPLKOOPPNJ<T>[] AINLNBKCCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int HOHMANHDGMP;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5616F50", Offset = "0x5615D50", VA = "0x185616F50")]
		public BEALMLPMJOB(List<ANPLKOOPPNJ<T>> DNCOGMHHPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5616EA0", Offset = "0x5615CA0", VA = "0x185616EA0")]
		public void NAJLPFPGFAP(T JOOHPPHJKMI, DFHMBPOKAIH FEBAHPCKNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5616DF0", Offset = "0x5615BF0", VA = "0x185616DF0")]
		public void EJOFNMKAHAB(T JOOHPPHJKMI, BILADOAKOAG GGBMOFKDHMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class MFCNPEKKCLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ANPLKOOPPNJ<T> ANFJBBFMPMK<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private DFHMBPOKAIH LENGLJPNMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int MKHMMMHAPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, MFCNPEKKCLP> FLALJKELFMH;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x65F3BC0", Offset = "0x65F29C0", VA = "0x1865F3BC0")]
	public ANGPFOPNFPA(int PHMCMFKEPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3A30660", Offset = "0x3A2F460", VA = "0x183A30660")]
	private BEALMLPMJOB<T> CFFCKGCEHIH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3071070", Offset = "0x306FE70", VA = "0x183071070")]
	public void EHDMJEMLBPD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3A31790", Offset = "0x3A30590", VA = "0x183A31790")]
	public bool FEIAPADJKML<T>(BILADOAKOAG GGBMOFKDHMN, T OBIPBFFAILK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3A31830", Offset = "0x3A30630", VA = "0x183A31830")]
	public void NPIKEPIONAB<T>(DFHMBPOKAIH FEBAHPCKNJP, T JOOHPPHJKMI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LIMENKBEBJN
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime ALDCFJNBPNC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] JODGGDJNIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ALJMFFKMJDC OONFMHEEMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x65FA580", Offset = "0x65F9380", VA = "0x1865FA580")]
		get
		{
			return default(ALJMFFKMJDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IMOAGHILMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x65FA950", Offset = "0x65F9750", VA = "0x1865FA950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x65FA910", Offset = "0x65F9710", VA = "0x1865FA910")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IDMHBHDINHL MNHPJOBJFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x65FA320", Offset = "0x65F9120", VA = "0x1865FA320")]
		get
		{
			return default(IDMHBHDINHL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x65FA840", Offset = "0x65F9640", VA = "0x1865FA840")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int CEKGAFBNPDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x65FADC0", Offset = "0x65F9BC0", VA = "0x1865FADC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint EFKIMHOCPOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x65FAB70", Offset = "0x65F9970", VA = "0x1865FAB70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? GHIPJJHKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x65FA2F0", Offset = "0x65F90F0", VA = "0x1865FA2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? OIDOEBHKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x65FA8E0", Offset = "0x65F96E0", VA = "0x1865FA8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? BOOAIDNJEAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x65FA550", Offset = "0x65F9350", VA = "0x1865FA550")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x65FA670", Offset = "0x65F9470", VA = "0x1865FA670")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? EFMLGHKJHNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xACB760", Offset = "0xACA560", VA = "0x180ACB760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC8E9B0", Offset = "0xC8D7B0", VA = "0x180C8E9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x65FB170", Offset = "0x65F9F70", VA = "0x1865FB170")]
	public LIMENKBEBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x65FB0C0", Offset = "0x65F9EC0", VA = "0x1865FB0C0")]
	internal LIMENKBEBJN(byte[] MDJJEFJEKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x65FA980", Offset = "0x65F9780", VA = "0x1865FA980")]
	public static LIMENKBEBJN KNIBFGNONNP(byte[] MDJJEFJEKNO, DateTime IIGNDLKPGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x65FA0F0", Offset = "0x65F8EF0", VA = "0x1865FA0F0")]
	internal void DBBJPAABGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x65FADF0", Offset = "0x65F9BF0", VA = "0x1865FADF0")]
	private void NLDMCKINIBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x65FA350", Offset = "0x65F9150", VA = "0x1865FA350")]
	private DateTime? EIGEMEGMCFI(int DACBEFNKNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x65FABF0", Offset = "0x65F99F0", VA = "0x1865FABF0")]
	private void NGCDAEAAEAP(int DACBEFNKNPO, DateTime? IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x65FAAA0", Offset = "0x65F98A0", VA = "0x1865FAAA0")]
	private ulong LBKEOJNLBOC(int DACBEFNKNPO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x65FA5B0", Offset = "0x65F93B0", VA = "0x1865FA5B0")]
	private void GLJOPEICBAC(int DACBEFNKNPO, ulong IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x65FAFD0", Offset = "0x65F9DD0", VA = "0x1865FAFD0")]
	private uint OPEDPDDGOBP(int DACBEFNKNPO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x64C5B80", Offset = "0x64C4980", VA = "0x1864C5B80")]
	private static uint HHIFGMHMIHL(uint LBONEMFCDEA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x65FA880", Offset = "0x65F9680", VA = "0x1865FA880")]
	private static ulong HHIFGMHMIHL(ulong LBONEMFCDEA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum ALJMFFKMJDC
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
public enum IDMHBHDINHL
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class NKBMHFJPMMD
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int BECKBJHHANH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int LFFDNPFMPKJ = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int IDHNPMANPEI = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint GMNKAAKHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int PHJHIALPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int AOJBCMMEMEF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GGMLMFCEBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x66099D0", Offset = "0x66087D0", VA = "0x1866099D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x66098E0", Offset = "0x66086E0", VA = "0x1866098E0")]
	public bool LPEMHFLBMBD(IDOCMNIOIEL LGNONKPKKNF, int LEAPIIAHEEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class IOFOICLOKJB : IDOCMNIOIEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket LGNONKPKKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly NIAGDHJGDNP FHPLDANHGOC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short MIGEACCBNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x65F96B0", Offset = "0x65F84B0", VA = "0x1865F96B0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NPFEMHODHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x65F9710", Offset = "0x65F8510", VA = "0x1865F9710", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint IOBKEGNAGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x65F9730", Offset = "0x65F8530", VA = "0x1865F9730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily HLJMPGPDEOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4A2FEA0", Offset = "0x4A2ECA0", VA = "0x184A2FEA0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x65F9750", Offset = "0x65F8550", VA = "0x1865F9750")]
	public IOFOICLOKJB(AddressFamily GADMJEBBOAD, NIAGDHJGDNP FHPLDANHGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x65F8FE0", Offset = "0x65F7DE0", VA = "0x1865F8FE0", Slot = "8")]
	public bool HBEFKGAAMME(IPEndPoint GHCCKKBLGIG, OGFDHDGCIAL BEKOCFAFFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x65F96D0", Offset = "0x65F84D0", VA = "0x1865F96D0", Slot = "9")]
	public int MAODMPBHJCD(byte[] FBEHCHGAOLI, int DACBEFNKNPO, int IECADCKMGOP, IPEndPoint IADNGEJPALM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x65F95C0", Offset = "0x65F83C0", VA = "0x1865F95C0", Slot = "10")]
	public int HMNBLMEFDCP(byte[] FBEHCHGAOLI, EndPoint JIPMPDLLJBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x65F95A0", Offset = "0x65F83A0", VA = "0x1865F95A0", Slot = "11")]
	public void HFFJCPDCOHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface IDOCMNIOIEL
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short MIGEACCBNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int NPFEMHODHFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint IOBKEGNAGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily HLJMPGPDEOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HBEFKGAAMME(IPEndPoint GHCCKKBLGIG, OGFDHDGCIAL BEKOCFAFFOA);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int MAODMPBHJCD(byte[] FBEHCHGAOLI, int DACBEFNKNPO, int IECADCKMGOP, IPEndPoint IADNGEJPALM);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HMNBLMEFDCP(byte[] FBEHCHGAOLI, EndPoint IADNGEJPALM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HFFJCPDCOHN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct CKMGKKCOPOD : IEquatable<CKMGKKCOPOD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long BCJCDIOFFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long DKMPLHKKOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long LFNIJODFNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int AMCBAJCNJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int EJFIDLDHPBG;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x65F5150", Offset = "0x65F3F50", VA = "0x1865F5150")]
	public CKMGKKCOPOD(byte[] FPFPCKOIAOK, int OMAGOBGACNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x91E390", Offset = "0x91D190", VA = "0x18091E390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x65F5060", Offset = "0x65F3E60", VA = "0x1865F5060", Slot = "4")]
	public bool Equals(CKMGKKCOPOD LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x65F50A0", Offset = "0x65F3EA0", VA = "0x1865F50A0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class JHECGBFDOHK : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] FFBKKKPPJNK;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class GNADBKLDENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int MIGJLFGACIF;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
	protected GNADBKLDENN(int BOMDNCFKFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void GDAIAODJPAP(IPEndPoint GHCCKKBLGIG, byte[] JOAPLPPIFPC, int DACBEFNKNPO, int AIIKLGOLFIK);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DFJANIKBODE(IPEndPoint GHCCKKBLGIG, byte[] JOAPLPPIFPC, int DACBEFNKNPO, int AIIKLGOLFIK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LKKJADFCLPK : GNADBKLDENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] FFOHLCGHDKA;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator BJKPEJGKHJK;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2559E20", Offset = "0x2558C20", VA = "0x182559E20")]
	public LKKJADFCLPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x65FBDA0", Offset = "0x65FABA0", VA = "0x1865FBDA0")]
	public void OLJOFGIHNAG(IPEndPoint GHCCKKBLGIG, byte[] FFOHLCGHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x65FBCC0", Offset = "0x65FAAC0", VA = "0x1865FBCC0")]
	public void GGFLHHPMCJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x65FB800", Offset = "0x65FA600", VA = "0x1865FB800", Slot = "4")]
	public override void GDAIAODJPAP(IPEndPoint GHCCKKBLGIG, byte[] JOAPLPPIFPC, int DACBEFNKNPO, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x65FB490", Offset = "0x65FA290", VA = "0x1865FB490", Slot = "5")]
	public override void DFJANIKBODE(IPEndPoint GHCCKKBLGIG, byte[] JOAPLPPIFPC, int DACBEFNKNPO, int AIIKLGOLFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct MEBHNPLBJJC
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void NDGIFCCFJOF([NoAlias] byte* JAOLJOAOOCB, [NoAlias] byte* FFOHLCGHDKA, [NoAlias] byte* GAAPDDKBILM, int AIIKLGOLFIK);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class HDPKPENLDOK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr HCBHBFHHCDI;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr FJKGLEDGOBH;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x660ACF0", Offset = "0x6609AF0", VA = "0x18660ACF0")]
		[BurstDiscard]
		private static void BNCEKFDGIJJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x660AE20", Offset = "0x6609C20", VA = "0x18660AE20")]
		private static IntPtr FMKAJIGFJIJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x660B1C0", Offset = "0x6609FC0", VA = "0x18660B1C0")]
		public static void LNCBACCMDPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		public static void JEELJGCJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x660AF80", Offset = "0x6609D80", VA = "0x18660AF80")]
		public unsafe static void GAFILCALGLM([NoAlias] byte* JAOLJOAOOCB, [NoAlias] byte* FFOHLCGHDKA, [NoAlias] byte* GAAPDDKBILM, int AIIKLGOLFIK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint FFOHLCGHDKA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint GAAPDDKBILM[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint BOLFICIAEBA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint PDADOPIBPJP[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint KGEAGPMDDKE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint NKKOAGGIBHB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint BDLFFHLOPOA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint HPPEEFNPLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint MOAKFCLBENC[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x65FD630", Offset = "0x65FC430", VA = "0x1865FD630")]
	private void GCNCDDFOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x65FD600", Offset = "0x65FC400", VA = "0x1865FD600")]
	private uint EJKCPEIPPME(uint MFHMIEFHEKN, int LECMOPPNMNL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x65F34B0", Offset = "0x65F22B0", VA = "0x1865F34B0")]
	private void BBFCMLEAHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x65F3560", Offset = "0x65F2360", VA = "0x1865F3560")]
	private void DJJHOCFBDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x65F3770", Offset = "0x65F2570", VA = "0x1865F3770")]
	private void FNDPGBNBDPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x65F3800", Offset = "0x65F2600", VA = "0x1865F3800")]
	private void PBMADFKHBEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x65FDBD0", Offset = "0x65FC9D0", VA = "0x1865FDBD0")]
	private void LEANKGDOBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x65FD6B0", Offset = "0x65FC4B0", VA = "0x1865FD6B0")]
	private unsafe void JMCLGIKPPEM(byte* JAOLJOAOOCB, uint* FFOHLCGHDKA, uint* GAAPDDKBILM, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x65FDC30", Offset = "0x65FCA30", VA = "0x1865FDC30")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OOJGINDCKFM([NoAlias] byte* JAOLJOAOOCB, [NoAlias] byte* FFOHLCGHDKA, [NoAlias] byte* GAAPDDKBILM, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x65FDCB0", Offset = "0x65FCAB0", VA = "0x1865FDCB0")]
	public static void OOJGINDCKFM(Span<byte> JAOLJOAOOCB, Span<byte> FFOHLCGHDKA, Span<byte> GAAPDDKBILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x65FDAD0", Offset = "0x65FC8D0", VA = "0x1865FDAD0")]
	public static void LAMOGOONCMG(Span<byte> JAOLJOAOOCB, Span<byte> FFOHLCGHDKA, Span<byte> GAAPDDKBILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x65FD590", Offset = "0x65FC390", VA = "0x1865FD590")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BDPOKGLJPJM([NoAlias] byte* JAOLJOAOOCB, [NoAlias] byte* FFOHLCGHDKA, [NoAlias] byte* GAAPDDKBILM, int AIIKLGOLFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x660B370", Offset = "0x660A170", VA = "0x18660B370")]
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
