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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LEHGIGPJAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum GJAAKKAPAPK
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
		private NetworkManager MJHAAJODHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, ALFNHBPHADP> OHDHNELAHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private JAFMHCGIOND AGNJAGKGFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] IHLLJELGMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private GJAAKKAPAPK NDCGCABBHMG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ILGFDPEFAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool NFLOEONLEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x67B5FE0", Offset = "0x67B53E0", VA = "0x1867B5FE0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x67B55C0", Offset = "0x67B49C0", VA = "0x1867B55C0")]
		public void RecRoom_SetEncryptionInfo(ulong ICDPBBOMIPJ, byte[] LKMGECEEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67B55A0", Offset = "0x67B49A0", VA = "0x1867B55A0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x67B5470", Offset = "0x67B4870", VA = "0x1867B5470")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x67B5EE0", Offset = "0x67B52E0", VA = "0x1867B5EE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x67B56E0", Offset = "0x67B4AE0", VA = "0x1867B56E0", Slot = "6")]
		public override void Send(ulong JPPHMPLKKOL, ArraySegment<byte> GIDGOODJFLJ, NetworkDelivery PFFPMNGGPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x67B5560", Offset = "0x67B4960", VA = "0x1867B5560", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong JPPHMPLKKOL, [Out] ArraySegment<byte> GOAPBALNOKD, [Out] float EDLAABLKNBB)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67B59D0", Offset = "0x67B4DD0", VA = "0x1867B59D0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67B5E00", Offset = "0x67B5200", VA = "0x1867B5E00", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67B4C00", Offset = "0x67B4000", VA = "0x1867B4C00", Slot = "10")]
		public override void DisconnectRemoteClient(ulong JPPHMPLKKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67B4B10", Offset = "0x67B3F10", VA = "0x1867B4B10", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67B4F20", Offset = "0x67B4320", VA = "0x1867B4F20", Slot = "12")]
		public override ulong GetCurrentRtt(ulong JPPHMPLKKOL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x67B5960", Offset = "0x67B4D60", VA = "0x1867B5960", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x67B4FC0", Offset = "0x67B43C0", VA = "0x1867B4FC0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MJHAAJODHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x67B5180", Offset = "0x67B4580", VA = "0x1867B5180")]
		private EKBGKAGOIAF LHFHIMBJLNL(NetworkDelivery BMIPLDLMPCD)
		{
			return default(EKBGKAGOIAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67B53B0", Offset = "0x67B47B0", VA = "0x1867B53B0", Slot = "15")]
		private void NMMMHIFOPPE(ALFNHBPHADP ADCGCFIHOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67B4A20", Offset = "0x67B3E20", VA = "0x1867B4A20", Slot = "16")]
		private void ACGLHHMIBCM(ALFNHBPHADP ADCGCFIHOIE, DGINEPAIMAB ILJOPNAPDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "17")]
		private void HFPHGCCIFOJ(IPEndPoint JEMILHCFMOK, SocketError IKEMGBBJIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67B4D10", Offset = "0x67B4110", VA = "0x1867B4D10", Slot = "18")]
		private void EKMPMGFLIDA(ALFNHBPHADP ADCGCFIHOIE, GPEJAICFPCL AJLILPPHPPH, byte AFKKHALCJGJ, EKBGKAGOIAF FNAOKCGIBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67B5250", Offset = "0x67B4650", VA = "0x1867B5250")]
		private void MAOAIBGIIGN(int IBMHAIHIDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "19")]
		private void IABNGFJLHEJ(IPEndPoint DBHJCCKKAMO, GPEJAICFPCL AJLILPPHPPH, EANOMKAMGKI BILLKIDNEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "20")]
		private void CPGOMKMIJNM(ALFNHBPHADP ADCGCFIHOIE, int IBDNOFKGDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67B5330", Offset = "0x67B4730", VA = "0x1867B5330", Slot = "21")]
		private void NDDFPKPPEEB(DHJDFIOGNAF NEMAHPGAGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67B4AE0", Offset = "0x67B3EE0", VA = "0x1867B4AE0")]
		private ulong DBLPDAPJEIH(ALFNHBPHADP ADCGCFIHOIE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67B5390", Offset = "0x67B4790", VA = "0x1867B5390")]
		private static int NDJMNKKOLPP(float HKPDGGGHFLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67B5F00", Offset = "0x67B5300", VA = "0x1867B5F00")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CLKEPLEHOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly ALFNHBPHADP LIFICHIFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<OLBGAHBBLGP> ENAENCCPKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int IIPCCMHNBOL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67A7030", Offset = "0x67A6430", VA = "0x1867A7030")]
	protected CLKEPLEHOIB(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F90", Offset = "0x67A6390", VA = "0x1867A6F90")]
	public void KIELEBCOCGC(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F10", Offset = "0x67A6310", VA = "0x1867A6F10")]
	protected void HOAPDJOCGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67A6FF0", Offset = "0x67A63F0", VA = "0x1867A6FF0")]
	public bool MLLHIICNPFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool ICAKHFFGKHI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GBGPPLAMAJP(OLBGAHBBLGP OLNCIJOKKAP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum DALFAKOLAKC
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
public class DHJDFIOGNAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly JAFMHCGIOND BEEPPBKGEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int JNHLFONLIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal HIAKKMOCMAP OFOGIKHDAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint PCJCGEEKJAN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal DALFAKOLAKC IONAMOKNDHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9728C0", Offset = "0x971CC0", VA = "0x1809728C0")]
		[CompilerGenerated]
		get
		{
			return default(DALFAKOLAKC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBF9220", Offset = "0xBF8620", VA = "0x180BF9220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67A82F0", Offset = "0x67A76F0", VA = "0x1867A82F0")]
	internal void HMCOMCNKFCJ(HIAKKMOCMAP ADKPFMHMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67A82C0", Offset = "0x67A76C0", VA = "0x1867A82C0")]
	private bool GAIBGKIEIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67A83B0", Offset = "0x67A77B0", VA = "0x1867A83B0")]
	internal DHJDFIOGNAF(IPEndPoint DBHJCCKKAMO, HIAKKMOCMAP EKCPBIHAHND, JAFMHCGIOND OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67A8350", Offset = "0x67A7750", VA = "0x1867A8350")]
	public ALFNHBPHADP KDKDMGHPBGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EANOMKAMGKI
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GNJIAPDJKGG
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
public struct DGINEPAIMAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GNJIAPDJKGG CBHHBBHAKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError OPNLOEHKEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GPEJAICFPCL BOAKAMNECLH;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LEHGIGPJAEJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFLAKALHCLL(ALFNHBPHADP ADCGCFIHOIE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOLGAMLGGOM(ALFNHBPHADP ADCGCFIHOIE, DGINEPAIMAB ILJOPNAPDAE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBBMGFBGPCF(IPEndPoint JEMILHCFMOK, SocketError IKEMGBBJIEE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FDNDNKFIJAL(ALFNHBPHADP ADCGCFIHOIE, GPEJAICFPCL AJLILPPHPPH, byte AFKKHALCJGJ, EKBGKAGOIAF FNAOKCGIBBC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EPJBAOOKMKJ(IPEndPoint DBHJCCKKAMO, GPEJAICFPCL AJLILPPHPPH, EANOMKAMGKI BILLKIDNEOJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CEFKIHICBAD(ALFNHBPHADP ADCGCFIHOIE, int IBDNOFKGDHE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NLALDEGENAK(DHJDFIOGNAF NEMAHPGAGLG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FBGNNPBCHIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJLLDHPEGKO(ALFNHBPHADP ADCGCFIHOIE, object AGOFGEFAJDM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CEIFMKMMBJA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONDMKPPCOAA(HDJDEJEMGPG OLNCIJOKKAP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EPMALBMKPAI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPHFEMGIIGH(ALFNHBPHADP ADCGCFIHOIE, IPEndPoint OHIMLJAEHGI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HIAKKMOCMAP
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int KCJGJDGDNNI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long PDACOAKDGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte MMOIEAKKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] OBHGFALKCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly MHJPNDEAFIA FENODPMPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int LPFBABABNCH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x67AB2E0", Offset = "0x67AA6E0", VA = "0x1867AB2E0")]
	private HIAKKMOCMAP(long GPNKJLICHOJ, byte BPHGDKLHAIA, int KPOCLGHHOEP, byte[] MCHFCBHAIFN, MHJPNDEAFIA GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67AAE80", Offset = "0x67AA280", VA = "0x1867AAE80")]
	public static int BAFBDLENCLM(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x67AB0C0", Offset = "0x67AA4C0", VA = "0x1867AB0C0")]
	public static HIAKKMOCMAP LBFIHDPKNOC(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x67AAEE0", Offset = "0x67AA2E0", VA = "0x1867AAEE0")]
	public static OLBGAHBBLGP IJOLHJMNFLM(PMDFLKCMKMG GJNHFAFGCBG, SocketAddress NBPCCFFIGDM, long BAKJEGOEMPJ, int KPOCLGHHOEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class HFPPKEAEEGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long PDACOAKDGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte MMOIEAKKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int LPFBABABNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool HDBCCHFAMOF;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x67AAE30", Offset = "0x67AA230", VA = "0x1867AAE30")]
	private HFPPKEAEEGF(long GPNKJLICHOJ, byte BPHGDKLHAIA, int BPIHOBOHBLI, bool HGKBNOABMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67AACE0", Offset = "0x67AA0E0", VA = "0x1867AACE0")]
	public static HFPPKEAEEGF LBFIHDPKNOC(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67AABF0", Offset = "0x67A9FF0", VA = "0x1867AABF0")]
	public static OLBGAHBBLGP IJOLHJMNFLM(long BAKJEGOEMPJ, byte FHFKHBLCIMJ, int OJNAOPODIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67AAAF0", Offset = "0x67A9EF0", VA = "0x1867AAAF0")]
	public static OLBGAHBBLGP BGJKCDLHHPJ(ALFNHBPHADP ADCGCFIHOIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum FDPGNJBPILG
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ADFFGDLIKLF
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEHGIPNMDOO(IPEndPoint EBAAIKPBBKC, IPEndPoint DBHJCCKKAMO, string LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNDIPPHMHHP(IPEndPoint FFAFGLBPHEB, FDPGNJBPILG BMIPLDLMPCD, string LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class HJHKBMKLIIM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OGCIMHDLDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint FCLFPDPMLBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint PCJCGEEKJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string FGEHPLBEBHN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BJBAGDOCCAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint PJBLKEAJLIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FDPGNJBPILG LNMDBHDAJAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string FGEHPLBEBHN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class HPDNJFNMION
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint NFHKFOKNIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string FGEHPLBEBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HPDNJFNMION()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class ACHEHIMPMMF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint NFHKFOKNIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint PGBEJIFGEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FGEHPLBEBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public ACHEHIMPMMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HOOMNDPNBDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FGEHPLBEBHN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HIELMLODNMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xBACAA0", Offset = "0xBABEA0", VA = "0x180BACAA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x949420", Offset = "0x948820", VA = "0x180949420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HOOMNDPNBDN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JAFMHCGIOND GKAGPECHDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OGCIMHDLDAC> CILBHJCKPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<BJBAGDOCCAB> AKGIBMFKIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly MHJPNDEAFIA NMBGDNOPEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly PMDFLKCMKMG HBLMNFJNOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AFNNJDJEDOG NCKAEMCJMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private ADFFGDLIKLF GOCMJMDJDIC;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int NPHGFDINPAG = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool LHJGKBMOEBB;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67AB960", Offset = "0x67AAD60", VA = "0x1867AB960")]
	internal HJHKBMKLIIM(JAFMHCGIOND NKFKONOGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67AB4E0", Offset = "0x67AA8E0", VA = "0x1867AB4E0")]
	internal void BDEKIABEKMD(IPEndPoint CJFCGBALKBN, OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33A8AE0", Offset = "0x33A7EE0", VA = "0x1833A8AE0")]
	private void EALCPPEDECJ<T>(T OLNCIJOKKAP, IPEndPoint MOCLCNOAHKF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67AB350", Offset = "0x67AA750", VA = "0x1867AB350")]
	private void AEHGIPNMDOO(HPDNJFNMION OJJKFAHDBGO, IPEndPoint CJFCGBALKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67AB660", Offset = "0x67AAA60", VA = "0x1867AB660")]
	private void MDPHOKFPLNO(ACHEHIMPMMF OJJKFAHDBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67AB7C0", Offset = "0x67AABC0", VA = "0x1867AB7C0")]
	private void OOJEOOMOLLD(HOOMNDPNBDN OJJKFAHDBGO, IPEndPoint CJFCGBALKBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EKBGKAGOIAF : byte
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
public enum DCFPKLHFJFD : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KKBLAJKNHDM
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] ILFIMGDAKCE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int KPLLBCPKADN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int CEBGPHBKNFF;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MGOAABKDNFA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F00", Offset = "0x67A6300", VA = "0x1867A6F00")]
	public MGOAABKDNFA(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CAMLDMEAALP : MGOAABKDNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F00", Offset = "0x67A6300", VA = "0x1867A6F00")]
	public CAMLDMEAALP(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum GOLIIDOHFKB
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
public interface HFHJKKGKJBA
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOGKEPCOGOJ(GOLIIDOHFKB IEDDIGKIIBL, string GIFBANFPJGI, params object[] JIEBKPCGKFF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NONEKMFDDDC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static HFHJKKGKJBA FHEOOEJKOOH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object ILGOMHLJPGJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67B6E30", Offset = "0x67B6230", VA = "0x1867B6E30")]
	private static void IJNNDMKIOAH(GOLIIDOHFKB MLEBODNMHCE, string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x67B7060", Offset = "0x67B6460", VA = "0x1867B7060")]
	internal static void KNJFCLDDLAP(string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x67B6D70", Offset = "0x67B6170", VA = "0x1867B6D70")]
	internal static void EEGMEMAPFDJ(string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67B6DD0", Offset = "0x67B61D0", VA = "0x1867B6DD0")]
	internal static void HLPDEDNFEMM(string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum JDMMLJBPJNP
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GPEJAICFPCL : MHJPNDEAFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private OLBGAHBBLGP NIMNBGBGOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JAFMHCGIOND LCAKLJCOAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly POIMBFCFADD NHEBPFLGENL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67A9700", Offset = "0x67A8B00", VA = "0x1867A9700")]
	internal GPEJAICFPCL(JAFMHCGIOND JEIEGFHFIPA, POIMBFCFADD HAIGDFHBOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x67A9690", Offset = "0x67A8A90", VA = "0x1867A9690")]
	internal void KIAKHNNHPMA(OLBGAHBBLGP OLNCIJOKKAP, int EKLNMDADKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x67A9610", Offset = "0x67A8A10", VA = "0x1867A9610")]
	internal void FKNLLDNHIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x67A95E0", Offset = "0x67A89E0", VA = "0x1867A95E0")]
	public void FJMOCJDFIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class POIMBFCFADD
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum NBHAOHMNMFP
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
	public POIMBFCFADD ELELLAAAAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NBHAOHMNMFP LNMDBHDAJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ALFNHBPHADP LIFICHIFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint PCJCGEEKJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object KFGHNHENDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int HBJNOEPLPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError BMMPDABBJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public GNJIAPDJKGG DEBEMKCMCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public DHJDFIOGNAF BMPDPFOEKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public EKBGKAGOIAF NJPEJJANLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte ALDAHCOPAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly GPEJAICFPCL HLNPINEHAEM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x67B8C90", Offset = "0x67B8090", VA = "0x1867B8C90")]
	public POIMBFCFADD(JAFMHCGIOND JEIEGFHFIPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class JAFMHCGIOND : IEnumerable<ALFNHBPHADP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class OGHEKALINJF : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x67B7170", Offset = "0x67B6570", VA = "0x1867B7170", Slot = "4")]
		public bool Equals(IPEndPoint IKAEODCKAIP, IPEndPoint ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62D9AB0", Offset = "0x62D8EB0", VA = "0x1862D9AB0", Slot = "5")]
		public int GetHashCode(IPEndPoint GMFKPONAANG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OGHEKALINJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct NEOOACDPPDD : IEnumerator<ALFNHBPHADP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly ALFNHBPHADP IMPFJJIELMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private ALFNHBPHADP FENIFFJJJJM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ALFNHBPHADP FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC33B50", Offset = "0xC32F50", VA = "0x180C33B50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC33B50", Offset = "0xC32F50", VA = "0x180C33B50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x177F360", Offset = "0x177E760", VA = "0x18177F360")]
		public NEOOACDPPDD(ALFNHBPHADP FCEAHINHNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x67B6CD0", Offset = "0x67B60D0", VA = "0x1867B6CD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x67B6D20", Offset = "0x67B6120", VA = "0x1867B6D20", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread CGPDCHNCKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool CJJPKFFDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent HJKKGJNNJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<POIMBFCFADD> PNOIPPFPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<POIMBFCFADD> JEOILACHFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private POIMBFCFADD MCGCJGPPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LEHGIGPJAEJ KPPIGCBBCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly FBGNNPBCHIJ AKGDEGPDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CEIFMKMMBJA INDDKKJOGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EPMALBMKPAI PNMDCBBGBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, ALFNHBPHADP> MNBDHOEJBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, DHJDFIOGNAF> CAPFKHLCDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, FJEEOEPJMOH> OJOBPHOILAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim FGBIHCAKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ALFNHBPHADP HLMGNFKFJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int ENIKEMABLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ALFNHBPHADP> HCKPHIIBAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private ALFNHBPHADP[] IJLCEOCGEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CNDFGJNMNMC FOIJMCAFDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int AOLEFHFBNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NJDJKKLJLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte MEOMDHMFMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object LHKIGMOEFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool DDPLFIHGPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool AAIOEFNOAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int OJLPMLJEAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int GIJBHLPAPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int FICCJNJMHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int JFOHKGIKMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool CHLCDIPGCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool OFLIFEPFHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IBIDIKCMAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FIMHMJAPLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int AOBADKKOGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool LHJGKBMOEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool PLGHGMAFBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KIONELLKHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool EPMMBBKOFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int ALAEIACPDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int CMHHCAJIHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool CFGELLBNMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly BFENEBKPNDO KDEFMNKNJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool HFDGEOEGHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly HJHKBMKLIIM HOFDPKGLHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool ICJKAFIAMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public JDMMLJBPJNP JKGMOGNOFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int LKNDGOMCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool CAJNBMMOBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool BELMJHIFCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool IBNLMHEECFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool IGECNEOCJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private OLBGAHBBLGP HIHMLECLKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int DNADIHEAAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object HHJBOOAKNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private OLBGAHBBLGP AJHJCBKPGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MONCFAJGEJK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int HAECAPNOEHO = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int JOODEBHIACL = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private AEIKHEFLJGJ EHCDPEMFABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private AEIKHEFLJGJ ABDIEMJJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread NNDHLIEDEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread IEGFMFPOOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint AEFHMGEGLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint LAOPCFBOEMN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] JGCDNOOGNPP;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] BPADANPCPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<OLFNOILEFHK, IPEndPoint> AMLECLGIGHE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress OOLFGCFFDHI;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool HCEFHOMADFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int LDFGDNOMKPP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HIAFELGMKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12D7940", Offset = "0x12D6D40", VA = "0x1812D7940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x12D7240", Offset = "0x12D6640", VA = "0x1812D7240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PDNNLKIJDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x208FC30", Offset = "0x208F030", VA = "0x18208FC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x208FC90", Offset = "0x208F090", VA = "0x18208FC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PIGGDJEJOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAFF540", Offset = "0xAFE940", VA = "0x180AFF540")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IKNCPJANMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x67B2C60", Offset = "0x67B2060", VA = "0x1867B2C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short EOFMGABNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x67AD370", Offset = "0x67AC770", VA = "0x1867AD370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67B1D40", Offset = "0x67B1140", VA = "0x1867B1D40")]
	public void HPDLKGNNMMD(IPEndPoint JEMILHCFMOK, byte[] LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67B1F60", Offset = "0x67B1360", VA = "0x1867B1F60")]
	public void IMOELILFPKG(IPEndPoint JEMILHCFMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67B0AF0", Offset = "0x67AFEF0", VA = "0x1867B0AF0")]
	private bool FNMJFKDJJIC(IPEndPoint JEMILHCFMOK, [Out] ALFNHBPHADP ADCGCFIHOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67B3610", Offset = "0x67B2A10", VA = "0x1867B3610")]
	private void PFGDHPGHFMI(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67AD980", Offset = "0x67ACD80", VA = "0x1867AD980")]
	private void CKBEMGGAFKD(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67B2EF0", Offset = "0x67B22F0", VA = "0x1867B2EF0")]
	private void NPOEHJOGGNI(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x67B3AD0", Offset = "0x67B2ED0", VA = "0x1867B3AD0")]
	public JAFMHCGIOND(LEHGIGPJAEJ OILBCIOLFPK, [Optional] CNDFGJNMNMC EGLFHLDIJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x67AD9D0", Offset = "0x67ACDD0", VA = "0x1867AD9D0")]
	internal void DHNBPBENNCM(ALFNHBPHADP PFNOPIDACBB, int IBDNOFKGDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67B2C80", Offset = "0x67B2080", VA = "0x1867B2C80")]
	internal void LGIOPJIBGPB(ALFNHBPHADP PFNOPIDACBB, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x67B01A0", Offset = "0x67AF5A0", VA = "0x1867B01A0")]
	internal void EKOMGAIHNGM(ALFNHBPHADP ADCGCFIHOIE, GNJIAPDJKGG CEGFAIJENKH, SocketError GFLDPECFGMP, OLBGAHBBLGP NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67B20F0", Offset = "0x67B14F0", VA = "0x1867B20F0")]
	private void IOIDHJLDODF(ALFNHBPHADP ADCGCFIHOIE, GNJIAPDJKGG CEGFAIJENKH, SocketError GFLDPECFGMP, bool MHOOEDPKADD, byte[] GIDGOODJFLJ, int HHIGALLBHNK, int BBEJNKBNMID, OLBGAHBBLGP NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67AC650", Offset = "0x67ABA50", VA = "0x1867AC650")]
	private void AFKIMNAEPGO(POIMBFCFADD.NBHAOHMNMFP BMIPLDLMPCD, [Optional] ALFNHBPHADP ADCGCFIHOIE, [Optional] IPEndPoint DBHJCCKKAMO, SocketError HKJCJLGBMOM = SocketError.Success, int IBDNOFKGDHE = 0, GNJIAPDJKGG EEPKMOCFGEH = GNJIAPDJKGG.ConnectionFailed, [Optional] DHJDFIOGNAF KHNHPKIIHPL, EKBGKAGOIAF FNAOKCGIBBC = EKBGKAGOIAF.Unreliable, byte AFKKHALCJGJ = 0, [Optional] OLBGAHBBLGP HCHABEIHMOP, [Optional] object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x67AF160", Offset = "0x67AE560", VA = "0x1867AF160")]
	private void EHIEJBKJENP(POIMBFCFADD HAIGDFHBOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x67B2CD0", Offset = "0x67B20D0", VA = "0x1867B2CD0")]
	internal void MMPPNOMPJOA(POIMBFCFADD HAIGDFHBOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67B0D30", Offset = "0x67B0130", VA = "0x1867B0D30")]
	private void GFJAGICJJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x67B0580", Offset = "0x67AF980", VA = "0x1867B0580")]
	private void FKGOHBODHBJ(int JOOHFMJEDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x67B14B0", Offset = "0x67B08B0", VA = "0x1867B14B0")]
	internal ALFNHBPHADP HGCJNMMOLHI(DHJDFIOGNAF NEMAHPGAGLG, byte[] IALAKEEHJMN, int HHIGALLBHNK, int GIGAFKHMOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67B2AE0", Offset = "0x67B1EE0", VA = "0x1867B2AE0")]
	private int JMGPCDNKNLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67B3160", Offset = "0x67B2560", VA = "0x1867B3160")]
	private void OIHLEPHCJOB(IPEndPoint DBHJCCKKAMO, ALFNHBPHADP APMOBKJGMBD, HIAKKMOCMAP CBFLFMOAAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67ADD80", Offset = "0x67AD180", VA = "0x1867ADD80")]
	private void EEMNPKPNIEL(OLBGAHBBLGP OLNCIJOKKAP, IPEndPoint DBHJCCKKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67AD090", Offset = "0x67AC490", VA = "0x1867AD090")]
	internal void BHFHGFKBOLK(OLBGAHBBLGP OLNCIJOKKAP, EKBGKAGOIAF PMAAKBDMJEK, byte AFKKHALCJGJ, int EKLNMDADKPG, ALFNHBPHADP PFNOPIDACBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x67B0110", Offset = "0x67AF510", VA = "0x1867B0110")]
	public bool EKFPEOGCKKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67B00F0", Offset = "0x67AF4F0", VA = "0x1867B00F0")]
	public bool EKFPEOGCKKC(IPAddress BJIJEDBELIG, IPAddress CMLJFLMBBGB, int GMEMHACONIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x67B0120", Offset = "0x67AF520", VA = "0x1867B0120")]
	public bool EKFPEOGCKKC(int GMEMHACONIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x67B0B80", Offset = "0x67AFF80", VA = "0x1867B0B80")]
	public void GFCMLHJMGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x67B2920", Offset = "0x67B1D20", VA = "0x1867B2920")]
	public ALFNHBPHADP JKBEOHINGHJ(string JMCLCDMOBMM, int GMEMHACONIH, string LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67B2A00", Offset = "0x67B1E00", VA = "0x1867B2A00")]
	public ALFNHBPHADP JKBEOHINGHJ(string JMCLCDMOBMM, int GMEMHACONIH, PMDFLKCMKMG FHAEHIHLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67B2550", Offset = "0x67B1950", VA = "0x1867B2550")]
	public ALFNHBPHADP JKBEOHINGHJ(IPEndPoint MOCLCNOAHKF, PMDFLKCMKMG FHAEHIHLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67ADA20", Offset = "0x67ACE20", VA = "0x1867ADA20")]
	public void EDANFFCKCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67ADA30", Offset = "0x67ACE30", VA = "0x1867ADA30")]
	public void EDANFFCKCPP(bool JOEDEDNDCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x67B1340", Offset = "0x67B0740", VA = "0x1867B1340")]
	public void HDLEIOBNCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67B13F0", Offset = "0x67B07F0", VA = "0x1867B13F0")]
	public void HDLEIOBNCAL(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67B20B0", Offset = "0x67B14B0", VA = "0x1867B20B0")]
	public void IOIDHJLDODF(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x67B2510", Offset = "0x67B1910", VA = "0x1867B2510")]
	public void IOIDHJLDODF(ALFNHBPHADP ADCGCFIHOIE, byte[] GIDGOODJFLJ, int HHIGALLBHNK, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67B38F0", Offset = "0x67B2CF0", VA = "0x1867B38F0", Slot = "4")]
	private IEnumerator<ALFNHBPHADP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x67B3980", Offset = "0x67B2D80", VA = "0x1867B3980", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x67B0490", Offset = "0x67AF890", VA = "0x1867B0490")]
	private OLBGAHBBLGP FFBGBMMBNAH(CCLEIPPHPEK KKCCAKAEMAH, int IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x67B03B0", Offset = "0x67AF7B0", VA = "0x1867B03B0")]
	private OLBGAHBBLGP FFBGBMMBNAH(CCLEIPPHPEK KKCCAKAEMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x67B08A0", Offset = "0x67AFCA0", VA = "0x1867B08A0")]
	internal OLBGAHBBLGP FNDPGIFFHJN(int IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x67B1AD0", Offset = "0x67B0ED0", VA = "0x1867B1AD0")]
	internal void HKBHMCJFFIA(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3A10", Offset = "0x67B2E10", VA = "0x1867B3A10")]
	static JAFMHCGIOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12D7940", Offset = "0x12D6D40", VA = "0x1812D7940")]
	private bool PKFLGBGJCDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67B2DE0", Offset = "0x67B21E0", VA = "0x1867B2DE0")]
	private void MPCBBFFJGFC(IPEndPoint AOAEJCPNLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67B2B60", Offset = "0x67B1F60", VA = "0x1867B2B60")]
	private void JOCAAHHKKOF(IPEndPoint AOAEJCPNLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67AD7D0", Offset = "0x67ACBD0", VA = "0x1867AD7D0")]
	private bool CGALGKNFPMH(SocketException DADIPHEHDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x67B1070", Offset = "0x67B0470", VA = "0x1867B1070")]
	private void GGFAFEMEOBL(AEIKHEFLJGJ NKFKONOGCEJ, EndPoint AHHOCDEFAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x67AD430", Offset = "0x67AC830", VA = "0x1867AD430")]
	private void BJDKOMHEFNA(object CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x67AF930", Offset = "0x67AED30", VA = "0x1867AF930")]
	public bool EKFPEOGCKKC(IPAddress BJIJEDBELIG, IPAddress CMLJFLMBBGB, int GMEMHACONIH, bool GABKFPKILHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x67B0350", Offset = "0x67AF750", VA = "0x1867B0350")]
	internal int FEMCNPFKJMO(OLBGAHBBLGP OLNCIJOKKAP, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67AD050", Offset = "0x67AC450", VA = "0x1867AD050")]
	internal int AHHOLHBCENG(OLBGAHBBLGP OLNCIJOKKAP, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x67ACA30", Offset = "0x67ABE30", VA = "0x1867ACA30")]
	internal int AHHOLHBCENG(byte[] MIALAMIFNLM, int HHIGALLBHNK, int GIGAFKHMOHH, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67B01E0", Offset = "0x67AF5E0", VA = "0x1867B01E0")]
	internal void EMGDENFKPEB(bool AANIJAGIAJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum CCLEIPPHPEK : byte
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
internal sealed class OLBGAHBBLGP
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int IJMKAOBMJJO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] ELDIJOAAHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] JHBCEMBDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int NGPEAGCEMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object KFGHNHENDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public OLBGAHBBLGP ELELLAAAAFC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CCLEIPPHPEK OHKHHCPAKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x67B7630", Offset = "0x67B6A30", VA = "0x1867B7630")]
		get
		{
			return default(CCLEIPPHPEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x67B75F0", Offset = "0x67B69F0", VA = "0x1867B75F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte MMOIEAKKPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x67B7220", Offset = "0x67B6620", VA = "0x1867B7220")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x67B7550", Offset = "0x67B6950", VA = "0x1867B7550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort FDLBDIBCDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x67B7740", Offset = "0x67B6B40", VA = "0x1867B7740")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x67B7700", Offset = "0x67B6B00", VA = "0x1867B7700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MLIBNHCBMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x67B7480", Offset = "0x67B6880", VA = "0x1867B7480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LJHBLBNAHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x67B74E0", Offset = "0x67B68E0", VA = "0x1867B74E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67B7350", Offset = "0x67B6750", VA = "0x1867B7350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LLEAADLHANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x67B7590", Offset = "0x67B6990", VA = "0x1867B7590")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x67B71E0", Offset = "0x67B65E0", VA = "0x1867B71E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort DAMMMAOGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x67B7660", Offset = "0x67B6A60", VA = "0x1867B7660")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x67B76C0", Offset = "0x67B6AC0", VA = "0x1867B76C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JJDMJHNFCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x67B77A0", Offset = "0x67B6BA0", VA = "0x1867B77A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x67B7510", Offset = "0x67B6910", VA = "0x1867B7510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67B7800", Offset = "0x67B6C00", VA = "0x1867B7800")]
	static OLBGAHBBLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x67B74B0", Offset = "0x67B68B0", VA = "0x1867B74B0")]
	public void GOHEDDEJNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x67B7AE0", Offset = "0x67B6EE0", VA = "0x1867B7AE0")]
	public OLBGAHBBLGP(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x67B7B50", Offset = "0x67B6F50", VA = "0x1867B7B50")]
	public OLBGAHBBLGP(CCLEIPPHPEK KKCCAKAEMAH, int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x67B7380", Offset = "0x67B6780", VA = "0x1867B7380")]
	public static int GANLLHDJDAC(CCLEIPPHPEK KKCCAKAEMAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x67B73F0", Offset = "0x67B67F0", VA = "0x1867B73F0")]
	public int GANLLHDJDAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x67B7250", Offset = "0x67B6650", VA = "0x1867B7250")]
	public bool DKKAHALPLON()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum GFIHPKPDAKG : byte
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
internal enum EKFBGFBGBLN
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
internal enum KJAIELBFAMH
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum PMFOCJCFPOB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ALFNHBPHADP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BKMKHEAHHCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public OLBGAHBBLGP[] JNECJMFBKIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int ICJBKIILNHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int LFAEJNCNPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte LJHBLBNAHBP;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BKMKHEAHHCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void FINJOLJFABI(ulong DACEELOAMGJ, int GCFKKKHOICJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int IBNOKLKOLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HEPALCEIEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int CFKLBKKHFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double EHHLKNDIBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int AIFAFKIMCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int ECLEJDCEOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int LMJNAFPENPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch IINKAMNFNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int OPJMHPMHJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long FMHIDHDBGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object OFDLEOKFAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal ALFNHBPHADP HDANNHBGNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal ALFNHBPHADP HIGJDPNGLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<OLBGAHBBLGP> OBPNFPJCLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CLKEPLEHOIB> MLHLAOAFCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CLKEPLEHOIB[] FHGJEODJAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int PGKMGKHFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int CBOBLIGLNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool OCCKCNAIDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int AIKHCODJLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int NNDCDNEEFCO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int EPHKMNDLIGJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int JMGAEBLKGPJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object FPBOHMKKMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int JFKKDCNBDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, BKMKHEAHHCN> KANDGEELGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> PMCHJGDBBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly OLBGAHBBLGP PGGGJELLCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int DPGMNHLMDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int JOGMCPHFMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint IJLNHOLNJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CDNAJFBDGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int LGAKKCOLCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long FCNHOOHCJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte BFNFJNOKCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private GFIHPKPDAKG FIGLMAOANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private OLBGAHBBLGP PKHMHEDBAGE;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int BHHDKKBHGGI = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int BJMGCDMKPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly OLBGAHBBLGP EFLBKFJHLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly OLBGAHBBLGP BKBOLOGPHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly OLBGAHBBLGP CPNCNEGHFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly OLBGAHBBLGP HPLGLPMFNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private DCFPKLHFJFD EKFGGFNHECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly JAFMHCGIOND HMMJHKAGOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int AOALABMLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object MFAMILMKIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly BFENEBKPNDO KDEFMNKNJPP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte CBAMCNOOFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA81AA0", Offset = "0xA80EA0", VA = "0x180A81AA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x67A36A0", Offset = "0x67A2AA0", VA = "0x1867A36A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint NKPKGMKPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB6EF10", Offset = "0xB6E310", VA = "0x180B6EF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GFIHPKPDAKG ENFAMNJFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA356E0", Offset = "0xA34AE0", VA = "0x180A356E0")]
		get
		{
			return default(GFIHPKPDAKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KAJDENBLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x94E8C0", Offset = "0x94DCC0", VA = "0x18094E8C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GKKMHKCFDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1319CC0", Offset = "0x13190C0", VA = "0x181319CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C06AE0", Offset = "0x1C05EE0", VA = "0x181C06AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NFCIBEGFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67A3A80", Offset = "0x67A2E80", VA = "0x1867A3A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MLPLNPKLPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x95A2B0", Offset = "0x9596B0", VA = "0x18095A2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LNHKEPIMGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x628DB30", Offset = "0x628CF30", VA = "0x18628DB30")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FINJOLJFABI CBMIMPLCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x67A3030", Offset = "0x67A2430", VA = "0x1867A3030")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x67A1C50", Offset = "0x67A1050", VA = "0x1867A1C50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x67A58C0", Offset = "0x67A4CC0", VA = "0x1867A58C0")]
	internal ALFNHBPHADP(JAFMHCGIOND DAFOMOMNIOC, IPEndPoint DBHJCCKKAMO, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x67A3A60", Offset = "0x67A2E60", VA = "0x1867A3A60")]
	internal void JLPNKAJELCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x67A3FF0", Offset = "0x67A33F0", VA = "0x1867A3FF0")]
	internal void MJOFBMJILHA(IPEndPoint HHBNALMDGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67A3CA0", Offset = "0x67A30A0", VA = "0x1867A3CA0")]
	internal void LPDBOABCFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x67A1D00", Offset = "0x67A1100", VA = "0x1867A1D00")]
	private void DGDNLPKPMCI(int NIKFCHCIOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67A44B0", Offset = "0x67A38B0", VA = "0x1867A44B0")]
	private void OJNCHHPLLBO(int ACPAEBKIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67A4140", Offset = "0x67A3540", VA = "0x1867A4140")]
	private CLKEPLEHOIB OAHHGLNAAFO(byte MKNOLMMOIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67A5730", Offset = "0x67A4B30", VA = "0x1867A5730")]
	internal ALFNHBPHADP(JAFMHCGIOND DAFOMOMNIOC, IPEndPoint DBHJCCKKAMO, int KGHCKLKGJKM, byte FHFKHBLCIMJ, PMDFLKCMKMG GJNHFAFGCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x67A5550", Offset = "0x67A4950", VA = "0x1867A5550")]
	internal ALFNHBPHADP(JAFMHCGIOND DAFOMOMNIOC, DHJDFIOGNAF NEMAHPGAGLG, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x67A40F0", Offset = "0x67A34F0", VA = "0x1867A40F0")]
	internal void NPIJPKLCCLP(HIAKKMOCMAP IKIFJNBFIDN, byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x67A4070", Offset = "0x67A3470", VA = "0x1867A4070")]
	internal bool NICKIKEIDIH(HFPPKEAEEGF OLNCIJOKKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x67A1F20", Offset = "0x67A1320", VA = "0x1867A1F20")]
	public void EALCPPEDECJ(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH, EKBGKAGOIAF DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x67A3140", Offset = "0x67A2540", VA = "0x1867A3140")]
	private void JDHIGHCKMHA(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH, byte AFKKHALCJGJ, EKBGKAGOIAF FNAOKCGIBBC, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x67A4020", Offset = "0x67A3420", VA = "0x1867A4020")]
	public void NDBONFMDEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x67A1F50", Offset = "0x67A1350", VA = "0x1867A1F50")]
	internal KJAIELBFAMH EEEPBGGGAIA(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return default(KJAIELBFAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x67A30E0", Offset = "0x67A24E0", VA = "0x1867A30E0")]
	internal void JCCLGECNNHK(CLKEPLEHOIB GJMMFDLBGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x67A3750", Offset = "0x67A2B50", VA = "0x1867A3750")]
	internal PMFOCJCFPOB JLIOHLLGMND(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH, bool MHOOEDPKADD)
	{
		return default(PMFOCJCFPOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x67A2030", Offset = "0x67A1430", VA = "0x1867A2030")]
	private void EIFMPLBKAIB(int PJBGPEDOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x67A44F0", Offset = "0x67A38F0", VA = "0x1867A44F0")]
	internal void PGLKGBLNMOF(EKBGKAGOIAF PMAAKBDMJEK, OLBGAHBBLGP FCEAHINHNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x67A2AC0", Offset = "0x67A1EC0", VA = "0x1867A2AC0")]
	private void GNGAMHNBGGD(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x67A2070", Offset = "0x67A1470", VA = "0x1867A2070")]
	private void EPECKCGBOFF(int HIBCBLOKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x67A42F0", Offset = "0x67A36F0", VA = "0x1867A42F0")]
	internal EKFBGFBGBLN OIHLEPHCJOB(HIAKKMOCMAP CBFLFMOAAPO)
	{
		return default(EKFBGFBGBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x67A2400", Offset = "0x67A1800", VA = "0x1867A2400")]
	internal void GBGPPLAMAJP(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x67A1DD0", Offset = "0x67A11D0", VA = "0x1867A1DD0")]
	private void DOEOJHEGCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x67A3A90", Offset = "0x67A2E90", VA = "0x1867A3A90")]
	internal void KJEPFFEGPEF(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x67A4E90", Offset = "0x67A4290", VA = "0x1867A4E90")]
	internal void PLJNMJIHBJD(int HIBCBLOKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x67A3D30", Offset = "0x67A3130", VA = "0x1867A3D30")]
	internal void MJAFKCOHIBA(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BFENEBKPNDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long AFFMCEMMKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NBCHFCLBCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long ELFMNDDJCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long CCMCKIGLCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long NEAKJBJDMAA;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long FCJJKHJOCJF;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long APECPAIAHBK;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long LEMDIANLPCO;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long EAFDLEHLNJM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long AIIJAPEJNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long OJCJLJOFCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long EHBKMPFJMID;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long NHPJMOMBPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x67A6990", Offset = "0x67A5D90", VA = "0x1867A6990")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DJPPPEOHNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x67A6970", Offset = "0x67A5D70", VA = "0x1867A6970")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long EEKAIGLGEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67A6980", Offset = "0x67A5D80", VA = "0x1867A6980")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MDJJCCNBINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67A68C0", Offset = "0x67A5CC0", VA = "0x1867A68C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long ANLBEAFMGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x67A6800", Offset = "0x67A5C00", VA = "0x1867A6800")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LOBCHFFJJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67A6A50", Offset = "0x67A5E50", VA = "0x1867A6A50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long GJEFNCOLHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x67A69A0", Offset = "0x67A5DA0", VA = "0x1867A69A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long ABAEPIJPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x67A6760", Offset = "0x67A5B60", VA = "0x1867A6760")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private DCFPKLHFJFD GDIIKEHHBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x67A68B0", Offset = "0x67A5CB0", VA = "0x1867A68B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double BAFFEFNBKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67A6700", Offset = "0x67A5B00", VA = "0x1867A6700")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x67A6930", Offset = "0x67A5D30", VA = "0x1867A6930")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x67A68D0", Offset = "0x67A5CD0", VA = "0x1867A68D0")]
	public void ILGNFCJCMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x67A6AD0", Offset = "0x67A5ED0", VA = "0x1867A6AD0")]
	public void OHMNGEBILPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x67A6A60", Offset = "0x67A5E60", VA = "0x1867A6A60")]
	public void NPIMIFMJJEJ(long PIHAKLMBEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x67A69E0", Offset = "0x67A5DE0", VA = "0x1867A69E0")]
	public void MBGOKOMEFNI(long EEGLPGIPCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x67A67A0", Offset = "0x67A5BA0", VA = "0x1867A67A0")]
	public void COIBCFNAMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x67A6B20", Offset = "0x67A5F20", VA = "0x1867A6B20")]
	public void PCNHEPAIIMO(long BBIFKJCCGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x67A6BA0", Offset = "0x67A5FA0", VA = "0x1867A6BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x67A6810", Offset = "0x67A5C10", VA = "0x1867A6810")]
	public void ELCEPEANCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public BFENEBKPNDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DFEHNFJFLJF
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> BKDKJDKGDCO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x67A7D80", Offset = "0x67A7180", VA = "0x1867A7D80")]
	public static IPEndPoint GMHKLOLLAGC(string HKMGPAMGNCG, int GMEMHACONIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x67A8060", Offset = "0x67A7460", VA = "0x1867A8060")]
	public static IPAddress ICDMOCAMFJA(string HKMGPAMGNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x67A7FD0", Offset = "0x67A73D0", VA = "0x1867A7FD0")]
	public static IPAddress ICDMOCAMFJA(string HKMGPAMGNCG, AddressFamily IIBJDKNOAKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x67A7D50", Offset = "0x67A7150", VA = "0x1867A7D50")]
	internal static int EBKNLOFLBLF(int MKFGMIFHKNM, int HILNFBANAMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3203690", Offset = "0x3202A90", VA = "0x183203690")]
	internal static T[] PCNKAGAMAGO<T>(int BBEJNKBNMID) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GAKOFHOJNNF : CLKEPLEHOIB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BFEBHENIKIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private OLBGAHBBLGP NIMNBGBGOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long GECIOHOMIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool PMHEDPFMKOH;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x67A6660", Offset = "0x67A5A60", VA = "0x1867A6660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x67A6580", Offset = "0x67A5980", VA = "0x1867A6580")]
		public void CIDIOEOELJF(OLBGAHBBLGP OLNCIJOKKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x67A65F0", Offset = "0x67A59F0", VA = "0x1867A65F0")]
		public bool MELKNKBPHFH(long LOJMONJPLCB, ALFNHBPHADP ADCGCFIHOIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67A65A0", Offset = "0x67A59A0", VA = "0x1867A65A0")]
		public bool KKIOKOIHHPE(ALFNHBPHADP ADCGCFIHOIE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly OLBGAHBBLGP IMBELEPGOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly BFEBHENIKIA[] BOEPBNEJLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly OLBGAHBBLGP[] IKJLMMCBPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] NDCAMIHDEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int IGAJHKOEIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int MEKGCBGIEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int FDCFDCMNMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int JICMHJGDIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool AIENCCCPPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly EKBGKAGOIAF GCGNODCOJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool PJJKHMPHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int BEMFLAJDLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte IFDOEKFFLNO;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x67A9410", Offset = "0x67A8810", VA = "0x1867A9410")]
	public GAKOFHOJNNF(ALFNHBPHADP ADCGCFIHOIE, bool FNLFAGPENHB, byte KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x67A8520", Offset = "0x67A7920", VA = "0x1867A8520")]
	private void DJIOPEEPCLG(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x67A8F40", Offset = "0x67A8340", VA = "0x1867A8F40", Slot = "4")]
	protected override bool ICAKHFFGKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x67A88E0", Offset = "0x67A7CE0", VA = "0x1867A88E0", Slot = "5")]
	public override bool GBGPPLAMAJP(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class AOBICJMHJEO : CLKEPLEHOIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int JNKCAKCGJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort MEKGCBGIEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool HBKPILEFIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private OLBGAHBBLGP AOLEMCPMMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly OLBGAHBBLGP COCHIJNPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool NGHCNJKMCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte IFDOEKFFLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long KJJDCBLPDBF;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x67A64C0", Offset = "0x67A58C0", VA = "0x1867A64C0")]
	public AOBICJMHJEO(ALFNHBPHADP ADCGCFIHOIE, bool CMLGOKFONGL, byte KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x67A6000", Offset = "0x67A5400", VA = "0x1867A6000", Slot = "4")]
	protected override bool ICAKHFFGKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x67A5D20", Offset = "0x67A5120", VA = "0x1867A5D20", Slot = "5")]
	public override bool GBGPPLAMAJP(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class COJNBNLKFCG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct NFENOCOFPOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong AEOFPIFDIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double LJAMFEGNNMM;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct IAPCIFKNMJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int FNLBPFIIKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float BHINMPHHBFK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x67A12F0", Offset = "0x67A06F0", VA = "0x1867A12F0")]
	private static void CFHHJPGEKEH(byte[] DEEIKCMDENK, int FDJGEFDKBBO, ulong GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x67A7BF0", Offset = "0x67A6FF0", VA = "0x1867A7BF0")]
	private static void CFHHJPGEKEH(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x67A7C60", Offset = "0x67A7060", VA = "0x1867A7C60")]
	public static void CFHHJPGEKEH(byte[] DEEIKCMDENK, int FDJGEFDKBBO, short GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x67A7CB0", Offset = "0x67A70B0", VA = "0x1867A7CB0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, double KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x67A7CD0", Offset = "0x67A70D0", VA = "0x1867A7CD0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x67A7C60", Offset = "0x67A7060", VA = "0x1867A7C60")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, short KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x67A7C60", Offset = "0x67A7060", VA = "0x1867A7C60")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, ushort KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x67A7BF0", Offset = "0x67A6FF0", VA = "0x1867A7BF0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67A7BF0", Offset = "0x67A6FF0", VA = "0x1867A7BF0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, uint KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x67A7CA0", Offset = "0x67A70A0", VA = "0x1867A7CA0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67A7CA0", Offset = "0x67A70A0", VA = "0x1867A7CA0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, ulong KBGCCIOIGBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class MHJPNDEAFIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] NGLBBEFFGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int IDAENOLBBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int EMJFMBCLBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int IHLEDCHHFNA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] JHBCEMBDJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OBPKCAFDNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NOLGFANEPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x67B6300", Offset = "0x67B5700", VA = "0x1867B6300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DADCAOGHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2458400", Offset = "0x2457800", VA = "0x182458400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OBABOJAIBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67B6A10", Offset = "0x67B5E10", VA = "0x1867B6A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67B6A60", Offset = "0x67B5E60", VA = "0x1867B6A60")]
	public void KIAKHNNHPMA(byte[] MBDLAJMBAIN, int FDJGEFDKBBO, int OJGAKAIOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public MHJPNDEAFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67B6C10", Offset = "0x67B6010", VA = "0x1867B6C10")]
	public MHJPNDEAFIA(byte[] MBDLAJMBAIN, int FDJGEFDKBBO, int OJGAKAIOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67B6390", Offset = "0x67B5790", VA = "0x1867B6390")]
	public IPEndPoint DHDDIOJFACG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67B64E0", Offset = "0x67B58E0", VA = "0x1867B64E0")]
	public byte FEIIDCGHHEE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67B64E0", Offset = "0x67B58E0", VA = "0x1867B64E0")]
	public sbyte JKAJBODGCFD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x34C3B00", Offset = "0x34C2F00", VA = "0x1834C3B00")]
	public T[] JNGIKLEFNCH<T>(ushort IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67B6A20", Offset = "0x67B5E20", VA = "0x1867B6A20")]
	public bool[] KBJHJOLGKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67B6000", Offset = "0x67B5400", VA = "0x1867B6000")]
	public ushort[] ABMPEDJHADK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x67B6080", Offset = "0x67B5480", VA = "0x1867B6080")]
	public short[] AKFOCMNOHFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x67B6310", Offset = "0x67B5710", VA = "0x1867B6310")]
	public int[] CPJDFCHDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67B6460", Offset = "0x67B5860", VA = "0x1867B6460")]
	public uint[] EOELNGJJCLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67B6280", Offset = "0x67B5680", VA = "0x1867B6280")]
	public float[] CDAJAFOOMPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x67B6350", Offset = "0x67B5750", VA = "0x1867B6350")]
	public double[] DCFIINGMJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x67B6990", Offset = "0x67B5D90", VA = "0x1867B6990")]
	public long[] HKPDGIGCCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x67B6040", Offset = "0x67B5440", VA = "0x1867B6040")]
	public ulong[] AFFHJAEPONE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x67B6520", Offset = "0x67B5920", VA = "0x1867B6520")]
	public string[] GIKBEPPEFKH(int FPELCKFDBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x67B62C0", Offset = "0x67B56C0", VA = "0x1867B62C0")]
	public bool CEMGKHJAGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x67B6670", Offset = "0x67B5A70", VA = "0x1867B6670")]
	public char GJGKAKCONBM()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67B6670", Offset = "0x67B5A70", VA = "0x1867B6670")]
	public ushort OPGBNFCPFJG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x67B6B30", Offset = "0x67B5F30", VA = "0x1867B6B30")]
	public short MFDLEIBLHNF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x67B6210", Offset = "0x67B5610", VA = "0x1867B6210")]
	public long CAOJMPHHFMP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x67B60C0", Offset = "0x67B54C0", VA = "0x1867B60C0")]
	public ulong AOCKCALANAH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67B6130", Offset = "0x67B5530", VA = "0x1867B6130")]
	public int BBNEDFGFMOB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x67B6BA0", Offset = "0x67B5FA0", VA = "0x1867B6BA0")]
	public uint OKMLMEICEIL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x67B61A0", Offset = "0x67B55A0", VA = "0x1867B61A0")]
	public float BOBHPPGGGMC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x67B6920", Offset = "0x67B5D20", VA = "0x1867B6920")]
	public double HBCJJEOJEJC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x67B66E0", Offset = "0x67B5AE0", VA = "0x1867B66E0")]
	public string HAPGJAEFBKP(int FCDJJGFAGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x67B6AC0", Offset = "0x67B5EC0", VA = "0x1867B6AC0")]
	public ArraySegment<byte> LOMAPENHLDB(int BBEJNKBNMID)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x67B69D0", Offset = "0x67B5DD0", VA = "0x1867B69D0")]
	public sbyte[] IKAJMMJKHLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x67B64A0", Offset = "0x67B58A0", VA = "0x1867B64A0")]
	public byte[] FANMNCCLJGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x67B6AA0", Offset = "0x67B5EA0", VA = "0x1867B6AA0")]
	public void KKIOKOIHHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PMDFLKCMKMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] NGLBBEFFGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int IDAENOLBBAG;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int PKHHGPJKPON = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool HOAEAHEPKHF;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding GEDIEKIIEIO;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int OLMAMPCEBLA = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] GAEPKCHOBCC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] FENODPMPHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x94D480", Offset = "0x94C880", VA = "0x18094D480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x67B8B70", Offset = "0x67B7F70", VA = "0x1867B8B70")]
	public PMDFLKCMKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67B8BF0", Offset = "0x67B7FF0", VA = "0x1867B8BF0")]
	public PMDFLKCMKMG(bool NEGNDEADJGK, int MNIENPOFPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67B8620", Offset = "0x67B7A20", VA = "0x1867B8620")]
	public static PMDFLKCMKMG DPOEGBKMEON(string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x67B8580", Offset = "0x67B7980", VA = "0x1867B8580")]
	public void BJJJNNJENLK(int FGICKOMPDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x24D19D0", Offset = "0x24D0DD0", VA = "0x1824D19D0")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x67B8300", Offset = "0x67B7700", VA = "0x1867B8300")]
	public void AGPGBFOKNPG(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x67B83F0", Offset = "0x67B77F0", VA = "0x1867B83F0")]
	public void AGPGBFOKNPG(double KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x67B83A0", Offset = "0x67B77A0", VA = "0x1867B83A0")]
	public void AGPGBFOKNPG(long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x67B83A0", Offset = "0x67B77A0", VA = "0x1867B83A0")]
	public void AGPGBFOKNPG(ulong KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x67B7EB0", Offset = "0x67B72B0", VA = "0x1867B7EB0")]
	public void AGPGBFOKNPG(int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x67B7EB0", Offset = "0x67B72B0", VA = "0x1867B7EB0")]
	public void AGPGBFOKNPG(uint KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x67B7E40", Offset = "0x67B7240", VA = "0x1867B7E40")]
	public void AGPGBFOKNPG(char KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x67B7E40", Offset = "0x67B7240", VA = "0x1867B7E40")]
	public void AGPGBFOKNPG(ushort KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x67B7E40", Offset = "0x67B7240", VA = "0x1867B7E40")]
	public void AGPGBFOKNPG(short KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x67B7FB0", Offset = "0x67B73B0", VA = "0x1867B7FB0")]
	public void AGPGBFOKNPG(sbyte KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x67B7FB0", Offset = "0x67B73B0", VA = "0x1867B7FB0")]
	public void AGPGBFOKNPG(byte KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x67B7F40", Offset = "0x67B7340", VA = "0x1867B7F40")]
	public void AGPGBFOKNPG(byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x67B84A0", Offset = "0x67B78A0", VA = "0x1867B84A0")]
	public void JCLPJDHCGGL(sbyte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67B84A0", Offset = "0x67B78A0", VA = "0x1867B84A0")]
	public void BGEOGBHMJPP(byte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67B8440", Offset = "0x67B7840", VA = "0x1867B8440")]
	public void AGPGBFOKNPG(bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67B8A00", Offset = "0x67B7E00", VA = "0x1867B8A00")]
	public void EFEOPCCCICF(Array IPJLMGNKKAH, int EOGCMBDMIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67B8850", Offset = "0x67B7C50", VA = "0x1867B8850")]
	public void EFEOPCCCICF(float[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x67B8770", Offset = "0x67B7B70", VA = "0x1867B8770")]
	public void EFEOPCCCICF(double[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x67B8770", Offset = "0x67B7B70", VA = "0x1867B8770")]
	public void EFEOPCCCICF(long[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67B8770", Offset = "0x67B7B70", VA = "0x1867B8770")]
	public void EFEOPCCCICF(ulong[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67B8850", Offset = "0x67B7C50", VA = "0x1867B8850")]
	public void EFEOPCCCICF(int[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67B8850", Offset = "0x67B7C50", VA = "0x1867B8850")]
	public void EFEOPCCCICF(uint[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x67B8690", Offset = "0x67B7A90", VA = "0x1867B8690")]
	public void EFEOPCCCICF(ushort[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x67B8690", Offset = "0x67B7A90", VA = "0x1867B8690")]
	public void EFEOPCCCICF(short[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x67B84A0", Offset = "0x67B78A0", VA = "0x1867B84A0")]
	public void EFEOPCCCICF(bool[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x67B8930", Offset = "0x67B7D30", VA = "0x1867B8930")]
	public void EFEOPCCCICF(string[] KBGCCIOIGBD, int JCEGDOALJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x67B8230", Offset = "0x67B7630", VA = "0x1867B8230")]
	public void AGPGBFOKNPG(IPEndPoint JEMILHCFMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67B8220", Offset = "0x67B7620", VA = "0x1867B8220")]
	public void AGPGBFOKNPG(string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x67B8010", Offset = "0x67B7410", VA = "0x1867B8010")]
	public void AGPGBFOKNPG(string KBGCCIOIGBD, int FCDJJGFAGNO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AFNNJDJEDOG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class COGAJGFKOFC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong AOALABMLPFM;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5C12060", Offset = "0x5C11460", VA = "0x185C12060")]
		static COGAJGFKOFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void KLGJFCBKKPD(MHJPNDEAFIA AJLILPPHPPH, object AGOFGEFAJDM);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KEJACFMOPMO<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AFNNJDJEDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public KEJACFMOPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4A4B1E0", Offset = "0x4A4A5E0", VA = "0x184A4B1E0")]
		internal void OGLNNIAJHOE(MHJPNDEAFIA reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BGFJINPLKGJ<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AFNNJDJEDOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public BGFJINPLKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x583C460", Offset = "0x583B860", VA = "0x18583C460")]
		internal void OGLNNIAJHOE(MHJPNDEAFIA reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly IDPPNEPBAOC NCMHCEEKAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, KLGJFCBKKPD> GLOFOBHPGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly PMDFLKCMKMG LPCEGHOADPM;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x67A1AD0", Offset = "0x67A0ED0", VA = "0x1867A1AD0")]
	public AFNNJDJEDOG(int FPELCKFDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3142330", Offset = "0x3141730", VA = "0x183142330", Slot = "4")]
	protected virtual ulong HOMLBPOJOGN<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x67A18D0", Offset = "0x67A0CD0", VA = "0x1867A18D0", Slot = "5")]
	protected virtual KLGJFCBKKPD GMGLMMBKFGI(MHJPNDEAFIA AJLILPPHPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3B27710", Offset = "0x3B26B10", VA = "0x183B27710", Slot = "6")]
	protected virtual void KHKELPODAMG<T>(PMDFLKCMKMG BMEAHINCLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x67A1A00", Offset = "0x67A0E00", VA = "0x1867A1A00")]
	public void LGLGAICMHIB(MHJPNDEAFIA AJLILPPHPPH, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3B27660", Offset = "0x3B26A60", VA = "0x183B27660")]
	public void KAOFGLNGLFA<T>(PMDFLKCMKMG BMEAHINCLAG, T OLNCIJOKKAP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67A1A80", Offset = "0x67A0E80", VA = "0x1867A1A80")]
	public void OEMACAAHKJG(MHJPNDEAFIA AJLILPPHPPH, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3B27940", Offset = "0x3B26D40", VA = "0x183B27940")]
	public void NJNIADIECJH<T>(Action<T> PIOFDJNIIJF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3B27780", Offset = "0x3B26B80", VA = "0x183B27780")]
	public void NJNIADIECJH<T, TUserData>(Action<T, TUserData> PIOFDJNIIJF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FNALHLCEIMP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F00", Offset = "0x67A6300", VA = "0x1867A6F00")]
	public FNALHLCEIMP(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MKGGMALEFFN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x67B6C70", Offset = "0x67B6070", VA = "0x1867B6C70")]
	public MKGGMALEFFN(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class IDPPNEPBAOC
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum CCHKIKPEPCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class BAODPPKNNIL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public CCHKIKPEPCG LNMDBHDAJAC;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5835A20", Offset = "0x5834E20", VA = "0x185835A20", Slot = "4")]
		public virtual void CIDIOEOELJF(MethodInfo NFOCFOFOOOP, MethodInfo GBEHCODGFCK, CCHKIKPEPCG BMIPLDLMPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void DOLENCEDDJN(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void MHPJBJABOOP(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		protected BAODPPKNNIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class GMFBEHIHFBE<TClass, TProperty> : BAODPPKNNIL<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> NMNICLBDGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> MPEBICKCLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> CIJLJOECPLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> GMKKGKPEHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> ODBNJBFBOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> DNEKCCPAAMI;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4513110", Offset = "0x4512510", VA = "0x184513110", Slot = "7")]
		public override void GCIKDJEKOFO(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x45137B0", Offset = "0x4512BB0", VA = "0x1845137B0", Slot = "8")]
		public override void KECLKHPOMBL(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4512310", Offset = "0x4511710", VA = "0x184512310", Slot = "9")]
		public override void DOLENCEDDJN(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4514070", Offset = "0x4513470", VA = "0x184514070", Slot = "10")]
		public override void MHPJBJABOOP(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4514A10", Offset = "0x4513E10", VA = "0x184514A10")]
		protected TProperty[] OFGFNOKCJDK(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x45132D0", Offset = "0x45126D0", VA = "0x1845132D0")]
		protected TProperty[] IOJNJCHLLPJ(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x450FFF0", Offset = "0x450F3F0", VA = "0x18450FFF0", Slot = "4")]
		public override void CIDIOEOELJF(MethodInfo NFOCFOFOOOP, MethodInfo GBEHCODGFCK, CCHKIKPEPCG BMIPLDLMPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4514B20", Offset = "0x4513F20", VA = "0x184514B20")]
		protected GMFBEHIHFBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class HFOJKCEEKAE<TClass, TProperty> : GMFBEHIHFBE<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void HNKMPBFJONH(MHJPNDEAFIA FBIKENCMLKN, [Out] TProperty NEDINDKOMCG);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void FGOPFNBCNAP(PMDFLKCMKMG KDEAIPINGAN, TProperty NEDINDKOMCG);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x45DAF00", Offset = "0x45DA300", VA = "0x1845DAF00", Slot = "5")]
		public override void ECCIGIDPGHK(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x45DB1A0", Offset = "0x45DA5A0", VA = "0x1845DB1A0", Slot = "6")]
		public override void KAOFGLNGLFA(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x45DB060", Offset = "0x45DA460", VA = "0x1845DB060", Slot = "7")]
		public override void GCIKDJEKOFO(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45DB220", Offset = "0x45DA620", VA = "0x1845DB220", Slot = "8")]
		public override void KECLKHPOMBL(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x43DBAE0", Offset = "0x43DAEE0", VA = "0x1843DBAE0")]
		protected HFOJKCEEKAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class CDJAGMMPGCO<T> : GMFBEHIHFBE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5A39050", Offset = "0x5A38450", VA = "0x185A39050", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7050", Offset = "0x3FF6450", VA = "0x183FF7050", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5A390D0", Offset = "0x5A384D0", VA = "0x185A390D0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF70C0", Offset = "0x3FF64C0", VA = "0x183FF70C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public CDJAGMMPGCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class ECBLPCEHFGA<T> : GMFBEHIHFBE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6F50", Offset = "0x3FF6350", VA = "0x183FF6F50", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7050", Offset = "0x3FF6450", VA = "0x183FF7050", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3FF6FD0", Offset = "0x3FF63D0", VA = "0x183FF6FD0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3FF70C0", Offset = "0x3FF64C0", VA = "0x183FF70C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public ECBLPCEHFGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KAGDJCPDHCD<T> : GMFBEHIHFBE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4A346F0", Offset = "0x4A33AF0", VA = "0x184A346F0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4A347F0", Offset = "0x4A33BF0", VA = "0x184A347F0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4A34770", Offset = "0x4A33B70", VA = "0x184A34770", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4A34860", Offset = "0x4A33C60", VA = "0x184A34860", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public KAGDJCPDHCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OMMEGGCPCKA<T> : GMFBEHIHFBE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4FC9860", Offset = "0x4FC8C60", VA = "0x184FC9860", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4A347F0", Offset = "0x4A33BF0", VA = "0x184A347F0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4FC98E0", Offset = "0x4FC8CE0", VA = "0x184FC98E0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4A34860", Offset = "0x4A33C60", VA = "0x184A34860", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public OMMEGGCPCKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MHIOAAKECJN<T> : GMFBEHIHFBE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4D70FB0", Offset = "0x4D703B0", VA = "0x184D70FB0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x49739E0", Offset = "0x4972DE0", VA = "0x1849739E0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4D71030", Offset = "0x4D70430", VA = "0x184D71030", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4973A50", Offset = "0x4972E50", VA = "0x184973A50", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public MHIOAAKECJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class JIMEOFOHKKL<T> : GMFBEHIHFBE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x49738E0", Offset = "0x4972CE0", VA = "0x1849738E0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x49739E0", Offset = "0x4972DE0", VA = "0x1849739E0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4973960", Offset = "0x4972D60", VA = "0x184973960", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4973A50", Offset = "0x4972E50", VA = "0x184973A50", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public JIMEOFOHKKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PJDPDLKJOJJ<T> : GMFBEHIHFBE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4799D70", Offset = "0x4799170", VA = "0x184799D70", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4799E70", Offset = "0x4799270", VA = "0x184799E70", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x50AA030", Offset = "0x50A9430", VA = "0x1850AA030", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4799EE0", Offset = "0x47992E0", VA = "0x184799EE0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public PJDPDLKJOJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AECBBAFIIHA<T> : GMFBEHIHFBE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4799D70", Offset = "0x4799170", VA = "0x184799D70", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4799E70", Offset = "0x4799270", VA = "0x184799E70", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4799DF0", Offset = "0x47991F0", VA = "0x184799DF0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4799EE0", Offset = "0x47992E0", VA = "0x184799EE0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public AECBBAFIIHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JGCPKHJBLLL<T> : GMFBEHIHFBE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x496F670", Offset = "0x496EA70", VA = "0x18496F670", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x496F770", Offset = "0x496EB70", VA = "0x18496F770", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x496F6F0", Offset = "0x496EAF0", VA = "0x18496F6F0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3FF70C0", Offset = "0x3FF64C0", VA = "0x183FF70C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public JGCPKHJBLLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LNKCFMCKEMN<T> : GMFBEHIHFBE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A130", Offset = "0x4B69530", VA = "0x184B6A130", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A230", Offset = "0x4B69630", VA = "0x184B6A230", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4B6A1B0", Offset = "0x4B695B0", VA = "0x184B6A1B0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4973A50", Offset = "0x4972E50", VA = "0x184973A50", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public LNKCFMCKEMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JMAMAIIHEMK<T> : GMFBEHIHFBE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x497CEF0", Offset = "0x497C2F0", VA = "0x18497CEF0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x497CFF0", Offset = "0x497C3F0", VA = "0x18497CFF0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x497CF70", Offset = "0x497C370", VA = "0x18497CF70", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4799EE0", Offset = "0x47992E0", VA = "0x184799EE0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3FF7130", Offset = "0x3FF6530", VA = "0x183FF7130")]
		public JMAMAIIHEMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PDMJEFABPNH<T> : HFOJKCEEKAE<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5080240", Offset = "0x507F640", VA = "0x185080240", Slot = "12")]
		protected override void FGOPFNBCNAP(PMDFLKCMKMG KDEAIPINGAN, char NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5080270", Offset = "0x507F670", VA = "0x185080270", Slot = "11")]
		protected override void HNKMPBFJONH(MHJPNDEAFIA FBIKENCMLKN, [Out] char NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA740", Offset = "0x3FC9B40", VA = "0x183FCA740")]
		public PDMJEFABPNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class EBHIPPFAJOB<T> : HFOJKCEEKAE<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5DE0", Offset = "0x3FF51E0", VA = "0x183FF5DE0", Slot = "12")]
		protected override void FGOPFNBCNAP(PMDFLKCMKMG KDEAIPINGAN, IPEndPoint NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3FF5E10", Offset = "0x3FF5210", VA = "0x183FF5E10", Slot = "11")]
		protected override void HNKMPBFJONH(MHJPNDEAFIA FBIKENCMLKN, [Out] IPEndPoint NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3FCA740", Offset = "0x3FC9B40", VA = "0x183FCA740")]
		public EBHIPPFAJOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BCBOIPBOCCM<T> : GMFBEHIHFBE<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int NABOBDALHKA;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5837940", Offset = "0x5836D40", VA = "0x185837940")]
		public BCBOIPBOCCM(int FCDJJGFAGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5837740", Offset = "0x5836B40", VA = "0x185837740", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5837840", Offset = "0x5836C40", VA = "0x185837840", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x58377C0", Offset = "0x5836BC0", VA = "0x1858377C0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x58378C0", Offset = "0x5836CC0", VA = "0x1858378C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class LFEGKFBCDKI<T> : BAODPPKNNIL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo OHKHHCPAKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type IKLFBLNJLOP;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C2A0", Offset = "0x4B5B6A0", VA = "0x184B5C2A0")]
		public LFEGKFBCDKI(PropertyInfo KKCCAKAEMAH, Type PNOFKLHJDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C010", Offset = "0x4B5B410", VA = "0x184B5C010", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C130", Offset = "0x4B5B530", VA = "0x184B5C130", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C0D0", Offset = "0x4B5B4D0", VA = "0x184B5C0D0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C1E0", Offset = "0x4B5B5E0", VA = "0x184B5C1E0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4B5BFB0", Offset = "0x4B5B3B0", VA = "0x184B5BFB0", Slot = "9")]
		public override void DOLENCEDDJN(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4B5C240", Offset = "0x4B5B640", VA = "0x184B5C240", Slot = "10")]
		public override void MHPJBJABOOP(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MOGDLNPFIBB<T> : LFEGKFBCDKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x40173C0", Offset = "0x40167C0", VA = "0x1840173C0")]
		public MOGDLNPFIBB(PropertyInfo KKCCAKAEMAH, Type PNOFKLHJDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4DD75C0", Offset = "0x4DD69C0", VA = "0x184DD75C0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4DD7680", Offset = "0x4DD6A80", VA = "0x184DD7680", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class CPEKLNBAMCM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static CPEKLNBAMCM<T> IMFIEPMCPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly BAODPPKNNIL<T>[] FJMEDHAEDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int FEMCLKABCCB;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9F00", Offset = "0x5CF9300", VA = "0x185CF9F00")]
		public CPEKLNBAMCM(List<BAODPPKNNIL<T>> HPFPIPEEBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9E50", Offset = "0x5CF9250", VA = "0x185CF9E50")]
		public void KAOFGLNGLFA(T GMFKPONAANG, PMDFLKCMKMG BMEAHINCLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5CF9DA0", Offset = "0x5CF91A0", VA = "0x185CF9DA0")]
		public void ECCIGIDPGHK(T GMFKPONAANG, MHJPNDEAFIA AJLILPPHPPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class ELNPPJIEOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract BAODPPKNNIL<T> NPPDIJEBOHO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private PMDFLKCMKMG PMABAOMPIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int JKCJDNBMPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, ELNPPJIEOKC> HDPAGFFCPII;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x67AC5B0", Offset = "0x67AB9B0", VA = "0x1867AC5B0")]
	public IDPPNEPBAOC(int FPELCKFDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x33BFD00", Offset = "0x33BF100", VA = "0x1833BFD00")]
	private CPEKLNBAMCM<T> JPOKCMDBKLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3153090", Offset = "0x3152490", VA = "0x183153090")]
	public void OCICFIBHEPA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x33BFBD0", Offset = "0x33BEFD0", VA = "0x1833BFBD0")]
	public bool GFOCOOKFNLL<T>(MHJPNDEAFIA AJLILPPHPPH, T MOCLCNOAHKF) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x33BFC70", Offset = "0x33BF070", VA = "0x1833BFC70")]
	public void IMJDHHAECMF<T>(PMDFLKCMKMG BMEAHINCLAG, T GMFKPONAANG) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class HDJDEJEMGPG
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime OBBHEJIEGGC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] OEKDHNEFOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NJLNDKEKKBM JLOAFODPNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x67AA150", Offset = "0x67A9550", VA = "0x1867AA150")]
		get
		{
			return default(NJLNDKEKKBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GGJKBILNABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x67A9800", Offset = "0x67A8C00", VA = "0x1867A9800")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x67A9A80", Offset = "0x67A8E80", VA = "0x1867A9A80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OFHFGLMGNIK ENIBFKGGOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x67AA180", Offset = "0x67A9580", VA = "0x1867AA180")]
		get
		{
			return default(OFHFGLMGNIK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x67A9830", Offset = "0x67A8C30", VA = "0x1867A9830")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DNBPKLBMAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x67A9EC0", Offset = "0x67A92C0", VA = "0x1867A9EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint PGLKGJDFMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x67A9750", Offset = "0x67A8B50", VA = "0x1867A9750")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? LDELHAHLMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x67A9A50", Offset = "0x67A8E50", VA = "0x1867A9A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? ICIJPFOIMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x67AA5C0", Offset = "0x67A99C0", VA = "0x1867AA5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? PCAEFIOHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x67A97D0", Offset = "0x67A8BD0", VA = "0x1867A97D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x67AA2D0", Offset = "0x67A96D0", VA = "0x1867AA2D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? KIFGEDPOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xA998F0", Offset = "0xA98CF0", VA = "0x180A998F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC48740", Offset = "0xC47B40", VA = "0x180C48740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x67AA7D0", Offset = "0x67A9BD0", VA = "0x1867AA7D0")]
	public HDJDEJEMGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x67AA720", Offset = "0x67A9B20", VA = "0x1867AA720")]
	internal HDJDEJEMGPG(byte[] HECJPBMFJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x67AA4A0", Offset = "0x67A98A0", VA = "0x1867AA4A0")]
	public static HDJDEJEMGPG OFMEOLNPCMP(byte[] HECJPBMFJGG, DateTime MDCFFDCCLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x67A9CC0", Offset = "0x67A90C0", VA = "0x1867A9CC0")]
	internal void IHDCJHPIEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x67A9870", Offset = "0x67A8C70", VA = "0x1867A9870")]
	private void EECNLBGLMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x67A9AC0", Offset = "0x67A8EC0", VA = "0x1867A9AC0")]
	private DateTime? HNIHLBGDJKE(int FDJGEFDKBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x67A9F80", Offset = "0x67A9380", VA = "0x1867A9F80")]
	private void KLLFOGDIGLH(int FDJGEFDKBBO, DateTime? KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x67AA5F0", Offset = "0x67A99F0", VA = "0x1867AA5F0")]
	private ulong PFBALFHNLFI(int FDJGEFDKBBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x67AA210", Offset = "0x67A9610", VA = "0x1867AA210")]
	private void MKJMDJECNKM(int FDJGEFDKBBO, ulong KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x67A9EF0", Offset = "0x67A92F0", VA = "0x1867A9EF0")]
	private uint KGCEALACNAG(int FDJGEFDKBBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6670580", Offset = "0x666F980", VA = "0x186670580")]
	private static uint MJBMEDBJIHO(uint IKAEODCKAIP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x67AA1B0", Offset = "0x67A95B0", VA = "0x1867AA1B0")]
	private static ulong MJBMEDBJIHO(ulong IKAEODCKAIP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum NJLNDKEKKBM
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
public enum OFHFGLMGNIK
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class FJEEOEPJMOH
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int MKLGENKLPOD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int COEFBIFPDCF = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int KJFCIOCIOOF = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint FHMBIFHJGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int EBBCJMBBAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int BHPMHAGHBDF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FBBFGHNBFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x67A8510", Offset = "0x67A7910", VA = "0x1867A8510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x67A8420", Offset = "0x67A7820", VA = "0x1867A8420")]
	public bool EALCPPEDECJ(AEIKHEFLJGJ NKFKONOGCEJ, int KGDKBIOOEOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class LLKMJDNKNFL : AEIKHEFLJGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket NKFKONOGCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly JAFMHCGIOND DAFOMOMNIOC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short EOFMGABNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x67B4800", Offset = "0x67B3C00", VA = "0x1867B4800", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int EPPNHNNGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x67B47E0", Offset = "0x67B3BE0", VA = "0x1867B47E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint FCLFPDPMLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x67B4950", Offset = "0x67B3D50", VA = "0x1867B4950", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily BCKFCGDNOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x4B37830", Offset = "0x4B36C30", VA = "0x184B37830", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x67B4970", Offset = "0x67B3D70", VA = "0x1867B4970")]
	public LLKMJDNKNFL(AddressFamily IIBJDKNOAKA, JAFMHCGIOND DAFOMOMNIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x67B4220", Offset = "0x67B3620", VA = "0x1867B4220", Slot = "8")]
	public bool AOPPMIJNFIP(IPEndPoint JEMILHCFMOK, JDMMLJBPJNP HKAKCDKICPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x67B4820", Offset = "0x67B3C20", VA = "0x1867B4820", Slot = "9")]
	public int KJGILHBBIOG(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int IBMHAIHIDJJ, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x67B4860", Offset = "0x67B3C60", VA = "0x1867B4860", Slot = "10")]
	public int KLJMBBEBDIE(byte[] DEEIKCMDENK, EndPoint HHGHHKJDAJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x67B4200", Offset = "0x67B3600", VA = "0x1867B4200", Slot = "11")]
	public void ANFCGLNPLHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface AEIKHEFLJGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short EOFMGABNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int EPPNHNNGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint FCLFPDPMLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily BCKFCGDNOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AOPPMIJNFIP(IPEndPoint JEMILHCFMOK, JDMMLJBPJNP HKAKCDKICPM);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KJGILHBBIOG(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int IBMHAIHIDJJ, IPEndPoint DBHJCCKKAMO);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KLJMBBEBDIE(byte[] DEEIKCMDENK, EndPoint DBHJCCKKAMO);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ANFCGLNPLHL();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct OLFNOILEFHK : IEquatable<OLFNOILEFHK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long AHIKPANBDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long CLHNGFHNFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long PCPIDNENJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int DAPBLCBNLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int CAKMCJCPFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x67B7D50", Offset = "0x67B7150", VA = "0x1867B7D50")]
	public OLFNOILEFHK(byte[] JMCLCDMOBMM, int PEPJJGNJCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9728C0", Offset = "0x971CC0", VA = "0x1809728C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x67B7D10", Offset = "0x67B7110", VA = "0x1867B7D10", Slot = "4")]
	public bool Equals(OLFNOILEFHK OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x67B7C60", Offset = "0x67B7060", VA = "0x1867B7C60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class AHICOMOFABB : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] IANKKCBCAIN;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class CNDFGJNMNMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int IKNCPJANMGO;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
	protected CNDFGJNMNMC(int JKPKDBICCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DNKEKEACFDP(IPEndPoint JEMILHCFMOK, byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NOKIKNDJJEL(IPEndPoint JEMILHCFMOK, byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class CMIPKBDGKFA : CNDFGJNMNMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] LKMGECEEGEE;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator KLEJLDOJDJM;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2580790", Offset = "0x257FB90", VA = "0x182580790")]
	public CMIPKBDGKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x67A7590", Offset = "0x67A6990", VA = "0x1867A7590")]
	public void NKIHODLMHPH(IPEndPoint JEMILHCFMOK, byte[] LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x67A7AB0", Offset = "0x67A6EB0", VA = "0x1867A7AB0")]
	public void OFPMKGDJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x67A70D0", Offset = "0x67A64D0", VA = "0x1867A70D0", Slot = "4")]
	public override void DNKEKEACFDP(IPEndPoint JEMILHCFMOK, byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x67A7740", Offset = "0x67A6B40", VA = "0x1867A7740", Slot = "5")]
	public override void NOKIKNDJJEL(IPEndPoint JEMILHCFMOK, byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct HNDMLHFFOAK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void GJPDCHNOJAM([NoAlias] byte* KPCDDLAAMKO, [NoAlias] byte* LKMGECEEGEE, [NoAlias] byte* BPOFHAHMILO, int GIGAFKHMOHH);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class OBPPNLGILJG
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr JNBHKFPGDBO;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr DPGHNCOBLHH;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x67B8F90", Offset = "0x67B8390", VA = "0x1867B8F90")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x67B8E30", Offset = "0x67B8230", VA = "0x1867B8E30")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x67B9300", Offset = "0x67B8700", VA = "0x1867B9300")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x67B90C0", Offset = "0x67B84C0", VA = "0x1867B90C0")]
		public unsafe static void CNDNDIPPKBE([NoAlias] byte* KPCDDLAAMKO, [NoAlias] byte* LKMGECEEGEE, [NoAlias] byte* BPOFHAHMILO, int GIGAFKHMOHH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint LKMGECEEGEE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint BPOFHAHMILO[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint GJFENGBPPEH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint OPCGAMKHHAP[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint CCOLPMNMCEH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint GGDBJCPDOCA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint LBKGNIKIMNP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint GAJFHEOEDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint OOGGGDHAHHD[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x67AC4C0", Offset = "0x67AB8C0", VA = "0x1867AC4C0")]
	private void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x67ABF70", Offset = "0x67AB370", VA = "0x1867ABF70")]
	private uint FFCOIBKBLOL(uint EFDAGALIIFI, int LNCFPMKFPEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x67A15F0", Offset = "0x67A09F0", VA = "0x1867A15F0")]
	private void EDDGAMCHOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x67A13E0", Offset = "0x67A07E0", VA = "0x1867A13E0")]
	private void ADNMHLLAMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x67A16A0", Offset = "0x67A0AA0", VA = "0x1867A16A0")]
	private void IGPJDIGNNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x67A1730", Offset = "0x67A0B30", VA = "0x1867A1730")]
	private void MPIPILKGKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x67ABF10", Offset = "0x67AB310", VA = "0x1867ABF10")]
	private void CDDCADDENDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x67AC0A0", Offset = "0x67AB4A0", VA = "0x1867AC0A0")]
	private unsafe void JPKBDDMICOO(byte* KPCDDLAAMKO, uint* LKMGECEEGEE, uint* BPOFHAHMILO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x67ABDB0", Offset = "0x67AB1B0", VA = "0x1867ABDB0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BGDFJIBFKBA([NoAlias] byte* KPCDDLAAMKO, [NoAlias] byte* LKMGECEEGEE, [NoAlias] byte* BPOFHAHMILO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x67ABE30", Offset = "0x67AB230", VA = "0x1867ABE30")]
	public static void BGDFJIBFKBA(Span<byte> KPCDDLAAMKO, Span<byte> LKMGECEEGEE, Span<byte> BPOFHAHMILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x67ABFA0", Offset = "0x67AB3A0", VA = "0x1867ABFA0")]
	public static void FIFOOMAENNN(Span<byte> KPCDDLAAMKO, Span<byte> LKMGECEEGEE, Span<byte> BPOFHAHMILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x67AC540", Offset = "0x67AB940", VA = "0x1867AC540")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OBFPELBFNBJ([NoAlias] byte* KPCDDLAAMKO, [NoAlias] byte* LKMGECEEGEE, [NoAlias] byte* BPOFHAHMILO, int GIGAFKHMOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x67B93B0", Offset = "0x67B87B0", VA = "0x1867B93B0")]
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
