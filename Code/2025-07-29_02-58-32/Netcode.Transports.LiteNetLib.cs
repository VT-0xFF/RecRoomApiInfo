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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, CLNPEFJOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum PLKLEINNIGE
		{
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Server,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
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
		private NetworkManager CAMGGGGOKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool OJDGDHJEGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly Dictionary<ulong, MDPMPMEIPBK> EKBFNGCFONE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CDEMDILCJDP DMEHEHLFDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Stopwatch JLJFHFEABON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private byte[] AGGKGHOAEEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PLKLEINNIGE BMAFBJODEIG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int LIFOLAMMDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x74E13B0", Offset = "0x74DFDB0", VA = "0x1874E13B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override ulong GAJOIMNDFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA85A50", Offset = "0xA84450", VA = "0x180A85A50", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override bool OCFFLBJOIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x74E1390", Offset = "0x74DFD90", VA = "0x1874E1390", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74E0980", Offset = "0x74DF380", VA = "0x1874E0980")]
		public void RecRoom_SetEncryptionInfo(ulong GOOANDAKBHO, byte[] LNBCHJPEENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x74E0960", Offset = "0x74DF360", VA = "0x1874E0960")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x74E0830", Offset = "0x74DF230", VA = "0x1874E0830")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74E1290", Offset = "0x74DFC90", VA = "0x1874E1290")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74E0AA0", Offset = "0x74DF4A0", VA = "0x1874E0AA0", Slot = "6")]
		public override void Send(ulong CDBGILBOAEE, ArraySegment<byte> GPCDCFCPGFK, NetworkDelivery NKFCKAPINEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
		public override void FlushSendQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x74E0920", Offset = "0x74DF320", VA = "0x1874E0920", Slot = "8")]
		public override NetworkEvent PollEvent([Out] ulong CDBGILBOAEE, [Out] ArraySegment<byte> EEMEEFCIEHD, [Out] float NKFMHMOBFKK)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74E0D90", Offset = "0x74DF790", VA = "0x1874E0D90", Slot = "9")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74E10B0", Offset = "0x74DFAB0", VA = "0x1874E10B0", Slot = "10")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74DFE50", Offset = "0x74DE850", VA = "0x1874DFE50", Slot = "11")]
		public override void DisconnectRemoteClient(ulong CDBGILBOAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74DFD60", Offset = "0x74DE760", VA = "0x1874DFD60", Slot = "12")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74E0190", Offset = "0x74DEB90", VA = "0x1874E0190", Slot = "13")]
		public override ulong GetCurrentRtt(ulong CDBGILBOAEE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74E0D20", Offset = "0x74DF720", VA = "0x1874E0D20", Slot = "14")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74E03E0", Offset = "0x74DEDE0", VA = "0x1874E03E0", Slot = "15")]
		public override void Initialize([Optional] NetworkManager CAMGGGGOKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74E06A0", Offset = "0x74DF0A0", VA = "0x1874E06A0")]
		private AOMHBJHJKJO NNKNJKCHEDO(NetworkDelivery AEOGKDPPBBE)
		{
			return default(AOMHBJHJKJO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74E0770", Offset = "0x74DF170", VA = "0x1874E0770", Slot = "16")]
		private void OHPEOKLNHNI(MDPMPMEIPBK DLAOPMDPLCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74E0230", Offset = "0x74DEC30", VA = "0x1874E0230", Slot = "17")]
		private void HABGMNKHPCP(MDPMPMEIPBK DLAOPMDPLCG, GPEPHGAHLNC NLJMHIAPPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "18")]
		private void LFMCMOAJJLD(IPEndPoint PCDDCAGCLHJ, SocketError MENAFFDJAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74DFF80", Offset = "0x74DE980", VA = "0x1874DFF80", Slot = "19")]
		private void GJEPKMPMMDC(MDPMPMEIPBK DLAOPMDPLCG, NGAOIDAFFPF IOMONBOBJAC, byte MAANAFMMOCN, AOMHBJHJKJO FJLBANMBKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74E0300", Offset = "0x74DED00", VA = "0x1874E0300")]
		private void IPOKCAPAIOJ(int CGAAPEOHPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "20")]
		private void HBFLHKBMOKN(IPEndPoint LBEDKFILOMP, NGAOIDAFFPF IOMONBOBJAC, JHGGPEGAMBO DHNJANCOPMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "21")]
		private void OJOHCNIDLED(MDPMPMEIPBK DLAOPMDPLCG, int JKNEDONBMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x74E0640", Offset = "0x74DF040", VA = "0x1874E0640", Slot = "22")]
		private void LGDFPMJAMPF(JNKBBIALDFK NIBLEOGJBJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74E0610", Offset = "0x74DF010", VA = "0x1874E0610")]
		private ulong KIHMFGEFMJJ(MDPMPMEIPBK DLAOPMDPLCG)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x74E05F0", Offset = "0x74DEFF0", VA = "0x1874E05F0")]
		private ulong KIHMFGEFMJJ(ulong CDBGILBOAEE)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74DFF60", Offset = "0x74DE960", VA = "0x1874DFF60")]
		private static int GDGKPMINBFA(float NMPFLEBOLHH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74E12B0", Offset = "0x74DFCB0", VA = "0x1874E12B0")]
		public LiteNetLibTransport()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74DFD30", Offset = "0x74DE730", VA = "0x1874DFD30")]
		[CompilerGenerated]
		private void DELGKIHHKEG(ulong EMJMEIELGNB, int HCPPNHFEFPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74DFD30", Offset = "0x74DE730", VA = "0x1874DFD30")]
		[CompilerGenerated]
		private void DNJMFCKGJNH(ulong EMJMEIELGNB, int HCPPNHFEFPE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal abstract class GMCAHKKJDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly MDPMPMEIPBK ECDNKPCEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected readonly ConcurrentQueue<MCIJNONHJOG> COHLPALDBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private int ABKCMHIECCN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IPNNHMIEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74DF1A0", Offset = "0x74DDBA0", VA = "0x1874DF1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74DF230", Offset = "0x74DDC30", VA = "0x1874DF230")]
	protected GMCAHKKJDEJ(MDPMPMEIPBK DLAOPMDPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74DF0C0", Offset = "0x74DDAC0", VA = "0x1874DF0C0")]
	public void EJNFBGIFODA(MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74DF120", Offset = "0x74DDB20", VA = "0x1874DF120")]
	protected void GHEEALGCKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74DF1F0", Offset = "0x74DDBF0", VA = "0x1874DF1F0")]
	public bool KOPBOJNAKGP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool AEDAOCFODKL();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AJLEGNDGCEE(MCIJNONHJOG NKFJGBBKJEE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal enum CJFPOBKLOCC
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Accept,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	RejectForce
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JNKBBIALDFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CDEMDILCJDP POBOCJLIOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int BPPFLGMEKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal OHOOHABOPJO FGEFJDLOKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly IPEndPoint AHGPIMHICNK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal CJFPOBKLOCC CBAAPALEPCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50")]
		[CompilerGenerated]
		get
		{
			return default(CJFPOBKLOCC);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xEB0C60", Offset = "0xEAF660", VA = "0x180EB0C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x74DF2D0", Offset = "0x74DDCD0", VA = "0x1874DF2D0")]
	internal void CICIADHPMIE(OHOOHABOPJO NAKGNABAGLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74DF330", Offset = "0x74DDD30", VA = "0x1874DF330")]
	private bool JEFKFNLAANH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74DF3C0", Offset = "0x74DDDC0", VA = "0x1874DF3C0")]
	internal JNKBBIALDFK(IPEndPoint LBEDKFILOMP, OHOOHABOPJO EJJANMMLLPJ, CDEMDILCJDP HKCOJOMINBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x74DF360", Offset = "0x74DDD60", VA = "0x1874DF360")]
	public MDPMPMEIPBK PLENKCCCKMN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JHGGPEGAMBO
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum FAIHOEOEMGC
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	ConnectionFailed,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Timeout,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HostUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	NetworkUnreachable,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	RemoteConnectionClose,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	DisconnectPeerCalled,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ConnectionRejected,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	UnknownHost,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	Reconnect,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	PeerToPeerConnection,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	PeerNotFound
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GPEPHGAHLNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public FAIHOEOEMGC ILDELIKFKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public SocketError LGNKNBNPFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public NGAOIDAFFPF LKIEGEDMPOC;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CLNPEFJOOCM
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLEDKEJFDOE(MDPMPMEIPBK DLAOPMDPLCG);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDPODFMNANP(MDPMPMEIPBK DLAOPMDPLCG, GPEPHGAHLNC NLJMHIAPPDP);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEOOBHLJOCE(IPEndPoint PCDDCAGCLHJ, SocketError MENAFFDJAHF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFPGPNJHEFJ(MDPMPMEIPBK DLAOPMDPLCG, NGAOIDAFFPF IOMONBOBJAC, byte MAANAFMMOCN, AOMHBJHJKJO FJLBANMBKMK);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DKKHBJIPBNM(IPEndPoint LBEDKFILOMP, NGAOIDAFFPF IOMONBOBJAC, JHGGPEGAMBO DHNJANCOPMO);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OPPNFKNEIMA(MDPMPMEIPBK DLAOPMDPLCG, int JKNEDONBMBH);

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HACHPOHIPIJ(JNKBBIALDFK NIBLEOGJBJF);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ANCICPAHNKP
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EIBEBBAODCB(MDPMPMEIPBK DLAOPMDPLCG, object KMIHMPGPMOB);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AGNAANKNPDK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEHJMAJAGKC(AOEADLCKOAE NKFJGBBKJEE);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KOGDLPNKNMA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDCMFJDIMNA(MDPMPMEIPBK DLAOPMDPLCG, IPEndPoint CLDAOCLCBJN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class OHOOHABOPJO
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const int PPCDHPCNOFC = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly long ECBEGDNEFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public byte EPDOHCMHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte[] BFLLMMLAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly CODKNAIBEBE AKBOOJDMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly int HCHOBAJMCCI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74E9A60", Offset = "0x74E8460", VA = "0x1874E9A60")]
	private OHOOHABOPJO(long NHPNDGHBLLC, byte CBJGMOMOAIB, int DBDHPICCKFG, byte[] IEANIDIMECE, CODKNAIBEBE GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74E9820", Offset = "0x74E8220", VA = "0x1874E9820")]
	public static int LFBBOGDELPI(MCIJNONHJOG NKFJGBBKJEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74E9600", Offset = "0x74E8000", VA = "0x1874E9600")]
	public static OHOOHABOPJO FPLPJFDLGBC(MCIJNONHJOG NKFJGBBKJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74E9880", Offset = "0x74E8280", VA = "0x1874E9880")]
	public static MCIJNONHJOG NAKLEINKPJE(MIPFOBFCGMI EIAGABIEFGE, SocketAddress LBEFBKKBNOF, long AOHMPCGLEMB, int DBDHPICCKFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal sealed class EABNDBPHFMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly long ECBEGDNEFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly byte EPDOHCMHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly int HCHOBAJMCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly bool OMIEOKPCFBE;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74DDA20", Offset = "0x74DC420", VA = "0x1874DDA20")]
	private EABNDBPHFMI(long NHPNDGHBLLC, byte CBJGMOMOAIB, int DFPMBNMGGEM, bool BPHENEOFCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x74DD6E0", Offset = "0x74DC0E0", VA = "0x1874DD6E0")]
	public static EABNDBPHFMI FPLPJFDLGBC(MCIJNONHJOG NKFJGBBKJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74DD930", Offset = "0x74DC330", VA = "0x1874DD930")]
	public static MCIJNONHJOG NAKLEINKPJE(long AOHMPCGLEMB, byte FHHBJDFOGNL, int GHMLOJAPLFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74DD830", Offset = "0x74DC230", VA = "0x1874DD830")]
	public static MCIJNONHJOG KFIKHJPOLHN(MDPMPMEIPBK DLAOPMDPLCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum LCLHFCDNABC
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CKIAMDNOLON
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACADBNAIMMB(IPEndPoint PFILHHFIAOA, IPEndPoint LBEDKFILOMP, string DHNMCOFINFM);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAIKIDFHPIE(IPEndPoint KCBKGIAJGAA, LCLHFCDNABC AEOGKDPPBBE, string DHNMCOFINFM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class AJAGNNCIACG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct FHBJGIGNEFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public IPEndPoint PDDKPAEJHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IPEndPoint AHGPIMHICNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string FIOAMKACPAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private struct JAGEGLBPIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public IPEndPoint CELHBOBAABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public LCLHFCDNABC MMPEDFAPIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string FIOAMKACPAK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class BJKEMPIHPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint GGLLPKEOIAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string FIOAMKACPAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public BJKEMPIHPIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class LJFANEBLOIH
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IPEndPoint GGLLPKEOIAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IPEndPoint BEFGCNNOCAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string FIOAMKACPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public LJFANEBLOIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class NOAGJFPDDIA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public string FIOAMKACPAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA864E0", Offset = "0xA84EE0", VA = "0x180A864E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool MFHBOMMDAJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAD3450", Offset = "0xAD1E50", VA = "0x180AD3450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA87B30", Offset = "0xA86530", VA = "0x180A87B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public NOAGJFPDDIA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CDEMDILCJDP JFKIMLAMMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ConcurrentQueue<FHBJGIGNEFM> EEOLDMMCHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ConcurrentQueue<JAGEGLBPIIG> PKCPGCDNDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CODKNAIBEBE PLKFKKMCOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly MIPFOBFCGMI OKBJBCCDCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly AHGODCKIHGL KOMAHKBMBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private CKIAMDNOLON NADPNONEDMP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public const int LCFHDKFGLIP = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public bool KECBMPGCIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x74D30C0", Offset = "0x74D1AC0", VA = "0x1874D30C0")]
	internal AJAGNNCIACG(CDEMDILCJDP CAAPNCHJHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x74D2DA0", Offset = "0x74D17A0", VA = "0x1874D2DA0")]
	internal void NKOKAPNCLAG(IPEndPoint LANHFACHNMH, MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31CB520", Offset = "0x31C9F20", VA = "0x1831CB520")]
	private void GPEHLCFJCHC<T>(T NKFJGBBKJEE, IPEndPoint IMFCAPGBDGB) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x74D2AB0", Offset = "0x74D14B0", VA = "0x1874D2AB0")]
	private void ACADBNAIMMB(BJKEMPIHPIJ EFOMNMDLAFE, IPEndPoint LANHFACHNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x74D2C40", Offset = "0x74D1640", VA = "0x1874D2C40")]
	private void DCHCFLJMLAE(LJFANEBLOIH EFOMNMDLAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x74D2F20", Offset = "0x74D1920", VA = "0x1874D2F20")]
	private void NKPNADGHPCE(NOAGJFPDDIA EFOMNMDLAFE, IPEndPoint LANHFACHNMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum AOMHBJHJKJO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Unreliable = 4,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	ReliableUnordered = 0,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Sequenced = 1,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	ReliableOrdered = 2,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	ReliableSequenced = 3
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum IIPFFCFIOBA : long
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OMGKNJHCIDE
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	internal static readonly int[] HBOHAFONNKP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly int KJIFNJIJIGD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly int AAIIIEABKBJ;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OPKCNOCPNHP : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x74DD6D0", Offset = "0x74DC0D0", VA = "0x1874DD6D0")]
	public OPKCNOCPNHP(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JHLKJHCEAGP : OPKCNOCPNHP
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x74DD6D0", Offset = "0x74DC0D0", VA = "0x1874DD6D0")]
	public JHLKJHCEAGP(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum EOABOAEJLFN
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Error,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Trace,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Info
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DJGLBPPHHMD
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJPPIEHNPOH(EOABOAEJLFN PAFEDJPIGAO, string OJCMLFFIJFF, params object[] GACFFBLMJOF);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EPNHIEMFMDA
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static DJGLBPPHHMD LAKBJDFEDOH;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly object BMHDIGMDGFG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74DDFE0", Offset = "0x74DC9E0", VA = "0x1874DDFE0")]
	private static void FGDBAHOOOKM(EOABOAEJLFN MODJDDGGHCM, string OJCMLFFIJFF, params object[] GACFFBLMJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x74DE2D0", Offset = "0x74DCCD0", VA = "0x1874DE2D0")]
	internal static void INPHAHKMGLI(string OJCMLFFIJFF, params object[] GACFFBLMJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74DE270", Offset = "0x74DCC70", VA = "0x1874DE270")]
	internal static void IAJDOJKEHPC(string OJCMLFFIJFF, params object[] GACFFBLMJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74DE210", Offset = "0x74DCC10", VA = "0x1874DE210")]
	internal static void GJIAJANGONN(string OJCMLFFIJFF, params object[] GACFFBLMJOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum FMMPLOJOBMP
{
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NGAOIDAFFPF : CODKNAIBEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private MCIJNONHJOG OLJHOOJNKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly CDEMDILCJDP GOBKKMAKPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly NFCPIBCGDMI GMEOEMCMMFC;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x74E7C60", Offset = "0x74E6660", VA = "0x1874E7C60")]
	internal NGAOIDAFFPF(CDEMDILCJDP NKHELPOPPEM, NFCPIBCGDMI KLIFLLIBPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x74E7B40", Offset = "0x74E6540", VA = "0x1874E7B40")]
	internal void COHBLEFJAJG(MCIJNONHJOG NKFJGBBKJEE, int MNLLGHAGCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x74E7BE0", Offset = "0x74E65E0", VA = "0x1874E7BE0")]
	internal void MJBCACHAKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74E7BB0", Offset = "0x74E65B0", VA = "0x1874E7BB0")]
	public void FAJOHGLFBLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal sealed class NFCPIBCGDMI
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public enum CJNDBCJPBJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Connect,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Disconnect,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Receive,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		ReceiveUnconnected,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		ConnectionLatencyUpdated,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Broadcast,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		ConnectionRequest,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		MessageDelivered,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PeerAddressChanged
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NFCPIBCGDMI EILPADPNPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public CJNDBCJPBJA MMPEDFAPIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public MDPMPMEIPBK ECDNKPCEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public IPEndPoint AHGPIMHICNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public object FMNGCEOIPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int NKMMFPHKNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public SocketError BNCAPCFBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FAIHOEOEMGC GELOMNGBACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public JNKBBIALDFK NAMFOIDIBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AOMHBJHJKJO PLNBOPADNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public byte NNAJBCCAEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public readonly NGAOIDAFFPF CIJDLDKABFH;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74E7AA0", Offset = "0x74E64A0", VA = "0x1874E7AA0")]
	public NFCPIBCGDMI(CDEMDILCJDP NKHELPOPPEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CDEMDILCJDP : IEnumerable<MDPMPMEIPBK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private class GDKEBALKKLO : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x74DE540", Offset = "0x74DCF40", VA = "0x1874DE540", Slot = "4")]
		public bool Equals(IPEndPoint IECENJOJFJH, IPEndPoint OFOCBNJJIJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x44A5BB0", Offset = "0x44A45B0", VA = "0x1844A5BB0", Slot = "5")]
		public int GetHashCode(IPEndPoint CEFJEHJNIAP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GDKEBALKKLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PIIGFMIPKCH : IEnumerator<MDPMPMEIPBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly MDPMPMEIPBK OKLAONDIFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private MDPMPMEIPBK KEGLCEBPLLM;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MDPMPMEIPBK CEKGODBONJL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB1D6D0", Offset = "0xB1C0D0", VA = "0x180B1D6D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C8C240", Offset = "0x1C8AC40", VA = "0x181C8C240")]
		public PIIGFMIPKCH(MDPMPMEIPBK DJKLMOIIBCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x74EA380", Offset = "0x74E8D80", VA = "0x1874EA380", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x74EA3D0", Offset = "0x74E8DD0", VA = "0x1874EA3D0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Thread BACFDJNEEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool AGKPFEMLJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool NLOMHMKMEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private FPIHJIAKLOO KDBOMIGHKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly AutoResetEvent IOIPONGIOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Queue<NFCPIBCGDMI> CCOHECLLLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Queue<NFCPIBCGDMI> CAFKPBHGIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NFCPIBCGDMI DIECOJJHAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly CLNPEFJOOCM OJKEOOPEPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ANCICPAHNKP EHHACIFJLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly AGNAANKNPDK EJAMAAJBEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly KOGDLPNKNMA IJHKMKNMFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly Dictionary<IPEndPoint, MDPMPMEIPBK> AEJFKOIMFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly Dictionary<IPEndPoint, JNKBBIALDFK> EGLLIFJHNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly Dictionary<IPEndPoint, LAGHKMDJHKK> OMKKLHNFJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly ReaderWriterLockSlim HOJJHCFJFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private MDPMPMEIPBK OOEGFCCDEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int LLOEKMMHEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly List<MDPMPMEIPBK> OIBHMHFBFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private MDPMPMEIPBK[] DAICIIOGFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly HIADFHCCGCK LBEGNKGCNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private int EEHFPALDGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private ConcurrentQueue<int> KMFAELHJAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private byte MMABPJOIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly object DLBBFFKLPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BFFCIPJCIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool HBAIMPBNPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int CBLNBHIMPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int MFFDMPCJLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int HKIIANOINOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int CPKLLCJFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool BFOJGIJLFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool MJMGFCAHJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int HPFPBPCNBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int GMCEHAJFNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public int FHDJMEKACDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool KECBMPGCIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool AMEADELBHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool IEFEIBFJBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool DOFJPIOCOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int GBFFBNMFOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int NCNDDIHCPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool HDJPKKKEBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public readonly PIDOACOEOME LDMJMNEBFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GGHDHNAGCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public readonly AJAGNNCIACG HFJBBINMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool MIFPKLCCMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public FMMPLOJOBMP DIFCIMGEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int MAADFOICBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool GCFAODDCDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13D")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool DCBMKBIIKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13E")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool FAHIKMMKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13F")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool KJMCCPFKGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private MCIJNONHJOG OACOKIMJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int MMJPJNJPFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly object OKMHDBAPBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private MCIJNONHJOG CDFKLFNIJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int EHIMPPPJNNN;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const int EHCECOJGDBA = 50;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private const int DIIFAFACLOK = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private ANFHAKMNCPI EHLFOHHFEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private ANFHAKMNCPI CKHNLGHLBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Thread GHPEFPPCMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Thread KBIHNMDPBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPEndPoint KGILPIEGGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IPEndPoint JCKNFHENKIJ;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	[ThreadStatic]
	private static byte[] CPLGPDHLJDF;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	[ThreadStatic]
	private static byte[] MLEEPFFEBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<PMLGBGFLIEB, IPEndPoint> CBGPFLDMIBD;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly IPAddress MAFHBHNIFNG;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly bool GLMBMIOPFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int PAPALJLONDE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IDAAHDMAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xBE4DB0", Offset = "0xBE37B0", VA = "0x180BE4DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xBE5740", Offset = "0xBE4140", VA = "0x180BE5740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PLPFPJBFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x17DC600", Offset = "0x17DB000", VA = "0x1817DC600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x20EE150", Offset = "0x20ECB50", VA = "0x1820EE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public byte GOAEGOPMFPP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x108B810", Offset = "0x108A210", VA = "0x18108B810")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HBHIJGGHIEP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74DB7A0", Offset = "0x74DA1A0", VA = "0x1874DB7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	internal short EMFPNHDFKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x74D71F0", Offset = "0x74D5BF0", VA = "0x1874D71F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MDPMPMEIPBK.BOPAPIELFNB AALADJFPJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x74DBC70", Offset = "0x74DA670", VA = "0x1874DBC70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74DBD20", Offset = "0x74DA720", VA = "0x1874DBD20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74D55D0", Offset = "0x74D3FD0", VA = "0x1874D55D0")]
	public void CGMDNLDGGGL(IPEndPoint PCDDCAGCLHJ, byte[] LNBCHJPEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74D9D80", Offset = "0x74D8780", VA = "0x1874D9D80")]
	public void HJDEOLFOFDE(IPEndPoint PCDDCAGCLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74D6960", Offset = "0x74D5360", VA = "0x1874D6960")]
	private bool EBOIBGFJHIF(IPEndPoint PCDDCAGCLHJ, [Out] MDPMPMEIPBK DLAOPMDPLCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74D97D0", Offset = "0x74D81D0", VA = "0x1874D97D0")]
	private void GMIGKPBGAEK(MDPMPMEIPBK DLAOPMDPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74D72B0", Offset = "0x74D5CB0", VA = "0x1874D72B0")]
	private void FJDHPGEBLGA(MDPMPMEIPBK DLAOPMDPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74DAB50", Offset = "0x74D9550", VA = "0x1874DAB50")]
	private void JFPEONLOPKF(MDPMPMEIPBK DLAOPMDPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74DC280", Offset = "0x74DAC80", VA = "0x1874DC280")]
	public CDEMDILCJDP(CLNPEFJOOCM HKCOJOMINBP, [Optional] HIADFHCCGCK BGGEAFNPGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74D4C20", Offset = "0x74D3620", VA = "0x1874D4C20")]
	internal void AJFAEKADPED(MDPMPMEIPBK ENAILNMEAPE, int JKNEDONBMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74DA470", Offset = "0x74D8E70", VA = "0x1874DA470")]
	internal void IBHHCHEAJKP(MDPMPMEIPBK ENAILNMEAPE, object KMIHMPGPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74DB760", Offset = "0x74DA160", VA = "0x1874DB760")]
	internal void LCJFGFJBKPL(MDPMPMEIPBK DLAOPMDPLCG, FAIHOEOEMGC HDDLNGLMMKN, SocketError GNHHIFOICJN, MCIJNONHJOG EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74D7310", Offset = "0x74D5D10", VA = "0x1874D7310")]
	private void GEALKMOBNEA(MDPMPMEIPBK DLAOPMDPLCG, FAIHOEOEMGC HDDLNGLMMKN, SocketError GNHHIFOICJN, bool FGLPKBNAEFO, byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int CDCPIGCEABM, MCIJNONHJOG EOOLELFGEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74D5070", Offset = "0x74D3A70", VA = "0x1874D5070")]
	private void BJPIEJNBJOJ(NFCPIBCGDMI.CJNDBCJPBJA AEOGKDPPBBE, [Optional] MDPMPMEIPBK DLAOPMDPLCG, [Optional] IPEndPoint LBEDKFILOMP, SocketError EKKNDADGPGC = SocketError.Success, int JKNEDONBMBH = 0, FAIHOEOEMGC CHMJJOIIDGO = FAIHOEOEMGC.ConnectionFailed, [Optional] JNKBBIALDFK AKALOFEGLCK, AOMHBJHJKJO FJLBANMBKMK = AOMHBJHJKJO.Unreliable, byte MAANAFMMOCN = 0, [Optional] MCIJNONHJOG LLGFHOHNJAD, [Optional] object KMIHMPGPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74D6A00", Offset = "0x74D5400", VA = "0x1874D6A00")]
	private void EKKJBKHOJCP(NFCPIBCGDMI KLIFLLIBPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74DB5D0", Offset = "0x74D9FD0", VA = "0x1874DB5D0")]
	internal void KPDGGPMOFAN(NFCPIBCGDMI KLIFLLIBPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74D6610", Offset = "0x74D5010", VA = "0x1874D6610")]
	private void DKPFMGOGNNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x74D57F0", Offset = "0x74D41F0", VA = "0x1874D57F0")]
	private void DCDNFKHBLPP(int LLECMJNJHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x74DAFB0", Offset = "0x74D99B0", VA = "0x1874DAFB0")]
	internal MDPMPMEIPBK JOOPCCMBFIM(JNKBBIALDFK NIBLEOGJBJF, byte[] LNDKGEDEMGN, int PAEPPOFDFDK, int KLLLBPFLPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x74DB6E0", Offset = "0x74DA0E0", VA = "0x1874DB6E0")]
	private int LANCJMNHLDE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74DB7C0", Offset = "0x74DA1C0", VA = "0x1874DB7C0")]
	private void MNCGIDCFGMJ(IPEndPoint LBEDKFILOMP, MDPMPMEIPBK IHDOIJJJDKC, OHOOHABOPJO DGALPGKEIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74D7800", Offset = "0x74D6200", VA = "0x1874D7800")]
	private void GJPGJDPFIPJ(MCIJNONHJOG NKFJGBBKJEE, IPEndPoint LBEDKFILOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74D5B10", Offset = "0x74D4510", VA = "0x1874D5B10")]
	internal void DCGOKJHJLCD(MCIJNONHJOG NKFJGBBKJEE, AOMHBJHJKJO LOHNFJJANPK, byte MAANAFMMOCN, int MNLLGHAGCFI, MDPMPMEIPBK ENAILNMEAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x74D8F50", Offset = "0x74D7950", VA = "0x1874D8F50")]
	public bool GMHPCBOPLJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74D97B0", Offset = "0x74D81B0", VA = "0x1874D97B0")]
	public bool GMHPCBOPLJD(IPAddress IEDKIKFEENE, IPAddress MKNOKJHKAOE, int BLKNFNLBLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x74D8F60", Offset = "0x74D7960", VA = "0x1874D8F60")]
	public bool GMHPCBOPLJD(int BLKNFNLBLKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x74D4EC0", Offset = "0x74D38C0", VA = "0x1874D4EC0")]
	public void BEADDJIPPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x74D9FB0", Offset = "0x74D89B0", VA = "0x1874D9FB0")]
	public MDPMPMEIPBK IBAOFJGDOEH(string KINAHJPOBLI, int BLKNFNLBLKN, string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x74D9ED0", Offset = "0x74D88D0", VA = "0x1874D9ED0")]
	public MDPMPMEIPBK IBAOFJGDOEH(string KINAHJPOBLI, int BLKNFNLBLKN, MIPFOBFCGMI NNKMDBGHJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x74DA090", Offset = "0x74D8A90", VA = "0x1874DA090")]
	public MDPMPMEIPBK IBAOFJGDOEH(IPEndPoint IMFCAPGBDGB, MIPFOBFCGMI NNKMDBGHJIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x74D48B0", Offset = "0x74D32B0", VA = "0x1874D48B0")]
	public void AHOFHALOFLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74D48C0", Offset = "0x74D32C0", VA = "0x1874D48C0")]
	public void AHOFHALOFLF(bool JCLNNANEMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74DA590", Offset = "0x74D8F90", VA = "0x1874DA590")]
	public void ICCMGHMGEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x74DA4C0", Offset = "0x74D8EC0", VA = "0x1874DA4C0")]
	public void ICCMGHMGEFH(byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x74D7760", Offset = "0x74D6160", VA = "0x1874D7760")]
	public void GEALKMOBNEA(MDPMPMEIPBK DLAOPMDPLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x74D7720", Offset = "0x74D6120", VA = "0x1874D7720")]
	public void GEALKMOBNEA(MDPMPMEIPBK DLAOPMDPLCG, byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x74DC0A0", Offset = "0x74DAAA0", VA = "0x1874DC0A0", Slot = "4")]
	private IEnumerator<MDPMPMEIPBK> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x74DC130", Offset = "0x74DAB30", VA = "0x1874DC130", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74D8BD0", Offset = "0x74D75D0", VA = "0x1874D8BD0")]
	private MCIJNONHJOG GKLOHHMNHNH(JKJOJPKFIBP OGFGMDINCKP, int CGAAPEOHPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74D8CC0", Offset = "0x74D76C0", VA = "0x1874D8CC0")]
	private MCIJNONHJOG GKLOHHMNHNH(JKJOJPKFIBP OGFGMDINCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74D4C70", Offset = "0x74D3670", VA = "0x1874D4C70")]
	internal MCIJNONHJOG AOFADLKCMHP(int CGAAPEOHPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74D9B10", Offset = "0x74D8510", VA = "0x1874D9B10")]
	internal void HGPDCOBKHDA(MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74DC1C0", Offset = "0x74DABC0", VA = "0x1874DC1C0")]
	static CDEMDILCJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xBE4DB0", Offset = "0xBE37B0", VA = "0x180BE4DB0")]
	private bool IMDHOEHLBNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74DAE30", Offset = "0x74D9830", VA = "0x1874DAE30")]
	private void JKOMCCIDJKL(IPEndPoint AHNBGGAPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74DA640", Offset = "0x74D9040", VA = "0x1874DA640")]
	private void JAIOHLFJIEG(IPEndPoint AHNBGGAPAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74D8DA0", Offset = "0x74D77A0", VA = "0x1874D8DA0")]
	private bool GLEFKJFLNKF(SocketException HPIGFEEDBKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74D71D0", Offset = "0x74D5BD0", VA = "0x1874D71D0")]
	private void FAELICKILPE(FPIHJIAKLOO CAAPNCHJHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74DBDD0", Offset = "0x74DA7D0", VA = "0x1874DBDD0")]
	private void PDAIFMHKLAA(ANFHAKMNCPI CAAPNCHJHAO, EndPoint PICDNCNMMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74DA7B0", Offset = "0x74D91B0", VA = "0x1874DA7B0")]
	private void JBOLGIGNFHF(object BLKFHFCBEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x74D8FE0", Offset = "0x74D79E0", VA = "0x1874D8FE0")]
	public bool GMHPCBOPLJD(IPAddress IEDKIKFEENE, IPAddress MKNOKJHKAOE, int BLKNFNLBLKN, bool ENBHKFLLIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x74D77A0", Offset = "0x74D61A0", VA = "0x1874D77A0")]
	internal int GGHAANJGOFP(MCIJNONHJOG NKFJGBBKJEE, IPEndPoint LBEDKFILOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x74D65D0", Offset = "0x74D4FD0", VA = "0x1874D65D0")]
	internal int DICAONLLNHK(MCIJNONHJOG NKFJGBBKJEE, IPEndPoint LBEDKFILOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x74D5DF0", Offset = "0x74D47F0", VA = "0x1874D5DF0")]
	internal int DICAONLLNHK(byte[] ONGDPODJNBL, int PAEPPOFDFDK, int KLLLBPFLPCD, IPEndPoint LBEDKFILOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x74D5450", Offset = "0x74D3E50", VA = "0x1874D5450")]
	internal void BLKPMPLKLFL(bool GCCLPODHENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal enum JKJOJPKFIBP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Unreliable,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Channeled,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Ack,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Ping,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Pong,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	ConnectRequest,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ConnectAccept,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Disconnect,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	UnconnectedMessage,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	MtuCheck,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	MtuOk,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Broadcast,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	Merged,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	ShutdownOk,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	PeerNotFound,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	InvalidProtocol,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	NatMessage,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	Empty
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class MCIJNONHJOG
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int EHHPCMFAJBL;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int[] EAAPEOEENKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public byte[] AOOJICDKGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public int LKGECEPPJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public object FMNGCEOIPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public MCIJNONHJOG EILPADPNPDF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JKJOJPKFIBP GKMJJHFHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x74E1AF0", Offset = "0x74E04F0", VA = "0x1874E1AF0")]
		get
		{
			return default(JKJOJPKFIBP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x74E1610", Offset = "0x74E0010", VA = "0x1874E1610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte EPDOHCMHOFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x74E1540", Offset = "0x74DFF40", VA = "0x1874E1540")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x74E1910", Offset = "0x74E0310", VA = "0x1874E1910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ushort ALGKJDLLLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x74E17E0", Offset = "0x74E01E0", VA = "0x1874E17E0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x74E1870", Offset = "0x74E0270", VA = "0x1874E1870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BANNLPNKKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x74E17B0", Offset = "0x74E01B0", VA = "0x1874E17B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public byte FMDOBABNHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x74E1840", Offset = "0x74E0240", VA = "0x1874E1840")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x74E1980", Offset = "0x74E0380", VA = "0x1874E1980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort ILELFFIFDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x74E1570", Offset = "0x74DFF70", VA = "0x1874E1570")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x74E1B20", Offset = "0x74E0520", VA = "0x1874E1B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ushort BNPHHKPIFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x74E18B0", Offset = "0x74E02B0", VA = "0x1874E18B0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x74E15D0", Offset = "0x74DFFD0", VA = "0x1874E15D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ushort MLAJAJJBFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x74E1650", Offset = "0x74E0050", VA = "0x1874E1650")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x74E1AB0", Offset = "0x74E04B0", VA = "0x1874E1AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x74E1B60", Offset = "0x74E0560", VA = "0x1874E1B60")]
	static MCIJNONHJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x74E1950", Offset = "0x74E0350", VA = "0x1874E1950")]
	public void IIFMCELFNJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x74E1E40", Offset = "0x74E0840", VA = "0x1874E1E40")]
	public MCIJNONHJOG(int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x74E1EB0", Offset = "0x74E08B0", VA = "0x1874E1EB0")]
	public MCIJNONHJOG(JKJOJPKFIBP OGFGMDINCKP, int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x74E19B0", Offset = "0x74E03B0", VA = "0x1874E19B0")]
	public static int KAPCCIGKPOI(JKJOJPKFIBP OGFGMDINCKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x74E1A20", Offset = "0x74E0420", VA = "0x1874E1A20")]
	public int KAPCCIGKPOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74E16B0", Offset = "0x74E00B0", VA = "0x1874E16B0")]
	public bool FHGNOPPNNKG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Flags]
public enum JDIOFAKNNAM : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Outgoing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Connected = 4,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	ShutdownRequested = 8,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Disconnected = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	EndPointChange = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Any = 0x2E
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal enum COJNLHAHPFL
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	P2PLose,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Reconnection,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	NewConnection
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum MJFONHLPKJA
{
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal enum ICDDHOEOLEH
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MDPMPMEIPBK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class PBBJNHFMMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public MCIJNONHJOG[] HFAHLFMOCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int GLODHMCIKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int CHNMMHEDNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public byte FMDOBABNHMB;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PBBJNHFMMLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate void BOPAPIELFNB(ulong EMJMEIELGNB, int HCPPNHFEFPE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int PFLCFPLJMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int DHGNKEFHEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int MLLEKMHAGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private double CODEBJPMHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private int GCJCPBBEGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int EBMHHHOJFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int LGLODMHGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly Stopwatch NJJEADMJDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private int FHEFGJKMGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private long BIPCHOIPENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly object HLPDHDMGPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	internal MDPMPMEIPBK OHCDJJJCKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	internal MDPMPMEIPBK EBNOOPDMKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly Queue<MCIJNONHJOG> NJFMDFBMBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly ConcurrentQueue<GMCAHKKJDEJ> ALEJLFMJMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly GMCAHKKJDEJ[] FHCDLFIEMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private int PDGMIMDHBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int IFIPCJDDFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool DFLLFLKMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int KAOLLGEFCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private int JDIGMBBIJNP;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private const int GNGDNLJACJP = 1000;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private const int IAGEJJPFNLM = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly object MLDHDLCBBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IPPJINEINNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private readonly Dictionary<ushort, PBBJNHFMMLL> EPFJHLKHEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Dictionary<ushort, ushort> JCHFGMJDPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly MCIJNONHJOG DGNCNPEOMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int ONNLOLBJNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int FNLJJAEFJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private IPEndPoint JJMAAIFBKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int DCKAHFJJMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private int HCHFHKIJONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private long APBGGDDGJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private byte BMAHJOCHNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private JDIOFAKNNAM NBHJPGCHNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private MCIJNONHJOG HHHAMECPKIN;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private const int OOMBNGDBLHA = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private int GDBPFDEIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly MCIJNONHJOG HJHKDPNCIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly MCIJNONHJOG EBFBCECDGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly MCIJNONHJOG LLEJHOMNAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly MCIJNONHJOG NPECKNNPAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private IIPFFCFIOBA EMCBOIHNAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public readonly CDEMDILCJDP ECIBHDGFKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public readonly int BIKKNIIFDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public object JADAEBBLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly PIDOACOEOME LDMJMNEBFEN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	internal byte NNMKCGDIOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB40670", Offset = "0xB3F070", VA = "0x180B40670")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x74E5AD0", Offset = "0x74E44D0", VA = "0x1874E5AD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IPEndPoint HIHAFMHCBMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB40660", Offset = "0xB3F060", VA = "0x180B40660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public JDIOFAKNNAM PEKBBCPBDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB409F0", Offset = "0xB3F3F0", VA = "0x180B409F0")]
		get
		{
			return default(JDIOFAKNNAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	internal long JLGMIBMBABF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA89E90", Offset = "0xA88890", VA = "0x180A89E90")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int EDNPNJLNIJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x17DC600", Offset = "0x17DB000", VA = "0x1817DC600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x20EE150", Offset = "0x20ECB50", VA = "0x1820EE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int BIOKGHGIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x74E4980", Offset = "0x74E3380", VA = "0x1874E4980")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int ICDFEBJGDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xAF1310", Offset = "0xAEFD10", VA = "0x180AF1310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	internal double ELMBDPEIFBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5059520", Offset = "0x5057F20", VA = "0x185059520")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BOPAPIELFNB AALADJFPJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74E4F60", Offset = "0x74E3960", VA = "0x1874E4F60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74E5A20", Offset = "0x74E4420", VA = "0x1874E5A20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x74E5B80", Offset = "0x74E4580", VA = "0x1874E5B80")]
	internal MDPMPMEIPBK(CDEMDILCJDP IHEPGLLKHBD, IPEndPoint LBEDKFILOMP, int EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x74E3540", Offset = "0x74E1F40", VA = "0x1874E3540")]
	internal void DANPKGDGCME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x74E3EA0", Offset = "0x74E28A0", VA = "0x1874E3EA0")]
	internal void FIBNAKNHAIA(IPEndPoint PPIMJPFIJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x74E34B0", Offset = "0x74E1EB0", VA = "0x1874E34B0")]
	internal void CPKLMMHFOHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x74E3770", Offset = "0x74E2170", VA = "0x1874E3770")]
	private void DJLJABBEAFP(int AHBFPJLNLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x74E4F20", Offset = "0x74E3920", VA = "0x1874E4F20")]
	private void NANNDHHBPEB(int FGCLAODDDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x74E46F0", Offset = "0x74E30F0", VA = "0x1874E46F0")]
	public int IDCJENHMAAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x74E4800", Offset = "0x74E3200", VA = "0x1874E4800")]
	public int IDCJENHMAAO(byte MAANAFMMOCN, bool PICGKMLGAGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x74E4540", Offset = "0x74E2F40", VA = "0x1874E4540")]
	private GMCAHKKJDEJ HOEIPEADLKG(byte LLLLOEKJOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x74E61C0", Offset = "0x74E4BC0", VA = "0x1874E61C0")]
	internal MDPMPMEIPBK(CDEMDILCJDP IHEPGLLKHBD, IPEndPoint LBEDKFILOMP, int EGJGKBPPPFG, byte FHHBJDFOGNL, MIPFOBFCGMI EIAGABIEFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x74E5FE0", Offset = "0x74E49E0", VA = "0x1874E5FE0")]
	internal MDPMPMEIPBK(CDEMDILCJDP IHEPGLLKHBD, JNKBBIALDFK NIBLEOGJBJF, int EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x74E3000", Offset = "0x74E1A00", VA = "0x1874E3000")]
	internal void BBLIJMJKMFP(OHOOHABOPJO LLEGIIBICJE, byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x74E59A0", Offset = "0x74E43A0", VA = "0x1874E59A0")]
	internal bool NOPDGOAGEJD(EABNDBPHFMI NKFJGBBKJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x74E3ED0", Offset = "0x74E28D0", VA = "0x1874E3ED0")]
	public void GPEHLCFJCHC(byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int KLLLBPFLPCD, AOMHBJHJKJO HHMKDMNANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x74E3840", Offset = "0x74E2240", VA = "0x1874E3840")]
	private void ENJIOPMMPAO(byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int KLLLBPFLPCD, byte MAANAFMMOCN, AOMHBJHJKJO FJLBANMBKMK, object KMIHMPGPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x74E3E50", Offset = "0x74E2850", VA = "0x1874E3E50")]
	public void FGLGBKHFALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x74E3F00", Offset = "0x74E2900", VA = "0x1874E3F00")]
	internal MJFONHLPKJA HJCJDECHIBP(MCIJNONHJOG NKFJGBBKJEE)
	{
		return default(MJFONHLPKJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x74E4920", Offset = "0x74E3320", VA = "0x1874E4920")]
	internal void JCJHDMCMPOK(GMCAHKKJDEJ GEBANPLEEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x74E31A0", Offset = "0x74E1BA0", VA = "0x1874E31A0")]
	internal ICDDHOEOLEH CELNCAKHCJF(byte[] GPCDCFCPGFK, int PAEPPOFDFDK, int KLLLBPFLPCD, bool FGLPKBNAEFO)
	{
		return default(ICDDHOEOLEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x74E4D20", Offset = "0x74E3720", VA = "0x1874E4D20")]
	private void MCDDIONIINO(int BAMBBBHMENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x74E5010", Offset = "0x74E3A10", VA = "0x1874E5010")]
	internal void NIJMNKKOJEF(AOMHBJHJKJO LOHNFJJANPK, MCIJNONHJOG DJKLMOIIBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x74E3FE0", Offset = "0x74E29E0", VA = "0x1874E3FE0")]
	private void HLANMBCFKEI(MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x74E4990", Offset = "0x74E3390", VA = "0x1874E4990")]
	private void LMLBNFONCGC(int NIHEEOMEEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x74E4D60", Offset = "0x74E3760", VA = "0x1874E4D60")]
	internal COJNLHAHPFL MNCGIDCFGMJ(OHOOHABOPJO DGALPGKEIOK)
	{
		return default(COJNLHAHPFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x74E2940", Offset = "0x74E1340", VA = "0x1874E2940")]
	internal void AJLEGNDGCEE(MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x74E3050", Offset = "0x74E1A50", VA = "0x1874E3050")]
	private void CDNJLEMBHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x74E3560", Offset = "0x74E1F60", VA = "0x1874E3560")]
	internal void DBNHMOPMMOI(MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x74E2280", Offset = "0x74E0C80", VA = "0x1874E2280")]
	internal void AIICKBIOPNB(int NIHEEOMEEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x74E1FC0", Offset = "0x74E09C0", VA = "0x1874E1FC0")]
	internal void AFKFAMBDJKD(MCIJNONHJOG NKFJGBBKJEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class PIDOACOEOME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private long BKBFLCFMKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private long DCKKAPNDAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private long PILKJBEGIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long OEGFCMDGPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long GDHLPOMHDIJ;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static long NAAEJHDGPOM;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static long LJABMCAKAHK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static long HFPIGPICNCH;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static long CFAHPCMMFND;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static long ICODBOGGOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long JHKKIJPMCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private long KJBHCHGJMOB;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LLNPKHAKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x74E9CF0", Offset = "0x74E86F0", VA = "0x1874E9CF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long IDCNFONFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74E9C80", Offset = "0x74E8680", VA = "0x1874E9C80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long NIJLAEEPHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x74E9D10", Offset = "0x74E8710", VA = "0x1874E9D10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long BHMODJHGGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x74E9F40", Offset = "0x74E8940", VA = "0x1874E9F40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public long GIBFAJBMENE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x74E9F50", Offset = "0x74E8950", VA = "0x1874E9F50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public long KJFHGBJEHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x74E9D00", Offset = "0x74E8700", VA = "0x1874E9D00")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static long MOCCHPNCCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74E9BF0", Offset = "0x74E85F0", VA = "0x1874E9BF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static long FLDKKDKOJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x74EA000", Offset = "0x74E8A00", VA = "0x1874EA000")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private IIPFFCFIOBA CMAAGOFIIHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x13AB4E0", Offset = "0x13A9EE0", VA = "0x1813AB4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public double BBEOELLJENF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x74E9C90", Offset = "0x74E8690", VA = "0x1874E9C90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x74E9BB0", Offset = "0x74E85B0", VA = "0x1874E9BB0")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x74E9D90", Offset = "0x74E8790", VA = "0x1874E9D90")]
	public void HGCJGIDINBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x74E9C30", Offset = "0x74E8630", VA = "0x1874E9C30")]
	public void BNKBDAALEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x74E9ED0", Offset = "0x74E88D0", VA = "0x1874E9ED0")]
	public void LFPPJKMDJKO(long OKCHFIKMOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x74E9D20", Offset = "0x74E8720", VA = "0x1874E9D20")]
	public void GPLLIPLBMBO(long LOEKFHFOJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x74E9E70", Offset = "0x74E8870", VA = "0x1874E9E70")]
	public void KECPDGLLJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x74E9DF0", Offset = "0x74E87F0", VA = "0x1874E9DF0")]
	public void IOEIOKPBKHA(long CEHJPHDGHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x74EA040", Offset = "0x74E8A40", VA = "0x1874EA040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x74E9F60", Offset = "0x74E8960", VA = "0x1874E9F60")]
	public void OPIPLNPMJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public PIDOACOEOME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class EFEBACCAEKB
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly List<string> CBKJGFNIJPN;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x74DDAA0", Offset = "0x74DC4A0", VA = "0x1874DDAA0")]
	public static IPEndPoint HHGHMLMOJGD(string OFFDDBHOOBP, int BLKNFNLBLKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x74DDD80", Offset = "0x74DC780", VA = "0x1874DDD80")]
	public static IPAddress NFLLCALPIND(string OFFDDBHOOBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x74DDCF0", Offset = "0x74DC6F0", VA = "0x1874DDCF0")]
	public static IPAddress NFLLCALPIND(string OFFDDBHOOBP, AddressFamily DKKKBPHHPCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x74DDA70", Offset = "0x74DC470", VA = "0x1874DDA70")]
	internal static int FGAOKGEMEMD(int COLLMKHNLJD, int PJNPFAHFNHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x3ADFC20", Offset = "0x3ADE620", VA = "0x183ADFC20")]
	internal static T[] OBFENPELFON<T>(int CDCPIGCEABM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class OHKJBFPMCHA : GMCAHKKJDEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private struct DMBALJABNGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private MCIJNONHJOG OLJHOOJNKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private long OMPABIFIBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private bool PDIPBPOECEO;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x74DD630", Offset = "0x74DC030", VA = "0x1874DD630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x74DD550", Offset = "0x74DBF50", VA = "0x1874DD550")]
		public void CEKLAJMLNPO(MCIJNONHJOG NKFJGBBKJEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x74DD5C0", Offset = "0x74DBFC0", VA = "0x1874DD5C0")]
		public bool HIAEHBNKDFN(long PBHGDMMKEOO, MDPMPMEIPBK DLAOPMDPLCG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x74DD570", Offset = "0x74DBF70", VA = "0x1874DD570")]
		public bool CHLOADNGFGM(MDPMPMEIPBK DLAOPMDPLCG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly MCIJNONHJOG PHJMBJNHJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private readonly DMBALJABNGP[] DADKKIFEOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly MCIJNONHJOG[] KJBHFGBEIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool[] JJDJBOOEOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private int KGAHEIODGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private int DIKDGCKOKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private int NJBPGHEBKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private int CNOHBPKHILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool FIHANFIAOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly AOMHBJHJKJO KBOGDBHIFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly bool PCMJDCKCCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly int IDMJELCNJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly byte BGAMMCGGJAM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NDCKBKNMLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x74E9060", Offset = "0x74E7A60", VA = "0x1874E9060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x74E9430", Offset = "0x74E7E30", VA = "0x1874E9430")]
	public OHKJBFPMCHA(MDPMPMEIPBK DLAOPMDPLCG, bool PICGKMLGAGE, byte EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x74E9070", Offset = "0x74E7A70", VA = "0x1874E9070")]
	private void MFMCAHBJNNJ(MCIJNONHJOG NKFJGBBKJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x74E8530", Offset = "0x74E6F30", VA = "0x1874E8530", Slot = "4")]
	protected override bool AEDAOCFODKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x74E8A00", Offset = "0x74E7400", VA = "0x1874E8A00", Slot = "5")]
	public override bool AJLEGNDGCEE(MCIJNONHJOG NKFJGBBKJEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class MNOMHJIHAEI : GMCAHKKJDEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int PAHAKJLKNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private ushort DIKDGCKOKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly bool OKENFCMJNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private MCIJNONHJOG NMAPFPCDNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly MCIJNONHJOG CNAKFPIHHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private bool HGKOMOMLHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly byte BGAMMCGGJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private long MDFDIMHECMH;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x74E7940", Offset = "0x74E6340", VA = "0x1874E7940")]
	public MNOMHJIHAEI(MDPMPMEIPBK DLAOPMDPLCG, bool KIMNIHKOKOE, byte EGJGKBPPPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x74E71A0", Offset = "0x74E5BA0", VA = "0x1874E71A0", Slot = "4")]
	protected override bool AEDAOCFODKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x74E7660", Offset = "0x74E6060", VA = "0x1874E7660", Slot = "5")]
	public override bool AJLEGNDGCEE(MCIJNONHJOG NKFJGBBKJEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class FGCIHCBOAFG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct OGNPBPALGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ulong IMCFCPJKFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public double LFLLJGDKNBH;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct HEMLGPOPMKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int GGECIPCBALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float AEHJCDHIOKM;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x74D2150", Offset = "0x74D0B50", VA = "0x1874D2150")]
	private static void IGJIDFAEFCO(byte[] AEJOONCILAD, int KIOPHNHDMKE, ulong GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74DE420", Offset = "0x74DCE20", VA = "0x1874DE420")]
	private static void IGJIDFAEFCO(byte[] AEJOONCILAD, int KIOPHNHDMKE, int GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x74DE3E0", Offset = "0x74DCDE0", VA = "0x1874DE3E0")]
	public static void IGJIDFAEFCO(byte[] AEJOONCILAD, int KIOPHNHDMKE, short GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x74DE520", Offset = "0x74DCF20", VA = "0x1874DE520")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, double PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x74DE4A0", Offset = "0x74DCEA0", VA = "0x1874DE4A0")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x74DE3E0", Offset = "0x74DCDE0", VA = "0x1874DE3E0")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, short PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x74DE3E0", Offset = "0x74DCDE0", VA = "0x1874DE3E0")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, ushort PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x74DE420", Offset = "0x74DCE20", VA = "0x1874DE420")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x74DE420", Offset = "0x74DCE20", VA = "0x1874DE420")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, uint PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x74DE490", Offset = "0x74DCE90", VA = "0x1874DE490")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x74DE490", Offset = "0x74DCE90", VA = "0x1874DE490")]
	public static void JAMJLEOKAEB(byte[] LHALFHPGBPD, int EMMDOKDGNJD, ulong PDKJBMPOMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CODKNAIBEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	protected byte[] GOKKGMDJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected int FNMOFJHBJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected int FKIHCBFGHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private int ALELGNIIGAM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public byte[] AOOJICDKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int HPDBHHDDAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MFPGJHNBBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x74DD160", Offset = "0x74DBB60", VA = "0x1874DD160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool OKNCBGPKPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2933FC0", Offset = "0x29329C0", VA = "0x182933FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OMJDFIPKFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x74DCFF0", Offset = "0x74DB9F0", VA = "0x1874DCFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x74DCB10", Offset = "0x74DB510", VA = "0x1874DCB10")]
	public void COHBLEFJAJG(byte[] PEIDNFHKHFH, int KIOPHNHDMKE, int NBGGNKOHCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
	public CODKNAIBEBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74DD4F0", Offset = "0x74DBEF0", VA = "0x1874DD4F0")]
	public CODKNAIBEBE(byte[] PEIDNFHKHFH, int KIOPHNHDMKE, int NBGGNKOHCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x74DD1B0", Offset = "0x74DBBB0", VA = "0x1874DD1B0")]
	public IPEndPoint NBIHBLJONHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x74DC9D0", Offset = "0x74DB3D0", VA = "0x1874DC9D0")]
	public byte OGMBKFIIIDC()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x74DC9D0", Offset = "0x74DB3D0", VA = "0x1874DC9D0")]
	public sbyte CDHGMEMCANI()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E530", Offset = "0x3A6CF30", VA = "0x183A6E530")]
	public T[] PPOLIKJKMMF<T>(ushort CGAAPEOHPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x74DD170", Offset = "0x74DBB70", VA = "0x1874DD170")]
	public bool[] MNOLEFMAOHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x74DC920", Offset = "0x74DB320", VA = "0x1874DC920")]
	public ushort[] BOCJEJPIACH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x74DD4B0", Offset = "0x74DBEB0", VA = "0x1874DD4B0")]
	public short[] PKEDNHIHKDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x74DC8E0", Offset = "0x74DB2E0", VA = "0x1874DC8E0")]
	public int[] BFPPFPFGNLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x74DCC40", Offset = "0x74DB640", VA = "0x1874DCC40")]
	public uint[] EMLKMNBOPGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x74DCB90", Offset = "0x74DB590", VA = "0x1874DCB90")]
	public float[] DPGLLFABOML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x74DD070", Offset = "0x74DBA70", VA = "0x1874DD070")]
	public double[] JOOGDGDJLDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x74DCF40", Offset = "0x74DB940", VA = "0x1874DCF40")]
	public long[] IAPNHBJNCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x74DCEC0", Offset = "0x74DB8C0", VA = "0x1874DCEC0")]
	public ulong[] HJLAGJCJNMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x74DD280", Offset = "0x74DBC80", VA = "0x1874DD280")]
	public string[] NBJJCOGPBGA(int KACLBKBODFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x74DCF00", Offset = "0x74DB900", VA = "0x1874DCF00")]
	public bool HODKOHLDACP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x74DC960", Offset = "0x74DB360", VA = "0x1874DC960")]
	public char CBJDGBGHAAJ()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x74DC960", Offset = "0x74DB360", VA = "0x1874DC960")]
	public ushort OHMJHOKOIBC()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x74DD440", Offset = "0x74DBE40", VA = "0x1874DD440")]
	public short OELOGCKCGBN()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA10", Offset = "0x74DB410", VA = "0x1874DCA10")]
	public long CEHJJBBJMNO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x74DCAA0", Offset = "0x74DB4A0", VA = "0x1874DCAA0")]
	public ulong CKMMHOJMNAA()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x74DD3D0", Offset = "0x74DBDD0", VA = "0x1874DD3D0")]
	public int NJDDPOFMJHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x74DCBD0", Offset = "0x74DB5D0", VA = "0x1874DCBD0")]
	public uint EICIHCOBODE()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x74DCF80", Offset = "0x74DB980", VA = "0x1874DCF80")]
	public float IBMLFBEBEJA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x74DD000", Offset = "0x74DBA00", VA = "0x1874DD000")]
	public double JHKJBFCPMIB()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x74DCC80", Offset = "0x74DB680", VA = "0x1874DCC80")]
	public string GMGJFPIHJPF(int OFPHGCJEELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x74DD0B0", Offset = "0x74DBAB0", VA = "0x1874DD0B0")]
	public ArraySegment<byte> KKJMFIPINGA(int CDCPIGCEABM)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x74DCB50", Offset = "0x74DB550", VA = "0x1874DCB50")]
	public sbyte[] DCJEOLCJMLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x74DD120", Offset = "0x74DBB20", VA = "0x1874DD120")]
	public byte[] LCMAONLGBCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA80", Offset = "0x74DB480", VA = "0x1874DCA80")]
	public void CHLOADNGFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class MIPFOBFCGMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	protected byte[] GOKKGMDJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	protected int FNMOFJHBJCA;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private const int OHCHKMJLHLL = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly bool PAKJPAJAJHE;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly UTF8Encoding NKMDMFBLOEJ;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public const int AGACBPJLNDO = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly byte[] LLBGPPOLNOB;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public byte[] AKBOOJDMDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NOMMIDHMEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5C0", Offset = "0xA8CFC0", VA = "0x180A8E5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x74E7120", Offset = "0x74E5B20", VA = "0x1874E7120")]
	public MIPFOBFCGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x74E7080", Offset = "0x74E5A80", VA = "0x1874E7080")]
	public MIPFOBFCGMI(bool MLOLHIHPDLI, int JBLJCGFDHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x74E6F80", Offset = "0x74E5980", VA = "0x1874E6F80")]
	public static MIPFOBFCGMI NEODOHOBBKA(string PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74E6EE0", Offset = "0x74E58E0", VA = "0x1874E6EE0")]
	public void IHAODKJJDPO(int MIHPKDHPDIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x29AD730", Offset = "0x29AC130", VA = "0x1829AD730")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x74E6660", Offset = "0x74E5060", VA = "0x1874E6660")]
	public void EFBLBOAHMEG(float PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x74E6760", Offset = "0x74E5160", VA = "0x1874E6760")]
	public void EFBLBOAHMEG(double PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x74E6960", Offset = "0x74E5360", VA = "0x1874E6960")]
	public void EFBLBOAHMEG(long PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x74E6960", Offset = "0x74E5360", VA = "0x1874E6960")]
	public void EFBLBOAHMEG(ulong PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x74E65D0", Offset = "0x74E4FD0", VA = "0x1874E65D0")]
	public void EFBLBOAHMEG(int PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x74E65D0", Offset = "0x74E4FD0", VA = "0x1874E65D0")]
	public void EFBLBOAHMEG(uint PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x74E6560", Offset = "0x74E4F60", VA = "0x1874E6560")]
	public void EFBLBOAHMEG(char PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x74E6560", Offset = "0x74E4F60", VA = "0x1874E6560")]
	public void EFBLBOAHMEG(ushort PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x74E6560", Offset = "0x74E4F60", VA = "0x1874E6560")]
	public void EFBLBOAHMEG(short PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x74E67B0", Offset = "0x74E51B0", VA = "0x1874E67B0")]
	public void EFBLBOAHMEG(sbyte PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x74E67B0", Offset = "0x74E51B0", VA = "0x1874E67B0")]
	public void EFBLBOAHMEG(byte PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x74E6810", Offset = "0x74E5210", VA = "0x1874E6810")]
	public void EFBLBOAHMEG(byte[] GPCDCFCPGFK, int KIOPHNHDMKE, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x74E6E00", Offset = "0x74E5800", VA = "0x1874E6E00")]
	public void GALCGCJEJIC(sbyte[] GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x74E6E00", Offset = "0x74E5800", VA = "0x1874E6E00")]
	public void KPEFNBEJICN(byte[] GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x74E6700", Offset = "0x74E5100", VA = "0x1874E6700")]
	public void EFBLBOAHMEG(bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x74E6D20", Offset = "0x74E5720", VA = "0x1874E6D20")]
	public void FEPAPENHMLE(Array LDAMGPGPNCL, int CBJFBLHLELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x74E69B0", Offset = "0x74E53B0", VA = "0x1874E69B0")]
	public void FEPAPENHMLE(float[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x74E6B70", Offset = "0x74E5570", VA = "0x1874E6B70")]
	public void FEPAPENHMLE(double[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x74E6B70", Offset = "0x74E5570", VA = "0x1874E6B70")]
	public void FEPAPENHMLE(long[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x74E6B70", Offset = "0x74E5570", VA = "0x1874E6B70")]
	public void FEPAPENHMLE(ulong[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x74E69B0", Offset = "0x74E53B0", VA = "0x1874E69B0")]
	public void FEPAPENHMLE(int[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x74E69B0", Offset = "0x74E53B0", VA = "0x1874E69B0")]
	public void FEPAPENHMLE(uint[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x74E6A90", Offset = "0x74E5490", VA = "0x1874E6A90")]
	public void FEPAPENHMLE(ushort[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x74E6A90", Offset = "0x74E5490", VA = "0x1874E6A90")]
	public void FEPAPENHMLE(short[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x74E6E00", Offset = "0x74E5800", VA = "0x1874E6E00")]
	public void FEPAPENHMLE(bool[] PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x74E6C50", Offset = "0x74E5650", VA = "0x1874E6C50")]
	public void FEPAPENHMLE(string[] PDKJBMPOMNC, int LONGLNHEKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x74E6880", Offset = "0x74E5280", VA = "0x1874E6880")]
	public void EFBLBOAHMEG(IPEndPoint PCDDCAGCLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x74E6950", Offset = "0x74E5350", VA = "0x1874E6950")]
	public void EFBLBOAHMEG(string PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x74E6350", Offset = "0x74E4D50", VA = "0x1874E6350")]
	public void EFBLBOAHMEG(string PDKJBMPOMNC, int OFPHGCJEELB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class AHGODCKIHGL
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	private static class AHMPPENPODI<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly ulong BIKKNIIFDAP;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x52419A0", Offset = "0x52403A0", VA = "0x1852419A0")]
		static AHMPPENPODI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	protected delegate void FHAGBOCLDPK(CODKNAIBEBE IOMONBOBJAC, object KMIHMPGPMOB);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class GKIGJNGCLDD<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AHGODCKIHGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GKIGJNGCLDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4FAEF50", Offset = "0x4FAD950", VA = "0x184FAEF50")]
		internal void LLKJEKMFOGJ(CODKNAIBEBE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class GBKIELGHFMH<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AHGODCKIHGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public GBKIELGHFMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4F42570", Offset = "0x4F40F70", VA = "0x184F42570")]
		internal void LLKJEKMFOGJ(CODKNAIBEBE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly MNOMMOFFNMC OHFMOPPDAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly Dictionary<ulong, FHAGBOCLDPK> GGDPENFMKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly MIPFOBFCGMI JNNCCPEJBKD;

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x74D2930", Offset = "0x74D1330", VA = "0x1874D2930")]
	public AHGODCKIHGL(int KACLBKBODFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x31BF170", Offset = "0x31BDB70", VA = "0x1831BF170", Slot = "4")]
	protected virtual ulong JDIHCNBBCGI<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x74D27B0", Offset = "0x74D11B0", VA = "0x1874D27B0", Slot = "5")]
	protected virtual FHAGBOCLDPK LEJCPNPMGFA(CODKNAIBEBE IOMONBOBJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x31CA180", Offset = "0x31C8B80", VA = "0x1831CA180", Slot = "6")]
	protected virtual void NNJJMOGDALJ<T>(MIPFOBFCGMI ADMHNJGGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x74D2730", Offset = "0x74D1130", VA = "0x1874D2730")]
	public void KEIDPJPEBGK(CODKNAIBEBE IOMONBOBJAC, object KMIHMPGPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x31CA4F0", Offset = "0x31C8EF0", VA = "0x1831CA4F0")]
	public void PHAKNALBEIB<T>(MIPFOBFCGMI ADMHNJGGGLG, T NKFJGBBKJEE) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x74D28E0", Offset = "0x74D12E0", VA = "0x1874D28E0")]
	public void NCGIIFBKEOC(CODKNAIBEBE IOMONBOBJAC, object KMIHMPGPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x31CA370", Offset = "0x31C8D70", VA = "0x1831CA370")]
	public void NPKOFAFELJH<T>(Action<T> DNCNDCAHGMC) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x31CA1F0", Offset = "0x31C8BF0", VA = "0x1831CA1F0")]
	public void NPKOFAFELJH<T, TUserData>(Action<T, TUserData> DNCNDCAHGMC) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class DMNAPBIJNDD : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x74DD6D0", Offset = "0x74DC0D0", VA = "0x1874DD6D0")]
	public DMNAPBIJNDD(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NOJEIELGKJD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x74E84D0", Offset = "0x74E6ED0", VA = "0x1874E84D0")]
	public NOJEIELGKJD(string ONGDPODJNBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class MNOMMOFFNMC
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private enum ABOFAOIMKAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class COHEMLCPFEG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public ABOFAOIMKAB MMPEDFAPIKH;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DFA0", Offset = "0x6A4C9A0", VA = "0x186A4DFA0", Slot = "4")]
		public virtual void CEKLAJMLNPO(MethodInfo NHOCPMEOJBL, MethodInfo GIFGNMODEJL, ABOFAOIMKAB AEOGKDPPBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID);

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP);

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void JOEHADEFDBA(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void PJINKPPBBEN(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		protected COHEMLCPFEG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class NAEGJBBCPAP<TClass, TProperty> : COHEMLCPFEG<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected Func<TClass, TProperty> PPLOBKEJLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected Action<TClass, TProperty> PNIEHJOMHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		protected Func<TClass, TProperty[]> FLKDNLPIPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		protected Action<TClass, TProperty[]> GIEIOJKLCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		protected Func<TClass, List<TProperty>> KPIIPEBCLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		protected Action<TClass, List<TProperty>> PDCMCLHPHPH;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x5898F50", Offset = "0x5897950", VA = "0x185898F50", Slot = "7")]
		public override void FCMIPJBEKJO(TClass GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x589A5C0", Offset = "0x5898FC0", VA = "0x18589A5C0", Slot = "8")]
		public override void LJMNIELADOO(TClass GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5899A60", Offset = "0x5898460", VA = "0x185899A60", Slot = "9")]
		public override void JOEHADEFDBA(TClass GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x589AF60", Offset = "0x5899960", VA = "0x18589AF60", Slot = "10")]
		public override void PJINKPPBBEN(TClass GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x58995E0", Offset = "0x5897FE0", VA = "0x1858995E0")]
		protected TProperty[] ICFHLIDNMDB(TClass GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x5899570", Offset = "0x5897F70", VA = "0x185899570")]
		protected TProperty[] GHOFKNOJNGG(TClass GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x5894510", Offset = "0x5892F10", VA = "0x185894510", Slot = "4")]
		public override void CEKLAJMLNPO(MethodInfo NHOCPMEOJBL, MethodInfo GIFGNMODEJL, ABOFAOIMKAB AEOGKDPPBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x589B900", Offset = "0x589A300", VA = "0x18589B900")]
		protected NAEGJBBCPAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private abstract class EFJLKPBBHDO<TClass, TProperty> : NAEGJBBCPAP<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void CGFPGONMIKI(CODKNAIBEBE PENFKHFIGID, [Out] TProperty BJGDCNAMNKA);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void JLBJIDEGNPO(MIPFOBFCGMI CINPCLDHBLP, TProperty BJGDCNAMNKA);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x492DBA0", Offset = "0x492C5A0", VA = "0x18492DBA0", Slot = "5")]
		public override void KBLLOONDKCE(TClass GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x492DDE0", Offset = "0x492C7E0", VA = "0x18492DDE0", Slot = "6")]
		public override void PHAKNALBEIB(TClass GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x492DA60", Offset = "0x492C460", VA = "0x18492DA60", Slot = "7")]
		public override void FCMIPJBEKJO(TClass GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x492DCA0", Offset = "0x492C6A0", VA = "0x18492DCA0", Slot = "8")]
		public override void LJMNIELADOO(TClass GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x492DEC0", Offset = "0x492C8C0", VA = "0x18492DEC0")]
		protected EFJLKPBBHDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class MEHIPNHNKNE<T> : NAEGJBBCPAP<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5812970", Offset = "0x5811370", VA = "0x185812970", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x561B010", Offset = "0x5619A10", VA = "0x18561B010", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5812900", Offset = "0x5811300", VA = "0x185812900", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x561AFB0", Offset = "0x56199B0", VA = "0x18561AFB0", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public MEHIPNHNKNE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class LLNBFDDNFPJ<T> : NAEGJBBCPAP<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x561AF40", Offset = "0x5619940", VA = "0x18561AF40", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x561B010", Offset = "0x5619A10", VA = "0x18561B010", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x561AED0", Offset = "0x56198D0", VA = "0x18561AED0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x561AFB0", Offset = "0x56199B0", VA = "0x18561AFB0", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public LLNBFDDNFPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class AMLOKDALAOE<T> : NAEGJBBCPAP<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5316E10", Offset = "0x5315810", VA = "0x185316E10", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5316EE0", Offset = "0x53158E0", VA = "0x185316EE0", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5316DA0", Offset = "0x53157A0", VA = "0x185316DA0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5316E80", Offset = "0x5315880", VA = "0x185316E80", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public AMLOKDALAOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class KODKAIKNJKM<T> : NAEGJBBCPAP<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x55090E0", Offset = "0x5507AE0", VA = "0x1855090E0", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5316EE0", Offset = "0x53158E0", VA = "0x185316EE0", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5509070", Offset = "0x5507A70", VA = "0x185509070", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5316E80", Offset = "0x5315880", VA = "0x185316E80", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public KODKAIKNJKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FJONDGGGNMN<T> : NAEGJBBCPAP<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4E175E0", Offset = "0x4E15FE0", VA = "0x184E175E0", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4E176B0", Offset = "0x4E160B0", VA = "0x184E176B0", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4E17570", Offset = "0x4E15F70", VA = "0x184E17570", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4E17650", Offset = "0x4E16050", VA = "0x184E17650", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public FJONDGGGNMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class CMFPNLPECIJ<T> : NAEGJBBCPAP<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A49370", Offset = "0x6A47D70", VA = "0x186A49370", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4E176B0", Offset = "0x4E160B0", VA = "0x184E176B0", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A49300", Offset = "0x6A47D00", VA = "0x186A49300", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4E17650", Offset = "0x4E16050", VA = "0x184E17650", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public CMFPNLPECIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class PJBODHLCDHJ<T> : NAEGJBBCPAP<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B470", Offset = "0x4E09E70", VA = "0x184E0B470", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B540", Offset = "0x4E09F40", VA = "0x184E0B540", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5B1CCD0", Offset = "0x5B1B6D0", VA = "0x185B1CCD0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B4E0", Offset = "0x4E09EE0", VA = "0x184E0B4E0", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public PJBODHLCDHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class FHNMIPBNJGJ<T> : NAEGJBBCPAP<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B470", Offset = "0x4E09E70", VA = "0x184E0B470", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B540", Offset = "0x4E09F40", VA = "0x184E0B540", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B400", Offset = "0x4E09E00", VA = "0x184E0B400", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B4E0", Offset = "0x4E09EE0", VA = "0x184E0B4E0", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public FHNMIPBNJGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class MMBEEIKPGLM<T> : NAEGJBBCPAP<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x583B810", Offset = "0x583A210", VA = "0x18583B810", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x583B880", Offset = "0x583A280", VA = "0x18583B880", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x583B7A0", Offset = "0x583A1A0", VA = "0x18583B7A0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x561AFB0", Offset = "0x56199B0", VA = "0x18561AFB0", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public MMBEEIKPGLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class GEGOANEPGFA<T> : NAEGJBBCPAP<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x4F54110", Offset = "0x4F52B10", VA = "0x184F54110", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4F54180", Offset = "0x4F52B80", VA = "0x184F54180", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4F540A0", Offset = "0x4F52AA0", VA = "0x184F540A0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E17650", Offset = "0x4E16050", VA = "0x184E17650", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public GEGOANEPGFA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class CGOCHJDLJPD<T> : NAEGJBBCPAP<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A37840", Offset = "0x6A36240", VA = "0x186A37840", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6A378B0", Offset = "0x6A362B0", VA = "0x186A378B0", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6A377D0", Offset = "0x6A361D0", VA = "0x186A377D0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x4E0B4E0", Offset = "0x4E09EE0", VA = "0x184E0B4E0", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x48FDC10", Offset = "0x48FC610", VA = "0x1848FDC10")]
		public CGOCHJDLJPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class IPLEILMJBDK<T> : EFJLKPBBHDO<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x517FF70", Offset = "0x517E970", VA = "0x18517FF70", Slot = "12")]
		protected override void JLBJIDEGNPO(MIPFOBFCGMI CINPCLDHBLP, char BJGDCNAMNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x517FF40", Offset = "0x517E940", VA = "0x18517FF40", Slot = "11")]
		protected override void CGFPGONMIKI(CODKNAIBEBE PENFKHFIGID, [Out] char BJGDCNAMNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
		public IPLEILMJBDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class OFOOIFJDJLP<T> : EFJLKPBBHDO<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5A00530", Offset = "0x59FEF30", VA = "0x185A00530", Slot = "12")]
		protected override void JLBJIDEGNPO(MIPFOBFCGMI CINPCLDHBLP, IPEndPoint BJGDCNAMNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5A004F0", Offset = "0x59FEEF0", VA = "0x185A004F0", Slot = "11")]
		protected override void CGFPGONMIKI(CODKNAIBEBE PENFKHFIGID, [Out] IPEndPoint BJGDCNAMNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x48D4670", Offset = "0x48D3070", VA = "0x1848D4670")]
		public OFOOIFJDJLP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class NCANENEPBAB<T> : NAEGJBBCPAP<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private readonly int KKABILHICIH;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x58A3BE0", Offset = "0x58A25E0", VA = "0x1858A3BE0")]
		public NCANENEPBAB(int OFPHGCJEELB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x58A3A90", Offset = "0x58A2490", VA = "0x1858A3A90", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x58A3B70", Offset = "0x58A2570", VA = "0x1858A3B70", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x58A3A20", Offset = "0x58A2420", VA = "0x1858A3A20", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x58A3B00", Offset = "0x58A2500", VA = "0x1858A3B00", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class GCDCEHKNFJA<T> : COHEMLCPFEG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		protected readonly PropertyInfo GKMJJHFHOCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		protected readonly Type DKIFNAFPJFG;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4F44EA0", Offset = "0x4F438A0", VA = "0x184F44EA0")]
		public GCDCEHKNFJA(PropertyInfo OGFGMDINCKP, Type LFONINCANLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x4F44C70", Offset = "0x4F43670", VA = "0x184F44C70", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x4F44D90", Offset = "0x4F43790", VA = "0x184F44D90", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4F44BB0", Offset = "0x4F435B0", VA = "0x184F44BB0", Slot = "7")]
		public override void FCMIPJBEKJO(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x4F44D30", Offset = "0x4F43730", VA = "0x184F44D30", Slot = "8")]
		public override void LJMNIELADOO(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F44C10", Offset = "0x4F43610", VA = "0x184F44C10", Slot = "9")]
		public override void JOEHADEFDBA(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F44E40", Offset = "0x4F43840", VA = "0x184F44E40", Slot = "10")]
		public override void PJINKPPBBEN(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private class FMOLCEMPDBO<T> : GCDCEHKNFJA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x491B8A0", Offset = "0x491A2A0", VA = "0x18491B8A0")]
		public FMOLCEMPDBO(PropertyInfo OGFGMDINCKP, Type LFONINCANLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4E34510", Offset = "0x4E32F10", VA = "0x184E34510", Slot = "5")]
		public override void KBLLOONDKCE(T GDHNGJFBEIB, CODKNAIBEBE PENFKHFIGID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x4E345D0", Offset = "0x4E32FD0", VA = "0x184E345D0", Slot = "6")]
		public override void PHAKNALBEIB(T GDHNGJFBEIB, MIPFOBFCGMI CINPCLDHBLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private sealed class PCJOAHDHCPK<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static PCJOAHDHCPK<T> NDAIDGNOFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly COHEMLCPFEG<T>[] AIPKMICICMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly int JGIIIBBHPML;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD400", Offset = "0x5AFBE00", VA = "0x185AFD400")]
		public PCJOAHDHCPK(List<COHEMLCPFEG<T>> KFCEFHAGAOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD350", Offset = "0x5AFBD50", VA = "0x185AFD350")]
		public void PHAKNALBEIB(T CEFJEHJNIAP, MIPFOBFCGMI ADMHNJGGGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5AFD2A0", Offset = "0x5AFBCA0", VA = "0x185AFD2A0")]
		public void KBLLOONDKCE(T CEFJEHJNIAP, CODKNAIBEBE IOMONBOBJAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private abstract class NFPMBOMHOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract COHEMLCPFEG<T> DHBICMHDGKM<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private MIPFOBFCGMI GJKJBEIECHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly int DLAKJPPGBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly Dictionary<Type, NFPMBOMHOMP> CDFEFMKJLMK;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x74E7A00", Offset = "0x74E6400", VA = "0x1874E7A00")]
	public MNOMMOFFNMC(int KACLBKBODFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5580", Offset = "0x3DB3F80", VA = "0x183DB5580")]
	private PCJOAHDHCPK<T> JJAFPDKIDNH<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE0560", Offset = "0x3ADEF60", VA = "0x183AE0560")]
	public void MAJNBNPDEEJ<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3DB5500", Offset = "0x3DB3F00", VA = "0x183DB5500")]
	public bool JBBKNKCPLNK<T>(CODKNAIBEBE IOMONBOBJAC, T IMFCAPGBDGB) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3DB54A0", Offset = "0x3DB3EA0", VA = "0x183DB54A0")]
	public void AGNKEKDJGCC<T>(MIPFOBFCGMI ADMHNJGGGLG, T CEFJEHJNIAP) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class AOEADLCKOAE
{
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private static readonly DateTime PAONPCMLLFB;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public byte[] EBDHHMPGCDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA86490", Offset = "0xA84E90", VA = "0x180A86490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public KLEGOFDMHKF EBGCCFPBNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x74D3E00", Offset = "0x74D2800", VA = "0x1874D3E00")]
		get
		{
			return default(KLEGOFDMHKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int HFCJGHGDFIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x74D4420", Offset = "0x74D2E20", VA = "0x1874D4420")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x74D3C80", Offset = "0x74D2680", VA = "0x1874D3C80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public CPLADFABMNO NJCNLKCAINL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x74D3550", Offset = "0x74D1F50", VA = "0x1874D3550")]
		get
		{
			return default(CPLADFABMNO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x74D3510", Offset = "0x74D1F10", VA = "0x1874D3510")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int HDIPMEAIEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x74D3E30", Offset = "0x74D2830", VA = "0x1874D3E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public uint CJLDBKBADKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x74D3D80", Offset = "0x74D2780", VA = "0x1874D3D80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? ACNEJFBIIME
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x74D3B30", Offset = "0x74D2530", VA = "0x1874D3B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime? JIELDJPPPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x74D4450", Offset = "0x74D2E50", VA = "0x1874D4450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTime? ICCPNLDDEDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x74D3CC0", Offset = "0x74D26C0", VA = "0x1874D3CC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x74D3580", Offset = "0x74D1F80", VA = "0x1874D3580")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DateTime? BKKKKBABBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xD5CF80", Offset = "0xD5B980", VA = "0x180D5CF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xF32710", Offset = "0xF31110", VA = "0x180F32710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x74D44E0", Offset = "0x74D2EE0", VA = "0x1874D44E0")]
	public AOEADLCKOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x74D4800", Offset = "0x74D3200", VA = "0x1874D4800")]
	internal AOEADLCKOAE(byte[] LHALFHPGBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x74D3F30", Offset = "0x74D2930", VA = "0x1874D3F30")]
	public static AOEADLCKOAE MHPEEJNMOLI(byte[] LHALFHPGBPD, DateTime PHFHKFPCFDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x74D3750", Offset = "0x74D2150", VA = "0x1874D3750")]
	internal void BCFKMGCGNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x74D3950", Offset = "0x74D2350", VA = "0x1874D3950")]
	private void BDDLJMECEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x74D4050", Offset = "0x74D2A50", VA = "0x1874D4050")]
	private DateTime? MNLNFICAGED(int KIOPHNHDMKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x74D4250", Offset = "0x74D2C50", VA = "0x1874D4250")]
	private void OCHIJBJAGFD(int KIOPHNHDMKE, DateTime? PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x74D3E60", Offset = "0x74D2860", VA = "0x1874D3E60")]
	private ulong MHCFJAPCIOL(int KIOPHNHDMKE)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x74D3BC0", Offset = "0x74D25C0", VA = "0x1874D3BC0")]
	private void EFNFIJOHDGO(int KIOPHNHDMKE, ulong PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x74D3CF0", Offset = "0x74D26F0", VA = "0x1874D3CF0")]
	private uint HBAJHGEBPOE(int KIOPHNHDMKE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x739DA50", Offset = "0x739C450", VA = "0x18739DA50")]
	private static uint CKEMCJILBDO(uint IECENJOJFJH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x74D3B60", Offset = "0x74D2560", VA = "0x1874D3B60")]
	private static ulong CKEMCJILBDO(ulong IECENJOJFJH)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum KLEGOFDMHKF
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	NoWarning,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	LastMinuteHas61Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	LastMinuteHas59Seconds,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	AlarmCondition
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum CPLADFABMNO
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class LAGHKMDJHKK
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private const int FJCPIKLNDOH = 1000;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private const int FAACNDGFJLL = 10000;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public const int NAJKFLGNMGD = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly IPEndPoint MDJBMJNBHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private int CFGJNADAEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private int LEJEDDFIKIM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FAOIMHGJKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x74DF520", Offset = "0x74DDF20", VA = "0x1874DF520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x74DF430", Offset = "0x74DDE30", VA = "0x1874DF430")]
	public bool GPEHLCFJCHC(ANFHAKMNCPI CAAPNCHJHAO, int FPIFKAOGCDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal class NIJDAPFHANH : ANFHAKMNCPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Socket CAAPNCHJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly CDEMDILCJDP IHEPGLLKHBD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public short EMFPNHDFKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x74E7DC0", Offset = "0x74E67C0", VA = "0x1874E7DC0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int INOHNFDMGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x74E8400", Offset = "0x74E6E00", VA = "0x1874E8400", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EndPoint PDDKPAEJHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x74E7DA0", Offset = "0x74E67A0", VA = "0x1874E7DA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public AddressFamily DCFLJMOIAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x556D7B0", Offset = "0x556C1B0", VA = "0x18556D7B0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x74E8420", Offset = "0x74E6E20", VA = "0x1874E8420")]
	public NIJDAPFHANH(AddressFamily DKKKBPHHPCL, CDEMDILCJDP IHEPGLLKHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x74E7DE0", Offset = "0x74E67E0", VA = "0x1874E7DE0", Slot = "8")]
	public bool FGOPOJKEGBE(IPEndPoint PCDDCAGCLHJ, FMMPLOJOBMP KOGPLNGOLNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x74E83A0", Offset = "0x74E6DA0", VA = "0x1874E83A0", Slot = "9")]
	public int FODPCOIBOAA(byte[] AEJOONCILAD, int KIOPHNHDMKE, int CGAAPEOHPIP, IPEndPoint LBEDKFILOMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x74E7CB0", Offset = "0x74E66B0", VA = "0x1874E7CB0", Slot = "10")]
	public int BELKFOGIDDE(byte[] AEJOONCILAD, EndPoint LEPHGJCEMFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x74E83E0", Offset = "0x74E6DE0", VA = "0x1874E83E0", Slot = "11")]
	public void LNLAAJILGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal interface ANFHAKMNCPI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	short EMFPNHDFKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int INOHNFDMGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	EndPoint PDDKPAEJHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AddressFamily DCFLJMOIAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FGOPOJKEGBE(IPEndPoint PCDDCAGCLHJ, FMMPLOJOBMP KOGPLNGOLNK);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int FODPCOIBOAA(byte[] AEJOONCILAD, int KIOPHNHDMKE, int CGAAPEOHPIP, IPEndPoint LBEDKFILOMP);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int BELKFOGIDDE(byte[] AEJOONCILAD, EndPoint LBEDKFILOMP);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LNLAAJILGAM();
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal readonly struct PMLGBGFLIEB : IEquatable<PMLGBGFLIEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly long HLANJIICOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly long DNHENFLDKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly long ALFLEPLKNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly int MHMDFMGFLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly int PECFHHLIDKI;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x74EA780", Offset = "0x74E9180", VA = "0x1874EA780")]
	public PMLGBGFLIEB(byte[] KINAHJPOBLI, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x74EA510", Offset = "0x74E8F10", VA = "0x1874EA510")]
	public PMLGBGFLIEB(Span<byte> KINAHJPOBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAC950", VA = "0x180AADF50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x74EA420", Offset = "0x74E8E20", VA = "0x1874EA420", Slot = "4")]
	public bool Equals(PMLGBGFLIEB EFNHKCDKOGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x74EA460", Offset = "0x74E8E60", VA = "0x1874EA460", Slot = "0")]
	public override bool Equals(object CEFJEHJNIAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class FBFHIONLNEF : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public readonly byte[] GFMNPMAEBEP;
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FPIHJIAKLOO
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal delegate void BLPBGDBIAEG(IPEndPoint KINAHJPOBLI, Span<byte> GPCDCFCPGFK);

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private const string CJFIPLLJLFM = "server_socket";

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private const int PIOOFGBFNOH = 16;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private const int PAHDCCGEGJO = 28;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private const int DFEDDNHPBHK = 1024;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static Dictionary<PMLGBGFLIEB, IPEndPoint> PPOJEKNGBDH;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static BLPBGDBIAEG IDJIPHCFBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private int EJAOIGENHLG;

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	internal void BAPMBCPJNDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
	internal void EOLJPJDJBAL(IPEndPoint LBEDKFILOMP, Span<byte> GPCDCFCPGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class HIADFHCCGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public readonly int HBHIJGGHIEP;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xA8AF50", Offset = "0xA89950", VA = "0x180A8AF50")]
	protected HIADFHCCGCK(int CLLKMGODKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LDJCJAOGPDB(IPEndPoint PCDDCAGCLHJ, byte[] GPCDCFCPGFK, int KIOPHNHDMKE, int KLLLBPFLPCD);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void AEFLAFKKHBN(IPEndPoint PCDDCAGCLHJ, byte[] GPCDCFCPGFK, int KIOPHNHDMKE, int KLLLBPFLPCD);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class GIDNPLLBIGO : HIADFHCCGCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private byte[] LNBCHJPEENA;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly RandomNumberGenerator GLAECFEJANE;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x2A8D300", Offset = "0x2A8BD00", VA = "0x182A8D300")]
	public GIDNPLLBIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x74DEEB0", Offset = "0x74DD8B0", VA = "0x1874DEEB0")]
	public void PEOELPIJFIA(IPEndPoint PCDDCAGCLHJ, byte[] LNBCHJPEENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x74DE920", Offset = "0x74DD320", VA = "0x1874DE920")]
	public void IEMCJMPBBLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x74DEA00", Offset = "0x74DD400", VA = "0x1874DEA00", Slot = "4")]
	public override void LDJCJAOGPDB(IPEndPoint PCDDCAGCLHJ, byte[] GPCDCFCPGFK, int KIOPHNHDMKE, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x74DE5B0", Offset = "0x74DCFB0", VA = "0x1874DE5B0", Slot = "5")]
	public override void AEFLAFKKHBN(IPEndPoint PCDDCAGCLHJ, byte[] GPCDCFCPGFK, int KIOPHNHDMKE, int KLLLBPFLPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct LDOJDCOKPAB
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public unsafe delegate void NKACMCMKJJP([NoAlias] byte* GGNPLPPANPC, [NoAlias] byte* LNBCHJPEENA, [NoAlias] byte* KGCNMNIMLIJ, int KLLLBPFLPCD);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	internal static class MEBJIDDLLFB
	{
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private static IntPtr HMKMBDMMICF;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private static IntPtr ICCGCFACKOO;

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x74EA9D0", Offset = "0x74E93D0", VA = "0x1874EA9D0")]
		[BurstDiscard]
		private static void BLECKPHCPCM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x74EAD40", Offset = "0x74E9740", VA = "0x1874EAD40")]
		private static IntPtr KLOKGCHDPLA()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x74EAEA0", Offset = "0x74E98A0", VA = "0x1874EAEA0")]
		public static void PJJGOPHONDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40")]
		public static void ICNIAFDKEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x74EAB00", Offset = "0x74E9500", VA = "0x1874EAB00")]
		public unsafe static void ELEPNCJAFML([NoAlias] byte* GGNPLPPANPC, [NoAlias] byte* LNBCHJPEENA, [NoAlias] byte* KGCNMNIMLIJ, int KLLLBPFLPCD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private unsafe fixed uint LNBCHJPEENA[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private unsafe fixed uint KGCNMNIMLIJ[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private unsafe fixed uint FFNJJNNJINN[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private unsafe fixed uint LNCBJGHBOPN[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private unsafe fixed uint PLIFMKEIIDK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private unsafe fixed uint FHHLLLODANO[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private unsafe fixed uint NJMCBDPNPLL[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private uint PEDPKGJMBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private unsafe fixed uint FIKNLIIDFCF[8];

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x74DF530", Offset = "0x74DDF30", VA = "0x1874DF530")]
	private void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x74DF780", Offset = "0x74DE180", VA = "0x1874DF780")]
	private uint KAPBCJPEPMM(uint ELPCBPJLJEF, int JCBPHBFKIAN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x74D25E0", Offset = "0x74D0FE0", VA = "0x1874D25E0")]
	private void MJKJPBBLHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x74D2240", Offset = "0x74D0C40", VA = "0x1874D2240")]
	private void BBFBEHCHLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x74D2550", Offset = "0x74D0F50", VA = "0x1874D2550")]
	private void JPBBEAJLBLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x74D2450", Offset = "0x74D0E50", VA = "0x1874D2450")]
	private void DBCDOJNMPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x74DF5B0", Offset = "0x74DDFB0", VA = "0x1874DF5B0")]
	private void APCCBOGFDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x74DF910", Offset = "0x74DE310", VA = "0x1874DF910")]
	private unsafe void PANFGJKKGFB(byte* GGNPLPPANPC, uint* LNBCHJPEENA, uint* KGCNMNIMLIJ, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x74DF890", Offset = "0x74DE290", VA = "0x1874DF890")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void LKFCODHOOEA([NoAlias] byte* GGNPLPPANPC, [NoAlias] byte* LNBCHJPEENA, [NoAlias] byte* KGCNMNIMLIJ, int KLLLBPFLPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x74DF7B0", Offset = "0x74DE1B0", VA = "0x1874DF7B0")]
	public static void LKFCODHOOEA(Span<byte> GGNPLPPANPC, Span<byte> LNBCHJPEENA, Span<byte> KGCNMNIMLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x74DF610", Offset = "0x74DE010", VA = "0x1874DF610")]
	public static void BEMHKMKCAON(Span<byte> GGNPLPPANPC, Span<byte> LNBCHJPEENA, Span<byte> KGCNMNIMLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x74DF710", Offset = "0x74DE110", VA = "0x1874DF710")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void FIGOLEDEDOK([NoAlias] byte* GGNPLPPANPC, [NoAlias] byte* LNBCHJPEENA, [NoAlias] byte* KGCNMNIMLIJ, int KLLLBPFLPCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x74EB050", Offset = "0x74E9A50", VA = "0x1874EB050")]
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
