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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, OCNPNGALDKC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum CIABDDAKIDH
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
		private NetworkManager CKCKOKJINPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, ABFGCNDJPEP> NPHIMOCMLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MOGAHGDHPMB JCJOFHPPLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] LNNDECJOHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CIABDDAKIDH EBDOJNPLGBL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong BCIHBPJHOMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool CBIPEGBCHNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5FC5A10", Offset = "0x5FC4410", VA = "0x185FC5A10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4F20", Offset = "0x5FC3920", VA = "0x185FC4F20")]
		public void RecRoom_SetEncryptionInfo(ulong HMCJLJPLJIN, byte[] JODEIIFHAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4F00", Offset = "0x5FC3900", VA = "0x185FC4F00")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4D10", Offset = "0x5FC3710", VA = "0x185FC4D10")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5910", Offset = "0x5FC4310", VA = "0x185FC5910")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FC50C0", Offset = "0x5FC3AC0", VA = "0x185FC50C0", Slot = "6")]
		public override void Send(ulong ENKBOFALDKE, ArraySegment<byte> OIGMDCDEKEG, NetworkDelivery GOHDCCOKDPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4EC0", Offset = "0x5FC38C0", VA = "0x185FC4EC0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong ENKBOFALDKE, [Out] ArraySegment<byte> NGDEBDJEGEI, [Out] float JKOCOAIBDHC)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC53B0", Offset = "0x5FC3DB0", VA = "0x185FC53B0", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5830", Offset = "0x5FC4230", VA = "0x185FC5830", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC46A0", Offset = "0x5FC30A0", VA = "0x185FC46A0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong ENKBOFALDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4550", Offset = "0x5FC2F50", VA = "0x185FC4550", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4950", Offset = "0x5FC3350", VA = "0x185FC4950", Slot = "12")]
		public override ulong GetCurrentRtt(ulong ENKBOFALDKE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5340", Offset = "0x5FC3D40", VA = "0x185FC5340", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4B50", Offset = "0x5FC3550", VA = "0x185FC4B50", Slot = "14")]
		public override void Initialize([Optional] NetworkManager CKCKOKJINPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4450", Offset = "0x5FC2E50", VA = "0x185FC4450")]
		private EJCMDCNEDCE BMEMLOBIEFK(NetworkDelivery NNCMOPPBEEE)
		{
			return default(EJCMDCNEDCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4E00", Offset = "0x5FC3800", VA = "0x185FC4E00", Slot = "15")]
		private void PDGBOGCCGNO(ABFGCNDJPEP PPHBKLNICMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FC49F0", Offset = "0x5FC33F0", VA = "0x185FC49F0", Slot = "16")]
		private void HIJJGGOANKG(ABFGCNDJPEP PPHBKLNICMK, DHOJILIPHNI GKMOIKNALMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "17")]
		private void NMOOHCHAPOJ(IPEndPoint DOMJEACIBAG, SocketError IOEDABHJAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4240", Offset = "0x5FC2C40", VA = "0x185FC4240", Slot = "18")]
		private void BJHCNHBGEBC(ABFGCNDJPEP PPHBKLNICMK, OEMKPEIHKJJ PHJKOICFNBE, byte JOKFPLECAEN, EJCMDCNEDCE BAELPIJBBPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4870", Offset = "0x5FC3270", VA = "0x185FC4870")]
		private void GHDHCPCICKK(int MPLHLKNKHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "19")]
		private void EDNBKFFNBNJ(IPEndPoint PPNKOEFPOCO, OEMKPEIHKJJ PHJKOICFNBE, PNMECKABAAO AEEGHAOENMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "20")]
		private void DAFIGLFICFK(ABFGCNDJPEP PPHBKLNICMK, int BDAKMBDIHHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4810", Offset = "0x5FC3210", VA = "0x185FC4810", Slot = "21")]
		private void ECIHIPPMLMB(FLLGDDCMEBF IHHJPAMNDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4520", Offset = "0x5FC2F20", VA = "0x185FC4520")]
		private ulong CFEEHKJAGFM(ABFGCNDJPEP PPHBKLNICMK)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC4B30", Offset = "0x5FC3530", VA = "0x185FC4B30")]
		private static int IIPBBCOFOJB(float CCMOFMGPDOB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC5930", Offset = "0x5FC4330", VA = "0x185FC5930")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class FHALJNDDJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly ABFGCNDJPEP HOHBHBHHAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<LMCHJGOIFKM> GKJAPDPOCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int OJFPEMDLOAB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0010", Offset = "0x5FBEA10", VA = "0x185FC0010")]
	protected FHALJNDDJPJ(ABFGCNDJPEP PPHBKLNICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFEF0", Offset = "0x5FBE8F0", VA = "0x185FBFEF0")]
	public void AAGFNPEBMDB(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFF50", Offset = "0x5FBE950", VA = "0x185FBFF50")]
	protected void AKCGNABFINO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFFD0", Offset = "0x5FBE9D0", VA = "0x185FBFFD0")]
	public bool JNAPKNIGHIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool BAONNMMFOGF();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GMAFADNIJLD(LMCHJGOIFKM GBLEPNNFAOP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum OELDLGNCGCG
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
public class FLLGDDCMEBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MOGAHGDHPMB JKKDKDENCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int BEEDKCPIPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MACNEJPCNMD PAMDDGNJCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint LLCNJFGHMOE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal OELDLGNCGCG BIJLDFBAGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AC930", Offset = "0x8AB330", VA = "0x1808AC930")]
		[CompilerGenerated]
		get
		{
			return default(OELDLGNCGCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC622C0", Offset = "0xC60CC0", VA = "0x180C622C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0110", Offset = "0x5FBEB10", VA = "0x185FC0110")]
	internal void HNNKGNOHJDC(MACNEJPCNMD BDJPFENOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FC01D0", Offset = "0x5FBEBD0", VA = "0x185FC01D0")]
	private bool PMDFCGOBNNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0200", Offset = "0x5FBEC00", VA = "0x185FC0200")]
	internal FLLGDDCMEBF(IPEndPoint PPNKOEFPOCO, MACNEJPCNMD EDBBOOLBCBA, MOGAHGDHPMB MFNDIOIIFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0170", Offset = "0x5FBEB70", VA = "0x185FC0170")]
	public ABFGCNDJPEP IGHBNAPMOOK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum PNMECKABAAO
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum KIFCLELHPGO
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
public struct DHOJILIPHNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public KIFCLELHPGO LMGJBLEBODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PPEFFPLBBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OEMKPEIHKJJ PNKNOLPKBEG;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OCNPNGALDKC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKHPACCGEAD(ABFGCNDJPEP PPHBKLNICMK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FIMCBIDODNA(ABFGCNDJPEP PPHBKLNICMK, DHOJILIPHNI GKMOIKNALMI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNHNNLKKCJC(IPEndPoint DOMJEACIBAG, SocketError IOEDABHJAHA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJGHNJBMOPC(ABFGCNDJPEP PPHBKLNICMK, OEMKPEIHKJJ PHJKOICFNBE, byte JOKFPLECAEN, EJCMDCNEDCE BAELPIJBBPL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNANBBHGKED(IPEndPoint PPNKOEFPOCO, OEMKPEIHKJJ PHJKOICFNBE, PNMECKABAAO AEEGHAOENMD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACDIEABMGFI(ABFGCNDJPEP PPHBKLNICMK, int BDAKMBDIHHG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMKBHIGCFPE(FLLGDDCMEBF IHHJPAMNDBP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NIHDNFFEPHE
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NCGEHGOBOBO(ABFGCNDJPEP PPHBKLNICMK, object OINGFEKIDHI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FLOPMLLFJHE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDBEOOMOLBE(DPAEPBPGKAN GBLEPNNFAOP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JKDOJAGOJND
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICBCOGPAKFD(ABFGCNDJPEP PPHBKLNICMK, IPEndPoint GBPNHGIPKCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MACNEJPCNMD
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int NBONPCOHLIP = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long EILKCBJOIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte HBGGOEJMAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] DAOMOHOOKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly EFCFMPLJLCB CNPFJDANIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int HEKIIPOIJIH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5E90", Offset = "0x5FC4890", VA = "0x185FC5E90")]
	private MACNEJPCNMD(long PBKHMFDNAEH, byte MECGGNAKFDG, int ELHMIJIMOPL, byte[] KJHADJPCMOJ, EFCFMPLJLCB OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5C10", Offset = "0x5FC4610", VA = "0x185FC5C10")]
	public static int KMBEMEMLHCO(LMCHJGOIFKM GBLEPNNFAOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5C70", Offset = "0x5FC4670", VA = "0x185FC5C70")]
	public static MACNEJPCNMD OIPALMNAAGI(LMCHJGOIFKM GBLEPNNFAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5A30", Offset = "0x5FC4430", VA = "0x185FC5A30")]
	public static LMCHJGOIFKM IJAOIANAGDE(HNJDBLMAIOH EHDDIDABBKN, SocketAddress PPIHIINAALF, long HGPGBJNPLBB, int ELHMIJIMOPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class IKPMCMCOEEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long EILKCBJOIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte HBGGOEJMAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int HEKIIPOIJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool EPMLNHJBKEP;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1EF0", Offset = "0x5FC08F0", VA = "0x185FC1EF0")]
	private IKPMCMCOEEG(long PBKHMFDNAEH, byte MECGGNAKFDG, int EGOHENOKEIC, bool OLDJCFKPHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1DA0", Offset = "0x5FC07A0", VA = "0x185FC1DA0")]
	public static IKPMCMCOEEG OIPALMNAAGI(LMCHJGOIFKM GBLEPNNFAOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1BB0", Offset = "0x5FC05B0", VA = "0x185FC1BB0")]
	public static LMCHJGOIFKM IJAOIANAGDE(long HGPGBJNPLBB, byte KNOOOHAODNK, int HNEFBKLKKOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1CA0", Offset = "0x5FC06A0", VA = "0x185FC1CA0")]
	public static LMCHJGOIFKM NLHMPBKCOAF(ABFGCNDJPEP PPHBKLNICMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum NJOKGHGGIME
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LPNJOMKJJFE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CAOEOEEJPPB(IPEndPoint IIHLICNFNIG, IPEndPoint PPNKOEFPOCO, string KLGLJKMNAIM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPDKPKJMDFN(IPEndPoint ECDGEICOCKM, NJOKGHGGIME NNCMOPPBEEE, string KLGLJKMNAIM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class NJNPFBCABIG
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct AMLGOIEPHNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint FOIBDDINBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint LLCNJFGHMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string FHCIEHPBAPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct HDJLCJGMJJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint OEDFCPGAKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public NJOKGHGGIME HMGDADDECHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string FHCIEHPBAPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class ONCGHFKPBDK
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BNNPDCBGJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string FHCIEHPBAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ONCGHFKPBDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class ODLJDAKELOH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BNNPDCBGJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LIHBGEDEBGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string FHCIEHPBAPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public ODLJDAKELOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class CIHGEDEIFCM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FHCIEHPBAPD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NHLIIODHGBO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB720", VA = "0x1809ECD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x888E70", Offset = "0x887870", VA = "0x180888E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CIHGEDEIFCM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MOGAHGDHPMB LFCHBEFBAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<AMLGOIEPHNI> GHGOHKEKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<HDJLCJGMJJH> MBHLKMELENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly EFCFMPLJLCB BGILIJLNBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly HNJDBLMAIOH EDDFMHBDAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JDHEHEIAFBA JGHJOBPLHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private LPNJOMKJJFE ABCCHNOJOCD;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int IKPNLHBFFHB = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool LNKLGIAOGMC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE780", Offset = "0x5FCD180", VA = "0x185FCE780")]
	internal NJNPFBCABIG(MOGAHGDHPMB COJNMKAFAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE620", Offset = "0x5FCD020", VA = "0x185FCE620")]
	internal void LOIGJGKPIIA(IPEndPoint ODLAKEGMOJI, LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC44E0", VA = "0x182DC5AE0")]
	private void BHGFHDJPEPF<T>(T GBLEPNNFAOP, IPEndPoint IPOCAIFIKHJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE190", Offset = "0x5FCCB90", VA = "0x185FCE190")]
	private void CAOEOEEJPPB(ONCGHFKPBDK MLEACKBEPAO, IPEndPoint ODLAKEGMOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE4C0", Offset = "0x5FCCEC0", VA = "0x185FCE4C0")]
	private void LMCNKLAPJDK(ODLJDAKELOH MLEACKBEPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE320", Offset = "0x5FCCD20", VA = "0x185FCE320")]
	private void KNADHKEBGCA(CIHGEDEIFCM MLEACKBEPAO, IPEndPoint ODLAKEGMOJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum EJCMDCNEDCE : byte
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
public enum DEKHJILJAJN : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BGKMFHOIPCK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] BFHEKFEIEBA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int LCHOECPKKEN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int KCFDBCOKAGH;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HECDLGMJGGF : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D60", Offset = "0x5FBF760", VA = "0x185FC0D60")]
	public HECDLGMJGGF(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KBENHENPMNN : HECDLGMJGGF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D60", Offset = "0x5FBF760", VA = "0x185FC0D60")]
	public KBENHENPMNN(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JMENOKBKONM
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
public interface BFCPGADIAFB
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAALOHGNNOJ(JMENOKBKONM PBPFMICJHGL, string EEOEDIPLNFM, params object[] EBIJIHILGPC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class LDLOCNEBGCD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static BFCPGADIAFB AMBGHOJGECJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object CAJLOBAKJIC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FC33D0", Offset = "0x5FC1DD0", VA = "0x185FC33D0")]
	private static void NFIGKPNNEKI(JMENOKBKONM PAENAOHCDHM, string EEOEDIPLNFM, params object[] EBIJIHILGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FC32B0", Offset = "0x5FC1CB0", VA = "0x185FC32B0")]
	internal static void AEININKPMDN(string EEOEDIPLNFM, params object[] EBIJIHILGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3310", Offset = "0x5FC1D10", VA = "0x185FC3310")]
	internal static void BFLIGIBDABN(string EEOEDIPLNFM, params object[] EBIJIHILGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3370", Offset = "0x5FC1D70", VA = "0x185FC3370")]
	internal static void CJEHHANDDMP(string EEOEDIPLNFM, params object[] EBIJIHILGPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum BIGBFEGLKHH
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OEMKPEIHKJJ : EFCFMPLJLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private LMCHJGOIFKM GNFOAAKLLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MOGAHGDHPMB LIJDIBGOJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly LIAFCJDIEOF EPMGGJIIMBH;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF510", Offset = "0x5FCDF10", VA = "0x185FCF510")]
	internal OEMKPEIHKJJ(MOGAHGDHPMB CMHMDBNCGCO, LIAFCJDIEOF CCMBJBOILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF3F0", Offset = "0x5FCDDF0", VA = "0x185FCF3F0")]
	internal void DPHDBKOGFFE(LMCHJGOIFKM GBLEPNNFAOP, int NPIFNJHCAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF490", Offset = "0x5FCDE90", VA = "0x185FCF490")]
	internal void FOJACFLKNKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF460", Offset = "0x5FCDE60", VA = "0x185FCF460")]
	public void ECHBNEBPCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class LIAFCJDIEOF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum GPBADGINDCP
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
	public LIAFCJDIEOF IDCAEDBDIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GPBADGINDCP HMGDADDECHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ABFGCNDJPEP HOHBHBHHAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint LLCNJFGHMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object FGDKANNDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int MPNHKKDNMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError BNONAHBPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public KIFCLELHPGO CKHCEHBMKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public FLLGDDCMEBF FMNDOGLBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public EJCMDCNEDCE NIIJDNGMLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte KJJIKFOHNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly OEMKPEIHKJJ OKBPDLOJPEC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3740", Offset = "0x5FC2140", VA = "0x185FC3740")]
	public LIAFCJDIEOF(MOGAHGDHPMB CMHMDBNCGCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MOGAHGDHPMB : IEnumerable<ABFGCNDJPEP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class CNBKGGPMGPI : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD5B0", Offset = "0x5FBBFB0", VA = "0x185FBD5B0", Slot = "4")]
		public bool Equals(IPEndPoint ICJCFEHCALD, IPEndPoint MPEFCGEJLMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5AA1B40", Offset = "0x5AA0540", VA = "0x185AA1B40", Slot = "5")]
		public int GetHashCode(IPEndPoint GIGIFGONEAO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public CNBKGGPMGPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct KGNLDBPGDOP : IEnumerator<ABFGCNDJPEP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly ABFGCNDJPEP HCGLJDIFPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private ABFGCNDJPEP DGMMJHEFNGM;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ABFGCNDJPEP JOCMDMELDEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9B0", Offset = "0xA3D3B0", VA = "0x180A3E9B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA3E9B0", Offset = "0xA3D3B0", VA = "0x180A3E9B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x12598C0", Offset = "0x12582C0", VA = "0x1812598C0")]
		public KGNLDBPGDOP(ABFGCNDJPEP KPOIIPENPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2B20", Offset = "0x5FC1520", VA = "0x185FC2B20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2B70", Offset = "0x5FC1570", VA = "0x185FC2B70", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread IHPNEBPBKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool IFDIFFOJHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent BMINAIJMENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<LIAFCJDIEOF> BGHNMAHAIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<LIAFCJDIEOF> OJAOAECHBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private LIAFCJDIEOF KCGDKDIJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OCNPNGALDKC DEPACAJCAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NIHDNFFEPHE NJDINNKMFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly FLOPMLLFJHE COABJDFMIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JKDOJAGOJND KLLNKDLAPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, ABFGCNDJPEP> DDIKNFENADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, FLLGDDCMEBF> BEAJBAMBIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, CNIFIOIKONC> DICGMCMCAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim LDJGPGJAKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ABFGCNDJPEP HHDJOCMLBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int EFCFKLMIFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ABFGCNDJPEP> DMLPPNBIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private ABFGCNDJPEP[] OKIIOMDJDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly BPHNLNKDKFN INOCJIEHGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int JAKJEPHNOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NEGEOJANAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte LNCBIOGOCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object BHDOIKGBHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool EAMEANLHGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool CEGJGKKGFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int MFGHEHPEPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int PGEDCNNNMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int CCBDBJAPDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int EHDHAJIOJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool ICJGBOAEHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool GFCCJHFBDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KDKNCLFADNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int MMONNHBODJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int GGGADNCEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool LNKLGIAOGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool ONAGMGMLLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool DCFDLDBCGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool LFCIKAPMFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int GMOLAMJMBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int NLCDOPMJGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool IPOOFLHKIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly ADFKJGBAFLI KPDPIMAFDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool CIMJFFLIABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly NJNPFBCABIG HAGAHEDNBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool MBCPAFGGKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public BIGBFEGLKHH NJGAEEAOLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int IIHPNOHKOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool DDCANHHOIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GFNGHDIKNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GLDHGIFCFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool OOJHOLIDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private LMCHJGOIFKM KCJONDHIHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int NGOOKGEKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object AAJJJICFDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private LMCHJGOIFKM NOJPIJLBDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int MDDCBLLOKDG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int JIDAPDNMIFG = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int GHJKMGNGIPN = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private NFMHABAANPG JAEACGEPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private NFMHABAANPG LOLDANICKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread NKABHDNBEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread JHBOBINDEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint PGKLCEBGHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint MLGAHHOLMBP;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] GBCIIKBJOKI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] GENGIPHEMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<BCKFCGMAAFJ, IPEndPoint> KALCCBBKDNF;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress FKHBMNEPJGL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool IGGMAKIDNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int BGLLFKOHJOK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PCEHAMJLLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD73580", Offset = "0xD71F80", VA = "0x180D73580")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE14790", Offset = "0xE13190", VA = "0x180E14790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PEOCMBIDMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x16F0410", Offset = "0x16EEE10", VA = "0x1816F0410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1A54A40", Offset = "0x1A53440", VA = "0x181A54A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte LMDBCLKENAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB93B60", Offset = "0xB92560", VA = "0x180B93B60")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int MEBBIKOAJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7300", Offset = "0x5FC5D00", VA = "0x185FC7300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short OPCEJNBDJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5FCC190", Offset = "0x5FCAB90", VA = "0x185FCC190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC250", Offset = "0x5FCAC50", VA = "0x185FCC250")]
	public void NGBPDAPOGCB(IPEndPoint DOMJEACIBAG, byte[] JODEIIFHAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCF90", Offset = "0x5FCB990", VA = "0x185FCCF90")]
	public void PGGCPKNKDBI(IPEndPoint DOMJEACIBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FC95A0", Offset = "0x5FC7FA0", VA = "0x185FC95A0")]
	private bool GEGCHPDNHOC(IPEndPoint DOMJEACIBAG, [Out] ABFGCNDJPEP PPHBKLNICMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7540", Offset = "0x5FC5F40", VA = "0x185FC7540")]
	private void BPEMJJBFILH(ABFGCNDJPEP PPHBKLNICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAF30", Offset = "0x5FC9930", VA = "0x185FCAF30")]
	private void IPBPPMFNCPN(ABFGCNDJPEP PPHBKLNICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FC99D0", Offset = "0x5FC83D0", VA = "0x185FC99D0")]
	private void HBODPNPFFKN(ABFGCNDJPEP PPHBKLNICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDB40", Offset = "0x5FCC540", VA = "0x185FCDB40")]
	public MOGAHGDHPMB(OCNPNGALDKC MFNDIOIIFEM, [Optional] BPHNLNKDKFN BFAHCMBKDBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB140", Offset = "0x5FC9B40", VA = "0x185FCB140")]
	internal void JPNGNEDBKJB(ABFGCNDJPEP EOCOEJPHEBF, int BDAKMBDIHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9900", Offset = "0x5FC8300", VA = "0x185FC9900")]
	internal void GGNFIIOFKBI(ABFGCNDJPEP EOCOEJPHEBF, object OINGFEKIDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB550", Offset = "0x5FC9F50", VA = "0x185FCB550")]
	internal void KOAPBLPJEEL(ABFGCNDJPEP PPHBKLNICMK, KIFCLELHPGO NDHIDCDGEGF, SocketError NFJPMMKOEBC, LMCHJGOIFKM NIMOEMOGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCEB0", Offset = "0x5FCB8B0", VA = "0x185FCCEB0")]
	private void PBCLHOLPKLD(ABFGCNDJPEP PPHBKLNICMK, KIFCLELHPGO NDHIDCDGEGF, SocketError NFJPMMKOEBC, bool MOFNDFHCJJC, byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int KFBJHPBJLOG, LMCHJGOIFKM NIMOEMOGMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB190", Offset = "0x5FC9B90", VA = "0x185FCB190")]
	private void KANAMDNKFML(LIAFCJDIEOF.GPBADGINDCP NNCMOPPBEEE, [Optional] ABFGCNDJPEP PPHBKLNICMK, [Optional] IPEndPoint PPNKOEFPOCO, SocketError FEOFGDLDLGC = SocketError.Success, int BDAKMBDIHHG = 0, KIFCLELHPGO FKCMCDBILLK = KIFCLELHPGO.ConnectionFailed, [Optional] FLLGDDCMEBF MIDPBALPONH, EJCMDCNEDCE BAELPIJBBPL = EJCMDCNEDCE.Unreliable, byte JOKFPLECAEN = 0, [Optional] LMCHJGOIFKM CHMCPHGEDAG, [Optional] object OINGFEKIDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB960", Offset = "0x5FCA360", VA = "0x185FCB960")]
	private void LILPEKJEJOO(LIAFCJDIEOF CCMBJBOILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FC8BB0", Offset = "0x5FC75B0", VA = "0x185FC8BB0")]
	internal void EKDFCKJPGLD(LIAFCJDIEOF CCMBJBOILED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB620", Offset = "0x5FCA020", VA = "0x185FCB620")]
	private void LHLCIAPGNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9C30", Offset = "0x5FC8630", VA = "0x185FC9C30")]
	private void HNHJEKBBEMP(int GMCDELBPOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC470", Offset = "0x5FCAE70", VA = "0x185FCC470")]
	internal ABFGCNDJPEP NKPFKJEBBIO(FLLGDDCMEBF IHHJPAMNDBP, byte[] OLAGMIBBMAA, int PJOMFOPGCGL, int OMBKDMFPMFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9950", Offset = "0x5FC8350", VA = "0x185FC9950")]
	private int HANNCMCCMIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7E90", Offset = "0x5FC6890", VA = "0x185FC7E90")]
	private void EFBNIJEGAFN(IPEndPoint PPNKOEFPOCO, ABFGCNDJPEP FCEDIJFDKII, MACNEJPCNMD MHHKMBCPLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FCA180", Offset = "0x5FC8B80", VA = "0x185FCA180")]
	private void IOLGHHFLPPN(LMCHJGOIFKM GBLEPNNFAOP, IPEndPoint PPNKOEFPOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCA80", Offset = "0x5FCB480", VA = "0x185FCCA80")]
	internal void OCCCMKBAGCN(LMCHJGOIFKM GBLEPNNFAOP, EJCMDCNEDCE JLPOEEBGKKN, byte JOKFPLECAEN, int NPIFNJHCAON, ABFGCNDJPEP EOCOEJPHEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FC8B40", Offset = "0x5FC7540", VA = "0x185FC8B40")]
	public bool EIIEGDCHIMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC82F0", Offset = "0x5FC6CF0", VA = "0x185FC82F0")]
	public bool EIIEGDCHIMI(IPAddress DNPFDMLHNKM, IPAddress AFCLMMMOGJC, int BPMKLCLFPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC8310", Offset = "0x5FC6D10", VA = "0x185FC8310")]
	public bool EIIEGDCHIMI(int BPMKLCLFPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7810", Offset = "0x5FC6210", VA = "0x185FC7810")]
	public void DGFCAEBPPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC90F0", Offset = "0x5FC7AF0", VA = "0x185FC90F0")]
	public ABFGCNDJPEP FKGDEOMGFJB(string CALGHEJMIMF, int BPMKLCLFPCJ, string JODEIIFHAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9010", Offset = "0x5FC7A10", VA = "0x185FC9010")]
	public ABFGCNDJPEP FKGDEOMGFJB(string CALGHEJMIMF, int BPMKLCLFPCJ, HNJDBLMAIOH CEPKEAEDKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC91D0", Offset = "0x5FC7BD0", VA = "0x185FC91D0")]
	public ABFGCNDJPEP FKGDEOMGFJB(IPEndPoint IPOCAIFIKHJ, HNJDBLMAIOH CEPKEAEDKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FC8CB0", Offset = "0x5FC76B0", VA = "0x185FC8CB0")]
	public void ENMEPABNHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FC8CC0", Offset = "0x5FC76C0", VA = "0x185FC8CC0")]
	public void ENMEPABNHMI(bool KOLNHGLHHGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7440", Offset = "0x5FC5E40", VA = "0x185FC7440")]
	public void BEPPPPCLDJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7320", Offset = "0x5FC5D20", VA = "0x185FC7320")]
	public void BEPPPPCLDJN(byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCE00", Offset = "0x5FCB800", VA = "0x185FCCE00")]
	public void PBCLHOLPKLD(ABFGCNDJPEP PPHBKLNICMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCD40", Offset = "0x5FCB740", VA = "0x185FCCD40")]
	public void PBCLHOLPKLD(ABFGCNDJPEP PPHBKLNICMK, byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int KFBJHPBJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD960", Offset = "0x5FCC360", VA = "0x185FCD960", Slot = "4")]
	private IEnumerator<ABFGCNDJPEP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD9F0", Offset = "0x5FCC3F0", VA = "0x185FCD9F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FCB060", Offset = "0x5FC9A60", VA = "0x185FCB060")]
	private LMCHJGOIFKM JJFGGNDMNLN(OHCMAIOBNAC FMKCBFNEFEH, int MPLHLKNKHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FCAF80", Offset = "0x5FC9980", VA = "0x185FCAF80")]
	private LMCHJGOIFKM JJFGGNDMNLN(OHCMAIOBNAC FMKCBFNEFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9F50", Offset = "0x5FC8950", VA = "0x185FC9F50")]
	internal LMCHJGOIFKM IHNDOLLPAOP(int MPLHLKNKHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7C40", Offset = "0x5FC6640", VA = "0x185FC7C40")]
	internal void EDKEBEFHMFB(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDA80", Offset = "0x5FCC480", VA = "0x185FCDA80")]
	static MOGAHGDHPMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xD73580", Offset = "0xD71F80", VA = "0x180D73580")]
	private bool LKCOBPNALCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC7B50", Offset = "0x5FC6550", VA = "0x185FC7B50")]
	private void ECJEMHIBBHP(IPEndPoint ECIOBDFMBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD710", Offset = "0x5FCC110", VA = "0x185FCD710")]
	private void PIPNBNBNPNN(IPEndPoint ECIOBDFMBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FC79B0", Offset = "0x5FC63B0", VA = "0x185FC79B0")]
	private bool DNFELPJJKNN(SocketException PBKGKGDHMFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5FC9630", Offset = "0x5FC8030", VA = "0x185FC9630")]
	private void GGAKLNPDFIJ(NFMHABAANPG COJNMKAFAAD, EndPoint FIDDKJEEKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6F80", Offset = "0x5FC5980", VA = "0x185FC6F80")]
	private void AJHCBMDFEHI(object ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FC8390", Offset = "0x5FC6D90", VA = "0x185FC8390")]
	public bool EIIEGDCHIMI(IPAddress DNPFDMLHNKM, IPAddress AFCLMMMOGJC, int BPMKLCLFPCJ, bool IHLBDFCHELF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC130", Offset = "0x5FCAB30", VA = "0x185FCC130")]
	internal int LIPDDMACLCP(LMCHJGOIFKM GBLEPNNFAOP, IPEndPoint PPNKOEFPOCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD0E0", Offset = "0x5FCBAE0", VA = "0x185FCD0E0")]
	internal int PGKILBAFIFD(LMCHJGOIFKM GBLEPNNFAOP, IPEndPoint PPNKOEFPOCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD120", Offset = "0x5FCBB20", VA = "0x185FCD120")]
	internal int PGKILBAFIFD(byte[] MEBLNPKEJMN, int PJOMFOPGCGL, int OMBKDMFPMFJ, IPEndPoint PPNKOEFPOCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD7F0", Offset = "0x5FCC1F0", VA = "0x185FCD7F0")]
	internal void PJDCDPFAEGO(bool BCLPDCFHDPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum OHCMAIOBNAC : byte
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
internal sealed class LMCHJGOIFKM
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int DMMCBLHLONA;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] EECPAILIDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] AFEIDHGGEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int GCMPBODBNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object FGDKANNDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public LMCHJGOIFKM IDCAEDBDIMH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public OHCMAIOBNAC NBNLLFODCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3C10", Offset = "0x5FC2610", VA = "0x185FC3C10")]
		get
		{
			return default(OHCMAIOBNAC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3B70", Offset = "0x5FC2570", VA = "0x185FC3B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte HBGGOEJMAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3DD0", Offset = "0x5FC27D0", VA = "0x185FC3DD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3880", Offset = "0x5FC2280", VA = "0x185FC3880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort EEAIANKGEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3BB0", Offset = "0x5FC25B0", VA = "0x185FC3BB0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3AC0", Offset = "0x5FC24C0", VA = "0x185FC3AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DPIIIDHMCGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3960", Offset = "0x5FC2360", VA = "0x185FC3960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte JLNMOHKAILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3B00", Offset = "0x5FC2500", VA = "0x185FC3B00")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3A90", Offset = "0x5FC2490", VA = "0x185FC3A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort JNCKCILOEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3C40", Offset = "0x5FC2640", VA = "0x185FC3C40")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3B30", Offset = "0x5FC2530", VA = "0x185FC3B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort PDPDGKDKHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC37E0", Offset = "0x5FC21E0", VA = "0x185FC37E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3840", Offset = "0x5FC2240", VA = "0x185FC3840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort NNLPIEMAOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5FC38C0", Offset = "0x5FC22C0", VA = "0x185FC38C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3920", Offset = "0x5FC2320", VA = "0x185FC3920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3E00", Offset = "0x5FC2800", VA = "0x185FC3E00")]
	static LMCHJGOIFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3DA0", Offset = "0x5FC27A0", VA = "0x185FC3DA0")]
	public void OPKENIKOMGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FC41D0", Offset = "0x5FC2BD0", VA = "0x185FC41D0")]
	public LMCHJGOIFKM(int MPLHLKNKHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FC40C0", Offset = "0x5FC2AC0", VA = "0x185FC40C0")]
	public LMCHJGOIFKM(OHCMAIOBNAC FMKCBFNEFEH, int MPLHLKNKHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3A20", Offset = "0x5FC2420", VA = "0x185FC3A20")]
	public static int GJHNMNPFLKE(OHCMAIOBNAC FMKCBFNEFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3990", Offset = "0x5FC2390", VA = "0x185FC3990")]
	public int GJHNMNPFLKE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3CA0", Offset = "0x5FC26A0", VA = "0x185FC3CA0")]
	public bool OFIOHNMKJCB()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum FENFLBLBBPE : byte
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
internal enum EPJBHDONMPE
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
internal enum BDIBLOAGCDB
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum EHCMNEJKINK
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ABFGCNDJPEP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class HJAONAMBLAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public LMCHJGOIFKM[] KDMJADBJGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int NPOLJEHANPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int DNOPIHMGHAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte JLNMOHKAILN;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HJAONAMBLAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void DCKBOKHDDJD(ulong LLKGBPBCFFN, int GCAIKGCKGCK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int LKPDLIHOBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int CELMHLDNAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int PFLKOMCBNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double CMGAMKMDNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int JKPENOKJMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int DMDNMEHLMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int MHNPGHCKAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch PBDGKOPPEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int DLCBJMDJJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PLGDCCBFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object FBLKLPMKIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal ABFGCNDJPEP MCNPEHKFMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal ABFGCNDJPEP CLKLFAFLGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<LMCHJGOIFKM> GLEDPFBJCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<FHALJNDDJPJ> IHEFOFFAGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly FHALJNDDJPJ[] DJCBPOAMMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int DLAOMIKDMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int DMDJIIBNNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool DJFMFACGPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int PCICFCFNBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int JLNAMKAKNBN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int GJHMHACDLJD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int NJOBHJAHDKM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object OPDGILHNPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int KHKFAPADHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, HJAONAMBLAJ> BEEGBOBIABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> CECBCGKHDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly LMCHJGOIFKM ECHOMHJOJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int AMMMLAMDKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int IMCFAICFNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint ONCLPHCJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int NLLKPMDJJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int BKCHGLCONHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long PLBJMHLDNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte NPCDKGDHNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FENFLBLBBPE HKFLGIKJOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private LMCHJGOIFKM KPFPAIBKAFJ;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int IJLCMEBDOAE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int NFCFONLNKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly LMCHJGOIFKM EJNAMIGLMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly LMCHJGOIFKM OMADIBNOMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly LMCHJGOIFKM JLKFGPDHLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly LMCHJGOIFKM IFIJHEOICPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private DEKHJILJAJN ACLOPOPNAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly MOGAHGDHPMB MNLHFDICGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int KLCNCHBCNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object MAFPAIAOLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly ADFKJGBAFLI KPDPIMAFDMC;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte MEDLFAMJCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA1F0E0", Offset = "0xA1DAE0", VA = "0x180A1F0E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5FBBEC0", Offset = "0x5FBA8C0", VA = "0x185FBBEC0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint PNAIPKDHECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x93A2C0", Offset = "0x938CC0", VA = "0x18093A2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FENFLBLBBPE KHAMMMFFDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x14C5470", Offset = "0x14C3E70", VA = "0x1814C5470")]
		get
		{
			return default(FENFLBLBBPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long FPOBHDLMGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8882F0", Offset = "0x886CF0", VA = "0x1808882F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HIKDKDBMIDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xE562B0", Offset = "0xE54CB0", VA = "0x180E562B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1769270", Offset = "0x1767C70", VA = "0x181769270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PBOENNKPPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9130", Offset = "0x5FB7B30", VA = "0x185FB9130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int FMKKKMMGJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x893630", Offset = "0x892030", VA = "0x180893630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double PDIJNKJLLEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C9E990", Offset = "0x1C9D390", VA = "0x181C9E990")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DCKBOKHDDJD CMLPFGIJGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBBF70", Offset = "0x5FBA970", VA = "0x185FBBF70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8DD0", Offset = "0x5FB77D0", VA = "0x185FB8DD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC210", Offset = "0x5FBAC10", VA = "0x185FBC210")]
	internal ABFGCNDJPEP(MOGAHGDHPMB EOAGLOFOJBE, IPEndPoint PPNKOEFPOCO, int KFBALBFDDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC170", Offset = "0x5FBAB70", VA = "0x185FBC170")]
	internal void LOLAMHMIGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBE90", Offset = "0x5FBA890", VA = "0x185FBBE90")]
	internal void KEIELBNAMJJ(IPEndPoint KAFFKGHLCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FBACF0", Offset = "0x5FB96F0", VA = "0x185FBACF0")]
	internal void GEDLIAAIKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8E80", Offset = "0x5FB7880", VA = "0x185FB8E80")]
	private void BDFJBEJHDMI(int DFNJGEIEINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC1D0", Offset = "0x5FBABD0", VA = "0x185FBC1D0")]
	private void PEBMMMGMNCN(int KCMKMKIMHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8F50", Offset = "0x5FB7950", VA = "0x185FB8F50")]
	private FHALJNDDJPJ BDKOMGCKBOM(byte PEMICEPHOKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC660", Offset = "0x5FBB060", VA = "0x185FBC660")]
	internal ABFGCNDJPEP(MOGAHGDHPMB EOAGLOFOJBE, IPEndPoint PPNKOEFPOCO, int KFBALBFDDFF, byte KNOOOHAODNK, HNJDBLMAIOH EHDDIDABBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC7F0", Offset = "0x5FBB1F0", VA = "0x185FBC7F0")]
	internal ABFGCNDJPEP(MOGAHGDHPMB EOAGLOFOJBE, FLLGDDCMEBF IHHJPAMNDBP, int KFBALBFDDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBB80", Offset = "0x5FBA580", VA = "0x185FBBB80")]
	internal void HDDDPOIJIJN(MACNEJPCNMD GIIPIDLOPEA, byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA820", Offset = "0x5FB9220", VA = "0x185FBA820")]
	internal bool FIGOOBMLAOC(IKPMCMCOEEG GBLEPNNFAOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9100", Offset = "0x5FB7B00", VA = "0x185FB9100")]
	public void BHGFHDJPEPF(byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int OMBKDMFPMFJ, EJCMDCNEDCE IIPNOBBMFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB630", Offset = "0x5FBA030", VA = "0x185FBB630")]
	private void GPGMIMPOKJE(byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int OMBKDMFPMFJ, byte JOKFPLECAEN, EJCMDCNEDCE BAELPIJBBPL, object OINGFEKIDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8D20", Offset = "0x5FB7720", VA = "0x185FB8D20")]
	public void AHIMBFHMBIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA8A0", Offset = "0x5FB92A0", VA = "0x185FBA8A0")]
	internal BDIBLOAGCDB FLEOMILBEJF(LMCHJGOIFKM GBLEPNNFAOP)
	{
		return default(BDIBLOAGCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9140", Offset = "0x5FB7B40", VA = "0x185FB9140")]
	internal void BJEAMJGNPHO(FHALJNDDJPJ MGKHIAMHDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA350", Offset = "0x5FB8D50", VA = "0x185FBA350")]
	internal EHCMNEJKINK DOIEEPPEDBK(byte[] OIGMDCDEKEG, int PJOMFOPGCGL, int OMBKDMFPMFJ, bool MOFNDFHCJJC)
	{
		return default(EHCMNEJKINK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC190", Offset = "0x5FBAB90", VA = "0x185FBC190")]
	private void NBNBGHFODBB(int CAFDGIKGJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FB91A0", Offset = "0x5FB7BA0", VA = "0x185FB91A0")]
	internal void COHKKKCANAH(EJCMDCNEDCE JLPOEEBGKKN, LMCHJGOIFKM KPOIIPENPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FB87D0", Offset = "0x5FB71D0", VA = "0x185FB87D0")]
	private void AHGEHGIOCFN(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA980", Offset = "0x5FB9380", VA = "0x185FBA980")]
	private void FNOGPHNIANI(int OMPPDBKHEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA660", Offset = "0x5FB9060", VA = "0x185FBA660")]
	internal EPJBHDONMPE EFBNIJEGAFN(MACNEJPCNMD MHHKMBCPLLA)
	{
		return default(EPJBHDONMPE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAF80", Offset = "0x5FB9980", VA = "0x185FBAF80")]
	internal void GMAFADNIJLD(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC020", Offset = "0x5FBAA20", VA = "0x185FBC020")]
	private void LJJAPIBLHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAD80", Offset = "0x5FB9780", VA = "0x185FBAD80")]
	internal void GHHPJJDBDHI(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9B40", Offset = "0x5FB8540", VA = "0x185FB9B40")]
	internal void DBMELBLEALE(int OMPPDBKHEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBBBD0", Offset = "0x5FBA5D0", VA = "0x185FBBBD0")]
	internal void ILEJDHBPIPM(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class ADFKJGBAFLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long CDKJBMOFHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long DBFFBPCBMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long KOHHMDOKNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long JHLLKFPNELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long DKDPGCCILFC;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long BPJIEEGPDDP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long LJOKOEKPJKF;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long JKBJCDGICLG;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long APABEBEANPK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long KOBOALICACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long JNHGDDJFAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long KBLGADBNIHF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long OGLILJPFAPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCD00", Offset = "0x5FBB700", VA = "0x185FBCD00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KMLGIHMNHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCA80", Offset = "0x5FBB480", VA = "0x185FBCA80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long GMEEHKDDLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCD70", Offset = "0x5FBB770", VA = "0x185FBCD70")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long DNLLPPCLGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC9D0", Offset = "0x5FBB3D0", VA = "0x185FBC9D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long AMMGMIOADME
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCB80", Offset = "0x5FBB580", VA = "0x185FBCB80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long NFMAPFBFAAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCDE0", Offset = "0x5FBB7E0", VA = "0x185FBCDE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long BKMBDDDHOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCC00", Offset = "0x5FBB600", VA = "0x185FBCC00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long BJCLPNGGPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCDF0", Offset = "0x5FBB7F0", VA = "0x185FBCDF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private DEKHJILJAJN IBFIMHOJFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCE30", Offset = "0x5FBB830", VA = "0x185FBCE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double BAHBJDEFNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCCA0", Offset = "0x5FBB6A0", VA = "0x185FBCCA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCA40", Offset = "0x5FBB440", VA = "0x185FBCA40")]
	public void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCC40", Offset = "0x5FBB640", VA = "0x185FBCC40")]
	public void GKNIKIEKFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCA90", Offset = "0x5FBB490", VA = "0x185FBCA90")]
	public void DPCBKDCPIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FBC9E0", Offset = "0x5FBB3E0", VA = "0x185FBC9E0")]
	public void BPGFBGEHHDG(long OFHGNEPHJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCD80", Offset = "0x5FBB780", VA = "0x185FBCD80")]
	public void OFCEJAMFIEG(long MHNKCHAFFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCD10", Offset = "0x5FBB710", VA = "0x185FBCD10")]
	public void NFCKBFIGBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCB90", Offset = "0x5FBB590", VA = "0x185FBCB90")]
	public void FJGHLGGKMAI(long AOGAGENNADO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCE40", Offset = "0x5FBB840", VA = "0x185FBCE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FBCAE0", Offset = "0x5FBB4E0", VA = "0x185FBCAE0")]
	public void FCBLHKBKKND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public ADFKJGBAFLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class LDKECNDOMOB
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> AFAAGBIANJE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2D70", Offset = "0x5FC1770", VA = "0x185FC2D70")]
	public static IPEndPoint GOPBNBCMBPE(string FCFBIJPOMOJ, int BPMKLCLFPCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2FC0", Offset = "0x5FC19C0", VA = "0x185FC2FC0")]
	public static IPAddress LPBMONADCLN(string FCFBIJPOMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3190", Offset = "0x5FC1B90", VA = "0x185FC3190")]
	public static IPAddress LPBMONADCLN(string FCFBIJPOMOJ, AddressFamily CJMLOFAEPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2D40", Offset = "0x5FC1740", VA = "0x185FC2D40")]
	internal static int FLCCDDEJMAG(int FAACKCPGGCB, int HKKCAEPFEJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A060", Offset = "0x2D38A60", VA = "0x182D3A060")]
	internal static T[] NOPBAHFDHLN<T>(int KFBJHPBJLOG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MCNFLCMGGHD : FHALJNDDJPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KHIOBIFDHPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private LMCHJGOIFKM GNFOAAKLLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long BGOAIHHBAJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool ELHAEGDJHPN;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2CA0", Offset = "0x5FC16A0", VA = "0x185FC2CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2BC0", Offset = "0x5FC15C0", VA = "0x185FC2BC0")]
		public void FKBEJNBPEHL(LMCHJGOIFKM GBLEPNNFAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2C30", Offset = "0x5FC1630", VA = "0x185FC2C30")]
		public bool LKCNELFACMF(long LAHCFAEJOJB, ABFGCNDJPEP PPHBKLNICMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2BE0", Offset = "0x5FC15E0", VA = "0x185FC2BE0")]
		public bool IMAFILHGCCD(ABFGCNDJPEP PPHBKLNICMK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly LMCHJGOIFKM JKMACIDFIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly KHIOBIFDHPK[] GCIBMDOKGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly LMCHJGOIFKM[] PPFMBCLMENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] LCLOLAKFDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int LKCGGKKAPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int FCAKFGNNOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int PBOHKNPCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int GGFBFEFBONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool BFOKDKOIHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly EJCMDCNEDCE NCIEFFOFJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool APHLGIGBMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int IMOOLMBHIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte ELCDEMAKAFK;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6DB0", Offset = "0x5FC57B0", VA = "0x185FC6DB0")]
	public MCNFLCMGGHD(ABFGCNDJPEP PPHBKLNICMK, bool HAPBGBKIEFC, byte KFBALBFDDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FC63B0", Offset = "0x5FC4DB0", VA = "0x185FC63B0")]
	private void DIBBOFOEHFK(LMCHJGOIFKM GBLEPNNFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FC5F00", Offset = "0x5FC4900", VA = "0x185FC5F00", Slot = "4")]
	protected override bool BAONNMMFOGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FC6750", Offset = "0x5FC5150", VA = "0x185FC6750", Slot = "5")]
	public override bool GMAFADNIJLD(LMCHJGOIFKM GBLEPNNFAOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KADNEOKOMIE : FHALJNDDJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int MHMJNCPNFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort FCAKFGNNOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool IPNJEAHHBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private LMCHJGOIFKM IHJFFIOPNKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly LMCHJGOIFKM DMMJGBDJHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool LMJBNBMAOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte ELCDEMAKAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long HMIAIPNDDLG;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2A60", Offset = "0x5FC1460", VA = "0x185FC2A60")]
	public KADNEOKOMIE(ABFGCNDJPEP PPHBKLNICMK, bool PMCNAGMAFFG, byte KFBALBFDDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5FC22C0", Offset = "0x5FC0CC0", VA = "0x185FC22C0", Slot = "4")]
	protected override bool BAONNMMFOGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2780", Offset = "0x5FC1180", VA = "0x185FC2780", Slot = "5")]
	public override bool GMAFADNIJLD(LMCHJGOIFKM GBLEPNNFAOP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BKEOGFGKNGD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct OIFNFAALEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong CJOBMGJIHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double EKLHDLFEOBJ;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct LKFHCKHFFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int HIOBLJINADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float KMKNPFPIMKK;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5FB81F0", Offset = "0x5FB6BF0", VA = "0x185FB81F0")]
	private static void FKKNBIDAOPE(byte[] NONPGPMAOEG, int ELDAPMPELBH, ulong OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD450", Offset = "0x5FBBE50", VA = "0x185FBD450")]
	private static void FKKNBIDAOPE(byte[] NONPGPMAOEG, int ELDAPMPELBH, int OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD4C0", Offset = "0x5FBBEC0", VA = "0x185FBD4C0")]
	public static void FKKNBIDAOPE(byte[] NONPGPMAOEG, int ELDAPMPELBH, short OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD500", Offset = "0x5FBBF00", VA = "0x185FBD500")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, double CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD530", Offset = "0x5FBBF30", VA = "0x185FBD530")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD4C0", Offset = "0x5FBBEC0", VA = "0x185FBD4C0")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, short CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD4C0", Offset = "0x5FBBEC0", VA = "0x185FBD4C0")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, ushort CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD450", Offset = "0x5FBBE50", VA = "0x185FBD450")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD450", Offset = "0x5FBBE50", VA = "0x185FBD450")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, uint CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD520", Offset = "0x5FBBF20", VA = "0x185FBD520")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, long CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD520", Offset = "0x5FBBF20", VA = "0x185FBD520")]
	public static void HMCJKOCONFH(byte[] OPJILLDCBJI, int GLCOHEPGOCK, ulong CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class EFCFMPLJLCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] LHPOENJKDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int FCNOKIPPLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int DIIABMBPADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int DMFBMOKJKDK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] AFEIDHGGEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int FKECFPCBEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F18F0", VA = "0x1808F2EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BOLGNCCEMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF2C0", Offset = "0x5FBDCC0", VA = "0x185FBF2C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LEAAIIMOCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FB49F0", Offset = "0x1FB33F0", VA = "0x181FB49F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int ECFKKDGDJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF1C0", Offset = "0x5FBDBC0", VA = "0x185FBF1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF180", Offset = "0x5FBDB80", VA = "0x185FBF180")]
	public void DPHDBKOGFFE(byte[] NHGOKBHHHPE, int ELDAPMPELBH, int DJBMENLLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public EFCFMPLJLCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF690", Offset = "0x5FBE090", VA = "0x185FBF690")]
	public EFCFMPLJLCB(byte[] NHGOKBHHHPE, int ELDAPMPELBH, int DJBMENLLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF3A0", Offset = "0x5FBDDA0", VA = "0x185FBF3A0")]
	public IPEndPoint KDKLPKLAEHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEF20", Offset = "0x5FBD920", VA = "0x185FBEF20")]
	public byte CDMFBNFCOMF()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEF20", Offset = "0x5FBD920", VA = "0x185FBEF20")]
	public sbyte PBMPDMPALHK()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B21EE0", Offset = "0x2B208E0", VA = "0x182B21EE0")]
	public T[] GBPDPGALNKD<T>(ushort MPLHLKNKHIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF0D0", Offset = "0x5FBDAD0", VA = "0x185FBF0D0")]
	public bool[] CONAHAOCKHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF210", Offset = "0x5FBDC10", VA = "0x185FBF210")]
	public ushort[] HCFGJKKHEEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF5E0", Offset = "0x5FBDFE0", VA = "0x185FBF5E0")]
	public short[] OHAHLAAOOEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF1D0", Offset = "0x5FBDBD0", VA = "0x185FBF1D0")]
	public int[] GHCIHIMEDOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF5A0", Offset = "0x5FBDFA0", VA = "0x185FBF5A0")]
	public uint[] OGIKFLHNFED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF470", Offset = "0x5FBDE70", VA = "0x185FBF470")]
	public float[] LDJJOOJDBKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEB20", Offset = "0x5FBD520", VA = "0x185FBEB20")]
	public double[] AKHIPICEDPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF090", Offset = "0x5FBDA90", VA = "0x185FBF090")]
	public long[] COKLAKPNEJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF560", Offset = "0x5FBDF60", VA = "0x185FBF560")]
	public ulong[] NKPFJPAKNBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEF60", Offset = "0x5FBD960", VA = "0x185FBEF60")]
	public string[] CKDAHBHDIFF(int KODPLDJMNGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF520", Offset = "0x5FBDF20", VA = "0x185FBF520")]
	public bool MOEOKJCEOBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF110", Offset = "0x5FBDB10", VA = "0x185FBF110")]
	public char HDBJPIKJBJJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF110", Offset = "0x5FBDB10", VA = "0x185FBF110")]
	public ushort DFBKPINAJEN()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF2D0", Offset = "0x5FBDCD0", VA = "0x185FBF2D0")]
	public short IGNIJADOHKE()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF4B0", Offset = "0x5FBDEB0", VA = "0x185FBF4B0")]
	public long LIDKPNAEAPO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF620", Offset = "0x5FBE020", VA = "0x185FBF620")]
	public ulong PGNFACCGNCK()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF250", Offset = "0x5FBDC50", VA = "0x185FBF250")]
	public int HOMFCFMDDGC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEAB0", Offset = "0x5FBD4B0", VA = "0x185FBEAB0")]
	public uint AJDHCEGHBED()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEE40", Offset = "0x5FBD840", VA = "0x185FBEE40")]
	public float CCNPPNAFLDE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5FBED90", Offset = "0x5FBD790", VA = "0x185FBED90")]
	public double BICJOCBBKNJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEB60", Offset = "0x5FBD560", VA = "0x185FBEB60")]
	public string BDGAIPHGANK(int CPJHHMNPCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEEB0", Offset = "0x5FBD8B0", VA = "0x185FBEEB0")]
	public ArraySegment<byte> CCOKKFONIOM(int KFBJHPBJLOG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF360", Offset = "0x5FBDD60", VA = "0x185FBF360")]
	public sbyte[] JHOEEMGANPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEE00", Offset = "0x5FBD800", VA = "0x185FBEE00")]
	public byte[] CCEHNAMEOLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF340", Offset = "0x5FBDD40", VA = "0x185FBF340")]
	public void IMAFILHGCCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class HNJDBLMAIOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] LHPOENJKDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int FCNOKIPPLGM;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int OMKJKJNLKFI = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool EPGOPFKMGLH;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding KMCFKDPMAEI;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int PIBCOANEOND = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] PCGEGBGODBD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] CNPFJDANIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int PKLCBMGOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1B30", Offset = "0x5FC0530", VA = "0x185FC1B30")]
	public HNJDBLMAIOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1A90", Offset = "0x5FC0490", VA = "0x185FC1A90")]
	public HNJDBLMAIOH(bool PEALLELJHHN, int MMOJCNFHBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC12A0", Offset = "0x5FBFCA0", VA = "0x185FC12A0")]
	public static HNJDBLMAIOH IDBILFGGJLL(string CLMKDBDPNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1970", Offset = "0x5FC0370", VA = "0x185FC1970")]
	public void ODICEJGBIBG(int FPICHGAHGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x202E0F0", Offset = "0x202CAF0", VA = "0x18202E0F0")]
	public void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC18D0", Offset = "0x5FC02D0", VA = "0x185FC18D0")]
	public void LFBGABEMKIL(float CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1720", Offset = "0x5FC0120", VA = "0x185FC1720")]
	public void LFBGABEMKIL(double CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5FC16D0", Offset = "0x5FC00D0", VA = "0x185FC16D0")]
	public void LFBGABEMKIL(long CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5FC16D0", Offset = "0x5FC00D0", VA = "0x185FC16D0")]
	public void LFBGABEMKIL(ulong CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1770", Offset = "0x5FC0170", VA = "0x185FC1770")]
	public void LFBGABEMKIL(int CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1770", Offset = "0x5FC0170", VA = "0x185FC1770")]
	public void LFBGABEMKIL(uint CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1450", Offset = "0x5FBFE50", VA = "0x185FC1450")]
	public void LFBGABEMKIL(char CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1450", Offset = "0x5FBFE50", VA = "0x185FC1450")]
	public void LFBGABEMKIL(ushort CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1450", Offset = "0x5FBFE50", VA = "0x185FC1450")]
	public void LFBGABEMKIL(short CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1370", Offset = "0x5FBFD70", VA = "0x185FC1370")]
	public void LFBGABEMKIL(sbyte CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1370", Offset = "0x5FBFD70", VA = "0x185FC1370")]
	public void LFBGABEMKIL(byte CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5FC13E0", Offset = "0x5FBFDE0", VA = "0x185FC13E0")]
	public void LFBGABEMKIL(byte[] OIGMDCDEKEG, int ELDAPMPELBH, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D70", Offset = "0x5FBF770", VA = "0x185FC0D70")]
	public void AKJNCNNHHIG(sbyte[] OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D70", Offset = "0x5FBF770", VA = "0x185FC0D70")]
	public void PCEDMBECFMK(byte[] OIGMDCDEKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1310", Offset = "0x5FBFD10", VA = "0x185FC1310")]
	public void LFBGABEMKIL(bool CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1010", Offset = "0x5FBFA10", VA = "0x185FC1010")]
	public void CDNJINIHCPP(Array MKJFHCKPCFP, int BPEAFHOONIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0E50", Offset = "0x5FBF850", VA = "0x185FC0E50")]
	public void CDNJINIHCPP(float[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0F30", Offset = "0x5FBF930", VA = "0x185FC0F30")]
	public void CDNJINIHCPP(double[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0F30", Offset = "0x5FBF930", VA = "0x185FC0F30")]
	public void CDNJINIHCPP(long[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0F30", Offset = "0x5FBF930", VA = "0x185FC0F30")]
	public void CDNJINIHCPP(ulong[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0E50", Offset = "0x5FBF850", VA = "0x185FC0E50")]
	public void CDNJINIHCPP(int[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0E50", Offset = "0x5FBF850", VA = "0x185FC0E50")]
	public void CDNJINIHCPP(uint[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5FC10F0", Offset = "0x5FBFAF0", VA = "0x185FC10F0")]
	public void CDNJINIHCPP(ushort[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5FC10F0", Offset = "0x5FBFAF0", VA = "0x185FC10F0")]
	public void CDNJINIHCPP(short[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D70", Offset = "0x5FBF770", VA = "0x185FC0D70")]
	public void CDNJINIHCPP(bool[] CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5FC11D0", Offset = "0x5FBFBD0", VA = "0x185FC11D0")]
	public void CDNJINIHCPP(string[] CLMKDBDPNNH, int IMJKLAMIJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1800", Offset = "0x5FC0200", VA = "0x185FC1800")]
	public void LFBGABEMKIL(IPEndPoint DOMJEACIBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5FC13D0", Offset = "0x5FBFDD0", VA = "0x185FC13D0")]
	public void LFBGABEMKIL(string CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC14C0", Offset = "0x5FBFEC0", VA = "0x185FC14C0")]
	public void LFBGABEMKIL(string CLMKDBDPNNH, int CPJHHMNPCPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class JDHEHEIAFBA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class OLEAMOBECNK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong KLCNCHBCNCJ;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4845380", Offset = "0x4843D80", VA = "0x184845380")]
		static OLEAMOBECNK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void BFKLGJLCAEM(EFCFMPLJLCB PHJKOICFNBE, object OINGFEKIDHI);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class GHJKGDFAJLA<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public JDHEHEIAFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public GHJKGDFAJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E24B70", Offset = "0x3E23570", VA = "0x183E24B70")]
		internal void KLFPLLGKKIK(EFCFMPLJLCB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class KHMENHDGPPP<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JDHEHEIAFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public KHMENHDGPPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x43496B0", Offset = "0x43480B0", VA = "0x1843496B0")]
		internal void KLFPLLGKKIK(EFCFMPLJLCB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly LDNIKLHIMNN GHGDNDFOGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, BFKLGJLCAEM> HHEINEOIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly HNJDBLMAIOH DABCAAGDPED;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2140", Offset = "0x5FC0B40", VA = "0x185FC2140")]
	public JDHEHEIAFBA(int KODPLDJMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A16890", Offset = "0x2A15290", VA = "0x182A16890", Slot = "4")]
	protected virtual ulong CGMEANJKANE<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1FC0", Offset = "0x5FC09C0", VA = "0x185FC1FC0", Slot = "5")]
	protected virtual BFKLGJLCAEM EMAGBPLKFOL(EFCFMPLJLCB PHJKOICFNBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7B00", Offset = "0x2CF6500", VA = "0x182CF7B00", Slot = "6")]
	protected virtual void CCJDGHOCFBL<T>(HNJDBLMAIOH GMONMLMLDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1F40", Offset = "0x5FC0940", VA = "0x185FC1F40")]
	public void BONHBCACNEH(EFCFMPLJLCB PHJKOICFNBE, object OINGFEKIDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7EF0", Offset = "0x2CF68F0", VA = "0x182CF7EF0")]
	public void GKMCPGCJPIC<T>(HNJDBLMAIOH GMONMLMLDAL, T GBLEPNNFAOP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5FC20F0", Offset = "0x5FC0AF0", VA = "0x185FC20F0")]
	public void KFIOAOOEHMO(EFCFMPLJLCB PHJKOICFNBE, object OINGFEKIDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7D30", Offset = "0x2CF6730", VA = "0x182CF7D30")]
	public void ECEFCAMOGKC<T>(Action<T> DACCLPFJAFP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7B70", Offset = "0x2CF6570", VA = "0x182CF7B70")]
	public void ECEFCAMOGKC<T, TUserData>(Action<T, TUserData> DACCLPFJAFP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HBGFHFCGAAE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D60", Offset = "0x5FBF760", VA = "0x185FC0D60")]
	public HBGFHFCGAAE(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FHGGDLGJPBJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC00B0", Offset = "0x5FBEAB0", VA = "0x185FC00B0")]
	public FHGGDLGJPBJ(string MEBLNPKEJMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class LDNIKLHIMNN
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum MJMHIKNKIEE
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class IJLDAMFGCBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public MJMHIKNKIEE HMGDADDECHP;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x401A280", Offset = "0x4018C80", VA = "0x18401A280", Slot = "4")]
		public virtual void FKBEJNBPEHL(MethodInfo EABKLCNLCMN, MethodInfo BFBOINJBBFP, MJMHIKNKIEE NNCMOPPBEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void CKONBGMNDBE(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void DFJIAHNOAKD(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		protected IJLDAMFGCBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class LGOJFKINPEJ<TClass, TProperty> : IJLDAMFGCBA<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> JCAFFEMACAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> LEDNBNJLJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> FDJDJJHKBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> CCMBDIIOPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> OKNAGPEDPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> EDLLPJBOAMC;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x442AE10", Offset = "0x4429810", VA = "0x18442AE10", Slot = "7")]
		public override void MBPAEKKOKBO(TClass CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x442A010", Offset = "0x4428A10", VA = "0x18442A010", Slot = "8")]
		public override void GFNKLOCNAHF(TClass CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4423D10", Offset = "0x4422710", VA = "0x184423D10", Slot = "9")]
		public override void CKONBGMNDBE(TClass CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4424330", Offset = "0x4422D30", VA = "0x184424330", Slot = "10")]
		public override void DFJIAHNOAKD(TClass CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4424CD0", Offset = "0x44236D0", VA = "0x184424CD0")]
		protected TProperty[] DOOEPDPGLLA(TClass CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4424DE0", Offset = "0x44237E0", VA = "0x184424DE0")]
		protected TProperty[] EDAODFACODF(TClass CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4429420", Offset = "0x4427E20", VA = "0x184429420", Slot = "4")]
		public override void FKBEJNBPEHL(MethodInfo EABKLCNLCMN, MethodInfo BFBOINJBBFP, MJMHIKNKIEE NNCMOPPBEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3E5DA90", Offset = "0x3E5C490", VA = "0x183E5DA90")]
		protected LGOJFKINPEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class IGDPPAKHIML<TClass, TProperty> : LGOJFKINPEJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void LCNOHBFOEAL(EFCFMPLJLCB FJIOIPCNGKD, [Out] TProperty BNJJMDJPNPP);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void EFEHCJCPOPG(HNJDBLMAIOH MNEICOIJGBO, TProperty BNJJMDJPNPP);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x400B160", Offset = "0x4009B60", VA = "0x18400B160", Slot = "5")]
		public override void CLFIJFEJJHJ(TClass CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x400B4B0", Offset = "0x4009EB0", VA = "0x18400B4B0", Slot = "6")]
		public override void GKMCPGCJPIC(TClass CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x400B540", Offset = "0x4009F40", VA = "0x18400B540", Slot = "7")]
		public override void MBPAEKKOKBO(TClass CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x400B2A0", Offset = "0x4009CA0", VA = "0x18400B2A0", Slot = "8")]
		public override void GFNKLOCNAHF(TClass CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BCF0", Offset = "0x3D4A6F0", VA = "0x183D4BCF0")]
		protected IGDPPAKHIML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class FGMIAOANLDI<T> : LGOJFKINPEJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BD30", Offset = "0x3D4A730", VA = "0x183D4BD30", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x396B510", Offset = "0x3969F10", VA = "0x18396B510", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4BDB0", Offset = "0x3D4A7B0", VA = "0x183D4BDB0", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x396B4A0", Offset = "0x3969EA0", VA = "0x18396B4A0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public FGMIAOANLDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class EHFKBIJNCGM<T> : LGOJFKINPEJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x396B420", Offset = "0x3969E20", VA = "0x18396B420", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x396B510", Offset = "0x3969F10", VA = "0x18396B510", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x396B580", Offset = "0x3969F80", VA = "0x18396B580", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x396B4A0", Offset = "0x3969EA0", VA = "0x18396B4A0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public EHFKBIJNCGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class JGOPJDEGKPA<T> : LGOJFKINPEJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4212010", Offset = "0x4210A10", VA = "0x184212010", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4212100", Offset = "0x4210B00", VA = "0x184212100", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x4212170", Offset = "0x4210B70", VA = "0x184212170", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4212090", Offset = "0x4210A90", VA = "0x184212090", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public JGOPJDEGKPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class DLJICNKDEOF<T> : LGOJFKINPEJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5A74D10", Offset = "0x5A73710", VA = "0x185A74D10", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4212100", Offset = "0x4210B00", VA = "0x184212100", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5A74D90", Offset = "0x5A73790", VA = "0x185A74D90", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4212090", Offset = "0x4210A90", VA = "0x184212090", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public DLJICNKDEOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class LFGNCKLJDJF<T> : LGOJFKINPEJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x44216B0", Offset = "0x44200B0", VA = "0x1844216B0", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC90", Offset = "0x3D2D690", VA = "0x183D2EC90", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4421730", Offset = "0x4420130", VA = "0x184421730", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC20", Offset = "0x3D2D620", VA = "0x183D2EC20", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public LFGNCKLJDJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FCFDOGOJDLJ<T> : LGOJFKINPEJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EBA0", Offset = "0x3D2D5A0", VA = "0x183D2EBA0", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC90", Offset = "0x3D2D690", VA = "0x183D2EC90", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2ED00", Offset = "0x3D2D700", VA = "0x183D2ED00", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC20", Offset = "0x3D2D620", VA = "0x183D2EC20", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public FCFDOGOJDLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class NHEGKHDNPDH<T> : LGOJFKINPEJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x46AEF30", Offset = "0x46AD930", VA = "0x1846AEF30", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x46AF020", Offset = "0x46ADA20", VA = "0x1846AF020", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x46AF090", Offset = "0x46ADA90", VA = "0x1846AF090", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x46AEFB0", Offset = "0x46AD9B0", VA = "0x1846AEFB0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public NHEGKHDNPDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class COPIMOONCNH<T> : LGOJFKINPEJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x46AEF30", Offset = "0x46AD930", VA = "0x1846AEF30", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x46AF020", Offset = "0x46ADA20", VA = "0x1846AF020", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x561F0D0", Offset = "0x561DAD0", VA = "0x18561F0D0", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x46AEFB0", Offset = "0x46AD9B0", VA = "0x1846AEFB0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public COPIMOONCNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class CGDKACLMMHC<T> : LGOJFKINPEJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5437350", Offset = "0x5435D50", VA = "0x185437350", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x54373D0", Offset = "0x5435DD0", VA = "0x1854373D0", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5437440", Offset = "0x5435E40", VA = "0x185437440", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x396B4A0", Offset = "0x3969EA0", VA = "0x18396B4A0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public CGDKACLMMHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DKEFEFFOOEM<T> : LGOJFKINPEJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5A69440", Offset = "0x5A67E40", VA = "0x185A69440", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A694C0", Offset = "0x5A67EC0", VA = "0x185A694C0", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5A69530", Offset = "0x5A67F30", VA = "0x185A69530", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EC20", Offset = "0x3D2D620", VA = "0x183D2EC20", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public DKEFEFFOOEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class BAPNMOEEHOL<T> : LGOJFKINPEJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6DB0", Offset = "0x4FF57B0", VA = "0x184FF6DB0", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6E30", Offset = "0x4FF5830", VA = "0x184FF6E30", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4FF6EA0", Offset = "0x4FF58A0", VA = "0x184FF6EA0", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x46AEFB0", Offset = "0x46AD9B0", VA = "0x1846AEFB0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x396B600", Offset = "0x396A000", VA = "0x18396B600")]
		public BAPNMOEEHOL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class FBAIKPPCGCB<T> : IGDPPAKHIML<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D18E80", Offset = "0x3D17880", VA = "0x183D18E80", Slot = "12")]
		protected override void EFEHCJCPOPG(HNJDBLMAIOH MNEICOIJGBO, char BNJJMDJPNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D18EB0", Offset = "0x3D178B0", VA = "0x183D18EB0", Slot = "11")]
		protected override void LCNOHBFOEAL(EFCFMPLJLCB FJIOIPCNGKD, [Out] char BNJJMDJPNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D18EE0", Offset = "0x3D178E0", VA = "0x183D18EE0")]
		public FBAIKPPCGCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class ABBJNDDAFOK<T> : IGDPPAKHIML<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB9D0", Offset = "0x3DBA3D0", VA = "0x183DBB9D0", Slot = "12")]
		protected override void EFEHCJCPOPG(HNJDBLMAIOH MNEICOIJGBO, IPEndPoint BNJJMDJPNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DBBA00", Offset = "0x3DBA400", VA = "0x183DBBA00", Slot = "11")]
		protected override void LCNOHBFOEAL(EFCFMPLJLCB FJIOIPCNGKD, [Out] IPEndPoint BNJJMDJPNPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D18EE0", Offset = "0x3D178E0", VA = "0x183D18EE0")]
		public ABBJNDDAFOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CDLKEBAKBBF<T> : LGOJFKINPEJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int MJPGADPHBNJ;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5325930", Offset = "0x5324330", VA = "0x185325930")]
		public CDLKEBAKBBF(int CPJHHMNPCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5325730", Offset = "0x5324130", VA = "0x185325730", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5325830", Offset = "0x5324230", VA = "0x185325830", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x53258B0", Offset = "0x53242B0", VA = "0x1853258B0", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x53257B0", Offset = "0x53241B0", VA = "0x1853257B0", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class AAJAFOMINJP<T> : IJLDAMFGCBA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo NBNLLFODCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type FCMPNPPKBMF;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA090", Offset = "0x3DB8A90", VA = "0x183DBA090")]
		public AAJAFOMINJP(PropertyInfo FMKCBFNEFEH, Type JHPGPGDJGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9E00", Offset = "0x3DB8800", VA = "0x183DB9E00", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9F80", Offset = "0x3DB8980", VA = "0x183DB9F80", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3DBA030", Offset = "0x3DB8A30", VA = "0x183DBA030", Slot = "7")]
		public override void MBPAEKKOKBO(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9F20", Offset = "0x3DB8920", VA = "0x183DB9F20", Slot = "8")]
		public override void GFNKLOCNAHF(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9DA0", Offset = "0x3DB87A0", VA = "0x183DB9DA0", Slot = "9")]
		public override void CKONBGMNDBE(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3DB9EC0", Offset = "0x3DB88C0", VA = "0x183DB9EC0", Slot = "10")]
		public override void DFJIAHNOAKD(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MECAGMNGHED<T> : AAJAFOMINJP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D69040", Offset = "0x3D67A40", VA = "0x183D69040")]
		public MECAGMNGHED(PropertyInfo FMKCBFNEFEH, Type JHPGPGDJGDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x460C7E0", Offset = "0x460B1E0", VA = "0x18460C7E0", Slot = "5")]
		public override void CLFIJFEJJHJ(T CLBBGPCGCGM, EFCFMPLJLCB FJIOIPCNGKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x460C8A0", Offset = "0x460B2A0", VA = "0x18460C8A0", Slot = "6")]
		public override void GKMCPGCJPIC(T CLBBGPCGCGM, HNJDBLMAIOH MNEICOIJGBO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class MDGBKMBCLFC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static MDGBKMBCLFC<T> LPENGNKGBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly IJLDAMFGCBA<T>[] GPFLBHPOEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int KLPENMHDFEN;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x460ABF0", Offset = "0x46095F0", VA = "0x18460ABF0")]
		public MDGBKMBCLFC(List<IJLDAMFGCBA<T>> CHJFNJAHBPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x460AB40", Offset = "0x4609540", VA = "0x18460AB40")]
		public void GKMCPGCJPIC(T GIGIFGONEAO, HNJDBLMAIOH GMONMLMLDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x460AA90", Offset = "0x4609490", VA = "0x18460AA90")]
		public void CLFIJFEJJHJ(T GIGIFGONEAO, EFCFMPLJLCB PHJKOICFNBE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class JKPENGLBFAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract IJLDAMFGCBA<T> PHNOCPFLPNG<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private HNJDBLMAIOH EKMECAJAEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int GEJFCMFNHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, JKPENGLBFAO> FEFBNOHAOPL;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC36A0", Offset = "0x5FC20A0", VA = "0x185FC36A0")]
	public LDNIKLHIMNN(int KODPLDJMNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A1C0", Offset = "0x2D38BC0", VA = "0x182D3A1C0")]
	private MDGBKMBCLFC<T> MOOMMFJDMDJ<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2A10520", Offset = "0x2A0EF20", VA = "0x182A10520")]
	public void HEDMFNKAECO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A090", Offset = "0x2D38A90", VA = "0x182D3A090")]
	public bool ILDFGHALABA<T>(EFCFMPLJLCB PHJKOICFNBE, T IPOCAIFIKHJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2D3A130", Offset = "0x2D38B30", VA = "0x182D3A130")]
	public void LKLOMDOAOHF<T>(HNJDBLMAIOH GMONMLMLDAL, T GIGIFGONEAO) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class DPAEPBPGKAN
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime DLMNGMAODFM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] DGBCKGKIAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HCOEJEDMHLJ CECEAPBGADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE300", Offset = "0x5FBCD00", VA = "0x185FBE300")]
		get
		{
			return default(HCOEJEDMHLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int APAKHLDCLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE330", Offset = "0x5FBCD30", VA = "0x185FBE330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE210", Offset = "0x5FBCC10", VA = "0x185FBE210")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public BJMHNEHIALK IMJGMMEIMOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD880", Offset = "0x5FBC280", VA = "0x185FBD880")]
		get
		{
			return default(BJMHNEHIALK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD8B0", Offset = "0x5FBC2B0", VA = "0x185FBD8B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int BJAFHFHJBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE1E0", Offset = "0x5FBCBE0", VA = "0x185FBE1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint PAIDIKCBDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE280", Offset = "0x5FBCC80", VA = "0x185FBE280")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? OBKKBOJMABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD850", Offset = "0x5FBC250", VA = "0x185FBD850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? JOLDKPDMKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5FBDB50", Offset = "0x5FBC550", VA = "0x185FBDB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? PBNIMGLOAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE250", Offset = "0x5FBCC50", VA = "0x185FBE250")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE010", Offset = "0x5FBCA10", VA = "0x185FBE010")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? KLOGBGIHFBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xDCD700", Offset = "0xDCC100", VA = "0x180DCD700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xC08B30", Offset = "0xC07530", VA = "0x180C08B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE6E0", Offset = "0x5FBD0E0", VA = "0x185FBE6E0")]
	public DPAEPBPGKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5FBEA00", Offset = "0x5FBD400", VA = "0x185FBEA00")]
	internal DPAEPBPGKAN(byte[] OPJILLDCBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE360", Offset = "0x5FBCD60", VA = "0x185FBE360")]
	public static DPAEPBPGKAN PKNNIKHJCCE(byte[] OPJILLDCBJI, DateTime GPCNJGCPFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FBE480", Offset = "0x5FBCE80", VA = "0x185FBE480")]
	internal void POAJAFAAOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDD80", Offset = "0x5FBC780", VA = "0x185FBDD80")]
	private void JGKDGOKMJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDB80", Offset = "0x5FBC580", VA = "0x185FBDB80")]
	private DateTime? IPBJNMECOLL(int ELDAPMPELBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD980", Offset = "0x5FBC380", VA = "0x185FBD980")]
	private void ELGPNAGKFCO(int ELDAPMPELBH, DateTime? CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD780", Offset = "0x5FBC180", VA = "0x185FBD780")]
	private ulong AILKDBFHKHK(int ELDAPMPELBH)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBDF50", Offset = "0x5FBC950", VA = "0x185FBDF50")]
	private void KNPLDAOCBJG(int ELDAPMPELBH, ulong CLMKDBDPNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD8F0", Offset = "0x5FBC2F0", VA = "0x185FBD8F0")]
	private uint ELEANMIICAN(int ELDAPMPELBH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D3A0", Offset = "0x5E8BDA0", VA = "0x185E8D3A0")]
	private static uint ACPDMGGAJEJ(uint ICJCFEHCALD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD720", Offset = "0x5FBC120", VA = "0x185FBD720")]
	private static ulong ACPDMGGAJEJ(ulong ICJCFEHCALD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HCOEJEDMHLJ
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
public enum BJMHNEHIALK
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class CNIFIOIKONC
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int LFELICOEFEI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int AKCLAJCBAKJ = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int KAPNJJENFOM = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint KEMNFCPKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int BINJMEHOKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int GCHBGKOGHOO;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool LCEPLMJEJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5FBD710", Offset = "0x5FBC110", VA = "0x185FBD710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD620", Offset = "0x5FBC020", VA = "0x185FBD620")]
	public bool BHGFHDJPEPF(NFMHABAANPG COJNMKAFAAD, int MNHDOCAHHMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class OBGCBKDDAMC : NFMHABAANPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket COJNMKAFAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly MOGAHGDHPMB EOAGLOFOJBE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short OPCEJNBDJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF2E0", Offset = "0x5FCDCE0", VA = "0x185FCF2E0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int HDMFLFNKFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5FCEBD0", Offset = "0x5FCD5D0", VA = "0x185FCEBD0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint FOIBDDINBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF1D0", Offset = "0x5FCDBD0", VA = "0x185FCF1D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily BMCNJDBCMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x44018F0", Offset = "0x44002F0", VA = "0x1844018F0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF340", Offset = "0x5FCDD40", VA = "0x185FCF340")]
	public OBGCBKDDAMC(AddressFamily CJMLOFAEPLN, MOGAHGDHPMB EOAGLOFOJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEC10", Offset = "0x5FCD610", VA = "0x185FCEC10", Slot = "8")]
	public bool KGAMFBJBODH(IPEndPoint DOMJEACIBAG, BIGBFEGLKHH NEDCOABCDOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF300", Offset = "0x5FCDD00", VA = "0x185FCF300", Slot = "9")]
	public int PKKKFGHNMLH(byte[] NONPGPMAOEG, int ELDAPMPELBH, int MPLHLKNKHIM, IPEndPoint PPNKOEFPOCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF1F0", Offset = "0x5FCDBF0", VA = "0x185FCF1F0", Slot = "10")]
	public int LKLNBMMDNDF(byte[] NONPGPMAOEG, EndPoint ONBENIBILOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5FCEBF0", Offset = "0x5FCD5F0", VA = "0x185FCEBF0", Slot = "11")]
	public void KALLFFFGNFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface NFMHABAANPG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short OPCEJNBDJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int HDMFLFNKFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint FOIBDDINBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily BMCNJDBCMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KGAMFBJBODH(IPEndPoint DOMJEACIBAG, BIGBFEGLKHH NEDCOABCDOE);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int PKKKFGHNMLH(byte[] NONPGPMAOEG, int ELDAPMPELBH, int MPLHLKNKHIM, IPEndPoint PPNKOEFPOCO);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int LKLNBMMDNDF(byte[] NONPGPMAOEG, EndPoint PPNKOEFPOCO);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KALLFFFGNFP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct BCKFCGMAAFJ : IEquatable<BCKFCGMAAFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long JFOGFGEKPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long NDPBKMMJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long OMNIBOEOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int KOPJGBBENKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int BAKEKOJDHIF;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD290", Offset = "0x5FBBC90", VA = "0x185FBD290")]
	public BCKFCGMAAFJ(byte[] CALGHEJMIMF, int BEDFCENHDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8AC930", Offset = "0x8AB330", VA = "0x1808AC930", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD250", Offset = "0x5FBBC50", VA = "0x185FBD250", Slot = "4")]
	public bool Equals(BCKFCGMAAFJ AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBD1A0", Offset = "0x5FBBBA0", VA = "0x185FBD1A0", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class DKHGICDCMIN : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] DBBFNJOODOP;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class BPHNLNKDKFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int MEBBIKOAJLN;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
	protected BPHNLNKDKFN(int LFAMNLNLGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void FNDLMBBNDAM(IPEndPoint DOMJEACIBAG, byte[] OIGMDCDEKEG, int ELDAPMPELBH, int OMBKDMFPMFJ);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AJDHHKFGBKE(IPEndPoint DOMJEACIBAG, byte[] OIGMDCDEKEG, int ELDAPMPELBH, int OMBKDMFPMFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GOECGOOEBGH : BPHNLNKDKFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] JODEIIFHAPK;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator DALLJPADGEM;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x20D3890", Offset = "0x20D2290", VA = "0x1820D3890")]
	public GOECGOOEBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0B60", Offset = "0x5FBF560", VA = "0x185FC0B60")]
	public void HFGMJJKFNOM(IPEndPoint DOMJEACIBAG, byte[] JODEIIFHAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5FC05D0", Offset = "0x5FBEFD0", VA = "0x185FC05D0")]
	public void BFJOIBFMHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5FC06B0", Offset = "0x5FBF0B0", VA = "0x185FC06B0", Slot = "4")]
	public override void FNDLMBBNDAM(IPEndPoint DOMJEACIBAG, byte[] OIGMDCDEKEG, int ELDAPMPELBH, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0270", Offset = "0x5FBEC70", VA = "0x185FC0270", Slot = "5")]
	public override void AJDHHKFGBKE(IPEndPoint DOMJEACIBAG, byte[] OIGMDCDEKEG, int ELDAPMPELBH, int OMBKDMFPMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct FEDMKCJACOK
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void GLCAMJFAMBM([NoAlias] byte* NMJLMPAIHIP, [NoAlias] byte* JODEIIFHAPK, [NoAlias] byte* JIOJMPHEAGP, int OMBKDMFPMFJ);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class JGFHAIOBLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF850", Offset = "0x5FCE250", VA = "0x185FCF850")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF700", Offset = "0x5FCE100", VA = "0x185FCF700")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF660", Offset = "0x5FCE060", VA = "0x185FCF660")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5FCF970", Offset = "0x5FCE370", VA = "0x185FCF970")]
		public unsafe static void NPIHGHHDKCM([NoAlias] byte* NMJLMPAIHIP, [NoAlias] byte* JODEIIFHAPK, [NoAlias] byte* JIOJMPHEAGP, int OMBKDMFPMFJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint JODEIIFHAPK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint JIOJMPHEAGP[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint FECBMGCMGGE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint AMKODCEFBOD[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint HMCDBAAKOBL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint EEKHAIJIKOH[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint CHIBPNFGHDK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint BKCPCLMKCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint LKAMEPNIIMO[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF720", Offset = "0x5FBE120", VA = "0x185FBF720")]
	private void CGBFLDMMJFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF6F0", Offset = "0x5FBE0F0", VA = "0x185FBF6F0")]
	private uint BJPNKDHMGOM(uint OEHMKJHGMIJ, int JCNJJAFBFBL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5FB85F0", Offset = "0x5FB6FF0", VA = "0x185FB85F0")]
	private void OALFLPBHDDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5FB82E0", Offset = "0x5FB6CE0", VA = "0x185FB82E0")]
	private void EPDMAAGDNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5FB86A0", Offset = "0x5FB70A0", VA = "0x185FB86A0")]
	private void PNIBIBLJIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB84F0", Offset = "0x5FB6EF0", VA = "0x185FB84F0")]
	private void GFPOEAOHCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF7A0", Offset = "0x5FBE1A0", VA = "0x185FBF7A0")]
	private void CJDMDEMKPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF9D0", Offset = "0x5FBE3D0", VA = "0x185FBF9D0")]
	private unsafe void NJGIKIOONCE(byte* NMJLMPAIHIP, uint* JODEIIFHAPK, uint* JIOJMPHEAGP, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF800", Offset = "0x5FBE200", VA = "0x185FBF800")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DENIJFEBNCN([NoAlias] byte* NMJLMPAIHIP, [NoAlias] byte* JODEIIFHAPK, [NoAlias] byte* JIOJMPHEAGP, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF880", Offset = "0x5FBE280", VA = "0x185FBF880")]
	public static void DENIJFEBNCN(Span<byte> NMJLMPAIHIP, Span<byte> JODEIIFHAPK, Span<byte> JIOJMPHEAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFDF0", Offset = "0x5FBE7F0", VA = "0x185FBFDF0")]
	public static void PFELIMBDONG(Span<byte> NMJLMPAIHIP, Span<byte> JODEIIFHAPK, Span<byte> JIOJMPHEAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF960", Offset = "0x5FBE360", VA = "0x185FBF960")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void JHDBLNAOHDG([NoAlias] byte* NMJLMPAIHIP, [NoAlias] byte* JODEIIFHAPK, [NoAlias] byte* JIOJMPHEAGP, int OMBKDMFPMFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFBA0", Offset = "0x5FCE5A0", VA = "0x185FCFBA0")]
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
