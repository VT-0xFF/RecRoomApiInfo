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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LLMPHNHPJOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JKHKLEPJOPD
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
		private NetworkManager FNLINPBKLJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, GJEPKKCALIJ> DBGHDNKANBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IEOIDIADAGK FJDAONHHJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] EMFNBMIGFKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JKHKLEPJOPD ACPBOJBKDAH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong HDLBPIBKEMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C34C0", Offset = "0x7C1EC0", VA = "0x1807C34C0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OMIKPIOILNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x57AFEF0", Offset = "0x57AE8F0", VA = "0x1857AFEF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x57AF3F0", Offset = "0x57ADDF0", VA = "0x1857AF3F0")]
		public void RecRoom_SetEncryptionInfo(ulong ENDFKLBPEBB, byte[] KLDFLAABJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x57AF3D0", Offset = "0x57ADDD0", VA = "0x1857AF3D0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57AF2A0", Offset = "0x57ADCA0", VA = "0x1857AF2A0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x57AFDF0", Offset = "0x57AE7F0", VA = "0x1857AFDF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x57AF5F0", Offset = "0x57ADFF0", VA = "0x1857AF5F0", Slot = "6")]
		public override void Send(ulong GLMNAECDJEC, ArraySegment<byte> ABDLEBPKDKC, NetworkDelivery HMGKKHMIPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x57AF390", Offset = "0x57ADD90", VA = "0x1857AF390", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong GLMNAECDJEC, [Out] ArraySegment<byte> PEFGDLBLMMP, [Out] float ONEOMCNAPJE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x57AF8E0", Offset = "0x57AE2E0", VA = "0x1857AF8E0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x57AFD10", Offset = "0x57AE710", VA = "0x1857AFD10", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x57AED10", Offset = "0x57AD710", VA = "0x1857AED10", Slot = "10")]
		public override void DisconnectRemoteClient(ulong GLMNAECDJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x57AEBC0", Offset = "0x57AD5C0", VA = "0x1857AEBC0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57AEF40", Offset = "0x57AD940", VA = "0x1857AEF40", Slot = "12")]
		public override ulong GetCurrentRtt(ulong GLMNAECDJEC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x57AF870", Offset = "0x57AE270", VA = "0x1857AF870", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x57AF0B0", Offset = "0x57ADAB0", VA = "0x1857AF0B0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager FNLINPBKLJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x57AEFE0", Offset = "0x57AD9E0", VA = "0x1857AEFE0")]
		private BMNEBGFOBGL HCKGAIMHDFO(NetworkDelivery CGEOAHHPHHK)
		{
			return default(BMNEBGFOBGL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57AEE80", Offset = "0x57AD880", VA = "0x1857AEE80", Slot = "15")]
		private void GMIHPGDOJCA(GJEPKKCALIJ ABAMMHKFCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x57AE7F0", Offset = "0x57AD1F0", VA = "0x1857AE7F0", Slot = "16")]
		private void BBAOBEHMFGE(GJEPKKCALIJ ABAMMHKFCAA, BPGLCHFFLHG GPLEEGMFIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "17")]
		private void LLJMODIPILH(IPEndPoint BDGAKFBHHMD, SocketError AKLFAEPGFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x57AE930", Offset = "0x57AD330", VA = "0x1857AE930", Slot = "18")]
		private void BGEEPCAKAME(GJEPKKCALIJ ABAMMHKFCAA, NDKFPFEOFKA INBDAJDBDHK, byte OJMMNENGIIE, BMNEBGFOBGL GMBMMEOGOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x57AE710", Offset = "0x57AD110", VA = "0x1857AE710")]
		private void ACHIOMOGCIK(int CBAOPDHODHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "19")]
		private void KAMJHGDLJKF(IPEndPoint MBNHLDIFNDP, NDKFPFEOFKA INBDAJDBDHK, JABJFKDANFI AIHGGGMCHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "20")]
		private void DFIIKKGCHLE(GJEPKKCALIJ ABAMMHKFCAA, int GEGEKBGGJNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x57AEB40", Offset = "0x57AD540", VA = "0x1857AEB40", Slot = "21")]
		private void CMBBPOFCNDA(FNEJGDJNOHE ELBMMMMNOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x57AF270", Offset = "0x57ADC70", VA = "0x1857AF270")]
		private ulong LGEDCBOEMND(GJEPKKCALIJ ABAMMHKFCAA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x57AEBA0", Offset = "0x57AD5A0", VA = "0x1857AEBA0")]
		private static int DEKLNEKHKCF(float BAFOADOMFEH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x57AFE10", Offset = "0x57AE810", VA = "0x1857AFE10")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class OCNJKOEAJML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly GJEPKKCALIJ BBMMMHLMMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<CPHIJMFOOJB> NEPICAJMEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PNBHEJJAMHN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x57B05A0", Offset = "0x57AEFA0", VA = "0x1857B05A0")]
	protected OCNJKOEAJML(GJEPKKCALIJ ABAMMHKFCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57B0540", Offset = "0x57AEF40", VA = "0x1857B0540")]
	public void NGKGIJAFNPE(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x57B04C0", Offset = "0x57AEEC0", VA = "0x1857B04C0")]
	protected void EJPCECGFCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x57B0480", Offset = "0x57AEE80", VA = "0x1857B0480")]
	public bool EEFLJPFFKGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool OPDOEJOOMOO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool OFOGDGCMMAN(CPHIJMFOOJB DHBMHKNGPCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CKNFHMFKCIE
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
public class FNEJGDJNOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IEOIDIADAGK AOAFLLPGLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int PNMPMHEAFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal HCBODIGFKEF MECDLOFIAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint PANEKNKACCE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CKNFHMFKCIE BFKFHPNHJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EAB70", Offset = "0x7E9570", VA = "0x1807EAB70")]
		[CompilerGenerated]
		get
		{
			return default(CKNFHMFKCIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99B470", Offset = "0x999E70", VA = "0x18099B470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x579F020", Offset = "0x579DA20", VA = "0x18579F020")]
	internal void KCBBLMBIHCG(HCBODIGFKEF OJPEPCJDMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x579EFF0", Offset = "0x579D9F0", VA = "0x18579EFF0")]
	private bool JJJNLAGBDLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x579F080", Offset = "0x579DA80", VA = "0x18579F080")]
	internal FNEJGDJNOHE(IPEndPoint MBNHLDIFNDP, HCBODIGFKEF JBMDCKLLGFA, IEOIDIADAGK DHCGHGOKJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x579EF90", Offset = "0x579D990", VA = "0x18579EF90")]
	public GJEPKKCALIJ FCGAKAIDJDB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JABJFKDANFI
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LHNBEBMLHOA
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
public struct BPGLCHFFLHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public LHNBEBMLHOA INBJPIFMDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError NHOLOMBBDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NDKFPFEOFKA BPCDMGJIBEL;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LLMPHNHPJOC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFDJPKPJIGM(GJEPKKCALIJ ABAMMHKFCAA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGGACIHGLNJ(GJEPKKCALIJ ABAMMHKFCAA, BPGLCHFFLHG GPLEEGMFIKA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIKBCKGJEBE(IPEndPoint BDGAKFBHHMD, SocketError AKLFAEPGFIJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JNDGLCGPMFB(GJEPKKCALIJ ABAMMHKFCAA, NDKFPFEOFKA INBDAJDBDHK, byte OJMMNENGIIE, BMNEBGFOBGL GMBMMEOGOML);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNNPKOPIKKM(IPEndPoint MBNHLDIFNDP, NDKFPFEOFKA INBDAJDBDHK, JABJFKDANFI AIHGGGMCHKM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAJCLOFKPHI(GJEPKKCALIJ ABAMMHKFCAA, int GEGEKBGGJNI);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECJIIKCFBFB(FNEJGDJNOHE ELBMMMMNOAO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KJDHMHGCGEB
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFIOPKLKHKM(GJEPKKCALIJ ABAMMHKFCAA, object GEGMONMODME);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EAHGKIGGDBC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GEBCMADAJFA(EDEGDOKKKNC DHBMHKNGPCJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ACNBIPBFLIL
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EONLGBEKDKH(GJEPKKCALIJ ABAMMHKFCAA, IPEndPoint HFFLGCDGHAM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HCBODIGFKEF
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int FBOFNMLKFNL = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long GMNBIENPDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte BLNFCAKAHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] MMOJDFNLGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DLMCPNMPKIP PICICNMEMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int OFKICCCANPJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x57A35A0", Offset = "0x57A1FA0", VA = "0x1857A35A0")]
	private HCBODIGFKEF(long MDDOOMEBPJG, byte DCLLGDBPBDO, int OCMIGFBMBMB, byte[] APMEFBDLNIB, DLMCPNMPKIP ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x57A3140", Offset = "0x57A1B40", VA = "0x1857A3140")]
	public static int FOGPOBNBBLD(CPHIJMFOOJB DHBMHKNGPCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x57A31A0", Offset = "0x57A1BA0", VA = "0x1857A31A0")]
	public static HCBODIGFKEF GIILGAHOKJJ(CPHIJMFOOJB DHBMHKNGPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x57A33C0", Offset = "0x57A1DC0", VA = "0x1857A33C0")]
	public static CPHIJMFOOJB PNCKMBEAPLG(KOMLPBDJGLD DBOANJPLNOL, SocketAddress JABMNPIFNGG, long MJCEDOAPPGN, int OCMIGFBMBMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HFMINLDHDOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long GMNBIENPDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte BLNFCAKAHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int OFKICCCANPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool CPOBDOFBMNI;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x57A3950", Offset = "0x57A2350", VA = "0x1857A3950")]
	private HFMINLDHDOB(long MDDOOMEBPJG, byte DCLLGDBPBDO, int FIFIIBJEECO, bool KABJMMFDNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57A3610", Offset = "0x57A2010", VA = "0x1857A3610")]
	public static HFMINLDHDOB GIILGAHOKJJ(CPHIJMFOOJB DHBMHKNGPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57A3860", Offset = "0x57A2260", VA = "0x1857A3860")]
	public static CPHIJMFOOJB PNCKMBEAPLG(long MJCEDOAPPGN, byte DBMEAPIENFA, int CGMONICANGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57A3760", Offset = "0x57A2160", VA = "0x1857A3760")]
	public static CPHIJMFOOJB GNJKOOLKEKI(GJEPKKCALIJ ABAMMHKFCAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum HLGGPEOENEP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MKEOMPIFINH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOAOCECNMFL(IPEndPoint EHGELHNMKMI, IPEndPoint MBNHLDIFNDP, string AIDIDMJCFEK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIEPJEPANGP(IPEndPoint LJAOMHLKOBM, HLGGPEOENEP CGEOAHHPHHK, string AIDIDMJCFEK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FJNMMDPEFIO
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct GBKPBLFINHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint DGPPDDBOBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint PANEKNKACCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string AFLNKCOGPJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct POPNDHBCNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint OIKMNGANBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public HLGGPEOENEP OHELAGOCJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string AFLNKCOGPJI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class PPPEBKJPEBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint GGLEMDBMLBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string AFLNKCOGPJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PPPEBKJPEBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HCBJMPEFNFK
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GGLEMDBMLBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint MPGAGLHNNHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string AFLNKCOGPJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HCBJMPEFNFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HOCGKMMKJEH
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AFLNKCOGPJI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AAAMBLLLJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x860540", Offset = "0x85EF40", VA = "0x180860540")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C4D40", Offset = "0x7C3740", VA = "0x1807C4D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HOCGKMMKJEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IEOIDIADAGK JPPFJCKJLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<GBKPBLFINHM> AOKCGAIFAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<POPNDHBCNFC> EODGBPMGCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DLMCPNMPKIP JBAHHKJADNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KOMLPBDJGLD JHCCCMLJBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly BMCJCKEPFGO NKJAHDCIFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private MKEOMPIFINH CCCPJOBILEF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int KPNDIPHIKEL = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool IGMPLEHGFMI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x579EB40", Offset = "0x579D540", VA = "0x18579EB40")]
	internal FJNMMDPEFIO(IEOIDIADAGK BOANGPNPCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x579E840", Offset = "0x579D240", VA = "0x18579E840")]
	internal void NKFPFKOJIOA(IPEndPoint GELMKHNOHBB, CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2939F90", Offset = "0x2938990", VA = "0x182939F90")]
	private void NJJKMAMJCGK<T>(T DHBMHKNGPCJ, IPEndPoint PJDANIPAHEH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x579E6B0", Offset = "0x579D0B0", VA = "0x18579E6B0")]
	private void FOAOCECNMFL(PPPEBKJPEBB GEACOMBPFIH, IPEndPoint GELMKHNOHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x579E550", Offset = "0x579CF50", VA = "0x18579E550")]
	private void DNFCAJLMFGK(HCBJMPEFNFK GEACOMBPFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x579E9A0", Offset = "0x579D3A0", VA = "0x18579E9A0")]
	private void PGEDEGEHOKA(HOCGKMMKJEH GEACOMBPFIH, IPEndPoint GELMKHNOHBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BMNEBGFOBGL : byte
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
public enum OMJCDDJFDCO : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NNHIHODHDKB
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] LKIPPKODNOL;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int CCNDLHDNFLG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int ADHDHAAFNED;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FDJHBHBHICK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x579E540", Offset = "0x579CF40", VA = "0x18579E540")]
	public FDJHBHBHICK(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LGJADMPMGAB : FDJHBHBHICK
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x579E540", Offset = "0x579CF40", VA = "0x18579E540")]
	public LGJADMPMGAB(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LGEOFJJCIAC
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
public interface BKOCONAAPLL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMAKHKMMOIC(LGEOFJJCIAC LDPLJMEDBBK, string LCECEOIPEEK, params object[] CADHKPGCKBL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDKMOLBHLFO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static BKOCONAAPLL MCFDNHBMDMD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object DNNBGAIDLPM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x579AE80", Offset = "0x5799880", VA = "0x18579AE80")]
	private static void ODDALMEEHDJ(LGEOFJJCIAC GENFENEHCAK, string LCECEOIPEEK, params object[] CADHKPGCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x579AD60", Offset = "0x5799760", VA = "0x18579AD60")]
	internal static void BJMIPJFBKBA(string LCECEOIPEEK, params object[] CADHKPGCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x579AE20", Offset = "0x5799820", VA = "0x18579AE20")]
	internal static void DEDAKACJJKE(string LCECEOIPEEK, params object[] CADHKPGCKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x579ADC0", Offset = "0x57997C0", VA = "0x18579ADC0")]
	internal static void CMLPMAOODIG(string LCECEOIPEEK, params object[] CADHKPGCKBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum KIOCBNLPOED
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NDKFPFEOFKA : DLMCPNMPKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private CPHIJMFOOJB KADGMJNLDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IEOIDIADAGK HFKBOCJNOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MJCKEKGIKAM HBPJNPDPLFG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57B0170", Offset = "0x57AEB70", VA = "0x1857B0170")]
	internal NDKFPFEOFKA(IEOIDIADAGK KEKOHNJFKFJ, MJCKEKGIKAM AAANINJIKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57B00D0", Offset = "0x57AEAD0", VA = "0x1857B00D0")]
	internal void LNFOKKNLPJA(CPHIJMFOOJB DHBMHKNGPCJ, int GCIPFMDINEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x57B0050", Offset = "0x57AEA50", VA = "0x1857B0050")]
	internal void BCHBGAFKLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x57B0140", Offset = "0x57AEB40", VA = "0x1857B0140")]
	public void LOFBHKOGOHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class MJCKEKGIKAM
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum KHHKGCMFNHF
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
	public MJCKEKGIKAM CAFNOMJCOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public KHHKGCMFNHF OHELAGOCJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public GJEPKKCALIJ BBMMMHLMMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint PANEKNKACCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object MPCLFDPMEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int BLKJDBEIELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError DCDHHICJMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public LHNBEBMLHOA JIENONGLHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public FNEJGDJNOHE FMENJABHHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public BMNEBGFOBGL FGLFCLKPONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte BCEMGMNDIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly NDKFPFEOFKA EFAIHGCIDIM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x57AFFB0", Offset = "0x57AE9B0", VA = "0x1857AFFB0")]
	public MJCKEKGIKAM(IEOIDIADAGK KEKOHNJFKFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IEOIDIADAGK : IEnumerable<GJEPKKCALIJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class KFPMENMJDAG : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x57ACDE0", Offset = "0x57AB7E0", VA = "0x1857ACDE0", Slot = "4")]
		public bool Equals(IPEndPoint HMCMBMJNNLE, IPEndPoint EGPNAKGBGLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5280900", Offset = "0x527F300", VA = "0x185280900", Slot = "5")]
		public int GetHashCode(IPEndPoint COMOOAEHALC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public KFPMENMJDAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LMCBCCNPCPO : IEnumerator<GJEPKKCALIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly GJEPKKCALIJ KLOFCMNBGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GJEPKKCALIJ PAMIJKEKFAK;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GJEPKKCALIJ EIIOCLGDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x91FF80", Offset = "0x91E980", VA = "0x18091FF80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x91FF80", Offset = "0x91E980", VA = "0x18091FF80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xFA8160", Offset = "0xFA6B60", VA = "0x180FA8160")]
		public LMCBCCNPCPO(GJEPKKCALIJ KDAABOPFDKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x57AE670", Offset = "0x57AD070", VA = "0x1857AE670", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57AE6C0", Offset = "0x57AD0C0", VA = "0x1857AE6C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread BADBEGJIHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool GDIIJPEBNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent OOGJMFIDGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<MJCKEKGIKAM> JHPPAGMOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<MJCKEKGIKAM> ECHMDBAJBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private MJCKEKGIKAM IIMJIFPMGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LLMPHNHPJOC BENNDICFMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KJDHMHGCGEB MEIIIGEEBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly EAHGKIGGDBC BOENMIADEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly ACNBIPBFLIL JGNGKKBBLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, GJEPKKCALIJ> IANLNBOKAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, FNEJGDJNOHE> KIIFMLFDAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, KOIAONMGJOF> JIPNHLFBGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim OCOJIINMKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GJEPKKCALIJ CICJMNMOFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int CGLDFJGIJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<GJEPKKCALIJ> ADBKHFPOPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GJEPKKCALIJ[] GAGNMBFKGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HFPIFPGIKDB OMBMFBGDEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int EPOKPMKHBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> DECGKHIDAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte GOCANBPKOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LEEHCEDJAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IBMBJBDIKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool DPMKFFBADEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int HAKKBKIKCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KFOHGBEIFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int EPOKKBCKIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int CHFMPNKKDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DKNJEEJICCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool HLEPDFBEKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int FAPDFHFJHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int HOCKCIPDLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int GCJLGAFLIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool IGMPLEHGFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool IKPJNAFLLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool BFPDFOCHAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool BLJEMCEFDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FFONGMIAGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int KJDMMOOFHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool BIGAJEFJJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly JGHHLEFPDLB ADNFLENCNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool NOEKIJBFPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly FJNMMDPEFIO JIDMPONCKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EGDAGACBIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public KIOCBNLPOED HBCOIPHAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int LGJEEGNLCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool IDGCCBALHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool ENCDEPJGPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool NNKKICFMJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool NAAKDLHEEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private CPHIJMFOOJB HGBPDEFLBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int ANHHMFHHMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object CNHLDHCBGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CPHIJMFOOJB BLLFNOJGEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NACJFKMOLIG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int ILBPCILGKAP = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int CFACHCGHBJO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private ALBABINKFBF KBNNELDIEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ALBABINKFBF ADLOAGIINGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OMNOPDCBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread HPCNIBAFJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint FEEGBGLIAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint PIMPHOLIJGL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] JJBBJOHHMDF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] FJOFKNKLKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NLPNFAIKKMA, IPEndPoint> OGGGIAAHGNG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress IOODEJEKKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool PDANLFKJPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int HFNEKHINEJA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OGNKICECFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA7F850", Offset = "0xA7E250", VA = "0x180A7F850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB4DED0", Offset = "0xB4C8D0", VA = "0x180B4DED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EMFGIMFNLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x135EF30", Offset = "0x135D930", VA = "0x18135EF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1686450", Offset = "0x1684E50", VA = "0x181686450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte EFDLEGNECIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E7FE0", Offset = "0x8E69E0", VA = "0x1808E7FE0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EIIKAGGMGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57A60A0", Offset = "0x57A4AA0", VA = "0x1857A60A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short AMKOGBELCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57A7EA0", Offset = "0x57A68A0", VA = "0x1857A7EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x57A73E0", Offset = "0x57A5DE0", VA = "0x1857A73E0")]
	public void JBMGBHNMDIA(IPEndPoint BDGAKFBHHMD, byte[] KLDFLAABJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x57A5490", Offset = "0x57A3E90", VA = "0x1857A5490")]
	public void CFNBAMAJIBL(IPEndPoint BDGAKFBHHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x57A7650", Offset = "0x57A6050", VA = "0x1857A7650")]
	private bool JGGKDBGMPGF(IPEndPoint BDGAKFBHHMD, [Out] GJEPKKCALIJ ABAMMHKFCAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x57A8AE0", Offset = "0x57A74E0", VA = "0x1857A8AE0")]
	private void MDENBKHDGPC(GJEPKKCALIJ ABAMMHKFCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x57A7F60", Offset = "0x57A6960", VA = "0x1857A7F60")]
	private void JPMHGJMAKPD(GJEPKKCALIJ ABAMMHKFCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x57A8DA0", Offset = "0x57A77A0", VA = "0x1857A8DA0")]
	private void MHHGECKKKJO(GJEPKKCALIJ ABAMMHKFCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x57AAF90", Offset = "0x57A9990", VA = "0x1857AAF90")]
	public IEOIDIADAGK(LLMPHNHPJOC DHCGHGOKJFG, [Optional] HFPIFPGIKDB NGKLBCGNODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x57AA8B0", Offset = "0x57A92B0", VA = "0x1857AA8B0")]
	internal void OGKFGJOIPMG(GJEPKKCALIJ GBFJLOKPOJB, int GEGEKBGGJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x57A5440", Offset = "0x57A3E40", VA = "0x1857A5440")]
	internal void BJOOPPHHDCJ(GJEPKKCALIJ GBFJLOKPOJB, object GEGMONMODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57A4BA0", Offset = "0x57A35A0", VA = "0x1857A4BA0")]
	internal void ANDANDAHKPJ(GJEPKKCALIJ ABAMMHKFCAA, LHNBEBMLHOA FKOGKDPANPE, SocketError LMFNLHHIHLM, CPHIJMFOOJB MOCDKEGGLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x57A7300", Offset = "0x57A5D00", VA = "0x1857A7300")]
	private void IFLOGEFBONI(GJEPKKCALIJ ABAMMHKFCAA, LHNBEBMLHOA FKOGKDPANPE, SocketError LMFNLHHIHLM, bool AHPBABJEPBH, byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int GBACAOOHJGH, CPHIJMFOOJB MOCDKEGGLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57A46E0", Offset = "0x57A30E0", VA = "0x1857A46E0")]
	private void ABJIDPFBKNN(MJCKEKGIKAM.KHHKGCMFNHF CGEOAHHPHHK, [Optional] GJEPKKCALIJ ABAMMHKFCAA, [Optional] IPEndPoint MBNHLDIFNDP, SocketError DBHLKMLCOPG = SocketError.Success, int GEGEKBGGJNI = 0, LHNBEBMLHOA MCBMGDFLOHH = LHNBEBMLHOA.ConnectionFailed, [Optional] FNEJGDJNOHE NHEEINMJILL, BMNEBGFOBGL GMBMMEOGOML = BMNEBGFOBGL.Unreliable, byte OJMMNENGIIE = 0, [Optional] CPHIJMFOOJB DOAEIANIBGP, [Optional] object GEGMONMODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57A4C70", Offset = "0x57A3670", VA = "0x1857A4C70")]
	private void BHBIIEKAEJK(MJCKEKGIKAM AAANINJIKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57A4AA0", Offset = "0x57A34A0", VA = "0x1857A4AA0")]
	internal void AJHBKPODPKN(MJCKEKGIKAM AAANINJIKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x57A9000", Offset = "0x57A7A00", VA = "0x1857A9000")]
	private void MLKOBHFPKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x57A5D80", Offset = "0x57A4780", VA = "0x1857A5D80")]
	private void EEMELAJECBG(int FOHIABLLLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x57A76E0", Offset = "0x57A60E0", VA = "0x1857A76E0")]
	internal GJEPKKCALIJ JGPKNCEMIOF(FNEJGDJNOHE ELBMMMMNOAO, byte[] EPLLMFOAFJP, int HDAPKPHIPPD, int JEKCEPEEELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x57A8A60", Offset = "0x57A7460", VA = "0x1857A8A60")]
	private int LKAFKAGKKLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x57A7FB0", Offset = "0x57A69B0", VA = "0x1857A7FB0")]
	private void LCCBFPINEOA(IPEndPoint MBNHLDIFNDP, GJEPKKCALIJ OLCCMCMFAOL, HCBODIGFKEF AFLFGLPDJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x57A9560", Offset = "0x57A7F60", VA = "0x1857A9560")]
	private void NPCGJONPGKJ(CPHIJMFOOJB DHBMHKNGPCJ, IPEndPoint MBNHLDIFNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x57A8410", Offset = "0x57A6E10", VA = "0x1857A8410")]
	internal void LGGAIOKLGCP(CPHIJMFOOJB DHBMHKNGPCJ, BMNEBGFOBGL AJMAHONKGGP, byte OJMMNENGIIE, int GCIPFMDINEI, GJEPKKCALIJ GBFJLOKPOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x57A6900", Offset = "0x57A5300", VA = "0x1857A6900")]
	public bool HBIPAHEJJPN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57A6910", Offset = "0x57A5310", VA = "0x1857A6910")]
	public bool HBIPAHEJJPN(IPAddress IGGMPEFJJMN, IPAddress PJPLHPDIBBI, int CADBBPNNJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x57A60C0", Offset = "0x57A4AC0", VA = "0x1857A60C0")]
	public bool HBIPAHEJJPN(int CADBBPNNJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x57A7D00", Offset = "0x57A6700", VA = "0x1857A7D00")]
	public void JHOMGHDEAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x57A6DE0", Offset = "0x57A57E0", VA = "0x1857A6DE0")]
	public GJEPKKCALIJ HCGBFNEAHKE(string ACDAPODGMCA, int CADBBPNNJIP, string KLDFLAABJKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x57A6930", Offset = "0x57A5330", VA = "0x1857A6930")]
	public GJEPKKCALIJ HCGBFNEAHKE(string ACDAPODGMCA, int CADBBPNNJIP, KOMLPBDJGLD CNNGGDKECKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x57A6A10", Offset = "0x57A5410", VA = "0x1857A6A10")]
	public GJEPKKCALIJ HCGBFNEAHKE(IPEndPoint PJDANIPAHEH, KOMLPBDJGLD CNNGGDKECKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57AACB0", Offset = "0x57A96B0", VA = "0x1857AACB0")]
	public void PLAOOGBPCGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x57AA960", Offset = "0x57A9360", VA = "0x1857AA960")]
	public void PLAOOGBPCGB(bool KPHKPFJADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x57A9340", Offset = "0x57A7D40", VA = "0x1857A9340")]
	public void NCAHKGOKIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57A9440", Offset = "0x57A7E40", VA = "0x1857A9440")]
	public void NCAHKGOKIKM(byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int GBACAOOHJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x57A7190", Offset = "0x57A5B90", VA = "0x1857A7190")]
	public void IFLOGEFBONI(GJEPKKCALIJ ABAMMHKFCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x57A7240", Offset = "0x57A5C40", VA = "0x1857A7240")]
	public void IFLOGEFBONI(GJEPKKCALIJ ABAMMHKFCAA, byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int GBACAOOHJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x57AADB0", Offset = "0x57A97B0", VA = "0x1857AADB0", Slot = "4")]
	private IEnumerator<GJEPKKCALIJ> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x57AAE40", Offset = "0x57A9840", VA = "0x1857AAE40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57A7480", Offset = "0x57A5E80", VA = "0x1857A7480")]
	private CPHIJMFOOJB JGGAJBPPFBN(JPHHJKLBMCG DMJMLGBLOFK, int CBAOPDHODHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57A7570", Offset = "0x57A5F70", VA = "0x1857A7570")]
	private CPHIJMFOOJB JGGAJBPPFBN(JPHHJKLBMCG DMJMLGBLOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57AA2B0", Offset = "0x57A8CB0", VA = "0x1857AA2B0")]
	internal CPHIJMFOOJB OBBDHBOIKLF(int CBAOPDHODHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x57AA650", Offset = "0x57A9050", VA = "0x1857AA650")]
	internal void OFBMFKHGFNJ(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x57AAED0", Offset = "0x57A98D0", VA = "0x1857AAED0")]
	static IEOIDIADAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA7F850", Offset = "0xA7E250", VA = "0x180A7F850")]
	private bool KPHMPCAONGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x57AACC0", Offset = "0x57A96C0", VA = "0x1857AACC0")]
	private void POBIKLMGMCC(IPEndPoint AGIOIHHEBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x57A4600", Offset = "0x57A3000", VA = "0x1857A4600")]
	private void AAEEJMMADAH(IPEndPoint AGIOIHHEBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x57A55E0", Offset = "0x57A3FE0", VA = "0x1857A55E0")]
	private bool CIEMEKHJGNF(SocketException PBPEDJNJMOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x57A6EC0", Offset = "0x57A58C0", VA = "0x1857A6EC0")]
	private void HPJACBNMKEG(ALBABINKFBF BOANGPNPCHH, EndPoint NPDJMLIDLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x57A86D0", Offset = "0x57A70D0", VA = "0x1857A86D0")]
	private void LIBCHEMHFMA(object MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x57A6140", Offset = "0x57A4B40", VA = "0x1857A6140")]
	public bool HBIPAHEJJPN(IPAddress IGGMPEFJJMN, IPAddress PJPLHPDIBBI, int CADBBPNNJIP, bool INJCONAONOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x57AA900", Offset = "0x57A9300", VA = "0x1857AA900")]
	internal int OLJGPGBPALK(CPHIJMFOOJB DHBMHKNGPCJ, IPEndPoint MBNHLDIFNDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x57A5780", Offset = "0x57A4180", VA = "0x1857A5780")]
	internal int CIIOMABOLIK(CPHIJMFOOJB DHBMHKNGPCJ, IPEndPoint MBNHLDIFNDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x57A57C0", Offset = "0x57A41C0", VA = "0x1857A57C0")]
	internal int CIIOMABOLIK(byte[] CPPFNMDMGHI, int HDAPKPHIPPD, int JEKCEPEEELJ, IPEndPoint MBNHLDIFNDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x57AA4E0", Offset = "0x57A8EE0", VA = "0x1857AA4E0")]
	internal void ODFPBDCKMMM(bool LJIGAOPKOJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum JPHHJKLBMCG : byte
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
internal sealed class CPHIJMFOOJB
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int JNFAADNJLJO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] HFKDHBPBBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] OGMDHOPHFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int LIKCBNMIJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object MPCLFDPMEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public CPHIJMFOOJB CAFNOMJCOAB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public JPHHJKLBMCG MIIKBAKIKGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x579B160", Offset = "0x5799B60", VA = "0x18579B160")]
		get
		{
			return default(JPHHJKLBMCG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x579B500", Offset = "0x5799F00", VA = "0x18579B500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte BLNFCAKAHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x579B610", Offset = "0x579A010", VA = "0x18579B610")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x579B5D0", Offset = "0x5799FD0", VA = "0x18579B5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MDGPGKKLHJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x579B420", Offset = "0x5799E20", VA = "0x18579B420")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x579B740", Offset = "0x579A140", VA = "0x18579B740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool HJELGDIIPCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x579B5A0", Offset = "0x5799FA0", VA = "0x18579B5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LPOPLALICOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x579B230", Offset = "0x5799C30", VA = "0x18579B230")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x579B190", Offset = "0x5799B90", VA = "0x18579B190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CMILNPLLHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x579B540", Offset = "0x5799F40", VA = "0x18579B540")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x579B4C0", Offset = "0x5799EC0", VA = "0x18579B4C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ADIFBEBHFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x579B360", Offset = "0x5799D60", VA = "0x18579B360")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x579B480", Offset = "0x5799E80", VA = "0x18579B480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort GBCLNGDOIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x579B3C0", Offset = "0x5799DC0", VA = "0x18579B3C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x579B1F0", Offset = "0x5799BF0", VA = "0x18579B1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x579B780", Offset = "0x579A180", VA = "0x18579B780")]
	static CPHIJMFOOJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x579B1C0", Offset = "0x5799BC0", VA = "0x18579B1C0")]
	public void BLCONEKPKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x579BB70", Offset = "0x579A570", VA = "0x18579BB70")]
	public CPHIJMFOOJB(int CBAOPDHODHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x579BA60", Offset = "0x579A460", VA = "0x18579BA60")]
	public CPHIJMFOOJB(JPHHJKLBMCG DMJMLGBLOFK, int CBAOPDHODHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x579B6D0", Offset = "0x579A0D0", VA = "0x18579B6D0")]
	public static int OMBLNPFCJBG(JPHHJKLBMCG DMJMLGBLOFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x579B640", Offset = "0x579A040", VA = "0x18579B640")]
	public int OMBLNPFCJBG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x579B260", Offset = "0x5799C60", VA = "0x18579B260")]
	public bool DDJEMOAKOFP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum GNFNBKLFCPC : byte
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
internal enum PMHGKOOHFML
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
internal enum PNEAOHKJOPN
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum IFLDIOFPGNA
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GJEPKKCALIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class HCPCKKPJPCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CPHIJMFOOJB[] OCJAFHGLCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int CLDDDPKBGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int DEPLOFHEAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte LPOPLALICOI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public HCPCKKPJPCK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void PHAOHMMPMEK(ulong GMAPDLFDMIJ, int CHKBDDJBLPH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int ANFCPNICMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int JKPDBIDFKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int LABOICHLCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double MCFLCHNENGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BLNDHKCDJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int BBCPPDCLCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int OPILIEJIHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch AELNLOCCKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int BKFDALNFGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FBGPMINMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object OOPMCDOLILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal GJEPKKCALIJ HGGMAOBENGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal GJEPKKCALIJ OHIJFOKOKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<CPHIJMFOOJB> IJHKCIKMMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<OCNJKOEAJML> KPGAHEDBPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OCNJKOEAJML[] BKFIAHOFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int KMEJIGGEJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int JJNJBFHPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool GFBHFCMNKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int JNGDJGCECPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int FDEGKKGHKNC;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int HFDODILAAMC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int FGOECKGHGLE = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object APCEHCADAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CLIAHLEKAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, HCPCKKPJPCK> NCLNGCEFALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> DECFDDAJFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CPHIJMFOOJB PGLEJLAFPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int FFKMMOAKGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int GLAKMIDALCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint FICDMNHMGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int OJJNAKAOCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int OLABCODLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long GMGHPIEGMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte NHGPFPKNMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GNFNBKLFCPC BDLKBJACIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private CPHIJMFOOJB AOCMPGNPPIM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int GOJLBCFODNJ = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EJKDALOHAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly CPHIJMFOOJB FOOEPIBKAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly CPHIJMFOOJB FAMHFMHLNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly CPHIJMFOOJB CPOLJHDFCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly CPHIJMFOOJB NEOPNBPDCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private OMJCDDJFDCO LLHJNFFOLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly IEOIDIADAGK BCMDPFNCCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int PHMNCFOHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object DBDAOHAJPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly JGHHLEFPDLB ADNFLENCNNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte IHJFIPFNOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAE29F0", Offset = "0xAE13F0", VA = "0x180AE29F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x57A2370", Offset = "0x57A0D70", VA = "0x1857A2370")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint FGLGHCHFFOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8F13A0", Offset = "0x8EFDA0", VA = "0x1808F13A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GNFNBKLFCPC EGELLMEPDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x16A34C0", Offset = "0x16A1EC0", VA = "0x1816A34C0")]
		get
		{
			return default(GNFNBKLFCPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KJOOJDJKFNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7CD440", Offset = "0x7CBE40", VA = "0x1807CD440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int EJDENAPJHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB91ED0", Offset = "0xB908D0", VA = "0x180B91ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x14AFD00", Offset = "0x14AE700", VA = "0x1814AFD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int GOHPNHFKIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x57A1CB0", Offset = "0x57A06B0", VA = "0x1857A1CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ONOMOCENDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D24E0", Offset = "0x7D0EE0", VA = "0x1807D24E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double BGLLEOFJEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x18D54D0", Offset = "0x18D3ED0", VA = "0x1818D54D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PHAOHMMPMEK KPLKJJFOEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x579F540", Offset = "0x579DF40", VA = "0x18579F540")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x579F5F0", Offset = "0x579DFF0", VA = "0x18579F5F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x57A2B00", Offset = "0x57A1500", VA = "0x1857A2B00")]
	internal GJEPKKCALIJ(IEOIDIADAGK GNBCOOHLAAP, IPEndPoint MBNHLDIFNDP, int MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x579FCE0", Offset = "0x579E6E0", VA = "0x18579FCE0")]
	internal void GMNDOOCCHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x579F480", Offset = "0x579DE80", VA = "0x18579F480")]
	internal void DOPELPFNMHE(IPEndPoint ALAHLFPHGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x579F3F0", Offset = "0x579DDF0", VA = "0x18579F3F0")]
	internal void DAOKEHBHKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x57A1540", Offset = "0x579FF40", VA = "0x1857A1540")]
	private void MCNBCBIHEIB(int LGJDAIFMEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x57A1C40", Offset = "0x57A0640", VA = "0x1857A1C40")]
	private void NCFNCBGCKJK(int MMHJJAKGAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x57A0DA0", Offset = "0x579F7A0", VA = "0x1857A0DA0")]
	private OCNJKOEAJML JMCOOPNJIDH(byte OGNEKOOOPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x57A2970", Offset = "0x57A1370", VA = "0x1857A2970")]
	internal GJEPKKCALIJ(IEOIDIADAGK GNBCOOHLAAP, IPEndPoint MBNHLDIFNDP, int MCGNHGLIJDN, byte DBMEAPIENFA, KOMLPBDJGLD DBOANJPLNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x57A2F60", Offset = "0x57A1960", VA = "0x1857A2F60")]
	internal GJEPKKCALIJ(IEOIDIADAGK GNBCOOHLAAP, FNEJGDJNOHE ELBMMMMNOAO, int MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x579F4F0", Offset = "0x579DEF0", VA = "0x18579F4F0")]
	internal void EBOPKIDEKOD(HCBODIGFKEF LOFEKHLFBMP, byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int JEKCEPEEELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x579F370", Offset = "0x579DD70", VA = "0x18579F370")]
	internal bool CEJKJHNDKKE(HFMINLDHDOB DHBMHKNGPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x57A1C80", Offset = "0x57A0680", VA = "0x1857A1C80")]
	public void NJJKMAMJCGK(byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int JEKCEPEEELJ, BMNEBGFOBGL KCIHFJELBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x57A2420", Offset = "0x57A0E20", VA = "0x1857A2420")]
	private void PKBDOFONLAJ(byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int JEKCEPEEELJ, byte OJMMNENGIIE, BMNEBGFOBGL GMBMMEOGOML, object GEGMONMODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x579F0F0", Offset = "0x579DAF0", VA = "0x18579F0F0")]
	public void AOELLFNMKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x57A1B60", Offset = "0x57A0560", VA = "0x1857A1B60")]
	internal PNEAOHKJOPN MKOAHEACLJA(CPHIJMFOOJB DHBMHKNGPCJ)
	{
		return default(PNEAOHKJOPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x579FD00", Offset = "0x579E700", VA = "0x18579FD00")]
	internal void GNALAHEGFAE(OCNJKOEAJML MJGPGNEGODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x57A1230", Offset = "0x579FC30", VA = "0x1857A1230")]
	internal IFLDIOFPGNA LDOMKFLOENA(byte[] ABDLEBPKDKC, int HDAPKPHIPPD, int JEKCEPEEELJ, bool AHPBABJEPBH)
	{
		return default(IFLDIOFPGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x579F4B0", Offset = "0x579DEB0", VA = "0x18579F4B0")]
	private void DPOFGKCKLLD(int CPJFLLMNIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x579FD60", Offset = "0x579E760", VA = "0x18579FD60")]
	internal void IHIHIHFOGJO(BMNEBGFOBGL AJMAHONKGGP, CPHIJMFOOJB KDAABOPFDKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x57A1610", Offset = "0x57A0010", VA = "0x1857A1610")]
	private void MKCBCLJDPDM(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x579F6A0", Offset = "0x579E0A0", VA = "0x18579F6A0")]
	private void FPLAAFEGHIG(int JFNONBMGLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57A1070", Offset = "0x579FA70", VA = "0x1857A1070")]
	internal PMHGKOOHFML LCCBFPINEOA(HCBODIGFKEF AFLFGLPDJAN)
	{
		return default(PMHGKOOHFML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x57A1CC0", Offset = "0x57A06C0", VA = "0x1857A1CC0")]
	internal void OFOGDGCMMAN(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x57A0F50", Offset = "0x579F950", VA = "0x1857A0F50")]
	private void JNLDKCDPKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x579F1A0", Offset = "0x579DBA0", VA = "0x18579F1A0")]
	internal void CEBHOLMIMHD(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x57A06F0", Offset = "0x579F0F0", VA = "0x1857A06F0")]
	internal void JACDOJBEGNB(int JFNONBMGLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x579FA20", Offset = "0x579E420", VA = "0x18579FA20")]
	internal void GKMBJMFFJJI(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class JGHHLEFPDLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long JIJIAJBIOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long GPBBHACJBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long FFAMEFHPAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long IDIKLNKDJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long CGICABEFPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long DBFINBEHJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long ONELKKJCNHP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long EJLGBDGMMML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x57AB760", Offset = "0x57AA160", VA = "0x1857AB760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EPKAEOOEILF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x57AB5E0", Offset = "0x57A9FE0", VA = "0x1857AB5E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long GNNHGKGNDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x57AB750", Offset = "0x57AA150", VA = "0x1857AB750")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long PMJGCAOBIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x57AB7F0", Offset = "0x57AA1F0", VA = "0x1857AB7F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long GNKDLHFBAKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x57AB800", Offset = "0x57AA200", VA = "0x1857AB800")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long HFGMMBBOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x57AB7E0", Offset = "0x57AA1E0", VA = "0x1857AB7E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private OMJCDDJFDCO BADINFMAGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x57AB620", Offset = "0x57AA020", VA = "0x1857AB620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double JKNNCNBPGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x57AB770", Offset = "0x57AA170", VA = "0x1857AB770")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x57AB6E0", Offset = "0x57AA0E0", VA = "0x1857AB6E0")]
	public void EMPGGONCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x57AB810", Offset = "0x57AA210", VA = "0x1857AB810")]
	public void LILMCNKFLBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x57AB740", Offset = "0x57AA140", VA = "0x1857AB740")]
	public void FMBKLOMLFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x57AB6D0", Offset = "0x57AA0D0", VA = "0x1857AB6D0")]
	public void DKDEBFAAJED(long PKNMBBJEADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x57AB7D0", Offset = "0x57AA1D0", VA = "0x1857AB7D0")]
	public void JFJHHOFOEID(long GMHHDLBOHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x57AB5F0", Offset = "0x57A9FF0", VA = "0x1857AB5F0")]
	public void BEJLAPKDNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x57AB840", Offset = "0x57AA240", VA = "0x1857AB840")]
	public void PNOMFFNECPN(long HCIACFNHEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x57AB880", Offset = "0x57AA280", VA = "0x1857AB880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x57AB630", Offset = "0x57AA030", VA = "0x1857AB630")]
	public void CPPCHPMECME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public JGHHLEFPDLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OEHAAANNJHK
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> JLFNEBMNHIL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x57B08D0", Offset = "0x57AF2D0", VA = "0x1857B08D0")]
	public static IPEndPoint PFLFNBOPCBL(string MLPHDJLNNPI, int CADBBPNNJIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x57B0670", Offset = "0x57AF070", VA = "0x1857B0670")]
	public static IPAddress IPMBGKGNCKN(string MLPHDJLNNPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x57B0840", Offset = "0x57AF240", VA = "0x1857B0840")]
	public static IPAddress IPMBGKGNCKN(string MLPHDJLNNPI, AddressFamily MBKPMFJOPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x57B0640", Offset = "0x57AF040", VA = "0x1857B0640")]
	internal static int CALBMAKKKBC(int ELAODGMOOIJ, int MMBMIJCDMIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3E20", Offset = "0x2AB2820", VA = "0x182AB3E20")]
	internal static T[] FNOJEFGGKKF<T>(int GBACAOOHJGH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KCGAEGNNAOB : OCNJKOEAJML
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct JNDGGFKCJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private CPHIJMFOOJB KADGMJNLDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long PBFMGBHHCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool HPBKJMHBLPH;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x57ABCA0", Offset = "0x57AA6A0", VA = "0x1857ABCA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x57ABBC0", Offset = "0x57AA5C0", VA = "0x1857ABBC0")]
		public void BMGPKAMLICG(CPHIJMFOOJB DHBMHKNGPCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x57ABBE0", Offset = "0x57AA5E0", VA = "0x1857ABBE0")]
		public bool KLGLMGAGDDB(long JOMOLCJEMBE, GJEPKKCALIJ ABAMMHKFCAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x57ABC50", Offset = "0x57AA650", VA = "0x1857ABC50")]
		public bool LDCFGOINEDJ(GJEPKKCALIJ ABAMMHKFCAA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly CPHIJMFOOJB GHKHHMBNNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly JNDGGFKCJKI[] HNFPHNHJHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly CPHIJMFOOJB[] APJKAGMPJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] LDEDBEMFLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int FFJGNOCICOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GJDFAIBKKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int EDGEIGPJMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int JJJHCDNHOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool JNJEFFCHHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly BMNEBGFOBGL LGBHFKLDLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool BNNFJKIMPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int CMHPLHMHFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte KFKNAKGGAFE;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x57ACC10", Offset = "0x57AB610", VA = "0x1857ACC10")]
	public KCGAEGNNAOB(GJEPKKCALIJ ABAMMHKFCAA, bool GKEDJGGENGB, byte MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x57ABD40", Offset = "0x57AA740", VA = "0x1857ABD40")]
	private void LGBCEIFHMHK(CPHIJMFOOJB DHBMHKNGPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x57AC760", Offset = "0x57AB160", VA = "0x1857AC760", Slot = "4")]
	protected override bool OPDOEJOOMOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x57AC100", Offset = "0x57AAB00", VA = "0x1857AC100", Slot = "5")]
	public override bool OFOGDGCMMAN(CPHIJMFOOJB DHBMHKNGPCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LLABNCLNPOD : OCNJKOEAJML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HADAOFMEEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort GJDFAIBKKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool LENABIBKPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private CPHIJMFOOJB FPDJJAOIICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly CPHIJMFOOJB BMELFMGKHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool AEMFHCJPNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte KFKNAKGGAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long MGKNHCIMNMP;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x57AE5B0", Offset = "0x57ACFB0", VA = "0x1857AE5B0")]
	public LLABNCLNPOD(GJEPKKCALIJ ABAMMHKFCAA, bool MKONJELFENA, byte MCGNHGLIJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x57AE110", Offset = "0x57ACB10", VA = "0x1857AE110", Slot = "4")]
	protected override bool OPDOEJOOMOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x57ADE00", Offset = "0x57AC800", VA = "0x1857ADE00", Slot = "5")]
	public override bool OFOGDGCMMAN(CPHIJMFOOJB DHBMHKNGPCJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EHGOMDCIJCM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct HBPGKEMBKOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong FMLOFCFHNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double JMIIMJBNOKB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct EBCBOBCPBFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int HCHAACEOJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float PAJPBGBIMIB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x579A850", Offset = "0x5799250", VA = "0x18579A850")]
	private static void DDNBJOHDJPO(byte[] PJIBFCJPNLC, int KNFIDNLGJFO, ulong ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x579DC00", Offset = "0x579C600", VA = "0x18579DC00")]
	private static void DDNBJOHDJPO(byte[] PJIBFCJPNLC, int KNFIDNLGJFO, int ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x579DBC0", Offset = "0x579C5C0", VA = "0x18579DBC0")]
	public static void DDNBJOHDJPO(byte[] PJIBFCJPNLC, int KNFIDNLGJFO, short ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x579DC80", Offset = "0x579C680", VA = "0x18579DC80")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, double AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x579DCA0", Offset = "0x579C6A0", VA = "0x18579DCA0")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x579DBC0", Offset = "0x579C5C0", VA = "0x18579DBC0")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, short AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x579DBC0", Offset = "0x579C5C0", VA = "0x18579DBC0")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, ushort AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x579DC00", Offset = "0x579C600", VA = "0x18579DC00")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x579DC00", Offset = "0x579C600", VA = "0x18579DC00")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, uint AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x579DC70", Offset = "0x579C670", VA = "0x18579DC70")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, long AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x579DC70", Offset = "0x579C670", VA = "0x18579DC70")]
	public static void PGACHIMJPOC(byte[] OIKPPLLAJOB, int ALMDOMLFINK, ulong AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DLMCPNMPKIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] NOHGJHABJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int LGBGGCPFBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int IKEAFGKACKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int LDEEAFIFMGL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] OGMDHOPHFKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int FDKJOCKFHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83FF90", Offset = "0x83E990", VA = "0x18083FF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int PHEFENKLALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x579C610", Offset = "0x579B010", VA = "0x18579C610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool AOIMCOAEKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D915D0", Offset = "0x1D8FFD0", VA = "0x181D915D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NNOICLNFAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x579C190", Offset = "0x579AB90", VA = "0x18579C190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x579C560", Offset = "0x579AF60", VA = "0x18579C560")]
	public void LNFOKKNLPJA(byte[] HIHHIJKIJFM, int KNFIDNLGJFO, int FJGIAAMGKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public DLMCPNMPKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x579C7D0", Offset = "0x579B1D0", VA = "0x18579C7D0")]
	public DLMCPNMPKIP(byte[] HIHHIJKIJFM, int KNFIDNLGJFO, int FJGIAAMGKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x579BF90", Offset = "0x579A990", VA = "0x18579BF90")]
	public IPEndPoint EBLMMHMKNAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x579C060", Offset = "0x579AA60", VA = "0x18579C060")]
	public byte ELEBEAGMKNH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x579C060", Offset = "0x579AA60", VA = "0x18579C060")]
	public sbyte KGENBFGAIJM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27E77C0", Offset = "0x27E61C0", VA = "0x1827E77C0")]
	public T[] GAKNOLPODNO<T>(ushort CBAOPDHODHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x579C790", Offset = "0x579B190", VA = "0x18579C790")]
	public bool[] OKJEHOGIJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x579BC60", Offset = "0x579A660", VA = "0x18579BC60")]
	public ushort[] BCLKLGIGCBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x579BBE0", Offset = "0x579A5E0", VA = "0x18579BBE0")]
	public short[] AOMAJAJPNMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x579C0E0", Offset = "0x579AAE0", VA = "0x18579C0E0")]
	public int[] GDEHMKPFOAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x579C620", Offset = "0x579B020", VA = "0x18579C620")]
	public uint[] MEFELGLHELE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x579BC20", Offset = "0x579A620", VA = "0x18579BC20")]
	public float[] BBMLEKKIBLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x579C660", Offset = "0x579B060", VA = "0x18579C660")]
	public double[] MJEHIICLHKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x579BF50", Offset = "0x579A950", VA = "0x18579BF50")]
	public long[] DPHCLLJJHNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x579C710", Offset = "0x579B110", VA = "0x18579C710")]
	public ulong[] OCGIOJFPMLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x579C430", Offset = "0x579AE30", VA = "0x18579C430")]
	public string[] LLHMIHJMLMI(int JEJEKPODNKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x579C0A0", Offset = "0x579AAA0", VA = "0x18579C0A0")]
	public bool FKFKEBBFGKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x579C210", Offset = "0x579AC10", VA = "0x18579C210")]
	public char PFEMPIPDEML()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x579C210", Offset = "0x579AC10", VA = "0x18579C210")]
	public ushort JAAMKHOOFID()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x579C5A0", Offset = "0x579AFA0", VA = "0x18579C5A0")]
	public short LPAIEOIHOPK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x579C2F0", Offset = "0x579ACF0", VA = "0x18579C2F0")]
	public long LBGPLEEDOFO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x579C120", Offset = "0x579AB20", VA = "0x18579C120")]
	public ulong GHAMMGFBDPA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x579C380", Offset = "0x579AD80", VA = "0x18579C380")]
	public int LDNOPPEHGDH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x579C280", Offset = "0x579AC80", VA = "0x18579C280")]
	public uint KHFOOKIAIHJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x579BEE0", Offset = "0x579A8E0", VA = "0x18579BEE0")]
	public float DODJEOPGCBH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x579C6A0", Offset = "0x579B0A0", VA = "0x18579C6A0")]
	public double NFAAOCAGHIF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x579BCA0", Offset = "0x579A6A0", VA = "0x18579BCA0")]
	public string BLMEGEJMMEI(int AFOAGHLPAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x579C1A0", Offset = "0x579ABA0", VA = "0x18579C1A0")]
	public ArraySegment<byte> GKNGBDKMEEE(int GBACAOOHJGH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x579C3F0", Offset = "0x579ADF0", VA = "0x18579C3F0")]
	public sbyte[] LGOGMNMLCIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x579C750", Offset = "0x579B150", VA = "0x18579C750")]
	public byte[] OENAMLHLIEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x579C360", Offset = "0x579AD60", VA = "0x18579C360")]
	public void LDCFGOINEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KOMLPBDJGLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] NOHGJHABJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int LGBGGCPFBID;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int GOEINPJEHBM = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool KHPPEDHPEPG;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding BPFNDFOEPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int MLPAPAOMFIP = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] JINOGOHCHLB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] PICICNMEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int EEALFJDFGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFB0", Offset = "0x7CA9B0", VA = "0x1807CBFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x57ADD80", Offset = "0x57AC780", VA = "0x1857ADD80")]
	public KOMLPBDJGLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x57ADCE0", Offset = "0x57AC6E0", VA = "0x1857ADCE0")]
	public KOMLPBDJGLD(bool DCFDLKKCBBB, int NNMLMCFPLLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x57AD090", Offset = "0x57ABA90", VA = "0x1857AD090")]
	public static KOMLPBDJGLD BGGGLJOCAFP(string AEJBOLFACJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x57AD100", Offset = "0x57ABB00", VA = "0x1857AD100")]
	public void GCBIOEEIMNB(int KMDOMBAILCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B960", Offset = "0x1E0A360", VA = "0x181E0B960")]
	public void EMPGGONCJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x57ADBB0", Offset = "0x57AC5B0", VA = "0x1857ADBB0")]
	public void JAMMFKMMAML(float AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x57ADA90", Offset = "0x57AC490", VA = "0x1857ADA90")]
	public void JAMMFKMMAML(double AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x57AD5F0", Offset = "0x57ABFF0", VA = "0x1857AD5F0")]
	public void JAMMFKMMAML(long AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x57AD5F0", Offset = "0x57ABFF0", VA = "0x1857AD5F0")]
	public void JAMMFKMMAML(ulong AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x57AD8C0", Offset = "0x57AC2C0", VA = "0x1857AD8C0")]
	public void JAMMFKMMAML(int AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x57AD8C0", Offset = "0x57AC2C0", VA = "0x1857AD8C0")]
	public void JAMMFKMMAML(uint AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x57AD640", Offset = "0x57AC040", VA = "0x1857AD640")]
	public void JAMMFKMMAML(char AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x57AD640", Offset = "0x57AC040", VA = "0x1857AD640")]
	public void JAMMFKMMAML(ushort AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x57AD640", Offset = "0x57AC040", VA = "0x1857AD640")]
	public void JAMMFKMMAML(short AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x57AD950", Offset = "0x57AC350", VA = "0x1857AD950")]
	public void JAMMFKMMAML(sbyte AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x57AD950", Offset = "0x57AC350", VA = "0x1857AD950")]
	public void JAMMFKMMAML(byte AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x57ADB40", Offset = "0x57AC540", VA = "0x1857ADB40")]
	public void JAMMFKMMAML(byte[] ABDLEBPKDKC, int KNFIDNLGJFO, int JEKCEPEEELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x57ACFB0", Offset = "0x57AB9B0", VA = "0x1857ACFB0")]
	public void ACJNFAOFLBI(sbyte[] ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x57ACFB0", Offset = "0x57AB9B0", VA = "0x1857ACFB0")]
	public void OJDCGFCPFPD(byte[] ABDLEBPKDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x57ADAE0", Offset = "0x57AC4E0", VA = "0x1857ADAE0")]
	public void JAMMFKMMAML(bool AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x57AD440", Offset = "0x57ABE40", VA = "0x1857AD440")]
	public void IOHBDOEAPGK(Array FLICKKHKDEJ, int AJIAJCNOGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x57AD360", Offset = "0x57ABD60", VA = "0x1857AD360")]
	public void IOHBDOEAPGK(float[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x57AD280", Offset = "0x57ABC80", VA = "0x1857AD280")]
	public void IOHBDOEAPGK(double[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x57AD280", Offset = "0x57ABC80", VA = "0x1857AD280")]
	public void IOHBDOEAPGK(long[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x57AD280", Offset = "0x57ABC80", VA = "0x1857AD280")]
	public void IOHBDOEAPGK(ulong[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x57AD360", Offset = "0x57ABD60", VA = "0x1857AD360")]
	public void IOHBDOEAPGK(int[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x57AD360", Offset = "0x57ABD60", VA = "0x1857AD360")]
	public void IOHBDOEAPGK(uint[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x57AD1A0", Offset = "0x57ABBA0", VA = "0x1857AD1A0")]
	public void IOHBDOEAPGK(ushort[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x57AD1A0", Offset = "0x57ABBA0", VA = "0x1857AD1A0")]
	public void IOHBDOEAPGK(short[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x57ACFB0", Offset = "0x57AB9B0", VA = "0x1857ACFB0")]
	public void IOHBDOEAPGK(bool[] AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x57AD520", Offset = "0x57ABF20", VA = "0x1857AD520")]
	public void IOHBDOEAPGK(string[] AEJBOLFACJC, int KGIGDLGJDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x57AD9B0", Offset = "0x57AC3B0", VA = "0x1857AD9B0")]
	public void JAMMFKMMAML(IPEndPoint BDGAKFBHHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x57ADA80", Offset = "0x57AC480", VA = "0x1857ADA80")]
	public void JAMMFKMMAML(string AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x57AD6B0", Offset = "0x57AC0B0", VA = "0x1857AD6B0")]
	public void JAMMFKMMAML(string AEJBOLFACJC, int AFOAGHLPAEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class BMCJCKEPFGO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class BKCPPKKLFJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong PHMNCFOHEJL;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4955570", Offset = "0x4953F70", VA = "0x184955570")]
		static BKCPPKKLFJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void AAOCKLNMFOC(DLMCPNMPKIP INBDAJDBDHK, object GEGMONMODME);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JLLGGNOEEHE<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BMCJCKEPFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public JLLGGNOEEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C82530", Offset = "0x3C80F30", VA = "0x183C82530")]
		internal void OBOOGFNJIHL(DLMCPNMPKIP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PPBNGKHDHPK<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public BMCJCKEPFGO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public PPBNGKHDHPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4320D50", Offset = "0x431F750", VA = "0x184320D50")]
		internal void OBOOGFNJIHL(DLMCPNMPKIP reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly MIJGMCNAJKE LKGEDEBIIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, AAOCKLNMFOC> JCBDNAHICJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly KOMLPBDJGLD FKMAFMACGKF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x579ABE0", Offset = "0x57995E0", VA = "0x18579ABE0")]
	public BMCJCKEPFGO(int JEJEKPODNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x271B670", Offset = "0x271A070", VA = "0x18271B670", Slot = "4")]
	protected virtual ulong HOBFKBEHAIF<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x579AAB0", Offset = "0x57994B0", VA = "0x18579AAB0", Slot = "5")]
	protected virtual AAOCKLNMFOC ONOOACOCMPD(DLMCPNMPKIP INBDAJDBDHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x271E510", Offset = "0x271CF10", VA = "0x18271E510", Slot = "6")]
	protected virtual void KIBIAKABNPI<T>(KOMLPBDJGLD KLKMGHMAEIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x579A9E0", Offset = "0x57993E0", VA = "0x18579A9E0")]
	public void ELALEGBPNIA(DLMCPNMPKIP INBDAJDBDHK, object GEGMONMODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x271E480", Offset = "0x271CE80", VA = "0x18271E480")]
	public void DOCDFFDNEMK<T>(KOMLPBDJGLD KLKMGHMAEIH, T DHBMHKNGPCJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x579AA60", Offset = "0x5799460", VA = "0x18579AA60")]
	public void FBCCCCEIFPO(DLMCPNMPKIP INBDAJDBDHK, object GEGMONMODME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x271E700", Offset = "0x271D100", VA = "0x18271E700")]
	public void PDMBFLOKPND<T>(Action<T> NGEFOONDFJP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x271E580", Offset = "0x271CF80", VA = "0x18271E580")]
	public void PDMBFLOKPND<T, TUserData>(Action<T, TUserData> NGEFOONDFJP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KMBKKPNIJKI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x579E540", Offset = "0x579CF40", VA = "0x18579E540")]
	public KMBKKPNIJKI(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class KGCJPCPKHND : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x57ACE50", Offset = "0x57AB850", VA = "0x1857ACE50")]
	public KGCJPCPKHND(string CPPFNMDMGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MIJGMCNAJKE
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum JJOODHADBPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class JKLPAMMGFHB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public JJOODHADBPE OHELAGOCJFN;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C81210", Offset = "0x3C7FC10", VA = "0x183C81210", Slot = "4")]
		public virtual void BMGPKAMLICG(MethodInfo LDKCNJBGCKI, MethodInfo OGIKFDKCJFF, JJOODHADBPE CGEOAHHPHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JMJGPGMGCHB(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GMHIIEDLAHM(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		protected JKLPAMMGFHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CAHMNIACPKK<TClass, TProperty> : JKLPAMMGFHB<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> BKBHGECBFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> OJGJHMNNJCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> OHGMMMBMFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> BGOAGDCPMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> LNEDPOKGJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> BMDAKBBEFHL;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x49D3C80", Offset = "0x49D2680", VA = "0x1849D3C80", Slot = "7")]
		public override void DCBGGCMFONI(TClass KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x49D2850", Offset = "0x49D1250", VA = "0x1849D2850", Slot = "8")]
		public override void ADKKJKBJDFH(TClass KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x49D4310", Offset = "0x49D2D10", VA = "0x1849D4310", Slot = "9")]
		public override void JMJGPGMGCHB(TClass KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x49D4000", Offset = "0x49D2A00", VA = "0x1849D4000", Slot = "10")]
		public override void GMHIIEDLAHM(TClass KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x49D43F0", Offset = "0x49D2DF0", VA = "0x1849D43F0")]
		protected TProperty[] JOOFFDOFKBD(TClass KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x49D40E0", Offset = "0x49D2AE0", VA = "0x1849D40E0")]
		protected TProperty[] GPCCFGGIBPE(TClass KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x49D2AF0", Offset = "0x49D14F0", VA = "0x1849D2AF0", Slot = "4")]
		public override void BMGPKAMLICG(MethodInfo LDKCNJBGCKI, MethodInfo OGIKFDKCJFF, JJOODHADBPE CGEOAHHPHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8000", Offset = "0x3FF6A00", VA = "0x183FF8000")]
		protected CAHMNIACPKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class CGDKKICCPNP<TClass, TProperty> : CAHMNIACPKK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CKLMMNOFPEC(DLMCPNMPKIP IBKPCEPDIIC, [Out] TProperty KPKDJDCDPJA);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void AIMPPDPLNJH(KOMLPBDJGLD PAMCHPJPPPN, TProperty KPKDJDCDPJA);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4AB31E0", Offset = "0x4AB1BE0", VA = "0x184AB31E0", Slot = "5")]
		public override void CJAINMNDGDP(TClass KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3410", Offset = "0x4AB1E10", VA = "0x184AB3410", Slot = "6")]
		public override void DOCDFFDNEMK(TClass KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3260", Offset = "0x4AB1C60", VA = "0x184AB3260", Slot = "7")]
		public override void DCBGGCMFONI(TClass KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4AB3020", Offset = "0x4AB1A20", VA = "0x184AB3020", Slot = "8")]
		public override void ADKKJKBJDFH(TClass KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3AE6770", Offset = "0x3AE5170", VA = "0x183AE6770")]
		protected CGDKKICCPNP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class PDKGKBEINMP<T> : CAHMNIACPKK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x42E6700", Offset = "0x42E5100", VA = "0x1842E6700", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x42E67C0", Offset = "0x42E51C0", VA = "0x1842E67C0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x42E6760", Offset = "0x42E5160", VA = "0x1842E6760", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E4D0", Offset = "0x3C6CED0", VA = "0x183C6E4D0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public PDKGKBEINMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BFIFKNPDIDL<T> : CAHMNIACPKK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x49438A0", Offset = "0x49422A0", VA = "0x1849438A0", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x42E67C0", Offset = "0x42E51C0", VA = "0x1842E67C0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4943900", Offset = "0x4942300", VA = "0x184943900", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E4D0", Offset = "0x3C6CED0", VA = "0x183C6E4D0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public BFIFKNPDIDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class AGHIHIBHIJD<T> : CAHMNIACPKK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3973120", Offset = "0x3971B20", VA = "0x183973120", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39731E0", Offset = "0x3971BE0", VA = "0x1839731E0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3973180", Offset = "0x3971B80", VA = "0x183973180", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x39730D0", Offset = "0x3971AD0", VA = "0x1839730D0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public AGHIHIBHIJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MJICEFAJDCJ<T> : CAHMNIACPKK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4044540", Offset = "0x4042F40", VA = "0x184044540", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x39731E0", Offset = "0x3971BE0", VA = "0x1839731E0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x40445A0", Offset = "0x4042FA0", VA = "0x1840445A0", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x39730D0", Offset = "0x3971AD0", VA = "0x1839730D0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public MJICEFAJDCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NNDBDCBLJBK<T> : CAHMNIACPKK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x40E64F0", Offset = "0x40E4EF0", VA = "0x1840E64F0", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAA50", Offset = "0x3AA9450", VA = "0x183AAAA50", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x40E6550", Offset = "0x40E4F50", VA = "0x1840E6550", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA940", Offset = "0x3AA9340", VA = "0x183AAA940", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public NNDBDCBLJBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class IEIBIINFJHP<T> : CAHMNIACPKK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA990", Offset = "0x3AA9390", VA = "0x183AAA990", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3AAAA50", Offset = "0x3AA9450", VA = "0x183AAAA50", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA9F0", Offset = "0x3AA93F0", VA = "0x183AAA9F0", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA940", Offset = "0x3AA9340", VA = "0x183AAA940", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public IEIBIINFJHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PGJFGMGPKPF<T> : CAHMNIACPKK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x34D7330", Offset = "0x34D5D30", VA = "0x1834D7330", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x34D73F0", Offset = "0x34D5DF0", VA = "0x1834D73F0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x42FA390", Offset = "0x42F8D90", VA = "0x1842FA390", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x34D72E0", Offset = "0x34D5CE0", VA = "0x1834D72E0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public PGJFGMGPKPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EEDKFELMKBL<T> : CAHMNIACPKK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x34D7330", Offset = "0x34D5D30", VA = "0x1834D7330", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x34D73F0", Offset = "0x34D5DF0", VA = "0x1834D73F0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x34D7390", Offset = "0x34D5D90", VA = "0x1834D7390", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x34D72E0", Offset = "0x34D5CE0", VA = "0x1834D72E0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public EEDKFELMKBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JDIADPIGGKD<T> : CAHMNIACPKK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E520", Offset = "0x3C6CF20", VA = "0x183C6E520", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E5E0", Offset = "0x3C6CFE0", VA = "0x183C6E5E0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E580", Offset = "0x3C6CF80", VA = "0x183C6E580", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E4D0", Offset = "0x3C6CED0", VA = "0x183C6E4D0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public JDIADPIGGKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LBAFAOFBCNF<T> : CAHMNIACPKK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EE90", Offset = "0x3E1D890", VA = "0x183E1EE90", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EF50", Offset = "0x3E1D950", VA = "0x183E1EF50", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EEF0", Offset = "0x3E1D8F0", VA = "0x183E1EEF0", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3AAA940", Offset = "0x3AA9340", VA = "0x183AAA940", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public LBAFAOFBCNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class LNEFDCGKAFO<T> : CAHMNIACPKK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E54600", Offset = "0x3E53000", VA = "0x183E54600", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3E546C0", Offset = "0x3E530C0", VA = "0x183E546C0", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E54660", Offset = "0x3E53060", VA = "0x183E54660", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x34D72E0", Offset = "0x34D5CE0", VA = "0x1834D72E0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x34D7440", Offset = "0x34D5E40", VA = "0x1834D7440")]
		public LNEFDCGKAFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FDJJGBBJGKO<T> : CGDKKICCPNP<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x387A8C0", Offset = "0x38792C0", VA = "0x18387A8C0", Slot = "12")]
		protected override void AIMPPDPLNJH(KOMLPBDJGLD PAMCHPJPPPN, char KPKDJDCDPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x387A8F0", Offset = "0x38792F0", VA = "0x18387A8F0", Slot = "11")]
		protected override void CKLMMNOFPEC(DLMCPNMPKIP IBKPCEPDIIC, [Out] char KPKDJDCDPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x34D22A0", Offset = "0x34D0CA0", VA = "0x1834D22A0")]
		public FDJJGBBJGKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class MHFKCAEPLBO<T> : CGDKKICCPNP<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x403B560", Offset = "0x4039F60", VA = "0x18403B560", Slot = "12")]
		protected override void AIMPPDPLNJH(KOMLPBDJGLD PAMCHPJPPPN, IPEndPoint KPKDJDCDPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x403B590", Offset = "0x4039F90", VA = "0x18403B590", Slot = "11")]
		protected override void CKLMMNOFPEC(DLMCPNMPKIP IBKPCEPDIIC, [Out] IPEndPoint KPKDJDCDPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x34D22A0", Offset = "0x34D0CA0", VA = "0x1834D22A0")]
		public MHFKCAEPLBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NPJCNCAJDCF<T> : CAHMNIACPKK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int NLIKDFOEKON;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x40EC080", Offset = "0x40EAA80", VA = "0x1840EC080")]
		public NPJCNCAJDCF(int AFOAGHLPAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40EBF40", Offset = "0x40EA940", VA = "0x1840EBF40", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x40EC020", Offset = "0x40EAA20", VA = "0x1840EC020", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x40EBFB0", Offset = "0x40EA9B0", VA = "0x1840EBFB0", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x40EBEE0", Offset = "0x40EA8E0", VA = "0x1840EBEE0", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class ILHMJAKJIPH<T> : JKLPAMMGFHB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo MIIKBAKIKGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type BELGNFKODBG;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD900", Offset = "0x3ACC300", VA = "0x183ACD900")]
		public ILHMJAKJIPH(PropertyInfo DMJMLGBLOFK, Type BPIMOPDMMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD670", Offset = "0x3ACC070", VA = "0x183ACD670", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD790", Offset = "0x3ACC190", VA = "0x183ACD790", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD730", Offset = "0x3ACC130", VA = "0x183ACD730", Slot = "7")]
		public override void DCBGGCMFONI(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD610", Offset = "0x3ACC010", VA = "0x183ACD610", Slot = "8")]
		public override void ADKKJKBJDFH(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD8A0", Offset = "0x3ACC2A0", VA = "0x183ACD8A0", Slot = "9")]
		public override void JMJGPGMGCHB(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD840", Offset = "0x3ACC240", VA = "0x183ACD840", Slot = "10")]
		public override void GMHIIEDLAHM(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class OIIHLKLJPCP<T> : ILHMJAKJIPH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x34FB590", Offset = "0x34F9F90", VA = "0x1834FB590")]
		public OIIHLKLJPCP(PropertyInfo DMJMLGBLOFK, Type BPIMOPDMMDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x42188A0", Offset = "0x42172A0", VA = "0x1842188A0", Slot = "5")]
		public override void CJAINMNDGDP(T KDEICIBNIBH, DLMCPNMPKIP IBKPCEPDIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4218960", Offset = "0x4217360", VA = "0x184218960", Slot = "6")]
		public override void DOCDFFDNEMK(T KDEICIBNIBH, KOMLPBDJGLD PAMCHPJPPPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class GGCCOMLPJOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static GGCCOMLPJOH<T> AINFBDJPIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly JKLPAMMGFHB<T>[] HHGOOBMBLKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int PEDMMIDPBMA;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3981180", Offset = "0x397FB80", VA = "0x183981180")]
		public GGCCOMLPJOH(List<JKLPAMMGFHB<T>> JDBBKNIHBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39810D0", Offset = "0x397FAD0", VA = "0x1839810D0")]
		public void DOCDFFDNEMK(T COMOOAEHALC, KOMLPBDJGLD KLKMGHMAEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3981020", Offset = "0x397FA20", VA = "0x183981020")]
		public void CJAINMNDGDP(T COMOOAEHALC, DLMCPNMPKIP INBDAJDBDHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class BBLIPJMMIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract JKLPAMMGFHB<T> OIFPBAJNOAG<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private KOMLPBDJGLD FEBHEKMAIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int IJEBGLOMBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, BBLIPJMMIMA> PMFMBCGLBEH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x57AFF10", Offset = "0x57AE910", VA = "0x1857AFF10")]
	public MIJGMCNAJKE(int JEJEKPODNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2A24130", Offset = "0x2A22B30", VA = "0x182A24130")]
	private GGCCOMLPJOH<T> HHHJPHLMAEP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2802C90", Offset = "0x2801690", VA = "0x182802C90")]
	public void JIGIEBIDGIG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2A25020", Offset = "0x2A23A20", VA = "0x182A25020")]
	public bool HIBHLHEFCGJ<T>(DLMCPNMPKIP INBDAJDBDHK, T PJDANIPAHEH) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2A240D0", Offset = "0x2A22AD0", VA = "0x182A240D0")]
	public void BOALAEMEPIG<T>(KOMLPBDJGLD KLKMGHMAEIH, T COMOOAEHALC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EDEGDOKKKNC
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime OAGHIPLDFML;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] OCOFDFLIDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HIAABHEEKGN EPFLNFINCHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x579C830", Offset = "0x579B230", VA = "0x18579C830")]
		get
		{
			return default(HIAABHEEKGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int ADBOONFFHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x579C860", Offset = "0x579B260", VA = "0x18579C860")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x579CC90", Offset = "0x579B690", VA = "0x18579CC90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public PEKMLBMKDFA HNPAGELODMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x579CCD0", Offset = "0x579B6D0", VA = "0x18579CCD0")]
		get
		{
			return default(PEKMLBMKDFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x579CDC0", Offset = "0x579B7C0", VA = "0x18579CDC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FKKMFNANCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x579D3B0", Offset = "0x579BDB0", VA = "0x18579D3B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint DBKFHLKNKLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x579D230", Offset = "0x579BC30", VA = "0x18579D230")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? BPHOAHECHHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x579D2B0", Offset = "0x579BCB0", VA = "0x18579D2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? LNPHJENMEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x579D760", Offset = "0x579C160", VA = "0x18579D760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? FONCOGIOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x579D3E0", Offset = "0x579BDE0", VA = "0x18579D3E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x579CFD0", Offset = "0x579B9D0", VA = "0x18579CFD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? LLCDJHFNPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xB019B0", Offset = "0xB003B0", VA = "0x180B019B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x92CAC0", Offset = "0x92B4C0", VA = "0x18092CAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x579D8A0", Offset = "0x579C2A0", VA = "0x18579D8A0")]
	public EDEGDOKKKNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x579D7F0", Offset = "0x579C1F0", VA = "0x18579D7F0")]
	internal EDEGDOKKKNC(byte[] OIKPPLLAJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x579D470", Offset = "0x579BE70", VA = "0x18579D470")]
	public static EDEGDOKKKNC MFOODJJAKIG(byte[] OIKPPLLAJOB, DateTime PNHIKIFMJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x579CA90", Offset = "0x579B490", VA = "0x18579CA90")]
	internal void BPDBDNKEGGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x579D590", Offset = "0x579BF90", VA = "0x18579D590")]
	private void PGDOHMKMKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x579C890", Offset = "0x579B290", VA = "0x18579C890")]
	private DateTime? BMNGAGGMHJM(int KNFIDNLGJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x579CE00", Offset = "0x579B800", VA = "0x18579CE00")]
	private void EDGEKKJKHEA(int KNFIDNLGJFO, DateTime? AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x579D2E0", Offset = "0x579BCE0", VA = "0x18579D2E0")]
	private ulong HLIJOAPKNEG(int KNFIDNLGJFO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x579CD00", Offset = "0x579B700", VA = "0x18579CD00")]
	private void DLIIPPLGPND(int KNFIDNLGJFO, ulong AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x579D1A0", Offset = "0x579BBA0", VA = "0x18579D1A0")]
	private uint GFBKCOIGDAE(int KNFIDNLGJFO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x566D170", Offset = "0x566BB70", VA = "0x18566D170")]
	private static uint KHBHEPEGEPA(uint HMCMBMJNNLE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x579D410", Offset = "0x579BE10", VA = "0x18579D410")]
	private static ulong KHBHEPEGEPA(ulong HMCMBMJNNLE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HIAABHEEKGN
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
public enum PEKMLBMKDFA
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class KOIAONMGJOF
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int BJEMKAFGGJG = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int MBNDNCEBFON = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int IGNACEPAMEE = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint FLKHJAIEAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int OECBAOBJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int HOHJJOKKOFD;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool FLBEDBACJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x57ACEB0", Offset = "0x57AB8B0", VA = "0x1857ACEB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x57ACEC0", Offset = "0x57AB8C0", VA = "0x1857ACEC0")]
	public bool NJJKMAMJCGK(ALBABINKFBF BOANGPNPCHH, int PAJOJJHFNPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EPFBFLMEEGJ : ALBABINKFBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket BOANGPNPCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly IEOIDIADAGK GNBCOOHLAAP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short AMKOGBELCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x579E430", Offset = "0x579CE30", VA = "0x18579E430", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GAPGPFFALDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x579E470", Offset = "0x579CE70", VA = "0x18579E470", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint DGPPDDBOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x579E450", Offset = "0x579CE50", VA = "0x18579E450", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily DAMAPOFBAND
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DF9220", Offset = "0x3DF7C20", VA = "0x183DF9220", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x579E490", Offset = "0x579CE90", VA = "0x18579E490")]
	public EPFBFLMEEGJ(AddressFamily MBKPMFJOPFJ, IEOIDIADAGK GNBCOOHLAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x579DE70", Offset = "0x579C870", VA = "0x18579DE70", Slot = "8")]
	public bool IBMBEMPAFHN(IPEndPoint BDGAKFBHHMD, KIOCBNLPOED JNBLCPIDMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x579DD40", Offset = "0x579C740", VA = "0x18579DD40", Slot = "9")]
	public int DFLPLPECPAA(byte[] PJIBFCJPNLC, int KNFIDNLGJFO, int CBAOPDHODHO, IPEndPoint MBNHLDIFNDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x579DD80", Offset = "0x579C780", VA = "0x18579DD80", Slot = "10")]
	public int DGHMJCBAOMN(byte[] PJIBFCJPNLC, EndPoint KHGCGACPGFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x579DD20", Offset = "0x579C720", VA = "0x18579DD20", Slot = "11")]
	public void CDCLCDKFKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface ALBABINKFBF
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short AMKOGBELCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int GAPGPFFALDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint DGPPDDBOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily DAMAPOFBAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IBMBEMPAFHN(IPEndPoint BDGAKFBHHMD, KIOCBNLPOED JNBLCPIDMJN);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DFLPLPECPAA(byte[] PJIBFCJPNLC, int KNFIDNLGJFO, int CBAOPDHODHO, IPEndPoint MBNHLDIFNDP);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DGHMJCBAOMN(byte[] PJIBFCJPNLC, EndPoint MBNHLDIFNDP);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDCLCDKFKFP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NLPNFAIKKMA : IEquatable<NLPNFAIKKMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long FDELPEBCPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long CJDMFKDICHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long BCLCAHMHFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int OIMHHJHOAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int DCIPDJNEOLM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x57B02B0", Offset = "0x57AECB0", VA = "0x1857B02B0")]
	public NLPNFAIKKMA(byte[] ACDAPODGMCA, int PPHLILHGBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7EAB70", Offset = "0x7E9570", VA = "0x1807EAB70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x57B0270", Offset = "0x57AEC70", VA = "0x1857B0270", Slot = "4")]
	public bool Equals(NLPNFAIKKMA HKMMPHJFKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x57B01C0", Offset = "0x57AEBC0", VA = "0x1857B01C0", Slot = "0")]
	public override bool Equals(object COMOOAEHALC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class NJMAMADHNEL : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] DJPNPKNMOOD;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HFPIFPGIKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int EIIKAGGMGBN;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2410", Offset = "0x7C0E10", VA = "0x1807C2410")]
	protected HFPIFPGIKDB(int ODAMGBICIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ADPOHEILIOL(IPEndPoint BDGAKFBHHMD, byte[] ABDLEBPKDKC, int KNFIDNLGJFO, int JEKCEPEEELJ);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GLPOMBDIKGP(IPEndPoint BDGAKFBHHMD, byte[] ABDLEBPKDKC, int KNFIDNLGJFO, int JEKCEPEEELJ);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HOCDGOCAECI : HFPIFPGIKDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider DEBAOPJAPDJ;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator BAGMOCHMHCM;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x57A45E0", Offset = "0x57A2FE0", VA = "0x1857A45E0")]
	public HOCDGOCAECI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x57A3F10", Offset = "0x57A2910", VA = "0x1857A3F10")]
	public void EOPALNLMPOI(IPEndPoint BDGAKFBHHMD, byte[] KLDFLAABJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x57A3E30", Offset = "0x57A2830", VA = "0x1857A3E30")]
	public void CGNLDAAPCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x57A44F0", Offset = "0x57A2EF0", VA = "0x1857A44F0")]
	private byte[] MNKBILEIDOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x57A39A0", Offset = "0x57A23A0", VA = "0x1857A39A0", Slot = "4")]
	public override void ADPOHEILIOL(IPEndPoint BDGAKFBHHMD, byte[] ABDLEBPKDKC, int KNFIDNLGJFO, int JEKCEPEEELJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x57A4150", Offset = "0x57A2B50", VA = "0x1857A4150", Slot = "5")]
	public override void GLPOMBDIKGP(IPEndPoint BDGAKFBHHMD, byte[] ABDLEBPKDKC, int KNFIDNLGJFO, int JEKCEPEEELJ)
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
