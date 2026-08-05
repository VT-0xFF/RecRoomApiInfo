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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, MBKCAPHAMLC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum LONMNBINIFM
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
		private NetworkManager ANIGCKEIGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, JNFCHABMBAC> MNDJILFAEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BHIBDNBJMBL FMOJCHGPBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] BHFHALKFOJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LONMNBINIFM FONHEJLOJIB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong OBJCHCFALLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool ABBELJLPEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5585980", Offset = "0x5584780", VA = "0x185585980", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5584E80", Offset = "0x5583C80", VA = "0x185584E80")]
		public void RecRoom_SetEncryptionInfo(ulong OBBOCPJINAK, byte[] ONOECNHBCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5584E60", Offset = "0x5583C60", VA = "0x185584E60")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5584900", Offset = "0x5583700", VA = "0x185584900")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5585880", Offset = "0x5584680", VA = "0x185585880")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5585080", Offset = "0x5583E80", VA = "0x185585080", Slot = "6")]
		public override void Send(ulong IOPOPAOOEHC, ArraySegment<byte> EEDANCJJEPL, NetworkDelivery INBCBHBMCBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5584E20", Offset = "0x5583C20", VA = "0x185584E20", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong IOPOPAOOEHC, [Out] ArraySegment<byte> AOJMAAJAPBJ, [Out] float JHHLFBNBGEC)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5585370", Offset = "0x5584170", VA = "0x185585370", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x55857A0", Offset = "0x55845A0", VA = "0x1855857A0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x55842F0", Offset = "0x55830F0", VA = "0x1855842F0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong IOPOPAOOEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x55841A0", Offset = "0x5582FA0", VA = "0x1855841A0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x55844F0", Offset = "0x55832F0", VA = "0x1855844F0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong IOPOPAOOEHC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5585300", Offset = "0x5584100", VA = "0x185585300", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5584590", Offset = "0x5583390", VA = "0x185584590", Slot = "14")]
		public override void Initialize([Optional] NetworkManager ANIGCKEIGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5584830", Offset = "0x5583630", VA = "0x185584830")]
		private COIMFMFIEKL MBKJHDJFNGH(NetworkDelivery LPFFKBBBCBL)
		{
			return default(COIMFMFIEKL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5584750", Offset = "0x5583550", VA = "0x185584750", Slot = "15")]
		private void JFGGNLMFNHM(JNFCHABMBAC GPIEBCABDOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5584CE0", Offset = "0x5583AE0", VA = "0x185584CE0", Slot = "16")]
		private void PLICNKGOLMA(JNFCHABMBAC GPIEBCABDOC, IHJIKNIPGJJ DBJJCCPNPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "17")]
		private void DJKHPPHOPGM(IPEndPoint POJPPPJHBHP, SocketError KJDEEKOFLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x55849F0", Offset = "0x55837F0", VA = "0x1855849F0", Slot = "18")]
		private void PAPIJIBNECH(JNFCHABMBAC GPIEBCABDOC, MFDNIDDEJEH INLIFCPEGKK, byte NMNNPEOPCGM, COIMFMFIEKL JMIMAJGKIEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5584C00", Offset = "0x5583A00", VA = "0x185584C00")]
		private void PDKFAPKIGDK(int JEOEJJBKODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "19")]
		private void MDFJNJMJGJF(IPEndPoint LBNNPHHGIHO, MFDNIDDEJEH INLIFCPEGKK, OMPKMBINKIL OGCKEJOMMAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "20")]
		private void IEIEHKPMJHK(JNFCHABMBAC GPIEBCABDOC, int APKKJIDPAKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5584490", Offset = "0x5583290", VA = "0x185584490", Slot = "21")]
		private void GCBJGOGHELO(IMLGLFEAONH GFBEKCAHNCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5584460", Offset = "0x5583260", VA = "0x185584460")]
		private ulong FLLJLIPGDDD(JNFCHABMBAC GPIEBCABDOC)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5584810", Offset = "0x5583610", VA = "0x185584810")]
		private static int LGAOOGMJJAM(float CDIOCCAJDIA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x55858A0", Offset = "0x55846A0", VA = "0x1855858A0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class DADLIPMBJOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly JNFCHABMBAC BLPJCNGNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HMJANKKMJPF> DIBJHEGOEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int KDPOCGAHGDD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x557BC90", Offset = "0x557AA90", VA = "0x18557BC90")]
	protected DADLIPMBJOH(JNFCHABMBAC GPIEBCABDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x557BBF0", Offset = "0x557A9F0", VA = "0x18557BBF0")]
	public void KJFJIPHHEAB(HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x557BB70", Offset = "0x557A970", VA = "0x18557BB70")]
	protected void IOLAJPOEENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x557BC50", Offset = "0x557AA50", VA = "0x18557BC50")]
	public bool PPDNCAHJNBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CLMBPADHPNP();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AMKEHFMILKM(HMJANKKMJPF MACPKJCBJCP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum HNGCBBFJODA
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
public class IMLGLFEAONH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BHIBDNBJMBL CIPIPAHGFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int PANOGCLLFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MBDDIJBLDCH PKFEODLEMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint FGEGHNHNEAJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HNGCBBFJODA OFKKBMLMDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E17A0", Offset = "0x7E05A0", VA = "0x1807E17A0")]
		[CompilerGenerated]
		get
		{
			return default(HNGCBBFJODA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x91FB00", Offset = "0x91E900", VA = "0x18091FB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x557F300", Offset = "0x557E100", VA = "0x18557F300")]
	internal void IDPNBPLDFEG(MBDDIJBLDCH IICFKDNBFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x557F360", Offset = "0x557E160", VA = "0x18557F360")]
	private bool OMFEDELIMDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x557F390", Offset = "0x557E190", VA = "0x18557F390")]
	internal IMLGLFEAONH(IPEndPoint LBNNPHHGIHO, MBDDIJBLDCH KDELBBDFDPJ, BHIBDNBJMBL HOGKGMHKKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x557F2A0", Offset = "0x557E0A0", VA = "0x18557F2A0")]
	public JNFCHABMBAC HEBKMHOCBJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum OMPKMBINKIL
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum AHHFOJPBBME
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
public struct IHJIKNIPGJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public AHHFOJPBBME HFIDLJLPKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError GDJGKFAHGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public MFDNIDDEJEH LFPDINICPNO;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MBKCAPHAMLC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGOEPIPGLGP(JNFCHABMBAC GPIEBCABDOC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BHMICAPFPPL(JNFCHABMBAC GPIEBCABDOC, IHJIKNIPGJJ DBJJCCPNPAA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCIMHGPDBPA(IPEndPoint POJPPPJHBHP, SocketError KJDEEKOFLOM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DKDBGCEJBAK(JNFCHABMBAC GPIEBCABDOC, MFDNIDDEJEH INLIFCPEGKK, byte NMNNPEOPCGM, COIMFMFIEKL JMIMAJGKIEM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KFBPFPJGAGK(IPEndPoint LBNNPHHGIHO, MFDNIDDEJEH INLIFCPEGKK, OMPKMBINKIL OGCKEJOMMAB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLJBFBOFMGP(JNFCHABMBAC GPIEBCABDOC, int APKKJIDPAKP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PLGAANBEEGD(IMLGLFEAONH GFBEKCAHNCH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BNEMKPCHANE
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAOEFMOFLIN(JNFCHABMBAC GPIEBCABDOC, object BKOCPHDOGLF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CCNAEPKGKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFILKELIONN(BJDNKJJDNOE MACPKJCBJCP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MMJOFFNOJOK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKFAHCECANI(JNFCHABMBAC GPIEBCABDOC, IPEndPoint PDAMFKMDKKO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class MBDDIJBLDCH
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int FBFIAMCLFNM = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long IBOFJJHGEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte DDCIAGGONML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] KAGIIBEIHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HMKCBIGIMHH LBOALCIJNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int NPCFJNEMMOB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5585E00", Offset = "0x5584C00", VA = "0x185585E00")]
	private MBDDIJBLDCH(long HACGNBHLGBL, byte MECAKPCGFGA, int JNDMOGCGEKD, byte[] MEBOJBNFICA, HMKCBIGIMHH EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x55859A0", Offset = "0x55847A0", VA = "0x1855859A0")]
	public static int GOBKMEKGLMD(HMJANKKMJPF MACPKJCBJCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5585BE0", Offset = "0x55849E0", VA = "0x185585BE0")]
	public static MBDDIJBLDCH LECJJBOAONF(HMJANKKMJPF MACPKJCBJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5585A00", Offset = "0x5584800", VA = "0x185585A00")]
	public static HMJANKKMJPF HGNEOKGMFPE(BHBCFHKPGCC NFALGIJJPDK, SocketAddress BFKJNOFLDBC, long KABJDHGAFOK, int JNDMOGCGEKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PCNBIAKGMLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long IBOFJJHGEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte DDCIAGGONML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int NPCFJNEMMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool DHDMDNAMMBN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5586720", Offset = "0x5585520", VA = "0x185586720")]
	private PCNBIAKGMLL(long HACGNBHLGBL, byte MECAKPCGFGA, int BFFIEOMPONH, bool GKFKKIJGPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x55865D0", Offset = "0x55853D0", VA = "0x1855865D0")]
	public static PCNBIAKGMLL LECJJBOAONF(HMJANKKMJPF MACPKJCBJCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x55864E0", Offset = "0x55852E0", VA = "0x1855864E0")]
	public static HMJANKKMJPF HGNEOKGMFPE(long KABJDHGAFOK, byte POKHMANMFCI, int LHBPNJFBEMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x55863E0", Offset = "0x55851E0", VA = "0x1855863E0")]
	public static HMJANKKMJPF FHBNOCGMJIH(JNFCHABMBAC GPIEBCABDOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum MJMPCIIIKFL
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LLMHKOGJFNM
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILDAJHFNCNG(IPEndPoint MKBCNDFJALO, IPEndPoint LBNNPHHGIHO, string BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFMPLCAGFHC(IPEndPoint AAADKMCKDDA, MJMPCIIIKFL LPFFKBBBCBL, string BNAJMHPOOCG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class CDBEMKFPJKC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct PKGEGLNEAPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint NNCLCDNNADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint FGEGHNHNEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string JJJEGJONNGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct BOEKDFNDPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint KALMFGCBLNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MJMPCIIIKFL BCIPLIOEBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string JJJEGJONNGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class GGNDJEDOMEC
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint BCIJHPEMJDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string JJJEGJONNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public GGNDJEDOMEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class ANEBJGFNMHM
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint BCIJHPEMJDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint KCBHHFNHANM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string JJJEGJONNGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public ANEBJGFNMHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class PNPPPOOIKAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JJJEGJONNGK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B8190", Offset = "0x7B6F90", VA = "0x1807B8190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GCDIKECJFLH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B83F0", Offset = "0x7B71F0", VA = "0x1807B83F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public PNPPPOOIKAP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly BHIBDNBJMBL GDCFNCJKFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<PKGEGLNEAPO> OCCMMAKJILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<BOEKDFNDPPN> AOAFGOOPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HMKCBIGIMHH NMMILGAKBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly BHBCFHKPGCC LJALIEMLGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly LMKFNHDAHPM NLMJFHBHHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private LLMHKOGJFNM NOBBIKHHMFI;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int MDPGJIBCOFK = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool GDEIODNJJPK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x557AF00", Offset = "0x5579D00", VA = "0x18557AF00")]
	internal CDBEMKFPJKC(BHIBDNBJMBL DFONLDMKLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x557AAB0", Offset = "0x55798B0", VA = "0x18557AAB0")]
	internal void BKPEHOFIPAM(IPEndPoint NKLLHLGEBMF, HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x258A910", Offset = "0x2589710", VA = "0x18258A910")]
	private void PMFCEBEMIIB<T>(T MACPKJCBJCP, IPEndPoint EOCODFIAJEL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x557AC10", Offset = "0x5579A10", VA = "0x18557AC10")]
	private void ILDAJHFNCNG(GGNDJEDOMEC JHEPOICHMIH, IPEndPoint NKLLHLGEBMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x557ADA0", Offset = "0x5579BA0", VA = "0x18557ADA0")]
	private void NMLLBKPGNLI(ANEBJGFNMHM JHEPOICHMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x557A910", Offset = "0x5579710", VA = "0x18557A910")]
	private void AMKGKKGCNHI(PNPPPOOIKAP JHEPOICHMIH, IPEndPoint NKLLHLGEBMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum COIMFMFIEKL : byte
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
public enum JMLBIDDKPGJ : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DLBMDJDFABC
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] EKLGOFNEBHC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int EMOKMOGKNMO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HOGFLEKMIOL;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HFPIMMJHDDB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x557CEC0", Offset = "0x557BCC0", VA = "0x18557CEC0")]
	public HFPIMMJHDDB(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MOFLCBLCNLL : HFPIMMJHDDB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x557CEC0", Offset = "0x557BCC0", VA = "0x18557CEC0")]
	public MOFLCBLCNLL(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum FJFNBLHAHDK
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
public interface JKBEBBGCNAM
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIKFDOPDHCJ(FJFNBLHAHDK NMCGPAMICED, string OMFBJPLNJIJ, params object[] LBACBNGIGEC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class OKFNMHINPDD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static JKBEBBGCNAM MLCKBDOMKIH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object BPCFGDBKMMA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5585FE0", Offset = "0x5584DE0", VA = "0x185585FE0")]
	private static void CLBPPBNNNCB(FJFNBLHAHDK BHNOHKLBDPJ, string OMFBJPLNJIJ, params object[] LBACBNGIGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5586270", Offset = "0x5585070", VA = "0x185586270")]
	internal static void FCBMNEBPGAL(string OMFBJPLNJIJ, params object[] LBACBNGIGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x55862D0", Offset = "0x55850D0", VA = "0x1855862D0")]
	internal static void IDJGLAKCKPJ(string OMFBJPLNJIJ, params object[] LBACBNGIGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5586210", Offset = "0x5585010", VA = "0x185586210")]
	internal static void DBENJAPGEAK(string OMFBJPLNJIJ, params object[] LBACBNGIGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum CKFOFPBJAOB
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class MFDNIDDEJEH : HMKCBIGIMHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HMJANKKMJPF JFBJEMLHHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly BHIBDNBJMBL LDINDHLPMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly GFDLLBDAKDL LHEGOCGNHOG;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5585F90", Offset = "0x5584D90", VA = "0x185585F90")]
	internal MFDNIDDEJEH(BHIBDNBJMBL LIDMLHOMNDK, GFDLLBDAKDL HNKPANGOBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5585F20", Offset = "0x5584D20", VA = "0x185585F20")]
	internal void KKAELPNAGPH(HMJANKKMJPF MACPKJCBJCP, int HJMLKNODBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5585EA0", Offset = "0x5584CA0", VA = "0x185585EA0")]
	internal void ICAMJCMDNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5585E70", Offset = "0x5584C70", VA = "0x185585E70")]
	public void AHEBDBNLPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class GFDLLBDAKDL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FAFEIAJOPHM
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
	public GFDLLBDAKDL JNLGPAPFKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public FAFEIAJOPHM BCIPLIOEBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public JNFCHABMBAC BLPJCNGNLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint FGEGHNHNEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object EIGFEECNLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int EONDOIBONAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError AGMFEICEEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public AHHFOJPBBME FOJBEPMBFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IMLGLFEAONH JEAPNCOLMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public COIMFMFIEKL JKMMEIONALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte AHNJNLPCKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly MFDNIDDEJEH LJDDJFNCAKN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x557CE20", Offset = "0x557BC20", VA = "0x18557CE20")]
	public GFDLLBDAKDL(BHIBDNBJMBL LIDMLHOMNDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BHIBDNBJMBL : IEnumerable<JNFCHABMBAC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class EEFICFNOIPB : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x557CDB0", Offset = "0x557BBB0", VA = "0x18557CDB0", Slot = "4")]
		public bool Equals(IPEndPoint BJKAJHEJDMP, IPEndPoint FPNMMAJHCIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x505D660", Offset = "0x505C460", VA = "0x18505D660", Slot = "5")]
		public int GetHashCode(IPEndPoint KDHDNCADFDJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public EEFICFNOIPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct ILKDMMOBBFE : IEnumerator<JNFCHABMBAC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly JNFCHABMBAC CPCEKNDDACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private JNFCHABMBAC GGAPKIKDEGP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JNFCHABMBAC OGCIBGAMGCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8E9730", Offset = "0x8E8530", VA = "0x1808E9730", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF3B780", Offset = "0xF3A580", VA = "0x180F3B780")]
		public ILKDMMOBBFE(JNFCHABMBAC BNKGEELECNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x557F200", Offset = "0x557E000", VA = "0x18557F200", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x557F250", Offset = "0x557E050", VA = "0x18557F250", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread MBPCBECLHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool DODHKOHIAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent OJGJEAELDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<GFDLLBDAKDL> MFLLOMGCHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<GFDLLBDAKDL> MDLJADHDKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GFDLLBDAKDL MJLOPPCMOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MBKCAPHAMLC GLEAOCKKELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly BNEMKPCHANE MFLBLMIMHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly CCNAEPKGKAF NNPECPAENBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MMJOFFNOJOK GNDOPPDMDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, JNFCHABMBAC> CAACCFCGHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, IMLGLFEAONH> IFFPOFOIHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, PJPFCIKAOJB> MBJLNNCOLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim DOJGKFCACHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private JNFCHABMBAC MBODGLLCLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OPMFDOKLKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<JNFCHABMBAC> IFDMNACPNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JNFCHABMBAC[] DMGOBHFJGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HJEILOHEECE PONCMIPCEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int BOIBIECBBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> KHDJKFBFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte DJGPOFNNDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object INNJEDJPBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool LOJPOFKMDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool ANMAGALJFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int NPFKMDBINDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int KKFHPNOIMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OINBBPJFOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int DBBKPALIJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool LOMIPDGIKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NLHDNGPHJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int KONCFFJHGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int OPNEIIAODBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int ILGOBJDKMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool GDEIODNJJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool PEHAAGGHIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool AAINCLABFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool ABACFLKPDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int EPBLFLKKLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int KBOAFCMJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool CJEDIEOCOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly LBBDBGNNPAM IDCOLGJFAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool JLAKMCGEHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly CDBEMKFPJKC LFEGHGAIHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool GOOHPBOIILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public CKFOFPBJAOB PJEEPDGIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int HNHPCFLNBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool COGMGELBMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool DCGCPPGKECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool CEIKPMOKFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool CMJEGJILFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HMJANKKMJPF ELCHOLNDAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int BGKDCLIGOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object JMGFPBMHDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HMJANKKMJPF GAFCAIPMHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int FDPEGGGLNDI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int MGLOBPCABME = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int EEMDLNPGJKD = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PKPDFJOHAKL NGAJAFACELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PKPDFJOHAKL ELBENJPFJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread CHHAJFKKINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread JCDPOJICKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint DFPFPGBMLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint DJIOEKIAFDG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] BDGBKBPFNOC;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] KELPHNFPCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<KDFLPHAGIAF, IPEndPoint> PCIFOJAKKHE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress JKCGGCPPCND;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool HDHCFKGIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int OBEFLOMDNLB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KEIAIGCKKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA429F0", Offset = "0xA417F0", VA = "0x180A429F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAEF390", Offset = "0xAEE190", VA = "0x180AEF390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HLOKELPNKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x15E1100", Offset = "0x15DFF00", VA = "0x1815E1100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x15DFC90", Offset = "0x15DEA90", VA = "0x1815DFC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte FNNJKPJDKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8AC360", VA = "0x1808AD560")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BIJKCCIMNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5573970", Offset = "0x5572770", VA = "0x185573970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short DCGHCONHAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5576DF0", Offset = "0x5575BF0", VA = "0x185576DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5575910", Offset = "0x5574710", VA = "0x185575910")]
	public void INGBGMNGPDG(IPEndPoint POJPPPJHBHP, byte[] ONOECNHBCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5573D70", Offset = "0x5572B70", VA = "0x185573D70")]
	public void FOLHNLHKPKD(IPEndPoint POJPPPJHBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5572BA0", Offset = "0x55719A0", VA = "0x185572BA0")]
	private bool CKCJBJINDNF(IPEndPoint POJPPPJHBHP, [Out] JNFCHABMBAC GPIEBCABDOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x55785C0", Offset = "0x55773C0", VA = "0x1855785C0")]
	private void MOMOKLJDOBF(JNFCHABMBAC GPIEBCABDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5578C10", Offset = "0x5577A10", VA = "0x185578C10")]
	private void OKLCJAPBIBA(JNFCHABMBAC GPIEBCABDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55756B0", Offset = "0x55744B0", VA = "0x1855756B0")]
	private void IECKPKIMODH(JNFCHABMBAC GPIEBCABDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5578F30", Offset = "0x5577D30", VA = "0x185578F30")]
	public BHIBDNBJMBL(MBKCAPHAMLC HOGKGMHKKLK, [Optional] HJEILOHEECE GBEBNMLOCFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5578880", Offset = "0x5577680", VA = "0x185578880")]
	internal void NBJOMJCLHIC(JNFCHABMBAC OAFPJEKAGHJ, int APKKJIDPAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5575200", Offset = "0x5574000", VA = "0x185575200")]
	internal void HBPLIPIMJKJ(JNFCHABMBAC OAFPJEKAGHJ, object BKOCPHDOGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5573B30", Offset = "0x5572930", VA = "0x185573B30")]
	internal void FFNIJBLEIDC(JNFCHABMBAC GPIEBCABDOC, AHHFOJPBBME NMANOHAACJH, SocketError BDOFAMIEFHF, HMJANKKMJPF PKOMIDKDHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5575A70", Offset = "0x5574870", VA = "0x185575A70")]
	private void JHKAHPLILBK(JNFCHABMBAC GPIEBCABDOC, AHHFOJPBBME NMANOHAACJH, SocketError BDOFAMIEFHF, bool CPEDIDFIAIE, byte[] EEDANCJJEPL, int CJNJFDOAKGB, int DPKFLHPPNCH, HMJANKKMJPF PKOMIDKDHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5576EB0", Offset = "0x5575CB0", VA = "0x185576EB0")]
	private void MMHKODNDDOB(GFDLLBDAKDL.FAFEIAJOPHM LPFFKBBBCBL, [Optional] JNFCHABMBAC GPIEBCABDOC, [Optional] IPEndPoint LBNNPHHGIHO, SocketError OEGBDAJHHHM = SocketError.Success, int APKKJIDPAKP = 0, AHHFOJPBBME HGJLDJBBGJN = AHHFOJPBBME.ConnectionFailed, [Optional] IMLGLFEAONH MCNDACBANGB, COIMFMFIEKL JMIMAJGKIEM = COIMFMFIEKL.Unreliable, byte NMNNPEOPCGM = 0, [Optional] HMJANKKMJPF FNHACHLJCMB, [Optional] object BKOCPHDOGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5572C30", Offset = "0x5571A30", VA = "0x185572C30")]
	private void DBBOLCJGNDH(GFDLLBDAKDL HNKPANGOBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55733F0", Offset = "0x55721F0", VA = "0x1855733F0")]
	internal void DCKODADNLDF(GFDLLBDAKDL HNKPANGOBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5573EC0", Offset = "0x5572CC0", VA = "0x185573EC0")]
	private void FPDDLBBICLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5572880", Offset = "0x5571680", VA = "0x185572880")]
	private void APCHIONJOBL(int HOOANLLOKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5575C00", Offset = "0x5574A00", VA = "0x185575C00")]
	internal JNFCHABMBAC JKJNOILMHPM(IMLGLFEAONH GFBEKCAHNCH, byte[] FCFICAAHAFF, int CJNJFDOAKGB, int AKCMMEDPGHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5578B90", Offset = "0x5577990", VA = "0x185578B90")]
	private int OAKGALPIDCC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5575250", Offset = "0x5574050", VA = "0x185575250")]
	private void HPKADDJMDDJ(IPEndPoint LBNNPHHGIHO, JNFCHABMBAC AKCJIPOGCBM, MBDDIJBLDCH KDABDEDDLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5577270", Offset = "0x5576070", VA = "0x185577270")]
	private void MOGCKIMAJNH(HMJANKKMJPF MACPKJCBJCP, IPEndPoint LBNNPHHGIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x55788D0", Offset = "0x55776D0", VA = "0x1855788D0")]
	internal void NCAFJLEANPD(HMJANKKMJPF MACPKJCBJCP, COIMFMFIEKL OMHFOKENAPK, byte NMNNPEOPCGM, int HJMLKNODBLI, JNFCHABMBAC OAFPJEKAGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5574220", Offset = "0x5573020", VA = "0x185574220")]
	public bool FPLLGBFFFEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5574200", Offset = "0x5573000", VA = "0x185574200")]
	public bool FPLLGBFFFEM(IPAddress DHJPCCOGPBI, IPAddress AHFFNNHNKKF, int IDELFPEFHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55749F0", Offset = "0x55737F0", VA = "0x1855749F0")]
	public bool FPLLGBFFFEM(int IDELFPEFHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5574AD0", Offset = "0x55738D0", VA = "0x185574AD0")]
	public void GMBFPIBMODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5574D50", Offset = "0x5573B50", VA = "0x185574D50")]
	public JNFCHABMBAC HAJAPJHFJPK(string AFNGGLCNEIN, int IDELFPEFHIP, string ONOECNHBCDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5574C70", Offset = "0x5573A70", VA = "0x185574C70")]
	public JNFCHABMBAC HAJAPJHFJPK(string AFNGGLCNEIN, int IDELFPEFHIP, BHBCFHKPGCC GIBBLNIBCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5574E30", Offset = "0x5573C30", VA = "0x185574E30")]
	public JNFCHABMBAC HAJAPJHFJPK(IPEndPoint EOCODFIAJEL, BHBCFHKPGCC GIBBLNIBCGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x55764D0", Offset = "0x55752D0", VA = "0x1855764D0")]
	public void LLCNKMBDPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x55764E0", Offset = "0x55752E0", VA = "0x1855764E0")]
	public void LLCNKMBDPEN(bool IEJALNPCACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5573610", Offset = "0x5572410", VA = "0x185573610")]
	public void EMIOAHELGDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x55734F0", Offset = "0x55722F0", VA = "0x1855734F0")]
	public void EMIOAHELGDF(byte[] EEDANCJJEPL, int CJNJFDOAKGB, int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5575B50", Offset = "0x5574950", VA = "0x185575B50")]
	public void JHKAHPLILBK(JNFCHABMBAC GPIEBCABDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x55759B0", Offset = "0x55747B0", VA = "0x1855759B0")]
	public void JHKAHPLILBK(JNFCHABMBAC GPIEBCABDOC, byte[] EEDANCJJEPL, int CJNJFDOAKGB, int DPKFLHPPNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5578D50", Offset = "0x5577B50", VA = "0x185578D50", Slot = "4")]
	private IEnumerator<JNFCHABMBAC> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5578DE0", Offset = "0x5577BE0", VA = "0x185578DE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5576300", Offset = "0x5575100", VA = "0x185576300")]
	private HMJANKKMJPF LHAKNIGLKCA(AGIDIFJJNAH EIJAJNKHLMI, int JEOEJJBKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55763F0", Offset = "0x55751F0", VA = "0x1855763F0")]
	private HMJANKKMJPF LHAKNIGLKCA(AGIDIFJJNAH EIJAJNKHLMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5576BC0", Offset = "0x55759C0", VA = "0x185576BC0")]
	internal HMJANKKMJPF MJKLHKPJMLC(int JEOEJJBKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5573710", Offset = "0x5572510", VA = "0x185573710")]
	internal void EMPGPKHDHHK(HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5578E70", Offset = "0x5577C70", VA = "0x185578E70")]
	static BHIBDNBJMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA429F0", Offset = "0xA417F0", VA = "0x180A429F0")]
	private bool KODEICHACDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5578C60", Offset = "0x5577A60", VA = "0x185578C60")]
	private void PJEEMJMPNPL(IPEndPoint LEACGNHCEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5576220", Offset = "0x5575020", VA = "0x185576220")]
	private void LBFMKFMIPMH(IPEndPoint LEACGNHCEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5573990", Offset = "0x5572790", VA = "0x185573990")]
	private bool FBNFOPLOKNH(SocketException IAOBDGOKOMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x55725B0", Offset = "0x55713B0", VA = "0x1855725B0")]
	private void AMBPLOOBHEP(PKPDFJOHAKL DFONLDMKLDF, EndPoint MGDMDGNFEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5576830", Offset = "0x5575630", VA = "0x185576830")]
	private void MDNBNIGLFJC(object OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5574230", Offset = "0x5573030", VA = "0x185574230")]
	public bool FPLLGBFFFEM(IPAddress DHJPCCOGPBI, IPAddress AHFFNNHNKKF, int IDELFPEFHIP, bool LNGMOLKLNKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5574A70", Offset = "0x5573870", VA = "0x185574A70")]
	internal int GCDEDIPKOHE(HMJANKKMJPF MACPKJCBJCP, IPEndPoint LBNNPHHGIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5577FC0", Offset = "0x5576DC0", VA = "0x185577FC0")]
	internal int MOJNMCHAJGG(HMJANKKMJPF MACPKJCBJCP, IPEndPoint LBNNPHHGIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5578000", Offset = "0x5576E00", VA = "0x185578000")]
	internal int MOJNMCHAJGG(byte[] LJCDGDONMLD, int CJNJFDOAKGB, int AKCMMEDPGHB, IPEndPoint LBNNPHHGIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5573C00", Offset = "0x5572A00", VA = "0x185573C00")]
	internal void FLKMNDLDCEH(bool INMCFFPADAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum AGIDIFJJNAH : byte
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
internal sealed class HMJANKKMJPF
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int EEOFBAIEILE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] NLDKKABELNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] FKFHDIPNCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int LGOFLDBOEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object EIGFEECNLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public HMJANKKMJPF JNLGPAPFKNP;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AGIDIFJJNAH CPGHLMCFDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x557D420", Offset = "0x557C220", VA = "0x18557D420")]
		get
		{
			return default(AGIDIFJJNAH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x557D4B0", Offset = "0x557C2B0", VA = "0x18557D4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte DDCIAGGONML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x557D450", Offset = "0x557C250", VA = "0x18557D450")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x557D270", Offset = "0x557C070", VA = "0x18557D270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort AEHIFKDGMIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x557D350", Offset = "0x557C150", VA = "0x18557D350")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x557D1F0", Offset = "0x557BFF0", VA = "0x18557D1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool IFDDMEDOAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x557D480", Offset = "0x557C280", VA = "0x18557D480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte NELMLECEFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x557D3F0", Offset = "0x557C1F0", VA = "0x18557D3F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x557D0C0", Offset = "0x557BEC0", VA = "0x18557D0C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort EMAPNJCBHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x557D000", Offset = "0x557BE00", VA = "0x18557D000")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x557D3B0", Offset = "0x557C1B0", VA = "0x18557D3B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort JPLOBMNDKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x557D2F0", Offset = "0x557C0F0", VA = "0x18557D2F0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x557D2B0", Offset = "0x557C0B0", VA = "0x18557D2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort ENLEDEMCAON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x557D060", Offset = "0x557BE60", VA = "0x18557D060")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x557D230", Offset = "0x557C030", VA = "0x18557D230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x557D4F0", Offset = "0x557C2F0", VA = "0x18557D4F0")]
	static HMJANKKMJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x557CFD0", Offset = "0x557BDD0", VA = "0x18557CFD0")]
	public void CPCDOAMJEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x557D7D0", Offset = "0x557C5D0", VA = "0x18557D7D0")]
	public HMJANKKMJPF(int JEOEJJBKODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x557D840", Offset = "0x557C640", VA = "0x18557D840")]
	public HMJANKKMJPF(AGIDIFJJNAH EIJAJNKHLMI, int JEOEJJBKODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x557D0F0", Offset = "0x557BEF0", VA = "0x18557D0F0")]
	public static int IELCIEDGJNP(AGIDIFJJNAH EIJAJNKHLMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x557D160", Offset = "0x557BF60", VA = "0x18557D160")]
	public int IELCIEDGJNP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x557CED0", Offset = "0x557BCD0", VA = "0x18557CED0")]
	public bool CKDACGBEFJJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum OKOIFAGPENJ : byte
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
internal enum LDANELJGNPK
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
internal enum IGDFBAONFCO
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum IKEMGIILGKI
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class JNFCHABMBAC
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class APIBICHLHKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HMJANKKMJPF[] GOLAFOJOLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int KCENCLOMJHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int BFPDLEBDBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte NELMLECEFKI;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public APIBICHLHKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void OFMDINJPIMB(ulong MJIPJADAJEM, int BMHCPHHONOL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int CAKIDHBPILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int PECICDFJIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int CHJAPJLMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double EFBADAJGJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int KDLPAAGNIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int MEJKLLGLIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int LIFPDLIJACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch EDCNMNJGKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int HDHDBAGCBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long EDGJKGJNAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object HDHOPACJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal JNFCHABMBAC KMMAHCIOOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal JNFCHABMBAC NCDJFKLCBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<HMJANKKMJPF> AIFEOGOJOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<DADLIPMBJOH> GBKPIEGGABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DADLIPMBJOH[] GMDPFNIANIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int BLKAEPNLCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int GMHCAMHJFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool FANJNAHLEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int ODFCOMIELBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int CJKLGIDLOAB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int OBEEDDNHIMH = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int KLJDKBLGOHL = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object HNIBEJFJIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int PIDGNNKEHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, APIBICHLHKA> HLJGPPCMEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> AMGFELLMIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly HMJANKKMJPF ONKFEIBPGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int EGDCDNAFIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int KDFNLHADNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint DCPNOPNDNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int KHDHFEBBMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int IJMNABPCCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long CDEAALPGKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte PHAOAPHDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private OKOIFAGPENJ HHFIDEBDOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HMJANKKMJPF JOCOEPIEAAI;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int NHCNBONDHPP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int IDCFNPBELJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HMJANKKMJPF GDLJCNEKPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HMJANKKMJPF NEFOEGICFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HMJANKKMJPF PEAMNFEPACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HMJANKKMJPF IOPPBPGAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private JMLBIDDKPGJ KBPIBDNGCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly BHIBDNBJMBL EILFGEMDOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int KAFEFKNGGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object MHFCIKDEPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly LBBDBGNNPAM IDCOLGJFAHE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte DBINCJFDPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA6B970", Offset = "0xA6A770", VA = "0x180A6B970")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x55829A0", Offset = "0x55817A0", VA = "0x1855829A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint BGGLOBOHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DCC70", Offset = "0x8DBA70", VA = "0x1808DCC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public OKOIFAGPENJ LBHEAILOHBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x15FD9F0", Offset = "0x15FC7F0", VA = "0x1815FD9F0")]
		get
		{
			return default(OKOIFAGPENJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long GNFMLCNDENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EA0", Offset = "0x7C2CA0", VA = "0x1807C3EA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OALDEFCEHEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB2F640", Offset = "0xB2E440", VA = "0x180B2F640")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1418490", Offset = "0x1417290", VA = "0x181418490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DKMGINNEJHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5582990", Offset = "0x5581790", VA = "0x185582990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int OMAAKIKEGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C9110", Offset = "0x7C7F10", VA = "0x1807C9110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double EGMJENJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x17E8C80", Offset = "0x17E7A80", VA = "0x1817E8C80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OFMDINJPIMB EOKJODOAEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5580640", Offset = "0x557F440", VA = "0x185580640")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x55807D0", Offset = "0x557F5D0", VA = "0x1855807D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5582E00", Offset = "0x5581C00", VA = "0x185582E00")]
	internal JNFCHABMBAC(BHIBDNBJMBL DGPAHDCNOCB, IPEndPoint LBNNPHHGIHO, int FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55808C0", Offset = "0x557F6C0", VA = "0x1855808C0")]
	internal void FNDJOJGLLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5581550", Offset = "0x5580350", VA = "0x185581550")]
	internal void INDHJFEPMOM(IPEndPoint ACALHDHLCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55806F0", Offset = "0x557F4F0", VA = "0x1855806F0")]
	internal void DEMEKBPLGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5581580", Offset = "0x5580380", VA = "0x185581580")]
	private void KAIEJGNODMI(int BMJDAKDKDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5580880", Offset = "0x557F680", VA = "0x185580880")]
	private void FFHMAEBCLLK(int NPLPHBOCJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5580E70", Offset = "0x557FC70", VA = "0x185580E70")]
	private DADLIPMBJOH GHEIOJOPMLC(byte FOKFIOMCHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5583260", Offset = "0x5582060", VA = "0x185583260")]
	internal JNFCHABMBAC(BHIBDNBJMBL DGPAHDCNOCB, IPEndPoint LBNNPHHGIHO, int FJIJLBIGEAH, byte POKHMANMFCI, BHBCFHKPGCC NFALGIJJPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x55833F0", Offset = "0x55821F0", VA = "0x1855833F0")]
	internal JNFCHABMBAC(BHIBDNBJMBL DGPAHDCNOCB, IMLGLFEAONH GFBEKCAHNCH, int FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5580780", Offset = "0x557F580", VA = "0x185580780")]
	internal void EONDCHAJBIE(MBDDIJBLDCH FDOPCAPMAAF, byte[] EEDANCJJEPL, int CJNJFDOAKGB, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x557F580", Offset = "0x557E380", VA = "0x18557F580")]
	internal bool ALGDNKGLGKO(PCNBIAKGMLL MACPKJCBJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5582DD0", Offset = "0x5581BD0", VA = "0x185582DD0")]
	public void PMFCEBEMIIB(byte[] EEDANCJJEPL, int CJNJFDOAKGB, int AKCMMEDPGHB, COIMFMFIEKL BAELEFOBFMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5582190", Offset = "0x5580F90", VA = "0x185582190")]
	private void LKEKCOEDANB(byte[] EEDANCJJEPL, int CJNJFDOAKGB, int AKCMMEDPGHB, byte NMNNPEOPCGM, COIMFMFIEKL JMIMAJGKIEM, object BKOCPHDOGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5581770", Offset = "0x5580570", VA = "0x185581770")]
	public void KNHBIBMHGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x55828B0", Offset = "0x55816B0", VA = "0x1855828B0")]
	internal IGDFBAONFCO NNEADALEDEE(HMJANKKMJPF MACPKJCBJCP)
	{
		return default(IGDFBAONFCO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5581020", Offset = "0x557FE20", VA = "0x185581020")]
	internal void GIFMJAGOBPA(DADLIPMBJOH OMBFAFMLKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5581080", Offset = "0x557FE80", VA = "0x185581080")]
	internal IKEMGIILGKI HOEEAFPNHGL(byte[] EEDANCJJEPL, int CJNJFDOAKGB, int AKCMMEDPGHB, bool CPEDIDFIAIE)
	{
		return default(IKEMGIILGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5580E30", Offset = "0x557FC30", VA = "0x185580E30")]
	private void GFJLKLNDCAG(int PBNMMDGEBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x557F600", Offset = "0x557E400", VA = "0x18557F600")]
	internal void AMFEADCIKGD(COIMFMFIEKL OMHFOKENAPK, HMJANKKMJPF BNKGEELECNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55808E0", Offset = "0x557F6E0", VA = "0x1855808E0")]
	private void GCHKFEOOLND(HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5582A50", Offset = "0x5581850", VA = "0x185582A50")]
	private void PHJOJPMAANN(int LDLIGJLNGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5581390", Offset = "0x5580190", VA = "0x185581390")]
	internal LDANELJGNPK HPKADDJMDDJ(MBDDIJBLDCH KDABDEDDLAF)
	{
		return default(LDANELJGNPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x557FF90", Offset = "0x557ED90", VA = "0x18557FF90")]
	internal void AMKEHFMILKM(HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5581650", Offset = "0x5580450", VA = "0x185581650")]
	private void KLIHMNGJEFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x55826E0", Offset = "0x55814E0", VA = "0x1855826E0")]
	internal void MOBJCNPNJKD(HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5581AE0", Offset = "0x55808E0", VA = "0x185581AE0")]
	internal void LAGHJNJIPJP(int LDLIGJLNGPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5581820", Offset = "0x5580620", VA = "0x185581820")]
	internal void KOJIHJCLKHD(HMJANKKMJPF MACPKJCBJCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class LBBDBGNNPAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long KAGCGJFAEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long JPGMHDPPDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long HINBNKOIIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long CMCGICMNLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long MPFNDFBLHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long IAIHPBJGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long PHINAJKFFJJ;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long MFCDKCGFAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5583910", Offset = "0x5582710", VA = "0x185583910")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long OONFOFPJPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x55839A0", Offset = "0x55827A0", VA = "0x1855839A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long DJOCGNJHAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5583980", Offset = "0x5582780", VA = "0x185583980")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long CFFBFBHGEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x55838F0", Offset = "0x55826F0", VA = "0x1855838F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long OMNBBOPGBDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5583920", Offset = "0x5582720", VA = "0x185583920")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long HGAIABEPFLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5583930", Offset = "0x5582730", VA = "0x185583930")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private JMLBIDDKPGJ FHLOAGKCKGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1A66460", Offset = "0x1A65260", VA = "0x181A66460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double ADALNFFHCEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x55839B0", Offset = "0x55827B0", VA = "0x1855839B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5583860", Offset = "0x5582660", VA = "0x185583860")]
	public void BMDNDNAFIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55838C0", Offset = "0x55826C0", VA = "0x1855838C0")]
	public void ECGFAOLEMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5583990", Offset = "0x5582790", VA = "0x185583990")]
	public void MMEGMNCBLEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5583900", Offset = "0x5582700", VA = "0x185583900")]
	public void FHHPBEKFEMA(long OGEBEDIFKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5583850", Offset = "0x5582650", VA = "0x185583850")]
	public void AOFCEOHGHIA(long HHOCKLMIDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5583A10", Offset = "0x5582810", VA = "0x185583A10")]
	public void PMOOPJIJGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5583940", Offset = "0x5582740", VA = "0x185583940")]
	public void LKJDPNIBBON(long OKMBIOAKOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5583A40", Offset = "0x5582840", VA = "0x185583A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55837B0", Offset = "0x55825B0", VA = "0x1855837B0")]
	public void ADAEPFPDKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public LBBDBGNNPAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DKPPOFJBGBN
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> ELMABLKBGBM;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x557C9F0", Offset = "0x557B7F0", VA = "0x18557C9F0")]
	public static IPEndPoint JHNAKILOAFH(string DHCICFKHBEA, int IDELFPEFHIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x557C790", Offset = "0x557B590", VA = "0x18557C790")]
	public static IPAddress EKKCIDFBFJN(string DHCICFKHBEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x557C960", Offset = "0x557B760", VA = "0x18557C960")]
	public static IPAddress EKKCIDFBFJN(string DHCICFKHBEA, AddressFamily PEGGBJNKKCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x557C760", Offset = "0x557B560", VA = "0x18557C760")]
	internal static int CLIEKCLOMHB(int PBDJDCDANCD, int JNBBCPIKJMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x25C2B60", Offset = "0x25C1960", VA = "0x1825C2B60")]
	internal static T[] LOENALGMIKG<T>(int DPKFLHPPNCH) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PFDIJJNIOEI : DADLIPMBJOH
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct JECKHLJLHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private HMJANKKMJPF JFBJEMLHHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long HONHNIGBGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool OGPIFKLBGEC;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x557F4E0", Offset = "0x557E2E0", VA = "0x18557F4E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x557F400", Offset = "0x557E200", VA = "0x18557F400")]
		public void AAEOMMPCBHP(HMJANKKMJPF MACPKJCBJCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x557F470", Offset = "0x557E270", VA = "0x18557F470")]
		public bool OOCKAGOLOFF(long PAFDNMMBKED, JNFCHABMBAC GPIEBCABDOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x557F420", Offset = "0x557E220", VA = "0x18557F420")]
		public bool OCIHDBDLDKI(JNFCHABMBAC GPIEBCABDOC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly HMJANKKMJPF GMMGOMHPFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly JECKHLJLHIC[] NCFIOLGLDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly HMJANKKMJPF[] BJPJODEKALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] AIIEOEGOKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int HLCCBNMHODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int OFOLOJOBKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int KFAHMHOCFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int LLEDFEEBDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool LIJFJCCNOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly COIMFMFIEKL GAMBLEKEHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool CANHGMIPBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int DDDDMKJKNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte CAIIIJLKBGO;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5587640", Offset = "0x5586440", VA = "0x185587640")]
	public PFDIJJNIOEI(JNFCHABMBAC GPIEBCABDOC, bool JOLGHPEGCEF, byte FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5587280", Offset = "0x5586080", VA = "0x185587280")]
	private void ELKOIEKJLDM(HMJANKKMJPF MACPKJCBJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5586DD0", Offset = "0x5585BD0", VA = "0x185586DD0", Slot = "4")]
	protected override bool CLMBPADHPNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5586770", Offset = "0x5585570", VA = "0x185586770", Slot = "5")]
	public override bool AMKEHFMILKM(HMJANKKMJPF MACPKJCBJCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DCIJAIIGDEO : DADLIPMBJOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int DLNAKEFMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort OFOLOJOBKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool LNMEMDJIDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private HMJANKKMJPF KHIGGDCFJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly HMJANKKMJPF KGPLCGEDMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool HPFPHNJEBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte CAIIIJLKBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long PDCCHMONFKJ;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x557C540", Offset = "0x557B340", VA = "0x18557C540")]
	public DCIJAIIGDEO(JNFCHABMBAC GPIEBCABDOC, bool GBCEKFLKDCJ, byte FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x557C0A0", Offset = "0x557AEA0", VA = "0x18557C0A0", Slot = "4")]
	protected override bool CLMBPADHPNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x557BD90", Offset = "0x557AB90", VA = "0x18557BD90", Slot = "5")]
	public override bool AMKEHFMILKM(HMJANKKMJPF MACPKJCBJCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class DCONNAIGIAB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct CGPDCIJPPME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong LEOGDFGMGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double JMFEMLFMFLF;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct JDEKDAMOBEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int AAMBGKDEOPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float NBEEOJJABMO;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5571670", Offset = "0x5570470", VA = "0x185571670")]
	private static void LKJOOGCBNPF(byte[] LIICAAPCJGB, int LBJEFCOBKGF, ulong EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x557C600", Offset = "0x557B400", VA = "0x18557C600")]
	private static void LKJOOGCBNPF(byte[] LIICAAPCJGB, int LBJEFCOBKGF, int EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x557C670", Offset = "0x557B470", VA = "0x18557C670")]
	public static void LKJOOGCBNPF(byte[] LIICAAPCJGB, int LBJEFCOBKGF, short EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x557C6C0", Offset = "0x557B4C0", VA = "0x18557C6C0")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, double MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x557C6E0", Offset = "0x557B4E0", VA = "0x18557C6E0")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x557C670", Offset = "0x557B470", VA = "0x18557C670")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, short MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x557C670", Offset = "0x557B470", VA = "0x18557C670")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, ushort MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x557C600", Offset = "0x557B400", VA = "0x18557C600")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, int MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x557C600", Offset = "0x557B400", VA = "0x18557C600")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, uint MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x557C6B0", Offset = "0x557B4B0", VA = "0x18557C6B0")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, long MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x557C6B0", Offset = "0x557B4B0", VA = "0x18557C6B0")]
	public static void PHIANEBGKFM(byte[] HCFBAPHHICF, int NIAPLMNAGEM, ulong MAEBFBHFPDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HMKCBIGIMHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] LDKGMPHCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int DPPCEJDLKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int ACLIANOHHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int NANJNCOCCFG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] FKFHDIPNCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OPENOGOMFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x91FAD0", Offset = "0x91E8D0", VA = "0x18091FAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JLMILBDOCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x557DCA0", Offset = "0x557CAA0", VA = "0x18557DCA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool DLLGEGNKIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1CD01D0", Offset = "0x1CCEFD0", VA = "0x181CD01D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MMPIKJEPECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x557E1E0", Offset = "0x557CFE0", VA = "0x18557E1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x557E2A0", Offset = "0x557D0A0", VA = "0x18557E2A0")]
	public void KKAELPNAGPH(byte[] CCBBNNMCBIL, int LBJEFCOBKGF, int FMCGGJCCPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HMKCBIGIMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x557E540", Offset = "0x557D340", VA = "0x18557E540")]
	public HMKCBIGIMHH(byte[] CCBBNNMCBIL, int LBJEFCOBKGF, int FMCGGJCCPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x557E2E0", Offset = "0x557D0E0", VA = "0x18557E2E0")]
	public IPEndPoint KPGHMHCOPGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x557E0C0", Offset = "0x557CEC0", VA = "0x18557E0C0")]
	public byte NGGIAMODDOL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x557E0C0", Offset = "0x557CEC0", VA = "0x18557E0C0")]
	public sbyte HJLCLENNDOD()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x276C900", Offset = "0x276B700", VA = "0x18276C900")]
	public T[] JGJEMDNAPIL<T>(ushort JEOEJJBKODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x557DD20", Offset = "0x557CB20", VA = "0x18557DD20")]
	public bool[] EPHKPJKDDHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x557E080", Offset = "0x557CE80", VA = "0x18557E080")]
	public ushort[] HGJDLPLJEGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x557DBA0", Offset = "0x557C9A0", VA = "0x18557DBA0")]
	public short[] BPBGOPJINJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x557DC20", Offset = "0x557CA20", VA = "0x18557DC20")]
	public int[] CPJECONLGJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x557DC60", Offset = "0x557CA60", VA = "0x18557DC60")]
	public uint[] DCMMKIDMCKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x557DBE0", Offset = "0x557C9E0", VA = "0x18557DBE0")]
	public float[] CDNJOPDNLFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x557E1F0", Offset = "0x557CFF0", VA = "0x18557E1F0")]
	public double[] JJONAKHLMKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x557E4A0", Offset = "0x557D2A0", VA = "0x18557E4A0")]
	public long[] MLDKCCDDOHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x557E4E0", Offset = "0x557D2E0", VA = "0x18557E4E0")]
	public ulong[] OBCIBKOHHLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x557DA00", Offset = "0x557C800", VA = "0x18557DA00")]
	public string[] BEKHBNEGGMJ(int JGOKBELMJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x557D950", Offset = "0x557C750", VA = "0x18557D950")]
	public bool AJENKBACGFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x557DB30", Offset = "0x557C930", VA = "0x18557DB30")]
	public char BNNDCCKJHEJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x557DB30", Offset = "0x557C930", VA = "0x18557DB30")]
	public ushort EBOIHBHDJAP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x557E230", Offset = "0x557D030", VA = "0x18557E230")]
	public short KEHOKGPNKAO()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x557E430", Offset = "0x557D230", VA = "0x18557E430")]
	public long MBLOFMFPJKN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x557D990", Offset = "0x557C790", VA = "0x18557D990")]
	public ulong ALCGPDNILLL()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x557DDD0", Offset = "0x557CBD0", VA = "0x18557DDD0")]
	public int HFIGJDCMANC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x557DCB0", Offset = "0x557CAB0", VA = "0x18557DCB0")]
	public uint EHPPBMLOJNC()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x557DD60", Offset = "0x557CB60", VA = "0x18557DD60")]
	public float GMFDBJNDEGF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x557E100", Offset = "0x557CF00", VA = "0x18557E100")]
	public double ICCPOIHPDGC()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x557DE40", Offset = "0x557CC40", VA = "0x18557DE40")]
	public string HGIFKJDJHFB(int DDEIEHGBNMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x557E170", Offset = "0x557CF70", VA = "0x18557E170")]
	public ArraySegment<byte> IKBNLFAJMFF(int DPKFLHPPNCH)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x557E3B0", Offset = "0x557D1B0", VA = "0x18557E3B0")]
	public sbyte[] LJJEBEGHJCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x557E3F0", Offset = "0x557D1F0", VA = "0x18557E3F0")]
	public byte[] MADEEGJODEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x557E520", Offset = "0x557D320", VA = "0x18557E520")]
	public void OCIHDBDLDKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class BHBCFHKPGCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] LDKGMPHCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int DPPCEJDLKBE;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int KOBGGGDAFON = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool BFLALHGBCGA;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding LMNPILCFOMN;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int OKHJMDJAFDI = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] MALDKJFAIBA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] LBOALCIJNPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int EINKGEEBGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5572490", Offset = "0x5571290", VA = "0x185572490")]
	public BHBCFHKPGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5572510", Offset = "0x5571310", VA = "0x185572510")]
	public BHBCFHKPGCC(bool JHFKLAMHGEM, int LAJNMJLCNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x55718E0", Offset = "0x55706E0", VA = "0x1855718E0")]
	public static BHBCFHKPGCC LIFJAJOHNGD(string MAEBFBHFPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5571840", Offset = "0x5570640", VA = "0x185571840")]
	public void KLKPLFPPLOJ(int KKABCLALAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1D49AE0", Offset = "0x1D488E0", VA = "0x181D49AE0")]
	public void BMDNDNAFIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5572130", Offset = "0x5570F30", VA = "0x185572130")]
	public void NIHKLPIOCIE(float MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x55720E0", Offset = "0x5570EE0", VA = "0x1855720E0")]
	public void NIHKLPIOCIE(double MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5571E80", Offset = "0x5570C80", VA = "0x185571E80")]
	public void NIHKLPIOCIE(long MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5571E80", Offset = "0x5570C80", VA = "0x185571E80")]
	public void NIHKLPIOCIE(ulong MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55721D0", Offset = "0x5570FD0", VA = "0x1855721D0")]
	public void NIHKLPIOCIE(int MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55721D0", Offset = "0x5570FD0", VA = "0x1855721D0")]
	public void NIHKLPIOCIE(uint MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5571DA0", Offset = "0x5570BA0", VA = "0x185571DA0")]
	public void NIHKLPIOCIE(char MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5571DA0", Offset = "0x5570BA0", VA = "0x185571DA0")]
	public void NIHKLPIOCIE(ushort MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5571DA0", Offset = "0x5570BA0", VA = "0x185571DA0")]
	public void NIHKLPIOCIE(short MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5572260", Offset = "0x5571060", VA = "0x185572260")]
	public void NIHKLPIOCIE(sbyte MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5572260", Offset = "0x5571060", VA = "0x185572260")]
	public void NIHKLPIOCIE(byte MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55722C0", Offset = "0x55710C0", VA = "0x1855722C0")]
	public void NIHKLPIOCIE(byte[] EEDANCJJEPL, int LBJEFCOBKGF, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5571760", Offset = "0x5570560", VA = "0x185571760")]
	public void KBNLECCMODL(sbyte[] EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5571760", Offset = "0x5570560", VA = "0x185571760")]
	public void BPJBDMPOOLC(byte[] EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5571E20", Offset = "0x5570C20", VA = "0x185571E20")]
	public void NIHKLPIOCIE(bool MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5571CC0", Offset = "0x5570AC0", VA = "0x185571CC0")]
	public void MOPOMNGBBOD(Array JHJDMLBHALI, int PLJHLEAIGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5571A30", Offset = "0x5570830", VA = "0x185571A30")]
	public void MOPOMNGBBOD(float[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5571BE0", Offset = "0x55709E0", VA = "0x185571BE0")]
	public void MOPOMNGBBOD(double[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5571BE0", Offset = "0x55709E0", VA = "0x185571BE0")]
	public void MOPOMNGBBOD(long[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5571BE0", Offset = "0x55709E0", VA = "0x185571BE0")]
	public void MOPOMNGBBOD(ulong[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5571A30", Offset = "0x5570830", VA = "0x185571A30")]
	public void MOPOMNGBBOD(int[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5571A30", Offset = "0x5570830", VA = "0x185571A30")]
	public void MOPOMNGBBOD(uint[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5571950", Offset = "0x5570750", VA = "0x185571950")]
	public void MOPOMNGBBOD(ushort[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5571950", Offset = "0x5570750", VA = "0x185571950")]
	public void MOPOMNGBBOD(short[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5571760", Offset = "0x5570560", VA = "0x185571760")]
	public void MOPOMNGBBOD(bool[] MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5571B10", Offset = "0x5570910", VA = "0x185571B10")]
	public void MOPOMNGBBOD(string[] MAEBFBHFPDE, int JDCMFOOLJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5572330", Offset = "0x5571130", VA = "0x185572330")]
	public void NIHKLPIOCIE(IPEndPoint POJPPPJHBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5571E10", Offset = "0x5570C10", VA = "0x185571E10")]
	public void NIHKLPIOCIE(string MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5571ED0", Offset = "0x5570CD0", VA = "0x185571ED0")]
	public void NIHKLPIOCIE(string MAEBFBHFPDE, int DDEIEHGBNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class LMKFNHDAHPM
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class FLHOJNBNCHF<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong KAFEFKNGGHK;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x361DBE0", Offset = "0x361C9E0", VA = "0x18361DBE0")]
		static FLHOJNBNCHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void NBNKIDDDPNC(HMKCBIGIMHH INLIFCPEGKK, object BKOCPHDOGLF);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class KBBBNIILPPL<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public LMKFNHDAHPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public KBBBNIILPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3AFE8F0", Offset = "0x3AFD6F0", VA = "0x183AFE8F0")]
		internal void LANEMDJCNMF(HMKCBIGIMHH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GFBCCHMLJPG<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public LMKFNHDAHPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public GFBCCHMLJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x36F3200", Offset = "0x36F2000", VA = "0x1836F3200")]
		internal void LANEMDJCNMF(HMKCBIGIMHH reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly LHLEHBBAICD GGLCMDGBOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, NBNKIDDDPNC> DCMDOKAJNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly BHBCFHKPGCC GNGOEMDCBPM;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5584020", Offset = "0x5582E20", VA = "0x185584020")]
	public LMKFNHDAHPM(int JGOKBELMJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2586050", Offset = "0x2584E50", VA = "0x182586050", Slot = "4")]
	protected virtual ulong EMOKKMFIMOK<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5583EF0", Offset = "0x5582CF0", VA = "0x185583EF0", Slot = "5")]
	protected virtual NBNKIDDDPNC OANGABCKNFD(HMKCBIGIMHH INLIFCPEGKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x27F88A0", Offset = "0x27F76A0", VA = "0x1827F88A0", Slot = "6")]
	protected virtual void DOPHFLHNGBJ<T>(BHBCFHKPGCC FCAJMDOFLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5583E20", Offset = "0x5582C20", VA = "0x185583E20")]
	public void GPDLAAFNEKC(HMKCBIGIMHH INLIFCPEGKK, object BKOCPHDOGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x27F8910", Offset = "0x27F7710", VA = "0x1827F8910")]
	public void IAJGBDBCFBH<T>(BHBCFHKPGCC FCAJMDOFLNK, T MACPKJCBJCP) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5583EA0", Offset = "0x5582CA0", VA = "0x185583EA0")]
	public void NAIGOJCEONH(HMKCBIGIMHH INLIFCPEGKK, object BKOCPHDOGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27F8B20", Offset = "0x27F7920", VA = "0x1827F8B20")]
	public void MFICKEOKOLB<T>(Action<T> CHGIDOIJMJD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x27F89A0", Offset = "0x27F77A0", VA = "0x1827F89A0")]
	public void MFICKEOKOLB<T, TUserData>(Action<T, TUserData> CHGIDOIJMJD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class NBEIPOJOBOB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x557CEC0", Offset = "0x557BCC0", VA = "0x18557CEC0")]
	public NBEIPOJOBOB(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DBLAEPGGDNL : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x557BD30", Offset = "0x557AB30", VA = "0x18557BD30")]
	public DBLAEPGGDNL(string LJCDGDONMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class LHLEHBBAICD
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum OELMENCCJBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class EOCFAJBKELJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public OELMENCCJBG BCIPLIOEBHN;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x32B87F0", Offset = "0x32B75F0", VA = "0x1832B87F0", Slot = "4")]
		public virtual void AAEOMMPCBHP(MethodInfo IHBIHALMPHM, MethodInfo BGIINLFGJEK, OELMENCCJBG LPFFKBBBCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MHEPANLNGDM(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void GDDJEOLGAHF(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		protected EOCFAJBKELJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MHAICNOOBIA<TClass, TProperty> : EOCFAJBKELJ<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> FKINIKNGFND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> GGCIFBPGFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> BGIMHCNKDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> JMFPCHAMDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> MOMBHJDGINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> EFFKLBJBICJ;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E19E60", Offset = "0x3E18C60", VA = "0x183E19E60", Slot = "7")]
		public override void JLAAEBNFBFP(TClass JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E18B00", Offset = "0x3E17900", VA = "0x183E18B00", Slot = "8")]
		public override void BKPBPCDACBP(TClass JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A4F0", Offset = "0x3E192F0", VA = "0x183E1A4F0", Slot = "9")]
		public override void MHEPANLNGDM(TClass JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E18F60", Offset = "0x3E17D60", VA = "0x183E18F60", Slot = "10")]
		public override void GDDJEOLGAHF(TClass JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E19820", Offset = "0x3E18620", VA = "0x183E19820")]
		protected TProperty[] GDJJMKPKMGA(TClass JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E1A480", Offset = "0x3E19280", VA = "0x183E1A480")]
		protected TProperty[] KOPHFFPNCKL(TClass JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E15360", Offset = "0x3E14160", VA = "0x183E15360", Slot = "4")]
		public override void AAEOMMPCBHP(MethodInfo IHBIHALMPHM, MethodInfo BGIINLFGJEK, OELMENCCJBG LPFFKBBBCBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3794500", Offset = "0x3793300", VA = "0x183794500")]
		protected MHAICNOOBIA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class LNFNCEIHLEL<TClass, TProperty> : MHAICNOOBIA<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void JHLEFLDABHP(HMKCBIGIMHH HLPGBAHMLPL, [Out] TProperty JOEPKJOAOMN);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void IDOHHKNLJFM(BHBCFHKPGCC LFPADPMEJPL, TProperty JOEPKJOAOMN);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F500", Offset = "0x3C3E300", VA = "0x183C3F500", Slot = "5")]
		public override void BLJDLJPIDLI(TClass JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F600", Offset = "0x3C3E400", VA = "0x183C3F600", Slot = "6")]
		public override void IAJGBDBCFBH(TClass JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F780", Offset = "0x3C3E580", VA = "0x183C3F780", Slot = "7")]
		public override void JLAAEBNFBFP(TClass JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F3C0", Offset = "0x3C3E1C0", VA = "0x183C3F3C0", Slot = "8")]
		public override void BKPBPCDACBP(TClass JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x38AFC30", Offset = "0x38AEA30", VA = "0x1838AFC30")]
		protected LNFNCEIHLEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class LMJKBCPEDOD<T> : MHAICNOOBIA<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C370B0", Offset = "0x3C35EB0", VA = "0x183C370B0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3788AE0", Offset = "0x37878E0", VA = "0x183788AE0", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3C37120", Offset = "0x3C35F20", VA = "0x183C37120", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3788A10", Offset = "0x3787810", VA = "0x183788A10", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public LMJKBCPEDOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class HAOHHLCHDEG<T> : MHAICNOOBIA<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3788A70", Offset = "0x3787870", VA = "0x183788A70", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3788AE0", Offset = "0x37878E0", VA = "0x183788AE0", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3788B40", Offset = "0x3787940", VA = "0x183788B40", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3788A10", Offset = "0x3787810", VA = "0x183788A10", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public HAOHHLCHDEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class LINLDHDHCIP<T> : MHAICNOOBIA<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E2A0", Offset = "0x3C1D0A0", VA = "0x183C1E2A0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3887750", Offset = "0x3886550", VA = "0x183887750", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E310", Offset = "0x3C1D110", VA = "0x183C1E310", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3887680", Offset = "0x3886480", VA = "0x183887680", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public LINLDHDHCIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class IJBBHGAGCEI<T> : MHAICNOOBIA<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x38876E0", Offset = "0x38864E0", VA = "0x1838876E0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3887750", Offset = "0x3886550", VA = "0x183887750", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x38877B0", Offset = "0x38865B0", VA = "0x1838877B0", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3887680", Offset = "0x3886480", VA = "0x183887680", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public IJBBHGAGCEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class FKHFCJPEINN<T> : MHAICNOOBIA<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x361CEA0", Offset = "0x361BCA0", VA = "0x18361CEA0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x361CF10", Offset = "0x361BD10", VA = "0x18361CF10", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x361CF70", Offset = "0x361BD70", VA = "0x18361CF70", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x361CE40", Offset = "0x361BC40", VA = "0x18361CE40", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public FKHFCJPEINN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class KMGHNKJGLBB<T> : MHAICNOOBIA<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D850", Offset = "0x3B2C650", VA = "0x183B2D850", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x361CF10", Offset = "0x361BD10", VA = "0x18361CF10", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D8C0", Offset = "0x3B2C6C0", VA = "0x183B2D8C0", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x361CE40", Offset = "0x361BC40", VA = "0x18361CE40", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public KMGHNKJGLBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class IEHFPGDJHGM<T> : MHAICNOOBIA<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3875BA0", Offset = "0x38749A0", VA = "0x183875BA0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3875C10", Offset = "0x3874A10", VA = "0x183875C10", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3875C70", Offset = "0x3874A70", VA = "0x183875C70", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3875B40", Offset = "0x3874940", VA = "0x183875B40", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public IEHFPGDJHGM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class NKOPNFHBMLA<T> : MHAICNOOBIA<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3875BA0", Offset = "0x38749A0", VA = "0x183875BA0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3875C10", Offset = "0x3874A10", VA = "0x183875C10", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0BF0", Offset = "0x3EDF9F0", VA = "0x183EE0BF0", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3875B40", Offset = "0x3874940", VA = "0x183875B40", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public NKOPNFHBMLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class PIPBFKICBHB<T> : MHAICNOOBIA<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40ADA70", Offset = "0x40AC870", VA = "0x1840ADA70", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x40ADAE0", Offset = "0x40AC8E0", VA = "0x1840ADAE0", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x40ADB40", Offset = "0x40AC940", VA = "0x1840ADB40", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3788A10", Offset = "0x3787810", VA = "0x183788A10", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public PIPBFKICBHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class APOGLAMFMPF<T> : MHAICNOOBIA<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x39AC540", Offset = "0x39AB340", VA = "0x1839AC540", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x39AC5B0", Offset = "0x39AB3B0", VA = "0x1839AC5B0", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x39AC610", Offset = "0x39AB410", VA = "0x1839AC610", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x361CE40", Offset = "0x361BC40", VA = "0x18361CE40", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public APOGLAMFMPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class IGPGDIFKJIM<T> : MHAICNOOBIA<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x387D510", Offset = "0x387C310", VA = "0x18387D510", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x387D580", Offset = "0x387C380", VA = "0x18387D580", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x387D5E0", Offset = "0x387C3E0", VA = "0x18387D5E0", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3875B40", Offset = "0x3874940", VA = "0x183875B40", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x361CFE0", Offset = "0x361BDE0", VA = "0x18361CFE0")]
		public IGPGDIFKJIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class BCBOJKDGEBN<T> : LNFNCEIHLEL<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x474F0A0", Offset = "0x474DEA0", VA = "0x18474F0A0", Slot = "12")]
		protected override void IDOHHKNLJFM(BHBCFHKPGCC LFPADPMEJPL, char JOEPKJOAOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x474F0D0", Offset = "0x474DED0", VA = "0x18474F0D0", Slot = "11")]
		protected override void JHLEFLDABHP(HMKCBIGIMHH HLPGBAHMLPL, [Out] char JOEPKJOAOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3293B80", Offset = "0x3292980", VA = "0x183293B80")]
		public BCBOJKDGEBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CBBPFIGABPK<T> : LNFNCEIHLEL<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D880", Offset = "0x4B7C680", VA = "0x184B7D880", Slot = "12")]
		protected override void IDOHHKNLJFM(BHBCFHKPGCC LFPADPMEJPL, IPEndPoint JOEPKJOAOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4B7D8B0", Offset = "0x4B7C6B0", VA = "0x184B7D8B0", Slot = "11")]
		protected override void JHLEFLDABHP(HMKCBIGIMHH HLPGBAHMLPL, [Out] IPEndPoint JOEPKJOAOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3293B80", Offset = "0x3292980", VA = "0x183293B80")]
		public CBBPFIGABPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class LFIPAHPFCJO<T> : MHAICNOOBIA<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int KHCCLFIIPDI;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C00650", Offset = "0x3BFF450", VA = "0x183C00650")]
		public LFIPAHPFCJO(int DDEIEHGBNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C00500", Offset = "0x3BFF300", VA = "0x183C00500", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C00570", Offset = "0x3BFF370", VA = "0x183C00570", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C005E0", Offset = "0x3BFF3E0", VA = "0x183C005E0", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C00490", Offset = "0x3BFF290", VA = "0x183C00490", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class HCPFEENJDFL<T> : EOCFAJBKELJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo CPGHLMCFDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type OENMHCILPLC;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3790490", Offset = "0x378F290", VA = "0x183790490")]
		public HCPFEENJDFL(PropertyInfo EIJAJNKHLMI, Type LFKKKBOGDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3790200", Offset = "0x378F000", VA = "0x183790200", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3790320", Offset = "0x378F120", VA = "0x183790320", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x37903D0", Offset = "0x378F1D0", VA = "0x1837903D0", Slot = "7")]
		public override void JLAAEBNFBFP(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x37901A0", Offset = "0x378EFA0", VA = "0x1837901A0", Slot = "8")]
		public override void BKPBPCDACBP(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3790430", Offset = "0x378F230", VA = "0x183790430", Slot = "9")]
		public override void MHEPANLNGDM(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x37902C0", Offset = "0x378F0C0", VA = "0x1837902C0", Slot = "10")]
		public override void GDDJEOLGAHF(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class IKEBKNJDJNB<T> : HCPFEENJDFL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x32AC270", Offset = "0x32AB070", VA = "0x1832AC270")]
		public IKEBKNJDJNB(PropertyInfo EIJAJNKHLMI, Type LFKKKBOGDHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x38994B0", Offset = "0x38982B0", VA = "0x1838994B0", Slot = "5")]
		public override void BLJDLJPIDLI(T JLMMMNHCIBO, HMKCBIGIMHH HLPGBAHMLPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3899570", Offset = "0x3898370", VA = "0x183899570", Slot = "6")]
		public override void IAJGBDBCFBH(T JLMMMNHCIBO, BHBCFHKPGCC LFPADPMEJPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class AKPABFJOIEL<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static AKPABFJOIEL<T> ACHMAPLCKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly EOCFAJBKELJ<T>[] PCLHBHGBJMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int HPEJAJAAAHF;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39A4720", Offset = "0x39A3520", VA = "0x1839A4720")]
		public AKPABFJOIEL(List<EOCFAJBKELJ<T>> EKBNIJLGIPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39A4670", Offset = "0x39A3470", VA = "0x1839A4670")]
		public void IAJGBDBCFBH(T KDHDNCADFDJ, BHBCFHKPGCC FCAJMDOFLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x39A45C0", Offset = "0x39A33C0", VA = "0x1839A45C0")]
		public void BLJDLJPIDLI(T KDHDNCADFDJ, HMKCBIGIMHH INLIFCPEGKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class FMNFINCDPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract EOCFAJBKELJ<T> MHEOMGMBJHC<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private BHBCFHKPGCC FKFICPOJGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int KEHPBNLNBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, FMNFINCDPOJ> DFOAOMJHJNP;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5583D80", Offset = "0x5582B80", VA = "0x185583D80")]
	public LHLEHBBAICD(int JGOKBELMJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x27F52F0", Offset = "0x27F40F0", VA = "0x1827F52F0")]
	private AKPABFJOIEL<T> FEGBDBOHFNK<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x27276C0", Offset = "0x27264C0", VA = "0x1827276C0")]
	public void GGPDGFKFIKF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x27F5210", Offset = "0x27F4010", VA = "0x1827F5210")]
	public bool APHAODHFANA<T>(HMKCBIGIMHH INLIFCPEGKK, T EOCODFIAJEL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x27F5290", Offset = "0x27F4090", VA = "0x1827F5290")]
	public void CDDFPMJNNJO<T>(BHBCFHKPGCC FCAJMDOFLNK, T KDHDNCADFDJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class BJDNKJJDNOE
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime OFCJPBDHJEF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GPNCEMPCBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MJAFNBHBHFN HMCHCHFMJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5579FF0", Offset = "0x5578DF0", VA = "0x185579FF0")]
		get
		{
			return default(MJAFNBHBHFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int KGOHLPBDJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x557A2B0", Offset = "0x55790B0", VA = "0x18557A2B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x557A020", Offset = "0x5578E20", VA = "0x18557A020")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FGOPELIFKJL FNJBAIPLHNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x557A2E0", Offset = "0x55790E0", VA = "0x18557A2E0")]
		get
		{
			return default(FGOPELIFKJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5579E90", Offset = "0x5578C90", VA = "0x185579E90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int OFGMFBGIFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5579E60", Offset = "0x5578C60", VA = "0x185579E60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint IEENGCLFLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x557A060", Offset = "0x5578E60", VA = "0x18557A060")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? JIGIIJLBEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x55796A0", Offset = "0x55784A0", VA = "0x1855796A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? DHDGNAHLNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5579F60", Offset = "0x5578D60", VA = "0x185579F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? LBNOKDIFKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x55798D0", Offset = "0x55786D0", VA = "0x1855798D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x557A310", Offset = "0x5579110", VA = "0x18557A310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? BDHHFFDKAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA86DC0", VA = "0x180A87FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8EE7A0", Offset = "0x8ED5A0", VA = "0x1808EE7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x557A5F0", Offset = "0x55793F0", VA = "0x18557A5F0")]
	public BJDNKJJDNOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x557A540", Offset = "0x5579340", VA = "0x18557A540")]
	internal BJDNKJJDNOE(byte[] HCFBAPHHICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5579580", Offset = "0x5578380", VA = "0x185579580")]
	public static BJDNKJJDNOE DBNDFHNAMCJ(byte[] HCFBAPHHICF, DateTime GCEOCDABGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5579C60", Offset = "0x5578A60", VA = "0x185579C60")]
	internal void GKNOAGKFJJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x557A0E0", Offset = "0x5578EE0", VA = "0x18557A0E0")]
	private void MNEHJEIBHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x55796D0", Offset = "0x55784D0", VA = "0x1855796D0")]
	private DateTime? ECENNFCBHMO(int LBJEFCOBKGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x55799C0", Offset = "0x55787C0", VA = "0x1855799C0")]
	private void FCCINGBNHBH(int LBJEFCOBKGF, DateTime? MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5579B90", Offset = "0x5578990", VA = "0x185579B90")]
	private ulong FGDJKACFOKF(int LBJEFCOBKGF)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5579900", Offset = "0x5578700", VA = "0x185579900")]
	private void FBGJLEFOFLP(int LBJEFCOBKGF, ulong MAEBFBHFPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5579ED0", Offset = "0x5578CD0", VA = "0x185579ED0")]
	private uint IENFDFHKCHL(int LBJEFCOBKGF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5444AF0", Offset = "0x54438F0", VA = "0x185444AF0")]
	private static uint JDAGMBGOGFJ(uint BJKAJHEJDMP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5579F90", Offset = "0x5578D90", VA = "0x185579F90")]
	private static ulong JDAGMBGOGFJ(ulong BJKAJHEJDMP)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum MJAFNBHBHFN
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
public enum FGOPELIFKJL
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class PJPFCIKAOJB
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int EHAEIJBKPOE = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int MODEHDDCKNK = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int EHJOPDKAHFD = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint KJGIBLGGNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int KEDFIICFJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int KMCHACNDMKE;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EAIEAFGPLME
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5587810", Offset = "0x5586610", VA = "0x185587810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5587820", Offset = "0x5586620", VA = "0x185587820")]
	public bool PMFCEBEMIIB(PKPDFJOHAKL DFONLDMKLDF, int EHBJJHHNHHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class CHENNALPLOL : PKPDFJOHAKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket DFONLDMKLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly BHIBDNBJMBL DGPAHDCNOCB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short DCGHCONHAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x557B4C0", Offset = "0x557A2C0", VA = "0x18557B4C0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HBMPICDBIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x557B4E0", Offset = "0x557A2E0", VA = "0x18557B4E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint NNCLCDNNADC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x557B390", Offset = "0x557A190", VA = "0x18557B390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily CGMEOGDMAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3BDB100", Offset = "0x3BD9F00", VA = "0x183BDB100", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x557BAC0", Offset = "0x557A8C0", VA = "0x18557BAC0")]
	public CHENNALPLOL(AddressFamily PEGGBJNKKCI, BHIBDNBJMBL DGPAHDCNOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x557B500", Offset = "0x557A300", VA = "0x18557B500", Slot = "8")]
	public bool OLELHAMEDFE(IPEndPoint POJPPPJHBHP, CKFOFPBJAOB DPJEJCACFFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x557B350", Offset = "0x557A150", VA = "0x18557B350", Slot = "9")]
	public int CLHEMFANEBB(byte[] LIICAAPCJGB, int LBJEFCOBKGF, int JEOEJJBKODC, IPEndPoint LBNNPHHGIHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x557B3B0", Offset = "0x557A1B0", VA = "0x18557B3B0", Slot = "10")]
	public int ENLNOCEEJBH(byte[] LIICAAPCJGB, EndPoint AMKGLBFFFFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x557B4A0", Offset = "0x557A2A0", VA = "0x18557B4A0", Slot = "11")]
	public void HCNDKFAGPEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface PKPDFJOHAKL
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short DCGHCONHAGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int HBMPICDBIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint NNCLCDNNADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily CGMEOGDMAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLELHAMEDFE(IPEndPoint POJPPPJHBHP, CKFOFPBJAOB DPJEJCACFFP);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CLHEMFANEBB(byte[] LIICAAPCJGB, int LBJEFCOBKGF, int JEOEJJBKODC, IPEndPoint LBNNPHHGIHO);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int ENLNOCEEJBH(byte[] LIICAAPCJGB, EndPoint LBNNPHHGIHO);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCNDKFAGPEP();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct KDFLPHAGIAF : IEquatable<KDFLPHAGIAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long APPGPEICPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long CHCLBOICKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long LLGCKLFGPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int CCJDGGCHPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int KJNLBFDCKFN;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x55836C0", Offset = "0x55824C0", VA = "0x1855836C0")]
	public KDFLPHAGIAF(byte[] AFNGGLCNEIN, int CPOBNFCOFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7E17A0", Offset = "0x7E05A0", VA = "0x1807E17A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5583680", Offset = "0x5582480", VA = "0x185583680", Slot = "4")]
	public bool Equals(KDFLPHAGIAF EDOEJIMPOFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x55835D0", Offset = "0x55823D0", VA = "0x1855835D0", Slot = "0")]
	public override bool Equals(object KDHDNCADFDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class EFNEJNBLLOI : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] HOKCLEPIOOF;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class HJEILOHEECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int BIJKCCIMNCA;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
	protected HJEILOHEECE(int EBODLAJFLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void EIKFFIJEEED(IPEndPoint POJPPPJHBHP, byte[] EEDANCJJEPL, int LBJEFCOBKGF, int AKCMMEDPGHB);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void PLLMNMFCOPF(IPEndPoint POJPPPJHBHP, byte[] EEDANCJJEPL, int LBJEFCOBKGF, int AKCMMEDPGHB);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IBGKPPHHPJL : HJEILOHEECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider HBAHGMEKGOK;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator HKIFIJPLPMF;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x557F1E0", Offset = "0x557DFE0", VA = "0x18557F1E0")]
	public IBGKPPHHPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x557E5A0", Offset = "0x557D3A0", VA = "0x18557E5A0")]
	public void AJJIHNMJJAD(IPEndPoint POJPPPJHBHP, byte[] ONOECNHBCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x557ED00", Offset = "0x557DB00", VA = "0x18557ED00")]
	public void PIEGFKKBKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x557EC70", Offset = "0x557DA70", VA = "0x18557EC70")]
	private byte[] JACIPCPCLAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x557E7E0", Offset = "0x557D5E0", VA = "0x18557E7E0", Slot = "4")]
	public override void EIKFFIJEEED(IPEndPoint POJPPPJHBHP, byte[] EEDANCJJEPL, int LBJEFCOBKGF, int AKCMMEDPGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x557EDE0", Offset = "0x557DBE0", VA = "0x18557EDE0", Slot = "5")]
	public override void PLLMNMFCOPF(IPEndPoint POJPPPJHBHP, byte[] EEDANCJJEPL, int LBJEFCOBKGF, int AKCMMEDPGHB)
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
