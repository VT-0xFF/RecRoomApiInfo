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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, MEFLCMFPLKN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum EOEOFCJMHJJ
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
		private NetworkManager PLAMKHGCHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, APOPADOIEEN> MHIFJPKKEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private FEGPFBMDAGF AIJCPLKDBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] OAMODAKLJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EOEOFCJMHJJ OLPCLGKCIML;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ADLIKDACBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OECBKAMBDPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x51C7860", Offset = "0x51C6660", VA = "0x1851C7860", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x51C6D60", Offset = "0x51C5B60", VA = "0x1851C6D60")]
		public void RecRoom_SetEncryptionInfo(ulong JOFOJGDHGPF, byte[] GMOPMNAPKBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x51C6D40", Offset = "0x51C5B40", VA = "0x1851C6D40")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51C6C10", Offset = "0x51C5A10", VA = "0x1851C6C10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51C7760", Offset = "0x51C6560", VA = "0x1851C7760")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51C6F60", Offset = "0x51C5D60", VA = "0x1851C6F60", Slot = "6")]
		public override void Send(ulong KOPAGBBKACI, ArraySegment<byte> LMCJHCIOIIP, NetworkDelivery IOKFCGLAJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x51C6D00", Offset = "0x51C5B00", VA = "0x1851C6D00", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong KOPAGBBKACI, [Out] ArraySegment<byte> JOPBACODGFL, [Out] float EOLBLFKEKPM)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51C7250", Offset = "0x51C6050", VA = "0x1851C7250", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x51C7680", Offset = "0x51C6480", VA = "0x1851C7680", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51C6570", Offset = "0x51C5370", VA = "0x1851C6570", Slot = "10")]
		public override void DisconnectRemoteClient(ulong KOPAGBBKACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51C6420", Offset = "0x51C5220", VA = "0x1851C6420", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51C6870", Offset = "0x51C5670", VA = "0x1851C6870", Slot = "12")]
		public override ulong GetCurrentRtt(ulong KOPAGBBKACI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x51C71E0", Offset = "0x51C5FE0", VA = "0x1851C71E0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51C6970", Offset = "0x51C5770", VA = "0x1851C6970", Slot = "14")]
		public override void Initialize([Optional] NetworkManager PLAMKHGCHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x51C67A0", Offset = "0x51C55A0", VA = "0x1851C67A0")]
		private OMKCMHJCOFJ GOGLKFBNIPN(NetworkDelivery FLHOFPAHPKL)
		{
			return default(OMKCMHJCOFJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51C66E0", Offset = "0x51C54E0", VA = "0x1851C66E0", Slot = "15")]
		private void ENFLLENELPL(APOPADOIEEN GLNHIABFBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51C5F90", Offset = "0x51C4D90", VA = "0x1851C5F90", Slot = "16")]
		private void BBHLMMBHGAP(APOPADOIEEN GLNHIABFBDG, OKJBLMBMJGE OPMGLDJJEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "17")]
		private void CBFNAKMKLED(IPEndPoint ABPMHGJKKEP, SocketError BCBJFPENKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51C6120", Offset = "0x51C4F20", VA = "0x1851C6120", Slot = "18")]
		private void DKEFJLFGNNL(APOPADOIEEN GLNHIABFBDG, GBJMFBEKHAL GFNJLJABMCF, byte AFEBDOBMGLE, OMKCMHJCOFJ NGDBGIKCOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51C6B30", Offset = "0x51C5930", VA = "0x1851C6B30")]
		private void MNPKKKDLFOE(int GINFBCJKIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "19")]
		private void POKDGNBHPHB(IPEndPoint PBNJEJHDMKF, GBJMFBEKHAL GFNJLJABMCF, PLFGJCLIEIO BONNCJDOLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "20")]
		private void PKJEJKOJIPO(APOPADOIEEN GLNHIABFBDG, int OBDEKMCPHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51C6910", Offset = "0x51C5710", VA = "0x1851C6910", Slot = "21")]
		private void HPKGMEAEAMK(FEEKNIJCOCE BHMKONDNBED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51C60D0", Offset = "0x51C4ED0", VA = "0x1851C60D0")]
		private ulong BOGGLHEMDIM(APOPADOIEEN GLNHIABFBDG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51C6100", Offset = "0x51C4F00", VA = "0x1851C6100")]
		private static int DEKINLCKLHN(float NNDFFBJHCAM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51C7780", Offset = "0x51C6580", VA = "0x1851C7780")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class HLEDCNBOCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly APOPADOIEEN KJEKOAADBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<MNHDLDDLHDG> MCIGOPAOENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int BCGPGLOIAFO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51C4B80", Offset = "0x51C3980", VA = "0x1851C4B80")]
	protected HLEDCNBOCPK(APOPADOIEEN GLNHIABFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51C4AE0", Offset = "0x51C38E0", VA = "0x1851C4AE0")]
	public void DPHPEAOMAJI(MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x51C4A60", Offset = "0x51C3860", VA = "0x1851C4A60")]
	protected void AGHJOAMKABK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51C4B40", Offset = "0x51C3940", VA = "0x1851C4B40")]
	public bool MGFIKEKHOKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool ENOABKJMPML();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool HBDLDJIAJNJ(MNHDLDDLHDG IMBCEPDODAI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum HMBDNNAHCMN
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
public class FEEKNIJCOCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly FEGPFBMDAGF PAKLPOFJDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int NOCDKGJNLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal OANNNOEPKBO JFDCLOJKCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint EDMMACLKKGH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HMBDNNAHCMN FKPFGJNEEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x786F50", Offset = "0x785D50", VA = "0x180786F50")]
		[CompilerGenerated]
		get
		{
			return default(HMBDNNAHCMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x806B30", Offset = "0x805930", VA = "0x180806B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51BC4F0", Offset = "0x51BB2F0", VA = "0x1851BC4F0")]
	internal void OKMHJLGHNCN(OANNNOEPKBO MDLJEAMEKJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51BC4C0", Offset = "0x51BB2C0", VA = "0x1851BC4C0")]
	private bool HLPLOLMADFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51BC550", Offset = "0x51BB350", VA = "0x1851BC550")]
	internal FEEKNIJCOCE(IPEndPoint PBNJEJHDMKF, OANNNOEPKBO PJFLMJOGPBK, FEGPFBMDAGF AIMEBJCOCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51BC460", Offset = "0x51BB260", VA = "0x1851BC460")]
	public APOPADOIEEN CFEDMPPIKFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PLFGJCLIEIO
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GAIBKLFPDOP
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
public struct OKJBLMBMJGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GAIBKLFPDOP GIDOEHDHKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError HCIGJJGHGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GBJMFBEKHAL DNNKPMEILOC;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MEFLCMFPLKN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGCKBAEANBD(APOPADOIEEN GLNHIABFBDG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APPDAOBCLNP(APOPADOIEEN GLNHIABFBDG, OKJBLMBMJGE OPMGLDJJEAK);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHJLKIJNHJL(IPEndPoint ABPMHGJKKEP, SocketError BCBJFPENKNF);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JBOFCAPLNOG(APOPADOIEEN GLNHIABFBDG, GBJMFBEKHAL GFNJLJABMCF, byte AFEBDOBMGLE, OMKCMHJCOFJ NGDBGIKCOKN);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLEFBDDPDDC(IPEndPoint PBNJEJHDMKF, GBJMFBEKHAL GFNJLJABMCF, PLFGJCLIEIO BONNCJDOLAP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFFPPPKKHDH(APOPADOIEEN GLNHIABFBDG, int OBDEKMCPHGK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGAGHCHGFKI(FEEKNIJCOCE BHMKONDNBED);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IHKIFIKDEBP
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHJAPNKIBFM(APOPADOIEEN GLNHIABFBDG, object IGFHPKBICAA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JCKKHDIEKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLJDPOLNALI(DPHMHLKMAGO IMBCEPDODAI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HBDFKHEIKGG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKMKLJLNDOG(APOPADOIEEN GLNHIABFBDG, IPEndPoint BAMKBCFHNGA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class OANNNOEPKBO
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int MKBEMGECNJC = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long HHEOMPKAEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte BHOFMDBIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] MHLNPHOLLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly PCHKKKEDCOJ NCHGGNHAEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int CIHMCEPOJBB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51C92F0", Offset = "0x51C80F0", VA = "0x1851C92F0")]
	private OANNNOEPKBO(long EOLIMHDDLKL, byte JAGPKPJHIPM, int GOOJPBOEHHC, byte[] LFFJPPAAJCH, PCHKKKEDCOJ LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51C8E90", Offset = "0x51C7C90", VA = "0x1851C8E90")]
	public static int ICNIFHEJHHN(MNHDLDDLHDG IMBCEPDODAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51C8EF0", Offset = "0x51C7CF0", VA = "0x1851C8EF0")]
	public static OANNNOEPKBO IDFNPNDEFOF(MNHDLDDLHDG IMBCEPDODAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51C9110", Offset = "0x51C7F10", VA = "0x1851C9110")]
	public static MNHDLDDLHDG PBMIPAKELDC(CCEHMELCJFE EMBJACFFBHL, SocketAddress IJPEAAECHKK, long DAMFBNPJGOK, int GOOJPBOEHHC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class DFIFKPJJGOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long HHEOMPKAEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte BHOFMDBIMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int CIHMCEPOJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool IABKHPMFIBJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51BA950", Offset = "0x51B9750", VA = "0x1851BA950")]
	private DFIFKPJJGOP(long EOLIMHDDLKL, byte JAGPKPJHIPM, int OJHGEGIICPG, bool CGHEADKJIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51BA710", Offset = "0x51B9510", VA = "0x1851BA710")]
	public static DFIFKPJJGOP IDFNPNDEFOF(MNHDLDDLHDG IMBCEPDODAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x51BA860", Offset = "0x51B9660", VA = "0x1851BA860")]
	public static MNHDLDDLHDG PBMIPAKELDC(long DAMFBNPJGOK, byte NDBKLPFHIAB, int FNIDCFNFGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51BA610", Offset = "0x51B9410", VA = "0x1851BA610")]
	public static MNHDLDDLHDG FPELKLNGJNM(APOPADOIEEN GLNHIABFBDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct LDFNNJKLPKH : IEquatable<LDFNNJKLPKH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long DGNKNFAPGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long NPGMIFENCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long JPEHFAIMKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int DEECMPGAHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int JJEPBGABEFH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51C5C80", Offset = "0x51C4A80", VA = "0x1851C5C80")]
	public LDFNNJKLPKH(byte[] BOENGMMHJOM, int ICBIFIPOOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x786F50", Offset = "0x785D50", VA = "0x180786F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x51C5B90", Offset = "0x51C4990", VA = "0x1851C5B90", Slot = "4")]
	public bool Equals(LDFNNJKLPKH LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51C5BD0", Offset = "0x51C49D0", VA = "0x1851C5BD0", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OEHCJOINEHC : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] OLEGNNHCILK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51C9360", Offset = "0x51C8160", VA = "0x1851C9360")]
	public OEHCJOINEHC(byte[] BOENGMMHJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class CPGCGKFDOFN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class LDMGCBNKCME
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51C5E50", Offset = "0x51C4C50", VA = "0x1851C5E50")]
		public static extern int LGPOMCNCJNL(IntPtr DGEHIGALELD, [In][Out] byte[] OELHKOGDJAJ, [In] int ICBIFIPOOGO, [In] SocketFlags ICFCGOIJGAF, [Out] byte[] FJJADDAMNKG, [In][Out] int IHDMOHAODKA);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51C5D70", Offset = "0x51C4B70", VA = "0x1851C5D70")]
		internal static extern int BKLIDBHFPPD(IntPtr DGEHIGALELD, [In] byte[] OELHKOGDJAJ, [In] int ICBIFIPOOGO, [In] SocketFlags ICFCGOIJGAF, [In] byte[] FJJADDAMNKG, [In] int IHDMOHAODKA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class DPDOPFOEJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51BAA80", Offset = "0x51B9880", VA = "0x1851BAA80")]
		public static extern int LGPOMCNCJNL(IntPtr DGEHIGALELD, [In][Out] byte[] OELHKOGDJAJ, [In] int ICBIFIPOOGO, [In] SocketFlags ICFCGOIJGAF, [Out] byte[] FJJADDAMNKG, [In][Out] int IHDMOHAODKA);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51BA9A0", Offset = "0x51B97A0", VA = "0x1851BA9A0")]
		internal static extern int BKLIDBHFPPD(IntPtr DGEHIGALELD, [In] byte[] OELHKOGDJAJ, [In] int ICBIFIPOOGO, [In] SocketFlags ICFCGOIJGAF, [In] byte[] FJJADDAMNKG, [In] int IHDMOHAODKA);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool OECBKAMBDPP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool HFJDDMCJNFA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> JBNJPGHKGGB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51B8F10", Offset = "0x51B7D10", VA = "0x1851B8F10")]
	static CPGCGKFDOFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51B8AE0", Offset = "0x51B78E0", VA = "0x1851B8AE0")]
	public static int CJMLAPEOFNP(IntPtr DGEHIGALELD, byte[] OELHKOGDJAJ, int ICBIFIPOOGO, byte[] FJJADDAMNKG, int IHDMOHAODKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51B8CD0", Offset = "0x51B7AD0", VA = "0x1851B8CD0")]
	public static int LMBMAIPOBLH(IntPtr DGEHIGALELD, byte[] OELHKOGDJAJ, int ICBIFIPOOGO, byte[] FJJADDAMNKG, int IHDMOHAODKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51B89F0", Offset = "0x51B77F0", VA = "0x1851B89F0")]
	public static SocketError CCDPDIEONMB()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51B8B90", Offset = "0x51B7990", VA = "0x1851B8B90")]
	public static SocketException CKIHOAABMOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51B8E60", Offset = "0x51B7C60", VA = "0x1851B8E60")]
	public static short NECMBGMBCIP(IPEndPoint PBNJEJHDMKF)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FJPKAPOIIOO
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CKOBOKPJOGF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBAMGKPHGHH(IPEndPoint EHOCJOOKPJE, IPEndPoint PBNJEJHDMKF, string EKDHBKMFLGI);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDLJEDCDKOE(IPEndPoint PKNKABGJNGM, FJPKAPOIIOO FLHOFPAHPKL, string EKDHBKMFLGI);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class PFEJMNEBNGB
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct KBLJIOPFNFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint JPBBAPNFCDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint EDMMACLKKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string GNCLJIFHECE;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct JIGLNHKBJJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint MIJOAOIILNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FJPKAPOIIOO HHINMKNAKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string GNCLJIFHECE;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class MOIKPKAFPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BDFFNOCEHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string GNCLJIFHECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MOIKPKAFPPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class MDGGPEEHOEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BDFFNOCEHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LPPOLAGJGFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GNCLJIFHECE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public MDGGPEEHOEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class HJFFFIPBBLE
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GNCLJIFHECE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GIKJFOKDGOI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x763AB0", VA = "0x180764CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HJFFFIPBBLE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly FEGPFBMDAGF BNLNDGAGCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<KBLJIOPFNFA> DOMOOOLMNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<JIGLNHKBJJM> IAMBAKMBOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly PCHKKKEDCOJ DADFPELLMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly CCEHMELCJFE ICCNJFDNPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly JGACGBHOLHD EABHGCGLLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private CKOBOKPJOGF DDDJMNHNGOJ;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int DJDMCPOMIPH = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool JHOKIIPNOBO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51CACD0", Offset = "0x51C9AD0", VA = "0x1851CACD0")]
	internal PFEJMNEBNGB(FEGPFBMDAGF EIEBKALMGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x51CAB70", Offset = "0x51C9970", VA = "0x1851CAB70")]
	internal void OIKKNMFEHOO(IPEndPoint DPCEOFJJOMN, MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x25118F0", Offset = "0x25106F0", VA = "0x1825118F0")]
	private void GGFCBONHGMC<T>(T IMBCEPDODAI, IPEndPoint PABBJIBBIGE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51CA840", Offset = "0x51C9640", VA = "0x1851CA840")]
	private void CBAMGKPHGHH(MOIKPKAFPPJ ODCKNGKEKHE, IPEndPoint DPCEOFJJOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x51CA6C0", Offset = "0x51C94C0", VA = "0x1851CA6C0")]
	private void BICEHABFLIC(MDGGPEEHOEN ODCKNGKEKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x51CA9D0", Offset = "0x51C97D0", VA = "0x1851CA9D0")]
	private void FAHBMCPPDBP(HJFFFIPBBLE ODCKNGKEKHE, IPEndPoint DPCEOFJJOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OMKCMHJCOFJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class ELOFNHHDJAL
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] MLOOCDMEBGO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int NLHNIIADHAL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int HJPCADIJIBJ;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JMJLLFBFJIF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51BA600", Offset = "0x51B9400", VA = "0x1851BA600")]
	public JMJLLFBFJIF(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DCFJEILMDKI : JMJLLFBFJIF
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51BA600", Offset = "0x51B9400", VA = "0x1851BA600")]
	public DCFJEILMDKI(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum MGHGCCGCCAL
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface EMNADFCIELH
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBCFPJELICK(MGHGCCGCCAL FAAAOGNJKEE, string MNCMCPLICPL, params object[] MEALCFKPKME);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class ONKEAOIMDEF
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static EMNADFCIELH KBNIAJMFDKB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object OLEOHBPJDOG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x51C96D0", Offset = "0x51C84D0", VA = "0x1851C96D0")]
	private static void ECGEBGPPCHD(MGHGCCGCCAL FCDLMNMJIMN, string MNCMCPLICPL, params object[] MEALCFKPKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x51C9960", Offset = "0x51C8760", VA = "0x1851C9960")]
	internal static void IIENDPPPLJE(string MNCMCPLICPL, params object[] MEALCFKPKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x51C9670", Offset = "0x51C8470", VA = "0x1851C9670")]
	internal static void AEECJKIHMKM(string MNCMCPLICPL, params object[] MEALCFKPKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51C9900", Offset = "0x51C8700", VA = "0x1851C9900")]
	internal static void HGCKCHDDAFL(string MNCMCPLICPL, params object[] MEALCFKPKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum LJHEBDNJPME
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GBJMFBEKHAL : PCHKKKEDCOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private MNHDLDDLHDG KPFAHHGPIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly FEGPFBMDAGF HEGFBDFPBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly JHJCIKLMKDA OOCAMMEGOIC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x51C4400", Offset = "0x51C3200", VA = "0x1851C4400")]
	internal GBJMFBEKHAL(FEGPFBMDAGF AMCDJKCDDEF, JHJCIKLMKDA BAKPBNPBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x51C42E0", Offset = "0x51C30E0", VA = "0x1851C42E0")]
	internal void JLCGBEEDJNK(MNHDLDDLHDG IMBCEPDODAI, int ILBPGNKNOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51C4350", Offset = "0x51C3150", VA = "0x1851C4350")]
	internal void KOOCFLJDGHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51C43D0", Offset = "0x51C31D0", VA = "0x1851C43D0")]
	public void NEGPAIDHDEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class JHJCIKLMKDA
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum HBMGOFHBLEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public JHJCIKLMKDA FKIKGLFLOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public HBMGOFHBLEC HHINMKNAKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public APOPADOIEEN KJEKOAADBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint EDMMACLKKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object OAFLMDPMEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int DOEGGKBDACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError NIBBOLAKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public GAIBKLFPDOP AHAOICFJHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public FEEKNIJCOCE KGAIEMJIBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public OMKCMHJCOFJ BBFPEMHGHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte PJDMFPHFCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly GBJMFBEKHAL NNBBEDBIEIE;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x51C5280", Offset = "0x51C4080", VA = "0x1851C5280")]
	public JHJCIKLMKDA(FEGPFBMDAGF AMCDJKCDDEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class FEGPFBMDAGF : IEnumerable<APOPADOIEEN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class FNLNIKFIALF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x51C4270", Offset = "0x51C3070", VA = "0x1851C4270", Slot = "4")]
		public bool Equals(IPEndPoint NPDPLEIHBMM, IPEndPoint CINKHPOEGPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C9E470", Offset = "0x4C9D270", VA = "0x184C9E470", Slot = "5")]
		public int GetHashCode(IPEndPoint DGPHOMINFCK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FNLNIKFIALF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct ADCPGFMALMH : IEnumerator<APOPADOIEEN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly APOPADOIEEN JBEKAFOGBBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private APOPADOIEEN CPKCKCNNEMD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public APOPADOIEEN CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x998FA0", Offset = "0x997DA0", VA = "0x180998FA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x998FA0", Offset = "0x997DA0", VA = "0x180998FA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xDE1040", Offset = "0xDDFE40", VA = "0x180DE1040")]
		public ADCPGFMALMH(APOPADOIEEN ADKJANDCMME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x51B3B50", Offset = "0x51B2950", VA = "0x1851B3B50", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x51B3BA0", Offset = "0x51B29A0", VA = "0x1851B3BA0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread LJGGIFGEJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool IFJNFLJMLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent CLJCDHPFMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<JHJCIKLMKDA> IEOCHHPMMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<JHJCIKLMKDA> KJMFHECGAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private JHJCIKLMKDA KFIGKMMCKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly MEFLCMFPLKN JIMPCGDOKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly IHKIFIKDEBP PHPOOIFAPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly JCKKHDIEKOC CPLLIKBPFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HBDFKHEIKGG BPHCHAGIHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, APOPADOIEEN> MLEEILAEICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, FEEKNIJCOCE> MGFMAJMKNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, AIDGFNFNCFH> BKFJEIMGKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim ILAICCNLDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private APOPADOIEEN CDCOHALAGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int NDKHDOHFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<APOPADOIEEN> KGAAJKFCLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private APOPADOIEEN[] NOEJKFEEOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly GKJDIBKICBJ JPNKBPCEFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int BKOPPGEFCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> DLENAEOOJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte OJPDFKEEEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object KOJJJGKGIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool JDAHKEGHFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool FEDAFGDDKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int FFBNIFCKGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int LJPLPDJHIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FFABCEKPLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool EAHKFCHELFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool COFOHDPADDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int ENJHAMJPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int MOKDIJMAGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int IPBODIPIEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool JHOKIIPNOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool BFGMIIKPGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool HBKALHMEBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool PBBMBAIPEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int OCAAJIJHHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int HNBCBICGBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool IIOFKAIBJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly EGLELLCIILC CEIKJNJDOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LFEMGMDBOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly PFEJMNEBNGB AECJJEGFPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool IHMMKEDLLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public LJHEBDNJPME NJFBNMJOCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int DFDNOJMBBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool OPGILLPOHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool KEILHKEHIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool AEEBCBEIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool KGNLHMLAEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MNHDLDDLHDG HINFJGLKPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int ALKKBEGOHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object JKBFIDPABEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int DPEDLPFJJMG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int COADBPBGHCK = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket LEAOHKNFALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket KFMKPLAFDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread ELNCNNKLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread PMFANDBJDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint MBBCFALNCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint ELGHIOOAEJC;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] MKPCGANPLJE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] HLDAOPOHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<LDFNNJKLPKH, IPEndPoint> LCHKFNPFKPG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int PBNFBNOCNEL = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress BMNBACDKLHN;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool EMNPDIFKMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int HILJJJNKPOA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JPFIJPCHNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x118C5B0", Offset = "0x118B3B0", VA = "0x18118C5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x118C5C0", Offset = "0x118B3C0", VA = "0x18118C5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OBFHIBONFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x143DB10", Offset = "0x143C910", VA = "0x18143DB10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x143D5F0", Offset = "0x143C3F0", VA = "0x18143D5F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte ACNBICEHDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x85AA60", Offset = "0x859860", VA = "0x18085AA60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EIAIDBKLOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x51C2FC0", Offset = "0x51C1DC0", VA = "0x1851C2FC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short JOEBDNBFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x51BFB20", Offset = "0x51BE920", VA = "0x1851BFB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51C23F0", Offset = "0x51C11F0", VA = "0x1851C23F0")]
	public void MOLLHIDOLHD(IPEndPoint ABPMHGJKKEP, byte[] GMOPMNAPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51BFB50", Offset = "0x51BE950", VA = "0x1851BFB50")]
	public void JLCKDGLEAPA(IPEndPoint ABPMHGJKKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x51BC930", Offset = "0x51BB730", VA = "0x1851BC930")]
	private bool AGFBFDBENGE(IPEndPoint ABPMHGJKKEP, [Out] APOPADOIEEN GLNHIABFBDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51C2AB0", Offset = "0x51C18B0", VA = "0x1851C2AB0")]
	private void OCEDNKMCFIP(APOPADOIEEN GLNHIABFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51BFAD0", Offset = "0x51BE8D0", VA = "0x1851BFAD0")]
	private void HMCNPKNGKEH(APOPADOIEEN GLNHIABFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51BD4D0", Offset = "0x51BC2D0", VA = "0x1851BD4D0")]
	private void BKDBKLJMKEL(APOPADOIEEN GLNHIABFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x51C3C20", Offset = "0x51C2A20", VA = "0x1851C3C20")]
	public FEGPFBMDAGF(MEFLCMFPLKN AIMEBJCOCBH, [Optional] GKJDIBKICBJ HBNLKICCGIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51C2FE0", Offset = "0x51C1DE0", VA = "0x1851C2FE0")]
	internal void ONFFKICIDIP(APOPADOIEEN NDGMHKJKIGE, int OBDEKMCPHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x51C23A0", Offset = "0x51C11A0", VA = "0x1851C23A0")]
	internal void MOEMHODDHMI(APOPADOIEEN NDGMHKJKIGE, object IGFHPKBICAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x51C3750", Offset = "0x51C2550", VA = "0x1851C3750")]
	internal void PMBFBKDELIE(APOPADOIEEN GLNHIABFBDG, GAIBKLFPDOP BNAPAMOAFNA, SocketError DAHCCGKIPBD, MNHDLDDLHDG BFKHLAANBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x51C2EE0", Offset = "0x51C1CE0", VA = "0x1851C2EE0")]
	private void OLPACDNALGH(APOPADOIEEN GLNHIABFBDG, GAIBKLFPDOP BNAPAMOAFNA, SocketError DAHCCGKIPBD, bool PIOPLCOODHB, byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int NENAAIFMEME, MNHDLDDLHDG BFKHLAANBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x51BD9F0", Offset = "0x51BC7F0", VA = "0x1851BD9F0")]
	private void DGKKJLGNMNC(JHJCIKLMKDA.HBMGOFHBLEC FLHOFPAHPKL, [Optional] APOPADOIEEN GLNHIABFBDG, [Optional] IPEndPoint PBNJEJHDMKF, SocketError OCGNIDFIOOG = SocketError.Success, int OBDEKMCPHGK = 0, GAIBKLFPDOP DKDLIACEEEB = GAIBKLFPDOP.ConnectionFailed, [Optional] FEEKNIJCOCE GJGHCHNFEMN, OMKCMHJCOFJ NGDBGIKCOKN = OMKCMHJCOFJ.Unreliable, byte AFEBDOBMGLE = 0, [Optional] MNHDLDDLHDG OFNINAEBJLK, [Optional] object IGFHPKBICAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x51BE3F0", Offset = "0x51BD1F0", VA = "0x1851BE3F0")]
	private void FLGAAIMKEDK(JHJCIKLMKDA BAKPBNPBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x51C3650", Offset = "0x51C2450", VA = "0x1851C3650")]
	internal void PJHKOOEEICH(JHJCIKLMKDA BAKPBNPBAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x51C0F90", Offset = "0x51BFD90", VA = "0x1851C0F90")]
	private void KHMELFCOJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x51BF480", Offset = "0x51BE280", VA = "0x1851BF480")]
	private void HCKABPODIOJ(int LEMHPMJIJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x51C3030", Offset = "0x51C1E30", VA = "0x1851C3030")]
	internal APOPADOIEEN PIPKLPEMOMO(FEEKNIJCOCE BHMKONDNBED, byte[] POEACHDOMKP, int IHNKLCGMFDI, int JGMNJBPPKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x51BED80", Offset = "0x51BDB80", VA = "0x1851BED80")]
	private int GKLLCCIAFEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x51C2650", Offset = "0x51C1450", VA = "0x1851C2650")]
	private void NIMLFPOHMJB(IPEndPoint PBNJEJHDMKF, APOPADOIEEN KMBFBJJIPEF, OANNNOEPKBO FCPGIBDHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51BFCA0", Offset = "0x51BEAA0", VA = "0x1851BFCA0")]
	private void JLGLABFLINB(MNHDLDDLHDG IMBCEPDODAI, IPEndPoint PBNJEJHDMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x51BD730", Offset = "0x51BC530", VA = "0x1851BD730")]
	internal void BOKCNGBHJAK(MNHDLDDLHDG IMBCEPDODAI, OMKCMHJCOFJ ONHFPAJIPEK, byte AFEBDOBMGLE, int ILBPGNKNOHK, APOPADOIEEN NDGMHKJKIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x51BCB40", Offset = "0x51BB940", VA = "0x1851BCB40")]
	public bool BAOEPALFJFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x51BCAA0", Offset = "0x51BB8A0", VA = "0x1851BCAA0")]
	public bool BAOEPALFJFL(IPAddress DCOOHNLEGHD, IPAddress AHELMHFKHIP, int EJAJDNOKKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x51BCAC0", Offset = "0x51BB8C0", VA = "0x1851BCAC0")]
	public bool BAOEPALFJFL(int EJAJDNOKKJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x51C1F60", Offset = "0x51C0D60", VA = "0x1851C1F60")]
	public void LJFCEHMPAFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x51BF3A0", Offset = "0x51BE1A0", VA = "0x1851BF3A0")]
	public APOPADOIEEN HBMNPCLOOBE(string BOENGMMHJOM, int EJAJDNOKKJL, string GMOPMNAPKBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x51BEEF0", Offset = "0x51BDCF0", VA = "0x1851BEEF0")]
	public APOPADOIEEN HBMNPCLOOBE(string BOENGMMHJOM, int EJAJDNOKKJL, CCEHMELCJFE PKDLKNPDGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x51BEFD0", Offset = "0x51BDDD0", VA = "0x1851BEFD0")]
	public APOPADOIEEN HBMNPCLOOBE(IPEndPoint PABBJIBBIGE, CCEHMELCJFE PKDLKNPDGEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x51BFAC0", Offset = "0x51BE8C0", VA = "0x1851BFAC0")]
	public void HIBINMOMJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x51BF7A0", Offset = "0x51BE5A0", VA = "0x1851BF7A0")]
	public void HIBINMOMJCJ(bool HJPHADJLMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x51C3820", Offset = "0x51C2620", VA = "0x1851C3820")]
	public void POMGLKEBDNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51C3920", Offset = "0x51C2720", VA = "0x1851C3920")]
	public void POMGLKEBDNK(byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51C2D70", Offset = "0x51C1B70", VA = "0x1851C2D70")]
	public void OLPACDNALGH(APOPADOIEEN GLNHIABFBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x51C2E20", Offset = "0x51C1C20", VA = "0x1851C2E20")]
	public void OLPACDNALGH(APOPADOIEEN GLNHIABFBDG, byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x51C3A40", Offset = "0x51C2840", VA = "0x1851C3A40", Slot = "4")]
	private IEnumerator<APOPADOIEEN> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x51C3AD0", Offset = "0x51C28D0", VA = "0x1851C3AD0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51BEC90", Offset = "0x51BDA90", VA = "0x1851BEC90")]
	private MNHDLDDLHDG GAPMHDJLIMM(NCCCEOMOIBP GHOAJKHDDHN, int GINFBCJKIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x51BEBB0", Offset = "0x51BD9B0", VA = "0x1851BEBB0")]
	private MNHDLDDLHDG GAPMHDJLIMM(NCCCEOMOIBP GHOAJKHDDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x51C2490", Offset = "0x51C1290", VA = "0x1851C2490")]
	internal MNHDLDDLHDG NDIDLIDCMGP(int GINFBCJKIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x51C2100", Offset = "0x51C0F00", VA = "0x1851C2100")]
	internal void LOJJHEIGMBL(MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51C3B60", Offset = "0x51C2960", VA = "0x1851C3B60")]
	static FEGPFBMDAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x118C5B0", Offset = "0x118B3B0", VA = "0x18118C5B0")]
	private bool LPNKMMHJMEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x51BEE00", Offset = "0x51BDC00", VA = "0x1851BEE00")]
	private void HACAMCAGNPA(IPEndPoint EKBPIIAFCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x51BC9C0", Offset = "0x51BB7C0", VA = "0x1851BC9C0")]
	private void AKHEECKLIFN(IPEndPoint EKBPIIAFCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x51BD330", Offset = "0x51BC130", VA = "0x1851BD330")]
	private bool BAPEOMMHNFB(SocketException GLNCBNFNGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x51BE1A0", Offset = "0x51BCFA0", VA = "0x1851BE1A0")]
	private void FEEEIANFPGD(Socket EIEBKALMGHH, EndPoint NHPGCJBHLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE10", Offset = "0x51BCC10", VA = "0x1851BDE10")]
	private void EOJKEFLNBEL(object KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x51BC5C0", Offset = "0x51BB3C0", VA = "0x1851BC5C0")]
	private void AEMJBKCPDAC(object KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x51BCB50", Offset = "0x51BB950", VA = "0x1851BCB50")]
	public bool BAOEPALFJFL(IPAddress DCOOHNLEGHD, IPAddress AHELMHFKHIP, int EJAJDNOKKJL, bool LDNKNKNGDPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x51C09F0", Offset = "0x51BF7F0", VA = "0x1851C09F0")]
	private bool KGKMINNHICP(Socket EIEBKALMGHH, IPEndPoint EKBPIIAFCBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x51BDDB0", Offset = "0x51BCBB0", VA = "0x1851BDDB0")]
	internal int DMBGDEILNCG(MNHDLDDLHDG IMBCEPDODAI, IPEndPoint PBNJEJHDMKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51C1F20", Offset = "0x51C0D20", VA = "0x1851C1F20")]
	internal int LANDMHKLBHC(MNHDLDDLHDG IMBCEPDODAI, IPEndPoint PBNJEJHDMKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x51C12D0", Offset = "0x51C00D0", VA = "0x1851C12D0")]
	internal int LANDMHKLBHC(byte[] BLAOEBOMGGP, int IHNKLCGMFDI, int JGMNJBPPKGP, IPEndPoint PBNJEJHDMKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x51C2270", Offset = "0x51C1070", VA = "0x1851C2270")]
	internal void LPLLANFNAJP(bool NCHBPLFAABI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum NCCCEOMOIBP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class MNHDLDDLHDG
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int KOGOCONGEPA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] GKEBALCFHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] OJIAKPOALIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int MGLJLKOIJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object OAFLMDPMEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public MNHDLDDLHDG FKIKGLFLOCI;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NCCCEOMOIBP ENEPIPEMHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x51C79B0", Offset = "0x51C67B0", VA = "0x1851C79B0")]
		get
		{
			return default(NCCCEOMOIBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x51C79E0", Offset = "0x51C67E0", VA = "0x1851C79E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte BHOFMDBIMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x51C7980", Offset = "0x51C6780", VA = "0x1851C7980")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x51C7D70", Offset = "0x51C6B70", VA = "0x1851C7D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort GNKJBILDOGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x51C7880", Offset = "0x51C6680", VA = "0x1851C7880")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x51C7940", Offset = "0x51C6740", VA = "0x1851C7940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MPHIPNLECFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x51C7DB0", Offset = "0x51C6BB0", VA = "0x1851C7DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LDNGKPLDAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x51C7DE0", Offset = "0x51C6BE0", VA = "0x1851C7DE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x51C7E70", Offset = "0x51C6C70", VA = "0x1851C7E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JINFHACFHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x51C7E10", Offset = "0x51C6C10", VA = "0x1851C7E10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x51C7C00", Offset = "0x51C6A00", VA = "0x1851C7C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ALKDAPPPMLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x51C78E0", Offset = "0x51C66E0", VA = "0x1851C78E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x51C7B20", Offset = "0x51C6920", VA = "0x1851C7B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort OPLKEBHDFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x51C7B60", Offset = "0x51C6960", VA = "0x1851C7B60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x51C7BC0", Offset = "0x51C69C0", VA = "0x1851C7BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x51C7EA0", Offset = "0x51C6CA0", VA = "0x1851C7EA0")]
	static MNHDLDDLHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x51C7D40", Offset = "0x51C6B40", VA = "0x1851C7D40")]
	public void JIPFPNHKJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x51C8180", Offset = "0x51C6F80", VA = "0x1851C8180")]
	public MNHDLDDLHDG(int GINFBCJKIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x51C81F0", Offset = "0x51C6FF0", VA = "0x1851C81F0")]
	public MNHDLDDLHDG(NCCCEOMOIBP GHOAJKHDDHN, int GINFBCJKIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x51C7C40", Offset = "0x51C6A40", VA = "0x1851C7C40")]
	public static int HNBKMPFNPFB(NCCCEOMOIBP GHOAJKHDDHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x51C7CB0", Offset = "0x51C6AB0", VA = "0x1851C7CB0")]
	public int HNBKMPFNPFB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x51C7A20", Offset = "0x51C6820", VA = "0x1851C7A20")]
	public bool DBFDEKBGBNE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum BCNLMCJIBIO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal enum ONIKNJMIGMD
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal enum OOMJOANMALI
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum PCOJCIAGLDK
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class APOPADOIEEN
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class PFNILANBLHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MNHDLDDLHDG[] MLBOHBFNHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int KMKDDJCCIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int ABJJGFPGJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte LDNGKPLDAJM;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PFNILANBLHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void KJEDBCIJMHN(ulong JIKMCCCHECI, int DAAJMDOJDFK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int KEOPCKFBJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int KOPIOPHHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int BMOMIMIBMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double JNJHJBDLEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int CJBEHDPDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int GJIPGEFEFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch BDCMIADDHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int CEHFLKBBKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long OPGDENJNDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object ENNNABABAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal APOPADOIEEN IKBKOEBCDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal APOPADOIEEN IFCOPLBMHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<MNHDLDDLHDG> GBAIICJNBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<HLEDCNBOCPK> NJDLPPKCFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly HLEDCNBOCPK[] AODDHKIOJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int CGJAFPFINCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int LAEOEBEEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool LLHDBGANHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int LKGFDDAINGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int IGCAELMMMHH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int GKGPEFIIHNH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int HLIKKAMJDNN = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object KGCCPLAGDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int JBCBMIBLDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, PFNILANBLHJ> AEHLHIAKCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> HDNADLEKBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly MNHDLDDLHDG PBKNPPBPGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int KOEKKLHBGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CGCNGHDAHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint AHHPEELJIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int OJNMDMBJDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int AEGMOAOOIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long HLBEOMDNGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte MJLIKCFFDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private BCNLMCJIBIO GGHNJIECEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private MNHDLDDLHDG IKDHGOEPDDE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int GPDEMAPKHIN = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int HLOCBKAEDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly MNHDLDDLHDG KNNGLMCAJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MNHDLDDLHDG JPPKIPHHODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly MNHDLDDLHDG MPHAENKLPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MNHDLDDLHDG IEEJDOINAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly FEGPFBMDAGF CMBCABFAGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int IOFNGFNIBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object CJNEOCNMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly EGLELLCIILC CEIKJNJDOFN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte HIJCHIBNGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xFCCF30", Offset = "0xFCBD30", VA = "0x180FCCF30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x51B6AC0", Offset = "0x51B58C0", VA = "0x1851B6AC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint DECGCAJMEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B90E0", Offset = "0x8B7EE0", VA = "0x1808B90E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BCNLMCJIBIO PAEFAPFMMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFCCF60", Offset = "0xFCBD60", VA = "0x180FCCF60")]
		get
		{
			return default(BCNLMCJIBIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long DEABKDIAEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B90F0", Offset = "0x8B7EF0", VA = "0x1808B90F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HNNNJNEGOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x143DB20", Offset = "0x143C920", VA = "0x18143DB20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x143CDD0", Offset = "0x143BBD0", VA = "0x18143CDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int EHEKHEKKNMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x51B4050", Offset = "0x51B2E50", VA = "0x1851B4050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MLDJDKFOAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double NPAHDGMKCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1642F60", Offset = "0x1641D60", VA = "0x181642F60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KJEDBCIJMHN JCCNOPMDPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x51B7320", Offset = "0x51B6120", VA = "0x1851B7320")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x51B6590", Offset = "0x51B5390", VA = "0x1851B6590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x51B7560", Offset = "0x51B6360", VA = "0x1851B7560")]
	internal APOPADOIEEN(FEGPFBMDAGF IBIEAOMLONP, IPEndPoint PBNJEJHDMKF, int KKIIDNMAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x51B6B70", Offset = "0x51B5970", VA = "0x1851B6B70")]
	internal void PABJAGLCMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x51B57A0", Offset = "0x51B45A0", VA = "0x1851B57A0")]
	internal void JMOLMDNHJFN(IPEndPoint CCHMFFJPFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x51B7290", Offset = "0x51B6090", VA = "0x1851B7290")]
	internal void PHPIDNCDNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x51B58B0", Offset = "0x51B46B0", VA = "0x1851B58B0")]
	private void KGDIAILBMAI(int KNFGLGBJKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x51B5770", Offset = "0x51B4570", VA = "0x1851B5770")]
	private void JIMBOJLAOHN(int NKDDBGDDEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x51B4060", Offset = "0x51B2E60", VA = "0x1851B4060")]
	private HLEDCNBOCPK BPHLCONENND(byte BMDADOLNDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x51B73D0", Offset = "0x51B61D0", VA = "0x1851B73D0")]
	internal APOPADOIEEN(FEGPFBMDAGF IBIEAOMLONP, IPEndPoint PBNJEJHDMKF, int KKIIDNMAMKF, byte NDBKLPFHIAB, CCEHMELCJFE EMBJACFFBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x51B79C0", Offset = "0x51B67C0", VA = "0x1851B79C0")]
	internal APOPADOIEEN(FEGPFBMDAGF IBIEAOMLONP, FEEKNIJCOCE BHMKONDNBED, int KKIIDNMAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x51B5980", Offset = "0x51B4780", VA = "0x1851B5980")]
	internal void LFILAFBAHAE(OANNNOEPKBO GKILFNNDLIA, byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x51B5690", Offset = "0x51B4490", VA = "0x1851B5690")]
	internal bool IHEKOEEKDLK(DFIFKPJJGOP IMBCEPDODAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x51B4FB0", Offset = "0x51B3DB0", VA = "0x1851B4FB0")]
	public void GGFCBONHGMC(byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int JGMNJBPPKGP, OMKCMHJCOFJ IPHFHMOKOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x51B59D0", Offset = "0x51B47D0", VA = "0x1851B59D0")]
	private void LIFGBHAPKPP(byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int JGMNJBPPKGP, byte AFEBDOBMGLE, OMKCMHJCOFJ NGDBGIKCOKN, object IGFHPKBICAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x51B5F20", Offset = "0x51B4D20", VA = "0x1851B5F20")]
	public void MKDIBJNBIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x51B57D0", Offset = "0x51B45D0", VA = "0x1851B57D0")]
	internal OOMJOANMALI KFGELLLDLDO(MNHDLDDLHDG IMBCEPDODAI)
	{
		return default(OOMJOANMALI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x51B5710", Offset = "0x51B4510", VA = "0x1851B5710")]
	internal void JCPFHMOMELP(HLEDCNBOCPK EFDHEOHHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x51B4CA0", Offset = "0x51B3AA0", VA = "0x1851B4CA0")]
	internal PCOJCIAGLDK GFKOEPCEEML(byte[] LMCJHCIOIIP, int IHNKLCGMFDI, int JGMNJBPPKGP, bool PIOPLCOODHB)
	{
		return default(PCOJCIAGLDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x51B6550", Offset = "0x51B5350", VA = "0x1851B6550")]
	private void NGMAKJLKFMK(int NLEGMALDBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x51B4210", Offset = "0x51B3010", VA = "0x1851B4210")]
	internal void DGOGIJEEIMP(OMKCMHJCOFJ ONHFPAJIPEK, MNHDLDDLHDG ADKJANDCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x51B6B90", Offset = "0x51B5990", VA = "0x1851B6B90")]
	private void PEFDIIMCKLB(MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x51B3CE0", Offset = "0x51B2AE0", VA = "0x1851B3CE0")]
	private void AONJIKMDNIO(int CILPHFINCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x51B6640", Offset = "0x51B5440", VA = "0x1851B6640")]
	internal ONIKNJMIGMD NIMLFPOHMJB(OANNNOEPKBO FCPGIBDHNLH)
	{
		return default(ONIKNJMIGMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x51B4FE0", Offset = "0x51B3DE0", VA = "0x1851B4FE0")]
	internal void HBDLDJIAJNJ(MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x51B4BA0", Offset = "0x51B39A0", VA = "0x1851B4BA0")]
	private void GBNOEKLEOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x51B70E0", Offset = "0x51B5EE0", VA = "0x1851B70E0")]
	internal void PFCIMKJCMLI(MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x51B5FD0", Offset = "0x51B4DD0", VA = "0x1851B5FD0")]
	internal void NCDLFODJGAN(int CILPHFINCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x51B6800", Offset = "0x51B5600", VA = "0x1851B6800")]
	internal void OGGCCALOJEN(MNHDLDDLHDG IMBCEPDODAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class EGLELLCIILC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long LDONJCLOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HGCIPPOKPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DCCOALGLKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long KHLGJAHMLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long PMEDIEEHLBJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long AFBOFAAEHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x51BBF50", Offset = "0x51BAD50", VA = "0x1851BBF50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long CMAAMKHBBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x51BBFE0", Offset = "0x51BADE0", VA = "0x1851BBFE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long IEJAMMMDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x51BBFF0", Offset = "0x51BADF0", VA = "0x1851BBFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long ABCABEDHPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x51BBF70", Offset = "0x51BAD70", VA = "0x1851BBF70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long CNJLNKFAMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x51BC010", Offset = "0x51BAE10", VA = "0x1851BC010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long ADPBGLEMCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x51BBF90", Offset = "0x51BAD90", VA = "0x1851BBF90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x51BBF60", Offset = "0x51BAD60", VA = "0x1851BBF60")]
	public void CLAGMGAOJGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x51BC030", Offset = "0x51BAE30", VA = "0x1851BC030")]
	public void MONDJKBDHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x51BC040", Offset = "0x51BAE40", VA = "0x1851BC040")]
	public void OABGPMDLCLB(long AIMILAKFGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x51BC020", Offset = "0x51BAE20", VA = "0x1851BC020")]
	public void MDGJGNDFMMN(long MKCCGIIPBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x51BBF80", Offset = "0x51BAD80", VA = "0x1851BBF80")]
	public void GCCCOAODGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x51BC000", Offset = "0x51BAE00", VA = "0x1851BC000")]
	public void JFLPFDGHDIC(long DJGKGCPFIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51BC050", Offset = "0x51BAE50", VA = "0x1851BC050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public EGLELLCIILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class GHPIGLFLNCA
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> NCPKHBLIGNC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x51C4450", Offset = "0x51C3250", VA = "0x1851C4450")]
	public static IPEndPoint CFFLNKBAPGN(string LHIBBJEFKMH, int EJAJDNOKKJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x51C4760", Offset = "0x51C3560", VA = "0x1851C4760")]
	public static IPAddress HDACHGPKLAI(string LHIBBJEFKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x51C46D0", Offset = "0x51C34D0", VA = "0x1851C46D0")]
	public static IPAddress HDACHGPKLAI(string LHIBBJEFKMH, AddressFamily IIMJKBLPNCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x51C46A0", Offset = "0x51C34A0", VA = "0x1851C46A0")]
	internal static int FBICOABHLNP(int LAIECOKBJPH, int KGNHAOBOCKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x239C1B0", Offset = "0x239AFB0", VA = "0x18239C1B0")]
	internal static T[] GLAPADDAJKK<T>(int NENAAIFMEME) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class DBPLGKGOIME : HLEDCNBOCPK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct IMIPADKBILB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MNHDLDDLHDG KPFAHHGPIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long GBKPEKHGDBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool BHHFLIHDCEA;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x51C4E60", Offset = "0x51C3C60", VA = "0x1851C4E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x51C4E40", Offset = "0x51C3C40", VA = "0x1851C4E40")]
		public void LKOIJBFKMJL(MNHDLDDLHDG IMBCEPDODAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x51C4D80", Offset = "0x51C3B80", VA = "0x1851C4D80")]
		public bool FAGLICBFIEA(long MGPAONHKGHN, APOPADOIEEN GLNHIABFBDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x51C4DF0", Offset = "0x51C3BF0", VA = "0x1851C4DF0")]
		public bool LHLJEDFLAKN(APOPADOIEEN GLNHIABFBDG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly MNHDLDDLHDG CLGLDIIECEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly IMIPADKBILB[] EHIEOMLCJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly MNHDLDDLHDG[] CGHIBIHNNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] GOBDHELMFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int HKCIGCGPOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int PGEACCJMJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int KAAOIICBDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int KNCFDPHKIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool IPGHPDKCLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly OMKCMHJCOFJ HLFGMGKMIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool KANGFIAMFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int JIADJKMNJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte DNGDIDMGDGI;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x51BA430", Offset = "0x51B9230", VA = "0x1851BA430")]
	public DBPLGKGOIME(APOPADOIEEN GLNHIABFBDG, bool PKEAEGOCMNE, byte KKIIDNMAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x51BA080", Offset = "0x51B8E80", VA = "0x1851BA080")]
	private void HOJJLJBEGMM(MNHDLDDLHDG IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x51B9570", Offset = "0x51B8370", VA = "0x1851B9570", Slot = "4")]
	protected override bool ENOABKJMPML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x51B9A20", Offset = "0x51B8820", VA = "0x1851B9A20", Slot = "5")]
	public override bool HBDLDJIAJNJ(MNHDLDDLHDG IMBCEPDODAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class KPEILMBDMFF : HLEDCNBOCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int NHOOAEOOKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort PGEACCJMJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool DHACEIGLJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private MNHDLDDLHDG CLFIGPPBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly MNHDLDDLHDG KODNMAKPOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool IAEIALJLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte DNGDIDMGDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long EKJCEHJIJJK;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x51C5AD0", Offset = "0x51C48D0", VA = "0x1851C5AD0")]
	public KPEILMBDMFF(APOPADOIEEN GLNHIABFBDG, bool MDDLJKAACHH, byte KKIIDNMAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x51C5380", Offset = "0x51C4180", VA = "0x1851C5380", Slot = "4")]
	protected override bool ENOABKJMPML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x51C57F0", Offset = "0x51C45F0", VA = "0x1851C57F0", Slot = "5")]
	public override bool HBDLDJIAJNJ(MNHDLDDLHDG IMBCEPDODAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IJNKAOMCNPL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct INFNHMHBEEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong EIAFDFHGJEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double DOINBHEPNMA;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct BKLMOPOPEGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int IEBPIKJHIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float MKCPPGJMBOD;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x51B3A60", Offset = "0x51B2860", VA = "0x1851B3A60")]
	private static void HDHDKMMBLOG(byte[] BLPPMOBNKNN, int NNACFOFLCKF, ulong LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x51C4C20", Offset = "0x51C3A20", VA = "0x1851C4C20")]
	private static void HDHDKMMBLOG(byte[] BLPPMOBNKNN, int NNACFOFLCKF, int LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x51C4C90", Offset = "0x51C3A90", VA = "0x1851C4C90")]
	public static void HDHDKMMBLOG(byte[] BLPPMOBNKNN, int NNACFOFLCKF, short LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x51C4D60", Offset = "0x51C3B60", VA = "0x1851C4D60")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, double POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x51C4CD0", Offset = "0x51C3AD0", VA = "0x1851C4CD0")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x51C4C90", Offset = "0x51C3A90", VA = "0x1851C4C90")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, short POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x51C4C90", Offset = "0x51C3A90", VA = "0x1851C4C90")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, ushort POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x51C4C20", Offset = "0x51C3A20", VA = "0x1851C4C20")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x51C4C20", Offset = "0x51C3A20", VA = "0x1851C4C20")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, uint POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x51C4D50", Offset = "0x51C3B50", VA = "0x1851C4D50")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, long POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x51C4D50", Offset = "0x51C3B50", VA = "0x1851C4D50")]
	public static void NPPDOIBJFIL(byte[] LKHDKNBOMJD, int IJBCLDGENAJ, ulong POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PCHKKKEDCOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] GLDGIPKLAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int LOJAJLJPOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int LFFHNAFBAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int LLHFFPPPOHD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] OJIAKPOALIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FGPNMAJLDFB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NOKEPHEPMID
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x51CA450", Offset = "0x51C9250", VA = "0x1851CA450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool NGCAEMIKDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1B95DE0", Offset = "0x1B94BE0", VA = "0x181B95DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LEOGGDDOOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x51C9AE0", Offset = "0x51C88E0", VA = "0x1851C9AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x51CA110", Offset = "0x51C8F10", VA = "0x1851CA110")]
	public void JLCGBEEDJNK(byte[] PGGBKFCMLMO, int NNACFOFLCKF, int DMKEHDNKMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PCHKKKEDCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x51CA660", Offset = "0x51C9460", VA = "0x1851CA660")]
	public PCHKKKEDCOJ(byte[] PGGBKFCMLMO, int NNACFOFLCKF, int DMKEHDNKMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51C9BB0", Offset = "0x51C89B0", VA = "0x1851C9BB0")]
	public IPEndPoint DEMCJHJDGMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x51C9B70", Offset = "0x51C8970", VA = "0x1851C9B70")]
	public byte CKKFNPECCCH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x51C9B70", Offset = "0x51C8970", VA = "0x1851C9B70")]
	public sbyte OIGHAJBDJMM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x250F130", Offset = "0x250DF30", VA = "0x18250F130")]
	public T[] KGIGIIGAEPE<T>(ushort GINFBCJKIJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x51CA530", Offset = "0x51C9330", VA = "0x1851CA530")]
	public bool[] ONKIMIPBHJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x51C9CC0", Offset = "0x51C8AC0", VA = "0x1851C9CC0")]
	public ushort[] DPIFOBCDLFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x51CA3D0", Offset = "0x51C91D0", VA = "0x1851CA3D0")]
	public short[] KGOMMIEPGOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x51C9AF0", Offset = "0x51C88F0", VA = "0x1851C9AF0")]
	public int[] BHMAMOMGMBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x51CA5B0", Offset = "0x51C93B0", VA = "0x1851CA5B0")]
	public uint[] OOGGNLKIDCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51C9C80", Offset = "0x51C8A80", VA = "0x1851C9C80")]
	public float[] DICJBNCKCJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51CA480", Offset = "0x51C9280", VA = "0x1851CA480")]
	public double[] MHDNLEAFABD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x51C9F10", Offset = "0x51C8D10", VA = "0x1851C9F10")]
	public long[] GDMAJEBIFOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x51CA570", Offset = "0x51C9370", VA = "0x1851CA570")]
	public ulong[] ONOCLGIHGMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x51C9D70", Offset = "0x51C8B70", VA = "0x1851C9D70")]
	public string[] EPLKABPNPCP(int LJHDFPPAEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x51CA410", Offset = "0x51C9210", VA = "0x1851CA410")]
	public bool KJGDAKNPLCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x51C9EA0", Offset = "0x51C8CA0", VA = "0x1851C9EA0")]
	public char FEHIKKPHEDP()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51C9EA0", Offset = "0x51C8CA0", VA = "0x1851C9EA0")]
	public ushort KGMFGICIFCB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x51C9F50", Offset = "0x51C8D50", VA = "0x1851C9F50")]
	public short GICBJJHFPJG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x51CA030", Offset = "0x51C8E30", VA = "0x1851CA030")]
	public long IFOOFNOGFCO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x51CA5F0", Offset = "0x51C93F0", VA = "0x1851CA5F0")]
	public ulong PEGAHBGIHJN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x51C9A70", Offset = "0x51C8870", VA = "0x1851C9A70")]
	public int ABOCIJPNCMD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x51C9FC0", Offset = "0x51C8DC0", VA = "0x1851C9FC0")]
	public uint HPIJDHEHLBM()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x51CA0A0", Offset = "0x51C8EA0", VA = "0x1851CA0A0")]
	public float JCNBKMKJGNB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x51CA4C0", Offset = "0x51C92C0", VA = "0x1851CA4C0")]
	public double MOCDJINFKEE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x51CA190", Offset = "0x51C8F90", VA = "0x1851CA190")]
	public string KAPJPOFLBFF(int MMGMGPHHDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x51C9D00", Offset = "0x51C8B00", VA = "0x1851C9D00")]
	public ArraySegment<byte> EBHKBANKIMP(int NENAAIFMEME)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x51C9B30", Offset = "0x51C8930", VA = "0x1851C9B30")]
	public sbyte[] CFMMIINPPHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x51CA150", Offset = "0x51C8F50", VA = "0x1851CA150")]
	public byte[] JOFLIJEAAFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x51CA460", Offset = "0x51C9260", VA = "0x1851CA460")]
	public void LHLJEDFLAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CCEHMELCJFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] GLDGIPKLAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int LOJAJLJPOKC;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int CIBJEJOBBKI = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool KEBBOFJFPKH;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding FOANPMMGDCN;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int GGGEEGKIPKG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] CONNEAJEJOA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] NCHGGNHAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GFHGMKIJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x51B88D0", Offset = "0x51B76D0", VA = "0x1851B88D0")]
	public CCEHMELCJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x51B8950", Offset = "0x51B7750", VA = "0x1851B8950")]
	public CCEHMELCJFE(bool CPGKJOMMNGM, int JBAAECKLFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x51B7BA0", Offset = "0x51B69A0", VA = "0x1851B7BA0")]
	public static CCEHMELCJFE BKJFGPAENGG(string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x51B8140", Offset = "0x51B6F40", VA = "0x1851B8140")]
	public void NBJFGBALBOP(int FFKAIEDDKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C0F6E0", Offset = "0x1C0E4E0", VA = "0x181C0F6E0")]
	public void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x51B8590", Offset = "0x51B7390", VA = "0x1851B8590")]
	public void OJOBPMMMGPP(float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x51B8630", Offset = "0x51B7430", VA = "0x1851B8630")]
	public void OJOBPMMMGPP(double POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x51B8330", Offset = "0x51B7130", VA = "0x1851B8330")]
	public void OJOBPMMMGPP(long POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x51B8330", Offset = "0x51B7130", VA = "0x1851B8330")]
	public void OJOBPMMMGPP(ulong POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x51B8680", Offset = "0x51B7480", VA = "0x1851B8680")]
	public void OJOBPMMMGPP(int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x51B8680", Offset = "0x51B7480", VA = "0x1851B8680")]
	public void OJOBPMMMGPP(uint POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x51B82C0", Offset = "0x51B70C0", VA = "0x1851B82C0")]
	public void OJOBPMMMGPP(char POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x51B82C0", Offset = "0x51B70C0", VA = "0x1851B82C0")]
	public void OJOBPMMMGPP(ushort POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x51B82C0", Offset = "0x51B70C0", VA = "0x1851B82C0")]
	public void OJOBPMMMGPP(short POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x51B8770", Offset = "0x51B7570", VA = "0x1851B8770")]
	public void OJOBPMMMGPP(sbyte POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x51B8770", Offset = "0x51B7570", VA = "0x1851B8770")]
	public void OJOBPMMMGPP(byte POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x51B87D0", Offset = "0x51B75D0", VA = "0x1851B87D0")]
	public void OJOBPMMMGPP(byte[] LMCJHCIOIIP, int NNACFOFLCKF, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x51B7C10", Offset = "0x51B6A10", VA = "0x1851B7C10")]
	public void HLNKBNKKAPF(sbyte[] LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x51B7C10", Offset = "0x51B6A10", VA = "0x1851B7C10")]
	public void GCBGKIKHPNP(byte[] LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x51B8710", Offset = "0x51B7510", VA = "0x1851B8710")]
	public void OJOBPMMMGPP(bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x51B7DD0", Offset = "0x51B6BD0", VA = "0x1851B7DD0")]
	public void MFFGNACDMHM(Array GGEKJGOLDKP, int BALDKBFADKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x51B8060", Offset = "0x51B6E60", VA = "0x1851B8060")]
	public void MFFGNACDMHM(float[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x51B7CF0", Offset = "0x51B6AF0", VA = "0x1851B7CF0")]
	public void MFFGNACDMHM(double[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x51B7CF0", Offset = "0x51B6AF0", VA = "0x1851B7CF0")]
	public void MFFGNACDMHM(long[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x51B7CF0", Offset = "0x51B6AF0", VA = "0x1851B7CF0")]
	public void MFFGNACDMHM(ulong[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x51B8060", Offset = "0x51B6E60", VA = "0x1851B8060")]
	public void MFFGNACDMHM(int[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x51B8060", Offset = "0x51B6E60", VA = "0x1851B8060")]
	public void MFFGNACDMHM(uint[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x51B7EB0", Offset = "0x51B6CB0", VA = "0x1851B7EB0")]
	public void MFFGNACDMHM(ushort[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x51B7EB0", Offset = "0x51B6CB0", VA = "0x1851B7EB0")]
	public void MFFGNACDMHM(short[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x51B7C10", Offset = "0x51B6A10", VA = "0x1851B7C10")]
	public void MFFGNACDMHM(bool[] POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x51B7F90", Offset = "0x51B6D90", VA = "0x1851B7F90")]
	public void MFFGNACDMHM(string[] POACLGOFKAJ, int LAPAMMCBDDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x51B81F0", Offset = "0x51B6FF0", VA = "0x1851B81F0")]
	public void OJOBPMMMGPP(IPEndPoint ABPMHGJKKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x51B81E0", Offset = "0x51B6FE0", VA = "0x1851B81E0")]
	public void OJOBPMMMGPP(string POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x51B8380", Offset = "0x51B7180", VA = "0x1851B8380")]
	public void OJOBPMMMGPP(string POACLGOFKAJ, int MMGMGPHHDNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class JGACGBHOLHD
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class PBGDDKIGMGP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong IOFNGFNIBGB;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3D74680", Offset = "0x3D73480", VA = "0x183D74680")]
		static PBGDDKIGMGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void FMMMNMEDLMJ(PCHKKKEDCOJ GFNJLJABMCF, object IGFHPKBICAA);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class LAIFOFMLIFK<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public JGACGBHOLHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LAIFOFMLIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3950700", Offset = "0x394F500", VA = "0x183950700")]
		internal void MFBFOCEDOPC(PCHKKKEDCOJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class AAAPJELMMEC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public JGACGBHOLHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AAAPJELMMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x343ABA0", Offset = "0x34399A0", VA = "0x18343ABA0")]
		internal void MFBFOCEDOPC(PCHKKKEDCOJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly HBKLPBKENAM AFDKKABHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, FMMMNMEDLMJ> CMBPJLNPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly CCEHMELCJFE PMCBNLLHJIJ;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x51C5100", Offset = "0x51C3F00", VA = "0x1851C5100")]
	public JGACGBHOLHD(int LJHDFPPAEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x2160C40", Offset = "0x215FA40", VA = "0x182160C40", Slot = "4")]
	protected virtual ulong FDNPDBJPKIF<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x51C4F80", Offset = "0x51C3D80", VA = "0x1851C4F80", Slot = "5")]
	protected virtual FMMMNMEDLMJ HEIKIGMDMDD(PCHKKKEDCOJ GFNJLJABMCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2410C40", Offset = "0x240FA40", VA = "0x182410C40", Slot = "6")]
	protected virtual void IEKJKKBOAAM<T>(CCEHMELCJFE FNEJOGEIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x51C4F00", Offset = "0x51C3D00", VA = "0x1851C4F00")]
	public void DKFEJBMLKNN(PCHKKKEDCOJ GFNJLJABMCF, object IGFHPKBICAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2410BB0", Offset = "0x240F9B0", VA = "0x182410BB0")]
	public void FFKIDNKHFEK<T>(CCEHMELCJFE FNEJOGEIEJN, T IMBCEPDODAI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x51C50B0", Offset = "0x51C3EB0", VA = "0x1851C50B0")]
	public void NCPLIIMEGBN(PCHKKKEDCOJ GFNJLJABMCF, object IGFHPKBICAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2410A30", Offset = "0x240F830", VA = "0x182410A30")]
	public void CBANJMIFEDB<T>(Action<T> IGONLOFIDKC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x24108B0", Offset = "0x240F6B0", VA = "0x1824108B0")]
	public void CBANJMIFEDB<T, TUserData>(Action<T, TUserData> IGONLOFIDKC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class MMMBMDPAGDB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x51BA600", Offset = "0x51B9400", VA = "0x1851BA600")]
	public MMMBMDPAGDB(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class KEKCCNLPNGI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x51C5320", Offset = "0x51C4120", VA = "0x1851C5320")]
	public KEKCCNLPNGI(string BLAOEBOMGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class HBKLPBKENAM
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum FMIFFOJKNEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class HIDEGMDKKKH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public FMIFFOJKNEP HHINMKNAKNJ;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x35DCFF0", Offset = "0x35DBDF0", VA = "0x1835DCFF0", Slot = "4")]
		public virtual void LKOIJBFKMJL(MethodInfo BDDOHEMJIJO, MethodInfo KJOLPDIMNAJ, FMIFFOJKNEP FLHOFPAHPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void NLJILGKJHEG(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void KOEJFKFDNKJ(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		protected HIDEGMDKKKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class MFAIHIGJEHN<TClass, TProperty> : HIDEGMDKKKH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> GADGBMPMMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> NFKFDKKKCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> LGLDFMEAEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> CEOIHABFJKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> FKOKPGKGBIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> HIFLIPIFCAO;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3B63630", Offset = "0x3B62430", VA = "0x183B63630", Slot = "7")]
		public override void OJFAKILKOME(TClass PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3B62E50", Offset = "0x3B61C50", VA = "0x183B62E50", Slot = "8")]
		public override void OIAMJNJFBPK(TClass PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3B62210", Offset = "0x3B61010", VA = "0x183B62210", Slot = "9")]
		public override void NLJILGKJHEG(TClass PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CAF0", Offset = "0x3B5B8F0", VA = "0x183B5CAF0", Slot = "10")]
		public override void KOEJFKFDNKJ(TClass PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3B5CD90", Offset = "0x3B5BB90", VA = "0x183B5CD90")]
		protected TProperty[] LBBJOMNELBF(TClass PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3B63B70", Offset = "0x3B62970", VA = "0x183B63B70")]
		protected TProperty[] OPNJCJAOIHN(TClass PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3B60250", Offset = "0x3B5F050", VA = "0x183B60250", Slot = "4")]
		public override void LKOIJBFKMJL(MethodInfo BDDOHEMJIJO, MethodInfo KJOLPDIMNAJ, FMIFFOJKNEP FLHOFPAHPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x34C0670", Offset = "0x34BF470", VA = "0x1834C0670")]
		protected MFAIHIGJEHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class EGKKIJBNPNG<TClass, TProperty> : MFAIHIGJEHN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void BLFHPHPHMAN(PCHKKKEDCOJ CAAEKLGIBGJ, [Out] TProperty CONHAFAMJMM);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void KHBAIBEEHBE(CCEHMELCJFE NHNDDOIAEPK, TProperty CONHAFAMJMM);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3029930", Offset = "0x3028730", VA = "0x183029930", Slot = "5")]
		public override void BAFAPCMDNFI(TClass PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x30299B0", Offset = "0x30287B0", VA = "0x1830299B0", Slot = "6")]
		public override void FFKIDNKHFEK(TClass PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3029BD0", Offset = "0x30289D0", VA = "0x183029BD0", Slot = "7")]
		public override void OJFAKILKOME(TClass PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3029A90", Offset = "0x3028890", VA = "0x183029A90", Slot = "8")]
		public override void OIAMJNJFBPK(TClass PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3029D10", Offset = "0x3028B10", VA = "0x183029D10")]
		protected EGKKIJBNPNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GDKPFCHMLBG<T> : MFAIHIGJEHN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x34820F0", Offset = "0x3480EF0", VA = "0x1834820F0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3482160", Offset = "0x3480F60", VA = "0x183482160", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x34821C0", Offset = "0x3480FC0", VA = "0x1834821C0", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x300AB80", Offset = "0x3009980", VA = "0x18300AB80", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public GDKPFCHMLBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DHOCEEMCCLD<T> : MFAIHIGJEHN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4C667F0", Offset = "0x4C655F0", VA = "0x184C667F0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3482160", Offset = "0x3480F60", VA = "0x183482160", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4C66860", Offset = "0x4C65660", VA = "0x184C66860", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x300AB80", Offset = "0x3009980", VA = "0x18300AB80", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public DHOCEEMCCLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class NAFMJLJJFFA<T> : MFAIHIGJEHN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF360", Offset = "0x3BCE160", VA = "0x183BCF360", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BEB0", Offset = "0x3B6ACB0", VA = "0x183B6BEB0", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF3D0", Offset = "0x3BCE1D0", VA = "0x183BCF3D0", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BF10", Offset = "0x3B6AD10", VA = "0x183B6BF10", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public NAFMJLJJFFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MINPPHCGMGE<T> : MFAIHIGJEHN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BE40", Offset = "0x3B6AC40", VA = "0x183B6BE40", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BEB0", Offset = "0x3B6ACB0", VA = "0x183B6BEB0", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BF70", Offset = "0x3B6AD70", VA = "0x183B6BF70", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BF10", Offset = "0x3B6AD10", VA = "0x183B6BF10", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public MINPPHCGMGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class MHJPIKGCIAJ<T> : MFAIHIGJEHN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BA70", Offset = "0x3B6A870", VA = "0x183B6BA70", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BAE0", Offset = "0x3B6A8E0", VA = "0x183B6BAE0", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BB40", Offset = "0x3B6A940", VA = "0x183B6BB40", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x366DF00", Offset = "0x366CD00", VA = "0x18366DF00", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public MHJPIKGCIAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CFGOILODIPE<T> : MFAIHIGJEHN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x47821E0", Offset = "0x4780FE0", VA = "0x1847821E0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B6BAE0", Offset = "0x3B6A8E0", VA = "0x183B6BAE0", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4782250", Offset = "0x4781050", VA = "0x184782250", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x366DF00", Offset = "0x366CD00", VA = "0x18366DF00", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public CFGOILODIPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class KFCCKFEFDHN<T> : MFAIHIGJEHN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x35EBFD0", Offset = "0x35EADD0", VA = "0x1835EBFD0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x35EC040", Offset = "0x35EAE40", VA = "0x1835EC040", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x38A1AC0", Offset = "0x38A08C0", VA = "0x1838A1AC0", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x35EC0A0", Offset = "0x35EAEA0", VA = "0x1835EC0A0", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public KFCCKFEFDHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HOBDEBNOOMM<T> : MFAIHIGJEHN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x35EBFD0", Offset = "0x35EADD0", VA = "0x1835EBFD0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x35EC040", Offset = "0x35EAE40", VA = "0x1835EC040", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x35EC100", Offset = "0x35EAF00", VA = "0x1835EC100", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x35EC0A0", Offset = "0x35EAEA0", VA = "0x1835EC0A0", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public HOBDEBNOOMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ECPIHGEMDEL<T> : MFAIHIGJEHN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x300AAB0", Offset = "0x30098B0", VA = "0x18300AAB0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x300AB20", Offset = "0x3009920", VA = "0x18300AB20", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x300ABE0", Offset = "0x30099E0", VA = "0x18300ABE0", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x300AB80", Offset = "0x3009980", VA = "0x18300AB80", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public ECPIHGEMDEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class IBOOMICEHOP<T> : MFAIHIGJEHN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x366DE30", Offset = "0x366CC30", VA = "0x18366DE30", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x366DEA0", Offset = "0x366CCA0", VA = "0x18366DEA0", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x366DF60", Offset = "0x366CD60", VA = "0x18366DF60", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x366DF00", Offset = "0x366CD00", VA = "0x18366DF00", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public IBOOMICEHOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class NKHPJPKLFIF<T> : MFAIHIGJEHN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2620", Offset = "0x3BF1420", VA = "0x183BF2620", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2690", Offset = "0x3BF1490", VA = "0x183BF2690", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF26F0", Offset = "0x3BF14F0", VA = "0x183BF26F0", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x35EC0A0", Offset = "0x35EAEA0", VA = "0x1835EC0A0", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x300AC50", Offset = "0x3009A50", VA = "0x18300AC50")]
		public NKHPJPKLFIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class GBCIACGHAON<T> : EGKKIJBNPNG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3479120", Offset = "0x3477F20", VA = "0x183479120", Slot = "12")]
		protected override void KHBAIBEEHBE(CCEHMELCJFE NHNDDOIAEPK, char CONHAFAMJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x34790F0", Offset = "0x3477EF0", VA = "0x1834790F0", Slot = "11")]
		protected override void BLFHPHPHMAN(PCHKKKEDCOJ CAAEKLGIBGJ, [Out] char CONHAFAMJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3479150", Offset = "0x3477F50", VA = "0x183479150")]
		public GBCIACGHAON()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class CJINMEBEPGB<T> : EGKKIJBNPNG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x49554C0", Offset = "0x49542C0", VA = "0x1849554C0", Slot = "12")]
		protected override void KHBAIBEEHBE(CCEHMELCJFE NHNDDOIAEPK, IPEndPoint CONHAFAMJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4955480", Offset = "0x4954280", VA = "0x184955480", Slot = "11")]
		protected override void BLFHPHPHMAN(PCHKKKEDCOJ CAAEKLGIBGJ, [Out] IPEndPoint CONHAFAMJMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3479150", Offset = "0x3477F50", VA = "0x183479150")]
		public CJINMEBEPGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class KJDICEGDPDC<T> : MFAIHIGJEHN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int KLJNHGENINB;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x38C2390", Offset = "0x38C1190", VA = "0x1838C2390")]
		public KJDICEGDPDC(int MMGMGPHHDNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x38C21D0", Offset = "0x38C0FD0", VA = "0x1838C21D0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x38C2240", Offset = "0x38C1040", VA = "0x1838C2240", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x38C2320", Offset = "0x38C1120", VA = "0x1838C2320", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x38C22B0", Offset = "0x38C10B0", VA = "0x1838C22B0", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class NGAHGDAFLKA<T> : HIDEGMDKKKH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo ENEPIPEMHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type AFKKOHIFLCB;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8000", Offset = "0x3BE6E00", VA = "0x183BE8000")]
		public NGAHGDAFLKA(PropertyInfo GHOAJKHDDHN, Type KNPIIGALLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7D10", Offset = "0x3BE6B10", VA = "0x183BE7D10", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7DD0", Offset = "0x3BE6BD0", VA = "0x183BE7DD0", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7FA0", Offset = "0x3BE6DA0", VA = "0x183BE7FA0", Slot = "7")]
		public override void OJFAKILKOME(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7F40", Offset = "0x3BE6D40", VA = "0x183BE7F40", Slot = "8")]
		public override void OIAMJNJFBPK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7EE0", Offset = "0x3BE6CE0", VA = "0x183BE7EE0", Slot = "9")]
		public override void NLJILGKJHEG(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3BE7E80", Offset = "0x3BE6C80", VA = "0x183BE7E80", Slot = "10")]
		public override void KOEJFKFDNKJ(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class LDLCPEKOOIO<T> : NGAHGDAFLKA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x304E4F0", Offset = "0x304D2F0", VA = "0x18304E4F0")]
		public LDLCPEKOOIO(PropertyInfo GHOAJKHDDHN, Type KNPIIGALLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x397A6A0", Offset = "0x39794A0", VA = "0x18397A6A0", Slot = "5")]
		public override void BAFAPCMDNFI(T PJKCCJGOFMO, PCHKKKEDCOJ CAAEKLGIBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x397A760", Offset = "0x3979560", VA = "0x18397A760", Slot = "6")]
		public override void FFKIDNKHFEK(T PJKCCJGOFMO, CCEHMELCJFE NHNDDOIAEPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class CINCOHOJJKL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static CINCOHOJJKL<T> IFFGEIGBEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly HIDEGMDKKKH<T>[] HGLHFOMIIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int CFIMKJCPMNI;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4952EE0", Offset = "0x4951CE0", VA = "0x184952EE0")]
		public CINCOHOJJKL(List<HIDEGMDKKKH<T>> GBGFPCMIGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4952E30", Offset = "0x4951C30", VA = "0x184952E30")]
		public void FFKIDNKHFEK(T DGPHOMINFCK, CCEHMELCJFE FNEJOGEIEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4952D80", Offset = "0x4951B80", VA = "0x184952D80")]
		public void BAFAPCMDNFI(T DGPHOMINFCK, PCHKKKEDCOJ GFNJLJABMCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class NHFNBNHPJLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HIDEGMDKKKH<T> HAMDPAFEPLN<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private CCEHMELCJFE AOPOHPDBGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int AEHKBEFPAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, NHFNBNHPJLB> DKNMJILLONJ;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x51C49C0", Offset = "0x51C37C0", VA = "0x1851C49C0")]
	public HBKLPBKENAM(int LJHDFPPAEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x23AD1A0", Offset = "0x23ABFA0", VA = "0x1823AD1A0")]
	private CINCOHOJJKL<T> INMODDEFCFA<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x21610D0", Offset = "0x215FED0", VA = "0x1821610D0")]
	public void LAPCBGMBHPD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x23AE0F0", Offset = "0x23ACEF0", VA = "0x1823AE0F0")]
	public bool NLOFGFEMKNI<T>(PCHKKKEDCOJ GFNJLJABMCF, T PABBJIBBIGE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x23AE090", Offset = "0x23ACE90", VA = "0x1823AE090")]
	public void LJOKGFFEJKK<T>(CCEHMELCJFE FNEJOGEIEJN, T DGPHOMINFCK) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DPHMHLKMAGO
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime MOPLJLNCIDJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] DAFMAJFNNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LBPJHKNGIAF PJGNPGDNIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x51BB740", Offset = "0x51BA540", VA = "0x1851BB740")]
		get
		{
			return default(LBPJHKNGIAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int LJPMFIICFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x51BABC0", Offset = "0x51B99C0", VA = "0x1851BABC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x51BAF10", Offset = "0x51B9D10", VA = "0x1851BAF10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JPIGHCEFKLL NBPHMHIHAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x51BB770", Offset = "0x51BA570", VA = "0x1851BB770")]
		get
		{
			return default(JPIGHCEFKLL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x51BAF80", Offset = "0x51B9D80", VA = "0x1851BAF80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int DLOLCJGCGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x51BBAF0", Offset = "0x51BA8F0", VA = "0x1851BBAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint LHOPMBHMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x51BBA40", Offset = "0x51BA840", VA = "0x1851BBA40")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? LGFEAIBLGJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x51BAF50", Offset = "0x51B9D50", VA = "0x1851BAF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? IKHJDOCKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x51BB4E0", Offset = "0x51BA2E0", VA = "0x1851BB4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? JMPDJCOMLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x51BBAC0", Offset = "0x51BA8C0", VA = "0x1851BBAC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x51BAFC0", Offset = "0x51B9DC0", VA = "0x1851BAFC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? FKKANCFOFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4D0", Offset = "0x7CD2D0", VA = "0x1807CE4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x51BBB80", Offset = "0x51BA980", VA = "0x1851BBB80")]
	public DPHMHLKMAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x51BBEA0", Offset = "0x51BACA0", VA = "0x1851BBEA0")]
	internal DPHMHLKMAGO(byte[] LKHDKNBOMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x51BADF0", Offset = "0x51B9BF0", VA = "0x1851BADF0")]
	public static DPHMHLKMAGO DMCFJHMBDGI(byte[] LKHDKNBOMJD, DateTime EPKHHFKCEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x51BB190", Offset = "0x51B9F90", VA = "0x1851BB190")]
	internal void FJOLGFPKAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x51BB870", Offset = "0x51BA670", VA = "0x1851BB870")]
	private void NKIAKNLDHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x51BABF0", Offset = "0x51B99F0", VA = "0x1851BABF0")]
	private DateTime? AJLBMFIFLKJ(int NNACFOFLCKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x51BB570", Offset = "0x51BA370", VA = "0x1851BB570")]
	private void LGINJADIABN(int NNACFOFLCKF, DateTime? POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x51BB7A0", Offset = "0x51BA5A0", VA = "0x1851BB7A0")]
	private ulong MMLPNKNLOGP(int NNACFOFLCKF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x51BB390", Offset = "0x51BA190", VA = "0x1851BB390")]
	private void ILEIADCACOE(int NNACFOFLCKF, ulong POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x51BB450", Offset = "0x51BA250", VA = "0x1851BB450")]
	private uint JBAPOIGIPFL(int NNACFOFLCKF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x50A3AE0", Offset = "0x50A28E0", VA = "0x1850A3AE0")]
	private static uint LAINBAFGCEK(uint NPDPLEIHBMM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x51BB510", Offset = "0x51BA310", VA = "0x1851BB510")]
	private static ulong LAINBAFGCEK(ulong NPDPLEIHBMM)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum LBPJHKNGIAF
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public enum JPIGHCEFKLL
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class AIDGFNFNCFH
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int IFKONGMLGKB = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int BHIJMCBJFDK = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int CDDJADJNOHE = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint EFPKJBBFBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int LICDIFMIHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int MBNEHFLEAGK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool CFNIOMKPLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x51B3BF0", Offset = "0x51B29F0", VA = "0x1851B3BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x51B3C00", Offset = "0x51B2A00", VA = "0x1851B3C00")]
	public bool GGFCBONHGMC(Socket EIEBKALMGHH, int BGDOPOOMALL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class GKJDIBKICBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int EIAIDBKLOML;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
	protected GKJDIBKICBJ(int EHCCPNCCGMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FDJPBBMNMGJ(IPEndPoint ABPMHGJKKEP, byte[] LMCJHCIOIIP, int NNACFOFLCKF, int JGMNJBPPKGP);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void EIBADEDDDBK(IPEndPoint ABPMHGJKKEP, byte[] LMCJHCIOIIP, int NNACFOFLCKF, int JGMNJBPPKGP);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NGHBOKFLDAL : GKJDIBKICBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider KPEGOJNIKOM;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator EFADLGHMAFN;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x51C8E70", Offset = "0x51C7C70", VA = "0x1851C8E70")]
	public NGHBOKFLDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x51C8730", Offset = "0x51C7530", VA = "0x1851C8730")]
	public void EPKEJMOCLPI(IPEndPoint ABPMHGJKKEP, byte[] GMOPMNAPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x51C8D30", Offset = "0x51C7B30", VA = "0x1851C8D30")]
	public void FJKIOCIANAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x51C86A0", Offset = "0x51C74A0", VA = "0x1851C86A0")]
	private byte[] EJGDLNKBCMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x51C8970", Offset = "0x51C7770", VA = "0x1851C8970", Slot = "4")]
	public override void FDJPBBMNMGJ(IPEndPoint ABPMHGJKKEP, byte[] LMCJHCIOIIP, int NNACFOFLCKF, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x51C8300", Offset = "0x51C7100", VA = "0x1851C8300", Slot = "5")]
	public override void EIBADEDDDBK(IPEndPoint ABPMHGJKKEP, byte[] LMCJHCIOIIP, int NNACFOFLCKF, int JGMNJBPPKGP)
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
