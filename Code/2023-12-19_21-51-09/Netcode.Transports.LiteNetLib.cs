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
			[Cpp2IlInjected.Address(RVA = "0x5348240", Offset = "0x5346E40", VA = "0x185348240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5347740", Offset = "0x5346340", VA = "0x185347740")]
		public void RecRoom_SetEncryptionInfo(ulong PKIHEGKIKHL, byte[] PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5347720", Offset = "0x5346320", VA = "0x185347720")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x53475F0", Offset = "0x53461F0", VA = "0x1853475F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5348140", Offset = "0x5346D40", VA = "0x185348140")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5347940", Offset = "0x5346540", VA = "0x185347940", Slot = "6")]
		public override void Send(ulong CKFFDHGOJPM, ArraySegment<byte> IGJLGPELHOJ, NetworkDelivery PJPDBEOBOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x53476E0", Offset = "0x53462E0", VA = "0x1853476E0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong CKFFDHGOJPM, [Out] ArraySegment<byte> AGEBEEELPDJ, [Out] float MBFFLEPNFMI)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5347C30", Offset = "0x5346830", VA = "0x185347C30", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5348060", Offset = "0x5346C60", VA = "0x185348060", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5346C50", Offset = "0x5345850", VA = "0x185346C50", Slot = "10")]
		public override void DisconnectRemoteClient(ulong CKFFDHGOJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5346B00", Offset = "0x5345700", VA = "0x185346B00", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5346F00", Offset = "0x5345B00", VA = "0x185346F00", Slot = "12")]
		public override ulong GetCurrentRtt(ulong CKFFDHGOJPM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5347BC0", Offset = "0x53467C0", VA = "0x185347BC0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5347080", Offset = "0x5345C80", VA = "0x185347080", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MCFDDOGOCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5346A30", Offset = "0x5345630", VA = "0x185346A30")]
		private FJLBHHPJFDB CGMOIINALKJ(NetworkDelivery OMKEAAPIABA)
		{
			return default(FJLBHHPJFDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5346970", Offset = "0x5345570", VA = "0x185346970", Slot = "15")]
		private void CCMEKFFDPPB(LCBIKOKMAOH GIMJPKIOCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5346DC0", Offset = "0x53459C0", VA = "0x185346DC0", Slot = "16")]
		private void GHADNNOHHKH(LCBIKOKMAOH GIMJPKIOCKJ, KCLCNNBAEBG CHDAFPGCJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "17")]
		private void AEMIBKKNIBH(IPEndPoint JJJNJOAKKIA, SocketError LEJGFJFECJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5347240", Offset = "0x5345E40", VA = "0x185347240", Slot = "18")]
		private void JNADPBMBJDA(LCBIKOKMAOH GIMJPKIOCKJ, GJBAJEIPMAP BIBCAMINPDH, byte HCEICOAGHBJ, FJLBHHPJFDB MDAKNPDLMDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5346FA0", Offset = "0x5345BA0", VA = "0x185346FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5347560", Offset = "0x5346160", VA = "0x185347560", Slot = "21")]
		private void OJNJIEENKFJ(JOGCIBGAGFC NFAAJOAMBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53475C0", Offset = "0x53461C0", VA = "0x1853475C0")]
		private ulong ONFIOEIFLGC(LCBIKOKMAOH GIMJPKIOCKJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5347540", Offset = "0x5346140", VA = "0x185347540")]
		private static int MPMBLECKPBM(float FOGEGHJNDKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5348160", Offset = "0x5346D60", VA = "0x185348160")]
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
	[Cpp2IlInjected.Address(RVA = "0x53411D0", Offset = "0x533FDD0", VA = "0x1853411D0")]
	protected FOCAMPDJAPJ(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5341170", Offset = "0x533FD70", VA = "0x185341170")]
	public void NOIIMBKIHEM(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53410B0", Offset = "0x533FCB0", VA = "0x1853410B0")]
	protected void IPGJEBJANFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5341130", Offset = "0x533FD30", VA = "0x185341130")]
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
	[Cpp2IlInjected.Address(RVA = "0x5341E70", Offset = "0x5340A70", VA = "0x185341E70")]
	internal void HMCJNPBLFMJ(KHDGGGOEMIO NFAIGDGAPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5341ED0", Offset = "0x5340AD0", VA = "0x185341ED0")]
	private bool LBNJFDOFNND()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5341F00", Offset = "0x5340B00", VA = "0x185341F00")]
	internal JOGCIBGAGFC(IPEndPoint NCPOLGILGFH, KHDGGGOEMIO FEKLJAIICAE, DDMHGGOOADA FMHAJBIIFBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5341E10", Offset = "0x5340A10", VA = "0x185341E10")]
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
	[Cpp2IlInjected.Address(RVA = "0x53423D0", Offset = "0x5340FD0", VA = "0x1853423D0")]
	private KHDGGGOEMIO(long LLAFEMHCKGP, byte JPCMFGEBBOP, int JMADFINDJPP, byte[] LKPJIMCPIED, OHGDFMEJMNI IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5342370", Offset = "0x5340F70", VA = "0x185342370")]
	public static int LIMDNAPKJDF(MELHHKMHGLO LEMDNPBNHID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5342150", Offset = "0x5340D50", VA = "0x185342150")]
	public static KHDGGGOEMIO JLNHDMIEFPC(MELHHKMHGLO LEMDNPBNHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5341F70", Offset = "0x5340B70", VA = "0x185341F70")]
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
	[Cpp2IlInjected.Address(RVA = "0x534B3B0", Offset = "0x5349FB0", VA = "0x18534B3B0")]
	private OJBDONNJLBE(long LLAFEMHCKGP, byte JPCMFGEBBOP, int IADOMMDPEJD, bool LJFAFGLJDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x534B260", Offset = "0x5349E60", VA = "0x18534B260")]
	public static OJBDONNJLBE JLNHDMIEFPC(MELHHKMHGLO LEMDNPBNHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x534B170", Offset = "0x5349D70", VA = "0x18534B170")]
	public static MELHHKMHGLO IOBHFIBENCL(long KCPMBFJDBFG, byte MAIAGKGIDJO, int DKNAIIOKLAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x534B070", Offset = "0x5349C70", VA = "0x18534B070")]
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
	[Cpp2IlInjected.Address(RVA = "0x5342530", Offset = "0x5341130", VA = "0x185342530")]
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
	[Cpp2IlInjected.Address(RVA = "0x53424F0", Offset = "0x53410F0", VA = "0x1853424F0", Slot = "4")]
	public bool Equals(LADOIJLCDJN LLMHBOEDHFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5342440", Offset = "0x5341040", VA = "0x185342440", Slot = "0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5337BB0", Offset = "0x53367B0", VA = "0x185337BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x534A160", Offset = "0x5348D60", VA = "0x18534A160")]
		public static extern int MNKCKPDDIJA(IntPtr HMIOLIMNMJA, [In][Out] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [Out] byte[] KEJIHBAMMJD, [In][Out] int FCIICENELNO);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x534A2A0", Offset = "0x5348EA0", VA = "0x18534A2A0")]
		internal static extern int OMKOHJNBPEM(IntPtr HMIOLIMNMJA, [In] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [In] byte[] KEJIHBAMMJD, [In] int FCIICENELNO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class DCCKMNJPOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5337990", Offset = "0x5336590", VA = "0x185337990")]
		public static extern int MNKCKPDDIJA(IntPtr HMIOLIMNMJA, [In][Out] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [Out] byte[] KEJIHBAMMJD, [In][Out] int FCIICENELNO);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5337AD0", Offset = "0x53366D0", VA = "0x185337AD0")]
		internal static extern int OMKOHJNBPEM(IntPtr HMIOLIMNMJA, [In] byte[] LIIILIBDKGI, [In] int DGNJGLBHMAI, [In] SocketFlags AHJBHPFEPEL, [In] byte[] KEJIHBAMMJD, [In] int FCIICENELNO);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool MCMJBMGCNJL;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool AGAGMJNMFFK;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> EPPCDKNNKEG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5337330", Offset = "0x5335F30", VA = "0x185337330")]
	static DANDOAPFFAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5336F00", Offset = "0x5335B00", VA = "0x185336F00")]
	public static int DGILBCKBNKH(IntPtr HMIOLIMNMJA, byte[] LIIILIBDKGI, int DGNJGLBHMAI, byte[] KEJIHBAMMJD, int FCIICENELNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5336FB0", Offset = "0x5335BB0", VA = "0x185336FB0")]
	public static int IPOEEKNJEKH(IntPtr HMIOLIMNMJA, byte[] LIIILIBDKGI, int DGNJGLBHMAI, byte[] KEJIHBAMMJD, int FCIICENELNO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5336E10", Offset = "0x5335A10", VA = "0x185336E10")]
	public static SocketError ALKLPOPJECF()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x53371F0", Offset = "0x5335DF0", VA = "0x1853371F0")]
	public static SocketException PHOAPLBJOEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5337140", Offset = "0x5335D40", VA = "0x185337140")]
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
	[Cpp2IlInjected.Address(RVA = "0x53369C0", Offset = "0x53355C0", VA = "0x1853369C0")]
	internal CDCIPDFFHMJ(DDMHGGOOADA JIDCLJBPKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x53363B0", Offset = "0x5334FB0", VA = "0x1853363B0")]
	internal void CEIDEBDFDHC(IPEndPoint BOFJKGJAKDF, MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x234E3C0", Offset = "0x234CFC0", VA = "0x18234E3C0")]
	private void IHPIAFADDED<T>(T LEMDNPBNHID, IPEndPoint JIGKIEPHJOJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5336510", Offset = "0x5335110", VA = "0x185336510")]
	private void FKHDPDHGIFF(FMAMHIDGJLF HLLLCECEGLD, IPEndPoint BOFJKGJAKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x53366A0", Offset = "0x53352A0", VA = "0x1853366A0")]
	private void HDOOHNPJJCD(ABINGFHBPCN HLLLCECEGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5336820", Offset = "0x5335420", VA = "0x185336820")]
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
	[Cpp2IlInjected.Address(RVA = "0x5341D60", Offset = "0x5340960", VA = "0x185341D60")]
	public OOOCEKNDHEP(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MPMGBDEJAEB : OOOCEKNDHEP
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5341D60", Offset = "0x5340960", VA = "0x185341D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5341A80", Offset = "0x5340680", VA = "0x185341A80")]
	private static void OFAGCEDJHKI(EHABONPPDEA ECFFOADKMGI, string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5341960", Offset = "0x5340560", VA = "0x185341960")]
	internal static void BFHKOPDBHFK(string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5341A20", Offset = "0x5340620", VA = "0x185341A20")]
	internal static void JFOLOKJBOCC(string JMMCCECHKKL, params object[] ODENEMACEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x53419C0", Offset = "0x53405C0", VA = "0x1853419C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53413F0", Offset = "0x533FFF0", VA = "0x1853413F0")]
	internal GJBAJEIPMAP(DDMHGGOOADA CEICFMOFGAN, NEOONCNLKDN CHPCBMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5341380", Offset = "0x533FF80", VA = "0x185341380")]
	internal void GOCGCPHFMHK(MELHHKMHGLO LEMDNPBNHID, int KEKIIDNOHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5341300", Offset = "0x533FF00", VA = "0x185341300")]
	internal void GNAGPCCKOPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x53412D0", Offset = "0x533FED0", VA = "0x1853412D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x534A380", Offset = "0x5348F80", VA = "0x18534A380")]
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
		[Cpp2IlInjected.Address(RVA = "0x5342620", Offset = "0x5341220", VA = "0x185342620", Slot = "4")]
		public bool Equals(IPEndPoint HPIMCNPJDMN, IPEndPoint BKLHNKCOAIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4E5C380", Offset = "0x4E5AF80", VA = "0x184E5C380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x53468D0", Offset = "0x53454D0", VA = "0x1853468D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5346920", Offset = "0x5345520", VA = "0x185346920", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x533AB00", Offset = "0x5339700", VA = "0x18533AB00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short BHLHAHBKLEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x533D230", Offset = "0x533BE30", VA = "0x18533D230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x533B780", Offset = "0x533A380", VA = "0x18533B780")]
	public void FCAIIBKDLOM(IPEndPoint JJJNJOAKKIA, byte[] PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x533CE20", Offset = "0x533BA20", VA = "0x18533CE20")]
	public void KMGKDLPLFPH(IPEndPoint JJJNJOAKKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5338090", Offset = "0x5336C90", VA = "0x185338090")]
	private bool AHAJCBPBKML(IPEndPoint JJJNJOAKKIA, [Out] LCBIKOKMAOH GIMJPKIOCKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x533CF70", Offset = "0x533BB70", VA = "0x18533CF70")]
	private void LAOHKMFEAKF(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x533EB40", Offset = "0x533D740", VA = "0x18533EB40")]
	private void PAGNPFPGAPO(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x533BA40", Offset = "0x533A640", VA = "0x18533BA40")]
	private void GPLHDAOBNGI(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x533F520", Offset = "0x533E120", VA = "0x18533F520")]
	public DDMHGGOOADA(CFPOLJKHGFO FMHAJBIIFBA, [Optional] IDPPCNENOJJ APFGNNGJFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x533E9C0", Offset = "0x533D5C0", VA = "0x18533E9C0")]
	internal void NPAOACPFLOK(LCBIKOKMAOH EICNOKHKBHA, int DHJGECOICJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x533E970", Offset = "0x533D570", VA = "0x18533E970")]
	internal void NOJMCPOALEO(LCBIKOKMAOH EICNOKHKBHA, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5338DB0", Offset = "0x53379B0", VA = "0x185338DB0")]
	internal void BEGMMICGJKH(LCBIKOKMAOH GIMJPKIOCKJ, IKCKNNLKPJG OKDGKAJLADI, SocketError GNBCBJJLKCC, MELHHKMHGLO DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x533B2E0", Offset = "0x5339EE0", VA = "0x18533B2E0")]
	private void EFDEDAGGFGJ(LCBIKOKMAOH GIMJPKIOCKJ, IKCKNNLKPJG OKDGKAJLADI, SocketError GNBCBJJLKCC, bool JNADMECNEPO, byte[] IGJLGPELHOJ, int DIOBLODNDCP, int EMHEDPDPEMP, MELHHKMHGLO DCCNFPKPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x533A740", Offset = "0x5339340", VA = "0x18533A740")]
	private void DICDLLDCLEP(NEOONCNLKDN.KHFBEFPOMAH OMKEAAPIABA, [Optional] LCBIKOKMAOH GIMJPKIOCKJ, [Optional] IPEndPoint NCPOLGILGFH, SocketError CDPNJMLAOAG = SocketError.Success, int DHJGECOICJM = 0, IKCKNNLKPJG FBKEDIJKCMN = IKCKNNLKPJG.ConnectionFailed, [Optional] JOGCIBGAGFC ICOJCNJEGAK, FJLBHHPJFDB MDAKNPDLMDO = FJLBHHPJFDB.Unreliable, byte HCEICOAGHBJ = 0, [Optional] MELHHKMHGLO JMPLADEJELN, [Optional] object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x533AB20", Offset = "0x5339720", VA = "0x18533AB20")]
	private void ECHNMPNKIAI(NEOONCNLKDN CHPCBMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x533A640", Offset = "0x5339240", VA = "0x18533A640")]
	internal void DAEMGHMCBDA(NEOONCNLKDN CHPCBMANOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x533F000", Offset = "0x533DC00", VA = "0x18533F000")]
	private void POBKLEHMIHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x533E4E0", Offset = "0x533D0E0", VA = "0x18533E4E0")]
	private void MJHEFBBLHND(int NDGAICDGCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x533C5E0", Offset = "0x533B1E0", VA = "0x18533C5E0")]
	internal LCBIKOKMAOH JKNJPMPLHDJ(JOGCIBGAGFC NFAAJOAMBMN, byte[] HFEKMKNKAIK, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x533B9C0", Offset = "0x533A5C0", VA = "0x18533B9C0")]
	private int GOEFFKDMDKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x533BFC0", Offset = "0x533ABC0", VA = "0x18533BFC0")]
	private void HDMDCAAGMEC(IPEndPoint NCPOLGILGFH, LCBIKOKMAOH FAIDIGEDACC, KHDGGGOEMIO CBNLCMCNFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5339750", Offset = "0x5338350", VA = "0x185339750")]
	private void CDMOJICMBAL(MELHHKMHGLO LEMDNPBNHID, IPEndPoint NCPOLGILGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x533BCA0", Offset = "0x533A8A0", VA = "0x18533BCA0")]
	internal void HDEKBMLNEFE(MELHHKMHGLO LEMDNPBNHID, FJLBHHPJFDB OLBMKOEFGHO, byte HCEICOAGHBJ, int KEKIIDNOHLK, LCBIKOKMAOH EICNOKHKBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x533D260", Offset = "0x533BE60", VA = "0x18533D260")]
	public bool LLDDGFIBKDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x533D270", Offset = "0x533BE70", VA = "0x18533D270")]
	public bool LLDDGFIBKDD(IPAddress NELCBFMIKEF, IPAddress HJMMFDBHPKE, int FJMLIBPECDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x533D290", Offset = "0x533BE90", VA = "0x18533D290")]
	public bool LLDDGFIBKDD(int FJMLIBPECDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x533B820", Offset = "0x533A420", VA = "0x18533B820")]
	public void FMKIADFPCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x533E310", Offset = "0x533CF10", VA = "0x18533E310")]
	public LCBIKOKMAOH MEJOJPFNBBN(string NNKFDPENBOP, int FJMLIBPECDL, string PPNDANAOAMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x533DE60", Offset = "0x533CA60", VA = "0x18533DE60")]
	public LCBIKOKMAOH MEJOJPFNBBN(string NNKFDPENBOP, int FJMLIBPECDL, EGIKCGINJND BCKHPAAIMBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x533DF40", Offset = "0x533CB40", VA = "0x18533DF40")]
	public LCBIKOKMAOH MEJOJPFNBBN(IPEndPoint JIGKIEPHJOJ, EGIKCGINJND BCKHPAAIMBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53391A0", Offset = "0x5337DA0", VA = "0x1853391A0")]
	public void BOBCBCFKKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5338E80", Offset = "0x5337A80", VA = "0x185338E80")]
	public void BOBCBCFKKIH(bool MJIIKENNGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x533CC00", Offset = "0x533B800", VA = "0x18533CC00")]
	public void KDGBNDJNNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x533CD00", Offset = "0x533B900", VA = "0x18533CD00")]
	public void KDGBNDJNNDI(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x533B3C0", Offset = "0x5339FC0", VA = "0x18533B3C0")]
	public void EFDEDAGGFGJ(LCBIKOKMAOH GIMJPKIOCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x533B470", Offset = "0x533A070", VA = "0x18533B470")]
	public void EFDEDAGGFGJ(LCBIKOKMAOH GIMJPKIOCKJ, byte[] IGJLGPELHOJ, int DIOBLODNDCP, int EMHEDPDPEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x533F340", Offset = "0x533DF40", VA = "0x18533F340", Slot = "4")]
	private IEnumerator<LCBIKOKMAOH> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x533F3D0", Offset = "0x533DFD0", VA = "0x18533F3D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5337EC0", Offset = "0x5336AC0", VA = "0x185337EC0")]
	private MELHHKMHGLO ADJGCDKGPMJ(GJHGGAILMFI IEIEKFIPLEG, int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5337FB0", Offset = "0x5336BB0", VA = "0x185337FB0")]
	private MELHHKMHGLO ADJGCDKGPMJ(GJHGGAILMFI IEIEKFIPLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x533C420", Offset = "0x533B020", VA = "0x18533C420")]
	internal MELHHKMHGLO IEHDBJGLLMH(int JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x533E800", Offset = "0x533D400", VA = "0x18533E800")]
	internal void MKNBMNOGIMA(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x533F460", Offset = "0x533E060", VA = "0x18533F460")]
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
	[Cpp2IlInjected.Address(RVA = "0x533E3F0", Offset = "0x533CFF0", VA = "0x18533E3F0")]
	private void MENNCDOAOEL(IPEndPoint CKIBONKJEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x533EF20", Offset = "0x533DB20", VA = "0x18533EF20")]
	private void PJFECPMCBGP(IPEndPoint CKIBONKJEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x533A4A0", Offset = "0x53390A0", VA = "0x18533A4A0")]
	private bool CPMILBCONFH(SocketException GDDKLHPPIHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x533B530", Offset = "0x533A130", VA = "0x18533B530")]
	private void EGOAPNBFOGK(Socket JIDCLJBPKFG, EndPoint CLMBKBLHMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x533EB90", Offset = "0x533D790", VA = "0x18533EB90")]
	private void PJDJLJPBDOK(object FPIEOLNLDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x533DAF0", Offset = "0x533C6F0", VA = "0x18533DAF0")]
	private void MCGLJFHAONB(object FPIEOLNLDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x533D310", Offset = "0x533BF10", VA = "0x18533D310")]
	public bool LLDDGFIBKDD(IPAddress NELCBFMIKEF, IPAddress HJMMFDBHPKE, int FJMLIBPECDL, bool NOKNDDEFCKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x53391B0", Offset = "0x5337DB0", VA = "0x1853391B0")]
	private bool CDDIDJGEJHE(Socket JIDCLJBPKFG, IPEndPoint CKIBONKJEFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x533BF60", Offset = "0x533AB60", VA = "0x18533BF60")]
	internal int HDHEOGOFAFP(MELHHKMHGLO LEMDNPBNHID, IPEndPoint NCPOLGILGFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5338D70", Offset = "0x5337970", VA = "0x185338D70")]
	internal int AJNOPGHIIIP(MELHHKMHGLO LEMDNPBNHID, IPEndPoint NCPOLGILGFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5338120", Offset = "0x5336D20", VA = "0x185338120")]
	internal int AJNOPGHIIIP(byte[] EOOPGFAEMIH, int DIOBLODNDCP, int NBJKCBMEDIG, IPEndPoint NCPOLGILGFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x533EA10", Offset = "0x533D610", VA = "0x18533EA10")]
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
		[Cpp2IlInjected.Address(RVA = "0x53485A0", Offset = "0x53471A0", VA = "0x1853485A0")]
		get
		{
			return default(GJHGGAILMFI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5348740", Offset = "0x5347340", VA = "0x185348740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte DEIOCOONNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5348670", Offset = "0x5347270", VA = "0x185348670")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x53485D0", Offset = "0x53471D0", VA = "0x1853485D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LFOCNGKIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5348610", Offset = "0x5347210", VA = "0x185348610")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5348300", Offset = "0x5346F00", VA = "0x185348300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MMJKEBFHDPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x53486A0", Offset = "0x53472A0", VA = "0x1853486A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte NFHFKAIMHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5348510", Offset = "0x5347110", VA = "0x185348510")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5348340", Offset = "0x5346F40", VA = "0x185348340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort OEKNJKBPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5348540", Offset = "0x5347140", VA = "0x185348540")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x53482C0", Offset = "0x5346EC0", VA = "0x1853482C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MOAOLEOCNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5348260", Offset = "0x5346E60", VA = "0x185348260")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x53486D0", Offset = "0x53472D0", VA = "0x1853486D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort LIKAMLCKAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5348470", Offset = "0x5347070", VA = "0x185348470")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x53484D0", Offset = "0x53470D0", VA = "0x1853484D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5348880", Offset = "0x5347480", VA = "0x185348880")]
	static MELHHKMHGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5348710", Offset = "0x5347310", VA = "0x185348710")]
	public void MFAMFGCCLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5348C70", Offset = "0x5347870", VA = "0x185348C70")]
	public MELHHKMHGLO(int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5348B60", Offset = "0x5347760", VA = "0x185348B60")]
	public MELHHKMHGLO(GJHGGAILMFI IEIEKFIPLEG, int JIGGJNDJAAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5348370", Offset = "0x5346F70", VA = "0x185348370")]
	public static int DJAHKOIKHAM(GJHGGAILMFI IEIEKFIPLEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x53483E0", Offset = "0x5346FE0", VA = "0x1853483E0")]
	public int DJAHKOIKHAM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5348780", Offset = "0x5347380", VA = "0x185348780")]
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
		[Cpp2IlInjected.Address(RVA = "0x53436F0", Offset = "0x53422F0", VA = "0x1853436F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5342940", Offset = "0x5341540", VA = "0x185342940")]
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
		[Cpp2IlInjected.Address(RVA = "0x5342950", Offset = "0x5341550", VA = "0x185342950")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5344CF0", Offset = "0x53438F0", VA = "0x185344CF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5345F60", Offset = "0x5344B60", VA = "0x185345F60")]
	internal LCBIKOKMAOH(DDMHGGOOADA MIGLECEPOOA, IPEndPoint NCPOLGILGFH, int HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5342690", Offset = "0x5341290", VA = "0x185342690")]
	internal void AGFLDAMKNMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5342B40", Offset = "0x5341740", VA = "0x185342B40")]
	internal void FKOCAEFHDPK(IPEndPoint JMFKHCKMIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5342AB0", Offset = "0x53416B0", VA = "0x185342AB0")]
	internal void ELIFMCELOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5343AE0", Offset = "0x53426E0", VA = "0x185343AE0")]
	private void IMOPBAEHIFI(int BMGCADMEBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5342B70", Offset = "0x5341770", VA = "0x185342B70")]
	private void GBJBMBIBKNH(int LBHEICCHIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5342790", Offset = "0x5341390", VA = "0x185342790")]
	private FOCAMPDJAPJ CNOLCLCBNPK(byte EANIEPCFJGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x53463C0", Offset = "0x5344FC0", VA = "0x1853463C0")]
	internal LCBIKOKMAOH(DDMHGGOOADA MIGLECEPOOA, IPEndPoint NCPOLGILGFH, int HLINMGJJNHD, byte MAIAGKGIDJO, EGIKCGINJND NMCHGAMOCMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5345D80", Offset = "0x5344980", VA = "0x185345D80")]
	internal LCBIKOKMAOH(DDMHGGOOADA MIGLECEPOOA, JOGCIBGAGFC NFAAJOAMBMN, int HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5344180", Offset = "0x5342D80", VA = "0x185344180")]
	internal void JOMPKANDAAC(KHDGGGOEMIO KHBNMABHMNP, byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5344100", Offset = "0x5342D00", VA = "0x185344100")]
	internal bool JHABNPLGPPH(OJBDONNJLBE LEMDNPBNHID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x53437A0", Offset = "0x53423A0", VA = "0x1853437A0")]
	public void IHPIAFADDED(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG, FJLBHHPJFDB MCIMANHECMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x53453C0", Offset = "0x5343FC0", VA = "0x1853453C0")]
	private void PIIIKGMMKEA(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG, byte HCEICOAGHBJ, FJLBHHPJFDB MDAKNPDLMDO, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5342A00", Offset = "0x5341600", VA = "0x185342A00")]
	public void EKILCNCBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x53426B0", Offset = "0x53412B0", VA = "0x1853426B0")]
	internal MJGPDBBPLFH CALENLKNGJF(MELHHKMHGLO LEMDNPBNHID)
	{
		return default(MJGPDBBPLFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5344DA0", Offset = "0x53439A0", VA = "0x185344DA0")]
	internal void LLGMNGBFEDJ(FOCAMPDJAPJ NIFEIEHLCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x53437D0", Offset = "0x53423D0", VA = "0x1853437D0")]
	internal JHJHLLKMCMP IJCEPGANLGJ(byte[] IGJLGPELHOJ, int DIOBLODNDCP, int NBJKCBMEDIG, bool JNADMECNEPO)
	{
		return default(JHJHLLKMCMP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5344E00", Offset = "0x5343A00", VA = "0x185344E00")]
	private void NIHKKHNHCON(int NAJBFHOJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5342D60", Offset = "0x5341960", VA = "0x185342D60")]
	internal void HFGNGHDLBBG(FJLBHHPJFDB OLBMKOEFGHO, MELHHKMHGLO BPDGEJEAOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5343BB0", Offset = "0x53427B0", VA = "0x185343BB0")]
	private void IPOMNEJHOBC(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x53441D0", Offset = "0x5342DD0", VA = "0x1853441D0")]
	private void KIMMPLLMLEO(int MMHFADIOONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5342BA0", Offset = "0x53417A0", VA = "0x185342BA0")]
	internal AIDHCBOHNGM HDMDCAAGMEC(KHDGGGOEMIO CBNLCMCNFIA)
	{
		return default(AIDHCBOHNGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5344640", Offset = "0x5343240", VA = "0x185344640")]
	internal void LDKJCJPLGBA(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5344540", Offset = "0x5343140", VA = "0x185344540")]
	private void KLCAIBHAMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5345910", Offset = "0x5344510", VA = "0x185345910")]
	internal void PJIFNCOLAAB(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5344E40", Offset = "0x5343A40", VA = "0x185344E40")]
	internal void OFENLADEDFE(int MMHFADIOONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5345AC0", Offset = "0x53446C0", VA = "0x185345AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5341510", Offset = "0x5340110", VA = "0x185341510")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long CPMAEPKKLFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5341520", Offset = "0x5340120", VA = "0x185341520")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long OCIANLMAHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x53414C0", Offset = "0x53400C0", VA = "0x1853414C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long MFDFPAMOBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x53414E0", Offset = "0x53400E0", VA = "0x1853414E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MMBGBDPFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x53414F0", Offset = "0x53400F0", VA = "0x1853414F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CEDHGLJNIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5341450", Offset = "0x5340050", VA = "0x185341450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x53414B0", Offset = "0x53400B0", VA = "0x1853414B0")]
	public void EJPPMBGDNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x53414A0", Offset = "0x53400A0", VA = "0x1853414A0")]
	public void DLOCNJOBEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x53414D0", Offset = "0x53400D0", VA = "0x1853414D0")]
	public void GIKDBIFDDMH(long AJMALKNENLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5341440", Offset = "0x5340040", VA = "0x185341440")]
	public void AAMDJDGCOEP(long MIOLDMLFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5341530", Offset = "0x5340130", VA = "0x185341530")]
	public void PLCIMGGGNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5341500", Offset = "0x5340100", VA = "0x185341500")]
	public void JEPJBJHHEBK(long NCALHFGGJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5341540", Offset = "0x5340140", VA = "0x185341540", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x533FB70", Offset = "0x533E770", VA = "0x18533FB70")]
	public static IPEndPoint GDKNDPJDIAE(string MGFKKALOBJK, int FJMLIBPECDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x533FE80", Offset = "0x533EA80", VA = "0x18533FE80")]
	public static IPAddress PPHNANBDFAJ(string MGFKKALOBJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x533FDF0", Offset = "0x533E9F0", VA = "0x18533FDF0")]
	public static IPAddress PPHNANBDFAJ(string MGFKKALOBJK, AddressFamily CCJKPPFLFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x533FDC0", Offset = "0x533E9C0", VA = "0x18533FDC0")]
	internal static int MMIFEJAHMNC(int JEIBBCEGCBO, int GLFGEBKCMID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2385420", Offset = "0x2384020", VA = "0x182385420")]
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
		[Cpp2IlInjected.Address(RVA = "0x5341010", Offset = "0x533FC10", VA = "0x185341010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5340F30", Offset = "0x533FB30", VA = "0x185340F30")]
		public void BGGKBEMAPMG(MELHHKMHGLO LEMDNPBNHID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5340F50", Offset = "0x533FB50", VA = "0x185340F50")]
		public bool GEAAINPDGHJ(long MKJMBIGEENJ, LCBIKOKMAOH GIMJPKIOCKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5340FC0", Offset = "0x533FBC0", VA = "0x185340FC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5334E50", Offset = "0x5333A50", VA = "0x185334E50")]
	public AFHILOFPCFD(LCBIKOKMAOH GIMJPKIOCKJ, bool GLJBKFECNJL, byte HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5333F90", Offset = "0x5332B90", VA = "0x185333F90")]
	private void BCCDFKOODJO(MELHHKMHGLO LEMDNPBNHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x53349A0", Offset = "0x53335A0", VA = "0x1853349A0", Slot = "4")]
	protected override bool MBKFGPGLGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5334340", Offset = "0x5332F40", VA = "0x185334340", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5349FC0", Offset = "0x5348BC0", VA = "0x185349FC0")]
	public MIGCAEAPJKP(LCBIKOKMAOH GIMJPKIOCKJ, bool DBFGBNFNPLJ, byte HLINMGJJNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5349B50", Offset = "0x5348750", VA = "0x185349B50", Slot = "4")]
	protected override bool MBKFGPGLGEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5349870", Offset = "0x5348470", VA = "0x185349870", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x5333CA0", Offset = "0x53328A0", VA = "0x185333CA0")]
	private static void BFIGDGMBEPH(byte[] NJCBLCELFEN, int IAKOFEGDGBF, ulong IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5333E70", Offset = "0x5332A70", VA = "0x185333E70")]
	private static void BFIGDGMBEPH(byte[] NJCBLCELFEN, int IAKOFEGDGBF, int IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5333E30", Offset = "0x5332A30", VA = "0x185333E30")]
	public static void BFIGDGMBEPH(byte[] NJCBLCELFEN, int IAKOFEGDGBF, short IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5333F70", Offset = "0x5332B70", VA = "0x185333F70")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, double GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5333EF0", Offset = "0x5332AF0", VA = "0x185333EF0")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5333E30", Offset = "0x5332A30", VA = "0x185333E30")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, short GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5333E30", Offset = "0x5332A30", VA = "0x185333E30")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, ushort GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5333E70", Offset = "0x5332A70", VA = "0x185333E70")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5333E70", Offset = "0x5332A70", VA = "0x185333E70")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, uint GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5333EE0", Offset = "0x5332AE0", VA = "0x185333EE0")]
	public static void MFJOPFFCBFK(byte[] FEGEJBFJFNG, int EJAHPHIIAGB, long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5333EE0", Offset = "0x5332AE0", VA = "0x185333EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x534A8B0", Offset = "0x53494B0", VA = "0x18534A8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KACAKNGLONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB980", Offset = "0x1BFA580", VA = "0x181BFB980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LFGIGFIFHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x534AE20", Offset = "0x5349A20", VA = "0x18534AE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x534AA10", Offset = "0x5349610", VA = "0x18534AA10")]
	public void GOCGCPHFMHK(byte[] NOOIIGLDGHB, int IAKOFEGDGBF, int ICLGGOFCENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public OHGDFMEJMNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x534B010", Offset = "0x5349C10", VA = "0x18534B010")]
	public OHGDFMEJMNI(byte[] NOOIIGLDGHB, int IAKOFEGDGBF, int ICLGGOFCENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x534A420", Offset = "0x5349020", VA = "0x18534A420")]
	public IPEndPoint ACFBIPPMEPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x534A660", Offset = "0x5349260", VA = "0x18534A660")]
	public byte FCIJCCPGGGJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x534A660", Offset = "0x5349260", VA = "0x18534A660")]
	public sbyte CJIGGPJPCFI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26466F0", Offset = "0x26452F0", VA = "0x1826466F0")]
	public T[] EMACKALBKNP<T>(ushort JIGGJNDJAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x534A620", Offset = "0x5349220", VA = "0x18534A620")]
	public bool[] CCIIKCMDDLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x534AFD0", Offset = "0x5349BD0", VA = "0x18534AFD0")]
	public ushort[] PGCGIELEBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x534AEA0", Offset = "0x5349AA0", VA = "0x18534AEA0")]
	public short[] NACCGBIMLKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x534AEE0", Offset = "0x5349AE0", VA = "0x18534AEE0")]
	public int[] NNONKJEFEGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x534A900", Offset = "0x5349500", VA = "0x18534A900")]
	public uint[] FKKINEIOHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x534AAC0", Offset = "0x53496C0", VA = "0x18534AAC0")]
	public float[] HLBJDJAMBLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x534A4F0", Offset = "0x53490F0", VA = "0x18534A4F0")]
	public double[] AEFOMPLPCAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x534A530", Offset = "0x5349130", VA = "0x18534A530")]
	public long[] ALIJNECOKPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x534A940", Offset = "0x5349540", VA = "0x18534A940")]
	public ulong[] FLAFIAEFGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x534A780", Offset = "0x5349380", VA = "0x18534A780")]
	public string[] DOHKFOJNBFN(int MHJLMGPANNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x534AF20", Offset = "0x5349B20", VA = "0x18534AF20")]
	public bool OGEAOEPLDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x534A570", Offset = "0x5349170", VA = "0x18534A570")]
	public char BDJCCHHFBDM()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x534A570", Offset = "0x5349170", VA = "0x18534A570")]
	public ushort BDKLDCAMKIA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x534A980", Offset = "0x5349580", VA = "0x18534A980")]
	public short FNAKKFANAEG()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x534AA50", Offset = "0x5349650", VA = "0x18534AA50")]
	public long HADHKJPBBJE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x534ADB0", Offset = "0x53499B0", VA = "0x18534ADB0")]
	public ulong KKGJPEEGNHD()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x534AB00", Offset = "0x5349700", VA = "0x18534AB00")]
	public int JCEPEKBOCLO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x534AE30", Offset = "0x5349A30", VA = "0x18534AE30")]
	public uint MNLIBMPOOML()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x534A6A0", Offset = "0x53492A0", VA = "0x18534A6A0")]
	public float CLKPJCAGNCL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x534A710", Offset = "0x5349310", VA = "0x18534A710")]
	public double DELLIKHCMOB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x534AB70", Offset = "0x5349770", VA = "0x18534AB70")]
	public string JCLIFBPHEGF(int LEEFAANFGJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x534AF60", Offset = "0x5349B60", VA = "0x18534AF60")]
	public ArraySegment<byte> PAPFPOPPABK(int EMHEDPDPEMP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x534A5E0", Offset = "0x53491E0", VA = "0x18534A5E0")]
	public sbyte[] BJBKPOKPFFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x534A8C0", Offset = "0x53494C0", VA = "0x18534A8C0")]
	public byte[] EFOKCPMNHOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x534A9F0", Offset = "0x53495F0", VA = "0x18534A9F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5340EB0", Offset = "0x533FAB0", VA = "0x185340EB0")]
	public EGIKCGINJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5340E10", Offset = "0x533FA10", VA = "0x185340E10")]
	public EGIKCGINJND(bool PONJDIIMFCM, int NHAAFBFJNNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5340260", Offset = "0x533EE60", VA = "0x185340260")]
	public static EGIKCGINJND EOOFBKOKHGA(string GCPEEAODAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x53401C0", Offset = "0x533EDC0", VA = "0x1853401C0")]
	public void CIFAIFMKIMF(int ACOMFCEADLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C75280", Offset = "0x1C73E80", VA = "0x181C75280")]
	public void GPJBDIFOFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5340550", Offset = "0x533F150", VA = "0x185340550")]
	public void FJKFMAADOMK(float GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x53408E0", Offset = "0x533F4E0", VA = "0x1853408E0")]
	public void FJKFMAADOMK(double GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x53403A0", Offset = "0x533EFA0", VA = "0x1853403A0")]
	public void FJKFMAADOMK(long GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x53403A0", Offset = "0x533EFA0", VA = "0x1853403A0")]
	public void FJKFMAADOMK(ulong GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x53404C0", Offset = "0x533F0C0", VA = "0x1853404C0")]
	public void FJKFMAADOMK(int GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x53404C0", Offset = "0x533F0C0", VA = "0x1853404C0")]
	public void FJKFMAADOMK(uint GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5340800", Offset = "0x533F400", VA = "0x185340800")]
	public void FJKFMAADOMK(char GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5340800", Offset = "0x533F400", VA = "0x185340800")]
	public void FJKFMAADOMK(ushort GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5340800", Offset = "0x533F400", VA = "0x185340800")]
	public void FJKFMAADOMK(short GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5340340", Offset = "0x533EF40", VA = "0x185340340")]
	public void FJKFMAADOMK(sbyte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5340340", Offset = "0x533EF40", VA = "0x185340340")]
	public void FJKFMAADOMK(byte GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x53402D0", Offset = "0x533EED0", VA = "0x1853402D0")]
	public void FJKFMAADOMK(byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x53400E0", Offset = "0x533ECE0", VA = "0x1853400E0")]
	public void CEHPBEJGDEL(sbyte[] IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x53400E0", Offset = "0x533ECE0", VA = "0x1853400E0")]
	public void BEDJEIFBBON(byte[] IGJLGPELHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5340870", Offset = "0x533F470", VA = "0x185340870")]
	public void FJKFMAADOMK(bool GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5340BD0", Offset = "0x533F7D0", VA = "0x185340BD0")]
	public void HFOFMPAFCCN(Array IOACHNEABNH, int PFFLLMJEOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5340A10", Offset = "0x533F610", VA = "0x185340A10")]
	public void HFOFMPAFCCN(float[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5340930", Offset = "0x533F530", VA = "0x185340930")]
	public void HFOFMPAFCCN(double[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5340930", Offset = "0x533F530", VA = "0x185340930")]
	public void HFOFMPAFCCN(long[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5340930", Offset = "0x533F530", VA = "0x185340930")]
	public void HFOFMPAFCCN(ulong[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5340A10", Offset = "0x533F610", VA = "0x185340A10")]
	public void HFOFMPAFCCN(int[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5340A10", Offset = "0x533F610", VA = "0x185340A10")]
	public void HFOFMPAFCCN(uint[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5340AF0", Offset = "0x533F6F0", VA = "0x185340AF0")]
	public void HFOFMPAFCCN(ushort[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5340AF0", Offset = "0x533F6F0", VA = "0x185340AF0")]
	public void HFOFMPAFCCN(short[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x53400E0", Offset = "0x533ECE0", VA = "0x1853400E0")]
	public void HFOFMPAFCCN(bool[] GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5340CB0", Offset = "0x533F8B0", VA = "0x185340CB0")]
	public void HFOFMPAFCCN(string[] GCPEEAODAIB, int GOAMMGEFCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x53403F0", Offset = "0x533EFF0", VA = "0x1853403F0")]
	public void FJKFMAADOMK(IPEndPoint JJJNJOAKKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x53408D0", Offset = "0x533F4D0", VA = "0x1853408D0")]
	public void FJKFMAADOMK(string GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x53405F0", Offset = "0x533F1F0", VA = "0x1853405F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E4CBC0", Offset = "0x4E4B7C0", VA = "0x184E4CBC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CB77F0", Offset = "0x3CB63F0", VA = "0x183CB77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DE7B50", Offset = "0x3DE6750", VA = "0x183DE7B50")]
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
	[Cpp2IlInjected.Address(RVA = "0x5346750", Offset = "0x5345350", VA = "0x185346750")]
	public LFPNBNMAIJC(int MHJLMGPANNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22B5080", Offset = "0x22B3C80", VA = "0x1822B5080", Slot = "4")]
	protected virtual ulong NHFDEOJCGAA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x53465A0", Offset = "0x53451A0", VA = "0x1853465A0", Slot = "5")]
	protected virtual GJNHEOBKLIK OMAMLHKPNIL(OHGDFMEJMNI BIBCAMINPDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2573E30", Offset = "0x2572A30", VA = "0x182573E30", Slot = "6")]
	protected virtual void BIHLLLJMEBG<T>(EGIKCGINJND BNGNOICJJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x53466D0", Offset = "0x53452D0", VA = "0x1853466D0")]
	public void POKLBOLFLGJ(OHGDFMEJMNI BIBCAMINPDH, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2573EA0", Offset = "0x2572AA0", VA = "0x182573EA0")]
	public void ENIJDOPIDEK<T>(EGIKCGINJND BNGNOICJJGA, T LEMDNPBNHID) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5346550", Offset = "0x5345150", VA = "0x185346550")]
	public void MCKBLBHGGOH(OHGDFMEJMNI BIBCAMINPDH, object GMJDOLFFJGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x25740B0", Offset = "0x2572CB0", VA = "0x1825740B0")]
	public void HEFOBJPOIHC<T>(Action<T> PFEIJODLEFB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2573F30", Offset = "0x2572B30", VA = "0x182573F30")]
	public void HEFOBJPOIHC<T, TUserData>(Action<T, TUserData> PFEIJODLEFB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class JDAFCHENPIC : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5341D60", Offset = "0x5340960", VA = "0x185341D60")]
	public JDAFCHENPIC(string EOOPGFAEMIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class GBCPMDFKGNC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5341270", Offset = "0x533FE70", VA = "0x185341270")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A400B0", Offset = "0x3A3ECB0", VA = "0x183A400B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4593990", Offset = "0x4592590", VA = "0x184593990", Slot = "7")]
		public override void KAKHIABLMNP(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x4593370", Offset = "0x4591F70", VA = "0x184593370", Slot = "8")]
		public override void IJDHJAAJNCP(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4592730", Offset = "0x4591330", VA = "0x184592730", Slot = "9")]
		public override void GCCFOFOPAOD(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4594330", Offset = "0x4592F30", VA = "0x184594330", Slot = "10")]
		public override void MMMCBFFCGAB(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4591FA0", Offset = "0x4590BA0", VA = "0x184591FA0")]
		protected TProperty[] CACGPKGLKIG(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x45920A0", Offset = "0x4590CA0", VA = "0x1845920A0")]
		protected TProperty[] CHBKJBNHIGH(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x458DAA0", Offset = "0x458C6A0", VA = "0x18458DAA0", Slot = "4")]
		public override void BGGKBEMAPMG(MethodInfo KNKPIHNFCLO, MethodInfo BNAMFAGPGOF, NJMKPNJMOAG OMKEAAPIABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3731DF0", Offset = "0x37309F0", VA = "0x183731DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3737C50", Offset = "0x3736850", VA = "0x183737C50", Slot = "5")]
		public override void LIBJDCJDILJ(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x37378F0", Offset = "0x37364F0", VA = "0x1837378F0", Slot = "6")]
		public override void ENIJDOPIDEK(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3737B10", Offset = "0x3736710", VA = "0x183737B10", Slot = "7")]
		public override void KAKHIABLMNP(TClass PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3737A70", Offset = "0x3736670", VA = "0x183737A70", Slot = "8")]
		public override void IJDHJAAJNCP(TClass PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3737D50", Offset = "0x3736950", VA = "0x183737D50")]
		protected IIKBHANPHMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class AHAPFAECPOC<T> : BFJCHLBFEMK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x35F4470", Offset = "0x35F3070", VA = "0x1835F4470", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x35F4340", Offset = "0x35F2F40", VA = "0x1835F4340", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x35F4400", Offset = "0x35F3000", VA = "0x1835F4400", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x35F43A0", Offset = "0x35F2FA0", VA = "0x1835F43A0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public AHAPFAECPOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class JMFNJLMBEFK<T> : BFJCHLBFEMK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x391BD50", Offset = "0x391A950", VA = "0x18391BD50", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x35F4340", Offset = "0x35F2F40", VA = "0x1835F4340", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x391BCE0", Offset = "0x391A8E0", VA = "0x18391BCE0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x35F43A0", Offset = "0x35F2FA0", VA = "0x1835F43A0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public JMFNJLMBEFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ANBMNLFGBEI<T> : BFJCHLBFEMK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x371F490", Offset = "0x371E090", VA = "0x18371F490", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x367C330", Offset = "0x367AF30", VA = "0x18367C330", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x371F420", Offset = "0x371E020", VA = "0x18371F420", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x367C390", Offset = "0x367AF90", VA = "0x18367C390", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public ANBMNLFGBEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class HJKNOKJIILN<T> : BFJCHLBFEMK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x367C460", Offset = "0x367B060", VA = "0x18367C460", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x367C330", Offset = "0x367AF30", VA = "0x18367C330", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x367C3F0", Offset = "0x367AFF0", VA = "0x18367C3F0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x367C390", Offset = "0x367AF90", VA = "0x18367C390", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public HJKNOKJIILN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FDBCIIHIOFG<T> : BFJCHLBFEMK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x34CA8C0", Offset = "0x34C94C0", VA = "0x1834CA8C0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x34CA790", Offset = "0x34C9390", VA = "0x1834CA790", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x34CA850", Offset = "0x34C9450", VA = "0x1834CA850", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x34CA7F0", Offset = "0x34C93F0", VA = "0x1834CA7F0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public FDBCIIHIOFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class OIKNPGAPNBN<T> : BFJCHLBFEMK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFEBF0", VA = "0x183DFFFF0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x34CA790", Offset = "0x34C9390", VA = "0x1834CA790", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFF80", Offset = "0x3DFEB80", VA = "0x183DFFF80", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x34CA7F0", Offset = "0x34C93F0", VA = "0x1834CA7F0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public OIKNPGAPNBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class ODONAPAKMPD<T> : BFJCHLBFEMK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3726CB0", Offset = "0x37258B0", VA = "0x183726CB0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3726BE0", Offset = "0x37257E0", VA = "0x183726BE0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE480", Offset = "0x3DED080", VA = "0x183DEE480", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x35C6CE0", Offset = "0x35C58E0", VA = "0x1835C6CE0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public ODONAPAKMPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class AOHAHMIAMNK<T> : BFJCHLBFEMK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3726CB0", Offset = "0x37258B0", VA = "0x183726CB0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3726BE0", Offset = "0x37257E0", VA = "0x183726BE0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3726C40", Offset = "0x3725840", VA = "0x183726C40", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x35C6CE0", Offset = "0x35C58E0", VA = "0x1835C6CE0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public AOHAHMIAMNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class NMOHOJKPKEA<T> : BFJCHLBFEMK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D250", Offset = "0x3D2BE50", VA = "0x183D2D250", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D180", Offset = "0x3D2BD80", VA = "0x183D2D180", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2D1E0", Offset = "0x3D2BDE0", VA = "0x183D2D1E0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x35F43A0", Offset = "0x35F2FA0", VA = "0x1835F43A0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public NMOHOJKPKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class NAHIFHLBODB<T> : BFJCHLBFEMK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CF87B0", Offset = "0x3CF73B0", VA = "0x183CF87B0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CF86E0", Offset = "0x3CF72E0", VA = "0x183CF86E0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8740", Offset = "0x3CF7340", VA = "0x183CF8740", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x34CA7F0", Offset = "0x34C93F0", VA = "0x1834CA7F0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public NAHIFHLBODB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class GJLIDHLGABP<T> : BFJCHLBFEMK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x35C6DB0", Offset = "0x35C59B0", VA = "0x1835C6DB0", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x35C6C80", Offset = "0x35C5880", VA = "0x1835C6C80", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x35C6D40", Offset = "0x35C5940", VA = "0x1835C6D40", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x35C6CE0", Offset = "0x35C58E0", VA = "0x1835C6CE0", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x34CA930", Offset = "0x34C9530", VA = "0x1834CA930")]
		public GJLIDHLGABP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class JIOCNCCBOGB<T> : IIKBHANPHMP<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3912070", Offset = "0x3910C70", VA = "0x183912070", Slot = "12")]
		protected override void PIMNFEHCCDC(EGIKCGINJND NGJMGEHADAK, char MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3912040", Offset = "0x3910C40", VA = "0x183912040", Slot = "11")]
		protected override void NGBEJKBKDIB(OHGDFMEJMNI OIPEAFPNBJB, [Out] char MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x318D380", Offset = "0x318BF80", VA = "0x18318D380")]
		public JIOCNCCBOGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class AHPFJLPLOAJ<T> : IIKBHANPHMP<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x35F6350", Offset = "0x35F4F50", VA = "0x1835F6350", Slot = "12")]
		protected override void PIMNFEHCCDC(EGIKCGINJND NGJMGEHADAK, IPEndPoint MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x35F6310", Offset = "0x35F4F10", VA = "0x1835F6310", Slot = "11")]
		protected override void NGBEJKBKDIB(OHGDFMEJMNI OIPEAFPNBJB, [Out] IPEndPoint MMLGHJLGAJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x318D380", Offset = "0x318BF80", VA = "0x18318D380")]
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
		[Cpp2IlInjected.Address(RVA = "0x367FEB0", Offset = "0x367EAB0", VA = "0x18367FEB0")]
		public HMKNKGJMKHL(int LEEFAANFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x367FE40", Offset = "0x367EA40", VA = "0x18367FE40", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x367FCF0", Offset = "0x367E8F0", VA = "0x18367FCF0", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x367FDD0", Offset = "0x367E9D0", VA = "0x18367FDD0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x367FD60", Offset = "0x367E960", VA = "0x18367FD60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E4BF40", Offset = "0x4E4AB40", VA = "0x184E4BF40")]
		public DKCGOMIEDBL(PropertyInfo IEIEKFIPLEG, Type LJLCBMBCFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BE20", Offset = "0x4E4AA20", VA = "0x184E4BE20", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BC50", Offset = "0x4E4A850", VA = "0x184E4BC50", Slot = "6")]
		public override void ENIJDOPIDEK(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BDC0", Offset = "0x4E4A9C0", VA = "0x184E4BDC0", Slot = "7")]
		public override void KAKHIABLMNP(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BD60", Offset = "0x4E4A960", VA = "0x184E4BD60", Slot = "8")]
		public override void IJDHJAAJNCP(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BD00", Offset = "0x4E4A900", VA = "0x184E4BD00", Slot = "9")]
		public override void GCCFOFOPAOD(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4E4BEE0", Offset = "0x4E4AAE0", VA = "0x184E4BEE0", Slot = "10")]
		public override void MMMCBFFCGAB(T PKAGNMJHMCJ, EGIKCGINJND NGJMGEHADAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class KCBBFNOGKHL<T> : DKCGOMIEDBL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x372A130", Offset = "0x3728D30", VA = "0x18372A130")]
		public KCBBFNOGKHL(PropertyInfo IEIEKFIPLEG, Type LJLCBMBCFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x396D280", Offset = "0x396BE80", VA = "0x18396D280", Slot = "5")]
		public override void LIBJDCJDILJ(T PKAGNMJHMCJ, OHGDFMEJMNI OIPEAFPNBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x396D1D0", Offset = "0x396BDD0", VA = "0x18396D1D0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x39848A0", Offset = "0x39834A0", VA = "0x1839848A0")]
		public KKGECAPCAHL(List<LICGHFFOFJF<T>> GNMCHNDEKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3984740", Offset = "0x3983340", VA = "0x183984740")]
		public void ENIJDOPIDEK(T IIFJCGIHMIN, EGIKCGINJND BNGNOICJJGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x39847F0", Offset = "0x39833F0", VA = "0x1839847F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5341D70", Offset = "0x5340970", VA = "0x185341D70")]
	public JJLNFBPLIOA(int MHJLMGPANNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x25470C0", Offset = "0x2545CC0", VA = "0x1825470C0")]
	private KKGECAPCAHL<T> OMJGHAJHEDC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x22B7C80", Offset = "0x22B6880", VA = "0x1822B7C80")]
	public void CFNGGCOIEBP<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2546FE0", Offset = "0x2545BE0", VA = "0x182546FE0")]
	public bool JFKFFNFOIMD<T>(OHGDFMEJMNI BIBCAMINPDH, T JIGKIEPHJOJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2547060", Offset = "0x2545C60", VA = "0x182547060")]
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
		[Cpp2IlInjected.Address(RVA = "0x5335020", Offset = "0x5333C20", VA = "0x185335020")]
		get
		{
			return default(KIOEICMNNPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int DDJMJMOJAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5335050", Offset = "0x5333C50", VA = "0x185335050")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x53359A0", Offset = "0x53345A0", VA = "0x1853359A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public AKGMAJEPADA HJMOMBBLICG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5335F10", Offset = "0x5334B10", VA = "0x185335F10")]
		get
		{
			return default(AKGMAJEPADA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5335F40", Offset = "0x5334B40", VA = "0x185335F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JPPLGONGHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5335280", Offset = "0x5333E80", VA = "0x185335280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint FBBDFEJKLEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5335E90", Offset = "0x5334A90", VA = "0x185335E90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? EDJKNBIKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5335080", Offset = "0x5333C80", VA = "0x185335080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? PBMFDMMFAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5335CD0", Offset = "0x53348D0", VA = "0x185335CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? EEIHKLAJPDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5335310", Offset = "0x5333F10", VA = "0x185335310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x53350B0", Offset = "0x5333CB0", VA = "0x1853350B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5336090", Offset = "0x5334C90", VA = "0x185336090")]
	public BDJEKGNDMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5335FE0", Offset = "0x5334BE0", VA = "0x185335FE0")]
	internal BDJEKGNDMGA(byte[] FEGEJBFJFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x53359E0", Offset = "0x53345E0", VA = "0x1853359E0")]
	public static BDJEKGNDMGA JJAOLHIMNGE(byte[] FEGEJBFJFNG, DateTime DGIEIPEMGFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5335540", Offset = "0x5334140", VA = "0x185335540")]
	internal void GEBIBIGCBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5335B00", Offset = "0x5334700", VA = "0x185335B00")]
	private void LHPHMKCLKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5335340", Offset = "0x5333F40", VA = "0x185335340")]
	private DateTime? FPPOKJNCPDO(int IAKOFEGDGBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x53357D0", Offset = "0x53343D0", VA = "0x1853357D0")]
	private void HAIOJGAKAEM(int IAKOFEGDGBF, DateTime? GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5335D00", Offset = "0x5334900", VA = "0x185335D00")]
	private ulong LKDPCILLOIJ(int IAKOFEGDGBF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5335DD0", Offset = "0x53349D0", VA = "0x185335DD0")]
	private void NGIMKBIKNHB(int IAKOFEGDGBF, ulong GCPEEAODAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5335740", Offset = "0x5334340", VA = "0x185335740")]
	private uint GFPMFPPCIMD(int IAKOFEGDGBF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5223C60", Offset = "0x5222860", VA = "0x185223C60")]
	private static uint FHHOENJFEHF(uint HPIMCNPJDMN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x53352B0", Offset = "0x5333EB0", VA = "0x1853352B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5341950", Offset = "0x5340550", VA = "0x185341950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5341870", Offset = "0x5340470", VA = "0x185341870")]
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
	[Cpp2IlInjected.Address(RVA = "0x5349850", Offset = "0x5348450", VA = "0x185349850")]
	public MHJPACIIACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5348CE0", Offset = "0x53478E0", VA = "0x185348CE0")]
	public void ADIDBFLGJDK(IPEndPoint JJJNJOAKKIA, byte[] PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5349370", Offset = "0x5347F70", VA = "0x185349370")]
	public void JJGPKFKEHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x53492E0", Offset = "0x5347EE0", VA = "0x1853492E0")]
	private byte[] EBKLLPJFPCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5348F20", Offset = "0x5347B20", VA = "0x185348F20", Slot = "4")]
	public override void DKFGDAHAPML(IPEndPoint JJJNJOAKKIA, byte[] IGJLGPELHOJ, int IAKOFEGDGBF, int NBJKCBMEDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5349450", Offset = "0x5348050", VA = "0x185349450", Slot = "5")]
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
