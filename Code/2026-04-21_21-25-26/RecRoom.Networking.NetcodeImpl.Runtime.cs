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
		[Cpp2IlInjected.Address(RVA = "0x9ABE560", Offset = "0x9ABCF60", VA = "0x189ABE560", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class JQYRLXCHTHL : CDPRAJEFKDH, MZPAUNRNKBF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class LZFMZGCSGKW : XHRZBUOCUVQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte AXBZVXMCNQM
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int LQBQFLVQZAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xE073A0", Offset = "0xE05DA0", VA = "0x180E073A0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xE073B0", Offset = "0xE05DB0", VA = "0x180E073B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object HGYSOZVKITU
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x92FF3A0", Offset = "0x92FDDA0", VA = "0x1892FF3A0")]
			public LZFMZGCSGKW(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9ABC6B0", Offset = "0x9ABB0B0", VA = "0x189ABC6B0", Slot = "7")]
			public bool YOABBVTNACT(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState PNYJMQKKTEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch IHARAYHUITI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int XXZCOCSUCKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<LZFMZGCSGKW> ZKUSRHDZZNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> OIQPJSFOCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private UNQUCEFHIMW IHDSKYOWBBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private UEKUWOEJGJW WSRYGSHLBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool CXDHHJBSBYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PZNWYZDFTBS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager TGDMTWPXZGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport FYHTVPGNFVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB620", Offset = "0x9ABA020", VA = "0x189ABB620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState FGEGWIEVBFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9ABBF40", Offset = "0x9ABA940", VA = "0x189ABBF40", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9ABC410", Offset = "0x9ABAE10", VA = "0x189ABC410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MKLTQDHSNME
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public UNQUCEFHIMW JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public UEKUWOEJGJW RVCQAXCUSLX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private JYTIDKYVVQE DADXVYVTOEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB760", Offset = "0x9ABA160", VA = "0x189ABB760", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool APJNDBXBMXW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB76A0", Offset = "0x9AB60A0", VA = "0x189AB76A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool QFWQYRJTORK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB76A0", Offset = "0x9AB60A0", VA = "0x189AB76A0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BMGZGIWJJNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xDB1A40", Offset = "0xDB0440", VA = "0x180DB1A40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9AB95F0", Offset = "0x9AB7FF0", VA = "0x189AB95F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception HXNBTWMRZPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD122A0", Offset = "0xD10CA0", VA = "0x180D122A0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int URLLODDDYSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PUXWYEMUEOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9AB76F0", Offset = "0x9AB60F0", VA = "0x189AB76F0", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB0B0", Offset = "0x9AB9AB0", VA = "0x189ABB0B0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HSYGFXFVUKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD11920", Offset = "0xD10320", VA = "0x180D11920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD122C0", Offset = "0xD10CC0", VA = "0x180D122C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double ICDAYHQMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB790", Offset = "0x9ABA190", VA = "0x189ABB790")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double YJYTIKZDJRR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB5D0", Offset = "0x9AB9FD0", VA = "0x189ABB5D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int QMTEWVPMKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA1C0", Offset = "0x9AB8BC0", VA = "0x189ABA1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZEKLDYQHFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6DF0", Offset = "0x9AB57F0", VA = "0x189AB6DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int CDSAGBGGVVX
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB200", Offset = "0x9AB9C00", VA = "0x189ABB200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UTTDOXTMXQW UTISZCHWWAI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA960", Offset = "0x9AB9360", VA = "0x189ABA960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HHCFARZRIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xFCDF20", Offset = "0xFCC920", VA = "0x180FCDF20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9160", Offset = "0x9AB7B60", VA = "0x189AB9160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> UGNYKHPPYVC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9ABBF60", Offset = "0x9ABA960", VA = "0x189ABBF60", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9ABA8B0", Offset = "0x9AB92B0", VA = "0x189ABA8B0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> FTWOSGYQQZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9AB90B0", Offset = "0x9AB7AB0", VA = "0x189AB90B0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9710", Offset = "0x9AB8110", VA = "0x189AB9710", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC490", Offset = "0x9ABAE90", VA = "0x189ABC490")]
		public JQYRLXCHTHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8030", Offset = "0x9AB6A30", VA = "0x189AB8030")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA560", Offset = "0x9AB8F60", VA = "0x189ABA560")]
		private void QEIHCMBSZKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA160", Offset = "0x9AB8B60", VA = "0x189ABA160")]
		private void OUWIWSEKPCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7B00", Offset = "0x9AB6500", VA = "0x189AB7B00")]
		public bool BXNPAQDLKRE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC440", Offset = "0x9ABAE40", VA = "0x189ABC440")]
		public bool YXPDPQTZSDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA110", Offset = "0x9AB8B10", VA = "0x189ABA110")]
		public void OUGZVRFRRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7180", Offset = "0x9AB5B80", VA = "0x189AB7180")]
		public void ALAJUTCNKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9400", Offset = "0x9AB7E00", VA = "0x189AB9400")]
		public void KVMDVSGCMUV(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7870", Offset = "0x9AB6270", VA = "0x189AB7870")]
		public void BVQDRLYHIAP(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9ABBD40", Offset = "0x9ABA740", VA = "0x189ABBD40")]
		public void XEVASJUFEWS(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9A80", Offset = "0x9AB8480", VA = "0x189AB9A80")]
		public void NYKTBLQYXAJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8A50", Offset = "0x9AB7450", VA = "0x189AB8A50")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7E40", Offset = "0x9AB6840", VA = "0x189AB7E40")]
		public int COPIOQMYBAN(XHRZBUOCUVQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7240", Offset = "0x9AB5C40", VA = "0x189AB7240")]
		public bool AMOVTMMCLWN(byte a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9AB85A0", Offset = "0x9AB6FA0", VA = "0x189AB85A0")]
		public bool DHTPXQPMPDR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7C20", Offset = "0x9AB6620", VA = "0x189AB7C20")]
		internal bool BXQDPPFXEED([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9AB91A0", Offset = "0x9AB7BA0", VA = "0x189AB91A0")]
		internal bool IEYSUJKTXRP([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9ABAEE0", Offset = "0x9AB98E0", VA = "0x189ABAEE0")]
		private void REETNKNEOJA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8B40", Offset = "0x9AB7540", VA = "0x189AB8B40")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8C40", Offset = "0x9AB7640", VA = "0x189AB8C40", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9ABBAE0", Offset = "0x9ABA4E0", VA = "0x189ABBAE0")]
		private void WQJMKYXMHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8D90", Offset = "0x9AB7790", VA = "0x189AB8D90")]
		private void FSHSHKISJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB110", Offset = "0x9AB9B10", VA = "0x189ABB110")]
		private void RJMNURUMCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC0F0", Offset = "0x9ABAAF0", VA = "0x189ABC0F0")]
		private void YKQLJOWRXON(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6EF0", Offset = "0x9AB58F0", VA = "0x189AB6EF0")]
		private void ACZCJWYVMPI(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B8BB90", Offset = "0x3B8A590", VA = "0x183B8BB90")]
		private void FIFLKKVKKVM<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AB7740", Offset = "0x9AB6140", VA = "0x189AB7740")]
		private void BKHZHAJVPYD(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8330", Offset = "0x9AB6D30", VA = "0x189AB8330")]
		private void DHJDXPZRFEA(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB730", Offset = "0x9ABA130", VA = "0x189ABB730")]
		private void VPKGINNIBPW(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA9B0", Offset = "0x9AB93B0", VA = "0x189ABA9B0")]
		private void QQPCXUZTTVP(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB7E0", Offset = "0x9ABA1E0", VA = "0x189ABB7E0")]
		private void WCQWOMFOZIP(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9ABB260", Offset = "0x9AB9C60", VA = "0x189ABB260")]
		private void SNSYPSTVJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA3D0", Offset = "0x9AB8DD0", VA = "0x189ABA3D0")]
		private void PAPYBXJIEPS(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA210", Offset = "0x9AB8C10", VA = "0x189ABA210")]
		private void OWIWMSGSAZA(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AB97C0", Offset = "0x9AB81C0", VA = "0x189AB97C0")]
		private void NSOAZFVTISG(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9ABA780", Offset = "0x9AB9180", VA = "0x189ABA780")]
		private void QFABISKIXBY(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AB8450", Offset = "0x9AB6E50", VA = "0x189AB8450")]
		private void DHJDXPZRFEA(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC010", Offset = "0x9ABAA10", VA = "0x189ABC010")]
		private void YHIDKQYPUEA(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9ABBC40", Offset = "0x9ABA640", VA = "0x189ABBC40")]
		private void WZRUWQQVHYS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9D10", Offset = "0x9AB8710", VA = "0x189AB9D10")]
		private void OAXKQCEBIIG(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9190", Offset = "0x9AB7B90", VA = "0x189AB9190")]
		[CompilerGenerated]
		private void HRPQZMDJVNM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class UNQUCEFHIMW : GUPOFWBVNMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private JQYRLXCHTHL PFCHBIVUPOJ;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string YUCKBXTRNQW;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> ZULLOQDMMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int BVVWAUXMYIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string RIWQDIVWNIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt EUBGVURBRAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? EBXZMZENEGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string ZCUILMFMDVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong BGNDIAPXHBW;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int JQXIJSMFSOX
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool NUJNSUHUSQU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xEAE2D0", Offset = "0xEACCD0", VA = "0x180EAE2D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xED9400", Offset = "0xED7E00", VA = "0x180ED9400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NMDFYZPJRWX
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDCC0", Offset = "0x9ABC6C0", VA = "0x189ABDCC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> UWQRXXCDAPB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string KJRFNBIDIXT
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDDC0", Offset = "0x9ABC7C0", VA = "0x189ABDDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int RBKHRQFQMTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDEB0", Offset = "0x9ABC8B0", VA = "0x189ABDEB0", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDD50", Offset = "0x9ABC750", VA = "0x189ABDD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool LGJMTXJYGYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x19FA020", Offset = "0x19F8A20", VA = "0x1819FA020", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x19F9DF0", Offset = "0x19F87F0", VA = "0x1819F9DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool RLTTNNVVRTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDAF0", Offset = "0x9ABC4F0", VA = "0x189ABDAF0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string LAQRTKCMDXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDF00", Offset = "0x9ABC900", VA = "0x189ABDF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string AVMTTNTKGZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9ABDBB0", Offset = "0x9ABC5B0", VA = "0x189ABDBB0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool UWNCFEFIELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object XXZQDHKYTDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD11900", Offset = "0xD10300", VA = "0x180D11900", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong FIVGZSRNCJV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD11940", Offset = "0xD10340", VA = "0x180D11940")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9ABE290", Offset = "0x9ABCC90", VA = "0x189ABE290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE520", Offset = "0x9ABCF20", VA = "0x189ABE520")]
		internal UNQUCEFHIMW(JQYRLXCHTHL a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE4E0", Offset = "0x9ABCEE0", VA = "0x189ABE4E0")]
		internal UNQUCEFHIMW(JQYRLXCHTHL a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE3D0", Offset = "0x9ABCDD0", VA = "0x189ABE3D0")]
		internal UNQUCEFHIMW(JQYRLXCHTHL a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9ABDC10", Offset = "0x9ABC610", VA = "0x189ABDC10", Slot = "16")]
		public bool EBMHYZBAFUV(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9ABE2B0", Offset = "0x9ABCCB0", VA = "0x189ABE2B0")]
		public NetworkedPlayerData YJSDVLCMJVR()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9ABDFA0", Offset = "0x9ABC9A0", VA = "0x189ABDFA0")]
		internal void XNUIWKYNBWP([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class UEKUWOEJGJW : JYTIDKYVVQE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private JQYRLXCHTHL PFCHBIVUPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> LURGEAXJJCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, UNQUCEFHIMW> PRNQDARVZXW;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte ZRLJBDOZLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9ABD910", Offset = "0x9ABC310", VA = "0x189ABD910", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool OFXFRDJZXMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> UWQRXXCDAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public UNQUCEFHIMW[] JXHCCPBYCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public UNQUCEFHIMW[] BZVCCZGULQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UNQUCEFHIMW[] DRLFPQZQTRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD12260", Offset = "0xD10C60", VA = "0x180D12260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public UNQUCEFHIMW[] RURBLRWXGYR
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD122E0", Offset = "0xD10CE0", VA = "0x180D122E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD12290", Offset = "0xD10C90", VA = "0x180D12290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int NOCTBTWTRNP
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xF01E60", Offset = "0xF00860", VA = "0x180F01E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1ADB800", Offset = "0x1ADA200", VA = "0x181ADB800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD960", Offset = "0x9ABC360", VA = "0x189ABD960")]
		public UEKUWOEJGJW(JQYRLXCHTHL a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD470", Offset = "0x9ABBE70", VA = "0x189ABD470", Slot = "8")]
		public bool NFFWBQUUPBY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9ABCDF0", Offset = "0x9ABB7F0", VA = "0x189ABCDF0", Slot = "7")]
		public bool EBMHYZBAFUV(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD2C0", Offset = "0x9ABBCC0", VA = "0x189ABD2C0")]
		internal bool NARVOYDCZWB([In] NetworkedPlayerData playerData, bool a, [Out] UNQUCEFHIMW b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9ABCC50", Offset = "0x9ABB650", VA = "0x189ABCC50")]
		internal void ACEOLHDKCUE(ulong a, [Out] UNQUCEFHIMW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9ABD4D0", Offset = "0x9ABBED0", VA = "0x189ABD4D0")]
		internal void POMMJWWKEKF([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9ABCEA0", Offset = "0x9ABB8A0", VA = "0x189ABCEA0")]
		private void LMLPGMWVYDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class EWRTDVFSXHI : LJMZQOWPPQQ, WHWIROLHRQO, DKXCZOVCSXE, RLWMQWFLYVW, AZZOGUSWEIC, JAGUJUYUPEX, DPEVNBHXBRZ, MZPAUNRNKBF, KUUDBUKJYRA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private JQYRLXCHTHL PFCHBIVUPOJ;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int QMTEWVPMKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6020", Offset = "0x9AB4A20", VA = "0x189AB6020", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int RHHVPGDIADU
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int BRUKMPCKKXM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5920", Offset = "0x9AB4320", VA = "0x189AB5920", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int MKLTQDHSNME
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6260", Offset = "0x9AB4C60", VA = "0x189AB6260", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool SNCZNNOXRIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE23F80", Offset = "0xE22980", VA = "0x180E23F80", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double ICDAYHQMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9AB67E0", Offset = "0x9AB51E0", VA = "0x189AB67E0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ZNRYLBDDSUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9AB61D0", Offset = "0x9AB4BD0", VA = "0x189AB61D0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool QFWQYRJTORK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9AB51D0", Offset = "0x9AB3BD0", VA = "0x189AB51D0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool BMGZGIWJJNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9AB59E0", Offset = "0x9AB43E0", VA = "0x189AB59E0", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5F50", Offset = "0x9AB4950", VA = "0x189AB5F50", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool RZPDNUNVGLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9AB62D0", Offset = "0x9AB4CD0", VA = "0x189AB62D0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6790", Offset = "0x9AB5190", VA = "0x189AB6790", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9AB52C0", Offset = "0x9AB3CC0", VA = "0x189AB52C0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int IBPUESASJST
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6840", Offset = "0x9AB5240", VA = "0x189AB6840", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int OFUWQCBQGUG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6540", Offset = "0x9AB4F40", VA = "0x189AB6540", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public GUPOFWBVNMS YKBSWBFDOBU
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9AB63C0", Offset = "0x9AB4DC0", VA = "0x189AB63C0", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5B90", Offset = "0x9AB4590", VA = "0x189AB5B90", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int ZRLJBDOZLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB65E0", Offset = "0x9AB4FE0", VA = "0x189AB65E0", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string YUCKBXTRNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB68A0", Offset = "0x9AB52A0", VA = "0x189AB68A0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> ZULLOQDMMHX
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5860", Offset = "0x9AB4260", VA = "0x189AB5860", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public UTTDOXTMXQW UTISZCHWWAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6280", Offset = "0x9AB4C80", VA = "0x189AB6280", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool HSYGFXFVUKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9AB61A0", Offset = "0x9AB4BA0", VA = "0x189AB61A0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5B70", Offset = "0x9AB4570", VA = "0x189AB5B70", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float GRPXCNWJYFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12EA760", Offset = "0x12E9160", VA = "0x1812EA760", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AC9DA0", Offset = "0x1AC87A0", VA = "0x181AC9DA0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override CDPRAJEFKDH GUKFHWXZOBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD15610", Offset = "0xD14010", VA = "0x180D15610", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HHCFARZRIKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9AB66F0", Offset = "0x9AB50F0", VA = "0x189AB66F0", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9AB59A0", Offset = "0x9AB43A0", VA = "0x189AB59A0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string ZEKLDYQHFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5090", Offset = "0x9AB3A90", VA = "0x189AB5090", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long VGIKHEWIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9AB69E0", Offset = "0x9AB53E0", VA = "0x189AB69E0", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long WLDUOCHRCAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9AB69F0", Offset = "0x9AB53F0", VA = "0x189AB69F0", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<XHRZBUOCUVQ> XXUPKAJWMAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6310", Offset = "0x9AB4D10", VA = "0x189AB6310", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5550", Offset = "0x9AB3F50", VA = "0x189AB5550", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<GUPOFWBVNMS> ZGBYUVJZSAU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6640", Offset = "0x9AB5040", VA = "0x189AB6640", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AB5E30", Offset = "0x9AB4830", VA = "0x189AB5E30", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5630", Offset = "0x9AB4030", VA = "0x189AB5630")]
		[CXDXQIFYXBD.Root.GameOnly]
		internal static void CXDXQIFYXBD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6A00", Offset = "0x9AB5400", VA = "0x189AB6A00")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public EWRTDVFSXHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5E10", Offset = "0x9AB4810", VA = "0x189AB5E10", Slot = "21")]
		public void KVMDVSGCMUV(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB69B0", Offset = "0x9AB53B0", VA = "0x189AB69B0", Slot = "23")]
		public void XEVASJUFEWS(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5CB0", Offset = "0x9AB46B0", VA = "0x189AB5CB0", Slot = "27")]
		public void JUDXTFCKDSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6430", Offset = "0x9AB4E30", VA = "0x189AB6430", Slot = "47")]
		public bool RSKHSJKJTUW(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5720", Offset = "0x9AB4120", VA = "0x189AB5720", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5750", Offset = "0x9AB4150", VA = "0x189AB5750", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5400", Offset = "0x9AB3E00", VA = "0x189AB5400", Slot = "22")]
		public void BVQDRLYHIAP(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5A20", Offset = "0x9AB4420", VA = "0x189AB5A20", Slot = "75")]
		public GUPOFWBVNMS IFSVABANWGE(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5F70", Offset = "0x9AB4970", VA = "0x189AB5F70", Slot = "74")]
		public GUPOFWBVNMS LSYTJXSXUGW(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6080", Offset = "0x9AB4A80", VA = "0x189AB6080", Slot = "76")]
		public GUPOFWBVNMS OCUQFXFYTLM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5B10", Offset = "0x9AB4510", VA = "0x189AB5B10", Slot = "18")]
		public bool IMSIVTFVUSC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6700", Offset = "0x9AB5100", VA = "0x189AB6700", Slot = "77")]
		public IReadOnlyList<GUPOFWBVNMS> VPMZNBEILYK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5230", Offset = "0x9AB3C30", VA = "0x189AB5230", Slot = "78")]
		public IReadOnlyList<GUPOFWBVNMS> BDEFTIGHDGF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AB56A0", Offset = "0x9AB40A0", VA = "0x189AB56A0", Slot = "45")]
		public bool DHTPXQPMPDR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6450", Offset = "0x9AB4E50", VA = "0x189AB6450", Slot = "20")]
		public void SFNIHUQYGZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9AB51A0", Offset = "0x9AB3BA0", VA = "0x189AB51A0", Slot = "62")]
		public bool AMOVTMMCLWN(byte a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6000", Offset = "0x9AB4A00", VA = "0x189AB6000", Slot = "28")]
		public void NYKTBLQYXAJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5600", Offset = "0x9AB4000", VA = "0x189AB5600", Slot = "30")]
		public int COPIOQMYBAN(XHRZBUOCUVQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5420", Offset = "0x9AB3E20", VA = "0x189AB5420", Slot = "79")]
		public bool BXNPAQDLKRE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5EE0", Offset = "0x9AB48E0", VA = "0x189AB5EE0", Slot = "17")]
		public float LMJDTWQHJHN(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB58C0", Offset = "0x9AB42C0", VA = "0x189AB58C0", Slot = "8")]
		public override void FRKPJZZZTFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9AB52E0", Offset = "0x9AB3CE0", VA = "0x189AB52E0", Slot = "73")]
		public void BNZSPXUUBJG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6020", Offset = "0x9AB4A20", VA = "0x189AB6020", Slot = "87")]
		public int NYXPOAUPOMH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5990", Offset = "0x9AB4390", VA = "0x189AB5990", Slot = "11")]
		private void HENDEEDYVIF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9AB61B0", Offset = "0x9AB4BB0", VA = "0x189AB61B0", Slot = "12")]
		private void OSESFDOBRYK(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6520", Offset = "0x9AB4F20", VA = "0x189AB6520", Slot = "25")]
		private void SRXTAFWHPAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5A10", Offset = "0x9AB4410", VA = "0x189AB5A10", Slot = "26")]
		private void HTRAJHQKSZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AB53F0", Offset = "0x9AB3DF0", VA = "0x189AB53F0", Slot = "31")]
		private void BTWYTUVSLUW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6530", Offset = "0x9AB4F30", VA = "0x189AB6530", Slot = "32")]
		private void TBHOWFCBXSN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6250", Offset = "0x9AB4C50", VA = "0x189AB6250", Slot = "48")]
		private void PPRYXCIIWPG(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5FE0", Offset = "0x9AB49E0", VA = "0x189AB5FE0", Slot = "49")]
		private void LTJHAZFGKHL(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5540", Offset = "0x9AB3F40", VA = "0x189AB5540", Slot = "50")]
		private void BXVWCYXKZLP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6190", Offset = "0x9AB4B90", VA = "0x189AB6190", Slot = "51")]
		private void OJYJBOAXKFA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB61C0", Offset = "0x9AB4BC0", VA = "0x189AB61C0", Slot = "52")]
		private void OUFBPGFGMOA(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5080", Offset = "0x9AB3A80", VA = "0x189AB5080", Slot = "53")]
		private IDisposable ABAMBSTETTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5E00", Offset = "0x9AB4800", VA = "0x189AB5E00", Slot = "54")]
		private bool KMXNIJPJDVA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6180", Offset = "0x9AB4B80", VA = "0x189AB6180", Slot = "55")]
		private void OGAFKIVDJUW(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5A00", Offset = "0x9AB4400", VA = "0x189AB5A00", Slot = "57")]
		private void HQVZBSKUGIG(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5DF0", Offset = "0x9AB47F0", VA = "0x189AB5DF0", Slot = "58")]
		private void KFAJLSVOVWB(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5620", Offset = "0x9AB4020", VA = "0x189AB5620", Slot = "80")]
		private void CVLQQNSGVFO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5850", Offset = "0x9AB4250", VA = "0x189AB5850", Slot = "81")]
		private void EGAHTACFXTJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AB5FF0", Offset = "0x9AB49F0", VA = "0x189AB5FF0", Slot = "82")]
		private void MCJRDWAMYBP()
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
		public NfgoCommsNetwork BEKYIACDQZM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9AB4D00", Offset = "0x9AB3700", VA = "0x189AB4D00")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AB4F10", Offset = "0x9AB3910", VA = "0x189AB4F10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AB4EC0", Offset = "0x9AB38C0", VA = "0x189AB4EC0")]
		private void KWBSGPQZHQV(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ABC6F0", Offset = "0x9ABB0F0", VA = "0x189ABC6F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class FZRUZLOUBUJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool XPMMWIWQKZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD66E30", Offset = "0xD65830", VA = "0x180D66E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xE376D0", Offset = "0xE360D0", VA = "0x180E376D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager TGDMTWPXZGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager XWVQPBLVAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager OYMIBEAVXQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> KWBSGPQZHQV
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6C80", Offset = "0x9AB5680", VA = "0x189AB6C80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9AB6AF0", Offset = "0x9AB54F0", VA = "0x189AB6AF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6D30", Offset = "0x9AB5730", VA = "0x189AB6D30")]
		[RecRoom.NoEngine.Common.Preserve]
		public FZRUZLOUBUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6BA0", Offset = "0x9AB55A0", VA = "0x189AB6BA0")]
		[CXDXQIFYXBD.Root]
		public static void HUETBZQUPBQ(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AB6C10", Offset = "0x9AB5610", VA = "0x189AB6C10")]
		public void PZGBGPIGOTY(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class OYMIBEAVXQN : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float KUOFJGPIVVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate SKHKYTWIWRM;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9ABC8D0", Offset = "0x9ABB2D0", VA = "0x189ABC8D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9ABCA20", Offset = "0x9ABB420", VA = "0x189ABCA20", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9ABC980", Offset = "0x9ABB380", VA = "0x189ABC980", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9ABCAD0", Offset = "0x9ABB4D0", VA = "0x189ABCAD0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC7E0", Offset = "0x9ABB1E0", VA = "0x189ABC7E0", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC7E0", Offset = "0x9ABB1E0", VA = "0x189ABC7E0", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC860", Offset = "0x9ABB260", VA = "0x189ABC860")]
		public OYMIBEAVXQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC800", Offset = "0x9ABB200", VA = "0x189ABC800", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC820", Offset = "0x9ABB220", VA = "0x189ABC820", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9ABC840", Offset = "0x9ABB240", VA = "0x189ABC840", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "21")]
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
