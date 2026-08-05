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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8542A0", Offset = "0x8534A0", VA = "0x1808542A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool PLJODFONKGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D174E0", Offset = "0x5D166E0", VA = "0x185D174E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D16A40", Offset = "0x5D15C40", VA = "0x185D16A40")]
		public void RecRoom_SetEncryptionInfo(ulong EJGFKLFDHGB, byte[] NDDCLPHCEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D16A20", Offset = "0x5D15C20", VA = "0x185D16A20")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D168F0", Offset = "0x5D15AF0", VA = "0x185D168F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D173E0", Offset = "0x5D165E0", VA = "0x185D173E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D16BE0", Offset = "0x5D15DE0", VA = "0x185D16BE0", Slot = "6")]
		public override void Send(ulong AKMNNFAFMJG, ArraySegment<byte> LINJEFIAFHO, NetworkDelivery AGHHDBDMFCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D169E0", Offset = "0x5D15BE0", VA = "0x185D169E0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong AKMNNFAFMJG, [Out] ArraySegment<byte> MIJPDJDOIDB, [Out] float CEHNGMBNDDJ)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D16ED0", Offset = "0x5D160D0", VA = "0x185D16ED0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D17300", Offset = "0x5D16500", VA = "0x185D17300", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D15FF0", Offset = "0x5D151F0", VA = "0x185D15FF0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong AKMNNFAFMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D15EA0", Offset = "0x5D150A0", VA = "0x185D15EA0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D16440", Offset = "0x5D15640", VA = "0x185D16440", Slot = "12")]
		public override ulong GetCurrentRtt(ulong AKMNNFAFMJG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D16E60", Offset = "0x5D16060", VA = "0x185D16E60", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D165F0", Offset = "0x5D157F0", VA = "0x185D165F0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager LNNCHIMDMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D16160", Offset = "0x5D15360", VA = "0x185D16160")]
		private ICCCONHPJEP FEPKDBMIKFI(NetworkDelivery NCMHJNKFAGH)
		{
			return default(ICCCONHPJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D15DE0", Offset = "0x5D14FE0", VA = "0x185D15DE0", Slot = "15")]
		private void DCAFEBGCOHA(JODPKGALIPK GFGLGJAIHDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D167B0", Offset = "0x5D159B0", VA = "0x185D167B0", Slot = "16")]
		private void NHKGEJAMJFL(JODPKGALIPK GFGLGJAIHDL, ALFHCMJKFDA LOJHBBEJFPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "17")]
		private void FMJCKHAILMP(IPEndPoint DFOCJDNDFGL, SocketError NCMCEHAHNIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D16230", Offset = "0x5D15430", VA = "0x185D16230", Slot = "18")]
		private void GBIEAAHIPBA(JODPKGALIPK GFGLGJAIHDL, MIPIFLBDLJI ELOKBGPKALP, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D164E0", Offset = "0x5D156E0", VA = "0x185D164E0")]
		private void IOHKDODEHAL(int ECGAAJFODGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "19")]
		private void CDFBPLBHCCM(IPEndPoint EPJJEHDAAFG, MIPIFLBDLJI ELOKBGPKALP, DKCILBKABMM HHFINDLGBJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "20")]
		private void BPMGKMEBDHK(JODPKGALIPK GFGLGJAIHDL, int DDJOLKKHIGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D15D60", Offset = "0x5D14F60", VA = "0x185D15D60", Slot = "21")]
		private void AOPHNAJBJNP(JKBDFEOFJML GPCNCGBOPJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D165C0", Offset = "0x5D157C0", VA = "0x185D165C0")]
		private ulong IOJHDMHKFIJ(JODPKGALIPK GFGLGJAIHDL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D15DC0", Offset = "0x5D14FC0", VA = "0x185D15DC0")]
		private static int BDFMOIOIABH(float IOCCJIJEELD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D17400", Offset = "0x5D16600", VA = "0x185D17400")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D06AA0", Offset = "0x5D05CA0", VA = "0x185D06AA0")]
	protected FGMMJKMMGFF(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D06980", Offset = "0x5D05B80", VA = "0x185D06980")]
	public void BLEEADHCKKC(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D069E0", Offset = "0x5D05BE0", VA = "0x185D069E0")]
	protected void KJNKPCOLHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D06A60", Offset = "0x5D05C60", VA = "0x185D06A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x87A900", Offset = "0x879B00", VA = "0x18087A900")]
		[CompilerGenerated]
		get
		{
			return default(KEMJBKPPDAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC9BB0", Offset = "0xAC8DB0", VA = "0x180AC9BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D08CD0", Offset = "0x5D07ED0", VA = "0x185D08CD0")]
	internal void FLAPIDCACNO(DFAKOGKLBAD PKDGMAJNDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D08CA0", Offset = "0x5D07EA0", VA = "0x185D08CA0")]
	private bool FGFDNDNBDFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D08D90", Offset = "0x5D07F90", VA = "0x185D08D90")]
	internal JKBDFEOFJML(IPEndPoint EPJJEHDAAFG, DFAKOGKLBAD HKFGBJHGHIP, KGFKNENJKED BLIJFMHBBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D08D30", Offset = "0x5D07F30", VA = "0x185D08D30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D040E0", Offset = "0x5D032E0", VA = "0x185D040E0")]
	private DFAKOGKLBAD(long AMBBGLIDMEH, byte BLFENLCKHKK, int DIHIHJFDGDD, byte[] FFFHNCFFBEK, GFNMLBNLGLI LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D03C80", Offset = "0x5D02E80", VA = "0x185D03C80")]
	public static int DCILAMDHFJM(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D03CE0", Offset = "0x5D02EE0", VA = "0x185D03CE0")]
	public static DFAKOGKLBAD KEJAOAAMFCL(BEEFEPJHLGP DNPPEENABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D03F00", Offset = "0x5D03100", VA = "0x185D03F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D18770", Offset = "0x5D17970", VA = "0x185D18770")]
	private ODEAAAOAHHA(long AMBBGLIDMEH, byte BLFENLCKHKK, int HEHDMPAEALN, bool DGCCKHFOCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D18530", Offset = "0x5D17730", VA = "0x185D18530")]
	public static ODEAAAOAHHA KEJAOAAMFCL(BEEFEPJHLGP DNPPEENABEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D18680", Offset = "0x5D17880", VA = "0x185D18680")]
	public static BEEFEPJHLGP LNJNOCFJFHC(long PAOGCAAHNPJ, byte AGBOJBDOOKK, int GOPAENHEEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D18430", Offset = "0x5D17630", VA = "0x185D18430")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
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
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
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
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8522F0", VA = "0x1808530F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BJGKOCMEFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x920B50", Offset = "0x91FD50", VA = "0x180920B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x854CE0", Offset = "0x853EE0", VA = "0x180854CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D17D60", Offset = "0x5D16F60", VA = "0x185D17D60")]
	internal MJBCJKFPNMH(KGFKNENJKED PBBKIEJLJNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C00", Offset = "0x5D16E00", VA = "0x185D17C00")]
	internal void OMPBMALEMKA(IPEndPoint AGOKLOHOEDJ, BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C383A0", Offset = "0x2C375A0", VA = "0x182C383A0")]
	private void FKIHHFKAOGH<T>(T DNPPEENABEA, IPEndPoint CGKANMHMCOJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D17910", Offset = "0x5D16B10", VA = "0x185D17910")]
	private void LBFBKLGFMIG(KHEMMIJEOLH ODMOGNJJMHL, IPEndPoint AGOKLOHOEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D17AA0", Offset = "0x5D16CA0", VA = "0x185D17AA0")]
	private void OEAJOGHGJJJ(HAJGKMHCNJI ODMOGNJJMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D17770", Offset = "0x5D16970", VA = "0x185D17770")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D04C60", Offset = "0x5D03E60", VA = "0x185D04C60")]
	public EHDFDIFLKDE(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MHLLKJCNCBF : EHDFDIFLKDE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D04C60", Offset = "0x5D03E60", VA = "0x185D04C60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D038E0", Offset = "0x5D02AE0", VA = "0x185D038E0")]
	private static void KCHINLBHLIN(NMCOAHPDIHB KBFHINCLMII, string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D03B10", Offset = "0x5D02D10", VA = "0x185D03B10")]
	internal static void LGCKHHDFDCN(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D03B70", Offset = "0x5D02D70", VA = "0x185D03B70")]
	internal static void OCBMDGHCJCO(string GMHAEBALLKB, params object[] FJCOFFFFCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D03880", Offset = "0x5D02A80", VA = "0x185D03880")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D17720", Offset = "0x5D16920", VA = "0x185D17720")]
	internal MIPIFLBDLJI(KGFKNENJKED GOHDOKCJOFP, NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D176B0", Offset = "0x5D168B0", VA = "0x185D176B0")]
	internal void NNGFPFGNFPO(BEEFEPJHLGP DNPPEENABEA, int MGDPGEEAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D17600", Offset = "0x5D16800", VA = "0x185D17600")]
	internal void FADOBPNELEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D17680", Offset = "0x5D16880", VA = "0x185D17680")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D18390", Offset = "0x5D17590", VA = "0x185D18390")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D187C0", Offset = "0x5D179C0", VA = "0x185D187C0", Slot = "4")]
		public bool Equals(IPEndPoint IPBJLCONKPC, IPEndPoint FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57DA6B0", Offset = "0x57D98B0", VA = "0x1857DA6B0", Slot = "5")]
		public int GetHashCode(IPEndPoint MEAFIMADMKA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
			[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8C3F40", Offset = "0x8C3140", VA = "0x1808C3F40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10DC130", Offset = "0x10DB330", VA = "0x1810DC130")]
		public FMMEPGDICPF(JODPKGALIPK MPPCPDMLBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D06B40", Offset = "0x5D05D40", VA = "0x185D06B40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D06B90", Offset = "0x5D05D90", VA = "0x185D06B90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xBD42F0", Offset = "0xBD34F0", VA = "0x180BD42F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC83870", Offset = "0xC82A70", VA = "0x180C83870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JIGJIJDNFNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14EFE90", Offset = "0x14EF090", VA = "0x1814EFE90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x18129D0", Offset = "0x1811BD0", VA = "0x1818129D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte FFBKFHCEAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3B390", Offset = "0xA3A590", VA = "0x180A3B390")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AKFCLKKEOPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D10770", Offset = "0x5D0F970", VA = "0x185D10770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short GANEPJJAMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0E530", Offset = "0x5D0D730", VA = "0x185D0E530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D10E50", Offset = "0x5D10050", VA = "0x185D10E50")]
	public void HMIMLGLKIMP(IPEndPoint DFOCJDNDFGL, byte[] NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D10620", Offset = "0x5D0F820", VA = "0x185D10620")]
	public void FEAEINHBOKG(IPEndPoint DFOCJDNDFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DB80", Offset = "0x5D0CD80", VA = "0x185D0DB80")]
	private bool AJLHNOPLLAM(IPEndPoint DFOCJDNDFGL, [Out] JODPKGALIPK GFGLGJAIHDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D11A60", Offset = "0x5D10C60", VA = "0x185D11A60")]
	private void LGFFPALLOAM(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E5F0", Offset = "0x5D0D7F0", VA = "0x185D0E5F0")]
	private void CGBCOJNNOBA(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D10BF0", Offset = "0x5D0FDF0", VA = "0x185D10BF0")]
	private void HHGHPGHFLKC(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D146A0", Offset = "0x5D138A0", VA = "0x185D146A0")]
	public KGFKNENJKED(IHIMDLCJLJM BLIJFMHBBHK, [Optional] AGIHDFJJONF CELMJLIEPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D116F0", Offset = "0x5D108F0", VA = "0x185D116F0")]
	internal void KCCEBGIKDDJ(JODPKGALIPK FNFEJDIAIEO, int DDJOLKKHIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D11740", Offset = "0x5D10940", VA = "0x185D11740")]
	internal void KDKCKJPNBHH(JODPKGALIPK FNFEJDIAIEO, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EDB0", Offset = "0x5D0DFB0", VA = "0x185D0EDB0")]
	internal void CNNNNDAGEKC(JODPKGALIPK GFGLGJAIHDL, OFGOOMNBBBM NPGFMGMHJJL, SocketError GCPIEKCOBLD, BEEFEPJHLGP BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D131F0", Offset = "0x5D123F0", VA = "0x185D131F0")]
	private void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL, OFGOOMNBBBM NPGFMGMHJJL, SocketError GCPIEKCOBLD, bool AMNFMCIBNPO, byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD, BEEFEPJHLGP BGEDEFLEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F370", Offset = "0x5D0E570", VA = "0x185D0F370")]
	private void DOOLAHCJLEA(NAIBNGPKFLD.DIJHJJBCNEG NCMHJNKFAGH, [Optional] JODPKGALIPK GFGLGJAIHDL, [Optional] IPEndPoint EPJJEHDAAFG, SocketError LBJMNCMBNEA = SocketError.Success, int DDJOLKKHIGA = 0, OFGOOMNBBBM BAFDMNMIECG = OFGOOMNBBBM.ConnectionFailed, [Optional] JKBDFEOFJML MKHEPHFJHOP, ICCCONHPJEP ABGGJFHFFAM = ICCCONHPJEP.Unreliable, byte DOFKDJGAHMN = 0, [Optional] BEEFEPJHLGP CAIFLGNAEAL, [Optional] object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D12570", Offset = "0x5D11770", VA = "0x185D12570")]
	private void NFMAFIEKMLN(NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D11D30", Offset = "0x5D10F30", VA = "0x185D11D30")]
	internal void LKDIHIMCPFO(NAIBNGPKFLD KOGADNBNHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D14180", Offset = "0x5D13380", VA = "0x185D14180")]
	private void PNOOOPOCNFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EE80", Offset = "0x5D0E080", VA = "0x185D0EE80")]
	private void DFOMFAOCBIH(int ENDANONOIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D110D0", Offset = "0x5D102D0", VA = "0x185D110D0")]
	internal JODPKGALIPK IPGJAJJLEHK(JKBDFEOFJML GPCNCGBOPJG, byte[] HFGMCDELLGN, int GBALKPFEDAI, int OMJPDIKPOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D12EE0", Offset = "0x5D120E0", VA = "0x185D12EE0")]
	private int NKGDFPAKAKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D10790", Offset = "0x5D0F990", VA = "0x185D10790")]
	private void GHMGHFGDLCF(IPEndPoint EPJJEHDAAFG, JODPKGALIPK LIJMNEKHBMD, DFAKOGKLBAD CMFNCGDHDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F8D0", Offset = "0x5D0EAD0", VA = "0x185D0F8D0")]
	private void FDCHBMGLANG(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D12090", Offset = "0x5D11290", VA = "0x185D12090")]
	internal void MLMGEGEKALE(BEEFEPJHLGP DNPPEENABEA, ICCCONHPJEP PEDHACINLAG, byte DOFKDJGAHMN, int MGDPGEEAGEM, JODPKGALIPK FNFEJDIAIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D135B0", Offset = "0x5D127B0", VA = "0x185D135B0")]
	public bool PGKLFDNLGPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D13E00", Offset = "0x5D13000", VA = "0x185D13E00")]
	public bool PGKLFDNLGPL(IPAddress IIALMAGAFPN, IPAddress BDMFDCMAJOL, int PGLCONBPEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D13D80", Offset = "0x5D12F80", VA = "0x185D13D80")]
	public bool PGKLFDNLGPL(int PGLCONBPEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D12D40", Offset = "0x5D11F40", VA = "0x185D12D40")]
	public void NGGGEKBLODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E370", Offset = "0x5D0D570", VA = "0x185D0E370")]
	public JODPKGALIPK APLKHODBNCD(string ENHCCNBGHAP, int PGLCONBPEID, string NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E450", Offset = "0x5D0D650", VA = "0x185D0E450")]
	public JODPKGALIPK APLKHODBNCD(string ENHCCNBGHAP, int PGLCONBPEID, PLNCDKJFIPB MMFHPDKOKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DFA0", Offset = "0x5D0D1A0", VA = "0x185D0DFA0")]
	public JODPKGALIPK APLKHODBNCD(IPEndPoint CGKANMHMCOJ, PLNCDKJFIPB MMFHPDKOKJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D13E20", Offset = "0x5D13020", VA = "0x185D13E20")]
	public void PKNIGDBJONP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D13E30", Offset = "0x5D13030", VA = "0x185D13E30")]
	public void PKNIGDBJONP(bool GOPGFBOBEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D12470", Offset = "0x5D11670", VA = "0x185D12470")]
	public void MOLGMOLNPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D12350", Offset = "0x5D11550", VA = "0x185D12350")]
	public void MOLGMOLNPLA(byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D132D0", Offset = "0x5D124D0", VA = "0x185D132D0")]
	public void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D13130", Offset = "0x5D12330", VA = "0x185D13130")]
	public void OICPJNHEBNK(JODPKGALIPK GFGLGJAIHDL, byte[] LINJEFIAFHO, int GBALKPFEDAI, int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D144C0", Offset = "0x5D136C0", VA = "0x185D144C0", Slot = "4")]
	private IEnumerator<JODPKGALIPK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D14550", Offset = "0x5D13750", VA = "0x185D14550", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F280", Offset = "0x5D0E480", VA = "0x185D0F280")]
	private BEEFEPJHLGP DLMOHFPBAHA(KDJJGPMBBJM FMACLHMOMLJ, int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F1A0", Offset = "0x5D0E3A0", VA = "0x185D0F1A0")]
	private BEEFEPJHLGP DLMOHFPBAHA(KDJJGPMBBJM FMACLHMOMLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D13380", Offset = "0x5D12580", VA = "0x185D13380")]
	internal BEEFEPJHLGP OONCCLBCFHE(int ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D11E30", Offset = "0x5D11030", VA = "0x185D11E30")]
	internal void LPLEPPGADOO(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D145E0", Offset = "0x5D137E0", VA = "0x185D145E0")]
	static KGFKNENJKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBD42F0", Offset = "0xBD34F0", VA = "0x180BD42F0")]
	private bool CKCBOLCFHPM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D12F60", Offset = "0x5D12160", VA = "0x185D12F60")]
	private void NPENMFDJIGI(IPEndPoint NCPMAKHGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D13050", Offset = "0x5D12250", VA = "0x185D13050")]
	private void NPFAGLLCIFJ(IPEndPoint NCPMAKHGDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D0F730", Offset = "0x5D0E930", VA = "0x185D0F730")]
	private bool EGJJPMOBEJG(SocketException PBAHBFAICPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D11790", Offset = "0x5D10990", VA = "0x185D11790")]
	private void LGEFBHIEOGL(OMAJCMIBHDD PBBKIEJLJNH, EndPoint FBBIDFONLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DC10", Offset = "0x5D0CE10", VA = "0x185D0DC10")]
	private void AOCKMAOAJCM(object DMDDBNBIFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D135C0", Offset = "0x5D127C0", VA = "0x185D135C0")]
	public bool PGKLFDNLGPL(IPAddress IIALMAGAFPN, IPAddress BDMFDCMAJOL, int PGLCONBPEID, bool FGLNLMOJHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D11070", Offset = "0x5D10270", VA = "0x185D11070")]
	internal int IIFKOKOAHII(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E640", Offset = "0x5D0D840", VA = "0x185D0E640")]
	internal int CLNKOFFKPGC(BEEFEPJHLGP DNPPEENABEA, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D0E680", Offset = "0x5D0D880", VA = "0x185D0E680")]
	internal int CLNKOFFKPGC(byte[] JNNDBFGKHHD, int GBALKPFEDAI, int OMJPDIKPOLO, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D0EC40", Offset = "0x5D0DE40", VA = "0x185D0EC40")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D03000", Offset = "0x5D02200", VA = "0x185D03000")]
		get
		{
			return default(KDJJGPMBBJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D03100", Offset = "0x5D02300", VA = "0x185D03100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte IGNBHIMKOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D03240", Offset = "0x5D02440", VA = "0x185D03240")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D033B0", Offset = "0x5D025B0", VA = "0x185D033B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort MCGINMOJIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D03350", Offset = "0x5D02550", VA = "0x185D03350")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D03170", Offset = "0x5D02370", VA = "0x185D03170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GLFGFKOBMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D033F0", Offset = "0x5D025F0", VA = "0x185D033F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte PCKDKEAAKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D03030", Offset = "0x5D02230", VA = "0x185D03030")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D03140", Offset = "0x5D02340", VA = "0x185D03140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort IJCAIOFMEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D030A0", Offset = "0x5D022A0", VA = "0x185D030A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D03310", Offset = "0x5D02510", VA = "0x185D03310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MGCOCDEEIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D031E0", Offset = "0x5D023E0", VA = "0x185D031E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D032D0", Offset = "0x5D024D0", VA = "0x185D032D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort KIBNOJKCFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D03270", Offset = "0x5D02470", VA = "0x185D03270")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D03060", Offset = "0x5D02260", VA = "0x185D03060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D03420", Offset = "0x5D02620", VA = "0x185D03420")]
	static BEEFEPJHLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D031B0", Offset = "0x5D023B0", VA = "0x185D031B0")]
	public void IENDDAGDBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D03700", Offset = "0x5D02900", VA = "0x185D03700")]
	public BEEFEPJHLGP(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D03770", Offset = "0x5D02970", VA = "0x185D03770")]
	public BEEFEPJHLGP(KDJJGPMBBJM FMACLHMOMLJ, int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D02E00", Offset = "0x5D02000", VA = "0x185D02E00")]
	public static int ACOEFJELLNG(KDJJGPMBBJM FMACLHMOMLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D02E70", Offset = "0x5D02070", VA = "0x185D02E70")]
	public int ACOEFJELLNG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D02F00", Offset = "0x5D02100", VA = "0x185D02F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0xC17570", Offset = "0xC16770", VA = "0x180C17570")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D09E10", Offset = "0x5D09010", VA = "0x185D09E10")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint EEMLJHOFNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BD6B0", Offset = "0x8BC8B0", VA = "0x1808BD6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BOBAGHPNAFL MMHLKJNBMGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1312780", Offset = "0x1311980", VA = "0x181312780")]
		get
		{
			return default(BOBAGHPNAFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long NLBFNPKONMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85DED0", Offset = "0x85D0D0", VA = "0x18085DED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GMIFIABMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCE70B0", Offset = "0xCE62B0", VA = "0x180CE70B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15DE4C0", Offset = "0x15DD6C0", VA = "0x1815DE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int IPFMNMMGNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D0A370", Offset = "0x5D09570", VA = "0x185D0A370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BMILMHIBOJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8626D0", Offset = "0x8618D0", VA = "0x1808626D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double FNOGAPDHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A6D830", Offset = "0x1A6CA30", VA = "0x181A6D830")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KDGCIOEGMLE MNMLKNCPAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BA40", Offset = "0x5D0AC40", VA = "0x185D0BA40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D0C3F0", Offset = "0x5D0B5F0", VA = "0x185D0C3F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C9A0", Offset = "0x5D0BBA0", VA = "0x185D0C9A0")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, IPEndPoint EPJJEHDAAFG, int DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C7F0", Offset = "0x5D0B9F0", VA = "0x185D0C7F0")]
	internal void PHEFPMIKKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D09F00", Offset = "0x5D09100", VA = "0x185D09F00")]
	internal void DCJBHLDLKNB(IPEndPoint OPLNBLCPJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BAF0", Offset = "0x5D0ACF0", VA = "0x185D0BAF0")]
	internal void KMJNIDCDOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A2A0", Offset = "0x5D094A0", VA = "0x185D0A2A0")]
	private void ENDFKOLAOBA(int MIFKMFBDKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C730", Offset = "0x5D0B930", VA = "0x185D0C730")]
	private void OMCOGMIJAHG(int ENCFBNKNPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C580", Offset = "0x5D0B780", VA = "0x185D0C580")]
	private FGMMJKMMGFF OGCKGPIHIGO(byte AFLJKADDJPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C810", Offset = "0x5D0BA10", VA = "0x185D0C810")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, IPEndPoint EPJJEHDAAFG, int DKFNFHGODON, byte AGBOJBDOOKK, PLNCDKJFIPB CHKCCGJEIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CE00", Offset = "0x5D0C000", VA = "0x185D0CE00")]
	internal JODPKGALIPK(KGFKNENJKED GENLECEPGLM, JKBDFEOFJML GPCNCGBOPJG, int DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C3A0", Offset = "0x5D0B5A0", VA = "0x185D0C3A0")]
	internal void NCFDFFJJMCG(DFAKOGKLBAD FKKDJGKIPPC, byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C770", Offset = "0x5D0B970", VA = "0x185D0C770")]
	internal bool OOLIMKHOMCD(ODEAAAOAHHA DNPPEENABEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A380", Offset = "0x5D09580", VA = "0x185D0A380")]
	public void FKIHHFKAOGH(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, ICCCONHPJEP FDGBBGJEJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B4F0", Offset = "0x5D0A6F0", VA = "0x185D0B4F0")]
	private void HIJFFJAHIIL(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, byte DOFKDJGAHMN, ICCCONHPJEP ABGGJFHFFAM, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A1F0", Offset = "0x5D093F0", VA = "0x185D0A1F0")]
	public void EJHDLEPHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D0C4A0", Offset = "0x5D0B6A0", VA = "0x185D0C4A0")]
	internal CGMOCKHNHFL NJHINPDEBNC(BEEFEPJHLGP DNPPEENABEA)
	{
		return default(CGMOCKHNHFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AA60", Offset = "0x5D09C60", VA = "0x185D0AA60")]
	internal void GGGNGEFPBMP(FGMMJKMMGFF FHBDGPKMKOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AC80", Offset = "0x5D09E80", VA = "0x185D0AC80")]
	internal BFCMLBMNPDD GKKLPGKFKML(byte[] LINJEFIAFHO, int GBALKPFEDAI, int OMJPDIKPOLO, bool AMNFMCIBNPO)
	{
		return default(BFCMLBMNPDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D09EC0", Offset = "0x5D090C0", VA = "0x185D09EC0")]
	private void CIDPFKEJJJI(int IGDHNHOPGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D090F0", Offset = "0x5D082F0", VA = "0x185D090F0")]
	internal void AJEBEKCCFEC(ICCCONHPJEP PEDHACINLAG, BEEFEPJHLGP MPPCPDMLBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AF90", Offset = "0x5D0A190", VA = "0x185D0AF90")]
	private void GOGHKPDNGAJ(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D09A90", Offset = "0x5D08C90", VA = "0x185D09A90")]
	private void AOMLALJENLE(int LDGBKFKPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D0AAC0", Offset = "0x5D09CC0", VA = "0x185D0AAC0")]
	internal LALDNDBJFKP GHMGHFGDLCF(DFAKOGKLBAD CMFNCGDHDKO)
	{
		return default(LALDNDBJFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D0A3B0", Offset = "0x5D095B0", VA = "0x185D0A3B0")]
	internal void GAHEDLGEJFB(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D08FD0", Offset = "0x5D081D0", VA = "0x185D08FD0")]
	private void AGMIPGHGDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D08E00", Offset = "0x5D08000", VA = "0x185D08E00")]
	internal void AFOEFDJAIMP(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BB80", Offset = "0x5D0AD80", VA = "0x185D0BB80")]
	internal void LHGGKPHIKGE(int LDGBKFKPDEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D09F30", Offset = "0x5D09130", VA = "0x185D09F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D06480", Offset = "0x5D05680", VA = "0x185D06480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long LEPOKCBEOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D062C0", Offset = "0x5D054C0", VA = "0x185D062C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LDEMILEKOBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D063D0", Offset = "0x5D055D0", VA = "0x185D063D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EGJKMNDIOMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D06440", Offset = "0x5D05640", VA = "0x185D06440")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BIPOBBFMHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D06490", Offset = "0x5D05690", VA = "0x185D06490")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long POGDPIOJAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D06500", Offset = "0x5D05700", VA = "0x185D06500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private OFFMEBAOCCD DOKFAEPHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D063B0", Offset = "0x5D055B0", VA = "0x185D063B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double OGCLMDOIGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D063E0", Offset = "0x5D055E0", VA = "0x185D063E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D064A0", Offset = "0x5D056A0", VA = "0x185D064A0")]
	public void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D06450", Offset = "0x5D05650", VA = "0x185D06450")]
	public void HMICJPJMLAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D06510", Offset = "0x5D05710", VA = "0x185D06510")]
	public void PJHHEENNBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D063C0", Offset = "0x5D055C0", VA = "0x185D063C0")]
	public void FGLMDOMNAIJ(long EHGLIIEECOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D06280", Offset = "0x5D05480", VA = "0x185D06280")]
	public void AENHBKONFFC(long NCLBGIHECPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D06290", Offset = "0x5D05490", VA = "0x185D06290")]
	public void BJJCOEEOHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D06370", Offset = "0x5D05570", VA = "0x185D06370")]
	public void DELPNCBFOEK(long KPMACPPLCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D06520", Offset = "0x5D05720", VA = "0x185D06520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D062D0", Offset = "0x5D054D0", VA = "0x185D062D0")]
	public void CKOKIAHMMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D05FA0", Offset = "0x5D051A0", VA = "0x185D05FA0")]
	public static IPEndPoint JAMCJKADIAC(string PPCNIEJPEKK, int PGLCONBPEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D05DD0", Offset = "0x5D04FD0", VA = "0x185D05DD0")]
	public static IPAddress FDGPNKJKEDA(string PPCNIEJPEKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D05D40", Offset = "0x5D04F40", VA = "0x185D05D40")]
	public static IPAddress FDGPNKJKEDA(string PPCNIEJPEKK, AddressFamily EBPPOLJHJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D05D10", Offset = "0x5D04F10", VA = "0x185D05D10")]
	internal static int DIMBMMLGONG(int CNEGAAAMFEO, int NKOKHDBOMFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x29E8C70", Offset = "0x29E7E70", VA = "0x1829E8C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D02C00", Offset = "0x5D01E00", VA = "0x185D02C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D02B20", Offset = "0x5D01D20", VA = "0x185D02B20")]
		public void EEKIDKGBNNN(BEEFEPJHLGP DNPPEENABEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D02B90", Offset = "0x5D01D90", VA = "0x185D02B90")]
		public bool KMBDKADDDCE(long KBAMMELOGGL, JODPKGALIPK GFGLGJAIHDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D02B40", Offset = "0x5D01D40", VA = "0x185D02B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D05B40", Offset = "0x5D04D40", VA = "0x185D05B40")]
	public EMPABLNIKLF(JODPKGALIPK GFGLGJAIHDL, bool OOLEDJPJOMF, byte DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D04C70", Offset = "0x5D03E70", VA = "0x185D04C70")]
	private void FEGMMFOAOEL(BEEFEPJHLGP DNPPEENABEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D05690", Offset = "0x5D04890", VA = "0x185D05690", Slot = "4")]
	protected override bool MKJGJDGPJJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D05030", Offset = "0x5D04230", VA = "0x185D05030", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D15CA0", Offset = "0x5D14EA0", VA = "0x185D15CA0")]
	public LMKMCJJMHIO(JODPKGALIPK GFGLGJAIHDL, bool FPHGDIEDHEP, byte DKFNFHGODON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D15800", Offset = "0x5D14A00", VA = "0x185D15800", Slot = "4")]
	protected override bool MKJGJDGPJJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D154F0", Offset = "0x5D146F0", VA = "0x185D154F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D02540", Offset = "0x5D01740", VA = "0x185D02540")]
	private static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, ulong LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D02CB0", Offset = "0x5D01EB0", VA = "0x185D02CB0")]
	private static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D02DA0", Offset = "0x5D01FA0", VA = "0x185D02DA0")]
	public static void MGFBGCPJOGP(byte[] PHMDIHEJOGG, int PENDBLHFGOI, short LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D02DE0", Offset = "0x5D01FE0", VA = "0x185D02DE0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, double JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D02D20", Offset = "0x5D01F20", VA = "0x185D02D20")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D02DA0", Offset = "0x5D01FA0", VA = "0x185D02DA0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, short JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D02DA0", Offset = "0x5D01FA0", VA = "0x185D02DA0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, ushort JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D02CB0", Offset = "0x5D01EB0", VA = "0x185D02CB0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D02CB0", Offset = "0x5D01EB0", VA = "0x185D02CB0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, uint JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D02CA0", Offset = "0x5D01EA0", VA = "0x185D02CA0")]
	public static void DGGPFFEFHDH(byte[] DDNKCFIIBGP, int JHEGPJBDKAJ, long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D02CA0", Offset = "0x5D01EA0", VA = "0x185D02CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int HJCGDEMODCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8CD9B0", Offset = "0x8CCBB0", VA = "0x1808CD9B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int GCMOLNFPOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D08B50", Offset = "0x5D07D50", VA = "0x185D08B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool EKJJHCFOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1ED0380", Offset = "0x1ECF580", VA = "0x181ED0380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OCPECKMFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D07FE0", Offset = "0x5D071E0", VA = "0x185D07FE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D08A20", Offset = "0x5D07C20", VA = "0x185D08A20")]
	public void NNGFPFGNFPO(byte[] LDPKCIGIIMG, int PENDBLHFGOI, int GMGJCNDCIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public GFNMLBNLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D08B60", Offset = "0x5D07D60", VA = "0x185D08B60")]
	public GFNMLBNLGLI(byte[] LDPKCIGIIMG, int PENDBLHFGOI, int GMGJCNDCIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D082A0", Offset = "0x5D074A0", VA = "0x185D082A0")]
	public IPEndPoint GDOCFGOAOCG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D08030", Offset = "0x5D07230", VA = "0x185D08030")]
	public byte PKKLBLNMIML()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5D08030", Offset = "0x5D07230", VA = "0x185D08030")]
	public sbyte BECONKIPHPM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B314B0", Offset = "0x2B306B0", VA = "0x182B314B0")]
	public T[] KHIKKEAIICA<T>(ushort ECGAAJFODGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D081A0", Offset = "0x5D073A0", VA = "0x185D081A0")]
	public bool[] DEAEDOECEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5D08370", Offset = "0x5D07570", VA = "0x185D08370")]
	public ushort[] GOEINCDEPPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D086D0", Offset = "0x5D078D0", VA = "0x185D086D0")]
	public short[] ICBJCKHIEOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D08220", Offset = "0x5D07420", VA = "0x185D08220")]
	public int[] EPOCFKGLFOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D08260", Offset = "0x5D07460", VA = "0x185D08260")]
	public uint[] FODMFOJPGNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D07FF0", Offset = "0x5D071F0", VA = "0x185D07FF0")]
	public float[] BDJABFABLKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D08B10", Offset = "0x5D07D10", VA = "0x185D08B10")]
	public double[] PGDAGAHBBOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D081E0", Offset = "0x5D073E0", VA = "0x185D081E0")]
	public long[] EFOHKABJFLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D08A60", Offset = "0x5D07C60", VA = "0x185D08A60")]
	public ulong[] OIBMNPJCFIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D08070", Offset = "0x5D07270", VA = "0x185D08070")]
	public string[] CPOCJGNOHKC(int KMOHOCIHNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D08970", Offset = "0x5D07B70", VA = "0x185D08970")]
	public bool KLENDAOKIHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D08420", Offset = "0x5D07620", VA = "0x185D08420")]
	public char PBHAKOPGOBD()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D08420", Offset = "0x5D07620", VA = "0x185D08420")]
	public ushort IBDBMFOGPNL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D087A0", Offset = "0x5D079A0", VA = "0x185D087A0")]
	public short JBNGFMMIBKH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D08850", Offset = "0x5D07A50", VA = "0x185D08850")]
	public long JDDNOHFHAAL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D08AA0", Offset = "0x5D07CA0", VA = "0x185D08AA0")]
	public ulong OOPKJEPMIOJ()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D08710", Offset = "0x5D07910", VA = "0x185D08710")]
	public int IHBFIGKDFOL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D08900", Offset = "0x5D07B00", VA = "0x185D08900")]
	public uint KFPAMIGGLPE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D083B0", Offset = "0x5D075B0", VA = "0x185D083B0")]
	public float HBAAEIHNOFH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D07F70", Offset = "0x5D07170", VA = "0x185D07F70")]
	public double AJIJFKNOBOA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D08490", Offset = "0x5D07690", VA = "0x185D08490")]
	public string IBIKDEAMEBM(int KBFGFPLLOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D089B0", Offset = "0x5D07BB0", VA = "0x185D089B0")]
	public ArraySegment<byte> KMLLKFLBLHJ(int IHGHLPOONHD)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D08810", Offset = "0x5D07A10", VA = "0x185D08810")]
	public sbyte[] JCCELEGMJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D088C0", Offset = "0x5D07AC0", VA = "0x185D088C0")]
	public byte[] JFHDODIKIAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D08780", Offset = "0x5D07980", VA = "0x185D08780")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int PBLCBJADLHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x85FD10", Offset = "0x85EF10", VA = "0x18085FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5D19560", Offset = "0x5D18760", VA = "0x185D19560")]
	public PLNCDKJFIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5D195E0", Offset = "0x5D187E0", VA = "0x185D195E0")]
	public PLNCDKJFIPB(bool OBNEJGEPALM, int BFNINGMCNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D18830", Offset = "0x5D17A30", VA = "0x185D18830")]
	public static PLNCDKJFIPB CKKNHLMDGHJ(string JMDCGOKJIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D188A0", Offset = "0x5D17AA0", VA = "0x185D188A0")]
	public void JBDGAIKBLHK(int OBMECBFGAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F49C40", Offset = "0x1F48E40", VA = "0x181F49C40")]
	public void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5D19160", Offset = "0x5D18360", VA = "0x185D19160")]
	public void OEEAOMEPNLL(float JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5D19110", Offset = "0x5D18310", VA = "0x185D19110")]
	public void OEEAOMEPNLL(double JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5D19210", Offset = "0x5D18410", VA = "0x185D19210")]
	public void OEEAOMEPNLL(long JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5D19210", Offset = "0x5D18410", VA = "0x185D19210")]
	public void OEEAOMEPNLL(ulong JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D19010", Offset = "0x5D18210", VA = "0x185D19010")]
	public void OEEAOMEPNLL(int JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D19010", Offset = "0x5D18210", VA = "0x185D19010")]
	public void OEEAOMEPNLL(uint JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D190A0", Offset = "0x5D182A0", VA = "0x185D190A0")]
	public void OEEAOMEPNLL(char JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D190A0", Offset = "0x5D182A0", VA = "0x185D190A0")]
	public void OEEAOMEPNLL(ushort JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5D190A0", Offset = "0x5D182A0", VA = "0x185D190A0")]
	public void OEEAOMEPNLL(short JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5D18FB0", Offset = "0x5D181B0", VA = "0x185D18FB0")]
	public void OEEAOMEPNLL(sbyte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5D18FB0", Offset = "0x5D181B0", VA = "0x185D18FB0")]
	public void OEEAOMEPNLL(byte JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5D18E70", Offset = "0x5D18070", VA = "0x185D18E70")]
	public void OEEAOMEPNLL(byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D18A20", Offset = "0x5D17C20", VA = "0x185D18A20")]
	public void JLECAMKEFBN(sbyte[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D18A20", Offset = "0x5D17C20", VA = "0x185D18A20")]
	public void MBKHOPAEPMM(byte[] LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D19260", Offset = "0x5D18460", VA = "0x185D19260")]
	public void OEEAOMEPNLL(bool JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D18940", Offset = "0x5D17B40", VA = "0x185D18940")]
	public void JDMIAFLJLFK(Array GHJMPEDKGHI, int JJPCOKALJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D18BD0", Offset = "0x5D17DD0", VA = "0x185D18BD0")]
	public void JDMIAFLJLFK(float[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D18D90", Offset = "0x5D17F90", VA = "0x185D18D90")]
	public void JDMIAFLJLFK(double[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D18D90", Offset = "0x5D17F90", VA = "0x185D18D90")]
	public void JDMIAFLJLFK(long[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D18D90", Offset = "0x5D17F90", VA = "0x185D18D90")]
	public void JDMIAFLJLFK(ulong[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D18BD0", Offset = "0x5D17DD0", VA = "0x185D18BD0")]
	public void JDMIAFLJLFK(int[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D18BD0", Offset = "0x5D17DD0", VA = "0x185D18BD0")]
	public void JDMIAFLJLFK(uint[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D18CB0", Offset = "0x5D17EB0", VA = "0x185D18CB0")]
	public void JDMIAFLJLFK(ushort[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D18CB0", Offset = "0x5D17EB0", VA = "0x185D18CB0")]
	public void JDMIAFLJLFK(short[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D18A20", Offset = "0x5D17C20", VA = "0x185D18A20")]
	public void JDMIAFLJLFK(bool[] JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D18B00", Offset = "0x5D17D00", VA = "0x185D18B00")]
	public void JDMIAFLJLFK(string[] JMDCGOKJIDA, int JOICIBAPFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D18EE0", Offset = "0x5D180E0", VA = "0x185D18EE0")]
	public void OEEAOMEPNLL(IPEndPoint DFOCJDNDFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D19200", Offset = "0x5D18400", VA = "0x185D19200")]
	public void OEEAOMEPNLL(string JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D192C0", Offset = "0x5D184C0", VA = "0x185D192C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x47897B0", Offset = "0x47889B0", VA = "0x1847897B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JGNLPPMEJPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x40B10D0", Offset = "0x40B02D0", VA = "0x1840B10D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GNOJKLLDGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CE59D0", Offset = "0x3CE4BD0", VA = "0x183CE59D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D0D1E0", Offset = "0x5D0C3E0", VA = "0x185D0D1E0")]
	public KAHBNCLFEMA(int KMOHOCIHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x294A1C0", Offset = "0x29493C0", VA = "0x18294A1C0", Slot = "4")]
	protected virtual ulong GLJLINEAPKO<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D030", Offset = "0x5D0C230", VA = "0x185D0D030", Slot = "5")]
	protected virtual ELGPGPGHMJP DMLMFOOODCB(GFNMLBNLGLI ELOKBGPKALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2C045E0", Offset = "0x2C037E0", VA = "0x182C045E0", Slot = "6")]
	protected virtual void IICCKAHOGEI<T>(PLNCDKJFIPB JLIOPEDCMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D160", Offset = "0x5D0C360", VA = "0x185D0D160")]
	public void HKCHGOMDLEB(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2C04530", Offset = "0x2C03730", VA = "0x182C04530")]
	public void HHIFNKNGNCI<T>(PLNCDKJFIPB JLIOPEDCMBE, T DNPPEENABEA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D0CFE0", Offset = "0x5D0C1E0", VA = "0x185D0CFE0")]
	public void BICCFOJGKHF(GFNMLBNLGLI ELOKBGPKALP, object BCIFNCCEIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2C04800", Offset = "0x2C03A00", VA = "0x182C04800")]
	public void LOKONGJCMHE<T>(Action<T> KMJBEKCGHLD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2C04650", Offset = "0x2C03850", VA = "0x182C04650")]
	public void LOKONGJCMHE<T, TUserData>(Action<T, TUserData> KMJBEKCGHLD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HDCEHOFLJAL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D04C60", Offset = "0x5D03E60", VA = "0x185D04C60")]
	public HDCEHOFLJAL(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MHFBENNBKOD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D175A0", Offset = "0x5D167A0", VA = "0x185D175A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C11CA0", Offset = "0x3C10EA0", VA = "0x183C11CA0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x476D580", Offset = "0x476C780", VA = "0x18476D580", Slot = "7")]
		public override void DIIPPBFNKFP(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4773640", Offset = "0x4772840", VA = "0x184773640", Slot = "8")]
		public override void MLDFCKJKEPC(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4774220", Offset = "0x4773420", VA = "0x184774220", Slot = "9")]
		public override void PKJGFMJNCIB(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4772920", Offset = "0x4771B20", VA = "0x184772920", Slot = "10")]
		public override void GNOLNCNLIAA(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x476D3A0", Offset = "0x476C5A0", VA = "0x18476D3A0")]
		protected TProperty[] DFNHALMGPLE(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4773FE0", Offset = "0x47731E0", VA = "0x184773FE0")]
		protected TProperty[] MOEMJFKCEOI(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x476EB40", Offset = "0x476DD40", VA = "0x18476EB40", Slot = "4")]
		public override void EEKIDKGBNNN(MethodInfo KANOEFJDOAC, MethodInfo NFNKOMEBDKF, KONOBGCEHAN NCMHJNKFAGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4253AC0", Offset = "0x4252CC0", VA = "0x184253AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CD4470", Offset = "0x3CD3670", VA = "0x183CD4470", Slot = "5")]
		public override void CLAPPBNJGGL(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4690", Offset = "0x3CD3890", VA = "0x183CD4690", Slot = "6")]
		public override void HHIFNKNGNCI(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CD45D0", Offset = "0x3CD37D0", VA = "0x183CD45D0", Slot = "7")]
		public override void DIIPPBFNKFP(TClass BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4790", Offset = "0x3CD3990", VA = "0x183CD4790", Slot = "8")]
		public override void MLDFCKJKEPC(TClass BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4910", Offset = "0x3CD3B10", VA = "0x183CD4910")]
		protected GJGGMAAGHIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class MKGEEPFKHPK<T> : PEAPMPPPPLK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x44AE410", Offset = "0x44AD610", VA = "0x1844AE410", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x44AE510", Offset = "0x44AD710", VA = "0x1844AE510", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x44AE490", Offset = "0x44AD690", VA = "0x1844AE490", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x41D15C0", Offset = "0x41D07C0", VA = "0x1841D15C0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public MKGEEPFKHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BJHDBCJMLNI<T> : PEAPMPPPPLK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4E44C20", Offset = "0x4E43E20", VA = "0x184E44C20", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x44AE510", Offset = "0x44AD710", VA = "0x1844AE510", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4E44CA0", Offset = "0x4E43EA0", VA = "0x184E44CA0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x41D15C0", Offset = "0x41D07C0", VA = "0x1841D15C0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public BJHDBCJMLNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class PJOHLLLGMEG<T> : PEAPMPPPPLK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4781810", Offset = "0x4780A10", VA = "0x184781810", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x381AB80", Offset = "0x3819D80", VA = "0x18381AB80", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4781890", Offset = "0x4780A90", VA = "0x184781890", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x381ABF0", Offset = "0x3819DF0", VA = "0x18381ABF0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public PJOHLLLGMEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class EOLPAMJCDMJ<T> : PEAPMPPPPLK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x381AA80", Offset = "0x3819C80", VA = "0x18381AA80", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x381AB80", Offset = "0x3819D80", VA = "0x18381AB80", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x381AB00", Offset = "0x3819D00", VA = "0x18381AB00", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x381ABF0", Offset = "0x3819DF0", VA = "0x18381ABF0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public EOLPAMJCDMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class NPCJGOEJPLO<T> : PEAPMPPPPLK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x454FD60", Offset = "0x454EF60", VA = "0x18454FD60", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9970", Offset = "0x3CE8B70", VA = "0x183CE9970", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x454FDE0", Offset = "0x454EFE0", VA = "0x18454FDE0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE99E0", Offset = "0x3CE8BE0", VA = "0x183CE99E0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public NPCJGOEJPLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class GPPCIFIKAOE<T> : PEAPMPPPPLK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9870", Offset = "0x3CE8A70", VA = "0x183CE9870", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9970", Offset = "0x3CE8B70", VA = "0x183CE9970", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CE98F0", Offset = "0x3CE8AF0", VA = "0x183CE98F0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CE99E0", Offset = "0x3CE8BE0", VA = "0x183CE99E0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public GPPCIFIKAOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CGDBEJHLLAK<T> : PEAPMPPPPLK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x38197F0", Offset = "0x38189F0", VA = "0x1838197F0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x38198F0", Offset = "0x3818AF0", VA = "0x1838198F0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x510BCB0", Offset = "0x510AEB0", VA = "0x18510BCB0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3819960", Offset = "0x3818B60", VA = "0x183819960", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public CGDBEJHLLAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ENHEOJOAPPD<T> : PEAPMPPPPLK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x38197F0", Offset = "0x38189F0", VA = "0x1838197F0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x38198F0", Offset = "0x3818AF0", VA = "0x1838198F0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3819870", Offset = "0x3818A70", VA = "0x183819870", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3819960", Offset = "0x3818B60", VA = "0x183819960", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public ENHEOJOAPPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KPDLCKGGMDA<T> : PEAPMPPPPLK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x41D1450", Offset = "0x41D0650", VA = "0x1841D1450", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x41D1550", Offset = "0x41D0750", VA = "0x1841D1550", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x41D14D0", Offset = "0x41D06D0", VA = "0x1841D14D0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x41D15C0", Offset = "0x41D07C0", VA = "0x1841D15C0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public KPDLCKGGMDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PCGPEMAAMAE<T> : PEAPMPPPPLK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4767B70", Offset = "0x4766D70", VA = "0x184767B70", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4767C70", Offset = "0x4766E70", VA = "0x184767C70", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4767BF0", Offset = "0x4766DF0", VA = "0x184767BF0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE99E0", Offset = "0x3CE8BE0", VA = "0x183CE99E0", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public PCGPEMAAMAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class LFDNFJMDLPE<T> : PEAPMPPPPLK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x42467A0", Offset = "0x42459A0", VA = "0x1842467A0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x42468A0", Offset = "0x4245AA0", VA = "0x1842468A0", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4246820", Offset = "0x4245A20", VA = "0x184246820", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3819960", Offset = "0x3818B60", VA = "0x183819960", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x38199D0", Offset = "0x3818BD0", VA = "0x1838199D0")]
		public LFDNFJMDLPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HEBIMOAJFJC<T> : GJGGMAAGHIA<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D19CD0", Offset = "0x3D18ED0", VA = "0x183D19CD0", Slot = "12")]
		protected override void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, char CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D19D00", Offset = "0x3D18F00", VA = "0x183D19D00", Slot = "11")]
		protected override void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] char CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D19D30", Offset = "0x3D18F30", VA = "0x183D19D30")]
		public HEBIMOAJFJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OGADGEMJNMA<T> : GJGGMAAGHIA<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x46423D0", Offset = "0x46415D0", VA = "0x1846423D0", Slot = "12")]
		protected override void GBOFNFDCJFA(PLNCDKJFIPB HNFNJDLDBDO, IPEndPoint CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4642400", Offset = "0x4641600", VA = "0x184642400", Slot = "11")]
		protected override void IMPLADPLPFK(GFNMLBNLGLI DLFEHJOHIIJ, [Out] IPEndPoint CJJOCFAPEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D19D30", Offset = "0x3D18F30", VA = "0x183D19D30")]
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
		[Cpp2IlInjected.Address(RVA = "0x42AA010", Offset = "0x42A9210", VA = "0x1842AA010")]
		public LNKKGFHGKNC(int KBFGFPLLOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x42A9E10", Offset = "0x42A9010", VA = "0x1842A9E10", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x42A9F10", Offset = "0x42A9110", VA = "0x1842A9F10", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x42A9E90", Offset = "0x42A9090", VA = "0x1842A9E90", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x42A9F90", Offset = "0x42A9190", VA = "0x1842A9F90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4180BD0", Offset = "0x417FDD0", VA = "0x184180BD0")]
		public KDJCAGMMMIJ(PropertyInfo FMACLHMOMLJ, Type KGDKDOJABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x41808E0", Offset = "0x417FAE0", VA = "0x1841808E0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4180A60", Offset = "0x417FC60", VA = "0x184180A60", Slot = "6")]
		public override void HHIFNKNGNCI(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x41809A0", Offset = "0x417FBA0", VA = "0x1841809A0", Slot = "7")]
		public override void DIIPPBFNKFP(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4180B10", Offset = "0x417FD10", VA = "0x184180B10", Slot = "8")]
		public override void MLDFCKJKEPC(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4180B70", Offset = "0x417FD70", VA = "0x184180B70", Slot = "9")]
		public override void PKJGFMJNCIB(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4180A00", Offset = "0x417FC00", VA = "0x184180A00", Slot = "10")]
		public override void GNOLNCNLIAA(T BMJBENJPFKC, PLNCDKJFIPB HNFNJDLDBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class KJOIMPHENDL<T> : KDJCAGMMMIJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C657F0", Offset = "0x3C649F0", VA = "0x183C657F0")]
		public KJOIMPHENDL(PropertyInfo FMACLHMOMLJ, Type KGDKDOJABNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4197CC0", Offset = "0x4196EC0", VA = "0x184197CC0", Slot = "5")]
		public override void CLAPPBNJGGL(T BMJBENJPFKC, GFNMLBNLGLI DLFEHJOHIIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4197D80", Offset = "0x4196F80", VA = "0x184197D80", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E872B0", Offset = "0x4E864B0", VA = "0x184E872B0")]
		public BNBGHEKIIAL(List<FMIMFEIJDCN<T>> FAHLHGGJMAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E87200", Offset = "0x4E86400", VA = "0x184E87200")]
		public void HHIFNKNGNCI(T MEAFIMADMKA, PLNCDKJFIPB JLIOPEDCMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E87150", Offset = "0x4E86350", VA = "0x184E87150")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D17500", Offset = "0x5D16700", VA = "0x185D17500")]
	public MAJBKIPCDFB(int KMOHOCIHNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AC10", Offset = "0x2C29E10", VA = "0x182C2AC10")]
	private BNBGHEKIIAL<T> MIKKPADLDCF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x29A3F10", Offset = "0x29A3110", VA = "0x1829A3F10")]
	public void JGBCFAKMKJN<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2C2AB70", Offset = "0x2C29D70", VA = "0x182C2AB70")]
	public bool DGBBAPGEGII<T>(GFNMLBNLGLI ELOKBGPKALP, T CGKANMHMCOJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2C2BD20", Offset = "0x2C2AF20", VA = "0x182C2BD20")]
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
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D06D60", Offset = "0x5D05F60", VA = "0x185D06D60")]
		get
		{
			return default(GPMKDDJGPMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JODMKGBCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D06BE0", Offset = "0x5D05DE0", VA = "0x185D06BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D07160", Offset = "0x5D06360", VA = "0x185D07160")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IHFBDOEDAIF FFLGFNAAOHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D07790", Offset = "0x5D06990", VA = "0x185D07790")]
		get
		{
			return default(IHFBDOEDAIF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D07870", Offset = "0x5D06A70", VA = "0x185D07870")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JHPKPHCHPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D077C0", Offset = "0x5D069C0", VA = "0x185D077C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint BPIOALJJJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D077F0", Offset = "0x5D069F0", VA = "0x185D077F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? NJHKEJDIHNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D06D30", Offset = "0x5D05F30", VA = "0x185D06D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? KKCPJNEOIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D07760", Offset = "0x5D06960", VA = "0x185D07760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CFIMMEIIMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D06F60", Offset = "0x5D06160", VA = "0x185D06F60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D06F90", Offset = "0x5D06190", VA = "0x185D06F90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DBAGCJPIEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC36B10", Offset = "0xC35D10", VA = "0x180C36B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA771C0", Offset = "0xA763C0", VA = "0x180A771C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D07BA0", Offset = "0x5D06DA0", VA = "0x185D07BA0")]
	public FNCNBOPEEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D07EC0", Offset = "0x5D070C0", VA = "0x185D07EC0")]
	internal FNCNBOPEEEO(byte[] DDNKCFIIBGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D06C10", Offset = "0x5D05E10", VA = "0x185D06C10")]
	public static FNCNBOPEEEO AKJCFLGKCBK(byte[] DDNKCFIIBGP, DateTime FAPMGBCFHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D07290", Offset = "0x5D06490", VA = "0x185D07290")]
	internal void KKJJCEGIAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D078B0", Offset = "0x5D06AB0", VA = "0x185D078B0")]
	private void OEGGEOBKOIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D07560", Offset = "0x5D06760", VA = "0x185D07560")]
	private DateTime? KMGLOGEADLP(int PENDBLHFGOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D06D90", Offset = "0x5D05F90", VA = "0x185D06D90")]
	private void CIAFLFKPMKO(int PENDBLHFGOI, DateTime? JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D07490", Offset = "0x5D06690", VA = "0x185D07490")]
	private ulong KKNBONJLPPI(int PENDBLHFGOI)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D07A80", Offset = "0x5D06C80", VA = "0x185D07A80")]
	private void PCNHLGNKGCE(int PENDBLHFGOI, ulong JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D07200", Offset = "0x5D06400", VA = "0x185D07200")]
	private uint KCFOGMBIODO(int PENDBLHFGOI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BD67E0", Offset = "0x5BD59E0", VA = "0x185BD67E0")]
	private static uint JILBPPCAONO(uint IPBJLCONKPC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D071A0", Offset = "0x5D063A0", VA = "0x185D071A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D06970", Offset = "0x5D05B70", VA = "0x185D06970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D06880", Offset = "0x5D05A80", VA = "0x185D06880")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D0D380", Offset = "0x5D0C580", VA = "0x185D0D380", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int ANBBECBIOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D3A0", Offset = "0x5D0C5A0", VA = "0x185D0D3A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint IDFDBCPNJMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D0D9C0", Offset = "0x5D0CBC0", VA = "0x185D0D9C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HNCFNIEAHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x422D7F0", Offset = "0x422C9F0", VA = "0x18422D7F0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D0DAD0", Offset = "0x5D0CCD0", VA = "0x185D0DAD0")]
	public KDLNGIHHHLK(AddressFamily EBPPOLJHJFO, KGFKNENJKED GENLECEPGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D400", Offset = "0x5D0C600", VA = "0x185D0D400", Slot = "8")]
	public bool KEPICDLKMMO(IPEndPoint DFOCJDNDFGL, NOCKMHOHBAI KABMHDMECDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D3C0", Offset = "0x5D0C5C0", VA = "0x185D0D3C0", Slot = "9")]
	public int KACGICJMLIN(byte[] PHMDIHEJOGG, int PENDBLHFGOI, int ECGAAJFODGN, IPEndPoint EPJJEHDAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D9E0", Offset = "0x5D0CBE0", VA = "0x185D0D9E0", Slot = "10")]
	public int PJJDGIFDOLF(byte[] PHMDIHEJOGG, EndPoint NJMLADNIIBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D0D360", Offset = "0x5D0C560", VA = "0x185D0D360", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D182A0", Offset = "0x5D174A0", VA = "0x185D182A0")]
	public NAAAKGNFLHP(byte[] ENHCCNBGHAP, int JPJDGBKMPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x87A900", Offset = "0x879B00", VA = "0x18087A900", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5D18260", Offset = "0x5D17460", VA = "0x185D18260", Slot = "4")]
	public bool Equals(NAAAKGNFLHP OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5D181B0", Offset = "0x5D173B0", VA = "0x185D181B0", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x85C1D0", Offset = "0x85B3D0", VA = "0x18085C1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FEE100", Offset = "0x1FED300", VA = "0x181FEE100")]
	public ECGLNENJEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5D04970", Offset = "0x5D03B70", VA = "0x185D04970")]
	public void GLLDDHJGPNI(IPEndPoint DFOCJDNDFGL, byte[] NDDCLPHCEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5D04B20", Offset = "0x5D03D20", VA = "0x185D04B20")]
	public void HPANOCLNFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D044C0", Offset = "0x5D036C0", VA = "0x185D044C0", Slot = "4")]
	public override void ADENPHMFJBA(IPEndPoint DFOCJDNDFGL, byte[] LINJEFIAFHO, int PENDBLHFGOI, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5D04150", Offset = "0x5D03350", VA = "0x185D04150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D19A70", Offset = "0x5D18C70", VA = "0x185D19A70")]
		[BurstDiscard]
		private static void DMDNENMINFN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5D19BA0", Offset = "0x5D18DA0", VA = "0x185D19BA0")]
		private static IntPtr NNCIHFCPDLJ()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5D199C0", Offset = "0x5D18BC0", VA = "0x185D199C0")]
		public static void BLFANLMLIED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
		public static void HMCGAKKBHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5D19780", Offset = "0x5D18980", VA = "0x185D19780")]
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
	[Cpp2IlInjected.Address(RVA = "0x5D15340", Offset = "0x5D14540", VA = "0x185D15340")]
	private void MJPMKPPBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5D153C0", Offset = "0x5D145C0", VA = "0x185D153C0")]
	private uint MOIBDHMHAOD(uint NJJHKDBJDAC, int HBOKNMMNDGO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5D029D0", Offset = "0x5D01BD0", VA = "0x185D029D0")]
	private void PBPPJJHAOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5D026C0", Offset = "0x5D018C0", VA = "0x185D026C0")]
	private void KFLKOHINFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5D02630", Offset = "0x5D01830", VA = "0x185D02630")]
	private void DEEHMDKMKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5D028D0", Offset = "0x5D01AD0", VA = "0x185D028D0")]
	private void NBFNNGOMNKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5D14CF0", Offset = "0x5D13EF0", VA = "0x185D14CF0")]
	private void AMCBEEJJABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5D14D50", Offset = "0x5D13F50", VA = "0x185D14D50")]
	private unsafe void FOFKAPABNLD(byte* MPCLCEPHNBP, uint* NDDCLPHCEEO, uint* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5D151E0", Offset = "0x5D143E0", VA = "0x185D151E0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void MHLOIJLDHIM([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5D15260", Offset = "0x5D14460", VA = "0x185D15260")]
	public static void MHLOIJLDHIM(Span<byte> MPCLCEPHNBP, Span<byte> NDDCLPHCEEO, Span<byte> NOJIAOAEHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5D153F0", Offset = "0x5D145F0", VA = "0x185D153F0")]
	public static void NGBGIGNPNOC(Span<byte> MPCLCEPHNBP, Span<byte> NDDCLPHCEEO, Span<byte> NOJIAOAEHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5D15170", Offset = "0x5D14370", VA = "0x185D15170")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LBIMKIEBEGO([NoAlias] byte* MPCLCEPHNBP, [NoAlias] byte* NDDCLPHCEEO, [NoAlias] byte* NOJIAOAEHBN, int OMJPDIKPOLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5D19D00", Offset = "0x5D18F00", VA = "0x185D19D00")]
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
