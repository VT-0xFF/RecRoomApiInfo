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
		[Cpp2IlInjected.Address(RVA = "0x9AC59E0", Offset = "0x9AC43E0", VA = "0x189AC59E0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class BFYJPATUDOI : MBQGRUSTSMG, IIPEJBWGEEG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class FEAXAOQXNZH : EPOORIVUAQX
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte OMUTIOYQJPJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xE28730", Offset = "0xE27130", VA = "0x180E28730")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int LQTBMJMCXTJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E00", Offset = "0xDF6800", VA = "0x180DF7E00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object RFNDEGJCHXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9306A20", Offset = "0x9305420", VA = "0x189306A20")]
			public FEAXAOQXNZH(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AC20C0", Offset = "0x9AC0AC0", VA = "0x189AC20C0", Slot = "7")]
			public bool MAVXVFMPMHQ(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState HMCEIPLIGSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch XHTXLWLQKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int SCEQAIMQBNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<FEAXAOQXNZH> YHQBDCXFMQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> RFJWACSBIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private ZWWIVDIJZYL QRUPNICDFJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private PJFXJRWQFBH JBODJDBFHIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool VLXAGVBMFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool KNDCZPLYPKL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager OBCXUZYMCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport YMDOBLPZJSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9AC00D0", Offset = "0x9ABEAD0", VA = "0x189AC00D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState BRKXBFWXXDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9ABFB90", Offset = "0x9ABE590", VA = "0x189ABFB90", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE2C0", Offset = "0x9ABCCC0", VA = "0x189ABE2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int GRJBIWSAUJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD1B440", Offset = "0xD19E40", VA = "0x180D1B440")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ZWWIVDIJZYL HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PJFXJRWQFBH IQUODMNVGQA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private IPBRLYOLLKP FBWFREJSJLH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool YBYLUNUVGBU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDEE0", Offset = "0x9ABC8E0", VA = "0x189ABDEE0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ENZVDVQVJTH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9ABD990", Offset = "0x9ABC390", VA = "0x189ABD990", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool QQRCZTPFXJT
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9ABD990", Offset = "0x9ABC390", VA = "0x189ABD990", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LIKRKGEZCXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E50", Offset = "0xDB4850", VA = "0x180DB5E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE1A0", Offset = "0x9ABCBA0", VA = "0x189ABE1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception JVGADPCADZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD141C0", Offset = "0xD12BC0", VA = "0x180D141C0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int NGXSHPBPAZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool TDVIXFHHCQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE850", Offset = "0x9ABD250", VA = "0x189ABE850", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE2F0", Offset = "0x9ABCCF0", VA = "0x189ABE2F0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool MHRLKDKFJFV
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD15970", Offset = "0xD14370", VA = "0x180D15970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD15930", Offset = "0xD14330", VA = "0x180D15930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double QKEZKBPMOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9ABF530", Offset = "0x9ABDF30", VA = "0x189ABF530")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double YWJOJVNZDTO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1640", Offset = "0x9AC0040", VA = "0x189AC1640")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int HCAAXHXVIGY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9AC15F0", Offset = "0x9ABFFF0", VA = "0x189AC15F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string URTSTMCGUSD
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE350", Offset = "0x9ABCD50", VA = "0x189ABE350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int HXLVRIBLSNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9ABD9E0", Offset = "0x9ABC3E0", VA = "0x189ABD9E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ALKDGZAAFQB USEWHVWKZZN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9AC09D0", Offset = "0x9ABF3D0", VA = "0x189AC09D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool NQNCGBDWWTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xFD0570", Offset = "0xFCEF70", VA = "0x180FD0570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9ABF500", Offset = "0x9ABDF00", VA = "0x189ABF500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> KKXLLNVMPWX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9ABF580", Offset = "0x9ABDF80", VA = "0x189ABF580", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE5B0", Offset = "0x9ABCFB0", VA = "0x189ABE5B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> KTPKXQEJUPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9ABC180", Offset = "0x9ABAB80", VA = "0x189ABC180", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9ABC230", Offset = "0x9ABAC30", VA = "0x189ABC230", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1820", Offset = "0x9AC0220", VA = "0x189AC1820")]
		public BFYJPATUDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD350", Offset = "0x9ABBD50", VA = "0x189ABD350")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD130", Offset = "0x9ABBB30", VA = "0x189ABD130")]
		private void CZRWCDOYCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9ABEAA0", Offset = "0x9ABD4A0", VA = "0x189ABEAA0")]
		private void NJWGQHFYSJR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9ABF850", Offset = "0x9ABE250", VA = "0x189ABF850")]
		public bool RDQCPBLTDHR(KDSOOWCXYNX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9ABEF80", Offset = "0x9ABD980", VA = "0x189ABEF80")]
		public bool OGOCVYLJKHC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9ABDA40", Offset = "0x9ABC440", VA = "0x189ABDA40")]
		public void FMDLUZPLHNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0010", Offset = "0x9ABEA10", VA = "0x189AC0010")]
		public void WDBBFXKHIHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9ABEB00", Offset = "0x9ABD500", VA = "0x189ABEB00")]
		public void NKSAWRSTASC(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9ABDF10", Offset = "0x9ABC910", VA = "0x189ABDF10")]
		public void IPFJYEMGWPE(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE8A0", Offset = "0x9ABD2A0", VA = "0x189ABE8A0")]
		public void MTEGJMGQCTN(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9ABECF0", Offset = "0x9ABD6F0", VA = "0x189ABECF0")]
		public void NZJDRENIZKU(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD650", Offset = "0x9ABC050", VA = "0x189ABD650")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE660", Offset = "0x9ABD060", VA = "0x189ABE660")]
		public int MNTKOONLCOG(EPOORIVUAQX a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFBB0", Offset = "0x9ABE5B0", VA = "0x189ABFBB0")]
		public bool UNRAXFIHVPM(byte a, object b, CBEOKZVPQNC c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9ABCC80", Offset = "0x9ABB680", VA = "0x189ABCC80")]
		public bool CWUQNUAQLNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9ABF630", Offset = "0x9ABE030", VA = "0x189ABF630")]
		internal bool QNBHOLXEJPO([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0450", Offset = "0x9ABEE50", VA = "0x189AC0450")]
		internal bool XBUAUFCXZLE([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC570", Offset = "0x9ABAF70", VA = "0x189ABC570")]
		private void BSTEYACYZTP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD740", Offset = "0x9ABC140", VA = "0x189ABD740")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD840", Offset = "0x9ABC240", VA = "0x189ABD840", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE450", Offset = "0x9ABCE50", VA = "0x189ABE450")]
		private void LPEOSAEBQZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC06B0", Offset = "0x9ABF0B0", VA = "0x189AC06B0")]
		private void XDACFHDATNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFAA0", Offset = "0x9ABE4A0", VA = "0x189ABFAA0")]
		private void TWVTXYCZDLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0C10", Offset = "0x9ABF610", VA = "0x189AC0C10")]
		private void XXNTUPNNAXU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC2E0", Offset = "0x9ABACE0", VA = "0x189ABC2E0")]
		private void BAJGBLRPRGT(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37644D0", Offset = "0x3762ED0", VA = "0x1837644D0")]
		private void EZYMUENDWDJ<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC740", Offset = "0x9ABB140", VA = "0x189ABC740")]
		private void BUJXBMIFRNI(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AC01E0", Offset = "0x9ABEBE0", VA = "0x189AC01E0")]
		private void XAIXBDFPBAD(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0BE0", Offset = "0x9ABF5E0", VA = "0x189AC0BE0")]
		private void XWMBXHQMKYH(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9ABEFD0", Offset = "0x9ABD9D0", VA = "0x189ABEFD0")]
		private void OMSAXYCEMIA(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0F30", Offset = "0x9ABF930", VA = "0x189AC0F30")]
		private void YRFGMHOGZTS(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9ABDB70", Offset = "0x9ABC570", VA = "0x189ABDB70")]
		private void GCHRWQWYFKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1690", Offset = "0x9AC0090", VA = "0x189AC1690")]
		private void ZYYVSDQJHFJ(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0A20", Offset = "0x9ABF420", VA = "0x189AC0A20")]
		private void XKCIROIYPOZ(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1330", Offset = "0x9ABFD30", VA = "0x189AC1330")]
		private void ZCIVHTCDBUN(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9ABF970", Offset = "0x9ABE370", VA = "0x189ABF970")]
		private void RMGCZERVCVP(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AC0300", Offset = "0x9ABED00", VA = "0x189AC0300")]
		private void XAIXBDFPBAD(FEAXAOQXNZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9ABDA90", Offset = "0x9ABC490", VA = "0x189ABDA90")]
		private void FQDOQUBNXWD(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1230", Offset = "0x9ABFC30", VA = "0x189AC1230")]
		private void YRZIMBDQARH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC870", Offset = "0x9ABB270", VA = "0x189ABC870")]
		private void CMTKMZRJLNX(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9ABCC70", Offset = "0x9ABB670", VA = "0x189ABCC70")]
		[CompilerGenerated]
		private void CSBCMRZMVIB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ZWWIVDIJZYL : KDSOOWCXYNX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private BFYJPATUDOI SOVBKQYAQEM;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string ZPTLXARQHRJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> HLHSFRELYDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GIMYJUODWQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string UULPLBAPCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt SVNXNOFHNOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? ESKNZGKOPCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string VHGVTVUJWGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong WGYBUMCOCOV;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int WFLATIDWTAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool XIKCCLBFFJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xEAF1A0", Offset = "0xEADBA0", VA = "0x180EAF1A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xEDB700", Offset = "0xEDA100", VA = "0x180EDB700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool CFYFULTIBEE
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9AC51D0", Offset = "0x9AC3BD0", VA = "0x189AC51D0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> MUJEHANMJKE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string TYVSFCKNFQG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC5350", Offset = "0x9AC3D50", VA = "0x189AC5350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int WYAVLOBYCKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9AC5300", Offset = "0x9AC3D00", VA = "0x189AC5300", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AC5440", Offset = "0x9AC3E40", VA = "0x189AC5440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DXSFUDMPNJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x19EF3C0", Offset = "0x19EDDC0", VA = "0x1819EF3C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x19EF5F0", Offset = "0x19EDFF0", VA = "0x1819EF5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool AIZDFIRZBJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4FF0", Offset = "0x9AC39F0", VA = "0x189AC4FF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string EVBJBKGAQIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9AC5260", Offset = "0x9AC3C60", VA = "0x189AC5260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string RQERZBTBIIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4F90", Offset = "0x9AC3990", VA = "0x189AC4F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool CMPMAOBNZZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object LSVVIQAWMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD141E0", Offset = "0xD12BE0", VA = "0x180D141E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong GEWBSXIMOJW
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4F70", Offset = "0x9AC3970", VA = "0x189AC4F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5890", Offset = "0x9AC4290", VA = "0x189AC5890")]
		internal ZWWIVDIJZYL(BFYJPATUDOI a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5850", Offset = "0x9AC4250", VA = "0x189AC5850")]
		internal ZWWIVDIJZYL(BFYJPATUDOI a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AC58D0", Offset = "0x9AC42D0", VA = "0x189AC58D0")]
		internal ZWWIVDIJZYL(BFYJPATUDOI a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC54B0", Offset = "0x9AC3EB0", VA = "0x189AC54B0", Slot = "16")]
		public bool XZIGXSLNHYA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC50B0", Offset = "0x9AC3AB0", VA = "0x189AC50B0")]
		public NetworkedPlayerData QUMIQLTTJSS()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5560", Offset = "0x9AC3F60", VA = "0x189AC5560")]
		internal void YSLXMOSXKFM([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class PJFXJRWQFBH : IPBRLYOLLKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BFYJPATUDOI SOVBKQYAQEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> DXQABHZJWMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, ZWWIVDIJZYL> NQRSJFZRJAX;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte HJYMWYSJKZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9AC2580", Offset = "0x9AC0F80", VA = "0x189AC2580", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool SROYTEFYRMR
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEC57F0", Offset = "0xEC41F0", VA = "0x180EC57F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> MUJEHANMJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public ZWWIVDIJZYL[] DWMFEWKALOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public ZWWIVDIJZYL[] JGJLBITEGPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ZWWIVDIJZYL[] OBATOJVICYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD15950", Offset = "0xD14350", VA = "0x180D15950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ZWWIVDIJZYL[] EEVKDUDWMFM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int ANOYUUITPEC
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEE94F0", Offset = "0xEE7EF0", VA = "0x180EE94F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1AD9140", Offset = "0x1AD7B40", VA = "0x181AD9140")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3290", Offset = "0x9AC1C90", VA = "0x189AC3290")]
		public PJFXJRWQFBH(BFYJPATUDOI a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC25D0", Offset = "0x9AC0FD0", VA = "0x189AC25D0", Slot = "8")]
		public bool MWSTOZZNJYL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC31E0", Offset = "0x9AC1BE0", VA = "0x189AC31E0", Slot = "7")]
		public bool XZIGXSLNHYA(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2630", Offset = "0x9AC1030", VA = "0x189AC2630")]
		internal bool NXOBWNNQFVS([In] NetworkedPlayerData playerData, bool a, [Out] ZWWIVDIJZYL b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9AC27E0", Offset = "0x9AC11E0", VA = "0x189AC27E0")]
		internal void PWROFWMFENZ(ulong a, [Out] ZWWIVDIJZYL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2DA0", Offset = "0x9AC17A0", VA = "0x189AC2DA0")]
		internal void WLVXCWOQSRK([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2980", Offset = "0x9AC1380", VA = "0x189AC2980")]
		private void SONPUTBLVJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PXGASJWCSQB : NNENUQXQVWX, GXLSEMXVYCP, YRPMRISBKYH, OVUDHFSVZRB, UKZZMHQCVUV, MHGHLMUDRDA, KQABBQLSHCW, IIPEJBWGEEG, OTYHDSTJRSP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private BFYJPATUDOI SOVBKQYAQEM;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int HCAAXHXVIGY
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4600", Offset = "0x9AC3000", VA = "0x189AC4600", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int ETQSHMXPUGT
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int SXPHRTFQALB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4000", Offset = "0x9AC2A00", VA = "0x189AC4000", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int GRJBIWSAUJT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4D70", Offset = "0x9AC3770", VA = "0x189AC4D70", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool POMPKSSGJRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE21440", Offset = "0xE1FE40", VA = "0x180E21440", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double QKEZKBPMOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9AC45A0", Offset = "0x9AC2FA0", VA = "0x189AC45A0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int VBVCSSKGYYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3430", Offset = "0x9AC1E30", VA = "0x189AC3430", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool QQRCZTPFXJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9AC44E0", Offset = "0x9AC2EE0", VA = "0x189AC44E0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool LIKRKGEZCXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3F80", Offset = "0x9AC2980", VA = "0x189AC3F80", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3E20", Offset = "0x9AC2820", VA = "0x189AC3E20", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool NIENSSSWZOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3C40", Offset = "0x9AC2640", VA = "0x189AC3C40", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool YBYLUNUVGBU
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3C80", Offset = "0x9AC2680", VA = "0x189AC3C80", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public KDSOOWCXYNX HBPTAMMHPSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9AC48E0", Offset = "0x9AC32E0", VA = "0x189AC48E0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int ASBNOAGXZWU
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4870", Offset = "0x9AC3270", VA = "0x189AC4870", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int YYNMKBWUOFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9AC36C0", Offset = "0x9AC20C0", VA = "0x189AC36C0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public KDSOOWCXYNX DUOYZNQYDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3D80", Offset = "0x9AC2780", VA = "0x189AC3D80", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool SUTKPCFTSTR
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3A60", Offset = "0x9AC2460", VA = "0x189AC3A60", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int HJYMWYSJKZU
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3FA0", Offset = "0x9AC29A0", VA = "0x189AC3FA0", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string ZPTLXARQHRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4180", Offset = "0x9AC2B80", VA = "0x189AC4180", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> HLHSFRELYDS
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC46A0", Offset = "0x9AC30A0", VA = "0x189AC46A0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public ALKDGZAAFQB USEWHVWKZZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4D10", Offset = "0x9AC3710", VA = "0x189AC4D10", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool MHRLKDKFJFV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4830", Offset = "0x9AC3230", VA = "0x189AC4830", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4670", Offset = "0x9AC3070", VA = "0x189AC4670", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float ATVZYPZCQHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12EC730", Offset = "0x12EB130", VA = "0x1812EC730", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AB90B0", Offset = "0x1AB7AB0", VA = "0x181AB90B0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override MBQGRUSTSMG HVFSCIYSEVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD14490", Offset = "0xD12E90", VA = "0x180D14490", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool NQNCGBDWWTV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4860", Offset = "0x9AC3260", VA = "0x189AC4860", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4560", Offset = "0x9AC2F60", VA = "0x189AC4560", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string URTSTMCGUSD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4070", Offset = "0x9AC2A70", VA = "0x189AC4070", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long SOVOAOQMNNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4320", Offset = "0x9AC2D20", VA = "0x189AC4320", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long LQZYSRGQDQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3610", Offset = "0x9AC2010", VA = "0x189AC3610", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EPOORIVUAQX> RORSLVKDMWI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3CD0", Offset = "0x9AC26D0", VA = "0x189AC3CD0", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4400", Offset = "0x9AC2E00", VA = "0x189AC4400", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<KDSOOWCXYNX> NGUPMDHOFVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9AC3B90", Offset = "0x9AC2590", VA = "0x189AC3B90", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AC4AD0", Offset = "0x9AC34D0", VA = "0x189AC4AD0", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC34B0", Offset = "0x9AC1EB0", VA = "0x189AC34B0")]
		[BRMSZAJTATI.Root.GameOnly]
		internal static void BRMSZAJTATI(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4DA0", Offset = "0x9AC37A0", VA = "0x189AC4DA0")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public PXGASJWCSQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9AC44C0", Offset = "0x9AC2EC0", VA = "0x189AC44C0", Slot = "21")]
		public void NKSAWRSTASC(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4330", Offset = "0x9AC2D30", VA = "0x189AC4330", Slot = "23")]
		public void MTEGJMGQCTN(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3E40", Offset = "0x9AC2840", VA = "0x189AC3E40", Slot = "27")]
		public void KCVBXOSSSDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3690", Offset = "0x9AC2090", VA = "0x189AC3690", Slot = "47")]
		public bool CJSGBGRNYOJ(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3850", Offset = "0x9AC2250", VA = "0x189AC3850", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3880", Offset = "0x9AC2280", VA = "0x189AC3880", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3DF0", Offset = "0x9AC27F0", VA = "0x189AC3DF0", Slot = "22")]
		public void IPFJYEMGWPE(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3520", Offset = "0x9AC1F20", VA = "0x189AC3520", Slot = "75")]
		public KDSOOWCXYNX BRTYMRMESFT(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4B80", Offset = "0x9AC3580", VA = "0x189AC4B80", Slot = "74")]
		public KDSOOWCXYNX XAAYHUMVZMX(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AC49D0", Offset = "0x9AC33D0", VA = "0x189AC49D0", Slot = "76")]
		public KDSOOWCXYNX WGNWTBDNSVF(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3620", Offset = "0x9AC2020", VA = "0x189AC3620", Slot = "18")]
		public bool CCOQBHMCJAT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4370", Offset = "0x9AC2D70", VA = "0x189AC4370", Slot = "77")]
		public IReadOnlyList<KDSOOWCXYNX> MZFIPIOGGNB(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4900", Offset = "0x9AC3300", VA = "0x189AC4900", Slot = "78")]
		public IReadOnlyList<KDSOOWCXYNX> TUMWMCJPUGI(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3760", Offset = "0x9AC2160", VA = "0x189AC3760", Slot = "45")]
		public bool CWUQNUAQLNK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3980", Offset = "0x9AC2380", VA = "0x189AC3980", Slot = "20")]
		public void EEISTHFQUKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4990", Offset = "0x9AC3390", VA = "0x189AC4990", Slot = "62")]
		public bool UNRAXFIHVPM(byte a, object b, CBEOKZVPQNC c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4540", Offset = "0x9AC2F40", VA = "0x189AC4540", Slot = "28")]
		public void NZJDRENIZKU(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4300", Offset = "0x9AC2D00", VA = "0x189AC4300", Slot = "30")]
		public int MNTKOONLCOG(EPOORIVUAQX a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4700", Offset = "0x9AC3100", VA = "0x189AC4700", Slot = "79")]
		public bool RDQCPBLTDHR(KDSOOWCXYNX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4290", Offset = "0x9AC2C90", VA = "0x189AC4290", Slot = "17")]
		public float MIIAHZRXNCI(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9AC37F0", Offset = "0x9AC21F0", VA = "0x189AC37F0", Slot = "8")]
		public override void DYIVQXTDRGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4BF0", Offset = "0x9AC35F0", VA = "0x189AC4BF0", Slot = "73")]
		public void XEHMGHSTIXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4600", Offset = "0x9AC3000", VA = "0x189AC4600", Slot = "87")]
		public int PCGTYUOJXFM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3B80", Offset = "0x9AC2580", VA = "0x189AC3B80", Slot = "11")]
		private void GGTBHGNNIQM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3420", Offset = "0x9AC1E20", VA = "0x189AC3420", Slot = "12")]
		private void BDATCOQGCFP(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4360", Offset = "0x9AC2D60", VA = "0x189AC4360", Slot = "25")]
		private void MYAJZPMUPVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4660", Offset = "0x9AC3060", VA = "0x189AC4660", Slot = "26")]
		private void PDVQRMPSWFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4D60", Offset = "0x9AC3760", VA = "0x189AC4D60", Slot = "31")]
		private void XVYIYFUFNHJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4820", Offset = "0x9AC3220", VA = "0x189AC4820", Slot = "32")]
		private void RRMZBWGCDPA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3680", Offset = "0x9AC2080", VA = "0x189AC3680", Slot = "48")]
		private void CENAQUBSMUV(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AC36B0", Offset = "0x9AC20B0", VA = "0x189AC36B0", Slot = "49")]
		private void CKKKJYLCKPI(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AC48D0", Offset = "0x9AC32D0", VA = "0x189AC48D0", Slot = "50")]
		private void TDKANLZAMQG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3A50", Offset = "0x9AC2450", VA = "0x189AC3A50", Slot = "51")]
		private void EFFLMYIZYUB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4840", Offset = "0x9AC3240", VA = "0x189AC4840", Slot = "52")]
		private void RVYLDSEHHMR(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4D90", Offset = "0x9AC3790", VA = "0x189AC4D90", Slot = "53")]
		private IDisposable YTXWRCIJXVE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AC44B0", Offset = "0x9AC2EB0", VA = "0x189AC44B0", Slot = "54")]
		private bool NKQZIAJXEUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4850", Offset = "0x9AC3250", VA = "0x189AC4850", Slot = "55")]
		private void SILXQRTUTAJ(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AC37E0", Offset = "0x9AC21E0", VA = "0x189AC37E0", Slot = "57")]
		private void DEENDMGHOLX(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AC49C0", Offset = "0x9AC33C0", VA = "0x189AC49C0", Slot = "58")]
		private void VXSSFCSYAQY(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4D00", Offset = "0x9AC3700", VA = "0x189AC4D00", Slot = "80")]
		private void XGKGEXLQVAL(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4690", Offset = "0x9AC3090", VA = "0x189AC4690", Slot = "81")]
		private void QISOUWMKNFU(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3E10", Offset = "0x9AC2810", VA = "0x189AC3E10", Slot = "82")]
		private void JOMZDUXUEPU()
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
		public NfgoCommsNetwork NUXVPHBNXWJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1D40", Offset = "0x9AC0740", VA = "0x189AC1D40")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1F00", Offset = "0x9AC0900", VA = "0x189AC1F00")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2070", Offset = "0x9AC0A70", VA = "0x189AC2070")]
		private void UCGQTEUJWKE(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC2490", Offset = "0x9AC0E90", VA = "0x189AC2490")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class BIZGAMFNFKS
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool ZZOSQWWFQIR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xE28730", Offset = "0xE27130", VA = "0x180E28730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager OBCXUZYMCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager RTYLSIXZSND
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager LLHVYSAWFOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> UCGQTEUJWKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1A40", Offset = "0x9AC0440", VA = "0x189AC1A40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9AC1AF0", Offset = "0x9AC04F0", VA = "0x189AC1AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1C80", Offset = "0x9AC0680", VA = "0x189AC1C80")]
		[RecRoom.NoEngine.Common.Preserve]
		public BIZGAMFNFKS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1C10", Offset = "0x9AC0610", VA = "0x189AC1C10")]
		[BRMSZAJTATI.Root]
		public static void SEQWXXTWQXX(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AC1BA0", Offset = "0x9AC05A0", VA = "0x189AC1BA0")]
		public void PHGIPKZYSBZ(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LLHVYSAWFOA : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float YAPHBNKTAWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate HNAFEVMCCFR;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD159F0", Offset = "0xD143F0", VA = "0x180D159F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD15880", Offset = "0xD14280", VA = "0x180D15880", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9AC21F0", Offset = "0x9AC0BF0", VA = "0x189AC21F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9AC2340", Offset = "0x9AC0D40", VA = "0x189AC2340", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9AC22A0", Offset = "0x9AC0CA0", VA = "0x189AC22A0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9AC23F0", Offset = "0x9AC0DF0", VA = "0x189AC23F0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2100", Offset = "0x9AC0B00", VA = "0x189AC2100", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2100", Offset = "0x9AC0B00", VA = "0x189AC2100", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2180", Offset = "0x9AC0B80", VA = "0x189AC2180")]
		public LLHVYSAWFOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2120", Offset = "0x9AC0B20", VA = "0x189AC2120", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2140", Offset = "0x9AC0B40", VA = "0x189AC2140", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2160", Offset = "0x9AC0B60", VA = "0x189AC2160", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "21")]
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
