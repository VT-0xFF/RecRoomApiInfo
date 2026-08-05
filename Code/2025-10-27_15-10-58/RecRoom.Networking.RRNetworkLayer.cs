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
		[Cpp2IlInjected.Address(RVA = "0x8845890", Offset = "0x8844890", VA = "0x188845890", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		private int[] LHVPIFQWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] LHQIKYWYSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset EVWCTMNURRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset EWBJQTHSBCX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x24AA5C0", Offset = "0x24A95C0", VA = "0x1824AA5C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88607B0", Offset = "0x885F7B0", VA = "0x1888607B0")]
		private void SSAHAHAUBXG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8860EF0", Offset = "0x885FEF0", VA = "0x188860EF0")]
		private void SSFNXNURLIP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8860700", Offset = "0x885F700", VA = "0x188860700", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8861150", Offset = "0x8860150", VA = "0x188861150")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class ETURDCFFDNU
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log GZEQVCYJDHO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log MMZNBLZUFJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x88419F0", Offset = "0x88409F0", VA = "0x1888419F0")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface ZIJIAJVRGPS
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView SBPFIYCWMPT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType DGUQWYIJZWW
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool HNUUCGKJCGT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "2")]
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
	internal interface DATKHZVDQAE
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool JLOSYYKMPAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SVONMZSFNIZ(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface KYJAMFGWOVJ : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YTBQRMTMKZK(ZIJIAJVRGPS a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GXZDBUQWFXF(ZIJIAJVRGPS a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(HMFSBTAVBZS.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ORMLRKSGXNY();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LBGGYHSWTIR(object a);
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
	public class WDABEVVJTSS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), DATKHZVDQAE> EJKOACHMLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<ZIJIAJVRGPS> VNXVKTNJUVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> YKDUTIBGSIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int DRXEBOUGVMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool PNJTIBJRRDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HMFSBTAVBZS.ApplyNetworkTransform LFNTWLBUGPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream KVPQDBIYAQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker OCNLPOVQKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker DMKIIRSWRHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] JAJUEEEZZBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float RVNYMEKUZQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int BICGFDTVSFC;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x885F5C0", Offset = "0x885E5C0", VA = "0x18885F5C0")]
		public WDABEVVJTSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x885F030", Offset = "0x885E030", VA = "0x18885F030")]
		public void Pause(HMFSBTAVBZS.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x885EFE0", Offset = "0x885DFE0", VA = "0x18885EFE0")]
		public void ORMLRKSGXNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x885F1F0", Offset = "0x885E1F0", VA = "0x18885F1F0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x885E100", Offset = "0x885D100", VA = "0x18885E100")]
		public bool Add(ZIJIAJVRGPS networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x885F0B0", Offset = "0x885E0B0", VA = "0x18885F0B0")]
		public bool Remove(ZIJIAJVRGPS networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x885EDD0", Offset = "0x885DDD0", VA = "0x18885EDD0")]
		private DATKHZVDQAE OFCROOXWKAL(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x885F1E0", Offset = "0x885E1E0", VA = "0x18885F1E0")]
		public void UUTEVZZTCFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x885F050", Offset = "0x885E050", VA = "0x18885F050")]
		private void QBMGBFATRJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x885EDB0", Offset = "0x885DDB0", VA = "0x18885EDB0")]
		private void JIDWTDXBSPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x885EA00", Offset = "0x885DA00", VA = "0x18885EA00")]
		public bool EEBWWORKPAN(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x885E610", Offset = "0x885D610", VA = "0x18885E610")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class EBNHKYQZPBL : DATKHZVDQAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ZIJIAJVRGPS APLPYJTMWQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint PLRCRCRDRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int VBSZEERPDVD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool JLOSYYKMPAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xADBE20", Offset = "0xADAE20", VA = "0x180ADBE20")]
		public EBNHKYQZPBL(ZIJIAJVRGPS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88416C0", Offset = "0x88406C0", VA = "0x1888416C0", Slot = "5")]
		public bool SVONMZSFNIZ(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88415E0", Offset = "0x88405E0", VA = "0x1888415E0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ELBYEAASEVE : DATKHZVDQAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HMFSBTAVBZS.ApplyNetworkTransform LFNTWLBUGPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId ZKDFJAUVAHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int VBSZEERPDVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint PLRCRCRDRXS;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JLOSYYKMPAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D71930", Offset = "0x1D70930", VA = "0x181D71930")]
		public ELBYEAASEVE(ViewId a, HMFSBTAVBZS.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88419B0", Offset = "0x88409B0", VA = "0x1888419B0", Slot = "5")]
		public bool SVONMZSFNIZ(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88417D0", Offset = "0x88407D0", VA = "0x1888417D0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class DWJSCKWYAFQ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8841060", Offset = "0x8840060", VA = "0x188841060")]
		public static void LDGVYQLXUAF(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88409F0", Offset = "0x883F9F0", VA = "0x1888409F0")]
		public static void BYMQRCOKHRW(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8840EF0", Offset = "0x883FEF0", VA = "0x188840EF0")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8841220", Offset = "0x8840220", VA = "0x188841220")]
		public static void RAPRLGMCVGN(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(KYJAMFGWOVJ), new string[] { })]
	public class RHUAMZASOIS : KYJAMFGWOVJ, INetworkUpdateSystem, UZCAYKEWQQA, AXORFOQTGRK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log GPABEBERUDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private WDABEVVJTSS QICFMXDZXDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint CCRMPWZFFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float SGTDFNOCYCS;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x884F490", Offset = "0x884E490", VA = "0x18884F490", Slot = "4")]
		public void YTBQRMTMKZK(ZIJIAJVRGPS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x884EFD0", Offset = "0x884DFD0", VA = "0x18884EFD0", Slot = "5")]
		public void GXZDBUQWFXF(ZIJIAJVRGPS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x884F1D0", Offset = "0x884E1D0", VA = "0x18884F1D0", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x884F380", Offset = "0x884E380", VA = "0x18884F380", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x884E890", Offset = "0x884D890", VA = "0x18884E890")]
		private void ECWOFDLLPQW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x884F460", Offset = "0x884E460", VA = "0x18884F460", Slot = "6")]
		public void Pause(HMFSBTAVBZS.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x884F400", Offset = "0x884E400", VA = "0x18884F400", Slot = "7")]
		public void ORMLRKSGXNY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x884F320", Offset = "0x884E320", VA = "0x18884F320", Slot = "8")]
		public void LBGGYHSWTIR(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x884E500", Offset = "0x884D500", VA = "0x18884E500")]
		private void CHFLYAHFGTG(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x884EEB0", Offset = "0x884DEB0", VA = "0x18884EEB0", Slot = "11")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x884F5B0", Offset = "0x884E5B0", VA = "0x18884F5B0")]
		public RHUAMZASOIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WEBCAVXRZZW : DATKHZVDQAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float MWUQJROVTIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int VBSZEERPDVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint PLRCRCRDRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType ZUNIHXHAUIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo TDWORFFRFMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int MKDZIQCGGVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] GIDSBXHQCJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo MUOWRHVHRHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int ATADTYSUDWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] WTEXUCJGETA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JLOSYYKMPAW
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x885FC70", Offset = "0x885EC70", VA = "0x18885FC70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x885FCA0", Offset = "0x885ECA0", VA = "0x18885FCA0")]
		public WEBCAVXRZZW(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x885FC30", Offset = "0x885EC30", VA = "0x18885FC30", Slot = "5")]
		public bool SVONMZSFNIZ(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x885F7B0", Offset = "0x885E7B0", VA = "0x18885F7B0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x885FB30", Offset = "0x885EB30", VA = "0x18885FB30")]
		internal EBNHKYQZPBL QVLLRGTLRKU(ZIJIAJVRGPS a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x885F960", Offset = "0x885E960", VA = "0x18885F960")]
		private static void QPFHFNKUFOW(EBNHKYQZPBL a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RegisterService(typeof(TVSXTQGGFFF), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class TVSXTQGGFFF : PJBIDVXKPOK, UZCAYKEWQQA, AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Hashtable PLPVVQUHUKX;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Hashtable STTFJWKOHZN;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Hashtable OVBCUXRPMGX;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly GWGBIKXISIV PCKOHQLNZRH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly GWGBIKXISIV WFDUVYOXEII;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly GWGBIKXISIV VVNEZXMKRKY;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly GWGBIKXISIV IRRRELTTSWB;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly GWGBIKXISIV YPWOSKCEKEI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static int GMIPBRSWOBT;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x885CFB0", Offset = "0x885BFB0", VA = "0x18885CFB0", Slot = "4")]
		public bool TJDDDSOSVOR(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x885B630", Offset = "0x885A630", VA = "0x18885B630", Slot = "5")]
		public int BJUSIEWZZPP(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x885C510", Offset = "0x885B510", VA = "0x18885C510", Slot = "6")]
		public bool MWZZQRPIJYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x885CE20", Offset = "0x885BE20", VA = "0x18885CE20", Slot = "7")]
		public bool THECKJHUYFH(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x885D5C0", Offset = "0x885C5C0", VA = "0x18885D5C0", Slot = "8")]
		public void WEGKKNYWPPG(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x885BC60", Offset = "0x885AC60", VA = "0x18885BC60", Slot = "9")]
		public bool IVKXCUIWMSY(IRRSNCQWIPE a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x885C700", Offset = "0x885B700", VA = "0x18885C700", Slot = "10")]
		public bool OTMSRICAVSJ(IRRSNCQWIPE a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x885C9E0", Offset = "0x885B9E0", VA = "0x18885C9E0", Slot = "11")]
		public bool OWMISOPELAG(IRRSNCQWIPE a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x885CC50", Offset = "0x885BC50", VA = "0x18885CC50", Slot = "12")]
		public void RSJWRSTSQIW(IRRSNCQWIPE a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x885CAF0", Offset = "0x885BAF0", VA = "0x18885CAF0", Slot = "13")]
		public void RBNNPKUWNEF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x885B9E0", Offset = "0x885A9E0", VA = "0x18885B9E0", Slot = "14")]
		public void EGLUPSPWLKB(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x885D0F0", Offset = "0x885C0F0", VA = "0x18885D0F0", Slot = "15")]
		public void UFLXRMYYQST(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x885BAF0", Offset = "0x885AAF0", VA = "0x18885BAF0", Slot = "16")]
		public void EMMWBBZTNIS(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x885C5A0", Offset = "0x885B5A0", VA = "0x18885C5A0", Slot = "17")]
		public void NRLTCXJPEAU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x885D1A0", Offset = "0x885C1A0", VA = "0x18885D1A0")]
		private static void UTLVBADFPON(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x885BDD0", Offset = "0x885ADD0", VA = "0x18885BDD0")]
		private static bool IVKXCUIWMSY(Hashtable a, XLYBIIWOHJI b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x885C430", Offset = "0x885B430", VA = "0x18885C430")]
		private static int LRUBXSZEVDN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x885C390", Offset = "0x885B390", VA = "0x18885C390", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x885BBC0", Offset = "0x885ABC0", VA = "0x18885BBC0", Slot = "19")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public TVSXTQGGFFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(TBLSFWYUJSZ), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class TBLSFWYUJSZ : JWONSZVODXG, UZCAYKEWQQA, AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static Hashtable PAVWLSZJZGY;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Hashtable MOIKJFUQBUP;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static GWGBIKXISIV LHNDBUHEIXI;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly GWGBIKXISIV XYVYNYGJABR;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8857040", Offset = "0x8856040", VA = "0x188857040", Slot = "4")]
		public void NXQVMWYMAVG(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8856D10", Offset = "0x8855D10", VA = "0x188856D10", Slot = "5")]
		public bool JRIYLDPVPJG(IRRSNCQWIPE a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8857120", Offset = "0x8856120", VA = "0x188857120", Slot = "6")]
		public void NZEUSVKBJZE(ViewId a, string b, RpcTarget c, XLYBIIWOHJI d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8856BD0", Offset = "0x8855BD0", VA = "0x188856BD0", Slot = "8")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8856C70", Offset = "0x8855C70", VA = "0x188856C70", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public TBLSFWYUJSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class HLAGXCCPRHV
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8841CB0", Offset = "0x8840CB0", VA = "0x188841CB0")]
		public static XLYBIIWOHJI BNQSGWHQIIG(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8841D40", Offset = "0x8840D40", VA = "0x188841D40")]
		public static PlayerId ToPlayerId(this XLYBIIWOHJI player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, IDHCSTFBIGK, HHTCNVFGVYJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool OCQAMOATNVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView JVPFJIVAHGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<EHDLXBWWXLB> JRAYUMFXONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool EFYYFWIBXYB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId VGNOVYOBKLG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x884FEF0", Offset = "0x884EEF0", VA = "0x18884FEF0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId VHYMXYEVRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x884FEF0", Offset = "0x884EEF0", VA = "0x18884FEF0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView IAPDKSMLFIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x884FF70", Offset = "0x884EF70", VA = "0x18884FF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView SBPFIYCWMPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x884FF70", Offset = "0x884EF70", VA = "0x18884FF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public XLYBIIWOHJI MHUEMGFWUKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8850070", Offset = "0x884F070", VA = "0x188850070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XLYBIIWOHJI GSIRRRQANUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x88503D0", Offset = "0x884F3D0", VA = "0x1888503D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KNRAKTUYYMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x88501D0", Offset = "0x884F1D0", VA = "0x1888501D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool QWHRGJABMRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8850340", Offset = "0x884F340", VA = "0x188850340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool JZUKBVSLCNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x884FE20", Offset = "0x884EE20", VA = "0x18884FE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BSOGJOJOIZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8850100", Offset = "0x884F100", VA = "0x188850100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool GWGXFQPIFDC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x884FE20", Offset = "0x884EE20", VA = "0x18884FE20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool DCDSPFHYYIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x884FEA0", Offset = "0x884EEA0", VA = "0x18884FEA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string NIUYIPUFINS
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x884FFE0", Offset = "0x884EFE0", VA = "0x18884FFE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool SBUKBQNINYH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x884FDA0", Offset = "0x884EDA0", VA = "0x18884FDA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<XLYBIIWOHJI> TGQDCFPGGWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x884FC70", Offset = "0x884EC70", VA = "0x18884FC70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8850460", Offset = "0x884F460", VA = "0x188850460")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x884FBD0", Offset = "0x884EBD0", VA = "0x18884FBD0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B430", Offset = "0x7B4A430", VA = "0x187B4B430")]
		private void QSKDPWJBSKK(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x884F7D0", Offset = "0x884E7D0", VA = "0x18884F7D0", Slot = "9")]
		public void RegisterDestroyHandler(EHDLXBWWXLB handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x884FA10", Offset = "0x884EA10", VA = "0x18884FA10", Slot = "10")]
		public void UnregisterDestroyHandler(EHDLXBWWXLB handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x884F7B0", Offset = "0x884E7B0", VA = "0x18884F7B0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class AGRPCOMULZW
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, XLYBIIWOHJI targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, XLYBIIWOHJI targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, XLYBIIWOHJI newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CompilerGenerated]
		private static InstantiateCallback XGIUVMDZLUE;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback JQGFCZANWGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x883F200", Offset = "0x883E200", VA = "0x18883F200")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x883FE30", Offset = "0x883EE30", VA = "0x18883FE30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback RQJYEUFPHAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x883F860", Offset = "0x883E860", VA = "0x18883F860")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x883F9B0", Offset = "0x883E9B0", VA = "0x18883F9B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback PCMDLADSSKT
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x883FCB0", Offset = "0x883ECB0", VA = "0x18883FCB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x883F4D0", Offset = "0x883E4D0", VA = "0x18883F4D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback YZPZZWMORBQ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x883F410", Offset = "0x883E410", VA = "0x18883F410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x88403F0", Offset = "0x883F3F0", VA = "0x1888403F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback YCXCWDUWUWI
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x88404B0", Offset = "0x883F4B0", VA = "0x1888404B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x883FD70", Offset = "0x883ED70", VA = "0x18883FD70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback SOPTJQVPUFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8840090", Offset = "0x883F090", VA = "0x188840090")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x883FA70", Offset = "0x883EA70", VA = "0x18883FA70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback DSFDMPANSZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x883F140", Offset = "0x883E140", VA = "0x18883F140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x883F6E0", Offset = "0x883E6E0", VA = "0x18883F6E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler OHFXOGSETKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x883FBF0", Offset = "0x883EBF0", VA = "0x18883FBF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x883F7A0", Offset = "0x883E7A0", VA = "0x18883F7A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler OYZIHKNPKBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x883FB30", Offset = "0x883EB30", VA = "0x18883FB30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8840330", Offset = "0x883F330", VA = "0x188840330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8840270", Offset = "0x883F270", VA = "0x188840270")]
		public static void UAFFPQOTFMO([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8840000", Offset = "0x883F000", VA = "0x188840000")]
		public static void RTPFNIMOKKU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x88401E0", Offset = "0x883F1E0", VA = "0x1888401E0")]
		public static void SVGMVGFPHXN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8840150", Offset = "0x883F150", VA = "0x188840150")]
		public static void SUAQUTXPHMS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x883F920", Offset = "0x883E920", VA = "0x18883F920")]
		public static void HZOGWGXLNOF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x883F590", Offset = "0x883E590", VA = "0x18883F590")]
		public static void DSEFJFEHJCZ(RRNetworkView a, string b, XLYBIIWOHJI c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x883F2C0", Offset = "0x883E2C0", VA = "0x18883F2C0")]
		public static void BESHEHFYESU(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x883FEF0", Offset = "0x883EEF0", VA = "0x18883FEF0")]
		public static void PRBRGVLHKZG(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class GGYMYEERAXJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8841B90", Offset = "0x8840B90", VA = "0x188841B90")]
		[CanBeNull]
		private static bool ITDLWVAQTAN(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8841AB0", Offset = "0x8840AB0", VA = "0x188841AB0")]
		[CanBeNull]
		public static Component ICHOQOJBQEJ(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3999B40", Offset = "0x3998B40", VA = "0x183999B40")]
		[CanBeNull]
		public static a ICHOQOJBQEJ<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3999990", Offset = "0x3998990", VA = "0x183999990")]
		[CanBeNull]
		public static b AFFAEWKNURT<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3999AB0", Offset = "0x3998AB0", VA = "0x183999AB0")]
		public static bool BMKODBCMNRG<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8841C40", Offset = "0x8840C40", VA = "0x188841C40")]
		[CanBeNull]
		public static RRNetworkView SNDGVLWAVGE(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler RPFQRSEZGLA;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler HNQVBJEYTYC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8850590", Offset = "0x884F590", VA = "0x188850590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8850760", Offset = "0x884F760", VA = "0x188850760")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8850720", Offset = "0x884F720", VA = "0x188850720")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RegisterService(typeof(PFYUVYEAIGB), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class PFYUVYEAIGB : YUJVIAXAESI, UZCAYKEWQQA, AXORFOQTGRK, KTWSMBNSLGS, OUANPQHUURE, OYGFOCCYTLG, LTOXHYHZXEQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ULCVYJVRYIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int RRJIQRJZDMD;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public ULCVYJVRYIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x885E040", Offset = "0x885D040", VA = "0x18885E040")]
			internal object HXVDTZIXRWU((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static Log QESWUXMMWCA;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static Log MSUTAWNWHWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[DependsOn]
		private ICDNZTGSLNZ PQKKZGPCOCY;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Dictionary<int, HashSet<int>> UQKAEUIZROK;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<int, int> GZAZOMSRDYD;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<(GameObject GameObject, int ParentCount)> TWPJLCCUFZM;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<GameObject> NJJMXTXBMWX;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static List<int> CCZOCPZSBMJ;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly List<RRNetworkView> WWBRIJIUJXF;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly GWGBIKXISIV IRRRELTTSWB;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly GWGBIKXISIV YPWOSKCEKEI;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x884A840", Offset = "0x8849840", VA = "0x18884A840", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8848430", Offset = "0x8847430", VA = "0x188848430", Slot = "9")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x884A680", Offset = "0x8849680", VA = "0x18884A680", Slot = "10")]
		public void InitExternal(GQPULEKOHTO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x884D2D0", Offset = "0x884C2D0", VA = "0x18884D2D0", Slot = "11")]
		public void TLGCHEFHCLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8848780", Offset = "0x8847780", VA = "0x188848780")]
		private void GDBDYSFXGUC(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x884D490", Offset = "0x884C490", VA = "0x18884D490")]
		private void VEXXRUKSMVB(FPWIGKGWIZD a, FPWIGKGWIZD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x884B270", Offset = "0x884A270", VA = "0x18884B270")]
		public GameObject LMNAOJNMCPZ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8846210", Offset = "0x8845210", VA = "0x188846210")]
		public GameObject BGSDNOIQTCP(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x884D580", Offset = "0x884C580", VA = "0x18884D580")]
		public GameObject WYEFHKLVHWS(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x884D150", Offset = "0x884C150", VA = "0x18884D150")]
		public GameObject RUXPHIVWALW(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x884C930", Offset = "0x884B930", VA = "0x18884C930", Slot = "6")]
		public void QILDFKFMMGA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x884DD00", Offset = "0x884CD00", VA = "0x18884DD00")]
		public void ZAZHXEGYWMZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x884B830", Offset = "0x884A830", VA = "0x18884B830", Slot = "7")]
		public void MKAOXDKLXTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x884ADE0", Offset = "0x8849DE0", VA = "0x18884ADE0", Slot = "4")]
		public GameObject[] KXNYSIWRNBQ(IList<VODJLYBZHVP> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x884DD70", Offset = "0x884CD70", VA = "0x18884DD70", Slot = "5")]
		public void ZBJXORAPSLD(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8847CB0", Offset = "0x8846CB0", VA = "0x188847CB0")]
		public void DRUCQHGXQPZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8846310", Offset = "0x8845310", VA = "0x188846310")]
		private void CHFLYAHFGTG(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x884D800", Offset = "0x884C800", VA = "0x18884D800")]
		private void XDGCIJPHRKO(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x884BA40", Offset = "0x884AA40", VA = "0x18884BA40")]
		private void OBTZEJUTSLG(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8845F90", Offset = "0x8844F90", VA = "0x188845F90")]
		private void BFXBRVPZJGQ(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x884B440", Offset = "0x884A440", VA = "0x18884B440")]
		private void LTGNOJMBRSY(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x884AB90", Offset = "0x8849B90", VA = "0x18884AB90")]
		private void KMVIORLJEEY(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8847D90", Offset = "0x8846D90", VA = "0x188847D90")]
		private void EIJEHHZBAOO(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8845DA0", Offset = "0x8844DA0", VA = "0x188845DA0")]
		private GameObject AYQJHKHZEWN(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x884CA50", Offset = "0x884BA50", VA = "0x18884CA50")]
		private GameObject ROWICQMTWXZ(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x884B840", Offset = "0x884A840", VA = "0x18884B840")]
		private static GameObject MPIZUTYGRER(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8845B90", Offset = "0x8844B90", VA = "0x188845B90")]
		private static GameObject AFBINZGNMWY(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x884C940", Offset = "0x884B940", VA = "0x18884C940")]
		private static void RLANLLPQOUX(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8846610", Offset = "0x8845610", VA = "0x188846610")]
		private GameObject[] CMZMFSZNMNQ(IList<VODJLYBZHVP> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x88479F0", Offset = "0x88469F0", VA = "0x1888479F0")]
		private GameObject[] DCFMNZTKNBW(InstantiateParameters[] a, int b, XLYBIIWOHJI c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x88488A0", Offset = "0x88478A0", VA = "0x1888488A0")]
		private GameObject GWXMUDJECNI([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F8C0", Offset = "0x7B2E8C0", VA = "0x187B2F8C0")]
		private static bool DSSJJJIVQDF(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8846DD0", Offset = "0x8845DD0", VA = "0x188846DD0")]
		private void DAPVYCDCYUD(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8848CB0", Offset = "0x8847CB0", VA = "0x188848CB0")]
		private void HBHMMZPKTKH(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x884C540", Offset = "0x884B540", VA = "0x18884C540")]
		private static void QASWATYKKJY(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x884B110", Offset = "0x884A110", VA = "0x18884B110")]
		private void LAJPIRBTUIO(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8848390", Offset = "0x8847390", VA = "0x188848390")]
		private static int ENAEFMGRRMO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x884AD80", Offset = "0x8849D80", VA = "0x18884AD80")]
		private void KSHRZGLWJWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x884BFC0", Offset = "0x884AFC0", VA = "0x18884BFC0")]
		private void PMQHNOKTCZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8845B30", Offset = "0x8844B30", VA = "0x188845B30")]
		private static int AEGJUCREHEW(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x884B960", Offset = "0x884A960", VA = "0x18884B960")]
		private static int[] NVGVRIKWQJB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x884D1D0", Offset = "0x884C1D0", VA = "0x18884D1D0")]
		private static int[] SXFIRBJDCSX(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x884BF80", Offset = "0x884AF80", VA = "0x18884BF80")]
		private void OnMasterClientSwitched(XLYBIIWOHJI newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8849BD0", Offset = "0x8848BD0", VA = "0x188849BD0")]
		private void HEMKXGJKMDZ(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x884BCA0", Offset = "0x884ACA0", VA = "0x18884BCA0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x884DAC0", Offset = "0x884CAC0", VA = "0x18884DAC0")]
		private void YPPHTCPOPCH(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x884B8C0", Offset = "0x884A8C0", VA = "0x18884B8C0")]
		private static void NPXQQQFWFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x884D9C0", Offset = "0x884C9C0", VA = "0x18884D9C0")]
		private void XGAUICPFWSZ(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x884D180", Offset = "0x884C180", VA = "0x18884D180", Slot = "12")]
		private void SMUSGLXJIVI(GQPULEKOHTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1019640", Offset = "0x1018640", VA = "0x181019640", Slot = "13")]
		private void CXZMGJMBDJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public PFYUVYEAIGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xACE140", Offset = "0xACD140", VA = "0x180ACE140")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(TVPBYJVZPXR), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class TVPBYJVZPXR : UZCAYKEWQQA, AXORFOQTGRK, ZHAXCTAVNZI
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

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7B374A0", Offset = "0x7B364A0", VA = "0x187B374A0")]
			public object YDOTEXCHKNL(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class SPETXCBTZKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public FieldInfo SQIBJFQPPVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Func<MonoBehaviour, object> RUESUUQEGOJ;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public SPETXCBTZKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8856B10", Offset = "0x8855B10", VA = "0x188856B10")]
			internal RpcMethodInfo XDHIBWKXOPZ(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5418360", Offset = "0x5417360", VA = "0x185418360")]
			internal object XDCBEPRAFEQ(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class SOZMZVHWPYS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Func<MonoBehaviour, object> IALKXPIZZLM;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public SOZMZVHWPYS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7B38A00", Offset = "0x7B37A00", VA = "0x187B38A00")]
			internal RpcMethodInfo XCRNKCDFMHY(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class MSGQKBNXUFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Type FNRUHXZRMPV;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public MSGQKBNXUFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8845AF0", Offset = "0x8844AF0", VA = "0x188845AF0")]
			internal bool XUUSULNLPCP(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, int> TSJNDOTADNN;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static List<string> ZMPSLABMCTA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int YYBJHSPVLGD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Stopwatch YHKOVBNVZZJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static Dictionary<MethodInfo, ParameterInfo[]> VNMMCTACPSO;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> CMDHMEOSBKR;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8857EA0", Offset = "0x8856EA0", VA = "0x188857EA0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8858B60", Offset = "0x8857B60", VA = "0x188858B60")]
		private void OJEVDRTCQEQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8857D50", Offset = "0x8856D50", VA = "0x188857D50", Slot = "5")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x885B330", Offset = "0x885A330", VA = "0x18885B330")]
		public static bool ZTULZYZMLUR(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x885B240", Offset = "0x885A240", VA = "0x18885B240")]
		public static bool ZRUPBIBPWEF(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8857970", Offset = "0x8856970", VA = "0x188857970")]
		private void CHFLYAHFGTG(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8857C20", Offset = "0x8856C20", VA = "0x188857C20", Slot = "9")]
		public string CKOAXYGUWZR(IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8858870", Offset = "0x8857870", VA = "0x188858870", Slot = "8")]
		public void NXQVMWYMAVG(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8859B00", Offset = "0x8858B00", VA = "0x188859B00", Slot = "6")]
		public void XZHBXEHRLGI(ViewId a, string b, XLYBIIWOHJI c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x88595F0", Offset = "0x88585F0", VA = "0x1888595F0", Slot = "7")]
		public void XZHBXEHRLGI(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8859620", Offset = "0x8858620", VA = "0x188859620")]
		private void XZHBXEHRLGI(ViewId a, string b, RpcTarget c, XLYBIIWOHJI d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8859BD0", Offset = "0x8858BD0", VA = "0x188859BD0")]
		private void ZENKHGBGECL(ViewId a, string b, XLYBIIWOHJI c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8859130", Offset = "0x8858130", VA = "0x188859130")]
		private static void UZTBIIJLBMN(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8858950", Offset = "0x8857950", VA = "0x188858950")]
		private static bool OEXSRWDEUCI(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8857FA0", Offset = "0x8856FA0", VA = "0x188857FA0")]
		private List<RpcMethodInfo> LFFLHOYMVET(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8857C50", Offset = "0x8856C50", VA = "0x188857C50")]
		private static IEnumerable<MethodInfo> DHUYZRXZENX(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8859020", Offset = "0x8858020", VA = "0x188859020")]
		public static ParameterInfo[] SUCMJZJBGMJ(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public TVPBYJVZPXR()
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
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x8850820", Offset = "0x884F820", VA = "0x188850820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x88507A0", Offset = "0x884F7A0", VA = "0x1888507A0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, NEFQUFMXATZ, MJNSBGDXMFC, HTRVWBGIWAB, ZVBIZIVXWCD, BQVUSUQRYNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(ICDNZTGSLNZ), new string[] { })]
		internal class XGHYWOMJHEY : UZCAYKEWQQA, AXORFOQTGRK, ICDNZTGSLNZ
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Dictionary<int, RRNetworkView> UECGXMMKWKR;

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x8860060", Offset = "0x885F060", VA = "0x188860060", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x8860060", Offset = "0x885F060", VA = "0x188860060", Slot = "5")]
			public void EQRPTIUGSAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x885FD10", Offset = "0x885ED10", VA = "0x18885FD10", Slot = "6")]
			public void CKUKZWIWIJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public XGHYWOMJHEY()
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
		private sealed class HTMXAPREZJT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int JDKRJOHFHCT;

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public HTMXAPREZJT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x8844980", Offset = "0x8843980", VA = "0x188844980")]
			internal bool WRSTLHHOQNT(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static GWGBIKXISIV VOYRTDOIEJD;

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
		private bool CSXOJMPKZMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool BKUMIGQYNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool OMGWJGJDSUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int JUJFONQLBUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool NNHEYJESVZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int VTLHODQMAXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private XLYBIIWOHJI GSIRRRQANUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private XLYBIIWOHJI NLAWEPLEFEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool? KDQLDXAGXVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool TAUXUTGRBUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal bool JDMSGSVWATV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal MonoBehaviour[] OCQAKWGHPGL;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly Log VJQZYZXFPHS;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> UECGXMMKWKR
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x88518F0", Offset = "0x88508F0", VA = "0x1888518F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId VHYMXYEVRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8854EA0", Offset = "0x8853EA0", VA = "0x188854EA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId OKOCRTDXMZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8854EA0", Offset = "0x8853EA0", VA = "0x188854EA0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId VGNOVYOBKLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8854EA0", Offset = "0x8853EA0", VA = "0x188854EA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int ORAPIBQRCYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xADF4F0", Offset = "0xADE4F0", VA = "0x180ADF4F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB29000", Offset = "0xB28000", VA = "0x180B29000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int OCBYEPROPIP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAF6930", Offset = "0xAF5930", VA = "0x180AF6930")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xFC12A0", Offset = "0xFC02A0", VA = "0x180FC12A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId ITWGVRWIOQR
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8854D10", Offset = "0x8853D10", VA = "0x188854D10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool JPBHMAEXTEP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xCF83E0", Offset = "0xCF73E0", VA = "0x180CF83E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xCF83F0", Offset = "0xCF73F0", VA = "0x180CF83F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool IJSHZUYYSRI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8854D20", Offset = "0x8853D20", VA = "0x188854D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool XRTPEZDRUUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xB31A30", Offset = "0xB30A30", VA = "0x180B31A30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xB31040", Offset = "0xB30040", VA = "0x180B31040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int RHGHZQJEYAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xB1C870", Offset = "0xB1B870", VA = "0x180B1C870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int RCSYJMMXYAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8854CB0", Offset = "0x8853CB0", VA = "0x188854CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public XLYBIIWOHJI DXXSJSICWRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8854EB0", Offset = "0x8853EB0", VA = "0x188854EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public XLYBIIWOHJI HNZEHUEHABT
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8854C80", Offset = "0x8853C80", VA = "0x188854C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public XLYBIIWOHJI MHUEMGFWUKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8854C80", Offset = "0x8853C80", VA = "0x188854C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public XLYBIIWOHJI ATVMCQRVWWO
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x8854C80", Offset = "0x8853C80", VA = "0x188854C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool PBACEXILTMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8854DF0", Offset = "0x8853DF0", VA = "0x188854DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int RATMTMETHUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8854CE0", Offset = "0x8853CE0", VA = "0x188854CE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] RHSVGWYJUAO
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xACEE90", Offset = "0xACDE90", VA = "0x180ACEE90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xACEBC0", Offset = "0xACDBC0", VA = "0x180ACEBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool KNRAKTUYYMM
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8854EE0", Offset = "0x8853EE0", VA = "0x188854EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OAWKOMRGLGC
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8854E70", Offset = "0x8853E70", VA = "0x188854E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NZIWLYFHMIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x106D080", Offset = "0x106C080", VA = "0x18106D080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x106CDC0", Offset = "0x106BDC0", VA = "0x18106CDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AZKGNCYZVPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xBEADC0", Offset = "0xBE9DC0", VA = "0x180BEADC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> GASIMCBFZLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8854B10", Offset = "0x8853B10", VA = "0x188854B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x88550A0", Offset = "0x88540A0", VA = "0x1888550A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<XLYBIIWOHJI> NZNEWMGGLHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8854820", Offset = "0x8853820", VA = "0x188854820")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8854310", Offset = "0x8853310", VA = "0x188854310")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<XLYBIIWOHJI> EEGHWIWWOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8854820", Offset = "0x8853820", VA = "0x188854820")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8854310", Offset = "0x8853310", VA = "0x188854310")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> GVKBCYHURPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8851680", Offset = "0x8850680", VA = "0x188851680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x88548D0", Offset = "0x88538D0", VA = "0x1888548D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> FYQEYDTSGBS
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8851680", Offset = "0x8850680", VA = "0x188851680")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x88548D0", Offset = "0x88538D0", VA = "0x1888548D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> ARTYHEHGNZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8854BC0", Offset = "0x8853BC0", VA = "0x188854BC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x8855150", Offset = "0x8854150", VA = "0x188855150")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action FBYAVMYRFSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8854A60", Offset = "0x8853A60", VA = "0x188854A60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8854FF0", Offset = "0x8853FF0", VA = "0x188854FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8854610", Offset = "0x8853610", VA = "0x188854610")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8851110", Offset = "0x8850110", VA = "0x188851110")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8851280", Offset = "0x8850280", VA = "0x188851280")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x88511D0", Offset = "0x88501D0", VA = "0x1888511D0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8852930", Offset = "0x8851930", VA = "0x188852930")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x88526D0", Offset = "0x88516D0", VA = "0x1888526D0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8851A80", Offset = "0x8850A80", VA = "0x188851A80")]
		public static void OnPlayerJoinedRoom(XLYBIIWOHJI newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x88513F0", Offset = "0x88503F0", VA = "0x1888513F0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8851450", Offset = "0x8850450", VA = "0x188851450")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8854740", Offset = "0x8853740", VA = "0x188854740")]
		private void VGQLYTQCPDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8850E20", Offset = "0x884FE20", VA = "0x188850E20")]
		public bool CreatedBy(XLYBIIWOHJI player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8854420", Offset = "0x8853420", VA = "0x188854420")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x88543C0", Offset = "0x88533C0", VA = "0x1888543C0")]
		public void TransferOwnership(XLYBIIWOHJI newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8851510", Offset = "0x8850510", VA = "0x188851510", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x88514B0", Offset = "0x88504B0", VA = "0x1888514B0")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8850990", Offset = "0x884F990", VA = "0x188850990")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8851F80", Offset = "0x8850F80", VA = "0x188851F80")]
		private void RNCXCPNYPOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2197CF0", Offset = "0x2196CF0", VA = "0x182197CF0")]
		internal void BRAVUBTTAGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8850EA0", Offset = "0x884FEA0", VA = "0x188850EA0", Slot = "6")]
		private void DCDGSFZFRLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x88546D0", Offset = "0x88536D0", VA = "0x1888546D0")]
		internal bool UGCDGJJDKGV(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8851940", Offset = "0x8850940", VA = "0x188851940")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x88510B0", Offset = "0x88500B0", VA = "0x1888510B0")]
		internal void EQKRCSAPKAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8854980", Offset = "0x8853980", VA = "0x188854980")]
		private void XPODRFCQKNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8850A50", Offset = "0x884FA50", VA = "0x188850A50")]
		internal void CCBRZNFJXDN(XLYBIIWOHJI a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8852890", Offset = "0x8851890", VA = "0x188852890")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x88529E0", Offset = "0x88519E0", VA = "0x1888529E0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8850B10", Offset = "0x884FB10", VA = "0x188850B10")]
		private void CRTVNLIRBTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8851E90", Offset = "0x8850E90", VA = "0x188851E90")]
		private void RIKLENMXOXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8852350", Offset = "0x8851350", VA = "0x188852350")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x88522C0", Offset = "0x88512C0", VA = "0x1888522C0")]
		public void RPC(string methodName, XLYBIIWOHJI targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x88528E0", Offset = "0x88518E0", VA = "0x1888528E0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x88509E0", Offset = "0x884F9E0", VA = "0x1888509E0", Slot = "8")]
		public void Bake(KTZYOSJORDK context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x88542A0", Offset = "0x88532A0", VA = "0x1888542A0")]
		private static void SRWQEKTONBA(XLYBIIWOHJI a, [Out] XLYBIIWOHJI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x88523E0", Offset = "0x88513E0", VA = "0x1888523E0")]
		private static void RRDCOYZRZUJ(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8851DF0", Offset = "0x8850DF0", VA = "0x188851DF0")]
		private static RPCInfo PVJFKQIZKGY(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8851810", Offset = "0x8850810", VA = "0x188851810")]
		private static void JVBVJRPNKAO(RRNetworkView a, Delegate b, XLYBIIWOHJI c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8851730", Offset = "0x8850730", VA = "0x188851730")]
		private static void JVBVJRPNKAO(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8850F00", Offset = "0x884FF00", VA = "0x188850F00")]
		private static void DODGEIWHTYF(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x88521F0", Offset = "0x88511F0", VA = "0x1888521F0")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8851010", Offset = "0x8850010", VA = "0x188851010")]
		private static bool ELNXHREYNLQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x88530C0", Offset = "0x88520C0", VA = "0x1888530C0", Slot = "25")]
		public void RpcAll(KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF490", Offset = "0x3CBE490", VA = "0x183CBF490", Slot = "9")]
		public void RpcAll<T1>(KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3CBED70", Offset = "0x3CBDD70", VA = "0x183CBED70", Slot = "10")]
		public void RpcAll<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFAF0", Offset = "0x3CBEAF0", VA = "0x183CBFAF0", Slot = "26")]
		public void RpcAll<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3CBEF60", Offset = "0x3CBDF60", VA = "0x183CBEF60", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5790", Offset = "0x3CD4790", VA = "0x183CD5790", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6D40", Offset = "0x3CD5D40", VA = "0x183CD6D40", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3CD52D0", Offset = "0x3CD42D0", VA = "0x183CD52D0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7C90", Offset = "0x3CE6C90", VA = "0x183CE7C90", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3CD7170", Offset = "0x3CD6170", VA = "0x183CD7170", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3CD6370", Offset = "0x3CD5370", VA = "0x183CD6370", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6F10", Offset = "0x3CE5F10", VA = "0x183CE6F10", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3CDCAC0", Offset = "0x3CDBAC0", VA = "0x183CDCAC0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3CDACD0", Offset = "0x3CD9CD0", VA = "0x183CDACD0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD5B90", Offset = "0x3CD4B90", VA = "0x183CD5B90", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8852E90", Offset = "0x8851E90", VA = "0x188852E90", Slot = "35")]
		public void RpcAll(KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2810", Offset = "0x3CC1810", VA = "0x183CC2810", Slot = "36")]
		public void RpcAll<T1>(KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2330", Offset = "0x3CC1330", VA = "0x183CC2330", Slot = "37")]
		public void RpcAll<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF810", Offset = "0x3CBE810", VA = "0x183CBF810", Slot = "38")]
		public void RpcAll<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6400", Offset = "0x3CE5400", VA = "0x183CE6400", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3CE5D40", Offset = "0x3CE4D40", VA = "0x183CE5D40", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3CE4EF0", Offset = "0x3CE3EF0", VA = "0x183CE4EF0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3CE35B0", Offset = "0x3CE25B0", VA = "0x183CE35B0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3CE2B90", Offset = "0x3CE1B90", VA = "0x183CE2B90", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3CE16A0", Offset = "0x3CE06A0", VA = "0x183CE16A0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3CDF370", Offset = "0x3CDE370", VA = "0x183CDF370", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3CDE600", Offset = "0x3CDD600", VA = "0x183CDE600", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3CDBC30", Offset = "0x3CDAC30", VA = "0x183CDBC30", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD9D10", Offset = "0x3CD8D10", VA = "0x183CD9D10", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3CD8C20", Offset = "0x3CD7C20", VA = "0x183CD8C20", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8852C30", Offset = "0x8851C30", VA = "0x188852C30", Slot = "50")]
		public void RpcAllViaServer(KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4E00", Offset = "0x3CD3E00", VA = "0x183CD4E00", Slot = "51")]
		public void RpcAllViaServer<T1>(KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4F90", Offset = "0x3CD3F90", VA = "0x183CD4F90", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4890", Offset = "0x3CD3890", VA = "0x183CD4890", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3CD44A0", Offset = "0x3CD34A0", VA = "0x183CD44A0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3FF0", Offset = "0x3CD2FF0", VA = "0x183CD3FF0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3A80", Offset = "0x3CD2A80", VA = "0x183CD3A80", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3450", Offset = "0x3CD2450", VA = "0x183CD3450", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2D50", Offset = "0x3CD1D50", VA = "0x183CD2D50", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2590", Offset = "0x3CD1590", VA = "0x183CD2590", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1D10", Offset = "0x3CD0D10", VA = "0x183CD1D10", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3CD13D0", Offset = "0x3CD03D0", VA = "0x183CD13D0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3CD09C0", Offset = "0x3CCF9C0", VA = "0x183CD09C0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFEE0", Offset = "0x3CCEEE0", VA = "0x183CCFEE0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF330", Offset = "0x3CCE330", VA = "0x183CCF330", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8852D60", Offset = "0x8851D60", VA = "0x188852D60", Slot = "64")]
		public void RpcAllViaServer(KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4E00", Offset = "0x3CD3E00", VA = "0x183CD4E00", Slot = "65")]
		public void RpcAllViaServer<T1>(KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4BB0", Offset = "0x3CD3BB0", VA = "0x183CD4BB0", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD4890", Offset = "0x3CD3890", VA = "0x183CD4890", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3CD44A0", Offset = "0x3CD34A0", VA = "0x183CD44A0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3FF0", Offset = "0x3CD2FF0", VA = "0x183CD3FF0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3A80", Offset = "0x3CD2A80", VA = "0x183CD3A80", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3450", Offset = "0x3CD2450", VA = "0x183CD3450", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2D50", Offset = "0x3CD1D50", VA = "0x183CD2D50", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2590", Offset = "0x3CD1590", VA = "0x183CD2590", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3CD1D10", Offset = "0x3CD0D10", VA = "0x183CD1D10", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3CD13D0", Offset = "0x3CD03D0", VA = "0x183CD13D0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3CD09C0", Offset = "0x3CCF9C0", VA = "0x183CD09C0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3CCFEE0", Offset = "0x3CCEEE0", VA = "0x183CCFEE0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF330", Offset = "0x3CCE330", VA = "0x183CCF330", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8853B50", Offset = "0x8852B50", VA = "0x188853B50", Slot = "79")]
		public void RpcOthers(KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B660", Offset = "0x3D1A660", VA = "0x183D1B660", Slot = "15")]
		public void RpcOthers<T1>(KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3D27D90", Offset = "0x3D26D90", VA = "0x183D27D90", Slot = "80")]
		public void RpcOthers<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3D21820", Offset = "0x3D20820", VA = "0x183D21820", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2AB30", Offset = "0x3D29B30", VA = "0x183D2AB30", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3D268B0", Offset = "0x3D258B0", VA = "0x183D268B0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D28B30", Offset = "0x3D27B30", VA = "0x183D28B30", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D25CB0", Offset = "0x3D24CB0", VA = "0x183D25CB0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D297A0", Offset = "0x3D287A0", VA = "0x183D297A0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D24DA0", Offset = "0x3D23DA0", VA = "0x183D24DA0", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D292A0", Offset = "0x3D282A0", VA = "0x183D292A0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D23B80", Offset = "0x3D22B80", VA = "0x183D23B80", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D23150", Offset = "0x3D22150", VA = "0x183D23150", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D22650", Offset = "0x3D21650", VA = "0x183D22650", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D21A70", Offset = "0x3D20A70", VA = "0x183D21A70", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8853CA0", Offset = "0x8852CA0", VA = "0x188853CA0", Slot = "92")]
		public void RpcOthers(KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D1B7B0", Offset = "0x3D1A7B0", VA = "0x183D1B7B0", Slot = "93")]
		public void RpcOthers<T1>(KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3D27BD0", Offset = "0x3D26BD0", VA = "0x183D27BD0", Slot = "94")]
		public void RpcOthers<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3D27190", Offset = "0x3D26190", VA = "0x183D27190", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3D27920", Offset = "0x3D26920", VA = "0x183D27920", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3D282A0", Offset = "0x3D272A0", VA = "0x183D282A0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D285B0", Offset = "0x3D275B0", VA = "0x183D285B0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D25CB0", Offset = "0x3D24CB0", VA = "0x183D25CB0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3D25590", Offset = "0x3D24590", VA = "0x183D25590", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3D24DA0", Offset = "0x3D23DA0", VA = "0x183D24DA0", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3D244F0", Offset = "0x3D234F0", VA = "0x183D244F0", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3D23B80", Offset = "0x3D22B80", VA = "0x183D23B80", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3D23150", Offset = "0x3D22150", VA = "0x183D23150", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3D22650", Offset = "0x3D21650", VA = "0x183D22650", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3D21A70", Offset = "0x3D20A70", VA = "0x183D21A70", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8853880", Offset = "0x8852880", VA = "0x188853880", Slot = "107")]
		public void RpcMaster(KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3D024E0", Offset = "0x3D014E0", VA = "0x183D024E0", Slot = "108")]
		public void RpcMaster<T1>(KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3D02860", Offset = "0x3D01860", VA = "0x183D02860", Slot = "109")]
		public void RpcMaster<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D01CD0", Offset = "0x3D00CD0", VA = "0x183D01CD0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3D01F30", Offset = "0x3D00F30", VA = "0x183D01F30", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3D16130", Offset = "0x3D15130", VA = "0x183D16130", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D18190", Offset = "0x3D17190", VA = "0x183D18190", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D0E5B0", Offset = "0x3D0D5B0", VA = "0x183D0E5B0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0D1B0", Offset = "0x3D0C1B0", VA = "0x183D0D1B0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C6D0", Offset = "0x3D0B6D0", VA = "0x183D0C6D0", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3D15970", Offset = "0x3D14970", VA = "0x183D15970", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3D14B80", Offset = "0x3D13B80", VA = "0x183D14B80", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3D06B60", Offset = "0x3D05B60", VA = "0x183D06B60", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3D05BF0", Offset = "0x3D04BF0", VA = "0x183D05BF0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D02A80", Offset = "0x3D01A80", VA = "0x183D02A80", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8853640", Offset = "0x8852640", VA = "0x188853640", Slot = "122")]
		public void RpcMaster(KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3D02680", Offset = "0x3D01680", VA = "0x183D02680", Slot = "123")]
		public void RpcMaster<T1>(KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3D13C90", Offset = "0x3D12C90", VA = "0x183D13C90", Slot = "124")]
		public void RpcMaster<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D134E0", Offset = "0x3D124E0", VA = "0x183D134E0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D11A10", Offset = "0x3D10A10", VA = "0x183D11A10", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3D16900", Offset = "0x3D15900", VA = "0x183D16900", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FF30", Offset = "0x3D0EF30", VA = "0x183D0FF30", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D0EE70", Offset = "0x3D0DE70", VA = "0x183D0EE70", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D0DB80", Offset = "0x3D0CB80", VA = "0x183D0DB80", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0BB80", Offset = "0x3D0AB80", VA = "0x183D0BB80", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3D0AF20", Offset = "0x3D09F20", VA = "0x183D0AF20", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3D09590", Offset = "0x3D08590", VA = "0x183D09590", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3D079B0", Offset = "0x3D069B0", VA = "0x183D079B0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3D04C20", Offset = "0x3D03C20", VA = "0x183D04C20", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D03B20", Offset = "0x3D02B20", VA = "0x183D03B20", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8853230", Offset = "0x8852230", VA = "0x188853230", Slot = "137")]
		public void RpcAuthority(KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBE50", Offset = "0x3CEAE50", VA = "0x183CEBE50", Slot = "138")]
		public void RpcAuthority<T1>(KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE4B0", Offset = "0x3CFD4B0", VA = "0x183CFE4B0", Slot = "139")]
		public void RpcAuthority<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CFEC20", Offset = "0x3CFDC20", VA = "0x183CFEC20", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CFE1B0", Offset = "0x3CFD1B0", VA = "0x183CFE1B0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CEBAB0", Offset = "0x3CEAAB0", VA = "0x183CEBAB0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9040", Offset = "0x3CF8040", VA = "0x183CF9040", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7E00", Offset = "0x3CF6E00", VA = "0x183CF7E00", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF7400", Offset = "0x3CF6400", VA = "0x183CF7400", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5E80", Offset = "0x3CF4E80", VA = "0x183CF5E80", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3A20", Offset = "0x3CF2A20", VA = "0x183CF3A20", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3CFFAD0", Offset = "0x3CFEAD0", VA = "0x183CFFAD0", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCF20", Offset = "0x3CFBF20", VA = "0x183CFCF20", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3CEF210", Offset = "0x3CEE210", VA = "0x183CEF210", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3CEC000", Offset = "0x3CEB000", VA = "0x183CEC000", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x88533E0", Offset = "0x88523E0", VA = "0x1888533E0", Slot = "152")]
		public void RpcAuthority(KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCA10", Offset = "0x3CFBA10", VA = "0x183CFCA10", Slot = "153")]
		public void RpcAuthority<T1>(KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3CFC630", Offset = "0x3CFB630", VA = "0x183CFC630", Slot = "154")]
		public void RpcAuthority<T1, T2>(KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB970", Offset = "0x3CFA970", VA = "0x183CFB970", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB380", Offset = "0x3CFA380", VA = "0x183CFB380", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA030", Offset = "0x3CF9030", VA = "0x183CFA030", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF9810", Offset = "0x3CF8810", VA = "0x183CF9810", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3CF8700", Offset = "0x3CF7700", VA = "0x183CF8700", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3CF69A0", Offset = "0x3CF59A0", VA = "0x183CF69A0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5300", Offset = "0x3CF4300", VA = "0x183CF5300", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF4660", Offset = "0x3CF3660", VA = "0x183CF4660", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3CF2C70", Offset = "0x3CF1C70", VA = "0x183CF2C70", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3CF01B0", Offset = "0x3CEF1B0", VA = "0x183CF01B0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3CEE200", Offset = "0x3CED200", VA = "0x183CEE200", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3CED0D0", Offset = "0x3CEC0D0", VA = "0x183CED0D0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8853DF0", Offset = "0x8852DF0", VA = "0x188853DF0", Slot = "17")]
		public void RpcPlayer(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B090", Offset = "0x3D2A090", VA = "0x183D2B090", Slot = "18")]
		public void RpcPlayer<T1>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BD30", Offset = "0x3D2AD30", VA = "0x183D2BD30", Slot = "19")]
		public void RpcPlayer<T1, T2>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B7B0", Offset = "0x3D2A7B0", VA = "0x183D2B7B0", Slot = "20")]
		public void RpcPlayer<T1, T2, T3>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B250", Offset = "0x3D2A250", VA = "0x183D2B250", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D40240", Offset = "0x3D3F240", VA = "0x183D40240", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D3FE30", Offset = "0x3D3EE30", VA = "0x183D3FE30", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D405D0", Offset = "0x3D3F5D0", VA = "0x183D405D0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D40A40", Offset = "0x3D3FA40", VA = "0x183D40A40", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D376A0", Offset = "0x3D366A0", VA = "0x183D376A0", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D35DC0", Offset = "0x3D34DC0", VA = "0x183D35DC0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C580", Offset = "0x3D2B580", VA = "0x183D2C580", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3D33410", Offset = "0x3D32410", VA = "0x183D33410", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3D454A0", Offset = "0x3D444A0", VA = "0x183D454A0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F470", Offset = "0x3D2E470", VA = "0x183D2F470", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8853FE0", Offset = "0x8852FE0", VA = "0x188853FE0", Slot = "176")]
		public void RpcPlayer(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3D2B5A0", Offset = "0x3D2A5A0", VA = "0x183D2B5A0", Slot = "177")]
		public void RpcPlayer<T1>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3D2C2C0", Offset = "0x3D2B2C0", VA = "0x183D2C2C0", Slot = "23")]
		public void RpcPlayer<T1, T2>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3D2BF80", Offset = "0x3D2AF80", VA = "0x183D2BF80", Slot = "24")]
		public void RpcPlayer<T1, T2, T3>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3D2DB90", Offset = "0x3D2CB90", VA = "0x183D2DB90", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3D3C3D0", Offset = "0x3D3B3D0", VA = "0x183D3C3D0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3D3BBA0", Offset = "0x3D3ABA0", VA = "0x183D3BBA0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3D3A1A0", Offset = "0x3D391A0", VA = "0x183D3A1A0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3D38D40", Offset = "0x3D37D40", VA = "0x183D38D40", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3D381C0", Offset = "0x3D371C0", VA = "0x183D381C0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3D36A00", Offset = "0x3D35A00", VA = "0x183D36A00", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3D35000", Offset = "0x3D34000", VA = "0x183D35000", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3D32520", Offset = "0x3D31520", VA = "0x183D32520", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3D30550", Offset = "0x3D2F550", VA = "0x183D30550", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3D2E320", Offset = "0x3D2D320", VA = "0x183D2E320", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(XLYBIIWOHJI player, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8852B90", Offset = "0x8851B90", VA = "0x188852B90", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF190", Offset = "0x3CCE190", VA = "0x183CCF190", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEF40", Offset = "0x3CCDF40", VA = "0x183CCEF40", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC20", Offset = "0x3CCDC20", VA = "0x183CCEC20", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE840", Offset = "0x3CCD840", VA = "0x183CCE840", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE390", Offset = "0x3CCD390", VA = "0x183CCE390", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDE10", Offset = "0x3CCCE10", VA = "0x183CCDE10", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD7E0", Offset = "0x3CCC7E0", VA = "0x183CCD7E0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD0E0", Offset = "0x3CCC0E0", VA = "0x183CCD0E0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC920", Offset = "0x3CCB920", VA = "0x183CCC920", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC090", Offset = "0x3CCB090", VA = "0x183CCC090", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB740", Offset = "0x3CCA740", VA = "0x183CCB740", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAD30", Offset = "0x3CC9D30", VA = "0x183CCAD30", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA250", Offset = "0x3CC9250", VA = "0x183CCA250", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3CC96A0", Offset = "0x3CC86A0", VA = "0x183CC96A0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x8852AF0", Offset = "0x8851AF0", VA = "0x188852AF0", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF190", Offset = "0x3CCE190", VA = "0x183CCF190", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEF40", Offset = "0x3CCDF40", VA = "0x183CCEF40", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3CCEC20", Offset = "0x3CCDC20", VA = "0x183CCEC20", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE840", Offset = "0x3CCD840", VA = "0x183CCE840", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE390", Offset = "0x3CCD390", VA = "0x183CCE390", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3CCDE10", Offset = "0x3CCCE10", VA = "0x183CCDE10", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD7E0", Offset = "0x3CCC7E0", VA = "0x183CCD7E0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD0E0", Offset = "0x3CCC0E0", VA = "0x183CCD0E0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC920", Offset = "0x3CCB920", VA = "0x183CCC920", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3CCC090", Offset = "0x3CCB090", VA = "0x183CCC090", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3CCB740", Offset = "0x3CCA740", VA = "0x183CCB740", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3CCAD30", Offset = "0x3CC9D30", VA = "0x183CCAD30", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA250", Offset = "0x3CC9250", VA = "0x183CCA250", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC96A0", Offset = "0x3CC86A0", VA = "0x183CC96A0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8853AB0", Offset = "0x8852AB0", VA = "0x188853AB0", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3D21680", Offset = "0x3D20680", VA = "0x183D21680", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3D21430", Offset = "0x3D20430", VA = "0x183D21430", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3D21110", Offset = "0x3D20110", VA = "0x183D21110", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3D20D20", Offset = "0x3D1FD20", VA = "0x183D20D20", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3D20870", Offset = "0x3D1F870", VA = "0x183D20870", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3D202F0", Offset = "0x3D1F2F0", VA = "0x183D202F0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FCC0", Offset = "0x3D1ECC0", VA = "0x183D1FCC0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F5C0", Offset = "0x3D1E5C0", VA = "0x183D1F5C0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EE00", Offset = "0x3D1DE00", VA = "0x183D1EE00", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E570", Offset = "0x3D1D570", VA = "0x183D1E570", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DC20", Offset = "0x3D1CC20", VA = "0x183D1DC20", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D210", Offset = "0x3D1C210", VA = "0x183D1D210", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C730", Offset = "0x3D1B730", VA = "0x183D1C730", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BB80", Offset = "0x3D1AB80", VA = "0x183D1BB80", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8853A10", Offset = "0x8852A10", VA = "0x188853A10", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3D21680", Offset = "0x3D20680", VA = "0x183D21680", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3D21430", Offset = "0x3D20430", VA = "0x183D21430", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3D21110", Offset = "0x3D20110", VA = "0x183D21110", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3D20D20", Offset = "0x3D1FD20", VA = "0x183D20D20", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3D20870", Offset = "0x3D1F870", VA = "0x183D20870", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3D202F0", Offset = "0x3D1F2F0", VA = "0x183D202F0", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3D1FCC0", Offset = "0x3D1ECC0", VA = "0x183D1FCC0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3D1F5C0", Offset = "0x3D1E5C0", VA = "0x183D1F5C0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3D1EE00", Offset = "0x3D1DE00", VA = "0x183D1EE00", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3D1E570", Offset = "0x3D1D570", VA = "0x183D1E570", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3D1DC20", Offset = "0x3D1CC20", VA = "0x183D1DC20", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3D1D210", Offset = "0x3D1C210", VA = "0x183D1D210", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3D1C730", Offset = "0x3D1B730", VA = "0x183D1C730", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3D1BB80", Offset = "0x3D1AB80", VA = "0x183D1BB80", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KXSQQNXQLKT.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8850BB0", Offset = "0x884FBB0", VA = "0x188850BB0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8850DC0", Offset = "0x884FDC0", VA = "0x188850DC0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x21CC2D0", Offset = "0x21CB2D0", VA = "0x1821CC2D0")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class DPAMCIIJSFE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x8840930", Offset = "0x883F930", VA = "0x188840930")]
		private static bool IBSRBHWTDJP(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x382FE90", Offset = "0x382EE90", VA = "0x18382FE90")]
		[CanBeNull]
		public static a VPDQBPKWSOF<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class JGCNFZDSCXF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public XLYBIIWOHJI[] CUAKRQITUJC;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public JGCNFZDSCXF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x88449E0", Offset = "0x88439E0", VA = "0x1888449E0")]
			internal int GCJCCXEQDDM(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8844A60", Offset = "0x8843A60", VA = "0x188844A60")]
			internal void GCOJADYNMOV(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static XLYBIIWOHJI[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int SMGVPKDNQWV;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x8855360", Offset = "0x8854360", VA = "0x188855360")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8855870", Offset = "0x8854870", VA = "0x188855870")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8855C10", Offset = "0x8854C10", VA = "0x188855C10")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x8855C90", Offset = "0x8854C90", VA = "0x188855C90")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8855860", Offset = "0x8854860", VA = "0x188855860")]
		private void JWWKMDUXIGX(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8855860", Offset = "0x8854860", VA = "0x188855860")]
		private void HEMKXGJKMDZ(XLYBIIWOHJI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x8855D40", Offset = "0x8854D40", VA = "0x188855D40")]
		private void PRNGOUKFNUF(XLYBIIWOHJI a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8855210", Offset = "0x8854210", VA = "0x188855210")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8855E30", Offset = "0x8854E30", VA = "0x188855E30")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8855770", Offset = "0x8854770", VA = "0x188855770")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xADF380", Offset = "0xADE380", VA = "0x180ADF380")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class SKNYPGEZHFP
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8856900", Offset = "0x8855900", VA = "0x188856900")]
		public static int YXAXQIAKDYD(this XLYBIIWOHJI a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8856540", Offset = "0x8855540", VA = "0x188856540")]
		public static void SPFHMXZGHFV(this XLYBIIWOHJI a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class XKLSIHBWBZT
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void RoomPropertyUpdateCallback(Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate void PlayerPropertyUpdateCallback(XLYBIIWOHJI player, Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback KMOKKWBWBOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x88604C0", Offset = "0x885F4C0", VA = "0x1888604C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x88601C0", Offset = "0x885F1C0", VA = "0x1888601C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback HXDEUDFYXEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x8860100", Offset = "0x885F100", VA = "0x188860100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x8860340", Offset = "0x885F340", VA = "0x188860340")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback SGLAKQVYSXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x8860280", Offset = "0x885F280", VA = "0x188860280")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x8860640", Offset = "0x885F640", VA = "0x188860640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback GNVJACNRIDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x8860580", Offset = "0x885F580", VA = "0x188860580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x8860400", Offset = "0x885F400", VA = "0x188860400")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class CRJIXIBPHNI
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int OGRRLEGMSRC;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int GVBDCFEGQKG;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int MZNSTLXVGMS;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x88408E0", Offset = "0x883F8E0", VA = "0x1888408E0")]
		public static void WYKUTLFDFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8840800", Offset = "0x883F800", VA = "0x188840800")]
		public static void KXXOCWPIVQZ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8840570", Offset = "0x883F570", VA = "0x188840570")]
		public static int AEGJUCREHEW(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RegisterService(typeof(HOXKUYGAGGO), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class HOXKUYGAGGO : PJBIDVXKPOK, UZCAYKEWQQA, AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Dictionary<object, object> PLPVVQUHUKX;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly Dictionary<object, object> STTFJWKOHZN;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly Dictionary<object, object> OVBCUXRPMGX;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly GWGBIKXISIV PCKOHQLNZRH;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly GWGBIKXISIV WFDUVYOXEII;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly GWGBIKXISIV VVNEZXMKRKY;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly GWGBIKXISIV IRRRELTTSWB;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly GWGBIKXISIV YPWOSKCEKEI;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static int GMIPBRSWOBT;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8842E50", Offset = "0x8841E50", VA = "0x188842E50", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8842420", Offset = "0x8841420", VA = "0x188842420", Slot = "19")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x8843D00", Offset = "0x8842D00", VA = "0x188843D00", Slot = "4")]
		public bool TJDDDSOSVOR(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8841D90", Offset = "0x8840D90", VA = "0x188841D90", Slot = "5")]
		public int BJUSIEWZZPP(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8843070", Offset = "0x8842070", VA = "0x188843070", Slot = "6")]
		public bool MWZZQRPIJYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8843B40", Offset = "0x8842B40", VA = "0x188843B40", Slot = "7")]
		public bool THECKJHUYFH(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8844470", Offset = "0x8843470", VA = "0x188844470", Slot = "8")]
		public void WEGKKNYWPPG(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x88424C0", Offset = "0x88414C0", VA = "0x1888424C0", Slot = "9")]
		public bool IVKXCUIWMSY(IRRSNCQWIPE a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x88432C0", Offset = "0x88422C0", VA = "0x1888432C0", Slot = "10")]
		public bool OTMSRICAVSJ(IRRSNCQWIPE a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x88435F0", Offset = "0x88425F0", VA = "0x1888435F0", Slot = "11")]
		public bool OWMISOPELAG(IRRSNCQWIPE a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x88438F0", Offset = "0x88428F0", VA = "0x1888438F0", Slot = "12")]
		public void RSJWRSTSQIW(IRRSNCQWIPE a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x8843730", Offset = "0x8842730", VA = "0x188843730", Slot = "13")]
		public void RBNNPKUWNEF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x88421A0", Offset = "0x88411A0", VA = "0x1888421A0", Slot = "14")]
		public void EGLUPSPWLKB(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8843E40", Offset = "0x8842E40", VA = "0x188843E40", Slot = "15")]
		public void UFLXRMYYQST(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x8842310", Offset = "0x8841310", VA = "0x188842310", Slot = "16")]
		public void EMMWBBZTNIS(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x8843100", Offset = "0x8842100", VA = "0x188843100", Slot = "17")]
		public void NRLTCXJPEAU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8843F20", Offset = "0x8842F20", VA = "0x188843F20")]
		private static void UTLVBADFPON(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8842630", Offset = "0x8841630", VA = "0x188842630")]
		private static bool IVKXCUIWMSY(Dictionary<object, object> a, XLYBIIWOHJI b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8842EF0", Offset = "0x8841EF0", VA = "0x188842EF0")]
		private static bool KOACWVSXMAT(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8842F90", Offset = "0x8841F90", VA = "0x188842F90")]
		private static int LRUBXSZEVDN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public HOXKUYGAGGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RegisterService(typeof(JWCWEQNIXUE), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class JWCWEQNIXUE : JWONSZVODXG, UZCAYKEWQQA, AXORFOQTGRK
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static Hashtable PAVWLSZJZGY;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static Hashtable MOIKJFUQBUP;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static GWGBIKXISIV LHNDBUHEIXI;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly GWGBIKXISIV XYVYNYGJABR;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8844AF0", Offset = "0x8843AF0", VA = "0x188844AF0", Slot = "8")]
		public void EQRPTIUGSAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8844B90", Offset = "0x8843B90", VA = "0x188844B90", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8844F60", Offset = "0x8843F60", VA = "0x188844F60", Slot = "4")]
		public void NXQVMWYMAVG(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8844C30", Offset = "0x8843C30", VA = "0x188844C30", Slot = "5")]
		public bool JRIYLDPVPJG(IRRSNCQWIPE a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8845040", Offset = "0x8844040", VA = "0x188845040", Slot = "6")]
		public void NZEUSVKBJZE(ViewId a, string b, RpcTarget c, XLYBIIWOHJI d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public JWCWEQNIXUE()
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
