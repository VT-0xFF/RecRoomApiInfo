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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CFPOLJKHGFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KHPMBHOPIHE
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
		private NetworkManager MCFDDOGOCMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, LCBIKOKMAOH> KPGELJHFFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DDMHGGOOADA BMFLDPFIEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] LCMEKJLLNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KHPMBHOPIHE OOBJHDHPJHJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong HJBLKHIHJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool MCMJBMGCNJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x53482D0", Offset = "0x5346ED0", VA = "0x1853482D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x53477D0", Offset = "0x53463D0", VA = "0x1853477D0")]
		public void RecRoom_SetEncryptionInfo(ulong PKIHEGKIKHL, byte[] PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x53477B0", Offset = "0x53463B0", VA = "0x1853477B0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5347680", Offset = "0x5346280", VA = "0x185347680")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x53481D0", Offset = "0x5346DD0", VA = "0x1853481D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x53479D0", Offset = "0x53465D0", VA = "0x1853479D0", Slot = "6")]
		public override void Send(ulong CKFFDHGOJPM, ArraySegment<byte> IGJLGPELHOJ, NetworkDelivery PJPDBEOBOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5347770", Offset = "0x5346370", VA = "0x185347770", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong CKFFDHGOJPM, [Out] ArraySegment<byte> AGEBEEELPDJ, [Out] float MBFFLEPNFMI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5347CC0", Offset = "0x53468C0", VA = "0x185347CC0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x53480F0", Offset = "0x5346CF0", VA = "0x1853480F0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5346CE0", Offset = "0x53458E0", VA = "0x185346CE0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong CKFFDHGOJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5346B90", Offset = "0x5345790", VA = "0x185346B90", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5346F90", Offset = "0x5345B90", VA = "0x185346F90", Slot = "12")]
		public override ulong GetCurrentRtt(ulong CKFFDHGOJPM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5347C50", Offset = "0x5346850", VA = "0x185347C50", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5347110", Offset = "0x5345D10", VA = "0x185347110", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MCFDDOGOCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5346AC0", Offset = "0x53456C0", VA = "0x185346AC0")]
		private FJLBHHPJFDB CGMOIINALKJ(NetworkDelivery OMKEAAPIABA)
		{
			return default(FJLBHHPJFDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5346A00", Offset = "0x5345600", VA = "0x185346A00", Slot = "15")]
		private void CCMEKFFDPPB(LCBIKOKMAOH GIMJPKIOCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5346E50", Offset = "0x5345A50", VA = "0x185346E50", Slot = "16")]
		private void GHADNNOHHKH(LCBIKOKMAOH GIMJPKIOCKJ, KCLCNNBAEBG CHDAFPGCJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "17")]
		private void AEMIBKKNIBH(IPEndPoint JJJNJOAKKIA, SocketError LEJGFJFECJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x53472D0", Offset = "0x5345ED0", VA = "0x1853472D0", Slot = "18")]
		private void JNADPBMBJDA(LCBIKOKMAOH GIMJPKIOCKJ, GJBAJEIPMAP BIBCAMINPDH, byte HCEICOAGHBJ, FJLBHHPJFDB MDAKNPDLMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5347030", Offset = "0x5345C30", VA = "0x185347030")]
		private void IAFIPNOPJAD(int JIGGJNDJAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "19")]
		private void NPLBLOOKHEE(IPEndPoint NCPOLGILGFH, GJBAJEIPMAP BIBCAMINPDH, FHPHOKJAELF DJFEPCFLBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "20")]
		private void LIONDONAMNJ(LCBIKOKMAOH GIMJPKIOCKJ, int DHJGECOICJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53475F0", Offset = "0x53461F0", VA = "0x1853475F0", Slot = "21")]
		private void OJNJIEENKFJ(JOGCIBGAGFC NFAAJOAMBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5347650", Offset = "0x5346250", VA = "0x185347650")]
		private ulong ONFIOEIFLGC(LCBIKOKMAOH GIMJPKIOCKJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53475D0", Offset = "0x53461D0", VA = "0x1853475D0")]
		private static int MPMBLECKPBM(float FOGEGHJNDKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x53481F0", Offset = "0x5346DF0", VA = "0x1853481F0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class FOCAMPDJAPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly LCBIKOKMAOH CLPPDJMLIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<MELHHKMHGLO> BKNNFBOKODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KFEGDCKDPHM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5341260", Offset = "0x533FE60", VA = "0x185341260")]
	protected FOCAMPDJAPJ(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5341200", Offset = "0x533FE00", VA = "0x185341200")]
	public void NOIIMBKIHEM(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5341140", Offset = "0x533FD40", VA = "0x185341140")]
	protected void IPGJEBJANFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x53411C0", Offset = "0x533FDC0", VA = "0x1853411C0")]
	public bool KJGIOGFIDLC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool MBKFGPGLGEG();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool LDKJCJPLGBA(MELHHKMHGLO LEMDNPBNHID);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CKPGJEAEFKB
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
public class JOGCIBGAGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly DDMHGGOOADA KIPGIDJKIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int ODGIJDBNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal KHDGGGOEMIO FFNKMNEIJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint MEHICACKILO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CKPGJEAEFKB BJMFNDMKKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x799820", Offset = "0x798420", VA = "0x180799820")]
		[CompilerGenerated]
		get
		{
			return default(CKPGJEAEFKB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x896A60", Offset = "0x895660", VA = "0x180896A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5341F00", Offset = "0x5340B00", VA = "0x185341F00")]
	internal void HMCJNPBLFMJ(KHDGGGOEMIO NFAIGDGAPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5341F60", Offset = "0x5340B60", VA = "0x185341F60")]
	private bool LBNJFDOFNND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5341F90", Offset = "0x5340B90", VA = "0x185341F90")]
	internal JOGCIBGAGFC(IPEndPoint NCPOLGILGFH, KHDGGGOEMIO FEKLJAIICAE, DDMHGGOOADA FMHAJBIIFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5341EA0", Offset = "0x5340AA0", VA = "0x185341EA0")]
	public LCBIKOKMAOH BLNKLPJJIKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FHPHOKJAELF
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IKCKNNLKPJG
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
public struct KCLCNNBAEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IKCKNNLKPJG KEPGOOKMNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError DLPNEPJBIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GJBAJEIPMAP ICMKGOLBNMM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CFPOLJKHGFO
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGFDDJDNAEI(LCBIKOKMAOH GIMJPKIOCKJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJODEFJMOHD(LCBIKOKMAOH GIMJPKIOCKJ, KCLCNNBAEBG CHDAFPGCJJP);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KPDGIKACLLC(IPEndPoint JJJNJOAKKIA, SocketError LEJGFJFECJL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKJJHCMBPPF(LCBIKOKMAOH GIMJPKIOCKJ, GJBAJEIPMAP BIBCAMINPDH, byte HCEICOAGHBJ, FJLBHHPJFDB MDAKNPDLMDO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKMHNHFJCHP(IPEndPoint NCPOLGILGFH, GJBAJEIPMAP BIBCAMINPDH, FHPHOKJAELF DJFEPCFLBLG);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IAEICLOIPIA(LCBIKOKMAOH GIMJPKIOCKJ, int DHJGECOICJM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PHOGALGNBPD(JOGCIBGAGFC NFAAJOAMBMN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JHPIOKNHGCL
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNFALKJKODK(LCBIKOKMAOH GIMJPKIOCKJ, object GMJDOLFFJGC);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EJMHJHAJAGO
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGJNPGAOPMH(BDJEKGNDMGA LEMDNPBNHID);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IEDAGLJEDLN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KEADCIAOCKO(LCBIKOKMAOH GIMJPKIOCKJ, IPEndPoint JIKNFBFHDFM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KHDGGGOEMIO
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int HIHKOJDGBLI = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long LEIIOFBAFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte DEIOCOONNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] NJOEDMAMEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly OHGDFMEJMNI PGHMPBDPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int BLKOKPFEBCB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5342460", Offset = "0x5341060", VA = "0x185342460")]
	private KHDGGGOEMIO(long LLAFEMHCKGP, byte JPCMFGEBBOP, int JMADFINDJPP, byte[] LKPJIMCPIED, OHGDFMEJMNI IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5342400", Offset = "0x5341000", VA = "0x185342400")]
	public static int LIMDNAPKJDF(MELHHKMHGLO LEMDNPBNHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x53421E0", Offset = "0x5340DE0", VA = "0x1853421E0")]
	public static KHDGGGOEMIO JLNHDMIEFPC(MELHHKMHGLO LEMDNPBNHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5342000", Offset = "0x5340C00", VA = "0x185342000")]
	public static MELHHKMHGLO IOBHFIBENCL(EGIKCGINJND NMCHGAMOCMM, SocketAddress EMHPPHGEELN, long KCPMBFJDBFG, int JMADFINDJPP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OJBDONNJLBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long LEIIOFBAFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte DEIOCOONNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int BLKOKPFEBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool PDKMBNMGCPJ;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x534B440", Offset = "0x534A040", VA = "0x18534B440")]
	private OJBDONNJLBE(long LLAFEMHCKGP, byte JPCMFGEBBOP, int IADOMMDPEJD, bool LJFAFGLJDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x534B2F0", Offset = "0x5349EF0", VA = "0x18534B2F0")]
	public static OJBDONNJLBE JLNHDMIEFPC(MELHHKMHGLO LEMDNPBNHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x534B200", Offset = "0x5349E00", VA = "0x18534B200")]
	public static MELHHKMHGLO IOBHFIBENCL(long KCPMBFJDBFG, byte MAIAGKGIDJO, int DKNAIIOKLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x534B100", Offset = "0x5349D00", VA = "0x18534B100")]
	public static MELHHKMHGLO EKOHEENLFEL(LCBIKOKMAOH GIMJPKIOCKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct LADOIJLCDJN : IEquatable<LADOIJLCDJN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long GGIJDAOFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long PIAGDMECNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long DLIDKLOILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int JOJMLLAEDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int CCLPDGJJEAJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x53425C0", Offset = "0x53411C0", VA = "0x1853425C0")]
	public LADOIJLCDJN(byte[] NNKFDPENBOP, int DGNJGLBHMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x799820", Offset = "0x798420", VA = "0x180799820", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5342580", Offset = "0x5341180", VA = "0x185342580", Slot = "4")]
	public bool Equals(LADOIJLCDJN LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x53424D0", Offset = "0x53410D0", VA = "0x1853424D0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DDKDBGKJDOG : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] HPIKNNIBPMP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5337C40", Offset = "0x5336840", VA = "0x185337C40")]
	public DDKDBGKJDOG(byte[] NNKFDPENBOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class DANDOAPFFAG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class NEIHCDIJBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x534A1F0", Offset = "0x5348DF0", VA = "0x18534A1F0")]
		public static extern int MNKCKPDDIJA(IntPtr HMIOLIMNMJA, [In][Out] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [Out] byte[] KEJIHBAMMJD, [In][Out] int FCIICENELNO);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x534A330", Offset = "0x5348F30", VA = "0x18534A330")]
		internal static extern int OMKOHJNBPEM(IntPtr HMIOLIMNMJA, [In] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [In] byte[] KEJIHBAMMJD, [In] int FCIICENELNO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class DCCKMNJPOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5337A20", Offset = "0x5336620", VA = "0x185337A20")]
		public static extern int MNKCKPDDIJA(IntPtr HMIOLIMNMJA, [In][Out] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [Out] byte[] KEJIHBAMMJD, [In][Out] int FCIICENELNO);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5337B60", Offset = "0x5336760", VA = "0x185337B60")]
		internal static extern int OMKOHJNBPEM(IntPtr HMIOLIMNMJA, [In] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [In] byte[] KEJIHBAMMJD, [In] int FCIICENELNO);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool MCMJBMGCNJL;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool AGAGMJNMFFK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> EPPCDKNNKEG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x53373C0", Offset = "0x5335FC0", VA = "0x1853373C0")]
	static DANDOAPFFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5336F90", Offset = "0x5335B90", VA = "0x185336F90")]
	public static int DGILBCKBNKH(IntPtr HMIOLIMNMJA, byte[] LIIILIBDKGI, int DGNJGLBHMAI, byte[] KEJIHBAMMJD, int FCIICENELNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5337040", Offset = "0x5335C40", VA = "0x185337040")]
	public static int IPOEEKNJEKH(IntPtr HMIOLIMNMJA, byte[] LIIILIBDKGI, int DGNJGLBHMAI, byte[] KEJIHBAMMJD, int FCIICENELNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5336EA0", Offset = "0x5335AA0", VA = "0x185336EA0")]
	public static SocketError ALKLPOPJECF()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5337280", Offset = "0x5335E80", VA = "0x185337280")]
	public static SocketException PHOAPLBJOEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x53371D0", Offset = "0x5335DD0", VA = "0x1853371D0")]
	public static short NDGKBDJCJPC(IPEndPoint NCPOLGILGFH)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PMLEDFMDCPH
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DPHJLBLPOJH
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKHDPDHGIFF(IPEndPoint LFKOLNBJHOC, IPEndPoint NCPOLGILGFH, string KJCAGLABEME);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNEEJDMENFH(IPEndPoint CKLLCGGLADC, PMLEDFMDCPH OMKEAAPIABA, string KJCAGLABEME);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class CDCIPDFFHMJ
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct EECMJNLMFLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint NFBPCHOEDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint MEHICACKILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string FEFKHFILIEO;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct OHJLLFHGEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint FLJMFBIKCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PMLEDFMDCPH IBCFEMEEMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string FEFKHFILIEO;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class FMAMHIDGJLF
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint ICPLDDICIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string FEFKHFILIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FMAMHIDGJLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class ABINGFHBPCN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint ICPLDDICIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint EOEJPNNJCMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FEFKHFILIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ABINGFHBPCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class FDPLPFDJIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FEFKHFILIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KDJJKJCPMMM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x778130", Offset = "0x776D30", VA = "0x180778130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public FDPLPFDJIOJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly DDMHGGOOADA BIIOIGKJEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<EECMJNLMFLM> NGKJAKBNJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<OHJLLFHGEHN> HEBNMPDOCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly OHGDFMEJMNI FILMAMIGCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly EGIKCGINJND GFGDFLHMAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly LFPNBNMAIJC EHHMDMIEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private DPHJLBLPOJH NCJGIGCJPGM;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int MMIFDINJKON = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool EOKHECJNMDL;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5336A50", Offset = "0x5335650", VA = "0x185336A50")]
	internal CDCIPDFFHMJ(DDMHGGOOADA JIDCLJBPKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5336440", Offset = "0x5335040", VA = "0x185336440")]
	internal void CEIDEBDFDHC(IPEndPoint BOFJKGJAKDF, MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x234E450", Offset = "0x234D050", VA = "0x18234E450")]
	private void IHPIAFADDED<T>(T LEMDNPBNHID, IPEndPoint JIGKIEPHJOJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x53365A0", Offset = "0x53351A0", VA = "0x1853365A0")]
	private void FKHDPDHGIFF(FMAMHIDGJLF HLLLCECEGLD, IPEndPoint BOFJKGJAKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5336730", Offset = "0x5335330", VA = "0x185336730")]
	private void HDOOHNPJJCD(ABINGFHBPCN HLLLCECEGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53368B0", Offset = "0x53354B0", VA = "0x1853368B0")]
	private void KMOIECGCBMP(FDPLPFDJIOJ HLLLCECEGLD, IPEndPoint BOFJKGJAKDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FJLBHHPJFDB : byte
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
public static class MOEAGHODFGF
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] KKKHHAPGJAN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int OFEJILAEHLM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int GLKOGIFACDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OOOCEKNDHEP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5341DF0", Offset = "0x53409F0", VA = "0x185341DF0")]
	public OOOCEKNDHEP(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MPMGBDEJAEB : OOOCEKNDHEP
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5341DF0", Offset = "0x53409F0", VA = "0x185341DF0")]
	public MPMGBDEJAEB(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum EHABONPPDEA
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
public interface HKEOOKGBDAM
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LDHCFHJBDEI(EHABONPPDEA KDPEFEFKBMH, string JMMCCECHKKL, params object[] ODENEMACEPI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HGHOCHNABOH
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static HKEOOKGBDAM LLJLNJAKNPC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object HJDEKHCDOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5341B10", Offset = "0x5340710", VA = "0x185341B10")]
	private static void OFAGCEDJHKI(EHABONPPDEA ECFFOADKMGI, string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53419F0", Offset = "0x53405F0", VA = "0x1853419F0")]
	internal static void BFHKOPDBHFK(string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5341AB0", Offset = "0x53406B0", VA = "0x185341AB0")]
	internal static void JFOLOKJBOCC(string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5341A50", Offset = "0x5340650", VA = "0x185341A50")]
	internal static void FKBPPHGLGJE(string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum LNBJCFOILML
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GJBAJEIPMAP : OHGDFMEJMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private MELHHKMHGLO KNMIDLHLFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly DDMHGGOOADA AMGMGAIHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NEOONCNLKDN ICLLBMLMHFC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5341480", Offset = "0x5340080", VA = "0x185341480")]
	internal GJBAJEIPMAP(DDMHGGOOADA CEICFMOFGAN, NEOONCNLKDN CHPCBMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5341410", Offset = "0x5340010", VA = "0x185341410")]
	internal void GOCGCPHFMHK(MELHHKMHGLO LEMDNPBNHID, int KEKIIDNOHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5341390", Offset = "0x533FF90", VA = "0x185341390")]
	internal void GNAGPCCKOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5341360", Offset = "0x533FF60", VA = "0x185341360")]
	public void BGCIDLBJBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class NEOONCNLKDN
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum KHFBEFPOMAH
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
	public NEOONCNLKDN ENPKBKCAFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public KHFBEFPOMAH IBCFEMEEMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public LCBIKOKMAOH CLPPDJMLIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint MEHICACKILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object KONOADJLAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int JKAECMMIBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError CHFGEOJMKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public IKCKNNLKPJG OPLENNNJGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public JOGCIBGAGFC BEHOAFKLAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public FJLBHHPJFDB DBHOBAINGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte ODJJJJOFGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly GJBAJEIPMAP EFCDFOODPPP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x534A410", Offset = "0x5349010", VA = "0x18534A410")]
	public NEOONCNLKDN(DDMHGGOOADA CEICFMOFGAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DDMHGGOOADA : IEnumerable<LCBIKOKMAOH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class LBALLCEBMKD : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53426B0", Offset = "0x53412B0", VA = "0x1853426B0", Slot = "4")]
		public bool Equals(IPEndPoint HPIMCNPJDMN, IPEndPoint BKLHNKCOAIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E5C410", Offset = "0x4E5B010", VA = "0x184E5C410", Slot = "5")]
		public int GetHashCode(IPEndPoint IIFJCGIHMIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public LBALLCEBMKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct LGKDNOBFHEM : IEnumerator<LCBIKOKMAOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly LCBIKOKMAOH DMBOKLACFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private LCBIKOKMAOH PLPMGMGKGNC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LCBIKOKMAOH FLKMMGJNGAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x834770", Offset = "0x833370", VA = "0x180834770", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x834770", Offset = "0x833370", VA = "0x180834770", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE60DB0", Offset = "0xE5F9B0", VA = "0x180E60DB0")]
		public LGKDNOBFHEM(LCBIKOKMAOH BPDGEJEAOAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5346960", Offset = "0x5345560", VA = "0x185346960", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53469B0", Offset = "0x53455B0", VA = "0x1853469B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread OLAMNNAFJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool CIAFMOGPDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent FFMGNIDHHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<NEOONCNLKDN> LINEOMLCKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<NEOONCNLKDN> HOECGMMKHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NEOONCNLKDN HDIOPEJLBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly CFPOLJKHGFO MPHKMGDBFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly JHPIOKNHGCL MPNGFKKOOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly EJMHJHAJAGO EGEBBHOPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IEDAGLJEDLN FLMFODGMGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, LCBIKOKMAOH> EMFJCDPKIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, JOGCIBGAGFC> PJENGMCMLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, HFDCFLNHFIA> HJLDBEHMMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim IFEFELDJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private LCBIKOKMAOH EGOBECCKEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int BEGLPNOHKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<LCBIKOKMAOH> MIIKGABIMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private LCBIKOKMAOH[] LKHOHAEFOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly IDPPCNENOJJ GOECPPKIFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int NCKJELJKNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> HBPHHGANMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte IOLMLGKCODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object GFCGKNPPBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool KLBJNMPDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool OKEODACKBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int EEIHLMCCFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int BHIKNKDPEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FEBIGOEMDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool LKINBHLOFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool MAFLKHDONBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int IDKMLMLGMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int JFPFDHIAOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int PGIKOHLBHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool EOKHECJNMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool KPMPOGEAGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool BKMHIIMIOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool FMINLEOHOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int DILGJDPPLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int LDKFFAGMJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool MHAPCNFKJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly GNPFKAEPGCB NLOKIHHHGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool MEJLANODKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly CDCIPDFFHMJ ENMGEJIJELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool OJIBHABLFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public LNBJCFOILML HKMEBIOHLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int HBBOIDBMJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool JDPLOLOLPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool BPCHHPLHJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool DKLIDMEBGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool MKANHNPKABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MELHHKMHGLO FIIJEFFDNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int CHPCJBFBCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object BHLAABLMNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int OLPPHHFMMOP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int OOALJJGJCAJ = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket AGJCHEMIFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket PKEKFCHPFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread HCDEKEILHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread DJMAALDBNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint CLAFMDBPAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint IBLFJOOCFFD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] KNDAGMPPBOH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] NGILMOLFLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<LADOIJLCDJN, IPEndPoint> PAFNMKMKJCA;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int MCDPCJLDBAM = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress FPBAKEIAOPE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool NHMJIFOHAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int FMFCCIJLNOB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool DHKLLFDFJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1252770", Offset = "0x1251370", VA = "0x181252770")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1252780", Offset = "0x1251380", VA = "0x181252780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JDJLFDJDJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x150FDD0", Offset = "0x150E9D0", VA = "0x18150FDD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x150FA80", Offset = "0x150E680", VA = "0x18150FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte NNLDLNJDCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81DF80", Offset = "0x81CB80", VA = "0x18081DF80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int KCFIFGMJMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x533AB90", Offset = "0x5339790", VA = "0x18533AB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short BHLHAHBKLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x533D2C0", Offset = "0x533BEC0", VA = "0x18533D2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x533B810", Offset = "0x533A410", VA = "0x18533B810")]
	public void FCAIIBKDLOM(IPEndPoint JJJNJOAKKIA, byte[] PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x533CEB0", Offset = "0x533BAB0", VA = "0x18533CEB0")]
	public void KMGKDLPLFPH(IPEndPoint JJJNJOAKKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5338120", Offset = "0x5336D20", VA = "0x185338120")]
	private bool AHAJCBPBKML(IPEndPoint JJJNJOAKKIA, [Out] LCBIKOKMAOH GIMJPKIOCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x533D000", Offset = "0x533BC00", VA = "0x18533D000")]
	private void LAOHKMFEAKF(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x533EBD0", Offset = "0x533D7D0", VA = "0x18533EBD0")]
	private void PAGNPFPGAPO(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x533BAD0", Offset = "0x533A6D0", VA = "0x18533BAD0")]
	private void GPLHDAOBNGI(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x533F5B0", Offset = "0x533E1B0", VA = "0x18533F5B0")]
	public DDMHGGOOADA(CFPOLJKHGFO FMHAJBIIFBA, [Optional] IDPPCNENOJJ APFGNNGJFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x533EA50", Offset = "0x533D650", VA = "0x18533EA50")]
	internal void NPAOACPFLOK(LCBIKOKMAOH EICNOKHKBHA, int DHJGECOICJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x533EA00", Offset = "0x533D600", VA = "0x18533EA00")]
	internal void NOJMCPOALEO(LCBIKOKMAOH EICNOKHKBHA, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5338E40", Offset = "0x5337A40", VA = "0x185338E40")]
	internal void BEGMMICGJKH(LCBIKOKMAOH GIMJPKIOCKJ, IKCKNNLKPJG OKDGKAJLADI, SocketError GNBCBJJLKCC, MELHHKMHGLO DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x533B370", Offset = "0x5339F70", VA = "0x18533B370")]
	private void EFDEDAGGFGJ(LCBIKOKMAOH GIMJPKIOCKJ, IKCKNNLKPJG OKDGKAJLADI, SocketError GNBCBJJLKCC, bool JNADMECNEPO, byte[] IGJLGPELHOJ, int DIOBLODNDCP, int EMHEDPDPEMP, MELHHKMHGLO DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x533A7D0", Offset = "0x53393D0", VA = "0x18533A7D0")]
	private void DICDLLDCLEP(NEOONCNLKDN.KHFBEFPOMAH OMKEAAPIABA, [Optional] LCBIKOKMAOH GIMJPKIOCKJ, [Optional] IPEndPoint NCPOLGILGFH, SocketError CDPNJMLAOAG = SocketError.Success, int DHJGECOICJM = 0, IKCKNNLKPJG FBKEDIJKCMN = IKCKNNLKPJG.ConnectionFailed, [Optional] JOGCIBGAGFC ICOJCNJEGAK, FJLBHHPJFDB MDAKNPDLMDO = FJLBHHPJFDB.Unreliable, byte HCEICOAGHBJ = 0, [Optional] MELHHKMHGLO JMPLADEJELN, [Optional] object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x533ABB0", Offset = "0x53397B0", VA = "0x18533ABB0")]
	private void ECHNMPNKIAI(NEOONCNLKDN CHPCBMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x533A6D0", Offset = "0x53392D0", VA = "0x18533A6D0")]
	internal void DAEMGHMCBDA(NEOONCNLKDN CHPCBMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x533F090", Offset = "0x533DC90", VA = "0x18533F090")]
	private void POBKLEHMIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x533E570", Offset = "0x533D170", VA = "0x18533E570")]
	private void MJHEFBBLHND(int NDGAICDGCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x533C670", Offset = "0x533B270", VA = "0x18533C670")]
	internal LCBIKOKMAOH JKNJPMPLHDJ(JOGCIBGAGFC NFAAJOAMBMN, byte[] HFEKMKNKAIK, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x533BA50", Offset = "0x533A650", VA = "0x18533BA50")]
	private int GOEFFKDMDKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x533C050", Offset = "0x533AC50", VA = "0x18533C050")]
	private void HDMDCAAGMEC(IPEndPoint NCPOLGILGFH, LCBIKOKMAOH FAIDIGEDACC, KHDGGGOEMIO CBNLCMCNFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x53397E0", Offset = "0x53383E0", VA = "0x1853397E0")]
	private void CDMOJICMBAL(MELHHKMHGLO LEMDNPBNHID, IPEndPoint NCPOLGILGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x533BD30", Offset = "0x533A930", VA = "0x18533BD30")]
	internal void HDEKBMLNEFE(MELHHKMHGLO LEMDNPBNHID, FJLBHHPJFDB OLBMKOEFGHO, byte HCEICOAGHBJ, int KEKIIDNOHLK, LCBIKOKMAOH EICNOKHKBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x533D2F0", Offset = "0x533BEF0", VA = "0x18533D2F0")]
	public bool LLDDGFIBKDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x533D300", Offset = "0x533BF00", VA = "0x18533D300")]
	public bool LLDDGFIBKDD(IPAddress NELCBFMIKEF, IPAddress HJMMFDBHPKE, int FJMLIBPECDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x533D320", Offset = "0x533BF20", VA = "0x18533D320")]
	public bool LLDDGFIBKDD(int FJMLIBPECDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x533B8B0", Offset = "0x533A4B0", VA = "0x18533B8B0")]
	public void FMKIADFPCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x533E3A0", Offset = "0x533CFA0", VA = "0x18533E3A0")]
	public LCBIKOKMAOH MEJOJPFNBBN(string NNKFDPENBOP, int FJMLIBPECDL, string PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x533DEF0", Offset = "0x533CAF0", VA = "0x18533DEF0")]
	public LCBIKOKMAOH MEJOJPFNBBN(string NNKFDPENBOP, int FJMLIBPECDL, EGIKCGINJND BCKHPAAIMBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x533DFD0", Offset = "0x533CBD0", VA = "0x18533DFD0")]
	public LCBIKOKMAOH MEJOJPFNBBN(IPEndPoint JIGKIEPHJOJ, EGIKCGINJND BCKHPAAIMBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5339230", Offset = "0x5337E30", VA = "0x185339230")]
	public void BOBCBCFKKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5338F10", Offset = "0x5337B10", VA = "0x185338F10")]
	public void BOBCBCFKKIH(bool MJIIKENNGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x533CC90", Offset = "0x533B890", VA = "0x18533CC90")]
	public void KDGBNDJNNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x533CD90", Offset = "0x533B990", VA = "0x18533CD90")]
	public void KDGBNDJNNDI(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x533B450", Offset = "0x533A050", VA = "0x18533B450")]
	public void EFDEDAGGFGJ(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x533B500", Offset = "0x533A100", VA = "0x18533B500")]
	public void EFDEDAGGFGJ(LCBIKOKMAOH GIMJPKIOCKJ, byte[] IGJLGPELHOJ, int DIOBLODNDCP, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x533F3D0", Offset = "0x533DFD0", VA = "0x18533F3D0", Slot = "4")]
	private IEnumerator<LCBIKOKMAOH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x533F460", Offset = "0x533E060", VA = "0x18533F460", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5337F50", Offset = "0x5336B50", VA = "0x185337F50")]
	private MELHHKMHGLO ADJGCDKGPMJ(GJHGGAILMFI IEIEKFIPLEG, int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5338040", Offset = "0x5336C40", VA = "0x185338040")]
	private MELHHKMHGLO ADJGCDKGPMJ(GJHGGAILMFI IEIEKFIPLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x533C4B0", Offset = "0x533B0B0", VA = "0x18533C4B0")]
	internal MELHHKMHGLO IEHDBJGLLMH(int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x533E890", Offset = "0x533D490", VA = "0x18533E890")]
	internal void MKNBMNOGIMA(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x533F4F0", Offset = "0x533E0F0", VA = "0x18533F4F0")]
	static DDMHGGOOADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1252770", Offset = "0x1251370", VA = "0x181252770")]
	private bool IBAGIICNAIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x533E480", Offset = "0x533D080", VA = "0x18533E480")]
	private void MENNCDOAOEL(IPEndPoint CKIBONKJEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x533EFB0", Offset = "0x533DBB0", VA = "0x18533EFB0")]
	private void PJFECPMCBGP(IPEndPoint CKIBONKJEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x533A530", Offset = "0x5339130", VA = "0x18533A530")]
	private bool CPMILBCONFH(SocketException GDDKLHPPIHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x533B5C0", Offset = "0x533A1C0", VA = "0x18533B5C0")]
	private void EGOAPNBFOGK(Socket JIDCLJBPKFG, EndPoint CLMBKBLHMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x533EC20", Offset = "0x533D820", VA = "0x18533EC20")]
	private void PJDJLJPBDOK(object FPIEOLNLDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x533DB80", Offset = "0x533C780", VA = "0x18533DB80")]
	private void MCGLJFHAONB(object FPIEOLNLDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x533D3A0", Offset = "0x533BFA0", VA = "0x18533D3A0")]
	public bool LLDDGFIBKDD(IPAddress NELCBFMIKEF, IPAddress HJMMFDBHPKE, int FJMLIBPECDL, bool NOKNDDEFCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5339240", Offset = "0x5337E40", VA = "0x185339240")]
	private bool CDDIDJGEJHE(Socket JIDCLJBPKFG, IPEndPoint CKIBONKJEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x533BFF0", Offset = "0x533ABF0", VA = "0x18533BFF0")]
	internal int HDHEOGOFAFP(MELHHKMHGLO LEMDNPBNHID, IPEndPoint NCPOLGILGFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5338E00", Offset = "0x5337A00", VA = "0x185338E00")]
	internal int AJNOPGHIIIP(MELHHKMHGLO LEMDNPBNHID, IPEndPoint NCPOLGILGFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53381B0", Offset = "0x5336DB0", VA = "0x1853381B0")]
	internal int AJNOPGHIIIP(byte[] EOOPGFAEMIH, int DIOBLODNDCP, int NBJKCBMEDIG, IPEndPoint NCPOLGILGFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x533EAA0", Offset = "0x533D6A0", VA = "0x18533EAA0")]
	internal void OPDNPKPKDIC(bool OBCABCPIKMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum GJHGGAILMFI : byte
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
internal sealed class MELHHKMHGLO
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int OKJNPNAOCMB;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] DNFLGGGFDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] OPFCHCFDJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int JKLDCECNLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object KONOADJLAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public MELHHKMHGLO ENPKBKCAFHC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GJHGGAILMFI IIHOCPJOOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5348630", Offset = "0x5347230", VA = "0x185348630")]
		get
		{
			return default(GJHGGAILMFI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x53487D0", Offset = "0x53473D0", VA = "0x1853487D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte DEIOCOONNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5348700", Offset = "0x5347300", VA = "0x185348700")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5348660", Offset = "0x5347260", VA = "0x185348660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LFOCNGKIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x53486A0", Offset = "0x53472A0", VA = "0x1853486A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5348390", Offset = "0x5346F90", VA = "0x185348390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MMJKEBFHDPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5348730", Offset = "0x5347330", VA = "0x185348730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte NFHFKAIMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x53485A0", Offset = "0x53471A0", VA = "0x1853485A0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x53483D0", Offset = "0x5346FD0", VA = "0x1853483D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort OEKNJKBPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x53485D0", Offset = "0x53471D0", VA = "0x1853485D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5348350", Offset = "0x5346F50", VA = "0x185348350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MOAOLEOCNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x53482F0", Offset = "0x5346EF0", VA = "0x1853482F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5348760", Offset = "0x5347360", VA = "0x185348760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort LIKAMLCKAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5348500", Offset = "0x5347100", VA = "0x185348500")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5348560", Offset = "0x5347160", VA = "0x185348560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5348910", Offset = "0x5347510", VA = "0x185348910")]
	static MELHHKMHGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x53487A0", Offset = "0x53473A0", VA = "0x1853487A0")]
	public void MFAMFGCCLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5348D00", Offset = "0x5347900", VA = "0x185348D00")]
	public MELHHKMHGLO(int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5348BF0", Offset = "0x53477F0", VA = "0x185348BF0")]
	public MELHHKMHGLO(GJHGGAILMFI IEIEKFIPLEG, int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5348400", Offset = "0x5347000", VA = "0x185348400")]
	public static int DJAHKOIKHAM(GJHGGAILMFI IEIEKFIPLEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5348470", Offset = "0x5347070", VA = "0x185348470")]
	public int DJAHKOIKHAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5348810", Offset = "0x5347410", VA = "0x185348810")]
	public bool PGCFBEIGHJH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum CCGMIJEPFHI : byte
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
internal enum AIDHCBOHNGM
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
internal enum MJGPDBBPLFH
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum JHJHLLKMCMP
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LCBIKOKMAOH
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class CJPMFCGGHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MELHHKMHGLO[] FIGCDNEDGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int LFLONNPPPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int EDKGKLPCPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte NFHFKAIMHPP;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public CJPMFCGGHHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void MEJFGHJADDN(ulong MHKONJIGPKE, int EEIKEGAJBEG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int OBEDNEKFDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BGPGFFMNLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int BMCFHECLICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double CLLNHPBBFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int PGBKAOCIHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HHHHHACGFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch IKBAKABPDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int BCHMMNIPLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long LBLDAFPKAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object EBPHMJNEIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal LCBIKOKMAOH AKEBOGMLEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal LCBIKOKMAOH NDDKMPANMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<MELHHKMHGLO> JKNDLIDJOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<FOCAMPDJAPJ> JAHEDLEIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly FOCAMPDJAPJ[] EJCGCBGJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int BCGFFDFMJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int JJMPCPGCMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool EHOMPCGMNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int OKIHHKGJLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int JJGFNMOGPCM;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int OGFDGNDIIPN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int GNHKJPCLBMM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object PADPNAHPNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int HGBHBGNAENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, CJPMFCGGHHO> EIAKAGKMCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> OPADKHOKBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly MELHHKMHGLO HJPNBEGFDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int DPMBAPNEGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KDMNJAGJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint GEHFNKOFCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int LGNCJCBHNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int CBOOJMNGMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long FMKGICCJGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte PPAJHLOIJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private CCGMIJEPFHI JPOMHIOGCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private MELHHKMHGLO IIOFKBGMAHG;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int ALOCEJGAIJO = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int JOPBFFNKDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly MELHHKMHGLO GNHHDFOIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MELHHKMHGLO ABJLIBCPFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly MELHHKMHGLO BHAHIBMCIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MELHHKMHGLO MDBLNOBINFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly DDMHGGOOADA FHGEAJBDNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int EFPGBNMCEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object JFMMGCLJAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly GNPFKAEPGCB NLOKIHHHGGG;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte OHIHJBBEKAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81DF70", Offset = "0x81CB70", VA = "0x18081DF70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5343780", Offset = "0x5342380", VA = "0x185343780")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint PAPLADLFGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x964480", Offset = "0x963080", VA = "0x180964480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CCGMIJEPFHI FNIFCEPBIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1074FA0", Offset = "0x1073BA0", VA = "0x181074FA0")]
		get
		{
			return default(CCGMIJEPFHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long KADFAPMLNKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x92E9D0", Offset = "0x92D5D0", VA = "0x18092E9D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PIGHPGKJONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x150FDE0", Offset = "0x150E9E0", VA = "0x18150FDE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x150FB20", Offset = "0x150E720", VA = "0x18150FB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int OBNNPFJIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x53429D0", Offset = "0x53415D0", VA = "0x1853429D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EPLHJIMMJHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x78F560", Offset = "0x78E160", VA = "0x18078F560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double NGOIIANPNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x16F37C0", Offset = "0x16F23C0", VA = "0x1816F37C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MEJFGHJADDN JGFEHAPDFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x53429E0", Offset = "0x53415E0", VA = "0x1853429E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5344D80", Offset = "0x5343980", VA = "0x185344D80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5345FF0", Offset = "0x5344BF0", VA = "0x185345FF0")]
	internal LCBIKOKMAOH(DDMHGGOOADA MIGLECEPOOA, IPEndPoint NCPOLGILGFH, int HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5342720", Offset = "0x5341320", VA = "0x185342720")]
	internal void AGFLDAMKNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5342BD0", Offset = "0x53417D0", VA = "0x185342BD0")]
	internal void FKOCAEFHDPK(IPEndPoint JMFKHCKMIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5342B40", Offset = "0x5341740", VA = "0x185342B40")]
	internal void ELIFMCELOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5343B70", Offset = "0x5342770", VA = "0x185343B70")]
	private void IMOPBAEHIFI(int BMGCADMEBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5342C00", Offset = "0x5341800", VA = "0x185342C00")]
	private void GBJBMBIBKNH(int LBHEICCHIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5342820", Offset = "0x5341420", VA = "0x185342820")]
	private FOCAMPDJAPJ CNOLCLCBNPK(byte EANIEPCFJGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5346450", Offset = "0x5345050", VA = "0x185346450")]
	internal LCBIKOKMAOH(DDMHGGOOADA MIGLECEPOOA, IPEndPoint NCPOLGILGFH, int HLINMGJJNHD, byte MAIAGKGIDJO, EGIKCGINJND NMCHGAMOCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5345E10", Offset = "0x5344A10", VA = "0x185345E10")]
	internal LCBIKOKMAOH(DDMHGGOOADA MIGLECEPOOA, JOGCIBGAGFC NFAAJOAMBMN, int HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5344210", Offset = "0x5342E10", VA = "0x185344210")]
	internal void JOMPKANDAAC(KHDGGGOEMIO KHBNMABHMNP, byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5344190", Offset = "0x5342D90", VA = "0x185344190")]
	internal bool JHABNPLGPPH(OJBDONNJLBE LEMDNPBNHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5343830", Offset = "0x5342430", VA = "0x185343830")]
	public void IHPIAFADDED(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG, FJLBHHPJFDB MCIMANHECMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5345450", Offset = "0x5344050", VA = "0x185345450")]
	private void PIIIKGMMKEA(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG, byte HCEICOAGHBJ, FJLBHHPJFDB MDAKNPDLMDO, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5342A90", Offset = "0x5341690", VA = "0x185342A90")]
	public void EKILCNCBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5342740", Offset = "0x5341340", VA = "0x185342740")]
	internal MJGPDBBPLFH CALENLKNGJF(MELHHKMHGLO LEMDNPBNHID)
	{
		return default(MJGPDBBPLFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5344E30", Offset = "0x5343A30", VA = "0x185344E30")]
	internal void LLGMNGBFEDJ(FOCAMPDJAPJ NIFEIEHLCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5343860", Offset = "0x5342460", VA = "0x185343860")]
	internal JHJHLLKMCMP IJCEPGANLGJ(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG, bool JNADMECNEPO)
	{
		return default(JHJHLLKMCMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5344E90", Offset = "0x5343A90", VA = "0x185344E90")]
	private void NIHKKHNHCON(int NAJBFHOJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5342DF0", Offset = "0x53419F0", VA = "0x185342DF0")]
	internal void HFGNGHDLBBG(FJLBHHPJFDB OLBMKOEFGHO, MELHHKMHGLO BPDGEJEAOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5343C40", Offset = "0x5342840", VA = "0x185343C40")]
	private void IPOMNEJHOBC(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5344260", Offset = "0x5342E60", VA = "0x185344260")]
	private void KIMMPLLMLEO(int MMHFADIOONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5342C30", Offset = "0x5341830", VA = "0x185342C30")]
	internal AIDHCBOHNGM HDMDCAAGMEC(KHDGGGOEMIO CBNLCMCNFIA)
	{
		return default(AIDHCBOHNGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x53446D0", Offset = "0x53432D0", VA = "0x1853446D0")]
	internal void LDKJCJPLGBA(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x53445D0", Offset = "0x53431D0", VA = "0x1853445D0")]
	private void KLCAIBHAMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53459A0", Offset = "0x53445A0", VA = "0x1853459A0")]
	internal void PJIFNCOLAAB(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5344ED0", Offset = "0x5343AD0", VA = "0x185344ED0")]
	internal void OFENLADEDFE(int MMHFADIOONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5345B50", Offset = "0x5344750", VA = "0x185345B50")]
	internal void POIAJGAGIOH(MELHHKMHGLO LEMDNPBNHID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class GNPFKAEPGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long FCMLMKIGJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long POMGKPDDDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long DKEMAPOEBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long JIKEGKBEIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long MFAAIPPHBBP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long PIDEHLODMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53415A0", Offset = "0x53401A0", VA = "0x1853415A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long CPMAEPKKLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53415B0", Offset = "0x53401B0", VA = "0x1853415B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long OCIANLMAHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5341550", Offset = "0x5340150", VA = "0x185341550")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MFDFPAMOBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5341570", Offset = "0x5340170", VA = "0x185341570")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MMBGBDPFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5341580", Offset = "0x5340180", VA = "0x185341580")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CEDHGLJNIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x53414E0", Offset = "0x53400E0", VA = "0x1853414E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5341540", Offset = "0x5340140", VA = "0x185341540")]
	public void EJPPMBGDNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5341530", Offset = "0x5340130", VA = "0x185341530")]
	public void DLOCNJOBEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5341560", Offset = "0x5340160", VA = "0x185341560")]
	public void GIKDBIFDDMH(long AJMALKNENLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x53414D0", Offset = "0x53400D0", VA = "0x1853414D0")]
	public void AAMDJDGCOEP(long MIOLDMLFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x53415C0", Offset = "0x53401C0", VA = "0x1853415C0")]
	public void PLCIMGGGNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5341590", Offset = "0x5340190", VA = "0x185341590")]
	public void JEPJBJHHEBK(long NCALHFGGJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x53415D0", Offset = "0x53401D0", VA = "0x1853415D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public GNPFKAEPGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DICFCOMCIGP
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> AJGICPKBEPP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x533FC00", Offset = "0x533E800", VA = "0x18533FC00")]
	public static IPEndPoint GDKNDPJDIAE(string MGFKKALOBJK, int FJMLIBPECDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x533FF10", Offset = "0x533EB10", VA = "0x18533FF10")]
	public static IPAddress PPHNANBDFAJ(string MGFKKALOBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x533FE80", Offset = "0x533EA80", VA = "0x18533FE80")]
	public static IPAddress PPHNANBDFAJ(string MGFKKALOBJK, AddressFamily CCJKPPFLFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x533FE50", Offset = "0x533EA50", VA = "0x18533FE50")]
	internal static int MMIFEJAHMNC(int JEIBBCEGCBO, int GLFGEBKCMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x23854B0", Offset = "0x23840B0", VA = "0x1823854B0")]
	internal static T[] FKPLDBOLMKE<T>(int EMHEDPDPEMP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class AFHILOFPCFD : FOCAMPDJAPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct EIDMOBONFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MELHHKMHGLO KNMIDLHLFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long AHKMONJNFAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool LCINEGPGPLF;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53410A0", Offset = "0x533FCA0", VA = "0x1853410A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5340FC0", Offset = "0x533FBC0", VA = "0x185340FC0")]
		public void BGGKBEMAPMG(MELHHKMHGLO LEMDNPBNHID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5340FE0", Offset = "0x533FBE0", VA = "0x185340FE0")]
		public bool GEAAINPDGHJ(long MKJMBIGEENJ, LCBIKOKMAOH GIMJPKIOCKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5341050", Offset = "0x533FC50", VA = "0x185341050")]
		public bool GMINFKPEKLF(LCBIKOKMAOH GIMJPKIOCKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly MELHHKMHGLO AKJEFHPBBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly EIDMOBONFOM[] NFKLBGDNDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly MELHHKMHGLO[] KAOADKGFPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] CINMKBCMEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int CAPPCMCGLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int EDMFOIPEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CHLEOCIJHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int LLDMDIMPMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool LPPHNIIPCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly FJLBHHPJFDB CMGDOBGLIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool ADKJHDAKNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int DOENAJHLAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte KJKJLNOIHMJ;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5334EE0", Offset = "0x5333AE0", VA = "0x185334EE0")]
	public AFHILOFPCFD(LCBIKOKMAOH GIMJPKIOCKJ, bool GLJBKFECNJL, byte HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5334020", Offset = "0x5332C20", VA = "0x185334020")]
	private void BCCDFKOODJO(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5334A30", Offset = "0x5333630", VA = "0x185334A30", Slot = "4")]
	protected override bool MBKFGPGLGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x53343D0", Offset = "0x5332FD0", VA = "0x1853343D0", Slot = "5")]
	public override bool LDKJCJPLGBA(MELHHKMHGLO LEMDNPBNHID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class MIGCAEAPJKP : FOCAMPDJAPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int NJGDCDCBODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort EDMFOIPEAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool FHEIGCAEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private MELHHKMHGLO FBJIGNNKLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly MELHHKMHGLO IPNGFPKJOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool FOHMLAIDMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte KJKJLNOIHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long MDBABHLAFDP;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x534A050", Offset = "0x5348C50", VA = "0x18534A050")]
	public MIGCAEAPJKP(LCBIKOKMAOH GIMJPKIOCKJ, bool DBFGBNFNPLJ, byte HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5349BE0", Offset = "0x53487E0", VA = "0x185349BE0", Slot = "4")]
	protected override bool MBKFGPGLGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5349900", Offset = "0x5348500", VA = "0x185349900", Slot = "5")]
	public override bool LDKJCJPLGBA(MELHHKMHGLO LEMDNPBNHID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class ACDJJJLHJKM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct JOOHBFFKEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong KAMPOHEJOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double AMAMDDBPBFG;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct DDPGECEKPAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int LFNKHICBLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float IBJJKNHHAPP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5333D30", Offset = "0x5332930", VA = "0x185333D30")]
	private static void BFIGDGMBEPH(byte[] NJCBLCELFEN, int IAKOFEGDGBF, ulong IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5333F00", Offset = "0x5332B00", VA = "0x185333F00")]
	private static void BFIGDGMBEPH(byte[] NJCBLCELFEN, int IAKOFEGDGBF, int IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5333EC0", Offset = "0x5332AC0", VA = "0x185333EC0")]
	public static void BFIGDGMBEPH(byte[] NJCBLCELFEN, int IAKOFEGDGBF, short IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5334000", Offset = "0x5332C00", VA = "0x185334000")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, double GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5333F80", Offset = "0x5332B80", VA = "0x185333F80")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5333EC0", Offset = "0x5332AC0", VA = "0x185333EC0")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, short GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5333EC0", Offset = "0x5332AC0", VA = "0x185333EC0")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, ushort GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5333F00", Offset = "0x5332B00", VA = "0x185333F00")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5333F00", Offset = "0x5332B00", VA = "0x185333F00")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, uint GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5333F70", Offset = "0x5332B70", VA = "0x185333F70")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5333F70", Offset = "0x5332B70", VA = "0x185333F70")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, ulong GCPEEAODAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class OHGDFMEJMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] JFFNBPDIOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int KENAEMDHCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int IMAGKPAKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int ABGGNCOKFHC;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] OPFCHCFDJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int HHNHGMINKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x896A30", Offset = "0x895630", VA = "0x180896A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HMHHNPGAGKI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x534A940", Offset = "0x5349540", VA = "0x18534A940")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KACAKNGLONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BFBA10", Offset = "0x1BFA610", VA = "0x181BFBA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LFGIGFIFHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x534AEB0", Offset = "0x5349AB0", VA = "0x18534AEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x534AAA0", Offset = "0x53496A0", VA = "0x18534AAA0")]
	public void GOCGCPHFMHK(byte[] NOOIIGLDGHB, int IAKOFEGDGBF, int ICLGGOFCENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OHGDFMEJMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x534B0A0", Offset = "0x5349CA0", VA = "0x18534B0A0")]
	public OHGDFMEJMNI(byte[] NOOIIGLDGHB, int IAKOFEGDGBF, int ICLGGOFCENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x534A4B0", Offset = "0x53490B0", VA = "0x18534A4B0")]
	public IPEndPoint ACFBIPPMEPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x534A6F0", Offset = "0x53492F0", VA = "0x18534A6F0")]
	public byte FCIJCCPGGGJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x534A6F0", Offset = "0x53492F0", VA = "0x18534A6F0")]
	public sbyte CJIGGPJPCFI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2646780", Offset = "0x2645380", VA = "0x182646780")]
	public T[] EMACKALBKNP<T>(ushort JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x534A6B0", Offset = "0x53492B0", VA = "0x18534A6B0")]
	public bool[] CCIIKCMDDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x534B060", Offset = "0x5349C60", VA = "0x18534B060")]
	public ushort[] PGCGIELEBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x534AF30", Offset = "0x5349B30", VA = "0x18534AF30")]
	public short[] NACCGBIMLKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x534AF70", Offset = "0x5349B70", VA = "0x18534AF70")]
	public int[] NNONKJEFEGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x534A990", Offset = "0x5349590", VA = "0x18534A990")]
	public uint[] FKKINEIOHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x534AB50", Offset = "0x5349750", VA = "0x18534AB50")]
	public float[] HLBJDJAMBLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x534A580", Offset = "0x5349180", VA = "0x18534A580")]
	public double[] AEFOMPLPCAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x534A5C0", Offset = "0x53491C0", VA = "0x18534A5C0")]
	public long[] ALIJNECOKPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x534A9D0", Offset = "0x53495D0", VA = "0x18534A9D0")]
	public ulong[] FLAFIAEFGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x534A810", Offset = "0x5349410", VA = "0x18534A810")]
	public string[] DOHKFOJNBFN(int MHJLMGPANNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x534AFB0", Offset = "0x5349BB0", VA = "0x18534AFB0")]
	public bool OGEAOEPLDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x534A600", Offset = "0x5349200", VA = "0x18534A600")]
	public char BDJCCHHFBDM()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x534A600", Offset = "0x5349200", VA = "0x18534A600")]
	public ushort BDKLDCAMKIA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x534AA10", Offset = "0x5349610", VA = "0x18534AA10")]
	public short FNAKKFANAEG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x534AAE0", Offset = "0x53496E0", VA = "0x18534AAE0")]
	public long HADHKJPBBJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x534AE40", Offset = "0x5349A40", VA = "0x18534AE40")]
	public ulong KKGJPEEGNHD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x534AB90", Offset = "0x5349790", VA = "0x18534AB90")]
	public int JCEPEKBOCLO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x534AEC0", Offset = "0x5349AC0", VA = "0x18534AEC0")]
	public uint MNLIBMPOOML()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x534A730", Offset = "0x5349330", VA = "0x18534A730")]
	public float CLKPJCAGNCL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x534A7A0", Offset = "0x53493A0", VA = "0x18534A7A0")]
	public double DELLIKHCMOB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x534AC00", Offset = "0x5349800", VA = "0x18534AC00")]
	public string JCLIFBPHEGF(int LEEFAANFGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x534AFF0", Offset = "0x5349BF0", VA = "0x18534AFF0")]
	public ArraySegment<byte> PAPFPOPPABK(int EMHEDPDPEMP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x534A670", Offset = "0x5349270", VA = "0x18534A670")]
	public sbyte[] BJBKPOKPFFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x534A950", Offset = "0x5349550", VA = "0x18534A950")]
	public byte[] EFOKCPMNHOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x534AA80", Offset = "0x5349680", VA = "0x18534AA80")]
	public void GMINFKPEKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class EGIKCGINJND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] JFFNBPDIOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int KENAEMDHCND;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int EGOCEDEJNFB = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool CJBKMFGOCJO;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding JMALIEKOPIM;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int HNKPMFAANBG = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] HBGACCDFHIK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] PGHMPBDPLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HOBMJDIAKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5340F40", Offset = "0x533FB40", VA = "0x185340F40")]
	public EGIKCGINJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5340EA0", Offset = "0x533FAA0", VA = "0x185340EA0")]
	public EGIKCGINJND(bool PONJDIIMFCM, int NHAAFBFJNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x53402F0", Offset = "0x533EEF0", VA = "0x1853402F0")]
	public static EGIKCGINJND EOOFBKOKHGA(string GCPEEAODAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5340250", Offset = "0x533EE50", VA = "0x185340250")]
	public void CIFAIFMKIMF(int ACOMFCEADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C75310", Offset = "0x1C73F10", VA = "0x181C75310")]
	public void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x53405E0", Offset = "0x533F1E0", VA = "0x1853405E0")]
	public void FJKFMAADOMK(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5340970", Offset = "0x533F570", VA = "0x185340970")]
	public void FJKFMAADOMK(double GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5340430", Offset = "0x533F030", VA = "0x185340430")]
	public void FJKFMAADOMK(long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5340430", Offset = "0x533F030", VA = "0x185340430")]
	public void FJKFMAADOMK(ulong GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5340550", Offset = "0x533F150", VA = "0x185340550")]
	public void FJKFMAADOMK(int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5340550", Offset = "0x533F150", VA = "0x185340550")]
	public void FJKFMAADOMK(uint GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5340890", Offset = "0x533F490", VA = "0x185340890")]
	public void FJKFMAADOMK(char GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5340890", Offset = "0x533F490", VA = "0x185340890")]
	public void FJKFMAADOMK(ushort GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5340890", Offset = "0x533F490", VA = "0x185340890")]
	public void FJKFMAADOMK(short GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x53403D0", Offset = "0x533EFD0", VA = "0x1853403D0")]
	public void FJKFMAADOMK(sbyte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x53403D0", Offset = "0x533EFD0", VA = "0x1853403D0")]
	public void FJKFMAADOMK(byte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5340360", Offset = "0x533EF60", VA = "0x185340360")]
	public void FJKFMAADOMK(byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5340170", Offset = "0x533ED70", VA = "0x185340170")]
	public void CEHPBEJGDEL(sbyte[] IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5340170", Offset = "0x533ED70", VA = "0x185340170")]
	public void BEDJEIFBBON(byte[] IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5340900", Offset = "0x533F500", VA = "0x185340900")]
	public void FJKFMAADOMK(bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5340C60", Offset = "0x533F860", VA = "0x185340C60")]
	public void HFOFMPAFCCN(Array IOACHNEABNH, int PFFLLMJEOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5340AA0", Offset = "0x533F6A0", VA = "0x185340AA0")]
	public void HFOFMPAFCCN(float[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x53409C0", Offset = "0x533F5C0", VA = "0x1853409C0")]
	public void HFOFMPAFCCN(double[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53409C0", Offset = "0x533F5C0", VA = "0x1853409C0")]
	public void HFOFMPAFCCN(long[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x53409C0", Offset = "0x533F5C0", VA = "0x1853409C0")]
	public void HFOFMPAFCCN(ulong[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5340AA0", Offset = "0x533F6A0", VA = "0x185340AA0")]
	public void HFOFMPAFCCN(int[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5340AA0", Offset = "0x533F6A0", VA = "0x185340AA0")]
	public void HFOFMPAFCCN(uint[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5340B80", Offset = "0x533F780", VA = "0x185340B80")]
	public void HFOFMPAFCCN(ushort[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5340B80", Offset = "0x533F780", VA = "0x185340B80")]
	public void HFOFMPAFCCN(short[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5340170", Offset = "0x533ED70", VA = "0x185340170")]
	public void HFOFMPAFCCN(bool[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5340D40", Offset = "0x533F940", VA = "0x185340D40")]
	public void HFOFMPAFCCN(string[] GCPEEAODAIB, int GOAMMGEFCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5340480", Offset = "0x533F080", VA = "0x185340480")]
	public void FJKFMAADOMK(IPEndPoint JJJNJOAKKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5340960", Offset = "0x533F560", VA = "0x185340960")]
	public void FJKFMAADOMK(string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5340680", Offset = "0x533F280", VA = "0x185340680")]
	public void FJKFMAADOMK(string GCPEEAODAIB, int LEEFAANFGJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class LFPNBNMAIJC
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class DMILEGJJCCG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong EFPGBNMCEMM;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4E4CC50", Offset = "0x4E4B850", VA = "0x184E4CC50")]
		static DMILEGJJCCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void GJNHEOBKLIK(OHGDFMEJMNI BIBCAMINPDH, object GMJDOLFFJGC);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class MMAGLJBDMGF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public LFPNBNMAIJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public MMAGLJBDMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3CB7880", Offset = "0x3CB6480", VA = "0x183CB7880")]
		internal void GONEHGMEDIL(OHGDFMEJMNI reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OBKJGIKJKLH<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public LFPNBNMAIJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OBKJGIKJKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3DE7BE0", Offset = "0x3DE67E0", VA = "0x183DE7BE0")]
		internal void GONEHGMEDIL(OHGDFMEJMNI reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly JJLNFBPLIOA DIMMKFNIBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, GJNHEOBKLIK> OMFHGHCKLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly EGIKCGINJND LBCIKFBJDBO;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x53467E0", Offset = "0x53453E0", VA = "0x1853467E0")]
	public LFPNBNMAIJC(int MHJLMGPANNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22B5110", Offset = "0x22B3D10", VA = "0x1822B5110", Slot = "4")]
	protected virtual ulong NHFDEOJCGAA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5346630", Offset = "0x5345230", VA = "0x185346630", Slot = "5")]
	protected virtual GJNHEOBKLIK OMAMLHKPNIL(OHGDFMEJMNI BIBCAMINPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2573EC0", Offset = "0x2572AC0", VA = "0x182573EC0", Slot = "6")]
	protected virtual void BIHLLLJMEBG<T>(EGIKCGINJND BNGNOICJJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5346760", Offset = "0x5345360", VA = "0x185346760")]
	public void POKLBOLFLGJ(OHGDFMEJMNI BIBCAMINPDH, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2573F30", Offset = "0x2572B30", VA = "0x182573F30")]
	public void ENIJDOPIDEK<T>(EGIKCGINJND BNGNOICJJGA, T LEMDNPBNHID) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x53465E0", Offset = "0x53451E0", VA = "0x1853465E0")]
	public void MCKBLBHGGOH(OHGDFMEJMNI BIBCAMINPDH, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2574140", Offset = "0x2572D40", VA = "0x182574140")]
	public void HEFOBJPOIHC<T>(Action<T> PFEIJODLEFB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2573FC0", Offset = "0x2572BC0", VA = "0x182573FC0")]
	public void HEFOBJPOIHC<T, TUserData>(Action<T, TUserData> PFEIJODLEFB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class JDAFCHENPIC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5341DF0", Offset = "0x53409F0", VA = "0x185341DF0")]
	public JDAFCHENPIC(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GBCPMDFKGNC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5341300", Offset = "0x533FF00", VA = "0x185341300")]
	public GBCPMDFKGNC(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JJLNFBPLIOA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum NJMKPNJMOAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class LICGHFFOFJF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public NJMKPNJMOAG IBCFEMEEMGE;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3A40140", Offset = "0x3A3ED40", VA = "0x183A40140", Slot = "4")]
		public virtual void BGGKBEMAPMG(MethodInfo KNKPIHNFCLO, MethodInfo BNAMFAGPGOF, NJMKPNJMOAG OMKEAAPIABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GCCFOFOPAOD(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void MMMCBFFCGAB(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		protected LICGHFFOFJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class BFJCHLBFEMK<TClass, TProperty> : LICGHFFOFJF<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> AFNJJJLGJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> OGKACOGNBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> ABKGIDOKDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> BEDFAPKMNLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> CBOAMHJPAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> IFJFEFKHFED;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4593A20", Offset = "0x4592620", VA = "0x184593A20", Slot = "7")]
		public override void KAKHIABLMNP(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4593400", Offset = "0x4592000", VA = "0x184593400", Slot = "8")]
		public override void IJDHJAAJNCP(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45927C0", Offset = "0x45913C0", VA = "0x1845927C0", Slot = "9")]
		public override void GCCFOFOPAOD(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x45943C0", Offset = "0x4592FC0", VA = "0x1845943C0", Slot = "10")]
		public override void MMMCBFFCGAB(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4592030", Offset = "0x4590C30", VA = "0x184592030")]
		protected TProperty[] CACGPKGLKIG(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4592130", Offset = "0x4590D30", VA = "0x184592130")]
		protected TProperty[] CHBKJBNHIGH(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x458DB30", Offset = "0x458C730", VA = "0x18458DB30", Slot = "4")]
		public override void BGGKBEMAPMG(MethodInfo KNKPIHNFCLO, MethodInfo BNAMFAGPGOF, NJMKPNJMOAG OMKEAAPIABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3731E80", Offset = "0x3730A80", VA = "0x183731E80")]
		protected BFJCHLBFEMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class IIKBHANPHMP<TClass, TProperty> : BFJCHLBFEMK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void NGBEJKBKDIB(OHGDFMEJMNI OIPEAFPNBJB, [Out] TProperty MMLGHJLGAJI);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void PIMNFEHCCDC(EGIKCGINJND NGJMGEHADAK, TProperty MMLGHJLGAJI);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3737CE0", Offset = "0x37368E0", VA = "0x183737CE0", Slot = "5")]
		public override void LIBJDCJDILJ(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3737980", Offset = "0x3736580", VA = "0x183737980", Slot = "6")]
		public override void ENIJDOPIDEK(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3737BA0", Offset = "0x37367A0", VA = "0x183737BA0", Slot = "7")]
		public override void KAKHIABLMNP(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3737B00", Offset = "0x3736700", VA = "0x183737B00", Slot = "8")]
		public override void IJDHJAAJNCP(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3737DE0", Offset = "0x37369E0", VA = "0x183737DE0")]
		protected IIKBHANPHMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class AHAPFAECPOC<T> : BFJCHLBFEMK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x35F4500", Offset = "0x35F3100", VA = "0x1835F4500", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x35F43D0", Offset = "0x35F2FD0", VA = "0x1835F43D0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x35F4490", Offset = "0x35F3090", VA = "0x1835F4490", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x35F4430", Offset = "0x35F3030", VA = "0x1835F4430", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public AHAPFAECPOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class JMFNJLMBEFK<T> : BFJCHLBFEMK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x391BDE0", Offset = "0x391A9E0", VA = "0x18391BDE0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x35F43D0", Offset = "0x35F2FD0", VA = "0x1835F43D0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x391BD70", Offset = "0x391A970", VA = "0x18391BD70", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x35F4430", Offset = "0x35F3030", VA = "0x1835F4430", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public JMFNJLMBEFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ANBMNLFGBEI<T> : BFJCHLBFEMK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x371F520", Offset = "0x371E120", VA = "0x18371F520", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x367C3C0", Offset = "0x367AFC0", VA = "0x18367C3C0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x371F4B0", Offset = "0x371E0B0", VA = "0x18371F4B0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x367C420", Offset = "0x367B020", VA = "0x18367C420", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public ANBMNLFGBEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HJKNOKJIILN<T> : BFJCHLBFEMK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x367C4F0", Offset = "0x367B0F0", VA = "0x18367C4F0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x367C3C0", Offset = "0x367AFC0", VA = "0x18367C3C0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x367C480", Offset = "0x367B080", VA = "0x18367C480", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x367C420", Offset = "0x367B020", VA = "0x18367C420", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public HJKNOKJIILN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FDBCIIHIOFG<T> : BFJCHLBFEMK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x34CA950", Offset = "0x34C9550", VA = "0x1834CA950", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x34CA820", Offset = "0x34C9420", VA = "0x1834CA820", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x34CA8E0", Offset = "0x34C94E0", VA = "0x1834CA8E0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x34CA880", Offset = "0x34C9480", VA = "0x1834CA880", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public FDBCIIHIOFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OIKNPGAPNBN<T> : BFJCHLBFEMK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3E00080", Offset = "0x3DFEC80", VA = "0x183E00080", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x34CA820", Offset = "0x34C9420", VA = "0x1834CA820", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3E00010", Offset = "0x3DFEC10", VA = "0x183E00010", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x34CA880", Offset = "0x34C9480", VA = "0x1834CA880", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public OIKNPGAPNBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class ODONAPAKMPD<T> : BFJCHLBFEMK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3726D40", Offset = "0x3725940", VA = "0x183726D40", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3726C70", Offset = "0x3725870", VA = "0x183726C70", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE510", Offset = "0x3DED110", VA = "0x183DEE510", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x35C6D70", Offset = "0x35C5970", VA = "0x1835C6D70", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public ODONAPAKMPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class AOHAHMIAMNK<T> : BFJCHLBFEMK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3726D40", Offset = "0x3725940", VA = "0x183726D40", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3726C70", Offset = "0x3725870", VA = "0x183726C70", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3726CD0", Offset = "0x37258D0", VA = "0x183726CD0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x35C6D70", Offset = "0x35C5970", VA = "0x1835C6D70", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public AOHAHMIAMNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class NMOHOJKPKEA<T> : BFJCHLBFEMK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D2E0", Offset = "0x3D2BEE0", VA = "0x183D2D2E0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D210", Offset = "0x3D2BE10", VA = "0x183D2D210", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D270", Offset = "0x3D2BE70", VA = "0x183D2D270", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x35F4430", Offset = "0x35F3030", VA = "0x1835F4430", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public NMOHOJKPKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NAHIFHLBODB<T> : BFJCHLBFEMK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8840", Offset = "0x3CF7440", VA = "0x183CF8840", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8770", Offset = "0x3CF7370", VA = "0x183CF8770", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CF87D0", Offset = "0x3CF73D0", VA = "0x183CF87D0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x34CA880", Offset = "0x34C9480", VA = "0x1834CA880", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public NAHIFHLBODB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GJLIDHLGABP<T> : BFJCHLBFEMK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x35C6E40", Offset = "0x35C5A40", VA = "0x1835C6E40", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x35C6D10", Offset = "0x35C5910", VA = "0x1835C6D10", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x35C6DD0", Offset = "0x35C59D0", VA = "0x1835C6DD0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x35C6D70", Offset = "0x35C5970", VA = "0x1835C6D70", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x34CA9C0", Offset = "0x34C95C0", VA = "0x1834CA9C0")]
		public GJLIDHLGABP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class JIOCNCCBOGB<T> : IIKBHANPHMP<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3912100", Offset = "0x3910D00", VA = "0x183912100", Slot = "12")]
		protected override void PIMNFEHCCDC(EGIKCGINJND NGJMGEHADAK, char MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x39120D0", Offset = "0x3910CD0", VA = "0x1839120D0", Slot = "11")]
		protected override void NGBEJKBKDIB(OHGDFMEJMNI OIPEAFPNBJB, [Out] char MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x318D410", Offset = "0x318C010", VA = "0x18318D410")]
		public JIOCNCCBOGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class AHPFJLPLOAJ<T> : IIKBHANPHMP<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x35F63E0", Offset = "0x35F4FE0", VA = "0x1835F63E0", Slot = "12")]
		protected override void PIMNFEHCCDC(EGIKCGINJND NGJMGEHADAK, IPEndPoint MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x35F63A0", Offset = "0x35F4FA0", VA = "0x1835F63A0", Slot = "11")]
		protected override void NGBEJKBKDIB(OHGDFMEJMNI OIPEAFPNBJB, [Out] IPEndPoint MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x318D410", Offset = "0x318C010", VA = "0x18318D410")]
		public AHPFJLPLOAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class HMKNKGJMKHL<T> : BFJCHLBFEMK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int CJKACDAGINB;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x367FF40", Offset = "0x367EB40", VA = "0x18367FF40")]
		public HMKNKGJMKHL(int LEEFAANFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x367FED0", Offset = "0x367EAD0", VA = "0x18367FED0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x367FD80", Offset = "0x367E980", VA = "0x18367FD80", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x367FE60", Offset = "0x367EA60", VA = "0x18367FE60", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x367FDF0", Offset = "0x367E9F0", VA = "0x18367FDF0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class DKCGOMIEDBL<T> : LICGHFFOFJF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo IIHOCPJOOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type KFFPMDBDLMC;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BFD0", Offset = "0x4E4ABD0", VA = "0x184E4BFD0")]
		public DKCGOMIEDBL(PropertyInfo IEIEKFIPLEG, Type LJLCBMBCFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BEB0", Offset = "0x4E4AAB0", VA = "0x184E4BEB0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BCE0", Offset = "0x4E4A8E0", VA = "0x184E4BCE0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BE50", Offset = "0x4E4AA50", VA = "0x184E4BE50", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BDF0", Offset = "0x4E4A9F0", VA = "0x184E4BDF0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BD90", Offset = "0x4E4A990", VA = "0x184E4BD90", Slot = "9")]
		public override void GCCFOFOPAOD(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BF70", Offset = "0x4E4AB70", VA = "0x184E4BF70", Slot = "10")]
		public override void MMMCBFFCGAB(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class KCBBFNOGKHL<T> : DKCGOMIEDBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x372A1C0", Offset = "0x3728DC0", VA = "0x18372A1C0")]
		public KCBBFNOGKHL(PropertyInfo IEIEKFIPLEG, Type LJLCBMBCFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x396D310", Offset = "0x396BF10", VA = "0x18396D310", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x396D260", Offset = "0x396BE60", VA = "0x18396D260", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class KKGECAPCAHL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static KKGECAPCAHL<T> IDAIJJLMAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly LICGHFFOFJF<T>[] OPNLOLLCBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int KKENPPAFNDG;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3984930", Offset = "0x3983530", VA = "0x183984930")]
		public KKGECAPCAHL(List<LICGHFFOFJF<T>> GNMCHNDEKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x39847D0", Offset = "0x39833D0", VA = "0x1839847D0")]
		public void ENIJDOPIDEK(T IIFJCGIHMIN, EGIKCGINJND BNGNOICJJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3984880", Offset = "0x3983480", VA = "0x183984880")]
		public void LIBJDCJDILJ(T IIFJCGIHMIN, OHGDFMEJMNI BIBCAMINPDH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class LDMNOMMPCGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract LICGHFFOFJF<T> IOOJPMIEEDI<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private EGIKCGINJND HCGGONEAAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int EKEFHAIPFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, LDMNOMMPCGE> EAGMNJJIIFE;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5341E00", Offset = "0x5340A00", VA = "0x185341E00")]
	public JJLNFBPLIOA(int MHJLMGPANNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2547150", Offset = "0x2545D50", VA = "0x182547150")]
	private KKGECAPCAHL<T> OMJGHAJHEDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22B7D10", Offset = "0x22B6910", VA = "0x1822B7D10")]
	public void CFNGGCOIEBP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2547070", Offset = "0x2545C70", VA = "0x182547070")]
	public bool JFKFFNFOIMD<T>(OHGDFMEJMNI BIBCAMINPDH, T JIGKIEPHJOJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x25470F0", Offset = "0x2545CF0", VA = "0x1825470F0")]
	public void OIIEHDKDHEB<T>(EGIKCGINJND BNGNOICJJGA, T IIFJCGIHMIN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class BDJEKGNDMGA
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime AMNBDBBIKBJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] NKMGLEGFLEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KIOEICMNNPC COFCGDJIDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x53350B0", Offset = "0x5333CB0", VA = "0x1853350B0")]
		get
		{
			return default(KIOEICMNNPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DDJMJMOJAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x53350E0", Offset = "0x5333CE0", VA = "0x1853350E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5335A30", Offset = "0x5334630", VA = "0x185335A30")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AKGMAJEPADA HJMOMBBLICG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5335FA0", Offset = "0x5334BA0", VA = "0x185335FA0")]
		get
		{
			return default(AKGMAJEPADA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5335FD0", Offset = "0x5334BD0", VA = "0x185335FD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JPPLGONGHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5335310", Offset = "0x5333F10", VA = "0x185335310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint FBBDFEJKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5335F20", Offset = "0x5334B20", VA = "0x185335F20")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? EDJKNBIKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5335110", Offset = "0x5333D10", VA = "0x185335110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? PBMFDMMFAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5335D60", Offset = "0x5334960", VA = "0x185335D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? EEIHKLAJPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x53353A0", Offset = "0x5333FA0", VA = "0x1853353A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5335140", Offset = "0x5333D40", VA = "0x185335140")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? BAJHBAAPIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9FCA30", Offset = "0x9FB630", VA = "0x1809FCA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x84EAE0", Offset = "0x84D6E0", VA = "0x18084EAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5336120", Offset = "0x5334D20", VA = "0x185336120")]
	public BDJEKGNDMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5336070", Offset = "0x5334C70", VA = "0x185336070")]
	internal BDJEKGNDMGA(byte[] FEGEJBFJFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5335A70", Offset = "0x5334670", VA = "0x185335A70")]
	public static BDJEKGNDMGA JJAOLHIMNGE(byte[] FEGEJBFJFNG, DateTime DGIEIPEMGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x53355D0", Offset = "0x53341D0", VA = "0x1853355D0")]
	internal void GEBIBIGCBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5335B90", Offset = "0x5334790", VA = "0x185335B90")]
	private void LHPHMKCLKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x53353D0", Offset = "0x5333FD0", VA = "0x1853353D0")]
	private DateTime? FPPOKJNCPDO(int IAKOFEGDGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5335860", Offset = "0x5334460", VA = "0x185335860")]
	private void HAIOJGAKAEM(int IAKOFEGDGBF, DateTime? GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5335D90", Offset = "0x5334990", VA = "0x185335D90")]
	private ulong LKDPCILLOIJ(int IAKOFEGDGBF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5335E60", Offset = "0x5334A60", VA = "0x185335E60")]
	private void NGIMKBIKNHB(int IAKOFEGDGBF, ulong GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x53357D0", Offset = "0x53343D0", VA = "0x1853357D0")]
	private uint GFPMFPPCIMD(int IAKOFEGDGBF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5223CF0", Offset = "0x52228F0", VA = "0x185223CF0")]
	private static uint FHHOENJFEHF(uint HPIMCNPJDMN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5335340", Offset = "0x5333F40", VA = "0x185335340")]
	private static ulong FHHOENJFEHF(ulong HPIMCNPJDMN)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum KIOEICMNNPC
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
public enum AKGMAJEPADA
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class HFDCFLNHFIA
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int MKMNLMCMNAF = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int JHKGKFPKNNA = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int DIJFKLKBNBN = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint GAAIAOFHCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int BLLPPPGOMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int MGMCIBBOHDE;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EAOIGAIMGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x53419E0", Offset = "0x53405E0", VA = "0x1853419E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5341900", Offset = "0x5340500", VA = "0x185341900")]
	public bool IHPIAFADDED(Socket JIDCLJBPKFG, int OJANOJHOJAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class IDPPCNENOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int KCFIFGMJMJD;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
	protected IDPPCNENOJJ(int KJPHEKLKBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void DKFGDAHAPML(IPEndPoint JJJNJOAKKIA, byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void NHDHDJLLMEJ(IPEndPoint JJJNJOAKKIA, byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MHJPACIIACN : IDPPCNENOJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider CHDJABOMAIJ;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator ONELFCBLPOA;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x53498E0", Offset = "0x53484E0", VA = "0x1853498E0")]
	public MHJPACIIACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5348D70", Offset = "0x5347970", VA = "0x185348D70")]
	public void ADIDBFLGJDK(IPEndPoint JJJNJOAKKIA, byte[] PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5349400", Offset = "0x5348000", VA = "0x185349400")]
	public void JJGPKFKEHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5349370", Offset = "0x5347F70", VA = "0x185349370")]
	private byte[] EBKLLPJFPCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5348FB0", Offset = "0x5347BB0", VA = "0x185348FB0", Slot = "4")]
	public override void DKFGDAHAPML(IPEndPoint JJJNJOAKKIA, byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x53494E0", Offset = "0x53480E0", VA = "0x1853494E0", Slot = "5")]
	public override void NHDHDJLLMEJ(IPEndPoint JJJNJOAKKIA, byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG)
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
