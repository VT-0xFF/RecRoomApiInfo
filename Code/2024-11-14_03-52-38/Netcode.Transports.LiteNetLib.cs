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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, OJJDIHPDBOD
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum OOJBDPPEPOF
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
		private NetworkManager ENKPKPHCOKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, PEBJEIHLGHB> KPJPMABLJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NBPJGGGCIDB ONHPKHBMIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] NABJEDFFGPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OOJBDPPEPOF GPNBIDJAHKG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong BGPLHLMCLDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x89BD40", Offset = "0x89B140", VA = "0x18089BD40", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool JAEOJMMDIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6132DA0", Offset = "0x61321A0", VA = "0x186132DA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6132380", Offset = "0x6131780", VA = "0x186132380")]
		public void RecRoom_SetEncryptionInfo(ulong CEGGDNLAPGE, byte[] PBFBBOFLBNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6132360", Offset = "0x6131760", VA = "0x186132360")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6132230", Offset = "0x6131630", VA = "0x186132230")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6132CA0", Offset = "0x61320A0", VA = "0x186132CA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61324A0", Offset = "0x61318A0", VA = "0x1861324A0", Slot = "6")]
		public override void Send(ulong BCIBDBPGIGG, ArraySegment<byte> EIFGKHNPLEK, NetworkDelivery ADLCMBHAJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6132320", Offset = "0x6131720", VA = "0x186132320", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BCIBDBPGIGG, [Out] ArraySegment<byte> AKKEJIFPDJM, [Out] float LFNEDFGCIKE)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6132790", Offset = "0x6131B90", VA = "0x186132790", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6132BC0", Offset = "0x6131FC0", VA = "0x186132BC0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6131A60", Offset = "0x6130E60", VA = "0x186131A60", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BCIBDBPGIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6131910", Offset = "0x6130D10", VA = "0x186131910", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6131C90", Offset = "0x6131090", VA = "0x186131C90", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BCIBDBPGIGG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6132720", Offset = "0x6131B20", VA = "0x186132720", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6131E40", Offset = "0x6131240", VA = "0x186131E40", Slot = "14")]
		public override void Initialize([Optional] NetworkManager ENKPKPHCOKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61317E0", Offset = "0x6130BE0", VA = "0x1861317E0")]
		private JIHKLGAAKOI DBOIDHGLNBO(NetworkDelivery EKNPHEPNHJD)
		{
			return default(JIHKLGAAKOI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6131BD0", Offset = "0x6130FD0", VA = "0x186131BD0", Slot = "15")]
		private void GIFMDOFLFCO(PEBJEIHLGHB EJBDPPENGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6131720", Offset = "0x6130B20", VA = "0x186131720", Slot = "16")]
		private void BDELBBGKLNM(PEBJEIHLGHB EJBDPPENGEJ, JAFHAGNNHHE MPNBBICFKCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "17")]
		private void KJFLDDLAGLO(IPEndPoint DPJMPBPOJKC, SocketError HLIFGLNLJDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6132000", Offset = "0x6131400", VA = "0x186132000", Slot = "18")]
		private void JLLGIBPCHEF(PEBJEIHLGHB EJBDPPENGEJ, KMJGLPHEACP ILEMOHLPHEC, byte ACNDMCNFGMA, JIHKLGAAKOI HBKBKGEJIJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6131D30", Offset = "0x6131130", VA = "0x186131D30")]
		private void IEDLJPDLPBK(int JKIIGJDNBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "19")]
		private void GMLOGLMIBNM(IPEndPoint DFHJGGIMKBC, KMJGLPHEACP ILEMOHLPHEC, NMLEDIDOBAK DAAKHAEFHFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "20")]
		private void MBODCHPGHLE(PEBJEIHLGHB EJBDPPENGEJ, int FDGCANJNMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61318B0", Offset = "0x6130CB0", VA = "0x1861318B0", Slot = "21")]
		private void DHENPKDLELG(BEPCDFFAIIL OPBNONPHAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6131E10", Offset = "0x6131210", VA = "0x186131E10")]
		private ulong IHGDLJBHLJL(PEBJEIHLGHB EJBDPPENGEJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6132210", Offset = "0x6131610", VA = "0x186132210")]
		private static int MJIEKAJHCMM(float FOPCLCJOGBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6132CC0", Offset = "0x61320C0", VA = "0x186132CC0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class DGOIFFMKHND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly PEBJEIHLGHB HPNNEFDNPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<DJDLKAMBLPL> PEHGLMGFBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int FDEEMHCFODO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x612B390", Offset = "0x612A790", VA = "0x18612B390")]
	protected DGOIFFMKHND(PEBJEIHLGHB EJBDPPENGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x612B270", Offset = "0x612A670", VA = "0x18612B270")]
	public void ILPFONMDFIM(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x612B2D0", Offset = "0x612A6D0", VA = "0x18612B2D0")]
	protected void MIHHHIFIALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x612B350", Offset = "0x612A750", VA = "0x18612B350")]
	public bool NGDDPMEOEBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool MLLADONPIAJ();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool PNLJHDMOFAH(DJDLKAMBLPL EHLNAIHIMHD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum BJIPNKAHKIO
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
public class BEPCDFFAIIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly NBPJGGGCIDB HKJLKDAFPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int GELEDACBIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal PHMBJIANFKA EEDDKLLMLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint AJJPEIIHGLL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal BJIPNKAHKIO IHOMJAIONAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C3890", Offset = "0x8C2C90", VA = "0x1808C3890")]
		[CompilerGenerated]
		get
		{
			return default(BJIPNKAHKIO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x91B6A0", Offset = "0x91AAA0", VA = "0x18091B6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x612A410", Offset = "0x6129810", VA = "0x18612A410")]
	internal void OJNAPCHBDON(PHMBJIANFKA CCNEADJAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x612A3E0", Offset = "0x61297E0", VA = "0x18612A3E0")]
	private bool JJIFKNPOPBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x612A470", Offset = "0x6129870", VA = "0x18612A470")]
	internal BEPCDFFAIIL(IPEndPoint DFHJGGIMKBC, PHMBJIANFKA NFAAKDEMIDB, NBPJGGGCIDB KKMEDFDHHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x612A380", Offset = "0x6129780", VA = "0x18612A380")]
	public PEBJEIHLGHB DNNDGGNMHAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum NMLEDIDOBAK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum HAMIGJBEMFC
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
public struct JAFHAGNNHHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public HAMIGJBEMFC EHIEFOBGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError PPPECMBBHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public KMJGLPHEACP JHBDBKFEAIL;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OJJDIHPDBOD
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEPCMOBEIBC(PEBJEIHLGHB EJBDPPENGEJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCGNMEHCEOC(PEBJEIHLGHB EJBDPPENGEJ, JAFHAGNNHHE MPNBBICFKCB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COAONBFDEFG(IPEndPoint DPJMPBPOJKC, SocketError HLIFGLNLJDE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDEJMCKGHIC(PEBJEIHLGHB EJBDPPENGEJ, KMJGLPHEACP ILEMOHLPHEC, byte ACNDMCNFGMA, JIHKLGAAKOI HBKBKGEJIJD);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNDHFEBIFHC(IPEndPoint DFHJGGIMKBC, KMJGLPHEACP ILEMOHLPHEC, NMLEDIDOBAK DAAKHAEFHFI);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MEHBLEMJDMB(PEBJEIHLGHB EJBDPPENGEJ, int FDGCANJNMLA);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BNJLLPDGEPC(BEPCDFFAIIL OPBNONPHAEF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CIOBJAGMLHH
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNMGOFPGHAC(PEBJEIHLGHB EJBDPPENGEJ, object DELDIDDNALP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DHOJBFLJDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHCJHHHNCIL(EGKLFMDCJMN EHLNAIHIMHD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OFHPHHAGBIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIKCEBNFGJH(PEBJEIHLGHB EJBDPPENGEJ, IPEndPoint PEPHJJDIFCP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class PHMBJIANFKA
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int CBFKCJEJEFB = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long OMMBDAMDEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte OLMCPNLCFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] ELPABMPILDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly BBELGAHDANM EELMKJIGLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int KPJPJBEAMJL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61404F0", Offset = "0x613F8F0", VA = "0x1861404F0")]
	private PHMBJIANFKA(long COGMPAKJHGF, byte JDBNKOCJJEJ, int KMBNCAAFLNK, byte[] PBCLGGNIPMK, BBELGAHDANM EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61402B0", Offset = "0x613F6B0", VA = "0x1861402B0")]
	public static int CMFIACOMJJP(DJDLKAMBLPL EHLNAIHIMHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6140090", Offset = "0x613F490", VA = "0x186140090")]
	public static PHMBJIANFKA AGFMDBDMJKK(DJDLKAMBLPL EHLNAIHIMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6140310", Offset = "0x613F710", VA = "0x186140310")]
	public static DJDLKAMBLPL HPFHEMLHAPP(JAOAGKIOFAM HFPDDHIIIAM, SocketAddress DHCMNOCMFDG, long JLIENNLMJJN, int KMBNCAAFLNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BHCPLNCPDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long OMMBDAMDEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte OLMCPNLCFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int KPJPJBEAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool ILFJAPDCCNK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x612A820", Offset = "0x6129C20", VA = "0x18612A820")]
	private BHCPLNCPDIN(long COGMPAKJHGF, byte JDBNKOCJJEJ, int MPMANLGGNNK, bool AKAHKGEGCFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x612A4E0", Offset = "0x61298E0", VA = "0x18612A4E0")]
	public static BHCPLNCPDIN AGFMDBDMJKK(DJDLKAMBLPL EHLNAIHIMHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x612A630", Offset = "0x6129A30", VA = "0x18612A630")]
	public static DJDLKAMBLPL HPFHEMLHAPP(long JLIENNLMJJN, byte LGLKKAOBIHI, int EPEHJNIPGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x612A720", Offset = "0x6129B20", VA = "0x18612A720")]
	public static DJDLKAMBLPL ODCFCAFDBLH(PEBJEIHLGHB EJBDPPENGEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum MGGPJJOKKNI
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface LEPOJIBMEKG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKKPFAGKHDL(IPEndPoint AGMIAMOCOPH, IPEndPoint DFHJGGIMKBC, string CFGHNHCDKCN);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAFPLIFKIGD(IPEndPoint EEAKIOBMAED, MGGPJJOKKNI EKNPHEPNHJD, string CFGHNHCDKCN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class PCBEIIGOAHE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct BEEKBHILHJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint CFPKFPBLIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint AJJPEIIHGLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string JIBAHPJFCKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct LPMKDJNMOJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint CODIELJFGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public MGGPJJOKKNI LLHMNEIJLPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string JIBAHPJFCKM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class NEJBIKECGFH
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint KLIPPBDJAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string JIBAHPJFCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public NEJBIKECGFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class BHEHABEKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint KLIPPBDJAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint AHCEEAELHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string JIBAHPJFCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BHEHABEKJDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class BLDAGEKMPGM
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JIBAHPJFCKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AIKEFJDEAEK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xB92390", Offset = "0xB91790", VA = "0x180B92390")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8AA6B0", Offset = "0x8A9AB0", VA = "0x1808AA6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BLDAGEKMPGM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly NBPJGGGCIDB LBNOECPFFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<BEEKBHILHJD> BELDEJDPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<LPMKDJNMOJP> FOFBKGEIFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BBELGAHDANM PIOJPOMKFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JAOAGKIOFAM IKLLAFNPJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CAIGAOEBPAH IJMOPNIEDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private LEPOJIBMEKG BPKGOHNKKDM;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int LEDIGNGBFHM = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool DFFNOBPPNMG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x613B8A0", Offset = "0x613ACA0", VA = "0x18613B8A0")]
	internal PCBEIIGOAHE(NBPJGGGCIDB EJFPBLGAMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x613B720", Offset = "0x613AB20", VA = "0x18613B720")]
	internal void JMHIKEKBPJH(IPEndPoint BNPKKENHCAA, DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x309A1F0", Offset = "0x30995F0", VA = "0x18309A1F0")]
	private void HMLHNBDCPOH<T>(T EHLNAIHIMHD, IPEndPoint KLACLBHAHNL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x613B590", Offset = "0x613A990", VA = "0x18613B590")]
	private void JKKPFAGKHDL(NEJBIKECGFH KJPODNMNOHL, IPEndPoint BNPKKENHCAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x613B430", Offset = "0x613A830", VA = "0x18613B430")]
	private void JKEABKKMLIC(BHEHABEKJDD KJPODNMNOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x613B2A0", Offset = "0x613A6A0", VA = "0x18613B2A0")]
	private void GJGPMMAECFC(BLDAGEKMPGM KJPODNMNOHL, IPEndPoint BNPKKENHCAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JIHKLGAAKOI : byte
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
public enum GBCOHKHPEJB : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MGAPBKJMBMI
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] CAICNEKLNOP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int HMOHLBNEAHD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int IAHDCJEMKMJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NGEJNKFEFBH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6129700", Offset = "0x6128B00", VA = "0x186129700")]
	public NGEJNKFEFBH(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PELJCDENDJG : NGEJNKFEFBH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6129700", Offset = "0x6128B00", VA = "0x186129700")]
	public PELJCDENDJG(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum GGPIBDLMFGP
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
public interface CFBLFLBAIHK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGEKBJPNCPI(GGPIBDLMFGP FJLOCMJCNHD, string BBLEEPEBKMO, params object[] KCHFAPGLICB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class IMMANAIIHMG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static CFBLFLBAIHK LHLBFPFLIAE;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object NKOEADHBCLE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x612EF10", Offset = "0x612E310", VA = "0x18612EF10")]
	private static void NNAPKKPADKH(GGPIBDLMFGP KIKLCBFHPCH, string BBLEEPEBKMO, params object[] KCHFAPGLICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x612F140", Offset = "0x612E540", VA = "0x18612F140")]
	internal static void PFAKLFOAPFK(string BBLEEPEBKMO, params object[] KCHFAPGLICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x612EEB0", Offset = "0x612E2B0", VA = "0x18612EEB0")]
	internal static void HOOGOMMFDJO(string BBLEEPEBKMO, params object[] KCHFAPGLICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x612EE50", Offset = "0x612E250", VA = "0x18612EE50")]
	internal static void DFHCCGALPOC(string BBLEEPEBKMO, params object[] KCHFAPGLICB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum IHGGOEKGHCJ
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KMJGLPHEACP : BBELGAHDANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DJDLKAMBLPL MLJPJOJCGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly NBPJGGGCIDB LIDOBHPHKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly KDBLNBCPNHF NGGGHNEKCMI;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6130360", Offset = "0x612F760", VA = "0x186130360")]
	internal KMJGLPHEACP(NBPJGGGCIDB EGAKDMHOMDJ, KDBLNBCPNHF PGLNBAELOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x61302C0", Offset = "0x612F6C0", VA = "0x1861302C0")]
	internal void EKPLOANHOLF(DJDLKAMBLPL EHLNAIHIMHD, int HPCLFMJIJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6130240", Offset = "0x612F640", VA = "0x186130240")]
	internal void AJOEKLLIOAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6130330", Offset = "0x612F730", VA = "0x186130330")]
	public void PIAHLEBMADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class KDBLNBCPNHF
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum ELLFCIHFBFE
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
	public KDBLNBCPNHF LDACBOJGIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public ELLFCIHFBFE LLHMNEIJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public PEBJEIHLGHB HPNNEFDNPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint AJJPEIIHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object JDKJNPODDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int PBEOJKHDDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError MBOPBALJOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public HAMIGJBEMFC NFIDNKDJMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public BEPCDFFAIIL PCAOGDNINJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public JIHKLGAAKOI FCNJLBGEJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte HKAOBDJHDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly KMJGLPHEACP ECAIMJJKGHJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61301A0", Offset = "0x612F5A0", VA = "0x1861301A0")]
	public KDBLNBCPNHF(NBPJGGGCIDB EGAKDMHOMDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NBPJGGGCIDB : IEnumerable<PEBJEIHLGHB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class DCJOJCCELMP : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x612B200", Offset = "0x612A600", VA = "0x18612B200", Slot = "4")]
		public bool Equals(IPEndPoint KPPEBBOFEKD, IPEndPoint EJAKPDCBGAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5C2FD80", Offset = "0x5C2F180", VA = "0x185C2FD80", Slot = "5")]
		public int GetHashCode(IPEndPoint FAKGLFFOLFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public DCJOJCCELMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct CFBEBDBEKOG : IEnumerator<PEBJEIHLGHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly PEBJEIHLGHB NMAJIKDHKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private PEBJEIHLGHB DBNINJIKGNH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public PEBJEIHLGHB LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x948250", Offset = "0x947650", VA = "0x180948250", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x948250", Offset = "0x947650", VA = "0x180948250", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1424D30", Offset = "0x1424130", VA = "0x181424D30")]
		public CFBEBDBEKOG(PEBJEIHLGHB NKKDINBLGEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x612ABF0", Offset = "0x6129FF0", VA = "0x18612ABF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x612AC40", Offset = "0x612A040", VA = "0x18612AC40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread PAFICDKBLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool ANFPGFEPPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent OJJLMJMGKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<KDBLNBCPNHF> LLACNKFMFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<KDBLNBCPNHF> DJKKHJBALDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private KDBLNBCPNHF DPLGIGCMBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly OJJDIHPDBOD BIHHKPLFIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CIOBJAGMLHH IALPIPOOIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly DHOJBFLJDOI PKEIMMNDOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OFHPHHAGBIJ LCFINDCIBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, PEBJEIHLGHB> OFNGBFGHEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, BEPCDFFAIIL> FGKPENGIFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, JAJBKLEBFDF> HMHGMGLKMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JFLNJOFEDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private PEBJEIHLGHB CHFMCNDDFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int LPKKOJPBPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<PEBJEIHLGHB> NDNFBPALPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private PEBJEIHLGHB[] OHDMAICLMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CPGLMDHOBDJ MKHLABOCNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int LHPHGPMIAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> NJCEHPPHODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte NPIHOAPECNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object CINNPIDGGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool AMANLAKGIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool NMCLHOAIAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LNGNBLCHBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int IIOEANCGLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OPBLKCKOIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int AGHIPKHGNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool EMAMJAGBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool DLEKJJMBGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int IGBEPIBLHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int FCJEPDHBLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int LEPLIBEOGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DFFNOBPPNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool MIINJOMPEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool LNOMDNKIFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool PJFAPFOCMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int FNGEAFPDCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int JDEEOJABNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool ODHPEGMLMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly HNPOEAHJOKD BEFLJLMDKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool LLBOLFEKDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly PCBEIIGOAHE PNCEBPDDDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EGNMMHEMIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public IHGGOEKGHCJ FOICKALDLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int KLIHJNELKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MHOMDDKOMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool HLLKKEKDCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool DNACPIECALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool MPEPNLGOOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private DJDLKAMBLPL BEILKHDKAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int IFNKIFLDFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object CBLOCLPHFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private DJDLKAMBLPL LJKPOOEEGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int NIALGAHMGDK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int GOCODPHOMPP = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int MDGIBLCNHIH = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private DBMECLBODDA FEGNLONOGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private DBMECLBODDA FBLKPCMOMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread LCJJAPLDHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread ODPCAGJBECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint AIDMCCEKFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint JLABCIGNGAD;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] OIJIAEPMHAE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] NIDPNFJPKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<GDIDEECCJEH, IPEndPoint> OAFPBJDKKBP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress LMNGOLKGMEH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool IINAENILDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int PGDDOLLFALH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IEKDHPOPGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF2C3B0", Offset = "0xF2B7B0", VA = "0x180F2C3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xFBB880", Offset = "0xFBAC80", VA = "0x180FBB880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GJOEDNABHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1962A10", Offset = "0x1961E10", VA = "0x181962A10")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8030", Offset = "0x1CB7430", VA = "0x181CB8030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte HOAJMLELNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD1E460", Offset = "0xD1D860", VA = "0x180D1E460")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int LELHEOJPIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6134610", Offset = "0x6133A10", VA = "0x186134610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short IJAMABFIBIH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6138050", Offset = "0x6137450", VA = "0x186138050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6133930", Offset = "0x6132D30", VA = "0x186133930")]
	public void CJIDCFJPCPI(IPEndPoint DPJMPBPOJKC, byte[] PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6132EA0", Offset = "0x61322A0", VA = "0x186132EA0")]
	public void AAPEABAAKCA(IPEndPoint DPJMPBPOJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6135640", Offset = "0x6134A40", VA = "0x186135640")]
	private bool HACBNHBINJI(IPEndPoint DPJMPBPOJKC, [Out] PEBJEIHLGHB EJBDPPENGEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6133B50", Offset = "0x6132F50", VA = "0x186133B50")]
	private void CLDNLIBBENM(PEBJEIHLGHB EJBDPPENGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6139240", Offset = "0x6138640", VA = "0x186139240")]
	private void OHALFHIAPNG(PEBJEIHLGHB EJBDPPENGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6135260", Offset = "0x6134660", VA = "0x186135260")]
	private void FNPDPFDPJME(PEBJEIHLGHB EJBDPPENGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6139B90", Offset = "0x6138F90", VA = "0x186139B90")]
	public NBPJGGGCIDB(OJJDIHPDBOD KKMEDFDHHGM, [Optional] CPGLMDHOBDJ BEMMAKKABFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6133E30", Offset = "0x6133230", VA = "0x186133E30")]
	internal void DFKGGMACHMN(PEBJEIHLGHB IJHDDJPJNNA, int FDGCANJNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61345C0", Offset = "0x61339C0", VA = "0x1861345C0")]
	internal void EJAGAILPPGJ(PEBJEIHLGHB IJHDDJPJNNA, object DELDIDDNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x61390F0", Offset = "0x61384F0", VA = "0x1861390F0")]
	internal void OCJCMLGNCIM(PEBJEIHLGHB EJBDPPENGEJ, HAMIGJBEMFC BNIDPJNMOLO, SocketError IMPCJKMDNGP, DJDLKAMBLPL KKIOOCHBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6136DF0", Offset = "0x61361F0", VA = "0x186136DF0")]
	private void KIDJJNPOALI(PEBJEIHLGHB EJBDPPENGEJ, HAMIGJBEMFC BNIDPJNMOLO, SocketError IMPCJKMDNGP, bool DLFLBGAHCIJ, byte[] EIFGKHNPLEK, int ICLFANODKJK, int GMOPHNCDIJO, DJDLKAMBLPL KKIOOCHBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6135F40", Offset = "0x6135340", VA = "0x186135F40")]
	private void HEGBEKOLKFF(KDBLNBCPNHF.ELLFCIHFBFE EKNPHEPNHJD, [Optional] PEBJEIHLGHB EJBDPPENGEJ, [Optional] IPEndPoint DFHJGGIMKBC, SocketError OKKOABGJFHB = SocketError.Success, int FDGCANJNMLA = 0, HAMIGJBEMFC ALKMIPNCEEI = HAMIGJBEMFC.ConnectionFailed, [Optional] BEPCDFFAIIL EHMKBIOACFK, JIHKLGAAKOI HBKBKGEJIJD = JIHKLGAAKOI.Unreliable, byte ACNDMCNFGMA = 0, [Optional] DJDLKAMBLPL ECEMHMCKMGJ, [Optional] object DELDIDDNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6134AC0", Offset = "0x6133EC0", VA = "0x186134AC0")]
	private void FMOGLHDAPNI(KDBLNBCPNHF PGLNBAELOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6136C80", Offset = "0x6136080", VA = "0x186136C80")]
	internal void JGDBJCLPCOD(KDBLNBCPNHF PGLNBAELOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6136320", Offset = "0x6135720", VA = "0x186136320")]
	private void HLDKFEBMBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6133240", Offset = "0x6132640", VA = "0x186133240")]
	private void CAIDENPJPCA(int HACKOLECMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6136660", Offset = "0x6135A60", VA = "0x186136660")]
	internal PEBJEIHLGHB INCGCLCHJAG(BEPCDFFAIIL OPBNONPHAEF, byte[] MHABGNDMBPD, int ICLFANODKJK, int LGPCCHEOHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61391C0", Offset = "0x61385C0", VA = "0x1861391C0")]
	private int OCKGGCPLEHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6134630", Offset = "0x6133A30", VA = "0x186134630")]
	private void FBECGCKJEEA(IPEndPoint DFHJGGIMKBC, PEBJEIHLGHB AFIBAGINHNP, PHMBJIANFKA GDKDLGGOOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6138110", Offset = "0x6137510", VA = "0x186138110")]
	private void OACBBCMCAIL(DJDLKAMBLPL EHLNAIHIMHD, IPEndPoint DFHJGGIMKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6139290", Offset = "0x6138690", VA = "0x186139290")]
	internal void PFIEBJJALGA(DJDLKAMBLPL EHLNAIHIMHD, JIHKLGAAKOI BNLFKLPCHKA, byte ACNDMCNFGMA, int HPCLFMJIJHO, PEBJEIHLGHB IJHDDJPJNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61356F0", Offset = "0x6134AF0", VA = "0x1861356F0")]
	public bool HEDCOPEMPIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61356D0", Offset = "0x6134AD0", VA = "0x1861356D0")]
	public bool HEDCOPEMPIE(IPAddress KFEDLGPONHP, IPAddress HDFGKJJLBPH, int MDMPLCCOJAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6135EC0", Offset = "0x61352C0", VA = "0x186135EC0")]
	public bool HEDCOPEMPIE(int MDMPLCCOJAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6133E80", Offset = "0x6133280", VA = "0x186133E80")]
	public void DJEPFHOAHKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6134030", Offset = "0x6133430", VA = "0x186134030")]
	public PEBJEIHLGHB EIELPJCMEBF(string HMGPCAGLHGL, int MDMPLCCOJAE, string PBFBBOFLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61344E0", Offset = "0x61338E0", VA = "0x1861344E0")]
	public PEBJEIHLGHB EIELPJCMEBF(string HMGPCAGLHGL, int MDMPLCCOJAE, JAOAGKIOFAM FDLHGHLHPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6134110", Offset = "0x6133510", VA = "0x186134110")]
	public PEBJEIHLGHB EIELPJCMEBF(IPEndPoint KLACLBHAHNL, JAOAGKIOFAM FDLHGHLHPKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6137D80", Offset = "0x6137180", VA = "0x186137D80")]
	public void LFENALFAFOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6137A30", Offset = "0x6136E30", VA = "0x186137A30")]
	public void LFENALFAFOO(bool MEIHENLNKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6138ED0", Offset = "0x61382D0", VA = "0x186138ED0")]
	public void OBFBLHGELLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6138FD0", Offset = "0x61383D0", VA = "0x186138FD0")]
	public void OBFBLHGELLA(byte[] EIFGKHNPLEK, int ICLFANODKJK, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6136FA0", Offset = "0x61363A0", VA = "0x186136FA0")]
	public void KIDJJNPOALI(PEBJEIHLGHB EJBDPPENGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6136EE0", Offset = "0x61362E0", VA = "0x186136EE0")]
	public void KIDJJNPOALI(PEBJEIHLGHB EJBDPPENGEJ, byte[] EIFGKHNPLEK, int ICLFANODKJK, int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61399B0", Offset = "0x6138DB0", VA = "0x1861399B0", Slot = "4")]
	private IEnumerator<PEBJEIHLGHB> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6139A40", Offset = "0x6138E40", VA = "0x186139A40", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61397E0", Offset = "0x6138BE0", VA = "0x1861397E0")]
	private DJDLKAMBLPL PLJIJIFPGKF(GDFHAGMCNHO BCPKEGMOEBD, int JKIIGJDNBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61398D0", Offset = "0x6138CD0", VA = "0x1861398D0")]
	private DJDLKAMBLPL PLJIJIFPGKF(GDFHAGMCNHO BCPKEGMOEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6132FF0", Offset = "0x61323F0", VA = "0x186132FF0")]
	internal DJDLKAMBLPL CAAJNLEJHLD(int JKIIGJDNBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6139570", Offset = "0x6138970", VA = "0x186139570")]
	internal void PHBDPFDAJDG(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6139AD0", Offset = "0x6138ED0", VA = "0x186139AD0")]
	static NBPJGGGCIDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xF2C3B0", Offset = "0xF2B7B0", VA = "0x180F2C3B0")]
	private bool PFAKIKACPFD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6137F40", Offset = "0x6137340", VA = "0x186137F40")]
	private void MKLMFBKAKAF(IPEndPoint OPAIOBKLHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6133830", Offset = "0x6132C30", VA = "0x186133830")]
	private void CIAIOIFJHIP(IPEndPoint OPAIOBKLHII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6137D90", Offset = "0x6137190", VA = "0x186137D90")]
	private bool LJHHEIHNACJ(SocketException BDBOMDMKJJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6133560", Offset = "0x6132960", VA = "0x186133560")]
	private void CHADBGEOCMP(DBMECLBODDA EJFPBLGAMPN, EndPoint CFAJCIMPLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61376A0", Offset = "0x6136AA0", VA = "0x1861376A0")]
	private void KNOANNMICAL(object GCJJLPMGMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6135700", Offset = "0x6134B00", VA = "0x186135700")]
	public bool HEDCOPEMPIE(IPAddress KFEDLGPONHP, IPAddress HDFGKJJLBPH, int MDMPLCCOJAE, bool NOJCCHHIIEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6136D90", Offset = "0x6136190", VA = "0x186136D90")]
	internal int JNIDLAONHJI(DJDLKAMBLPL EHLNAIHIMHD, IPEndPoint DFHJGGIMKBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6137660", Offset = "0x6136A60", VA = "0x186137660")]
	internal int KKMGLFBEOIN(DJDLKAMBLPL EHLNAIHIMHD, IPEndPoint DFHJGGIMKBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6137050", Offset = "0x6136450", VA = "0x186137050")]
	internal int KKMGLFBEOIN(byte[] NFKMLKNHFEM, int ICLFANODKJK, int LGPCCHEOHGO, IPEndPoint DFHJGGIMKBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61354D0", Offset = "0x61348D0", VA = "0x1861354D0")]
	internal void GAIBIKEIENH(bool GCKELBPENOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GDFHAGMCNHO : byte
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
internal sealed class DJDLKAMBLPL
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int FDKBELPNBJE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] CMCFKAMBFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] IJMCFNOLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int INPFMBGIDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object JDKJNPODDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public DJDLKAMBLPL LDACBOJGIHJ;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GDFHAGMCNHO CCFHHEJINME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x612B8F0", Offset = "0x612ACF0", VA = "0x18612B8F0")]
		get
		{
			return default(GDFHAGMCNHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x612B430", Offset = "0x612A830", VA = "0x18612B430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte OLMCPNLCFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x612BA20", Offset = "0x612AE20", VA = "0x18612BA20")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x612B680", Offset = "0x612AA80", VA = "0x18612B680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LDFJBECOAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x612B6C0", Offset = "0x612AAC0", VA = "0x18612B6C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x612B470", Offset = "0x612A870", VA = "0x18612B470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JIEGGEJDGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x612B880", Offset = "0x612AC80", VA = "0x18612B880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte DDGDMHNOPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x612B820", Offset = "0x612AC20", VA = "0x18612B820")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x612B4B0", Offset = "0x612A8B0", VA = "0x18612B4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort GEMMMFCEFOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x612B620", Offset = "0x612AA20", VA = "0x18612B620")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x612B4E0", Offset = "0x612A8E0", VA = "0x18612B4E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort HFDCEAPDPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x612B520", Offset = "0x612A920", VA = "0x18612B520")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x612B8B0", Offset = "0x612ACB0", VA = "0x18612B8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort HLIOGFMLHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x612B580", Offset = "0x612A980", VA = "0x18612B580")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x612B5E0", Offset = "0x612A9E0", VA = "0x18612B5E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x612BA50", Offset = "0x612AE50", VA = "0x18612BA50")]
	static DJDLKAMBLPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x612B850", Offset = "0x612AC50", VA = "0x18612B850")]
	public void LHCFNBCDFCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x612BE40", Offset = "0x612B240", VA = "0x18612BE40")]
	public DJDLKAMBLPL(int JKIIGJDNBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x612BD30", Offset = "0x612B130", VA = "0x18612BD30")]
	public DJDLKAMBLPL(GDFHAGMCNHO BCPKEGMOEBD, int JKIIGJDNBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x612B720", Offset = "0x612AB20", VA = "0x18612B720")]
	public static int JEBIMCCMNHA(GDFHAGMCNHO BCPKEGMOEBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x612B790", Offset = "0x612AB90", VA = "0x18612B790")]
	public int JEBIMCCMNHA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x612B920", Offset = "0x612AD20", VA = "0x18612B920")]
	public bool PCDNJHBFBBF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum AONCDPHNCPA : byte
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
internal enum MNAPNIMAHMF
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
internal enum FGHEFONHMLD
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum PJCOFDPIOOC
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PEBJEIHLGHB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GCKDBLHPBLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DJDLKAMBLPL[] BOEGFJGFOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int MIGFLMLNMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int OHMNHFGDECN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte DDGDMHNOPGP;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public GCKDBLHPBLJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void KIAOPPBCGEK(ulong FAAGGDIHFCG, int BEOHLLBKMEA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int LMJHLKFOICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HNGPINABFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int DMMNHBAFNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double AMICPDNIBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int FPCOFIIJFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int FOMBOBABKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int NJBNLNAPFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch JCFGIONPIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int PBIIMHMOPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long NELMEIJAAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object FKBAIFBFLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal PEBJEIHLGHB LEAOCBNGKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal PEBJEIHLGHB FONDBAIMIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<DJDLKAMBLPL> OAGOADFLLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<DGOIFFMKHND> DAAIDGOBDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly DGOIFFMKHND[] KLGFBHFJKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int JILNLKBENEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int NKIBDHCOIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool FEBKGNALEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int JMCJINEKPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int PLNEFPAMFLI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CNDCNJIAGIN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int PNFFDKPDCOM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object FLMCHADDKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CEGMBNMDIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GCKDBLHPBLJ> FKIMFGDDLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> OGALBHAFJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly DJDLKAMBLPL BOHBPBCBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int OOCIDEPNHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int BFKMEOIMMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint KOIHFABKFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int MGJCNPHCNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int OMOPBGIFAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long OHDHLJNJCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte CHIMAPHKPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private AONCDPHNCPA KIBLBDILFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private DJDLKAMBLPL ADHLKDDINGK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int HIFLJFENGOE = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int LPJGGHFBCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly DJDLKAMBLPL DGBGCNKGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly DJDLKAMBLPL HAJMFJCMGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly DJDLKAMBLPL LBFHFLFDJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly DJDLKAMBLPL PHODDBAEFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private GBCOHKHPEJB GCMDJNPEBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly NBPJGGGCIDB FAKKOIIOFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int GPNGJJINABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object CHJLLEEPJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly HNPOEAHJOKD BEFLJLMDKKM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte NMDGHLPOJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xBCE5F0", Offset = "0xBCD9F0", VA = "0x180BCE5F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x613C5A0", Offset = "0x613B9A0", VA = "0x18613C5A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint JPLMGFEJGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x96D0E0", Offset = "0x96C4E0", VA = "0x18096D0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AONCDPHNCPA PEMNHBLKILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x166DCD0", Offset = "0x166D0D0", VA = "0x18166DCD0")]
		get
		{
			return default(AONCDPHNCPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long FNBPKNMCHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x89A3F0", Offset = "0x8997F0", VA = "0x18089A3F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CJJNFOKDCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xFFD690", Offset = "0xFFCA90", VA = "0x180FFD690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19066F0", Offset = "0x1905AF0", VA = "0x1819066F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int BMCOPEGPNFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x613BFB0", Offset = "0x613B3B0", VA = "0x18613BFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int HKMHIOFJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8AAEF0", Offset = "0x8AA2F0", VA = "0x1808AAEF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double NNIKFNEJFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5724E00", Offset = "0x5724200", VA = "0x185724E00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event KIAOPPBCGEK FLMMLCOBDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x613EDA0", Offset = "0x613E1A0", VA = "0x18613EDA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x613E790", Offset = "0x613DB90", VA = "0x18613E790")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x613F9F0", Offset = "0x613EDF0", VA = "0x18613F9F0")]
	internal PEBJEIHLGHB(NBPJGGGCIDB AOCOCJEHHEH, IPEndPoint DFHJGGIMKBC, int HDCHKIOFILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x613E520", Offset = "0x613D920", VA = "0x18613E520")]
	internal void JIGENAEEHCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x613E4F0", Offset = "0x613D8F0", VA = "0x18613E4F0")]
	internal void JHMMAPIBMLK(IPEndPoint HMHEFEDEJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x613CA90", Offset = "0x613BE90", VA = "0x18613CA90")]
	internal void CJEHCGHEOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x613EFF0", Offset = "0x613E3F0", VA = "0x18613EFF0")]
	private void PBDMAEPCKCD(int MPIGKGFDFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x613E170", Offset = "0x613D570", VA = "0x18613E170")]
	private void HJOLDDIOCMA(int CFIILHCLMIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x613E540", Offset = "0x613D940", VA = "0x18613E540")]
	private DGOIFFMKHND JKHDHGFGFBO(byte CMANFNLPJKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x613F860", Offset = "0x613EC60", VA = "0x18613F860")]
	internal PEBJEIHLGHB(NBPJGGGCIDB AOCOCJEHHEH, IPEndPoint DFHJGGIMKBC, int HDCHKIOFILD, byte LGLKKAOBIHI, JAOAGKIOFAM HFPDDHIIIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x613FE50", Offset = "0x613F250", VA = "0x18613FE50")]
	internal PEBJEIHLGHB(NBPJGGGCIDB AOCOCJEHHEH, BEPCDFFAIIL OPBNONPHAEF, int HDCHKIOFILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x613EFA0", Offset = "0x613E3A0", VA = "0x18613EFA0")]
	internal void OCPBJIMENBA(PHMBJIANFKA CPDLLEDDJKL, byte[] EIFGKHNPLEK, int ICLFANODKJK, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x613BFC0", Offset = "0x613B3C0", VA = "0x18613BFC0")]
	internal bool APOACABHBHM(BHCPLNCPDIN EHLNAIHIMHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x613E1B0", Offset = "0x613D5B0", VA = "0x18613E1B0")]
	public void HMLHNBDCPOH(byte[] EIFGKHNPLEK, int ICLFANODKJK, int LGPCCHEOHGO, JIHKLGAAKOI POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x613C040", Offset = "0x613B440", VA = "0x18613C040")]
	private void BBGPCFDCGBH(byte[] EIFGKHNPLEK, int ICLFANODKJK, int LGPCCHEOHGO, byte ACNDMCNFGMA, JIHKLGAAKOI HBKBKGEJIJD, object DELDIDDNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x613C9E0", Offset = "0x613BDE0", VA = "0x18613C9E0")]
	public void BOIODEBLDDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x613F0C0", Offset = "0x613E4C0", VA = "0x18613F0C0")]
	internal FGHEFONHMLD PGBLDPAECPL(DJDLKAMBLPL EHLNAIHIMHD)
	{
		return default(FGHEFONHMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x613E730", Offset = "0x613DB30", VA = "0x18613E730")]
	internal void LGMCKCCDHPH(DGOIFFMKHND NBBHAGEBHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x613E1E0", Offset = "0x613D5E0", VA = "0x18613E1E0")]
	internal PJCOFDPIOOC IMEEJDELEHL(byte[] EIFGKHNPLEK, int ICLFANODKJK, int LGPCCHEOHGO, bool DLFLBGAHCIJ)
	{
		return default(PJCOFDPIOOC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x613E6F0", Offset = "0x613DAF0", VA = "0x18613E6F0")]
	private void KMKDBIPIHEL(int IKANIHKAKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x613CD30", Offset = "0x613C130", VA = "0x18613CD30")]
	internal void DOODCHPMFCA(JIHKLGAAKOI BNLFKLPCHKA, DJDLKAMBLPL NKKDINBLGEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x613E840", Offset = "0x613DC40", VA = "0x18613E840")]
	private void MFMLIOOPKGH(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x613C650", Offset = "0x613BA50", VA = "0x18613C650")]
	private void BLNHGMDBEFE(int FDMAJNEEBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x613DFB0", Offset = "0x613D3B0", VA = "0x18613DFB0")]
	internal MNAPNIMAHMF FBECGCKJEEA(PHMBJIANFKA GDKDLGGOOBA)
	{
		return default(MNAPNIMAHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x613F1A0", Offset = "0x613E5A0", VA = "0x18613F1A0")]
	internal void PNLJHDMOFAH(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x613EE50", Offset = "0x613E250", VA = "0x18613EE50")]
	private void NIJGMAIDEGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x613CB20", Offset = "0x613BF20", VA = "0x18613CB20")]
	internal void DBMOBKIHJJN(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x613D6C0", Offset = "0x613CAC0", VA = "0x18613D6C0")]
	internal void DPCLJOJLMCI(int FDMAJNEEBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x613BCF0", Offset = "0x613B0F0", VA = "0x18613BCF0")]
	internal void ACOGHBOKOCA(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HNPOEAHJOKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long DOEOGKJDAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long IICKKJFDIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long OHCKCGJBAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long LGEDOMIEAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long OBCHKIGGLMK;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long OIBMPILPDOP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long KOEEHLLOBAF;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long FAMONGGKCGG;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long DGCEFPFNHOL;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long OPHKKIEPMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long BNMEBBPPADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long IHNEOKGEMAF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long KAFHNLDEKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x612E730", Offset = "0x612DB30", VA = "0x18612E730")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long EMGMGHCHBJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x612EA10", Offset = "0x612DE10", VA = "0x18612EA10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long FOEMEHFCHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x612E820", Offset = "0x612DC20", VA = "0x18612E820")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long FMNLDJEOFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x612E720", Offset = "0x612DB20", VA = "0x18612E720")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long AJGHJIGEEDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x612EA20", Offset = "0x612DE20", VA = "0x18612EA20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long DAONKFMHCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x612E950", Offset = "0x612DD50", VA = "0x18612E950")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long HGCAMNADPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x612E960", Offset = "0x612DD60", VA = "0x18612E960")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long FKFBAELPMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x612E680", Offset = "0x612DA80", VA = "0x18612E680")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private GBCOHKHPEJB JOMDHOIGJMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x612E670", Offset = "0x612DA70", VA = "0x18612E670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double AGOGMJJADEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x612E6C0", Offset = "0x612DAC0", VA = "0x18612E6C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x612EAD0", Offset = "0x612DED0", VA = "0x18612EAD0")]
	public void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x612E880", Offset = "0x612DC80", VA = "0x18612E880")]
	public void IMAOEFGBGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x612E830", Offset = "0x612DC30", VA = "0x18612E830")]
	public void IAHAGFAMHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x612E8E0", Offset = "0x612DCE0", VA = "0x18612E8E0")]
	public void JBKMMMFJJNI(long CADLGIOMBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x612E9A0", Offset = "0x612DDA0", VA = "0x18612E9A0")]
	public void MDLOLBLGHMI(long MGBHGDCMIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x612E7C0", Offset = "0x612DBC0", VA = "0x18612E7C0")]
	public void EMJOGHLGOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x612E740", Offset = "0x612DB40", VA = "0x18612E740")]
	public void EFLDNJPMFGK(long APHHOKGJAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x612EB10", Offset = "0x612DF10", VA = "0x18612EB10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x612EA30", Offset = "0x612DE30", VA = "0x18612EA30")]
	public void PFJHBKKADPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public HNPOEAHJOKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class COHAMHDHNPE
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> CBMJBJMLGDE;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x612AC90", Offset = "0x612A090", VA = "0x18612AC90")]
	public static IPEndPoint CDMIDOKPBKE(string PFAIHFIPIEI, int MDMPLCCOJAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x612AF70", Offset = "0x612A370", VA = "0x18612AF70")]
	public static IPAddress CIELHBPIKBL(string PFAIHFIPIEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x612AEE0", Offset = "0x612A2E0", VA = "0x18612AEE0")]
	public static IPAddress CIELHBPIKBL(string PFAIHFIPIEI, AddressFamily HKFMHMHDHFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x612B140", Offset = "0x612A540", VA = "0x18612B140")]
	internal static int LHAAOJFFHKN(int INOFNPAHHKG, int HOKALHNIKIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2CAD250", Offset = "0x2CAC650", VA = "0x182CAD250")]
	internal static T[] MEELEAHOAOP<T>(int GMOPHNCDIJO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class OAIEJHGMFIK : DGOIFFMKHND
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct FMGNBECPMMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private DJDLKAMBLPL MLJPJOJCGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long FFIMDMGPBFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool AJFEJDONJGI;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x612E3F0", Offset = "0x612D7F0", VA = "0x18612E3F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x612E3D0", Offset = "0x612D7D0", VA = "0x18612E3D0")]
		public void MABFCCPGADF(DJDLKAMBLPL EHLNAIHIMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x612E360", Offset = "0x612D760", VA = "0x18612E360")]
		public bool KNPBLDNDEEJ(long DMIHFIICGGA, PEBJEIHLGHB EJBDPPENGEJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x612E310", Offset = "0x612D710", VA = "0x18612E310")]
		public bool FEPOBOIDOBF(PEBJEIHLGHB EJBDPPENGEJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly DJDLKAMBLPL AMGAAADNBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly FMGNBECPMMF[] NAMIILFHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly DJDLKAMBLPL[] NINOKEPOKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] MMCJGOJEEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int HELDLHCHKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int CAMPPPDGNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int NFLEICCEBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int AKJPMIDCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool CHBANMJLDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly JIHKLGAAKOI KKNGMMGGAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool FPJMDDDCCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int GAFAMPDNFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte INDEKGPEPCN;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x613B0D0", Offset = "0x613A4D0", VA = "0x18613B0D0")]
	public OAIEJHGMFIK(PEBJEIHLGHB EJBDPPENGEJ, bool MNNKIIMNJAI, byte HDCHKIOFILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x613A1E0", Offset = "0x61395E0", VA = "0x18613A1E0")]
	private void LHEGLCECKNI(DJDLKAMBLPL EHLNAIHIMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x613A5A0", Offset = "0x61399A0", VA = "0x18613A5A0", Slot = "4")]
	protected override bool MLLADONPIAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x613AA70", Offset = "0x6139E70", VA = "0x18613AA70", Slot = "5")]
	public override bool PNLJHDMOFAH(DJDLKAMBLPL EHLNAIHIMHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class LJDBPIAJDMP : DGOIFFMKHND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int DBJLNCOMCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort CAMPPPDGNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool JJDPEJBGHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private DJDLKAMBLPL HLDLKBJDDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly DJDLKAMBLPL NOGAAGJDJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool GCGGPCCGPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte INDEKGPEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long MKNGLJDPFNE;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6131660", Offset = "0x6130A60", VA = "0x186131660")]
	public LJDBPIAJDMP(PEBJEIHLGHB EJBDPPENGEJ, bool OKEJHGCCBDL, byte HDCHKIOFILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6130EC0", Offset = "0x61302C0", VA = "0x186130EC0", Slot = "4")]
	protected override bool MLLADONPIAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6131380", Offset = "0x6130780", VA = "0x186131380", Slot = "5")]
	public override bool PNLJHDMOFAH(DJDLKAMBLPL EHLNAIHIMHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AEEHPFAGNLC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct PAHHIPANGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong EOEMKJDGLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double NCHODELIBPB;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct EJENKGLEKKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int FGBBGEPILJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float JNKPHJBLFNF;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6128FC0", Offset = "0x61283C0", VA = "0x186128FC0")]
	private static void GPIJGGJPHAE(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, ulong EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6129690", Offset = "0x6128A90", VA = "0x186129690")]
	private static void GPIJGGJPHAE(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, int EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x61295A0", Offset = "0x61289A0", VA = "0x1861295A0")]
	public static void GPIJGGJPHAE(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, short EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6129660", Offset = "0x6128A60", VA = "0x186129660")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, double PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x61295E0", Offset = "0x61289E0", VA = "0x1861295E0")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x61295A0", Offset = "0x61289A0", VA = "0x1861295A0")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, short PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x61295A0", Offset = "0x61289A0", VA = "0x1861295A0")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, ushort PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6129690", Offset = "0x6128A90", VA = "0x186129690")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6129690", Offset = "0x6128A90", VA = "0x186129690")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, uint PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6129680", Offset = "0x6128A80", VA = "0x186129680")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6129680", Offset = "0x6128A80", VA = "0x186129680")]
	public static void BKIKDNGHIIK(byte[] HFBIMFCNCFE, int PNGCLOMDHAJ, ulong PFKKDHPJFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BBELGAHDANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] MLLHAONLDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int JNIBEBGFAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int OLEHNONFDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int HOLPLHFPCPA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] IJMCFNOLMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int NEINOBHPGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9741A0", Offset = "0x9735A0", VA = "0x1809741A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int IPDDMFIBPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x612A160", Offset = "0x6129560", VA = "0x18612A160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool NBDBJNEIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x21793C0", Offset = "0x21787C0", VA = "0x1821793C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NMIGDDKHBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x612A2D0", Offset = "0x61296D0", VA = "0x18612A2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6129D10", Offset = "0x6129110", VA = "0x186129D10")]
	public void EKPLOANHOLF(byte[] LHOBDGJGOHD, int HHOJFKLGPBP, int CCPPODEOIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public BBELGAHDANM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x612A320", Offset = "0x6129720", VA = "0x18612A320")]
	public BBELGAHDANM(byte[] LHOBDGJGOHD, int HHOJFKLGPBP, int CCPPODEOIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6129B20", Offset = "0x6128F20", VA = "0x186129B20")]
	public IPEndPoint DINBIFHOLLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6129910", Offset = "0x6128D10", VA = "0x186129910")]
	public byte BPOBDJEDBEL()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6129910", Offset = "0x6128D10", VA = "0x186129910")]
	public sbyte NDHDCDKEJBG()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2C43800", Offset = "0x2C42C00", VA = "0x182C43800")]
	public T[] JDNPIMCOHGF<T>(ushort JKIIGJDNBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x612A170", Offset = "0x6129570", VA = "0x18612A170")]
	public bool[] MJBAHEHGCLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6129CD0", Offset = "0x61290D0", VA = "0x186129CD0")]
	public ushort[] EHKBLBBBHAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6129950", Offset = "0x6128D50", VA = "0x186129950")]
	public short[] CEOGDFDKPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x612A2E0", Offset = "0x61296E0", VA = "0x18612A2E0")]
	public int[] PFJKHMGHACC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x612A0E0", Offset = "0x61294E0", VA = "0x18612A0E0")]
	public uint[] GNOOPNOCFLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6129F90", Offset = "0x6129390", VA = "0x186129F90")]
	public float[] FEDHJNFFABN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x612A290", Offset = "0x6129690", VA = "0x18612A290")]
	public double[] NLBIFEHEOOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x612A0A0", Offset = "0x61294A0", VA = "0x18612A0A0")]
	public long[] GELGEOEFCKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6129FF0", Offset = "0x61293F0", VA = "0x186129FF0")]
	public ulong[] FLNLKFHMPHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6129780", Offset = "0x6128B80", VA = "0x186129780")]
	public string[] APIIAMPLKBM(int CLIFJKOKJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6129A70", Offset = "0x6128E70", VA = "0x186129A70")]
	public bool DGIKIJIPGGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x612A220", Offset = "0x6129620", VA = "0x18612A220")]
	public char MPECMEGMHHL()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x612A220", Offset = "0x6129620", VA = "0x18612A220")]
	public ushort PGOFIKHJPIJ()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6129C60", Offset = "0x6129060", VA = "0x186129C60")]
	public short EBCIIDNPFGH()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6129A00", Offset = "0x6128E00", VA = "0x186129A00")]
	public long CPDCFFCPFMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x612A1B0", Offset = "0x61295B0", VA = "0x18612A1B0")]
	public ulong MJKLKMKJDIN()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6129AB0", Offset = "0x6128EB0", VA = "0x186129AB0")]
	public int DGKHAFAELME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x612A030", Offset = "0x6129430", VA = "0x18612A030")]
	public uint FPIBKGOMNJJ()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6129990", Offset = "0x6128D90", VA = "0x186129990")]
	public float CHKDAKFAEFB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6129710", Offset = "0x6128B10", VA = "0x186129710")]
	public double ABIBCILCJDM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6129D50", Offset = "0x6129150", VA = "0x186129D50")]
	public string ELKHKOCNMHE(int CBPLCBHEDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6129BF0", Offset = "0x6128FF0", VA = "0x186129BF0")]
	public ArraySegment<byte> EAGOCLIDPMF(int GMOPHNCDIJO)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x61298D0", Offset = "0x6128CD0", VA = "0x1861298D0")]
	public sbyte[] BGMKNPMCPCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x612A120", Offset = "0x6129520", VA = "0x18612A120")]
	public byte[] LBMKGOIGOAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6129FD0", Offset = "0x61293D0", VA = "0x186129FD0")]
	public void FEPOBOIDOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JAOAGKIOFAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] MLLHAONLDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int JNIBEBGFAGK;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int GNLAOBBPDNC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool BJNBCIDACMB;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding DBCFIJGNNIE;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int NLDAGJIPMFL = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] DNBAICIKOPD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] EELMKJIGLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int OCLEKHGCIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6130080", Offset = "0x612F480", VA = "0x186130080")]
	public JAOAGKIOFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6130100", Offset = "0x612F500", VA = "0x186130100")]
	public JAOAGKIOFAM(bool PDOECMMNGKP, int LGCGGHJGEDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x612FF80", Offset = "0x612F380", VA = "0x18612FF80")]
	public static JAOAGKIOFAM JNAGDGOBALN(string PFKKDHPJFEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x612FEE0", Offset = "0x612F2E0", VA = "0x18612FEE0")]
	public void IEDNFEALEJA(int HIINENLAIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x21F2860", Offset = "0x21F1C60", VA = "0x1821F2860")]
	public void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x612F8A0", Offset = "0x612ECA0", VA = "0x18612F8A0")]
	public void BDDDIJJPNNN(float PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x612F570", Offset = "0x612E970", VA = "0x18612F570")]
	public void BDDDIJJPNNN(double PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x612F520", Offset = "0x612E920", VA = "0x18612F520")]
	public void BDDDIJJPNNN(long PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x612F520", Offset = "0x612E920", VA = "0x18612F520")]
	public void BDDDIJJPNNN(ulong PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x612F430", Offset = "0x612E830", VA = "0x18612F430")]
	public void BDDDIJJPNNN(int PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x612F430", Offset = "0x612E830", VA = "0x18612F430")]
	public void BDDDIJJPNNN(uint PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x612F360", Offset = "0x612E760", VA = "0x18612F360")]
	public void BDDDIJJPNNN(char PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x612F360", Offset = "0x612E760", VA = "0x18612F360")]
	public void BDDDIJJPNNN(ushort PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x612F360", Offset = "0x612E760", VA = "0x18612F360")]
	public void BDDDIJJPNNN(short PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x612F3D0", Offset = "0x612E7D0", VA = "0x18612F3D0")]
	public void BDDDIJJPNNN(sbyte PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x612F3D0", Offset = "0x612E7D0", VA = "0x18612F3D0")]
	public void BDDDIJJPNNN(byte PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x612F940", Offset = "0x612ED40", VA = "0x18612F940")]
	public void BDDDIJJPNNN(byte[] EIFGKHNPLEK, int HHOJFKLGPBP, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x612FE00", Offset = "0x612F200", VA = "0x18612FE00")]
	public void HPAIDCHMMAD(sbyte[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x612FE00", Offset = "0x612F200", VA = "0x18612FE00")]
	public void HCBLIFMADMP(byte[] EIFGKHNPLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x612F4C0", Offset = "0x612E8C0", VA = "0x18612F4C0")]
	public void BDDDIJJPNNN(bool PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x612FC40", Offset = "0x612F040", VA = "0x18612FC40")]
	public void GMEDPIOKPMA(Array MHJLEEFCHPP, int PIAFPKMEDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x612FA90", Offset = "0x612EE90", VA = "0x18612FA90")]
	public void GMEDPIOKPMA(float[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x612F9B0", Offset = "0x612EDB0", VA = "0x18612F9B0")]
	public void GMEDPIOKPMA(double[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x612F9B0", Offset = "0x612EDB0", VA = "0x18612F9B0")]
	public void GMEDPIOKPMA(long[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x612F9B0", Offset = "0x612EDB0", VA = "0x18612F9B0")]
	public void GMEDPIOKPMA(ulong[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x612FA90", Offset = "0x612EE90", VA = "0x18612FA90")]
	public void GMEDPIOKPMA(int[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x612FA90", Offset = "0x612EE90", VA = "0x18612FA90")]
	public void GMEDPIOKPMA(uint[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x612FD20", Offset = "0x612F120", VA = "0x18612FD20")]
	public void GMEDPIOKPMA(ushort[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x612FD20", Offset = "0x612F120", VA = "0x18612FD20")]
	public void GMEDPIOKPMA(short[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x612FE00", Offset = "0x612F200", VA = "0x18612FE00")]
	public void GMEDPIOKPMA(bool[] PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x612FB70", Offset = "0x612EF70", VA = "0x18612FB70")]
	public void GMEDPIOKPMA(string[] PFKKDHPJFEH, int JGMLFJEOCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x612F7D0", Offset = "0x612EBD0", VA = "0x18612F7D0")]
	public void BDDDIJJPNNN(IPEndPoint DPJMPBPOJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x612F350", Offset = "0x612E750", VA = "0x18612F350")]
	public void BDDDIJJPNNN(string PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x612F5C0", Offset = "0x612E9C0", VA = "0x18612F5C0")]
	public void BDDDIJJPNNN(string PFKKDHPJFEH, int CBPLCBHEDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class CAIGAOEBPAH
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class HIHPPNLHGMJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong GPNGJJINABA;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4156C20", Offset = "0x4156020", VA = "0x184156C20")]
		static HIHPPNLHGMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void LELMLAKGBLF(BBELGAHDANM ILEMOHLPHEC, object DELDIDDNALP);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class FIFOHOLPCNF<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public CAIGAOEBPAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public FIFOHOLPCNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3F4A300", Offset = "0x3F49700", VA = "0x183F4A300")]
		internal void PELGMKNMODH(BBELGAHDANM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class LJMLNEKDLHC<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public CAIGAOEBPAH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public LJMLNEKDLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4671080", Offset = "0x4670480", VA = "0x184671080")]
		internal void PELGMKNMODH(BBELGAHDANM reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly EMKKEANAINA MNBBCKNJJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, LELMLAKGBLF> LHLJDNDJKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly JAOAGKIOFAM IOOMPECLNMI;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x612AA70", Offset = "0x6129E70", VA = "0x18612AA70")]
	public CAIGAOEBPAH(int CLIFJKOKJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2C4D0F0", Offset = "0x2C4C4F0", VA = "0x182C4D0F0", Slot = "4")]
	protected virtual ulong OHPIFIEEJCB<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x612A870", Offset = "0x6129C70", VA = "0x18612A870", Slot = "5")]
	protected virtual LELMLAKGBLF APNDCKGFPEN(BBELGAHDANM ILEMOHLPHEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9300", Offset = "0x2CA8700", VA = "0x182CA9300", Slot = "6")]
	protected virtual void INHAAADNPDN<T>(JAOAGKIOFAM FJOPPBPMLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x612A9F0", Offset = "0x6129DF0", VA = "0x18612A9F0")]
	public void PLCGKDACGIH(BBELGAHDANM ILEMOHLPHEC, object DELDIDDNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9370", Offset = "0x2CA8770", VA = "0x182CA9370")]
	public void JPEPEKDGNLK<T>(JAOAGKIOFAM FJOPPBPMLFL, T EHLNAIHIMHD) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x612A9A0", Offset = "0x6129DA0", VA = "0x18612A9A0")]
	public void MNOBABIJCMP(BBELGAHDANM ILEMOHLPHEC, object DELDIDDNALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2CA9140", Offset = "0x2CA8540", VA = "0x182CA9140")]
	public void AIPDJBJFCKF<T>(Action<T> LEEHGGEJIDA) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8F80", Offset = "0x2CA8380", VA = "0x182CA8F80")]
	public void AIPDJBJFCKF<T, TUserData>(Action<T, TUserData> LEEHGGEJIDA) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AIJBIFAIBJE : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6129700", Offset = "0x6128B00", VA = "0x186129700")]
	public AIJBIFAIBJE(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PGKFEJINCOP : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6140030", Offset = "0x613F430", VA = "0x186140030")]
	public PGKFEJINCOP(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class EMKKEANAINA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum JODGLICCPBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class OKPNAPEOCJK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public JODGLICCPBE LLHMNEIJLPP;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4A74A20", Offset = "0x4A73E20", VA = "0x184A74A20", Slot = "4")]
		public virtual void MABFCCPGADF(MethodInfo MJKNAABLGKH, MethodInfo PHEKABGBAFL, JODGLICCPBE EKNPHEPNHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void MPJPGDLFCLI(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void CIEOIKOEJFP(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		protected OKPNAPEOCJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class KOFKBGAJOIO<TClass, TProperty> : OKPNAPEOCJK<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> JNDAMKDFJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> EAMGJPMHBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> KGHLMOKIHBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> MLMNDKECLHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> PJLOIBLPICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> BNCDCMJMHPO;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4538540", Offset = "0x4537940", VA = "0x184538540", Slot = "7")]
		public override void AJFABMEOLDF(TClass EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x45381C0", Offset = "0x45375C0", VA = "0x1845381C0", Slot = "8")]
		public override void AIJOICFCGBH(TClass EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x453ECD0", Offset = "0x453E0D0", VA = "0x18453ECD0", Slot = "9")]
		public override void MPJPGDLFCLI(TClass EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4539340", Offset = "0x4538740", VA = "0x184539340", Slot = "10")]
		public override void CIEOIKOEJFP(TClass EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4539B20", Offset = "0x4538F20", VA = "0x184539B20")]
		protected TProperty[] GFHMADDOMNI(TClass EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4539C30", Offset = "0x4539030", VA = "0x184539C30")]
		protected TProperty[] LJHPEGFGINF(TClass EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x453D4F0", Offset = "0x453C8F0", VA = "0x18453D4F0", Slot = "4")]
		public override void MABFCCPGADF(MethodInfo MJKNAABLGKH, MethodInfo PHEKABGBAFL, JODGLICCPBE EKNPHEPNHJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3B648F0", Offset = "0x3B63CF0", VA = "0x183B648F0")]
		protected KOFKBGAJOIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class BOOCHGNAHID<TClass, TProperty> : KOFKBGAJOIO<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void KNOHBAKKGEL(BBELGAHDANM AKMABNIDADH, [Out] TProperty CCOCIOCMPFE);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void OBIHBEMCLCP(JAOAGKIOFAM MAHNIEPOPIG, TProperty CCOCIOCMPFE);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5279930", Offset = "0x5278D30", VA = "0x185279930", Slot = "5")]
		public override void ININPHDECDH(TClass EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5279A50", Offset = "0x5278E50", VA = "0x185279A50", Slot = "6")]
		public override void JPEPEKDGNLK(TClass EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x52797D0", Offset = "0x5278BD0", VA = "0x1852797D0", Slot = "7")]
		public override void AJFABMEOLDF(TClass EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5279590", Offset = "0x5278990", VA = "0x185279590", Slot = "8")]
		public override void AIJOICFCGBH(TClass EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F5A1D0", Offset = "0x3F595D0", VA = "0x183F5A1D0")]
		protected BOOCHGNAHID()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class EOHKPINBJCG<T> : KOFKBGAJOIO<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4D50", Offset = "0x3BB4150", VA = "0x183BB4D50", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4DD0", Offset = "0x3BB41D0", VA = "0x183BB4DD0", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4CD0", Offset = "0x3BB40D0", VA = "0x183BB4CD0", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4C60", Offset = "0x3BB4060", VA = "0x183BB4C60", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public EOHKPINBJCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class BEAIPIPIKNI<T> : KOFKBGAJOIO<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x522E400", Offset = "0x522D800", VA = "0x18522E400", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4DD0", Offset = "0x3BB41D0", VA = "0x183BB4DD0", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x522E380", Offset = "0x522D780", VA = "0x18522E380", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4C60", Offset = "0x3BB4060", VA = "0x183BB4C60", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public BEAIPIPIKNI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class NMBHCKHDKIL<T> : KOFKBGAJOIO<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x495ED80", Offset = "0x495E180", VA = "0x18495ED80", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x420DF90", Offset = "0x420D390", VA = "0x18420DF90", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x495ED00", Offset = "0x495E100", VA = "0x18495ED00", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x420DE20", Offset = "0x420D220", VA = "0x18420DE20", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public NMBHCKHDKIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class IHPIDFAMANB<T> : KOFKBGAJOIO<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x420DF10", Offset = "0x420D310", VA = "0x18420DF10", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x420DF90", Offset = "0x420D390", VA = "0x18420DF90", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x420DE90", Offset = "0x420D290", VA = "0x18420DE90", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x420DE20", Offset = "0x420D220", VA = "0x18420DE20", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public IHPIDFAMANB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class HGECEJBDKCO<T> : KOFKBGAJOIO<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4130990", Offset = "0x412FD90", VA = "0x184130990", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4130A10", Offset = "0x412FE10", VA = "0x184130A10", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4130910", Offset = "0x412FD10", VA = "0x184130910", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FEF0", Offset = "0x3B5F2F0", VA = "0x183B5FEF0", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public HGECEJBDKCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OPCFKCBHMJF<T> : KOFKBGAJOIO<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4A86D10", Offset = "0x4A86110", VA = "0x184A86D10", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4130A10", Offset = "0x412FE10", VA = "0x184130A10", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4A86C90", Offset = "0x4A86090", VA = "0x184A86C90", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FEF0", Offset = "0x3B5F2F0", VA = "0x183B5FEF0", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public OPCFKCBHMJF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class ALJBILBMOMB<T> : KOFKBGAJOIO<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x40FF020", Offset = "0x40FE420", VA = "0x1840FF020", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x40FF0A0", Offset = "0x40FE4A0", VA = "0x1840FF0A0", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x40FEFA0", Offset = "0x40FE3A0", VA = "0x1840FEFA0", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x40FEF30", Offset = "0x40FE330", VA = "0x1840FEF30", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public ALJBILBMOMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class CAJKJHAJCHP<T> : KOFKBGAJOIO<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x40FF020", Offset = "0x40FE420", VA = "0x1840FF020", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x40FF0A0", Offset = "0x40FE4A0", VA = "0x1840FF0A0", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x544DEF0", Offset = "0x544D2F0", VA = "0x18544DEF0", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x40FEF30", Offset = "0x40FE330", VA = "0x1840FEF30", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public CAJKJHAJCHP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class KGNKAKCBCLE<T> : KOFKBGAJOIO<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x44FFFC0", Offset = "0x44FF3C0", VA = "0x1844FFFC0", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4500040", Offset = "0x44FF440", VA = "0x184500040", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x44FFF40", Offset = "0x44FF340", VA = "0x1844FFF40", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4C60", Offset = "0x3BB4060", VA = "0x183BB4C60", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public KGNKAKCBCLE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class EADBDMIAGIL<T> : KOFKBGAJOIO<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FFE0", Offset = "0x3B5F3E0", VA = "0x183B5FFE0", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3B60060", Offset = "0x3B5F460", VA = "0x183B60060", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FF60", Offset = "0x3B5F360", VA = "0x183B5FF60", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3B5FEF0", Offset = "0x3B5F2F0", VA = "0x183B5FEF0", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public EADBDMIAGIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class IHMNLGEMKBA<T> : KOFKBGAJOIO<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x420DD30", Offset = "0x420D130", VA = "0x18420DD30", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x420DDB0", Offset = "0x420D1B0", VA = "0x18420DDB0", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x420DCB0", Offset = "0x420D0B0", VA = "0x18420DCB0", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x40FEF30", Offset = "0x40FE330", VA = "0x1840FEF30", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3B600D0", Offset = "0x3B5F4D0", VA = "0x183B600D0")]
		public IHMNLGEMKBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class LNCEJADMNOH<T> : BOOCHGNAHID<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x467B400", Offset = "0x467A800", VA = "0x18467B400", Slot = "12")]
		protected override void OBIHBEMCLCP(JAOAGKIOFAM MAHNIEPOPIG, char CCOCIOCMPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x467B3D0", Offset = "0x467A7D0", VA = "0x18467B3D0", Slot = "11")]
		protected override void KNOHBAKKGEL(BBELGAHDANM AKMABNIDADH, [Out] char CCOCIOCMPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x416DA00", Offset = "0x416CE00", VA = "0x18416DA00")]
		public LNCEJADMNOH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class JFDJJNCIMLB<T> : BOOCHGNAHID<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x43DEBA0", Offset = "0x43DDFA0", VA = "0x1843DEBA0", Slot = "12")]
		protected override void OBIHBEMCLCP(JAOAGKIOFAM MAHNIEPOPIG, IPEndPoint CCOCIOCMPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x43DEB60", Offset = "0x43DDF60", VA = "0x1843DEB60", Slot = "11")]
		protected override void KNOHBAKKGEL(BBELGAHDANM AKMABNIDADH, [Out] IPEndPoint CCOCIOCMPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x416DA00", Offset = "0x416CE00", VA = "0x18416DA00")]
		public JFDJJNCIMLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class DHDFPBIKEJF<T> : KOFKBGAJOIO<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int CBIFHFLOMFI;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3DC0", Offset = "0x5BF31C0", VA = "0x185BF3DC0")]
		public DHDFPBIKEJF(int CBPLCBHEDDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3CC0", Offset = "0x5BF30C0", VA = "0x185BF3CC0", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3D40", Offset = "0x5BF3140", VA = "0x185BF3D40", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3C40", Offset = "0x5BF3040", VA = "0x185BF3C40", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5BF3BC0", Offset = "0x5BF2FC0", VA = "0x185BF3BC0", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class OIAIEMEPPAO<T> : OKPNAPEOCJK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo CCFHHEJINME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type JLICGPGDDBB;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CDB0", Offset = "0x4A5C1B0", VA = "0x184A5CDB0")]
		public OIAIEMEPPAO(PropertyInfo BCPKEGMOEBD, Type MLNPCLGDGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CBE0", Offset = "0x4A5BFE0", VA = "0x184A5CBE0", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CCA0", Offset = "0x4A5C0A0", VA = "0x184A5CCA0", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CB20", Offset = "0x4A5BF20", VA = "0x184A5CB20", Slot = "7")]
		public override void AJFABMEOLDF(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CAC0", Offset = "0x4A5BEC0", VA = "0x184A5CAC0", Slot = "8")]
		public override void AIJOICFCGBH(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CD50", Offset = "0x4A5C150", VA = "0x184A5CD50", Slot = "9")]
		public override void MPJPGDLFCLI(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x4A5CB80", Offset = "0x4A5BF80", VA = "0x184A5CB80", Slot = "10")]
		public override void CIEOIKOEJFP(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class DLIKMGMIJAL<T> : OIAIEMEPPAO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F5C0", Offset = "0x3B9E9C0", VA = "0x183B9F5C0")]
		public DLIKMGMIJAL(PropertyInfo BCPKEGMOEBD, Type MLNPCLGDGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C03660", Offset = "0x5C02A60", VA = "0x185C03660", Slot = "5")]
		public override void ININPHDECDH(T EGADADNKCBD, BBELGAHDANM AKMABNIDADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C03720", Offset = "0x5C02B20", VA = "0x185C03720", Slot = "6")]
		public override void JPEPEKDGNLK(T EGADADNKCBD, JAOAGKIOFAM MAHNIEPOPIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class EOAJAPFEKAJ<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static EOAJAPFEKAJ<T> GHDNHBBFDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly OKPNAPEOCJK<T>[] EBPKKBDEDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int ANOODILDEIN;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4210", Offset = "0x3BB3610", VA = "0x183BB4210")]
		public EOAJAPFEKAJ(List<OKPNAPEOCJK<T>> CCGHLKAIJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3BB4160", Offset = "0x3BB3560", VA = "0x183BB4160")]
		public void JPEPEKDGNLK(T FAKGLFFOLFI, JAOAGKIOFAM FJOPPBPMLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3BB40B0", Offset = "0x3BB34B0", VA = "0x183BB40B0")]
		public void ININPHDECDH(T FAKGLFFOLFI, BBELGAHDANM ILEMOHLPHEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class BEMLKFPPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract OKPNAPEOCJK<T> GEKLBPFDDHO<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private JAOAGKIOFAM PHNMCJCCNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int ADHBFIHKOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, BEMLKFPPPLB> ONJDPBMLIPJ;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x612E270", Offset = "0x612D670", VA = "0x18612E270")]
	public EMKKEANAINA(int CLIFJKOKJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x2D46FD0", Offset = "0x2D463D0", VA = "0x182D46FD0")]
	private EOAJAPFEKAJ<T> OIICGLCHICH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2CAC9E0", Offset = "0x2CABDE0", VA = "0x182CAC9E0")]
	public void CIGOIKFLIDO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2D46F30", Offset = "0x2D46330", VA = "0x182D46F30")]
	public bool LIJBJHOEHGL<T>(BBELGAHDANM ILEMOHLPHEC, T KLACLBHAHNL) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2D46EA0", Offset = "0x2D462A0", VA = "0x182D46EA0")]
	public void IJIPNHCCMND<T>(JAOAGKIOFAM FJOPPBPMLFL, T FAKGLFFOLFI) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class EGKLFMDCJMN
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime ELDAKELEOPB;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] BGKAINKAEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LIJOKHCNBBK DPJNPLBDPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x612D0A0", Offset = "0x612C4A0", VA = "0x18612D0A0")]
		get
		{
			return default(LIJOKHCNBBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DOKGBNHLFDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x612C780", Offset = "0x612BB80", VA = "0x18612C780")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x612C740", Offset = "0x612BB40", VA = "0x18612C740")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public PLNDILKHPPA EIJCBACHEEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x612D420", Offset = "0x612C820", VA = "0x18612D420")]
		get
		{
			return default(PLNDILKHPPA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x612CCE0", Offset = "0x612C0E0", VA = "0x18612CCE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int MHLCDCKMPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x612CD80", Offset = "0x612C180", VA = "0x18612CD80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint LNOPDLDJFAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x612D1A0", Offset = "0x612C5A0", VA = "0x18612D1A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? KFDGPPFJCDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x612CDB0", Offset = "0x612C1B0", VA = "0x18612CDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? EOBANOBHIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x612D070", Offset = "0x612C470", VA = "0x18612D070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? LDFNBIJHAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x612C7B0", Offset = "0x612BBB0", VA = "0x18612C7B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x612D450", Offset = "0x612C850", VA = "0x18612D450")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? EAECFHIEGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x96D250", Offset = "0x96C650", VA = "0x18096D250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x612D730", Offset = "0x612CB30", VA = "0x18612D730")]
	public EGKLFMDCJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x612D680", Offset = "0x612CA80", VA = "0x18612D680")]
	internal EGKLFMDCJMN(byte[] HFBIMFCNCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x612CBC0", Offset = "0x612BFC0", VA = "0x18612CBC0")]
	public static EGKLFMDCJMN GNJGFIDFDPA(byte[] HFBIMFCNCFE, DateTime OHPFFNELIBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x612C9C0", Offset = "0x612BDC0", VA = "0x18612C9C0")]
	internal void GKFFLLAJJHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x612C7E0", Offset = "0x612BBE0", VA = "0x18612C7E0")]
	private void EIOHBHNLGCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x612D220", Offset = "0x612C620", VA = "0x18612D220")]
	private DateTime? NABEDELOOEE(int HHOJFKLGPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x612CEA0", Offset = "0x612C2A0", VA = "0x18612CEA0")]
	private void JKKHLHAEJOP(int HHOJFKLGPBP, DateTime? PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x612D0D0", Offset = "0x612C4D0", VA = "0x18612D0D0")]
	private ulong MMMBHAMCBDB(int HHOJFKLGPBP)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x612CDE0", Offset = "0x612C1E0", VA = "0x18612CDE0")]
	private void IPDJFDGALJL(int HHOJFKLGPBP, ulong PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x612C6B0", Offset = "0x612BAB0", VA = "0x18612C6B0")]
	private uint BHNDAAAANLO(int HHOJFKLGPBP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FFDDC0", Offset = "0x5FFD1C0", VA = "0x185FFDDC0")]
	private static uint IAFKLCKEOPH(uint KPPEBBOFEKD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x612CD20", Offset = "0x612C120", VA = "0x18612CD20")]
	private static ulong IAFKLCKEOPH(ulong KPPEBBOFEKD)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum LIJOKHCNBBK
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
public enum PLNDILKHPPA
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class JAJBKLEBFDF
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int JGJNAAMOLPD = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int MNFCMMGGAHA = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int FEOICHMCLIH = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint OEIEKMNHIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int BELHDCNELJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int EHFHELDPOMP;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool NGDMFHMJKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x612F340", Offset = "0x612E740", VA = "0x18612F340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x612F250", Offset = "0x612E650", VA = "0x18612F250")]
	public bool HMLHNBDCPOH(DBMECLBODDA EJFPBLGAMPN, int HEJHCAGJGFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class ELBNMMMDEKN : DBMECLBODDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket EJFPBLGAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly NBPJGGGCIDB AOCOCJEHHEH;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short IJAMABFIBIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x612E180", Offset = "0x612D580", VA = "0x18612E180", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int HCFPDHKPNPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x612E1A0", Offset = "0x612D5A0", VA = "0x18612E1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint CFPKFPBLIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x612DA50", Offset = "0x612CE50", VA = "0x18612DA50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily NMAHFMNGDFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x45B7400", Offset = "0x45B6800", VA = "0x1845B7400", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x612E1C0", Offset = "0x612D5C0", VA = "0x18612E1C0")]
	public ELBNMMMDEKN(AddressFamily HKFMHMHDHFO, NBPJGGGCIDB AOCOCJEHHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x612DBC0", Offset = "0x612CFC0", VA = "0x18612DBC0", Slot = "8")]
	public bool MEHMLMCOANH(IPEndPoint DPJMPBPOJKC, IHGGOEKGHCJ PBLKMOBOIII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x612DB80", Offset = "0x612CF80", VA = "0x18612DB80", Slot = "9")]
	public int LNHGCHFEOOJ(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, int JKIIGJDNBMO, IPEndPoint DFHJGGIMKBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x612DA90", Offset = "0x612CE90", VA = "0x18612DA90", Slot = "10")]
	public int HLLBGNGFFJN(byte[] GMKBBDEHIHO, EndPoint HLEIACKCOBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x612DA70", Offset = "0x612CE70", VA = "0x18612DA70", Slot = "11")]
	public void CPJOHNBIHPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface DBMECLBODDA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short IJAMABFIBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int HCFPDHKPNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint CFPKFPBLIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily NMAHFMNGDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MEHMLMCOANH(IPEndPoint DPJMPBPOJKC, IHGGOEKGHCJ PBLKMOBOIII);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int LNHGCHFEOOJ(byte[] GMKBBDEHIHO, int HHOJFKLGPBP, int JKIIGJDNBMO, IPEndPoint DFHJGGIMKBC);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int HLLBGNGFFJN(byte[] GMKBBDEHIHO, EndPoint DFHJGGIMKBC);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPJOHNBIHPO();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct GDIDEECCJEH : IEquatable<GDIDEECCJEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long FODJIHIPDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long FCEOBAPPFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long MDEDDHOEDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int EDKNMLLFFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int KJMPMPJIGMD;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x612E580", Offset = "0x612D980", VA = "0x18612E580")]
	public GDIDEECCJEH(byte[] HMGPCAGLHGL, int GBKOCMPPGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8C3890", Offset = "0x8C2C90", VA = "0x1808C3890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x612E540", Offset = "0x612D940", VA = "0x18612E540", Slot = "4")]
	public bool Equals(GDIDEECCJEH OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x612E490", Offset = "0x612D890", VA = "0x18612E490", Slot = "0")]
	public override bool Equals(object FAKGLFFOLFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class POIFBPMLNFL : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] JEOOCNPEAGN;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class CPGLMDHOBDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int LELHEOJPIPA;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8A5100", Offset = "0x8A4500", VA = "0x1808A5100")]
	protected CPGLMDHOBDJ(int BBPDILKGPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void HGAAMPAKHDO(IPEndPoint DPJMPBPOJKC, byte[] EIFGKHNPLEK, int HHOJFKLGPBP, int LGPCCHEOHGO);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CIDJEENLGAF(IPEndPoint DPJMPBPOJKC, byte[] EIFGKHNPLEK, int HHOJFKLGPBP, int LGPCCHEOHGO);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class KNICNPPFOPN : CPGLMDHOBDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] PBFBBOFLBNL;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator CGOBLFPOJAH;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2297890", Offset = "0x2296C90", VA = "0x182297890")]
	public KNICNPPFOPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6130720", Offset = "0x612FB20", VA = "0x186130720")]
	public void HEDLCLILIEL(IPEndPoint DPJMPBPOJKC, byte[] PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6130D80", Offset = "0x6130180", VA = "0x186130D80")]
	public void OHDGMELHNPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x61308D0", Offset = "0x612FCD0", VA = "0x1861308D0", Slot = "4")]
	public override void HGAAMPAKHDO(IPEndPoint DPJMPBPOJKC, byte[] EIFGKHNPLEK, int HHOJFKLGPBP, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x61303B0", Offset = "0x612F7B0", VA = "0x1861303B0", Slot = "5")]
	public override void CIDJEENLGAF(IPEndPoint DPJMPBPOJKC, byte[] EIFGKHNPLEK, int HHOJFKLGPBP, int LGPCCHEOHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct DKMDBMHNAHA
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void BEFNLFNONEI([NoAlias] byte* NPPFKPOHLJL, [NoAlias] byte* PBFBBOFLBNL, [NoAlias] byte* LKDILNBDBOM, int LGPCCHEOHGO);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class FOCHAPHPFLL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x6140660", Offset = "0x613FA60", VA = "0x186140660")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6140A80", Offset = "0x613FE80", VA = "0x186140A80")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x61409D0", Offset = "0x613FDD0", VA = "0x1861409D0")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6140790", Offset = "0x613FB90", VA = "0x186140790")]
		public unsafe static void IIFNBMCHKOM([NoAlias] byte* NPPFKPOHLJL, [NoAlias] byte* PBFBBOFLBNL, [NoAlias] byte* LKDILNBDBOM, int LGPCCHEOHGO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint PBFBBOFLBNL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint LKDILNBDBOM[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint NOKKNAKPOGF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint MDBPEOGIFBB[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint KKDKJACOAMD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint IAIPIPCGEIE[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint MBEDLBBNGAF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint EOGGNEOJGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint NDDFIDLDCFM[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x612C630", Offset = "0x612BA30", VA = "0x18612C630")]
	private void PGGELGPJGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x612C600", Offset = "0x612BA00", VA = "0x18612C600")]
	private uint MLCNEKFBGEP(uint FCBPGONDPJI, int FDKCHGCMEPD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6129140", Offset = "0x6128540", VA = "0x186129140")]
	private void IMADOPHEMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x61291F0", Offset = "0x61285F0", VA = "0x1861291F0")]
	private void MGJJKICLLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x61290B0", Offset = "0x61284B0", VA = "0x1861290B0")]
	private void DJBABFIHEIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6129400", Offset = "0x6128800", VA = "0x186129400")]
	private void PPIDBGEMKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x612BEB0", Offset = "0x612B2B0", VA = "0x18612BEB0")]
	private void ADIJIDGDBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x612BF10", Offset = "0x612B310", VA = "0x18612BF10")]
	private unsafe void CJMOJCAFKKC(byte* NPPFKPOHLJL, uint* PBFBBOFLBNL, uint* LKDILNBDBOM, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x612C430", Offset = "0x612B830", VA = "0x18612C430")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void IFBOMBFKMDJ([NoAlias] byte* NPPFKPOHLJL, [NoAlias] byte* PBFBBOFLBNL, [NoAlias] byte* LKDILNBDBOM, int LGPCCHEOHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x612C4B0", Offset = "0x612B8B0", VA = "0x18612C4B0")]
	public static void IFBOMBFKMDJ(Span<byte> NPPFKPOHLJL, Span<byte> PBFBBOFLBNL, Span<byte> LKDILNBDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x612C330", Offset = "0x612B730", VA = "0x18612C330")]
	public static void EGKONPDGHKH(Span<byte> NPPFKPOHLJL, Span<byte> PBFBBOFLBNL, Span<byte> LKDILNBDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x612C590", Offset = "0x612B990", VA = "0x18612C590")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void KMLDFKIBABF([NoAlias] byte* NPPFKPOHLJL, [NoAlias] byte* PBFBBOFLBNL, [NoAlias] byte* LKDILNBDBOM, int LGPCCHEOHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6140BE0", Offset = "0x613FFE0", VA = "0x186140BE0")]
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
