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
		[Cpp2IlInjected.Address(RVA = "0x83820A0", Offset = "0x83814A0", VA = "0x1883820A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class KWFFBGASKQI : ARVWTXZMNAK, BPRDYKJBWMW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class CUTJSXSIABT : PTKTLSUVJWP
		{
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public object this[byte key]
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0x8378DD0", Offset = "0x83781D0", VA = "0x188378DD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public byte LKVKMZDDSZJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public int GQNZJUUOZCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xC4E2B0", Offset = "0xC4D6B0", VA = "0x180C4E2B0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCDF260", Offset = "0xCDE660", VA = "0x180CDF260")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public object ZGGPRZOUJQR
			{
				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7C247C0", Offset = "0x7C23BC0", VA = "0x187C247C0")]
			public CUTJSXSIABT(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8378D90", Offset = "0x8378190", VA = "0x188378D90", Slot = "8")]
			public bool NCIRIRZXKOC(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState KFYSFVVWASF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch LPKFHYSJMNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int JSUIEAZLMTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<CUTJSXSIABT> UGHAPRNKCGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> JXLAKEXTUCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private JYRYZHEJBPF RUILYLIMWRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private MPWDKZDVBCV SQWCGYROUXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool RTXDBMYOFMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool FJAKBIWUPXZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager WIKMMXPLBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport PQEPAKWSRQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x837C000", Offset = "0x837B400", VA = "0x18837C000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState OUMBUQEHUDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x837CF80", Offset = "0x837C380", VA = "0x18837CF80", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x837C110", Offset = "0x837B510", VA = "0x18837C110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int YRRIJSHTVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public JYRYZHEJBPF NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public MPWDKZDVBCV NWPGHNHRIAI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private ZPFBQSWCPET ZVATAVZSTCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool ONWUNJMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x837E510", Offset = "0x837D910", VA = "0x18837E510", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool NWVIMDJTJBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x837A530", Offset = "0x8379930", VA = "0x18837A530", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JMORIRTNXBT
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x837A530", Offset = "0x8379930", VA = "0x18837A530", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool VIRVGMSUTHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x837A530", Offset = "0x8379930", VA = "0x18837A530", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool ZZIASLAHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB175E0", Offset = "0xB169E0", VA = "0x180B175E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x837ADF0", Offset = "0x837A1F0", VA = "0x18837ADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Exception WIIJITCGTCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int RJCPEGHZTMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool BJCGUHHAEYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x837C480", Offset = "0x837B880", VA = "0x18837C480", Slot = "17")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x837DB70", Offset = "0x837CF70", VA = "0x18837DB70", Slot = "18")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OHMMNRCDRVV
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F30", Offset = "0xAA9330", VA = "0x180AA9F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xAAA040", Offset = "0xAA9440", VA = "0x180AAA040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double DLFQJUKJJJB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x837C140", Offset = "0x837B540", VA = "0x18837C140")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public double XCMQXOPWJAM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x837D3C0", Offset = "0x837C7C0", VA = "0x18837D3C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int UDBZSSXKPRG
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x837DA00", Offset = "0x837CE00", VA = "0x18837DA00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string SNNFXQPUAJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x837C740", Offset = "0x837BB40", VA = "0x18837C740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public int PQTSLKXZZKC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x837E760", Offset = "0x837DB60", VA = "0x18837E760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public CALGTGVEOGB DKHHOJRBOMT
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x837C4D0", Offset = "0x837B8D0", VA = "0x18837C4D0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool ENIHPCWSDHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xCAAC50", Offset = "0xCAA050", VA = "0x180CAAC50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x837B670", Offset = "0x837AA70", VA = "0x18837B670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> KFBQOYMPXYL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8379E20", Offset = "0x8379220", VA = "0x188379E20", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x837B010", Offset = "0x837A410", VA = "0x18837B010", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> JJTJLMPWLYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x837E0C0", Offset = "0x837D4C0", VA = "0x18837E0C0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x837F050", Offset = "0x837E450", VA = "0x18837F050", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x837F100", Offset = "0x837E500", VA = "0x18837F100")]
		public KWFFBGASKQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x837A8D0", Offset = "0x8379CD0", VA = "0x18837A8D0")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x837ABD0", Offset = "0x8379FD0", VA = "0x18837ABD0")]
		private void DCNSGBEIYGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x837A240", Offset = "0x8379640", VA = "0x18837A240")]
		private void AVCZMFWEPST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x837DA50", Offset = "0x837CE50", VA = "0x18837DA50")]
		public bool QYBADYZNXZN(JCSDFORPEFX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x837E070", Offset = "0x837D470", VA = "0x18837E070")]
		public bool SLVZOMDOWLS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x837E020", Offset = "0x837D420", VA = "0x18837E020")]
		public void SHGIEISWGLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x837A580", Offset = "0x8379980", VA = "0x18837A580")]
		public void CPOXJERPZLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x837E570", Offset = "0x837D970", VA = "0x18837E570")]
		public void VEVYLWJEIPI(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x837A2A0", Offset = "0x83796A0", VA = "0x18837A2A0")]
		public void BZXONOCAKBA(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8379ED0", Offset = "0x83792D0", VA = "0x188379ED0")]
		public void AMCPPCNPMSH(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x837A640", Offset = "0x8379A40", VA = "0x18837A640")]
		public void CQVTSUWTJSM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x837B0C0", Offset = "0x837A4C0", VA = "0x18837B0C0")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x837E170", Offset = "0x837D570", VA = "0x18837E170")]
		public int TCSLSNADBIG(PTKTLSUVJWP a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x837DBD0", Offset = "0x837CFD0", VA = "0x18837DBD0")]
		public bool RaiseEvent(byte eventCode, object eventContent, FRDJWLZNOWA raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x837B1C0", Offset = "0x837A5C0", VA = "0x18837B1C0")]
		public bool ENYSHZTEINW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x837C840", Offset = "0x837BC40", VA = "0x18837C840")]
		internal bool OGRZVRGWQHS([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x837D410", Offset = "0x837C810", VA = "0x18837D410")]
		internal bool PYDMXFMNINU([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x837D230", Offset = "0x837C630", VA = "0x18837D230")]
		private void PLAJVQIWTLX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x837C520", Offset = "0x837B920", VA = "0x18837C520")]
		public void LeaveRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x837B1B0", Offset = "0x837A5B0", VA = "0x18837B1B0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x837EB80", Offset = "0x837DF80", VA = "0x18837EB80")]
		private void YLECYNYIYVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x837B7C0", Offset = "0x837ABC0", VA = "0x18837B7C0")]
		private void GYBOWJJSQHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x837D670", Offset = "0x837CA70", VA = "0x18837D670")]
		private void QBXXTLLCAHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x837D760", Offset = "0x837CB60", VA = "0x18837D760")]
		private void QHYBNKCITGK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x837CFA0", Offset = "0x837C3A0", VA = "0x18837CFA0")]
		private void PJFQZKCZUJJ(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3720510", Offset = "0x371F910", VA = "0x183720510")]
		private void LEBKTRVBDBJ<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x837C530", Offset = "0x837B930", VA = "0x18837C530")]
		private void MWFTIWDOAKS(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x837BD90", Offset = "0x837B190", VA = "0x18837BD90")]
		private void HYBGUAGITID(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x837E540", Offset = "0x837D940", VA = "0x18837E540")]
		private void UUTWTZYOULR(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x837CA60", Offset = "0x837BE60", VA = "0x18837CA60")]
		private void OXFZUOXGXKQ(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x837C190", Offset = "0x837B590", VA = "0x18837C190")]
		private void LGSWPAWFKYE(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x837ECE0", Offset = "0x837E0E0", VA = "0x18837ECE0")]
		private void ZIDGQRIWUUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x837A0C0", Offset = "0x83794C0", VA = "0x18837A0C0")]
		private void AOCQFJKTHGP(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x837E360", Offset = "0x837D760", VA = "0x18837E360")]
		private void TLKVLTTTQHT(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x837BAE0", Offset = "0x837AEE0", VA = "0x18837BAE0")]
		private void HQMROSCSVNL(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x837B6A0", Offset = "0x837AAA0", VA = "0x18837B6A0")]
		private void FXZEKUHMQFP(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x837BEB0", Offset = "0x837B2B0", VA = "0x18837BEB0")]
		private void HYBGUAGITID(CUTJSXSIABT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x837C660", Offset = "0x837BA60", VA = "0x18837C660")]
		private void NCRGIFZKACP(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x837AF10", Offset = "0x837A310", VA = "0x18837AF10")]
		private void DTCNRSOENRT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x837E790", Offset = "0x837DB90", VA = "0x18837E790")]
		private void YIVQYVIWKNT(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x837ADE0", Offset = "0x837A1E0", VA = "0x18837ADE0")]
		[CompilerGenerated]
		private void DKMPHTDLEEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JYRYZHEJBPF : JCSDFORPEFX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private KWFFBGASKQI TOEMLHSESEU;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string YNADGOKJOIP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> GJGXGVUBWLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int FFBEIYZKQQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string NKLRHKHEDGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt RAMUHEUPNYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? JKLSJHRWEYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string ANJFKZGMMYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong YPEBOBUHGER;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int JRKPARUUIDY
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GDYUSVBIBZL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xBC0680", Offset = "0xBBFA80", VA = "0x180BC0680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xBC0B60", Offset = "0xBBFF60", VA = "0x180BC0B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool XOESREZGSQI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8379680", Offset = "0x8378A80", VA = "0x188379680", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Dictionary<object, object> EHYLMOOHJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string OSCBNFQQUXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8379BA0", Offset = "0x8378FA0", VA = "0x188379BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int LJBAHEEJJST
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8379AA0", Offset = "0x8378EA0", VA = "0x188379AA0", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x83793B0", Offset = "0x83787B0", VA = "0x1883793B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool RUNXODOPFLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x16C50A0", Offset = "0x16C44A0", VA = "0x1816C50A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x16C5090", Offset = "0x16C4490", VA = "0x1816C5090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool QDQRFQHZMTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8379480", Offset = "0x8378880", VA = "0x188379480", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string NWKBKSJEXZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8379A00", Offset = "0x8378E00", VA = "0x188379A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string CLHMIRDUYNC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8379420", Offset = "0x8378820", VA = "0x188379420", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool SELXGRDRVSX
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public object HABLDYMKHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal ulong ZYHUDWNTQUY
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8379540", Offset = "0x8378940", VA = "0x188379540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8379DA0", Offset = "0x83791A0", VA = "0x188379DA0")]
		internal JYRYZHEJBPF(KWFFBGASKQI a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8379DE0", Offset = "0x83791E0", VA = "0x188379DE0")]
		internal JYRYZHEJBPF(KWFFBGASKQI a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8379C90", Offset = "0x8379090", VA = "0x188379C90")]
		internal JYRYZHEJBPF(KWFFBGASKQI a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8379AF0", Offset = "0x8378EF0", VA = "0x188379AF0", Slot = "16")]
		public bool PENZUSGNVZO(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8379560", Offset = "0x8378960", VA = "0x188379560")]
		public NetworkedPlayerData EDARPOQUCTM()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8379710", Offset = "0x8378B10", VA = "0x188379710")]
		internal void GXNARBSWJZA([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class MPWDKZDVBCV : ZPFBQSWCPET
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KWFFBGASKQI TOEMLHSESEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> GDFSXTTRVER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, JYRYZHEJBPF> MRTILSHCXBN;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string NSNROSXPJBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8380D60", Offset = "0x8380160", VA = "0x188380D60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public byte BMLDBTQEMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8381620", Offset = "0x8380A20", VA = "0x188381620", Slot = "5")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool QAHKCLAUBNX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Dictionary<object, object> EHYLMOOHJQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public JYRYZHEJBPF[] ZOSEENNQUPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JYRYZHEJBPF[] YHCNVOBWPEG
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public JYRYZHEJBPF[] MEYYKLSYGBU
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public JYRYZHEJBPF[] EBRLUAJBHPU
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int TVZKWIROTQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xBB86C0", Offset = "0xBB7AC0", VA = "0x180BB86C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x175B160", Offset = "0x175A560", VA = "0x18175B160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8381A60", Offset = "0x8380E60", VA = "0x188381A60")]
		public MPWDKZDVBCV(KWFFBGASKQI a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8380F40", Offset = "0x8380340", VA = "0x188380F40", Slot = "9")]
		public bool LXXKPLICIZN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8380FA0", Offset = "0x83803A0", VA = "0x188380FA0", Slot = "8")]
		public bool PENZUSGNVZO(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8380D90", Offset = "0x8380190", VA = "0x188380D90")]
		internal bool BTRIQMONQYQ([In] NetworkedPlayerData playerData, bool a, [Out] JYRYZHEJBPF b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8381050", Offset = "0x8380450", VA = "0x188381050")]
		internal void RCMBXYRPKZZ(ulong a, [Out] JYRYZHEJBPF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83811E0", Offset = "0x83805E0", VA = "0x1883811E0")]
		internal void RSLXHRXTRKM([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8381670", Offset = "0x8380A70", VA = "0x188381670")]
		private void YCAGDCSSBLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class LZVXZUHPSAZ : PKRKHBPMELJ, HFLLGBMWIHF, NEKBGPYAQCD, VMVFFWRLBCX, UCPYWEKSTPP, OVQHBDANVOS, FRBYIYMCMFU, BPRDYKJBWMW, CYZDKSSLZID, TMSLSNNXNHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private KWFFBGASKQI TOEMLHSESEU;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int UDBZSSXKPRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x837F6A0", Offset = "0x837EAA0", VA = "0x18837F6A0", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public int WJFUMRPIWHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public int QRYUFTFUHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8380A00", Offset = "0x837FE00", VA = "0x188380A00", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int YRRIJSHTVEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x26C5EB0", Offset = "0x26C52B0", VA = "0x1826C5EB0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool FGICFREIOZT
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xBAA9D0", Offset = "0xBA9DD0", VA = "0x180BAA9D0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public double DLFQJUKJJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x837FA50", Offset = "0x837EE50", VA = "0x18837FA50", Slot = "35")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public int BGTIJWDZDZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x837F510", Offset = "0x837E910", VA = "0x18837F510", Slot = "36")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool XZLSCFLCCRG
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x2038AF0", Offset = "0x2037EF0", VA = "0x182038AF0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool NWVIMDJTJBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x837F5B0", Offset = "0x837E9B0", VA = "0x18837F5B0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool JMORIRTNXBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x837F5B0", Offset = "0x837E9B0", VA = "0x18837F5B0", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool ZZIASLAHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x837FE40", Offset = "0x837F240", VA = "0x18837FE40", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x837F700", Offset = "0x837EB00", VA = "0x18837F700", Slot = "47")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool PLOCWNODDGX
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8380480", Offset = "0x837F880", VA = "0x188380480", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool ONWUNJMGJPE
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8380A60", Offset = "0x837FE60", VA = "0x188380A60", Slot = "49")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public object SFOORVFRGKG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130", Slot = "50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public JCSDFORPEFX NYHENYQESVW
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x837FA10", Offset = "0x837EE10", VA = "0x18837FA10", Slot = "73")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int GJGTCQYWBXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x837FEE0", Offset = "0x837F2E0", VA = "0x18837FEE0", Slot = "74")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public int WKNGKDGQVXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8380900", Offset = "0x837FD00", VA = "0x188380900", Slot = "75")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public JCSDFORPEFX PQXGPXPTXLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x837F880", Offset = "0x837EC80", VA = "0x18837F880", Slot = "76")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool ZCQMDRLXERN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x83807B0", Offset = "0x837FBB0", VA = "0x1883807B0", Slot = "77")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int BMLDBTQEMLQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x83809A0", Offset = "0x837FDA0", VA = "0x1883809A0", Slot = "78")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string YNADGOKJOIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x837FCD0", Offset = "0x837F0D0", VA = "0x18837FCD0", Slot = "79")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public Func<string, string> GJGXGVUBWLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x837F8F0", Offset = "0x837ECF0", VA = "0x18837F8F0", Slot = "80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CALGTGVEOGB DKHHOJRBOMT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x837FE60", Offset = "0x837F260", VA = "0x18837FE60", Slot = "91")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool OHMMNRCDRVV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8380220", Offset = "0x837F620", VA = "0x188380220", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x837FC10", Offset = "0x837F010", VA = "0x18837FC10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override float WYOSAUQGGQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB22780", Offset = "0xB21B80", VA = "0x180B22780", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xB22450", Offset = "0xB21850", VA = "0x180B22450", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override ARVWTXZMNAK YUCPQMFGHHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool ENIHPCWSDHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8380C00", Offset = "0x8380000", VA = "0x188380C00", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x837F830", Offset = "0x837EC30", VA = "0x18837F830", Slot = "38")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string SNNFXQPUAJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8380000", Offset = "0x837F400", VA = "0x188380000", Slot = "92")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public long GXPZYTBXPXU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x837F820", Offset = "0x837EC20", VA = "0x18837F820", Slot = "93")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public long QECJIEKLOND
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8380C20", Offset = "0x8380020", VA = "0x188380C20", Slot = "94")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<ARVWTXZMNAK, ARVWTXZMNAK> GYBWVDXKMMU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x837F940", Offset = "0x837ED40", VA = "0x18837F940", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8380290", Offset = "0x837F690", VA = "0x188380290", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<PTKTLSUVJWP> BEMKGLENBOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8380AD0", Offset = "0x837FED0", VA = "0x188380AD0", Slot = "68")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8380C30", Offset = "0x8380030", VA = "0x188380C30", Slot = "69")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JCSDFORPEFX> FQFOLDMOBXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x837FF40", Offset = "0x837F340", VA = "0x18837FF40", Slot = "71")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x837F360", Offset = "0x837E760", VA = "0x18837F360", Slot = "72")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x837F630", Offset = "0x837EA30", VA = "0x18837F630")]
		[CVOOPLRRRUK.Root.GameOnly]
		internal static void CVOOPLRRRUK(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8380CF0", Offset = "0x83800F0", VA = "0x188380CF0")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public LZVXZUHPSAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8380AB0", Offset = "0x837FEB0", VA = "0x188380AB0", Slot = "21")]
		public void VEVYLWJEIPI(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x837F320", Offset = "0x837E720", VA = "0x18837F320", Slot = "23")]
		public void AMCPPCNPMSH(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x837FAD0", Offset = "0x837EED0", VA = "0x18837FAD0", Slot = "27")]
		public void KLJJDTVZMDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x837FA30", Offset = "0x837EE30", VA = "0x18837FA30", Slot = "56")]
		public bool INRRGWGYOMN(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x837F720", Offset = "0x837EB20", VA = "0x18837F720", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x837F750", Offset = "0x837EB50", VA = "0x18837F750", Slot = "55")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x837F590", Offset = "0x837E990", VA = "0x18837F590", Slot = "22")]
		public void BZXONOCAKBA(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8380520", Offset = "0x837F920", VA = "0x188380520", Slot = "83")]
		public JCSDFORPEFX RVWUFLTWTDT(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8380B80", Offset = "0x837FF80", VA = "0x188380B80", Slot = "82")]
		public JCSDFORPEFX VQEGFVAHVPZ(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x837F410", Offset = "0x837E810", VA = "0x18837F410", Slot = "84")]
		public JCSDFORPEFX BIKNLKOXTOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8380230", Offset = "0x837F630", VA = "0x188380230", Slot = "18")]
		public bool PNVHEKUVZRR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x837FC30", Offset = "0x837F030", VA = "0x18837FC30", Slot = "85")]
		public IReadOnlyList<JCSDFORPEFX> LANSCTINBBF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8380720", Offset = "0x837FB20", VA = "0x188380720", Slot = "86")]
		public IReadOnlyList<JCSDFORPEFX> SLDKIXECHYQ(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x837F7A0", Offset = "0x837EBA0", VA = "0x18837F7A0", Slot = "54")]
		public bool ENYSHZTEINW(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x837FEB0", Offset = "0x837F2B0", VA = "0x18837FEB0", Slot = "53")]
		public bool LeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8380610", Offset = "0x837FA10", VA = "0x188380610", Slot = "20")]
		public void RXTOUJSLUVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83806E0", Offset = "0x837FAE0", VA = "0x1883806E0", Slot = "70")]
		public bool RaiseEvent(byte eventCode, object eventContent, FRDJWLZNOWA raiseEventOptions, RRNetworkDelivery networkDelivery)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x837F610", Offset = "0x837EA10", VA = "0x18837F610", Slot = "28")]
		public void CQVTSUWTJSM(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x83808D0", Offset = "0x837FCD0", VA = "0x1883808D0", Slot = "30")]
		public int TCSLSNADBIG(PTKTLSUVJWP a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "45")]
		public void NXUWSZAGQKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8380350", Offset = "0x837F750", VA = "0x188380350", Slot = "87")]
		public bool QYBADYZNXZN(JCSDFORPEFX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "34")]
		public void CCLXSXYAPTT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x837FDD0", Offset = "0x837F1D0", VA = "0x18837FDD0", Slot = "17")]
		public float LMVCLTGAJRK(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83804C0", Offset = "0x837F8C0", VA = "0x1883804C0", Slot = "8")]
		public override void RQAGPEKYIRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8380110", Offset = "0x837F510", VA = "0x188380110", Slot = "81")]
		public void OJJNJISBRRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x837F6A0", Offset = "0x837EAA0", VA = "0x18837F6A0", Slot = "95")]
		public int DIEKMYBPXDQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8380710", Offset = "0x837FB10", VA = "0x188380710", Slot = "11")]
		private void SEEHIZYDXLC(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x837F350", Offset = "0x837E750", VA = "0x18837F350", Slot = "12")]
		private void AYDFGPRRHBL(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8380C10", Offset = "0x8380010", VA = "0x188380C10", Slot = "25")]
		private void ZAAKCIGXHCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8380470", Offset = "0x837F870", VA = "0x188380470", Slot = "26")]
		private void RGLHBSQYRSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x837FCC0", Offset = "0x837F0C0", VA = "0x18837FCC0", Slot = "31")]
		private void LENDHXGFIHN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x837FAC0", Offset = "0x837EEC0", VA = "0x18837FAC0", Slot = "32")]
		private void KENWKVFOPDI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83808F0", Offset = "0x837FCF0", VA = "0x1883808F0", Slot = "57")]
		private void TCVGIMOWQEF(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8380A50", Offset = "0x837FE50", VA = "0x188380A50", Slot = "58")]
		private void USVAVZGPSWK(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8380A40", Offset = "0x837FE40", VA = "0x188380A40", Slot = "59")]
		private void UABNBZWYYJM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x837F780", Offset = "0x837EB80", VA = "0x18837F780", Slot = "60")]
		private void EAPGJASOVHH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x837FA00", Offset = "0x837EE00", VA = "0x18837FA00", Slot = "61")]
		private void HXAPQQROCIV(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x837F9F0", Offset = "0x837EDF0", VA = "0x18837F9F0", Slot = "62")]
		private IDisposable HGDGOZHGMAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x837F790", Offset = "0x837EB90", VA = "0x18837F790", Slot = "63")]
		private bool EINIASDXBCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8380BF0", Offset = "0x837FFF0", VA = "0x188380BF0", Slot = "64")]
		private void WDBWOEUANBH(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8380CE0", Offset = "0x83800E0", VA = "0x188380CE0", Slot = "66")]
		private void ZVBZRKXXGQV(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x837F870", Offset = "0x837EC70", VA = "0x18837F870", Slot = "67")]
		private void FLVFRUUUGYA(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x837FAB0", Offset = "0x837EEB0", VA = "0x18837FAB0", Slot = "88")]
		private void KCKUBSFMULB(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x837FFF0", Offset = "0x837F3F0", VA = "0x18837FFF0", Slot = "89")]
		private void NHNUMPDRRHY(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8380340", Offset = "0x837F740", VA = "0x188380340", Slot = "90")]
		private void QPTIKUVXWBQ()
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
		public NfgoCommsNetwork XEUJCPHCRMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8378E10", Offset = "0x8378210", VA = "0x188378E10")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8378FD0", Offset = "0x83783D0", VA = "0x188378FD0")]
		private void FNYWDMHAOMY(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
		[Cpp2IlInjected.Address(RVA = "0x8381BF0", Offset = "0x8380FF0", VA = "0x188381BF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class QLXAFCQSEAS
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool BRKLQJNZCCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAF8E00", Offset = "0xAF8200", VA = "0x180AF8E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB22470", Offset = "0xB21870", VA = "0x180B22470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public NetworkManager WIKMMXPLBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public NetworkManager CSHUUKZRYJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public INetworkManager INNQOQBUAZG
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<NetworkManager, bool> FNYWDMHAOMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8381CE0", Offset = "0x83810E0", VA = "0x188381CE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8381D90", Offset = "0x8381190", VA = "0x188381D90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8381F20", Offset = "0x8381320", VA = "0x188381F20")]
		[RecRoom.NoEngine.Common.Preserve]
		public QLXAFCQSEAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8381EB0", Offset = "0x83812B0", VA = "0x188381EB0")]
		[CVOOPLRRRUK.Root]
		public static void UIHNUDZTDIZ(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8381E40", Offset = "0x8381240", VA = "0x188381E40")]
		public void RMEATNQXWED(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class INNQOQBUAZG : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float SXQRAIASTXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private CustomMessagingManager.HandleNamedMessageDelegate HLORJKGOHBV;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x8379110", Offset = "0x8378510", VA = "0x188379110", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x8379260", Offset = "0x8378660", VA = "0x188379260", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x83791C0", Offset = "0x83785C0", VA = "0x1883791C0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8379310", Offset = "0x8378710", VA = "0x188379310", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8379020", Offset = "0x8378420", VA = "0x188379020", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8379020", Offset = "0x8378420", VA = "0x188379020", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x83790A0", Offset = "0x83784A0", VA = "0x1883790A0")]
		public INNQOQBUAZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8379040", Offset = "0x8378440", VA = "0x188379040", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8379060", Offset = "0x8378460", VA = "0x188379060", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8379080", Offset = "0x8378480", VA = "0x188379080", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "21")]
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
