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
		[Cpp2IlInjected.Address(RVA = "0x9AE94D0", Offset = "0x9AE7ED0", VA = "0x189AE94D0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] SSEWJRBADRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset DGFUTRZDISL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x22688A0", Offset = "0x22672A0", VA = "0x1822688A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5590", Offset = "0x9AF3F90", VA = "0x189AF5590")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5AA0", Offset = "0x9AF44A0", VA = "0x189AF5AA0")]
		private void TZHSANLRDRN(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9AF54E0", Offset = "0x9AF3EE0", VA = "0x189AF54E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5D00", Offset = "0x9AF4700", VA = "0x189AF5D00")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PWWHVBALQCW
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log HVGOLUCVCZW;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log TMEGFMGQCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9C30", Offset = "0x9AE8630", VA = "0x189AE9C30")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface BCQXRUSLGZW
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView HMUNBSXVCEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType IFFLRPTRFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool MYLPIQGVIDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "2")]
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
	internal interface UMTDTSDPBBO
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool HZGSLNWSFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RLGCXTJCMVL(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface MZWCZPCNXTJ : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CBYRPQCEVDS(BCQXRUSLGZW a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WRENKBCPLUL(BCQXRUSLGZW a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(GNCYHEZRUUA.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SKYRIIBFGMW();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XXVJJQPAXON(object a);
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
	public class DOPCKQTVUJQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), UMTDTSDPBBO> UVXMIUMAJJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<BCQXRUSLGZW> QXRCMAVSTWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> GPCNUVVDOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int KTJDTHIKMPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool SPEHAGFAMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private GNCYHEZRUUA.ApplyNetworkTransform WZVSDYKMNQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream SGWUOOAXACT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker MQZIKAEGCKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker UPCBYWFIIQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] UBYUADTTXMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float OAJLOAEZXUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int UNBCRSMAZUQ;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB6D0", Offset = "0x9ADA0D0", VA = "0x189ADB6D0")]
		public DOPCKQTVUJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB160", Offset = "0x9AD9B60", VA = "0x189ADB160")]
		public void Pause(GNCYHEZRUUA.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB2B0", Offset = "0x9AD9CB0", VA = "0x189ADB2B0")]
		public void SKYRIIBFGMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB300", Offset = "0x9AD9D00", VA = "0x189ADB300")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA210", Offset = "0x9AD8C10", VA = "0x189ADA210")]
		public bool Add(BCQXRUSLGZW networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB180", Offset = "0x9AD9B80", VA = "0x189ADB180")]
		public bool Remove(BCQXRUSLGZW networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9ADAB80", Offset = "0x9AD9580", VA = "0x189ADAB80")]
		private UMTDTSDPBBO JVHDVSKXJUX(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA720", Offset = "0x9AD9120", VA = "0x189ADA720")]
		public void CNTXQSOVDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9ADAB20", Offset = "0x9AD9520", VA = "0x189ADAB20")]
		private void ELVCEFOWLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9ADAD90", Offset = "0x9AD9790", VA = "0x189ADAD90")]
		private void OIVCTCCWKVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9ADADB0", Offset = "0x9AD97B0", VA = "0x189ADADB0")]
		public bool PODDPYJRAER(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA730", Offset = "0x9AD9130", VA = "0x189ADA730")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class GJGFXAJBGAB : UMTDTSDPBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private BCQXRUSLGZW LYHATPLGLMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint DXDWXLJEPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int FGNVLJJHCDD;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool HZGSLNWSFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public GJGFXAJBGAB(BCQXRUSLGZW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC980", Offset = "0x9ADB380", VA = "0x189ADC980", Slot = "5")]
		public bool RLGCXTJCMVL(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC8A0", Offset = "0x9ADB2A0", VA = "0x189ADC8A0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class HKHYGBWZWNM : UMTDTSDPBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private GNCYHEZRUUA.ApplyNetworkTransform WZVSDYKMNQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId GOVTICOLOTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int FGNVLJJHCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint DXDWXLJEPEI;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HZGSLNWSFPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D2FE50", Offset = "0x1D2E850", VA = "0x181D2FE50")]
		public HKHYGBWZWNM(ViewId a, GNCYHEZRUUA.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD030", Offset = "0x9ADBA30", VA = "0x189ADD030", Slot = "5")]
		public bool RLGCXTJCMVL(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCE50", Offset = "0x9ADB850", VA = "0x189ADCE50", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class RGCBKFAJFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB4F0", Offset = "0x9AE9EF0", VA = "0x189AEB4F0")]
		public static void NYKTBLQYXAJ(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAFF0", Offset = "0x9AE99F0", VA = "0x189AEAFF0")]
		public static void KRPGPWFKHUQ(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAE80", Offset = "0x9AE9880", VA = "0x189AEAE80")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEB6B0", Offset = "0x9AEA0B0", VA = "0x189AEB6B0")]
		public static void XPQMOZYQHBP(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(MZWCZPCNXTJ), new string[] { })]
	public class RFPIPVFFDPI : MZWCZPCNXTJ, INetworkUpdateSystem, SZDUQTANYAQ, JQVAGBYEMGQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log JBTEFAHORZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private DOPCKQTVUJQ UYPWWNDSARI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint AWHCXBKYUHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float EWMHLQUFBHM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9CF0", Offset = "0x9AE86F0", VA = "0x189AE9CF0", Slot = "4")]
		public void CBYRPQCEVDS(BCQXRUSLGZW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAB40", Offset = "0x9AE9540", VA = "0x189AEAB40", Slot = "5")]
		public void WRENKBCPLUL(BCQXRUSLGZW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA1A0", Offset = "0x9AE8BA0", VA = "0x189AEA1A0", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAA30", Offset = "0x9AE9430", VA = "0x189AEAA30", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA2F0", Offset = "0x9AE8CF0", VA = "0x189AEA2F0")]
		private void KZEQTQNLTJE(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAAB0", Offset = "0x9AE94B0", VA = "0x189AEAAB0", Slot = "6")]
		public void Pause(GNCYHEZRUUA.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAAE0", Offset = "0x9AE94E0", VA = "0x189AEAAE0", Slot = "7")]
		public void SKYRIIBFGMW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAD40", Offset = "0x9AE9740", VA = "0x189AEAD40", Slot = "8")]
		public void XXVJJQPAXON(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9E10", Offset = "0x9AE8810", VA = "0x189AE9E10")]
		private void EWGFALHVYVC(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9AEA910", Offset = "0x9AE9310", VA = "0x189AEA910", Slot = "11")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEADA0", Offset = "0x9AE97A0", VA = "0x189AEADA0")]
		public RFPIPVFFDPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CQUNKMKKLOM : UMTDTSDPBBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float IMFWMARMTST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int FGNVLJJHCDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint DXDWXLJEPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType QKYERFMSQMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo GMRBQJXXSTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int ELCURUIPYRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] ZMNCRHSTBQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo UXGEPYJCNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int RUTVDIOZUYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] SBIKXGBYOJE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HZGSLNWSFPA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9ADA130", Offset = "0x9AD8B30", VA = "0x189ADA130", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA1A0", Offset = "0x9AD8BA0", VA = "0x189ADA1A0")]
		public CQUNKMKKLOM(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA160", Offset = "0x9AD8B60", VA = "0x189ADA160", Slot = "5")]
		public bool RLGCXTJCMVL(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9CB0", Offset = "0x9AD86B0", VA = "0x189AD9CB0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9ADA030", Offset = "0x9AD8A30", VA = "0x189ADA030")]
		internal GJGFXAJBGAB HQUIOOVJFUI(BCQXRUSLGZW a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9E60", Offset = "0x9AD8860", VA = "0x189AD9E60")]
		private static void HEHNGRQZGSK(GJGFXAJBGAB a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class LOXMTEHMHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9440", Offset = "0x9AE7E40", VA = "0x189AE9440")]
		public static GUPOFWBVNMS UJQNGJNIACK(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AE93F0", Offset = "0x9AE7DF0", VA = "0x189AE93F0")]
		public static PlayerId ToPlayerId(this GUPOFWBVNMS player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class RRNetworkBehavior : MonoBehaviour, POUEUUSEPBA, SABLHYKIBLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool YRMVBTSNUXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private RRNetworkView WCZNQTDEGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private List<XVBFOFGHFVF> UUIFIEPWAWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool HVDDWUXTAKB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId RVSFQJHGGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC310", Offset = "0x9AEAD10", VA = "0x189AEC310")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId NTZCCDPYCXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC310", Offset = "0x9AEAD10", VA = "0x189AEC310", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView PEYTLAHKVZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC390", Offset = "0x9AEAD90", VA = "0x189AEC390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView HMUNBSXVCEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC390", Offset = "0x9AEAD90", VA = "0x189AEC390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GUPOFWBVNMS BDJAMVHZXVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC490", Offset = "0x9AEAE90", VA = "0x189AEC490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public GUPOFWBVNMS QDUDBVDWRMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC7F0", Offset = "0x9AEB1F0", VA = "0x189AEC7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PZUILKNXUOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC5F0", Offset = "0x9AEAFF0", VA = "0x189AEC5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool XBNINZGZMZA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC760", Offset = "0x9AEB160", VA = "0x189AEC760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool UVHZJNHXWPW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC240", Offset = "0x9AEAC40", VA = "0x189AEC240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool JXQPEVTYUBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC520", Offset = "0x9AEAF20", VA = "0x189AEC520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool VIQCPVWISLW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC240", Offset = "0x9AEAC40", VA = "0x189AEC240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool ZRRMNTACRAU
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC2C0", Offset = "0x9AEACC0", VA = "0x189AEC2C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string UWUZMUMWHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC400", Offset = "0x9AEAE00", VA = "0x189AEC400", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ZQNBLGXVZKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC1C0", Offset = "0x9AEABC0", VA = "0x189AEC1C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<GUPOFWBVNMS> IEZVBRTJJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC090", Offset = "0x9AEAA90", VA = "0x189AEC090")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC880", Offset = "0x9AEB280", VA = "0x189AEC880")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBFF0", Offset = "0x9AEA9F0", VA = "0x189AEBFF0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBBB0", Offset = "0x9AEA5B0", VA = "0x189AEBBB0")]
		private void MTIKXSHHLGW(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBBF0", Offset = "0x9AEA5F0", VA = "0x189AEBBF0", Slot = "9")]
		public void RegisterDestroyHandler(XVBFOFGHFVF handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBE30", Offset = "0x9AEA830", VA = "0x189AEBE30", Slot = "10")]
		public void UnregisterDestroyHandler(XVBFOFGHFVF handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AEBBD0", Offset = "0x9AEA5D0", VA = "0x189AEBBD0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class ZSIERAIPISI
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, GUPOFWBVNMS targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, GUPOFWBVNMS targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, GUPOFWBVNMS newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[CompilerGenerated]
		private static InstantiateCallback XMIWQMLYGIQ;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback YJENITIPPLX
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5420", Offset = "0x9AF3E20", VA = "0x189AF5420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9AF48C0", Offset = "0x9AF32C0", VA = "0x189AF48C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback EPMKYBYODRT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4170", Offset = "0x9AF2B70", VA = "0x189AF4170")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4CB0", Offset = "0x9AF36B0", VA = "0x189AF4CB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback CZPBBOTTYGT
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9AF42F0", Offset = "0x9AF2CF0", VA = "0x189AF42F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4680", Offset = "0x9AF3080", VA = "0x189AF4680")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback QYNEQGAQVMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4F80", Offset = "0x9AF3980", VA = "0x189AF4F80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AF45C0", Offset = "0x9AF2FC0", VA = "0x189AF45C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback OHNVDQUOGSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4230", Offset = "0x9AF2C30", VA = "0x189AF4230")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4500", Offset = "0x9AF2F00", VA = "0x189AF4500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback PTWNGIKGDZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4800", Offset = "0x9AF3200", VA = "0x189AF4800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5040", Offset = "0x9AF3A40", VA = "0x189AF5040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback RRUFJHUAESH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9AF5210", Offset = "0x9AF3C10", VA = "0x189AF5210")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4D70", Offset = "0x9AF3770", VA = "0x189AF4D70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler QTYWCUMEUNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4E30", Offset = "0x9AF3830", VA = "0x189AF4E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9AF43B0", Offset = "0x9AF2DB0", VA = "0x189AF43B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler IQPIQXWPTAC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x9AF40B0", Offset = "0x9AF2AB0", VA = "0x189AF40B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x9AF4740", Offset = "0x9AF3140", VA = "0x189AF4740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9AF52D0", Offset = "0x9AF3CD0", VA = "0x189AF52D0")]
		public static void YTKNYJTYHMG([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4AD0", Offset = "0x9AF34D0", VA = "0x189AF4AD0")]
		public static void KILMVXJSHQM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4470", Offset = "0x9AF2E70", VA = "0x189AF4470")]
		public static void CONCWJYQWVF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4EF0", Offset = "0x9AF38F0", VA = "0x189AF4EF0")]
		public static void SIPRCYBBFNI(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5390", Offset = "0x9AF3D90", VA = "0x189AF5390")]
		public static void YZRXOUDIKCZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4B60", Offset = "0x9AF3560", VA = "0x189AF4B60")]
		public static void LIOOUEVFMER(RRNetworkView a, string b, GUPOFWBVNMS c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9AF4980", Offset = "0x9AF3380", VA = "0x189AF4980")]
		public static void JACOEULHDRS(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9AF5100", Offset = "0x9AF3B00", VA = "0x189AF5100")]
		public static void UCNXWCSRTIE(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class WJLOIEKCVRR
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9AF37F0", Offset = "0x9AF21F0", VA = "0x189AF37F0")]
		[CanBeNull]
		private static bool BMZPGQINCZX(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3910", Offset = "0x9AF2310", VA = "0x189AF3910")]
		[CanBeNull]
		public static Component OXVDWLJIXDH(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x4151050", Offset = "0x414FA50", VA = "0x184151050")]
		[CanBeNull]
		public static a OXVDWLJIXDH<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x4150FE0", Offset = "0x414F9E0", VA = "0x184150FE0")]
		[CanBeNull]
		public static b IGMAAVOKYXX<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4151170", Offset = "0x414FB70", VA = "0x184151170")]
		public static bool UZQHSCWBQXO<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9AF38A0", Offset = "0x9AF22A0", VA = "0x189AF38A0")]
		[CanBeNull]
		public static RRNetworkView OWCVYZNNUDG(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static RRNetworkHandler OUAYFCUQLSG;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9AEC9F0", Offset = "0x9AEB3F0", VA = "0x189AEC9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9AECB80", Offset = "0x9AEB580", VA = "0x189AECB80")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEC9B0", Offset = "0x9AEB3B0", VA = "0x189AEC9B0")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RegisterService(typeof(LCYABLRDLAB), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class LCYABLRDLAB : YJNLRHPFYDO, SZDUQTANYAQ, JQVAGBYEMGQ, PVENKBCWRBE, HMEVPLUVQPI, JIKZVPRDGWM, ORELWRZKHYY
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class XTGCFERSGLX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int IKENXQDKCWD;

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public XTGCFERSGLX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x9AF39F0", Offset = "0x9AF23F0", VA = "0x189AF39F0")]
			internal object EPEZXBNODKU((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static Log ABAOGDUAPVW;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private static Log HVTEITVRFQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[DependsOn]
		private YVCUWVTQVMT OBLOEIINDNG;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static GZKXLBOYSEQ JKZTKTMFTNF;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static Dictionary<int, HashSet<int>> GNSFQQUWXPI;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static Dictionary<int, int> BGDZOIWFBXN;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private static readonly List<(GameObject GameObject, int ParentCount)> VMWPINYVDDA;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private static readonly List<GameObject> HCKCFZKDYED;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private static List<int> YRFOUSOAQBD;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private static readonly List<RRNetworkView> SLLBDHMCKFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private LLXBIEQMARQ TGNUBRRGGVX;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private static readonly OGEXSFQHDBH GHGWAZHKYPP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly OGEXSFQHDBH CAZGYJOKRUU;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEFF0", Offset = "0x9ADD9F0", VA = "0x189ADEFF0", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFCE0", Offset = "0x9ADE6E0", VA = "0x189ADFCE0", Slot = "9")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEEE0", Offset = "0x9ADD8E0", VA = "0x189ADEEE0", Slot = "10")]
		public void InitExternal(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4D50", Offset = "0x9AE3750", VA = "0x189AE4D50", Slot = "11")]
		public void ZCZVBWKAWEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFC70", Offset = "0x9ADE670", VA = "0x189ADFC70")]
		private void LCJLWNFPMUC(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3020", Offset = "0x9AE1A20", VA = "0x189AE3020")]
		public GameObject WBOZGMFZHSH(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0320", Offset = "0x9ADED20", VA = "0x189AE0320")]
		public GameObject OOYRFCOXKGL(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3C80", Offset = "0x9AE2680", VA = "0x189AE3C80")]
		public GameObject XPBZTHYAWMK(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0190", Offset = "0x9ADEB90", VA = "0x189AE0190")]
		public GameObject OBKSKFBDQPO(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEB90", Offset = "0x9ADD590", VA = "0x189ADEB90", Slot = "6")]
		public void GLHZKOZFRUA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2600", Offset = "0x9AE1000", VA = "0x189AE2600")]
		public void RTVIFYGQPAV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEED0", Offset = "0x9ADD8D0", VA = "0x189ADEED0", Slot = "7")]
		public void IAKPRARYORB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEBA0", Offset = "0x9ADD5A0", VA = "0x189ADEBA0", Slot = "4")]
		public GameObject[] HCXIQWWVQQG(IList<VTRNOXHLFIB> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0D90", Offset = "0x9ADF790", VA = "0x189AE0D90", Slot = "5")]
		public void QBKQUNPABGZ(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD980", Offset = "0x9ADC380", VA = "0x189ADD980")]
		public void BSFTKHVBDMT(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE8B0", Offset = "0x9ADD2B0", VA = "0x189ADE8B0")]
		private void EWGFALHVYVC(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE710", Offset = "0x9ADD110", VA = "0x189ADE710")]
		private void EQIAKQNPGQG(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0B50", Offset = "0x9ADF550", VA = "0x189AE0B50")]
		private void PPYRBJBNULG(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD130", Offset = "0x9ADBB30", VA = "0x189ADD130")]
		private void AAGTYPAYSCE(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF690", Offset = "0x9ADE090", VA = "0x189ADF690")]
		private void KOEDVMTWSXC(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4AE0", Offset = "0x9AE34E0", VA = "0x189AE4AE0")]
		private void YDEBWPUIPZK(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1160", Offset = "0x9ADFB60", VA = "0x189AE1160")]
		private void QQJTYZXSNHQ(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFA80", Offset = "0x9ADE480", VA = "0x189ADFA80")]
		private GameObject KROXVNJDXXP(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2940", Offset = "0x9AE1340", VA = "0x189AE2940")]
		private GameObject VFKNADAVPTV(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9AE01C0", Offset = "0x9ADEBC0", VA = "0x189AE01C0")]
		private static GameObject OIKAWOLNQNL(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF480", Offset = "0x9ADDE80", VA = "0x189ADF480")]
		private static GameObject KECIOMGKCZC(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0080", Offset = "0x9ADEA80", VA = "0x189AE0080")]
		private static void MHIQZSGWXOH(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDF60", Offset = "0x9ADC960", VA = "0x189ADDF60")]
		private GameObject[] EFWHCPLHZAW(IList<VTRNOXHLFIB> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDA60", Offset = "0x9ADC460", VA = "0x189ADDA60")]
		private GameObject[] CIMEQGHHMXO(InstantiateParameters[] a, int b, GUPOFWBVNMS c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0740", Offset = "0x9ADF140", VA = "0x189AE0740")]
		private GameObject PLHZKFQVYTU([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2920", Offset = "0x9AE1320", VA = "0x189AE2920")]
		private static bool VBUVOLCYHNV(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE3F00", Offset = "0x9AE2900", VA = "0x189AE3F00")]
		private void XTASNDMKFLB(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9AE1740", Offset = "0x9AE0140", VA = "0x189AE1740")]
		private void RNDKRIGINKH(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD3B0", Offset = "0x9ADBDB0", VA = "0x189ADD3B0")]
		private static void ASHMDYKVONA(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2770", Offset = "0x9AE1170", VA = "0x189AE2770")]
		private void TOPXLLCCHGG(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF3E0", Offset = "0x9ADDDE0", VA = "0x189ADF3E0")]
		private static int JDGXRVDULSK(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE28C0", Offset = "0x9AE12C0", VA = "0x189AE28C0")]
		private void TXWRTYLAPRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4E40", Offset = "0x9AE3840", VA = "0x189AE4E40")]
		private void ZVLIMINLNOS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE02C0", Offset = "0x9ADECC0", VA = "0x189AE02C0")]
		private static int OLBGKOBTFOK(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD7A0", Offset = "0x9ADC1A0", VA = "0x189ADD7A0")]
		private static int[] AXGRFPLDSZZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD880", Offset = "0x9ADC280", VA = "0x189ADD880")]
		private static int[] BABGWHLIVMX(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0700", Offset = "0x9ADF100", VA = "0x189AE0700")]
		private void OnMasterClientSwitched(GUPOFWBVNMS newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE31F0", Offset = "0x9AE1BF0", VA = "0x189AE31F0")]
		private void XJVWXWJMEZF(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0420", Offset = "0x9ADEE20", VA = "0x189AE0420")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDD20", Offset = "0x9ADC720", VA = "0x189ADDD20")]
		private void CQDMMEGIIGD(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE4CB0", Offset = "0x9AE36B0", VA = "0x189AE4CB0")]
		private static void YZTURCVVIRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AE2670", Offset = "0x9AE1070", VA = "0x189AE2670")]
		private void SJSYNPBZAKZ(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0030", Offset = "0x9ADEA30", VA = "0x189AE0030", Slot = "12")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xF854D0", Offset = "0xF83ED0", VA = "0x180F854D0", Slot = "13")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public LCYABLRDLAB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RegisterService(typeof(LOVWORLBHDB), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class LOVWORLBHDB : SZDUQTANYAQ, JQVAGBYEMGQ, UZVLDSEDVVI, YWYIFNCKTFV, FGDXYNTAWZN
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
			[Cpp2IlInjected.Address(RVA = "0x111A3F0", Offset = "0x1118DF0", VA = "0x18111A3F0")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2960", Offset = "0x9AF1360", VA = "0x189AF2960")]
			public object NNCONQKLNON(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class VETNBUJHDIQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public FieldInfo VKMOBYHNIYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Func<MonoBehaviour, object> EQQCJPAWXMR;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public VETNBUJHDIQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9AF36E0", Offset = "0x9AF20E0", VA = "0x189AF36E0")]
			internal RpcMethodInfo KJLJGRXJJTN(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x75843E0", Offset = "0x7582DE0", VA = "0x1875843E0")]
			internal object KJGCJLDMAIE(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class VEYTZBDEMTZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Func<MonoBehaviour, object> UYGYZSHXBLU;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public VEYTZBDEMTZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9AF37A0", Offset = "0x9AF21A0", VA = "0x189AF37A0")]
			internal RpcMethodInfo KIVOOXPRHLM(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class PIAOBGEZDVH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Type XWPYKUUCLVN;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PIAOBGEZDVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9800", Offset = "0x9AE8200", VA = "0x189AE9800")]
			internal bool RWXQJELPVUL(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static Dictionary<string, int> WBBIFABRRSD;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static List<string> DASQIHRNFDU;

		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private static int KEYLTLUMEUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private NTFPIIKJPQM GQTHJLVMVIX;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Stopwatch DCJBLAWRQEX;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private static Dictionary<MethodInfo, ParameterInfo[]> RIVTBWSALYK;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> YBLOXDESVFL;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6500", Offset = "0x9AE4F00", VA = "0x189AE6500", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6040", Offset = "0x9AE4A40", VA = "0x189AE6040")]
		private void HKUKVKPRIGM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6600", Offset = "0x9AE5000", VA = "0x189AE6600", Slot = "10")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xF854D0", Offset = "0xF83ED0", VA = "0x180F854D0", Slot = "11")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6750", Offset = "0x9AE5150", VA = "0x189AE6750", Slot = "5")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5780", Offset = "0x9AE4180", VA = "0x189AE5780")]
		public static bool BMZAPEEVLQJ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5A90", Offset = "0x9AE4490", VA = "0x189AE5A90")]
		public static bool FWODXWNGFDT(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5810", Offset = "0x9AE4210", VA = "0x189AE5810")]
		private void EWGFALHVYVC(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9150", Offset = "0x9AE7B50", VA = "0x189AE9150", Slot = "9")]
		public string ZRFMQLPFQVB(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8F90", Offset = "0x9AE7990", VA = "0x189AE8F90", Slot = "8")]
		public void XUAFPWBGJQM(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AE89E0", Offset = "0x9AE73E0", VA = "0x189AE89E0", Slot = "6")]
		public void VJAJIYGWGXS(ViewId a, string b, GUPOFWBVNMS c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8F60", Offset = "0x9AE7960", VA = "0x189AE8F60", Slot = "7")]
		public void VJAJIYGWGXS(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8AB0", Offset = "0x9AE74B0", VA = "0x189AE8AB0")]
		private void VJAJIYGWGXS(ViewId a, string b, RpcTarget c, GUPOFWBVNMS d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6AB0", Offset = "0x9AE54B0", VA = "0x189AE6AB0")]
		private void UFQHLOHTKYX(ViewId a, string b, GUPOFWBVNMS c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AE5B80", Offset = "0x9AE4580", VA = "0x189AE5B80")]
		private static void GNNNDGUJJEV(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9AE68A0", Offset = "0x9AE52A0", VA = "0x189AE68A0")]
		private static bool PSGUZIKOWXG(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AE8120", Offset = "0x9AE6B20", VA = "0x189AE8120")]
		private List<RpcMethodInfo> UOGPASQZPQT(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AE6650", Offset = "0x9AE5050", VA = "0x189AE6650")]
		private static IEnumerable<MethodInfo> JOGDPVRRQGF(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AE9040", Offset = "0x9AE7A40", VA = "0x189AE9040")]
		public static ParameterInfo[] YUJIFSZOFVD(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public LOVWORLBHDB()
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
			[Cpp2IlInjected.Address(RVA = "0x9AECC40", Offset = "0x9AEB640", VA = "0x189AECC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9AECBC0", Offset = "0x9AEB5C0", VA = "0x189AECBC0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class RRNetworkView : MonoBehaviour, ZHBFLYLVHWX, CALFCIRMQAE, ZZKPJRDXOQR, BLJXLPZXGFN, RRFCPEUOZAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[RegisterService(typeof(YVCUWVTQVMT), new string[] { })]
		internal class PTZWLAYNKYM : SZDUQTANYAQ, JQVAGBYEMGQ, YVCUWVTQVMT
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Dictionary<int, RRNetworkView> AQAHHLHRQSJ;

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9840", Offset = "0x9AE8240", VA = "0x189AE9840", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9840", Offset = "0x9AE8240", VA = "0x189AE9840", Slot = "5")]
			public void LUFANJQDLDU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x9AE9850", Offset = "0x9AE8250", VA = "0x189AE9850", Slot = "6")]
			public void QOILXPFJPZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PTZWLAYNKYM()
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
		private sealed class PDHGCPSPZDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int VSIIUTBMDQX;

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public PDHGCPSPZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x9AE97A0", Offset = "0x9AE81A0", VA = "0x189AE97A0")]
			internal bool RHFJWRQIOFT(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static OGEXSFQHDBH LAKPWNGLAJT;

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
		private bool RGMTHVVNLCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool OXJTQGTWWVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private bool JTFVROIVZLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int DIKYDEYOGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool MOBELXVJSHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int NMNMCTMDMES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private GUPOFWBVNMS QDUDBVDWRMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private GUPOFWBVNMS TXGNVMBOQFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private bool? TUPXAFRKJSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool QWHZJADOPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		internal bool KCZUANMGUIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		internal MonoBehaviour[] BMLEMFDASTN;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly Log MOWRKWQNRFG;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> AQAHHLHRQSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9AEDAC0", Offset = "0x9AEC4C0", VA = "0x189AEDAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId NTZCCDPYCXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9AF12D0", Offset = "0x9AEFCD0", VA = "0x189AF12D0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId MHTKJYYOENX
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9AF12D0", Offset = "0x9AEFCD0", VA = "0x189AF12D0", Slot = "6")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId RVSFQJHGGHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9AF12D0", Offset = "0x9AEFCD0", VA = "0x189AF12D0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int MBGXTQLUOOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int VYNZUIFMBZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId VLFXFIUMKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1140", Offset = "0x9AEFB40", VA = "0x189AF1140")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool SYSYBVFJZYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NYQENZWOZUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1150", Offset = "0x9AEFB50", VA = "0x189AF1150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool AJJZLFXXIQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xD6E8A0", Offset = "0xD6D2A0", VA = "0x180D6E8A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xD6EFC0", Offset = "0xD6D9C0", VA = "0x180D6EFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int MYLFDHGBIND
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD60890", Offset = "0xD5F290", VA = "0x180D60890")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int XYDOXXGIYYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9AF10E0", Offset = "0x9AEFAE0", VA = "0x189AF10E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public GUPOFWBVNMS GBROGOAMMCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9AF12E0", Offset = "0x9AEFCE0", VA = "0x189AF12E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public GUPOFWBVNMS ANPIILVVZLT
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9AF10B0", Offset = "0x9AEFAB0", VA = "0x189AF10B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public GUPOFWBVNMS BDJAMVHZXVM
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9AF10B0", Offset = "0x9AEFAB0", VA = "0x189AF10B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public GUPOFWBVNMS GARNKJAINUG
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9AF10B0", Offset = "0x9AEFAB0", VA = "0x189AF10B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool EPMONFHYLWC
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1220", Offset = "0x9AEFC20", VA = "0x189AF1220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int CMRSKAQAKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1110", Offset = "0x9AEFB10", VA = "0x189AF1110")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] NUJKXLOIVRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool PZUILKNXUOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1310", Offset = "0x9AEFD10", VA = "0x189AF1310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool XDFAJSWBGDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x9AF12A0", Offset = "0x9AEFCA0", VA = "0x189AF12A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IANMPCTXZDV
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xFCDF20", Offset = "0xFCC920", VA = "0x180FCDF20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xFCD190", Offset = "0xFCBB90", VA = "0x180FCD190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KHYHTOJFTMT
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xFCC790", Offset = "0xFCB190", VA = "0x180FCC790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> FEWMHFOXRTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0F40", Offset = "0x9AEF940", VA = "0x189AF0F40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9AF14D0", Offset = "0x9AEFED0", VA = "0x189AF14D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<GUPOFWBVNMS> DHVJEJEBAPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0CB0", Offset = "0x9AEF6B0", VA = "0x189AF0CB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0C00", Offset = "0x9AEF600", VA = "0x189AF0C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<GUPOFWBVNMS> GSOEYXCIHRL
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0CB0", Offset = "0x9AEF6B0", VA = "0x189AF0CB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0C00", Offset = "0x9AEF600", VA = "0x189AF0C00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> PCENOZZATEY
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0B50", Offset = "0x9AEF550", VA = "0x189AF0B50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9AEE9D0", Offset = "0x9AED3D0", VA = "0x189AEE9D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> PUODUHQPTNG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0B50", Offset = "0x9AEF550", VA = "0x189AF0B50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9AEE9D0", Offset = "0x9AED3D0", VA = "0x189AEE9D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> WEDXZCJJLCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0FF0", Offset = "0x9AEF9F0", VA = "0x189AF0FF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1580", Offset = "0x9AEFF80", VA = "0x189AF1580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action NTKLWWSMLIG
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9AF0E90", Offset = "0x9AEF890", VA = "0x189AF0E90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF1420", Offset = "0x9AEFE20", VA = "0x189AF1420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0A90", Offset = "0x9AEF490", VA = "0x189AF0A90")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9AED590", Offset = "0x9AEBF90", VA = "0x189AED590")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9AED880", Offset = "0x9AEC280", VA = "0x189AED880")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9AED7D0", Offset = "0x9AEC1D0", VA = "0x189AED7D0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEED0", Offset = "0x9AED8D0", VA = "0x189AEEED0")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEC70", Offset = "0x9AED670", VA = "0x189AEEC70")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE590", Offset = "0x9AECF90", VA = "0x189AEE590")]
		public static void OnPlayerJoinedRoom(GUPOFWBVNMS newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9AED9F0", Offset = "0x9AEC3F0", VA = "0x189AED9F0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA50", Offset = "0x9AEC450", VA = "0x189AEDA50")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9AED650", Offset = "0x9AEC050", VA = "0x189AED650")]
		private void GHQGNQHUZYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9AED1F0", Offset = "0x9AEBBF0", VA = "0x189AED1F0")]
		public bool CreatedBy(GUPOFWBVNMS player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9AF08A0", Offset = "0x9AEF2A0", VA = "0x189AF08A0")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0840", Offset = "0x9AEF240", VA = "0x189AF0840")]
		public void TransferOwnership(GUPOFWBVNMS newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDD30", Offset = "0x9AEC730", VA = "0x189AEDD30", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDCD0", Offset = "0x9AEC6D0", VA = "0x189AEDCD0")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9AECDB0", Offset = "0x9AEB7B0", VA = "0x189AECDB0")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9AED310", Offset = "0x9AEBD10", VA = "0x189AED310")]
		private void DVKRPIGCUXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1364240", Offset = "0x1362C40", VA = "0x181364240")]
		internal void CPOLDALVSZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0D60", Offset = "0x9AEF760", VA = "0x189AF0D60", Slot = "7")]
		private void YDVGRWOIJVU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE340", Offset = "0x9AECD40", VA = "0x189AEE340")]
		internal bool NMJLLUVTEZH(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE450", Offset = "0x9AECE50", VA = "0x189AEE450")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE970", Offset = "0x9AED370", VA = "0x189AEE970")]
		internal void QXIMYPKAEFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDAB0", Offset = "0x9AEC4B0", VA = "0x189AEDAB0")]
		private void HMUGXRXZLGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDF90", Offset = "0x9AEC990", VA = "0x189AEDF90")]
		internal void KAYGQTZCDTN(GUPOFWBVNMS a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEE30", Offset = "0x9AED830", VA = "0x189AEEE30")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEF80", Offset = "0x9AED980", VA = "0x189AEEF80")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE3B0", Offset = "0x9AECDB0", VA = "0x189AEE3B0")]
		private void OXVCZSQMRYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDEA0", Offset = "0x9AEC8A0", VA = "0x189AEDEA0")]
		private void JELCPUPDYJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEBE0", Offset = "0x9AED5E0", VA = "0x189AEEBE0")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEB50", Offset = "0x9AED550", VA = "0x189AEEB50")]
		public void RPC(string methodName, GUPOFWBVNMS targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEE80", Offset = "0x9AED880", VA = "0x189AEEE80")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9AECE00", Offset = "0x9AEB800", VA = "0x189AECE00", Slot = "9")]
		public void Bake(LRDITXVMCHW context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE900", Offset = "0x9AED300", VA = "0x189AEE900")]
		private static void QLHXZJESANE(GUPOFWBVNMS a, [Out] GUPOFWBVNMS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9AEE050", Offset = "0x9AECA50", VA = "0x189AEE050")]
		private static void MTKBGLSRYMV(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9AED270", Offset = "0x9AEBC70", VA = "0x189AED270")]
		private static RPCInfo DLQDWNJHZQQ(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDB10", Offset = "0x9AEC510", VA = "0x189AEDB10")]
		private static void IZBWJAHHZES(RRNetworkView a, Delegate b, GUPOFWBVNMS c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDBF0", Offset = "0x9AEC5F0", VA = "0x189AEDBF0")]
		private static void IZBWJAHHZES(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9AECE70", Offset = "0x9AEB870", VA = "0x189AECE70")]
		private static void COEIUYINKWF(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9AEEA80", Offset = "0x9AED480", VA = "0x189AEEA80")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9AED730", Offset = "0x9AEC130", VA = "0x189AED730")]
		private static bool GUALXVWPSHU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF660", Offset = "0x9AEE060", VA = "0x189AEF660", Slot = "26")]
		public void RpcAll(KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6940", Offset = "0x3EA5340", VA = "0x183EA6940", Slot = "10")]
		public void RpcAll<T1>(KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6220", Offset = "0x3EA4C20", VA = "0x183EA6220", Slot = "11")]
		public void RpcAll<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3EA8B90", Offset = "0x3EA7590", VA = "0x183EA8B90", Slot = "27")]
		public void RpcAll<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6410", Offset = "0x3EA4E10", VA = "0x183EA6410", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6F70", Offset = "0x3EA5970", VA = "0x183EA6F70", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9040", Offset = "0x3EA7A40", VA = "0x183EA9040", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6AB0", Offset = "0x3EA54B0", VA = "0x183EA6AB0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3EBD8D0", Offset = "0x3EBC2D0", VA = "0x183EBD8D0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA9470", Offset = "0x3EA7E70", VA = "0x183EA9470", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7CD0", Offset = "0x3EA66D0", VA = "0x183EA7CD0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2440", Offset = "0x3EC0E40", VA = "0x183EC2440", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3EBAE90", Offset = "0x3EB9890", VA = "0x183EBAE90", Slot = "14")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3EAC2D0", Offset = "0x3EAACD0", VA = "0x183EAC2D0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3EA74F0", Offset = "0x3EA5EF0", VA = "0x183EA74F0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF430", Offset = "0x9AEDE30", VA = "0x189AEF430", Slot = "36")]
		public void RpcAll(KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3EBBB90", Offset = "0x3EBA590", VA = "0x183EBBB90", Slot = "37")]
		public void RpcAll<T1>(KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3EBB540", Offset = "0x3EB9F40", VA = "0x183EBB540", Slot = "38")]
		public void RpcAll<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3EA84F0", Offset = "0x3EA6EF0", VA = "0x183EA84F0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8460", Offset = "0x3EB6E60", VA = "0x183EB8460", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7DD0", Offset = "0x3EB67D0", VA = "0x183EB7DD0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3EB6FD0", Offset = "0x3EB59D0", VA = "0x183EB6FD0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3EB5740", Offset = "0x3EB4140", VA = "0x183EB5740", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB43E0", Offset = "0x3EB2DE0", VA = "0x183EB43E0", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2E70", Offset = "0x3EB1870", VA = "0x183EB2E70", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB2270", Offset = "0x3EB0C70", VA = "0x183EB2270", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB09C0", Offset = "0x3EAF3C0", VA = "0x183EB09C0", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE110", Offset = "0x3EACB10", VA = "0x183EAE110", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD1C0", Offset = "0x3EABBC0", VA = "0x183EAD1C0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3EAB260", Offset = "0x3EA9C60", VA = "0x183EAB260", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF300", Offset = "0x9AEDD00", VA = "0x189AEF300", Slot = "51")]
		public void RpcAllViaServer(KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5D50", Offset = "0x3EA4750", VA = "0x183EA5D50", Slot = "52")]
		public void RpcAllViaServer<T1>(KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5EE0", Offset = "0x3EA48E0", VA = "0x183EA5EE0", Slot = "15")]
		public void RpcAllViaServer<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3EA57F0", Offset = "0x3EA41F0", VA = "0x183EA57F0", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5410", Offset = "0x3EA3E10", VA = "0x183EA5410", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4F70", Offset = "0x3EA3970", VA = "0x183EA4F70", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4A10", Offset = "0x3EA3410", VA = "0x183EA4A10", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3EA43F0", Offset = "0x3EA2DF0", VA = "0x183EA43F0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3EA3D10", Offset = "0x3EA2710", VA = "0x183EA3D10", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA3570", Offset = "0x3EA1F70", VA = "0x183EA3570", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2D10", Offset = "0x3EA1710", VA = "0x183EA2D10", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA23F0", Offset = "0x3EA0DF0", VA = "0x183EA23F0", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1A00", Offset = "0x3EA0400", VA = "0x183EA1A00", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0F50", Offset = "0x3E9F950", VA = "0x183EA0F50", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA03C0", Offset = "0x3E9EDC0", VA = "0x183EA03C0", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF1D0", Offset = "0x9AEDBD0", VA = "0x189AEF1D0", Slot = "65")]
		public void RpcAllViaServer(KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5D50", Offset = "0x3EA4750", VA = "0x183EA5D50", Slot = "66")]
		public void RpcAllViaServer<T1>(KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5B00", Offset = "0x3EA4500", VA = "0x183EA5B00", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3EA57F0", Offset = "0x3EA41F0", VA = "0x183EA57F0", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5410", Offset = "0x3EA3E10", VA = "0x183EA5410", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4F70", Offset = "0x3EA3970", VA = "0x183EA4F70", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3EA4A10", Offset = "0x3EA3410", VA = "0x183EA4A10", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3EA43F0", Offset = "0x3EA2DF0", VA = "0x183EA43F0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3EA3D10", Offset = "0x3EA2710", VA = "0x183EA3D10", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3EA3570", Offset = "0x3EA1F70", VA = "0x183EA3570", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2D10", Offset = "0x3EA1710", VA = "0x183EA2D10", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA23F0", Offset = "0x3EA0DF0", VA = "0x183EA23F0", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1A00", Offset = "0x3EA0400", VA = "0x183EA1A00", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0F50", Offset = "0x3E9F950", VA = "0x183EA0F50", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3EA03C0", Offset = "0x3E9EDC0", VA = "0x183EA03C0", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF00F0", Offset = "0x9AEEAF0", VA = "0x189AF00F0", Slot = "80")]
		public void RpcOthers(KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBDB0", Offset = "0x3EFA7B0", VA = "0x183EFBDB0", Slot = "16")]
		public void RpcOthers<T1>(KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3F02360", Offset = "0x3F00D60", VA = "0x183F02360", Slot = "81")]
		public void RpcOthers<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBB60", Offset = "0x3EFA560", VA = "0x183EFBB60", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3F05230", Offset = "0x3F03C30", VA = "0x183F05230", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3F00C30", Offset = "0x3EFF630", VA = "0x183F00C30", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3F03100", Offset = "0x3F01B00", VA = "0x183F03100", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3F00060", Offset = "0x3EFEA60", VA = "0x183F00060", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3F03D70", Offset = "0x3F02770", VA = "0x183F03D70", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF180", Offset = "0x3EFDB80", VA = "0x183EFF180", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3F03870", Offset = "0x3F02270", VA = "0x183F03870", Slot = "17")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDFA0", Offset = "0x3EFC9A0", VA = "0x183EFDFA0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD590", Offset = "0x3EFBF90", VA = "0x183EFD590", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCAB0", Offset = "0x3EFB4B0", VA = "0x183EFCAB0", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBF00", Offset = "0x3EFA900", VA = "0x183EFBF00", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0240", Offset = "0x9AEEC40", VA = "0x189AF0240", Slot = "93")]
		public void RpcOthers(KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3F020C0", Offset = "0x3F00AC0", VA = "0x183F020C0", Slot = "94")]
		public void RpcOthers<T1>(KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F01F00", Offset = "0x3F00900", VA = "0x183F01F00", Slot = "95")]
		public void RpcOthers<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3F014F0", Offset = "0x3EFFEF0", VA = "0x183F014F0", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3F01C50", Offset = "0x3F00650", VA = "0x183F01C50", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F02870", Offset = "0x3F01270", VA = "0x183F02870", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F02B80", Offset = "0x3F01580", VA = "0x183F02B80", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F00060", Offset = "0x3EFEA60", VA = "0x183F00060", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF950", Offset = "0x3EFE350", VA = "0x183EFF950", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3EFF180", Offset = "0x3EFDB80", VA = "0x183EFF180", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3EFE8F0", Offset = "0x3EFD2F0", VA = "0x183EFE8F0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3EFDFA0", Offset = "0x3EFC9A0", VA = "0x183EFDFA0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFD590", Offset = "0x3EFBF90", VA = "0x183EFD590", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFCAB0", Offset = "0x3EFB4B0", VA = "0x183EFCAB0", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFBF00", Offset = "0x3EFA900", VA = "0x183EFBF00", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFBE0", Offset = "0x9AEE5E0", VA = "0x189AEFBE0", Slot = "108")]
		public void RpcMaster(KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE3B0", Offset = "0x3EDCDB0", VA = "0x183EDE3B0", Slot = "109")]
		public void RpcMaster<T1>(KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE550", Offset = "0x3EDCF50", VA = "0x183EDE550", Slot = "110")]
		public void RpcMaster<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD9C0", Offset = "0x3EDC3C0", VA = "0x183EDD9C0", Slot = "111")]
		public void RpcMaster<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDC20", Offset = "0x3EDC620", VA = "0x183EDDC20", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0AD0", Offset = "0x3EEF4D0", VA = "0x183EF0AD0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3EF2B30", Offset = "0x3EF1530", VA = "0x183EF2B30", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA5E0", Offset = "0x3EE8FE0", VA = "0x183EEA5E0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9390", Offset = "0x3EE7D90", VA = "0x183EE9390", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7F20", Offset = "0x3EE6920", VA = "0x183EE7F20", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3EF0520", Offset = "0x3EEEF20", VA = "0x183EF0520", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3EEFEE0", Offset = "0x3EEE8E0", VA = "0x183EEFEE0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3EE2670", Offset = "0x3EE1070", VA = "0x183EE2670", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EE1770", Offset = "0x3EE0170", VA = "0x183EE1770", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF7F0", Offset = "0x3EDE1F0", VA = "0x183EDF7F0", Slot = "122")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD70", Offset = "0x9AEE770", VA = "0x189AEFD70", Slot = "123")]
		public void RpcMaster(KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE1D0", Offset = "0x3EDCBD0", VA = "0x183EDE1D0", Slot = "124")]
		public void RpcMaster<T1>(KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EEF3F0", Offset = "0x3EEDDF0", VA = "0x183EEF3F0", Slot = "125")]
		public void RpcMaster<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EEEA50", Offset = "0x3EED450", VA = "0x183EEEA50", Slot = "126")]
		public void RpcMaster<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3EECAA0", Offset = "0x3EEB4A0", VA = "0x183EECAA0", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3EF12A0", Offset = "0x3EEFCA0", VA = "0x183EF12A0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB5D0", Offset = "0x3EE9FD0", VA = "0x183EEB5D0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3EE9D10", Offset = "0x3EE8710", VA = "0x183EE9D10", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3EE89B0", Offset = "0x3EE73B0", VA = "0x183EE89B0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3EE7420", Offset = "0x3EE5E20", VA = "0x183EE7420", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3EE6810", Offset = "0x3EE5210", VA = "0x183EE6810", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4290", Offset = "0x3EE2C90", VA = "0x183EE4290", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3450", Offset = "0x3EE1E50", VA = "0x183EE3450", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0810", Offset = "0x3EDF210", VA = "0x183EE0810", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE770", Offset = "0x3EDD170", VA = "0x183EDE770", Slot = "137")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF7D0", Offset = "0x9AEE1D0", VA = "0x189AEF7D0", Slot = "138")]
		public void RpcAuthority(KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3EC7430", Offset = "0x3EC5E30", VA = "0x183EC7430", Slot = "139")]
		public void RpcAuthority<T1>(KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3EC71F0", Offset = "0x3EC5BF0", VA = "0x183EC71F0", Slot = "140")]
		public void RpcAuthority<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3ECE640", Offset = "0x3ECD040", VA = "0x183ECE640", Slot = "141")]
		public void RpcAuthority<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3ECFE80", Offset = "0x3ECE880", VA = "0x183ECFE80", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3EC6E50", Offset = "0x3EC5850", VA = "0x183EC6E50", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3ECAE90", Offset = "0x3EC9890", VA = "0x183ECAE90", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3EC9DE0", Offset = "0x3EC87E0", VA = "0x183EC9DE0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8110", Offset = "0x3EC6B10", VA = "0x183EC8110", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3EDC210", Offset = "0x3EDAC10", VA = "0x183EDC210", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3EDB630", Offset = "0x3EDA030", VA = "0x183EDB630", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD370", Offset = "0x3EDBD70", VA = "0x183EDD370", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3EDCCE0", Offset = "0x3EDB6E0", VA = "0x183EDCCE0", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED63F0", Offset = "0x3ED4DF0", VA = "0x183ED63F0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED4410", Offset = "0x3ED2E10", VA = "0x183ED4410", Slot = "152")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF980", Offset = "0x9AEE380", VA = "0x189AEF980", Slot = "153")]
		public void RpcAuthority(KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3ECDF10", Offset = "0x3ECC910", VA = "0x183ECDF10", Slot = "154")]
		public void RpcAuthority<T1>(KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3ECDB50", Offset = "0x3ECC550", VA = "0x183ECDB50", Slot = "155")]
		public void RpcAuthority<T1, T2>(KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCED0", Offset = "0x3ECB8D0", VA = "0x183ECCED0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3>(KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC900", Offset = "0x3ECB300", VA = "0x183ECC900", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB630", Offset = "0x3ECA030", VA = "0x183ECB630", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3ECA6A0", Offset = "0x3EC90A0", VA = "0x183ECA6A0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3EC94E0", Offset = "0x3EC7EE0", VA = "0x183EC94E0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8AD0", Offset = "0x3EC74D0", VA = "0x183EC8AD0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3EC75E0", Offset = "0x3EC5FE0", VA = "0x183EC75E0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA9F0", Offset = "0x3ED93F0", VA = "0x183EDA9F0", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8FA0", Offset = "0x3ED79A0", VA = "0x183ED8FA0", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8130", Offset = "0x3ED6B30", VA = "0x183ED8130", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3ED5460", Offset = "0x3ED3E60", VA = "0x183ED5460", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED3350", Offset = "0x3ED1D50", VA = "0x183ED3350", Slot = "167")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0390", Offset = "0x9AEED90", VA = "0x189AF0390", Slot = "18")]
		public void RpcPlayer(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3F05790", Offset = "0x3F04190", VA = "0x183F05790", Slot = "19")]
		public void RpcPlayer<T1>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3F06430", Offset = "0x3F04E30", VA = "0x183F06430", Slot = "20")]
		public void RpcPlayer<T1, T2>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F05EB0", Offset = "0x3F048B0", VA = "0x183F05EB0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3F05950", Offset = "0x3F04350", VA = "0x183F05950", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A200", Offset = "0x3F18C00", VA = "0x183F1A200", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F19DF0", Offset = "0x3F187F0", VA = "0x183F19DF0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A590", Offset = "0x3F18F90", VA = "0x183F1A590", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F1AA00", Offset = "0x3F19400", VA = "0x183F1AA00", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F11970", Offset = "0x3F10370", VA = "0x183F11970", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F10D90", Offset = "0x3F0F790", VA = "0x183F10D90", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F06C80", Offset = "0x3F05680", VA = "0x183F06C80", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3F0D8C0", Offset = "0x3F0C2C0", VA = "0x183F0D8C0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F1F460", Offset = "0x3F1DE60", VA = "0x183F1F460", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F08A20", Offset = "0x3F07420", VA = "0x183F08A20", Slot = "176")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0580", Offset = "0x9AEEF80", VA = "0x189AF0580", Slot = "177")]
		public void RpcPlayer(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F05CA0", Offset = "0x3F046A0", VA = "0x183F05CA0", Slot = "178")]
		public void RpcPlayer<T1>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F069C0", Offset = "0x3F053C0", VA = "0x183F069C0", Slot = "24")]
		public void RpcPlayer<T1, T2>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F06680", Offset = "0x3F05080", VA = "0x183F06680", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F08290", Offset = "0x3F06C90", VA = "0x183F08290", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F16B20", Offset = "0x3F15520", VA = "0x183F16B20", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3F154F0", Offset = "0x3F13EF0", VA = "0x183F154F0", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F14BF0", Offset = "0x3F135F0", VA = "0x183F14BF0", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F12F70", Offset = "0x3F11970", VA = "0x183F12F70", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F12440", Offset = "0x3F10E40", VA = "0x183F12440", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F10140", Offset = "0x3F0EB40", VA = "0x183F10140", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F0E6E0", Offset = "0x3F0D0E0", VA = "0x183F0E6E0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3F0CA40", Offset = "0x3F0B440", VA = "0x183F0CA40", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F0BAA0", Offset = "0x3F0A4A0", VA = "0x183F0BAA0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F09A90", Offset = "0x3F08490", VA = "0x183F09A90", Slot = "189")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(GUPOFWBVNMS player, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF090", Offset = "0x9AEDA90", VA = "0x189AEF090", Slot = "190")]
		public void RpcAllBuffered(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0220", Offset = "0x3E9EC20", VA = "0x183EA0220", Slot = "191")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FFD0", Offset = "0x3E9E9D0", VA = "0x183E9FFD0", Slot = "192")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FCB0", Offset = "0x3E9E6B0", VA = "0x183E9FCB0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F8D0", Offset = "0x3E9E2D0", VA = "0x183E9F8D0", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F430", Offset = "0x3E9DE30", VA = "0x183E9F430", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3E9EED0", Offset = "0x3E9D8D0", VA = "0x183E9EED0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E8B0", Offset = "0x3E9D2B0", VA = "0x183E9E8B0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E1D0", Offset = "0x3E9CBD0", VA = "0x183E9E1D0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DA30", Offset = "0x3E9C430", VA = "0x183E9DA30", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D1C0", Offset = "0x3E9BBC0", VA = "0x183E9D1C0", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C890", Offset = "0x3E9B290", VA = "0x183E9C890", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BEA0", Offset = "0x3E9A8A0", VA = "0x183E9BEA0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B3E0", Offset = "0x3E99DE0", VA = "0x183E9B3E0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A850", Offset = "0x3E99250", VA = "0x183E9A850", Slot = "204")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9AEF130", Offset = "0x9AEDB30", VA = "0x189AEF130", Slot = "205")]
		public void RpcAllBuffered(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3EA0220", Offset = "0x3E9EC20", VA = "0x183EA0220", Slot = "206")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FFD0", Offset = "0x3E9E9D0", VA = "0x183E9FFD0", Slot = "207")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3E9FCB0", Offset = "0x3E9E6B0", VA = "0x183E9FCB0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F8D0", Offset = "0x3E9E2D0", VA = "0x183E9F8D0", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E9F430", Offset = "0x3E9DE30", VA = "0x183E9F430", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3E9EED0", Offset = "0x3E9D8D0", VA = "0x183E9EED0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E8B0", Offset = "0x3E9D2B0", VA = "0x183E9E8B0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3E9E1D0", Offset = "0x3E9CBD0", VA = "0x183E9E1D0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E9DA30", Offset = "0x3E9C430", VA = "0x183E9DA30", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3E9D1C0", Offset = "0x3E9BBC0", VA = "0x183E9D1C0", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3E9C890", Offset = "0x3E9B290", VA = "0x183E9C890", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3E9BEA0", Offset = "0x3E9A8A0", VA = "0x183E9BEA0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3E9B3E0", Offset = "0x3E99DE0", VA = "0x183E9B3E0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A850", Offset = "0x3E99250", VA = "0x183E9A850", Slot = "219")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFFB0", Offset = "0x9AEE9B0", VA = "0x189AEFFB0", Slot = "220")]
		public void RpcOthersBuffered(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB9C0", Offset = "0x3EFA3C0", VA = "0x183EFB9C0", Slot = "221")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB770", Offset = "0x3EFA170", VA = "0x183EFB770", Slot = "222")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB460", Offset = "0x3EF9E60", VA = "0x183EFB460", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB080", Offset = "0x3EF9A80", VA = "0x183EFB080", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFABE0", Offset = "0x3EF95E0", VA = "0x183EFABE0", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA680", Offset = "0x3EF9080", VA = "0x183EFA680", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA060", Offset = "0x3EF8A60", VA = "0x183EFA060", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9980", Offset = "0x3EF8380", VA = "0x183EF9980", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF91E0", Offset = "0x3EF7BE0", VA = "0x183EF91E0", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8970", Offset = "0x3EF7370", VA = "0x183EF8970", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8040", Offset = "0x3EF6A40", VA = "0x183EF8040", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7650", Offset = "0x3EF6050", VA = "0x183EF7650", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6B90", Offset = "0x3EF5590", VA = "0x183EF6B90", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6000", Offset = "0x3EF4A00", VA = "0x183EF6000", Slot = "234")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x9AF0050", Offset = "0x9AEEA50", VA = "0x189AF0050", Slot = "235")]
		public void RpcOthersBuffered(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB9C0", Offset = "0x3EFA3C0", VA = "0x183EFB9C0", Slot = "236")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB770", Offset = "0x3EFA170", VA = "0x183EFB770", Slot = "237")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB460", Offset = "0x3EF9E60", VA = "0x183EFB460", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3EFB080", Offset = "0x3EF9A80", VA = "0x183EFB080", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3EFABE0", Offset = "0x3EF95E0", VA = "0x183EFABE0", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA680", Offset = "0x3EF9080", VA = "0x183EFA680", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3EFA060", Offset = "0x3EF8A60", VA = "0x183EFA060", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF9980", Offset = "0x3EF8380", VA = "0x183EF9980", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF91E0", Offset = "0x3EF7BE0", VA = "0x183EF91E0", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8970", Offset = "0x3EF7370", VA = "0x183EF8970", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8040", Offset = "0x3EF6A40", VA = "0x183EF8040", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7650", Offset = "0x3EF6050", VA = "0x183EF7650", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6B90", Offset = "0x3EF5590", VA = "0x183EF6B90", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6000", Offset = "0x3EF4A00", VA = "0x183EF6000", Slot = "249")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, KKZYZMGLXPB.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9AECF80", Offset = "0x9AEB980", VA = "0x189AECF80", Slot = "250")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9AED190", Offset = "0x9AEBB90", VA = "0x189AED190", Slot = "251")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1767FC0", Offset = "0x17669C0", VA = "0x181767FC0")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public static class IIUDVZYGCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD070", Offset = "0x9ADBA70", VA = "0x189ADD070")]
		private static bool CAVGZSJYFZH(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3B33340", Offset = "0x3B31D40", VA = "0x183B33340")]
		[CanBeNull]
		public static a LMMWNAPFWAR<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class SIXMNEQISOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public GUPOFWBVNMS[] XSQEXFIMZZO;

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public SIXMNEQISOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2980", Offset = "0x9AF1380", VA = "0x189AF2980")]
			internal int VJLCIWFSQYO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x9AF2A00", Offset = "0x9AF1400", VA = "0x189AF2A00")]
			internal void VJQJGCZQAJX(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static GUPOFWBVNMS[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		internal int COLGPNWSUIR;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1790", Offset = "0x9AF0190", VA = "0x189AF1790")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1D70", Offset = "0x9AF0770", VA = "0x189AF1D70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2110", Offset = "0x9AF0B10", VA = "0x189AF2110")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2190", Offset = "0x9AF0B90", VA = "0x189AF2190")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9AF28D0", Offset = "0x9AF12D0", VA = "0x189AF28D0")]
		private void WZLJLQKABEH(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x9AF28D0", Offset = "0x9AF12D0", VA = "0x189AF28D0")]
		private void XJVWXWJMEZF(GUPOFWBVNMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1C90", Offset = "0x9AF0690", VA = "0x189AF1C90")]
		private void ENBCMBWSAKN(GUPOFWBVNMS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1640", Offset = "0x9AF0040", VA = "0x189AF1640")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2240", Offset = "0x9AF0C40", VA = "0x189AF2240")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x9AF1BA0", Offset = "0x9AF05A0", VA = "0x189AF1BA0")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0xD21480", Offset = "0xD1FE80", VA = "0x180D21480")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class SLDWUJXYGIV
	{
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2A90", Offset = "0x9AF1490", VA = "0x189AF2A90")]
		public static int DMQEKFKFQJF(this GUPOFWBVNMS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2C20", Offset = "0x9AF1620", VA = "0x189AF2C20")]
		public static void XSEPCYWTVGT(this GUPOFWBVNMS a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public static class YCKHJLBEOKN
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public delegate void RoomPropertyUpdateCallback(Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public delegate void PlayerPropertyUpdateCallback(GUPOFWBVNMS player, Dictionary<object, object> properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback CNLDLDVCBHX
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3CF0", Offset = "0x9AF26F0", VA = "0x189AF3CF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3FF0", Offset = "0x9AF29F0", VA = "0x189AF3FF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback UQKJUHRMIPW
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3DB0", Offset = "0x9AF27B0", VA = "0x189AF3DB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3C30", Offset = "0x9AF2630", VA = "0x189AF3C30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback PAIABSBDZFR
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3B70", Offset = "0x9AF2570", VA = "0x189AF3B70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3E70", Offset = "0x9AF2870", VA = "0x189AF3E70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback QJRWATVFMVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3F30", Offset = "0x9AF2930", VA = "0x189AF3F30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x9AF3AB0", Offset = "0x9AF24B0", VA = "0x189AF3AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal static class HIEVOHUNXXM
	{
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static int RVIGJVGJSWQ;

		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private static int JLRYYIZLMEC;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private static int CFUDSHIJGQC;

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCE00", Offset = "0x9ADB800", VA = "0x189ADCE00")]
		public static void XWDDYPIUEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCA90", Offset = "0x9ADB490", VA = "0x189ADCA90")]
		public static void AFYHRZAFHBX(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCB70", Offset = "0x9ADB570", VA = "0x189ADCB70")]
		public static int OLBGKOBTFOK(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RegisterService(typeof(LLXBIEQMARQ), new string[] { })]
	public class CHVLLTWPYZI : LLXBIEQMARQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private static readonly Dictionary<object, object> OSOBCHGUIYL;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private static readonly Dictionary<object, object> FRZAELMVZQP;

		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static readonly Dictionary<object, object> BXUBEZCPDOD;

		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly OGEXSFQHDBH QPYEPPUEHWN;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static readonly OGEXSFQHDBH TUBODXKIKOU;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static readonly OGEXSFQHDBH XHFNPNGLLPO;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static readonly OGEXSFQHDBH GHGWAZHKYPP;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private static readonly OGEXSFQHDBH CAZGYJOKRUU;

		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int KNBBQJCQUKJ;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9600", Offset = "0x9AD8000", VA = "0x189AD9600", Slot = "4")]
		public bool URLIGQNWGMJ(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x9AD76F0", Offset = "0x9AD60F0", VA = "0x189AD76F0", Slot = "5")]
		public int EVYRCSRFNVL(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9820", Offset = "0x9AD8220", VA = "0x189AD9820", Slot = "6")]
		public bool WEAWXMFIKRO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9AD7200", Offset = "0x9AD5C00", VA = "0x189AD7200", Slot = "7")]
		public bool BAZAESIUMLD(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x9AD93E0", Offset = "0x9AD7DE0", VA = "0x189AD93E0", Slot = "8")]
		public void TGXUBLOBQOM(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9AD8870", Offset = "0x9AD7270", VA = "0x189AD8870", Slot = "9")]
		public bool FHYCNWOTTEI(XHRZBUOCUVQ a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9AD8D10", Offset = "0x9AD7710", VA = "0x189AD8D10", Slot = "10")]
		public bool IFLKTNCYNQV(XHRZBUOCUVQ a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9200", Offset = "0x9AD7C00", VA = "0x189AD9200", Slot = "11")]
		public bool ORSAOWYUTTQ(XHRZBUOCUVQ a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9AD89E0", Offset = "0x9AD73E0", VA = "0x189AD89E0", Slot = "12")]
		public void FJUOTSMJMQW(XHRZBUOCUVQ a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9040", Offset = "0x9AD7A40", VA = "0x189AD9040", Slot = "13")]
		public void LIYPVOUUXQN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x9AD7580", Offset = "0x9AD5F80", VA = "0x189AD7580", Slot = "14")]
		public void CFCHRCNQTHX(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9AD8C30", Offset = "0x9AD7630", VA = "0x189AD8C30", Slot = "15")]
		public void GFULUNZTUEP(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9AD98B0", Offset = "0x9AD82B0", VA = "0x189AD98B0", Slot = "16")]
		public void XIJHBMQHWWK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9AD73C0", Offset = "0x9AD5DC0", VA = "0x189AD73C0", Slot = "17")]
		public void BBNIEFPAXTK(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9AD7B00", Offset = "0x9AD6500", VA = "0x189AD7B00")]
		private static void FEAAQZDJIGB(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9AD8050", Offset = "0x9AD6A50", VA = "0x189AD8050")]
		private static bool FHYCNWOTTEI(Dictionary<object, object> a, GUPOFWBVNMS b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9340", Offset = "0x9AD7D40", VA = "0x189AD9340")]
		private static bool RMTSOXWBYDN(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9AD9740", Offset = "0x9AD8140", VA = "0x189AD9740")]
		private static int VRJKYSVCVFB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public CHVLLTWPYZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RegisterService(typeof(NTFPIIKJPQM), new string[] { })]
	public class EOZWLNISWQI : NTFPIIKJPQM
	{
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static readonly object EPNMWWULTBQ;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static readonly object EPSTUDOJCMZ;

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly object EPCZCJGRAEY;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly object EPIFZQAOJQH;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly object EQIOLXWBEVA;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static Dictionary<object, object> LJLKMBOOWGU;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static Dictionary<object, object> MWYBVCWPLGT;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static OGEXSFQHDBH CMAGIRFUXTM;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly OGEXSFQHDBH FDZZTDEECTF;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC490", Offset = "0x9ADAE90", VA = "0x189ADC490", Slot = "4")]
		public void XUAFPWBGJQM(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9ADBF90", Offset = "0x9ADA990", VA = "0x189ADBF90", Slot = "5")]
		public bool VERZXISKZKE(XHRZBUOCUVQ a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9ADB8C0", Offset = "0x9ADA2C0", VA = "0x189ADB8C0", Slot = "6")]
		public void ILTTIKLBGOW(ViewId a, string b, RpcTarget c, GUPOFWBVNMS d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public EOZWLNISWQI()
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
