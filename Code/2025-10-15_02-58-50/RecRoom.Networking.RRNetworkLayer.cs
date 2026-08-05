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
		[Cpp2IlInjected.Address(RVA = "0x85A7F80", Offset = "0x85A6D80", VA = "0x1885A7F80", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private int[] DAADMOFRSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] CZUWPHLUIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset RDSSOODTNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset RDXZLUXQWUR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x242C360", Offset = "0x242B160", VA = "0x18242C360", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85C22A0", Offset = "0x85C10A0", VA = "0x1885C22A0")]
		private void ZZHVSKGGGUO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85C29F0", Offset = "0x85C17F0", VA = "0x1885C29F0")]
		private void ZZNCPRADQFX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85C21F0", Offset = "0x85C0FF0", VA = "0x1885C21F0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85C2C50", Offset = "0x85C1A50", VA = "0x1885C2C50")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class TINGBHSGKCQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KUNNDCZWLAK;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static Log ZZTQQBHFIGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x85B0B20", Offset = "0x85AF920", VA = "0x1885B0B20")]
			get
			{
				return default(Log);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface AXYZMWVXRSO
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RRNetworkView AFDCBUJWASD
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		NetworkSynchronizationType TNUJESTZEUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool VZGLCVHAFDT
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "2")]
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
	internal interface VTRTXGWXHXA
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool FNBIWJHDRCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BQALNWGXLLR(NetworkSyncInfo a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Deserialize(NetworkSyncInfo info, BitPacker bitpacker);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public interface WVGADCWZHAB : INetworkUpdateSystem
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IPFDCTVTWHM(AXYZMWVXRSO a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VKYFMNNRBOB(AXYZMWVXRSO a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Pause(RCQHLSQFKLY.ApplyNetworkTransform applyNetworkTransform);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RDCKINMLVAI();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CMCIWOHMPJZ(object a);
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
	public class CFTHSXZODME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly Dictionary<(ViewId, NetworkSynchronizationType), VTRTXGWXHXA> OLGVLQJVZHT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<AXYZMWVXRSO> YNDJZWZZHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly HashSet<(ViewId, NetworkSynchronizationType)> AQCDYLYPKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int ZPSWZCCGZPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool LDVVZQEPATL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RCQHLSQFKLY.ApplyNetworkTransform WTQLOYOBUOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MemoryStream DTCTHHYJKJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly BitPacker VJZJUOOTJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly BitPacker XBKJPPTEHQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private byte[] LWELGRRNRJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float VSRNGSPFFOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int LCGLGTPRCHA;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85A3380", Offset = "0x85A2180", VA = "0x1885A3380")]
		public CFTHSXZODME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85A2B80", Offset = "0x85A1980", VA = "0x1885A2B80")]
		public void Pause(RCQHLSQFKLY.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85A2BA0", Offset = "0x85A19A0", VA = "0x1885A2BA0")]
		public void RDCKINMLVAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85A2F50", Offset = "0x85A1D50", VA = "0x1885A2F50")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85A1E50", Offset = "0x85A0C50", VA = "0x1885A1E50")]
		public bool Add(AXYZMWVXRSO networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85A2BF0", Offset = "0x85A19F0", VA = "0x1885A2BF0")]
		public bool Remove(AXYZMWVXRSO networkSynchronized)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85A2D40", Offset = "0x85A1B40", VA = "0x1885A2D40")]
		private VTRTXGWXHXA TIELAMUMOVX(ViewId a, NetworkSynchronizationType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85A27C0", Offset = "0x85A15C0", VA = "0x1885A27C0")]
		public void JIKXQFLSOTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85A3320", Offset = "0x85A2120", VA = "0x1885A3320")]
		private void YSFGPVZVEHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85A2D20", Offset = "0x85A1B20", VA = "0x1885A2D20")]
		private void SXVZPYLCNXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85A27D0", Offset = "0x85A15D0", VA = "0x1885A27D0")]
		public bool MXMMDHPOIPF(FastBufferWriter a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85A23D0", Offset = "0x85A11D0", VA = "0x1885A23D0")]
		public void Deserialize(NetworkSyncInfo info, FastBufferReader reader)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	internal class CXDNLUUPVUH : VTRTXGWXHXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AXYZMWVXRSO MDDWAAWXVOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private uint JVOTLBKFVTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int QLPTHQYTNXN;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool FNBIWJHDRCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public CXDNLUUPVUH(AXYZMWVXRSO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85A3570", Offset = "0x85A2370", VA = "0x1885A3570", Slot = "5")]
		public bool BQALNWGXLLR(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85A3680", Offset = "0x85A2480", VA = "0x1885A3680", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class XZMFUKMGGRC : VTRTXGWXHXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private RCQHLSQFKLY.ApplyNetworkTransform WTQLOYOBUOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly ViewId JTBWVEOYQXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int QLPTHQYTNXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint JVOTLBKFVTM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FNBIWJHDRCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1D078C0", Offset = "0x1D066C0", VA = "0x181D078C0")]
		public XZMFUKMGGRC(ViewId a, RCQHLSQFKLY.ApplyNetworkTransform b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85BF410", Offset = "0x85BE210", VA = "0x1885BF410", Slot = "5")]
		public bool BQALNWGXLLR(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85BF450", Offset = "0x85BE250", VA = "0x1885BF450", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public static class PSQUHUAJGZK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85A8460", Offset = "0x85A7260", VA = "0x1885A8460")]
		public static void HPFTFJWMZQX(this NetworkTransformSyncData a, BitPacker b, ViewId c, bool d = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85A8620", Offset = "0x85A7420", VA = "0x1885A8620")]
		public static void KUTDPYFOJGK(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85A82F0", Offset = "0x85A70F0", VA = "0x1885A82F0")]
		public static NetworkTransformSyncData Deserialize(BitPacker bitPacker, ViewId context, bool serializeAngularVelocity = true)
		{
			return default(NetworkTransformSyncData);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85A8B20", Offset = "0x85A7920", VA = "0x1885A8B20")]
		public static void ZKNOPRABPYX(this NetworkTransformSyncData a, BitPacker b, bool c = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(WVGADCWZHAB), new string[] { })]
	public class BXFBFRZFHMM : WVGADCWZHAB, INetworkUpdateSystem, IFVEAFHUJHU, BQLXQKHZRWO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Log QNIAZTKWDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private CFTHSXZODME PBTUHFPFOAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private uint LRHCQUCJGBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float XRJZNYNZAIQ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85A1340", Offset = "0x85A0140", VA = "0x1885A1340", Slot = "4")]
		public void IPFDCTVTWHM(AXYZMWVXRSO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85A17E0", Offset = "0x85A05E0", VA = "0x1885A17E0", Slot = "5")]
		public void VKYFMNNRBOB(AXYZMWVXRSO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85A1460", Offset = "0x85A0260", VA = "0x1885A1460", Slot = "10")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85A15B0", Offset = "0x85A03B0", VA = "0x1885A15B0", Slot = "9")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85A0D20", Offset = "0x859FB20", VA = "0x1885A0D20")]
		private void DWNEJCFFMSM(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85A1630", Offset = "0x85A0430", VA = "0x1885A1630", Slot = "6")]
		public void Pause(RCQHLSQFKLY.ApplyNetworkTransform applyNetworkTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85A1780", Offset = "0x85A0580", VA = "0x1885A1780", Slot = "7")]
		public void RDCKINMLVAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85A0CC0", Offset = "0x859FAC0", VA = "0x1885A0CC0", Slot = "8")]
		public void CMCIWOHMPJZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85A19E0", Offset = "0x85A07E0", VA = "0x1885A19E0")]
		private void YXNBLWXFTWG(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85A1660", Offset = "0x85A0460", VA = "0x1885A1660", Slot = "11")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85A1D70", Offset = "0x85A0B70", VA = "0x1885A1D70")]
		public BXFBFRZFHMM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UUPVBLIPJFQ : VTRTXGWXHXA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private float SFBERNMWZPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int QLPTHQYTNXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private uint JVOTLBKFVTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly NetworkSynchronizationType RFBSLUCHUNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public NetworkSyncInfo ATEMIFTSDYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int LQMSENFMYKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public byte[] UIXCJXEPXKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NetworkSyncInfo MJLAFCVAWRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int VAXPPROTOFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private byte[] AGDLVYZTSFS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FNBIWJHDRCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x85B2DA0", Offset = "0x85B1BA0", VA = "0x1885B2DA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85B30A0", Offset = "0x85B1EA0", VA = "0x1885B30A0")]
		public UUPVBLIPJFQ(NetworkSynchronizationType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85B2BB0", Offset = "0x85B19B0", VA = "0x1885B2BB0", Slot = "5")]
		public bool BQALNWGXLLR(NetworkSyncInfo a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85B2BF0", Offset = "0x85B19F0", VA = "0x1885B2BF0", Slot = "6")]
		public void Deserialize(NetworkSyncInfo info, BitPacker bitpacker)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85B2FA0", Offset = "0x85B1DA0", VA = "0x1885B2FA0")]
		internal CXDNLUUPVUH LMCGYMFTFDI(AXYZMWVXRSO a, BitPacker b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85B2DD0", Offset = "0x85B1BD0", VA = "0x1885B2DD0")]
		private static void HOTVOXRNXXW(CXDNLUUPVUH a, BitPacker b, NetworkSyncInfo c, byte[] d, int e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[RegisterService(typeof(WRDCLWOAYBT), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class WRDCLWOAYBT : ZHXZBWHQFPK, IFVEAFHUJHU, BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Hashtable XPZRLSTHSCR;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Hashtable APEXVOUFCGR;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Hashtable RLWTUBETTXD;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly ZPXXLQJTGDJ IAXUVIQYOVV;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly ZPXXLQJTGDJ IVEKEAZXFMG;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly ZPXXLQJTGDJ VADYUBXSZYK;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static readonly ZPXXLQJTGDJ ZMQTKHVMCXB;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static readonly ZPXXLQJTGDJ WPPDDQHPWCW;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static int XLYNVNTOJFJ;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85BD000", Offset = "0x85BBE00", VA = "0x1885BD000", Slot = "4")]
		public bool BGXYLVWJHKP(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85BDCF0", Offset = "0x85BCAF0", VA = "0x1885BDCF0", Slot = "5")]
		public int SMLRAVDNNFB(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85BD2D0", Offset = "0x85BC0D0", VA = "0x1885BD2D0", Slot = "6")]
		public bool IGACLUPHIXM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85BD360", Offset = "0x85BC160", VA = "0x1885BD360", Slot = "7")]
		public bool IGZTPTBPNOT(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB10", Offset = "0x85BC910", VA = "0x1885BDB10", Slot = "8")]
		public void QZZKPXBTRVU(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85BE0A0", Offset = "0x85BCEA0", VA = "0x1885BE0A0", Slot = "9")]
		public bool ULIGVHSCTXQ(PQDMMRYYGHS a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85BE7B0", Offset = "0x85BD5B0", VA = "0x1885BE7B0", Slot = "10")]
		public bool VIWVDZYOJPR(PQDMMRYYGHS a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85BD850", Offset = "0x85BC650", VA = "0x1885BD850", Slot = "11")]
		public bool NCEBPMCLVCQ(PQDMMRYYGHS a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85BEA80", Offset = "0x85BD880", VA = "0x1885BEA80", Slot = "12")]
		public void XKWXYXBPTCU(PQDMMRYYGHS a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85BD6F0", Offset = "0x85BC4F0", VA = "0x1885BD6F0", Slot = "13")]
		public void LSGSPLUQTIP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85BD960", Offset = "0x85BC760", VA = "0x1885BD960", Slot = "14")]
		public void ONHYGVDBAVZ(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85BD140", Offset = "0x85BBF40", VA = "0x1885BD140", Slot = "15")]
		public void BJRAIHIQEIZ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85BEC50", Offset = "0x85BDA50", VA = "0x1885BEC50", Slot = "16")]
		public void YLMHFCLXLXK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85BD590", Offset = "0x85BC390", VA = "0x1885BD590", Slot = "17")]
		public void KFLHLYVUSIS(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85BED20", Offset = "0x85BDB20", VA = "0x1885BED20")]
		private static void YMUUUQNDAHB(InstantiateParameters a, Hashtable b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85BE210", Offset = "0x85BD010", VA = "0x1885BE210")]
		private static bool ULIGVHSCTXQ(Hashtable a, LZEYQUPSRUQ b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85BD1F0", Offset = "0x85BBFF0", VA = "0x1885BD1F0")]
		private static int IDJVFSDOQVX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85BD4F0", Offset = "0x85BC2F0", VA = "0x1885BD4F0", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85BDA70", Offset = "0x85BC870", VA = "0x1885BDA70", Slot = "19")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WRDCLWOAYBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RegisterService(typeof(STIQXVQERBR), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class STIQXVQERBR : NLUUQDIMWGS, IFVEAFHUJHU, BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static Hashtable HPUKDBLDQKS;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private static Hashtable JKKZWFAYTHH;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static ZPXXLQJTGDJ HUGFKYIFBAY;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly ZPXXLQJTGDJ NPOQGJGIBRX;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85B04D0", Offset = "0x85AF2D0", VA = "0x1885B04D0", Slot = "4")]
		public void NGVUUBCWLUC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85B05B0", Offset = "0x85AF3B0", VA = "0x1885B05B0", Slot = "5")]
		public bool NIRASQTWJAK(PQDMMRYYGHS a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85AFD90", Offset = "0x85AEB90", VA = "0x1885AFD90", Slot = "6")]
		public void FKXNPTJTRIM(ViewId a, string b, RpcTarget c, LZEYQUPSRUQ d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x85B08D0", Offset = "0x85AF6D0", VA = "0x1885B08D0", Slot = "8")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85B0430", Offset = "0x85AF230", VA = "0x1885B0430", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public STIQXVQERBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class VMPYRCTWVPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85B3170", Offset = "0x85B1F70", VA = "0x1885B3170")]
		public static LZEYQUPSRUQ MSOXZFNULSE(this PlayerId a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85B3200", Offset = "0x85B2000", VA = "0x1885B3200")]
		public static PlayerId ToPlayerId(this LZEYQUPSRUQ player)
		{
			return default(PlayerId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RRNetworkBehavior : MonoBehaviour, FWMXFMUJXBK, XQQWUKBJKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool JXESWQSOPBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private RRNetworkView XDJNOCUKAGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<MKDAPDYTKQJ> RUEANZTLMSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool KDVQQRGNJDZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ViewId NZZBLJUVSOO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85A9740", Offset = "0x85A8540", VA = "0x1885A9740")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ViewId IJGXCDMRXYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x85A9740", Offset = "0x85A8540", VA = "0x1885A9740", Slot = "4")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[Obsolete("Use NetworkedView instead")]
		public RRNetworkView EHFRFNTUGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x85A97C0", Offset = "0x85A85C0", VA = "0x1885A97C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RRNetworkView AFDCBUJWASD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x85A97C0", Offset = "0x85A85C0", VA = "0x1885A97C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LZEYQUPSRUQ FNEQBLRGMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x85A98C0", Offset = "0x85A86C0", VA = "0x1885A98C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LZEYQUPSRUQ BNUTWBMFIVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x85A9C20", Offset = "0x85A8A20", VA = "0x1885A9C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool PWRAUDJQPUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x85A9A20", Offset = "0x85A8820", VA = "0x1885A9A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LLKABZPHKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x85A9B90", Offset = "0x85A8990", VA = "0x1885A9B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool SEOSNDDQYQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x85A9670", Offset = "0x85A8470", VA = "0x1885A9670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DKZVEHTPCQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x85A9950", Offset = "0x85A8750", VA = "0x1885A9950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool RYOBENBYJUC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x85A9670", Offset = "0x85A8470", VA = "0x1885A9670", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool NDYWGDVYHDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85A96F0", Offset = "0x85A84F0", VA = "0x1885A96F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string MRJAWLBROKO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x85A9830", Offset = "0x85A8630", VA = "0x1885A9830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool OZZPUQTSJTT
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x85A95F0", Offset = "0x85A83F0", VA = "0x1885A95F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<LZEYQUPSRUQ> NWOUULSPVQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x85A94C0", Offset = "0x85A82C0", VA = "0x1885A94C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x85A9CB0", Offset = "0x85A8AB0", VA = "0x1885A9CB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85A9420", Offset = "0x85A8220", VA = "0x1885A9420")]
		public bool WasSpawnedForPlayer(int playerActorNumber)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x78C8F30", Offset = "0x78C7D30", VA = "0x1878C8F30")]
		private void JJOETTCEKVG(RRNetworkView a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x85A9020", Offset = "0x85A7E20", VA = "0x1885A9020", Slot = "9")]
		public void RegisterDestroyHandler(MKDAPDYTKQJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85A9260", Offset = "0x85A8060", VA = "0x1885A9260", Slot = "10")]
		public void UnregisterDestroyHandler(MKDAPDYTKQJ handler)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85A9000", Offset = "0x85A7E00", VA = "0x1885A9000", Slot = "12")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public RRNetworkBehavior()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class TXOWRETCCFM
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void NetworkInstantiateCallback([In] InstantiateParameters parameters, bool sceneObject, bool instantiateEvent, bool destroyOnLeave);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void InstantiateCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void DestroyCallback(GameObject go);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCInvokedCallback(RRNetworkView view, string methodName, LZEYQUPSRUQ targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCSendingCallback(RRNetworkView view, string methodName, LZEYQUPSRUQ targetPlayer, RpcTarget? target, bool encrypt, RpcCacheOption caching, object[] parameters, string targetStr);

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public delegate void RPCReceivedCallback(RRNetworkView view, string methodName, object[] arguments, string senderStr);

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public delegate void OnOwnershipTransferedHandler(RRNetworkView view, LZEYQUPSRUQ newOwner);

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[CompilerGenerated]
		private static InstantiateCallback HXUQNQNQTNE;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public static event NetworkInstantiateCallback MBGGVXDYNBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x85B1530", Offset = "0x85B0330", VA = "0x1885B1530")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x85B1830", Offset = "0x85B0630", VA = "0x1885B1830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public static event InstantiateCallback GCEFKGNBRTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x85B1770", Offset = "0x85B0570", VA = "0x1885B1770")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x85B18F0", Offset = "0x85B06F0", VA = "0x1885B18F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public static event DestroyCallback PFREUCBQGXT
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x85B0D60", Offset = "0x85AFB60", VA = "0x1885B0D60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x85B1180", Offset = "0x85AFF80", VA = "0x1885B1180")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public static event DestroyCallback WGFISKFKXYE
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x85B0BE0", Offset = "0x85AF9E0", VA = "0x1885B0BE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x85B1C80", Offset = "0x85B0A80", VA = "0x1885B1C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public static event RPCInvokedCallback ORPRGCHPOYC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x85B1A70", Offset = "0x85B0870", VA = "0x1885B1A70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x85B19B0", Offset = "0x85B07B0", VA = "0x1885B19B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public static event RPCSendingCallback GKWJFAFFSQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x85B1470", Offset = "0x85B0270", VA = "0x1885B1470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x85B1B30", Offset = "0x85B0930", VA = "0x1885B1B30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public static event RPCReceivedCallback BTPHQWJRZJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x85B16B0", Offset = "0x85B04B0", VA = "0x1885B16B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x85B1030", Offset = "0x85AFE30", VA = "0x1885B1030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public static event OnOwnershipTransferedHandler YGUROQUMUGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x85B0F70", Offset = "0x85AFD70", VA = "0x1885B0F70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x85B15F0", Offset = "0x85B03F0", VA = "0x1885B15F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public static event OnOwnershipTransferedHandler ASULQDGQMSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x85B0CA0", Offset = "0x85AFAA0", VA = "0x1885B0CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x85B1D40", Offset = "0x85B0B40", VA = "0x1885B1D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E00", Offset = "0x85B0C00", VA = "0x1885B1E00")]
		public static void ZEOMUGGNZHC([In] InstantiateParameters parameters, bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x85B10F0", Offset = "0x85AFEF0", VA = "0x1885B10F0")]
		public static void MHNGHJBTPAW(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x85B1BF0", Offset = "0x85B09F0", VA = "0x1885B1BF0")]
		public static void WWYULKSRPQN(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x85B1240", Offset = "0x85B0040", VA = "0x1885B1240")]
		public static void NALYGNZPIXS(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x85B12D0", Offset = "0x85B00D0", VA = "0x1885B12D0")]
		public static void NVVNRHAVTRZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x85B1EC0", Offset = "0x85B0CC0", VA = "0x1885B1EC0")]
		public static void ZSWEIWLTEHJ(RRNetworkView a, string b, LZEYQUPSRUQ c, RpcTarget? d, bool e, RpcCacheOption f, object[] g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85B0E20", Offset = "0x85AFC20", VA = "0x1885B0E20")]
		public static void DYTIUDALCFU(RRNetworkView a, string b, int c, object[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85B1360", Offset = "0x85B0160", VA = "0x1885B1360")]
		public static void OFHAGOWEDRU(int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class GLNWIQGIWMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x85A7560", Offset = "0x85A6360", VA = "0x1885A7560")]
		[CanBeNull]
		private static bool VRVVFILIUUD(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x85A7480", Offset = "0x85A6280", VA = "0x1885A7480")]
		[CanBeNull]
		public static Component SPUSMDHZQET(this ViewId a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x38F4080", Offset = "0x38F2E80", VA = "0x1838F4080")]
		[CanBeNull]
		public static a SPUSMDHZQET<a>(this ViewId a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x38F4230", Offset = "0x38F3030", VA = "0x1838F4230")]
		[CanBeNull]
		public static b XPKEMAPMRVB<b>(this ViewId a)
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x38F41A0", Offset = "0x38F2FA0", VA = "0x1838F41A0")]
		public static bool TZBUIQCKIMW<c>(this ViewId a, [Out] c b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x85A7410", Offset = "0x85A6210", VA = "0x1885A7410")]
		[CanBeNull]
		public static RRNetworkView PQWWLVDWSIO(this ViewId a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RRNetworkHandler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static RRNetworkHandler YKIIEGGLVSM;

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static bool AppQuits;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		internal static RRNetworkHandler VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x85A9DE0", Offset = "0x85A8BE0", VA = "0x1885A9DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x85A9FB0", Offset = "0x85A8DB0", VA = "0x1885A9FB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void StaticReset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x85A9F70", Offset = "0x85A8D70", VA = "0x1885A9F70")]
		protected void OnApplicationQuit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public RRNetworkHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RegisterService(typeof(WCMHDCMXZCX), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public sealed class WCMHDCMXZCX : IXHWWEEMCTM, IFVEAFHUJHU, BQLXQKHZRWO, XBOLCYDYDAA, OZGSEXBXCXO, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LUVYHIUWUHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public int TEEYWWUUJBD;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LUVYHIUWUHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x85A7E80", Offset = "0x85A6C80", VA = "0x1885A7E80")]
			internal object VMKLBRVFERY((int requestedViewId, int newOwnerId, int senderId) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static Log KMEZCLTJBTU;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static Log GTUFOZAZXIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[DependsOn]
		private EDSLAJEBCZX VGZUCOBVBYG;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private static Dictionary<int, HashSet<int>> EYCIOSHLWRO;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static Dictionary<int, int> NNAPXGEKXGV;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<(GameObject GameObject, int ParentCount)> VKOUUUFAYAM;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<GameObject> TOUDHZYQBXT;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static List<int> MMULDLRLBEP;

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private static readonly List<RRNetworkView> QVLCHDPIZCF;

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private static readonly ZPXXLQJTGDJ ZMQTKHVMCXB;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly ZPXXLQJTGDJ WPPDDQHPWCW;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x85B6E10", Offset = "0x85B5C10", VA = "0x1885B6E10", Slot = "8")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85BA160", Offset = "0x85B8F60", VA = "0x1885BA160", Slot = "9")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85B6C50", Offset = "0x85B5A50", VA = "0x1885B6C50", Slot = "10")]
		public void InitExternal(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85B7160", Offset = "0x85B5F60", VA = "0x1885B7160", Slot = "11")]
		public void JKEMGOBUBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85BBAA0", Offset = "0x85BA8A0", VA = "0x1885BBAA0")]
		private void VZRGVHYCGEE(ClientState a, ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85B4D90", Offset = "0x85B3B90", VA = "0x1885B4D90")]
		private void DVLHAEQGNCF(RBETLIDWDVR a, RBETLIDWDVR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85B68E0", Offset = "0x85B56E0", VA = "0x1885B68E0")]
		public GameObject IDJQWSIAXYJ(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85B6AE0", Offset = "0x85B58E0", VA = "0x1885B6AE0")]
		public GameObject IOOWYHLTAIR(string a, Vector3 b, Quaternion c, float d, object[] e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85B7F50", Offset = "0x85B6D50", VA = "0x1885B7F50")]
		public GameObject LMUCMCSXYVG(string a, Vector3 b, Quaternion c, Vector3 d, ViewId e, CreationInstantiationParameters f, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x85B6AB0", Offset = "0x85B58B0", VA = "0x1885B6AB0")]
		public GameObject IGDGHRIOVOK(InstantiateParameters a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85B9040", Offset = "0x85B7E40", VA = "0x1885B9040", Slot = "6")]
		public void NRVHMNAFHTM(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85B6BE0", Offset = "0x85B59E0", VA = "0x1885B6BE0")]
		public void IWPYUJCCEQH(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85B6670", Offset = "0x85B5470", VA = "0x1885B6670", Slot = "7")]
		public void HRNZTBZXOCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x85B9B10", Offset = "0x85B8910", VA = "0x1885B9B10", Slot = "4")]
		public GameObject[] OMTWEHZEBKE(IList<HWBSQPITHTV> a, bool b = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x85B7320", Offset = "0x85B6120", VA = "0x1885B7320", Slot = "5")]
		public void JRSUDGLWOQP(List<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85BBCC0", Offset = "0x85BAAC0", VA = "0x1885BBCC0")]
		public void XBQTFXYYEAR(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85BC610", Offset = "0x85BB410", VA = "0x1885BC610")]
		private void YXNBLWXFTWG(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85B47D0", Offset = "0x85B35D0", VA = "0x1885B47D0")]
		private void AWHMWQZDGVO(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85B6680", Offset = "0x85B5480", VA = "0x1885B6680")]
		private void IAWEQXJBSQO(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85BC920", Offset = "0x85BB720", VA = "0x1885BC920")]
		private void YZIXEWAMMQO(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85B5BB0", Offset = "0x85B49B0", VA = "0x1885B5BB0")]
		private void FDRWQXWIJRM(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85B8E50", Offset = "0x85B7C50", VA = "0x1885B8E50")]
		private void NQRSLQXYHBQ(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x85B5FA0", Offset = "0x85B4DA0", VA = "0x1885B5FA0")]
		private void FXHFRNBLTAM(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85B45E0", Offset = "0x85B33E0", VA = "0x1885B45E0")]
		private GameObject APEVQDNFUGT(string a, Vector3 b, Quaternion c, Vector3 d, byte e = 0, [Optional] object[] f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85B8750", Offset = "0x85B7550", VA = "0x1885B8750")]
		private GameObject MHEPKCBHMWZ(InstantiateParameters a, bool b = false, bool c = false, bool d = true, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85B7C10", Offset = "0x85B6A10", VA = "0x1885B7C10")]
		private static GameObject KVVAQFFYNFB(string a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85BB4A0", Offset = "0x85BA2A0", VA = "0x1885BB4A0")]
		private static GameObject TZANFGXRLPI(GameObject a, InstantiateParameters b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85B7B00", Offset = "0x85B6900", VA = "0x1885B7B00")]
		private static void KJVSNXJPYAN(GameObject a, RRNetworkView b, [In] InstantiateParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85BBDA0", Offset = "0x85BABA0", VA = "0x1885BBDA0")]
		private GameObject[] XYSDNEOLMZS(IList<HWBSQPITHTV> a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85B7C90", Offset = "0x85B6A90", VA = "0x1885B7C90")]
		private GameObject[] LLMBLMFUDAK(InstantiateParameters[] a, int b, LZEYQUPSRUQ c, GameObject[] d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85B76F0", Offset = "0x85B64F0", VA = "0x1885B76F0")]
		private GameObject KJMCPAVLAXO([In] InstantiateParameters parameters, GameObject a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x789D5A0", Offset = "0x789C3A0", VA = "0x18789D5A0")]
		private static bool JBCAUWFWSAB(bool a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85B4E80", Offset = "0x85B3C80", VA = "0x1885B4E80")]
		private void DYDIFGHUCZX(IEnumerable<GameObject> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85BA590", Offset = "0x85B9390", VA = "0x1885BA590")]
		private void QWFKOEEKPFX(GameObject a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85B49A0", Offset = "0x85B37A0", VA = "0x1885B49A0")]
		private static void DERROCINWEM(IEnumerable<GameObject> a, List<(GameObject GameObject, int ParentCount)> orderedResults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85BB8F0", Offset = "0x85BA6F0", VA = "0x1885BB8F0")]
		private void VOZLUETNRNO(int a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85BCBA0", Offset = "0x85BB9A0", VA = "0x1885BCBA0")]
		private static int ZMWTMFWXTYY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85B6610", Offset = "0x85B5410", VA = "0x1885B6610")]
		private void HGNVZBBMNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85B81D0", Offset = "0x85B6FD0", VA = "0x1885B81D0")]
		private void LOOPRQMHNVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85B65B0", Offset = "0x85B53B0", VA = "0x1885B65B0")]
		private static int GIQVNIISCWM(int a, bool b = true)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85BA4B0", Offset = "0x85B92B0", VA = "0x1885BA4B0")]
		private static int[] QUKEUAASVOB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85B5AB0", Offset = "0x85B48B0", VA = "0x1885B5AB0")]
		private static int[] EAAUFTGMZCR(int a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x85BA120", Offset = "0x85B8F20", VA = "0x1885BA120")]
		private void OnMasterClientSwitched(LZEYQUPSRUQ newMasterClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x85B9050", Offset = "0x85B7E50", VA = "0x1885B9050")]
		private void NWULNUHSRQV(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85B9E40", Offset = "0x85B8C40", VA = "0x1885B9E40")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x85BB6B0", Offset = "0x85BA4B0", VA = "0x1885BB6B0")]
		private void VDRCOKLMXIV(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x85BC570", Offset = "0x85BB370", VA = "0x1885BC570")]
		private static void YSLXZOYCIIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x85BBBC0", Offset = "0x85BA9C0", VA = "0x1885BBBC0")]
		private void WDORJEXYAYT(int[] a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85BBA50", Offset = "0x85BA850", VA = "0x1885BBA50", Slot = "12")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xFCB1A0", Offset = "0xFC9FA0", VA = "0x180FCB1A0", Slot = "13")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WCMHDCMXZCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RRNetworkProfiler : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public RRNetworkProfiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RegisterService(typeof(ECPCDRYMWPT), new string[] { "Photon" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class ECPCDRYMWPT : IFVEAFHUJHU, BQLXQKHZRWO, QXSZZHJGVNS
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
			[Cpp2IlInjected.Address(RVA = "0xCBE300", Offset = "0xCBD100", VA = "0x180CBE300")]
			public RpcMethodInfo(MethodInfo methodInfo, [Optional] Func<MonoBehaviour, object> accessor)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x789C600", Offset = "0x789B400", VA = "0x18789C600")]
			public object XDUSOZNCITZ(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class EUSAGERKPOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public FieldInfo EPDMUTFNGKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Func<MonoBehaviour, object> JNTKTDGAOQT;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public EUSAGERKPOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x85A7350", Offset = "0x85A6150", VA = "0x1885A7350")]
			internal RpcMethodInfo SXERWSRZMPT(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x5367E80", Offset = "0x5366C80", VA = "0x185367E80")]
			internal object SWZKZLYCDEK(MonoBehaviour a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class EUMTIXXNGDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public Func<MonoBehaviour, object> JTWDPKLSNMA;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public EUMTIXXNGDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x78B6A50", Offset = "0x78B5850", VA = "0x1878B6A50")]
			internal RpcMethodInfo SXJYTZLWWBC(MethodInfo a)
			{
				return default(RpcMethodInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class LXCOCJKLUFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public Type REKRMDUAIHX;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public LXCOCJKLUFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x85A7F40", Offset = "0x85A6D40", VA = "0x1885A7F40")]
			internal bool PFIADDRTXFT(MethodInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static Dictionary<string, int> TKNPUJOKFSV;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static List<string> ZJJHAJYMSAI;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int PHZEJPIIARL;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static readonly Stopwatch NDIECVEJVZL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static Dictionary<MethodInfo, ParameterInfo[]> KBDYXLENIWY;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Dictionary<Type, List<RpcMethodInfo>> SICOEWKDEOD;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x85A37F0", Offset = "0x85A25F0", VA = "0x1885A37F0", Slot = "4")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85A5D10", Offset = "0x85A4B10", VA = "0x1885A5D10", Slot = "5")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x85A3760", Offset = "0x85A2560", VA = "0x1885A3760")]
		public static bool AKUHZEXMREX(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x85A6D40", Offset = "0x85A5B40", VA = "0x1885A6D40")]
		public static bool YMPHLBCLSHV(int a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85A6E30", Offset = "0x85A5C30", VA = "0x1885A6E30")]
		private void YXNBLWXFTWG(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x85A6730", Offset = "0x85A5530", VA = "0x1885A6730", Slot = "9")]
		public string TVTZGRBPFPX(PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x85A3E20", Offset = "0x85A2C20", VA = "0x1885A3E20", Slot = "8")]
		public void NGVUUBCWLUC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x85A6C70", Offset = "0x85A5A70", VA = "0x1885A6C70", Slot = "6")]
		public void YMGTTEPZWOG(ViewId a, string b, LZEYQUPSRUQ c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x85A6C40", Offset = "0x85A5A40", VA = "0x1885A6C40", Slot = "7")]
		public void YMGTTEPZWOG(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x85A6760", Offset = "0x85A5560", VA = "0x1885A6760")]
		private void YMGTTEPZWOG(ViewId a, string b, RpcTarget c, LZEYQUPSRUQ d, RpcCacheOption e, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x85A3F00", Offset = "0x85A2D00", VA = "0x1885A3F00")]
		private void OCFJMSFKVOZ(ViewId a, string b, LZEYQUPSRUQ c, int d, object[] e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85A5530", Offset = "0x85A4330", VA = "0x1885A5530")]
		private static void OQJXXISMTNR(RpcMethodInfo a, MonoBehaviour b, object[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x85A5B00", Offset = "0x85A4900", VA = "0x1885A5B00")]
		private static bool PXUPBCWJKBI(ParameterInfo[] a, Type[] b, [Out] bool c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x85A5E60", Offset = "0x85A4C60", VA = "0x1885A5E60")]
		private List<RpcMethodInfo> QJEGMNANKBD(MonoBehaviour a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x85A3D20", Offset = "0x85A2B20", VA = "0x1885A3D20")]
		private static IEnumerable<MethodInfo> NFKGFBJXXCD(Type a, Type b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x85A59F0", Offset = "0x85A47F0", VA = "0x1885A59F0")]
		public static ParameterInfo[] OYJOZOQJRLB(MethodInfo a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ECPCDRYMWPT()
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
			[Cpp2IlInjected.Address(RVA = "0x85AA070", Offset = "0x85A8E70", VA = "0x1885AA070")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85A9FF0", Offset = "0x85A8DF0", VA = "0x1885A9FF0")]
		public RRNetworkSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class RRNetworkView : MonoBehaviour, FJLOWAMHGGV, DTDVLMBXLIS, GXSSDXPNARJ, PBJWDCWWANP, AYXISKATXWY
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		[RegisterService(typeof(EDSLAJEBCZX), new string[] { })]
		internal class JXGURBCVKGG : IFVEAFHUJHU, BQLXQKHZRWO, EDSLAJEBCZX
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Dictionary<int, RRNetworkView> CRUMLVKYUVR;

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x85A7A90", Offset = "0x85A6890", VA = "0x1885A7A90", Slot = "4")]
			public void InitInternal()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x85A7A90", Offset = "0x85A6890", VA = "0x1885A7A90", Slot = "5")]
			public void QDLPFTNMELS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x85A7AA0", Offset = "0x85A68A0", VA = "0x1885A7AA0", Slot = "6")]
			public void WDQSRXGAMLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public JXGURBCVKGG()
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
		private sealed class VFMVPEYKGXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public int ERDZERBDSTP;

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public VFMVPEYKGXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x85B3110", Offset = "0x85B1F10", VA = "0x1885B3110")]
			internal bool NTUTARLNHMT(RRNetworkView a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static ZPXXLQJTGDJ OBKVQQGRMMP;

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
		private bool LWKZMMJNIQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[TooltipAttribute("By default, prefabs cannot contain hard coded values for viewIdField; singletons that need to have consistent viewIdField across clients may set this flag to disable automatic cleaning of the property viewIdField")]
		public HasExplicitViewId hasExplicitViewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private bool NRHSBDBYRYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool LLFYZFNTIXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int MBAGYBVEKZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool HYMAXYLYQCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int WYFHWKQTXJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private LZEYQUPSRUQ BNUTWBMFIVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private LZEYQUPSRUQ WFYDMEXWHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool? XQZXIUAMWIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private bool BDKBBQZWLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		internal bool DMOGSXUKEYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		internal MonoBehaviour[] EBGUAEJJBCV;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static readonly Log VZKKAJCWHKC;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private static Dictionary<int, RRNetworkView> CRUMLVKYUVR
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x85AA8A0", Offset = "0x85A96A0", VA = "0x1885AA8A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ViewId IJGXCDMRXYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x85AE6F0", Offset = "0x85AD4F0", VA = "0x1885AE6F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public ViewId QJODXRXFMPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x85AE6F0", Offset = "0x85AD4F0", VA = "0x1885AE6F0", Slot = "5")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public ViewId NZZBLJUVSOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x85AE6F0", Offset = "0x85AD4F0", VA = "0x1885AE6F0")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int QQAQOAJZCOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAFF070", Offset = "0xAFDE70", VA = "0x180AFF070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MQLEKYFPTUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAC5E20", Offset = "0xAC4C20", VA = "0x180AC5E20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xF654B0", Offset = "0xF642B0", VA = "0x180F654B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ViewId RVFZOEVDVCP
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x85AE560", Offset = "0x85AD360", VA = "0x1885AE560")]
			get
			{
				return default(ViewId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ERAYSHZRVMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xCB7060", Offset = "0xCB5E60", VA = "0x180CB7060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xCB7050", Offset = "0xCB5E50", VA = "0x180CB7050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool QKAFWMMRGTS
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x85AE570", Offset = "0x85AD370", VA = "0x1885AE570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool ZAWHGLURKQH
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xB009E0", Offset = "0xAFF7E0", VA = "0x180B009E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xB01120", Offset = "0xAFFF20", VA = "0x180B01120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int FULDSEHZYTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAEC640", Offset = "0xAEB440", VA = "0x180AEC640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int DVMPSYIBGOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x85AE500", Offset = "0x85AD300", VA = "0x1885AE500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public LZEYQUPSRUQ XZHGVSHYZSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x85AE700", Offset = "0x85AD500", VA = "0x1885AE700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public LZEYQUPSRUQ FGBHVLJGKCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x85AE4D0", Offset = "0x85AD2D0", VA = "0x1885AE4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public LZEYQUPSRUQ FNEQBLRGMAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x85AE4D0", Offset = "0x85AD2D0", VA = "0x1885AE4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public LZEYQUPSRUQ JELEMJNGUCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x85AE4D0", Offset = "0x85AD2D0", VA = "0x1885AE4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool GDWUVLIOTLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x85AE640", Offset = "0x85AD440", VA = "0x1885AE640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int WUGCNKJKQMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x85AE530", Offset = "0x85AD330", VA = "0x1885AE530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public object[] TAHVYXACWUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAA19B0", Offset = "0xAA07B0", VA = "0x180AA19B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool PWRAUDJQPUO
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x85AE730", Offset = "0x85AD530", VA = "0x1885AE730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool ADZLEZMAXPK
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x85AE6C0", Offset = "0x85AD4C0", VA = "0x1885AE6C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IUVDVSDYVBP
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x10124B0", Offset = "0x10112B0", VA = "0x1810124B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x10124A0", Offset = "0x10112A0", VA = "0x1810124A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool QYGWXXOFOJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB82730", Offset = "0xB81530", VA = "0x180B82730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<RRNetworkView> XKEELNFJXRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x85AE360", Offset = "0x85AD160", VA = "0x1885AE360")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x85AE8F0", Offset = "0x85AD6F0", VA = "0x1885AE8F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		private event Action<LZEYQUPSRUQ> VCYFLXNMCBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x85AE130", Offset = "0x85ACF30", VA = "0x1885AE130")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x85AB640", Offset = "0x85AA440", VA = "0x1885AB640")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<LZEYQUPSRUQ> ZTRBWFZTGNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x85AE130", Offset = "0x85ACF30", VA = "0x1885AE130")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x85AB640", Offset = "0x85AA440", VA = "0x1885AB640")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		private event Action<int> WDLZOPXUOFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x85AD790", Offset = "0x85AC590", VA = "0x1885AD790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x85ADBF0", Offset = "0x85AC9F0", VA = "0x1885ADBF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action<int> SILBRRIYPRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x85AD790", Offset = "0x85AC590", VA = "0x1885AD790")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x85ADBF0", Offset = "0x85AC9F0", VA = "0x1885ADBF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<RRNetworkView> LXFHDALNTSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x85AE410", Offset = "0x85AD210", VA = "0x1885AE410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x85AE9A0", Offset = "0x85AD7A0", VA = "0x1885AE9A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		public event Action HEIYDDGDXNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x85AE2B0", Offset = "0x85AD0B0", VA = "0x1885AE2B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x85AE840", Offset = "0x85AD640", VA = "0x1885AE840")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x85ADA90", Offset = "0x85AC890", VA = "0x1885ADA90")]
		public static bool TryGetNetworkView(int viewId, [Out] RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x85AA8F0", Offset = "0x85A96F0", VA = "0x1885AA8F0")]
		public static RRNetworkView Find(int viewId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85AAA60", Offset = "0x85A9860", VA = "0x1885AAA60")]
		public static IEnumerable<RRNetworkView> GetCreatedAndOwnedNetworkViews(int actorNumber)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x85AA9B0", Offset = "0x85A97B0", VA = "0x1885AA9B0")]
		public static IEnumerable<RRNetworkView> GetAllNetworkViews()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x85ABE20", Offset = "0x85AAC20", VA = "0x1885ABE20")]
		public static bool RemoveNetworkView(RRNetworkView view)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x85ABBC0", Offset = "0x85AA9C0", VA = "0x1885ABBC0")]
		public static void RebuildControllCacheForAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85AB2D0", Offset = "0x85AA0D0", VA = "0x1885AB2D0")]
		public static void OnPlayerJoinedRoom(LZEYQUPSRUQ newPlayer, List<int> viewOwnerPairs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85AABD0", Offset = "0x85A99D0", VA = "0x1885AABD0")]
		public static RRNetworkView Get(Component component)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x85AAC30", Offset = "0x85A9A30", VA = "0x1885AAC30")]
		public static RRNetworkView Get(GameObject gameObj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x85AA7C0", Offset = "0x85A95C0", VA = "0x1885AA7C0")]
		private void DJISXNQAOOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85AA740", Offset = "0x85A9540", VA = "0x1885AA740")]
		public bool CreatedBy(LZEYQUPSRUQ player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD8A0", Offset = "0x85AC6A0", VA = "0x1885AD8A0")]
		public void TransferOwnership(int newOwnerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85AD840", Offset = "0x85AC640", VA = "0x1885AD840")]
		public void TransferOwnership(LZEYQUPSRUQ newOwner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x85AAD60", Offset = "0x85A9B60", VA = "0x1885AAD60", Slot = "4")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85AAD00", Offset = "0x85A9B00", VA = "0x1885AAD00")]
		public void Initialize(ViewId subViewId, ViewId rootViewId, object[] instantiationData, PlayerId owner)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x85AA240", Offset = "0x85A9040", VA = "0x1885AA240")]
		protected internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x85AB830", Offset = "0x85AA630", VA = "0x1885AB830")]
		private void RPCCPJORAHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2129520", Offset = "0x2128320", VA = "0x182129520")]
		internal void UQJQVBCHTLW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85AAED0", Offset = "0x85A9CD0", VA = "0x1885AAED0", Slot = "6")]
		private void JWULHDHYZJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x85AAC90", Offset = "0x85A9A90", VA = "0x1885AAC90")]
		internal bool HQQWPKEKRJR(RRNetworkView a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x85AB190", Offset = "0x85A9F90", VA = "0x1885AB190")]
		protected internal void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x85AA1E0", Offset = "0x85A8FE0", VA = "0x1885AA1E0")]
		internal void ARFDCVZHIXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x85ADD90", Offset = "0x85ACB90", VA = "0x1885ADD90")]
		private void WFQFCTVORSD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x85AA410", Offset = "0x85A9210", VA = "0x1885AA410")]
		internal void CUBTRBJNYQV(LZEYQUPSRUQ a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x85ABD80", Offset = "0x85AAB80", VA = "0x1885ABD80")]
		public void RebuildControllerCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x85ABED0", Offset = "0x85AACD0", VA = "0x1885ABED0")]
		public void ResetOwnership()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x85ADB50", Offset = "0x85AC950", VA = "0x1885ADB50")]
		private void UAMROOXTZHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x85ADCA0", Offset = "0x85ACAA0", VA = "0x1885ADCA0")]
		private void WBASOREZMVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x85ABB30", Offset = "0x85AA930", VA = "0x1885ABB30")]
		public void RPC(string methodName, RpcTarget target, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x85ABAA0", Offset = "0x85AA8A0", VA = "0x1885ABAA0")]
		public void RPC(string methodName, LZEYQUPSRUQ targetPlayer, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x85ABDD0", Offset = "0x85AABD0", VA = "0x1885ABDD0")]
		public void RefreshRpcMonoBehaviourCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x85AA3A0", Offset = "0x85A91A0", VA = "0x1885AA3A0", Slot = "8")]
		public void Bake(WLYRVSLEATQ context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85AB6F0", Offset = "0x85AA4F0", VA = "0x1885AB6F0")]
		private static void PYTQXAHEGFS(LZEYQUPSRUQ a, [Out] LZEYQUPSRUQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x85ADDA0", Offset = "0x85ACBA0", VA = "0x1885ADDA0")]
		private static void XRHGUIERQVZ(RRNetworkView a, Delegate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x85AE090", Offset = "0x85ACE90", VA = "0x1885AE090")]
		private static RPCInfo YWVHRSTHULM(RRNetworkView a)
		{
			return default(RPCInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x85AAF30", Offset = "0x85A9D30", VA = "0x1885AAF30")]
		private static void ODWMMFEQPCQ(RRNetworkView a, Delegate b, LZEYQUPSRUQ c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x85AB010", Offset = "0x85A9E10", VA = "0x1885AB010")]
		private static void ODWMMFEQPCQ(RRNetworkView a, Delegate b, RpcTarget c, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85AA290", Offset = "0x85A9090", VA = "0x1885AA290")]
		private static void BHZNXAAKTRV(RRNetworkView a, Delegate b, RpcTarget c, BufferedEventCaching d, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85AB760", Offset = "0x85AA560", VA = "0x1885AB760")]
		public void RPCBuffered(string methodName, RpcTarget target, BufferedEventCaching caching, params object[] parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85AB0F0", Offset = "0x85A9EF0", VA = "0x1885AB0F0")]
		private static bool OLRSVOGHTZC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85AC380", Offset = "0x85AB180", VA = "0x1885AC380", Slot = "26")]
		public void RpcAll(HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x3C3EEE0", Offset = "0x3C3DCE0", VA = "0x183C3EEE0", Slot = "9")]
		public void RpcAll<T1>(HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E7D0", Offset = "0x3C3D5D0", VA = "0x183C3E7D0", Slot = "10")]
		public void RpcAll<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3C40F40", Offset = "0x3C3FD40", VA = "0x183C40F40", Slot = "27")]
		public void RpcAll<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E9C0", Offset = "0x3C3D7C0", VA = "0x183C3E9C0", Slot = "28")]
		public void RpcAll<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F500", Offset = "0x3C3E300", VA = "0x183C3F500", Slot = "29")]
		public void RpcAll<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C413E0", Offset = "0x3C401E0", VA = "0x183C413E0", Slot = "30")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F050", Offset = "0x3C3DE50", VA = "0x183C3F050", Slot = "11")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x3C555D0", Offset = "0x3C543D0", VA = "0x183C555D0", Slot = "12")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x3C41800", Offset = "0x3C40600", VA = "0x183C41800", Slot = "31")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3C400A0", Offset = "0x3C3EEA0", VA = "0x183C400A0", Slot = "13")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x3C59FB0", Offset = "0x3C58DB0", VA = "0x183C59FB0", Slot = "32")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3C463B0", Offset = "0x3C451B0", VA = "0x183C463B0", Slot = "33")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3C445D0", Offset = "0x3C433D0", VA = "0x183C445D0", Slot = "34")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3F8F0", Offset = "0x3C3E6F0", VA = "0x183C3F8F0", Slot = "35")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x85AC4F0", Offset = "0x85AB2F0", VA = "0x1885AC4F0", Slot = "36")]
		public void RpcAll(HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3C53970", Offset = "0x3C52770", VA = "0x183C53970", Slot = "37")]
		public void RpcAll<T1>(HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3C53490", Offset = "0x3C52290", VA = "0x183C53490", Slot = "38")]
		public void RpcAll<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3C408A0", Offset = "0x3C3F6A0", VA = "0x183C408A0", Slot = "39")]
		public void RpcAll<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C50A70", Offset = "0x3C4F870", VA = "0x183C50A70", Slot = "40")]
		public void RpcAll<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FEC0", Offset = "0x3C4ECC0", VA = "0x183C4FEC0", Slot = "41")]
		public void RpcAll<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F0E0", Offset = "0x3C4DEE0", VA = "0x183C4F0E0", Slot = "42")]
		public void RpcAll<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C4E0F0", Offset = "0x3C4CEF0", VA = "0x183C4E0F0", Slot = "43")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3C4C570", Offset = "0x3C4B370", VA = "0x183C4C570", Slot = "44")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x3C4BAA0", Offset = "0x3C4A8A0", VA = "0x183C4BAA0", Slot = "45")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3C498D0", Offset = "0x3C486D0", VA = "0x183C498D0", Slot = "46")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3C47F50", Offset = "0x3C46D50", VA = "0x183C47F50", Slot = "47")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3C47150", Offset = "0x3C45F50", VA = "0x183C47150", Slot = "48")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3C45490", Offset = "0x3C44290", VA = "0x183C45490", Slot = "49")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3C43590", Offset = "0x3C42390", VA = "0x183C43590", Slot = "50")]
		public void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x85AC250", Offset = "0x85AB050", VA = "0x1885AC250", Slot = "51")]
		public void RpcAllViaServer(HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3C660C0", Offset = "0x3C64EC0", VA = "0x183C660C0", Slot = "52")]
		public void RpcAllViaServer<T1>(HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3C66250", Offset = "0x3C65050", VA = "0x183C66250", Slot = "14")]
		public void RpcAllViaServer<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3C65B70", Offset = "0x3C64970", VA = "0x183C65B70", Slot = "53")]
		public void RpcAllViaServer<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3C657A0", Offset = "0x3C645A0", VA = "0x183C657A0", Slot = "54")]
		public void RpcAllViaServer<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3C65310", Offset = "0x3C64110", VA = "0x183C65310", Slot = "55")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3C64DC0", Offset = "0x3C63BC0", VA = "0x183C64DC0", Slot = "56")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3C647B0", Offset = "0x3C635B0", VA = "0x183C647B0", Slot = "57")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C640E0", Offset = "0x3C62EE0", VA = "0x183C640E0", Slot = "58")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3C63960", Offset = "0x3C62760", VA = "0x183C63960", Slot = "59")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C63120", Offset = "0x3C61F20", VA = "0x183C63120", Slot = "60")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C62820", Offset = "0x3C61620", VA = "0x183C62820", Slot = "61")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x3C61E60", Offset = "0x3C60C60", VA = "0x183C61E60", Slot = "62")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C613D0", Offset = "0x3C601D0", VA = "0x183C613D0", Slot = "63")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C60870", Offset = "0x3C5F670", VA = "0x183C60870", Slot = "64")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x85AC120", Offset = "0x85AAF20", VA = "0x1885AC120", Slot = "65")]
		public void RpcAllViaServer(HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C660C0", Offset = "0x3C64EC0", VA = "0x183C660C0", Slot = "66")]
		public void RpcAllViaServer<T1>(HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3C65E70", Offset = "0x3C64C70", VA = "0x183C65E70", Slot = "67")]
		public void RpcAllViaServer<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3C65B70", Offset = "0x3C64970", VA = "0x183C65B70", Slot = "68")]
		public void RpcAllViaServer<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x3C657A0", Offset = "0x3C645A0", VA = "0x183C657A0", Slot = "69")]
		public void RpcAllViaServer<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3C65310", Offset = "0x3C64110", VA = "0x183C65310", Slot = "70")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C64DC0", Offset = "0x3C63BC0", VA = "0x183C64DC0", Slot = "71")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x3C647B0", Offset = "0x3C635B0", VA = "0x183C647B0", Slot = "72")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C640E0", Offset = "0x3C62EE0", VA = "0x183C640E0", Slot = "73")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C63960", Offset = "0x3C62760", VA = "0x183C63960", Slot = "74")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C63120", Offset = "0x3C61F20", VA = "0x183C63120", Slot = "75")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3C62820", Offset = "0x3C61620", VA = "0x183C62820", Slot = "76")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3C61E60", Offset = "0x3C60C60", VA = "0x183C61E60", Slot = "77")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x3C613D0", Offset = "0x3C601D0", VA = "0x183C613D0", Slot = "78")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3C60870", Offset = "0x3C5F670", VA = "0x183C60870", Slot = "79")]
		public void RpcAllViaServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x85AD040", Offset = "0x85ABE40", VA = "0x1885AD040", Slot = "80")]
		public void RpcOthers(HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A930", Offset = "0x3C99730", VA = "0x183C9A930", Slot = "15")]
		public void RpcOthers<T1>(HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0D90", Offset = "0x3C9FB90", VA = "0x183CA0D90", Slot = "81")]
		public void RpcOthers<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A6F0", Offset = "0x3C994F0", VA = "0x183C9A6F0", Slot = "82")]
		public void RpcOthers<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3600", Offset = "0x3CA2400", VA = "0x183CA3600", Slot = "83")]
		public void RpcOthers<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3C9F690", Offset = "0x3C9E490", VA = "0x183C9F690", Slot = "84")]
		public void RpcOthers<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x3CA18F0", Offset = "0x3CA06F0", VA = "0x183CA18F0", Slot = "85")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C9EAF0", Offset = "0x3C9D8F0", VA = "0x183C9EAF0", Slot = "86")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3CA2510", Offset = "0x3CA1310", VA = "0x183CA2510", Slot = "87")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DC50", Offset = "0x3C9CA50", VA = "0x183C9DC50", Slot = "88")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3CA2030", Offset = "0x3CA0E30", VA = "0x183CA2030", Slot = "16")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C9CAB0", Offset = "0x3C9B8B0", VA = "0x183C9CAB0", Slot = "89")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C0C0", Offset = "0x3C9AEC0", VA = "0x183C9C0C0", Slot = "90")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B610", Offset = "0x3C9A410", VA = "0x183C9B610", Slot = "91")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AA80", Offset = "0x3C99880", VA = "0x183C9AA80", Slot = "92")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x85AD190", Offset = "0x85ABF90", VA = "0x1885AD190", Slot = "93")]
		public void RpcOthers(HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0AF0", Offset = "0x3C9F8F0", VA = "0x183CA0AF0", Slot = "94")]
		public void RpcOthers<T1>(HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0930", Offset = "0x3C9F730", VA = "0x183CA0930", Slot = "95")]
		public void RpcOthers<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C9FF30", Offset = "0x3C9ED30", VA = "0x183C9FF30", Slot = "96")]
		public void RpcOthers<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0690", Offset = "0x3C9F490", VA = "0x183CA0690", Slot = "97")]
		public void RpcOthers<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x3CA12A0", Offset = "0x3CA00A0", VA = "0x183CA12A0", Slot = "98")]
		public void RpcOthers<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3CA15A0", Offset = "0x3CA03A0", VA = "0x183CA15A0", Slot = "99")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x3C9EAF0", Offset = "0x3C9D8F0", VA = "0x183C9EAF0", Slot = "100")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C9E400", Offset = "0x3C9D200", VA = "0x183C9E400", Slot = "101")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C9DC50", Offset = "0x3C9CA50", VA = "0x183C9DC50", Slot = "102")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C9D3E0", Offset = "0x3C9C1E0", VA = "0x183C9D3E0", Slot = "103")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C9CAB0", Offset = "0x3C9B8B0", VA = "0x183C9CAB0", Slot = "104")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C9C0C0", Offset = "0x3C9AEC0", VA = "0x183C9C0C0", Slot = "105")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C9B610", Offset = "0x3C9A410", VA = "0x183C9B610", Slot = "106")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x3C9AA80", Offset = "0x3C99880", VA = "0x183C9AA80", Slot = "107")]
		public void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x85ACB30", Offset = "0x85AB930", VA = "0x1885ACB30", Slot = "108")]
		public void RpcMaster(HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C4B0", Offset = "0x3C7B2B0", VA = "0x183C7C4B0", Slot = "109")]
		public void RpcMaster<T1>(HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C820", Offset = "0x3C7B620", VA = "0x183C7C820", Slot = "17")]
		public void RpcMaster<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BCC0", Offset = "0x3C7AAC0", VA = "0x183C7BCC0", Slot = "110")]
		public void RpcMaster<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C7BF20", Offset = "0x3C7AD20", VA = "0x183C7BF20", Slot = "111")]
		public void RpcMaster<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F890", Offset = "0x3C8E690", VA = "0x183C8F890", Slot = "112")]
		public void RpcMaster<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C918A0", Offset = "0x3C906A0", VA = "0x183C918A0", Slot = "113")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3C886F0", Offset = "0x3C874F0", VA = "0x183C886F0", Slot = "114")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C86AF0", Offset = "0x3C858F0", VA = "0x183C86AF0", Slot = "115")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C86080", Offset = "0x3C84E80", VA = "0x183C86080", Slot = "116")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C8F0E0", Offset = "0x3C8DEE0", VA = "0x183C8F0E0", Slot = "117")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C8E130", Offset = "0x3C8CF30", VA = "0x183C8E130", Slot = "118")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C808B0", Offset = "0x3C7F6B0", VA = "0x183C808B0", Slot = "119")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C7F9E0", Offset = "0x3C7E7E0", VA = "0x183C7F9E0", Slot = "120")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C7CA40", Offset = "0x3C7B840", VA = "0x183C7CA40", Slot = "121")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x85ACCC0", Offset = "0x85ABAC0", VA = "0x1885ACCC0", Slot = "122")]
		public void RpcMaster(HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C7C640", Offset = "0x3C7B440", VA = "0x183C7C640", Slot = "123")]
		public void RpcMaster<T1>(HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D450", Offset = "0x3C8C250", VA = "0x183C8D450", Slot = "124")]
		public void RpcMaster<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C8CAC0", Offset = "0x3C8B8C0", VA = "0x183C8CAC0", Slot = "125")]
		public void RpcMaster<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x3C8AB60", Offset = "0x3C89960", VA = "0x183C8AB60", Slot = "126")]
		public void RpcMaster<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x3C90060", Offset = "0x3C8EE60", VA = "0x183C90060", Slot = "127")]
		public void RpcMaster<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3C88F60", Offset = "0x3C87D60", VA = "0x183C88F60", Slot = "128")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x3C87E30", Offset = "0x3C86C30", VA = "0x183C87E30", Slot = "129")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x3C87460", Offset = "0x3C86260", VA = "0x183C87460", Slot = "130")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x3C855A0", Offset = "0x3C843A0", VA = "0x183C855A0", Slot = "131")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x3C849B0", Offset = "0x3C837B0", VA = "0x183C849B0", Slot = "132")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C83130", Offset = "0x3C81F30", VA = "0x183C83130", Slot = "133")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x3C81670", Offset = "0x3C80470", VA = "0x183C81670", Slot = "134")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x3C7EAA0", Offset = "0x3C7D8A0", VA = "0x183C7EAA0", Slot = "135")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DA40", Offset = "0x3C7C840", VA = "0x183C7DA40", Slot = "136")]
		public void RpcMaster<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x85AC980", Offset = "0x85AB780", VA = "0x1885AC980", Slot = "137")]
		public void RpcAuthority(HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x3C66920", Offset = "0x3C65720", VA = "0x183C66920", Slot = "138")]
		public void RpcAuthority<T1>(HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x3C78550", Offset = "0x3C77350", VA = "0x183C78550", Slot = "139")]
		public void RpcAuthority<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x3C78CB0", Offset = "0x3C77AB0", VA = "0x183C78CB0", Slot = "140")]
		public void RpcAuthority<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x3C78250", Offset = "0x3C77050", VA = "0x183C78250", Slot = "141")]
		public void RpcAuthority<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x3C66590", Offset = "0x3C65390", VA = "0x183C66590", Slot = "142")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x3C73330", Offset = "0x3C72130", VA = "0x183C73330", Slot = "143")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x3C72A90", Offset = "0x3C71890", VA = "0x183C72A90", Slot = "144")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C70E00", Offset = "0x3C6FC00", VA = "0x183C70E00", Slot = "145")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3C6F840", Offset = "0x3C6E640", VA = "0x183C6F840", Slot = "146")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3C6EC80", Offset = "0x3C6DA80", VA = "0x183C6EC80", Slot = "147")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3C79B20", Offset = "0x3C78920", VA = "0x183C79B20", Slot = "148")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C77010", Offset = "0x3C75E10", VA = "0x183C77010", Slot = "149")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3C68B90", Offset = "0x3C67990", VA = "0x183C68B90", Slot = "150")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3C66AD0", Offset = "0x3C658D0", VA = "0x183C66AD0", Slot = "151")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AC720", Offset = "0x85AB520", VA = "0x1885AC720", Slot = "152")]
		public void RpcAuthority(HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3C76B10", Offset = "0x3C75910", VA = "0x183C76B10", Slot = "153")]
		public void RpcAuthority<T1>(HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x3C76750", Offset = "0x3C75550", VA = "0x183C76750", Slot = "154")]
		public void RpcAuthority<T1, T2>(HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3C75F40", Offset = "0x3C74D40", VA = "0x183C75F40", Slot = "155")]
		public void RpcAuthority<T1, T2, T3>(HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x3C74FB0", Offset = "0x3C73DB0", VA = "0x183C74FB0", Slot = "156")]
		public void RpcAuthority<T1, T2, T3, T4>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3C748F0", Offset = "0x3C736F0", VA = "0x183C748F0", Slot = "157")]
		public void RpcAuthority<T1, T2, T3, T4, T5>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3C73AB0", Offset = "0x3C728B0", VA = "0x183C73AB0", Slot = "158")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x3C721A0", Offset = "0x3C70FA0", VA = "0x183C721A0", Slot = "159")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x3C717A0", Offset = "0x3C705A0", VA = "0x183C717A0", Slot = "160")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3C702F0", Offset = "0x3C6F0F0", VA = "0x183C702F0", Slot = "161")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x3C6E060", Offset = "0x3C6CE60", VA = "0x183C6E060", Slot = "162")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x3C6D330", Offset = "0x3C6C130", VA = "0x183C6D330", Slot = "163")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x3C6AA10", Offset = "0x3C69810", VA = "0x183C6AA10", Slot = "164")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3C69AA0", Offset = "0x3C688A0", VA = "0x183C69AA0", Slot = "165")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C67B00", Offset = "0x3C66900", VA = "0x183C67B00", Slot = "166")]
		public void RpcAuthority<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x85AD2E0", Offset = "0x85AC0E0", VA = "0x1885AD2E0", Slot = "18")]
		public void RpcPlayer(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3B40", Offset = "0x3CA2940", VA = "0x183CA3B40", Slot = "19")]
		public void RpcPlayer<T1>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3F10", Offset = "0x3CA2D10", VA = "0x183CA3F10", Slot = "20")]
		public void RpcPlayer<T1, T2>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5D60", Offset = "0x3CA4B60", VA = "0x183CA5D60", Slot = "21")]
		public void RpcPlayer<T1, T2, T3>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5A20", Offset = "0x3CA4820", VA = "0x183CA5A20", Slot = "22")]
		public void RpcPlayer<T1, T2, T3, T4>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8D50", Offset = "0x3CB7B50", VA = "0x183CB8D50", Slot = "167")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8950", Offset = "0x3CB7750", VA = "0x183CB8950", Slot = "168")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CB90D0", Offset = "0x3CB7ED0", VA = "0x183CB90D0", Slot = "169")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9520", Offset = "0x3CB8320", VA = "0x183CB9520", Slot = "170")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x3CB0B00", Offset = "0x3CAF900", VA = "0x183CB0B00", Slot = "171")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CAFF40", Offset = "0x3CAED40", VA = "0x183CAFF40", Slot = "172")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6600", Offset = "0x3CA5400", VA = "0x183CA6600", Slot = "23")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3CACAF0", Offset = "0x3CAB8F0", VA = "0x183CACAF0", Slot = "173")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3CBCF90", Offset = "0x3CBBD90", VA = "0x183CBCF90", Slot = "174")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7D10", Offset = "0x3CA6B10", VA = "0x183CA7D10", Slot = "175")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x85AD4D0", Offset = "0x85AC2D0", VA = "0x1885AD4D0", Slot = "176")]
		public void RpcPlayer(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3CA3D00", Offset = "0x3CA2B00", VA = "0x183CA3D00", Slot = "177")]
		public void RpcPlayer<T1>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3CA4160", Offset = "0x3CA2F60", VA = "0x183CA4160", Slot = "24")]
		public void RpcPlayer<T1, T2>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3CA62D0", Offset = "0x3CA50D0", VA = "0x183CA62D0", Slot = "25")]
		public void RpcPlayer<T1, T2, T3>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3CA7990", Offset = "0x3CA6790", VA = "0x183CA7990", Slot = "178")]
		public void RpcPlayer<T1, T2, T3, T4>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3CB5560", Offset = "0x3CB4360", VA = "0x183CB5560", Slot = "179")]
		public void RpcPlayer<T1, T2, T3, T4, T5>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3CB4D80", Offset = "0x3CB3B80", VA = "0x183CB4D80", Slot = "180")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3470", Offset = "0x3CB2270", VA = "0x183CB3470", Slot = "181")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB2A70", Offset = "0x3CB1870", VA = "0x183CB2A70", Slot = "182")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3CB15B0", Offset = "0x3CB03B0", VA = "0x183CB15B0", Slot = "183")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3CAF310", Offset = "0x3CAE110", VA = "0x183CAF310", Slot = "184")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x3CAE5D0", Offset = "0x3CAD3D0", VA = "0x183CAE5D0", Slot = "185")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3CABC90", Offset = "0x3CAAA90", VA = "0x183CABC90", Slot = "186")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3CAAD10", Offset = "0x3CA9B10", VA = "0x183CAAD10", Slot = "187")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8D50", Offset = "0x3CA7B50", VA = "0x183CA8D50", Slot = "188")]
		public void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LZEYQUPSRUQ player, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x85AC080", Offset = "0x85AAE80", VA = "0x1885AC080", Slot = "189")]
		public void RpcAllBuffered(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E630", Offset = "0x3C3D430", VA = "0x183C3E630", Slot = "190")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E3E0", Offset = "0x3C3D1E0", VA = "0x183C3E3E0", Slot = "191")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E0D0", Offset = "0x3C3CED0", VA = "0x183C3E0D0", Slot = "192")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DD00", Offset = "0x3C3CB00", VA = "0x183C3DD00", Slot = "193")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D870", Offset = "0x3C3C670", VA = "0x183C3D870", Slot = "194")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D320", Offset = "0x3C3C120", VA = "0x183C3D320", Slot = "195")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CD10", Offset = "0x3C3BB10", VA = "0x183C3CD10", Slot = "196")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C640", Offset = "0x3C3B440", VA = "0x183C3C640", Slot = "197")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BEB0", Offset = "0x3C3ACB0", VA = "0x183C3BEB0", Slot = "198")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B660", Offset = "0x3C3A460", VA = "0x183C3B660", Slot = "199")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3C3AD50", Offset = "0x3C39B50", VA = "0x183C3AD50", Slot = "200")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FEA0", Offset = "0x3C5ECA0", VA = "0x183C5FEA0", Slot = "201")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F410", Offset = "0x3C5E210", VA = "0x183C5F410", Slot = "202")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E8B0", Offset = "0x3C5D6B0", VA = "0x183C5E8B0", Slot = "203")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x85ABFE0", Offset = "0x85AADE0", VA = "0x1885ABFE0", Slot = "204")]
		public void RpcAllBuffered(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E630", Offset = "0x3C3D430", VA = "0x183C3E630", Slot = "205")]
		public void RpcAllBuffered<T1>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E3E0", Offset = "0x3C3D1E0", VA = "0x183C3E3E0", Slot = "206")]
		public void RpcAllBuffered<T1, T2>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3C3E0D0", Offset = "0x3C3CED0", VA = "0x183C3E0D0", Slot = "207")]
		public void RpcAllBuffered<T1, T2, T3>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3C3DD00", Offset = "0x3C3CB00", VA = "0x183C3DD00", Slot = "208")]
		public void RpcAllBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D870", Offset = "0x3C3C670", VA = "0x183C3D870", Slot = "209")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3C3D320", Offset = "0x3C3C120", VA = "0x183C3D320", Slot = "210")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CD10", Offset = "0x3C3BB10", VA = "0x183C3CD10", Slot = "211")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x3C3C640", Offset = "0x3C3B440", VA = "0x183C3C640", Slot = "212")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3C3BEB0", Offset = "0x3C3ACB0", VA = "0x183C3BEB0", Slot = "213")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x3C3B660", Offset = "0x3C3A460", VA = "0x183C3B660", Slot = "214")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3C3AD50", Offset = "0x3C39B50", VA = "0x183C3AD50", Slot = "215")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3C5FEA0", Offset = "0x3C5ECA0", VA = "0x183C5FEA0", Slot = "216")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3C5F410", Offset = "0x3C5E210", VA = "0x183C5F410", Slot = "217")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x3C5E8B0", Offset = "0x3C5D6B0", VA = "0x183C5E8B0", Slot = "218")]
		public void RpcAllBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x85ACFA0", Offset = "0x85ABDA0", VA = "0x1885ACFA0", Slot = "219")]
		public void RpcOthersBuffered(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A550", Offset = "0x3C99350", VA = "0x183C9A550", Slot = "220")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A300", Offset = "0x3C99100", VA = "0x183C9A300", Slot = "221")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3C99FF0", Offset = "0x3C98DF0", VA = "0x183C99FF0", Slot = "222")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3C99C20", Offset = "0x3C98A20", VA = "0x183C99C20", Slot = "223")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3C99790", Offset = "0x3C98590", VA = "0x183C99790", Slot = "224")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3C99240", Offset = "0x3C98040", VA = "0x183C99240", Slot = "225")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3C98C30", Offset = "0x3C97A30", VA = "0x183C98C30", Slot = "226")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x3C98560", Offset = "0x3C97360", VA = "0x183C98560", Slot = "227")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3C97DD0", Offset = "0x3C96BD0", VA = "0x183C97DD0", Slot = "228")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3C97580", Offset = "0x3C96380", VA = "0x183C97580", Slot = "229")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x3C96C70", Offset = "0x3C95A70", VA = "0x183C96C70", Slot = "230")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3C962A0", Offset = "0x3C950A0", VA = "0x183C962A0", Slot = "231")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3C95810", Offset = "0x3C94610", VA = "0x183C95810", Slot = "232")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3C94CB0", Offset = "0x3C93AB0", VA = "0x183C94CB0", Slot = "233")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x85ACF00", Offset = "0x85ABD00", VA = "0x1885ACF00", Slot = "234")]
		public void RpcOthersBuffered(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<RPCInfo> method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A550", Offset = "0x3C99350", VA = "0x183C9A550", Slot = "235")]
		public void RpcOthersBuffered<T1>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, RPCInfo> method, T1 arg1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x3C9A300", Offset = "0x3C99100", VA = "0x183C9A300", Slot = "236")]
		public void RpcOthersBuffered<T1, T2>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3C99FF0", Offset = "0x3C98DF0", VA = "0x183C99FF0", Slot = "237")]
		public void RpcOthersBuffered<T1, T2, T3>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3C99C20", Offset = "0x3C98A20", VA = "0x183C99C20", Slot = "238")]
		public void RpcOthersBuffered<T1, T2, T3, T4>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x3C99790", Offset = "0x3C98590", VA = "0x183C99790", Slot = "239")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3C99240", Offset = "0x3C98040", VA = "0x183C99240", Slot = "240")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3C98C30", Offset = "0x3C97A30", VA = "0x183C98C30", Slot = "241")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3C98560", Offset = "0x3C97360", VA = "0x183C98560", Slot = "242")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x3C97DD0", Offset = "0x3C96BD0", VA = "0x183C97DD0", Slot = "243")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x3C97580", Offset = "0x3C96380", VA = "0x183C97580", Slot = "244")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3C96C70", Offset = "0x3C95A70", VA = "0x183C96C70", Slot = "245")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3C962A0", Offset = "0x3C950A0", VA = "0x183C962A0", Slot = "246")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x3C95810", Offset = "0x3C94610", VA = "0x183C95810", Slot = "247")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3C94CB0", Offset = "0x3C93AB0", VA = "0x183C94CB0", Slot = "248")]
		public void RpcOthersBuffered<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(BufferedEventCaching caching, HRBQQIPPXKR.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x85AA4D0", Offset = "0x85A92D0", VA = "0x1885AA4D0", Slot = "249")]
		public void ClearBufferedRPCsIfMine()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x85AA6E0", Offset = "0x85A94E0", VA = "0x1885AA6E0", Slot = "250")]
		public void ClearBufferedRPCs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x2161200", Offset = "0x2160000", VA = "0x182161200")]
		public RRNetworkView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class HCYGCEIQGCU
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x85A7610", Offset = "0x85A6410", VA = "0x1885A7610")]
		private static bool KKVRTDUUTZB(ViewId a, [Out] RRNetworkView b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3900FC0", Offset = "0x38FFDC0", VA = "0x183900FC0")]
		[CanBeNull]
		public static a HASPTMIBBFF<a>(this ViewId a)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class RRPlayerNumbering : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class POLEGLKOIKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public LZEYQUPSRUQ[] MLMGBBESJYC;

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public POLEGLKOIKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x85A81E0", Offset = "0x85A6FE0", VA = "0x1885A81E0")]
			internal int DIEXSQNSQXO(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x85A8260", Offset = "0x85A7060", VA = "0x1885A8260")]
			internal void DIKEPXHQAIX(int a, int b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public static RRPlayerNumbering instance;

		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public static LZEYQUPSRUQ[] SortedPlayers;

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public const string RoomPlayerIndexedProp = "rrPnr";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		internal int FHKKLLEXCZF;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x85AEBB0", Offset = "0x85AD9B0", VA = "0x1885AEBB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x85AF1B0", Offset = "0x85ADFB0", VA = "0x1885AF1B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x85AF550", Offset = "0x85AE350", VA = "0x1885AF550")]
		private void OnJoinedRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x85AF5D0", Offset = "0x85AE3D0", VA = "0x1885AF5D0")]
		private void OnLeftRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x85AF1A0", Offset = "0x85ADFA0", VA = "0x1885AF1A0")]
		private void TSTSHMBDYCB(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x85AF1A0", Offset = "0x85ADFA0", VA = "0x1885AF1A0")]
		private void NWULNUHSRQV(LZEYQUPSRUQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x85AEFC0", Offset = "0x85ADDC0", VA = "0x1885AEFC0")]
		private void BYCDOBIZCAD(LZEYQUPSRUQ a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x85AEA60", Offset = "0x85AD860", VA = "0x1885AEA60")]
		public static void AssignPlayerNumbers(int playerCount, int localPlayerIndex, Func<int, int> getPlayerNumber, Action<int, int> setPlayerNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x85AF680", Offset = "0x85AE480", VA = "0x1885AF680")]
		public void RefreshData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x85AF0B0", Offset = "0x85ADEB0", VA = "0x1885AF0B0")]
		private void ClearLocalPlayerNumber()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xAAF410", Offset = "0xAAE210", VA = "0x180AAF410")]
		public RRPlayerNumbering()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public static class UBUVZRJGWYL
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x85B29A0", Offset = "0x85B17A0", VA = "0x1885B29A0")]
		public static int SJWIXYZAKLP(this LZEYQUPSRUQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x85B25E0", Offset = "0x85B13E0", VA = "0x1885B25E0")]
		public static void JNRGHSUILDH(this LZEYQUPSRUQ a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class VXLWIKOVKYH
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public delegate void RoomPropertyUpdateCallback(Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public delegate void PlayerPropertyUpdateCallback(LZEYQUPSRUQ player, Hashtable properties);

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		public static event RoomPropertyUpdateCallback YRJZJOHOSDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x85B4220", Offset = "0x85B3020", VA = "0x1885B4220")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x85B4460", Offset = "0x85B3260", VA = "0x1885B4460")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public static event RoomPropertyUpdateCallback CQDYOZEZVMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x85B3FE0", Offset = "0x85B2DE0", VA = "0x1885B3FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x85B42E0", Offset = "0x85B30E0", VA = "0x1885B42E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public static event PlayerPropertyUpdateCallback WVJFXIMNCQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x85B4520", Offset = "0x85B3320", VA = "0x1885B4520")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x85B43A0", Offset = "0x85B31A0", VA = "0x1885B43A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public static event PlayerPropertyUpdateCallback CNSZDLVUQSA
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x85B4160", Offset = "0x85B2F60", VA = "0x1885B4160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x85B40A0", Offset = "0x85B2EA0", VA = "0x1885B40A0")]
			[CompilerGenerated]
			remove
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal static class IYVJOSIEJGQ
	{
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private static int HIQMVWBSICC;

		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private static int DMSUVXVUFLC;

		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private static int DILQRFMAWXG;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x85A7960", Offset = "0x85A6760", VA = "0x1885A7960")]
		public static void YKAWFSBDAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x85A79B0", Offset = "0x85A67B0", VA = "0x1885A79B0")]
		public static void YNGBZLCYKQD(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x85A76D0", Offset = "0x85A64D0", VA = "0x1885A76D0")]
		public static int GIQVNIISCWM(int a, bool b = true)
		{
			return default(int);
		}
	}
}
namespace RRNetworkLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RegisterService(typeof(ZDDVYZUGWBS), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class ZDDVYZUGWBS : ZHXZBWHQFPK, IFVEAFHUJHU, BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly Dictionary<object, object> XPZRLSTHSCR;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private static readonly Dictionary<object, object> APEXVOUFCGR;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly Dictionary<object, object> RLWTUBETTXD;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private static readonly ZPXXLQJTGDJ IAXUVIQYOVV;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly ZPXXLQJTGDJ IVEKEAZXFMG;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly ZPXXLQJTGDJ VADYUBXSZYK;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private static readonly ZPXXLQJTGDJ ZMQTKHVMCXB;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private static readonly ZPXXLQJTGDJ WPPDDQHPWCW;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static int XLYNVNTOJFJ;

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x85BFB80", Offset = "0x85BE980", VA = "0x1885BFB80", Slot = "18")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x85C02F0", Offset = "0x85BF0F0", VA = "0x1885C02F0", Slot = "19")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x85BF630", Offset = "0x85BE430", VA = "0x1885BF630", Slot = "4")]
		public bool BGXYLVWJHKP(InstantiateParameters a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x85C05B0", Offset = "0x85BF3B0", VA = "0x1885C05B0", Slot = "5")]
		public int SMLRAVDNNFB(InstantiateParameters[] a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x85BF930", Offset = "0x85BE730", VA = "0x1885BF930", Slot = "6")]
		public bool IGACLUPHIXM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x85BF9C0", Offset = "0x85BE7C0", VA = "0x1885BF9C0", Slot = "7")]
		public bool IGZTPTBPNOT(int a, int b, bool c, GameObject d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x85C0390", Offset = "0x85BF190", VA = "0x1885C0390", Slot = "8")]
		public void QZZKPXBTRVU(int a, [Optional] int? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x85C09C0", Offset = "0x85BF7C0", VA = "0x1885C09C0", Slot = "9")]
		public bool ULIGVHSCTXQ(PQDMMRYYGHS a, [Out] InstantiateParameters b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x85C1330", Offset = "0x85C0130", VA = "0x1885C1330", Slot = "10")]
		public bool VIWVDZYOJPR(PQDMMRYYGHS a, [Out] int b, [Out] InstantiateParameters[] c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x85BFFA0", Offset = "0x85BEDA0", VA = "0x1885BFFA0", Slot = "11")]
		public bool NCEBPMCLVCQ(PQDMMRYYGHS a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x85C1650", Offset = "0x85C0450", VA = "0x1885C1650", Slot = "12")]
		public void XKWXYXBPTCU(PQDMMRYYGHS a, [Out] int b, [Out] int[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x85BFDE0", Offset = "0x85BEBE0", VA = "0x1885BFDE0", Slot = "13")]
		public void LSGSPLUQTIP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x85C00E0", Offset = "0x85BEEE0", VA = "0x1885C00E0", Slot = "14")]
		public void ONHYGVDBAVZ(int a, int[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x85BF770", Offset = "0x85BE570", VA = "0x1885BF770", Slot = "15")]
		public void BJRAIHIQEIZ(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x85C18A0", Offset = "0x85C06A0", VA = "0x1885C18A0", Slot = "16")]
		public void YLMHFCLXLXK(int[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x85BFC20", Offset = "0x85BEA20", VA = "0x1885BFC20", Slot = "17")]
		public void KFLHLYVUSIS(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x85C19B0", Offset = "0x85C07B0", VA = "0x1885C19B0")]
		private static void YMUUUQNDAHB(InstantiateParameters a, Dictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x85C0B30", Offset = "0x85BF930", VA = "0x1885C0B30")]
		private static bool ULIGVHSCTXQ(Dictionary<object, object> a, LZEYQUPSRUQ b, [Out] InstantiateParameters c, bool d = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x85C0250", Offset = "0x85BF050", VA = "0x1885C0250")]
		private static bool PSBNIURJVRL(int a, InstantiateParameters b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x85BF850", Offset = "0x85BE650", VA = "0x1885BF850")]
		private static int IDJVFSDOQVX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZDDVYZUGWBS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RegisterService(typeof(VQNPXJYRBHE), new string[] { })]
	[ServiceLifetime(Lifetime.Application)]
	public class VQNPXJYRBHE : NLUUQDIMWGS, IFVEAFHUJHU, BQLXQKHZRWO
	{
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private static Hashtable HPUKDBLDQKS;

		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private static Hashtable JKKZWFAYTHH;

		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private static ZPXXLQJTGDJ HUGFKYIFBAY;

		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private static readonly ZPXXLQJTGDJ NPOQGJGIBRX;

		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private static Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x85B3D90", Offset = "0x85B2B90", VA = "0x1885B3D90", Slot = "8")]
		public void QDLPFTNMELS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x85B38F0", Offset = "0x85B26F0", VA = "0x1885B38F0", Slot = "7")]
		public void InitInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x85B3990", Offset = "0x85B2790", VA = "0x1885B3990", Slot = "4")]
		public void NGVUUBCWLUC(ViewId a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x85B3A70", Offset = "0x85B2870", VA = "0x1885B3A70", Slot = "5")]
		public bool NIRASQTWJAK(PQDMMRYYGHS a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x85B3250", Offset = "0x85B2050", VA = "0x1885B3250", Slot = "6")]
		public void FKXNPTJTRIM(ViewId a, string b, RpcTarget c, LZEYQUPSRUQ d, RpcCacheOption e, object[] f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public VQNPXJYRBHE()
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
