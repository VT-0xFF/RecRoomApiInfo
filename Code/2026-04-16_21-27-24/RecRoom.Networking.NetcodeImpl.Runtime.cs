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
		[Cpp2IlInjected.Address(RVA = "0x993B4D0", Offset = "0x993A2D0", VA = "0x18993B4D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD3CC00", Offset = "0xD3BA00", VA = "0x180D3CC00", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xE0DF60", Offset = "0xE0CD60", VA = "0x180E0DF60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int LQBQFLVQZAE
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xDDD310", Offset = "0xDDC110", VA = "0x180DDD310")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object HGYSOZVKITU
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCE8270", Offset = "0xCE7070", VA = "0x180CE8270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x917EAD0", Offset = "0x917D8D0", VA = "0x18917EAD0")]
			public LZFMZGCSGKW(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9939620", Offset = "0x9938420", VA = "0x189939620", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport FYHTVPGNFVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9938590", Offset = "0x9937390", VA = "0x189938590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState FGEGWIEVBFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9938EB0", Offset = "0x9937CB0", VA = "0x189938EB0", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9939380", Offset = "0x9938180", VA = "0x189939380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int MKLTQDHSNME
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BE0", Offset = "0xCE79E0", VA = "0x180CE8BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public UNQUCEFHIMW JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public UEKUWOEJGJW RVCQAXCUSLX
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private JYTIDKYVVQE DADXVYVTOEA
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x99386D0", Offset = "0x99374D0", VA = "0x1899386D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool APJNDBXBMXW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9934610", Offset = "0x9933410", VA = "0x189934610", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool QFWQYRJTORK
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9934610", Offset = "0x9933410", VA = "0x189934610", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BMGZGIWJJNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD87740", Offset = "0xD86540", VA = "0x180D87740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9936560", Offset = "0x9935360", VA = "0x189936560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception HXNBTWMRZPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCE7940", Offset = "0xCE6740", VA = "0x180CE7940", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCE82A0", Offset = "0xCE70A0", VA = "0x180CE82A0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int URLLODDDYSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PUXWYEMUEOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9934660", Offset = "0x9933460", VA = "0x189934660", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9938020", Offset = "0x9936E20", VA = "0x189938020", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HSYGFXFVUKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCE7920", Offset = "0xCE6720", VA = "0x180CE7920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCE82C0", Offset = "0xCE70C0", VA = "0x180CE82C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double ICDAYHQMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9938700", Offset = "0x9937500", VA = "0x189938700")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double YJYTIKZDJRR
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9938540", Offset = "0x9937340", VA = "0x189938540")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int QMTEWVPMKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9937130", Offset = "0x9935F30", VA = "0x189937130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZEKLDYQHFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9933D60", Offset = "0x9932B60", VA = "0x189933D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int CDSAGBGGVVX
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9938170", Offset = "0x9936F70", VA = "0x189938170")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public UTTDOXTMXQW UTISZCHWWAI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x99378D0", Offset = "0x99366D0", VA = "0x1899378D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HHCFARZRIKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF9E8F0", Offset = "0xF9D6F0", VA = "0x180F9E8F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99360D0", Offset = "0x9934ED0", VA = "0x1899360D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> UGNYKHPPYVC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9938ED0", Offset = "0x9937CD0", VA = "0x189938ED0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9937820", Offset = "0x9936620", VA = "0x189937820", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> FTWOSGYQQZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9936020", Offset = "0x9934E20", VA = "0x189936020", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9936680", Offset = "0x9935480", VA = "0x189936680", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9939400", Offset = "0x9938200", VA = "0x189939400")]
		public JQYRLXCHTHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9934FA0", Offset = "0x9933DA0", VA = "0x189934FA0")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99374D0", Offset = "0x99362D0", VA = "0x1899374D0")]
		private void QEIHCMBSZKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99370D0", Offset = "0x9935ED0", VA = "0x1899370D0")]
		private void OUWIWSEKPCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9934A70", Offset = "0x9933870", VA = "0x189934A70")]
		public bool BXNPAQDLKRE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99393B0", Offset = "0x99381B0", VA = "0x1899393B0")]
		public bool YXPDPQTZSDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9937080", Offset = "0x9935E80", VA = "0x189937080")]
		public void OUGZVRFRRII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99340F0", Offset = "0x9932EF0", VA = "0x1899340F0")]
		public void ALAJUTCNKJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9936370", Offset = "0x9935170", VA = "0x189936370")]
		public void KVMDVSGCMUV(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99347E0", Offset = "0x99335E0", VA = "0x1899347E0")]
		public void BVQDRLYHIAP(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9938CB0", Offset = "0x9937AB0", VA = "0x189938CB0")]
		public void XEVASJUFEWS(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99369F0", Offset = "0x99357F0", VA = "0x1899369F0")]
		public void NYKTBLQYXAJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99359C0", Offset = "0x99347C0", VA = "0x1899359C0")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9934DB0", Offset = "0x9933BB0", VA = "0x189934DB0")]
		public int COPIOQMYBAN(XHRZBUOCUVQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99341B0", Offset = "0x9932FB0", VA = "0x1899341B0")]
		public bool AMOVTMMCLWN(byte a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9935510", Offset = "0x9934310", VA = "0x189935510")]
		public bool DHTPXQPMPDR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9934B90", Offset = "0x9933990", VA = "0x189934B90")]
		internal bool BXQDPPFXEED([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9936110", Offset = "0x9934F10", VA = "0x189936110")]
		internal bool IEYSUJKTXRP([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9937E50", Offset = "0x9936C50", VA = "0x189937E50")]
		private void REETNKNEOJA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9935AB0", Offset = "0x99348B0", VA = "0x189935AB0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9935BB0", Offset = "0x99349B0", VA = "0x189935BB0", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9938A50", Offset = "0x9937850", VA = "0x189938A50")]
		private void WQJMKYXMHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9935D00", Offset = "0x9934B00", VA = "0x189935D00")]
		private void FSHSHKISJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9938080", Offset = "0x9936E80", VA = "0x189938080")]
		private void RJMNURUMCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9939060", Offset = "0x9937E60", VA = "0x189939060")]
		private void YKQLJOWRXON(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9933E60", Offset = "0x9932C60", VA = "0x189933E60")]
		private void ACZCJWYVMPI(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B45DD0", Offset = "0x3B44BD0", VA = "0x183B45DD0")]
		private void FIFLKKVKKVM<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99346B0", Offset = "0x99334B0", VA = "0x1899346B0")]
		private void BKHZHAJVPYD(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99352A0", Offset = "0x99340A0", VA = "0x1899352A0")]
		private void DHJDXPZRFEA(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x99386A0", Offset = "0x99374A0", VA = "0x1899386A0")]
		private void VPKGINNIBPW(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9937920", Offset = "0x9936720", VA = "0x189937920")]
		private void QQPCXUZTTVP(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9938750", Offset = "0x9937550", VA = "0x189938750")]
		private void WCQWOMFOZIP(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99381D0", Offset = "0x9936FD0", VA = "0x1899381D0")]
		private void SNSYPSTVJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9937340", Offset = "0x9936140", VA = "0x189937340")]
		private void PAPYBXJIEPS(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9937180", Offset = "0x9935F80", VA = "0x189937180")]
		private void OWIWMSGSAZA(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9936730", Offset = "0x9935530", VA = "0x189936730")]
		private void NSOAZFVTISG(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99376F0", Offset = "0x99364F0", VA = "0x1899376F0")]
		private void QFABISKIXBY(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99353C0", Offset = "0x99341C0", VA = "0x1899353C0")]
		private void DHJDXPZRFEA(LZFMZGCSGKW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9938F80", Offset = "0x9937D80", VA = "0x189938F80")]
		private void YHIDKQYPUEA(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9938BB0", Offset = "0x99379B0", VA = "0x189938BB0")]
		private void WZRUWQQVHYS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9936C80", Offset = "0x9935A80", VA = "0x189936C80")]
		private void OAXKQCEBIIG(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9936100", Offset = "0x9934F00", VA = "0x189936100")]
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
			[Cpp2IlInjected.Address(RVA = "0xCED330", Offset = "0xCEC130", VA = "0x180CED330", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool NUJNSUHUSQU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xE8E790", Offset = "0xE8D590", VA = "0x180E8E790", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xEB8230", Offset = "0xEB7030", VA = "0x180EB8230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool NMDFYZPJRWX
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x993AC30", Offset = "0x9939A30", VA = "0x18993AC30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> UWQRXXCDAPB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x993AD30", Offset = "0x9939B30", VA = "0x18993AD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int RBKHRQFQMTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x993AE20", Offset = "0x9939C20", VA = "0x18993AE20", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x993ACC0", Offset = "0x9939AC0", VA = "0x18993ACC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool LGJMTXJYGYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x19C1890", Offset = "0x19C0690", VA = "0x1819C1890", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x19C1660", Offset = "0x19C0460", VA = "0x1819C1660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool RLTTNNVVRTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x993AA60", Offset = "0x9939860", VA = "0x18993AA60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string LAQRTKCMDXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x993AE70", Offset = "0x9939C70", VA = "0x18993AE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string AVMTTNTKGZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x993AB20", Offset = "0x9939920", VA = "0x18993AB20", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool UWNCFEFIELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object XXZQDHKYTDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B20", Offset = "0xCE6920", VA = "0x180CE7B20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7900", Offset = "0xCE6700", VA = "0x180CE7900", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong FIVGZSRNCJV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCE7940", Offset = "0xCE6740", VA = "0x180CE7940")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x993B200", Offset = "0x993A000", VA = "0x18993B200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x993B490", Offset = "0x993A290", VA = "0x18993B490")]
		internal UNQUCEFHIMW(JQYRLXCHTHL a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x993B450", Offset = "0x993A250", VA = "0x18993B450")]
		internal UNQUCEFHIMW(JQYRLXCHTHL a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x993B340", Offset = "0x993A140", VA = "0x18993B340")]
		internal UNQUCEFHIMW(JQYRLXCHTHL a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x993AB80", Offset = "0x9939980", VA = "0x18993AB80", Slot = "16")]
		public bool EBMHYZBAFUV(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x993B220", Offset = "0x993A020", VA = "0x18993B220")]
		public NetworkedPlayerData YJSDVLCMJVR()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x993AF10", Offset = "0x9939D10", VA = "0x18993AF10")]
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
			[Cpp2IlInjected.Address(RVA = "0x993A880", Offset = "0x9939680", VA = "0x18993A880", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool OFXFRDJZXMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xE92720", Offset = "0xE91520", VA = "0x180E92720", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public UNQUCEFHIMW[] JXHCCPBYCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public UNQUCEFHIMW[] BZVCCZGULQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public UNQUCEFHIMW[] DRLFPQZQTRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCE8260", Offset = "0xCE7060", VA = "0x180CE8260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public UNQUCEFHIMW[] RURBLRWXGYR
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCE82E0", Offset = "0xCE70E0", VA = "0x180CE82E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCE8290", Offset = "0xCE7090", VA = "0x180CE8290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int NOCTBTWTRNP
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEE5F80", Offset = "0xEE4D80", VA = "0x180EE5F80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1AA2FA0", Offset = "0x1AA1DA0", VA = "0x181AA2FA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x993A8D0", Offset = "0x99396D0", VA = "0x18993A8D0")]
		public UEKUWOEJGJW(JQYRLXCHTHL a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x993A3E0", Offset = "0x99391E0", VA = "0x18993A3E0", Slot = "8")]
		public bool NFFWBQUUPBY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9939D60", Offset = "0x9938B60", VA = "0x189939D60", Slot = "7")]
		public bool EBMHYZBAFUV(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x993A230", Offset = "0x9939030", VA = "0x18993A230")]
		internal bool NARVOYDCZWB([In] NetworkedPlayerData playerData, bool a, [Out] UNQUCEFHIMW b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9939BC0", Offset = "0x99389C0", VA = "0x189939BC0")]
		internal void ACEOLHDKCUE(ulong a, [Out] UNQUCEFHIMW b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x993A440", Offset = "0x9939240", VA = "0x18993A440")]
		internal void POMMJWWKEKF([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9939E10", Offset = "0x9938C10", VA = "0x189939E10")]
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
			[Cpp2IlInjected.Address(RVA = "0x9932F90", Offset = "0x9931D90", VA = "0x189932F90", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int RHHVPGDIADU
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int BRUKMPCKKXM
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9932890", Offset = "0x9931690", VA = "0x189932890", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int MKLTQDHSNME
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x99331D0", Offset = "0x9931FD0", VA = "0x1899331D0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool SNCZNNOXRIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xDDF5B0", Offset = "0xDDE3B0", VA = "0x180DDF5B0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double ICDAYHQMCMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9933750", Offset = "0x9932550", VA = "0x189933750", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int ZNRYLBDDSUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9933140", Offset = "0x9931F40", VA = "0x189933140", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool QFWQYRJTORK
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9932140", Offset = "0x9930F40", VA = "0x189932140", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool BMGZGIWJJNZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9932950", Offset = "0x9931750", VA = "0x189932950", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9932EC0", Offset = "0x9931CC0", VA = "0x189932EC0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool RZPDNUNVGLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9933240", Offset = "0x9932040", VA = "0x189933240", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool RLAZWSISEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9933700", Offset = "0x9932500", VA = "0x189933700", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public GUPOFWBVNMS JEGPTVEDGKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9932230", Offset = "0x9931030", VA = "0x189932230", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int IBPUESASJST
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x99337B0", Offset = "0x99325B0", VA = "0x1899337B0", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int OFUWQCBQGUG
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x99334B0", Offset = "0x99322B0", VA = "0x1899334B0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public GUPOFWBVNMS YKBSWBFDOBU
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9933330", Offset = "0x9932130", VA = "0x189933330", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool OKAKVETJBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9932B00", Offset = "0x9931900", VA = "0x189932B00", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int ZRLJBDOZLFF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9933550", Offset = "0x9932350", VA = "0x189933550", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string YUCKBXTRNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9933810", Offset = "0x9932610", VA = "0x189933810", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> ZULLOQDMMHX
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x99327D0", Offset = "0x99315D0", VA = "0x1899327D0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public UTTDOXTMXQW UTISZCHWWAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x99331F0", Offset = "0x9931FF0", VA = "0x1899331F0", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool HSYGFXFVUKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9933110", Offset = "0x9931F10", VA = "0x189933110", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9932AE0", Offset = "0x99318E0", VA = "0x189932AE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float GRPXCNWJYFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12AEE60", Offset = "0x12ADC60", VA = "0x1812AEE60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A915E0", Offset = "0x1A903E0", VA = "0x181A915E0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override CDPRAJEFKDH GUKFHWXZOBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCEB600", Offset = "0xCEA400", VA = "0x180CEB600", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HHCFARZRIKU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9933660", Offset = "0x9932460", VA = "0x189933660", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9932910", Offset = "0x9931710", VA = "0x189932910", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string ZEKLDYQHFRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9932000", Offset = "0x9930E00", VA = "0x189932000", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long VGIKHEWIEAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9933950", Offset = "0x9932750", VA = "0x189933950", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long WLDUOCHRCAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9933960", Offset = "0x9932760", VA = "0x189933960", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<XHRZBUOCUVQ> XXUPKAJWMAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9933280", Offset = "0x9932080", VA = "0x189933280", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x99324C0", Offset = "0x99312C0", VA = "0x1899324C0", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<GUPOFWBVNMS> ZGBYUVJZSAU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x99335B0", Offset = "0x99323B0", VA = "0x1899335B0", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9932DA0", Offset = "0x9931BA0", VA = "0x189932DA0", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x99325A0", Offset = "0x99313A0", VA = "0x1899325A0")]
		[CXDXQIFYXBD.Root.GameOnly]
		internal static void CXDXQIFYXBD(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9933970", Offset = "0x9932770", VA = "0x189933970")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public EWRTDVFSXHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9932D80", Offset = "0x9931B80", VA = "0x189932D80", Slot = "21")]
		public void KVMDVSGCMUV(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9933920", Offset = "0x9932720", VA = "0x189933920", Slot = "23")]
		public void XEVASJUFEWS(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9932C20", Offset = "0x9931A20", VA = "0x189932C20", Slot = "27")]
		public void JUDXTFCKDSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x99333A0", Offset = "0x99321A0", VA = "0x1899333A0", Slot = "47")]
		public bool RSKHSJKJTUW(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9932690", Offset = "0x9931490", VA = "0x189932690", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x99326C0", Offset = "0x99314C0", VA = "0x1899326C0", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9932370", Offset = "0x9931170", VA = "0x189932370", Slot = "22")]
		public void BVQDRLYHIAP(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9932990", Offset = "0x9931790", VA = "0x189932990", Slot = "75")]
		public GUPOFWBVNMS IFSVABANWGE(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9932EE0", Offset = "0x9931CE0", VA = "0x189932EE0", Slot = "74")]
		public GUPOFWBVNMS LSYTJXSXUGW(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9932FF0", Offset = "0x9931DF0", VA = "0x189932FF0", Slot = "76")]
		public GUPOFWBVNMS OCUQFXFYTLM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9932A80", Offset = "0x9931880", VA = "0x189932A80", Slot = "18")]
		public bool IMSIVTFVUSC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9933670", Offset = "0x9932470", VA = "0x189933670", Slot = "77")]
		public IReadOnlyList<GUPOFWBVNMS> VPMZNBEILYK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x99321A0", Offset = "0x9930FA0", VA = "0x1899321A0", Slot = "78")]
		public IReadOnlyList<GUPOFWBVNMS> BDEFTIGHDGF(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9932610", Offset = "0x9931410", VA = "0x189932610", Slot = "45")]
		public bool DHTPXQPMPDR(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x99333C0", Offset = "0x99321C0", VA = "0x1899333C0", Slot = "20")]
		public void SFNIHUQYGZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9932110", Offset = "0x9930F10", VA = "0x189932110", Slot = "62")]
		public bool AMOVTMMCLWN(byte a, object b, OGEXSFQHDBH c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9932F70", Offset = "0x9931D70", VA = "0x189932F70", Slot = "28")]
		public void NYKTBLQYXAJ(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9932570", Offset = "0x9931370", VA = "0x189932570", Slot = "30")]
		public int COPIOQMYBAN(XHRZBUOCUVQ a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9932390", Offset = "0x9931190", VA = "0x189932390", Slot = "79")]
		public bool BXNPAQDLKRE(GUPOFWBVNMS a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9932E50", Offset = "0x9931C50", VA = "0x189932E50", Slot = "17")]
		public float LMJDTWQHJHN(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9932830", Offset = "0x9931630", VA = "0x189932830", Slot = "8")]
		public override void FRKPJZZZTFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9932250", Offset = "0x9931050", VA = "0x189932250", Slot = "73")]
		public void BNZSPXUUBJG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9932F90", Offset = "0x9931D90", VA = "0x189932F90", Slot = "87")]
		public int NYXPOAUPOMH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9932900", Offset = "0x9931700", VA = "0x189932900", Slot = "11")]
		private void HENDEEDYVIF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9933120", Offset = "0x9931F20", VA = "0x189933120", Slot = "12")]
		private void OSESFDOBRYK(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9933490", Offset = "0x9932290", VA = "0x189933490", Slot = "25")]
		private void SRXTAFWHPAZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9932980", Offset = "0x9931780", VA = "0x189932980", Slot = "26")]
		private void HTRAJHQKSZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9932360", Offset = "0x9931160", VA = "0x189932360", Slot = "31")]
		private void BTWYTUVSLUW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x99334A0", Offset = "0x99322A0", VA = "0x1899334A0", Slot = "32")]
		private void TBHOWFCBXSN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x99331C0", Offset = "0x9931FC0", VA = "0x1899331C0", Slot = "48")]
		private void PPRYXCIIWPG(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9932F50", Offset = "0x9931D50", VA = "0x189932F50", Slot = "49")]
		private void LTJHAZFGKHL(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x99324B0", Offset = "0x99312B0", VA = "0x1899324B0", Slot = "50")]
		private void BXVWCYXKZLP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9933100", Offset = "0x9931F00", VA = "0x189933100", Slot = "51")]
		private void OJYJBOAXKFA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9933130", Offset = "0x9931F30", VA = "0x189933130", Slot = "52")]
		private void OUFBPGFGMOA(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9931FF0", Offset = "0x9930DF0", VA = "0x189931FF0", Slot = "53")]
		private IDisposable ABAMBSTETTF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9932D70", Offset = "0x9931B70", VA = "0x189932D70", Slot = "54")]
		private bool KMXNIJPJDVA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x99330F0", Offset = "0x9931EF0", VA = "0x1899330F0", Slot = "55")]
		private void OGAFKIVDJUW(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9932970", Offset = "0x9931770", VA = "0x189932970", Slot = "57")]
		private void HQVZBSKUGIG(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9932D60", Offset = "0x9931B60", VA = "0x189932D60", Slot = "58")]
		private void KFAJLSVOVWB(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9932590", Offset = "0x9931390", VA = "0x189932590", Slot = "80")]
		private void CVLQQNSGVFO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x99327C0", Offset = "0x99315C0", VA = "0x1899327C0", Slot = "81")]
		private void EGAHTACFXTJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9932F60", Offset = "0x9931D60", VA = "0x189932F60", Slot = "82")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9931C70", Offset = "0x9930A70", VA = "0x189931C70")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9931E80", Offset = "0x9930C80", VA = "0x189931E80")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9931E30", Offset = "0x9930C30", VA = "0x189931E30")]
		private void KWBSGPQZHQV(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCE6140", Offset = "0xCE4F40", VA = "0x180CE6140")]
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
		[Cpp2IlInjected.Address(RVA = "0x9939660", Offset = "0x9938460", VA = "0x189939660")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCE6140", Offset = "0xCE4F40", VA = "0x180CE6140")]
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
			[Cpp2IlInjected.Address(RVA = "0xD3CC00", Offset = "0xD3BA00", VA = "0x180D3CC00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xE0DF60", Offset = "0xE0CD60", VA = "0x180E0DF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager TGDMTWPXZGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCE7520", Offset = "0xCE6320", VA = "0x180CE7520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager XWVQPBLVAWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCE7530", Offset = "0xCE6330", VA = "0x180CE7530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager OYMIBEAVXQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
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
			[Cpp2IlInjected.Address(RVA = "0x9933BF0", Offset = "0x99329F0", VA = "0x189933BF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9933A60", Offset = "0x9932860", VA = "0x189933A60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9933CA0", Offset = "0x9932AA0", VA = "0x189933CA0")]
		[RecRoom.NoEngine.Common.Preserve]
		public FZRUZLOUBUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9933B10", Offset = "0x9932910", VA = "0x189933B10")]
		[CXDXQIFYXBD.Root]
		public static void HUETBZQUPBQ(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9933B80", Offset = "0x9932980", VA = "0x189933B80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD524A0", Offset = "0xD512A0", VA = "0x180D524A0", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCE7950", Offset = "0xCE6750", VA = "0x180CE7950", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCE8250", Offset = "0xCE7050", VA = "0x180CE8250", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD00B10", Offset = "0xCFF910", VA = "0x180D00B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9939840", Offset = "0x9938640", VA = "0x189939840", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9939990", Offset = "0x9938790", VA = "0x189939990", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x99398F0", Offset = "0x99386F0", VA = "0x1899398F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9939A40", Offset = "0x9938840", VA = "0x189939A40", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9939750", Offset = "0x9938550", VA = "0x189939750", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9939750", Offset = "0x9938550", VA = "0x189939750", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xCE6160", Offset = "0xCE4F60", VA = "0x180CE6160", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x99397D0", Offset = "0x99385D0", VA = "0x1899397D0")]
		public OYMIBEAVXQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9939770", Offset = "0x9938570", VA = "0x189939770", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9939790", Offset = "0x9938590", VA = "0x189939790", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x99397B0", Offset = "0x99385B0", VA = "0x1899397B0", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "21")]
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
