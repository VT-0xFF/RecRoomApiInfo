using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom;
using RecRoom.Core.ResourceManagement;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.RPC;
using RecRoom.Networking.SynchronizedFields;
using RecRoom.ObjectModel;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9B17210", Offset = "0x9B16210", VA = "0x189B17210", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Networking_RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] FEHXVDYRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] FENESKSOPWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GXKYIJVMEXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GXFRLDBOVMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2255D00", Offset = "0x2254D00", VA = "0x182255D00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B2C9D0", Offset = "0x9B2B9D0", VA = "0x189B2C9D0")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B2C770", Offset = "0x9B2B770", VA = "0x189B2C770")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CEE0", Offset = "0x9B2BEE0", VA = "0x189B2CEE0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B2CF90", Offset = "0x9B2BF90", VA = "0x189B2CF90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ODKQIHESJNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log JBBHQSRXUHV;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log HDARARLBDJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9B17540", Offset = "0x9B16540", VA = "0x189B17540")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface QGACUAPBBPT
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView ACYDEJRGHCS
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType TLXNJQZAYNB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PYKSSRRYTHY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "2")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool Serialize(BitPacker bitpacker);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal interface RCLDYCWZPYD
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool FZTBDYYOHLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RWXKBLRZAWK(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface LNPSCQAIKOA : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SIFQFAPRLAF(QGACUAPBBPT a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WKECLZBLVZA(QGACUAPBBPT a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(NVKJNZVENLP.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BCLHNHIBLHJ();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RDGUPVIGSJQ(object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NetworkSyncInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public uint senderNetworkTick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public double serverNetworkTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int serverNetworkTick;
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class KLZYQGRXVHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), RCLDYCWZPYD> MKMUDHCBLVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<QGACUAPBBPT> IUQIGIHPEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> YPEIKPOTDTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int SPGVVKLGYEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool KWKMPTHXYUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private NVKJNZVENLP.ApplyNetworkTransform SIYGUKNWMOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream VTTHANUICKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker HSOBWBJWFGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker IGFUUBZXOZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] WUROCVFMLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float VQHJPNMMKYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int ZCPMODYCCXD;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B16FE0", Offset = "0x9B15FE0", VA = "0x189B16FE0")]
		public KLZYQGRXVHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9B168A0", Offset = "0x9B158A0", VA = "0x189B168A0")]
		public void Pause(NVKJNZVENLP.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9B16030", Offset = "0x9B15030", VA = "0x189B16030")]
		public void BCLHNHIBLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B169F0", Offset = "0x9B159F0", VA = "0x189B169F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B15B20", Offset = "0x9B14B20", VA = "0x189B15B20")]
		public bool Add(QGACUAPBBPT networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B168C0", Offset = "0x9B158C0", VA = "0x189B168C0")]
		public bool Remove(QGACUAPBBPT networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B16DD0", Offset = "0x9B15DD0", VA = "0x189B16DD0")]
		private RCLDYCWZPYD ZARSRPUAPYS(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B16DC0", Offset = "0x9B15DC0", VA = "0x189B16DC0")]
		public void XIMBWSGLBJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B16490", Offset = "0x9B15490", VA = "0x189B16490")]
		private void KDJRTXWYZGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B16470", Offset = "0x9B15470", VA = "0x189B16470")]
		private void GQXYIJCWOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B164F0", Offset = "0x9B154F0", VA = "0x189B164F0")]
		public bool LMCEIJJRIGE(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B16080", Offset = "0x9B15080", VA = "0x189B16080")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class GYLENHIFVPC : RCLDYCWZPYD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private QGACUAPBBPT ZCKDGBEAGHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint BJDOEHLILCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int MXYHQQFNORC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FZTBDYYOHLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public GYLENHIFVPC(QGACUAPBBPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B100E0", Offset = "0x9B0F0E0", VA = "0x189B100E0", Slot = "5")]
		public bool RWXKBLRZAWK(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9B10000", Offset = "0x9B0F000", VA = "0x189B10000", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YDLXAJPBRLV : RCLDYCWZPYD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NVKJNZVENLP.ApplyNetworkTransform SIYGUKNWMOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId CEPNCNYOLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int MXYHQQFNORC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint BJDOEHLILCT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FZTBDYYOHLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D22FC0", Offset = "0x1D21FC0", VA = "0x181D22FC0")]
		public YDLXAJPBRLV(ViewId a, NVKJNZVENLP.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B2C620", Offset = "0x9B2B620", VA = "0x189B2C620", Slot = "5")]
		public bool RWXKBLRZAWK(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B2C440", Offset = "0x9B2B440", VA = "0x189B2C440", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class WVNXFDSCEUL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B28F10", Offset = "0x9B27F10", VA = "0x189B28F10")]
		public static void GHRXOLGFAHI(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B29490", Offset = "0x9B28490", VA = "0x189B29490")]
		public static void UQIVFLQQDLN(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B28DA0", Offset = "0x9B27DA0", VA = "0x189B28DA0")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B290D0", Offset = "0x9B280D0", VA = "0x189B290D0")]
		public static void HZVSILSLSLA(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(LNPSCQAIKOA), new string[] { })]
	public class RONGPMSYWQT : LNPSCQAIKOA, INetworkUpdateSystem, QNFHPEUJUSR, EQFYRFRSSPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log GSMVKKDSIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KLZYQGRXVHP BHHLXBQJZJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint XLXZIPHCGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float BTFPFGJXATL;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B21010", Offset = "0x9B20010", VA = "0x189B21010", Slot = "4")]
		public void SIFQFAPRLAF(QGACUAPBBPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B21130", Offset = "0x9B20130", VA = "0x189B21130", Slot = "5")]
		public void WKECLZBLVZA(QGACUAPBBPT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B20790", Offset = "0x9B1F790", VA = "0x189B20790", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B20F00", Offset = "0x9B1FF00", VA = "0x189B20F00", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B208E0", Offset = "0x9B1F8E0", VA = "0x189B208E0")]
		private void NSCHADYBQIV(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9B20F80", Offset = "0x9B1FF80", VA = "0x189B20F80", Slot = "6")]
		public void Pause(NVKJNZVENLP.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B203A0", Offset = "0x9B1F3A0", VA = "0x189B203A0", Slot = "7")]
		public void BCLHNHIBLHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B20FB0", Offset = "0x9B1FFB0", VA = "0x189B20FB0", Slot = "8")]
		public void RDGUPVIGSJQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B20400", Offset = "0x9B1F400", VA = "0x189B20400")]
		private void FGHHYFWTLMH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B20280", Offset = "0x9B1F280", VA = "0x189B20280", Slot = "11")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B21330", Offset = "0x9B20330", VA = "0x189B21330")]
		public RONGPMSYWQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GFNVQQZCYZD : RCLDYCWZPYD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float VITVIHUUYTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int MXYHQQFNORC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint BJDOEHLILCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType UVOSOLKAQGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo GZXCUMPGVYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int VHISTJDIAIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] GORXXOJREBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo ZMMNBAYCDBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int DKFGFAMQMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] MFIGYUIIWFN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FZTBDYYOHLZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9B0FF60", Offset = "0x9B0EF60", VA = "0x189B0FF60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FF90", Offset = "0x9B0EF90", VA = "0x189B0FF90")]
		public GFNVQQZCYZD(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FF20", Offset = "0x9B0EF20", VA = "0x189B0FF20", Slot = "5")]
		public bool RWXKBLRZAWK(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FC70", Offset = "0x9B0EC70", VA = "0x189B0FC70", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FE20", Offset = "0x9B0EE20", VA = "0x189B0FE20")]
		internal GYLENHIFVPC OSSPXDYWBPH(QGACUAPBBPT a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FAB0", Offset = "0x9B0EAB0", VA = "0x189B0FAB0")]
		private static void DTVXASUSJBH(GYLENHIFVPC a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CMMYTTJBBGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F9D0", Offset = "0x9B0E9D0", VA = "0x189B0F9D0")]
		public static DDFOJMMWCEL JDGYJLHIJGF(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FA60", Offset = "0x9B0EA60", VA = "0x189B0FA60")]
		public static PlayerId ToPlayerId(this DDFOJMMWCEL player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RRNetworkBehavior : MonoBehaviour, FLXSWDTULZN, DSDVCCWMEAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool NHHASEPOBZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RRNetworkView WKJUPSGRWGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<IATHQHSNSXK> WHNLINWTMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool MAFFXVEEVVY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId YVFGQNGUAIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9B21CC0", Offset = "0x9B20CC0", VA = "0x189B21CC0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId BAUHYNCUZBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9B21CC0", Offset = "0x9B20CC0", VA = "0x189B21CC0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView LXBHNWSAMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9B21D40", Offset = "0x9B20D40", VA = "0x189B21D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView ACYDEJRGHCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9B21D40", Offset = "0x9B20D40", VA = "0x189B21D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public DDFOJMMWCEL FFUGFXKYRYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9B21E40", Offset = "0x9B20E40", VA = "0x189B21E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public DDFOJMMWCEL VZNWCMOFUPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9B221A0", Offset = "0x9B211A0", VA = "0x189B221A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool POOGZZCQVAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9B21FA0", Offset = "0x9B20FA0", VA = "0x189B21FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JXHWYADZNKR
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9B22110", Offset = "0x9B21110", VA = "0x189B22110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool SHPOHIQLRAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B21BF0", Offset = "0x9B20BF0", VA = "0x189B21BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool IZSAPSZONIR
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9B21ED0", Offset = "0x9B20ED0", VA = "0x189B21ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool YRLVANZTLCV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9B21BF0", Offset = "0x9B20BF0", VA = "0x189B21BF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool YOKUFGKYOGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9B21C70", Offset = "0x9B20C70", VA = "0x189B21C70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string AYIWIXMYNJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9B21DB0", Offset = "0x9B20DB0", VA = "0x189B21DB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool GZVSNUBPDHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9B21B70", Offset = "0x9B20B70", VA = "0x189B21B70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<DDFOJMMWCEL> EQWFHOKFEOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9B21A40", Offset = "0x9B20A40", VA = "0x189B21A40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9B22230", Offset = "0x9B21230", VA = "0x189B22230")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B219A0", Offset = "0x9B209A0", VA = "0x189B219A0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B21580", Offset = "0x9B20580", VA = "0x189B21580")]
		private void RTHMHORDXTZ(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B215A0", Offset = "0x9B205A0", VA = "0x189B215A0", Slot = "9")]
		public void RegisterDestroyHandler(IATHQHSNSXK handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B217E0", Offset = "0x9B207E0", VA = "0x189B217E0", Slot = "10")]
		public void UnregisterDestroyHandler(IATHQHSNSXK handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9B21560", Offset = "0x9B20560", VA = "0x189B21560", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class CIKUERQNVPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, DDFOJMMWCEL targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, DDFOJMMWCEL targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, DDFOJMMWCEL newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[CompilerGenerated]
		private static InstantiateCallback PNTBQAILWOP;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback ISQTOSTVXBA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F730", Offset = "0x9B0E730", VA = "0x189B0F730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F7F0", Offset = "0x9B0E7F0", VA = "0x189B0F7F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback JRHWTIDPWEU
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F2E0", Offset = "0x9B0E2E0", VA = "0x189B0F2E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9B0E980", Offset = "0x9B0D980", VA = "0x189B0E980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback ZEYVEFKMJEO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EF50", Offset = "0x9B0DF50", VA = "0x189B0EF50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EC50", Offset = "0x9B0DC50", VA = "0x189B0EC50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback QWGPOUCVMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EB90", Offset = "0x9B0DB90", VA = "0x189B0EB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F670", Offset = "0x9B0E670", VA = "0x189B0F670")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback ROXDYDIKVVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F5B0", Offset = "0x9B0E5B0", VA = "0x189B0F5B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9B0E800", Offset = "0x9B0D800", VA = "0x189B0E800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback DNFGCPPNURJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EAD0", Offset = "0x9B0DAD0", VA = "0x189B0EAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F220", Offset = "0x9B0E220", VA = "0x189B0F220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback RGQGHDOGZRO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9B0E740", Offset = "0x9B0D740", VA = "0x189B0E740")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F3A0", Offset = "0x9B0E3A0", VA = "0x189B0F3A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler BPOPOMEZXLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EE90", Offset = "0x9B0DE90", VA = "0x189B0EE90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9B0E8C0", Offset = "0x9B0D8C0", VA = "0x189B0E8C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler AKPBUXEPHBP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F010", Offset = "0x9B0E010", VA = "0x189B0F010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EDD0", Offset = "0x9B0DDD0", VA = "0x189B0EDD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B0ED10", Offset = "0x9B0DD10", VA = "0x189B0ED10")]
		public static void LEHEDPSJVWB([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F940", Offset = "0x9B0E940", VA = "0x189B0F940")]
		public static void ZOFZHBHQAMR(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E6B0", Offset = "0x9B0D6B0", VA = "0x189B0E6B0")]
		public static void BCXJRSUFPPO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F8B0", Offset = "0x9B0E8B0", VA = "0x189B0F8B0")]
		public static void YUWLEJJXJRB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9B0EA40", Offset = "0x9B0DA40", VA = "0x189B0EA40")]
		public static void DWDSTLTBDBI(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F460", Offset = "0x9B0E460", VA = "0x189B0F460")]
		public static void UYBKTBOSBVW(RRNetworkView a, string b, DDFOJMMWCEL c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F0D0", Offset = "0x9B0E0D0", VA = "0x189B0F0D0")]
		public static void RGHLSMEUNVF(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E5A0", Offset = "0x9B0D5A0", VA = "0x189B0E5A0")]
		public static void AUBFRTDOEWH(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class HQZBUVVXVOY
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B10340", Offset = "0x9B0F340", VA = "0x189B10340")]
		[CanBeNull]
		private static bool DYOTGREEUDQ(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9B10260", Offset = "0x9B0F260", VA = "0x189B10260")]
		[CanBeNull]
		public static Component CLEWSEXSLCO(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F8D0", Offset = "0x3B0E8D0", VA = "0x183B0F8D0")]
		[CanBeNull]
		public static a CLEWSEXSLCO<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FA80", Offset = "0x3B0EA80", VA = "0x183B0FA80")]
		[CanBeNull]
		public static b RCRZWLFGLKO<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3B0F9F0", Offset = "0x3B0E9F0", VA = "0x183B0F9F0")]
		public static bool KCVEUXPWFCJ<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9B101F0", Offset = "0x9B0F1F0", VA = "0x189B101F0")]
		[CanBeNull]
		public static RRNetworkView BXYEJETSDNZ(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static RRNetworkHandler CYXBXYXEPKL;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9B22360", Offset = "0x9B21360", VA = "0x189B22360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9B22530", Offset = "0x9B21530", VA = "0x189B22530")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B224F0", Offset = "0x9B214F0", VA = "0x189B224F0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RegisterService(typeof(RHMOIIGXSRQ), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class RHMOIIGXSRQ : XJMTDZCTHZH, QNFHPEUJUSR, EQFYRFRSSPD, BSBPOUIRCFB, JVSDYXNIRML, CJJGAWHPXAL, KXJYMNDEBYH
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class OERIHQMSFXQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int QHJYQXDCMQM;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public OERIHQMSFXQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9B17600", Offset = "0x9B16600", VA = "0x189B17600")]
			internal object YYLUBODXMWV((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static Log FOFTSOQYHDP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static Log HMYZOYTLZEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private PJZRKIAGJCO VBGYKYRTDLN;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static QZPYDOOFSJL EEKEHPRBDRS;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static Dictionary<int, HashSet<int>> LICROVKWQMF;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<int, int> HRVXENMKEBY;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly List<(GameObject GameObject, int ParentCount)> RBTACUHOSSV;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly List<GameObject> FEGPGJUAMRE;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static List<int> DTXHSGMCWRY;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly List<RRNetworkView> LTDABNKSWCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IDEIBCHCWET EGAMSCGSTJU;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly SVLVGVMSMLM FQRDJBMDAJI;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly SVLVGVMSMLM INCMTKRXOXZ;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A210", Offset = "0x9B19210", VA = "0x189B1A210", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9B17C90", Offset = "0x9B16C90", VA = "0x189B17C90", Slot = "9")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A100", Offset = "0x9B19100", VA = "0x189B1A100", Slot = "10")]
		public void InitExternal(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D2A0", Offset = "0x9B1C2A0", VA = "0x189B1D2A0", Slot = "11")]
		public void QUURHTLDHRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B18E30", Offset = "0x9B17E30", VA = "0x189B18E30")]
		private void DXRKCEKCUJZ(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B18C60", Offset = "0x9B17C60", VA = "0x189B18C60")]
		public GameObject DNHOCPETSBG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B19680", Offset = "0x9B18680", VA = "0x189B19680")]
		public GameObject HPIGYAEHOJA(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B185F0", Offset = "0x9B175F0", VA = "0x189B185F0")]
		public GameObject BQOMUKRVXZN(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9B185C0", Offset = "0x9B175C0", VA = "0x189B185C0")]
		public GameObject AXGQLDLEVNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B18A10", Offset = "0x9B17A10", VA = "0x189B18A10", Slot = "6")]
		public void CUIMRRJTBAF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B1F480", Offset = "0x9B1E480", VA = "0x189B1F480")]
		public void VYDSHFUVAKM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9B19570", Offset = "0x9B18570", VA = "0x189B19570", Slot = "7")]
		public void FZAGUMQDXWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D390", Offset = "0x9B1C390", VA = "0x189B1D390", Slot = "4")]
		public GameObject[] SRLVMLJILOF(IList<XHNPIXFCEBC> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9B19780", Offset = "0x9B18780", VA = "0x189B19780", Slot = "5")]
		public void HQVDAZKAASI(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1E300", Offset = "0x9B1D300", VA = "0x189B1E300")]
		public void THOPXVXOXCM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B19290", Offset = "0x9B18290", VA = "0x189B19290")]
		private void FGHHYFWTLMH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9B19B50", Offset = "0x9B18B50", VA = "0x189B19B50")]
		private void HTBDGVWGWPH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1CD50", Offset = "0x9B1BD50", VA = "0x189B1CD50")]
		private void OLWZHCNGZYH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C550", Offset = "0x9B1B550", VA = "0x189B1C550")]
		private void NRBAVMANSXH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9B18EA0", Offset = "0x9B17EA0", VA = "0x189B18EA0")]
		private void EDZNIGFBFCB(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D6C0", Offset = "0x9B1C6C0", VA = "0x189B1D6C0")]
		private void SUCPSQYZAGL(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B17FE0", Offset = "0x9B16FE0", VA = "0x189B17FE0")]
		private void ASJMTKRVYGF(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1EAC0", Offset = "0x9B1DAC0", VA = "0x189B1EAC0")]
		private GameObject TQTUJUDSOYI(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9B1E3E0", Offset = "0x9B1D3E0", VA = "0x189B1E3E0")]
		private GameObject TKGRGMJILUK(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9B18910", Offset = "0x9B17910", VA = "0x189B18910")]
		private static GameObject BYUDUVPGCNE(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1B340", Offset = "0x9B1A340", VA = "0x189B1B340")]
		private static GameObject KKPEJUGULDJ(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A660", Offset = "0x9B19660", VA = "0x189B1A660")]
		private static void JOBAATUYBZQ(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1F4F0", Offset = "0x9B1E4F0", VA = "0x189B1F4F0")]
		private GameObject[] WFYJZTAVDIV(IList<XHNPIXFCEBC> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9B1EDB0", Offset = "0x9B1DDB0", VA = "0x189B1EDB0")]
		private GameObject[] UBLGMNWEGFF(InstantiateParameters[] a, int b, DDFOJMMWCEL c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B19CF0", Offset = "0x9B18CF0", VA = "0x189B19CF0")]
		private GameObject IDYQZSXXUPL([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1F070", Offset = "0x9B1E070", VA = "0x189B1F070")]
		private static bool UPANNSKOLLM(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A770", Offset = "0x9B19770", VA = "0x189B1A770")]
		private void JRJHEQFWQUE(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B1B640", Offset = "0x9B1A640", VA = "0x189B1B640")]
		private void MQVICXTLQUS(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9B1F090", Offset = "0x9B1E090", VA = "0x189B1F090")]
		private static void URABTLEVKOT(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9B1FC90", Offset = "0x9B1EC90", VA = "0x189B1FC90")]
		private void WZSPLRGDJWZ(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9B18870", Offset = "0x9B17870", VA = "0x189B18870")]
		private static int BRUQPYKSRHN(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A600", Offset = "0x9B19600", VA = "0x189B1A600")]
		private void JDIPBRSMUMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C7D0", Offset = "0x9B1B7D0", VA = "0x189B1C7D0")]
		private void OJWJAKGRGJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C4F0", Offset = "0x9B1B4F0", VA = "0x189B1C4F0")]
		private static int NNTCFOUAFVZ(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9B1FDE0", Offset = "0x9B1EDE0", VA = "0x189B1FDE0")]
		private static int[] ZLNLPUSXZRM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B19580", Offset = "0x9B18580", VA = "0x189B19580")]
		private static int[] HNNXBLBYPGM(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D260", Offset = "0x9B1C260", VA = "0x189B1D260")]
		private void OnMasterClientSwitched(DDFOJMMWCEL newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D880", Offset = "0x9B1C880", VA = "0x189B1D880")]
		private void TBMDJJXXEKO(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B1CF80", Offset = "0x9B1BF80", VA = "0x189B1CF80")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9B18A20", Offset = "0x9B17A20", VA = "0x189B18A20")]
		private void CWCGYTPUNKS(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9B1B550", Offset = "0x9B1A550", VA = "0x189B1B550")]
		private static void KMYHPRSSCZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9B1ECB0", Offset = "0x9B1DCB0", VA = "0x189B1ECB0")]
		private void UAIYVBFOLIO(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B1B5F0", Offset = "0x9B1A5F0", VA = "0x189B1B5F0", Slot = "12")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xF6ACF0", Offset = "0xF69CF0", VA = "0x180F6ACF0", Slot = "13")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public RHMOIIGXSRQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RegisterService(typeof(HYOYEVCLUTS), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class HYOYEVCLUTS : QNFHPEUJUSR, EQFYRFRSSPD, ZSDCJODNTRP, DTRQAXWKVLM, CYNTNYLLHQW
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x10F92A0", Offset = "0x10F82A0", VA = "0x1810F92A0")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9B28310", Offset = "0x9B27310", VA = "0x189B28310")]
			public object HCHCAWMAEYC(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class YMDBDAGFVMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FieldInfo QYBMNUDZPLR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Func<MonoBehaviour, object> QJROIKIBEXC;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YMDBDAGFVMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C6B0", Offset = "0x9B2B6B0", VA = "0x189B2C6B0")]
			internal RpcMethodInfo ENMGAFMXHPW(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x758CE70", Offset = "0x758BE70", VA = "0x18758CE70")]
			internal object ENRMXMGURBF(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class YLXUFTMIMAY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Func<MonoBehaviour, object> NASSQFRIJIL;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public YLXUFTMIMAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9B2C660", Offset = "0x9B2B660", VA = "0x189B2C660")]
			internal RpcMethodInfo EOXCHAWEVRH(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class LLBQWFUEPKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Type ACDSRXRIJOI;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LLBQWFUEPKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9B171D0", Offset = "0x9B161D0", VA = "0x189B171D0")]
			internal bool OZYTGOKJMJC(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static Dictionary<string, int> LVYSFRPZNFY;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static List<string> AHIQJHYNGRN;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static int CCBGNLYNDTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private WXMSOGSVJBD TKGGASBCIJW;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Stopwatch UXVZZVESGJU;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static Dictionary<MethodInfo, ParameterInfo[]> YDPILNFKPMF;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> THIGLNNFVOO;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B119D0", Offset = "0x9B109D0", VA = "0x189B119D0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9B138F0", Offset = "0x9B128F0", VA = "0x189B138F0")]
		private void TDQREHWUYKZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B11AD0", Offset = "0x9B10AD0", VA = "0x189B11AD0", Slot = "10")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xF6ACF0", Offset = "0xF69CF0", VA = "0x180F6ACF0", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9B103F0", Offset = "0x9B0F3F0", VA = "0x189B103F0", Slot = "5")]
		public void AALNHOBOWYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B11090", Offset = "0x9B10090", VA = "0x189B11090")]
		public static bool HPZDFSLCSAS(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9B13800", Offset = "0x9B12800", VA = "0x189B13800")]
		public static bool SCKHRDMLVPA(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B10E10", Offset = "0x9B0FE10", VA = "0x189B10E10")]
		private void FGHHYFWTLMH(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9B13DC0", Offset = "0x9B12DC0", VA = "0x189B13DC0", Slot = "9")]
		public string TVXKJNMIXSK(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9B11B20", Offset = "0x9B10B20", VA = "0x189B11B20", Slot = "8")]
		public void KSOJYXHPFRP(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9B109F0", Offset = "0x9B0F9F0", VA = "0x189B109F0", Slot = "6")]
		public void ARTCSILUAKP(ViewId a, string b, DDFOJMMWCEL c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9B10AC0", Offset = "0x9B0FAC0", VA = "0x189B10AC0", Slot = "7")]
		public void ARTCSILUAKP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9B10540", Offset = "0x9B0F540", VA = "0x189B10540")]
		private void ARTCSILUAKP(ViewId a, string b, RpcTarget c, DDFOJMMWCEL d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9B12090", Offset = "0x9B11090", VA = "0x189B12090")]
		private void QMKOWAZCHKC(ViewId a, string b, DDFOJMMWCEL c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9B11BD0", Offset = "0x9B10BD0", VA = "0x189B11BD0")]
		private static void PXWYPONDUES(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B10AF0", Offset = "0x9B0FAF0", VA = "0x189B10AF0")]
		private static bool DFAFDFNRUMR(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B11120", Offset = "0x9B10120", VA = "0x189B11120")]
		private List<RpcMethodInfo> HTJRRAQTHDW(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9B13700", Offset = "0x9B12700", VA = "0x189B13700")]
		private static IEnumerable<MethodInfo> RMYFIKEQXBU(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B10D00", Offset = "0x9B0FD00", VA = "0x189B10D00")]
		public static ParameterInfo[] DNRMQPGDCGW(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public HYOYEVCLUTS()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9B225F0", Offset = "0x9B215F0", VA = "0x189B225F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9B22570", Offset = "0x9B21570", VA = "0x189B22570")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRNetworkView : MonoBehaviour, CVWDRVYPYSK, ZEZVGGJERXZ, GIOUNSVYOHS, SZLHTNPOQJO, SCEIAZYJKHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[RegisterService(typeof(PJZRKIAGJCO), new string[] { })]
		internal class UWLFTBYNSPJ : QNFHPEUJUSR, EQFYRFRSSPD, PJZRKIAGJCO
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Dictionary<int, RRNetworkView> KIETYCHDQGI;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x9B289B0", Offset = "0x9B279B0", VA = "0x189B289B0", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x9B289B0", Offset = "0x9B279B0", VA = "0x189B289B0", Slot = "5")]
			public void AALNHOBOWYP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x9B289C0", Offset = "0x9B279C0", VA = "0x189B289C0", Slot = "6")]
			public void PLVZGBAGWIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public UWLFTBYNSPJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int FKCARVZLIFS;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x9B17420", Offset = "0x9B16420", VA = "0x189B17420")]
			internal bool DRCHLXZVHVG(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static SVLVGVMSMLM HVCOSDGRPVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private bool TJGEIIHIKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool IYHQFHXZJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool HYXPPMKQMET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int KXZAIYBKVBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool HSPJWPLMBXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int EXNABTVTUUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private DDFOJMMWCEL VZNWCMOFUPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private DDFOJMMWCEL YIXUSAVOAYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool? OZGXNCQGVGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool MDKEDFINSXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal bool WFVFBLBQPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal MonoBehaviour[] CLOEHMYQKKA;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Log YWOODTYNIMZ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> KIETYCHDQGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9B23000", Offset = "0x9B22000", VA = "0x189B23000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId BAUHYNCUZBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9B26C80", Offset = "0x9B25C80", VA = "0x189B26C80")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId HXNEEKIRAUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9B26C80", Offset = "0x9B25C80", VA = "0x189B26C80", Slot = "6")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId YVFGQNGUAIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9B26C80", Offset = "0x9B25C80", VA = "0x189B26C80")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HRAROBVXKVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD1B830", Offset = "0xD1A830", VA = "0x180D1B830")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD60B30", Offset = "0xD5FB30", VA = "0x180D60B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int YUBNKXQIYLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD322D0", Offset = "0xD312D0", VA = "0x180D322D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xF219B0", Offset = "0xF209B0", VA = "0x180F219B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId NXYPNAMBHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9B26AF0", Offset = "0x9B25AF0", VA = "0x189B26AF0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool EACQKTYBTTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xDA2110", Offset = "0xDA1110", VA = "0x180DA2110")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xDA2120", Offset = "0xDA1120", VA = "0x180DA2120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ZUBNPHBPCDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9B26B00", Offset = "0x9B25B00", VA = "0x189B26B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool HBRNUYVLEHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xD69190", Offset = "0xD68190", VA = "0x180D69190")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xD6A4F0", Offset = "0xD694F0", VA = "0x180D6A4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int LYWKLSBKUGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD5A350", Offset = "0xD59350", VA = "0x180D5A350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LTLOBVIVATP
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9B26A90", Offset = "0x9B25A90", VA = "0x189B26A90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public DDFOJMMWCEL LXLHHFKVPFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9B26C90", Offset = "0x9B25C90", VA = "0x189B26C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public DDFOJMMWCEL OOGYHCMDOHC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9B26A60", Offset = "0x9B25A60", VA = "0x189B26A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public DDFOJMMWCEL FFUGFXKYRYB
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9B26A60", Offset = "0x9B25A60", VA = "0x189B26A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public DDFOJMMWCEL BBVYPLXOXHD
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9B26A60", Offset = "0x9B25A60", VA = "0x189B26A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool HSNTEMAQYRH
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9B26BD0", Offset = "0x9B25BD0", VA = "0x189B26BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int NSLPLMKAYUF
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9B26AC0", Offset = "0x9B25AC0", VA = "0x189B26AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] ETENMNWZTMR
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD09120", Offset = "0xD08120", VA = "0x180D09120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD09170", Offset = "0xD08170", VA = "0x180D09170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool POOGZZCQVAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9B26CC0", Offset = "0x9B25CC0", VA = "0x189B26CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FHQTDDMIKSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9B26C50", Offset = "0x9B25C50", VA = "0x189B26C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool XKPOTKSKOSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xFC1920", Offset = "0xFC0920", VA = "0x180FC1920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xFC1440", Offset = "0xFC0440", VA = "0x180FC1440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool RHREZJRVEHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xFB1600", Offset = "0xFB0600", VA = "0x180FB1600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> GKQHAHPZBWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9B268F0", Offset = "0x9B258F0", VA = "0x189B268F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9B26E80", Offset = "0x9B25E80", VA = "0x189B26E80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<DDFOJMMWCEL> ZAJSZMTEBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9B238D0", Offset = "0x9B228D0", VA = "0x189B238D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9B22BF0", Offset = "0x9B21BF0", VA = "0x189B22BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<DDFOJMMWCEL> BAZVBVFFCXO
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9B238D0", Offset = "0x9B228D0", VA = "0x189B238D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9B22BF0", Offset = "0x9B21BF0", VA = "0x189B22BF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> UAWNUXJXZTF
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9B26650", Offset = "0x9B25650", VA = "0x189B26650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9B265A0", Offset = "0x9B255A0", VA = "0x189B265A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> OCZWAPJTLED
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9B26650", Offset = "0x9B25650", VA = "0x189B26650")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9B265A0", Offset = "0x9B255A0", VA = "0x189B265A0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> TUMKFKHTIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9B269A0", Offset = "0x9B259A0", VA = "0x189B269A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9B26F30", Offset = "0x9B25F30", VA = "0x189B26F30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action LBLMXJAYHXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9B26840", Offset = "0x9B25840", VA = "0x189B26840")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9B26DD0", Offset = "0x9B25DD0", VA = "0x189B26DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9B264E0", Offset = "0x9B254E0", VA = "0x189B264E0")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B23050", Offset = "0x9B22050", VA = "0x189B23050")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B231C0", Offset = "0x9B221C0", VA = "0x189B231C0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B23110", Offset = "0x9B22110", VA = "0x189B23110")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B24630", Offset = "0x9B23630", VA = "0x189B24630")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B243D0", Offset = "0x9B233D0", VA = "0x189B243D0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B23B30", Offset = "0x9B22B30", VA = "0x189B23B30")]
		public static void OnPlayerJoinedRoom(DDFOJMMWCEL newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B23330", Offset = "0x9B22330", VA = "0x189B23330")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9B23390", Offset = "0x9B22390", VA = "0x189B23390")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9B23750", Offset = "0x9B22750", VA = "0x189B23750")]
		private void KRIJORTXBMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9B22F80", Offset = "0x9B21F80", VA = "0x189B22F80")]
		public bool CreatedBy(DDFOJMMWCEL player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9B26290", Offset = "0x9B25290", VA = "0x189B26290")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9B26480", Offset = "0x9B25480", VA = "0x189B26480")]
		public void TransferOwnership(DDFOJMMWCEL newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9B234F0", Offset = "0x9B224F0", VA = "0x189B234F0", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B23490", Offset = "0x9B22490", VA = "0x189B23490")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9B22A90", Offset = "0x9B21A90", VA = "0x189B22A90")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9B23EA0", Offset = "0x9B22EA0", VA = "0x189B23EA0")]
		private void PDGCVQIEMVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1365D70", Offset = "0x1364D70", VA = "0x181365D70")]
		internal void DHTWJNADPUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9B22990", Offset = "0x9B21990", VA = "0x189B22990", Slot = "7")]
		private void AVFXKGBDDHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9B26700", Offset = "0x9B25700", VA = "0x189B26700")]
		internal bool ZYXWMTUQJOQ(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9B239F0", Offset = "0x9B229F0", VA = "0x189B239F0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9B23990", Offset = "0x9B22990", VA = "0x189B23990")]
		internal void OMTTIZXIOWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9B23980", Offset = "0x9B22980", VA = "0x189B23980")]
		private void MHKIFKHOSXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9B24120", Offset = "0x9B23120", VA = "0x189B24120")]
		internal void QNQWYWHEGQG(DDFOJMMWCEL a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9B24590", Offset = "0x9B23590", VA = "0x189B24590")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9B246E0", Offset = "0x9B236E0", VA = "0x189B246E0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9B23830", Offset = "0x9B22830", VA = "0x189B23830")]
		private void KWHMHHLGPCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9B23660", Offset = "0x9B22660", VA = "0x189B23660")]
		private void KINERQKXIOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9B24340", Offset = "0x9B23340", VA = "0x189B24340")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9B242B0", Offset = "0x9B232B0", VA = "0x189B242B0")]
		public void RPC(string methodName, DDFOJMMWCEL targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9B245E0", Offset = "0x9B235E0", VA = "0x189B245E0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9B22CA0", Offset = "0x9B21CA0", VA = "0x189B22CA0", Slot = "9")]
		public void Bake(NSNTXJAOJGZ context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9B22920", Offset = "0x9B21920", VA = "0x189B22920")]
		private static void AHCAXDIGCGL(DDFOJMMWCEL a, [Out] DDFOJMMWCEL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9B25FA0", Offset = "0x9B24FA0", VA = "0x189B25FA0")]
		private static void TVVSEJRADFI(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9B233F0", Offset = "0x9B223F0", VA = "0x189B233F0")]
		private static RPCInfo IZWAAETAWKP(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9B22840", Offset = "0x9B21840", VA = "0x189B22840")]
		private static void AAYNTRKRZEJ(RRNetworkView a, Delegate b, DDFOJMMWCEL c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9B22760", Offset = "0x9B21760", VA = "0x189B22760")]
		private static void AAYNTRKRZEJ(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9B22AE0", Offset = "0x9B21AE0", VA = "0x189B22AE0")]
		private static void BHRIHFEIAPM(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9B241E0", Offset = "0x9B231E0", VA = "0x189B241E0")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9B229F0", Offset = "0x9B219F0", VA = "0x189B229F0")]
		private static bool AYETVXLTMKL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9B24B90", Offset = "0x9B23B90", VA = "0x189B24B90", Slot = "26")]
		public void RpcAll(ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3E73EB0", Offset = "0x3E72EB0", VA = "0x183E73EB0", Slot = "10")]
		public void RpcAll<T1>(ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E73790", Offset = "0x3E72790", VA = "0x183E73790", Slot = "11")]
		public void RpcAll<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3E76100", Offset = "0x3E75100", VA = "0x183E76100", Slot = "27")]
		public void RpcAll<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3E73980", Offset = "0x3E72980", VA = "0x183E73980", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E744E0", Offset = "0x3E734E0", VA = "0x183E744E0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3E765B0", Offset = "0x3E755B0", VA = "0x183E765B0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3E74020", Offset = "0x3E73020", VA = "0x183E74020", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3E8AE40", Offset = "0x3E89E40", VA = "0x183E8AE40", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3E769E0", Offset = "0x3E759E0", VA = "0x183E769E0", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3E75240", Offset = "0x3E74240", VA = "0x183E75240", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E8F9B0", Offset = "0x3E8E9B0", VA = "0x183E8F9B0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3E88400", Offset = "0x3E87400", VA = "0x183E88400", Slot = "14")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3E7A790", Offset = "0x3E79790", VA = "0x183E7A790", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3E74A60", Offset = "0x3E73A60", VA = "0x183E74A60", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9B24D00", Offset = "0x9B23D00", VA = "0x189B24D00", Slot = "36")]
		public void RpcAll(ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3E88F90", Offset = "0x3E87F90", VA = "0x183E88F90", Slot = "37")]
		public void RpcAll<T1>(ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3E88AB0", Offset = "0x3E87AB0", VA = "0x183E88AB0", Slot = "38")]
		public void RpcAll<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3E75A60", Offset = "0x3E74A60", VA = "0x183E75A60", Slot = "39")]
		public void RpcAll<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3E859D0", Offset = "0x3E849D0", VA = "0x183E859D0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3E85340", Offset = "0x3E84340", VA = "0x183E85340", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3E83DE0", Offset = "0x3E82DE0", VA = "0x183E83DE0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3E82CB0", Offset = "0x3E81CB0", VA = "0x183E82CB0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3E822D0", Offset = "0x3E812D0", VA = "0x183E822D0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3E80E70", Offset = "0x3E7FE70", VA = "0x183E80E70", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F7E0", Offset = "0x3E7E7E0", VA = "0x183E7F7E0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D280", Offset = "0x3E7C280", VA = "0x183E7D280", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7B680", Offset = "0x3E7A680", VA = "0x183E7B680", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3E79840", Offset = "0x3E78840", VA = "0x183E79840", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3E777C0", Offset = "0x3E767C0", VA = "0x183E777C0", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9B24A60", Offset = "0x9B23A60", VA = "0x189B24A60", Slot = "51")]
		public void RpcAllViaServer(ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3E732C0", Offset = "0x3E722C0", VA = "0x183E732C0", Slot = "52")]
		public void RpcAllViaServer<T1>(ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3E73450", Offset = "0x3E72450", VA = "0x183E73450", Slot = "15")]
		public void RpcAllViaServer<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3E72D60", Offset = "0x3E71D60", VA = "0x183E72D60", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3E72980", Offset = "0x3E71980", VA = "0x183E72980", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3E724E0", Offset = "0x3E714E0", VA = "0x183E724E0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3E71F80", Offset = "0x3E70F80", VA = "0x183E71F80", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3E71960", Offset = "0x3E70960", VA = "0x183E71960", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E71280", Offset = "0x3E70280", VA = "0x183E71280", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3E70AE0", Offset = "0x3E6FAE0", VA = "0x183E70AE0", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3E70280", Offset = "0x3E6F280", VA = "0x183E70280", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F960", Offset = "0x3E6E960", VA = "0x183E6F960", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EF70", Offset = "0x3E6DF70", VA = "0x183E6EF70", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E4C0", Offset = "0x3E6D4C0", VA = "0x183E6E4C0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D930", Offset = "0x3E6C930", VA = "0x183E6D930", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9B24930", Offset = "0x9B23930", VA = "0x189B24930", Slot = "65")]
		public void RpcAllViaServer(ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3E732C0", Offset = "0x3E722C0", VA = "0x183E732C0", Slot = "66")]
		public void RpcAllViaServer<T1>(ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3E73070", Offset = "0x3E72070", VA = "0x183E73070", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3E72D60", Offset = "0x3E71D60", VA = "0x183E72D60", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3E72980", Offset = "0x3E71980", VA = "0x183E72980", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3E724E0", Offset = "0x3E714E0", VA = "0x183E724E0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3E71F80", Offset = "0x3E70F80", VA = "0x183E71F80", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3E71960", Offset = "0x3E70960", VA = "0x183E71960", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3E71280", Offset = "0x3E70280", VA = "0x183E71280", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E70AE0", Offset = "0x3E6FAE0", VA = "0x183E70AE0", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E70280", Offset = "0x3E6F280", VA = "0x183E70280", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E6F960", Offset = "0x3E6E960", VA = "0x183E6F960", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6EF70", Offset = "0x3E6DF70", VA = "0x183E6EF70", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E4C0", Offset = "0x3E6D4C0", VA = "0x183E6E4C0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D930", Offset = "0x3E6C930", VA = "0x183E6D930", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9B25850", Offset = "0x9B24850", VA = "0x189B25850", Slot = "80")]
		public void RpcOthers(ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9320", Offset = "0x3EC8320", VA = "0x183EC9320", Slot = "16")]
		public void RpcOthers<T1>(ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF8D0", Offset = "0x3ECE8D0", VA = "0x183ECF8D0", Slot = "81")]
		public void RpcOthers<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3EC90D0", Offset = "0x3EC80D0", VA = "0x183EC90D0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3ED27A0", Offset = "0x3ED17A0", VA = "0x183ED27A0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE1A0", Offset = "0x3ECD1A0", VA = "0x183ECE1A0", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0670", Offset = "0x3ECF670", VA = "0x183ED0670", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD5D0", Offset = "0x3ECC5D0", VA = "0x183ECD5D0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3ED12E0", Offset = "0x3ED02E0", VA = "0x183ED12E0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC6F0", Offset = "0x3ECB6F0", VA = "0x183ECC6F0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0DE0", Offset = "0x3ECFDE0", VA = "0x183ED0DE0", Slot = "17")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB510", Offset = "0x3ECA510", VA = "0x183ECB510", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAB00", Offset = "0x3EC9B00", VA = "0x183ECAB00", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3ECA020", Offset = "0x3EC9020", VA = "0x183ECA020", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9470", Offset = "0x3EC8470", VA = "0x183EC9470", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9B259A0", Offset = "0x9B249A0", VA = "0x189B259A0", Slot = "93")]
		public void RpcOthers(ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF630", Offset = "0x3ECE630", VA = "0x183ECF630", Slot = "94")]
		public void RpcOthers<T1>(ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF470", Offset = "0x3ECE470", VA = "0x183ECF470", Slot = "95")]
		public void RpcOthers<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3ECEA60", Offset = "0x3ECDA60", VA = "0x183ECEA60", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3ECF1C0", Offset = "0x3ECE1C0", VA = "0x183ECF1C0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3ECFDE0", Offset = "0x3ECEDE0", VA = "0x183ECFDE0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3ED00F0", Offset = "0x3ECF0F0", VA = "0x183ED00F0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD5D0", Offset = "0x3ECC5D0", VA = "0x183ECD5D0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCEC0", Offset = "0x3ECBEC0", VA = "0x183ECCEC0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC6F0", Offset = "0x3ECB6F0", VA = "0x183ECC6F0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBE60", Offset = "0x3ECAE60", VA = "0x183ECBE60", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB510", Offset = "0x3ECA510", VA = "0x183ECB510", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAB00", Offset = "0x3EC9B00", VA = "0x183ECAB00", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3ECA020", Offset = "0x3EC9020", VA = "0x183ECA020", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9470", Offset = "0x3EC8470", VA = "0x183EC9470", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9B25580", Offset = "0x9B24580", VA = "0x189B25580", Slot = "108")]
		public void RpcMaster(ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB920", Offset = "0x3EAA920", VA = "0x183EAB920", Slot = "109")]
		public void RpcMaster<T1>(ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EABAC0", Offset = "0x3EAAAC0", VA = "0x183EABAC0", Slot = "110")]
		public void RpcMaster<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EAAF30", Offset = "0x3EA9F30", VA = "0x183EAAF30", Slot = "111")]
		public void RpcMaster<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB190", Offset = "0x3EAA190", VA = "0x183EAB190", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE040", Offset = "0x3EBD040", VA = "0x183EBE040", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EC00A0", Offset = "0x3EBF0A0", VA = "0x183EC00A0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7B50", Offset = "0x3EB6B50", VA = "0x183EB7B50", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5F20", Offset = "0x3EB4F20", VA = "0x183EB5F20", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4990", Offset = "0x3EB3990", VA = "0x183EB4990", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EBDA90", Offset = "0x3EBCA90", VA = "0x183EBDA90", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD450", Offset = "0x3EBC450", VA = "0x183EBD450", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0A20", Offset = "0x3EAFA20", VA = "0x183EB0A20", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EADD80", Offset = "0x3EACD80", VA = "0x183EADD80", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EACD60", Offset = "0x3EABD60", VA = "0x183EACD60", Slot = "122")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9B25340", Offset = "0x9B24340", VA = "0x189B25340", Slot = "123")]
		public void RpcMaster(ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB740", Offset = "0x3EAA740", VA = "0x183EAB740", Slot = "124")]
		public void RpcMaster<T1>(ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EBC770", Offset = "0x3EBB770", VA = "0x183EBC770", Slot = "125")]
		public void RpcMaster<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EBBFC0", Offset = "0x3EBAFC0", VA = "0x183EBBFC0", Slot = "126")]
		public void RpcMaster<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA010", Offset = "0x3EB9010", VA = "0x183EBA010", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3EBE810", Offset = "0x3EBD810", VA = "0x183EBE810", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3EB83D0", Offset = "0x3EB73D0", VA = "0x183EB83D0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7280", Offset = "0x3EB6280", VA = "0x183EB7280", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3EB68A0", Offset = "0x3EB58A0", VA = "0x183EB68A0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5420", Offset = "0x3EB4420", VA = "0x183EB5420", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EB31E0", Offset = "0x3EB21E0", VA = "0x183EB31E0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EB24C0", Offset = "0x3EB14C0", VA = "0x183EB24C0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EAFBE0", Offset = "0x3EAEBE0", VA = "0x183EAFBE0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3EAEC80", Offset = "0x3EADC80", VA = "0x183EAEC80", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3EABCE0", Offset = "0x3EAACE0", VA = "0x183EABCE0", Slot = "137")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B24F30", Offset = "0x9B23F30", VA = "0x189B24F30", Slot = "138")]
		public void RpcAuthority(ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3E949A0", Offset = "0x3E939A0", VA = "0x183E949A0", Slot = "139")]
		public void RpcAuthority<T1>(ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3E94760", Offset = "0x3E93760", VA = "0x183E94760", Slot = "140")]
		public void RpcAuthority<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5BD0", Offset = "0x3EA4BD0", VA = "0x183EA5BD0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7410", Offset = "0x3EA6410", VA = "0x183EA7410", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3E943C0", Offset = "0x3E933C0", VA = "0x183E943C0", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3EA15A0", Offset = "0x3EA05A0", VA = "0x183EA15A0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3EA03E0", Offset = "0x3E9F3E0", VA = "0x183EA03E0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F010", Offset = "0x3E9E010", VA = "0x183E9F010", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DA10", Offset = "0x3E9CA10", VA = "0x183E9DA10", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C1F0", Offset = "0x3E9B1F0", VA = "0x183E9C1F0", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8D30", Offset = "0x3EA7D30", VA = "0x183EA8D30", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5310", Offset = "0x3EA4310", VA = "0x183EA5310", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3E97BF0", Offset = "0x3E96BF0", VA = "0x183E97BF0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E94B50", Offset = "0x3E93B50", VA = "0x183E94B50", Slot = "152")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9B250E0", Offset = "0x9B240E0", VA = "0x189B250E0", Slot = "153")]
		public void RpcAuthority(ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5060", Offset = "0x3EA4060", VA = "0x183EA5060", Slot = "154")]
		public void RpcAuthority<T1>(ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4700", Offset = "0x3EA3700", VA = "0x183EA4700", Slot = "155")]
		public void RpcAuthority<T1, T2>(ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4240", Offset = "0x3EA3240", VA = "0x183EA4240", Slot = "156")]
		public void RpcAuthority<T1, T2, T3>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3EA3280", Offset = "0x3EA2280", VA = "0x183EA3280", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2530", Offset = "0x3EA1530", VA = "0x183EA2530", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1D40", Offset = "0x3EA0D40", VA = "0x183EA1D40", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0CA0", Offset = "0x3E9FCA0", VA = "0x183EA0CA0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F9D0", Offset = "0x3E9E9D0", VA = "0x183E9F9D0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E4E0", Offset = "0x3E9D4E0", VA = "0x183E9E4E0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E9CDD0", Offset = "0x3E9BDD0", VA = "0x183E9CDD0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A7A0", Offset = "0x3E997A0", VA = "0x183E9A7A0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3E98B20", Offset = "0x3E97B20", VA = "0x183E98B20", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3E96C60", Offset = "0x3E95C60", VA = "0x183E96C60", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3E95BA0", Offset = "0x3E94BA0", VA = "0x183E95BA0", Slot = "167")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9B25AF0", Offset = "0x9B24AF0", VA = "0x189B25AF0", Slot = "18")]
		public void RpcPlayer(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2D00", Offset = "0x3ED1D00", VA = "0x183ED2D00", Slot = "19")]
		public void RpcPlayer<T1>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3ED39A0", Offset = "0x3ED29A0", VA = "0x183ED39A0", Slot = "20")]
		public void RpcPlayer<T1, T2>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3420", Offset = "0x3ED2420", VA = "0x183ED3420", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2EC0", Offset = "0x3ED1EC0", VA = "0x183ED2EC0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7770", Offset = "0x3EE6770", VA = "0x183EE7770", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7360", Offset = "0x3EE6360", VA = "0x183EE7360", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7B00", Offset = "0x3EE6B00", VA = "0x183EE7B00", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7F70", Offset = "0x3EE6F70", VA = "0x183EE7F70", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEEE0", Offset = "0x3EDDEE0", VA = "0x183EDEEE0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE300", Offset = "0x3EDD300", VA = "0x183EDE300", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3ED41F0", Offset = "0x3ED31F0", VA = "0x183ED41F0", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3EDAE30", Offset = "0x3ED9E30", VA = "0x183EDAE30", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3EEC9D0", Offset = "0x3EEB9D0", VA = "0x183EEC9D0", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5F90", Offset = "0x3ED4F90", VA = "0x183ED5F90", Slot = "176")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B25CE0", Offset = "0x9B24CE0", VA = "0x189B25CE0", Slot = "177")]
		public void RpcPlayer(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3210", Offset = "0x3ED2210", VA = "0x183ED3210", Slot = "178")]
		public void RpcPlayer<T1>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3F30", Offset = "0x3ED2F30", VA = "0x183ED3F30", Slot = "24")]
		public void RpcPlayer<T1, T2>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3BF0", Offset = "0x3ED2BF0", VA = "0x183ED3BF0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5800", Offset = "0x3ED4800", VA = "0x183ED5800", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3EE39F0", Offset = "0x3EE29F0", VA = "0x183EE39F0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3200", Offset = "0x3EE2200", VA = "0x183EE3200", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3EE18B0", Offset = "0x3EE08B0", VA = "0x183EE18B0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0EA0", Offset = "0x3EDFEA0", VA = "0x183EE0EA0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF9B0", Offset = "0x3EDE9B0", VA = "0x183EDF9B0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD6B0", Offset = "0x3EDC6B0", VA = "0x183EDD6B0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC950", Offset = "0x3EDB950", VA = "0x183EDC950", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9FB0", Offset = "0x3ED8FB0", VA = "0x183ED9FB0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED80D0", Offset = "0x3ED70D0", VA = "0x183ED80D0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7000", Offset = "0x3ED6000", VA = "0x183ED7000", Slot = "189")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DDFOJMMWCEL player, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9B24890", Offset = "0x9B23890", VA = "0x189B24890", Slot = "190")]
		public void RpcAllBuffered(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D790", Offset = "0x3E6C790", VA = "0x183E6D790", Slot = "191")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D540", Offset = "0x3E6C540", VA = "0x183E6D540", Slot = "192")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D220", Offset = "0x3E6C220", VA = "0x183E6D220", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CE40", Offset = "0x3E6BE40", VA = "0x183E6CE40", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C9A0", Offset = "0x3E6B9A0", VA = "0x183E6C9A0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C440", Offset = "0x3E6B440", VA = "0x183E6C440", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E6BE20", Offset = "0x3E6AE20", VA = "0x183E6BE20", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B740", Offset = "0x3E6A740", VA = "0x183E6B740", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3E6AFA0", Offset = "0x3E69FA0", VA = "0x183E6AFA0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A730", Offset = "0x3E69730", VA = "0x183E6A730", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3E69E00", Offset = "0x3E68E00", VA = "0x183E69E00", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3E69410", Offset = "0x3E68410", VA = "0x183E69410", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3E68950", Offset = "0x3E67950", VA = "0x183E68950", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3E67DC0", Offset = "0x3E66DC0", VA = "0x183E67DC0", Slot = "204")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9B247F0", Offset = "0x9B237F0", VA = "0x189B247F0", Slot = "205")]
		public void RpcAllBuffered(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D790", Offset = "0x3E6C790", VA = "0x183E6D790", Slot = "206")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D540", Offset = "0x3E6C540", VA = "0x183E6D540", Slot = "207")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D220", Offset = "0x3E6C220", VA = "0x183E6D220", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CE40", Offset = "0x3E6BE40", VA = "0x183E6CE40", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C9A0", Offset = "0x3E6B9A0", VA = "0x183E6C9A0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6C440", Offset = "0x3E6B440", VA = "0x183E6C440", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6BE20", Offset = "0x3E6AE20", VA = "0x183E6BE20", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6B740", Offset = "0x3E6A740", VA = "0x183E6B740", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6AFA0", Offset = "0x3E69FA0", VA = "0x183E6AFA0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A730", Offset = "0x3E69730", VA = "0x183E6A730", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3E69E00", Offset = "0x3E68E00", VA = "0x183E69E00", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3E69410", Offset = "0x3E68410", VA = "0x183E69410", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3E68950", Offset = "0x3E67950", VA = "0x183E68950", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3E67DC0", Offset = "0x3E66DC0", VA = "0x183E67DC0", Slot = "219")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9B257B0", Offset = "0x9B247B0", VA = "0x189B257B0", Slot = "220")]
		public void RpcOthersBuffered(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8F30", Offset = "0x3EC7F30", VA = "0x183EC8F30", Slot = "221")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8CE0", Offset = "0x3EC7CE0", VA = "0x183EC8CE0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3EC89D0", Offset = "0x3EC79D0", VA = "0x183EC89D0", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3EC85F0", Offset = "0x3EC75F0", VA = "0x183EC85F0", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8150", Offset = "0x3EC7150", VA = "0x183EC8150", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7BF0", Offset = "0x3EC6BF0", VA = "0x183EC7BF0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC75D0", Offset = "0x3EC65D0", VA = "0x183EC75D0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6EF0", Offset = "0x3EC5EF0", VA = "0x183EC6EF0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6750", Offset = "0x3EC5750", VA = "0x183EC6750", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5EE0", Offset = "0x3EC4EE0", VA = "0x183EC5EE0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3EC55B0", Offset = "0x3EC45B0", VA = "0x183EC55B0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4BC0", Offset = "0x3EC3BC0", VA = "0x183EC4BC0", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4100", Offset = "0x3EC3100", VA = "0x183EC4100", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3570", Offset = "0x3EC2570", VA = "0x183EC3570", Slot = "234")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9B25710", Offset = "0x9B24710", VA = "0x189B25710", Slot = "235")]
		public void RpcOthersBuffered(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8F30", Offset = "0x3EC7F30", VA = "0x183EC8F30", Slot = "236")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8CE0", Offset = "0x3EC7CE0", VA = "0x183EC8CE0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3EC89D0", Offset = "0x3EC79D0", VA = "0x183EC89D0", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3EC85F0", Offset = "0x3EC75F0", VA = "0x183EC85F0", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8150", Offset = "0x3EC7150", VA = "0x183EC8150", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7BF0", Offset = "0x3EC6BF0", VA = "0x183EC7BF0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC75D0", Offset = "0x3EC65D0", VA = "0x183EC75D0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6EF0", Offset = "0x3EC5EF0", VA = "0x183EC6EF0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6750", Offset = "0x3EC5750", VA = "0x183EC6750", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5EE0", Offset = "0x3EC4EE0", VA = "0x183EC5EE0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3EC55B0", Offset = "0x3EC45B0", VA = "0x183EC55B0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4BC0", Offset = "0x3EC3BC0", VA = "0x183EC4BC0", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3EC4100", Offset = "0x3EC3100", VA = "0x183EC4100", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3EC3570", Offset = "0x3EC2570", VA = "0x183EC3570", Slot = "249")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, ZYVMVUOJFSW.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9B22D10", Offset = "0x9B21D10", VA = "0x189B22D10", Slot = "250")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9B22F20", Offset = "0x9B21F20", VA = "0x189B22F20", Slot = "251")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1753CF0", Offset = "0x1752CF0", VA = "0x181753CF0")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class BREOQVDCSIV
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E4E0", Offset = "0x9B0D4E0", VA = "0x189B0E4E0")]
		private static bool TTSWJQRNZQS(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3743070", Offset = "0x3742070", VA = "0x183743070")]
		[CanBeNull]
		public static a NXHZVCUMXZU<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class JRFIKRCKNGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public DDFOJMMWCEL[] FTTBUVOORFX;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public JRFIKRCKNGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x9B156E0", Offset = "0x9B146E0", VA = "0x189B156E0")]
			internal int YEUYJLUJUFH(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x9B15650", Offset = "0x9B14650", VA = "0x189B15650")]
			internal void YEPRMFAMKTY(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static DDFOJMMWCEL[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal int RAJGQMOJYWE;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9B27150", Offset = "0x9B26150", VA = "0x189B27150")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9B27730", Offset = "0x9B26730", VA = "0x189B27730")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9B27AD0", Offset = "0x9B26AD0", VA = "0x189B27AD0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9B27B50", Offset = "0x9B26B50", VA = "0x189B27B50")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9B26FF0", Offset = "0x9B25FF0", VA = "0x189B26FF0")]
		private void ANTIOAUIDAI(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9B26FF0", Offset = "0x9B25FF0", VA = "0x189B26FF0")]
		private void TBMDJJXXEKO(DDFOJMMWCEL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9B27650", Offset = "0x9B26650", VA = "0x189B27650")]
		private void GHVELZUWBWI(DDFOJMMWCEL a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9B27000", Offset = "0x9B26000", VA = "0x189B27000")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9B27C00", Offset = "0x9B26C00", VA = "0x189B27C00")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9B27560", Offset = "0x9B26560", VA = "0x189B27560")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xD1B6C0", Offset = "0xD1A6C0", VA = "0x180D1B6C0")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class PRYHAUFZVQW
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9B176C0", Offset = "0x9B166C0", VA = "0x189B176C0")]
		public static int AOKIORLPAFS(this DDFOJMMWCEL a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9B17850", Offset = "0x9B16850", VA = "0x189B17850")]
		public static void IHFSQDBQTRK(this DDFOJMMWCEL a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class IFBUBZAGMZS
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void RoomPropertyUpdateCallback(Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void PlayerPropertyUpdateCallback(DDFOJMMWCEL player, Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback JCSMVXMSZFE
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x9B141E0", Offset = "0x9B131E0", VA = "0x189B141E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x9B14360", Offset = "0x9B13360", VA = "0x189B14360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback ACIKFTAUNNL
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x9B14420", Offset = "0x9B13420", VA = "0x189B14420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x9B145A0", Offset = "0x9B135A0", VA = "0x189B145A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback LPMVPBUXPQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9B142A0", Offset = "0x9B132A0", VA = "0x189B142A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9B14060", Offset = "0x9B13060", VA = "0x189B14060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback CVGENUMBBKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x9B14120", Offset = "0x9B13120", VA = "0x189B14120")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x9B144E0", Offset = "0x9B134E0", VA = "0x189B144E0")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class KDTTVJVDTIV
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static int BEPEDUQEQEP;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static int RHKFWFSSZTF;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static int SNWGHZLBMKR;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9B15760", Offset = "0x9B14760", VA = "0x189B15760")]
		public static void AVPGJMYPJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9B157B0", Offset = "0x9B147B0", VA = "0x189B157B0")]
		public static void EGBGSOUGJRW(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9B15890", Offset = "0x9B14890", VA = "0x189B15890")]
		public static int NNTCFOUAFVZ(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RegisterService(typeof(IDEIBCHCWET), new string[] { })]
	public class XTCIFANGUPX : IDEIBCHCWET
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Dictionary<object, object> GRUJFNAIGKG;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly Dictionary<object, object> FQOKOMOYYNI;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly Dictionary<object, object> JUJHVILELCG;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly SVLVGVMSMLM OFUPFYURTBK;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly SVLVGVMSMLM SASSSXUAEYX;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly SVLVGVMSMLM THXJNTNXVSL;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly SVLVGVMSMLM FQRDJBMDAJI;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly SVLVGVMSMLM INCMTKRXOXZ;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int MVXCEJJMGGY;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9B2C010", Offset = "0x9B2B010", VA = "0x189B2C010", Slot = "4")]
		public bool XWHANLJQIYG(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9B2AED0", Offset = "0x9B29ED0", VA = "0x189B2AED0", Slot = "5")]
		public int PMIPTDFBPWS(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A6A0", Offset = "0x9B296A0", VA = "0x189B2A6A0", Slot = "6")]
		public bool GTZPYSJYDTD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A9E0", Offset = "0x9B299E0", VA = "0x189B2A9E0", Slot = "7")]
		public bool JZHLDGPPAIU(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9B2ACB0", Offset = "0x9B29CB0", VA = "0x189B2ACB0", Slot = "8")]
		public void KQHXDIKITBT(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A530", Offset = "0x9B29530", VA = "0x189B2A530", Slot = "9")]
		public bool FDHRBUEFFZT(VZMXLASXEMR a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9B2BCE0", Offset = "0x9B2ACE0", VA = "0x189B2BCE0", Slot = "10")]
		public bool VKDCGQKFBPQ(VZMXLASXEMR a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A8A0", Offset = "0x9B298A0", VA = "0x189B2A8A0", Slot = "11")]
		public bool HXKHYPZQPQL(VZMXLASXEMR a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9B2B2E0", Offset = "0x9B2A2E0", VA = "0x189B2B2E0", Slot = "12")]
		public void ROFCRUITRZR(VZMXLASXEMR a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9B29990", Offset = "0x9B28990", VA = "0x189B29990", Slot = "13")]
		public void BGYUGGEFIFK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9B2A730", Offset = "0x9B29730", VA = "0x189B2A730", Slot = "14")]
		public void HSWRYBTZAIS(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9B2BC00", Offset = "0x9B2AC00", VA = "0x189B2BC00", Slot = "15")]
		public void TOISERKROUK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9B2ABA0", Offset = "0x9B29BA0", VA = "0x189B2ABA0", Slot = "16")]
		public void KNLVRWLETSJ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9B29B50", Offset = "0x9B28B50", VA = "0x189B29B50", Slot = "17")]
		public void DOZBGNVEHKZ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9B2B530", Offset = "0x9B2A530", VA = "0x189B2B530")]
		private static void RPLNNGXXAFC(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9B29D10", Offset = "0x9B28D10", VA = "0x189B29D10")]
		private static bool FDHRBUEFFZT(Dictionary<object, object> a, DDFOJMMWCEL b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9B2BA80", Offset = "0x9B2AA80", VA = "0x189B2BA80")]
		private static bool RPQECIGVOSC(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9B2BB20", Offset = "0x9B2AB20", VA = "0x189B2BB20")]
		private static int TFVMBCBBYRA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public XTCIFANGUPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RegisterService(typeof(WXMSOGSVJBD), new string[] { })]
	public class JJFTIRCILYT : WXMSOGSVJBD
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly object ZYJKESVAZOX;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly object ZYEDHMBDQDO;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly object ZYTXZGIVSLP;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly object ZYORBZOYJAG;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly object ZXOIPRTLNVN;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static Dictionary<object, object> FLPEMBNGSFH;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static Dictionary<object, object> LLWBSFBGJFK;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static SVLVGVMSMLM DLYAGOXHZLP;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly SVLVGVMSMLM UGFQBGGENYA;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9B14D30", Offset = "0x9B13D30", VA = "0x189B14D30", Slot = "4")]
		public void KSOJYXHPFRP(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9B14E30", Offset = "0x9B13E30", VA = "0x189B14E30", Slot = "5")]
		public bool NTIKDBPFHHH(VZMXLASXEMR a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9B14660", Offset = "0x9B13660", VA = "0x189B14660", Slot = "6")]
		public void CGRVOOVTKBN(ViewId a, string b, RpcTarget c, DDFOJMMWCEL d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public JJFTIRCILYT()
		{
		}
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
