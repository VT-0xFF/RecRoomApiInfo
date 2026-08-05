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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x852AA0", VA = "0x1808542A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool PLJODFONKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5CFDCB0", Offset = "0x5CFC4B0", VA = "0x185CFDCB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD210", Offset = "0x5CFBA10", VA = "0x185CFD210")]
		public void RecRoom_SetEncryptionInfo(ulong EJGFKLFDHGB, byte[] NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD1F0", Offset = "0x5CFB9F0", VA = "0x185CFD1F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD0C0", Offset = "0x5CFB8C0", VA = "0x185CFD0C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDBB0", Offset = "0x5CFC3B0", VA = "0x185CFDBB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD3B0", Offset = "0x5CFBBB0", VA = "0x185CFD3B0", Slot = "6")]
		public override void Send(ulong AKMNNFAFMJG, ArraySegment<byte> LINJEFIAFHO, NetworkDelivery AGHHDBDMFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD1B0", Offset = "0x5CFB9B0", VA = "0x185CFD1B0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong AKMNNFAFMJG, [Out] ArraySegment<byte> MIJPDJDOIDB, [Out] float CEHNGMBNDDJ)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD6A0", Offset = "0x5CFBEA0", VA = "0x185CFD6A0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDAD0", Offset = "0x5CFC2D0", VA = "0x185CFDAD0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC7C0", Offset = "0x5CFAFC0", VA = "0x185CFC7C0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong AKMNNFAFMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC670", Offset = "0x5CFAE70", VA = "0x185CFC670", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCC10", Offset = "0x5CFB410", VA = "0x185CFCC10", Slot = "12")]
		public override ulong GetCurrentRtt(ulong AKMNNFAFMJG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CFD630", Offset = "0x5CFBE30", VA = "0x185CFD630", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCDC0", Offset = "0x5CFB5C0", VA = "0x185CFCDC0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LNNCHIMDMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC930", Offset = "0x5CFB130", VA = "0x185CFC930")]
		private ICCCONHPJEP FEPKDBMIKFI(NetworkDelivery NCMHJNKFAGH)
		{
			return default(ICCCONHPJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC5B0", Offset = "0x5CFADB0", VA = "0x185CFC5B0", Slot = "15")]
		private void DCAFEBGCOHA(JODPKGALIPK GFGLGJAIHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCF80", Offset = "0x5CFB780", VA = "0x185CFCF80", Slot = "16")]
		private void NHKGEJAMJFL(JODPKGALIPK GFGLGJAIHDL, ALFHCMJKFDA LOJHBBEJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "17")]
		private void FMJCKHAILMP(IPEndPoint DFOCJDNDFGL, SocketError NCMCEHAHNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCA00", Offset = "0x5CFB200", VA = "0x185CFCA00", Slot = "18")]
		private void GBIEAAHIPBA(JODPKGALIPK GFGLGJAIHDL, MIPIFLBDLJI ELOKBGPKALP, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCCB0", Offset = "0x5CFB4B0", VA = "0x185CFCCB0")]
		private void IOHKDODEHAL(int ECGAAJFODGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "19")]
		private void CDFBPLBHCCM(IPEndPoint EPJJEHDAAFG, MIPIFLBDLJI ELOKBGPKALP, DKCILBKABMM HHFINDLGBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "20")]
		private void BPMGKMEBDHK(JODPKGALIPK GFGLGJAIHDL, int DDJOLKKHIGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC530", Offset = "0x5CFAD30", VA = "0x185CFC530", Slot = "21")]
		private void AOPHNAJBJNP(JKBDFEOFJML GPCNCGBOPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CFCD90", Offset = "0x5CFB590", VA = "0x185CFCD90")]
		private ulong IOJHDMHKFIJ(JODPKGALIPK GFGLGJAIHDL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5CFC590", Offset = "0x5CFAD90", VA = "0x185CFC590")]
		private static int BDFMOIOIABH(float IOCCJIJEELD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5CFDBD0", Offset = "0x5CFC3D0", VA = "0x185CFDBD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CED3E0", Offset = "0x5CEBBE0", VA = "0x185CED3E0")]
	protected FGMMJKMMGFF(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CED2C0", Offset = "0x5CEBAC0", VA = "0x185CED2C0")]
	public void BLEEADHCKKC(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CED320", Offset = "0x5CEBB20", VA = "0x185CED320")]
	protected void KJNKPCOLHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CED3A0", Offset = "0x5CEBBA0", VA = "0x185CED3A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87A9F0", Offset = "0x8791F0", VA = "0x18087A9F0")]
		[CompilerGenerated]
		get
		{
			return default(KEMJBKPPDAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC8B00", Offset = "0xAC7300", VA = "0x180AC8B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF610", Offset = "0x5CEDE10", VA = "0x185CEF610")]
	internal void FLAPIDCACNO(DFAKOGKLBAD PKDGMAJNDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF5E0", Offset = "0x5CEDDE0", VA = "0x185CEF5E0")]
	private bool FGFDNDNBDFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF6D0", Offset = "0x5CEDED0", VA = "0x185CEF6D0")]
	internal JKBDFEOFJML(IPEndPoint EPJJEHDAAFG, DFAKOGKLBAD HKFGBJHGHIP, KGFKNENJKED BLIJFMHBBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF670", Offset = "0x5CEDE70", VA = "0x185CEF670")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CEA9E0", Offset = "0x5CE91E0", VA = "0x185CEA9E0")]
	private DFAKOGKLBAD(long AMBBGLIDMEH, byte BLFENLCKHKK, int DIHIHJFDGDD, byte[] FFFHNCFFBEK, GFNMLBNLGLI LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA580", Offset = "0x5CE8D80", VA = "0x185CEA580")]
	public static int DCILAMDHFJM(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA5E0", Offset = "0x5CE8DE0", VA = "0x185CEA5E0")]
	public static DFAKOGKLBAD KEJAOAAMFCL(BEEFEPJHLGP DNPPEENABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA800", Offset = "0x5CE9000", VA = "0x185CEA800")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFEF40", Offset = "0x5CFD740", VA = "0x185CFEF40")]
	private ODEAAAOAHHA(long AMBBGLIDMEH, byte BLFENLCKHKK, int HEHDMPAEALN, bool DGCCKHFOCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CFED00", Offset = "0x5CFD500", VA = "0x185CFED00")]
	public static ODEAAAOAHHA KEJAOAAMFCL(BEEFEPJHLGP DNPPEENABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEE50", Offset = "0x5CFD650", VA = "0x185CFEE50")]
	public static BEEFEPJHLGP LNJNOCFJFHC(long PAOGCAAHNPJ, byte AGBOJBDOOKK, int GOPAENHEEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEC00", Offset = "0x5CFD400", VA = "0x185CFEC00")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
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
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BJGKOCMEFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x91FDA0", Offset = "0x91E5A0", VA = "0x18091FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x8534E0", VA = "0x180854CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFE530", Offset = "0x5CFCD30", VA = "0x185CFE530")]
	internal MJBCJKFPNMH(KGFKNENJKED PBBKIEJLJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE3D0", Offset = "0x5CFCBD0", VA = "0x185CFE3D0")]
	internal void OMPBMALEMKA(IPEndPoint AGOKLOHOEDJ, BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C29890", Offset = "0x2C28090", VA = "0x182C29890")]
	private void FKIHHFKAOGH<T>(T DNPPEENABEA, IPEndPoint CGKANMHMCOJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE0E0", Offset = "0x5CFC8E0", VA = "0x185CFE0E0")]
	private void LBFBKLGFMIG(KHEMMIJEOLH ODMOGNJJMHL, IPEndPoint AGOKLOHOEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE270", Offset = "0x5CFCA70", VA = "0x185CFE270")]
	private void OEAJOGHGJJJ(HAJGKMHCNJI ODMOGNJJMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDF40", Offset = "0x5CFC740", VA = "0x185CFDF40")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CEB5A0", Offset = "0x5CE9DA0", VA = "0x185CEB5A0")]
	public EHDFDIFLKDE(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MHLLKJCNCBF : EHDFDIFLKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB5A0", Offset = "0x5CE9DA0", VA = "0x185CEB5A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CEA1E0", Offset = "0x5CE89E0", VA = "0x185CEA1E0")]
	private static void KCHINLBHLIN(NMCOAHPDIHB KBFHINCLMII, string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA410", Offset = "0x5CE8C10", VA = "0x185CEA410")]
	internal static void LGCKHHDFDCN(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA470", Offset = "0x5CE8C70", VA = "0x185CEA470")]
	internal static void OCBMDGHCJCO(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA180", Offset = "0x5CE8980", VA = "0x185CEA180")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFDEF0", Offset = "0x5CFC6F0", VA = "0x185CFDEF0")]
	internal MIPIFLBDLJI(KGFKNENJKED GOHDOKCJOFP, NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDE80", Offset = "0x5CFC680", VA = "0x185CFDE80")]
	internal void NNGFPFGNFPO(BEEFEPJHLGP DNPPEENABEA, int MGDPGEEAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDDD0", Offset = "0x5CFC5D0", VA = "0x185CFDDD0")]
	internal void FADOBPNELEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDE50", Offset = "0x5CFC650", VA = "0x185CFDE50")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFEB60", Offset = "0x5CFD360", VA = "0x185CFEB60")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CFEF90", Offset = "0x5CFD790", VA = "0x185CFEF90", Slot = "4")]
		public bool Equals(IPEndPoint IPBJLCONKPC, IPEndPoint FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57BD640", Offset = "0x57BBE40", VA = "0x1857BD640", Slot = "5")]
		public int GetHashCode(IPEndPoint MEAFIMADMKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8C4100", Offset = "0x8C2900", VA = "0x1808C4100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10D95D0", Offset = "0x10D7DD0", VA = "0x1810D95D0")]
		public FMMEPGDICPF(JODPKGALIPK MPPCPDMLBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5CED480", Offset = "0x5CEBC80", VA = "0x185CED480", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5CED4D0", Offset = "0x5CEBCD0", VA = "0x185CED4D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD3060", Offset = "0xBD1860", VA = "0x180BD3060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC825B0", Offset = "0xC80DB0", VA = "0x180C825B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JIGJIJDNFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14D8900", Offset = "0x14D7100", VA = "0x1814D8900")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1808F20", Offset = "0x1807720", VA = "0x181808F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte FFBKFHCEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3A3D0", Offset = "0xA38BD0", VA = "0x180A3A3D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AKFCLKKEOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CF6F40", Offset = "0x5CF5740", VA = "0x185CF6F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short GANEPJJAMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4D00", Offset = "0x5CF3500", VA = "0x185CF4D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7620", Offset = "0x5CF5E20", VA = "0x185CF7620")]
	public void HMIMLGLKIMP(IPEndPoint DFOCJDNDFGL, byte[] NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6DF0", Offset = "0x5CF55F0", VA = "0x185CF6DF0")]
	public void FEAEINHBOKG(IPEndPoint DFOCJDNDFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4350", Offset = "0x5CF2B50", VA = "0x185CF4350")]
	private bool AJLHNOPLLAM(IPEndPoint DFOCJDNDFGL, [Out] JODPKGALIPK GFGLGJAIHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8230", Offset = "0x5CF6A30", VA = "0x185CF8230")]
	private void LGFFPALLOAM(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4DC0", Offset = "0x5CF35C0", VA = "0x185CF4DC0")]
	private void CGBCOJNNOBA(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CF73C0", Offset = "0x5CF5BC0", VA = "0x185CF73C0")]
	private void HHGHPGHFLKC(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAE70", Offset = "0x5CF9670", VA = "0x185CFAE70")]
	public KGFKNENJKED(IHIMDLCJLJM BLIJFMHBBHK, [Optional] AGIHDFJJONF CELMJLIEPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7EC0", Offset = "0x5CF66C0", VA = "0x185CF7EC0")]
	internal void KCCEBGIKDDJ(JODPKGALIPK FNFEJDIAIEO, int DDJOLKKHIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7F10", Offset = "0x5CF6710", VA = "0x185CF7F10")]
	internal void KDKCKJPNBHH(JODPKGALIPK FNFEJDIAIEO, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5580", Offset = "0x5CF3D80", VA = "0x185CF5580")]
	internal void CNNNNDAGEKC(JODPKGALIPK GFGLGJAIHDL, OFGOOMNBBBM NPGFMGMHJJL, SocketError GCPIEKCOBLD, BEEFEPJHLGP BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF99C0", Offset = "0x5CF81C0", VA = "0x185CF99C0")]
	private void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL, OFGOOMNBBBM NPGFMGMHJJL, SocketError GCPIEKCOBLD, bool AMNFMCIBNPO, byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD, BEEFEPJHLGP BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5B40", Offset = "0x5CF4340", VA = "0x185CF5B40")]
	private void DOOLAHCJLEA(NAIBNGPKFLD.DIJHJJBCNEG NCMHJNKFAGH, [Optional] JODPKGALIPK GFGLGJAIHDL, [Optional] IPEndPoint EPJJEHDAAFG, SocketError LBJMNCMBNEA = SocketError.Success, int DDJOLKKHIGA = 0, OFGOOMNBBBM BAFDMNMIECG = OFGOOMNBBBM.ConnectionFailed, [Optional] JKBDFEOFJML MKHEPHFJHOP, ICCCONHPJEP ABGGJFHFFAM = ICCCONHPJEP.Unreliable, byte DOFKDJGAHMN = 0, [Optional] BEEFEPJHLGP CAIFLGNAEAL, [Optional] object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8D40", Offset = "0x5CF7540", VA = "0x185CF8D40")]
	private void NFMAFIEKMLN(NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8500", Offset = "0x5CF6D00", VA = "0x185CF8500")]
	internal void LKDIHIMCPFO(NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA950", Offset = "0x5CF9150", VA = "0x185CFA950")]
	private void PNOOOPOCNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5650", Offset = "0x5CF3E50", VA = "0x185CF5650")]
	private void DFOMFAOCBIH(int ENDANONOIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CF78A0", Offset = "0x5CF60A0", VA = "0x185CF78A0")]
	internal JODPKGALIPK IPGJAJJLEHK(JKBDFEOFJML GPCNCGBOPJG, byte[] HFGMCDELLGN, int GBALKPFEDAI, int OMJPDIKPOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CF96B0", Offset = "0x5CF7EB0", VA = "0x185CF96B0")]
	private int NKGDFPAKAKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5CF6F60", Offset = "0x5CF5760", VA = "0x185CF6F60")]
	private void GHMGHFGDLCF(IPEndPoint EPJJEHDAAFG, JODPKGALIPK LIJMNEKHBMD, DFAKOGKLBAD CMFNCGDHDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5CF60A0", Offset = "0x5CF48A0", VA = "0x185CF60A0")]
	private void FDCHBMGLANG(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8860", Offset = "0x5CF7060", VA = "0x185CF8860")]
	internal void MLMGEGEKALE(BEEFEPJHLGP DNPPEENABEA, ICCCONHPJEP PEDHACINLAG, byte DOFKDJGAHMN, int MGDPGEEAGEM, JODPKGALIPK FNFEJDIAIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9D80", Offset = "0x5CF8580", VA = "0x185CF9D80")]
	public bool PGKLFDNLGPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA5D0", Offset = "0x5CF8DD0", VA = "0x185CFA5D0")]
	public bool PGKLFDNLGPL(IPAddress IIALMAGAFPN, IPAddress BDMFDCMAJOL, int PGLCONBPEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA550", Offset = "0x5CF8D50", VA = "0x185CFA550")]
	public bool PGKLFDNLGPL(int PGLCONBPEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9510", Offset = "0x5CF7D10", VA = "0x185CF9510")]
	public void NGGGEKBLODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4B40", Offset = "0x5CF3340", VA = "0x185CF4B40")]
	public JODPKGALIPK APLKHODBNCD(string ENHCCNBGHAP, int PGLCONBPEID, string NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4C20", Offset = "0x5CF3420", VA = "0x185CF4C20")]
	public JODPKGALIPK APLKHODBNCD(string ENHCCNBGHAP, int PGLCONBPEID, PLNCDKJFIPB MMFHPDKOKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4770", Offset = "0x5CF2F70", VA = "0x185CF4770")]
	public JODPKGALIPK APLKHODBNCD(IPEndPoint CGKANMHMCOJ, PLNCDKJFIPB MMFHPDKOKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA5F0", Offset = "0x5CF8DF0", VA = "0x185CFA5F0")]
	public void PKNIGDBJONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5CFA600", Offset = "0x5CF8E00", VA = "0x185CFA600")]
	public void PKNIGDBJONP(bool GOPGFBOBEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8C40", Offset = "0x5CF7440", VA = "0x185CF8C40")]
	public void MOLGMOLNPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8B20", Offset = "0x5CF7320", VA = "0x185CF8B20")]
	public void MOLGMOLNPLA(byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9AA0", Offset = "0x5CF82A0", VA = "0x185CF9AA0")]
	public void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9900", Offset = "0x5CF8100", VA = "0x185CF9900")]
	public void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL, byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAC90", Offset = "0x5CF9490", VA = "0x185CFAC90", Slot = "4")]
	private IEnumerator<JODPKGALIPK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CFAD20", Offset = "0x5CF9520", VA = "0x185CFAD20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5A50", Offset = "0x5CF4250", VA = "0x185CF5A50")]
	private BEEFEPJHLGP DLMOHFPBAHA(KDJJGPMBBJM FMACLHMOMLJ, int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5970", Offset = "0x5CF4170", VA = "0x185CF5970")]
	private BEEFEPJHLGP DLMOHFPBAHA(KDJJGPMBBJM FMACLHMOMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9B50", Offset = "0x5CF8350", VA = "0x185CF9B50")]
	internal BEEFEPJHLGP OONCCLBCFHE(int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5CF8600", Offset = "0x5CF6E00", VA = "0x185CF8600")]
	internal void LPLEPPGADOO(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFADB0", Offset = "0x5CF95B0", VA = "0x185CFADB0")]
	static KGFKNENJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBD3060", Offset = "0xBD1860", VA = "0x180BD3060")]
	private bool CKCBOLCFHPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9730", Offset = "0x5CF7F30", VA = "0x185CF9730")]
	private void NPENMFDJIGI(IPEndPoint NCPMAKHGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9820", Offset = "0x5CF8020", VA = "0x185CF9820")]
	private void NPFAGLLCIFJ(IPEndPoint NCPMAKHGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5F00", Offset = "0x5CF4700", VA = "0x185CF5F00")]
	private bool EGJJPMOBEJG(SocketException PBAHBFAICPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7F60", Offset = "0x5CF6760", VA = "0x185CF7F60")]
	private void LGEFBHIEOGL(OMAJCMIBHDD PBBKIEJLJNH, EndPoint FBBIDFONLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5CF43E0", Offset = "0x5CF2BE0", VA = "0x185CF43E0")]
	private void AOCKMAOAJCM(object DMDDBNBIFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5CF9D90", Offset = "0x5CF8590", VA = "0x185CF9D90")]
	public bool PGKLFDNLGPL(IPAddress IIALMAGAFPN, IPAddress BDMFDCMAJOL, int PGLCONBPEID, bool FGLNLMOJHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5CF7840", Offset = "0x5CF6040", VA = "0x185CF7840")]
	internal int IIFKOKOAHII(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4E10", Offset = "0x5CF3610", VA = "0x185CF4E10")]
	internal int CLNKOFFKPGC(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5CF4E50", Offset = "0x5CF3650", VA = "0x185CF4E50")]
	internal int CLNKOFFKPGC(byte[] JNNDBFGKHHD, int GBALKPFEDAI, int OMJPDIKPOLO, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5CF5410", Offset = "0x5CF3C10", VA = "0x185CF5410")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE9900", Offset = "0x5CE8100", VA = "0x185CE9900")]
		get
		{
			return default(KDJJGPMBBJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9A00", Offset = "0x5CE8200", VA = "0x185CE9A00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte IGNBHIMKOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9B40", Offset = "0x5CE8340", VA = "0x185CE9B40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9CB0", Offset = "0x5CE84B0", VA = "0x185CE9CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MCGINMOJIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9C50", Offset = "0x5CE8450", VA = "0x185CE9C50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9A70", Offset = "0x5CE8270", VA = "0x185CE9A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GLFGFKOBMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9CF0", Offset = "0x5CE84F0", VA = "0x185CE9CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PCKDKEAAKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9930", Offset = "0x5CE8130", VA = "0x185CE9930")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9A40", Offset = "0x5CE8240", VA = "0x185CE9A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort IJCAIOFMEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5CE99A0", Offset = "0x5CE81A0", VA = "0x185CE99A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9C10", Offset = "0x5CE8410", VA = "0x185CE9C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MGCOCDEEIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9AE0", Offset = "0x5CE82E0", VA = "0x185CE9AE0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9BD0", Offset = "0x5CE83D0", VA = "0x185CE9BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort KIBNOJKCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9B70", Offset = "0x5CE8370", VA = "0x185CE9B70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9960", Offset = "0x5CE8160", VA = "0x185CE9960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9D20", Offset = "0x5CE8520", VA = "0x185CE9D20")]
	static BEEFEPJHLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9AB0", Offset = "0x5CE82B0", VA = "0x185CE9AB0")]
	public void IENDDAGDBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA000", Offset = "0x5CE8800", VA = "0x185CEA000")]
	public BEEFEPJHLGP(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5CEA070", Offset = "0x5CE8870", VA = "0x185CEA070")]
	public BEEFEPJHLGP(KDJJGPMBBJM FMACLHMOMLJ, int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9700", Offset = "0x5CE7F00", VA = "0x185CE9700")]
	public static int ACOEFJELLNG(KDJJGPMBBJM FMACLHMOMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9770", Offset = "0x5CE7F70", VA = "0x185CE9770")]
	public int ACOEFJELLNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9800", Offset = "0x5CE8000", VA = "0x185CE9800")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0xC162E0", Offset = "0xC14AE0", VA = "0x180C162E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0750", Offset = "0x5CEEF50", VA = "0x185CF0750")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint EEMLJHOFNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD870", Offset = "0x8BC070", VA = "0x1808BD870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BOBAGHPNAFL MMHLKJNBMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x130F240", Offset = "0x130DA40", VA = "0x18130F240")]
		get
		{
			return default(BOBAGHPNAFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long NLBFNPKONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85C6D0", VA = "0x18085DED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GMIFIABMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCE5D70", Offset = "0xCE4570", VA = "0x180CE5D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15D70D0", Offset = "0x15D58D0", VA = "0x1815D70D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int IPFMNMMGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5CF0CB0", Offset = "0x5CEF4B0", VA = "0x185CF0CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BMILMHIBOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x860ED0", VA = "0x1808626D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double FNOGAPDHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A63900", Offset = "0x1A62100", VA = "0x181A63900")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KDGCIOEGMLE MNMLKNCPAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2380", Offset = "0x5CF0B80", VA = "0x185CF2380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5CF2BC0", Offset = "0x5CF13C0", VA = "0x185CF2BC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3170", Offset = "0x5CF1970", VA = "0x185CF3170")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, IPEndPoint EPJJEHDAAFG, int DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2FC0", Offset = "0x5CF17C0", VA = "0x185CF2FC0")]
	internal void PHEFPMIKKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0840", Offset = "0x5CEF040", VA = "0x185CF0840")]
	internal void DCJBHLDLKNB(IPEndPoint OPLNBLCPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2430", Offset = "0x5CF0C30", VA = "0x185CF2430")]
	internal void KMJNIDCDOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0BE0", Offset = "0x5CEF3E0", VA = "0x185CF0BE0")]
	private void ENDFKOLAOBA(int MIFKMFBDKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2F00", Offset = "0x5CF1700", VA = "0x185CF2F00")]
	private void OMCOGMIJAHG(int ENCFBNKNPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2D50", Offset = "0x5CF1550", VA = "0x185CF2D50")]
	private FGMMJKMMGFF OGCKGPIHIGO(byte AFLJKADDJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2FE0", Offset = "0x5CF17E0", VA = "0x185CF2FE0")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, IPEndPoint EPJJEHDAAFG, int DKFNFHGODON, byte AGBOJBDOOKK, PLNCDKJFIPB CHKCCGJEIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5CF35D0", Offset = "0x5CF1DD0", VA = "0x185CF35D0")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, JKBDFEOFJML GPCNCGBOPJG, int DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2B70", Offset = "0x5CF1370", VA = "0x185CF2B70")]
	internal void NCFDFFJJMCG(DFAKOGKLBAD FKKDJGKIPPC, byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2F40", Offset = "0x5CF1740", VA = "0x185CF2F40")]
	internal bool OOLIMKHOMCD(ODEAAAOAHHA DNPPEENABEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0CC0", Offset = "0x5CEF4C0", VA = "0x185CF0CC0")]
	public void FKIHHFKAOGH(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, ICCCONHPJEP FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1E30", Offset = "0x5CF0630", VA = "0x185CF1E30")]
	private void HIJFFJAHIIL(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0B30", Offset = "0x5CEF330", VA = "0x185CF0B30")]
	public void EJHDLEPHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5CF2C70", Offset = "0x5CF1470", VA = "0x185CF2C70")]
	internal CGMOCKHNHFL NJHINPDEBNC(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(CGMOCKHNHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5CF13A0", Offset = "0x5CEFBA0", VA = "0x185CF13A0")]
	internal void GGGNGEFPBMP(FGMMJKMMGFF FHBDGPKMKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5CF15C0", Offset = "0x5CEFDC0", VA = "0x185CF15C0")]
	internal BFCMLBMNPDD GKKLPGKFKML(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, bool AMNFMCIBNPO)
	{
		return default(BFCMLBMNPDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0800", Offset = "0x5CEF000", VA = "0x185CF0800")]
	private void CIDPFKEJJJI(int IGDHNHOPGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEFA30", Offset = "0x5CEE230", VA = "0x185CEFA30")]
	internal void AJEBEKCCFEC(ICCCONHPJEP PEDHACINLAG, BEEFEPJHLGP MPPCPDMLBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5CF18D0", Offset = "0x5CF00D0", VA = "0x185CF18D0")]
	private void GOGHKPDNGAJ(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5CF03D0", Offset = "0x5CEEBD0", VA = "0x185CF03D0")]
	private void AOMLALJENLE(int LDGBKFKPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5CF1400", Offset = "0x5CEFC00", VA = "0x185CF1400")]
	internal LALDNDBJFKP GHMGHFGDLCF(DFAKOGKLBAD CMFNCGDHDKO)
	{
		return default(LALDNDBJFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0CF0", Offset = "0x5CEF4F0", VA = "0x185CF0CF0")]
	internal void GAHEDLGEJFB(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF910", Offset = "0x5CEE110", VA = "0x185CEF910")]
	private void AGMIPGHGDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF740", Offset = "0x5CEDF40", VA = "0x185CEF740")]
	internal void AFOEFDJAIMP(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF24C0", Offset = "0x5CF0CC0", VA = "0x185CF24C0")]
	internal void LHGGKPHIKGE(int LDGBKFKPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5CF0870", Offset = "0x5CEF070", VA = "0x185CF0870")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CECDC0", Offset = "0x5CEB5C0", VA = "0x185CECDC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LEPOKCBEOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CECC00", Offset = "0x5CEB400", VA = "0x185CECC00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LDEMILEKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5CECD10", Offset = "0x5CEB510", VA = "0x185CECD10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EGJKMNDIOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5CECD80", Offset = "0x5CEB580", VA = "0x185CECD80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BIPOBBFMHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5CECDD0", Offset = "0x5CEB5D0", VA = "0x185CECDD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long POGDPIOJAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5CECE40", Offset = "0x5CEB640", VA = "0x185CECE40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private OFFMEBAOCCD DOKFAEPHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5CECCF0", Offset = "0x5CEB4F0", VA = "0x185CECCF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double OGCLMDOIGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5CECD20", Offset = "0x5CEB520", VA = "0x185CECD20")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CECDE0", Offset = "0x5CEB5E0", VA = "0x185CECDE0")]
	public void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CECD90", Offset = "0x5CEB590", VA = "0x185CECD90")]
	public void HMICJPJMLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CECE50", Offset = "0x5CEB650", VA = "0x185CECE50")]
	public void PJHHEENNBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CECD00", Offset = "0x5CEB500", VA = "0x185CECD00")]
	public void FGLMDOMNAIJ(long EHGLIIEECOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CECBC0", Offset = "0x5CEB3C0", VA = "0x185CECBC0")]
	public void AENHBKONFFC(long NCLBGIHECPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CECBD0", Offset = "0x5CEB3D0", VA = "0x185CECBD0")]
	public void BJJCOEEOHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CECCB0", Offset = "0x5CEB4B0", VA = "0x185CECCB0")]
	public void DELPNCBFOEK(long KPMACPPLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CECE60", Offset = "0x5CEB660", VA = "0x185CECE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5CECC10", Offset = "0x5CEB410", VA = "0x185CECC10")]
	public void CKOKIAHMMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CEC8E0", Offset = "0x5CEB0E0", VA = "0x185CEC8E0")]
	public static IPEndPoint JAMCJKADIAC(string PPCNIEJPEKK, int PGLCONBPEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC710", Offset = "0x5CEAF10", VA = "0x185CEC710")]
	public static IPAddress FDGPNKJKEDA(string PPCNIEJPEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC680", Offset = "0x5CEAE80", VA = "0x185CEC680")]
	public static IPAddress FDGPNKJKEDA(string PPCNIEJPEKK, AddressFamily EBPPOLJHJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEC650", Offset = "0x5CEAE50", VA = "0x185CEC650")]
	internal static int DIMBMMLGONG(int CNEGAAAMFEO, int NKOKHDBOMFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x29D9F70", Offset = "0x29D8770", VA = "0x1829D9F70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CE9500", Offset = "0x5CE7D00", VA = "0x185CE9500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9420", Offset = "0x5CE7C20", VA = "0x185CE9420")]
		public void EEKIDKGBNNN(BEEFEPJHLGP DNPPEENABEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9490", Offset = "0x5CE7C90", VA = "0x185CE9490")]
		public bool KMBDKADDDCE(long KBAMMELOGGL, JODPKGALIPK GFGLGJAIHDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5CE9440", Offset = "0x5CE7C40", VA = "0x185CE9440")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CEC480", Offset = "0x5CEAC80", VA = "0x185CEC480")]
	public EMPABLNIKLF(JODPKGALIPK GFGLGJAIHDL, bool OOLEDJPJOMF, byte DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB5B0", Offset = "0x5CE9DB0", VA = "0x185CEB5B0")]
	private void FEGMMFOAOEL(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CEBFD0", Offset = "0x5CEA7D0", VA = "0x185CEBFD0", Slot = "4")]
	protected override bool MKJGJDGPJJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB970", Offset = "0x5CEA170", VA = "0x185CEB970", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFC470", Offset = "0x5CFAC70", VA = "0x185CFC470")]
	public LMKMCJJMHIO(JODPKGALIPK GFGLGJAIHDL, bool FPHGDIEDHEP, byte DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBFD0", Offset = "0x5CFA7D0", VA = "0x185CFBFD0", Slot = "4")]
	protected override bool MKJGJDGPJJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBCC0", Offset = "0x5CFA4C0", VA = "0x185CFBCC0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CE8E40", Offset = "0x5CE7640", VA = "0x185CE8E40")]
	private static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, ulong LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5CE95B0", Offset = "0x5CE7DB0", VA = "0x185CE95B0")]
	private static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96A0", Offset = "0x5CE7EA0", VA = "0x185CE96A0")]
	public static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, short LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96E0", Offset = "0x5CE7EE0", VA = "0x185CE96E0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, double JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5CE9620", Offset = "0x5CE7E20", VA = "0x185CE9620")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96A0", Offset = "0x5CE7EA0", VA = "0x185CE96A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, short JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE96A0", Offset = "0x5CE7EA0", VA = "0x185CE96A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, ushort JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE95B0", Offset = "0x5CE7DB0", VA = "0x185CE95B0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE95B0", Offset = "0x5CE7DB0", VA = "0x185CE95B0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, uint JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE95A0", Offset = "0x5CE7DA0", VA = "0x185CE95A0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE95A0", Offset = "0x5CE7DA0", VA = "0x185CE95A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HJCGDEMODCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8CDB30", Offset = "0x8CC330", VA = "0x1808CDB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GCMOLNFPOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5CEF490", Offset = "0x5CEDC90", VA = "0x185CEF490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EKJJHCFOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EC53C0", Offset = "0x1EC3BC0", VA = "0x181EC53C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OCPECKMFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE920", Offset = "0x5CED120", VA = "0x185CEE920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF360", Offset = "0x5CEDB60", VA = "0x185CEF360")]
	public void NNGFPFGNFPO(byte[] LDPKCIGIIMG, int PENDBLHFGOI, int GMGJCNDCIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public GFNMLBNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF4A0", Offset = "0x5CEDCA0", VA = "0x185CEF4A0")]
	public GFNMLBNLGLI(byte[] LDPKCIGIIMG, int PENDBLHFGOI, int GMGJCNDCIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEBE0", Offset = "0x5CED3E0", VA = "0x185CEEBE0")]
	public IPEndPoint GDOCFGOAOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE970", Offset = "0x5CED170", VA = "0x185CEE970")]
	public byte PKKLBLNMIML()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE970", Offset = "0x5CED170", VA = "0x185CEE970")]
	public sbyte BECONKIPHPM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B22FC0", Offset = "0x2B217C0", VA = "0x182B22FC0")]
	public T[] KHIKKEAIICA<T>(ushort ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEAE0", Offset = "0x5CED2E0", VA = "0x185CEEAE0")]
	public bool[] DEAEDOECEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEECB0", Offset = "0x5CED4B0", VA = "0x185CEECB0")]
	public ushort[] GOEINCDEPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF010", Offset = "0x5CED810", VA = "0x185CEF010")]
	public short[] ICBJCKHIEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEB60", Offset = "0x5CED360", VA = "0x185CEEB60")]
	public int[] EPOCFKGLFOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEBA0", Offset = "0x5CED3A0", VA = "0x185CEEBA0")]
	public uint[] FODMFOJPGNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE930", Offset = "0x5CED130", VA = "0x185CEE930")]
	public float[] BDJABFABLKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF450", Offset = "0x5CEDC50", VA = "0x185CEF450")]
	public double[] PGDAGAHBBOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEB20", Offset = "0x5CED320", VA = "0x185CEEB20")]
	public long[] EFOHKABJFLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3A0", Offset = "0x5CEDBA0", VA = "0x185CEF3A0")]
	public ulong[] OIBMNPJCFIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE9B0", Offset = "0x5CED1B0", VA = "0x185CEE9B0")]
	public string[] CPOCJGNOHKC(int KMOHOCIHNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF2B0", Offset = "0x5CEDAB0", VA = "0x185CEF2B0")]
	public bool KLENDAOKIHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5CEED60", Offset = "0x5CED560", VA = "0x185CEED60")]
	public char PBHAKOPGOBD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5CEED60", Offset = "0x5CED560", VA = "0x185CEED60")]
	public ushort IBDBMFOGPNL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF0E0", Offset = "0x5CED8E0", VA = "0x185CEF0E0")]
	public short JBNGFMMIBKH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF190", Offset = "0x5CED990", VA = "0x185CEF190")]
	public long JDDNOHFHAAL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF3E0", Offset = "0x5CEDBE0", VA = "0x185CEF3E0")]
	public ulong OOPKJEPMIOJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF050", Offset = "0x5CED850", VA = "0x185CEF050")]
	public int IHBFIGKDFOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF240", Offset = "0x5CEDA40", VA = "0x185CEF240")]
	public uint KFPAMIGGLPE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEECF0", Offset = "0x5CED4F0", VA = "0x185CEECF0")]
	public float HBAAEIHNOFH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE8B0", Offset = "0x5CED0B0", VA = "0x185CEE8B0")]
	public double AJIJFKNOBOA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5CEEDD0", Offset = "0x5CED5D0", VA = "0x185CEEDD0")]
	public string IBIKDEAMEBM(int KBFGFPLLOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF2F0", Offset = "0x5CEDAF0", VA = "0x185CEF2F0")]
	public ArraySegment<byte> KMLLKFLBLHJ(int IHGHLPOONHD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF150", Offset = "0x5CED950", VA = "0x185CEF150")]
	public sbyte[] JCCELEGMJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF200", Offset = "0x5CEDA00", VA = "0x185CEF200")]
	public byte[] JFHDODIKIAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5CEF0C0", Offset = "0x5CED8C0", VA = "0x185CEF0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85E510", VA = "0x18085FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFD30", Offset = "0x5CFE530", VA = "0x185CFFD30")]
	public PLNCDKJFIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFDB0", Offset = "0x5CFE5B0", VA = "0x185CFFDB0")]
	public PLNCDKJFIPB(bool OBNEJGEPALM, int BFNINGMCNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF000", Offset = "0x5CFD800", VA = "0x185CFF000")]
	public static PLNCDKJFIPB CKKNHLMDGHJ(string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF070", Offset = "0x5CFD870", VA = "0x185CFF070")]
	public void JBDGAIKBLHK(int OBMECBFGAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F3EC80", Offset = "0x1F3D480", VA = "0x181F3EC80")]
	public void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF930", Offset = "0x5CFE130", VA = "0x185CFF930")]
	public void OEEAOMEPNLL(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF8E0", Offset = "0x5CFE0E0", VA = "0x185CFF8E0")]
	public void OEEAOMEPNLL(double JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF9E0", Offset = "0x5CFE1E0", VA = "0x185CFF9E0")]
	public void OEEAOMEPNLL(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF9E0", Offset = "0x5CFE1E0", VA = "0x185CFF9E0")]
	public void OEEAOMEPNLL(ulong JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF7E0", Offset = "0x5CFDFE0", VA = "0x185CFF7E0")]
	public void OEEAOMEPNLL(int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF7E0", Offset = "0x5CFDFE0", VA = "0x185CFF7E0")]
	public void OEEAOMEPNLL(uint JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF870", Offset = "0x5CFE070", VA = "0x185CFF870")]
	public void OEEAOMEPNLL(char JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF870", Offset = "0x5CFE070", VA = "0x185CFF870")]
	public void OEEAOMEPNLL(ushort JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF870", Offset = "0x5CFE070", VA = "0x185CFF870")]
	public void OEEAOMEPNLL(short JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF780", Offset = "0x5CFDF80", VA = "0x185CFF780")]
	public void OEEAOMEPNLL(sbyte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF780", Offset = "0x5CFDF80", VA = "0x185CFF780")]
	public void OEEAOMEPNLL(byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF640", Offset = "0x5CFDE40", VA = "0x185CFF640")]
	public void OEEAOMEPNLL(byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF1F0", Offset = "0x5CFD9F0", VA = "0x185CFF1F0")]
	public void JLECAMKEFBN(sbyte[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF1F0", Offset = "0x5CFD9F0", VA = "0x185CFF1F0")]
	public void MBKHOPAEPMM(byte[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFA30", Offset = "0x5CFE230", VA = "0x185CFFA30")]
	public void OEEAOMEPNLL(bool JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF110", Offset = "0x5CFD910", VA = "0x185CFF110")]
	public void JDMIAFLJLFK(Array GHJMPEDKGHI, int JJPCOKALJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF3A0", Offset = "0x5CFDBA0", VA = "0x185CFF3A0")]
	public void JDMIAFLJLFK(float[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF560", Offset = "0x5CFDD60", VA = "0x185CFF560")]
	public void JDMIAFLJLFK(double[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF560", Offset = "0x5CFDD60", VA = "0x185CFF560")]
	public void JDMIAFLJLFK(long[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF560", Offset = "0x5CFDD60", VA = "0x185CFF560")]
	public void JDMIAFLJLFK(ulong[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF3A0", Offset = "0x5CFDBA0", VA = "0x185CFF3A0")]
	public void JDMIAFLJLFK(int[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF3A0", Offset = "0x5CFDBA0", VA = "0x185CFF3A0")]
	public void JDMIAFLJLFK(uint[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF480", Offset = "0x5CFDC80", VA = "0x185CFF480")]
	public void JDMIAFLJLFK(ushort[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF480", Offset = "0x5CFDC80", VA = "0x185CFF480")]
	public void JDMIAFLJLFK(short[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF1F0", Offset = "0x5CFD9F0", VA = "0x185CFF1F0")]
	public void JDMIAFLJLFK(bool[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF2D0", Offset = "0x5CFDAD0", VA = "0x185CFF2D0")]
	public void JDMIAFLJLFK(string[] JMDCGOKJIDA, int JOICIBAPFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF6B0", Offset = "0x5CFDEB0", VA = "0x185CFF6B0")]
	public void OEEAOMEPNLL(IPEndPoint DFOCJDNDFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5CFF9D0", Offset = "0x5CFE1D0", VA = "0x185CFF9D0")]
	public void OEEAOMEPNLL(string JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5CFFA90", Offset = "0x5CFE290", VA = "0x185CFFA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4772520", Offset = "0x4770D20", VA = "0x184772520")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public JGNLPPMEJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x409B980", Offset = "0x409A180", VA = "0x18409B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
		public GNOJKLLDGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1780", Offset = "0x3CCFF80", VA = "0x183CD1780")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CF39B0", Offset = "0x5CF21B0", VA = "0x185CF39B0")]
	public KAHBNCLFEMA(int KMOHOCIHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x293BE90", Offset = "0x293A690", VA = "0x18293BE90", Slot = "4")]
	protected virtual ulong GLJLINEAPKO<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3800", Offset = "0x5CF2000", VA = "0x185CF3800", Slot = "5")]
	protected virtual ELGPGPGHMJP DMLMFOOODCB(GFNMLBNLGLI ELOKBGPKALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5AD0", Offset = "0x2BF42D0", VA = "0x182BF5AD0", Slot = "6")]
	protected virtual void IICCKAHOGEI<T>(PLNCDKJFIPB JLIOPEDCMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3930", Offset = "0x5CF2130", VA = "0x185CF3930")]
	public void HKCHGOMDLEB(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5A20", Offset = "0x2BF4220", VA = "0x182BF5A20")]
	public void HHIFNKNGNCI<T>(PLNCDKJFIPB JLIOPEDCMBE, T DNPPEENABEA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5CF37B0", Offset = "0x5CF1FB0", VA = "0x185CF37B0")]
	public void BICCFOJGKHF(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CF0", Offset = "0x2BF44F0", VA = "0x182BF5CF0")]
	public void LOKONGJCMHE<T>(Action<T> KMJBEKCGHLD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5B40", Offset = "0x2BF4340", VA = "0x182BF5B40")]
	public void LOKONGJCMHE<T, TUserData>(Action<T, TUserData> KMJBEKCGHLD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HDCEHOFLJAL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB5A0", Offset = "0x5CE9DA0", VA = "0x185CEB5A0")]
	public HDCEHOFLJAL(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MHFBENNBKOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFDD70", Offset = "0x5CFC570", VA = "0x185CFDD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BE84F0", Offset = "0x3BE6CF0", VA = "0x183BE84F0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x4757090", Offset = "0x4755890", VA = "0x184757090", Slot = "7")]
		public override void DIIPPBFNKFP(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x475C9F0", Offset = "0x475B1F0", VA = "0x18475C9F0", Slot = "8")]
		public override void MLDFCKJKEPC(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x475D410", Offset = "0x475BC10", VA = "0x18475D410", Slot = "9")]
		public override void PKJGFMJNCIB(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x475BDB0", Offset = "0x475A5B0", VA = "0x18475BDB0", Slot = "10")]
		public override void GNOLNCNLIAA(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4756EB0", Offset = "0x47556B0", VA = "0x184756EB0")]
		protected TProperty[] DFNHALMGPLE(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x475D2B0", Offset = "0x475BAB0", VA = "0x18475D2B0")]
		protected TProperty[] MOEMJFKCEOI(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4758570", Offset = "0x4756D70", VA = "0x184758570", Slot = "4")]
		public override void EEKIDKGBNNN(MethodInfo KANOEFJDOAC, MethodInfo NFNKOMEBDKF, KONOBGCEHAN NCMHJNKFAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x423F5D0", Offset = "0x423DDD0", VA = "0x18423F5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CC01A0", Offset = "0x3CBE9A0", VA = "0x183CC01A0", Slot = "5")]
		public override void CLAPPBNJGGL(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3CC03C0", Offset = "0x3CBEBC0", VA = "0x183CC03C0", Slot = "6")]
		public override void HHIFNKNGNCI(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0300", Offset = "0x3CBEB00", VA = "0x183CC0300", Slot = "7")]
		public override void DIIPPBFNKFP(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CC04C0", Offset = "0x3CBECC0", VA = "0x183CC04C0", Slot = "8")]
		public override void MLDFCKJKEPC(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0640", Offset = "0x3CBEE40", VA = "0x183CC0640")]
		protected GJGGMAAGHIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class MKGEEPFKHPK<T> : PEAPMPPPPLK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4498B70", Offset = "0x4497370", VA = "0x184498B70", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4498C70", Offset = "0x4497470", VA = "0x184498C70", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4498BF0", Offset = "0x44973F0", VA = "0x184498BF0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x41BBD40", Offset = "0x41BA540", VA = "0x1841BBD40", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public MKGEEPFKHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BJHDBCJMLNI<T> : PEAPMPPPPLK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E2DC20", Offset = "0x4E2C420", VA = "0x184E2DC20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4498C70", Offset = "0x4497470", VA = "0x184498C70", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4E2DCA0", Offset = "0x4E2C4A0", VA = "0x184E2DCA0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x41BBD40", Offset = "0x41BA540", VA = "0x1841BBD40", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public BJHDBCJMLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class PJOHLLLGMEG<T> : PEAPMPPPPLK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x476A580", Offset = "0x4768D80", VA = "0x18476A580", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3805DB0", Offset = "0x38045B0", VA = "0x183805DB0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x476A600", Offset = "0x4768E00", VA = "0x18476A600", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3805E20", Offset = "0x3804620", VA = "0x183805E20", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public PJOHLLLGMEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class EOLPAMJCDMJ<T> : PEAPMPPPPLK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3805CB0", Offset = "0x38044B0", VA = "0x183805CB0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3805DB0", Offset = "0x38045B0", VA = "0x183805DB0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3805D30", Offset = "0x3804530", VA = "0x183805D30", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3805E20", Offset = "0x3804620", VA = "0x183805E20", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public EOLPAMJCDMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NPCJGOEJPLO<T> : PEAPMPPPPLK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x453A650", Offset = "0x4538E50", VA = "0x18453A650", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5720", Offset = "0x3CD3F20", VA = "0x183CD5720", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x453A6D0", Offset = "0x4538ED0", VA = "0x18453A6D0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5790", Offset = "0x3CD3F90", VA = "0x183CD5790", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public NPCJGOEJPLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class GPPCIFIKAOE<T> : PEAPMPPPPLK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5620", Offset = "0x3CD3E20", VA = "0x183CD5620", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5720", Offset = "0x3CD3F20", VA = "0x183CD5720", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CD56A0", Offset = "0x3CD3EA0", VA = "0x183CD56A0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5790", Offset = "0x3CD3F90", VA = "0x183CD5790", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public GPPCIFIKAOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CGDBEJHLLAK<T> : PEAPMPPPPLK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3804A20", Offset = "0x3803220", VA = "0x183804A20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3804B20", Offset = "0x3803320", VA = "0x183804B20", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x51077F0", Offset = "0x5105FF0", VA = "0x1851077F0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3804B90", Offset = "0x3803390", VA = "0x183804B90", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public CGDBEJHLLAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ENHEOJOAPPD<T> : PEAPMPPPPLK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3804A20", Offset = "0x3803220", VA = "0x183804A20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3804B20", Offset = "0x3803320", VA = "0x183804B20", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3804AA0", Offset = "0x38032A0", VA = "0x183804AA0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3804B90", Offset = "0x3803390", VA = "0x183804B90", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public ENHEOJOAPPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KPDLCKGGMDA<T> : PEAPMPPPPLK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41BBBD0", Offset = "0x41BA3D0", VA = "0x1841BBBD0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x41BBCD0", Offset = "0x41BA4D0", VA = "0x1841BBCD0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x41BBC50", Offset = "0x41BA450", VA = "0x1841BBC50", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x41BBD40", Offset = "0x41BA540", VA = "0x1841BBD40", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public KPDLCKGGMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PCGPEMAAMAE<T> : PEAPMPPPPLK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x47516D0", Offset = "0x474FED0", VA = "0x1847516D0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x47517D0", Offset = "0x474FFD0", VA = "0x1847517D0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4751750", Offset = "0x474FF50", VA = "0x184751750", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5790", Offset = "0x3CD3F90", VA = "0x183CD5790", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public PCGPEMAAMAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class LFDNFJMDLPE<T> : PEAPMPPPPLK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4231600", Offset = "0x422FE00", VA = "0x184231600", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4231700", Offset = "0x422FF00", VA = "0x184231700", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4231680", Offset = "0x422FE80", VA = "0x184231680", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3804B90", Offset = "0x3803390", VA = "0x183804B90", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3804C00", Offset = "0x3803400", VA = "0x183804C00")]
		public LFDNFJMDLPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HEBIMOAJFJC<T> : GJGGMAAGHIA<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D05990", Offset = "0x3D04190", VA = "0x183D05990", Slot = "12")]
		protected override void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, char CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D059C0", Offset = "0x3D041C0", VA = "0x183D059C0", Slot = "11")]
		protected override void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] char CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D059F0", Offset = "0x3D041F0", VA = "0x183D059F0")]
		public HEBIMOAJFJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OGADGEMJNMA<T> : GJGGMAAGHIA<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x462CBE0", Offset = "0x462B3E0", VA = "0x18462CBE0", Slot = "12")]
		protected override void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, IPEndPoint CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x462CC10", Offset = "0x462B410", VA = "0x18462CC10", Slot = "11")]
		protected override void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] IPEndPoint CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D059F0", Offset = "0x3D041F0", VA = "0x183D059F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4294820", Offset = "0x4293020", VA = "0x184294820")]
		public LNKKGFHGKNC(int KBFGFPLLOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4294620", Offset = "0x4292E20", VA = "0x184294620", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4294720", Offset = "0x4292F20", VA = "0x184294720", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x42946A0", Offset = "0x4292EA0", VA = "0x1842946A0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x42947A0", Offset = "0x4292FA0", VA = "0x1842947A0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x416B270", Offset = "0x4169A70", VA = "0x18416B270")]
		public KDJCAGMMMIJ(PropertyInfo FMACLHMOMLJ, Type KGDKDOJABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x416AF80", Offset = "0x4169780", VA = "0x18416AF80", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x416B100", Offset = "0x4169900", VA = "0x18416B100", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x416B040", Offset = "0x4169840", VA = "0x18416B040", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x416B1B0", Offset = "0x41699B0", VA = "0x18416B1B0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x416B210", Offset = "0x4169A10", VA = "0x18416B210", Slot = "9")]
		public override void PKJGFMJNCIB(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x416B0A0", Offset = "0x41698A0", VA = "0x18416B0A0", Slot = "10")]
		public override void GNOLNCNLIAA(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KJOIMPHENDL<T> : KDJCAGMMMIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C528C0", Offset = "0x3C510C0", VA = "0x183C528C0")]
		public KJOIMPHENDL(PropertyInfo FMACLHMOMLJ, Type KGDKDOJABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4182440", Offset = "0x4180C40", VA = "0x184182440", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4182500", Offset = "0x4180D00", VA = "0x184182500", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E702B0", Offset = "0x4E6EAB0", VA = "0x184E702B0")]
		public BNBGHEKIIAL(List<FMIMFEIJDCN<T>> FAHLHGGJMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E70200", Offset = "0x4E6EA00", VA = "0x184E70200")]
		public void HHIFNKNGNCI(T MEAFIMADMKA, PLNCDKJFIPB JLIOPEDCMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E70150", Offset = "0x4E6E950", VA = "0x184E70150")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFDCD0", Offset = "0x5CFC4D0", VA = "0x185CFDCD0")]
	public MAJBKIPCDFB(int KMOHOCIHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C100", Offset = "0x2C1A900", VA = "0x182C1C100")]
	private BNBGHEKIIAL<T> MIKKPADLDCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2995C20", Offset = "0x2994420", VA = "0x182995C20")]
	public void JGBCFAKMKJN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C1C060", Offset = "0x2C1A860", VA = "0x182C1C060")]
	public bool DGBBAPGEGII<T>(GFNMLBNLGLI ELOKBGPKALP, T CGKANMHMCOJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C1D210", Offset = "0x2C1BA10", VA = "0x182C1D210")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x851900", VA = "0x180853100")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CED6A0", Offset = "0x5CEBEA0", VA = "0x185CED6A0")]
		get
		{
			return default(GPMKDDJGPMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JODMKGBCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CED520", Offset = "0x5CEBD20", VA = "0x185CED520")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5CEDAA0", Offset = "0x5CEC2A0", VA = "0x185CEDAA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IHFBDOEDAIF FFLGFNAAOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE0D0", Offset = "0x5CEC8D0", VA = "0x185CEE0D0")]
		get
		{
			return default(IHFBDOEDAIF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE1B0", Offset = "0x5CEC9B0", VA = "0x185CEE1B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JHPKPHCHPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE100", Offset = "0x5CEC900", VA = "0x185CEE100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint BPIOALJJJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE130", Offset = "0x5CEC930", VA = "0x185CEE130")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? NJHKEJDIHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5CED670", Offset = "0x5CEBE70", VA = "0x185CED670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KKCPJNEOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CEE0A0", Offset = "0x5CEC8A0", VA = "0x185CEE0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CFIMMEIIMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CED8A0", Offset = "0x5CEC0A0", VA = "0x185CED8A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5CED8D0", Offset = "0x5CEC0D0", VA = "0x185CED8D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DBAGCJPIEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34080", VA = "0x180C35880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA761E0", Offset = "0xA749E0", VA = "0x180A761E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE4E0", Offset = "0x5CECCE0", VA = "0x185CEE4E0")]
	public FNCNBOPEEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE800", Offset = "0x5CED000", VA = "0x185CEE800")]
	internal FNCNBOPEEEO(byte[] DDNKCFIIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5CED550", Offset = "0x5CEBD50", VA = "0x185CED550")]
	public static FNCNBOPEEEO AKJCFLGKCBK(byte[] DDNKCFIIBGP, DateTime FAPMGBCFHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDBD0", Offset = "0x5CEC3D0", VA = "0x185CEDBD0")]
	internal void KKJJCEGIAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE1F0", Offset = "0x5CEC9F0", VA = "0x185CEE1F0")]
	private void OEGGEOBKOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDEA0", Offset = "0x5CEC6A0", VA = "0x185CEDEA0")]
	private DateTime? KMGLOGEADLP(int PENDBLHFGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5CED6D0", Offset = "0x5CEBED0", VA = "0x185CED6D0")]
	private void CIAFLFKPMKO(int PENDBLHFGOI, DateTime? JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDDD0", Offset = "0x5CEC5D0", VA = "0x185CEDDD0")]
	private ulong KKNBONJLPPI(int PENDBLHFGOI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5CEE3C0", Offset = "0x5CECBC0", VA = "0x185CEE3C0")]
	private void PCNHLGNKGCE(int PENDBLHFGOI, ulong JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDB40", Offset = "0x5CEC340", VA = "0x185CEDB40")]
	private uint KCFOGMBIODO(int PENDBLHFGOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BBE6F0", Offset = "0x5BBCEF0", VA = "0x185BBE6F0")]
	private static uint JILBPPCAONO(uint IPBJLCONKPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDAE0", Offset = "0x5CEC2E0", VA = "0x185CEDAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CED2B0", Offset = "0x5CEBAB0", VA = "0x185CED2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5CED1C0", Offset = "0x5CEB9C0", VA = "0x185CED1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5CF3B50", Offset = "0x5CF2350", VA = "0x185CF3B50", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int ANBBECBIOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5CF3B70", Offset = "0x5CF2370", VA = "0x185CF3B70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint IDFDBCPNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5CF4190", Offset = "0x5CF2990", VA = "0x185CF4190", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HNCFNIEAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x4217F70", Offset = "0x4216770", VA = "0x184217F70", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5CF42A0", Offset = "0x5CF2AA0", VA = "0x185CF42A0")]
	public KDLNGIHHHLK(AddressFamily EBPPOLJHJFO, KGFKNENJKED GENLECEPGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3BD0", Offset = "0x5CF23D0", VA = "0x185CF3BD0", Slot = "8")]
	public bool KEPICDLKMMO(IPEndPoint DFOCJDNDFGL, NOCKMHOHBAI KABMHDMECDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3B90", Offset = "0x5CF2390", VA = "0x185CF3B90", Slot = "9")]
	public int KACGICJMLIN(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int ECGAAJFODGN, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5CF41B0", Offset = "0x5CF29B0", VA = "0x185CF41B0", Slot = "10")]
	public int PJJDGIFDOLF(byte[] PHMDIHEJOGG, EndPoint NJMLADNIIBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5CF3B30", Offset = "0x5CF2330", VA = "0x185CF3B30", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFEA70", Offset = "0x5CFD270", VA = "0x185CFEA70")]
	public NAAAKGNFLHP(byte[] ENHCCNBGHAP, int JPJDGBKMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x87A9F0", Offset = "0x8791F0", VA = "0x18087A9F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5CFEA30", Offset = "0x5CFD230", VA = "0x185CFEA30", Slot = "4")]
	public bool Equals(NAAAKGNFLHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5CFE980", Offset = "0x5CFD180", VA = "0x185CFE980", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85A9D0", VA = "0x18085C1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FE3140", Offset = "0x1FE1940", VA = "0x181FE3140")]
	public ECGLNENJEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB2B0", Offset = "0x5CE9AB0", VA = "0x185CEB2B0")]
	public void GLLDDHJGPNI(IPEndPoint DFOCJDNDFGL, byte[] NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5CEB460", Offset = "0x5CE9C60", VA = "0x185CEB460")]
	public void HPANOCLNFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5CEADC0", Offset = "0x5CE95C0", VA = "0x185CEADC0", Slot = "4")]
	public override void ADENPHMFJBA(IPEndPoint DFOCJDNDFGL, byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5CEAA50", Offset = "0x5CE9250", VA = "0x185CEAA50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D00240", Offset = "0x5CFEA40", VA = "0x185D00240")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5D00370", Offset = "0x5CFEB70", VA = "0x185D00370")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D00190", Offset = "0x5CFE990", VA = "0x185D00190")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5CFFF50", Offset = "0x5CFE750", VA = "0x185CFFF50")]
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
	[Cpp2IlInjected.Address(RVA = "0x5CFBB10", Offset = "0x5CFA310", VA = "0x185CFBB10")]
	private void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBB90", Offset = "0x5CFA390", VA = "0x185CFBB90")]
	private uint MOIBDHMHAOD(uint NJJHKDBJDAC, int HBOKNMMNDGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5CE92D0", Offset = "0x5CE7AD0", VA = "0x185CE92D0")]
	private void PBPPJJHAOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8FC0", Offset = "0x5CE77C0", VA = "0x185CE8FC0")]
	private void KFLKOHINFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5CE8F30", Offset = "0x5CE7730", VA = "0x185CE8F30")]
	private void DEEHMDKMKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5CE91D0", Offset = "0x5CE79D0", VA = "0x185CE91D0")]
	private void NBFNNGOMNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB4C0", Offset = "0x5CF9CC0", VA = "0x185CFB4C0")]
	private void AMCBEEJJABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB520", Offset = "0x5CF9D20", VA = "0x185CFB520")]
	private unsafe void FOFKAPABNLD(byte* MPCLCEPHNBP, uint* NDDCLPHCEEO, uint* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB9B0", Offset = "0x5CFA1B0", VA = "0x185CFB9B0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void MHLOIJLDHIM([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBA30", Offset = "0x5CFA230", VA = "0x185CFBA30")]
	public static void MHLOIJLDHIM(Span<byte> MPCLCEPHNBP, Span<byte> NDDCLPHCEEO, Span<byte> NOJIAOAEHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5CFBBC0", Offset = "0x5CFA3C0", VA = "0x185CFBBC0")]
	public static void NGBGIGNPNOC(Span<byte> MPCLCEPHNBP, Span<byte> NDDCLPHCEEO, Span<byte> NOJIAOAEHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5CFB940", Offset = "0x5CFA140", VA = "0x185CFB940")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LBIMKIEBEGO([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5D004D0", Offset = "0x5CFECD0", VA = "0x185D004D0")]
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
