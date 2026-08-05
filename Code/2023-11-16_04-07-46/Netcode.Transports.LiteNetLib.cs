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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, BCGCGJCHLNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum EPNPCBLNJGE
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
		private NetworkManager CPIHDHKADMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, EDPEIAPILNK> NCEMGKPHBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DHJHNNJOPGC BOBPCNMJPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] KCBEJFMGGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EPNPCBLNJGE LPCAOLBIIPB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong KJKGODEKLGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76FCC0", VA = "0x180770CC0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool EDHOFAJAFEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x53315A0", Offset = "0x53305A0", VA = "0x1853315A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5330AA0", Offset = "0x532FAA0", VA = "0x185330AA0")]
		public void RecRoom_SetEncryptionInfo(ulong IJGEPGECJBA, byte[] BGNGIHJEFLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5330A80", Offset = "0x532FA80", VA = "0x185330A80")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5330950", Offset = "0x532F950", VA = "0x185330950")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x53314A0", Offset = "0x53304A0", VA = "0x1853314A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5330CA0", Offset = "0x532FCA0", VA = "0x185330CA0", Slot = "6")]
		public override void Send(ulong NLOANPFIFKC, ArraySegment<byte> FCLEEDACIMH, NetworkDelivery BDHIIHGDHPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5330A40", Offset = "0x532FA40", VA = "0x185330A40", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong NLOANPFIFKC, [Out] ArraySegment<byte> HPEDGLBMGED, [Out] float MAHBLFLCNHI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5330F90", Offset = "0x532FF90", VA = "0x185330F90", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x53313C0", Offset = "0x53303C0", VA = "0x1853313C0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x532FEE0", Offset = "0x532EEE0", VA = "0x18532FEE0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong NLOANPFIFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x532FD90", Offset = "0x532ED90", VA = "0x18532FD90", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5330490", Offset = "0x532F490", VA = "0x185330490", Slot = "12")]
		public override ulong GetCurrentRtt(ulong NLOANPFIFKC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5330F20", Offset = "0x532FF20", VA = "0x185330F20", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5330610", Offset = "0x532F610", VA = "0x185330610", Slot = "14")]
		public override void Initialize([Optional] NetworkManager CPIHDHKADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5330800", Offset = "0x532F800", VA = "0x185330800")]
		private HLLHEIADGBK NFMAPPKJPFL(NetworkDelivery CFGJPNBLNDJ)
		{
			return default(HLLHEIADGBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x532FCD0", Offset = "0x532ECD0", VA = "0x18532FCD0", Slot = "15")]
		private void DHEMLNJLLJD(EDPEIAPILNK PAPNAMKNKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5330350", Offset = "0x532F350", VA = "0x185330350", Slot = "16")]
		private void FOBHGDDDAJH(EDPEIAPILNK PAPNAMKNKAK, FFIPIDEKKCC OJCHFBCMMGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "17")]
		private void MFCGNLAOGBO(IPEndPoint OMJGBHNDKIM, SocketError JCHOGOMPOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5330050", Offset = "0x532F050", VA = "0x185330050", Slot = "18")]
		private void FCIBHGIKJIJ(EDPEIAPILNK PAPNAMKNKAK, FOIDKANJMJM JPPGFPLOJCL, byte GMHOEJKBJHE, HLLHEIADGBK BEBAHJONPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5330530", Offset = "0x532F530", VA = "0x185330530")]
		private void HMOBHGDIGCJ(int LHAIIFMNPNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "19")]
		private void HDAPDFJFPAI(IPEndPoint JBKDKOECJMC, FOIDKANJMJM JPPGFPLOJCL, PIPNONFJCLO PLKJOLKIJMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "20")]
		private void JCCGMFKIMHK(EDPEIAPILNK PAPNAMKNKAK, int OCJPFPEIPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53308D0", Offset = "0x532F8D0", VA = "0x1853308D0", Slot = "21")]
		private void NLKOOJHICAG(CIFOANAFLKK ICLPGCHCHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53307D0", Offset = "0x532F7D0", VA = "0x1853307D0")]
		private ulong KCHLJPPIMLK(EDPEIAPILNK PAPNAMKNKAK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5330930", Offset = "0x532F930", VA = "0x185330930")]
		private static int OLNCGJCFNHO(float JPCFJENKEPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53314C0", Offset = "0x53304C0", VA = "0x1853314C0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class KCJMNKHNBPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly EDPEIAPILNK IBKDENBLCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HCADHDIJDEL> FKGAINJFNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int DBOKFDNNPIC;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x532E750", Offset = "0x532D750", VA = "0x18532E750")]
	protected KCJMNKHNBPG(EDPEIAPILNK PAPNAMKNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x532E630", Offset = "0x532D630", VA = "0x18532E630")]
	public void EOMPLOCINNK(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x532E690", Offset = "0x532D690", VA = "0x18532E690")]
	protected void GNEAOOOEJKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x532E710", Offset = "0x532D710", VA = "0x18532E710")]
	public bool NCIFLGJOBAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool JMAAGOKLJDL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool ELNNPJPODLA(HCADHDIJDEL JOKHPGDBFNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum GJNFBJNDCKO
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
public class CIFOANAFLKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DHJHNNJOPGC ACHNIGIPMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int OCGLCJHADLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal DCGCJPIFFJB EAEKIEDHOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IJBJDHNONNN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal GJNFBJNDCKO GPGFJEGPJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x798730", Offset = "0x797730", VA = "0x180798730")]
		[CompilerGenerated]
		get
		{
			return default(GJNFBJNDCKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8620B0", Offset = "0x8610B0", VA = "0x1808620B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x531BB00", Offset = "0x531AB00", VA = "0x18531BB00")]
	internal void FAHFCGBJOPK(DCGCJPIFFJB MPJFJLIFNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x531BAD0", Offset = "0x531AAD0", VA = "0x18531BAD0")]
	private bool CIDKIKENGLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x531BB60", Offset = "0x531AB60", VA = "0x18531BB60")]
	internal CIFOANAFLKK(IPEndPoint JBKDKOECJMC, DCGCJPIFFJB NCMAAJNPPAO, DHJHNNJOPGC NJDADKILNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x531BA70", Offset = "0x531AA70", VA = "0x18531BA70")]
	public EDPEIAPILNK BNLFIADKEON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PIPNONFJCLO
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DEIJFJHEFPH
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
public struct FFIPIDEKKCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public DEIJFJHEFPH IGFPNLODPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError JKKPDGJKFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public FOIDKANJMJM IINIBIOPCHE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BCGCGJCHLNN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIPBKIHJGBC(EDPEIAPILNK PAPNAMKNKAK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BBGECEFIJKN(EDPEIAPILNK PAPNAMKNKAK, FFIPIDEKKCC OJCHFBCMMGO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KNHLLEEBGOK(IPEndPoint OMJGBHNDKIM, SocketError JCHOGOMPOCP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCEIBFPDNJO(EDPEIAPILNK PAPNAMKNKAK, FOIDKANJMJM JPPGFPLOJCL, byte GMHOEJKBJHE, HLLHEIADGBK BEBAHJONPDO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJFFCDMDIKP(IPEndPoint JBKDKOECJMC, FOIDKANJMJM JPPGFPLOJCL, PIPNONFJCLO PLKJOLKIJMF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HOJLBFGFPIK(EDPEIAPILNK PAPNAMKNKAK, int OCJPFPEIPOO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFOBEKBMDIG(CIFOANAFLKK ICLPGCHCHFB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PLGJAJOLAGC
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPOAPNNKIPI(EDPEIAPILNK PAPNAMKNKAK, object HMJMNEFHLFL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LEJPNLPCBHC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMHLCHJENPB(JMBGJOMDDCP JOKHPGDBFNJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LDCFDBPJLAC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKBJDOJCDCN(EDPEIAPILNK PAPNAMKNKAK, IPEndPoint HFOGNGOFEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DCGCJPIFFJB
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NJPMKDMECKP = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long MJBKDFDCLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte CLODKMGIMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] JLKNBHNCDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly KKFCOHCBGOJ ALHHFFKAKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int GBLKFAEPEEK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x531C840", Offset = "0x531B840", VA = "0x18531C840")]
	private DCGCJPIFFJB(long LCDOBFHDJMH, byte BDOEBKLNHAF, int BOEFBOGINDB, byte[] OCDPGHFKGKM, KKFCOHCBGOJ FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x531C5C0", Offset = "0x531B5C0", VA = "0x18531C5C0")]
	public static int HIFEOJIFAJB(HCADHDIJDEL JOKHPGDBFNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x531C620", Offset = "0x531B620", VA = "0x18531C620")]
	public static DCGCJPIFFJB OPDEJIGIEJE(HCADHDIJDEL JOKHPGDBFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x531C3E0", Offset = "0x531B3E0", VA = "0x18531C3E0")]
	public static HCADHDIJDEL ECOIFFKKCPI(DGLBOHMAMBP FDALCFGKNHJ, SocketAddress DCEAEJACNKJ, long CICAPKBKDKN, int BOEFBOGINDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HIMNFBLPHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long MJBKDFDCLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte CLODKMGIMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int GBLKFAEPEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool BOEGALJFDFP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x532CEF0", Offset = "0x532BEF0", VA = "0x18532CEF0")]
	private HIMNFBLPHAE(long LCDOBFHDJMH, byte BDOEBKLNHAF, int JIICCMHDNNI, bool NEGHCGMIALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x532CDA0", Offset = "0x532BDA0", VA = "0x18532CDA0")]
	public static HIMNFBLPHAE OPDEJIGIEJE(HCADHDIJDEL JOKHPGDBFNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x532CCB0", Offset = "0x532BCB0", VA = "0x18532CCB0")]
	public static HCADHDIJDEL ECOIFFKKCPI(long CICAPKBKDKN, byte KHJNAAGHJDL, int DFACDJBIPHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x532CBB0", Offset = "0x532BBB0", VA = "0x18532CBB0")]
	public static HCADHDIJDEL BBBPHCEBHFJ(EDPEIAPILNK PAPNAMKNKAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct NGBPKNPMCLH : IEquatable<NGBPKNPMCLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long BKIGMMCMCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long FAGCADIKHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long BELFGFICHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int IBLDBOFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int MOLCNBONKJM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x53318D0", Offset = "0x53308D0", VA = "0x1853318D0")]
	public NGBPKNPMCLH(byte[] IKKEONFGJJL, int OBLCDKOIFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x798730", Offset = "0x797730", VA = "0x180798730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5331890", Offset = "0x5330890", VA = "0x185331890", Slot = "4")]
	public bool Equals(NGBPKNPMCLH EJEDDDCGMMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x53317E0", Offset = "0x53307E0", VA = "0x1853317E0", Slot = "0")]
	public override bool Equals(object GPCHHCACPPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DFJGOLFKEIJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] GNPHKCJCKOO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x531C9A0", Offset = "0x531B9A0", VA = "0x18531C9A0")]
	public DFJGOLFKEIJ(byte[] IKKEONFGJJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class DFKECEPBEKH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class JNCJNFOCNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x532E4F0", Offset = "0x532D4F0", VA = "0x18532E4F0")]
		public static extern int LMPLKBPJLBN(IntPtr FMOEIDMGMMF, [In][Out] byte[] KJGPBLBJKDD, [In] int OBLCDKOIFIB, [In] SocketFlags MLCJFHMLLLG, [Out] byte[] IHJJIGBCOML, [In][Out] int EMLGHLINIDH);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x532E410", Offset = "0x532D410", VA = "0x18532E410")]
		internal static extern int CABKDMBOAPB(IntPtr FMOEIDMGMMF, [In] byte[] KJGPBLBJKDD, [In] int OBLCDKOIFIB, [In] SocketFlags MLCJFHMLLLG, [In] byte[] IHJJIGBCOML, [In] int EMLGHLINIDH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class MCFLIFIOJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x53316A0", Offset = "0x53306A0", VA = "0x1853316A0")]
		public static extern int LMPLKBPJLBN(IntPtr FMOEIDMGMMF, [In][Out] byte[] KJGPBLBJKDD, [In] int OBLCDKOIFIB, [In] SocketFlags MLCJFHMLLLG, [Out] byte[] IHJJIGBCOML, [In][Out] int EMLGHLINIDH);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x53315C0", Offset = "0x53305C0", VA = "0x1853315C0")]
		internal static extern int CABKDMBOAPB(IntPtr FMOEIDMGMMF, [In] byte[] KJGPBLBJKDD, [In] int OBLCDKOIFIB, [In] SocketFlags MLCJFHMLLLG, [In] byte[] IHJJIGBCOML, [In] int EMLGHLINIDH);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool EDHOFAJAFEF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool FFCEOGIPCLC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> JHIDGDIFPHO;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x531D1D0", Offset = "0x531C1D0", VA = "0x18531D1D0")]
	static DFKECEPBEKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x531CF30", Offset = "0x531BF30", VA = "0x18531CF30")]
	public static int LIHDPFEPDJG(IntPtr FMOEIDMGMMF, byte[] KJGPBLBJKDD, int OBLCDKOIFIB, byte[] IHJJIGBCOML, int EMLGHLINIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x531CCB0", Offset = "0x531BCB0", VA = "0x18531CCB0")]
	public static int DCAJACIJGNP(IntPtr FMOEIDMGMMF, byte[] KJGPBLBJKDD, int OBLCDKOIFIB, byte[] IHJJIGBCOML, int EMLGHLINIDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x531CE40", Offset = "0x531BE40", VA = "0x18531CE40")]
	public static SocketError EHMABOKJLFA()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x531D090", Offset = "0x531C090", VA = "0x18531D090")]
	public static SocketException PCJJAAOEEIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x531CFE0", Offset = "0x531BFE0", VA = "0x18531CFE0")]
	public static short OGKGEPOAPLL(IPEndPoint JBKDKOECJMC)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FFJHANIBAJD
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OEEPFNOOHKC
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AGEFNMHNMED(IPEndPoint CLNPOMEMDOM, IPEndPoint JBKDKOECJMC, string PDIBILKHEBM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHCGBPCDIBB(IPEndPoint LINMAPEFEOM, FFJHANIBAJD CFGJPNBLNDJ, string PDIBILKHEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class EADFCKEBGDI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct AOEPIFHJLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint CFBJDNJCGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint IJBJDHNONNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string LEONAHFDKDE;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct LLEFGLLDIEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint FFACHMLDIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FFJHANIBAJD AMBPOKEJAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string LEONAHFDKDE;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class BHCOHIFOIDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint CFMHOODGJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LEONAHFDKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BHCOHIFOIDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class KAOCPHHELFA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint CFMHOODGJBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint GKONHDBFMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LEONAHFDKDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x76F1F0", Offset = "0x76E1F0", VA = "0x18076F1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public KAOCPHHELFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class FGOFHFFPHDM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LEONAHFDKDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CPCALAJKKOF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7775F0", Offset = "0x7765F0", VA = "0x1807775F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FGOFHFFPHDM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly DHJHNNJOPGC AEPEGOGGBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<AOEPIFHJLKG> OFCFOOGKNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<LLEFGLLDIEO> PODAKLIHOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly KKFCOHCBGOJ NLGPICLNJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DGLBOHMAMBP CIPDJBIDEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly LJIOADGBDBD PHEKHCBABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private OEEPFNOOHKC IHDOIACAOFB;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int NENJPBIAENB = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool GCHIJEMKNLO;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5326940", Offset = "0x5325940", VA = "0x185326940")]
	internal EADFCKEBGDI(DHJHNNJOPGC MJAAIICELBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5326660", Offset = "0x5325660", VA = "0x185326660")]
	internal void OCKALHNAGKE(IPEndPoint LPPCAGBGKAP, HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x23A9070", Offset = "0x23A8070", VA = "0x1823A9070")]
	private void DNMEFJOKMCD<T>(T JOKHPGDBFNJ, IPEndPoint MNNJBJHGADP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5326330", Offset = "0x5325330", VA = "0x185326330")]
	private void AGEFNMHNMED(BHCOHIFOIDN AHADGGLOOLK, IPEndPoint LPPCAGBGKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x53267C0", Offset = "0x53257C0", VA = "0x1853267C0")]
	private void OFNHKAMLFLJ(KAOCPHHELFA AHADGGLOOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53264C0", Offset = "0x53254C0", VA = "0x1853264C0")]
	private void KEHCAMBOMIF(FGOFHFFPHDM AHADGGLOOLK, IPEndPoint LPPCAGBGKAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum HLLHEIADGBK : byte
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
public static class CEGGMPHLMIO
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] CGDHAAMILEO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int FGGHFCOBBHJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int MFGPICEEBNL;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CHMKAFFNBLN : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x531BA60", Offset = "0x531AA60", VA = "0x18531BA60")]
	public CHMKAFFNBLN(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class EACOMJNOHEE : CHMKAFFNBLN
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x531BA60", Offset = "0x531AA60", VA = "0x18531BA60")]
	public EACOMJNOHEE(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum GKMHHLCPEOF
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
public interface HNEONJKPOID
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEJPLOECLIK(GKMHHLCPEOF JBELPPCMPGD, string CINODLDMGAP, params object[] IEECDEJOFJP);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class LCNNIKNPKDL
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static HNEONJKPOID DBGAEMKMIEB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object DCDMFNGMOFM;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x532F5A0", Offset = "0x532E5A0", VA = "0x18532F5A0")]
	private static void LBENBMAHNJG(GKMHHLCPEOF EPNHNIDEDIA, string CINODLDMGAP, params object[] IEECDEJOFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x532F540", Offset = "0x532E540", VA = "0x18532F540")]
	internal static void HDKPKENEKCN(string CINODLDMGAP, params object[] IEECDEJOFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x532F7D0", Offset = "0x532E7D0", VA = "0x18532F7D0")]
	internal static void OGCAFDLMPBC(string CINODLDMGAP, params object[] IEECDEJOFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x532F4E0", Offset = "0x532E4E0", VA = "0x18532F4E0")]
	internal static void GHAEILJFPED(string CINODLDMGAP, params object[] IEECDEJOFJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum PJAFBNNJKCA
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class FOIDKANJMJM : KKFCOHCBGOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private HCADHDIJDEL BJDONDLHEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly DHJHNNJOPGC AIFHIJDHCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly KNKHLBMINBB LAEEDFHBFJO;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x532BF60", Offset = "0x532AF60", VA = "0x18532BF60")]
	internal FOIDKANJMJM(DHJHNNJOPGC PPJFGCMLNID, KNKHLBMINBB HHKIBIBPCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x532BE70", Offset = "0x532AE70", VA = "0x18532BE70")]
	internal void JFENIKFILFG(HCADHDIJDEL JOKHPGDBFNJ, int ALDLGKLNBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x532BEE0", Offset = "0x532AEE0", VA = "0x18532BEE0")]
	internal void JGOLILNPFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x532BE40", Offset = "0x532AE40", VA = "0x18532BE40")]
	public void CDGAANFLLKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class KNKHLBMINBB
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum GECNEIKFLMM
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
	public KNKHLBMINBB CLAGMKDPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public GECNEIKFLMM AMBPOKEJAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public EDPEIAPILNK IBKDENBLCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint IJBJDHNONNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object BCNJAMNGCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int AFFHHBIHLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError CJIJHIELJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public DEIJFJHEFPH DJAOEJMONAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public CIFOANAFLKK BFCKFDLOHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public HLLHEIADGBK HKAKFMCIOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte FFJIBLFEIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly FOIDKANJMJM AJJDHLEKDPC;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x532F440", Offset = "0x532E440", VA = "0x18532F440")]
	public KNKHLBMINBB(DHJHNNJOPGC PPJFGCMLNID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DHJHNNJOPGC : IEnumerable<EDPEIAPILNK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class LEAGOGMDNAI : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x532F8E0", Offset = "0x532E8E0", VA = "0x18532F8E0", Slot = "4")]
		public bool Equals(IPEndPoint LNKHMLIBJEP, IPEndPoint DLOPBGEOAKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DDA140", Offset = "0x4DD9140", VA = "0x184DDA140", Slot = "5")]
		public int GetHashCode(IPEndPoint GPCHHCACPPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LEAGOGMDNAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct HPEJFOGBIGG : IEnumerator<EDPEIAPILNK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly EDPEIAPILNK JBBFJEDCOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private EDPEIAPILNK BAOBMBMCMFO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public EDPEIAPILNK PADEIDMLAKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x7FFDA0", Offset = "0x7FEDA0", VA = "0x1807FFDA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE2AFC0", Offset = "0xE29FC0", VA = "0x180E2AFC0")]
		public HPEJFOGBIGG(EDPEIAPILNK KLACNNEOMHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x532CF40", Offset = "0x532BF40", VA = "0x18532CF40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x532CF90", Offset = "0x532BF90", VA = "0x18532CF90", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread FMIIIPCBJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool AAGDPLCOCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent BDEIGCMIJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<KNKHLBMINBB> HCJAFCAAHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<KNKHLBMINBB> BHANNFIFPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private KNKHLBMINBB PHDEOGODLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly BCGCGJCHLNN DBMIDIJFFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly PLGJAJOLAGC HNFEPHMEOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly LEJPNLPCBHC CMEDAHDJFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly LDCFDBPJLAC PABFFBPOADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, EDPEIAPILNK> BHLAJCIADIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, CIFOANAFLKK> DADJLKBOPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, DEOLAIGPDJF> OOHEPKNCGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim GKIFGDNGAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private EDPEIAPILNK OEBLPOAHGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int CKHDDALLIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<EDPEIAPILNK> FDPNKNLIFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private EDPEIAPILNK[] ILEAGDIAMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly DMLJFNDNDMF BKLFHCCHMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int DCPEAGKPDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> JHNNAAPLNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte NOOABLPPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object HDJPPMEDGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool JPNBEONGALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool GAPBHIOOIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int DKKGMJEGBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int ECNIHAMBCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int KNEPKPOPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool CLGMMHKNIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool FJMKILHCFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int HDJEEKLPEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int NAKBGKCHDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int GHFIDGDKBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool GCHIJEMKNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool NFHNLJBAHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool HBEGNBOCHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool AECNMPCDJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int JJPFOBGJCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int PLLJCONNAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool GGPKBKIHDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly OCAADAHGMPH GPEGJOBEHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PMIHALOOLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly EADFCKEBGDI KLBGHFFGNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GMNGICMGNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public PJAFBNNJKCA AEHAFOAPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int GDBNNDHHDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool BFEIBEPJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool LJPJCFGMKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool NOGCEPKONGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool AECCPKEJNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private HCADHDIJDEL BGPKNJIEHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int MHHIFKPBDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object EHBDMGODEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int MGNFOOOJFOE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int ELDLBKEDOHJ = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket CNLJAJECFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket JNPBHEOJCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread KAOOLNDCIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread DAOMDBCICIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint FLBKBCPOKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint IKAJPIPFEAL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] JFBHKHFFHDG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] EFCJCNAFLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<NGBPKNPMCLH, IPEndPoint> PJPCKJJBOCG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int JMCJKAHLFOE = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress NNELHLFIJNN;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool MPEAPEDLAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int KBOALGCBLIC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MPIELJMGPCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1219F40", Offset = "0x1218F40", VA = "0x181219F40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1219F50", Offset = "0x1218F50", VA = "0x181219F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HDDEIPODMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x14D7360", Offset = "0x14D6360", VA = "0x1814D7360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x14D6D20", Offset = "0x14D5D20", VA = "0x1814D6D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte IPGCJNOFLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7E9920", Offset = "0x7E8920", VA = "0x1807E9920")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JJCKBJDIHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5322EB0", Offset = "0x5321EB0", VA = "0x185322EB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short ILHFIMGIHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5321320", Offset = "0x5320320", VA = "0x185321320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5325810", Offset = "0x5324810", VA = "0x185325810")]
	public void PIPBFDKMAKH(IPEndPoint OMJGBHNDKIM, byte[] BGNGIHJEFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x53210A0", Offset = "0x53200A0", VA = "0x1853210A0")]
	public void FGDIJKBAEOL(IPEndPoint OMJGBHNDKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5321010", Offset = "0x5320010", VA = "0x185321010")]
	private bool FFBKEEHOGFD(IPEndPoint OMJGBHNDKIM, [Out] EDPEIAPILNK PAPNAMKNKAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5320990", Offset = "0x531F990", VA = "0x185320990")]
	private void EOBKNJPJMDD(EDPEIAPILNK PAPNAMKNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x531FE90", Offset = "0x531EE90", VA = "0x18531FE90")]
	private void CJEHAMEDPCF(EDPEIAPILNK PAPNAMKNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x53235E0", Offset = "0x53225E0", VA = "0x1853235E0")]
	private void JLHJKLHJIDJ(EDPEIAPILNK PAPNAMKNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5325CE0", Offset = "0x5324CE0", VA = "0x185325CE0")]
	public DHJHNNJOPGC(BCGCGJCHLNN NJDADKILNNL, [Optional] DMLJFNDNDMF MKNMMLBPCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5324730", Offset = "0x5323730", VA = "0x185324730")]
	internal void ODEHIEAPOGA(EDPEIAPILNK EIOLPGBOKFA, int OCJPFPEIPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x53211F0", Offset = "0x53201F0", VA = "0x1853211F0")]
	internal void FGHDLNDEDCK(EDPEIAPILNK EIOLPGBOKFA, object HMJMNEFHLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x531FEE0", Offset = "0x531EEE0", VA = "0x18531FEE0")]
	internal void DGNIOECKCFG(EDPEIAPILNK PAPNAMKNKAK, DEIJFJHEFPH GEIKHBJFIME, SocketError PBHPIAGEMKH, HCADHDIJDEL MFCMLHEKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x531FDB0", Offset = "0x531EDB0", VA = "0x18531FDB0")]
	private void CHOKEMNPDNJ(EDPEIAPILNK PAPNAMKNKAK, DEIJFJHEFPH GEIKHBJFIME, SocketError PBHPIAGEMKH, bool OFOIDDLLFEI, byte[] FCLEEDACIMH, int CEJJMMEOKPD, int AGLAJIDEGHD, HCADHDIJDEL MFCMLHEKFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5320C50", Offset = "0x531FC50", VA = "0x185320C50")]
	private void FEOFFINMAAN(KNKHLBMINBB.GECNEIKFLMM CFGJPNBLNDJ, [Optional] EDPEIAPILNK PAPNAMKNKAK, [Optional] IPEndPoint JBKDKOECJMC, SocketError KKBHHFJDIJK = SocketError.Success, int OCJPFPEIPOO = 0, DEIJFJHEFPH KLNAAJKPFML = DEIJFJHEFPH.ConnectionFailed, [Optional] CIFOANAFLKK NPJFGLDCGNB, HLLHEIADGBK BEBAHJONPDO = HLLHEIADGBK.Unreliable, byte GMHOEJKBJHE = 0, [Optional] HCADHDIJDEL HMPNNEOHKMI, [Optional] object HMJMNEFHLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x53201D0", Offset = "0x531F1D0", VA = "0x1853201D0")]
	private void EGGIKKHPHHH(KNKHLBMINBB HHKIBIBPCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5322520", Offset = "0x5321520", VA = "0x185322520")]
	internal void HMICFEBNGJE(KNKHLBMINBB HHKIBIBPCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5324780", Offset = "0x5323780", VA = "0x185324780")]
	private void OGPFEHJLODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x53232C0", Offset = "0x53222C0", VA = "0x1853232C0")]
	private void JGKDCCONNEC(int FNLILDIIAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5323E60", Offset = "0x5322E60", VA = "0x185323E60")]
	internal EDPEIAPILNK LFLPAHPJJAD(CIFOANAFLKK ICLPGCHCHFB, byte[] GGOLNPAGKFP, int CEJJMMEOKPD, int EHBIPHOJPOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5323240", Offset = "0x5322240", VA = "0x185323240")]
	private int JFGOKMLJHEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x531E820", Offset = "0x531D820", VA = "0x18531E820")]
	private void AKCFFGCJNNF(IPEndPoint JBKDKOECJMC, EDPEIAPILNK BAPHKALKJAE, DCGCJPIFFJB GCLLPFDFLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5324AC0", Offset = "0x5323AC0", VA = "0x185324AC0")]
	private void PCFFEMEACEC(HCADHDIJDEL JOKHPGDBFNJ, IPEndPoint JBKDKOECJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5323A70", Offset = "0x5322A70", VA = "0x185323A70")]
	internal void KNAAFKCAOMJ(HCADHDIJDEL JOKHPGDBFNJ, HLLHEIADGBK NPDIMKCGEJL, byte GMHOEJKBJHE, int ALDLGKLNBIA, EDPEIAPILNK EIOLPGBOKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x53226A0", Offset = "0x53216A0", VA = "0x1853226A0")]
	public bool IMBOKILCADD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53226B0", Offset = "0x53216B0", VA = "0x1853226B0")]
	public bool IMBOKILCADD(IPAddress NBCCBDFJOHL, IPAddress DGALCBMOECN, int KJJGHOHKLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5322620", Offset = "0x5321620", VA = "0x185322620")]
	public bool IMBOKILCADD(int KJJGHOHKLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x531E680", Offset = "0x531D680", VA = "0x18531E680")]
	public void AFNCGNKJOLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5321720", Offset = "0x5320720", VA = "0x185321720")]
	public EDPEIAPILNK GAGPKDCPBPF(string IKKEONFGJJL, int KJJGHOHKLDG, string BGNGIHJEFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5321800", Offset = "0x5320800", VA = "0x185321800")]
	public EDPEIAPILNK GAGPKDCPBPF(string IKKEONFGJJL, int KJJGHOHKLDG, DGLBOHMAMBP HDIOMENJKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5321350", Offset = "0x5320350", VA = "0x185321350")]
	public EDPEIAPILNK GAGPKDCPBPF(IPEndPoint MNNJBJHGADP, DGLBOHMAMBP HDIOMENJKOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x531EC80", Offset = "0x531DC80", VA = "0x18531EC80")]
	public void ANKILPBGOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x531EC90", Offset = "0x531DC90", VA = "0x18531EC90")]
	public void ANKILPBGOAL(bool MJFOBAFJLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x53200D0", Offset = "0x531F0D0", VA = "0x1853200D0")]
	public void EAGLKLJBBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x531FFB0", Offset = "0x531EFB0", VA = "0x18531FFB0")]
	public void EAGLKLJBBFN(byte[] FCLEEDACIMH, int CEJJMMEOKPD, int AGLAJIDEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x531FD00", Offset = "0x531ED00", VA = "0x18531FD00")]
	public void CHOKEMNPDNJ(EDPEIAPILNK PAPNAMKNKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x531FC40", Offset = "0x531EC40", VA = "0x18531FC40")]
	public void CHOKEMNPDNJ(EDPEIAPILNK PAPNAMKNKAK, byte[] FCLEEDACIMH, int CEJJMMEOKPD, int AGLAJIDEGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5325B00", Offset = "0x5324B00", VA = "0x185325B00", Slot = "4")]
	private IEnumerator<EDPEIAPILNK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5325B90", Offset = "0x5324B90", VA = "0x185325B90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x53238A0", Offset = "0x53228A0", VA = "0x1853238A0")]
	private HCADHDIJDEL KCMFMNGDEDO(DGJBFEIBDFB BHNFFMEOAFJ, int LHAIIFMNPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5323990", Offset = "0x5322990", VA = "0x185323990")]
	private HCADHDIJDEL KCMFMNGDEDO(DGJBFEIBDFB BHNFFMEOAFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5324480", Offset = "0x5323480", VA = "0x185324480")]
	internal HCADHDIJDEL LJLPINJJBIJ(int LHAIIFMNPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5321E10", Offset = "0x5320E10", VA = "0x185321E10")]
	internal void GEOOJCEEHKL(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5325C20", Offset = "0x5324C20", VA = "0x185325C20")]
	static DHJHNNJOPGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1219F40", Offset = "0x1218F40", VA = "0x181219F40")]
	private bool JFINHHLMGII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5324640", Offset = "0x5323640", VA = "0x185324640")]
	private void MKOAKOEDNLL(IPEndPoint KGFDPDIACKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5321240", Offset = "0x5320240", VA = "0x185321240")]
	private void FKKMLGMACED(IPEndPoint KGFDPDIACKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x53218E0", Offset = "0x53208E0", VA = "0x1853218E0")]
	private bool GEJPGOJKJEO(SocketException GDBKEDNPKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53258B0", Offset = "0x53248B0", VA = "0x1853258B0")]
	private void PJDBIIADIJH(Socket MJAAIICELBP, EndPoint DBNKAIABOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5321A80", Offset = "0x5320A80", VA = "0x185321A80")]
	private void GENHIPFIOLF(object LDGNDDODOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5322ED0", Offset = "0x5321ED0", VA = "0x185322ED0")]
	private void JDMLAOEOAOF(object LDGNDDODOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x53226D0", Offset = "0x53216D0", VA = "0x1853226D0")]
	public bool IMBOKILCADD(IPAddress NBCCBDFJOHL, IPAddress DGALCBMOECN, int KJJGHOHKLDG, bool CABKLFEFBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5321F80", Offset = "0x5320F80", VA = "0x185321F80")]
	private bool HMIAGMIBLLM(Socket MJAAIICELBP, IPEndPoint KGFDPDIACKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5323840", Offset = "0x5322840", VA = "0x185323840")]
	internal int JMGLOAGHKOM(HCADHDIJDEL JOKHPGDBFNJ, IPEndPoint JBKDKOECJMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x531FC00", Offset = "0x531EC00", VA = "0x18531FC00")]
	internal int BJLMIHBPPMH(HCADHDIJDEL JOKHPGDBFNJ, IPEndPoint JBKDKOECJMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x531EFB0", Offset = "0x531DFB0", VA = "0x18531EFB0")]
	internal int BJLMIHBPPMH(byte[] NCBOINMNCHO, int CEJJMMEOKPD, int EHBIPHOJPOK, IPEndPoint JBKDKOECJMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5323D30", Offset = "0x5322D30", VA = "0x185323D30")]
	internal void KPGAICFJOMM(bool BLDJCMCFKFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum DGJBFEIBDFB : byte
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
internal sealed class HCADHDIJDEL
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int JFHNFELCOIA;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] GPFOPBBGIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] LAMADKMALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int FJPPAJJFFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object BCNJAMNGCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public HCADHDIJDEL CLAGMKDPLCC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DGJBFEIBDFB BNEBFPCAGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x532C130", Offset = "0x532B130", VA = "0x18532C130")]
		get
		{
			return default(DGJBFEIBDFB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x532C610", Offset = "0x532B610", VA = "0x18532C610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte CLODKMGIMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x532C420", Offset = "0x532B420", VA = "0x18532C420")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x532C320", Offset = "0x532B320", VA = "0x18532C320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MHABCHIKFGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x532C650", Offset = "0x532B650", VA = "0x18532C650")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x532C360", Offset = "0x532B360", VA = "0x18532C360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GFIIKKABPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x532C160", Offset = "0x532B160", VA = "0x18532C160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte CNEIELOPELK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x532C450", Offset = "0x532B450", VA = "0x18532C450")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x532C1F0", Offset = "0x532B1F0", VA = "0x18532C1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort GHNMNEDLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x532C6F0", Offset = "0x532B6F0", VA = "0x18532C6F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x532C3E0", Offset = "0x532B3E0", VA = "0x18532C3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort ALGEGAGJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x532C480", Offset = "0x532B480", VA = "0x18532C480")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x532C3A0", Offset = "0x532B3A0", VA = "0x18532C3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort DIFBAJAFNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x532C190", Offset = "0x532B190", VA = "0x18532C190")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x532C6B0", Offset = "0x532B6B0", VA = "0x18532C6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x532C750", Offset = "0x532B750", VA = "0x18532C750")]
	static HCADHDIJDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x532C4E0", Offset = "0x532B4E0", VA = "0x18532C4E0")]
	public void KEIGFFCAAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x532CA30", Offset = "0x532BA30", VA = "0x18532CA30")]
	public HCADHDIJDEL(int LHAIIFMNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x532CAA0", Offset = "0x532BAA0", VA = "0x18532CAA0")]
	public HCADHDIJDEL(DGJBFEIBDFB BHNFFMEOAFJ, int LHAIIFMNPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x532C220", Offset = "0x532B220", VA = "0x18532C220")]
	public static int EIOGDGBJCKG(DGJBFEIBDFB BHNFFMEOAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x532C290", Offset = "0x532B290", VA = "0x18532C290")]
	public int EIOGDGBJCKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x532C510", Offset = "0x532B510", VA = "0x18532C510")]
	public bool LHGBBCHPJKL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum HGFFLDALNCA : byte
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
internal enum OCMGHCMJMHM
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
internal enum PAFHFCNCDCL
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum MKOMEDPJGNK
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class EDPEIAPILNK
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class HCJDCIAPKIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public HCADHDIJDEL[] INCDJCMLDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int CNIFGELEBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int CPMMDGEIICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte CNEIELOPELK;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public HCJDCIAPKIC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void DGJJDPCFIKI(ulong DJLHHABFLOG, int MAFKOPCCIMI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int MONNNICLKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int KCKBHMHDHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int OMBMPFOIEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double HHEDPOOLMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int KFMNKKGGIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int GMAGHGCJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch GOPCMGJODJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int EFEGEHAJBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long DDJIAMEFMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object OJMJMOEPMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal EDPEIAPILNK LBAKIAPKFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal EDPEIAPILNK PBONPOHDLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<HCADHDIJDEL> KCGINPGCFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<KCJMNKHNBPG> EDKCOBOGEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly KCJMNKHNBPG[] HPJHOKFIEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int NCGLIOKMGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int GICFNGCMAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool HMDLEKKKLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int JDLODDEMDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int GJJCIKPPFCO;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int BIFCJGDNOMD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int GFGLFNLIJKD = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object EAHHEBBABDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int AMBLEDGACFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, HCJDCIAPKIC> GMCHBMAJNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> PPNIPLJKCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly HCADHDIJDEL EMOMBHHCDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int EHDKOPEPAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int DEFKDBLEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint LFLHALGKHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int PMNEOHKLGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int JOJEIKIIIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long MKEHOKMMILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte FNNBMHPBGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private HGFFLDALNCA GFNBOMALLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private HCADHDIJDEL GFCMOJDHJKL;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int FOEBCNCJHHI = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int BOGCKIMDKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HCADHDIJDEL OHDJLAEIDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HCADHDIJDEL DHIDILLLKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly HCADHDIJDEL LPBLFMCBLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly HCADHDIJDEL LBPOMHMHHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly DHJHNNJOPGC COEIAMDEFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int GMIBMNELHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object MAKGAPHJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly OCAADAHGMPH GPEGJOBEHAJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte DDGEFCOOLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7E9910", Offset = "0x7E8910", VA = "0x1807E9910")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x53277C0", Offset = "0x53267C0", VA = "0x1853277C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint KBPHHNNBGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x90A310", Offset = "0x909310", VA = "0x18090A310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HGFFLDALNCA MDOCFFEHCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x103C990", Offset = "0x103B990", VA = "0x18103C990")]
		get
		{
			return default(HGFFLDALNCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long NCIGCODJILC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x90A320", Offset = "0x909320", VA = "0x18090A320")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CFAHICAKINE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x14D7370", Offset = "0x14D6370", VA = "0x1814D7370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x14D6890", Offset = "0x14D5890", VA = "0x1814D6890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int ILJMBLJBEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x532A400", Offset = "0x5329400", VA = "0x18532A400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CKCBKKNPDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78E470", Offset = "0x78D470", VA = "0x18078E470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double BHAKCCJOEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x16AF760", Offset = "0x16AE760", VA = "0x1816AF760")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DGJJDPCFIKI GALHBCOHCAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5329100", Offset = "0x5328100", VA = "0x185329100")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x532A350", Offset = "0x5329350", VA = "0x18532A350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x532A770", Offset = "0x5329770", VA = "0x18532A770")]
	internal EDPEIAPILNK(DHJHNNJOPGC GJANJMKPKAP, IPEndPoint JBKDKOECJMC, int LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5327B80", Offset = "0x5326B80", VA = "0x185327B80")]
	internal void EIEGABCEKMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5329D50", Offset = "0x5328D50", VA = "0x185329D50")]
	internal void IJEKFLNPCJE(IPEndPoint JDCMAOPGJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x532A550", Offset = "0x5329550", VA = "0x18532A550")]
	internal void PDPNCDOJOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5328250", Offset = "0x5327250", VA = "0x185328250")]
	private void FHKGBONHKPC(int FHDKHBMHHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5328320", Offset = "0x5327320", VA = "0x185328320")]
	private void FOAECPHIPOL(int PPNCLJIHMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5329360", Offset = "0x5328360", VA = "0x185329360")]
	private KCJMNKHNBPG HNAAACCFJPF(byte CPCIEIKHPPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x532A5E0", Offset = "0x53295E0", VA = "0x18532A5E0")]
	internal EDPEIAPILNK(DHJHNNJOPGC GJANJMKPKAP, IPEndPoint JBKDKOECJMC, int LPCEACMGEAL, byte KHJNAAGHJDL, DGLBOHMAMBP FDALCFGKNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x532ABD0", Offset = "0x5329BD0", VA = "0x18532ABD0")]
	internal EDPEIAPILNK(DHJHNNJOPGC GJANJMKPKAP, CIFOANAFLKK ICLPGCHCHFB, int LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5326EF0", Offset = "0x5325EF0", VA = "0x185326EF0")]
	internal void AGJICCBGKKB(DCGCJPIFFJB PHLOIEAMDDA, byte[] FCLEEDACIMH, int CEJJMMEOKPD, int EHBIPHOJPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x532A2D0", Offset = "0x53292D0", VA = "0x18532A2D0")]
	internal bool LJHGMPHNNOK(HIMNFBLPHAE JOKHPGDBFNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5327790", Offset = "0x5326790", VA = "0x185327790")]
	public void DNMEFJOKMCD(byte[] FCLEEDACIMH, int CEJJMMEOKPD, int EHBIPHOJPOK, HLLHEIADGBK DGHDFHCPCLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5327240", Offset = "0x5326240", VA = "0x185327240")]
	private void BMMIPCHCLCF(byte[] FCLEEDACIMH, int CEJJMMEOKPD, int EHBIPHOJPOK, byte GMHOEJKBJHE, HLLHEIADGBK BEBAHJONPDO, object HMJMNEFHLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5329050", Offset = "0x5328050", VA = "0x185329050")]
	public void HBBHEEPBGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x532A410", Offset = "0x5329410", VA = "0x18532A410")]
	internal PAFHFCNCDCL ODDJJICLIAE(HCADHDIJDEL JOKHPGDBFNJ)
	{
		return default(PAFHFCNCDCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x532A4F0", Offset = "0x53294F0", VA = "0x18532A4F0")]
	internal void PCKFHJLGEPG(KCJMNKHNBPG LIEOKHIIFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5327870", Offset = "0x5326870", VA = "0x185327870")]
	internal MKOMEDPJGNK EHHGNPCBLBG(byte[] FCLEEDACIMH, int CEJJMMEOKPD, int EHBIPHOJPOK, bool OFOIDDLLFEI)
	{
		return default(MKOMEDPJGNK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5327200", Offset = "0x5326200", VA = "0x185327200")]
	private void AKMKKGAIKPC(int FPMNDFIAJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5328350", Offset = "0x5327350", VA = "0x185328350")]
	internal void GKONFMPBMBD(HLLHEIADGBK NPDIMKCGEJL, HCADHDIJDEL KLACNNEOMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5329D80", Offset = "0x5328D80", VA = "0x185329D80")]
	private void LABPPCLFPNC(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5328CE0", Offset = "0x5327CE0", VA = "0x185328CE0")]
	private void GLNGJCOMLEL(int BLKKNAAPMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5327040", Offset = "0x5326040", VA = "0x185327040")]
	internal OCMGHCMJMHM AKCFFGCJNNF(DCGCJPIFFJB GCLLPFDFLHN)
	{
		return default(OCMGHCMJMHM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5327BA0", Offset = "0x5326BA0", VA = "0x185327BA0")]
	internal void ELNNPJPODLA(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5326F40", Offset = "0x5325F40", VA = "0x185326F40")]
	private void AHGGCJLDFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53291B0", Offset = "0x53281B0", VA = "0x1853291B0")]
	internal void HJIFLGNNPAB(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5329510", Offset = "0x5328510", VA = "0x185329510")]
	internal void HOEJNKLEAPP(int BLKKNAAPMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5329A90", Offset = "0x5328A90", VA = "0x185329A90")]
	internal void IDDDHNEMPLA(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class OCAADAHGMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NJCCPMDLDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long AMENBGNCEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long MFPAIHCMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long DENALKCPDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long KBCJMJFMGEL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long OCCHDOIDAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5331A00", Offset = "0x5330A00", VA = "0x185331A00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long JGDKAFIFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53319E0", Offset = "0x53309E0", VA = "0x1853319E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long FGKEBLFHFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5331A50", Offset = "0x5330A50", VA = "0x185331A50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MLMFJGPCJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5331A40", Offset = "0x5330A40", VA = "0x185331A40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long NDPNIIEEJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x53319F0", Offset = "0x53309F0", VA = "0x1853319F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long OEDKENJDMDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5331A70", Offset = "0x5330A70", VA = "0x185331A70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5331A20", Offset = "0x5330A20", VA = "0x185331A20")]
	public void IBPBPKMIGLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x53319C0", Offset = "0x53309C0", VA = "0x1853319C0")]
	public void ANLDLHAECOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5331A30", Offset = "0x5330A30", VA = "0x185331A30")]
	public void JMDDCJCIIHA(long MFCJDHNENOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5331A10", Offset = "0x5330A10", VA = "0x185331A10")]
	public void HEAHJGIIOMA(long NLBELEKKHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x53319D0", Offset = "0x53309D0", VA = "0x1853319D0")]
	public void BIPNKOIGKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5331A60", Offset = "0x5330A60", VA = "0x185331A60")]
	public void NDOKEMCMHDN(long BGPMGIMBLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5331AC0", Offset = "0x5330AC0", VA = "0x185331AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public OCAADAHGMPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BOONDANGOMO
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> HLGFBGHJKEA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x531B6A0", Offset = "0x531A6A0", VA = "0x18531B6A0")]
	public static IPEndPoint IEJAMPCGBBG(string MDJGIAEMMFH, int KJJGHOHKLDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x531B4A0", Offset = "0x531A4A0", VA = "0x18531B4A0")]
	public static IPAddress CPGHPOMDJCN(string MDJGIAEMMFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x531B410", Offset = "0x531A410", VA = "0x18531B410")]
	public static IPAddress CPGHPOMDJCN(string MDJGIAEMMFH, AddressFamily ONGHJFHKNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x531B670", Offset = "0x531A670", VA = "0x18531B670")]
	internal static int DDFGCMKJDJK(int CDOOMMABEBM, int NDHJFMDGDMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x22C5460", Offset = "0x22C4460", VA = "0x1822C5460")]
	internal static T[] AOEMAKJOCFI<T>(int AGLAJIDEGHD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class EGHPHMKHEOM : KCJMNKHNBPG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct GJNMHDFCAAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private HCADHDIJDEL BJDONDLHEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long CCGKPAKOCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool LPLNEPLCCHH;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x532C090", Offset = "0x532B090", VA = "0x18532C090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x532BFB0", Offset = "0x532AFB0", VA = "0x18532BFB0")]
		public void CAFOKCFCPFO(HCADHDIJDEL JOKHPGDBFNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x532BFD0", Offset = "0x532AFD0", VA = "0x18532BFD0")]
		public bool NEADFJOJADF(long NHFJMJEEFNF, EDPEIAPILNK PAPNAMKNKAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x532C040", Offset = "0x532B040", VA = "0x18532C040")]
		public bool PMEKKAMOFIE(EDPEIAPILNK PAPNAMKNKAK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly HCADHDIJDEL OAHKGBGFPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly GJNMHDFCAAA[] AMDFDDHMDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly HCADHDIJDEL[] OBMIBEFMDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] CDBKOLFCFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int FLBDLLMJNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int KAHNMMPOHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int GMOMOBADCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int EIKOCDNFLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool PEDLFIHIGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly HLLHEIADGBK KODGDCFPJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool JBDOLBBGJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int ENELPGDHDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte GPFKMABHCCA;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x532BC70", Offset = "0x532AC70", VA = "0x18532BC70")]
	public EGHPHMKHEOM(EDPEIAPILNK PAPNAMKNKAK, bool CBDDJDLJLGF, byte LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x532ADB0", Offset = "0x5329DB0", VA = "0x18532ADB0")]
	private void CPNLLDAFJGG(HCADHDIJDEL JOKHPGDBFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x532B7C0", Offset = "0x532A7C0", VA = "0x18532B7C0", Slot = "4")]
	protected override bool JMAAGOKLJDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x532B160", Offset = "0x532A160", VA = "0x18532B160", Slot = "5")]
	public override bool ELNNPJPODLA(HCADHDIJDEL JOKHPGDBFNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CLFFEADFAHM : KCJMNKHNBPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int AJBPIBJEOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort KAHNMMPOHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool KIFCEPIOEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private HCADHDIJDEL JKNMOLMKKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly HCADHDIJDEL INNLEHFNLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool GEBPEMADBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte GPFKMABHCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long EILCLLNLIEN;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x531C320", Offset = "0x531B320", VA = "0x18531C320")]
	public CLFFEADFAHM(EDPEIAPILNK PAPNAMKNKAK, bool IOMNLLDGHPL, byte LPCEACMGEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x531BEB0", Offset = "0x531AEB0", VA = "0x18531BEB0", Slot = "4")]
	protected override bool JMAAGOKLJDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x531BBD0", Offset = "0x531ABD0", VA = "0x18531BBD0", Slot = "5")]
	public override bool ELNNPJPODLA(HCADHDIJDEL JOKHPGDBFNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class ECAOLMCDHPI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct CCNLBKDJEFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong MPNKDCBECIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double GHBCLNONGLE;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct CFNMKNKEIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int CHIAPDNEMCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float DBCNMOPKNOJ;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x531B2C0", Offset = "0x531A2C0", VA = "0x18531B2C0")]
	private static void LEIBIJBAOII(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, ulong FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5326DE0", Offset = "0x5325DE0", VA = "0x185326DE0")]
	private static void LEIBIJBAOII(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, int FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5326DA0", Offset = "0x5325DA0", VA = "0x185326DA0")]
	public static void LEIBIJBAOII(byte[] DOAIHCCMJDP, int ODJLNMBFCPC, short FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5326ED0", Offset = "0x5325ED0", VA = "0x185326ED0")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, double APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5326E50", Offset = "0x5325E50", VA = "0x185326E50")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5326DA0", Offset = "0x5325DA0", VA = "0x185326DA0")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, short APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5326DA0", Offset = "0x5325DA0", VA = "0x185326DA0")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, ushort APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5326DE0", Offset = "0x5325DE0", VA = "0x185326DE0")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, int APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5326DE0", Offset = "0x5325DE0", VA = "0x185326DE0")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, uint APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5326D90", Offset = "0x5325D90", VA = "0x185326D90")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, long APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5326D90", Offset = "0x5325D90", VA = "0x185326D90")]
	public static void BPBOIBPNPGF(byte[] BKCOILCKNDC, int HOLHNBPNHFM, ulong APPJEOKOGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class KKFCOHCBGOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] BPHHKLDCICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int CDJDJDLDJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int OGEKPONGEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int OJLNPPKNGFF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] LAMADKMALCN
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int KNKAGODAMAN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8620A0", Offset = "0x8610A0", VA = "0x1808620A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int EDHBCJACEHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x532EB60", Offset = "0x532DB60", VA = "0x18532EB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool JJCOCKALLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BE9C20", Offset = "0x1BE8C20", VA = "0x181BE9C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DIOMKPLDIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x532F3D0", Offset = "0x532E3D0", VA = "0x18532F3D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x532EEF0", Offset = "0x532DEF0", VA = "0x18532EEF0")]
	public void JFENIKFILFG(byte[] ONDDMEPBDDI, int ODJLNMBFCPC, int BKFHDJGFADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
	public KKFCOHCBGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x532F3E0", Offset = "0x532E3E0", VA = "0x18532F3E0")]
	public KKFCOHCBGOJ(byte[] ONDDMEPBDDI, int ODJLNMBFCPC, int BKFHDJGFADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x532EE20", Offset = "0x532DE20", VA = "0x18532EE20")]
	public IPEndPoint JBPOKHDDIFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x532F020", Offset = "0x532E020", VA = "0x18532F020")]
	public byte LJDKPMACCDP()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x532F020", Offset = "0x532E020", VA = "0x18532F020")]
	public sbyte OINEKANHHCP()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x25555B0", Offset = "0x25545B0", VA = "0x1825555B0")]
	public T[] EKFAODEOAAL<T>(ushort LHAIIFMNPNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x532F390", Offset = "0x532E390", VA = "0x18532F390")]
	public bool[] PMPKPHGENNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x532F0A0", Offset = "0x532E0A0", VA = "0x18532F0A0")]
	public ushort[] MLHLIGFEJEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x532E830", Offset = "0x532D830", VA = "0x18532E830")]
	public short[] ANAPOEPJGFK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x532F250", Offset = "0x532E250", VA = "0x18532F250")]
	public int[] OPBIBFPDGHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x532EF70", Offset = "0x532DF70", VA = "0x18532EF70")]
	public uint[] LBBLIAJHCEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x532EF30", Offset = "0x532DF30", VA = "0x18532EF30")]
	public float[] JHHMHJHEPCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x532F060", Offset = "0x532E060", VA = "0x18532F060")]
	public double[] LMOGODEKCBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x532F210", Offset = "0x532E210", VA = "0x18532F210")]
	public long[] ONEEHOAPBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x532EA70", Offset = "0x532DA70", VA = "0x18532EA70")]
	public ulong[] DGBCMGJHMKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x532F0E0", Offset = "0x532E0E0", VA = "0x18532F0E0")]
	public string[] OFENOKKAFNH(int PEFDKNDDDGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x532EB20", Offset = "0x532DB20", VA = "0x18532EB20")]
	public bool FDOPMGNFPLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x532EDB0", Offset = "0x532DDB0", VA = "0x18532EDB0")]
	public char IOOKEFGBIIN()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x532EDB0", Offset = "0x532DDB0", VA = "0x18532EDB0")]
	public ushort LMBFJNAFEDG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x532E8E0", Offset = "0x532D8E0", VA = "0x18532E8E0")]
	public short CCBEIAMGDDF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x532EAB0", Offset = "0x532DAB0", VA = "0x18532EAB0")]
	public long EEFJMNDJNPB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x532E950", Offset = "0x532D950", VA = "0x18532E950")]
	public ulong CCEAAPJFMLA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x532F290", Offset = "0x532E290", VA = "0x18532F290")]
	public int PABHOLFNKIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x532EA00", Offset = "0x532DA00", VA = "0x18532EA00")]
	public uint DDGFFAFBFOP()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x532EFB0", Offset = "0x532DFB0", VA = "0x18532EFB0")]
	public float LBICFNDMMFE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x532F300", Offset = "0x532E300", VA = "0x18532F300")]
	public double PDBKBPFCFBI()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x532EB70", Offset = "0x532DB70", VA = "0x18532EB70")]
	public string GPNINBPLEBO(int AAIHABNEPDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x532E870", Offset = "0x532D870", VA = "0x18532E870")]
	public ArraySegment<byte> AOFGPFHEJNJ(int AGLAJIDEGHD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x532E9C0", Offset = "0x532D9C0", VA = "0x18532E9C0")]
	public sbyte[] CIHPJAMDKCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x532E7F0", Offset = "0x532D7F0", VA = "0x18532E7F0")]
	public byte[] ABMMMMDAGMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x532F370", Offset = "0x532E370", VA = "0x18532F370")]
	public void PMEKKAMOFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DGLBOHMAMBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] BPHHKLDCICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int CDJDJDLDJME;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int IIJFOHMOMOE = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool JDENCPLMDAE;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding JHPNJGFFNPO;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int MKIGDJBPFLG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] HBJPAFENAEA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] ALHHFFKAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EPGHPPHAJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x775DA0", Offset = "0x774DA0", VA = "0x180775DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x531E600", Offset = "0x531D600", VA = "0x18531E600")]
	public DGLBOHMAMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x531E560", Offset = "0x531D560", VA = "0x18531E560")]
	public DGLBOHMAMBP(bool JCBLLGJDCAF, int FJNCEIECJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x531D910", Offset = "0x531C910", VA = "0x18531D910")]
	public static DGLBOHMAMBP BFCLCMJAIBO(string APPJEOKOGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x531E430", Offset = "0x531D430", VA = "0x18531E430")]
	public void JPNGOJKDDAA(int MKLIJLKCMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C63520", Offset = "0x1C62520", VA = "0x181C63520")]
	public void OFPJBAGGFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x531E050", Offset = "0x531D050", VA = "0x18531E050")]
	public void JONJFLPFNAF(float APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x531DEA0", Offset = "0x531CEA0", VA = "0x18531DEA0")]
	public void JONJFLPFNAF(double APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x531DDD0", Offset = "0x531CDD0", VA = "0x18531DDD0")]
	public void JONJFLPFNAF(long APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x531DDD0", Offset = "0x531CDD0", VA = "0x18531DDD0")]
	public void JONJFLPFNAF(ulong APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x531DF50", Offset = "0x531CF50", VA = "0x18531DF50")]
	public void JONJFLPFNAF(int APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x531DF50", Offset = "0x531CF50", VA = "0x18531DF50")]
	public void JONJFLPFNAF(uint APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x531DFE0", Offset = "0x531CFE0", VA = "0x18531DFE0")]
	public void JONJFLPFNAF(char APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x531DFE0", Offset = "0x531CFE0", VA = "0x18531DFE0")]
	public void JONJFLPFNAF(ushort APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x531DFE0", Offset = "0x531CFE0", VA = "0x18531DFE0")]
	public void JONJFLPFNAF(short APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x531DEF0", Offset = "0x531CEF0", VA = "0x18531DEF0")]
	public void JONJFLPFNAF(sbyte APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x531DEF0", Offset = "0x531CEF0", VA = "0x18531DEF0")]
	public void JONJFLPFNAF(byte APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x531DE20", Offset = "0x531CE20", VA = "0x18531DE20")]
	public void JONJFLPFNAF(byte[] FCLEEDACIMH, int ODJLNMBFCPC, int EHBIPHOJPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x531D830", Offset = "0x531C830", VA = "0x18531D830")]
	public void IDFCHJCAPEA(sbyte[] FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x531D830", Offset = "0x531C830", VA = "0x18531D830")]
	public void AONHAGEOBCC(byte[] FCLEEDACIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x531E300", Offset = "0x531D300", VA = "0x18531E300")]
	public void JONJFLPFNAF(bool APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x531DB40", Offset = "0x531CB40", VA = "0x18531DB40")]
	public void CCKIFLGBILH(Array HILNKJGGIFO, int IEDOCMKPIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x531DC20", Offset = "0x531CC20", VA = "0x18531DC20")]
	public void CCKIFLGBILH(float[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x531DA60", Offset = "0x531CA60", VA = "0x18531DA60")]
	public void CCKIFLGBILH(double[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x531DA60", Offset = "0x531CA60", VA = "0x18531DA60")]
	public void CCKIFLGBILH(long[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x531DA60", Offset = "0x531CA60", VA = "0x18531DA60")]
	public void CCKIFLGBILH(ulong[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x531DC20", Offset = "0x531CC20", VA = "0x18531DC20")]
	public void CCKIFLGBILH(int[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x531DC20", Offset = "0x531CC20", VA = "0x18531DC20")]
	public void CCKIFLGBILH(uint[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x531D980", Offset = "0x531C980", VA = "0x18531D980")]
	public void CCKIFLGBILH(ushort[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x531D980", Offset = "0x531C980", VA = "0x18531D980")]
	public void CCKIFLGBILH(short[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x531D830", Offset = "0x531C830", VA = "0x18531D830")]
	public void CCKIFLGBILH(bool[] APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x531DD00", Offset = "0x531CD00", VA = "0x18531DD00")]
	public void CCKIFLGBILH(string[] APPJEOKOGAK, int CJADBGKEIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x531E360", Offset = "0x531D360", VA = "0x18531E360")]
	public void JONJFLPFNAF(IPEndPoint OMJGBHNDKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x531DE90", Offset = "0x531CE90", VA = "0x18531DE90")]
	public void JONJFLPFNAF(string APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x531E0F0", Offset = "0x531D0F0", VA = "0x18531E0F0")]
	public void JONJFLPFNAF(string APPJEOKOGAK, int AAIHABNEPDM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LJIOADGBDBD
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class ADBBENMIGPA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong GMIBMNELHMC;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x34DCCC0", Offset = "0x34DBCC0", VA = "0x1834DCCC0")]
		static ADBBENMIGPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void OCHNJKKJDMO(KKFCOHCBGOJ JPPGFPLOJCL, object HMJMNEFHLFL);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class IDPFEELFCJO<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public LJIOADGBDBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public IDPFEELFCJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x372BE00", Offset = "0x372AE00", VA = "0x18372BE00")]
		internal void JNHAPHKMCBL(KKFCOHCBGOJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class GOOMNPGLEJA<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public LJIOADGBDBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GOOMNPGLEJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x35A7980", Offset = "0x35A6980", VA = "0x1835A7980")]
		internal void JNHAPHKMCBL(KKFCOHCBGOJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly JELAPEINPIB PFMKGGCCFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, OCHNJKKJDMO> DBBEBECPMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DGLBOHMAMBP EDGABHCMBKD;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x532FB50", Offset = "0x532EB50", VA = "0x18532FB50")]
	public LJIOADGBDBD(int PEFDKNDDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22A94E0", Offset = "0x22A84E0", VA = "0x1822A94E0", Slot = "4")]
	protected virtual ulong GJPBIFBBODC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x532F950", Offset = "0x532E950", VA = "0x18532F950", Slot = "5")]
	protected virtual OCHNJKKJDMO AANIPFFPJAI(KKFCOHCBGOJ JPPGFPLOJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x255E370", Offset = "0x255D370", VA = "0x18255E370", Slot = "6")]
	protected virtual void BFEHGBMLEHD<T>(DGLBOHMAMBP BBENPAOCMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x532FA80", Offset = "0x532EA80", VA = "0x18532FA80")]
	public void GLHPBJBJGHI(KKFCOHCBGOJ JPPGFPLOJCL, object HMJMNEFHLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x255E3E0", Offset = "0x255D3E0", VA = "0x18255E3E0")]
	public void KOLMFBJFGAN<T>(DGLBOHMAMBP BBENPAOCMIF, T JOKHPGDBFNJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x532FB00", Offset = "0x532EB00", VA = "0x18532FB00")]
	public void OCPFIIGLJLO(KKFCOHCBGOJ JPPGFPLOJCL, object HMJMNEFHLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x255E5F0", Offset = "0x255D5F0", VA = "0x18255E5F0")]
	public void LKJFJCLOICK<T>(Action<T> PLBADDBACAB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x255E470", Offset = "0x255D470", VA = "0x18255E470")]
	public void LKJFJCLOICK<T, TUserData>(Action<T, TUserData> PLBADDBACAB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class JKAJIEPKLJL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x531BA60", Offset = "0x531AA60", VA = "0x18531BA60")]
	public JKAJIEPKLJL(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class ADOCICKGNHG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x531B3B0", Offset = "0x531A3B0", VA = "0x18531B3B0")]
	public ADOCICKGNHG(string NCBOINMNCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JELAPEINPIB
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum CGIKLOPOPAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class AOOHBBPCCGE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CGIKLOPOPAG AMBPOKEJAOP;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x366D660", Offset = "0x366C660", VA = "0x18366D660", Slot = "4")]
		public virtual void CAFOKCFCPFO(MethodInfo PGKIPNBNCPG, MethodInfo FHFFOBCJMIG, CGIKLOPOPAG CFGJPNBLNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HHDCEBENHPM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void MBMHIDPPFLE(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		protected AOOHBBPCCGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class IJNDDGKPIGI<TClass, TProperty> : AOOHBBPCCGE<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> GDPGBKKMFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> HELNPGPOBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> KOEBOLLEIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> AAGGJKFJNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> LLPKOEFKDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> HONDKEBEGFG;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x374ECF0", Offset = "0x374DCF0", VA = "0x18374ECF0", Slot = "7")]
		public override void HGHCJJMNCBM(TClass ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x374D780", Offset = "0x374C780", VA = "0x18374D780", Slot = "8")]
		public override void DGOPNHNKHNK(TClass ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x374EEB0", Offset = "0x374DEB0", VA = "0x18374EEB0", Slot = "9")]
		public override void HHDCEBENHPM(TClass ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x374FAF0", Offset = "0x374EAF0", VA = "0x18374FAF0", Slot = "10")]
		public override void MBMHIDPPFLE(TClass ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3748BC0", Offset = "0x3747BC0", VA = "0x183748BC0")]
		protected TProperty[] BGKBAPCKCMJ(TClass ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x374E2E0", Offset = "0x374D2E0", VA = "0x18374E2E0")]
		protected TProperty[] DKGFFCNHHLE(TClass ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x374CC00", Offset = "0x374BC00", VA = "0x18374CC00", Slot = "4")]
		public override void CAFOKCFCPFO(MethodInfo PGKIPNBNCPG, MethodInfo FHFFOBCJMIG, CGIKLOPOPAG CFGJPNBLNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x362CD60", Offset = "0x362BD60", VA = "0x18362CD60")]
		protected IJNDDGKPIGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class OHPMIOODIIG<TClass, TProperty> : IJNDDGKPIGI<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OPFDFAMKCIM(KKFCOHCBGOJ MGOBBEHMAHK, [Out] TProperty FBHGAIPHCFN);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IIEBBFEDEBM(DGLBOHMAMBP JBMDKHMBEKD, TProperty FBHGAIPHCFN);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3E013F0", Offset = "0x3E003F0", VA = "0x183E013F0", Slot = "5")]
		public override void PMDIMJEPDIC(TClass ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3E01310", Offset = "0x3E00310", VA = "0x183E01310", Slot = "6")]
		public override void KOLMFBJFGAN(TClass ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E01270", Offset = "0x3E00270", VA = "0x183E01270", Slot = "7")]
		public override void HGHCJJMNCBM(TClass ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E01090", Offset = "0x3E00090", VA = "0x183E01090", Slot = "8")]
		public override void DGOPNHNKHNK(TClass ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x375A710", Offset = "0x3759710", VA = "0x18375A710")]
		protected OHPMIOODIIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GMOBHGKPLBJ<T> : IJNDDGKPIGI<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3596530", Offset = "0x3595530", VA = "0x183596530", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x35964D0", Offset = "0x35954D0", VA = "0x1835964D0", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3596460", Offset = "0x3595460", VA = "0x183596460", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3596400", Offset = "0x3595400", VA = "0x183596400", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public GMOBHGKPLBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OLAEKAKGHDF<T> : IJNDDGKPIGI<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3E05490", Offset = "0x3E04490", VA = "0x183E05490", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x35964D0", Offset = "0x35954D0", VA = "0x1835964D0", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3E05420", Offset = "0x3E04420", VA = "0x183E05420", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3596400", Offset = "0x3595400", VA = "0x183596400", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public OLAEKAKGHDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class MGHLFDDHJHH<T> : IJNDDGKPIGI<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3C82410", Offset = "0x3C81410", VA = "0x183C82410", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C823B0", Offset = "0x3C813B0", VA = "0x183C823B0", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C82340", Offset = "0x3C81340", VA = "0x183C82340", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C822E0", Offset = "0x3C812E0", VA = "0x183C822E0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public MGHLFDDHJHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class MINBDOEBEDL<T> : IJNDDGKPIGI<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C97790", Offset = "0x3C96790", VA = "0x183C97790", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C823B0", Offset = "0x3C813B0", VA = "0x183C823B0", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C97720", Offset = "0x3C96720", VA = "0x183C97720", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C822E0", Offset = "0x3C812E0", VA = "0x183C822E0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public MINBDOEBEDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JBHLOEIOOFL<T> : IJNDDGKPIGI<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x38C9BA0", Offset = "0x38C8BA0", VA = "0x1838C9BA0", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38C9B40", Offset = "0x38C8B40", VA = "0x1838C9B40", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x38C9AD0", Offset = "0x38C8AD0", VA = "0x1838C9AD0", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x30F22D0", Offset = "0x30F12D0", VA = "0x1830F22D0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public JBHLOEIOOFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class JCBMEJGKHDB<T> : IJNDDGKPIGI<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x38CE1B0", Offset = "0x38CD1B0", VA = "0x1838CE1B0", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38C9B40", Offset = "0x38C8B40", VA = "0x1838C9B40", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x38CE140", Offset = "0x38CD140", VA = "0x1838CE140", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x30F22D0", Offset = "0x30F12D0", VA = "0x1830F22D0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public JCBMEJGKHDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class FLFPCMIMNFN<T> : IJNDDGKPIGI<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3468FF0", Offset = "0x3467FF0", VA = "0x183468FF0", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3468F90", Offset = "0x3467F90", VA = "0x183468F90", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3468F20", Offset = "0x3467F20", VA = "0x183468F20", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3468EC0", Offset = "0x3467EC0", VA = "0x183468EC0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public FLFPCMIMNFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class ALKFBGBCICD<T> : IJNDDGKPIGI<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3468FF0", Offset = "0x3467FF0", VA = "0x183468FF0", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3468F90", Offset = "0x3467F90", VA = "0x183468F90", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x365CC00", Offset = "0x365BC00", VA = "0x18365CC00", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3468EC0", Offset = "0x3467EC0", VA = "0x183468EC0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public ALKFBGBCICD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class DNBIKAIPJCH<T> : IJNDDGKPIGI<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4DD0170", Offset = "0x4DCF170", VA = "0x184DD0170", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4DD0110", Offset = "0x4DCF110", VA = "0x184DD0110", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4DD00A0", Offset = "0x4DCF0A0", VA = "0x184DD00A0", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3596400", Offset = "0x3595400", VA = "0x183596400", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public DNBIKAIPJCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class EDKEGDIOJFJ<T> : IJNDDGKPIGI<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x30F2400", Offset = "0x30F1400", VA = "0x1830F2400", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x30F23A0", Offset = "0x30F13A0", VA = "0x1830F23A0", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x30F2330", Offset = "0x30F1330", VA = "0x1830F2330", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x30F22D0", Offset = "0x30F12D0", VA = "0x1830F22D0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public EDKEGDIOJFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BGOFJJENCEJ<T> : IJNDDGKPIGI<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x455BD90", Offset = "0x455AD90", VA = "0x18455BD90", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x455BD30", Offset = "0x455AD30", VA = "0x18455BD30", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x455BCC0", Offset = "0x455ACC0", VA = "0x18455BCC0", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3468EC0", Offset = "0x3467EC0", VA = "0x183468EC0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x30F2470", Offset = "0x30F1470", VA = "0x1830F2470")]
		public BGOFJJENCEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class ALIGALGJIBF<T> : OHPMIOODIIG<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x365C440", Offset = "0x365B440", VA = "0x18365C440", Slot = "12")]
		protected override void IIEBBFEDEBM(DGLBOHMAMBP JBMDKHMBEKD, char FBHGAIPHCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x365C470", Offset = "0x365B470", VA = "0x18365C470", Slot = "11")]
		protected override void OPFDFAMKCIM(KKFCOHCBGOJ MGOBBEHMAHK, [Out] char FBHGAIPHCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x34D97B0", Offset = "0x34D87B0", VA = "0x1834D97B0")]
		public ALIGALGJIBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class MJCICPAKBFN<T> : OHPMIOODIIG<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C978E0", Offset = "0x3C968E0", VA = "0x183C978E0", Slot = "12")]
		protected override void IIEBBFEDEBM(DGLBOHMAMBP JBMDKHMBEKD, IPEndPoint FBHGAIPHCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C97910", Offset = "0x3C96910", VA = "0x183C97910", Slot = "11")]
		protected override void OPFDFAMKCIM(KKFCOHCBGOJ MGOBBEHMAHK, [Out] IPEndPoint FBHGAIPHCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x34D97B0", Offset = "0x34D87B0", VA = "0x1834D97B0")]
		public MJCICPAKBFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class MLKLIKEFJGI<T> : IJNDDGKPIGI<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int LEHKJOGCPAL;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CBABC0", Offset = "0x3CB9BC0", VA = "0x183CBABC0")]
		public MLKLIKEFJGI(int AAIHABNEPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CBAB50", Offset = "0x3CB9B50", VA = "0x183CBAB50", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3CBAAE0", Offset = "0x3CB9AE0", VA = "0x183CBAAE0", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3CBAA70", Offset = "0x3CB9A70", VA = "0x183CBAA70", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3CBAA00", Offset = "0x3CB9A00", VA = "0x183CBAA00", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class MBJOOEEPDDG<T> : AOOHBBPCCGE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo BNEBFPCAGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type DPBGKOCKNMP;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C597D0", Offset = "0x3C587D0", VA = "0x183C597D0")]
		public MBJOOEEPDDG(PropertyInfo BHNFFMEOAFJ, Type INCFKNJMOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C59710", Offset = "0x3C58710", VA = "0x183C59710", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C59600", Offset = "0x3C58600", VA = "0x183C59600", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C59540", Offset = "0x3C58540", VA = "0x183C59540", Slot = "7")]
		public override void HGHCJJMNCBM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C594E0", Offset = "0x3C584E0", VA = "0x183C594E0", Slot = "8")]
		public override void DGOPNHNKHNK(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C595A0", Offset = "0x3C585A0", VA = "0x183C595A0", Slot = "9")]
		public override void HHDCEBENHPM(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C596B0", Offset = "0x3C586B0", VA = "0x183C596B0", Slot = "10")]
		public override void MBMHIDPPFLE(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class HNFLFMIHLCO<T> : MBJOOEEPDDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x35786D0", Offset = "0x35776D0", VA = "0x1835786D0")]
		public HNFLFMIHLCO(PropertyInfo BHNFFMEOAFJ, Type INCFKNJMOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3699240", Offset = "0x3698240", VA = "0x183699240", Slot = "5")]
		public override void PMDIMJEPDIC(T ICBDGKECFJP, KKFCOHCBGOJ MGOBBEHMAHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3699190", Offset = "0x3698190", VA = "0x183699190", Slot = "6")]
		public override void KOLMFBJFGAN(T ICBDGKECFJP, DGLBOHMAMBP JBMDKHMBEKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class KNELGEOEBGN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static KNELGEOEBGN<T> NKFKDADGOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly AOOHBBPCCGE<T>[] EHGAMHDONOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int PLLAINBCDLI;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x39D7260", Offset = "0x39D6260", VA = "0x1839D7260")]
		public KNELGEOEBGN(List<AOOHBBPCCGE<T>> GGCHFFJPINI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x39D7100", Offset = "0x39D6100", VA = "0x1839D7100")]
		public void KOLMFBJFGAN(T GPCHHCACPPJ, DGLBOHMAMBP BBENPAOCMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x39D71B0", Offset = "0x39D61B0", VA = "0x1839D71B0")]
		public void PMDIMJEPDIC(T GPCHHCACPPJ, KKFCOHCBGOJ JPPGFPLOJCL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class INKEIGANFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract AOOHBBPCCGE<T> GJNMDDLIIAA<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private DGLBOHMAMBP DHAOJPAJPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int CPCOOHNBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, INKEIGANFLL> PPGKKKAGJHN;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x532CFE0", Offset = "0x532BFE0", VA = "0x18532CFE0")]
	public JELAPEINPIB(int PEFDKNDDDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2524920", Offset = "0x2523920", VA = "0x182524920")]
	private KNELGEOEBGN<T> EJKILPFNFEP<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22C3AE0", Offset = "0x22C2AE0", VA = "0x1822C3AE0")]
	public void NOIKFHNFAKL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x25248A0", Offset = "0x25238A0", VA = "0x1825248A0")]
	public bool AJBPOCIDFHA<T>(KKFCOHCBGOJ JPPGFPLOJCL, T MNNJBJHGADP) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2525810", Offset = "0x2524810", VA = "0x182525810")]
	public void KJONJHMMAMK<T>(DGLBOHMAMBP BBENPAOCMIF, T GPCHHCACPPJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JMBGJOMDDCP
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime EOIABFDILKO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] JPMPDNEFEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LMJJLHHPEND HKGKLOCNJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x532D770", Offset = "0x532C770", VA = "0x18532D770")]
		get
		{
			return default(LMJJLHHPEND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int OAANNOFDEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x532D650", Offset = "0x532C650", VA = "0x18532D650")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x532D730", Offset = "0x532C730", VA = "0x18532D730")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HIMGFDDHGMK CGFMLGHKMOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x532D080", Offset = "0x532C080", VA = "0x18532D080")]
		get
		{
			return default(HIMGFDDHGMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x532D7A0", Offset = "0x532C7A0", VA = "0x18532D7A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int LMHMMNLDLCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x532DA40", Offset = "0x532CA40", VA = "0x18532DA40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint LNMKKFBCIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x532D680", Offset = "0x532C680", VA = "0x18532D680")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? LJDLOFHOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x532D700", Offset = "0x532C700", VA = "0x18532D700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? BFBOEIEDDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x532DFB0", Offset = "0x532CFB0", VA = "0x18532DFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? OAHCMCLLAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x532DC70", Offset = "0x532CC70", VA = "0x18532DC70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x532D2B0", Offset = "0x532C2B0", VA = "0x18532D2B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? EJLIEACMJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9C95B0", Offset = "0x9C85B0", VA = "0x1809C95B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8035F0", Offset = "0x8025F0", VA = "0x1808035F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x532E0F0", Offset = "0x532D0F0", VA = "0x18532E0F0")]
	public JMBGJOMDDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x532E040", Offset = "0x532D040", VA = "0x18532E040")]
	internal JMBGJOMDDCP(byte[] BKCOILCKNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x532DD60", Offset = "0x532CD60", VA = "0x18532DD60")]
	public static JMBGJOMDDCP MJNHKNEPJKE(byte[] BKCOILCKNDC, DateTime EGAPGMOLBBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x532D0B0", Offset = "0x532C0B0", VA = "0x18532D0B0")]
	internal void BHLHJFPCAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x532D480", Offset = "0x532C480", VA = "0x18532D480")]
	private void BKNJEAGHKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x532DA70", Offset = "0x532CA70", VA = "0x18532DA70")]
	private DateTime? IPLMEMKCHOI(int ODJLNMBFCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x532D870", Offset = "0x532C870", VA = "0x18532D870")]
	private void GKHHELHCCJE(int ODJLNMBFCPC, DateTime? APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x532DE80", Offset = "0x532CE80", VA = "0x18532DE80")]
	private ulong MLLKONIMCCD(int ODJLNMBFCPC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x532DCA0", Offset = "0x532CCA0", VA = "0x18532DCA0")]
	private void LGEFLBJKLCN(int ODJLNMBFCPC, ulong APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x532D7E0", Offset = "0x532C7E0", VA = "0x18532D7E0")]
	private uint GGLHMFGIAOF(int ODJLNMBFCPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x520B1E0", Offset = "0x520A1E0", VA = "0x18520B1E0")]
	private static uint PBMBFPLIADE(uint LNKHMLIBJEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x532DF50", Offset = "0x532CF50", VA = "0x18532DF50")]
	private static ulong PBMBFPLIADE(ulong LNKHMLIBJEP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum LMJJLHHPEND
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
public enum HIMGFDDHGMK
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class DEOLAIGPDJF
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int HEPJEDHFKNG = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int CNNMDLEGDPA = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int FDCBFMHJDEA = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint CDNPINNNGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int IPLNOFDOCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int MOJJGCJECKN;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NLMAGKLANCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x531C990", Offset = "0x531B990", VA = "0x18531C990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x531C8B0", Offset = "0x531B8B0", VA = "0x18531C8B0")]
	public bool DNMEFJOKMCD(Socket MJAAIICELBP, int ICEIPOOCKJL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class DMLJFNDNDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int JJCKBJDIHAG;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x777270", Offset = "0x776270", VA = "0x180777270")]
	protected DMLJFNDNDMF(int LDHFGKOMDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DIIIKFCIBIB(IPEndPoint OMJGBHNDKIM, byte[] FCLEEDACIMH, int ODJLNMBFCPC, int EHBIPHOJPOK);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AJOJFEFFAIL(IPEndPoint OMJGBHNDKIM, byte[] FCLEEDACIMH, int ODJLNMBFCPC, int EHBIPHOJPOK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PLODMAGPFMA : DMLJFNDNDMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider NLGNBCJJPJF;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator EAPCHOFNPJF;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5332960", Offset = "0x5331960", VA = "0x185332960")]
	public PLODMAGPFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x53326C0", Offset = "0x53316C0", VA = "0x1853326C0")]
	public void LOCEGNIABAA(IPEndPoint OMJGBHNDKIM, byte[] BGNGIHJEFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5332550", Offset = "0x5331550", VA = "0x185332550")]
	public void HHAEOKALDKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5332630", Offset = "0x5331630", VA = "0x185332630")]
	private byte[] LBLEDFCAPMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5332190", Offset = "0x5331190", VA = "0x185332190", Slot = "4")]
	public override void DIIIKFCIBIB(IPEndPoint OMJGBHNDKIM, byte[] FCLEEDACIMH, int ODJLNMBFCPC, int EHBIPHOJPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5331DF0", Offset = "0x5330DF0", VA = "0x185331DF0", Slot = "5")]
	public override void AJOJFEFFAIL(IPEndPoint OMJGBHNDKIM, byte[] FCLEEDACIMH, int ODJLNMBFCPC, int EHBIPHOJPOK)
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
