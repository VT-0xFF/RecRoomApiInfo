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
		[Cpp2IlInjected.Address(RVA = "0x86030D0", Offset = "0x86016D0", VA = "0x1886030D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class HQPIUDOPWQG : LULDBTLWMMU, GNTZBYSJAKA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class UZIJILOAAQH : KMNYUBYLMOF
		{
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x8603090", Offset = "0x8601690", VA = "0x188603090", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public byte JCAQGEWAOFT
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE2FC0", VA = "0x180BE49C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int MELQJXGPJAV
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xC071B0", Offset = "0xC057B0", VA = "0x180C071B0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xC071A0", Offset = "0xC057A0", VA = "0x180C071A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public object RDOUNCXBMRJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAA7A70", Offset = "0xAA6070", VA = "0x180AA7A70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7EB23F0", Offset = "0x7EB09F0", VA = "0x187EB23F0")]
			public UZIJILOAAQH(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8603050", Offset = "0x8601650", VA = "0x188603050", Slot = "8")]
			public bool ZKJFYFPTSEI(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState UDZXTHFFSEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch BIBSJACCLXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int BAZWIIABKUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<UZIJILOAAQH> XYCDJVVMZAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> WBRKGOEABDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private QFWQOWNWAYZ UKTSRTTGCWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private DUCPVZHYEHZ MDAMGSBCNUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool PVGGQMSSWML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PTKRMZCNOCZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager HJNQUYLYIGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport IBZQACSVWGR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8600CC0", Offset = "0x85FF2C0", VA = "0x188600CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState IWTSUTKKYDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x85FFC50", Offset = "0x85FE250", VA = "0x1885FFC50", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8601ED0", Offset = "0x86004D0", VA = "0x188601ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int EFRFNSNEUAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public QFWQOWNWAYZ MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DUCPVZHYEHZ AVUADSSKXTY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private VMUJRLNJPHP HXJJNTBEBWL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x85FD9D0", Offset = "0x85FBFD0", VA = "0x1885FD9D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FDXUTTWQDHV
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x85FE710", Offset = "0x85FCD10", VA = "0x1885FE710", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AQYNNVJWTED
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x85FE710", Offset = "0x85FCD10", VA = "0x1885FE710", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FKRHGRNAQOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x85FE710", Offset = "0x85FCD10", VA = "0x1885FE710", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool GLEAKZSTAQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB9A660", Offset = "0xB98C60", VA = "0x180B9A660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x85FCB30", Offset = "0x85FB130", VA = "0x1885FCB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Exception UJTZQSJUDCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAACAA0", Offset = "0xAAB0A0", VA = "0x180AACAA0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int JEDOTRPWTAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool PNGCCEKMCGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86007C0", Offset = "0x85FEDC0", VA = "0x1886007C0", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8601C40", Offset = "0x8600240", VA = "0x188601C40", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool RWMSFILBLUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAB3040", Offset = "0xAB1640", VA = "0x180AB3040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAB31B0", Offset = "0xAB17B0", VA = "0x180AB31B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double QMXCMFRZYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8601DD0", Offset = "0x86003D0", VA = "0x188601DD0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double WFDFAYTQOFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x85FE140", Offset = "0x85FC740", VA = "0x1885FE140")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int WKQPIRWOUFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85FE760", Offset = "0x85FCD60", VA = "0x1885FE760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string DPCDTBVKSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8601030", Offset = "0x85FF630", VA = "0x188601030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int BDMJUKYGVUY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8600210", Offset = "0x85FE810", VA = "0x188600210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LBZZZSNEOUH SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8601D80", Offset = "0x8600380", VA = "0x188601D80", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool VAZDZMRSDXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1014B40", Offset = "0x1013140", VA = "0x181014B40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8601D50", Offset = "0x8600350", VA = "0x188601D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> EXUPCMEPHGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x85FD730", Offset = "0x85FBD30", VA = "0x1885FD730", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8601CA0", Offset = "0x86002A0", VA = "0x188601CA0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> PVQSHXBGUBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x86002A0", Offset = "0x85FE8A0", VA = "0x1886002A0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8601E20", Offset = "0x8600420", VA = "0x188601E20", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8601F10", Offset = "0x8600510", VA = "0x188601F10")]
		public HQPIUDOPWQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85FD430", Offset = "0x85FBA30", VA = "0x1885FD430")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85FFFA0", Offset = "0x85FE5A0", VA = "0x1885FFFA0")]
		private void LYCBKAXQRJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8600240", Offset = "0x85FE840", VA = "0x188600240")]
		private void NTNISIQNIWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85FDE50", Offset = "0x85FC450", VA = "0x1885FDE50")]
		public bool EYHVMJXQPTD(LRIABUPBGVB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86001C0", Offset = "0x85FE7C0", VA = "0x1886001C0")]
		public bool MPDBVJHEZXE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85FCC50", Offset = "0x85FB250", VA = "0x1885FCC50")]
		public void BJQCLZYYLLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85FFEE0", Offset = "0x85FE4E0", VA = "0x1885FFEE0")]
		public void LXSGIRJQLSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85FF2B0", Offset = "0x85FD8B0", VA = "0x1885FF2B0")]
		public void JQQZCDDFVPK(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE7B0", Offset = "0x85FCDB0", VA = "0x1885FE7B0")]
		public void HMXABJOURQA(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85FCCA0", Offset = "0x85FB2A0", VA = "0x1885FCCA0")]
		public void CFNECTYJAQJ(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85FF6A0", Offset = "0x85FDCA0", VA = "0x1885FF6A0")]
		public void KYZOGDONURM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85FD8D0", Offset = "0x85FBED0", VA = "0x1885FD8D0")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85FD240", Offset = "0x85FB840", VA = "0x1885FD240")]
		public int CZGRFBDRIQI(KMNYUBYLMOF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8601130", Offset = "0x85FF730", VA = "0x188601130")]
		public bool RaiseEvent(byte eventCode, object eventContent, KAUBEGREKJA raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8600810", Offset = "0x85FEE10", VA = "0x188600810")]
		public bool PJGOPJVAVGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85FEA40", Offset = "0x85FD040", VA = "0x1885FEA40")]
		internal bool HUHJUHLGOYW([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85FEC60", Offset = "0x85FD260", VA = "0x1885FEC60")]
		internal bool HXBEDREJPII([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85FDF70", Offset = "0x85FC570", VA = "0x1885FDF70")]
		private void FCBILDZKFSL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86001B0", Offset = "0x85FE7B0", VA = "0x1886001B0")]
		public void LeaveRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85FD9C0", Offset = "0x85FBFC0", VA = "0x1885FD9C0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8600ED0", Offset = "0x85FF4D0", VA = "0x188600ED0")]
		private void QSXDMALQTBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85FDA00", Offset = "0x85FC000", VA = "0x1885FDA00")]
		private void EQNPHMOLRRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85FD7E0", Offset = "0x85FBDE0", VA = "0x1885FD7E0")]
		private void DLNQUIVJHXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85FF930", Offset = "0x85FDF30", VA = "0x1885FF930")]
		private void LHSQCVRWYGI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85FE480", Offset = "0x85FCA80", VA = "0x1885FE480")]
		private void GCZGAKRIHKF(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x38FFDB0", Offset = "0x38FE3B0", VA = "0x1838FFDB0")]
		private void TNFOCNBKUFX<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85FDD20", Offset = "0x85FC320", VA = "0x1885FDD20")]
		private void ESNRMVSWXRS(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85FFDC0", Offset = "0x85FE3C0", VA = "0x1885FFDC0")]
		private void LSWDESTILON(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85FCEA0", Offset = "0x85FB4A0", VA = "0x1885FCEA0")]
		private void CMTMQVVWQNH(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8601710", Offset = "0x85FFD10", VA = "0x188601710")]
		private void UBLTKGZCJVU(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85FE190", Offset = "0x85FC790", VA = "0x1885FE190")]
		private void FRZNQDNEWPA(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85FCED0", Offset = "0x85FB4D0", VA = "0x1885FCED0")]
		private void CVABXAJFWTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8601580", Offset = "0x85FFB80", VA = "0x188601580")]
		private void TZOINISYKFT(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8600350", Offset = "0x85FE950", VA = "0x188600350")]
		private void NVIWLUBFTMH(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8600510", Offset = "0x85FEB10", VA = "0x188600510")]
		private void OIFEFDDQBUH(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85FF580", Offset = "0x85FDB80", VA = "0x1885FF580")]
		private void KKHIGWXGJLV(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85FFC70", Offset = "0x85FE270", VA = "0x1885FFC70")]
		private void LSWDESTILON(UZIJILOAAQH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85FF4A0", Offset = "0x85FDAA0", VA = "0x1885FF4A0")]
		private void JRDFIJZFYSB(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8600DD0", Offset = "0x85FF3D0", VA = "0x188600DD0")]
		private void QCCJPHJLIIX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85FEEC0", Offset = "0x85FD4C0", VA = "0x1885FEEC0")]
		private void IFXEMUFSJGH(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8601F00", Offset = "0x8600500", VA = "0x188601F00")]
		[CompilerGenerated]
		private void ZBGXCAZHVGD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QFWQOWNWAYZ : LRIABUPBGVB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private HQPIUDOPWQG JQGQOQGHDRQ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string VFFMJFAUHPP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> TWHAMMEMUFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int XRXZAJDBRNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string FNSXOATJFYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt RIWAGHKMJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? BIDFDPARLDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string EHXXJLQDOWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong RLVNEOAPNXR;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int NRXDTWIGCHW
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GHXYFBVSUVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xBDF360", Offset = "0xBDD960", VA = "0x180BDF360", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xF38CA0", Offset = "0xF372A0", VA = "0x180F38CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool VRFNBXXULQK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8602660", Offset = "0x8600C60", VA = "0x188602660", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Dictionary<object, object> CXHGTZWHXBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string RAVFTVYUUQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8602570", Offset = "0x8600B70", VA = "0x188602570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int QIWRZRVNPYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8602520", Offset = "0x8600B20", VA = "0x188602520", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8602D30", Offset = "0x8601330", VA = "0x188602D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NKCIMGMHYIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1A25B40", Offset = "0x1A24140", VA = "0x181A25B40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1A25C80", Offset = "0x1A24280", VA = "0x181A25C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool RWPZTQAVWIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x86028D0", Offset = "0x8600ED0", VA = "0x1886028D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string OVLAXNUGIZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x86026F0", Offset = "0x8600CF0", VA = "0x1886026F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string YREETLBDJFY
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8602DA0", Offset = "0x86013A0", VA = "0x188602DA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool APNBPGNEGER
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public object LAGVFAAYBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal ulong RNLEDBHUDJE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB080", VA = "0x180AACA80")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x86028B0", Offset = "0x8600EB0", VA = "0x1886028B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8602F50", Offset = "0x8601550", VA = "0x188602F50")]
		internal QFWQOWNWAYZ(HQPIUDOPWQG a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8602E00", Offset = "0x8601400", VA = "0x188602E00")]
		internal QFWQOWNWAYZ(HQPIUDOPWQG a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8602E40", Offset = "0x8601440", VA = "0x188602E40")]
		internal QFWQOWNWAYZ(HQPIUDOPWQG a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8602990", Offset = "0x8600F90", VA = "0x188602990", Slot = "16")]
		public bool OWXBWCSPYAC(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8602790", Offset = "0x8600D90", VA = "0x188602790")]
		public NetworkedPlayerData HFBIKZHBDAI()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8602A40", Offset = "0x8601040", VA = "0x188602A40")]
		internal void RKFLEYZFDOQ([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DUCPVZHYEHZ : VMUJRLNJPHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HQPIUDOPWQG JQGQOQGHDRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> ALQUWOGSXGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, QFWQOWNWAYZ> AZLUTYVSQPT;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string UDAZODDRFXJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x85FB700", Offset = "0x85F9D00", VA = "0x1885FB700", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public byte FSLGJJKUOVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x85FBD00", Offset = "0x85FA300", VA = "0x1885FBD00", Slot = "5")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool JATBHARDLTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Dictionary<object, object> CXHGTZWHXBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public QFWQOWNWAYZ[] IXUBVMNHWQB
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public QFWQOWNWAYZ[] YRLDKXBTYXC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F10", Offset = "0xAAF510", VA = "0x180AB0F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public QFWQOWNWAYZ[] VHXWNVEXBCA
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public QFWQOWNWAYZ[] EAWCCBXTRUA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int RVPGXIVMFMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xF33300", Offset = "0xF31900", VA = "0x180F33300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1ACCEF0", Offset = "0x1ACB4F0", VA = "0x181ACCEF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85FC400", Offset = "0x85FAA00", VA = "0x1885FC400")]
		public DUCPVZHYEHZ(HQPIUDOPWQG a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85FBD50", Offset = "0x85FA350", VA = "0x1885FBD50", Slot = "9")]
		public bool OBQGWBPTTXL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85FBDB0", Offset = "0x85FA3B0", VA = "0x1885FBDB0", Slot = "8")]
		public bool OWXBWCSPYAC(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85FC250", Offset = "0x85FA850", VA = "0x1885FC250")]
		internal bool ZJHTNGDBKBY([In] NetworkedPlayerData playerData, bool a, [Out] QFWQOWNWAYZ b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85FB730", Offset = "0x85F9D30", VA = "0x1885FB730")]
		internal void EKLCYVSDKLH(ulong a, [Out] QFWQOWNWAYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85FB8C0", Offset = "0x85F9EC0", VA = "0x1885FB8C0")]
		internal void IALTMOWTZUC([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85FBE60", Offset = "0x85FA460", VA = "0x1885FBE60")]
		private void QKPYEZWVDQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AZWKUYUQUBJ : ZIVUGZRFOJL, LRJLKNGLINT, WFDZJXBVAKR, YYJRECEXABT, QEFSHYPRWFN, HICUPWZNCRO, JXTMYJLBPME, GNTZBYSJAKA, HAMVSMTRQPP, GYXQGXDAFKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HQPIUDOPWQG JQGQOQGHDRQ;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int WKQPIRWOUFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x85FA2D0", Offset = "0x85F88D0", VA = "0x1885FA2D0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int NSVJDHNRQKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int IZCIEUZNMTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x85F9D10", Offset = "0x85F8310", VA = "0x1885F9D10", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int EFRFNSNEUAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xE575F0", Offset = "0xE55BF0", VA = "0x180E575F0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool WNXGPUBIYSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xE57840", Offset = "0xE55E40", VA = "0x180E57840", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public double QMXCMFRZYIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x85FB2A0", Offset = "0x85F98A0", VA = "0x1885FB2A0", Slot = "35")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int XAFLDETVPRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x85FA6F0", Offset = "0x85F8CF0", VA = "0x1885FA6F0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool YJMAWCMYMZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x25A0170", Offset = "0x259E770", VA = "0x1825A0170", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool FDXUTTWQDHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x85FA770", Offset = "0x85F8D70", VA = "0x1885FA770", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool AQYNNVJWTED
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x85FA770", Offset = "0x85F8D70", VA = "0x1885FA770", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool GLEAKZSTAQA
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x85FB4E0", Offset = "0x85F9AE0", VA = "0x1885FB4E0", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x85F9CF0", Offset = "0x85F82F0", VA = "0x1885F9CF0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool SZNGBOTGQRT
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x85FB580", Offset = "0x85F9B80", VA = "0x1885FB580", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x85FA020", Offset = "0x85F8620", VA = "0x1885FA020", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public object HCYXBXXAGJK
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB070", VA = "0x180AACA70", Slot = "50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x85FAAD0", Offset = "0x85F90D0", VA = "0x1885FAAD0", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int CEQSIFBJLUW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x85FAAF0", Offset = "0x85F90F0", VA = "0x1885FAAF0", Slot = "74")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int NKGCJSYPLDT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x85FAD10", Offset = "0x85F9310", VA = "0x1885FAD10", Slot = "75")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public LRIABUPBGVB OJYVFBFKHGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x85FAEC0", Offset = "0x85F94C0", VA = "0x1885FAEC0", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x85FA1B0", Offset = "0x85F87B0", VA = "0x1885FA1B0", Slot = "77")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int FSLGJJKUOVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x85FA690", Offset = "0x85F8C90", VA = "0x1885FA690", Slot = "78")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string VFFMJFAUHPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x85F9EA0", Offset = "0x85F84A0", VA = "0x1885F9EA0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Func<string, string> TWHAMMEMUFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x85F9DE0", Offset = "0x85F83E0", VA = "0x1885F9DE0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public LBZZZSNEOUH SGABYGXHOTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x85FB1A0", Offset = "0x85F97A0", VA = "0x1885FB1A0", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool RWMSFILBLUR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x85FB140", Offset = "0x85F9740", VA = "0x1885FB140", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x85F9CD0", Offset = "0x85F82D0", VA = "0x1885F9CD0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override float LNQEKLSZPSF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE7DD70", Offset = "0xE7C370", VA = "0x180E7DD70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xE7DD90", Offset = "0xE7C390", VA = "0x180E7DD90", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override LULDBTLWMMU NAABVCHULKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool VAZDZMRSDXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x85FB4D0", Offset = "0x85F9AD0", VA = "0x1885FB4D0", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x85FB160", Offset = "0x85F9760", VA = "0x1885FB160", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string DPCDTBVKSAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x85FADB0", Offset = "0x85F93B0", VA = "0x1885FADB0", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public long JUEMVLWLMBS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x85F9DA0", Offset = "0x85F83A0", VA = "0x1885F9DA0", Slot = "93")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public long GYAGCJOQOFV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x85FA660", Offset = "0x85F8C60", VA = "0x1885FA660", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<LULDBTLWMMU, LULDBTLWMMU> QUKBVYNYZRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x85FB1F0", Offset = "0x85F97F0", VA = "0x1885FB1F0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x85FA500", Offset = "0x85F8B00", VA = "0x1885FA500", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<KMNYUBYLMOF> JADLUJHYKBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x85FAA20", Offset = "0x85F9020", VA = "0x1885FAA20", Slot = "68")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x85FB300", Offset = "0x85F9900", VA = "0x1885FB300", Slot = "69")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LRIABUPBGVB> AOECWXLSHVX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x85FB3B0", Offset = "0x85F99B0", VA = "0x1885FB3B0", Slot = "71")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x85FA5B0", Offset = "0x85F8BB0", VA = "0x1885FA5B0", Slot = "72")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x85FB510", Offset = "0x85F9B10", VA = "0x1885FB510")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void ZOKCDQOPSGU(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x85FB690", Offset = "0x85F9C90", VA = "0x1885FB690")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public AZWKUYUQUBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85FA480", Offset = "0x85F8A80", VA = "0x1885FA480", Slot = "21")]
		public void JQQZCDDFVPK(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85F9D60", Offset = "0x85F8360", VA = "0x1885F9D60", Slot = "23")]
		public void CFNECTYJAQJ(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85FABD0", Offset = "0x85F91D0", VA = "0x1885FABD0", Slot = "27")]
		public void QDCEVCMUVNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x85FB100", Offset = "0x85F9700", VA = "0x1885FB100", Slot = "56")]
		public bool TOQCODXOKCT(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x85F9FB0", Offset = "0x85F85B0", VA = "0x1885F9FB0", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x85F9FE0", Offset = "0x85F85E0", VA = "0x1885F9FE0", Slot = "55")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x85FA330", Offset = "0x85F8930", VA = "0x1885FA330", Slot = "22")]
		public void HMXABJOURQA(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x85FAFF0", Offset = "0x85F95F0", VA = "0x1885FAFF0", Slot = "83")]
		public LRIABUPBGVB SFXJGGUGRGT(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85F9E30", Offset = "0x85F8430", VA = "0x1885F9E30", Slot = "82")]
		public LRIABUPBGVB DNCAMOEVDPX(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85FA810", Offset = "0x85F8E10", VA = "0x1885FA810", Slot = "84")]
		public LRIABUPBGVB NFVPIIQPSWR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x85FA4A0", Offset = "0x85F8AA0", VA = "0x1885FA4A0", Slot = "18")]
		public bool KFKCHGZLITT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85FA3E0", Offset = "0x85F89E0", VA = "0x1885FA3E0", Slot = "85")]
		public IReadOnlyList<LRIABUPBGVB> JHFUMHTVXIR(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x85FAF60", Offset = "0x85F9560", VA = "0x1885FAF60", Slot = "86")]
		public IReadOnlyList<LRIABUPBGVB> SCHANGSOPCC(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85FAB50", Offset = "0x85F9150", VA = "0x1885FAB50", Slot = "54")]
		public bool PJGOPJVAVGC(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x85FA7D0", Offset = "0x85F8DD0", VA = "0x1885FA7D0", Slot = "53")]
		public bool LeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85FB5C0", Offset = "0x85F9BC0", VA = "0x1885FB5C0", Slot = "20")]
		public void ZZUUNNXCDTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x85FAF30", Offset = "0x85F9530", VA = "0x1885FAF30", Slot = "70")]
		public bool RaiseEvent(byte eventCode, object eventContent, KAUBEGREKJA raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x85FA670", Offset = "0x85F8C70", VA = "0x1885FA670", Slot = "28")]
		public void KYZOGDONURM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85F9DB0", Offset = "0x85F83B0", VA = "0x1885F9DB0", Slot = "30")]
		public int CZGRFBDRIQI(KMNYUBYLMOF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "45")]
		public void ENVEPPLLZCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85FA070", Offset = "0x85F8670", VA = "0x1885FA070", Slot = "87")]
		public bool EYHVMJXQPTD(LRIABUPBGVB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "34")]
		public void WBZLUGCPMXF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x85FB460", Offset = "0x85F9A60", VA = "0x1885FB460", Slot = "17")]
		public float YMZRYPUBVMK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85FA380", Offset = "0x85F8980", VA = "0x1885FA380", Slot = "8")]
		public override void JBQIZXOFPVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x85FA910", Offset = "0x85F8F10", VA = "0x1885FA910", Slot = "81")]
		public void OIWJOOSVADD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x85FA2D0", Offset = "0x85F88D0", VA = "0x1885FA2D0", Slot = "95")]
		public int MLWORJOZBWE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x85FA190", Offset = "0x85F8790", VA = "0x1885FA190", Slot = "11")]
		private void FGYFAVGMIYS(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x85FA010", Offset = "0x85F8610", VA = "0x1885FA010", Slot = "12")]
		private void ECZLFDSIAMH(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x85FA1A0", Offset = "0x85F87A0", VA = "0x1885FA1A0", Slot = "25")]
		private void GXRIVSRPKQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x85FA360", Offset = "0x85F8960", VA = "0x1885FA360", Slot = "26")]
		private void ILCMJEOJOGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x85FA350", Offset = "0x85F8950", VA = "0x1885FA350", Slot = "31")]
		private void HXPWSNZOYYV(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x85FB0E0", Offset = "0x85F96E0", VA = "0x1885FB0E0", Slot = "32")]
		private void SIBDACVIIFO(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85F9D50", Offset = "0x85F8350", VA = "0x1885F9D50", Slot = "57")]
		private void BVIAWYMOTQH(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x85FB500", Offset = "0x85F9B00", VA = "0x1885FB500", Slot = "58")]
		private void ZDWBPOOEKLG(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x85F9FA0", Offset = "0x85F85A0", VA = "0x1885F9FA0", Slot = "59")]
		private void DVSSIWRHYXG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x85FB0F0", Offset = "0x85F96F0", VA = "0x1885FB0F0", Slot = "60")]
		private void SLOAVLIFLJF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x85F9CC0", Offset = "0x85F82C0", VA = "0x1885F9CC0", Slot = "61")]
		private void AQLACYZPGST(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85F9D90", Offset = "0x85F8390", VA = "0x1885F9D90", Slot = "62")]
		private IDisposable CNZCWNIKLII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x85FB130", Offset = "0x85F9730", VA = "0x1885FB130", Slot = "63")]
		private bool VRNWVOECNGT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x85FA470", Offset = "0x85F8A70", VA = "0x1885FA470", Slot = "64")]
		private void JNFIVOYUVYH(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85FB120", Offset = "0x85F9720", VA = "0x1885FB120", Slot = "66")]
		private void UCVLXQQHGHN(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85FA370", Offset = "0x85F8970", VA = "0x1885FA370", Slot = "67")]
		private void JAKRABWKSSS(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x85FB150", Offset = "0x85F9750", VA = "0x1885FB150", Slot = "88")]
		private void WNTBJOVSFQR(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x85FA800", Offset = "0x85F8E00", VA = "0x1885FA800", Slot = "89")]
		private void MFCPZHCJEOU(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x85F9DD0", Offset = "0x85F83D0", VA = "0x1885F9DD0", Slot = "90")]
		private void DDIXVIRCPWU()
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
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NfgoCommsNetwork nfgoCommsNetwork;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NfgoCommsNetwork SGAOQJBUQCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85FC590", Offset = "0x85FAB90", VA = "0x1885FC590")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x85FC750", Offset = "0x85FAD50", VA = "0x1885FC750")]
		private void ISYQGMYACWC(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public DissonanceNetworkManagerInjector()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NetworkManagerBinder : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private NetworkManager networkManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private NetworkManager secondaryNetworkManager;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8602430", Offset = "0x8600A30", VA = "0x188602430")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class NSHKRTZITJO
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool VIDVPFGOSSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAFA810", Offset = "0xAF8E10", VA = "0x180AFA810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBE49C0", Offset = "0xBE2FC0", VA = "0x180BE49C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NetworkManager HJNQUYLYIGR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NetworkManager UVPKWJYXIJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA8690", Offset = "0xAA6C90", VA = "0x180AA8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public INetworkManager GFNGWOYSBAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NetworkManager, bool> ISYQGMYACWC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8602130", Offset = "0x8600730", VA = "0x188602130")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8602250", Offset = "0x8600850", VA = "0x188602250")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8602370", Offset = "0x8600970", VA = "0x188602370")]
		[RecRoom.NoEngine.Common.Preserve]
		public NSHKRTZITJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86021E0", Offset = "0x86007E0", VA = "0x1886021E0")]
		[ZOKCDQOPSGU.Root]
		public static void RJWPHGKABXJ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8602300", Offset = "0x8600900", VA = "0x188602300")]
		public void VMVCMPPSUGR(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GFNGWOYSBAK : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float WQAJBVLWULQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private CustomMessagingManager.HandleNamedMessageDelegate XYRKFWEWMXH;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F20", Offset = "0xAAF520", VA = "0x180AB0F20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F00", Offset = "0xAAF500", VA = "0x180AB0F00", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x85FC890", Offset = "0x85FAE90", VA = "0x1885FC890", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x85FC9E0", Offset = "0x85FAFE0", VA = "0x1885FC9E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x85FC940", Offset = "0x85FAF40", VA = "0x1885FC940", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x85FCA90", Offset = "0x85FB090", VA = "0x1885FCA90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x85FC7A0", Offset = "0x85FADA0", VA = "0x1885FC7A0", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x85FC7A0", Offset = "0x85FADA0", VA = "0x1885FC7A0", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x85FC820", Offset = "0x85FAE20", VA = "0x1885FC820")]
		public GFNGWOYSBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x85FC7C0", Offset = "0x85FADC0", VA = "0x1885FC7C0", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x85FC7E0", Offset = "0x85FADE0", VA = "0x1885FC7E0", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x85FC800", Offset = "0x85FAE00", VA = "0x1885FC800", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "21")]
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
