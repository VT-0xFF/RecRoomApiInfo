using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Dissonance.Integrations.Unity_NFGO;
using Netcode.Transports.LiteNetLib;
using Nito.Collections;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using UJect;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Networking_NetcodeImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8591DE0", Offset = "0x8590DE0", VA = "0x188591DE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x279CA70", Offset = "0x279BA70", VA = "0x18279CA70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class IRYDFGLWZGH : SPAZCZEVTZZ, PTABWLQDFFD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class HOWHYCEBLOQ : VASLQQLLDVS
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte CLIBGYYHYLA
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xBA8E20", Offset = "0xBA7E20", VA = "0x180BA8E20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int VMRGAQPOMHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xB7CE40", Offset = "0xB7BE40", VA = "0x180B7CE40", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xB7CC80", Offset = "0xB7BC80", VA = "0x180B7CC80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object AZWQUNNAXEY
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7DF5550", Offset = "0x7DF4550", VA = "0x187DF5550")]
			public HOWHYCEBLOQ(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8588AC0", Offset = "0x8587AC0", VA = "0x188588AC0", Slot = "7")]
			public bool DVVDXLGNEBL(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState MVKUENAWKQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch EGKOSFEYIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int YYPZPOBVIWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<HOWHYCEBLOQ> IYRBRTFQFRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> XYVUQRDAHLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private JCGPEIGMXFW QHNFCCXJWQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NRSCVCZICEW EVKNSVNXYJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool DZUTKGLECZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PVKVWDWHZUC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager WLMUPEEZOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport HBRYNXCTCWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x858A3E0", Offset = "0x85893E0", VA = "0x18858A3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState FOJCURUDALS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x858B140", Offset = "0x858A140", VA = "0x18858B140", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x858DDB0", Offset = "0x858CDB0", VA = "0x18858DDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KQPBGQWZWPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAD05D0", Offset = "0xACF5D0", VA = "0x180AD05D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public JCGPEIGMXFW UOTHWZKTJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NRSCVCZICEW VZKZLTXHEIT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private HUZGCNRKFDE NENGPRSNWQO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool RIAZAHEERGH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x858BFB0", Offset = "0x858AFB0", VA = "0x18858BFB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YRUJFDSRACC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x858D1D0", Offset = "0x858C1D0", VA = "0x18858D1D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GQXMPAUZOJM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x858D1D0", Offset = "0x858C1D0", VA = "0x18858D1D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HEZZJNKLAHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB638B0", Offset = "0xB628B0", VA = "0x180B638B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x858D0B0", Offset = "0x858C0B0", VA = "0x18858D0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception OKWFZAQWCSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xACDCF0", Offset = "0xACCCF0", VA = "0x180ACDCF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xACDF80", Offset = "0xACCF80", VA = "0x180ACDF80", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int OTJGVZSMUNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool WLCATCERIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8588B00", Offset = "0x8587B00", VA = "0x188588B00", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x858D050", Offset = "0x858C050", VA = "0x18858D050", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DEUYJSMWYQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DC0", Offset = "0xAD4DC0", VA = "0x180AD5DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAD6490", Offset = "0xAD5490", VA = "0x180AD6490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double STXIKPNXGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x858BF60", Offset = "0x858AF60", VA = "0x18858BF60")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double GNIYEBHRUWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8588D70", Offset = "0x8587D70", VA = "0x188588D70")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int FCEDIEEZHWL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x858B3E0", Offset = "0x858A3E0", VA = "0x18858B3E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string VNWQOOXCHCM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x858BA60", Offset = "0x858AA60", VA = "0x18858BA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int RXTJDZPIPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x858B350", Offset = "0x858A350", VA = "0x18858B350")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JVZNGNWULOY BGTDFOJJXSK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x858A9A0", Offset = "0x85899A0", VA = "0x18858A9A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BTBZQKOQLUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD446C0", Offset = "0xD436C0", VA = "0x180D446C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x858CE70", Offset = "0x858BE70", VA = "0x18858CE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> UEXXKBKHGSW
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8588FB0", Offset = "0x8587FB0", VA = "0x188588FB0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x858D220", Offset = "0x858C220", VA = "0x18858D220", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> OCFNNDQBYCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x858A9F0", Offset = "0x85899F0", VA = "0x18858A9F0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x858BFE0", Offset = "0x858AFE0", VA = "0x18858BFE0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x858E040", Offset = "0x858D040", VA = "0x18858E040")]
		public IRYDFGLWZGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85892F0", Offset = "0x85882F0", VA = "0x1885892F0")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85895F0", Offset = "0x85885F0", VA = "0x1885895F0")]
		private void DJPKAFGCCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x858B0E0", Offset = "0x858A0E0", VA = "0x18858B0E0")]
		private void IYEAWNAWQUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8589800", Offset = "0x8588800", VA = "0x188589800")]
		public bool DXNYDFRAPJW(OVSEBXDBUJS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x858A210", Offset = "0x8589210", VA = "0x18858A210")]
		public bool FIAKSSQANAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x858B430", Offset = "0x858A430", VA = "0x18858B430")]
		public void KDKBCFNQGWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x858B9A0", Offset = "0x858A9A0", VA = "0x18858B9A0")]
		public void KFSPENGJDAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8588DC0", Offset = "0x8587DC0", VA = "0x188588DC0")]
		public void CRZDZMMAZFR(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8589060", Offset = "0x8588060", VA = "0x188589060")]
		public void CYXWDAZXTMR(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x858B160", Offset = "0x858A160", VA = "0x18858B160")]
		public void JJIEJVUWAJG(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x858D6C0", Offset = "0x858C6C0", VA = "0x18858D6C0")]
		public void XRHSQBYDVHR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8589920", Offset = "0x8588920", VA = "0x188589920")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x858CC80", Offset = "0x858BC80", VA = "0x18858CC80")]
		public int QRQKMVLOPZN(VASLQQLLDVS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8589C60", Offset = "0x8588C60", VA = "0x188589C60")]
		public bool EFSZTLMNQBJ(byte a, object b, XSNAFSFANWP c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x858A4F0", Offset = "0x85894F0", VA = "0x18858A4F0")]
		public bool FTCIHMRZUNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8588B50", Offset = "0x8587B50", VA = "0x188588B50")]
		internal bool BTHNWXKIGOJ([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x858DDE0", Offset = "0x858CDE0", VA = "0x18858DDE0")]
		internal bool ZGDTKXBOMYH([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x858CAF0", Offset = "0x858BAF0", VA = "0x18858CAF0")]
		private void QMXMQVXMHMU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8589A10", Offset = "0x8588A10", VA = "0x188589A10")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8589B10", Offset = "0x8588B10", VA = "0x188589B10", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x858A0B0", Offset = "0x85890B0", VA = "0x18858A0B0")]
		private void FAYXYUSQKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x858C170", Offset = "0x858B170", VA = "0x18858C170")]
		private void NTJVOLJMXLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x858D950", Offset = "0x858C950", VA = "0x18858D950")]
		private void XRWPSQKHKND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x858ABD0", Offset = "0x8589BD0", VA = "0x18858ABD0")]
		private void HKMCUKVWQLV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x858C490", Offset = "0x858B490", VA = "0x18858C490")]
		private void PLUENMCTAMU(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37ACE70", Offset = "0x37ABE70", VA = "0x1837ACE70")]
		private void PWXRBHKFUKQ<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x858AAA0", Offset = "0x8589AA0", VA = "0x18858AAA0")]
		private void GEIUXDEHMYF(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x858AE70", Offset = "0x8589E70", VA = "0x18858AE70")]
		private void ISTJPDIGONE(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x858B3B0", Offset = "0x858A3B0", VA = "0x18858B3B0")]
		private void JSHYSZHVOKS(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x858B480", Offset = "0x858A480", VA = "0x18858B480")]
		private void KFCBDXWQAJZ(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x858BB70", Offset = "0x858AB70", VA = "0x18858BB70")]
		private void LKHOGJJTAON(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x858DA40", Offset = "0x858CA40", VA = "0x18858DA40")]
		private void XZVPNZSARWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x858A260", Offset = "0x8589260", VA = "0x18858A260")]
		private void FJCBPMDGWOG(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x858CEA0", Offset = "0x858BEA0", VA = "0x18858CEA0")]
		private void RYNTCWGOPUU(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x858C720", Offset = "0x858B720", VA = "0x18858C720")]
		private void PTUOVBKKRFC(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x858C9D0", Offset = "0x858B9D0", VA = "0x18858C9D0")]
		private void PZBXJVTBAKE(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x858AF90", Offset = "0x8589F90", VA = "0x18858AF90")]
		private void ISTJPDIGONE(HOWHYCEBLOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x858C090", Offset = "0x858B090", VA = "0x18858C090")]
		private void NLVSEMKWXQK(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x858BE60", Offset = "0x858AE60", VA = "0x18858BE60")]
		private void LRWLMVKOGJG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x858D2D0", Offset = "0x858C2D0", VA = "0x18858D2D0")]
		private void WIOOKACWLPS(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x858BB60", Offset = "0x858AB60", VA = "0x18858BB60")]
		[CompilerGenerated]
		private void LJMWVCZJDQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JCGPEIGMXFW : OVSEBXDBUJS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private IRYDFGLWZGH CFTWGOEDKSD;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string CTAYVZZKIVO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> OWVFWQOPIRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int ILHEYMLASZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string XLNJVVRBUHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt UKKPMTMMLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? YKGDBEVOVYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string MTLKPSOAWSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong DBNWYCDBRZU;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int HBXWTXDVAYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool YEPOFYTHJRU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xC3DC90", Offset = "0xC3CC90", VA = "0x180C3DC90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC3D6C0", Offset = "0xC3C6C0", VA = "0x180C3D6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool OCXIMFCFZSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x858EA00", Offset = "0x858DA00", VA = "0x18858EA00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> WHZVFONCQRP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string GWHAQGXJWXB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x858E2B0", Offset = "0x858D2B0", VA = "0x18858E2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int GIIZDTBSRCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x858E260", Offset = "0x858D260", VA = "0x18858E260", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x858E990", Offset = "0x858D990", VA = "0x18858E990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool NFIQDNNRDCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x173AAE0", Offset = "0x1739AE0", VA = "0x18173AAE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x173AC20", Offset = "0x1739C20", VA = "0x18173AC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool VAXMMEJLODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x858E870", Offset = "0x858D870", VA = "0x18858E870", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string RQKDGXIZJIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x858E4E0", Offset = "0x858D4E0", VA = "0x18858E4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string XQBRPBOGCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x858E930", Offset = "0x858D930", VA = "0x18858E930", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool YWZWFPRUKES
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object IMKMBKMHNWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xACDCE0", Offset = "0xACCCE0", VA = "0x180ACDCE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xACDF50", Offset = "0xACCF50", VA = "0x180ACDF50", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong AXZVESQFSSB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xACDCF0", Offset = "0xACCCF0", VA = "0x180ACDCF0")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x858E4C0", Offset = "0x858D4C0", VA = "0x18858E4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x858EC50", Offset = "0x858DC50", VA = "0x18858EC50")]
		internal JCGPEIGMXFW(IRYDFGLWZGH a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x858EC90", Offset = "0x858DC90", VA = "0x18858EC90")]
		internal JCGPEIGMXFW(IRYDFGLWZGH a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x858EB40", Offset = "0x858DB40", VA = "0x18858EB40")]
		internal JCGPEIGMXFW(IRYDFGLWZGH a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x858EA90", Offset = "0x858DA90", VA = "0x18858EA90", Slot = "16")]
		public bool VMUITGSTKIT(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x858E3A0", Offset = "0x858D3A0", VA = "0x18858E3A0")]
		public NetworkedPlayerData KYPVXVOQEZD()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x858E580", Offset = "0x858D580", VA = "0x18858E580")]
		internal void NZGNCGCFZQZ([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NRSCVCZICEW : HUZGCNRKFDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IRYDFGLWZGH CFTWGOEDKSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> QHKCCHBNHAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, JCGPEIGMXFW> HURKRSGQDMW;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte BFVEVTWZOBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x858F110", Offset = "0x858E110", VA = "0x18858F110", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool LTTUKSPCFPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xC35BD0", Offset = "0xC34BD0", VA = "0x180C35BD0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> WHZVFONCQRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public JCGPEIGMXFW[] YEUPTBZNGLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAD05C0", Offset = "0xACF5C0", VA = "0x180AD05C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public JCGPEIGMXFW[] FSCTXUMYUPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAD3540", Offset = "0xAD2540", VA = "0x180AD3540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public JCGPEIGMXFW[] LFHXCRLPTJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F10", Offset = "0xAD1F10", VA = "0x180AD2F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JCGPEIGMXFW[] JMERDZDIVYH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAD32E0", Offset = "0xAD22E0", VA = "0x180AD32E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int EJCLKPFUPLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xC3AF70", Offset = "0xC39F70", VA = "0x180C3AF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1836E50", Offset = "0x1835E50", VA = "0x181836E50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x858F9A0", Offset = "0x858E9A0", VA = "0x18858F9A0")]
		public NRSCVCZICEW(IRYDFGLWZGH a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x858F2F0", Offset = "0x858E2F0", VA = "0x18858F2F0", Slot = "8")]
		public bool MRQJFGYVIFG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x858F8F0", Offset = "0x858E8F0", VA = "0x18858F8F0", Slot = "7")]
		public bool VMUITGSTKIT(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x858F740", Offset = "0x858E740", VA = "0x18858F740")]
		internal bool VENYOTWTMOD([In] NetworkedPlayerData playerData, bool a, [Out] JCGPEIGMXFW b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x858F160", Offset = "0x858E160", VA = "0x18858F160")]
		internal void LISXMHZLQFA(ulong a, [Out] JCGPEIGMXFW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x858ECD0", Offset = "0x858DCD0", VA = "0x18858ECD0")]
		internal void ERCZNHYGPSP([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x858F350", Offset = "0x858E350", VA = "0x18858F350")]
		private void OYNOJBRBERQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PPWVTOVXEXS : DRAUUFCATJA, ANKBABAEPJK, VUTHXTHLSUE, QJTNBJDGMMK, LRVNPGANVGM, LCAFFFMQMFL, ENSFLBPYLUR, PTABWLQDFFD, DQHGYEHPZZW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IRYDFGLWZGH CFTWGOEDKSD;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int FCEDIEEZHWL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8590640", Offset = "0x858F640", VA = "0x188590640", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int IZZEEJDARDC
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int JFRVZULTLSY
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8590C60", Offset = "0x858FC60", VA = "0x188590C60", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int KQPBGQWZWPE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8590480", Offset = "0x858F480", VA = "0x188590480", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool XCFQVXHCUSE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB80990", Offset = "0xB7F990", VA = "0x180B80990", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double STXIKPNXGPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x85908D0", Offset = "0x858F8D0", VA = "0x1885908D0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int TGOVDZFMICI
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8590510", Offset = "0x858F510", VA = "0x188590510", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool GQXMPAUZOJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8591300", Offset = "0x8590300", VA = "0x188591300", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool HEZZJNKLAHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8590E80", Offset = "0x858FE80", VA = "0x188590E80", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x85911F0", Offset = "0x85901F0", VA = "0x1885911F0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool EVTLLQQIOIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8591060", Offset = "0x8590060", VA = "0x188591060", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool RIAZAHEERGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8590940", Offset = "0x858F940", VA = "0x188590940", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public OVSEBXDBUJS UOTHWZKTJRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x858FF40", Offset = "0x858EF40", VA = "0x18858FF40", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int FTTMGVXVUQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8591220", Offset = "0x8590220", VA = "0x188591220", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int TZIBGWTPXSM
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8590CD0", Offset = "0x858FCD0", VA = "0x188590CD0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public OVSEBXDBUJS DTKXNFDZXTG
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8590860", Offset = "0x858F860", VA = "0x188590860", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool GJCZRRWYTMO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8590050", Offset = "0x858F050", VA = "0x188590050", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int BFVEVTWZOBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8590350", Offset = "0x858F350", VA = "0x188590350", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string CTAYVZZKIVO
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8591380", Offset = "0x8590380", VA = "0x188591380", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> OWVFWQOPIRR
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8591190", Offset = "0x8590190", VA = "0x188591190", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public JVZNGNWULOY BGTDFOJJXSK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8590300", Offset = "0x858F300", VA = "0x188590300", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool DEUYJSMWYQM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x858FC20", Offset = "0x858EC20", VA = "0x18858FC20", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x858FC50", Offset = "0x858EC50", VA = "0x18858FC50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float XSPRLQBSEZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x104D4B0", Offset = "0x104C4B0", VA = "0x18104D4B0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x180F930", Offset = "0x180E930", VA = "0x18180F930", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override SPAZCZEVTZZ DBIGOYZGKTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xACDF70", Offset = "0xACCF70", VA = "0x180ACDF70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool BTBZQKOQLUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x858FC70", Offset = "0x858EC70", VA = "0x18858FC70", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x85910A0", Offset = "0x85900A0", VA = "0x1885910A0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string VNWQOOXCHCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8590720", Offset = "0x858F720", VA = "0x188590720", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long AHCAVPLKRJT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8590590", Offset = "0x858F590", VA = "0x188590590", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long APLHIFGAZMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x858FC40", Offset = "0x858EC40", VA = "0x18858FC40", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<VASLQQLLDVS> JTYLZZSLTMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x858FFA0", Offset = "0x858EFA0", VA = "0x18858FFA0", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x85909A0", Offset = "0x858F9A0", VA = "0x1885909A0", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<OVSEBXDBUJS> XDATQVSJUTY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8590BA0", Offset = "0x858FBA0", VA = "0x188590BA0", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8590AE0", Offset = "0x858FAE0", VA = "0x188590AE0", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8591290", Offset = "0x8590290", VA = "0x188591290")]
		[WUCJGMLKEDZ.Root.GameOnly]
		internal static void WUCJGMLKEDZ(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8591580", Offset = "0x8590580", VA = "0x188591580")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public PPWVTOVXEXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x858FC90", Offset = "0x858EC90", VA = "0x18858FC90", Slot = "21")]
		public void CRZDZMMAZFR(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85905A0", Offset = "0x858F5A0", VA = "0x1885905A0", Slot = "23")]
		public void JJIEJVUWAJG(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8590EC0", Offset = "0x858FEC0", VA = "0x188590EC0", Slot = "27")]
		public void QSTXGBCTXRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8590840", Offset = "0x858F840", VA = "0x188590840", Slot = "47")]
		public bool LOATGABJLKY(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x858FE10", Offset = "0x858EE10", VA = "0x18858FE10", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x858FE40", Offset = "0x858EE40", VA = "0x18858FE40", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x858FCB0", Offset = "0x858ECB0", VA = "0x18858FCB0", Slot = "22")]
		public void CYXWDAZXTMR(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8591490", Offset = "0x8590490", VA = "0x188591490", Slot = "75")]
		public OVSEBXDBUJS YQLFXQKIPQG(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x85905D0", Offset = "0x858F5D0", VA = "0x1885905D0", Slot = "74")]
		public OVSEBXDBUJS JOMXKKCXRYA(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8590180", Offset = "0x858F180", VA = "0x188590180", Slot = "76")]
		public OVSEBXDBUJS FSHTGKEZGLC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8591000", Offset = "0x8590000", VA = "0x188591000", Slot = "18")]
		public bool QVOJGLTSTMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8590A50", Offset = "0x858FA50", VA = "0x188590A50", Slot = "77")]
		public IReadOnlyList<OVSEBXDBUJS> OELOYDYOJSM(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85910F0", Offset = "0x85900F0", VA = "0x1885910F0", Slot = "78")]
		public IReadOnlyList<OVSEBXDBUJS> RYJXHVRUZAL(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8590280", Offset = "0x858F280", VA = "0x188590280", Slot = "45")]
		public bool FTCIHMRZUNP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85903B0", Offset = "0x858F3B0", VA = "0x1885903B0", Slot = "20")]
		public void GIWYAPKVNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x858FF60", Offset = "0x858EF60", VA = "0x18858FF60", Slot = "62")]
		public bool EFSZTLMNQBJ(byte a, object b, XSNAFSFANWP c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8591360", Offset = "0x8590360", VA = "0x188591360", Slot = "28")]
		public void XRHSQBYDVHR(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8590EA0", Offset = "0x858FEA0", VA = "0x188590EA0", Slot = "30")]
		public int QRQKMVLOPZN(VASLQQLLDVS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x858FCE0", Offset = "0x858ECE0", VA = "0x18858FCE0", Slot = "79")]
		public bool DXNYDFRAPJW(OVSEBXDBUJS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85904A0", Offset = "0x858F4A0", VA = "0x1885904A0", Slot = "17")]
		public float GPUBAWWKPHH(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85906C0", Offset = "0x858F6C0", VA = "0x1885906C0", Slot = "8")]
		public override void KSOBUHMPDPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8590D70", Offset = "0x858FD70", VA = "0x188590D70", Slot = "73")]
		public void QBDRGJDKPSW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8590640", Offset = "0x858F640", VA = "0x188590640", Slot = "87")]
		public int YTJXEOZTVTL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x858FC80", Offset = "0x858EC80", VA = "0x18858FC80", Slot = "11")]
		private void CGASFVOHRFN(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x858FC30", Offset = "0x858EC30", VA = "0x18858FC30", Slot = "12")]
		private void AIRXGBJUDNK(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8591480", Offset = "0x8590480", VA = "0x188591480", Slot = "25")]
		private void XSGMFSMNKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85906A0", Offset = "0x858F6A0", VA = "0x1885906A0", Slot = "26")]
		private void JWBZFPPPDKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8590B90", Offset = "0x858FB90", VA = "0x188590B90", Slot = "31")]
		private void OOFDLCHBUSM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8590C50", Offset = "0x858FC50", VA = "0x188590C50", Slot = "32")]
		private void PHOBUGUTOCL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x858FE00", Offset = "0x858EE00", VA = "0x18858FE00", Slot = "48")]
		private void DZRIEDTUPZQ(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8591210", Offset = "0x8590210", VA = "0x188591210", Slot = "49")]
		private void UOEJMNFPKAT(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8591280", Offset = "0x8590280", VA = "0x188591280", Slot = "50")]
		private void WGLJXKHNXMH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8590930", Offset = "0x858F930", VA = "0x188590930", Slot = "51")]
		private void MRJOVZLJHTO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8590990", Offset = "0x858F990", VA = "0x188590990", Slot = "52")]
		private void MXDWMJRRHHI(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85906B0", Offset = "0x858F6B0", VA = "0x1885906B0", Slot = "53")]
		private IDisposable KJFIEHIWIMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8590170", Offset = "0x858F170", VA = "0x188590170", Slot = "54")]
		private bool FEUAACKNUGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x858FF90", Offset = "0x858EF90", VA = "0x18858FF90", Slot = "55")]
		private void EUCXPBRSXHC(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8591180", Offset = "0x8590180", VA = "0x188591180", Slot = "57")]
		private void RZLNBYAGVXG(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x858FCD0", Offset = "0x858ECD0", VA = "0x18858FCD0", Slot = "58")]
		private void DQUXLZIHWAT(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8590830", Offset = "0x858F830", VA = "0x188590830", Slot = "80")]
		private void LJKDDEXJPRA(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x85910E0", Offset = "0x85900E0", VA = "0x1885910E0", Slot = "81")]
		private void RXOUJHIGRIR(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85911E0", Offset = "0x85901E0", VA = "0x1885911E0", Slot = "82")]
		private void TKOPRNVDRIL()
		{
		}
	}
}
namespace NetcodeImpl
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class DissonanceNetworkManagerInjector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public NfgoCommsNetwork OMCPLNUUMYE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8588740", Offset = "0x8587740", VA = "0x188588740")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8588900", Offset = "0x8587900", VA = "0x188588900")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8588A70", Offset = "0x8587A70", VA = "0x188588A70")]
		private void XNYJLBVISVZ(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NetworkManagerBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private NetworkManager networkManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NetworkManager secondaryNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x858FB30", Offset = "0x858EB30", VA = "0x18858FB30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class WIVKNEPFTWD
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool BPTNUNZLUTM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xBA8E20", Offset = "0xBA7E20", VA = "0x180BA8E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager WLMUPEEZOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager VVFACOUIGHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager VIPMXDNZESP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> XNYJLBVISVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8591C70", Offset = "0x8590C70", VA = "0x188591C70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8591BC0", Offset = "0x8590BC0", VA = "0x188591BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8591D20", Offset = "0x8590D20", VA = "0x188591D20")]
		[RecRoom.NoEngine.Common.Preserve]
		public WIVKNEPFTWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8591AE0", Offset = "0x8590AE0", VA = "0x188591AE0")]
		[WUCJGMLKEDZ.Root]
		public static void GZRDXFJCXZC(KTJKRWFMICD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8591B50", Offset = "0x8590B50", VA = "0x188591B50")]
		public void KUETAQLPOFC(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class VIPMXDNZESP : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LICYJJTWTDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate QOASKUDXBXC;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F00", Offset = "0xAD1F00", VA = "0x180AD2F00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD3550", Offset = "0xAD2550", VA = "0x180AD3550", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8591840", Offset = "0x8590840", VA = "0x188591840", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8591990", Offset = "0x8590990", VA = "0x188591990", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x85918F0", Offset = "0x85908F0", VA = "0x1885918F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8591A40", Offset = "0x8590A40", VA = "0x188591A40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8591750", Offset = "0x8590750", VA = "0x188591750", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8591750", Offset = "0x8590750", VA = "0x188591750", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x85917D0", Offset = "0x85907D0", VA = "0x1885917D0")]
		public VIPMXDNZESP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8591770", Offset = "0x8590770", VA = "0x188591770", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8591790", Offset = "0x8590790", VA = "0x188591790", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x85917B0", Offset = "0x85907B0", VA = "0x1885917B0", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "21")]
		public void SendCustomMessage(NamedMessageType namedMessageType, ulong clientId, FastBufferWriter messageStream, NetworkDelivery networkDelivery)
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
