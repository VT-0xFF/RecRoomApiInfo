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
		[Cpp2IlInjected.Address(RVA = "0x9961230", Offset = "0x995FC30", VA = "0x189961230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class VLBQZEBHUAA : FDSUQUMMUMO, LAQPZZGTZPU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class EWALVMKTDYB : FAOJZRJMKFV
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte GZEYCUKYEKX
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xD2C460", Offset = "0xD2AE60", VA = "0x180D2C460", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xDE7AB0", Offset = "0xDE64B0", VA = "0x180DE7AB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int YNXBKDDXBMX
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xDF2300", Offset = "0xDF0D00", VA = "0x180DF2300")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object TKRVWOJUNNX
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x91A0510", Offset = "0x919EF10", VA = "0x1891A0510")]
			public EWALVMKTDYB(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9957D90", Offset = "0x9956790", VA = "0x189957D90", Slot = "7")]
			public bool RRJZBUUOGPY(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState UQLUKZCCKER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch BZANPAUKNBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int EXUDNXNEYTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<EWALVMKTDYB> JBKGBZJJFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> WIXRCUGLAYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private KYPFTKSJCUH HZUUYDOJLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ZSJCBYBIFXD OZCIMGGDBVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool MLHSKLPFTLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool JAAHLPFIQUL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager POSIHHFXNVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport OQTEHKQSGQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x995D040", Offset = "0x995BA40", VA = "0x18995D040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState PCBIWBRHLBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x995D520", Offset = "0x995BF20", VA = "0x18995D520", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x995C6D0", Offset = "0x995B0D0", VA = "0x18995C6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HAGQTDWDBJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCDD3A0", Offset = "0xCDBDA0", VA = "0x180CDD3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public KYPFTKSJCUH AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ZSJCBYBIFXD YFAIFNTMAUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private BWXREESIIMX ISGPONXYZFL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool GZHULXBNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x995F3F0", Offset = "0x995DDF0", VA = "0x18995F3F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YZBDSWHUIIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x995BCD0", Offset = "0x995A6D0", VA = "0x18995BCD0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool OFGSALPZLFD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x995BCD0", Offset = "0x995A6D0", VA = "0x18995BCD0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool VHNJIAREFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD7B870", Offset = "0xD7A270", VA = "0x180D7B870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x995DEF0", Offset = "0x995C8F0", VA = "0x18995DEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception WGDPVIISGCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD7510", Offset = "0xCD5F10", VA = "0x180CD7510", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int IZLFUDHHKCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool AHIZGOXUUBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x995F1B0", Offset = "0x995DBB0", VA = "0x18995F1B0", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x995FC80", Offset = "0x995E680", VA = "0x18995FC80", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool WODXRQUKXKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E20", Offset = "0xCD5820", VA = "0x180CD6E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C70", Offset = "0xCD5670", VA = "0x180CD6C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double WIMGRXCFESD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x995E010", Offset = "0x995CA10", VA = "0x18995E010")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double YGWEKQRAJUM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x995C680", Offset = "0x995B080", VA = "0x18995C680")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int FQPVNFOJQVK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x995DB80", Offset = "0x995C580", VA = "0x18995DB80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string CVPCHQUQPWX
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x995FB80", Offset = "0x995E580", VA = "0x18995FB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int OYQTBSHSKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x995FB20", Offset = "0x995E520", VA = "0x18995FB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public QBVKJZPJHHT XAJMBAEMFZF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x995D730", Offset = "0x995C130", VA = "0x18995D730", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool JSLCVACGUML
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF97C10", Offset = "0xF96610", VA = "0x180F97C10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x995F420", Offset = "0x995DE20", VA = "0x18995F420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> YCKRRQXISAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x995E2F0", Offset = "0x995CCF0", VA = "0x18995E2F0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x995C700", Offset = "0x995B100", VA = "0x18995C700", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> TOXVSJESZUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x995EE50", Offset = "0x995D850", VA = "0x18995EE50", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x995D150", Offset = "0x995BB50", VA = "0x18995D150", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x995FE70", Offset = "0x995E870", VA = "0x18995FE70")]
		public VLBQZEBHUAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x995BD20", Offset = "0x995A720", VA = "0x18995BD20")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x995A810", Offset = "0x9959210", VA = "0x18995A810")]
		private void ALXZFLPTMCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x995CDF0", Offset = "0x995B7F0", VA = "0x18995CDF0")]
		private void EWMHCMBAPYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x995ACA0", Offset = "0x99596A0", VA = "0x18995ACA0")]
		public bool AUODXOGMGTN(PPTCRKDFMWF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x995F450", Offset = "0x995DE50", VA = "0x18995F450")]
		public bool XQPARPXFEFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x995ED00", Offset = "0x995D700", VA = "0x18995ED00")]
		public void TIASKNIYHTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x995D460", Offset = "0x995BE60", VA = "0x18995D460")]
		public void HYCRJQQBPMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x995D540", Offset = "0x995BF40", VA = "0x18995D540")]
		public void IPYZCDVYBNA(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x995E060", Offset = "0x995CA60", VA = "0x18995E060")]
		public void OXSDDWRMIMS(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x995CE50", Offset = "0x995B850", VA = "0x18995CE50")]
		public void FNZNHWYKNFV(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x995AEA0", Offset = "0x99598A0", VA = "0x18995AEA0")]
		public void BGVSXQNQAUM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x995C340", Offset = "0x995AD40", VA = "0x18995C340")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x995F200", Offset = "0x995DC00", VA = "0x18995F200")]
		public int WUHZDOUCNNU(FAOJZRJMKFV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x995B130", Offset = "0x9959B30", VA = "0x18995B130")]
		public bool BTXCCJZIXMC(byte a, object b, GTCQSIYUTCU c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x995B590", Offset = "0x9959F90", VA = "0x18995B590")]
		public bool CFAFPROIIVO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x995EAE0", Offset = "0x995D4E0", VA = "0x18995EAE0")]
		internal bool SDMEDMZQOOM([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x995D200", Offset = "0x995BC00", VA = "0x18995D200")]
		internal bool HVNGXYHGSYO([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x995E910", Offset = "0x995D310", VA = "0x18995E910")]
		private void RZIUXYPQBFD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x995C430", Offset = "0x995AE30", VA = "0x18995C430")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x995C530", Offset = "0x995AF30", VA = "0x18995C530", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x995E590", Offset = "0x995CF90", VA = "0x18995E590")]
		private void PLIBZYZHNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x995C020", Offset = "0x995AA20", VA = "0x18995C020")]
		private void DDKSLABHLBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x995E6F0", Offset = "0x995D0F0", VA = "0x18995E6F0")]
		private void PTNJXAVJOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x995DBD0", Offset = "0x995C5D0", VA = "0x18995DBD0")]
		private void NBNMNGTNKNI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x995BA40", Offset = "0x995A440", VA = "0x18995BA40")]
		private void CHNNICVWAML(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x40C19A0", Offset = "0x40C03A0", VA = "0x1840C19A0")]
		private void XKBFNCHCUOT<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x995E7E0", Offset = "0x995D1E0", VA = "0x18995E7E0")]
		private void RTLKFMQJPHE(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x995AB80", Offset = "0x9959580", VA = "0x18995AB80")]
		private void AMMRFURNOGL(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x995E560", Offset = "0x995CF60", VA = "0x18995E560")]
		private void PKGMXCJOKWT(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x995C8D0", Offset = "0x995B2D0", VA = "0x18995C8D0")]
		private void ENBCMKASROI(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x995F4B0", Offset = "0x995DEB0", VA = "0x18995F4B0")]
		private void YAIPBCMLCWA(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x995F7B0", Offset = "0x995E1B0", VA = "0x18995F7B0")]
		private void YNWJPXFZZDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x995FCE0", Offset = "0x995E6E0", VA = "0x18995FCE0")]
		private void ZQGYVPRDNIL(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x995E3A0", Offset = "0x995CDA0", VA = "0x18995E3A0")]
		private void PJSTFQGEBDX(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x995EF00", Offset = "0x995D900", VA = "0x18995EF00")]
		private void VHERLNWNQXL(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x995C7B0", Offset = "0x995B1B0", VA = "0x18995C7B0")]
		private void EJPYIJNDZCJ(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x995AA30", Offset = "0x9959430", VA = "0x18995AA30")]
		private void AMMRFURNOGL(EWALVMKTDYB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x995ADC0", Offset = "0x99597C0", VA = "0x18995ADC0")]
		private void AVMMNLIEWFR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x995ED50", Offset = "0x995D750", VA = "0x18995ED50")]
		private void TVAYSZVAFLX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x995D780", Offset = "0x995C180", VA = "0x18995D780")]
		private void LSSWMXOWDSF(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x995F4A0", Offset = "0x995DEA0", VA = "0x18995F4A0")]
		[CompilerGenerated]
		private void XVFZRJBHLON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class KYPFTKSJCUH : PPTCRKDFMWF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private VLBQZEBHUAA OCPVGSAVYSQ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string IBQDEZGEQNF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> DTVYCLFXDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int UUIUALAQGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string UHQOEJDDADV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt NHSLVZQZBSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? MVLGRZNFTKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string PEIIPWMDSHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong BBBCSDVWBBD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int BIGKSEQAVFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD9B30", Offset = "0xCD8530", VA = "0x180CD9B30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool HXNGJXGEHGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xE728E0", Offset = "0xE712E0", VA = "0x180E728E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xEC8620", Offset = "0xEC7020", VA = "0x180EC8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool TVVUNUTOXSY
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9958160", Offset = "0x9956B60", VA = "0x189958160", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> HGKBEBVMQPO
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string VQFJVMJOAZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9957DD0", Offset = "0x99567D0", VA = "0x189957DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int NFAPYOPSVWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9958660", Offset = "0x9957060", VA = "0x189958660", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x99581F0", Offset = "0x9956BF0", VA = "0x1899581F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool HASQHBMFHMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x19C4A60", Offset = "0x19C3460", VA = "0x1819C4A60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x19C4A70", Offset = "0x19C3470", VA = "0x1819C4A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IKSNIKEJZQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9957EC0", Offset = "0x99568C0", VA = "0x189957EC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string IJYFIGSCPYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9957FA0", Offset = "0x99569A0", VA = "0x189957FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string NOMIWXFDQXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9958550", Offset = "0x9956F50", VA = "0x189958550", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool RYTLTGEEZWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object IIKPIFPQKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DF0", Offset = "0xCD57F0", VA = "0x180CD6DF0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong YZNTRXWKLQE
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C10", Offset = "0xCD5610", VA = "0x180CD6C10")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9957F80", Offset = "0x9956980", VA = "0x189957F80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99587C0", Offset = "0x99571C0", VA = "0x1899587C0")]
		internal KYPFTKSJCUH(VLBQZEBHUAA a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9958800", Offset = "0x9957200", VA = "0x189958800")]
		internal KYPFTKSJCUH(VLBQZEBHUAA a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99586B0", Offset = "0x99570B0", VA = "0x1899586B0")]
		internal KYPFTKSJCUH(VLBQZEBHUAA a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x99585B0", Offset = "0x9956FB0", VA = "0x1899585B0", Slot = "16")]
		public bool RAJYJUXABEA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9958040", Offset = "0x9956A40", VA = "0x189958040")]
		public NetworkedPlayerData JOHRSIKZURY()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9958260", Offset = "0x9956C60", VA = "0x189958260")]
		internal void OUUOFNMOHFY([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class ZSJCBYBIFXD : BWXREESIIMX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private VLBQZEBHUAA OCPVGSAVYSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> GYVMUMAOBWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, KYPFTKSJCUH> LSYZPSBZAQT;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte FQZBROFXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9960D90", Offset = "0x995F790", VA = "0x189960D90", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool TFXOHEFFLAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> HGKBEBVMQPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public KYPFTKSJCUH[] KBCJKDWTXQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCDF4B0", Offset = "0xCDDEB0", VA = "0x180CDF4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public KYPFTKSJCUH[] QLGLYZKWKFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E40", Offset = "0xCD5840", VA = "0x180CD6E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public KYPFTKSJCUH[] PCDKYBKHPZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DD0", Offset = "0xCD57D0", VA = "0x180CD6DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public KYPFTKSJCUH[] NDMXLOQUCRE
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int QAHWPTMMLZA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEB4070", Offset = "0xEB2A70", VA = "0x180EB4070")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1A98950", Offset = "0x1A97350", VA = "0x181A98950")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x99610A0", Offset = "0x995FAA0", VA = "0x1899610A0")]
		public ZSJCBYBIFXD(VLBQZEBHUAA a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9960E90", Offset = "0x995F890", VA = "0x189960E90", Slot = "8")]
		public bool ZKATTJGGQZF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9960DE0", Offset = "0x995F7E0", VA = "0x189960DE0", Slot = "7")]
		public bool RAJYJUXABEA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9960EF0", Offset = "0x995F8F0", VA = "0x189960EF0")]
		internal bool ZVCKFQWNWJW([In] NetworkedPlayerData playerData, bool a, [Out] KYPFTKSJCUH b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9960BF0", Offset = "0x995F5F0", VA = "0x189960BF0")]
		internal void INVDHXVYOGH(ulong a, [Out] KYPFTKSJCUH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99607B0", Offset = "0x995F1B0", VA = "0x1899607B0")]
		internal void GOFIGDIKIDW([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9960390", Offset = "0x995ED90", VA = "0x189960390")]
		private void CVMJJQEYWJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class TYHIRWCKVMF : WHRTNBUCYMX, DSNQEDELGVB, CXOVPBLSJYL, YUABFMVJCRV, KBBDKRIIPGB, AUQPMHCPDCK, ZGWRFJPMSKC, LAQPZZGTZPU, IUDNOJYFVFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private VLBQZEBHUAA OCPVGSAVYSQ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int FQPVNFOJQVK
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9959830", Offset = "0x9958230", VA = "0x189959830", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int TZAVINYGDOH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int KTVAAPJWICD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x99599D0", Offset = "0x99583D0", VA = "0x1899599D0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int HAGQTDWDBJP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x995A480", Offset = "0x9958E80", VA = "0x18995A480", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PDCJVBTMVON
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xDE9ED0", Offset = "0xDE88D0", VA = "0x180DE9ED0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double WIMGRXCFESD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9959CC0", Offset = "0x99586C0", VA = "0x189959CC0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int UOLXBGAQJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x99597A0", Offset = "0x99581A0", VA = "0x1899597A0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool OFGSALPZLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9959950", Offset = "0x9958350", VA = "0x189959950", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool VHNJIAREFGW
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x99598C0", Offset = "0x99582C0", VA = "0x1899598C0", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9959AE0", Offset = "0x99584E0", VA = "0x189959AE0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool QETTEXJWWNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9959D60", Offset = "0x9958760", VA = "0x189959D60", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool GZHULXBNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x995A2D0", Offset = "0x9958CD0", VA = "0x18995A2D0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public PPTCRKDFMWF AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x99598E0", Offset = "0x99582E0", VA = "0x1899598E0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int FRYCLNKVMBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9959DA0", Offset = "0x99587A0", VA = "0x189959DA0", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int HJBIHEVOMZR
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9959A40", Offset = "0x9958440", VA = "0x189959A40", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public PPTCRKDFMWF FCZGBNMTFVD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9958DF0", Offset = "0x99577F0", VA = "0x189958DF0", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x99594F0", Offset = "0x9957EF0", VA = "0x1899594F0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int FQZBROFXIRE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9959EB0", Offset = "0x99588B0", VA = "0x189959EB0", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string IBQDEZGEQNF
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9958F30", Offset = "0x9957930", VA = "0x189958F30", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> DTVYCLFXDDO
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x995A4D0", Offset = "0x9958ED0", VA = "0x18995A4D0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public QBVKJZPJHHT XAJMBAEMFZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9959900", Offset = "0x9958300", VA = "0x189959900", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool WODXRQUKXKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x995A1F0", Offset = "0x9958BF0", VA = "0x18995A1F0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x99599B0", Offset = "0x99583B0", VA = "0x1899599B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float FNGEIEZWPQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12B5620", Offset = "0x12B4020", VA = "0x1812B5620", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A85840", Offset = "0x1A84240", VA = "0x181A85840", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override FDSUQUMMUMO FXMBMGUIXFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCDAC20", Offset = "0xCD9620", VA = "0x180CDAC20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool JSLCVACGUML
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x995A1D0", Offset = "0x9958BD0", VA = "0x18995A1D0", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x995A320", Offset = "0x9958D20", VA = "0x18995A320", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string CVPCHQUQPWX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x995A530", Offset = "0x9958F30", VA = "0x18995A530", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long XQLZUWJMVOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9959890", Offset = "0x9958290", VA = "0x189959890", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long GPBTWIIPGFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9959F40", Offset = "0x9958940", VA = "0x189959F40", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<FAOJZRJMKFV> TTQAFSLACHG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x995A200", Offset = "0x9958C00", VA = "0x18995A200", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9959E00", Offset = "0x9958800", VA = "0x189959E00", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<PPTCRKDFMWF> SZGGPUJJABF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x995A070", Offset = "0x9958A70", VA = "0x18995A070", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9958E80", Offset = "0x9957880", VA = "0x189958E80", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9959040", Offset = "0x9957A40", VA = "0x189959040")]
		[BQDQKYYGTTM.Root.GameOnly]
		internal static void BQDQKYYGTTM(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x995A640", Offset = "0x9959040", VA = "0x18995A640")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public TYHIRWCKVMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x99598A0", Offset = "0x99582A0", VA = "0x1899598A0", Slot = "21")]
		public void IPYZCDVYBNA(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9959770", Offset = "0x9958170", VA = "0x189959770", Slot = "23")]
		public void FNZNHWYKNFV(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9959B00", Offset = "0x9958500", VA = "0x189959B00", Slot = "27")]
		public void NMDSSYPLZCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x995A4A0", Offset = "0x9958EA0", VA = "0x18995A4A0", Slot = "47")]
		public bool XYWVMYGJSQV(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x99593C0", Offset = "0x9957DC0", VA = "0x1899593C0", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x99593F0", Offset = "0x9957DF0", VA = "0x1899593F0", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9959D30", Offset = "0x9958730", VA = "0x189959D30", Slot = "22")]
		public void OXSDDWRMIMS(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x99590E0", Offset = "0x9957AE0", VA = "0x1899590E0", Slot = "75")]
		public PPTCRKDFMWF BWKOWLCGPSV(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x995A000", Offset = "0x9958A00", VA = "0x18995A000", Slot = "74")]
		public PPTCRKDFMWF UDHMAQVFXMH(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9959250", Offset = "0x9957C50", VA = "0x189959250", Slot = "76")]
		public PPTCRKDFMWF CLAFOMMVCZV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9959C40", Offset = "0x9958640", VA = "0x189959C40", Slot = "18")]
		public bool NPHQCDBYTAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x995A140", Offset = "0x9958B40", VA = "0x18995A140", Slot = "77")]
		public IReadOnlyList<PPTCRKDFMWF> VHBHPFAGCPV(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9959F50", Offset = "0x9958950", VA = "0x189959F50", Slot = "78")]
		public IReadOnlyList<PPTCRKDFMWF> SLELIROGWLO(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x99591D0", Offset = "0x9957BD0", VA = "0x1899591D0", Slot = "45")]
		public bool CFAFPROIIVO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x99596A0", Offset = "0x99580A0", VA = "0x1899596A0", Slot = "20")]
		public void FIIMCLDHOAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x99590B0", Offset = "0x9957AB0", VA = "0x1899590B0", Slot = "62")]
		public bool BTXCCJZIXMC(byte a, object b, GTCQSIYUTCU c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9958E60", Offset = "0x9957860", VA = "0x189958E60", Slot = "28")]
		public void BGVSXQNQAUM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x995A2B0", Offset = "0x9958CB0", VA = "0x18995A2B0", Slot = "30")]
		public int WUHZDOUCNNU(FAOJZRJMKFV a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9958CC0", Offset = "0x99576C0", VA = "0x189958CC0", Slot = "79")]
		public bool AUODXOGMGTN(PPTCRKDFMWF a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9959630", Offset = "0x9958030", VA = "0x189959630", Slot = "17")]
		public float EOXQRWFESLK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9959360", Offset = "0x9957D60", VA = "0x189959360", Slot = "8")]
		public override void CYCBSYPTWUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x995A360", Offset = "0x9958D60", VA = "0x18995A360", Slot = "73")]
		public void XAIXXKWZTRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9959830", Offset = "0x9958230", VA = "0x189959830", Slot = "87")]
		public int IFBQVVAAVCC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x995A120", Offset = "0x9958B20", VA = "0x18995A120", Slot = "11")]
		private void UMNGUMEXWRC(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9959CB0", Offset = "0x99586B0", VA = "0x189959CB0", Slot = "12")]
		private void NXGTGMZDEIZ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9959620", Offset = "0x9958020", VA = "0x189959620", Slot = "25")]
		private void EKCOSKYEBHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x995A1E0", Offset = "0x9958BE0", VA = "0x18995A1E0", Slot = "26")]
		private void VNGPVIPTHCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9959F30", Offset = "0x9958930", VA = "0x189959F30", Slot = "31")]
		private void RIGNCLKQZHJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9958DE0", Offset = "0x99577E0", VA = "0x189958DE0", Slot = "32")]
		private void BAKZARFDXAG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9959350", Offset = "0x9957D50", VA = "0x189959350", Slot = "48")]
		private void CQTVVMYEJIB(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9959D50", Offset = "0x9958750", VA = "0x189959D50", Slot = "49")]
		private void PBXQCJZKHZI(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x995A4C0", Offset = "0x9958EC0", VA = "0x18995A4C0", Slot = "50")]
		private void XZXYKGDATBY(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9959D20", Offset = "0x9958720", VA = "0x189959D20", Slot = "51")]
		private void ODIAGRVVEEZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9959FE0", Offset = "0x99589E0", VA = "0x189959FE0", Slot = "52")]
		private void SVZVQUPTSSR(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9959610", Offset = "0x9958010", VA = "0x189959610", Slot = "53")]
		private IDisposable EJNXYJBEUQS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9959CA0", Offset = "0x99586A0", VA = "0x189959CA0", Slot = "54")]
		private bool NPXUGWTURDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9959820", Offset = "0x9958220", VA = "0x189959820", Slot = "55")]
		private void GYPYQGPCTBH(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x995A130", Offset = "0x9958B30", VA = "0x18995A130", Slot = "57")]
		private void USXKEIVEFIJ(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9959F10", Offset = "0x9958910", VA = "0x189959F10", Slot = "58")]
		private void QVEHIPKZENW(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9959FF0", Offset = "0x99589F0", VA = "0x189959FF0", Slot = "80")]
		private void TBXLRQWCRDF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x995A470", Offset = "0x9958E70", VA = "0x18995A470", Slot = "81")]
		private void XMTXTKDACFI(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9959F20", Offset = "0x9958920", VA = "0x189959F20", Slot = "82")]
		private void QYKDYIGISUS()
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
		public NfgoCommsNetwork JXYWXBIOMTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9957A10", Offset = "0x9956410", VA = "0x189957A10")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9957C20", Offset = "0x9956620", VA = "0x189957C20")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9957BD0", Offset = "0x99565D0", VA = "0x189957BD0")]
		private void HMHTXFJHUGM(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
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
		[Cpp2IlInjected.Address(RVA = "0x9958840", Offset = "0x9957240", VA = "0x189958840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCD6180", Offset = "0xCD4B80", VA = "0x180CD6180")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YWSSVEULXGK
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool JXAULVHERXX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD2C460", Offset = "0xD2AE60", VA = "0x180D2C460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xDE7AB0", Offset = "0xDE64B0", VA = "0x180DE7AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager POSIHHFXNVN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCD8610", Offset = "0xCD7010", VA = "0x180CD8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager EOMZYSYHROF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CE0", Offset = "0xCD56E0", VA = "0x180CD6CE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD8620", Offset = "0xCD7020", VA = "0x180CD8620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager OCKMXOSBQUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> HMHTXFJHUGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9960170", Offset = "0x995EB70", VA = "0x189960170")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9960220", Offset = "0x995EC20", VA = "0x189960220")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x99602D0", Offset = "0x995ECD0", VA = "0x1899602D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public YWSSVEULXGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9960100", Offset = "0x995EB00", VA = "0x189960100")]
		[BQDQKYYGTTM.Root]
		public static void OTSGYGZNYUV(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9960090", Offset = "0x995EA90", VA = "0x189960090")]
		public void OKNBIQLJVNV(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class OCKMXOSBQUI : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float ZZQICKNFYKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate ZDQBIDOPEED;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xD42AE0", Offset = "0xD414E0", VA = "0x180D42AE0", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C40", Offset = "0xCD5640", VA = "0x180CD6C40", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9958A20", Offset = "0x9957420", VA = "0x189958A20", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9958B70", Offset = "0x9957570", VA = "0x189958B70", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9958AD0", Offset = "0x99574D0", VA = "0x189958AD0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9958C20", Offset = "0x9957620", VA = "0x189958C20", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9958930", Offset = "0x9957330", VA = "0x189958930", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9958930", Offset = "0x9957330", VA = "0x189958930", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xCD61A0", Offset = "0xCD4BA0", VA = "0x180CD61A0", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x99589B0", Offset = "0x99573B0", VA = "0x1899589B0")]
		public OCKMXOSBQUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9958950", Offset = "0x9957350", VA = "0x189958950", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9958970", Offset = "0x9957370", VA = "0x189958970", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9958990", Offset = "0x9957390", VA = "0x189958990", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "21")]
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
