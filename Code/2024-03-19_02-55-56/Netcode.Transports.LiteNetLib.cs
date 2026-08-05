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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CEDFANBHBAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum BGHNHCBNMLP
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
		private NetworkManager KIOEELMCJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, NHPCBOGEGDC> LMHBDLCDHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DHAPFCCGMJE OJFOHNPDOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] ILALDBKNPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BGHNHCBNMLP OPJLOJKADIJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong LPDEGBMPGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OOLCLHFGNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5622EA0", Offset = "0x5621EA0", VA = "0x185622EA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x56223A0", Offset = "0x56213A0", VA = "0x1856223A0")]
		public void RecRoom_SetEncryptionInfo(ulong CLIJFCBDHAB, byte[] IPAJBJLLPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5622380", Offset = "0x5621380", VA = "0x185622380")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5622230", Offset = "0x5621230", VA = "0x185622230")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5622DA0", Offset = "0x5621DA0", VA = "0x185622DA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x56225A0", Offset = "0x56215A0", VA = "0x1856225A0", Slot = "6")]
		public override void Send(ulong DMJDFONKKBE, ArraySegment<byte> ELANMAGHLLI, NetworkDelivery MBAHAPDKJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5622340", Offset = "0x5621340", VA = "0x185622340", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DMJDFONKKBE, [Out] ArraySegment<byte> CEFJMHIOKFM, [Out] float INMGAGKHCLD)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5622890", Offset = "0x5621890", VA = "0x185622890", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5622CC0", Offset = "0x5621CC0", VA = "0x185622CC0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5621E60", Offset = "0x5620E60", VA = "0x185621E60", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DMJDFONKKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5621D10", Offset = "0x5620D10", VA = "0x185621D10", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5621FD0", Offset = "0x5620FD0", VA = "0x185621FD0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DMJDFONKKBE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5622820", Offset = "0x5621820", VA = "0x185622820", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5622070", Offset = "0x5621070", VA = "0x185622070", Slot = "14")]
		public override void Initialize([Optional] NetworkManager KIOEELMCJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5621AA0", Offset = "0x5620AA0", VA = "0x185621AA0")]
		private IEOGIHIIJKI CAHPBJAIAIC(NetworkDelivery IKHOLAJCJOG)
		{
			return default(IEOGIHIIJKI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x56216C0", Offset = "0x56206C0", VA = "0x1856216C0", Slot = "15")]
		private void AMJKOEIOJOF(NHPCBOGEGDC KEBCDACPHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5621BD0", Offset = "0x5620BD0", VA = "0x185621BD0", Slot = "16")]
		private void CEGJBIEPJLC(NHPCBOGEGDC KEBCDACPHMA, NABMLFKOEKA DOPEIANNMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "17")]
		private void AEJMMIGCDEC(IPEndPoint IOLKKJCLFNN, SocketError IKMJEHPNNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5621890", Offset = "0x5620890", VA = "0x185621890", Slot = "18")]
		private void BNPBLOMHFFI(NHPCBOGEGDC KEBCDACPHMA, HBAHCBFKKPI PCOFGFPALLL, byte JIDIOOGBAOE, IEOGIHIIJKI CPIJFJHHEAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56217B0", Offset = "0x56207B0", VA = "0x1856217B0")]
		private void BNKKDBKMJII(int BEELDCKKFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "19")]
		private void CJOCCIANKAO(IPEndPoint ENEEIADMAHO, HBAHCBFKKPI PCOFGFPALLL, LOFIGOAELGG CBEFJOJPNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "20")]
		private void GNMGBNGLMFK(NHPCBOGEGDC KEBCDACPHMA, int ANDPIFIIOAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5621B70", Offset = "0x5620B70", VA = "0x185621B70", Slot = "21")]
		private void CEBAOAHOPPE(JADHCKDMJGO LFFEKPPMJHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5621780", Offset = "0x5620780", VA = "0x185621780")]
		private ulong APFHEMPMDDO(NHPCBOGEGDC KEBCDACPHMA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5622320", Offset = "0x5621320", VA = "0x185622320")]
		private static int PFMJCOFLBID(float KMADAIPOJJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5622DC0", Offset = "0x5621DC0", VA = "0x185622DC0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class EFFNOFKLPJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NHPCBOGEGDC LOJOPFCHKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<DLBOMPEFPEF> HAGHBBEMDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int MNAJPOAKFAN;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x561E550", Offset = "0x561D550", VA = "0x18561E550")]
	protected EFFNOFKLPJI(NHPCBOGEGDC KEBCDACPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x561E430", Offset = "0x561D430", VA = "0x18561E430")]
	public void CJCBKKKIDAP(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x561E490", Offset = "0x561D490", VA = "0x18561E490")]
	protected void CMLMHIHNEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x561E510", Offset = "0x561D510", VA = "0x18561E510")]
	public bool DIHHICFMNDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool DPBFECDHLML();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool BPDBBDAGMMK(DLBOMPEFPEF LCLIEHKHJLN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BODELHAOFBD
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
public class JADHCKDMJGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DHAPFCCGMJE CKAKOIDAEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int GDECBCFJECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal BEDNAMELPBP DKODMDOHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint GPJPNFINNLI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BODELHAOFBD LJNEPGKFNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E3870", Offset = "0x7E2870", VA = "0x1807E3870")]
		[CompilerGenerated]
		get
		{
			return default(BODELHAOFBD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x967460", Offset = "0x966460", VA = "0x180967460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5620720", Offset = "0x561F720", VA = "0x185620720")]
	internal void BPCPNGHPBLK(BEDNAMELPBP HGMNMFDOEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56207E0", Offset = "0x561F7E0", VA = "0x1856207E0")]
	private bool DEEINANLIIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5620810", Offset = "0x561F810", VA = "0x185620810")]
	internal JADHCKDMJGO(IPEndPoint ENEEIADMAHO, BEDNAMELPBP PCGMLCAKJGM, DHAPFCCGMJE DCKPMIGBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5620780", Offset = "0x561F780", VA = "0x185620780")]
	public NHPCBOGEGDC BPIBEJKGNGM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LOFIGOAELGG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DDDJKOOHGNO
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
public struct NABMLFKOEKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DDDJKOOHGNO AHHLLNDGNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError KPOCDNLKGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HBAHCBFKKPI KJAKOKLHHDB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEDFANBHBAC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGCHJOONBJN(NHPCBOGEGDC KEBCDACPHMA);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCDDOJDEKCF(NHPCBOGEGDC KEBCDACPHMA, NABMLFKOEKA DOPEIANNMHG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICBIMCKIJCP(IPEndPoint IOLKKJCLFNN, SocketError IKMJEHPNNLP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GAHGACALICA(NHPCBOGEGDC KEBCDACPHMA, HBAHCBFKKPI PCOFGFPALLL, byte JIDIOOGBAOE, IEOGIHIIJKI CPIJFJHHEAC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNIHDKELKLA(IPEndPoint ENEEIADMAHO, HBAHCBFKKPI PCOFGFPALLL, LOFIGOAELGG CBEFJOJPNMI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGNCBIPEGBD(NHPCBOGEGDC KEBCDACPHMA, int ANDPIFIIOAP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMMPLJCEOKL(JADHCKDMJGO LFFEKPPMJHN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KDPCICKAHLG
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHFPOEJPDPM(NHPCBOGEGDC KEBCDACPHMA, object LKMCHFFGKFP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GLOMPPIANDF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKBBNAABMEN(MOMCICNDMMO LCLIEHKHJLN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AFCFAEDGLHD
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBKHNLDJOEK(NHPCBOGEGDC KEBCDACPHMA, IPEndPoint LMHPMDKEBDL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class BEDNAMELPBP
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int AIECDBNPODH = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long MNGCBJILDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte ENPOBIEBCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] AICHHBBGJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IPAPMJFPALB GCOMEMFCJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int GBFPKNFBLOF;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5615A70", Offset = "0x5614A70", VA = "0x185615A70")]
	private BEDNAMELPBP(long ADDBEMNNBLA, byte CMGEFDJMAMJ, int JHPDAOFKDGB, byte[] NNNBPEOAONN, IPAPMJFPALB ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x56157F0", Offset = "0x56147F0", VA = "0x1856157F0")]
	public static int DGOILIDONHG(DLBOMPEFPEF LCLIEHKHJLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5615850", Offset = "0x5614850", VA = "0x185615850")]
	public static BEDNAMELPBP NFGIKFMJNGD(DLBOMPEFPEF LCLIEHKHJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5615610", Offset = "0x5614610", VA = "0x185615610")]
	public static DLBOMPEFPEF CNDHFNBCBOE(CHGEFENFMJB OCJKIGHNPDL, SocketAddress AHGCPKDGPDD, long IMONHAIHFCL, int JHPDAOFKDGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LEIMKKNEFAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long MNGCBJILDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte ENPOBIEBCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int GBFPKNFBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool NMIOCACLGLB;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5621670", Offset = "0x5620670", VA = "0x185621670")]
	private LEIMKKNEFAE(long ADDBEMNNBLA, byte CMGEFDJMAMJ, int BGNPPLDOOBN, bool PMAHDNEDNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5621520", Offset = "0x5620520", VA = "0x185621520")]
	public static LEIMKKNEFAE NFGIKFMJNGD(DLBOMPEFPEF LCLIEHKHJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5621330", Offset = "0x5620330", VA = "0x185621330")]
	public static DLBOMPEFPEF CNDHFNBCBOE(long IMONHAIHFCL, byte DAFLPPNOAMJ, int ECBDMKKACEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5621420", Offset = "0x5620420", VA = "0x185621420")]
	public static DLBOMPEFPEF EICAMEIKMKE(NHPCBOGEGDC KEBCDACPHMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum KMLNOIOBNCH
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ODEEOFGBKPN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANCBEMAEONN(IPEndPoint BGJJCMHPAJE, IPEndPoint ENEEIADMAHO, string OGACLNNOKDA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBANEGBHIOL(IPEndPoint LPFLDNCGCDH, KMLNOIOBNCH IKHOLAJCJOG, string OGACLNNOKDA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HMPIFDFMIBA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OJDBHJIKLOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint BIPHKODLPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint GPJPNFINNLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string NGDGLKKPIHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct IHEHMBLKKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint HEBMMGMLIPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public KMLNOIOBNCH MJIJAFEKHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string NGDGLKKPIHE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class CLKIPLJLBOL
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint FGNBDKFEPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string NGDGLKKPIHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CLKIPLJLBOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class IEAGKHEHONG
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint FGNBDKFEPBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint IKPPHLAHHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string NGDGLKKPIHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public IEAGKHEHONG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class OGNBFOFNEIC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NGDGLKKPIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DFDNFJNLODN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BFAC0", Offset = "0x7BEAC0", VA = "0x1807BFAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public OGNBFOFNEIC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DHAPFCCGMJE AFAPIGHPPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OJDBHJIKLOH> JGHOPDLIEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<IHEHMBLKKLF> PEDPOOJMPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly IPAPMJFPALB PMNOHKFKOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CHGEFENFMJB AINJGKAKNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NFBDJOFFNKN IPCFNOGLIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ODEEOFGBKPN ABKDMPAHIED;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int HGCLEPHHKHJ = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KHOCKBFIFLL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x561F680", Offset = "0x561E680", VA = "0x18561F680")]
	internal HMPIFDFMIBA(DHAPFCCGMJE IDIGAOLCKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x561F220", Offset = "0x561E220", VA = "0x18561F220")]
	internal void CDAGPMFDNMN(IPEndPoint FJHKAKLGIHG, DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27CEE90", Offset = "0x27CDE90", VA = "0x1827CEE90")]
	private void EGPAKDDIGDD<T>(T LCLIEHKHJLN, IPEndPoint PGJBCOPPFBK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x561F090", Offset = "0x561E090", VA = "0x18561F090")]
	private void ANCBEMAEONN(CLKIPLJLBOL BIBCHDNIFEM, IPEndPoint FJHKAKLGIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x561F380", Offset = "0x561E380", VA = "0x18561F380")]
	private void EBKBLCIBDNG(IEAGKHEHONG BIBCHDNIFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x561F4E0", Offset = "0x561E4E0", VA = "0x18561F4E0")]
	private void LFMFFPELJAB(OGNBFOFNEIC BIBCHDNIFEM, IPEndPoint FJHKAKLGIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum IEOGIHIIJKI : byte
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
public enum ONKBEIKCMDL : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KLPMLGLKKDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] CPMEFHGHKMC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int KMBBHPKLKBK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int MKDGHIMCDDO;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FDHEBKGEENM : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5615AE0", Offset = "0x5614AE0", VA = "0x185615AE0")]
	public FDHEBKGEENM(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GCOMPBHOHDF : FDHEBKGEENM
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5615AE0", Offset = "0x5614AE0", VA = "0x185615AE0")]
	public GCOMPBHOHDF(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MGPPMFJOJNN
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
public interface LGOEPKFPIPI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJKECNJALBB(MGPPMFJOJNN JCACFEGOIDE, string BBECBJENJIE, params object[] AFBHAGBGAAM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class JFGAGIGPHDN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static LGOEPKFPIPI JHEHLABKPEI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object ABFMALPFLLK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x56208E0", Offset = "0x561F8E0", VA = "0x1856208E0")]
	private static void DOHJLHKGKLJ(MGPPMFJOJNN NPAHFHOIJCN, string BBECBJENJIE, params object[] AFBHAGBGAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5620880", Offset = "0x561F880", VA = "0x185620880")]
	internal static void AMNOMDACIOC(string BBECBJENJIE, params object[] AFBHAGBGAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5620B70", Offset = "0x561FB70", VA = "0x185620B70")]
	internal static void NBMPELGGCIK(string BBECBJENJIE, params object[] AFBHAGBGAAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5620B10", Offset = "0x561FB10", VA = "0x185620B10")]
	internal static void GNOFEHLMAJJ(string BBECBJENJIE, params object[] AFBHAGBGAAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum PCPKCGKODCG
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HBAHCBFKKPI : IPAPMJFPALB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DLBOMPEFPEF PKPBEKJOHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly DHAPFCCGMJE AHKFPKPFJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CPJKHPBAOOK DLFMNOECAJN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x561F040", Offset = "0x561E040", VA = "0x18561F040")]
	internal HBAHCBFKKPI(DHAPFCCGMJE JDIOCIOLNIG, CPJKHPBAOOK HGJIEONDGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x561EFA0", Offset = "0x561DFA0", VA = "0x18561EFA0")]
	internal void CFENEJCNLDB(DLBOMPEFPEF LCLIEHKHJLN, int CFGGCLOGMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x561EF20", Offset = "0x561DF20", VA = "0x18561EF20")]
	internal void ANIILFOFAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x561F010", Offset = "0x561E010", VA = "0x18561F010")]
	public void EEJMMCDNCEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class CPJKHPBAOOK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum NBGPEEDACFF
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
	public CPJKHPBAOOK GMLEKMDNCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NBGPEEDACFF MJIJAFEKHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NHPCBOGEGDC LOJOPFCHKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint GPJPNFINNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object HPBDBIALIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int LFDMLBKAADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError CLBMKKEFOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public DDDJKOOHGNO NHDHOEFOMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public JADHCKDMJGO KGBCFKFONPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public IEOGIHIIJKI MFAGMBKKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte LLFDPMDPIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HBAHCBFKKPI CEMGEKCOFKN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5616940", Offset = "0x5615940", VA = "0x185616940")]
	public CPJKHPBAOOK(DHAPFCCGMJE JDIOCIOLNIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class DHAPFCCGMJE : IEnumerable<NHPCBOGEGDC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class FMJAKJLHDPB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x561E690", Offset = "0x561D690", VA = "0x18561E690", Slot = "4")]
		public bool Equals(IPEndPoint GDALFMOOMGE, IPEndPoint CPFDGDKGJBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x50F7540", Offset = "0x50F6540", VA = "0x1850F7540", Slot = "5")]
		public int GetHashCode(IPEndPoint FGOCJODIEMI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FMJAKJLHDPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct EFKHPFPPJGA : IEnumerator<NHPCBOGEGDC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly NHPCBOGEGDC HJKCCKDAOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NHPCBOGEGDC MKEONIOCGMG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NHPCBOGEGDC FKHNLELEDDF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x908AB0", Offset = "0x907AB0", VA = "0x180908AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x908AB0", Offset = "0x907AB0", VA = "0x180908AB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF49C60", Offset = "0xF48C60", VA = "0x180F49C60")]
		public EFKHPFPPJGA(NHPCBOGEGDC GAAEMIDPEHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x561E5F0", Offset = "0x561D5F0", VA = "0x18561E5F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x561E640", Offset = "0x561D640", VA = "0x18561E640", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread HAJNOKIKNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool BEOEOJMDADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent FBJDNPOEAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<CPJKHPBAOOK> LCMNHHBJIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CPJKHPBAOOK> PCCDNMCMDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private CPJKHPBAOOK LDBLAEBNPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly CEDFANBHBAC ABBFBFOFLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KDPCICKAHLG OCBEIEDKNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly GLOMPPIANDF LBAICLJFDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly AFCFAEDGLHD NGKEKLLPPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, NHPCBOGEGDC> FMKFAIJKGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, JADHCKDMJGO> ALILLFHILDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, ADCEOGCKNKN> IDMOAOMKLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim LNGCHIMFNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NHPCBOGEGDC HCNKDCFJOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int CLNGIGIKKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NHPCBOGEGDC> IOFGMNANDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NHPCBOGEGDC[] GECEPHEAHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CNNHLBODLNE IEHHBJMHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int BKEJCDEOJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> PDAALKKNOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte ANHPOIHBABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object HAJJJAANBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool GKALCMLDGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool PEHELEDIODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int FFPJEPDJJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KLIBFKJOEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int AEJFBMNAHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int CPGCJHMCNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool JGANPGELMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool DOAOOPHNCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int NJPIDNKHMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int OPEFDNGBNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MFOAOACIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool KHOCKBFIFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool MEOGLDJBBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool EMFPDBCMLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KDHJKMKDCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int MBIKBDOCGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int LNDBCLNEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool DDCMCHCGGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly KCFEBBFMOLG GLCDAIMPAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool IMPALGODKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly HMPIFDFMIBA KGONJPMJEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool GGAINKHHOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public PCPKCGKODCG LBDLJBNNMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int NENOJOBMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool AAFKKCLHDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool ELOCIDBBNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool DIDIPNJANLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool LCLKOJIELIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private DLBOMPEFPEF MMCAHMGHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int PGLHCEHEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object MAHCKFHOJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DLBOMPEFPEF NKDMOMCHBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NBFOBJHBAKE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int HPPDJAGFIMP = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int DLBKPPMAHDO = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LOLGDKAEKNE DEBFKJNPLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LOLGDKAEKNE IKNOJIPJCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread FPHFFBAAEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread MJBMALLJBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint NDPBLBEHKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint HIGNFDPOCOK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] CANGHPDIHIO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] PJCJPOJNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<MFCCFFGDNJI, IPEndPoint> NKMEDEKDLAK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress BIIMIIHLOON;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool NHGCPGPOKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GLCOCHDDGNL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool GNFNEADMDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA67450", Offset = "0xA66450", VA = "0x180A67450")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB30090", Offset = "0xB2F090", VA = "0x180B30090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FAOBPFOHODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x161D260", Offset = "0x161C260", VA = "0x18161D260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x161BEE0", Offset = "0x161AEE0", VA = "0x18161BEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte BOBPBHMDALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CCCF0", Offset = "0x8CBCF0", VA = "0x1808CCCF0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IJBJJGHIAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5618E60", Offset = "0x5617E60", VA = "0x185618E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short OOHBMFCCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x561CB00", Offset = "0x561BB00", VA = "0x18561CB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5616EE0", Offset = "0x5615EE0", VA = "0x185616EE0")]
	public void DDLIABICEOK(IPEndPoint IOLKKJCLFNN, byte[] IPAJBJLLPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5617010", Offset = "0x5616010", VA = "0x185617010")]
	public void DLHMLFCJBJH(IPEndPoint IOLKKJCLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5616F80", Offset = "0x5615F80", VA = "0x185616F80")]
	private bool DFFCBOJIJPB(IPEndPoint IOLKKJCLFNN, [Out] NHPCBOGEGDC KEBCDACPHMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x56186E0", Offset = "0x56176E0", VA = "0x1856186E0")]
	private void EJBOBAGKKCA(NHPCBOGEGDC KEBCDACPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5618690", Offset = "0x5617690", VA = "0x185618690")]
	private void EEKCOCAKBKN(NHPCBOGEGDC KEBCDACPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5616A60", Offset = "0x5615A60", VA = "0x185616A60")]
	private void CCIEHCEDJMF(NHPCBOGEGDC KEBCDACPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x561D360", Offset = "0x561C360", VA = "0x18561D360")]
	public DHAPFCCGMJE(CEDFANBHBAC DCKPMIGBIJO, [Optional] CNNHLBODLNE IDHAKJKLJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x561B840", Offset = "0x561A840", VA = "0x18561B840")]
	internal void MKIOGHOJMKC(NHPCBOGEGDC JLFHCCNEIBJ, int ANDPIFIIOAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5616E90", Offset = "0x5615E90", VA = "0x185616E90")]
	internal void CKJBEELEGGL(NHPCBOGEGDC JLFHCCNEIBJ, object LKMCHFFGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x561AA60", Offset = "0x5619A60", VA = "0x18561AA60")]
	internal void JDCCFOILGNA(NHPCBOGEGDC KEBCDACPHMA, DDDJKOOHGNO CPHMIDDIJGK, SocketError DNEEJBMHPID, DLBOMPEFPEF KGGAPJLLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x561B6A0", Offset = "0x561A6A0", VA = "0x18561B6A0")]
	private void MGGMCLDHNFM(NHPCBOGEGDC KEBCDACPHMA, DDDJKOOHGNO CPHMIDDIJGK, SocketError DNEEJBMHPID, bool GCPGMMGNKLP, byte[] ELANMAGHLLI, int CGJCOMADABC, int FBDNKGNOEFD, DLBOMPEFPEF KGGAPJLLPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x561B230", Offset = "0x561A230", VA = "0x18561B230")]
	private void LNNDIICDEOG(CPJKHPBAOOK.NBGPEEDACFF IKHOLAJCJOG, [Optional] NHPCBOGEGDC KEBCDACPHMA, [Optional] IPEndPoint ENEEIADMAHO, SocketError ILDJAPLNIMH = SocketError.Success, int ANDPIFIIOAP = 0, DDDJKOOHGNO OJCGHGINFCO = DDDJKOOHGNO.ConnectionFailed, [Optional] JADHCKDMJGO CMMNNBAGBFC, IEOGIHIIJKI CPIJFJHHEAC = IEOGIHIIJKI.Unreliable, byte JIDIOOGBAOE = 0, [Optional] DLBOMPEFPEF OHLADBGPGOA, [Optional] object LKMCHFFGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5617B70", Offset = "0x5616B70", VA = "0x185617B70")]
	private void EBFACOPPOIB(CPJKHPBAOOK HGJIEONDGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5619EF0", Offset = "0x5618EF0", VA = "0x185619EF0")]
	internal void HNNOAKFGPNB(CPJKHPBAOOK HGJIEONDGNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5618E80", Offset = "0x5617E80", VA = "0x185618E80")]
	private void GLFJDNDBPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5619750", Offset = "0x5618750", VA = "0x185619750")]
	private void HJGBLGBCCAO(int BPFNKEJACHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x561AB30", Offset = "0x5619B30", VA = "0x18561AB30")]
	internal NHPCBOGEGDC LJPEBEIFCIP(JADHCKDMJGO LFFEKPPMJHN, byte[] OKHJAKBPKAH, int CGJCOMADABC, int NAHHNFGPNAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x56169E0", Offset = "0x56159E0", VA = "0x1856169E0")]
	private int CACJMIEGJEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5618A00", Offset = "0x5617A00", VA = "0x185618A00")]
	private void GDOKFCEEKNN(IPEndPoint ENEEIADMAHO, NHPCBOGEGDC HLBMBPCMDJP, BEDNAMELPBP FPDCCNFHNEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x561BAF0", Offset = "0x561AAF0", VA = "0x18561BAF0")]
	private void NPBPJIOAEGD(DLBOMPEFPEF LCLIEHKHJLN, IPEndPoint ENEEIADMAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x561C840", Offset = "0x561B840", VA = "0x18561C840")]
	internal void OCDLLHMLKEG(DLBOMPEFPEF LCLIEHKHJLN, IEOGIHIIJKI EAIHOEJOEIA, byte JIDIOOGBAOE, int CFGGCLOGMGK, NHPCBOGEGDC JLFHCCNEIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5617B60", Offset = "0x5616B60", VA = "0x185617B60")]
	public bool EBEKMFPLELC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5617380", Offset = "0x5616380", VA = "0x185617380")]
	public bool EBEKMFPLELC(IPAddress FDPCEIPFJIB, IPAddress CFHMMOJDKND, int KEEIILHLCMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5617300", Offset = "0x5616300", VA = "0x185617300")]
	public bool EBEKMFPLELC(int KEEIILHLCMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5617160", Offset = "0x5616160", VA = "0x185617160")]
	public void EAGIJHPOBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x56191C0", Offset = "0x56181C0", VA = "0x1856191C0")]
	public NHPCBOGEGDC GMMCAPJLPFL(string PFLPKLHGIOM, int KEEIILHLCMJ, string IPAJBJLLPIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x56192A0", Offset = "0x56182A0", VA = "0x1856192A0")]
	public NHPCBOGEGDC GMMCAPJLPFL(string PFLPKLHGIOM, int KEEIILHLCMJ, CHGEFENFMJB NILHLIDDDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5619380", Offset = "0x5618380", VA = "0x185619380")]
	public NHPCBOGEGDC GMMCAPJLPFL(IPEndPoint PGJBCOPPFBK, CHGEFENFMJB NILHLIDDDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5618680", Offset = "0x5617680", VA = "0x185618680")]
	public void ECBGDFNMHFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5618330", Offset = "0x5617330", VA = "0x185618330")]
	public void ECBGDFNMHFA(bool JIGEFFEEBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x561CDF0", Offset = "0x561BDF0", VA = "0x18561CDF0")]
	public void OKPFLEHJAHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x561CEF0", Offset = "0x561BEF0", VA = "0x18561CEF0")]
	public void OKPFLEHJAHB(byte[] ELANMAGHLLI, int CGJCOMADABC, int FBDNKGNOEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x561B5F0", Offset = "0x561A5F0", VA = "0x18561B5F0")]
	public void MGGMCLDHNFM(NHPCBOGEGDC KEBCDACPHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x561B780", Offset = "0x561A780", VA = "0x18561B780")]
	public void MGGMCLDHNFM(NHPCBOGEGDC KEBCDACPHMA, byte[] ELANMAGHLLI, int CGJCOMADABC, int FBDNKGNOEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x561D180", Offset = "0x561C180", VA = "0x18561D180", Slot = "4")]
	private IEnumerator<NHPCBOGEGDC> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x561D210", Offset = "0x561C210", VA = "0x18561D210", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5616CC0", Offset = "0x5615CC0", VA = "0x185616CC0")]
	private DLBOMPEFPEF CFCLKDGCMOP(GICOBHGPCCG DFALMLPAKJC, int BEELDCKKFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5616DB0", Offset = "0x5615DB0", VA = "0x185616DB0")]
	private DLBOMPEFPEF CFCLKDGCMOP(GICOBHGPCCG DFALMLPAKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x561CBC0", Offset = "0x561BBC0", VA = "0x18561CBC0")]
	internal DLBOMPEFPEF OJKOICIKDDP(int BEELDCKKFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x561B890", Offset = "0x561A890", VA = "0x18561B890")]
	internal void NFDICFCENEN(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x561D2A0", Offset = "0x561C2A0", VA = "0x18561D2A0")]
	static DHAPFCCGMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA67450", Offset = "0xA66450", VA = "0x180A67450")]
	private bool EJJDCENODGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5619A70", Offset = "0x5618A70", VA = "0x185619A70")]
	private void HJKMPLIPCFL(IPEndPoint HHLOKCNHDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x561B150", Offset = "0x561A150", VA = "0x18561B150")]
	private void LNJMPMPKKHK(IPEndPoint HHLOKCNHDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x561A2C0", Offset = "0x56192C0", VA = "0x18561A2C0")]
	private bool IFBNIDDDHCD(SocketException NNMGILNOFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5619FF0", Offset = "0x5618FF0", VA = "0x185619FF0")]
	private void IDLJCKJIJFD(LOLGDKAEKNE IDIGAOLCKNP, EndPoint DJADPAODDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5619B60", Offset = "0x5618B60", VA = "0x185619B60")]
	private void HMDBGLGILMK(object NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x56173A0", Offset = "0x56163A0", VA = "0x1856173A0")]
	public bool EBEKMFPLELC(IPAddress FDPCEIPFJIB, IPAddress CFHMMOJDKND, int KEEIILHLCMJ, bool CMKGCHHKCIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56189A0", Offset = "0x56179A0", VA = "0x1856189A0")]
	internal int FOJOIEHFICA(DLBOMPEFPEF LCLIEHKHJLN, IPEndPoint ENEEIADMAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x561AA20", Offset = "0x5619A20", VA = "0x18561AA20")]
	internal int INHGPLCGBCM(DLBOMPEFPEF LCLIEHKHJLN, IPEndPoint ENEEIADMAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x561A460", Offset = "0x5619460", VA = "0x18561A460")]
	internal int INHGPLCGBCM(byte[] DFJKCKBFLAD, int CGJCOMADABC, int NAHHNFGPNAE, IPEndPoint ENEEIADMAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x561D010", Offset = "0x561C010", VA = "0x18561D010")]
	internal void PIINNJGCIFG(bool MPMBFFDBPMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GICOBHGPCCG : byte
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
internal sealed class DLBOMPEFPEF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int JJLOOGHKBOD;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] KNFIGBMIHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] LALMLLINKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int DAPBPFEGNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object HPBDBIALIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public DLBOMPEFPEF GMLEKMDNCFA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GICOBHGPCCG NPDLFNCFNAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x561DFA0", Offset = "0x561CFA0", VA = "0x18561DFA0")]
		get
		{
			return default(GICOBHGPCCG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x561DD00", Offset = "0x561CD00", VA = "0x18561DD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte ENPOBIEBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x561DE70", Offset = "0x561CE70", VA = "0x18561DE70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x561DC80", Offset = "0x561CC80", VA = "0x18561DC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort NJJGLMNDLNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x561DAC0", Offset = "0x561CAC0", VA = "0x18561DAC0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x561DA80", Offset = "0x561CA80", VA = "0x18561DA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AEHJNJEPDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x561DB20", Offset = "0x561CB20", VA = "0x18561DB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte MKOGPHINIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x561DB50", Offset = "0x561CB50", VA = "0x18561DB50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x561DA50", Offset = "0x561CA50", VA = "0x18561DA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort PMMKHKCCHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x561DC20", Offset = "0x561CC20", VA = "0x18561DC20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x561DCC0", Offset = "0x561CCC0", VA = "0x18561DCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ANPLOFFGALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x561DB80", Offset = "0x561CB80", VA = "0x18561DB80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x561D9B0", Offset = "0x561C9B0", VA = "0x18561D9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JEHJFBMBALG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x561D9F0", Offset = "0x561C9F0", VA = "0x18561D9F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x561DBE0", Offset = "0x561CBE0", VA = "0x18561DBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x561DFD0", Offset = "0x561CFD0", VA = "0x18561DFD0")]
	static DLBOMPEFPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x561DD40", Offset = "0x561CD40", VA = "0x18561DD40")]
	public void NFELJAMLAGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x561E3C0", Offset = "0x561D3C0", VA = "0x18561E3C0")]
	public DLBOMPEFPEF(int BEELDCKKFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x561E2B0", Offset = "0x561D2B0", VA = "0x18561E2B0")]
	public DLBOMPEFPEF(GICOBHGPCCG DFALMLPAKJC, int BEELDCKKFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x561DF30", Offset = "0x561CF30", VA = "0x18561DF30")]
	public static int PBBNOBBMMCO(GICOBHGPCCG DFALMLPAKJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x561DEA0", Offset = "0x561CEA0", VA = "0x18561DEA0")]
	public int PBBNOBBMMCO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x561DD70", Offset = "0x561CD70", VA = "0x18561DD70")]
	public bool OBAHDLEGPKE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum AJNKDNPBFED : byte
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
internal enum FDLOMKMANJE
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
internal enum HCPDLONJFKK
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum MFIKIGBBCOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NHPCBOGEGDC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GJODEPJIDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DLBOMPEFPEF[] JGMBCAOJFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int IOOPNCLIFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int BCIOKMGLLID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte MKOGPHINIMA;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public GJODEPJIDBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void GNHIEELLKIP(ulong BPALHPJFADI, int AGHHFIAAOML);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int NMCKMGALCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int IEEFFHAEBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int LDALNOJMDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double ELKCOPMPFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int CANPNGLNPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int CIAHGPDBEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int HHIOEJMMFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch FGEHINNNGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int FDHAMILGCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long APNHPMABMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object DKONAMLJBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal NHPCBOGEGDC CDAJGGOEGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal NHPCBOGEGDC GBAICPLMMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<DLBOMPEFPEF> EBHNMNNDJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<EFFNOFKLPJI> ICOEOFAPFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly EFFNOFKLPJI[] HOEPKFIMMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int DNFLNGMOIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int BKDOJOLCBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool MDGCJHNHMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int KEMBIAPILHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int DGODEBBLAJI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CMIACAHDMJD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int ACODHFJIMKF = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object MEDFHDFMMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int IDIFEBPACIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GJODEPJIDBE> GHMLHFPHKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> EHIPDMADMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DLBOMPEFPEF DLMHJCHPCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int KAMEDKGGKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int KPPJLHKJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint BMAMLKHMKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CPMMOFJHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int KBECFCAMFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long BGDONPNDAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte KLPLGEMELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private AJNKDNPBFED LKMGHDIMODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private DLBOMPEFPEF GINCBLFCFMG;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int EPMJNFBLLPE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int GAAAEHNLIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly DLBOMPEFPEF JAFJHOOLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly DLBOMPEFPEF HJBDMOGLLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly DLBOMPEFPEF KFCGCFIDIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly DLBOMPEFPEF IOHLJHDHDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private ONKBEIKCMDL NGPJPJNLEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly DHAPFCCGMJE ECMKLFACGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int NIAPEAHEHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object EEEHKIEMBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly KCFEBBFMOLG GLCDAIMPAPO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte FDJLOFCAABF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA4870", Offset = "0xAA3870", VA = "0x180AA4870")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5628240", Offset = "0x5627240", VA = "0x185628240")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint HIPHGLILFKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FBA20", Offset = "0x8FAA20", VA = "0x1808FBA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AJNKDNPBFED CIEAMDDIBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x16254C0", Offset = "0x16244C0", VA = "0x1816254C0")]
		get
		{
			return default(AJNKDNPBFED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long LIOJJJAKOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C97B0", Offset = "0x7C87B0", VA = "0x1807C97B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NMIEDGBCMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB72FA0", Offset = "0xB71FA0", VA = "0x180B72FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x144EDC0", Offset = "0x144DDC0", VA = "0x18144EDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int ILBFHOCGAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5628230", Offset = "0x5627230", VA = "0x185628230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int LINOBMOFBID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB1C0", Offset = "0x7CA1C0", VA = "0x1807CB1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double NGBKBMACLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1852140", Offset = "0x1851140", VA = "0x181852140")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GNHIEELLKIP ACLIALJHEHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5627D10", Offset = "0x5626D10", VA = "0x185627D10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5624D80", Offset = "0x5623D80", VA = "0x185624D80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5628790", Offset = "0x5627790", VA = "0x185628790")]
	internal NHPCBOGEGDC(DHAPFCCGMJE HMIIBOMCAAG, IPEndPoint ENEEIADMAHO, int IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5627400", Offset = "0x5626400", VA = "0x185627400")]
	internal void GALENLCFGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5626910", Offset = "0x5625910", VA = "0x185626910")]
	internal void DKGHLJLDGPG(IPEndPoint IFAGMKAADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5626C50", Offset = "0x5625C50", VA = "0x185626C50")]
	internal void ECONLMHKFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5627740", Offset = "0x5626740", VA = "0x185627740")]
	private void HAMPLGCKGPO(int LPPMBIEFPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56281F0", Offset = "0x56271F0", VA = "0x1856281F0")]
	private void MPCAFIKOBMO(int KINMMBDGFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5627DC0", Offset = "0x5626DC0", VA = "0x185627DC0")]
	private EFFNOFKLPJI KKFKPALOHLG(byte HCGAIOKHKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5628600", Offset = "0x5627600", VA = "0x185628600")]
	internal NHPCBOGEGDC(DHAPFCCGMJE HMIIBOMCAAG, IPEndPoint ENEEIADMAHO, int IJKMNFNHLGO, byte DAFLPPNOAMJ, CHGEFENFMJB OCJKIGHNPDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5628BF0", Offset = "0x5627BF0", VA = "0x185628BF0")]
	internal NHPCBOGEGDC(DHAPFCCGMJE HMIIBOMCAAG, JADHCKDMJGO LFFEKPPMJHN, int IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x56285B0", Offset = "0x56275B0", VA = "0x1856285B0")]
	internal void OJELLMMBEEO(BEDNAMELPBP KBMMLFOJLFF, byte[] ELANMAGHLLI, int CGJCOMADABC, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x56275E0", Offset = "0x56265E0", VA = "0x1856275E0")]
	internal bool GGPBEMCAOBA(LEIMKKNEFAE LCLIEHKHJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5626CE0", Offset = "0x5625CE0", VA = "0x185626CE0")]
	public void EGPAKDDIGDD(byte[] ELANMAGHLLI, int CGJCOMADABC, int NAHHNFGPNAE, IEOGIHIIJKI KJMCMIAJLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5624E30", Offset = "0x5623E30", VA = "0x185624E30")]
	private void BEGJHDOAKJD(byte[] ELANMAGHLLI, int CGJCOMADABC, int NAHHNFGPNAE, byte JIDIOOGBAOE, IEOGIHIIJKI CPIJFJHHEAC, object LKMCHFFGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5627F70", Offset = "0x5626F70", VA = "0x185627F70")]
	public void LFHGOCPMJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5627660", Offset = "0x5626660", VA = "0x185627660")]
	internal HCPDLONJFKK GNKCGEAGPJL(DLBOMPEFPEF LCLIEHKHJLN)
	{
		return default(HCPDLONJFKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5627B90", Offset = "0x5626B90", VA = "0x185627B90")]
	internal void IPCDGNDKCJD(EFFNOFKLPJI BEMGGLGKLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5626940", Offset = "0x5625940", VA = "0x185626940")]
	internal MFIKIGBBCOJ DPHAIKAJGBL(byte[] ELANMAGHLLI, int CGJCOMADABC, int NAHHNFGPNAE, bool GCPGMMGNKLP)
	{
		return default(MFIKIGBBCOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x56273C0", Offset = "0x56263C0", VA = "0x1856273C0")]
	private void EOEICMOPJMB(int MPABELHPGCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x56258D0", Offset = "0x56248D0", VA = "0x1856258D0")]
	internal void BMNJCPINPAE(IEOGIHIIJKI EAIHOEJOEIA, DLBOMPEFPEF GAAEMIDPEHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5625380", Offset = "0x5624380", VA = "0x185625380")]
	private void BMKNEMDIPKP(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5627810", Offset = "0x5626810", VA = "0x185627810")]
	private void ICOGMOHCPHB(int HBFOIDKFIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5627420", Offset = "0x5626420", VA = "0x185627420")]
	internal FDLOMKMANJE GDOKFCEEKNN(BEDNAMELPBP FPDCCNFHNEI)
	{
		return default(FDLOMKMANJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5626260", Offset = "0x5625260", VA = "0x185626260")]
	internal void BPDBBDAGMMK(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5627BF0", Offset = "0x5626BF0", VA = "0x185627BF0")]
	private void JDFDEALCLJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5628020", Offset = "0x5627020", VA = "0x185628020")]
	internal void MGJMFGJDNNL(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5626D10", Offset = "0x5625D10", VA = "0x185626D10")]
	internal void EKOOOFBJPAE(int HBFOIDKFIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x56282F0", Offset = "0x56272F0", VA = "0x1856282F0")]
	internal void OALCOJNBEDD(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KCFEBBFMOLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KADAHCAMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long EEJBHKPOLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long KFEAOIDPINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long AHEIAGEDFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long IFFAJMFHIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long PLHOAGLNMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long JIBLEEIPNMN;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long DJCMGIHCNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5620C80", Offset = "0x561FC80", VA = "0x185620C80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long HOAOOLGLMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5620E10", Offset = "0x561FE10", VA = "0x185620E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long MKMOCAMOKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5620D60", Offset = "0x561FD60", VA = "0x185620D60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long OKKCIJHNFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5620C90", Offset = "0x561FC90", VA = "0x185620C90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MIALAPJNBKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5620D50", Offset = "0x561FD50", VA = "0x185620D50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long FKMLCLPELJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5620CA0", Offset = "0x561FCA0", VA = "0x185620CA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private ONKBEIKCMDL PCFKEDOADIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1AAA370", Offset = "0x1AA9370", VA = "0x181AAA370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double NBEBOLGDDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5620CB0", Offset = "0x561FCB0", VA = "0x185620CB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5620D70", Offset = "0x561FD70", VA = "0x185620D70")]
	public void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5620E20", Offset = "0x561FE20", VA = "0x185620E20")]
	public void LPPPANPCFMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5620E00", Offset = "0x561FE00", VA = "0x185620E00")]
	public void IDGHKHLAAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5620EF0", Offset = "0x561FEF0", VA = "0x185620EF0")]
	public void OCNMMPPHOLO(long BKBAJEHGOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5620F00", Offset = "0x561FF00", VA = "0x185620F00")]
	public void POJCKJBCCFD(long JGDCJPMOOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5620DD0", Offset = "0x561FDD0", VA = "0x185620DD0")]
	public void GDLLDKICCKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5620D10", Offset = "0x561FD10", VA = "0x185620D10")]
	public void DOPIOPJAFMN(long AAOGOCJFAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5620F10", Offset = "0x561FF10", VA = "0x185620F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5620E50", Offset = "0x561FE50", VA = "0x185620E50")]
	public void NKBPJFGFFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KCFEBBFMOLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MGLPAIPCBOE
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> JINNBALDEII;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5623130", Offset = "0x5622130", VA = "0x185623130")]
	public static IPEndPoint JPJPHOPNHBK(string ENOPEKOJNAG, int KEEIILHLCMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5623410", Offset = "0x5622410", VA = "0x185623410")]
	public static IPAddress LFNBEFOLIMB(string ENOPEKOJNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5623380", Offset = "0x5622380", VA = "0x185623380")]
	public static IPAddress LFNBEFOLIMB(string ENOPEKOJNAG, AddressFamily OKLENFGENDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5623100", Offset = "0x5622100", VA = "0x185623100")]
	internal static int HKMPGPDEGML(int FJMKENKLHGI, int FGAHAIJGBCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x287C980", Offset = "0x287B980", VA = "0x18287C980")]
	internal static T[] EJOKDLALCBJ<T>(int FBDNKGNOEFD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class OLHGCBGBJGF : EFFNOFKLPJI
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct OPMPDNCMJLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private DLBOMPEFPEF PKPBEKJOHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long AANDPKPJPLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool POJKHNKKJKM;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x562A150", Offset = "0x5629150", VA = "0x18562A150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x562A0C0", Offset = "0x56290C0", VA = "0x18562A0C0")]
		public void IPDECBGGCGL(DLBOMPEFPEF LCLIEHKHJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x562A0E0", Offset = "0x56290E0", VA = "0x18562A0E0")]
		public bool PEAJDDIICMH(long FKCEECKJIEI, NHPCBOGEGDC KEBCDACPHMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x562A070", Offset = "0x5629070", VA = "0x18562A070")]
		public bool BGPDDONPEEO(NHPCBOGEGDC KEBCDACPHMA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly DLBOMPEFPEF KBDIDBNJFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly OPMPDNCMJLJ[] ECAADGEBNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly DLBOMPEFPEF[] LEKPEEBFPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] NFEFOIMCJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int MNBCCHAGGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int IIBNIFEHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int NDMNEJHGHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int BKCNMCPNGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KGECHPBHHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly IEOGIHIIJKI GGILKJHKMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool EBKNPKMDIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int IFLBBJBICIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte GGLGACLHOKM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5629D40", Offset = "0x5628D40", VA = "0x185629D40")]
	public OLHGCBGBJGF(NHPCBOGEGDC KEBCDACPHMA, bool DHMJJHODEPG, byte IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5629980", Offset = "0x5628980", VA = "0x185629980")]
	private void NKKABEECMCA(DLBOMPEFPEF LCLIEHKHJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56294D0", Offset = "0x56284D0", VA = "0x1856294D0", Slot = "4")]
	protected override bool DPBFECDHLML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5628E70", Offset = "0x5627E70", VA = "0x185628E70", Slot = "5")]
	public override bool BPDBBDAGMMK(DLBOMPEFPEF LCLIEHKHJLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OPODBHDDGIA : EFFNOFKLPJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int OJKAFIGGLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort IIBNIFEHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool KFCIGMGDPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private DLBOMPEFPEF JNHIILCDMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly DLBOMPEFPEF CKDOBCFLIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool DHFIJMDIKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte GGLGACLHOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long NANJOKOCEFL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x562A9A0", Offset = "0x56299A0", VA = "0x18562A9A0")]
	public OPODBHDDGIA(NHPCBOGEGDC KEBCDACPHMA, bool FOLFCHNKEAJ, byte IJKMNFNHLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x562A500", Offset = "0x5629500", VA = "0x18562A500", Slot = "4")]
	protected override bool DPBFECDHLML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x562A1F0", Offset = "0x56291F0", VA = "0x18562A1F0", Slot = "5")]
	public override bool BPDBBDAGMMK(DLBOMPEFPEF LCLIEHKHJLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OOHCCCMDHLE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OEPHNFDIHMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong KCACGEFBAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double JLFMALEHKFJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OOAGAINBEFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int LHDJDMDGPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float PGBKMMOAHGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5615420", Offset = "0x5614420", VA = "0x185615420")]
	private static void HGNABAFDPCC(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, ulong ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5629F10", Offset = "0x5628F10", VA = "0x185629F10")]
	private static void HGNABAFDPCC(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, int ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x562A020", Offset = "0x5629020", VA = "0x18562A020")]
	public static void HGNABAFDPCC(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, short ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x562A000", Offset = "0x5629000", VA = "0x18562A000")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, double CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5629F80", Offset = "0x5628F80", VA = "0x185629F80")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x562A020", Offset = "0x5629020", VA = "0x18562A020")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, short CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x562A020", Offset = "0x5629020", VA = "0x18562A020")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, ushort CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5629F10", Offset = "0x5628F10", VA = "0x185629F10")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, int CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5629F10", Offset = "0x5628F10", VA = "0x185629F10")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, uint CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x562A060", Offset = "0x5629060", VA = "0x18562A060")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, long CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x562A060", Offset = "0x5629060", VA = "0x18562A060")]
	public static void AEICPDLMOAD(byte[] EOMNNFHDHII, int BMGBMMPKFAO, ulong CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IPAPMJFPALB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] IGABGFMFCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int MJNLDNNALBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int ILAHMDGNNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int BFOBBCKKOIB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] LALMLLINKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int CDEFEBGMCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x967480", Offset = "0x966480", VA = "0x180967480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int MHPNFHJOADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5620420", Offset = "0x561F420", VA = "0x185620420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JNBAPJEPBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7A90", Offset = "0x1CF6A90", VA = "0x181CF7A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HAGGOCDGNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x56206B0", Offset = "0x561F6B0", VA = "0x1856206B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x561FFD0", Offset = "0x561EFD0", VA = "0x18561FFD0")]
	public void CFENEJCNLDB(byte[] HLPKKPNOMHG, int CNHEAECNOFO, int DEFBAGFLDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IPAPMJFPALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x56206C0", Offset = "0x561F6C0", VA = "0x1856206C0")]
	public IPAPMJFPALB(byte[] HLPKKPNOMHG, int CNHEAECNOFO, int DEFBAGFLDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5620310", Offset = "0x561F310", VA = "0x185620310")]
	public IPEndPoint ICHPOOFAAHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x56202D0", Offset = "0x561F2D0", VA = "0x1856202D0")]
	public byte HDOINLKDIEJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x56202D0", Offset = "0x561F2D0", VA = "0x1856202D0")]
	public sbyte OOHONCPIBEO()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x27E5240", Offset = "0x27E4240", VA = "0x1827E5240")]
	public T[] GHIHKDFPHNB<T>(ushort BEELDCKKFJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x56204A0", Offset = "0x561F4A0", VA = "0x1856204A0")]
	public bool[] LCPEMMJCDEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x561FAD0", Offset = "0x561EAD0", VA = "0x18561FAD0")]
	public ushort[] AEFIBPEMEMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x56200C0", Offset = "0x561F0C0", VA = "0x1856200C0")]
	public short[] DCLLADMFCEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x561FC40", Offset = "0x561EC40", VA = "0x18561FC40")]
	public int[] AJAJMHFDCMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5620080", Offset = "0x561F080", VA = "0x185620080")]
	public uint[] CPNMBFGLBHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5620600", Offset = "0x561F600", VA = "0x185620600")]
	public float[] NOCNAGFGJLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x561FF90", Offset = "0x561EF90", VA = "0x18561FF90")]
	public double[] BNOLOEIPIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x56203E0", Offset = "0x561F3E0", VA = "0x1856203E0")]
	public long[] IKMMBBMBPCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5620290", Offset = "0x561F290", VA = "0x185620290")]
	public ulong[] HCKCHJPOHCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x561FB10", Offset = "0x561EB10", VA = "0x18561FB10")]
	public string[] AIFOODKBPCH(int COALLBGPAJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x561FC80", Offset = "0x561EC80", VA = "0x18561FC80")]
	public bool ANJDPEPLGLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5620170", Offset = "0x561F170", VA = "0x185620170")]
	public char EIMHOCMNMBP()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5620170", Offset = "0x561F170", VA = "0x185620170")]
	public ushort GLGKMLGJOGE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5620010", Offset = "0x561F010", VA = "0x185620010")]
	public short CFNHENNFCOG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x56204E0", Offset = "0x561F4E0", VA = "0x1856204E0")]
	public long LIDOIBBOGMD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5620220", Offset = "0x561F220", VA = "0x185620220")]
	public ulong GGFPLNNICFE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x561FF20", Offset = "0x561EF20", VA = "0x18561FF20")]
	public int BKDBJKLKNBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5620640", Offset = "0x561F640", VA = "0x185620640")]
	public uint NOEMACCHPEA()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5620100", Offset = "0x561F100", VA = "0x185620100")]
	public float ECLNGJEAAIN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5620430", Offset = "0x561F430", VA = "0x185620430")]
	public double KJFKKKEJNFF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x561FCE0", Offset = "0x561ECE0", VA = "0x18561FCE0")]
	public string BIOFNFEJHJM(int JKABMGFMNKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5620550", Offset = "0x561F550", VA = "0x185620550")]
	public ArraySegment<byte> MEBOPIOLOON(int FBDNKGNOEFD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56205C0", Offset = "0x561F5C0", VA = "0x1856205C0")]
	public sbyte[] NAMNCFODOJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x56201E0", Offset = "0x561F1E0", VA = "0x1856201E0")]
	public byte[] ENDMMIPGMPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x561FCC0", Offset = "0x561ECC0", VA = "0x18561FCC0")]
	public void BGPDDONPEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CHGEFENFMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] IGABGFMFCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int MJNLDNNALBL;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int PKINDCCOKDM = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool GLNOBJNJMAL;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding KJCCLCEPPOE;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int ODOJCKGDJGF = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] HMKFLPJGONE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] GCOMEMFCJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HOCNAFCFDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5616820", Offset = "0x5615820", VA = "0x185616820")]
	public CHGEFENFMJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56168A0", Offset = "0x56158A0", VA = "0x1856168A0")]
	public CHGEFENFMJB(bool HFHCMIBCINB, int HHLNLOJCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5615BD0", Offset = "0x5614BD0", VA = "0x185615BD0")]
	public static CHGEFENFMJB EDAGHNADKCJ(string CFJDHAGGAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x56166F0", Offset = "0x56156F0", VA = "0x1856166F0")]
	public void OHBMPJGNOJF(int HNBEOBKGOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D71710", Offset = "0x1D70710", VA = "0x181D71710")]
	public void FPNJJPKFGNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x56160A0", Offset = "0x56150A0", VA = "0x1856160A0")]
	public void JEMPIDCFEPJ(float CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x56166A0", Offset = "0x56156A0", VA = "0x1856166A0")]
	public void JEMPIDCFEPJ(double CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x56163E0", Offset = "0x56153E0", VA = "0x1856163E0")]
	public void JEMPIDCFEPJ(long CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x56163E0", Offset = "0x56153E0", VA = "0x1856163E0")]
	public void JEMPIDCFEPJ(ulong CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5616140", Offset = "0x5615140", VA = "0x185616140")]
	public void JEMPIDCFEPJ(int CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5616140", Offset = "0x5615140", VA = "0x185616140")]
	public void JEMPIDCFEPJ(uint CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5616500", Offset = "0x5615500", VA = "0x185616500")]
	public void JEMPIDCFEPJ(char CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5616500", Offset = "0x5615500", VA = "0x185616500")]
	public void JEMPIDCFEPJ(ushort CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5616500", Offset = "0x5615500", VA = "0x185616500")]
	public void JEMPIDCFEPJ(short CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x56164A0", Offset = "0x56154A0", VA = "0x1856164A0")]
	public void JEMPIDCFEPJ(sbyte CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x56164A0", Offset = "0x56154A0", VA = "0x1856164A0")]
	public void JEMPIDCFEPJ(byte CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5616430", Offset = "0x5615430", VA = "0x185616430")]
	public void JEMPIDCFEPJ(byte[] ELANMAGHLLI, int CNHEAECNOFO, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5615AF0", Offset = "0x5614AF0", VA = "0x185615AF0")]
	public void PHNJACNLDDH(sbyte[] ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5615AF0", Offset = "0x5614AF0", VA = "0x185615AF0")]
	public void BMKBLDKELFG(byte[] ELANMAGHLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5616570", Offset = "0x5615570", VA = "0x185616570")]
	public void JEMPIDCFEPJ(bool CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5615D20", Offset = "0x5614D20", VA = "0x185615D20")]
	public void HJJJNIGNFPL(Array AMCKAAAGJDG, int CAHFGDGKNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5615C40", Offset = "0x5614C40", VA = "0x185615C40")]
	public void HJJJNIGNFPL(float[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5615EE0", Offset = "0x5614EE0", VA = "0x185615EE0")]
	public void HJJJNIGNFPL(double[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5615EE0", Offset = "0x5614EE0", VA = "0x185615EE0")]
	public void HJJJNIGNFPL(long[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5615EE0", Offset = "0x5614EE0", VA = "0x185615EE0")]
	public void HJJJNIGNFPL(ulong[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5615C40", Offset = "0x5614C40", VA = "0x185615C40")]
	public void HJJJNIGNFPL(int[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5615C40", Offset = "0x5614C40", VA = "0x185615C40")]
	public void HJJJNIGNFPL(uint[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5615E00", Offset = "0x5614E00", VA = "0x185615E00")]
	public void HJJJNIGNFPL(ushort[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5615E00", Offset = "0x5614E00", VA = "0x185615E00")]
	public void HJJJNIGNFPL(short[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5615AF0", Offset = "0x5614AF0", VA = "0x185615AF0")]
	public void HJJJNIGNFPL(bool[] CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5615FC0", Offset = "0x5614FC0", VA = "0x185615FC0")]
	public void HJJJNIGNFPL(string[] CFJDHAGGAJO, int JGDHLKIGCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56165D0", Offset = "0x56155D0", VA = "0x1856165D0")]
	public void JEMPIDCFEPJ(IPEndPoint IOLKKJCLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5616090", Offset = "0x5615090", VA = "0x185616090")]
	public void JEMPIDCFEPJ(string CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x56161D0", Offset = "0x56151D0", VA = "0x1856161D0")]
	public void JEMPIDCFEPJ(string CFJDHAGGAJO, int JKABMGFMNKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NFBDJOFFNKN
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class MALFAKJDCLD<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong NIAPEAHEHDC;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9DB0", Offset = "0x3EB8DB0", VA = "0x183EB9DB0")]
		static MALFAKJDCLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void IILLLFMMAFK(IPAPMJFPALB PCOFGFPALLL, object LKMCHFFGKFP);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NCAIBPIEDDP<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public NFBDJOFFNKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NCAIBPIEDDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3F400C0", Offset = "0x3F3F0C0", VA = "0x183F400C0")]
		internal void POEBCMAMHKA(IPAPMJFPALB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FGONCOGCHDC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NFBDJOFFNKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public FGONCOGCHDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x36737D0", Offset = "0x36727D0", VA = "0x1836737D0")]
		internal void POEBCMAMHKA(IPAPMJFPALB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly NPKNPGKHEOK KOPIBGDIEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, IILLLFMMAFK> DIGACMMDBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly CHGEFENFMJB DBINKEDIOKJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5624C00", Offset = "0x5623C00", VA = "0x185624C00")]
	public NFBDJOFFNKN(int COALLBGPAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x258DA00", Offset = "0x258CA00", VA = "0x18258DA00", Slot = "4")]
	protected virtual ulong DLHNBEOAIOK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5624AD0", Offset = "0x5623AD0", VA = "0x185624AD0", Slot = "5")]
	protected virtual IILLLFMMAFK NACCHHAJPPF(IPAPMJFPALB PCOFGFPALLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x28EBB10", Offset = "0x28EAB10", VA = "0x1828EBB10", Slot = "6")]
	protected virtual void BHLIMJKBPAO<T>(CHGEFENFMJB HKMKHKLNOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5624A00", Offset = "0x5623A00", VA = "0x185624A00")]
	public void EMDFODDPKEE(IPAPMJFPALB PCOFGFPALLL, object LKMCHFFGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x28EBB80", Offset = "0x28EAB80", VA = "0x1828EBB80")]
	public void CCBGBBLBEMM<T>(CHGEFENFMJB HKMKHKLNOHE, T LCLIEHKHJLN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5624A80", Offset = "0x5623A80", VA = "0x185624A80")]
	public void FDNGOJCGCHI(IPAPMJFPALB PCOFGFPALLL, object LKMCHFFGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x28EBD90", Offset = "0x28EAD90", VA = "0x1828EBD90")]
	public void KMLPKPBLEIG<T>(Action<T> FLHMBKBEKCM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x28EBC10", Offset = "0x28EAC10", VA = "0x1828EBC10")]
	public void KMLPKPBLEIG<T, TUserData>(Action<T, TUserData> FLHMBKBEKCM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BKHKAPDLCGO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5615AE0", Offset = "0x5614AE0", VA = "0x185615AE0")]
	public BKHKAPDLCGO(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MEGLEPHAKKF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5622EC0", Offset = "0x5621EC0", VA = "0x185622EC0")]
	public MEGLEPHAKKF(string DFJKCKBFLAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NPKNPGKHEOK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LEGLKABDOLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class AJOFEMPAJAH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LEGLKABDOLM MJIJAFEKHOG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x37A6B20", Offset = "0x37A5B20", VA = "0x1837A6B20", Slot = "4")]
		public virtual void IPDECBGGCGL(MethodInfo JDABCDMOMDM, MethodInfo EHGLKEPOCEA, LEGLKABDOLM IKHOLAJCJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HAGDCIDDOIF(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GLKLIGCEFOD(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		protected AJOFEMPAJAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class OMACFBNHOND<TClass, TProperty> : AJOFEMPAJAH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> LECMGMKDJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> DIGGHLHJGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> DMLGCFIOLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> NJNLGNCEKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> GFELCMLKEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> ELPJHBFEJLK;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x407CDC0", Offset = "0x407BDC0", VA = "0x18407CDC0", Slot = "7")]
		public override void FEEBAELMOOP(TClass CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4083A30", Offset = "0x4082A30", VA = "0x184083A30", Slot = "8")]
		public override void PDHGLKFDOFI(TClass CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x407ED40", Offset = "0x407DD40", VA = "0x18407ED40", Slot = "9")]
		public override void HAGDCIDDOIF(TClass CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x407D920", Offset = "0x407C920", VA = "0x18407D920", Slot = "10")]
		public override void GLKLIGCEFOD(TClass CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4084590", Offset = "0x4083590", VA = "0x184084590")]
		protected TProperty[] PEIHLHMPAAO(TClass CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x40839C0", Offset = "0x40829C0", VA = "0x1840839C0")]
		protected TProperty[] MAJNEDEGEFH(TClass CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4080600", Offset = "0x407F600", VA = "0x184080600", Slot = "4")]
		public override void IPDECBGGCGL(MethodInfo JDABCDMOMDM, MethodInfo EHGLKEPOCEA, LEGLKABDOLM IKHOLAJCJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4084690", Offset = "0x4083690", VA = "0x184084690")]
		protected OMACFBNHOND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class KIFNCDMFIJD<TClass, TProperty> : OMACFBNHOND<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void NIDIPIBCNIP(IPAPMJFPALB HKCCAHKOPDN, [Out] TProperty PEMPPICHDJA);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void NGAJNNAHEMD(CHGEFENFMJB HCFPNEAOOMC, TProperty PEMPPICHDJA);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C23570", Offset = "0x3C22570", VA = "0x183C23570", Slot = "5")]
		public override void DIBLOGPPEBD(TClass CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C23480", Offset = "0x3C22480", VA = "0x183C23480", Slot = "6")]
		public override void CCBGBBLBEMM(TClass CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C23690", Offset = "0x3C22690", VA = "0x183C23690", Slot = "7")]
		public override void FEEBAELMOOP(TClass CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C23730", Offset = "0x3C22730", VA = "0x183C23730", Slot = "8")]
		public override void PDHGLKFDOFI(TClass CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3986FC0", Offset = "0x3985FC0", VA = "0x183986FC0")]
		protected KIFNCDMFIJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class BIODMEPLFMM<T> : OMACFBNHOND<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x47BA010", Offset = "0x47B9010", VA = "0x1847BA010", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4060070", Offset = "0x405F070", VA = "0x184060070", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x47BA080", Offset = "0x47B9080", VA = "0x1847BA080", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x332F780", Offset = "0x332E780", VA = "0x18332F780", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public BIODMEPLFMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OAFOBKBNOKL<T> : OMACFBNHOND<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x40600D0", Offset = "0x405F0D0", VA = "0x1840600D0", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4060070", Offset = "0x405F070", VA = "0x184060070", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4060140", Offset = "0x405F140", VA = "0x184060140", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x332F780", Offset = "0x332E780", VA = "0x18332F780", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public OAFOBKBNOKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class NBMADKDCMDP<T> : OMACFBNHOND<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FB20", Offset = "0x3F3EB20", VA = "0x183F3FB20", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FAC0", Offset = "0x3F3EAC0", VA = "0x183F3FAC0", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FB90", Offset = "0x3F3EB90", VA = "0x183F3FB90", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FC00", Offset = "0x3F3EC00", VA = "0x183F3FC00", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public NBMADKDCMDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OBFCHNHJEGD<T> : OMACFBNHOND<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4062A50", Offset = "0x4061A50", VA = "0x184062A50", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FAC0", Offset = "0x3F3EAC0", VA = "0x183F3FAC0", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4062AC0", Offset = "0x4061AC0", VA = "0x184062AC0", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3F3FC00", Offset = "0x3F3EC00", VA = "0x183F3FC00", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public OBFCHNHJEGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GHPEMKHCFIO<T> : OMACFBNHOND<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3758440", Offset = "0x3757440", VA = "0x183758440", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x37583E0", Offset = "0x37573E0", VA = "0x1837583E0", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x37584B0", Offset = "0x37574B0", VA = "0x1837584B0", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3758520", Offset = "0x3757520", VA = "0x183758520", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public GHPEMKHCFIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class MBLMNGHBEND<T> : OMACFBNHOND<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA6C0", Offset = "0x3EB96C0", VA = "0x183EBA6C0", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x37583E0", Offset = "0x37573E0", VA = "0x1837583E0", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA730", Offset = "0x3EB9730", VA = "0x183EBA730", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3758520", Offset = "0x3757520", VA = "0x183758520", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public MBLMNGHBEND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class HFBCKECJJME<T> : OMACFBNHOND<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x37C7760", Offset = "0x37C6760", VA = "0x1837C7760", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x37C7700", Offset = "0x37C6700", VA = "0x1837C7700", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x37C77D0", Offset = "0x37C67D0", VA = "0x1837C77D0", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x37C7840", Offset = "0x37C6840", VA = "0x1837C7840", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public HFBCKECJJME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HNMCHLDCIOF<T> : OMACFBNHOND<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x37C7760", Offset = "0x37C6760", VA = "0x1837C7760", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x37C7700", Offset = "0x37C6700", VA = "0x1837C7700", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x37EF880", Offset = "0x37EE880", VA = "0x1837EF880", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x37C7840", Offset = "0x37C6840", VA = "0x1837C7840", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public HNMCHLDCIOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class EODEDJIJNOK<T> : OMACFBNHOND<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x332F6A0", Offset = "0x332E6A0", VA = "0x18332F6A0", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x332F640", Offset = "0x332E640", VA = "0x18332F640", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x332F710", Offset = "0x332E710", VA = "0x18332F710", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x332F780", Offset = "0x332E780", VA = "0x18332F780", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public EODEDJIJNOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MCJGAFMHAKO<T> : OMACFBNHOND<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD670", Offset = "0x3EBC670", VA = "0x183EBD670", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD610", Offset = "0x3EBC610", VA = "0x183EBD610", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD6E0", Offset = "0x3EBC6E0", VA = "0x183EBD6E0", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3758520", Offset = "0x3757520", VA = "0x183758520", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public MCJGAFMHAKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class POHEFKAIHPN<T> : OMACFBNHOND<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x41645C0", Offset = "0x41635C0", VA = "0x1841645C0", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4164560", Offset = "0x4163560", VA = "0x184164560", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4164630", Offset = "0x4163630", VA = "0x184164630", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x37C7840", Offset = "0x37C6840", VA = "0x1837C7840", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x332F7E0", Offset = "0x332E7E0", VA = "0x18332F7E0")]
		public POHEFKAIHPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class DOGDMNEFHKG<T> : KIFNCDMFIJD<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x50EA4C0", Offset = "0x50E94C0", VA = "0x1850EA4C0", Slot = "12")]
		protected override void NGAJNNAHEMD(CHGEFENFMJB HCFPNEAOOMC, char PEMPPICHDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x50EA4F0", Offset = "0x50E94F0", VA = "0x1850EA4F0", Slot = "11")]
		protected override void NIDIPIBCNIP(IPAPMJFPALB HKCCAHKOPDN, [Out] char PEMPPICHDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x37C7E80", Offset = "0x37C6E80", VA = "0x1837C7E80")]
		public DOGDMNEFHKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OAAGCIBBCCE<T> : KIFNCDMFIJD<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x405FEC0", Offset = "0x405EEC0", VA = "0x18405FEC0", Slot = "12")]
		protected override void NGAJNNAHEMD(CHGEFENFMJB HCFPNEAOOMC, IPEndPoint PEMPPICHDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x405FEF0", Offset = "0x405EEF0", VA = "0x18405FEF0", Slot = "11")]
		protected override void NIDIPIBCNIP(IPAPMJFPALB HKCCAHKOPDN, [Out] IPEndPoint PEMPPICHDJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x37C7E80", Offset = "0x37C6E80", VA = "0x1837C7E80")]
		public OAAGCIBBCCE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class AIANHKIFCOE<T> : OMACFBNHOND<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int KIEKPNPJDLO;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x37A68C0", Offset = "0x37A58C0", VA = "0x1837A68C0")]
		public AIANHKIFCOE(int JKABMGFMNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x37A6770", Offset = "0x37A5770", VA = "0x1837A6770", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x37A6700", Offset = "0x37A5700", VA = "0x1837A6700", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x37A67E0", Offset = "0x37A57E0", VA = "0x1837A67E0", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x37A6850", Offset = "0x37A5850", VA = "0x1837A6850", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class LPMBPLALHNG<T> : AJOFEMPAJAH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo NPDLFNCFNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type JPCPCDIMEIA;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D420", Offset = "0x3D0C420", VA = "0x183D0D420")]
		public LPMBPLALHNG(PropertyInfo DFALMLPAKJC, Type HEILAMEINLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D1E0", Offset = "0x3D0C1E0", VA = "0x183D0D1E0", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D130", Offset = "0x3D0C130", VA = "0x183D0D130", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D2A0", Offset = "0x3D0C2A0", VA = "0x183D0D2A0", Slot = "7")]
		public override void FEEBAELMOOP(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D3C0", Offset = "0x3D0C3C0", VA = "0x183D0D3C0", Slot = "8")]
		public override void PDHGLKFDOFI(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D360", Offset = "0x3D0C360", VA = "0x183D0D360", Slot = "9")]
		public override void HAGDCIDDOIF(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D300", Offset = "0x3D0C300", VA = "0x183D0D300", Slot = "10")]
		public override void GLKLIGCEFOD(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KJIBEGLCNLN<T> : LPMBPLALHNG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3698290", Offset = "0x3697290", VA = "0x183698290")]
		public KJIBEGLCNLN(PropertyInfo DFALMLPAKJC, Type HEILAMEINLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C23CD0", Offset = "0x3C22CD0", VA = "0x183C23CD0", Slot = "5")]
		public override void DIBLOGPPEBD(T CMLNOGNAJBK, IPAPMJFPALB HKCCAHKOPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C23C20", Offset = "0x3C22C20", VA = "0x183C23C20", Slot = "6")]
		public override void CCBGBBLBEMM(T CMLNOGNAJBK, CHGEFENFMJB HCFPNEAOOMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class FAEHDABMGIM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static FAEHDABMGIM<T> GDAKEGIGEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly AJOFEMPAJAH<T>[] EPFOCOBHNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int ICHAADGEFCC;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x365D530", Offset = "0x365C530", VA = "0x18365D530")]
		public FAEHDABMGIM(List<AJOFEMPAJAH<T>> HIJAIDOJPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x365D3D0", Offset = "0x365C3D0", VA = "0x18365D3D0")]
		public void CCBGBBLBEMM(T FGOCJODIEMI, CHGEFENFMJB HKMKHKLNOHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x365D480", Offset = "0x365C480", VA = "0x18365D480")]
		public void DIBLOGPPEBD(T FGOCJODIEMI, IPAPMJFPALB PCOFGFPALLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class EPLCOOBKFCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract AJOFEMPAJAH<T> LNKEGHLMDOM<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private CHGEFENFMJB HBMDBOJKHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int GOMDHEJDDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, EPLCOOBKFCP> AONBDCEFDDD;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5628DD0", Offset = "0x5627DD0", VA = "0x185628DD0")]
	public NPKNPGKHEOK(int COALLBGPAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x28FC5A0", Offset = "0x28FB5A0", VA = "0x1828FC5A0")]
	private FAEHDABMGIM<T> JNIMJOALPGB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2585C50", Offset = "0x2584C50", VA = "0x182585C50")]
	public void PCEAKBMIBLF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x28FD490", Offset = "0x28FC490", VA = "0x1828FD490")]
	public bool MPIEPNPHGIA<T>(IPAPMJFPALB PCOFGFPALLL, T PGJBCOPPFBK) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x28FD510", Offset = "0x28FC510", VA = "0x1828FD510")]
	public void PAKOMNGHIKD<T>(CHGEFENFMJB HKMKHKLNOHE, T FGOCJODIEMI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MOMCICNDMMO
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime ONADEICJBJB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] NFMFMGCKPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FNHKAFFBKGG NKAFDJIDIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5624160", Offset = "0x5623160", VA = "0x185624160")]
		get
		{
			return default(FNHKAFFBKGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OMKGCMCLKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5623D80", Offset = "0x5622D80", VA = "0x185623D80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5623CB0", Offset = "0x5622CB0", VA = "0x185623CB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CLAGBHPAOKF JJKOGMAJPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5623970", Offset = "0x5622970", VA = "0x185623970")]
		get
		{
			return default(CLAGBHPAOKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5624390", Offset = "0x5623390", VA = "0x185624390")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int PADDELMKPPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5623940", Offset = "0x5622940", VA = "0x185623940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint KDICBANHHCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x56239A0", Offset = "0x56229A0", VA = "0x1856239A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? GLKHDKPCHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5623910", Offset = "0x5622910", VA = "0x185623910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? FFGACHALCCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5623ED0", Offset = "0x5622ED0", VA = "0x185623ED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? ANPEMPMNOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x56245A0", Offset = "0x56235A0", VA = "0x1856245A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5623AE0", Offset = "0x5622AE0", VA = "0x185623AE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? KECFEEJHMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAE3DA0", Offset = "0xAE2DA0", VA = "0x180AE3DA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x912750", Offset = "0x911750", VA = "0x180912750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x56246E0", Offset = "0x56236E0", VA = "0x1856246E0")]
	public MOMCICNDMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5624630", Offset = "0x5623630", VA = "0x185624630")]
	internal MOMCICNDMMO(byte[] EOMNNFHDHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5623DB0", Offset = "0x5622DB0", VA = "0x185623DB0")]
	public static MOMCICNDMMO JAFJBPGPLOK(byte[] EOMNNFHDHII, DateTime HIKJHCFNCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5623F60", Offset = "0x5622F60", VA = "0x185623F60")]
	internal void JPEJMBMOEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x56243D0", Offset = "0x56233D0", VA = "0x1856243D0")]
	private void NJMLMCHOFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5624190", Offset = "0x5623190", VA = "0x185624190")]
	private DateTime? KLDDJBJCHFB(int CNHEAECNOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5623740", Offset = "0x5622740", VA = "0x185623740")]
	private void AHICOPDCBPJ(int CNHEAECNOFO, DateTime? CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5623670", Offset = "0x5622670", VA = "0x185623670")]
	private ulong AGMMHIPANMM(int CNHEAECNOFO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5623A20", Offset = "0x5622A20", VA = "0x185623A20")]
	private void FMAGDJJJGNG(int CNHEAECNOFO, ulong CFJDHAGGAJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5623CF0", Offset = "0x5622CF0", VA = "0x185623CF0")]
	private uint HPPNELKOFNA(int CNHEAECNOFO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x54E89E0", Offset = "0x54E79E0", VA = "0x1854E89E0")]
	private static uint JKHFACJOMAB(uint GDALFMOOMGE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5623F00", Offset = "0x5622F00", VA = "0x185623F00")]
	private static ulong JKHFACJOMAB(ulong GDALFMOOMGE)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum FNHKAFFBKGG
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
public enum CLAGBHPAOKF
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ADCEOGCKNKN
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int MINHLNPDALK = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int GJBJBINFBIB = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int DCDJDNKIANC = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint MJHCJBCIKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int CHPAEIHAIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int GHOFEOMFOKN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EMFNFPMCJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5615600", Offset = "0x5614600", VA = "0x185615600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5615510", Offset = "0x5614510", VA = "0x185615510")]
	public bool EGPAKDDIGDD(LOLGDKAEKNE IDIGAOLCKNP, int CJLMIDOLMHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class FPDKPIMACKP : LOLGDKAEKNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket IDIGAOLCKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly DHAPFCCGMJE HMIIBOMCAAG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short OOHBMFCCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x561ED60", Offset = "0x561DD60", VA = "0x18561ED60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MPNGIFECCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x561ED40", Offset = "0x561DD40", VA = "0x18561ED40", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint BIPHKODLPON
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x561ED00", Offset = "0x561DD00", VA = "0x18561ED00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily BKPBNFBABFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD970", Offset = "0x3CBC970", VA = "0x183CBD970", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x561EE70", Offset = "0x561DE70", VA = "0x18561EE70")]
	public FPDKPIMACKP(AddressFamily OKLENFGENDD, DHAPFCCGMJE HMIIBOMCAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x561E700", Offset = "0x561D700", VA = "0x18561E700", Slot = "8")]
	public bool BADAGJNHMAL(IPEndPoint IOLKKJCLFNN, PCPKCGKODCG JFNEDGJKGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x561ECC0", Offset = "0x561DCC0", VA = "0x18561ECC0", Slot = "9")]
	public int DKNHKCDCAAL(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, int BEELDCKKFJL, IPEndPoint ENEEIADMAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x561ED80", Offset = "0x561DD80", VA = "0x18561ED80", Slot = "10")]
	public int OKNFFDCNPBK(byte[] EOOJCJAHOCJ, EndPoint AOHONGABEMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x561ED20", Offset = "0x561DD20", VA = "0x18561ED20", Slot = "11")]
	public void GLPECLACHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface LOLGDKAEKNE
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short OOHBMFCCGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int MPNGIFECCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint BIPHKODLPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily BKPBNFBABFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BADAGJNHMAL(IPEndPoint IOLKKJCLFNN, PCPKCGKODCG JFNEDGJKGOD);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DKNHKCDCAAL(byte[] EOOJCJAHOCJ, int CNHEAECNOFO, int BEELDCKKFJL, IPEndPoint ENEEIADMAHO);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OKNFFDCNPBK(byte[] EOOJCJAHOCJ, EndPoint ENEEIADMAHO);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLPECLACHLH();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct MFCCFFGDNJI : IEquatable<MFCCFFGDNJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long IANLFOCDEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long ECMJPOCLADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long GFCNDLICGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int GCOBNAFJHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int ENPKDHIGPHM;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5623010", Offset = "0x5622010", VA = "0x185623010")]
	public MFCCFFGDNJI(byte[] PFLPKLHGIOM, int ELBMMAHPLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7E3870", Offset = "0x7E2870", VA = "0x1807E3870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5622F20", Offset = "0x5621F20", VA = "0x185622F20", Slot = "4")]
	public bool Equals(MFCCFFGDNJI PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5622F60", Offset = "0x5621F60", VA = "0x185622F60", Slot = "0")]
	public override bool Equals(object FGOCJODIEMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class IGEJECJAGII : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] GCKCNJFPLMB;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class CNNHLBODLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int IJBJJGHIAIM;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF830", Offset = "0x7BE830", VA = "0x1807BF830")]
	protected CNNHLBODLNE(int OHKIJGKFKMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void CFGCJDAIMKE(IPEndPoint IOLKKJCLFNN, byte[] ELANMAGHLLI, int CNHEAECNOFO, int NAHHNFGPNAE);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void MKDPAKHMKBB(IPEndPoint IOLKKJCLFNN, byte[] ELANMAGHLLI, int CNHEAECNOFO, int NAHHNFGPNAE);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PNICKCJGLOB : CNNHLBODLNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider KCPLLKOBGKH;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator GIOLNPJJJOL;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x562B6A0", Offset = "0x562A6A0", VA = "0x18562B6A0")]
	public PNICKCJGLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x562B060", Offset = "0x562A060", VA = "0x18562B060")]
	public void IGJAMAJGANE(IPEndPoint IOLKKJCLFNN, byte[] IPAJBJLLPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x562AA60", Offset = "0x5629A60", VA = "0x18562AA60")]
	public void BJGLDEEIEBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x562AFD0", Offset = "0x5629FD0", VA = "0x18562AFD0")]
	private byte[] GJNFJGKFHJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x562AB40", Offset = "0x5629B40", VA = "0x18562AB40", Slot = "4")]
	public override void CFGCJDAIMKE(IPEndPoint IOLKKJCLFNN, byte[] ELANMAGHLLI, int CNHEAECNOFO, int NAHHNFGPNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x562B2A0", Offset = "0x562A2A0", VA = "0x18562B2A0", Slot = "5")]
	public override void MKDPAKHMKBB(IPEndPoint IOLKKJCLFNN, byte[] ELANMAGHLLI, int CNHEAECNOFO, int NAHHNFGPNAE)
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
