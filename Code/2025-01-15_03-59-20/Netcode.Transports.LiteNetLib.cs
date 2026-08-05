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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, MMDKIEDAFIK
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum ONGFBDOPIMJ
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
		private NetworkManager PDPNMINDDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, LFKBAMMDNBC> DEMHMECEIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EBAFGKIDJCA GCFFPEOLJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] AJDHADLGOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ONGFBDOPIMJ DLKOJCJEEIC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong MDFNGMPMJLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MNDILBDNIJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x63A47E0", Offset = "0x63A3BE0", VA = "0x1863A47E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x63A3D70", Offset = "0x63A3170", VA = "0x1863A3D70")]
		public void RecRoom_SetEncryptionInfo(ulong AFDJBHMMINH, byte[] LDCKBFKFIKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x63A3D50", Offset = "0x63A3150", VA = "0x1863A3D50")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63A3C20", Offset = "0x63A3020", VA = "0x1863A3C20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x63A46E0", Offset = "0x63A3AE0", VA = "0x1863A46E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x63A3E90", Offset = "0x63A3290", VA = "0x1863A3E90", Slot = "6")]
		public override void Send(ulong BLDKEJEIDPH, ArraySegment<byte> JGCOLLOOLHL, NetworkDelivery BKFAINGMNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x63A3D10", Offset = "0x63A3110", VA = "0x1863A3D10", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BLDKEJEIDPH, [Out] ArraySegment<byte> PBJNGGAILNG, [Out] float PHKOBJJOCNF)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x63A4180", Offset = "0x63A3580", VA = "0x1863A4180", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x63A4600", Offset = "0x63A3A00", VA = "0x1863A4600", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63A33D0", Offset = "0x63A27D0", VA = "0x1863A33D0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BLDKEJEIDPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63A32E0", Offset = "0x63A26E0", VA = "0x1863A32E0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x63A36F0", Offset = "0x63A2AF0", VA = "0x1863A36F0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BLDKEJEIDPH)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63A4110", Offset = "0x63A3510", VA = "0x1863A4110", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x63A3860", Offset = "0x63A2C60", VA = "0x1863A3860", Slot = "14")]
		public override void Initialize([Optional] NetworkManager PDPNMINDDFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63A3790", Offset = "0x63A2B90", VA = "0x1863A3790")]
		private FJPDPEPKCEO HPLCIOFFNAC(NetworkDelivery IFBDJLKPHIG)
		{
			return default(FJPDPEPKCEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63A3B00", Offset = "0x63A2F00", VA = "0x1863A3B00", Slot = "15")]
		private void ONABMIEMGKD(LFKBAMMDNBC HKHPFCFJEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x63A3A40", Offset = "0x63A2E40", VA = "0x1863A3A40", Slot = "16")]
		private void OILPOGCKAMK(LFKBAMMDNBC HKHPFCFJEEC, FNFFENJPEID NILGMEFGPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "17")]
		private void EIPHAMGEHLF(IPEndPoint GLFHKDBKIDM, SocketError LGKIOOLANGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63A34E0", Offset = "0x63A28E0", VA = "0x1863A34E0", Slot = "18")]
		private void FCJIDEDLEMM(LFKBAMMDNBC HKHPFCFJEEC, HIGJMMHAKKI IEMPDPINHLH, byte NLPLCCLPCED, FJPDPEPKCEO OGKJKGLPGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63A3200", Offset = "0x63A2600", VA = "0x1863A3200")]
		private void AKNINOPHBFJ(int BGDDCGNLDBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "19")]
		private void NOKBGOFLCJD(IPEndPoint EJHHBFHANIP, HIGJMMHAKKI IEMPDPINHLH, HMEEMLBMNPJ LOHBMOPCGPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "20")]
		private void GLHGJHEGBKB(LFKBAMMDNBC HKHPFCFJEEC, int KHJHMFEAGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x63A3BC0", Offset = "0x63A2FC0", VA = "0x1863A3BC0", Slot = "21")]
		private void OPMMHGMHLDI(MMKEOAKLNLF BLIDGDGMCAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63A31D0", Offset = "0x63A25D0", VA = "0x1863A31D0")]
		private ulong ADEMAKPBCFP(LFKBAMMDNBC HKHPFCFJEEC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x63A3A20", Offset = "0x63A2E20", VA = "0x1863A3A20")]
		private static int MNLLONMKDGN(float CHFBMMDLDCL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x63A4700", Offset = "0x63A3B00", VA = "0x1863A4700")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class LNEODLDONAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly LFKBAMMDNBC OPNHJFPOCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<FIJIGBDFGGF> AGJHHIIFBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KOHJGHJGICM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63A3130", Offset = "0x63A2530", VA = "0x1863A3130")]
	protected LNEODLDONAJ(LFKBAMMDNBC HKHPFCFJEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63A30D0", Offset = "0x63A24D0", VA = "0x1863A30D0")]
	public void OHMOADFOJMF(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63A3050", Offset = "0x63A2450", VA = "0x1863A3050")]
	protected void NJEACOPPIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63A3010", Offset = "0x63A2410", VA = "0x1863A3010")]
	public bool JLMKNJCMCIA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool JIEIOGNGMKB();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool HLDONNFIGHG(FIJIGBDFGGF FLGFIKLLJDI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum KKIECEJKFHG
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
public class MMKEOAKLNLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EBAFGKIDJCA IJMFCLIHKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int JDBEFMNHGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal ADMGHAMAECK CNBKCKFEIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint MNPOHMNABHJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal KKIECEJKFHG HDPJOGJGFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8EF030", Offset = "0x8EE430", VA = "0x1808EF030")]
		[CompilerGenerated]
		get
		{
			return default(KKIECEJKFHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99BBB0", Offset = "0x99AFB0", VA = "0x18099BBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x63A4FB0", Offset = "0x63A43B0", VA = "0x1863A4FB0")]
	internal void BBBCFIPBCML(ADMGHAMAECK LIDKBKKECBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x63A5070", Offset = "0x63A4470", VA = "0x1863A5070")]
	private bool OEPLKNEPCOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63A50A0", Offset = "0x63A44A0", VA = "0x1863A50A0")]
	internal MMKEOAKLNLF(IPEndPoint EJHHBFHANIP, ADMGHAMAECK GKBHNMIOENA, EBAFGKIDJCA IMHIIMJFBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x63A5010", Offset = "0x63A4410", VA = "0x1863A5010")]
	public LFKBAMMDNBC MANENJIJBPO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HMEEMLBMNPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KFFAEFLOFMJ
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
public struct FNFFENJPEID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public KFFAEFLOFMJ BJPADBDMDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError OLCMPJDPFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HIGJMMHAKKI DFIJIKPJFHI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MMDKIEDAFIK
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGKAKGOODHP(LFKBAMMDNBC HKHPFCFJEEC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNEANLJOEKF(LFKBAMMDNBC HKHPFCFJEEC, FNFFENJPEID NILGMEFGPHE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HJLOHIHMDJE(IPEndPoint GLFHKDBKIDM, SocketError LGKIOOLANGO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMMABMBHCBD(LFKBAMMDNBC HKHPFCFJEEC, HIGJMMHAKKI IEMPDPINHLH, byte NLPLCCLPCED, FJPDPEPKCEO OGKJKGLPGFJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EMPNFPACOKD(IPEndPoint EJHHBFHANIP, HIGJMMHAKKI IEMPDPINHLH, HMEEMLBMNPJ LOHBMOPCGPC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PFJFAKJHDIG(LFKBAMMDNBC HKHPFCFJEEC, int KHJHMFEAGAJ);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHNHHKPDJMI(MMKEOAKLNLF BLIDGDGMCAP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AJIJEAAOIJF
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDDFAIBKNMB(LFKBAMMDNBC HKHPFCFJEEC, object OEJDLHPPLOG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NJNKAIOLJAO
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLELJDAKLGP(EMFDBNEONHA FLGFIKLLJDI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JMHKKAOLBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKBPDELCBLJ(LFKBAMMDNBC HKHPFCFJEEC, IPEndPoint KKAFBDDAACF);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class ADMGHAMAECK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int EOBNDPECJNL = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long KADHIPDOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte FPNLDJADMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] NJFMJCEGCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DCKCPIENGMJ GLBGLIBCAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int LFNJFJFEAAG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6390B20", Offset = "0x638FF20", VA = "0x186390B20")]
	private ADMGHAMAECK(long ELHFOEIMNFC, byte DHKDPBBHGHG, int FCHDAFNGEPF, byte[] HNKEMMCKBNB, DCKCPIENGMJ JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x63908A0", Offset = "0x638FCA0", VA = "0x1863908A0")]
	public static int EFIAKAIEGFN(FIJIGBDFGGF FLGFIKLLJDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6390900", Offset = "0x638FD00", VA = "0x186390900")]
	public static ADMGHAMAECK MLDKPOJIBPC(FIJIGBDFGGF FLGFIKLLJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x63906C0", Offset = "0x638FAC0", VA = "0x1863906C0")]
	public static FIJIGBDFGGF AMLIMLEKAEJ(CMNAIECCOJF EBOAIIIFNFC, SocketAddress CEOBFBHIALE, long HDAKNEDFBPE, int FCHDAFNGEPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class CELNLGEAGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long KADHIPDOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte FPNLDJADMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int LFNJFJFEAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool NAFPOKEPFOK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6391050", Offset = "0x6390450", VA = "0x186391050")]
	private CELNLGEAGHB(long ELHFOEIMNFC, byte DHKDPBBHGHG, int EHPKDMLCMAE, bool CDKMPNBPDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6390F00", Offset = "0x6390300", VA = "0x186390F00")]
	public static CELNLGEAGHB MLDKPOJIBPC(FIJIGBDFGGF FLGFIKLLJDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6390D10", Offset = "0x6390110", VA = "0x186390D10")]
	public static FIJIGBDFGGF AMLIMLEKAEJ(long HDAKNEDFBPE, byte IDJEABFGJDC, int MMFMNMHGGAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6390E00", Offset = "0x6390200", VA = "0x186390E00")]
	public static FIJIGBDFGGF KMDAEDOMDAD(LFKBAMMDNBC HKHPFCFJEEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum BOLAECMCKDE
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HJDDJBKMBND
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPHEMIFMPAD(IPEndPoint MJCECKDHOPJ, IPEndPoint EJHHBFHANIP, string CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFCHNGGJJNO(IPEndPoint OIEPLEHLGEN, BOLAECMCKDE IFBDJLKPHIG, string CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JPILPOGHABP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MEIICMCJKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint MDAGEEIONGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint MNPOHMNABHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string GGAGHGDLNFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FFGHHAPOMPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint MMOENGEJMJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BOLAECMCKDE KBPCMAIENME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string GGAGHGDLNFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class GMAMGGOFPFI
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint LMBKHPJFCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string GGAGHGDLNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GMAMGGOFPFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class AMNMEKOICMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint LMBKHPJFCPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint DGPAJHMDBCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GGAGHGDLNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AMNMEKOICMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class IBJMIOBDHEM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GGAGHGDLNFL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BDEJCMEBOAF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x96F330", Offset = "0x96E730", VA = "0x18096F330")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8CE810", Offset = "0x8CDC10", VA = "0x1808CE810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IBJMIOBDHEM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EBAFGKIDJCA MLPANEFAJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<MEIICMCJKKP> JJJPIFNNMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<FFGHHAPOMPM> HBLMKGAGLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly DCKCPIENGMJ KNMIMJFEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CMNAIECCOJF ONCAOPCBDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JANOKOJJBKN PNDMOIMPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private HJDDJBKMBND JMNFLBCCJDM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int JAGLBEPAEAF = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HCEBINDMJHA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x639EA70", Offset = "0x639DE70", VA = "0x18639EA70")]
	internal JPILPOGHABP(EBAFGKIDJCA BLOFPCKNGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x639E770", Offset = "0x639DB70", VA = "0x18639E770")]
	internal void HDPPNMENDAI(IPEndPoint ICJEPKNHGIO, FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x30D99E0", Offset = "0x30D8DE0", VA = "0x1830D99E0")]
	private void LBMEHPBKLMC<T>(T FLGFIKLLJDI, IPEndPoint MGPMAFDHMLC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x639E8F0", Offset = "0x639DCF0", VA = "0x18639E8F0")]
	private void OPHEMIFMPAD(GMAMGGOFPFI AMJPCICDEHI, IPEndPoint ICJEPKNHGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x639E480", Offset = "0x639D880", VA = "0x18639E480")]
	private void BBCKLEJELPE(AMNMEKOICMA AMJPCICDEHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x639E5E0", Offset = "0x639D9E0", VA = "0x18639E5E0")]
	private void DALCOLEFHOM(IBJMIOBDHEM AMJPCICDEHI, IPEndPoint ICJEPKNHGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum FJPDPEPKCEO : byte
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
public enum OBNADDHJJJI : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LELEECMOKAL
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] FCFFHLKDBAE;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int GCKGGNADFGN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int CGNFEGEFMEK;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IJBDAMGJGDA : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x639C460", Offset = "0x639B860", VA = "0x18639C460")]
	public IJBDAMGJGDA(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FPBJNILOHIA : IJBDAMGJGDA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x639C460", Offset = "0x639B860", VA = "0x18639C460")]
	public FPBJNILOHIA(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OMEDGPAAPEB
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
public interface EAGLDAINMJM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKJKFPCCJKA(OMEDGPAAPEB AFOMFDJIHAP, string KKGBCJPEHGE, params object[] DCNLGGHAIIP);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PLPOPJPOEOI
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static EAGLDAINMJM MPPFBCGOJPP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object AGDPBPOJOLB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63A6CF0", Offset = "0x63A60F0", VA = "0x1863A6CF0")]
	private static void DDMNNGKHLMM(OMEDGPAAPEB GFAMIBBHNEP, string KKGBCJPEHGE, params object[] DCNLGGHAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x63A6FE0", Offset = "0x63A63E0", VA = "0x1863A6FE0")]
	internal static void KNGICPOLBBL(string KKGBCJPEHGE, params object[] DCNLGGHAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x63A6F80", Offset = "0x63A6380", VA = "0x1863A6F80")]
	internal static void HMCNPBJDNAJ(string KKGBCJPEHGE, params object[] DCNLGGHAIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x63A6F20", Offset = "0x63A6320", VA = "0x1863A6F20")]
	internal static void GGMGLKMFODF(string KKGBCJPEHGE, params object[] DCNLGGHAIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum KLOPABLBAKN
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HIGJMMHAKKI : DCKCPIENGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private FIJIGBDFGGF BIIKLCNAPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EBAFGKIDJCA NIPJBBAAGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly HEECOKJELEN ALEGKPIOFAJ;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x639E0B0", Offset = "0x639D4B0", VA = "0x18639E0B0")]
	internal HIGJMMHAKKI(EBAFGKIDJCA KCLPDCIIPCH, HEECOKJELEN GMKNLOPAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x639E010", Offset = "0x639D410", VA = "0x18639E010")]
	internal void HBOPJGMCKNM(FIJIGBDFGGF FLGFIKLLJDI, int GKJJHAEFGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x639DF90", Offset = "0x639D390", VA = "0x18639DF90")]
	internal void FCLDMJPKLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x639E080", Offset = "0x639D480", VA = "0x18639E080")]
	public void OOLHAFHJOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class HEECOKJELEN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum HHMOKEAKHKF
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
	public HEECOKJELEN MGJENIPPFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public HHMOKEAKHKF KBPCMAIENME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public LFKBAMMDNBC OPNHJFPOCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint MNPOHMNABHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object JKMPPLKDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int ENCLAGKPOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JHGLEFBLDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public KFFAEFLOFMJ EPFDHCBMPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public MMKEOAKLNLF OFHDLNDFDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public FJPDPEPKCEO GNKEIFGAFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte ENBNMFOCBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HIGJMMHAKKI BFKDPPGMCNH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x639D6D0", Offset = "0x639CAD0", VA = "0x18639D6D0")]
	public HEECOKJELEN(EBAFGKIDJCA KCLPDCIIPCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EBAFGKIDJCA : IEnumerable<LFKBAMMDNBC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class DCBBGAAPLGA : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6391EE0", Offset = "0x63912E0", VA = "0x186391EE0", Slot = "4")]
		public bool Equals(IPEndPoint KENGFOGLPKI, IPEndPoint IFGPABAHODO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E99ED0", Offset = "0x5E992D0", VA = "0x185E99ED0", Slot = "5")]
		public int GetHashCode(IPEndPoint NCHBKHMIMGJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DCBBGAAPLGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct NBHNAECNFBE : IEnumerator<LFKBAMMDNBC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly LFKBAMMDNBC LIODGFHMAFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private LFKBAMMDNBC JIHKMJFHJJB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LFKBAMMDNBC DLFFLJHEEDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9C07A0", Offset = "0x9BFBA0", VA = "0x1809C07A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9C07A0", Offset = "0x9BFBA0", VA = "0x1809C07A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x14E37D0", Offset = "0x14E2BD0", VA = "0x1814E37D0")]
		public NBHNAECNFBE(LFKBAMMDNBC AHHPGJOEACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x63A52F0", Offset = "0x63A46F0", VA = "0x1863A52F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x63A5340", Offset = "0x63A4740", VA = "0x1863A5340", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread CKNHCPOJKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool PMOFPFODLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent FJKBJKFKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<HEECOKJELEN> BFDFDPHEGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<HEECOKJELEN> COLKMBPHEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private HEECOKJELEN CIFNBNFJFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MMDKIEDAFIK CABBIHIJIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AJIJEAAOIJF ABHAGDLDNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly NJNKAIOLJAO HHDCCJKKEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JMHKKAOLBCP JIIOODKOBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, LFKBAMMDNBC> EJOLAMINKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, MMKEOAKLNLF> ADIMKJEDCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, GBBLDPCOJOJ> OLMHOCOAHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim NDGOMHJMNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private LFKBAMMDNBC FDPJDFHGNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int FCDFGKBMKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<LFKBAMMDNBC> JHPBCOLOGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private LFKBAMMDNBC[] KJKIJPKFDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly AFDHMBHIONO POLALPGLCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int NKFDJGOPCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> MMMPJAKKEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte BFNCNDNCGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object DDJFACLAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool ALIGDPGEBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool ENNDHEIOFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int MMENIAOCBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int JBKJKMLKKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int LOHNFIBFDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int KEGBJFHIGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool JNDNEDADKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FMNGODMFOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int AIOOENNNJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int LHJEEHNKMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int IMNCFKJGKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool HCEBINDMJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool IBOHGADCODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool PJNCMEJAHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool GCMCNEFDGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int IAGGKKGKPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int JGJNIBOAMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool MKENBLMGPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly MCFGKDIOKLL KCENEJGAKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool FKKBLFJPCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly JPILPOGHABP EAOBMFNHNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool MGMLHCFCOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public KLOPABLBAKN BGJJPOFLPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int FJHBHKPNEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool FCMLHEOLDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool BJEPILLCBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool BLKDIMABBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool DHGGDDCHEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private FIJIGBDFGGF IENFGKDJIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int FIFPNHDODCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object ECIJGMGDPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private FIJIGBDFGGF KEDFNFPKEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int CJNGEKDLCHG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int HEPKABINPPG = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int HJNDNLCALCI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IIADFAKHHJK JLMDAOGDDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private IIADFAKHHJK MDCNNIOFFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread JHJMCLCAFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread KGNPKJBAALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint ANINJDAMANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint DMDOHFMLIHC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] DIBADKNDAHK;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] DCOHBPNPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NBCLELCBMDP, IPEndPoint> MCNHHDPMKLO;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress ACKIGJFIHJH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool LCOEJHGHLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int NECBAPBKPEI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool INNMLDMNAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x106F030", Offset = "0x106E430", VA = "0x18106F030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x106FCD0", Offset = "0x106F0D0", VA = "0x18106FCD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NHLLJHDHKII
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1A48590", Offset = "0x1A47990", VA = "0x181A48590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CB1DD0", Offset = "0x1CB11D0", VA = "0x181CB1DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte HCKJEEMCGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x92C6C0", Offset = "0x92BAC0", VA = "0x18092C6C0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int IKPPGAPELGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6394BE0", Offset = "0x6393FE0", VA = "0x186394BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short CCKKDALBIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63933E0", Offset = "0x63927E0", VA = "0x1863933E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6396010", Offset = "0x6395410", VA = "0x186396010")]
	public void IEFLEPODPAA(IPEndPoint GLFHKDBKIDM, byte[] LDCKBFKFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6393D30", Offset = "0x6393130", VA = "0x186393D30")]
	public void ELIJNNIJCMD(IPEndPoint GLFHKDBKIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6397CC0", Offset = "0x63970C0", VA = "0x186397CC0")]
	private bool LFNKFLDDFEC(IPEndPoint GLFHKDBKIDM, [Out] LFKBAMMDNBC HKHPFCFJEEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6393EC0", Offset = "0x63932C0", VA = "0x186393EC0")]
	private void FHCFIHJPDHN(LFKBAMMDNBC HKHPFCFJEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6397B00", Offset = "0x6396F00", VA = "0x186397B00")]
	private void JFFBKHJHOIG(LFKBAMMDNBC HKHPFCFJEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6397E50", Offset = "0x6397250", VA = "0x186397E50")]
	private void LJJEGLHNJPO(LFKBAMMDNBC HKHPFCFJEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x639A010", Offset = "0x6399410", VA = "0x18639A010")]
	public EBAFGKIDJCA(MMDKIEDAFIK IMHIIMJFBJP, [Optional] AFDHMBHIONO KIJNNDELKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6393820", Offset = "0x6392C20", VA = "0x186393820")]
	internal void DAEIGKHPKHB(LFKBAMMDNBC BPKJHKCMKJG, int KHJHMFEAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6393870", Offset = "0x6392C70", VA = "0x186393870")]
	internal void DKJPHDJJOMN(LFKBAMMDNBC BPKJHKCMKJG, object OEJDLHPPLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6392BB0", Offset = "0x6391FB0", VA = "0x186392BB0")]
	internal void BPLKFEODGEG(LFKBAMMDNBC HKHPFCFJEEC, KFFAEFLOFMJ OCIFOIBHPJJ, SocketError FGJDCNAEFMF, FIJIGBDFGGF IAAPABJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6392C70", Offset = "0x6392070", VA = "0x186392C70")]
	private void CFPJCHIHHNP(LFKBAMMDNBC HKHPFCFJEEC, KFFAEFLOFMJ OCIFOIBHPJJ, SocketError FGJDCNAEFMF, bool MKNFMGNFODH, byte[] JGCOLLOOLHL, int JJJPINFOLNN, int ABPDJOGPHFP, FIJIGBDFGGF IAAPABJLNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6394C00", Offset = "0x6394000", VA = "0x186394C00")]
	private void GMKAFBFFAFC(HEECOKJELEN.HHMOKEAKHKF IFBDJLKPHIG, [Optional] LFKBAMMDNBC HKHPFCFJEEC, [Optional] IPEndPoint EJHHBFHANIP, SocketError MMEACNFBMEM = SocketError.Success, int KHJHMFEAGAJ = 0, KFFAEFLOFMJ NEOMIGDEFCP = KFFAEFLOFMJ.ConnectionFailed, [Optional] MMKEOAKLNLF DHKKCKHPCNO, FJPDPEPKCEO OGKJKGLPGFJ = FJPDPEPKCEO.Unreliable, byte NLPLCCLPCED = 0, [Optional] FIJIGBDFGGF MCNHLPINDIE, [Optional] object OEJDLHPPLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6395240", Offset = "0x6394640", VA = "0x186395240")]
	private void HJIJGKEKNEC(HEECOKJELEN GMKNLOPAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x63999E0", Offset = "0x6398DE0", VA = "0x1863999E0")]
	internal void NNJELINLHHD(HEECOKJELEN GMKNLOPAONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6399AF0", Offset = "0x6398EF0", VA = "0x186399AF0")]
	private void OEDNPMLFAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63996C0", Offset = "0x6398AC0", VA = "0x1863996C0")]
	private void NIEGMEICIPM(int LIHLJECAIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63959F0", Offset = "0x6394DF0", VA = "0x1863959F0")]
	internal LFKBAMMDNBC HNAILLGIKFJ(MMKEOAKLNLF BLIDGDGMCAP, byte[] DAFAAPJLDCJ, int JJJPINFOLNN, int OIPEPMJNPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6396230", Offset = "0x6395630", VA = "0x186396230")]
	private int IFABDALDDIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6396AD0", Offset = "0x6395ED0", VA = "0x186396AD0")]
	private void IMNFLCNKJNK(IPEndPoint EJHHBFHANIP, LFKBAMMDNBC HINBJPBOFEJ, ADMGHAMAECK DGELNAKNCOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6398300", Offset = "0x6397700", VA = "0x186398300")]
	private void MIKCEPLJGKD(FIJIGBDFGGF FLGFIKLLJDI, IPEndPoint EJHHBFHANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6394900", Offset = "0x6393D00", VA = "0x186394900")]
	internal void GGHGJLDHMPM(FIJIGBDFGGF FLGFIKLLJDI, FJPDPEPKCEO AJDONECJFID, byte NLPLCCLPCED, int GKJJHAEFGAB, LFKBAMMDNBC BPKJHKCMKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x63977D0", Offset = "0x6396BD0", VA = "0x1863977D0")]
	public bool INEAJMHODFF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6396F80", Offset = "0x6396380", VA = "0x186396F80")]
	public bool INEAJMHODFF(IPAddress PFBKCCKLLOB, IPAddress BPKDBMHLABH, int KFFGLKDIHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6397750", Offset = "0x6396B50", VA = "0x186397750")]
	public bool INEAJMHODFF(int KFFGLKDIHDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6397840", Offset = "0x6396C40", VA = "0x186397840")]
	public void JAGDDFPBFIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x63945D0", Offset = "0x63939D0", VA = "0x1863945D0")]
	public LFKBAMMDNBC FLCDEJJJPJC(string FIKHCKAHJLC, int KFFGLKDIHDK, string LDCKBFKFIKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x63946B0", Offset = "0x6393AB0", VA = "0x1863946B0")]
	public LFKBAMMDNBC FLCDEJJJPJC(string FIKHCKAHJLC, int KFFGLKDIHDK, CMNAIECCOJF NOHIJOLELJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6394200", Offset = "0x6393600", VA = "0x186394200")]
	public LFKBAMMDNBC FLCDEJJJPJC(IPEndPoint MGPMAFDHMLC, CMNAIECCOJF NOHIJOLELJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6393080", Offset = "0x6392480", VA = "0x186393080")]
	public void CICEJJBDDFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6393090", Offset = "0x6392490", VA = "0x186393090")]
	public void CICEJJBDDFM(bool ANMKCDKKLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6397B50", Offset = "0x6396F50", VA = "0x186397B50")]
	public void JNPAOIEPPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6397C00", Offset = "0x6397000", VA = "0x186397C00")]
	public void JNPAOIEPPGE(byte[] JGCOLLOOLHL, int JJJPINFOLNN, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6392C30", Offset = "0x6392030", VA = "0x186392C30")]
	public void CFPJCHIHHNP(LFKBAMMDNBC HKHPFCFJEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6392BF0", Offset = "0x6391FF0", VA = "0x186392BF0")]
	public void CFPJCHIHHNP(LFKBAMMDNBC HKHPFCFJEEC, byte[] JGCOLLOOLHL, int JJJPINFOLNN, int ABPDJOGPHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6399E30", Offset = "0x6399230", VA = "0x186399E30", Slot = "4")]
	private IEnumerator<LFKBAMMDNBC> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6399EC0", Offset = "0x63992C0", VA = "0x186399EC0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x63962B0", Offset = "0x63956B0", VA = "0x1863962B0")]
	private FIJIGBDFGGF IFCHEKJMOEL(INFFJBFGDIO LKGPHBHEBBE, int BGDDCGNLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6396390", Offset = "0x6395790", VA = "0x186396390")]
	private FIJIGBDFGGF IFCHEKJMOEL(INFFJBFGDIO LKGPHBHEBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x63980C0", Offset = "0x63974C0", VA = "0x1863980C0")]
	internal FIJIGBDFGGF LMGLBGODLDO(int BGDDCGNLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6394FE0", Offset = "0x63943E0", VA = "0x186394FE0")]
	internal void HBIACOCFIDF(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6399F50", Offset = "0x6399350", VA = "0x186399F50")]
	static EBAFGKIDJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x106F030", Offset = "0x106E430", VA = "0x18106F030")]
	private bool LEGHPMGIPEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63979F0", Offset = "0x6396DF0", VA = "0x1863979F0")]
	private void JEFFABINAEK(IPEndPoint BBADCPEOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6397D50", Offset = "0x6397150", VA = "0x186397D50")]
	private void LIAHOFDOKBJ(IPEndPoint BBADCPEOBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6393B80", Offset = "0x6392F80", VA = "0x186393B80")]
	private bool EGLEOOIFPHN(SocketException DIPLOOHMPFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63938C0", Offset = "0x6392CC0", VA = "0x1863938C0")]
	private void DPDIEMCOOGI(IIADFAKHHJK BLOFPCKNGFH, EndPoint HPLHNKOOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63934A0", Offset = "0x63928A0", VA = "0x1863934A0")]
	private void CNLGAJPDAGL(object MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6396FA0", Offset = "0x63963A0", VA = "0x186396FA0")]
	public bool INEAJMHODFF(IPAddress PFBKCCKLLOB, IPAddress BPKDBMHLABH, int KFFGLKDIHDK, bool LOLNFDLKIPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x63941A0", Offset = "0x63935A0", VA = "0x1863941A0")]
	internal int FJFIGKAOOHF(FIJIGBDFGGF FLGFIKLLJDI, IPEndPoint EJHHBFHANIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6396470", Offset = "0x6395870", VA = "0x186396470")]
	internal int IFDPKIJDBGB(FIJIGBDFGGF FLGFIKLLJDI, IPEndPoint EJHHBFHANIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x63964B0", Offset = "0x63958B0", VA = "0x1863964B0")]
	internal int IFDPKIJDBGB(byte[] LNICHECHJFC, int JJJPINFOLNN, int OIPEPMJNPGM, IPEndPoint EJHHBFHANIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6394790", Offset = "0x6393B90", VA = "0x186394790")]
	internal void GFKHPANFAGO(bool JNMNCIDOGJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum INFFJBFGDIO : byte
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
internal sealed class FIJIGBDFGGF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int PCAIDAEGHCG;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] KAOFILIHICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] BKIJMDMGNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int EMINOKGEAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object JKMPPLKDBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public FIJIGBDFGGF MGJENIPPFDL;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public INFFJBFGDIO MHDHCLENANM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x639BEB0", Offset = "0x639B2B0", VA = "0x18639BEB0")]
		get
		{
			return default(INFFJBFGDIO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x639BD10", Offset = "0x639B110", VA = "0x18639BD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte FPNLDJADMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x639BCE0", Offset = "0x639B0E0", VA = "0x18639BCE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x639BBE0", Offset = "0x639AFE0", VA = "0x18639BBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort JNGPIDDFABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x639BC20", Offset = "0x639B020", VA = "0x18639BC20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x639BA00", Offset = "0x639AE00", VA = "0x18639BA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MJAMKJFDPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x639BC80", Offset = "0x639B080", VA = "0x18639BC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte NNDEDKOAIND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x639BFC0", Offset = "0x639B3C0", VA = "0x18639BFC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x639BFF0", Offset = "0x639B3F0", VA = "0x18639BFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort LGHLCFKFOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x639BF20", Offset = "0x639B320", VA = "0x18639BF20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x639BEE0", Offset = "0x639B2E0", VA = "0x18639BEE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort FOJMAHOCILE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x639BE50", Offset = "0x639B250", VA = "0x18639BE50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x639BF80", Offset = "0x639B380", VA = "0x18639BF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JDPLDIKGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x639BA40", Offset = "0x639AE40", VA = "0x18639BA40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x639BBA0", Offset = "0x639AFA0", VA = "0x18639BBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x639C020", Offset = "0x639B420", VA = "0x18639C020")]
	static FIJIGBDFGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x639BCB0", Offset = "0x639B0B0", VA = "0x18639BCB0")]
	public void KHKCBNLJMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x639C2E0", Offset = "0x639B6E0", VA = "0x18639C2E0")]
	public FIJIGBDFGGF(int BGDDCGNLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x639C350", Offset = "0x639B750", VA = "0x18639C350")]
	public FIJIGBDFGGF(INFFJBFGDIO LKGPHBHEBBE, int BGDDCGNLDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x639BDE0", Offset = "0x639B1E0", VA = "0x18639BDE0")]
	public static int LOKGJONBIEC(INFFJBFGDIO LKGPHBHEBBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x639BD50", Offset = "0x639B150", VA = "0x18639BD50")]
	public int LOKGJONBIEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x639BAA0", Offset = "0x639AEA0", VA = "0x18639BAA0")]
	public bool COOJCHCEECM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum DCAHOALJEDI : byte
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
internal enum JDEGKHOEIKJ
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
internal enum GLLBMMNBKCB
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum NKHBOIPIHGI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LFKBAMMDNBC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class MICEDMDOMEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public FIJIGBDFGGF[] GABLNCKBJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NPDPPPPEOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int GEDFGCDOPBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte NNDEDKOAIND;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MICEDMDOMEN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void HFBBEEMOIMP(ulong HEGEGOFDHPM, int LAKCNFHMGME);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int POMLEHPMCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int EAECDCKKMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int FJFOMDIGJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double DOBIJOACAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int GMPKNMLIDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int CNDEBDCDCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int DBKMOKJODPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch LGAPGKMEEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KDHDMPMFKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long CMKJHHCALPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object LLCIFDBGMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal LFKBAMMDNBC ELCPPAMHKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal LFKBAMMDNBC HJJPFEIOLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<FIJIGBDFGGF> KANPDDGGLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<LNEODLDONAJ> HKEFNBGHPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly LNEODLDONAJ[] KKNPCKAHNNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int OOMMCJPBILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int ELGAELMDNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool KCFMIOHNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int KMPEIKJHPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int HKANHMMNBEI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int FFNDLODOENF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int GKFLOJOJMAA = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object IIGPGGLEOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int OOKGMMOINKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, MICEDMDOMEN> DBHLJGLOCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CIBMFLKIOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly FIJIGBDFGGF MKCNPHCFFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int CJAELBLDPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int NMIMFHFIPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint CCAONDAPBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int AGDLDAOFEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int IIHNCEEDBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long ELLCAIOEMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte EIPIBLHFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private DCAHOALJEDI PIFLHFELNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private FIJIGBDFGGF OOPJIHEAOKJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int OPLBNADHEHM = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int BDGDABPFEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FIJIGBDFGGF JHPCBLHCJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly FIJIGBDFGGF GDKDCEFADFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly FIJIGBDFGGF MAKHCCCBEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly FIJIGBDFGGF CLNBKEINLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private OBNADDHJJJI EIDMJDDEMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly EBAFGKIDJCA KLNMIAPGACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int ODDAFMAOMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object GCKCKCIIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly MCFGKDIOKLL KCENEJGAKPI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte HDCFIEKINJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xDFDC90", Offset = "0xDFD090", VA = "0x180DFDC90")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x639F140", Offset = "0x639E540", VA = "0x18639F140")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint GIAAOOLNAMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EBBD0", Offset = "0x9EAFD0", VA = "0x1809EBBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DCAHOALJEDI NEMNEAIKGHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x17514F0", Offset = "0x17508F0", VA = "0x1817514F0")]
		get
		{
			return default(DCAHOALJEDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long HOAHGMDCBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC60", Offset = "0x8CD060", VA = "0x1808CDC60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NOKONBNJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x10B1660", Offset = "0x10B0A60", VA = "0x1810B1660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19AC6A0", Offset = "0x19ABAA0", VA = "0x1819AC6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LMMJMPLEPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x639FC10", Offset = "0x639F010", VA = "0x18639FC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CPEIDCALJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D5ED0", Offset = "0x8D52D0", VA = "0x1808D5ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double JEFJAJBJCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5704200", Offset = "0x5703600", VA = "0x185704200")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event HFBBEEMOIMP LIJGFCINDOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x63A01D0", Offset = "0x639F5D0", VA = "0x1863A01D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x63A0120", Offset = "0x639F520", VA = "0x1863A0120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x63A2850", Offset = "0x63A1C50", VA = "0x1863A2850")]
	internal LFKBAMMDNBC(EBAFGKIDJCA OLIEJOPFLIA, IPEndPoint EJHHBFHANIP, int LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x63A0C00", Offset = "0x63A0000", VA = "0x1863A0C00")]
	internal void JFNOGGHIJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x63A0B90", Offset = "0x639FF90", VA = "0x1863A0B90")]
	internal void JAINGHDDNMA(IPEndPoint CKJIGODMKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x63A0940", Offset = "0x639FD40", VA = "0x1863A0940")]
	internal void ICBKAHGKKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x63A0C70", Offset = "0x63A0070", VA = "0x1863A0C70")]
	private void KBHHIADLHEB(int OGJEFPNFPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x639FF30", Offset = "0x639F330", VA = "0x18639FF30")]
	private void DLPPAAFPIBP(int MIHDBAOHCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x639EF90", Offset = "0x639E390", VA = "0x18639EF90")]
	private LNEODLDONAJ AGKJKBIGNFF(byte DEFGGFLHDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x63A2CA0", Offset = "0x63A20A0", VA = "0x1863A2CA0")]
	internal LFKBAMMDNBC(EBAFGKIDJCA OLIEJOPFLIA, IPEndPoint EJHHBFHANIP, int LPMIIFILJPI, byte IDJEABFGJDC, CMNAIECCOJF EBOAIIIFNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x63A2E30", Offset = "0x63A2230", VA = "0x1863A2E30")]
	internal LFKBAMMDNBC(EBAFGKIDJCA OLIEJOPFLIA, MMKEOAKLNLF BLIDGDGMCAP, int LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x63A13C0", Offset = "0x63A07C0", VA = "0x1863A13C0")]
	internal void NPPKDNBJJIB(ADMGHAMAECK EODFLPNOPDL, byte[] JGCOLLOOLHL, int JJJPINFOLNN, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x639F1F0", Offset = "0x639E5F0", VA = "0x18639F1F0")]
	internal bool BEPFLECPJMB(CELNLGEAGHB FLGFIKLLJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x63A1390", Offset = "0x63A0790", VA = "0x1863A1390")]
	public void LBMEHPBKLMC(byte[] JGCOLLOOLHL, int JJJPINFOLNN, int OIPEPMJNPGM, FJPDPEPKCEO MFKLHLPHDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x63A22F0", Offset = "0x63A16F0", VA = "0x1863A22F0")]
	private void PGFACBAOPCI(byte[] JGCOLLOOLHL, int JJJPINFOLNN, int OIPEPMJNPGM, byte NLPLCCLPCED, FJPDPEPKCEO OGKJKGLPGFJ, object OEJDLHPPLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x63A0C20", Offset = "0x63A0020", VA = "0x1863A0C20")]
	public void JOPAEBIHEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x639F270", Offset = "0x639E670", VA = "0x18639F270")]
	internal GLLBMMNBKCB BFJACOCOGCA(FIJIGBDFGGF FLGFIKLLJDI)
	{
		return default(GLLBMMNBKCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x63A00C0", Offset = "0x639F4C0", VA = "0x1863A00C0")]
	internal void FNFJFBBIGPH(LNEODLDONAJ HDHAFOPEDDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x639FC20", Offset = "0x639F020", VA = "0x18639FC20")]
	internal NKHBOIPIHGI DLLMHCHDBGI(byte[] JGCOLLOOLHL, int JJJPINFOLNN, int OIPEPMJNPGM, bool MKNFMGNFODH)
	{
		return default(NKHBOIPIHGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x63A0BC0", Offset = "0x639FFC0", VA = "0x1863A0BC0")]
	private void JFKKMEBHKPG(int GIIAEPINEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x63A1960", Offset = "0x63A0D60", VA = "0x1863A1960")]
	internal void PEJHENAJLKA(FJPDPEPKCEO AJDONECJFID, FIJIGBDFGGF AHHPGJOEACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x63A1410", Offset = "0x63A0810", VA = "0x1863A1410")]
	private void OOGLNKLMCJI(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x63A0D40", Offset = "0x63A0140", VA = "0x1863A0D40")]
	private void KCEFPOPLIPJ(int GNOIEGLKNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x63A09D0", Offset = "0x639FDD0", VA = "0x1863A09D0")]
	internal JDEGKHOEIKJ IMNFLCNKJNK(ADMGHAMAECK DGELNAKNCOD)
	{
		return default(JDEGKHOEIKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x63A0280", Offset = "0x639F680", VA = "0x1863A0280")]
	internal void HLDONNFIGHG(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x639FF70", Offset = "0x639F370", VA = "0x18639FF70")]
	private void FMCPBFNEEII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x639FA10", Offset = "0x639EE10", VA = "0x18639FA10")]
	internal void CPJNKGKPCJF(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x639F350", Offset = "0x639E750", VA = "0x18639F350")]
	internal void BFLBMILJDBK(int GNOIEGLKNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x63A10D0", Offset = "0x63A04D0", VA = "0x1863A10D0")]
	internal void KHALMNLNEGH(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MCFGKDIOKLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long PCMKGOHKNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long DKCHJDAJFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long KIAPKLNALFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HECHEJGBLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long PEPGFMBPFFB;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long FCJAGDFJLLN;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long DAJIACEEPEM;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long NBMNNPLGIHA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long EEMKGFDHLAC;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long JDAEMHJGCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long AGICIBIAHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long INKLJHCIIDI;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FOANKKHAJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x63A4C10", Offset = "0x63A4010", VA = "0x1863A4C10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KCBACGIBFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x63A49D0", Offset = "0x63A3DD0", VA = "0x1863A49D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long JICMMPKLJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x63A4C20", Offset = "0x63A4020", VA = "0x1863A4C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long GCCGICPOKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x63A4BA0", Offset = "0x63A3FA0", VA = "0x1863A4BA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long JLGPDPKBMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x63A4A80", Offset = "0x63A3E80", VA = "0x1863A4A80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IKNFKNKPKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x63A49C0", Offset = "0x63A3DC0", VA = "0x1863A49C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long OBOLEDJEJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x63A49E0", Offset = "0x63A3DE0", VA = "0x1863A49E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long MPLDGFLJMDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x63A4C30", Offset = "0x63A4030", VA = "0x1863A4C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private OBNADDHJJJI DBADEAMJMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x63A4910", Offset = "0x63A3D10", VA = "0x1863A4910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double HEJIKGPNCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x63A4BB0", Offset = "0x63A3FB0", VA = "0x1863A4BB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x63A4920", Offset = "0x63A3D20", VA = "0x1863A4920")]
	public void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x63A4A20", Offset = "0x63A3E20", VA = "0x1863A4A20")]
	public void FDCCNMJBJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x63A48C0", Offset = "0x63A3CC0", VA = "0x1863A48C0")]
	public void BIONMJBKPGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x63A4860", Offset = "0x63A3C60", VA = "0x1863A4860")]
	public void AOGDOPNMGPM(long DEDONEOLFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x63A4960", Offset = "0x63A3D60", VA = "0x1863A4960")]
	public void COLIFPFLCMG(long ONFOEGBFFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x63A4800", Offset = "0x63A3C00", VA = "0x1863A4800")]
	public void ALGDBOEBOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x63A4A90", Offset = "0x63A3E90", VA = "0x1863A4A90")]
	public void GAEIFNHNEEH(long PBBDCIAACLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x63A4C70", Offset = "0x63A4070", VA = "0x1863A4C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x63A4B00", Offset = "0x63A3F00", VA = "0x1863A4B00")]
	public void HCJMOABHMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public MCFGKDIOKLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OLDEELOODCL
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> NNCNKPLHJJP;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x63A6150", Offset = "0x63A5550", VA = "0x1863A6150")]
	public static IPEndPoint NAKNBNGGGIK(string GBMAODPODMG, int KFFGLKDIHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x63A5EC0", Offset = "0x63A52C0", VA = "0x1863A5EC0")]
	public static IPAddress GODNFKLEAFA(string GBMAODPODMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x63A6090", Offset = "0x63A5490", VA = "0x1863A6090")]
	public static IPAddress GODNFKLEAFA(string GBMAODPODMG, AddressFamily ODNIKBCJBGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x63A6120", Offset = "0x63A5520", VA = "0x1863A6120")]
	internal static int HDGDMKJKEBI(int CLDAFOOBOLA, int KGGCKPJBIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3217B90", Offset = "0x3216F90", VA = "0x183217B90")]
	internal static T[] ABIDDHBFEEL<T>(int ABPDJOGPHFP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class GDFOIOKIAIA : LNEODLDONAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BJHHLGJPOON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private FIJIGBDFGGF BIIKLCNAPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long FBHEHGFFCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool AMOJABMAEGB;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6390C70", Offset = "0x6390070", VA = "0x186390C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6390C50", Offset = "0x6390050", VA = "0x186390C50")]
		public void LKOIGPCFEMK(FIJIGBDFGGF FLGFIKLLJDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6390BE0", Offset = "0x638FFE0", VA = "0x186390BE0")]
		public bool GGJMKDLNLPN(long EKLCEMNAMKD, LFKBAMMDNBC HKHPFCFJEEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6390B90", Offset = "0x638FF90", VA = "0x186390B90")]
		public bool CDMKLDGEKPL(LFKBAMMDNBC HKHPFCFJEEC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly FIJIGBDFGGF PKHOLMJGKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly BJHHLGJPOON[] LIPEEFLEBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly FIJIGBDFGGF[] HPPMPNMGCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] BMCMFFPIEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int PFLIBCPJEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int PBHJPEDLFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int HJAGDPHMLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int CDPHGJKONJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool BPAPANGLMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly FJPDPEPKCEO JFJNFLHDCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool EDDLLCNBAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int FAGNONAFGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte LMPDAMCBHJI;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x639D460", Offset = "0x639C860", VA = "0x18639D460")]
	public GDFOIOKIAIA(LFKBAMMDNBC HKHPFCFJEEC, bool KPCCFNFPPIK, byte LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x639C570", Offset = "0x639B970", VA = "0x18639C570")]
	private void CJJCCOAKBOK(FIJIGBDFGGF FLGFIKLLJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x639CF90", Offset = "0x639C390", VA = "0x18639CF90", Slot = "4")]
	protected override bool JIEIOGNGMKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x639C930", Offset = "0x639BD30", VA = "0x18639C930", Slot = "5")]
	public override bool HLDONNFIGHG(FIJIGBDFGGF FLGFIKLLJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OPFJJJNKAJC : LNEODLDONAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int MIFADPJNBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort PBHJPEDLFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool BLLGAAPHMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private FIJIGBDFGGF BILGHGGMNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly FIJIGBDFGGF BFKBBBBKBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool DCNCLADBOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte LMPDAMCBHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long GHBLONKIMNK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x63A6BD0", Offset = "0x63A5FD0", VA = "0x1863A6BD0")]
	public OPFJJJNKAJC(LFKBAMMDNBC HKHPFCFJEEC, bool POIAJLMODHI, byte LPMIIFILJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x63A6710", Offset = "0x63A5B10", VA = "0x1863A6710", Slot = "4")]
	protected override bool JIEIOGNGMKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x63A6430", Offset = "0x63A5830", VA = "0x1863A6430", Slot = "5")]
	public override bool HLDONNFIGHG(FIJIGBDFGGF FLGFIKLLJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class ACEEJOCGAKL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct BIDHCKKMNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong FCCCMDFOJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double OPOGIPAEEBJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OEONKGHNDJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int CNGEIOPOFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float IAOPBGNIBJB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x638FF80", Offset = "0x638F380", VA = "0x18638FF80")]
	private static void PKPNLMNNAPI(byte[] CELIBNPACII, int LHBPAMEKCBO, ulong JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6390560", Offset = "0x638F960", VA = "0x186390560")]
	private static void PKPNLMNNAPI(byte[] CELIBNPACII, int LHBPAMEKCBO, int JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x63905F0", Offset = "0x638F9F0", VA = "0x1863905F0")]
	public static void PKPNLMNNAPI(byte[] CELIBNPACII, int LHBPAMEKCBO, short JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x63905D0", Offset = "0x638F9D0", VA = "0x1863905D0")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, double HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6390640", Offset = "0x638FA40", VA = "0x186390640")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x63905F0", Offset = "0x638F9F0", VA = "0x1863905F0")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, short HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x63905F0", Offset = "0x638F9F0", VA = "0x1863905F0")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, ushort HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6390560", Offset = "0x638F960", VA = "0x186390560")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6390560", Offset = "0x638F960", VA = "0x186390560")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, uint HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6390630", Offset = "0x638FA30", VA = "0x186390630")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6390630", Offset = "0x638FA30", VA = "0x186390630")]
	public static void BMLDLFIFBKL(byte[] MDABPMPEKPN, int GDCLLKFPEAF, ulong HCPAOILCJCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DCKCPIENGMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] OCPNIGJCMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int EEDADFLMBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int CCNHGJOPEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int KPPDKPMKHOB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] BKIJMDMGNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FFJCHKBPJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DAFKLAJCEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6392760", Offset = "0x6391B60", VA = "0x186392760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OGIFIEIHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x222D9C0", Offset = "0x222CDC0", VA = "0x18222D9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int FKKMGBFAAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6392520", Offset = "0x6391920", VA = "0x186392520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6392420", Offset = "0x6391820", VA = "0x186392420")]
	public void HBOPJGMCKNM(byte[] MAPPNBHJLPD, int LHBPAMEKCBO, int BDOLIEHFICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public DCKCPIENGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6392B50", Offset = "0x6391F50", VA = "0x186392B50")]
	public DCKCPIENGMJ(byte[] MAPPNBHJLPD, int LHBPAMEKCBO, int BDOLIEHFICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6391F50", Offset = "0x6391350", VA = "0x186391F50")]
	public IPEndPoint AJCPGDODNNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6392280", Offset = "0x6391680", VA = "0x186392280")]
	public byte FLIKOIELIHC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6392280", Offset = "0x6391680", VA = "0x186392280")]
	public sbyte OGOFEOMKCBL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2E92490", Offset = "0x2E91890", VA = "0x182E92490")]
	public T[] INFKICFHMDK<T>(ushort BGDDCGNLDBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x63927B0", Offset = "0x6391BB0", VA = "0x1863927B0")]
	public bool[] MCBKBDGNBNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6392100", Offset = "0x6391500", VA = "0x186392100")]
	public ushort[] BNIDFAOBNJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6392770", Offset = "0x6391B70", VA = "0x186392770")]
	public short[] LNJIKPEAPNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x63922C0", Offset = "0x63916C0", VA = "0x1863922C0")]
	public int[] GIDIMMFKPIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x63927F0", Offset = "0x6391BF0", VA = "0x1863927F0")]
	public uint[] MMONJPOCEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x63924A0", Offset = "0x63918A0", VA = "0x1863924A0")]
	public float[] HJBKJCFMNDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x63924E0", Offset = "0x63918E0", VA = "0x1863924E0")]
	public double[] HKKKDDGFHBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6392460", Offset = "0x6391860", VA = "0x186392460")]
	public long[] HHJIKAEOIFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6392160", Offset = "0x6391560", VA = "0x186392160")]
	public ulong[] DHJEJOMEKEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6392530", Offset = "0x6391930", VA = "0x186392530")]
	public string[] IALNCPEMOOJ(int AEANMBILKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x63928E0", Offset = "0x6391CE0", VA = "0x1863928E0")]
	public bool PEKDIBBBOKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6392300", Offset = "0x6391700", VA = "0x186392300")]
	public char GLAFDEAAIEO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6392300", Offset = "0x6391700", VA = "0x186392300")]
	public ushort PNHECDBLDCF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x63926F0", Offset = "0x6391AF0", VA = "0x1863926F0")]
	public short KLONLMCOBIN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6392830", Offset = "0x6391C30", VA = "0x186392830")]
	public long NHBKLJHOJLO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x63921A0", Offset = "0x63915A0", VA = "0x1863921A0")]
	public ulong EAEIAMLIBJN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6392020", Offset = "0x6391420", VA = "0x186392020")]
	public int BHKCGDDIEFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6392210", Offset = "0x6391610", VA = "0x186392210")]
	public uint ENBDGCOAFLI()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6392680", Offset = "0x6391A80", VA = "0x186392680")]
	public float KEBNFLGMHBM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6392090", Offset = "0x6391490", VA = "0x186392090")]
	public double BMJGPPOELMO()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6392920", Offset = "0x6391D20", VA = "0x186392920")]
	public string PHALFBDHBII(int HOCAGGHKPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x63923B0", Offset = "0x63917B0", VA = "0x1863923B0")]
	public ArraySegment<byte> GPCDKNKMKIK(int ABPDJOGPHFP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6392370", Offset = "0x6391770", VA = "0x186392370")]
	public sbyte[] GLNINNEAGFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x63928A0", Offset = "0x6391CA0", VA = "0x1863928A0")]
	public byte[] NLIFDHFFKIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6392140", Offset = "0x6391540", VA = "0x186392140")]
	public void CDMKLDGEKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CMNAIECCOJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] OCPNIGJCMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int EEDADFLMBMP;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int ILNKLKNEDIM = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool CDAOBIDHBNI;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding NAHKIAIJCAJ;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int MOAPBLHFFBD = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] FCBPMKJAHLI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GLBGLIBCAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int EPMKILCCCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8C93C0", Offset = "0x8C87C0", VA = "0x1808C93C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6391DC0", Offset = "0x63911C0", VA = "0x186391DC0")]
	public CMNAIECCOJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6391E40", Offset = "0x6391240", VA = "0x186391E40")]
	public CMNAIECCOJF(bool DAPOHKPPHDB, int ICKKGHMHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6391880", Offset = "0x6390C80", VA = "0x186391880")]
	public static CMNAIECCOJF LCMHMJPDJLD(string HCPAOILCJCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6391180", Offset = "0x6390580", VA = "0x186391180")]
	public void AODBDGBDMPI(int DOPCGIEFEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x22A6D20", Offset = "0x22A6120", VA = "0x1822A6D20")]
	public void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6391410", Offset = "0x6390810", VA = "0x186391410")]
	public void GFIAIBIJEFC(float HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6391280", Offset = "0x6390680", VA = "0x186391280")]
	public void GFIAIBIJEFC(double HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6391580", Offset = "0x6390980", VA = "0x186391580")]
	public void GFIAIBIJEFC(long HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6391580", Offset = "0x6390980", VA = "0x186391580")]
	public void GFIAIBIJEFC(ulong HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x63915D0", Offset = "0x63909D0", VA = "0x1863915D0")]
	public void GFIAIBIJEFC(int HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x63915D0", Offset = "0x63909D0", VA = "0x1863915D0")]
	public void GFIAIBIJEFC(uint HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6391330", Offset = "0x6390730", VA = "0x186391330")]
	public void GFIAIBIJEFC(char HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6391330", Offset = "0x6390730", VA = "0x186391330")]
	public void GFIAIBIJEFC(ushort HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6391330", Offset = "0x6390730", VA = "0x186391330")]
	public void GFIAIBIJEFC(short HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6391220", Offset = "0x6390620", VA = "0x186391220")]
	public void GFIAIBIJEFC(sbyte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6391220", Offset = "0x6390620", VA = "0x186391220")]
	public void GFIAIBIJEFC(byte HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x63913A0", Offset = "0x63907A0", VA = "0x1863913A0")]
	public void GFIAIBIJEFC(byte[] JGCOLLOOLHL, int LHBPAMEKCBO, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x63910A0", Offset = "0x63904A0", VA = "0x1863910A0")]
	public void OHOKJAAMKEC(sbyte[] JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x63910A0", Offset = "0x63904A0", VA = "0x1863910A0")]
	public void AEIGMGDKIJM(byte[] JGCOLLOOLHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x63912D0", Offset = "0x63906D0", VA = "0x1863912D0")]
	public void GFIAIBIJEFC(bool HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6391B90", Offset = "0x6390F90", VA = "0x186391B90")]
	public void LIDJFJOAGGO(Array GNNFCDHIMHF, int NNCIDEJOCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x63919D0", Offset = "0x6390DD0", VA = "0x1863919D0")]
	public void LIDJFJOAGGO(float[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6391AB0", Offset = "0x6390EB0", VA = "0x186391AB0")]
	public void LIDJFJOAGGO(double[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6391AB0", Offset = "0x6390EB0", VA = "0x186391AB0")]
	public void LIDJFJOAGGO(long[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6391AB0", Offset = "0x6390EB0", VA = "0x186391AB0")]
	public void LIDJFJOAGGO(ulong[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x63919D0", Offset = "0x6390DD0", VA = "0x1863919D0")]
	public void LIDJFJOAGGO(int[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x63919D0", Offset = "0x6390DD0", VA = "0x1863919D0")]
	public void LIDJFJOAGGO(uint[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x63918F0", Offset = "0x6390CF0", VA = "0x1863918F0")]
	public void LIDJFJOAGGO(ushort[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x63918F0", Offset = "0x6390CF0", VA = "0x1863918F0")]
	public void LIDJFJOAGGO(short[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x63910A0", Offset = "0x63904A0", VA = "0x1863910A0")]
	public void LIDJFJOAGGO(bool[] HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6391C70", Offset = "0x6391070", VA = "0x186391C70")]
	public void LIDJFJOAGGO(string[] HCPAOILCJCB, int HNHIGELCGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x63914B0", Offset = "0x63908B0", VA = "0x1863914B0")]
	public void GFIAIBIJEFC(IPEndPoint GLFHKDBKIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6391870", Offset = "0x6390C70", VA = "0x186391870")]
	public void GFIAIBIJEFC(string HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6391660", Offset = "0x6390A60", VA = "0x186391660")]
	public void GFIAIBIJEFC(string HCPAOILCJCB, int HOCAGGHKPKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JANOKOJJBKN
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class EBHIGCJBNIN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong ODDAFMAOMHH;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BF60", Offset = "0x3C7B360", VA = "0x183C7BF60")]
		static EBHIGCJBNIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void IFFCILCBCEM(DCKCPIENGMJ IEMPDPINHLH, object OEJDLHPPLOG);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class PBLCJPPBJDL<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public JANOKOJJBKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public PBLCJPPBJDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4C494B0", Offset = "0x4C488B0", VA = "0x184C494B0")]
		internal void KHHNICEJPBH(DCKCPIENGMJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class AJCIAGGKBLG<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JANOKOJJBKN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AJCIAGGKBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x41E0F20", Offset = "0x41E0320", VA = "0x1841E0F20")]
		internal void KHHNICEJPBH(DCKCPIENGMJ reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly GNODAIGNIGF JNGHDDOLMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, IFFCILCBCEM> LEDMAHPGOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly CMNAIECCOJF OCNBJBGDAJD;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x639E300", Offset = "0x639D700", VA = "0x18639E300")]
	public JANOKOJJBKN(int AEANMBILKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDC1B0", Offset = "0x2DDB5B0", VA = "0x182DDC1B0", Slot = "4")]
	protected virtual ulong KJEBDGFHAHO<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x639E1D0", Offset = "0x639D5D0", VA = "0x18639E1D0", Slot = "5")]
	protected virtual IFFCILCBCEM OOPEKLOHBMO(DCKCPIENGMJ IEMPDPINHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x30C9E50", Offset = "0x30C9250", VA = "0x1830C9E50", Slot = "6")]
	protected virtual void DOMFDGFOAJM<T>(CMNAIECCOJF EEKKIBDAGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x639E150", Offset = "0x639D550", VA = "0x18639E150")]
	public void HNFEHCINFEE(DCKCPIENGMJ IEMPDPINHLH, object OEJDLHPPLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x30C9DA0", Offset = "0x30C91A0", VA = "0x1830C9DA0")]
	public void BNJLCFOPFMP<T>(CMNAIECCOJF EEKKIBDAGAJ, T FLGFIKLLJDI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x639E100", Offset = "0x639D500", VA = "0x18639E100")]
	public void GNLMFJIEHGH(DCKCPIENGMJ IEMPDPINHLH, object OEJDLHPPLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x30CA080", Offset = "0x30C9480", VA = "0x1830CA080")]
	public void HDDFPNPPABK<T>(Action<T> GNBEBEGNFFC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x30C9EC0", Offset = "0x30C92C0", VA = "0x1830C9EC0")]
	public void HDDFPNPPABK<T, TUserData>(Action<T, TUserData> GNBEBEGNFFC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NABGPJEAPAH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x639C460", Offset = "0x639B860", VA = "0x18639C460")]
	public NABGPJEAPAH(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PHLCCGFIPJI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x63A6C90", Offset = "0x63A6090", VA = "0x1863A6C90")]
	public PHLCCGFIPJI(string LNICHECHJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class GNODAIGNIGF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum MJCINCGOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class ODCJANNJCOE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MJCINCGOKEH KBPCMAIENME;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D820", Offset = "0x4B7CC20", VA = "0x184B7D820", Slot = "4")]
		public virtual void LKOIGPCFEMK(MethodInfo AGLFMIHKKLN, MethodInfo DBLHBAAFMIN, MJCINCGOKEH IFBDJLKPHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MJNMKAMAADF(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void NNBNOPNFPHB(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		protected ODCJANNJCOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CGPKIBBGGDB<TClass, TProperty> : ODCJANNJCOE<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> FOLBJEJGNBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> GKKIOFNHPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> LHALGGGFKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> FEMKJENDLFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> CDNJLPKILCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> IPMEHHHECLK;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x581DC90", Offset = "0x581D090", VA = "0x18581DC90", Slot = "7")]
		public override void EPAIEABNCLL(TClass CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x581CB10", Offset = "0x581BF10", VA = "0x18581CB10", Slot = "8")]
		public override void CKNABONGJEK(TClass CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x5823240", Offset = "0x5822640", VA = "0x185823240", Slot = "9")]
		public override void MJNMKAMAADF(TClass CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5823F60", Offset = "0x5823360", VA = "0x185823F60", Slot = "10")]
		public override void NNBNOPNFPHB(TClass CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5824200", Offset = "0x5823600", VA = "0x185824200")]
		protected TProperty[] NOODPJNIDHE(TClass CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x581DF30", Offset = "0x581D330", VA = "0x18581DF30")]
		protected TProperty[] FFNODNCKJBI(TClass CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5821400", Offset = "0x5820800", VA = "0x185821400", Slot = "4")]
		public override void LKOIGPCFEMK(MethodInfo AGLFMIHKKLN, MethodInfo DBLHBAAFMIN, MJCINCGOKEH IFBDJLKPHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x40B3860", Offset = "0x40B2C60", VA = "0x1840B3860")]
		protected CGPKIBBGGDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class JAPMGFDCBCB<TClass, TProperty> : CGPKIBBGGDB<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void GCOILDKMEHN(DCKCPIENGMJ NOMFBHAJODM, [Out] TProperty GGNKBGDBPFH);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void AKAHINLDFMB(CMNAIECCOJF MLOFEILNACF, TProperty GGNKBGDBPFH);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x45716E0", Offset = "0x4570AE0", VA = "0x1845716E0", Slot = "5")]
		public override void FDDODJDFILN(TClass CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x45712C0", Offset = "0x45706C0", VA = "0x1845712C0", Slot = "6")]
		public override void BNJLCFOPFMP(TClass CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4571560", Offset = "0x4570960", VA = "0x184571560", Slot = "7")]
		public override void EPAIEABNCLL(TClass CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45714A0", Offset = "0x45708A0", VA = "0x1845714A0", Slot = "8")]
		public override void CKNABONGJEK(TClass CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x43D82F0", Offset = "0x43D76F0", VA = "0x1843D82F0")]
		protected JAPMGFDCBCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class ECPJOHLFLOK<T> : CGPKIBBGGDB<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB91A0", Offset = "0x3CB85A0", VA = "0x183CB91A0", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9040", Offset = "0x3CB8440", VA = "0x183CB9040", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9120", Offset = "0x3CB8520", VA = "0x183CB9120", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB90B0", Offset = "0x3CB84B0", VA = "0x183CB90B0", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public ECPJOHLFLOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class PLMNKAPKBDA<T> : CGPKIBBGGDB<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4C748F0", Offset = "0x4C73CF0", VA = "0x184C748F0", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9040", Offset = "0x3CB8440", VA = "0x183CB9040", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4C74870", Offset = "0x4C73C70", VA = "0x184C74870", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3CB90B0", Offset = "0x3CB84B0", VA = "0x183CB90B0", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public PLMNKAPKBDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KCJKMPKGMPD<T> : CGPKIBBGGDB<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x465DED0", Offset = "0x465D2D0", VA = "0x18465DED0", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x465DD70", Offset = "0x465D170", VA = "0x18465DD70", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x465DE50", Offset = "0x465D250", VA = "0x18465DE50", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x465DDE0", Offset = "0x465D1E0", VA = "0x18465DDE0", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public KCJKMPKGMPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class DOEAKBDELCF<T> : CGPKIBBGGDB<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B090", Offset = "0x5E8A490", VA = "0x185E8B090", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x465DD70", Offset = "0x465D170", VA = "0x18465DD70", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B010", Offset = "0x5E8A410", VA = "0x185E8B010", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x465DDE0", Offset = "0x465D1E0", VA = "0x18465DDE0", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public DOEAKBDELCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MNFAGANCJMD<T> : CGPKIBBGGDB<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4A15BC0", Offset = "0x4A14FC0", VA = "0x184A15BC0", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x419F3F0", Offset = "0x419E7F0", VA = "0x18419F3F0", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4A15B40", Offset = "0x4A14F40", VA = "0x184A15B40", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x419F460", Offset = "0x419E860", VA = "0x18419F460", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public MNFAGANCJMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class GJGOFMGMDPI<T> : CGPKIBBGGDB<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x419F550", Offset = "0x419E950", VA = "0x18419F550", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x419F3F0", Offset = "0x419E7F0", VA = "0x18419F3F0", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x419F4D0", Offset = "0x419E8D0", VA = "0x18419F4D0", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x419F460", Offset = "0x419E860", VA = "0x18419F460", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public GJGOFMGMDPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class PHLICCAMGDN<T> : CGPKIBBGGDB<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4A82520", Offset = "0x4A81920", VA = "0x184A82520", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4A82430", Offset = "0x4A81830", VA = "0x184A82430", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4C658B0", Offset = "0x4C64CB0", VA = "0x184C658B0", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x407F890", Offset = "0x407EC90", VA = "0x18407F890", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public PHLICCAMGDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class NGEPNBBINBC<T> : CGPKIBBGGDB<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A82520", Offset = "0x4A81920", VA = "0x184A82520", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A82430", Offset = "0x4A81830", VA = "0x184A82430", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4A824A0", Offset = "0x4A818A0", VA = "0x184A824A0", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x407F890", Offset = "0x407EC90", VA = "0x18407F890", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public NGEPNBBINBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class IECMDIOKBDL<T> : CGPKIBBGGDB<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x43320D0", Offset = "0x43314D0", VA = "0x1843320D0", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4331FE0", Offset = "0x43313E0", VA = "0x184331FE0", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x4332050", Offset = "0x4331450", VA = "0x184332050", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CB90B0", Offset = "0x3CB84B0", VA = "0x183CB90B0", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public IECMDIOKBDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class LMMCONOEJBP<T> : CGPKIBBGGDB<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x47E4120", Offset = "0x47E3520", VA = "0x1847E4120", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x47E4030", Offset = "0x47E3430", VA = "0x1847E4030", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x47E40A0", Offset = "0x47E34A0", VA = "0x1847E40A0", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x419F460", Offset = "0x419E860", VA = "0x18419F460", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public LMMCONOEJBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class FHFCGFNIFEO<T> : CGPKIBBGGDB<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x407F980", Offset = "0x407ED80", VA = "0x18407F980", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x407F820", Offset = "0x407EC20", VA = "0x18407F820", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x407F900", Offset = "0x407ED00", VA = "0x18407F900", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x407F890", Offset = "0x407EC90", VA = "0x18407F890", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9220", Offset = "0x3CB8620", VA = "0x183CB9220")]
		public FHFCGFNIFEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class JBBMHAFDMAA<T> : JAPMGFDCBCB<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4571A00", Offset = "0x4570E00", VA = "0x184571A00", Slot = "12")]
		protected override void AKAHINLDFMB(CMNAIECCOJF MLOFEILNACF, char GGNKBGDBPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4571A30", Offset = "0x4570E30", VA = "0x184571A30", Slot = "11")]
		protected override void GCOILDKMEHN(DCKCPIENGMJ NOMFBHAJODM, [Out] char GGNKBGDBPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x40529C0", Offset = "0x4051DC0", VA = "0x1840529C0")]
		public JBBMHAFDMAA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CDMNDNHBMOP<T> : JAPMGFDCBCB<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x56FA870", Offset = "0x56F9C70", VA = "0x1856FA870", Slot = "12")]
		protected override void AKAHINLDFMB(CMNAIECCOJF MLOFEILNACF, IPEndPoint GGNKBGDBPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x56FA8A0", Offset = "0x56F9CA0", VA = "0x1856FA8A0", Slot = "11")]
		protected override void GCOILDKMEHN(DCKCPIENGMJ NOMFBHAJODM, [Out] IPEndPoint GGNKBGDBPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40529C0", Offset = "0x4051DC0", VA = "0x1840529C0")]
		public CDMNDNHBMOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class JLOKDHGGNIH<T> : CGPKIBBGGDB<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int OMGIMGKFOIA;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x45945D0", Offset = "0x45939D0", VA = "0x1845945D0")]
		public JLOKDHGGNIH(int HOCAGGHKPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4594550", Offset = "0x4593950", VA = "0x184594550", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x45943D0", Offset = "0x45937D0", VA = "0x1845943D0", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x45944D0", Offset = "0x45938D0", VA = "0x1845944D0", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4594450", Offset = "0x4593850", VA = "0x184594450", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class FNNEDMJOELL<T> : ODCJANNJCOE<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo MHDHCLENANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type HOBOEBKIFEB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x40AFF70", Offset = "0x40AF370", VA = "0x1840AFF70")]
		public FNNEDMJOELL(PropertyInfo LKGPHBHEBBE, Type MNLAMHDCPBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x40AFDF0", Offset = "0x40AF1F0", VA = "0x1840AFDF0", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x40AFC80", Offset = "0x40AF080", VA = "0x1840AFC80", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x40AFD90", Offset = "0x40AF190", VA = "0x1840AFD90", Slot = "7")]
		public override void EPAIEABNCLL(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x40AFD30", Offset = "0x40AF130", VA = "0x1840AFD30", Slot = "8")]
		public override void CKNABONGJEK(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x40AFEB0", Offset = "0x40AF2B0", VA = "0x1840AFEB0", Slot = "9")]
		public override void MJNMKAMAADF(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x40AFF10", Offset = "0x40AF310", VA = "0x1840AFF10", Slot = "10")]
		public override void NNBNOPNFPHB(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class GMHKOPPBMHO<T> : FNNEDMJOELL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C80330", Offset = "0x3C7F730", VA = "0x183C80330")]
		public GMHKOPPBMHO(PropertyInfo LKGPHBHEBBE, Type MNLAMHDCPBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x41A8C70", Offset = "0x41A8070", VA = "0x1841A8C70", Slot = "5")]
		public override void FDDODJDFILN(T CMCGAOJJBBI, DCKCPIENGMJ NOMFBHAJODM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x41A8BC0", Offset = "0x41A7FC0", VA = "0x1841A8BC0", Slot = "6")]
		public override void BNJLCFOPFMP(T CMCGAOJJBBI, CMNAIECCOJF MLOFEILNACF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class EHKDGGLJFMK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static EHKDGGLJFMK<T> ELEBKANKHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly ODCJANNJCOE<T>[] IBNELGJBIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int CBLMLJLMBMF;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6000", Offset = "0x3CC5400", VA = "0x183CC6000")]
		public EHKDGGLJFMK(List<ODCJANNJCOE<T>> PGAODIKMJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5EA0", Offset = "0x3CC52A0", VA = "0x183CC5EA0")]
		public void BNJLCFOPFMP(T NCHBKHMIMGJ, CMNAIECCOJF EEKKIBDAGAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5F50", Offset = "0x3CC5350", VA = "0x183CC5F50")]
		public void FDDODJDFILN(T NCHBKHMIMGJ, DCKCPIENGMJ IEMPDPINHLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class KFJGBGABEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract ODCJANNJCOE<T> AFFELPLAAIM<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private CMNAIECCOJF JJKJKBCOJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int KINNLDJGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, KFJGBGABEIF> CJKDOKHFKHC;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x639D630", Offset = "0x639CA30", VA = "0x18639D630")]
	public GNODAIGNIGF(int AEANMBILKIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x306EEA0", Offset = "0x306E2A0", VA = "0x18306EEA0")]
	private EHKDGGLJFMK<T> OPHHLNMAPJO<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x301EA10", Offset = "0x301DE10", VA = "0x18301EA10")]
	public void EMOBGIHOLPD<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x306EE00", Offset = "0x306E200", VA = "0x18306EE00")]
	public bool KBLFJIABLOP<T>(DCKCPIENGMJ IEMPDPINHLH, T MGPMAFDHMLC) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x306ED70", Offset = "0x306E170", VA = "0x18306ED70")]
	public void GKPJGNLGAKF<T>(CMNAIECCOJF EEKKIBDAGAJ, T NCHBKHMIMGJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EMFDBNEONHA
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime ENBGALLJOMN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] GMLNACNEMPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IMDBMAMEIMH PNDBELOKAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x639A6E0", Offset = "0x6399AE0", VA = "0x18639A6E0")]
		get
		{
			return default(IMDBMAMEIMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int IEOJKDPMOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x639AAA0", Offset = "0x6399EA0", VA = "0x18639AAA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x639B4C0", Offset = "0x639A8C0", VA = "0x18639B4C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IFMKEIJFDCL ODMFPAOABLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x639AD90", Offset = "0x639A190", VA = "0x18639AD90")]
		get
		{
			return default(IFMKEIJFDCL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x639A940", Offset = "0x6399D40", VA = "0x18639A940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int PLGOFCKKELF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x639B050", Offset = "0x639A450", VA = "0x18639B050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint NEJMOLCFEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x639A660", Offset = "0x6399A60", VA = "0x18639A660")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? JCIBBMGCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x639B250", Offset = "0x639A650", VA = "0x18639B250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? DILKFFANFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x639A710", Offset = "0x6399B10", VA = "0x18639A710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? DBDDOKCPIPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x639AB60", Offset = "0x6399F60", VA = "0x18639AB60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x639AE80", Offset = "0x639A280", VA = "0x18639AE80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? NMIGLBEGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBC10", Offset = "0x9EB010", VA = "0x1809EBC10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EBD20", Offset = "0x9EB120", VA = "0x1809EBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x639B630", Offset = "0x639AA30", VA = "0x18639B630")]
	public EMFDBNEONHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x639B950", Offset = "0x639AD50", VA = "0x18639B950")]
	internal EMFDBNEONHA(byte[] MDABPMPEKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x639A980", Offset = "0x6399D80", VA = "0x18639A980")]
	public static EMFDBNEONHA EOPHFAPKDMC(byte[] MDABPMPEKPN, DateTime ONNJHEIKDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x639AB90", Offset = "0x6399F90", VA = "0x18639AB90")]
	internal void IDAMCPMEJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x639B280", Offset = "0x639A680", VA = "0x18639B280")]
	private void MEGOFDHCCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x639A740", Offset = "0x6399B40", VA = "0x18639A740")]
	private DateTime? DBCBNFOFGJO(int LHBPAMEKCBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x639B080", Offset = "0x639A480", VA = "0x18639B080")]
	private void KFIBJMMDIOG(int LHBPAMEKCBO, DateTime? HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x639B500", Offset = "0x639A900", VA = "0x18639B500")]
	private ulong OBMCPCBDKDM(int LHBPAMEKCBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x639ADC0", Offset = "0x639A1C0", VA = "0x18639ADC0")]
	private void JLLGFFBIFDM(int LHBPAMEKCBO, ulong HCPAOILCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x639AAD0", Offset = "0x6399ED0", VA = "0x18639AAD0")]
	private uint GNOPMLPHEIJ(int LHBPAMEKCBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6263AA0", Offset = "0x6262EA0", VA = "0x186263AA0")]
	private static uint NIOIIEPCJGL(uint KENGFOGLPKI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x639B460", Offset = "0x639A860", VA = "0x18639B460")]
	private static ulong NIOIIEPCJGL(ulong KENGFOGLPKI)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum IMDBMAMEIMH
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
public enum IFMKEIJFDCL
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class GBBLDPCOJOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int CJIHGCAFDMJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int FBOKBMKHOMN = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int KGLANODCPMJ = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint NGBMCIIFPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int AMFDHFGKIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int COBNPOJFOBE;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PDOCGMLNKAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x639C470", Offset = "0x639B870", VA = "0x18639C470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x639C480", Offset = "0x639B880", VA = "0x18639C480")]
	public bool LBMEHPBKLMC(IIADFAKHHJK BLOFPCKNGFH, int HCHBEBADBKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class HHFCKNHPOLF : IIADFAKHHJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket BLOFPCKNGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly EBAFGKIDJCA OLIEJOPFLIA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short CCKKDALBIEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x639D790", Offset = "0x639CB90", VA = "0x18639D790", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DLHKEJLDHJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x639DEC0", Offset = "0x639D2C0", VA = "0x18639DEC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint MDAGEEIONGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x639D770", Offset = "0x639CB70", VA = "0x18639D770", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily PMGIAPJGILA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x478AD70", Offset = "0x478A170", VA = "0x18478AD70", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x639DEE0", Offset = "0x639D2E0", VA = "0x18639DEE0")]
	public HHFCKNHPOLF(AddressFamily ODNIKBCJBGG, EBAFGKIDJCA OLIEJOPFLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x639D7F0", Offset = "0x639CBF0", VA = "0x18639D7F0", Slot = "8")]
	public bool KEGNJBCNDGG(IPEndPoint GLFHKDBKIDM, KLOPABLBAKN DJMJCEEOIEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x639D7B0", Offset = "0x639CBB0", VA = "0x18639D7B0", Slot = "9")]
	public int CNPEANABKOO(byte[] CELIBNPACII, int LHBPAMEKCBO, int BGDDCGNLDBK, IPEndPoint EJHHBFHANIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x639DDB0", Offset = "0x639D1B0", VA = "0x18639DDB0", Slot = "10")]
	public int LCHNDNHJGMB(byte[] CELIBNPACII, EndPoint AJADNCBFDPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x639DEA0", Offset = "0x639D2A0", VA = "0x18639DEA0", Slot = "11")]
	public void NPDCEOAKOJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface IIADFAKHHJK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short CCKKDALBIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int DLHKEJLDHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint MDAGEEIONGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily PMGIAPJGILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KEGNJBCNDGG(IPEndPoint GLFHKDBKIDM, KLOPABLBAKN DJMJCEEOIEG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CNPEANABKOO(byte[] CELIBNPACII, int LHBPAMEKCBO, int BGDDCGNLDBK, IPEndPoint EJHHBFHANIP);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LCHNDNHJGMB(byte[] CELIBNPACII, EndPoint EJHHBFHANIP);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPDCEOAKOJF();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NBCLELCBMDP : IEquatable<NBCLELCBMDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long DNCOCEPJGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long FNFFEACMMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long HPNJAJFDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int HBAHEOEDNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int KCFANBGLOOJ;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x63A5200", Offset = "0x63A4600", VA = "0x1863A5200")]
	public NBCLELCBMDP(byte[] FIKHCKAHJLC, int NIHIEHDIAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8EF030", Offset = "0x8EE430", VA = "0x1808EF030", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x63A5110", Offset = "0x63A4510", VA = "0x1863A5110", Slot = "4")]
	public bool Equals(NBCLELCBMDP BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x63A5150", Offset = "0x63A4550", VA = "0x1863A5150", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class EFNHBCJKFPO : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] KEOCJOBLOAK;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class AFDHMBHIONO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int IKPPGAPELGG;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
	protected AFDHMBHIONO(int AAOLMMBCFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FGJAEFPJIIM(IPEndPoint GLFHKDBKIDM, byte[] JGCOLLOOLHL, int LHBPAMEKCBO, int OIPEPMJNPGM);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void MOHDGCNPION(IPEndPoint GLFHKDBKIDM, byte[] JGCOLLOOLHL, int LHBPAMEKCBO, int OIPEPMJNPGM);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NIHNNPKABGF : AFDHMBHIONO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] LDCKBFKFIKC;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator AABNNNNAFPF;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2352D00", Offset = "0x2352100", VA = "0x182352D00")]
	public NIHNNPKABGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x63A5960", Offset = "0x63A4D60", VA = "0x1863A5960")]
	public void MFPENNDPAHF(IPEndPoint GLFHKDBKIDM, byte[] LDCKBFKFIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x63A5390", Offset = "0x63A4790", VA = "0x1863A5390")]
	public void FFGJGLIPJML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x63A54B0", Offset = "0x63A48B0", VA = "0x1863A54B0", Slot = "4")]
	public override void FGJAEFPJIIM(IPEndPoint GLFHKDBKIDM, byte[] JGCOLLOOLHL, int LHBPAMEKCBO, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63A5B10", Offset = "0x63A4F10", VA = "0x1863A5B10", Slot = "5")]
	public override void MOHDGCNPION(IPEndPoint GLFHKDBKIDM, byte[] JGCOLLOOLHL, int LHBPAMEKCBO, int OIPEPMJNPGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct PPELLJNKEFL
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void HBNCNCBKPCN([NoAlias] byte* POBFABKDFKE, [NoAlias] byte* LDCKBFKFIKC, [NoAlias] byte* PLPIHBOPGIO, int OIPEPMJNPGM);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class NGAIMFBIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr NJPOCAJLMOG;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr FKHADJNJGPH;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x63A7E10", Offset = "0x63A7210", VA = "0x1863A7E10")]
		[BurstDiscard]
		private static void MOMNLNKPONH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x63A7CC0", Offset = "0x63A70C0", VA = "0x1863A7CC0")]
		private static IntPtr MODNEBBCKAM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x63A7C20", Offset = "0x63A7020", VA = "0x1863A7C20")]
		public static void MIJNEAPKOKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		public static void OOJJEJPOBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x63A79F0", Offset = "0x63A6DF0", VA = "0x1863A79F0")]
		public unsafe static void CAHJKFNDGBI([NoAlias] byte* POBFABKDFKE, [NoAlias] byte* LDCKBFKFIKC, [NoAlias] byte* PLPIHBOPGIO, int OIPEPMJNPGM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint LDCKBFKFIKC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint PLPIHBOPGIO[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint HOCOKKHNGPO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint JCOHOBHKCNK[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint PHNAJBHKOAD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint KDCFCBGLFFC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint JBKDNKPADAH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint HKFHAKABPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint LCDIJFJCJHL[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x63A7120", Offset = "0x63A6520", VA = "0x1863A7120")]
	private void CALNFFOLFJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x63A70F0", Offset = "0x63A64F0", VA = "0x1863A70F0")]
	private uint ADPOHLCGBDD(uint LLKDJGHBOID, int POOEBLAGFAP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6390110", Offset = "0x638F510", VA = "0x186390110")]
	private void AMLMHIGBLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6390250", Offset = "0x638F650", VA = "0x186390250")]
	private void IACLNDCBOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63901C0", Offset = "0x638F5C0", VA = "0x1863901C0")]
	private void ELOBKAPNKNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6390460", Offset = "0x638F860", VA = "0x186390460")]
	private void JEDKCCFEBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63A7790", Offset = "0x63A6B90", VA = "0x1863A7790")]
	private void IIFEFMGGHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x63A7210", Offset = "0x63A6610", VA = "0x1863A7210")]
	private unsafe void HHCFCAHMDEI(byte* POBFABKDFKE, uint* LDCKBFKFIKC, uint* PLPIHBOPGIO, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x63A7630", Offset = "0x63A6A30", VA = "0x1863A7630")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void IAOJADJEFFL([NoAlias] byte* POBFABKDFKE, [NoAlias] byte* LDCKBFKFIKC, [NoAlias] byte* PLPIHBOPGIO, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x63A76B0", Offset = "0x63A6AB0", VA = "0x1863A76B0")]
	public static void IAOJADJEFFL(Span<byte> POBFABKDFKE, Span<byte> LDCKBFKFIKC, Span<byte> PLPIHBOPGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x63A77F0", Offset = "0x63A6BF0", VA = "0x1863A77F0")]
	public static void OAPJBAAFFCA(Span<byte> POBFABKDFKE, Span<byte> LDCKBFKFIKC, Span<byte> PLPIHBOPGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x63A71A0", Offset = "0x63A65A0", VA = "0x1863A71A0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void EMIMHOKLFPO([NoAlias] byte* POBFABKDFKE, [NoAlias] byte* LDCKBFKFIKC, [NoAlias] byte* PLPIHBOPGIO, int OIPEPMJNPGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x63A7F30", Offset = "0x63A7330", VA = "0x1863A7F30")]
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
