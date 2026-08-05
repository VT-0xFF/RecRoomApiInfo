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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, LLMIFJPDMMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum JMADOOFBCDL
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
		private NetworkManager MBCFKIGPKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, IKHAHKINKOP> EMCDPNCAOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LMNCAIDCPIE NBFDFBABDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] OHGPPLAJMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JMADOOFBCDL FKALCHOFACG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong DCGMFFDPGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool COLBMNLABHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5698070", Offset = "0x5696E70", VA = "0x185698070", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5697520", Offset = "0x5696320", VA = "0x185697520")]
		public void RecRoom_SetEncryptionInfo(ulong NLLHFFEHCCH, byte[] OBPLDLNDJLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5697500", Offset = "0x5696300", VA = "0x185697500")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x56973D0", Offset = "0x56961D0", VA = "0x1856973D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5697F70", Offset = "0x5696D70", VA = "0x185697F70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5697720", Offset = "0x5696520", VA = "0x185697720", Slot = "6")]
		public override void Send(ulong POAKOKLLPFF, ArraySegment<byte> LHODDAGAJKC, NetworkDelivery NLIEHEKEOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x56974C0", Offset = "0x56962C0", VA = "0x1856974C0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong POAKOKLLPFF, [Out] ArraySegment<byte> PENMOOOPINK, [Out] float IKELGJGIECK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5697A10", Offset = "0x5696810", VA = "0x185697A10", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5697E90", Offset = "0x5696C90", VA = "0x185697E90", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x56969B0", Offset = "0x56957B0", VA = "0x1856969B0", Slot = "10")]
		public override void DisconnectRemoteClient(ulong POAKOKLLPFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5696860", Offset = "0x5695660", VA = "0x185696860", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5696BE0", Offset = "0x56959E0", VA = "0x185696BE0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong POAKOKLLPFF)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56979A0", Offset = "0x56967A0", VA = "0x1856979A0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5696E90", Offset = "0x5695C90", VA = "0x185696E90", Slot = "14")]
		public override void Initialize([Optional] NetworkManager MBCFKIGPKOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5696DC0", Offset = "0x5695BC0", VA = "0x185696DC0")]
		private PIJLBOEPILM ILBFNFIENPL(NetworkDelivery DDEINLAGLLL)
		{
			return default(PIJLBOEPILM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5696B20", Offset = "0x5695920", VA = "0x185696B20", Slot = "15")]
		private void FPNJDAMOALL(IKHAHKINKOP GEHNJIMMHDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5696C80", Offset = "0x5695A80", VA = "0x185696C80", Slot = "16")]
		private void HCEOELBIJKL(IKHAHKINKOP GEHNJIMMHDJ, OBOKPKAHKNM MEOPDLNMCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "17")]
		private void JGCJFPBLJKO(IPEndPoint GNILBNJDNPE, SocketError NFFNEPAKAFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x56971C0", Offset = "0x5695FC0", VA = "0x1856971C0", Slot = "18")]
		private void MKKAECEANHF(IKHAHKINKOP GEHNJIMMHDJ, HFNGCDLEOBB HGAPEJGOMLD, byte BNJKEFJPHFO, PIJLBOEPILM DBLAOMFEBAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56970B0", Offset = "0x5695EB0", VA = "0x1856970B0")]
		private void KHJGPHPEJGG(int CGDBKIJPKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "19")]
		private void IKFNHEGCAIE(IPEndPoint JMBLOMEBCON, HFNGCDLEOBB HGAPEJGOMLD, ABCBLALJGHD EAGIJKIKJMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "20")]
		private void COHGFPMFCNG(IKHAHKINKOP GEHNJIMMHDJ, int ECMFMMLLKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5697050", Offset = "0x5695E50", VA = "0x185697050", Slot = "21")]
		private void KHFAGLIKFGP(MDJBHGMPGEF AIAKOJMKOGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5697190", Offset = "0x5695F90", VA = "0x185697190")]
		private ulong MEPDOCBDDKA(IKHAHKINKOP GEHNJIMMHDJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5696840", Offset = "0x5695640", VA = "0x185696840")]
		private static int CIILNOMJCIC(float GKFGFCFKANC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5697F90", Offset = "0x5696D90", VA = "0x185697F90")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class KEAFNNMKHPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly IKHAHKINKOP LNNADKLDPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<AMMFFBKCNLA> IGAAKOLPEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int AEFDHFNBDLL;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x568CDA0", Offset = "0x568BBA0", VA = "0x18568CDA0")]
	protected KEAFNNMKHPJ(IKHAHKINKOP GEHNJIMMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x568CD40", Offset = "0x568BB40", VA = "0x18568CD40")]
	public void MAFNMGEOHOO(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x568CC80", Offset = "0x568BA80", VA = "0x18568CC80")]
	protected void CIJODCPJNDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x568CD00", Offset = "0x568BB00", VA = "0x18568CD00")]
	public bool LPILGLKCDJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool LNHPKAGFLCG();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool GLNNFHPEAPD(AMMFFBKCNLA HBICHOPJKGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum NODBNLHOGIE
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
public class MDJBHGMPGEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LMNCAIDCPIE ELDLIPEKKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int JCFDPBPOFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal AKJFAEBCIFE ODNGBPCDJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint IKMMKKANDMC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal NODBNLHOGIE GGIDPGJHPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BB0", Offset = "0x7D69B0", VA = "0x1807D7BB0")]
		[CompilerGenerated]
		get
		{
			return default(NODBNLHOGIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9592B0", Offset = "0x9580B0", VA = "0x1809592B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5698120", Offset = "0x5696F20", VA = "0x185698120")]
	internal void JIBFMLBKLIJ(AKJFAEBCIFE NOINPIDBENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x56980F0", Offset = "0x5696EF0", VA = "0x1856980F0")]
	private bool HNCONOAICPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5698180", Offset = "0x5696F80", VA = "0x185698180")]
	internal MDJBHGMPGEF(IPEndPoint JMBLOMEBCON, AKJFAEBCIFE EOIPCINDBAH, LMNCAIDCPIE OGIGDBJPPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5698090", Offset = "0x5696E90", VA = "0x185698090")]
	public IKHAHKINKOP AMAMAAOENID()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum ABCBLALJGHD
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JACCNFHDILD
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
public struct OBOKPKAHKNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JACCNFHDILD MMGEIKIPCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError JLANGONFKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public HFNGCDLEOBB DIEEOHMPNOE;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LLMIFJPDMMN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHEKKOHLKOO(IKHAHKINKOP GEHNJIMMHDJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJNIAKDCLOO(IKHAHKINKOP GEHNJIMMHDJ, OBOKPKAHKNM MEOPDLNMCKH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBBIACINJAC(IPEndPoint GNILBNJDNPE, SocketError NFFNEPAKAFN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDHIJFCFCGI(IKHAHKINKOP GEHNJIMMHDJ, HFNGCDLEOBB HGAPEJGOMLD, byte BNJKEFJPHFO, PIJLBOEPILM DBLAOMFEBAH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LCNPKECMLFP(IPEndPoint JMBLOMEBCON, HFNGCDLEOBB HGAPEJGOMLD, ABCBLALJGHD EAGIJKIKJMP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEGLPHPEPGN(IKHAHKINKOP GEHNJIMMHDJ, int ECMFMMLLKFL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FOADGGJBPHJ(MDJBHGMPGEF AIAKOJMKOGA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GJGMEPFHKPE
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFBCGHLADBE(IKHAHKINKOP GEHNJIMMHDJ, object FMPDDEEEKPA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AAPKDLPANEN
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PIKMPCEEPMC(LFFPIGELDGJ HBICHOPJKGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MLFJCJOACKE
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIPAJCJOCMK(IKHAHKINKOP GEHNJIMMHDJ, IPEndPoint FKMOJOFGAGH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class AKJFAEBCIFE
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int KMAAJJHOMOF = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long NHOIPMAKGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte EPFLGMAHLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] DBHIEHAGGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly OBIDBJALLGB OJPNFDCEOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int IFJINFLPDHH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5683C90", Offset = "0x5682A90", VA = "0x185683C90")]
	private AKJFAEBCIFE(long ABIDJDPFIPP, byte MJNFMGKBICO, int BLCHDPHIDBL, byte[] CCNOBGDMMOJ, OBIDBJALLGB LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5683830", Offset = "0x5682630", VA = "0x185683830")]
	public static int HHGNPGLCNHP(AMMFFBKCNLA HBICHOPJKGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5683890", Offset = "0x5682690", VA = "0x185683890")]
	public static AKJFAEBCIFE LNOFPKLJGAE(AMMFFBKCNLA HBICHOPJKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5683AB0", Offset = "0x56828B0", VA = "0x185683AB0")]
	public static AMMFFBKCNLA PABKOABPLOG(FPOBMNAIFCJ GECHFPJADIG, SocketAddress OBKNDNIMENB, long ONCECFIKDCK, int BLCHDPHIDBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class NLDFEBELHCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long NHOIPMAKGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte EPFLGMAHLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int IFJINFLPDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool GLJFNICJMGN;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5698A90", Offset = "0x5697890", VA = "0x185698A90")]
	private NLDFEBELHCF(long ABIDJDPFIPP, byte MJNFMGKBICO, int HBJBDACBKDN, bool KGEFJEKEMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5698850", Offset = "0x5697650", VA = "0x185698850")]
	public static NLDFEBELHCF LNOFPKLJGAE(AMMFFBKCNLA HBICHOPJKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x56989A0", Offset = "0x56977A0", VA = "0x1856989A0")]
	public static AMMFFBKCNLA PABKOABPLOG(long ONCECFIKDCK, byte OOMBHMECJBI, int IMBNAJEFCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5698750", Offset = "0x5697550", VA = "0x185698750")]
	public static AMMFFBKCNLA AFDIBGEGBLI(IKHAHKINKOP GEHNJIMMHDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum ALDIDIEMPIF
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PBGGAECFHGJ
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PLAJCDGHFGI(IPEndPoint IKLAPCOPMDB, IPEndPoint JMBLOMEBCON, string ADNDMAGEPOK);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEOIILOMLCI(IPEndPoint IGKANGODENI, ALDIDIEMPIF DDEINLAGLLL, string ADNDMAGEPOK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FFMDFGEKHAD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct MKDPENNNNOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint MIOPNFKLGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint IKMMKKANDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string IIDPGEKHGAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct MIJCEPGDKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint OAGCLFBIDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public ALDIDIEMPIF LNPLBOHLOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string IIDPGEKHGAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class AANCOHOFKAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint FCGMJFLFBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string IIDPGEKHGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AANCOHOFKAG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class BEKLJCMFGII
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint FCGMJFLFBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint FCCHFIDCIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string IIDPGEKHGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BEKLJCMFGII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KNOCEPFIKDF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IIDPGEKHGAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PPJOIMFLEPD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x81E8A0", Offset = "0x81D6A0", VA = "0x18081E8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7B7D50", Offset = "0x7B6B50", VA = "0x1807B7D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KNOCEPFIKDF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LMNCAIDCPIE BAPJLDGKIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<MKDPENNNNOB> IGDCMAAOPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<MIJCEPGDKOD> OLHCMNMFHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly OBIDBJALLGB GDNGOJAJFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FPOBMNAIFCJ ICPAONKKPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NHPIFEJBHKJ EHOGHEEGEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private PBGGAECFHGJ OEJMNMPJEBA;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int MLNMILMMFKN = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DOHLEFEEJCC;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5685540", Offset = "0x5684340", VA = "0x185685540")]
	internal FFMDFGEKHAD(LMNCAIDCPIE CJOAKJGOHDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5685260", Offset = "0x5684060", VA = "0x185685260")]
	internal void LCHDKPDEIAK(IPEndPoint ABIKPAJJHLI, AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x28AF3F0", Offset = "0x28AE1F0", VA = "0x1828AF3F0")]
	private void BKDPNGCPEBD<T>(T HBICHOPJKGJ, IPEndPoint KCDBINENHAL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x56853C0", Offset = "0x56841C0", VA = "0x1856853C0")]
	private void PLAJCDGHFGI(AANCOHOFKAG PEOGBBCLHPK, IPEndPoint ABIKPAJJHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5684F70", Offset = "0x5683D70", VA = "0x185684F70")]
	private void AFKNPLCOLDO(BEKLJCMFGII PEOGBBCLHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x56850D0", Offset = "0x5683ED0", VA = "0x1856850D0")]
	private void AJPJJKGGKGN(KNOCEPFIKDF PEOGBBCLHPK, IPEndPoint ABIKPAJJHLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum PIJLBOEPILM : byte
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
public enum EINPHEPKLAJ : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class CMEIPCJHFAK
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] EFOBJGPEANC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int MPADLPIOHAK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int HCCFNGCKHCA;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class APGKGDGDEIB : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5684760", Offset = "0x5683560", VA = "0x185684760")]
	public APGKGDGDEIB(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HOICLKIDJNN : APGKGDGDEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5684760", Offset = "0x5683560", VA = "0x185684760")]
	public HOICLKIDJNN(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PLKLBFGFHBN
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
public interface AJPAHNBEPKH
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KACGFKEFNMH(PLKLBFGFHBN FEGBLIIJCJA, string INOMBDBKIKO, params object[] GOFCIAANDLN);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HBOFKIAAPJN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static AJPAHNBEPKH JFDIADOJFFG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object HCHHFHGODPB;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5687110", Offset = "0x5685F10", VA = "0x185687110")]
	private static void PDKBDINEPNM(PLKLBFGFHBN OFKJOHCNMFM, string INOMBDBKIKO, params object[] GOFCIAANDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5686FF0", Offset = "0x5685DF0", VA = "0x185686FF0")]
	internal static void ACEBHMDMEFG(string INOMBDBKIKO, params object[] GOFCIAANDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x56870B0", Offset = "0x5685EB0", VA = "0x1856870B0")]
	internal static void HJHGPMJHHLF(string INOMBDBKIKO, params object[] GOFCIAANDLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5687050", Offset = "0x5685E50", VA = "0x185687050")]
	internal static void BNCGKDDFMIF(string INOMBDBKIKO, params object[] GOFCIAANDLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum MDGJLGIAFFD
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class HFNGCDLEOBB : OBIDBJALLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private AMMFFBKCNLA CFJIBDOOBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LMNCAIDCPIE CPJAOPBCFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly AGGIDLCCIGI MDKDJKBNAEC;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5687500", Offset = "0x5686300", VA = "0x185687500")]
	internal HFNGCDLEOBB(LMNCAIDCPIE JOMBJDFNECI, AGGIDLCCIGI LCGCKDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56873E0", Offset = "0x56861E0", VA = "0x1856873E0")]
	internal void FHMDFIGMJOP(AMMFFBKCNLA HBICHOPJKGJ, int MPBBPCNCDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5687450", Offset = "0x5686250", VA = "0x185687450")]
	internal void IKAFDDGNENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x56874D0", Offset = "0x56862D0", VA = "0x1856874D0")]
	public void NFMPOGBMKCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class AGGIDLCCIGI
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum JCBJOPMIPGH
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
	public AGGIDLCCIGI HFBNPFMLIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public JCBJOPMIPGH LNPLBOHLOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public IKHAHKINKOP LNNADKLDPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint IKMMKKANDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object MHOKMOHFKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int OAJONHNFIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError DFKIFMANGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public JACCNFHDILD IBFEGLDLJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public MDJBHGMPGEF ODFGEDBBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public PIJLBOEPILM JGDGHDMHLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte AMPLCKAMPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly HFNGCDLEOBB BFADGBPMPDK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5683790", Offset = "0x5682590", VA = "0x185683790")]
	public AGGIDLCCIGI(LMNCAIDCPIE JOMBJDFNECI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LMNCAIDCPIE : IEnumerable<IKHAHKINKOP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class ODIPMIAAAGL : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5699720", Offset = "0x5698520", VA = "0x185699720", Slot = "4")]
		public bool Equals(IPEndPoint FCLAAGLFIOD, IPEndPoint OJPNBFDBAHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x517CCE0", Offset = "0x517BAE0", VA = "0x18517CCE0", Slot = "5")]
		public int GetHashCode(IPEndPoint EIFMADKIHON)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ODIPMIAAAGL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct IJFMMHGGEHI : IEnumerator<IKHAHKINKOP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly IKHAHKINKOP ECCCJJDPNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private IKHAHKINKOP BFLBOCHPDJE;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IKHAHKINKOP HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9007C0", Offset = "0x8FF5C0", VA = "0x1809007C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9007C0", Offset = "0x8FF5C0", VA = "0x1809007C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xF74070", Offset = "0xF72E70", VA = "0x180F74070")]
		public IJFMMHGGEHI(IKHAHKINKOP OKKFAPHNPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x56881B0", Offset = "0x5686FB0", VA = "0x1856881B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5688200", Offset = "0x5687000", VA = "0x185688200", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread MHIPEGDCILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool GCFMHHDNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent LEGELJOJKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<AGGIDLCCIGI> LDBJCNIKHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<AGGIDLCCIGI> NPCPEGDPONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private AGGIDLCCIGI APNDMEPPPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LLMIFJPDMMN CDGBLIMFKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly GJGMEPFHKPE BHBNLDFPOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AAPKDLPANEN KAHOIHPLKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MLFJCJOACKE CFFHDMGBNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, IKHAHKINKOP> OOKLAOIKKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, MDJBHGMPGEF> GGBOIALIJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, AFJLGHMBJMD> OFHJJJNICNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JNMGCBBNIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IKHAHKINKOP EDGLPHJJMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int OKGGEGPAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<IKHAHKINKOP> BHBDFEOEGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private IKHAHKINKOP[] CDJGCOIIEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly PLAIIJBJIKK JNMAEGGEBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int FKGHLBPMCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NJIEPIJPFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte ADEMIJGMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object OHIGLOGHBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool OLOHHKGAEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool NIHGJEMHBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int GPIAPDIMJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int MLNEHPGCCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int AFCMHLHHEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int LDJPPNGMPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool GIKPNBPEGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool JJNEGIAEJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int PLFFCAHJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int GOHBILGMNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int PEKDDDLBLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DOHLEFEEJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool IBGOAIMAGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool MCCFMKJKNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool CIDEIPMAPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LBHHDAEHFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int IFCNIGCEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool MEBKKMAFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly KMMDBBFCEIA CCIEJJBOCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool LNEGNJLELLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly FFMDFGEKHAD MCAJMAJAPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool HGKNLCNLEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public MDGJLGIAFFD OHNIMJEIKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int KHLHKEECHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool ABBKGKPHBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool ELJEHOIBBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OEMNAFANCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool DLPFMKGILCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private AMMFFBKCNLA NKPEENBAJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int HLIEPNDBHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object OAPBDHKJPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AMMFFBKCNLA KNNDDJKPCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int ABOGKFHMLPF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int ELFIAFHGKJN = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int FLMDKICBLPP = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private BGFHNCFBLDN CAMGKKLKHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private BGFHNCFBLDN OGNDJIGCPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread KKAJKEEDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread FAPEOAIBPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint PCANLBKMMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint HABDNELHMJO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] PNNFMADAGDF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] HFMHJLDJNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NFMBCCMBJBF, IPEndPoint> GMCFEAGMIKM;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress HMCBDMBHIPO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool IJPJIKKIFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int MJLLODBGJNJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool OEHGGDJKFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA59100", Offset = "0xA57F00", VA = "0x180A59100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB22E00", Offset = "0xB21C00", VA = "0x180B22E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HGLBNMKDDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1326DE0", Offset = "0x1325BE0", VA = "0x181326DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1648890", Offset = "0x1647690", VA = "0x181648890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte ADPEOFKJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C6560", Offset = "0x8C5360", VA = "0x1808C6560")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int HIKPNIJPCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5690700", Offset = "0x568F500", VA = "0x185690700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short CEPCCDGNELB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5692950", Offset = "0x5691750", VA = "0x185692950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5691CA0", Offset = "0x5690AA0", VA = "0x185691CA0")]
	public void HPHMKGFLKEN(IPEndPoint GNILBNJDNPE, byte[] OBPLDLNDJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5692D50", Offset = "0x5691B50", VA = "0x185692D50")]
	public void KEDCANBCPEP(IPEndPoint GNILBNJDNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5693BC0", Offset = "0x56929C0", VA = "0x185693BC0")]
	private bool NKCBALNDCEA(IPEndPoint GNILBNJDNPE, [Out] IKHAHKINKOP GEHNJIMMHDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5692320", Offset = "0x5691120", VA = "0x185692320")]
	private void IHFBICDNKJF(IKHAHKINKOP GEHNJIMMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5691C50", Offset = "0x5690A50", VA = "0x185691C50")]
	private void HBOIDHJFCFF(IKHAHKINKOP GEHNJIMMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5694C10", Offset = "0x5693A10", VA = "0x185694C10")]
	private void PAEFGFHFLOD(IKHAHKINKOP GEHNJIMMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5695150", Offset = "0x5693F50", VA = "0x185695150")]
	public LMNCAIDCPIE(LLMIFJPDMMN OGIGDBJPPDP, [Optional] PLAIIJBJIKK JCALHHIJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56941E0", Offset = "0x5692FE0", VA = "0x1856941E0")]
	internal void NMMINHPPACA(IKHAHKINKOP MHAOHKKKBBF, int ECMFMMLLKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5692000", Offset = "0x5690E00", VA = "0x185692000")]
	internal void IDCIGFHMAIK(IKHAHKINKOP MHAOHKKKBBF, object FMPDDEEEKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x568EA10", Offset = "0x568D810", VA = "0x18568EA10")]
	internal void BAFHFADJNKM(IKHAHKINKOP GEHNJIMMHDJ, JACCNFHDILD JNFKLJKGAMI, SocketError LJGIKLEDAAF, AMMFFBKCNLA LGLMJBOBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5690EA0", Offset = "0x568FCA0", VA = "0x185690EA0")]
	private void FEEIGHEGODC(IKHAHKINKOP GEHNJIMMHDJ, JACCNFHDILD JNFKLJKGAMI, SocketError LJGIKLEDAAF, bool NLMEJPDDFJD, byte[] LHODDAGAJKC, int GJACDHHHCDB, int NJKDAMEBDBN, AMMFFBKCNLA LGLMJBOBFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5692EA0", Offset = "0x5691CA0", VA = "0x185692EA0")]
	private void LDNLNHFPJNM(AGGIDLCCIGI.JCBJOPMIPGH DDEINLAGLLL, [Optional] IKHAHKINKOP GEHNJIMMHDJ, [Optional] IPEndPoint JMBLOMEBCON, SocketError BEPIHCHFDKJ = SocketError.Success, int ECMFMMLLKFL = 0, JACCNFHDILD JFMCEAGPPCE = JACCNFHDILD.ConnectionFailed, [Optional] MDJBHGMPGEF NNHJEEAMPEE, PIJLBOEPILM DBLAOMFEBAH = PIJLBOEPILM.Unreliable, byte BNJKEFJPHFO = 0, [Optional] AMMFFBKCNLA DIGBGEHONHK, [Optional] object FMPDDEEEKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5694230", Offset = "0x5693030", VA = "0x185694230")]
	private void OEKKECHKPBC(AGGIDLCCIGI LCGCKDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5694E70", Offset = "0x5693C70", VA = "0x185694E70")]
	internal void PIHBJBCNIGP(AGGIDLCCIGI LCGCKDGPHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5692A10", Offset = "0x5691810", VA = "0x185692A10")]
	private void JLJCNIAINMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x568F970", Offset = "0x568E770", VA = "0x18568F970")]
	private void CNNBBBOGAIJ(int GGKODNLOCBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5690720", Offset = "0x568F520", VA = "0x185690720")]
	internal IKHAHKINKOP FCGENJLDFJA(MDJBHGMPGEF AIAKOJMKOGA, byte[] JFGGBMOGOML, int GJACDHHHCDB, int PDCHCFIOJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5691840", Offset = "0x5690640", VA = "0x185691840")]
	private int FPDGGEGACND()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x568FD80", Offset = "0x568EB80", VA = "0x18568FD80")]
	private void DHEPGNGHACK(IPEndPoint JMBLOMEBCON, IKHAHKINKOP FPDPGEKAFND, AKJFAEBCIFE FNNMDCOGCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x568EBC0", Offset = "0x568D9C0", VA = "0x18568EBC0")]
	private void BHODMLCACLK(AMMFFBKCNLA HBICHOPJKGJ, IPEndPoint JMBLOMEBCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5691D40", Offset = "0x5690B40", VA = "0x185691D40")]
	internal void HPNCEKNMOBJ(AMMFFBKCNLA HBICHOPJKGJ, PIJLBOEPILM JBMNJPFPMLM, byte BNJKEFJPHFO, int MPBBPCNCDPI, IKHAHKINKOP MHAOHKKKBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5691730", Offset = "0x5690530", VA = "0x185691730")]
	public bool FIAKOELMJPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5691820", Offset = "0x5690620", VA = "0x185691820")]
	public bool FIAKOELMJPA(IPAddress LPKMKFDGMCL, IPAddress OEMEFHJILLF, int AHLCDFAKDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56917A0", Offset = "0x56905A0", VA = "0x1856917A0")]
	public bool FIAKOELMJPA(int AHLCDFAKDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5690560", Offset = "0x568F360", VA = "0x185690560")]
	public void EDEMPEMIKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5694100", Offset = "0x5692F00", VA = "0x185694100")]
	public IKHAHKINKOP NMJMKDMGCDI(string IMHFEJALMMA, int AHLCDFAKDLF, string OBPLDLNDJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5694020", Offset = "0x5692E20", VA = "0x185694020")]
	public IKHAHKINKOP NMJMKDMGCDI(string IMHFEJALMMA, int AHLCDFAKDLF, FPOBMNAIFCJ KDKHJDLLEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5693C50", Offset = "0x5692A50", VA = "0x185693C50")]
	public IKHAHKINKOP NMJMKDMGCDI(IPEndPoint KCDBINENHAL, FPOBMNAIFCJ KDKHJDLLEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5692940", Offset = "0x5691740", VA = "0x185692940")]
	public void IMCOABBNLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x56925F0", Offset = "0x56913F0", VA = "0x1856925F0")]
	public void IMCOABBNLJH(bool JLBIPLDHAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x56919E0", Offset = "0x56907E0", VA = "0x1856919E0")]
	public void GJDPPCGHFNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x56918C0", Offset = "0x56906C0", VA = "0x1856918C0")]
	public void GJDPPCGHFNO(byte[] LHODDAGAJKC, int GJACDHHHCDB, int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5690D30", Offset = "0x568FB30", VA = "0x185690D30")]
	public void FEEIGHEGODC(IKHAHKINKOP GEHNJIMMHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5690DE0", Offset = "0x568FBE0", VA = "0x185690DE0")]
	public void FEEIGHEGODC(IKHAHKINKOP GEHNJIMMHDJ, byte[] LHODDAGAJKC, int GJACDHHHCDB, int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5694F70", Offset = "0x5693D70", VA = "0x185694F70", Slot = "4")]
	private IEnumerator<IKHAHKINKOP> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5695000", Offset = "0x5693E00", VA = "0x185695000", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5693260", Offset = "0x5692060", VA = "0x185693260")]
	private AMMFFBKCNLA LGFEPCKKGAA(LAJCHKPBKLC CINANBNCBIJ, int CGDBKIJPKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5693340", Offset = "0x5692140", VA = "0x185693340")]
	private AMMFFBKCNLA LGFEPCKKGAA(LAJCHKPBKLC CINANBNCBIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x56949E0", Offset = "0x56937E0", VA = "0x1856949E0")]
	internal AMMFFBKCNLA OKCBLHIJEAA(int CGDBKIJPKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x568E7C0", Offset = "0x568D5C0", VA = "0x18568E7C0")]
	internal void APNLIENJIHD(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5695090", Offset = "0x5693E90", VA = "0x185695090")]
	static LMNCAIDCPIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA59100", Offset = "0xA57F00", VA = "0x180A59100")]
	private bool LDNDMEBKADH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x568FC90", Offset = "0x568EA90", VA = "0x18568FC90")]
	private void DGNNKMHCNAF(IPEndPoint JNPDNMCDJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x568EAE0", Offset = "0x568D8E0", VA = "0x18568EAE0")]
	private void BFFOILDIBMJ(IPEndPoint JNPDNMCDJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5693A20", Offset = "0x5692820", VA = "0x185693A20")]
	private bool NCJPANOLBOH(SocketException MCKOJGJOINA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5692050", Offset = "0x5690E50", VA = "0x185692050")]
	private void IFDGNGBHIBO(BGFHNCFBLDN CJOAKJGOHDB, EndPoint GEEBDFBPFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568EFE0", VA = "0x1856901E0")]
	private void DNIHHOFIHGG(object DEPIDMABJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5690F80", Offset = "0x568FD80", VA = "0x185690F80")]
	public bool FIAKOELMJPA(IPAddress LPKMKFDGMCL, IPAddress OEMEFHJILLF, int AHLCDFAKDLF, bool FGBPAAIIBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x568F910", Offset = "0x568E710", VA = "0x18568F910")]
	internal int CKIKENFGABG(AMMFFBKCNLA HBICHOPJKGJ, IPEndPoint JMBLOMEBCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5693420", Offset = "0x5692220", VA = "0x185693420")]
	internal int LIALNIBAIOD(AMMFFBKCNLA HBICHOPJKGJ, IPEndPoint JMBLOMEBCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5693460", Offset = "0x5692260", VA = "0x185693460")]
	internal int LIALNIBAIOD(byte[] HPJAAILCALJ, int GJACDHHHCDB, int PDCHCFIOJCE, IPEndPoint JMBLOMEBCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5691AE0", Offset = "0x56908E0", VA = "0x185691AE0")]
	internal void GJIADFMALNG(bool OBHMPMPAIEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LAJCHKPBKLC : byte
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
internal sealed class AMMFFBKCNLA
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int BLPLBOABJIB;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] BBCBDHEJACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] GMHGAIFFPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int EDOPLBKMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object MHOKMOHFKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public AMMFFBKCNLA HFBNPFMLIOA;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LAJCHKPBKLC JPHMNJIAJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x56842C0", Offset = "0x56830C0", VA = "0x1856842C0")]
		get
		{
			return default(LAJCHKPBKLC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5684220", Offset = "0x5683020", VA = "0x185684220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte EPFLGMAHLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x56841F0", Offset = "0x5682FF0", VA = "0x1856841F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5683DC0", Offset = "0x5682BC0", VA = "0x185683DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort NHNJIKNOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5683E00", Offset = "0x5682C00", VA = "0x185683E00")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5683FF0", Offset = "0x5682DF0", VA = "0x185683FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BKBADILDNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5683D00", Offset = "0x5682B00", VA = "0x185683D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte HDGACOIBHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5683FC0", Offset = "0x5682DC0", VA = "0x185683FC0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5683D30", Offset = "0x5682B30", VA = "0x185683D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort DDGFPEJCELO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5684260", Offset = "0x5683060", VA = "0x185684260")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5684170", Offset = "0x5682F70", VA = "0x185684170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort NFJBJCEEJGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5683E60", Offset = "0x5682C60", VA = "0x185683E60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x56841B0", Offset = "0x5682FB0", VA = "0x1856841B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JFEJHIHPFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5683D60", Offset = "0x5682B60", VA = "0x185683D60")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5684130", Offset = "0x5682F30", VA = "0x185684130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5684320", Offset = "0x5683120", VA = "0x185684320")]
	static AMMFFBKCNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x56842F0", Offset = "0x56830F0", VA = "0x1856842F0")]
	public void PDCIDFOBFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x56845E0", Offset = "0x56833E0", VA = "0x1856845E0")]
	public AMMFFBKCNLA(int CGDBKIJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5684650", Offset = "0x5683450", VA = "0x185684650")]
	public AMMFFBKCNLA(LAJCHKPBKLC CINANBNCBIJ, int CGDBKIJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5684030", Offset = "0x5682E30", VA = "0x185684030")]
	public static int HKAFHMLNMBL(LAJCHKPBKLC CINANBNCBIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x56840A0", Offset = "0x5682EA0", VA = "0x1856840A0")]
	public int HKAFHMLNMBL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5683EC0", Offset = "0x5682CC0", VA = "0x185683EC0")]
	public bool EEEHFMKKGND()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum FKGEFCKMHDO : byte
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
internal enum MELOBPNNMBN
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
internal enum IAOOFPFBFIN
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum ALIOGIDEGGC
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IKHAHKINKOP
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BIKEFJCOJEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AMMFFBKCNLA[] AEPINIBECGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int FOGBCMFJNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int BBJJHENEHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte HDGACOIBHDE;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public BIKEFJCOJEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void CDNBAHEEPFA(ulong NNGKBFDKKLL, int OFINJJBHBLM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int MECNGGEOJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HOOHPDGPMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int OLOFANLIOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double EKFEBDOPJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int EAAHIHLECPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int DPCAIKNDBCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int DKGNDDNHNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch KNPJGGOEMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int KKPLJFDHADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long PMLGLIFJCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object GEDGADCNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal IKHAHKINKOP LEAODMHGNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal IKHAHKINKOP OPFGJPCLOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<AMMFFBKCNLA> KDCBCIOKAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<KEAFNNMKHPJ> BGMEHEDFDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly KEAFNNMKHPJ[] LCHHBNPPGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int JMEDBNMEAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int NFGBOCKMMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool ILPCBJOPJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int EGNLEIJAEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int GGDJOOPKJGN;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int FHJGBIEKIAA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int MHJBDIGFCNL = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object IHOIIBHCLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int DJKIOLCDOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, BIKEFJCOJEM> DOLDEIBOJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> GJDNDGAEGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly AMMFFBKCNLA PMLPEEKKAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int BHLOJPIMBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int PHAEAOOBJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint NCAKBHBEAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int BOHEHNKHCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HEDONHPEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long OLMENCHOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte PNIHGFHIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FKGEFCKMHDO LBAMGGIPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private AMMFFBKCNLA GOKLMLIGNCH;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int NKLNFPGGNMB = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int JCIHEEBLIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly AMMFFBKCNLA DIPEHCJICHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly AMMFFBKCNLA FDIGMPHJHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly AMMFFBKCNLA PEICPMEHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly AMMFFBKCNLA MGPOCKLKPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private EINPHEPKLAJ MFNNNODBJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly LMNCAIDCPIE LNPFFACBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int FLJIHJMFGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object IPPGHDONLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly KMMDBBFCEIA CCIEJJBOCPD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte CNELHOGBGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA97910", Offset = "0xA96710", VA = "0x180A97910")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5688880", Offset = "0x5687680", VA = "0x185688880")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint LHHGGOENFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8CF3D0", Offset = "0x8CE1D0", VA = "0x1808CF3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FKGEFCKMHDO NPJNBIFGJHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x16649D0", Offset = "0x16637D0", VA = "0x1816649D0")]
		get
		{
			return default(FKGEFCKMHDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long CECNBGCKOIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7BB620", Offset = "0x7BA420", VA = "0x1807BB620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int DOEGOPIDBBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB66AB0", Offset = "0xB658B0", VA = "0x180B66AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1475480", Offset = "0x1474280", VA = "0x181475480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int FIPNELMOHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x568AD20", Offset = "0x5689B20", VA = "0x18568AD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int BKABFBHMHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF240", Offset = "0x7BE040", VA = "0x1807BF240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double DPNOPNIMCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x18935E0", Offset = "0x18923E0", VA = "0x1818935E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CDNBAHEEPFA PHGNPIOOKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x56893F0", Offset = "0x56881F0", VA = "0x1856893F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x568A6C0", Offset = "0x56894C0", VA = "0x18568A6C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x568BAD0", Offset = "0x568A8D0", VA = "0x18568BAD0")]
	internal IKHAHKINKOP(LMNCAIDCPIE LNAIAFCAHPF, IPEndPoint JMBLOMEBCON, int NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56889E0", Offset = "0x56877E0", VA = "0x1856889E0")]
	internal void GLBHMMKNEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56886A0", Offset = "0x56874A0", VA = "0x1856886A0")]
	internal void FIMKIDOHMAN(IPEndPoint HGFILMNGMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x568BA40", Offset = "0x568A840", VA = "0x18568BA40")]
	internal void PNFDJHGDJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x568AD70", Offset = "0x5689B70", VA = "0x18568AD70")]
	private void PAJAOBOAOLK(int HKPGHBDEDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x568AD30", Offset = "0x5689B30", VA = "0x18568AD30")]
	private void OHGGOFPLHKD(int JDKPLFCMKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x56886D0", Offset = "0x56874D0", VA = "0x1856886D0")]
	private KEAFNNMKHPJ FJABCLIFKFE(byte OMMBGLAGAJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x568BF20", Offset = "0x568AD20", VA = "0x18568BF20")]
	internal IKHAHKINKOP(LMNCAIDCPIE LNAIAFCAHPF, IPEndPoint JMBLOMEBCON, int NLFEJIHGBIC, byte OOMBHMECJBI, FPOBMNAIFCJ GECHFPJADIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x568C0B0", Offset = "0x568AEB0", VA = "0x18568C0B0")]
	internal IKHAHKINKOP(LMNCAIDCPIE LNAIAFCAHPF, MDJBHGMPGEF AIAKOJMKOGA, int NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5688250", Offset = "0x5687050", VA = "0x185688250")]
	internal void ADDKAOIPEPH(AKJFAEBCIFE PGBJOKMBHGG, byte[] LHODDAGAJKC, int GJACDHHHCDB, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5689370", Offset = "0x5688170", VA = "0x185689370")]
	internal bool IALANHGGAMA(NLDFEBELHCF HBICHOPJKGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x56884B0", Offset = "0x56872B0", VA = "0x1856884B0")]
	public void BKDPNGCPEBD(byte[] LHODDAGAJKC, int GJACDHHHCDB, int PDCHCFIOJCE, PIJLBOEPILM KDIJMIPPONN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x568A770", Offset = "0x5689570", VA = "0x18568A770")]
	private void NMIAOIOOLON(byte[] LHODDAGAJKC, int GJACDHHHCDB, int PDCHCFIOJCE, byte BNJKEFJPHFO, PIJLBOEPILM DBLAOMFEBAH, object FMPDDEEEKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5688930", Offset = "0x5687730", VA = "0x185688930")]
	public void GKIBOMIFMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5689B20", Offset = "0x5688920", VA = "0x185689B20")]
	internal IAOOFPFBFIN JCOAMMDCLLB(AMMFFBKCNLA HBICHOPJKGJ)
	{
		return default(IAOOFPFBFIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x568ACC0", Offset = "0x5689AC0", VA = "0x18568ACC0")]
	internal void OAEIPBPJMCF(KEAFNNMKHPJ IJOCAKMCLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x56894A0", Offset = "0x56882A0", VA = "0x1856894A0")]
	internal ALIOGIDEGGC IJEBCPEJMIN(byte[] LHODDAGAJKC, int GJACDHHHCDB, int PDCHCFIOJCE, bool NLMEJPDDFJD)
	{
		return default(ALIOGIDEGGC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5688470", Offset = "0x5687270", VA = "0x185688470")]
	private void BJBLFDJBFML(int EOGIJINMBHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5689C00", Offset = "0x5688A00", VA = "0x185689C00")]
	internal void LBOMAOAGELP(PIJLBOEPILM JBMNJPFPMLM, AMMFFBKCNLA OKKFAPHNPBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x568B4F0", Offset = "0x568A2F0", VA = "0x18568B4F0")]
	private void PNDDNAJDAEP(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x56897B0", Offset = "0x56885B0", VA = "0x1856897B0")]
	private void ILJCBLAKOEK(int KAFHCFGLIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x56884E0", Offset = "0x56872E0", VA = "0x1856884E0")]
	internal MELOBPNNMBN DHEPGNGHACK(AKJFAEBCIFE FNNMDCOGCHD)
	{
		return default(MELOBPNNMBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5688A00", Offset = "0x5687800", VA = "0x185688A00")]
	internal void GLNNFHPEAPD(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x568A5A0", Offset = "0x56893A0", VA = "0x18568A5A0")]
	private void LNOJLBIAEHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x56882A0", Offset = "0x56870A0", VA = "0x1856882A0")]
	internal void AIHELJPJMCN(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x568AE40", Offset = "0x5689C40", VA = "0x18568AE40")]
	internal void PHAFDIODDDG(int KAFHCFGLIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x56890B0", Offset = "0x5687EB0", VA = "0x1856890B0")]
	internal void HDGJNFJLKND(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class KMMDBBFCEIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long FEBLMOAEHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long EJFKBAAKPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long MAPLMGNHIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long PJGDHBEIIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long EPGPEMAJPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long EOLHPBGIFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long NIHBOEBCDEL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long DPEIEMODNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x568CF90", Offset = "0x568BD90", VA = "0x18568CF90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long KIOLFPHJDFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x568CFB0", Offset = "0x568BDB0", VA = "0x18568CFB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long FNLPMMONNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x568CF20", Offset = "0x568BD20", VA = "0x18568CF20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long CFGPFBBHJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x568D0C0", Offset = "0x568BEC0", VA = "0x18568D0C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long APBODBBNAIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x568CFF0", Offset = "0x568BDF0", VA = "0x18568CFF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long KKHDKIKGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x568D0A0", Offset = "0x568BEA0", VA = "0x18568D0A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private EINPHEPKLAJ KCNLKLKAHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7C00", Offset = "0x1AF6A00", VA = "0x181AF7C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double MAAIHJDKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x568CE40", Offset = "0x568BC40", VA = "0x18568CE40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x568CF30", Offset = "0x568BD30", VA = "0x18568CF30")]
	public void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x568CFC0", Offset = "0x568BDC0", VA = "0x18568CFC0")]
	public void LDCFFNKBBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x568D0B0", Offset = "0x568BEB0", VA = "0x18568D0B0")]
	public void NJEDDBDNOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x568CED0", Offset = "0x568BCD0", VA = "0x18568CED0")]
	public void GHFLIIEFAJH(long NPCNAIFODIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x568CFA0", Offset = "0x568BDA0", VA = "0x18568CFA0")]
	public void JGPHNCDHKNC(long IGGGJMEFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x568CEA0", Offset = "0x568BCA0", VA = "0x18568CEA0")]
	public void EJMBPKMKPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x568CEE0", Offset = "0x568BCE0", VA = "0x18568CEE0")]
	public void GLGEACJEHBL(long JJMCHCGBGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x568D0D0", Offset = "0x568BED0", VA = "0x18568D0D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x568D000", Offset = "0x568BE00", VA = "0x18568D000")]
	public void LGCJPLPPHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public KMMDBBFCEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EEMEIGBOPBO
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> MLHPIEFPHKG;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5684A30", Offset = "0x5683830", VA = "0x185684A30")]
	public static IPEndPoint CAMMMPIFAHJ(string KOHIMIAAICH, int AHLCDFAKDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5684C80", Offset = "0x5683A80", VA = "0x185684C80")]
	public static IPAddress JHLKPBAHKMG(string KOHIMIAAICH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5684E50", Offset = "0x5683C50", VA = "0x185684E50")]
	public static IPAddress JHLKPBAHKMG(string KOHIMIAAICH, AddressFamily NDMOFGEBPAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5684A00", Offset = "0x5683800", VA = "0x185684A00")]
	internal static int BKIONJAHOMM(int DOKLDGJKBHB, int CAMFMONNIFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2770670", Offset = "0x276F470", VA = "0x182770670")]
	internal static T[] PCGKOFGOHED<T>(int NJKDAMEBDBN) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LOBMDLLDEJE : KEAFNNMKHPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct KCJMOIANBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private AMMFFBKCNLA CFJIBDOOBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long HJAJAMNBNFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool EPICBMCCMOJ;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x568CBE0", Offset = "0x568B9E0", VA = "0x18568CBE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x568CBC0", Offset = "0x568B9C0", VA = "0x18568CBC0")]
		public void LMFMKFLHHJJ(AMMFFBKCNLA HBICHOPJKGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x568CB50", Offset = "0x568B950", VA = "0x18568CB50")]
		public bool KPIKEAAABJE(long EIJMBHBKALN, IKHAHKINKOP GEHNJIMMHDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x568CB00", Offset = "0x568B900", VA = "0x18568CB00")]
		public bool HOCLBDDCDMI(IKHAHKINKOP GEHNJIMMHDJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly AMMFFBKCNLA OGMFAEEPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly KCJMOIANBFP[] FBADOJPCGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly AMMFFBKCNLA[] BNABAEHDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] PLGABJLMHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int GFBJOLLAIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int FFIMGGAJDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int DBMBNOBJOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int DCAJHIHDADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool DFJFFPJGFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly PIJLBOEPILM IDKBLJCLHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool LNAIPJBBILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int KABAPHNPDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte FGMIPCJDALI;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5696670", Offset = "0x5695470", VA = "0x185696670")]
	public LOBMDLLDEJE(IKHAHKINKOP GEHNJIMMHDJ, bool LJFCGLPGMHI, byte NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x56957A0", Offset = "0x56945A0", VA = "0x1856957A0")]
	private void BDHMHPCLDMJ(AMMFFBKCNLA HBICHOPJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56961C0", Offset = "0x5694FC0", VA = "0x1856961C0", Slot = "4")]
	protected override bool LNHPKAGFLCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5695B60", Offset = "0x5694960", VA = "0x185695B60", Slot = "5")]
	public override bool GLNNFHPEAPD(AMMFFBKCNLA HBICHOPJKGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JINBMEFHDKA : KEAFNNMKHPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int FFHNBHKIJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort FFIMGGAJDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool PDIFCOONMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private AMMFFBKCNLA DMCIHEAOKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly AMMFFBKCNLA DLDMEFOEEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool MMOLFHPHAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte FGMIPCJDALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long JFDNENPPKOM;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x568CA40", Offset = "0x568B840", VA = "0x18568CA40")]
	public JINBMEFHDKA(IKHAHKINKOP GEHNJIMMHDJ, bool IBNIAABIEMM, byte NLFEJIHGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x568C5A0", Offset = "0x568B3A0", VA = "0x18568C5A0", Slot = "4")]
	protected override bool LNHPKAGFLCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x568C290", Offset = "0x568B090", VA = "0x18568C290", Slot = "5")]
	public override bool GLNNFHPEAPD(AMMFFBKCNLA HBICHOPJKGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class BPDAOGHAEMC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct MJPGEDIBAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong FDIPMEOJIAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double OMFCPLJHBDL;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OLMCMFIKAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int FNMOFMLAEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float NMMGLHENPEP;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5683500", Offset = "0x5682300", VA = "0x185683500")]
	private static void JEBKFPLANBI(byte[] GGBNILIIFNK, int PJPGJICIKPG, ulong LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5684780", Offset = "0x5683580", VA = "0x185684780")]
	private static void JEBKFPLANBI(byte[] GGBNILIIFNK, int PJPGJICIKPG, int LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5684810", Offset = "0x5683610", VA = "0x185684810")]
	public static void JEBKFPLANBI(byte[] GGBNILIIFNK, int PJPGJICIKPG, short LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x56847F0", Offset = "0x56835F0", VA = "0x1856847F0")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, double DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5684850", Offset = "0x5683650", VA = "0x185684850")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5684810", Offset = "0x5683610", VA = "0x185684810")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, short DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5684810", Offset = "0x5683610", VA = "0x185684810")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, ushort DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5684780", Offset = "0x5683580", VA = "0x185684780")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5684780", Offset = "0x5683580", VA = "0x185684780")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, uint DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5684770", Offset = "0x5683570", VA = "0x185684770")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, long DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5684770", Offset = "0x5683570", VA = "0x185684770")]
	public static void JCJJDEGGCBM(byte[] KKAMOMBNLOJ, int DLJHEFPEFCO, ulong DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OBIDBJALLGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] EOMDOAOMKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int ILLNBJDJEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int OFOIEBIMNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int IAGFGKIEAGA;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] GMHGAIFFPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LPJEILFNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int EIOOEBAIJLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5698DF0", Offset = "0x5697BF0", VA = "0x185698DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GOEIHCDBOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D4B950", Offset = "0x1D4A750", VA = "0x181D4B950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int MAILNKGCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5699560", Offset = "0x5698360", VA = "0x185699560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5698E00", Offset = "0x5697C00", VA = "0x185698E00")]
	public void FHMDFIGMJOP(byte[] PFNKIIMPMKG, int PJPGJICIKPG, int PBELDGKDKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public OBIDBJALLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x56996C0", Offset = "0x56984C0", VA = "0x1856996C0")]
	public OBIDBJALLGB(byte[] PFNKIIMPMKG, int PJPGJICIKPG, int PBELDGKDKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x56995F0", Offset = "0x56983F0", VA = "0x1856995F0")]
	public IPEndPoint PEOMJABOGNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5698FA0", Offset = "0x5697DA0", VA = "0x185698FA0")]
	public byte HCAJCGJIKPI()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5698FA0", Offset = "0x5697DA0", VA = "0x185698FA0")]
	public sbyte IHIFNLNNKIL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2A1F690", Offset = "0x2A1E490", VA = "0x182A1F690")]
	public T[] IAEECHFCINB<T>(ushort CGDBKIJPKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5698DB0", Offset = "0x5697BB0", VA = "0x185698DB0")]
	public bool[] EFJIIOGCPNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x56995B0", Offset = "0x56983B0", VA = "0x1856995B0")]
	public ushort[] PEGADEDJNGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5698B90", Offset = "0x5697990", VA = "0x185698B90")]
	public short[] CBJJNJCIAMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5698F60", Offset = "0x5697D60", VA = "0x185698F60")]
	public int[] GGOMBOEEOPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x56990F0", Offset = "0x5697EF0", VA = "0x1856990F0")]
	public uint[] KACLNKFOOAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5698B50", Offset = "0x5697950", VA = "0x185698B50")]
	public float[] AMJBMEECGIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5698BD0", Offset = "0x56979D0", VA = "0x185698BD0")]
	public double[] CEPMJCPIHDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5699040", Offset = "0x5697E40", VA = "0x185699040")]
	public long[] JBOKAHCDEON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5699570", Offset = "0x5698370", VA = "0x185699570")]
	public ulong[] OHDBPCMCOLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5698C80", Offset = "0x5697A80", VA = "0x185698C80")]
	public string[] ECCLIABNPEL(int CMKEHGOLKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5698E40", Offset = "0x5697C40", VA = "0x185698E40")]
	public bool FNHOEHHECIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5698AE0", Offset = "0x56978E0", VA = "0x185698AE0")]
	public char JHAAFKJDILJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5698AE0", Offset = "0x56978E0", VA = "0x185698AE0")]
	public ushort ADOLMDMCNIF()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5699080", Offset = "0x5697E80", VA = "0x185699080")]
	public short JIAJHHAFIDF()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5699440", Offset = "0x5698240", VA = "0x185699440")]
	public long NAAPDMKFFPG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x56994F0", Offset = "0x56982F0", VA = "0x1856994F0")]
	public ulong NINNJLGMLEH()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5699130", Offset = "0x5697F30", VA = "0x185699130")]
	public int KCCDIDFCODO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5698E80", Offset = "0x5697C80", VA = "0x185698E80")]
	public uint GFIBPMKNEEB()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5698C10", Offset = "0x5697A10", VA = "0x185698C10")]
	public float DLPHKGMPPAD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5698EF0", Offset = "0x5697CF0", VA = "0x185698EF0")]
	public double GGIHCDFBBON()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5699210", Offset = "0x5698010", VA = "0x185699210")]
	public string MNCFEJMACCA(int FDGBOAPMAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x56991A0", Offset = "0x5697FA0", VA = "0x1856991A0")]
	public ArraySegment<byte> LCIFMMJPFPK(int NJKDAMEBDBN)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56994B0", Offset = "0x56982B0", VA = "0x1856994B0")]
	public sbyte[] NFFNMCDMMJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5699000", Offset = "0x5697E00", VA = "0x185699000")]
	public byte[] INIGDIOFDMM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5698FE0", Offset = "0x5697DE0", VA = "0x185698FE0")]
	public void HOCLBDDCDMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FPOBMNAIFCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] EOMDOAOMKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int ILLNBJDJEEE;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int NAIODGLGHJO = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool KIEFIPPPIAD;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding IFACLDDPMDL;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int GPDCAKIFAHH = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] CCHKACEPAFP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] OJPNFDCEOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NIBNLPMGPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7AE670", Offset = "0x7AD470", VA = "0x1807AE670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5686750", Offset = "0x5685550", VA = "0x185686750")]
	public FPOBMNAIFCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56866B0", Offset = "0x56854B0", VA = "0x1856866B0")]
	public FPOBMNAIFCJ(bool OGHOGEMLNGA, int FNGLAKCPFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5685EC0", Offset = "0x5684CC0", VA = "0x185685EC0")]
	public static FPOBMNAIFCJ DBGAPGPDIJP(string DIBNBLEEFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5686590", Offset = "0x5685390", VA = "0x185686590")]
	public void NNPAKFLOAJN(int BHALBPKOEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC59A0", Offset = "0x1DC47A0", VA = "0x181DC59A0")]
	public void HJOLGBAAIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5685F30", Offset = "0x5684D30", VA = "0x185685F30")]
	public void NACNFMKPMCE(float DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x56860A0", Offset = "0x5684EA0", VA = "0x1856860A0")]
	public void NACNFMKPMCE(double DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5686160", Offset = "0x5684F60", VA = "0x185686160")]
	public void NACNFMKPMCE(long DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5686160", Offset = "0x5684F60", VA = "0x185686160")]
	public void NACNFMKPMCE(ulong DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x56861B0", Offset = "0x5684FB0", VA = "0x1856861B0")]
	public void NACNFMKPMCE(int DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x56861B0", Offset = "0x5684FB0", VA = "0x1856861B0")]
	public void NACNFMKPMCE(uint DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5686030", Offset = "0x5684E30", VA = "0x185686030")]
	public void NACNFMKPMCE(char DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5686030", Offset = "0x5684E30", VA = "0x185686030")]
	public void NACNFMKPMCE(ushort DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5686030", Offset = "0x5684E30", VA = "0x185686030")]
	public void NACNFMKPMCE(short DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5686100", Offset = "0x5684F00", VA = "0x185686100")]
	public void NACNFMKPMCE(sbyte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5686100", Offset = "0x5684F00", VA = "0x185686100")]
	public void NACNFMKPMCE(byte DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5686310", Offset = "0x5685110", VA = "0x185686310")]
	public void NACNFMKPMCE(byte[] LHODDAGAJKC, int PJPGJICIKPG, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5685DE0", Offset = "0x5684BE0", VA = "0x185685DE0")]
	public void FOCJEFKLHCJ(sbyte[] LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5685DE0", Offset = "0x5684BE0", VA = "0x185685DE0")]
	public void OJOAHHCGCEN(byte[] LHODDAGAJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5685FD0", Offset = "0x5684DD0", VA = "0x185685FD0")]
	public void NACNFMKPMCE(bool DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5685D00", Offset = "0x5684B00", VA = "0x185685D00")]
	public void BNKJIEBOALD(Array IIEPPHLALMH, int FNGKFBLEGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5685990", Offset = "0x5684790", VA = "0x185685990")]
	public void BNKJIEBOALD(float[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5685C20", Offset = "0x5684A20", VA = "0x185685C20")]
	public void BNKJIEBOALD(double[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5685C20", Offset = "0x5684A20", VA = "0x185685C20")]
	public void BNKJIEBOALD(long[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5685C20", Offset = "0x5684A20", VA = "0x185685C20")]
	public void BNKJIEBOALD(ulong[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5685990", Offset = "0x5684790", VA = "0x185685990")]
	public void BNKJIEBOALD(int[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5685990", Offset = "0x5684790", VA = "0x185685990")]
	public void BNKJIEBOALD(uint[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5685A70", Offset = "0x5684870", VA = "0x185685A70")]
	public void BNKJIEBOALD(ushort[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5685A70", Offset = "0x5684870", VA = "0x185685A70")]
	public void BNKJIEBOALD(short[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5685DE0", Offset = "0x5684BE0", VA = "0x185685DE0")]
	public void BNKJIEBOALD(bool[] DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5685B50", Offset = "0x5684950", VA = "0x185685B50")]
	public void BNKJIEBOALD(string[] DIBNBLEEFNN, int GDGKFPMAMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5686240", Offset = "0x5685040", VA = "0x185686240")]
	public void NACNFMKPMCE(IPEndPoint GNILBNJDNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x56860F0", Offset = "0x5684EF0", VA = "0x1856860F0")]
	public void NACNFMKPMCE(string DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5686380", Offset = "0x5685180", VA = "0x185686380")]
	public void NACNFMKPMCE(string DIBNBLEEFNN, int FDGBOAPMAKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class NHPIFEJBHKJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class HAGNNGHMNOA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong FLJIHJMFGKK;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x39A2A20", Offset = "0x39A1820", VA = "0x1839A2A20")]
		static HAGNNGHMNOA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void ILCAJKPPMJG(OBIDBJALLGB HGAPEJGOMLD, object FMPDDEEEKPA);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class NALGDGLLAPO<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public NHPIFEJBHKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public NALGDGLLAPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3FF23C0", Offset = "0x3FF11C0", VA = "0x183FF23C0")]
		internal void BGIPHPKCJBO(OBIDBJALLGB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DNKIOBEEGIC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public NHPIFEJBHKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public DNKIOBEEGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x515E960", Offset = "0x515D760", VA = "0x18515E960")]
		internal void BGIPHPKCJBO(OBIDBJALLGB reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly OIOCPJPGPHI APPEGOEBGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, ILCAJKPPMJG> GKIECIDEINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FPOBMNAIFCJ LAJCENJAIPB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x56985D0", Offset = "0x56973D0", VA = "0x1856985D0")]
	public NHPIFEJBHKJ(int CMKEHGOLKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2712050", Offset = "0x2710E50", VA = "0x182712050", Slot = "4")]
	protected virtual ulong IFCIEJGGKOM<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5698420", Offset = "0x5697220", VA = "0x185698420", Slot = "5")]
	protected virtual ILCAJKPPMJG LJDLCBLNEIL(OBIDBJALLGB HGAPEJGOMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A078C0", Offset = "0x2A066C0", VA = "0x182A078C0", Slot = "6")]
	protected virtual void FHGGBNPALGP<T>(FPOBMNAIFCJ DFHABBFDBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5698550", Offset = "0x5697350", VA = "0x185698550")]
	public void MEGAAKEBJKM(OBIDBJALLGB HGAPEJGOMLD, object FMPDDEEEKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A07930", Offset = "0x2A06730", VA = "0x182A07930")]
	public void JHIMPLGLBKB<T>(FPOBMNAIFCJ DFHABBFDBND, T HBICHOPJKGJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x56983D0", Offset = "0x56971D0", VA = "0x1856983D0")]
	public void JDNGNNDPCPP(OBIDBJALLGB HGAPEJGOMLD, object FMPDDEEEKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2A07740", Offset = "0x2A06540", VA = "0x182A07740")]
	public void BFKLNDDMDGP<T>(Action<T> HNKAHGNABJB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A075C0", Offset = "0x2A063C0", VA = "0x182A075C0")]
	public void BFKLNDDMDGP<T, TUserData>(Action<T, TUserData> HNKAHGNABJB) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BMJJLECNNLP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5684760", Offset = "0x5683560", VA = "0x185684760")]
	public BMJJLECNNLP(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class EEKGCJENIEE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x56849A0", Offset = "0x56837A0", VA = "0x1856849A0")]
	public EEKGCJENIEE(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class OIOCPJPGPHI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum HIOJBIOLMAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class OPPPLHNKNLJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public HIOJBIOLMAD LNPLBOHLOBB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x412F310", Offset = "0x412E110", VA = "0x18412F310", Slot = "4")]
		public virtual void LMFMKFLHHJJ(MethodInfo ACNKIEGLFJA, MethodInfo OIFGMJBBGFA, HIOJBIOLMAD DDEINLAGLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void PGJEHPJCMFM(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void ICNOBDIDFML(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		protected OPPPLHNKNLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class GIKEGIEPEKC<TClass, TProperty> : OPPPLHNKNLJ<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> HHPLPFLIMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> DAELLLGIKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> JHHAGHHECAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> KCJEBOCLPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> DHMOMPDNOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> MNNPCKDADAP;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x393EC30", Offset = "0x393DA30", VA = "0x18393EC30", Slot = "7")]
		public override void BNDFDKBAFEO(TClass LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x393FDB0", Offset = "0x393EBB0", VA = "0x18393FDB0", Slot = "8")]
		public override void EGDAAJBNKIL(TClass LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3945FE0", Offset = "0x3944DE0", VA = "0x183945FE0", Slot = "9")]
		public override void PGJEHPJCMFM(TClass LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3940750", Offset = "0x393F550", VA = "0x183940750", Slot = "10")]
		public override void ICNOBDIDFML(TClass LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3945710", Offset = "0x3944510", VA = "0x183945710")]
		protected TProperty[] PBPNKPLKICJ(TClass LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3940E50", Offset = "0x393FC50", VA = "0x183940E50")]
		protected TProperty[] LFLDLHECFFE(TClass LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x39440D0", Offset = "0x3942ED0", VA = "0x1839440D0", Slot = "4")]
		public override void LMFMKFLHHJJ(MethodInfo ACNKIEGLFJA, MethodInfo OIFGMJBBGFA, HIOJBIOLMAD DDEINLAGLLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3946360", Offset = "0x3945160", VA = "0x183946360")]
		protected GIKEGIEPEKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class CHGJIAJEANN<TClass, TProperty> : GIKEGIEPEKC<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void NHBMLFLHMLM(OBIDBJALLGB HFJACMIAHKE, [Out] TProperty LOOCKFEEHLM);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void FGDOKPBEIDI(FPOBMNAIFCJ EEKLJBLGCEC, TProperty LOOCKFEEHLM);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x4D22250", Offset = "0x4D21050", VA = "0x184D22250", Slot = "5")]
		public override void DHCDCJJKPAK(TClass LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x4D22490", Offset = "0x4D21290", VA = "0x184D22490", Slot = "6")]
		public override void JHIMPLGLBKB(TClass LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x4D22110", Offset = "0x4D20F10", VA = "0x184D22110", Slot = "7")]
		public override void BNDFDKBAFEO(TClass LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x4D22350", Offset = "0x4D21150", VA = "0x184D22350", Slot = "8")]
		public override void EGDAAJBNKIL(TClass LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3A85140", Offset = "0x3A83F40", VA = "0x183A85140")]
		protected CHGJIAJEANN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class LEJFJOOJDBE<T> : GIKEGIEPEKC<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0EA0", Offset = "0x3DAFCA0", VA = "0x183DB0EA0", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F50", Offset = "0x3DAFD50", VA = "0x183DB0F50", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0E40", Offset = "0x3DAFC40", VA = "0x183DB0E40", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F00", Offset = "0x3DAFD00", VA = "0x183DB0F00", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public LEJFJOOJDBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class OKCHEDKGPNO<T> : GIKEGIEPEKC<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4114110", Offset = "0x4112F10", VA = "0x184114110", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F50", Offset = "0x3DAFD50", VA = "0x183DB0F50", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x41140B0", Offset = "0x4112EB0", VA = "0x1841140B0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F00", Offset = "0x3DAFD00", VA = "0x183DB0F00", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public OKCHEDKGPNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class BCNEMLHJLPN<T> : GIKEGIEPEKC<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4838150", Offset = "0x4836F50", VA = "0x184838150", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB220", Offset = "0x3DBA020", VA = "0x183DBB220", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x48380F0", Offset = "0x4836EF0", VA = "0x1848380F0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB1D0", Offset = "0x3DB9FD0", VA = "0x183DBB1D0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public BCNEMLHJLPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class LHPANDFNKBP<T> : GIKEGIEPEKC<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB170", Offset = "0x3DB9F70", VA = "0x183DBB170", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB220", Offset = "0x3DBA020", VA = "0x183DBB220", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB110", Offset = "0x3DB9F10", VA = "0x183DBB110", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBB1D0", Offset = "0x3DB9FD0", VA = "0x183DBB1D0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public LHPANDFNKBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class KLFMDLIGOBE<T> : GIKEGIEPEKC<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3D14520", Offset = "0x3D13320", VA = "0x183D14520", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B330", Offset = "0x3A6A130", VA = "0x183A6B330", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3D144C0", Offset = "0x3D132C0", VA = "0x183D144C0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3934160", Offset = "0x3932F60", VA = "0x183934160", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public KLFMDLIGOBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class IBHMMIFNOBM<T> : GIKEGIEPEKC<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B2D0", Offset = "0x3A6A0D0", VA = "0x183A6B2D0", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B330", Offset = "0x3A6A130", VA = "0x183A6B330", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A6B270", Offset = "0x3A6A070", VA = "0x183A6B270", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3934160", Offset = "0x3932F60", VA = "0x183934160", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public IBHMMIFNOBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CEINBHKOEFG<T> : GIKEGIEPEKC<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4837D40", Offset = "0x4836B40", VA = "0x184837D40", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4837DA0", Offset = "0x4836BA0", VA = "0x184837DA0", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4C4E850", Offset = "0x4C4D650", VA = "0x184C4E850", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3491DE0", Offset = "0x3490BE0", VA = "0x183491DE0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public CEINBHKOEFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class BCFGJNHEGNJ<T> : GIKEGIEPEKC<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4837D40", Offset = "0x4836B40", VA = "0x184837D40", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x4837DA0", Offset = "0x4836BA0", VA = "0x184837DA0", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4837CE0", Offset = "0x4836AE0", VA = "0x184837CE0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3491DE0", Offset = "0x3490BE0", VA = "0x183491DE0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public BCFGJNHEGNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BJLDCMKILND<T> : GIKEGIEPEKC<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4858470", Offset = "0x4857270", VA = "0x184858470", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x48584D0", Offset = "0x48572D0", VA = "0x1848584D0", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4858410", Offset = "0x4857210", VA = "0x184858410", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3DB0F00", Offset = "0x3DAFD00", VA = "0x183DB0F00", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public BJLDCMKILND()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class GGGPDCPOFGE<T> : GIKEGIEPEKC<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3934100", Offset = "0x3932F00", VA = "0x183934100", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x39341B0", Offset = "0x3932FB0", VA = "0x1839341B0", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x39340A0", Offset = "0x3932EA0", VA = "0x1839340A0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3934160", Offset = "0x3932F60", VA = "0x183934160", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public GGGPDCPOFGE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class EJMMNFBBEOK<T> : GIKEGIEPEKC<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3491D80", Offset = "0x3490B80", VA = "0x183491D80", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3491E30", Offset = "0x3490C30", VA = "0x183491E30", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3491D20", Offset = "0x3490B20", VA = "0x183491D20", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3491DE0", Offset = "0x3490BE0", VA = "0x183491DE0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3491E80", Offset = "0x3490C80", VA = "0x183491E80")]
		public EJMMNFBBEOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class DEFCFBELOEG<T> : CHGJIAJEANN<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5138E60", Offset = "0x5137C60", VA = "0x185138E60", Slot = "12")]
		protected override void FGDOKPBEIDI(FPOBMNAIFCJ EEKLJBLGCEC, char LOOCKFEEHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5138E90", Offset = "0x5137C90", VA = "0x185138E90", Slot = "11")]
		protected override void NHBMLFLHMLM(OBIDBJALLGB HFJACMIAHKE, [Out] char LOOCKFEEHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3471EA0", Offset = "0x3470CA0", VA = "0x183471EA0")]
		public DEFCFBELOEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class CFGMJJBIAHL<T> : CHGJIAJEANN<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4D0DB90", Offset = "0x4D0C990", VA = "0x184D0DB90", Slot = "12")]
		protected override void FGDOKPBEIDI(FPOBMNAIFCJ EEKLJBLGCEC, IPEndPoint LOOCKFEEHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x4D0DBC0", Offset = "0x4D0C9C0", VA = "0x184D0DBC0", Slot = "11")]
		protected override void NHBMLFLHMLM(OBIDBJALLGB HFJACMIAHKE, [Out] IPEndPoint LOOCKFEEHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3471EA0", Offset = "0x3470CA0", VA = "0x183471EA0")]
		public CFGMJJBIAHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class MFBDEOPGGOG<T> : GIKEGIEPEKC<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int LMNCIIIEIDJ;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F87D80", Offset = "0x3F86B80", VA = "0x183F87D80")]
		public MFBDEOPGGOG(int FDGBOAPMAKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3F87C50", Offset = "0x3F86A50", VA = "0x183F87C50", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F87D20", Offset = "0x3F86B20", VA = "0x183F87D20", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F87BE0", Offset = "0x3F869E0", VA = "0x183F87BE0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F87CC0", Offset = "0x3F86AC0", VA = "0x183F87CC0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class OPNMAKIGBPE<T> : OPPPLHNKNLJ<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo JPHMNJIAJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type IOFPANLNFJO;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x412F1C0", Offset = "0x412DFC0", VA = "0x18412F1C0")]
		public OPNMAKIGBPE(PropertyInfo CINANBNCBIJ, Type EMJEIICBIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x412EF30", Offset = "0x412DD30", VA = "0x18412EF30", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x412F0B0", Offset = "0x412DEB0", VA = "0x18412F0B0", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x412EED0", Offset = "0x412DCD0", VA = "0x18412EED0", Slot = "7")]
		public override void BNDFDKBAFEO(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x412EFF0", Offset = "0x412DDF0", VA = "0x18412EFF0", Slot = "8")]
		public override void EGDAAJBNKIL(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x412F160", Offset = "0x412DF60", VA = "0x18412F160", Slot = "9")]
		public override void PGJEHPJCMFM(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x412F050", Offset = "0x412DE50", VA = "0x18412F050", Slot = "10")]
		public override void ICNOBDIDFML(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class BGNICMFNNDD<T> : OPNMAKIGBPE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x34762F0", Offset = "0x34750F0", VA = "0x1834762F0")]
		public BGNICMFNNDD(PropertyInfo CINANBNCBIJ, Type EMJEIICBIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x48525F0", Offset = "0x48513F0", VA = "0x1848525F0", Slot = "5")]
		public override void DHCDCJJKPAK(T LCAMLPOOCIH, OBIDBJALLGB HFJACMIAHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x48526B0", Offset = "0x48514B0", VA = "0x1848526B0", Slot = "6")]
		public override void JHIMPLGLBKB(T LCAMLPOOCIH, FPOBMNAIFCJ EEKLJBLGCEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class JPDJHBKEEII<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static JPDJHBKEEII<T> LLCJIHIKEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly OPPPLHNKNLJ<T>[] KJOJMGNPBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int PJOILHMGPOD;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B650", Offset = "0x3C8A450", VA = "0x183C8B650")]
		public JPDJHBKEEII(List<OPPPLHNKNLJ<T>> LNJHEBCPKGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B5A0", Offset = "0x3C8A3A0", VA = "0x183C8B5A0")]
		public void JHIMPLGLBKB(T EIFMADKIHON, FPOBMNAIFCJ DFHABBFDBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B4F0", Offset = "0x3C8A2F0", VA = "0x183C8B4F0")]
		public void DHCDCJJKPAK(T EIFMADKIHON, OBIDBJALLGB HGAPEJGOMLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class OFAKKDKIMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract OPPPLHNKNLJ<T> DJGCEJBDGHO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private FPOBMNAIFCJ IFDADEJGDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int GHNLJKFJJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, OFAKKDKIMGP> NHGEGCJNDLA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5699790", Offset = "0x5698590", VA = "0x185699790")]
	public OIOCPJPGPHI(int CMKEHGOLKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x2A213B0", Offset = "0x2A201B0", VA = "0x182A213B0")]
	private JPDJHBKEEII<T> OEBCKCNINPC<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x2742F60", Offset = "0x2741D60", VA = "0x182742F60")]
	public void GEBEKKCKBFI<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2A212D0", Offset = "0x2A200D0", VA = "0x182A212D0")]
	public bool FPNHMAJLCHC<T>(OBIDBJALLGB HGAPEJGOMLD, T KCDBINENHAL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2A21350", Offset = "0x2A20150", VA = "0x182A21350")]
	public void JPFDICAGNEF<T>(FPOBMNAIFCJ DFHABBFDBND, T EIFMADKIHON) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LFFPIGELDGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime PHEGPLGEEBP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] JDKLKJIEBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GLEENFJMJOD OHCPBPLPDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x568D430", Offset = "0x568C230", VA = "0x18568D430")]
		get
		{
			return default(GLEENFJMJOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int JCENMMMIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x568E0E0", Offset = "0x568CEE0", VA = "0x18568E0E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x568D920", Offset = "0x568C720", VA = "0x18568D920")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KGAPMIIDLJA DJGNOOGIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x568DBE0", Offset = "0x568C9E0", VA = "0x18568DBE0")]
		get
		{
			return default(KGAPMIIDLJA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x568E070", Offset = "0x568CE70", VA = "0x18568E070")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int ALFHNMFCDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x568D960", Offset = "0x568C760", VA = "0x18568D960")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint JLJPGIADPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x568E140", Offset = "0x568CF40", VA = "0x18568E140")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? JEMBNFDACLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x568E110", Offset = "0x568CF10", VA = "0x18568E110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? IGLKCHDJALM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x568DC10", Offset = "0x568CA10", VA = "0x18568DC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? DJPEDJCAMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x568E0B0", Offset = "0x568CEB0", VA = "0x18568E0B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x568DEA0", Offset = "0x568CCA0", VA = "0x18568DEA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? AFLOADCHPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DB0", Offset = "0xAD4BB0", VA = "0x180AD5DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x900F10", Offset = "0x8FFD10", VA = "0x180900F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x568E4A0", Offset = "0x568D2A0", VA = "0x18568E4A0")]
	public LFFPIGELDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x568E3F0", Offset = "0x568D1F0", VA = "0x18568E3F0")]
	internal LFFPIGELDGJ(byte[] KKAMOMBNLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x568D990", Offset = "0x568C790", VA = "0x18568D990")]
	public static LFFPIGELDGJ CDHPJOECAHK(byte[] KKAMOMBNLOJ, DateTime PIEMOKCMAEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x568D660", Offset = "0x568C460", VA = "0x18568D660")]
	internal void AONBPCPKFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x568E1C0", Offset = "0x568CFC0", VA = "0x18568E1C0")]
	private void OINPKMMGIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x568D460", Offset = "0x568C260", VA = "0x18568D460")]
	private DateTime? AIKMNJAMJFF(int PJPGJICIKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x568DC40", Offset = "0x568CA40", VA = "0x18568DC40")]
	private void JIEEHPGDKKH(int PJPGJICIKPG, DateTime? DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x568DAB0", Offset = "0x568C8B0", VA = "0x18568DAB0")]
	private ulong CJFOGMKGFBP(int PJPGJICIKPG)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x568D860", Offset = "0x568C660", VA = "0x18568D860")]
	private void BCOMNHCEDGA(int PJPGJICIKPG, ulong DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x568DE10", Offset = "0x568CC10", VA = "0x18568DE10")]
	private uint KCFMIBHFNLC(int PJPGJICIKPG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x55664F0", Offset = "0x55652F0", VA = "0x1855664F0")]
	private static uint COEOEJBDOIE(uint FCLAAGLFIOD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x568DB80", Offset = "0x568C980", VA = "0x18568DB80")]
	private static ulong COEOEJBDOIE(ulong FCLAAGLFIOD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum GLEENFJMJOD
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
public enum KGAPMIIDLJA
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class AFJLGHMBJMD
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int OECBCPCGLAI = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int PAAPFABDOKF = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int HHENFGGAEEG = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint OMNOBBOMAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int OKKBPJDJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int IOBGCHAFGIC;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool HHBOJIBNFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5683780", Offset = "0x5682580", VA = "0x185683780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5683690", Offset = "0x5682490", VA = "0x185683690")]
	public bool BKDPNGCPEBD(BGFHNCFBLDN CJOAKJGOHDB, int DIAHEDLEKEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class GOMGPMNHAIK : BGFHNCFBLDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket CJOAKJGOHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LMNCAIDCPIE LNAIAFCAHPF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short CEPCCDGNELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5686F20", Offset = "0x5685D20", VA = "0x185686F20", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GJBOOIHAGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5686DB0", Offset = "0x5685BB0", VA = "0x185686DB0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint MIOPNFKLGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5686D90", Offset = "0x5685B90", VA = "0x185686D90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily DNLLECPLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D981C0", Offset = "0x3D96FC0", VA = "0x183D981C0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5686F40", Offset = "0x5685D40", VA = "0x185686F40")]
	public GOMGPMNHAIK(AddressFamily NDMOFGEBPAF, LMNCAIDCPIE LNAIAFCAHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x56867D0", Offset = "0x56855D0", VA = "0x1856867D0", Slot = "8")]
	public bool ALBOBBDPJDA(IPEndPoint GNILBNJDNPE, MDGJLGIAFFD EKEKJDOOEPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5686DF0", Offset = "0x5685BF0", VA = "0x185686DF0", Slot = "9")]
	public int IJLDLMCAMLN(byte[] GGBNILIIFNK, int PJPGJICIKPG, int CGDBKIJPKOF, IPEndPoint JMBLOMEBCON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5686E30", Offset = "0x5685C30", VA = "0x185686E30", Slot = "10")]
	public int JAMKGFGLELM(byte[] GGBNILIIFNK, EndPoint MKLDKAPKGJB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5686DD0", Offset = "0x5685BD0", VA = "0x185686DD0", Slot = "11")]
	public void GILBHCONALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface BGFHNCFBLDN
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short CEPCCDGNELB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int GJBOOIHAGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint MIOPNFKLGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily DNLLECPLGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ALBOBBDPJDA(IPEndPoint GNILBNJDNPE, MDGJLGIAFFD EKEKJDOOEPP);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int IJLDLMCAMLN(byte[] GGBNILIIFNK, int PJPGJICIKPG, int CGDBKIJPKOF, IPEndPoint JMBLOMEBCON);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JAMKGFGLELM(byte[] GGBNILIIFNK, EndPoint JMBLOMEBCON);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GILBHCONALN();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NFMBCCMBJBF : IEquatable<NFMBCCMBJBF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long PPJFBKMPADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long AFABIAGMKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long BLANBEGKNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int CPMLLLPDHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int HHOOMIGLEOG;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x56982E0", Offset = "0x56970E0", VA = "0x1856982E0")]
	public NFMBCCMBJBF(byte[] IMHFEJALMMA, int ALJFCEBOPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7D7BB0", Offset = "0x7D69B0", VA = "0x1807D7BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x56981F0", Offset = "0x5696FF0", VA = "0x1856981F0", Slot = "4")]
	public bool Equals(NFMBCCMBJBF GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5698230", Offset = "0x5697030", VA = "0x185698230", Slot = "0")]
	public override bool Equals(object EIFMADKIHON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class NINEMLPFGLM : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] KHOPCEEGBBG;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class PLAIIJBJIKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int HIKPNIJPCKG;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE480", Offset = "0x7AD280", VA = "0x1807AE480")]
	protected PLAIIJBJIKK(int EPLDHBLNBDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void NMAEEDKDJHE(IPEndPoint GNILBNJDNPE, byte[] LHODDAGAJKC, int PJPGJICIKPG, int PDCHCFIOJCE);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void IHDNBHDOCPH(IPEndPoint GNILBNJDNPE, byte[] LHODDAGAJKC, int PJPGJICIKPG, int PDCHCFIOJCE);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HMDAJGKNIHG : PLAIIJBJIKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private AesCryptoServiceProvider JHDAPPMNHPM;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator MLFNDNABKGJ;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5688190", Offset = "0x5686F90", VA = "0x185688190")]
	public HMDAJGKNIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5687630", Offset = "0x5686430", VA = "0x185687630")]
	public void HAPOIKMCJBH(IPEndPoint GNILBNJDNPE, byte[] OBPLDLNDJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5687550", Offset = "0x5686350", VA = "0x185687550")]
	public void GJEKBKKKLNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x56880B0", Offset = "0x5686EB0", VA = "0x1856880B0")]
	private byte[] PJHIJPOBCBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5687C10", Offset = "0x5686A10", VA = "0x185687C10", Slot = "4")]
	public override void NMAEEDKDJHE(IPEndPoint GNILBNJDNPE, byte[] LHODDAGAJKC, int PJPGJICIKPG, int PDCHCFIOJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5687870", Offset = "0x5686670", VA = "0x185687870", Slot = "5")]
	public override void IHDNBHDOCPH(IPEndPoint GNILBNJDNPE, byte[] LHODDAGAJKC, int PJPGJICIKPG, int PDCHCFIOJCE)
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
