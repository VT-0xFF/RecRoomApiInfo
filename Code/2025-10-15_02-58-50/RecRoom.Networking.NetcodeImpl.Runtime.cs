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
		[Cpp2IlInjected.Address(RVA = "0x857EC60", Offset = "0x857DA60", VA = "0x18857EC60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class RFAJFCMJMHR : RBETLIDWDVR, KKWQOVLPYQB, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HIZSPKGUWRG : PQDMMRYYGHS
		{
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x8575AD0", Offset = "0x85748D0", VA = "0x188575AD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public byte OEZDCDKLODA
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xBF7410", Offset = "0xBF6210", VA = "0x180BF7410")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int NQVZPJSYJEW
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xC1BCE0", Offset = "0xC1AAE0", VA = "0x180C1BCE0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xC1BCF0", Offset = "0xC1AAF0", VA = "0x180C1BCF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public object ASWAUOGFDQQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BC0", Offset = "0xA9F9C0", VA = "0x180AA0BC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7E1EAE0", Offset = "0x7E1D8E0", VA = "0x187E1EAE0")]
			public HIZSPKGUWRG(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8575A90", Offset = "0x8574890", VA = "0x188575A90", Slot = "8")]
			public bool HHYTRHIEAWJ(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState KDJVSBWPKRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch YVJYCCKXRPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int ZKLXICITIUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<HIZSPKGUWRG> OLBRAKJUVZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> LGTGXVGXBZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private ZETDYTQWFNG DVICQENKJJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private UGWNADKAFVY AQHLUREKYPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool TWEXXEDVXHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool WUQFKZEMRNI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager LBNDANTMWHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport TTFBODVKNBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8577800", Offset = "0x8576600", VA = "0x188577800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState RQKQVQYYWSU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x857B180", Offset = "0x8579F80", VA = "0x18857B180", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x857B1D0", Offset = "0x8579FD0", VA = "0x18857B1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PHZTBKPXKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA7120", Offset = "0xAA5F20", VA = "0x180AA7120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ZETDYTQWFNG GABUPFWQSQP
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public UGWNADKAFVY AOUAOBTSYDV
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private ABWHXVJVLPE TBMEQOPEYNU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8579250", Offset = "0x8578050", VA = "0x188579250", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool YZSDVXYZDAS
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8575F50", Offset = "0x8574D50", VA = "0x188575F50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EBZAJFLGPLE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8575F50", Offset = "0x8574D50", VA = "0x188575F50", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UPWIKWEKFBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8575F50", Offset = "0x8574D50", VA = "0x188575F50", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BSHEGRJNMKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB9FA40", Offset = "0xB9E840", VA = "0x180B9FA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x857A090", Offset = "0x8578E90", VA = "0x18857A090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Exception UFINETWLPOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA1950", Offset = "0xAA0750", VA = "0x180AA1950", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAA1990", Offset = "0xAA0790", VA = "0x180AA1990", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int YYOAFZCTOHR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AGZUDIRMHYE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8575F00", Offset = "0x8574D00", VA = "0x188575F00", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8579090", Offset = "0x8577E90", VA = "0x188579090", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NRNTSANFHMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAA20F0", Offset = "0xAA0EF0", VA = "0x180AA20F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAA21F0", Offset = "0xAA0FF0", VA = "0x180AA21F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double ZZXWEPDGXLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x857AA80", Offset = "0x8579880", VA = "0x18857AA80")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double DDTYDTGMELX
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8576310", Offset = "0x8575110", VA = "0x188576310")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DAKOSDDBMSH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x857ACC0", Offset = "0x8579AC0", VA = "0x18857ACC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string FSRDKZBWKGA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x85798F0", Offset = "0x85786F0", VA = "0x1885798F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int NYMVGUJYAOX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8576B10", Offset = "0x8575910", VA = "0x188576B10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public ZPMZXUEDLIU HGXHCIEEHMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x857A1B0", Offset = "0x8578FB0", VA = "0x18857A1B0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool VMCSTYVXSBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x10124B0", Offset = "0x10112B0", VA = "0x1810124B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x857B1A0", Offset = "0x8579FA0", VA = "0x18857B1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> CNAPRNIOBHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8578C00", Offset = "0x8577A00", VA = "0x188578C00", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x857AFB0", Offset = "0x8579DB0", VA = "0x18857AFB0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> UQDIBZWPYZM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x85770E0", Offset = "0x8575EE0", VA = "0x1885770E0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x857A9D0", Offset = "0x85797D0", VA = "0x18857A9D0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x857B250", Offset = "0x857A050", VA = "0x18857B250")]
		public RFAJFCMJMHR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8576810", Offset = "0x8575610", VA = "0x188576810")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8579BD0", Offset = "0x85789D0", VA = "0x188579BD0")]
		private void PJSNYTBJQUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x857A750", Offset = "0x8579550", VA = "0x18857A750")]
		private void SGYIXFZZKRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x857B060", Offset = "0x8579E60", VA = "0x18857B060")]
		public bool XEXQTEGNXOE(LZEYQUPSRUQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8579040", Offset = "0x8577E40", VA = "0x188579040")]
		public bool KMMXJGGVIZT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x857B200", Offset = "0x857A000", VA = "0x18857B200")]
		public void ZNTJPZQCENI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85799F0", Offset = "0x85787F0", VA = "0x1885799F0")]
		public void OXPYBPCCUHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8579520", Offset = "0x8578320", VA = "0x188579520")]
		public void MFVMRTWDNFR(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8579280", Offset = "0x8578080", VA = "0x188579280")]
		public void LBUMCAPOIND(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8576EF0", Offset = "0x8575CF0", VA = "0x188576EF0")]
		public void EHKQPQBBYKM(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8577E40", Offset = "0x8576C40", VA = "0x188577E40")]
		public void HPFTFJWMZQX(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8576B40", Offset = "0x8575940", VA = "0x188576B40")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85780D0", Offset = "0x8576ED0", VA = "0x1885780D0")]
		public int HPXBGWAUHLR(PQDMMRYYGHS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x857A200", Offset = "0x8579000", VA = "0x18857A200")]
		public bool RaiseEvent(byte eventCode, object eventContent, ZPXXLQJTGDJ raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8578750", Offset = "0x8577550", VA = "0x188578750")]
		public bool IWWMMBRGHWJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x857A7B0", Offset = "0x85795B0", VA = "0x18857A7B0")]
		internal bool SKNYPGRGRAR([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8578CB0", Offset = "0x8577AB0", VA = "0x188578CB0")]
		internal bool JWBZYUOOKST([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8576360", Offset = "0x8575160", VA = "0x188576360")]
		private void CNXOPCVDMSU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8579510", Offset = "0x8578310", VA = "0x188579510")]
		public void LeaveRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8576C30", Offset = "0x8575A30", VA = "0x188576C30")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85790F0", Offset = "0x8577EF0", VA = "0x1885790F0")]
		private void KXFOFXZNQUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85764F0", Offset = "0x85752F0", VA = "0x1885764F0")]
		private void CRREGUCDCQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x857A660", Offset = "0x8579460", VA = "0x18857A660")]
		private void SBSYQYLJFQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x857AD10", Offset = "0x8579B10", VA = "0x18857AD10")]
		private void UTUVAXIFCFJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8579DF0", Offset = "0x8578BF0", VA = "0x188579DF0")]
		private void PRGYPSTFILG(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3C341F0", Offset = "0x3C32FF0", VA = "0x183C341F0")]
		private void LMLTTRKLGHO<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8578F10", Offset = "0x8577D10", VA = "0x188578F10")]
		private void KAFAPVYXSVD(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8577190", Offset = "0x8575F90", VA = "0x188577190")]
		private void FEPORDTXQVM(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x857AAD0", Offset = "0x85798D0", VA = "0x18857AAD0")]
		private void TNKUYBDSUXI(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8577920", Offset = "0x8576720", VA = "0x188577920")]
		private void HGSWZZWMEED(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85782C0", Offset = "0x85770C0", VA = "0x1885782C0")]
		private void IFAJOHGZWNH(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8575FA0", Offset = "0x8574DA0", VA = "0x188575FA0")]
		private void BYEYGWCEFPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85785C0", Offset = "0x85773C0", VA = "0x1885785C0")]
		private void IVEEOOLJVSC(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x857AB00", Offset = "0x8579900", VA = "0x18857AB00")]
		private void TQYGBYFYJHW(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8576C40", Offset = "0x8575A40", VA = "0x188576C40")]
		private void EFOYAMGRKYA(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8579AB0", Offset = "0x85788B0", VA = "0x188579AB0")]
		private void OYIMSNRNGUQ(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85772B0", Offset = "0x85760B0", VA = "0x1885772B0")]
		private void FEPORDTXQVM(HIZSPKGUWRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8579810", Offset = "0x8578610", VA = "0x188579810")]
		private void MTSRAZEJSEG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8579710", Offset = "0x8578510", VA = "0x188579710")]
		private void MRHPQSXEQWE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8577400", Offset = "0x8576200", VA = "0x188577400")]
		private void FHKTUJOHCCY(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x857A080", Offset = "0x8578E80", VA = "0x18857A080")]
		[CompilerGenerated]
		private void PWJNOEEFWUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ZETDYTQWFNG : LZEYQUPSRUQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private RFAJFCMJMHR VNCAOZFCNHV;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string XNOSUSNTGNW;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> KPIVEISJAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int WXGYCMJPIKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string ANIOAUISONS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt HCPEIMHDHYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? LLBZUQAZMUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string PMTOLUKEDUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong NMHELKAVPMW;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int LHNKUKOMXWV
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool DSFKUPIDZLI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xBCDA30", Offset = "0xBCC830", VA = "0x180BCDA30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xF47710", Offset = "0xF46510", VA = "0x180F47710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MBDFWDUXOGF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x857E680", Offset = "0x857D480", VA = "0x18857E680", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Dictionary<object, object> EOYPZSHVNGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string MCCRGDXMTOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x857E770", Offset = "0x857D570", VA = "0x18857E770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int SBOXCSWHYVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x857E1F0", Offset = "0x857CFF0", VA = "0x18857E1F0", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x857E610", Offset = "0x857D410", VA = "0x18857E610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool MIARKIPYGPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1A11620", Offset = "0x1A10420", VA = "0x181A11620", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1A116B0", Offset = "0x1A104B0", VA = "0x181A116B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool SRNXQUUUNWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x857E240", Offset = "0x857D040", VA = "0x18857E240", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string NDIJBRGOCIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x857E980", Offset = "0x857D780", VA = "0x18857E980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ZXAOLMEGRXH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x857E710", Offset = "0x857D510", VA = "0x18857E710", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool SXHCJZIKQFY
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAE7F40", Offset = "0xAE6D40", VA = "0x180AE7F40", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public object VAPARQYGEHE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA19B0", Offset = "0xAA07B0", VA = "0x180AA19B0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal ulong LWYYJOURKMV
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1950", Offset = "0xAA0750", VA = "0x180AA1950")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x857E5F0", Offset = "0x857D3F0", VA = "0x18857E5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x857EC20", Offset = "0x857DA20", VA = "0x18857EC20")]
		internal ZETDYTQWFNG(RFAJFCMJMHR a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x857EAD0", Offset = "0x857D8D0", VA = "0x18857EAD0")]
		internal ZETDYTQWFNG(RFAJFCMJMHR a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x857EB10", Offset = "0x857D910", VA = "0x18857EB10")]
		internal ZETDYTQWFNG(RFAJFCMJMHR a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x857EA20", Offset = "0x857D820", VA = "0x18857EA20", Slot = "16")]
		public bool YPDAXXVOQJB(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x857E860", Offset = "0x857D660", VA = "0x18857E860")]
		public NetworkedPlayerData SIPVGCOPBPD()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x857E300", Offset = "0x857D100", VA = "0x18857E300")]
		internal void DVHOXMYBKPX([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class UGWNADKAFVY : ABWHXVJVLPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private RFAJFCMJMHR VNCAOZFCNHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> SJOIJPJNSSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, ZETDYTQWFNG> OVYMUIMCMXM;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string CCOXOANSCWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x857E030", Offset = "0x857CE30", VA = "0x18857E030", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public byte HLUOFLCBKHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x857DBE0", Offset = "0x857C9E0", VA = "0x18857DBE0", Slot = "5")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool PAKNTHIERNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB87BE0", Offset = "0xB869E0", VA = "0x180B87BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Dictionary<object, object> EOYPZSHVNGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ZETDYTQWFNG[] BSUBDGYHHGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAA58C0", Offset = "0xAA46C0", VA = "0x180AA58C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public ZETDYTQWFNG[] DENMFQWCTIN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BF0", Offset = "0xA9F9F0", VA = "0x180AA0BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public ZETDYTQWFNG[] GEHHZMRDWRR
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BD0", Offset = "0xA9F9D0", VA = "0x180AA0BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public ZETDYTQWFNG[] HNXGQTHQOED
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC10", Offset = "0xA9DA10", VA = "0x180A9EC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int MSYOBDUWEDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xF2E2E0", Offset = "0xF2D0E0", VA = "0x180F2E2E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x1AD65E0", Offset = "0x1AD53E0", VA = "0x181AD65E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x857E060", Offset = "0x857CE60", VA = "0x18857E060")]
		public UGWNADKAFVY(RFAJFCMJMHR a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x857DB80", Offset = "0x857C980", VA = "0x18857DB80", Slot = "9")]
		public bool ITXDWGHGRBK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x857DF80", Offset = "0x857CD80", VA = "0x18857DF80", Slot = "8")]
		public bool YPDAXXVOQJB(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x857DC30", Offset = "0x857CA30", VA = "0x18857DC30")]
		internal bool VAMRUSXEHXN([In] NetworkedPlayerData playerData, bool a, [Out] ZETDYTQWFNG b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x857DDE0", Offset = "0x857CBE0", VA = "0x18857DDE0")]
		internal void WKJJEDPUBEG(ulong a, [Out] ZETDYTQWFNG b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x857D320", Offset = "0x857C120", VA = "0x18857D320")]
		internal void AKNCNLIPBFJ([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x857D760", Offset = "0x857C560", VA = "0x18857D760")]
		private void FWLCHSRAEQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SCTITJUUBNC : GPGVOGUVSTQ, RZNZAUAZENO, LHVRLQQVSQU, RIEHQAGCECW, BPNYDMHEGGI, RXEEQWARQDP, SARRWXEQYHH, KKWQOVLPYQB, UNHZSCQNBPS, CZCOINDTTUJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private RFAJFCMJMHR VNCAOZFCNHV;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int DAKOSDDBMSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x857B9B0", Offset = "0x857A7B0", VA = "0x18857B9B0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int JBVUXQRHUMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int FRGAMLCORDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x857BCF0", Offset = "0x857AAF0", VA = "0x18857BCF0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int PHZTBKPXKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xE53640", Offset = "0xE52440", VA = "0x180E53640", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool QDURDVTJFRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xE53890", Offset = "0xE52690", VA = "0x180E53890", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public double ZZXWEPDGXLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x857C4C0", Offset = "0x857B2C0", VA = "0x18857C4C0", Slot = "35")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int JESLADALABS
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x857B5D0", Offset = "0x857A3D0", VA = "0x18857B5D0", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool QQMEGTADUQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x25AEB10", Offset = "0x25AD910", VA = "0x1825AEB10", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool YZSDVXYZDAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x857B490", Offset = "0x857A290", VA = "0x18857B490", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool EBZAJFLGPLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x857B490", Offset = "0x857A290", VA = "0x18857B490", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool BSHEGRJNMKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x857C9A0", Offset = "0x857B7A0", VA = "0x18857C9A0", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x857BEE0", Offset = "0x857ACE0", VA = "0x18857BEE0", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool ISOPISRYMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x857C660", Offset = "0x857B460", VA = "0x18857C660", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool FGJAKZFGGCD
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x857BA10", Offset = "0x857A810", VA = "0x18857BA10", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public object PVLYZHTYGFV
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1BD0", Offset = "0xAA09D0", VA = "0x180AA1BD0", Slot = "50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public LZEYQUPSRUQ GABUPFWQSQP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x857B780", Offset = "0x857A580", VA = "0x18857B780", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int CFJQWSGKLER
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x857B7F0", Offset = "0x857A5F0", VA = "0x18857B7F0", Slot = "74")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int REILCMUTBRW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x857CCB0", Offset = "0x857BAB0", VA = "0x18857CCB0", Slot = "75")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public LZEYQUPSRUQ FFTPZTDYYMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x857C2B0", Offset = "0x857B0B0", VA = "0x18857C2B0", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool VAXAVVMVXCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x857C520", Offset = "0x857B320", VA = "0x18857C520", Slot = "77")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int HLUOFLCBKHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x857B8E0", Offset = "0x857A6E0", VA = "0x18857B8E0", Slot = "78")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string XNOSUSNTGNW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x857C6C0", Offset = "0x857B4C0", VA = "0x18857C6C0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Func<string, string> KPIVEISJAML
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x857BDE0", Offset = "0x857ABE0", VA = "0x18857BDE0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ZPMZXUEDLIU HGXHCIEEHMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x857BFB0", Offset = "0x857ADB0", VA = "0x18857BFB0", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool NRNTSANFHMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x857CE50", Offset = "0x857BC50", VA = "0x18857CE50", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x857B650", Offset = "0x857A450", VA = "0x18857B650", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override float ARWVOPQWQEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xE71AF0", Offset = "0xE708F0", VA = "0x180E71AF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xE70D80", Offset = "0xE6FB80", VA = "0x180E70D80", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override RBETLIDWDVR TRVLDQDOWHS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA0F10", VA = "0x180AA2110", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool VMCSTYVXSBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x857B480", Offset = "0x857A280", VA = "0x18857B480", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x857CC70", Offset = "0x857BA70", VA = "0x18857CC70", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string FSRDKZBWKGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x857BB10", Offset = "0x857A910", VA = "0x18857BB10", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public long JOEXIQXLLWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x857C640", Offset = "0x857B440", VA = "0x18857C640", Slot = "93")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public long FEFDZBSAJUA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x857BAA0", Offset = "0x857A8A0", VA = "0x18857BAA0", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<RBETLIDWDVR, RBETLIDWDVR> RHRSFMZGMFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x857BD30", Offset = "0x857AB30", VA = "0x18857BD30", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x857BC30", Offset = "0x857AA30", VA = "0x18857BC30", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<PQDMMRYYGHS> NPEUFGMMXVN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x857BF00", Offset = "0x857AD00", VA = "0x18857BF00", Slot = "68")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x857B500", Offset = "0x857A300", VA = "0x18857B500", Slot = "69")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LZEYQUPSRUQ> GVVOLKWYSVM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x857C7D0", Offset = "0x857B5D0", VA = "0x18857C7D0", Slot = "71")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x857C150", Offset = "0x857AF50", VA = "0x18857C150", Slot = "72")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x857CAA0", Offset = "0x857B8A0", VA = "0x18857CAA0")]
		[XNELNNYDNRZ.Root.GameOnly]
		internal static void XNELNNYDNRZ(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x857CE60", Offset = "0x857BC60", VA = "0x18857CE60")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public SCTITJUUBNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x857BAF0", Offset = "0x857A8F0", VA = "0x18857BAF0", Slot = "21")]
		public void MFVMRTWDNFR(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x857B750", Offset = "0x857A550", VA = "0x18857B750", Slot = "23")]
		public void EHKQPQBBYKM(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x857CB10", Offset = "0x857B910", VA = "0x18857CB10", Slot = "27")]
		public void XTENLXJOVMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x857C6A0", Offset = "0x857B4A0", VA = "0x18857C6A0", Slot = "56")]
		public bool UNQAQYEWZGY(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x857B6F0", Offset = "0x857A4F0", VA = "0x18857B6F0", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x857B720", Offset = "0x857A520", VA = "0x18857B720", Slot = "55")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x857BA60", Offset = "0x857A860", VA = "0x18857BA60", Slot = "22")]
		public void LBUMCAPOIND(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x857C000", Offset = "0x857AE00", VA = "0x18857C000", Slot = "83")]
		public LZEYQUPSRUQ QZOOCSSOTEG(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x857C210", Offset = "0x857B010", VA = "0x18857C210", Slot = "82")]
		public LZEYQUPSRUQ RMOHZMDEGFK(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x857CD50", Offset = "0x857BB50", VA = "0x18857CD50", Slot = "84")]
		public LZEYQUPSRUQ ZVRIZSNDDOY(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x857B940", Offset = "0x857A740", VA = "0x18857B940", Slot = "18")]
		public bool KFGVJADWQCY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x857C320", Offset = "0x857B120", VA = "0x18857C320", Slot = "85")]
		public IReadOnlyList<LZEYQUPSRUQ> SLZEQDKDLFW(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x857BE50", Offset = "0x857AC50", VA = "0x18857BE50", Slot = "86")]
		public IReadOnlyList<LZEYQUPSRUQ> QIDBEPWWMTZ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x857B850", Offset = "0x857A650", VA = "0x18857B850", Slot = "54")]
		public bool IWWMMBRGHWJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x857BAB0", Offset = "0x857A8B0", VA = "0x18857BAB0", Slot = "53")]
		public bool LeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x857C9C0", Offset = "0x857B7C0", VA = "0x18857C9C0", Slot = "20")]
		public void XLMXGWKZHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x857C280", Offset = "0x857B080", VA = "0x18857C280", Slot = "70")]
		public bool RaiseEvent(byte eventCode, object eventContent, ZPXXLQJTGDJ raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x857B7A0", Offset = "0x857A5A0", VA = "0x18857B7A0", Slot = "28")]
		public void HPFTFJWMZQX(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x857B7C0", Offset = "0x857A5C0", VA = "0x18857B7C0", Slot = "30")]
		public int HPXBGWAUHLR(PQDMMRYYGHS a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "45")]
		public void LMRVREPCZQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x857C880", Offset = "0x857B680", VA = "0x18857C880", Slot = "87")]
		public bool XEXQTEGNXOE(LZEYQUPSRUQ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "34")]
		public void SBQIBJGZCLE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x857B670", Offset = "0x857A470", VA = "0x18857B670", Slot = "17")]
		public float COWRICCYMWV(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x857C0F0", Offset = "0x857AEF0", VA = "0x18857C0F0", Slot = "8")]
		public override void RDPPNQPWMNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x857C3B0", Offset = "0x857B1B0", VA = "0x18857C3B0", Slot = "81")]
		public void TCGAFZPNYYG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x857B9B0", Offset = "0x857A7B0", VA = "0x18857B9B0", Slot = "95")]
		public int KZONMQEIIDP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x857BA90", Offset = "0x857A890", VA = "0x18857BA90", Slot = "11")]
		private void LNUGMGUYBPZ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x857B6E0", Offset = "0x857A4E0", VA = "0x18857B6E0", Slot = "12")]
		private void DXTCPCFWHWI(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x857CA90", Offset = "0x857B890", VA = "0x18857CA90", Slot = "25")]
		private void XNAKXKDQBIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x857B5B0", Offset = "0x857A3B0", VA = "0x18857B5B0", Slot = "26")]
		private void BZLGCMPNJWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x857C200", Offset = "0x857B000", VA = "0x18857C200", Slot = "31")]
		private void RHXSRKGPJGI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x857CC50", Offset = "0x857BA50", VA = "0x18857CC50", Slot = "32")]
		private void XTJVKWTUTQL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x857BC20", Offset = "0x857AA20", VA = "0x18857BC20", Slot = "57")]
		private void NKGOPNVIAPI(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x857CC60", Offset = "0x857BA60", VA = "0x18857CC60", Slot = "58")]
		private void YBZZESUELEX(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x857B4F0", Offset = "0x857A2F0", VA = "0x18857B4F0", Slot = "59")]
		private void BCGFFDNBAUL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x857BAE0", Offset = "0x857A8E0", VA = "0x18857BAE0", Slot = "60")]
		private void MERDPVAPDJK(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x857BA80", Offset = "0x857A880", VA = "0x18857BA80", Slot = "61")]
		private void LISMCZTXBJE(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x857C650", Offset = "0x857B450", VA = "0x18857C650", Slot = "62")]
		private IDisposable UHZUPJEARYR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x857B7E0", Offset = "0x857A5E0", VA = "0x18857B7E0", Slot = "63")]
		private bool IIXEXTMAWXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x857BE40", Offset = "0x857AC40", VA = "0x18857BE40", Slot = "64")]
		private void PUGUEITHCGA(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x857BCE0", Offset = "0x857AAE0", VA = "0x18857BCE0", Slot = "66")]
		private void NOKSYZLFHAU(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x857B5C0", Offset = "0x857A3C0", VA = "0x18857B5C0", Slot = "67")]
		private void BZSWPLDRIGH(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x857B9A0", Offset = "0x857A7A0", VA = "0x18857B9A0", Slot = "88")]
		private void KNJZDNNTZKG(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x857B470", Offset = "0x857A270", VA = "0x18857B470", Slot = "89")]
		private void ADHARBMAZPD(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x857B8D0", Offset = "0x857A6D0", VA = "0x18857B8D0", Slot = "90")]
		private void JGNWRJNQRBR()
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
		public NfgoCommsNetwork MOJKZOUECVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8575880", Offset = "0x8574680", VA = "0x188575880")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8575A40", Offset = "0x8574840", VA = "0x188575A40")]
		private void GAWPTDJPPCD(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
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
		[Cpp2IlInjected.Address(RVA = "0x8575B10", Offset = "0x8574910", VA = "0x188575B10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9CF70", VA = "0x180A9E170")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class PBGTCTLGUIL
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool OUDFRHNPREG
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAF1380", Offset = "0xAF0180", VA = "0x180AF1380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xBF7410", Offset = "0xBF6210", VA = "0x180BF7410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NetworkManager LBNDANTMWHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA0560", Offset = "0xA9F360", VA = "0x180AA0560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NetworkManager KTDOWEBIDDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9FA00", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA0570", Offset = "0xA9F370", VA = "0x180AA0570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public INetworkManager TTJSQDCEDXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NetworkManager, bool> GAWPTDJPPCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8575C00", Offset = "0x8574A00", VA = "0x188575C00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8575D20", Offset = "0x8574B20", VA = "0x188575D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8575E40", Offset = "0x8574C40", VA = "0x188575E40")]
		[RecRoom.NoEngine.Common.Preserve]
		public PBGTCTLGUIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8575DD0", Offset = "0x8574BD0", VA = "0x188575DD0")]
		[XNELNNYDNRZ.Root]
		public static void ZLLOPCIBZWY(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8575CB0", Offset = "0x8574AB0", VA = "0x188575CB0")]
		public void XMOGRAKNPQY(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TTJSQDCEDXB : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float CTTKYVKZBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private CustomMessagingManager.HandleNamedMessageDelegate NIGKMDGFHUQ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xC55740", Offset = "0xC54540", VA = "0x180C55740", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BB0", Offset = "0xA9F9B0", VA = "0x180AA0BB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAA0940", Offset = "0xA9F740", VA = "0x180AA0940", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAB8990", Offset = "0xAB7790", VA = "0x180AB8990", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x857CFC0", Offset = "0x857BDC0", VA = "0x18857CFC0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x857D110", Offset = "0x857BF10", VA = "0x18857D110", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x857D070", Offset = "0x857BE70", VA = "0x18857D070", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x857D1C0", Offset = "0x857BFC0", VA = "0x18857D1C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x857CED0", Offset = "0x857BCD0", VA = "0x18857CED0", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x857CED0", Offset = "0x857BCD0", VA = "0x18857CED0", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA9E190", Offset = "0xA9CF90", VA = "0x180A9E190", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x857CF50", Offset = "0x857BD50", VA = "0x18857CF50")]
		public TTJSQDCEDXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x857CEF0", Offset = "0x857BCF0", VA = "0x18857CEF0", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x857CF10", Offset = "0x857BD10", VA = "0x18857CF10", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x857CF30", Offset = "0x857BD30", VA = "0x18857CF30", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "21")]
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
