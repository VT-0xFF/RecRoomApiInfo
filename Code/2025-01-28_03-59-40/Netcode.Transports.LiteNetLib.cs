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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, NGKFADACBNK
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JAAOMCAMEGE
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
		private NetworkManager GLNEKPCIIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, LKLNNJNJMMK> ONNOALJIIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CNDBJPBABCJ GKOLDIJMPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] KPFMNPBOAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JAAOMCAMEGE HAAIMHFFMJN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong MOLHJJOEMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D90", Offset = "0x8F2F90", VA = "0x1808F3D90", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool LKFOPDCMGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x65B3F40", Offset = "0x65B3140", VA = "0x1865B3F40", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x65B3520", Offset = "0x65B2720", VA = "0x1865B3520")]
		public void RecRoom_SetEncryptionInfo(ulong CIELHGMHECJ, byte[] OFPBICPHALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x65B3500", Offset = "0x65B2700", VA = "0x1865B3500")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x65B33D0", Offset = "0x65B25D0", VA = "0x1865B33D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x65B3E40", Offset = "0x65B3040", VA = "0x1865B3E40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x65B3640", Offset = "0x65B2840", VA = "0x1865B3640", Slot = "6")]
		public override void Send(ulong OHCCKDFOMNM, ArraySegment<byte> LFDKFEEPNFP, NetworkDelivery DMHODJDFGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x65B34C0", Offset = "0x65B26C0", VA = "0x1865B34C0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong OHCCKDFOMNM, [Out] ArraySegment<byte> OCPJHHIMKFB, [Out] float PJAPIBEPMJD)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65B3930", Offset = "0x65B2B30", VA = "0x1865B3930", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x65B3D60", Offset = "0x65B2F60", VA = "0x1865B3D60", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x65B2C80", Offset = "0x65B1E80", VA = "0x1865B2C80", Slot = "10")]
		public override void DisconnectRemoteClient(ulong OHCCKDFOMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65B2B90", Offset = "0x65B1D90", VA = "0x1865B2B90", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65B2F30", Offset = "0x65B2130", VA = "0x1865B2F30", Slot = "12")]
		public override ulong GetCurrentRtt(ulong OHCCKDFOMNM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x65B38C0", Offset = "0x65B2AC0", VA = "0x1865B38C0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x65B3030", Offset = "0x65B2230", VA = "0x1865B3030", Slot = "14")]
		public override void Initialize([Optional] NetworkManager GLNEKPCIIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x65B3300", Offset = "0x65B2500", VA = "0x1865B3300")]
		private MKHGPFEDDCF NJDAJDJLLCB(NetworkDelivery MDOOANEGCAH)
		{
			return default(MKHGPFEDDCF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65B31F0", Offset = "0x65B23F0", VA = "0x1865B31F0", Slot = "15")]
		private void JAKGNECCKIH(LKLNNJNJMMK MKLDEPGKAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x65B2E70", Offset = "0x65B2070", VA = "0x1865B2E70", Slot = "16")]
		private void FOPOIFNFJGB(LKLNNJNJMMK MKLDEPGKAPD, KAEPLNMJJIO LFONLAEKDJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "17")]
		private void FBCHBNEPIKG(IPEndPoint LGILCDPHGCM, SocketError KANNNNFFNNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65B2980", Offset = "0x65B1B80", VA = "0x1865B2980", Slot = "18")]
		private void BECAJJDDOLF(LKLNNJNJMMK MKLDEPGKAPD, GNJCGMKKFFC NHPBIOODHLE, byte ODINLIOKLDH, MKHGPFEDDCF FBGHNAILEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65B2D90", Offset = "0x65B1F90", VA = "0x1865B2D90")]
		private void ENBDDBAPGPA(int AFLMMFDMNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "19")]
		private void CKLFMIEFBDM(IPEndPoint HLMCAHANHPC, GNJCGMKKFFC NHPBIOODHLE, LLHJOJJPMEK ANMMAGLPDHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "20")]
		private void GBAHFPGEKPL(LKLNNJNJMMK MKLDEPGKAPD, int BIGNGBLPNJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65B2FD0", Offset = "0x65B21D0", VA = "0x1865B2FD0", Slot = "21")]
		private void HKIHAAKNGDA(LGPHODEKLNO JLBJPEIMAMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65B32B0", Offset = "0x65B24B0", VA = "0x1865B32B0")]
		private ulong LAKMPEBLKPH(LKLNNJNJMMK MKLDEPGKAPD)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65B32E0", Offset = "0x65B24E0", VA = "0x1865B32E0")]
		private static int MPHLPILOPOG(float KIPBHBAMJHE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65B3E60", Offset = "0x65B3060", VA = "0x1865B3E60")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class OFMCJPDGNEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly LKLNNJNJMMK PFMONPCMOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<CCBBBFPGGJN> FFHKLPOAIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HEJFPKACNCG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x65B5800", Offset = "0x65B4A00", VA = "0x1865B5800")]
	protected OFMCJPDGNEO(LKLNNJNJMMK MKLDEPGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x65B57A0", Offset = "0x65B49A0", VA = "0x1865B57A0")]
	public void LKOFCABJIEB(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x65B56E0", Offset = "0x65B48E0", VA = "0x1865B56E0")]
	protected void HGBCNEAJGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x65B5760", Offset = "0x65B4960", VA = "0x1865B5760")]
	public bool IOMIFJJENMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool NEEEBIFFMHE();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JLBCBLMDAOE(CCBBBFPGGJN GIOCJAKMLHB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum PHJMEHMPAEP
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
public class LGPHODEKLNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CNDBJPBABCJ EGGCMLBADDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int HJEFDJIELKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FIDPFNNMFKL IMKFJKEPACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint CFOAIIHKBDI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal PHJMEHMPAEP MCKCHGKEDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x91B6D0", Offset = "0x91A8D0", VA = "0x18091B6D0")]
		[CompilerGenerated]
		get
		{
			return default(PHJMEHMPAEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBF0080", Offset = "0xBEF280", VA = "0x180BF0080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x65ADF70", Offset = "0x65AD170", VA = "0x1865ADF70")]
	internal void DOAPOGEKOEN(FIDPFNNMFKL ILPNMAKCIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x65ADFD0", Offset = "0x65AD1D0", VA = "0x1865ADFD0")]
	private bool HBOGLLCNBPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x65AE000", Offset = "0x65AD200", VA = "0x1865AE000")]
	internal LGPHODEKLNO(IPEndPoint HLMCAHANHPC, FIDPFNNMFKL OPDPAKPLFHG, CNDBJPBABCJ PCOKPLBMBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x65ADF10", Offset = "0x65AD110", VA = "0x1865ADF10")]
	public LKLNNJNJMMK DBFEFJPOMPI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum LLHJOJJPMEK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum GGCJEDDGPOF
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
public struct KAEPLNMJJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public GGCJEDDGPOF MMJENGHOJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError CFBHJGKNGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public GNJCGMKKFFC KDNIIFHCLDD;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NGKFADACBNK
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHIAJJGPGHE(LKLNNJNJMMK MKLDEPGKAPD);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EADBBABGGDF(LKLNNJNJMMK MKLDEPGKAPD, KAEPLNMJJIO LFONLAEKDJH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCBPNGNDHPL(IPEndPoint LGILCDPHGCM, SocketError KANNNNFFNNO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFGMLCIHPEN(LKLNNJNJMMK MKLDEPGKAPD, GNJCGMKKFFC NHPBIOODHLE, byte ODINLIOKLDH, MKHGPFEDDCF FBGHNAILEKK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MLKMFFAIOOH(IPEndPoint HLMCAHANHPC, GNJCGMKKFFC NHPBIOODHLE, LLHJOJJPMEK ANMMAGLPDHH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CJOICGOONOA(LKLNNJNJMMK MKLDEPGKAPD, int BIGNGBLPNJN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDPENJJLLID(LGPHODEKLNO JLBJPEIMAMB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJCAACOFFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOOCKKOCHGP(LKLNNJNJMMK MKLDEPGKAPD, object EFOAKAGEENP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ANAHNFLGEPI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PNCCHNCKLKD(BDJHJMFONJP GIOCJAKMLHB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CKHHNPEDCEK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAKMLADGBOG(LKLNNJNJMMK MKLDEPGKAPD, IPEndPoint DOHOIGNNIOD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class FIDPFNNMFKL
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int EJOIIEFJKDG = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long MJOEDHDBFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte DEDKLCDBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] NMEHIMCADHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly JIHDPNNKJJH ELDOIBMHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int EBMHOJHHLIN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x65AB770", Offset = "0x65AA970", VA = "0x1865AB770")]
	private FIDPFNNMFKL(long JAAILENEFIL, byte DMFDJIPPFDD, int IMMLHGFCKGF, byte[] PAINCKCPKKN, JIHDPNNKJJH LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x65AB530", Offset = "0x65AA730", VA = "0x1865AB530")]
	public static int KGFDLHELLMM(CCBBBFPGGJN GIOCJAKMLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x65AB310", Offset = "0x65AA510", VA = "0x1865AB310")]
	public static FIDPFNNMFKL ECKNODOEANJ(CCBBBFPGGJN GIOCJAKMLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x65AB590", Offset = "0x65AA790", VA = "0x1865AB590")]
	public static CCBBBFPGGJN OHLBCAFGAAJ(MJEKGNAFCGO HHBDHDLIIBJ, SocketAddress BLOANNPPJKO, long PCOEFIHNDOA, int IMMLHGFCKGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class KMFJFDCBHBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long MJOEDHDBFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte DEDKLCDBFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int EBMHOJHHLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool PGFFNOMFDCL;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x65ADEC0", Offset = "0x65AD0C0", VA = "0x1865ADEC0")]
	private KMFJFDCBHBP(long JAAILENEFIL, byte DMFDJIPPFDD, int HPPIFJFHCDJ, bool DJHAEDACLNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65ADB80", Offset = "0x65ACD80", VA = "0x1865ADB80")]
	public static KMFJFDCBHBP ECKNODOEANJ(CCBBBFPGGJN GIOCJAKMLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65ADDD0", Offset = "0x65ACFD0", VA = "0x1865ADDD0")]
	public static CCBBBFPGGJN OHLBCAFGAAJ(long PCOEFIHNDOA, byte BEIICOMDDOD, int GIKIIBIBFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x65ADCD0", Offset = "0x65ACED0", VA = "0x1865ADCD0")]
	public static CCBBBFPGGJN IBFLJFFMFKE(LKLNNJNJMMK MKLDEPGKAPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum IAHAGBJFEGG
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GEOELGJAJAJ
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJNEPJCFEJN(IPEndPoint HOJEAJMMFMI, IPEndPoint HLMCAHANHPC, string BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGHFODHEGDE(IPEndPoint KENLONPLNAC, IAHAGBJFEGG MDOOANEGCAH, string BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EABPPJFDOGN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct OCLHMNBOHKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint HEFPJCCOHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint CFOAIIHKBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string PACGCGGMHMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DAOIKMGKFDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint EFCOFGBDLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IAHAGBJFEGG BLFPNJPCADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string PACGCGGMHMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class NLGCPJDEDEM
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BCMPMFFAFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string PACGCGGMHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public NLGCPJDEDEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class JKGLDGOOEKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BCMPMFFAFBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint NPIAHHJFPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string PACGCGGMHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public JKGLDGOOEKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class LFOHOIPPJCC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PACGCGGMHMB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8F54A0", Offset = "0x8F46A0", VA = "0x1808F54A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FLDLEEGHHHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xBB5FE0", Offset = "0xBB51E0", VA = "0x180BB5FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8FA8F0", Offset = "0x8F9AF0", VA = "0x1808FA8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public LFOHOIPPJCC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly CNDBJPBABCJ JANNNMNBDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<OCLHMNBOHKA> KEEAFFOJMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<DAOIKMGKFDG> GPLPBBAOMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JIHDPNNKJJH BKOLPCHKIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly MJEKGNAFCGO MOFPDOHGBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly DMNGBBDFEMM HCLPGCFEHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GEOELGJAJAJ KDCEJKOCEOF;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int MIILNAFNNCF = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool OGBEAEDPDHE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x65AA910", Offset = "0x65A9B10", VA = "0x1865AA910")]
	internal EABPPJFDOGN(CNDBJPBABCJ DOLANKJKKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x65AA320", Offset = "0x65A9520", VA = "0x1865AA320")]
	internal void FICJENGKDAH(IPEndPoint JPIIHJNMBCM, CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x310EB70", Offset = "0x310DD70", VA = "0x18310EB70")]
	private void DGLOBOPALIN<T>(T GIOCJAKMLHB, IPEndPoint MKMPLOHPJDC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x65AA600", Offset = "0x65A9800", VA = "0x1865AA600")]
	private void KJNEPJCFEJN(NLGCPJDEDEM IHANNNPOKBP, IPEndPoint JPIIHJNMBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x65AA4A0", Offset = "0x65A96A0", VA = "0x1865AA4A0")]
	private void HHNHFJCMBKH(JKGLDGOOEKB IHANNNPOKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x65AA780", Offset = "0x65A9980", VA = "0x1865AA780")]
	private void PNAHFCPEONL(LFOHOIPPJCC IHANNNPOKBP, IPEndPoint JPIIHJNMBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MKHGPFEDDCF : byte
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
public enum KGGIMOLIBMB : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FCJJHLGJKAI
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] HJCCKGCBFOK;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int HDNDJNJLPLK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int BFLPOBPJMBL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KMHNGKMGGGK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65AAD60", Offset = "0x65A9F60", VA = "0x1865AAD60")]
	public KMHNGKMGGGK(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EGAFECPHAJH : KMHNGKMGGGK
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65AAD60", Offset = "0x65A9F60", VA = "0x1865AAD60")]
	public EGAFECPHAJH(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum BMPMGCBHAPJ
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
public interface KECBPMLGNII
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void POEJKHDDAMK(BMPMGCBHAPJ CDDAGCDHNBH, string JJOHJKDMMOB, params object[] OKBEKNPNPIM);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GCLPFCDHCCL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static KECBPMLGNII MCBPGHOPFDD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object PAIKPCNMENB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x65AB7E0", Offset = "0x65AA9E0", VA = "0x1865AB7E0")]
	private static void AOKKKKCCAHP(BMPMGCBHAPJ CPPGBCEKDMJ, string JJOHJKDMMOB, params object[] OKBEKNPNPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x65ABA10", Offset = "0x65AAC10", VA = "0x1865ABA10")]
	internal static void HFJENPLOHCO(string JJOHJKDMMOB, params object[] OKBEKNPNPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x65ABA70", Offset = "0x65AAC70", VA = "0x1865ABA70")]
	internal static void KCGOEOAFMKJ(string JJOHJKDMMOB, params object[] OKBEKNPNPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x65ABAD0", Offset = "0x65AACD0", VA = "0x1865ABAD0")]
	internal static void NKEPPCPNCID(string JJOHJKDMMOB, params object[] OKBEKNPNPIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum MMBBHFNJLEB
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class GNJCGMKKFFC : JIHDPNNKJJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private CCBBBFPGGJN MBLFJNCDKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly CNDBJPBABCJ FJKIMNECDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly ODMLCBBPMGK IBIFLFFHHCL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x65ABD00", Offset = "0x65AAF00", VA = "0x1865ABD00")]
	internal GNJCGMKKFFC(CNDBJPBABCJ ODPBGAGOMOC, ODMLCBBPMGK PPAAELGINFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x65ABC10", Offset = "0x65AAE10", VA = "0x1865ABC10")]
	internal void LHODODHJKGD(CCBBBFPGGJN GIOCJAKMLHB, int BAECKACNAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x65ABC80", Offset = "0x65AAE80", VA = "0x1865ABC80")]
	internal void NKACPOMJCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x65ABBE0", Offset = "0x65AADE0", VA = "0x1865ABBE0")]
	public void JPECJIMIILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class ODMLCBBPMGK
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum LGIEFMFIGKH
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
	public ODMLCBBPMGK KKNAFBJAICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public LGIEFMFIGKH BLFPNJPCADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public LKLNNJNJMMK PFMONPCMOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint CFOAIIHKBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object GKGMIGOLBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int AGICLEHOCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError AAPILFGNDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public GGCJEDDGPOF ELODNIKHDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public LGPHODEKLNO IBGIDJEPLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public MKHGPFEDDCF FBFOKIJLOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte MBNCBHMCCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly GNJCGMKKFFC NONOCAICKKD;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x65B5640", Offset = "0x65B4840", VA = "0x1865B5640")]
	public ODMLCBBPMGK(CNDBJPBABCJ ODPBGAGOMOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CNDBJPBABCJ : IEnumerable<LKLNNJNJMMK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class MLNHLIOALMJ : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x65B4DB0", Offset = "0x65B3FB0", VA = "0x1865B4DB0", Slot = "4")]
		public bool Equals(IPEndPoint KIEMJAMMNPB, IPEndPoint IIOFLMMOEPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6092220", Offset = "0x6091420", VA = "0x186092220", Slot = "5")]
		public int GetHashCode(IPEndPoint LCACGJDNDHA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public MLNHLIOALMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct KGMKGDPMEIC : IEnumerator<LKLNNJNJMMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly LKLNNJNJMMK NJDDAJEGJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private LKLNNJNJMMK GHFDKDDFLPD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LKLNNJNJMMK AJGNMEAPLII
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC14800", Offset = "0xC13A00", VA = "0x180C14800", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x17537A0", Offset = "0x17529A0", VA = "0x1817537A0")]
		public KGMKGDPMEIC(LKLNNJNJMMK GBPBPMJPBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65ADAE0", Offset = "0x65ACCE0", VA = "0x1865ADAE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x65ADB30", Offset = "0x65ACD30", VA = "0x1865ADB30", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread HCAMCBHDCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool FFOIKCKOBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent PPEJGPCPMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<ODMLCBBPMGK> FFHIPNEDHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<ODMLCBBPMGK> KINMHHLKCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private ODMLCBBPMGK EPGLBFCAJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NGKFADACBNK GJFIACNGKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly JJCAACOFFIL FDFPOCGNODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ANAHNFLGEPI KOPMJEGLMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly CKHHNPEDCEK AKHFDOFBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, LKLNNJNJMMK> KHGEDENAOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, LGPHODEKLNO> ECEAOBHMPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, OMLPIIFBLIC> PJMGGPMCCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim CPGCHHFNILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private LKLNNJNJMMK BKIIGPBHDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int JEOLEBPLDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<LKLNNJNJMMK> PDPALLDOEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private LKLNNJNJMMK[] AMCONOEJAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly GKIAOFHBENC BLAPJOAPGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int HDHCIGBCPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> PFOIDLCMLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte CLDLCGJPMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object JKAIOMBBLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IPNOHOPEDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool DONBBLHOHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LGFMFFGAJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int OODABNPBOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int NHHCKMENGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int KCALJFBABCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DAIKMKIKCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool AGPFJBMHBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int CDAJMADBLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int GKIECHDFOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int KMCFGLGKKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool OGBEAEDPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool ALLDCFOJDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool MLANDMBDOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool AALIMBMCNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int MFLKOENNCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int DCOJEHPANCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool DCMGNBLCKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly BDKBIKALKCA OKJIPEFBNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool MEDCIMLMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly EABPPJFDOGN GFAGCPPJCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool ONJICPOLPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public MMBBHFNJLEB PCFABHJAJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int KFKAHPAFELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool LFHBJNMJLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool DOJCEJPHIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool PIHHHEEHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FCKBMHGFEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private CCBBBFPGGJN BINNIAOFLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int NCFDDLONMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object MHEEEPIKDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CCBBBFPGGJN PIECJNDIFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int PBPHCJPDHCE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int BGOFCFFNDPF = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int DHGGFBLJFJK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DDPAGMBGMLL DPDPOIEMCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private DDPAGMBGMLL DNDFDACGNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread GPJJDABNJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread KHHNPNHJMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint GGFAKAMCOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint DNNFIKJECAM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] ECJOMNMMMCI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] LABHNGOLOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<FCHLKHNKJMM, IPEndPoint> PJCPCOCBAJP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress IPKEGKAEOAJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool KFBONHANECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int LIJDMLCLODF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NFKIFHMADJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x12CAA80", Offset = "0x12C9C80", VA = "0x1812CAA80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x12CB3C0", Offset = "0x12CA5C0", VA = "0x1812CB3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FBHJJGBJPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6ED0", Offset = "0x1DC60D0", VA = "0x181DC6ED0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x20394A0", Offset = "0x20386A0", VA = "0x1820394A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte LAHAMGKOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB31240", Offset = "0xB30440", VA = "0x180B31240")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PCJDOEKIKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x65A7CF0", Offset = "0x65A6EF0", VA = "0x1865A7CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short MLLIDEGGADO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x65A2520", Offset = "0x65A1720", VA = "0x1865A2520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x65A5CF0", Offset = "0x65A4EF0", VA = "0x1865A5CF0")]
	public void IGFCAOPDFPC(IPEndPoint LGILCDPHGCM, byte[] OFPBICPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x65A9240", Offset = "0x65A8440", VA = "0x1865A9240")]
	public void PHHMEGNHDAH(IPEndPoint LGILCDPHGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x65A34A0", Offset = "0x65A26A0", VA = "0x1865A34A0")]
	private bool CJBGKKIDCNF(IPEndPoint LGILCDPHGCM, [Out] LKLNNJNJMMK MKLDEPGKAPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x65A5F10", Offset = "0x65A5110", VA = "0x1865A5F10")]
	private void INKEDEHFEAM(LKLNNJNJMMK MKLDEPGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x65A3450", Offset = "0x65A2650", VA = "0x1865A3450")]
	private void CIGABKGJOMK(LKLNNJNJMMK MKLDEPGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x65A7A80", Offset = "0x65A6C80", VA = "0x1865A7A80")]
	private void NLIMDEPDCGM(LKLNNJNJMMK MKLDEPGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x65A9950", Offset = "0x65A8B50", VA = "0x1865A9950")]
	public CNDBJPBABCJ(NGKFADACBNK PCOKPLBMBPB, [Optional] GKIAOFHBENC GEPMPIJLCNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x65A61F0", Offset = "0x65A53F0", VA = "0x1865A61F0")]
	internal void JALPNFAAHCJ(LKLNNJNJMMK ALJKJDNECID, int BIGNGBLPNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x65A63F0", Offset = "0x65A55F0", VA = "0x1865A63F0")]
	internal void LBOPHGKDBPC(LKLNNJNJMMK ALJKJDNECID, object EFOAKAGEENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x65A4250", Offset = "0x65A3450", VA = "0x1865A4250")]
	internal void FMIPPDBAFBF(LKLNNJNJMMK MKLDEPGKAPD, GGCJEDDGPOF GLMJIDMBMEG, SocketError HCBFKFKKMCI, CCBBBFPGGJN PKEBHPACJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x65A3E40", Offset = "0x65A3040", VA = "0x1865A3E40")]
	private void FHNNLBAKDOH(LKLNNJNJMMK MKLDEPGKAPD, GGCJEDDGPOF GLMJIDMBMEG, SocketError HCBFKFKKMCI, bool DCOODACAFGM, byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int EOKNBJLIKEG, CCBBBFPGGJN PKEBHPACJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x65A9390", Offset = "0x65A8590", VA = "0x1865A9390")]
	private void PJPNIEEPHGK(ODMLCBBPMGK.LGIEFMFIGKH MDOOANEGCAH, [Optional] LKLNNJNJMMK MKLDEPGKAPD, [Optional] IPEndPoint HLMCAHANHPC, SocketError KGBDOKDJBHH = SocketError.Success, int BIGNGBLPNJN = 0, GGCJEDDGPOF BMLIPNFGBFN = GGCJEDDGPOF.ConnectionFailed, [Optional] LGPHODEKLNO AFIKMKPBBHE, MKHGPFEDDCF FBGHNAILEKK = MKHGPFEDDCF.Unreliable, byte ODINLIOKLDH = 0, [Optional] CCBBBFPGGJN GNHANJPCFBN, [Optional] object EFOAKAGEENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x65A48B0", Offset = "0x65A3AB0", VA = "0x1865A48B0")]
	private void HDEFKFLKEOL(ODMLCBBPMGK PPAAELGINFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x65A6AC0", Offset = "0x65A5CC0", VA = "0x1865A6AC0")]
	internal void LLIKHLCMNLO(ODMLCBBPMGK PPAAELGINFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x65A7110", Offset = "0x65A6310", VA = "0x1865A7110")]
	private void MIKOBDBIJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x65A2A90", Offset = "0x65A1C90", VA = "0x1865A2A90")]
	private void BMJHIAIMGJD(int KMHIGGCAIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x65A4290", Offset = "0x65A3490", VA = "0x1865A4290")]
	internal LKLNNJNJMMK GGAJDNLPBIG(LGPHODEKLNO JLBJPEIMAMB, byte[] AJEMHEJHNJD, int JEMCAHPLMGJ, int BJJBELCKPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x65A7A00", Offset = "0x65A6C00", VA = "0x1865A7A00")]
	private int NJPBCGOCMBI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x65A25E0", Offset = "0x65A17E0", VA = "0x1865A25E0")]
	private void BEEHAKECLJF(IPEndPoint HLMCAHANHPC, LKLNNJNJMMK FNGOMMNOAFI, FIDPFNNMFKL CFEGBKDLBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x65A7E80", Offset = "0x65A7080", VA = "0x1865A7E80")]
	private void PFJKGPBIPNP(CCBBBFPGGJN GIOCJAKMLHB, IPEndPoint HLMCAHANHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x65A6440", Offset = "0x65A5640", VA = "0x1865A6440")]
	internal void LKCBIIMDDEE(CCBBBFPGGJN GIOCJAKMLHB, MKHGPFEDDCF PIBBPMPHNAJ, byte ODINLIOKLDH, int BAECKACNAEA, LKLNNJNJMMK ALJKJDNECID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x65A5A30", Offset = "0x65A4C30", VA = "0x1865A5A30")]
	public bool HFJDLLOGLKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x65A51D0", Offset = "0x65A43D0", VA = "0x1865A51D0")]
	public bool HFJDLLOGLKA(IPAddress FJDJKFIOFOM, IPAddress NKOFEGHLIMA, int JPKKDDIAAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x65A51F0", Offset = "0x65A43F0", VA = "0x1865A51F0")]
	public bool HFJDLLOGLKA(int JPKKDDIAAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x65A6240", Offset = "0x65A5440", VA = "0x1865A6240")]
	public void LBCKOMIKIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x65A3260", Offset = "0x65A2460", VA = "0x1865A3260")]
	public LKLNNJNJMMK BMJIHHHHJHH(string IEILKJKDKAG, int JPKKDDIAAIN, string OFPBICPHALF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x65A2DB0", Offset = "0x65A1FB0", VA = "0x1865A2DB0")]
	public LKLNNJNJMMK BMJIHHHHJHH(string IEILKJKDKAG, int JPKKDDIAAIN, MJEKGNAFCGO KJFDLABMLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x65A2E90", Offset = "0x65A2090", VA = "0x1865A2E90")]
	public LKLNNJNJMMK BMJIHHHHJHH(IPEndPoint MKMPLOHPJDC, MJEKGNAFCGO KJFDLABMLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x65A77A0", Offset = "0x65A69A0", VA = "0x1865A77A0")]
	public void MKBPOJHGOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x65A7450", Offset = "0x65A6650", VA = "0x1865A7450")]
	public void MKBPOJHGOEI(bool LNEEOLFGILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x65A5060", Offset = "0x65A4260", VA = "0x1865A5060")]
	public void HDJPJKLJDLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x65A5110", Offset = "0x65A4310", VA = "0x1865A5110")]
	public void HDJPJKLJDLP(byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x65A3DC0", Offset = "0x65A2FC0", VA = "0x1865A3DC0")]
	public void FHNNLBAKDOH(LKLNNJNJMMK MKLDEPGKAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x65A3E00", Offset = "0x65A3000", VA = "0x1865A3E00")]
	public void FHNNLBAKDOH(LKLNNJNJMMK MKLDEPGKAPD, byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x65A9770", Offset = "0x65A8970", VA = "0x1865A9770", Slot = "4")]
	private IEnumerator<LKLNNJNJMMK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x65A9800", Offset = "0x65A8A00", VA = "0x1865A9800", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x65A3BF0", Offset = "0x65A2DF0", VA = "0x1865A3BF0")]
	private CCBBBFPGGJN EFENAIEDDEB(IADMPONEIJA FPOONLFOOIF, int AFLMMFDMNOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x65A3CE0", Offset = "0x65A2EE0", VA = "0x1865A3CE0")]
	private CCBBBFPGGJN EFENAIEDDEB(IADMPONEIJA FPOONLFOOIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x65A77B0", Offset = "0x65A69B0", VA = "0x1865A77B0")]
	internal CCBBBFPGGJN NCBJMCBMGKO(int AFLMMFDMNOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x65A6BD0", Offset = "0x65A5DD0", VA = "0x1865A6BD0")]
	internal void MAEIKGHODLJ(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x65A9890", Offset = "0x65A8A90", VA = "0x1865A9890")]
	static CNDBJPBABCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x12CAA80", Offset = "0x12C9C80", VA = "0x1812CAA80")]
	private bool CCBACAJLKLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x65A3340", Offset = "0x65A2540", VA = "0x1865A3340")]
	private void BPOEILCKJHL(IPEndPoint DFINIMFOPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x65A5BF0", Offset = "0x65A4DF0", VA = "0x1865A5BF0")]
	private void HOBFBFMBJKN(IPEndPoint DFINIMFOPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x65A5A40", Offset = "0x65A4C40", VA = "0x1865A5A40")]
	private bool HNGKDHNPAPH(SocketException ANJHEGDKNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x65A6E40", Offset = "0x65A6040", VA = "0x1865A6E40")]
	private void MEPKFPDPDFA(DDPAGMBGMLL DOLANKJKKHC, EndPoint NKKNHCKHHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x65A6720", Offset = "0x65A5920", VA = "0x1865A6720")]
	private void LKEPJIGEDLJ(object ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x65A5270", Offset = "0x65A4470", VA = "0x1865A5270")]
	public bool HFJDLLOGLKA(IPAddress FJDJKFIOFOM, IPAddress NKOFEGHLIMA, int JPKKDDIAAIN, bool OBAPCEDKFLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x65A3B90", Offset = "0x65A2D90", VA = "0x1865A3B90")]
	internal int DOLAHGADMKL(CCBBBFPGGJN GIOCJAKMLHB, IPEndPoint HLMCAHANHPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x65A3B50", Offset = "0x65A2D50", VA = "0x1865A3B50")]
	internal int DDLBHPMKFAB(CCBBBFPGGJN GIOCJAKMLHB, IPEndPoint HLMCAHANHPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x65A3530", Offset = "0x65A2730", VA = "0x1865A3530")]
	internal int DDLBHPMKFAB(byte[] CBCJFCINKPJ, int JEMCAHPLMGJ, int BJJBELCKPHA, IPEndPoint HLMCAHANHPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x65A7D10", Offset = "0x65A6F10", VA = "0x1865A7D10")]
	internal void OGMLFIHLLOB(bool GFINMABHBEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum IADMPONEIJA : byte
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
internal sealed class CCBBBFPGGJN
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int OJGFIGKAODL;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] FIJCIKAHNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IBOJGJMEIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int ININOACGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object GKGMIGOLBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public CCBBBFPGGJN KKNAFBJAICO;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IADMPONEIJA OMPKIFGNKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x65A1800", Offset = "0x65A0A00", VA = "0x1865A1800")]
		get
		{
			return default(IADMPONEIJA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x65A1480", Offset = "0x65A0680", VA = "0x1865A1480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte DEDKLCDBFGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x65A1450", Offset = "0x65A0650", VA = "0x1865A1450")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x65A14C0", Offset = "0x65A06C0", VA = "0x1865A14C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort DFMGIPLJKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x65A1730", Offset = "0x65A0930", VA = "0x1865A1730")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x65A1240", Offset = "0x65A0440", VA = "0x1865A1240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ECMKECLJGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x65A13E0", Offset = "0x65A05E0", VA = "0x1865A13E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HJKHGOEMKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x65A17D0", Offset = "0x65A09D0", VA = "0x1865A17D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x65A15A0", Offset = "0x65A07A0", VA = "0x1865A15A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort IEJKFBKHOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65A15D0", Offset = "0x65A07D0", VA = "0x1865A15D0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65A1410", Offset = "0x65A0610", VA = "0x1865A1410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MCFECGPCEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65A1540", Offset = "0x65A0740", VA = "0x1865A1540")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x65A1790", Offset = "0x65A0990", VA = "0x1865A1790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort OEOBEHDOIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x65A1280", Offset = "0x65A0480", VA = "0x1865A1280")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x65A1500", Offset = "0x65A0700", VA = "0x1865A1500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x65A1860", Offset = "0x65A0A60", VA = "0x1865A1860")]
	static CCBBBFPGGJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65A1830", Offset = "0x65A0A30", VA = "0x1865A1830")]
	public void PLFOLDPOKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x65A1C50", Offset = "0x65A0E50", VA = "0x1865A1C50")]
	public CCBBBFPGGJN(int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x65A1B40", Offset = "0x65A0D40", VA = "0x1865A1B40")]
	public CCBBBFPGGJN(IADMPONEIJA FPOONLFOOIF, int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x65A1370", Offset = "0x65A0570", VA = "0x1865A1370")]
	public static int DIMJIEJCMBF(IADMPONEIJA FPOONLFOOIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x65A12E0", Offset = "0x65A04E0", VA = "0x1865A12E0")]
	public int DIMJIEJCMBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x65A1630", Offset = "0x65A0830", VA = "0x1865A1630")]
	public bool KFOPJBDHKEO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum APFEMGKOKCN : byte
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
internal enum IKAKBBIOHOJ
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
internal enum FCHJBFCPBMG
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum OHGIBGIBBAE
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class LKLNNJNJMMK
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class EBBPNLNKOJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public CCBBBFPGGJN[] EABNPLNABIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int MOHKFCPKPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int BNIOEFAAOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HJKHGOEMKIN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public EBBPNLNKOJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void BHJMLLKMCCD(ulong FEEFHENFFFM, int OLJHDCBPGPO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int DMNHOHAHOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int IGGNGHHMFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int OMKGEENNHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double EOGLHDNFKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int IFFAGPKNMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int PKHMHLCELAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int OICBDAMGFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch EOFOLKMIIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int EKHONNHMGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long OEBFOEPIMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object ECLEKOBKAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal LKLNNJNJMMK NKHFHICJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal LKLNNJNJMMK MECNAOKIBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<CCBBBFPGGJN> DCBMGPMLLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<OFMCJPDGNEO> HGGMBLHBNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OFMCJPDGNEO[] EBOLIDFGPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int DPEPOIBBEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int OLFKBMKNMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool EKKOEPMAIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int COPFOLMCJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int PMOJOBOOJCH;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int IJLNKOCEHAC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int LMLILEBOOON = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object MKPMAKPKELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int EDFONCJPOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, EBBPNLNKOJK> AHHKOAKLHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CCGIOACCLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly CCBBBFPGGJN DPDHOJLCMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int PNAEGIKEPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int FFPKEANGDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint ACGCCJEGKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int GEINMDJIGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int KKPOPGBEGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long KBNNHEJJHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte DMKILIOGAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private APFEMGKOKCN JFBKLAHEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private CCBBBFPGGJN IIEMGOHPONJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int PKAJAPPNLLE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int HJFGKCKABBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly CCBBBFPGGJN BDKALPMAJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly CCBBBFPGGJN BLMOICJGJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly CCBBBFPGGJN AONHDCBMHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly CCBBBFPGGJN DFIEDCAHPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private KGGIMOLIBMB JMONJPHBJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly CNDBJPBABCJ MBEOPABACOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int JFJOAOHHOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object LNAJEBMMAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly BDKBIKALKCA OKJIPEFBNCM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte FINPOKNMBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x98A910", Offset = "0x989B10", VA = "0x18098A910")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x65AE940", Offset = "0x65ADB40", VA = "0x1865AE940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint GJNBJOGKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB65170", Offset = "0xB64370", VA = "0x180B65170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public APFEMGKOKCN GBFMPBILEPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA48030", Offset = "0xA47230", VA = "0x180A48030")]
		get
		{
			return default(APFEMGKOKCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long IPHFMAFIBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8F7860", Offset = "0x8F6A60", VA = "0x1808F7860")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OLJNMBDEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x130BE60", Offset = "0x130B060", VA = "0x18130BE60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1BE5FE0", Offset = "0x1BE51E0", VA = "0x181BE5FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DGKBCIBAHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x65AE800", Offset = "0x65ADA00", VA = "0x1865AE800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AJDPDIMGDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x903060", Offset = "0x902260", VA = "0x180903060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double HBBHDENBJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x42F12D0", Offset = "0x42F04D0", VA = "0x1842F12D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BHJMLLKMCCD KJOFJKOFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x65AF010", Offset = "0x65AE210", VA = "0x1865AF010")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x65AE6F0", Offset = "0x65AD8F0", VA = "0x1865AE6F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x65B1B30", Offset = "0x65B0D30", VA = "0x1865B1B30")]
	internal LKLNNJNJMMK(CNDBJPBABCJ CPIHHKGCJFE, IPEndPoint HLMCAHANHPC, int BEHEHKFONGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x65AE6D0", Offset = "0x65AD8D0", VA = "0x1865AE6D0")]
	internal void DCPOINDHOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x65AE7D0", Offset = "0x65AD9D0", VA = "0x1865AE7D0")]
	internal void DHKBBDHFFLD(IPEndPoint JNELFMMKJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x65AE870", Offset = "0x65ADA70", VA = "0x1865AE870")]
	internal void FLANJEDEBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x65AFCA0", Offset = "0x65AEEA0", VA = "0x1865AFCA0")]
	private void JOHFBOLCNKP(int GNINHLPCHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x65AE690", Offset = "0x65AD890", VA = "0x1865AE690")]
	private void BHKGCFOECEB(int JCLMGGBGIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x65AED80", Offset = "0x65ADF80", VA = "0x1865AED80")]
	private OFMCJPDGNEO GGABDGDHHPI(byte ODMGJHMGBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x65B1F90", Offset = "0x65B1190", VA = "0x1865B1F90")]
	internal LKLNNJNJMMK(CNDBJPBABCJ CPIHHKGCJFE, IPEndPoint HLMCAHANHPC, int BEHEHKFONGA, byte BEIICOMDDOD, MJEKGNAFCGO HHBDHDLIIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x65B1950", Offset = "0x65B0B50", VA = "0x1865B1950")]
	internal LKLNNJNJMMK(CNDBJPBABCJ CPIHHKGCJFE, LGPHODEKLNO JLBJPEIMAMB, int BEHEHKFONGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x65B0990", Offset = "0x65AFB90", VA = "0x1865B0990")]
	internal void MOLHCGOMHMB(FIDPFNNMFKL JFIAOGGLKAJ, byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x65B18D0", Offset = "0x65B0AD0", VA = "0x1865B18D0")]
	internal bool PNNIINKHCLN(KMFJFDCBHBP GIOCJAKMLHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x65AE7A0", Offset = "0x65AD9A0", VA = "0x1865AE7A0")]
	public void DGLOBOPALIN(byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int BJJBELCKPHA, MKHGPFEDDCF GPDCLNOGPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x65B0430", Offset = "0x65AF630", VA = "0x1865B0430")]
	private void MGFNBKPDIMC(byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int BJJBELCKPHA, byte ODINLIOKLDH, MKHGPFEDDCF FBGHNAILEKK, object EFOAKAGEENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x65AE1C0", Offset = "0x65AD3C0", VA = "0x1865AE1C0")]
	public void APAMADKKLCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x65AEF30", Offset = "0x65AE130", VA = "0x1865AEF30")]
	internal FCHJBFCPBMG GLMDAICFKIN(CCBBBFPGGJN GIOCJAKMLHB)
	{
		return default(FCHJBFCPBMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x65AE810", Offset = "0x65ADA10", VA = "0x1865AE810")]
	internal void DOFCHFFFLNE(OFMCJPDGNEO FLAIOLMMJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x65AF990", Offset = "0x65AEB90", VA = "0x1865AF990")]
	internal OHGIBGIBBAE JOFNHPKKNAM(byte[] LFDKFEEPNFP, int JEMCAHPLMGJ, int BJJBELCKPHA, bool DCOODACAFGM)
	{
		return default(OHGIBGIBBAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x65AE900", Offset = "0x65ADB00", VA = "0x1865AE900")]
	private void FMKBOKJFFKG(int MALOJKPKAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x65B0F40", Offset = "0x65B0140", VA = "0x1865B0F40")]
	internal void OMCGMOHCHJI(MKHGPFEDDCF PIBBPMPHNAJ, CCBBBFPGGJN GBPBPMJPBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x65B09E0", Offset = "0x65AFBE0", VA = "0x1865B09E0")]
	private void NJEKCELCBGN(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x65AE9F0", Offset = "0x65ADBF0", VA = "0x1865AE9F0")]
	private void GBJOOODGNBI(int NIMHBLEHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x65AE210", Offset = "0x65AD410", VA = "0x1865AE210")]
	internal IKAKBBIOHOJ BEEHAKECLJF(FIDPFNNMFKL CFEGBKDLBNC)
	{
		return default(IKAKBBIOHOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x65AF2D0", Offset = "0x65AE4D0", VA = "0x1865AF2D0")]
	internal void JLBCBLMDAOE(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x65AE070", Offset = "0x65AD270", VA = "0x1865AE070")]
	private void AAAMGLJLCOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x65AF0C0", Offset = "0x65AE2C0", VA = "0x1865AF0C0")]
	internal void INCHPKIONJO(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x65AFD70", Offset = "0x65AEF70", VA = "0x1865AFD70")]
	internal void MEIPIBBEBLB(int NIMHBLEHMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x65AE3D0", Offset = "0x65AD5D0", VA = "0x1865AE3D0")]
	internal void BGNHKAIOPNM(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BDKBIKALKCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long EEJMAGLAAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long LIOLBKHCJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long FINOMMOLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long BBFGNEJKLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long HEIKAOOJDAK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long LBGBPFLGOPN;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long JNDOPLGPCBE;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long DIGKLAPNOPK;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long GOGGJOJFHIN;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long FCAGGMPIHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long KGCHNHMBPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long GPBAFJBIKGL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long EEBJPCKBACC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x65A0C60", Offset = "0x659FE60", VA = "0x1865A0C60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long JDLJAFDAIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x65A0A60", Offset = "0x659FC60", VA = "0x1865A0A60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long DMIHODFNIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x65A0DD0", Offset = "0x659FFD0", VA = "0x1865A0DD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long EANIHBGMAPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x65A0DE0", Offset = "0x659FFE0", VA = "0x1865A0DE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long NLPDHMGKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x65A0B70", Offset = "0x659FD70", VA = "0x1865A0B70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long HIHDKNLGBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x65A0B80", Offset = "0x659FD80", VA = "0x1865A0B80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long FKFELFGJLKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x65A0C70", Offset = "0x659FE70", VA = "0x1865A0C70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long HKFEHCBEEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x65A0DF0", Offset = "0x659FFF0", VA = "0x1865A0DF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private KGGIMOLIBMB OIPPIFHLPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x65A0EF0", Offset = "0x65A00F0", VA = "0x1865A0EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double MHECCDAFAGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x65A0C00", Offset = "0x659FE00", VA = "0x1865A0C00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x65A0E30", Offset = "0x65A0030", VA = "0x1865A0E30")]
	public void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x65A0D70", Offset = "0x659FF70", VA = "0x1865A0D70")]
	public void KJAOBGBOHKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x65A0CB0", Offset = "0x659FEB0", VA = "0x1865A0CB0")]
	public void JIBNIIFBBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x65A0D00", Offset = "0x659FF00", VA = "0x1865A0D00")]
	public void KAABHBANHIA(long IPOBLBOEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x65A0B90", Offset = "0x659FD90", VA = "0x1865A0B90")]
	public void EAFMPKGKBFE(long NIFKJJKOPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x65A0A70", Offset = "0x659FC70", VA = "0x1865A0A70")]
	public void ABNAGJBDFGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x65A0E70", Offset = "0x65A0070", VA = "0x1865A0E70")]
	public void OPFPBOICJMD(long LKIEOLCPFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x65A0F00", Offset = "0x65A0100", VA = "0x1865A0F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x65A0AD0", Offset = "0x659FCD0", VA = "0x1865A0AD0")]
	public void CHHGODIGEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public BDKBIKALKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HLONMPBCMBL
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> BCHOILPPIJI;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x65AC080", Offset = "0x65AB280", VA = "0x1865AC080")]
	public static IPEndPoint PFPDMBEKOJL(string KMEPMJLFEBL, int JPKKDDIAAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x65ABEB0", Offset = "0x65AB0B0", VA = "0x1865ABEB0")]
	public static IPAddress PDLNGKCCHNN(string KMEPMJLFEBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x65ABE20", Offset = "0x65AB020", VA = "0x1865ABE20")]
	public static IPAddress PDLNGKCCHNN(string KMEPMJLFEBL, AddressFamily IIECCGHMBBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x65ABDF0", Offset = "0x65AAFF0", VA = "0x1865ABDF0")]
	internal static int GOAMNDFJIDL(int KGOADIDBCLN, int BIFMINLMLMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x3292340", Offset = "0x3291540", VA = "0x183292340")]
	internal static T[] IMPHKAPCEDO<T>(int EOKNBJLIKEG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PNEBFEMIOFH : OFMCJPDGNEO
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct ELDGFJEJCHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private CCBBBFPGGJN MBLFJNCDKKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long POOFCADMLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool FBEICLLEOCJ;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x65AAE50", Offset = "0x65AA050", VA = "0x1865AAE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x65AAE30", Offset = "0x65AA030", VA = "0x1865AAE30")]
		public void MDPAGNEJHAM(CCBBBFPGGJN GIOCJAKMLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x65AADC0", Offset = "0x65A9FC0", VA = "0x1865AADC0")]
		public bool HOCFPJHPAOF(long MFMMOJAJAID, LKLNNJNJMMK MKLDEPGKAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x65AAD70", Offset = "0x65A9F70", VA = "0x1865AAD70")]
		public bool DBGBEIOBMKO(LKLNNJNJMMK MKLDEPGKAPD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly CCBBBFPGGJN HCFFJDCMENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly ELDGFJEJCHA[] MJLPCJGCPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly CCBBBFPGGJN[] HELBMLACLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] CKHGPLILNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int ELEDOIBILGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int HGEPGLIGLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int GFEGCDADELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int OPMCNPAPPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool DKDGDBPJNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly MKHGPFEDDCF MFIEOLLDGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool JIDAGEOFNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int DMPIBHNIHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte FHKCBMNDOED;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x65B6890", Offset = "0x65B5A90", VA = "0x1865B6890")]
	public PNEBFEMIOFH(LKLNNJNJMMK MKLDEPGKAPD, bool EPCBNDDNKDO, byte BEHEHKFONGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x65B59A0", Offset = "0x65B4BA0", VA = "0x1865B59A0")]
	private void BDKCKHGACDJ(CCBBBFPGGJN GIOCJAKMLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x65B63C0", Offset = "0x65B55C0", VA = "0x1865B63C0", Slot = "4")]
	protected override bool NEEEBIFFMHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x65B5D60", Offset = "0x65B4F60", VA = "0x1865B5D60", Slot = "5")]
	public override bool JLBCBLMDAOE(CCBBBFPGGJN GIOCJAKMLHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CMGJJDNBBMK : OFMCJPDGNEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int CJDFKDKCJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort HGEPGLIGLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool GFAKFPOIAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private CCBBBFPGGJN EPLOAEKBIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly CCBBBFPGGJN ABAFDJDAJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool OLJDFKGLJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte FHKCBMNDOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long FCBKMMIMHHE;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x65A2460", Offset = "0x65A1660", VA = "0x1865A2460")]
	public CMGJJDNBBMK(LKLNNJNJMMK MKLDEPGKAPD, bool PBABJFJDNND, byte BEHEHKFONGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x65A1FA0", Offset = "0x65A11A0", VA = "0x1865A1FA0", Slot = "4")]
	protected override bool NEEEBIFFMHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x65A1CC0", Offset = "0x65A0EC0", VA = "0x1865A1CC0", Slot = "5")]
	public override bool JLBCBLMDAOE(CCBBBFPGGJN GIOCJAKMLHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FFDKGMINIJH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct NNDBKFBODGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong JOAHJIGJPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double NIHJNALOFGE;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct FNLHEPODKDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int EGIBLNILGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float HKOICBKLFEE;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x659F0E0", Offset = "0x659E2E0", VA = "0x18659F0E0")]
	private static void CBIDMLBMKFL(byte[] HJDGEKDMIGG, int KLICPJBJAIA, ulong LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x65AB1B0", Offset = "0x65AA3B0", VA = "0x1865AB1B0")]
	private static void CBIDMLBMKFL(byte[] HJDGEKDMIGG, int KLICPJBJAIA, int LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x65AB220", Offset = "0x65AA420", VA = "0x1865AB220")]
	public static void CBIDMLBMKFL(byte[] HJDGEKDMIGG, int KLICPJBJAIA, short LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x65AB2F0", Offset = "0x65AA4F0", VA = "0x1865AB2F0")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, double OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x65AB270", Offset = "0x65AA470", VA = "0x1865AB270")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x65AB220", Offset = "0x65AA420", VA = "0x1865AB220")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, short OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x65AB220", Offset = "0x65AA420", VA = "0x1865AB220")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, ushort OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x65AB1B0", Offset = "0x65AA3B0", VA = "0x1865AB1B0")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x65AB1B0", Offset = "0x65AA3B0", VA = "0x1865AB1B0")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, uint OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x65AB260", Offset = "0x65AA460", VA = "0x1865AB260")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x65AB260", Offset = "0x65AA460", VA = "0x1865AB260")]
	public static void FBAFJDIPPHO(byte[] JIGDFCPIKCH, int EINJGMILBKO, ulong OMEFCJCOLII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JIHDPNNKJJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] KJHLEFLCCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int GNGAKGICFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int HJJGDBMAFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int FBHMEPHKMPP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] IBOJGJMEIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int DCHCLJLAOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA960C0", Offset = "0xA952C0", VA = "0x180A960C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LBDBHBNFHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x65AD950", Offset = "0x65ACB50", VA = "0x1865AD950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NPIENFLKIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2417D00", Offset = "0x2416F00", VA = "0x182417D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NMDEPOBNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x65ACEB0", Offset = "0x65AC0B0", VA = "0x1865ACEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x65AD860", Offset = "0x65ACA60", VA = "0x1865AD860")]
	public void LHODODHJKGD(byte[] PDEGCFKDOBB, int KLICPJBJAIA, int BMNKKLDENBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public JIHDPNNKJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x65ADA80", Offset = "0x65ACC80", VA = "0x1865ADA80")]
	public JIHDPNNKJJH(byte[] PDEGCFKDOBB, int KLICPJBJAIA, int BMNKKLDENBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x65AD790", Offset = "0x65AC990", VA = "0x1865AD790")]
	public IPEndPoint KLMEJLHABGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x65AD710", Offset = "0x65AC910", VA = "0x1865AD710")]
	public byte KGDFJEADGJG()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x65AD710", Offset = "0x65AC910", VA = "0x1865AD710")]
	public sbyte MFDLANKAAHF()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x32F5ED0", Offset = "0x32F50D0", VA = "0x1832F5ED0")]
	public T[] LKKFKHIAJOH<T>(ushort AFLMMFDMNOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x65AD330", Offset = "0x65AC530", VA = "0x1865AD330")]
	public bool[] GHDDIANOKBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x65AD960", Offset = "0x65ACB60", VA = "0x1865AD960")]
	public ushort[] OCBGAPCFJIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x65AD0B0", Offset = "0x65AC2B0", VA = "0x1865AD0B0")]
	public short[] DKNGICCNMKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x65AD3E0", Offset = "0x65AC5E0", VA = "0x1865AD3E0")]
	public int[] HHGPLAJEKHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x65AD070", Offset = "0x65AC270", VA = "0x1865AD070")]
	public uint[] DCGBHFJJEHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65AD500", Offset = "0x65AC700", VA = "0x1865AD500")]
	public float[] HOKBOFMGFNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x65AD8A0", Offset = "0x65ACAA0", VA = "0x1865AD8A0")]
	public double[] LIALPEDLAOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x65AD6D0", Offset = "0x65AC8D0", VA = "0x1865AD6D0")]
	public long[] INBEJKOEAIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x65AD750", Offset = "0x65AC950", VA = "0x1865AD750")]
	public ulong[] KHMEKNLGOKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x65ACF00", Offset = "0x65AC100", VA = "0x1865ACF00")]
	public string[] DAHOKNHJNDA(int BEKLMIPGELP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x65AD5B0", Offset = "0x65AC7B0", VA = "0x1865AD5B0")]
	public bool IBHNDHFLBNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x65AD420", Offset = "0x65AC620", VA = "0x1865AD420")]
	public char POINHBFOAEH()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x65AD420", Offset = "0x65AC620", VA = "0x1865AD420")]
	public ushort HLCNODFLIPA()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x65ADA10", Offset = "0x65ACC10", VA = "0x1865ADA10")]
	public short PIDJAACHLBP()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x65AD540", Offset = "0x65AC740", VA = "0x1865AD540")]
	public long IBBKJEEGKGK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x65AD370", Offset = "0x65AC570", VA = "0x1865AD370")]
	public ulong HBOAIAJHACA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x65AD660", Offset = "0x65AC860", VA = "0x1865AD660")]
	public int IILCNBLILDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x65AD8E0", Offset = "0x65ACAE0", VA = "0x1865AD8E0")]
	public uint LNMMMOCBECD()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x65AD5F0", Offset = "0x65AC7F0", VA = "0x1865AD5F0")]
	public float IHAKKLMOBOI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x65AD9A0", Offset = "0x65ACBA0", VA = "0x1865AD9A0")]
	public double PFJHNECGNLM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x65AD0F0", Offset = "0x65AC2F0", VA = "0x1865AD0F0")]
	public string EJGAHHNBKMF(int ODKEIFCIJNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x65AD490", Offset = "0x65AC690", VA = "0x1865AD490")]
	public ArraySegment<byte> HOAFKFKLOFO(int EOKNBJLIKEG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE70", Offset = "0x65AC070", VA = "0x1865ACE70")]
	public sbyte[] ACFKLNCCEOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x65ACEC0", Offset = "0x65AC0C0", VA = "0x1865ACEC0")]
	public byte[] CNLJIIFBJFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x65AD050", Offset = "0x65AC250", VA = "0x1865AD050")]
	public void DBGBEIOBMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class MJEKGNAFCGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] KJHLEFLCCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int GNGAKGICFFD;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int PFOCMIAEAOL = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool DODPAIDJJDK;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding IDKONMGKJCG;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int MLIHNIELMOK = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] MDKDJJDDNMK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] ELDOIBMHPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int JBMLOIOBDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D30", Offset = "0x8F3F30", VA = "0x1808F4D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x65B4C90", Offset = "0x65B3E90", VA = "0x1865B4C90")]
	public MJEKGNAFCGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x65B4D10", Offset = "0x65B3F10", VA = "0x1865B4D10")]
	public MJEKGNAFCGO(bool DALIPIOFADA, int IELIALDOIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x65B4B90", Offset = "0x65B3D90", VA = "0x1865B4B90")]
	public static MJEKGNAFCGO PONDMCBHHNB(string OMEFCJCOLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x65B4AF0", Offset = "0x65B3CF0", VA = "0x1865B4AF0")]
	public void JLDEFPBGDKK(int NNJFNPJGBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2491530", Offset = "0x2490730", VA = "0x182491530")]
	public void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x65B4210", Offset = "0x65B3410", VA = "0x1865B4210")]
	public void GDPCAGEHNIC(float OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x65B41C0", Offset = "0x65B33C0", VA = "0x1865B41C0")]
	public void GDPCAGEHNIC(double OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x65B40B0", Offset = "0x65B32B0", VA = "0x1865B40B0")]
	public void GDPCAGEHNIC(long OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x65B40B0", Offset = "0x65B32B0", VA = "0x1865B40B0")]
	public void GDPCAGEHNIC(ulong OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x65B4540", Offset = "0x65B3740", VA = "0x1865B4540")]
	public void GDPCAGEHNIC(int OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x65B4540", Offset = "0x65B3740", VA = "0x1865B4540")]
	public void GDPCAGEHNIC(uint OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x65B4040", Offset = "0x65B3240", VA = "0x1865B4040")]
	public void GDPCAGEHNIC(char OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x65B4040", Offset = "0x65B3240", VA = "0x1865B4040")]
	public void GDPCAGEHNIC(ushort OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x65B4040", Offset = "0x65B3240", VA = "0x1865B4040")]
	public void GDPCAGEHNIC(short OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x65B4160", Offset = "0x65B3360", VA = "0x1865B4160")]
	public void GDPCAGEHNIC(sbyte OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x65B4160", Offset = "0x65B3360", VA = "0x1865B4160")]
	public void GDPCAGEHNIC(byte OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x65B44C0", Offset = "0x65B36C0", VA = "0x1865B44C0")]
	public void GDPCAGEHNIC(byte[] LFDKFEEPNFP, int KLICPJBJAIA, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F60", Offset = "0x65B3160", VA = "0x1865B3F60")]
	public void FPPCNFDPLLB(sbyte[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F60", Offset = "0x65B3160", VA = "0x1865B3F60")]
	public void JMMCIPGFJMO(byte[] LFDKFEEPNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x65B4100", Offset = "0x65B3300", VA = "0x1865B4100")]
	public void GDPCAGEHNIC(bool OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x65B4940", Offset = "0x65B3B40", VA = "0x1865B4940")]
	public void IBJPBCMGMMH(Array GPBEAHFLAKH, int MDGIOGAPJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x65B4780", Offset = "0x65B3980", VA = "0x1865B4780")]
	public void IBJPBCMGMMH(float[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x65B4860", Offset = "0x65B3A60", VA = "0x1865B4860")]
	public void IBJPBCMGMMH(double[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x65B4860", Offset = "0x65B3A60", VA = "0x1865B4860")]
	public void IBJPBCMGMMH(long[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x65B4860", Offset = "0x65B3A60", VA = "0x1865B4860")]
	public void IBJPBCMGMMH(ulong[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x65B4780", Offset = "0x65B3980", VA = "0x1865B4780")]
	public void IBJPBCMGMMH(int[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x65B4780", Offset = "0x65B3980", VA = "0x1865B4780")]
	public void IBJPBCMGMMH(uint[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x65B46A0", Offset = "0x65B38A0", VA = "0x1865B46A0")]
	public void IBJPBCMGMMH(ushort[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x65B46A0", Offset = "0x65B38A0", VA = "0x1865B46A0")]
	public void IBJPBCMGMMH(short[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x65B3F60", Offset = "0x65B3160", VA = "0x1865B3F60")]
	public void IBJPBCMGMMH(bool[] OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x65B4A20", Offset = "0x65B3C20", VA = "0x1865B4A20")]
	public void IBJPBCMGMMH(string[] OMEFCJCOLII, int AMKBHFMJBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x65B45D0", Offset = "0x65B37D0", VA = "0x1865B45D0")]
	public void GDPCAGEHNIC(IPEndPoint LGILCDPHGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x65B4530", Offset = "0x65B3730", VA = "0x1865B4530")]
	public void GDPCAGEHNIC(string OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x65B42B0", Offset = "0x65B34B0", VA = "0x1865B42B0")]
	public void GDPCAGEHNIC(string OMEFCJCOLII, int ODKEIFCIJNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DMNGBBDFEMM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class CAJDNPGOHMG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong JFJOAOHHOGF;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x56DF4F0", Offset = "0x56DE6F0", VA = "0x1856DF4F0")]
		static CAJDNPGOHMG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void NOACADFEBKJ(JIHDPNNKJJH NHPBIOODHLE, object EFOAKAGEENP);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AMAFOJJOHBG<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public DMNGBBDFEMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public AMAFOJJOHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4534AD0", Offset = "0x4533CD0", VA = "0x184534AD0")]
		internal void FNLEKMFMGGE(JIHDPNNKJJH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DKCOFFDHINI<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public DMNGBBDFEMM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		public DKCOFFDHINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x607ADE0", Offset = "0x6079FE0", VA = "0x18607ADE0")]
		internal void FNLEKMFMGGE(JIHDPNNKJJH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly HGCCCJGEOFC PADOJMIDFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, NOACADFEBKJ> MIPHKGMEGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly MJEKGNAFCGO DMHLALEHMFG;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x65AA1A0", Offset = "0x65A93A0", VA = "0x1865AA1A0")]
	public DMNGBBDFEMM(int BEKLMIPGELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x3058540", Offset = "0x3057740", VA = "0x183058540", Slot = "4")]
	protected virtual ulong LJMEKHKIHKF<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x65AA020", Offset = "0x65A9220", VA = "0x1865AA020", Slot = "5")]
	protected virtual NOACADFEBKJ MDMBPHAMDBA(JIHDPNNKJJH NHPBIOODHLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x30F7750", Offset = "0x30F6950", VA = "0x1830F7750", Slot = "6")]
	protected virtual void BKNPGCEEBHP<T>(MJEKGNAFCGO JPECNBJOJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x65A9FA0", Offset = "0x65A91A0", VA = "0x1865A9FA0")]
	public void DFJKBBDNNKO(JIHDPNNKJJH NHPBIOODHLE, object EFOAKAGEENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x30F77C0", Offset = "0x30F69C0", VA = "0x1830F77C0")]
	public void CCDEIAGNOJL<T>(MJEKGNAFCGO JPECNBJOJNA, T GIOCJAKMLHB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x65AA150", Offset = "0x65A9350", VA = "0x1865AA150")]
	public void NJMNMAPMECB(JIHDPNNKJJH NHPBIOODHLE, object EFOAKAGEENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x30F7A30", Offset = "0x30F6C30", VA = "0x1830F7A30")]
	public void GNHJJLKBNAL<T>(Action<T> EAEBPEOACJL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x30F7870", Offset = "0x30F6A70", VA = "0x1830F7870")]
	public void GNHJJLKBNAL<T, TUserData>(Action<T, TUserData> EAEBPEOACJL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NFAIGFCPOLK : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x65AAD60", Offset = "0x65A9F60", VA = "0x1865AAD60")]
	public NFAIGFCPOLK(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LPPADPMCDPF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x65B2920", Offset = "0x65B1B20", VA = "0x1865B2920")]
	public LPPADPMCDPF(string CBCJFCINKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class HGCCCJGEOFC
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum KACBHDGHHGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class JKHPADGOOHF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public KACBHDGHHGI BLFPNJPCADF;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4832290", Offset = "0x4831490", VA = "0x184832290", Slot = "4")]
		public virtual void MDPAGNEJHAM(MethodInfo HGCCIKABGFF, MethodInfo IHGIPABBOKB, KACBHDGHHGI MDOOANEGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void IMGLNOCEPOF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ICHPKHMDNGE(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
		protected JKHPADGOOHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CHMDBMLMONN<TClass, TProperty> : JKHPADGOOHF<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> FFBDOGEIHLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> DNFBILIDMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> OOLJNBPKFDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> KMBLHHOFNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> CAGMGFHHDEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> MEAFBKOJFFD;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x578F730", Offset = "0x578E930", VA = "0x18578F730", Slot = "7")]
		public override void IPEKLCMOECF(TClass DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x578D160", Offset = "0x578C360", VA = "0x18578D160", Slot = "8")]
		public override void BDIALKELKDB(TClass DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x578ED90", Offset = "0x578DF90", VA = "0x18578ED90", Slot = "9")]
		public override void IMGLNOCEPOF(TClass DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x578E3F0", Offset = "0x578D5F0", VA = "0x18578E3F0", Slot = "10")]
		public override void ICHPKHMDNGE(TClass DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x578DBE0", Offset = "0x578CDE0", VA = "0x18578DBE0")]
		protected TProperty[] GFNAJHHBJFA(TClass DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x578FF10", Offset = "0x578F110", VA = "0x18578FF10")]
		protected TProperty[] KNMJGFIKEBB(TClass DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5791BB0", Offset = "0x5790DB0", VA = "0x185791BB0", Slot = "4")]
		public override void MDPAGNEJHAM(MethodInfo HGCCIKABGFF, MethodInfo IHGIPABBOKB, KACBHDGHHGI MDOOANEGCAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3F148D0", Offset = "0x3F13AD0", VA = "0x183F148D0")]
		protected CHMDBMLMONN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class IEEEKNNDCPJ<TClass, TProperty> : CHMDBMLMONN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void GAJBGMFKGAJ(JIHDPNNKJJH KBNPICMCGIJ, [Out] TProperty HIMCBHGOGFP);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void CLEBIIKGDLO(MJEKGNAFCGO JIBFOCJJOLJ, TProperty HIMCBHGOGFP);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x45B2610", Offset = "0x45B1810", VA = "0x1845B2610", Slot = "5")]
		public override void IFPJADONGKG(TClass DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x45B2470", Offset = "0x45B1670", VA = "0x1845B2470", Slot = "6")]
		public override void CCDEIAGNOJL(TClass DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x45B2770", Offset = "0x45B1970", VA = "0x1845B2770", Slot = "7")]
		public override void IPEKLCMOECF(TClass DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x45B22F0", Offset = "0x45B14F0", VA = "0x1845B22F0", Slot = "8")]
		public override void BDIALKELKDB(TClass DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F22090", Offset = "0x3F21290", VA = "0x183F22090")]
		protected IEEEKNNDCPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class LLEBEPCHALB<T> : CHMDBMLMONN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4A01210", Offset = "0x4A00410", VA = "0x184A01210", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x46582E0", Offset = "0x46574E0", VA = "0x1846582E0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4A01290", Offset = "0x4A00490", VA = "0x184A01290", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4658270", Offset = "0x4657470", VA = "0x184658270", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public LLEBEPCHALB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class IMOLJAKFNJJ<T> : CHMDBMLMONN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4658350", Offset = "0x4657550", VA = "0x184658350", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x46582E0", Offset = "0x46574E0", VA = "0x1846582E0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x46583D0", Offset = "0x46575D0", VA = "0x1846583D0", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4658270", Offset = "0x4657470", VA = "0x184658270", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public IMOLJAKFNJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class EONFMCJEIOL<T> : CHMDBMLMONN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F295F0", Offset = "0x3F287F0", VA = "0x183F295F0", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F29580", Offset = "0x3F28780", VA = "0x183F29580", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3F29670", Offset = "0x3F28870", VA = "0x183F29670", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3F29510", Offset = "0x3F28710", VA = "0x183F29510", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public EONFMCJEIOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class MIEBBOPDMND<T> : CHMDBMLMONN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9C00", Offset = "0x4BF8E00", VA = "0x184BF9C00", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3F29580", Offset = "0x3F28780", VA = "0x183F29580", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9C80", Offset = "0x4BF8E80", VA = "0x184BF9C80", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3F29510", Offset = "0x3F28710", VA = "0x183F29510", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public MIEBBOPDMND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class HPLJBPBPBNG<T> : CHMDBMLMONN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x44F9E50", Offset = "0x44F9050", VA = "0x1844F9E50", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3F665B0", Offset = "0x3F657B0", VA = "0x183F665B0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x44F9ED0", Offset = "0x44F90D0", VA = "0x1844F9ED0", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F66540", Offset = "0x3F65740", VA = "0x183F66540", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public HPLJBPBPBNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class EPMBCLCDBOO<T> : CHMDBMLMONN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F66620", Offset = "0x3F65820", VA = "0x183F66620", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3F665B0", Offset = "0x3F657B0", VA = "0x183F665B0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3F666A0", Offset = "0x3F658A0", VA = "0x183F666A0", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F66540", Offset = "0x3F65740", VA = "0x183F66540", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public EPMBCLCDBOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class FHHMJJFANKL<T> : CHMDBMLMONN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F18400", Offset = "0x3F17600", VA = "0x183F18400", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F18390", Offset = "0x3F17590", VA = "0x183F18390", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x42E6490", Offset = "0x42E5690", VA = "0x1842E6490", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F13D60", Offset = "0x3F12F60", VA = "0x183F13D60", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public FHHMJJFANKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EIKBFCFNKGI<T> : CHMDBMLMONN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3F18400", Offset = "0x3F17600", VA = "0x183F18400", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3F18390", Offset = "0x3F17590", VA = "0x183F18390", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3F18480", Offset = "0x3F17680", VA = "0x183F18480", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3F13D60", Offset = "0x3F12F60", VA = "0x183F13D60", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public EIKBFCFNKGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class DIMDMBFDHHM<T> : CHMDBMLMONN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6077AD0", Offset = "0x6076CD0", VA = "0x186077AD0", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6077A60", Offset = "0x6076C60", VA = "0x186077A60", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6077B50", Offset = "0x6076D50", VA = "0x186077B50", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4658270", Offset = "0x4657470", VA = "0x184658270", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public DIMDMBFDHHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MLCLIGPDGOP<T> : CHMDBMLMONN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4C01F20", Offset = "0x4C01120", VA = "0x184C01F20", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4C01EB0", Offset = "0x4C010B0", VA = "0x184C01EB0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C01FA0", Offset = "0x4C011A0", VA = "0x184C01FA0", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3F66540", Offset = "0x3F65740", VA = "0x183F66540", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public MLCLIGPDGOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class EGMBNHJKOGD<T> : CHMDBMLMONN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3F13E40", Offset = "0x3F13040", VA = "0x183F13E40", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F13DD0", Offset = "0x3F12FD0", VA = "0x183F13DD0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F13EC0", Offset = "0x3F130C0", VA = "0x183F13EC0", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F13D60", Offset = "0x3F12F60", VA = "0x183F13D60", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F13F40", Offset = "0x3F13140", VA = "0x183F13F40")]
		public EGMBNHJKOGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class IJHJNKJOOMO<T> : IEEEKNNDCPJ<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x464AD90", Offset = "0x4649F90", VA = "0x18464AD90", Slot = "12")]
		protected override void CLEBIIKGDLO(MJEKGNAFCGO JIBFOCJJOLJ, char HIMCBHGOGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x464ADC0", Offset = "0x4649FC0", VA = "0x18464ADC0", Slot = "11")]
		protected override void GAJBGMFKGAJ(JIHDPNNKJJH KBNPICMCGIJ, [Out] char HIMCBHGOGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
		public IJHJNKJOOMO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ILLAOACFMKL<T> : IEEEKNNDCPJ<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x464FF50", Offset = "0x464F150", VA = "0x18464FF50", Slot = "12")]
		protected override void CLEBIIKGDLO(MJEKGNAFCGO JIBFOCJJOLJ, IPEndPoint HIMCBHGOGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x464FF80", Offset = "0x464F180", VA = "0x18464FF80", Slot = "11")]
		protected override void GAJBGMFKGAJ(JIHDPNNKJJH KBNPICMCGIJ, [Out] IPEndPoint HIMCBHGOGFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x42DEC80", Offset = "0x42DDE80", VA = "0x1842DEC80")]
		public ILLAOACFMKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class OAGJNHINOCE<T> : CHMDBMLMONN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int FHINAONMAPC;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4D83390", Offset = "0x4D82590", VA = "0x184D83390")]
		public OAGJNHINOCE(int ODKEIFCIJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4D83290", Offset = "0x4D82490", VA = "0x184D83290", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4D83210", Offset = "0x4D82410", VA = "0x184D83210", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x4D83310", Offset = "0x4D82510", VA = "0x184D83310", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x4D83190", Offset = "0x4D82390", VA = "0x184D83190", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class ENJKBPBJAAA<T> : JKHPADGOOHF<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo OMPKIFGNKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type AMLJAIEJCNA;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F27F70", Offset = "0x3F27170", VA = "0x183F27F70")]
		public ENJKBPBJAAA(PropertyInfo FPOONLFOOIF, Type BIKNALKNCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3F27DF0", Offset = "0x3F26FF0", VA = "0x183F27DF0", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F27CE0", Offset = "0x3F26EE0", VA = "0x183F27CE0", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F27F10", Offset = "0x3F27110", VA = "0x183F27F10", Slot = "7")]
		public override void IPEKLCMOECF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3F27C80", Offset = "0x3F26E80", VA = "0x183F27C80", Slot = "8")]
		public override void BDIALKELKDB(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3F27EB0", Offset = "0x3F270B0", VA = "0x183F27EB0", Slot = "9")]
		public override void IMGLNOCEPOF(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3F27D90", Offset = "0x3F26F90", VA = "0x183F27D90", Slot = "10")]
		public override void ICHPKHMDNGE(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class CFNJNMLOKCO<T> : ENJKBPBJAAA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBD20", Offset = "0x3EFAF20", VA = "0x183EFBD20")]
		public CFNJNMLOKCO(PropertyInfo FPOONLFOOIF, Type BIKNALKNCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x577FB10", Offset = "0x577ED10", VA = "0x18577FB10", Slot = "5")]
		public override void IFPJADONGKG(T DDNFFDGMKDB, JIHDPNNKJJH KBNPICMCGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x577FA60", Offset = "0x577EC60", VA = "0x18577FA60", Slot = "6")]
		public override void CCDEIAGNOJL(T DDNFFDGMKDB, MJEKGNAFCGO JIBFOCJJOLJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class FDLHPMJIODN<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static FDLHPMJIODN<T> CLACNPDFIIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly JKHPADGOOHF<T>[] PLNJGMGHLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int KEBPFHDIAAA;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x42E1FA0", Offset = "0x42E11A0", VA = "0x1842E1FA0")]
		public FDLHPMJIODN(List<JKHPADGOOHF<T>> BLJAFFMNHJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x42E1E40", Offset = "0x42E1040", VA = "0x1842E1E40")]
		public void CCDEIAGNOJL(T LCACGJDNDHA, MJEKGNAFCGO JPECNBJOJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x42E1EF0", Offset = "0x42E10F0", VA = "0x1842E1EF0")]
		public void IFPJADONGKG(T LCACGJDNDHA, JIHDPNNKJJH NHPBIOODHLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class CALMLOCNFED
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract JKHPADGOOHF<T> BGMHNJIJIDG<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private MJEKGNAFCGO DNAJDNOHPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int IDFNJFLJBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, CALMLOCNFED> KMGCLLMDKPI;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x65ABD50", Offset = "0x65AAF50", VA = "0x1865ABD50")]
	public HGCCCJGEOFC(int BEKLMIPGELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x328C7E0", Offset = "0x328B9E0", VA = "0x18328C7E0")]
	private FDLHPMJIODN<T> NHEDOAMCAKB<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3053810", Offset = "0x3052A10", VA = "0x183053810")]
	public void JMFBCAGPLCG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x328C6B0", Offset = "0x328B8B0", VA = "0x18328C6B0")]
	public bool LAEIJKNHIPI<T>(JIHDPNNKJJH NHPBIOODHLE, T MKMPLOHPJDC) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x328C750", Offset = "0x328B950", VA = "0x18328C750")]
	public void LKDLAIOBOFF<T>(MJEKGNAFCGO JPECNBJOJNA, T LCACGJDNDHA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BDJHJMFONJP
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime FDAGEGONNEB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] AAGGNGGEHHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DNMILCODEOC OBIJAPOEONC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x659FE30", Offset = "0x659F030", VA = "0x18659FE30")]
		get
		{
			return default(DNMILCODEOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int LOKMEGCBIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x65A0060", Offset = "0x659F260", VA = "0x1865A0060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x65A0420", Offset = "0x659F620", VA = "0x1865A0420")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EMFFKOKLMDJ MGKAEFACEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x659FE00", Offset = "0x659F000", VA = "0x18659FE00")]
		get
		{
			return default(EMFFKOKLMDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x659F950", Offset = "0x659EB50", VA = "0x18659F950")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MMELMGPBKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x65A0580", Offset = "0x659F780", VA = "0x1865A0580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint KPIGLGGCGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x65A05B0", Offset = "0x659F7B0", VA = "0x1865A05B0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? BJPFBBBIKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x659F890", Offset = "0x659EA90", VA = "0x18659F890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? PGKEMBJPPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x65A03F0", Offset = "0x659F5F0", VA = "0x1865A03F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? EAKGNJDFMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x659FDD0", Offset = "0x659EFD0", VA = "0x18659FDD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x659F6C0", Offset = "0x659E8C0", VA = "0x18659F6C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? MHLCHDPOKIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB970", Offset = "0xAAAB70", VA = "0x180AAB970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC70CE0", Offset = "0xC6FEE0", VA = "0x180C70CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x65A0690", Offset = "0x659F890", VA = "0x1865A0690")]
	public BDJHJMFONJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x65A09B0", Offset = "0x659FBB0", VA = "0x1865A09B0")]
	internal BDJHJMFONJP(byte[] JIGDFCPIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x65A0460", Offset = "0x659F660", VA = "0x1865A0460")]
	public static BDJHJMFONJP PCJFAEKKGFE(byte[] JIGDFCPIKCH, DateTime PEGLCEIAFFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x659FE60", Offset = "0x659F060", VA = "0x18659FE60")]
	internal void IIHPJKCENCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x659F9F0", Offset = "0x659EBF0", VA = "0x18659F9F0")]
	private void GICBNPDNBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x659FBD0", Offset = "0x659EDD0", VA = "0x18659FBD0")]
	private DateTime? HCGIGJHILMD(int KLICPJBJAIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x65A0220", Offset = "0x659F420", VA = "0x1865A0220")]
	private void LAEFPLACBMG(int KLICPJBJAIA, DateTime? OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x65A0150", Offset = "0x659F350", VA = "0x1865A0150")]
	private ulong KLNGBPHMDCB(int KLICPJBJAIA)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x65A0090", Offset = "0x659F290", VA = "0x1865A0090")]
	private void JDOFLJJAJHI(int KLICPJBJAIA, ulong OMEFCJCOLII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x659F8C0", Offset = "0x659EAC0", VA = "0x18659F8C0")]
	private uint FMHBPFNCMEM(int KLICPJBJAIA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6471B80", Offset = "0x6470D80", VA = "0x186471B80")]
	private static uint GBLHFJGKLMF(uint KIEMJAMMNPB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x659F990", Offset = "0x659EB90", VA = "0x18659F990")]
	private static ulong GBLHFJGKLMF(ulong KIEMJAMMNPB)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum DNMILCODEOC
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
public enum EMFFKOKLMDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class OMLPIIFBLIC
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int ENGKAJOMGJH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int DEFCHNLDJON = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int HAOGIJOOANI = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint JBHBALCKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int CCBJBOFHBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int GLHDFOHIMDF;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JLPIIAIAJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x65B5990", Offset = "0x65B4B90", VA = "0x1865B5990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x65B58A0", Offset = "0x65B4AA0", VA = "0x1865B58A0")]
	public bool DGLOBOPALIN(DDPAGMBGMLL DOLANKJKKHC, int EFKOIGNGJGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class NNLLIBBOOAE : DDPAGMBGMLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket DOLANKJKKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly CNDBJPBABCJ CPIHHKGCJFE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short MLLIDEGGADO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x65B4E20", Offset = "0x65B4020", VA = "0x1865B4E20", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int AKDNOCOENMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x65B4F30", Offset = "0x65B4130", VA = "0x1865B4F30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint HEFPJCCOHLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x65B4F50", Offset = "0x65B4150", VA = "0x1865B4F50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily LJGHEBHHBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x49AB2F0", Offset = "0x49AA4F0", VA = "0x1849AB2F0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x65B5590", Offset = "0x65B4790", VA = "0x1865B5590")]
	public NNLLIBBOOAE(AddressFamily IIECCGHMBBE, CNDBJPBABCJ CPIHHKGCJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x65B4FD0", Offset = "0x65B41D0", VA = "0x1865B4FD0", Slot = "8")]
	public bool NJHAKBGIMHB(IPEndPoint LGILCDPHGCM, MMBBHFNJLEB FLKIJKMEKKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x65B4F70", Offset = "0x65B4170", VA = "0x1865B4F70", Slot = "9")]
	public int CPFALMEIHMM(byte[] HJDGEKDMIGG, int KLICPJBJAIA, int AFLMMFDMNOE, IPEndPoint HLMCAHANHPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x65B4E40", Offset = "0x65B4040", VA = "0x1865B4E40", Slot = "10")]
	public int APEJGCLIJLH(byte[] HJDGEKDMIGG, EndPoint KPDPJFMJCFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x65B4FB0", Offset = "0x65B41B0", VA = "0x1865B4FB0", Slot = "11")]
	public void KNICDHFCPGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface DDPAGMBGMLL
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short MLLIDEGGADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int AKDNOCOENMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint HEFPJCCOHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily LJGHEBHHBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NJHAKBGIMHB(IPEndPoint LGILCDPHGCM, MMBBHFNJLEB FLKIJKMEKKI);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CPFALMEIHMM(byte[] HJDGEKDMIGG, int KLICPJBJAIA, int AFLMMFDMNOE, IPEndPoint HLMCAHANHPC);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int APEJGCLIJLH(byte[] HJDGEKDMIGG, EndPoint HLMCAHANHPC);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KNICDHFCPGO();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct FCHLKHNKJMM : IEquatable<FCHLKHNKJMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long DJAALKBINCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long AGJECFBNCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long OFHCPAFOAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int EIELCHDENIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int PIELOJFDBHN;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFE0", Offset = "0x65AA1E0", VA = "0x1865AAFE0")]
	public FCHLKHNKJMM(byte[] IEILKJKDKAG, int MGBOOMFNHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x91B6D0", Offset = "0x91A8D0", VA = "0x18091B6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x65AAFA0", Offset = "0x65AA1A0", VA = "0x1865AAFA0", Slot = "4")]
	public bool Equals(FCHLKHNKJMM JAINJPLCLDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x65AAEF0", Offset = "0x65AA0F0", VA = "0x1865AAEF0", Slot = "0")]
	public override bool Equals(object LCACGJDNDHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class HFFAJJBNIOD : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] EJJANCHFMKE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class GKIAOFHBENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int PCJDOEKIKIF;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
	protected GKIAOFHBENC(int PLEPBLDEPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LOGGKCJPNBO(IPEndPoint LGILCDPHGCM, byte[] LFDKFEEPNFP, int KLICPJBJAIA, int BJJBELCKPHA);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void PPKMLNHJGAM(IPEndPoint LGILCDPHGCM, byte[] LFDKFEEPNFP, int KLICPJBJAIA, int BJJBELCKPHA);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class JDMBKPIHHGK : GKIAOFHBENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] OFPBICPHALF;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator JFPEGEPNFFO;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2541B50", Offset = "0x2540D50", VA = "0x182541B50")]
	public JDMBKPIHHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x65AC360", Offset = "0x65AB560", VA = "0x1865AC360")]
	public void CPDDOEGDJDN(IPEndPoint LGILCDPHGCM, byte[] OFPBICPHALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x65AC9C0", Offset = "0x65ABBC0", VA = "0x1865AC9C0")]
	public void NMNCBBNPCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x65AC510", Offset = "0x65AB710", VA = "0x1865AC510", Slot = "4")]
	public override void LOGGKCJPNBO(IPEndPoint LGILCDPHGCM, byte[] LFDKFEEPNFP, int KLICPJBJAIA, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x65ACAA0", Offset = "0x65ABCA0", VA = "0x1865ACAA0", Slot = "5")]
	public override void PPKMLNHJGAM(IPEndPoint LGILCDPHGCM, byte[] LFDKFEEPNFP, int KLICPJBJAIA, int BJJBELCKPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct LONINPJMGNC
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void CNKANANKGPJ([NoAlias] byte* OFOBMGKMBIE, [NoAlias] byte* OFPBICPHALF, [NoAlias] byte* PHFLHIMKFAG, int BJJBELCKPHA);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class KMDGBPMEIPK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr PKJOPOHJLKP;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr ANFHAEOPFNP;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x65B6F00", Offset = "0x65B6100", VA = "0x1865B6F00")]
		[BurstDiscard]
		private static void MLCJALKEJPD(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x65B6DA0", Offset = "0x65B5FA0", VA = "0x1865B6DA0")]
		private static IntPtr IIKDHFGKDPG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x65B7030", Offset = "0x65B6230", VA = "0x1865B7030")]
		public static void PGMOHMCCKAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
		public static void GGPOBANFNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x65B6B60", Offset = "0x65B5D60", VA = "0x1865B6B60")]
		public unsafe static void HJOIGAOEAFJ([NoAlias] byte* OFOBMGKMBIE, [NoAlias] byte* OFPBICPHALF, [NoAlias] byte* PHFLHIMKFAG, int BJJBELCKPHA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint OFPBICPHALF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint PHFLHIMKFAG[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint DKFEPNDEDDO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint DLLLLEGOGJL[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint KKGBAMBFGJC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint OLECDOCIEIK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint BMAJAHPOBIL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint NNDEIOPOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint CPAOLHHHHDI[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x65B2480", Offset = "0x65B1680", VA = "0x1865B2480")]
	private void OKECIINHNOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x65B2220", Offset = "0x65B1420", VA = "0x1865B2220")]
	private uint IJHLKNMEBGK(uint PBNOOPEKDOL, int MANFIKLMHPH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x659F570", Offset = "0x659E770", VA = "0x18659F570")]
	private void MLMJBDNHDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x659F360", Offset = "0x659E560", VA = "0x18659F360")]
	private void LNAJPADIHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x659F2D0", Offset = "0x659E4D0", VA = "0x18659F2D0")]
	private void KMBJBPOLLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x659F1D0", Offset = "0x659E3D0", VA = "0x18659F1D0")]
	private void GCJJEJINFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x65B2250", Offset = "0x65B1450", VA = "0x1865B2250")]
	private void KMKJLCCKCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x65B2500", Offset = "0x65B1700", VA = "0x1865B2500")]
	private unsafe void OPIMGDCIHDL(byte* OFOBMGKMBIE, uint* OFPBICPHALF, uint* PHFLHIMKFAG, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x65B2320", Offset = "0x65B1520", VA = "0x1865B2320")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void NNODCIHNADM([NoAlias] byte* OFOBMGKMBIE, [NoAlias] byte* OFPBICPHALF, [NoAlias] byte* PHFLHIMKFAG, int BJJBELCKPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x65B23A0", Offset = "0x65B15A0", VA = "0x1865B23A0")]
	public static void NNODCIHNADM(Span<byte> OFOBMGKMBIE, Span<byte> OFPBICPHALF, Span<byte> PHFLHIMKFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x65B2120", Offset = "0x65B1320", VA = "0x1865B2120")]
	public static void BMFPEBOKCKI(Span<byte> OFOBMGKMBIE, Span<byte> OFPBICPHALF, Span<byte> PHFLHIMKFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x65B22B0", Offset = "0x65B14B0", VA = "0x1865B22B0")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void MMKAOPEALNN([NoAlias] byte* OFOBMGKMBIE, [NoAlias] byte* OFPBICPHALF, [NoAlias] byte* PHFLHIMKFAG, int BJJBELCKPHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x65B70E0", Offset = "0x65B62E0", VA = "0x1865B70E0")]
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
