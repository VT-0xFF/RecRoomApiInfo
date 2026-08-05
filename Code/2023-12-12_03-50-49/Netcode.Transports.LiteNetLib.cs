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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, DKFGJHKEMNL
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum KGNIPBAIPKG
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
		private NetworkManager CFJEIMHIEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, CFOKFLAAELB> IBCCKHNDEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BLHBBMDKLKP DFLHDFDCDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] OKHOALFJCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KGNIPBAIPKG NILPKHCANBL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong IDLJJEKBOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GJIDBOBEGFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5345520", Offset = "0x5343D20", VA = "0x185345520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5344A20", Offset = "0x5343220", VA = "0x185344A20")]
		public void RecRoom_SetEncryptionInfo(ulong HCAACMFJMHK, byte[] EMBEECDJLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5344A00", Offset = "0x5343200", VA = "0x185344A00")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x53448D0", Offset = "0x53430D0", VA = "0x1853448D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5345420", Offset = "0x5343C20", VA = "0x185345420")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5344C20", Offset = "0x5343420", VA = "0x185344C20", Slot = "6")]
		public override void Send(ulong BIFKICBKPCC, ArraySegment<byte> FCHBDAMJEHN, NetworkDelivery DIBMNDKBGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x53449C0", Offset = "0x53431C0", VA = "0x1853449C0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BIFKICBKPCC, [Out] ArraySegment<byte> IOHCLNMNKCI, [Out] float AENOOADCBFN)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5344F10", Offset = "0x5343710", VA = "0x185344F10", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5345340", Offset = "0x5343B40", VA = "0x185345340", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5343DA0", Offset = "0x53425A0", VA = "0x185343DA0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BIFKICBKPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5343C50", Offset = "0x5342450", VA = "0x185343C50", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5344000", Offset = "0x5342800", VA = "0x185344000", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BIFKICBKPCC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5344EA0", Offset = "0x53436A0", VA = "0x185344EA0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x53443B0", Offset = "0x5342BB0", VA = "0x1853443B0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager CFJEIMHIEFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x53442E0", Offset = "0x5342AE0", VA = "0x1853442E0")]
		private FDFEMKLNKHC IHOIGLHLMBG(NetworkDelivery HJNJPNKDEFH)
		{
			return default(FDFEMKLNKHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5343F10", Offset = "0x5342710", VA = "0x185343F10", Slot = "15")]
		private void EHIFHJJLOIH(CFOKFLAAELB OCKELOKNLJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5344180", Offset = "0x5342980", VA = "0x185344180", Slot = "16")]
		private void HNIOPAKLNAE(CFOKFLAAELB OCKELOKNLJE, MNMEFPICNJF KBJBAFGJPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "17")]
		private void KCBKFADBDKK(IPEndPoint CPOHNJPIGON, SocketError LEDBIACLGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5344570", Offset = "0x5342D70", VA = "0x185344570", Slot = "18")]
		private void JIMNGILHKGJ(CFOKFLAAELB OCKELOKNLJE, PMNJOEDBKHA EINLOJPKPLI, byte GIKBKKCAKAP, FDFEMKLNKHC DOLNOGIENIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53440A0", Offset = "0x53428A0", VA = "0x1853440A0")]
		private void HDGJJMJFNHF(int NKCDHJPJBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "19")]
		private void HCOJCBHNMPJ(IPEndPoint GDKALMJKDCN, PMNJOEDBKHA EINLOJPKPLI, CPHBEMOFAPD ODMIODEIPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "20")]
		private void MLFKCFPGOLD(CFOKFLAAELB OCKELOKNLJE, int DJJJDDPJFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5344870", Offset = "0x5343070", VA = "0x185344870", Slot = "21")]
		private void NKGEBPEJLFJ(ABAIPDPHJED KOFJNFGLAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5343FD0", Offset = "0x53427D0", VA = "0x185343FD0")]
		private ulong GMHDCDBFKMO(CFOKFLAAELB OCKELOKNLJE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x53442C0", Offset = "0x5342AC0", VA = "0x1853442C0")]
		private static int IBNGPKANLKG(float GDAIBLFKMLM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5345440", Offset = "0x5343C40", VA = "0x185345440")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class MONFPENDGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly CFOKFLAAELB CJDBGFBMAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<MGAHMHJPDAM> DLKKIPJPEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int OBPAELONFKF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5346460", Offset = "0x5344C60", VA = "0x185346460")]
	protected MONFPENDGLE(CFOKFLAAELB OCKELOKNLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5346340", Offset = "0x5344B40", VA = "0x185346340")]
	public void DCJONDGBIDJ(MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x53463A0", Offset = "0x5344BA0", VA = "0x1853463A0")]
	protected void HMJDJBOPOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5346420", Offset = "0x5344C20", VA = "0x185346420")]
	public bool NDEGAMGJBGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool IIHEGHGNJAP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool FAAJDKFOGFM(MGAHMHJPDAM DACNPGFDDMN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum JHBBPLIPHKJ
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
public class ABAIPDPHJED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BLHBBMDKLKP DBPIKJPPPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int FCLEKMNHDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal HPBCHALKFIL EGNPKMOGBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint BNDKNKMGLNG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal JHBBPLIPHKJ DPPDJIKGIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x79A730", Offset = "0x798F30", VA = "0x18079A730")]
		[CompilerGenerated]
		get
		{
			return default(JHBBPLIPHKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x89AEF0", Offset = "0x8996F0", VA = "0x18089AEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5332320", Offset = "0x5330B20", VA = "0x185332320")]
	internal void DMDFBEFBOAB(HPBCHALKFIL IKLDIBALDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x53323E0", Offset = "0x5330BE0", VA = "0x1853323E0")]
	private bool JPOAHIIFJMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5332410", Offset = "0x5330C10", VA = "0x185332410")]
	internal ABAIPDPHJED(IPEndPoint GDKALMJKDCN, HPBCHALKFIL HLCGPOBPKFP, BLHBBMDKLKP JBKEDPHDJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5332380", Offset = "0x5330B80", VA = "0x185332380")]
	public CFOKFLAAELB EADKMGEDPCM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum CPHBEMOFAPD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OIMDLPLLFPO
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
public struct MNMEFPICNJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OIMDLPLLFPO LLPPGOBCPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError CEHEGBHFPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public PMNJOEDBKHA JECAOFENFCA;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DKFGJHKEMNL
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLDDJCBCGIC(CFOKFLAAELB OCKELOKNLJE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OEGGGAOBEMC(CFOKFLAAELB OCKELOKNLJE, MNMEFPICNJF KBJBAFGJPHI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKCCOCBPMCC(IPEndPoint CPOHNJPIGON, SocketError LEDBIACLGCL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BEEFDNMIBEI(CFOKFLAAELB OCKELOKNLJE, PMNJOEDBKHA EINLOJPKPLI, byte GIKBKKCAKAP, FDFEMKLNKHC DOLNOGIENIC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPLBGAPONBH(IPEndPoint GDKALMJKDCN, PMNJOEDBKHA EINLOJPKPLI, CPHBEMOFAPD ODMIODEIPOA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFAKJGKODOI(CFOKFLAAELB OCKELOKNLJE, int DJJJDDPJFGH);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KEHAAHHBELD(ABAIPDPHJED KOFJNFGLAFK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MONIOMHMFFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKGAGNHMHPC(CFOKFLAAELB OCKELOKNLJE, object OMHFAAFCGEJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface IJINKMBDGIN
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KADIDMCOBMB(CEOPGKFBGOD DACNPGFDDMN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDAEGHBFACE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJAAHHLJAKN(CFOKFLAAELB OCKELOKNLJE, IPEndPoint OPNFLAHCEGI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class HPBCHALKFIL
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int BGOJBHBBBCD = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long LLBFHEFCDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte NGIEMGLFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] DDCOJILHIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly ALCLJHBOBGE GKMCBGMNDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int CDJFEPANEOJ;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5341BB0", Offset = "0x53403B0", VA = "0x185341BB0")]
	private HPBCHALKFIL(long HFFPDJEAGEE, byte ECPKKKPODIJ, int HFMJJPJADMB, byte[] FIHOOALIJAG, ALCLJHBOBGE FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5341970", Offset = "0x5340170", VA = "0x185341970")]
	public static int ICECNNLEGPI(MGAHMHJPDAM DACNPGFDDMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5341750", Offset = "0x533FF50", VA = "0x185341750")]
	public static HPBCHALKFIL FNPMANGBJJF(MGAHMHJPDAM DACNPGFDDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x53419D0", Offset = "0x53401D0", VA = "0x1853419D0")]
	public static MGAHMHJPDAM NOEMLLOIBKL(PDLJIICEKFI GNABOBNOFNA, SocketAddress PFMOKFADENM, long MGBMCBIKHHG, int HFMJJPJADMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class LEJOOLOFGHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long LLBFHEFCDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte NGIEMGLFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int CDJFEPANEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool PDPGIMOJAIG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x53431A0", Offset = "0x53419A0", VA = "0x1853431A0")]
	private LEJOOLOFGHE(long HFFPDJEAGEE, byte ECPKKKPODIJ, int ICHACDBFKMA, bool LGGDPNJHIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5342F60", Offset = "0x5341760", VA = "0x185342F60")]
	public static LEJOOLOFGHE FNPMANGBJJF(MGAHMHJPDAM DACNPGFDDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x53430B0", Offset = "0x53418B0", VA = "0x1853430B0")]
	public static MGAHMHJPDAM NOEMLLOIBKL(long MGBMCBIKHHG, byte ONJJMDHNDGF, int MOIKEDCFIPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5342E60", Offset = "0x5341660", VA = "0x185342E60")]
	public static MGAHMHJPDAM CKLIFMPJKCM(CFOKFLAAELB OCKELOKNLJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct DGAFAHDDKGB : IEquatable<DGAFAHDDKGB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly long HJKPIPAHJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly long AMFCOKHNIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly long ANBKAAHJIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int JACJKHDIHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly int ILFKLBPAJEN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5340240", Offset = "0x533EA40", VA = "0x185340240")]
	public DGAFAHDDKGB(byte[] CBDHFBPDECG, int BPIHAIKFCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79A730", Offset = "0x798F30", VA = "0x18079A730", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5340200", Offset = "0x533EA00", VA = "0x185340200", Slot = "4")]
	public bool Equals(DGAFAHDDKGB FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5340150", Offset = "0x533E950", VA = "0x185340150", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class FJMAFNNCAEJ : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly byte[] JEFEGFEEJNA;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x53410A0", Offset = "0x533F8A0", VA = "0x1853410A0")]
	public FJMAFNNCAEJ(byte[] CBDHFBPDECG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal static class JIJKOEGNNKL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private static class GIKPBPDBKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5341530", Offset = "0x533FD30", VA = "0x185341530")]
		public static extern int KLELDMILAGB(IntPtr BABKKLEBDNO, [In][Out] byte[] OHLLHADDDGD, [In] int BPIHAIKFCAF, [In] SocketFlags FNCLFGLCHMB, [Out] byte[] KGKLCDEPDFL, [In][Out] int JEOAHJFIACH);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5341670", Offset = "0x533FE70", VA = "0x185341670")]
		internal static extern int LMCPPIDMHLK(IntPtr BABKKLEBDNO, [In] byte[] OHLLHADDDGD, [In] int BPIHAIKFCAF, [In] SocketFlags FNCLFGLCHMB, [In] byte[] KGKLCDEPDFL, [In] int JEOAHJFIACH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private static class JEEKEBOCNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5341C30", Offset = "0x5340430", VA = "0x185341C30")]
		public static extern int KLELDMILAGB(IntPtr BABKKLEBDNO, [In][Out] byte[] OHLLHADDDGD, [In] int BPIHAIKFCAF, [In] SocketFlags FNCLFGLCHMB, [Out] byte[] KGKLCDEPDFL, [In][Out] int JEOAHJFIACH);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5341D70", Offset = "0x5340570", VA = "0x185341D70")]
		internal static extern int LMCPPIDMHLK(IntPtr BABKKLEBDNO, [In] byte[] OHLLHADDDGD, [In] int BPIHAIKFCAF, [In] SocketFlags FNCLFGLCHMB, [In] byte[] KGKLCDEPDFL, [In] int JEOAHJFIACH);
	}

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly bool GJIDBOBEGFF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public static readonly bool GJBLJFAJENC;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Dictionary<int, SocketError> EHMIPMAFANL;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5342370", Offset = "0x5340B70", VA = "0x185342370")]
	static JIJKOEGNNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5341F90", Offset = "0x5340790", VA = "0x185341F90")]
	public static int FKMEKJNJCPP(IntPtr BABKKLEBDNO, byte[] OHLLHADDDGD, int BPIHAIKFCAF, byte[] KGKLCDEPDFL, int JEOAHJFIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x53421E0", Offset = "0x53409E0", VA = "0x1853421E0")]
	public static int NADAFCOAJIG(IntPtr BABKKLEBDNO, byte[] OHLLHADDDGD, int BPIHAIKFCAF, byte[] KGKLCDEPDFL, int JEOAHJFIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5342040", Offset = "0x5340840", VA = "0x185342040")]
	public static SocketError LBCBKCJIANC()
	{
		return default(SocketError);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5341E50", Offset = "0x5340650", VA = "0x185341E50")]
	public static SocketException AOMEJPIPPOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5342130", Offset = "0x5340930", VA = "0x185342130")]
	public static short MMKGHFGHAEK(IPEndPoint GDKALMJKDCN)
	{
		return default(short);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PPGMNGFBNJI
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EHGJOOFGJMD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELMPPKGOCAA(IPEndPoint MOMHLBCEFNH, IPEndPoint GDKALMJKDCN, string JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFIEEFOBKFP(IPEndPoint EIAAIJJMMIJ, PPGMNGFBNJI HJNJPNKDEFH, string JECMOKMEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class LEKCEPHKEAP
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private struct MPGMCKNIMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IPEndPoint ELPOBJPEPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public IPEndPoint BNDKNKMGLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string GEFKAGHCNOC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private struct LIOHCFIEMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public IPEndPoint HJHDOHMJEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public PPGMNGFBNJI CCNHBOAJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public string GEFKAGHCNOC;
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class CEKGCFKNNPF
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint MLHFMFDIMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string GEFKAGHCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CEKGCFKNNPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class IKKMFCGKPKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint MLHFMFDIMNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint AOGKOLFKPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GEFKAGHCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public IKKMFCGKPKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class NLGINKPMJPK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GEFKAGHCNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772320", VA = "0x180773B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GNADOFKCINE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x775870", Offset = "0x774070", VA = "0x180775870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public NLGINKPMJPK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly BLHBBMDKLKP NKNJPOAHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ConcurrentQueue<MPGMCKNIMBL> BOOKHKAHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ConcurrentQueue<LIOHCFIEMCO> LNACDCECJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly ALCLJHBOBGE GHJJELGCJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly PDLJIICEKFI KCFDCKDAIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly MMLPIMHMJHL MIPPNJPHDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private EHGJOOFGJMD BPHDNBOFJMA;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public const int GLBGKGEFEIC = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool GGMENDAAMFH;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5343800", Offset = "0x5342000", VA = "0x185343800")]
	internal LEKCEPHKEAP(BLHBBMDKLKP JCEJGLPIBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x53436A0", Offset = "0x5341EA0", VA = "0x1853436A0")]
	internal void PJJICICCBDH(IPEndPoint EEJNKOBGGIM, MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2566420", Offset = "0x2564C20", VA = "0x182566420")]
	private void NBEHFMGBFJF<T>(T DACNPGFDDMN, IPEndPoint MAKBFCPADHF) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x53431F0", Offset = "0x53419F0", VA = "0x1853431F0")]
	private void ELMPPKGOCAA(CEKGCFKNNPF BGFCHABMAHL, IPEndPoint EEJNKOBGGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5343520", Offset = "0x5341D20", VA = "0x185343520")]
	private void NJBDCBMEEHD(IKKMFCGKPKH BGFCHABMAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5343380", Offset = "0x5341B80", VA = "0x185343380")]
	private void MFNENFGBABP(NLGINKPMJPK BGFCHABMAHL, IPEndPoint EEJNKOBGGIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FDFEMKLNKHC : byte
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
public static class AONPKJGNPLI
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	internal static readonly int[] AOBMOLFPDPB;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int AOLMIEGGHLP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly int EBMGLONFACF;
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class NMIEONBJPEF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5341C20", Offset = "0x5340420", VA = "0x185341C20")]
	public NMIEONBJPEF(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OCOINCLHLEG : NMIEONBJPEF
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5341C20", Offset = "0x5340420", VA = "0x185341C20")]
	public OCOINCLHLEG(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum AJDCHLMHFGC
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
public interface HFOLHDJFJOD
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGCEKOIOMDP(AJDCHLMHFGC ENLHPKJPMMH, string OIHIJMCPAMD, params object[] ILIHAHINKGC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DLDDNBKGCGD
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static HFOLHDJFJOD KCHHMCDIHIL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly object BJFNDCPMOOI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5340330", Offset = "0x533EB30", VA = "0x185340330")]
	private static void EPJKFMFCMMM(AJDCHLMHFGC GANOCBOJMCI, string OIHIJMCPAMD, params object[] ILIHAHINKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x53405C0", Offset = "0x533EDC0", VA = "0x1853405C0")]
	internal static void NJPFBAJOGBL(string OIHIJMCPAMD, params object[] ILIHAHINKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5340560", Offset = "0x533ED60", VA = "0x185340560")]
	internal static void HPJOFDJKLEL(string OIHIJMCPAMD, params object[] ILIHAHINKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5340620", Offset = "0x533EE20", VA = "0x185340620")]
	internal static void OHAOCOONANK(string OIHIJMCPAMD, params object[] ILIHAHINKGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum IIIKMNKFHGM
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class PMNJOEDBKHA : ALCLJHBOBGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private MGAHMHJPDAM MFGCKABONMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BLHBBMDKLKP PFACICOLNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NBPNFMLKIFJ IDLEIEODMEE;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x53498A0", Offset = "0x53480A0", VA = "0x1853498A0")]
	internal PMNJOEDBKHA(BLHBBMDKLKP CLDKLPDMMOI, NBPNFMLKIFJ NGNDJFAINIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5349830", Offset = "0x5348030", VA = "0x185349830")]
	internal void NGEGCHLJNHE(MGAHMHJPDAM DACNPGFDDMN, int PMIPOGFKGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5349780", Offset = "0x5347F80", VA = "0x185349780")]
	internal void ABEGEGNDBLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5349800", Offset = "0x5348000", VA = "0x185349800")]
	public void KGBBLLMEOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class NBPNFMLKIFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public enum LMHGCOJKHJM
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
	public NBPNFMLKIFJ GAFBCNBLEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public LMHGCOJKHJM CCNHBOAJCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public CFOKFLAAELB CJDBGFBMAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IPEndPoint BNDKNKMGLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public object CMAMBLOJJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MAFGGDAKCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SocketError GJGFPCBNLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public OIMDLPLLFPO LLBCLKDCNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public ABAIPDPHJED DGCBPPNJHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public FDFEMKLNKHC FAAAFIGKOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public byte MOONDFGCIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public readonly PMNJOEDBKHA GMAGMINDLGA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5346500", Offset = "0x5344D00", VA = "0x185346500")]
	public NBPNFMLKIFJ(BLHBBMDKLKP CLDKLPDMMOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class BLHBBMDKLKP : IEnumerable<CFOKFLAAELB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class OLPCAMDNJHN : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5347830", Offset = "0x5346030", VA = "0x185347830", Slot = "4")]
		public bool Equals(IPEndPoint GJPJIELLCID, IPEndPoint HBNKALMNLPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4DF7190", Offset = "0x4DF5990", VA = "0x184DF7190", Slot = "5")]
		public int GetHashCode(IPEndPoint BEKFGDCEJDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public OLPCAMDNJHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct OJACOPJMCBM : IEnumerator<CFOKFLAAELB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly CFOKFLAAELB GOGHPAGCHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private CFOKFLAAELB KNCLDMPDOIA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public CFOKFLAAELB POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xE61380", Offset = "0xE5FB80", VA = "0x180E61380")]
		public OJACOPJMCBM(CFOKFLAAELB NDMBOLPNCGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5347790", Offset = "0x5345F90", VA = "0x185347790", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53477E0", Offset = "0x5345FE0", VA = "0x1853477E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Thread IBINCPFCFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool ACNOKHHALAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AutoResetEvent JDCKFCFEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Queue<NBPNFMLKIFJ> DMIMNDDEHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<NBPNFMLKIFJ> LABGDMECCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private NBPNFMLKIFJ CPCBLKDPBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly DKFGJHKEMNL BBABEILFPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly MONIOMHMFFJ MLKDFJOLEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly IJINKMBDGIN CBLOEECJOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly HDAEGHBFACE BAHNNOILFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly Dictionary<IPEndPoint, CFOKFLAAELB> NOPLNDHJNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, ABAIPDPHJED> NIHOPKHHLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, NLMOHNCBCGB> LMAMOKJBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly ReaderWriterLockSlim CELOMKEEEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private CFOKFLAAELB FLLAIJNCMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private int NIKFBKNKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly List<CFOKFLAAELB> MNAKFAIOIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private CFOKFLAAELB[] EKLGANPFFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly NJPFGKKKPDF NJGAJBLJKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private int GAPHCDOOFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private ConcurrentQueue<int> OAKAMJKBPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private byte AGGJMKMNKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly object IBOLAGJAAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool PAGPGNJHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool ENOGJLJCJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int CNMEFCLDNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int AFJGNEFAODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int BGENMPFALFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool KBJKMBGPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool PBFDEPKDJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int KIHNAGLDPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public int KFMLJLOIANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int CIHHDNCAONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool GGMENDAAMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool MABNIGLPLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEA")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool MLILKGBPJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEB")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool KKHCDEENBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public int KOLIMOPMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public int BKFCNGMFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool ONADCPPLELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly JKAJHDGKJFJ GEIMDBOBEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool PCLHNNANKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public readonly LEKCEPHKEAP MBGLLAGDDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool MMBLFJPFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public IIIKMNKFHGM OCPKMGOAFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int OOHGDLGAHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool AGIMLBIAALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x125")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool AEMEOLOPOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x126")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool AFBBKCEDAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x127")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool AGIIHOJGFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MGAHMHJPDAM EBGDKNEMEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int EKPPDDDFADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly object FDKKIOJEDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public int OGCKHNPDIMD;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const int ECNFHAFONCN = 500000;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Socket GJLAHMFDNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Socket HNHJGDKFCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Thread INDEDHJHHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Thread HODJNHABPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private IPEndPoint HFIGPOHICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private IPEndPoint HEPCADNEEEO;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	[ThreadStatic]
	private static byte[] MEKGKFODDJA;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	[ThreadStatic]
	private static byte[] CPJHJHHCFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly Dictionary<DGAFAHDDKGB, IPEndPoint> HNHAHFFMHOH;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int IGLMJPBLBIM = -1744830452;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly IPAddress MBCCAOAGBLO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly bool EMEHMAFKPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int MOFMFDGLNFK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool HIAKBAOJCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1253290", Offset = "0x1251A90", VA = "0x181253290")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x12532A0", Offset = "0x1251AA0", VA = "0x1812532A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HHCCGJJHNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1510C70", Offset = "0x150F470", VA = "0x181510C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x150FCA0", Offset = "0x150E4A0", VA = "0x18150FCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte DEIMAACPKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81EF80", Offset = "0x81D780", VA = "0x18081EF80")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JDHOJICIJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5337080", Offset = "0x5335880", VA = "0x185337080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short OPIJPAMIPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5339450", Offset = "0x5337C50", VA = "0x185339450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5336B20", Offset = "0x5335320", VA = "0x185336B20")]
	public void HBOCGCCIGHP(IPEndPoint CPOHNJPIGON, byte[] EMBEECDJLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5339DD0", Offset = "0x53385D0", VA = "0x185339DD0")]
	public void NEMIIACIOGP(IPEndPoint CPOHNJPIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x53340E0", Offset = "0x53328E0", VA = "0x1853340E0")]
	private bool BOHPHCHGAAD(IPEndPoint CPOHNJPIGON, [Out] CFOKFLAAELB OCKELOKNLJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x53335B0", Offset = "0x5331DB0", VA = "0x1853335B0")]
	private void ALBFEFNCFCG(CFOKFLAAELB OCKELOKNLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5339480", Offset = "0x5337C80", VA = "0x185339480")]
	private void MADJHJBNKEH(CFOKFLAAELB OCKELOKNLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5335820", Offset = "0x5334020", VA = "0x185335820")]
	private void GFFIDEOIJIL(CFOKFLAAELB OCKELOKNLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x533A810", Offset = "0x5339010", VA = "0x18533A810")]
	public BLHBBMDKLKP(DKFGJHKEMNL JBKEDPHDJLP, [Optional] NJPFGKKKPDF CDFLAGNIDKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x533A5E0", Offset = "0x5338DE0", VA = "0x18533A5E0")]
	internal void PIIIOHDFKNL(CFOKFLAAELB FLILHLMKLOA, int DJJJDDPJFGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5335CA0", Offset = "0x53344A0", VA = "0x185335CA0")]
	internal void GIMPMPNHIIK(CFOKFLAAELB FLILHLMKLOA, object OMHFAAFCGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x53334E0", Offset = "0x5331CE0", VA = "0x1853334E0")]
	internal void AHPHFLDKAJJ(CFOKFLAAELB OCKELOKNLJE, OIMDLPLLFPO DMEJPDINNBL, SocketError NKEHDKPONHJ, MGAHMHJPDAM EMCOMEIJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5333E90", Offset = "0x5332690", VA = "0x185333E90")]
	private void BFOJGGOLGPA(CFOKFLAAELB OCKELOKNLJE, OIMDLPLLFPO DMEJPDINNBL, SocketError NKEHDKPONHJ, bool PPEPKNMOGPK, byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int PPKDCOOCBKP, MGAHMHJPDAM EMCOMEIJNKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x53345B0", Offset = "0x5332DB0", VA = "0x1853345B0")]
	private void DJACENMNIMN(NBPNFMLKIFJ.LMHGCOJKHJM HJNJPNKDEFH, [Optional] CFOKFLAAELB OCKELOKNLJE, [Optional] IPEndPoint GDKALMJKDCN, SocketError PIKNFMIHJEE = SocketError.Success, int DJJJDDPJFGH = 0, OIMDLPLLFPO ECJHNOOHAMJ = OIMDLPLLFPO.ConnectionFailed, [Optional] ABAIPDPHJED PIMDJGHLABK, FDFEMKLNKHC DOLNOGIENIC = FDFEMKLNKHC.Unreliable, byte GIKBKKCAKAP = 0, [Optional] MGAHMHJPDAM LAKIDAGFCAN, [Optional] object OMHFAAFCGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x53373C0", Offset = "0x5335BC0", VA = "0x1853373C0")]
	private void JAMDPLOKPCB(NBPNFMLKIFJ NGNDJFAINIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5334430", Offset = "0x5332C30", VA = "0x185334430")]
	internal void CMDAJPFGHDC(NBPNFMLKIFJ NGNDJFAINIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5338DD0", Offset = "0x53375D0", VA = "0x185338DD0")]
	private void KPBOHJCJKKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x53370A0", Offset = "0x53358A0", VA = "0x1853370A0")]
	private void IPCBCPBGMII(int DHDENPAELMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5333870", Offset = "0x5332070", VA = "0x185333870")]
	internal CFOKFLAAELB BEMCFEMNLMN(ABAIPDPHJED KOFJNFGLAFK, byte[] MJDDOHKNJDK, int IOPBDEDCAOK, int BONCBNKGOGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5334530", Offset = "0x5332D30", VA = "0x185334530")]
	private int DDBNHNMKKFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x533A010", Offset = "0x5338810", VA = "0x18533A010")]
	private void OPBFCMKJNMN(IPEndPoint GDKALMJKDCN, CFOKFLAAELB CMLNECPOPCH, HPBCHALKFIL DAKBJFBCLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5335CF0", Offset = "0x53344F0", VA = "0x185335CF0")]
	private void GMCPBGFFCEI(MGAHMHJPDAM DACNPGFDDMN, IPEndPoint GDKALMJKDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5334170", Offset = "0x5332970", VA = "0x185334170")]
	internal void CIHEHNCMGHA(MGAHMHJPDAM DACNPGFDDMN, FDFEMKLNKHC JFCABJNBFNH, byte GIKBKKCAKAP, int PMIPOGFKGCF, CFOKFLAAELB FLILHLMKLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x53383E0", Offset = "0x5336BE0", VA = "0x1853383E0")]
	public bool KFEANBKPEKM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x53383F0", Offset = "0x5336BF0", VA = "0x1853383F0")]
	public bool KFEANBKPEKM(IPAddress CPLEENCLDBN, IPAddress NPMGCFJMDBI, int DFIMNCLPENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5337B80", Offset = "0x5336380", VA = "0x185337B80")]
	public bool KFEANBKPEKM(int DFIMNCLPENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5339110", Offset = "0x5337910", VA = "0x185339110")]
	public void LBPMKEKHNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x53395B0", Offset = "0x5337DB0", VA = "0x1853395B0")]
	public CFOKFLAAELB MJGDIGEBEJL(string CBDHFBPDECG, int DFIMNCLPENE, string EMBEECDJLJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x53394D0", Offset = "0x5337CD0", VA = "0x1853394D0")]
	public CFOKFLAAELB MJGDIGEBEJL(string CBDHFBPDECG, int DFIMNCLPENE, PDLJIICEKFI CMOHMNNGICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5339690", Offset = "0x5337E90", VA = "0x185339690")]
	public CFOKFLAAELB MJGDIGEBEJL(IPEndPoint MAKBFCPADHF, PDLJIICEKFI CMOHMNNGICG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x53334D0", Offset = "0x5331CD0", VA = "0x1853334D0")]
	public void AEEEKMDJAJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x53331B0", Offset = "0x53319B0", VA = "0x1853331B0")]
	public void AEEEKMDJAJH(bool FDNIFDMLCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5335BA0", Offset = "0x53343A0", VA = "0x185335BA0")]
	public void GICHGEOAAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5335A80", Offset = "0x5334280", VA = "0x185335A80")]
	public void GICHGEOAAEJ(byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5334030", Offset = "0x5332830", VA = "0x185334030")]
	public void BFOJGGOLGPA(CFOKFLAAELB OCKELOKNLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5333F70", Offset = "0x5332770", VA = "0x185333F70")]
	public void BFOJGGOLGPA(CFOKFLAAELB OCKELOKNLJE, byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int PPKDCOOCBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x533A630", Offset = "0x5338E30", VA = "0x18533A630", Slot = "4")]
	private IEnumerator<CFOKFLAAELB> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x533A6C0", Offset = "0x5338EC0", VA = "0x18533A6C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5338410", Offset = "0x5336C10", VA = "0x185338410")]
	private MGAHMHJPDAM KIOCHAPFOOK(JKINFHNJNBI AHFKMNKCLNN, int NKCDHJPJBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5338500", Offset = "0x5336D00", VA = "0x185338500")]
	private MGAHMHJPDAM KIOCHAPFOOK(JKINFHNJNBI AHFKMNKCLNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5335660", Offset = "0x5333E60", VA = "0x185335660")]
	internal MGAHMHJPDAM EJBLJCHADEL(int NKCDHJPJBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x533A470", Offset = "0x5338C70", VA = "0x18533A470")]
	internal void PAHLHKBLAKM(MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x533A750", Offset = "0x5338F50", VA = "0x18533A750")]
	static BLHBBMDKLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1253290", Offset = "0x1251A90", VA = "0x181253290")]
	private bool GHOHJDFGENL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5339F20", Offset = "0x5338720", VA = "0x185339F20")]
	private void OKHBEODCFAE(IPEndPoint FJODMMIFGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5336A40", Offset = "0x5335240", VA = "0x185336A40")]
	private void HADAMPFKEFK(IPEndPoint FJODMMIFGLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x53392B0", Offset = "0x5337AB0", VA = "0x1853392B0")]
	private bool LJCBIOHMNMD(SocketException IOPFKNIOMEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x53385E0", Offset = "0x5336DE0", VA = "0x1853385E0")]
	private void KLHMNHIJLKK(Socket JCEJGLPIBPG, EndPoint ACAKBGOHEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5336CF0", Offset = "0x53354F0", VA = "0x185336CF0")]
	private void ILMLHFJOAKH(object KPFMIIFGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5339A60", Offset = "0x5338260", VA = "0x185339A60")]
	private void NAKDBDNJBJP(object KPFMIIFGAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5337C00", Offset = "0x5336400", VA = "0x185337C00")]
	public bool KFEANBKPEKM(IPAddress CPLEENCLDBN, IPAddress NPMGCFJMDBI, int DFIMNCLPENE, bool NLGPAIELAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5338830", Offset = "0x5337030", VA = "0x185338830")]
	private bool KNEJMOMOBLH(Socket JCEJGLPIBPG, IPEndPoint FJODMMIFGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5334970", Offset = "0x5333170", VA = "0x185334970")]
	internal int DLKNHBOGHLE(MGAHMHJPDAM DACNPGFDDMN, IPEndPoint GDKALMJKDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5335620", Offset = "0x5333E20", VA = "0x185335620")]
	internal int EFKFKOMOFBN(MGAHMHJPDAM DACNPGFDDMN, IPEndPoint GDKALMJKDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x53349D0", Offset = "0x53331D0", VA = "0x1853349D0")]
	internal int EFKFKOMOFBN(byte[] OLDFIJBKFKG, int IOPBDEDCAOK, int BONCBNKGOGN, IPEndPoint GDKALMJKDCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5336BC0", Offset = "0x53353C0", VA = "0x185336BC0")]
	internal void IIEILODMDGA(bool GAIAFCJPPGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum JKINFHNJNBI : byte
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
internal sealed class MGAHMHJPDAM
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int HDGKKPGCCLE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int[] FONBAJAPCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public byte[] GFNEIDBOKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public int PCGHIJCLEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public object CMAMBLOJJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public MGAHMHJPDAM GAFBCNBLEBB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public JKINFHNJNBI IIFGKCLMHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x53459F0", Offset = "0x53441F0", VA = "0x1853459F0")]
		get
		{
			return default(JKINFHNJNBI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x53457D0", Offset = "0x5343FD0", VA = "0x1853457D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte NGIEMGLFOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5345960", Offset = "0x5344160", VA = "0x185345960")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5345540", Offset = "0x5343D40", VA = "0x185345540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort BJCLKKNFEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5345810", Offset = "0x5344010", VA = "0x185345810")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5345B20", Offset = "0x5344320", VA = "0x185345B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool LFPELKKKNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x53457A0", Offset = "0x5343FA0", VA = "0x1853457A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte ECENLEEBBEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5345900", Offset = "0x5344100", VA = "0x185345900")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x53458D0", Offset = "0x53440D0", VA = "0x1853458D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort GOIDPLKJMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5345870", Offset = "0x5344070", VA = "0x185345870")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x53455C0", Offset = "0x5343DC0", VA = "0x1853455C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort CABMGFEHEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5345990", Offset = "0x5344190", VA = "0x185345990")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5345580", Offset = "0x5343D80", VA = "0x185345580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort IBKFMIMEKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5345600", Offset = "0x5343E00", VA = "0x185345600")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5345660", Offset = "0x5343E60", VA = "0x185345660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5345B60", Offset = "0x5344360", VA = "0x185345B60")]
	static MGAHMHJPDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5345930", Offset = "0x5344130", VA = "0x185345930")]
	public void MAKCDJJLPMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5345F50", Offset = "0x5344750", VA = "0x185345F50")]
	public MGAHMHJPDAM(int NKCDHJPJBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5345E40", Offset = "0x5344640", VA = "0x185345E40")]
	public MGAHMHJPDAM(JKINFHNJNBI AHFKMNKCLNN, int NKCDHJPJBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5345AB0", Offset = "0x53442B0", VA = "0x185345AB0")]
	public static int OFKOILCGFNK(JKINFHNJNBI AHFKMNKCLNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5345A20", Offset = "0x5344220", VA = "0x185345A20")]
	public int OFKOILCGFNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x53456A0", Offset = "0x5343EA0", VA = "0x1853456A0")]
	public bool CPDLJFHNLKC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum EKBAMEIBILA : byte
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
internal enum EOAKKPHEAOC
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
internal enum MOIGIGOMEFE
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal enum BKDHCHFNMBC
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class CFOKFLAAELB
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private class MBJLNFDIDLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public MGAHMHJPDAM[] GMJIMBFKPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int PILFFHICEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public int BHCPOKJIPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public byte ECENLEEBBEE;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public MBJLNFDIDLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate void JBLCDGPGMAA(ulong IIHJNAOBDFM, int NLCIOCOCPCP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int OIBNJDEKHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int MBDIPAJBPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int CNKDKKOIKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private double JGGGOOEOEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int NLDLOFEPCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int APJPIELLLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stopwatch MLABBMKJNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int CEKDPFPJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private long KBJBHKPPEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly object CPHJOPBJCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	internal CFOKFLAAELB APADDBMOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	internal CFOKFLAAELB GABEIMLDCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Queue<MGAHMHJPDAM> POIIDLCADPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly ConcurrentQueue<MONFPENDGLE> HIDCJOIAJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly MONFPENDGLE[] NBMHFLNLMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private int HBPAHIDIMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int LCEJKIJHMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool OPLGKFHNOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private int HDINJEBBFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private int IJJFCGPOGFL;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private const int NENILEPINMD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private const int FFMCGMMBBEK = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly object EKIPOACJKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int CMIGDFPLDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly Dictionary<ushort, MBJLNFDIDLF> MLFLCLMLPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<ushort, ushort> HIIEPIJEBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly MGAHMHJPDAM LMGIGDJPKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private int LIJPKDPPGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int APEPLFPIDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private IPEndPoint DECGBKGADAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int HAFIDHEKAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private int JCADDEAKIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private long KABKGFEMLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private byte LNHAFFCOFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private EKBAMEIBILA NAEHNDOIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private MGAHMHJPDAM JIHHMNKHLKE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private const int PJMEJHJLJGF = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private int PNOIKAGHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly MGAHMHJPDAM HPMFCIAIMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly MGAHMHJPDAM PNOBPCBDJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly MGAHMHJPDAM LPJFGPFBLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MGAHMHJPDAM GBJHIKENFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly BLHBBMDKLKP CHAJFJBLJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly int ALAIFGAODFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public object MKKNPPLELGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly JKAJHDGKJFJ GEIMDBOBEPC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte MBONPLKAMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x81EF70", Offset = "0x81D770", VA = "0x18081EF70")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x533DE40", Offset = "0x533C640", VA = "0x18533DE40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint JGEDMABIBME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x966B80", Offset = "0x965380", VA = "0x180966B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EKBAMEIBILA DPKGOCMHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1075AC0", Offset = "0x10742C0", VA = "0x181075AC0")]
		get
		{
			return default(EKBAMEIBILA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long DGAJFLGJGFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x92F470", Offset = "0x92DC70", VA = "0x18092F470")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CKHKPOHPJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x1510C80", Offset = "0x150F480", VA = "0x181510C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x150FCB0", Offset = "0x150E4B0", VA = "0x18150FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int JMGFIOCHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x533C8F0", Offset = "0x533B0F0", VA = "0x18533C8F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int GFBMLODIEAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x790470", Offset = "0x78EC70", VA = "0x180790470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double LNFNLAFFHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x16FF330", Offset = "0x16FDB30", VA = "0x1816FF330")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event JBLCDGPGMAA MDOFNEKONJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x533C930", Offset = "0x533B130", VA = "0x18533C930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x533D0E0", Offset = "0x533B8E0", VA = "0x18533D0E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x533FCF0", Offset = "0x533E4F0", VA = "0x18533FCF0")]
	internal CFOKFLAAELB(BLHBBMDKLKP JBLMPCPAAMO, IPEndPoint GDKALMJKDCN, int MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x533D4A0", Offset = "0x533BCA0", VA = "0x18533D4A0")]
	internal void EGKDCDFCKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x533DC00", Offset = "0x533C400", VA = "0x18533DC00")]
	internal void GEOIKKAPCFM(IPEndPoint BOEILEDIKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x533D4C0", Offset = "0x533BCC0", VA = "0x18533D4C0")]
	internal void ELNKLHHDLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x533C290", Offset = "0x533AA90", VA = "0x18533C290")]
	private void AAFBBKGFHIE(int DGEGDDFLMDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x533C900", Offset = "0x533B100", VA = "0x18533C900")]
	private void BHCMPMFEBJK(int IJMIAMDOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x533DC90", Offset = "0x533C490", VA = "0x18533DC90")]
	private MONFPENDGLE IGDMLLMAKJG(byte KCAGHHGBPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x533F980", Offset = "0x533E180", VA = "0x18533F980")]
	internal CFOKFLAAELB(BLHBBMDKLKP JBLMPCPAAMO, IPEndPoint GDKALMJKDCN, int MBMFHFDDILC, byte ONJJMDHNDGF, PDLJIICEKFI GNABOBNOFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x533FB10", Offset = "0x533E310", VA = "0x18533FB10")]
	internal CFOKFLAAELB(BLHBBMDKLKP JBLMPCPAAMO, ABAIPDPHJED KOFJNFGLAFK, int MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x533D190", Offset = "0x533B990", VA = "0x18533D190")]
	internal void DLBHGMDDDLD(HPBCHALKFIL HNFNENLALOO, byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int BONCBNKGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x533F110", Offset = "0x533D910", VA = "0x18533F110")]
	internal bool NDEKLCEOGFM(LEJOOLOFGHE DACNPGFDDMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x533F0E0", Offset = "0x533D8E0", VA = "0x18533F0E0")]
	public void NBEHFMGBFJF(byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int BONCBNKGOGN, FDFEMKLNKHC JDIKAIHEILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x533C9E0", Offset = "0x533B1E0", VA = "0x18533C9E0")]
	private void CHLICEJNKKH(byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int BONCBNKGOGN, byte GIKBKKCAKAP, FDFEMKLNKHC DOLNOGIENIC, object OMHFAAFCGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x533F190", Offset = "0x533D990", VA = "0x18533F190")]
	public void NFCDIHLBOOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x533ECF0", Offset = "0x533D4F0", VA = "0x18533ECF0")]
	internal MOIGIGOMEFE LEBBCHAJMAM(MGAHMHJPDAM DACNPGFDDMN)
	{
		return default(MOIGIGOMEFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x533DC30", Offset = "0x533C430", VA = "0x18533DC30")]
	internal void IFGEFEOHMJP(MONFPENDGLE IJMEAIBEBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x533EDD0", Offset = "0x533D5D0", VA = "0x18533EDD0")]
	internal BKDHCHFNMBC MCABPFHEMBD(byte[] FCHBDAMJEHN, int IOPBDEDCAOK, int BONCBNKGOGN, bool PPEPKNMOGPK)
	{
		return default(BKDHCHFNMBC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x533C8B0", Offset = "0x533B0B0", VA = "0x18533C8B0")]
	private void APJGLCPNAOL(int FONHELHDJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x533DEF0", Offset = "0x533C6F0", VA = "0x18533DEF0")]
	internal void JNHKLOMBIBP(FDFEMKLNKHC JFCABJNBFNH, MGAHMHJPDAM NDMBOLPNCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x533C360", Offset = "0x533AB60", VA = "0x18533C360")]
	private void AHBFBJJLPLD(MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x533E980", Offset = "0x533D180", VA = "0x18533E980")]
	private void KKEHGLIPMAI(int GAJHKHCCEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x533F7C0", Offset = "0x533DFC0", VA = "0x18533F7C0")]
	internal EOAKKPHEAOC OPBFCMKJNMN(HPBCHALKFIL DAKBJFBCLBL)
	{
		return default(EOAKKPHEAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x533D550", Offset = "0x533BD50", VA = "0x18533D550")]
	internal void FAAJDKFOGFM(MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x533E880", Offset = "0x533D080", VA = "0x18533E880")]
	private void JNNGAEJJPOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x533CF30", Offset = "0x533B730", VA = "0x18533CF30")]
	internal void DBDAHINELDC(MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x533F240", Offset = "0x533DA40", VA = "0x18533F240")]
	internal void OMANMGAMPNF(int GAJHKHCCEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x533D1E0", Offset = "0x533B9E0", VA = "0x18533D1E0")]
	internal void EADONNJKEKA(MGAHMHJPDAM DACNPGFDDMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class JKAJHDGKJFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long HKDCDIKJCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long MABNGONEKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long HPNGAFCHBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long BEDCDMKEOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long PNPOOOHFPFO;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long LDLLHHMHEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53429E0", Offset = "0x53411E0", VA = "0x1853429E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long JPJLDEOCFLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5342A40", Offset = "0x5341240", VA = "0x185342A40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long IOFAGLEJKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5342A00", Offset = "0x5341200", VA = "0x185342A00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long IJLCAPADMJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5342AB0", Offset = "0x53412B0", VA = "0x185342AB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MJFHPPEDAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5342A10", Offset = "0x5341210", VA = "0x185342A10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long DFLKOFALACM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5342A60", Offset = "0x5341260", VA = "0x185342A60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5342A50", Offset = "0x5341250", VA = "0x185342A50")]
	public void KJCBPMPNLGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x53429D0", Offset = "0x53411D0", VA = "0x1853429D0")]
	public void ABNJCHPLHAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5342AC0", Offset = "0x53412C0", VA = "0x185342AC0")]
	public void PEKANOGJCJA(long PABDDAAJLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5342A30", Offset = "0x5341230", VA = "0x185342A30")]
	public void IMCEPFOEJCC(long DENHCBBGPEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x53429F0", Offset = "0x53411F0", VA = "0x1853429F0")]
	public void ELFOOLLGCIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5342A20", Offset = "0x5341220", VA = "0x185342A20")]
	public void IKOGLDPPJAC(long DAHJELJFLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5342AD0", Offset = "0x53412D0", VA = "0x185342AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JKAJHDGKJFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NDGJCNLGNPN
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly List<string> MFCHGHOGCNA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x53465D0", Offset = "0x5344DD0", VA = "0x1853465D0")]
	public static IPEndPoint JGCIHNPKAOC(string GEICNJOBHMD, int DFIMNCLPENE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x53468B0", Offset = "0x53450B0", VA = "0x1853468B0")]
	public static IPAddress KLKPNGAPDMF(string GEICNJOBHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5346820", Offset = "0x5345020", VA = "0x185346820")]
	public static IPAddress KLKPNGAPDMF(string GEICNJOBHMD, AddressFamily MOCOIEIOCAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x53465A0", Offset = "0x5344DA0", VA = "0x1853465A0")]
	internal static int CDIOHGPLHDO(int LHLDABINMFD, int MKLOMBGFNAM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2629BD0", Offset = "0x26283D0", VA = "0x182629BD0")]
	internal static T[] CCDKGNNCMGM<T>(int PPKDCOOCBKP) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PJAMBIMIAMB : MONFPENDGLE
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct GHGPBNJLJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MGAHMHJPDAM MFGCKABONMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private long ELMMIKPAMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool PKANBFEFAND;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5341490", Offset = "0x533FC90", VA = "0x185341490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53413B0", Offset = "0x533FBB0", VA = "0x1853413B0")]
		public void DNNHMGCFPEP(MGAHMHJPDAM DACNPGFDDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x53413D0", Offset = "0x533FBD0", VA = "0x1853413D0")]
		public bool LBHMMEINMFN(long NKIJCBIIGBE, CFOKFLAAELB OCKELOKNLJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5341440", Offset = "0x533FC40", VA = "0x185341440")]
		public bool MJBDPJEPBJH(CFOKFLAAELB OCKELOKNLJE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly MGAHMHJPDAM EIEFKIDAJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly GHGPBNJLJKC[] DBMIJPPGKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly MGAHMHJPDAM[] GLOPAGLILII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly bool[] BLCCDBOBKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int LAIGCFCPJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private int OICACGELGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CPIOMLGCEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int KFAMOJJOAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private bool BEMANJHHEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly FDFEMKLNKHC DPNDHAKNOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool GOJBGPHPDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly int PGIHEDCDFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly byte HIADNILMMGG;

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x53495B0", Offset = "0x5347DB0", VA = "0x1853495B0")]
	public PJAMBIMIAMB(CFOKFLAAELB OCKELOKNLJE, bool JGINPJGBDEK, byte MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x53486F0", Offset = "0x5346EF0", VA = "0x1853486F0")]
	private void DKMBDPOMPDB(MGAHMHJPDAM DACNPGFDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5349100", Offset = "0x5347900", VA = "0x185349100", Slot = "4")]
	protected override bool IIHEGHGNJAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5348AA0", Offset = "0x53472A0", VA = "0x185348AA0", Slot = "5")]
	public override bool FAAJDKFOGFM(MGAHMHJPDAM DACNPGFDDMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class EKABFEOKHHE : MONFPENDGLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private int LLLPIHMIKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private ushort OICACGELGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly bool OAAKMGOOOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private MGAHMHJPDAM AAOBJFILFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly MGAHMHJPDAM AMEFOKLBMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool IHOGBFPBECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly byte HIADNILMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private long HDFLJEDAMML;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5340FE0", Offset = "0x533F7E0", VA = "0x185340FE0")]
	public EKABFEOKHHE(CFOKFLAAELB OCKELOKNLJE, bool AFMFGAONGEJ, byte MBMFHFDDILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5340B70", Offset = "0x533F370", VA = "0x185340B70", Slot = "4")]
	protected override bool IIHEGHGNJAP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5340890", Offset = "0x533F090", VA = "0x185340890", Slot = "5")]
	public override bool FAAJDKFOGFM(MGAHMHJPDAM DACNPGFDDMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class EABELBJAFCP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private struct NNEDOBHNPGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ulong DJLDDLEEKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public double OCONNDDDBKK;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private struct NNLCDIIEDHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public int GBIOGKLBBBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float AKBBNKLALCB;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5332190", Offset = "0x5330990", VA = "0x185332190")]
	private static void NFPPFLJAKOK(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, ulong FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5340770", Offset = "0x533EF70", VA = "0x185340770")]
	private static void NFPPFLJAKOK(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, int FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5340730", Offset = "0x533EF30", VA = "0x185340730")]
	public static void NFPPFLJAKOK(byte[] IJPAPFCFHAF, int IJJNAEFKMHG, short FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5340870", Offset = "0x533F070", VA = "0x185340870")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, double DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x53407F0", Offset = "0x533EFF0", VA = "0x1853407F0")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5340730", Offset = "0x533EF30", VA = "0x185340730")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, short DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5340730", Offset = "0x533EF30", VA = "0x185340730")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, ushort DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5340770", Offset = "0x533EF70", VA = "0x185340770")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, int DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5340770", Offset = "0x533EF70", VA = "0x185340770")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, uint DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x53407E0", Offset = "0x533EFE0", VA = "0x1853407E0")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, long DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x53407E0", Offset = "0x533EFE0", VA = "0x1853407E0")]
	public static void OHDFCDFANDG(byte[] OCKHPPLPLMN, int DJIOGHHPANO, ulong DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ALCLJHBOBGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	protected byte[] OBAHELACCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	protected int CFCKPMNJBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected int MGAGKLDNPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private int GAFOCDOLMKE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public byte[] GFNEIDBOKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BKNHAOAEMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int PNOOIOBAELN
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5332D00", Offset = "0x5331500", VA = "0x185332D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OBMICBKAPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1BFC4A0", Offset = "0x1BFACA0", VA = "0x181BFC4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int ACPIIIPNOOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5332A60", Offset = "0x5331260", VA = "0x185332A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5332E90", Offset = "0x5331690", VA = "0x185332E90")]
	public void NGEGCHLJNHE(byte[] PCNNAKCFNJC, int IJJNAEFKMHG, int OGHINEJFEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ALCLJHBOBGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5333070", Offset = "0x5331870", VA = "0x185333070")]
	public ALCLJHBOBGE(byte[] PCNNAKCFNJC, int IJJNAEFKMHG, int OGHINEJFEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x53327B0", Offset = "0x5330FB0", VA = "0x1853327B0")]
	public IPEndPoint BKNALAHBDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5332C80", Offset = "0x5331480", VA = "0x185332C80")]
	public byte IEOEPHDCKGH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5332C80", Offset = "0x5331480", VA = "0x185332C80")]
	public sbyte PFBIEBNMCPH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2B27480", Offset = "0x2B25C80", VA = "0x182B27480")]
	public T[] FLGLBLJPLIL<T>(ushort NKCDHJPJBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x53328C0", Offset = "0x53310C0", VA = "0x1853328C0")]
	public bool[] BNIMOALOEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5332880", Offset = "0x5331080", VA = "0x185332880")]
	public ushort[] BMNDCGELFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5332DA0", Offset = "0x53315A0", VA = "0x185332DA0")]
	public short[] MLLJNLJCODP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5332AF0", Offset = "0x53312F0", VA = "0x185332AF0")]
	public int[] GPKBIIEGAED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5332770", Offset = "0x5330F70", VA = "0x185332770")]
	public uint[] ANKMNEFINKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5332CC0", Offset = "0x53314C0", VA = "0x185332CC0")]
	public float[] KLCAHPJPOEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5332DE0", Offset = "0x53315E0", VA = "0x185332DE0")]
	public double[] NAJICGDAFJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5332A70", Offset = "0x5331270", VA = "0x185332A70")]
	public long[] FCHFIIENCFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5332AB0", Offset = "0x53312B0", VA = "0x185332AB0")]
	public ulong[] FHNHCDEHAIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5332ED0", Offset = "0x53316D0", VA = "0x185332ED0")]
	public string[] NHDCLOHJICC(int MEAPILEPKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5332970", Offset = "0x5331170", VA = "0x185332970")]
	public bool CIOLOFPGKLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5332900", Offset = "0x5331100", VA = "0x185332900")]
	public char DPLHCEAGEGB()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5332900", Offset = "0x5331100", VA = "0x185332900")]
	public ushort CDJEJHANHMM()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5332C10", Offset = "0x5331410", VA = "0x185332C10")]
	public short HNGLCFIJBEC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5332700", Offset = "0x5330F00", VA = "0x185332700")]
	public long ALECGJFAFII()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5332E20", Offset = "0x5331620", VA = "0x185332E20")]
	public ulong NAOBPEHKNNG()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5332B30", Offset = "0x5331330", VA = "0x185332B30")]
	public int HCFCBIFNDGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x53329F0", Offset = "0x53311F0", VA = "0x1853329F0")]
	public uint EPBJKBGBIHO()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5333000", Offset = "0x5331800", VA = "0x185333000")]
	public float NKFJOMENBFB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5332D10", Offset = "0x5331510", VA = "0x185332D10")]
	public double LBOADEMLBED()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5332480", Offset = "0x5330C80", VA = "0x185332480")]
	public string AADAIDJMNJP(int BFJEEHIDFEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5332BA0", Offset = "0x53313A0", VA = "0x185332BA0")]
	public ArraySegment<byte> HILAACNOMAL(int PPKDCOOCBKP)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x53326C0", Offset = "0x5330EC0", VA = "0x1853326C0")]
	public sbyte[] AECOCKLHJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x53329B0", Offset = "0x53311B0", VA = "0x1853329B0")]
	public byte[] DIDAGIAGHBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5332D80", Offset = "0x5331580", VA = "0x185332D80")]
	public void MJBDPJEPBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class PDLJIICEKFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected byte[] OBAHELACCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected int CFCKPMNJBPJ;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private const int EDBDMLAPAHI = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly bool BDEFBAHAHMB;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public static readonly UTF8Encoding EPKECCMHCDF;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public const int PPNHBOGKOLE = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly byte[] GFGDFCHBCKC;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public byte[] GKMCBGMNDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int FHJOOIBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x773AF0", Offset = "0x7722F0", VA = "0x180773AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x53485D0", Offset = "0x5346DD0", VA = "0x1853485D0")]
	public PDLJIICEKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5348650", Offset = "0x5346E50", VA = "0x185348650")]
	public PDLJIICEKFI(bool JFGBCHPNMDE, int MNJPAOOFLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5348080", Offset = "0x5346880", VA = "0x185348080")]
	public static PDLJIICEKFI MKCPPGCELHB(string DOLICEBFIPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5347FE0", Offset = "0x53467E0", VA = "0x185347FE0")]
	public void LIHPCKKPDBD(int CIALMHHACCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1C75DA0", Offset = "0x1C745A0", VA = "0x181C75DA0")]
	public void EINJMPIPEHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5347F40", Offset = "0x5346740", VA = "0x185347F40")]
	public void LCEMAEDKDGC(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5347EF0", Offset = "0x53466F0", VA = "0x185347EF0")]
	public void LCEMAEDKDGC(double DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5347980", Offset = "0x5346180", VA = "0x185347980")]
	public void LCEMAEDKDGC(long DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5347980", Offset = "0x5346180", VA = "0x185347980")]
	public void LCEMAEDKDGC(ulong DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x53479D0", Offset = "0x53461D0", VA = "0x1853479D0")]
	public void LCEMAEDKDGC(int DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x53479D0", Offset = "0x53461D0", VA = "0x1853479D0")]
	public void LCEMAEDKDGC(uint DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5347A60", Offset = "0x5346260", VA = "0x185347A60")]
	public void LCEMAEDKDGC(char DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5347A60", Offset = "0x5346260", VA = "0x185347A60")]
	public void LCEMAEDKDGC(ushort DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5347A60", Offset = "0x5346260", VA = "0x185347A60")]
	public void LCEMAEDKDGC(short DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5347AD0", Offset = "0x53462D0", VA = "0x185347AD0")]
	public void LCEMAEDKDGC(sbyte DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5347AD0", Offset = "0x53462D0", VA = "0x185347AD0")]
	public void LCEMAEDKDGC(byte DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5347B30", Offset = "0x5346330", VA = "0x185347B30")]
	public void LCEMAEDKDGC(byte[] FCHBDAMJEHN, int IJJNAEFKMHG, int BONCBNKGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x53478A0", Offset = "0x53460A0", VA = "0x1853478A0")]
	public void ENFIIJMIMDK(sbyte[] FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x53478A0", Offset = "0x53460A0", VA = "0x1853478A0")]
	public void DDCMLBAPBJI(byte[] FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5347DB0", Offset = "0x53465B0", VA = "0x185347DB0")]
	public void LCEMAEDKDGC(bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5348390", Offset = "0x5346B90", VA = "0x185348390")]
	public void OICJDPMIIOH(Array IGBGCCOMDEP, int HPNJBOBOBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x53480F0", Offset = "0x53468F0", VA = "0x1853480F0")]
	public void OICJDPMIIOH(float[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x53482B0", Offset = "0x5346AB0", VA = "0x1853482B0")]
	public void OICJDPMIIOH(double[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53482B0", Offset = "0x5346AB0", VA = "0x1853482B0")]
	public void OICJDPMIIOH(long[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x53482B0", Offset = "0x5346AB0", VA = "0x1853482B0")]
	public void OICJDPMIIOH(ulong[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x53480F0", Offset = "0x53468F0", VA = "0x1853480F0")]
	public void OICJDPMIIOH(int[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x53480F0", Offset = "0x53468F0", VA = "0x1853480F0")]
	public void OICJDPMIIOH(uint[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x53481D0", Offset = "0x53469D0", VA = "0x1853481D0")]
	public void OICJDPMIIOH(ushort[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x53481D0", Offset = "0x53469D0", VA = "0x1853481D0")]
	public void OICJDPMIIOH(short[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x53478A0", Offset = "0x53460A0", VA = "0x1853478A0")]
	public void OICJDPMIIOH(bool[] DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5348470", Offset = "0x5346C70", VA = "0x185348470")]
	public void OICJDPMIIOH(string[] DOLICEBFIPF, int MPGADJPPLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5347E10", Offset = "0x5346610", VA = "0x185347E10")]
	public void LCEMAEDKDGC(IPEndPoint CPOHNJPIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5347EE0", Offset = "0x53466E0", VA = "0x185347EE0")]
	public void LCEMAEDKDGC(string DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5347BA0", Offset = "0x53463A0", VA = "0x185347BA0")]
	public void LCEMAEDKDGC(string DOLICEBFIPF, int BFJEEHIDFEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class MMLPIMHMJHL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private static class HPJIIPIOEDG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly ulong ALAIFGAODFI;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x35F3EA0", Offset = "0x35F26A0", VA = "0x1835F3EA0")]
		static HPJIIPIOEDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	protected delegate void HDMCGPNKMLO(ALCLJHBOBGE EINLOJPKPLI, object OMHFAAFCGEJ);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class APBNHNOBIMP<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public MMLPIMHMJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public APBNHNOBIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3667E60", Offset = "0x3666660", VA = "0x183667E60")]
		internal void IECBJKPMMCN(ALCLJHBOBGE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class DEKJIFJOFKI<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public MMLPIMHMJHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public DEKJIFJOFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4DD1DE0", Offset = "0x4DD05E0", VA = "0x184DD1DE0")]
		internal void IECBJKPMMCN(ALCLJHBOBGE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly CCGLDHPJCPM JJBNKLCHEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Dictionary<ulong, HDMCGPNKMLO> MBGMMKGHDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly PDLJIICEKFI LPLFFGGGANA;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x53461C0", Offset = "0x53449C0", VA = "0x1853461C0")]
	public MMLPIMHMJHL(int MEAPILEPKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x22CAC40", Offset = "0x22C9440", VA = "0x1822CAC40", Slot = "4")]
	protected virtual ulong PFBEDHMPDOA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5346010", Offset = "0x5344810", VA = "0x185346010", Slot = "5")]
	protected virtual HDMCGPNKMLO KNHEHNADNJO(ALCLJHBOBGE EINLOJPKPLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x25ADBE0", Offset = "0x25AC3E0", VA = "0x1825ADBE0", Slot = "6")]
	protected virtual void FPOPDGLGCAN<T>(PDLJIICEKFI MDONNIFBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5346140", Offset = "0x5344940", VA = "0x185346140")]
	public void PKGCLONAMAP(ALCLJHBOBGE EINLOJPKPLI, object OMHFAAFCGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x25ADB50", Offset = "0x25AC350", VA = "0x1825ADB50")]
	public void AFHOGBCJPKC<T>(PDLJIICEKFI MDONNIFBLDI, T DACNPGFDDMN) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5345FC0", Offset = "0x53447C0", VA = "0x185345FC0")]
	public void GHEMCJAKNME(ALCLJHBOBGE EINLOJPKPLI, object OMHFAAFCGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x25ADDD0", Offset = "0x25AC5D0", VA = "0x1825ADDD0")]
	public void MCPDCNINIEL<T>(Action<T> NIAOGBIBCDH) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x25ADC50", Offset = "0x25AC450", VA = "0x1825ADC50")]
	public void MCPDCNINIEL<T, TUserData>(Action<T, TUserData> NIAOGBIBCDH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class IGHDNPKKAMB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5341C20", Offset = "0x5340420", VA = "0x185341C20")]
	public IGHDNPKKAMB(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public class LAFNHJHANBO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5342E00", Offset = "0x5341600", VA = "0x185342E00")]
	public LAFNHJHANBO(string OLDFIJBKFKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class CCGLDHPJCPM
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private enum OIOCCFMCALH
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private abstract class NFNEFJJDJHH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public OIOCCFMCALH CCNHBOAJCJO;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3D252E0", Offset = "0x3D23AE0", VA = "0x183D252E0", Slot = "4")]
		public virtual void DNNHMGCFPEP(MethodInfo LLAALBMPOJM, MethodInfo MINEHICCHLB, OIOCCFMCALH HJNJPNKDEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LCDEFBFMFJN(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ABGKMIPDOEM(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		protected NFNEFJJDJHH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class HDGCCLMEAAC<TClass, TProperty> : NFNEFJJDJHH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected Func<TClass, TProperty> ELLMDMGBPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected Action<TClass, TProperty> MPAICJDIMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty[]> DEPOCIPAELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty[]> BPCNECAGAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, List<TProperty>> EOHKEJGJBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, List<TProperty>> NDLGHACOFBB;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x358C990", Offset = "0x358B190", VA = "0x18358C990", Slot = "7")]
		public override void CFKACJBLHGG(TClass JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x358F700", Offset = "0x358DF00", VA = "0x18358F700", Slot = "8")]
		public override void NAFLEPFJGNO(TClass JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x358F380", Offset = "0x358DB80", VA = "0x18358F380", Slot = "9")]
		public override void LCDEFBFMFJN(TClass JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x358C430", Offset = "0x358AC30", VA = "0x18358C430", Slot = "10")]
		public override void ABGKMIPDOEM(TClass JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x358C890", Offset = "0x358B090", VA = "0x18358C890")]
		protected TProperty[] BOCNHLHEBOO(TClass JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x358F150", Offset = "0x358D950", VA = "0x18358F150")]
		protected TProperty[] KLIMHJFAEIJ(TClass JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x358E5D0", Offset = "0x358CDD0", VA = "0x18358E5D0", Slot = "4")]
		public override void DNNHMGCFPEP(MethodInfo LLAALBMPOJM, MethodInfo MINEHICCHLB, OIOCCFMCALH HJNJPNKDEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x358FC40", Offset = "0x358E440", VA = "0x18358FC40")]
		protected HDGCCLMEAAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private abstract class ILIBDOOOGKN<TClass, TProperty> : HDGCCLMEAAC<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void EAJJOKFMPKA(ALCLJHBOBGE PMKDCBJFJND, [Out] TProperty PANEMINAOON);

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OFEOBHNDHFO(PDLJIICEKFI EHCPCJMKJMH, TProperty PANEMINAOON);

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x36C7150", Offset = "0x36C5950", VA = "0x1836C7150", Slot = "5")]
		public override void OHNEPJEMAEP(TClass JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x36C6DF0", Offset = "0x36C55F0", VA = "0x1836C6DF0", Slot = "6")]
		public override void AFHOGBCJPKC(TClass JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x36C6ED0", Offset = "0x36C56D0", VA = "0x1836C6ED0", Slot = "7")]
		public override void CFKACJBLHGG(TClass JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x36C70B0", Offset = "0x36C58B0", VA = "0x1836C70B0", Slot = "8")]
		public override void NAFLEPFJGNO(TClass JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x36C7250", Offset = "0x36C5A50", VA = "0x1836C7250")]
		protected ILIBDOOOGKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GKHOGHCKNKD<T> : HDGCCLMEAAC<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x35237C0", Offset = "0x3521FC0", VA = "0x1835237C0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3523690", Offset = "0x3521E90", VA = "0x183523690", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x35236F0", Offset = "0x3521EF0", VA = "0x1835236F0", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3523760", Offset = "0x3521F60", VA = "0x183523760", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public GKHOGHCKNKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class LKBEBGMFAHK<T> : HDGCCLMEAAC<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3A6CCF0", Offset = "0x3A6B4F0", VA = "0x183A6CCF0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3523690", Offset = "0x3521E90", VA = "0x183523690", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3A6CC80", Offset = "0x3A6B480", VA = "0x183A6CC80", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3523760", Offset = "0x3521F60", VA = "0x183523760", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public LKBEBGMFAHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class JKPLCDCMEAL<T> : HDGCCLMEAAC<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x38A6700", Offset = "0x38A4F00", VA = "0x1838A6700", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x38A65D0", Offset = "0x38A4DD0", VA = "0x1838A65D0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x38A6630", Offset = "0x38A4E30", VA = "0x1838A6630", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x38A66A0", Offset = "0x38A4EA0", VA = "0x1838A66A0", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public JKPLCDCMEAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class KJKLDJCPPDL<T> : HDGCCLMEAAC<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x39036C0", Offset = "0x3901EC0", VA = "0x1839036C0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x38A65D0", Offset = "0x38A4DD0", VA = "0x1838A65D0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3903650", Offset = "0x3901E50", VA = "0x183903650", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x38A66A0", Offset = "0x38A4EA0", VA = "0x1838A66A0", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public KJKLDJCPPDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class OCLENGAFMOL<T> : HDGCCLMEAAC<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFEB0", Offset = "0x3DFE6B0", VA = "0x183DFFEB0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3C3FFA0", Offset = "0x3C3E7A0", VA = "0x183C3FFA0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFE40", Offset = "0x3DFE640", VA = "0x183DFFE40", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3972570", Offset = "0x3970D70", VA = "0x183972570", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public OCLENGAFMOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MANDICFLEEJ<T> : HDGCCLMEAAC<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3C40070", Offset = "0x3C3E870", VA = "0x183C40070", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C3FFA0", Offset = "0x3C3E7A0", VA = "0x183C3FFA0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C40000", Offset = "0x3C3E800", VA = "0x183C40000", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3972570", Offset = "0x3970D70", VA = "0x183972570", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public MANDICFLEEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PBPLLLFACLN<T> : HDGCCLMEAAC<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3E35B70", Offset = "0x3E34370", VA = "0x183E35B70", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E35AA0", Offset = "0x3E342A0", VA = "0x183E35AA0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3EE2F90", Offset = "0x3EE1790", VA = "0x183EE2F90", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FA80", Offset = "0x3C9E280", VA = "0x183C9FA80", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public PBPLLLFACLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class OMLJDKLECDI<T> : HDGCCLMEAAC<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3E35B70", Offset = "0x3E34370", VA = "0x183E35B70", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3E35AA0", Offset = "0x3E342A0", VA = "0x183E35AA0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3E35B00", Offset = "0x3E34300", VA = "0x183E35B00", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FA80", Offset = "0x3C9E280", VA = "0x183C9FA80", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public OMLJDKLECDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class HLADCBGDPDK<T> : HDGCCLMEAAC<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x35A72F0", Offset = "0x35A5AF0", VA = "0x1835A72F0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x35A7220", Offset = "0x35A5A20", VA = "0x1835A7220", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x35A7280", Offset = "0x35A5A80", VA = "0x1835A7280", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3523760", Offset = "0x3521F60", VA = "0x183523760", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public HLADCBGDPDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class KNAGGJEKJOI<T> : HDGCCLMEAAC<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39725D0", Offset = "0x3970DD0", VA = "0x1839725D0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x39724A0", Offset = "0x3970CA0", VA = "0x1839724A0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3972500", Offset = "0x3970D00", VA = "0x183972500", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3972570", Offset = "0x3970D70", VA = "0x183972570", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public KNAGGJEKJOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class MKIAELEOGBI<T> : HDGCCLMEAAC<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FAE0", Offset = "0x3C9E2E0", VA = "0x183C9FAE0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F9B0", Offset = "0x3C9E1B0", VA = "0x183C9F9B0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FA10", Offset = "0x3C9E210", VA = "0x183C9FA10", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FA80", Offset = "0x3C9E280", VA = "0x183C9FA80", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3523830", Offset = "0x3522030", VA = "0x183523830")]
		public MKIAELEOGBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class HOIKDPCCEAI<T> : ILIBDOOOGKN<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x35EA810", Offset = "0x35E9010", VA = "0x1835EA810", Slot = "12")]
		protected override void OFEOBHNDHFO(PDLJIICEKFI EHCPCJMKJMH, char PANEMINAOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x35EA7E0", Offset = "0x35E8FE0", VA = "0x1835EA7E0", Slot = "11")]
		protected override void EAJJOKFMPKA(ALCLJHBOBGE PMKDCBJFJND, [Out] char PANEMINAOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3520980", Offset = "0x351F180", VA = "0x183520980")]
		public HOIKDPCCEAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class NCMBBJEPGHN<T> : ILIBDOOOGKN<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA370", Offset = "0x3CF8B70", VA = "0x183CFA370", Slot = "12")]
		protected override void OFEOBHNDHFO(PDLJIICEKFI EHCPCJMKJMH, IPEndPoint PANEMINAOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA330", Offset = "0x3CF8B30", VA = "0x183CFA330", Slot = "11")]
		protected override void EAJJOKFMPKA(ALCLJHBOBGE PMKDCBJFJND, [Out] IPEndPoint PANEMINAOON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3520980", Offset = "0x351F180", VA = "0x183520980")]
		public NCMBBJEPGHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private class MCNIKKAKNNN<T> : HDGCCLMEAAC<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private readonly int HCJICCNOGCM;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C476A0", Offset = "0x3C45EA0", VA = "0x183C476A0")]
		public MCNIKKAKNNN(int BFJEEHIDFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C47630", Offset = "0x3C45E30", VA = "0x183C47630", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C474E0", Offset = "0x3C45CE0", VA = "0x183C474E0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3C47550", Offset = "0x3C45D50", VA = "0x183C47550", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C475C0", Offset = "0x3C45DC0", VA = "0x183C475C0", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private class FDIOHBPPHOC<T> : NFNEFJJDJHH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected readonly PropertyInfo IIFGKCLMHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected readonly Type PAMDKHFMAAD;

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3457B70", Offset = "0x3456370", VA = "0x183457B70")]
		public FDIOHBPPHOC(PropertyInfo AHFKMNKCLNN, Type DEMINAGMHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3457AB0", Offset = "0x34562B0", VA = "0x183457AB0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x34578E0", Offset = "0x34560E0", VA = "0x1834578E0", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3457990", Offset = "0x3456190", VA = "0x183457990", Slot = "7")]
		public override void CFKACJBLHGG(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3457A50", Offset = "0x3456250", VA = "0x183457A50", Slot = "8")]
		public override void NAFLEPFJGNO(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x34579F0", Offset = "0x34561F0", VA = "0x1834579F0", Slot = "9")]
		public override void LCDEFBFMFJN(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3457880", Offset = "0x3456080", VA = "0x183457880", Slot = "10")]
		public override void ABGKMIPDOEM(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private class NPPEEMHPILD<T> : FDIOHBPPHOC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3550000", Offset = "0x354E800", VA = "0x183550000")]
		public NPPEEMHPILD(PropertyInfo AHFKMNKCLNN, Type DEMINAGMHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3D482E0", Offset = "0x3D46AE0", VA = "0x183D482E0", Slot = "5")]
		public override void OHNEPJEMAEP(T JPKBILJLOEM, ALCLJHBOBGE PMKDCBJFJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3D48230", Offset = "0x3D46A30", VA = "0x183D48230", Slot = "6")]
		public override void AFHOGBCJPKC(T JPKBILJLOEM, PDLJIICEKFI EHCPCJMKJMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private sealed class JGOFMKINGPL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static JGOFMKINGPL<T> ODCBNHJKAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private readonly NFNEFJJDJHH<T>[] GEAJLPINNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private readonly int BOJNHADIMBG;

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x388FEC0", Offset = "0x388E6C0", VA = "0x18388FEC0")]
		public JGOFMKINGPL(List<NFNEFJJDJHH<T>> GLKKGBIEICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x388FD60", Offset = "0x388E560", VA = "0x18388FD60")]
		public void AFHOGBCJPKC(T BEKFGDCEJDH, PDLJIICEKFI MDONNIFBLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x388FE10", Offset = "0x388E610", VA = "0x18388FE10")]
		public void OHNEPJEMAEP(T BEKFGDCEJDH, ALCLJHBOBGE EINLOJPKPLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	private abstract class JNMIBGFDAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract NFNEFJJDJHH<T> BGCBNLKDELI<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private PDLJIICEKFI LINENPFLBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly int GENLCKMIDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly Dictionary<Type, JNMIBGFDAPF> FOFNNFCNBME;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x533AE60", Offset = "0x5339660", VA = "0x18533AE60")]
	public CCGLDHPJCPM(int MEAPILEPKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2328060", Offset = "0x2326860", VA = "0x182328060")]
	private JGOFMKINGPL<T> CLMGJOFEHNK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x2328F50", Offset = "0x2327750", VA = "0x182328F50")]
	public void FPBPDBBEPKK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x2327FE0", Offset = "0x23267E0", VA = "0x182327FE0")]
	public bool AEDPLFCAHJC<T>(ALCLJHBOBGE EINLOJPKPLI, T MAKBFCPADHF) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2328F60", Offset = "0x2327760", VA = "0x182328F60")]
	public void JMOOMJHDBEG<T>(PDLJIICEKFI MDONNIFBLDI, T BEKFGDCEJDH) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class CEOPGKFBGOD
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static readonly DateTime LOPBPMMKBJH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] KCEHPLKPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public IDOCKALHALP MIENFLJPOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x533B6B0", Offset = "0x5339EB0", VA = "0x18533B6B0")]
		get
		{
			return default(IDOCKALHALP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int APKCCBEFPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x533B8E0", Offset = "0x533A0E0", VA = "0x18533B8E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x533BDC0", Offset = "0x533A5C0", VA = "0x18533BDC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GOOMFAHKJCH EAGPGMEICLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x533BCD0", Offset = "0x533A4D0", VA = "0x18533BCD0")]
		get
		{
			return default(GOOMFAHKJCH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x533B940", Offset = "0x533A140", VA = "0x18533B940")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GHJABFFFLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x533B8B0", Offset = "0x533A0B0", VA = "0x18533B8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public uint AHCEAIEPJIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x533B1A0", Offset = "0x53399A0", VA = "0x18533B1A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DateTime? IANOACDDMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x533BCA0", Offset = "0x533A4A0", VA = "0x18533BCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DateTime? OLIBOIIHJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x533B910", Offset = "0x533A110", VA = "0x18533B910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? GCNKGPHBOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x533B2B0", Offset = "0x5339AB0", VA = "0x18533B2B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x533B2E0", Offset = "0x5339AE0", VA = "0x18533B2E0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? PCOHHNDKLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FC230", VA = "0x1809FDA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x837BC0", Offset = "0x8363C0", VA = "0x180837BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x533BEC0", Offset = "0x533A6C0", VA = "0x18533BEC0")]
	public CEOPGKFBGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x533C1E0", Offset = "0x533A9E0", VA = "0x18533C1E0")]
	internal CEOPGKFBGOD(byte[] OCKHPPLPLMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x533BB80", Offset = "0x533A380", VA = "0x18533BB80")]
	public static CEOPGKFBGOD NKOJFOMJAKG(byte[] OCKHPPLPLMN, DateTime CAKKMIOHEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x533B980", Offset = "0x533A180", VA = "0x18533B980")]
	internal void NIGLAJHIOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x533B6E0", Offset = "0x5339EE0", VA = "0x18533B6E0")]
	private void JPPLFDDIJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x533B4B0", Offset = "0x5339CB0", VA = "0x18533B4B0")]
	private DateTime? HJHCGMIBDBI(int IJJNAEFKMHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x533AFD0", Offset = "0x53397D0", VA = "0x18533AFD0")]
	private void CNFCDLAMGFI(int IJJNAEFKMHG, DateTime? DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x533AF00", Offset = "0x5339700", VA = "0x18533AF00")]
	private ulong CLFIEGKHAFG(int IJJNAEFKMHG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x533BD00", Offset = "0x533A500", VA = "0x18533BD00")]
	private void OIKHGJCCLOH(int IJJNAEFKMHG, ulong DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x533B220", Offset = "0x5339A20", VA = "0x18533B220")]
	private uint ELKGOLBMEFO(int IJJNAEFKMHG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5222150", Offset = "0x5220950", VA = "0x185222150")]
	private static uint PPHHKEAMJPN(uint GJPJIELLCID)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x533BE00", Offset = "0x533A600", VA = "0x18533BE00")]
	private static ulong PPHHKEAMJPN(ulong GJPJIELLCID)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum IDOCKALHALP
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
public enum GOOMFAHKJCH
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal sealed class NLMOHNCBCGB
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private const int BPJGAEOGKOE = 1000;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private const int KGMPGEDIDHK = 10000;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public const int IJIJILNHNLN = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly IPEndPoint ELBAFOELGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private int HCBEKLPEJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int MALAABAMCGK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool LDLEPOEOFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5346B10", Offset = "0x5345310", VA = "0x185346B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5346B20", Offset = "0x5345320", VA = "0x185346B20")]
	public bool NBEHFMGBFJF(Socket JCEJGLPIBPG, int ODNLKBOLFPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class NJPFGKKKPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public readonly int JDHOJICIJMI;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x776120", Offset = "0x774920", VA = "0x180776120")]
	protected NJPFGKKKPDF(int CCFBBMNFJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FMLJHMCIKHH(IPEndPoint CPOHNJPIGON, byte[] FCHBDAMJEHN, int IJJNAEFKMHG, int BONCBNKGOGN);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OIIAOAFGHKG(IPEndPoint CPOHNJPIGON, byte[] FCHBDAMJEHN, int IJJNAEFKMHG, int BONCBNKGOGN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NOPGCNBFDHA : NJPFGKKKPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AesCryptoServiceProvider FBNMEGNIDGD;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly RandomNumberGenerator FLPMFBCEFNK;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5347770", Offset = "0x5345F70", VA = "0x185347770")]
	public NOPGCNBFDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x53470A0", Offset = "0x53458A0", VA = "0x1853470A0")]
	public void IPDKODMJMNP(IPEndPoint CPOHNJPIGON, byte[] EMBEECDJLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5346FC0", Offset = "0x53457C0", VA = "0x185346FC0")]
	public void GNHHIPKGEHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x53472E0", Offset = "0x5345AE0", VA = "0x1853472E0")]
	private byte[] KMGLECHCGFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5346C00", Offset = "0x5345400", VA = "0x185346C00", Slot = "4")]
	public override void FMLJHMCIKHH(IPEndPoint CPOHNJPIGON, byte[] FCHBDAMJEHN, int IJJNAEFKMHG, int BONCBNKGOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5347370", Offset = "0x5345B70", VA = "0x185347370", Slot = "5")]
	public override void OIIAOAFGHKG(IPEndPoint CPOHNJPIGON, byte[] FCHBDAMJEHN, int IJJNAEFKMHG, int BONCBNKGOGN)
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
