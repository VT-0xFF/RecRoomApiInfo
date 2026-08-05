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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, EJGOAIGEEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum ADNPMAPJOAK
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
		private NetworkManager CBGILLMCIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, HFLCHHGGHAB> JHODKPCDCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ADDCGBBFKGH HDNMIKCBKDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] MKONJJOJMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ADNPMAPJOAK HFJIIEAGGEL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong HCGHKBIOLCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool IKGDPKFCKGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x55EECC0", Offset = "0x55EDEC0", VA = "0x1855EECC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x55EE1C0", Offset = "0x55ED3C0", VA = "0x1855EE1C0")]
		public void RecRoom_SetEncryptionInfo(ulong BKNBMAPBAHO, byte[] HKNPGHOCJDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x55EE1A0", Offset = "0x55ED3A0", VA = "0x1855EE1A0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55EDE60", Offset = "0x55ED060", VA = "0x1855EDE60")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55EEBC0", Offset = "0x55EDDC0", VA = "0x1855EEBC0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55EE3C0", Offset = "0x55ED5C0", VA = "0x1855EE3C0", Slot = "6")]
		public override void Send(ulong BHALOKOGDPA, ArraySegment<byte> GKNJGNIHLDH, NetworkDelivery MHOCCDLEMMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55EE160", Offset = "0x55ED360", VA = "0x1855EE160", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BHALOKOGDPA, [Out] ArraySegment<byte> ECJANKACADL, [Out] float GPMJENPOJOJ)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55EE6B0", Offset = "0x55ED8B0", VA = "0x1855EE6B0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x55EEAE0", Offset = "0x55EDCE0", VA = "0x1855EEAE0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55ED7F0", Offset = "0x55EC9F0", VA = "0x1855ED7F0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BHALOKOGDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x55ED6A0", Offset = "0x55EC8A0", VA = "0x1855ED6A0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x55EDA40", Offset = "0x55ECC40", VA = "0x1855EDA40", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BHALOKOGDPA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x55EE640", Offset = "0x55ED840", VA = "0x1855EE640", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x55EDAE0", Offset = "0x55ECCE0", VA = "0x1855EDAE0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager CBGILLMCIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x55ED510", Offset = "0x55EC710", VA = "0x1855ED510")]
		private DEFOJFDGBAL CGOOCOGKBCH(NetworkDelivery DMEGHACCPAC)
		{
			return default(DEFOJFDGBAL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55ED5E0", Offset = "0x55EC7E0", VA = "0x1855ED5E0", Slot = "15")]
		private void CNDIPLJNFMB(HFLCHHGGHAB AJCONLEONPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55EDD20", Offset = "0x55ECF20", VA = "0x1855EDD20", Slot = "16")]
		private void OJCGAJMCFHN(HFLCHHGGHAB AJCONLEONPI, JIJIHEHDNEN HHIPCPBKECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "17")]
		private void CCGAJKINIBG(IPEndPoint GAKMLEJIDOA, SocketError KPLHJAAJIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55EDF50", Offset = "0x55ED150", VA = "0x1855EDF50", Slot = "18")]
		private void PKHGGPPHPJA(HFLCHHGGHAB AJCONLEONPI, HLGNJHFFHFN ODNMKNFNAPP, byte CPBHFDDLMLG, DEFOJFDGBAL GFPODONGGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x55ED960", Offset = "0x55ECB60", VA = "0x1855ED960")]
		private void GHNCDIIBHIA(int DKMFLNHKFDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "19")]
		private void HMHFHIBCMOB(IPEndPoint FNMHEOANGNC, HLGNJHFFHFN ODNMKNFNAPP, JFDFDLMMPPG NDBLNFLPBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "20")]
		private void HHDKNBOKJHI(HFLCHHGGHAB AJCONLEONPI, int KJKNIPKLEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x55EDCA0", Offset = "0x55ECEA0", VA = "0x1855EDCA0", Slot = "21")]
		private void MEAOPMNJHLM(CIMILFIEDOJ BDKDFPBHDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x55ED4E0", Offset = "0x55EC6E0", VA = "0x1855ED4E0")]
		private ulong ADEBDOPAJAE(HFLCHHGGHAB AJCONLEONPI)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x55EDD00", Offset = "0x55ECF00", VA = "0x1855EDD00")]
		private static int NFCNOCOGPGG(float NCFLLHLBEIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55EEBE0", Offset = "0x55EDDE0", VA = "0x1855EEBE0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class AHDOBOGAEPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly HFLCHHGGHAB NJJFHIDAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<KCNNAMGIPHG> HHNDMMDPECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PCEHBMLPOCE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x55E1210", Offset = "0x55E0410", VA = "0x1855E1210")]
	protected AHDOBOGAEPK(HFLCHHGGHAB AJCONLEONPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x55E11B0", Offset = "0x55E03B0", VA = "0x1855E11B0")]
	public void PGFBGMOELON(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x55E1130", Offset = "0x55E0330", VA = "0x1855E1130")]
	protected void PEDIOJJCPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x55E10F0", Offset = "0x55E02F0", VA = "0x1855E10F0")]
	public bool EIENMFHOKFN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool LHFOECFBMGH();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JPFFBMHHMAE(KCNNAMGIPHG PBGBMMLMDDL);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum ACJBAKADPOA
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
public class CIMILFIEDOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly ADDCGBBFKGH EMGOOLPFLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int IIPMIJPFIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MHFJDFGIPGM JPDMFJHKPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint MKEKIEBJCJI;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal ACJBAKADPOA PIGKFMPIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E39A0", Offset = "0x7E2BA0", VA = "0x1807E39A0")]
		[CompilerGenerated]
		get
		{
			return default(ACJBAKADPOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x969DF0", Offset = "0x968FF0", VA = "0x180969DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x55E3380", Offset = "0x55E2580", VA = "0x1855E3380")]
	internal void EBMBGMKICOA(MHFJDFGIPGM IGLACLMMDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x55E3350", Offset = "0x55E2550", VA = "0x1855E3350")]
	private bool DPGDNGIAKJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x55E33E0", Offset = "0x55E25E0", VA = "0x1855E33E0")]
	internal CIMILFIEDOJ(IPEndPoint FNMHEOANGNC, MHFJDFGIPGM CPANPIAOELJ, ADDCGBBFKGH FMBMJNHALKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x55E32F0", Offset = "0x55E24F0", VA = "0x1855E32F0")]
	public HFLCHHGGHAB DGILMFJLEGP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum JFDFDLMMPPG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum NAEBLNIDMFD
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
public struct JIJIHEHDNEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NAEBLNIDMFD MLOFGNGJMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError NIFEFOGKCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HLGNJHFFHFN ONKEPNJFMJD;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EJGOAIGEEAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIBOLAKDMNH(HFLCHHGGHAB AJCONLEONPI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGDMJFPOFNL(HFLCHHGGHAB AJCONLEONPI, JIJIHEHDNEN HHIPCPBKECJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEPMMFMCHLM(IPEndPoint GAKMLEJIDOA, SocketError KPLHJAAJIME);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLJCFNDPKNM(HFLCHHGGHAB AJCONLEONPI, HLGNJHFFHFN ODNMKNFNAPP, byte CPBHFDDLMLG, DEFOJFDGBAL GFPODONGGDC);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKAAALFDHGI(IPEndPoint FNMHEOANGNC, HLGNJHFFHFN ODNMKNFNAPP, JFDFDLMMPPG NDBLNFLPBLF);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJGBENPKHCF(HFLCHHGGHAB AJCONLEONPI, int KJKNIPKLEHK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LLEIEPPDPPA(CIMILFIEDOJ BDKDFPBHDIC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GFHPNJDFCMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PAOBDLEDNIK(HFLCHHGGHAB AJCONLEONPI, object PJLHDJIIKJG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PPEHFNBAKOC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIOKJIAMONK(GHKGLJCMKOM PBGBMMLMDDL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OPAHINNEGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PCILLNKEGIL(HFLCHHGGHAB AJCONLEONPI, IPEndPoint OOANNGICKPA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MHFJDFGIPGM
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int FMIDMLFDMOB = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long EDBIGEBLNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte AJDKNHKCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] MOFBJBEKOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly ELBJKFKBJLN DOMOOIMCODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int GBDPAMHOMHK;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x55EF1B0", Offset = "0x55EE3B0", VA = "0x1855EF1B0")]
	private MHFJDFGIPGM(long JPLEPKJFMGD, byte LKFPKINNNCD, int EJFJDAKPAHL, byte[] HOLALDNAHKN, ELBJKFKBJLN GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55EED50", Offset = "0x55EDF50", VA = "0x1855EED50")]
	public static int DBJKILPDMCC(KCNNAMGIPHG PBGBMMLMDDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x55EEDB0", Offset = "0x55EDFB0", VA = "0x1855EEDB0")]
	public static MHFJDFGIPGM IJACOCEBIPH(KCNNAMGIPHG PBGBMMLMDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x55EEFD0", Offset = "0x55EE1D0", VA = "0x1855EEFD0")]
	public static KCNNAMGIPHG INLACPKICDF(LLEGFCIIDBN GOCIFPFAHNO, SocketAddress FGBLDIEHLPJ, long LAMJLCGLJNL, int EJFJDAKPAHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class CEPKONIJAIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long EDBIGEBLNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte AJDKNHKCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int GBDPAMHOMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool INLDCBDNHGG;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x55E32A0", Offset = "0x55E24A0", VA = "0x1855E32A0")]
	private CEPKONIJAIC(long JPLEPKJFMGD, byte LKFPKINNNCD, int DAMAOBLACLC, bool KMDCAFJEKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55E3060", Offset = "0x55E2260", VA = "0x1855E3060")]
	public static CEPKONIJAIC IJACOCEBIPH(KCNNAMGIPHG PBGBMMLMDDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55E31B0", Offset = "0x55E23B0", VA = "0x1855E31B0")]
	public static KCNNAMGIPHG INLACPKICDF(long LAMJLCGLJNL, byte JHGPDNBBFKH, int LGDLOMICDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55E2F60", Offset = "0x55E2160", VA = "0x1855E2F60")]
	public static KCNNAMGIPHG GKLBNMJLBBB(HFLCHHGGHAB AJCONLEONPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum JAMHFMKENII
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EJHPJEEJALH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INHFADNPKDK(IPEndPoint NCFHAKGIEEH, IPEndPoint FNMHEOANGNC, string COAGHPOILPB);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBFJPPEOOBO(IPEndPoint JDHBEHBHPOL, JAMHFMKENII DMEGHACCPAC, string COAGHPOILPB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ANDGGNPLCLP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct DLJJMMBNMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint NNNIFDEPFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint MKEKIEBJCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string IOONFPAJIDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BGIMKPNMDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint BBAJANAPPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JAMHFMKENII OFDHKLACDLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string IOONFPAJIDH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class FDHCMHNNBAH
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint EKBODBAKOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IOONFPAJIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public FDHCMHNNBAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class OLPABHACACJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint EKBODBAKOCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint BMLFKBCAIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IOONFPAJIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public OLPABHACACJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class HKOIIBEFJOA
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IOONFPAJIDH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JNCCLDAGFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82CC20", Offset = "0x82BE20", VA = "0x18082CC20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C6280", Offset = "0x7C5480", VA = "0x1807C6280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public HKOIIBEFJOA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ADDCGBBFKGH OPNAEDDPBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<DLJJMMBNMCO> IHLOBIIOCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<BGIMKPNMDLC> LHJKBNCMFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ELBJKFKBJLN NEHKEJLJELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly LLEGFCIIDBN PKEJMPJCMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly IPCHAKEFKFE AEHKAOBBGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EJHPJEEJALH DHKOIKGKEGE;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int EDJLABLGCFE = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool NPFJFLHDEAP;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x55E1A00", Offset = "0x55E0C00", VA = "0x1855E1A00")]
	internal ANDGGNPLCLP(ADDCGBBFKGH JPOBGNMAKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x55E1700", Offset = "0x55E0900", VA = "0x1855E1700")]
	internal void MLCPJKAIFMP(IPEndPoint DGJMGELPBNC, KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2D57F60", Offset = "0x2D57160", VA = "0x182D57F60")]
	private void NJKPGCHPFIO<T>(T PBGBMMLMDDL, IPEndPoint MJBOJGOCOJL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x55E1410", Offset = "0x55E0610", VA = "0x1855E1410")]
	private void INHFADNPKDK(FDHCMHNNBAH MLOKOCBPKIN, IPEndPoint DGJMGELPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x55E15A0", Offset = "0x55E07A0", VA = "0x1855E15A0")]
	private void LENDJJDPCNL(OLPABHACACJ MLOKOCBPKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x55E1860", Offset = "0x55E0A60", VA = "0x1855E1860")]
	private void NCNPOJPKIHK(HKOIIBEFJOA MLOKOCBPKIN, IPEndPoint DGJMGELPBNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DEFOJFDGBAL : byte
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
public enum FEADDEFDKAN : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class AHCIBLDFNJK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] ELNOGBMDIMP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int FJIBFPBIEFP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int MANKGOLLLND;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BNEIPNNEJDL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x55E2EF0", Offset = "0x55E20F0", VA = "0x1855E2EF0")]
	public BNEIPNNEJDL(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GGOPEPDDOHN : BNEIPNNEJDL
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x55E2EF0", Offset = "0x55E20F0", VA = "0x1855E2EF0")]
	public GGOPEPDDOHN(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum IJJLGJBIFHJ
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
public interface HPDHIPIOMKD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGAEABPMDLE(IJJLGJBIFHJ MCJNJCHPJBC, string CPJNFDEECBG, params object[] KFIENCBOEKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NBECOALAGLD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static HPDHIPIOMKD GDDKJHFJJAB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object NKFMEOJIGEA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x55EF340", Offset = "0x55EE540", VA = "0x1855EF340")]
	private static void MPMMOLKPADM(IJJLGJBIFHJ KIGKEKIPCJP, string CPJNFDEECBG, params object[] KFIENCBOEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x55EF220", Offset = "0x55EE420", VA = "0x1855EF220")]
	internal static void DBMLNLGDHED(string CPJNFDEECBG, params object[] KFIENCBOEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55EF280", Offset = "0x55EE480", VA = "0x1855EF280")]
	internal static void DEHHFHBNLJI(string CPJNFDEECBG, params object[] KFIENCBOEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x55EF2E0", Offset = "0x55EE4E0", VA = "0x1855EF2E0")]
	internal static void EKADPBKIKFD(string CPJNFDEECBG, params object[] KFIENCBOEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum IEPDDNKLNBD
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HLGNJHFFHFN : ELBJKFKBJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private KCNNAMGIPHG HEIACPKKELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ADDCGBBFKGH BIGGPCNBIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FIKFEEHCNIJ NJOIGHDCCPE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55E9E60", Offset = "0x55E9060", VA = "0x1855E9E60")]
	internal HLGNJHFFHFN(ADDCGBBFKGH HOHFFEHOKPA, FIKFEEHCNIJ FIMMNPPPACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x55E9D70", Offset = "0x55E8F70", VA = "0x1855E9D70")]
	internal void IMJHCEBGHHO(KCNNAMGIPHG PBGBMMLMDDL, int CPAABCDEIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x55E9DE0", Offset = "0x55E8FE0", VA = "0x1855E9DE0")]
	internal void MEDPJOOFHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x55E9D40", Offset = "0x55E8F40", VA = "0x1855E9D40")]
	public void IBJCHMIAOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class FIKFEEHCNIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum PKKJIBCJCON
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
	public FIKFEEHCNIJ GLDIDDCPOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public PKKJIBCJCON OFDHKLACDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public HFLCHHGGHAB NJJFHIDAGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint MKEKIEBJCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object NFGKPGIMFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int KOJAEJOHMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError CPHNHGFBDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NAEBLNIDMFD PKDBOIMGNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public CIMILFIEDOJ EFPJNIEKNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public DEFOJFDGBAL BHEEKONBIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte DHAAOJHMGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HLGNJHFFHFN MHLMHHMLLNJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x55E40A0", Offset = "0x55E32A0", VA = "0x1855E40A0")]
	public FIKFEEHCNIJ(ADDCGBBFKGH HOHFFEHOKPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class ADDCGBBFKGH : IEnumerable<HFLCHHGGHAB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class MFAFLNELOBK : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x55EECE0", Offset = "0x55EDEE0", VA = "0x1855EECE0", Slot = "4")]
		public bool Equals(IPEndPoint DHOHKCEOCND, IPEndPoint CKNDNFKDDJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x50923C0", Offset = "0x50915C0", VA = "0x1850923C0", Slot = "5")]
		public int GetHashCode(IPEndPoint MFLACBLODGN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MFAFLNELOBK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LGCIIPNLPKF : IEnumerator<HFLCHHGGHAB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly HFLCHHGGHAB NDONFKMNGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private HFLCHHGGHAB MGJIODPFKNB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HFLCHHGGHAB DNINAAJGKKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x90C4F0", Offset = "0x90B6F0", VA = "0x18090C4F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x90C4F0", Offset = "0x90B6F0", VA = "0x18090C4F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF5F510", Offset = "0xF5E710", VA = "0x180F5F510")]
		public LGCIIPNLPKF(HFLCHHGGHAB MLNANLHFBGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x55EB990", Offset = "0x55EAB90", VA = "0x1855EB990", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55EB9E0", Offset = "0x55EABE0", VA = "0x1855EB9E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread MHKHDICNALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool HONHPOFDBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent KMNIIKACDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<FIKFEEHCNIJ> EFDHFKAGMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<FIKFEEHCNIJ> AELDHEFNMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private FIKFEEHCNIJ KCFHGFFPLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly EJGOAIGEEAJ HFHHBGOFLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly GFHPNJDFCMJ MPALAMKOOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly PPEHFNBAKOC AJNMCEMLLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OPAHINNEGJC MDNOFEIMIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, HFLCHHGGHAB> JEBLIILCANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, CIMILFIEDOJ> FOGBFDOICLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, KKNAGILJNBE> CPPHAOFKIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim MOCLCALFFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private HFLCHHGGHAB NEKIKNOICBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OMGLPDNHEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<HFLCHHGGHAB> DDFGHGDCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private HFLCHHGGHAB[] JCGCHNLKDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JNMPJPAPAOF FAEGDECAECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int GLKEDPKMICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> AFHBNDGBLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte BGEGCPMCEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object HGIECECKMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool EBNCKJKFOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool GEHKHLPMKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int FKDFCPCHHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int AIBDMDIJECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int HKKIELFOBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int BHGLACCFBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool MNKGNGEIAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MKBFLIKGICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JOCGHPLBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int DLNJINHOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MBFOEGCLGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool NPFJFLHDEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool APLKOGFJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HOMKOGMAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool CIJELOPICOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int NEFJAGFAMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int AHGOMHFJJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EBDLDPOEECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly ILKGCMAFJBM LMJEGMBPFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool EKDEEGHJHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly ANDGGNPLCLP KPFKABIBFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EOANOJNDPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public IEPDDNKLNBD APOHMMIIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int FBHBMABEFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KIAJCBGNDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool HAAAFJNGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GIHJKHIGAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool ELMLNHEAGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private KCNNAMGIPHG GALAFHLIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int LPHMAJMOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object ENGJFMMLCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private KCNNAMGIPHG CBGEGNOFLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int BNFDLCLMHIN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int BBOCNLLFLBA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int IALCCCOBDBN = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private MJEOEBHNCAM CDLGDBMHPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private MJEOEBHNCAM JIIAEPCGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread IFNCOKGIAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread JPLOMKHOOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint LBIGKKHNELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint EEPJLCBONKD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] POJAMINGPCO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] GIKAFLIKCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<OFIPCMHANCK, IPEndPoint> OBMKDLAMBOK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress KNCENCJCMHF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool MMJOJDGAFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int HMGMHCNJDLD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EJEBMEMBDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA69510", Offset = "0xA68710", VA = "0x180A69510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB2DA70", Offset = "0xB2CC70", VA = "0x180B2DA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DDPJDEBBJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x16145F0", Offset = "0x16137F0", VA = "0x1816145F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1613DC0", Offset = "0x1612FC0", VA = "0x181613DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte LNPDJJKJHEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CEB60", Offset = "0x8CDD60", VA = "0x1808CEB60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GCDGNCANLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55DD0A0", Offset = "0x55DC2A0", VA = "0x1855DD0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short OINMKLMCOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x55DA940", Offset = "0x55D9B40", VA = "0x1855DA940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x55DF6E0", Offset = "0x55DE8E0", VA = "0x1855DF6E0")]
	public void LOMMPEOHDME(IPEndPoint GAKMLEJIDOA, byte[] HKNPGHOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x55DA1F0", Offset = "0x55D93F0", VA = "0x1855DA1F0")]
	public void BHOLALBMGKO(IPEndPoint GAKMLEJIDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x55DBC30", Offset = "0x55DAE30", VA = "0x1855DBC30")]
	private bool EAIEIHLFLDO(IPEndPoint GAKMLEJIDOA, [Out] HFLCHHGGHAB AJCONLEONPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55DC390", Offset = "0x55DB590", VA = "0x1855DC390")]
	private void GEHDBGFBGMG(HFLCHHGGHAB AJCONLEONPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55DFF20", Offset = "0x55DF120", VA = "0x1855DFF20")]
	private void MEADALIOFHG(HFLCHHGGHAB AJCONLEONPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55E0140", Offset = "0x55DF340", VA = "0x1855E0140")]
	private void NLOMNOGKMIG(HFLCHHGGHAB AJCONLEONPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55E0840", Offset = "0x55DFA40", VA = "0x1855E0840")]
	public ADDCGBBFKGH(EJGOAIGEEAJ FMBMJNHALKE, [Optional] JNMPJPAPAOF HNCPDJNMKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55DEFB0", Offset = "0x55DE1B0", VA = "0x1855DEFB0")]
	internal void KLHNGODOLBF(HFLCHHGGHAB FHOOMNOMEBO, int KJKNIPKLEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x55DEE90", Offset = "0x55DE090", VA = "0x1855DEE90")]
	internal void KCCEMJFJJDP(HFLCHHGGHAB FHOOMNOMEBO, object PJLHDJIIKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55DEEE0", Offset = "0x55DE0E0", VA = "0x1855DEEE0")]
	internal void KDHLKBNCFIM(HFLCHHGGHAB AJCONLEONPI, NAEBLNIDMFD GJNAIKENJBL, SocketError FDFIHDIAEGD, KCNNAMGIPHG KGOCMEOMNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x55D9FA0", Offset = "0x55D91A0", VA = "0x1855D9FA0")]
	private void BFGNKEHDDAB(HFLCHHGGHAB AJCONLEONPI, NAEBLNIDMFD GJNAIKENJBL, SocketError FDFIHDIAEGD, bool DBMLIHEKMKO, byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int BNPJLEJJKIB, KCNNAMGIPHG KGOCMEOMNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55DBEE0", Offset = "0x55DB0E0", VA = "0x1855DBEE0")]
	private void EOFKGLKENLE(FIKFEEHCNIJ.PKKJIBCJCON DMEGHACCPAC, [Optional] HFLCHHGGHAB AJCONLEONPI, [Optional] IPEndPoint FNMHEOANGNC, SocketError DHCGJHBGJCP = SocketError.Success, int KJKNIPKLEHK = 0, NAEBLNIDMFD DBKHKEJKEFD = NAEBLNIDMFD.ConnectionFailed, [Optional] CIMILFIEDOJ CEGCDMOHHFN, DEFOJFDGBAL GFPODONGGDC = DEFOJFDGBAL.Unreliable, byte CPBHFDDLMLG = 0, [Optional] KCNNAMGIPHG ECAMAFKNBKM, [Optional] object PJLHDJIIKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55DB470", Offset = "0x55DA670", VA = "0x1855DB470")]
	private void DPPMBEAMALA(FIKFEEHCNIJ FIMMNPPPACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55DE660", Offset = "0x55DD860", VA = "0x1855DE660")]
	internal void JLFFGNCMFJL(FIKFEEHCNIJ FIMMNPPPACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55DF780", Offset = "0x55DE980", VA = "0x1855DF780")]
	private void MCAJMFAHBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x55DC8B0", Offset = "0x55DBAB0", VA = "0x1855DC8B0")]
	private void GKFMFOJOOBM(int LICNDALFBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x55DE040", Offset = "0x55DD240", VA = "0x1855DE040")]
	internal HFLCHHGGHAB JCNEMPLCBEG(CIMILFIEDOJ BDKDFPBHDIC, byte[] JNMHIEINKFA, int LIFMPBNCBOL, int NCLKCGHBFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55DF390", Offset = "0x55DE590", VA = "0x1855DF390")]
	private int LEBNLDOEFPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55DFAC0", Offset = "0x55DECC0", VA = "0x1855DFAC0")]
	private void MDNJKGHMNPF(IPEndPoint FNMHEOANGNC, HFLCHHGGHAB HLIMNMCIGBM, MHFJDFGIPGM FMOPLODFNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x55DD2F0", Offset = "0x55DC4F0", VA = "0x1855DD2F0")]
	private void HOBFCEHDACK(KCNNAMGIPHG PBGBMMLMDDL, IPEndPoint FNMHEOANGNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55E03A0", Offset = "0x55DF5A0", VA = "0x1855E03A0")]
	internal void PPGHANHCMGB(KCNNAMGIPHG PBGBMMLMDDL, DEFOJFDGBAL JBLEAOOFACF, byte CPBHFDDLMLG, int CPAABCDEIHL, HFLCHHGGHAB FHOOMNOMEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x55DB3E0", Offset = "0x55DA5E0", VA = "0x1855DB3E0")]
	public bool DDALJGFIKBD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55DAC00", Offset = "0x55D9E00", VA = "0x1855DAC00")]
	public bool DDALJGFIKBD(IPAddress OFAIPBLANNJ, IPAddress MCDOFHGGABC, int IHCAGGOMLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55DB3F0", Offset = "0x55DA5F0", VA = "0x1855DB3F0")]
	public bool DDALJGFIKBD(int IHCAGGOMLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55DECF0", Offset = "0x55DDEF0", VA = "0x1855DECF0")]
	public void KBJOJGDNEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x55DE840", Offset = "0x55DDA40", VA = "0x1855DE840")]
	public HFLCHHGGHAB JNCKGHALFBJ(string DGPEIEAMDCM, int IHCAGGOMLOI, string HKNPGHOCJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x55DE760", Offset = "0x55DD960", VA = "0x1855DE760")]
	public HFLCHHGGHAB JNCKGHALFBJ(string DGPEIEAMDCM, int IHCAGGOMLOI, LLEGFCIIDBN OHKLMHMPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x55DE920", Offset = "0x55DDB20", VA = "0x1855DE920")]
	public HFLCHHGGHAB JNCKGHALFBJ(IPEndPoint MJBOJGOCOJL, LLEGFCIIDBN OHKLMHMPHGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x55DCBD0", Offset = "0x55DBDD0", VA = "0x1855DCBD0")]
	public void GKJAHBMHFGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x55DCBE0", Offset = "0x55DBDE0", VA = "0x1855DCBE0")]
	public void GKJAHBMHFGD(bool AEDAPMHMBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55DBDE0", Offset = "0x55DAFE0", VA = "0x1855DBDE0")]
	public void EFNLJJKKIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x55DBCC0", Offset = "0x55DAEC0", VA = "0x1855DBCC0")]
	public void EFNLJJKKIEM(byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x55DA080", Offset = "0x55D9280", VA = "0x1855DA080")]
	public void BFGNKEHDDAB(HFLCHHGGHAB AJCONLEONPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x55DA130", Offset = "0x55D9330", VA = "0x1855DA130")]
	public void BFGNKEHDDAB(HFLCHHGGHAB AJCONLEONPI, byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int BNPJLEJJKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x55E0660", Offset = "0x55DF860", VA = "0x1855E0660", Slot = "4")]
	private IEnumerator<HFLCHHGGHAB> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x55E06F0", Offset = "0x55DF8F0", VA = "0x1855E06F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x55E0050", Offset = "0x55DF250", VA = "0x1855E0050")]
	private KCNNAMGIPHG MEDPAINBFHJ(FKEJKEKMLPN EPEGAGFKJNJ, int DKMFLNHKFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55DFF70", Offset = "0x55DF170", VA = "0x1855DFF70")]
	private KCNNAMGIPHG MEDPAINBFHJ(FKEJKEKMLPN EPEGAGFKJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55DD0C0", Offset = "0x55DC2C0", VA = "0x1855DD0C0")]
	internal KCNNAMGIPHG HKDMOOILPLH(int DKMFLNHKFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55DC650", Offset = "0x55DB850", VA = "0x1855DC650")]
	internal void GFPGCBMJJNA(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55E0780", Offset = "0x55DF980", VA = "0x1855E0780")]
	static ADDCGBBFKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA69510", Offset = "0xA68710", VA = "0x180A69510")]
	private bool CCDJCEAFEKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55DC2A0", Offset = "0x55DB4A0", VA = "0x1855DC2A0")]
	private void FEMBBACIDGA(IPEndPoint KIOHGMBNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55D9EC0", Offset = "0x55D90C0", VA = "0x1855D9EC0")]
	private void BEPOBLLKPCC(IPEndPoint KIOHGMBNODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55DAA00", Offset = "0x55D9C00", VA = "0x1855DAA00")]
	private bool CNKEJNIACCB(SocketException PHKDDEHKOGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55DF410", Offset = "0x55DE610", VA = "0x1855DF410")]
	private void LLJDIPPHKAF(MJEOEBHNCAM JPOBGNMAKIK, EndPoint HLPLOEPKJEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x55DF000", Offset = "0x55DE200", VA = "0x1855DF000")]
	private void KMEMEELHKIB(object MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x55DAC20", Offset = "0x55D9E20", VA = "0x1855DAC20")]
	public bool DDALJGFIKBD(IPAddress OFAIPBLANNJ, IPAddress MCDOFHGGABC, int IHCAGGOMLOI, bool CBEAHNCAGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x55DABA0", Offset = "0x55D9DA0", VA = "0x1855DABA0")]
	internal int DALECMAOILF(KCNNAMGIPHG PBGBMMLMDDL, IPEndPoint FNMHEOANGNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x55DA900", Offset = "0x55D9B00", VA = "0x1855DA900")]
	internal int BJBLGEKMCHM(KCNNAMGIPHG PBGBMMLMDDL, IPEndPoint FNMHEOANGNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x55DA340", Offset = "0x55D9540", VA = "0x1855DA340")]
	internal int BJBLGEKMCHM(byte[] LFMFEFFGFLH, int LIFMPBNCBOL, int NCLKCGHBFFI, IPEndPoint FNMHEOANGNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x55DCF30", Offset = "0x55DC130", VA = "0x1855DCF30")]
	internal void GPMHBJFIAHN(bool MFKLMGKDMKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FKEJKEKMLPN : byte
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
internal sealed class KCNNAMGIPHG
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int KIDAJNPLGEH;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] INLOIIHBLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] HHKBLAPMLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int OMLLDMPJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object NFGKPGIMFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public KCNNAMGIPHG GLDIDDCPOOM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FKEJKEKMLPN LGKIHDDICLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55EA970", Offset = "0x55E9B70", VA = "0x1855EA970")]
		get
		{
			return default(FKEJKEKMLPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB10", Offset = "0x55E9D10", VA = "0x1855EAB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte AJDKNHKCEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55EA940", Offset = "0x55E9B40", VA = "0x1855EA940")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x55EAE20", Offset = "0x55EA020", VA = "0x1855EAE20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort OAEEOBMJOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x55EA8A0", Offset = "0x55E9AA0", VA = "0x1855EA8A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x55EA9D0", Offset = "0x55E9BD0", VA = "0x1855EA9D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PBAPKNLLCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x55EA9A0", Offset = "0x55E9BA0", VA = "0x1855EA9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HPMBADMCINN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB50", Offset = "0x55E9D50", VA = "0x1855EAB50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x55EADF0", Offset = "0x55E9FF0", VA = "0x1855EADF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort OBKFNLCLFIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x55EAE60", Offset = "0x55EA060", VA = "0x1855EAE60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55EABE0", Offset = "0x55E9DE0", VA = "0x1855EABE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort HPJOHKDBOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x55EAC50", Offset = "0x55E9E50", VA = "0x1855EAC50")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x55EACB0", Offset = "0x55E9EB0", VA = "0x1855EACB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort LJKDFCDBCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x55EAB80", Offset = "0x55E9D80", VA = "0x1855EAB80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x55EA900", Offset = "0x55E9B00", VA = "0x1855EA900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x55EAEC0", Offset = "0x55EA0C0", VA = "0x1855EAEC0")]
	static KCNNAMGIPHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x55EAC20", Offset = "0x55E9E20", VA = "0x1855EAC20")]
	public void MAPGKAPIKIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x55EB2B0", Offset = "0x55EA4B0", VA = "0x1855EB2B0")]
	public KCNNAMGIPHG(int DKMFLNHKFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x55EB1A0", Offset = "0x55EA3A0", VA = "0x1855EB1A0")]
	public KCNNAMGIPHG(FKEJKEKMLPN EPEGAGFKJNJ, int DKMFLNHKFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x55EAD80", Offset = "0x55E9F80", VA = "0x1855EAD80")]
	public static int NDANKMMAMKO(FKEJKEKMLPN EPEGAGFKJNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x55EACF0", Offset = "0x55E9EF0", VA = "0x1855EACF0")]
	public int NDANKMMAMKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55EAA10", Offset = "0x55E9C10", VA = "0x1855EAA10")]
	public bool GKHKPEMMHEG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum FKMMOEFNIGD : byte
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
internal enum KLILHNCACGE
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
internal enum BODJCHJJLCP
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum ILGAAHCHMEN
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class HFLCHHGGHAB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class CMJLBLNIKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public KCNNAMGIPHG[] MHNEIPEPFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NPJOAKAAJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int CPJPFMODJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HPMBADMCINN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public CMJLBLNIKMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void EHGAMJKHEOO(ulong CPLCENMCMAO, int PNGGAFHKABE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int DIEIAMNLPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int ECLMABPBAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int MGGEGCNAGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double MDGHGCELONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int KHJEIDCLIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int JFCPBMKJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int PGIIOGAPEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch IJLCDMKMHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int GPEHNAHLDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long JKBMHDNEGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object JIAFDIGDCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal HFLCHHGGHAB JBFCIPNPHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal HFLCHHGGHAB MPENKGEJCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<KCNNAMGIPHG> JCLMMLCAMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<AHDOBOGAEPK> MEICAMGJMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly AHDOBOGAEPK[] LMIOGBFCNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int EGPLLGJAPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int GFCFCHLOOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool HCEHLNBCEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int PFLEPDDOHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int OJAGFJLJCNO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int DGPFOFOLIAF = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int IGEECJOEFGJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object HFIHINNNPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int EJCMGOGGENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, CMJLBLNIKMM> KMMHMEDFNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CEGOGFHKCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly KCNNAMGIPHG CJJFEDDOBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int MIEEKEDPLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int INJPNDBEJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint JLMHDNPAKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int MPJKNHCDGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int KGOLFBBLBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long KGFOPDBDFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte FHJPACOFPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FKMMOEFNIGD NPNMLGKJDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private KCNNAMGIPHG FLGCLFKDLAB;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int LLBOKBOLBOK = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JDHLAFFKPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly KCNNAMGIPHG HMMEHGMNEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly KCNNAMGIPHG CDPKDMNOGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly KCNNAMGIPHG DEICHIPIPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly KCNNAMGIPHG DKPJGDCNMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private FEADDEFDKAN EOPCPMMHHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly ADDCGBBFKGH HMMHHLENOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int HKBOKMJPIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object PEOFOOPFKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly ILKGCMAFJBM LMJEGMBPFBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte LNLJICACKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D40", Offset = "0xAA4F40", VA = "0x180AA5D40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55E5F90", Offset = "0x55E5190", VA = "0x1855E5F90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint HKOEIIOBAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FD650", Offset = "0x8FC850", VA = "0x1808FD650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FKMMOEFNIGD BOJLFECDBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x161CE20", Offset = "0x161C020", VA = "0x18161CE20")]
		get
		{
			return default(FKMMOEFNIGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long EGJILKFOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C67F0", Offset = "0x7C59F0", VA = "0x1807C67F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OHDONGLCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB717F0", Offset = "0xB709F0", VA = "0x180B717F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1446AB0", Offset = "0x1445CB0", VA = "0x181446AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PKHKNJIFDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x55E5E70", Offset = "0x55E5070", VA = "0x1855E5E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int KLJHIKLMCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB110", Offset = "0x7CA310", VA = "0x1807CB110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double AMNNLPODKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1818850", Offset = "0x1817A50", VA = "0x181818850")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EHGAMJKHEOO NJEMNIDOIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x55E8070", Offset = "0x55E7270", VA = "0x1855E8070")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x55E93A0", Offset = "0x55E85A0", VA = "0x1855E93A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55E9750", Offset = "0x55E8950", VA = "0x1855E9750")]
	internal HFLCHHGGHAB(ADDCGBBFKGH IMKBEDOHKAO, IPEndPoint FNMHEOANGNC, int EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55E5E00", Offset = "0x55E5000", VA = "0x1855E5E00")]
	internal void CIDBCJPEAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55E8BA0", Offset = "0x55E7DA0", VA = "0x1855E8BA0")]
	internal void KHBEEIPOFCJ(IPEndPoint EFNKFCKIDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55E9310", Offset = "0x55E8510", VA = "0x1855E9310")]
	internal void OAPPIGEHLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55E5E80", Offset = "0x55E5080", VA = "0x1855E5E80")]
	private void EBEEOPHCKGC(int DANPMGIFAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55E5F50", Offset = "0x55E5150", VA = "0x1855E5F50")]
	private void FHELPFBMJMO(int GBDFLCNHGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55E6670", Offset = "0x55E5870", VA = "0x1855E6670")]
	private AHDOBOGAEPK GJKGBMGDBHK(byte AIAMFINBMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55E9BB0", Offset = "0x55E8DB0", VA = "0x1855E9BB0")]
	internal HFLCHHGGHAB(ADDCGBBFKGH IMKBEDOHKAO, IPEndPoint FNMHEOANGNC, int EOHPLEHPKEN, byte JHGPDNBBFKH, LLEGFCIIDBN GOCIFPFAHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55E9570", Offset = "0x55E8770", VA = "0x1855E9570")]
	internal HFLCHHGGHAB(ADDCGBBFKGH IMKBEDOHKAO, CIMILFIEDOJ BDKDFPBHDIC, int EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x55E5E20", Offset = "0x55E5020", VA = "0x1855E5E20")]
	internal void CIFGGMPJALE(MHFJDFGIPGM LHGNFPPBHPJ, byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int NCLKCGHBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x55E8470", Offset = "0x55E7670", VA = "0x1855E8470")]
	internal bool JFCOGCBPBCI(CEPKONIJAIC PBGBMMLMDDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x55E92E0", Offset = "0x55E84E0", VA = "0x1855E92E0")]
	public void NJKPGCHPFIO(byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int NCLKCGHBFFI, DEFOJFDGBAL AGAKJLDACOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x55E6040", Offset = "0x55E5240", VA = "0x1855E6040")]
	private void FIMOOCIJHGF(byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int NCLKCGHBFFI, byte CPBHFDDLMLG, DEFOJFDGBAL GFPODONGGDC, object PJLHDJIIKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x55E5CF0", Offset = "0x55E4EF0", VA = "0x1855E5CF0")]
	public void BJDNMMEHCPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55E6590", Offset = "0x55E5790", VA = "0x1855E6590")]
	internal BODJCHJJLCP GEDACNOLCPF(KCNNAMGIPHG PBGBMMLMDDL)
	{
		return default(BODJCHJJLCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x55E5DA0", Offset = "0x55E4FA0", VA = "0x1855E5DA0")]
	internal void CFGDNJLLAEF(AHDOBOGAEPK IOCHCJBHHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x55E8160", Offset = "0x55E7360", VA = "0x1855E8160")]
	internal ILGAAHCHMEN ILKBDBDIKHF(byte[] GKNJGNIHLDH, int LIFMPBNCBOL, int NCLKCGHBFFI, bool DBMLIHEKMKO)
	{
		return default(ILGAAHCHMEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x55E8120", Offset = "0x55E7320", VA = "0x1855E8120")]
	private void IHGCECIDDEL(int MNGIBIOOCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x55E7510", Offset = "0x55E6710", VA = "0x1855E7510")]
	internal void HPFENGNEGOF(DEFOJFDGBAL JBLEAOOFACF, KCNNAMGIPHG MLNANLHFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55E8BD0", Offset = "0x55E7DD0", VA = "0x1855E8BD0")]
	private void MDHFFDIOAFH(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55E6820", Offset = "0x55E5A20", VA = "0x1855E6820")]
	private void GOOBFKIGPBM(int HDOBGNHLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55E9120", Offset = "0x55E8320", VA = "0x1855E9120")]
	internal KLILHNCACGE MDNJKGHMNPF(MHFJDFGIPGM FMOPLODFNLC)
	{
		return default(KLILHNCACGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55E84F0", Offset = "0x55E76F0", VA = "0x1855E84F0")]
	internal void JPFFBMHHMAE(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x55E9450", Offset = "0x55E8650", VA = "0x1855E9450")]
	private void OLDPOCEBLOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55E7EA0", Offset = "0x55E70A0", VA = "0x1855E7EA0")]
	internal void IAFAJFCEMEH(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x55E6E60", Offset = "0x55E6060", VA = "0x1855E6E60")]
	internal void HIJKAFNAKDI(int HDOBGNHLIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x55E6BA0", Offset = "0x55E5DA0", VA = "0x1855E6BA0")]
	internal void GPPGMMFLHAJ(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class ILKGCMAFJBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long EGDNCLJINCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NAMJJMLLBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long JKIAPLMFKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long PDGOFNOLNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long NBDDKHAHODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long NBBMLJAIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long PDOIKAPNMNG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long APCMAKFDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x55EA130", Offset = "0x55E9330", VA = "0x1855EA130")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long BEEGBOEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x55EA040", Offset = "0x55E9240", VA = "0x1855EA040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long AEMIGKGMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x55E9FD0", Offset = "0x55E91D0", VA = "0x1855E9FD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long POGLGBDBJED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x55E9EC0", Offset = "0x55E90C0", VA = "0x1855E9EC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long MIHCNNKIGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x55E9EB0", Offset = "0x55E90B0", VA = "0x1855E9EB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IGOCAHDJNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x55E9F20", Offset = "0x55E9120", VA = "0x1855E9F20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private FEADDEFDKAN MFGEABHMNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1A99030", Offset = "0x1A98230", VA = "0x181A99030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double LMCMCLOAPGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55E9FE0", Offset = "0x55E91E0", VA = "0x1855E9FE0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55E9F70", Offset = "0x55E9170", VA = "0x1855E9F70")]
	public void HBHCINBKNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55E9F40", Offset = "0x55E9140", VA = "0x1855E9F40")]
	public void GNLEKGGDHEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x55E9ED0", Offset = "0x55E90D0", VA = "0x1855E9ED0")]
	public void EFFGJBNGPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x55E9EE0", Offset = "0x55E90E0", VA = "0x1855E9EE0")]
	public void FJMBOFDIFLF(long IKDFAOBICHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x55E9F30", Offset = "0x55E9130", VA = "0x1855E9F30")]
	public void GMKCPACFDJP(long NONANFMNFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x55E9EF0", Offset = "0x55E90F0", VA = "0x1855E9EF0")]
	public void FKKFOJAJFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x55EA050", Offset = "0x55E9250", VA = "0x1855EA050")]
	public void MGJGALIPKOE(long JMNFAFEEIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x55EA140", Offset = "0x55E9340", VA = "0x1855EA140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55EA090", Offset = "0x55E9290", VA = "0x1855EA090")]
	public void NGNIBIIEEBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public ILKGCMAFJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class KNAIGENOGBI
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> LCECACBCLGJ;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x55EB6B0", Offset = "0x55EA8B0", VA = "0x1855EB6B0")]
	public static IPEndPoint KJFDKKAEGMJ(string CCEJNBEJBIJ, int IHCAGGOMLOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55EB450", Offset = "0x55EA650", VA = "0x1855EB450")]
	public static IPAddress IPAIHDMGMDD(string CCEJNBEJBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55EB620", Offset = "0x55EA820", VA = "0x1855EB620")]
	public static IPAddress IPAIHDMGMDD(string CCEJNBEJBIJ, AddressFamily KGOCGJDOGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x55EB420", Offset = "0x55EA620", VA = "0x1855EB420")]
	internal static int CAGACIIHIBJ(int MKDPBDDBIMB, int NLMJPOLMGJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x281E6B0", Offset = "0x281D8B0", VA = "0x18281E6B0")]
	internal static T[] BJOFLPOJBBC<T>(int BNPJLEJJKIB) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BKJIFFJFHKO : AHDOBOGAEPK
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct AEINKEPDKEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private KCNNAMGIPHG HEIACPKKELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long MHLBEJIEFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool BNBJMJKODNJ;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x55E0F70", Offset = "0x55E0170", VA = "0x1855E0F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x55E0F50", Offset = "0x55E0150", VA = "0x1855E0F50")]
		public void PIODBADEDMB(KCNNAMGIPHG PBGBMMLMDDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55E0E90", Offset = "0x55E0090", VA = "0x1855E0E90")]
		public bool FPOJADKJLOC(long PGDBAEFBEBO, HFLCHHGGHAB AJCONLEONPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x55E0F00", Offset = "0x55E0100", VA = "0x1855E0F00")]
		public bool IICCKONGNNF(HFLCHHGGHAB AJCONLEONPI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly KCNNAMGIPHG IOCHBKNIOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly AEINKEPDKEK[] PGAKMPIIJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly KCNNAMGIPHG[] GOMFENEOCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] AKGLIELDGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CHAAIBFPFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int CPCCOHGGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int CINGJCMEOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int INJEBIIOMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool KDODOJBEAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly DEFOJFDGBAL GMFJJPGGKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool BOPMJMDBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int IPBEOKECKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte GJAFGGLEFKK;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x55E2D20", Offset = "0x55E1F20", VA = "0x1855E2D20")]
	public BKJIFFJFHKO(HFLCHHGGHAB AJCONLEONPI, bool LKGHEIBOMCM, byte EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x55E1E50", Offset = "0x55E1050", VA = "0x1855E1E50")]
	private void JKHLCGKHAJF(KCNNAMGIPHG PBGBMMLMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x55E2870", Offset = "0x55E1A70", VA = "0x1855E2870", Slot = "4")]
	protected override bool LHFOECFBMGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55E2210", Offset = "0x55E1410", VA = "0x1855E2210", Slot = "5")]
	public override bool JPFFBMHHMAE(KCNNAMGIPHG PBGBMMLMDDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class OJEIMKKCMHD : AHDOBOGAEPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int ELPPOGFGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort CPCCOHGGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool EEBMJBFGKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private KCNNAMGIPHG KDIDJBLONGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly KCNNAMGIPHG ALPLENMJMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool LAGCPCDILIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte GJAFGGLEFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long FAJBGJGGBNE;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x55EFFB0", Offset = "0x55EF1B0", VA = "0x1855EFFB0")]
	public OJEIMKKCMHD(HFLCHHGGHAB AJCONLEONPI, bool LHOKNBMFMCA, byte EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55EFB10", Offset = "0x55EED10", VA = "0x1855EFB10", Slot = "4")]
	protected override bool LHFOECFBMGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55EF800", Offset = "0x55EEA00", VA = "0x1855EF800", Slot = "5")]
	public override bool JPFFBMHHMAE(KCNNAMGIPHG PBGBMMLMDDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AIIODBMNBNO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct GIJHBFNMDOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong ACPPNOKFGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double BAEKOMGMJOC;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct BBHKIHGBDGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int ONMEDDFLBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float PNMJONGFIPA;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55D9D30", Offset = "0x55D8F30", VA = "0x1855D9D30")]
	private static void DDNLJPGPOKG(byte[] JCGIBGELCJL, int GNHLLBKBLJF, ulong GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x55E12F0", Offset = "0x55E04F0", VA = "0x1855E12F0")]
	private static void DDNLJPGPOKG(byte[] JCGIBGELCJL, int GNHLLBKBLJF, int GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x55E12B0", Offset = "0x55E04B0", VA = "0x1855E12B0")]
	public static void DDNLJPGPOKG(byte[] JCGIBGELCJL, int GNHLLBKBLJF, short GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x55E13E0", Offset = "0x55E05E0", VA = "0x1855E13E0")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, double AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x55E1360", Offset = "0x55E0560", VA = "0x1855E1360")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x55E12B0", Offset = "0x55E04B0", VA = "0x1855E12B0")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, short AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x55E12B0", Offset = "0x55E04B0", VA = "0x1855E12B0")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, ushort AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x55E12F0", Offset = "0x55E04F0", VA = "0x1855E12F0")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, int AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x55E12F0", Offset = "0x55E04F0", VA = "0x1855E12F0")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, uint AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x55E1400", Offset = "0x55E0600", VA = "0x1855E1400")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, long AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x55E1400", Offset = "0x55E0600", VA = "0x1855E1400")]
	public static void LOOMMBDOGOJ(byte[] EHGLENBKLPL, int CMAABPPFEEC, ulong AFCGKMGKPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ELBJKFKBJLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] EHOFGNEHMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int OKCOCIGBNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int IAANCHMNPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int CAPINGCHHDA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] HHKBLAPMLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int MLOPIMNGIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FOOBEDHAEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x55E3A40", Offset = "0x55E2C40", VA = "0x1855E3A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NMPECMIFCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2440", Offset = "0x1CE1640", VA = "0x181CE2440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NMFNLPDNDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55E3ED0", Offset = "0x55E30D0", VA = "0x1855E3ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x55E3CF0", Offset = "0x55E2EF0", VA = "0x1855E3CF0")]
	public void IMJHCEBGHHO(byte[] CGONJAIKCGI, int GNHLLBKBLJF, int FENCGELALPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public ELBJKFKBJLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x55E4040", Offset = "0x55E3240", VA = "0x1855E4040")]
	public ELBJKFKBJLN(byte[] CGONJAIKCGI, int GNHLLBKBLJF, int FENCGELALPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x55E38C0", Offset = "0x55E2AC0", VA = "0x1855E38C0")]
	public IPEndPoint FLPDLMHJEPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x55E3D30", Offset = "0x55E2F30", VA = "0x1855E3D30")]
	public byte KCEFIDBNPDL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55E3D30", Offset = "0x55E2F30", VA = "0x1855E3D30")]
	public sbyte NLALHJNOJOL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x263EF60", Offset = "0x263E160", VA = "0x18263EF60")]
	public T[] DJDKPODEIKD<T>(ushort DKMFLNHKFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x55E3E50", Offset = "0x55E3050", VA = "0x1855E3E50")]
	public bool[] NFEKICFOLBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x55E3540", Offset = "0x55E2740", VA = "0x1855E3540")]
	public ushort[] BFIJMOGINLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x55E3F50", Offset = "0x55E3150", VA = "0x1855E3F50")]
	public short[] ONPKMPFOOPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x55E3490", Offset = "0x55E2690", VA = "0x1855E3490")]
	public int[] AKCGONLPJIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x55E3A00", Offset = "0x55E2C00", VA = "0x1855E3A00")]
	public uint[] GFHJDDBPFKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x55E3450", Offset = "0x55E2650", VA = "0x1855E3450")]
	public float[] AKAOGDBOMPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x55E3F90", Offset = "0x55E3190", VA = "0x1855E3F90")]
	public double[] PNILBMDCAGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55E3A50", Offset = "0x55E2C50", VA = "0x1855E3A50")]
	public long[] HBFFFJIBBGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x55E3630", Offset = "0x55E2830", VA = "0x1855E3630")]
	public ulong[] CJEALAPCEPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x55E3670", Offset = "0x55E2870", VA = "0x1855E3670")]
	public string[] DBMJDNHCELD(int EBEBCNGMJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x55E35F0", Offset = "0x55E27F0", VA = "0x1855E35F0")]
	public bool CHFAPAMPNJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x55E3580", Offset = "0x55E2780", VA = "0x1855E3580")]
	public char OPEFECCCFMF()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x55E3580", Offset = "0x55E2780", VA = "0x1855E3580")]
	public ushort BMDDJPPKEOL()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x55E3FD0", Offset = "0x55E31D0", VA = "0x1855E3FD0")]
	public short POJFGOAIOHD()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55E34D0", Offset = "0x55E26D0", VA = "0x1855E34D0")]
	public long AOFPMKAMGBE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x55E3990", Offset = "0x55E2B90", VA = "0x1855E3990")]
	public ulong GBJFJCKAPDL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55E3850", Offset = "0x55E2A50", VA = "0x1855E3850")]
	public int FLAGFNCAMEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55E3EE0", Offset = "0x55E30E0", VA = "0x1855E3EE0")]
	public uint OGFGGFAHHMB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55E37E0", Offset = "0x55E29E0", VA = "0x1855E37E0")]
	public float FEFHFICPIHF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x55E3D70", Offset = "0x55E2F70", VA = "0x1855E3D70")]
	public double LICGAHIBBAA()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x55E3A90", Offset = "0x55E2C90", VA = "0x1855E3A90")]
	public string HJPNPDMEHGI(int GCBBIJKLBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x55E3DE0", Offset = "0x55E2FE0", VA = "0x1855E3DE0")]
	public ArraySegment<byte> MDDFJAPEAPO(int BNPJLEJJKIB)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x55E3E90", Offset = "0x55E3090", VA = "0x1855E3E90")]
	public sbyte[] NMKLBPHIHDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55E37A0", Offset = "0x55E29A0", VA = "0x1855E37A0")]
	public byte[] DFGLJELMGPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x55E3CD0", Offset = "0x55E2ED0", VA = "0x1855E3CD0")]
	public void IICCKONGNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class LLEGFCIIDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] EHOFGNEHMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int OKCOCIGBNAM;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int MDEKCMIFAAM = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool BDPBGEJJLLI;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding EFFCJIBMBIO;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int AODDKGBJGHO = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] PFIBMCAKGNC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] DOMOOIMCODE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int DOKCLGDELIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x55EC800", Offset = "0x55EBA00", VA = "0x1855EC800")]
	public LLEGFCIIDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x55EC760", Offset = "0x55EB960", VA = "0x1855EC760")]
	public LLEGFCIIDBN(bool NILLIKEJOKB, int LFIIIMKHLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x55EC210", Offset = "0x55EB410", VA = "0x1855EC210")]
	public static LLEGFCIIDBN KLEMEAMOHJP(string AFCGKMGKPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x55EBB10", Offset = "0x55EAD10", VA = "0x1855EBB10")]
	public void GEAJELPBJGE(int KPDKDIMCEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BD30", Offset = "0x1D5AF30", VA = "0x181D5BD30")]
	public void HBHCINBKNHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x55EBBB0", Offset = "0x55EADB0", VA = "0x1855EBBB0")]
	public void IHBJPMACCOK(float AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x55EBED0", Offset = "0x55EB0D0", VA = "0x1855EBED0")]
	public void IHBJPMACCOK(double AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55EBCE0", Offset = "0x55EAEE0", VA = "0x1855EBCE0")]
	public void IHBJPMACCOK(long AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x55EBCE0", Offset = "0x55EAEE0", VA = "0x1855EBCE0")]
	public void IHBJPMACCOK(ulong AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55EBC50", Offset = "0x55EAE50", VA = "0x1855EBC50")]
	public void IHBJPMACCOK(int AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55EBC50", Offset = "0x55EAE50", VA = "0x1855EBC50")]
	public void IHBJPMACCOK(uint AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x55EC1A0", Offset = "0x55EB3A0", VA = "0x1855EC1A0")]
	public void IHBJPMACCOK(char AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55EC1A0", Offset = "0x55EB3A0", VA = "0x1855EC1A0")]
	public void IHBJPMACCOK(ushort AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x55EC1A0", Offset = "0x55EB3A0", VA = "0x1855EC1A0")]
	public void IHBJPMACCOK(short AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x55EBE70", Offset = "0x55EB070", VA = "0x1855EBE70")]
	public void IHBJPMACCOK(sbyte AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x55EBE70", Offset = "0x55EB070", VA = "0x1855EBE70")]
	public void IHBJPMACCOK(byte AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55EBE00", Offset = "0x55EB000", VA = "0x1855EBE00")]
	public void IHBJPMACCOK(byte[] GKNJGNIHLDH, int GNHLLBKBLJF, int NCLKCGHBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55EBA30", Offset = "0x55EAC30", VA = "0x1855EBA30")]
	public void CFHFEAAJPLP(sbyte[] GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x55EBA30", Offset = "0x55EAC30", VA = "0x1855EBA30")]
	public void BILGMHOIDJK(byte[] GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x55EC130", Offset = "0x55EB330", VA = "0x1855EC130")]
	public void IHBJPMACCOK(bool AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x55EC5F0", Offset = "0x55EB7F0", VA = "0x1855EC5F0")]
	public void NINKIINHCKG(Array BMCDGHOOJIF, int LNPPFCPLJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x55EC280", Offset = "0x55EB480", VA = "0x1855EC280")]
	public void NINKIINHCKG(float[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x55EC510", Offset = "0x55EB710", VA = "0x1855EC510")]
	public void NINKIINHCKG(double[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x55EC510", Offset = "0x55EB710", VA = "0x1855EC510")]
	public void NINKIINHCKG(long[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x55EC510", Offset = "0x55EB710", VA = "0x1855EC510")]
	public void NINKIINHCKG(ulong[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x55EC280", Offset = "0x55EB480", VA = "0x1855EC280")]
	public void NINKIINHCKG(int[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x55EC280", Offset = "0x55EB480", VA = "0x1855EC280")]
	public void NINKIINHCKG(uint[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x55EC430", Offset = "0x55EB630", VA = "0x1855EC430")]
	public void NINKIINHCKG(ushort[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x55EC430", Offset = "0x55EB630", VA = "0x1855EC430")]
	public void NINKIINHCKG(short[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x55EBA30", Offset = "0x55EAC30", VA = "0x1855EBA30")]
	public void NINKIINHCKG(bool[] AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x55EC360", Offset = "0x55EB560", VA = "0x1855EC360")]
	public void NINKIINHCKG(string[] AFCGKMGKPEF, int AFPLMHBBHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x55EBD30", Offset = "0x55EAF30", VA = "0x1855EBD30")]
	public void IHBJPMACCOK(IPEndPoint GAKMLEJIDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x55EC190", Offset = "0x55EB390", VA = "0x1855EC190")]
	public void IHBJPMACCOK(string AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x55EBF20", Offset = "0x55EB120", VA = "0x1855EBF20")]
	public void IHBJPMACCOK(string AFCGKMGKPEF, int GCBBIJKLBCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class IPCHAKEFKFE
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class JKKLJKDFHIK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong HKBOKMJPIGA;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3AB3C50", Offset = "0x3AB2E50", VA = "0x183AB3C50")]
		static JKKLJKDFHIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void LHNPJHGLELD(ELBJKFKBJLN ODNMKNFNAPP, object PJLHDJIIKJG);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EBJIFLAHOHJ<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public IPCHAKEFKFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public EBJIFLAHOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x32A9FA0", Offset = "0x32A91A0", VA = "0x1832A9FA0")]
		internal void GCHFAPLLODK(ELBJKFKBJLN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class MJNEFICJJHP<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public IPCHAKEFKFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MJNEFICJJHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E7ADE0", Offset = "0x3E79FE0", VA = "0x183E7ADE0")]
		internal void GCHFAPLLODK(ELBJKFKBJLN reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly JBJEPIJOEAH AJEJBOMKCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, LHNPJHGLELD> JIEDMAMGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly LLEGFCIIDBN PFBHBBMCIAG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x55EA680", Offset = "0x55E9880", VA = "0x1855EA680")]
	public IPCHAKEFKFE(int EBEBCNGMJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x256A3C0", Offset = "0x25695C0", VA = "0x18256A3C0", Slot = "4")]
	protected virtual ulong IGBOIHHGFAE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x55EA4D0", Offset = "0x55E96D0", VA = "0x1855EA4D0", Slot = "5")]
	protected virtual LHNPJHGLELD JNCJKJKPEKB(ELBJKFKBJLN ODNMKNFNAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27D5190", Offset = "0x27D4390", VA = "0x1827D5190", Slot = "6")]
	protected virtual void KOFNHGNHGBP<T>(LLEGFCIIDBN MNAHEBBEBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55EA600", Offset = "0x55E9800", VA = "0x1855EA600")]
	public void OGHHFPMKMOL(ELBJKFKBJLN ODNMKNFNAPP, object PJLHDJIIKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x27D5100", Offset = "0x27D4300", VA = "0x1827D5100")]
	public void EGPLHGBNEEA<T>(LLEGFCIIDBN MNAHEBBEBLG, T PBGBMMLMDDL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x55EA480", Offset = "0x55E9680", VA = "0x1855EA480")]
	public void DOCKJCBCABD(ELBJKFKBJLN ODNMKNFNAPP, object PJLHDJIIKJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27D4F80", Offset = "0x27D4180", VA = "0x1827D4F80")]
	public void DLLFDIMIKEI<T>(Action<T> GBEKNHDMMJA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27D4E00", Offset = "0x27D4000", VA = "0x1827D4E00")]
	public void DLLFDIMIKEI<T, TUserData>(Action<T, TUserData> GBEKNHDMMJA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class IHMIPCNMDDL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x55E2EF0", Offset = "0x55E20F0", VA = "0x1855E2EF0")]
	public IHMIPCNMDDL(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CBNMHKFHPBC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x55E2F00", Offset = "0x55E2100", VA = "0x1855E2F00")]
	public CBNMHKFHPBC(string LFMFEFFGFLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JBJEPIJOEAH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum DOPCOIFOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class HNADDNAJECH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public DOPCOIFOIKN OFDHKLACDLG;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3801630", Offset = "0x3800830", VA = "0x183801630", Slot = "4")]
		public virtual void PIODBADEDMB(MethodInfo NOEMNCPPIEP, MethodInfo NBFBKDPIFBA, DOPCOIFOIKN DMEGHACCPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void CKPIOIBAHAC(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PHGJGPPPDIL(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		protected HNADDNAJECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class CDAEPKHOJAN<TClass, TProperty> : HNADDNAJECH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> NMMBOMDOOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> MPDPDJNDMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> CHNHMDJDIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> OJDBLIEBAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> AFMMMGIPMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> GMCKMHMCCKF;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x48EBA30", Offset = "0x48EAC30", VA = "0x1848EBA30", Slot = "7")]
		public override void AIBHKKIMAHE(TClass HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x48EC310", Offset = "0x48EB510", VA = "0x1848EC310", Slot = "8")]
		public override void GDAMFGHJILI(TClass HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x48EBDB0", Offset = "0x48EAFB0", VA = "0x1848EBDB0", Slot = "9")]
		public override void CKPIOIBAHAC(TClass HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x48EC7E0", Offset = "0x48EB9E0", VA = "0x1848EC7E0", Slot = "10")]
		public override void PHGJGPPPDIL(TClass HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x48EC210", Offset = "0x48EB410", VA = "0x1848EC210")]
		protected TProperty[] EFOPFCCKPEA(TClass HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x48EC770", Offset = "0x48EB970", VA = "0x1848EC770")]
		protected TProperty[] KJDDBKIPAOH(TClass HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x48ED7C0", Offset = "0x48EC9C0", VA = "0x1848ED7C0", Slot = "4")]
		public override void PIODBADEDMB(MethodInfo NOEMNCPPIEP, MethodInfo NBFBKDPIFBA, DOPCOIFOIKN DMEGHACCPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3741B20", Offset = "0x3740D20", VA = "0x183741B20")]
		protected CDAEPKHOJAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class EHPHAANLDIF<TClass, TProperty> : CDAEPKHOJAN<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void OAJLBLDJMAK(ELBJKFKBJLN PGPFOODFIEA, [Out] TProperty PLGPFGFIJKK);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void LJNFLNHNKMD(LLEGFCIIDBN MBCBCOEONAH, TProperty PLGPFGFIJKK);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x32B8FC0", Offset = "0x32B81C0", VA = "0x1832B8FC0", Slot = "5")]
		public override void IPIDAKPHGJN(TClass HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x32B8E10", Offset = "0x32B8010", VA = "0x1832B8E10", Slot = "6")]
		public override void EGPLHGBNEEA(TClass HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x32B8C60", Offset = "0x32B7E60", VA = "0x1832B8C60", Slot = "7")]
		public override void AIBHKKIMAHE(TClass HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x32B8F20", Offset = "0x32B8120", VA = "0x1832B8F20", Slot = "8")]
		public override void GDAMFGHJILI(TClass HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x32B90C0", Offset = "0x32B82C0", VA = "0x1832B90C0")]
		protected EHPHAANLDIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class GHNEICEMMBF<T> : CDAEPKHOJAN<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3756120", Offset = "0x3755320", VA = "0x183756120", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x37560C0", Offset = "0x37552C0", VA = "0x1837560C0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3756050", Offset = "0x3755250", VA = "0x183756050", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x32C85D0", Offset = "0x32C77D0", VA = "0x1832C85D0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public GHNEICEMMBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LLJOPANKPMF<T> : CDAEPKHOJAN<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FD10", Offset = "0x3C9EF10", VA = "0x183C9FD10", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x37560C0", Offset = "0x37552C0", VA = "0x1837560C0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FCA0", Offset = "0x3C9EEA0", VA = "0x183C9FCA0", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x32C85D0", Offset = "0x32C77D0", VA = "0x1832C85D0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public LLJOPANKPMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class ICLGDMCAKIO<T> : CDAEPKHOJAN<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x388B7C0", Offset = "0x388A9C0", VA = "0x18388B7C0", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x388B700", Offset = "0x388A900", VA = "0x18388B700", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x388B690", Offset = "0x388A890", VA = "0x18388B690", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x388B760", Offset = "0x388A960", VA = "0x18388B760", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public ICLGDMCAKIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class DKKFMEIIJBM<T> : CDAEPKHOJAN<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x507F200", Offset = "0x507E400", VA = "0x18507F200", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x388B700", Offset = "0x388A900", VA = "0x18388B700", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x507F190", Offset = "0x507E390", VA = "0x18507F190", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x388B760", Offset = "0x388A960", VA = "0x18388B760", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public DKKFMEIIJBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class JFMFEMLBEGB<T> : CDAEPKHOJAN<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3A8EF00", Offset = "0x3A8E100", VA = "0x183A8EF00", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3A8EEA0", Offset = "0x3A8E0A0", VA = "0x183A8EEA0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3A8EE30", Offset = "0x3A8E030", VA = "0x183A8EE30", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x37FEB60", Offset = "0x37FDD60", VA = "0x1837FEB60", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public JFMFEMLBEGB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OGCKCEMGEFB<T> : CDAEPKHOJAN<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4068530", Offset = "0x4067730", VA = "0x184068530", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A8EEA0", Offset = "0x3A8E0A0", VA = "0x183A8EEA0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x40684C0", Offset = "0x40676C0", VA = "0x1840684C0", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x37FEB60", Offset = "0x37FDD60", VA = "0x1837FEB60", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public OGCKCEMGEFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class DNEGGFHHPAL<T> : CDAEPKHOJAN<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F10", Offset = "0x32A9110", VA = "0x1832A9F10", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x32A9E50", Offset = "0x32A9050", VA = "0x1832A9E50", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x508ABC0", Offset = "0x5089DC0", VA = "0x18508ABC0", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x32A9EB0", Offset = "0x32A90B0", VA = "0x1832A9EB0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public DNEGGFHHPAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class EBIPINHIPCI<T> : CDAEPKHOJAN<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F10", Offset = "0x32A9110", VA = "0x1832A9F10", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x32A9E50", Offset = "0x32A9050", VA = "0x1832A9E50", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x32A9DE0", Offset = "0x32A8FE0", VA = "0x1832A9DE0", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x32A9EB0", Offset = "0x32A90B0", VA = "0x1832A9EB0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public EBIPINHIPCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class ELKNBCHOMOC<T> : CDAEPKHOJAN<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x32C8630", Offset = "0x32C7830", VA = "0x1832C8630", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x32C8570", Offset = "0x32C7770", VA = "0x1832C8570", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x32C8500", Offset = "0x32C7700", VA = "0x1832C8500", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x32C85D0", Offset = "0x32C77D0", VA = "0x1832C85D0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public ELKNBCHOMOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class HMBBLPPLIPA<T> : CDAEPKHOJAN<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x37FEBC0", Offset = "0x37FDDC0", VA = "0x1837FEBC0", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x37FEB00", Offset = "0x37FDD00", VA = "0x1837FEB00", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x37FEA90", Offset = "0x37FDC90", VA = "0x1837FEA90", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x37FEB60", Offset = "0x37FDD60", VA = "0x1837FEB60", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public HMBBLPPLIPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CAPPNODADJE<T> : CDAEPKHOJAN<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x48E3210", Offset = "0x48E2410", VA = "0x1848E3210", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x48E31B0", Offset = "0x48E23B0", VA = "0x1848E31B0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x48E3140", Offset = "0x48E2340", VA = "0x1848E3140", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x32A9EB0", Offset = "0x32A90B0", VA = "0x1832A9EB0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x32A9F80", Offset = "0x32A9180", VA = "0x1832A9F80")]
		public CAPPNODADJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class NPJABDDOLKJ<T> : EHPHAANLDIF<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F884E0", Offset = "0x3F876E0", VA = "0x183F884E0", Slot = "12")]
		protected override void LJNFLNHNKMD(LLEGFCIIDBN MBCBCOEONAH, char PLGPFGFIJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3F88510", Offset = "0x3F87710", VA = "0x183F88510", Slot = "11")]
		protected override void OAJLBLDJMAK(ELBJKFKBJLN PGPFOODFIEA, [Out] char PLGPFGFIJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3618FD0", Offset = "0x36181D0", VA = "0x183618FD0")]
		public NPJABDDOLKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class MLMKBEDLPGM<T> : EHPHAANLDIF<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3E85400", Offset = "0x3E84600", VA = "0x183E85400", Slot = "12")]
		protected override void LJNFLNHNKMD(LLEGFCIIDBN MBCBCOEONAH, IPEndPoint PLGPFGFIJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E85430", Offset = "0x3E84630", VA = "0x183E85430", Slot = "11")]
		protected override void OAJLBLDJMAK(ELBJKFKBJLN PGPFOODFIEA, [Out] IPEndPoint PLGPFGFIJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3618FD0", Offset = "0x36181D0", VA = "0x183618FD0")]
		public MLMKBEDLPGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CKBAHFODONC<T> : CDAEPKHOJAN<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int NBDKOCKFIII;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4AB7F30", Offset = "0x4AB7130", VA = "0x184AB7F30")]
		public CKBAHFODONC(int GCBBIJKLBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4AB7EC0", Offset = "0x4AB70C0", VA = "0x184AB7EC0", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4AB7DE0", Offset = "0x4AB6FE0", VA = "0x184AB7DE0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4AB7D70", Offset = "0x4AB6F70", VA = "0x184AB7D70", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4AB7E50", Offset = "0x4AB7050", VA = "0x184AB7E50", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class KJOLOALAJKM<T> : HNADDNAJECH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo LGKIHDDICLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type MIFCPFBPDME;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B6CA20", Offset = "0x3B6BC20", VA = "0x183B6CA20")]
		public KJOLOALAJKM(PropertyInfo EPEGAGFKJNJ, Type ELGFKOGIHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C900", Offset = "0x3B6BB00", VA = "0x183B6C900", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C7F0", Offset = "0x3B6B9F0", VA = "0x183B6C7F0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C730", Offset = "0x3B6B930", VA = "0x183B6C730", Slot = "7")]
		public override void AIBHKKIMAHE(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C8A0", Offset = "0x3B6BAA0", VA = "0x183B6C8A0", Slot = "8")]
		public override void GDAMFGHJILI(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C790", Offset = "0x3B6B990", VA = "0x183B6C790", Slot = "9")]
		public override void CKPIOIBAHAC(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3B6C9C0", Offset = "0x3B6BBC0", VA = "0x183B6C9C0", Slot = "10")]
		public override void PHGJGPPPDIL(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class GIJMBMANHJC<T> : KJOLOALAJKM<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x32B5530", Offset = "0x32B4730", VA = "0x1832B5530")]
		public GIJMBMANHJC(PropertyInfo EPEGAGFKJNJ, Type ELGFKOGIHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3758EA0", Offset = "0x37580A0", VA = "0x183758EA0", Slot = "5")]
		public override void IPIDAKPHGJN(T HBBGPEJCIGP, ELBJKFKBJLN PGPFOODFIEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3758DF0", Offset = "0x3757FF0", VA = "0x183758DF0", Slot = "6")]
		public override void EGPLHGBNEEA(T HBBGPEJCIGP, LLEGFCIIDBN MBCBCOEONAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class GHCOIDMKLAG<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static GHCOIDMKLAG<T> MJANIPKLNPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly HNADDNAJECH<T>[] CBEKDDIGLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int LIDLLALCFKO;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x37551F0", Offset = "0x37543F0", VA = "0x1837551F0")]
		public GHCOIDMKLAG(List<HNADDNAJECH<T>> IODNGLMCBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3755090", Offset = "0x3754290", VA = "0x183755090")]
		public void EGPLHGBNEEA(T MFLACBLODGN, LLEGFCIIDBN MNAHEBBEBLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3755140", Offset = "0x3754340", VA = "0x183755140")]
		public void IPIDAKPHGJN(T MFLACBLODGN, ELBJKFKBJLN ODNMKNFNAPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class MEDKJBADEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract HNADDNAJECH<T> EOIPIOCNLEH<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private LLEGFCIIDBN PGICOOFNLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int DIDACKDGLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, MEDKJBADEMP> PJBPLBJEMJA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x55EA800", Offset = "0x55E9A00", VA = "0x1855EA800")]
	public JBJEPIJOEAH(int EBEBCNGMJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x27E2030", Offset = "0x27E1230", VA = "0x1827E2030")]
	private GHCOIDMKLAG<T> PELPAECIAAL<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x261C7C0", Offset = "0x261B9C0", VA = "0x18261C7C0")]
	public void MPIFNDMAGPL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x27E1F50", Offset = "0x27E1150", VA = "0x1827E1F50")]
	public bool APPDJDLGIOH<T>(ELBJKFKBJLN ODNMKNFNAPP, T MJBOJGOCOJL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x27E1FD0", Offset = "0x27E11D0", VA = "0x1827E1FD0")]
	public void CJMGAEMJONM<T>(LLEGFCIIDBN MNAHEBBEBLG, T MFLACBLODGN) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GHKGLJCMKOM
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime JBFLDKPKMAK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] ENBGCGDEDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CHKBLCOKFNG HJNHFCDCEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x55E4BA0", Offset = "0x55E3DA0", VA = "0x1855E4BA0")]
		get
		{
			return default(CHKBLCOKFNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FPEDJPNBIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x55E52C0", Offset = "0x55E44C0", VA = "0x1855E52C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x55E4B60", Offset = "0x55E3D60", VA = "0x1855E4B60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public DECHPCEHOHE AKDDLKKPGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x55E5330", Offset = "0x55E4530", VA = "0x1855E5330")]
		get
		{
			return default(DECHPCEHOHE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x55E52F0", Offset = "0x55E44F0", VA = "0x1855E52F0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DLOMGOFNDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x55E4E00", Offset = "0x55E4000", VA = "0x1855E4E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint KENEMFACDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x55E53F0", Offset = "0x55E45F0", VA = "0x1855E53F0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? MEEHMHKOKME
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x55E5890", Offset = "0x55E4A90", VA = "0x1855E5890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? IBPCINAJGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x55E4B30", Offset = "0x55E3D30", VA = "0x1855E4B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? LNHELACDFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x55E5540", Offset = "0x55E4740", VA = "0x1855E5540")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x55E4960", Offset = "0x55E3B60", VA = "0x1855E4960")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? MKFCOEKOLBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAE2150", Offset = "0xAE1350", VA = "0x180AE2150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9115E0", Offset = "0x9107E0", VA = "0x1809115E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x55E5920", Offset = "0x55E4B20", VA = "0x1855E5920")]
	public GHKGLJCMKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x55E5C40", Offset = "0x55E4E40", VA = "0x1855E5C40")]
	internal GHKGLJCMKOM(byte[] EHGLENBKLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x55E5570", Offset = "0x55E4770", VA = "0x1855E5570")]
	public static GHKGLJCMKOM MIPGPDGFBGD(byte[] EHGLENBKLPL, DateTime CHGMBPBIDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x55E4E30", Offset = "0x55E4030", VA = "0x1855E4E30")]
	internal void EKNNKOOBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x55E4C30", Offset = "0x55E3E30", VA = "0x1855E4C30")]
	private void CFGHNEANMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x55E5690", Offset = "0x55E4890", VA = "0x1855E5690")]
	private DateTime? NHAEOFKAHLD(int GNHLLBKBLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x55E5030", Offset = "0x55E4230", VA = "0x1855E5030")]
	private void FKCGGBEBEBE(int GNHLLBKBLJF, DateTime? AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x55E5470", Offset = "0x55E4670", VA = "0x1855E5470")]
	private ulong KNJHEGNCMNI(int GNHLLBKBLJF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x55E5200", Offset = "0x55E4400", VA = "0x1855E5200")]
	private void FKGDCFEDDMG(int GNHLLBKBLJF, ulong AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x55E5360", Offset = "0x55E4560", VA = "0x1855E5360")]
	private uint HPCMJMAAMHK(int GNHLLBKBLJF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x54AD100", Offset = "0x54AC300", VA = "0x1854AD100")]
	private static uint CFEFNCKDOHJ(uint DHOHKCEOCND)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x55E4BD0", Offset = "0x55E3DD0", VA = "0x1855E4BD0")]
	private static ulong CFEFNCKDOHJ(ulong DHOHKCEOCND)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum CHKBLCOKFNG
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
public enum DECHPCEHOHE
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class KKNAGILJNBE
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int BMCJCPBNCAC = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int DLNHFKCLJBM = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int GPCGBGBBJIJ = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint NAEPCNEMJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int EPBPFFDIDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int DPDBODDMOHN;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool KBMKIDLAOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x55EB320", Offset = "0x55EA520", VA = "0x1855EB320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x55EB330", Offset = "0x55EA530", VA = "0x1855EB330")]
	public bool NJKPGCHPFIO(MJEOEBHNCAM JPOBGNMAKIK, int PODEEFCDAGD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class FPBCOGJIEMG : MJEOEBHNCAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket JPOBGNMAKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ADDCGBBFKGH IMKBEDOHKAO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short OINMKLMCOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x55E4140", Offset = "0x55E3340", VA = "0x1855E4140", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int NHDPNNGNLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x55E4720", Offset = "0x55E3920", VA = "0x1855E4720", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint NNNIFDEPFLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x55E4890", Offset = "0x55E3A90", VA = "0x1855E4890", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily IOBJKFAEPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF28C0", Offset = "0x3BF1AC0", VA = "0x183BF28C0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x55E48B0", Offset = "0x55E3AB0", VA = "0x1855E48B0")]
	public FPBCOGJIEMG(AddressFamily KGOCGJDOGID, ADDCGBBFKGH IMKBEDOHKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x55E4160", Offset = "0x55E3360", VA = "0x1855E4160", Slot = "8")]
	public bool CPJCJDKOGOB(IPEndPoint GAKMLEJIDOA, IEPDDNKLNBD LNHJMNFCFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x55E4830", Offset = "0x55E3A30", VA = "0x1855E4830", Slot = "9")]
	public int IJBMFPPCJHE(byte[] JCGIBGELCJL, int GNHLLBKBLJF, int DKMFLNHKFDF, IPEndPoint FNMHEOANGNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x55E4740", Offset = "0x55E3940", VA = "0x1855E4740", Slot = "10")]
	public int EJNBFDNPMIC(byte[] JCGIBGELCJL, EndPoint APJEMIANHEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x55E4870", Offset = "0x55E3A70", VA = "0x1855E4870", Slot = "11")]
	public void KLJOGHGDFHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface MJEOEBHNCAM
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short OINMKLMCOHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int NHDPNNGNLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint NNNIFDEPFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily IOBJKFAEPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CPJCJDKOGOB(IPEndPoint GAKMLEJIDOA, IEPDDNKLNBD LNHJMNFCFMI);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int IJBMFPPCJHE(byte[] JCGIBGELCJL, int GNHLLBKBLJF, int DKMFLNHKFDF, IPEndPoint FNMHEOANGNC);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EJNBFDNPMIC(byte[] JCGIBGELCJL, EndPoint FNMHEOANGNC);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLJOGHGDFHM();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct OFIPCMHANCK : IEquatable<OFIPCMHANCK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long BDJHPMALDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long NHPMJHDAJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long ADJKJAAIFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int KFFACOLGABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int IEMIHJBOFLK;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x55EF710", Offset = "0x55EE910", VA = "0x1855EF710")]
	public OFIPCMHANCK(byte[] DGPEIEAMDCM, int BFDHININPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7E39A0", Offset = "0x7E2BA0", VA = "0x1807E39A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x55EF6D0", Offset = "0x55EE8D0", VA = "0x1855EF6D0", Slot = "4")]
	public bool Equals(OFIPCMHANCK NFMPGFPPFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x55EF620", Offset = "0x55EE820", VA = "0x1855EF620", Slot = "0")]
	public override bool Equals(object MFLACBLODGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class GHAILKELCAP : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] KJKPIBCDBPB;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class JNMPJPAPAOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int GCDGNCANLKE;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD570", Offset = "0x7BC770", VA = "0x1807BD570")]
	protected JNMPJPAPAOF(int DMAEGFGONOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void ADIMLBPENMO(IPEndPoint GAKMLEJIDOA, byte[] GKNJGNIHLDH, int GNHLLBKBLJF, int NCLKCGHBFFI);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void LEMGJLPFEDM(IPEndPoint GAKMLEJIDOA, byte[] GKNJGNIHLDH, int GNHLLBKBLJF, int NCLKCGHBFFI);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LMLBKKMLIHJ : JNMPJPAPAOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider COICEOBBPDC;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator KHDCBCLIELG;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x55ED4C0", Offset = "0x55EC6C0", VA = "0x1855ED4C0")]
	public LMLBKKMLIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x55ECDF0", Offset = "0x55EBFF0", VA = "0x1855ECDF0")]
	public void KCLDMMMEPNE(IPEndPoint GAKMLEJIDOA, byte[] HKNPGHOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x55ECD10", Offset = "0x55EBF10", VA = "0x1855ECD10")]
	public void GOAJMMNCGJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x55ED030", Offset = "0x55EC230", VA = "0x1855ED030")]
	private byte[] KGDFLEONALA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x55EC880", Offset = "0x55EBA80", VA = "0x1855EC880", Slot = "4")]
	public override void ADIMLBPENMO(IPEndPoint GAKMLEJIDOA, byte[] GKNJGNIHLDH, int GNHLLBKBLJF, int NCLKCGHBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x55ED0C0", Offset = "0x55EC2C0", VA = "0x1855ED0C0", Slot = "5")]
	public override void LEMGJLPFEDM(IPEndPoint GAKMLEJIDOA, byte[] GKNJGNIHLDH, int GNHLLBKBLJF, int NCLKCGHBFFI)
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
