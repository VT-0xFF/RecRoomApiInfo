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
		[Cpp2IlInjected.Address(RVA = "0x82ED660", Offset = "0x82EC260", VA = "0x1882ED660", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		private int[] RXQWJMLBFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] RXLPMFRDWGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset DXAPYCEYZZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset DXFWVIYWJLH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1EE26B0", Offset = "0x1EE12B0", VA = "0x181EE26B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82FC0B0", Offset = "0x82FACB0", VA = "0x1882FC0B0")]
		private void JGBTHBSKOEG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82FC5C0", Offset = "0x82FB1C0", VA = "0x1882FC5C0")]
		private void JGHAEIMHXPP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82FC820", Offset = "0x82FB420", VA = "0x1882FC820", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82FC8D0", Offset = "0x82FB4D0", VA = "0x1882FC8D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class QZNRRANYWWQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log ILAMAUQBTHE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log XGDXVYQDZWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x82EE130", Offset = "0x82ECD30", VA = "0x1882EE130")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface QTQSTUDYUDI
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView ZZEZRYREMMH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType MADFPDLMDRS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PTSJVVHEMJT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "2")]
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
	internal interface XAFWFAPKYAS
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool XMWLDWAPQFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NIUTGHDYVQH(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface IPNUHFNJAFT : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OGBNJYRINGK(QTQSTUDYUDI a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WOWKLYECNPX(QTQSTUDYUDI a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(XHIYXPYTTUC.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void WDOGKXUTALG();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GGOHFFTDTFB(object a);
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
	public class LICYJKBXKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), XAFWFAPKYAS> MKVSQCMGMFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<QTQSTUDYUDI> VYFGAEKOHDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> KTJENWQDUSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int RFDGLHJQEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool LJNRMERKKYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private XHIYXPYTTUC.ApplyNetworkTransform SBJKQITLQNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream ULIFWINNTXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker ERKHHPKYGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker SROCUFYMBGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] QALYBIWLZRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float BJEDTPCZSNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int PDNKFOHSQTA;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82ED470", Offset = "0x82EC070", VA = "0x1882ED470")]
		public LICYJKBXKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82ECEA0", Offset = "0x82EBAA0", VA = "0x1882ECEA0")]
		public void Pause(XHIYXPYTTUC.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82ED3C0", Offset = "0x82EBFC0", VA = "0x1882ED3C0")]
		public void WDOGKXUTALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82ECFF0", Offset = "0x82EBBF0", VA = "0x1882ECFF0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82EBF50", Offset = "0x82EAB50", VA = "0x1882EBF50")]
		public bool Add(QTQSTUDYUDI networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82ECEC0", Offset = "0x82EBAC0", VA = "0x1882ECEC0")]
		public bool Remove(QTQSTUDYUDI networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82EC8E0", Offset = "0x82EB4E0", VA = "0x1882EC8E0")]
		private XAFWFAPKYAS JDUNCABKFTX(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82EC4C0", Offset = "0x82EB0C0", VA = "0x1882EC4C0")]
		public void BLWFUQFWQBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82ED410", Offset = "0x82EC010", VA = "0x1882ED410")]
		private void YILUUSHGKJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82EC8C0", Offset = "0x82EB4C0", VA = "0x1882EC8C0")]
		private void GFOEUKZITPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82ECAF0", Offset = "0x82EB6F0", VA = "0x1882ECAF0")]
		public bool KXDJATNQIJZ(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82EC4D0", Offset = "0x82EB0D0", VA = "0x1882EC4D0")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class PHJUBKJPYOP : XAFWFAPKYAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private QTQSTUDYUDI EVDMFLIKKDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint JFFPHZVQTLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int KTASZGUPSHB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool XMWLDWAPQFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public PHJUBKJPYOP(QTQSTUDYUDI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82EDC30", Offset = "0x82EC830", VA = "0x1882EDC30", Slot = "5")]
		public bool NIUTGHDYVQH(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82EDB50", Offset = "0x82EC750", VA = "0x1882EDB50", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NOVWFCDPKXW : XAFWFAPKYAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private XHIYXPYTTUC.ApplyNetworkTransform SBJKQITLQNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId TSIKJXLEEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int KTASZGUPSHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint JFFPHZVQTLE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool XMWLDWAPQFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19E2F30", Offset = "0x19E1B30", VA = "0x1819E2F30")]
		public NOVWFCDPKXW(ViewId a, XHIYXPYTTUC.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82EDA50", Offset = "0x82EC650", VA = "0x1882EDA50", Slot = "5")]
		public bool NIUTGHDYVQH(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82ED870", Offset = "0x82EC470", VA = "0x1882ED870", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class JPBSORNLPCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82EAAA0", Offset = "0x82E96A0", VA = "0x1882EAAA0")]
		public static void DKWNNTIDYNZ(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82EB190", Offset = "0x82E9D90", VA = "0x1882EB190")]
		public static void TLJARXSPEJQ(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82EAC60", Offset = "0x82E9860", VA = "0x1882EAC60")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82EADD0", Offset = "0x82E99D0", VA = "0x1882EADD0")]
		public static void IGHVINLYZUH(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(IPNUHFNJAFT), new string[] { })]
	public class UMUYEEGLBIU : IPNUHFNJAFT, INetworkUpdateSystem, WKGSNWVFZRQ, HJESUUHTFVQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log MYUGDNOSYUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LICYJKBXKPK ZRPEOPWPLZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint XUKGTUXWTIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float BFQGOQUZJTW;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82FB2E0", Offset = "0x82F9EE0", VA = "0x1882FB2E0", Slot = "4")]
		public void OGBNJYRINGK(QTQSTUDYUDI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82FBBD0", Offset = "0x82FA7D0", VA = "0x1882FBBD0", Slot = "5")]
		public void WOWKLYECNPX(QTQSTUDYUDI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82FB110", Offset = "0x82F9D10", VA = "0x1882FB110", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82FB260", Offset = "0x82F9E60", VA = "0x1882FB260", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82FB550", Offset = "0x82FA150", VA = "0x1882FB550")]
		private void SILTMRMONOA(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82FB520", Offset = "0x82FA120", VA = "0x1882FB520", Slot = "6")]
		public void Pause(XHIYXPYTTUC.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82FBB70", Offset = "0x82FA770", VA = "0x1882FBB70", Slot = "7")]
		public void WDOGKXUTALG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82FB0B0", Offset = "0x82F9CB0", VA = "0x1882FB0B0", Slot = "8")]
		public void GGOHFFTDTFB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82FAD20", Offset = "0x82F9920", VA = "0x1882FAD20")]
		private void EDMPWAKMPSO(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82FB400", Offset = "0x82FA000", VA = "0x1882FB400", Slot = "11")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82FBDD0", Offset = "0x82FA9D0", VA = "0x1882FBDD0")]
		public UMUYEEGLBIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FVMUWQZVGTI : XAFWFAPKYAS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float WUVOYSNVMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int KTASZGUPSHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint JFFPHZVQTLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType GAXCEDCIEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo AWNZIYMTHCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int UQHYRNVHPBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] QTHVQQKXZBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo WNEZHBDPXMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int WBZSNJORWNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] TBRPGJPHLIY;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool XMWLDWAPQFK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82E6C10", Offset = "0x82E5810", VA = "0x1882E6C10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82E6D80", Offset = "0x82E5980", VA = "0x1882E6D80")]
		public FVMUWQZVGTI(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82E6C40", Offset = "0x82E5840", VA = "0x1882E6C40", Slot = "5")]
		public bool NIUTGHDYVQH(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82E6A60", Offset = "0x82E5660", VA = "0x1882E6A60", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82E6C80", Offset = "0x82E5880", VA = "0x1882E6C80")]
		internal PHJUBKJPYOP SZIBINSAAKG(QTQSTUDYUDI a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82E6890", Offset = "0x82E5490", VA = "0x1882E6890")]
		private static void BTPWXIGVHRK(PHJUBKJPYOP a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class YSZWBAIGTMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82FC020", Offset = "0x82FAC20", VA = "0x1882FC020")]
		public static HNNNRVHBOIU YIWSLJECIQM(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82FBFD0", Offset = "0x82FABD0", VA = "0x1882FBFD0")]
		public static PlayerId ToPlayerId(this HNNNRVHBOIU player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RRNetworkBehavior : MonoBehaviour, DWUKVYICZCY, CCOVUQOLKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool DAVZZAHXPTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RRNetworkView BVYXJMLFFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<ZWRFJLBCOQZ> HGHINZNWILY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool BHLETXJXDUP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId HLPOUEPVBUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x82EEAA0", Offset = "0x82ED6A0", VA = "0x1882EEAA0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId WATNWFASMIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x82EEAA0", Offset = "0x82ED6A0", VA = "0x1882EEAA0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView UIUJWAMVFYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x82EEB20", Offset = "0x82ED720", VA = "0x1882EEB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView ZZEZRYREMMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x82EEB20", Offset = "0x82ED720", VA = "0x1882EEB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public HNNNRVHBOIU TOZITTQODVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82EEC20", Offset = "0x82ED820", VA = "0x1882EEC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public HNNNRVHBOIU GGAKNSHIHOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x82EEF80", Offset = "0x82EDB80", VA = "0x1882EEF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool XUCGARBVGVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x82EED80", Offset = "0x82ED980", VA = "0x1882EED80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool VLNPYCXZIGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x82EEEF0", Offset = "0x82EDAF0", VA = "0x1882EEEF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IEJPQQPSHHU
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x82EE9D0", Offset = "0x82ED5D0", VA = "0x1882EE9D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NOMFAVAMQPY
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x82EECB0", Offset = "0x82ED8B0", VA = "0x1882EECB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool HQIWCPIRRRA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82EE9D0", Offset = "0x82ED5D0", VA = "0x1882EE9D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool AEQGHCUNGOW
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82EEA50", Offset = "0x82ED650", VA = "0x1882EEA50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string EOBMQILZMAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x82EEB90", Offset = "0x82ED790", VA = "0x1882EEB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool YFCQPAGNVFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82EE950", Offset = "0x82ED550", VA = "0x1882EE950", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<HNNNRVHBOIU> FSKVMPQZZCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82EE820", Offset = "0x82ED420", VA = "0x1882EE820")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82EF010", Offset = "0x82EDC10", VA = "0x1882EF010")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82EE780", Offset = "0x82ED380", VA = "0x1882EE780")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82EE340", Offset = "0x82ECF40", VA = "0x1882EE340")]
		private void IQDNYJDXZUU(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82EE380", Offset = "0x82ECF80", VA = "0x1882EE380", Slot = "9")]
		public void RegisterDestroyHandler(ZWRFJLBCOQZ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82EE5C0", Offset = "0x82ED1C0", VA = "0x1882EE5C0", Slot = "10")]
		public void UnregisterDestroyHandler(ZWRFJLBCOQZ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82EE360", Offset = "0x82ECF60", VA = "0x1882EE360", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class TWMPAVHPHTM
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, HNNNRVHBOIU targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, HNNNRVHBOIU targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, HNNNRVHBOIU newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[CompilerGenerated]
		private static InstantiateCallback EHKNQCKNKTM;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback PGVVVWPOYCH
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x82FA490", Offset = "0x82F9090", VA = "0x1882FA490")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x82F9800", Offset = "0x82F8400", VA = "0x1882F9800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback VLPVLGZWQNR
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x82F94B0", Offset = "0x82F80B0", VA = "0x1882F94B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x82F9950", Offset = "0x82F8550", VA = "0x1882F9950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback BIKUIKBESGV
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x82FA040", Offset = "0x82F8C40", VA = "0x1882FA040")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x82F9B60", Offset = "0x82F8760", VA = "0x1882F9B60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback INMGQSFWWBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x82F9EC0", Offset = "0x82F8AC0", VA = "0x1882F9EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x82FA100", Offset = "0x82F8D00", VA = "0x1882FA100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback TGYHNWCEJRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82F93F0", Offset = "0x82F7FF0", VA = "0x1882F93F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x82FA3D0", Offset = "0x82F8FD0", VA = "0x1882FA3D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback BILOVRDDUYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x82F9F80", Offset = "0x82F8B80", VA = "0x1882F9F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82FA1C0", Offset = "0x82F8DC0", VA = "0x1882FA1C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback UYVXTUNJJWJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82F9AA0", Offset = "0x82F86A0", VA = "0x1882F9AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82F9570", Offset = "0x82F8170", VA = "0x1882F9570")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler GVBXSKDLKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x82F9270", Offset = "0x82F7E70", VA = "0x1882F9270")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x82F9330", Offset = "0x82F7F30", VA = "0x1882F9330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler MYQMSZDTZVW
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x82F9E00", Offset = "0x82F8A00", VA = "0x1882F9E00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x82F9D40", Offset = "0x82F8940", VA = "0x1882F9D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x82F9740", Offset = "0x82F8340", VA = "0x1882F9740")]
		public static void FPSNZHGZNXK([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x82F9CB0", Offset = "0x82F88B0", VA = "0x1882F9CB0")]
		public static void JQYXQJZRERQ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x82F9A10", Offset = "0x82F8610", VA = "0x1882F9A10")]
		public static void HXSNDKTDGQJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x82F9C20", Offset = "0x82F8820", VA = "0x1882F9C20")]
		public static void JFUYMBSGTSY(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x82F98C0", Offset = "0x82F84C0", VA = "0x1882F98C0")]
		public static void GCASLZJWNHV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x82FA550", Offset = "0x82F9150", VA = "0x1882FA550")]
		public static void ZNFDHPNYUXZ(RRNetworkView a, string b, HNNNRVHBOIU c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x82FA280", Offset = "0x82F8E80", VA = "0x1882FA280")]
		public static void TRZVZLOYPTE(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x82F9630", Offset = "0x82F8230", VA = "0x1882F9630")]
		public static void DRESRZLREKW(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class JWPVKIPPNVD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x82EB700", Offset = "0x82EA300", VA = "0x1882EB700")]
		[CanBeNull]
		private static bool EITPUOBLDDB(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x82EB7B0", Offset = "0x82EA3B0", VA = "0x1882EB7B0")]
		[CanBeNull]
		public static Component GTJRIDNNQYD(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3726680", Offset = "0x3725280", VA = "0x183726680")]
		[CanBeNull]
		public static a GTJRIDNNQYD<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3726610", Offset = "0x3725210", VA = "0x183726610")]
		[CanBeNull]
		public static b DYZPARYCJMD<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x3726460", Offset = "0x3725060", VA = "0x183726460")]
		public static bool AEEFPTCDXGG<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x82EB690", Offset = "0x82EA290", VA = "0x1882EB690")]
		[CanBeNull]
		public static RRNetworkView AOAMTCYZNRY(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static RRNetworkHandler KIWZHDPKYDG;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler PGFSJHGESKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x82EF1C0", Offset = "0x82EDDC0", VA = "0x1882EF1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x82EF180", Offset = "0x82EDD80", VA = "0x1882EF180")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x82EF140", Offset = "0x82EDD40", VA = "0x1882EF140")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RegisterService(typeof(BTPPAHNGQZV), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class BTPPAHNGQZV : JAINKIUYJFU, WKGSNWVFZRQ, HJESUUHTFVQ, KVDAJIKJIJC, GGXGSUREAZS, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KRFKZYGPKGU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int FSQJPMNOJTX;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KRFKZYGPKGU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x82EBE90", Offset = "0x82EAA90", VA = "0x1882EBE90")]
			internal object UYKPQJYXACG((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static Log VCTGIJOYOJE;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static Log RNIVOKCDNTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private KQLOCOMOQFH AVEFUGDVMKO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static Dictionary<int, HashSet<int>> SGAVQKSSFPW;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static Dictionary<int, int> BMSOIVOBNEB;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly List<(GameObject GameObject, int ParentCount)> MBZLZHTSTRO;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly List<GameObject> KCKZMVUVPVP;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static List<int> DLRLXIGFAOH;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static readonly List<RRNetworkView> VGVGVXDUDTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private QCQQKPQMXYA VYSPRCRHRVR;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly QINZOSCQMJF NPIMFORDYLR;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly QINZOSCQMJF WOFCUGFOICO;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82E0810", Offset = "0x82DF410", VA = "0x1882E0810", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x82E3BC0", Offset = "0x82E27C0", VA = "0x1882E3BC0", Slot = "9")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x82E0700", Offset = "0x82DF300", VA = "0x1882E0700", Slot = "10")]
		public void InitExternal(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x82DF2A0", Offset = "0x82DDEA0", VA = "0x1882DF2A0", Slot = "11")]
		public void FTKRTFERMFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x82E0280", Offset = "0x82DEE80", VA = "0x1882E0280")]
		private void HCBXLZVWACY(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82E58F0", Offset = "0x82E44F0", VA = "0x1882E58F0")]
		public GameObject VECBZBLAYTP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82DE330", Offset = "0x82DCF30", VA = "0x1882DE330")]
		public GameObject AWCYPCMMQCN(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x82E5F30", Offset = "0x82E4B30", VA = "0x1882E5F30")]
		public GameObject XNYMMMLFBDO(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x82E06C0", Offset = "0x82DF2C0", VA = "0x1882E06C0")]
		public GameObject IRHTLBPAULE(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x82E06F0", Offset = "0x82DF2F0", VA = "0x1882E06F0", Slot = "6")]
		public void ISTEPQHCPJA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x82E0F80", Offset = "0x82DFB80", VA = "0x1882E0F80")]
		public void MBEKEJHWFBB(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82DF1B0", Offset = "0x82DDDB0", VA = "0x1882DF1B0", Slot = "7")]
		public void EUDTLUWVWNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82E55C0", Offset = "0x82E41C0", VA = "0x1882E55C0", Slot = "4")]
		public GameObject[] VBKXOSQVQME(IList<SMQGRYCPFUL> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82E02F0", Offset = "0x82DEEF0", VA = "0x1882E02F0", Slot = "5")]
		public void HNDWAQPIKAX(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x82E0D50", Offset = "0x82DF950", VA = "0x1882E0D50")]
		public void JZODPUYDDDH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x82DEC90", Offset = "0x82DD890", VA = "0x1882DEC90")]
		private void EDMPWAKMPSO(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x82DFE20", Offset = "0x82DEA20", VA = "0x1882DFE20")]
		private void GKPNUQIRSQI(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x82E5380", Offset = "0x82E3F80", VA = "0x1882E5380")]
		private void URLPBOZJOIW(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x82E4770", Offset = "0x82E3370", VA = "0x1882E4770")]
		private void SLDISKPPCGK(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x82E5AC0", Offset = "0x82E46C0", VA = "0x1882E5AC0")]
		private void VJYDNMQASEC(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x82E13E0", Offset = "0x82DFFE0", VA = "0x1882E13E0")]
		private void MJCEEVKPPFI(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x82E4010", Offset = "0x82E2C10", VA = "0x1882E4010")]
		private void QKLIECNJHAU(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82E0B60", Offset = "0x82DF760", VA = "0x1882E0B60")]
		private GameObject JSHETYKVZQD(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x82DE430", Offset = "0x82DD030", VA = "0x1882DE430")]
		private GameObject BRLULYZEZHL(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82E5EB0", Offset = "0x82E4AB0", VA = "0x1882E5EB0")]
		private static GameObject XAWBVEMWUDB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x82E61B0", Offset = "0x82E4DB0", VA = "0x1882E61B0")]
		private static GameObject YLFYOTCAZHQ(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82DEB30", Offset = "0x82DD730", VA = "0x1882DEB30")]
		private static void DQIWFSRVWKZ(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82E1650", Offset = "0x82E0250", VA = "0x1882E1650")]
		private GameObject[] NGWUIBUAEQM(IList<SMQGRYCPFUL> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82DFFC0", Offset = "0x82DEBC0", VA = "0x1882DFFC0")]
		private GameObject[] HBQTKDURPDM(InstantiateParameters[] a, int b, HNNNRVHBOIU c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82E49F0", Offset = "0x82E35F0", VA = "0x1882E49F0")]
		private GameObject SXSHYROIKIM([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82E4650", Offset = "0x82E3250", VA = "0x1882E4650")]
		private static bool RBPQMBTKEEZ(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82E2CC0", Offset = "0x82E18C0", VA = "0x1882E2CC0")]
		private void ODEWQQZAZYN(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82E1E00", Offset = "0x82E0A00", VA = "0x1882E1E00")]
		private void NLZOJAIFJSN(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82E0FF0", Offset = "0x82DFBF0", VA = "0x1882E0FF0")]
		private static void METVHIEWCIE(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E30", Offset = "0x82DFA30", VA = "0x1882E0E30")]
		private void KJUSKQICVRW(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x82DE230", Offset = "0x82DCE30", VA = "0x1882DE230")]
		private static int ALOKOCWMJEI(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x82DE2D0", Offset = "0x82DCED0", VA = "0x1882DE2D0")]
		private void AUINMAXNERR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82E4E00", Offset = "0x82E3A00", VA = "0x1882E4E00")]
		private void UEXBXNKCSBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82E45F0", Offset = "0x82E31F0", VA = "0x1882E45F0")]
		private static int QOUPYILQIZO(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x82DF1C0", Offset = "0x82DDDC0", VA = "0x1882DF1C0")]
		private static int[] EZDXVIYWYPT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x82E3F10", Offset = "0x82E2B10", VA = "0x1882E3F10")]
		private static int[] QHKYVHJPGLD(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x82E3B80", Offset = "0x82E2780", VA = "0x1882E3B80")]
		private void OnMasterClientSwitched(HNNNRVHBOIU newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x82DF390", Offset = "0x82DDF90", VA = "0x1882DF390")]
		private void GCEJUEQGUIB(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x82E38A0", Offset = "0x82E24A0", VA = "0x1882E38A0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x82DEF70", Offset = "0x82DDB70", VA = "0x1882DEF70")]
		private void EQIEPZMWGDD(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x82E15B0", Offset = "0x82E01B0", VA = "0x1882E15B0")]
		private static void MUDMKYHWAUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x82E4670", Offset = "0x82E3270", VA = "0x1882E4670")]
		private void RYIAZWYXMXN(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x82DEC40", Offset = "0x82DD840", VA = "0x1882DEC40", Slot = "12")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xC6B6D0", Offset = "0xC6A2D0", VA = "0x180C6B6D0", Slot = "13")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public BTPPAHNGQZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RegisterService(typeof(GKDGZJFPRZD), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class GKDGZJFPRZD : WKGSNWVFZRQ, HJESUUHTFVQ, TZUPOYZJAQI, KWODXIHZOSZ, DXKVHEDTUEV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private struct RpcMethodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public readonly MethodInfo methodInfo;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private readonly Func<MonoBehaviour, object> accessor;

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x82F50E0", Offset = "0x82F3CE0", VA = "0x1882F50E0")]
			public object LPJUOPHRJZJ(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class CBOPHOYVCOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public FieldInfo TMOYLHLNRCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Func<MonoBehaviour, object> HUQOIQSJJKD;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CBOPHOYVCOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x82E6780", Offset = "0x82E5380", VA = "0x1882E6780")]
			internal RpcMethodInfo LQDYVLYUXXX(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x507DD40", Offset = "0x507C940", VA = "0x18507DD40")]
			internal object LPYRYFEXOMO(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class CBTWEVSSLZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Func<MonoBehaviour, object> KEHXYJZHKDW;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CBTWEVSSLZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x82E6840", Offset = "0x82E5440", VA = "0x1882E6840")]
			internal RpcMethodInfo LQJFSSSSHJG(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class IBVXBRAKPLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Type ZURHGCGMFMJ;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IBVXBRAKPLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x82EAA60", Offset = "0x82E9660", VA = "0x1882EAA60")]
			internal bool CCEKIVESBMV(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static Dictionary<string, int> CCVCFEGMDQZ;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static List<string> SDTKURAVSBO;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static int YALIZDLWWDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private DPLXUVLYZMC TPWVUQJMLCN;

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Stopwatch OCQKYAWYRKB;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static Dictionary<MethodInfo, ParameterInfo[]> WIQWQATHFHC;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> TSKMOWPIIWT;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x82E82B0", Offset = "0x82E6EB0", VA = "0x1882E82B0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x82EA170", Offset = "0x82E8D70", VA = "0x1882EA170")]
		private void WDBJOCMMSLA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x82E83B0", Offset = "0x82E6FB0", VA = "0x1882E83B0", Slot = "10")]
		public void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xC6B6D0", Offset = "0xC6A2D0", VA = "0x180C6B6D0", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x82E84F0", Offset = "0x82E70F0", VA = "0x1882E84F0", Slot = "5")]
		public void PUBZWIFCMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x82E6DF0", Offset = "0x82E59F0", VA = "0x1882E6DF0")]
		public static bool ADFTAABFQYT(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x82E8400", Offset = "0x82E7000", VA = "0x1882E8400")]
		public static bool OMDXNBTUZBF(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82E7F00", Offset = "0x82E6B00", VA = "0x1882E7F00")]
		private void EDMPWAKMPSO(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x82E8180", Offset = "0x82E6D80", VA = "0x1882E8180", Slot = "9")]
		public string EOZWOLDEDLH(PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82EA630", Offset = "0x82E9230", VA = "0x1882EA630", Slot = "8")]
		public void YKKMAAEYPDE(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82E7360", Offset = "0x82E5F60", VA = "0x1882E7360", Slot = "6")]
		public void AQBEZSEJJEW(ViewId a, string b, HNNNRVHBOIU c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x82E6E80", Offset = "0x82E5A80", VA = "0x1882E6E80", Slot = "7")]
		public void AQBEZSEJJEW(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x82E6EB0", Offset = "0x82E5AB0", VA = "0x1882E6EB0")]
		private void AQBEZSEJJEW(ViewId a, string b, RpcTarget c, HNNNRVHBOIU d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x82E8640", Offset = "0x82E7240", VA = "0x1882E8640")]
		private void SDOTBUQOHFT(ViewId a, string b, HNNNRVHBOIU c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x82E9CB0", Offset = "0x82E88B0", VA = "0x1882E9CB0")]
		private static void URPMVYAUBXN(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x82E7430", Offset = "0x82E6030", VA = "0x1882E7430")]
		private static bool BQSYBCSZUIS(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x82E7640", Offset = "0x82E6240", VA = "0x1882E7640")]
		private List<RpcMethodInfo> DZBUYGISVTD(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x82E81B0", Offset = "0x82E6DB0", VA = "0x1882E81B0")]
		private static IEnumerable<MethodInfo> IWVSFMGYDCD(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x82EA6E0", Offset = "0x82E92E0", VA = "0x1882EA6E0")]
		public static ParameterInfo[] ZFXBFALFJOL(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public GKDGZJFPRZD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class RRNetworkSettings : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public const string RRNetworkSettingsFileName = "RRNetworkSettings";

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static RRNetworkSettings instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[TooltipAttribute("RPC name list.\nUsed as shortcut when sending calls.")]
		public List<string> RpcList;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static RRNetworkSettings Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x82EF3D0", Offset = "0x82EDFD0", VA = "0x1882EF3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x82EF350", Offset = "0x82EDF50", VA = "0x1882EF350")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRNetworkView : MonoBehaviour, JOVEFQIMWWV, GAYZLVTIQUW, AWBOTJUFIVJ, HYWYKOMCRZL, NSJDIDNUXGY
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[RegisterService(typeof(KQLOCOMOQFH), new string[] { })]
		internal class QPPYMLDFIDU : WKGSNWVFZRQ, HJESUUHTFVQ, KQLOCOMOQFH
		{
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Dictionary<int, RRNetworkView> PSBWQQPPELF;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x82EE090", Offset = "0x82ECC90", VA = "0x1882EE090", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x82EE090", Offset = "0x82ECC90", VA = "0x1882EE090", Slot = "5")]
			public void PUBZWIFCMXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x82EDD40", Offset = "0x82EC940", VA = "0x1882EDD40", Slot = "6")]
			public void FQQMPLSXILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public QPPYMLDFIDU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum HasExplicitViewId
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			False,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			True_SetInSceneForRoom,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			True_ManuallySetInPrefab
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class XVCGTKCCKDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public int AYTPNGPEAWZ;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public XVCGTKCCKDJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x82FBEB0", Offset = "0x82FAAB0", VA = "0x1882FBEB0")]
			internal bool VUMUNDUNCAX(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static QINZOSCQMJF UUFWBCLAINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private int viewIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private int instantiationIdField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private bool DGNASSGNVNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private bool YRGCAMURBSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool JYBGLESYUYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int VTIHQUVUGNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private bool YXJXENKKMQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int QNROMWSDSPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private HNNNRVHBOIU GGAKNSHIHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private HNNNRVHBOIU QJRQRIIJUZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private bool? IQGGGRONIID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private bool OMPDVRWOWND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		internal bool OFXLZIUFIIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal MonoBehaviour[] GEULPITRMZL;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly Log MPFVUPBSNVU;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> PSBWQQPPELF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x82F0700", Offset = "0x82EF300", VA = "0x1882F0700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId WATNWFASMIS
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x82F3A50", Offset = "0x82F2650", VA = "0x1882F3A50")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId XLKELDXFWHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x82F3A50", Offset = "0x82F2650", VA = "0x1882F3A50", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId HLPOUEPVBUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x82F3A50", Offset = "0x82F2650", VA = "0x1882F3A50")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int XRWRBMJZMGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAFA0D0", Offset = "0xAF8CD0", VA = "0x180AFA0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MAJDFIPRPKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xABDF90", Offset = "0xABCB90", VA = "0x180ABDF90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xBE2E80", Offset = "0xBE1A80", VA = "0x180BE2E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId JLWKVXGBXCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x82F38C0", Offset = "0x82F24C0", VA = "0x1882F38C0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool QCBTXPAKCCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xC6B1E0", Offset = "0xC69DE0", VA = "0x180C6B1E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xC6B1F0", Offset = "0xC69DF0", VA = "0x180C6B1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool LTNGYWABXWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x82F38D0", Offset = "0x82F24D0", VA = "0x1882F38D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ZGLZWMOECPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAF8F90", Offset = "0xAF7B90", VA = "0x180AF8F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xAF9300", Offset = "0xAF7F00", VA = "0x180AF9300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int SQWLFGDGFVZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAE4AB0", Offset = "0xAE36B0", VA = "0x180AE4AB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int CEHGQMKBZFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x82F3860", Offset = "0x82F2460", VA = "0x1882F3860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public HNNNRVHBOIU WDXVSLDYCEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x82F3A60", Offset = "0x82F2660", VA = "0x1882F3A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HNNNRVHBOIU BJOUIHIDITV
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x82F3830", Offset = "0x82F2430", VA = "0x1882F3830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public HNNNRVHBOIU TOZITTQODVG
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x82F3830", Offset = "0x82F2430", VA = "0x1882F3830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public HNNNRVHBOIU PLBBDIDEJEI
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x82F3830", Offset = "0x82F2430", VA = "0x1882F3830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IHKMZSUCAGM
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x82F39A0", Offset = "0x82F25A0", VA = "0x1882F39A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int KWSDYLBVALM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x82F3890", Offset = "0x82F2490", VA = "0x1882F3890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] TMCOXUSRTQI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5B0", Offset = "0xA991B0", VA = "0x180A9A5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool XUCGARBVGVY
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x82F3A90", Offset = "0x82F2690", VA = "0x1882F3A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FXVQWUZEKGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x82F3A20", Offset = "0x82F2620", VA = "0x1882F3A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HWKQTCIEKTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xCAF250", Offset = "0xCADE50", VA = "0x180CAF250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xCAFCF0", Offset = "0xCAE8F0", VA = "0x180CAFCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DYPSIJJRFFL
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xCAE720", Offset = "0xCAD320", VA = "0x180CAE720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> BCLJKTLFJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x82F36C0", Offset = "0x82F22C0", VA = "0x1882F36C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x82F3C50", Offset = "0x82F2850", VA = "0x1882F3C50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<HNNNRVHBOIU> PUESZEKSYSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x82F0530", Offset = "0x82EF130", VA = "0x1882F0530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x82F2C00", Offset = "0x82F1800", VA = "0x1882F2C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<HNNNRVHBOIU> VZXRIWOLDAX
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x82F0530", Offset = "0x82EF130", VA = "0x1882F0530")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x82F2C00", Offset = "0x82F1800", VA = "0x1882F2C00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> PNNDNBFUXCC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x82EF9C0", Offset = "0x82EE5C0", VA = "0x1882EF9C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x82F07F0", Offset = "0x82EF3F0", VA = "0x1882F07F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> HVRMWNMAQTU
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x82EF9C0", Offset = "0x82EE5C0", VA = "0x1882EF9C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x82F07F0", Offset = "0x82EF3F0", VA = "0x1882F07F0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> RTFCOSSCQZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x82F3770", Offset = "0x82F2370", VA = "0x1882F3770")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x82F3D00", Offset = "0x82F2900", VA = "0x1882F3D00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action CKTATUMDSLG
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x82F3610", Offset = "0x82F2210", VA = "0x1882F3610")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x82F3BA0", Offset = "0x82F27A0", VA = "0x1882F3BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x82F3300", Offset = "0x82F1F00", VA = "0x1882F3300")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x82EFAD0", Offset = "0x82EE6D0", VA = "0x1882EFAD0")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x82EFC40", Offset = "0x82EE840", VA = "0x1882EFC40")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82EFB90", Offset = "0x82EE790", VA = "0x1882EFB90")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x82F1290", Offset = "0x82EFE90", VA = "0x1882F1290")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82F1030", Offset = "0x82EFC30", VA = "0x1882F1030")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x82F09E0", Offset = "0x82EF5E0", VA = "0x1882F09E0")]
		public static void OnPlayerJoinedRoom(HNNNRVHBOIU newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x82EFDB0", Offset = "0x82EE9B0", VA = "0x1882EFDB0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82EFE10", Offset = "0x82EEA10", VA = "0x1882EFE10")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x82F33C0", Offset = "0x82F1FC0", VA = "0x1882F33C0")]
		private void URXTOLSPUVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x82EF940", Offset = "0x82EE540", VA = "0x1882EF940")]
		public bool CreatedBy(HNNNRVHBOIU player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x82F3110", Offset = "0x82F1D10", VA = "0x1882F3110")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x82F30B0", Offset = "0x82F1CB0", VA = "0x1882F30B0")]
		public void TransferOwnership(HNNNRVHBOIU newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x82F0090", Offset = "0x82EEC90", VA = "0x1882F0090", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x82F0030", Offset = "0x82EEC30", VA = "0x1882F0030")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x82EF5A0", Offset = "0x82EE1A0", VA = "0x1882EF5A0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x82F0200", Offset = "0x82EEE00", VA = "0x1882F0200")]
		private void JDQYZJFLHCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x10F4D60", Offset = "0x10F3960", VA = "0x1810F4D60")]
		internal void QAFCOYVSBXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82EF540", Offset = "0x82EE140", VA = "0x1882EF540", Slot = "6")]
		private void AXDWXNORUGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82F0690", Offset = "0x82EF290", VA = "0x1882F0690")]
		internal bool MLYQNCHWFZZ(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x82F08A0", Offset = "0x82EF4A0", VA = "0x1882F08A0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x82EFA70", Offset = "0x82EE670", VA = "0x1882EFA70")]
		internal void EQGGLZAGMEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x82F0680", Offset = "0x82EF280", VA = "0x1882F0680")]
		private void MBQATYKZDZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x82F0470", Offset = "0x82EF070", VA = "0x1882F0470")]
		internal void JXRQJAJCRMJ(HNNNRVHBOIU a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x82F11F0", Offset = "0x82EFDF0", VA = "0x1882F11F0")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x82F1340", Offset = "0x82EFF40", VA = "0x1882F1340")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x82F05E0", Offset = "0x82EF1E0", VA = "0x1882F05E0")]
		private void LMBGYOAKWNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D50", Offset = "0x82EF950", VA = "0x1882F0D50")]
		private void QGWFGVXLZVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x82F0F10", Offset = "0x82EFB10", VA = "0x1882F0F10")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x82F0FA0", Offset = "0x82EFBA0", VA = "0x1882F0FA0")]
		public void RPC(string methodName, HNNNRVHBOIU targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x82F1240", Offset = "0x82EFE40", VA = "0x1882F1240")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x82EF5F0", Offset = "0x82EE1F0", VA = "0x1882EF5F0", Slot = "8")]
		public void Bake(JWXNTSXUZSO context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x82EF660", Offset = "0x82EE260", VA = "0x1882EF660")]
		private static void CULVOGIAQKQ(HNNNRVHBOIU a, [Out] HNNNRVHBOIU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x82F2DC0", Offset = "0x82F19C0", VA = "0x1882F2DC0")]
		private static void TAHLRULLQOX(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x82F34A0", Offset = "0x82F20A0", VA = "0x1882F34A0")]
		private static RPCInfo YVBFBPNOFLI(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x82EFE70", Offset = "0x82EEA70", VA = "0x1882EFE70")]
		private static void HFLUNWOHGAI(RRNetworkView a, Delegate b, HNNNRVHBOIU c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x82EFF50", Offset = "0x82EEB50", VA = "0x1882EFF50")]
		private static void HFLUNWOHGAI(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x82F2CB0", Offset = "0x82F18B0", VA = "0x1882F2CB0")]
		private static void SYLLNLQDRMP(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x82F0E40", Offset = "0x82EFA40", VA = "0x1882F0E40")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x82F0750", Offset = "0x82EF350", VA = "0x1882F0750")]
		private static bool NXLKTPHOYQY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x82F17F0", Offset = "0x82F03F0", VA = "0x1882F17F0", Slot = "25")]
		public void RpcAll(LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3982A40", Offset = "0x3981640", VA = "0x183982A40", Slot = "9")]
		public void RpcAll<T1>(LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3982320", Offset = "0x3980F20", VA = "0x183982320", Slot = "10")]
		public void RpcAll<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3984B10", Offset = "0x3983710", VA = "0x183984B10", Slot = "26")]
		public void RpcAll<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3982510", Offset = "0x3981110", VA = "0x183982510", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3983070", Offset = "0x3981C70", VA = "0x183983070", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3984FC0", Offset = "0x3983BC0", VA = "0x183984FC0", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3982BB0", Offset = "0x39817B0", VA = "0x183982BB0", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3999F60", Offset = "0x3998B60", VA = "0x183999F60", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x39853F0", Offset = "0x3983FF0", VA = "0x1839853F0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3983C50", Offset = "0x3982850", VA = "0x183983C50", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x399EAD0", Offset = "0x399D6D0", VA = "0x18399EAD0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3997520", Offset = "0x3996120", VA = "0x183997520", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3989310", Offset = "0x3987F10", VA = "0x183989310", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3983470", Offset = "0x3982070", VA = "0x183983470", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x82F1960", Offset = "0x82F0560", VA = "0x1882F1960", Slot = "35")]
		public void RpcAll(LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x39980B0", Offset = "0x3996CB0", VA = "0x1839980B0", Slot = "36")]
		public void RpcAll<T1>(LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3997BD0", Offset = "0x39967D0", VA = "0x183997BD0", Slot = "37")]
		public void RpcAll<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3984470", Offset = "0x3983070", VA = "0x183984470", Slot = "38")]
		public void RpcAll<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3994A40", Offset = "0x3993640", VA = "0x183994A40", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3993D10", Offset = "0x3992910", VA = "0x183993D10", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3992DA0", Offset = "0x39919A0", VA = "0x183992DA0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x39924A0", Offset = "0x39910A0", VA = "0x1839924A0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3990810", Offset = "0x398F410", VA = "0x183990810", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x398FCE0", Offset = "0x398E8E0", VA = "0x18398FCE0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x398E5B0", Offset = "0x398D1B0", VA = "0x18398E5B0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x398BF30", Offset = "0x398AB30", VA = "0x18398BF30", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x398A270", Offset = "0x3988E70", VA = "0x18398A270", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3988350", Offset = "0x3986F50", VA = "0x183988350", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3987260", Offset = "0x3985E60", VA = "0x183987260", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x82F16C0", Offset = "0x82F02C0", VA = "0x1882F16C0", Slot = "50")]
		public void RpcAllViaServer(LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x39AA610", Offset = "0x39A9210", VA = "0x1839AA610", Slot = "51")]
		public void RpcAllViaServer<T1>(LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x39AA7A0", Offset = "0x39A93A0", VA = "0x1839AA7A0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x39AA0A0", Offset = "0x39A8CA0", VA = "0x1839AA0A0", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x39A9CB0", Offset = "0x39A88B0", VA = "0x1839A9CB0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x39A9800", Offset = "0x39A8400", VA = "0x1839A9800", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x39A9290", Offset = "0x39A7E90", VA = "0x1839A9290", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x39A8C60", Offset = "0x39A7860", VA = "0x1839A8C60", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x39A8560", Offset = "0x39A7160", VA = "0x1839A8560", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x39A7DA0", Offset = "0x39A69A0", VA = "0x1839A7DA0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x39A7520", Offset = "0x39A6120", VA = "0x1839A7520", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x39A6BE0", Offset = "0x39A57E0", VA = "0x1839A6BE0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x39A61D0", Offset = "0x39A4DD0", VA = "0x1839A61D0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x39A56F0", Offset = "0x39A42F0", VA = "0x1839A56F0", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x39A4B40", Offset = "0x39A3740", VA = "0x1839A4B40", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x82F1590", Offset = "0x82F0190", VA = "0x1882F1590", Slot = "64")]
		public void RpcAllViaServer(LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x39AA610", Offset = "0x39A9210", VA = "0x1839AA610", Slot = "65")]
		public void RpcAllViaServer<T1>(LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x39AA3C0", Offset = "0x39A8FC0", VA = "0x1839AA3C0", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x39AA0A0", Offset = "0x39A8CA0", VA = "0x1839AA0A0", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x39A9CB0", Offset = "0x39A88B0", VA = "0x1839A9CB0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x39A9800", Offset = "0x39A8400", VA = "0x1839A9800", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x39A9290", Offset = "0x39A7E90", VA = "0x1839A9290", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x39A8C60", Offset = "0x39A7860", VA = "0x1839A8C60", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x39A8560", Offset = "0x39A7160", VA = "0x1839A8560", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x39A7DA0", Offset = "0x39A69A0", VA = "0x1839A7DA0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x39A7520", Offset = "0x39A6120", VA = "0x1839A7520", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x39A6BE0", Offset = "0x39A57E0", VA = "0x1839A6BE0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x39A61D0", Offset = "0x39A4DD0", VA = "0x1839A61D0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x39A56F0", Offset = "0x39A42F0", VA = "0x1839A56F0", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39A4B40", Offset = "0x39A3740", VA = "0x1839A4B40", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x82F2600", Offset = "0x82F1200", VA = "0x1882F2600", Slot = "79")]
		public void RpcOthers(LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39E0580", Offset = "0x39DF180", VA = "0x1839E0580", Slot = "15")]
		public void RpcOthers<T1>(LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39E6C90", Offset = "0x39E5890", VA = "0x1839E6C90", Slot = "80")]
		public void RpcOthers<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x39E0330", Offset = "0x39DEF30", VA = "0x1839E0330", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39E9B60", Offset = "0x39E8760", VA = "0x1839E9B60", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39E5510", Offset = "0x39E4110", VA = "0x1839E5510", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x39E7A30", Offset = "0x39E6630", VA = "0x1839E7A30", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x39E4910", Offset = "0x39E3510", VA = "0x1839E4910", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x39E86A0", Offset = "0x39E72A0", VA = "0x1839E86A0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x39E3A00", Offset = "0x39E2600", VA = "0x1839E3A00", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x39E81A0", Offset = "0x39E6DA0", VA = "0x1839E81A0", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x39E27E0", Offset = "0x39E13E0", VA = "0x1839E27E0", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x39E1DB0", Offset = "0x39E09B0", VA = "0x1839E1DB0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x39E12B0", Offset = "0x39DFEB0", VA = "0x1839E12B0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x39E06D0", Offset = "0x39DF2D0", VA = "0x1839E06D0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x82F24B0", Offset = "0x82F10B0", VA = "0x1882F24B0", Slot = "92")]
		public void RpcOthers(LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x39E69F0", Offset = "0x39E55F0", VA = "0x1839E69F0", Slot = "93")]
		public void RpcOthers<T1>(LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x39E6830", Offset = "0x39E5430", VA = "0x1839E6830", Slot = "94")]
		public void RpcOthers<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x39E5DF0", Offset = "0x39E49F0", VA = "0x1839E5DF0", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39E6580", Offset = "0x39E5180", VA = "0x1839E6580", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39E71A0", Offset = "0x39E5DA0", VA = "0x1839E71A0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x39E74B0", Offset = "0x39E60B0", VA = "0x1839E74B0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x39E4910", Offset = "0x39E3510", VA = "0x1839E4910", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x39E41F0", Offset = "0x39E2DF0", VA = "0x1839E41F0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x39E3A00", Offset = "0x39E2600", VA = "0x1839E3A00", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x39E3150", Offset = "0x39E1D50", VA = "0x1839E3150", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x39E27E0", Offset = "0x39E13E0", VA = "0x1839E27E0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x39E1DB0", Offset = "0x39E09B0", VA = "0x1839E1DB0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x39E12B0", Offset = "0x39DFEB0", VA = "0x1839E12B0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x39E06D0", Offset = "0x39DF2D0", VA = "0x1839E06D0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x82F21E0", Offset = "0x82F0DE0", VA = "0x1882F21E0", Slot = "107")]
		public void RpcMaster(LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x39C16F0", Offset = "0x39C02F0", VA = "0x1839C16F0", Slot = "108")]
		public void RpcMaster<T1>(LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x39C1890", Offset = "0x39C0490", VA = "0x1839C1890", Slot = "109")]
		public void RpcMaster<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x39C0D00", Offset = "0x39BF900", VA = "0x1839C0D00", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39C0F60", Offset = "0x39BFB60", VA = "0x1839C0F60", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x39D5160", Offset = "0x39D3D60", VA = "0x1839D5160", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x39D71C0", Offset = "0x39D5DC0", VA = "0x1839D71C0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x39CD5E0", Offset = "0x39CC1E0", VA = "0x1839CD5E0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x39CC1E0", Offset = "0x39CADE0", VA = "0x1839CC1E0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x39CB700", Offset = "0x39CA300", VA = "0x1839CB700", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x39D49A0", Offset = "0x39D35A0", VA = "0x1839D49A0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x39D3BB0", Offset = "0x39D27B0", VA = "0x1839D3BB0", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x39C6A40", Offset = "0x39C5640", VA = "0x1839C6A40", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x39C4C20", Offset = "0x39C3820", VA = "0x1839C4C20", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x39C1AB0", Offset = "0x39C06B0", VA = "0x1839C1AB0", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x82F1FA0", Offset = "0x82F0BA0", VA = "0x1882F1FA0", Slot = "122")]
		public void RpcMaster(LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x39C1510", Offset = "0x39C0110", VA = "0x1839C1510", Slot = "123")]
		public void RpcMaster<T1>(LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x39D2EB0", Offset = "0x39D1AB0", VA = "0x1839D2EB0", Slot = "124")]
		public void RpcMaster<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x39D2510", Offset = "0x39D1110", VA = "0x1839D2510", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x39D0A40", Offset = "0x39CF640", VA = "0x1839D0A40", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x39D5930", Offset = "0x39D4530", VA = "0x1839D5930", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x39CE7B0", Offset = "0x39CD3B0", VA = "0x1839CE7B0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x39CDEA0", Offset = "0x39CCAA0", VA = "0x1839CDEA0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x39CCBB0", Offset = "0x39CB7B0", VA = "0x1839CCBB0", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x39CABB0", Offset = "0x39C97B0", VA = "0x1839CABB0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x39C9F50", Offset = "0x39C8B50", VA = "0x1839C9F50", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x39C85C0", Offset = "0x39C71C0", VA = "0x1839C85C0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x39C5B90", Offset = "0x39C4790", VA = "0x1839C5B90", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x39C3C50", Offset = "0x39C2850", VA = "0x1839C3C50", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x39C2B50", Offset = "0x39C1750", VA = "0x1839C2B50", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x82F1B90", Offset = "0x82F0790", VA = "0x1882F1B90", Slot = "137")]
		public void RpcAuthority(LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x39AAE80", Offset = "0x39A9A80", VA = "0x1839AAE80", Slot = "138")]
		public void RpcAuthority<T1>(LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x39BD4E0", Offset = "0x39BC0E0", VA = "0x1839BD4E0", Slot = "139")]
		public void RpcAuthority<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x39BDC50", Offset = "0x39BC850", VA = "0x1839BDC50", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x39BD1E0", Offset = "0x39BBDE0", VA = "0x1839BD1E0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x39AAAE0", Offset = "0x39A96E0", VA = "0x1839AAAE0", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x39B8070", Offset = "0x39B6C70", VA = "0x1839B8070", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39B7770", Offset = "0x39B6370", VA = "0x1839B7770", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x39B59D0", Offset = "0x39B45D0", VA = "0x1839B59D0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x39B4330", Offset = "0x39B2F30", VA = "0x1839B4330", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x39B36F0", Offset = "0x39B22F0", VA = "0x1839B36F0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x39BEB00", Offset = "0x39BD700", VA = "0x1839BEB00", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x39BBF50", Offset = "0x39BAB50", VA = "0x1839BBF50", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x39AD230", Offset = "0x39ABE30", VA = "0x1839AD230", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x39AB030", Offset = "0x39A9C30", VA = "0x1839AB030", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x82F1D40", Offset = "0x82F0940", VA = "0x1882F1D40", Slot = "152")]
		public void RpcAuthority(LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x39BBA40", Offset = "0x39BA640", VA = "0x1839BBA40", Slot = "153")]
		public void RpcAuthority<T1>(LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x39BB660", Offset = "0x39BA260", VA = "0x1839BB660", Slot = "154")]
		public void RpcAuthority<T1, T2>(LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x39BA9A0", Offset = "0x39B95A0", VA = "0x1839BA9A0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x39BA3B0", Offset = "0x39B8FB0", VA = "0x1839BA3B0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x39B9710", Offset = "0x39B8310", VA = "0x1839B9710", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x39B8840", Offset = "0x39B7440", VA = "0x1839B8840", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x39B6E30", Offset = "0x39B5A30", VA = "0x1839B6E30", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x39B63D0", Offset = "0x39B4FD0", VA = "0x1839B63D0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39B4E50", Offset = "0x39B3A50", VA = "0x1839B4E50", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39B2A50", Offset = "0x39B1650", VA = "0x1839B2A50", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39B1CA0", Offset = "0x39B08A0", VA = "0x1839B1CA0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x39AF1E0", Offset = "0x39ADDE0", VA = "0x1839AF1E0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x39AE1D0", Offset = "0x39ACDD0", VA = "0x1839AE1D0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x39AC100", Offset = "0x39AAD00", VA = "0x1839AC100", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x82F2750", Offset = "0x82F1350", VA = "0x1882F2750", Slot = "17")]
		public void RpcPlayer(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x39EA0C0", Offset = "0x39E8CC0", VA = "0x1839EA0C0", Slot = "18")]
		public void RpcPlayer<T1>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x39EA490", Offset = "0x39E9090", VA = "0x1839EA490", Slot = "19")]
		public void RpcPlayer<T1, T2>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x39EC400", Offset = "0x39EB000", VA = "0x1839EC400", Slot = "20")]
		public void RpcPlayer<T1, T2, T3>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x39EC0B0", Offset = "0x39EACB0", VA = "0x1839EC0B0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x39FFE00", Offset = "0x39FEA00", VA = "0x1839FFE00", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x39FF9F0", Offset = "0x39FE5F0", VA = "0x1839FF9F0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3A00190", Offset = "0x39FED90", VA = "0x183A00190", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3A00600", Offset = "0x39FF200", VA = "0x183A00600", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x39F7790", Offset = "0x39F6390", VA = "0x1839F7790", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x39F5EB0", Offset = "0x39F4AB0", VA = "0x1839F5EB0", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x39ECCC0", Offset = "0x39EB8C0", VA = "0x1839ECCC0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x39F2610", Offset = "0x39F1210", VA = "0x1839F2610", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3A045D0", Offset = "0x3A031D0", VA = "0x183A045D0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x39EF560", Offset = "0x39EE160", VA = "0x1839EF560", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x82F2940", Offset = "0x82F1540", VA = "0x1882F2940", Slot = "176")]
		public void RpcPlayer(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x39EA280", Offset = "0x39E8E80", VA = "0x1839EA280", Slot = "177")]
		public void RpcPlayer<T1>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x39EA6E0", Offset = "0x39E92E0", VA = "0x1839EA6E0", Slot = "23")]
		public void RpcPlayer<T1, T2>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x39EC980", Offset = "0x39EB580", VA = "0x1839EC980", Slot = "24")]
		public void RpcPlayer<T1, T2, T3>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x39EE080", Offset = "0x39ECC80", VA = "0x1839EE080", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x39FCB80", Offset = "0x39FB780", VA = "0x1839FCB80", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x39FB4B0", Offset = "0x39FA0B0", VA = "0x1839FB4B0", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x39FA290", Offset = "0x39F8E90", VA = "0x1839FA290", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x39F9830", Offset = "0x39F8430", VA = "0x1839F9830", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x39F82B0", Offset = "0x39F6EB0", VA = "0x1839F82B0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x39F6AF0", Offset = "0x39F56F0", VA = "0x1839F6AF0", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x39F50F0", Offset = "0x39F3CF0", VA = "0x1839F50F0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x39F34A0", Offset = "0x39F20A0", VA = "0x1839F34A0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x39F15F0", Offset = "0x39F01F0", VA = "0x1839F15F0", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x39EE410", Offset = "0x39ED010", VA = "0x1839EE410", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HNNNRVHBOIU player, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x82F14F0", Offset = "0x82F00F0", VA = "0x1882F14F0", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3982180", Offset = "0x3980D80", VA = "0x183982180", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3981F30", Offset = "0x3980B30", VA = "0x183981F30", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3981C10", Offset = "0x3980810", VA = "0x183981C10", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3981830", Offset = "0x3980430", VA = "0x183981830", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3981380", Offset = "0x397FF80", VA = "0x183981380", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3980E00", Offset = "0x397FA00", VA = "0x183980E00", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x39807D0", Offset = "0x397F3D0", VA = "0x1839807D0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x39800D0", Offset = "0x397ECD0", VA = "0x1839800D0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x397F910", Offset = "0x397E510", VA = "0x18397F910", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x397F080", Offset = "0x397DC80", VA = "0x18397F080", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x397E730", Offset = "0x397D330", VA = "0x18397E730", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x397DD20", Offset = "0x397C920", VA = "0x18397DD20", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x39A4060", Offset = "0x39A2C60", VA = "0x1839A4060", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x39A34B0", Offset = "0x39A20B0", VA = "0x1839A34B0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x82F1450", Offset = "0x82F0050", VA = "0x1882F1450", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3982180", Offset = "0x3980D80", VA = "0x183982180", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3981F30", Offset = "0x3980B30", VA = "0x183981F30", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3981C10", Offset = "0x3980810", VA = "0x183981C10", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3981830", Offset = "0x3980430", VA = "0x183981830", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3981380", Offset = "0x397FF80", VA = "0x183981380", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3980E00", Offset = "0x397FA00", VA = "0x183980E00", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x39807D0", Offset = "0x397F3D0", VA = "0x1839807D0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x39800D0", Offset = "0x397ECD0", VA = "0x1839800D0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x397F910", Offset = "0x397E510", VA = "0x18397F910", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x397F080", Offset = "0x397DC80", VA = "0x18397F080", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x397E730", Offset = "0x397D330", VA = "0x18397E730", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x397DD20", Offset = "0x397C920", VA = "0x18397DD20", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x39A4060", Offset = "0x39A2C60", VA = "0x1839A4060", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x39A34B0", Offset = "0x39A20B0", VA = "0x1839A34B0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x82F2370", Offset = "0x82F0F70", VA = "0x1882F2370", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x39E0190", Offset = "0x39DED90", VA = "0x1839E0190", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x39DFF40", Offset = "0x39DEB40", VA = "0x1839DFF40", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x39DFC20", Offset = "0x39DE820", VA = "0x1839DFC20", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x39DF830", Offset = "0x39DE430", VA = "0x1839DF830", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x39DF380", Offset = "0x39DDF80", VA = "0x1839DF380", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x39DEE00", Offset = "0x39DDA00", VA = "0x1839DEE00", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x39DE7D0", Offset = "0x39DD3D0", VA = "0x1839DE7D0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x39DE0D0", Offset = "0x39DCCD0", VA = "0x1839DE0D0", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x39DD910", Offset = "0x39DC510", VA = "0x1839DD910", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x39DD080", Offset = "0x39DBC80", VA = "0x1839DD080", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x39DC730", Offset = "0x39DB330", VA = "0x1839DC730", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x39DBD20", Offset = "0x39DA920", VA = "0x1839DBD20", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x39DB240", Offset = "0x39D9E40", VA = "0x1839DB240", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x39DA690", Offset = "0x39D9290", VA = "0x1839DA690", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x82F2410", Offset = "0x82F1010", VA = "0x1882F2410", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x39E0190", Offset = "0x39DED90", VA = "0x1839E0190", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x39DFF40", Offset = "0x39DEB40", VA = "0x1839DFF40", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x39DFC20", Offset = "0x39DE820", VA = "0x1839DFC20", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x39DF830", Offset = "0x39DE430", VA = "0x1839DF830", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x39DF380", Offset = "0x39DDF80", VA = "0x1839DF380", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x39DEE00", Offset = "0x39DDA00", VA = "0x1839DEE00", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x39DE7D0", Offset = "0x39DD3D0", VA = "0x1839DE7D0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x39DE0D0", Offset = "0x39DCCD0", VA = "0x1839DE0D0", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x39DD910", Offset = "0x39DC510", VA = "0x1839DD910", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x39DD080", Offset = "0x39DBC80", VA = "0x1839DD080", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x39DC730", Offset = "0x39DB330", VA = "0x1839DC730", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x39DBD20", Offset = "0x39DA920", VA = "0x1839DBD20", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x39DB240", Offset = "0x39D9E40", VA = "0x1839DB240", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x39DA690", Offset = "0x39D9290", VA = "0x1839DA690", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, LHTPNUVQTXP.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x82EF6D0", Offset = "0x82EE2D0", VA = "0x1882EF6D0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x82EF8E0", Offset = "0x82EE4E0", VA = "0x1882EF8E0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x14CC770", Offset = "0x14CB370", VA = "0x1814CC770")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class YKJTKNKVWPS
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x82FBF10", Offset = "0x82FAB10", VA = "0x1882FBF10")]
		private static bool ACIWXLIRPVJ(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C01E90", Offset = "0x3C00A90", VA = "0x183C01E90")]
		[CanBeNull]
		public static a GLWHSVQRYGH<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class SBNSPJVPEDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public HNNNRVHBOIU[] OFMOQLQLYKS;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SBNSPJVPEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x82F5100", Offset = "0x82F3D00", VA = "0x1882F5100")]
			internal int IHNOTUBUDRG(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x82F5180", Offset = "0x82F3D80", VA = "0x1882F5180")]
			internal void IHSVRAVRNCP(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static HNNNRVHBOIU[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		internal int RLLPWQLRGXB;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x82F3FF0", Offset = "0x82F2BF0", VA = "0x1882F3FF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x82F4500", Offset = "0x82F3100", VA = "0x1882F4500")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x82F48A0", Offset = "0x82F34A0", VA = "0x1882F48A0")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x82F4920", Offset = "0x82F3520", VA = "0x1882F4920")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x82F44F0", Offset = "0x82F30F0", VA = "0x1882F44F0")]
		private void JROTLCZTIJT(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x82F44F0", Offset = "0x82F30F0", VA = "0x1882F44F0")]
		private void GCEJUEQGUIB(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x82F3DC0", Offset = "0x82F29C0", VA = "0x1882F3DC0")]
		private void AXIMZKCPCLN(HNNNRVHBOIU a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x82F3EA0", Offset = "0x82F2AA0", VA = "0x1882F3EA0")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x82F49D0", Offset = "0x82F35D0", VA = "0x1882F49D0")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x82F4400", Offset = "0x82F3000", VA = "0x1882F4400")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA5F80", VA = "0x180AA7380")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class TLGDWYVZYZJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x82F61F0", Offset = "0x82F4DF0", VA = "0x1882F61F0")]
		public static int GTHTZJYNGZD(this HNNNRVHBOIU a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x82F6380", Offset = "0x82F4F80", VA = "0x1882F6380")]
		public static void LRWBZMBVGUR(this HNNNRVHBOIU a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class JZNIDCXHVBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void RoomPropertyUpdateCallback(Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void PlayerPropertyUpdateCallback(HNNNRVHBOIU player, Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback JLEUEGGZPWT
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x82EBD10", Offset = "0x82EA910", VA = "0x1882EBD10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x82EB890", Offset = "0x82EA490", VA = "0x1882EB890")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback NCAZBOOFTTA
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x82EBB90", Offset = "0x82EA790", VA = "0x1882EBB90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x82EB950", Offset = "0x82EA550", VA = "0x1882EB950")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback QTPFKNHGCEB
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x82EBAD0", Offset = "0x82EA6D0", VA = "0x1882EBAD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x82EBA10", Offset = "0x82EA610", VA = "0x1882EBA10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback BBAOTKAGWFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x82EBDD0", Offset = "0x82EA9D0", VA = "0x1882EBDD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x82EBC50", Offset = "0x82EA850", VA = "0x1882EBC50")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class BFPGWFDLMQA
	{
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private static int EZPOTZMHRFQ;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static int IMEYOBBWKVC;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static int BHWOZEAERDK;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x82DDE70", Offset = "0x82DCA70", VA = "0x1882DDE70")]
		public static void FMDODPXRNEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x82DE150", Offset = "0x82DCD50", VA = "0x1882DE150")]
		public static void YMGFJZIPTMH(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x82DDEC0", Offset = "0x82DCAC0", VA = "0x1882DDEC0")]
		public static int QOUPYILQIZO(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RegisterService(typeof(QCQQKPQMXYA), new string[] { })]
	public class TTAUAPSJAWY : QCQQKPQMXYA
	{
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static readonly Dictionary<object, object> IRFESMJRWOR;

		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Dictionary<object, object> YLZFAYUCPKF;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly Dictionary<object, object> VEURAHZJKFD;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly QINZOSCQMJF JCQPYVWCOZF;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly QINZOSCQMJF STGWJFSFZTI;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly QINZOSCQMJF CDUCCUWMFAS;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly QINZOSCQMJF NPIMFORDYLR;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly QINZOSCQMJF WOFCUGFOICO;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static int ONCQSPDNNBR;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x82F8BA0", Offset = "0x82F77A0", VA = "0x1882F8BA0", Slot = "4")]
		public bool WFTUHJPDYLJ(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x82F8170", Offset = "0x82F6D70", VA = "0x1882F8170", Slot = "5")]
		public int KBIETJLSQIX(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x82F6C80", Offset = "0x82F5880", VA = "0x1882F6C80", Slot = "6")]
		public bool CCAMKAMHWRY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x82F67C0", Offset = "0x82F53C0", VA = "0x1882F67C0", Slot = "7")]
		public bool AKVGQAMEEGH(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x82F6980", Offset = "0x82F5580", VA = "0x1882F6980", Slot = "8")]
		public void BEHFCRCWJZM(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x82F8000", Offset = "0x82F6C00", VA = "0x1882F8000", Slot = "9")]
		public bool GZEIONHAEQK(PKPJICLPGZO a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x82F74B0", Offset = "0x82F60B0", VA = "0x1882F74B0", Slot = "10")]
		public bool FVPSLSGELYH(PKPJICLPGZO a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x82F8690", Offset = "0x82F7290", VA = "0x1882F8690", Slot = "11")]
		public bool NSUOOFOKWZG(PKPJICLPGZO a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x82F7260", Offset = "0x82F5E60", VA = "0x1882F7260", Slot = "12")]
		public void FKGQOJMPAUE(PKPJICLPGZO a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x82F8DC0", Offset = "0x82F79C0", VA = "0x1882F8DC0", Slot = "13")]
		public void ZVYPBPUNJDJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x82F8990", Offset = "0x82F7590", VA = "0x1882F8990", Slot = "14")]
		public void PELSGCAICFB(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x82F6BA0", Offset = "0x82F57A0", VA = "0x1882F6BA0", Slot = "15")]
		public void BRTKNHINJQV(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x82F8580", Offset = "0x82F7180", VA = "0x1882F8580", Slot = "16")]
		public void KXWNQFEVTNG(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x82F87D0", Offset = "0x82F73D0", VA = "0x1882F87D0", Slot = "17")]
		public void NYNAORKTXBE(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x82F6D10", Offset = "0x82F5910", VA = "0x1882F6D10")]
		private static void DZJLCUBWRIT(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x82F77E0", Offset = "0x82F63E0", VA = "0x1882F77E0")]
		private static bool GZEIONHAEQK(Dictionary<object, object> a, HNNNRVHBOIU b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x82F8B00", Offset = "0x82F7700", VA = "0x1882F8B00")]
		private static bool SJXMZAZKDBT(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x82F8CE0", Offset = "0x82F78E0", VA = "0x1882F8CE0")]
		private static int YUWXUSCIGPT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public TTAUAPSJAWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RegisterService(typeof(DPLXUVLYZMC), new string[] { })]
	public class SVUXVDSGTOW : DPLXUVLYZMC
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static readonly object BJBZWUOZXFG;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly object BJHGUBIXGQP;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly object BJMNRICUQBY;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly object BJRUOOWRZNH;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly object BIGYHTNKLLW;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static Dictionary<object, object> XKLKGKAKGDQ;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static Dictionary<object, object> RCXAQZRHYSF;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static QINZOSCQMJF AJAMTAQQSYE;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly QINZOSCQMJF BXWCLTVWTFP;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82F5DE0", Offset = "0x82F49E0", VA = "0x1882F5DE0", Slot = "4")]
		public void YKKMAAEYPDE(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x82F5210", Offset = "0x82F3E10", VA = "0x1882F5210", Slot = "5")]
		public bool OMHJWBJTTIC(PKPJICLPGZO a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x82F5710", Offset = "0x82F4310", VA = "0x1882F5710", Slot = "6")]
		public void ROXOIDBZCUY(ViewId a, string b, RpcTarget c, HNNNRVHBOIU d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public SVUXVDSGTOW()
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
