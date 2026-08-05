using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;
using RecRoom;
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
		[Cpp2IlInjected.Address(RVA = "0x862DA60", Offset = "0x862C060", VA = "0x18862DA60", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		private int[] TPUBNGGXPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] TPZIKNAUYZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EHSYFWCIGXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EHNRIPIKXLW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x241FAE0", Offset = "0x241E0E0", VA = "0x18241FAE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8646290", Offset = "0x8644890", VA = "0x188646290")]
		private void UAFZRFJIDZJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8646030", Offset = "0x8644630", VA = "0x188646030")]
		private void UAASTYPKUOA(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8645F80", Offset = "0x8644580", VA = "0x188645F80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86469B0", Offset = "0x8644FB0", VA = "0x1886469B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class NTMONFRLFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log PBBTIUZEHMH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log NTIICHSWCXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x862EA10", Offset = "0x862D010", VA = "0x18862EA10")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OVTNSTZVZRX
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView UTKAVBFHTRM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType WZRYSBHXNXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool EIMJOXLHWRY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "2")]
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
	internal interface HDFYGGZLGZF
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool JMYYHICKAKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IFEXUWCMUQW(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface RNCUYKMLGDO : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KQPXXDZDTRT(OVTNSTZVZRX a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VJDYMFSHNXM(OVTNSTZVZRX a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(XNJLLINLFPH.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DTWORKFBIEL();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VNJCSOGXCKG(object a);
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
	public class SBUIRLCHPQV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), HDFYGGZLGZF> RDWCATIECZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<OVTNSTZVZRX> OAKVRMVILGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> DXUJYIGFKCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int HLFIKOMYNGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool YEJBWRFFHTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private XNJLLINLFPH.ApplyNetworkTransform QRMEPYXCZWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream RJFECIAAEJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker RXVEDEYXCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker DCWVXTSBEFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] ZTQTOOXETYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float IZNPDVZXPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int XLQAYWQMPCJ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86435C0", Offset = "0x8641BC0", VA = "0x1886435C0")]
		public SBUIRLCHPQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8642E70", Offset = "0x8641470", VA = "0x188642E70")]
		public void Pause(XNJLLINLFPH.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8642610", Offset = "0x8640C10", VA = "0x188642610")]
		public void DTWORKFBIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86431F0", Offset = "0x86417F0", VA = "0x1886431F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8642090", Offset = "0x8640690", VA = "0x188642090")]
		public bool Add(OVTNSTZVZRX networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8642E90", Offset = "0x8641490", VA = "0x188642E90")]
		public bool Remove(OVTNSTZVZRX networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8642FC0", Offset = "0x86415C0", VA = "0x188642FC0")]
		private HDFYGGZLGZF SHFJXFNJWYW(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8642E60", Offset = "0x8641460", VA = "0x188642E60")]
		public void PJBYZNYNWCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8642E00", Offset = "0x8641400", VA = "0x188642E00")]
		private void MXXCOVARFME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86431D0", Offset = "0x86417D0", VA = "0x1886431D0")]
		private void UJQMGXQAIYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8642A50", Offset = "0x8641050", VA = "0x188642A50")]
		public bool GZQMWTSWKII(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8642660", Offset = "0x8640C60", VA = "0x188642660")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class YCNZGRKJJDC : HDFYGGZLGZF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private OVTNSTZVZRX UMHECDCMJRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint VJSBWDMRDWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int KVOVYEPVHJG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JMYYHICKAKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public YCNZGRKJJDC(OVTNSTZVZRX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8645C50", Offset = "0x8644250", VA = "0x188645C50", Slot = "5")]
		public bool IFEXUWCMUQW(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8645B70", Offset = "0x8644170", VA = "0x188645B70", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ZJEGGZEYWYP : HDFYGGZLGZF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private XNJLLINLFPH.ApplyNetworkTransform QRMEPYXCZWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId KNFYPJMDMXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int KVOVYEPVHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint VJSBWDMRDWL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JMYYHICKAKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D1A5B0", Offset = "0x1D18BB0", VA = "0x181D1A5B0")]
		public ZJEGGZEYWYP(ViewId a, XNJLLINLFPH.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8645F40", Offset = "0x8644540", VA = "0x188645F40", Slot = "5")]
		public bool IFEXUWCMUQW(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8645D60", Offset = "0x8644360", VA = "0x188645D60", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class WODTLPZEFWL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8644B30", Offset = "0x8643130", VA = "0x188644B30")]
		public static void KYZOGDONURM(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86450A0", Offset = "0x86436A0", VA = "0x1886450A0")]
		public static void RWZVNDZMXRZ(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86449C0", Offset = "0x8642FC0", VA = "0x1886449C0")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8644CF0", Offset = "0x86432F0", VA = "0x188644CF0")]
		public static void OYTDGRGZLJI(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RNCUYKMLGDO), new string[] { })]
	public class CKVBJCDOKHF : RNCUYKMLGDO, INetworkUpdateSystem, UUPKZPXZDMZ, SPJAMBOPKUB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log VSLQEFYCCJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private SBUIRLCHPQV IRQZAULLFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint GTWIEMXWEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float CPMSJREFULT;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8625BB0", Offset = "0x86241B0", VA = "0x188625BB0", Slot = "4")]
		public void KQPXXDZDTRT(OVTNSTZVZRX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8625D80", Offset = "0x8624380", VA = "0x188625D80", Slot = "5")]
		public void VJDYMFSHNXM(OVTNSTZVZRX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8625A60", Offset = "0x8624060", VA = "0x188625A60", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8625CD0", Offset = "0x86242D0", VA = "0x188625CD0", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8624F40", Offset = "0x8623540", VA = "0x188624F40")]
		private void BNXZJADKIBL(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8625D50", Offset = "0x8624350", VA = "0x188625D50", Slot = "6")]
		public void Pause(XNJLLINLFPH.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8625550", Offset = "0x8623B50", VA = "0x188625550", Slot = "7")]
		public void DTWORKFBIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8625F80", Offset = "0x8624580", VA = "0x188625F80", Slot = "8")]
		public void VNJCSOGXCKG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86255B0", Offset = "0x8623BB0", VA = "0x1886255B0")]
		private void HRVRANTSQAL(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8625940", Offset = "0x8623F40", VA = "0x188625940", Slot = "11")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8625FE0", Offset = "0x86245E0", VA = "0x188625FE0")]
		public CKVBJCDOKHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SDJSXDWADCV : HDFYGGZLGZF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float DEQJHXJXNUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int KVOVYEPVHJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint VJSBWDMRDWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType LZRROHXPADU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo UUBWYYGUUWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int PHKTACLKZVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] QPKJCNHRSTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo IGVIUYPESZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int SBSVUPZKZHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] DUMTXUGPPMD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JMYYHICKAKX
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8643C60", Offset = "0x8642260", VA = "0x188643C60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8643C90", Offset = "0x8642290", VA = "0x188643C90")]
		public SDJSXDWADCV(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8643C20", Offset = "0x8642220", VA = "0x188643C20", Slot = "5")]
		public bool IFEXUWCMUQW(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x86437B0", Offset = "0x8641DB0", VA = "0x1886437B0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8643960", Offset = "0x8641F60", VA = "0x188643960")]
		internal YCNZGRKJJDC FXPBUUKKZSB(OVTNSTZVZRX a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8643A60", Offset = "0x8642060", VA = "0x188643A60")]
		private static void GGYWQZLNYJL(YCNZGRKJJDC a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RegisterService(typeof(QBQSIYAWUCE), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class QBQSIYAWUCE : SJEOPBKQURR, UUPKZPXZDMZ, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Hashtable OBJGHDHIENY;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Hashtable JPKCWWYMBPY;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Hashtable HAIHFONELUK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly KAUBEGREKJA HYHTDUERTDO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly KAUBEGREKJA MLCECWTYEZF;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly KAUBEGREKJA QSCBXUWFZCT;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly KAUBEGREKJA RISRPVCKRHY;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly KAUBEGREKJA QYXBLRCGSWD;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static int FBPQCRNZEPG;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8638F30", Offset = "0x8637530", VA = "0x188638F30", Slot = "4")]
		public bool FRFRCHITJDE(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86399A0", Offset = "0x8637FA0", VA = "0x1886399A0", Slot = "5")]
		public int NGOGMOHXYFA(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8638920", Offset = "0x8636F20", VA = "0x188638920", Slot = "6")]
		public bool BTXJOGDTJCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x863A420", Offset = "0x8638A20", VA = "0x18863A420", Slot = "7")]
		public bool SZVNWSPOISA(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x863A670", Offset = "0x8638C70", VA = "0x18863A670", Slot = "8")]
		public void VBRYLLLXHKJ(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8639060", Offset = "0x8637660", VA = "0x188639060", Slot = "9")]
		public bool IBCHBFWTLWR(KMNYUBYLMOF a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x863A140", Offset = "0x8638740", VA = "0x18863A140", Slot = "10")]
		public bool QAZCLSSAJGK(KMNYUBYLMOF a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x863A850", Offset = "0x8638E50", VA = "0x18863A850", Slot = "11")]
		public bool ZKCDHRVYNWP(KMNYUBYLMOF a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8639F60", Offset = "0x8638560", VA = "0x188639F60", Slot = "12")]
		public void OXVSJNFCYUH(KMNYUBYLMOF a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8638DD0", Offset = "0x86373D0", VA = "0x188638DD0", Slot = "13")]
		public void FOIACVACMDO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8638810", Offset = "0x8636E10", VA = "0x188638810", Slot = "14")]
		public void BEGCHBZWZYO(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8639EB0", Offset = "0x86384B0", VA = "0x188639EB0", Slot = "15")]
		public void OOMYDZXLHIW(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x863A5A0", Offset = "0x8638BA0", VA = "0x18863A5A0", Slot = "16")]
		public void UQBQUEVSFZD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8639D50", Offset = "0x8638350", VA = "0x188639D50", Slot = "17")]
		public void NKPPPPFFQKV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x86389B0", Offset = "0x8636FB0", VA = "0x1886389B0")]
		private static void DBZDWSQZSDG(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86391D0", Offset = "0x86377D0", VA = "0x1886391D0")]
		private static bool IBCHBFWTLWR(Hashtable a, LRIABUPBGVB b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86398C0", Offset = "0x8637EC0", VA = "0x1886398C0")]
		private static int KIJVSDZFVMW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8639820", Offset = "0x8637E20", VA = "0x188639820", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8639780", Offset = "0x8637D80", VA = "0x188639780", Slot = "19")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public QBQSIYAWUCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(NNGRJYQBKAS), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class NNGRJYQBKAS : KCEPQMCUHSR, UUPKZPXZDMZ, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static Hashtable ZUSCUDDHVAN;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Hashtable GUNMNFTUNVS;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static KAUBEGREKJA IBRGWQUQOAJ;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly KAUBEGREKJA ETYLSZHZOUE;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x862DCC0", Offset = "0x862C2C0", VA = "0x18862DCC0", Slot = "4")]
		public void BESVZIHDHDL(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x862E550", Offset = "0x862CB50", VA = "0x18862E550", Slot = "5")]
		public bool YETUYCMCZAF(KMNYUBYLMOF a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x862DEE0", Offset = "0x862C4E0", VA = "0x18862DEE0", Slot = "6")]
		public void SKXVZATUAVN(ViewId a, string b, RpcTarget c, LRIABUPBGVB d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x862DDA0", Offset = "0x862C3A0", VA = "0x18862DDA0", Slot = "8")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x862DE40", Offset = "0x862C440", VA = "0x18862DE40", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public NNGRJYQBKAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class TOYEROQBZPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8643F60", Offset = "0x8642560", VA = "0x188643F60")]
		public static LRIABUPBGVB LLAIBEYZZTT(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8643FF0", Offset = "0x86425F0", VA = "0x188643FF0")]
		public static PlayerId ToPlayerId(this LRIABUPBGVB player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, YJHBJOYDIOX, UXWMPOTYTVA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool OPEONUHFNJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView BGZTCKFIQRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<XACNGKUEJNS> LENDTPNHZXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool RDVACNNVLPM;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId FNLTWIMDPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x863BB70", Offset = "0x863A170", VA = "0x18863BB70")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId NCFUGXARWYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x863BB70", Offset = "0x863A170", VA = "0x18863BB70", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView UBOIQWABRMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x863BBF0", Offset = "0x863A1F0", VA = "0x18863BBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView UTKAVBFHTRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x863BBF0", Offset = "0x863A1F0", VA = "0x18863BBF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LRIABUPBGVB HAFJUQTXDUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x863BCF0", Offset = "0x863A2F0", VA = "0x18863BCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LRIABUPBGVB ZLCVZYTXLXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x863C050", Offset = "0x863A650", VA = "0x18863C050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool XTOREDDLSRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x863BE50", Offset = "0x863A450", VA = "0x18863BE50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool JXHIMMLBZCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x863BFC0", Offset = "0x863A5C0", VA = "0x18863BFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JWHGKSDZUOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x863BAA0", Offset = "0x863A0A0", VA = "0x18863BAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JJVWNUKVITX
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x863BD80", Offset = "0x863A380", VA = "0x18863BD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TLRCQRCHQIN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x863BAA0", Offset = "0x863A0A0", VA = "0x18863BAA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool QHXYVHQMKTV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x863BB20", Offset = "0x863A120", VA = "0x18863BB20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string ITNDOYAGFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x863BC60", Offset = "0x863A260", VA = "0x18863BC60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DQHFTMJOHVU
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x863BA20", Offset = "0x863A020", VA = "0x18863BA20", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<LRIABUPBGVB> LOMIPICCHZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x863B8F0", Offset = "0x8639EF0", VA = "0x18863B8F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x863C0E0", Offset = "0x863A6E0", VA = "0x18863C0E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x863B850", Offset = "0x8639E50", VA = "0x18863B850")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7962210", Offset = "0x7960810", VA = "0x187962210")]
		private void MDTVXSTGPIH(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x863B450", Offset = "0x8639A50", VA = "0x18863B450", Slot = "9")]
		public void RegisterDestroyHandler(XACNGKUEJNS handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x863B690", Offset = "0x8639C90", VA = "0x18863B690", Slot = "10")]
		public void UnregisterDestroyHandler(XACNGKUEJNS handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x863B430", Offset = "0x8639A30", VA = "0x18863B430", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class OWBYEQNSMRT
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, LRIABUPBGVB targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, LRIABUPBGVB targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, LRIABUPBGVB newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CompilerGenerated]
		private static InstantiateCallback KRQPTWMORDR;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback LZMIAVYOFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8637A40", Offset = "0x8636040", VA = "0x188637A40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8637400", Offset = "0x8635A00", VA = "0x188637400")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback REQTFHDNKTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8638690", Offset = "0x8636C90", VA = "0x188638690")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8637E20", Offset = "0x8636420", VA = "0x188637E20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback PMGDILXGVFM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x86378C0", Offset = "0x8635EC0", VA = "0x1886378C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8638480", Offset = "0x8636A80", VA = "0x188638480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback NDYAAFLMGVP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8637800", Offset = "0x8635E00", VA = "0x188637800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8637FA0", Offset = "0x86365A0", VA = "0x188637FA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback FPNUIVFNGMV
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x8637EE0", Offset = "0x86364E0", VA = "0x188637EE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x8638300", Offset = "0x8636900", VA = "0x188638300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback QMAYUUINOTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8637980", Offset = "0x8635F80", VA = "0x188637980")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x8638750", Offset = "0x8636D50", VA = "0x188638750")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback TCLJJEPTXUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x86383C0", Offset = "0x86369C0", VA = "0x1886383C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8637680", Offset = "0x8635C80", VA = "0x188637680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler KZYANPVHSCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x86375C0", Offset = "0x8635BC0", VA = "0x1886375C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x8638120", Offset = "0x8636720", VA = "0x188638120")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler JFBGPXAKOBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x8638060", Offset = "0x8636660", VA = "0x188638060")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8637CD0", Offset = "0x86362D0", VA = "0x188637CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8637740", Offset = "0x8635D40", VA = "0x188637740")]
		public static void DUBXIEXTRND([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8637C40", Offset = "0x8636240", VA = "0x188637C40")]
		public static void IKQZXMNMQGV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8637D90", Offset = "0x8636390", VA = "0x188637D90")]
		public static void KFWSDCCXYYY(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86381E0", Offset = "0x86367E0", VA = "0x1886381E0")]
		public static void OHTOLPVBFWH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8638270", Offset = "0x8636870", VA = "0x188638270")]
		public static void PWRRPCZORWO(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8638540", Offset = "0x8636B40", VA = "0x188638540")]
		public static void VQSNOWUXBII(RRNetworkView a, string b, LRIABUPBGVB c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8637B00", Offset = "0x8636100", VA = "0x188637B00")]
		public static void IJPEKJDFPAP(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86374C0", Offset = "0x8635AC0", VA = "0x1886374C0")]
		public static void CTYKNQEMVSD(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TJANTLKBDIU
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8643E40", Offset = "0x8642440", VA = "0x188643E40")]
		[CanBeNull]
		private static bool WXWIEREPJKW(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8643D60", Offset = "0x8642360", VA = "0x188643D60")]
		[CanBeNull]
		public static Component QCIFZCSDDPM(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D5ECB0", Offset = "0x3D5D2B0", VA = "0x183D5ECB0")]
		[CanBeNull]
		public static a QCIFZCSDDPM<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EC40", Offset = "0x3D5D240", VA = "0x183D5EC40")]
		[CanBeNull]
		public static b DWHKPORZYKK<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D5EDD0", Offset = "0x3D5D3D0", VA = "0x183D5EDD0")]
		public static bool UBTYWKHEEXD<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8643EF0", Offset = "0x86424F0", VA = "0x188643EF0")]
		[CanBeNull]
		public static RRNetworkView YBNXZTYFLTN(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler ADQBSUIXDPJ;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler ZQTZABWNUIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x863C210", Offset = "0x863A810", VA = "0x18863C210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x863C3C0", Offset = "0x863A9C0", VA = "0x18863C3C0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x863C380", Offset = "0x863A980", VA = "0x18863C380")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RegisterService(typeof(OIGDHDPQBLA), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class OIGDHDPQBLA : XFWBBFNUYHH, UUPKZPXZDMZ, SPJAMBOPKUB, ZGVBPXQWGAT, GYBGJZXFTPV, GIIGMTDPOEP, SWFXCOYYPIH
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class DGWFRGWFTEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int IWXKGJPORRW;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DGWFRGWFTEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x86260B0", Offset = "0x86246B0", VA = "0x1886260B0")]
			internal object GMJDBOAQSPD((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static Log RYUWLSGTSUJ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static Log YLCVXJYZJQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[DependsOn]
		private HLFEETEILQC VSQCZFDDOPR;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Dictionary<int, HashSet<int>> FCZJSFKXLKN;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<int, int> WIOPDFEWQVY;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<(GameObject GameObject, int ParentCount)> BYTFMADRHQF;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<GameObject> GSXMZZTAIVU;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static List<int> VIHDHUGYLCC;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly List<RRNetworkView> PLXCXETQIMQ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly KAUBEGREKJA RISRPVCKRHY;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly KAUBEGREKJA QYXBLRCGSWD;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8631CC0", Offset = "0x86302C0", VA = "0x188631CC0", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x86317C0", Offset = "0x862FDC0", VA = "0x1886317C0", Slot = "9")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8631B00", Offset = "0x8630100", VA = "0x188631B00", Slot = "10")]
		public void InitExternal(XRIYJCZWKCD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8634CF0", Offset = "0x86332F0", VA = "0x188634CF0", Slot = "11")]
		public void QHKPZYISJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8630E30", Offset = "0x862F430", VA = "0x188630E30")]
		private void HDVAEMANQIT(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x862F770", Offset = "0x862DD70", VA = "0x18862F770")]
		private void BYBSQFWINSM(LULDBTLWMMU a, LULDBTLWMMU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8634FB0", Offset = "0x86335B0", VA = "0x188634FB0")]
		public GameObject RBGBFVANQMI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8632CF0", Offset = "0x86312F0", VA = "0x188632CF0")]
		public GameObject NMIKNQWZPBE(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8636000", Offset = "0x8634600", VA = "0x188636000")]
		public GameObject VEYWMXSFKJZ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8631500", Offset = "0x862FB00", VA = "0x188631500")]
		public GameObject HTKZTHKLRNP(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8635180", Offset = "0x8633780", VA = "0x188635180", Slot = "6")]
		public void RBILCSNAOSN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x86321B0", Offset = "0x86307B0", VA = "0x1886321B0")]
		public void JUVZSQEWEQQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8636980", Offset = "0x8634F80", VA = "0x188636980", Slot = "7")]
		public void ZMPEKYQCMOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x86325E0", Offset = "0x8630BE0", VA = "0x1886325E0", Slot = "4")]
		public GameObject[] KUKZNVASMGJ(IList<OSIQXZBIXOM> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x862FA50", Offset = "0x862E050", VA = "0x18862FA50", Slot = "5")]
		public void CSYKHTXGHJO(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8636840", Offset = "0x8634E40", VA = "0x188636840")]
		public void XBXHFXFIYOI(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8630F50", Offset = "0x862F550", VA = "0x188630F50")]
		private void HRVRANTSQAL(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8632000", Offset = "0x8630600", VA = "0x188632000")]
		private void JLBUSLSNGKJ(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8635DA0", Offset = "0x86343A0", VA = "0x188635DA0")]
		private void VASGRMRIGRR(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8633F00", Offset = "0x8632500", VA = "0x188633F00")]
		private void OWVXBCEJLMJ(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8634910", Offset = "0x8632F10", VA = "0x188634910")]
		private void QCFZBFUHJHH(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x862F860", Offset = "0x862DE60", VA = "0x18862F860")]
		private void CKRNIOAAEIH(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8630780", Offset = "0x862ED80", VA = "0x188630780")]
		private void ETPDAUSJKMJ(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x86315D0", Offset = "0x862FBD0", VA = "0x1886315D0")]
		private GameObject HXSVFMLNOYY(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8636990", Offset = "0x8634F90", VA = "0x188636990")]
		private GameObject ZVHPKUPTOTY(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8630600", Offset = "0x862EC00", VA = "0x188630600")]
		private static GameObject EGCGJLGYSDA(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8632220", Offset = "0x8630820", VA = "0x188632220")]
		private static GameObject KBPVKJWYFYH(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x862EBD0", Offset = "0x862D1D0", VA = "0x18862EBD0")]
		private static void AUVEKURLEPI(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x862FDF0", Offset = "0x862E3F0", VA = "0x18862FDF0")]
		private GameObject[] DJOBOIPGBJT(IList<OSIQXZBIXOM> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8631240", Offset = "0x862F840", VA = "0x188631240")]
		private GameObject[] HSCYDFPYEKD(InstantiateParameters[] a, int b, LRIABUPBGVB c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x86328F0", Offset = "0x8630EF0", VA = "0x1886328F0")]
		private GameObject KVCSVYEPZQV([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x79459D0", Offset = "0x7943FD0", VA = "0x1879459D0")]
		private static bool POQSTOILNLU(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8635190", Offset = "0x8633790", VA = "0x188635190")]
		private void SWRESOVMHYY(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8633020", Offset = "0x8631620", VA = "0x188633020")]
		private void OKAVRNTKSWW(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8634530", Offset = "0x8632B30", VA = "0x188634530")]
		private static void PYOUJQCAMIX(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8632430", Offset = "0x8630A30", VA = "0x188632430")]
		private void KNGVIHHWNSR(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8631530", Offset = "0x862FB30", VA = "0x188631530")]
		private static int HXRVZASEEUX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8636280", Offset = "0x8634880", VA = "0x188636280")]
		private void VZNUWPKYZQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x86362E0", Offset = "0x86348E0", VA = "0x1886362E0")]
		private void WOGJOJWTQFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8636920", Offset = "0x8634F20", VA = "0x188636920")]
		private static int XKTLXSODHVR(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8630D50", Offset = "0x862F350", VA = "0x188630D50")]
		private static int[] GWOSGCSIFSC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8634EB0", Offset = "0x86334B0", VA = "0x188634EB0")]
		private static int[] QHOBYINXHUQ(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8634450", Offset = "0x8632A50", VA = "0x188634450")]
		private void OnMasterClientSwitched(LRIABUPBGVB newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x862ECE0", Offset = "0x862D2E0", VA = "0x18862ECE0")]
		private void BROIYLBNFAG(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8634180", Offset = "0x8632780", VA = "0x188634180")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8632DE0", Offset = "0x86313E0", VA = "0x188632DE0")]
		private void NRWQBZKVEUS(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8634490", Offset = "0x8632A90", VA = "0x188634490")]
		private static void PSEURMDNOAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8630680", Offset = "0x862EC80", VA = "0x188630680")]
		private void EGPLSLTXTSK(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8632590", Offset = "0x8630B90", VA = "0x188632590", Slot = "12")]
		private void KPEUJIHXKXR(XRIYJCZWKCD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xFCB320", Offset = "0xFC9920", VA = "0x180FCB320", Slot = "13")]
		private void WCDWJAGTXKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public OIGDHDPQBLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(ISLDQZCPRDW), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class ISLDQZCPRDW : UUPKZPXZDMZ, SPJAMBOPKUB, GSJHGGBTZJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x794FE80", Offset = "0x794E480", VA = "0x18794FE80")]
			public object LCTCAYLNJIO(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class GLDZIWPLILI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public FieldInfo EQOKVTETSGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Func<MonoBehaviour, object> LGGVGPLTSFW;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GLDZIWPLILI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8626EC0", Offset = "0x86254C0", VA = "0x188626EC0")]
			internal RpcMethodInfo VBTOSRTQWXK(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x533C670", Offset = "0x533AC70", VA = "0x18533C670")]
			internal object VBYVPYNOGIT(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class GLJGGDJIRWR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Func<MonoBehaviour, object> QVNHTDFDXNR;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public GLJGGDJIRWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x794D7E0", Offset = "0x794BDE0", VA = "0x18794D7E0")]
			internal RpcMethodInfo VDEKZNCYKYV(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class QEFUBVWJVIW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Type RDZNXILWHVC;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public QEFUBVWJVIW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x863AC10", Offset = "0x8639210", VA = "0x18863AC10")]
			internal bool PZIFBOMOUJS(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, int> YHQDJMCVCTQ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static List<string> HGENYQLXGCL;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int FSJMUZHNFFO;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Stopwatch IQMYVRDXVAS;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static Dictionary<MethodInfo, ParameterInfo[]> TUWGHDCNRJL;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> ZGZOBXGCNKW;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x862AAA0", Offset = "0x86290A0", VA = "0x18862AAA0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x862A950", Offset = "0x8628F50", VA = "0x18862A950", Slot = "5")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x862D580", Offset = "0x862BB80", VA = "0x18862D580")]
		public static bool XKZMMRKYZUG(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x862B100", Offset = "0x8629700", VA = "0x18862B100")]
		public static bool OHAOSTYYNYG(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x862A6A0", Offset = "0x8628CA0", VA = "0x18862A6A0")]
		private void HRVRANTSQAL(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x862D550", Offset = "0x862BB50", VA = "0x18862D550", Slot = "9")]
		public string UQDEJWFDIJA(KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8629EE0", Offset = "0x86284E0", VA = "0x188629EE0", Slot = "8")]
		public void BESVZIHDHDL(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8629FC0", Offset = "0x86285C0", VA = "0x188629FC0", Slot = "6")]
		public void BYWISIGZRAP(ViewId a, string b, LRIABUPBGVB c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x862A090", Offset = "0x8628690", VA = "0x18862A090", Slot = "7")]
		public void BYWISIGZRAP(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x862A0C0", Offset = "0x86286C0", VA = "0x18862A0C0")]
		private void BYWISIGZRAP(ViewId a, string b, RpcTarget c, LRIABUPBGVB d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x862B1E0", Offset = "0x86297E0", VA = "0x18862B1E0")]
		private void RPAGBOQHGHU(ViewId a, string b, LRIABUPBGVB c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x862C840", Offset = "0x862AE40", VA = "0x18862C840")]
		private static void SYHDJIXCTRU(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x862D610", Offset = "0x862BC10", VA = "0x18862D610")]
		private static bool YQBPGBOYWZH(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x862CCD0", Offset = "0x862B2D0", VA = "0x18862CCD0")]
		private List<RpcMethodInfo> UPDALJGDDSY(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x862B000", Offset = "0x8629600", VA = "0x18862B000")]
		private static IEnumerable<MethodInfo> NUUDSRQFJNE(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x862A590", Offset = "0x8628B90", VA = "0x18862A590")]
		public static ParameterInfo[] GKQOBZJFTPA(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ISLDQZCPRDW()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x863C480", Offset = "0x863AA80", VA = "0x18863C480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x863C400", Offset = "0x863AA00", VA = "0x18863C400")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, KXZTLOMYDMK, LVHGPWRFDXR, JPMUZHOIAII, WCDUUKVIGQY, KLYGLTRGWBR
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(HLFEETEILQC), new string[] { })]
		internal class HCPJQLSAWPZ : UUPKZPXZDMZ, SPJAMBOPKUB, HLFEETEILQC
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Dictionary<int, RRNetworkView> ZEWNAWLKKJC;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x8626F80", Offset = "0x8625580", VA = "0x188626F80", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8626F80", Offset = "0x8625580", VA = "0x188626F80", Slot = "5")]
			public void IPUBHZMPJRZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8626F90", Offset = "0x8625590", VA = "0x188626F90", Slot = "6")]
			public void YPSCAHTUQQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HCPJQLSAWPZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			False,
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class SSSKYROOASY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int FDUEUZQWTNW;

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SSSKYROOASY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x8643D00", Offset = "0x8642300", VA = "0x188643D00")]
			internal bool ETKYRCQJAFK(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static KAUBEGREKJA YZZSNZGOUYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool DNSFDMOBLEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool OFFLXBZBOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool LDUHEEXJPQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int EBYOJFCDRZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool UBCZJIVBHGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int APDITPCQDUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private LRIABUPBGVB ZLCVZYTXLXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private LRIABUPBGVB PZUADIJXRCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool? WAPPIMIDKXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool FTDWDATLTZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal bool LVIWFMHVGVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal MonoBehaviour[] LSCTDNCTIEU;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly Log KLNBLBVXWOV;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> ZEWNAWLKKJC
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x863DEF0", Offset = "0x863C4F0", VA = "0x18863DEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId NCFUGXARWYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8640A90", Offset = "0x863F090", VA = "0x188640A90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId GUEEODABUVS
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8640A90", Offset = "0x863F090", VA = "0x188640A90", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId FNLTWIMDPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8640A90", Offset = "0x863F090", VA = "0x188640A90")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int HAQRELMVKUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAFA730", Offset = "0xAF8D30", VA = "0x180AFA730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int VUHTNYJDPOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xACE970", Offset = "0xACCF70", VA = "0x180ACE970")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xF68720", Offset = "0xF66D20", VA = "0x180F68720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId WGHPARVHFIU
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8640900", Offset = "0x863EF00", VA = "0x188640900")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JEYNCPCPZPG
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xCB5800", Offset = "0xCB3E00", VA = "0x180CB5800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xCB5810", Offset = "0xCB3E10", VA = "0x180CB5810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool ZCBBZZGPYQD
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8640910", Offset = "0x863EF10", VA = "0x188640910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool YBXHWCZUDTK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAFD1B0", Offset = "0xAFB7B0", VA = "0x180AFD1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int KJFLMETBDXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAF4D30", Offset = "0xAF3330", VA = "0x180AF4D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int MYQWPLGDRPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x86408A0", Offset = "0x863EEA0", VA = "0x1886408A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public LRIABUPBGVB WIDAAGVUMWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8640AA0", Offset = "0x863F0A0", VA = "0x188640AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public LRIABUPBGVB YZXEMOVHUBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8640870", Offset = "0x863EE70", VA = "0x188640870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public LRIABUPBGVB HAFJUQTXDUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8640870", Offset = "0x863EE70", VA = "0x188640870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public LRIABUPBGVB GITKTHCBKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8640870", Offset = "0x863EE70", VA = "0x188640870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ZFIGCFLMFGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x86409E0", Offset = "0x863EFE0", VA = "0x1886409E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int EHVQVNISTMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x86408D0", Offset = "0x863EED0", VA = "0x1886408D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] ZBZHYDEOYOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool XTOREDDLSRR
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8640AD0", Offset = "0x863F0D0", VA = "0x188640AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool KWMKLHBGTYN
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8640A60", Offset = "0x863F060", VA = "0x188640A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool RYZUWNDXRMY
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1014B40", Offset = "0x1013140", VA = "0x181014B40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x1014EC0", Offset = "0x10134C0", VA = "0x181014EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool TSBYLEBGUPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB8E3C0", Offset = "0xB8C9C0", VA = "0x180B8E3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> KYTOTNDHBVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8640700", Offset = "0x863ED00", VA = "0x188640700")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8640C90", Offset = "0x863F290", VA = "0x188640C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<LRIABUPBGVB> YMUKTXNMQBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x863DBE0", Offset = "0x863C1E0", VA = "0x18863DBE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x863CD10", Offset = "0x863B310", VA = "0x18863CD10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<LRIABUPBGVB> FACBTJZONNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x863DBE0", Offset = "0x863C1E0", VA = "0x18863DBE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x863CD10", Offset = "0x863B310", VA = "0x18863CD10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> EGRVOKEMQYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x863FE00", Offset = "0x863E400", VA = "0x18863FE00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x863C770", Offset = "0x863AD70", VA = "0x18863C770")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> UYEYVMCYSGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x863FE00", Offset = "0x863E400", VA = "0x18863FE00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x863C770", Offset = "0x863AD70", VA = "0x18863C770")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> AOBVGJPFUZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x86407B0", Offset = "0x863EDB0", VA = "0x1886407B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8640D40", Offset = "0x863F340", VA = "0x188640D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action WTSGEKCYCPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8640650", Offset = "0x863EC50", VA = "0x188640650")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8640BE0", Offset = "0x863F1E0", VA = "0x188640BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x86400F0", Offset = "0x863E6F0", VA = "0x1886400F0")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x863CDC0", Offset = "0x863B3C0", VA = "0x18863CDC0")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x863CFE0", Offset = "0x863B5E0", VA = "0x18863CFE0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x863CF40", Offset = "0x863B540", VA = "0x18863CF40")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x863E490", Offset = "0x863CA90", VA = "0x18863E490")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x863E230", Offset = "0x863C830", VA = "0x18863E230")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x863D870", Offset = "0x863BE70", VA = "0x18863D870")]
		public static void OnPlayerJoinedRoom(LRIABUPBGVB newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x863D140", Offset = "0x863B740", VA = "0x18863D140")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x863D1A0", Offset = "0x863B7A0", VA = "0x18863D1A0")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x863C5E0", Offset = "0x863ABE0", VA = "0x18863C5E0")]
		private void AERLYLQOGUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x863CAF0", Offset = "0x863B0F0", VA = "0x18863CAF0")]
		public bool CreatedBy(LRIABUPBGVB player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x863FEB0", Offset = "0x863E4B0", VA = "0x18863FEB0")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8640090", Offset = "0x863E690", VA = "0x188640090")]
		public void TransferOwnership(LRIABUPBGVB newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x863D4C0", Offset = "0x863BAC0", VA = "0x18863D4C0", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x863D460", Offset = "0x863BA60", VA = "0x18863D460")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x863C720", Offset = "0x863AD20", VA = "0x18863C720")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x863D200", Offset = "0x863B800", VA = "0x18863D200")]
		private void ILHETFNSMOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x211FA50", Offset = "0x211E050", VA = "0x18211FA50")]
		internal void QIWIISMOYAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x863C6C0", Offset = "0x863ACC0", VA = "0x18863C6C0", Slot = "6")]
		private void AZJJPFSZAXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8640520", Offset = "0x863EB20", VA = "0x188640520")]
		internal bool WRABSFWXALC(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x863D730", Offset = "0x863BD30", VA = "0x18863D730")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x863CB70", Offset = "0x863B170", VA = "0x18863CB70")]
		internal void DYSPSJHOYYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x863D720", Offset = "0x863BD20", VA = "0x18863D720")]
		private void KPMMRVFGFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x863CE80", Offset = "0x863B480", VA = "0x18863CE80")]
		internal void GKJFGSKSWBU(LRIABUPBGVB a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x863E3F0", Offset = "0x863C9F0", VA = "0x18863E3F0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x863E540", Offset = "0x863CB40", VA = "0x18863E540")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x863CBD0", Offset = "0x863B1D0", VA = "0x18863CBD0")]
		private void FGBSSXPLMYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x863D630", Offset = "0x863BC30", VA = "0x18863D630")]
		private void KBONFSFWQJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x863DDD0", Offset = "0x863C3D0", VA = "0x18863DDD0")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x863DE60", Offset = "0x863C460", VA = "0x18863DE60")]
		public void RPC(string methodName, LRIABUPBGVB targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x863E440", Offset = "0x863CA40", VA = "0x18863E440")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x863C820", Offset = "0x863AE20", VA = "0x18863C820", Slot = "8")]
		public void Bake(RODATQHQXLX context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x863DC90", Offset = "0x863C290", VA = "0x18863DC90")]
		private static void PJJEOVDBGEP(LRIABUPBGVB a, [Out] LRIABUPBGVB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x863DF40", Offset = "0x863C540", VA = "0x18863DF40")]
		private static void RZOYQBYSDCO(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x863CC70", Offset = "0x863B270", VA = "0x18863CC70")]
		private static RPCInfo FKBVSQOLHHZ(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8640440", Offset = "0x863EA40", VA = "0x188640440")]
		private static void VSMMPIREGKZ(RRNetworkView a, Delegate b, LRIABUPBGVB c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8640360", Offset = "0x863E960", VA = "0x188640360")]
		private static void VSMMPIREGKZ(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86401B0", Offset = "0x863E7B0", VA = "0x1886401B0")]
		private static void UVDZHXOHNTA(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x863DD00", Offset = "0x863C300", VA = "0x18863DD00")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x86402C0", Offset = "0x863E8C0", VA = "0x1886402C0")]
		private static bool VKHDZZSCDHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x863EC20", Offset = "0x863D220", VA = "0x18863EC20", Slot = "26")]
		public void RpcAll(LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C64730", Offset = "0x3C62D30", VA = "0x183C64730", Slot = "9")]
		public void RpcAll<T1>(LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3C64010", Offset = "0x3C62610", VA = "0x183C64010", Slot = "10")]
		public void RpcAll<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3C66020", Offset = "0x3C64620", VA = "0x183C66020", Slot = "27")]
		public void RpcAll<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3C64200", Offset = "0x3C62800", VA = "0x183C64200", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3C64D60", Offset = "0x3C63360", VA = "0x183C64D60", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C664D0", Offset = "0x3C64AD0", VA = "0x183C664D0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C648A0", Offset = "0x3C62EA0", VA = "0x183C648A0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C739A0", Offset = "0x3C71FA0", VA = "0x183C739A0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3C66900", Offset = "0x3C64F00", VA = "0x183C66900", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C65160", Offset = "0x3C63760", VA = "0x183C65160", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3C784A0", Offset = "0x3C76AA0", VA = "0x183C784A0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E1C0", Offset = "0x3C8C7C0", VA = "0x183C8E1C0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3C8C3D0", Offset = "0x3C8A9D0", VA = "0x183C8C3D0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C88AB0", Offset = "0x3C870B0", VA = "0x183C88AB0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x863E9F0", Offset = "0x863CFF0", VA = "0x18863E9F0", Slot = "36")]
		public void RpcAll(LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C71E50", Offset = "0x3C70450", VA = "0x183C71E50", Slot = "37")]
		public void RpcAll<T1>(LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C71800", Offset = "0x3C6FE00", VA = "0x183C71800", Slot = "38")]
		public void RpcAll<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C65980", Offset = "0x3C63F80", VA = "0x183C65980", Slot = "39")]
		public void RpcAll<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C6ECD0", Offset = "0x3C6D2D0", VA = "0x183C6ECD0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E0B0", Offset = "0x3C6C6B0", VA = "0x183C6E0B0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C6CAD0", Offset = "0x3C6B0D0", VA = "0x183C6CAD0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C6B920", Offset = "0x3C69F20", VA = "0x183C6B920", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AF00", Offset = "0x3C69500", VA = "0x183C6AF00", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3C69A10", Offset = "0x3C68010", VA = "0x183C69A10", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3C676E0", Offset = "0x3C65CE0", VA = "0x183C676E0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C8EFF0", Offset = "0x3C8D5F0", VA = "0x183C8EFF0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D330", Offset = "0x3C8B930", VA = "0x183C8D330", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3C8B410", Offset = "0x3C89A10", VA = "0x183C8B410", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C89290", Offset = "0x3C87890", VA = "0x183C89290", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x863E8C0", Offset = "0x863CEC0", VA = "0x18863E8C0", Slot = "51")]
		public void RpcAllViaServer(LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C885E0", Offset = "0x3C86BE0", VA = "0x183C885E0", Slot = "52")]
		public void RpcAllViaServer<T1>(LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C88770", Offset = "0x3C86D70", VA = "0x183C88770", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C88070", Offset = "0x3C86670", VA = "0x183C88070", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C87C80", Offset = "0x3C86280", VA = "0x183C87C80", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C877D0", Offset = "0x3C85DD0", VA = "0x183C877D0", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C87260", Offset = "0x3C85860", VA = "0x183C87260", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C86C30", Offset = "0x3C85230", VA = "0x183C86C30", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C86530", Offset = "0x3C84B30", VA = "0x183C86530", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C85D70", Offset = "0x3C84370", VA = "0x183C85D70", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C854F0", Offset = "0x3C83AF0", VA = "0x183C854F0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C84BB0", Offset = "0x3C831B0", VA = "0x183C84BB0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3C841A0", Offset = "0x3C827A0", VA = "0x183C841A0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C836C0", Offset = "0x3C81CC0", VA = "0x183C836C0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C82B10", Offset = "0x3C81110", VA = "0x183C82B10", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x863E790", Offset = "0x863CD90", VA = "0x18863E790", Slot = "65")]
		public void RpcAllViaServer(LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C885E0", Offset = "0x3C86BE0", VA = "0x183C885E0", Slot = "66")]
		public void RpcAllViaServer<T1>(LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C88390", Offset = "0x3C86990", VA = "0x183C88390", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C88070", Offset = "0x3C86670", VA = "0x183C88070", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C87C80", Offset = "0x3C86280", VA = "0x183C87C80", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C877D0", Offset = "0x3C85DD0", VA = "0x183C877D0", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C87260", Offset = "0x3C85860", VA = "0x183C87260", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C86C30", Offset = "0x3C85230", VA = "0x183C86C30", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C86530", Offset = "0x3C84B30", VA = "0x183C86530", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C85D70", Offset = "0x3C84370", VA = "0x183C85D70", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C854F0", Offset = "0x3C83AF0", VA = "0x183C854F0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C84BB0", Offset = "0x3C831B0", VA = "0x183C84BB0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C841A0", Offset = "0x3C827A0", VA = "0x183C841A0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C836C0", Offset = "0x3C81CC0", VA = "0x183C836C0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C82B10", Offset = "0x3C81110", VA = "0x183C82B10", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x863F800", Offset = "0x863DE00", VA = "0x18863F800", Slot = "80")]
		public void RpcOthers(LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0E70", Offset = "0x3CBF470", VA = "0x183CC0E70", Slot = "15")]
		public void RpcOthers<T1>(LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7580", Offset = "0x3CC5B80", VA = "0x183CC7580", Slot = "81")]
		public void RpcOthers<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0C20", Offset = "0x3CBF220", VA = "0x183CC0C20", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9EA0", Offset = "0x3CC84A0", VA = "0x183CC9EA0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5E00", Offset = "0x3CC4400", VA = "0x183CC5E00", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8100", Offset = "0x3CC6700", VA = "0x183CC8100", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5200", Offset = "0x3CC3800", VA = "0x183CC5200", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8D70", Offset = "0x3CC7370", VA = "0x183CC8D70", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CC42F0", Offset = "0x3CC28F0", VA = "0x183CC42F0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8870", Offset = "0x3CC6E70", VA = "0x183CC8870", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC30D0", Offset = "0x3CC16D0", VA = "0x183CC30D0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC26A0", Offset = "0x3CC0CA0", VA = "0x183CC26A0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1BA0", Offset = "0x3CC01A0", VA = "0x183CC1BA0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0FC0", Offset = "0x3CBF5C0", VA = "0x183CC0FC0", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x863F6B0", Offset = "0x863DCB0", VA = "0x18863F6B0", Slot = "93")]
		public void RpcOthers(LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC72E0", Offset = "0x3CC58E0", VA = "0x183CC72E0", Slot = "94")]
		public void RpcOthers<T1>(LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7120", Offset = "0x3CC5720", VA = "0x183CC7120", Slot = "95")]
		public void RpcOthers<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CC66E0", Offset = "0x3CC4CE0", VA = "0x183CC66E0", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CC6E70", Offset = "0x3CC5470", VA = "0x183CC6E70", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7A90", Offset = "0x3CC6090", VA = "0x183CC7A90", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CC7DA0", Offset = "0x3CC63A0", VA = "0x183CC7DA0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5200", Offset = "0x3CC3800", VA = "0x183CC5200", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3CC4AE0", Offset = "0x3CC30E0", VA = "0x183CC4AE0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3CC42F0", Offset = "0x3CC28F0", VA = "0x183CC42F0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3CC3A40", Offset = "0x3CC2040", VA = "0x183CC3A40", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3CC30D0", Offset = "0x3CC16D0", VA = "0x183CC30D0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3CC26A0", Offset = "0x3CC0CA0", VA = "0x183CC26A0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1BA0", Offset = "0x3CC01A0", VA = "0x183CC1BA0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0FC0", Offset = "0x3CBF5C0", VA = "0x183CC0FC0", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x863F1A0", Offset = "0x863D7A0", VA = "0x18863F1A0", Slot = "108")]
		public void RpcMaster(LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3CA74A0", Offset = "0x3CA5AA0", VA = "0x183CA74A0", Slot = "109")]
		public void RpcMaster<T1>(LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7820", Offset = "0x3CA5E20", VA = "0x183CA7820", Slot = "17")]
		public void RpcMaster<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6C90", Offset = "0x3CA5290", VA = "0x183CA6C90", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6EF0", Offset = "0x3CA54F0", VA = "0x183CA6EF0", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CBB300", Offset = "0x3CB9900", VA = "0x183CBB300", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3CBD360", Offset = "0x3CBB960", VA = "0x183CBD360", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3570", Offset = "0x3CB1B70", VA = "0x183CB3570", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2170", Offset = "0x3CB0770", VA = "0x183CB2170", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3CB1690", Offset = "0x3CAFC90", VA = "0x183CB1690", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3CBAB40", Offset = "0x3CB9140", VA = "0x183CBAB40", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9B40", Offset = "0x3CB8140", VA = "0x183CB9B40", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3CAC9D0", Offset = "0x3CAAFD0", VA = "0x183CAC9D0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3CA9BE0", Offset = "0x3CA81E0", VA = "0x183CA9BE0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8B40", Offset = "0x3CA7140", VA = "0x183CA8B40", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x863F330", Offset = "0x863D930", VA = "0x18863F330", Slot = "122")]
		public void RpcMaster(LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7640", Offset = "0x3CA5C40", VA = "0x183CA7640", Slot = "123")]
		public void RpcMaster<T1>(LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8E40", Offset = "0x3CB7440", VA = "0x183CB8E40", Slot = "124")]
		public void RpcMaster<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3CB84A0", Offset = "0x3CB6AA0", VA = "0x183CB84A0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB69D0", Offset = "0x3CB4FD0", VA = "0x183CB69D0", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBBAD0", Offset = "0x3CBA0D0", VA = "0x183CBBAD0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4EF0", Offset = "0x3CB34F0", VA = "0x183CB4EF0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3E30", Offset = "0x3CB2430", VA = "0x183CB3E30", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2B40", Offset = "0x3CB1140", VA = "0x183CB2B40", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0B40", Offset = "0x3CAF140", VA = "0x183CB0B40", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFEE0", Offset = "0x3CAE4E0", VA = "0x183CAFEE0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3CAD820", Offset = "0x3CABE20", VA = "0x183CAD820", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3CABB20", Offset = "0x3CAA120", VA = "0x183CABB20", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3CAAB50", Offset = "0x3CA9150", VA = "0x183CAAB50", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7A40", Offset = "0x3CA6040", VA = "0x183CA7A40", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x863EFF0", Offset = "0x863D5F0", VA = "0x18863EFF0", Slot = "137")]
		public void RpcAuthority(LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C90E10", Offset = "0x3C8F410", VA = "0x183C90E10", Slot = "138")]
		public void RpcAuthority<T1>(LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3470", Offset = "0x3CA1A70", VA = "0x183CA3470", Slot = "139")]
		public void RpcAuthority<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3BE0", Offset = "0x3CA21E0", VA = "0x183CA3BE0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3170", Offset = "0x3CA1770", VA = "0x183CA3170", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C90A70", Offset = "0x3C8F070", VA = "0x183C90A70", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E000", Offset = "0x3C9C600", VA = "0x183C9E000", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C9CDC0", Offset = "0x3C9B3C0", VA = "0x183C9CDC0", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B960", Offset = "0x3C99F60", VA = "0x183C9B960", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A2C0", Offset = "0x3C988C0", VA = "0x183C9A2C0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C99680", Offset = "0x3C97C80", VA = "0x183C99680", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4A90", Offset = "0x3CA3090", VA = "0x183CA4A90", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3CA1EE0", Offset = "0x3CA04E0", VA = "0x183CA1EE0", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C941D0", Offset = "0x3C927D0", VA = "0x183C941D0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C90FC0", Offset = "0x3C8F5C0", VA = "0x183C90FC0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x863ED90", Offset = "0x863D390", VA = "0x18863ED90", Slot = "152")]
		public void RpcAuthority(LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3CA19D0", Offset = "0x3C9FFD0", VA = "0x183CA19D0", Slot = "153")]
		public void RpcAuthority<T1>(LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CA15F0", Offset = "0x3C9FBF0", VA = "0x183CA15F0", Slot = "154")]
		public void RpcAuthority<T1, T2>(LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0DB0", Offset = "0x3C9F3B0", VA = "0x183CA0DB0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FDA0", Offset = "0x3C9E3A0", VA = "0x183C9FDA0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F6A0", Offset = "0x3C9DCA0", VA = "0x183C9F6A0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E7D0", Offset = "0x3C9CDD0", VA = "0x183C9E7D0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C9D6C0", Offset = "0x3C9BCC0", VA = "0x183C9D6C0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C360", Offset = "0x3C9A960", VA = "0x183C9C360", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C9ADE0", Offset = "0x3C993E0", VA = "0x183C9ADE0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C989E0", Offset = "0x3C96FE0", VA = "0x183C989E0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C96ED0", Offset = "0x3C954D0", VA = "0x183C96ED0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C95170", Offset = "0x3C93770", VA = "0x183C95170", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C931C0", Offset = "0x3C917C0", VA = "0x183C931C0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C92090", Offset = "0x3C90690", VA = "0x183C92090", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x863F950", Offset = "0x863DF50", VA = "0x18863F950", Slot = "18")]
		public void RpcPlayer(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFD30", Offset = "0x3CCE330", VA = "0x183CCFD30", Slot = "19")]
		public void RpcPlayer<T1>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CD09D0", Offset = "0x3CCEFD0", VA = "0x183CD09D0", Slot = "20")]
		public void RpcPlayer<T1, T2>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0450", Offset = "0x3CCEA50", VA = "0x183CD0450", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFEF0", Offset = "0x3CCE4F0", VA = "0x183CCFEF0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4EE0", Offset = "0x3CE34E0", VA = "0x183CE4EE0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4AD0", Offset = "0x3CE30D0", VA = "0x183CE4AD0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5270", Offset = "0x3CE3870", VA = "0x183CE5270", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CE56E0", Offset = "0x3CE3CE0", VA = "0x183CE56E0", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3CDC340", Offset = "0x3CDA940", VA = "0x183CDC340", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CDB700", Offset = "0x3CD9D00", VA = "0x183CDB700", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1220", Offset = "0x3CCF820", VA = "0x183CD1220", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3CD80B0", Offset = "0x3CD66B0", VA = "0x183CD80B0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3CE9CE0", Offset = "0x3CE82E0", VA = "0x183CE9CE0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4110", Offset = "0x3CD2710", VA = "0x183CD4110", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x863FB40", Offset = "0x863E140", VA = "0x18863FB40", Slot = "176")]
		public void RpcPlayer(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0240", Offset = "0x3CCE840", VA = "0x183CD0240", Slot = "177")]
		public void RpcPlayer<T1>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0F60", Offset = "0x3CCF560", VA = "0x183CD0F60", Slot = "24")]
		public void RpcPlayer<T1, T2>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0C20", Offset = "0x3CCF220", VA = "0x183CD0C20", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2830", Offset = "0x3CD0E30", VA = "0x183CD2830", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3CE1730", Offset = "0x3CDFD30", VA = "0x183CE1730", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3CE0840", Offset = "0x3CDEE40", VA = "0x183CE0840", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF720", Offset = "0x3CDDD20", VA = "0x183CDF720", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE3E0", Offset = "0x3CDC9E0", VA = "0x183CDE3E0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCE60", Offset = "0x3CDB460", VA = "0x183CDCE60", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3CDAA60", Offset = "0x3CD9060", VA = "0x183CDAA60", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9CA0", Offset = "0x3CD82A0", VA = "0x183CD9CA0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD71C0", Offset = "0x3CD57C0", VA = "0x183CD71C0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD61A0", Offset = "0x3CD47A0", VA = "0x183CD61A0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2FC0", Offset = "0x3CD15C0", VA = "0x183CD2FC0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LRIABUPBGVB player, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x863E6F0", Offset = "0x863CCF0", VA = "0x18863E6F0", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3C82970", Offset = "0x3C80F70", VA = "0x183C82970", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3C82720", Offset = "0x3C80D20", VA = "0x183C82720", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3C82400", Offset = "0x3C80A00", VA = "0x183C82400", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3C82020", Offset = "0x3C80620", VA = "0x183C82020", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3C81B70", Offset = "0x3C80170", VA = "0x183C81B70", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3C815F0", Offset = "0x3C7FBF0", VA = "0x183C815F0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3C80FC0", Offset = "0x3C7F5C0", VA = "0x183C80FC0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3C808C0", Offset = "0x3C7EEC0", VA = "0x183C808C0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3C80100", Offset = "0x3C7E700", VA = "0x183C80100", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F870", Offset = "0x3C7DE70", VA = "0x183C7F870", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EF20", Offset = "0x3C7D520", VA = "0x183C7EF20", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E510", Offset = "0x3C7CB10", VA = "0x183C7E510", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DA30", Offset = "0x3C7C030", VA = "0x183C7DA30", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CE80", Offset = "0x3C7B480", VA = "0x183C7CE80", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x863E650", Offset = "0x863CC50", VA = "0x18863E650", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3C82970", Offset = "0x3C80F70", VA = "0x183C82970", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3C82720", Offset = "0x3C80D20", VA = "0x183C82720", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3C82400", Offset = "0x3C80A00", VA = "0x183C82400", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3C82020", Offset = "0x3C80620", VA = "0x183C82020", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3C81B70", Offset = "0x3C80170", VA = "0x183C81B70", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3C815F0", Offset = "0x3C7FBF0", VA = "0x183C815F0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3C80FC0", Offset = "0x3C7F5C0", VA = "0x183C80FC0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3C808C0", Offset = "0x3C7EEC0", VA = "0x183C808C0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3C80100", Offset = "0x3C7E700", VA = "0x183C80100", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F870", Offset = "0x3C7DE70", VA = "0x183C7F870", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EF20", Offset = "0x3C7D520", VA = "0x183C7EF20", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3C7E510", Offset = "0x3C7CB10", VA = "0x183C7E510", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DA30", Offset = "0x3C7C030", VA = "0x183C7DA30", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CE80", Offset = "0x3C7B480", VA = "0x183C7CE80", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x863F610", Offset = "0x863DC10", VA = "0x18863F610", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0A80", Offset = "0x3CBF080", VA = "0x183CC0A80", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0830", Offset = "0x3CBEE30", VA = "0x183CC0830", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFA10", Offset = "0x3CCE010", VA = "0x183CCFA10", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF620", Offset = "0x3CCDC20", VA = "0x183CCF620", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF170", Offset = "0x3CCD770", VA = "0x183CCF170", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEBF0", Offset = "0x3CCD1F0", VA = "0x183CCEBF0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE5C0", Offset = "0x3CCCBC0", VA = "0x183CCE5C0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDEC0", Offset = "0x3CCC4C0", VA = "0x183CCDEC0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD700", Offset = "0x3CCBD00", VA = "0x183CCD700", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCE70", Offset = "0x3CCB470", VA = "0x183CCCE70", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC520", Offset = "0x3CCAB20", VA = "0x183CCC520", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBB10", Offset = "0x3CCA110", VA = "0x183CCBB10", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB030", Offset = "0x3CC9630", VA = "0x183CCB030", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA480", Offset = "0x3CC8A80", VA = "0x183CCA480", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x863F570", Offset = "0x863DB70", VA = "0x18863F570", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0A80", Offset = "0x3CBF080", VA = "0x183CC0A80", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3CC0830", Offset = "0x3CBEE30", VA = "0x183CC0830", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFA10", Offset = "0x3CCE010", VA = "0x183CCFA10", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF620", Offset = "0x3CCDC20", VA = "0x183CCF620", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF170", Offset = "0x3CCD770", VA = "0x183CCF170", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEBF0", Offset = "0x3CCD1F0", VA = "0x183CCEBF0", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE5C0", Offset = "0x3CCCBC0", VA = "0x183CCE5C0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDEC0", Offset = "0x3CCC4C0", VA = "0x183CCDEC0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD700", Offset = "0x3CCBD00", VA = "0x183CCD700", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3CCCE70", Offset = "0x3CCB470", VA = "0x183CCCE70", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC520", Offset = "0x3CCAB20", VA = "0x183CCC520", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCBB10", Offset = "0x3CCA110", VA = "0x183CCBB10", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB030", Offset = "0x3CC9630", VA = "0x183CCB030", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA480", Offset = "0x3CC8A80", VA = "0x183CCA480", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LKHKEMFRQFE.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x863C890", Offset = "0x863AE90", VA = "0x18863C890", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x863CA90", Offset = "0x863B090", VA = "0x18863CA90", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2152F70", Offset = "0x2151570", VA = "0x182152F70")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class QVBOEFGXEXX
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x863AC50", Offset = "0x8639250", VA = "0x18863AC50")]
		private static bool BFEPXRBJMZE(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3C37910", Offset = "0x3C35F10", VA = "0x183C37910")]
		[CanBeNull]
		public static a NDQSTYBELDY<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class OHRLUJXVIGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public LRIABUPBGVB[] YUABNWFFBNX;

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OHRLUJXVIGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x862EB50", Offset = "0x862D150", VA = "0x18862EB50")]
			internal int OLQTDVFSYSV(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x862EAC0", Offset = "0x862D0C0", VA = "0x18862EAC0")]
			internal void OLLMGOLVPHM(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static LRIABUPBGVB[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int AWUQTSMYXGY;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8640F50", Offset = "0x863F550", VA = "0x188640F50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8641520", Offset = "0x863FB20", VA = "0x188641520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x86418A0", Offset = "0x863FEA0", VA = "0x1886418A0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8641910", Offset = "0x863FF10", VA = "0x188641910")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8641420", Offset = "0x863FA20", VA = "0x188641420")]
		private void RVPLPOVKBNW(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8641420", Offset = "0x863FA20", VA = "0x188641420")]
		private void BROIYLBNFAG(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8641340", Offset = "0x863F940", VA = "0x188641340")]
		private void BQSYQXRVUAY(LRIABUPBGVB a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8640E00", Offset = "0x863F400", VA = "0x188640E00")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x86419B0", Offset = "0x863FFB0", VA = "0x1886419B0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8641430", Offset = "0x863FA30", VA = "0x188641430")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xAB7500", Offset = "0xAB5B00", VA = "0x180AB7500")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class XECDLJBRJKK
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x86455A0", Offset = "0x8643BA0", VA = "0x1886455A0")]
		public static int BUOPRWDSWHG(this LRIABUPBGVB a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8645730", Offset = "0x8643D30", VA = "0x188645730")]
		public static void ESFWSMSHOXS(this LRIABUPBGVB a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class RASADBGVEVK
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void RoomPropertyUpdateCallback(Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate void PlayerPropertyUpdateCallback(LRIABUPBGVB player, Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback BPRTMIOYREW
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x863B0D0", Offset = "0x86396D0", VA = "0x18863B0D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x863AE90", Offset = "0x8639490", VA = "0x18863AE90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback NAVIXNTTPFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x863B190", Offset = "0x8639790", VA = "0x18863B190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x863AD10", Offset = "0x8639310", VA = "0x18863AD10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback FKUXELWOWTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x863ADD0", Offset = "0x86393D0", VA = "0x18863ADD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x863B250", Offset = "0x8639850", VA = "0x18863B250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback APZTLQPURVB
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x863B010", Offset = "0x8639610", VA = "0x18863B010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x863AF50", Offset = "0x8639550", VA = "0x18863AF50")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class WEJZBCMATQF
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int YKBZJKLVHED;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int ERMRFGWMRNJ;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int YSWBCWZEPKF;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8644610", Offset = "0x8642C10", VA = "0x188644610")]
		public static void LIABZREVHBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x86448E0", Offset = "0x8642EE0", VA = "0x1886448E0")]
		public static void YVEXGVDVQVS(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8644660", Offset = "0x8642C60", VA = "0x188644660")]
		public static int XKTLXSODHVR(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RegisterService(typeof(IMHGASDTZON), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class IMHGASDTZON : SJEOPBKQURR, UUPKZPXZDMZ, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Dictionary<object, object> OBJGHDHIENY;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly Dictionary<object, object> JPKCWWYMBPY;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly Dictionary<object, object> HAIHFONELUK;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly KAUBEGREKJA HYHTDUERTDO;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly KAUBEGREKJA MLCECWTYEZF;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly KAUBEGREKJA QSCBXUWFZCT;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly KAUBEGREKJA RISRPVCKRHY;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly KAUBEGREKJA QYXBLRCGSWD;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static int FBPQCRNZEPG;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8628860", Offset = "0x8626E60", VA = "0x188628860", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x86287C0", Offset = "0x8626DC0", VA = "0x1886287C0", Slot = "19")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8627D00", Offset = "0x8626300", VA = "0x188627D00", Slot = "4")]
		public bool FRFRCHITJDE(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x86289E0", Offset = "0x8626FE0", VA = "0x1886289E0", Slot = "5")]
		public int NGOGMOHXYFA(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x86274C0", Offset = "0x8625AC0", VA = "0x1886274C0", Slot = "6")]
		public bool BTXJOGDTJCV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8629610", Offset = "0x8627C10", VA = "0x188629610", Slot = "7")]
		public bool SZVNWSPOISA(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x86298D0", Offset = "0x8627ED0", VA = "0x1886298D0", Slot = "8")]
		public void VBRYLLLXHKJ(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8628650", Offset = "0x8626C50", VA = "0x188628650", Slot = "9")]
		public bool IBCHBFWTLWR(KMNYUBYLMOF a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x86292E0", Offset = "0x86278E0", VA = "0x1886292E0", Slot = "10")]
		public bool QAZCLSSAJGK(KMNYUBYLMOF a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8629AE0", Offset = "0x86280E0", VA = "0x188629AE0", Slot = "11")]
		public bool ZKCDHRVYNWP(KMNYUBYLMOF a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8629090", Offset = "0x8627690", VA = "0x188629090", Slot = "12")]
		public void OXVSJNFCYUH(KMNYUBYLMOF a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x8627B40", Offset = "0x8626140", VA = "0x188627B40", Slot = "13")]
		public void FOIACVACMDO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8627350", Offset = "0x8625950", VA = "0x188627350", Slot = "14")]
		public void BEGCHBZWZYO(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8628FB0", Offset = "0x86275B0", VA = "0x188628FB0", Slot = "15")]
		public void OOMYDZXLHIW(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x86297C0", Offset = "0x8627DC0", VA = "0x1886297C0", Slot = "16")]
		public void UQBQUEVSFZD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8628DF0", Offset = "0x86273F0", VA = "0x188628DF0", Slot = "17")]
		public void NKPPPPFFQKV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8627550", Offset = "0x8625B50", VA = "0x188627550")]
		private static void DBZDWSQZSDG(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8627E30", Offset = "0x8626430", VA = "0x188627E30")]
		private static bool IBCHBFWTLWR(Dictionary<object, object> a, LRIABUPBGVB b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8627AA0", Offset = "0x86260A0", VA = "0x188627AA0")]
		private static bool DEETSEIAZXU(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8628900", Offset = "0x8626F00", VA = "0x188628900")]
		private static int KIJVSDZFVMW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public IMHGASDTZON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RegisterService(typeof(FJNGHMMLOCT), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class FJNGHMMLOCT : KCEPQMCUHSR, UUPKZPXZDMZ, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static Hashtable ZUSCUDDHVAN;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static Hashtable GUNMNFTUNVS;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static KAUBEGREKJA IBRGWQUQOAJ;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly KAUBEGREKJA ETYLSZHZOUE;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x8626250", Offset = "0x8624850", VA = "0x188626250", Slot = "8")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x86262F0", Offset = "0x86248F0", VA = "0x1886262F0", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8626170", Offset = "0x8624770", VA = "0x188626170", Slot = "4")]
		public void BESVZIHDHDL(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8626A00", Offset = "0x8625000", VA = "0x188626A00", Slot = "5")]
		public bool YETUYCMCZAF(KMNYUBYLMOF a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8626390", Offset = "0x8624990", VA = "0x188626390", Slot = "6")]
		public void SKXVZATUAVN(ViewId a, string b, RpcTarget c, LRIABUPBGVB d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public FJNGHMMLOCT()
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
