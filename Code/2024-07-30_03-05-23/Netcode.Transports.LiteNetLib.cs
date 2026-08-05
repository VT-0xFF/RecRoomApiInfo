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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, ONNFBOPBOBC
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum OPKBJOKENMH
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
		private NetworkManager GHLKNCLNEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, ALPHIOGOAKG> GAJLNGCNCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EFONNIOJBCM JKGBILLFLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] EOMAGGJFLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OPKBJOKENMH JJAGCKDLKJO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong CAIGOIPBJHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8677A0", Offset = "0x865DA0", VA = "0x1808677A0", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool PKKKAMFPJHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5E29340", Offset = "0x5E27940", VA = "0x185E29340", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E288A0", Offset = "0x5E26EA0", VA = "0x185E288A0")]
		public void RecRoom_SetEncryptionInfo(ulong FKNPEBHLKOL, byte[] IBBDLGCDELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E28880", Offset = "0x5E26E80", VA = "0x185E28880")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5E28750", Offset = "0x5E26D50", VA = "0x185E28750")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E29240", Offset = "0x5E27840", VA = "0x185E29240")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E28A40", Offset = "0x5E27040", VA = "0x185E28A40", Slot = "6")]
		public override void Send(ulong BMDIOLCKPIJ, ArraySegment<byte> MMDLBEBNCGC, NetworkDelivery JGKDMBICJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E28840", Offset = "0x5E26E40", VA = "0x185E28840", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong BMDIOLCKPIJ, [Out] ArraySegment<byte> OGADPHAKNMI, [Out] float DFBALLOLIAC)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E28D30", Offset = "0x5E27330", VA = "0x185E28D30", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E29160", Offset = "0x5E27760", VA = "0x185E29160", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E27D10", Offset = "0x5E26310", VA = "0x185E27D10", Slot = "10")]
		public override void DisconnectRemoteClient(ulong BMDIOLCKPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E27BC0", Offset = "0x5E261C0", VA = "0x185E27BC0", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E280F0", Offset = "0x5E266F0", VA = "0x185E280F0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong BMDIOLCKPIJ)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E28CC0", Offset = "0x5E272C0", VA = "0x185E28CC0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E282D0", Offset = "0x5E268D0", VA = "0x185E282D0", Slot = "14")]
		public override void Initialize([Optional] NetworkManager GHLKNCLNEAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E27E80", Offset = "0x5E26480", VA = "0x185E27E80")]
		private HBBNONGBPCG ECOPDDJBCBJ(NetworkDelivery GOAECDHCJMK)
		{
			return default(HBBNONGBPCG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E28030", Offset = "0x5E26630", VA = "0x185E28030", Slot = "15")]
		private void FKHGPOGBKNO(ALPHIOGOAKG BEDJFABJDIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E28190", Offset = "0x5E26790", VA = "0x185E28190", Slot = "16")]
		private void ILHJBNNKMGL(ALPHIOGOAKG BEDJFABJDIG, DHOMGDPIMHF GAGAPPEHEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "17")]
		private void GMFEFBDCADM(IPEndPoint IILILNHEHKN, SocketError BPIHGIBKFLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E28540", Offset = "0x5E26B40", VA = "0x185E28540", Slot = "18")]
		private void ONEJPJCMLJE(ALPHIOGOAKG BEDJFABJDIG, OEMFLKAHPPI MMDEOFGAFEK, byte HONJBGKAAKP, HBBNONGBPCG DDHEDCNFABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E27F50", Offset = "0x5E26550", VA = "0x185E27F50")]
		private void FAGMGIKHIEH(int LPKLLJKOBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "19")]
		private void AENJDNMGKMC(IPEndPoint HENIIGIHEIF, OEMFLKAHPPI MMDEOFGAFEK, EIADKDKDMLA HFLDKOGNIMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "20")]
		private void DIGGLAJILMM(ALPHIOGOAKG BEDJFABJDIG, int FNBGLPJNIOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E284E0", Offset = "0x5E26AE0", VA = "0x185E284E0", Slot = "21")]
		private void NLHCOBEMILC(BPPCEFHHOKP EPDDNPCGMCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5E284B0", Offset = "0x5E26AB0", VA = "0x185E284B0")]
		private ulong MGDELFIAKED(ALPHIOGOAKG BEDJFABJDIG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5E28490", Offset = "0x5E26A90", VA = "0x185E28490")]
		private static int KCEOLDGGNLK(float HAGKGIBCOBL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5E29260", Offset = "0x5E27860", VA = "0x185E29260")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CPMINFKKDKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly ALPHIOGOAKG CBNIFGHLDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HHLBPPIMLPI> OGKAAIMCAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int CACAKFFDLNJ;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E19910", Offset = "0x5E17F10", VA = "0x185E19910")]
	protected CPMINFKKDKF(ALPHIOGOAKG BEDJFABJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E197F0", Offset = "0x5E17DF0", VA = "0x185E197F0")]
	public void FBAFIAIFCHI(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E19890", Offset = "0x5E17E90", VA = "0x185E19890")]
	protected void OPDDOKNIAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E19850", Offset = "0x5E17E50", VA = "0x185E19850")]
	public bool KELNABFAIJJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool DGKKCCAALKO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool JCFPDGFBJDM(HHLBPPIMLPI AJJDDDKMKDC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum CGNPFONJDJL
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
public class BPPCEFHHOKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EFONNIOJBCM PDPJDOABBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int KFMBFKKAGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal KJDILBIOFIO IGLOHEAMKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint NFDPFFJIAMF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CGNPFONJDJL NFBDLKDFCFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88ECA0", Offset = "0x88D2A0", VA = "0x18088ECA0")]
		[CompilerGenerated]
		get
		{
			return default(CGNPFONJDJL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB0D220", Offset = "0xB0B820", VA = "0x180B0D220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E19680", Offset = "0x5E17C80", VA = "0x185E19680")]
	internal void ALIAHPMJOPB(KJDILBIOFIO BELKFEBAMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E19740", Offset = "0x5E17D40", VA = "0x185E19740")]
	private bool LINHGGDCBIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5E19770", Offset = "0x5E17D70", VA = "0x185E19770")]
	internal BPPCEFHHOKP(IPEndPoint HENIIGIHEIF, KJDILBIOFIO OOFDPDOLAKK, EFONNIOJBCM MEDPKOGPCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E196E0", Offset = "0x5E17CE0", VA = "0x185E196E0")]
	public ALPHIOGOAKG IPAGIAFCGIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum EIADKDKDMLA
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum OALAKALOGIP
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
public struct DHOMGDPIMHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public OALAKALOGIP PBEIOHKBDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError JDDCGINEPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public OEMFLKAHPPI PKINLDKLKCI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ONNFBOPBOBC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJDOMIANLDK(ALPHIOGOAKG BEDJFABJDIG);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDONHJGMKGC(ALPHIOGOAKG BEDJFABJDIG, DHOMGDPIMHF GAGAPPEHEKO);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PFIEAILAHDI(IPEndPoint IILILNHEHKN, SocketError BPIHGIBKFLJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKCOKANAHKO(ALPHIOGOAKG BEDJFABJDIG, OEMFLKAHPPI MMDEOFGAFEK, byte HONJBGKAAKP, HBBNONGBPCG DDHEDCNFABH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BIKPLPACGID(IPEndPoint HENIIGIHEIF, OEMFLKAHPPI MMDEOFGAFEK, EIADKDKDMLA HFLDKOGNIMP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KFLKJONMDKK(ALPHIOGOAKG BEDJFABJDIG, int FNBGLPJNIOO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BDLJGCDKPPH(BPPCEFHHOKP EPDDNPCGMCI);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AGMCBEJMOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDKGNHKKGAB(ALPHIOGOAKG BEDJFABJDIG, object KDFLHFONPJE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KEBJBDLPILP
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LMKJBBBIHAG(LMMMIKEHEAD AJJDDDKMKDC);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EAEFNHFKDKN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELAOHKGLEGB(ALPHIOGOAKG BEDJFABJDIG, IPEndPoint LOKDMPEMIGK);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class KJDILBIOFIO
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int OPLHBDPFKIM = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long PPNHGNAAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte AAHDECIFPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] NILFLNKANGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly JOMEGECCBCE GDPGJFHLHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int AAMCMIDCMCI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E26640", Offset = "0x5E24C40", VA = "0x185E26640")]
	private KJDILBIOFIO(long MGHGGBMLECM, byte KCECACECLKH, int NACMAJFMJAJ, byte[] BHONBNGOHHG, JOMEGECCBCE MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E263C0", Offset = "0x5E249C0", VA = "0x185E263C0")]
	public static int HACNCOGPCLJ(HHLBPPIMLPI AJJDDDKMKDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E26420", Offset = "0x5E24A20", VA = "0x185E26420")]
	public static KJDILBIOFIO HIFOFBBCIDI(HHLBPPIMLPI AJJDDDKMKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E261E0", Offset = "0x5E247E0", VA = "0x185E261E0")]
	public static HHLBPPIMLPI ADBBJBCONGF(DDKJAJGINNB JGFBADMCPAB, SocketAddress LBAOINCKNFO, long JBNBHBNFDEB, int NACMAJFMJAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class MHDDNDCICEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long PPNHGNAAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte AAHDECIFPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int AAMCMIDCMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool PJNKGNGELAA;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E296A0", Offset = "0x5E27CA0", VA = "0x185E296A0")]
	private MHDDNDCICEH(long MGHGGBMLECM, byte KCECACECLKH, int BHGHHFELLFC, bool NNJMHBPJFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E29450", Offset = "0x5E27A50", VA = "0x185E29450")]
	public static MHDDNDCICEH HIFOFBBCIDI(HHLBPPIMLPI AJJDDDKMKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E29360", Offset = "0x5E27960", VA = "0x185E29360")]
	public static HHLBPPIMLPI ADBBJBCONGF(long JBNBHBNFDEB, byte BNFKNJBHGAM, int KMOKNADMOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E295A0", Offset = "0x5E27BA0", VA = "0x185E295A0")]
	public static HHLBPPIMLPI OMNOHHANAAJ(ALPHIOGOAKG BEDJFABJDIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GJKLNICOODB
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DKJCCNLKPHK
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DLIGDKEGPBE(IPEndPoint LHIMHDNGCDF, IPEndPoint HENIIGIHEIF, string NJLOKHEKBBE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIGNDLDIGBA(IPEndPoint GKBNIFMHLIO, GJKLNICOODB GOAECDHCJMK, string NJLOKHEKBBE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JNPHLJHPIIB
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct FLCMDGBPCIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint NMIBIIKANDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint NFDPFFJIAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string LDPKNPINICA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct GBMDEFBIKKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint PPDHJEPGMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GJKLNICOODB LADEKBPIHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string LDPKNPINICA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class JKLLEJCNDEI
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint CBNBNJGFNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string LDPKNPINICA
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JKLLEJCNDEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class JFBPDEAOBPP
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint CBNBNJGFNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint JBCKLOBENII
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string LDPKNPINICA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JFBPDEAOBPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class KEHGEOAJPJB
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LDPKNPINICA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LPBKNFDBHOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x869EA0", Offset = "0x8684A0", VA = "0x180869EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KEHGEOAJPJB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly EFONNIOJBCM FLOLGAJDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<FLCMDGBPCIJ> FDNAGLGAHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<GBMDEFBIKKO> NEMKNENEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JOMEGECCBCE OJFBLLHFNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly DDKJAJGINNB BPPBMJFMOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly EPPGCFAIPCA BJEAOABPGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private DKJCCNLKPHK OCJFCLHJKMK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int NNAKCEDIFBB = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool BEEJCBKFOKA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5E25140", Offset = "0x5E23740", VA = "0x185E25140")]
	internal JNPHLJHPIIB(EFONNIOJBCM DCEJINAEKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E24FE0", Offset = "0x5E235E0", VA = "0x185E24FE0")]
	internal void PKANKMBCNME(IPEndPoint MDGJOOMCNIH, HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C076C0", Offset = "0x2C05CC0", VA = "0x182C076C0")]
	private void OPHEFDNPNLG<T>(T AJJDDDKMKDC, IPEndPoint PABFDMCLKCE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E24B50", Offset = "0x5E23150", VA = "0x185E24B50")]
	private void DLIGDKEGPBE(JKLLEJCNDEI FJCFFBIBKOL, IPEndPoint MDGJOOMCNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E24E80", Offset = "0x5E23480", VA = "0x185E24E80")]
	private void KMAJGMLFIPJ(JFBPDEAOBPP FJCFFBIBKOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E24CE0", Offset = "0x5E232E0", VA = "0x185E24CE0")]
	private void FCCBOHPPNPM(KEHGEOAJPJB FJCFFBIBKOL, IPEndPoint MDGJOOMCNIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum HBBNONGBPCG : byte
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
public enum PBGCONOGDNJ : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LLNAIJOLLII
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] JFAMBELGMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int BPNLKLBGCCH;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int CDOKHPGJLAO;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class INLICDAGEKI : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E197E0", Offset = "0x5E17DE0", VA = "0x185E197E0")]
	public INLICDAGEKI(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CCNDPJBOPNN : INLICDAGEKI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E197E0", Offset = "0x5E17DE0", VA = "0x185E197E0")]
	public CCNDPJBOPNN(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum ALDAOFLEBGB
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
public interface MNCMAIIJHFI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MPPHDBFLHHL(ALDAOFLEBGB BKFJGNCEDNF, string KFOCKGMHIBO, params object[] CNKOAIGMGCF);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NIPIJPIFHFD
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static MNCMAIIJHFI FMDIBFFIJMK;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object MHIIKJIMLIE;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5E29750", Offset = "0x5E27D50", VA = "0x185E29750")]
	private static void NKHKMCEJMID(ALDAOFLEBGB EKEIBMCNAPM, string KFOCKGMHIBO, params object[] CNKOAIGMGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5E296F0", Offset = "0x5E27CF0", VA = "0x185E296F0")]
	internal static void CMBJBIPAGLI(string KFOCKGMHIBO, params object[] CNKOAIGMGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E29980", Offset = "0x5E27F80", VA = "0x185E29980")]
	internal static void OFMBCCNAOHO(string KFOCKGMHIBO, params object[] CNKOAIGMGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E299E0", Offset = "0x5E27FE0", VA = "0x185E299E0")]
	internal static void PKMIMMLDNIM(string KFOCKGMHIBO, params object[] CNKOAIGMGCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DCCKNKNAEPO
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OEMFLKAHPPI : JOMEGECCBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HHLBPPIMLPI JJKJJIMOEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EFONNIOJBCM DKOIGMKPKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly JLNGJBAGDBG BAOJBHMLHGF;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A1E0", Offset = "0x5E287E0", VA = "0x185E2A1E0")]
	internal OEMFLKAHPPI(EFONNIOJBCM FECFMDJKBKG, JLNGJBAGDBG DNLMIBJALAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A0C0", Offset = "0x5E286C0", VA = "0x185E2A0C0")]
	internal void FBIFFGDPCBH(HHLBPPIMLPI AJJDDDKMKDC, int GPDOBLJLJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A160", Offset = "0x5E28760", VA = "0x185E2A160")]
	internal void OKEPLIDKHDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A130", Offset = "0x5E28730", VA = "0x185E2A130")]
	public void NGIOPBOJJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class JLNGJBAGDBG
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum OEBEDPEKDOH
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
	public JLNGJBAGDBG OCFJFMFNEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public OEBEDPEKDOH LADEKBPIHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public ALPHIOGOAKG CBNIFGHLDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint NFDPFFJIAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object DLAJMNPAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int DFGPNCEPDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError JCHMGCNIFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public OALAKALOGIP ANHIFPOBDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public BPPCEFHHOKP MKDFHGLBPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public HBBNONGBPCG KLJFJLAEIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte BDLKICEECFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly OEMFLKAHPPI DCOCMFBJKGM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E24AB0", Offset = "0x5E230B0", VA = "0x185E24AB0")]
	public JLNGJBAGDBG(EFONNIOJBCM FECFMDJKBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class EFONNIOJBCM : IEnumerable<ALPHIOGOAKG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class PKOJGMHGODO : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A390", Offset = "0x5E28990", VA = "0x185E2A390", Slot = "4")]
		public bool Equals(IPEndPoint OCPDJIJPMCG, IPEndPoint DEKMKLPIHFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5906160", Offset = "0x5904760", VA = "0x185906160", Slot = "5")]
		public int GetHashCode(IPEndPoint NJKKPOFFNNJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public PKOJGMHGODO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct LEFCPAKCGGB : IEnumerator<ALPHIOGOAKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly ALPHIOGOAKG FGFMCMECOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private ALPHIOGOAKG LOMKMEIGOAG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ALPHIOGOAKG FOBIFFPGMIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FA820", Offset = "0x8F8E20", VA = "0x1808FA820", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1116B90", Offset = "0x1115190", VA = "0x181116B90")]
		public LEFCPAKCGGB(ALPHIOGOAKG FFJDFAKILFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E266B0", Offset = "0x5E24CB0", VA = "0x185E266B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5E26700", Offset = "0x5E24D00", VA = "0x185E26700", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread BFDCCNKOIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool JPBGGMBBLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent EKOJGIALFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<JLNGJBAGDBG> ICJDMMBLHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<JLNGJBAGDBG> AJMMKMLFOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private JLNGJBAGDBG GNIPPHCFLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly ONNFBOPBOBC HLJOBPGDHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly AGMCBEJMOOL DAEMCLJNFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly KEBJBDLPILP POKIILDDCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly EAEFNHFKDKN MNLEEINDNBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, ALPHIOGOAKG> KDOAOGGHBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, BPPCEFHHOKP> DOIBDBPDGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, AOPLKDMEGGH> PCCHMBEFJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim JLKHOODGMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ALPHIOGOAKG CKGAIMJOEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int GHHKAIAGAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ALPHIOGOAKG> KEKDPACPELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private ALPHIOGOAKG[] LNJCHDNJJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly KAKDBJLMHMP GJLMAGJKNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int PACPDHJGFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> DBHLJBOBKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte AMCLBAAALJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object MEIJLEAHNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool LBKDJNONGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool INAHKIEDOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int JBHFLGOCPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int HLNBKACHBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int OKKGDOPDMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int GNBMIMDACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool EHEOMPPKNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FCFPAMPCNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int MNMILEIMDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int GOLALPMGBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int KPINKMNJGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool BEEJCBKFOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool BJADEBNNFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool FBKBGGNDHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KDJBIALLNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int JLLMPNLKHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int GLFNDOCNIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool OFDNADGNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly DCKCNBEIKGL GDAEBPBMGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool KHPDILOBEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly JNPHLJHPIIB OOPNEPBPDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool HGNBKKPEOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public DCCKNKNAEPO OAEHOAOONKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int IOKJICJLMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool PKNFNPHDBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FNFAJFABKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool KEHDHDCHJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FMCOENNHCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HHLBPPIMLPI DDDCMGFILJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int BJLHBCCDCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object ACOAOJPNDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HHLBPPIMLPI IHIKONBBFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int HGABHGOGCIG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int MFMOBJPDBNJ = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int LALEPBOJNDP = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KAHMIOHDPDJ CGIJNPECIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private KAHMIOHDPDJ ILEEAMKIBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread FIAJDPBPDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread MHIFHIIPHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint PDFOIDPMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint NBCFJFDPNJM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] EBBAKGFFFMD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] FJNFFMNEEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<GCEAEOLOKLD, IPEndPoint> GEEBLNGACFB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress IJDJLFAEABG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool GBIIOAMDMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int MFNEMPFFLIG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AIEOABNNLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xC0E0E0", Offset = "0xC0C6E0", VA = "0x180C0E0E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCBDED0", Offset = "0xCBC4D0", VA = "0x180CBDED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LDIIJNACNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x152FBE0", Offset = "0x152E1E0", VA = "0x18152FBE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x185BD90", Offset = "0x185A390", VA = "0x18185BD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte INCMDDBNLOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8ECC30", Offset = "0x8EB230", VA = "0x1808ECC30")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EJMBABKDCOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E20460", Offset = "0x5E1EA60", VA = "0x185E20460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short ALKENMHAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E207A0", Offset = "0x5E1EDA0", VA = "0x185E207A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F070", Offset = "0x5E1D670", VA = "0x185E1F070")]
	public void MFBCFIPDNGL(IPEndPoint IILILNHEHKN, byte[] IBBDLGCDELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DAC0", Offset = "0x5E1C0C0", VA = "0x185E1DAC0")]
	public void HGMBEPPHNMB(IPEndPoint IILILNHEHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E20E70", Offset = "0x5E1F470", VA = "0x185E20E70")]
	private bool PKHIKOBHLHH(IPEndPoint IILILNHEHKN, [Out] ALPHIOGOAKG BEDJFABJDIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F820", Offset = "0x5E1DE20", VA = "0x185E1F820")]
	private void MFKOFHBKNNL(ALPHIOGOAKG BEDJFABJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D4B0", Offset = "0x5E1BAB0", VA = "0x185E1D4B0")]
	private void EKGPEMLFLNO(ALPHIOGOAKG BEDJFABJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E20C20", Offset = "0x5E1F220", VA = "0x185E20C20")]
	private void PGPOMBENKOG(ALPHIOGOAKG BEDJFABJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5E22100", Offset = "0x5E20700", VA = "0x185E22100")]
	public EFONNIOJBCM(ONNFBOPBOBC MEDPKOGPCIJ, [Optional] KAKDBJLMHMP BHJIDJLOOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D460", Offset = "0x5E1BA60", VA = "0x185E1D460")]
	internal void EIPOPMNJAND(ALPHIOGOAKG EBLENBEDHJM, int FNBGLPJNIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FAE0", Offset = "0x5E1E0E0", VA = "0x185E1FAE0")]
	internal void MLCNFJJILBN(ALPHIOGOAKG EBLENBEDHJM, object KDFLHFONPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D730", Offset = "0x5E1BD30", VA = "0x185E1D730")]
	internal void FGKOMHIHFJJ(ALPHIOGOAKG BEDJFABJDIG, OALAKALOGIP GBNNAJEHACL, SocketError ILMDPCPALCA, HHLBPPIMLPI JICPEOGMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E580", Offset = "0x5E1CB80", VA = "0x185E1E580")]
	private void IHMLEPFEPBI(ALPHIOGOAKG BEDJFABJDIG, OALAKALOGIP GBNNAJEHACL, SocketError ILMDPCPALCA, bool LCIFANAPNML, byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int BMKFLHFENBJ, HHLBPPIMLPI JICPEOGMFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E20860", Offset = "0x5E1EE60", VA = "0x185E20860")]
	private void PFBNOGHFAJJ(JLNGJBAGDBG.OEBEDPEKDOH GOAECDHCJMK, [Optional] ALPHIOGOAKG BEDJFABJDIG, [Optional] IPEndPoint HENIIGIHEIF, SocketError LIFEOAGILNM = SocketError.Success, int FNBGLPJNIOO = 0, OALAKALOGIP AGGKFMOJGAF = OALAKALOGIP.ConnectionFailed, [Optional] BPPCEFHHOKP IGDEIMADNGI, HBBNONGBPCG DDHEDCNFABH = HBBNONGBPCG.Unreliable, byte HONJBGKAAKP = 0, [Optional] HHLBPPIMLPI EOHEFCFMFPL, [Optional] object KDFLHFONPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E21760", Offset = "0x5E1FD60", VA = "0x185E21760")]
	private void PPMFNMCLPFA(JLNGJBAGDBG DNLMIBJALAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DDB0", Offset = "0x5E1C3B0", VA = "0x185E1DDB0")]
	internal void IDKNMFNHGHM(JLNGJBAGDBG DNLMIBJALAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E20120", Offset = "0x5E1E720", VA = "0x185E20120")]
	private void NLIKEDJFJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E20480", Offset = "0x5E1EA80", VA = "0x185E20480")]
	private void OILJCEBKJLG(int FIIKHPOPBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DEB0", Offset = "0x5E1C4B0", VA = "0x185E1DEB0")]
	internal ALPHIOGOAKG IENHPJNDGLC(BPPCEFHHOKP EPDDNPCGMCI, byte[] PHDLIEJHFDE, int IJNJPAGKLKM, int JOCLJBACIHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B840", Offset = "0x5E19E40", VA = "0x185E1B840")]
	private int BCMOLOBDHEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C780", Offset = "0x5E1AD80", VA = "0x185E1C780")]
	private void CNOCMMICNPA(IPEndPoint HENIIGIHEIF, ALPHIOGOAKG JLHKPJMJFHC, KJDILBIOFIO DHJEIDIBEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B8C0", Offset = "0x5E19EC0", VA = "0x185E1B8C0")]
	private void BOAPIKGLING(HHLBPPIMLPI AJJDDDKMKDC, IPEndPoint HENIIGIHEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D800", Offset = "0x5E1BE00", VA = "0x185E1D800")]
	internal void GAGHGGIDPIN(HHLBPPIMLPI AJJDDDKMKDC, HBBNONGBPCG CJOHFIOMAAH, byte HONJBGKAAKP, int GPDOBLJLJBG, ALPHIOGOAKG EBLENBEDHJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E21750", Offset = "0x5E1FD50", VA = "0x185E21750")]
	public bool PNPOMLBEDFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E216B0", Offset = "0x5E1FCB0", VA = "0x185E216B0")]
	public bool PNPOMLBEDFL(IPAddress MNBMNKGGKIC, IPAddress LLHLFAFMEHC, int OJDLGPLPDJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5E216D0", Offset = "0x5E1FCD0", VA = "0x185E216D0")]
	public bool PNPOMLBEDFL(int OJDLGPLPDJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CBE0", Offset = "0x5E1B1E0", VA = "0x185E1CBE0")]
	public void DGMNNAELPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F370", Offset = "0x5E1D970", VA = "0x185E1F370")]
	public ALPHIOGOAKG MFJNCBLOCCB(string APCNIONLEEC, int OJDLGPLPDJG, string IBBDLGCDELM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F290", Offset = "0x5E1D890", VA = "0x185E1F290")]
	public ALPHIOGOAKG MFJNCBLOCCB(string APCNIONLEEC, int OJDLGPLPDJG, DDKJAJGINNB IDDPDBGPMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F450", Offset = "0x5E1DA50", VA = "0x185E1F450")]
	public ALPHIOGOAKG MFJNCBLOCCB(IPEndPoint PABFDMCLKCE, DDKJAJGINNB IDDPDBGPMGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F060", Offset = "0x5E1D660", VA = "0x185E1F060")]
	public void LDDBOACCGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ED10", Offset = "0x5E1D310", VA = "0x185E1ED10")]
	public void LDDBOACCGAJ(bool LCEHBJGMAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B740", Offset = "0x5E19D40", VA = "0x185E1B740")]
	public void ACIKLLNIDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B620", Offset = "0x5E19C20", VA = "0x185E1B620")]
	public void ACIKLLNIDCA(byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int BMKFLHFENBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E4D0", Offset = "0x5E1CAD0", VA = "0x185E1E4D0")]
	public void IHMLEPFEPBI(ALPHIOGOAKG BEDJFABJDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E660", Offset = "0x5E1CC60", VA = "0x185E1E660")]
	public void IHMLEPFEPBI(ALPHIOGOAKG BEDJFABJDIG, byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int BMKFLHFENBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E21F20", Offset = "0x5E20520", VA = "0x185E21F20", Slot = "4")]
	private IEnumerator<ALPHIOGOAKG> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E21FB0", Offset = "0x5E205B0", VA = "0x185E21FB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EAE0", Offset = "0x5E1D0E0", VA = "0x185E1EAE0")]
	private HHLBPPIMLPI JMEJECBJBLK(DEAOMKMABAO FDKAIMCLOIA, int LPKLLJKOBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EBD0", Offset = "0x5E1D1D0", VA = "0x185E1EBD0")]
	private HHLBPPIMLPI JMEJECBJBLK(DEAOMKMABAO FDKAIMCLOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D500", Offset = "0x5E1BB00", VA = "0x185E1D500")]
	internal HHLBPPIMLPI FDHDEHGKPCH(int LPKLLJKOBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FEC0", Offset = "0x5E1E4C0", VA = "0x185E1FEC0")]
	internal void NEJAEEMHOPH(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5E22040", Offset = "0x5E20640", VA = "0x185E22040")]
	static EFONNIOJBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC0E0E0", Offset = "0xC0C6E0", VA = "0x180C0E0E0")]
	private bool KEFAIPMPDDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E720", Offset = "0x5E1CD20", VA = "0x185E1E720")]
	private void ILBOLAAHPON(IPEndPoint LNHIACNPLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D380", Offset = "0x5E1B980", VA = "0x185E1D380")]
	private void EIOHGLIMJJP(IPEndPoint LNHIACNPLMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DC10", Offset = "0x5E1C210", VA = "0x185E1DC10")]
	private bool HLCHMAAPHGL(SocketException LPFKIAHEHEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E810", Offset = "0x5E1CE10", VA = "0x185E1E810")]
	private void JHMCLGLAGCA(KAHMIOHDPDJ DCEJINAEKKO, EndPoint ADFBFBPBIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FB30", Offset = "0x5E1E130", VA = "0x185E1FB30")]
	private void NCIDBHHPJOJ(object NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F00", Offset = "0x5E1F500", VA = "0x185E20F00")]
	public bool PNPOMLBEDFL(IPAddress MNBMNKGGKIC, IPAddress LLHLFAFMEHC, int OJDLGPLPDJG, bool NPBIDNOBFGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ECB0", Offset = "0x5E1D2B0", VA = "0x185E1ECB0")]
	internal int KDLFEFNDGMI(HHLBPPIMLPI AJJDDDKMKDC, IPEndPoint HENIIGIHEIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D340", Offset = "0x5E1B940", VA = "0x185E1D340")]
	internal int DHEDMAFAOPB(HHLBPPIMLPI AJJDDDKMKDC, IPEndPoint HENIIGIHEIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD80", Offset = "0x5E1B380", VA = "0x185E1CD80")]
	internal int DHEDMAFAOPB(byte[] ELIMFPDKMPD, int IJNJPAGKLKM, int JOCLJBACIHN, IPEndPoint HENIIGIHEIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C610", Offset = "0x5E1AC10", VA = "0x185E1C610")]
	internal void CHEABLAGPIJ(bool MCNMDEJOAAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum DEAOMKMABAO : byte
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
internal sealed class HHLBPPIMLPI
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int KOFPMOAMNBK;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] PMOIJJDKMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] PKKDDJCCIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int FPMEMCFLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object DLAJMNPAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public HHLBPPIMLPI OCFJFMFNEAC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DEAOMKMABAO LGPIJIKHBNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E244F0", Offset = "0x5E22AF0", VA = "0x185E244F0")]
		get
		{
			return default(DEAOMKMABAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E24520", Offset = "0x5E22B20", VA = "0x185E24520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte AAHDECIFPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E24620", Offset = "0x5E22C20", VA = "0x185E24620")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E24400", Offset = "0x5E22A00", VA = "0x185E24400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort LCIFKFMHCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E24030", Offset = "0x5E22630", VA = "0x185E24030")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E24480", Offset = "0x5E22A80", VA = "0x185E24480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JKEEGNICHNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E243D0", Offset = "0x5E229D0", VA = "0x185E243D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte IINBKIFBIJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E244C0", Offset = "0x5E22AC0", VA = "0x185E244C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E24100", Offset = "0x5E22700", VA = "0x185E24100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort FAPCLKMIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E24560", Offset = "0x5E22B60", VA = "0x185E24560")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E240C0", Offset = "0x5E226C0", VA = "0x185E240C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort EPAAHHLJING
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E24130", Offset = "0x5E22730", VA = "0x185E24130")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E24190", Offset = "0x5E22790", VA = "0x185E24190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort JLOGJDKAKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E245C0", Offset = "0x5E22BC0", VA = "0x185E245C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E24440", Offset = "0x5E22A40", VA = "0x185E24440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E24650", Offset = "0x5E22C50", VA = "0x185E24650")]
	static HHLBPPIMLPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E24090", Offset = "0x5E22690", VA = "0x185E24090")]
	public void FKLDFHDAKIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E24930", Offset = "0x5E22F30", VA = "0x185E24930")]
	public HHLBPPIMLPI(int LPKLLJKOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E249A0", Offset = "0x5E22FA0", VA = "0x185E249A0")]
	public HHLBPPIMLPI(DEAOMKMABAO FDKAIMCLOIA, int LPKLLJKOBNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E242D0", Offset = "0x5E228D0", VA = "0x185E242D0")]
	public static int JGMDBCCHPLC(DEAOMKMABAO FDKAIMCLOIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E24340", Offset = "0x5E22940", VA = "0x185E24340")]
	public int JGMDBCCHPLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E241D0", Offset = "0x5E227D0", VA = "0x185E241D0")]
	public bool JFPGGCKLBAG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum MAGPMIAIHKF : byte
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
internal enum BCKIANJNAPF
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
internal enum BKEFGPNMAMF
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum IODKPPBMFME
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ALPHIOGOAKG
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class GDNNEMBPGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HHLBPPIMLPI[] LBNFGMJALLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int LPAIGMFDCNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int DNLPKAECFJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte IINBKIFBIJL;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public GDNNEMBPGEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void LMHDNGGDJGK(ulong GIKGLFDMHHB, int HLINHHJEMEN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int EBCHNPFHAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int HCGJADGFHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int GDJNHGLBILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double NFFEHHLICMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int CGLPGCBAMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int MFOGEKBDDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int PLPMCBHCLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch JAFGDLDDJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int JPOPNFEMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long HEILAPOOCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object MBADLCEPEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal ALPHIOGOAKG FOCGNMNHGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal ALPHIOGOAKG MMFFAFCGCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<HHLBPPIMLPI> DMKNGBPMGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CPMINFKKDKF> OAKEHHKFPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CPMINFKKDKF[] LBJFCPHLNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int MOBMGCNLOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int MIMKHEBKNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool BEHJOPEBLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int NIBNMFFGNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int JGLNCAFFKHF;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int CBNNHOPOHNA = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int MEJFAJBHLOC = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object LFDADPNJBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int GKLBMOGOBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, GDNNEMBPGEM> NFNBGEBMCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> LIPALGENDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly HHLBPPIMLPI LEDBILBNEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int PBHBNNBDNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int FBAAACOEFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint MAINAMODGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int CAJLLLDBGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int CBHOILEGNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long KPDLIAMIAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte MMJDJPJNDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private MAGPMIAIHKF MIJJOOCNNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HHLBPPIMLPI BEHBPJILGNO;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int NCEIBNODFAJ = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int EKGOAOHNJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HHLBPPIMLPI PBNJGPEOADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HHLBPPIMLPI PJDLOCDILDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HHLBPPIMLPI HPNIKLLGIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HHLBPPIMLPI HHENOJFMFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private PBGCONOGDNJ DBPICLEDBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly EFONNIOJBCM DMBJHIGBADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int LAALHOAJCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object EJLKJGGGHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly DCKCNBEIKGL GDAEBPBMGPO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte FDNJFDMNDOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC51420", Offset = "0xC4FA20", VA = "0x180C51420")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E16D00", Offset = "0x5E15300", VA = "0x185E16D00")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint ALGJBAOBBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D20", Offset = "0x8F5320", VA = "0x1808F6D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MAGPMIAIHKF CGHJIIPDMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x13508E0", Offset = "0x134EEE0", VA = "0x1813508E0")]
		get
		{
			return default(MAGPMIAIHKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long AODIPCJLEMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x870BF0", Offset = "0x86F1F0", VA = "0x180870BF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int AHKMBAEEAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xD21820", Offset = "0xD1FE20", VA = "0x180D21820")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x161EE00", Offset = "0x161D400", VA = "0x18161EE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LEJGLPGLGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E16A00", Offset = "0x5E15000", VA = "0x185E16A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int CJDNEBOBLLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8764A0", Offset = "0x874AA0", VA = "0x1808764A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double NDGMBIFDNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1AB8A90", Offset = "0x1AB7090", VA = "0x181AB8A90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LMHDNGGDJGK KAMHNDFKDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E13D30", Offset = "0x5E12330", VA = "0x185E13D30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E13C80", Offset = "0x5E12280", VA = "0x185E13C80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E17520", Offset = "0x5E15B20", VA = "0x185E17520")]
	internal ALPHIOGOAKG(EFONNIOJBCM CNPEFDMLDFP, IPEndPoint HENIIGIHEIF, int DAIJJLLIENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E13A60", Offset = "0x5E12060", VA = "0x185E13A60")]
	internal void ANLIOAKHHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E16100", Offset = "0x5E14700", VA = "0x185E16100")]
	internal void LGDIPGNHJKH(IPEndPoint BPHABHICHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E143B0", Offset = "0x5E129B0", VA = "0x185E143B0")]
	internal void HAHBJKLACFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E14E30", Offset = "0x5E13430", VA = "0x185E14E30")]
	private void JCLLCCLIMAE(int JGDKOAPLGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E160C0", Offset = "0x5E146C0", VA = "0x185E160C0")]
	private void LGDDHDCCDCB(int BGAKBOFJHOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E14440", Offset = "0x5E12A40", VA = "0x185E14440")]
	private CPMINFKKDKF HECCCJKMDJN(byte EAHBLIIOOON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E17390", Offset = "0x5E15990", VA = "0x185E17390")]
	internal ALPHIOGOAKG(EFONNIOJBCM CNPEFDMLDFP, IPEndPoint HENIIGIHEIF, int DAIJJLLIENA, byte BNFKNJBHGAM, DDKJAJGINNB JGFBADMCPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E17980", Offset = "0x5E15F80", VA = "0x185E17980")]
	internal ALPHIOGOAKG(EFONNIOJBCM CNPEFDMLDFP, BPPCEFHHOKP EPDDNPCGMCI, int DAIJJLLIENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E17340", Offset = "0x5E15940", VA = "0x185E17340")]
	internal void PLOBPJECMMB(KJDILBIOFIO GHKEBIBJJAF, byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E14650", Offset = "0x5E12C50", VA = "0x185E14650")]
	internal bool IDFBCCCIPKD(MHDDNDCICEH AJJDDDKMKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E17310", Offset = "0x5E15910", VA = "0x185E17310")]
	public void OPHEFDNPNLG(byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int JOCLJBACIHN, HBBNONGBPCG EFDCDFNAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E16130", Offset = "0x5E14730", VA = "0x185E16130")]
	private void LKHFIIBAIBD(byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int JOCLJBACIHN, byte HONJBGKAAKP, HBBNONGBPCG DDHEDCNFABH, object KDFLHFONPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E146D0", Offset = "0x5E12CD0", VA = "0x185E146D0")]
	public void IGKEHOJEPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E13980", Offset = "0x5E11F80", VA = "0x185E13980")]
	internal BKEFGPNMAMF ADLEOOMIJBP(HHLBPPIMLPI AJJDDDKMKDC)
	{
		return default(BKEFGPNMAMF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E145F0", Offset = "0x5E12BF0", VA = "0x185E145F0")]
	internal void HFFLOHGLOCG(CPMINFKKDKF CKEKDMBNEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E13DE0", Offset = "0x5E123E0", VA = "0x185E13DE0")]
	internal IODKPPBMFME FBDKMIHMJFG(byte[] MMDLBEBNCGC, int IJNJPAGKLKM, int JOCLJBACIHN, bool LCIFANAPNML)
	{
		return default(IODKPPBMFME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E13A80", Offset = "0x5E12080", VA = "0x185E13A80")]
	private void BPKCOKEIIJO(int JGEECFHEIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E15720", Offset = "0x5E13D20", VA = "0x185E15720")]
	internal void KDHAOMPMAEA(HBBNONGBPCG CJOHFIOMAAH, HHLBPPIMLPI FFJDFAKILFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E16DB0", Offset = "0x5E153B0", VA = "0x185E16DB0")]
	private void NMJEDPGOKHK(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E16680", Offset = "0x5E14C80", VA = "0x185E16680")]
	private void MEBDAJHKKPI(int JOOMCFPDCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E13AC0", Offset = "0x5E120C0", VA = "0x185E13AC0")]
	internal BCKIANJNAPF CNOCMMICNPA(KJDILBIOFIO DHJEIDIBEDL)
	{
		return default(BCKIANJNAPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E14780", Offset = "0x5E12D80", VA = "0x185E14780")]
	internal void JCFPDGFBJDM(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E16A10", Offset = "0x5E15010", VA = "0x185E16A10")]
	private void NLGHJFDPDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E16B30", Offset = "0x5E15130", VA = "0x185E16B30")]
	internal void NLMPIHCMDDJ(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E14F00", Offset = "0x5E13500", VA = "0x185E14F00")]
	internal void JPIODFAGAAF(int JOOMCFPDCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E140F0", Offset = "0x5E126F0", VA = "0x185E140F0")]
	internal void GGNFNHCICBI(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DCKCNBEIKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long NFBAOFCMLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long NHCFNCPNCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long PKEMMDKOFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long EPOJGEAOFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long PMFCAHEDMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private long GADKEBJOJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private long GIPDBFNCOPB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FEDGDLNNPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E19C10", Offset = "0x5E18210", VA = "0x185E19C10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long CHNHBMGFGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E19C40", Offset = "0x5E18240", VA = "0x185E19C40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LKPLBNOAHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E19B00", Offset = "0x5E18100", VA = "0x185E19B00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long NGDIDGFKKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E199C0", Offset = "0x5E17FC0", VA = "0x185E199C0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long BKPKCBHBIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E19C20", Offset = "0x5E18220", VA = "0x185E19C20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long CCGMMAGKDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E199D0", Offset = "0x5E17FD0", VA = "0x185E199D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private PBGCONOGDNJ GBLFGAJIMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E19C30", Offset = "0x5E18230", VA = "0x185E19C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double KEPECLGBIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E19AA0", Offset = "0x5E180A0", VA = "0x185E19AA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E19BB0", Offset = "0x5E181B0", VA = "0x185E19BB0")]
	public void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E19A00", Offset = "0x5E18000", VA = "0x185E19A00")]
	public void GLDGGMEKNLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E199E0", Offset = "0x5E17FE0", VA = "0x185E199E0")]
	public void GFGPALHHJOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E199F0", Offset = "0x5E17FF0", VA = "0x185E199F0")]
	public void GIDPFCCEFBM(long KPIAIPFCLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E199B0", Offset = "0x5E17FB0", VA = "0x185E199B0")]
	public void BLHMKOEMDIH(long BAGKJIGNPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E19A30", Offset = "0x5E18030", VA = "0x185E19A30")]
	public void IJBEADKKCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E19A60", Offset = "0x5E18060", VA = "0x185E19A60")]
	public void IJMGHDOPMII(long JAMHPILDJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E19C50", Offset = "0x5E18250", VA = "0x185E19C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E19B10", Offset = "0x5E18110", VA = "0x185E19B10")]
	public void LHIHNCFOPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DCKCNBEIKGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class NPOGPDMHDKD
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly List<string> OBJDGNNGCPN;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E29B50", Offset = "0x5E28150", VA = "0x185E29B50")]
	public static IPEndPoint GGDBNENIBGB(string COFAFKPJOJM, int OJDLGPLPDJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E29E30", Offset = "0x5E28430", VA = "0x185E29E30")]
	public static IPAddress IMIHCNICCJC(string COFAFKPJOJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E29DA0", Offset = "0x5E283A0", VA = "0x185E29DA0")]
	public static IPAddress IMIHCNICCJC(string COFAFKPJOJM, AddressFamily AHOECLBLDBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A000", Offset = "0x5E28600", VA = "0x185E2A000")]
	internal static int OBHAOMEOFDB(int JOEFNKAEKFJ, int INLDAGLPLLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2CDB680", Offset = "0x2CD9C80", VA = "0x182CDB680")]
	internal static T[] AFOIDJOFPMM<T>(int BMKFLHFENBJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class BNCABCFJGDI : CPMINFKKDKF
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct BLPBLDDPHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private HHLBPPIMLPI JJKJJIMOEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private long AKNBKKGPAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private bool KCHBJGBFPIG;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E18540", Offset = "0x5E16B40", VA = "0x185E18540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E18460", Offset = "0x5E16A60", VA = "0x185E18460")]
		public void ADKLMMLJNNJ(HHLBPPIMLPI AJJDDDKMKDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E184D0", Offset = "0x5E16AD0", VA = "0x185E184D0")]
		public bool NOKFNKKOFAO(long GDHFBKFAMIC, ALPHIOGOAKG BEDJFABJDIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E18480", Offset = "0x5E16A80", VA = "0x185E18480")]
		public bool DMCFOMNOLLC(ALPHIOGOAKG BEDJFABJDIG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private readonly HHLBPPIMLPI FJLGDPFLJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly BLPBLDDPHOP[] BLENKIOBOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly HHLBPPIMLPI[] PCPGNFBMAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly bool[] NJAJMJNGIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int MMPIMFDLGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int NCJFAPOOLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int IGDGPOOFEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int MBOBNBGJPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private bool MDEGNPICMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly HBBNONGBPCG ECIBKHAILCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly bool CPDDLEGJKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly int BHOEHNKPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly byte KLAJLHLIJHP;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E194B0", Offset = "0x5E17AB0", VA = "0x185E194B0")]
	public BNCABCFJGDI(ALPHIOGOAKG BEDJFABJDIG, bool MLHKMGKFDHH, byte DAIJJLLIENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E190F0", Offset = "0x5E176F0", VA = "0x185E190F0")]
	private void PGDFCLBPAEH(HHLBPPIMLPI AJJDDDKMKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E185E0", Offset = "0x5E16BE0", VA = "0x185E185E0", Slot = "4")]
	protected override bool DGKKCCAALKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E18A90", Offset = "0x5E17090", VA = "0x185E18A90", Slot = "5")]
	public override bool JCFPDGFBJDM(HHLBPPIMLPI AJJDDDKMKDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class HDKEEKPJMCA : CPMINFKKDKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int ABIANGPKHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ushort NCJFAPOOLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly bool PMMHGCJMKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private HHLBPPIMLPI CDODAAHHBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly HHLBPPIMLPI BMNIJCLCOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool CGOEMIKEIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly byte KLAJLHLIJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private long DPJEBACNPME;

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5E23F70", Offset = "0x5E22570", VA = "0x185E23F70")]
	public HDKEEKPJMCA(ALPHIOGOAKG BEDJFABJDIG, bool KBLEMKGKIEP, byte DAIJJLLIENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5E237C0", Offset = "0x5E21DC0", VA = "0x185E237C0", Slot = "4")]
	protected override bool DGKKCCAALKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5E23C60", Offset = "0x5E22260", VA = "0x185E23C60", Slot = "5")]
	public override bool JCFPDGFBJDM(HHLBPPIMLPI AJJDDDKMKDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class PKBIGLHKOMJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct DBLDALHFPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public ulong GIACPDABICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public double CHKHPGOMAON;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct NDFAAHGNIMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int LIINKIEBLAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float LGMDPOPKELF;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5E137F0", Offset = "0x5E11DF0", VA = "0x185E137F0")]
	private static void DIGOJKBACNL(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, ulong MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A270", Offset = "0x5E28870", VA = "0x185E2A270")]
	private static void DIGOJKBACNL(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A230", Offset = "0x5E28830", VA = "0x185E2A230")]
	public static void DIGOJKBACNL(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, short MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A2F0", Offset = "0x5E288F0", VA = "0x185E2A2F0")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, double DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A310", Offset = "0x5E28910", VA = "0x185E2A310")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A230", Offset = "0x5E28830", VA = "0x185E2A230")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, short DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A230", Offset = "0x5E28830", VA = "0x185E2A230")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, ushort DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A270", Offset = "0x5E28870", VA = "0x185E2A270")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A270", Offset = "0x5E28870", VA = "0x185E2A270")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, uint DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A2E0", Offset = "0x5E288E0", VA = "0x185E2A2E0")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, long DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A2E0", Offset = "0x5E288E0", VA = "0x185E2A2E0")]
	public static void NAFACCBIFJG(byte[] LKFNEINGOFE, int CMKHMGALFJE, ulong DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JOMEGECCBCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	protected byte[] HCGFEAPJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	protected int HNAHNLHOLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected int DFFNLCAMGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private int PLPLKDLELFN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public byte[] PKKDDJCCIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int JFFJMCACMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OKHBHEDMOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5E25E90", Offset = "0x5E24490", VA = "0x185E25E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool MMOMPNFLPAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1EFDDE0", Offset = "0x1EFC3E0", VA = "0x181EFDDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int OOGKJMHGAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5E256F0", Offset = "0x5E23CF0", VA = "0x185E256F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5E25A50", Offset = "0x5E24050", VA = "0x185E25A50")]
	public void FBIFFGDPCBH(byte[] MADFKNCBFBG, int GCMGLJCEDLO, int EABAAOKKDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public JOMEGECCBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E26180", Offset = "0x5E24780", VA = "0x185E26180")]
	public JOMEGECCBCE(byte[] MADFKNCBFBG, int GCMGLJCEDLO, int EABAAOKKDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E260B0", Offset = "0x5E246B0", VA = "0x185E260B0")]
	public IPEndPoint PJIIIGDLOHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E25DA0", Offset = "0x5E243A0", VA = "0x185E25DA0")]
	public byte JMAGIBANNMJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E25DA0", Offset = "0x5E243A0", VA = "0x185E25DA0")]
	public sbyte OGNOKLMHADL()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2C07A60", Offset = "0x2C06060", VA = "0x182C07A60")]
	public T[] LHBBBOIMMFI<T>(ushort LPKLLJKOBNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E25D20", Offset = "0x5E24320", VA = "0x185E25D20")]
	public bool[] JIGPLFAJDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E25D60", Offset = "0x5E24360", VA = "0x185E25D60")]
	public ushort[] JKCFFPPIPKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E25700", Offset = "0x5E23D00", VA = "0x185E25700")]
	public short[] DBLNKJFMKNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E255D0", Offset = "0x5E23BD0", VA = "0x185E255D0")]
	public int[] BDAEFDEAKNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E25590", Offset = "0x5E23B90", VA = "0x185E25590")]
	public uint[] BCOIGGCDIJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5E25BB0", Offset = "0x5E241B0", VA = "0x185E25BB0")]
	public float[] IBCEGHFIKPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E26070", Offset = "0x5E24670", VA = "0x185E26070")]
	public double[] PEPNGKBOMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E257D0", Offset = "0x5E23DD0", VA = "0x185E257D0")]
	public long[] EDJANCBNINH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E25EE0", Offset = "0x5E244E0", VA = "0x185E25EE0")]
	public ulong[] NADAEBDBDJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E25BF0", Offset = "0x5E241F0", VA = "0x185E25BF0")]
	public string[] IJGAGOMFFIP(int MBDFHOGFFJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E25B70", Offset = "0x5E24170", VA = "0x185E25B70")]
	public bool HEPOCFANADF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5E25610", Offset = "0x5E23C10", VA = "0x185E25610")]
	public char LEKCGILIKIJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E25610", Offset = "0x5E23C10", VA = "0x185E25610")]
	public ushort BDBBEAFAAOB()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5E25680", Offset = "0x5E23C80", VA = "0x185E25680")]
	public short CGCGNFJMHDL()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5E25F20", Offset = "0x5E24520", VA = "0x185E25F20")]
	public long NGHMPNLNNFF()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5E25F90", Offset = "0x5E24590", VA = "0x185E25F90")]
	public ulong NIDDJIHLDJB()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5E25B00", Offset = "0x5E24100", VA = "0x185E25B00")]
	public int FLCOCKJPBFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5E25E20", Offset = "0x5E24420", VA = "0x185E25E20")]
	public uint MBIDLOGBGOF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E26000", Offset = "0x5E24600", VA = "0x185E26000")]
	public float PEPKEKEHLDH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5E25740", Offset = "0x5E23D40", VA = "0x185E25740")]
	public double DIOAPDMFAPG()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E25810", Offset = "0x5E23E10", VA = "0x185E25810")]
	public string EHMBEGDNCMM(int LANOKLGBLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5E25A90", Offset = "0x5E24090", VA = "0x185E25A90")]
	public ArraySegment<byte> FJMNLLBNNGA(int BMKFLHFENBJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5E25EA0", Offset = "0x5E244A0", VA = "0x185E25EA0")]
	public sbyte[] MHDHKLHGGDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5E25DE0", Offset = "0x5E243E0", VA = "0x185E25DE0")]
	public byte[] KIJOILFPFIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5E257B0", Offset = "0x5E23DB0", VA = "0x185E257B0")]
	public void DMCFOMNOLLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DDKJAJGINNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	protected byte[] HCGFEAPJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected int HNAHNLHOLGK;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int MBFIPDGAFOC = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly bool DCDAIKMFMLC;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public static readonly UTF8Encoding HAMIKEPKLIO;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public const int IJGCEGMOABC = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly byte[] IJOJPDIMBFC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] GDPGJFHLHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int LBEGGACHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86C7E0", Offset = "0x86ADE0", VA = "0x18086C7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AD80", Offset = "0x5E19380", VA = "0x185E1AD80")]
	public DDKJAJGINNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ACE0", Offset = "0x5E192E0", VA = "0x185E1ACE0")]
	public DDKJAJGINNB(bool HJLBECNMNML, int PCGKLEANFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AB40", Offset = "0x5E19140", VA = "0x185E1AB40")]
	public static DDKJAJGINNB JPHDNGHLCEG(string DMNGPNKHPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ABB0", Offset = "0x5E191B0", VA = "0x185E1ABB0")]
	public void NKPBFHOGOJC(int LKKFDNJMGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1F77C20", Offset = "0x1F76220", VA = "0x181F77C20")]
	public void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A4E0", Offset = "0x5E18AE0", VA = "0x185E1A4E0")]
	public void HCMEPBBIOPP(float DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A090", Offset = "0x5E18690", VA = "0x185E1A090")]
	public void HCMEPBBIOPP(double DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A420", Offset = "0x5E18A20", VA = "0x185E1A420")]
	public void HCMEPBBIOPP(long DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A420", Offset = "0x5E18A20", VA = "0x185E1A420")]
	public void HCMEPBBIOPP(ulong DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A580", Offset = "0x5E18B80", VA = "0x185E1A580")]
	public void HCMEPBBIOPP(int DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A580", Offset = "0x5E18B80", VA = "0x185E1A580")]
	public void HCMEPBBIOPP(uint DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5E19FC0", Offset = "0x5E185C0", VA = "0x185E19FC0")]
	public void HCMEPBBIOPP(char DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5E19FC0", Offset = "0x5E185C0", VA = "0x185E19FC0")]
	public void HCMEPBBIOPP(ushort DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5E19FC0", Offset = "0x5E185C0", VA = "0x185E19FC0")]
	public void HCMEPBBIOPP(short DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A030", Offset = "0x5E18630", VA = "0x185E1A030")]
	public void HCMEPBBIOPP(sbyte DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A030", Offset = "0x5E18630", VA = "0x185E1A030")]
	public void HCMEPBBIOPP(byte DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A470", Offset = "0x5E18A70", VA = "0x185E1A470")]
	public void HCMEPBBIOPP(byte[] MMDLBEBNCGC, int GCMGLJCEDLO, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A990", Offset = "0x5E18F90", VA = "0x185E1A990")]
	public void OBGJNOLICFB(sbyte[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A990", Offset = "0x5E18F90", VA = "0x185E1A990")]
	public void PMHIBMPEKFJ(byte[] MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A2F0", Offset = "0x5E188F0", VA = "0x185E1A2F0")]
	public void HCMEPBBIOPP(bool DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A8B0", Offset = "0x5E18EB0", VA = "0x185E1A8B0")]
	public void HGAMOCICFNH(Array LGAGNKBKBAA, int EBGKEBAHFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A7D0", Offset = "0x5E18DD0", VA = "0x185E1A7D0")]
	public void HGAMOCICFNH(float[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A610", Offset = "0x5E18C10", VA = "0x185E1A610")]
	public void HGAMOCICFNH(double[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A610", Offset = "0x5E18C10", VA = "0x185E1A610")]
	public void HGAMOCICFNH(long[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A610", Offset = "0x5E18C10", VA = "0x185E1A610")]
	public void HGAMOCICFNH(ulong[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A7D0", Offset = "0x5E18DD0", VA = "0x185E1A7D0")]
	public void HGAMOCICFNH(int[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A7D0", Offset = "0x5E18DD0", VA = "0x185E1A7D0")]
	public void HGAMOCICFNH(uint[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A6F0", Offset = "0x5E18CF0", VA = "0x185E1A6F0")]
	public void HGAMOCICFNH(ushort[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A6F0", Offset = "0x5E18CF0", VA = "0x185E1A6F0")]
	public void HGAMOCICFNH(short[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A990", Offset = "0x5E18F90", VA = "0x185E1A990")]
	public void HGAMOCICFNH(bool[] DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AA70", Offset = "0x5E19070", VA = "0x185E1AA70")]
	public void HGAMOCICFNH(string[] DMNGPNKHPKF, int MADGKGPJBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A350", Offset = "0x5E18950", VA = "0x185E1A350")]
	public void HCMEPBBIOPP(IPEndPoint IILILNHEHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5E19FB0", Offset = "0x5E185B0", VA = "0x185E19FB0")]
	public void HCMEPBBIOPP(string DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A0E0", Offset = "0x5E186E0", VA = "0x185E1A0E0")]
	public void HCMEPBBIOPP(string DMNGPNKHPKF, int LANOKLGBLAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class EPPGCFAIPCA
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class DNECPGCKGJC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ulong LAALHOAJCIA;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x58E2E30", Offset = "0x58E1430", VA = "0x1858E2E30")]
		static DNECPGCKGJC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void OMOIPAEALCA(JOMEGECCBCE MMDEOFGAFEK, object KDFLHFONPJE);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class LLFJAAEEHLL<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public EPPGCFAIPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public LLFJAAEEHLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x42E6520", Offset = "0x42E4B20", VA = "0x1842E6520")]
		internal void JDBOPIOALEH(JOMEGECCBCE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class PJOMCLBHALN<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public EPPGCFAIPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public PJOMCLBHALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47F8640", Offset = "0x47F6C40", VA = "0x1847F8640")]
		internal void JDBOPIOALEH(JOMEGECCBCE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private readonly AGBFAHJJDHM IHJFHMHKLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly Dictionary<ulong, OMOIPAEALCA> OKPHGACGAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly DDKJAJGINNB MMCANFPHKGA;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E22950", Offset = "0x5E20F50", VA = "0x185E22950")]
	public EPPGCFAIPCA(int MBDFHOGFFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x293CD70", Offset = "0x293B370", VA = "0x18293CD70", Slot = "4")]
	protected virtual ulong BDMFLIFKCGI<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5E227A0", Offset = "0x5E20DA0", VA = "0x185E227A0", Slot = "5")]
	protected virtual OMOIPAEALCA MHKOICNOJIF(JOMEGECCBCE MMDEOFGAFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2A40B90", Offset = "0x2A3F190", VA = "0x182A40B90", Slot = "6")]
	protected virtual void CIINHADIAKH<T>(DDKJAJGINNB JFIDOOOHFIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E228D0", Offset = "0x5E20ED0", VA = "0x185E228D0")]
	public void OLFKBLOMBGM(JOMEGECCBCE MMDEOFGAFEK, object KDFLHFONPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x2A40C00", Offset = "0x2A3F200", VA = "0x182A40C00")]
	public void GDIEAOLABBA<T>(DDKJAJGINNB JFIDOOOHFIL, T AJJDDDKMKDC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5E22750", Offset = "0x5E20D50", VA = "0x185E22750")]
	public void AINKOKFJPKL(JOMEGECCBCE MMDEOFGAFEK, object KDFLHFONPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2A40E70", Offset = "0x2A3F470", VA = "0x182A40E70")]
	public void LLKLDBIJKBM<T>(Action<T> OIKFIBKMPCL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A40CB0", Offset = "0x2A3F2B0", VA = "0x182A40CB0")]
	public void LLKLDBIJKBM<T, TUserData>(Action<T, TUserData> OIKFIBKMPCL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class HFJJBLNJCCG : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E197E0", Offset = "0x5E17DE0", VA = "0x185E197E0")]
	public HFJJBLNJCCG(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class NMOIMCKINBA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E29AF0", Offset = "0x5E280F0", VA = "0x185E29AF0")]
	public NMOIMCKINBA(string ELIMFPDKMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class AGBFAHJJDHM
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum EPGKJJJDLEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class NNJCNFHCCBH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public EPGKJJJDLEP LADEKBPIHJB;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x45DA780", Offset = "0x45D8D80", VA = "0x1845DA780", Slot = "4")]
		public virtual void ADKLMMLJNNJ(MethodInfo EIMKAAGFKJP, MethodInfo OICMHNJLDAN, EPGKJJJDLEP GOAECDHCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ);

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void OLJMJIJKKHD(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void LKPEEGCFDML(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		protected NNJCNFHCCBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class DMIPNEHBFDP<TClass, TProperty> : NNJCNFHCCBH<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected Func<TClass, TProperty> AAMJPCANJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected Action<TClass, TProperty> JPHKFPOHBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected Func<TClass, TProperty[]> BLEEHEOOFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected Action<TClass, TProperty[]> FBCCBJFENPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		protected Func<TClass, List<TProperty>> MGPAKALHANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Action<TClass, List<TProperty>> CBADMBPBKFD;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x58DCB30", Offset = "0x58DB130", VA = "0x1858DCB30", Slot = "7")]
		public override void NPKHGHMBNGN(TClass BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x58DE8F0", Offset = "0x58DCEF0", VA = "0x1858DE8F0", Slot = "8")]
		public override void PJCNGJOOLLA(TClass BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x58DD930", Offset = "0x58DBF30", VA = "0x1858DD930", Slot = "9")]
		public override void OLJMJIJKKHD(TClass BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x58DC270", Offset = "0x58DA870", VA = "0x1858DC270", Slot = "10")]
		public override void LKPEEGCFDML(TClass BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x58DBC20", Offset = "0x58DA220", VA = "0x1858DBC20")]
		protected TProperty[] JKDDFKGGLOC(TClass BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x58DBBA0", Offset = "0x58DA1A0", VA = "0x1858DBBA0")]
		protected TProperty[] AIGKADPMHHC(TClass BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x58DA460", Offset = "0x58D8A60", VA = "0x1858DA460", Slot = "4")]
		public override void ADKLMMLJNNJ(MethodInfo EIMKAAGFKJP, MethodInfo OICMHNJLDAN, EPGKJJJDLEP GOAECDHCJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x42BDF40", Offset = "0x42BC540", VA = "0x1842BDF40")]
		protected DMIPNEHBFDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class HHHALONENMA<TClass, TProperty> : DMIPNEHBFDP<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void MAAANNBDHJO(JOMEGECCBCE JPKMILJIBCP, [Out] TProperty AELLJGLCMFB);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void AJAJJBIGENP(DDKJAJGINNB BLGAJFHCFEJ, TProperty AELLJGLCMFB);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2140", Offset = "0x3DA0740", VA = "0x183DA2140", Slot = "5")]
		public override void BBNLCCNAPGE(TClass BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2280", Offset = "0x3DA0880", VA = "0x183DA2280", Slot = "6")]
		public override void GDIEAOLABBA(TClass BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3DA2460", Offset = "0x3DA0A60", VA = "0x183DA2460", Slot = "7")]
		public override void NPKHGHMBNGN(TClass BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3DA25E0", Offset = "0x3DA0BE0", VA = "0x183DA25E0", Slot = "8")]
		public override void PJCNGJOOLLA(TClass BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3DA26A0", Offset = "0x3DA0CA0", VA = "0x183DA26A0")]
		protected HHHALONENMA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class JLBJBPFAKDN<T> : DMIPNEHBFDP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x409B320", Offset = "0x4099920", VA = "0x18409B320", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x409B3A0", Offset = "0x40999A0", VA = "0x18409B3A0", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x409B410", Offset = "0x4099A10", VA = "0x18409B410", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C14A20", Offset = "0x3C13020", VA = "0x183C14A20", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public JLBJBPFAKDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class MJFJOOPEIEA<T> : DMIPNEHBFDP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x44D1430", Offset = "0x44CFA30", VA = "0x1844D1430", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x409B3A0", Offset = "0x40999A0", VA = "0x18409B3A0", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x44D14B0", Offset = "0x44CFAB0", VA = "0x1844D14B0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C14A20", Offset = "0x3C13020", VA = "0x183C14A20", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public MJFJOOPEIEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class IAJEEPBLDKM<T> : DMIPNEHBFDP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3E497C0", Offset = "0x3E47DC0", VA = "0x183E497C0", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3E49840", Offset = "0x3E47E40", VA = "0x183E49840", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3E498B0", Offset = "0x3E47EB0", VA = "0x183E498B0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3E49930", Offset = "0x3E47F30", VA = "0x183E49930", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public IAJEEPBLDKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class IDGBPEKFDEC<T> : DMIPNEHBFDP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3E59C90", Offset = "0x3E58290", VA = "0x183E59C90", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3E49840", Offset = "0x3E47E40", VA = "0x183E49840", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3E59D10", Offset = "0x3E58310", VA = "0x183E59D10", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3E49930", Offset = "0x3E47F30", VA = "0x183E49930", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public IDGBPEKFDEC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MKIHOOFJEGI<T> : DMIPNEHBFDP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x44D9160", Offset = "0x44D7760", VA = "0x1844D9160", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x41B5190", Offset = "0x41B3790", VA = "0x1841B5190", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x44D91E0", Offset = "0x44D77E0", VA = "0x1844D91E0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x41B5280", Offset = "0x41B3880", VA = "0x1841B5280", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public MKIHOOFJEGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class KIDMJGIONJA<T> : DMIPNEHBFDP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x41B5110", Offset = "0x41B3710", VA = "0x1841B5110", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x41B5190", Offset = "0x41B3790", VA = "0x1841B5190", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x41B5200", Offset = "0x41B3800", VA = "0x1841B5200", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x41B5280", Offset = "0x41B3880", VA = "0x1841B5280", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public KIDMJGIONJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class EKJGBCLMPFJ<T> : DMIPNEHBFDP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3880F80", Offset = "0x387F580", VA = "0x183880F80", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3881000", Offset = "0x387F600", VA = "0x183881000", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3881070", Offset = "0x387F670", VA = "0x183881070", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x38810F0", Offset = "0x387F6F0", VA = "0x1838810F0", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public EKJGBCLMPFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class GKCLKDOCOJN<T> : DMIPNEHBFDP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3880F80", Offset = "0x387F580", VA = "0x183880F80", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3881000", Offset = "0x387F600", VA = "0x183881000", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D34FB0", Offset = "0x3D335B0", VA = "0x183D34FB0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x38810F0", Offset = "0x387F6F0", VA = "0x1838810F0", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public GKCLKDOCOJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FFHAANIHFAI<T> : DMIPNEHBFDP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C148B0", Offset = "0x3C12EB0", VA = "0x183C148B0", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C14930", Offset = "0x3C12F30", VA = "0x183C14930", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C149A0", Offset = "0x3C12FA0", VA = "0x183C149A0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C14A20", Offset = "0x3C13020", VA = "0x183C14A20", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public FFHAANIHFAI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class PPCAOOKBOMF<T> : DMIPNEHBFDP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x48043B0", Offset = "0x48029B0", VA = "0x1848043B0", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4804430", Offset = "0x4802A30", VA = "0x184804430", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x48044A0", Offset = "0x4802AA0", VA = "0x1848044A0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x41B5280", Offset = "0x41B3880", VA = "0x1841B5280", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public PPCAOOKBOMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CNEGLDMEHCF<T> : DMIPNEHBFDP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x55A9FD0", Offset = "0x55A85D0", VA = "0x1855A9FD0", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x55AA050", Offset = "0x55A8650", VA = "0x1855AA050", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x55AA0C0", Offset = "0x55A86C0", VA = "0x1855AA0C0", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x38810F0", Offset = "0x387F6F0", VA = "0x1838810F0", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3881160", Offset = "0x387F760", VA = "0x183881160")]
		public CNEGLDMEHCF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class GEMKNMCHONK<T> : HHHALONENMA<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D09FD0", Offset = "0x3D085D0", VA = "0x183D09FD0", Slot = "12")]
		protected override void AJAJJBIGENP(DDKJAJGINNB BLGAJFHCFEJ, char AELLJGLCMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0A000", Offset = "0x3D08600", VA = "0x183D0A000", Slot = "11")]
		protected override void MAAANNBDHJO(JOMEGECCBCE JPKMILJIBCP, [Out] char AELLJGLCMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x385C2B0", Offset = "0x385A8B0", VA = "0x18385C2B0")]
		public GEMKNMCHONK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class OLBHNIEIPCM<T> : HHHALONENMA<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x46E5150", Offset = "0x46E3750", VA = "0x1846E5150", Slot = "12")]
		protected override void AJAJJBIGENP(DDKJAJGINNB BLGAJFHCFEJ, IPEndPoint AELLJGLCMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x46E5180", Offset = "0x46E3780", VA = "0x1846E5180", Slot = "11")]
		protected override void MAAANNBDHJO(JOMEGECCBCE JPKMILJIBCP, [Out] IPEndPoint AELLJGLCMFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x385C2B0", Offset = "0x385A8B0", VA = "0x18385C2B0")]
		public OLBHNIEIPCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class BDJPGBECMBK<T> : DMIPNEHBFDP<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private readonly int IMIPICOOIDD;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5F50", Offset = "0x4EC4550", VA = "0x184EC5F50")]
		public BDJPGBECMBK(int LANOKLGBLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5D50", Offset = "0x4EC4350", VA = "0x184EC5D50", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5DD0", Offset = "0x4EC43D0", VA = "0x184EC5DD0", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5E50", Offset = "0x4EC4450", VA = "0x184EC5E50", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5ED0", Offset = "0x4EC44D0", VA = "0x184EC5ED0", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class KENBPHGEGHC<T> : NNJCNFHCCBH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected readonly PropertyInfo LGPIJIKHBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected readonly Type BLCLJKEBOLP;

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x416F290", Offset = "0x416D890", VA = "0x18416F290")]
		public KENBPHGEGHC(PropertyInfo FDKAIMCLOIA, Type GBLBAOCMKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x416EFA0", Offset = "0x416D5A0", VA = "0x18416EFA0", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x416F060", Offset = "0x416D660", VA = "0x18416F060", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x416F170", Offset = "0x416D770", VA = "0x18416F170", Slot = "7")]
		public override void NPKHGHMBNGN(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x416F230", Offset = "0x416D830", VA = "0x18416F230", Slot = "8")]
		public override void PJCNGJOOLLA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x416F1D0", Offset = "0x416D7D0", VA = "0x18416F1D0", Slot = "9")]
		public override void OLJMJIJKKHD(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x416F110", Offset = "0x416D710", VA = "0x18416F110", Slot = "10")]
		public override void LKPEEGCFDML(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class MJMNHMMOCPE<T> : KENBPHGEGHC<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3859A10", Offset = "0x3858010", VA = "0x183859A10")]
		public MJMNHMMOCPE(PropertyInfo FDKAIMCLOIA, Type GBLBAOCMKOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x44D5790", Offset = "0x44D3D90", VA = "0x1844D5790", Slot = "5")]
		public override void BBNLCCNAPGE(T BILCKFOIMNP, JOMEGECCBCE JPKMILJIBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x44D5850", Offset = "0x44D3E50", VA = "0x1844D5850", Slot = "6")]
		public override void GDIEAOLABBA(T BILCKFOIMNP, DDKJAJGINNB BLGAJFHCFEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class KMPKKEGBPFP<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static KMPKKEGBPFP<T> CFNNMJAMDBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private readonly NNJCNFHCCBH<T>[] KGEAKIJAFHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int OKCHPGBCPPL;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x41C76C0", Offset = "0x41C5CC0", VA = "0x1841C76C0")]
		public KMPKKEGBPFP(List<NNJCNFHCCBH<T>> HDICKAKGJPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x41C7610", Offset = "0x41C5C10", VA = "0x1841C7610")]
		public void GDIEAOLABBA(T NJKKPOFFNNJ, DDKJAJGINNB JFIDOOOHFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x41C7560", Offset = "0x41C5B60", VA = "0x1841C7560")]
		public void BBNLCCNAPGE(T NJKKPOFFNNJ, JOMEGECCBCE MMDEOFGAFEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class IIKBJLLBOID
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract NNJCNFHCCBH<T> FOHHCFMHKPE<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private DDKJAJGINNB CIJCHHHAEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly int HGBFBHCBPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly Dictionary<Type, IIKBJLLBOID> EHGFOKBKFBA;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5E138E0", Offset = "0x5E11EE0", VA = "0x185E138E0")]
	public AGBFAHJJDHM(int MBDFHOGFFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x3235B30", Offset = "0x3234130", VA = "0x183235B30")]
	private KMPKKEGBPFP<T> GBLKJDMPKHH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x29323D0", Offset = "0x29309D0", VA = "0x1829323D0")]
	public void NECNOABNHFL<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3236C60", Offset = "0x3235260", VA = "0x183236C60")]
	public bool OJPHNAHFOOE<T>(JOMEGECCBCE MMDEOFGAFEK, T PABFDMCLKCE) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x3236D00", Offset = "0x3235300", VA = "0x183236D00")]
	public void PEGIGFCKLEH<T>(DDKJAJGINNB JFIDOOOHFIL, T NJKKPOFFNNJ) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class LMMMIKEHEAD
{
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static readonly DateTime AOMBHICOIPK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] LLOCFONDLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ANBNFBNAKGG GNNOJOGIDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E27660", Offset = "0x5E25C60", VA = "0x185E27660")]
		get
		{
			return default(ANBNFBNAKGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int FKPIHICIMLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E26C30", Offset = "0x5E25230", VA = "0x185E26C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E26A40", Offset = "0x5E25040", VA = "0x185E26A40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public JEAMDGMLLPM OMLGDEPGPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E26C00", Offset = "0x5E25200", VA = "0x185E26C00")]
		get
		{
			return default(JEAMDGMLLPM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E27750", Offset = "0x5E25D50", VA = "0x185E27750")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NOHKNIIEGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E26A10", Offset = "0x5E25010", VA = "0x185E26A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public uint PGOKNOLEFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E26B50", Offset = "0x5E25150", VA = "0x185E26B50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DateTime? AOPDCHPPHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E26BD0", Offset = "0x5E251D0", VA = "0x185E26BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DateTime? MAJPAFHFFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E276C0", Offset = "0x5E25CC0", VA = "0x185E276C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? HDJIPDDEBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E27690", Offset = "0x5E25C90", VA = "0x185E27690")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E27490", Offset = "0x5E25A90", VA = "0x185E27490")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? BOEMFJIEMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xC70640", Offset = "0xC6EC40", VA = "0x180C70640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5830", Offset = "0xAB3E30", VA = "0x180AB5830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E278A0", Offset = "0x5E25EA0", VA = "0x185E278A0")]
	public LMMMIKEHEAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E277F0", Offset = "0x5E25DF0", VA = "0x185E277F0")]
	internal LMMMIKEHEAD(byte[] LKFNEINGOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E268F0", Offset = "0x5E24EF0", VA = "0x185E268F0")]
	public static LMMMIKEHEAD AEGBDHMOCOB(byte[] LKFNEINGOFE, DateTime NMBOANKHGMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E27030", Offset = "0x5E25630", VA = "0x185E27030")]
	internal void KMFNPKKHEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E272C0", Offset = "0x5E258C0", VA = "0x185E272C0")]
	private void LHEJJBBFBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E26C60", Offset = "0x5E25260", VA = "0x185E26C60")]
	private DateTime? IMILMMJIEJJ(int GCMGLJCEDLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E26E60", Offset = "0x5E25460", VA = "0x185E26E60")]
	private void IPGKPDGCIEK(int GCMGLJCEDLO, DateTime? DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E26A80", Offset = "0x5E25080", VA = "0x185E26A80")]
	private ulong CJGCBBNCIGB(int GCMGLJCEDLO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E26830", Offset = "0x5E24E30", VA = "0x185E26830")]
	private void AEBGPAFBEKJ(int GCMGLJCEDLO, ulong DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E27230", Offset = "0x5E25830", VA = "0x185E27230")]
	private uint LFLMPAKMMJH(int GCMGLJCEDLO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5CE7880", Offset = "0x5CE5E80", VA = "0x185CE7880")]
	private static uint PMPGKGHDHCG(uint OCPDJIJPMCG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E276F0", Offset = "0x5E25CF0", VA = "0x185E276F0")]
	private static ulong PMPGKGHDHCG(ulong OCPDJIJPMCG)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum ANBNFBNAKGG
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
public enum JEAMDGMLLPM
{
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class AOPLKDMEGGH
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private const int OFPBFMENBGB = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private const int JEBKKCKFLBE = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int FPEOLNJADED = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly IPEndPoint NDJGIJJJFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private int IHENPPDDBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private int PNIJCDOECMH;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DBOGCANJIFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E17B60", Offset = "0x5E16160", VA = "0x185E17B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E17B70", Offset = "0x5E16170", VA = "0x185E17B70")]
	public bool OPHEFDNPNLG(KAHMIOHDPDJ DCEJINAEKKO, int BNGEJPOFIKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class EFHBJHNIAMH : KAHMIOHDPDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly Socket DCEJINAEKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly EFONNIOJBCM CNPEFDMLDFP;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public short ALKENMHAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B550", Offset = "0x5E19B50", VA = "0x185E1B550", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int PPKFMKGNHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B530", Offset = "0x5E19B30", VA = "0x185E1B530", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EndPoint NMIBIIKANDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AEF0", Offset = "0x5E194F0", VA = "0x185E1AEF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AddressFamily HPHDNOFLAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x42A9210", Offset = "0x42A7810", VA = "0x1842A9210", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B570", Offset = "0x5E19B70", VA = "0x185E1B570")]
	public EFHBJHNIAMH(AddressFamily AHOECLBLDBN, EFONNIOJBCM CNPEFDMLDFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF70", Offset = "0x5E19570", VA = "0x185E1AF70", Slot = "8")]
	public bool LJACJNPNEDK(IPEndPoint IILILNHEHKN, DCCKNKNAEPO PFNALMIFIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF10", Offset = "0x5E19510", VA = "0x185E1AF10", Slot = "9")]
	public int CCHACNCJNKJ(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int LPKLLJKOBNO, IPEndPoint HENIIGIHEIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AE00", Offset = "0x5E19400", VA = "0x185E1AE00", Slot = "10")]
	public int AADLBJGMJAI(byte[] JDFOAHNNFFE, EndPoint LCEOEOCKLAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF50", Offset = "0x5E19550", VA = "0x185E1AF50", Slot = "11")]
	public void EDOLDFCKIAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface KAHMIOHDPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	short ALKENMHAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int PPKFMKGNHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	EndPoint NMIBIIKANDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AddressFamily HPHDNOFLAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LJACJNPNEDK(IPEndPoint IILILNHEHKN, DCCKNKNAEPO PFNALMIFIFB);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int CCHACNCJNKJ(byte[] JDFOAHNNFFE, int GCMGLJCEDLO, int LPKLLJKOBNO, IPEndPoint HENIIGIHEIF);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AADLBJGMJAI(byte[] JDFOAHNNFFE, EndPoint HENIIGIHEIF);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EDOLDFCKIAL();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct GCEAEOLOKLD : IEquatable<GCEAEOLOKLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly long LFMDANOGCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly long PDOPIOGPNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly long MJFEEGCBCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly int EFPJFNMECOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly int HALKCCBDMDN;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5E22BC0", Offset = "0x5E211C0", VA = "0x185E22BC0")]
	public GCEAEOLOKLD(byte[] APCNIONLEEC, int HDLJOPAECNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x88ECA0", Offset = "0x88D2A0", VA = "0x18088ECA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5E22B80", Offset = "0x5E21180", VA = "0x185E22B80", Slot = "4")]
	public bool Equals(GCEAEOLOKLD BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5E22AD0", Offset = "0x5E210D0", VA = "0x185E22AD0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class MFDFDGGPOHG : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public readonly byte[] NNELDDEFPEE;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class KAKDBJLMHMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public readonly int EJMBABKDCOP;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x871800", Offset = "0x86FE00", VA = "0x180871800")]
	protected KAKDBJLMHMP(int LHGJLKFCLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void AADFLGLJMCA(IPEndPoint IILILNHEHKN, byte[] MMDLBEBNCGC, int GCMGLJCEDLO, int JOCLJBACIHN);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void DJAEIMKJNLD(IPEndPoint IILILNHEHKN, byte[] MMDLBEBNCGC, int GCMGLJCEDLO, int JOCLJBACIHN);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GGAPJCEJKIP : KAKDBJLMHMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private byte[] IBBDLGCDELM;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly RandomNumberGenerator OBBOIGFCJDO;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2020240", Offset = "0x201E840", VA = "0x182020240")]
	public GGAPJCEJKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5E235B0", Offset = "0x5E21BB0", VA = "0x185E235B0")]
	public void EDBOGLGHEME(IPEndPoint IILILNHEHKN, byte[] IBBDLGCDELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5E23160", Offset = "0x5E21760", VA = "0x185E23160")]
	public void ANJADKIFDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5E22CB0", Offset = "0x5E212B0", VA = "0x185E22CB0", Slot = "4")]
	public override void AADFLGLJMCA(IPEndPoint IILILNHEHKN, byte[] MMDLBEBNCGC, int GCMGLJCEDLO, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5E23240", Offset = "0x5E21840", VA = "0x185E23240", Slot = "5")]
	public override void DJAEIMKJNLD(IPEndPoint IILILNHEHKN, byte[] MMDLBEBNCGC, int GCMGLJCEDLO, int JOCLJBACIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct BBKHOMAKFPG
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void MKOHNJPBEGK([NoAlias] byte* KBOBHHJAJLF, [NoAlias] byte* IBBDLGCDELM, [NoAlias] byte* KFOFGNBOCMI, int JOCLJBACIHN);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class PIPEJFBGABN
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private static IntPtr KLCGLECEBJJ;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private static IntPtr DDBCLLEDAPE;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A7F0", Offset = "0x5E28DF0", VA = "0x185E2A7F0")]
		[BurstDiscard]
		private static void EIOIFFJFPOL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A920", Offset = "0x5E28F20", VA = "0x185E2A920")]
		private static IntPtr HODLALKBOOL()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A500", Offset = "0x5E28B00", VA = "0x185E2A500")]
		public static void BHKBKKHCMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
		public static void PNLKNBIHCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A5B0", Offset = "0x5E28BB0", VA = "0x185E2A5B0")]
		public unsafe static void DKJHOBNJMII([NoAlias] byte* KBOBHHJAJLF, [NoAlias] byte* IBBDLGCDELM, [NoAlias] byte* KFOFGNBOCMI, int JOCLJBACIHN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private unsafe fixed uint IBBDLGCDELM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private unsafe fixed uint KFOFGNBOCMI[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private unsafe fixed uint CJHLJFNOAAD[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private unsafe fixed uint PFGHJJKOEFB[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private unsafe fixed uint LEKBCFKCBDK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint FNPDGLIMFML[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint PMECLMFFDIM[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private uint ONJJLJHHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint CMKCFKJEIAD[8];

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5E183E0", Offset = "0x5E169E0", VA = "0x185E183E0")]
	private void LJOBMJGJKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5E17CD0", Offset = "0x5E162D0", VA = "0x185E17CD0")]
	private uint CJPHDCNMABN(uint HAHPKMHGFDD, int JLEHMKGKIOA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5E13400", Offset = "0x5E11A00", VA = "0x185E13400")]
	private void HMMINBIAANH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5E13540", Offset = "0x5E11B40", VA = "0x185E13540")]
	private void KCGACGJGBDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5E134B0", Offset = "0x5E11AB0", VA = "0x185E134B0")]
	private void JOJBHHGMALB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5E13300", Offset = "0x5E11900", VA = "0x185E13300")]
	private void GMCACGMNIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5E18280", Offset = "0x5E16880", VA = "0x185E18280")]
	private void JDGLPFLLAAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5E17E60", Offset = "0x5E16460", VA = "0x185E17E60")]
	private unsafe void IINHLFNKAIF(byte* KBOBHHJAJLF, uint* IBBDLGCDELM, uint* KFOFGNBOCMI, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5E17D00", Offset = "0x5E16300", VA = "0x185E17D00")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DIGHCOONGCB([NoAlias] byte* KBOBHHJAJLF, [NoAlias] byte* IBBDLGCDELM, [NoAlias] byte* KFOFGNBOCMI, int JOCLJBACIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5E17D80", Offset = "0x5E16380", VA = "0x185E17D80")]
	public static void DIGHCOONGCB(Span<byte> KBOBHHJAJLF, Span<byte> IBBDLGCDELM, Span<byte> KFOFGNBOCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5E182E0", Offset = "0x5E168E0", VA = "0x185E182E0")]
	public static void KKKHFNCNAJH(Span<byte> KBOBHHJAJLF, Span<byte> IBBDLGCDELM, Span<byte> KFOFGNBOCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5E17C60", Offset = "0x5E16260", VA = "0x185E17C60")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BPNHACOALCM([NoAlias] byte* KBOBHHJAJLF, [NoAlias] byte* IBBDLGCDELM, [NoAlias] byte* KFOFGNBOCMI, int JOCLJBACIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AA80", Offset = "0x5E29080", VA = "0x185E2AA80")]
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
