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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BPLEJAPAOOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum DFKGHEFBGBO
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
		private NetworkManager NKDODNJDELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, BJDNGBELDLA> EMFLHPDMOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GDGMJBJODBA DPMNGNCLHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] GMBONJJDEGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private DFKGHEFBGBO NALAABDDNLJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong AAJDPANOCDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MDFLCFDOBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x600E100", Offset = "0x600CD00", VA = "0x18600E100", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x600D690", Offset = "0x600C290", VA = "0x18600D690")]
		public void RecRoom_SetEncryptionInfo(ulong DFKLMKNBHMB, byte[] NONKDEOLPHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x600D670", Offset = "0x600C270", VA = "0x18600D670")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x600D520", Offset = "0x600C120", VA = "0x18600D520")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x600E000", Offset = "0x600CC00", VA = "0x18600E000")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x600D7B0", Offset = "0x600C3B0", VA = "0x18600D7B0", Slot = "6")]
		public override void Send(ulong DFHDOPNDLHG, ArraySegment<byte> BFLLAIFBMAJ, NetworkDelivery EDOHFCFDPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x600D630", Offset = "0x600C230", VA = "0x18600D630", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DFHDOPNDLHG, [Out] ArraySegment<byte> NCPEFDMEFEF, [Out] float AFGNIIOIFJA)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x600DAA0", Offset = "0x600C6A0", VA = "0x18600DAA0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x600DF20", Offset = "0x600CB20", VA = "0x18600DF20", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x600CE50", Offset = "0x600BA50", VA = "0x18600CE50", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DFHDOPNDLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x600CD00", Offset = "0x600B900", VA = "0x18600CD00", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x600D1D0", Offset = "0x600BDD0", VA = "0x18600D1D0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DFHDOPNDLHG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x600DA30", Offset = "0x600C630", VA = "0x18600DA30", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x600D270", Offset = "0x600BE70", VA = "0x18600D270", Slot = "14")]
		public override void Initialize([Optional] NetworkManager NKDODNJDELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x600CC30", Offset = "0x600B830", VA = "0x18600CC30")]
		private COGHNIEIKKF CMNIDNFKPBD(NetworkDelivery FIFJJNIIAPF)
		{
			return default(COGHNIEIKKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x600D430", Offset = "0x600C030", VA = "0x18600D430", Slot = "15")]
		private void MBGBLCNINMJ(BJDNGBELDLA MPDBPEAFFBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x600CB70", Offset = "0x600B770", VA = "0x18600CB70", Slot = "16")]
		private void BPBMBDKEJGN(BJDNGBELDLA MPDBPEAFFBI, OGLHKGJOLJE KMDPIIHNHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "17")]
		private void KIJLEHDKIHH(IPEndPoint MCDJJKAEJFH, SocketError ANJIPKDCJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x600CFC0", Offset = "0x600BBC0", VA = "0x18600CFC0", Slot = "18")]
		private void EJFJMLNIFEI(BJDNGBELDLA MPDBPEAFFBI, DFACMOCGKAO DMECMNHFOBP, byte IALJDPOOCHL, COGHNIEIKKF PGDMOBMOMNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x600CA90", Offset = "0x600B690", VA = "0x18600CA90")]
		private void BKIAPNCPOAG(int OLKJNOHMJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "19")]
		private void GBPIHHPHAKP(IPEndPoint DKKODPEOAIL, DFACMOCGKAO DMECMNHFOBP, OCMAMJNEAMF DKMDFAFCDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "20")]
		private void JBEJMAOIEOK(BJDNGBELDLA MPDBPEAFFBI, int KJLBLPABLKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x600CA30", Offset = "0x600B630", VA = "0x18600CA30", Slot = "21")]
		private void BBCIAEHBJPD(DKOKIBKOKLA IBNNNHFPFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x600D4F0", Offset = "0x600C0F0", VA = "0x18600D4F0")]
		private ulong OPACGEAKCJG(BJDNGBELDLA MPDBPEAFFBI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x600D610", Offset = "0x600C210", VA = "0x18600D610")]
		private static int PFFBIBNFMGJ(float KEFCDGNOKGL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x600E020", Offset = "0x600CC20", VA = "0x18600E020")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class ABPDCACPDJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly BJDNGBELDLA CIBFEJPBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<NMBFLKAIPPB> FLCKMCKJDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JKFHBDAGEOF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8400", Offset = "0x5FF7000", VA = "0x185FF8400")]
	protected ABPDCACPDJN(BJDNGBELDLA MPDBPEAFFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8360", Offset = "0x5FF6F60", VA = "0x185FF8360")]
	public void FOIIAINMNLP(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FF82E0", Offset = "0x5FF6EE0", VA = "0x185FF82E0")]
	protected void AFGEMOLGNEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FF83C0", Offset = "0x5FF6FC0", VA = "0x185FF83C0")]
	public bool GBKPCJODDDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool IGLAGBFEMBG();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JMELOOMMDCA(NMBFLKAIPPB LOBAIGHBGLP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum EHADDJFCNDA
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
public class DKOKIBKOKLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GDGMJBJODBA GPHFHAPKDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int AMALEIHGBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal LGPHHCAPPCA MFGBPHHKPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint CNPNMPEFEKO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal EHADDJFCNDA CHEHOFMMBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B07C0", Offset = "0x8AF3C0", VA = "0x1808B07C0")]
		[CompilerGenerated]
		get
		{
			return default(EHADDJFCNDA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC804F0", Offset = "0xC7F0F0", VA = "0x180C804F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF490", Offset = "0x5FFE090", VA = "0x185FFF490")]
	internal void EGPJGKOIBAC(LGPHHCAPPCA JDEIEAGPLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF4F0", Offset = "0x5FFE0F0", VA = "0x185FFF4F0")]
	private bool HCLFEHAPHPC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF520", Offset = "0x5FFE120", VA = "0x185FFF520")]
	internal DKOKIBKOKLA(IPEndPoint DKKODPEOAIL, LGPHHCAPPCA JCINGKDAFOG, GDGMJBJODBA GBKJOHPDEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF430", Offset = "0x5FFE030", VA = "0x185FFF430")]
	public BJDNGBELDLA AAPEKAKFDBG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OCMAMJNEAMF
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LAECEBLPHDA
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
public struct OGLHKGJOLJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public LAECEBLPHDA AKPFAPPBPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BIDJJKKJNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DFACMOCGKAO IDKPDJOOMDJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BPLEJAPAOOI
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBFECOCKDOA(BJDNGBELDLA MPDBPEAFFBI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNEJCLLNKLG(BJDNGBELDLA MPDBPEAFFBI, OGLHKGJOLJE KMDPIIHNHCI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GPIOPIAIHFA(IPEndPoint MCDJJKAEJFH, SocketError ANJIPKDCJOL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPBIFEDMENJ(BJDNGBELDLA MPDBPEAFFBI, DFACMOCGKAO DMECMNHFOBP, byte IALJDPOOCHL, COGHNIEIKKF PGDMOBMOMNI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ACCNPHAMLDE(IPEndPoint DKKODPEOAIL, DFACMOCGKAO DMECMNHFOBP, OCMAMJNEAMF DKMDFAFCDMC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PAPKNKAIILP(BJDNGBELDLA MPDBPEAFFBI, int KJLBLPABLKJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HPCAJKMBBAI(DKOKIBKOKLA IBNNNHFPFBF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHAJFOKAMHP
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPGINGDDHAP(BJDNGBELDLA MPDBPEAFFBI, object KCEHGHMENBC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KONHLDIINPA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CPGLANNOCPP(LDKOFHABFJH LOBAIGHBGLP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KFKBHAPKHOK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKKDPNGMINI(BJDNGBELDLA MPDBPEAFFBI, IPEndPoint CCGFGAINHAO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class LGPHHCAPPCA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int FHAHCEENKDG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long KEKHAPMCNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte HLECEKBGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] KEHMGBGBKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HAEGDPOPBEO HCNDAPMGMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int PPJLGHEOGCH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x600C920", Offset = "0x600B520", VA = "0x18600C920")]
	private LGPHHCAPPCA(long KJKGAEEHPBO, byte LJOGKLBNHFO, int DKAIINNEBFL, byte[] IBLOJPJDFJC, HAEGDPOPBEO BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x600C6A0", Offset = "0x600B2A0", VA = "0x18600C6A0")]
	public static int IDPAGPIJKHP(NMBFLKAIPPB LOBAIGHBGLP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x600C700", Offset = "0x600B300", VA = "0x18600C700")]
	public static LGPHHCAPPCA KGBFBMEJNEN(NMBFLKAIPPB LOBAIGHBGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x600C4C0", Offset = "0x600B0C0", VA = "0x18600C4C0")]
	public static NMBFLKAIPPB EODKINNHMIJ(DIBGMDCNCIF PDKLIPJGHKG, SocketAddress LOALNMKGIJK, long PIBAEACBHGE, int DKAIINNEBFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BBMDDCLDIJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long KEKHAPMCNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte HLECEKBGEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int PPJLGHEOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool AOECLFADALJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FF87E0", Offset = "0x5FF73E0", VA = "0x185FF87E0")]
	private BBMDDCLDIJE(long KJKGAEEHPBO, byte LJOGKLBNHFO, int JFMPFIFNDKK, bool LLJNOLMKDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8590", Offset = "0x5FF7190", VA = "0x185FF8590")]
	public static BBMDDCLDIJE KGBFBMEJNEN(NMBFLKAIPPB LOBAIGHBGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF84A0", Offset = "0x5FF70A0", VA = "0x185FF84A0")]
	public static NMBFLKAIPPB EODKINNHMIJ(long PIBAEACBHGE, byte JDFGIFODPON, int HDDACMEPMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF86E0", Offset = "0x5FF72E0", VA = "0x185FF86E0")]
	public static NMBFLKAIPPB PDIGAFDGGLF(BJDNGBELDLA MPDBPEAFFBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum MACICFGHJBO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DLFKLOIHIMG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAHFLHLPLPD(IPEndPoint AKAMIOHJHED, IPEndPoint DKKODPEOAIL, string DGGGDIFONNG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCNFFHJGKEP(IPEndPoint HFJKFANOEAP, MACICFGHJBO FIFJJNIIAPF, string DGGGDIFONNG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JFFNDPNCFCK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct IHBELPCLICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint EAAEFLFJHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint CNPNMPEFEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string POBGIDMLOMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MFJJIFLLJLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint DFBPBEMDLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MACICFGHJBO LBAEOCJIFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string POBGIDMLOMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class BGCPPFCEOHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint ILCPOEHCCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string POBGIDMLOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public BGCPPFCEOHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class AENNHBGJFPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint ILCPOEHCCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint DFCOLCLNBCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string POBGIDMLOMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AENNHBGJFPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class CEKAKGLLKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string POBGIDMLOMF
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DDKBCOBAFNG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA22440", Offset = "0xA21040", VA = "0x180A22440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x892E30", Offset = "0x891A30", VA = "0x180892E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CEKAKGLLKKJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GDGMJBJODBA MGABIAKGFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<IHBELPCLICO> EMCOEJCJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<MFJJIFLLJLN> FNMBLCEHEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HAEGDPOPBEO BBDFFLFCFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DIBGMDCNCIF GCMNIBHGPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NMAJGLPFPPE DNLBADAOPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DLFKLOIHIMG ENJMLIPNJFB;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int HLIGMIBJKDD = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool LIDIOOAAAKP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6009180", Offset = "0x6007D80", VA = "0x186009180")]
	internal JFFNDPNCFCK(GDGMJBJODBA FAKFMJJAOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6008E70", Offset = "0x6007A70", VA = "0x186008E70")]
	internal void NBHHNFCIADO(IPEndPoint GFJHNJBNIGK, NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2E7DA50", Offset = "0x2E7C650", VA = "0x182E7DA50")]
	private void PLKIBGGDJPP<T>(T LOBAIGHBGLP, IPEndPoint CGJNNJHBPPG) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6008FF0", Offset = "0x6007BF0", VA = "0x186008FF0")]
	private void OAHFLHLPLPD(BGCPPFCEOHM EHODIBOCEPE, IPEndPoint GFJHNJBNIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6008B70", Offset = "0x6007770", VA = "0x186008B70")]
	private void CGPOJBLOLCE(AENNHBGJFPM EHODIBOCEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6008CD0", Offset = "0x60078D0", VA = "0x186008CD0")]
	private void IKGLDDHCANJ(CEKAKGLLKKJ EHODIBOCEPE, IPEndPoint GFJHNJBNIGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum COGHNIEIKKF : byte
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
public enum APBJAPDDJBM : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DIJKHCLOBBB
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] CMDILOLEJEB;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int NAAKOPCMJKA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int KOAAACOFNJJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IMFPLIIOJNE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD110", Offset = "0x5FFBD10", VA = "0x185FFD110")]
	public IMFPLIIOJNE(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KKDJKGPHLGB : IMFPLIIOJNE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD110", Offset = "0x5FFBD10", VA = "0x185FFD110")]
	public KKDJKGPHLGB(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DJMLOHKOGBJ
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
public interface JOJNFJJEFCE
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBEBCANNOMF(DJMLOHKOGBJ POFGODPFIFA, string BPDMBIHGLAC, params object[] JIAHCJFCHOA);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EHOGENJCNAO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static JOJNFJJEFCE IMGIEBFKKBO;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object DHENDANFBEO;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF690", Offset = "0x5FFE290", VA = "0x185FFF690")]
	private static void HNJJLIKPFBI(DJMLOHKOGBJ BONDFAEIBHL, string BPDMBIHGLAC, params object[] JIAHCJFCHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF920", Offset = "0x5FFE520", VA = "0x185FFF920")]
	internal static void ODADGCIIJED(string BPDMBIHGLAC, params object[] JIAHCJFCHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF8C0", Offset = "0x5FFE4C0", VA = "0x185FFF8C0")]
	internal static void JAKJOBOMGLG(string BPDMBIHGLAC, params object[] JIAHCJFCHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF630", Offset = "0x5FFE230", VA = "0x185FFF630")]
	internal static void DMAJPJHFPNC(string BPDMBIHGLAC, params object[] JIAHCJFCHOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum LCODKONBGGC
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DFACMOCGKAO : HAEGDPOPBEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NMBFLKAIPPB AAKOGPFEIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly GDGMJBJODBA DLOBAIOGGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly DMNMLIGFBDF BJBCIAHGBNA;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE4D0", Offset = "0x5FFD0D0", VA = "0x185FFE4D0")]
	internal DFACMOCGKAO(GDGMJBJODBA IGEADGIGICG, DMNMLIGFBDF LGPIICDBGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE430", Offset = "0x5FFD030", VA = "0x185FFE430")]
	internal void GPFLOEEDCPA(NMBFLKAIPPB LOBAIGHBGLP, int ODPCDJLNAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE3B0", Offset = "0x5FFCFB0", VA = "0x185FFE3B0")]
	internal void FBOEEEMCPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE4A0", Offset = "0x5FFD0A0", VA = "0x185FFE4A0")]
	public void IJAJGEILHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class DMNMLIGFBDF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum HBDOEBIDOHM
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
	public DMNMLIGFBDF JIBIMLHAGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public HBDOEBIDOHM LBAEOCJIFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public BJDNGBELDLA CIBFEJPBNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint CNPNMPEFEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object BJFJIJJCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int GLMOBKFDFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError LHPAMCCKLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public LAECEBLPHDA JNAKOEKFFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public DKOKIBKOKLA CILJEKBOGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public COGHNIEIKKF GNBDHGKLKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte IPFMJNNOGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly DFACMOCGKAO IEAGGHGNHLO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF590", Offset = "0x5FFE190", VA = "0x185FFF590")]
	public DMNMLIGFBDF(GDGMJBJODBA IGEADGIGICG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class GDGMJBJODBA : IEnumerable<BJDNGBELDLA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class DCCINCOJCGP : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5FFD280", Offset = "0x5FFBE80", VA = "0x185FFD280", Slot = "4")]
		public bool Equals(IPEndPoint MBJABMPNEHF, IPEndPoint MNMGCDILGBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5B28550", Offset = "0x5B27150", VA = "0x185B28550", Slot = "5")]
		public int GetHashCode(IPEndPoint PLAMADMDGIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public DCCINCOJCGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LNJODPHOAIB : IEnumerator<BJDNGBELDLA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly BJDNGBELDLA EJGMKOIEKGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private BJDNGBELDLA AAEBNFCEMEI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BJDNGBELDLA FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA644E0", Offset = "0xA630E0", VA = "0x180A644E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x12C21F0", Offset = "0x12C0DF0", VA = "0x1812C21F0")]
		public LNJODPHOAIB(BJDNGBELDLA GAECIBGPFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x600C990", Offset = "0x600B590", VA = "0x18600C990", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x600C9E0", Offset = "0x600B5E0", VA = "0x18600C9E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread MCFEMFHBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool NBNBJBOPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent DFFDHBPOHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<DMNMLIGFBDF> PCGOGKNDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<DMNMLIGFBDF> EDMOJPMAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private DMNMLIGFBDF APBGJCMGMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly BPLEJAPAOOI JDIMOIFLCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NHAJFOKAMHP GBBKPMPBKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly KONHLDIINPA OFGJHCLPAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly KFKBHAPKHOK EMAMFAPIHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, BJDNGBELDLA> LFIBPJKKDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, DKOKIBKOKLA> LGCDPHMAOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, GLGIIMIODAE> GGLIKBDMGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim HMLKBDHGHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private BJDNGBELDLA JEODAEJPJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int IJIJBGCPJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<BJDNGBELDLA> DPEHKLIGLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private BJDNGBELDLA[] OEDPNPDNMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PBDHNLOMFEC INABPIJALHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int BBOKPKMEGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> AGOMJGPMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte NHBHEHEJBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LGNJEFPDAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool MDOFJFMLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool KHLIFEDEICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int KIHKDBDFDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int ENPKINCDDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MIBDGKGLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int ABABDDIKBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool CFJBFLKBGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BPMNFDPOANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int HJHOJNFNGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int IOANGLNBFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int OFIJOCIMHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool LIDIOOAAAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool HHBBGBBHBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool LBOLELEGMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool PPDKGBFMLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int OCNGPKJMHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int HCHBIBHJABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool FFODHBOIIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly HIMNKNKLLGD HMGGCPMBGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool LAKPMFOMEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly JFFNDPNCFCK DMOIEGMHOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LAKCNOGHFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public LCODKONBGGC CFKNCMKMDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int GCMMGDOONPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MIPMMPAMALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GHHJKLKOMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool NAMKNFHHAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool JGDIDFNOCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NMBFLKAIPPB NBHKOIAEILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int JAHEGPLNCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object FBOGBLCNDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NMBFLKAIPPB ICEBGBILBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int LNAJENOIINN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int JBHNOCDILCL = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int ANJMCHGNOFK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private LDAPCJPICHP LFHPOCGOHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private LDAPCJPICHP GLBOLPJANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread OIEBOGDDNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread CBEOFFLNPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint AMIOKPPKMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint ELLMOOJCAHC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] MFBHDCDONFN;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] KGNDNLDPCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<OOLPDAPCJEC, IPEndPoint> LEDKLDOIIGO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress AFNGBLELDCO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool FPJEGGHOAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int KIEAEECDLGN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HHHDGPNEDHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE41220", Offset = "0xE3FE20", VA = "0x180E41220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE40CF0", Offset = "0xE3F8F0", VA = "0x180E40CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ACKCNACCMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1736FA0", Offset = "0x1735BA0", VA = "0x181736FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x19B2270", Offset = "0x19B0E70", VA = "0x1819B2270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte JEPKPOFFADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xC4AC20", Offset = "0xC49820", VA = "0x180C4AC20")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PJHDEJCPNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FFFB80", Offset = "0x5FFE780", VA = "0x185FFFB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short LOEJGKEHAIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60060D0", Offset = "0x6004CD0", VA = "0x1860060D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6000C90", Offset = "0x5FFF890", VA = "0x186000C90")]
	public void ECIDMEJCOHA(IPEndPoint MCDJJKAEJFH, byte[] NONKDEOLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFA30", Offset = "0x5FFE630", VA = "0x185FFFA30")]
	public void ACCPDNCGEDJ(IPEndPoint MCDJJKAEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60031A0", Offset = "0x6001DA0", VA = "0x1860031A0")]
	private bool IFJPAPANDEL(IPEndPoint MCDJJKAEJFH, [Out] BJDNGBELDLA MPDBPEAFFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60018F0", Offset = "0x60004F0", VA = "0x1860018F0")]
	private void HBKHHFNOMBL(BJDNGBELDLA MPDBPEAFFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6003150", Offset = "0x6001D50", VA = "0x186003150")]
	private void IFBEHDCGNPE(BJDNGBELDLA MPDBPEAFFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6004350", Offset = "0x6002F50", VA = "0x186004350")]
	private void LJJIDOEPCON(BJDNGBELDLA MPDBPEAFFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6006750", Offset = "0x6005350", VA = "0x186006750")]
	public GDGMJBJODBA(BPLEJAPAOOI GBKJOHPDEID, [Optional] PBDHNLOMFEC OHLDBIDIAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6003B00", Offset = "0x6002700", VA = "0x186003B00")]
	internal void JMCGJBCFHLB(BJDNGBELDLA JEBAGADBPEH, int KJLBLPABLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFBA0", Offset = "0x5FFE7A0", VA = "0x185FFFBA0")]
	internal void CBBNFCOPAHO(BJDNGBELDLA JEBAGADBPEH, object KCEHGHMENBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60056F0", Offset = "0x60042F0", VA = "0x1860056F0")]
	internal void NAAJEFFOBNN(BJDNGBELDLA MPDBPEAFFBI, LAECEBLPHDA CKHPKJLILHH, SocketError OJILIOIBNHL, NMBFLKAIPPB KLBPGDIPDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6003950", Offset = "0x6002550", VA = "0x186003950")]
	private void JJDGPHAOILH(BJDNGBELDLA MPDBPEAFFBI, LAECEBLPHDA CKHPKJLILHH, SocketError OJILIOIBNHL, bool KHODILEOPHB, byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int KNHHBEFLJAF, NMBFLKAIPPB KLBPGDIPDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6006190", Offset = "0x6004D90", VA = "0x186006190")]
	private void PNLNOINNKPK(DMNMLIGFBDF.HBDOEBIDOHM FIFJJNIIAPF, [Optional] BJDNGBELDLA MPDBPEAFFBI, [Optional] IPEndPoint DKKODPEOAIL, SocketError AGEJKJPNEJB = SocketError.Success, int KJLBLPABLKJ = 0, LAECEBLPHDA IFEJJFFKFKC = LAECEBLPHDA.ConnectionFailed, [Optional] DKOKIBKOKLA LLEAJKEJMOL, COGHNIEIKKF PGDMOBMOMNI = COGHNIEIKKF.Unreliable, byte IALJDPOOCHL = 0, [Optional] NMBFLKAIPPB IFIDMDFNLMF, [Optional] object KCEHGHMENBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6002990", Offset = "0x6001590", VA = "0x186002990")]
	private void IENHOAKPPLE(DMNMLIGFBDF LGPIICDBGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6001490", Offset = "0x6000090", VA = "0x186001490")]
	internal void FEHCHJDIFMI(DMNMLIGFBDF LGPIICDBGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6005AE0", Offset = "0x60046E0", VA = "0x186005AE0")]
	private void NOBDCIHLMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60057C0", Offset = "0x60043C0", VA = "0x1860057C0")]
	private void NBHOENIMPDP(int OKDKAJFGHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6000670", Offset = "0x5FFF270", VA = "0x186000670")]
	internal BJDNGBELDLA EBIPKAEJFPP(DKOKIBKOKLA IBNNNHFPFBF, byte[] JHJNIAEBADN, int GMEOEMGBEED, int OLBMNABBGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6003820", Offset = "0x6002420", VA = "0x186003820")]
	private int JHGILPLFHMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6003D10", Offset = "0x6002910", VA = "0x186003D10")]
	private void KLDDFOKIPFF(IPEndPoint DKKODPEOAIL, BJDNGBELDLA KLCHOPHCFFM, LGPHHCAPPCA BLGDBMAMFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6001BD0", Offset = "0x60007D0", VA = "0x186001BD0")]
	private void HNLKHBBNDHJ(NMBFLKAIPPB LOBAIGHBGLP, IPEndPoint DKKODPEOAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFBF0", Offset = "0x5FFE7F0", VA = "0x185FFFBF0")]
	internal void CGMACODCEJG(NMBFLKAIPPB LOBAIGHBGLP, COGHNIEIKKF GHPOFPMJIIK, byte IALJDPOOCHL, int ODPCDJLNAKB, BJDNGBELDLA JEBAGADBPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6004E10", Offset = "0x6003A10", VA = "0x186004E10")]
	public bool LMFNDHIOLEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6004DF0", Offset = "0x60039F0", VA = "0x186004DF0")]
	public bool LMFNDHIOLEF(IPAddress FBOINBOBNGP, IPAddress BDFHFLAOGDA, int APMPPPPEKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60045C0", Offset = "0x60031C0", VA = "0x1860045C0")]
	public bool LMFNDHIOLEF(int APMPPPPEKJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6005F20", Offset = "0x6004B20", VA = "0x186005F20")]
	public void PDMCALIPOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6003740", Offset = "0x6002340", VA = "0x186003740")]
	public BJDNGBELDLA JFPCDMCJMLO(string CNNFBDLEEOC, int APMPPPPEKJK, string NONKDEOLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6003290", Offset = "0x6001E90", VA = "0x186003290")]
	public BJDNGBELDLA JFPCDMCJMLO(string CNNFBDLEEOC, int APMPPPPEKJK, DIBGMDCNCIF FGLIPAGHHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6003370", Offset = "0x6001F70", VA = "0x186003370")]
	public BJDNGBELDLA JFPCDMCJMLO(IPEndPoint CGJNNJHBPPG, DIBGMDCNCIF FGLIPAGHHHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6000310", Offset = "0x5FFEF10", VA = "0x186000310")]
	public void DLKAMPAODFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6000320", Offset = "0x5FFEF20", VA = "0x186000320")]
	public void DLKAMPAODFP(bool EFEBOKLBLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6004E80", Offset = "0x6003A80", VA = "0x186004E80")]
	public void MCDIEKBJJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6004F80", Offset = "0x6003B80", VA = "0x186004F80")]
	public void MCDIEKBJJOO(byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60038A0", Offset = "0x60024A0", VA = "0x1860038A0")]
	public void JJDGPHAOILH(BJDNGBELDLA MPDBPEAFFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6003A40", Offset = "0x6002640", VA = "0x186003A40")]
	public void JJDGPHAOILH(BJDNGBELDLA MPDBPEAFFBI, byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6006570", Offset = "0x6005170", VA = "0x186006570", Slot = "4")]
	private IEnumerator<BJDNGBELDLA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6006600", Offset = "0x6005200", VA = "0x186006600", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6003C30", Offset = "0x6002830", VA = "0x186003C30")]
	private NMBFLKAIPPB JNLECJFFNFD(LMINCFJLPKE OPOMMFAAAOF, int OLKJNOHMJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6003B50", Offset = "0x6002750", VA = "0x186003B50")]
	private NMBFLKAIPPB JNLECJFFNFD(LMINCFJLPKE OPOMMFAAAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60015A0", Offset = "0x60001A0", VA = "0x1860015A0")]
	internal NMBFLKAIPPB GCIJGHGHIDL(int OLKJNOHMJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6000EB0", Offset = "0x5FFFAB0", VA = "0x186000EB0")]
	internal void EHHMGAHMIKH(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6006690", Offset = "0x6005290", VA = "0x186006690")]
	static GDGMJBJODBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE41220", Offset = "0xE3FE20", VA = "0x180E41220")]
	private bool BNAOOFMMBLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60017E0", Offset = "0x60003E0", VA = "0x1860017E0")]
	private void GKIOHDHEOAA(IPEndPoint LKKIHAOOLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6005E20", Offset = "0x6004A20", VA = "0x186005E20")]
	private void NOMJBGJKMJG(IPEndPoint LKKIHAOOLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x60041A0", Offset = "0x6002DA0", VA = "0x1860041A0")]
	private bool LHPPEFPINAD(SocketException JFFKMOFPCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FFFED0", Offset = "0x5FFEAD0", VA = "0x185FFFED0")]
	private void DEAFPDEMJBO(LDAPCJPICHP FAKFMJJAOKC, EndPoint MMOCLLOJHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6001110", Offset = "0x5FFFD10", VA = "0x186001110")]
	private void EMLJCFJJCKA(object GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6004640", Offset = "0x6003240", VA = "0x186004640")]
	public bool LMFNDHIOLEF(IPAddress FBOINBOBNGP, IPAddress BDFHFLAOGDA, int APMPPPPEKJK, bool GOEHLMMPEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6003230", Offset = "0x6001E30", VA = "0x186003230")]
	internal int INFAMMLCADG(NMBFLKAIPPB LOBAIGHBGLP, IPEndPoint DKKODPEOAIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x60056B0", Offset = "0x60042B0", VA = "0x1860056B0")]
	internal int MGNKKFPNCMC(NMBFLKAIPPB LOBAIGHBGLP, IPEndPoint DKKODPEOAIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x60050A0", Offset = "0x6003CA0", VA = "0x1860050A0")]
	internal int MGNKKFPNCMC(byte[] LFKIGNHCOID, int GMEOEMGBEED, int OLBMNABBGHI, IPEndPoint DKKODPEOAIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x60001A0", Offset = "0x5FFEDA0", VA = "0x1860001A0")]
	internal void DGJHIAHOIFL(bool PPOHMIOPOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LMINCFJLPKE : byte
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
internal sealed class NMBFLKAIPPB
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int COCGOBCHEAM;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] IIIBDPDPBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IJAONBGKGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int DMCOCMMDKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object BJFJIJJCHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public NMBFLKAIPPB JIBIMLHAGAB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LMINCFJLPKE NPLNAEOCEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x600E4A0", Offset = "0x600D0A0", VA = "0x18600E4A0")]
		get
		{
			return default(LMINCFJLPKE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x600E9A0", Offset = "0x600D5A0", VA = "0x18600E9A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte HLECEKBGEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x600E930", Offset = "0x600D530", VA = "0x18600E930")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x600E5D0", Offset = "0x600D1D0", VA = "0x18600E5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort CFHLENOEACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x600E610", Offset = "0x600D210", VA = "0x18600E610")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x600E960", Offset = "0x600D560", VA = "0x18600E960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BIMKHLMJLEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x600EA10", Offset = "0x600D610", VA = "0x18600EA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PIGCPDKCOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x600E8A0", Offset = "0x600D4A0", VA = "0x18600E8A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x600E870", Offset = "0x600D470", VA = "0x18600E870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JLONEMLEKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x600E8D0", Offset = "0x600D4D0", VA = "0x18600E8D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x600EA40", Offset = "0x600D640", VA = "0x18600EA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort LOAEGMFJLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x600E7B0", Offset = "0x600D3B0", VA = "0x18600E7B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x600E670", Offset = "0x600D270", VA = "0x18600E670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort MOFBELHHLBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x600E810", Offset = "0x600D410", VA = "0x18600E810")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x600EA80", Offset = "0x600D680", VA = "0x18600EA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x600EAC0", Offset = "0x600D6C0", VA = "0x18600EAC0")]
	static NMBFLKAIPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x600E9E0", Offset = "0x600D5E0", VA = "0x18600E9E0")]
	public void NMMOBMCHNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x600ED80", Offset = "0x600D980", VA = "0x18600ED80")]
	public NMBFLKAIPPB(int OLKJNOHMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x600EDF0", Offset = "0x600D9F0", VA = "0x18600EDF0")]
	public NMBFLKAIPPB(LMINCFJLPKE OPOMMFAAAOF, int OLKJNOHMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x600E4D0", Offset = "0x600D0D0", VA = "0x18600E4D0")]
	public static int AIJAJNOHCBM(LMINCFJLPKE OPOMMFAAAOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x600E540", Offset = "0x600D140", VA = "0x18600E540")]
	public int AIJAJNOHCBM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x600E6B0", Offset = "0x600D2B0", VA = "0x18600E6B0")]
	public bool DLMKNFFJFFB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum KHKAGBCHMND : byte
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
internal enum MLACLIPHBLN
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
internal enum PLFFFOMKEOI
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum KPBEMBAFPJL
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BJDNGBELDLA
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class JOJELHPAPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public NMBFLKAIPPB[] JDNJIMJGPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int OCLMNHOJGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int ANHDFLGLKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte PIGCPDKCOKJ;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public JOJELHPAPNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void EONFEIEDALD(ulong BLAPBOMNGGO, int BAFCOCPKHOL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int JMHGEKPPEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int GCELOMBGLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int ECOFCCMBKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double LBAFLGLAOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int IFMIAKHADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int BGBIOHIKCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int BDHHGBOBKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch CJIJGIJDHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HPGEBGFGCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long DCLODBGOLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object IEMIGLPILNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal BJDNGBELDLA FJECALAOHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal BJDNGBELDLA DGCAAEEAJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<NMBFLKAIPPB> MIHBDLJAAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<ABPDCACPDJN> AIPCKMOJFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly ABPDCACPDJN[] HJLCKHMIPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int CFKAMHDHEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int FFODJDJJELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool ECDBJHJGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int DHKLHJGNGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int MJJOMFKIEEA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CBPHCGEDMOP = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int LELMLHGIPPK = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object OKFOOGNIJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KHDNIKEHLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, JOJELHPAPNL> FOMJPGIEFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> OJNKGKNECPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NMBFLKAIPPB PAJPMBECGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int KOALCPMBGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int LHEBLBLFMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint DPDCBANFMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IIPOPCJNMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int EIKCADIBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long MBAELBNNELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte PEHELANKGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private KHKAGBCHMND HKGFFKKGDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private NMBFLKAIPPB ODNAMILAKMO;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int LFJOBHEGCPM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int MFJNLNONOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly NMBFLKAIPPB LMGAADMNAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly NMBFLKAIPPB IHEJEGMCJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly NMBFLKAIPPB HDDADHPDFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly NMBFLKAIPPB JIDJHDJBAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private APBJAPDDJBM LDFAEIIAPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly GDGMJBJODBA NMDMNDIHIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int HJABBJLNKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object IMIEFDBBNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly HIMNKNKLLGD HMGGCPMBGBG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte BNCIPOGNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5B520", Offset = "0xA5A120", VA = "0x180A5B520")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5FF9380", Offset = "0x5FF7F80", VA = "0x185FF9380")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint GJMKIGHEKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x94DCE0", Offset = "0x94C8E0", VA = "0x18094DCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KHKAGBCHMND DIJMAGKDNLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1518840", Offset = "0x1517440", VA = "0x181518840")]
		get
		{
			return default(KHKAGBCHMND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long BNIBLHDCFJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8963C0", Offset = "0x894FC0", VA = "0x1808963C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PKEMCCEBAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xE82C40", Offset = "0xE81840", VA = "0x180E82C40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x17C6C40", Offset = "0x17C5840", VA = "0x1817C6C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PPDBDCHFIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FFA5A0", Offset = "0x5FF91A0", VA = "0x185FFA5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GCMAMCCCCFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x897F00", Offset = "0x896B00", VA = "0x180897F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double CHAAFJPBFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4992470", Offset = "0x4991070", VA = "0x184992470")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EONFEIEDALD MPMFLEMHAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FF9430", Offset = "0x5FF8030", VA = "0x185FF9430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FFC2D0", Offset = "0x5FFAED0", VA = "0x185FFC2D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FFC6F0", Offset = "0x5FFB2F0", VA = "0x185FFC6F0")]
	internal BJDNGBELDLA(GDGMJBJODBA OCPEGACHFND, IPEndPoint DKKODPEOAIL, int MJDOIIBKEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8D40", Offset = "0x5FF7940", VA = "0x185FF8D40")]
	internal void CNHLMNKFLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8830", Offset = "0x5FF7430", VA = "0x185FF8830")]
	internal void ACAPAAHOAIK(IPEndPoint CFCCAPIILNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA770", Offset = "0x5FF9370", VA = "0x185FFA770")]
	internal void LHDNAANOPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9DD0", Offset = "0x5FF89D0", VA = "0x185FF9DD0")]
	private void IPLJMPAHHJO(int APIEPNBCCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA560", Offset = "0x5FF9160", VA = "0x185FFA560")]
	private void JPEEIBNDCNH(int IBBOBMDMPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FFC0F0", Offset = "0x5FFACF0", VA = "0x185FFC0F0")]
	private ABPDCACPDJN PAJHHHFBNFG(byte MCPGGPJAKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FFC380", Offset = "0x5FFAF80", VA = "0x185FFC380")]
	internal BJDNGBELDLA(GDGMJBJODBA OCPEGACHFND, IPEndPoint DKKODPEOAIL, int MJDOIIBKEKN, byte JDFGIFODPON, DIBGMDCNCIF PDKLIPJGHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FFC510", Offset = "0x5FFB110", VA = "0x185FFC510")]
	internal BJDNGBELDLA(GDGMJBJODBA OCPEGACHFND, DKOKIBKOKLA IBNNNHFPFBF, int MJDOIIBKEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8D60", Offset = "0x5FF7960", VA = "0x185FF8D60")]
	internal void DGOFEKBGNEN(LGPHHCAPPCA KLJNGPBKFIN, byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FFAD50", Offset = "0x5FF9950", VA = "0x185FFAD50")]
	internal bool MDPONPEALLN(BBMDDCLDIJE LOBAIGHBGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FFC2A0", Offset = "0x5FFAEA0", VA = "0x185FFC2A0")]
	public void PLKIBGGDJPP(byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int OLBMNABBGHI, COGHNIEIKKF OGIKBJOPPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FFB960", Offset = "0x5FFA560", VA = "0x185FFB960")]
	private void NOBPLNIAHIL(byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int OLBMNABBGHI, byte IALJDPOOCHL, COGHNIEIKKF PGDMOBMOMNI, object KCEHGHMENBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8900", Offset = "0x5FF7500", VA = "0x185FF8900")]
	public void BEFHIONLBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FFBEC0", Offset = "0x5FFAAC0", VA = "0x185FFBEC0")]
	internal PLFFFOMKEOI OGNJMNNJEJM(NMBFLKAIPPB LOBAIGHBGLP)
	{
		return default(PLFFFOMKEOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FF88A0", Offset = "0x5FF74A0", VA = "0x185FF88A0")]
	internal void BCJLCPJIILN(ABPDCACPDJN KJMBOBLOOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9070", Offset = "0x5FF7C70", VA = "0x185FF9070")]
	internal KPBEMBAFPJL HALFADNJGAB(byte[] BFLLAIFBMAJ, int GMEOEMGBEED, int OLBMNABBGHI, bool KHODILEOPHB)
	{
		return default(KPBEMBAFPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8860", Offset = "0x5FF7460", VA = "0x185FF8860")]
	private void ANIDINIKPDG(int NJGMHHKGKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FFADD0", Offset = "0x5FF99D0", VA = "0x185FFADD0")]
	internal void MGIOOCCKDLJ(COGHNIEIKKF GHPOFPMJIIK, NMBFLKAIPPB GAECIBGPFJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA800", Offset = "0x5FF9400", VA = "0x185FFA800")]
	private void LJAMBINPFNC(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FF89B0", Offset = "0x5FF75B0", VA = "0x185FF89B0")]
	private void BIHCOIOFGOK(int EOJDMAMGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FFA5B0", Offset = "0x5FF91B0", VA = "0x185FFA5B0")]
	internal MLACLIPHBLN KLDDFOKIPFF(LGPHHCAPPCA BLGDBMAMFGJ)
	{
		return default(MLACLIPHBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9EA0", Offset = "0x5FF8AA0", VA = "0x185FF9EA0")]
	internal void JMELOOMMDCA(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FFBFA0", Offset = "0x5FFABA0", VA = "0x185FFBFA0")]
	private void ONAJEOKGLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FFB760", Offset = "0x5FFA360", VA = "0x185FFB760")]
	internal void NNGBGIJFIBM(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FF94E0", Offset = "0x5FF80E0", VA = "0x185FF94E0")]
	internal void HMDNBLCBPCK(int EOJDMAMGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8DB0", Offset = "0x5FF79B0", VA = "0x185FF8DB0")]
	internal void FHAAIJFJPKM(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HIMNKNKLLGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PECDAKGGMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long FBCIDDKMOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long JAPDLNEFAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long BKLIHGAIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long NKEAECMLGPK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long OAHKHPAMLOG;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long GFFLFKNJNKE;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long BBDKNJNAKJE;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long LHHGIIMEGDD;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long JLLIOMHLOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long LLAGGDNCCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long PKIJNMEHCPP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FEKMPKCHCPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6007CC0", Offset = "0x60068C0", VA = "0x186007CC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long INBLGDCBNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6007EA0", Offset = "0x6006AA0", VA = "0x186007EA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long OCDKGMAODKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6007E40", Offset = "0x6006A40", VA = "0x186007E40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FFNHELMCMFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6007EB0", Offset = "0x6006AB0", VA = "0x186007EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BCENKCGCOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6007F60", Offset = "0x6006B60", VA = "0x186007F60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long GGKPJOCACAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6007E90", Offset = "0x6006A90", VA = "0x186007E90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long CMBLCINNDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6007E50", Offset = "0x6006A50", VA = "0x186007E50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long BLOMNPAIDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6007DA0", Offset = "0x60069A0", VA = "0x186007DA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private APBJAPDDJBM FFKHCKDLHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6007CD0", Offset = "0x60068D0", VA = "0x186007CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double KKBHEBMHOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6007EC0", Offset = "0x6006AC0", VA = "0x186007EC0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6007F20", Offset = "0x6006B20", VA = "0x186007F20")]
	public void OMNFNMJPOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6007DE0", Offset = "0x60069E0", VA = "0x186007DE0")]
	public void KCDDOIPHGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6007BA0", Offset = "0x60067A0", VA = "0x186007BA0")]
	public void BGOMEDLGMJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6007CE0", Offset = "0x60068E0", VA = "0x186007CE0")]
	public void GKHLAEIOPBL(long JLLMLLDHPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6007D40", Offset = "0x6006940", VA = "0x186007D40")]
	public void HLMAKLPGPIK(long PJOHEMKCFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6007C60", Offset = "0x6006860", VA = "0x186007C60")]
	public void EBKGCNONALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6007BF0", Offset = "0x60067F0", VA = "0x186007BF0")]
	public void DOHDKFLFLAC(long GIBGJEGLBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6007F70", Offset = "0x6006B70", VA = "0x186007F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6007B00", Offset = "0x6006700", VA = "0x186007B00")]
	public void ACCCGIGOGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HIMNKNKLLGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BOLBFNPNJHF
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> OGJMNECHGKG;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCB70", Offset = "0x5FFB770", VA = "0x185FFCB70")]
	public static IPEndPoint NPOECIJMKGK(string DHIKHNFDEND, int APMPPPPEKJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCE50", Offset = "0x5FFBA50", VA = "0x185FFCE50")]
	public static IPAddress OCGODNJMPBH(string DHIKHNFDEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCDC0", Offset = "0x5FFB9C0", VA = "0x185FFCDC0")]
	public static IPAddress OCGODNJMPBH(string DHIKHNFDEND, AddressFamily LIDICBLGOLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FFCB40", Offset = "0x5FFB740", VA = "0x185FFCB40")]
	internal static int LIHJEDNPHOM(int EFBGONPHCMG, int CEHMAADEJEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B9D400", Offset = "0x2B9C000", VA = "0x182B9D400")]
	internal static T[] OINHEEPLGBK<T>(int KNHHBEFLJAF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class DEALHCABFOE : ABPDCACPDJN
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct PIMDPJFPNFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private NMBFLKAIPPB AAKOGPFEIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long AOMKCKDKEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool EPLFIPJHNKE;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x600F1C0", Offset = "0x600DDC0", VA = "0x18600F1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x600F130", Offset = "0x600DD30", VA = "0x18600F130")]
		public void CIBOHFMOAPI(NMBFLKAIPPB LOBAIGHBGLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x600F150", Offset = "0x600DD50", VA = "0x18600F150")]
		public bool HBKJAHNNOFG(long NIKMMPJCPGG, BJDNGBELDLA MPDBPEAFFBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x600F0E0", Offset = "0x600DCE0", VA = "0x18600F0E0")]
		public bool ANKOMBFBDGF(BJDNGBELDLA MPDBPEAFFBI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly NMBFLKAIPPB GOEHCCOOEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly PIMDPJFPNFP[] OGDAMIAFAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly NMBFLKAIPPB[] PNGCPNLKOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] LPJINBNDIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int DFCHOGMGAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int GKBAPHJBPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int NEMLANMMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int EPPPHOBFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HJHNJCOILAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly COGHNIEIKKF FKHLOHFKLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool HGLBFGPIJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int EJKNLPNIPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte IEIKJGJDOIJ;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE1E0", Offset = "0x5FFCDE0", VA = "0x185FFE1E0")]
	public DEALHCABFOE(BJDNGBELDLA MPDBPEAFFBI, bool LMFLKNHKGDM, byte MJDOIIBKEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD2F0", Offset = "0x5FFBEF0", VA = "0x185FFD2F0")]
	private void HNCNMAFFGMF(NMBFLKAIPPB LOBAIGHBGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD6B0", Offset = "0x5FFC2B0", VA = "0x185FFD6B0", Slot = "4")]
	protected override bool IGLAGBFEMBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FFDB80", Offset = "0x5FFC780", VA = "0x185FFDB80", Slot = "5")]
	public override bool JMELOOMMDCA(NMBFLKAIPPB LOBAIGHBGLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LEAJKEMICMD : ABPDCACPDJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int DJJGKKNLKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort GKBAPHJBPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool KNMIJLKPLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NMBFLKAIPPB PDOGOLLIIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly NMBFLKAIPPB GLCKBMDPHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool PJKGPAFIJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte IEIKJGJDOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long NCNBNLDFCMC;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x600C400", Offset = "0x600B000", VA = "0x18600C400")]
	public LEAJKEMICMD(BJDNGBELDLA MPDBPEAFFBI, bool PHIJHCAOKIG, byte MJDOIIBKEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x600BC60", Offset = "0x600A860", VA = "0x18600BC60", Slot = "4")]
	protected override bool IGLAGBFEMBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x600C120", Offset = "0x600AD20", VA = "0x18600C120", Slot = "5")]
	public override bool JMELOOMMDCA(NMBFLKAIPPB LOBAIGHBGLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class CPPFLPDFAFM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct MLHLOHHHHBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong IHFCNEICFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double JAIAODEHIEL;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct EMPGDLCFNGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int HFMADGDIENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float BGNEFIOBAIK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7D00", Offset = "0x5FF6900", VA = "0x185FF7D00")]
	private static void GEJGAGKMBGE(byte[] OFBCPBHPLBK, int APMEPKJBNGD, ulong BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD130", Offset = "0x5FFBD30", VA = "0x185FFD130")]
	private static void GEJGAGKMBGE(byte[] OFBCPBHPLBK, int APMEPKJBNGD, int BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD1A0", Offset = "0x5FFBDA0", VA = "0x185FFD1A0")]
	public static void GEJGAGKMBGE(byte[] OFBCPBHPLBK, int APMEPKJBNGD, short BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD1E0", Offset = "0x5FFBDE0", VA = "0x185FFD1E0")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, double CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD200", Offset = "0x5FFBE00", VA = "0x185FFD200")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD1A0", Offset = "0x5FFBDA0", VA = "0x185FFD1A0")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, short CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD1A0", Offset = "0x5FFBDA0", VA = "0x185FFD1A0")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, ushort CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD130", Offset = "0x5FFBD30", VA = "0x185FFD130")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD130", Offset = "0x5FFBD30", VA = "0x185FFD130")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, uint CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD120", Offset = "0x5FFBD20", VA = "0x185FFD120")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD120", Offset = "0x5FFBD20", VA = "0x185FFD120")]
	public static void FNLKEEEKOJF(byte[] NDKFLGEBABO, int HAOCJMNINJC, ulong CABLCDOIFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HAEGDPOPBEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] OBDICJNJBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int FFMPCOFKCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int OAHANHOCLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int GPMNBGFNBLG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] IJAONBGKGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int ADDAOJKMDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA0", Offset = "0x8E8BA0", VA = "0x1808E9FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HDDBFKMJJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x60071B0", Offset = "0x6005DB0", VA = "0x1860071B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FJGAAIAPKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2066F40", Offset = "0x2065B40", VA = "0x182066F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DGCAGLLEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6006F70", Offset = "0x6005B70", VA = "0x186006F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6007560", Offset = "0x6006160", VA = "0x186007560")]
	public void GPFLOEEDCPA(byte[] DOHADELBNEM, int APMEPKJBNGD, int JOMAOELOIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public HAEGDPOPBEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6007AA0", Offset = "0x60066A0", VA = "0x186007AA0")]
	public HAEGDPOPBEO(byte[] DOHADELBNEM, int APMEPKJBNGD, int JOMAOELOIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60073E0", Offset = "0x6005FE0", VA = "0x1860073E0")]
	public IPEndPoint FPHKPECMLPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6007520", Offset = "0x6006120", VA = "0x186007520")]
	public byte LPKFLNDPANG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6007520", Offset = "0x6006120", VA = "0x186007520")]
	public sbyte GNBHCLEFDDL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2E13090", Offset = "0x2E11C90", VA = "0x182E13090")]
	public T[] KKJHKEEMDLJ<T>(ushort OLKJNOHMJPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6007850", Offset = "0x6006450", VA = "0x186007850")]
	public bool[] KAJDKEHCNEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6007270", Offset = "0x6005E70", VA = "0x186007270")]
	public ushort[] DJPHCKNCPJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6006EA0", Offset = "0x6005AA0", VA = "0x186006EA0")]
	public short[] ANJGIDAOHBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60071C0", Offset = "0x6005DC0", VA = "0x1860071C0")]
	public int[] DAPIEJFLPPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60079B0", Offset = "0x60065B0", VA = "0x1860079B0")]
	public uint[] NPNMADDGNOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60079F0", Offset = "0x60065F0", VA = "0x1860079F0")]
	public float[] OMFGGDIDPEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6007810", Offset = "0x6006410", VA = "0x186007810")]
	public double[] HNNGMMOACLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60072F0", Offset = "0x6005EF0", VA = "0x1860072F0")]
	public long[] FDMGKLIIDMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60072B0", Offset = "0x6005EB0", VA = "0x1860072B0")]
	public ulong[] FADLACKLFLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6006F80", Offset = "0x6005B80", VA = "0x186006F80")]
	public string[] BLGCNKPGPDA(int KNMNPEJNPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60075A0", Offset = "0x60061A0", VA = "0x1860075A0")]
	public bool HGELKCDCFEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6007330", Offset = "0x6005F30", VA = "0x186007330")]
	public char FFAMAIAINGE()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6007330", Offset = "0x6005F30", VA = "0x186007330")]
	public ushort GBIAOGCHIAH()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6007890", Offset = "0x6006490", VA = "0x186007890")]
	public short KJHCHPEDHDE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6007140", Offset = "0x6005D40", VA = "0x186007140")]
	public long CCHKHNPGIGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6007200", Offset = "0x6005E00", VA = "0x186007200")]
	public ulong DBHLGGDHBIO()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60074B0", Offset = "0x60060B0", VA = "0x1860074B0")]
	public int GGKFJHLJPCF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6007940", Offset = "0x6006540", VA = "0x186007940")]
	public uint LBJHGOMECCE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x60070D0", Offset = "0x6005CD0", VA = "0x1860070D0")]
	public float CALEEBLFHJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6006F00", Offset = "0x6005B00", VA = "0x186006F00")]
	public double AOPGMJPHDFE()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x60075E0", Offset = "0x60061E0", VA = "0x1860075E0")]
	public string HGNDIIOKDHA(int PEMOHIDFBKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6007A30", Offset = "0x6006630", VA = "0x186007A30")]
	public ArraySegment<byte> PBGFOPNADJI(int KNHHBEFLJAF)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6007900", Offset = "0x6006500", VA = "0x186007900")]
	public sbyte[] KOHBAONAIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60073A0", Offset = "0x6005FA0", VA = "0x1860073A0")]
	public byte[] FNGJBGOJMFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6006EE0", Offset = "0x6005AE0", VA = "0x186006EE0")]
	public void ANKOMBFBDGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DIBGMDCNCIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] OBDICJNJBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int FFMPCOFKCDF;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int EOPCHIOPNOK = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool ABHDMKBAJKE;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding MEGHHDAOIFK;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int DGKANNAIGNI = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] AIBILPDGNCA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] HCNDAPMGMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int LDFIBCLBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF240", Offset = "0x5FFDE40", VA = "0x185FFF240")]
	public DIBGMDCNCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF2C0", Offset = "0x5FFDEC0", VA = "0x185FFF2C0")]
	public DIBGMDCNCIF(bool GJBFOMPJIKC, int OPNGAFEOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF0B0", Offset = "0x5FFDCB0", VA = "0x185FFF0B0")]
	public static DIBGMDCNCIF LKAGHLLKJBM(string CABLCDOIFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFF120", Offset = "0x5FFDD20", VA = "0x185FFF120")]
	public void OGOHNMAACCF(int LLFNIKDNAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x20DFC50", Offset = "0x20DE850", VA = "0x1820DFC50")]
	public void OMNFNMJPOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE650", Offset = "0x5FFD250", VA = "0x185FFE650")]
	public void KBCIDKIHPNB(float CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE780", Offset = "0x5FFD380", VA = "0x185FFE780")]
	public void KBCIDKIHPNB(double CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE600", Offset = "0x5FFD200", VA = "0x185FFE600")]
	public void KBCIDKIHPNB(long CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE600", Offset = "0x5FFD200", VA = "0x185FFE600")]
	public void KBCIDKIHPNB(ulong CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE6F0", Offset = "0x5FFD2F0", VA = "0x185FFE6F0")]
	public void KBCIDKIHPNB(int CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE6F0", Offset = "0x5FFD2F0", VA = "0x185FFE6F0")]
	public void KBCIDKIHPNB(uint CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE9F0", Offset = "0x5FFD5F0", VA = "0x185FFE9F0")]
	public void KBCIDKIHPNB(char CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE9F0", Offset = "0x5FFD5F0", VA = "0x185FFE9F0")]
	public void KBCIDKIHPNB(ushort CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE9F0", Offset = "0x5FFD5F0", VA = "0x185FFE9F0")]
	public void KBCIDKIHPNB(short CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEAC0", Offset = "0x5FFD6C0", VA = "0x185FFEAC0")]
	public void KBCIDKIHPNB(sbyte CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEAC0", Offset = "0x5FFD6C0", VA = "0x185FFEAC0")]
	public void KBCIDKIHPNB(byte CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEBF0", Offset = "0x5FFD7F0", VA = "0x185FFEBF0")]
	public void KBCIDKIHPNB(byte[] BFLLAIFBMAJ, int APMEPKJBNGD, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE520", Offset = "0x5FFD120", VA = "0x185FFE520")]
	public void GEOCGDIBNEH(sbyte[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE520", Offset = "0x5FFD120", VA = "0x185FFE520")]
	public void NDOIHNMGGNC(byte[] BFLLAIFBMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEA60", Offset = "0x5FFD660", VA = "0x185FFEA60")]
	public void KBCIDKIHPNB(bool CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEE20", Offset = "0x5FFDA20", VA = "0x185FFEE20")]
	public void LALOGEOJILO(Array MMEKJOMIIBL, int CGBPPIHHDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FFED40", Offset = "0x5FFD940", VA = "0x185FFED40")]
	public void LALOGEOJILO(float[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEF00", Offset = "0x5FFDB00", VA = "0x185FFEF00")]
	public void LALOGEOJILO(double[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEF00", Offset = "0x5FFDB00", VA = "0x185FFEF00")]
	public void LALOGEOJILO(long[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEF00", Offset = "0x5FFDB00", VA = "0x185FFEF00")]
	public void LALOGEOJILO(ulong[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5FFED40", Offset = "0x5FFD940", VA = "0x185FFED40")]
	public void LALOGEOJILO(int[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5FFED40", Offset = "0x5FFD940", VA = "0x185FFED40")]
	public void LALOGEOJILO(uint[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEC60", Offset = "0x5FFD860", VA = "0x185FFEC60")]
	public void LALOGEOJILO(ushort[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEC60", Offset = "0x5FFD860", VA = "0x185FFEC60")]
	public void LALOGEOJILO(short[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE520", Offset = "0x5FFD120", VA = "0x185FFE520")]
	public void LALOGEOJILO(bool[] CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEFE0", Offset = "0x5FFDBE0", VA = "0x185FFEFE0")]
	public void LALOGEOJILO(string[] CABLCDOIFFL, int OEPAIKLPIFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5FFEB20", Offset = "0x5FFD720", VA = "0x185FFEB20")]
	public void KBCIDKIHPNB(IPEndPoint MCDJJKAEJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE9E0", Offset = "0x5FFD5E0", VA = "0x185FFE9E0")]
	public void KBCIDKIHPNB(string CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FFE7D0", Offset = "0x5FFD3D0", VA = "0x185FFE7D0")]
	public void KBCIDKIHPNB(string CABLCDOIFFL, int PEMOHIDFBKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NMAJGLPFPPE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class LBCMODBKCPC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong HJABBJLNKKC;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4364B20", Offset = "0x4363720", VA = "0x184364B20")]
		static LBCMODBKCPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void NCHBHFEOKAK(HAEGDPOPBEO DMECMNHFOBP, object KCEHGHMENBC);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class IGLPPHJDPAF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public NMAJGLPFPPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public IGLPPHJDPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x402A9D0", Offset = "0x40295D0", VA = "0x18402A9D0")]
		internal void EACCADHDFJO(HAEGDPOPBEO reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MDCBPNHLMHL<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public NMAJGLPFPPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public MDCBPNHLMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4586480", Offset = "0x4585080", VA = "0x184586480")]
		internal void EACCADHDFJO(HAEGDPOPBEO reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly HJABJDEAKOP LINLCIKECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, NCHBHFEOKAK> JELHMPGLBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly DIBGMDCNCIF DLJFHDDACPN;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x600E320", Offset = "0x600CF20", VA = "0x18600E320")]
	public NMAJGLPFPPE(int KNMNPEJNPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B3F0", Offset = "0x2B89FF0", VA = "0x182B8B3F0", Slot = "4")]
	protected virtual ulong PHDPCLMFFMK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x600E1A0", Offset = "0x600CDA0", VA = "0x18600E1A0", Slot = "5")]
	protected virtual NCHBHFEOKAK JDMEFIDGPFL(HAEGDPOPBEO DMECMNHFOBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2F83B50", Offset = "0x2F82750", VA = "0x182F83B50", Slot = "6")]
	protected virtual void MLDHOINHCPM<T>(DIBGMDCNCIF CDCPEBLNAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x600E120", Offset = "0x600CD20", VA = "0x18600E120")]
	public void HJLMEICEFFB(HAEGDPOPBEO DMECMNHFOBP, object KCEHGHMENBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2F83AA0", Offset = "0x2F826A0", VA = "0x182F83AA0")]
	public void KEFHONGLMJL<T>(DIBGMDCNCIF CDCPEBLNAND, T LOBAIGHBGLP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x600E2D0", Offset = "0x600CED0", VA = "0x18600E2D0")]
	public void NNJEOODLKPA(HAEGDPOPBEO DMECMNHFOBP, object KCEHGHMENBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2F838E0", Offset = "0x2F824E0", VA = "0x182F838E0")]
	public void IAJGAIJAAGL<T>(Action<T> IMNBDDFCIKC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2F83720", Offset = "0x2F82320", VA = "0x182F83720")]
	public void IAJGAIJAAGL<T, TUserData>(Action<T, TUserData> IMNBDDFCIKC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class CPKOADOCFKL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD110", Offset = "0x5FFBD10", VA = "0x185FFD110")]
	public CPKOADOCFKL(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class BPEGFNDOBCO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5FFD0B0", Offset = "0x5FFBCB0", VA = "0x185FFD0B0")]
	public BPEGFNDOBCO(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HJABJDEAKOP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum PDDBPPEGLJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class JNMOMBKMLGN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public PDDBPPEGLJH LBAEOCJIFPD;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x42004A0", Offset = "0x41FF0A0", VA = "0x1842004A0", Slot = "4")]
		public virtual void CIBOHFMOAPI(MethodInfo NNMNLPGOHGB, MethodInfo BEKMPNPIJDJ, PDDBPPEGLJH FIFJJNIIAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GIEBADELPDF(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GBGNLFAOGDC(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		protected JNMOMBKMLGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class KJIGBJPCCMG<TClass, TProperty> : JNMOMBKMLGN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> OHIEDMCGIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> GOMKKNAHCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> MENPAMFDLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> DIEMHGKOBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> LCIGEELCFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> IHEMGJKKCHM;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x42C6330", Offset = "0x42C4F30", VA = "0x1842C6330", Slot = "7")]
		public override void ALKJBBBHGAB(TClass JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x42C68A0", Offset = "0x42C54A0", VA = "0x1842C68A0", Slot = "8")]
		public override void CGINOPPFGMM(TClass JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x42CAB00", Offset = "0x42C9700", VA = "0x1842CAB00", Slot = "9")]
		public override void GIEBADELPDF(TClass JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x42CA320", Offset = "0x42C8F20", VA = "0x1842CA320", Slot = "10")]
		public override void GBGNLFAOGDC(TClass JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x42C6790", Offset = "0x42C5390", VA = "0x1842C6790")]
		protected TProperty[] BCEELGGKJGN(TClass JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x42CB2E0", Offset = "0x42C9EE0", VA = "0x1842CB2E0")]
		protected TProperty[] HFCABFHIDLH(TClass JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x42C8CA0", Offset = "0x42C78A0", VA = "0x1842C8CA0", Slot = "4")]
		public override void CIBOHFMOAPI(MethodInfo NNMNLPGOHGB, MethodInfo BEKMPNPIJDJ, PDDBPPEGLJH FIFJJNIIAPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x42CB360", Offset = "0x42C9F60", VA = "0x1842CB360")]
		protected KJIGBJPCCMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class FNNGHHAGKFO<TClass, TProperty> : KJIGBJPCCMG<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void DKPPEOFEDIB(HAEGDPOPBEO LNOMDCGJNHN, [Out] TProperty FHPFLCLLCPF);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PPKIIHHBNIM(DIBGMDCNCIF HPBFBIICGCP, TProperty FHPFLCLLCPF);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3E205C0", Offset = "0x3E1F1C0", VA = "0x183E205C0", Slot = "5")]
		public override void DNEPMNIMLAE(TClass JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3E206E0", Offset = "0x3E1F2E0", VA = "0x183E206E0", Slot = "6")]
		public override void KEFHONGLMJL(TClass JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3E202E0", Offset = "0x3E1EEE0", VA = "0x183E202E0", Slot = "7")]
		public override void ALKJBBBHGAB(TClass JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3E20460", Offset = "0x3E1F060", VA = "0x183E20460", Slot = "8")]
		public override void CGINOPPFGMM(TClass JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3E20760", Offset = "0x3E1F360", VA = "0x183E20760")]
		protected FNNGHHAGKFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class FCGCBDKKAPA<T> : KJIGBJPCCMG<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8BB0", Offset = "0x3DE77B0", VA = "0x183DE8BB0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8C30", Offset = "0x3DE7830", VA = "0x183DE8C30", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8AC0", Offset = "0x3DE76C0", VA = "0x183DE8AC0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8B40", Offset = "0x3DE7740", VA = "0x183DE8B40", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public FCGCBDKKAPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class IDIDLIPNLKD<T> : KJIGBJPCCMG<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4019A30", Offset = "0x4018630", VA = "0x184019A30", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8C30", Offset = "0x3DE7830", VA = "0x183DE8C30", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x40199B0", Offset = "0x40185B0", VA = "0x1840199B0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8B40", Offset = "0x3DE7740", VA = "0x183DE8B40", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public IDIDLIPNLKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class DIJOEKDBNBO<T> : KJIGBJPCCMG<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB270", Offset = "0x5AE9E70", VA = "0x185AEB270", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x50D2D60", Offset = "0x50D1960", VA = "0x1850D2D60", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5AEB1F0", Offset = "0x5AE9DF0", VA = "0x185AEB1F0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x50D2C70", Offset = "0x50D1870", VA = "0x1850D2C70", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public DIJOEKDBNBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class BPAKOHOOOBB<T> : KJIGBJPCCMG<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x50D2CE0", Offset = "0x50D18E0", VA = "0x1850D2CE0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x50D2D60", Offset = "0x50D1960", VA = "0x1850D2D60", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x50D2BF0", Offset = "0x50D17F0", VA = "0x1850D2BF0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x50D2C70", Offset = "0x50D1870", VA = "0x1850D2C70", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public BPAKOHOOOBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class OPBOJIDOCAB<T> : KJIGBJPCCMG<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x47D3F70", Offset = "0x47D2B70", VA = "0x1847D3F70", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x47D3FF0", Offset = "0x47D2BF0", VA = "0x1847D3FF0", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x47D3EF0", Offset = "0x47D2AF0", VA = "0x1847D3EF0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x43C7B60", Offset = "0x43C6760", VA = "0x1843C7B60", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public OPBOJIDOCAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DLHNHOOPDOO<T> : KJIGBJPCCMG<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5B03170", Offset = "0x5B01D70", VA = "0x185B03170", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x47D3FF0", Offset = "0x47D2BF0", VA = "0x1847D3FF0", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5B030F0", Offset = "0x5B01CF0", VA = "0x185B030F0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x43C7B60", Offset = "0x43C6760", VA = "0x1843C7B60", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public DLHNHOOPDOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class MJNGCFOHEAA<T> : KJIGBJPCCMG<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x45BEBF0", Offset = "0x45BD7F0", VA = "0x1845BEBF0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x45BEC70", Offset = "0x45BD870", VA = "0x1845BEC70", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x45BFCC0", Offset = "0x45BE8C0", VA = "0x1845BFCC0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F35CC0", Offset = "0x3F348C0", VA = "0x183F35CC0", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public MJNGCFOHEAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MHPJNGHNEAI<T> : KJIGBJPCCMG<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x45BEBF0", Offset = "0x45BD7F0", VA = "0x1845BEBF0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x45BEC70", Offset = "0x45BD870", VA = "0x1845BEC70", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x45BEB70", Offset = "0x45BD770", VA = "0x1845BEB70", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F35CC0", Offset = "0x3F348C0", VA = "0x183F35CC0", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public MHPJNGHNEAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JPNJAPJJOAE<T> : KJIGBJPCCMG<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4204B60", Offset = "0x4203760", VA = "0x184204B60", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4204BE0", Offset = "0x42037E0", VA = "0x184204BE0", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4204AE0", Offset = "0x42036E0", VA = "0x184204AE0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8B40", Offset = "0x3DE7740", VA = "0x183DE8B40", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public JPNJAPJJOAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LPHLDOHBOKM<T> : KJIGBJPCCMG<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x43C7BD0", Offset = "0x43C67D0", VA = "0x1843C7BD0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x43C7C50", Offset = "0x43C6850", VA = "0x1843C7C50", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x43C7AE0", Offset = "0x43C66E0", VA = "0x1843C7AE0", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x43C7B60", Offset = "0x43C6760", VA = "0x1843C7B60", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public LPHLDOHBOKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class HEFPPDDLOAD<T> : KJIGBJPCCMG<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F35D30", Offset = "0x3F34930", VA = "0x183F35D30", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F35DB0", Offset = "0x3F349B0", VA = "0x183F35DB0", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F35C40", Offset = "0x3F34840", VA = "0x183F35C40", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F35CC0", Offset = "0x3F348C0", VA = "0x183F35CC0", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8CA0", Offset = "0x3DE78A0", VA = "0x183DE8CA0")]
		public HEFPPDDLOAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class EAKOHPEGLOM<T> : FNNGHHAGKFO<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A5F0", Offset = "0x3A591F0", VA = "0x183A5A5F0", Slot = "12")]
		protected override void PPKIIHHBNIM(DIBGMDCNCIF HPBFBIICGCP, char FHPFLCLLCPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A5C0", Offset = "0x3A591C0", VA = "0x183A5A5C0", Slot = "11")]
		protected override void DKPPEOFEDIB(HAEGDPOPBEO LNOMDCGJNHN, [Out] char FHPFLCLLCPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A620", Offset = "0x3A59220", VA = "0x183A5A620")]
		public EAKOHPEGLOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class HIDDOKACBBJ<T> : FNNGHHAGKFO<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E7C0", Offset = "0x3F3D3C0", VA = "0x183F3E7C0", Slot = "12")]
		protected override void PPKIIHHBNIM(DIBGMDCNCIF HPBFBIICGCP, IPEndPoint FHPFLCLLCPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E780", Offset = "0x3F3D380", VA = "0x183F3E780", Slot = "11")]
		protected override void DKPPEOFEDIB(HAEGDPOPBEO LNOMDCGJNHN, [Out] IPEndPoint FHPFLCLLCPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A5A620", Offset = "0x3A59220", VA = "0x183A5A620")]
		public HIDDOKACBBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DGFFDECDAEJ<T> : KJIGBJPCCMG<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int BCFAEIPONGB;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE720", Offset = "0x5ACD320", VA = "0x185ACE720")]
		public DGFFDECDAEJ(int PEMOHIDFBKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE620", Offset = "0x5ACD220", VA = "0x185ACE620", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE6A0", Offset = "0x5ACD2A0", VA = "0x185ACE6A0", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE520", Offset = "0x5ACD120", VA = "0x185ACE520", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5ACE5A0", Offset = "0x5ACD1A0", VA = "0x185ACE5A0", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class KEDGKGMMLOB<T> : JNMOMBKMLGN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo NPLNAEOCEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type DAFMCPDAMKD;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x42B1A00", Offset = "0x42B0600", VA = "0x1842B1A00")]
		public KEDGKGMMLOB(PropertyInfo OPOMMFAAAOF, Type MHNJGMKNOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x42B17D0", Offset = "0x42B03D0", VA = "0x1842B17D0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x42B1950", Offset = "0x42B0550", VA = "0x1842B1950", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x42B1710", Offset = "0x42B0310", VA = "0x1842B1710", Slot = "7")]
		public override void ALKJBBBHGAB(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x42B1770", Offset = "0x42B0370", VA = "0x1842B1770", Slot = "8")]
		public override void CGINOPPFGMM(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x42B18F0", Offset = "0x42B04F0", VA = "0x1842B18F0", Slot = "9")]
		public override void GIEBADELPDF(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x42B1890", Offset = "0x42B0490", VA = "0x1842B1890", Slot = "10")]
		public override void GBGNLFAOGDC(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class HPHNJCNAHII<T> : KEDGKGMMLOB<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3DE8870", Offset = "0x3DE7470", VA = "0x183DE8870")]
		public HPHNJCNAHII(PropertyInfo OPOMMFAAAOF, Type MHNJGMKNOAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D8E0", Offset = "0x3F6C4E0", VA = "0x183F6D8E0", Slot = "5")]
		public override void DNEPMNIMLAE(T JLPPIBNKLGL, HAEGDPOPBEO LNOMDCGJNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3F6D9A0", Offset = "0x3F6C5A0", VA = "0x183F6D9A0", Slot = "6")]
		public override void KEFHONGLMJL(T JLPPIBNKLGL, DIBGMDCNCIF HPBFBIICGCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class GIFJPPMJPEH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static GIFJPPMJPEH<T> AAGIFLNDKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly JNMOMBKMLGN<T>[] EFGCAFJDGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int HFMIDKJNEKL;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA240", Offset = "0x3EE8E40", VA = "0x183EEA240")]
		public GIFJPPMJPEH(List<JNMOMBKMLGN<T>> POMDDHBGIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA190", Offset = "0x3EE8D90", VA = "0x183EEA190")]
		public void KEFHONGLMJL(T PLAMADMDGIO, DIBGMDCNCIF CDCPEBLNAND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA0E0", Offset = "0x3EE8CE0", VA = "0x183EEA0E0")]
		public void DNEPMNIMLAE(T PLAMADMDGIO, HAEGDPOPBEO DMECMNHFOBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class MKEJKFMHLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract JNMOMBKMLGN<T> IBIJBNAFKLE<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private DIBGMDCNCIF FNHELAAMICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int DBNLDOEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, MKEJKFMHLEI> LBHFEODJNIN;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60082B0", Offset = "0x6006EB0", VA = "0x1860082B0")]
	public HJABJDEAKOP(int KNMNPEJNPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2E2F1D0", Offset = "0x2E2DDD0", VA = "0x182E2F1D0")]
	private GIFJPPMJPEH<T> IOFDEPKEEOD<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2DE6AF0", Offset = "0x2DE56F0", VA = "0x182DE6AF0")]
	public void PEGPHNFMEDB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2E2F0A0", Offset = "0x2E2DCA0", VA = "0x182E2F0A0")]
	public bool ICHKPGLOBMP<T>(HAEGDPOPBEO DMECMNHFOBP, T CGJNNJHBPPG) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2E2F140", Offset = "0x2E2DD40", VA = "0x182E2F140")]
	public void IMPFBNFMBKJ<T>(DIBGMDCNCIF CDCPEBLNAND, T PLAMADMDGIO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LDKOFHABFJH
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime DEJPAFMKCPG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] FJKHNJNJGID
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ADOBPMLCHFN PGLDFLPHLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x600A8C0", Offset = "0x60094C0", VA = "0x18600A8C0")]
		get
		{
			return default(ADOBPMLCHFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int ADGNNCINIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x600B510", Offset = "0x600A110", VA = "0x18600B510")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x600B340", Offset = "0x6009F40", VA = "0x18600B340")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public GIDLIEPACAE OGMJHMCEPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x600B110", Offset = "0x6009D10", VA = "0x18600B110")]
		get
		{
			return default(GIDLIEPACAE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x600B4A0", Offset = "0x600A0A0", VA = "0x18600B4A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int GFIOECNOEPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x600A8F0", Offset = "0x60094F0", VA = "0x18600A8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint FAJBGBFHOBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x600AFC0", Offset = "0x6009BC0", VA = "0x18600AFC0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? PDJIDBGOEBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x600B3B0", Offset = "0x6009FB0", VA = "0x18600B3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? PCHOOPALDCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x600B4E0", Offset = "0x600A0E0", VA = "0x18600B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? JFHBPHHHAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x600B380", Offset = "0x6009F80", VA = "0x18600B380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x600ADF0", Offset = "0x60099F0", VA = "0x18600ADF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? BEAEEGMHDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xDF95E0", Offset = "0xDF81E0", VA = "0x180DF95E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC20250", Offset = "0xC1EE50", VA = "0x180C20250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x600B890", Offset = "0x600A490", VA = "0x18600B890")]
	public LDKOFHABFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x600BBB0", Offset = "0x600A7B0", VA = "0x18600BBB0")]
	internal LDKOFHABFJH(byte[] NDKFLGEBABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x600B710", Offset = "0x600A310", VA = "0x18600B710")]
	public static LDKOFHABFJH PGKLIKDPINL(byte[] NDKFLGEBABO, DateTime ADMKGINLKEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x600B140", Offset = "0x6009D40", VA = "0x18600B140")]
	internal void IDIPDMKEJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x600AC10", Offset = "0x6009810", VA = "0x18600AC10")]
	private void CGNBBJBPOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x600A980", Offset = "0x6009580", VA = "0x18600A980")]
	private DateTime? BEFGNAIDBIA(int APMEPKJBNGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x600B540", Offset = "0x600A140", VA = "0x18600B540")]
	private void MJBAJBEBNMI(int APMEPKJBNGD, DateTime? CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x600B040", Offset = "0x6009C40", VA = "0x18600B040")]
	private ulong GCKIFCOOHEA(int APMEPKJBNGD)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x600B3E0", Offset = "0x6009FE0", VA = "0x18600B3E0")]
	private void LKDIBAAAGGE(int APMEPKJBNGD, ulong CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x600AB80", Offset = "0x6009780", VA = "0x18600AB80")]
	private uint BGAPEENIMGJ(int APMEPKJBNGD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBAF0", Offset = "0x5ECA6F0", VA = "0x185ECBAF0")]
	private static uint AJOIPALAFNM(uint MBJABMPNEHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x600A920", Offset = "0x6009520", VA = "0x18600A920")]
	private static ulong AJOIPALAFNM(ulong MBJABMPNEHF)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum ADOBPMLCHFN
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
public enum GIDLIEPACAE
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GLGIIMIODAE
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int JOMPDCEAAEN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int CNLNCOFGJBD = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int HMMBJLIMNNG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint POHHJBJMHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int EGLPHPLJAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int DFAADDHIONM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GJPAMLLJEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6006DA0", Offset = "0x60059A0", VA = "0x186006DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6006DB0", Offset = "0x60059B0", VA = "0x186006DB0")]
	public bool PLKIBGGDJPP(LDAPCJPICHP FAKFMJJAOKC, int GBMJCPKKICC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class ICNEAOKDPCE : LDAPCJPICHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket FAKFMJJAOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly GDGMJBJODBA OCPEGACHFND;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short LOEJGKEHAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6008AA0", Offset = "0x60076A0", VA = "0x186008AA0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ACBIFEHJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x60084A0", Offset = "0x60070A0", VA = "0x1860084A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint EAAEFLFJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6008390", Offset = "0x6006F90", VA = "0x186008390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily FONGJBBEJDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4351A90", Offset = "0x4350690", VA = "0x184351A90", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6008AC0", Offset = "0x60076C0", VA = "0x186008AC0")]
	public ICNEAOKDPCE(AddressFamily LIDICBLGOLH, GDGMJBJODBA OCPEGACHFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x60084C0", Offset = "0x60070C0", VA = "0x1860084C0", Slot = "8")]
	public bool JKOLLEIMKIN(IPEndPoint MCDJJKAEJFH, LCODKONBGGC MHIPPIIEJGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6008350", Offset = "0x6006F50", VA = "0x186008350", Slot = "9")]
	public int DLLFJGLAKJN(byte[] OFBCPBHPLBK, int APMEPKJBNGD, int OLKJNOHMJPI, IPEndPoint DKKODPEOAIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x60083B0", Offset = "0x6006FB0", VA = "0x1860083B0", Slot = "10")]
	public int IFAEDHDMEDH(byte[] OFBCPBHPLBK, EndPoint BHMMKDCGCEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6008A80", Offset = "0x6007680", VA = "0x186008A80", Slot = "11")]
	public void LEKOAIABPKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface LDAPCJPICHP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short LOEJGKEHAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int ACBIFEHJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint EAAEFLFJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily FONGJBBEJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JKOLLEIMKIN(IPEndPoint MCDJJKAEJFH, LCODKONBGGC MHIPPIIEJGN);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DLLFJGLAKJN(byte[] OFBCPBHPLBK, int APMEPKJBNGD, int OLKJNOHMJPI, IPEndPoint DKKODPEOAIL);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int IFAEDHDMEDH(byte[] OFBCPBHPLBK, EndPoint DKKODPEOAIL);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LEKOAIABPKN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct OOLPDAPCJEC : IEquatable<OOLPDAPCJEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long DCKEGIKMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long ODFICANDMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long FBLDLINGHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int GOEDIFHINFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int FAILFMOIHIP;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x600EFF0", Offset = "0x600DBF0", VA = "0x18600EFF0")]
	public OOLPDAPCJEC(byte[] CNNFBDLEEOC, int IENLMMCPHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8B07C0", Offset = "0x8AF3C0", VA = "0x1808B07C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x600EFB0", Offset = "0x600DBB0", VA = "0x18600EFB0", Slot = "4")]
	public bool Equals(OOLPDAPCJEC FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x600EF00", Offset = "0x600DB00", VA = "0x18600EF00", Slot = "0")]
	public override bool Equals(object PLAMADMDGIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class PHJHKGNLHME : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] PDEDPNJCOID;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class PBDHNLOMFEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int PJHDEJCPNPH;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
	protected PBDHNLOMFEC(int FCFHCKPFIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DCEPBMKAMBO(IPEndPoint MCDJJKAEJFH, byte[] BFLLAIFBMAJ, int APMEPKJBNGD, int OLBMNABBGHI);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void HKHPKELFHME(IPEndPoint MCDJJKAEJFH, byte[] BFLLAIFBMAJ, int APMEPKJBNGD, int OLBMNABBGHI);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KNDKGPDKKMA : PBDHNLOMFEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] NONKDEOLPHL;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator AMPJHNELBEA;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x218CF10", Offset = "0x218BB10", VA = "0x18218CF10")]
	public KNDKGPDKKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x600A6C0", Offset = "0x60092C0", VA = "0x18600A6C0")]
	public void LJCNDGEHHCM(IPEndPoint MCDJJKAEJFH, byte[] NONKDEOLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6009DD0", Offset = "0x60089D0", VA = "0x186009DD0")]
	public void BGKDLMBEFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6009EB0", Offset = "0x6008AB0", VA = "0x186009EB0", Slot = "4")]
	public override void DCEPBMKAMBO(IPEndPoint MCDJJKAEJFH, byte[] BFLLAIFBMAJ, int APMEPKJBNGD, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x600A360", Offset = "0x6008F60", VA = "0x18600A360", Slot = "5")]
	public override void HKHPKELFHME(IPEndPoint MCDJJKAEJFH, byte[] BFLLAIFBMAJ, int APMEPKJBNGD, int OLBMNABBGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct JKECHCAOAKG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void HIDCHBIPIKC([NoAlias] byte* GDDHFBPFLOO, [NoAlias] byte* NONKDEOLPHL, [NoAlias] byte* LDGBCNMFGKG, int OLBMNABBGHI);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class HJNDOJMBBDH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr HKPLBDMCING;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr NKBIHPPFJFM;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x600F6E0", Offset = "0x600E2E0", VA = "0x18600F6E0")]
		[BurstDiscard]
		private static void KCNLFMBGBBJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x600F360", Offset = "0x600DF60", VA = "0x18600F360")]
		private static IntPtr HCKKEBFPLOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x600F800", Offset = "0x600E400", VA = "0x18600F800")]
		public static void PLGGKBINGMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		public static void KMAKNPIEEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x600F4B0", Offset = "0x600E0B0", VA = "0x18600F4B0")]
		public unsafe static void JFCFICAEHOH([NoAlias] byte* GDDHFBPFLOO, [NoAlias] byte* NONKDEOLPHL, [NoAlias] byte* LDGBCNMFGKG, int OLBMNABBGHI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint NONKDEOLPHL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint LDGBCNMFGKG[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint BAEDJFPHKFC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint BBMGCBAJOMG[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint KHMMBICJMBJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint EJANMPGOKKH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint FHGBPJLBHNA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint CDHFAGOEDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint PNCLODLFNFD[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6009CF0", Offset = "0x60088F0", VA = "0x186009CF0")]
	private void OMNFNMJPOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6009730", Offset = "0x6008330", VA = "0x186009730")]
	private uint GMCEECFGBOL(uint PPIEANOJMKF, int LOFEDKCLKBJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7E90", Offset = "0x5FF6A90", VA = "0x185FF7E90")]
	private void FFNLAFIMINB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7F40", Offset = "0x5FF6B40", VA = "0x185FF7F40")]
	private void KBEIEDCKEPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8150", Offset = "0x5FF6D50", VA = "0x185FF8150")]
	private void NDHNGPPLCJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF81E0", Offset = "0x5FF6DE0", VA = "0x185FF81E0")]
	private void OCHCNCMJLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6009D70", Offset = "0x6008970", VA = "0x186009D70")]
	private void PCMCBBDMDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x60097D0", Offset = "0x60083D0", VA = "0x1860097D0")]
	private unsafe void KJEABNGHELM(byte* GDDHFBPFLOO, uint* NONKDEOLPHL, uint* LDGBCNMFGKG, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x60095D0", Offset = "0x60081D0", VA = "0x1860095D0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BFEPBHLMCFE([NoAlias] byte* GDDHFBPFLOO, [NoAlias] byte* NONKDEOLPHL, [NoAlias] byte* LDGBCNMFGKG, int OLBMNABBGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6009650", Offset = "0x6008250", VA = "0x186009650")]
	public static void BFEPBHLMCFE(Span<byte> GDDHFBPFLOO, Span<byte> NONKDEOLPHL, Span<byte> LDGBCNMFGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6009BF0", Offset = "0x60087F0", VA = "0x186009BF0")]
	public static void MOPKBNCCGDN(Span<byte> GDDHFBPFLOO, Span<byte> NONKDEOLPHL, Span<byte> LDGBCNMFGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6009760", Offset = "0x6008360", VA = "0x186009760")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JJDCNHCLJDN([NoAlias] byte* GDDHFBPFLOO, [NoAlias] byte* NONKDEOLPHL, [NoAlias] byte* LDGBCNMFGKG, int OLBMNABBGHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x600F8A0", Offset = "0x600E4A0", VA = "0x18600F8A0")]
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
