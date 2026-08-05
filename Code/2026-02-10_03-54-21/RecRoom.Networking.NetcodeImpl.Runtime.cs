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
		[Cpp2IlInjected.Address(RVA = "0x85276F0", Offset = "0x85268F0", VA = "0x1885276F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class OJARDMHSIRQ : AUYEDWZYXUE, EHXMXFWKWZG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class UNJRGGRBMLV : QVRCDNFGMQF
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte LYZGIQDGMIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xB0C710", Offset = "0xB0B910", VA = "0x180B0C710", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xBBFE90", Offset = "0xBBF090", VA = "0x180BBFE90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int KXODMYZKDVX
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xB82A80", Offset = "0xB81C80", VA = "0x180B82A80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xB82B50", Offset = "0xB81D50", VA = "0x180B82B50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object HKKESJZASNF
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xABA470", Offset = "0xAB9670", VA = "0x180ABA470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D8FCA0", Offset = "0x7D8EEA0", VA = "0x187D8FCA0")]
			public UNJRGGRBMLV(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x85273B0", Offset = "0x85265B0", VA = "0x1885273B0", Slot = "7")]
			public bool GDGJFTLPVBG(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState OOACEFLMVML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch HORIUQKYKOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int QHUYXAIUTNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<UNJRGGRBMLV> JALGIVOOVFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> UACHIZUMNLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private UBYKJXNLAFD WOKRWNLMBWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private SNNGMLFFZUH OHVHQNZEVLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool EEFHBRTTRCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool YCATQCUNOCF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager IMPRJVNLJVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport OWANFGEXRUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8522800", Offset = "0x8521A00", VA = "0x188522800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState HJOLEZEACUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8524D20", Offset = "0x8523F20", VA = "0x188524D20", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85207E0", Offset = "0x851F9E0", VA = "0x1885207E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int KYSJFLMOZGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xABBC10", Offset = "0xABAE10", VA = "0x180ABBC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public UBYKJXNLAFD KWHQLHEEHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public SNNGMLFFZUH GJMYCKTJNSW
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private TSGUKOIFCBT ZILZOEUSXFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool EBMDIHEHQPW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8522770", Offset = "0x8521970", VA = "0x188522770", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool JRPLAXVORIX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8523B00", Offset = "0x8522D00", VA = "0x188523B00", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool WJUBLSTZTWL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8523B00", Offset = "0x8522D00", VA = "0x188523B00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CIWOUSIJXFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB3BBA0", Offset = "0xB3ADA0", VA = "0x180B3BBA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85239E0", Offset = "0x8522BE0", VA = "0x1885239E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception XZNSOPVQECZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xABCB70", Offset = "0xABBD70", VA = "0x180ABCB70", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xABC980", Offset = "0xABBB80", VA = "0x180ABC980", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int GKRTXATCIFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool FRSLLUWKBTP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8520810", Offset = "0x851FA10", VA = "0x188520810", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8525280", Offset = "0x8524480", VA = "0x188525280", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MVDGEOMSBSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAC49F0", Offset = "0xAC3BF0", VA = "0x180AC49F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAC4940", Offset = "0xAC3B40", VA = "0x180AC4940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double QRFLHNBEWRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8525400", Offset = "0x8524600", VA = "0x188525400")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double MSVXHJFDCZE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x851FFF0", Offset = "0x851F1F0", VA = "0x18851FFF0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int MTPGDMQDRFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8523D40", Offset = "0x8522F40", VA = "0x188523D40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string PYOXVPTNFCN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x85206E0", Offset = "0x851F8E0", VA = "0x1885206E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int STQYXLJBZEE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85227A0", Offset = "0x85219A0", VA = "0x1885227A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UYADTWTQRTZ WAEXHSIGTTL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x851FFA0", Offset = "0x851F1A0", VA = "0x18851FFA0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool LEVVYKGXURX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD4EA60", Offset = "0xD4DC60", VA = "0x180D4EA60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85229C0", Offset = "0x8521BC0", VA = "0x1885229C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> OUOILXJSMZD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8522910", Offset = "0x8521B10", VA = "0x188522910", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8521570", Offset = "0x8520770", VA = "0x188521570", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> BUEFSFVUUEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8520860", Offset = "0x851FA60", VA = "0x188520860", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8521840", Offset = "0x8520A40", VA = "0x188521840", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8525450", Offset = "0x8524650", VA = "0x188525450")]
		public OJARDMHSIRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8520910", Offset = "0x851FB10", VA = "0x188520910")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85223D0", Offset = "0x85215D0", VA = "0x1885223D0")]
		private void KTOZSJMROLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8524890", Offset = "0x8523A90", VA = "0x188524890")]
		private void RLNJXUPPCDT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8522FC0", Offset = "0x85221C0", VA = "0x188522FC0")]
		public bool MRZBWQKIAWF(HJIMNRPSBJR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8524D40", Offset = "0x8523F40", VA = "0x188524D40")]
		public bool UWOEKEJFDGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8521AE0", Offset = "0x8520CE0", VA = "0x188521AE0")]
		public void IEGFZMFUDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8524B60", Offset = "0x8523D60", VA = "0x188524B60")]
		public void TAZLLPIVHZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8523B50", Offset = "0x8522D50", VA = "0x188523B50")]
		public void NOJIZSZHIPS(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8523D90", Offset = "0x8522F90", VA = "0x188523D90")]
		public void QCTEDNTLAGU(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8524150", Offset = "0x8523350", VA = "0x188524150")]
		public void QUMNIKHZMIN(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8521B30", Offset = "0x8520D30", VA = "0x188521B30")]
		public void JNXWDCMOQDE(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8521070", Offset = "0x8520270", VA = "0x188521070")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85218F0", Offset = "0x8520AF0", VA = "0x1885218F0")]
		public int HTSMJERMLZW(QVRCDNFGMQF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85230E0", Offset = "0x85222E0", VA = "0x1885230E0")]
		public bool MTJMVGQAXXC(byte a, object b, QWRWUXWOZZA c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8523530", Offset = "0x8522730", VA = "0x188523530")]
		public bool MUNPXEFDEMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8521620", Offset = "0x8520820", VA = "0x188521620")]
		internal bool FPYHBGEVTIG([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85229F0", Offset = "0x8521BF0", VA = "0x1885229F0")]
		internal bool MHMJZWDUGHC([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8520EA0", Offset = "0x85200A0", VA = "0x188520EA0")]
		private void DPPFTHXIHHV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8521160", Offset = "0x8520360", VA = "0x188521160")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8521260", Offset = "0x8520460", VA = "0x188521260")]
		private void EJYOPKHMTVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8524E70", Offset = "0x8524070", VA = "0x188524E70")]
		private void YGQTOVCSFTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8525190", Offset = "0x8524390", VA = "0x188525190")]
		private void YOCVZSDFITO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8521DC0", Offset = "0x8520FC0", VA = "0x188521DC0")]
		private void JZOVZAXROJG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8520C10", Offset = "0x851FE10", VA = "0x188520C10")]
		private void DBTSIUQBFHX(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3924020", Offset = "0x3923220", VA = "0x183924020")]
		private void ILKTDCLAFYJ<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8524020", Offset = "0x8523220", VA = "0x188524020")]
		private void QTPLMLGGYMM(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85248F0", Offset = "0x8523AF0", VA = "0x1885248F0")]
		private void ROBOXFKBJDH(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8524340", Offset = "0x8523540", VA = "0x188524340")]
		private void QXMGWAJLSEN(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8524370", Offset = "0x8523570", VA = "0x188524370")]
		private void RABJQXGLGYG(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85220E0", Offset = "0x85212E0", VA = "0x1885220E0")]
		private void KILPDYLZZHA(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8522C50", Offset = "0x8521E50", VA = "0x188522C50")]
		private void MIRPGJRBJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85225F0", Offset = "0x85217F0", VA = "0x1885225F0")]
		private void LFWTERHSAQR(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85213C0", Offset = "0x85205C0", VA = "0x1885213C0")]
		private void FBPCHGOPNBZ(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8520430", Offset = "0x851F630", VA = "0x188520430")]
		private void BKYXJVSPTDN(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85252E0", Offset = "0x85244E0", VA = "0x1885252E0")]
		private void ZRDEQQVZQGP(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8524A10", Offset = "0x8523C10", VA = "0x188524A10")]
		private void ROBOXFKBJDH(UNJRGGRBMLV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8524D90", Offset = "0x8523F90", VA = "0x188524D90")]
		private void WMDWCTDPZIV(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8524C20", Offset = "0x8523E20", VA = "0x188524C20")]
		private void TCILBEUNZXZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8520040", Offset = "0x851F240", VA = "0x188520040")]
		private void BKIHQSJUYGP(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85225E0", Offset = "0x85217E0", VA = "0x1885225E0")]
		[CompilerGenerated]
		private void LEFBXSRYKMP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class UBYKJXNLAFD : HJIMNRPSBJR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OJARDMHSIRQ MKQWJXOALSC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string WWZUTIZNWKB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> BFMFFZLJPUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int HHBIMUKCDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string AXDIATPNKGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt BSRVDTDYTIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? XXYVYAJKLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string WRQUOKKLFLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong SUXDXMEMYFN;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int NDBTCLMJJGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool ILGWFGJRNRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xC41720", Offset = "0xC40920", VA = "0x180C41720", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC41D30", Offset = "0xC40F30", VA = "0x180C41D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool SREIDMNKVUW
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8526B10", Offset = "0x8525D10", VA = "0x188526B10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> ZZFLDYGBTMS
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string MOBNANQPPFS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8527090", Offset = "0x8526290", VA = "0x188527090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ZSUAZWPNANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8526C00", Offset = "0x8525E00", VA = "0x188526C00", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8527020", Offset = "0x8526220", VA = "0x188527020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool XUVHCKPCAJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x175E690", Offset = "0x175D890", VA = "0x18175E690", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x175E680", Offset = "0x175D880", VA = "0x18175E680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool WMEKIKROBVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8526C50", Offset = "0x8525E50", VA = "0x188526C50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string YPUADLAMLPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8527180", Offset = "0x8526380", VA = "0x188527180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string SGBIATIOCRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8526BA0", Offset = "0x8525DA0", VA = "0x188526BA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool ZIKOBXOFEZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object ZTTFILQAOSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xABC9A0", Offset = "0xABBBA0", VA = "0x180ABC9A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xABC960", Offset = "0xABBB60", VA = "0x180ABC960", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong VMBDHVRRNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xABCB70", Offset = "0xABBD70", VA = "0x180ABCB70")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x8526D10", Offset = "0x8525F10", VA = "0x188526D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8527370", Offset = "0x8526570", VA = "0x188527370")]
		internal UBYKJXNLAFD(OJARDMHSIRQ a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8527330", Offset = "0x8526530", VA = "0x188527330")]
		internal UBYKJXNLAFD(OJARDMHSIRQ a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8527220", Offset = "0x8526420", VA = "0x188527220")]
		internal UBYKJXNLAFD(OJARDMHSIRQ a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8526940", Offset = "0x8525B40", VA = "0x188526940", Slot = "16")]
		public bool HMIOXWORGXA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x85269F0", Offset = "0x8525BF0", VA = "0x1885269F0")]
		public NetworkedPlayerData LIUYXPAPPWQ()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8526D30", Offset = "0x8525F30", VA = "0x188526D30")]
		internal void SVLKKBTBFXC([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class SNNGMLFFZUH : TSGUKOIFCBT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OJARDMHSIRQ MKQWJXOALSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> QPAVTFRDATZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, UBYKJXNLAFD> UJOEYQXJTNP;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte XVJYJUFXPZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8526290", Offset = "0x8525490", VA = "0x188526290", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool EHTQDJALBEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xC56780", Offset = "0xC55980", VA = "0x180C56780", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> ZZFLDYGBTMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public UBYKJXNLAFD[] NLOCHGZSUCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xABA420", Offset = "0xAB9620", VA = "0x180ABA420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public UBYKJXNLAFD[] FEGUEHEMXEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xABEC10", Offset = "0xABDE10", VA = "0x180ABEC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UBYKJXNLAFD[] ULVDAINQKOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAC2AF0", Offset = "0xAC1CF0", VA = "0x180AC2AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xABE640", Offset = "0xABD840", VA = "0x180ABE640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public UBYKJXNLAFD[] KZAOYYNQNVC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int ZFOJALSLAJK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xC45940", Offset = "0xC44B40", VA = "0x180C45940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1841780", Offset = "0x1840980", VA = "0x181841780")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x85266D0", Offset = "0x85258D0", VA = "0x1885266D0")]
		public SNNGMLFFZUH(OJARDMHSIRQ a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8525E40", Offset = "0x8525040", VA = "0x188525E40", Slot = "8")]
		public bool EICPTWSMJSJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8525EA0", Offset = "0x85250A0", VA = "0x188525EA0", Slot = "7")]
		public bool HMIOXWORGXA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85260E0", Offset = "0x85252E0", VA = "0x1885260E0")]
		internal bool RAKUWUFZDIC([In] NetworkedPlayerData playerData, bool a, [Out] UBYKJXNLAFD b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8525F50", Offset = "0x8525150", VA = "0x188525F50")]
		internal void MSLVIATFVGJ(ulong a, [Out] UBYKJXNLAFD b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8525A00", Offset = "0x8524C00", VA = "0x188525A00")]
		internal void AIYUHCHPUFI([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x85262E0", Offset = "0x85254E0", VA = "0x1885262E0")]
		private void XAPMHQRHNFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AZZVYVUQGTZ : WXGMUBHQUFX, JXLRYILWFBT, URSSQVCSNSR, CLHMLDVSGTT, CYCYZBKLEVZ, VVJENVYZJIA, QHVJNOZXWTW, EHXMXFWKWZG, WTTKILXCBAV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private OJARDMHSIRQ MKQWJXOALSC;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int MTPGDMQDRFA
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x851E5A0", Offset = "0x851D7A0", VA = "0x18851E5A0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int VYJUIEUFPMN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int HIEYOAHGMRD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x851F690", Offset = "0x851E890", VA = "0x18851F690", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int KYSJFLMOZGX
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x851E7B0", Offset = "0x851D9B0", VA = "0x18851E7B0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool WEURDMQYHRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB8FB50", Offset = "0xB8ED50", VA = "0x180B8FB50", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double QRFLHNBEWRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x851FAF0", Offset = "0x851ECF0", VA = "0x18851FAF0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int BTHYZDSCHAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x851F9D0", Offset = "0x851EBD0", VA = "0x18851F9D0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool WJUBLSTZTWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x851ED10", Offset = "0x851DF10", VA = "0x18851ED10", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool CIWOUSIJXFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x851F0F0", Offset = "0x851E2F0", VA = "0x18851F0F0", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x851ECF0", Offset = "0x851DEF0", VA = "0x18851ECF0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool CJOJEFCJKSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x851F110", Offset = "0x851E310", VA = "0x18851F110", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool EBMDIHEHQPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x851E920", Offset = "0x851DB20", VA = "0x18851E920", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public HJIMNRPSBJR KWHQLHEEHBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x851F1D0", Offset = "0x851E3D0", VA = "0x18851F1D0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int APKZSPQWAOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x851EF10", Offset = "0x851E110", VA = "0x18851EF10", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int BEDSJIKWVRL
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x851E4E0", Offset = "0x851D6E0", VA = "0x18851E4E0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public HJIMNRPSBJR EUZHPHSIVZF
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x851F160", Offset = "0x851E360", VA = "0x18851F160", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x851EF90", Offset = "0x851E190", VA = "0x18851EF90", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int XVJYJUFXPZK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x851F2C0", Offset = "0x851E4C0", VA = "0x18851F2C0", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string WWZUTIZNWKB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x851F4E0", Offset = "0x851E6E0", VA = "0x18851F4E0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> BFMFFZLJPUK
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x851E760", Offset = "0x851D960", VA = "0x18851E760", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public UYADTWTQRTZ WAEXHSIGTTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x851E250", Offset = "0x851D450", VA = "0x18851E250", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool MVDGEOMSBSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x851E750", Offset = "0x851D950", VA = "0x18851E750", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x851EAF0", Offset = "0x851DCF0", VA = "0x18851EAF0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float TBMTOSDKWTL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x105AA70", Offset = "0x1059C70", VA = "0x18105AA70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1825470", Offset = "0x1824670", VA = "0x181825470", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override AUYEDWZYXUE KEUUCWRLKOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xABC970", Offset = "0xABBB70", VA = "0x180ABC970", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool LEVVYKGXURX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x851E2C0", Offset = "0x851D4C0", VA = "0x18851E2C0", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x851EAA0", Offset = "0x851DCA0", VA = "0x18851EAA0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string PYOXVPTNFCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x851E3C0", Offset = "0x851D5C0", VA = "0x18851E3C0", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long HOXRNYLJWZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x851E2B0", Offset = "0x851D4B0", VA = "0x18851E2B0", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long CWZNNZAOYWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x851E580", Offset = "0x851D780", VA = "0x18851E580", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<QVRCDNFGMQF> CGRIJLTRVGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x851E7F0", Offset = "0x851D9F0", VA = "0x18851E7F0", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x851F5E0", Offset = "0x851E7E0", VA = "0x18851F5E0", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<HJIMNRPSBJR> CMHOQUNWHDX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x851F920", Offset = "0x851EB20", VA = "0x18851F920", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x851F420", Offset = "0x851E620", VA = "0x18851F420", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x851EE20", Offset = "0x851E020", VA = "0x18851EE20")]
		[OCFGNIRMEEE.Root.GameOnly]
		internal static void OCFGNIRMEEE(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x851FBB0", Offset = "0x851EDB0", VA = "0x18851FBB0")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public AZZVYVUQGTZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x851EE00", Offset = "0x851E000", VA = "0x18851EE00", Slot = "21")]
		public void NOJIZSZHIPS(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x851F0B0", Offset = "0x851E2B0", VA = "0x18851F0B0", Slot = "23")]
		public void QUMNIKHZMIN(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x851F770", Offset = "0x851E970", VA = "0x18851F770", Slot = "27")]
		public void WZVOOIMNXHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x851E7D0", Offset = "0x851D9D0", VA = "0x18851E7D0", Slot = "47")]
		public bool HBWPYNUGSWH(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x851E610", Offset = "0x851D810", VA = "0x18851E610", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x851E640", Offset = "0x851D840", VA = "0x18851E640", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x851EF70", Offset = "0x851E170", VA = "0x18851EF70", Slot = "22")]
		public void QCTEDNTLAGU(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x851E2D0", Offset = "0x851D4D0", VA = "0x18851E2D0", Slot = "75")]
		public HJIMNRPSBJR BZLPAQTJHNZ(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x851F8B0", Offset = "0x851EAB0", VA = "0x18851F8B0", Slot = "74")]
		public HJIMNRPSBJR XEDOMBRQBYR(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x851F320", Offset = "0x851E520", VA = "0x18851F320", Slot = "76")]
		public HJIMNRPSBJR TOLRNTJWGLT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x851EEA0", Offset = "0x851E0A0", VA = "0x18851EEA0", Slot = "18")]
		public bool PAPVNPYTOOZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x851FA50", Offset = "0x851EC50", VA = "0x18851FA50", Slot = "77")]
		public IReadOnlyList<HJIMNRPSBJR> YQRMGYUJKUR(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x851ED70", Offset = "0x851DF70", VA = "0x18851ED70", Slot = "78")]
		public IReadOnlyList<HJIMNRPSBJR> NJAQJDXQLLE(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x851EC70", Offset = "0x851DE70", VA = "0x18851EC70", Slot = "45")]
		public bool MUNPXEFDEMO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x851F1F0", Offset = "0x851E3F0", VA = "0x18851F1F0", Slot = "20")]
		public void SVTUOPPXHDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x851EC40", Offset = "0x851DE40", VA = "0x18851EC40", Slot = "62")]
		public bool MTJMVGQAXXC(byte a, object b, QWRWUXWOZZA c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x851E8F0", Offset = "0x851DAF0", VA = "0x18851E8F0", Slot = "28")]
		public void JNXWDCMOQDE(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x851E8B0", Offset = "0x851DAB0", VA = "0x18851E8B0", Slot = "30")]
		public int HTSMJERMLZW(QVRCDNFGMQF a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x851EB10", Offset = "0x851DD10", VA = "0x18851EB10", Slot = "79")]
		public bool MRZBWQKIAWF(HJIMNRPSBJR a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x851F700", Offset = "0x851E900", VA = "0x18851F700", Slot = "17")]
		public float WUGDTZVLESW(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x851FB50", Offset = "0x851ED50", VA = "0x18851FB50", Slot = "8")]
		public override void ZVZZRMWAGLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x851E980", Offset = "0x851DB80", VA = "0x18851E980", Slot = "73")]
		public void MARINIMNRSN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x851E5A0", Offset = "0x851D7A0", VA = "0x18851E5A0", Slot = "87")]
		public int DUQMWMUHGZW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x851F0E0", Offset = "0x851E2E0", VA = "0x18851F0E0", Slot = "11")]
		private void QVOODWKGHPU(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x851E4D0", Offset = "0x851D6D0", VA = "0x18851E4D0", Slot = "12")]
		private void CKVRDFGIQAD(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x851F150", Offset = "0x851E350", VA = "0x18851F150", Slot = "25")]
		private void RTYAIZFLVYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x851F4D0", Offset = "0x851E6D0", VA = "0x18851F4D0", Slot = "26")]
		private void UQBDSEXJAYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x851EAE0", Offset = "0x851DCE0", VA = "0x18851EAE0", Slot = "31")]
		private void MOQCJJCELAF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x851E8A0", Offset = "0x851DAA0", VA = "0x18851E8A0", Slot = "32")]
		private void HDLSDIDBQUE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x851E8D0", Offset = "0x851DAD0", VA = "0x18851E8D0", Slot = "48")]
		private void IVBFUKUCFUD(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x851E8E0", Offset = "0x851DAE0", VA = "0x18851E8E0", Slot = "49")]
		private void JHSBRVCJHCQ(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x851E2A0", Offset = "0x851D4A0", VA = "0x18851E2A0", Slot = "50")]
		private void AVOIHQGCXXW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x851EA90", Offset = "0x851DC90", VA = "0x18851EA90", Slot = "51")]
		private void MCYLUFIXYLB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x851E910", Offset = "0x851DB10", VA = "0x18851E910", Slot = "52")]
		private void LDRLPUIGZWD(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x851E970", Offset = "0x851DB70", VA = "0x18851E970", Slot = "53")]
		private IDisposable LKXMMIMHMKM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x851E740", Offset = "0x851D940", VA = "0x18851E740", Slot = "54")]
		private bool EDHMDHXVMNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x851EE90", Offset = "0x851E090", VA = "0x18851EE90", Slot = "55")]
		private void OEKUWKZXDNJ(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x851EF00", Offset = "0x851E100", VA = "0x18851EF00", Slot = "57")]
		private void PGPHUIEERNZ(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x851E600", Offset = "0x851D800", VA = "0x18851E600", Slot = "58")]
		private void DYLPHRCAHBU(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x851FAE0", Offset = "0x851ECE0", VA = "0x18851FAE0", Slot = "80")]
		private void YUWDBJUNZZT(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x851EC30", Offset = "0x851DE30", VA = "0x18851EC30", Slot = "81")]
		private void MSCXIAXDDMA(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x851E590", Offset = "0x851D790", VA = "0x18851E590", Slot = "82")]
		private void CVODKVJVAVO()
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
		public NfgoCommsNetwork VWAADLDCZQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x851FCA0", Offset = "0x851EEA0", VA = "0x18851FCA0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x851FE60", Offset = "0x851F060", VA = "0x18851FE60")]
		private void RYRNMSONODU(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
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

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x851FEB0", Offset = "0x851F0B0", VA = "0x18851FEB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class XGXWMVAETNC
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool QCQDDWKDSRZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB0C710", Offset = "0xB0B910", VA = "0x180B0C710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xBBFE90", Offset = "0xBBF090", VA = "0x180BBFE90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager IMPRJVNLJVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager MUUQFNHAOWH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xABA480", Offset = "0xAB9680", VA = "0x180ABA480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB8170", Offset = "0xAB7370", VA = "0x180AB8170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager QUOJVDBXJJM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> RYRNMSONODU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x85274D0", Offset = "0x85266D0", VA = "0x1885274D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8527580", Offset = "0x8526780", VA = "0x188527580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8527630", Offset = "0x8526830", VA = "0x188527630")]
		[RecRoom.NoEngine.Common.Preserve]
		public XGXWMVAETNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x85273F0", Offset = "0x85265F0", VA = "0x1885273F0")]
		[OCFGNIRMEEE.Root]
		public static void CGFBIGKNYUP(CYZVJPHMMVM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8527460", Offset = "0x8526660", VA = "0x188527460")]
		public void RJGJDZHSWCV(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class QUOJVDBXJJM : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float VNOMWEMBXGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate KZYDMCGWLTP;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xABE620", Offset = "0xABD820", VA = "0x180ABE620", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xABE600", Offset = "0xABD800", VA = "0x180ABE600", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8525760", Offset = "0x8524960", VA = "0x188525760", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x85258B0", Offset = "0x8524AB0", VA = "0x1885258B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8525810", Offset = "0x8524A10", VA = "0x188525810", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8525960", Offset = "0x8524B60", VA = "0x188525960", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8525670", Offset = "0x8524870", VA = "0x188525670", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8525670", Offset = "0x8524870", VA = "0x188525670", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAB6190", Offset = "0xAB5390", VA = "0x180AB6190", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x85256F0", Offset = "0x85248F0", VA = "0x1885256F0")]
		public QUOJVDBXJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8525690", Offset = "0x8524890", VA = "0x188525690", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x85256B0", Offset = "0x85248B0", VA = "0x1885256B0", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x85256D0", Offset = "0x85248D0", VA = "0x1885256D0", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "21")]
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
