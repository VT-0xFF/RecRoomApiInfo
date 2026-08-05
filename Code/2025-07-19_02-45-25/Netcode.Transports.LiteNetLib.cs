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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ECFCPOPNGNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum DCCPAKJPPLL
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
		private NetworkManager NIPEFFPIHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool BJOAFFJOBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, MOLHAOHJIGG> BCLFCFILCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JAOBJOHMHKI GOOEJFCKNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch MGPPICDJPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] CGNDDJOAFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DCCPAKJPPLL DACAPCIHLOL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int OCOHMCOABAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x735D450", Offset = "0x735C450", VA = "0x18735D450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong FENFLBIBOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool NKBKAMMACCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x735D430", Offset = "0x735C430", VA = "0x18735D430", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x735CA20", Offset = "0x735BA20", VA = "0x18735CA20")]
		public void RecRoom_SetEncryptionInfo(ulong BHGNGIBFMCH, byte[] DAKIIEIEKNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x735CA00", Offset = "0x735BA00", VA = "0x18735CA00")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x735C810", Offset = "0x735B810", VA = "0x18735C810")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x735D330", Offset = "0x735C330", VA = "0x18735D330")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x735CB40", Offset = "0x735BB40", VA = "0x18735CB40", Slot = "6")]
		public override void Send(ulong AEOGCMBMFHO, ArraySegment<byte> INCJDDLACNP, NetworkDelivery EDJBEOPABFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x735C9C0", Offset = "0x735B9C0", VA = "0x18735C9C0", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong AEOGCMBMFHO, [Out] ArraySegment<byte> MBAGIDFJGJL, [Out] float GHPNCHJHJCE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x735CE30", Offset = "0x735BE30", VA = "0x18735CE30", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x735D150", Offset = "0x735C150", VA = "0x18735D150", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x735BF10", Offset = "0x735AF10", VA = "0x18735BF10", Slot = "11")]
		public override void DisconnectRemoteClient(ulong AEOGCMBMFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x735BE20", Offset = "0x735AE20", VA = "0x18735BE20", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x735C140", Offset = "0x735B140", VA = "0x18735C140", Slot = "13")]
		public override ulong GetCurrentRtt(ulong AEOGCMBMFHO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x735CDC0", Offset = "0x735BDC0", VA = "0x18735CDC0", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x735C1E0", Offset = "0x735B1E0", VA = "0x18735C1E0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager NIPEFFPIHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x735C040", Offset = "0x735B040", VA = "0x18735C040")]
		private IOIBCGAEOCL GELIOELDCHI(NetworkDelivery BJLNCBFOGNL)
		{
			return default(IOIBCGAEOCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x735C900", Offset = "0x735B900", VA = "0x18735C900", Slot = "16")]
		private void PKFEOFJECOB(MOLHAOHJIGG PAJOIEFGIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x735C530", Offset = "0x735B530", VA = "0x18735C530", Slot = "17")]
		private void LIFDFJEGIIO(MOLHAOHJIGG PAJOIEFGIDG, GFOEAEJDCLJ BGEGPLMBNCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "18")]
		private void DLKOCKNLGLK(IPEndPoint KPDFNPOOKOJ, SocketError CJAONMINKHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x735C600", Offset = "0x735B600", VA = "0x18735C600", Slot = "19")]
		private void OALDPAIJPEA(MOLHAOHJIGG PAJOIEFGIDG, HFGDAGGMJMB AMPJMGIAGBB, byte CJPGBMBDJLM, IOIBCGAEOCL JPHMMIGPNNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x735C450", Offset = "0x735B450", VA = "0x18735C450")]
		private void LHBFPLBLNJL(int BKLOHAHJLKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "20")]
		private void NGDMMINKEDC(IPEndPoint MCPKAMEBJKG, HFGDAGGMJMB AMPJMGIAGBB, GKNPOIIDKIH LIJIIGNGLDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "21")]
		private void EAKHBJDAJFM(MOLHAOHJIGG PAJOIEFGIDG, int KHIEPDPEFIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x735C3F0", Offset = "0x735B3F0", VA = "0x18735C3F0", Slot = "22")]
		private void LBKMBOPDNKC(GMJMEOAFJEE LIPNPCINFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x735BDD0", Offset = "0x735ADD0", VA = "0x18735BDD0")]
		private ulong DOEHAMIOGDG(MOLHAOHJIGG PAJOIEFGIDG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x735BE00", Offset = "0x735AE00", VA = "0x18735BE00")]
		private ulong DOEHAMIOGDG(ulong AEOGCMBMFHO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x735C020", Offset = "0x735B020", VA = "0x18735C020")]
		private static int FAHAOOPHNBD(float GLANCCCAPLO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x735D350", Offset = "0x735C350", VA = "0x18735D350")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x735C110", Offset = "0x735B110", VA = "0x18735C110")]
		[CompilerGenerated]
		private void KEHMHHGMEDA(ulong CGJAADAMNAJ, int LOMGLKPGKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x735C110", Offset = "0x735B110", VA = "0x18735C110")]
		[CompilerGenerated]
		private void GNLABOHAHDN(ulong CGJAADAMNAJ, int LOMGLKPGKAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class JKLKEIBPBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly MOLHAOHJIGG EPJCMLFBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<PCPCKKAAELA> PODCHCKIKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int PBNEOCAJDOH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MFADHCIPILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x735B650", Offset = "0x735A650", VA = "0x18735B650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x735B7C0", Offset = "0x735A7C0", VA = "0x18735B7C0")]
	protected JKLKEIBPBAI(MOLHAOHJIGG PAJOIEFGIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x735B720", Offset = "0x735A720", VA = "0x18735B720")]
	public void HMPNJMNFHEB(PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x735B6A0", Offset = "0x735A6A0", VA = "0x18735B6A0")]
	protected void BOOALPHNACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x735B780", Offset = "0x735A780", VA = "0x18735B780")]
	public bool JLLCOBNJDKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool GAKKIAHHBBB();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PBDCJJBPPPD(PCPCKKAAELA CJBPABPKIDK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum IGLAPEPJDLH
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class GMJMEOAFJEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JAOBJOHMHKI IFHLOEEMGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int LPDIKAPCEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal KMPABPIHLLK LPMMDPNBPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint KCCHMAOPMAM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal IGLAPEPJDLH IJBEHPGCOHL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10")]
		[CompilerGenerated]
		get
		{
			return default(IGLAPEPJDLH);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xE8AAE0", Offset = "0xE89AE0", VA = "0x180E8AAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7352B60", Offset = "0x7351B60", VA = "0x187352B60")]
	internal void AFOENOIGPFF(KMPABPIHLLK IBLICHKBJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7352BC0", Offset = "0x7351BC0", VA = "0x187352BC0")]
	private bool AIJFMHKCAML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7352C50", Offset = "0x7351C50", VA = "0x187352C50")]
	internal GMJMEOAFJEE(IPEndPoint MCPKAMEBJKG, KMPABPIHLLK HNPAAPKPCFI, JAOBJOHMHKI KBILBMDMHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7352BF0", Offset = "0x7351BF0", VA = "0x187352BF0")]
	public MOLHAOHJIGG KGEPBOEGIMJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GKNPOIIDKIH
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum PKIOAIMGLAI
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GFOEAEJDCLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public PKIOAIMGLAI FAFIFHIDIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError JJJPHNIPFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public HFGDAGGMJMB GALLBHOCOBM;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECFCPOPNGNE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHDCKDBHFCD(MOLHAOHJIGG PAJOIEFGIDG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BNLFHEDLPAC(MOLHAOHJIGG PAJOIEFGIDG, GFOEAEJDCLJ BGEGPLMBNCG);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJHJJFMJANE(IPEndPoint KPDFNPOOKOJ, SocketError CJAONMINKHG);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELFCAKICLMP(MOLHAOHJIGG PAJOIEFGIDG, HFGDAGGMJMB AMPJMGIAGBB, byte CJPGBMBDJLM, IOIBCGAEOCL JPHMMIGPNNG);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CAGGBIBKCGA(IPEndPoint MCPKAMEBJKG, HFGDAGGMJMB AMPJMGIAGBB, GKNPOIIDKIH LIJIIGNGLDP);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DNEDFKNNBIC(MOLHAOHJIGG PAJOIEFGIDG, int KHIEPDPEFIJ);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMNDMOPGPOL(GMJMEOAFJEE LIPNPCINFLG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GPCJBEPLPMI
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEJHKNDLGBP(MOLHAOHJIGG PAJOIEFGIDG, object HBHKNPFCOFO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LHJKADOLPIO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGHHNAPFJFI(GGHFBJPCICH CJBPABPKIDK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EOJMLKKMEDN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGHOECNDHCA(MOLHAOHJIGG PAJOIEFGIDG, IPEndPoint HGJGOHGLBDL);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class KMPABPIHLLK
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int BONMAGPBNPI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long GHHHBFBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte DAIANNAMJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] DDFKOILNLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly AMLLHKHCDME FGNOGEEOKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int NCMNNOPADHL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x735BD60", Offset = "0x735AD60", VA = "0x18735BD60")]
	private KMPABPIHLLK(long DGIHDPCOECG, byte HCGDMIBPBND, int MPAKEJAFLKL, byte[] ADJILPLOJGH, AMLLHKHCDME INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x735BD00", Offset = "0x735AD00", VA = "0x18735BD00")]
	public static int OCIADAOIJCF(PCPCKKAAELA CJBPABPKIDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x735BAE0", Offset = "0x735AAE0", VA = "0x18735BAE0")]
	public static KMPABPIHLLK LAIGGDBHJLK(PCPCKKAAELA CJBPABPKIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x735B900", Offset = "0x735A900", VA = "0x18735B900")]
	public static PCPCKKAAELA BDPKAOOFAGK(NIHFFPGGAMD COLGHDHBOOO, SocketAddress OGAFPJGIGIJ, long HMCKFMIFCNF, int MPAKEJAFLKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class EPGOLFIPCGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long GHHHBFBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte DAIANNAMJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int NCMNNOPADHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool NJLCIDBFONL;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7350150", Offset = "0x734F150", VA = "0x187350150")]
	private EPGOLFIPCGO(long DGIHDPCOECG, byte HCGDMIBPBND, int FBEDGADHOAK, bool CBICFJKKDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x734FF00", Offset = "0x734EF00", VA = "0x18734FF00")]
	public static EPGOLFIPCGO LAIGGDBHJLK(PCPCKKAAELA CJBPABPKIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x734FE10", Offset = "0x734EE10", VA = "0x18734FE10")]
	public static PCPCKKAAELA BDPKAOOFAGK(long HMCKFMIFCNF, byte NHFFHCCOEGH, int KMHHEDBGECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7350050", Offset = "0x734F050", VA = "0x187350050")]
	public static PCPCKKAAELA PJBFKGILKNG(MOLHAOHJIGG PAJOIEFGIDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum EPONGDHMKHD
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MGKADKLNAIK
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLHBHALMIHP(IPEndPoint PEPOAGHKPEF, IPEndPoint MCPKAMEBJKG, string GFDDDAIMFOH);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNNBMIIDKFK(IPEndPoint JMIHLPOIAOM, EPONGDHMKHD BJLNCBFOGNL, string GFDDDAIMFOH);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class ODFKPHHFDMI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DNNPDNALDOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint NFJGNFKNNAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint KCCHMAOPMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string PGBJGODECMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct POGGKHNPIED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint OJJEOHKIGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EPONGDHMKHD HHDOJPCILPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string PGBJGODECMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class CGDOPIEDIEB
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint ALBKENLCLPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string PGBJGODECMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CGDOPIEDIEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class EOLGOBJAFOC
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint ALBKENLCLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint HGBCIIFGCDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string PGBJGODECMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EOLGOBJAFOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class PMHLEJLKDJC
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string PGBJGODECMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BLJEGJLEKHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7160", VA = "0x180AB8160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA69F60", Offset = "0xA68F60", VA = "0x180A69F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PMHLEJLKDJC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JAOBJOHMHKI GLOAEHBLIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<DNNPDNALDOD> HCBLEKEINLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<POGGKHNPIED> HBGJFHNBJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly AMLLHKHCDME DMDKADFCKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly NIHFFPGGAMD NHIIMKGBLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly PFGCHPOFEDC LDHIKILPLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private MGKADKLNAIK FAPAICMKLHE;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int HHAJMJNLGND = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool BIECAGEPCCE;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7363E90", Offset = "0x7362E90", VA = "0x187363E90")]
	internal ODFKPHHFDMI(JAOBJOHMHKI DOELFPFPAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7363D10", Offset = "0x7362D10", VA = "0x187363D10")]
	internal void MIPODMJHBBE(IPEndPoint KAMJLBJENNF, PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E23140", Offset = "0x3E22140", VA = "0x183E23140")]
	private void GEIODCMLOHE<T>(T CJBPABPKIDK, IPEndPoint AOJAHPGAGPO) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7363A20", Offset = "0x7362A20", VA = "0x187363A20")]
	private void FLHBHALMIHP(CGDOPIEDIEB HOAGMOILDLF, IPEndPoint KAMJLBJENNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7363BB0", Offset = "0x7362BB0", VA = "0x187363BB0")]
	private void HHDLDLAOGLH(EOLGOBJAFOC HOAGMOILDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7363880", Offset = "0x7362880", VA = "0x187363880")]
	private void FANNOKIPFMP(PMHLEJLKDJC HOAGMOILDLF, IPEndPoint KAMJLBJENNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IOIBCGAEOCL : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum MDKJEPCEJJK : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DBPCNIIDKMK
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] GACNLNCLDFG;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int FMLMCEFGBAD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int CBLHNGODHEM;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CPJEAOJPDPA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x734FB60", Offset = "0x734EB60", VA = "0x18734FB60")]
	public CPJEAOJPDPA(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KGFBJMAJLIO : CPJEAOJPDPA
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x734FB60", Offset = "0x734EB60", VA = "0x18734FB60")]
	public KGFBJMAJLIO(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum JKMOEDNHKJG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KACPBONDDHE
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPMPMJNBCIJ(JKMOEDNHKJG EGCMCJPAEFG, string NGKMMOMPFOH, params object[] DELLHDJPKBE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NOKNEDMCNPL
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static KACPBONDDHE CNPHMEGODOH;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object ELHABJJBLLJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x73635A0", Offset = "0x73625A0", VA = "0x1873635A0")]
	private static void OONJOAGPNDM(JKMOEDNHKJG IDNMMNHIJKL, string NGKMMOMPFOH, params object[] DELLHDJPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7363540", Offset = "0x7362540", VA = "0x187363540")]
	internal static void HFNDKHDHHJI(string NGKMMOMPFOH, params object[] DELLHDJPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7363480", Offset = "0x7362480", VA = "0x187363480")]
	internal static void DGLBOPFDBFE(string NGKMMOMPFOH, params object[] DELLHDJPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73634E0", Offset = "0x73624E0", VA = "0x1873634E0")]
	internal static void FKBLCNLIMIK(string NGKMMOMPFOH, params object[] DELLHDJPKBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum MBAHKAAHHNM
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HFGDAGGMJMB : AMLLHKHCDME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private PCPCKKAAELA FEJJNNHGDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly JAOBJOHMHKI CBHAHKIIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly KLDLNFFHHFC PJLFPDGEFBB;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7352DE0", Offset = "0x7351DE0", VA = "0x187352DE0")]
	internal HFGDAGGMJMB(JAOBJOHMHKI PAOKFDJPALE, KLDLNFFHHFC BHEKJKJMJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7352D70", Offset = "0x7351D70", VA = "0x187352D70")]
	internal void MELGLMKLMLG(PCPCKKAAELA CJBPABPKIDK, int KPPPOOBEFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7352CC0", Offset = "0x7351CC0", VA = "0x187352CC0")]
	internal void HANCIJBGKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7352D40", Offset = "0x7351D40", VA = "0x187352D40")]
	public void JGLCCADPNNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class KLDLNFFHHFC
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum LHOHAHMALAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public KLDLNFFHHFC KBDAEPHICEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LHOHAHMALAF HHDOJPCILPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public MOLHAOHJIGG EPJCMLFBPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint KCCHMAOPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object NLPKKOOKIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int ONLNALFCJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError HBLAJNELBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public PKIOAIMGLAI ACLJFEPOMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public GMJMEOAFJEE KKJHELHOONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public IOIBCGAEOCL GDDKHOJPEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte EOBHHNPIDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly HFGDAGGMJMB LAPAFBKBODM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x735B860", Offset = "0x735A860", VA = "0x18735B860")]
	public KLDLNFFHHFC(JAOBJOHMHKI PAOKFDJPALE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JAOBJOHMHKI : IEnumerable<MOLHAOHJIGG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class OPDHNDMOHMD : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73642E0", Offset = "0x73632E0", VA = "0x1873642E0", Slot = "4")]
		public bool Equals(IPEndPoint OEFDFBLCHHF, IPEndPoint GDBEEAKMPMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x44AEFE0", Offset = "0x44ADFE0", VA = "0x1844AEFE0", Slot = "5")]
		public int GetHashCode(IPEndPoint PGIOEBKALDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OPDHNDMOHMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct FCLNENJNOPG : IEnumerator<MOLHAOHJIGG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly MOLHAOHJIGG ECGFLDOILMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private MOLHAOHJIGG IJMKIMEOACP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MOLHAOHJIGG AJOLFNCECJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAEAB70", Offset = "0xAE9B70", VA = "0x180AEAB70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C59620", Offset = "0x1C58620", VA = "0x181C59620")]
		public FCLNENJNOPG(MOLHAOHJIGG GDJJGAEMLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x73501A0", Offset = "0x734F1A0", VA = "0x1873501A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x73501F0", Offset = "0x734F1F0", VA = "0x1873501F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread NKOPLAIFNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool PPOBIIPLHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool GCBCCHMFDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private DMOIFJKJNEM BPPNOPACKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent BAFBNKJPOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<KLDLNFFHHFC> ADMLINLPOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<KLDLNFFHHFC> CAJLPLPHOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private KLDLNFFHHFC PMNGMFLNCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly ECFCPOPNGNE KMDCCOIGLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly GPCJBEPLPMI PEAGDCFDKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly LHJKADOLPIO AHHCJGEBFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly EOJMLKKMEDN GNKONMGDPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, MOLHAOHJIGG> KOGCOKKCCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, GMJMEOAFJEE> CCCNMLMONIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, PHHNHFLDDML> AEPDNLJDDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim BNCGNPIADCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private MOLHAOHJIGG PNOENIPHMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int AKHHEBDDFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<MOLHAOHJIGG> ABBIEHHPHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private MOLHAOHJIGG[] LEEECGOCJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GANDEHKIMBM CCPJLKFGEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int LJLDHCLHKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> KFGNCBDOEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte DOCJNEDNOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object KMIGOEBPKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool AMNFBNEKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool GDLFIGMBBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int MCIJBKOBBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int BJONGOGEMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int KAKHGCEJGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int IOFHGMJGGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool DBMHBMNDDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool JDJIEECHBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NNAEMCFDPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int OPMHDMCANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int MAJFOIDEAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool BIECAGEPCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool EGCPAMMDFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool PNNFHDLDCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool FHIDFGGAKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int GCFDOPGFHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int DDKDCKNKGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool KOLJJFKGADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly GDIPEMDOCEO ICECPBGDEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool AMHHHNFMIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly ODFKPHHFDMI IBDLEFFFKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool MBDNJPHHFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public MBAHKAAHHNM IGLICAHIJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int PDFNGIACNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool OKHACMONOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool GNFMBMAMMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool BOAEINEBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool EMGHOIOIGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PCPCKKAAELA KIMLAHBFPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int MCOAKEJCCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object MNIAGGIHJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PCPCKKAAELA ADBOIANOEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int NMMOMAOPABJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int PEBEGKILPJL = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int PGBOEODFGJJ = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NBNDFJNFFAH CNNHJLMGNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NBNDFJNFFAH EMBFAJHLFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread KBGAMOFKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread CFGPJAAIPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint NOBHNJPPCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint GECGKJFHDOF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] PKKFPKCDFNJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] CEHJBBMNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<CCPEGNLODCP, IPEndPoint> DANNMHJKEFH;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress CKCBOLMBKKE;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool CACAENHOMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int CLKCNHCBHFM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool KKHOOGOMJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBB5A30", Offset = "0xBB4A30", VA = "0x180BB5A30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBB7D90", Offset = "0xBB6D90", VA = "0x180BB7D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AJDDGMDAPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x17A5250", Offset = "0x17A4250", VA = "0x1817A5250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x20B8B50", Offset = "0x20B7B50", VA = "0x1820B8B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte GONEOGDGOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1042FB0", Offset = "0x1041FB0", VA = "0x181042FB0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IEMANDIKEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7358D40", Offset = "0x7357D40", VA = "0x187358D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short MMOJEOFAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x735AC00", Offset = "0x7359C00", VA = "0x18735AC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MOLHAOHJIGG.FNKEDJIIFMJ JGFLIMBNMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7359760", Offset = "0x7358760", VA = "0x187359760")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7357180", Offset = "0x7356180", VA = "0x187357180")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7354360", Offset = "0x7353360", VA = "0x187354360")]
	public void AHFLBJAKKKG(IPEndPoint KPDFNPOOKOJ, byte[] DAKIIEIEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x735ACC0", Offset = "0x7359CC0", VA = "0x18735ACC0")]
	public void PNIKALFBJFC(IPEndPoint KPDFNPOOKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7359990", Offset = "0x7358990", VA = "0x187359990")]
	private bool NOFIBKPJGLP(IPEndPoint KPDFNPOOKOJ, [Out] MOLHAOHJIGG PAJOIEFGIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7355D40", Offset = "0x7354D40", VA = "0x187355D40")]
	private void DJNDLMOKLPA(MOLHAOHJIGG PAJOIEFGIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x73567F0", Offset = "0x73557F0", VA = "0x1873567F0")]
	private void FPEHMJFHODD(MOLHAOHJIGG PAJOIEFGIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x735A250", Offset = "0x7359250", VA = "0x18735A250")]
	private void OBFCMPHIMLG(MOLHAOHJIGG PAJOIEFGIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x735AFF0", Offset = "0x7359FF0", VA = "0x18735AFF0")]
	public JAOBJOHMHKI(ECFCPOPNGNE KBILBMDMHMH, [Optional] GANDEHKIMBM GOGHGLMJIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7356B10", Offset = "0x7355B10", VA = "0x187356B10")]
	internal void GMFPJEOIMFI(MOLHAOHJIGG LEOPHGJAPEC, int KHIEPDPEFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x735A560", Offset = "0x7359560", VA = "0x18735A560")]
	internal void OGBDELLKHEC(MOLHAOHJIGG LEOPHGJAPEC, object HBHKNPFCOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x735A520", Offset = "0x7359520", VA = "0x18735A520")]
	internal void ODGJMHKGHBF(MOLHAOHJIGG PAJOIEFGIDG, PKIOAIMGLAI LPKJHGCILMN, SocketError HOCMKDLFJBN, PCPCKKAAELA PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7358860", Offset = "0x7357860", VA = "0x187358860")]
	private void JGLIFFALCMG(MOLHAOHJIGG PAJOIEFGIDG, PKIOAIMGLAI LPKJHGCILMN, SocketError HOCMKDLFJBN, bool HOJOMGEINAH, byte[] INCJDDLACNP, int LMLEMDDGACN, int MFFPIAPMHCN, PCPCKKAAELA PHDJPEOAFMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7359030", Offset = "0x7358030", VA = "0x187359030")]
	private void MEJDANGEEJA(KLDLNFFHHFC.LHOHAHMALAF BJLNCBFOGNL, [Optional] MOLHAOHJIGG PAJOIEFGIDG, [Optional] IPEndPoint MCPKAMEBJKG, SocketError LEOFMJDKCIM = SocketError.Success, int KHIEPDPEFIJ = 0, PKIOAIMGLAI HEBBIFHLMFG = PKIOAIMGLAI.ConnectionFailed, [Optional] GMJMEOAFJEE BEBGDLKMBPK, IOIBCGAEOCL JPHMMIGPNNG = IOIBCGAEOCL.Unreliable, byte CJPGBMBDJLM = 0, [Optional] PCPCKKAAELA KGKFKNBHFGP, [Optional] object HBHKNPFCOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7357230", Offset = "0x7356230", VA = "0x187357230")]
	private void HPCECNFBMJN(KLDLNFFHHFC BHEKJKJMJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x735A940", Offset = "0x7359940", VA = "0x18735A940")]
	internal void OPEJNCLNPEE(KLDLNFFHHFC BHEKJKJMJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7359410", Offset = "0x7358410", VA = "0x187359410")]
	private void MGCPFAGALCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7357A00", Offset = "0x7356A00", VA = "0x187357A00")]
	private void HPGHKDBJBOJ(int MICGDMIBDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7356B60", Offset = "0x7355B60", VA = "0x187356B60")]
	internal MOLHAOHJIGG GOKOJMGMMGM(GMJMEOAFJEE LIPNPCINFLG, byte[] POPGCPKKOKO, int LMLEMDDGACN, int FCCMJLNEMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7358CC0", Offset = "0x7357CC0", VA = "0x187358CC0")]
	private int JMPODLIADJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7357EA0", Offset = "0x7356EA0", VA = "0x187357EA0")]
	private void IDGANENNKGF(IPEndPoint MCPKAMEBJKG, MOLHAOHJIGG MNBNEOOICAE, KMPABPIHLLK PJIPOMDCNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7354950", Offset = "0x7353950", VA = "0x187354950")]
	private void DBGKGFFJCCP(PCPCKKAAELA CJBPABPKIDK, IPEndPoint MCPKAMEBJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7353630", Offset = "0x7352630", VA = "0x187353630")]
	internal void AAIAICLAEPA(PCPCKKAAELA CJBPABPKIDK, IOIBCGAEOCL JFPLGEEKCOD, byte CJPGBMBDJLM, int KPPPOOBEFGD, MOLHAOHJIGG LEOPHGJAPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7353AE0", Offset = "0x7352AE0", VA = "0x187353AE0")]
	public bool AGMPLOGOAAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x73542C0", Offset = "0x73532C0", VA = "0x1873542C0")]
	public bool AGMPLOGOAAB(IPAddress IDMJJGIEJHA, IPAddress HBBJDJMPDMK, int DOIABPONBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73542E0", Offset = "0x73532E0", VA = "0x1873542E0")]
	public bool AGMPLOGOAAB(int DOIABPONBBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x735AA50", Offset = "0x7359A50", VA = "0x18735AA50")]
	public void PHEKLJBFJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7356560", Offset = "0x7355560", VA = "0x187356560")]
	public MOLHAOHJIGG EHPNKKJDIMD(string CCNGABFELGK, int DOIABPONBBD, string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73560A0", Offset = "0x73550A0", VA = "0x1873560A0")]
	public MOLHAOHJIGG EHPNKKJDIMD(string CCNGABFELGK, int DOIABPONBBD, NIHFFPGGAMD GDOPFEGDJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7356180", Offset = "0x7355180", VA = "0x187356180")]
	public MOLHAOHJIGG EHPNKKJDIMD(IPEndPoint AOJAHPGAGPO, NIHFFPGGAMD GDOPFEGDJFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73586B0", Offset = "0x73576B0", VA = "0x1873586B0")]
	public void ILACAOECPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7358350", Offset = "0x7357350", VA = "0x187358350")]
	public void ILACAOECPPO(bool FJGKOFENLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7357DF0", Offset = "0x7356DF0", VA = "0x187357DF0")]
	public void IBDOPEBAKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7357D20", Offset = "0x7356D20", VA = "0x187357D20")]
	public void IBDOPEBAKGN(byte[] INCJDDLACNP, int LMLEMDDGACN, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7358C80", Offset = "0x7357C80", VA = "0x187358C80")]
	public void JGLIFFALCMG(MOLHAOHJIGG PAJOIEFGIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7358820", Offset = "0x7357820", VA = "0x187358820")]
	public void JGLIFFALCMG(MOLHAOHJIGG PAJOIEFGIDG, byte[] INCJDDLACNP, int LMLEMDDGACN, int MFFPIAPMHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x735AE10", Offset = "0x7359E10", VA = "0x18735AE10", Slot = "4")]
	private IEnumerator<MOLHAOHJIGG> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x735AEA0", Offset = "0x7359EA0", VA = "0x18735AEA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7353910", Offset = "0x7352910", VA = "0x187353910")]
	private PCPCKKAAELA AANMINDOGMB(DKNOOPBLOFE EKGLNGMKMKH, int BKLOHAHJLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7353A00", Offset = "0x7352A00", VA = "0x187353A00")]
	private PCPCKKAAELA AANMINDOGMB(DKNOOPBLOFE EKGLNGMKMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7354700", Offset = "0x7353700", VA = "0x187354700")]
	internal PCPCKKAAELA CLKGHPCBJID(int BKLOHAHJLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7358DC0", Offset = "0x7357DC0", VA = "0x187358DC0")]
	internal void LOEFKDPOOOK(PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x735AF30", Offset = "0x7359F30", VA = "0x18735AF30")]
	static JAOBJOHMHKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBB5A30", Offset = "0xBB4A30", VA = "0x180BB5A30")]
	private bool BCOFOAOJDKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7354580", Offset = "0x7353580", VA = "0x187354580")]
	private void BEEFJKDNKKK(IPEndPoint HENLNBDAKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73586C0", Offset = "0x73576C0", VA = "0x1873586C0")]
	private void IOPKONJFNIP(IPEndPoint HENLNBDAKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7356640", Offset = "0x7355640", VA = "0x187356640")]
	private bool FNMNAGPAJGK(SocketException MMCKGPNIIIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7356080", Offset = "0x7355080", VA = "0x187356080")]
	private void DLMKMNAJFKB(DMOIFJKJNEM DOELFPFPAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7356850", Offset = "0x7355850", VA = "0x187356850")]
	private void GHOGANDHJDJ(NBNDFJNFFAH DOELFPFPAJL, EndPoint JKNCLOFANLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x735A5B0", Offset = "0x73595B0", VA = "0x18735A5B0")]
	private void OGMCMKMLDGM(object GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7353AF0", Offset = "0x7352AF0", VA = "0x187353AF0")]
	public bool AGMPLOGOAAB(IPAddress IDMJJGIEJHA, IPAddress HBBJDJMPDMK, int DOIABPONBBD, bool LLHKOIAFHOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7358D60", Offset = "0x7357D60", VA = "0x187358D60")]
	internal int LLIHKCGILLL(PCPCKKAAELA CJBPABPKIDK, IPEndPoint MCPKAMEBJKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x735A210", Offset = "0x7359210", VA = "0x18735A210")]
	internal int NOFOBKLJELF(PCPCKKAAELA CJBPABPKIDK, IPEndPoint MCPKAMEBJKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7359A30", Offset = "0x7358A30", VA = "0x187359A30")]
	internal int NOFOBKLJELF(byte[] OBCNAJEENCI, int LMLEMDDGACN, int FCCMJLNEMIB, IPEndPoint MCPKAMEBJKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7359810", Offset = "0x7358810", VA = "0x187359810")]
	internal void NLILAIBOBMA(bool DNKAMKEEFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum DKNOOPBLOFE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class PCPCKKAAELA
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int DIENHHEIFEJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] NFFPFFCIMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] MMNKJGMLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int GEDPMFLNHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object NLPKKOOKIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public PCPCKKAAELA KBDAEPHICEN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public DKNOOPBLOFE JFAMMMJCEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x73648A0", Offset = "0x73638A0", VA = "0x1873648A0")]
		get
		{
			return default(DKNOOPBLOFE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x73643B0", Offset = "0x73633B0", VA = "0x1873643B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte DAIANNAMJAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7364830", Offset = "0x7363830", VA = "0x187364830")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73643F0", Offset = "0x73633F0", VA = "0x1873643F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort AFCNIHKEIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7364600", Offset = "0x7363600", VA = "0x187364600")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7364900", Offset = "0x7363900", VA = "0x187364900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MKOGAOBHOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x73648D0", Offset = "0x73638D0", VA = "0x1873648D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte DONKAJNKHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7364760", Offset = "0x7363760", VA = "0x187364760")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7364940", Offset = "0x7363940", VA = "0x187364940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort GBNCFOAFABB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7364350", Offset = "0x7363350", VA = "0x187364350")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7364860", Offset = "0x7363860", VA = "0x187364860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort PLBOHPOKGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x73647D0", Offset = "0x73637D0", VA = "0x1873647D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x73644C0", Offset = "0x73634C0", VA = "0x1873644C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort EOIPGFBCIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7364430", Offset = "0x7363430", VA = "0x187364430")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7364790", Offset = "0x7363790", VA = "0x187364790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7364970", Offset = "0x7363970", VA = "0x187364970")]
	static PCPCKKAAELA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7364490", Offset = "0x7363490", VA = "0x187364490")]
	public void DNNKIBGAOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7364C50", Offset = "0x7363C50", VA = "0x187364C50")]
	public PCPCKKAAELA(int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7364CC0", Offset = "0x7363CC0", VA = "0x187364CC0")]
	public PCPCKKAAELA(DKNOOPBLOFE EKGLNGMKMKH, int BKLOHAHJLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7364590", Offset = "0x7363590", VA = "0x187364590")]
	public static int EBOANIMILIN(DKNOOPBLOFE EKGLNGMKMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7364500", Offset = "0x7363500", VA = "0x187364500")]
	public int EBOANIMILIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7364660", Offset = "0x7363660", VA = "0x187364660")]
	public bool HINFGPJNPAB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum ODPBNCNNCOL : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum FCPLENFIDOL
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum BGDOMLLAFDF
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum EPMCGMHBCMB
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MOLHAOHJIGG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class EBLNPPMBMJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public PCPCKKAAELA[] FGDOJMHPJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int IIMHJLJEHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int NIOEHDBLFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte DONKAJNKHNF;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public EBLNPPMBMJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void FNKEDJIIFMJ(ulong CGJAADAMNAJ, int LOMGLKPGKAE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int HFFNOPHOLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KKOKDMFMOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int NEMKEADDIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double ABDLBNLBEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int EBHGEBBNLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int MOHNPEGGPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int DNKFLMBHHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch DOMPOOGEKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int EKCDJGBHIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long EIFCFHEAHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object POLOILPHOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal MOLHAOHJIGG PPPAGJHEHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal MOLHAOHJIGG ALOPKJKIIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<PCPCKKAAELA> OBNDDLLDJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<JKLKEIBPBAI> JGCMEMPHCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly JKLKEIBPBAI[] LFJHBKPDNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int CLKABAPBALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PJFPOJAOCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool FFDCHGFFKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int PEHDPHJNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int NMBFAOPFKJL;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int CLMBDBFBJMN = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int JJEIMHAPMOG = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object PNNCOPHCDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int NDMNONKJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, EBLNPPMBMJN> CPLIBPAFPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> AABDBDBNLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly PCPCKKAAELA KPHBNLHBODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HJLCNCCDLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int GFHGJNOEONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint MCGHIBECMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int AMFDJJPPKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int FPKIILLHNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long NJNJHJIHOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte HFOMAJKFIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private ODPBNCNNCOL AJDIJBMAICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PCPCKKAAELA EKBINNNOAGJ;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int CMEHMLCNEMO = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int EMNDPJBAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly PCPCKKAAELA PFAJCECLDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly PCPCKKAAELA IFHIHOOBKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly PCPCKKAAELA HKMAHGDNHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly PCPCKKAAELA EEBDCAOIKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private MDKJEPCEJJK NKABIIABHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly JAOBJOHMHKI KDPCCBNODND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int CMGKJAEFCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object GBJAIFIDHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly GDIPEMDOCEO ICECPBGDEPK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte BHMLHCHBDDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB11FF0", Offset = "0xB10FF0", VA = "0x180B11FF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x735FBD0", Offset = "0x735EBD0", VA = "0x18735FBD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint ELEIEMCPJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB12240", Offset = "0xB11240", VA = "0x180B12240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ODPBNCNNCOL KCHLEMMHABF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB12090", Offset = "0xB11090", VA = "0x180B12090")]
		get
		{
			return default(ODPBNCNNCOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long OJADJNNAOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA62870", Offset = "0xA61870", VA = "0x180A62870")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GPAKKEIDKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x17A5250", Offset = "0x17A4250", VA = "0x1817A5250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x20B8B50", Offset = "0x20B7B50", VA = "0x1820B8B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int BHNMFCDAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7361790", Offset = "0x7360790", VA = "0x187361790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int OOJPAENHGLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xD16000", Offset = "0xD15000", VA = "0x180D16000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double EGDFONOOMIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x50C8B40", Offset = "0x50C7B40", VA = "0x1850C8B40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event FNKEDJIIFMJ JGFLIMBNMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x73601C0", Offset = "0x735F1C0", VA = "0x1873601C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x735FC80", Offset = "0x735EC80", VA = "0x18735FC80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7361FF0", Offset = "0x7360FF0", VA = "0x187361FF0")]
	internal MOLHAOHJIGG(JAOBJOHMHKI AKBLGGEEFOH, IPEndPoint MCPKAMEBJKG, int PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7360170", Offset = "0x735F170", VA = "0x187360170")]
	internal void LINCJEOKBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7360190", Offset = "0x735F190", VA = "0x187360190")]
	internal void MAGCCEPJGPB(IPEndPoint EFKGCOGEELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x735F850", Offset = "0x735E850", VA = "0x18735F850")]
	internal void FGKLDJOGMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x735FEF0", Offset = "0x735EEF0", VA = "0x18735FEF0")]
	private void JLPEAHDFHNN(int BNAOOALEDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x735F1B0", Offset = "0x735E1B0", VA = "0x18735F1B0")]
	private void ECAKOGJNLJF(int GIOIMGKHKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x735ECA0", Offset = "0x735DCA0", VA = "0x18735ECA0")]
	public int CFBNFKJCOIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x735EDB0", Offset = "0x735DDB0", VA = "0x18735EDB0")]
	public int CFBNFKJCOIE(byte CJPGBMBDJLM, bool CBLHLBBMCCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x735FFC0", Offset = "0x735EFC0", VA = "0x18735FFC0")]
	private JKLKEIBPBAI LHAIMLGFCGF(byte LFBGKHDOJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7361E60", Offset = "0x7360E60", VA = "0x187361E60")]
	internal MOLHAOHJIGG(JAOBJOHMHKI AKBLGGEEFOH, IPEndPoint MCPKAMEBJKG, int PBJHGGBBAAF, byte NHFFHCCOEGH, NIHFFPGGAMD COLGHDHBOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7362450", Offset = "0x7361450", VA = "0x187362450")]
	internal MOLHAOHJIGG(JAOBJOHMHKI AKBLGGEEFOH, GMJMEOAFJEE LIPNPCINFLG, int PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x735F160", Offset = "0x735E160", VA = "0x18735F160")]
	internal void EBNAHJLEBLN(KMPABPIHLLK GGODEKHPOEI, byte[] INCJDDLACNP, int LMLEMDDGACN, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x735F0E0", Offset = "0x735E0E0", VA = "0x18735F0E0")]
	internal bool DBCDGHNPBHD(EPGOLFIPCGO CJBPABPKIDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x735F8E0", Offset = "0x735E8E0", VA = "0x18735F8E0")]
	public void GEIODCMLOHE(byte[] INCJDDLACNP, int LMLEMDDGACN, int FCCMJLNEMIB, IOIBCGAEOCL EGBMNBJEHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x735F1F0", Offset = "0x735E1F0", VA = "0x18735F1F0")]
	private void ECHPAADCNOI(byte[] INCJDDLACNP, int LMLEMDDGACN, int FCCMJLNEMIB, byte CJPGBMBDJLM, IOIBCGAEOCL JPHMMIGPNNG, object HBHKNPFCOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x735F800", Offset = "0x735E800", VA = "0x18735F800")]
	public void EMGOHOCPKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x735EB80", Offset = "0x735DB80", VA = "0x18735EB80")]
	internal BGDOMLLAFDF BDPIDHKEONI(PCPCKKAAELA CJBPABPKIDK)
	{
		return default(BGDOMLLAFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7361730", Offset = "0x7360730", VA = "0x187361730")]
	internal void PBDENAAHGEN(JKLKEIBPBAI JHPFOADKPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7360C10", Offset = "0x735FC10", VA = "0x187360C10")]
	internal EPMCGMHBCMB NIIEIPPPGNL(byte[] INCJDDLACNP, int LMLEMDDGACN, int FCCMJLNEMIB, bool HOJOMGEINAH)
	{
		return default(EPMCGMHBCMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x735EC60", Offset = "0x735DC60", VA = "0x18735EC60")]
	private void BNPMJGBAGEB(int DAOHJBFOJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7360270", Offset = "0x735F270", VA = "0x187360270")]
	internal void MLPCHFHNJAK(IOIBCGAEOCL JFPLGEEKCOD, PCPCKKAAELA GDJJGAEMLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x735E610", Offset = "0x735D610", VA = "0x18735E610")]
	private void BCDOIAKMDHH(PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x735E280", Offset = "0x735D280", VA = "0x18735E280")]
	private void ALFBKPDAONK(int PFFBKHOBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x735FD30", Offset = "0x735ED30", VA = "0x18735FD30")]
	internal FCPLENFIDOL IDGANENNKGF(KMPABPIHLLK PJIPOMDCNMG)
	{
		return default(FCPLENFIDOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7361070", Offset = "0x7360070", VA = "0x187361070")]
	internal void PBDCJJBPPPD(PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7360F20", Offset = "0x735FF20", VA = "0x187360F20")]
	private void OIAMHICLBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x735EED0", Offset = "0x735DED0", VA = "0x18735EED0")]
	internal void CIAGGACAFHH(PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x73617A0", Offset = "0x73607A0", VA = "0x1873617A0")]
	internal void PHBANHJIEKG(int PFFBKHOBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x735F910", Offset = "0x735E910", VA = "0x18735F910")]
	internal void GFOKLAMAOJK(PCPCKKAAELA CJBPABPKIDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class GDIPEMDOCEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long FGKGHPNDNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long JIDGLDKNGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long AHKIJLKHODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long DJOBOPCMAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long EPFCLDDIEAE;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long DPKCEMJMBOG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long JAFALPJHGCK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long HFLALKIPLGO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long CHLGNBFIMKD;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long HGKNPGIPJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long OLJILECIMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long FILGFJNIKLE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long FDOFHLOJGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x73513B0", Offset = "0x73503B0", VA = "0x1873513B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FEIFCEDDAOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7351030", Offset = "0x7350030", VA = "0x187351030")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long NJHBEPHOGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7351020", Offset = "0x7350020", VA = "0x187351020")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LDHPABINFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x73511C0", Offset = "0x73501C0", VA = "0x1873511C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long ODHAPJIKDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7351010", Offset = "0x7350010", VA = "0x187351010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long OPICIOCKDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7351040", Offset = "0x7350040", VA = "0x187351040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long KNKFIJANOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x73512A0", Offset = "0x73502A0", VA = "0x1873512A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long EBPKGBJKJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7351120", Offset = "0x7350120", VA = "0x187351120")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private MDKJEPCEJJK NOLPFAAIKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1353980", Offset = "0x1352980", VA = "0x181353980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double IOGBCDLCBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7351160", Offset = "0x7350160", VA = "0x187351160")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7350FD0", Offset = "0x734FFD0", VA = "0x187350FD0")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7351350", Offset = "0x7350350", VA = "0x187351350")]
	public void MMMOMHCDCDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7351050", Offset = "0x7350050", VA = "0x187351050")]
	public void FJAHIICAPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7351230", Offset = "0x7350230", VA = "0x187351230")]
	public void JFFIPPCBGLJ(long JBMDAAAGKAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x73512E0", Offset = "0x73502E0", VA = "0x1873512E0")]
	public void KOCEHIKFKNM(long GJBKKMJJGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x73511D0", Offset = "0x73501D0", VA = "0x1873511D0")]
	public void JCOODLKBIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x73510A0", Offset = "0x73500A0", VA = "0x1873510A0")]
	public void FJGOEGIFEIB(long COCEMHFOJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7351460", Offset = "0x7350460", VA = "0x187351460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x73513C0", Offset = "0x73503C0", VA = "0x1873513C0")]
	public void OLMIKKEHDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public GDIPEMDOCEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class FMNAJLFOFEJ
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> GMDGIHDBBMB;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7350A60", Offset = "0x734FA60", VA = "0x187350A60")]
	public static IPEndPoint ABFJBEKCPLO(string ADCEHGNJKAI, int DOIABPONBBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7350CB0", Offset = "0x734FCB0", VA = "0x187350CB0")]
	public static IPAddress KBIOAPKENEI(string ADCEHGNJKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7350E80", Offset = "0x734FE80", VA = "0x187350E80")]
	public static IPAddress KBIOAPKENEI(string ADCEHGNJKAI, AddressFamily BHHFDICMDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7350F10", Offset = "0x734FF10", VA = "0x187350F10")]
	internal static int MOGMCKFODDI(int IHBDNJAFEOL, int IOMFMJOJHKN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3C45120", Offset = "0x3C44120", VA = "0x183C45120")]
	internal static T[] FIDICCLJEAG<T>(int MFFPIAPMHCN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class AKPMCLFOFCO : JKLKEIBPBAI
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct MANGKEAKFCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private PCPCKKAAELA FEJJNNHGDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long CPLGEJLMGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool IEOIILNFPIJ;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x735D6C0", Offset = "0x735C6C0", VA = "0x18735D6C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x735D6A0", Offset = "0x735C6A0", VA = "0x18735D6A0")]
		public void LMCEEELLBNF(PCPCKKAAELA CJBPABPKIDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x735D5E0", Offset = "0x735C5E0", VA = "0x18735D5E0")]
		public bool DOIHACDHLCB(long KPMJMLPKHME, MOLHAOHJIGG PAJOIEFGIDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x735D650", Offset = "0x735C650", VA = "0x18735D650")]
		public bool JPJFAMEFLHG(MOLHAOHJIGG PAJOIEFGIDG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly PCPCKKAAELA IAPOAFEDIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly MANGKEAKFCG[] FPNKPJBKICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly PCPCKKAAELA[] BONCDFFBBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] PILBHCBJDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int BKOJJDGADKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int EJHJIIAMEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int EEALAHPOJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int MMPDHAKKFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool FDLOECOBJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly IOIBCGAEOCL JCFLLEGHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool EGHLEJGNFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int LCHJMAFIENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte LENLNNJHKAE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EOBAKENNELL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x734D1A0", Offset = "0x734C1A0", VA = "0x18734D1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x734E0A0", Offset = "0x734D0A0", VA = "0x18734E0A0")]
	public AKPMCLFOFCO(MOLHAOHJIGG PAJOIEFGIDG, bool CBLHLBBMCCG, byte PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x734D1B0", Offset = "0x734C1B0", VA = "0x18734D1B0")]
	private void FECJCENIJDN(PCPCKKAAELA CJBPABPKIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x734D570", Offset = "0x734C570", VA = "0x18734D570", Slot = "4")]
	protected override bool GAKKIAHHBBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x734DA40", Offset = "0x734CA40", VA = "0x18734DA40", Slot = "5")]
	public override bool PBDCJJBPPPD(PCPCKKAAELA CJBPABPKIDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class BKEAAOBKOEG : JKLKEIBPBAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int MPHJBOLNNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort EJHJIIAMEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool JMDAHBKLCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private PCPCKKAAELA KIOKDFODCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly PCPCKKAAELA AGKLPMKOGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool MPCHGGBAHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte LENLNNJHKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long IOJNBKANPFC;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x734F680", Offset = "0x734E680", VA = "0x18734F680")]
	public BKEAAOBKOEG(MOLHAOHJIGG PAJOIEFGIDG, bool KBMAAHNKBIL, byte PBJHGGBBAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x734EEE0", Offset = "0x734DEE0", VA = "0x18734EEE0", Slot = "4")]
	protected override bool GAKKIAHHBBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x734F3A0", Offset = "0x734E3A0", VA = "0x18734F3A0", Slot = "5")]
	public override bool PBDCJJBPPPD(PCPCKKAAELA CJBPABPKIDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class EDHDDFDJJPM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct KNNGFDBLJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong DIOEBDOCFGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double ACOEEGMPEFI;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct CCCAPOJEMCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int GPJBPKBOILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float ALHGJHDMMAP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x734CB20", Offset = "0x734BB20", VA = "0x18734CB20")]
	private static void DMLGCFKFJFP(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, ulong INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x734FCF0", Offset = "0x734ECF0", VA = "0x18734FCF0")]
	private static void DMLGCFKFJFP(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, int INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x734FCB0", Offset = "0x734ECB0", VA = "0x18734FCB0")]
	public static void DMLGCFKFJFP(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, short INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x734FD70", Offset = "0x734ED70", VA = "0x18734FD70")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, double IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x734FD90", Offset = "0x734ED90", VA = "0x18734FD90")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x734FCB0", Offset = "0x734ECB0", VA = "0x18734FCB0")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, short IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x734FCB0", Offset = "0x734ECB0", VA = "0x18734FCB0")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, ushort IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x734FCF0", Offset = "0x734ECF0", VA = "0x18734FCF0")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x734FCF0", Offset = "0x734ECF0", VA = "0x18734FCF0")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, uint IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x734FD60", Offset = "0x734ED60", VA = "0x18734FD60")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x734FD60", Offset = "0x734ED60", VA = "0x18734FD60")]
	public static void LAAIBGPJDFB(byte[] ODOOLGJOBIG, int OBJODNIPNPB, ulong IOALKPFEKEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class AMLLHKHCDME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] LGHFMHICOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int KGBKIDEBHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int NCNDKEEELJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int AJICIBJGLJJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] MMNKJGMLKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DAMBPHLABON
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int AOGLLDDGHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x734E720", Offset = "0x734D720", VA = "0x18734E720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IICNILBEGPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2906C80", Offset = "0x2905C80", VA = "0x182906C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GJPAAMNABDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x734EA60", Offset = "0x734DA60", VA = "0x18734EA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x734ECB0", Offset = "0x734DCB0", VA = "0x18734ECB0")]
	public void MELGLMKLMLG(byte[] MKOOPFGGHLN, int MOAJDMPNBPN, int JJJDNDPMGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public AMLLHKHCDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x734EE80", Offset = "0x734DE80", VA = "0x18734EE80")]
	public AMLLHKHCDME(byte[] MKOOPFGGHLN, int MOAJDMPNBPN, int JJJDNDPMGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x734ECF0", Offset = "0x734DCF0", VA = "0x18734ECF0")]
	public IPEndPoint NGJHGAJJNKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x734EDC0", Offset = "0x734DDC0", VA = "0x18734EDC0")]
	public byte PJNLIFGJOAO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x734EDC0", Offset = "0x734DDC0", VA = "0x18734EDC0")]
	public sbyte NPAHECPFFBH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x31ABBE0", Offset = "0x31AABE0", VA = "0x1831ABBE0")]
	public T[] GKJEAFPIKDM<T>(ushort BKLOHAHJLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x734EB50", Offset = "0x734DB50", VA = "0x18734EB50")]
	public bool[] KFCIKCLPONH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x734EE00", Offset = "0x734DE00", VA = "0x18734EE00")]
	public ushort[] NPDKJNANNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x734E3C0", Offset = "0x734D3C0", VA = "0x18734E3C0")]
	public short[] AIMDLIIBKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x734EAF0", Offset = "0x734DAF0", VA = "0x18734EAF0")]
	public int[] JDPEFFFCEAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x734E6E0", Offset = "0x734D6E0", VA = "0x18734E6E0")]
	public uint[] EJGNADNJFHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x734E630", Offset = "0x734D630", VA = "0x18734E630")]
	public float[] EBCIHJILHAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x734E730", Offset = "0x734D730", VA = "0x18734E730")]
	public double[] FBGKAGOBPJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x734EA70", Offset = "0x734DA70", VA = "0x18734EA70")]
	public long[] HFMFKJACGBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x734EAB0", Offset = "0x734DAB0", VA = "0x18734EAB0")]
	public ulong[] IHIPEPBJKCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x734E270", Offset = "0x734D270", VA = "0x18734E270")]
	public string[] ACNPNKDFKHE(int AFFLLAIGBHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x734EC70", Offset = "0x734DC70", VA = "0x18734EC70")]
	public bool LGCAGGOGOJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x734E470", Offset = "0x734D470", VA = "0x18734E470")]
	public char ANDGCEEKJLC()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x734E470", Offset = "0x734D470", VA = "0x18734E470")]
	public ushort CICBNHLBHBG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x734E400", Offset = "0x734D400", VA = "0x18734E400")]
	public short AMEDHBFIEOC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x734E670", Offset = "0x734D670", VA = "0x18734E670")]
	public long ECAGAIGMAGD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x734EC00", Offset = "0x734DC00", VA = "0x18734EC00")]
	public ulong LCINBLIFPAB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x734EB90", Offset = "0x734DB90", VA = "0x18734EB90")]
	public int KGOIOHPOBHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x734E9F0", Offset = "0x734D9F0", VA = "0x18734E9F0")]
	public uint GCNDDOFOELP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x734E5C0", Offset = "0x734D5C0", VA = "0x18734E5C0")]
	public float DDGOHKMNDIP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x734E550", Offset = "0x734D550", VA = "0x18734E550")]
	public double CJHACBNLBNA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x734E770", Offset = "0x734D770", VA = "0x18734E770")]
	public string FDBNBOEKDCK(int KILNJGPIIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x734E4E0", Offset = "0x734D4E0", VA = "0x18734E4E0")]
	public ArraySegment<byte> CFMLKEFLKMN(int MFFPIAPMHCN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x734EE40", Offset = "0x734DE40", VA = "0x18734EE40")]
	public sbyte[] OAEHEFKBIGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x734E9B0", Offset = "0x734D9B0", VA = "0x18734E9B0")]
	public byte[] FLGLIMBCGPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x734EB30", Offset = "0x734DB30", VA = "0x18734EB30")]
	public void JPJFAMEFLHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NIHFFPGGAMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] LGHFMHICOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int KGBKIDEBHCP;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int IMNNLMNPDEC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool DFALJNCKHNM;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding BNGJFFDELMC;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int HCJDJCBKLIL = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] FAJIEKGIKLK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] FGNOGEEOKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BJKDLCPHPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA6A700", Offset = "0xA69700", VA = "0x180A6A700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7363360", Offset = "0x7362360", VA = "0x187363360")]
	public NIHFFPGGAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x73633E0", Offset = "0x73623E0", VA = "0x1873633E0")]
	public NIHFFPGGAMD(bool OAMBBNNFBNL, int KDIBEELIFLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7363260", Offset = "0x7362260", VA = "0x187363260")]
	public static NIHFFPGGAMD MNPICENAOBH(string IOALKPFEKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7362630", Offset = "0x7361630", VA = "0x187362630")]
	public void EHHAGNKNLIA(int IOFDJCFHBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2980B30", Offset = "0x297FB30", VA = "0x182980B30")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7363100", Offset = "0x7362100", VA = "0x187363100")]
	public void MLFBEPBEBNB(float IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x73631A0", Offset = "0x73621A0", VA = "0x1873631A0")]
	public void MLFBEPBEBNB(double IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7362D70", Offset = "0x7361D70", VA = "0x187362D70")]
	public void MLFBEPBEBNB(long IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7362D70", Offset = "0x7361D70", VA = "0x187362D70")]
	public void MLFBEPBEBNB(ulong IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7362CE0", Offset = "0x7361CE0", VA = "0x187362CE0")]
	public void MLFBEPBEBNB(int IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7362CE0", Offset = "0x7361CE0", VA = "0x187362CE0")]
	public void MLFBEPBEBNB(uint IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7362C00", Offset = "0x7361C00", VA = "0x187362C00")]
	public void MLFBEPBEBNB(char IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7362C00", Offset = "0x7361C00", VA = "0x187362C00")]
	public void MLFBEPBEBNB(ushort IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7362C00", Offset = "0x7361C00", VA = "0x187362C00")]
	public void MLFBEPBEBNB(short IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7362DC0", Offset = "0x7361DC0", VA = "0x187362DC0")]
	public void MLFBEPBEBNB(sbyte IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7362DC0", Offset = "0x7361DC0", VA = "0x187362DC0")]
	public void MLFBEPBEBNB(byte IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7362C70", Offset = "0x7361C70", VA = "0x187362C70")]
	public void MLFBEPBEBNB(byte[] INCJDDLACNP, int MOAJDMPNBPN, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x73626D0", Offset = "0x73616D0", VA = "0x1873626D0")]
	public void HGODBJHHAOI(sbyte[] INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x73626D0", Offset = "0x73616D0", VA = "0x1873626D0")]
	public void JGOJDIHLBDD(byte[] INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7363200", Offset = "0x7362200", VA = "0x187363200")]
	public void MLFBEPBEBNB(bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7362890", Offset = "0x7361890", VA = "0x187362890")]
	public void MALMLIBPGNO(Array CAJHHKCJGAH, int CANPAGCLIIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x73627B0", Offset = "0x73617B0", VA = "0x1873627B0")]
	public void MALMLIBPGNO(float[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7362970", Offset = "0x7361970", VA = "0x187362970")]
	public void MALMLIBPGNO(double[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7362970", Offset = "0x7361970", VA = "0x187362970")]
	public void MALMLIBPGNO(long[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7362970", Offset = "0x7361970", VA = "0x187362970")]
	public void MALMLIBPGNO(ulong[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x73627B0", Offset = "0x73617B0", VA = "0x1873627B0")]
	public void MALMLIBPGNO(int[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x73627B0", Offset = "0x73617B0", VA = "0x1873627B0")]
	public void MALMLIBPGNO(uint[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7362B20", Offset = "0x7361B20", VA = "0x187362B20")]
	public void MALMLIBPGNO(ushort[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7362B20", Offset = "0x7361B20", VA = "0x187362B20")]
	public void MALMLIBPGNO(short[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73626D0", Offset = "0x73616D0", VA = "0x1873626D0")]
	public void MALMLIBPGNO(bool[] IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7362A50", Offset = "0x7361A50", VA = "0x187362A50")]
	public void MALMLIBPGNO(string[] IOALKPFEKEK, int OLBHJKKGEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7363030", Offset = "0x7362030", VA = "0x187363030")]
	public void MLFBEPBEBNB(IPEndPoint KPDFNPOOKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x73631F0", Offset = "0x73621F0", VA = "0x1873631F0")]
	public void MLFBEPBEBNB(string IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7362E20", Offset = "0x7361E20", VA = "0x187362E20")]
	public void MLFBEPBEBNB(string IOALKPFEKEK, int KILNJGPIIOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class PFGCHPOFEDC
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class COJDPEAAAPP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong CMGKJAEFCGA;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6995310", Offset = "0x6994310", VA = "0x186995310")]
		static COJDPEAAAPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void CPHMMNEPCHF(AMLLHKHCDME AMPJMGIAGBB, object HBHKNPFCOFO);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class FOBNKJHIEBM<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public PFGCHPOFEDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public FOBNKJHIEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4DB48E0", Offset = "0x4DB38E0", VA = "0x184DB48E0")]
		internal void OGJMJCMFEIE(AMLLHKHCDME reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class PALKKNEEPKD<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public PFGCHPOFEDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public PALKKNEEPKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5A1DA90", Offset = "0x5A1CA90", VA = "0x185A1DA90")]
		internal void OGJMJCMFEIE(AMLLHKHCDME reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly AIMPELDACDB MKBKJOIKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, CPHMMNEPCHF> DGNENDIKKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly NIHFFPGGAMD NDHKNMJOLDM;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7364FD0", Offset = "0x7363FD0", VA = "0x187364FD0")]
	public PFGCHPOFEDC(int AFFLLAIGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C1B0", Offset = "0x3A3B1B0", VA = "0x183A3C1B0", Slot = "4")]
	protected virtual ulong GPDPLJBMEJC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7364EA0", Offset = "0x7363EA0", VA = "0x187364EA0", Slot = "5")]
	protected virtual CPHMMNEPCHF NOCFHDOEGGJ(AMLLHKHCDME AMPJMGIAGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3E384C0", Offset = "0x3E374C0", VA = "0x183E384C0", Slot = "6")]
	protected virtual void PBNLDBLEEAO<T>(NIHFFPGGAMD NMCAGOGLPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7364E20", Offset = "0x7363E20", VA = "0x187364E20")]
	public void LKFAEFEJDOB(AMLLHKHCDME AMPJMGIAGBB, object HBHKNPFCOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3E38430", Offset = "0x3E37430", VA = "0x183E38430")]
	public void KENBDFDJMJH<T>(NIHFFPGGAMD NMCAGOGLPLD, T CJBPABPKIDK) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7364DD0", Offset = "0x7363DD0", VA = "0x187364DD0")]
	public void CJDMPJKGAML(AMLLHKHCDME AMPJMGIAGBB, object HBHKNPFCOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3E386B0", Offset = "0x3E376B0", VA = "0x183E386B0")]
	public void PCBDKJGGFJK<T>(Action<T> CLLBDKGDJKB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3E38530", Offset = "0x3E37530", VA = "0x183E38530")]
	public void PCBDKJGGFJK<T, TUserData>(Action<T, TUserData> CLLBDKGDJKB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NHHAGLPEPOL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x734FB60", Offset = "0x734EB60", VA = "0x18734FB60")]
	public NHHAGLPEPOL(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class DDNFLMNKBLP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x734FC50", Offset = "0x734EC50", VA = "0x18734FC50")]
	public DDNFLMNKBLP(string OBCNAJEENCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class AIMPELDACDB
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum MOLMCJFNFIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class HFKFIHCEIIN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public MOLMCJFNFIK HHDOJPCILPE;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A480", Offset = "0x4F39480", VA = "0x184F3A480", Slot = "4")]
		public virtual void LMCEEELLBNF(MethodInfo ANFGAKJLBHE, MethodInfo ANPNEJINGPO, MOLMCJFNFIK BJLNCBFOGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JHDHIEHBDGL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JFNAKFDPNAK(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		protected HFKFIHCEIIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class DGADIIFMGIP<TClass, TProperty> : HFKFIHCEIIN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> ODNIGAAELPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> MEFKEBBCOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> BNJDNNGKJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> LHOLKGNIDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> LPFPFDMNECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> MDAOILGLNHH;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BC20", Offset = "0x6E8AC20", VA = "0x186E8BC20", Slot = "7")]
		public override void NDOAMFKMFON(TClass MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6E883B0", Offset = "0x6E873B0", VA = "0x186E883B0", Slot = "8")]
		public override void FFAHIPPDEOP(TClass MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6E88F10", Offset = "0x6E87F10", VA = "0x186E88F10", Slot = "9")]
		public override void JHDHIEHBDGL(TClass MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6E88650", Offset = "0x6E87650", VA = "0x186E88650", Slot = "10")]
		public override void JFNAKFDPNAK(TClass MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6E87D80", Offset = "0x6E86D80", VA = "0x186E87D80")]
		protected TProperty[] EKEOGBBEDOB(TClass MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BDE0", Offset = "0x6E8ADE0", VA = "0x186E8BDE0")]
		protected TProperty[] NNPECPJAMCH(TClass MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6E89660", Offset = "0x6E88660", VA = "0x186E89660", Slot = "4")]
		public override void LMCEEELLBNF(MethodInfo ANFGAKJLBHE, MethodInfo ANPNEJINGPO, MOLMCJFNFIK BJLNCBFOGNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BE50", Offset = "0x6E8AE50", VA = "0x186E8BE50")]
		protected DGADIIFMGIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class IDJMDCKDJGF<TClass, TProperty> : DGADIIFMGIP<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void LJOGJLJELHO(AMLLHKHCDME AEJLPHJDEHN, [Out] TProperty CKBJMHPECGE);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void INIFPPBFGAK(NIHFFPGGAMD PGMOKNOMMMJ, TProperty CKBJMHPECGE);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x500F100", Offset = "0x500E100", VA = "0x18500F100", Slot = "5")]
		public override void KBNPPCHGIKL(TClass MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x500F200", Offset = "0x500E200", VA = "0x18500F200", Slot = "6")]
		public override void KENBDFDJMJH(TClass MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x500F2E0", Offset = "0x500E2E0", VA = "0x18500F2E0", Slot = "7")]
		public override void NDOAMFKMFON(TClass MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x500F060", Offset = "0x500E060", VA = "0x18500F060", Slot = "8")]
		public override void FFAHIPPDEOP(TClass MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x48F9010", Offset = "0x48F8010", VA = "0x1848F9010")]
		protected IDJMDCKDJGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class CFGKBCGDCEF<T> : DGADIIFMGIP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x68B6E60", Offset = "0x68B5E60", VA = "0x1868B6E60", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x53DAEC0", Offset = "0x53D9EC0", VA = "0x1853DAEC0", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68B6EC0", Offset = "0x68B5EC0", VA = "0x1868B6EC0", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x53DAE10", Offset = "0x53D9E10", VA = "0x1853DAE10", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public CFGKBCGDCEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KPNHNHFFJDN<T> : DGADIIFMGIP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x53DAE60", Offset = "0x53D9E60", VA = "0x1853DAE60", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x53DAEC0", Offset = "0x53D9EC0", VA = "0x1853DAEC0", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x53DAF10", Offset = "0x53D9F10", VA = "0x1853DAF10", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x53DAE10", Offset = "0x53D9E10", VA = "0x1853DAE10", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public KPNHNHFFJDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class BEGPOHADMIO<T> : DGADIIFMGIP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x64300C0", Offset = "0x642F0C0", VA = "0x1864300C0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6430120", Offset = "0x642F120", VA = "0x186430120", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6430170", Offset = "0x642F170", VA = "0x186430170", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6430070", Offset = "0x642F070", VA = "0x186430070", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public BEGPOHADMIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class BJHCHELMHOC<T> : DGADIIFMGIP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x643C4A0", Offset = "0x643B4A0", VA = "0x18643C4A0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6430120", Offset = "0x642F120", VA = "0x186430120", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x643C500", Offset = "0x643B500", VA = "0x18643C500", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6430070", Offset = "0x642F070", VA = "0x186430070", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public BJHCHELMHOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FADHDLNEGME<T> : DGADIIFMGIP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4D74A90", Offset = "0x4D73A90", VA = "0x184D74A90", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D74AF0", Offset = "0x4D73AF0", VA = "0x184D74AF0", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4D74B40", Offset = "0x4D73B40", VA = "0x184D74B40", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4D74A40", Offset = "0x4D73A40", VA = "0x184D74A40", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public FADHDLNEGME()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class AMKKDEFEPEC<T> : DGADIIFMGIP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x527AC30", Offset = "0x5279C30", VA = "0x18527AC30", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4D74AF0", Offset = "0x4D73AF0", VA = "0x184D74AF0", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x527AC90", Offset = "0x5279C90", VA = "0x18527AC90", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4D74A40", Offset = "0x4D73A40", VA = "0x184D74A40", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public AMKKDEFEPEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class DMJALBBPMPL<T> : DGADIIFMGIP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4498AF0", Offset = "0x4497AF0", VA = "0x184498AF0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4498B50", Offset = "0x4497B50", VA = "0x184498B50", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4498BA0", Offset = "0x4497BA0", VA = "0x184498BA0", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4498AA0", Offset = "0x4497AA0", VA = "0x184498AA0", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public DMJALBBPMPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PLECGMPMIFI<T> : DGADIIFMGIP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4498AF0", Offset = "0x4497AF0", VA = "0x184498AF0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4498B50", Offset = "0x4497B50", VA = "0x184498B50", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A7CF40", Offset = "0x5A7BF40", VA = "0x185A7CF40", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4498AA0", Offset = "0x4497AA0", VA = "0x184498AA0", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public PLECGMPMIFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MOEMKGBHPFN<T> : DGADIIFMGIP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x56FAD40", Offset = "0x56F9D40", VA = "0x1856FAD40", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x56FADA0", Offset = "0x56F9DA0", VA = "0x1856FADA0", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x56FADF0", Offset = "0x56F9DF0", VA = "0x1856FADF0", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x53DAE10", Offset = "0x53D9E10", VA = "0x1853DAE10", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public MOEMKGBHPFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class KBDGPMNECHK<T> : DGADIIFMGIP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x53971F0", Offset = "0x53961F0", VA = "0x1853971F0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5397250", Offset = "0x5396250", VA = "0x185397250", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x53972A0", Offset = "0x53962A0", VA = "0x1853972A0", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4D74A40", Offset = "0x4D73A40", VA = "0x184D74A40", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public KBDGPMNECHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class LODDECBLHJN<T> : DGADIIFMGIP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x54BB630", Offset = "0x54BA630", VA = "0x1854BB630", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x54BB690", Offset = "0x54BA690", VA = "0x1854BB690", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x54BB6E0", Offset = "0x54BA6E0", VA = "0x1854BB6E0", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4498AA0", Offset = "0x4497AA0", VA = "0x184498AA0", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4498C00", Offset = "0x4497C00", VA = "0x184498C00")]
		public LODDECBLHJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OBGANHAEAMB<T> : IDJMDCKDJGF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5897F20", Offset = "0x5896F20", VA = "0x185897F20", Slot = "12")]
		protected override void INIFPPBFGAK(NIHFFPGGAMD PGMOKNOMMMJ, char CKBJMHPECGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5897F50", Offset = "0x5896F50", VA = "0x185897F50", Slot = "11")]
		protected override void LJOGJLJELHO(AMLLHKHCDME AEJLPHJDEHN, [Out] char CKBJMHPECGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
		public OBGANHAEAMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CLAAEBKPMKC<T> : IDJMDCKDJGF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x698A3D0", Offset = "0x69893D0", VA = "0x18698A3D0", Slot = "12")]
		protected override void INIFPPBFGAK(NIHFFPGGAMD PGMOKNOMMMJ, IPEndPoint CKBJMHPECGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x698A400", Offset = "0x6989400", VA = "0x18698A400", Slot = "11")]
		protected override void LJOGJLJELHO(AMLLHKHCDME AEJLPHJDEHN, [Out] IPEndPoint CKBJMHPECGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x48B4C40", Offset = "0x48B3C40", VA = "0x1848B4C40")]
		public CLAAEBKPMKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class CPJAPDMLEDA<T> : DGADIIFMGIP<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int ENNMMLGEIGE;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6998EE0", Offset = "0x6997EE0", VA = "0x186998EE0")]
		public CPJAPDMLEDA(int KILNJGPIIOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x6998DA0", Offset = "0x6997DA0", VA = "0x186998DA0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6998E10", Offset = "0x6997E10", VA = "0x186998E10", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6998E70", Offset = "0x6997E70", VA = "0x186998E70", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6998D40", Offset = "0x6997D40", VA = "0x186998D40", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class FHEAGDGGGCP<T> : HFKFIHCEIIN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo JFAMMMJCEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type JNPPOBJDBFK;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DA60", Offset = "0x4D8CA60", VA = "0x184D8DA60")]
		public FHEAGDGGGCP(PropertyInfo EKGLNGMKMKH, Type ENLLGBMKCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D890", Offset = "0x4D8C890", VA = "0x184D8D890", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D950", Offset = "0x4D8C950", VA = "0x184D8D950", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4D8DA00", Offset = "0x4D8CA00", VA = "0x184D8DA00", Slot = "7")]
		public override void NDOAMFKMFON(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D770", Offset = "0x4D8C770", VA = "0x184D8D770", Slot = "8")]
		public override void FFAHIPPDEOP(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D830", Offset = "0x4D8C830", VA = "0x184D8D830", Slot = "9")]
		public override void JHDHIEHBDGL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4D8D7D0", Offset = "0x4D8C7D0", VA = "0x184D8D7D0", Slot = "10")]
		public override void JFNAKFDPNAK(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class COGBDAMHNGF<T> : FHEAGDGGGCP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
		public COGBDAMHNGF(PropertyInfo EKGLNGMKMKH, Type ENLLGBMKCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x69909F0", Offset = "0x698F9F0", VA = "0x1869909F0", Slot = "5")]
		public override void KBNPPCHGIKL(T MGBBDFJFCJF, AMLLHKHCDME AEJLPHJDEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6990AB0", Offset = "0x698FAB0", VA = "0x186990AB0", Slot = "6")]
		public override void KENBDFDJMJH(T MGBBDFJFCJF, NIHFFPGGAMD PGMOKNOMMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class DEAIPCAMMEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static DEAIPCAMMEL<T> KONBGMLOLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly HFKFIHCEIIN<T>[] MHCECEFNIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int INAEKBBNGKJ;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E87100", Offset = "0x6E86100", VA = "0x186E87100")]
		public DEAIPCAMMEL(List<HFKFIHCEIIN<T>> IJMBIBGFAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E87050", Offset = "0x6E86050", VA = "0x186E87050")]
		public void KENBDFDJMJH(T PGIOEBKALDP, NIHFFPGGAMD NMCAGOGLPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E86FA0", Offset = "0x6E85FA0", VA = "0x186E86FA0")]
		public void KBNPPCHGIKL(T PGIOEBKALDP, AMLLHKHCDME AMPJMGIAGBB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class HNJNBBAEHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HFKFIHCEIIN<T> LMKONLJOAEP<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private NIHFFPGGAMD GFHOGCNFNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int KDEJFEEJAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, HNJNBBAEHEH> KHIMINBOCEF;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x734D100", Offset = "0x734C100", VA = "0x18734D100")]
	public AIMPELDACDB(int AFFLLAIGBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x31A9EF0", Offset = "0x31A8EF0", VA = "0x1831A9EF0")]
	private DEAIPCAMMEL<T> ALOAHMKCDCI<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x31AADE0", Offset = "0x31A9DE0", VA = "0x1831AADE0")]
	public void AMNFOKHCMAP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x31AAE50", Offset = "0x31A9E50", VA = "0x1831AAE50")]
	public bool LABNBGADOBH<T>(AMLLHKHCDME AMPJMGIAGBB, T AOJAHPGAGPO) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x31AADF0", Offset = "0x31A9DF0", VA = "0x1831AADF0")]
	public void FBGBLPHHDGN<T>(NIHFFPGGAMD NMCAGOGLPLD, T PGIOEBKALDP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class GGHFBJPCICH
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime NHOFGLOJPHN;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] MHJEGHKHFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public JCNKPKJIECJ NAOLDFFFNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7351CA0", Offset = "0x7350CA0", VA = "0x187351CA0")]
		get
		{
			return default(JCNKPKJIECJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HGAGMDAKJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7351B80", Offset = "0x7350B80", VA = "0x187351B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7352660", Offset = "0x7351660", VA = "0x187352660")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public HJMEBJALEFI JPMAINONMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7351A80", Offset = "0x7350A80", VA = "0x187351A80")]
		get
		{
			return default(HJMEBJALEFI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7351EA0", Offset = "0x7350EA0", VA = "0x187351EA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NLMFKLHMBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7352700", Offset = "0x7351700", VA = "0x187352700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint IHKCPKCOIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x73519A0", Offset = "0x73509A0", VA = "0x1873519A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? HDMDEPHPODO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7351BB0", Offset = "0x7350BB0", VA = "0x187351BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? DPEBONNJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x73526D0", Offset = "0x73516D0", VA = "0x1873526D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? EIFCCCILOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x73526A0", Offset = "0x73516A0", VA = "0x1873526A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7351CD0", Offset = "0x7350CD0", VA = "0x187351CD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? KHCIKAAIMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD36D60", Offset = "0xD35D60", VA = "0x180D36D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF0BE40", Offset = "0xF0AE40", VA = "0x180F0BE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7352790", Offset = "0x7351790", VA = "0x187352790")]
	public GGHFBJPCICH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7352AB0", Offset = "0x7351AB0", VA = "0x187352AB0")]
	internal GGHFBJPCICH(byte[] ODOOLGJOBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7352170", Offset = "0x7351170", VA = "0x187352170")]
	public static GGHFBJPCICH KJINFEOFONN(byte[] ODOOLGJOBIG, DateTime EJEEHOMGPLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7351F70", Offset = "0x7350F70", VA = "0x187351F70")]
	internal void JMCIDAIDPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x73517C0", Offset = "0x73507C0", VA = "0x1873517C0")]
	private void AKKOPIFJCIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7352290", Offset = "0x7351290", VA = "0x187352290")]
	private DateTime? LENEHHIOGPI(int MOAJDMPNBPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7352490", Offset = "0x7351490", VA = "0x187352490")]
	private void LJLBGLCLBOJ(int MOAJDMPNBPN, DateTime? IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7351AB0", Offset = "0x7350AB0", VA = "0x187351AB0")]
	private ulong DCBGLEDKENH(int MOAJDMPNBPN)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7351BE0", Offset = "0x7350BE0", VA = "0x187351BE0")]
	private void EGFCDFLGDKJ(int MOAJDMPNBPN, ulong IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7351EE0", Offset = "0x7350EE0", VA = "0x187351EE0")]
	private uint HIHJIHAKDCB(int MOAJDMPNBPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7217F60", Offset = "0x7216F60", VA = "0x187217F60")]
	private static uint BHJJPKIFFLB(uint OEFDFBLCHHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7351A20", Offset = "0x7350A20", VA = "0x187351A20")]
	private static ulong BHJJPKIFFLB(ulong OEFDFBLCHHF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum JCNKPKJIECJ
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum HJMEBJALEFI
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class PHHNHFLDDML
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int MKPLNLEIFEI = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int OJCBAJJBLDG = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int GMNDDFEDDMA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint ACOLBONKKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int GLKPEAPAFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int GIAGAJGANHJ;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NJIFBFOJOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7365240", Offset = "0x7364240", VA = "0x187365240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7365150", Offset = "0x7364150", VA = "0x187365150")]
	public bool GEIODCMLOHE(NBNDFJNFFAH DOELFPFPAJL, int JAPNNLNNKKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class FIEHCOJMLFK : NBNDFJNFFAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket DOELFPFPAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly JAOBJOHMHKI AKBLGGEEFOH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short MMOJEOFAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x7350990", Offset = "0x734F990", VA = "0x187350990", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JFIHNFOIFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7350950", Offset = "0x734F950", VA = "0x187350950", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint NFJGNFKNNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7350240", Offset = "0x734F240", VA = "0x187350240", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily BAANCNGLLFC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x543AF00", Offset = "0x5439F00", VA = "0x18543AF00", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x73509B0", Offset = "0x734F9B0", VA = "0x1873509B0")]
	public FIEHCOJMLFK(AddressFamily BHHFDICMDDI, JAOBJOHMHKI AKBLGGEEFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7350390", Offset = "0x734F390", VA = "0x187350390", Slot = "8")]
	public bool DIIACPJEKGA(IPEndPoint KPDFNPOOKOJ, MBAHKAAHHNM GHKCHBNIJJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7350260", Offset = "0x734F260", VA = "0x187350260", Slot = "9")]
	public int BEMKALPJKJE(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, int BKLOHAHJLKP, IPEndPoint MCPKAMEBJKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x73502A0", Offset = "0x734F2A0", VA = "0x1873502A0", Slot = "10")]
	public int CPFJMNMNLBL(byte[] MPPMMFHHGAK, EndPoint KEOBIIMLGEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7350970", Offset = "0x734F970", VA = "0x187350970", Slot = "11")]
	public void ONLGEPHGHLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface NBNDFJNFFAH
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short MMOJEOFAEBD
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int JFIHNFOIFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint NFJGNFKNNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily BAANCNGLLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DIIACPJEKGA(IPEndPoint KPDFNPOOKOJ, MBAHKAAHHNM GHKCHBNIJJC);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int BEMKALPJKJE(byte[] MPPMMFHHGAK, int MOAJDMPNBPN, int BKLOHAHJLKP, IPEndPoint MCPKAMEBJKG);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CPFJMNMNLBL(byte[] MPPMMFHHGAK, EndPoint MCPKAMEBJKG);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONLGEPHGHLP();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct CCPEGNLODCP : IEquatable<CCPEGNLODCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long GIJBOFDGJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long MLCNHLKKGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long GALCLIJMCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int BGKNBCKCMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int MDOJIFAOGKP;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x734F830", Offset = "0x734E830", VA = "0x18734F830")]
	public CCPEGNLODCP(byte[] CCNGABFELGK, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x734F8F0", Offset = "0x734E8F0", VA = "0x18734F8F0")]
	public CCPEGNLODCP(Span<byte> CCNGABFELGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xA88A10", Offset = "0xA87A10", VA = "0x180A88A10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x734F740", Offset = "0x734E740", VA = "0x18734F740", Slot = "4")]
	public bool Equals(CCPEGNLODCP EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x734F780", Offset = "0x734E780", VA = "0x18734F780", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class KOILJOHLCJJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] ECCODMLPHFL;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class DMOIFJKJNEM
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void OMKJAAGNHJN(IPEndPoint CCNGABFELGK, Span<byte> INCJDDLACNP);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string NHOHPCGAAID = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int DFGPMBLPKHC = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int CBLFHPBKELL = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int OCPIDDCOLEA = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<CCPEGNLODCP, IPEndPoint> HPNIMGHBFLO;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static OMKJAAGNHJN EJFMNNMDNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int LDMKJEJBADI;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	internal void AFHMCIGONJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	internal void OCABPGCNJDE(IPEndPoint MCPKAMEBJKG, Span<byte> INCJDDLACNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class GANDEHKIMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int IEMANDIKEOI;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA5F480", Offset = "0xA5E480", VA = "0x180A5F480")]
	protected GANDEHKIMBM(int HPJAMKKEGMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FMHFAJOCCHG(IPEndPoint KPDFNPOOKOJ, byte[] INCJDDLACNP, int MOAJDMPNBPN, int FCCMJLNEMIB);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void FOFHJKKBKGJ(IPEndPoint KPDFNPOOKOJ, byte[] INCJDDLACNP, int MOAJDMPNBPN, int FCCMJLNEMIB);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MGHAOMEMAHF : GANDEHKIMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] DAKIIEIEKNI;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator LOFJEPDAEKF;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2A65710", Offset = "0x2A64710", VA = "0x182A65710")]
	public MGHAOMEMAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x735DF90", Offset = "0x735CF90", VA = "0x18735DF90")]
	public void GKKBCNBDNNF(IPEndPoint KPDFNPOOKOJ, byte[] DAKIIEIEKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x735E140", Offset = "0x735D140", VA = "0x18735E140")]
	public void OMFPKBDCHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x735D760", Offset = "0x735C760", VA = "0x18735D760", Slot = "4")]
	public override void FMHFAJOCCHG(IPEndPoint KPDFNPOOKOJ, byte[] INCJDDLACNP, int MOAJDMPNBPN, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x735DC20", Offset = "0x735CC20", VA = "0x18735DC20", Slot = "5")]
	public override void FOFHJKKBKGJ(IPEndPoint KPDFNPOOKOJ, byte[] INCJDDLACNP, int MOAJDMPNBPN, int FCCMJLNEMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct JAAFAEJAGHD
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void KELPEAFPAJA([NoAlias] byte* DJGKIKHDPKO, [NoAlias] byte* DAKIIEIEKNI, [NoAlias] byte* KLIPKECLBGO, int FCCMJLNEMIB);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class BJAEIACDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr FCMGCDBJKKE;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr ECLLHLMKGPH;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7365780", Offset = "0x7364780", VA = "0x187365780")]
		[BurstDiscard]
		private static void KKANJPNIGKL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7365620", Offset = "0x7364620", VA = "0x187365620")]
		private static IntPtr GJEGJCGINDM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x73658B0", Offset = "0x73648B0", VA = "0x1873658B0")]
		public static void NMGGAOODKNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
		public static void OCOPJMCPGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x73653E0", Offset = "0x73643E0", VA = "0x1873653E0")]
		public unsafe static void BAHFCECOEJD([NoAlias] byte* DJGKIKHDPKO, [NoAlias] byte* DAKIIEIEKNI, [NoAlias] byte* KLIPKECLBGO, int FCCMJLNEMIB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint DAKIIEIEKNI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint KLIPKECLBGO[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint JCJFBBGLNIH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint AJJDFIPPLGE[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint JEPHJFHJCGL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint KHCOPNFDMNL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint JKAOFIEFGHA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint JKLKMAEEEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint MBDFGBLNLEC[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x7352E30", Offset = "0x7351E30", VA = "0x187352E30")]
	private void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x7352EB0", Offset = "0x7351EB0", VA = "0x187352EB0")]
	private uint BKPMDFBKEFJ(uint LJALOPCLDCK, int APPLLJJBAIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x734CFB0", Offset = "0x734BFB0", VA = "0x18734CFB0")]
	private void OHBHBPCCILF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x734CDA0", Offset = "0x734BDA0", VA = "0x18734CDA0")]
	private void NJNMJABPIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x734CD10", Offset = "0x734BD10", VA = "0x18734CD10")]
	private void LMHBICFDOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x734CC10", Offset = "0x734BC10", VA = "0x18734CC10")]
	private void HGDBNOBNCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x73535D0", Offset = "0x73525D0", VA = "0x1873535D0")]
	private void PNKMECFHCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x73530B0", Offset = "0x73520B0", VA = "0x1873530B0")]
	private unsafe void KKLCFKEDJCA(byte* DJGKIKHDPKO, uint* DAKIIEIEKNI, uint* KLIPKECLBGO, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7352FC0", Offset = "0x7351FC0", VA = "0x187352FC0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void FLBDEFFKNCL([NoAlias] byte* DJGKIKHDPKO, [NoAlias] byte* DAKIIEIEKNI, [NoAlias] byte* KLIPKECLBGO, int FCCMJLNEMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7352EE0", Offset = "0x7351EE0", VA = "0x187352EE0")]
	public static void FLBDEFFKNCL(Span<byte> DJGKIKHDPKO, Span<byte> DAKIIEIEKNI, Span<byte> KLIPKECLBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x73534D0", Offset = "0x73524D0", VA = "0x1873534D0")]
	public static void KLOHHLIEEIE(Span<byte> DJGKIKHDPKO, Span<byte> DAKIIEIEKNI, Span<byte> KLIPKECLBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7353040", Offset = "0x7352040", VA = "0x187353040")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JDKBPGGEKMN([NoAlias] byte* DJGKIKHDPKO, [NoAlias] byte* DAKIIEIEKNI, [NoAlias] byte* KLIPKECLBGO, int FCCMJLNEMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7365A60", Offset = "0x7364A60", VA = "0x187365A60")]
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
