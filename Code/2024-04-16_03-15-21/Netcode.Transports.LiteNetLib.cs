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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NPPKDGDNEKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum LFOHIGDMGIB
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
		private NetworkManager IOICPMKOKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, GKGPEJPPAAF> LJJFKPCPKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GPOMCMHKDFP GCDOMLHABBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] DFACDNKKJCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LFOHIGDMGIB GGPIOBDFIDD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong JBFILELMFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B3610", Offset = "0x7B2810", VA = "0x1807B3610", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OAIDKHJLCFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x55D6F70", Offset = "0x55D6170", VA = "0x1855D6F70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x55D6420", Offset = "0x55D5620", VA = "0x1855D6420")]
		public void RecRoom_SetEncryptionInfo(ulong GAFJLAFNPMP, byte[] GHBNLDGJPCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x55D6400", Offset = "0x55D5600", VA = "0x1855D6400")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55D62D0", Offset = "0x55D54D0", VA = "0x1855D62D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55D6E70", Offset = "0x55D6070", VA = "0x1855D6E70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55D6620", Offset = "0x55D5820", VA = "0x1855D6620", Slot = "6")]
		public override void Send(ulong MMPLLKMIKJL, ArraySegment<byte> MJGHOBDIDHD, NetworkDelivery LNONMBJFHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55D63C0", Offset = "0x55D55C0", VA = "0x1855D63C0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong MMPLLKMIKJL, [Out] ArraySegment<byte> JAHJOCBHFCP, [Out] float HOHJMGECDPE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55D6910", Offset = "0x55D5B10", VA = "0x1855D6910", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x55D6D90", Offset = "0x55D5F90", VA = "0x1855D6D90", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55D5970", Offset = "0x55D4B70", VA = "0x1855D5970", Slot = "10")]
		public override void DisconnectRemoteClient(ulong MMPLLKMIKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x55D5820", Offset = "0x55D4A20", VA = "0x1855D5820", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x55D5CE0", Offset = "0x55D4EE0", VA = "0x1855D5CE0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong MMPLLKMIKJL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x55D68A0", Offset = "0x55D5AA0", VA = "0x1855D68A0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55D5DB0", Offset = "0x55D4FB0", VA = "0x1855D5DB0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager IOICPMKOKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x55D6180", Offset = "0x55D5380", VA = "0x1855D6180")]
		private POMFOCHJFPC NHDEAHJEOJP(NetworkDelivery MJMAEGDPBNJ)
		{
			return default(POMFOCHJFPC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55D5C20", Offset = "0x55D4E20", VA = "0x1855D5C20", Slot = "15")]
		private void ELOAEGACBCH(GKGPEJPPAAF KNGHABKDKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55D5AE0", Offset = "0x55D4CE0", VA = "0x1855D5AE0", Slot = "16")]
		private void EIFCDJMMOLI(GKGPEJPPAAF KNGHABKDKHL, EMDLPPFGFCM HNKCMEOKEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "17")]
		private void MAGHONGHOFP(IPEndPoint DLJPDHBCMKJ, SocketError JHOPPABOFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55D5F70", Offset = "0x55D5170", VA = "0x1855D5F70", Slot = "18")]
		private void LAADBOMHGKL(GKGPEJPPAAF KNGHABKDKHL, KPELIMPALJA GILMBCDEMDA, byte BGIPNBKNKOH, POMFOCHJFPC MAGELPNJNDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55D5740", Offset = "0x55D4940", VA = "0x1855D5740")]
		private void ACNLOHDJIFC(int ANCJPCFOHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "19")]
		private void CBHIKBDFKAO(IPEndPoint PLDGGNEJGHP, KPELIMPALJA GILMBCDEMDA, ILECPIHKBBE IKAGHPBODKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "20")]
		private void OEJJLDBGFPB(GKGPEJPPAAF KNGHABKDKHL, int PFBCLKBDGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55D6270", Offset = "0x55D5470", VA = "0x1855D6270", Slot = "21")]
		private void NPNMEFGFPOD(EHIGHKDCPJO NOGNLJBIFAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55D5D80", Offset = "0x55D4F80", VA = "0x1855D5D80")]
		private ulong IKJNGJACEOD(GKGPEJPPAAF KNGHABKDKHL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55D6250", Offset = "0x55D5450", VA = "0x1855D6250")]
		private static int NNJGLMADGCI(float AJKELOHAHIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55D6E90", Offset = "0x55D6090", VA = "0x1855D6E90")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class HEPDOGBFAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly GKGPEJPPAAF KILPEPCOOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<LPKFGDCBEEN> CBMJAHPNLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int CGAKPMCGNBJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55D2500", Offset = "0x55D1700", VA = "0x1855D2500")]
	protected HEPDOGBFAOG(GKGPEJPPAAF KNGHABKDKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55D2420", Offset = "0x55D1620", VA = "0x1855D2420")]
	public void EHAHAEMFENH(LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55D2480", Offset = "0x55D1680", VA = "0x1855D2480")]
	protected void OKHLAOJCKJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55D23E0", Offset = "0x55D15E0", VA = "0x1855D23E0")]
	public bool BILDBHEIGML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool AONGMMIOAOP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool MPGNIHJCCIG(LPKFGDCBEEN DOHFDINFONM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CHBLJAHDFIA
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
public class EHIGHKDCPJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GPOMCMHKDFP HEGFHGGMKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int AOJFHKNDIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal IKCBCCLANNF GLGLGGALFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint NLBHIKJCFJG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CHBLJAHDFIA BNDDHIDLONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7DCC60", Offset = "0x7DBE60", VA = "0x1807DCC60")]
		[CompilerGenerated]
		get
		{
			return default(CHBLJAHDFIA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x95D900", Offset = "0x95CB00", VA = "0x18095D900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x55C68B0", Offset = "0x55C5AB0", VA = "0x1855C68B0")]
	internal void FCCPPLFMNJC(IKCBCCLANNF MNODGDKMBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55C6970", Offset = "0x55C5B70", VA = "0x1855C6970")]
	private bool MANHPIKDDDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55C69A0", Offset = "0x55C5BA0", VA = "0x1855C69A0")]
	internal EHIGHKDCPJO(IPEndPoint PLDGGNEJGHP, IKCBCCLANNF IEDHBPOEGAK, GPOMCMHKDFP NABAFNOEEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x55C6910", Offset = "0x55C5B10", VA = "0x1855C6910")]
	public GKGPEJPPAAF KCMLIPPEDCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ILECPIHKBBE
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum AHKPGGFNPHM
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
public struct EMDLPPFGFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public AHKPGGFNPHM DADDDJHFJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PEBKJDAGBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public KPELIMPALJA KPBKIAMLMIK;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NPPKDGDNEKI
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHKFJHADDEH(GKGPEJPPAAF KNGHABKDKHL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNLHINFKFED(GKGPEJPPAAF KNGHABKDKHL, EMDLPPFGFCM HNKCMEOKEFK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KAIOAJKIDDE(IPEndPoint DLJPDHBCMKJ, SocketError JHOPPABOFDK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIPJPHHIGIB(GKGPEJPPAAF KNGHABKDKHL, KPELIMPALJA GILMBCDEMDA, byte BGIPNBKNKOH, POMFOCHJFPC MAGELPNJNDO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBNOKEAKBPB(IPEndPoint PLDGGNEJGHP, KPELIMPALJA GILMBCDEMDA, ILECPIHKBBE IKAGHPBODKD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IKHLGNCDMAF(GKGPEJPPAAF KNGHABKDKHL, int PFBCLKBDGJL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPDMJNENDMA(EHIGHKDCPJO NOGNLJBIFAF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CAOJPPLABMP
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGJEFHHJHBE(GKGPEJPPAAF KNGHABKDKHL, object BGOGLKENJDE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HOBCJHCLMBK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBDGFKPBKJJ(PFKLKHOHIPO DOHFDINFONM);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IBPILMIICLP
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENAMCCJGNNP(GKGPEJPPAAF KNGHABKDKHL, IPEndPoint OGFFFGMDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class IKCBCCLANNF
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int FJACPOIMHGH = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long DCIEEHJKGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte IBNBCBDFHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] GCKFAMGOCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly NOBKPDKKLHH FHDMPGOGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int HHIJLLCOIJG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55D2DF0", Offset = "0x55D1FF0", VA = "0x1855D2DF0")]
	private IKCBCCLANNF(long KAMEIFGJKEF, byte FAHBMBMHPCK, int NAJMDMAIPJN, byte[] LICLHEEOEAB, NOBKPDKKLHH MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55D2B70", Offset = "0x55D1D70", VA = "0x1855D2B70")]
	public static int DMNOPOFAGCM(LPKFGDCBEEN DOHFDINFONM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x55D2BD0", Offset = "0x55D1DD0", VA = "0x1855D2BD0")]
	public static IKCBCCLANNF FDDPBBKLGGC(LPKFGDCBEEN DOHFDINFONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55D2990", Offset = "0x55D1B90", VA = "0x1855D2990")]
	public static LPKFGDCBEEN CFFDDDHEILM(KMMOMOFICIF APIKKOEOLAI, SocketAddress FANMDHAAIGP, long CMOOPGCDNDG, int NAJMDMAIPJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class DLHJOBILMJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long DCIEEHJKGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte IBNBCBDFHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int HHIJLLCOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool DHOINCGIALO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55C57C0", Offset = "0x55C49C0", VA = "0x1855C57C0")]
	private DLHJOBILMJB(long KAMEIFGJKEF, byte FAHBMBMHPCK, int GPCGMJGACDB, bool CBLJNKHNLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55C5570", Offset = "0x55C4770", VA = "0x1855C5570")]
	public static DLHJOBILMJB FDDPBBKLGGC(LPKFGDCBEEN DOHFDINFONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55C5480", Offset = "0x55C4680", VA = "0x1855C5480")]
	public static LPKFGDCBEEN CFFDDDHEILM(long CMOOPGCDNDG, byte JBHDMOMIIDF, int AMEELAIDINI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55C56C0", Offset = "0x55C48C0", VA = "0x1855C56C0")]
	public static LPKFGDCBEEN JDLOEAGNJDD(GKGPEJPPAAF KNGHABKDKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DNPGPDJCKLF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CHAKFFEOKMD
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APBAGINBOCE(IPEndPoint KANMIINOJOJ, IPEndPoint PLDGGNEJGHP, string GMMJMENGHCD);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANADNOBEMFH(IPEndPoint PBGNCKDGIIA, DNPGPDJCKLF MJMAEGDPBNJ, string GMMJMENGHCD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PIGNMJMODDF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct KIGKPMPNHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint FGLDDNKEMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint NLBHIKJCFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string LODBFGJKKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct AEALBIJGJPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint DBOAGEKIMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DNPGPDJCKLF MEBDELDBDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string LODBFGJKKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class BFKKEDJHFLK
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint NFNEJNPGLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LODBFGJKKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public BFKKEDJHFLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class PIBOHDELGIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint NFNEJNPGLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint OHLNBMKMGMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LODBFGJKKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public PIBOHDELGIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class AAIOMCPJCLP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LODBFGJKKPN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DPGLDLMHCIE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82DA00", Offset = "0x82CC00", VA = "0x18082DA00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BA590", Offset = "0x7B9790", VA = "0x1807BA590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public AAIOMCPJCLP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GPOMCMHKDFP JFJCAJBLJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<KIGKPMPNHHC> CIMKLEKAPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<AEALBIJGJPI> KPDGIKKHCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly NOBKPDKKLHH IIJCKAOIFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly KMMOMOFICIF FGPIJNFEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ABNJFAHGHPO KGJCAGIDLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private CHAKFFEOKMD GHAHNOJNCJN;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LNNINMLLDPA = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool EICGALCDPIO;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x55D9C20", Offset = "0x55D8E20", VA = "0x1855D9C20")]
	internal PIGNMJMODDF(GPOMCMHKDFP HHMDDEODCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x55D9AC0", Offset = "0x55D8CC0", VA = "0x1855D9AC0")]
	internal void LADFAHAECJE(IPEndPoint MBHLLGDNAOG, LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A11070", Offset = "0x2A10270", VA = "0x182A11070")]
	private void LCJAGJPKCMA<T>(T DOHFDINFONM, IPEndPoint JGFCAMDGBLE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x55D9640", Offset = "0x55D8840", VA = "0x1855D9640")]
	private void APBAGINBOCE(BFKKEDJHFLK KEFIHCPMJKI, IPEndPoint MBHLLGDNAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x55D9960", Offset = "0x55D8B60", VA = "0x1855D9960")]
	private void GCKMEKHFFHP(PIBOHDELGIA KEFIHCPMJKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55D97D0", Offset = "0x55D89D0", VA = "0x1855D97D0")]
	private void FMDIEJNIEDF(AAIOMCPJCLP KEFIHCPMJKI, IPEndPoint MBHLLGDNAOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum POMFOCHJFPC : byte
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
public enum KIEMAAIIEOK : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NBDONIMHEIK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] PNHONPCJDDI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int JCLDNCBOGGP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HMOJJACMMAL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CLGIKCFINEF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55C5190", Offset = "0x55C4390", VA = "0x1855C5190")]
	public CLGIKCFINEF(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NBNGELNGIFN : CLGIKCFINEF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x55C5190", Offset = "0x55C4390", VA = "0x1855C5190")]
	public NBNGELNGIFN(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KNPDDFHPGGC
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
public interface EIGNNJJEMMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCEOKJOHAFM(KNPDDFHPGGC NNFJCCCGKCE, string DMCHJABNPHL, params object[] FJIDAJDLPID);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HGAKDPDCBNO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static EIGNNJJEMMJ IKPJPNOOGMM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object MLKDBJHOOCG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55D2600", Offset = "0x55D1800", VA = "0x1855D2600")]
	private static void FOIHJOAOFKG(KNPDDFHPGGC JPBEKNKBONH, string DMCHJABNPHL, params object[] FJIDAJDLPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55D2820", Offset = "0x55D1A20", VA = "0x1855D2820")]
	internal static void LKPEOFJBLDA(string DMCHJABNPHL, params object[] FJIDAJDLPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55D2880", Offset = "0x55D1A80", VA = "0x1855D2880")]
	internal static void PHPMLIOAING(string DMCHJABNPHL, params object[] FJIDAJDLPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55D25A0", Offset = "0x55D17A0", VA = "0x1855D25A0")]
	internal static void CBHBCAIBKNJ(string DMCHJABNPHL, params object[] FJIDAJDLPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LCCFPJJAEBC
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KPELIMPALJA : NOBKPDKKLHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private LPKFGDCBEEN PKCGHOPLELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GPOMCMHKDFP JKOAEHKIABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly MOPKIPDBIMJ GGHMLBIPHAN;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55D4A10", Offset = "0x55D3C10", VA = "0x1855D4A10")]
	internal KPELIMPALJA(GPOMCMHKDFP JPFNBECBJPL, MOPKIPDBIMJ HLKLIGEDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x55D4920", Offset = "0x55D3B20", VA = "0x1855D4920")]
	internal void INNBIKLINGK(LPKFGDCBEEN DOHFDINFONM, int JCOEHENCDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55D4990", Offset = "0x55D3B90", VA = "0x1855D4990")]
	internal void PGCEBECEOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55D48F0", Offset = "0x55D3AF0", VA = "0x1855D48F0")]
	public void FLLODDJKEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class MOPKIPDBIMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum IPMGAGCDODE
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
	public MOPKIPDBIMJ CECLBNHPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public IPMGAGCDODE MEBDELDBDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public GKGPEJPPAAF KILPEPCOOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint NLBHIKJCFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object GNEMNPLCEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int KBOGENMJNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError BJFAPCNEINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public AHKPGGFNPHM NCNKGPNNDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public EHIGHKDCPJO PPCABIILBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public POMFOCHJFPC GGEAHNKFOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte DAHKMCLKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly KPELIMPALJA KAPFNCNDKFD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55D6F90", Offset = "0x55D6190", VA = "0x1855D6F90")]
	public MOPKIPDBIMJ(GPOMCMHKDFP JPFNBECBJPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GPOMCMHKDFP : IEnumerable<GKGPEJPPAAF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class EJANDINLCDL : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x55C6A10", Offset = "0x55C5C10", VA = "0x1855C6A10", Slot = "4")]
		public bool Equals(IPEndPoint EFCGILCAOIA, IPEndPoint DDIIOJEJOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x50B5CA0", Offset = "0x50B4EA0", VA = "0x1850B5CA0", Slot = "5")]
		public int GetHashCode(IPEndPoint GLMGCMELGFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public EJANDINLCDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct BBJNMKNACKP : IEnumerator<GKGPEJPPAAF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly GKGPEJPPAAF JKJGDHHOCDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private GKGPEJPPAAF KMJFIJJBCPB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public GKGPEJPPAAF KOOHOOFHLKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8FFBE0", Offset = "0x8FEDE0", VA = "0x1808FFBE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FFBE0", Offset = "0x8FEDE0", VA = "0x1808FFBE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF6F040", Offset = "0xF6E240", VA = "0x180F6F040")]
		public BBJNMKNACKP(GKGPEJPPAAF HIFBGLLPLPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x55C42B0", Offset = "0x55C34B0", VA = "0x1855C42B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55C4300", Offset = "0x55C3500", VA = "0x1855C4300", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread CPLADMONELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool DFHKODODEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent HJGCBJMKOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<MOPKIPDBIMJ> LNCGDHOIPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<MOPKIPDBIMJ> FBMNKPOPFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private MOPKIPDBIMJ IDKDEPFJAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NPPKDGDNEKI JJPAMLHOMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CAOJPPLABMP ODFMNJOEKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly HOBCJHCLMBK FAICABACBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly IBPILMIICLP GFFBENHKHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, GKGPEJPPAAF> DPLFNKEJEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, EHIGHKDCPJO> MIGMFGDKEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, LFDHALFAHFL> NOLDLPFFAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim KPIACFEBNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GKGPEJPPAAF IGKGIBLKIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GFHEPNFAGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<GKGPEJPPAAF> EFHGKPDCAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private GKGPEJPPAAF[] KBNADLNMLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MIEPKCLICMM PIBFLAACDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int FKOGNPNDKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> GPBGMLNGLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte BFMLCEEPHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object BNDGMAAKFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool JCIPIMBLCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool BCGKIJDEBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int AFCPLNEFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MALMADGNGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OOEEIAEMLKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int PNIJGLOMIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool EFMGPLLHOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NCPLCJEPCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int BKFOJCOJJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int ONLDJKCKFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int OJGCJACFBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EICGALCDPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool BBOIMPLENOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KEGILGONFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool FDIHCFLHNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int MLDHLLFJEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int IJJLOPMCFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool BGBICBPMAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly CFFAOIFLCKJ ILBGGFINNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool FINCCJCOMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly PIGNMJMODDF ADBBCKLNHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool OHMGKKMJCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LCCFPJJAEBC ALGLFFCNPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int PNDCNAPDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool LNMPKJLCPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool CNIMIJMFBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OCKACGICBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool OIAGNKPFIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private LPKFGDCBEEN AHJGMDKNCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int MFDOKLMMMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object EBMGJHHBFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private LPKFGDCBEEN GFFBICHIGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MJJKBAAPCDB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int KNBGNNKABMK = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int AMKJLHICPJE = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private ONDLAEHFCPD HIOPCNPKJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ONDLAEHFCPD MKKDPAOPBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread HINCJPDCHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread ECDJNFDMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint HAHBCOGFPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint PGIGPJCHHFH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] ADCEAPPNBMM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] AJOLHHNIFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<DGMKNLFGMOC, IPEndPoint> DOCLELGCAKE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress DKLBFHDODAF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool BBKABKEIKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int GFLADGLLCEL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OEPBMKHAMPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B480", Offset = "0xA5A680", VA = "0x180A5B480")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB246B0", Offset = "0xB238B0", VA = "0x180B246B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LPMKDPABGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x13213F0", Offset = "0x13205F0", VA = "0x1813213F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1636170", Offset = "0x1635370", VA = "0x181636170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte DGAOHLJDAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CACA0", Offset = "0x8C9EA0", VA = "0x1808CACA0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KOJFLBJBAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55CF570", Offset = "0x55CE770", VA = "0x1855CF570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short INKPONNHLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x55CF8F0", Offset = "0x55CEAF0", VA = "0x1855CF8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55CBA80", Offset = "0x55CAC80", VA = "0x1855CBA80")]
	public void BKGBAPIIHIL(IPEndPoint DLJPDHBCMKJ, byte[] GHBNLDGJPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55D0F00", Offset = "0x55D0100", VA = "0x1855D0F00")]
	public void NHNNJCNEOAI(IPEndPoint DLJPDHBCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55CFD00", Offset = "0x55CEF00", VA = "0x1855CFD00")]
	private bool KEABEIFOHDJ(IPEndPoint DLJPDHBCMKJ, [Out] GKGPEJPPAAF KNGHABKDKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55CF2B0", Offset = "0x55CE4B0", VA = "0x1855CF2B0")]
	private void HIKCJKBAPAG(GKGPEJPPAAF KNGHABKDKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55CFD90", Offset = "0x55CEF90", VA = "0x1855CFD90")]
	private void KFKPNLIHIFN(GKGPEJPPAAF KNGHABKDKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55D1050", Offset = "0x55D0250", VA = "0x1855D1050")]
	private void OGCJMLELGPD(GKGPEJPPAAF KNGHABKDKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55D1D90", Offset = "0x55D0F90", VA = "0x1855D1D90")]
	public GPOMCMHKDFP(NPPKDGDNEKI NABAFNOEEAM, [Optional] MIEPKCLICMM BNEGCOIADGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55CBA30", Offset = "0x55CAC30", VA = "0x1855CBA30")]
	internal void BADBDICCNFG(GKGPEJPPAAF HOLIJOMGFGA, int PFBCLKBDGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55CBEE0", Offset = "0x55CB0E0", VA = "0x1855CBEE0")]
	internal void CPLPFEAJFIF(GKGPEJPPAAF HOLIJOMGFGA, object BGOGLKENJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55D0C90", Offset = "0x55CFE90", VA = "0x1855D0C90")]
	internal void MFLGFMGHHKH(GKGPEJPPAAF KNGHABKDKHL, AHKPGGFNPHM LPMJIGEBKFN, SocketError OAALKMCKBPD, LPKFGDCBEEN NEMGAFJFCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55CFA60", Offset = "0x55CEC60", VA = "0x1855CFA60")]
	private void JHFENPMKCNI(GKGPEJPPAAF KNGHABKDKHL, AHKPGGFNPHM LPMJIGEBKFN, SocketError OAALKMCKBPD, bool HLOIBGCELIK, byte[] MJGHOBDIDHD, int GGLMJACONBL, int KMJOEPJMADC, LPKFGDCBEEN NEMGAFJFCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55CBB20", Offset = "0x55CAD20", VA = "0x1855CBB20")]
	private void CCLPMMDFNNP(MOPKIPDBIMJ.IPMGAGCDODE MJMAEGDPBNJ, [Optional] GKGPEJPPAAF KNGHABKDKHL, [Optional] IPEndPoint PLDGGNEJGHP, SocketError JGDMEIBELAK = SocketError.Success, int PFBCLKBDGJL = 0, AHKPGGFNPHM FHIJMIOLBAO = AHKPGGFNPHM.ConnectionFailed, [Optional] EHIGHKDCPJO IOJNJKBBJCN, POMFOCHJFPC MAGELPNJNDO = POMFOCHJFPC.Unreliable, byte BGIPNBKNKOH = 0, [Optional] LPKFGDCBEEN PFHNMBPKNIC, [Optional] object BGOGLKENJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55CD100", Offset = "0x55CC300", VA = "0x1855CD100")]
	private void EELOLKHIMBH(MOPKIPDBIMJ HLKLIGEDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55CFC00", Offset = "0x55CEE00", VA = "0x1855CFC00")]
	internal void JLDIJPBEJEL(MOPKIPDBIMJ HLKLIGEDCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55D0950", Offset = "0x55CFB50", VA = "0x1855D0950")]
	private void MDMMDMHJFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55CEAD0", Offset = "0x55CDCD0", VA = "0x1855CEAD0")]
	private void GALKCLPLBFN(int DLHELMONHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55CFF50", Offset = "0x55CF150", VA = "0x1855CFF50")]
	internal GKGPEJPPAAF KKMILLHKFHA(EHIGHKDCPJO NOGNLJBIFAF, byte[] MHMJPPMNKLN, int GGLMJACONBL, int EAMNBPDOIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55CE890", Offset = "0x55CDA90", VA = "0x1855CE890")]
	private int FKLPODNFJIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55CEDF0", Offset = "0x55CDFF0", VA = "0x1855CEDF0")]
	private void GNACPOOFLGJ(IPEndPoint PLDGGNEJGHP, GKGPEJPPAAF MNJOCJAJLFF, IKCBCCLANNF HJJGAODCODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55CBF30", Offset = "0x55CB130", VA = "0x1855CBF30")]
	private void DEIJALKOAEP(LPKFGDCBEEN DOHFDINFONM, IPEndPoint PLDGGNEJGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55CE5D0", Offset = "0x55CD7D0", VA = "0x1855CE5D0")]
	internal void FJALPCLAENF(LPKFGDCBEEN DOHFDINFONM, POMFOCHJFPC MGEGKLPMAHA, byte BGIPNBKNKOH, int JCOEHENCDBO, GKGPEJPPAAF HOLIJOMGFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55CDA60", Offset = "0x55CCC60", VA = "0x1855CDA60")]
	public bool EOFOFFHJEOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55CDA40", Offset = "0x55CCC40", VA = "0x1855CDA40")]
	public bool EOFOFFHJEOJ(IPAddress OLIOMLNIJIG, IPAddress AGLNCPGJMDD, int PFKMNBCMKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55CDAD0", Offset = "0x55CCCD0", VA = "0x1855CDAD0")]
	public bool EOFOFFHJEOJ(int PFKMNBCMKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55CD8A0", Offset = "0x55CCAA0", VA = "0x1855CD8A0")]
	public void EEPGLNALIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x55D12A0", Offset = "0x55D04A0", VA = "0x1855D12A0")]
	public GKGPEJPPAAF PGGCGLFEBBH(string PCLIJINNNLM, int PFKMNBCMKBC, string GHBNLDGJPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x55D1750", Offset = "0x55D0950", VA = "0x1855D1750")]
	public GKGPEJPPAAF PGGCGLFEBBH(string PCLIJINNNLM, int PFKMNBCMKBC, KMMOMOFICIF LGJIMKIBJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x55D1380", Offset = "0x55D0580", VA = "0x1855D1380")]
	public GKGPEJPPAAF PGGCGLFEBBH(IPEndPoint JGFCAMDGBLE, KMMOMOFICIF LGJIMKIBJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x55CF590", Offset = "0x55CE790", VA = "0x1855CF590")]
	public void IHPCHMBALAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x55CF5A0", Offset = "0x55CE7A0", VA = "0x1855CF5A0")]
	public void IHPCHMBALAP(bool CCFIKFGOBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55D0560", Offset = "0x55CF760", VA = "0x1855D0560")]
	public void LECNKFPAANJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x55D0660", Offset = "0x55CF860", VA = "0x1855D0660")]
	public void LECNKFPAANJ(byte[] MJGHOBDIDHD, int GGLMJACONBL, int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x55CF9B0", Offset = "0x55CEBB0", VA = "0x1855CF9B0")]
	public void JHFENPMKCNI(GKGPEJPPAAF KNGHABKDKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x55CFB40", Offset = "0x55CED40", VA = "0x1855CFB40")]
	public void JHFENPMKCNI(GKGPEJPPAAF KNGHABKDKHL, byte[] MJGHOBDIDHD, int GGLMJACONBL, int KMJOEPJMADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55D1BB0", Offset = "0x55D0DB0", VA = "0x1855D1BB0", Slot = "4")]
	private IEnumerator<GKGPEJPPAAF> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55D1C40", Offset = "0x55D0E40", VA = "0x1855D1C40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x55CE9F0", Offset = "0x55CDBF0", VA = "0x1855CE9F0")]
	private LPKFGDCBEEN FOKHINBNAGF(DFGJBKOGFDK BMIMCNPMKAE, int ANCJPCFOHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55CE910", Offset = "0x55CDB10", VA = "0x1855CE910")]
	private LPKFGDCBEEN FOKHINBNAGF(DFGJBKOGFDK BMIMCNPMKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55CCC80", Offset = "0x55CBE80", VA = "0x1855CCC80")]
	internal LPKFGDCBEEN EBGFHCAGBLL(int ANCJPCFOHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55CCEB0", Offset = "0x55CC0B0", VA = "0x1855CCEB0")]
	internal void EECBOKBFHHM(LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55D1CD0", Offset = "0x55D0ED0", VA = "0x1855D1CD0")]
	static GPOMCMHKDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA5B480", Offset = "0xA5A680", VA = "0x180A5B480")]
	private bool MOOOKMKIDMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55D0860", Offset = "0x55CFA60", VA = "0x1855D0860")]
	private void LMMDEHFIMGO(IPEndPoint ALEMAOIPIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55D0780", Offset = "0x55CF980", VA = "0x1855D0780")]
	private void LHAAIDAFELO(IPEndPoint ALEMAOIPIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55D0D60", Offset = "0x55CFF60", VA = "0x1855D0D60")]
	private bool NCFKGMABHAK(SocketException ABPIAOIFKLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55CE300", Offset = "0x55CD500", VA = "0x1855CE300")]
	private void FGBBGADMHBP(ONDLAEHFCPD HHMDDEODCKM, EndPoint ALBCHFGKEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55D1830", Offset = "0x55D0A30", VA = "0x1855D1830")]
	private void PPCGFGKHHMJ(object GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x55CDB50", Offset = "0x55CCD50", VA = "0x1855CDB50")]
	public bool EOFOFFHJEOJ(IPAddress OLIOMLNIJIG, IPAddress AGLNCPGJMDD, int PFKMNBCMKBC, bool CDOMJOHKAEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55CF250", Offset = "0x55CE450", VA = "0x1855CF250")]
	internal int HHGMDAHGPPC(LPKFGDCBEEN DOHFDINFONM, IPEndPoint PLDGGNEJGHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x55CB9F0", Offset = "0x55CABF0", VA = "0x1855CB9F0")]
	internal int ABMNNMNMIPI(LPKFGDCBEEN DOHFDINFONM, IPEndPoint PLDGGNEJGHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x55CB430", Offset = "0x55CA630", VA = "0x1855CB430")]
	internal int ABMNNMNMIPI(byte[] FFDOAJJEAOK, int GGLMJACONBL, int EAMNBPDOIFO, IPEndPoint PLDGGNEJGHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x55CFDE0", Offset = "0x55CEFE0", VA = "0x1855CFDE0")]
	internal void KHJAFLHOEPI(bool DMPIHEGOOLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum DFGJBKOGFDK : byte
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
internal sealed class LPKFGDCBEEN
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int ABGEMANNHMC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] KNFBPINAJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] MJFCAKICACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int ODOBGAEOPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object GNEMNPLCEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public LPKFGDCBEEN CECLBNHPHAI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DFGJBKOGFDK EDBLDHKGHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55D4EA0", Offset = "0x55D40A0", VA = "0x1855D4EA0")]
		get
		{
			return default(DFGJBKOGFDK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x55D5140", Offset = "0x55D4340", VA = "0x1855D5140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte IBNBCBDFHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55D4F30", Offset = "0x55D4130", VA = "0x1855D4F30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55D51C0", Offset = "0x55D43C0", VA = "0x1855D51C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort OILOBEBHDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x55D5000", Offset = "0x55D4200", VA = "0x1855D5000")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x55D5180", Offset = "0x55D4380", VA = "0x1855D5180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CCPLOONDFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55D4CE0", Offset = "0x55D3EE0", VA = "0x1855D4CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte ECBKCBMCBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x55D4F00", Offset = "0x55D4100", VA = "0x1855D4F00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55D4E70", Offset = "0x55D4070", VA = "0x1855D4E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort GDEEJDAGGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x55D4F60", Offset = "0x55D4160", VA = "0x1855D4F60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55D5100", Offset = "0x55D4300", VA = "0x1855D5100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort EJGNMKOBOOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55D5060", Offset = "0x55D4260", VA = "0x1855D5060")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x55D4FC0", Offset = "0x55D41C0", VA = "0x1855D4FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort IKMKECMLHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x55D4D10", Offset = "0x55D3F10", VA = "0x1855D4D10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x55D50C0", Offset = "0x55D42C0", VA = "0x1855D50C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x55D5300", Offset = "0x55D4500", VA = "0x1855D5300")]
	static LPKFGDCBEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55D4ED0", Offset = "0x55D40D0", VA = "0x1855D4ED0")]
	public void HPNCLFMKBBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x55D55C0", Offset = "0x55D47C0", VA = "0x1855D55C0")]
	public LPKFGDCBEEN(int ANCJPCFOHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x55D5630", Offset = "0x55D4830", VA = "0x1855D5630")]
	public LPKFGDCBEEN(DFGJBKOGFDK BMIMCNPMKAE, int ANCJPCFOHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x55D5200", Offset = "0x55D4400", VA = "0x1855D5200")]
	public static int PPAOKCIHBOM(DFGJBKOGFDK BMIMCNPMKAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x55D5270", Offset = "0x55D4470", VA = "0x1855D5270")]
	public int PPAOKCIHBOM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55D4D70", Offset = "0x55D3F70", VA = "0x1855D4D70")]
	public bool ECONBCEHBDF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum GGOGABMGOOG : byte
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
internal enum LNNNIGMFHBL
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
internal enum FBHFIKDFLIP
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum OIIPPNEJIBK
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GKGPEJPPAAF
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class IHGBGAFLADN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LPKFGDCBEEN[] CKMFEPAFCJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int JPIEAMAPEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int GIJOAOAEBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte ECBKCBMCBCL;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public IHGBGAFLADN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void NDOLLDIIHEN(ulong NLLKHOHFJDL, int ADMKGPNBDHO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CKHCAMFMAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int MAJANHLPJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int LIGAHNEJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double PNFOBFIBFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int IPPODDPHCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int GDLKPNEECGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int OFFCLBPKJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch IHFJNEDELCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HFINNKBKBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PGLLPJLDBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object EHBMPFKNGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal GKGPEJPPAAF MEPNBHAHACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal GKGPEJPPAAF FGACKBCOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<LPKFGDCBEEN> OLLOCDHKHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<HEPDOGBFAOG> AKGIEMEGIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly HEPDOGBFAOG[] AKCCFLDOKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int JLDNGKEIGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int JDBNIBDCEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool AFDKIOOIADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int OOEFNPPOIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int DKHMAJLBPDH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int JFBNADGGELC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int HFEIILAOBHD = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object HCJAADOBAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int EDGAMBLLDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, IHGBGAFLADN> JKJOGOMIIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BNLFEFEGAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly LPKFGDCBEEN MDKCCLFIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int JIHACIJEBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int LMFEMCHHLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint NIOKBLOPCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int JECHKBEILLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int MHEOEAIECHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long IKOJMIIPMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte JKMLFLDCNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GGOGABMGOOG LBAAJHABHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private LPKFGDCBEEN MPJKOPDOKFE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int PCDIMHGNEEP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int IJIADHFAPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly LPKFGDCBEEN AEOPHEHCHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly LPKFGDCBEEN JNAJPKKJGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly LPKFGDCBEEN HFPEAEOKINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly LPKFGDCBEEN CENAJFKMHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KIEMAAIIEOK HKILLOMDCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly GPOMCMHKDFP MKGHKNGCOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int PAIBFKFLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object FDNJENHLPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly CFFAOIFLCKJ ILBGGFINNHC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte ODBAMNOGGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA99930", Offset = "0xA98B30", VA = "0x180A99930")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55C8320", Offset = "0x55C7520", VA = "0x1855C8320")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint CCDGHJKDADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D4910", Offset = "0x8D3B10", VA = "0x1808D4910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GGOGABMGOOG KBIHFGAOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x16525E0", Offset = "0x16517E0", VA = "0x1816525E0")]
		get
		{
			return default(GGOGABMGOOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long INGDBMDCKID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BB050", Offset = "0x7BA250", VA = "0x1807BB050")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PLDIKANKJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB679C0", Offset = "0xB66BC0", VA = "0x180B679C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1467D00", Offset = "0x1466F00", VA = "0x181467D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PFBBELJLGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x55C85D0", Offset = "0x55C77D0", VA = "0x1855C85D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EPGKDCJGMDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F50", Offset = "0x7C3150", VA = "0x1807C3F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double HMAGAJAMJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1865420", Offset = "0x1864620", VA = "0x181865420")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NDOLLDIIHEN PCJHLJMBBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x55C85E0", Offset = "0x55C77E0", VA = "0x1855C85E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x55C7770", Offset = "0x55C6970", VA = "0x1855C7770")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55CAFE0", Offset = "0x55CA1E0", VA = "0x1855CAFE0")]
	internal GKGPEJPPAAF(GPOMCMHKDFP FHLBACEFGOE, IPEndPoint PLDGGNEJGHP, int POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55CA620", Offset = "0x55C9820", VA = "0x1855CA620")]
	internal void OBBKJIHOEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55CAC40", Offset = "0x55C9E40", VA = "0x1855CAC40")]
	internal void OOIPMNAAGGM(IPEndPoint MDKFGHLKJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55C7860", Offset = "0x55C6A60", VA = "0x1855C7860")]
	internal void BACANOHPNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55C90A0", Offset = "0x55C82A0", VA = "0x1855C90A0")]
	private void KPPBOHNMCPL(int GEIAKLDDLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55C7820", Offset = "0x55C6A20", VA = "0x1855C7820")]
	private void ANPBKLMJNKL(int IBOCNJMCOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55C78F0", Offset = "0x55C6AF0", VA = "0x1855C78F0")]
	private HEPDOGBFAOG BBHEKAAHJCI(byte NMHNBICEFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55CAE50", Offset = "0x55CA050", VA = "0x1855CAE50")]
	internal GKGPEJPPAAF(GPOMCMHKDFP FHLBACEFGOE, IPEndPoint PLDGGNEJGHP, int POAELFIOKHK, byte JBHDMOMIIDF, KMMOMOFICIF APIKKOEOLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55CAC70", Offset = "0x55C9E70", VA = "0x1855CAC70")]
	internal GKGPEJPPAAF(GPOMCMHKDFP FHLBACEFGOE, EHIGHKDCPJO NOGNLJBIFAF, int POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55C7D60", Offset = "0x55C6F60", VA = "0x1855C7D60")]
	internal void DLJCFPDOCJD(IKCBCCLANNF AMPAEAIDLDE, byte[] MJGHOBDIDHD, int GGLMJACONBL, int EAMNBPDOIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x55C8690", Offset = "0x55C7890", VA = "0x1855C8690")]
	internal bool JKLICKLACEN(DLHJOBILMJB DOHFDINFONM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x55C9170", Offset = "0x55C8370", VA = "0x1855C9170")]
	public void LCJAGJPKCMA(byte[] MJGHOBDIDHD, int GGLMJACONBL, int EAMNBPDOIFO, POMFOCHJFPC JNAMIDLEDED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55CA6F0", Offset = "0x55C98F0", VA = "0x1855CA6F0")]
	private void OELBJOGEAFG(byte[] MJGHOBDIDHD, int GGLMJACONBL, int EAMNBPDOIFO, byte BGIPNBKNKOH, POMFOCHJFPC MAGELPNJNDO, object BGOGLKENJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x55CA640", Offset = "0x55C9840", VA = "0x1855CA640")]
	public void OCMMDAAPODC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55C8120", Offset = "0x55C7320", VA = "0x1855C8120")]
	internal FBHFIKDFLIP ELLPMJNKPFG(LPKFGDCBEEN DOHFDINFONM)
	{
		return default(FBHFIKDFLIP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55C7DB0", Offset = "0x55C6FB0", VA = "0x1855C7DB0")]
	internal void EAGGBCBMFFM(HEPDOGBFAOG JMOLEHHBOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55C7E10", Offset = "0x55C7010", VA = "0x1855C7E10")]
	internal OIIPPNEJIBK EKKAHFJJLHA(byte[] MJGHOBDIDHD, int GGLMJACONBL, int EAMNBPDOIFO, bool HLOIBGCELIK)
	{
		return default(OIIPPNEJIBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x55C8590", Offset = "0x55C7790", VA = "0x1855C8590")]
	private void HFGGFAJKKNA(int PHAJDNEKMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x55C8710", Offset = "0x55C7910", VA = "0x1855C8710")]
	internal void KNLICIMHFDJ(POMFOCHJFPC MGEGKLPMAHA, LPKFGDCBEEN HIFBGLLPLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55CA0D0", Offset = "0x55C92D0", VA = "0x1855CA0D0")]
	private void NKIELHHLDCA(LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55C7400", Offset = "0x55C6600", VA = "0x1855C7400")]
	private void AFPBGEAPEPB(int PJADGMHMMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55C83D0", Offset = "0x55C75D0", VA = "0x1855C83D0")]
	internal LNNNIGMFHBL GNACPOOFLGJ(IKCBCCLANNF HJJGAODCODE)
	{
		return default(LNNNIGMFHBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55C9A20", Offset = "0x55C8C20", VA = "0x1855C9A20")]
	internal void MPGNIHJCCIG(LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x55C8200", Offset = "0x55C7400", VA = "0x1855C8200")]
	private void FMGPOJIGPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55C91A0", Offset = "0x55C83A0", VA = "0x1855C91A0")]
	internal void LDIEBOMNJGK(LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x55C9370", Offset = "0x55C8570", VA = "0x1855C9370")]
	internal void MOLHGBBEJOJ(int PJADGMHMMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x55C7AA0", Offset = "0x55C6CA0", VA = "0x1855C7AA0")]
	internal void CBMLPFAPKFL(LPKFGDCBEEN DOHFDINFONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CFFAOIFLCKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long CODMONGKCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long EOGBLKAODCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long LBGHOMEPKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long MNFGHCEDDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long OHOBKNFPNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long EOPGHDMIGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long PLLEPDKMPAB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long IGJFLKDKPLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x55C4E40", Offset = "0x55C4040", VA = "0x1855C4E40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long MEODDNFLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x55C4D30", Offset = "0x55C3F30", VA = "0x1855C4D30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long OMEKHEHGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55C4D20", Offset = "0x55C3F20", VA = "0x1855C4D20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NHHKBHIKPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x55C4C10", Offset = "0x55C3E10", VA = "0x1855C4C10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long FGFNNPNINGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x55C4BC0", Offset = "0x55C3DC0", VA = "0x1855C4BC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long NOHHIHODACH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x55C4D70", Offset = "0x55C3F70", VA = "0x1855C4D70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private KIEMAAIIEOK OJOIFPILBKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1AD6E00", Offset = "0x1AD6000", VA = "0x181AD6E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double NGGKCNKLPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55C4C50", Offset = "0x55C3E50", VA = "0x1855C4C50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55C4CB0", Offset = "0x55C3EB0", VA = "0x1855C4CB0")]
	public void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55C4D40", Offset = "0x55C3F40", VA = "0x1855C4D40")]
	public void LBOAALEEGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x55C4D10", Offset = "0x55C3F10", VA = "0x1855C4D10")]
	public void IODMFLHPHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x55C4D80", Offset = "0x55C3F80", VA = "0x1855C4D80")]
	public void NDFAIMMKDPE(long IPBDIDKNFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x55C4E30", Offset = "0x55C4030", VA = "0x1855C4E30")]
	public void NOAJPLGMHDP(long LNNPFLPKHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x55C4C20", Offset = "0x55C3E20", VA = "0x1855C4C20")]
	public void EOLCGGOAAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x55C4BD0", Offset = "0x55C3DD0", VA = "0x1855C4BD0")]
	public void DHIINLHDGDB(long GHBCOLJGLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x55C4E50", Offset = "0x55C4050", VA = "0x1855C4E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55C4D90", Offset = "0x55C3F90", VA = "0x1855C4D90")]
	public void NHAKNKCJDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public CFFAOIFLCKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OLEIOLPHOCG
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> BJFMOKMPGIA;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x55D7D70", Offset = "0x55D6F70", VA = "0x1855D7D70")]
	public static IPEndPoint JBPGHNDEEDB(string PLOIEGNJIIL, int PFKMNBCMKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55D8050", Offset = "0x55D7250", VA = "0x1855D8050")]
	public static IPAddress KHGDBJFJJGM(string PLOIEGNJIIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55D7FC0", Offset = "0x55D71C0", VA = "0x1855D7FC0")]
	public static IPAddress KHGDBJFJJGM(string PLOIEGNJIIL, AddressFamily GEHHGIHBAOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55D7D40", Offset = "0x55D6F40", VA = "0x1855D7D40")]
	internal static int HBGJGDGPMMJ(int MNDAKOCHFGN, int JJGOIJENEOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A06BC0", Offset = "0x2A05DC0", VA = "0x182A06BC0")]
	internal static T[] JFMLACDIGFO<T>(int KMJOEPJMADC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DNEFIMICJPK : HEPDOGBFAOG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct LDHJIBJHKAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private LPKFGDCBEEN PKCGHOPLELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long HJGJGMABGDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool GIAPFOEANBG;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x55D4B40", Offset = "0x55D3D40", VA = "0x1855D4B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x55D4AB0", Offset = "0x55D3CB0", VA = "0x1855D4AB0")]
		public void GNCDFEHEFDJ(LPKFGDCBEEN DOHFDINFONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55D4AD0", Offset = "0x55D3CD0", VA = "0x1855D4AD0")]
		public bool JPEIIBIGINN(long BHDDECHEFPF, GKGPEJPPAAF KNGHABKDKHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x55D4A60", Offset = "0x55D3C60", VA = "0x1855D4A60")]
		public bool DBHKOJLPIHJ(GKGPEJPPAAF KNGHABKDKHL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly LPKFGDCBEEN DMCMCFBNPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly LDHJIBJHKAM[] HCLOPNKNCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly LPKFGDCBEEN[] NDIBNOCAIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] IGHAEHGDEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int DEGFPLNGKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int AJCBOELBMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int LJMHGNMGALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int AFKKPNHNHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KBAJGKBCAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly POMFOCHJFPC KLCMGCNJGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool HLMOGGHFLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int MAOOEHDBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte FKFKBBJAAOG;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x55C66E0", Offset = "0x55C58E0", VA = "0x1855C66E0")]
	public DNEFIMICJPK(GKGPEJPPAAF KNGHABKDKHL, bool GLPOMPIKCKB, byte POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55C5CC0", Offset = "0x55C4EC0", VA = "0x1855C5CC0")]
	private void GDBNEFHJHNM(LPKFGDCBEEN DOHFDINFONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x55C5810", Offset = "0x55C4A10", VA = "0x1855C5810", Slot = "4")]
	protected override bool AONGMMIOAOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55C6080", Offset = "0x55C5280", VA = "0x1855C6080", Slot = "5")]
	public override bool MPGNIHJCCIG(LPKFGDCBEEN DOHFDINFONM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CCGHJNHBMPO : HEPDOGBFAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int MKPGFCLMMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort AJCBOELBMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool OMPIAEJOLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private LPKFGDCBEEN ABKAGDJEPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly LPKFGDCBEEN NDBLFAJLDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool ECFJJMONCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte FKFKBBJAAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long BKPINEHCBOL;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x55C4B00", Offset = "0x55C3D00", VA = "0x1855C4B00")]
	public CCGHJNHBMPO(GKGPEJPPAAF KNGHABKDKHL, bool ONBMOLMMPKI, byte POAELFIOKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55C4350", Offset = "0x55C3550", VA = "0x1855C4350", Slot = "4")]
	protected override bool AONGMMIOAOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55C47F0", Offset = "0x55C39F0", VA = "0x1855C47F0", Slot = "5")]
	public override bool MPGNIHJCCIG(LPKFGDCBEEN DOHFDINFONM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ELDAHNJJIDE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EMJCJNPGNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong KFMMKEKECCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double KJPNMPBFGFM;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct ICIPNKIHBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int PMHKIMOGHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float JLCFAEKJBGE;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55C3DA0", Offset = "0x55C2FA0", VA = "0x1855C3DA0")]
	private static void FEMEAODEPKN(byte[] ENIOLEEEFGI, int BMIAFODFMCE, ulong MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x55C6B70", Offset = "0x55C5D70", VA = "0x1855C6B70")]
	private static void FEMEAODEPKN(byte[] ENIOLEEEFGI, int BMIAFODFMCE, int MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x55C6B30", Offset = "0x55C5D30", VA = "0x1855C6B30")]
	public static void FEMEAODEPKN(byte[] ENIOLEEEFGI, int BMIAFODFMCE, short MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x55C6A90", Offset = "0x55C5C90", VA = "0x1855C6A90")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, double EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x55C6AB0", Offset = "0x55C5CB0", VA = "0x1855C6AB0")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x55C6B30", Offset = "0x55C5D30", VA = "0x1855C6B30")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, short EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x55C6B30", Offset = "0x55C5D30", VA = "0x1855C6B30")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, ushort EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x55C6B70", Offset = "0x55C5D70", VA = "0x1855C6B70")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, int EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x55C6B70", Offset = "0x55C5D70", VA = "0x1855C6B70")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, uint EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x55C6A80", Offset = "0x55C5C80", VA = "0x1855C6A80")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, long EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x55C6A80", Offset = "0x55C5C80", VA = "0x1855C6A80")]
	public static void EGPPBBFDFED(byte[] GNPAJENJDCN, int BHOMKDDOKFH, ulong EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class NOBKPDKKLHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] MEJDGPDEIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int LIMEEAGHNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int DOLNDMNGDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int PMICCLLNOFI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] MJFCAKICACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int DECIMDMNJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x95D910", Offset = "0x95CB10", VA = "0x18095D910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GMFNAIDDAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x55D7660", Offset = "0x55D6860", VA = "0x1855D7660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HEPIABBLCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D29920", Offset = "0x1D28B20", VA = "0x181D29920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EJNAPNDLPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55D7670", Offset = "0x55D6870", VA = "0x1855D7670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x55D7840", Offset = "0x55D6A40", VA = "0x1855D7840")]
	public void INNBIKLINGK(byte[] HEEIDJMADFG, int BMIAFODFMCE, int FFNFCMBFNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public NOBKPDKKLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x55D7CE0", Offset = "0x55D6EE0", VA = "0x1855D7CE0")]
	public NOBKPDKKLHH(byte[] HEEIDJMADFG, int BMIAFODFMCE, int FFNFCMBFNDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x55D7680", Offset = "0x55D6880", VA = "0x1855D7680")]
	public IPEndPoint GOKNMOLCOIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55D78C0", Offset = "0x55D6AC0", VA = "0x1855D78C0")]
	public byte KAMLFEIAMPJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55D78C0", Offset = "0x55D6AC0", VA = "0x1855D78C0")]
	public sbyte OKICPFJAGIG()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29E29C0", Offset = "0x29E1BC0", VA = "0x1829E29C0")]
	public T[] KMKCAKHIDIJ<T>(ushort ANCJPCFOHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x55D7100", Offset = "0x55D6300", VA = "0x1855D7100")]
	public bool[] ADLEOODFDDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x55D7620", Offset = "0x55D6820", VA = "0x1855D7620")]
	public ushort[] EBJFMJKBFMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x55D7880", Offset = "0x55D6A80", VA = "0x1855D7880")]
	public short[] JENIHDFAHDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x55D7940", Offset = "0x55D6B40", VA = "0x1855D7940")]
	public int[] KJEPKEEICPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x55D7750", Offset = "0x55D6950", VA = "0x1855D7750")]
	public uint[] IGDIDDGHDAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x55D71B0", Offset = "0x55D63B0", VA = "0x1855D71B0")]
	public float[] AILHFCLPLJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x55D7B50", Offset = "0x55D6D50", VA = "0x1855D7B50")]
	public double[] OKKHFMDEDDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55D7B10", Offset = "0x55D6D10", VA = "0x1855D7B10")]
	public long[] NEJCODJDBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x55D7980", Offset = "0x55D6B80", VA = "0x1855D7980")]
	public ulong[] LBGFBEANDHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x55D7230", Offset = "0x55D6430", VA = "0x1855D7230")]
	public string[] CAPDGDFLPGL(int PDJLEFONOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x55D71F0", Offset = "0x55D63F0", VA = "0x1855D71F0")]
	public bool ANCFFCLICML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x55D7140", Offset = "0x55D6340", VA = "0x1855D7140")]
	public char GLHIELJLEKH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x55D7140", Offset = "0x55D6340", VA = "0x1855D7140")]
	public ushort AHENNKLLCJB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55D7C70", Offset = "0x55D6E70", VA = "0x1855D7C70")]
	public short PPCHILOJIEB()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55D7C00", Offset = "0x55D6E00", VA = "0x1855D7C00")]
	public long PKAOAOOJNHH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x55D7B90", Offset = "0x55D6D90", VA = "0x1855D7B90")]
	public ulong OPPECBHKLMG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55D79C0", Offset = "0x55D6BC0", VA = "0x1855D79C0")]
	public int LBKBCMAIBJJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55D75B0", Offset = "0x55D67B0", VA = "0x1855D75B0")]
	public uint EBHIHOFMEFG()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55D7AA0", Offset = "0x55D6CA0", VA = "0x1855D7AA0")]
	public float LECDFNFPJJM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x55D7A30", Offset = "0x55D6C30", VA = "0x1855D7A30")]
	public double LDGMEIEIOHN()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x55D7360", Offset = "0x55D6560", VA = "0x1855D7360")]
	public string CHBIDMAAKOI(int AJAOOILJBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x55D7790", Offset = "0x55D6990", VA = "0x1855D7790")]
	public ArraySegment<byte> IJJJBJPLMCM(int KMJOEPJMADC)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x55D7800", Offset = "0x55D6A00", VA = "0x1855D7800")]
	public sbyte[] IMDHBPOMFGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55D7900", Offset = "0x55D6B00", VA = "0x1855D7900")]
	public byte[] KDHIAKGCEFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x55D7590", Offset = "0x55D6790", VA = "0x1855D7590")]
	public void DBHKOJLPIHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KMMOMOFICIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] MEJDGPDEIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int LIMEEAGHNDH;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int AJFIJCOPAJA = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool HIKCNGLOLAL;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding KLDLJEGIEOD;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int AKEMOHAFIAG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] FHMDLIFFJIG;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] FHDMPGOGOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OECJFLODMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F20", Offset = "0x7B8120", VA = "0x1807B8F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x55D47D0", Offset = "0x55D39D0", VA = "0x1855D47D0")]
	public KMMOMOFICIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x55D4850", Offset = "0x55D3A50", VA = "0x1855D4850")]
	public KMMOMOFICIF(bool AAGGOJCAPIK, int BIDOPCCDGDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x55D46E0", Offset = "0x55D38E0", VA = "0x1855D46E0")]
	public static KMMOMOFICIF OBKMNHEKIAH(string EKDDCPALANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x55D3AB0", Offset = "0x55D2CB0", VA = "0x1855D3AB0")]
	public void BGLFEIDINPI(int HKOEPOIJDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3410", Offset = "0x1DA2610", VA = "0x181DA3410")]
	public void GKFNPGBHNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x55D3DE0", Offset = "0x55D2FE0", VA = "0x1855D3DE0")]
	public void DGOBDINCNHL(float EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x55D3CB0", Offset = "0x55D2EB0", VA = "0x1855D3CB0")]
	public void DGOBDINCNHL(double EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55D4160", Offset = "0x55D3360", VA = "0x1855D4160")]
	public void DGOBDINCNHL(long EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x55D4160", Offset = "0x55D3360", VA = "0x1855D4160")]
	public void DGOBDINCNHL(ulong EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55D3B50", Offset = "0x55D2D50", VA = "0x1855D3B50")]
	public void DGOBDINCNHL(int EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55D3B50", Offset = "0x55D2D50", VA = "0x1855D3B50")]
	public void DGOBDINCNHL(uint EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x55D3BE0", Offset = "0x55D2DE0", VA = "0x1855D3BE0")]
	public void DGOBDINCNHL(char EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55D3BE0", Offset = "0x55D2DE0", VA = "0x1855D3BE0")]
	public void DGOBDINCNHL(ushort EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x55D3BE0", Offset = "0x55D2DE0", VA = "0x1855D3BE0")]
	public void DGOBDINCNHL(short EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x55D3C50", Offset = "0x55D2E50", VA = "0x1855D3C50")]
	public void DGOBDINCNHL(sbyte EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x55D3C50", Offset = "0x55D2E50", VA = "0x1855D3C50")]
	public void DGOBDINCNHL(byte EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55D3EE0", Offset = "0x55D30E0", VA = "0x1855D3EE0")]
	public void DGOBDINCNHL(byte[] MJGHOBDIDHD, int BMIAFODFMCE, int EAMNBPDOIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55D4600", Offset = "0x55D3800", VA = "0x1855D4600")]
	public void JEOMEOELDCH(sbyte[] MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x55D4600", Offset = "0x55D3800", VA = "0x1855D4600")]
	public void FLPLDKIDOCF(byte[] MJGHOBDIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x55D3E80", Offset = "0x55D3080", VA = "0x1855D3E80")]
	public void DGOBDINCNHL(bool EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x55D4450", Offset = "0x55D3650", VA = "0x1855D4450")]
	public void DNJDBPBOOFG(Array NJKFGGCMEIF, int JPJBOHJFBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x55D4370", Offset = "0x55D3570", VA = "0x1855D4370")]
	public void DNJDBPBOOFG(float[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x55D41B0", Offset = "0x55D33B0", VA = "0x1855D41B0")]
	public void DNJDBPBOOFG(double[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x55D41B0", Offset = "0x55D33B0", VA = "0x1855D41B0")]
	public void DNJDBPBOOFG(long[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x55D41B0", Offset = "0x55D33B0", VA = "0x1855D41B0")]
	public void DNJDBPBOOFG(ulong[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x55D4370", Offset = "0x55D3570", VA = "0x1855D4370")]
	public void DNJDBPBOOFG(int[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x55D4370", Offset = "0x55D3570", VA = "0x1855D4370")]
	public void DNJDBPBOOFG(uint[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x55D4290", Offset = "0x55D3490", VA = "0x1855D4290")]
	public void DNJDBPBOOFG(ushort[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x55D4290", Offset = "0x55D3490", VA = "0x1855D4290")]
	public void DNJDBPBOOFG(short[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x55D4600", Offset = "0x55D3800", VA = "0x1855D4600")]
	public void DNJDBPBOOFG(bool[] EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x55D4530", Offset = "0x55D3730", VA = "0x1855D4530")]
	public void DNJDBPBOOFG(string[] EKDDCPALANJ, int CEHKLAIFDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x55D3D00", Offset = "0x55D2F00", VA = "0x1855D3D00")]
	public void DGOBDINCNHL(IPEndPoint DLJPDHBCMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x55D3DD0", Offset = "0x55D2FD0", VA = "0x1855D3DD0")]
	public void DGOBDINCNHL(string EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x55D3F50", Offset = "0x55D3150", VA = "0x1855D3F50")]
	public void DGOBDINCNHL(string EKDDCPALANJ, int AJAOOILJBID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ABNJFAHGHPO
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class HJLAOCEBBMI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong PAIBFKFLOCN;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3974B20", Offset = "0x3973D20", VA = "0x183974B20")]
		static HJLAOCEBBMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BAKDPBHDABP(NOBKPDKKLHH GILMBCDEMDA, object BGOGLKENJDE);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FBBMDAAOBCM<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public ABNJFAHGHPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FBBMDAAOBCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3759E80", Offset = "0x3759080", VA = "0x183759E80")]
		internal void ALPFEBMAGDG(NOBKPDKKLHH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FFHNHGALAMG<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public ABNJFAHGHPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public FFHNHGALAMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3778390", Offset = "0x3777590", VA = "0x183778390")]
		internal void ALPFEBMAGDG(NOBKPDKKLHH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly CPBPAGKNKCN NHFIMHOPHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, BAKDPBHDABP> KDLEHMJEGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly KMMOMOFICIF MMMJFNLIFJM;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x55C4130", Offset = "0x55C3330", VA = "0x1855C4130")]
	public ABNJFAHGHPO(int PDJLEFONOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x264E930", Offset = "0x264DB30", VA = "0x18264E930", Slot = "4")]
	protected virtual ulong NJJNALMLALA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x55C3F30", Offset = "0x55C3130", VA = "0x1855C3F30", Slot = "5")]
	protected virtual BAKDPBHDABP AJBNDFCHCBM(NOBKPDKKLHH GILMBCDEMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6A50", Offset = "0x2EA5C50", VA = "0x182EA6A50", Slot = "6")]
	protected virtual void JEJLPBFBHBL<T>(KMMOMOFICIF IBOFEJJMDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55C40B0", Offset = "0x55C32B0", VA = "0x1855C40B0")]
	public void GFDMCPFNGOB(NOBKPDKKLHH GILMBCDEMDA, object BGOGLKENJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6AC0", Offset = "0x2EA5CC0", VA = "0x182EA6AC0")]
	public void PFJFMDMNKPF<T>(KMMOMOFICIF IBOFEJJMDAD, T DOHFDINFONM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x55C4060", Offset = "0x55C3260", VA = "0x1855C4060")]
	public void EENIKKLFNLC(NOBKPDKKLHH GILMBCDEMDA, object BGOGLKENJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2EA68D0", Offset = "0x2EA5AD0", VA = "0x182EA68D0")]
	public void EMEBEMLPKKH<T>(Action<T> GJFPIJFAOPJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2EA6750", Offset = "0x2EA5950", VA = "0x182EA6750")]
	public void EMEBEMLPKKH<T, TUserData>(Action<T, TUserData> GJFPIJFAOPJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ILDENOBHACO : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x55C5190", Offset = "0x55C4390", VA = "0x1855C5190")]
	public ILDENOBHACO(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CLMLDMKIKAN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x55C51A0", Offset = "0x55C43A0", VA = "0x1855C51A0")]
	public CLMLDMKIKAN(string FFDOAJJEAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class CPBPAGKNKCN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LMOLNHFLOKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BJJAGCFHMNL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public LMOLNHFLOKA MEBDELDBDDE;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x47C8480", Offset = "0x47C7680", VA = "0x1847C8480", Slot = "4")]
		public virtual void GNCDFEHEFDJ(MethodInfo NPBDJNCDBAA, MethodInfo GIKKGNLGMOL, LMOLNHFLOKA MJMAEGDPBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ICJFLBGKEFN(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void KNLCGJGPCPH(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		protected BJJAGCFHMNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class FDIDDOFBKIO<TClass, TProperty> : BJJAGCFHMNL<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> DDDKGHAOJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> NJKIBGLMDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> HBPMOJENGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> OILGPNHKHPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> IKLBJHKILCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> HJHDLIGOIAH;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3765A60", Offset = "0x3764C60", VA = "0x183765A60", Slot = "7")]
		public override void DNMOJMMOCNJ(TClass JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3766C20", Offset = "0x3765E20", VA = "0x183766C20", Slot = "8")]
		public override void OGGLBNEHCGJ(TClass JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3766750", Offset = "0x3765950", VA = "0x183766750", Slot = "9")]
		public override void ICJFLBGKEFN(TClass JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3766980", Offset = "0x3765B80", VA = "0x183766980", Slot = "10")]
		public override void KNLCGJGPCPH(TClass JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3765B40", Offset = "0x3764D40", VA = "0x183765B40")]
		protected TProperty[] FHILDDDAIDL(TClass JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3766910", Offset = "0x3765B10", VA = "0x183766910")]
		protected TProperty[] KMEOFAAENHN(TClass JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x37661C0", Offset = "0x37653C0", VA = "0x1837661C0", Slot = "4")]
		public override void GNCDFEHEFDJ(MethodInfo NPBDJNCDBAA, MethodInfo GIKKGNLGMOL, LMOLNHFLOKA MJMAEGDPBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3766D00", Offset = "0x3765F00", VA = "0x183766D00")]
		protected FDIDDOFBKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class FGMGHOPKNPJ<TClass, TProperty> : FDIDDOFBKIO<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void JMKCHOBHJNP(NOBKPDKKLHH COLCKPIEBCC, [Out] TProperty DJDBDBAFGDL);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void ELHEMFCEPCM(KMMOMOFICIF HDJLHPPJJLL, TProperty DJDBDBAFGDL);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x377ABC0", Offset = "0x3779DC0", VA = "0x18377ABC0", Slot = "5")]
		public override void AJMADNCBCCK(TClass JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x377AF40", Offset = "0x377A140", VA = "0x18377AF40", Slot = "6")]
		public override void PFJFMDMNKPF(TClass JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x377AD60", Offset = "0x3779F60", VA = "0x18377AD60", Slot = "7")]
		public override void DNMOJMMOCNJ(TClass JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x377AE00", Offset = "0x377A000", VA = "0x18377AE00", Slot = "8")]
		public override void OGGLBNEHCGJ(TClass JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x377B020", Offset = "0x377A220", VA = "0x18377B020")]
		protected FGMGHOPKNPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class JGNCIDJIFAD<T> : FDIDDOFBKIO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE820", Offset = "0x3BFDA20", VA = "0x183BFE820", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x38784B0", Offset = "0x38776B0", VA = "0x1838784B0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFE880", Offset = "0x3BFDA80", VA = "0x183BFE880", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x37789E0", Offset = "0x3777BE0", VA = "0x1837789E0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public JGNCIDJIFAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class GJHAOBGAFEA<T> : FDIDDOFBKIO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x38783F0", Offset = "0x38775F0", VA = "0x1838783F0", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x38784B0", Offset = "0x38776B0", VA = "0x1838784B0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3878450", Offset = "0x3877650", VA = "0x183878450", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x37789E0", Offset = "0x3777BE0", VA = "0x1837789E0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public GJHAOBGAFEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class FHOJEPBLECL<T> : FDIDDOFBKIO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3780D40", Offset = "0x377FF40", VA = "0x183780D40", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3780E50", Offset = "0x3780050", VA = "0x183780E50", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3780DA0", Offset = "0x377FFA0", VA = "0x183780DA0", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3780E00", Offset = "0x3780000", VA = "0x183780E00", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public FHOJEPBLECL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class GAOPODIJFGI<T> : FDIDDOFBKIO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3852500", Offset = "0x3851700", VA = "0x183852500", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3780E50", Offset = "0x3780050", VA = "0x183780E50", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3852560", Offset = "0x3851760", VA = "0x183852560", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3780E00", Offset = "0x3780000", VA = "0x183780E00", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public GAOPODIJFGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JDKJLPMPFNK<T> : FDIDDOFBKIO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3BECAE0", Offset = "0x3BEBCE0", VA = "0x183BECAE0", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3BECBF0", Offset = "0x3BEBDF0", VA = "0x183BECBF0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3BECB40", Offset = "0x3BEBD40", VA = "0x183BECB40", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3BECBA0", Offset = "0x3BEBDA0", VA = "0x183BECBA0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public JDKJLPMPFNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class KEJJICJDFPN<T> : FDIDDOFBKIO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CABAC0", Offset = "0x3CAACC0", VA = "0x183CABAC0", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3BECBF0", Offset = "0x3BEBDF0", VA = "0x183BECBF0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CABB20", Offset = "0x3CAAD20", VA = "0x183CABB20", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3BECBA0", Offset = "0x3BEBDA0", VA = "0x183BECBA0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public KEJJICJDFPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AMDBNHIPAOF<T> : FDIDDOFBKIO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x38347A0", Offset = "0x38339A0", VA = "0x1838347A0", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x38348B0", Offset = "0x3833AB0", VA = "0x1838348B0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x38B9170", Offset = "0x38B8370", VA = "0x1838B9170", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3834860", Offset = "0x3833A60", VA = "0x183834860", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public AMDBNHIPAOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ACMPPGMIKCB<T> : FDIDDOFBKIO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x38347A0", Offset = "0x38339A0", VA = "0x1838347A0", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x38348B0", Offset = "0x3833AB0", VA = "0x1838348B0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3834800", Offset = "0x3833A00", VA = "0x183834800", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3834860", Offset = "0x3833A60", VA = "0x183834860", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public ACMPPGMIKCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FFOBFOJBNMP<T> : FDIDDOFBKIO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3778920", Offset = "0x3777B20", VA = "0x183778920", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3778A30", Offset = "0x3777C30", VA = "0x183778A30", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3778980", Offset = "0x3777B80", VA = "0x183778980", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x37789E0", Offset = "0x3777BE0", VA = "0x1837789E0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public FFOBFOJBNMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class NGLFDDIDDHC<T> : FDIDDOFBKIO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8D50", Offset = "0x3FE7F50", VA = "0x183FE8D50", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8E10", Offset = "0x3FE8010", VA = "0x183FE8E10", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3FE8DB0", Offset = "0x3FE7FB0", VA = "0x183FE8DB0", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BECBA0", Offset = "0x3BEBDA0", VA = "0x183BECBA0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public NGLFDDIDDHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MALAKGGGAAL<T> : FDIDDOFBKIO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F04D10", Offset = "0x3F03F10", VA = "0x183F04D10", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F04DD0", Offset = "0x3F03FD0", VA = "0x183F04DD0", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F04D70", Offset = "0x3F03F70", VA = "0x183F04D70", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3834860", Offset = "0x3833A60", VA = "0x183834860", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3778A80", Offset = "0x3777C80", VA = "0x183778A80")]
		public MALAKGGGAAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class EPCJJAKOGKB<T> : FGMGHOPKNPJ<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3433D90", Offset = "0x3432F90", VA = "0x183433D90", Slot = "12")]
		protected override void ELHEMFCEPCM(KMMOMOFICIF HDJLHPPJJLL, char DJDBDBAFGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3433DC0", Offset = "0x3432FC0", VA = "0x183433DC0", Slot = "11")]
		protected override void JMKCHOBHJNP(NOBKPDKKLHH COLCKPIEBCC, [Out] char DJDBDBAFGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3433DF0", Offset = "0x3432FF0", VA = "0x183433DF0")]
		public EPCJJAKOGKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class PEDMLMNPGII<T> : FGMGHOPKNPJ<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x41A2C50", Offset = "0x41A1E50", VA = "0x1841A2C50", Slot = "12")]
		protected override void ELHEMFCEPCM(KMMOMOFICIF HDJLHPPJJLL, IPEndPoint DJDBDBAFGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x41A2C80", Offset = "0x41A1E80", VA = "0x1841A2C80", Slot = "11")]
		protected override void JMKCHOBHJNP(NOBKPDKKLHH COLCKPIEBCC, [Out] IPEndPoint DJDBDBAFGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3433DF0", Offset = "0x3432FF0", VA = "0x183433DF0")]
		public PEDMLMNPGII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class EJGAPCMAPEB<T> : FDIDDOFBKIO<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int JNAOEKFEOGF;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x34291B0", Offset = "0x34283B0", VA = "0x1834291B0")]
		public EJGAPCMAPEB(int AJAOOILJBID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3429010", Offset = "0x3428210", VA = "0x183429010", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3429150", Offset = "0x3428350", VA = "0x183429150", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3429080", Offset = "0x3428280", VA = "0x183429080", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x34290F0", Offset = "0x34282F0", VA = "0x1834290F0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class JOKEDPBKOEG<T> : BJJAGCFHMNL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo EDBLDHKGHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type LBLELMPNGJE;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C566B0", Offset = "0x3C558B0", VA = "0x183C566B0")]
		public JOKEDPBKOEG(PropertyInfo BMIMCNPMKAE, Type MMGLGNDOABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C563C0", Offset = "0x3C555C0", VA = "0x183C563C0", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C56600", Offset = "0x3C55800", VA = "0x183C56600", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C56480", Offset = "0x3C55680", VA = "0x183C56480", Slot = "7")]
		public override void DNMOJMMOCNJ(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C565A0", Offset = "0x3C557A0", VA = "0x183C565A0", Slot = "8")]
		public override void OGGLBNEHCGJ(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C564E0", Offset = "0x3C556E0", VA = "0x183C564E0", Slot = "9")]
		public override void ICJFLBGKEFN(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C56540", Offset = "0x3C55740", VA = "0x183C56540", Slot = "10")]
		public override void KNLCGJGPCPH(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class HKICIKBCOHN<T> : JOKEDPBKOEG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x342B930", Offset = "0x342AB30", VA = "0x18342B930")]
		public HKICIKBCOHN(PropertyInfo BMIMCNPMKAE, Type MMGLGNDOABP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3976240", Offset = "0x3975440", VA = "0x183976240", Slot = "5")]
		public override void AJMADNCBCCK(T JPBNIFOGNFN, NOBKPDKKLHH COLCKPIEBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3976300", Offset = "0x3975500", VA = "0x183976300", Slot = "6")]
		public override void PFJFMDMNKPF(T JPBNIFOGNFN, KMMOMOFICIF HDJLHPPJJLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class NJJFDLPCMCL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static NJJFDLPCMCL<T> EELHBDDPCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly BJJAGCFHMNL<T>[] PHPECGALHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int BMGGOFEGPNG;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF8550", Offset = "0x3FF7750", VA = "0x183FF8550")]
		public NJJFDLPCMCL(List<BJJAGCFHMNL<T>> ACADNCOBJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3FF84A0", Offset = "0x3FF76A0", VA = "0x183FF84A0")]
		public void PFJFMDMNKPF(T GLMGCMELGFD, KMMOMOFICIF IBOFEJJMDAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3FF83F0", Offset = "0x3FF75F0", VA = "0x183FF83F0")]
		public void AJMADNCBCCK(T GLMGCMELGFD, NOBKPDKKLHH GILMBCDEMDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class PBOIBNLGPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BJJAGCFHMNL<T> CEIMJGKDJPN<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private KMMOMOFICIF OPOAIDJGLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int ALLEKDEJCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, PBOIBNLGPHJ> JPPEFHLCGGJ;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x55C5200", Offset = "0x55C4400", VA = "0x1855C5200")]
	public CPBPAGKNKCN(int PDJLEFONOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x26FA510", Offset = "0x26F9710", VA = "0x1826FA510")]
	private NJJFDLPCMCL<T> NGLABIAIGLG<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x26FB3E0", Offset = "0x26FA5E0", VA = "0x1826FB3E0")]
	public void OEPCKJDAMHI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x26FA490", Offset = "0x26F9690", VA = "0x1826FA490")]
	public bool MAOCPLNNJJM<T>(NOBKPDKKLHH GILMBCDEMDA, T JGFCAMDGBLE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x26FA430", Offset = "0x26F9630", VA = "0x1826FA430")]
	public void JCBMCDNAHJB<T>(KMMOMOFICIF IBOFEJJMDAD, T GLMGCMELGFD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class PFKLKHOHIPO
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime HNKFCEFDGHE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] JAIOKBNJHEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public FCNGEPJALDI BGICCNEGOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x55D8DB0", Offset = "0x55D7FB0", VA = "0x1855D8DB0")]
		get
		{
			return default(FCNGEPJALDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BPNHPMOCOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x55D84E0", Offset = "0x55D76E0", VA = "0x1855D84E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x55D87C0", Offset = "0x55D79C0", VA = "0x1855D87C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NBLIKPGHALC MPKCFOPLCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x55D8790", Offset = "0x55D7990", VA = "0x1855D8790")]
		get
		{
			return default(NBLIKPGHALC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x55D91D0", Offset = "0x55D83D0", VA = "0x1855D91D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int KAJLPGKDKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x55D82B0", Offset = "0x55D74B0", VA = "0x1855D82B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint NLPLCCDLDJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x55D8710", Offset = "0x55D7910", VA = "0x1855D8710")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? IPDANIBLJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x55D8510", Offset = "0x55D7710", VA = "0x1855D8510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? CDNGLFJDKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x55D82E0", Offset = "0x55D74E0", VA = "0x1855D82E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CNPNJDNHPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x55D8BD0", Offset = "0x55D7DD0", VA = "0x1855D8BD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x55D8800", Offset = "0x55D7A00", VA = "0x1855D8800")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? HEKNFMLIOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAD72C0", Offset = "0xAD64C0", VA = "0x180AD72C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x909750", Offset = "0x908950", VA = "0x180909750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x55D9320", Offset = "0x55D8520", VA = "0x1855D9320")]
	public PFKLKHOHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x55D9270", Offset = "0x55D8470", VA = "0x1855D9270")]
	internal PFKLKHOHIPO(byte[] GNPAJENJDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x55D8C90", Offset = "0x55D7E90", VA = "0x1855D8C90")]
	public static PFKLKHOHIPO KJNDGBJAKHN(byte[] GNPAJENJDCN, DateTime KAFNEACOOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x55D8F70", Offset = "0x55D8170", VA = "0x1855D8F70")]
	internal void NAAMACBDFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x55D8540", Offset = "0x55D7740", VA = "0x1855D8540")]
	private void FJDAOILBOOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x55D89D0", Offset = "0x55D7BD0", VA = "0x1855D89D0")]
	private DateTime? JEPLEHKACEH(int BMIAFODFMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x55D8310", Offset = "0x55D7510", VA = "0x1855D8310")]
	private void CMKICNMOLPG(int BMIAFODFMCE, DateTime? EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x55D8EA0", Offset = "0x55D80A0", VA = "0x1855D8EA0")]
	private ulong MHFOHFJMBIL(int BMIAFODFMCE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x55D8DE0", Offset = "0x55D7FE0", VA = "0x1855D8DE0")]
	private void MEGDFLIGPFG(int BMIAFODFMCE, ulong EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x55D8C00", Offset = "0x55D7E00", VA = "0x1855D8C00")]
	private uint KHIJBHBPAPD(int BMIAFODFMCE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x54A7770", Offset = "0x54A6970", VA = "0x1854A7770")]
	private static uint NGEPAAKHOCA(uint EFCGILCAOIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x55D9170", Offset = "0x55D8370", VA = "0x1855D9170")]
	private static ulong NGEPAAKHOCA(ulong EFCGILCAOIA)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum FCNGEPJALDI
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
public enum NBLIKPGHALC
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class LFDHALFAHFL
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int BHGFHFKKGFN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int HMCKHCMADGO = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int GBDLDAEIOEE = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint AACBOCLMMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int LJLIOJACMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int DBMHFPNHCOM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HCGHHFNKOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x55D4BE0", Offset = "0x55D3DE0", VA = "0x1855D4BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x55D4BF0", Offset = "0x55D3DF0", VA = "0x1855D4BF0")]
	public bool LCJAGJPKCMA(ONDLAEHFCPD HHMDDEODCKM, int NOOMBIPKGEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class GANANCEEJPJ : ONDLAEHFCPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket HHMDDEODCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly GPOMCMHKDFP FHLBACEFGOE;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short INKPONNHLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x55C6C60", Offset = "0x55C5E60", VA = "0x1855C6C60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HMPAKBJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x55C6C20", Offset = "0x55C5E20", VA = "0x1855C6C20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint FGLDDNKEMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x55C6C40", Offset = "0x55C5E40", VA = "0x1855C6C40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily MOLLDBFFFME
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D242A0", Offset = "0x3D234A0", VA = "0x183D242A0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x55C7350", Offset = "0x55C6550", VA = "0x1855C7350")]
	public GANANCEEJPJ(AddressFamily GEHHGIHBAOL, GPOMCMHKDFP FHLBACEFGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x55C6C80", Offset = "0x55C5E80", VA = "0x1855C6C80", Slot = "8")]
	public bool IOHGPHEIIBM(IPEndPoint DLJPDHBCMKJ, LCCFPJJAEBC HAAHBILGIIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x55C6BE0", Offset = "0x55C5DE0", VA = "0x1855C6BE0", Slot = "9")]
	public int CPIMELGJAKG(byte[] ENIOLEEEFGI, int BMIAFODFMCE, int ANCJPCFOHBG, IPEndPoint PLDGGNEJGHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x55C7260", Offset = "0x55C6460", VA = "0x1855C7260", Slot = "10")]
	public int PFINIDEHIHN(byte[] ENIOLEEEFGI, EndPoint MMCGCEFLKMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x55C7240", Offset = "0x55C6440", VA = "0x1855C7240", Slot = "11")]
	public void KPMIACKNINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface ONDLAEHFCPD
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short INKPONNHLJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int HMPAKBJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint FGLDDNKEMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily MOLLDBFFFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IOHGPHEIIBM(IPEndPoint DLJPDHBCMKJ, LCCFPJJAEBC HAAHBILGIIP);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CPIMELGJAKG(byte[] ENIOLEEEFGI, int BMIAFODFMCE, int ANCJPCFOHBG, IPEndPoint PLDGGNEJGHP);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PFINIDEHIHN(byte[] ENIOLEEEFGI, EndPoint PLDGGNEJGHP);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KPMIACKNINJ();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct DGMKNLFGMOC : IEquatable<DGMKNLFGMOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long CAKKDMPJLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long MFMCAJDBCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long OOAGKGCOAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int OHINGGKCBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int LMJBCJHOFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x55C5390", Offset = "0x55C4590", VA = "0x1855C5390")]
	public DGMKNLFGMOC(byte[] PCLIJINNNLM, int PJPBPMACBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7DCC60", Offset = "0x7DBE60", VA = "0x1807DCC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x55C5350", Offset = "0x55C4550", VA = "0x1855C5350", Slot = "4")]
	public bool Equals(DGMKNLFGMOC MEJMHKPOODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x55C52A0", Offset = "0x55C44A0", VA = "0x1855C52A0", Slot = "0")]
	public override bool Equals(object GLMGCMELGFD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class NCCDDIFCKMB : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] BEDIIHOMDNI;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class MIEPKCLICMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int KOJFLBJBAGP;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBC90", Offset = "0x7BAE90", VA = "0x1807BBC90")]
	protected MIEPKCLICMM(int CCHDJIOLDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ODCFIKGKAMM(IPEndPoint DLJPDHBCMKJ, byte[] MJGHOBDIDHD, int BMIAFODFMCE, int EAMNBPDOIFO);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void JNIKNLDHEDC(IPEndPoint DLJPDHBCMKJ, byte[] MJGHOBDIDHD, int BMIAFODFMCE, int EAMNBPDOIFO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KHDJLBPNFFJ : MIEPKCLICMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider IADFKGEBNNL;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator NALAJNDDJFI;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x55D3A90", Offset = "0x55D2C90", VA = "0x1855D3A90")]
	public KHDJLBPNFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x55D3370", Offset = "0x55D2570", VA = "0x1855D3370")]
	public void MKCEOLKHJEM(IPEndPoint DLJPDHBCMKJ, byte[] GHBNLDGJPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x55D2E60", Offset = "0x55D2060", VA = "0x1855D2E60")]
	public void BOJJKGABLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x55D32E0", Offset = "0x55D24E0", VA = "0x1855D32E0")]
	private byte[] KCNNBDKMCKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x55D35B0", Offset = "0x55D27B0", VA = "0x1855D35B0", Slot = "4")]
	public override void ODCFIKGKAMM(IPEndPoint DLJPDHBCMKJ, byte[] MJGHOBDIDHD, int BMIAFODFMCE, int EAMNBPDOIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x55D2F40", Offset = "0x55D2140", VA = "0x1855D2F40", Slot = "5")]
	public override void JNIKNLDHEDC(IPEndPoint DLJPDHBCMKJ, byte[] MJGHOBDIDHD, int BMIAFODFMCE, int EAMNBPDOIFO)
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
