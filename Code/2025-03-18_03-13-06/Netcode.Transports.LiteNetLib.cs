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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Netcode.Transports.LiteNetLib
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LiteNetLibTransport : NetworkTransport, DKOIAOMHPMH
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private enum HELDMGGNFHP
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
		private NetworkManager PFMLLHDPOIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<ulong, IBFGGPACIII> CICNOMGENCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LINBBKJIJAG CFOLAFGGDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private byte[] AHCOBBCGNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HELDMGGNFHP IJBIDCDADCC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override ulong AIEDFCJHLPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "4")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override bool NBIJHOJOLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x690C080", Offset = "0x690B280", VA = "0x18690C080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x690B610", Offset = "0x690A810", VA = "0x18690B610")]
		public void RecRoom_SetEncryptionInfo(ulong CFDHFKOCLPF, byte[] MBDBONINAPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x690B5F0", Offset = "0x690A7F0", VA = "0x18690B5F0")]
		public void RecRoom_ClearEncryptionInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x690B3E0", Offset = "0x690A5E0", VA = "0x18690B3E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x690BF80", Offset = "0x690B180", VA = "0x18690BF80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x690B730", Offset = "0x690A930", VA = "0x18690B730", Slot = "6")]
		public override void Send(ulong LFJBKMEMIJP, ArraySegment<byte> LJELDKAOCJM, NetworkDelivery KMFGDGHGDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x690B5B0", Offset = "0x690A7B0", VA = "0x18690B5B0", Slot = "7")]
		public override NetworkEvent PollEvent([Out] ulong LFJBKMEMIJP, [Out] ArraySegment<byte> FKKLLADNDBA, [Out] float EILBEEIACFB)
		{
			return default(NetworkEvent);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x690BA20", Offset = "0x690AC20", VA = "0x18690BA20", Slot = "8")]
		public override bool StartClient()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x690BEA0", Offset = "0x690B0A0", VA = "0x18690BEA0", Slot = "9")]
		public override bool StartServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x690AF60", Offset = "0x690A160", VA = "0x18690AF60", Slot = "10")]
		public override void DisconnectRemoteClient(ulong LFJBKMEMIJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x690AE70", Offset = "0x690A070", VA = "0x18690AE70", Slot = "11")]
		public override void DisconnectLocalClient()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x690B0A0", Offset = "0x690A2A0", VA = "0x18690B0A0", Slot = "12")]
		public override ulong GetCurrentRtt(ulong LFJBKMEMIJP)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x690B9B0", Offset = "0x690ABB0", VA = "0x18690B9B0", Slot = "13")]
		public override void Shutdown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x690B220", Offset = "0x690A420", VA = "0x18690B220", Slot = "14")]
		public override void Initialize([Optional] NetworkManager PFMLLHDPOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x690AB90", Offset = "0x6909D90", VA = "0x18690AB90")]
		private ADDKJBIDEOK CCDDFEDIJDO(NetworkDelivery NNILCBOLNDI)
		{
			return default(ADDKJBIDEOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x690B4D0", Offset = "0x690A6D0", VA = "0x18690B4D0", Slot = "15")]
		private void PFDFCNBBOOC(IBFGGPACIII KBMJHFDLELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x690AAD0", Offset = "0x6909CD0", VA = "0x18690AAD0", Slot = "16")]
		private void CADFHBMIABN(IBFGGPACIII KBMJHFDLELM, CHPBEEDAEDM ANBDFBICKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "17")]
		private void LMOLINLJFEE(IPEndPoint JOLCMKOLPDK, SocketError EFLAKPAKJIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x690AC60", Offset = "0x6909E60", VA = "0x18690AC60", Slot = "18")]
		private void DLEMCEIADGO(IBFGGPACIII KBMJHFDLELM, DKNOIGJOEDI KLIFEKFIIAG, byte HKLGFMBOFND, ADDKJBIDEOK LKNBPFLHMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x690B140", Offset = "0x690A340", VA = "0x18690B140")]
		private void IICHBGNLHFB(int IAGJHPFNLHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "19")]
		private void GMGKECDAEBB(IPEndPoint LFGOFONPGMP, DKNOIGJOEDI KLIFEKFIIAG, HHHMCKJLBLK ANGGCHEAKNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "20")]
		private void DDHCKBPMIDM(IBFGGPACIII KBMJHFDLELM, int GDFMPHGAGEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x690AA70", Offset = "0x6909C70", VA = "0x18690AA70", Slot = "21")]
		private void ADHJINGGEGM(FBHDDBEPLPH NKJDMJIDCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x690B070", Offset = "0x690A270", VA = "0x18690B070")]
		private ulong FAKPOHOLKJI(IBFGGPACIII KBMJHFDLELM)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x690B590", Offset = "0x690A790", VA = "0x18690B590")]
		private static int PLCEMGKOFCN(float KDJGAOFKCEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x690BFA0", Offset = "0x690B1A0", VA = "0x18690BFA0")]
		public LiteNetLibTransport()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal abstract class CKNPKJNILKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly IBFGGPACIII JLAMAMJBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly ConcurrentQueue<HAOIDNFHONE> LFDEFMEEBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int FDCECJEFNGO;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68F9C70", Offset = "0x68F8E70", VA = "0x1868F9C70")]
	protected CKNPKJNILKG(IBFGGPACIII KBMJHFDLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F9BD0", Offset = "0x68F8DD0", VA = "0x1868F9BD0")]
	public void HIIDHKBGNBA(HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F9B50", Offset = "0x68F8D50", VA = "0x1868F9B50")]
	protected void FFCMBPHGDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68F9C30", Offset = "0x68F8E30", VA = "0x1868F9C30")]
	public bool KCMDENONIHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract bool FAIOLCAONEL();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool HILEBAOIAKH(HAOIDNFHONE HEEHGLKODPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal enum NPMPOENIOPD
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
public class FBHDDBEPLPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly LINBBKJIJAG HKNPPIEOJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private int ONKLDOHPLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal JPKMOECDPHG AEBJHLEDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IPEndPoint PLFNBAOKDDO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal NPMPOENIOPD JLJAOJIPCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x98ABF0", Offset = "0x989DF0", VA = "0x18098ABF0")]
		[CompilerGenerated]
		get
		{
			return default(NPMPOENIOPD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC4FF90", Offset = "0xC4F190", VA = "0x180C4FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68FA090", Offset = "0x68F9290", VA = "0x1868FA090")]
	internal void OPFODMFGFLH(JPKMOECDPHG NJPFENBKAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68FA000", Offset = "0x68F9200", VA = "0x1868FA000")]
	private bool DPHFGOPJEMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68FA0F0", Offset = "0x68F92F0", VA = "0x1868FA0F0")]
	internal FBHDDBEPLPH(IPEndPoint LFGOFONPGMP, JPKMOECDPHG POIDOKAFFCD, LINBBKJIJAG NAMHIGBGJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68FA030", Offset = "0x68F9230", VA = "0x1868FA030")]
	public IBFGGPACIII IOCPDPNEANK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum HHHMCKJLBLK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	BasicMessage,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Broadcast
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JEAILMDKDAE
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
public struct CHPBEEDAEDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public JEAILMDKDAE JDPKAPFJJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public SocketError BHCDENFEIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public DKNOIGJOEDI MLPDHCGNKDP;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DKOIAOMHPMH
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECCEHDCFKIB(IBFGGPACIII KBMJHFDLELM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPIPAFOMFDC(IBFGGPACIII KBMJHFDLELM, CHPBEEDAEDM ANBDFBICKDI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DELPMBAHMLC(IPEndPoint JOLCMKOLPDK, SocketError EFLAKPAKJIO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JCCMKBCLOMK(IBFGGPACIII KBMJHFDLELM, DKNOIGJOEDI KLIFEKFIIAG, byte HKLGFMBOFND, ADDKJBIDEOK LKNBPFLHMNM);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAEHKADJIAF(IPEndPoint LFGOFONPGMP, DKNOIGJOEDI KLIFEKFIIAG, HHHMCKJLBLK ANGGCHEAKNK);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHKMHCBMOCE(IBFGGPACIII KBMJHFDLELM, int GDFMPHGAGEL);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHJDHICMDJE(FBHDDBEPLPH NKJDMJIDCOG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KHLECLNJHPL
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAOFGAPGBAC(IBFGGPACIII KBMJHFDLELM, object INCDEDPAIFB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OLDJLIODPOF
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOGAPLKBLPK(KOBDDMFPENJ HEEHGLKODPJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface OMPAEFCJJML
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKBBFKPHOCC(IBFGGPACIII KBMJHFDLELM, IPEndPoint HADEMJJABAB);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal sealed class JPKMOECDPHG
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const int JFCBDBJGOBN = 18;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly long DHINENHDKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public byte EHANMKFDFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly byte[] NIHNNFFDJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly BAOEBFNMEKE GGCAPNOPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int AHOLEGOIGCE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6901B40", Offset = "0x6900D40", VA = "0x186901B40")]
	private JPKMOECDPHG(long JAOGGKIEBLN, byte HCNFNKKKKHH, int DEBNBMMFJPK, byte[] OKNCDLFEKNN, BAOEBFNMEKE LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69016E0", Offset = "0x69008E0", VA = "0x1869016E0")]
	public static int ACONEKCKCIJ(HAOIDNFHONE HEEHGLKODPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6901740", Offset = "0x6900940", VA = "0x186901740")]
	public static JPKMOECDPHG EMHDMNODGFJ(HAOIDNFHONE HEEHGLKODPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6901960", Offset = "0x6900B60", VA = "0x186901960")]
	public static HAOIDNFHONE IBJKKGFKMAP(CEFODEDJLIL JPOEAKIDHKO, SocketAddress HHKGKAKGOHF, long KEJHKJADFLC, int DEBNBMMFJPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal sealed class BIOGNOBDOEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly long DHINENHDKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly byte EHANMKFDFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int AHOLEGOIGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly bool AFJOINPDJJK;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x68F7C00", Offset = "0x68F6E00", VA = "0x1868F7C00")]
	private BIOGNOBDOEH(long JAOGGKIEBLN, byte HCNFNKKKKHH, int LKBBAKDOBFP, bool MFCCMLHPPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68F78C0", Offset = "0x68F6AC0", VA = "0x1868F78C0")]
	public static BIOGNOBDOEH EMHDMNODGFJ(HAOIDNFHONE HEEHGLKODPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68F7B10", Offset = "0x68F6D10", VA = "0x1868F7B10")]
	public static HAOIDNFHONE IBJKKGFKMAP(long KEJHKJADFLC, byte ODLDKBIIJFK, int APJKMEMELEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68F7A10", Offset = "0x68F6C10", VA = "0x1868F7A10")]
	public static HAOIDNFHONE GDNJEFHEMKH(IBFGGPACIII KBMJHFDLELM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GGHMOBDOFLL
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Internal,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	External
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GONMLIBBLBO
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKCEACDBEGI(IPEndPoint CCONBFDIHMM, IPEndPoint LFGOFONPGMP, string GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHGIOOFJGMN(IPEndPoint PAFLEMJPOMF, GGHMOBDOFLL NNILCBOLNDI, string GIIKHLJPAKH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class INFHKFNFBBF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private struct JCIKJCGMEPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public IPEndPoint BLFIAMKDPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public IPEndPoint PLFNBAOKDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public string GEKPFJDHKCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private struct DJFNCEFKLLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IPEndPoint DLMJDMPJGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public GGHMOBDOFLL FCLHHMOEMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string GEKPFJDHKCH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	private class ADKEELLLFJI
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IPEndPoint DOIPOCKEJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string GEKPFJDHKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public ADKEELLLFJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private class DEDADBHOJDN
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IPEndPoint DOIPOCKEJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IPEndPoint LNCINEAMDAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public string GEKPFJDHKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DEDADBHOJDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class DEEIAKGEOGG
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GEKPFJDHKCH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EKKGCADPLPG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xC04650", Offset = "0xC03850", VA = "0x180C04650")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x964790", Offset = "0x963990", VA = "0x180964790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public DEEIAKGEOGG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly LINBBKJIJAG EBHPFCBLHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ConcurrentQueue<JCIKJCGMEPH> FMPFHEKBNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ConcurrentQueue<DJFNCEFKLLC> OLGHNDKGGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly BAOEBFNMEKE HEOINGIDOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CEFODEDJLIL MADPIJOAPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly HLCGKGGNNPB CNKDADMDMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GONMLIBBLBO HJNIKJHHHJG;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const int BKOAABPGDPK = 256;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HMABDENMHMD;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6901290", Offset = "0x6900490", VA = "0x186901290")]
	internal INFHKFNFBBF(LINBBKJIJAG INIBLBFOPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6900F80", Offset = "0x6900180", VA = "0x186900F80")]
	internal void FHKPIDDMGMJ(IPEndPoint HIEFFOHEBCC, HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x34DB760", Offset = "0x34DA960", VA = "0x1834DB760")]
	private void GADMOHJJNAJ<T>(T HEEHGLKODPJ, IPEndPoint CGKPJBPKLPJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6901100", Offset = "0x6900300", VA = "0x186901100")]
	private void HKCEACDBEGI(ADKEELLLFJI NFJCAEDHPGK, IPEndPoint HIEFFOHEBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6900C80", Offset = "0x68FFE80", VA = "0x186900C80")]
	private void DHHNMIHHPLH(DEDADBHOJDN NFJCAEDHPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6900DE0", Offset = "0x68FFFE0", VA = "0x186900DE0")]
	private void DLMPIAGBNLP(DEEIAKGEOGG NFJCAEDHPGK, IPEndPoint HIEFFOHEBCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum ADDKJBIDEOK : byte
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
public enum MCPOCBOELKI : long
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Excellent,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fair,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Poor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GFJPBCOJAAP
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	internal static readonly int[] PLBABEDIDBP;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly int DFDFFJIKDKL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly int BKJDONKGDOH;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BHBKDKCHJDH : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68F78B0", Offset = "0x68F6AB0", VA = "0x1868F78B0")]
	public BHBKDKCHJDH(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LMLHDNGLMJE : BHBKDKCHJDH
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x68F78B0", Offset = "0x68F6AB0", VA = "0x1868F78B0")]
	public LMLHDNGLMJE(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DCCIMJCKIIO
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
public interface BMCILKCMIGA
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPMKHBEEJGK(DCCIMJCKIIO HELKJOLNKEN, string BKOPBBHMJGH, params object[] MEDGLPBHGFL);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GGOIKGECKGC
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static BMCILKCMIGA DGNICNNHKDP;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly object HMFNGIKDDBA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68FAAC0", Offset = "0x68F9CC0", VA = "0x1868FAAC0")]
	private static void LEHAHPGPAJJ(DCCIMJCKIIO NALKKGEDBBJ, string BKOPBBHMJGH, params object[] MEDGLPBHGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x68FAA00", Offset = "0x68F9C00", VA = "0x1868FAA00")]
	internal static void ANOLLJIOGGI(string BKOPBBHMJGH, params object[] MEDGLPBHGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68FA9A0", Offset = "0x68F9BA0", VA = "0x1868FA9A0")]
	internal static void AGAEEIMEBCF(string BKOPBBHMJGH, params object[] MEDGLPBHGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x68FAA60", Offset = "0x68F9C60", VA = "0x1868FAA60")]
	internal static void IGEGFKIHEEA(string BKOPBBHMJGH, params object[] MEDGLPBHGFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum OHNOHGKDLPF
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SeparateSocket,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DualMode
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class DKNOIGJOEDI : BAOEBFNMEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private HAOIDNFHONE LBBBFCLANHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly LINBBKJIJAG FEKKBAOHIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly FMKELLGNDDN HEBDEJLIFEB;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68F9E30", Offset = "0x68F9030", VA = "0x1868F9E30")]
	internal DKNOIGJOEDI(LINBBKJIJAG CKLPHBNMNHA, FMKELLGNDDN CDNHPBIABBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68F9D90", Offset = "0x68F8F90", VA = "0x1868F9D90")]
	internal void CIPFKOAJCFI(HAOIDNFHONE HEEHGLKODPJ, int AGMHNFGBACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68F9D10", Offset = "0x68F8F10", VA = "0x1868F9D10")]
	internal void CBLMKGNKEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68F9E00", Offset = "0x68F9000", VA = "0x1868F9E00")]
	public void EOKJJLONGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class FMKELLGNDDN
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum LKLLFMMEFJD
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
	public FMKELLGNDDN GOKBCIEPFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public LKLLFMMEFJD FCLHHMOEMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public IBFGGPACIII JLAMAMJBCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public IPEndPoint PLFNBAOKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public object ONLHPHCHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public int MJLKNHCFALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SocketError EFMPLGMOIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public JEAILMDKDAE MJMINCKOKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public FBHDDBEPLPH GBKHFELPKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public ADDKJBIDEOK HIALNGCNDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public byte NDKKIIFNKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public readonly DKNOIGJOEDI ICNAJPGHDPO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68FA830", Offset = "0x68F9A30", VA = "0x1868FA830")]
	public FMKELLGNDDN(LINBBKJIJAG CKLPHBNMNHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LINBBKJIJAG : IEnumerable<IBFGGPACIII>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private class IGODEJHBLFG : IEqualityComparer<IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69003F0", Offset = "0x68FF5F0", VA = "0x1869003F0", Slot = "4")]
		public bool Equals(IPEndPoint NNDJDIFFAID, IPEndPoint AMFIBFNKFFJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63FD400", Offset = "0x63FC600", VA = "0x1863FD400", Slot = "5")]
		public int GetHashCode(IPEndPoint ONELFPFEALD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IGODEJHBLFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct ABCOFNJPCLJ : IEnumerator<IBFGGPACIII>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly IBFGGPACIII ONMAHNJKFHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private IBFGGPACIII FOKDALHMHMF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IBFGGPACIII PEOKKFBMNKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xC8DFC0", Offset = "0xC8D1C0", VA = "0x180C8DFC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xC8DFC0", Offset = "0xC8D1C0", VA = "0x180C8DFC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1824980", Offset = "0x1823B80", VA = "0x181824980")]
		public ABCOFNJPCLJ(IBFGGPACIII FGNDNDOCBOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x68F62B0", Offset = "0x68F54B0", VA = "0x1868F62B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68F6300", Offset = "0x68F5500", VA = "0x1868F6300", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Thread MNDOMIBCCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool JEANNPHOJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly AutoResetEvent GHPBJCAAGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<FMKELLGNDDN> NBPLJKLILCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<FMKELLGNDDN> FMGFMCMGNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private FMKELLGNDDN AFNJPHMPHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DKOIAOMHPMH EAEBFAJGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly KHLECLNJHPL BPHOMFBHECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OLDJLIODPOF LIEMJAHFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly OMPAEFCJJML EIMHCGBHKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly Dictionary<IPEndPoint, IBFGGPACIII> CMCPJNCIDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly Dictionary<IPEndPoint, FBHDDBEPLPH> EMFDEFNIJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly Dictionary<IPEndPoint, ADBEAAMHDOK> HFIDMEHEPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ReaderWriterLockSlim EFJGPHGBPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private IBFGGPACIII JGPBFEBOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private int JKODJBFALED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<IBFGGPACIII> JDAHNHJEDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private IBFGGPACIII[] MIDNNGEFKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly OHFOKDBBGNH FDNOJKDNHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private int KHADCGJDLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private ConcurrentQueue<int> CPBJAMFCNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private byte PGCFJHCIFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly object NDNEFOJPLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool KOHGKGIMNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool COMIMADIGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int MKKEBOGJIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int CIBKMNFNGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int MGCBOLJCNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public int ALHODFIFPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool LKEGCHAAJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MCPCMBCHLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int BIIEHMPIBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public int IPPGBLFKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public int CMEKPLMGFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool HMABDENMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xED")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool NDNBCABFPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEE")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool EHKBCFGIKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEF")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool OALBKMPNFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int DDFFEPGAIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public int OIJELHEAGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool AACKHOMMPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly IBKHPHPOFHD MKLJJAAAANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool ECNGDBPOHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly INFHKFNFBBF PLBAAPFBLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool DLMJKOJMNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public OHNOHGKDLPF DMHGCDKKODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int LNPGHIKOIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KNIGAMIOBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool HLODDJGPPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12E")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool LPILKNMAGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12F")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool ODHJBGBIMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private HAOIDNFHONE EEPKPFOGBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private int HAMINPJNGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly object LHAHFPCKKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private HAOIDNFHONE FGFILHCDADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int ABAIIDOEOMF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private const int MPOAOKMMKHK = 50;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private const int DACBMPPHPDC = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PPMDPKKEBOB LHPBBGCMAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PPMDPKKEBOB PJHFNHIAPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Thread PNHEJIPJKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Thread DMNJBMADGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private IPEndPoint HFNLLLDHMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private IPEndPoint DHBELLLIHHN;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	[ThreadStatic]
	private static byte[] GIJMIAOBOHN;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[ThreadStatic]
	private static byte[] MHAHMAAJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Dictionary<NCDEEEPKACB, IPEndPoint> NKFPCMGGMOE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly IPAddress FCLDIJCLBAM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly bool HAAONMHHABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public int JGIKOEHJPKB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MEMHGKDAOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1347F90", Offset = "0x1347190", VA = "0x181347F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1348030", Offset = "0x1347230", VA = "0x181348030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EOEBDLLOJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x212FD50", Offset = "0x212EF50", VA = "0x18212FD50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x212FDB0", Offset = "0x212EFB0", VA = "0x18212FDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public byte FNPDCHEJLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xB72F40", Offset = "0xB72140", VA = "0x180B72F40")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JPPJMDEAGAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6903890", Offset = "0x6902A90", VA = "0x186903890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	internal short FJDBENHNBOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6906FB0", Offset = "0x69061B0", VA = "0x186906FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6909B30", Offset = "0x6908D30", VA = "0x186909B30")]
	public void OMDIAMCFMGH(IPEndPoint JOLCMKOLPDK, byte[] MBDBONINAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69048A0", Offset = "0x6903AA0", VA = "0x1869048A0")]
	public void DFKNLKAACIB(IPEndPoint JOLCMKOLPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6908F30", Offset = "0x6908130", VA = "0x186908F30")]
	private bool MKBJFNFGDCE(IPEndPoint JOLCMKOLPDK, [Out] IBFGGPACIII KBMJHFDLELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6909F00", Offset = "0x6909100", VA = "0x186909F00")]
	private void PPKEDGKEGKO(IBFGGPACIII KBMJHFDLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6909AE0", Offset = "0x6908CE0", VA = "0x186909AE0")]
	private void OGHNHFGJNEM(IBFGGPACIII KBMJHFDLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6903190", Offset = "0x6902390", VA = "0x186903190")]
	private void AGIOCLILADH(IBFGGPACIII KBMJHFDLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x690A3C0", Offset = "0x69095C0", VA = "0x18690A3C0")]
	public LINBBKJIJAG(DKOIAOMHPMH NAMHIGBGJBG, [Optional] OHFOKDBBGNH CBKPCBJAHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69049F0", Offset = "0x6903BF0", VA = "0x1869049F0")]
	internal void DMIJKNACPID(IBFGGPACIII KBFHKFPKION, int GDFMPHGAGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6907890", Offset = "0x6906A90", VA = "0x186907890")]
	internal void IILECBLAIFE(IBFGGPACIII KBFHKFPKION, object INCDEDPAIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6905200", Offset = "0x6904400", VA = "0x186905200")]
	internal void EHKEKFPMPGE(IBFGGPACIII KBMJHFDLELM, JEAILMDKDAE HIIOCAFDBNN, SocketError MMIFJMPKGKE, HAOIDNFHONE ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69082C0", Offset = "0x69074C0", VA = "0x1869082C0")]
	private void KFMICMPECMP(IBFGGPACIII KBMJHFDLELM, JEAILMDKDAE HIIOCAFDBNN, SocketError MMIFJMPKGKE, bool CPGNGBBHKKK, byte[] LJELDKAOCJM, int MGKDKECOLOJ, int IPBKHOJKHLJ, HAOIDNFHONE ELLEMLBGHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6909700", Offset = "0x6908900", VA = "0x186909700")]
	private void OGBJEMDHMCO(FMKELLGNDDN.LKLLFMMEFJD NNILCBOLNDI, [Optional] IBFGGPACIII KBMJHFDLELM, [Optional] IPEndPoint LFGOFONPGMP, SocketError CAPIHDDNOAD = SocketError.Success, int GDFMPHGAGEL = 0, JEAILMDKDAE FMPPINCPFHO = JEAILMDKDAE.ConnectionFailed, [Optional] FBHDDBEPLPH DCFFNHHDMFH, ADDKJBIDEOK LKNBPFLHMNM = ADDKJBIDEOK.Unreliable, byte HKLGFMBOFND = 0, [Optional] HAOIDNFHONE MIJECCKIJGM, [Optional] object INCDEDPAIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6908760", Offset = "0x6907960", VA = "0x186908760")]
	private void MIDMOIKKAJL(FMKELLGNDDN CDNHPBIABBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6905800", Offset = "0x6904A00", VA = "0x186905800")]
	internal void FNICHGHFKMN(FMKELLGNDDN CDNHPBIABBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6904A40", Offset = "0x6903C40", VA = "0x186904A40")]
	private void DOJNLDAEIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6903400", Offset = "0x6902600", VA = "0x186903400")]
	private void AJJKGJBFBIO(int NLONDCEIMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69078E0", Offset = "0x6906AE0", VA = "0x1869078E0")]
	internal IBFGGPACIII IINNOKBKDCL(FBHDDBEPLPH NKJDMJIDCOG, byte[] HFKCILEAIMK, int MGKDKECOLOJ, int EEBDBIBAAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69038B0", Offset = "0x6902AB0", VA = "0x1869038B0")]
	private int BJBAEDGJBNE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6905240", Offset = "0x6904440", VA = "0x186905240")]
	private void FHJFJBALPPM(IPEndPoint LFGOFONPGMP, IBFGGPACIII KMGPGOIMOAL, JPKMOECDPHG LCAHOJNJEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6905910", Offset = "0x6904B10", VA = "0x186905910")]
	private void FOMCOGBIMGL(HAOIDNFHONE HEEHGLKODPJ, IPEndPoint LFGOFONPGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6903B90", Offset = "0x6902D90", VA = "0x186903B90")]
	internal void CFPAIMCMPDD(HAOIDNFHONE HEEHGLKODPJ, ADDKJBIDEOK BDACBFNIFCC, byte HKLGFMBOFND, int AGMHNFGBACD, IBFGGPACIII KBFHKFPKION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6903E70", Offset = "0x6903070", VA = "0x186903E70")]
	public bool CHDCILGNCOK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6903EE0", Offset = "0x69030E0", VA = "0x186903EE0")]
	public bool CHDCILGNCOK(IPAddress KPKJFKBNHAP, IPAddress ILKKHMLCOFG, int EEHIBEJLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6903F00", Offset = "0x6903100", VA = "0x186903F00")]
	public bool CHDCILGNCOK(int EEHIBEJLAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6909D50", Offset = "0x6908F50", VA = "0x186909D50")]
	public void PBBIAPFMLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6908FC0", Offset = "0x69081C0", VA = "0x186908FC0")]
	public IBFGGPACIII NFPIDBIEFGO(string PPFHNJCIAMC, int EEHIBEJLAEO, string MBDBONINAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6909470", Offset = "0x6908670", VA = "0x186909470")]
	public IBFGGPACIII NFPIDBIEFGO(string PPFHNJCIAMC, int EEHIBEJLAEO, CEFODEDJLIL LKDBBKEEOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69090A0", Offset = "0x69082A0", VA = "0x1869090A0")]
	public IBFGGPACIII NFPIDBIEFGO(IPEndPoint CGKPJBPKLPJ, CEFODEDJLIL LKDBBKEEOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6908250", Offset = "0x6907450", VA = "0x186908250")]
	public void JIJAHPJBMHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6907F00", Offset = "0x6907100", VA = "0x186907F00")]
	public void JIJAHPJBMHM(bool FEEONHGELGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x69047F0", Offset = "0x69039F0", VA = "0x1869047F0")]
	public void CPLMOEDPJIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6904730", Offset = "0x6903930", VA = "0x186904730")]
	public void CPLMOEDPJIF(byte[] LJELDKAOCJM, int MGKDKECOLOJ, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6908720", Offset = "0x6907920", VA = "0x186908720")]
	public void KFMICMPECMP(IBFGGPACIII KBMJHFDLELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69086E0", Offset = "0x69078E0", VA = "0x1869086E0")]
	public void KFMICMPECMP(IBFGGPACIII KBMJHFDLELM, byte[] LJELDKAOCJM, int MGKDKECOLOJ, int IPBKHOJKHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x690A1E0", Offset = "0x69093E0", VA = "0x18690A1E0", Slot = "4")]
	private IEnumerator<IBFGGPACIII> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x690A270", Offset = "0x6909470", VA = "0x18690A270", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x69077B0", Offset = "0x69069B0", VA = "0x1869077B0")]
	private HAOIDNFHONE HGDLFKKIGKD(DDLGLODKLCA AKOEHEOHLAC, int IAGJHPFNLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x69076D0", Offset = "0x69068D0", VA = "0x1869076D0")]
	private HAOIDNFHONE HGDLFKKIGKD(DDLGLODKLCA AKOEHEOHLAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6902F50", Offset = "0x6902150", VA = "0x186902F50")]
	internal HAOIDNFHONE ADGMHIGAMPE(int IAGJHPFNLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6903930", Offset = "0x6902B30", VA = "0x186903930")]
	internal void CEGNEGHHAPM(HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x690A300", Offset = "0x6909500", VA = "0x18690A300")]
	static LINBBKJIJAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1347F90", Offset = "0x1347190", VA = "0x181347F90")]
	private bool LEEPFAKCGED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x69056F0", Offset = "0x69048F0", VA = "0x1869056F0")]
	private void FJJFMAJMMEM(IPEndPoint AJPEODNAMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6904D80", Offset = "0x6903F80", VA = "0x186904D80")]
	private void DOKLNPCIJAN(IPEndPoint AJPEODNAMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6909550", Offset = "0x6908750", VA = "0x186909550")]
	private bool ODKHBCFINHG(SocketException GMEDNHNLLCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6906CF0", Offset = "0x6905EF0", VA = "0x186906CF0")]
	private void GAHCBMMOCNB(PPMDPKKEBOB INIBLBFOPKO, EndPoint MPDMIMILGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6904E80", Offset = "0x6904080", VA = "0x186904E80")]
	private void EHAGGJMIAFK(object LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6903F80", Offset = "0x6903180", VA = "0x186903F80")]
	public bool CHDCILGNCOK(IPAddress KPKJFKBNHAP, IPAddress ILKKHMLCOFG, int EEHIBEJLAEO, bool OHJOOEAJGJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6908260", Offset = "0x6907460", VA = "0x186908260")]
	internal int KAMBOJLFAKA(HAOIDNFHONE HEEHGLKODPJ, IPEndPoint LFGOFONPGMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6907690", Offset = "0x6906890", VA = "0x186907690")]
	internal int HCBMGCOFILL(HAOIDNFHONE HEEHGLKODPJ, IPEndPoint LFGOFONPGMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6907070", Offset = "0x6906270", VA = "0x186907070")]
	internal int HCBMGCOFILL(byte[] DCEACFEGBDC, int MGKDKECOLOJ, int EEBDBIBAAFF, IPEndPoint LFGOFONPGMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6903720", Offset = "0x6902920", VA = "0x186903720")]
	internal void BADKGBNOOLM(bool PJBEPIJLJBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum DDLGLODKLCA : byte
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
internal sealed class HAOIDNFHONE
{
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int IDOFMLBLPON;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int[] FDGLCMKBLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public byte[] NCLKOFODGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int HNAECDILAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public object ONLHPHCHECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public HAOIDNFHONE GOKBCIEPFDC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DDLGLODKLCA AAODMKJBOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68FB1E0", Offset = "0x68FA3E0", VA = "0x1868FB1E0")]
		get
		{
			return default(DDLGLODKLCA);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x68FAE70", Offset = "0x68FA070", VA = "0x1868FAE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte EHANMKFDFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x68FAEB0", Offset = "0x68FA0B0", VA = "0x1868FAEB0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68FB320", Offset = "0x68FA520", VA = "0x1868FB320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ushort CJFHCMPAEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x68FADA0", Offset = "0x68F9FA0", VA = "0x1868FADA0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x68FAE00", Offset = "0x68FA000", VA = "0x1868FAE00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool AIHHMJAPBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x68FB070", Offset = "0x68FA270", VA = "0x1868FB070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte EBBFNNGGIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x68FAEE0", Offset = "0x68FA0E0", VA = "0x1868FAEE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x68FB290", Offset = "0x68FA490", VA = "0x1868FB290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ushort CMAOOMDIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68FAF10", Offset = "0x68FA110", VA = "0x1868FAF10")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x68FB210", Offset = "0x68FA410", VA = "0x1868FB210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ushort MFBNPBMFBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68FB360", Offset = "0x68FA560", VA = "0x1868FB360")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x68FB250", Offset = "0x68FA450", VA = "0x1868FB250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ushort CCLBDPNPDOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68FB2C0", Offset = "0x68FA4C0", VA = "0x1868FB2C0")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x68FB0A0", Offset = "0x68FA2A0", VA = "0x1868FB0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x68FB3C0", Offset = "0x68FA5C0", VA = "0x1868FB3C0")]
	static HAOIDNFHONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x68FAE40", Offset = "0x68FA040", VA = "0x1868FAE40")]
	public void CPBFANJMJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x68FB790", Offset = "0x68FA990", VA = "0x1868FB790")]
	public HAOIDNFHONE(int IAGJHPFNLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x68FB680", Offset = "0x68FA880", VA = "0x1868FB680")]
	public HAOIDNFHONE(DDLGLODKLCA AKOEHEOHLAC, int IAGJHPFNLHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68FB0E0", Offset = "0x68FA2E0", VA = "0x1868FB0E0")]
	public static int KFBJLGJFJBJ(DDLGLODKLCA AKOEHEOHLAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x68FB150", Offset = "0x68FA350", VA = "0x1868FB150")]
	public int KFBJLGJFJBJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x68FAF70", Offset = "0x68FA170", VA = "0x1868FAF70")]
	public bool FFPKNIECDJF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum NJGKAMDOCOK : byte
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
internal enum ENAAJIHGNDI
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
internal enum BPHINMPALNI
{
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	Reject,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Disconnect
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal enum FLIPAPFPIBA
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	WasConnected
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IBFGGPACIII
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class IIAHGBNPOHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public HAOIDNFHONE[] PHGBFEKAABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int EINFNBJJBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int IAICLNJPGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public byte EBBFNNGGIDF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public IIAHGBNPOHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate void BDKDIHIGPGD(ulong EIOJODFLPEI, int NBFEIFJBPHB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int OLNELPFGLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int OIOKOFGNJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int GHJNHFFGEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private double KCPNBIHBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private int BALMDKCJNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int HCJMAHKALHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int IIPEBNLGBAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly Stopwatch DHHPCMGICAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private int LMBPNOKANOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private long LOGJKHPPFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly object FCFJLHMBJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	internal IBFGGPACIII JMNBMCIFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	internal IBFGGPACIII FHPKBBFBPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly Queue<HAOIDNFHONE> NDEKEGHJICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly ConcurrentQueue<CKNPKJNILKG> IHDGGCLCPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly CKNPKJNILKG[] CGAKDIHIPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private int OENICJPLNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private int CLLGILEOIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool OKCLMHKPHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private int PBNDBLACPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private int LMLLKHIPLHE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private const int NMMODALGPPP = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private const int IJNOBHKPEEG = 4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly object OJONJJNCDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CFPMBPIJADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<ushort, IIAHGBNPOHA> IILFINJIHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly Dictionary<ushort, ushort> MMCHDELOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly HAOIDNFHONE DJJLIGCFGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private int BAPACGFGJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private int BDMPMJAKLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IPEndPoint DMHMFGCEBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private int IGMLMFAFCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int GGAHPAFHNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private long GONHCHAHNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private byte AKINGFMLHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private NJGKAMDOCOK NHPKJLFDPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private HAOIDNFHONE CMIEAACKNHA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private const int BELEFKAPOIL = 300;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private int FMLJKNJLLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly HAOIDNFHONE AKGBEJICPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HAOIDNFHONE JIKDBCOFJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly HAOIDNFHONE DDFJFGKOOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly HAOIDNFHONE JNKEMNNOLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private MCPOCBOELKI JNMBGAGAHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public readonly LINBBKJIJAG BOEFPOBFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public readonly int HOJBPJFAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public object PKLLPFENPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly IBKHPHPOFHD MKLJJAAAANE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	internal byte IGBNGBBJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA95AA0", Offset = "0xA94CA0", VA = "0x180A95AA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x68FBC50", Offset = "0x68FAE50", VA = "0x1868FBC50")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IPEndPoint ANNIBHJCPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBC6550", Offset = "0xBC5750", VA = "0x180BC6550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NJGKAMDOCOK KFCOAKNFNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA95AC0", Offset = "0xA94CC0", VA = "0x180A95AC0")]
		get
		{
			return default(NJGKAMDOCOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	internal long HPABGDHDCFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x969710", Offset = "0x968910", VA = "0x180969710")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JMJJHGBINHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x138A480", Offset = "0x1389680", VA = "0x18138A480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C70B20", Offset = "0x1C6FD20", VA = "0x181C70B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int OJNHNNCFPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68FCB10", Offset = "0x68FBD10", VA = "0x1868FCB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int FINEEGPOOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x972060", Offset = "0x971260", VA = "0x180972060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	internal double PBGIBHPBMDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x465CC10", Offset = "0x465BE10", VA = "0x18465CC10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BDKDIHIGPGD JLGFGOBOJBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68FD1A0", Offset = "0x68FC3A0", VA = "0x1868FD1A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x68FCBA0", Offset = "0x68FBDA0", VA = "0x1868FCBA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x68FF640", Offset = "0x68FE840", VA = "0x1868FF640")]
	internal IBFGGPACIII(LINBBKJIJAG BJBNFACAIJM, IPEndPoint LFGOFONPGMP, int JDNOHHGIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68FEFE0", Offset = "0x68FE1E0", VA = "0x1868FEFE0")]
	internal void MHBOPMAIKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x68FF0A0", Offset = "0x68FE2A0", VA = "0x1868FF0A0")]
	internal void OFMIAKIPPDF(IPEndPoint GBLFLKPAGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68FDEB0", Offset = "0x68FD0B0", VA = "0x1868FDEB0")]
	internal void INMPCNKPENA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x68FBB80", Offset = "0x68FAD80", VA = "0x1868FBB80")]
	private void AKGHODNBAED(int BKMMIABFGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68FF060", Offset = "0x68FE260", VA = "0x1868FF060")]
	private void NLMJEPKFPKN(int FDDLDDNCKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x68FBF00", Offset = "0x68FB100", VA = "0x1868FBF00")]
	private CKNPKJNILKG BOOAHJINNPO(byte EFNCIOCDOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68FFA90", Offset = "0x68FEC90", VA = "0x1868FFA90")]
	internal IBFGGPACIII(LINBBKJIJAG BJBNFACAIJM, IPEndPoint LFGOFONPGMP, int JDNOHHGIHEO, byte ODLDKBIIJFK, CEFODEDJLIL JPOEAKIDHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68FF460", Offset = "0x68FE660", VA = "0x1868FF460")]
	internal IBFGGPACIII(LINBBKJIJAG BJBNFACAIJM, FBHDDBEPLPH NKJDMJIDCOG, int JDNOHHGIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x68FE090", Offset = "0x68FD290", VA = "0x1868FE090")]
	internal void JMINGIJBDAK(JPKMOECDPHG EGBEEOKGLCD, byte[] LJELDKAOCJM, int MGKDKECOLOJ, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68FCB20", Offset = "0x68FBD20", VA = "0x1868FCB20")]
	internal bool EIMAPLDDEHN(BIOGNOBDOEH HEEHGLKODPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68FCE10", Offset = "0x68FC010", VA = "0x1868FCE10")]
	public void GADMOHJJNAJ(byte[] LJELDKAOCJM, int MGKDKECOLOJ, int EEBDBIBAAFF, ADDKJBIDEOK ONCKKBCCJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68FEA80", Offset = "0x68FDC80", VA = "0x1868FEA80")]
	private void LGPOMLGLFGH(byte[] LJELDKAOCJM, int MGKDKECOLOJ, int EEBDBIBAAFF, byte HKLGFMBOFND, ADDKJBIDEOK LKNBPFLHMNM, object INCDEDPAIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x68FCE40", Offset = "0x68FC040", VA = "0x1868FCE40")]
	public void GAHOAGNCMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68FC370", Offset = "0x68FB570", VA = "0x1868FC370")]
	internal BPHINMPALNI DGCLNPACOEM(HAOIDNFHONE HEEHGLKODPJ)
	{
		return default(BPHINMPALNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x68FF000", Offset = "0x68FE200", VA = "0x1868FF000")]
	internal void NFOLLDKPBFF(CKNPKJNILKG ONMGEDNMOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x68FCE90", Offset = "0x68FC090", VA = "0x1868FCE90")]
	internal FLIPAPFPIBA GMCLMNNAIAA(byte[] LJELDKAOCJM, int MGKDKECOLOJ, int EEBDBIBAAFF, bool CPGNGBBHKKK)
	{
		return default(FLIPAPFPIBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x68FDE70", Offset = "0x68FD070", VA = "0x1868FDE70")]
	private void IAFHFIIFKDF(int ELDBFAGOIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68FE0E0", Offset = "0x68FD2E0", VA = "0x1868FE0E0")]
	internal void LGNIOGBCHGH(ADDKJBIDEOK BDACBFNIFCC, HAOIDNFHONE FGNDNDOCBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x68FD910", Offset = "0x68FCB10", VA = "0x1868FD910")]
	private void HJBFGOOPNJF(HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x68FF0D0", Offset = "0x68FE2D0", VA = "0x1868FF0D0")]
	private void PPHHIABEGIK(int JMHDFCLJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x68FCC50", Offset = "0x68FBE50", VA = "0x1868FCC50")]
	internal ENAAJIHGNDI FHJFJBALPPM(JPKMOECDPHG LCAHOJNJEIO)
	{
		return default(ENAAJIHGNDI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68FD250", Offset = "0x68FC450", VA = "0x1868FD250")]
	internal void HILEBAOIAKH(HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x68FDF40", Offset = "0x68FD140", VA = "0x1868FDF40")]
	private void JLPDFJGDDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x68FBD00", Offset = "0x68FAF00", VA = "0x1868FBD00")]
	internal void BHHJFKDCDDM(HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x68FC450", Offset = "0x68FB650", VA = "0x1868FC450")]
	internal void DJHAIOPCIPI(int JMHDFCLJGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68FC0B0", Offset = "0x68FB2B0", VA = "0x1868FC0B0")]
	internal void CEKCHDHINOB(HAOIDNFHONE HEEHGLKODPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class IBKHPHPOFHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private long ALIOEKBKOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private long KCDJJLJHBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private long NMIJAEFHCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private long NMFMOFJAABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private long PHGCFINHKEA;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static long LHCGFDLDLOK;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static long MJBMIGOPDJA;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static long LBHOIJMJKKE;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static long GEKHEFNOILK;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static long GKAGJOGKJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long FAPONGGENLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long JLLDIHDICKG;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long AJOKHMFNGGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x68FFC60", Offset = "0x68FEE60", VA = "0x1868FFC60")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public long GMBHKBADOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6900010", Offset = "0x68FF210", VA = "0x186900010")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public long LJNBDMDFEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6900020", Offset = "0x68FF220", VA = "0x186900020")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public long POBGKHNBLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68FFE80", Offset = "0x68FF080", VA = "0x1868FFE80")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public long FDGHKOGFEJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68FFDE0", Offset = "0x68FEFE0", VA = "0x1868FFDE0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public long IIAGMEMKABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68FFD10", Offset = "0x68FEF10", VA = "0x1868FFD10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static long JJNJOCNGFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x68FFC20", Offset = "0x68FEE20", VA = "0x1868FFC20")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static long FKJLBEKHHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68FFE40", Offset = "0x68FF040", VA = "0x1868FFE40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private MCPOCBOELKI CPEKFJBPCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x68FFF60", Offset = "0x68FF160", VA = "0x1868FFF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public double KPAFHBHOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6900030", Offset = "0x68FF230", VA = "0x186900030")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x68FFC70", Offset = "0x68FEE70", VA = "0x1868FFC70")]
	public void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x68FFD80", Offset = "0x68FEF80", VA = "0x1868FFD80")]
	public void HACAOBLDEEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x68FFDF0", Offset = "0x68FEFF0", VA = "0x1868FFDF0")]
	public void JBPAGACIPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x68FFD20", Offset = "0x68FEF20", VA = "0x1868FFD20")]
	public void GOJHIMDPIHH(long GBNGOHGLMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x68FFCB0", Offset = "0x68FEEB0", VA = "0x1868FFCB0")]
	public void DPEDBADGHBN(long NAFFDGCCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x68FFF00", Offset = "0x68FF100", VA = "0x1868FFF00")]
	public void LOBADABDMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x68FFE90", Offset = "0x68FF090", VA = "0x1868FFE90")]
	public void KOHMADFECDK(long JAPFGLOABFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6900090", Offset = "0x68FF290", VA = "0x186900090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x68FFF70", Offset = "0x68FF170", VA = "0x1868FFF70")]
	public void MGADAILFKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public IBKHPHPOFHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class FMGBMHCENLG
{
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly List<string> LAAHFILIFLD;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x68FA2C0", Offset = "0x68F94C0", VA = "0x1868FA2C0")]
	public static IPEndPoint FDPNMADLDPO(string BJCPNGNOKJF, int EEHIBEJLAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x68FA510", Offset = "0x68F9710", VA = "0x1868FA510")]
	public static IPAddress NECIMNPJJMG(string BJCPNGNOKJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x68FA6E0", Offset = "0x68F98E0", VA = "0x1868FA6E0")]
	public static IPAddress NECIMNPJJMG(string BJCPNGNOKJF, AddressFamily EBMKCELKMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x68FA770", Offset = "0x68F9970", VA = "0x1868FA770")]
	internal static int NKHGCEDEDCE(int EBKCFDGICML, int ABLBOLEBNHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x347DFC0", Offset = "0x347D1C0", VA = "0x18347DFC0")]
	internal static T[] KDJNHGAFJJH<T>(int IPBKHOJKHLJ) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class CGDAHMJBCEB : CKNPKJNILKG
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private struct ENEPFHFMMFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private HAOIDNFHONE LBBBFCLANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private long OEODEDPMFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private bool DPPBNPALHOB;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x68F9F60", Offset = "0x68F9160", VA = "0x1868F9F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68F9E80", Offset = "0x68F9080", VA = "0x1868F9E80")]
		public void EMBIHAFPMPJ(HAOIDNFHONE HEEHGLKODPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x68F9EA0", Offset = "0x68F90A0", VA = "0x1868F9EA0")]
		public bool KCMCGPJBEKH(long IJEINPFHNPG, IBFGGPACIII KBMJHFDLELM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68F9F10", Offset = "0x68F9110", VA = "0x1868F9F10")]
		public bool NLADMABHKNO(IBFGGPACIII KBMJHFDLELM)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly HAOIDNFHONE FHELJEPDHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly ENEPFHFMMFL[] MFHPLDBPCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly HAOIDNFHONE[] GNAHEKKIEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly bool[] GLCMKANBCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private int FEHFGEDONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private int EBMDCJHGJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private int PKJEOIJHCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private int NAPKLCMJJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool HJALECEFHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly ADDKJBIDEOK MELPBJNGNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly bool GFINHNPHOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly int GFJIDOLKJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly byte LBNKNKCAGAB;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x68F9980", Offset = "0x68F8B80", VA = "0x1868F9980")]
	public CGDAHMJBCEB(IBFGGPACIII KBMJHFDLELM, bool FMKPMCLPKHD, byte JDNOHHGIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x68F95C0", Offset = "0x68F87C0", VA = "0x1868F95C0")]
	private void KJJDBOIIPBD(HAOIDNFHONE HEEHGLKODPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x68F8A90", Offset = "0x68F7C90", VA = "0x1868F8A90", Slot = "4")]
	protected override bool FAIOLCAONEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x68F8F60", Offset = "0x68F8160", VA = "0x1868F8F60", Slot = "5")]
	public override bool HILEBAOIAKH(HAOIDNFHONE HEEHGLKODPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class MOADHCBOFOC : CKNPKJNILKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private int FEBDPCIJEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private ushort EBMDCJHGJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly bool KKPGNDCAFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private HAOIDNFHONE EGGNHHLGEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly HAOIDNFHONE EMFALJBEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private bool IJKDPKKBAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly byte LBNKNKCAGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long AKDJHJBOFPK;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x690D340", Offset = "0x690C540", VA = "0x18690D340")]
	public MOADHCBOFOC(IBFGGPACIII KBMJHFDLELM, bool MDOJOCHBCNP, byte JDNOHHGIHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x690CBA0", Offset = "0x690BDA0", VA = "0x18690CBA0", Slot = "4")]
	protected override bool FAIOLCAONEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x690D060", Offset = "0x690C260", VA = "0x18690D060", Slot = "5")]
	public override bool HILEBAOIAKH(HAOIDNFHONE HEEHGLKODPJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class FDIJAAJEJPG
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EEMHIDMANFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ulong AENDIPKNBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public double OEIKKBHAAEC;
	}

	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private struct NJNIICGDECO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int MKHLMAKJPCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float EDBEEILHHBO;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x68F61C0", Offset = "0x68F53C0", VA = "0x1868F61C0")]
	private static void LMJFOGENJNJ(byte[] LPBGEKCBGMP, int DCNPLBBIONO, ulong LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x68FA210", Offset = "0x68F9410", VA = "0x1868FA210")]
	private static void LMJFOGENJNJ(byte[] LPBGEKCBGMP, int DCNPLBBIONO, int LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x68FA280", Offset = "0x68F9480", VA = "0x1868FA280")]
	public static void LMJFOGENJNJ(byte[] LPBGEKCBGMP, int DCNPLBBIONO, short LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x68FA170", Offset = "0x68F9370", VA = "0x1868FA170")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, double OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x68FA190", Offset = "0x68F9390", VA = "0x1868FA190")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x68FA280", Offset = "0x68F9480", VA = "0x1868FA280")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, short OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x68FA280", Offset = "0x68F9480", VA = "0x1868FA280")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, ushort OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x68FA210", Offset = "0x68F9410", VA = "0x1868FA210")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x68FA210", Offset = "0x68F9410", VA = "0x1868FA210")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, uint OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x68FA160", Offset = "0x68F9360", VA = "0x1868FA160")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, long OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x68FA160", Offset = "0x68F9360", VA = "0x1868FA160")]
	public static void JLBDPHOPFIF(byte[] GJKPEEJCIPN, int JMHJAFCGEDO, ulong OMFJNFBDJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class BAOEBFNMEKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	protected byte[] LHJMAMJHDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	protected int EIDBGIDBIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	protected int ABPHGAGIIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int JJBOJNLMFGH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] NCLKOFODGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int IPMAIEKFFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAE2F30", Offset = "0xAE2130", VA = "0x180AE2F30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int GKCNMLCCHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68F6CD0", Offset = "0x68F5ED0", VA = "0x1868F6CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LAPNCAMJNCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x24C0F00", Offset = "0x24C0100", VA = "0x1824C0F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NACCIFJJKLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x68F7230", Offset = "0x68F6430", VA = "0x1868F7230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x68F6D20", Offset = "0x68F5F20", VA = "0x1868F6D20")]
	public void CIPFKOAJCFI(byte[] DPCGKOGCCDM, int DCNPLBBIONO, int OONAFABDFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public BAOEBFNMEKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x68F7850", Offset = "0x68F6A50", VA = "0x1868F7850")]
	public BAOEBFNMEKE(byte[] DPCGKOGCCDM, int DCNPLBBIONO, int OONAFABDFBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x68F7780", Offset = "0x68F6980", VA = "0x1868F7780")]
	public IPEndPoint PKHBIHIHGAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x68F6CE0", Offset = "0x68F5EE0", VA = "0x1868F6CE0")]
	public byte IEGOCAHCLJO()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x68F6CE0", Offset = "0x68F5EE0", VA = "0x1868F6CE0")]
	public sbyte CFACFCGBKKJ()
	{
		return default(sbyte);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x31F0390", Offset = "0x31EF590", VA = "0x1831F0390")]
	public T[] JMLDDFPFODC<T>(ushort IAGJHPFNLHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68F76D0", Offset = "0x68F68D0", VA = "0x1868F76D0")]
	public bool[] OIFAAKNKDOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x68F7330", Offset = "0x68F6530", VA = "0x1868F7330")]
	public ushort[] HCGMPBLBEPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68F7420", Offset = "0x68F6620", VA = "0x1868F7420")]
	public short[] JACNKJOLHNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68F72F0", Offset = "0x68F64F0", VA = "0x1868F72F0")]
	public int[] GMEGJCNKCPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x68F7370", Offset = "0x68F6570", VA = "0x1868F7370")]
	public uint[] HIBKEMEAGAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x68F6C50", Offset = "0x68F5E50", VA = "0x1868F6C50")]
	public float[] ABGKIEGCMLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68F74D0", Offset = "0x68F66D0", VA = "0x1868F74D0")]
	public double[] JCLIHDOINHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x68F7240", Offset = "0x68F6440", VA = "0x1868F7240")]
	public long[] FOBKBDEEBMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x68F7690", Offset = "0x68F6890", VA = "0x1868F7690")]
	public ulong[] NLFGPGNHPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x68F6F90", Offset = "0x68F6190", VA = "0x1868F6F90")]
	public string[] DBMIFHBCBNA(int DLOMJEDGHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x68F7580", Offset = "0x68F6780", VA = "0x1868F7580")]
	public bool LLGKLABMMKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x68F71C0", Offset = "0x68F63C0", VA = "0x1868F71C0")]
	public char FALKAIKNHPI()
	{
		return default(char);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68F71C0", Offset = "0x68F63C0", VA = "0x1868F71C0")]
	public ushort OEOKCCDAPKP()
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x68F7600", Offset = "0x68F6800", VA = "0x1868F7600")]
	public short NDBBCDOHDOC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x68F70E0", Offset = "0x68F62E0", VA = "0x1868F70E0")]
	public long DCGIEGFJCCA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x68F73B0", Offset = "0x68F65B0", VA = "0x1868F73B0")]
	public ulong HPCDLJKEHFI()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x68F7710", Offset = "0x68F6910", VA = "0x1868F7710")]
	public int PCJPINLDAIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x68F7460", Offset = "0x68F6660", VA = "0x1868F7460")]
	public uint JCAGPMIPAGF()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x68F7280", Offset = "0x68F6480", VA = "0x1868F7280")]
	public float GFHCJCPKJHJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x68F7510", Offset = "0x68F6710", VA = "0x1868F7510")]
	public double JJBHMAKIKFM()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x68F6D60", Offset = "0x68F5F60", VA = "0x1868F6D60")]
	public string CJNLBIKKJAP(int FLFNGMJEBAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x68F7150", Offset = "0x68F6350", VA = "0x1868F7150")]
	public ArraySegment<byte> DPPKGBBFDGF(int IPBKHOJKHLJ)
	{
		return default(ArraySegment<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x68F75C0", Offset = "0x68F67C0", VA = "0x1868F75C0")]
	public sbyte[] MILEJMDJIMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x68F6C90", Offset = "0x68F5E90", VA = "0x1868F6C90")]
	public byte[] ANOLHIPADFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x68F7670", Offset = "0x68F6870", VA = "0x1868F7670")]
	public void NLADMABHKNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CEFODEDJLIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	protected byte[] LHJMAMJHDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	protected int EIDBGIDBIGC;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private const int PGHGDFEGNAN = 64;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly bool ACCIGLCHHKJ;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public static readonly UTF8Encoding GBAMJNGIADO;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const int HPDBKMHPMAO = 32768;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private readonly byte[] CJELMDDDPDE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] GGCAPNOPJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int MCIABBAIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x96C090", Offset = "0x96B290", VA = "0x18096C090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x68F8970", Offset = "0x68F7B70", VA = "0x1868F8970")]
	public CEFODEDJLIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x68F89F0", Offset = "0x68F7BF0", VA = "0x1868F89F0")]
	public CEFODEDJLIL(bool FDIHCEPKFNM, int HKDLBKBEIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x68F8880", Offset = "0x68F7A80", VA = "0x1868F8880")]
	public static CEFODEDJLIL PPAFFDGKDFJ(string OMFJNFBDJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x68F7D30", Offset = "0x68F6F30", VA = "0x1868F7D30")]
	public void LGOGHOLIFML(int HILEKMLLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2539CF0", Offset = "0x2538EF0", VA = "0x182539CF0")]
	public void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x68F8600", Offset = "0x68F7800", VA = "0x1868F8600")]
	public void NOLIFOBLNGN(float OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x68F8710", Offset = "0x68F7910", VA = "0x1868F8710")]
	public void NOLIFOBLNGN(double OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x68F8830", Offset = "0x68F7A30", VA = "0x1868F8830")]
	public void NOLIFOBLNGN(long OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x68F8830", Offset = "0x68F7A30", VA = "0x1868F8830")]
	public void NOLIFOBLNGN(ulong OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x68F8570", Offset = "0x68F7770", VA = "0x1868F8570")]
	public void NOLIFOBLNGN(int OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x68F8570", Offset = "0x68F7770", VA = "0x1868F8570")]
	public void NOLIFOBLNGN(uint OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x68F8280", Offset = "0x68F7480", VA = "0x1868F8280")]
	public void NOLIFOBLNGN(char OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x68F8280", Offset = "0x68F7480", VA = "0x1868F8280")]
	public void NOLIFOBLNGN(ushort OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x68F8280", Offset = "0x68F7480", VA = "0x1868F8280")]
	public void NOLIFOBLNGN(short OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x68F8500", Offset = "0x68F7700", VA = "0x1868F8500")]
	public void NOLIFOBLNGN(sbyte OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x68F8500", Offset = "0x68F7700", VA = "0x1868F8500")]
	public void NOLIFOBLNGN(byte OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x68F86A0", Offset = "0x68F78A0", VA = "0x1868F86A0")]
	public void NOLIFOBLNGN(byte[] LJELDKAOCJM, int DCNPLBBIONO, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x68F7C50", Offset = "0x68F6E50", VA = "0x1868F7C50")]
	public void GGAILOABOCH(sbyte[] LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x68F7C50", Offset = "0x68F6E50", VA = "0x1868F7C50")]
	public void DGDOBACIDIP(byte[] LJELDKAOCJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x68F8220", Offset = "0x68F7420", VA = "0x1868F8220")]
	public void NOLIFOBLNGN(bool OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x68F8140", Offset = "0x68F7340", VA = "0x1868F8140")]
	public void MFNOLDNGBKL(Array LOJLBKJLMJL, int CELKNBBIMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x68F7DD0", Offset = "0x68F6FD0", VA = "0x1868F7DD0")]
	public void MFNOLDNGBKL(float[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x68F7EB0", Offset = "0x68F70B0", VA = "0x1868F7EB0")]
	public void MFNOLDNGBKL(double[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x68F7EB0", Offset = "0x68F70B0", VA = "0x1868F7EB0")]
	public void MFNOLDNGBKL(long[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x68F7EB0", Offset = "0x68F70B0", VA = "0x1868F7EB0")]
	public void MFNOLDNGBKL(ulong[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x68F7DD0", Offset = "0x68F6FD0", VA = "0x1868F7DD0")]
	public void MFNOLDNGBKL(int[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x68F7DD0", Offset = "0x68F6FD0", VA = "0x1868F7DD0")]
	public void MFNOLDNGBKL(uint[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x68F7F90", Offset = "0x68F7190", VA = "0x1868F7F90")]
	public void MFNOLDNGBKL(ushort[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x68F7F90", Offset = "0x68F7190", VA = "0x1868F7F90")]
	public void MFNOLDNGBKL(short[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x68F7C50", Offset = "0x68F6E50", VA = "0x1868F7C50")]
	public void MFNOLDNGBKL(bool[] OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x68F8070", Offset = "0x68F7270", VA = "0x1868F8070")]
	public void MFNOLDNGBKL(string[] OMFJNFBDJCA, int IHGEBLCCPHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x68F8760", Offset = "0x68F7960", VA = "0x1868F8760")]
	public void NOLIFOBLNGN(IPEndPoint JOLCMKOLPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x68F8560", Offset = "0x68F7760", VA = "0x1868F8560")]
	public void NOLIFOBLNGN(string OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x68F82F0", Offset = "0x68F74F0", VA = "0x1868F82F0")]
	public void NOLIFOBLNGN(string OMFJNFBDJCA, int FLFNGMJEBAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HLCGKGGNNPB
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	private static class EHPEHGDINBA<T>
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly ulong HOJBPJFAOFL;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x4101670", Offset = "0x4100870", VA = "0x184101670")]
		static EHPEHGDINBA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	protected delegate void PBLDDADCGBE(BAOEBFNMEKE KLIFEKFIIAG, object INCDEDPAIFB);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class OEGOGGNDKLG<T> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public HLCGKGGNNPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Action<T> onReceive;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OEGOGGNDKLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4FC5810", Offset = "0x4FC4A10", VA = "0x184FC5810")]
		internal void CLAELPELFGF(BAOEBFNMEKE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class CKEAKMCCHPE<T, TUserData> where T : class, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public HLCGKGGNNPB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public T reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public Action<T, TUserData> onReceive;

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CKEAKMCCHPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x5CD9310", Offset = "0x5CD8510", VA = "0x185CD9310")]
		internal void CLAELPELFGF(BAOEBFNMEKE reader, object userData)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private readonly NOGKOGOBABA EAGKLOBMCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<ulong, PBLDDADCGBE> GGMLKBANNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly CEFODEDJLIL CGKHAPODLIO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68FBA00", Offset = "0x68FAC00", VA = "0x1868FBA00")]
	public HLCGKGGNNPB(int DLOMJEDGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x31F6260", Offset = "0x31F5460", VA = "0x1831F6260", Slot = "4")]
	protected virtual ulong KHKNDEFBPEA<T>()
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x68FB800", Offset = "0x68FAA00", VA = "0x1868FB800", Slot = "5")]
	protected virtual PBLDDADCGBE FCOBFDNEDGF(BAOEBFNMEKE KLIFEKFIIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x34BBB60", Offset = "0x34BAD60", VA = "0x1834BBB60", Slot = "6")]
	protected virtual void ANLHBALIPBD<T>(CEFODEDJLIL DKHAABKGBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68FB980", Offset = "0x68FAB80", VA = "0x1868FB980")]
	public void KEIFHHOPMPJ(BAOEBFNMEKE KLIFEKFIIAG, object INCDEDPAIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x34BBBD0", Offset = "0x34BADD0", VA = "0x1834BBBD0")]
	public void BKDLAHCGGNN<T>(CEFODEDJLIL DKHAABKGBIG, T HEEHGLKODPJ) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68FB930", Offset = "0x68FAB30", VA = "0x1868FB930")]
	public void JJOFJELADCJ(BAOEBFNMEKE KLIFEKFIIAG, object INCDEDPAIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x34BBE40", Offset = "0x34BB040", VA = "0x1834BBE40")]
	public void JOJILPIJHIK<T>(Action<T> GPCJAMBPELL) where T : class, new()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x34BBC80", Offset = "0x34BAE80", VA = "0x1834BBC80")]
	public void JOJILPIJHIK<T, TUserData>(Action<T, TUserData> GPCJAMBPELL) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class KKAODFFNFFL : ArgumentException
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x68F78B0", Offset = "0x68F6AB0", VA = "0x1868F78B0")]
	public KKAODFFNFFL(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LJGAEFENMJJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x690AA10", Offset = "0x6909C10", VA = "0x18690AA10")]
	public LJGAEFENMJJ(string DCEACFEGBDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class NOGKOGOBABA
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private enum LNBNDALCCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Basic,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		List
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private abstract class CONGKDOMCNL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public LNBNDALCCHJ FCLHHMOEMEB;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3600", Offset = "0x5DC2800", VA = "0x185DC3600", Slot = "4")]
		public virtual void EMBIHAFPMPJ(MethodInfo JNCLHJIOOOP, MethodInfo HHLIIHKOEDO, LNBNDALCCHJ NNILCBOLNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK);

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void HBHGLIOKMMO(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void JFHMHGBGGFH(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		protected CONGKDOMCNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private abstract class MPBJLPGGAGK<TClass, TProperty> : CONGKDOMCNL<TClass>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected Func<TClass, TProperty> PHMECDJJFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected Action<TClass, TProperty> AAMNGPCHGLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		protected Func<TClass, TProperty[]> GCLGDJAPOGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		protected Action<TClass, TProperty[]> BHPKLAINCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		protected Func<TClass, List<TProperty>> MPCCBEHMAKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		protected Action<TClass, List<TProperty>> GHBNGMGKOMA;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4DBEB40", Offset = "0x4DBDD40", VA = "0x184DBEB40", Slot = "7")]
		public override void PCKCPBHKMOH(TClass JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4DBC680", Offset = "0x4DBB880", VA = "0x184DBC680", Slot = "8")]
		public override void GOABKNHCAMI(TClass JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD2C0", Offset = "0x4DBC4C0", VA = "0x184DBD2C0", Slot = "9")]
		public override void HBHGLIOKMMO(TClass JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4DBD800", Offset = "0x4DBCA00", VA = "0x184DBD800", Slot = "10")]
		public override void JFHMHGBGGFH(TClass JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4DBBE00", Offset = "0x4DBB000", VA = "0x184DBBE00")]
		protected TProperty[] FOIDNNEBFFM(TClass JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4DBBF00", Offset = "0x4DBB100", VA = "0x184DBBF00")]
		protected TProperty[] GHCJEHEIFEJ(TClass JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4DB85C0", Offset = "0x4DB77C0", VA = "0x184DB85C0", Slot = "4")]
		public override void EMBIHAFPMPJ(MethodInfo JNCLHJIOOOP, MethodInfo HHLIIHKOEDO, LNBNDALCCHJ NNILCBOLNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4D85200", Offset = "0x4D84400", VA = "0x184D85200")]
		protected MPBJLPGGAGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private abstract class BAIBGJECNCI<TClass, TProperty> : MPBJLPGGAGK<TClass, TProperty>
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract void PEPPCAAGFOE(BAOEBFNMEKE LIBECIMLPKK, [Out] TProperty GGGCPMKHBPK);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void MMAHOLCGMJC(CEFODEDJLIL IGJBFOFDOME, TProperty GGGCPMKHBPK);

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x5890990", Offset = "0x588FB90", VA = "0x185890990", Slot = "5")]
		public override void PFEJMKEAOBH(TClass JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5890590", Offset = "0x588F790", VA = "0x185890590", Slot = "6")]
		public override void BKDLAHCGGNN(TClass JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x58908D0", Offset = "0x588FAD0", VA = "0x1858908D0", Slot = "7")]
		public override void PCKCPBHKMOH(TClass JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x5890690", Offset = "0x588F890", VA = "0x185890690", Slot = "8")]
		public override void GOABKNHCAMI(TClass JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x4655850", Offset = "0x4654A50", VA = "0x184655850")]
		protected BAIBGJECNCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private class MHKLOBHLPJJ<T> : MPBJLPGGAGK<T, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5C60", Offset = "0x4DA4E60", VA = "0x184DA5C60", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x4B27920", Offset = "0x4B26B20", VA = "0x184B27920", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5BE0", Offset = "0x4DA4DE0", VA = "0x184DA5BE0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4657380", Offset = "0x4656580", VA = "0x184657380", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public MHKLOBHLPJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private class LBPLIMDNKGG<T> : MPBJLPGGAGK<T, uint>
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x4B27A10", Offset = "0x4B26C10", VA = "0x184B27A10", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x4B27920", Offset = "0x4B26B20", VA = "0x184B27920", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x4B27990", Offset = "0x4B26B90", VA = "0x184B27990", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x4657380", Offset = "0x4656580", VA = "0x184657380", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public LBPLIMDNKGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private class HNOPGHGKHKJ<T> : MPBJLPGGAGK<T, short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x46BD970", Offset = "0x46BCB70", VA = "0x1846BD970", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x46BD810", Offset = "0x46BCA10", VA = "0x1846BD810", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x46BD8F0", Offset = "0x46BCAF0", VA = "0x1846BD8F0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x46BD880", Offset = "0x46BCA80", VA = "0x1846BD880", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public HNOPGHGKHKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private class OIOFFOBKJLG<T> : MPBJLPGGAGK<T, ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5006050", Offset = "0x5005250", VA = "0x185006050", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x46BD810", Offset = "0x46BCA10", VA = "0x1846BD810", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5005FD0", Offset = "0x50051D0", VA = "0x185005FD0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x46BD880", Offset = "0x46BCA80", VA = "0x1846BD880", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public OIOFFOBKJLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class MHGECJJHCEF<T> : MPBJLPGGAGK<T, long>
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5B60", Offset = "0x4DA4D60", VA = "0x184DA5B60", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x44B81B0", Offset = "0x44B73B0", VA = "0x1844B81B0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5AE0", Offset = "0x4DA4CE0", VA = "0x184DA5AE0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x44B8220", Offset = "0x44B7420", VA = "0x1844B8220", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public MHGECJJHCEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class FEFMELHJLBL<T> : MPBJLPGGAGK<T, ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x44B8310", Offset = "0x44B7510", VA = "0x1844B8310", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x44B81B0", Offset = "0x44B73B0", VA = "0x1844B81B0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x44B8290", Offset = "0x44B7490", VA = "0x1844B8290", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x44B8220", Offset = "0x44B7420", VA = "0x1844B8220", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public FEFMELHJLBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private class BCOPKKOCBDG<T> : MPBJLPGGAGK<T, byte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A520", Offset = "0x4B99720", VA = "0x184B9A520", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A3C0", Offset = "0x4B995C0", VA = "0x184B9A3C0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x58A1670", Offset = "0x58A0870", VA = "0x1858A1670", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A430", Offset = "0x4B99630", VA = "0x184B9A430", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public BCOPKKOCBDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class LPJCKGIMDIF<T> : MPBJLPGGAGK<T, sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A520", Offset = "0x4B99720", VA = "0x184B9A520", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A3C0", Offset = "0x4B995C0", VA = "0x184B9A3C0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A4A0", Offset = "0x4B996A0", VA = "0x184B9A4A0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A430", Offset = "0x4B99630", VA = "0x184B9A430", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public LPJCKGIMDIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class AHCHGMEAGNA<T> : MPBJLPGGAGK<T, float>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4657470", Offset = "0x4656670", VA = "0x184657470", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4657310", Offset = "0x4656510", VA = "0x184657310", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x46573F0", Offset = "0x46565F0", VA = "0x1846573F0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4657380", Offset = "0x4656580", VA = "0x184657380", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public AHCHGMEAGNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class DDOGANDKLCI<T> : MPBJLPGGAGK<T, double>
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6382F10", Offset = "0x6382110", VA = "0x186382F10", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6382E20", Offset = "0x6382020", VA = "0x186382E20", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6382E90", Offset = "0x6382090", VA = "0x186382E90", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x44B8220", Offset = "0x44B7420", VA = "0x1844B8220", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public DDOGANDKLCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class MNMJFIFINFN<T> : MPBJLPGGAGK<T, bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3600", Offset = "0x4DB2800", VA = "0x184DB3600", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3510", Offset = "0x4DB2710", VA = "0x184DB3510", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x4DB3580", Offset = "0x4DB2780", VA = "0x184DB3580", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x4B9A430", Offset = "0x4B99630", VA = "0x184B9A430", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x44B8390", Offset = "0x44B7590", VA = "0x1844B8390")]
		public MNMJFIFINFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KAOFNPKLHKD<T> : BAIBGJECNCI<T, char>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x4A58A60", Offset = "0x4A57C60", VA = "0x184A58A60", Slot = "12")]
		protected override void MMAHOLCGMJC(CEFODEDJLIL IGJBFOFDOME, char GGGCPMKHBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x4A58A90", Offset = "0x4A57C90", VA = "0x184A58A90", Slot = "11")]
		protected override void PEPPCAAGFOE(BAOEBFNMEKE LIBECIMLPKK, [Out] char GGGCPMKHBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x40A7EB0", Offset = "0x40A70B0", VA = "0x1840A7EB0")]
		public KAOFNPKLHKD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class FGENJKKNECD<T> : BAIBGJECNCI<T, IPEndPoint>
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x44C0800", Offset = "0x44BFA00", VA = "0x1844C0800", Slot = "12")]
		protected override void MMAHOLCGMJC(CEFODEDJLIL IGJBFOFDOME, IPEndPoint GGGCPMKHBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x44C0830", Offset = "0x44BFA30", VA = "0x1844C0830", Slot = "11")]
		protected override void PEPPCAAGFOE(BAOEBFNMEKE LIBECIMLPKK, [Out] IPEndPoint GGGCPMKHBPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x40A7EB0", Offset = "0x40A70B0", VA = "0x1840A7EB0")]
		public FGENJKKNECD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private class CNEJEPPHJOG<T> : MPBJLPGGAGK<T, string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private readonly int EOBFFBHDJJL;

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA2E0", Offset = "0x5CE94E0", VA = "0x185CEA2E0")]
		public CNEJEPPHJOG(int FLFNGMJEBAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA260", Offset = "0x5CE9460", VA = "0x185CEA260", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA0E0", Offset = "0x5CE92E0", VA = "0x185CEA0E0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA1E0", Offset = "0x5CE93E0", VA = "0x185CEA1E0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA160", Offset = "0x5CE9360", VA = "0x185CEA160", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class PPLIMELGPIE<T> : CONGKDOMCNL<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		protected readonly PropertyInfo AAODMKJBOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		protected readonly Type AGAPFEDODPD;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x513CBE0", Offset = "0x513BDE0", VA = "0x18513CBE0")]
		public PPLIMELGPIE(PropertyInfo AKOEHEOHLAC, Type NFPLDPAPEGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x513CB20", Offset = "0x513BD20", VA = "0x18513CB20", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x513C8F0", Offset = "0x513BAF0", VA = "0x18513C8F0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x513CAC0", Offset = "0x513BCC0", VA = "0x18513CAC0", Slot = "7")]
		public override void PCKCPBHKMOH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x513C9A0", Offset = "0x513BBA0", VA = "0x18513C9A0", Slot = "8")]
		public override void GOABKNHCAMI(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x513CA00", Offset = "0x513BC00", VA = "0x18513CA00", Slot = "9")]
		public override void HBHGLIOKMMO(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x513CA60", Offset = "0x513BC60", VA = "0x18513CA60", Slot = "10")]
		public override void JFHMHGBGGFH(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	private class EJGCOLHHEJJ<T> : PPLIMELGPIE<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x4102120", Offset = "0x4101320", VA = "0x184102120")]
		public EJGCOLHHEJJ(PropertyInfo AKOEHEOHLAC, Type NFPLDPAPEGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x4102060", Offset = "0x4101260", VA = "0x184102060", Slot = "5")]
		public override void PFEJMKEAOBH(T JAIOPEHBMOP, BAOEBFNMEKE LIBECIMLPKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4101FB0", Offset = "0x41011B0", VA = "0x184101FB0", Slot = "6")]
		public override void BKDLAHCGGNN(T JAIOPEHBMOP, CEFODEDJLIL IGJBFOFDOME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private sealed class NIDFEPOHFJO<T>
	{
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static NIDFEPOHFJO<T> JLGHKLNHGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly CONGKDOMCNL<T>[] KHIALPFKDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private readonly int FNHFALIOHAL;

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4E34F70", Offset = "0x4E34170", VA = "0x184E34F70")]
		public NIDFEPOHFJO(List<CONGKDOMCNL<T>> IGGNMMEBFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x4E34E10", Offset = "0x4E34010", VA = "0x184E34E10")]
		public void BKDLAHCGGNN(T ONELFPFEALD, CEFODEDJLIL DKHAABKGBIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x4E34EC0", Offset = "0x4E340C0", VA = "0x184E34EC0")]
		public void PFEJMKEAOBH(T ONELFPFEALD, BAOEBFNMEKE KLIFEKFIIAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	private abstract class DEFKEFKLKBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract CONGKDOMCNL<T> NKAAMPBENGI<T>();
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private CEFODEDJLIL MCKIDMJJJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly int DBPMDACIEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly Dictionary<Type, DEFKEFKLKBH> OLHPGEGFAAL;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x690D5E0", Offset = "0x690C7E0", VA = "0x18690D5E0")]
	public NOGKOGOBABA(int DLOMJEDGHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x36191D0", Offset = "0x36183D0", VA = "0x1836191D0")]
	private NIDFEPOHFJO<T> NIKEJJJNEJD<T>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x31F2A10", Offset = "0x31F1C10", VA = "0x1831F2A10")]
	public void COGNOIDNGPM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x36190A0", Offset = "0x36182A0", VA = "0x1836190A0")]
	public bool ANADGBKPLNB<T>(BAOEBFNMEKE KLIFEKFIIAG, T CGKPJBPKLPJ) where T : class, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3619140", Offset = "0x3618340", VA = "0x183619140")]
	public void JEAAONFOJJH<T>(CEFODEDJLIL DKHAABKGBIG, T ONELFPFEALD) where T : class, new()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class KOBDDMFPENJ
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static readonly DateTime ADOLHFDLDMD;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public byte[] MLBGAIHOJDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HECKJEHGCCN HNKOBCAGFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6901E60", Offset = "0x6901060", VA = "0x186901E60")]
		get
		{
			return default(HECKJEHGCCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int DFAGINAHFPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6902770", Offset = "0x6901970", VA = "0x186902770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6902520", Offset = "0x6901720", VA = "0x186902520")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IFIFNJIMEKF LFMDHLHEJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6901C80", Offset = "0x6900E80", VA = "0x186901C80")]
		get
		{
			return default(IFIFNJIMEKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6901E20", Offset = "0x6901020", VA = "0x186901E20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int IHDHDLHEABB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6901CB0", Offset = "0x6900EB0", VA = "0x186901CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public uint PAALKBEBMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6901DA0", Offset = "0x6900FA0", VA = "0x186901DA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DateTime? CMIAGHMLDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6902AF0", Offset = "0x6901CF0", VA = "0x186902AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DateTime? MPFJPLKHCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x69028C0", Offset = "0x6901AC0", VA = "0x1869028C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DateTime? DGFCENOFBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6902560", Offset = "0x6901760", VA = "0x186902560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6902060", Offset = "0x6901260", VA = "0x186902060")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime? MJJMJGDFJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAF8440", Offset = "0xAF7640", VA = "0x180AF8440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xCD65B0", Offset = "0xCD57B0", VA = "0x180CD65B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6902C30", Offset = "0x6901E30", VA = "0x186902C30")]
	public KOBDDMFPENJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6902B80", Offset = "0x6901D80", VA = "0x186902B80")]
	internal KOBDDMFPENJ(byte[] GJKPEEJCIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x69027A0", Offset = "0x69019A0", VA = "0x1869027A0")]
	public static KOBDDMFPENJ NKOCIPJGFOM(byte[] GJKPEEJCIPN, DateTime NBAFPGKGCNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x69028F0", Offset = "0x6901AF0", VA = "0x1869028F0")]
	internal void OMEANONMLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6902590", Offset = "0x6901790", VA = "0x186902590")]
	private void NAGLBBGLGNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6902230", Offset = "0x6901430", VA = "0x186902230")]
	private DateTime? LDAAOABDLGF(int DCNPLBBIONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6901E90", Offset = "0x6901090", VA = "0x186901E90")]
	private void GOMEEOINDKJ(int DCNPLBBIONO, DateTime? OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6901BB0", Offset = "0x6900DB0", VA = "0x186901BB0")]
	private ulong BGBKFKLNPMK(int DCNPLBBIONO)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6901CE0", Offset = "0x6900EE0", VA = "0x186901CE0")]
	private void FKGALBKOKMB(int DCNPLBBIONO, ulong OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6902490", Offset = "0x6901690", VA = "0x186902490")]
	private uint LMGPMKDELMH(int DCNPLBBIONO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x67C56B0", Offset = "0x67C48B0", VA = "0x1867C56B0")]
	private static uint LGJBJHJJFIL(uint NNDJDIFFAID)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6902430", Offset = "0x6901630", VA = "0x186902430")]
	private static ulong LGJBJHJJFIL(ulong NNDJDIFFAID)
	{
		return default(ulong);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum HECKJEHGCCN
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
public enum IFIFNJIMEKF
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	Client = 3,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	Server
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class ADBEAAMHDOK
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private const int MOJIPBGHNNN = 1000;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private const int BDJAOGKBGCC = 10000;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public const int BBMDEFLGIIP = 123;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly IPEndPoint GDGCNKMEEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private int IOIDMMCKFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private int DNDHHEAJEID;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool PJFJGPJGCMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x68F6350", Offset = "0x68F5550", VA = "0x1868F6350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68F6360", Offset = "0x68F5560", VA = "0x1868F6360")]
	public bool GADMOHJJNAJ(PPMDPKKEBOB INIBLBFOPKO, int HFMGEOLGMMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal class IILBAAOIBKA : PPMDPKKEBOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Socket INIBLBFOPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly LINBBKJIJAG BJBNFACAIJM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public short FJDBENHNBOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6900480", Offset = "0x68FF680", VA = "0x186900480", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int CNAFDLFKPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x69004C0", Offset = "0x68FF6C0", VA = "0x1869004C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public EndPoint BLFIAMKDPOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x69004A0", Offset = "0x68FF6A0", VA = "0x1869004A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public AddressFamily MGBFFOMPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x100C0C0", Offset = "0x100B2C0", VA = "0x18100C0C0", Slot = "7")]
		get
		{
			return default(AddressFamily);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6900BD0", Offset = "0x68FFDD0", VA = "0x186900BD0")]
	public IILBAAOIBKA(AddressFamily EBMKCELKMKN, LINBBKJIJAG BJBNFACAIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6900610", Offset = "0x68FF810", VA = "0x186900610", Slot = "8")]
	public bool KMMAEHKIJLJ(IPEndPoint JOLCMKOLPDK, OHNOHGKDLPF GPFFDABFCEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69005D0", Offset = "0x68FF7D0", VA = "0x1869005D0", Slot = "9")]
	public int KKELCFNDHPO(byte[] LPBGEKCBGMP, int DCNPLBBIONO, int IAGJHPFNLHJ, IPEndPoint LFGOFONPGMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69004E0", Offset = "0x68FF6E0", VA = "0x1869004E0", Slot = "10")]
	public int KDOHCBICILN(byte[] LPBGEKCBGMP, EndPoint ACOEJBCIJCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6900460", Offset = "0x68FF660", VA = "0x186900460", Slot = "11")]
	public void AMEFNPPLFKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
internal interface PPMDPKKEBOB
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	short FJDBENHNBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	int CNAFDLFKPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	EndPoint BLFIAMKDPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	AddressFamily MGBFFOMPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KMMAEHKIJLJ(IPEndPoint JOLCMKOLPDK, OHNOHGKDLPF GPFFDABFCEG);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "5")]
	int KKELCFNDHPO(byte[] LPBGEKCBGMP, int DCNPLBBIONO, int IAGJHPFNLHJ, IPEndPoint LFGOFONPGMP);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KDOHCBICILN(byte[] LPBGEKCBGMP, EndPoint LFGOFONPGMP);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AMEFNPPLFKE();
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal readonly struct NCDEEEPKACB : IEquatable<NCDEEEPKACB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly long ABEFFELLKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private readonly long FIDKIEPKKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly long HLKGLABMENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly int DKJNKJLJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly int OOFFEGPBAGP;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x690D4F0", Offset = "0x690C6F0", VA = "0x18690D4F0")]
	public NCDEEEPKACB(byte[] PPFHNJCIAMC, int JGFAIHLGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x98ABF0", Offset = "0x989DF0", VA = "0x18098ABF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x690D4B0", Offset = "0x690C6B0", VA = "0x18690D4B0", Slot = "4")]
	public bool Equals(NCDEEEPKACB LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x690D400", Offset = "0x690C600", VA = "0x18690D400", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class ABALCOKFGFK : IPEndPoint
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public readonly byte[] DCHFFCMJCCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class OHFOKDBBGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public readonly int JPPJMDEAGAO;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
	protected OHFOKDBBGNH(int CKFPAFKEIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BKOLBCPOOEB(IPEndPoint JOLCMKOLPDK, byte[] LJELDKAOCJM, int DCNPLBBIONO, int EEBDBIBAAFF);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GOPIJINLCLB(IPEndPoint JOLCMKOLPDK, byte[] LJELDKAOCJM, int DCNPLBBIONO, int EEBDBIBAAFF);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class MKIPOGAPJHC : OHFOKDBBGNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private byte[] MBDBONINAPC;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly RandomNumberGenerator MPGFOKGIBME;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x25E7750", Offset = "0x25E6950", VA = "0x1825E7750")]
	public MKIPOGAPJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x690C640", Offset = "0x690B840", VA = "0x18690C640")]
	public void DKAEJHLKDHP(IPEndPoint JOLCMKOLPDK, byte[] MBDBONINAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x690C560", Offset = "0x690B760", VA = "0x18690C560")]
	public void DAKCAHEAEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x690C0A0", Offset = "0x690B2A0", VA = "0x18690C0A0", Slot = "4")]
	public override void BKOLBCPOOEB(IPEndPoint JOLCMKOLPDK, byte[] LJELDKAOCJM, int DCNPLBBIONO, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x690C7F0", Offset = "0x690B9F0", VA = "0x18690C7F0", Slot = "5")]
	public override void GOPIJINLCLB(IPEndPoint JOLCMKOLPDK, byte[] LJELDKAOCJM, int DCNPLBBIONO, int EEBDBIBAAFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[BurstCompile]
internal struct APHGHOGJGCH
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public unsafe delegate void IIJBNAGNKEA([NoAlias] byte* FEKPOBJLMLO, [NoAlias] byte* MBDBONINAPC, [NoAlias] byte* OMJKILNPCNF, int EEBDBIBAAFF);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	internal static class PFDFOKEALCP
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static IntPtr HKFPAEBPLLC;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private static IntPtr KGFKANCMOHN;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x690DBA0", Offset = "0x690CDA0", VA = "0x18690DBA0")]
		[BurstDiscard]
		private static void OKNPIIBPOOE(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x690D820", Offset = "0x690CA20", VA = "0x18690D820")]
		private static IntPtr LHGKDKABFBM()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x690D780", Offset = "0x690C980", VA = "0x18690D780")]
		public static void AEGLEKLDFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		public static void PDAIGIIELDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x690D970", Offset = "0x690CB70", VA = "0x18690D970")]
		public unsafe static void LKNMLKMEAKD([NoAlias] byte* FEKPOBJLMLO, [NoAlias] byte* MBDBONINAPC, [NoAlias] byte* OMJKILNPCNF, int EEBDBIBAAFF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private unsafe fixed uint MBDBONINAPC[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private unsafe fixed uint OMJKILNPCNF[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private unsafe fixed uint FKHDPPOFHBP[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private unsafe fixed uint MJGNMJBBPAJ[4];

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private unsafe fixed uint KDIKNDOFKBF[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private unsafe fixed uint BCEKHBFJBOI[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private unsafe fixed uint KBHLBJJPEID[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private uint DBJDLDEELBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private unsafe fixed uint MMKDKMMHEOO[8];

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x68F65F0", Offset = "0x68F57F0", VA = "0x1868F65F0")]
	private void DICECPNPBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x68F64C0", Offset = "0x68F56C0", VA = "0x1868F64C0")]
	private uint CAOLJCINMKJ(uint OKAELCMAFHA, int FNCICDDLDOH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x68F5CD0", Offset = "0x68F4ED0", VA = "0x1868F5CD0")]
	private void CAEEDFCJHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x68F5E80", Offset = "0x68F5080", VA = "0x1868F5E80")]
	private void JADBHLNNFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x68F6090", Offset = "0x68F5290", VA = "0x1868F6090")]
	private void JMPNFMEEKKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x68F5D80", Offset = "0x68F4F80", VA = "0x1868F5D80")]
	private void FBNJEMDKLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x68F67D0", Offset = "0x68F59D0", VA = "0x1868F67D0")]
	private void IEIIPLAEJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x68F6830", Offset = "0x68F5A30", VA = "0x1868F6830")]
	private unsafe void MDMHDGHKHLC(byte* FEKPOBJLMLO, uint* MBDBONINAPC, uint* OMJKILNPCNF, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x68F6750", Offset = "0x68F5950", VA = "0x1868F6750")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void DOKNEINEMFK([NoAlias] byte* FEKPOBJLMLO, [NoAlias] byte* MBDBONINAPC, [NoAlias] byte* OMJKILNPCNF, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x68F6670", Offset = "0x68F5870", VA = "0x1868F6670")]
	public static void DOKNEINEMFK(Span<byte> FEKPOBJLMLO, Span<byte> MBDBONINAPC, Span<byte> OMJKILNPCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x68F64F0", Offset = "0x68F56F0", VA = "0x1868F64F0")]
	public static void CPBLOLMPNPH(Span<byte> FEKPOBJLMLO, Span<byte> MBDBONINAPC, Span<byte> OMJKILNPCNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x68F6450", Offset = "0x68F5650", VA = "0x1868F6450")]
	[BurstCompile(OptimizeFor = OptimizeFor.Performance)]
	public unsafe static void BGGCIJPFICM([NoAlias] byte* FEKPOBJLMLO, [NoAlias] byte* MBDBONINAPC, [NoAlias] byte* OMJKILNPCNF, int EEBDBIBAAFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x690DCC0", Offset = "0x690CEC0", VA = "0x18690DCC0")]
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
