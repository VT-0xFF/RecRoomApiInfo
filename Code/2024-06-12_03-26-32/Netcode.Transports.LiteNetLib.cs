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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, DFODFHDDBEA
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JDFPPHPIINL
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
		private NetworkManager BGIDCENDPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, NFPOGMFBBKO> KKCEGNNHNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MMPHMAPNHBJ KAGEGAIOOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] NJNJCMNAIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JDFPPHPIINL FILDGCAGJFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong ILOJLHNNBDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool GKNIAGFIMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5D26EA0", Offset = "0x5D25AA0", VA = "0x185D26EA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5D263A0", Offset = "0x5D24FA0", VA = "0x185D263A0")]
		public void RecRoom_SetEncryptionInfo(ulong HFNJPBEHHFL, byte[] DPHIOKCFMFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5D26380", Offset = "0x5D24F80", VA = "0x185D26380")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D261F0", Offset = "0x5D24DF0", VA = "0x185D261F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D26DA0", Offset = "0x5D259A0", VA = "0x185D26DA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5D265A0", Offset = "0x5D251A0", VA = "0x185D265A0", Slot = "6")]
		public override void Send(ulong DCDOFODHOCA, ArraySegment<byte> IMCLGJBJJKP, NetworkDelivery NHNIMGHHCMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D26340", Offset = "0x5D24F40", VA = "0x185D26340", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong DCDOFODHOCA, [Out] ArraySegment<byte> FAPAFOGIGGO, [Out] float LAKEMOIHMOK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D26890", Offset = "0x5D25490", VA = "0x185D26890", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D26CC0", Offset = "0x5D258C0", VA = "0x185D26CC0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D25A40", Offset = "0x5D24640", VA = "0x185D25A40", Slot = "10")]
		public override void DisconnectRemoteClient(ulong DCDOFODHOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D258F0", Offset = "0x5D244F0", VA = "0x185D258F0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D25C90", Offset = "0x5D24890", VA = "0x185D25C90", Slot = "12")]
		public override ulong GetCurrentRtt(ulong DCDOFODHOCA)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D26820", Offset = "0x5D25420", VA = "0x185D26820", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5D25D30", Offset = "0x5D24930", VA = "0x185D25D30", Slot = "14")]
		public override void Initialize([Optional] NetworkManager BGIDCENDPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D25EF0", Offset = "0x5D24AF0", VA = "0x185D25EF0")]
		private LLLMHJJADAC LNBHICOPILB(NetworkDelivery NCNNODEFPOG)
		{
			return default(LLLMHJJADAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D256C0", Offset = "0x5D242C0", VA = "0x185D256C0", Slot = "15")]
		private void CNFEEOMBBDC(NFPOGMFBBKO NPGFADPHEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D25780", Offset = "0x5D24380", VA = "0x185D25780", Slot = "16")]
		private void CPIFFFJEKAI(NFPOGMFBBKO NPGFADPHEFM, CNJPHHCLEFM PCMFJMCHHFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "17")]
		private void HDEKJCLPFIN(IPEndPoint NOIIAAEGKDO, SocketError ANJLHENIONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D25FE0", Offset = "0x5D24BE0", VA = "0x185D25FE0", Slot = "18")]
		private void NKLECHHMGLL(NFPOGMFBBKO NPGFADPHEFM, EKJNGBNPGKE GGPHPLOPODB, byte ABEMAODNOPE, LLLMHJJADAC BLFNMBHFJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5D25BB0", Offset = "0x5D247B0", VA = "0x185D25BB0")]
		private void FFFPIJJJNKK(int AEOJMEBJNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "19")]
		private void IBDFDMKMJOO(IPEndPoint FCHBKDDIEFN, EKJNGBNPGKE GGPHPLOPODB, NLIJOGBGPHK CMBJJGDNGGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "20")]
		private void DNOBMDONOEP(NFPOGMFBBKO NPGFADPHEFM, int DGIEPFCJPHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5D262E0", Offset = "0x5D24EE0", VA = "0x185D262E0", Slot = "21")]
		private void PGAOCADODCI(PJBODKNNIHI CLBGLGJCBEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5D258C0", Offset = "0x5D244C0", VA = "0x185D258C0")]
		private ulong DAMAICNNEGG(NFPOGMFBBKO NPGFADPHEFM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D25FC0", Offset = "0x5D24BC0", VA = "0x185D25FC0")]
		private static int MOFOCGNGMBP(float EACMJFLDLDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D26DC0", Offset = "0x5D259C0", VA = "0x185D26DC0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class GGGCFLLCBAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NFPOGMFBBKO DAAONOBJOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<AIHNKGMLOJH> COECGBJGMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int PKLELFNBOEB;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D238B0", Offset = "0x5D224B0", VA = "0x185D238B0")]
	protected GGGCFLLCBAH(NFPOGMFBBKO NPGFADPHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D23850", Offset = "0x5D22450", VA = "0x185D23850")]
	public void KMCLBCMMPHP(AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D23790", Offset = "0x5D22390", VA = "0x185D23790")]
	protected void BOEMJBANDII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D23810", Offset = "0x5D22410", VA = "0x185D23810")]
	public bool EFFCNLIHNLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool CGGDAMLBJFK();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool OKDFANBMJMK(AIHNKGMLOJH JOIDOIOECKI);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum NPMHMOFCEIF
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
public class PJBODKNNIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MMPHMAPNHBJ OIJHBCDINAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int HNIJOEGCGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal PGHFFAIILII MOCKOMOHNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint GGAEIFPDJIA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal NPMHMOFCEIF IJJBKBIAPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86B860", Offset = "0x86A460", VA = "0x18086B860")]
		[CompilerGenerated]
		get
		{
			return default(NPMHMOFCEIF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB7890", Offset = "0xAB6490", VA = "0x180AB7890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D33BF0", Offset = "0x5D327F0", VA = "0x185D33BF0")]
	internal void NBHDDHMPCMO(PGHFFAIILII MEAKIDCAOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D33C50", Offset = "0x5D32850", VA = "0x185D33C50")]
	private bool NBMENHPPCNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D33C80", Offset = "0x5D32880", VA = "0x185D33C80")]
	internal PJBODKNNIHI(IPEndPoint FCHBKDDIEFN, PGHFFAIILII NDOBKLHLECH, MMPHMAPNHBJ COPPJILPFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D33B90", Offset = "0x5D32790", VA = "0x185D33B90")]
	public NFPOGMFBBKO HFNEOIKLOCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NLIJOGBGPHK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum IHBDADNGCLP
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
public struct CNJPHHCLEFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public IHBDADNGCLP BHCBEJDONFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError HPKHHLHHPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public EKJNGBNPGKE CPPHBNOICHI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DFODFHDDBEA
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KILKAKKANOD(NFPOGMFBBKO NPGFADPHEFM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPJOHPKBCFK(NFPOGMFBBKO NPGFADPHEFM, CNJPHHCLEFM PCMFJMCHHFF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MMEKBAGJBKL(IPEndPoint NOIIAAEGKDO, SocketError ANJLHENIONH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHOIAGIJOPF(NFPOGMFBBKO NPGFADPHEFM, EKJNGBNPGKE GGPHPLOPODB, byte ABEMAODNOPE, LLLMHJJADAC BLFNMBHFJIG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HFJPKNMALLA(IPEndPoint FCHBKDDIEFN, EKJNGBNPGKE GGPHPLOPODB, NLIJOGBGPHK CMBJJGDNGGE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DIINCAEEDOD(NFPOGMFBBKO NPGFADPHEFM, int DGIEPFCJPHC);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJBGCGFFMGJ(PJBODKNNIHI CLBGLGJCBEB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NPALNDBCDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIBGIIHJIIG(NFPOGMFBBKO NPGFADPHEFM, object BNKNOLMDOIM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KIPCHFHAEAD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKPFEJOLGMO(GNCJKAOMMBH JOIDOIOECKI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LAAIBLNPFAO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELCGDHACLEJ(NFPOGMFBBKO NPGFADPHEFM, IPEndPoint EFEKNGONHFB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PGHFFAIILII
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int DFBFIMOMEGJ = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long GBPDEOHGLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte DGCDDAIMNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] KHKAALGPKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly BDCLBPBAMKO JLODENNJHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int BOOILGCICDG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D33B20", Offset = "0x5D32720", VA = "0x185D33B20")]
	private PGHFFAIILII(long DHDAFOBDMFA, byte FLMHGEBFKFH, int FFODPEFFKPK, byte[] KHGHEIPGKDL, BDCLBPBAMKO IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D338E0", Offset = "0x5D324E0", VA = "0x185D338E0")]
	public static int IBBLAJCHLKA(AIHNKGMLOJH JOIDOIOECKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D336C0", Offset = "0x5D322C0", VA = "0x185D336C0")]
	public static PGHFFAIILII GIAANNHODEO(AIHNKGMLOJH JOIDOIOECKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D33940", Offset = "0x5D32540", VA = "0x185D33940")]
	public static AIHNKGMLOJH NINJDMKNNPG(EEHIFILIEEP MOJPPNPOHOO, SocketAddress PNLHEOHEBIN, long JMIDDAEINOH, int FFODPEFFKPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class PFELDBJOEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long GBPDEOHGLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte DGCDDAIMNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int BOOILGCICDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool JJHGHGEKBOA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D33670", Offset = "0x5D32270", VA = "0x185D33670")]
	private PFELDBJOEPA(long DHDAFOBDMFA, byte FLMHGEBFKFH, int PBBNGBHIGLC, bool EIFNKHAGAPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D33330", Offset = "0x5D31F30", VA = "0x185D33330")]
	public static PFELDBJOEPA GIAANNHODEO(AIHNKGMLOJH JOIDOIOECKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D33580", Offset = "0x5D32180", VA = "0x185D33580")]
	public static AIHNKGMLOJH NINJDMKNNPG(long JMIDDAEINOH, byte FEPPIKKJKON, int EBFOJMNDBDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D33480", Offset = "0x5D32080", VA = "0x185D33480")]
	public static AIHNKGMLOJH ILCBNJMKNOB(NFPOGMFBBKO NPGFADPHEFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum PMHLAAIGHBM
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PJBAFJELHJF
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNFEPKCBIKE(IPEndPoint KCEDOMEFJFP, IPEndPoint FCHBKDDIEFN, string FGIAGALCIAP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGLOPHFPNIH(IPEndPoint OHCFPEHAFMP, PMHLAAIGHBM NCNNODEFPOG, string FGIAGALCIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PDPCOEIGOAB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct COADIEAKIPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint KLCBJPJPKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint GGAEIFPDJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string DENFOMHEOCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DHBLGAAJGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint MNPKOMADFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PMHLAAIGHBM AJCKJIKGPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string DENFOMHEOCD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class EGLPIKGBFHB
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint JHAGLAEAONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string DENFOMHEOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EGLPIKGBFHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class OKCKDDANPKH
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint JHAGLAEAONH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint MGEEBOJHPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string DENFOMHEOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public OKCKDDANPKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KMBGNEKKCED
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DENFOMHEOCD
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DDPIAIGIBEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x852F20", Offset = "0x851B20", VA = "0x180852F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public KMBGNEKKCED()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MMPHMAPNHBJ NIFBJJEBAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<COADIEAKIPD> JGANGOINDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<DHBLGAAJGHA> JLIIHLKBANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BDCLBPBAMKO KDMHCHFHAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EEHIFILIEEP HECEIMNPCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ALFBIHMHIPL LMJOFELFNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private PJBAFJELHJF PNLJFFEJGIA;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LLDCODKBMPN = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool JCDDABAAINN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D32EE0", Offset = "0x5D31AE0", VA = "0x185D32EE0")]
	internal PDPCOEIGOAB(MMPHMAPNHBJ FCEKADCKKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D32A90", Offset = "0x5D31690", VA = "0x185D32A90")]
	internal void GFLMKAHJLOD(IPEndPoint EGAGEJIIHPG, AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2CE76E0", Offset = "0x2CE62E0", VA = "0x182CE76E0")]
	private void KOAEOCAGPCE<T>(T JOIDOIOECKI, IPEndPoint PJIFCLGMLOL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D32D50", Offset = "0x5D31950", VA = "0x185D32D50")]
	private void NNFEPKCBIKE(EGLPIKGBFHB LONCLCJENDI, IPEndPoint EGAGEJIIHPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D32BF0", Offset = "0x5D317F0", VA = "0x185D32BF0")]
	private void LDGGAGDIIMH(OKCKDDANPKH LONCLCJENDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D328F0", Offset = "0x5D314F0", VA = "0x185D328F0")]
	private void ENJDOEJKKHF(KMBGNEKKCED LONCLCJENDI, IPEndPoint EGAGEJIIHPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum LLLMHJJADAC : byte
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
public enum LIEKLFGDHPO : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BPHIGIAEHPN
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] GEFNHOMALGD;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int LPEJGLPKCNM;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int AKBNGEFMGGN;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EINPENONNOG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D23570", Offset = "0x5D22170", VA = "0x185D23570")]
	public EINPENONNOG(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FJMGJJMHCIN : EINPENONNOG
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5D23570", Offset = "0x5D22170", VA = "0x185D23570")]
	public FJMGJJMHCIN(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EJNEAMELOKB
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
public interface GCFGCMJJBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AADIBADBAAH(EJNEAMELOKB EMCEGDJKOFF, string OGFFIPCKAML, params object[] LLJCEPGKLEC);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MMKEFHGMPHA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static GCFGCMJJBPI EMEILDKFNFD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object AHOBOFMHEMJ;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5D27520", Offset = "0x5D26120", VA = "0x185D27520")]
	private static void HKEGIHPHHKI(EJNEAMELOKB NBEAAKAJDIB, string OGFFIPCKAML, params object[] LLJCEPGKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D277B0", Offset = "0x5D263B0", VA = "0x185D277B0")]
	internal static void KCKBBFBDOAD(string OGFFIPCKAML, params object[] LLJCEPGKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D27750", Offset = "0x5D26350", VA = "0x185D27750")]
	internal static void JLBNMGNLPHB(string OGFFIPCKAML, params object[] LLJCEPGKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D274C0", Offset = "0x5D260C0", VA = "0x185D274C0")]
	internal static void CIFAHDKPDFA(string OGFFIPCKAML, params object[] LLJCEPGKLEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum CPCADCHGGLL
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class EKJNGBNPGKE : BDCLBPBAMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private AIHNKGMLOJH IHCPFBBDDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MMPHMAPNHBJ JGDHBFFMBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly EILMPLKDPPC BCFLGPGHPIM;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D236A0", Offset = "0x5D222A0", VA = "0x185D236A0")]
	internal EKJNGBNPGKE(MMPHMAPNHBJ DJIBBLNPCFA, EILMPLKDPPC LOMPNKHHHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D23630", Offset = "0x5D22230", VA = "0x185D23630")]
	internal void PCAKICBLLGI(AIHNKGMLOJH JOIDOIOECKI, int CAOKGLIJAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D235B0", Offset = "0x5D221B0", VA = "0x185D235B0")]
	internal void NHACJJILJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D23580", Offset = "0x5D22180", VA = "0x185D23580")]
	public void DHJCJEBDPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class EILMPLKDPPC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum AGFEEDHMPCK
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
	public EILMPLKDPPC FKLDIJDCIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public AGFEEDHMPCK AJCKJIKGPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NFPOGMFBBKO DAAONOBJOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint GGAEIFPDJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object CHNEDDPPNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int OMIFACIABOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError HNPAIAAMNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IHBDADNGCLP GEAOJIBOJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public PJBODKNNIHI HGJJDLHBKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public LLLMHJJADAC HCPILHLNBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte GPGJHMCNCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly EKJNGBNPGKE NEJBOLGJNAJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D234D0", Offset = "0x5D220D0", VA = "0x185D234D0")]
	public EILMPLKDPPC(MMPHMAPNHBJ DJIBBLNPCFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MMPHMAPNHBJ : IEnumerable<NFPOGMFBBKO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class LGPFHHMFEBN : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D25650", Offset = "0x5D24250", VA = "0x185D25650", Slot = "4")]
		public bool Equals(IPEndPoint KNFDPFPHEON, IPEndPoint EFBKAEHLBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5801DB0", Offset = "0x58009B0", VA = "0x185801DB0", Slot = "5")]
		public int GetHashCode(IPEndPoint HAHECKLGOJC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public LGPFHHMFEBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct FCCAAMILHFD : IEnumerator<NFPOGMFBBKO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly NFPOGMFBBKO EGHGFILCEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private NFPOGMFBBKO EAHLKDLAJIP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public NFPOGMFBBKO KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8B4DA0", Offset = "0x8B39A0", VA = "0x1808B4DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x10BFA60", Offset = "0x10BE660", VA = "0x1810BFA60")]
		public FCCAAMILHFD(NFPOGMFBBKO GEBOGBKBFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5D236F0", Offset = "0x5D222F0", VA = "0x185D236F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5D23740", Offset = "0x5D22340", VA = "0x185D23740", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread HGJBIMBLJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool KCEIKNEIPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent CMCMJIGFKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<EILMPLKDPPC> DEBOAAGDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<EILMPLKDPPC> INJCBAIPMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private EILMPLKDPPC KPCFPFKPNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DFODFHDDBEA PCFHFCODINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly NPALNDBCDKK FEPHCJPFJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly KIPCHFHAEAD CCPABDBDKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LAAIBLNPFAO FLEKMMFGNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, NFPOGMFBBKO> KDKIHDDJHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, PJBODKNNIHI> EHFPGBHLOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, JNHDFJNOINM> GFFGBJBDICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim ILJFBKIJBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NFPOGMFBBKO BFLFOJJOOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int JEIFLFPKEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<NFPOGMFBBKO> EOFBBMEGKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NFPOGMFBBKO[] HLFCLBMFNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly EEELNGBAALN ADIKKDPLBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int BGFMJJNJBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> BKDCJCEBCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte AEGOIANMEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object KEIEKCGBGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool BCPOIBBKAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool GOFGNDHLEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int ECDHHJPPLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int LOKCKFKJIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OOBKNGBNIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int LHHGDJKOGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool KOFJDADPBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BGAGDKANHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int GCAOCKNJFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int JLEJNOGIAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int BOHICPAJGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool JCDDABAAINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool DFDPHOPNLOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool AHOCKMNMBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool LGFIODAHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int ANFOKHLLJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int DOMOEMNAGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EHPCCDFNDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly MKNBGJACFFN PBDKBEFJADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool MBLCHPLBHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly PDPCOEIGOAB DIEOIFOHKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EHALBDFDFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public CPCADCHGGLL LGFLIKDJJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int DDKBJFMLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool HCBKKLPAIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FHOGGPEHFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OCMCLFJEIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool LLFHJBFGDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private AIHNKGMLOJH NKFLADCDMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int FELADOADGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object KAHGNLMKDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AIHNKGMLOJH NNNGJJBPANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int AIOEPJGCCCI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int JBMEPFHKOPA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int FPBHHIFPBML = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BBMEBEKLFAO FCJKHGCKEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private BBMEBEKLFAO HDCNEMFLCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread FGCLMPPIICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread OICDBILLEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint GLNHGGMEJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint MBPBJMIEDNA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] HOBDHFKMPEJ;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] KGPILHMJGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<CLCNLBIIMFM, IPEndPoint> ENKDBOIGPOH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress GHCMGHDMPPM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool NCPECIMGCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int EOAJIDCFBAH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool FBFEKFLCBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xBC05F0", Offset = "0xBBF1F0", VA = "0x180BC05F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xC6FCA0", Offset = "0xC6E8A0", VA = "0x180C6FCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LIDMMCPDAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14B8F70", Offset = "0x14B7B70", VA = "0x1814B8F70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x17E0D20", Offset = "0x17DF920", VA = "0x1817E0D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte LAIFANAJJMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA257D0", Offset = "0xA243D0", VA = "0x180A257D0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HFNLAAOMCHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A7B0", Offset = "0x5D293B0", VA = "0x185D2A7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short NLBPAEMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B1B0", Offset = "0x5D29DB0", VA = "0x185D2B1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D7F0", Offset = "0x5D2C3F0", VA = "0x185D2D7F0")]
	public void OODOGIIIOPD(IPEndPoint NOIIAAEGKDO, byte[] DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B9E0", Offset = "0x5D2A5E0", VA = "0x185D2B9E0")]
	public void MNFPEIIDDEF(IPEndPoint NOIIAAEGKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D27DF0", Offset = "0x5D269F0", VA = "0x185D27DF0")]
	private bool BKOLNMLIECB(IPEndPoint NOIIAAEGKDO, [Out] NFPOGMFBBKO NPGFADPHEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B720", Offset = "0x5D2A320", VA = "0x185D2B720")]
	private void MKOOHLDOOMA(NFPOGMFBBKO NPGFADPHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD60", Offset = "0x5D29960", VA = "0x185D2AD60")]
	private void JKJMHIMBPBI(NFPOGMFBBKO NPGFADPHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AE90", Offset = "0x5D29A90", VA = "0x185D2AE90")]
	private void KIILCKLABAP(NFPOGMFBBKO NPGFADPHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E230", Offset = "0x5D2CE30", VA = "0x185D2E230")]
	public MMPHMAPNHBJ(DFODFHDDBEA COPPJILPFFC, [Optional] EEELNGBAALN LMDDPECFHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A760", Offset = "0x5D29360", VA = "0x185D2A760")]
	internal void FNCDGGCDEMF(NFPOGMFBBKO CFLJHNIBHFA, int DGIEPFCJPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5D28EE0", Offset = "0x5D27AE0", VA = "0x185D28EE0")]
	internal void DBKHDOKPGON(NFPOGMFBBKO CFLJHNIBHFA, object BNKNOLMDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B0E0", Offset = "0x5D29CE0", VA = "0x185D2B0E0")]
	internal void KLOLFKBONOO(NFPOGMFBBKO NPGFADPHEFM, IHBDADNGCLP BGLFCJCCBPJ, SocketError FKHGBICBACL, AIHNKGMLOJH JFEELHKEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5D296A0", Offset = "0x5D282A0", VA = "0x185D296A0")]
	private void DIPMELNCFCG(NFPOGMFBBKO NPGFADPHEFM, IHBDADNGCLP BGLFCJCCBPJ, SocketError FKHGBICBACL, bool NDHMLIPBMEM, byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int HDFABDCMCAG, AIHNKGMLOJH JFEELHKEMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D430", Offset = "0x5D2C030", VA = "0x185D2D430")]
	private void OMJGFOOMLHI(EILMPLKDPPC.AGFEEDHMPCK NCNNODEFPOG, [Optional] NFPOGMFBBKO NPGFADPHEFM, [Optional] IPEndPoint FCHBKDDIEFN, SocketError PFGMABBCMAM = SocketError.Success, int DGIEPFCJPHC = 0, IHBDADNGCLP ENKLDBDBNLK = IHBDADNGCLP.ConnectionFailed, [Optional] PJBODKNNIHI HCDNMNHHOPC, LLLMHJJADAC BLFNMBHFJIG = LLLMHJJADAC.Unreliable, byte ABEMAODNOPE = 0, [Optional] AIHNKGMLOJH DGDKHKJPODC, [Optional] object BNKNOLMDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D29780", Offset = "0x5D28380", VA = "0x185D29780")]
	private void EAFPLFALICL(EILMPLKDPPC LOMPNKHHHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D28310", Offset = "0x5D26F10", VA = "0x185D28310")]
	internal void CBOFJDLMOFB(EILMPLKDPPC LOMPNKHHHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D28410", Offset = "0x5D27010", VA = "0x185D28410")]
	private void CEIKPNBONKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D29F50", Offset = "0x5D28B50", VA = "0x185D29F50")]
	private void EBIBKADMHAO(int PAFMJCJFLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D28750", Offset = "0x5D27350", VA = "0x185D28750")]
	internal NFPOGMFBBKO CHLDEJICDIM(PJBODKNNIHI CLBGLGJCBEB, byte[] ODKNMICCGDD, int BGCAJHMJIFE, int JKBHNDINMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A410", Offset = "0x5D29010", VA = "0x185D2A410")]
	private int FDJJNFPHMNP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DBF0", Offset = "0x5D2C7F0", VA = "0x185D2DBF0")]
	private void POLCNJBALGA(IPEndPoint FCHBKDDIEFN, NFPOGMFBBKO DINPDJOGHGF, PGHFFAIILII BCGPPCJCDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C5F0", Offset = "0x5D2B1F0", VA = "0x185D2C5F0")]
	private void ODNFAMAACHL(AIHNKGMLOJH JOIDOIOECKI, IPEndPoint FCHBKDDIEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5D27E80", Offset = "0x5D26A80", VA = "0x185D27E80")]
	internal void BNEGKFICBAM(AIHNKGMLOJH JOIDOIOECKI, LLLMHJJADAC AEGDCAADINA, byte ABEMAODNOPE, int CAOKGLIJAOL, NFPOGMFBBKO CFLJHNIBHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BBD0", Offset = "0x5D2A7D0", VA = "0x185D2BBD0")]
	public bool NBMNJOJAEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BB30", Offset = "0x5D2A730", VA = "0x185D2BB30")]
	public bool NBMNJOJAEEO(IPAddress GLDDNAHBGHK, IPAddress CPACGLGOACF, int GBDBCEHCEOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BB50", Offset = "0x5D2A750", VA = "0x185D2BB50")]
	public bool NBMNJOJAEEO(int GBDBCEHCEOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A270", Offset = "0x5D28E70", VA = "0x185D2A270")]
	public void EDJHJDEKNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A8B0", Offset = "0x5D294B0", VA = "0x185D2A8B0")]
	public NFPOGMFBBKO IMNIIHLAOFM(string FJCEHPOBJJD, int GBDBCEHCEOE, string DPHIOKCFMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A7D0", Offset = "0x5D293D0", VA = "0x185D2A7D0")]
	public NFPOGMFBBKO IMNIIHLAOFM(string FJCEHPOBJJD, int GBDBCEHCEOE, EEHIFILIEEP FBLCCKCCAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A990", Offset = "0x5D29590", VA = "0x185D2A990")]
	public NFPOGMFBBKO IMNIIHLAOFM(IPEndPoint PJIFCLGMLOL, EEHIFILIEEP FBLCCKCCAEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DBE0", Offset = "0x5D2C7E0", VA = "0x185D2DBE0")]
	public void PMLHLALIMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D890", Offset = "0x5D2C490", VA = "0x185D2D890")]
	public void PMLHLALIMBP(bool NOJFMACOKMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B4A0", Offset = "0x5D2A0A0", VA = "0x185D2B4A0")]
	public void MEOFJAPBEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B5A0", Offset = "0x5D2A1A0", VA = "0x185D2B5A0")]
	public void MEOFJAPBEAD(byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D29530", Offset = "0x5D28130", VA = "0x185D29530")]
	public void DIPMELNCFCG(NFPOGMFBBKO NPGFADPHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D295E0", Offset = "0x5D281E0", VA = "0x185D295E0")]
	public void DIPMELNCFCG(NFPOGMFBBKO NPGFADPHEFM, byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E050", Offset = "0x5D2CC50", VA = "0x185D2E050", Slot = "4")]
	private IEnumerator<NFPOGMFBBKO> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E0E0", Offset = "0x5D2CCE0", VA = "0x185D2E0E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5D28140", Offset = "0x5D26D40", VA = "0x185D28140")]
	private AIHNKGMLOJH BNPCIIGFCFB(NHCPOJPCBBP LKOIJCCHEHO, int AEOJMEBJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5D28230", Offset = "0x5D26E30", VA = "0x185D28230")]
	private AIHNKGMLOJH BNPCIIGFCFB(NHCPOJPCBBP LKOIJCCHEHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B270", Offset = "0x5D29E70", VA = "0x185D2B270")]
	internal AIHNKGMLOJH LAAPFOKJAEK(int AEOJMEBJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C390", Offset = "0x5D2AF90", VA = "0x185D2C390")]
	internal void NHOAKEFJDGJ(AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E170", Offset = "0x5D2CD70", VA = "0x185D2E170")]
	static MMPHMAPNHBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xBC05F0", Offset = "0xBBF1F0", VA = "0x180BC05F0")]
	private bool KLEOOCIKEIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D340", Offset = "0x5D2BF40", VA = "0x185D2D340")]
	private void OLECLHDPJKE(IPEndPoint MMCKCFIHEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D2ADB0", Offset = "0x5D299B0", VA = "0x185D2ADB0")]
	private void KGAOEJCHCEO(IPEndPoint MMCKCFIHEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D278C0", Offset = "0x5D264C0", VA = "0x185D278C0")]
	private bool AAJENMHNMBE(SocketException JNLFEIJKPEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A490", Offset = "0x5D29090", VA = "0x185D2A490")]
	private void FKOMHPNBNAM(BBMEBEKLFAO FCEKADCKKIC, EndPoint OJOPLLFHDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D27A60", Offset = "0x5D26660", VA = "0x185D27A60")]
	private void ADCMKPPDELM(object GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BBE0", Offset = "0x5D2A7E0", VA = "0x185D2BBE0")]
	public bool NBMNJOJAEEO(IPAddress GLDDNAHBGHK, IPAddress CPACGLGOACF, int GBDBCEHCEOE, bool KPAHJPJBICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B6C0", Offset = "0x5D2A2C0", VA = "0x185D2B6C0")]
	internal int MGPHEIPLGKG(AIHNKGMLOJH JOIDOIOECKI, IPEndPoint FCHBKDDIEFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5D294F0", Offset = "0x5D280F0", VA = "0x185D294F0")]
	internal int DENOMHPCFKM(AIHNKGMLOJH JOIDOIOECKI, IPEndPoint FCHBKDDIEFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5D28F30", Offset = "0x5D27B30", VA = "0x185D28F30")]
	internal int DENOMHPCFKM(byte[] JIMAFLGJGFB, int BGCAJHMJIFE, int JKBHNDINMGD, IPEndPoint FCHBKDDIEFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5D28D70", Offset = "0x5D27970", VA = "0x185D28D70")]
	internal void CIOAFHBNMFO(bool KIPDDNLNAEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum NHCPOJPCBBP : byte
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
internal sealed class AIHNKGMLOJH
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int PPKIJGEBCPO;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] CKOBBIHIOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] GLCJEMGIGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int LBOCLAHFPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object CHNEDDPPNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public AIHNKGMLOJH FKLDIJDCIAH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NHCPOJPCBBP CPGIIMJBFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E930", Offset = "0x5D1D530", VA = "0x185D1E930")]
		get
		{
			return default(NHCPOJPCBBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E8F0", Offset = "0x5D1D4F0", VA = "0x185D1E8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte DGCDDAIMNKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E8C0", Offset = "0x5D1D4C0", VA = "0x185D1E8C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EA60", Offset = "0x5D1D660", VA = "0x185D1EA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort CHJFLNKMJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EA00", Offset = "0x5D1D600", VA = "0x185D1EA00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E960", Offset = "0x5D1D560", VA = "0x185D1E960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FDLOKHFFEHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EC80", Offset = "0x5D1D880", VA = "0x185D1EC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte EMBDLDGCGGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EB50", Offset = "0x5D1D750", VA = "0x185D1EB50")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ECF0", Offset = "0x5D1D8F0", VA = "0x185D1ECF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort AGPPOJCLBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EE20", Offset = "0x5D1DA20", VA = "0x185D1EE20")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EAD0", Offset = "0x5D1D6D0", VA = "0x185D1EAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort HEPKMMLNPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EE80", Offset = "0x5D1DA80", VA = "0x185D1EE80")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ECB0", Offset = "0x5D1D8B0", VA = "0x185D1ECB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort AHFLCEGEFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E9A0", Offset = "0x5D1D5A0", VA = "0x185D1E9A0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EB10", Offset = "0x5D1D710", VA = "0x185D1EB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EEE0", Offset = "0x5D1DAE0", VA = "0x185D1EEE0")]
	static AIHNKGMLOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EAA0", Offset = "0x5D1D6A0", VA = "0x185D1EAA0")]
	public void JGGACNIHEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F1C0", Offset = "0x5D1DDC0", VA = "0x185D1F1C0")]
	public AIHNKGMLOJH(int AEOJMEBJNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F230", Offset = "0x5D1DE30", VA = "0x185D1F230")]
	public AIHNKGMLOJH(NHCPOJPCBBP LKOIJCCHEHO, int AEOJMEBJNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EB80", Offset = "0x5D1D780", VA = "0x185D1EB80")]
	public static int LLLICNMJHPL(NHCPOJPCBBP LKOIJCCHEHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EBF0", Offset = "0x5D1D7F0", VA = "0x185D1EBF0")]
	public int LLLICNMJHPL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ED20", Offset = "0x5D1D920", VA = "0x185D1ED20")]
	public bool OANKPECCLIF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum NBEGDIHBOOI : byte
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
internal enum LBAHAHJFLBJ
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
internal enum ELHABHLMECL
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum HNHANIAIECB
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NFPOGMFBBKO
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GOOEJGAFPPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AIHNKGMLOJH[] LECMJHPAAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int GNPGOFKEMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int HACBAMBDJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte EMBDLDGCGGM;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public GOOEJGAFPPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void MDMKJMNPCDL(ulong HABLDJOCHHB, int IFLOMDADBAL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int INCBINMNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int FNFFPOODPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int BFHDFMCHDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double FGAFCAFLOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int EGAGOGNPKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int DJAGPBHPHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int BBBFJNHNDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch HOBCOFMDGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int DBGFICBBPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long AIJEKFGCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object GDMDOLEHGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal NFPOGMFBBKO GHEFJHPHGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal NFPOGMFBBKO HIODHJMNAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<AIHNKGMLOJH> KDLGFNCEMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<GGGCFLLCBAH> FCNGLHCJMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly GGGCFLLCBAH[] FBODKNCNOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int AOLLJNCOABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int IAENINCKPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool LBIILNIBMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int CBIADAENPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int ACNOKHGMCOD;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CNGCCGIPLBA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int NAFFMANJLPJ = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object DGBLIKDBPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int ELJBLKCLNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GOOEJGAFPPF> GOOOLFCNBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> BNECPJMPEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly AIHNKGMLOJH ADHNGPBAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int KGGHJMGLPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int FHOMDHIHJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint PAFOFLHMOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int BAKKLDPBJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int EMIGMFKAAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long DEJDMPHKMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte FOIOMMLOKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NBEGDIHBOOI GKKCCPPKLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private AIHNKGMLOJH EFFJFIKGKGL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int EINFHEAFENP = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JEONIOCIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly AIHNKGMLOJH CIHBODKBEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly AIHNKGMLOJH ABECPADGFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly AIHNKGMLOJH PKAECCGGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly AIHNKGMLOJH AMPHPMHDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private LIEKLFGDHPO AGMPFFHJCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly MMPHMAPNHBJ NNHOPBFOAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int CCJJLJNMAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object KICMNPDJCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly MKNBGJACFFN PBDKBEFJADO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte BGFNKEBDMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC03230", Offset = "0xC01E30", VA = "0x180C03230")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D309B0", Offset = "0x5D2F5B0", VA = "0x185D309B0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint BHPLNHDDMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A40", Offset = "0x8AF640", VA = "0x1808B0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NBEGDIHBOOI NNOBBOPLEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x12EEEC0", Offset = "0x12EDAC0", VA = "0x1812EEEC0")]
		get
		{
			return default(NBEGDIHBOOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long EELDEBLAJKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x850730", Offset = "0x84F330", VA = "0x180850730")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NNHGKAHMHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCD2190", Offset = "0xCD0D90", VA = "0x180CD2190")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x15BE690", Offset = "0x15BD290", VA = "0x1815BE690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int MBHFNLDHPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F660", Offset = "0x5D2E260", VA = "0x185D2F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JFLNANCEHEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x853470", Offset = "0x852070", VA = "0x180853470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double EEODNHHNEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1A3DF40", Offset = "0x1A3CB40", VA = "0x181A3DF40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MDMKJMNPCDL OHCJPGEOKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FD80", Offset = "0x5D2E980", VA = "0x185D2FD80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D31730", Offset = "0x5D30330", VA = "0x185D31730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D32490", Offset = "0x5D31090", VA = "0x185D32490")]
	internal NFPOGMFBBKO(MMPHMAPNHBJ GMNBHCIECHB, IPEndPoint FCHBKDDIEFN, int EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F530", Offset = "0x5D2E130", VA = "0x185D2F530")]
	internal void DPPHLFJKHJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F550", Offset = "0x5D2E150", VA = "0x185D2F550")]
	internal void EKDPHDECOBI(IPEndPoint DCNMNFCOBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E880", Offset = "0x5D2D480", VA = "0x185D2E880")]
	internal void BCFNOPPJDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E90", Offset = "0x5D30A90", VA = "0x185D31E90")]
	private void OLFMDFBCGDF(int JNPJMLDLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD40", Offset = "0x5D2E940", VA = "0x185D2FD40")]
	private void IHDIDMDONHD(int LPGGFGPCEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D30800", Offset = "0x5D2F400", VA = "0x185D30800")]
	private GGGCFLLCBAH LLIGNKINDGN(byte BIIBCGDMKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D32120", Offset = "0x5D30D20", VA = "0x185D32120")]
	internal NFPOGMFBBKO(MMPHMAPNHBJ GMNBHCIECHB, IPEndPoint FCHBKDDIEFN, int EPKGPGILADI, byte FEPPIKKJKON, EEHIFILIEEP MOJPPNPOHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5D322B0", Offset = "0x5D30EB0", VA = "0x185D322B0")]
	internal NFPOGMFBBKO(MMPHMAPNHBJ GMNBHCIECHB, PJBODKNNIHI CLBGLGJCBEB, int EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EEE0", Offset = "0x5D2DAE0", VA = "0x185D2EEE0")]
	internal void CODLHBOMFOC(PGHFFAIILII GHBCJDANLAN, byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D316B0", Offset = "0x5D302B0", VA = "0x185D316B0")]
	internal bool OAJEKLPEOKP(PFELDBJOEPA JOIDOIOECKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FE30", Offset = "0x5D2EA30", VA = "0x185D2FE30")]
	public void KOAEOCAGPCE(byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int JKBHNDINMGD, LLLMHJJADAC MMOLNDGHCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EF30", Offset = "0x5D2DB30", VA = "0x185D2EF30")]
	private void DDDJCFLOMMM(byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int JKBHNDINMGD, byte ABEMAODNOPE, LLLMHJJADAC BLFNMBHFJIG, object BNKNOLMDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F480", Offset = "0x5D2E080", VA = "0x185D2F480")]
	public void DNLKPDBBDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F580", Offset = "0x5D2E180", VA = "0x185D2F580")]
	internal ELHABHLMECL FAACNIJPPPL(AIHNKGMLOJH JOIDOIOECKI)
	{
		return default(ELHABHLMECL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F840", Offset = "0x5D2E440", VA = "0x185D2F840")]
	internal void FLGACHDDEDF(GGGCFLLCBAH PKMPDBKDJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EBD0", Offset = "0x5D2D7D0", VA = "0x185D2EBD0")]
	internal HNHANIAIECB BMNMMOLHIOO(byte[] IMCLGJBJJKP, int BGCAJHMJIFE, int JKBHNDINMGD, bool NDHMLIPBMEM)
	{
		return default(HNHANIAIECB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D31670", Offset = "0x5D30270", VA = "0x185D31670")]
	private void NHFHOEGELAM(int NENLAMOODMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FE60", Offset = "0x5D2EA60", VA = "0x185D2FE60")]
	internal void KODMBAKAOOD(LLLMHJJADAC AEGDCAADINA, AIHNKGMLOJH GEBOGBKBFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D30A60", Offset = "0x5D2F660", VA = "0x185D30A60")]
	private void MMAKHLKOMHC(AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F9C0", Offset = "0x5D2E5C0", VA = "0x185D2F9C0")]
	private void GPMLAPDHEGB(int HHCAAOJDKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D31F60", Offset = "0x5D30B60", VA = "0x185D31F60")]
	internal LBAHAHJFLBJ POLCNJBALGA(PGHFFAIILII BCGPPCJCDMP)
	{
		return default(LBAHAHJFLBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D317E0", Offset = "0x5D303E0", VA = "0x185D317E0")]
	internal void OKDFANBMJMK(AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F8A0", Offset = "0x5D2E4A0", VA = "0x185D2F8A0")]
	private void GEKILDDHDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F670", Offset = "0x5D2E270", VA = "0x185D2F670")]
	internal void FBCNLNFJJJK(AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D30FC0", Offset = "0x5D2FBC0", VA = "0x185D30FC0")]
	internal void NBJEMGDMOCC(int HHCAAOJDKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E910", Offset = "0x5D2D510", VA = "0x185D2E910")]
	internal void BJIJBKJAPMG(AIHNKGMLOJH JOIDOIOECKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class MKNBGJACFFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long BCNMOLIKDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long AHODFBPBPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long KNEPOOAEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long OHFJGNKLMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long PNIHIFOLIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long AMLGFEPEOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long IPDBNELOKLP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long LAAFOIHPOEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D26ED0", Offset = "0x5D25AD0", VA = "0x185D26ED0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EKGCHKPLLAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D27120", Offset = "0x5D25D20", VA = "0x185D27120")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long PHNHBJAGFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D270C0", Offset = "0x5D25CC0", VA = "0x185D270C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long ODGOMEBEHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D26FF0", Offset = "0x5D25BF0", VA = "0x185D26FF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long CFLBLKJFHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D270E0", Offset = "0x5D25CE0", VA = "0x185D270E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long FGALHKCFNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5D270D0", Offset = "0x5D25CD0", VA = "0x185D270D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private LIEKLFGDHPO DCFDCPLIECG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D270B0", Offset = "0x5D25CB0", VA = "0x185D270B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double EFCDHILDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D26F80", Offset = "0x5D25B80", VA = "0x185D26F80")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D26EE0", Offset = "0x5D25AE0", VA = "0x185D26EE0")]
	public void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D270F0", Offset = "0x5D25CF0", VA = "0x185D270F0")]
	public void MDDGJANJKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D26EC0", Offset = "0x5D25AC0", VA = "0x185D26EC0")]
	public void BOOJKAPDFJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D270A0", Offset = "0x5D25CA0", VA = "0x185D270A0")]
	public void GOFFJGAIJGA(long FDKHMBPFHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D26FE0", Offset = "0x5D25BE0", VA = "0x185D26FE0")]
	public void DNNJIDBIFGJ(long JNOBPJCJPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D27130", Offset = "0x5D25D30", VA = "0x185D27130")]
	public void NJNMBLANALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D26F40", Offset = "0x5D25B40", VA = "0x185D26F40")]
	public void CODHHFNENJI(long AECDDIIJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D27160", Offset = "0x5D25D60", VA = "0x185D27160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D27000", Offset = "0x5D25C00", VA = "0x185D27000")]
	public void FGECFJEIMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MKNBGJACFFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class CGMAOOENGCI
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> ILNAJLKGNBO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D206E0", Offset = "0x5D1F2E0", VA = "0x185D206E0")]
	public static IPEndPoint PJIKCFKKJMJ(string BIPBPBMDGOD, int GBDBCEHCEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D204E0", Offset = "0x5D1F0E0", VA = "0x185D204E0")]
	public static IPAddress CBCKFOJOEIH(string BIPBPBMDGOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D20450", Offset = "0x5D1F050", VA = "0x185D20450")]
	public static IPAddress CBCKFOJOEIH(string BIPBPBMDGOD, AddressFamily CFPPDGMPCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D206B0", Offset = "0x5D1F2B0", VA = "0x185D206B0")]
	internal static int JACMEMGHAJC(int LOENGGJKFDK, int NBCBLAAHNCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x28E8E00", Offset = "0x28E7A00", VA = "0x1828E8E00")]
	internal static T[] IKELAPCPLAP<T>(int HDFABDCMCAG) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CPHDIIBFONI : GGGCFLLCBAH
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct DPLNCJELMLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private AIHNKGMLOJH IHCPFBBDDHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long KCLBHLCNCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool IGLFJNFEMJE;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D225E0", Offset = "0x5D211E0", VA = "0x185D225E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D22500", Offset = "0x5D21100", VA = "0x185D22500")]
		public void JOJMDOFEJMG(AIHNKGMLOJH JOIDOIOECKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D22520", Offset = "0x5D21120", VA = "0x185D22520")]
		public bool NIKNCAAPFDH(long BILFJIAHIIH, NFPOGMFBBKO NPGFADPHEFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D22590", Offset = "0x5D21190", VA = "0x185D22590")]
		public bool ONDHHAABKMO(NFPOGMFBBKO NPGFADPHEFM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly AIHNKGMLOJH MLFLMBFMHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly DPLNCJELMLM[] LOGPCPKMBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly AIHNKGMLOJH[] AJMKLOKBGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] PGOPGFLMKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int EJJHKAMGBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int BCEELEKMAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int JFBGNACCCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int OCFIKCJPKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool EGBHLEJHGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly LLLMHJJADAC DDCKBAOBFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool CNAGNLKDEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int JDOKAPJGMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte FOHOPACNIHA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D21A70", Offset = "0x5D20670", VA = "0x185D21A70")]
	public CPHDIIBFONI(NFPOGMFBBKO NPGFADPHEFM, bool APAFAFCKOMP, byte EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D21050", Offset = "0x5D1FC50", VA = "0x185D21050")]
	private void FDBBODEFHBN(AIHNKGMLOJH JOIDOIOECKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D20BA0", Offset = "0x5D1F7A0", VA = "0x185D20BA0", Slot = "4")]
	protected override bool CGGDAMLBJFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D21410", Offset = "0x5D20010", VA = "0x185D21410", Slot = "5")]
	public override bool OKDFANBMJMK(AIHNKGMLOJH JOIDOIOECKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GNPLGIJAJKE : GGGCFLLCBAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int HEAEPFEHELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort BCEELEKMAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool ENPFIJFGNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private AIHNKGMLOJH NEHIOCAJLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly AIHNKGMLOJH NPPIJOIMOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool NIAGKFAPJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte FOHOPACNIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long FDBHNGILNIA;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5D25490", Offset = "0x5D24090", VA = "0x185D25490")]
	public GNPLGIJAJKE(NFPOGMFBBKO NPGFADPHEFM, bool DEFNEGAGBPL, byte EPKGPGILADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5D24CE0", Offset = "0x5D238E0", VA = "0x185D24CE0", Slot = "4")]
	protected override bool CGGDAMLBJFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5D25180", Offset = "0x5D23D80", VA = "0x185D25180", Slot = "5")]
	public override bool OKDFANBMJMK(AIHNKGMLOJH JOIDOIOECKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PPIBIHEPGCE
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct MPKINJDKIOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong OJCHBFJCAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double MHFCMGBAACH;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct ECJMADBEJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int HLNBHBAFKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float NMPKIHJCKPD;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E7D0", Offset = "0x5D1D3D0", VA = "0x185D1E7D0")]
	private static void APPONGKKHHB(byte[] BKHGNPANPPB, int MANKJHLJMBO, ulong IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5D34960", Offset = "0x5D33560", VA = "0x185D34960")]
	private static void APPONGKKHHB(byte[] BKHGNPANPPB, int MANKJHLJMBO, int IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5D349E0", Offset = "0x5D335E0", VA = "0x185D349E0")]
	public static void APPONGKKHHB(byte[] BKHGNPANPPB, int MANKJHLJMBO, short IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5D34AA0", Offset = "0x5D336A0", VA = "0x185D34AA0")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, double GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5D34A20", Offset = "0x5D33620", VA = "0x185D34A20")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5D349E0", Offset = "0x5D335E0", VA = "0x185D349E0")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, short GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D349E0", Offset = "0x5D335E0", VA = "0x185D349E0")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, ushort GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5D34960", Offset = "0x5D33560", VA = "0x185D34960")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5D34960", Offset = "0x5D33560", VA = "0x185D34960")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, uint GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5D349D0", Offset = "0x5D335D0", VA = "0x185D349D0")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5D349D0", Offset = "0x5D335D0", VA = "0x185D349D0")]
	public static void AOBKNKHMIPC(byte[] HNGDLLNOPEB, int PAGNMFPMINA, ulong GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BDCLBPBAMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] BGKODKCBENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int AJACNKLCLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int BFJMCCIDPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int LHFNBIEELDB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] GLCJEMGIGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int PBGDHKDABHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF0", Offset = "0x8B9AF0", VA = "0x1808BAEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int CHGHJDPDCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D1F780", Offset = "0x5D1E380", VA = "0x185D1F780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool INHLAJFFEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1E95FB0", Offset = "0x1E94BB0", VA = "0x181E95FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NBPLDGOPANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D1F730", Offset = "0x5D1E330", VA = "0x185D1F730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5D20230", Offset = "0x5D1EE30", VA = "0x185D20230")]
	public void PCAKICBLLGI(byte[] OGOLDJHPDFA, int MANKJHLJMBO, int JHHLJOPBFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BDCLBPBAMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5D202B0", Offset = "0x5D1EEB0", VA = "0x185D202B0")]
	public BDCLBPBAMKO(byte[] OGOLDJHPDFA, int MANKJHLJMBO, int JHHLJOPBFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FDD0", Offset = "0x5D1E9D0", VA = "0x185D1FDD0")]
	public IPEndPoint LNADEIPKDDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F8C0", Offset = "0x5D1E4C0", VA = "0x185D1F8C0")]
	public byte FHNPMDDAKJE()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F8C0", Offset = "0x5D1E4C0", VA = "0x185D1F8C0")]
	public sbyte HDOFEAHNIPH()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2881020", Offset = "0x287FC20", VA = "0x182881020")]
	public T[] FLLFAIOFMEK<T>(ushort AEOJMEBJNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F880", Offset = "0x5D1E480", VA = "0x185D1F880")]
	public bool[] FGOGKCKHCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F740", Offset = "0x5D1E340", VA = "0x185D1F740")]
	public ushort[] BDOACDFINNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F940", Offset = "0x5D1E540", VA = "0x185D1F940")]
	public short[] HADMCODGFAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FC30", Offset = "0x5D1E830", VA = "0x185D1FC30")]
	public int[] IJMHAKBANCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F790", Offset = "0x5D1E390", VA = "0x185D1F790")]
	public uint[] COHADOONKJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FD90", Offset = "0x5D1E990", VA = "0x185D1FD90")]
	public float[] KALAMEEPDFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FD50", Offset = "0x5D1E950", VA = "0x185D1FD50")]
	public double[] JOPIMKNBHID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FEA0", Offset = "0x5D1EAA0", VA = "0x185D1FEA0")]
	public long[] MCJJNCJLIFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F7D0", Offset = "0x5D1E3D0", VA = "0x185D1F7D0")]
	public ulong[] DHCCBHICIEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D200E0", Offset = "0x5D1ECE0", VA = "0x185D200E0")]
	public string[] OKEAGBIECAM(int BJBEFNHDGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D200A0", Offset = "0x5D1ECA0", VA = "0x185D200A0")]
	public bool OAHCABPNBHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FF50", Offset = "0x5D1EB50", VA = "0x185D1FF50")]
	public char NFBGDPNDCNO()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FF50", Offset = "0x5D1EB50", VA = "0x185D1FF50")]
	public ushort OKOMOHCCKKK()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FC70", Offset = "0x5D1E870", VA = "0x185D1FC70")]
	public short IPPJHHLAIFM()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FBC0", Offset = "0x5D1E7C0", VA = "0x185D1FBC0")]
	public long HEDEOKKOBDK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F810", Offset = "0x5D1E410", VA = "0x185D1F810")]
	public ulong ENHMKPLOBGF()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FCE0", Offset = "0x5D1E8E0", VA = "0x185D1FCE0")]
	public int JOMJJGLIEKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D20030", Offset = "0x5D1EC30", VA = "0x185D20030")]
	public uint NNIOIIGILCK()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F6C0", Offset = "0x5D1E2C0", VA = "0x185D1F6C0")]
	public float ABNJKBPGGPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FEE0", Offset = "0x5D1EAE0", VA = "0x185D1FEE0")]
	public double MFGHCDIHHPJ()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F980", Offset = "0x5D1E580", VA = "0x185D1F980")]
	public string HCBFGBKOCGD(int HLCPHBIOAAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FFC0", Offset = "0x5D1EBC0", VA = "0x185D1FFC0")]
	public ArraySegment<byte> NJAHBGPIFCC(int HDFABDCMCAG)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F900", Offset = "0x5D1E500", VA = "0x185D1F900")]
	public sbyte[] GJHAHJEFIFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D20270", Offset = "0x5D1EE70", VA = "0x185D20270")]
	public byte[] PPNFDJDMNJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D20210", Offset = "0x5D1EE10", VA = "0x185D20210")]
	public void ONDHHAABKMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EEHIFILIEEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] BGKODKCBENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int AJACNKLCLPC;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int AABHPFFABBP = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool AGABKMEKNHD;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding NCFDPICIFCE;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int CHDGFDCPJOP = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] NKKMJINILJJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] JLODENNJHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int CJOHGCFPKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5D233B0", Offset = "0x5D21FB0", VA = "0x185D233B0")]
	public EEHIFILIEEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5D23430", Offset = "0x5D22030", VA = "0x185D23430")]
	public EEHIFILIEEP(bool HAHJHCPPCKO, int JPDKFFOGAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5D22760", Offset = "0x5D21360", VA = "0x185D22760")]
	public static EEHIFILIEEP HHIDDBECHFG(string GLMEMJNJKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5D227D0", Offset = "0x5D213D0", VA = "0x185D227D0")]
	public void JAJGDLCHAGK(int DKJJICELCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F0FA60", Offset = "0x1F0E660", VA = "0x181F0FA60")]
	public void CJMFGDFICPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5D228E0", Offset = "0x5D214E0", VA = "0x185D228E0")]
	public void JEAMKKAPMNN(float GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5D22980", Offset = "0x5D21580", VA = "0x185D22980")]
	public void JEAMKKAPMNN(double GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5D22B10", Offset = "0x5D21710", VA = "0x185D22B10")]
	public void JEAMKKAPMNN(long GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5D22B10", Offset = "0x5D21710", VA = "0x185D22B10")]
	public void JEAMKKAPMNN(ulong GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D22DD0", Offset = "0x5D219D0", VA = "0x185D22DD0")]
	public void JEAMKKAPMNN(int GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D22DD0", Offset = "0x5D219D0", VA = "0x185D22DD0")]
	public void JEAMKKAPMNN(uint GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D22870", Offset = "0x5D21470", VA = "0x185D22870")]
	public void JEAMKKAPMNN(char GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D22870", Offset = "0x5D21470", VA = "0x185D22870")]
	public void JEAMKKAPMNN(ushort GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5D22870", Offset = "0x5D21470", VA = "0x185D22870")]
	public void JEAMKKAPMNN(short GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5D22B60", Offset = "0x5D21760", VA = "0x185D22B60")]
	public void JEAMKKAPMNN(sbyte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5D22B60", Offset = "0x5D21760", VA = "0x185D22B60")]
	public void JEAMKKAPMNN(byte GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5D22AA0", Offset = "0x5D216A0", VA = "0x185D22AA0")]
	public void JEAMKKAPMNN(byte[] IMCLGJBJJKP, int MANKJHLJMBO, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5D22680", Offset = "0x5D21280", VA = "0x185D22680")]
	public void HKAIKINMDCH(sbyte[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5D22680", Offset = "0x5D21280", VA = "0x185D22680")]
	public void EAOHJHNFALC(byte[] IMCLGJBJJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5D22E70", Offset = "0x5D21A70", VA = "0x185D22E70")]
	public void JEAMKKAPMNN(bool GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5D23170", Offset = "0x5D21D70", VA = "0x185D23170")]
	public void LPPKDOEIKOO(Array IPLMOLBCGME, int HJHEHEJADDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D22FB0", Offset = "0x5D21BB0", VA = "0x185D22FB0")]
	public void LPPKDOEIKOO(float[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D22ED0", Offset = "0x5D21AD0", VA = "0x185D22ED0")]
	public void LPPKDOEIKOO(double[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D22ED0", Offset = "0x5D21AD0", VA = "0x185D22ED0")]
	public void LPPKDOEIKOO(long[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5D22ED0", Offset = "0x5D21AD0", VA = "0x185D22ED0")]
	public void LPPKDOEIKOO(ulong[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5D22FB0", Offset = "0x5D21BB0", VA = "0x185D22FB0")]
	public void LPPKDOEIKOO(int[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5D22FB0", Offset = "0x5D21BB0", VA = "0x185D22FB0")]
	public void LPPKDOEIKOO(uint[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5D23090", Offset = "0x5D21C90", VA = "0x185D23090")]
	public void LPPKDOEIKOO(ushort[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5D23090", Offset = "0x5D21C90", VA = "0x185D23090")]
	public void LPPKDOEIKOO(short[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5D22680", Offset = "0x5D21280", VA = "0x185D22680")]
	public void LPPKDOEIKOO(bool[] GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5D23250", Offset = "0x5D21E50", VA = "0x185D23250")]
	public void LPPKDOEIKOO(string[] GLMEMJNJKAN, int GKCJEFDGAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D229D0", Offset = "0x5D215D0", VA = "0x185D229D0")]
	public void JEAMKKAPMNN(IPEndPoint NOIIAAEGKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D22E60", Offset = "0x5D21A60", VA = "0x185D22E60")]
	public void JEAMKKAPMNN(string GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D22BC0", Offset = "0x5D217C0", VA = "0x185D22BC0")]
	public void JEAMKKAPMNN(string GLMEMJNJKAN, int HLCPHBIOAAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class ALFBIHMHIPL
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class BMGIPMPGIAC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong CCJJLJNMAIH;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4E65550", Offset = "0x4E64150", VA = "0x184E65550")]
		static BMGIPMPGIAC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void AJEJAAPHJPM(BDCLBPBAMKO GGPHPLOPODB, object BNKNOLMDOIM);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DFCCADDGAJL<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public ALFBIHMHIPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public DFCCADDGAJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x57CD6A0", Offset = "0x57CC2A0", VA = "0x1857CD6A0")]
		internal void BOLKGMOEJNL(BDCLBPBAMKO reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IPLMGBHNJEF<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public ALFBIHMHIPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public IPLMGBHNJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E7C0", Offset = "0x3E7D3C0", VA = "0x183E7E7C0")]
		internal void BOLKGMOEJNL(BDCLBPBAMKO reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly DIKIGGOCFLE NPIPCICDDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, AJEJAAPHJPM> INLIMMBLOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly EEHIFILIEEP KEPKAJBDMCK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F540", Offset = "0x5D1E140", VA = "0x185D1F540")]
	public ALFBIHMHIPL(int BJBEFNHDGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2887C40", Offset = "0x2886840", VA = "0x182887C40", Slot = "4")]
	protected virtual ulong KMNOLGNONCC<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F340", Offset = "0x5D1DF40", VA = "0x185D1F340", Slot = "5")]
	protected virtual AJEJAAPHJPM FEPGNLMFJJM(BDCLBPBAMKO GGPHPLOPODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x31DDBF0", Offset = "0x31DC7F0", VA = "0x1831DDBF0", Slot = "6")]
	protected virtual void JOFENMKLEDM<T>(EEHIFILIEEP AKHHKFNOJLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F470", Offset = "0x5D1E070", VA = "0x185D1F470")]
	public void GMHDLMFHIND(BDCLBPBAMKO GGPHPLOPODB, object BNKNOLMDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x31DDC60", Offset = "0x31DC860", VA = "0x1831DDC60")]
	public void LLMINMLBJFM<T>(EEHIFILIEEP AKHHKFNOJLO, T JOIDOIOECKI) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F4F0", Offset = "0x5D1E0F0", VA = "0x185D1F4F0")]
	public void PPCENCDDACG(BDCLBPBAMKO GGPHPLOPODB, object BNKNOLMDOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x31DDA30", Offset = "0x31DC630", VA = "0x1831DDA30")]
	public void IAGBOCHMNIC<T>(Action<T> MKJHLNHNGNM) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x31DD870", Offset = "0x31DC470", VA = "0x1831DD870")]
	public void IAGBOCHMNIC<T, TUserData>(Action<T, TUserData> MKJHLNHNGNM) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KDNELALKLEJ : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D23570", Offset = "0x5D22170", VA = "0x185D23570")]
	public KDNELALKLEJ(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class CDMFMLDCFHE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D203F0", Offset = "0x5D1EFF0", VA = "0x185D203F0")]
	public CDMFMLDCFHE(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class DIKIGGOCFLE
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum NICPEEGGOLA
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class PMMDLFGPJNL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public NICPEEGGOLA AJCKJIKGPNK;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x477B860", Offset = "0x477A460", VA = "0x18477B860", Slot = "4")]
		public virtual void JOJMDOFEJMG(MethodInfo NMGDANFKDFM, MethodInfo OFAHBHCGIIM, NICPEEGGOLA NCNNODEFPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void FCAMBJHEDAD(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void KCGEJIBHMBA(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		protected PMMDLFGPJNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class DOHAKCKGFCJ<TClass, TProperty> : PMMDLFGPJNL<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> FNOFDFAGPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> MAIEHAIFCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> GLCPPLOCICA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> PLEHNPBNKDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> NLLPADLBCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> MMIPCCHEEDA;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x57F4A80", Offset = "0x57F3680", VA = "0x1857F4A80", Slot = "7")]
		public override void APODBOAOOOI(TClass PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x57FB670", Offset = "0x57FA270", VA = "0x1857FB670", Slot = "8")]
		public override void OIOLBJDDDLK(TClass PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x57F55E0", Offset = "0x57F41E0", VA = "0x1857F55E0", Slot = "9")]
		public override void FCAMBJHEDAD(TClass PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x57FA680", Offset = "0x57F9280", VA = "0x1857FA680", Slot = "10")]
		public override void KCGEJIBHMBA(TClass PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x57FAF40", Offset = "0x57F9B40", VA = "0x1857FAF40")]
		protected TProperty[] MJEGIHFGHJL(TClass PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x57F5A40", Offset = "0x57F4640", VA = "0x1857F5A40")]
		protected TProperty[] JENLNDACLOB(TClass PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x57F76E0", Offset = "0x57F62E0", VA = "0x1857F76E0", Slot = "4")]
		public override void JOJMDOFEJMG(MethodInfo NMGDANFKDFM, MethodInfo OFAHBHCGIIM, NICPEEGGOLA NCNNODEFPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3D38440", Offset = "0x3D37040", VA = "0x183D38440")]
		protected DOHAKCKGFCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class CDDPMDGABAH<TClass, TProperty> : DOHAKCKGFCJ<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void FJHLKFHFOAK(BDCLBPBAMKO AAELGECAEGP, [Out] TProperty JOKBGOINBCP);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void AGHAMPGBGHH(EEHIFILIEEP NLPLEHNHDEH, TProperty JOKBGOINBCP);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x51A2230", Offset = "0x51A0E30", VA = "0x1851A2230", Slot = "5")]
		public override void JDCHHNFHGNC(TClass PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x51A2350", Offset = "0x51A0F50", VA = "0x1851A2350", Slot = "6")]
		public override void LLMINMLBJFM(TClass PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x51A20D0", Offset = "0x51A0CD0", VA = "0x1851A20D0", Slot = "7")]
		public override void APODBOAOOOI(TClass PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x51A2490", Offset = "0x51A1090", VA = "0x1851A2490", Slot = "8")]
		public override void OIOLBJDDDLK(TClass PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3BAC2B0", Offset = "0x3BAAEB0", VA = "0x183BAC2B0")]
		protected CDDPMDGABAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class BPDLOPPCALI<T> : DOHAKCKGFCJ<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x4E82140", Offset = "0x4E80D40", VA = "0x184E82140", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4589140", Offset = "0x4587D40", VA = "0x184589140", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4E820C0", Offset = "0x4E80CC0", VA = "0x184E820C0", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x45891B0", Offset = "0x4587DB0", VA = "0x1845891B0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public BPDLOPPCALI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OILBABOIMFK<T> : DOHAKCKGFCJ<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x45890C0", Offset = "0x4587CC0", VA = "0x1845890C0", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4589140", Offset = "0x4587D40", VA = "0x184589140", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4589040", Offset = "0x4587C40", VA = "0x184589040", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x45891B0", Offset = "0x4587DB0", VA = "0x1845891B0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public OILBABOIMFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class KIEOKBODAKD<T> : DOHAKCKGFCJ<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4151810", Offset = "0x4150410", VA = "0x184151810", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x4151890", Offset = "0x4150490", VA = "0x184151890", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x4151790", Offset = "0x4150390", VA = "0x184151790", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x4151900", Offset = "0x4150500", VA = "0x184151900", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public KIEOKBODAKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OPBJPENFGJJ<T> : DOHAKCKGFCJ<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x4655CC0", Offset = "0x46548C0", VA = "0x184655CC0", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4151890", Offset = "0x4150490", VA = "0x184151890", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4655C40", Offset = "0x4654840", VA = "0x184655C40", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4151900", Offset = "0x4150500", VA = "0x184151900", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public OPBJPENFGJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class GLIMKGBIIDJ<T> : DOHAKCKGFCJ<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3BC0", Offset = "0x3CE27C0", VA = "0x183CE3BC0", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3C40", Offset = "0x3CE2840", VA = "0x183CE3C40", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3B40", Offset = "0x3CE2740", VA = "0x183CE3B40", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3CB0", Offset = "0x3CE28B0", VA = "0x183CE3CB0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public GLIMKGBIIDJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class COCPHLLFKJF<T> : DOHAKCKGFCJ<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5382550", Offset = "0x5381150", VA = "0x185382550", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3C40", Offset = "0x3CE2840", VA = "0x183CE3C40", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x53824D0", Offset = "0x53810D0", VA = "0x1853824D0", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3CB0", Offset = "0x3CE28B0", VA = "0x183CE3CB0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public COCPHLLFKJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class FBIEKCPONOB<T> : DOHAKCKGFCJ<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D270", Offset = "0x3B7BE70", VA = "0x183B7D270", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D2F0", Offset = "0x3B7BEF0", VA = "0x183B7D2F0", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D1F0", Offset = "0x3B7BDF0", VA = "0x183B7D1F0", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D360", Offset = "0x3B7BF60", VA = "0x183B7D360", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public FBIEKCPONOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class ACGGHMIJENB<T> : DOHAKCKGFCJ<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D270", Offset = "0x3B7BE70", VA = "0x183B7D270", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D2F0", Offset = "0x3B7BEF0", VA = "0x183B7D2F0", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2740", Offset = "0x3CC1340", VA = "0x183CC2740", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D360", Offset = "0x3B7BF60", VA = "0x183B7D360", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public ACGGHMIJENB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BMOHDEOCKJN<T> : DOHAKCKGFCJ<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E67620", Offset = "0x4E66220", VA = "0x184E67620", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E676A0", Offset = "0x4E662A0", VA = "0x184E676A0", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4E675A0", Offset = "0x4E661A0", VA = "0x184E675A0", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x45891B0", Offset = "0x4587DB0", VA = "0x1845891B0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public BMOHDEOCKJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CALJCBPGICF<T> : DOHAKCKGFCJ<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50C12E0", Offset = "0x50BFEE0", VA = "0x1850C12E0", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x50C1360", Offset = "0x50BFF60", VA = "0x1850C1360", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x50C1260", Offset = "0x50BFE60", VA = "0x1850C1260", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE3CB0", Offset = "0x3CE28B0", VA = "0x183CE3CB0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public CALJCBPGICF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class NKCDBODIMIL<T> : DOHAKCKGFCJ<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4499400", Offset = "0x4498000", VA = "0x184499400", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x4499480", Offset = "0x4498080", VA = "0x184499480", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4499380", Offset = "0x4497F80", VA = "0x184499380", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D360", Offset = "0x3B7BF60", VA = "0x183B7D360", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3B7D3D0", Offset = "0x3B7BFD0", VA = "0x183B7D3D0")]
		public NKCDBODIMIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class HAKOGMBMPKI<T> : CDDPMDGABAH<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C4B0", Offset = "0x3D0B0B0", VA = "0x183D0C4B0", Slot = "12")]
		protected override void AGHAMPGBGHH(EEHIFILIEEP NLPLEHNHDEH, char JOKBGOINBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C4E0", Offset = "0x3D0B0E0", VA = "0x183D0C4E0", Slot = "11")]
		protected override void FJHLKFHFOAK(BDCLBPBAMKO AAELGECAEGP, [Out] char JOKBGOINBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C733C0", Offset = "0x3C71FC0", VA = "0x183C733C0")]
		public HAKOGMBMPKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class GDGHLMCLFDA<T> : CDDPMDGABAH<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C73350", Offset = "0x3C71F50", VA = "0x183C73350", Slot = "12")]
		protected override void AGHAMPGBGHH(EEHIFILIEEP NLPLEHNHDEH, IPEndPoint JOKBGOINBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C73380", Offset = "0x3C71F80", VA = "0x183C73380", Slot = "11")]
		protected override void FJHLKFHFOAK(BDCLBPBAMKO AAELGECAEGP, [Out] IPEndPoint JOKBGOINBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C733C0", Offset = "0x3C71FC0", VA = "0x183C733C0")]
		public GDGHLMCLFDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class MBJNCBGLDEE<T> : DOHAKCKGFCJ<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int HOMIPNALKAE;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x43E3AA0", Offset = "0x43E26A0", VA = "0x1843E3AA0")]
		public MBJNCBGLDEE(int HLCPHBIOAAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x43E3920", Offset = "0x43E2520", VA = "0x1843E3920", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x43E39A0", Offset = "0x43E25A0", VA = "0x1843E39A0", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x43E38A0", Offset = "0x43E24A0", VA = "0x1843E38A0", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x43E3A20", Offset = "0x43E2620", VA = "0x1843E3A20", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class COODMPGELOE<T> : PMMDLFGPJNL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo CPGIIMJBFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type AEBNMNDNCJO;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x545FE00", Offset = "0x545EA00", VA = "0x18545FE00")]
		public COODMPGELOE(PropertyInfo LKOIJCCHEHO, Type ANHBMHIDMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x545FBD0", Offset = "0x545E7D0", VA = "0x18545FBD0", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x545FCF0", Offset = "0x545E8F0", VA = "0x18545FCF0", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x545FB10", Offset = "0x545E710", VA = "0x18545FB10", Slot = "7")]
		public override void APODBOAOOOI(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x545FDA0", Offset = "0x545E9A0", VA = "0x18545FDA0", Slot = "8")]
		public override void OIOLBJDDDLK(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x545FB70", Offset = "0x545E770", VA = "0x18545FB70", Slot = "9")]
		public override void FCAMBJHEDAD(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x545FC90", Offset = "0x545E890", VA = "0x18545FC90", Slot = "10")]
		public override void KCGEJIBHMBA(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DJNJEJKJPPE<T> : COODMPGELOE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C980", Offset = "0x3B9B580", VA = "0x183B9C980")]
		public DJNJEJKJPPE(PropertyInfo LKOIJCCHEHO, Type ANHBMHIDMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x57E8630", Offset = "0x57E7230", VA = "0x1857E8630", Slot = "5")]
		public override void JDCHHNFHGNC(T PMEOCIODFAO, BDCLBPBAMKO AAELGECAEGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x57E86F0", Offset = "0x57E72F0", VA = "0x1857E86F0", Slot = "6")]
		public override void LLMINMLBJFM(T PMEOCIODFAO, EEHIFILIEEP NLPLEHNHDEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class KIMEPEMHANH<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static KIMEPEMHANH<T> GGKBGANLBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly PMMDLFGPJNL<T>[] IEGMHIAJBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int AMHPGKGMFJB;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4151C10", Offset = "0x4150810", VA = "0x184151C10")]
		public KIMEPEMHANH(List<PMMDLFGPJNL<T>> FBADKFEMEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4151B60", Offset = "0x4150760", VA = "0x184151B60")]
		public void LLMINMLBJFM(T HAHECKLGOJC, EEHIFILIEEP AKHHKFNOJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4151AB0", Offset = "0x41506B0", VA = "0x184151AB0")]
		public void JDCHHNFHGNC(T HAHECKLGOJC, BDCLBPBAMKO GGPHPLOPODB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class PFOOAGHBJPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract PMMDLFGPJNL<T> HCNFCFFAFEI<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private EEHIFILIEEP BIMFFIOPLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int JAJIPEIONLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, PFOOAGHBJPE> BDFELCFEPFH;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5D22460", Offset = "0x5D21060", VA = "0x185D22460")]
	public DIKIGGOCFLE(int BJBEFNHDGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x292EF40", Offset = "0x292DB40", VA = "0x18292EF40")]
	private KIMEPEMHANH<T> DBEFABBPBAN<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2930110", Offset = "0x292ED10", VA = "0x182930110")]
	public void FHCDBNBHAOK<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2930070", Offset = "0x292EC70", VA = "0x182930070")]
	public bool EGCBEAACMHC<T>(BDCLBPBAMKO GGPHPLOPODB, T PJIFCLGMLOL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2930140", Offset = "0x292ED40", VA = "0x182930140")]
	public void PLFEAILJDFE<T>(EEHIFILIEEP AKHHKFNOJLO, T HAHECKLGOJC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GNCJKAOMMBH
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime NKLIBDDHNIL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] JCGHCBOKHDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JCOPBANOKAM ILMJEAMNFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D24570", Offset = "0x5D23170", VA = "0x185D24570")]
		get
		{
			return default(JCOPBANOKAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int AAFLKLEIBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D240E0", Offset = "0x5D22CE0", VA = "0x185D240E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5D24440", Offset = "0x5D23040", VA = "0x185D24440")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ALLFGBPFEJP GAOEFIHNHPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5D23D80", Offset = "0x5D22980", VA = "0x185D23D80")]
		get
		{
			return default(ALLFGBPFEJP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5D23F80", Offset = "0x5D22B80", VA = "0x185D23F80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int FCEFKBEJNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5D23950", Offset = "0x5D22550", VA = "0x185D23950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint JKNAKLMIMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D24830", Offset = "0x5D23430", VA = "0x185D24830")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? EDADPCNDJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D23980", Offset = "0x5D22580", VA = "0x185D23980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? HENNLBLKKJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D24480", Offset = "0x5D23080", VA = "0x185D24480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? NOCBMIHAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D245A0", Offset = "0x5D231A0", VA = "0x185D245A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D23DB0", Offset = "0x5D229B0", VA = "0x185D23DB0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? NBJBHHMHMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC225E0", Offset = "0xC211E0", VA = "0x180C225E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA6B660", Offset = "0xA6A260", VA = "0x180A6B660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D249C0", Offset = "0x5D235C0", VA = "0x185D249C0")]
	public GNCJKAOMMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D24910", Offset = "0x5D23510", VA = "0x185D24910")]
	internal GNCJKAOMMBH(byte[] HNGDLLNOPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D23FC0", Offset = "0x5D22BC0", VA = "0x185D23FC0")]
	public static GNCJKAOMMBH EGCGKDHBHLC(byte[] HNGDLLNOPEB, DateTime DAMOAJNJEBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D23B80", Offset = "0x5D22780", VA = "0x185D23B80")]
	internal void CCNBOKJANAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D239B0", Offset = "0x5D225B0", VA = "0x185D239B0")]
	private void ANHKGGDMMGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5D245D0", Offset = "0x5D231D0", VA = "0x185D245D0")]
	private DateTime? OEJEGBOOGPD(int MANKJHLJMBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5D24270", Offset = "0x5D22E70", VA = "0x185D24270")]
	private void IONNADAPPAJ(int MANKJHLJMBO, DateTime? GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5D24110", Offset = "0x5D22D10", VA = "0x185D24110")]
	private ulong IBPGFAMFECK(int MANKJHLJMBO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5D244B0", Offset = "0x5D230B0", VA = "0x185D244B0")]
	private void KFGPNGGCGJN(int MANKJHLJMBO, ulong GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D241E0", Offset = "0x5D22DE0", VA = "0x185D241E0")]
	private uint IODDFPFEGPJ(int MANKJHLJMBO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5BF0E80", Offset = "0x5BEFA80", VA = "0x185BF0E80")]
	private static uint OPNEIJPKPOE(uint KNFDPFPHEON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D247D0", Offset = "0x5D233D0", VA = "0x185D247D0")]
	private static ulong OPNEIJPKPOE(ulong KNFDPFPHEON)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum JCOPBANOKAM
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
public enum ALLFGBPFEJP
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class JNHDFJNOINM
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int MJPDACBKMCJ = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int IJPLPPICEIP = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int FOIDGFDFMJI = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint MJGODDAOFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int NBCBDKPKLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int CMDOCFGGKHK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IKMGENAEHCP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D25550", Offset = "0x5D24150", VA = "0x185D25550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D25560", Offset = "0x5D24160", VA = "0x185D25560")]
	public bool KOAEOCAGPCE(BBMEBEKLFAO FCEKADCKKIC, int PHNMPHLDABI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class DCMIKJPLEFI : BBMEBEKLFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket FCEKADCKKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly MMPHMAPNHBJ GMNBHCIECHB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short NLBPAEMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D21CC0", Offset = "0x5D208C0", VA = "0x185D21CC0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BAKBDGFBGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D21C80", Offset = "0x5D20880", VA = "0x185D21C80", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint KLCBJPJPKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D22390", Offset = "0x5D20F90", VA = "0x185D22390", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HPKPLIHGGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x41D9050", Offset = "0x41D7C50", VA = "0x1841D9050", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D223B0", Offset = "0x5D20FB0", VA = "0x185D223B0")]
	public DCMIKJPLEFI(AddressFamily CFPPDGMPCLM, MMPHMAPNHBJ GMNBHCIECHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D21CE0", Offset = "0x5D208E0", VA = "0x185D21CE0", Slot = "8")]
	public bool LBLLALBKEGK(IPEndPoint NOIIAAEGKDO, CPCADCHGGLL IHAIKOBBNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D21C40", Offset = "0x5D20840", VA = "0x185D21C40", Slot = "9")]
	public int DMDOHLAPCOC(byte[] BKHGNPANPPB, int MANKJHLJMBO, int AEOJMEBJNPD, IPEndPoint FCHBKDDIEFN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D222A0", Offset = "0x5D20EA0", VA = "0x185D222A0", Slot = "10")]
	public int NDCBGKMAEHM(byte[] BKHGNPANPPB, EndPoint GDKLKJEDBCP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D21CA0", Offset = "0x5D208A0", VA = "0x185D21CA0", Slot = "11")]
	public void KPDLMHAGGDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface BBMEBEKLFAO
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short NLBPAEMEJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int BAKBDGFBGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint KLCBJPJPKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily HPKPLIHGGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LBLLALBKEGK(IPEndPoint NOIIAAEGKDO, CPCADCHGGLL IHAIKOBBNJB);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int DMDOHLAPCOC(byte[] BKHGNPANPPB, int MANKJHLJMBO, int AEOJMEBJNPD, IPEndPoint FCHBKDDIEFN);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int NDCBGKMAEHM(byte[] BKHGNPANPPB, EndPoint FCHBKDDIEFN);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KPDLMHAGGDO();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct CLCNLBIIMFM : IEquatable<CLCNLBIIMFM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long CLLMBEGPLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long KPIHEBDOCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long DAMKFDKIFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int EDIAPOFIBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int NJMIGPKCLPA;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5D20AB0", Offset = "0x5D1F6B0", VA = "0x185D20AB0")]
	public CLCNLBIIMFM(byte[] FJCEHPOBJJD, int KGKIHOPAHHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x86B860", Offset = "0x86A460", VA = "0x18086B860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5D20A70", Offset = "0x5D1F670", VA = "0x185D20A70", Slot = "4")]
	public bool Equals(CLCNLBIIMFM OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5D209C0", Offset = "0x5D1F5C0", VA = "0x185D209C0", Slot = "0")]
	public override bool Equals(object HAHECKLGOJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class LDPCDGBKLGE : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] BAGGEAJHILE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class EEELNGBAALN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int HFNLAAOMCHN;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8497C0", Offset = "0x8483C0", VA = "0x1808497C0")]
	protected EEELNGBAALN(int OKMMBEHENMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void JIKNLANMPHJ(IPEndPoint NOIIAAEGKDO, byte[] IMCLGJBJJKP, int MANKJHLJMBO, int JKBHNDINMGD);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void OGEJCILADEA(IPEndPoint NOIIAAEGKDO, byte[] IMCLGJBJJKP, int MANKJHLJMBO, int JKBHNDINMGD);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PMDLNOPNOCE : EEELNGBAALN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider OIBELHNJBHF;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator DIGPKGGGODC;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5D34940", Offset = "0x5D33540", VA = "0x185D34940")]
	public PMDLNOPNOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5D33CF0", Offset = "0x5D328F0", VA = "0x185D33CF0")]
	public void AAOJKHLNNMH(IPEndPoint NOIIAAEGKDO, byte[] DPHIOKCFMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5D33F30", Offset = "0x5D32B30", VA = "0x185D33F30")]
	public void ABACPHNOLIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5D34010", Offset = "0x5D32C10", VA = "0x185D34010")]
	private byte[] ANANFPKDBHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5D340A0", Offset = "0x5D32CA0", VA = "0x185D340A0", Slot = "4")]
	public override void JIKNLANMPHJ(IPEndPoint NOIIAAEGKDO, byte[] IMCLGJBJJKP, int MANKJHLJMBO, int JKBHNDINMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5D34540", Offset = "0x5D33140", VA = "0x185D34540", Slot = "5")]
	public override void OGEJCILADEA(IPEndPoint NOIIAAEGKDO, byte[] IMCLGJBJJKP, int MANKJHLJMBO, int JKBHNDINMGD)
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
