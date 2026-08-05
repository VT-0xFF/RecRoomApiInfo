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
		[Cpp2IlInjected.Address(RVA = "0x83AD3B0", Offset = "0x83AC7B0", VA = "0x1883AD3B0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		private int[] DTCBHPALRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] DTHIEVUJATD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset GTGGRGPIZNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset GTAZTZVLQCO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC810", Offset = "0x1EBBC10", VA = "0x181EBC810", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83C5020", Offset = "0x83C4420", VA = "0x1883C5020")]
		private void RGTQLMDRHIR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83C4DC0", Offset = "0x83C41C0", VA = "0x1883C4DC0")]
		private void RGOJOFJTXXI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83C5760", Offset = "0x83C4B60", VA = "0x1883C5760", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83C5810", Offset = "0x83C4C10", VA = "0x1883C5810")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class DEMBYPOVLIT
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log ISWOYAUQWZP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log ZAKKOELBXOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83A3DF0", Offset = "0x83A31F0", VA = "0x1883A3DF0")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface JNNJCVHTNAP
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView UEURKORRJPO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType YHZEKCCBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool QPQNFHXJEMQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "2")]
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
	internal interface MVSQMLVFRGV
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool OPTGMGZCGGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GFAYMBIJEEM(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface CQECVQJAFPE : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SHWXSEAJSCT(JNNJCVHTNAP a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WUGNLHLOTAM(JNNJCVHTNAP a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(NMZRZQMVPTV.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HFNANUUUTWR();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IYGUJCWTARK(object a);
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
	public class YPCVJBFIUAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), MVSQMLVFRGV> IKDXVLNAGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<JNNJCVHTNAP> PVJCUNNJRCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> UQTJORBDWJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int SGWHSBFWVHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool JHVHTCCCRZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private NMZRZQMVPTV.ApplyNetworkTransform DYDAHMMAVGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream OIEYIHBKGZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker DFLHIBVSOUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker THLZNRKWINV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] BHGUSKSEYHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float BXRHUAQYJAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int GFIILXTTDXB;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83C33D0", Offset = "0x83C27D0", VA = "0x1883C33D0")]
		public YPCVJBFIUAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83C2AF0", Offset = "0x83C1EF0", VA = "0x1883C2AF0")]
		public void Pause(NMZRZQMVPTV.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83C2A80", Offset = "0x83C1E80", VA = "0x1883C2A80")]
		public void HFNANUUUTWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83C2FF0", Offset = "0x83C23F0", VA = "0x1883C2FF0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83C20B0", Offset = "0x83C14B0", VA = "0x1883C20B0")]
		public bool Add(JNNJCVHTNAP networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83C2B10", Offset = "0x83C1F10", VA = "0x1883C2B10")]
		public bool Remove(JNNJCVHTNAP networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83C1EA0", Offset = "0x83C12A0", VA = "0x1883C1EA0")]
		private MVSQMLVFRGV AOUVEOJXESY(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83C33C0", Offset = "0x83C27C0", VA = "0x1883C33C0")]
		public void WMVVZJQNUCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83C2630", Offset = "0x83C1A30", VA = "0x1883C2630")]
		private void BGCVDWQPUNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83C2AD0", Offset = "0x83C1ED0", VA = "0x1883C2AD0")]
		private void HHEKTOZXZMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83C2C40", Offset = "0x83C2040", VA = "0x1883C2C40")]
		public bool TLFEPPGRBVM(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83C2690", Offset = "0x83C1A90", VA = "0x1883C2690")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class XQEZASPLRIK : MVSQMLVFRGV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private JNNJCVHTNAP XOSVCTTGZZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint FAWQVHOROXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int PWSOQESZSBQ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool OPTGMGZCGGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public XQEZASPLRIK(JNNJCVHTNAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83C1050", Offset = "0x83C0450", VA = "0x1883C1050", Slot = "5")]
		public bool GFAYMBIJEEM(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83C0F70", Offset = "0x83C0370", VA = "0x1883C0F70", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RQGLQURHXEJ : MVSQMLVFRGV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private NMZRZQMVPTV.ApplyNetworkTransform DYDAHMMAVGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId WWZIVBEBCVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int PWSOQESZSBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint FAWQVHOROXX;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OPTGMGZCGGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x19CACE0", Offset = "0x19CA0E0", VA = "0x1819CACE0")]
		public RQGLQURHXEJ(ViewId a, NMZRZQMVPTV.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83B9570", Offset = "0x83B8970", VA = "0x1883B9570", Slot = "5")]
		public bool GFAYMBIJEEM(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83B9390", Offset = "0x83B8790", VA = "0x1883B9390", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class DFKFTWNLKPX
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83A3EA0", Offset = "0x83A32A0", VA = "0x1883A3EA0")]
		public static void CQVTSUWTJSM(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83A4580", Offset = "0x83A3980", VA = "0x1883A4580")]
		public static void TQQUBGMSFVX(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83A4060", Offset = "0x83A3460", VA = "0x1883A4060")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83A41D0", Offset = "0x83A35D0", VA = "0x1883A41D0")]
		public static void TKCFHKJISOI(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(CQECVQJAFPE), new string[] { })]
	public class ZQNZYMFFPQN : CQECVQJAFPE, INetworkUpdateSystem, HNAKBHLVZRV, LGPJMXYAVLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log RFJQJIOBOTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private YPCVJBFIUAH XTYNDDFLAMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint YVSQZPNAQBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float HFRJVYEDAUT;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83C4910", Offset = "0x83C3D10", VA = "0x1883C4910", Slot = "4")]
		public void SHWXSEAJSCT(JNNJCVHTNAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83C4A30", Offset = "0x83C3E30", VA = "0x1883C4A30", Slot = "5")]
		public void WUGNLHLOTAM(JNNJCVHTNAP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83C45F0", Offset = "0x83C39F0", VA = "0x1883C45F0", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83C4740", Offset = "0x83C3B40", VA = "0x1883C4740", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83C3B90", Offset = "0x83C2F90", VA = "0x1883C3B90")]
		private void FSSDTBIXPYP(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83C47C0", Offset = "0x83C3BC0", VA = "0x1883C47C0", Slot = "6")]
		public void Pause(NMZRZQMVPTV.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83C4530", Offset = "0x83C3930", VA = "0x1883C4530", Slot = "7")]
		public void HFNANUUUTWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83C4590", Offset = "0x83C3990", VA = "0x1883C4590", Slot = "8")]
		public void IYGUJCWTARK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83C41A0", Offset = "0x83C35A0", VA = "0x1883C41A0")]
		private void FUUJLGJITVX(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83C47F0", Offset = "0x83C3BF0", VA = "0x1883C47F0", Slot = "11")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83C4C30", Offset = "0x83C4030", VA = "0x1883C4C30")]
		public ZQNZYMFFPQN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HZJFWFPSBBR : MVSQMLVFRGV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float QEQZUGGCTBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int PWSOQESZSBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint FAWQVHOROXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType ZTSRYVDFXXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo FIYCGFMAXSH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int VSXWIUXKPIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] SQDQMRBFYQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo VJHJHEXNBVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int MHAUZEDJYIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] OZOMFAHSUSZ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool OPTGMGZCGGR
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x83A5EA0", Offset = "0x83A52A0", VA = "0x1883A5EA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83A5FD0", Offset = "0x83A53D0", VA = "0x1883A5FD0")]
		public HZJFWFPSBBR(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83A5C90", Offset = "0x83A5090", VA = "0x1883A5C90", Slot = "5")]
		public bool GFAYMBIJEEM(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83A5AE0", Offset = "0x83A4EE0", VA = "0x1883A5AE0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83A5ED0", Offset = "0x83A52D0", VA = "0x1883A5ED0")]
		internal XQEZASPLRIK KFNEFOEVYXB(JNNJCVHTNAP a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83A5CD0", Offset = "0x83A50D0", VA = "0x1883A5CD0")]
		private static void GVQKROEVFPN(XQEZASPLRIK a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RegisterService(typeof(LRRUUYYANPY), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class LRRUUYYANPY : CJUCCXXOWJL, HNAKBHLVZRV, LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Hashtable YUYJKVERBQA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Hashtable AEPXPEPHTJW;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Hashtable JJLDDTDFJLW;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly FRDJWLZNOWA EPHGSQKDRZE;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly FRDJWLZNOWA UCETJTJUKWN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly FRDJWLZNOWA LPLGGIDJFOJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly FRDJWLZNOWA QLVQVNRTMKY;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly FRDJWLZNOWA AQQGGRRIJFD;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static int FFZNOGLODOG;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83ABDC0", Offset = "0x83AB1C0", VA = "0x1883ABDC0", Slot = "4")]
		public bool GKQMWUFEMHW(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83AB2B0", Offset = "0x83AA6B0", VA = "0x1883AB2B0", Slot = "5")]
		public int CKCRKDHDUFW(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83ABF90", Offset = "0x83AB390", VA = "0x1883ABF90", Slot = "6")]
		public bool KLOOOSQNXUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83AB760", Offset = "0x83AAB60", VA = "0x1883AB760", Slot = "7")]
		public bool DEOFDANRBUS(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83AC720", Offset = "0x83ABB20", VA = "0x1883AC720", Slot = "8")]
		public void OOIITOOADMP(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83AC5B0", Offset = "0x83AB9B0", VA = "0x1883AC5B0", Slot = "9")]
		public bool MKSWNZBLONF(PTKTLSUVJWP a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83ABAF0", Offset = "0x83AAEF0", VA = "0x1883ABAF0", Slot = "10")]
		public bool GFZDVVPVXRO(PTKTLSUVJWP a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83ACF20", Offset = "0x83AC320", VA = "0x1883ACF20", Slot = "11")]
		public bool WPYMEBBLMND(PTKTLSUVJWP a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83AB0E0", Offset = "0x83AA4E0", VA = "0x1883AB0E0", Slot = "12")]
		public void BSKXFIIWACR(PTKTLSUVJWP a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83AB8E0", Offset = "0x83AACE0", VA = "0x1883AB8E0", Slot = "13")]
		public void DJXGTLLXWAO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83AB650", Offset = "0x83AAA50", VA = "0x1883AB650", Slot = "14")]
		public void CRTAPYHIBII(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83ABA40", Offset = "0x83AAE40", VA = "0x1883ABA40", Slot = "15")]
		public void EEBQVUIXRMI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83AB010", Offset = "0x83AA410", VA = "0x1883AB010", Slot = "16")]
		public void BPZWIDQSVQD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83ACDC0", Offset = "0x83AC1C0", VA = "0x1883ACDC0", Slot = "17")]
		public void UILUWRTWMNF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83AC9A0", Offset = "0x83ABDA0", VA = "0x1883AC9A0")]
		private static void TCNEPGFRPOG(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83AC020", Offset = "0x83AB420", VA = "0x1883AC020")]
		private static bool MKSWNZBLONF(Hashtable a, JCSDFORPEFX b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83AD030", Offset = "0x83AC430", VA = "0x1883AD030")]
		private static int ZOZOBVPKLLC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83ABEF0", Offset = "0x83AB2F0", VA = "0x1883ABEF0", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83AC900", Offset = "0x83ABD00", VA = "0x1883AC900", Slot = "19")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public LRRUUYYANPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(GHWBIYUDEZW), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class GHWBIYUDEZW : CXJOXAXQAJV, HNAKBHLVZRV, LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static Hashtable RDNIZGRPWRN;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Hashtable JBIKJBRTNBI;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static FRDJWLZNOWA EAKSNKXJPAD;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly FRDJWLZNOWA RTWTIHEQHNQ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83A4F60", Offset = "0x83A4360", VA = "0x1883A4F60", Slot = "4")]
		public void PKGFWDHVDMH(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83A4C40", Offset = "0x83A4040", VA = "0x1883A4C40", Slot = "5")]
		public bool JJQEVYCZEGH(PTKTLSUVJWP a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83A50E0", Offset = "0x83A44E0", VA = "0x1883A50E0", Slot = "6")]
		public void WUDTSSCGWMN(ViewId a, string b, RpcTarget c, JCSDFORPEFX d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83A5040", Offset = "0x83A4440", VA = "0x1883A5040", Slot = "8")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83A4BA0", Offset = "0x83A3FA0", VA = "0x1883A4BA0", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public GHWBIYUDEZW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class OXNEJXRSEYY
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83B8A80", Offset = "0x83B7E80", VA = "0x1883B8A80")]
		public static JCSDFORPEFX MWFJIYSTMTN(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83B8B10", Offset = "0x83B7F10", VA = "0x1883B8B10")]
		public static PlayerId ToPlayerId(this JCSDFORPEFX player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, BSPGLUGQSFD, BZXWFWBHLFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool PJNZTPPDULA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView TXYQUEICGUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<FZERGMMLSNU> XHBIXAUNSKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool RJJTYRGIKWQ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId ZALRNYYMMJX
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83B9CF0", Offset = "0x83B90F0", VA = "0x1883B9CF0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId RHFFQUVNHSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83B9CF0", Offset = "0x83B90F0", VA = "0x1883B9CF0", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView JAYEYSKEVAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83B9D70", Offset = "0x83B9170", VA = "0x1883B9D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView UEURKORRJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x83B9D70", Offset = "0x83B9170", VA = "0x1883B9D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public JCSDFORPEFX NOEDRAWFDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83B9E70", Offset = "0x83B9270", VA = "0x1883B9E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public JCSDFORPEFX ELCRUQTGWQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83BA1D0", Offset = "0x83B95D0", VA = "0x1883BA1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HQXEGKLXRGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83B9FD0", Offset = "0x83B93D0", VA = "0x1883B9FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KLISNLGBAHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x83BA140", Offset = "0x83B9540", VA = "0x1883BA140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IESSKMASBGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83B9C20", Offset = "0x83B9020", VA = "0x1883B9C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool XAVQKZNCQCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83B9F00", Offset = "0x83B9300", VA = "0x1883B9F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool EBOYCAOBIFV
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83B9C20", Offset = "0x83B9020", VA = "0x1883B9C20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool GVVKCONZJFP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x83B9CA0", Offset = "0x83B90A0", VA = "0x1883B9CA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string IAZGUJGDTXR
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x83B9DE0", Offset = "0x83B91E0", VA = "0x1883B9DE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool XHQBBUHUJCM
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x83B9BA0", Offset = "0x83B8FA0", VA = "0x1883B9BA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<JCSDFORPEFX> BSCMAMEXHAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83B9A70", Offset = "0x83B8E70", VA = "0x1883B9A70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83BA260", Offset = "0x83B9660", VA = "0x1883BA260")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83B99D0", Offset = "0x83B8DD0", VA = "0x1883B99D0")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x76B2D40", Offset = "0x76B2140", VA = "0x1876B2D40")]
		private void NVNTZQTPEIF(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83B95D0", Offset = "0x83B89D0", VA = "0x1883B95D0", Slot = "9")]
		public void RegisterDestroyHandler(FZERGMMLSNU handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83B9810", Offset = "0x83B8C10", VA = "0x1883B9810", Slot = "10")]
		public void UnregisterDestroyHandler(FZERGMMLSNU handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83B95B0", Offset = "0x83B89B0", VA = "0x1883B95B0", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KKBTRIOLEPZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, JCSDFORPEFX targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, JCSDFORPEFX targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, JCSDFORPEFX newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CompilerGenerated]
		private static InstantiateCallback OSZSQWEVIIN;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback JWDPBUCHBGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x83AA7D0", Offset = "0x83A9BD0", VA = "0x1883AA7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x83A9F80", Offset = "0x83A9380", VA = "0x1883A9F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback NFCNUXEOBJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83AA890", Offset = "0x83A9C90", VA = "0x1883AA890")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83A9C00", Offset = "0x83A9000", VA = "0x1883A9C00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback IWBFFANOHUI
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x83AAC20", Offset = "0x83AA020", VA = "0x1883AAC20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x83AAE00", Offset = "0x83AA200", VA = "0x1883AAE00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback LYCWYEZUCRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x83AA680", Offset = "0x83A9A80", VA = "0x1883AA680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x83AA380", Offset = "0x83A9780", VA = "0x1883AA380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback AYWLKDHBQGP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x83AA100", Offset = "0x83A9500", VA = "0x1883AA100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x83AA500", Offset = "0x83A9900", VA = "0x1883AA500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback NIOMCDFNFTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x83AAB60", Offset = "0x83A9F60", VA = "0x1883AAB60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x83AA040", Offset = "0x83A9440", VA = "0x1883AA040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback ELIYLNZAWJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x83AA5C0", Offset = "0x83A99C0", VA = "0x1883AA5C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83AAAA0", Offset = "0x83A9EA0", VA = "0x1883AAAA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler NTZQEDQSAUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x83AAF50", Offset = "0x83AA350", VA = "0x1883AAF50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x83AA440", Offset = "0x83A9840", VA = "0x1883AA440")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler DVBBKAJGLZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x83A9EC0", Offset = "0x83A92C0", VA = "0x1883A9EC0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x83A9E00", Offset = "0x83A9200", VA = "0x1883A9E00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83AA1C0", Offset = "0x83A95C0", VA = "0x1883AA1C0")]
		public static void EUOBTKSZBTR([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83AAD70", Offset = "0x83AA170", VA = "0x1883AAD70")]
		public static void UXKULCFAPLJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83AAEC0", Offset = "0x83AA2C0", VA = "0x1883AAEC0")]
		public static void YETCJBCBBBU(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83AA740", Offset = "0x83A9B40", VA = "0x1883AA740")]
		public static void NGHUAFLSUSV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83AACE0", Offset = "0x83AA0E0", VA = "0x1883AACE0")]
		public static void UFWOWPQCQPC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83AA950", Offset = "0x83A9D50", VA = "0x1883AA950")]
		public static void QAOQHVPHZAO(RRNetworkView a, string b, JCSDFORPEFX c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83A9CC0", Offset = "0x83A90C0", VA = "0x1883A9CC0")]
		public static void AOOHKHPOTCR(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83AA280", Offset = "0x83A9680", VA = "0x1883AA280")]
		public static void FKBUYUBJDQZ(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class HHNYJLMVMVA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83A59C0", Offset = "0x83A4DC0", VA = "0x1883A59C0")]
		[CanBeNull]
		private static bool TWBDGVFJGLS(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x83A58E0", Offset = "0x83A4CE0", VA = "0x1883A58E0")]
		[CanBeNull]
		public static Component CIFLFGYSBSQ(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x365F080", Offset = "0x365E480", VA = "0x18365F080")]
		[CanBeNull]
		public static a CIFLFGYSBSQ<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x365F0F0", Offset = "0x365E4F0", VA = "0x18365F0F0")]
		[CanBeNull]
		public static b DVFWMMWGIGM<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x365F210", Offset = "0x365E610", VA = "0x18365F210")]
		public static bool SSTDEJVZRGT<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x83A5A70", Offset = "0x83A4E70", VA = "0x1883A5A70")]
		[CanBeNull]
		public static RRNetworkView UZBXMLBAFFT(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler HEWJBQCTFXH;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x83BA390", Offset = "0x83B9790", VA = "0x1883BA390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x83BA540", Offset = "0x83B9940", VA = "0x1883BA540")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83BA500", Offset = "0x83B9900", VA = "0x1883BA500")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RegisterService(typeof(MZXWUMTXODO), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class MZXWUMTXODO : XQZDSUXMIXF, HNAKBHLVZRV, LGPJMXYAVLB, RDQXTNNVCSB, EMBMQMXGZNX, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class ZXABQVGZVDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int ZAQMQQYWXQK;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public ZXABQVGZVDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x83C4D00", Offset = "0x83C4100", VA = "0x1883C4D00")]
			internal object VLOXWHCIPVZ((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static Log LCHMDTTDSRJ;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static Log BPJCKKCOQMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[DependsOn]
		private IZVFEARWWXC ELOIKPKLPBX;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Dictionary<int, HashSet<int>> NUIKPMNOLLZ;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<int, int> ALGZSJOXMZW;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<(GameObject GameObject, int ParentCount)> WMDTSRCOVDZ;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<GameObject> KVBIHLQVQAQ;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static List<int> QOYHBNLLIRG;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly List<RRNetworkView> TCXBBAMZUKC;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly FRDJWLZNOWA QLVQVNRTMKY;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly FRDJWLZNOWA AQQGGRRIJFD;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83B1180", Offset = "0x83B0580", VA = "0x1883B1180", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83B2DF0", Offset = "0x83B21F0", VA = "0x1883B2DF0", Slot = "9")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83B0FC0", Offset = "0x83B03C0", VA = "0x1883B0FC0", Slot = "10")]
		public void InitExternal(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83B4330", Offset = "0x83B3730", VA = "0x1883B4330", Slot = "11")]
		public void WBQZJJFAQZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83B24E0", Offset = "0x83B18E0", VA = "0x1883B24E0")]
		private void OYYDLMQZARD(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x83B23F0", Offset = "0x83B17F0", VA = "0x1883B23F0")]
		private void MMMFFYQGVGW(ARVWTXZMNAK a, ARVWTXZMNAK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83AFD80", Offset = "0x83AF180", VA = "0x1883AFD80")]
		public GameObject GSLMICJJWDI(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83B1620", Offset = "0x83B0A20", VA = "0x1883B1620")]
		public GameObject KIMZMDLFILW(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83B3B50", Offset = "0x83B2F50", VA = "0x1883B3B50")]
		public GameObject TDSJLKREDXP(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83AFF50", Offset = "0x83AF350", VA = "0x1883AFF50")]
		public GameObject HAFDTLWQNKT(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83B46E0", Offset = "0x83B3AE0", VA = "0x1883B46E0", Slot = "6")]
		public void XFLXKHBRAGH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83B46F0", Offset = "0x83B3AF0", VA = "0x1883B46F0")]
		public void XOJZLHKFEKC(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83ADF40", Offset = "0x83AD340", VA = "0x1883ADF40", Slot = "7")]
		public void EBZRXGYTAFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83B0CA0", Offset = "0x83B00A0", VA = "0x1883B0CA0", Slot = "4")]
		public GameObject[] IZDZQVVNTQX(IList<ZEHIHZUMJHM> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83ADA90", Offset = "0x83ACE90", VA = "0x1883ADA90", Slot = "5")]
		public void DRJLZKIURDY(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83B5630", Offset = "0x83B4A30", VA = "0x1883B5630")]
		public void XYROOKVGDJY(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83AF830", Offset = "0x83AEC30", VA = "0x1883AF830")]
		private void FUUJLGJITVX(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83AD610", Offset = "0x83ACA10", VA = "0x1883AD610")]
		private void ALTBVJFIKXR(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83AFB20", Offset = "0x83AEF20", VA = "0x1883AFB20")]
		private void GLJYEANCUQN(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83B0A20", Offset = "0x83AFE20", VA = "0x1883B0A20")]
		private void IRNWVDHOZBN(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83B5710", Offset = "0x83B4B10", VA = "0x1883B5710")]
		private void ZRFTCBNXAXV(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83B44F0", Offset = "0x83B38F0", VA = "0x1883B44F0")]
		private void WEQSZXIFNAB(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83AFF80", Offset = "0x83AF380", VA = "0x1883AFF80")]
		private void HGZECPFAYAH(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83B05F0", Offset = "0x83AF9F0", VA = "0x1883B05F0")]
		private GameObject HTUHZKSMVUS(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83AE040", Offset = "0x83AD440", VA = "0x1883AE040")]
		private GameObject EIJGJLIWLPS(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83B2D70", Offset = "0x83B2170", VA = "0x1883B2D70")]
		private static GameObject RFQXBKNUMBO(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83B3940", Offset = "0x83B2D40", VA = "0x1883B3940")]
		private static GameObject SYFBHWCJDDX(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83ADE30", Offset = "0x83AD230", VA = "0x1883ADE30")]
		private static void DUAKDJIAHBW(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83B3130", Offset = "0x83B2530", VA = "0x1883B3130")]
		private GameObject[] SEQBIXPYZPZ(IList<ZEHIHZUMJHM> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83AD7D0", Offset = "0x83ACBD0", VA = "0x1883AD7D0")]
		private GameObject[] ATBLHFDOGPD(InstantiateParameters[] a, int b, JCSDFORPEFX c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83B2910", Offset = "0x83B1D10", VA = "0x1883B2910")]
		private GameObject PSNKOHKSAED([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7692550", Offset = "0x7691950", VA = "0x187692550")]
		private static bool WEBMOHCWNRG(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83AE730", Offset = "0x83ADB30", VA = "0x1883AE730")]
		private void EVSHJFHNGXU(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83B4760", Offset = "0x83B3B60", VA = "0x1883B4760")]
		private void XYIGCZOOWUY(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83AF440", Offset = "0x83AE840", VA = "0x1883AF440")]
		private static void FPLSMGMYYJH(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83B14C0", Offset = "0x83B08C0", VA = "0x1883B14C0")]
		private void JMVCSXCCBHN(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83B0550", Offset = "0x83AF950", VA = "0x1883B0550")]
		private static int HMYDWGRNABP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83B2D10", Offset = "0x83B2110", VA = "0x1883B2D10")]
		private void QZGVZAADXSY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83B3DD0", Offset = "0x83B31D0", VA = "0x1883B3DD0")]
		private void UZEVQNGTMWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83B21B0", Offset = "0x83B15B0", VA = "0x1883B21B0")]
		private static int LSRBXFIUVSV(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83B2310", Offset = "0x83B1710", VA = "0x1883B2310")]
		private static int[] MBCQJDTTSZW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83B2210", Offset = "0x83B1610", VA = "0x1883B2210")]
		private static int[] LVKNUGYPRHY(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83B28D0", Offset = "0x83B1CD0", VA = "0x1883B28D0")]
		private void OnMasterClientSwitched(JCSDFORPEFX newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83B1710", Offset = "0x83B0B10", VA = "0x1883B1710")]
		private void LFQGPOAEOHW(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83B2600", Offset = "0x83B1A00", VA = "0x1883B2600")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83B07E0", Offset = "0x83AFBE0", VA = "0x1883B07E0")]
		private void HVPTJUGFREQ(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83ADFA0", Offset = "0x83AD3A0", VA = "0x1883ADFA0")]
		private static void EIFXXXTNMUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83AF340", Offset = "0x83AE740", VA = "0x1883AF340")]
		private void FCFPOJAUHME(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83ADF50", Offset = "0x83AD350", VA = "0x1883ADF50", Slot = "12")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xC5AA40", Offset = "0xC59E40", VA = "0x180C5AA40", Slot = "13")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public MZXWUMTXODO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(IGPLQUFZMUW), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class IGPLQUFZMUW : HNAKBHLVZRV, LGPJMXYAVLB, PYESNTUUZNB
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
			[Cpp2IlInjected.Address(RVA = "0xDDEE90", Offset = "0xDDE290", VA = "0x180DDEE90")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7688200", Offset = "0x7687600", VA = "0x187688200")]
			public object KWKXPXWTSAE(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class EMQMBTNNLSE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public FieldInfo QBDIGVSHYNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Func<MonoBehaviour, object> GROWGGXKBFA;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EMQMBTNNLSE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x83A4A80", Offset = "0x83A3E80", VA = "0x1883A4A80")]
			internal RpcMethodInfo OXICMHBIEYK(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5172DE0", Offset = "0x51721E0", VA = "0x185172DE0")]
			internal object OXNJJNVFOJT(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class EMVSZAHKVDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Func<MonoBehaviour, object> QJPLQFITDTT;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EMVSZAHKVDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7688170", Offset = "0x7687570", VA = "0x187688170")]
			internal RpcMethodInfo OWHTZZFVJTR(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class AAMLVDACMDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Type AXCRHBSXFSK;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public AAMLVDACMDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x83A3DB0", Offset = "0x83A31B0", VA = "0x1883A3DB0")]
			internal bool IDLGCDGBMHI(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, int> WFRZVLNXRLO;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static List<string> DXEXMDNOQCN;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int MJKGYSFEZRI;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Stopwatch MQHPBWMFFOY;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static Dictionary<MethodInfo, ParameterInfo[]> MPMRGNPBYXR;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> CBAIXSIATWU;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x83A67B0", Offset = "0x83A5BB0", VA = "0x1883A67B0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83A89B0", Offset = "0x83A7DB0", VA = "0x1883A89B0")]
		private void UHUOXGINGET(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83A8650", Offset = "0x83A7A50", VA = "0x1883A8650", Slot = "5")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83A84E0", Offset = "0x83A78E0", VA = "0x1883A84E0")]
		public static bool NNRGZLKSNUM(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x83A8E40", Offset = "0x83A8240", VA = "0x1883A8E40")]
		public static bool UVXCYCKCHZK(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x83A6070", Offset = "0x83A5470", VA = "0x1883A6070")]
		private void FUUJLGJITVX(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83A6040", Offset = "0x83A5440", VA = "0x1883A6040", Slot = "9")]
		public string BOKCMDWOWWE(PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83A8570", Offset = "0x83A7970", VA = "0x1883A8570", Slot = "8")]
		public void PKGFWDHVDMH(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83A6DD0", Offset = "0x83A61D0", VA = "0x1883A6DD0", Slot = "6")]
		public void KHTEEVPSPPL(ViewId a, string b, JCSDFORPEFX c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83A6EA0", Offset = "0x83A62A0", VA = "0x1883A6EA0", Slot = "7")]
		public void KHTEEVPSPPL(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83A6900", Offset = "0x83A5D00", VA = "0x1883A6900")]
		private void KHTEEVPSPPL(ViewId a, string b, RpcTarget c, JCSDFORPEFX d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83A6ED0", Offset = "0x83A62D0", VA = "0x1883A6ED0")]
		private void LDPHKBRCHIA(ViewId a, string b, JCSDFORPEFX c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83A6320", Offset = "0x83A5720", VA = "0x1883A6320")]
		private static void IMIPTOYUIMA(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83A97B0", Offset = "0x83A8BB0", VA = "0x1883A97B0")]
		private static bool YRHMTHRCGQP(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83A8F20", Offset = "0x83A8320", VA = "0x1883A8F20")]
		private List<RpcMethodInfo> WIMJRNHOXVI(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x83A88B0", Offset = "0x83A7CB0", VA = "0x1883A88B0")]
		private static IEnumerable<MethodInfo> STKQDGFXGBK(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83A87A0", Offset = "0x83A7BA0", VA = "0x1883A87A0")]
		public static ParameterInfo[] RXUSRAUYAHG(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public IGPLQUFZMUW()
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
			[Cpp2IlInjected.Address(RVA = "0x83BA600", Offset = "0x83B9A00", VA = "0x1883BA600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83BA580", Offset = "0x83B9980", VA = "0x1883BA580")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, VITLXRLATFK, BTDVHPCUPXD, CHZAZPCWGLE, KHQUFIVSEOW, PMLNBQXSYVL
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(IZVFEARWWXC), new string[] { })]
		internal class XJLYIGGHUSJ : HNAKBHLVZRV, LGPJMXYAVLB, IZVFEARWWXC
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Dictionary<int, RRNetworkView> HGHZENIHZWK;

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x83C0EE0", Offset = "0x83C02E0", VA = "0x1883C0EE0", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x83C0EE0", Offset = "0x83C02E0", VA = "0x1883C0EE0", Slot = "5")]
			public void RWVOXCJLGEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x83C0BA0", Offset = "0x83BFFA0", VA = "0x1883C0BA0", Slot = "6")]
			public void GJIKWLOQOUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public XJLYIGGHUSJ()
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
		private sealed class EOXEHAWLLLA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int CIATINOZZOO;

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public EOXEHAWLLLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x83A4B40", Offset = "0x83A3F40", VA = "0x1883A4B40")]
			internal bool SMZUSLZWIFM(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static FRDJWLZNOWA UQPLDMFMTWK;

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
		private bool WWTQXLWGGDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool ORUDEULAMJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool CSXVWUFPMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int DSSGTOKMIAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool QLFWROJJJSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int HVLTNGSRTHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private JCSDFORPEFX ELCRUQTGWQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private JCSDFORPEFX KHNGEXTEAXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool? DALQZDZCHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool EPFZNMLANSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal bool RQLSXPTDMXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal MonoBehaviour[] CPMAPZSZNVA;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly Log RGBXRZDOAZV;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> HGHZENIHZWK
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x83BE6C0", Offset = "0x83BDAC0", VA = "0x1883BE6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId RHFFQUVNHSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x83BEC10", Offset = "0x83BE010", VA = "0x1883BEC10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId PTWUJFUIFRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83BEC10", Offset = "0x83BE010", VA = "0x1883BEC10", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId ZALRNYYMMJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x83BEC10", Offset = "0x83BE010", VA = "0x1883BEC10")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int PNKHSXHOPSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int NTXYGHMBCOC
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xACC3D0", Offset = "0xACB7D0", VA = "0x180ACC3D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBE0CB0", VA = "0x180BE18B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId FBCDFCNMSYO
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x83BEA80", Offset = "0x83BDE80", VA = "0x1883BEA80")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool EPVBXKUMQOO
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xC75520", Offset = "0xC74920", VA = "0x180C75520")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xC75550", Offset = "0xC74950", VA = "0x180C75550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool OXJZPBSUYIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x83BEA90", Offset = "0x83BDE90", VA = "0x1883BEA90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool BMLIGJYGKXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAF9F90", Offset = "0xAF9390", VA = "0x180AF9F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAF9170", Offset = "0xAF8570", VA = "0x180AF9170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int KJIWPASLUVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAF32A0", Offset = "0xAF26A0", VA = "0x180AF32A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int PUMHYKIKGYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x83BEA20", Offset = "0x83BDE20", VA = "0x1883BEA20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public JCSDFORPEFX BQRSMRLJFND
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x83BEC20", Offset = "0x83BE020", VA = "0x1883BEC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public JCSDFORPEFX BHKBVRHTXYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x83BE9F0", Offset = "0x83BDDF0", VA = "0x1883BE9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public JCSDFORPEFX NOEDRAWFDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x83BE9F0", Offset = "0x83BDDF0", VA = "0x1883BE9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public JCSDFORPEFX AVQUSDUMKSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x83BE9F0", Offset = "0x83BDDF0", VA = "0x1883BE9F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool RPISOTTPFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x83BEB60", Offset = "0x83BDF60", VA = "0x1883BEB60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int EYFFDKGGITJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x83BEA50", Offset = "0x83BDE50", VA = "0x1883BEA50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] WTUPXNQRGZR
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HQXEGKLXRGB
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x83BEC50", Offset = "0x83BE050", VA = "0x1883BEC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool HPTKESOYKJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x83BEBE0", Offset = "0x83BDFE0", VA = "0x1883BEBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KGYJMXFIELE
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xCAAC50", Offset = "0xCAA050", VA = "0x180CAAC50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCABB70", Offset = "0xCAAF70", VA = "0x180CABB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool POVZQWAWTHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xCAAC20", Offset = "0xCAA020", VA = "0x180CAAC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> JHBOGRLDIAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83BE880", Offset = "0x83BDC80", VA = "0x1883BE880")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x83BEE10", Offset = "0x83BE210", VA = "0x1883BEE10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<JCSDFORPEFX> BFZBZLJTXGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x83BACB0", Offset = "0x83BA0B0", VA = "0x1883BACB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83BAF30", Offset = "0x83BA330", VA = "0x1883BAF30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<JCSDFORPEFX> QGBCGBCLDTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x83BACB0", Offset = "0x83BA0B0", VA = "0x1883BACB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x83BAF30", Offset = "0x83BA330", VA = "0x1883BAF30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> YSAISCGCHJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x83BC010", Offset = "0x83BB410", VA = "0x1883BC010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x83BBF50", Offset = "0x83BB350", VA = "0x1883BBF50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> WUPCNSQYVAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x83BC010", Offset = "0x83BB410", VA = "0x1883BC010")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x83BBF50", Offset = "0x83BB350", VA = "0x1883BBF50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> WQFQIWWCHKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x83BE930", Offset = "0x83BDD30", VA = "0x1883BE930")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x83BEEC0", Offset = "0x83BE2C0", VA = "0x1883BEEC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action KKFOZHDWADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x83BE7D0", Offset = "0x83BDBD0", VA = "0x1883BE7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x83BED60", Offset = "0x83BE160", VA = "0x1883BED60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83BE130", Offset = "0x83BD530", VA = "0x1883BE130")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83BAE70", Offset = "0x83BA270", VA = "0x1883BAE70")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83BB0F0", Offset = "0x83BA4F0", VA = "0x1883BB0F0")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83BB050", Offset = "0x83BA450", VA = "0x1883BB050")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83BC510", Offset = "0x83BB910", VA = "0x1883BC510")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x83BC2B0", Offset = "0x83BB6B0", VA = "0x1883BC2B0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x83BBBE0", Offset = "0x83BAFE0", VA = "0x1883BBBE0")]
		public static void OnPlayerJoinedRoom(JCSDFORPEFX newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x83BB250", Offset = "0x83BA650", VA = "0x1883BB250")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x83BB2B0", Offset = "0x83BA6B0", VA = "0x1883BB2B0")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x83BE4E0", Offset = "0x83BD8E0", VA = "0x1883BE4E0")]
		private void YGWHYPQLDID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x83BAB40", Offset = "0x83B9F40", VA = "0x1883BAB40")]
		public bool CreatedBy(JCSDFORPEFX player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x83BDF50", Offset = "0x83BD350", VA = "0x1883BDF50")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x83BDEF0", Offset = "0x83BD2F0", VA = "0x1883BDEF0")]
		public void TransferOwnership(JCSDFORPEFX newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x83BB5D0", Offset = "0x83BA9D0", VA = "0x1883BB5D0", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x83BB570", Offset = "0x83BA970", VA = "0x1883BB570")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x83BA760", Offset = "0x83B9B60", VA = "0x1883BA760")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x83BB740", Offset = "0x83BAB40", VA = "0x1883BB740")]
		private void MGOMFBMSBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1100CE0", Offset = "0x11000E0", VA = "0x181100CE0")]
		internal void OZIOHRJSTZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x83BE5C0", Offset = "0x83BD9C0", VA = "0x1883BE5C0", Slot = "6")]
		private void YWQOKQGGZSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x83BAFE0", Offset = "0x83BA3E0", VA = "0x1883BAFE0")]
		internal bool GRSNMILFZCO(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x83BBAA0", Offset = "0x83BAEA0", VA = "0x1883BBAA0")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x83BBA40", Offset = "0x83BAE40", VA = "0x1883BBA40")]
		internal void OOLGLJPFCCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x83BC000", Offset = "0x83BB400", VA = "0x1883BC000")]
		private void QYBYLSZVEYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x83BA820", Offset = "0x83B9C20", VA = "0x1883BA820")]
		internal void CZGDZSQSTGE(JCSDFORPEFX a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83BC470", Offset = "0x83BB870", VA = "0x1883BC470")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83BC5C0", Offset = "0x83BB9C0", VA = "0x1883BC5C0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83BB9A0", Offset = "0x83BADA0", VA = "0x1883BB9A0")]
		private void MYVQXTIKHGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x83BABC0", Offset = "0x83B9FC0", VA = "0x1883BABC0")]
		private void EBQXAJAYQIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83BC190", Offset = "0x83BB590", VA = "0x1883BC190")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x83BC220", Offset = "0x83BB620", VA = "0x1883BC220")]
		public void RPC(string methodName, JCSDFORPEFX targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83BC4C0", Offset = "0x83BB8C0", VA = "0x1883BC4C0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x83BA7B0", Offset = "0x83B9BB0", VA = "0x1883BA7B0", Slot = "8")]
		public void Bake(MRSPDLXDOCP context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x83BDE80", Offset = "0x83BD280", VA = "0x1883BDE80")]
		private static void SSHJANHWQBL(JCSDFORPEFX a, [Out] JCSDFORPEFX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83BE1F0", Offset = "0x83BD5F0", VA = "0x1883BE1F0")]
		private static void UEIPQGHUHMA(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83BB310", Offset = "0x83BA710", VA = "0x1883BB310")]
		private static RPCInfo HRDDNZZRRBD(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83BB3B0", Offset = "0x83BA7B0", VA = "0x1883BB3B0")]
		private static void IRVYXWBRNQD(RRNetworkView a, Delegate b, JCSDFORPEFX c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83BB490", Offset = "0x83BA890", VA = "0x1883BB490")]
		private static void IRVYXWBRNQD(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83BAD60", Offset = "0x83BA160", VA = "0x1883BAD60")]
		private static void FHRXXPUMUBC(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83BC0C0", Offset = "0x83BB4C0", VA = "0x1883BC0C0")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83BE620", Offset = "0x83BDA20", VA = "0x1883BE620")]
		private static bool ZABBABTLKZD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83BCCA0", Offset = "0x83BC0A0", VA = "0x1883BCCA0", Slot = "25")]
		public void RpcAll(DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x39A2180", Offset = "0x39A1580", VA = "0x1839A2180", Slot = "9")]
		public void RpcAll<T1>(DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x39A1A70", Offset = "0x39A0E70", VA = "0x1839A1A70", Slot = "10")]
		public void RpcAll<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x39A27E0", Offset = "0x39A1BE0", VA = "0x1839A27E0", Slot = "26")]
		public void RpcAll<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x39A1C60", Offset = "0x39A1060", VA = "0x1839A1C60", Slot = "27")]
		public void RpcAll<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x39B77D0", Offset = "0x39B6BD0", VA = "0x1839B77D0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x39B8D20", Offset = "0x39B8120", VA = "0x1839B8D20", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x39B7320", Offset = "0x39B6720", VA = "0x1839B7320", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x39C99D0", Offset = "0x39C8DD0", VA = "0x1839C99D0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x39B9140", Offset = "0x39B8540", VA = "0x1839B9140", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x39B8370", Offset = "0x39B7770", VA = "0x1839B8370", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x39C8C90", Offset = "0x39C8090", VA = "0x1839C8C90", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x39BDB20", Offset = "0x39BCF20", VA = "0x1839BDB20", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x39BCBF0", Offset = "0x39BBFF0", VA = "0x1839BCBF0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x39B7BC0", Offset = "0x39B6FC0", VA = "0x1839B7BC0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x83BCA70", Offset = "0x83BBE70", VA = "0x1883BCA70", Slot = "35")]
		public void RpcAll(DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x39A54A0", Offset = "0x39A48A0", VA = "0x1839A54A0", Slot = "36")]
		public void RpcAll<T1>(DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x39A4FC0", Offset = "0x39A43C0", VA = "0x1839A4FC0", Slot = "37")]
		public void RpcAll<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x39A2500", Offset = "0x39A1900", VA = "0x1839A2500", Slot = "38")]
		public void RpcAll<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x39C86F0", Offset = "0x39C7AF0", VA = "0x1839C86F0", Slot = "39")]
		public void RpcAll<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x39C7AE0", Offset = "0x39C6EE0", VA = "0x1839C7AE0", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x39C6CB0", Offset = "0x39C60B0", VA = "0x1839C6CB0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x39C53A0", Offset = "0x39C47A0", VA = "0x1839C53A0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x39C4990", Offset = "0x39C3D90", VA = "0x1839C4990", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x39C2A00", Offset = "0x39C1E00", VA = "0x1839C2A00", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x39C11E0", Offset = "0x39C05E0", VA = "0x1839C11E0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x39BF7A0", Offset = "0x39BEBA0", VA = "0x1839BF7A0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x39BE930", Offset = "0x39BDD30", VA = "0x1839BE930", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x39BBC60", Offset = "0x39BB060", VA = "0x1839BBC60", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x39BABA0", Offset = "0x39B9FA0", VA = "0x1839BABA0", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x83BC940", Offset = "0x83BBD40", VA = "0x1883BC940", Slot = "50")]
		public void RpcAllViaServer(DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x39B6E50", Offset = "0x39B6250", VA = "0x1839B6E50", Slot = "51")]
		public void RpcAllViaServer<T1>(DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x39B6FE0", Offset = "0x39B63E0", VA = "0x1839B6FE0", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x39B68F0", Offset = "0x39B5CF0", VA = "0x1839B68F0", Slot = "52")]
		public void RpcAllViaServer<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x39B6510", Offset = "0x39B5910", VA = "0x1839B6510", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x39B6070", Offset = "0x39B5470", VA = "0x1839B6070", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x39B5B10", Offset = "0x39B4F10", VA = "0x1839B5B10", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x39B54F0", Offset = "0x39B48F0", VA = "0x1839B54F0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x39B4E10", Offset = "0x39B4210", VA = "0x1839B4E10", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x39B4670", Offset = "0x39B3A70", VA = "0x1839B4670", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x39B3E10", Offset = "0x39B3210", VA = "0x1839B3E10", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x39B34F0", Offset = "0x39B28F0", VA = "0x1839B34F0", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x39B2B00", Offset = "0x39B1F00", VA = "0x1839B2B00", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x39B2050", Offset = "0x39B1450", VA = "0x1839B2050", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x39B14C0", Offset = "0x39B08C0", VA = "0x1839B14C0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x83BC810", Offset = "0x83BBC10", VA = "0x1883BC810", Slot = "64")]
		public void RpcAllViaServer(DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x39B6E50", Offset = "0x39B6250", VA = "0x1839B6E50", Slot = "65")]
		public void RpcAllViaServer<T1>(DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x39B6C00", Offset = "0x39B6000", VA = "0x1839B6C00", Slot = "66")]
		public void RpcAllViaServer<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x39B68F0", Offset = "0x39B5CF0", VA = "0x1839B68F0", Slot = "67")]
		public void RpcAllViaServer<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x39B6510", Offset = "0x39B5910", VA = "0x1839B6510", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x39B6070", Offset = "0x39B5470", VA = "0x1839B6070", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x39B5B10", Offset = "0x39B4F10", VA = "0x1839B5B10", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39B54F0", Offset = "0x39B48F0", VA = "0x1839B54F0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x39B4E10", Offset = "0x39B4210", VA = "0x1839B4E10", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x39B4670", Offset = "0x39B3A70", VA = "0x1839B4670", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x39B3E10", Offset = "0x39B3210", VA = "0x1839B3E10", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x39B34F0", Offset = "0x39B28F0", VA = "0x1839B34F0", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x39B2B00", Offset = "0x39B1F00", VA = "0x1839B2B00", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x39B2050", Offset = "0x39B1450", VA = "0x1839B2050", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x39B14C0", Offset = "0x39B08C0", VA = "0x1839B14C0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x83BD730", Offset = "0x83BCB30", VA = "0x1883BD730", Slot = "79")]
		public void RpcOthers(DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3A03130", Offset = "0x3A02530", VA = "0x183A03130", Slot = "15")]
		public void RpcOthers<T1>(DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3A096D0", Offset = "0x3A08AD0", VA = "0x183A096D0", Slot = "80")]
		public void RpcOthers<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3A02EF0", Offset = "0x3A022F0", VA = "0x183A02EF0", Slot = "81")]
		public void RpcOthers<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C4D0", Offset = "0x3A0B8D0", VA = "0x183A0C4D0", Slot = "82")]
		public void RpcOthers<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3A07FB0", Offset = "0x3A073B0", VA = "0x183A07FB0", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3A0A440", Offset = "0x3A09840", VA = "0x183A0A440", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3A073E0", Offset = "0x3A067E0", VA = "0x183A073E0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A0B060", Offset = "0x3A0A460", VA = "0x183A0B060", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A06500", Offset = "0x3A05900", VA = "0x183A06500", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3A0AB80", Offset = "0x3A09F80", VA = "0x183A0AB80", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A05320", Offset = "0x3A04720", VA = "0x183A05320", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A04910", Offset = "0x3A03D10", VA = "0x183A04910", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A03E30", Offset = "0x3A03230", VA = "0x183A03E30", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A03280", Offset = "0x3A02680", VA = "0x183A03280", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x83BD880", Offset = "0x83BCC80", VA = "0x1883BD880", Slot = "92")]
		public void RpcOthers(DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3A09430", Offset = "0x3A08830", VA = "0x183A09430", Slot = "93")]
		public void RpcOthers<T1>(DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3A09270", Offset = "0x3A08670", VA = "0x183A09270", Slot = "94")]
		public void RpcOthers<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3A08870", Offset = "0x3A07C70", VA = "0x183A08870", Slot = "95")]
		public void RpcOthers<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3A08FD0", Offset = "0x3A083D0", VA = "0x183A08FD0", Slot = "96")]
		public void RpcOthers<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3A09BE0", Offset = "0x3A08FE0", VA = "0x183A09BE0", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3A09EE0", Offset = "0x3A092E0", VA = "0x183A09EE0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A073E0", Offset = "0x3A067E0", VA = "0x183A073E0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3A06CD0", Offset = "0x3A060D0", VA = "0x183A06CD0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3A06500", Offset = "0x3A05900", VA = "0x183A06500", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3A05C70", Offset = "0x3A05070", VA = "0x183A05C70", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3A05320", Offset = "0x3A04720", VA = "0x183A05320", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3A04910", Offset = "0x3A03D10", VA = "0x183A04910", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A03E30", Offset = "0x3A03230", VA = "0x183A03E30", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A03280", Offset = "0x3A02680", VA = "0x183A03280", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x83BD460", Offset = "0x83BC860", VA = "0x1883BD460", Slot = "107")]
		public void RpcMaster(DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x39E47E0", Offset = "0x39E3BE0", VA = "0x1839E47E0", Slot = "108")]
		public void RpcMaster<T1>(DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x39E4970", Offset = "0x39E3D70", VA = "0x1839E4970", Slot = "109")]
		public void RpcMaster<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x39E3E10", Offset = "0x39E3210", VA = "0x1839E3E10", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x39E4070", Offset = "0x39E3470", VA = "0x1839E4070", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x39F7F70", Offset = "0x39F7370", VA = "0x1839F7F70", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x39F9F80", Offset = "0x39F9380", VA = "0x1839F9F80", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x39F04F0", Offset = "0x39EF8F0", VA = "0x1839F04F0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x39EFB40", Offset = "0x39EEF40", VA = "0x1839EFB40", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x39EDB30", Offset = "0x39ECF30", VA = "0x1839EDB30", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x39F77C0", Offset = "0x39F6BC0", VA = "0x1839F77C0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x39F6A10", Offset = "0x39F5E10", VA = "0x1839F6A10", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x39E9A70", Offset = "0x39E8E70", VA = "0x1839E9A70", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x39E6CE0", Offset = "0x39E60E0", VA = "0x1839E6CE0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x39E4B90", Offset = "0x39E3F90", VA = "0x1839E4B90", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x83BD220", Offset = "0x83BC620", VA = "0x1883BD220", Slot = "122")]
		public void RpcMaster(DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x39E4600", Offset = "0x39E3A00", VA = "0x1839E4600", Slot = "123")]
		public void RpcMaster<T1>(DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x39F5D30", Offset = "0x39F5130", VA = "0x1839F5D30", Slot = "124")]
		public void RpcMaster<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x39F53A0", Offset = "0x39F47A0", VA = "0x1839F53A0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x39F3370", Offset = "0x39F2770", VA = "0x1839F3370", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x39F8740", Offset = "0x39F7B40", VA = "0x1839F8740", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x39F16A0", Offset = "0x39F0AA0", VA = "0x1839F16A0", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x39F0DA0", Offset = "0x39F01A0", VA = "0x1839F0DA0", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x39EF130", Offset = "0x39EE530", VA = "0x1839EF130", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x39EE600", Offset = "0x39EDA00", VA = "0x1839EE600", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x39ECEF0", Offset = "0x39EC2F0", VA = "0x1839ECEF0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x39EB5A0", Offset = "0x39EA9A0", VA = "0x1839EB5A0", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x39E8BE0", Offset = "0x39E7FE0", VA = "0x1839E8BE0", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x39E7C30", Offset = "0x39E7030", VA = "0x1839E7C30", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x39E5C00", Offset = "0x39E5000", VA = "0x1839E5C00", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x83BD070", Offset = "0x83BC470", VA = "0x1883BD070", Slot = "137")]
		public void RpcAuthority(DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x39CE320", Offset = "0x39CD720", VA = "0x1839CE320", Slot = "138")]
		public void RpcAuthority<T1>(DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x39E06A0", Offset = "0x39DFAA0", VA = "0x1839E06A0", Slot = "139")]
		public void RpcAuthority<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x39E0E00", Offset = "0x39E0200", VA = "0x1839E0E00", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x39E03A0", Offset = "0x39DF7A0", VA = "0x1839E03A0", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x39CDF90", Offset = "0x39CD390", VA = "0x1839CDF90", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x39DB300", Offset = "0x39DA700", VA = "0x1839DB300", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x39DAA20", Offset = "0x39D9E20", VA = "0x1839DAA20", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x39D8CC0", Offset = "0x39D80C0", VA = "0x1839D8CC0", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x39D81C0", Offset = "0x39D75C0", VA = "0x1839D81C0", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x39D5DC0", Offset = "0x39D51C0", VA = "0x1839D5DC0", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x39E1C70", Offset = "0x39E1070", VA = "0x1839E1C70", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x39DF160", Offset = "0x39DE560", VA = "0x1839DF160", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x39D1670", Offset = "0x39D0A70", VA = "0x1839D1670", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x39CF5E0", Offset = "0x39CE9E0", VA = "0x1839CF5E0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x83BCE10", Offset = "0x83BC210", VA = "0x1883BCE10", Slot = "152")]
		public void RpcAuthority(DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x39DEEB0", Offset = "0x39DE2B0", VA = "0x1839DEEB0", Slot = "153")]
		public void RpcAuthority<T1>(DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x39DE530", Offset = "0x39DD930", VA = "0x1839DE530", Slot = "154")]
		public void RpcAuthority<T1, T2>(DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x39DDBE0", Offset = "0x39DCFE0", VA = "0x1839DDBE0", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x39DD600", Offset = "0x39DCA00", VA = "0x1839DD600", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x39DC970", Offset = "0x39DBD70", VA = "0x1839DC970", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x39DBAC0", Offset = "0x39DAEC0", VA = "0x1839DBAC0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x39DA0F0", Offset = "0x39D94F0", VA = "0x1839DA0F0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x39D96B0", Offset = "0x39D8AB0", VA = "0x1839D96B0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x39D7660", Offset = "0x39D6A60", VA = "0x1839D7660", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x39D69E0", Offset = "0x39D5DE0", VA = "0x1839D69E0", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x39D5030", Offset = "0x39D4430", VA = "0x1839D5030", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x39D3440", Offset = "0x39D2840", VA = "0x1839D3440", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x39D0690", Offset = "0x39CFA90", VA = "0x1839D0690", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x39CE4D0", Offset = "0x39CD8D0", VA = "0x1839CE4D0", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x83BDC90", Offset = "0x83BD090", VA = "0x1883BDC90", Slot = "17")]
		public void RpcPlayer(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3A0CA10", Offset = "0x3A0BE10", VA = "0x183A0CA10", Slot = "18")]
		public void RpcPlayer<T1>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D690", Offset = "0x3A0CA90", VA = "0x183A0D690", Slot = "19")]
		public void RpcPlayer<T1, T2>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D120", Offset = "0x3A0C520", VA = "0x183A0D120", Slot = "20")]
		public void RpcPlayer<T1, T2, T3>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3A0CBD0", Offset = "0x3A0BFD0", VA = "0x183A0CBD0", Slot = "21")]
		public void RpcPlayer<T1, T2, T3, T4>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3A218B0", Offset = "0x3A20CB0", VA = "0x183A218B0", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A214B0", Offset = "0x3A208B0", VA = "0x183A214B0", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3A21C30", Offset = "0x3A21030", VA = "0x183A21C30", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3A22080", Offset = "0x3A21480", VA = "0x183A22080", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A19990", Offset = "0x3A18D90", VA = "0x183A19990", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3A18200", Offset = "0x3A17600", VA = "0x183A18200", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DEC0", Offset = "0x3A0D2C0", VA = "0x183A0DEC0", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3A13D60", Offset = "0x3A13160", VA = "0x183A13D60", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3A269A0", Offset = "0x3A25DA0", VA = "0x183A269A0", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3A0FC00", Offset = "0x3A0F000", VA = "0x183A0FC00", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x83BD9D0", Offset = "0x83BCDD0", VA = "0x1883BD9D0", Slot = "176")]
		public void RpcPlayer(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3A0CF10", Offset = "0x3A0C310", VA = "0x183A0CF10", Slot = "177")]
		public void RpcPlayer<T1>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DC10", Offset = "0x3A0D010", VA = "0x183A0DC10", Slot = "23")]
		public void RpcPlayer<T1, T2>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D8E0", Offset = "0x3A0CCE0", VA = "0x183A0D8E0", Slot = "24")]
		public void RpcPlayer<T1, T2, T3>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3A0F490", Offset = "0x3A0E890", VA = "0x183A0F490", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3A1DAB0", Offset = "0x3A1CEB0", VA = "0x183A1DAB0", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D290", Offset = "0x3A1C690", VA = "0x183A1D290", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3A1C190", Offset = "0x3A1B590", VA = "0x183A1C190", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3A1AE80", Offset = "0x3A1A280", VA = "0x183A1AE80", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3A18E20", Offset = "0x3A18220", VA = "0x183A18E20", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3A17570", Offset = "0x3A16970", VA = "0x183A17570", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3A167D0", Offset = "0x3A15BD0", VA = "0x183A167D0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3A14BC0", Offset = "0x3A13FC0", VA = "0x183A14BC0", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3A12D70", Offset = "0x3A12170", VA = "0x183A12D70", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x3A10CC0", Offset = "0x3A100C0", VA = "0x183A10CC0", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(JCSDFORPEFX player, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x83BC6D0", Offset = "0x83BBAD0", VA = "0x1883BC6D0", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x39B1320", Offset = "0x39B0720", VA = "0x1839B1320", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x39B10D0", Offset = "0x39B04D0", VA = "0x1839B10D0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x39B0DB0", Offset = "0x39B01B0", VA = "0x1839B0DB0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x39B09D0", Offset = "0x39AFDD0", VA = "0x1839B09D0", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x39B0530", Offset = "0x39AF930", VA = "0x1839B0530", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x39AFFD0", Offset = "0x39AF3D0", VA = "0x1839AFFD0", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x39AF9B0", Offset = "0x39AEDB0", VA = "0x1839AF9B0", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x39AF2D0", Offset = "0x39AE6D0", VA = "0x1839AF2D0", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x39AEB30", Offset = "0x39ADF30", VA = "0x1839AEB30", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x39AE2C0", Offset = "0x39AD6C0", VA = "0x1839AE2C0", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x39AD990", Offset = "0x39ACD90", VA = "0x1839AD990", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x39ACFA0", Offset = "0x39AC3A0", VA = "0x1839ACFA0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x39AC4E0", Offset = "0x39AB8E0", VA = "0x1839AC4E0", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x39AB950", Offset = "0x39AAD50", VA = "0x1839AB950", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x83BC770", Offset = "0x83BBB70", VA = "0x1883BC770", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x39B1320", Offset = "0x39B0720", VA = "0x1839B1320", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x39B10D0", Offset = "0x39B04D0", VA = "0x1839B10D0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x39B0DB0", Offset = "0x39B01B0", VA = "0x1839B0DB0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x39B09D0", Offset = "0x39AFDD0", VA = "0x1839B09D0", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x39B0530", Offset = "0x39AF930", VA = "0x1839B0530", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x39AFFD0", Offset = "0x39AF3D0", VA = "0x1839AFFD0", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x39AF9B0", Offset = "0x39AEDB0", VA = "0x1839AF9B0", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x39AF2D0", Offset = "0x39AE6D0", VA = "0x1839AF2D0", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x39AEB30", Offset = "0x39ADF30", VA = "0x1839AEB30", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x39AE2C0", Offset = "0x39AD6C0", VA = "0x1839AE2C0", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x39AD990", Offset = "0x39ACD90", VA = "0x1839AD990", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x39ACFA0", Offset = "0x39AC3A0", VA = "0x1839ACFA0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x39AC4E0", Offset = "0x39AB8E0", VA = "0x1839AC4E0", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x39AB950", Offset = "0x39AAD50", VA = "0x1839AB950", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x83BD5F0", Offset = "0x83BC9F0", VA = "0x1883BD5F0", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3A02D50", Offset = "0x3A02150", VA = "0x183A02D50", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3A02B00", Offset = "0x3A01F00", VA = "0x183A02B00", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3A027F0", Offset = "0x3A01BF0", VA = "0x183A027F0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3A02410", Offset = "0x3A01810", VA = "0x183A02410", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3A01F70", Offset = "0x3A01370", VA = "0x183A01F70", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3A01A10", Offset = "0x3A00E10", VA = "0x183A01A10", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3A013F0", Offset = "0x3A007F0", VA = "0x183A013F0", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3A00D10", Offset = "0x3A00110", VA = "0x183A00D10", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3A00570", Offset = "0x39FF970", VA = "0x183A00570", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x39FFD00", Offset = "0x39FF100", VA = "0x1839FFD00", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x39FF3D0", Offset = "0x39FE7D0", VA = "0x1839FF3D0", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x39FE9E0", Offset = "0x39FDDE0", VA = "0x1839FE9E0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x39FDF20", Offset = "0x39FD320", VA = "0x1839FDF20", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x39FD390", Offset = "0x39FC790", VA = "0x1839FD390", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x83BD690", Offset = "0x83BCA90", VA = "0x1883BD690", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3A02D50", Offset = "0x3A02150", VA = "0x183A02D50", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3A02B00", Offset = "0x3A01F00", VA = "0x183A02B00", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3A027F0", Offset = "0x3A01BF0", VA = "0x183A027F0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3A02410", Offset = "0x3A01810", VA = "0x183A02410", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3A01F70", Offset = "0x3A01370", VA = "0x183A01F70", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3A01A10", Offset = "0x3A00E10", VA = "0x183A01A10", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3A013F0", Offset = "0x3A007F0", VA = "0x183A013F0", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3A00D10", Offset = "0x3A00110", VA = "0x183A00D10", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3A00570", Offset = "0x39FF970", VA = "0x183A00570", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x39FFD00", Offset = "0x39FF100", VA = "0x1839FFD00", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x39FF3D0", Offset = "0x39FE7D0", VA = "0x1839FF3D0", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x39FE9E0", Offset = "0x39FDDE0", VA = "0x1839FE9E0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x39FDF20", Offset = "0x39FD320", VA = "0x1839FDF20", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x39FD390", Offset = "0x39FC790", VA = "0x1839FD390", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, DWHGDJWKQBC.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x83BA8E0", Offset = "0x83B9CE0", VA = "0x1883BA8E0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x83BAAE0", Offset = "0x83B9EE0", VA = "0x1883BAAE0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x14DF470", Offset = "0x14DE870", VA = "0x1814DF470")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class OIXYGAVRTQT
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x83B89C0", Offset = "0x83B7DC0", VA = "0x1883B89C0")]
		private static bool XZPIJBDKAIQ(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3862760", Offset = "0x3861B60", VA = "0x183862760")]
		[CanBeNull]
		public static a PHFKUPPBXUA<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class RMIVDUUSKIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public JCSDFORPEFX[] JJMROLAHRPN;

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public RMIVDUUSKIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x83B91F0", Offset = "0x83B85F0", VA = "0x1883B91F0")]
			internal int TQDHKQMHJUD(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x83B9160", Offset = "0x83B8560", VA = "0x1883B9160")]
			internal void TPYANJSKAIU(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static JCSDFORPEFX[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int RLOXHNNFAFU;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x83BF0D0", Offset = "0x83BE4D0", VA = "0x1883BF0D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x83BF6B0", Offset = "0x83BEAB0", VA = "0x1883BF6B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x83BFA30", Offset = "0x83BEE30", VA = "0x1883BFA30")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x83BFAA0", Offset = "0x83BEEA0", VA = "0x1883BFAA0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x83BF6A0", Offset = "0x83BEAA0", VA = "0x1883BF6A0")]
		private void TNTVWEYAIUW(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x83BF6A0", Offset = "0x83BEAA0", VA = "0x1883BF6A0")]
		private void LFQGPOAEOHW(JCSDFORPEFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x83BF5B0", Offset = "0x83BE9B0", VA = "0x1883BF5B0")]
		private void JWOBHZNWSMC(JCSDFORPEFX a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x83BEF80", Offset = "0x83BE380", VA = "0x1883BEF80")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x83BFB40", Offset = "0x83BEF40", VA = "0x1883BFB40")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x83BF4C0", Offset = "0x83BE8C0", VA = "0x1883BF4C0")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xAB54F0", Offset = "0xAB48F0", VA = "0x180AB54F0")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class YWAUXUMDKSE
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x83C3980", Offset = "0x83C2D80", VA = "0x1883C3980")]
		public static int UURFIFZLWOW(this JCSDFORPEFX a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x83C35C0", Offset = "0x83C29C0", VA = "0x1883C35C0")]
		public static void MKKHFOIXWNM(this JCSDFORPEFX a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class QUMPZHROCUC
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void RoomPropertyUpdateCallback(Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate void PlayerPropertyUpdateCallback(JCSDFORPEFX player, Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback IGJCTCTTRDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x83B8DA0", Offset = "0x83B81A0", VA = "0x1883B8DA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x83B8F20", Offset = "0x83B8320", VA = "0x1883B8F20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback QGKVJERJKUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x83B8FE0", Offset = "0x83B83E0", VA = "0x1883B8FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x83B8E60", Offset = "0x83B8260", VA = "0x1883B8E60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback EHPDAYQRUOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x83B90A0", Offset = "0x83B84A0", VA = "0x1883B90A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x83B8C20", Offset = "0x83B8020", VA = "0x1883B8C20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback VALIXOKDADX
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x83B8B60", Offset = "0x83B7F60", VA = "0x1883B8B60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x83B8CE0", Offset = "0x83B80E0", VA = "0x1883B8CE0")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class VHEBLMYFUZJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int MPKZKFMWJIV;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int GRWPZYBCYXL;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int KYLSVRQAYGT;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x83C08D0", Offset = "0x83BFCD0", VA = "0x1883C08D0")]
		public static void KNRVKKWMFQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x83C07F0", Offset = "0x83BFBF0", VA = "0x1883C07F0")]
		public static void GTGWVOCUOVA(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x83C0920", Offset = "0x83BFD20", VA = "0x1883C0920")]
		public static int LSRBXFIUVSV(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RegisterService(typeof(NCWIFCYCRCH), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class NCWIFCYCRCH : CJUCCXXOWJL, HNAKBHLVZRV, LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Dictionary<object, object> YUYJKVERBQA;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly Dictionary<object, object> AEPXPEPHTJW;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly Dictionary<object, object> JJLDDTDFJLW;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly FRDJWLZNOWA EPHGSQKDRZE;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly FRDJWLZNOWA UCETJTJUKWN;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly FRDJWLZNOWA LPLGGIDJFOJ;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly FRDJWLZNOWA QLVQVNRTMKY;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly FRDJWLZNOWA AQQGGRRIJFD;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static int FFZNOGLODOG;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x83B7090", Offset = "0x83B6490", VA = "0x1883B7090", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x83B7D30", Offset = "0x83B7130", VA = "0x1883B7D30", Slot = "19")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x83B6F60", Offset = "0x83B6360", VA = "0x1883B6F60", Slot = "4")]
		public bool GKQMWUFEMHW(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x83B61D0", Offset = "0x83B55D0", VA = "0x1883B61D0", Slot = "5")]
		public int CKCRKDHDUFW(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x83B7130", Offset = "0x83B6530", VA = "0x1883B7130", Slot = "6")]
		public bool KLOOOSQNXUL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x83B6750", Offset = "0x83B5B50", VA = "0x1883B6750", Slot = "7")]
		public bool DEOFDANRBUS(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x83B7B20", Offset = "0x83B6F20", VA = "0x1883B7B20", Slot = "8")]
		public void OOIITOOADMP(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x83B71C0", Offset = "0x83B65C0", VA = "0x1883B71C0", Slot = "9")]
		public bool MKSWNZBLONF(PTKTLSUVJWP a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x83B6C40", Offset = "0x83B6040", VA = "0x1883B6C40", Slot = "10")]
		public bool GFZDVVPVXRO(PTKTLSUVJWP a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x83B84E0", Offset = "0x83B78E0", VA = "0x1883B84E0", Slot = "11")]
		public bool WPYMEBBLMND(PTKTLSUVJWP a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x83B5F80", Offset = "0x83B5380", VA = "0x1883B5F80", Slot = "12")]
		public void BSKXFIIWACR(PTKTLSUVJWP a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x83B6900", Offset = "0x83B5D00", VA = "0x1883B6900", Slot = "13")]
		public void DJXGTLLXWAO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x83B65E0", Offset = "0x83B59E0", VA = "0x1883B65E0", Slot = "14")]
		public void CRTAPYHIBII(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x83B6B60", Offset = "0x83B5F60", VA = "0x1883B6B60", Slot = "15")]
		public void EEBQVUIXRMI(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x83B5E70", Offset = "0x83B5270", VA = "0x1883B5E70", Slot = "16")]
		public void BPZWIDQSVQD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x83B8320", Offset = "0x83B7720", VA = "0x1883B8320", Slot = "17")]
		public void UILUWRTWMNF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x83B7DD0", Offset = "0x83B71D0", VA = "0x1883B7DD0")]
		private static void TCNEPGFRPOG(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x83B7330", Offset = "0x83B6730", VA = "0x1883B7330")]
		private static bool MKSWNZBLONF(Dictionary<object, object> a, JCSDFORPEFX b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x83B6AC0", Offset = "0x83B5EC0", VA = "0x1883B6AC0")]
		private static bool DZXYEZBOKHO(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x83B8620", Offset = "0x83B7A20", VA = "0x1883B8620")]
		private static int ZOZOBVPKLLC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public NCWIFCYCRCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RegisterService(typeof(YIQTZVFBILX), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class YIQTZVFBILX : CXJOXAXQAJV, HNAKBHLVZRV, LGPJMXYAVLB
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static Hashtable RDNIZGRPWRN;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static Hashtable JBIKJBRTNBI;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static FRDJWLZNOWA EAKSNKXJPAD;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly FRDJWLZNOWA RTWTIHEQHNQ;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x83C1600", Offset = "0x83C0A00", VA = "0x1883C1600", Slot = "8")]
		public void RWVOXCJLGEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x83C1160", Offset = "0x83C0560", VA = "0x1883C1160", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x83C1520", Offset = "0x83C0920", VA = "0x1883C1520", Slot = "4")]
		public void PKGFWDHVDMH(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x83C1200", Offset = "0x83C0600", VA = "0x1883C1200", Slot = "5")]
		public bool JJQEVYCZEGH(PTKTLSUVJWP a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x83C16A0", Offset = "0x83C0AA0", VA = "0x1883C16A0", Slot = "6")]
		public void WUDTSSCGWMN(ViewId a, string b, RpcTarget c, JCSDFORPEFX d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public YIQTZVFBILX()
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
