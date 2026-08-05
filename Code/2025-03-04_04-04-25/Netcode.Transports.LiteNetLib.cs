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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool NFLOEONLEKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x681B5F0", Offset = "0x6819BF0", VA = "0x18681B5F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x681ABD0", Offset = "0x68191D0", VA = "0x18681ABD0")]
		public void RecRoom_SetEncryptionInfo(ulong ICDPBBOMIPJ, byte[] LKMGECEEGEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x681ABB0", Offset = "0x68191B0", VA = "0x18681ABB0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x681AA80", Offset = "0x6819080", VA = "0x18681AA80")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x681B4F0", Offset = "0x6819AF0", VA = "0x18681B4F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x681ACF0", Offset = "0x68192F0", VA = "0x18681ACF0", Slot = "6")]
		public override void Send(ulong JPPHMPLKKOL, ArraySegment<byte> GIDGOODJFLJ, NetworkDelivery PFFPMNGGPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x681AB70", Offset = "0x6819170", VA = "0x18681AB70", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong JPPHMPLKKOL, [Out] ArraySegment<byte> GOAPBALNOKD, [Out] float EDLAABLKNBB)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x681AFE0", Offset = "0x68195E0", VA = "0x18681AFE0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x681B410", Offset = "0x6819A10", VA = "0x18681B410", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x681A210", Offset = "0x6818810", VA = "0x18681A210", Slot = "10")]
		public override void DisconnectRemoteClient(ulong JPPHMPLKKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x681A120", Offset = "0x6818720", VA = "0x18681A120", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x681A530", Offset = "0x6818B30", VA = "0x18681A530", Slot = "12")]
		public override ulong GetCurrentRtt(ulong JPPHMPLKKOL)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x681AF70", Offset = "0x6819570", VA = "0x18681AF70", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x681A5D0", Offset = "0x6818BD0", VA = "0x18681A5D0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MJHAAJODHFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x681A790", Offset = "0x6818D90", VA = "0x18681A790")]
		private EKBGKAGOIAF LHFHIMBJLNL(NetworkDelivery BMIPLDLMPCD)
		{
			return default(EKBGKAGOIAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x681A9C0", Offset = "0x6818FC0", VA = "0x18681A9C0", Slot = "15")]
		private void NMMMHIFOPPE(ALFNHBPHADP ADCGCFIHOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x681A030", Offset = "0x6818630", VA = "0x18681A030", Slot = "16")]
		private void ACGLHHMIBCM(ALFNHBPHADP ADCGCFIHOIE, DGINEPAIMAB ILJOPNAPDAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "17")]
		private void HFPHGCCIFOJ(IPEndPoint JEMILHCFMOK, SocketError IKEMGBBJIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x681A320", Offset = "0x6818920", VA = "0x18681A320", Slot = "18")]
		private void EKMPMGFLIDA(ALFNHBPHADP ADCGCFIHOIE, GPEJAICFPCL AJLILPPHPPH, byte AFKKHALCJGJ, EKBGKAGOIAF FNAOKCGIBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x681A860", Offset = "0x6818E60", VA = "0x18681A860")]
		private void MAOAIBGIIGN(int IBMHAIHIDJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "19")]
		private void IABNGFJLHEJ(IPEndPoint DBHJCCKKAMO, GPEJAICFPCL AJLILPPHPPH, EANOMKAMGKI BILLKIDNEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "20")]
		private void CPGOMKMIJNM(ALFNHBPHADP ADCGCFIHOIE, int IBDNOFKGDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x681A940", Offset = "0x6818F40", VA = "0x18681A940", Slot = "21")]
		private void NDDFPKPPEEB(DHJDFIOGNAF NEMAHPGAGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x681A0F0", Offset = "0x68186F0", VA = "0x18681A0F0")]
		private ulong DBLPDAPJEIH(ALFNHBPHADP ADCGCFIHOIE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x681A9A0", Offset = "0x6818FA0", VA = "0x18681A9A0")]
		private static int NDJMNKKOLPP(float HKPDGGGHFLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x681B510", Offset = "0x6819B10", VA = "0x18681B510")]
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
	[Cpp2IlInjected.Address(RVA = "0x680C640", Offset = "0x680AC40", VA = "0x18680C640")]
	protected CLKEPLEHOIB(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x680C5A0", Offset = "0x680ABA0", VA = "0x18680C5A0")]
	public void KIELEBCOCGC(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x680C520", Offset = "0x680AB20", VA = "0x18680C520")]
	protected void HOAPDJOCGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x680C600", Offset = "0x680AC00", VA = "0x18680C600")]
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
		[Cpp2IlInjected.Address(RVA = "0x979920", Offset = "0x977F20", VA = "0x180979920")]
		[CompilerGenerated]
		get
		{
			return default(DALFAKOLAKC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC000C0", Offset = "0xBFE6C0", VA = "0x180C000C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x680D900", Offset = "0x680BF00", VA = "0x18680D900")]
	internal void HMCOMCNKFCJ(HIAKKMOCMAP ADKPFMHMONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x680D8D0", Offset = "0x680BED0", VA = "0x18680D8D0")]
	private bool GAIBGKIEIPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x680D9C0", Offset = "0x680BFC0", VA = "0x18680D9C0")]
	internal DHJDFIOGNAF(IPEndPoint DBHJCCKKAMO, HIAKKMOCMAP EKCPBIHAHND, JAFMHCGIOND OILBCIOLFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x680D960", Offset = "0x680BF60", VA = "0x18680D960")]
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
	[Cpp2IlInjected.Address(RVA = "0x68108F0", Offset = "0x680EEF0", VA = "0x1868108F0")]
	private HIAKKMOCMAP(long GPNKJLICHOJ, byte BPHGDKLHAIA, int KPOCLGHHOEP, byte[] MCHFCBHAIFN, MHJPNDEAFIA GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6810490", Offset = "0x680EA90", VA = "0x186810490")]
	public static int BAFBDLENCLM(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68106D0", Offset = "0x680ECD0", VA = "0x1868106D0")]
	public static HIAKKMOCMAP LBFIHDPKNOC(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x68104F0", Offset = "0x680EAF0", VA = "0x1868104F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6810440", Offset = "0x680EA40", VA = "0x186810440")]
	private HFPPKEAEEGF(long GPNKJLICHOJ, byte BPHGDKLHAIA, int BPIHOBOHBLI, bool HGKBNOABMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68102F0", Offset = "0x680E8F0", VA = "0x1868102F0")]
	public static HFPPKEAEEGF LBFIHDPKNOC(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6810200", Offset = "0x680E800", VA = "0x186810200")]
	public static OLBGAHBBLGP IJOLHJMNFLM(long BAKJEGOEMPJ, byte FHFKHBLCIMJ, int OJNAOPODIAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6810100", Offset = "0x680E700", VA = "0x186810100")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HIELMLODNMH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x950420", Offset = "0x94EA20", VA = "0x180950420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6810F70", Offset = "0x680F570", VA = "0x186810F70")]
	internal HJHKBMKLIIM(JAFMHCGIOND NKFKONOGCEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6810AF0", Offset = "0x680F0F0", VA = "0x186810AF0")]
	internal void BDEKIABEKMD(IPEndPoint CJFCGBALKBN, OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x33ED440", Offset = "0x33EBA40", VA = "0x1833ED440")]
	private void EALCPPEDECJ<T>(T OLNCIJOKKAP, IPEndPoint MOCLCNOAHKF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6810960", Offset = "0x680EF60", VA = "0x186810960")]
	private void AEHGIPNMDOO(HPDNJFNMION OJJKFAHDBGO, IPEndPoint CJFCGBALKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6810C70", Offset = "0x680F270", VA = "0x186810C70")]
	private void MDPHOKFPLNO(ACHEHIMPMMF OJJKFAHDBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6810DD0", Offset = "0x680F3D0", VA = "0x186810DD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x680C510", Offset = "0x680AB10", VA = "0x18680C510")]
	public MGOAABKDNFA(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CAMLDMEAALP : MGOAABKDNFA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x680C510", Offset = "0x680AB10", VA = "0x18680C510")]
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
	[Cpp2IlInjected.Address(RVA = "0x681C440", Offset = "0x681AA40", VA = "0x18681C440")]
	private static void IJNNDMKIOAH(GOLIIDOHFKB MLEBODNMHCE, string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x681C670", Offset = "0x681AC70", VA = "0x18681C670")]
	internal static void KNJFCLDDLAP(string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x681C380", Offset = "0x681A980", VA = "0x18681C380")]
	internal static void EEGMEMAPFDJ(string GIFBANFPJGI, params object[] JIEBKPCGKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x681C3E0", Offset = "0x681A9E0", VA = "0x18681C3E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x680ED10", Offset = "0x680D310", VA = "0x18680ED10")]
	internal GPEJAICFPCL(JAFMHCGIOND JEIEGFHFIPA, POIMBFCFADD HAIGDFHBOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x680ECA0", Offset = "0x680D2A0", VA = "0x18680ECA0")]
	internal void KIAKHNNHPMA(OLBGAHBBLGP OLNCIJOKKAP, int EKLNMDADKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x680EC20", Offset = "0x680D220", VA = "0x18680EC20")]
	internal void FKNLLDNHIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x680EBF0", Offset = "0x680D1F0", VA = "0x18680EBF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x681E2A0", Offset = "0x681C8A0", VA = "0x18681E2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x681C780", Offset = "0x681AD80", VA = "0x18681C780", Slot = "4")]
		public bool Equals(IPEndPoint IKAEODCKAIP, IPEndPoint ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6342900", Offset = "0x6340F00", VA = "0x186342900", Slot = "5")]
		public int GetHashCode(IPEndPoint GMFKPONAANG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC3A160", Offset = "0xC38760", VA = "0x180C3A160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC3A160", Offset = "0xC38760", VA = "0x180C3A160", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x17CBC80", Offset = "0x17CA280", VA = "0x1817CBC80")]
		public NEOOACDPPDD(ALFNHBPHADP FCEAHINHNGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x681C2E0", Offset = "0x681A8E0", VA = "0x18681C2E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x681C330", Offset = "0x681A930", VA = "0x18681C330", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x12E7C90", Offset = "0x12E6290", VA = "0x1812E7C90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x12E7590", Offset = "0x12E5B90", VA = "0x1812E7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PDNNLKIJDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x20BEB60", Offset = "0x20BD160", VA = "0x1820BEB60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x20BEBC0", Offset = "0x20BD1C0", VA = "0x1820BEBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte PIGGDJEJOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB07810", Offset = "0xB05E10", VA = "0x180B07810")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IKNCPJANMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6818270", Offset = "0x6816870", VA = "0x186818270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short EOFMGABNEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6812980", Offset = "0x6810F80", VA = "0x186812980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6817350", Offset = "0x6815950", VA = "0x186817350")]
	public void HPDLKGNNMMD(IPEndPoint JEMILHCFMOK, byte[] LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6817570", Offset = "0x6815B70", VA = "0x186817570")]
	public void IMOELILFPKG(IPEndPoint JEMILHCFMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6816100", Offset = "0x6814700", VA = "0x186816100")]
	private bool FNMJFKDJJIC(IPEndPoint JEMILHCFMOK, [Out] ALFNHBPHADP ADCGCFIHOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6818C20", Offset = "0x6817220", VA = "0x186818C20")]
	private void PFGDHPGHFMI(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6812F90", Offset = "0x6811590", VA = "0x186812F90")]
	private void CKBEMGGAFKD(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6818500", Offset = "0x6816B00", VA = "0x186818500")]
	private void NPOEHJOGGNI(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68190E0", Offset = "0x68176E0", VA = "0x1868190E0")]
	public JAFMHCGIOND(LEHGIGPJAEJ OILBCIOLFPK, [Optional] CNDFGJNMNMC EGLFHLDIJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6812FE0", Offset = "0x68115E0", VA = "0x186812FE0")]
	internal void DHNBPBENNCM(ALFNHBPHADP PFNOPIDACBB, int IBDNOFKGDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6818290", Offset = "0x6816890", VA = "0x186818290")]
	internal void LGIOPJIBGPB(ALFNHBPHADP PFNOPIDACBB, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x68157B0", Offset = "0x6813DB0", VA = "0x1868157B0")]
	internal void EKOMGAIHNGM(ALFNHBPHADP ADCGCFIHOIE, GNJIAPDJKGG CEGFAIJENKH, SocketError GFLDPECFGMP, OLBGAHBBLGP NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6817700", Offset = "0x6815D00", VA = "0x186817700")]
	private void IOIDHJLDODF(ALFNHBPHADP ADCGCFIHOIE, GNJIAPDJKGG CEGFAIJENKH, SocketError GFLDPECFGMP, bool MHOOEDPKADD, byte[] GIDGOODJFLJ, int HHIGALLBHNK, int BBEJNKBNMID, OLBGAHBBLGP NBGBHBICCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6811C60", Offset = "0x6810260", VA = "0x186811C60")]
	private void AFKIMNAEPGO(POIMBFCFADD.NBHAOHMNMFP BMIPLDLMPCD, [Optional] ALFNHBPHADP ADCGCFIHOIE, [Optional] IPEndPoint DBHJCCKKAMO, SocketError HKJCJLGBMOM = SocketError.Success, int IBDNOFKGDHE = 0, GNJIAPDJKGG EEPKMOCFGEH = GNJIAPDJKGG.ConnectionFailed, [Optional] DHJDFIOGNAF KHNHPKIIHPL, EKBGKAGOIAF FNAOKCGIBBC = EKBGKAGOIAF.Unreliable, byte AFKKHALCJGJ = 0, [Optional] OLBGAHBBLGP HCHABEIHMOP, [Optional] object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6814770", Offset = "0x6812D70", VA = "0x186814770")]
	private void EHIEJBKJENP(POIMBFCFADD HAIGDFHBOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68182E0", Offset = "0x68168E0", VA = "0x1868182E0")]
	internal void MMPPNOMPJOA(POIMBFCFADD HAIGDFHBOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6816340", Offset = "0x6814940", VA = "0x186816340")]
	private void GFJAGICJJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6815B90", Offset = "0x6814190", VA = "0x186815B90")]
	private void FKGOHBODHBJ(int JOOHFMJEDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6816AC0", Offset = "0x68150C0", VA = "0x186816AC0")]
	internal ALFNHBPHADP HGCJNMMOLHI(DHJDFIOGNAF NEMAHPGAGLG, byte[] IALAKEEHJMN, int HHIGALLBHNK, int GIGAFKHMOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68180F0", Offset = "0x68166F0", VA = "0x1868180F0")]
	private int JMGPCDNKNLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6818770", Offset = "0x6816D70", VA = "0x186818770")]
	private void OIHLEPHCJOB(IPEndPoint DBHJCCKKAMO, ALFNHBPHADP APMOBKJGMBD, HIAKKMOCMAP CBFLFMOAAPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6813390", Offset = "0x6811990", VA = "0x186813390")]
	private void EEMNPKPNIEL(OLBGAHBBLGP OLNCIJOKKAP, IPEndPoint DBHJCCKKAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68126A0", Offset = "0x6810CA0", VA = "0x1868126A0")]
	internal void BHFHGFKBOLK(OLBGAHBBLGP OLNCIJOKKAP, EKBGKAGOIAF PMAAKBDMJEK, byte AFKKHALCJGJ, int EKLNMDADKPG, ALFNHBPHADP PFNOPIDACBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6815720", Offset = "0x6813D20", VA = "0x186815720")]
	public bool EKFPEOGCKKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6815700", Offset = "0x6813D00", VA = "0x186815700")]
	public bool EKFPEOGCKKC(IPAddress BJIJEDBELIG, IPAddress CMLJFLMBBGB, int GMEMHACONIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6815730", Offset = "0x6813D30", VA = "0x186815730")]
	public bool EKFPEOGCKKC(int GMEMHACONIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6816190", Offset = "0x6814790", VA = "0x186816190")]
	public void GFCMLHJMGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6817F30", Offset = "0x6816530", VA = "0x186817F30")]
	public ALFNHBPHADP JKBEOHINGHJ(string JMCLCDMOBMM, int GMEMHACONIH, string LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6818010", Offset = "0x6816610", VA = "0x186818010")]
	public ALFNHBPHADP JKBEOHINGHJ(string JMCLCDMOBMM, int GMEMHACONIH, PMDFLKCMKMG FHAEHIHLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6817B60", Offset = "0x6816160", VA = "0x186817B60")]
	public ALFNHBPHADP JKBEOHINGHJ(IPEndPoint MOCLCNOAHKF, PMDFLKCMKMG FHAEHIHLDCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6813030", Offset = "0x6811630", VA = "0x186813030")]
	public void EDANFFCKCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6813040", Offset = "0x6811640", VA = "0x186813040")]
	public void EDANFFCKCPP(bool JOEDEDNDCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6816950", Offset = "0x6814F50", VA = "0x186816950")]
	public void HDLEIOBNCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6816A00", Offset = "0x6815000", VA = "0x186816A00")]
	public void HDLEIOBNCAL(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68176C0", Offset = "0x6815CC0", VA = "0x1868176C0")]
	public void IOIDHJLDODF(ALFNHBPHADP ADCGCFIHOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6817B20", Offset = "0x6816120", VA = "0x186817B20")]
	public void IOIDHJLDODF(ALFNHBPHADP ADCGCFIHOIE, byte[] GIDGOODJFLJ, int HHIGALLBHNK, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6818F00", Offset = "0x6817500", VA = "0x186818F00", Slot = "4")]
	private IEnumerator<ALFNHBPHADP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6818F90", Offset = "0x6817590", VA = "0x186818F90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6815AA0", Offset = "0x68140A0", VA = "0x186815AA0")]
	private OLBGAHBBLGP FFBGBMMBNAH(CCLEIPPHPEK KKCCAKAEMAH, int IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x68159C0", Offset = "0x6813FC0", VA = "0x1868159C0")]
	private OLBGAHBBLGP FFBGBMMBNAH(CCLEIPPHPEK KKCCAKAEMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6815EB0", Offset = "0x68144B0", VA = "0x186815EB0")]
	internal OLBGAHBBLGP FNDPGIFFHJN(int IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x68170E0", Offset = "0x68156E0", VA = "0x1868170E0")]
	internal void HKBHMCJFFIA(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6819020", Offset = "0x6817620", VA = "0x186819020")]
	static JAFMHCGIOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12E7C90", Offset = "0x12E6290", VA = "0x1812E7C90")]
	private bool PKFLGBGJCDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x68183F0", Offset = "0x68169F0", VA = "0x1868183F0")]
	private void MPCBBFFJGFC(IPEndPoint AOAEJCPNLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6818170", Offset = "0x6816770", VA = "0x186818170")]
	private void JOCAAHHKKOF(IPEndPoint AOAEJCPNLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6812DE0", Offset = "0x68113E0", VA = "0x186812DE0")]
	private bool CGALGKNFPMH(SocketException DADIPHEHDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6816680", Offset = "0x6814C80", VA = "0x186816680")]
	private void GGFAFEMEOBL(AEIKHEFLJGJ NKFKONOGCEJ, EndPoint AHHOCDEFAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6812A40", Offset = "0x6811040", VA = "0x186812A40")]
	private void BJDKOMHEFNA(object CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6814F40", Offset = "0x6813540", VA = "0x186814F40")]
	public bool EKFPEOGCKKC(IPAddress BJIJEDBELIG, IPAddress CMLJFLMBBGB, int GMEMHACONIH, bool GABKFPKILHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6815960", Offset = "0x6813F60", VA = "0x186815960")]
	internal int FEMCNPFKJMO(OLBGAHBBLGP OLNCIJOKKAP, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6812660", Offset = "0x6810C60", VA = "0x186812660")]
	internal int AHHOLHBCENG(OLBGAHBBLGP OLNCIJOKKAP, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6812040", Offset = "0x6810640", VA = "0x186812040")]
	internal int AHHOLHBCENG(byte[] MIALAMIFNLM, int HHIGALLBHNK, int GIGAFKHMOHH, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x68157F0", Offset = "0x6813DF0", VA = "0x1868157F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x681CC40", Offset = "0x681B240", VA = "0x18681CC40")]
		get
		{
			return default(CCLEIPPHPEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x681CC00", Offset = "0x681B200", VA = "0x18681CC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte MMOIEAKKPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x681C830", Offset = "0x681AE30", VA = "0x18681C830")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x681CB60", Offset = "0x681B160", VA = "0x18681CB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort FDLBDIBCDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x681CD50", Offset = "0x681B350", VA = "0x18681CD50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x681CD10", Offset = "0x681B310", VA = "0x18681CD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MLIBNHCBMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x681CA90", Offset = "0x681B090", VA = "0x18681CA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte LJHBLBNAHBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x681CAF0", Offset = "0x681B0F0", VA = "0x18681CAF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x681C960", Offset = "0x681AF60", VA = "0x18681C960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LLEAADLHANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x681CBA0", Offset = "0x681B1A0", VA = "0x18681CBA0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x681C7F0", Offset = "0x681ADF0", VA = "0x18681C7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort DAMMMAOGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x681CC70", Offset = "0x681B270", VA = "0x18681CC70")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x681CCD0", Offset = "0x681B2D0", VA = "0x18681CCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JJDMJHNFCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x681CDB0", Offset = "0x681B3B0", VA = "0x18681CDB0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x681CB20", Offset = "0x681B120", VA = "0x18681CB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x681CE10", Offset = "0x681B410", VA = "0x18681CE10")]
	static OLBGAHBBLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x681CAC0", Offset = "0x681B0C0", VA = "0x18681CAC0")]
	public void GOHEDDEJNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x681D0F0", Offset = "0x681B6F0", VA = "0x18681D0F0")]
	public OLBGAHBBLGP(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x681D160", Offset = "0x681B760", VA = "0x18681D160")]
	public OLBGAHBBLGP(CCLEIPPHPEK KKCCAKAEMAH, int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x681C990", Offset = "0x681AF90", VA = "0x18681C990")]
	public static int GANLLHDJDAC(CCLEIPPHPEK KKCCAKAEMAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x681CA00", Offset = "0x681B000", VA = "0x18681CA00")]
	public int GANLLHDJDAC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x681C860", Offset = "0x681AE60", VA = "0x18681C860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3D340", Offset = "0xA3B940", VA = "0x180A3D340")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6808CB0", Offset = "0x68072B0", VA = "0x186808CB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint NKPKGMKPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB76760", Offset = "0xB74D60", VA = "0x180B76760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GFIHPKPDAKG ENFAMNJFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D360", Offset = "0xA3B960", VA = "0x180A3D360")]
		get
		{
			return default(GFIHPKPDAKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KAJDENBLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9558C0", Offset = "0x953EC0", VA = "0x1809558C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int GKKMHKCFDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1348500", Offset = "0x1346B00", VA = "0x181348500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C278F0", Offset = "0x1C25EF0", VA = "0x181C278F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NFCIBEGFAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6809090", Offset = "0x6807690", VA = "0x186809090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MLPLNPKLPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9612B0", Offset = "0x95F8B0", VA = "0x1809612B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LNHKEPIMGBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62F5C80", Offset = "0x62F4280", VA = "0x1862F5C80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FINJOLJFABI CBMIMPLCMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6808640", Offset = "0x6806C40", VA = "0x186808640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6807260", Offset = "0x6805860", VA = "0x186807260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x680AED0", Offset = "0x68094D0", VA = "0x18680AED0")]
	internal ALFNHBPHADP(JAFMHCGIOND DAFOMOMNIOC, IPEndPoint DBHJCCKKAMO, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6809070", Offset = "0x6807670", VA = "0x186809070")]
	internal void JLPNKAJELCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6809600", Offset = "0x6807C00", VA = "0x186809600")]
	internal void MJOFBMJILHA(IPEndPoint HHBNALMDGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68092B0", Offset = "0x68078B0", VA = "0x1868092B0")]
	internal void LPDBOABCFEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6807310", Offset = "0x6805910", VA = "0x186807310")]
	private void DGDNLPKPMCI(int NIKFCHCIOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6809AC0", Offset = "0x68080C0", VA = "0x186809AC0")]
	private void OJNCHHPLLBO(int ACPAEBKIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6809750", Offset = "0x6807D50", VA = "0x186809750")]
	private CLKEPLEHOIB OAHHGLNAAFO(byte MKNOLMMOIDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x680AD40", Offset = "0x6809340", VA = "0x18680AD40")]
	internal ALFNHBPHADP(JAFMHCGIOND DAFOMOMNIOC, IPEndPoint DBHJCCKKAMO, int KGHCKLKGJKM, byte FHFKHBLCIMJ, PMDFLKCMKMG GJNHFAFGCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x680AB60", Offset = "0x6809160", VA = "0x18680AB60")]
	internal ALFNHBPHADP(JAFMHCGIOND DAFOMOMNIOC, DHJDFIOGNAF NEMAHPGAGLG, int KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6809700", Offset = "0x6807D00", VA = "0x186809700")]
	internal void NPIJPKLCCLP(HIAKKMOCMAP IKIFJNBFIDN, byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6809680", Offset = "0x6807C80", VA = "0x186809680")]
	internal bool NICKIKEIDIH(HFPPKEAEEGF OLNCIJOKKAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6807530", Offset = "0x6805B30", VA = "0x186807530")]
	public void EALCPPEDECJ(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH, EKBGKAGOIAF DCEHMKPFEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6808750", Offset = "0x6806D50", VA = "0x186808750")]
	private void JDHIGHCKMHA(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH, byte AFKKHALCJGJ, EKBGKAGOIAF FNAOKCGIBBC, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6809630", Offset = "0x6807C30", VA = "0x186809630")]
	public void NDBONFMDEOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6807560", Offset = "0x6805B60", VA = "0x186807560")]
	internal KJAIELBFAMH EEEPBGGGAIA(OLBGAHBBLGP OLNCIJOKKAP)
	{
		return default(KJAIELBFAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68086F0", Offset = "0x6806CF0", VA = "0x1868086F0")]
	internal void JCCLGECNNHK(CLKEPLEHOIB GJMMFDLBGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6808D60", Offset = "0x6807360", VA = "0x186808D60")]
	internal PMFOCJCFPOB JLIOHLLGMND(byte[] GIDGOODJFLJ, int HHIGALLBHNK, int GIGAFKHMOHH, bool MHOOEDPKADD)
	{
		return default(PMFOCJCFPOB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6807640", Offset = "0x6805C40", VA = "0x186807640")]
	private void EIFMPLBKAIB(int PJBGPEDOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6809B00", Offset = "0x6808100", VA = "0x186809B00")]
	internal void PGLKGBLNMOF(EKBGKAGOIAF PMAAKBDMJEK, OLBGAHBBLGP FCEAHINHNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68080D0", Offset = "0x68066D0", VA = "0x1868080D0")]
	private void GNGAMHNBGGD(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6807680", Offset = "0x6805C80", VA = "0x186807680")]
	private void EPECKCGBOFF(int HIBCBLOKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6809900", Offset = "0x6807F00", VA = "0x186809900")]
	internal EKFBGFBGBLN OIHLEPHCJOB(HIAKKMOCMAP CBFLFMOAAPO)
	{
		return default(EKFBGFBGBLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6807A10", Offset = "0x6806010", VA = "0x186807A10")]
	internal void GBGPPLAMAJP(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68073E0", Offset = "0x68059E0", VA = "0x1868073E0")]
	private void DOEOJHEGCNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68090A0", Offset = "0x68076A0", VA = "0x1868090A0")]
	internal void KJEPFFEGPEF(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x680A4A0", Offset = "0x6808AA0", VA = "0x18680A4A0")]
	internal void PLJNMJIHBJD(int HIBCBLOKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6809340", Offset = "0x6807940", VA = "0x186809340")]
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
		[Cpp2IlInjected.Address(RVA = "0x680BFA0", Offset = "0x680A5A0", VA = "0x18680BFA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long DJPPPEOHNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x680BF80", Offset = "0x680A580", VA = "0x18680BF80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long EEKAIGLGEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x680BF90", Offset = "0x680A590", VA = "0x18680BF90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MDJJCCNBINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x680BED0", Offset = "0x680A4D0", VA = "0x18680BED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long ANLBEAFMGLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x680BE10", Offset = "0x680A410", VA = "0x18680BE10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long LOBCHFFJJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x680C060", Offset = "0x680A660", VA = "0x18680C060")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long GJEFNCOLHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x680BFB0", Offset = "0x680A5B0", VA = "0x18680BFB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long ABAEPIJPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x680BD70", Offset = "0x680A370", VA = "0x18680BD70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private DCFPKLHFJFD GDIIKEHHBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x680BEC0", Offset = "0x680A4C0", VA = "0x18680BEC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double BAFFEFNBKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x680BD10", Offset = "0x680A310", VA = "0x18680BD10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x680BF40", Offset = "0x680A540", VA = "0x18680BF40")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x680BEE0", Offset = "0x680A4E0", VA = "0x18680BEE0")]
	public void ILGNFCJCMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x680C0E0", Offset = "0x680A6E0", VA = "0x18680C0E0")]
	public void OHMNGEBILPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x680C070", Offset = "0x680A670", VA = "0x18680C070")]
	public void NPIMIFMJJEJ(long PIHAKLMBEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x680BFF0", Offset = "0x680A5F0", VA = "0x18680BFF0")]
	public void MBGOKOMEFNI(long EEGLPGIPCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x680BDB0", Offset = "0x680A3B0", VA = "0x18680BDB0")]
	public void COIBCFNAMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x680C130", Offset = "0x680A730", VA = "0x18680C130")]
	public void PCNHEPAIIMO(long BBIFKJCCGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x680C1B0", Offset = "0x680A7B0", VA = "0x18680C1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x680BE20", Offset = "0x680A420", VA = "0x18680BE20")]
	public void ELCEPEANCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x680D390", Offset = "0x680B990", VA = "0x18680D390")]
	public static IPEndPoint GMHKLOLLAGC(string HKMGPAMGNCG, int GMEMHACONIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x680D670", Offset = "0x680BC70", VA = "0x18680D670")]
	public static IPAddress ICDMOCAMFJA(string HKMGPAMGNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x680D5E0", Offset = "0x680BBE0", VA = "0x18680D5E0")]
	public static IPAddress ICDMOCAMFJA(string HKMGPAMGNCG, AddressFamily IIBJDKNOAKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x680D360", Offset = "0x680B960", VA = "0x18680D360")]
	internal static int EBKNLOFLBLF(int MKFGMIFHKNM, int HILNFBANAMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x324C730", Offset = "0x324AD30", VA = "0x18324C730")]
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
		[Cpp2IlInjected.Address(RVA = "0x680BC70", Offset = "0x680A270", VA = "0x18680BC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x680BB90", Offset = "0x680A190", VA = "0x18680BB90")]
		public void CIDIOEOELJF(OLBGAHBBLGP OLNCIJOKKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x680BC00", Offset = "0x680A200", VA = "0x18680BC00")]
		public bool MELKNKBPHFH(long LOJMONJPLCB, ALFNHBPHADP ADCGCFIHOIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x680BBB0", Offset = "0x680A1B0", VA = "0x18680BBB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x680EA20", Offset = "0x680D020", VA = "0x18680EA20")]
	public GAKOFHOJNNF(ALFNHBPHADP ADCGCFIHOIE, bool FNLFAGPENHB, byte KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x680DB30", Offset = "0x680C130", VA = "0x18680DB30")]
	private void DJIOPEEPCLG(OLBGAHBBLGP OLNCIJOKKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x680E550", Offset = "0x680CB50", VA = "0x18680E550", Slot = "4")]
	protected override bool ICAKHFFGKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x680DEF0", Offset = "0x680C4F0", VA = "0x18680DEF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x680BAD0", Offset = "0x680A0D0", VA = "0x18680BAD0")]
	public AOBICJMHJEO(ALFNHBPHADP ADCGCFIHOIE, bool CMLGOKFONGL, byte KGHCKLKGJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x680B610", Offset = "0x6809C10", VA = "0x18680B610", Slot = "4")]
	protected override bool ICAKHFFGKHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x680B330", Offset = "0x6809930", VA = "0x18680B330", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6806900", Offset = "0x6804F00", VA = "0x186806900")]
	private static void CFHHJPGEKEH(byte[] DEEIKCMDENK, int FDJGEFDKBBO, ulong GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x680D200", Offset = "0x680B800", VA = "0x18680D200")]
	private static void CFHHJPGEKEH(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x680D270", Offset = "0x680B870", VA = "0x18680D270")]
	public static void CFHHJPGEKEH(byte[] DEEIKCMDENK, int FDJGEFDKBBO, short GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x680D2C0", Offset = "0x680B8C0", VA = "0x18680D2C0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, double KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x680D2E0", Offset = "0x680B8E0", VA = "0x18680D2E0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x680D270", Offset = "0x680B870", VA = "0x18680D270")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, short KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x680D270", Offset = "0x680B870", VA = "0x18680D270")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, ushort KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x680D200", Offset = "0x680B800", VA = "0x18680D200")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x680D200", Offset = "0x680B800", VA = "0x18680D200")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, uint KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x680D2B0", Offset = "0x680B8B0", VA = "0x18680D2B0")]
	public static void PFJFDALLHPI(byte[] HECJPBMFJGG, int EKDINNHMJFC, long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x680D2B0", Offset = "0x680B8B0", VA = "0x18680D2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int OBPKCAFDNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA8B580", Offset = "0xA89B80", VA = "0x180A8B580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NOLGFANEPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x681B910", Offset = "0x6819F10", VA = "0x18681B910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DADCAOGHJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x248B180", Offset = "0x2489780", VA = "0x18248B180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int OBABOJAIBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x681C020", Offset = "0x681A620", VA = "0x18681C020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x681C070", Offset = "0x681A670", VA = "0x18681C070")]
	public void KIAKHNNHPMA(byte[] MBDLAJMBAIN, int FDJGEFDKBBO, int OJGAKAIOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public MHJPNDEAFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x681C220", Offset = "0x681A820", VA = "0x18681C220")]
	public MHJPNDEAFIA(byte[] MBDLAJMBAIN, int FDJGEFDKBBO, int OJGAKAIOJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x681B9A0", Offset = "0x6819FA0", VA = "0x18681B9A0")]
	public IPEndPoint DHDDIOJFACG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x681BAF0", Offset = "0x681A0F0", VA = "0x18681BAF0")]
	public byte FEIIDCGHHEE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x681BAF0", Offset = "0x681A0F0", VA = "0x18681BAF0")]
	public sbyte JKAJBODGCFD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x350E790", Offset = "0x350CD90", VA = "0x18350E790")]
	public T[] JNGIKLEFNCH<T>(ushort IBMHAIHIDJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x681C030", Offset = "0x681A630", VA = "0x18681C030")]
	public bool[] KBJHJOLGKKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x681B610", Offset = "0x6819C10", VA = "0x18681B610")]
	public ushort[] ABMPEDJHADK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x681B690", Offset = "0x6819C90", VA = "0x18681B690")]
	public short[] AKFOCMNOHFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x681B920", Offset = "0x6819F20", VA = "0x18681B920")]
	public int[] CPJDFCHDEBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x681BA70", Offset = "0x681A070", VA = "0x18681BA70")]
	public uint[] EOELNGJJCLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x681B890", Offset = "0x6819E90", VA = "0x18681B890")]
	public float[] CDAJAFOOMPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x681B960", Offset = "0x6819F60", VA = "0x18681B960")]
	public double[] DCFIINGMJIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x681BFA0", Offset = "0x681A5A0", VA = "0x18681BFA0")]
	public long[] HKPDGIGCCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x681B650", Offset = "0x6819C50", VA = "0x18681B650")]
	public ulong[] AFFHJAEPONE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x681BB30", Offset = "0x681A130", VA = "0x18681BB30")]
	public string[] GIKBEPPEFKH(int FPELCKFDBEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x681B8D0", Offset = "0x6819ED0", VA = "0x18681B8D0")]
	public bool CEMGKHJAGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x681BC80", Offset = "0x681A280", VA = "0x18681BC80")]
	public char GJGKAKCONBM()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x681BC80", Offset = "0x681A280", VA = "0x18681BC80")]
	public ushort OPGBNFCPFJG()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x681C140", Offset = "0x681A740", VA = "0x18681C140")]
	public short MFDLEIBLHNF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x681B820", Offset = "0x6819E20", VA = "0x18681B820")]
	public long CAOJMPHHFMP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x681B6D0", Offset = "0x6819CD0", VA = "0x18681B6D0")]
	public ulong AOCKCALANAH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x681B740", Offset = "0x6819D40", VA = "0x18681B740")]
	public int BBNEDFGFMOB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x681C1B0", Offset = "0x681A7B0", VA = "0x18681C1B0")]
	public uint OKMLMEICEIL()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x681B7B0", Offset = "0x6819DB0", VA = "0x18681B7B0")]
	public float BOBHPPGGGMC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x681BF30", Offset = "0x681A530", VA = "0x18681BF30")]
	public double HBCJJEOJEJC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x681BCF0", Offset = "0x681A2F0", VA = "0x18681BCF0")]
	public string HAPGJAEFBKP(int FCDJJGFAGNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x681C0D0", Offset = "0x681A6D0", VA = "0x18681C0D0")]
	public ArraySegment<byte> LOMAPENHLDB(int BBEJNKBNMID)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x681BFE0", Offset = "0x681A5E0", VA = "0x18681BFE0")]
	public sbyte[] IKAJMMJKHLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x681BAB0", Offset = "0x681A0B0", VA = "0x18681BAB0")]
	public byte[] FANMNCCLJGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x681C0B0", Offset = "0x681A6B0", VA = "0x18681C0B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int AFNDGLAJDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x954480", Offset = "0x952A80", VA = "0x180954480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x681E180", Offset = "0x681C780", VA = "0x18681E180")]
	public PMDFLKCMKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x681E200", Offset = "0x681C800", VA = "0x18681E200")]
	public PMDFLKCMKMG(bool NEGNDEADJGK, int MNIENPOFPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x681DC30", Offset = "0x681C230", VA = "0x18681DC30")]
	public static PMDFLKCMKMG DPOEGBKMEON(string KBGCCIOIGBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x681DB90", Offset = "0x681C190", VA = "0x18681DB90")]
	public void BJJJNNJENLK(int FGICKOMPDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2504750", Offset = "0x2502D50", VA = "0x182504750")]
	public void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x681D910", Offset = "0x681BF10", VA = "0x18681D910")]
	public void AGPGBFOKNPG(float KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x681DA00", Offset = "0x681C000", VA = "0x18681DA00")]
	public void AGPGBFOKNPG(double KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x681D9B0", Offset = "0x681BFB0", VA = "0x18681D9B0")]
	public void AGPGBFOKNPG(long KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x681D9B0", Offset = "0x681BFB0", VA = "0x18681D9B0")]
	public void AGPGBFOKNPG(ulong KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x681D4C0", Offset = "0x681BAC0", VA = "0x18681D4C0")]
	public void AGPGBFOKNPG(int KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x681D4C0", Offset = "0x681BAC0", VA = "0x18681D4C0")]
	public void AGPGBFOKNPG(uint KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x681D450", Offset = "0x681BA50", VA = "0x18681D450")]
	public void AGPGBFOKNPG(char KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x681D450", Offset = "0x681BA50", VA = "0x18681D450")]
	public void AGPGBFOKNPG(ushort KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x681D450", Offset = "0x681BA50", VA = "0x18681D450")]
	public void AGPGBFOKNPG(short KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x681D5C0", Offset = "0x681BBC0", VA = "0x18681D5C0")]
	public void AGPGBFOKNPG(sbyte KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x681D5C0", Offset = "0x681BBC0", VA = "0x18681D5C0")]
	public void AGPGBFOKNPG(byte KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x681D550", Offset = "0x681BB50", VA = "0x18681D550")]
	public void AGPGBFOKNPG(byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x681DAB0", Offset = "0x681C0B0", VA = "0x18681DAB0")]
	public void JCLPJDHCGGL(sbyte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x681DAB0", Offset = "0x681C0B0", VA = "0x18681DAB0")]
	public void BGEOGBHMJPP(byte[] GIDGOODJFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x681DA50", Offset = "0x681C050", VA = "0x18681DA50")]
	public void AGPGBFOKNPG(bool KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x681E010", Offset = "0x681C610", VA = "0x18681E010")]
	public void EFEOPCCCICF(Array IPJLMGNKKAH, int EOGCMBDMIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x681DE60", Offset = "0x681C460", VA = "0x18681DE60")]
	public void EFEOPCCCICF(float[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x681DD80", Offset = "0x681C380", VA = "0x18681DD80")]
	public void EFEOPCCCICF(double[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x681DD80", Offset = "0x681C380", VA = "0x18681DD80")]
	public void EFEOPCCCICF(long[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x681DD80", Offset = "0x681C380", VA = "0x18681DD80")]
	public void EFEOPCCCICF(ulong[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x681DE60", Offset = "0x681C460", VA = "0x18681DE60")]
	public void EFEOPCCCICF(int[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x681DE60", Offset = "0x681C460", VA = "0x18681DE60")]
	public void EFEOPCCCICF(uint[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x681DCA0", Offset = "0x681C2A0", VA = "0x18681DCA0")]
	public void EFEOPCCCICF(ushort[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x681DCA0", Offset = "0x681C2A0", VA = "0x18681DCA0")]
	public void EFEOPCCCICF(short[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x681DAB0", Offset = "0x681C0B0", VA = "0x18681DAB0")]
	public void EFEOPCCCICF(bool[] KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x681DF40", Offset = "0x681C540", VA = "0x18681DF40")]
	public void EFEOPCCCICF(string[] KBGCCIOIGBD, int JCEGDOALJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x681D840", Offset = "0x681BE40", VA = "0x18681D840")]
	public void AGPGBFOKNPG(IPEndPoint JEMILHCFMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x681D830", Offset = "0x681BE30", VA = "0x18681D830")]
	public void AGPGBFOKNPG(string KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x681D620", Offset = "0x681BC20", VA = "0x18681D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C4A370", Offset = "0x5C48970", VA = "0x185C4A370")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public KEJACFMOPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4AA8570", Offset = "0x4AA6B70", VA = "0x184AA8570")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BGFJINPLKGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x589FD50", Offset = "0x589E350", VA = "0x18589FD50")]
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
	[Cpp2IlInjected.Address(RVA = "0x68070E0", Offset = "0x68056E0", VA = "0x1868070E0")]
	public AFNNJDJEDOG(int FPELCKFDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3189130", Offset = "0x3187730", VA = "0x183189130", Slot = "4")]
	protected virtual ulong HOMLBPOJOGN<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6806EE0", Offset = "0x68054E0", VA = "0x186806EE0", Slot = "5")]
	protected virtual KLGJFCBKKPD GMGLMMBKFGI(MHJPNDEAFIA AJLILPPHPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3B72320", Offset = "0x3B70920", VA = "0x183B72320", Slot = "6")]
	protected virtual void KHKELPODAMG<T>(PMDFLKCMKMG BMEAHINCLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6807010", Offset = "0x6805610", VA = "0x186807010")]
	public void LGLGAICMHIB(MHJPNDEAFIA AJLILPPHPPH, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x3B72270", Offset = "0x3B70870", VA = "0x183B72270")]
	public void KAOFGLNGLFA<T>(PMDFLKCMKMG BMEAHINCLAG, T OLNCIJOKKAP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6807090", Offset = "0x6805690", VA = "0x186807090")]
	public void OEMACAAHKJG(MHJPNDEAFIA AJLILPPHPPH, object AGOFGEFAJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3B72550", Offset = "0x3B70B50", VA = "0x183B72550")]
	public void NJNIADIECJH<T>(Action<T> PIOFDJNIIJF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3B72390", Offset = "0x3B70990", VA = "0x183B72390")]
	public void NJNIADIECJH<T, TUserData>(Action<T, TUserData> PIOFDJNIIJF) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class FNALHLCEIMP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x680C510", Offset = "0x680AB10", VA = "0x18680C510")]
	public FNALHLCEIMP(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MKGGMALEFFN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x681C280", Offset = "0x681A880", VA = "0x18681C280")]
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
		[Cpp2IlInjected.Address(RVA = "0x5899310", Offset = "0x5897910", VA = "0x185899310", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x456C790", Offset = "0x456AD90", VA = "0x18456C790", Slot = "7")]
		public override void GCIKDJEKOFO(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x456CE30", Offset = "0x456B430", VA = "0x18456CE30", Slot = "8")]
		public override void KECLKHPOMBL(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x456B990", Offset = "0x4569F90", VA = "0x18456B990", Slot = "9")]
		public override void DOLENCEDDJN(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x456D6F0", Offset = "0x456BCF0", VA = "0x18456D6F0", Slot = "10")]
		public override void MHPJBJABOOP(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x456E090", Offset = "0x456C690", VA = "0x18456E090")]
		protected TProperty[] OFGFNOKCJDK(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x456C950", Offset = "0x456AF50", VA = "0x18456C950")]
		protected TProperty[] IOJNJCHLLPJ(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4569670", Offset = "0x4567C70", VA = "0x184569670", Slot = "4")]
		public override void CIDIOEOELJF(MethodInfo NFOCFOFOOOP, MethodInfo GBEHCODGFCK, CCHKIKPEPCG BMIPLDLMPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x456E1A0", Offset = "0x456C7A0", VA = "0x18456E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4634E80", Offset = "0x4633480", VA = "0x184634E80", Slot = "5")]
		public override void ECCIGIDPGHK(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4635120", Offset = "0x4633720", VA = "0x184635120", Slot = "6")]
		public override void KAOFGLNGLFA(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4634FE0", Offset = "0x46335E0", VA = "0x184634FE0", Slot = "7")]
		public override void GCIKDJEKOFO(TClass OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x46351A0", Offset = "0x46337A0", VA = "0x1846351A0", Slot = "8")]
		public override void KECLKHPOMBL(TClass OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x44356C0", Offset = "0x4433CC0", VA = "0x1844356C0")]
		protected HFOJKCEEKAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class CDJAGMMPGCO<T> : GMFBEHIHFBE<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5A71CD0", Offset = "0x5A702D0", VA = "0x185A71CD0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4049950", Offset = "0x4047F50", VA = "0x184049950", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5A71D50", Offset = "0x5A70350", VA = "0x185A71D50", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x40499C0", Offset = "0x4047FC0", VA = "0x1840499C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public CDJAGMMPGCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class ECBLPCEHFGA<T> : GMFBEHIHFBE<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4049850", Offset = "0x4047E50", VA = "0x184049850", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4049950", Offset = "0x4047F50", VA = "0x184049950", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x40498D0", Offset = "0x4047ED0", VA = "0x1840498D0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x40499C0", Offset = "0x4047FC0", VA = "0x1840499C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public ECBLPCEHFGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KAGDJCPDHCD<T> : GMFBEHIHFBE<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4A91910", Offset = "0x4A8FF10", VA = "0x184A91910", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4A91A10", Offset = "0x4A90010", VA = "0x184A91A10", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4A91990", Offset = "0x4A8FF90", VA = "0x184A91990", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4A91A80", Offset = "0x4A90080", VA = "0x184A91A80", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public KAGDJCPDHCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OMMEGGCPCKA<T> : GMFBEHIHFBE<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5028250", Offset = "0x5026850", VA = "0x185028250", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4A91A10", Offset = "0x4A90010", VA = "0x184A91A10", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x50282D0", Offset = "0x50268D0", VA = "0x1850282D0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4A91A80", Offset = "0x4A90080", VA = "0x184A91A80", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public OMMEGGCPCKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MHIOAAKECJN<T> : GMFBEHIHFBE<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4DCE9F0", Offset = "0x4DCCFF0", VA = "0x184DCE9F0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x49CF3E0", Offset = "0x49CD9E0", VA = "0x1849CF3E0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4DCEA70", Offset = "0x4DCD070", VA = "0x184DCEA70", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x49CF450", Offset = "0x49CDA50", VA = "0x1849CF450", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public MHIOAAKECJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class JIMEOFOHKKL<T> : GMFBEHIHFBE<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x49CF2E0", Offset = "0x49CD8E0", VA = "0x1849CF2E0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x49CF3E0", Offset = "0x49CD9E0", VA = "0x1849CF3E0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x49CF360", Offset = "0x49CD960", VA = "0x1849CF360", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x49CF450", Offset = "0x49CDA50", VA = "0x1849CF450", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public JIMEOFOHKKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PJDPDLKJOJJ<T> : GMFBEHIHFBE<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x47CECE0", Offset = "0x47CD2E0", VA = "0x1847CECE0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x47CEDE0", Offset = "0x47CD3E0", VA = "0x1847CEDE0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5108640", Offset = "0x5106C40", VA = "0x185108640", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x47CEE50", Offset = "0x47CD450", VA = "0x1847CEE50", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public PJDPDLKJOJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class AECBBAFIIHA<T> : GMFBEHIHFBE<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x47CECE0", Offset = "0x47CD2E0", VA = "0x1847CECE0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x47CEDE0", Offset = "0x47CD3E0", VA = "0x1847CEDE0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x47CED60", Offset = "0x47CD360", VA = "0x1847CED60", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x47CEE50", Offset = "0x47CD450", VA = "0x1847CEE50", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public AECBBAFIIHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class JGCPKHJBLLL<T> : GMFBEHIHFBE<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x49CB070", Offset = "0x49C9670", VA = "0x1849CB070", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x49CB170", Offset = "0x49C9770", VA = "0x1849CB170", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x49CB0F0", Offset = "0x49C96F0", VA = "0x1849CB0F0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x40499C0", Offset = "0x4047FC0", VA = "0x1840499C0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public JGCPKHJBLLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LNKCFMCKEMN<T> : GMFBEHIHFBE<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4BC66B0", Offset = "0x4BC4CB0", VA = "0x184BC66B0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4BC67B0", Offset = "0x4BC4DB0", VA = "0x184BC67B0", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4BC6730", Offset = "0x4BC4D30", VA = "0x184BC6730", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x49CF450", Offset = "0x49CDA50", VA = "0x1849CF450", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public LNKCFMCKEMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class JMAMAIIHEMK<T> : GMFBEHIHFBE<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x49D8920", Offset = "0x49D6F20", VA = "0x1849D8920", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x49D8A20", Offset = "0x49D7020", VA = "0x1849D8A20", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x49D89A0", Offset = "0x49D6FA0", VA = "0x1849D89A0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x47CEE50", Offset = "0x47CD450", VA = "0x1847CEE50", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x4049A30", Offset = "0x4048030", VA = "0x184049A30")]
		public JMAMAIIHEMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class PDMJEFABPNH<T> : HFOJKCEEKAE<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x50DE8F0", Offset = "0x50DCEF0", VA = "0x1850DE8F0", Slot = "12")]
		protected override void FGOPFNBCNAP(PMDFLKCMKMG KDEAIPINGAN, char NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x50DE920", Offset = "0x50DCF20", VA = "0x1850DE920", Slot = "11")]
		protected override void HNKMPBFJONH(MHJPNDEAFIA FBIKENCMLKN, [Out] char NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x401CFF0", Offset = "0x401B5F0", VA = "0x18401CFF0")]
		public PDMJEFABPNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class EBHIPPFAJOB<T> : HFOJKCEEKAE<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x4048860", Offset = "0x4046E60", VA = "0x184048860", Slot = "12")]
		protected override void FGOPFNBCNAP(PMDFLKCMKMG KDEAIPINGAN, IPEndPoint NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4048890", Offset = "0x4046E90", VA = "0x184048890", Slot = "11")]
		protected override void HNKMPBFJONH(MHJPNDEAFIA FBIKENCMLKN, [Out] IPEndPoint NEDINDKOMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x401CFF0", Offset = "0x401B5F0", VA = "0x18401CFF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x589B230", Offset = "0x5899830", VA = "0x18589B230")]
		public BCBOIPBOCCM(int FCDJJGFAGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x589B030", Offset = "0x5899630", VA = "0x18589B030", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x589B130", Offset = "0x5899730", VA = "0x18589B130", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x589B0B0", Offset = "0x58996B0", VA = "0x18589B0B0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x589B1B0", Offset = "0x58997B0", VA = "0x18589B1B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BB92B0", Offset = "0x4BB78B0", VA = "0x184BB92B0")]
		public LFEGKFBCDKI(PropertyInfo KKCCAKAEMAH, Type PNOFKLHJDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9020", Offset = "0x4BB7620", VA = "0x184BB9020", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9140", Offset = "0x4BB7740", VA = "0x184BB9140", Slot = "6")]
		public override void KAOFGLNGLFA(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4BB90E0", Offset = "0x4BB76E0", VA = "0x184BB90E0", Slot = "7")]
		public override void GCIKDJEKOFO(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4BB91F0", Offset = "0x4BB77F0", VA = "0x184BB91F0", Slot = "8")]
		public override void KECLKHPOMBL(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8FC0", Offset = "0x4BB75C0", VA = "0x184BB8FC0", Slot = "9")]
		public override void DOLENCEDDJN(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4BB9250", Offset = "0x4BB7850", VA = "0x184BB9250", Slot = "10")]
		public override void MHPJBJABOOP(T OJMDENCMIOK, PMDFLKCMKMG KDEAIPINGAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MOGDLNPFIBB<T> : LFEGKFBCDKI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4066120", Offset = "0x4064720", VA = "0x184066120")]
		public MOGDLNPFIBB(PropertyInfo KKCCAKAEMAH, Type PNOFKLHJDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4E351D0", Offset = "0x4E337D0", VA = "0x184E351D0", Slot = "5")]
		public override void ECCIGIDPGHK(T OJMDENCMIOK, MHJPNDEAFIA FBIKENCMLKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4E35290", Offset = "0x4E33890", VA = "0x184E35290", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x5D35F90", Offset = "0x5D34590", VA = "0x185D35F90")]
		public CPEKLNBAMCM(List<BAODPPKNNIL<T>> HPFPIPEEBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D35EE0", Offset = "0x5D344E0", VA = "0x185D35EE0")]
		public void KAOFGLNGLFA(T GMFKPONAANG, PMDFLKCMKMG BMEAHINCLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D35E30", Offset = "0x5D34430", VA = "0x185D35E30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6811BC0", Offset = "0x68101C0", VA = "0x186811BC0")]
	public IDPPNEPBAOC(int FPELCKFDBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3404AF0", Offset = "0x34030F0", VA = "0x183404AF0")]
	private CPEKLNBAMCM<T> JPOKCMDBKLF<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x31999F0", Offset = "0x3197FF0", VA = "0x1831999F0")]
	public void OCICFIBHEPA<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x34049C0", Offset = "0x3402FC0", VA = "0x1834049C0")]
	public bool GFOCOOKFNLL<T>(MHJPNDEAFIA AJLILPPHPPH, T MOCLCNOAHKF) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3404A60", Offset = "0x3403060", VA = "0x183404A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
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
		[Cpp2IlInjected.Address(RVA = "0x680F760", Offset = "0x680DD60", VA = "0x18680F760")]
		get
		{
			return default(NJLNDKEKKBM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int GGJKBILNABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x680EE10", Offset = "0x680D410", VA = "0x18680EE10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x680F090", Offset = "0x680D690", VA = "0x18680F090")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OFHFGLMGNIK ENIBFKGGOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x680F790", Offset = "0x680DD90", VA = "0x18680F790")]
		get
		{
			return default(OFHFGLMGNIK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x680EE40", Offset = "0x680D440", VA = "0x18680EE40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DNBPKLBMAPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x680F4D0", Offset = "0x680DAD0", VA = "0x18680F4D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint PGLKGJDFMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x680ED60", Offset = "0x680D360", VA = "0x18680ED60")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? LDELHAHLMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x680F060", Offset = "0x680D660", VA = "0x18680F060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? ICIJPFOIMML
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x680FBD0", Offset = "0x680E1D0", VA = "0x18680FBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? PCAEFIOHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x680EDE0", Offset = "0x680D3E0", VA = "0x18680EDE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x680F8E0", Offset = "0x680DEE0", VA = "0x18680F8E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? KIFGEDPOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA1810", Offset = "0xA9FE10", VA = "0x180AA1810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC7EB70", Offset = "0xC7D170", VA = "0x180C7EB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x680FDE0", Offset = "0x680E3E0", VA = "0x18680FDE0")]
	public HDJDEJEMGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x680FD30", Offset = "0x680E330", VA = "0x18680FD30")]
	internal HDJDEJEMGPG(byte[] HECJPBMFJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x680FAB0", Offset = "0x680E0B0", VA = "0x18680FAB0")]
	public static HDJDEJEMGPG OFMEOLNPCMP(byte[] HECJPBMFJGG, DateTime MDCFFDCCLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x680F2D0", Offset = "0x680D8D0", VA = "0x18680F2D0")]
	internal void IHDCJHPIEAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x680EE80", Offset = "0x680D480", VA = "0x18680EE80")]
	private void EECNLBGLMOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x680F0D0", Offset = "0x680D6D0", VA = "0x18680F0D0")]
	private DateTime? HNIHLBGDJKE(int FDJGEFDKBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x680F590", Offset = "0x680DB90", VA = "0x18680F590")]
	private void KLLFOGDIGLH(int FDJGEFDKBBO, DateTime? KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x680FC00", Offset = "0x680E200", VA = "0x18680FC00")]
	private ulong PFBALFHNLFI(int FDJGEFDKBBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x680F820", Offset = "0x680DE20", VA = "0x18680F820")]
	private void MKJMDJECNKM(int FDJGEFDKBBO, ulong KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x680F500", Offset = "0x680DB00", VA = "0x18680F500")]
	private uint KGCEALACNAG(int FDJGEFDKBBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x66D5740", Offset = "0x66D3D40", VA = "0x1866D5740")]
	private static uint MJBMEDBJIHO(uint IKAEODCKAIP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x680F7C0", Offset = "0x680DDC0", VA = "0x18680F7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x680DB20", Offset = "0x680C120", VA = "0x18680DB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x680DA30", Offset = "0x680C030", VA = "0x18680DA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6819E10", Offset = "0x6818410", VA = "0x186819E10", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int EPPNHNNGKGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6819DF0", Offset = "0x68183F0", VA = "0x186819DF0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint FCLFPDPMLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6819F60", Offset = "0x6818560", VA = "0x186819F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily BCKFCGDNOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xFB7310", Offset = "0xFB5910", VA = "0x180FB7310", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6819F80", Offset = "0x6818580", VA = "0x186819F80")]
	public LLKMJDNKNFL(AddressFamily IIBJDKNOAKA, JAFMHCGIOND DAFOMOMNIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6819830", Offset = "0x6817E30", VA = "0x186819830", Slot = "8")]
	public bool AOPPMIJNFIP(IPEndPoint JEMILHCFMOK, JDMMLJBPJNP HKAKCDKICPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6819E30", Offset = "0x6818430", VA = "0x186819E30", Slot = "9")]
	public int KJGILHBBIOG(byte[] DEEIKCMDENK, int FDJGEFDKBBO, int IBMHAIHIDJJ, IPEndPoint DBHJCCKKAMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6819E70", Offset = "0x6818470", VA = "0x186819E70", Slot = "10")]
	public int KLJMBBEBDIE(byte[] DEEIKCMDENK, EndPoint HHGHHKJDAJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6819810", Offset = "0x6817E10", VA = "0x186819810", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x681D360", Offset = "0x681B960", VA = "0x18681D360")]
	public OLFNOILEFHK(byte[] JMCLCDMOBMM, int PEPJJGNJCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x979920", Offset = "0x977F20", VA = "0x180979920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x681D320", Offset = "0x681B920", VA = "0x18681D320", Slot = "4")]
	public bool Equals(OLFNOILEFHK OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x681D270", Offset = "0x681B870", VA = "0x18681D270", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x25B3510", Offset = "0x25B1B10", VA = "0x1825B3510")]
	public CMIPKBDGKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x680CBA0", Offset = "0x680B1A0", VA = "0x18680CBA0")]
	public void NKIHODLMHPH(IPEndPoint JEMILHCFMOK, byte[] LKMGECEEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x680D0C0", Offset = "0x680B6C0", VA = "0x18680D0C0")]
	public void OFPMKGDJLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x680C6E0", Offset = "0x680ACE0", VA = "0x18680C6E0", Slot = "4")]
	public override void DNKEKEACFDP(IPEndPoint JEMILHCFMOK, byte[] GIDGOODJFLJ, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x680CD50", Offset = "0x680B350", VA = "0x18680CD50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x681E5A0", Offset = "0x681CBA0", VA = "0x18681E5A0")]
		[BurstDiscard]
		private static void CMDCBKFDKEE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x681E440", Offset = "0x681CA40", VA = "0x18681E440")]
		private static IntPtr BHMEKCHEAGK()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x681E910", Offset = "0x681CF10", VA = "0x18681E910")]
		public static void IBJDMOEOEBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
		public static void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x681E6D0", Offset = "0x681CCD0", VA = "0x18681E6D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6811AD0", Offset = "0x68100D0", VA = "0x186811AD0")]
	private void KLOHADBCHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6811580", Offset = "0x680FB80", VA = "0x186811580")]
	private uint FFCOIBKBLOL(uint EFDAGALIIFI, int LNCFPMKFPEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6806C00", Offset = "0x6805200", VA = "0x186806C00")]
	private void EDDGAMCHOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x68069F0", Offset = "0x6804FF0", VA = "0x1868069F0")]
	private void ADNMHLLAMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6806CB0", Offset = "0x68052B0", VA = "0x186806CB0")]
	private void IGPJDIGNNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6806D40", Offset = "0x6805340", VA = "0x186806D40")]
	private void MPIPILKGKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6811520", Offset = "0x680FB20", VA = "0x186811520")]
	private void CDDCADDENDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x68116B0", Offset = "0x680FCB0", VA = "0x1868116B0")]
	private unsafe void JPKBDDMICOO(byte* KPCDDLAAMKO, uint* LKMGECEEGEE, uint* BPOFHAHMILO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x68113C0", Offset = "0x680F9C0", VA = "0x1868113C0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BGDFJIBFKBA([NoAlias] byte* KPCDDLAAMKO, [NoAlias] byte* LKMGECEEGEE, [NoAlias] byte* BPOFHAHMILO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6811440", Offset = "0x680FA40", VA = "0x186811440")]
	public static void BGDFJIBFKBA(Span<byte> KPCDDLAAMKO, Span<byte> LKMGECEEGEE, Span<byte> BPOFHAHMILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x68115B0", Offset = "0x680FBB0", VA = "0x1868115B0")]
	public static void FIFOOMAENNN(Span<byte> KPCDDLAAMKO, Span<byte> LKMGECEEGEE, Span<byte> BPOFHAHMILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6811B50", Offset = "0x6810150", VA = "0x186811B50")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void OBFPELBFNBJ([NoAlias] byte* KPCDDLAAMKO, [NoAlias] byte* LKMGECEEGEE, [NoAlias] byte* BPOFHAHMILO, int GIGAFKHMOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x681E9C0", Offset = "0x681CFC0", VA = "0x18681E9C0")]
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
