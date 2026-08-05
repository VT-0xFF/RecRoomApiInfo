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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, IHIMDLCJLJM
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KJJOKBIPHKP
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
		private NetworkManager LNNCHIMDMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, JODPKGALIPK> MDIPIDDMOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KGFKNENJKED GKDFLMLBJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] GBJOLINIODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KJJOKBIPHKP GENCLIEICNN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong CDOFBOLBKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852CA0", VA = "0x1808542A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool PLJODFONKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5CFDDB0", Offset = "0x5CFC7B0", VA = "0x185CFDDB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD310", Offset = "0x5CFBD10", VA = "0x185CFD310")]
		public void RecRoom_SetEncryptionInfo(ulong EJGFKLFDHGB, byte[] NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD2F0", Offset = "0x5CFBCF0", VA = "0x185CFD2F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD1C0", Offset = "0x5CFBBC0", VA = "0x185CFD1C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDCB0", Offset = "0x5CFC6B0", VA = "0x185CFDCB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD4B0", Offset = "0x5CFBEB0", VA = "0x185CFD4B0", Slot = "6")]
		public override void Send(ulong AKMNNFAFMJG, ArraySegment<byte> LINJEFIAFHO, NetworkDelivery AGHHDBDMFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD2B0", Offset = "0x5CFBCB0", VA = "0x185CFD2B0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong AKMNNFAFMJG, [Out] ArraySegment<byte> MIJPDJDOIDB, [Out] float CEHNGMBNDDJ)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD7A0", Offset = "0x5CFC1A0", VA = "0x185CFD7A0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDBD0", Offset = "0x5CFC5D0", VA = "0x185CFDBD0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC8C0", Offset = "0x5CFB2C0", VA = "0x185CFC8C0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong AKMNNFAFMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC770", Offset = "0x5CFB170", VA = "0x185CFC770", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCD10", Offset = "0x5CFB710", VA = "0x185CFCD10", Slot = "12")]
		public override ulong GetCurrentRtt(ulong AKMNNFAFMJG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD730", Offset = "0x5CFC130", VA = "0x185CFD730", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCEC0", Offset = "0x5CFB8C0", VA = "0x185CFCEC0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LNNCHIMDMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCA30", Offset = "0x5CFB430", VA = "0x185CFCA30")]
		private ICCCONHPJEP FEPKDBMIKFI(NetworkDelivery NCMHJNKFAGH)
		{
			return default(ICCCONHPJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC6B0", Offset = "0x5CFB0B0", VA = "0x185CFC6B0", Slot = "15")]
		private void DCAFEBGCOHA(JODPKGALIPK GFGLGJAIHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD080", Offset = "0x5CFBA80", VA = "0x185CFD080", Slot = "16")]
		private void NHKGEJAMJFL(JODPKGALIPK GFGLGJAIHDL, ALFHCMJKFDA LOJHBBEJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "17")]
		private void FMJCKHAILMP(IPEndPoint DFOCJDNDFGL, SocketError NCMCEHAHNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCB00", Offset = "0x5CFB500", VA = "0x185CFCB00", Slot = "18")]
		private void GBIEAAHIPBA(JODPKGALIPK GFGLGJAIHDL, MIPIFLBDLJI ELOKBGPKALP, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCDB0", Offset = "0x5CFB7B0", VA = "0x185CFCDB0")]
		private void IOHKDODEHAL(int ECGAAJFODGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "19")]
		private void CDFBPLBHCCM(IPEndPoint EPJJEHDAAFG, MIPIFLBDLJI ELOKBGPKALP, DKCILBKABMM HHFINDLGBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "20")]
		private void BPMGKMEBDHK(JODPKGALIPK GFGLGJAIHDL, int DDJOLKKHIGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC630", Offset = "0x5CFB030", VA = "0x185CFC630", Slot = "21")]
		private void AOPHNAJBJNP(JKBDFEOFJML GPCNCGBOPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCE90", Offset = "0x5CFB890", VA = "0x185CFCE90")]
		private ulong IOJHDMHKFIJ(JODPKGALIPK GFGLGJAIHDL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC690", Offset = "0x5CFB090", VA = "0x185CFC690")]
		private static int BDFMOIOIABH(float IOCCJIJEELD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDCD0", Offset = "0x5CFC6D0", VA = "0x185CFDCD0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class FGMMJKMMGFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly JODPKGALIPK JHJOAHFGKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<BEEFEPJHLGP> MJFAMIIOHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int GHGCEIPJKJO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CED4E0", Offset = "0x5CEBEE0", VA = "0x185CED4E0")]
	protected FGMMJKMMGFF(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CED3C0", Offset = "0x5CEBDC0", VA = "0x185CED3C0")]
	public void BLEEADHCKKC(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CED420", Offset = "0x5CEBE20", VA = "0x185CED420")]
	protected void KJNKPCOLHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CED4A0", Offset = "0x5CEBEA0", VA = "0x185CED4A0")]
	public bool OEPCKHAHEAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool MKJGJDGPJJL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GAHEDLGEJFB(BEEFEPJHLGP DNPPEENABEA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KEMJBKPPDAA
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
public class JKBDFEOFJML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KGFKNENJKED HMKGIDBFEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int MONKOMICDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal DFAKOGKLBAD HDBCMIMHOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint FMKKKNNFNIB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KEMJBKPPDAA IKAHOBFPKCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87A9F0", Offset = "0x8793F0", VA = "0x18087A9F0")]
		[CompilerGenerated]
		get
		{
			return default(KEMJBKPPDAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC8B00", Offset = "0xAC7500", VA = "0x180AC8B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF710", Offset = "0x5CEE110", VA = "0x185CEF710")]
	internal void FLAPIDCACNO(DFAKOGKLBAD PKDGMAJNDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF6E0", Offset = "0x5CEE0E0", VA = "0x185CEF6E0")]
	private bool FGFDNDNBDFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF7D0", Offset = "0x5CEE1D0", VA = "0x185CEF7D0")]
	internal JKBDFEOFJML(IPEndPoint EPJJEHDAAFG, DFAKOGKLBAD HKFGBJHGHIP, KGFKNENJKED BLIJFMHBBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF770", Offset = "0x5CEE170", VA = "0x185CEF770")]
	public JODPKGALIPK LDGIMNEBPHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum DKCILBKABMM
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OFGOOMNBBBM
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
public struct ALFHCMJKFDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OFGOOMNBBBM CCLAAIKBFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError KAKKFFCPGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MIPIFLBDLJI FLGAGDNKKGK;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IHIMDLCJLJM
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLCFAKIAPOG(JODPKGALIPK GFGLGJAIHDL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAMLBAONAIN(JODPKGALIPK GFGLGJAIHDL, ALFHCMJKFDA LOJHBBEJFPF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOLLLIKPBAI(IPEndPoint DFOCJDNDFGL, SocketError NCMCEHAHNIP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHONKDHIMHN(JODPKGALIPK GFGLGJAIHDL, MIPIFLBDLJI ELOKBGPKALP, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOOHGMHEMOM(IPEndPoint EPJJEHDAAFG, MIPIFLBDLJI ELOKBGPKALP, DKCILBKABMM HHFINDLGBJC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KMHPHGPNGHN(JODPKGALIPK GFGLGJAIHDL, int DDJOLKKHIGA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OBFLBOPEEDG(JKBDFEOFJML GPCNCGBOPJG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IMNJKBLKKLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DELDKEFCBCK(JODPKGALIPK GFGLGJAIHDL, object BCIFNCCEIDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DNFLKDGNKCB
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCFFCKIOHPN(FNCNBOPEEEO DNPPEENABEA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MJHEIIECOPI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOELFPGKLDA(JODPKGALIPK GFGLGJAIHDL, IPEndPoint MPCKEAICOFL);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class DFAKOGKLBAD
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int KIBAOCBHDFD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long AKBPCDPHIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte IGNBHIMKOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] PCBKJIEEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly GFNMLBNLGLI CPPCAMCFLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int AOKMODDCFFN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAAE0", Offset = "0x5CE94E0", VA = "0x185CEAAE0")]
	private DFAKOGKLBAD(long AMBBGLIDMEH, byte BLFENLCKHKK, int DIHIHJFDGDD, byte[] FFFHNCFFBEK, GFNMLBNLGLI LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA680", Offset = "0x5CE9080", VA = "0x185CEA680")]
	public static int DCILAMDHFJM(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA6E0", Offset = "0x5CE90E0", VA = "0x185CEA6E0")]
	public static DFAKOGKLBAD KEJAOAAMFCL(BEEFEPJHLGP DNPPEENABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA900", Offset = "0x5CE9300", VA = "0x185CEA900")]
	public static BEEFEPJHLGP LNJNOCFJFHC(PLNCDKJFIPB CHKCCGJEIHN, SocketAddress AFLFHINDHAF, long PAOGCAAHNPJ, int DIHIHJFDGDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class ODEAAAOAHHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long AKBPCDPHIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte IGNBHIMKOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int AOKMODDCFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool EDMAPABMAOC;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF040", Offset = "0x5CFDA40", VA = "0x185CFF040")]
	private ODEAAAOAHHA(long AMBBGLIDMEH, byte BLFENLCKHKK, int HEHDMPAEALN, bool DGCCKHFOCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEE00", Offset = "0x5CFD800", VA = "0x185CFEE00")]
	public static ODEAAAOAHHA KEJAOAAMFCL(BEEFEPJHLGP DNPPEENABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEF50", Offset = "0x5CFD950", VA = "0x185CFEF50")]
	public static BEEFEPJHLGP LNJNOCFJFHC(long PAOGCAAHNPJ, byte AGBOJBDOOKK, int GOPAENHEEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFED00", Offset = "0x5CFD700", VA = "0x185CFED00")]
	public static BEEFEPJHLGP GPNIHICEPAK(JODPKGALIPK GFGLGJAIHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NLNEOMGIBKD
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface KNABJOPABBO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBFBKLGFMIG(IPEndPoint FHMEGJGBNLG, IPEndPoint EPJJEHDAAFG, string EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CMDFADEINAC(IPEndPoint JECKNHMMHJI, NLNEOMGIBKD NCMHJNKFAGH, string EOCJCEFCOOA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class MJBCJKFPNMH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct EOFJBPMAIBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint IDFDBCPNJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint FMKKKNNFNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string JDBBABFONDC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DDFBBKIMKNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint NHAFOJOFBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NLNEOMGIBKD EPCABOEGHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string JDBBABFONDC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class KHEMMIJEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint LEDKNLPKCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string JDBBABFONDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KHEMMIJEOLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class HAJGKMHCNJI
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint LEDKNLPKCJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint NGHIDBPOFNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string JDBBABFONDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8512A0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public HAJGKMHCNJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KPHCLDABFIK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JDBBABFONDC
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x851AF0", VA = "0x1808530F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BJGKOCMEFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E7A0", VA = "0x18091FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x8536E0", VA = "0x180854CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public KPHCLDABFIK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KGFKNENJKED MNMJFBALDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<EOFJBPMAIBB> JBPHLAGICEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<DDFBBKIMKNL> HCIALOCCNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly GFNMLBNLGLI JCIPKEBFNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PLNCDKJFIPB MLAOLBKCMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KAHBNCLFEMA NGGEBMOKCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private KNABJOPABBO HDFONPAIAPP;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int BOJFJCOBPOG = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool EFMCGKDNEAP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE630", Offset = "0x5CFD030", VA = "0x185CFE630")]
	internal MJBCJKFPNMH(KGFKNENJKED PBBKIEJLJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE4D0", Offset = "0x5CFCED0", VA = "0x185CFE4D0")]
	internal void OMPBMALEMKA(IPEndPoint AGOKLOHOEDJ, BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C29990", Offset = "0x2C28390", VA = "0x182C29990")]
	private void FKIHHFKAOGH<T>(T DNPPEENABEA, IPEndPoint CGKANMHMCOJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE1E0", Offset = "0x5CFCBE0", VA = "0x185CFE1E0")]
	private void LBFBKLGFMIG(KHEMMIJEOLH ODMOGNJJMHL, IPEndPoint AGOKLOHOEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE370", Offset = "0x5CFCD70", VA = "0x185CFE370")]
	private void OEAJOGHGJJJ(HAJGKMHCNJI ODMOGNJJMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE040", Offset = "0x5CFCA40", VA = "0x185CFE040")]
	private void ELJJJEFCDAK(KPHCLDABFIK ODMOGNJJMHL, IPEndPoint AGOKLOHOEDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum ICCCONHPJEP : byte
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
public enum OFFMEBAOCCD : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HNLOKCFJMOK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] CBEIPCMHOII;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int ADDOKPPICLG;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int EMJPOEKMHLH;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EHDFDIFLKDE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB6A0", Offset = "0x5CEA0A0", VA = "0x185CEB6A0")]
	public EHDFDIFLKDE(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MHLLKJCNCBF : EHDFDIFLKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB6A0", Offset = "0x5CEA0A0", VA = "0x185CEB6A0")]
	public MHLLKJCNCBF(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum NMCOAHPDIHB
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
public interface PFFLLKHAIJD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGCFCOFKGPD(NMCOAHPDIHB GHDPCBMOFPP, string GMHAEBALLKB, params object[] FJCOFFFFCFE);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class BKDOLGKLEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static PFFLLKHAIJD HBKHNMFHGBI;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object PDLACBHFJCL;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA2E0", Offset = "0x5CE8CE0", VA = "0x185CEA2E0")]
	private static void KCHINLBHLIN(NMCOAHPDIHB KBFHINCLMII, string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA510", Offset = "0x5CE8F10", VA = "0x185CEA510")]
	internal static void LGCKHHDFDCN(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA570", Offset = "0x5CE8F70", VA = "0x185CEA570")]
	internal static void OCBMDGHCJCO(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA280", Offset = "0x5CE8C80", VA = "0x185CEA280")]
	internal static void CAPPJGANHKM(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum NOCKMHOHBAI
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MIPIFLBDLJI : GFNMLBNLGLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private BEEFEPJHLGP LBGHFJFHADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly KGFKNENJKED FGOEDJELLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly NAIBNGPKFLD DAMKHACNBNP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDFF0", Offset = "0x5CFC9F0", VA = "0x185CFDFF0")]
	internal MIPIFLBDLJI(KGFKNENJKED GOHDOKCJOFP, NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDF80", Offset = "0x5CFC980", VA = "0x185CFDF80")]
	internal void NNGFPFGNFPO(BEEFEPJHLGP DNPPEENABEA, int MGDPGEEAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDED0", Offset = "0x5CFC8D0", VA = "0x185CFDED0")]
	internal void FADOBPNELEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDF50", Offset = "0x5CFC950", VA = "0x185CFDF50")]
	public void HJPDEGLGIPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class NAIBNGPKFLD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum DIJHJJBCNEG
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
	public NAIBNGPKFLD NCDLNIPPHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public DIJHJJBCNEG EPCABOEGHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public JODPKGALIPK JHJOAHFGKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint FMKKKNNFNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object GBFFNIOHIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int CHJHANKOOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError CAEPJNKNMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public OFGOOMNBBBM LBKMJAGDPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public JKBDFEOFJML HFINAMHGNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public ICCCONHPJEP JEILNILLMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte PACNFKLHHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly MIPIFLBDLJI LKFKPMJCDDB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEC60", Offset = "0x5CFD660", VA = "0x185CFEC60")]
	public NAIBNGPKFLD(KGFKNENJKED GOHDOKCJOFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KGFKNENJKED : IEnumerable<JODPKGALIPK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class PILODDEKFOK : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CFF090", Offset = "0x5CFDA90", VA = "0x185CFF090", Slot = "4")]
		public bool Equals(IPEndPoint IPBJLCONKPC, IPEndPoint FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57BD740", Offset = "0x57BC140", VA = "0x1857BD740", Slot = "5")]
		public int GetHashCode(IPEndPoint MEAFIMADMKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public PILODDEKFOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct FMMEPGDICPF : IEnumerator<JODPKGALIPK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly JODPKGALIPK PMAPPOKMEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private JODPKGALIPK ODCCCDCFPHG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JODPKGALIPK EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2B00", VA = "0x1808C4100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2B00", VA = "0x1808C4100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10D95D0", Offset = "0x10D7FD0", VA = "0x1810D95D0")]
		public FMMEPGDICPF(JODPKGALIPK MPPCPDMLBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CED580", Offset = "0x5CEBF80", VA = "0x185CED580", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CED5D0", Offset = "0x5CEBFD0", VA = "0x185CED5D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread ECOBHLEKPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool LHDNNKIHANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent NKEPEKOAHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<NAIBNGPKFLD> MPAOPEHKHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<NAIBNGPKFLD> KMDHCEDIDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private NAIBNGPKFLD EEHEHADKFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly IHIMDLCJLJM DGAICCLAHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly IMNJKBLKKLJ FCINCKDIMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DNFLKDGNKCB JEAJGKFNLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MJHEIIECOPI MKEKNHFIPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, JODPKGALIPK> NEJKONIICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, JKBDFEOFJML> JIBKMAHICEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, FBDJODOBBJP> CJHBMCEFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim NANHCHMAGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JODPKGALIPK JOJCFLEEMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GJDFBBBIILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<JODPKGALIPK> DKPAPGBMFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JODPKGALIPK[] DMIHOBCEILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly AGIHDFJJONF KMGFMPNIPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int EKAKADMPNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> LBHOJPGJMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte HFLMDPGHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object FJFDBCBHNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool EEPBAMCDHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool NOBACJHLNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int BAGBBOFDJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MPHFPBBBMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int KFOJFNLLOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int JLGCCMBMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool JEFNFCOCCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool JBOMGPKNNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GLFKNPICJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DGGHEMKDAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MLBMHJOFBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool EFMCGKDNEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool NJDBEGHGMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CCNNAFPHGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool OFELFNJDHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int ANNAFKJJMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int ENGBELNOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool FDIAMLFNHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly FAALMMEMLLA PHPFODDLFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool CGKJGAFANIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly MJBCJKFPNMH ODNNCHDOBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool CLBJAGIFINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public NOCKMHOHBAI JEHDCPEOCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int CEECCKBCHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool DJHLLAGPIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool BFANMDGOKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool BMNOIAHNNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool AHNFCHDALAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private BEEFEPJHLGP IOIAJBHENIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int OBJHJBKMEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object EMDJINOOAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private BEEFEPJHLGP KDDJPPBNIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int OOOLIKJIAIG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int ICIBCAOABPF = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int HGCDAMDKAII = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OMAJCMIBHDD APPBPLAJDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private OMAJCMIBHDD MNKPCFNGACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread DLIJCGGJNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread EBMHIMBAMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint GAAKOENKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint KFEFNLEIDDA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] LFNBKHEIMKC;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] GFECDOBPDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NAAAKGNFLHP, IPEndPoint> BCJMHKPEOHH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress JDHFDMOLOEN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool MFECCIGFFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int OAJPCMNEBIC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LELHMFOMGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBD3060", Offset = "0xBD1A60", VA = "0x180BD3060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC825B0", Offset = "0xC80FB0", VA = "0x180C825B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JIGJIJDNFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14D8900", Offset = "0x14D7300", VA = "0x1814D8900")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1808F20", Offset = "0x1807920", VA = "0x181808F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte FFBKFHCEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3A3D0", Offset = "0xA38DD0", VA = "0x180A3A3D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AKFCLKKEOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CF7040", Offset = "0x5CF5A40", VA = "0x185CF7040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short GANEPJJAMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4E00", Offset = "0x5CF3800", VA = "0x185CF4E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7720", Offset = "0x5CF6120", VA = "0x185CF7720")]
	public void HMIMLGLKIMP(IPEndPoint DFOCJDNDFGL, byte[] NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6EF0", Offset = "0x5CF58F0", VA = "0x185CF6EF0")]
	public void FEAEINHBOKG(IPEndPoint DFOCJDNDFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4450", Offset = "0x5CF2E50", VA = "0x185CF4450")]
	private bool AJLHNOPLLAM(IPEndPoint DFOCJDNDFGL, [Out] JODPKGALIPK GFGLGJAIHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8330", Offset = "0x5CF6D30", VA = "0x185CF8330")]
	private void LGFFPALLOAM(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4EC0", Offset = "0x5CF38C0", VA = "0x185CF4EC0")]
	private void CGBCOJNNOBA(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CF74C0", Offset = "0x5CF5EC0", VA = "0x185CF74C0")]
	private void HHGHPGHFLKC(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAF70", Offset = "0x5CF9970", VA = "0x185CFAF70")]
	public KGFKNENJKED(IHIMDLCJLJM BLIJFMHBBHK, [Optional] AGIHDFJJONF CELMJLIEPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7FC0", Offset = "0x5CF69C0", VA = "0x185CF7FC0")]
	internal void KCCEBGIKDDJ(JODPKGALIPK FNFEJDIAIEO, int DDJOLKKHIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8010", Offset = "0x5CF6A10", VA = "0x185CF8010")]
	internal void KDKCKJPNBHH(JODPKGALIPK FNFEJDIAIEO, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5680", Offset = "0x5CF4080", VA = "0x185CF5680")]
	internal void CNNNNDAGEKC(JODPKGALIPK GFGLGJAIHDL, OFGOOMNBBBM NPGFMGMHJJL, SocketError GCPIEKCOBLD, BEEFEPJHLGP BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9AC0", Offset = "0x5CF84C0", VA = "0x185CF9AC0")]
	private void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL, OFGOOMNBBBM NPGFMGMHJJL, SocketError GCPIEKCOBLD, bool AMNFMCIBNPO, byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD, BEEFEPJHLGP BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5C40", Offset = "0x5CF4640", VA = "0x185CF5C40")]
	private void DOOLAHCJLEA(NAIBNGPKFLD.DIJHJJBCNEG NCMHJNKFAGH, [Optional] JODPKGALIPK GFGLGJAIHDL, [Optional] IPEndPoint EPJJEHDAAFG, SocketError LBJMNCMBNEA = SocketError.Success, int DDJOLKKHIGA = 0, OFGOOMNBBBM BAFDMNMIECG = OFGOOMNBBBM.ConnectionFailed, [Optional] JKBDFEOFJML MKHEPHFJHOP, ICCCONHPJEP ABGGJFHFFAM = ICCCONHPJEP.Unreliable, byte DOFKDJGAHMN = 0, [Optional] BEEFEPJHLGP CAIFLGNAEAL, [Optional] object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8E40", Offset = "0x5CF7840", VA = "0x185CF8E40")]
	private void NFMAFIEKMLN(NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8600", Offset = "0x5CF7000", VA = "0x185CF8600")]
	internal void LKDIHIMCPFO(NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAA50", Offset = "0x5CF9450", VA = "0x185CFAA50")]
	private void PNOOOPOCNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5750", Offset = "0x5CF4150", VA = "0x185CF5750")]
	private void DFOMFAOCBIH(int ENDANONOIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CF79A0", Offset = "0x5CF63A0", VA = "0x185CF79A0")]
	internal JODPKGALIPK IPGJAJJLEHK(JKBDFEOFJML GPCNCGBOPJG, byte[] HFGMCDELLGN, int GBALKPFEDAI, int OMJPDIKPOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CF97B0", Offset = "0x5CF81B0", VA = "0x185CF97B0")]
	private int NKGDFPAKAKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7060", Offset = "0x5CF5A60", VA = "0x185CF7060")]
	private void GHMGHFGDLCF(IPEndPoint EPJJEHDAAFG, JODPKGALIPK LIJMNEKHBMD, DFAKOGKLBAD CMFNCGDHDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5CF61A0", Offset = "0x5CF4BA0", VA = "0x185CF61A0")]
	private void FDCHBMGLANG(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8960", Offset = "0x5CF7360", VA = "0x185CF8960")]
	internal void MLMGEGEKALE(BEEFEPJHLGP DNPPEENABEA, ICCCONHPJEP PEDHACINLAG, byte DOFKDJGAHMN, int MGDPGEEAGEM, JODPKGALIPK FNFEJDIAIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9E80", Offset = "0x5CF8880", VA = "0x185CF9E80")]
	public bool PGKLFDNLGPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA6D0", Offset = "0x5CF90D0", VA = "0x185CFA6D0")]
	public bool PGKLFDNLGPL(IPAddress IIALMAGAFPN, IPAddress BDMFDCMAJOL, int PGLCONBPEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA650", Offset = "0x5CF9050", VA = "0x185CFA650")]
	public bool PGKLFDNLGPL(int PGLCONBPEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9610", Offset = "0x5CF8010", VA = "0x185CF9610")]
	public void NGGGEKBLODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4C40", Offset = "0x5CF3640", VA = "0x185CF4C40")]
	public JODPKGALIPK APLKHODBNCD(string ENHCCNBGHAP, int PGLCONBPEID, string NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4D20", Offset = "0x5CF3720", VA = "0x185CF4D20")]
	public JODPKGALIPK APLKHODBNCD(string ENHCCNBGHAP, int PGLCONBPEID, PLNCDKJFIPB MMFHPDKOKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4870", Offset = "0x5CF3270", VA = "0x185CF4870")]
	public JODPKGALIPK APLKHODBNCD(IPEndPoint CGKANMHMCOJ, PLNCDKJFIPB MMFHPDKOKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA6F0", Offset = "0x5CF90F0", VA = "0x185CFA6F0")]
	public void PKNIGDBJONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA700", Offset = "0x5CF9100", VA = "0x185CFA700")]
	public void PKNIGDBJONP(bool GOPGFBOBEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8D40", Offset = "0x5CF7740", VA = "0x185CF8D40")]
	public void MOLGMOLNPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8C20", Offset = "0x5CF7620", VA = "0x185CF8C20")]
	public void MOLGMOLNPLA(byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9BA0", Offset = "0x5CF85A0", VA = "0x185CF9BA0")]
	public void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9A00", Offset = "0x5CF8400", VA = "0x185CF9A00")]
	public void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL, byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAD90", Offset = "0x5CF9790", VA = "0x185CFAD90", Slot = "4")]
	private IEnumerator<JODPKGALIPK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAE20", Offset = "0x5CF9820", VA = "0x185CFAE20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5B50", Offset = "0x5CF4550", VA = "0x185CF5B50")]
	private BEEFEPJHLGP DLMOHFPBAHA(KDJJGPMBBJM FMACLHMOMLJ, int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5A70", Offset = "0x5CF4470", VA = "0x185CF5A70")]
	private BEEFEPJHLGP DLMOHFPBAHA(KDJJGPMBBJM FMACLHMOMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9C50", Offset = "0x5CF8650", VA = "0x185CF9C50")]
	internal BEEFEPJHLGP OONCCLBCFHE(int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8700", Offset = "0x5CF7100", VA = "0x185CF8700")]
	internal void LPLEPPGADOO(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAEB0", Offset = "0x5CF98B0", VA = "0x185CFAEB0")]
	static KGFKNENJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBD3060", Offset = "0xBD1A60", VA = "0x180BD3060")]
	private bool CKCBOLCFHPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9830", Offset = "0x5CF8230", VA = "0x185CF9830")]
	private void NPENMFDJIGI(IPEndPoint NCPMAKHGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9920", Offset = "0x5CF8320", VA = "0x185CF9920")]
	private void NPFAGLLCIFJ(IPEndPoint NCPMAKHGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6000", Offset = "0x5CF4A00", VA = "0x185CF6000")]
	private bool EGJJPMOBEJG(SocketException PBAHBFAICPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8060", Offset = "0x5CF6A60", VA = "0x185CF8060")]
	private void LGEFBHIEOGL(OMAJCMIBHDD PBBKIEJLJNH, EndPoint FBBIDFONLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5CF44E0", Offset = "0x5CF2EE0", VA = "0x185CF44E0")]
	private void AOCKMAOAJCM(object DMDDBNBIFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9E90", Offset = "0x5CF8890", VA = "0x185CF9E90")]
	public bool PGKLFDNLGPL(IPAddress IIALMAGAFPN, IPAddress BDMFDCMAJOL, int PGLCONBPEID, bool FGLNLMOJHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7940", Offset = "0x5CF6340", VA = "0x185CF7940")]
	internal int IIFKOKOAHII(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4F10", Offset = "0x5CF3910", VA = "0x185CF4F10")]
	internal int CLNKOFFKPGC(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4F50", Offset = "0x5CF3950", VA = "0x185CF4F50")]
	internal int CLNKOFFKPGC(byte[] JNNDBFGKHHD, int GBALKPFEDAI, int OMJPDIKPOLO, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5510", Offset = "0x5CF3F10", VA = "0x185CF5510")]
	internal void CNIMOHAOHEB(bool EJNCKPOIJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum KDJJGPMBBJM : byte
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
internal sealed class BEEFEPJHLGP
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int BMNBMFJAEKC;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] KIGIHIKNHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] FBNOHAEMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int LIFKLMGEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object GBFFNIOHIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public BEEFEPJHLGP NCDLNIPPHPH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public KDJJGPMBBJM DMAFECJFEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9A00", Offset = "0x5CE8400", VA = "0x185CE9A00")]
		get
		{
			return default(KDJJGPMBBJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9B00", Offset = "0x5CE8500", VA = "0x185CE9B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte IGNBHIMKOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9C40", Offset = "0x5CE8640", VA = "0x185CE9C40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9DB0", Offset = "0x5CE87B0", VA = "0x185CE9DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MCGINMOJIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9D50", Offset = "0x5CE8750", VA = "0x185CE9D50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9B70", Offset = "0x5CE8570", VA = "0x185CE9B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GLFGFKOBMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9DF0", Offset = "0x5CE87F0", VA = "0x185CE9DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PCKDKEAAKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9A30", Offset = "0x5CE8430", VA = "0x185CE9A30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9B40", Offset = "0x5CE8540", VA = "0x185CE9B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort IJCAIOFMEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9AA0", Offset = "0x5CE84A0", VA = "0x185CE9AA0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9D10", Offset = "0x5CE8710", VA = "0x185CE9D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MGCOCDEEIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9BE0", Offset = "0x5CE85E0", VA = "0x185CE9BE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9CD0", Offset = "0x5CE86D0", VA = "0x185CE9CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort KIBNOJKCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9C70", Offset = "0x5CE8670", VA = "0x185CE9C70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9A60", Offset = "0x5CE8460", VA = "0x185CE9A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9E20", Offset = "0x5CE8820", VA = "0x185CE9E20")]
	static BEEFEPJHLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9BB0", Offset = "0x5CE85B0", VA = "0x185CE9BB0")]
	public void IENDDAGDBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA100", Offset = "0x5CE8B00", VA = "0x185CEA100")]
	public BEEFEPJHLGP(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA170", Offset = "0x5CE8B70", VA = "0x185CEA170")]
	public BEEFEPJHLGP(KDJJGPMBBJM FMACLHMOMLJ, int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9800", Offset = "0x5CE8200", VA = "0x185CE9800")]
	public static int ACOEFJELLNG(KDJJGPMBBJM FMACLHMOMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9870", Offset = "0x5CE8270", VA = "0x185CE9870")]
	public int ACOEFJELLNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9900", Offset = "0x5CE8300", VA = "0x185CE9900")]
	public bool AHBIEMPEPON()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum BOBAGHPNAFL : byte
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
internal enum LALDNDBJFKP
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
internal enum CGMOCKHNHFL
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum BFCMLBMNPDD
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JODPKGALIPK
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class LCMHFCPJAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public BEEFEPJHLGP[] INFKCAHIPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int MPCPPLNFFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int MBAHCGLFDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte PCKDKEAAKBC;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public LCMHFCPJAAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void KDGCIOEGMLE(ulong CDNMPGGDLLC, int EEJMOKCJMKD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int BMJKGMOPAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int ODNCIEPABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int OOKPBFOALID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double NPPEMPKHMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int OKLLAEMDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int LJJOFIMNEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int LKKCLKAGHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch HNIDNGNNING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int IHOBMNPKBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long HIMPNKENAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object ANFJKOGLGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal JODPKGALIPK BHNDCBIMGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal JODPKGALIPK CKKACDJIIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<BEEFEPJHLGP> MNJGGLAGPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<FGMMJKMMGFF> NMJGHCDABMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly FGMMJKMMGFF[] MFFIOLMCLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int OMHFCEPOELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int GDDPFBCCCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool IFAFEFKIFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int GNBBKCHLJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int PIHMAIAJKAG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int LPNJJDFCDPN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int MBGBJGCIBJF = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object ONCKGPLCFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int HONJHMDPNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, LCMHFCPJAAO> KCMICDLFEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> EPADIDNOMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly BEEFEPJHLGP GJDCAKJCDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int GHFKJEFIOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int IIPKFJKKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint PHFJFBPLDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int JJGEKLNMCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int FFKOGGMJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long CBEGMNEAIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte KFJIAHGLJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private BOBAGHPNAFL BALDAGNDHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private BEEFEPJHLGP LKIJMHLKHJK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int PGFCCLCPJIM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HHLKJPOMKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly BEEFEPJHLGP KFLHGEKANGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly BEEFEPJHLGP EAJEPBACDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly BEEFEPJHLGP CFNADCABAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly BEEFEPJHLGP NALKMHBLHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private OFFMEBAOCCD EEHJMDCMEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly KGFKNENJKED JPLMBMNGICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int CODEDOIEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object LAHMNFJBNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly FAALMMEMLLA PHPFODDLFMF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte IIFLFFHANCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC162E0", Offset = "0xC14CE0", VA = "0x180C162E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0850", Offset = "0x5CEF250", VA = "0x185CF0850")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint EEMLJHOFNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD870", Offset = "0x8BC270", VA = "0x1808BD870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BOBAGHPNAFL MMHLKJNBMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x130F240", Offset = "0x130DC40", VA = "0x18130F240")]
		get
		{
			return default(BOBAGHPNAFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long NLBFNPKONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85C8D0", VA = "0x18085DED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GMIFIABMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCE5D70", Offset = "0xCE4770", VA = "0x180CE5D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15D70D0", Offset = "0x15D5AD0", VA = "0x1815D70D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int IPFMNMMGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0DB0", Offset = "0x5CEF7B0", VA = "0x185CF0DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BMILMHIBOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x8610D0", VA = "0x1808626D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double FNOGAPDHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A63900", Offset = "0x1A62300", VA = "0x181A63900")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KDGCIOEGMLE MNMLKNCPAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2480", Offset = "0x5CF0E80", VA = "0x185CF2480")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2CC0", Offset = "0x5CF16C0", VA = "0x185CF2CC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3270", Offset = "0x5CF1C70", VA = "0x185CF3270")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, IPEndPoint EPJJEHDAAFG, int DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF30C0", Offset = "0x5CF1AC0", VA = "0x185CF30C0")]
	internal void PHEFPMIKKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0940", Offset = "0x5CEF340", VA = "0x185CF0940")]
	internal void DCJBHLDLKNB(IPEndPoint OPLNBLCPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2530", Offset = "0x5CF0F30", VA = "0x185CF2530")]
	internal void KMJNIDCDOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0CE0", Offset = "0x5CEF6E0", VA = "0x185CF0CE0")]
	private void ENDFKOLAOBA(int MIFKMFBDKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3000", Offset = "0x5CF1A00", VA = "0x185CF3000")]
	private void OMCOGMIJAHG(int ENCFBNKNPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2E50", Offset = "0x5CF1850", VA = "0x185CF2E50")]
	private FGMMJKMMGFF OGCKGPIHIGO(byte AFLJKADDJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CF30E0", Offset = "0x5CF1AE0", VA = "0x185CF30E0")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, IPEndPoint EPJJEHDAAFG, int DKFNFHGODON, byte AGBOJBDOOKK, PLNCDKJFIPB CHKCCGJEIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CF36D0", Offset = "0x5CF20D0", VA = "0x185CF36D0")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, JKBDFEOFJML GPCNCGBOPJG, int DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2C70", Offset = "0x5CF1670", VA = "0x185CF2C70")]
	internal void NCFDFFJJMCG(DFAKOGKLBAD FKKDJGKIPPC, byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3040", Offset = "0x5CF1A40", VA = "0x185CF3040")]
	internal bool OOLIMKHOMCD(ODEAAAOAHHA DNPPEENABEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0DC0", Offset = "0x5CEF7C0", VA = "0x185CF0DC0")]
	public void FKIHHFKAOGH(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, ICCCONHPJEP FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1F30", Offset = "0x5CF0930", VA = "0x185CF1F30")]
	private void HIJFFJAHIIL(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0C30", Offset = "0x5CEF630", VA = "0x185CF0C30")]
	public void EJHDLEPHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2D70", Offset = "0x5CF1770", VA = "0x185CF2D70")]
	internal CGMOCKHNHFL NJHINPDEBNC(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(CGMOCKHNHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CF14A0", Offset = "0x5CEFEA0", VA = "0x185CF14A0")]
	internal void GGGNGEFPBMP(FGMMJKMMGFF FHBDGPKMKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF16C0", Offset = "0x5CF00C0", VA = "0x185CF16C0")]
	internal BFCMLBMNPDD GKKLPGKFKML(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, bool AMNFMCIBNPO)
	{
		return default(BFCMLBMNPDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0900", Offset = "0x5CEF300", VA = "0x185CF0900")]
	private void CIDPFKEJJJI(int IGDHNHOPGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFB30", Offset = "0x5CEE530", VA = "0x185CEFB30")]
	internal void AJEBEKCCFEC(ICCCONHPJEP PEDHACINLAG, BEEFEPJHLGP MPPCPDMLBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CF19D0", Offset = "0x5CF03D0", VA = "0x185CF19D0")]
	private void GOGHKPDNGAJ(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CF04D0", Offset = "0x5CEEED0", VA = "0x185CF04D0")]
	private void AOMLALJENLE(int LDGBKFKPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1500", Offset = "0x5CEFF00", VA = "0x185CF1500")]
	internal LALDNDBJFKP GHMGHFGDLCF(DFAKOGKLBAD CMFNCGDHDKO)
	{
		return default(LALDNDBJFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0DF0", Offset = "0x5CEF7F0", VA = "0x185CF0DF0")]
	internal void GAHEDLGEJFB(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFA10", Offset = "0x5CEE410", VA = "0x185CEFA10")]
	private void AGMIPGHGDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF840", Offset = "0x5CEE240", VA = "0x185CEF840")]
	internal void AFOEFDJAIMP(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF25C0", Offset = "0x5CF0FC0", VA = "0x185CF25C0")]
	internal void LHGGKPHIKGE(int LDGBKFKPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0970", Offset = "0x5CEF370", VA = "0x185CF0970")]
	internal void DKFKCAMLABP(BEEFEPJHLGP DNPPEENABEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class FAALMMEMLLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long GALEBJBCDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long GFAFBHGBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HHJGCKMCDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long IAEANEOLJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long GFLCGODMIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long EGAADHNDGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long CIJPHCNPDIF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long PLKICFOHLHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CECEC0", Offset = "0x5CEB8C0", VA = "0x185CECEC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LEPOKCBEOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CECD00", Offset = "0x5CEB700", VA = "0x185CECD00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LDEMILEKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CECE10", Offset = "0x5CEB810", VA = "0x185CECE10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EGJKMNDIOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5CECE80", Offset = "0x5CEB880", VA = "0x185CECE80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BIPOBBFMHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CECED0", Offset = "0x5CEB8D0", VA = "0x185CECED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long POGDPIOJAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5CECF40", Offset = "0x5CEB940", VA = "0x185CECF40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private OFFMEBAOCCD DOKFAEPHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CECDF0", Offset = "0x5CEB7F0", VA = "0x185CECDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double OGCLMDOIGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CECE20", Offset = "0x5CEB820", VA = "0x185CECE20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CECEE0", Offset = "0x5CEB8E0", VA = "0x185CECEE0")]
	public void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CECE90", Offset = "0x5CEB890", VA = "0x185CECE90")]
	public void HMICJPJMLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CECF50", Offset = "0x5CEB950", VA = "0x185CECF50")]
	public void PJHHEENNBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CECE00", Offset = "0x5CEB800", VA = "0x185CECE00")]
	public void FGLMDOMNAIJ(long EHGLIIEECOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CECCC0", Offset = "0x5CEB6C0", VA = "0x185CECCC0")]
	public void AENHBKONFFC(long NCLBGIHECPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CECCD0", Offset = "0x5CEB6D0", VA = "0x185CECCD0")]
	public void BJJCOEEOHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CECDB0", Offset = "0x5CEB7B0", VA = "0x185CECDB0")]
	public void DELPNCBFOEK(long KPMACPPLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CECF60", Offset = "0x5CEB960", VA = "0x185CECF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CECD10", Offset = "0x5CEB710", VA = "0x185CECD10")]
	public void CKOKIAHMMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public FAALMMEMLLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EOCHKCFCJLE
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> IDKFABKODEL;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC9E0", Offset = "0x5CEB3E0", VA = "0x185CEC9E0")]
	public static IPEndPoint JAMCJKADIAC(string PPCNIEJPEKK, int PGLCONBPEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC810", Offset = "0x5CEB210", VA = "0x185CEC810")]
	public static IPAddress FDGPNKJKEDA(string PPCNIEJPEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC780", Offset = "0x5CEB180", VA = "0x185CEC780")]
	public static IPAddress FDGPNKJKEDA(string PPCNIEJPEKK, AddressFamily EBPPOLJHJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC750", Offset = "0x5CEB150", VA = "0x185CEC750")]
	internal static int DIMBMMLGONG(int CNEGAAAMFEO, int NKOKHDBOMFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x29DA070", Offset = "0x29D8A70", VA = "0x1829DA070")]
	internal static T[] ALJPENGOCKI<T>(int IHGHLPOONHD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class EMPABLNIKLF : FGMMJKMMGFF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct AEDPFHHIACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private BEEFEPJHLGP LBGHFJFHADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long BAOBNCFKPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool JNDJLBDLLCA;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9600", Offset = "0x5CE8000", VA = "0x185CE9600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9520", Offset = "0x5CE7F20", VA = "0x185CE9520")]
		public void EEKIDKGBNNN(BEEFEPJHLGP DNPPEENABEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9590", Offset = "0x5CE7F90", VA = "0x185CE9590")]
		public bool KMBDKADDDCE(long KBAMMELOGGL, JODPKGALIPK GFGLGJAIHDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9540", Offset = "0x5CE7F40", VA = "0x185CE9540")]
		public bool IMJJLGNDCEN(JODPKGALIPK GFGLGJAIHDL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly BEEFEPJHLGP DNNAABELFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly AEDPFHHIACK[] HPAOHLNMNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly BEEFEPJHLGP[] GABHMNFAGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] LHNIHBMPJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int DGPLIIFLEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int CBNDKBFJHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int IDKKAKACNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int JMKJLAMFKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KFHDKAEJAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly ICCCONHPJEP EEOFJLLBBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool MGLFIFGJOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int JNGFAIGMJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte ADGENFHMOEI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC580", Offset = "0x5CEAF80", VA = "0x185CEC580")]
	public EMPABLNIKLF(JODPKGALIPK GFGLGJAIHDL, bool OOLEDJPJOMF, byte DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB6B0", Offset = "0x5CEA0B0", VA = "0x185CEB6B0")]
	private void FEGMMFOAOEL(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC0D0", Offset = "0x5CEAAD0", VA = "0x185CEC0D0", Slot = "4")]
	protected override bool MKJGJDGPJJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBA70", Offset = "0x5CEA470", VA = "0x185CEBA70", Slot = "5")]
	public override bool GAHEDLGEJFB(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LMKMCJJMHIO : FGMMJKMMGFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int CKBFKJDALHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort CBNDKBFJHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool MMGCGDCLODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private BEEFEPJHLGP CKHMPCHAKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly BEEFEPJHLGP DEOALAPAPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool BAOEDGFKFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte ADGENFHMOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long IAAIBPCCOLO;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC570", Offset = "0x5CFAF70", VA = "0x185CFC570")]
	public LMKMCJJMHIO(JODPKGALIPK GFGLGJAIHDL, bool FPHGDIEDHEP, byte DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CFC0D0", Offset = "0x5CFAAD0", VA = "0x185CFC0D0", Slot = "4")]
	protected override bool MKJGJDGPJJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBDC0", Offset = "0x5CFA7C0", VA = "0x185CFBDC0", Slot = "5")]
	public override bool GAHEDLGEJFB(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AOIBHEGIIAI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct IAFOOBBDGID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong GGKOPPINKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double HBPHPOMAJGE;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct LCOFOGDAACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int ONOBBLCINFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float DBLHLLHIAHM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8F40", Offset = "0x5CE7940", VA = "0x185CE8F40")]
	private static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, ulong LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96B0", Offset = "0x5CE80B0", VA = "0x185CE96B0")]
	private static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CE97A0", Offset = "0x5CE81A0", VA = "0x185CE97A0")]
	public static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, short LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CE97E0", Offset = "0x5CE81E0", VA = "0x185CE97E0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, double JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9720", Offset = "0x5CE8120", VA = "0x185CE9720")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE97A0", Offset = "0x5CE81A0", VA = "0x185CE97A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, short JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE97A0", Offset = "0x5CE81A0", VA = "0x185CE97A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, ushort JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96B0", Offset = "0x5CE80B0", VA = "0x185CE96B0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96B0", Offset = "0x5CE80B0", VA = "0x185CE96B0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, uint JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96A0", Offset = "0x5CE80A0", VA = "0x185CE96A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96A0", Offset = "0x5CE80A0", VA = "0x185CE96A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, ulong JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GFNMLBNLGLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] FEANHFKPPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int IILNLNEPHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int KOGBPBPBOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int IIGEFBDIEMO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] FBNOHAEMOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HJCGDEMODCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC530", VA = "0x1808CDB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GCMOLNFPOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF590", Offset = "0x5CEDF90", VA = "0x185CEF590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EKJJHCFOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EC53C0", Offset = "0x1EC3DC0", VA = "0x181EC53C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OCPECKMFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5CEEA20", Offset = "0x5CED420", VA = "0x185CEEA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF460", Offset = "0x5CEDE60", VA = "0x185CEF460")]
	public void NNGFPFGNFPO(byte[] LDPKCIGIIMG, int PENDBLHFGOI, int GMGJCNDCIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
	public GFNMLBNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF5A0", Offset = "0x5CEDFA0", VA = "0x185CEF5A0")]
	public GFNMLBNLGLI(byte[] LDPKCIGIIMG, int PENDBLHFGOI, int GMGJCNDCIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CEECE0", Offset = "0x5CED6E0", VA = "0x185CEECE0")]
	public IPEndPoint GDOCFGOAOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEA70", Offset = "0x5CED470", VA = "0x185CEEA70")]
	public byte PKKLBLNMIML()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEA70", Offset = "0x5CED470", VA = "0x185CEEA70")]
	public sbyte BECONKIPHPM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B22D40", Offset = "0x2B21740", VA = "0x182B22D40")]
	public T[] KHIKKEAIICA<T>(ushort ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEBE0", Offset = "0x5CED5E0", VA = "0x185CEEBE0")]
	public bool[] DEAEDOECEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEDB0", Offset = "0x5CED7B0", VA = "0x185CEEDB0")]
	public ushort[] GOEINCDEPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF110", Offset = "0x5CEDB10", VA = "0x185CEF110")]
	public short[] ICBJCKHIEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEC60", Offset = "0x5CED660", VA = "0x185CEEC60")]
	public int[] EPOCFKGLFOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5CEECA0", Offset = "0x5CED6A0", VA = "0x185CEECA0")]
	public uint[] FODMFOJPGNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEA30", Offset = "0x5CED430", VA = "0x185CEEA30")]
	public float[] BDJABFABLKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF550", Offset = "0x5CEDF50", VA = "0x185CEF550")]
	public double[] PGDAGAHBBOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEC20", Offset = "0x5CED620", VA = "0x185CEEC20")]
	public long[] EFOHKABJFLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF4A0", Offset = "0x5CEDEA0", VA = "0x185CEF4A0")]
	public ulong[] OIBMNPJCFIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEAB0", Offset = "0x5CED4B0", VA = "0x185CEEAB0")]
	public string[] CPOCJGNOHKC(int KMOHOCIHNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3B0", Offset = "0x5CEDDB0", VA = "0x185CEF3B0")]
	public bool KLENDAOKIHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEE60", Offset = "0x5CED860", VA = "0x185CEEE60")]
	public char PBHAKOPGOBD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEE60", Offset = "0x5CED860", VA = "0x185CEEE60")]
	public ushort IBDBMFOGPNL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF1E0", Offset = "0x5CEDBE0", VA = "0x185CEF1E0")]
	public short JBNGFMMIBKH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF290", Offset = "0x5CEDC90", VA = "0x185CEF290")]
	public long JDDNOHFHAAL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF4E0", Offset = "0x5CEDEE0", VA = "0x185CEF4E0")]
	public ulong OOPKJEPMIOJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF150", Offset = "0x5CEDB50", VA = "0x185CEF150")]
	public int IHBFIGKDFOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF340", Offset = "0x5CEDD40", VA = "0x185CEF340")]
	public uint KFPAMIGGLPE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEDF0", Offset = "0x5CED7F0", VA = "0x185CEEDF0")]
	public float HBAAEIHNOFH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE9B0", Offset = "0x5CED3B0", VA = "0x185CEE9B0")]
	public double AJIJFKNOBOA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEED0", Offset = "0x5CED8D0", VA = "0x185CEEED0")]
	public string IBIKDEAMEBM(int KBFGFPLLOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3F0", Offset = "0x5CEDDF0", VA = "0x185CEF3F0")]
	public ArraySegment<byte> KMLLKFLBLHJ(int IHGHLPOONHD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF250", Offset = "0x5CEDC50", VA = "0x185CEF250")]
	public sbyte[] JCCELEGMJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF300", Offset = "0x5CEDD00", VA = "0x185CEF300")]
	public byte[] JFHDODIKIAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF1C0", Offset = "0x5CEDBC0", VA = "0x185CEF1C0")]
	public void IMJJLGNDCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PLNCDKJFIPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] FEANHFKPPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int IILNLNEPHHI;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int DIKAFHHKDIF = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool OEAGPEDEGJB;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding HKIGLLDMIBJ;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int OAMCEJIMHCG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] BGHDNODHFIN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] CPPCAMCFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E710", VA = "0x18085FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFE30", Offset = "0x5CFE830", VA = "0x185CFFE30")]
	public PLNCDKJFIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFEB0", Offset = "0x5CFE8B0", VA = "0x185CFFEB0")]
	public PLNCDKJFIPB(bool OBNEJGEPALM, int BFNINGMCNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF100", Offset = "0x5CFDB00", VA = "0x185CFF100")]
	public static PLNCDKJFIPB CKKNHLMDGHJ(string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF170", Offset = "0x5CFDB70", VA = "0x185CFF170")]
	public void JBDGAIKBLHK(int OBMECBFGAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F3EC80", Offset = "0x1F3D680", VA = "0x181F3EC80")]
	public void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFA30", Offset = "0x5CFE430", VA = "0x185CFFA30")]
	public void OEEAOMEPNLL(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF9E0", Offset = "0x5CFE3E0", VA = "0x185CFF9E0")]
	public void OEEAOMEPNLL(double JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFAE0", Offset = "0x5CFE4E0", VA = "0x185CFFAE0")]
	public void OEEAOMEPNLL(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFAE0", Offset = "0x5CFE4E0", VA = "0x185CFFAE0")]
	public void OEEAOMEPNLL(ulong JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF8E0", Offset = "0x5CFE2E0", VA = "0x185CFF8E0")]
	public void OEEAOMEPNLL(int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF8E0", Offset = "0x5CFE2E0", VA = "0x185CFF8E0")]
	public void OEEAOMEPNLL(uint JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF970", Offset = "0x5CFE370", VA = "0x185CFF970")]
	public void OEEAOMEPNLL(char JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF970", Offset = "0x5CFE370", VA = "0x185CFF970")]
	public void OEEAOMEPNLL(ushort JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF970", Offset = "0x5CFE370", VA = "0x185CFF970")]
	public void OEEAOMEPNLL(short JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF880", Offset = "0x5CFE280", VA = "0x185CFF880")]
	public void OEEAOMEPNLL(sbyte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF880", Offset = "0x5CFE280", VA = "0x185CFF880")]
	public void OEEAOMEPNLL(byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF740", Offset = "0x5CFE140", VA = "0x185CFF740")]
	public void OEEAOMEPNLL(byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF2F0", Offset = "0x5CFDCF0", VA = "0x185CFF2F0")]
	public void JLECAMKEFBN(sbyte[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF2F0", Offset = "0x5CFDCF0", VA = "0x185CFF2F0")]
	public void MBKHOPAEPMM(byte[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFB30", Offset = "0x5CFE530", VA = "0x185CFFB30")]
	public void OEEAOMEPNLL(bool JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF210", Offset = "0x5CFDC10", VA = "0x185CFF210")]
	public void JDMIAFLJLFK(Array GHJMPEDKGHI, int JJPCOKALJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF4A0", Offset = "0x5CFDEA0", VA = "0x185CFF4A0")]
	public void JDMIAFLJLFK(float[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF660", Offset = "0x5CFE060", VA = "0x185CFF660")]
	public void JDMIAFLJLFK(double[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF660", Offset = "0x5CFE060", VA = "0x185CFF660")]
	public void JDMIAFLJLFK(long[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF660", Offset = "0x5CFE060", VA = "0x185CFF660")]
	public void JDMIAFLJLFK(ulong[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF4A0", Offset = "0x5CFDEA0", VA = "0x185CFF4A0")]
	public void JDMIAFLJLFK(int[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF4A0", Offset = "0x5CFDEA0", VA = "0x185CFF4A0")]
	public void JDMIAFLJLFK(uint[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF580", Offset = "0x5CFDF80", VA = "0x185CFF580")]
	public void JDMIAFLJLFK(ushort[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF580", Offset = "0x5CFDF80", VA = "0x185CFF580")]
	public void JDMIAFLJLFK(short[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF2F0", Offset = "0x5CFDCF0", VA = "0x185CFF2F0")]
	public void JDMIAFLJLFK(bool[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF3D0", Offset = "0x5CFDDD0", VA = "0x185CFF3D0")]
	public void JDMIAFLJLFK(string[] JMDCGOKJIDA, int JOICIBAPFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF7B0", Offset = "0x5CFE1B0", VA = "0x185CFF7B0")]
	public void OEEAOMEPNLL(IPEndPoint DFOCJDNDFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFAD0", Offset = "0x5CFE4D0", VA = "0x185CFFAD0")]
	public void OEEAOMEPNLL(string JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFB90", Offset = "0x5CFE590", VA = "0x185CFFB90")]
	public void OEEAOMEPNLL(string JMDCGOKJIDA, int KBFGFPLLOGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KAHBNCLFEMA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class PMHFCAPFNOH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong CODEDOIEGGD;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4772620", Offset = "0x4771020", VA = "0x184772620")]
		static PMHFCAPFNOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void ELGPGPGHMJP(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class JGNLPPMEJPI<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public KAHBNCLFEMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public JGNLPPMEJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x409BA80", Offset = "0x409A480", VA = "0x18409BA80")]
		internal void FNAFBADBMFC(GFNMLBNLGLI reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GNOJKLLDGLL<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public KAHBNCLFEMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		public GNOJKLLDGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1880", Offset = "0x3CD0280", VA = "0x183CD1880")]
		internal void FNAFBADBMFC(GFNMLBNLGLI reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly MAJBKIPCDFB HDKIFDEJJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, ELGPGPGHMJP> JIGBPAHBPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly PLNCDKJFIPB KDGOFIGAFIB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3AB0", Offset = "0x5CF24B0", VA = "0x185CF3AB0")]
	public KAHBNCLFEMA(int KMOHOCIHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x293BB90", Offset = "0x293A590", VA = "0x18293BB90", Slot = "4")]
	protected virtual ulong GLJLINEAPKO<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3900", Offset = "0x5CF2300", VA = "0x185CF3900", Slot = "5")]
	protected virtual ELGPGPGHMJP DMLMFOOODCB(GFNMLBNLGLI ELOKBGPKALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5BD0", Offset = "0x2BF45D0", VA = "0x182BF5BD0", Slot = "6")]
	protected virtual void IICCKAHOGEI<T>(PLNCDKJFIPB JLIOPEDCMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3A30", Offset = "0x5CF2430", VA = "0x185CF3A30")]
	public void HKCHGOMDLEB(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5B20", Offset = "0x2BF4520", VA = "0x182BF5B20")]
	public void HHIFNKNGNCI<T>(PLNCDKJFIPB JLIOPEDCMBE, T DNPPEENABEA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5CF38B0", Offset = "0x5CF22B0", VA = "0x185CF38B0")]
	public void BICCFOJGKHF(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5DF0", Offset = "0x2BF47F0", VA = "0x182BF5DF0")]
	public void LOKONGJCMHE<T>(Action<T> KMJBEKCGHLD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5C40", Offset = "0x2BF4640", VA = "0x182BF5C40")]
	public void LOKONGJCMHE<T, TUserData>(Action<T, TUserData> KMJBEKCGHLD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HDCEHOFLJAL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB6A0", Offset = "0x5CEA0A0", VA = "0x185CEB6A0")]
	public HDCEHOFLJAL(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MHFBENNBKOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDE70", Offset = "0x5CFC870", VA = "0x185CFDE70")]
	public MHFBENNBKOD(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class MAJBKIPCDFB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum KONOBGCEHAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class FMIMFEIJDCN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public KONOBGCEHAN EPCABOEGHGN;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3BE85F0", Offset = "0x3BE6FF0", VA = "0x183BE85F0", Slot = "4")]
		public virtual void EEKIDKGBNNN(MethodInfo KANOEFJDOAC, MethodInfo NFNKOMEBDKF, KONOBGCEHAN NCMHJNKFAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void PKJGFMJNCIB(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GNOLNCNLIAA(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		protected FMIMFEIJDCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class PEAPMPPPPLK<TClass, TProperty> : FMIMFEIJDCN<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> LOKCLAODIPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> OJNABJANEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> HIBBDACGFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> GJPMBCIGFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> EHEPMKKMEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> KIPEAJDNMCF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4757190", Offset = "0x4755B90", VA = "0x184757190", Slot = "7")]
		public override void DIIPPBFNKFP(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x475CAF0", Offset = "0x475B4F0", VA = "0x18475CAF0", Slot = "8")]
		public override void MLDFCKJKEPC(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x475D510", Offset = "0x475BF10", VA = "0x18475D510", Slot = "9")]
		public override void PKJGFMJNCIB(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x475BEB0", Offset = "0x475A8B0", VA = "0x18475BEB0", Slot = "10")]
		public override void GNOLNCNLIAA(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4756FB0", Offset = "0x47559B0", VA = "0x184756FB0")]
		protected TProperty[] DFNHALMGPLE(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x475D3B0", Offset = "0x475BDB0", VA = "0x18475D3B0")]
		protected TProperty[] MOEMJFKCEOI(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4758670", Offset = "0x4757070", VA = "0x184758670", Slot = "4")]
		public override void EEKIDKGBNNN(MethodInfo KANOEFJDOAC, MethodInfo NFNKOMEBDKF, KONOBGCEHAN NCMHJNKFAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x423F6D0", Offset = "0x423E0D0", VA = "0x18423F6D0")]
		protected PEAPMPPPPLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class GJGGMAAGHIA<TClass, TProperty> : PEAPMPPPPLK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] TProperty CJJOCFAPEJO);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, TProperty CJJOCFAPEJO);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3CC02A0", Offset = "0x3CBECA0", VA = "0x183CC02A0", Slot = "5")]
		public override void CLAPPBNJGGL(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3CC04C0", Offset = "0x3CBEEC0", VA = "0x183CC04C0", Slot = "6")]
		public override void HHIFNKNGNCI(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0400", Offset = "0x3CBEE00", VA = "0x183CC0400", Slot = "7")]
		public override void DIIPPBFNKFP(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CC05C0", Offset = "0x3CBEFC0", VA = "0x183CC05C0", Slot = "8")]
		public override void MLDFCKJKEPC(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0740", Offset = "0x3CBF140", VA = "0x183CC0740")]
		protected GJGGMAAGHIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class MKGEEPFKHPK<T> : PEAPMPPPPLK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4498C70", Offset = "0x4497670", VA = "0x184498C70", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4498D70", Offset = "0x4497770", VA = "0x184498D70", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4498CF0", Offset = "0x44976F0", VA = "0x184498CF0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x41BBE40", Offset = "0x41BA840", VA = "0x1841BBE40", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public MKGEEPFKHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BJHDBCJMLNI<T> : PEAPMPPPPLK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E2DD20", Offset = "0x4E2C720", VA = "0x184E2DD20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4498D70", Offset = "0x4497770", VA = "0x184498D70", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4E2DDA0", Offset = "0x4E2C7A0", VA = "0x184E2DDA0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x41BBE40", Offset = "0x41BA840", VA = "0x1841BBE40", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public BJHDBCJMLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class PJOHLLLGMEG<T> : PEAPMPPPPLK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x476A680", Offset = "0x4769080", VA = "0x18476A680", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3805EB0", Offset = "0x38048B0", VA = "0x183805EB0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x476A700", Offset = "0x4769100", VA = "0x18476A700", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3805F20", Offset = "0x3804920", VA = "0x183805F20", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public PJOHLLLGMEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class EOLPAMJCDMJ<T> : PEAPMPPPPLK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3805DB0", Offset = "0x38047B0", VA = "0x183805DB0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3805EB0", Offset = "0x38048B0", VA = "0x183805EB0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3805E30", Offset = "0x3804830", VA = "0x183805E30", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3805F20", Offset = "0x3804920", VA = "0x183805F20", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public EOLPAMJCDMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NPCJGOEJPLO<T> : PEAPMPPPPLK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x453A750", Offset = "0x4539150", VA = "0x18453A750", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5820", Offset = "0x3CD4220", VA = "0x183CD5820", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x453A7D0", Offset = "0x45391D0", VA = "0x18453A7D0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5890", Offset = "0x3CD4290", VA = "0x183CD5890", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public NPCJGOEJPLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class GPPCIFIKAOE<T> : PEAPMPPPPLK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5720", Offset = "0x3CD4120", VA = "0x183CD5720", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5820", Offset = "0x3CD4220", VA = "0x183CD5820", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD57A0", Offset = "0x3CD41A0", VA = "0x183CD57A0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5890", Offset = "0x3CD4290", VA = "0x183CD5890", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public GPPCIFIKAOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CGDBEJHLLAK<T> : PEAPMPPPPLK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3804B20", Offset = "0x3803520", VA = "0x183804B20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3804C20", Offset = "0x3803620", VA = "0x183804C20", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x51078F0", Offset = "0x51062F0", VA = "0x1851078F0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3804C90", Offset = "0x3803690", VA = "0x183804C90", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public CGDBEJHLLAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ENHEOJOAPPD<T> : PEAPMPPPPLK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3804B20", Offset = "0x3803520", VA = "0x183804B20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3804C20", Offset = "0x3803620", VA = "0x183804C20", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3804BA0", Offset = "0x38035A0", VA = "0x183804BA0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3804C90", Offset = "0x3803690", VA = "0x183804C90", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public ENHEOJOAPPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KPDLCKGGMDA<T> : PEAPMPPPPLK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41BBCD0", Offset = "0x41BA6D0", VA = "0x1841BBCD0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x41BBDD0", Offset = "0x41BA7D0", VA = "0x1841BBDD0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x41BBD50", Offset = "0x41BA750", VA = "0x1841BBD50", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x41BBE40", Offset = "0x41BA840", VA = "0x1841BBE40", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public KPDLCKGGMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PCGPEMAAMAE<T> : PEAPMPPPPLK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x47517D0", Offset = "0x47501D0", VA = "0x1847517D0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x47518D0", Offset = "0x47502D0", VA = "0x1847518D0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4751850", Offset = "0x4750250", VA = "0x184751850", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5890", Offset = "0x3CD4290", VA = "0x183CD5890", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public PCGPEMAAMAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class LFDNFJMDLPE<T> : PEAPMPPPPLK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4231700", Offset = "0x4230100", VA = "0x184231700", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4231800", Offset = "0x4230200", VA = "0x184231800", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4231780", Offset = "0x4230180", VA = "0x184231780", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3804C90", Offset = "0x3803690", VA = "0x183804C90", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3804D00", Offset = "0x3803700", VA = "0x183804D00")]
		public LFDNFJMDLPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HEBIMOAJFJC<T> : GJGGMAAGHIA<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D05A90", Offset = "0x3D04490", VA = "0x183D05A90", Slot = "12")]
		protected override void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, char CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AC0", Offset = "0x3D044C0", VA = "0x183D05AC0", Slot = "11")]
		protected override void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] char CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D044F0", VA = "0x183D05AF0")]
		public HEBIMOAJFJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OGADGEMJNMA<T> : GJGGMAAGHIA<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x462CCE0", Offset = "0x462B6E0", VA = "0x18462CCE0", Slot = "12")]
		protected override void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, IPEndPoint CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x462CD10", Offset = "0x462B710", VA = "0x18462CD10", Slot = "11")]
		protected override void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] IPEndPoint CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D05AF0", Offset = "0x3D044F0", VA = "0x183D05AF0")]
		public OGADGEMJNMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class LNKKGFHGKNC<T> : PEAPMPPPPLK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int KGIIPFBDAHA;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4294920", Offset = "0x4293320", VA = "0x184294920")]
		public LNKKGFHGKNC(int KBFGFPLLOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4294720", Offset = "0x4293120", VA = "0x184294720", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4294820", Offset = "0x4293220", VA = "0x184294820", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x42947A0", Offset = "0x42931A0", VA = "0x1842947A0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x42948A0", Offset = "0x42932A0", VA = "0x1842948A0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class KDJCAGMMMIJ<T> : FMIMFEIJDCN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo DMAFECJFEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type IAOEJFAHGHF;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x416B370", Offset = "0x4169D70", VA = "0x18416B370")]
		public KDJCAGMMMIJ(PropertyInfo FMACLHMOMLJ, Type KGDKDOJABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x416B080", Offset = "0x4169A80", VA = "0x18416B080", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x416B200", Offset = "0x4169C00", VA = "0x18416B200", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x416B140", Offset = "0x4169B40", VA = "0x18416B140", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x416B2B0", Offset = "0x4169CB0", VA = "0x18416B2B0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x416B310", Offset = "0x4169D10", VA = "0x18416B310", Slot = "9")]
		public override void PKJGFMJNCIB(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x416B1A0", Offset = "0x4169BA0", VA = "0x18416B1A0", Slot = "10")]
		public override void GNOLNCNLIAA(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KJOIMPHENDL<T> : KDJCAGMMMIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C529C0", Offset = "0x3C513C0", VA = "0x183C529C0")]
		public KJOIMPHENDL(PropertyInfo FMACLHMOMLJ, Type KGDKDOJABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4182540", Offset = "0x4180F40", VA = "0x184182540", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4182600", Offset = "0x4181000", VA = "0x184182600", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class BNBGHEKIIAL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static BNBGHEKIIAL<T> MJFJCBEEADM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly FMIMFEIJDCN<T>[] AABHHKNBJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int KOHCPMDDOBJ;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E703B0", Offset = "0x4E6EDB0", VA = "0x184E703B0")]
		public BNBGHEKIIAL(List<FMIMFEIJDCN<T>> FAHLHGGJMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E70300", Offset = "0x4E6ED00", VA = "0x184E70300")]
		public void HHIFNKNGNCI(T MEAFIMADMKA, PLNCDKJFIPB JLIOPEDCMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E70250", Offset = "0x4E6EC50", VA = "0x184E70250")]
		public void CLAPPBNJGGL(T MEAFIMADMKA, GFNMLBNLGLI ELOKBGPKALP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class NGJIOKLEHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract FMIMFEIJDCN<T> JMJOGDIBBHK<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private PLNCDKJFIPB NNFHGFKIFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int FCFNNNPMMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, NGJIOKLEHIB> JEJMFEAOEPP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDDD0", Offset = "0x5CFC7D0", VA = "0x185CFDDD0")]
	public MAJBKIPCDFB(int KMOHOCIHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C200", Offset = "0x2C1AC00", VA = "0x182C1C200")]
	private BNBGHEKIIAL<T> MIKKPADLDCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2995920", Offset = "0x2994320", VA = "0x182995920")]
	public void JGBCFAKMKJN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C160", Offset = "0x2C1AB60", VA = "0x182C1C160")]
	public bool DGBBAPGEGII<T>(GFNMLBNLGLI ELOKBGPKALP, T CGKANMHMCOJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D310", Offset = "0x2C1BD10", VA = "0x182C1D310")]
	public void OPCGAJMHMBL<T>(PLNCDKJFIPB JLIOPEDCMBE, T MEAFIMADMKA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class FNCNBOPEEEO
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime PJAHKINMNOI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] FFDJEBPLBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851B00", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GPMKDDJGPMD OHGGDANKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CED7A0", Offset = "0x5CEC1A0", VA = "0x185CED7A0")]
		get
		{
			return default(GPMKDDJGPMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JODMKGBCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CED620", Offset = "0x5CEC020", VA = "0x185CED620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDBA0", Offset = "0x5CEC5A0", VA = "0x185CEDBA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IHFBDOEDAIF FFLGFNAAOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE1D0", Offset = "0x5CECBD0", VA = "0x185CEE1D0")]
		get
		{
			return default(IHFBDOEDAIF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE2B0", Offset = "0x5CECCB0", VA = "0x185CEE2B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JHPKPHCHPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE200", Offset = "0x5CECC00", VA = "0x185CEE200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint BPIOALJJJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE230", Offset = "0x5CECC30", VA = "0x185CEE230")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? NJHKEJDIHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CED770", Offset = "0x5CEC170", VA = "0x185CED770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KKCPJNEOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE1A0", Offset = "0x5CECBA0", VA = "0x185CEE1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CFIMMEIIMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CED9A0", Offset = "0x5CEC3A0", VA = "0x185CED9A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CED9D0", Offset = "0x5CEC3D0", VA = "0x185CED9D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DBAGCJPIEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA761E0", Offset = "0xA74BE0", VA = "0x180A761E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE5E0", Offset = "0x5CECFE0", VA = "0x185CEE5E0")]
	public FNCNBOPEEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE900", Offset = "0x5CED300", VA = "0x185CEE900")]
	internal FNCNBOPEEEO(byte[] DDNKCFIIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CED650", Offset = "0x5CEC050", VA = "0x185CED650")]
	public static FNCNBOPEEEO AKJCFLGKCBK(byte[] DDNKCFIIBGP, DateTime FAPMGBCFHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDCD0", Offset = "0x5CEC6D0", VA = "0x185CEDCD0")]
	internal void KKJJCEGIAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE2F0", Offset = "0x5CECCF0", VA = "0x185CEE2F0")]
	private void OEGGEOBKOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDFA0", Offset = "0x5CEC9A0", VA = "0x185CEDFA0")]
	private DateTime? KMGLOGEADLP(int PENDBLHFGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CED7D0", Offset = "0x5CEC1D0", VA = "0x185CED7D0")]
	private void CIAFLFKPMKO(int PENDBLHFGOI, DateTime? JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDED0", Offset = "0x5CEC8D0", VA = "0x185CEDED0")]
	private ulong KKNBONJLPPI(int PENDBLHFGOI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE4C0", Offset = "0x5CECEC0", VA = "0x185CEE4C0")]
	private void PCNHLGNKGCE(int PENDBLHFGOI, ulong JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDC40", Offset = "0x5CEC640", VA = "0x185CEDC40")]
	private uint KCFOGMBIODO(int PENDBLHFGOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BBE7F0", Offset = "0x5BBD1F0", VA = "0x185BBE7F0")]
	private static uint JILBPPCAONO(uint IPBJLCONKPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDBE0", Offset = "0x5CEC5E0", VA = "0x185CEDBE0")]
	private static ulong JILBPPCAONO(ulong IPBJLCONKPC)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum GPMKDDJGPMD
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
public enum IHFBDOEDAIF
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class FBDJODOBBJP
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int KIAKOGJFJFA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int NDBPEKDNMFI = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int EICMNMJDFDH = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint DIKJKPHIECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int JJPMMLBMPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int LCJPLENIMMA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DNNDMCMAIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5CED3B0", Offset = "0x5CEBDB0", VA = "0x185CED3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CED2C0", Offset = "0x5CEBCC0", VA = "0x185CED2C0")]
	public bool FKIHHFKAOGH(OMAJCMIBHDD PBBKIEJLJNH, int HDCBOMJHFCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class KDLNGIHHHLK : OMAJCMIBHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket PBBKIEJLJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly KGFKNENJKED GENLECEPGLM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short GANEPJJAMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3C50", Offset = "0x5CF2650", VA = "0x185CF3C50", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int ANBBECBIOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3C70", Offset = "0x5CF2670", VA = "0x185CF3C70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint IDFDBCPNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4290", Offset = "0x5CF2C90", VA = "0x185CF4290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HNCFNIEAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4218070", Offset = "0x4216A70", VA = "0x184218070", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF43A0", Offset = "0x5CF2DA0", VA = "0x185CF43A0")]
	public KDLNGIHHHLK(AddressFamily EBPPOLJHJFO, KGFKNENJKED GENLECEPGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3CD0", Offset = "0x5CF26D0", VA = "0x185CF3CD0", Slot = "8")]
	public bool KEPICDLKMMO(IPEndPoint DFOCJDNDFGL, NOCKMHOHBAI KABMHDMECDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3C90", Offset = "0x5CF2690", VA = "0x185CF3C90", Slot = "9")]
	public int KACGICJMLIN(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int ECGAAJFODGN, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CF42B0", Offset = "0x5CF2CB0", VA = "0x185CF42B0", Slot = "10")]
	public int PJJDGIFDOLF(byte[] PHMDIHEJOGG, EndPoint NJMLADNIIBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3C30", Offset = "0x5CF2630", VA = "0x185CF3C30", Slot = "11")]
	public void BFGFCJDAAAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface OMAJCMIBHDD
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short GANEPJJAMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int ANBBECBIOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint IDFDBCPNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily HNCFNIEAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KEPICDLKMMO(IPEndPoint DFOCJDNDFGL, NOCKMHOHBAI KABMHDMECDK);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KACGICJMLIN(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int ECGAAJFODGN, IPEndPoint EPJJEHDAAFG);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PJJDGIFDOLF(byte[] PHMDIHEJOGG, EndPoint EPJJEHDAAFG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BFGFCJDAAAP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NAAAKGNFLHP : IEquatable<NAAAKGNFLHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long CNGCAPHDEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long LJJIBOHJBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long CPDGBBGFOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int IGOELDFONMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int HJBAKJHHIBP;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEB70", Offset = "0x5CFD570", VA = "0x185CFEB70")]
	public NAAAKGNFLHP(byte[] ENHCCNBGHAP, int JPJDGBKMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x87A9F0", Offset = "0x8793F0", VA = "0x18087A9F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEB30", Offset = "0x5CFD530", VA = "0x185CFEB30", Slot = "4")]
	public bool Equals(NAAAKGNFLHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEA80", Offset = "0x5CFD480", VA = "0x185CFEA80", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class HCKFCGPJLEC : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] MPNEHMBFFAP;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class AGIHDFJJONF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int AKFCLKKEOPD;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85ABD0", VA = "0x18085C1D0")]
	protected AGIHDFJJONF(int DJPNMOLLMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ADENPHMFJBA(IPEndPoint DFOCJDNDFGL, byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AAOEDGBCNIA(IPEndPoint DFOCJDNDFGL, byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ECGLNENJEPP : AGIHDFJJONF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private byte[] NDDCLPHCEEO;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator ACNFGGAHBNP;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE3140", Offset = "0x1FE1B40", VA = "0x181FE3140")]
	public ECGLNENJEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB3B0", Offset = "0x5CE9DB0", VA = "0x185CEB3B0")]
	public void GLLDDHJGPNI(IPEndPoint DFOCJDNDFGL, byte[] NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB560", Offset = "0x5CE9F60", VA = "0x185CEB560")]
	public void HPANOCLNFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAEC0", Offset = "0x5CE98C0", VA = "0x185CEAEC0", Slot = "4")]
	public override void ADENPHMFJBA(IPEndPoint DFOCJDNDFGL, byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAB50", Offset = "0x5CE9550", VA = "0x185CEAB50", Slot = "5")]
	public override void AAOEDGBCNIA(IPEndPoint DFOCJDNDFGL, byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct KHJMIMNCHCP
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void HHIMBKGDABC([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class NPLIKKJNEJD
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static IntPtr JKIOGPPBJID;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static IntPtr DJAPHBDBJLE;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5D00340", Offset = "0x5CFED40", VA = "0x185D00340")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5D00470", Offset = "0x5CFEE70", VA = "0x185D00470")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D00290", Offset = "0x5CFEC90", VA = "0x185D00290")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5D00050", Offset = "0x5CFEA50", VA = "0x185D00050")]
		public unsafe static void APPOJKGPLJE([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private unsafe fixed uint NDDCLPHCEEO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private unsafe fixed uint NOJIAOAEHBN[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private unsafe fixed uint KGCLAONHFNO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private unsafe fixed uint GJIIOIENOPD[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private unsafe fixed uint LLNHEFBPGKD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint PLMBIGKDKPC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint LPGJCCBBLJB[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private uint BKDDPFELLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint BAMOLPIILJE[8];

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBC10", Offset = "0x5CFA610", VA = "0x185CFBC10")]
	private void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBC90", Offset = "0x5CFA690", VA = "0x185CFBC90")]
	private uint MOIBDHMHAOD(uint NJJHKDBJDAC, int HBOKNMMNDGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5CE93D0", Offset = "0x5CE7DD0", VA = "0x185CE93D0")]
	private void PBPPJJHAOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5CE90C0", Offset = "0x5CE7AC0", VA = "0x185CE90C0")]
	private void KFLKOHINFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9030", Offset = "0x5CE7A30", VA = "0x185CE9030")]
	private void DEEHMDKMKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5CE92D0", Offset = "0x5CE7CD0", VA = "0x185CE92D0")]
	private void NBFNNGOMNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB5C0", Offset = "0x5CF9FC0", VA = "0x185CFB5C0")]
	private void AMCBEEJJABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB620", Offset = "0x5CFA020", VA = "0x185CFB620")]
	private unsafe void FOFKAPABNLD(byte* MPCLCEPHNBP, uint* NDDCLPHCEEO, uint* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBAB0", Offset = "0x5CFA4B0", VA = "0x185CFBAB0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void MHLOIJLDHIM([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBB30", Offset = "0x5CFA530", VA = "0x185CFBB30")]
	public static void MHLOIJLDHIM(Span<byte> MPCLCEPHNBP, Span<byte> NDDCLPHCEEO, Span<byte> NOJIAOAEHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBCC0", Offset = "0x5CFA6C0", VA = "0x185CFBCC0")]
	public static void NGBGIGNPNOC(Span<byte> MPCLCEPHNBP, Span<byte> NDDCLPHCEEO, Span<byte> NOJIAOAEHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBA40", Offset = "0x5CFA440", VA = "0x185CFBA40")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LBIMKIEBEGO([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5D005D0", Offset = "0x5CFEFD0", VA = "0x185D005D0")]
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
