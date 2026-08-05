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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, OPHJBCKCGMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HBFBMKLAPIO
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
		private NetworkManager IICLHHNPNDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, ECJINLKIFAA> EFNKGNOHDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ILNAMGHDHPE ADNGFGFGAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] FLAPCMFFCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HBFBMKLAPIO ALPKDGKFFHK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong DOKJEFLEEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool OLPDCIICENH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x51C59C0", Offset = "0x51C4DC0", VA = "0x1851C59C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x51C4EC0", Offset = "0x51C42C0", VA = "0x1851C4EC0")]
		public void RecRoom_SetEncryptionInfo(ulong HBPHDMLJBOA, byte[] DGCJCBHPPBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x51C4EA0", Offset = "0x51C42A0", VA = "0x1851C4EA0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x51C4D70", Offset = "0x51C4170", VA = "0x1851C4D70")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x51C58C0", Offset = "0x51C4CC0", VA = "0x1851C58C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x51C50C0", Offset = "0x51C44C0", VA = "0x1851C50C0", Slot = "6")]
		public override void Send(ulong MDPJPABGGLO, ArraySegment<byte> GHFAAPNAFDE, NetworkDelivery CJOAONFIGBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x51C4E60", Offset = "0x51C4260", VA = "0x1851C4E60", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong MDPJPABGGLO, [Out] ArraySegment<byte> HEFGEKEDAKE, [Out] float PHPCDENDPNF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x51C53B0", Offset = "0x51C47B0", VA = "0x1851C53B0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x51C57E0", Offset = "0x51C4BE0", VA = "0x1851C57E0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x51C4310", Offset = "0x51C3710", VA = "0x1851C4310", Slot = "10")]
		public override void DisconnectRemoteClient(ulong MDPJPABGGLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x51C41C0", Offset = "0x51C35C0", VA = "0x1851C41C0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51C47E0", Offset = "0x51C3BE0", VA = "0x1851C47E0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong MDPJPABGGLO)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x51C5340", Offset = "0x51C4740", VA = "0x1851C5340", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x51C4940", Offset = "0x51C3D40", VA = "0x1851C4940", Slot = "14")]
		public override void Initialize([Optional] NetworkManager IICLHHNPNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x51C40F0", Offset = "0x51C34F0", VA = "0x1851C40F0")]
		private KLPPKPAMBME AFHNHDGFPOM(NetworkDelivery IJFAMCPOKBO)
		{
			return default(KLPPKPAMBME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51C4880", Offset = "0x51C3C80", VA = "0x1851C4880", Slot = "15")]
		private void HDHOOIIHMDN(ECJINLKIFAA OGECFHAMLCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x51C4C30", Offset = "0x51C4030", VA = "0x1851C4C30", Slot = "16")]
		private void LLKNJBEAONB(ECJINLKIFAA OGECFHAMLCC, BLGBPNPKNFB DBFDAKDEOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "17")]
		private void MADGCAAKLCK(IPEndPoint HPJMBPJNMJO, SocketError JIKBGCOLCDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x51C44E0", Offset = "0x51C38E0", VA = "0x1851C44E0", Slot = "18")]
		private void GALJFNBBGAN(ECJINLKIFAA OGECFHAMLCC, PICMPIDPPGP IOJEJAFBOHN, byte AFBJLLIKKME, KLPPKPAMBME MBAELHKJDNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51C4B00", Offset = "0x51C3F00", VA = "0x1851C4B00")]
		private void KCDBGEMDLKL(int DAIAAPJIJOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "19")]
		private void FCDNMDFBLDE(IPEndPoint HFPCFGEMOPP, PICMPIDPPGP IOJEJAFBOHN, OFDMEGIGCHL EIJFHIFEAHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "20")]
		private void BFOPIEBCMFL(ECJINLKIFAA OGECFHAMLCC, int HJGMNJFJNBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51C4480", Offset = "0x51C3880", VA = "0x1851C4480", Slot = "21")]
		private void FMOHDLOMNMK(AGIBNJAGFDE PLGCCHMKBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x51C4C00", Offset = "0x51C4000", VA = "0x1851C4C00")]
		private ulong LLDMDIANONG(ECJINLKIFAA OGECFHAMLCC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51C4BE0", Offset = "0x51C3FE0", VA = "0x1851C4BE0")]
		private static int LBIGEMELGGM(float DBEHEFMCFDE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51C58E0", Offset = "0x51C4CE0", VA = "0x1851C58E0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class AAKFAOIADMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly ECJINLKIFAA EJAHKFALFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<LECKAJNALJP> JGGJIIPECHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JABMOJGLLJO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x51B2110", Offset = "0x51B1510", VA = "0x1851B2110")]
	protected AAKFAOIADMM(ECJINLKIFAA OGECFHAMLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x51B20B0", Offset = "0x51B14B0", VA = "0x1851B20B0")]
	public void LJFEAJLEKGL(LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x51B2030", Offset = "0x51B1430", VA = "0x1851B2030")]
	protected void INMAACDJGMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51B1FF0", Offset = "0x51B13F0", VA = "0x1851B1FF0")]
	public bool BMFKLLIIIPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool ELLAMODHICC();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool BGCCBHGMLEB(LECKAJNALJP PDEHJHDJEHH);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CHMEFIAMKGN
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
public class AGIBNJAGFDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ILNAMGHDHPE CNGDNJLPPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int PPLABGHOFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal ILFFBAIHNJL OCMBNOPAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IBNMBIJBILN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CHMEFIAMKGN HDIIMCLFKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x785BA0", Offset = "0x784FA0", VA = "0x180785BA0")]
		[CompilerGenerated]
		get
		{
			return default(CHMEFIAMKGN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8124B0", Offset = "0x8118B0", VA = "0x1808124B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51B2240", Offset = "0x51B1640", VA = "0x1851B2240")]
	internal void GOCLBJGKKFK(ILFFBAIHNJL ENKHOIOOAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51B2210", Offset = "0x51B1610", VA = "0x1851B2210")]
	private bool GABKANFDDLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x51B22A0", Offset = "0x51B16A0", VA = "0x1851B22A0")]
	internal AGIBNJAGFDE(IPEndPoint HFPCFGEMOPP, ILFFBAIHNJL IJEFGEHIEIA, ILNAMGHDHPE BEMHEPHJKFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x51B21B0", Offset = "0x51B15B0", VA = "0x1851B21B0")]
	public ECJINLKIFAA DEOLGDEJGCG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OFDMEGIGCHL
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum ODALLFCLGMF
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
public struct BLGBPNPKNFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public ODALLFCLGMF NKMCMLMHAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BHHALKAKFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PICMPIDPPGP GHLDCOMJPPB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OPHJBCKCGMB
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCLMPLOLDGD(ECJINLKIFAA OGECFHAMLCC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGLNLHJNCFB(ECJINLKIFAA OGECFHAMLCC, BLGBPNPKNFB DBFDAKDEOJG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKDFIFHKJDE(IPEndPoint HPJMBPJNMJO, SocketError JIKBGCOLCDM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNLLDLLPBAN(ECJINLKIFAA OGECFHAMLCC, PICMPIDPPGP IOJEJAFBOHN, byte AFBJLLIKKME, KLPPKPAMBME MBAELHKJDNO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPGHDDNLIIK(IPEndPoint HFPCFGEMOPP, PICMPIDPPGP IOJEJAFBOHN, OFDMEGIGCHL EIJFHIFEAHE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PEODDEABGBO(ECJINLKIFAA OGECFHAMLCC, int HJGMNJFJNBK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEHCJBPPKFE(AGIBNJAGFDE PLGCCHMKBMF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LHAMNAKAJIH
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPNHAMLDKPF(ECJINLKIFAA OGECFHAMLCC, object FJNGLAKPPDG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IIDDKOGONIA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMMOHOEMBIL(MCCOJIACMHO PDEHJHDJEHH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ODIHCCBDKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJCJCEECDNB(ECJINLKIFAA OGECFHAMLCC, IPEndPoint CFCDOBKMAKF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class ILFFBAIHNJL
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int INOIAPBJHEE = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long KMJBAAKGDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte OCFBKMBHKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] FJLGHNGFLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly CGMFCOEHEAJ AABHDJGOCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int BLLFJPKLHLL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51BB200", Offset = "0x51BA600", VA = "0x1851BB200")]
	private ILFFBAIHNJL(long BFFCCPGACDC, byte JOBNBMOJFNP, int PIBFDGEOBKF, byte[] CJAPNHGAFJB, CGMFCOEHEAJ GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51BADA0", Offset = "0x51BA1A0", VA = "0x1851BADA0")]
	public static int EJCCKKCCAJO(LECKAJNALJP PDEHJHDJEHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51BAE00", Offset = "0x51BA200", VA = "0x1851BAE00")]
	public static ILFFBAIHNJL KAHPMFPOCJL(LECKAJNALJP PDEHJHDJEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51BB020", Offset = "0x51BA420", VA = "0x1851BB020")]
	public static LECKAJNALJP PFBHOBOANBJ(DIPMIPMIGAD AGBLOJKPPGC, SocketAddress BBGMDMCGKAB, long NBAEGNMDMPO, int PIBFDGEOBKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class IBEFJKPJHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long KMJBAAKGDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte OCFBKMBHKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int BLLFJPKLHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool AINCEHNGOME;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51BAD50", Offset = "0x51BA150", VA = "0x1851BAD50")]
	private IBEFJKPJHFA(long BFFCCPGACDC, byte JOBNBMOJFNP, int MELMALCICIE, bool BHGEHDCEFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51BAB10", Offset = "0x51B9F10", VA = "0x1851BAB10")]
	public static IBEFJKPJHFA KAHPMFPOCJL(LECKAJNALJP PDEHJHDJEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x51BAC60", Offset = "0x51BA060", VA = "0x1851BAC60")]
	public static LECKAJNALJP PFBHOBOANBJ(long NBAEGNMDMPO, byte HNEBDIHPENB, int FFELGPBGLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51BAA10", Offset = "0x51B9E10", VA = "0x1851BAA10")]
	public static LECKAJNALJP EFANDEDLHOD(ECJINLKIFAA OGECFHAMLCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct LMBCPNDPIHL : IEquatable<LMBCPNDPIHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long DLDLJJJHJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long OAIGKEDHKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long FCDMLBIGKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int CEHACIPJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int HPHGPGJLNBM;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51C4000", Offset = "0x51C3400", VA = "0x1851C4000")]
	public LMBCPNDPIHL(byte[] JDLBGJDPMCL, int DKAEIGFECOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x785BA0", Offset = "0x784FA0", VA = "0x180785BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x51C3FC0", Offset = "0x51C33C0", VA = "0x1851C3FC0", Slot = "4")]
	public bool Equals(LMBCPNDPIHL LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51C3F10", Offset = "0x51C3310", VA = "0x1851C3F10", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PFKDCDILNPN : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] JEFEEPJNOJE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51C9070", Offset = "0x51C8470", VA = "0x1851C9070")]
	public PFKDCDILNPN(byte[] JDLBGJDPMCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class DFFMBANJFPC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class GCOEPOBBHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51BA290", Offset = "0x51B9690", VA = "0x1851BA290")]
		public static extern int BJEDGBDAFLJ(IntPtr IJIAOHKJEKL, [In][Out] byte[] MENEHLKFHMM, [In] int DKAEIGFECOJ, [In] SocketFlags MHLCOAMGANG, [Out] byte[] LEHPMJFPEBF, [In][Out] int GFJAPLJBJGD);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51BA3D0", Offset = "0x51B97D0", VA = "0x1851BA3D0")]
		internal static extern int KFKHGOHIEBM(IntPtr IJIAOHKJEKL, [In] byte[] MENEHLKFHMM, [In] int DKAEIGFECOJ, [In] SocketFlags MHLCOAMGANG, [In] byte[] LEHPMJFPEBF, [In] int GFJAPLJBJGD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class MKMEIJJJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51C6E10", Offset = "0x51C6210", VA = "0x1851C6E10")]
		public static extern int BJEDGBDAFLJ(IntPtr IJIAOHKJEKL, [In][Out] byte[] MENEHLKFHMM, [In] int DKAEIGFECOJ, [In] SocketFlags MHLCOAMGANG, [Out] byte[] LEHPMJFPEBF, [In][Out] int GFJAPLJBJGD);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51C6F50", Offset = "0x51C6350", VA = "0x1851C6F50")]
		internal static extern int KFKHGOHIEBM(IntPtr IJIAOHKJEKL, [In] byte[] MENEHLKFHMM, [In] int DKAEIGFECOJ, [In] SocketFlags MHLCOAMGANG, [In] byte[] LEHPMJFPEBF, [In] int GFJAPLJBJGD);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool OLPDCIICENH;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool FDHOAKKIMFK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> FMFCPFLPMMN;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51B4060", Offset = "0x51B3460", VA = "0x1851B4060")]
	static DFFMBANJFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51B3B40", Offset = "0x51B2F40", VA = "0x1851B3B40")]
	public static int AJHHCNIKKML(IntPtr IJIAOHKJEKL, byte[] MENEHLKFHMM, int DKAEIGFECOJ, byte[] LEHPMJFPEBF, int GFJAPLJBJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51B3ED0", Offset = "0x51B32D0", VA = "0x1851B3ED0")]
	public static int OIMGJNDOKKE(IntPtr IJIAOHKJEKL, byte[] MENEHLKFHMM, int DKAEIGFECOJ, byte[] LEHPMJFPEBF, int GFJAPLJBJGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51B3CA0", Offset = "0x51B30A0", VA = "0x1851B3CA0")]
	public static SocketError GGDPGENMMMJ()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51B3D90", Offset = "0x51B3190", VA = "0x1851B3D90")]
	public static SocketException MMNJOAJGKPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x51B3BF0", Offset = "0x51B2FF0", VA = "0x1851B3BF0")]
	public static short CDLOCDFOMOI(IPEndPoint HFPCFGEMOPP)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum OKPFIGIKDDB
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BPMBJAGLLOB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIKCLFOPHCM(IPEndPoint EHDLCEAAJFL, IPEndPoint HFPCFGEMOPP, string KJAGMGIFCEM);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLLEACAAGMN(IPEndPoint KKEPJJKJLAM, OKPFIGIKDDB IJFAMCPOKBO, string KJAGMGIFCEM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class DDOJOIDCICF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct ECFHCIKKFMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint ACICCNJBINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint IBNMBIJBILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string GJALGAPOOGP;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct DGCLMOINNNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint KLHLLDELGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public OKPFIGIKDDB EANPJBEPKCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string GJALGAPOOGP;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class KIIDBMEMKGC
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint PDEAOFKBCIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string GJALGAPOOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public KIIDBMEMKGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class CJLIOKLENPB
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint PDEAOFKBCIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint NLJGBFMONBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GJALGAPOOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public CJLIOKLENPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class OLJEFEJBLFK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GJALGAPOOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NNHEGHNJIHI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x763C70", Offset = "0x763070", VA = "0x180763C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public OLJEFEJBLFK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly ILNAMGHDHPE ANBCCGDDBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<ECFHCIKKFMN> MOFPJPEHKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<DGCLMOINNNK> EIKHIFCCCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly CGMFCOEHEAJ FINOPEMKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly DIPMIPMIGAD CENJNPFFGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly PBKKMOJPBKP FGBFOMIAKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private BPMBJAGLLOB ILLJJHHEHIE;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int KDKDHMBAIPL = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool BGBOGEOIGBM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x51B36F0", Offset = "0x51B2AF0", VA = "0x1851B36F0")]
	internal DDOJOIDCICF(ILNAMGHDHPE OBKBMINEBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x51B3410", Offset = "0x51B2810", VA = "0x1851B3410")]
	internal void MAECGCJBGJC(IPEndPoint GACCFALBAHA, LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x222E930", Offset = "0x222DD30", VA = "0x18222E930")]
	private void FEKCACAAPAM<T>(T PDEHJHDJEHH, IPEndPoint BGICHGONLEL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x51B3280", Offset = "0x51B2680", VA = "0x1851B3280")]
	private void JIKCLFOPHCM(KIIDBMEMKGC BKFMLPGLKEL, IPEndPoint GACCFALBAHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x51B3570", Offset = "0x51B2970", VA = "0x1851B3570")]
	private void OFNDDAIBENI(CJLIOKLENPB BKFMLPGLKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x51B30E0", Offset = "0x51B24E0", VA = "0x1851B30E0")]
	private void BADBHCAKPHC(OLJEFEJBLFK BKFMLPGLKEL, IPEndPoint GACCFALBAHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KLPPKPAMBME : byte
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
public static class CEMEIPGKAEP
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] AFGMADMPLHA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int IFJEFIDJDIL;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int GOLOPOINDAH;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GCBMKFFDNEH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51B5510", Offset = "0x51B4910", VA = "0x1851B5510")]
	public GCBMKFFDNEH(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class NEOPMCPMEJA : GCBMKFFDNEH
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51B5510", Offset = "0x51B4910", VA = "0x1851B5510")]
	public NEOPMCPMEJA(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum FKLENJJJMEM
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
public interface MBBHEBKAJOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGIOOHPJOEF(FKLENJJJMEM CDDCFIPCBGB, string JPCPLJECFKH, params object[] CAAIHKBHIAA);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class GFKJEGMLGKM
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static MBBHEBKAJOJ DNAHOOHGDED;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object BDMMDJFLHHA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x51BA510", Offset = "0x51B9910", VA = "0x1851BA510")]
	private static void EEAHKNIKGON(FKLENJJJMEM NIJDIANLCIJ, string JPCPLJECFKH, params object[] CAAIHKBHIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x51BA4B0", Offset = "0x51B98B0", VA = "0x1851BA4B0")]
	internal static void DMBMAMEBPBF(string JPCPLJECFKH, params object[] CAAIHKBHIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x51BA740", Offset = "0x51B9B40", VA = "0x1851BA740")]
	internal static void IPIAOKAMIIN(string JPCPLJECFKH, params object[] CAAIHKBHIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51BA7A0", Offset = "0x51B9BA0", VA = "0x1851BA7A0")]
	internal static void MOGDCAFIANA(string JPCPLJECFKH, params object[] CAAIHKBHIAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum AOAMDPGMDBB
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PICMPIDPPGP : CGMFCOEHEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private LECKAJNALJP GCLGDMKCAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly ILNAMGHDHPE JIPDAOHAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NCEABBCNOLJ ICOGEJOCAEB;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x51C9500", Offset = "0x51C8900", VA = "0x1851C9500")]
	internal PICMPIDPPGP(ILNAMGHDHPE GCLFDBLLOOM, NCEABBCNOLJ NEHAPFODGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x51C9460", Offset = "0x51C8860", VA = "0x1851C9460")]
	internal void KMCKEIAEAPA(LECKAJNALJP PDEHJHDJEHH, int PFFABMOJJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51C93E0", Offset = "0x51C87E0", VA = "0x1851C93E0")]
	internal void JGPCCAPPKIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51C94D0", Offset = "0x51C88D0", VA = "0x1851C94D0")]
	public void MGKDLBGFEGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class NCEABBCNOLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum KFLCIJJJNFG
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
	public NCEABBCNOLJ IMBJMHKHAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public KFLCIJJJNFG EANPJBEPKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public ECJINLKIFAA EJAHKFALFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint IBNMBIJBILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object JCBLNMPEAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int NNEFKGJCBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError GOBNJPNIJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public ODALLFCLGMF FLCHBDLCPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AGIBNJAGFDE NPMIIOAJAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public KLPPKPAMBME IJBHDBGNMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte DMNGCFBOONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly PICMPIDPPGP BPBBKNICIKH;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x51C7030", Offset = "0x51C6430", VA = "0x1851C7030")]
	public NCEABBCNOLJ(ILNAMGHDHPE GCLFDBLLOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class ILNAMGHDHPE : IEnumerable<ECJINLKIFAA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class PLGLPLIIKAH : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x51C9550", Offset = "0x51C8950", VA = "0x1851C9550", Slot = "4")]
		public bool Equals(IPEndPoint MHJJOHHKIPH, IPEndPoint DFACBIDGKFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4CBDBA0", Offset = "0x4CBCFA0", VA = "0x184CBDBA0", Slot = "5")]
		public int GetHashCode(IPEndPoint BAFDGKKJJJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PLGLPLIIKAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct MIMACKGKCKJ : IEnumerator<ECJINLKIFAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ECJINLKIFAA FBNLJPBIKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private ECJINLKIFAA PBKAKCHIPLO;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ECJINLKIFAA PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xDDA2F0", Offset = "0xDD96F0", VA = "0x180DDA2F0")]
		public MIMACKGKCKJ(ECJINLKIFAA DCHCBCCCIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x51C6D70", Offset = "0x51C6170", VA = "0x1851C6D70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x51C6DC0", Offset = "0x51C61C0", VA = "0x1851C6DC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread BCDMFJJIBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool LPOGCLKLFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent CKLKHFIOELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<NCEABBCNOLJ> JPLOIEKDLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<NCEABBCNOLJ> AFEDOOIBJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NCEABBCNOLJ IBMIPHCLDDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OPHJBCKCGMB KAIPLELPMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly LHAMNAKAJIH MAICHDALAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IIDDKOGONIA IEMHGBMBFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly ODIHCCBDKLF HMFAAGPNEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, ECJINLKIFAA> BFOMFJKKGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, AGIBNJAGFDE> PFDHAAJPNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, EFNCOBIHJMK> FIIBNEHJFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim AIGEPDPFJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private ECJINLKIFAA LMLCBNFKGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int LJHCAANJEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<ECJINLKIFAA> CFKKICIHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private ECJINLKIFAA[] OELHKKLJMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly BBPDLGGDKAA FIMMPMMEEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int CPPDFDOCGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> OBLPOKNIPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte IKOFFGOJBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object OONLJCLLMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool OFNBIPBOGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool LIOHKDPICHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int LDAMFMPGLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int EDEJEDOBMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CFMGBDCAMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool LDLHKDKLELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool COMCJEMAHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int JLBIOFBGKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int PFHKGAIMCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int MHGGOIAAHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool BGBOGEOIGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool OPFFFIABCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool FICHCMOBNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool FBOBKJDMKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int JKDAFLFIGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int NBEBAJKBLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool BJJMFIJMGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly FOOPECMNKEG IHFLPJPMBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool BPCFAMLJOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly DDOJOIDCICF LIBMMCLAMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool AINCLMMIEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public AOAMDPGMDBB CIHLGMINIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int OEMIIIJNGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool BAKEKCKEAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool MNKCPEHHOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool MMCJBBMOBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool NBLKFPIKIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private LECKAJNALJP HGLOFCFJDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int LHJHLOEDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object KFGLOCMHEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int JBFEHAGOIGK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int IHCBFOMAOMC = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket FAMKEBGOBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket FLFGOENODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread EKECBKJNMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread GMNMFGHOPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint PIFALCFFJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint IMJJAPMBDDM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] BOODKJJNOJD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] MMJBCGMLLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<LMBCPNDPIHL, IPEndPoint> DKCDIBPOKCO;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int IGNENLONFDC = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress DAPLPPJEOFA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool PIKEBFHOILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int PKFMCLEIJDE;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KMJBMANEOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x118B5B0", Offset = "0x118A9B0", VA = "0x18118B5B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x118B5C0", Offset = "0x118A9C0", VA = "0x18118B5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IDOAJHFMNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x143C480", Offset = "0x143B880", VA = "0x18143C480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x143C1D0", Offset = "0x143B5D0", VA = "0x18143C1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte POHNBNEODLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x859D50", Offset = "0x859150", VA = "0x180859D50")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LNPDPCBBEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x51BB270", Offset = "0x51BA670", VA = "0x1851BB270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short FGPDCCNEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x51C2350", Offset = "0x51C1750", VA = "0x1851C2350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51BEE70", Offset = "0x51BE270", VA = "0x1851BEE70")]
	public void HLGJNBLPKLG(IPEndPoint HPJMBPJNMJO, byte[] DGCJCBHPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51BE0E0", Offset = "0x51BD4E0", VA = "0x1851BE0E0")]
	public void FOKAJFAKMBK(IPEndPoint HPJMBPJNMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x51BFB90", Offset = "0x51BEF90", VA = "0x1851BFB90")]
	private bool KDBKAFALLOG(IPEndPoint HPJMBPJNMJO, [Out] ECJINLKIFAA OGECFHAMLCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51BE3A0", Offset = "0x51BD7A0", VA = "0x1851BE3A0")]
	private void GEICDPAEEPC(ECJINLKIFAA OGECFHAMLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51BD970", Offset = "0x51BCD70", VA = "0x1851BD970")]
	private void FBDDJAIFBDH(ECJINLKIFAA OGECFHAMLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51C1600", Offset = "0x51C0A00", VA = "0x1851C1600")]
	private void OHNGKKELBHI(ECJINLKIFAA OGECFHAMLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x51C28D0", Offset = "0x51C1CD0", VA = "0x1851C28D0")]
	public ILNAMGHDHPE(OPHJBCKCGMB BEMHEPHJKFJ, [Optional] BBPDLGGDKAA OPDOJLJJIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51BB4E0", Offset = "0x51BA8E0", VA = "0x1851BB4E0")]
	internal void BNAIDCMOHDL(ECJINLKIFAA BJJMIPFINAB, int HJGMNJFJNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x51BEE20", Offset = "0x51BE220", VA = "0x1851BEE20")]
	internal void HBKDGPNICLF(ECJINLKIFAA BJJMIPFINAB, object FJNGLAKPPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x51C1070", Offset = "0x51C0470", VA = "0x1851C1070")]
	internal void LIFAPGCGDON(ECJINLKIFAA OGECFHAMLCC, ODALLFCLGMF NNMKOPJHOFI, SocketError NDOOMFONNCK, LECKAJNALJP ACDNJPHPGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x51BB340", Offset = "0x51BA740", VA = "0x1851BB340")]
	private void APCGMENIDJN(ECJINLKIFAA OGECFHAMLCC, ODALLFCLGMF NNMKOPJHOFI, SocketError NDOOMFONNCK, bool EFLODOEECNL, byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int OGEHFGGOGMJ, LECKAJNALJP ACDNJPHPGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x51C1240", Offset = "0x51C0640", VA = "0x1851C1240")]
	private void NKJKMCBAEPB(NCEABBCNOLJ.KFLCIJJJNFG IJFAMCPOKBO, [Optional] ECJINLKIFAA OGECFHAMLCC, [Optional] IPEndPoint HFPCFGEMOPP, SocketError PBOIJGEHGIH = SocketError.Success, int HJGMNJFJNBK = 0, ODALLFCLGMF JFMCLODMMAO = ODALLFCLGMF.ConnectionFailed, [Optional] AGIBNJAGFDE AGMIDADFPKE, KLPPKPAMBME MBAELHKJDNO = KLPPKPAMBME.Unreliable, byte AFBJLLIKKME = 0, [Optional] LECKAJNALJP BCOPNPCGCBP, [Optional] object FJNGLAKPPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x51BE660", Offset = "0x51BDA60", VA = "0x1851BE660")]
	private void GNECLJNFCFP(NCEABBCNOLJ NEHAPFODGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x51C1140", Offset = "0x51C0540", VA = "0x1851C1140")]
	internal void MLCIALNHHGM(NCEABBCNOLJ NEHAPFODGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x51BD630", Offset = "0x51BCA30", VA = "0x1851BD630")]
	private void FBCDIKPHHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x51BFC20", Offset = "0x51BF020", VA = "0x1851BFC20")]
	private void KEOFJMGDJEH(int MEKJLHCOIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x51BEF10", Offset = "0x51BE310", VA = "0x1851BEF10")]
	internal ECJINLKIFAA IAHOOEFPLAM(AGIBNJAGFDE PLGCCHMKBMF, byte[] NGHAPEINAIH, int NBBMHNNJHFB, int KIHHOMBMMEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x51BF890", Offset = "0x51BEC90", VA = "0x1851BF890")]
	private int IPJOPJKILNF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x51BD9C0", Offset = "0x51BCDC0", VA = "0x1851BD9C0")]
	private void FJAKKNBHEAE(IPEndPoint HFPCFGEMOPP, ECJINLKIFAA GPMDHMOKILK, ILFFBAIHNJL OLMKAJOBPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51C02C0", Offset = "0x51BF6C0", VA = "0x1851C02C0")]
	private void KOLOMELCMBN(LECKAJNALJP PDEHJHDJEHH, IPEndPoint HFPCFGEMOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x51BDE20", Offset = "0x51BD220", VA = "0x1851BDE20")]
	internal void FOIFBNKFCMD(LECKAJNALJP PDEHJHDJEHH, KLPPKPAMBME BKEOAKFHKEK, byte AFBJLLIKKME, int PFFABMOJJDO, ECJINLKIFAA BJJMIPFINAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x51BC920", Offset = "0x51BBD20", VA = "0x1851BC920")]
	public bool DOIBKMNMIJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x51BD110", Offset = "0x51BC510", VA = "0x1851BD110")]
	public bool DOIBKMNMIJN(IPAddress MCBOKLMMHCL, IPAddress EMGPFHBDCMI, int OGAEHODNLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x51BD130", Offset = "0x51BC530", VA = "0x1851BD130")]
	public bool DOIBKMNMIJN(int OGAEHODNLPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x51BF910", Offset = "0x51BED10", VA = "0x1851BF910")]
	public void JFOCPPFBKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x51BB530", Offset = "0x51BA930", VA = "0x1851BB530")]
	public ECJINLKIFAA CKBAKKEHGHK(string JDLBGJDPMCL, int OGAEHODNLPI, string DGCJCBHPPBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x51BB9E0", Offset = "0x51BADE0", VA = "0x1851BB9E0")]
	public ECJINLKIFAA CKBAKKEHGHK(string JDLBGJDPMCL, int OGAEHODNLPI, DIPMIPMIGAD OFFGMJHABOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x51BB610", Offset = "0x51BAA10", VA = "0x1851BB610")]
	public ECJINLKIFAA CKBAKKEHGHK(IPEndPoint BGICHGONLEL, DIPMIPMIGAD OFFGMJHABOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x51C2340", Offset = "0x51C1740", VA = "0x1851C2340")]
	public void PGBHPLOICIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x51C2020", Offset = "0x51C1420", VA = "0x1851C2020")]
	public void PGBHPLOICIP(bool PPDMNAGHIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x51C1E00", Offset = "0x51C1200", VA = "0x1851C1E00")]
	public void OPKFHLDOBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x51C1F00", Offset = "0x51C1300", VA = "0x1851C1F00")]
	public void OPKFHLDOBDC(byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x51BB290", Offset = "0x51BA690", VA = "0x1851BB290")]
	public void APCGMENIDJN(ECJINLKIFAA OGECFHAMLCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x51BB420", Offset = "0x51BA820", VA = "0x1851BB420")]
	public void APCGMENIDJN(ECJINLKIFAA OGECFHAMLCC, byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x51C26F0", Offset = "0x51C1AF0", VA = "0x1851C26F0", Slot = "4")]
	private IEnumerator<ECJINLKIFAA> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x51C2780", Offset = "0x51C1B80", VA = "0x1851C2780", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x51BC830", Offset = "0x51BBC30", VA = "0x1851BC830")]
	private LECKAJNALJP DGDDJPHDAJJ(EAGLFDPLFOI ANNDMLIIDLL, int DAIAAPJIJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x51BC750", Offset = "0x51BBB50", VA = "0x1851BC750")]
	private LECKAJNALJP DGDDJPHDAJJ(EAGLFDPLFOI ANNDMLIIDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x51BF530", Offset = "0x51BE930", VA = "0x1851BF530")]
	internal LECKAJNALJP IKBIGMJJDGF(int DAIAAPJIJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x51BE230", Offset = "0x51BD630", VA = "0x1851BE230")]
	internal void GAEMAHKMEFG(LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x51C2810", Offset = "0x51C1C10", VA = "0x1851C2810")]
	static ILNAMGHDHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x118B5B0", Offset = "0x118A9B0", VA = "0x18118B5B0")]
	private bool ENMLFMOLLEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x51BD540", Offset = "0x51BC940", VA = "0x1851BD540")]
	private void ELCEIKENCJK(IPEndPoint KNMFHODKEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x51BFAB0", Offset = "0x51BEEB0", VA = "0x1851BFAB0")]
	private void JMIBLDIBDML(IPEndPoint KNMFHODKEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x51BF6F0", Offset = "0x51BEAF0", VA = "0x1851BF6F0")]
	private bool INLPMGHIIPD(SocketException APLJIBADEAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x51C0070", Offset = "0x51BF470", VA = "0x1851C0070")]
	private void KNCEJLLIFLC(Socket OBKBMINEBDP, EndPoint ILCELPBLJLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x51BD1B0", Offset = "0x51BC5B0", VA = "0x1851BD1B0")]
	private void EFGGBDCMKOD(object JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x51C2380", Offset = "0x51C1780", VA = "0x1851C2380")]
	private void PNLNBGBDIBJ(object JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x51BC930", Offset = "0x51BBD30", VA = "0x1851BC930")]
	public bool DOIBKMNMIJN(IPAddress MCBOKLMMHCL, IPAddress EMGPFHBDCMI, int OGAEHODNLPI, bool FBKOJNCIBHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x51C1860", Offset = "0x51C0C60", VA = "0x1851C1860")]
	private bool OIEMLPNMJBC(Socket OBKBMINEBDP, IPEndPoint KNMFHODKEPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x51C1010", Offset = "0x51C0410", VA = "0x1851C1010")]
	internal int LCKEHPLEGHH(LECKAJNALJP PDEHJHDJEHH, IPEndPoint HFPCFGEMOPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x51BBAC0", Offset = "0x51BAEC0", VA = "0x1851BBAC0")]
	internal int DCMDBEAPAKK(LECKAJNALJP PDEHJHDJEHH, IPEndPoint HFPCFGEMOPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x51BBB00", Offset = "0x51BAF00", VA = "0x1851BBB00")]
	internal int DCMDBEAPAKK(byte[] NJKPBIBMIJE, int NBBMHNNJHFB, int KIHHOMBMMEI, IPEndPoint HFPCFGEMOPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x51BFF40", Offset = "0x51BF340", VA = "0x1851BFF40")]
	internal void KLHHANOMLKC(bool PDOJJMLCBKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum EAGLFDPLFOI : byte
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
internal sealed class LECKAJNALJP
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int KKJECIMKJKM;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] NHMIBAEKJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] CLPIEDFHBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int LMJBHMFNAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object JCBLNMPEAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public LECKAJNALJP IMBJMHKHAAP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EAGLFDPLFOI KKBMIECDJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x51C3A20", Offset = "0x51C2E20", VA = "0x1851C3A20")]
		get
		{
			return default(EAGLFDPLFOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x51C38E0", Offset = "0x51C2CE0", VA = "0x1851C38E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte OCFBKMBHKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x51C3620", Offset = "0x51C2A20", VA = "0x1851C3620")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x51C39E0", Offset = "0x51C2DE0", VA = "0x1851C39E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort HIFCGMHGEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x51C3A50", Offset = "0x51C2E50", VA = "0x1851C3A50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x51C3870", Offset = "0x51C2C70", VA = "0x1851C3870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MCGPPIHLHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x51C37E0", Offset = "0x51C2BE0", VA = "0x1851C37E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HMNINKOFNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x51C37B0", Offset = "0x51C2BB0", VA = "0x1851C37B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x51C38B0", Offset = "0x51C2CB0", VA = "0x1851C38B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JOKBDGJDJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x51C3810", Offset = "0x51C2C10", VA = "0x1851C3810")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x51C3960", Offset = "0x51C2D60", VA = "0x1851C3960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JIOOKGNHJGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x51C3650", Offset = "0x51C2A50", VA = "0x1851C3650")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x51C39A0", Offset = "0x51C2DA0", VA = "0x1851C39A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort BIGJKFJBNHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x51C35C0", Offset = "0x51C29C0", VA = "0x1851C35C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x51C3920", Offset = "0x51C2D20", VA = "0x1851C3920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x51C3AB0", Offset = "0x51C2EB0", VA = "0x1851C3AB0")]
	static LECKAJNALJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x51C3590", Offset = "0x51C2990", VA = "0x1851C3590")]
	public void AFLMPPICJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x51C3D90", Offset = "0x51C3190", VA = "0x1851C3D90")]
	public LECKAJNALJP(int DAIAAPJIJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x51C3E00", Offset = "0x51C3200", VA = "0x1851C3E00")]
	public LECKAJNALJP(EAGLFDPLFOI ANNDMLIIDLL, int DAIAAPJIJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x51C36B0", Offset = "0x51C2AB0", VA = "0x1851C36B0")]
	public static int FENMFMJPOBE(EAGLFDPLFOI ANNDMLIIDLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x51C3720", Offset = "0x51C2B20", VA = "0x1851C3720")]
	public int FENMFMJPOBE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x51C3490", Offset = "0x51C2890", VA = "0x1851C3490")]
	public bool AADMFFMDAHK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum MCNHCHLIOJB : byte
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
internal enum GHMFMLHAJAL
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
internal enum BALNLBAEJGL
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum FFEAAFLBJPL
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class ECJINLKIFAA
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class FPPIJBMLNHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public LECKAJNALJP[] PMJBHDDPKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int GMFMGDEBGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int CEHACHIOHKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte HMNINKOFNHD;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public FPPIJBMLNHG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void FKNDKAIHFAG(ulong KIFDEDINMCC, int HGLDKNPEBKH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int OBIAOMFDNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int DLHNOIBAKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int EBCABLCMDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double KDLECLPMKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int FNJAIDFLAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int CALONBCPJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch JBDEIBIAJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int PCDDPOBKHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long POGMOOKGOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object DBCMLCJPIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal ECJINLKIFAA MCICJCFFHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal ECJINLKIFAA GEHOFPNPBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<LECKAJNALJP> NJKHOAKKOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<AAKFAOIADMM> KAKBNGBOFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly AAKFAOIADMM[] HLAJEKKAAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int FNJBIIFEJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int DJMDGABEEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool MBLOIBOIFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int MINOLBGBHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int LBKOPIDFOHC;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int KCCCFHAPIIJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int FJMPDKIHLHO = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object DNOBFOIPHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int NDIDIAKLBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, FPPIJBMLNHG> HJFLOAPHDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> ELLBKPMNKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly LECKAJNALJP BFENIAJMCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int ICNJDNPCJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int JIDINJHJIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint ALCHBJFGFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int MHBIPECGMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int IAHHNDLNPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long GKDBKOGGDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte JIPFMIEBEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private MCNHCHLIOJB DMKHFOHFHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private LECKAJNALJP BNDMLGPPDCI;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int HBPKGMMDKIF = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int OJGMJCHNIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly LECKAJNALJP AENNCHLBIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly LECKAJNALJP GHFCGOLFKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly LECKAJNALJP LANFLAOJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly LECKAJNALJP GGILAEFJKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly ILNAMGHDHPE BFIDMGIJDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int FPOLJBGEJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object FOCHDDMLMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly FOOPECMNKEG IHFLPJPMBDG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte AMMCJONBBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xFCBF30", Offset = "0xFCB330", VA = "0x180FCBF30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x51B5FB0", Offset = "0x51B53B0", VA = "0x1851B5FB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint EIMPPEBDAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5B0", Offset = "0x8BA9B0", VA = "0x1808BB5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MCNHCHLIOJB KNMPKEMHOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xFCBF60", Offset = "0xFCB360", VA = "0x180FCBF60")]
		get
		{
			return default(MCNHCHLIOJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long GBEKMKBPIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5C0", Offset = "0x8BA9C0", VA = "0x1808BB5C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IHKFJILAEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x143C490", Offset = "0x143B890", VA = "0x18143C490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x143BBD0", Offset = "0x143AFD0", VA = "0x18143BBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JEPFCEFBLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x51B7F60", Offset = "0x51B7360", VA = "0x1851B7F60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GJBCHCLKDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x77B8E0", Offset = "0x77ACE0", VA = "0x18077B8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double PHMAOFKGPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x163AB50", Offset = "0x1639F50", VA = "0x18163AB50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FKNDKAIHFAG MPGIPKKCCLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x51B7B40", Offset = "0x51B6F40", VA = "0x1851B7B40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x51B7EB0", Offset = "0x51B72B0", VA = "0x1851B7EB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x51B8C10", Offset = "0x51B8010", VA = "0x1851B8C10")]
	internal ECJINLKIFAA(ILNAMGHDHPE OFEDJMJCGKA, IPEndPoint HFPCFGEMOPP, int PIKCMFPLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x51B75D0", Offset = "0x51B69D0", VA = "0x1851B75D0")]
	internal void IPAFJJEMJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x51B75F0", Offset = "0x51B69F0", VA = "0x1851B75F0")]
	internal void JPKJDBLOIJN(IPEndPoint ANAGKJMAICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x51B6060", Offset = "0x51B5460", VA = "0x1851B6060")]
	internal void DPIPFBOPONC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x51B7A70", Offset = "0x51B6E70", VA = "0x1851B7A70")]
	private void LPGJAGNFFGI(int GGOHFBOICJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x51B75A0", Offset = "0x51B69A0", VA = "0x1851B75A0")]
	private void IKFGONNICBC(int ICAAOECGLIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x51B8A60", Offset = "0x51B7E60", VA = "0x1851B8A60")]
	private AAKFAOIADMM PPIAKLPLOLM(byte FPPGKNBCDNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x51B9070", Offset = "0x51B8470", VA = "0x1851B9070")]
	internal ECJINLKIFAA(ILNAMGHDHPE OFEDJMJCGKA, IPEndPoint HFPCFGEMOPP, int PIKCMFPLBNL, byte HNEBDIHPENB, DIPMIPMIGAD AGBLOJKPPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x51B9200", Offset = "0x51B8600", VA = "0x1851B9200")]
	internal ECJINLKIFAA(ILNAMGHDHPE OFEDJMJCGKA, AGIBNJAGFDE PLGCCHMKBMF, int PIKCMFPLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x51B7F70", Offset = "0x51B7370", VA = "0x1851B7F70")]
	internal void NKGOANDAPMC(ILFFBAIHNJL DGPMDJGHFEJ, byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x51B5F30", Offset = "0x51B5330", VA = "0x1851B5F30")]
	internal bool CPEKIGODNEG(IBEFJKPJHFA PDEHJHDJEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x51B60F0", Offset = "0x51B54F0", VA = "0x1851B60F0")]
	public void FEKCACAAPAM(byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int KIHHOMBMMEI, KLPPKPAMBME PHAIIGMLKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x51B8510", Offset = "0x51B7910", VA = "0x1851B8510")]
	private void PHFPADMIHIM(byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int KIHHOMBMMEI, byte AFBJLLIKKME, KLPPKPAMBME MBAELHKJDNO, object FJNGLAKPPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x51B5620", Offset = "0x51B4A20", VA = "0x1851B5620")]
	public void AEFMOCBEJCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x51B7620", Offset = "0x51B6A20", VA = "0x1851B7620")]
	internal BALNLBAEJGL KDICEDJOBKE(LECKAJNALJP PDEHJHDJEHH)
	{
		return default(BALNLBAEJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x51B7700", Offset = "0x51B6B00", VA = "0x1851B7700")]
	internal void KFBIPBEKDMA(AAKFAOIADMM GDOHLBCLKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x51B7760", Offset = "0x51B6B60", VA = "0x1851B7760")]
	internal FFEAAFLBJPL LBGGCCPPAJH(byte[] GHFAAPNAFDE, int NBBMHNNJHFB, int KIHHOMBMMEI, bool EFLODOEECNL)
	{
		return default(FFEAAFLBJPL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x51B6BD0", Offset = "0x51B5FD0", VA = "0x1851B6BD0")]
	private void HJLLBNKJHML(int EJPEPEOBKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x51B6C10", Offset = "0x51B6010", VA = "0x1851B6C10")]
	internal void HKDNHHJNPAF(KLPPKPAMBME BKEOAKFHKEK, LECKAJNALJP DCHCBCCCIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x51B7FC0", Offset = "0x51B73C0", VA = "0x1851B7FC0")]
	private void OHMCBEDLIKB(LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x51B6860", Offset = "0x51B5C60", VA = "0x1851B6860")]
	private void GOOFOEEGIKN(int HGGDOAEFCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x51B6120", Offset = "0x51B5520", VA = "0x1851B6120")]
	internal GHMFMLHAJAL FJAKKNBHEAE(ILFFBAIHNJL OLMKAJOBPCC)
	{
		return default(GHMFMLHAJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x51B56D0", Offset = "0x51B4AD0", VA = "0x1851B56D0")]
	internal void BGCCBHGMLEB(LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x51B5520", Offset = "0x51B4920", VA = "0x1851B5520")]
	private void ADKGEBCNNCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x51B5D80", Offset = "0x51B5180", VA = "0x1851B5D80")]
	internal void BHMGNAEIDOJ(LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x51B62E0", Offset = "0x51B56E0", VA = "0x1851B62E0")]
	internal void GFEAHGHFDLK(int HGGDOAEFCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x51B7BF0", Offset = "0x51B6FF0", VA = "0x1851B7BF0")]
	internal void MFDLBFIANCF(LECKAJNALJP PDEHJHDJEHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class FOOPECMNKEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long OOMNFPAPFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long PDADALFAIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DGMKHMJKKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HHKFPLEMPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long GOENMOEBHEM;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long BPFIBKCKBAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x51B95C0", Offset = "0x51B89C0", VA = "0x1851B95C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long AINEDAJOGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x51B9520", Offset = "0x51B8920", VA = "0x1851B9520")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long BDEMBILKJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x51B94F0", Offset = "0x51B88F0", VA = "0x1851B94F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long CLLIDOMHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x51B94D0", Offset = "0x51B88D0", VA = "0x1851B94D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long NAJPCAAGKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x51B9510", Offset = "0x51B8910", VA = "0x1851B9510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long KIICEPBIKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x51B9540", Offset = "0x51B8940", VA = "0x1851B9540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x51B9530", Offset = "0x51B8930", VA = "0x1851B9530")]
	public void LKPCAKCMNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x51B95A0", Offset = "0x51B89A0", VA = "0x1851B95A0")]
	public void OEOOGBNODGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x51B9500", Offset = "0x51B8900", VA = "0x1851B9500")]
	public void EPMGBKNLHMB(long KCICEJPKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x51B95B0", Offset = "0x51B89B0", VA = "0x1851B95B0")]
	public void PIJAMFCPFIL(long DPNGGPOOEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x51B94E0", Offset = "0x51B88E0", VA = "0x1851B94E0")]
	public void CMCLFECJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x51B9590", Offset = "0x51B8990", VA = "0x1851B9590")]
	public void NCOOKICIDJN(long CONELHJKMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51B95D0", Offset = "0x51B89D0", VA = "0x1851B95D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FOOPECMNKEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class KHCAEFKBEJD
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> CFBMJDNFIGC;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x51C31B0", Offset = "0x51C25B0", VA = "0x1851C31B0")]
	public static IPEndPoint PKCAEENAKAL(string GKLOAEOJLOF, int OGAEHODNLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x51C2FB0", Offset = "0x51C23B0", VA = "0x1851C2FB0")]
	public static IPAddress DKNKICJLIMM(string GKLOAEOJLOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x51C2F20", Offset = "0x51C2320", VA = "0x1851C2F20")]
	public static IPAddress DKNKICJLIMM(string GKLOAEOJLOF, AddressFamily HHPAFMGNOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x51C3180", Offset = "0x51C2580", VA = "0x1851C3180")]
	internal static int GNHEMIKPGNH(int IHAFLCFFDDD, int OCDLGNNMKIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2438790", Offset = "0x2437B90", VA = "0x182438790")]
	internal static T[] LOHADPIMAGM<T>(int OGEHFGGOGMJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class OHLAFJLOMAE : AAKFAOIADMM
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct GAFBDDOKIGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private LECKAJNALJP GCLGDMKCAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long IMJOIMPFDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool LPLOHOEACPC;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x51BA1F0", Offset = "0x51B95F0", VA = "0x1851BA1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x51BA1D0", Offset = "0x51B95D0", VA = "0x1851BA1D0")]
		public void PICNJLOMOKL(LECKAJNALJP PDEHJHDJEHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x51BA160", Offset = "0x51B9560", VA = "0x1851BA160")]
		public bool LLHGHDGKNAD(long KMKDDGFMIJP, ECJINLKIFAA OGECFHAMLCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x51BA110", Offset = "0x51B9510", VA = "0x1851BA110")]
		public bool BPHEMFKLBDC(ECJINLKIFAA OGECFHAMLCC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly LECKAJNALJP BDANIDKFOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly GAFBDDOKIGI[] ACCLGLFGBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly LECKAJNALJP[] HPAOPNODLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] AKNPLPEAFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int LOLLFJELDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int BECKMNJACNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int EDAJCKNNCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int DAJPOGMCLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool IDMIEGPMLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly KLPPKPAMBME LHNGFEKOLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool NJKIHCAFFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int GBIBMIGIGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte PEJJIJBEIBL;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x51C7F90", Offset = "0x51C7390", VA = "0x1851C7F90")]
	public OHLAFJLOMAE(ECJINLKIFAA OGECFHAMLCC, bool NHCJJLNIPKP, byte PIKCMFPLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x51C70D0", Offset = "0x51C64D0", VA = "0x1851C70D0")]
	private void BEGLIJHJBOK(LECKAJNALJP PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x51C7AE0", Offset = "0x51C6EE0", VA = "0x1851C7AE0", Slot = "4")]
	protected override bool ELLAMODHICC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x51C7480", Offset = "0x51C6880", VA = "0x1851C7480", Slot = "5")]
	public override bool BGCCBHGMLEB(LECKAJNALJP PDEHJHDJEHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class GAAAHOONECO : AAKFAOIADMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int OHJIMFPIALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort BECKMNJACNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool DLJBKKFPIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private LECKAJNALJP LHIHCHGCGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly LECKAJNALJP EEPPHPCFJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool PPGLEKNICDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte PEJJIJBEIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long BKJFGLBKEKK;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x51BA050", Offset = "0x51B9450", VA = "0x1851BA050")]
	public GAAAHOONECO(ECJINLKIFAA OGECFHAMLCC, bool BDMHIDFDAGH, byte PIKCMFPLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x51B9BE0", Offset = "0x51B8FE0", VA = "0x1851B9BE0", Slot = "4")]
	protected override bool ELLAMODHICC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x51B9900", Offset = "0x51B8D00", VA = "0x1851B9900", Slot = "5")]
	public override bool BGCCBHGMLEB(LECKAJNALJP PDEHJHDJEHH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HLGNBOHNJAI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct OKFACPNFGDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong OGOKLKNHBBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double BCCBKALDABG;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct KHGCJKOBBNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int FPPLIOJBJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float NLCLBGHDBFE;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x51B1F00", Offset = "0x51B1300", VA = "0x1851B1F00")]
	private static void PJGGCKJNAJC(byte[] FNCIFBBDALE, int APBJNEFOGOC, ulong GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x51BA8B0", Offset = "0x51B9CB0", VA = "0x1851BA8B0")]
	private static void PJGGCKJNAJC(byte[] FNCIFBBDALE, int APBJNEFOGOC, int GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x51BA9B0", Offset = "0x51B9DB0", VA = "0x1851BA9B0")]
	public static void PJGGCKJNAJC(byte[] FNCIFBBDALE, int APBJNEFOGOC, short GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x51BA9F0", Offset = "0x51B9DF0", VA = "0x1851BA9F0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, double EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x51BA920", Offset = "0x51B9D20", VA = "0x1851BA920")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x51BA9B0", Offset = "0x51B9DB0", VA = "0x1851BA9B0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, short EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x51BA9B0", Offset = "0x51B9DB0", VA = "0x1851BA9B0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, ushort EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x51BA8B0", Offset = "0x51B9CB0", VA = "0x1851BA8B0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x51BA8B0", Offset = "0x51B9CB0", VA = "0x1851BA8B0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, uint EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x51BA9A0", Offset = "0x51B9DA0", VA = "0x1851BA9A0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, long EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x51BA9A0", Offset = "0x51B9DA0", VA = "0x1851BA9A0")]
	public static void GJJPBIBCIPK(byte[] HPOLMACFBHD, int IDGHKCPGHHK, ulong EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class CGMFCOEHEAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] JGOBHHHIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int MKAMIDFDJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int PNLIJKNCCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int NFLHNFCFMAJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] CLPIEDFHBDP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PONIMMAILFL
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int OFBFDLMEJPF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x51B2970", Offset = "0x51B1D70", VA = "0x1851B2970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool HPJBDLMEMPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1B94E70", Offset = "0x1B94270", VA = "0x181B94E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DGOEDICOCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x51B28B0", Offset = "0x51B1CB0", VA = "0x1851B28B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x51B2B40", Offset = "0x51B1F40", VA = "0x1851B2B40")]
	public void KMCKEIAEAPA(byte[] OAGNBNMPALP, int APBJNEFOGOC, int EFOFMDKBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CGMFCOEHEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x51B3080", Offset = "0x51B2480", VA = "0x1851B3080")]
	public CGMFCOEHEAJ(byte[] OAGNBNMPALP, int APBJNEFOGOC, int EFOFMDKBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51B29F0", Offset = "0x51B1DF0", VA = "0x1851B29F0")]
	public IPEndPoint IIKPJKAAKNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x51B26D0", Offset = "0x51B1AD0", VA = "0x1851B26D0")]
	public byte DKAMBLOBJFC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x51B26D0", Offset = "0x51B1AD0", VA = "0x1851B26D0")]
	public sbyte JHKKBLONBJM()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x220AEC0", Offset = "0x220A2C0", VA = "0x18220AEC0")]
	public T[] KDGHHBOCOPN<T>(ushort DAIAAPJIJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x51B2600", Offset = "0x51B1A00", VA = "0x1851B2600")]
	public bool[] BGCKOLAPPMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x51B27C0", Offset = "0x51B1BC0", VA = "0x1851B27C0")]
	public ushort[] EHLMCBJBECE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x51B2510", Offset = "0x51B1910", VA = "0x1851B2510")]
	public short[] ACMDGPDBNBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x51B2AC0", Offset = "0x51B1EC0", VA = "0x1851B2AC0")]
	public int[] JNDGGNCFKNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x51B24D0", Offset = "0x51B18D0", VA = "0x1851B24D0")]
	public uint[] ABKHNMIHHMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51B2490", Offset = "0x51B1890", VA = "0x1851B2490")]
	public float[] AAAKGHCJDGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51B28C0", Offset = "0x51B1CC0", VA = "0x1851B28C0")]
	public double[] GHHDDKEFKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x51B2D20", Offset = "0x51B2120", VA = "0x1851B2D20")]
	public long[] NEJIPILANDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x51B2550", Offset = "0x51B1950", VA = "0x1851B2550")]
	public ulong[] AMDEHLKNGAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x51B2B80", Offset = "0x51B1F80", VA = "0x1851B2B80")]
	public string[] LKCPNJBCMDJ(int ICNLJAEKCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x51B2B00", Offset = "0x51B1F00", VA = "0x1851B2B00")]
	public bool KGCAOOLCPJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x51B2750", Offset = "0x51B1B50", VA = "0x1851B2750")]
	public char EBLBGKLFONM()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51B2750", Offset = "0x51B1B50", VA = "0x1851B2750")]
	public ushort MPBNAKIJIJE()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x51B2660", Offset = "0x51B1A60", VA = "0x1851B2660")]
	public short DGAHPPMPDDP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x51B2900", Offset = "0x51B1D00", VA = "0x1851B2900")]
	public long HAPOPOPCIKC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x51B2590", Offset = "0x51B1990", VA = "0x1851B2590")]
	public ulong BBLOMNMOEHE()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x51B2840", Offset = "0x51B1C40", VA = "0x1851B2840")]
	public int FLDPHGCFFKE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x51B2D60", Offset = "0x51B2160", VA = "0x1851B2D60")]
	public uint OOAAJEAMHHE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x51B2CB0", Offset = "0x51B20B0", VA = "0x1851B2CB0")]
	public float MLLNNKCADAL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x51B3010", Offset = "0x51B2410", VA = "0x1851B3010")]
	public double PNEIEAIJDGF()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x51B2DD0", Offset = "0x51B21D0", VA = "0x1851B2DD0")]
	public string PCGICEIHENF(int MHKHFOABMJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x51B2980", Offset = "0x51B1D80", VA = "0x1851B2980")]
	public ArraySegment<byte> HGOFHFKCMOJ(int OGEHFGGOGMJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x51B2710", Offset = "0x51B1B10", VA = "0x1851B2710")]
	public sbyte[] DLFOGEFDNHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x51B2800", Offset = "0x51B1C00", VA = "0x1851B2800")]
	public byte[] EPEBLLHIILM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x51B2640", Offset = "0x51B1A40", VA = "0x1851B2640")]
	public void BPHEMFKLBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class DIPMIPMIGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] JGOBHHHIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int MKAMIDFDJGD;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int NCEPMPEDKJA = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool KOEHFEALIGK;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding OEFOICAPDKG;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int CHHBLFCGGEO = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] FELHPFMJPDP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] AABHDJGOCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x51B53F0", Offset = "0x51B47F0", VA = "0x1851B53F0")]
	public DIPMIPMIGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x51B5470", Offset = "0x51B4870", VA = "0x1851B5470")]
	public DIPMIPMIGAD(bool CBOPKBDBDCF, int MAPKJDAIEGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x51B4BF0", Offset = "0x51B3FF0", VA = "0x1851B4BF0")]
	public static DIPMIPMIGAD GNBFHKFDFPI(string EOHMJBFGDPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x51B4C60", Offset = "0x51B4060", VA = "0x1851B4C60")]
	public void LPHMOKFAPFL(int CCCBBIIMNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E770", Offset = "0x1C0DB70", VA = "0x181C0E770")]
	public void OAFECOOGBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x51B5260", Offset = "0x51B4660", VA = "0x1851B5260")]
	public void NPCIOPKAABI(float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x51B5310", Offset = "0x51B4710", VA = "0x1851B5310")]
	public void NPCIOPKAABI(double EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x51B5140", Offset = "0x51B4540", VA = "0x1851B5140")]
	public void NPCIOPKAABI(long EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x51B5140", Offset = "0x51B4540", VA = "0x1851B5140")]
	public void NPCIOPKAABI(ulong EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x51B4D00", Offset = "0x51B4100", VA = "0x1851B4D00")]
	public void NPCIOPKAABI(int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x51B4D00", Offset = "0x51B4100", VA = "0x1851B4D00")]
	public void NPCIOPKAABI(uint EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x51B4FA0", Offset = "0x51B43A0", VA = "0x1851B4FA0")]
	public void NPCIOPKAABI(char EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x51B4FA0", Offset = "0x51B43A0", VA = "0x1851B4FA0")]
	public void NPCIOPKAABI(ushort EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x51B4FA0", Offset = "0x51B43A0", VA = "0x1851B4FA0")]
	public void NPCIOPKAABI(short EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x51B5010", Offset = "0x51B4410", VA = "0x1851B5010")]
	public void NPCIOPKAABI(sbyte EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x51B5010", Offset = "0x51B4410", VA = "0x1851B5010")]
	public void NPCIOPKAABI(byte EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x51B50D0", Offset = "0x51B44D0", VA = "0x1851B50D0")]
	public void NPCIOPKAABI(byte[] GHFAAPNAFDE, int APBJNEFOGOC, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x51B4B10", Offset = "0x51B3F10", VA = "0x1851B4B10")]
	public void LHFHBKEAODP(sbyte[] GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x51B4B10", Offset = "0x51B3F10", VA = "0x1851B4B10")]
	public void CEENAICOEHK(byte[] GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x51B5070", Offset = "0x51B4470", VA = "0x1851B5070")]
	public void NPCIOPKAABI(bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x51B4A30", Offset = "0x51B3E30", VA = "0x1851B4A30")]
	public void AKBLIIMELOM(Array NIDCNIGEHOM, int PBKOEDBNAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x51B46C0", Offset = "0x51B3AC0", VA = "0x1851B46C0")]
	public void AKBLIIMELOM(float[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x51B4870", Offset = "0x51B3C70", VA = "0x1851B4870")]
	public void AKBLIIMELOM(double[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x51B4870", Offset = "0x51B3C70", VA = "0x1851B4870")]
	public void AKBLIIMELOM(long[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x51B4870", Offset = "0x51B3C70", VA = "0x1851B4870")]
	public void AKBLIIMELOM(ulong[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x51B46C0", Offset = "0x51B3AC0", VA = "0x1851B46C0")]
	public void AKBLIIMELOM(int[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x51B46C0", Offset = "0x51B3AC0", VA = "0x1851B46C0")]
	public void AKBLIIMELOM(uint[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x51B4950", Offset = "0x51B3D50", VA = "0x1851B4950")]
	public void AKBLIIMELOM(ushort[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x51B4950", Offset = "0x51B3D50", VA = "0x1851B4950")]
	public void AKBLIIMELOM(short[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x51B4B10", Offset = "0x51B3F10", VA = "0x1851B4B10")]
	public void AKBLIIMELOM(bool[] EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x51B47A0", Offset = "0x51B3BA0", VA = "0x1851B47A0")]
	public void AKBLIIMELOM(string[] EOHMJBFGDPD, int HGCPPIMPFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x51B5190", Offset = "0x51B4590", VA = "0x1851B5190")]
	public void NPCIOPKAABI(IPEndPoint HPJMBPJNMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x51B5300", Offset = "0x51B4700", VA = "0x1851B5300")]
	public void NPCIOPKAABI(string EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x51B4D90", Offset = "0x51B4190", VA = "0x1851B4D90")]
	public void NPCIOPKAABI(string EOHMJBFGDPD, int MHKHFOABMJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class PBKKMOJPBKP
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class LHODJPEGJFG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong FPOLJBGEJBC;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x397E820", Offset = "0x397DC20", VA = "0x18397E820")]
		static LHODJPEGJFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void JGHDAFIGLAG(CGMFCOEHEAJ IOJEJAFBOHN, object FJNGLAKPPDG);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EHJEPDIENHI<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public PBKKMOJPBKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public EHJEPDIENHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3071420", Offset = "0x3070820", VA = "0x183071420")]
		internal void PPJOKODODOA(CGMFCOEHEAJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class KFBOAFFGNMF<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public PBKKMOJPBKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public KFBOAFFGNMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x38D4F00", Offset = "0x38D4300", VA = "0x1838D4F00")]
		internal void PPJOKODODOA(CGMFCOEHEAJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly CFBOAFIGNFL EOJNOKGLNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, JGHDAFIGLAG> KPGDJOFMEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DIPMIPMIGAD KKPBIIKBFCP;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x51C8EF0", Offset = "0x51C82F0", VA = "0x1851C8EF0")]
	public PBKKMOJPBKP(int ICNLJAEKCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x219D8E0", Offset = "0x219CCE0", VA = "0x18219D8E0", Slot = "4")]
	protected virtual ulong CHBBILBKDOI<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x51C8D40", Offset = "0x51C8140", VA = "0x1851C8D40", Slot = "5")]
	protected virtual JGHDAFIGLAG HEHMIBBPLME(CGMFCOEHEAJ IOJEJAFBOHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x25087C0", Offset = "0x2507BC0", VA = "0x1825087C0", Slot = "6")]
	protected virtual void CIAKBNKDKIP<T>(DIPMIPMIGAD MKIOBJMIBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x51C8E70", Offset = "0x51C8270", VA = "0x1851C8E70")]
	public void NDHPNIPFPLJ(CGMFCOEHEAJ IOJEJAFBOHN, object FJNGLAKPPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2508830", Offset = "0x2507C30", VA = "0x182508830")]
	public void EOCHBNCKDPC<T>(DIPMIPMIGAD MKIOBJMIBCN, T PDEHJHDJEHH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x51C8CF0", Offset = "0x51C80F0", VA = "0x1851C8CF0")]
	public void ENNNHAMEIDH(CGMFCOEHEAJ IOJEJAFBOHN, object FJNGLAKPPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2508A40", Offset = "0x2507E40", VA = "0x182508A40")]
	public void GBFAOMAEIMB<T>(Action<T> PNPKNJEOLGA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x25088C0", Offset = "0x2507CC0", VA = "0x1825088C0")]
	public void GBFAOMAEIMB<T, TUserData>(Action<T, TUserData> PNPKNJEOLGA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class DMHGNCMKBAE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x51B5510", Offset = "0x51B4910", VA = "0x1851B5510")]
	public DMHGNCMKBAE(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class PHFPLMKMNEM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x51C9380", Offset = "0x51C8780", VA = "0x1851C9380")]
	public PHFPLMKMNEM(string NJKPBIBMIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CFBOAFIGNFL
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum EPHPMHOGKCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class BBCODJMMJID<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public EPHPMHOGKCO EANPJBEPKCO;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x443CD30", Offset = "0x443C130", VA = "0x18443CD30", Slot = "4")]
		public virtual void PICNJLOMOKL(MethodInfo LIOFKBOJDOD, MethodInfo PPGALGBMPOJ, EPHPMHOGKCO IJFAMCPOKBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void ABCKJBMOALE(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PCEFEDAGNKA(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		protected BBCODJMMJID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class HAOOGOGIEHO<TClass, TProperty> : BBCODJMMJID<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> DGACDAMONBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> GBDAFDALBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> JJIHGKCAJGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> GMKHPFPHGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> CJNMCCIIDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> IAIBLGHMBPA;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x352B6F0", Offset = "0x352AAF0", VA = "0x18352B6F0", Slot = "7")]
		public override void LNPKNPECCJD(TClass HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x352AD30", Offset = "0x352A130", VA = "0x18352AD30", Slot = "8")]
		public override void DJJIILILKGB(TClass HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x352A160", Offset = "0x3529560", VA = "0x18352A160", Slot = "9")]
		public override void ABCKJBMOALE(TClass HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x352C170", Offset = "0x352B570", VA = "0x18352C170", Slot = "10")]
		public override void PCEFEDAGNKA(TClass HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x352B430", Offset = "0x352A830", VA = "0x18352B430")]
		protected TProperty[] JOCJGPHLFCI(TClass HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x352A860", Offset = "0x3529C60", VA = "0x18352A860")]
		protected TProperty[] DIDCPCGPMNN(TClass HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x352D770", Offset = "0x352CB70", VA = "0x18352D770", Slot = "4")]
		public override void PICNJLOMOKL(MethodInfo LIOFKBOJDOD, MethodInfo PPGALGBMPOJ, EPHPMHOGKCO IJFAMCPOKBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x34DF1B0", Offset = "0x34DE5B0", VA = "0x1834DF1B0")]
		protected HAOOGOGIEHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class DHHCFLIAKOA<TClass, TProperty> : HAOOGOGIEHO<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OKDJNMEANLH(CGMFCOEHEAJ LNNNOJDNMEH, [Out] TProperty NPHJLOJKBMK);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void KKMPPNEMKGD(DIPMIPMIGAD JMLFIKJGAAF, TProperty NPHJLOJKBMK);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F270", Offset = "0x4C8E670", VA = "0x184C8F270", Slot = "5")]
		public override void OEAJMABMJDL(TClass HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EFD0", Offset = "0x4C8E3D0", VA = "0x184C8EFD0", Slot = "6")]
		public override void EOCHBNCKDPC(TClass HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F0B0", Offset = "0x4C8E4B0", VA = "0x184C8F0B0", Slot = "7")]
		public override void LNPKNPECCJD(TClass HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EE90", Offset = "0x4C8E290", VA = "0x184C8EE90", Slot = "8")]
		public override void DJJIILILKGB(TClass HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3459D50", Offset = "0x3459150", VA = "0x183459D50")]
		protected DHHCFLIAKOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class KBDPIJADFIK<T> : HAOOGOGIEHO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x38A9120", Offset = "0x38A8520", VA = "0x1838A9120", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x38A9050", Offset = "0x38A8450", VA = "0x1838A9050", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x38A90B0", Offset = "0x38A84B0", VA = "0x1838A90B0", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x34A6F40", Offset = "0x34A6340", VA = "0x1834A6F40", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public KBDPIJADFIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class DIEHLCLMKPP<T> : HAOOGOGIEHO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4C934F0", Offset = "0x4C928F0", VA = "0x184C934F0", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x38A9050", Offset = "0x38A8450", VA = "0x1838A9050", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4C93480", Offset = "0x4C92880", VA = "0x184C93480", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x34A6F40", Offset = "0x34A6340", VA = "0x1834A6F40", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public DIEHLCLMKPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class DGDKNHEIOJK<T> : HAOOGOGIEHO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D690", Offset = "0x4C8CA90", VA = "0x184C8D690", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E10BB0", Offset = "0x3E0FFB0", VA = "0x183E10BB0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D620", Offset = "0x4C8CA20", VA = "0x184C8D620", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E10B50", Offset = "0x3E0FF50", VA = "0x183E10B50", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public DGDKNHEIOJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class POOKNJHHHED<T> : HAOOGOGIEHO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3E10C80", Offset = "0x3E10080", VA = "0x183E10C80", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E10BB0", Offset = "0x3E0FFB0", VA = "0x183E10BB0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E10C10", Offset = "0x3E10010", VA = "0x183E10C10", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E10B50", Offset = "0x3E0FF50", VA = "0x183E10B50", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public POOKNJHHHED()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KDJNCGAGEGN<T> : HAOOGOGIEHO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x38C3540", Offset = "0x38C2940", VA = "0x1838C3540", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x38C3470", Offset = "0x38C2870", VA = "0x1838C3470", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x38C34D0", Offset = "0x38C28D0", VA = "0x1838C34D0", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x38C3410", Offset = "0x38C2810", VA = "0x1838C3410", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public KDJNCGAGEGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DHCOPHMIPAM<T> : HAOOGOGIEHO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EE20", Offset = "0x4C8E220", VA = "0x184C8EE20", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x38C3470", Offset = "0x38C2870", VA = "0x1838C3470", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EDB0", Offset = "0x4C8E1B0", VA = "0x184C8EDB0", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x38C3410", Offset = "0x38C2810", VA = "0x1838C3410", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public DHCOPHMIPAM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PCHANLPIBLC<T> : HAOOGOGIEHO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9590", Offset = "0x3DB8990", VA = "0x183DB9590", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3DB94C0", Offset = "0x3DB88C0", VA = "0x183DB94C0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9520", Offset = "0x3DB8920", VA = "0x183DB9520", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x34C3CA0", Offset = "0x34C30A0", VA = "0x1834C3CA0", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public PCHANLPIBLC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PDDMPHGDCJO<T> : HAOOGOGIEHO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9590", Offset = "0x3DB8990", VA = "0x183DB9590", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3DB94C0", Offset = "0x3DB88C0", VA = "0x183DB94C0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9EC0", Offset = "0x3DB92C0", VA = "0x183DB9EC0", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x34C3CA0", Offset = "0x34C30A0", VA = "0x1834C3CA0", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public PDDMPHGDCJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class AHKGBNNPJOH<T> : HAOOGOGIEHO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x34A7070", Offset = "0x34A6470", VA = "0x1834A7070", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x34A6FA0", Offset = "0x34A63A0", VA = "0x1834A6FA0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x34A7000", Offset = "0x34A6400", VA = "0x1834A7000", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x34A6F40", Offset = "0x34A6340", VA = "0x1834A6F40", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public AHKGBNNPJOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BLECFDNDJEG<T> : HAOOGOGIEHO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x484E2B0", Offset = "0x484D6B0", VA = "0x18484E2B0", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x484E1E0", Offset = "0x484D5E0", VA = "0x18484E1E0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x484E240", Offset = "0x484D640", VA = "0x18484E240", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x38C3410", Offset = "0x38C2810", VA = "0x1838C3410", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public BLECFDNDJEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GHFEODLBHFD<T> : HAOOGOGIEHO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x34C3DD0", Offset = "0x34C31D0", VA = "0x1834C3DD0", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x34C3D00", Offset = "0x34C3100", VA = "0x1834C3D00", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x34C3D60", Offset = "0x34C3160", VA = "0x1834C3D60", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x34C3CA0", Offset = "0x34C30A0", VA = "0x1834C3CA0", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x34A70E0", Offset = "0x34A64E0", VA = "0x1834A70E0")]
		public GHFEODLBHFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class HPNKHPLBDHC<T> : DHHCFLIAKOA<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x35717C0", Offset = "0x3570BC0", VA = "0x1835717C0", Slot = "12")]
		protected override void KKMPPNEMKGD(DIPMIPMIGAD JMLFIKJGAAF, char NPHJLOJKBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x35717F0", Offset = "0x3570BF0", VA = "0x1835717F0", Slot = "11")]
		protected override void OKDJNMEANLH(CGMFCOEHEAJ LNNNOJDNMEH, [Out] char NPHJLOJKBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x33DB470", Offset = "0x33DA870", VA = "0x1833DB470")]
		public HPNKHPLBDHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class ODEEJBFOONE<T> : DHHCFLIAKOA<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2480", Offset = "0x3CE1880", VA = "0x183CE2480", Slot = "12")]
		protected override void KKMPPNEMKGD(DIPMIPMIGAD JMLFIKJGAAF, IPEndPoint NPHJLOJKBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CE24B0", Offset = "0x3CE18B0", VA = "0x183CE24B0", Slot = "11")]
		protected override void OKDJNMEANLH(CGMFCOEHEAJ LNNNOJDNMEH, [Out] IPEndPoint NPHJLOJKBMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x33DB470", Offset = "0x33DA870", VA = "0x1833DB470")]
		public ODEEJBFOONE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class LONELBCJMKO<T> : HAOOGOGIEHO<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int JDOLMCIBHAA;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3987E40", Offset = "0x3987240", VA = "0x183987E40")]
		public LONELBCJMKO(int MHKHFOABMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3987DD0", Offset = "0x39871D0", VA = "0x183987DD0", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3987CF0", Offset = "0x39870F0", VA = "0x183987CF0", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3987D60", Offset = "0x3987160", VA = "0x183987D60", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3987C80", Offset = "0x3987080", VA = "0x183987C80", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class KGJPNKDHFLG<T> : BBCODJMMJID<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo KKBMIECDJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type JAKALPJHJKN;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x38D5C70", Offset = "0x38D5070", VA = "0x1838D5C70")]
		public KGJPNKDHFLG(PropertyInfo ANNDMLIIDLL, Type PAIOOAEGLIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x38D5B50", Offset = "0x38D4F50", VA = "0x1838D5B50", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x38D5A40", Offset = "0x38D4E40", VA = "0x1838D5A40", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x38D5AF0", Offset = "0x38D4EF0", VA = "0x1838D5AF0", Slot = "7")]
		public override void LNPKNPECCJD(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x38D59E0", Offset = "0x38D4DE0", VA = "0x1838D59E0", Slot = "8")]
		public override void DJJIILILKGB(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x38D5980", Offset = "0x38D4D80", VA = "0x1838D5980", Slot = "9")]
		public override void ABCKJBMOALE(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x38D5C10", Offset = "0x38D5010", VA = "0x1838D5C10", Slot = "10")]
		public override void PCEFEDAGNKA(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class NNEALLACMKO<T> : KGJPNKDHFLG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x33D7BD0", Offset = "0x33D6FD0", VA = "0x1833D7BD0")]
		public NNEALLACMKO(PropertyInfo ANNDMLIIDLL, Type PAIOOAEGLIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C27140", Offset = "0x3C26540", VA = "0x183C27140", Slot = "5")]
		public override void OEAJMABMJDL(T HEKMLHOFGNE, CGMFCOEHEAJ LNNNOJDNMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C27090", Offset = "0x3C26490", VA = "0x183C27090", Slot = "6")]
		public override void EOCHBNCKDPC(T HEKMLHOFGNE, DIPMIPMIGAD JMLFIKJGAAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class DMCIAONBPHP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static DMCIAONBPHP<T> PFONNHJIIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly BBCODJMMJID<T>[] AIBPHFPOJLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int MLJEMMHPBAO;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7610", Offset = "0x4CA6A10", VA = "0x184CA7610")]
		public DMCIAONBPHP(List<BBCODJMMJID<T>> IEGHBKFHLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4CA74B0", Offset = "0x4CA68B0", VA = "0x184CA74B0")]
		public void EOCHBNCKDPC(T BAFDGKKJJJD, DIPMIPMIGAD MKIOBJMIBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4CA7560", Offset = "0x4CA6960", VA = "0x184CA7560")]
		public void OEAJMABMJDL(T BAFDGKKJJJD, CGMFCOEHEAJ IOJEJAFBOHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class OBJDOFNCNBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BBCODJMMJID<T> OPODPAEFLEB<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private DIPMIPMIGAD NBICBEIOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int MIMOOKLGKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, OBJDOFNCNBL> MAPIJMABLDE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x51B23F0", Offset = "0x51B17F0", VA = "0x1851B23F0")]
	public CFBOAFIGNFL(int ICNLJAEKCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2202BB0", Offset = "0x2201FB0", VA = "0x182202BB0")]
	private DMCIAONBPHP<T> FPKPAGCNMPD<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x21A0D10", Offset = "0x21A0110", VA = "0x1821A0D10")]
	public void KIPDOAILNDA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2203AA0", Offset = "0x2202EA0", VA = "0x182203AA0")]
	public bool ONLENKPGCBM<T>(CGMFCOEHEAJ IOJEJAFBOHN, T BGICHGONLEL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2203B20", Offset = "0x2202F20", VA = "0x182203B20")]
	public void PJNKBIHCNDA<T>(DIPMIPMIGAD MKIOBJMIBCN, T BAFDGKKJJJD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MCCOJIACMHO
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime GNHKHLKBNGK;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] FMIFIKMGMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public GICILEFAOCE KJOHMAAHJMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x51C6250", Offset = "0x51C5650", VA = "0x1851C6250")]
		get
		{
			return default(GICILEFAOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int JBFLDJMFCHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x51C6620", Offset = "0x51C5A20", VA = "0x1851C6620")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x51C6650", Offset = "0x51C5A50", VA = "0x1851C6650")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AANEBDODBGF JGLMGGBJBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x51C66C0", Offset = "0x51C5AC0", VA = "0x1851C66C0")]
		get
		{
			return default(AANEBDODBGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x51C62B0", Offset = "0x51C56B0", VA = "0x1851C62B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FAMGOPDKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x51C6690", Offset = "0x51C5A90", VA = "0x1851C6690")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint LBHOIEKBOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x51C68C0", Offset = "0x51C5CC0", VA = "0x1851C68C0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? ANLKLHLOAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x51C5D00", Offset = "0x51C5100", VA = "0x1851C5D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? BAKBICIPGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x51C6280", Offset = "0x51C5680", VA = "0x1851C6280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? EDJDPAGFOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x51C65F0", Offset = "0x51C59F0", VA = "0x1851C65F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x51C66F0", Offset = "0x51C5AF0", VA = "0x1851C66F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? HAEMEGEEJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x95E320", Offset = "0x95D720", VA = "0x18095E320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D3F60", Offset = "0x7D3360", VA = "0x1807D3F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x51C69A0", Offset = "0x51C5DA0", VA = "0x1851C69A0")]
	public MCCOJIACMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x51C6CC0", Offset = "0x51C60C0", VA = "0x1851C6CC0")]
	internal MCCOJIACMHO(byte[] HPOLMACFBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x51C59E0", Offset = "0x51C4DE0", VA = "0x1851C59E0")]
	public static MCCOJIACMHO BKNFEMMMKCL(byte[] HPOLMACFBHD, DateTime FIMMEIDEDIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x51C5D30", Offset = "0x51C5130", VA = "0x1851C5D30")]
	internal void CMIEHIOCPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x51C6420", Offset = "0x51C5820", VA = "0x1851C6420")]
	private void HFOHNEGDADD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x51C5B00", Offset = "0x51C4F00", VA = "0x1851C5B00")]
	private DateTime? CICJJDGDFDL(int APBJNEFOGOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x51C5FF0", Offset = "0x51C53F0", VA = "0x1851C5FF0")]
	private void DMDBELJFNPM(int APBJNEFOGOC, DateTime? EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x51C62F0", Offset = "0x51C56F0", VA = "0x1851C62F0")]
	private ulong FOGENNEEAKD(int APBJNEFOGOC)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x51C5F30", Offset = "0x51C5330", VA = "0x1851C5F30")]
	private void DELFIMNLIMK(int APBJNEFOGOC, ulong EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x51C61C0", Offset = "0x51C55C0", VA = "0x1851C61C0")]
	private uint ELFHPDAPBPF(int APBJNEFOGOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x50A1F80", Offset = "0x50A1380", VA = "0x1850A1F80")]
	private static uint GHEDHJHLNCA(uint MHJJOHHKIPH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x51C63C0", Offset = "0x51C57C0", VA = "0x1851C63C0")]
	private static ulong GHEDHJHLNCA(ulong MHJJOHHKIPH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum GICILEFAOCE
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
public enum AANEBDODBGF
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class EFNCOBIHJMK
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int PPBCNCLMGDE = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int OMDAKBPKGOI = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int DIPIIEJBEMF = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint JBGGIFKAHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int EPEPBEEOMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int OHAEJOEKODO;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GGFBNCDDECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x51B93E0", Offset = "0x51B87E0", VA = "0x1851B93E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x51B93F0", Offset = "0x51B87F0", VA = "0x1851B93F0")]
	public bool FEKCACAAPAM(Socket OBKBMINEBDP, int EGHBFNCPCGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class BBPDLGGDKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int LNPDPCBBEEN;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
	protected BBPDLGGDKAA(int LLDKFOFNEHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BDODBKIADFJ(IPEndPoint HPJMBPJNMJO, byte[] GHFAAPNAFDE, int APBJNEFOGOC, int KIHHOMBMMEI);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OPJDLGEGHGE(IPEndPoint HPJMBPJNMJO, byte[] GHFAAPNAFDE, int APBJNEFOGOC, int KIHHOMBMMEI);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class OOAKGLDLDBO : BBPDLGGDKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider DMAJFICIHCH;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator DLCGDNCLKFO;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x51C8CD0", Offset = "0x51C80D0", VA = "0x1851C8CD0")]
	public OOAKGLDLDBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x51C8600", Offset = "0x51C7A00", VA = "0x1851C8600")]
	public void MGEPFJCIFGC(IPEndPoint HPJMBPJNMJO, byte[] DGCJCBHPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x51C8520", Offset = "0x51C7920", VA = "0x1851C8520")]
	public void HOIGLFGGKLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x51C8840", Offset = "0x51C7C40", VA = "0x1851C8840")]
	private byte[] OAMEHEAGGDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x51C8160", Offset = "0x51C7560", VA = "0x1851C8160", Slot = "4")]
	public override void BDODBKIADFJ(IPEndPoint HPJMBPJNMJO, byte[] GHFAAPNAFDE, int APBJNEFOGOC, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x51C88D0", Offset = "0x51C7CD0", VA = "0x1851C88D0", Slot = "5")]
	public override void OPJDLGEGHGE(IPEndPoint HPJMBPJNMJO, byte[] GHFAAPNAFDE, int APBJNEFOGOC, int KIHHOMBMMEI)
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
