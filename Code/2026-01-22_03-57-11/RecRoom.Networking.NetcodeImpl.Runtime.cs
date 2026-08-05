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
		[Cpp2IlInjected.Address(RVA = "0x83F5D70", Offset = "0x83F4570", VA = "0x1883F5D70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B9F0", VA = "0x18275D1F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MTCEBUWVUOH : MAWHZFSGVAP, NBRYZCDYXRH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class RHKEBRJCJGE : TZRHNFDOAHO
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte VXKHLOPOGZQ
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xB857D0", Offset = "0xB83FD0", VA = "0x180B857D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int CPHXQYQZLUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DB10", VA = "0x180B5F310")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object PBWQZEMQYZW
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C72A30", Offset = "0x7C71230", VA = "0x187C72A30")]
			public RHKEBRJCJGE(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x83F34C0", Offset = "0x83F1CC0", VA = "0x1883F34C0", Slot = "7")]
			public bool LHRMMYTLGSF(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState UCFHKWCAVPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch WCFJPNMXWHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int VVBVVSTOXNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<RHKEBRJCJGE> HNJJLYVJSTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> UUXJNYSQQMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private WJUKMVFZGVG HCOFWMLZIQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private OMYGEXPHVLI AOPWASMOZBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool MGLJUAMKKSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool WARFYHPDKDE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager RIPEXVPAXTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport EBOESVUYCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x83ED6F0", Offset = "0x83EBEF0", VA = "0x1883ED6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState YCUWUPDKQUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x83EDB00", Offset = "0x83EC300", VA = "0x1883EDB00", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x83F0C30", Offset = "0x83EF430", VA = "0x1883F0C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MYGBQYXTIWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAB1F10", Offset = "0xAB0710", VA = "0x180AB1F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public WJUKMVFZGVG QTQDYPPCQEL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OMYGEXPHVLI GNOWVBVSYDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private TMTPKRTSWNA HCSSHFTIEBA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool JJAXACDEXPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x83F1990", Offset = "0x83F0190", VA = "0x1883F1990", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool FDPCVURNBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x83ECF40", Offset = "0x83EB740", VA = "0x1883ECF40", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool RXOATIRNKMC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x83ECF40", Offset = "0x83EB740", VA = "0x1883ECF40", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool WUQNCLUJMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB40C20", Offset = "0xB3F420", VA = "0x180B40C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83F0590", Offset = "0x83EED90", VA = "0x1883F0590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception CVIDMLEUHYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAB32A0", Offset = "0xAB1AA0", VA = "0x180AB32A0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IUGUFWDSBWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool UOTEORFGLWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83F2300", Offset = "0x83F0B00", VA = "0x1883F2300", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83F1A10", Offset = "0x83F0210", VA = "0x1883F1A10", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool LDTVAYEWKZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAB4110", Offset = "0xAB2910", VA = "0x180AB4110")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAB4150", Offset = "0xAB2950", VA = "0x180AB4150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double SNQZVXRVFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x83F1EC0", Offset = "0x83F06C0", VA = "0x1883F1EC0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double KLUFBGUALVT
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83F19C0", Offset = "0x83F01C0", VA = "0x1883F19C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int KDNLELRDVAL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x83EF440", Offset = "0x83EDC40", VA = "0x1883EF440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string MDGDSCIYQKU
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x83F08A0", Offset = "0x83EF0A0", VA = "0x1883F08A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int WOAZIFIJNQD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x83F1B70", Offset = "0x83F0370", VA = "0x1883F1B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IUZJXZPQTPC PFHHYDRQATA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x83EF490", Offset = "0x83EDC90", VA = "0x1883EF490", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool BAFEEAIWCEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD25550", Offset = "0xD23D50", VA = "0x180D25550")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x83EF410", Offset = "0x83EDC10", VA = "0x1883EF410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> AZWQGZAZKXY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x83ECE90", Offset = "0x83EB690", VA = "0x1883ECE90", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x83EF360", Offset = "0x83EDB60", VA = "0x1883EF360", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> DBIMQSBTTQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x83ECFE0", Offset = "0x83EB7E0", VA = "0x1883ECFE0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x83EE190", Offset = "0x83EC990", VA = "0x1883EE190", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83F2350", Offset = "0x83F0B50", VA = "0x1883F2350")]
		public MTCEBUWVUOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83ED800", Offset = "0x83EC000", VA = "0x1883ED800")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83F11A0", Offset = "0x83EF9A0", VA = "0x1883F11A0")]
		private void TOYFPRURZSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83F13B0", Offset = "0x83EFBB0", VA = "0x1883F13B0")]
		private void UMPTCBZBWOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83EFAF0", Offset = "0x83EE2F0", VA = "0x1883EFAF0")]
		public bool OAPWSGQJWXK(MNBQIABPYXS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83EE840", Offset = "0x83ED040", VA = "0x1883EE840")]
		public bool HXGQEPLUKEZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83ECF90", Offset = "0x83EB790", VA = "0x1883ECF90")]
		public void BRKOGWOWPBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83F04D0", Offset = "0x83EECD0", VA = "0x1883F04D0")]
		public void QRQHBZTCEVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83F06B0", Offset = "0x83EEEB0", VA = "0x1883F06B0")]
		public void RPKMUHNBTAH(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83F0E20", Offset = "0x83EF620", VA = "0x1883F0E20")]
		public void TDOYGAVGWGN(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83EE890", Offset = "0x83ED090", VA = "0x1883EE890")]
		public void IHAKCBSCHNG(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83F1700", Offset = "0x83EFF00", VA = "0x1883F1700")]
		public void VOPQGDPBGDJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83EDB20", Offset = "0x83EC320", VA = "0x1883EDB20")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83EFC10", Offset = "0x83EE410", VA = "0x1883EFC10")]
		public int PEAKUQXNCHZ(TZRHNFDOAHO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83EEA90", Offset = "0x83ED290", VA = "0x1883EEA90")]
		public bool JUFIERDKBIL(byte a, object b, JFVSBLTWLJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83EE240", Offset = "0x83ECA40", VA = "0x1883EE240")]
		public bool GRESAKXAIWZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83EF140", Offset = "0x83ED940", VA = "0x1883EF140")]
		internal bool KXHQMNKQEYJ([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83EEEE0", Offset = "0x83ED6E0", VA = "0x1883EEEE0")]
		internal bool JVJMSXHJVWD([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83EF920", Offset = "0x83EE120", VA = "0x1883EF920")]
		private void NSTWDSJZEOI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83EDC10", Offset = "0x83EC410", VA = "0x1883EDC10")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83EDD10", Offset = "0x83EC510", VA = "0x1883EDD10")]
		private void FHPNKBDKTKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83F1BA0", Offset = "0x83F03A0", VA = "0x1883F1BA0")]
		private void XLTKIRHSOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83F10B0", Offset = "0x83EF8B0", VA = "0x1883F10B0")]
		private void TLVFZMVZUNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83EDE70", Offset = "0x83EC670", VA = "0x1883EDE70")]
		private void FVWPNBFTIEP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83F09A0", Offset = "0x83EF1A0", VA = "0x1883F09A0")]
		private void RTUCPITTMDS(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37DD830", Offset = "0x37DC030", VA = "0x1837DD830")]
		private void CCRCRCUNUYI<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83ED5C0", Offset = "0x83EBDC0", VA = "0x1883ED5C0")]
		private void COECAXVUHLP(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83F03B0", Offset = "0x83EEBB0", VA = "0x1883F03B0")]
		private void QFEFWSTSZMO(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83EE810", Offset = "0x83ED010", VA = "0x1883EE810")]
		private void HBVABWZJKUK(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83ED090", Offset = "0x83EB890", VA = "0x1883ED090")]
		private void CJFILLYVCAP(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83F1410", Offset = "0x83EFC10", VA = "0x1883F1410")]
		private void UZXXWVXPGWJ(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83EFEF0", Offset = "0x83EE6F0", VA = "0x1883EFEF0")]
		private void QAXKOJZBDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83EF790", Offset = "0x83EDF90", VA = "0x1883EF790")]
		private void NKQVNOFAODI(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83F0C60", Offset = "0x83EF460", VA = "0x1883F0C60")]
		private void SERFXTKLAJS(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83EF4E0", Offset = "0x83EDCE0", VA = "0x1883EF4E0")]
		private void MYNWAOBHUGQ(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83EE6F0", Offset = "0x83ECEF0", VA = "0x1883EE6F0")]
		private void GXZNGELVWUE(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83F0260", Offset = "0x83EEA60", VA = "0x1883F0260")]
		private void QFEFWSTSZMO(RHKEBRJCJGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83EFE00", Offset = "0x83EE600", VA = "0x1883EFE00")]
		private void PNNHQDFZLVU(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83F1A70", Offset = "0x83F0270", VA = "0x1883F1A70")]
		private void WXWOSFTURSM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83F1F10", Offset = "0x83F0710", VA = "0x1883F1F10")]
		private void ZDHYIXGBTZK(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83EFEE0", Offset = "0x83EE6E0", VA = "0x1883EFEE0")]
		[CompilerGenerated]
		private void PQZXIIEBOPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class WJUKMVFZGVG : MNBQIABPYXS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private MTCEBUWVUOH TOCHYSJWWTV;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string OSWOJTCUOUU;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> QBYZQKLGRAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DRZPPOGUHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string FTESNCPRMOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt CWNSQUGUJOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? XPZFHQBLNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string IOVRPKGIVTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong EFTRSUHSTRQ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int XUKWTZFUNUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool WTTGUEUXEWK
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xC2B730", Offset = "0xC29F30", VA = "0x180C2B730", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xC2B2F0", Offset = "0xC29AF0", VA = "0x180C2B2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NWBFVNJKRLT
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83F38D0", Offset = "0x83F20D0", VA = "0x1883F38D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> VTTVAXMVWIN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string JWLCDGPUAXF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x83F3A50", Offset = "0x83F2250", VA = "0x1883F3A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int YKUVNXIZUME
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x83F3960", Offset = "0x83F2160", VA = "0x1883F3960", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x83F3E50", Offset = "0x83F2650", VA = "0x1883F3E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool KIRKTUFXGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x17455B0", Offset = "0x1743DB0", VA = "0x1817455B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x17457E0", Offset = "0x1743FE0", VA = "0x1817457E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool WJHWMQNAMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83F3C60", Offset = "0x83F2460", VA = "0x1883F3C60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string VUATFIVNVLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x83F39B0", Offset = "0x83F21B0", VA = "0x1883F39B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string IQTJRAMOGJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83F3D40", Offset = "0x83F2540", VA = "0x1883F3D40", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CLWCNEXSCWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object BBFSYXLFUTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAB3290", Offset = "0xAB1A90", VA = "0x180AB3290", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong TYJUTZPVZFD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x83F3D20", Offset = "0x83F2520", VA = "0x1883F3D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83F4010", Offset = "0x83F2810", VA = "0x1883F4010")]
		internal WJUKMVFZGVG(MTCEBUWVUOH a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83F3EC0", Offset = "0x83F26C0", VA = "0x1883F3EC0")]
		internal WJUKMVFZGVG(MTCEBUWVUOH a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83F3F00", Offset = "0x83F2700", VA = "0x1883F3F00")]
		internal WJUKMVFZGVG(MTCEBUWVUOH a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83F3DA0", Offset = "0x83F25A0", VA = "0x1883F3DA0", Slot = "16")]
		public bool TIMPTTSWSMP(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83F3B40", Offset = "0x83F2340", VA = "0x1883F3B40")]
		public NetworkedPlayerData MVLLBRJTUFH()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83F35E0", Offset = "0x83F1DE0", VA = "0x1883F35E0")]
		internal void CKYUHYVOTTP([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OMYGEXPHVLI : TMTPKRTSWNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MTCEBUWVUOH TOCHYSJWWTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> HDPCVXFYDZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, WJUKMVFZGVG> EZPKPTNOMHA;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte DERTQEUKAJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83F2AB0", Offset = "0x83F12B0", VA = "0x1883F2AB0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool QHMCCIWEFBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xC19AA0", Offset = "0xC182A0", VA = "0x180C19AA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> VTTVAXMVWIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public WJUKMVFZGVG[] CQFXDYXKYIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public WJUKMVFZGVG[] UUVNFGNBRKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB2B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public WJUKMVFZGVG[] MZOHZODRCQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAACAD0", Offset = "0xAAB2D0", VA = "0x180AACAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public WJUKMVFZGVG[] FZFRUQMAKIX
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int WRYCQOELBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xC16C90", Offset = "0xC15490", VA = "0x180C16C90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1808920", Offset = "0x1807120", VA = "0x181808920")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83F3330", Offset = "0x83F1B30", VA = "0x1883F3330")]
		public OMYGEXPHVLI(MTCEBUWVUOH a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83F2660", Offset = "0x83F0E60", VA = "0x1883F2660", Slot = "8")]
		public bool BOGBZOQKERS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83F30D0", Offset = "0x83F18D0", VA = "0x1883F30D0", Slot = "7")]
		public bool TIMPTTSWSMP(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83F3180", Offset = "0x83F1980", VA = "0x1883F3180")]
		internal bool ZCACKEUCUPV([In] NetworkedPlayerData playerData, bool a, [Out] WJUKMVFZGVG b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83F2B00", Offset = "0x83F1300", VA = "0x1883F2B00")]
		internal void PZUPKFWUFQC(ulong a, [Out] WJUKMVFZGVG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83F2C90", Offset = "0x83F1490", VA = "0x1883F2C90")]
		internal void RCLJPJCNXWL([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83F26C0", Offset = "0x83F0EC0", VA = "0x1883F26C0")]
		private void HZKHTKLCUHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class XVTVVNNDLAY : AZKYQODOSFQ, GIDVIXDVHZW, XGOQMYRLYMI, IBUSXBISTXU, OIPNVNKIDVK, PARGVAODMKF, RRULHLFIRDH, NBRYZCDYXRH, OTPKINYDCQI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private MTCEBUWVUOH TOCHYSJWWTV;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int KDNLELRDVAL
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x83F4C50", Offset = "0x83F3450", VA = "0x1883F4C50", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int DGYPTPOPNJS
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int GRGZCYSJZAI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x83F4C10", Offset = "0x83F3410", VA = "0x1883F4C10", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int MYGBQYXTIWS
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x83F49D0", Offset = "0x83F31D0", VA = "0x1883F49D0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ACIXLODIUAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB5F070", Offset = "0xB5D870", VA = "0x180B5F070", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double SNQZVXRVFHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x83F57F0", Offset = "0x83F3FF0", VA = "0x1883F57F0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ZZPJWOKLUZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x83F4910", Offset = "0x83F3110", VA = "0x1883F4910", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool RXOATIRNKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x83F53D0", Offset = "0x83F3BD0", VA = "0x1883F53D0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool WUQNCLUJMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x83F5050", Offset = "0x83F3850", VA = "0x1883F5050", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x83F5240", Offset = "0x83F3A40", VA = "0x1883F5240", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool TWOXRIMIRTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x83F5390", Offset = "0x83F3B90", VA = "0x1883F5390", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JJAXACDEXPZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x83F56E0", Offset = "0x83F3EE0", VA = "0x1883F56E0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public MNBQIABPYXS QTQDYPPCQEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x83F5030", Offset = "0x83F3830", VA = "0x1883F5030", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int LTAJEFTVFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x83F5080", Offset = "0x83F3880", VA = "0x1883F5080", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int HDIUILZNGRO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x83F47E0", Offset = "0x83F2FE0", VA = "0x1883F47E0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public MNBQIABPYXS JQWQXHCSCMU
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x83F4A60", Offset = "0x83F3260", VA = "0x1883F4A60", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x83F5120", Offset = "0x83F3920", VA = "0x1883F5120", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int DERTQEUKAJX
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x83F4E80", Offset = "0x83F3680", VA = "0x1883F4E80", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string OSWOJTCUOUU
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x83F5870", Offset = "0x83F4070", VA = "0x1883F5870", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> QBYZQKLGRAL
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x83F40E0", Offset = "0x83F28E0", VA = "0x1883F40E0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public IUZJXZPQTPC PFHHYDRQATA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x83F4DC0", Offset = "0x83F35C0", VA = "0x1883F4DC0", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool LDTVAYEWKZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x83F4900", Offset = "0x83F3100", VA = "0x1883F4900", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x83F55D0", Offset = "0x83F3DD0", VA = "0x1883F55D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float HQNDGMRLYBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x102F170", Offset = "0x102D970", VA = "0x18102F170", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x17F7490", Offset = "0x17F5C90", VA = "0x1817F7490", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override MAWHZFSGVAP ILYBKPKQJHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAB3270", Offset = "0xAB1A70", VA = "0x180AB3270", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool BAFEEAIWCEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x83F4DA0", Offset = "0x83F35A0", VA = "0x1883F4DA0", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x83F4BD0", Offset = "0x83F33D0", VA = "0x1883F4BD0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string MDGDSCIYQKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x83F5280", Offset = "0x83F3A80", VA = "0x1883F5280", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long QBLQIFDXPRH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x83F4990", Offset = "0x83F3190", VA = "0x1883F4990", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long XSWTUHKYISM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x83F5100", Offset = "0x83F3900", VA = "0x1883F5100", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<TZRHNFDOAHO> PXOGPXPZKCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x83F5740", Offset = "0x83F3F40", VA = "0x1883F5740", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x83F5600", Offset = "0x83F3E00", VA = "0x1883F5600", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<MNBQIABPYXS> IPPANTXFKZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x83F4730", Offset = "0x83F2F30", VA = "0x1883F4730", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x83F42F0", Offset = "0x83F2AF0", VA = "0x1883F42F0", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83F5430", Offset = "0x83F3C30", VA = "0x1883F5430")]
		[SLGIUIECCXF.Root.GameOnly]
		internal static void SLGIUIECCXF(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83F5980", Offset = "0x83F4180", VA = "0x1883F5980")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public XVTVVNNDLAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83F5260", Offset = "0x83F3A60", VA = "0x1883F5260", Slot = "21")]
		public void RPKMUHNBTAH(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83F49A0", Offset = "0x83F31A0", VA = "0x1883F49A0", Slot = "23")]
		public void IHAKCBSCHNG(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83F43A0", Offset = "0x83F2BA0", VA = "0x1883F43A0", Slot = "27")]
		public void EBBIGFIXXBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83F4B60", Offset = "0x83F3360", VA = "0x1883F4B60", Slot = "47")]
		public bool JHSKUCSGXTS(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83F41C0", Offset = "0x83F29C0", VA = "0x1883F41C0", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83F41F0", Offset = "0x83F29F0", VA = "0x1883F41F0", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x83F55B0", Offset = "0x83F3DB0", VA = "0x1883F55B0", Slot = "22")]
		public void TDOYGAVGWGN(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x83F4CB0", Offset = "0x83F34B0", VA = "0x1883F4CB0", Slot = "75")]
		public MNBQIABPYXS LTKKPDBWUAO(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x83F4150", Offset = "0x83F2950", VA = "0x1883F4150", Slot = "74")]
		public MNBQIABPYXS DNCBCMCMERG(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x83F54B0", Offset = "0x83F3CB0", VA = "0x1883F54B0", Slot = "76")]
		public MNBQIABPYXS SSWMEFDYLAQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83F49F0", Offset = "0x83F31F0", VA = "0x1883F49F0", Slot = "18")]
		public bool IRLQPMXILIE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83F4AD0", Offset = "0x83F32D0", VA = "0x1883F4AD0", Slot = "77")]
		public IReadOnlyList<MNBQIABPYXS> JCCBSMAEIHS(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83F4050", Offset = "0x83F2850", VA = "0x1883F4050", Slot = "78")]
		public IReadOnlyList<MNBQIABPYXS> AYONRPZRHYX(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83F4880", Offset = "0x83F3080", VA = "0x1883F4880", Slot = "45")]
		public bool GRESAKXAIWZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x83F44E0", Offset = "0x83F2CE0", VA = "0x1883F44E0", Slot = "20")]
		public void EBUVYVNRNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83F4B80", Offset = "0x83F3380", VA = "0x1883F4B80", Slot = "62")]
		public bool JUFIERDKBIL(byte a, object b, JFVSBLTWLJF c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83F56B0", Offset = "0x83F3EB0", VA = "0x1883F56B0", Slot = "28")]
		public void VOPQGDPBGDJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x83F5010", Offset = "0x83F3810", VA = "0x1883F5010", Slot = "30")]
		public int PEAKUQXNCHZ(TZRHNFDOAHO a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83F4EE0", Offset = "0x83F36E0", VA = "0x1883F4EE0", Slot = "79")]
		public bool OAPWSGQJWXK(MNBQIABPYXS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83F4E10", Offset = "0x83F3610", VA = "0x1883F4E10", Slot = "17")]
		public float MRUBOQBUEBD(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83F45C0", Offset = "0x83F2DC0", VA = "0x1883F45C0", Slot = "8")]
		public override void EPLNHXZGDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83F4620", Offset = "0x83F2E20", VA = "0x1883F4620", Slot = "73")]
		public void EQEFYTZJIGG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83F4C50", Offset = "0x83F3450", VA = "0x1883F4C50", Slot = "87")]
		public int RPNUICCKAJP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83F54A0", Offset = "0x83F3CA0", VA = "0x1883F54A0", Slot = "11")]
		private void SOAFKROSBPF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x83F5070", Offset = "0x83F3870", VA = "0x1883F5070", Slot = "12")]
		private void PIRLMCAPRPK(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83F50E0", Offset = "0x83F38E0", VA = "0x1883F50E0", Slot = "25")]
		private void QGFMEODWHGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x83F4BB0", Offset = "0x83F33B0", VA = "0x1883F4BB0", Slot = "26")]
		private void JYNLNZBNMHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83F5110", Offset = "0x83F3910", VA = "0x1883F5110", Slot = "31")]
		private void RCYWKTWALII(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83F4A50", Offset = "0x83F3250", VA = "0x1883F4A50", Slot = "32")]
		private void IZSCMUZXWKP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83F4DB0", Offset = "0x83F35B0", VA = "0x1883F4DB0", Slot = "48")]
		private void MHDEGNPFKJI(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x83F5860", Offset = "0x83F4060", VA = "0x1883F5860", Slot = "49")]
		private void YQLVRQHGSQX(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83F4BC0", Offset = "0x83F33C0", VA = "0x1883F4BC0", Slot = "50")]
		private void KILSOVJWLED(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83F5850", Offset = "0x83F4050", VA = "0x1883F5850", Slot = "51")]
		private void YPMTJQBMDHS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83F55F0", Offset = "0x83F3DF0", VA = "0x1883F55F0", Slot = "52")]
		private void USTYBLSDRLE(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x83F5000", Offset = "0x83F3800", VA = "0x1883F5000", Slot = "53")]
		private IDisposable OFGDLGHLLBD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83F56D0", Offset = "0x83F3ED0", VA = "0x1883F56D0", Slot = "54")]
		private bool VVZSKXYSJWY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83F5970", Offset = "0x83F4170", VA = "0x1883F5970", Slot = "55")]
		private void ZQZFHPRGUCE(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83F4130", Offset = "0x83F2930", VA = "0x1883F4130", Slot = "57")]
		private void DDZAOPBXINC(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83F5730", Offset = "0x83F3F30", VA = "0x1883F5730", Slot = "58")]
		private void WNBBKDQWNPV(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83F4140", Offset = "0x83F2940", VA = "0x1883F4140", Slot = "80")]
		private void DMMLEUEOKSW(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83F45B0", Offset = "0x83F2DB0", VA = "0x1883F45B0", Slot = "81")]
		private void EECCRQPDJSJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83F50F0", Offset = "0x83F38F0", VA = "0x1883F50F0", Slot = "82")]
		private void QKOVILFRUOP()
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
		public NfgoCommsNetwork DWNWNIGNYOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83EC8F0", Offset = "0x83EB0F0", VA = "0x1883EC8F0")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x83ECAB0", Offset = "0x83EB2B0", VA = "0x1883ECAB0")]
		private void VWWKYVPZZTF(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83F2570", Offset = "0x83F0D70", VA = "0x1883F2570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YIJPYTGHUQX
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool GXLNYVOIQPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB857D0", Offset = "0xB83FD0", VA = "0x180B857D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager RIPEXVPAXTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager NXEBXNHNGJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager IKUHBFMXLFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> VWWKYVPZZTF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x83F5B90", Offset = "0x83F4390", VA = "0x1883F5B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x83F5A70", Offset = "0x83F4270", VA = "0x1883F5A70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x83F5CB0", Offset = "0x83F44B0", VA = "0x1883F5CB0")]
		[RecRoom.NoEngine.Common.Preserve]
		public YIJPYTGHUQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83F5C40", Offset = "0x83F4440", VA = "0x1883F5C40")]
		[SLGIUIECCXF.Root]
		public static void VTNXFZRZGFS(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83F5B20", Offset = "0x83F4320", VA = "0x1883F5B20")]
		public void RGDDBZMRUDS(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class IKUHBFMXLFJ : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float KPLZWQGHKUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate OYAGKTBMXNS;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB290", VA = "0x180AACA90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAACB00", Offset = "0xAAB300", VA = "0x180AACB00", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x83ECBF0", Offset = "0x83EB3F0", VA = "0x1883ECBF0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x83ECD40", Offset = "0x83EB540", VA = "0x1883ECD40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x83ECCA0", Offset = "0x83EB4A0", VA = "0x1883ECCA0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x83ECDF0", Offset = "0x83EB5F0", VA = "0x1883ECDF0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83ECB00", Offset = "0x83EB300", VA = "0x1883ECB00", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83ECB00", Offset = "0x83EB300", VA = "0x1883ECB00", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x83ECB80", Offset = "0x83EB380", VA = "0x1883ECB80")]
		public IKUHBFMXLFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x83ECB20", Offset = "0x83EB320", VA = "0x1883ECB20", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x83ECB40", Offset = "0x83EB340", VA = "0x1883ECB40", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x83ECB60", Offset = "0x83EB360", VA = "0x1883ECB60", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "21")]
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
