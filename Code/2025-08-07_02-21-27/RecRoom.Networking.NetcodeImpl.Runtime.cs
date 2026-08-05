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
		[Cpp2IlInjected.Address(RVA = "0x8B0F980", Offset = "0x8B0E580", VA = "0x188B0F980", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class FYMYUMVRQAZ : WGQKHJHIHJT, KQDBLQWKNOT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class SMKMIMPUCNU : RQAGMLJLYPY
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x600004E")]
				[Cpp2IlInjected.Address(RVA = "0x8B0E9C0", Offset = "0x8B0D5C0", VA = "0x188B0E9C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public byte VUTIZLHWNDC
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xBF7010", Offset = "0xBF5C10", VA = "0x180BF7010")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public int ZIHFNJEOTOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xC13B00", Offset = "0xC12700", VA = "0x180C13B00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public object CVLYVVPBTUS
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x83B91F0", Offset = "0x83B7DF0", VA = "0x1883B91F0")]
			public SMKMIMPUCNU(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E980", Offset = "0x8B0D580", VA = "0x188B0E980", Slot = "8")]
			public bool KCRQOJGIJUH(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState RHYDIEDNFGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch WNRCPDNZETE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int NIWMUPBAOXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<SMKMIMPUCNU> DITQFZNGCLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> GQORDTAFIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private OHESUPSZJTI CXYEWUZLPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private VCWYJUDBKDW ZESFOJFOYRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool QWOQQXJSHYC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager GTAAVDIUQGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport JVULMWKWQZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8B08B90", Offset = "0x8B07790", VA = "0x188B08B90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState TEBXHXIJOSW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8B0B920", Offset = "0x8B0A520", VA = "0x188B0B920", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B07680", Offset = "0x8B06280", VA = "0x188B07680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OKOZUARBZHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OHESUPSZJTI PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public VCWYJUDBKDW YUUSVKZWQVH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private QJXWOHUBXKU NEZUBSELTJO
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool OQWVSBVOFDD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8B086B0", Offset = "0x8B072B0", VA = "0x188B086B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool HUZCELRYAUY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8B07B60", Offset = "0x8B06760", VA = "0x188B07B60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FRGHDAZDKHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8B07B60", Offset = "0x8B06760", VA = "0x188B07B60", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EGLPNORYWGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8B07B60", Offset = "0x8B06760", VA = "0x188B07B60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool QDVEDJHOVLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xBB3CE0", Offset = "0xBB28E0", VA = "0x180BB3CE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B09440", Offset = "0x8B08040", VA = "0x188B09440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Exception GQEESMYBDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB131B0", Offset = "0xB11DB0", VA = "0x180B131B0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int PTBFBDNUXIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool VGFLZVTOATQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B093F0", Offset = "0x8B07FF0", VA = "0x188B093F0", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B0BBA0", Offset = "0x8B0A7A0", VA = "0x188B0BBA0", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SBNSKLFULUG
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB13150", Offset = "0xB11D50", VA = "0x180B13150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB13260", Offset = "0xB11E60", VA = "0x180B13260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double AUQDPIVCHZO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8B07B10", Offset = "0x8B06710", VA = "0x188B07B10")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double CKOGZKZBRKD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B08EF0", Offset = "0x8B07AF0", VA = "0x188B08EF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BAXMPNLKWHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B095B0", Offset = "0x8B081B0", VA = "0x188B095B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string SNHYKSCBNQO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8B07C00", Offset = "0x8B06800", VA = "0x188B07C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int GISOYMDMFHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B08EC0", Offset = "0x8B07AC0", VA = "0x188B08EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BXPKXKSWHTE IYASBWMBMUU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8B09CA0", Offset = "0x8B088A0", VA = "0x188B09CA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> HNQJJDSIEUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8B07A60", Offset = "0x8B06660", VA = "0x188B07A60", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8B0B010", Offset = "0x8B09C10", VA = "0x188B0B010", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> JDKMNMHILNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B0B330", Offset = "0x8B09F30", VA = "0x188B0B330", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B072C0", Offset = "0x8B05EC0", VA = "0x188B072C0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BC00", Offset = "0x8B0A800", VA = "0x188B0BC00")]
		public FYMYUMVRQAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B07380", Offset = "0x8B05F80", VA = "0x188B07380")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B08CA0", Offset = "0x8B078A0", VA = "0x188B08CA0")]
		private void LKFGMPRTKPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8B080A0", Offset = "0x8B06CA0", VA = "0x188B080A0")]
		private void GIWUOMOGWCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B076B0", Offset = "0x8B062B0", VA = "0x188B076B0")]
		public bool DXTAWHMKVAW(WJBKOLNRRJE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B06DC0", Offset = "0x8B059C0", VA = "0x188B06DC0")]
		public bool ABPPEACKXPV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B09560", Offset = "0x8B08160", VA = "0x188B09560")]
		public void NWKNZPKEFYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B07BB0", Offset = "0x8B067B0", VA = "0x188B07BB0")]
		public void FHHAKCJBAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8B06E10", Offset = "0x8B05A10", VA = "0x188B06E10")]
		public void ADAYWVRTTWJ(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8B08900", Offset = "0x8B07500", VA = "0x188B08900")]
		public void JDFGJZEIVJV(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B090A0", Offset = "0x8B07CA0", VA = "0x188B090A0")]
		public void MEUEJJXHMRQ(IDictionary<object, object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AD80", Offset = "0x8B09980", VA = "0x188B0AD80")]
		public void Serialize(object obj, NativeList<byte> dstList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8B07960", Offset = "0x8B06560", VA = "0x188B07960")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8B09AB0", Offset = "0x8B086B0", VA = "0x188B09AB0")]
		public int OQZQHXEOPLL(RQAGMLJLYPY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A3F0", Offset = "0x8B08FF0", VA = "0x188B0A3F0")]
		public bool RaiseEvent(byte eventCode, object eventContent, PZIMWREHPGJ raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B09600", Offset = "0x8B08200", VA = "0x188B09600")]
		public bool OPMXWKLETOX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B086E0", Offset = "0x8B072E0", VA = "0x188B086E0")]
		internal bool ICRLXDWQSHJ([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B940", Offset = "0x8B0A540", VA = "0x188B0B940")]
		internal bool YKECKTAUSPL([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B07A50", Offset = "0x8B06650", VA = "0x188B07A50")]
		public void LeaveRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B07A50", Offset = "0x8B06650", VA = "0x188B07A50")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B08F40", Offset = "0x8B07B40", VA = "0x188B08F40")]
		private void LSGANHPUACS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B06AA0", Offset = "0x8B056A0", VA = "0x188B06AA0")]
		private void AAKLDHZJJWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B830", Offset = "0x8B0A430", VA = "0x188B0B830")]
		private void YIOGETOCCFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8B08100", Offset = "0x8B06D00", VA = "0x188B08100")]
		private void HCTBWANYPOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B5A0", Offset = "0x8B0A1A0", VA = "0x188B0B5A0")]
		private void WYBRFSKCMJI(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAB540", Offset = "0x3BAA140", VA = "0x183BAB540")]
		private void ZRBEZLNCOAK<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AC50", Offset = "0x8B09850", VA = "0x188B0AC50")]
		private void SSGGXLFTNLR(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B210", Offset = "0x8B09E10", VA = "0x188B0B210")]
		private void URKBDEEBZZC(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B07D00", Offset = "0x8B06900", VA = "0x188B07D00")]
		private void FUATIPGLKEM(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B09EC0", Offset = "0x8B08AC0", VA = "0x188B09EC0")]
		private void RGOSKUDBCMR(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8B083B0", Offset = "0x8B06FB0", VA = "0x188B083B0")]
		private void HLKCQCIEYPJ(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B07D30", Offset = "0x8B06930", VA = "0x188B07D30")]
		private void FYMLVXKAHRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B077D0", Offset = "0x8B063D0", VA = "0x188B077D0")]
		private void DYMXXCIPOAU(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B3E0", Offset = "0x8B09FE0", VA = "0x188B0B3E0")]
		private void VQSQWHEBRZI(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B07000", Offset = "0x8B05C00", VA = "0x188B07000")]
		private void AMRMNJPWULI(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B092C0", Offset = "0x8B07EC0", VA = "0x188B092C0")]
		private void MZXSTHCNMUC(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8B0B0C0", Offset = "0x8B09CC0", VA = "0x188B0B0C0")]
		private void URKBDEEBZZC(SMKMIMPUCNU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B09DE0", Offset = "0x8B089E0", VA = "0x188B09DE0")]
		private void QGHNUMCMFFG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8B09CF0", Offset = "0x8B088F0", VA = "0x188B09CF0")]
		private void QCBKDDBMYRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8B0A850", Offset = "0x8B09450", VA = "0x188B0A850")]
		private void SHWVTIEHHXQ(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8B07370", Offset = "0x8B05F70", VA = "0x188B07370")]
		[CompilerGenerated]
		private void CHCQILWIUHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class OHESUPSZJTI : WJBKOLNRRJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private FYMYUMVRQAZ WLRGTJZOEQN;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public static string MVDTPWRFZDU;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static Func<string, string> KHSBOZUXYFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int HQPOVDCSPES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string DNDITQLTERA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private ObscuredInt AXSWNTUYHKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool? AODWKRALGQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private string ZFSTSFJQXOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ulong LELBFINZMZW;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int IZNYAAQIDED
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool PEVBNNCHVZS
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xBE1AA0", Offset = "0xBE06A0", VA = "0x180BE1AA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xF1F840", Offset = "0xF1E440", VA = "0x180F1F840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool KPMTYMQEXNF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C3B0", Offset = "0x8B0AFB0", VA = "0x188B0C3B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Dictionary<object, object> MAGMQBCAHJF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string UIGNJDWHIIV
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C700", Offset = "0x8B0B300", VA = "0x188B0C700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int COAQBOYPXYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C460", Offset = "0x8B0B060", VA = "0x188B0C460", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C690", Offset = "0x8B0B290", VA = "0x188B0C690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool AAWSOGKTXTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool HOZNJGIWKNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C5D0", Offset = "0x8B0B1D0", VA = "0x188B0C5D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string OCKFVCPENHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C7F0", Offset = "0x8B0B3F0", VA = "0x188B0C7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string VVZJOHTPCDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C350", Offset = "0x8B0AF50", VA = "0x188B0C350", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool KDIBHIVOCRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public object RSRCLCGOETK
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal ulong EIXGHUTKBAP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C440", Offset = "0x8B0B040", VA = "0x188B0C440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CB70", Offset = "0x8B0B770", VA = "0x188B0CB70")]
		internal OHESUPSZJTI(FYMYUMVRQAZ a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CBB0", Offset = "0x8B0B7B0", VA = "0x188B0CBB0")]
		internal OHESUPSZJTI(FYMYUMVRQAZ a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CBF0", Offset = "0x8B0B7F0", VA = "0x188B0CBF0")]
		internal OHESUPSZJTI(FYMYUMVRQAZ a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0C2A0", Offset = "0x8B0AEA0", VA = "0x188B0C2A0", Slot = "16")]
		public bool CLBOLIAJSIF(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8B0C4B0", Offset = "0x8B0B0B0", VA = "0x188B0C4B0")]
		public NetworkedPlayerData KRJPFAAAKSH()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8B0C890", Offset = "0x8B0B490", VA = "0x188B0C890")]
		internal void URHVUXKUKGP([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class VCWYJUDBKDW : QJXWOHUBXKU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private FYMYUMVRQAZ WLRGTJZOEQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private Dictionary<object, object> JSAETMVUIEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		internal Dictionary<int, OHESUPSZJTI> CQUWVAHVBAA;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8B0EEB0", Offset = "0x8B0DAB0", VA = "0x188B0EEB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public byte WXFAOCQLSOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8B0EEE0", Offset = "0x8B0DAE0", VA = "0x188B0EEE0", Slot = "5")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool JVEQXLQYENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Dictionary<object, object> MAGMQBCAHJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public OHESUPSZJTI[] TLROCOVPHPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public OHESUPSZJTI[] WEKSEXUWKYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB13200", Offset = "0xB11E00", VA = "0x180B13200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public OHESUPSZJTI[] GEKWRBTTYKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public OHESUPSZJTI[] UCGHSEGXVIB
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int XGCQPDSMOJX
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xF31B10", Offset = "0xF30710", VA = "0x180F31B10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1A9D7C0", Offset = "0x1A9C3C0", VA = "0x181A9D7C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F7F0", Offset = "0x8B0E3F0", VA = "0x188B0F7F0")]
		public VCWYJUDBKDW(FYMYUMVRQAZ a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8B0EF30", Offset = "0x8B0DB30", VA = "0x188B0EF30", Slot = "9")]
		public bool VCCQARXYCGO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B0EAB0", Offset = "0x8B0D6B0", VA = "0x188B0EAB0", Slot = "8")]
		public bool CLBOLIAJSIF(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8B0EB60", Offset = "0x8B0D760", VA = "0x188B0EB60")]
		internal bool KSZZAFLGVQZ([In] NetworkedPlayerData playerData, bool a, [Out] OHESUPSZJTI b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8B0ED10", Offset = "0x8B0D910", VA = "0x188B0ED10")]
		internal void KXZKTRRPWCU(ulong a, [Out] OHESUPSZJTI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8B0F3B0", Offset = "0x8B0DFB0", VA = "0x188B0F3B0")]
		internal void YHHEROHPUUN([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8B0EF90", Offset = "0x8B0DB90", VA = "0x188B0EF90")]
		private void XMOHIBSBTRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OQCKJFBYJKG : JNTPAIRWSYI, ZUUCGYXVQOS, NVFVUOVIIUO, DEUAISEJQSQ, YGYNNKGMBTM, TQBBOSYCXSX, ZAMSNYKZUGX, KQDBLQWKNOT, DBVWTZVEMXQ, PAONCUNUEQH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private FYMYUMVRQAZ WLRGTJZOEQN;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int BAXMPNLKWHH
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D900", Offset = "0x8B0C500", VA = "0x188B0D900", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int BXOMLBXBQEO
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int GUPHGNFOYMO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D5D0", Offset = "0x8B0C1D0", VA = "0x188B0D5D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int OKOZUARBZHC
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xE73F30", Offset = "0xE72B30", VA = "0x180E73F30", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool AVVMNPMFYSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE725D0", Offset = "0xE711D0", VA = "0x180E725D0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public LOFTYJJETKU NNSWMXMMOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8B0CE30", Offset = "0x8B0BA30", VA = "0x188B0CE30", Slot = "34")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public double AUQDPIVCHZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D110", Offset = "0x8B0BD10", VA = "0x188B0D110", Slot = "36")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int DSGWFOJGIFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E140", Offset = "0x8B0CD40", VA = "0x188B0E140", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool GZKTPRQIGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x27EB390", Offset = "0x27E9F90", VA = "0x1827EB390", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool HUZCELRYAUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D230", Offset = "0x8B0BE30", VA = "0x188B0D230", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool FRGHDAZDKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D230", Offset = "0x8B0BE30", VA = "0x188B0D230", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool QDVEDJHOVLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D640", Offset = "0x8B0C240", VA = "0x188B0D640", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D870", Offset = "0x8B0C470", VA = "0x188B0D870", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool KSVLEGUMHXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E0A0", Offset = "0x8B0CCA0", VA = "0x188B0E0A0", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool OQWVSBVOFDD
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D4F0", Offset = "0x8B0C0F0", VA = "0x188B0D4F0", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public object KEVEKDAECNL
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xB14940", Offset = "0xB13540", VA = "0x180B14940", Slot = "50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public WJBKOLNRRJE PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E1D0", Offset = "0x8B0CDD0", VA = "0x188B0E1D0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int OJYHBYGGBKX
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8B0CE90", Offset = "0x8B0BA90", VA = "0x188B0CE90", Slot = "74")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int XGUNJTFPWQC
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E1F0", Offset = "0x8B0CDF0", VA = "0x188B0E1F0", Slot = "75")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public WJBKOLNRRJE EDOAEKBLKMK
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D7A0", Offset = "0x8B0C3A0", VA = "0x188B0D7A0", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D3B0", Offset = "0x8B0BFB0", VA = "0x188B0D3B0", Slot = "77")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int WXFAOCQLSOT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DB40", Offset = "0x8B0C740", VA = "0x188B0DB40", Slot = "78")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string MVDTPWRFZDU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DC10", Offset = "0x8B0C810", VA = "0x188B0DC10", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Func<string, string> KHSBOZUXYFX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DBB0", Offset = "0x8B0C7B0", VA = "0x188B0DBB0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public BXPKXKSWHTE IYASBWMBMUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DAF0", Offset = "0x8B0C6F0", VA = "0x188B0DAF0", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool SBNSKLFULUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x8B0CE80", Offset = "0x8B0BA80", VA = "0x188B0CE80", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E120", Offset = "0x8B0CD20", VA = "0x188B0E120", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override float VRYQVHOKDOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xE8B190", Offset = "0xE89D90", VA = "0x180E8B190", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xE8C370", Offset = "0xE8AF70", VA = "0x180E8C370", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override WGQKHJHIHJT NCXELNDCXQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB131F0", Offset = "0xB11DF0", VA = "0x180B131F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool SKMBRSBWOWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string SNHYKSCBNQO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D290", Offset = "0x8B0BE90", VA = "0x188B0D290", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public long JRKMRJXEUZJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E100", Offset = "0x8B0CD00", VA = "0x188B0E100", Slot = "93")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public long HRGTDMOUQVY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D3A0", Offset = "0x8B0BFA0", VA = "0x188B0D3A0", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<WGQKHJHIHJT, WGQKHJHIHJT> WWYJLUGIMCZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8B0DFF0", Offset = "0x8B0CBF0", VA = "0x188B0DFF0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8B0CEF0", Offset = "0x8B0BAF0", VA = "0x188B0CEF0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<RQAGMLJLYPY> LTYUWEJPATT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D170", Offset = "0x8B0BD70", VA = "0x188B0D170", Slot = "68")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8B0CD80", Offset = "0x8B0B980", VA = "0x188B0CD80", Slot = "69")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<WJBKOLNRRJE> GXYINHYWKGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E560", Offset = "0x8B0D160", VA = "0x188B0E560", Slot = "71")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8B0D670", Offset = "0x8B0C270", VA = "0x188B0D670", Slot = "72")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D560", Offset = "0x8B0C160", VA = "0x188B0D560")]
		[IFIZWETSKCB.Root.GameOnly]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E610", Offset = "0x8B0D210", VA = "0x188B0E610")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public OQCKJFBYJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CD00", Offset = "0x8B0B900", VA = "0x188B0CD00", Slot = "21")]
		public void ADAYWVRTTWJ(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D770", Offset = "0x8B0C370", VA = "0x188B0D770", Slot = "23")]
		public void MEUEJJXHMRQ(IDictionary<object, object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E400", Offset = "0x8B0D000", VA = "0x188B0E400", Slot = "27")]
		public void YQSYZGNNHQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E0E0", Offset = "0x8B0CCE0", VA = "0x188B0E0E0", Slot = "56")]
		public bool UJEBYDWZLVQ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D0C0", Offset = "0x8B0BCC0", VA = "0x188B0D0C0", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D0F0", Offset = "0x8B0BCF0", VA = "0x188B0D0F0", Slot = "55")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D610", Offset = "0x8B0C210", VA = "0x188B0D610", Slot = "22")]
		public void JDFGJZEIVJV(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DA00", Offset = "0x8B0C600", VA = "0x188B0DA00", Slot = "83")]
		public WJBKOLNRRJE OUPJDKYGOPG(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DF90", Offset = "0x8B0CB90", VA = "0x188B0DF90", Slot = "82")]
		public WJBKOLNRRJE TRBSVSFBQLQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DD60", Offset = "0x8B0C960", VA = "0x188B0DD60", Slot = "84")]
		public WJBKOLNRRJE SYFRPMTIPBU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D810", Offset = "0x8B0C410", VA = "0x188B0D810", Slot = "18")]
		public bool NSIPUDQETRM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E290", Offset = "0x8B0CE90", VA = "0x188B0E290", Slot = "85")]
		public IReadOnlyList<WJBKOLNRRJE> XXSWMMVJKIC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E370", Offset = "0x8B0CF70", VA = "0x188B0E370", Slot = "86")]
		public IReadOnlyList<WJBKOLNRRJE> YFINFNYJFCJ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D960", Offset = "0x8B0C560", VA = "0x188B0D960", Slot = "54")]
		public bool OPMXWKLETOX(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D730", Offset = "0x8B0C330", VA = "0x188B0D730", Slot = "53")]
		public bool LeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E320", Offset = "0x8B0CF20", VA = "0x188B0E320", Slot = "20")]
		public void YFHQTERUFEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DD20", Offset = "0x8B0C920", VA = "0x188B0DD20", Slot = "70")]
		public bool RaiseEvent(byte eventCode, object eventContent, PZIMWREHPGJ raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DE50", Offset = "0x8B0CA50", VA = "0x188B0DE50", Slot = "28")]
		public void Serialize(object obj, NativeList<byte> data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D9E0", Offset = "0x8B0C5E0", VA = "0x188B0D9E0", Slot = "30")]
		public int OQZQHXEOPLL(RQAGMLJLYPY a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "45")]
		public void CQGNTPUWYKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CFA0", Offset = "0x8B0BBA0", VA = "0x188B0CFA0", Slot = "87")]
		public bool DXTAWHMKVAW(WJBKOLNRRJE a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "35")]
		public void LYZVJUFUVPS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D890", Offset = "0x8B0C490", VA = "0x188B0D890", Slot = "17")]
		public float NULNMPVZHAX(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CD20", Offset = "0x8B0B920", VA = "0x188B0CD20", Slot = "8")]
		public override void BDGKBLKFTSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DE70", Offset = "0x8B0CA70", VA = "0x188B0DE70", Slot = "81")]
		public void TEDPDIJZHPG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D900", Offset = "0x8B0C500", VA = "0x188B0D900", Slot = "95")]
		public int XOKNWYKQWRZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E1C0", Offset = "0x8B0CDC0", VA = "0x188B0E1C0", Slot = "11")]
		private void WVLTACBDDEJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E540", Offset = "0x8B0D140", VA = "0x188B0E540", Slot = "12")]
		private void ZBBUEMXGMLE(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E550", Offset = "0x8B0D150", VA = "0x188B0E550", Slot = "25")]
		private void ZOVONKTZXKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DAE0", Offset = "0x8B0C6E0", VA = "0x188B0DAE0", Slot = "26")]
		private void OVLOPSYOHEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D4D0", Offset = "0x8B0C0D0", VA = "0x188B0D4D0", Slot = "31")]
		private void GQAJKFVJLGO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D4E0", Offset = "0x8B0C0E0", VA = "0x188B0D4E0", Slot = "32")]
		private void HNDVJOETTGR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DF80", Offset = "0x8B0CB80", VA = "0x188B0DF80", Slot = "57")]
		private void THTPTTWNMYA(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D630", Offset = "0x8B0C230", VA = "0x188B0D630", Slot = "58")]
		private void JQJZEPKAMXX(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D790", Offset = "0x8B0C390", VA = "0x188B0D790", Slot = "59")]
		private void MQGCXYUOAZT(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D660", Offset = "0x8B0C260", VA = "0x188B0D660", Slot = "60")]
		private void LGHBJPYLPZQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DBA0", Offset = "0x8B0C7A0", VA = "0x188B0DBA0", Slot = "61")]
		private void PJJDOKRDMCE(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D720", Offset = "0x8B0C320", VA = "0x188B0D720", Slot = "62")]
		private IDisposable LTAPZONALHZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D760", Offset = "0x8B0C360", VA = "0x188B0D760", Slot = "63")]
		private bool MAKGVUVGNPY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E110", Offset = "0x8B0CD10", VA = "0x188B0E110", Slot = "64")]
		private void VBCSUNHEBYS(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D540", Offset = "0x8B0C140", VA = "0x188B0D540", Slot = "66")]
		private void HZOMZWLRLKK(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B0CE70", Offset = "0x8B0BA70", VA = "0x188B0CE70", Slot = "67")]
		private void CEZPAIQGKMF(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D550", Offset = "0x8B0C150", VA = "0x188B0D550", Slot = "88")]
		private void IDTTNYZKFZS(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B0DD50", Offset = "0x8B0C950", VA = "0x188B0DD50", Slot = "89")]
		private void SJBGQYDGUTZ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B0D220", Offset = "0x8B0BE20", VA = "0x188B0D220", Slot = "90")]
		private void EOQUVJHIXQB()
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

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NfgoCommsNetwork TKYXWXBURMO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B06890", Offset = "0x8B05490", VA = "0x188B06890")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B06A50", Offset = "0x8B05650", VA = "0x188B06A50")]
		private void DOVEGMTTGYN(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B0C1B0", Offset = "0x8B0ADB0", VA = "0x188B0C1B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class SCVZMTBKJIV
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool TKNACZBONHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xBF7030", Offset = "0xBF5C30", VA = "0x180BF7030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xBF7010", Offset = "0xBF5C10", VA = "0x180BF7010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NetworkManager GTAAVDIUQGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NetworkManager WHXXLYIILAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xB180C0", Offset = "0xB16CC0", VA = "0x180B180C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public INetworkManager NLDBQDMDRJH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NetworkManager, bool> DOVEGMTTGYN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E760", Offset = "0x8B0D360", VA = "0x188B0E760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E810", Offset = "0x8B0D410", VA = "0x188B0E810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E8C0", Offset = "0x8B0D4C0", VA = "0x188B0E8C0")]
		[RecRoom.NoEngine.Common.Preserve]
		public SCVZMTBKJIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E680", Offset = "0x8B0D280", VA = "0x188B0E680")]
		[IFIZWETSKCB.Root]
		public static void IHKWZARGQQK(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B0E6F0", Offset = "0x8B0D2F0", VA = "0x188B0E6F0")]
		public void NENNNOKGMZQ(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class NLDBQDMDRJH : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float LVHRIHSKKGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate NMLWIMRIKMS;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xB13A80", Offset = "0xB12680", VA = "0x180B13A80", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8B0BF10", Offset = "0x8B0AB10", VA = "0x188B0BF10", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C060", Offset = "0x8B0AC60", VA = "0x188B0C060", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x8B0BFC0", Offset = "0x8B0ABC0", VA = "0x188B0BFC0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x8B0C110", Offset = "0x8B0AD10", VA = "0x188B0C110", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BE20", Offset = "0x8B0AA20", VA = "0x188B0BE20", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BE20", Offset = "0x8B0AA20", VA = "0x188B0BE20", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "17")]
		public void ClearDeferredMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BEA0", Offset = "0x8B0AAA0", VA = "0x188B0BEA0")]
		public NLDBQDMDRJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BE40", Offset = "0x8B0AA40", VA = "0x188B0BE40", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BE60", Offset = "0x8B0AA60", VA = "0x188B0BE60", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8B0BE80", Offset = "0x8B0AA80", VA = "0x188B0BE80", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "21")]
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
