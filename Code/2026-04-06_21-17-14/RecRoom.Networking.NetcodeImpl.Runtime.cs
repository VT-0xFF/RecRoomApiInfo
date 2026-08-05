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
		[Cpp2IlInjected.Address(RVA = "0x9AB2060", Offset = "0x9AB1060", VA = "0x189AB2060", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F86A0", Offset = "0x29F76A0", VA = "0x1829F86A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class FZZZQKSFIHS : RBRIQVJRNNA, HRGTWKYVSJU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class QVDFOKSNNQB : PKEJZTAIXED
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte ZKGQRVFYLTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xE0C750", Offset = "0xE0B750", VA = "0x180E0C750")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int DGCOIKJZOFR
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xE01B10", Offset = "0xE00B10", VA = "0x180E01B10", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xE01AF0", Offset = "0xE00AF0", VA = "0x180E01AF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object CXPGFCWUHBP
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x92F4150", Offset = "0x92F3150", VA = "0x1892F4150")]
			public QVDFOKSNNQB(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1F40", Offset = "0x9AB0F40", VA = "0x189AB1F40", Slot = "7")]
			public bool YBTJOCJEVNY(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState JBVNCKNVQKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch IPJMQHCSMBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int XBZEILSLVMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<QVDFOKSNNQB> ECSGUOTFDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> KNMCSCICYHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private LQKYZXHXIIP DDUTUPDWSZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private LYHKCPSOFMZ POQXMDZJCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool HXXSWEPGIQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool DPMYDRZAYMT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager PVJAJFWXGNR
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport SHVLMNMHSJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9AAAF40", Offset = "0x9AA9F40", VA = "0x189AAAF40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState AGPAWCJWOFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9AAE0D0", Offset = "0x9AAD0D0", VA = "0x189AAE0D0", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9AAB2E0", Offset = "0x9AAA2E0", VA = "0x189AAB2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int HYEMTGSPFDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCFBA70", Offset = "0xCFAA70", VA = "0x180CFBA70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public LQKYZXHXIIP BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LYHKCPSOFMZ OSLOXOYULWI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private JNIFYRYESKL ADKKNQYFEUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool CBXBNDHBZZI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9AAA7D0", Offset = "0x9AA97D0", VA = "0x189AAA7D0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool RGAUPBAKBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9AABDA0", Offset = "0x9AAADA0", VA = "0x189AABDA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool WUGYAMPLMXD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9AABDA0", Offset = "0x9AAADA0", VA = "0x189AABDA0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CASXLHDKDYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD9B510", Offset = "0xD9A510", VA = "0x180D9B510")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9AAB860", Offset = "0x9AAA860", VA = "0x189AAB860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception IXRZDICTPYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int VPUOEHAMUQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool MNXYWPKRXGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9AAA3C0", Offset = "0x9AA93C0", VA = "0x189AAA3C0", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9AAB180", Offset = "0x9AAA180", VA = "0x189AAB180", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool QSHEVNXINNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCFC310", Offset = "0xCFB310", VA = "0x180CFC310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCFC300", Offset = "0xCFB300", VA = "0x180CFC300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double XUGUCERVHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9AAB430", Offset = "0x9AAA430", VA = "0x189AAB430")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double JEFDMDGSTXO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9AADF90", Offset = "0x9AACF90", VA = "0x189AADF90")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int MPZTSRIXLCU
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9AAA9F0", Offset = "0x9AA99F0", VA = "0x189AAA9F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string VYJSHSWXBJR
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9AAC1F0", Offset = "0x9AAB1F0", VA = "0x189AAC1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int QXSWYSBANOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9AAA360", Offset = "0x9AA9360", VA = "0x189AAA360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public SOEJOTFBVHT SNFDUGULNWD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9AAD0C0", Offset = "0x9AAC0C0", VA = "0x189AAD0C0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool YIMSHLABBZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xFAB2B0", Offset = "0xFAA2B0", VA = "0x180FAB2B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9AA9CF0", Offset = "0x9AA8CF0", VA = "0x189AA9CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> MBKYDEUBIAX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9AACE80", Offset = "0x9AABE80", VA = "0x189AACE80", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9AAD3A0", Offset = "0x9AAC3A0", VA = "0x189AAD3A0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> XBGNBBZAQHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9AAD450", Offset = "0x9AAC450", VA = "0x189AAD450", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9AAB980", Offset = "0x9AAA980", VA = "0x189AAB980", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9AAE8B0", Offset = "0x9AAD8B0", VA = "0x189AAE8B0")]
		public FZZZQKSFIHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AA99F0", Offset = "0x9AA89F0", VA = "0x189AA99F0")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AAE630", Offset = "0x9AAD630", VA = "0x189AAE630")]
		private void ZQDLDHRPNDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9AAE850", Offset = "0x9AAD850", VA = "0x189AAE850")]
		private void ZSLUWVYHIET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB310", Offset = "0x9AAA310", VA = "0x189AAB310")]
		public bool KFOAQEJMPPJ(QCTMRFTYWMB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9AABD50", Offset = "0x9AAAD50", VA = "0x189AABD50")]
		public bool MPZOKQTFADS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB480", Offset = "0x9AAA480", VA = "0x189AAB480")]
		public void KSGMNUBFBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC300", Offset = "0x9AAB300", VA = "0x189AAC300")]
		public void OHRJMFPTMQI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA800", Offset = "0x9AA9800", VA = "0x189AAA800")]
		public void FQDAHEULGLA(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AAD110", Offset = "0x9AAC110", VA = "0x189AAD110")]
		public void VMLOZGORYAK(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA96C0", Offset = "0x9AA86C0", VA = "0x189AA96C0")]
		public void BINWWPTDWNR(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA9430", Offset = "0x9AA8430", VA = "0x189AA9430")]
		public void BIDIANLANQI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA020", Offset = "0x9AA9020", VA = "0x189AAA020")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AACC60", Offset = "0x9AABC60", VA = "0x189AACC60")]
		public int SDBOPHCHTSK(PKEJZTAIXED a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AAE0F0", Offset = "0x9AAD0F0", VA = "0x189AAE0F0")]
		public bool ZKAFYNRYOQW(byte a, object b, GWNNVAAQPXK c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9AAD820", Offset = "0x9AAC820", VA = "0x189AAD820")]
		public bool WPQPTQJWETK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9AA9210", Offset = "0x9AA8210", VA = "0x189AA9210")]
		internal bool APFOYOTRFDO([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA410", Offset = "0x9AA9410", VA = "0x189AAA410")]
		internal bool EVPNBKUFXUS([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB690", Offset = "0x9AAA690", VA = "0x189AAB690")]
		private void LSWNZQIWIOF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA110", Offset = "0x9AA9110", VA = "0x189AAA110")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA210", Offset = "0x9AA9210", VA = "0x189AAA210", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9AAA670", Offset = "0x9AA9670", VA = "0x189AAA670")]
		private void FJSBMMCRRYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9AAD500", Offset = "0x9AAC500", VA = "0x189AAD500")]
		private void WJTMUITSXEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9AADFE0", Offset = "0x9AACFE0", VA = "0x189AADFE0")]
		private void YHUKWNNTZZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9AABA30", Offset = "0x9AAAA30", VA = "0x189AABA30")]
		private void MKEADVCAFDA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9AAACB0", Offset = "0x9AA9CB0", VA = "0x189AAACB0")]
		private void GSOUVESTWFJ(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3ACFF60", Offset = "0x3ACEF60", VA = "0x183ACFF60")]
		private void LPJNKYVCMRN<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB050", Offset = "0x9AAA050", VA = "0x189AAB050")]
		private void HHGIGTFLQMG(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9AAAA40", Offset = "0x9AA9A40", VA = "0x189AAAA40")]
		private void GJICBTVIJNJ(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9AACE50", Offset = "0x9AABE50", VA = "0x189AACE50")]
		private void SVAOMOMJJUL(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC730", Offset = "0x9AAB730", VA = "0x189AAC730")]
		private void QORSSSFZBMM(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9AA9D20", Offset = "0x9AA8D20", VA = "0x189AA9D20")]
		private void DRNSXZFUTFW(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC3C0", Offset = "0x9AAB3C0", VA = "0x189AAC3C0")]
		private void QFAQRJLJYOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9AACF30", Offset = "0x9AABF30", VA = "0x189AACF30")]
		private void TVYLSIGNZHN(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB4D0", Offset = "0x9AAA4D0", VA = "0x189AAB4D0")]
		private void LRVVMUKNWMJ(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AADCD0", Offset = "0x9AACCD0", VA = "0x189AADCD0")]
		private void XFUVBVODEHT(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9AA98C0", Offset = "0x9AA88C0", VA = "0x189AA98C0")]
		private void BMXFOQUVSIR(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AAAB60", Offset = "0x9AA9B60", VA = "0x189AAAB60")]
		private void GJICBTVIJNJ(QVDFOKSNNQB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9AAE550", Offset = "0x9AAD550", VA = "0x189AAE550")]
		private void ZKMUPCEFYAL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AAB1E0", Offset = "0x9AAA1E0", VA = "0x189AAB1E0")]
		private void HYYZTOGCLYF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9AABDF0", Offset = "0x9AAADF0", VA = "0x189AABDF0")]
		private void NDHVBHDAQPX(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9AAC2F0", Offset = "0x9AAB2F0", VA = "0x189AAC2F0")]
		[CompilerGenerated]
		private void NGRKMTMLLMZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class LQKYZXHXIIP : QCTMRFTYWMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private FZZZQKSFIHS HLQZXTHEJGE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string OCQUBLJNPBB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> PDEDWOOYZWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int AMBEEXQEYVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string QFYZWYOUKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt CETJNUCMBTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? PKRHOTSHHEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string NOGVKBGOIQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong BUOZXZLXKQJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int RTNQGDZOYVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool HRMVVFJFZWB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xE9D7B0", Offset = "0xE9C7B0", VA = "0x180E9D7B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xED4590", Offset = "0xED3590", VA = "0x180ED4590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool SVDREBHHLMU
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9AAEAD0", Offset = "0x9AADAD0", VA = "0x189AAEAD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> CHTPRGSGKSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string HKZNAIGDAWO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9AAED40", Offset = "0x9AADD40", VA = "0x189AAED40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int KDXKZNRYOPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF360", Offset = "0x9AAE360", VA = "0x189AAF360", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF1D0", Offset = "0x9AAE1D0", VA = "0x189AAF1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool HTXJVIDGKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x19C8B90", Offset = "0x19C7B90", VA = "0x1819C8B90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x19C8D50", Offset = "0x19C7D50", VA = "0x1819C8D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DYUUYGHOWOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF2A0", Offset = "0x9AAE2A0", VA = "0x189AAF2A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string KAIWACZQKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9AAECA0", Offset = "0x9AADCA0", VA = "0x189AAECA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string ZXFIXZGAWJS
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF240", Offset = "0x9AAE240", VA = "0x189AAF240", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool JLOZFCIGNHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object QSXJYKJZEIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BD0", Offset = "0xCF6BD0", VA = "0x180CF7BD0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BC0", Offset = "0xCF6BC0", VA = "0x180CF7BC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong AFJHJXBUMDK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9AAEB60", Offset = "0x9AADB60", VA = "0x189AAEB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF3F0", Offset = "0x9AAE3F0", VA = "0x189AAF3F0")]
		internal LQKYZXHXIIP(FZZZQKSFIHS a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF3B0", Offset = "0x9AAE3B0", VA = "0x189AAF3B0")]
		internal LQKYZXHXIIP(FZZZQKSFIHS a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF430", Offset = "0x9AAE430", VA = "0x189AAF430")]
		internal LQKYZXHXIIP(FZZZQKSFIHS a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF120", Offset = "0x9AAE120", VA = "0x189AAF120", Slot = "16")]
		public bool MAOLTSDEBZG(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9AAEB80", Offset = "0x9AADB80", VA = "0x189AAEB80")]
		public NetworkedPlayerData CPVIEYHTASW()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9AAEE30", Offset = "0x9AADE30", VA = "0x189AAEE30")]
		internal void LUXJEOCBBBI([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class LYHKCPSOFMZ : JNIFYRYESKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private FZZZQKSFIHS HLQZXTHEJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> VYDVWEISOCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, LQKYZXHXIIP> YKNBCPLJAIL;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte DLUEVSNOIPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9AAF8F0", Offset = "0x9AAE8F0", VA = "0x189AAF8F0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool JXVAOXYSQLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEBB680", Offset = "0xEBA680", VA = "0x180EBB680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> CHTPRGSGKSQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public LQKYZXHXIIP[] UEMNJSQGSFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD02500", Offset = "0xD01500", VA = "0x180D02500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public LQKYZXHXIIP[] DHYEOKLMXMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCFC360", Offset = "0xCFB360", VA = "0x180CFC360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public LQKYZXHXIIP[] SRHBZPMALGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF3370", VA = "0x180CF4370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public LQKYZXHXIIP[] GSKWDYTSGDY
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCFC240", Offset = "0xCFB240", VA = "0x180CFC240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int SDVODPIVCBU
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xED7420", Offset = "0xED6420", VA = "0x180ED7420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1AABF50", Offset = "0x1AAAF50", VA = "0x181AABF50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0250", Offset = "0x9AAF250", VA = "0x189AB0250")]
		public LYHKCPSOFMZ(FZZZQKSFIHS a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF6F0", Offset = "0x9AAE6F0", VA = "0x189AAF6F0", Slot = "8")]
		public bool ASEPVQVXNKX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF940", Offset = "0x9AAE940", VA = "0x189AAF940", Slot = "7")]
		public bool MAOLTSDEBZG(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF540", Offset = "0x9AAE540", VA = "0x189AAF540")]
		internal bool AGZDGNOJNRC([In] NetworkedPlayerData playerData, bool a, [Out] LQKYZXHXIIP b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF750", Offset = "0x9AAE750", VA = "0x189AAF750")]
		internal void ETPGNZILYQL(ulong a, [Out] LQKYZXHXIIP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9AAFE10", Offset = "0x9AAEE10", VA = "0x189AAFE10")]
		internal void NXTIQAPTWWQ([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9AAF9F0", Offset = "0x9AAE9F0", VA = "0x189AAF9F0")]
		private void MFWNWZEYTXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MDYGDKQGTHH : YGGHXUYNTZZ, VTBHZBONJTB, QLDQNELYIYH, TFZPZNPDNPF, CZJKUNNKCNH, TLNJJUFQNGK, MQYWWXYBDLU, HRGTWKYVSJU, JTGJDGRSJPV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FZZZQKSFIHS HLQZXTHEJGE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int MPZTSRIXLCU
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0C60", Offset = "0x9AAFC60", VA = "0x189AB0C60", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int IEWCABQVDNB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int ZHNVWTSOVZB
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0DB0", Offset = "0x9AAFDB0", VA = "0x189AB0DB0", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int HYEMTGSPFDT
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0750", Offset = "0x9AAF750", VA = "0x189AB0750", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool VMORMBEXBVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xDEC400", Offset = "0xDEB400", VA = "0x180DEC400", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double XUGUCERVHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0FE0", Offset = "0x9AAFFE0", VA = "0x189AB0FE0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int OFLKXJLVGZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9AB10E0", Offset = "0x9AB00E0", VA = "0x189AB10E0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool WUGYAMPLMXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9AB13A0", Offset = "0x9AB03A0", VA = "0x189AB13A0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool CASXLHDKDYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1930", Offset = "0x9AB0930", VA = "0x189AB1930", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9AB10B0", Offset = "0x9AB00B0", VA = "0x189AB10B0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool TCIGJMOYZML
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0960", Offset = "0x9AAF960", VA = "0x189AB0960", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool CBXBNDHBZZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0BF0", Offset = "0x9AAFBF0", VA = "0x189AB0BF0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public QCTMRFTYWMB BZISNAJGEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1380", Offset = "0x9AB0380", VA = "0x189AB1380", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int GPZMNVIOTQQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1270", Offset = "0x9AB0270", VA = "0x189AB1270", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int QJBVHAFFVFF
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0B50", Offset = "0x9AAFB50", VA = "0x189AB0B50", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public QCTMRFTYWMB LERYWHOBAMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9AB05E0", Offset = "0x9AAF5E0", VA = "0x189AB05E0", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool DVVCXGHSQVN
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9AB16B0", Offset = "0x9AB06B0", VA = "0x189AB16B0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int DLUEVSNOIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0CC0", Offset = "0x9AAFCC0", VA = "0x189AB0CC0", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string OCQUBLJNPBB
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9AB17D0", Offset = "0x9AB07D0", VA = "0x189AB17D0", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> PDEDWOOYZWY
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9AB09A0", Offset = "0x9AAF9A0", VA = "0x189AB09A0", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public SOEJOTFBVHT SNFDUGULNWD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9AB18E0", Offset = "0x9AB08E0", VA = "0x189AB18E0", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool QSHEVNXINNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9AB03E0", Offset = "0x9AAF3E0", VA = "0x189AB03E0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9AB12D0", Offset = "0x9AB02D0", VA = "0x189AB12D0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float NMQNGGQOBID
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12BF670", Offset = "0x12BE670", VA = "0x1812BF670", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A8E7C0", Offset = "0x1A8D7C0", VA = "0x181A8E7C0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override RBRIQVJRNNA OPNMTYWCXMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool YIMSHLABBZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9AB08D0", Offset = "0x9AAF8D0", VA = "0x189AB08D0", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0790", Offset = "0x9AAF790", VA = "0x189AB0790", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string VYJSHSWXBJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1160", Offset = "0x9AB0160", VA = "0x189AB1160", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long BKDJBWQALJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9AB08C0", Offset = "0x9AAF8C0", VA = "0x189AB08C0", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long FKWROGGQLPD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0A00", Offset = "0x9AAFA00", VA = "0x189AB0A00", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PKEJZTAIXED> LZTKLUFVYFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9AB14C0", Offset = "0x9AB04C0", VA = "0x189AB14C0", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1C60", Offset = "0x9AB0C60", VA = "0x189AB1C60", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<QCTMRFTYWMB> MNPMNJIRUQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9AB1410", Offset = "0x9AB0410", VA = "0x189AB1410", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9AB06A0", Offset = "0x9AAF6A0", VA = "0x189AB06A0", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0D20", Offset = "0x9AAFD20", VA = "0x189AB0D20")]
		[GQJUYEPYYUG.Root.GameOnly]
		internal static void GQJUYEPYYUG(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1D60", Offset = "0x9AB0D60", VA = "0x189AB1D60")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public MDYGDKQGTHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0C40", Offset = "0x9AAFC40", VA = "0x189AB0C40", Slot = "21")]
		public void FQDAHEULGLA(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0670", Offset = "0x9AAF670", VA = "0x189AB0670", Slot = "23")]
		public void BINWWPTDWNR(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB04A0", Offset = "0x9AAF4A0", VA = "0x189AB04A0", Slot = "27")]
		public void AZDULUIDTAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1D10", Offset = "0x9AB0D10", VA = "0x189AB1D10", Slot = "47")]
		public bool ZJTRWUIAUOR(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0A10", Offset = "0x9AAFA10", VA = "0x189AB0A10", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0A40", Offset = "0x9AAFA40", VA = "0x189AB0A40", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1A20", Offset = "0x9AB0A20", VA = "0x189AB1A20", Slot = "22")]
		public void VMLOZGORYAK(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9AB07D0", Offset = "0x9AAF7D0", VA = "0x189AB07D0", Slot = "75")]
		public QCTMRFTYWMB DEVHBWDOJSF(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9AB08F0", Offset = "0x9AAF8F0", VA = "0x189AB08F0", Slot = "74")]
		public QCTMRFTYWMB DOSIYYYTFMX(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1B40", Offset = "0x9AB0B40", VA = "0x189AB1B40", Slot = "76")]
		public QCTMRFTYWMB XCFOZJMINOH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1040", Offset = "0x9AB0040", VA = "0x189AB1040", Slot = "18")]
		public bool KQCVZKRFVIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0400", Offset = "0x9AAF400", VA = "0x189AB0400", Slot = "77")]
		public IReadOnlyList<QCTMRFTYWMB> ALTKBHTYVUP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9AB12F0", Offset = "0x9AB02F0", VA = "0x189AB12F0", Slot = "78")]
		public IReadOnlyList<QCTMRFTYWMB> QKTYMEZZGOA(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1AB0", Offset = "0x9AB0AB0", VA = "0x189AB1AB0", Slot = "45")]
		public bool WPQPTQJWETK(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1950", Offset = "0x9AB0950", VA = "0x189AB1950", Slot = "20")]
		public void VGTMHZCWLXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1D30", Offset = "0x9AB0D30", VA = "0x189AB1D30", Slot = "62")]
		public bool ZKAFYNRYOQW(byte a, object b, GWNNVAAQPXK c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0650", Offset = "0x9AAF650", VA = "0x189AB0650", Slot = "28")]
		public void BIDIANLANQI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1680", Offset = "0x9AB0680", VA = "0x189AB1680", Slot = "30")]
		public int SDBOPHCHTSK(PKEJZTAIXED a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0EC0", Offset = "0x9AAFEC0", VA = "0x189AB0EC0", Slot = "79")]
		public bool KFOAQEJMPPJ(QCTMRFTYWMB a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0E40", Offset = "0x9AAFE40", VA = "0x189AB0E40", Slot = "17")]
		public float IPGVAAGBOEQ(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1A50", Offset = "0x9AB0A50", VA = "0x189AB1A50", Slot = "8")]
		public override void WKCPVNOITUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1570", Offset = "0x9AB0570", VA = "0x189AB1570", Slot = "73")]
		public void RTKJDKUWSXN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0C60", Offset = "0x9AAFC60", VA = "0x189AB0C60", Slot = "87")]
		public int MMCQUIJKMDU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1A40", Offset = "0x9AB0A40", VA = "0x189AB1A40", Slot = "11")]
		private void WFAJEUQEYCQ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0DA0", Offset = "0x9AAFDA0", VA = "0x189AB0DA0", Slot = "12")]
		private void HCBNMDRLGGN(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1B30", Offset = "0x9AB0B30", VA = "0x189AB1B30", Slot = "25")]
		private void WVNMQXFOQKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0D90", Offset = "0x9AAFD90", VA = "0x189AB0D90", Slot = "26")]
		private void GYXCXSUXDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9AB03F0", Offset = "0x9AAF3F0", VA = "0x189AB03F0", Slot = "31")]
		private void ALJOYJPGJUP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9AB08E0", Offset = "0x9AAF8E0", VA = "0x189AB08E0", Slot = "32")]
		private void DMZZCGRRFDI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1400", Offset = "0x9AB0400", VA = "0x189AB1400", Slot = "48")]
		private void QXZZGLYOPUZ(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0E20", Offset = "0x9AAFE20", VA = "0x189AB0E20", Slot = "49")]
		private void HYMKMRDEUUO(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0490", Offset = "0x9AAF490", VA = "0x189AB0490", Slot = "50")]
		private void AXMKACYGGGC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1C50", Offset = "0x9AB0C50", VA = "0x189AB1C50", Slot = "51")]
		private void YEQFGWEKQBH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0E30", Offset = "0x9AAFE30", VA = "0x189AB0E30", Slot = "52")]
		private void IIIDIJQFTIZ(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0780", Offset = "0x9AAF780", VA = "0x189AB0780", Slot = "53")]
		private IDisposable CDBLIZZDGQK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0EB0", Offset = "0x9AAFEB0", VA = "0x189AB0EB0", Slot = "54")]
		private bool JEORBGLDBNT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9AB10D0", Offset = "0x9AB00D0", VA = "0x189AB10D0", Slot = "55")]
		private void MOXPNLEVIMF(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0770", Offset = "0x9AAF770", VA = "0x189AB0770", Slot = "57")]
		private void BXOKOTZCPVH(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9AB10A0", Offset = "0x9AB00A0", VA = "0x189AB10A0", Slot = "58")]
		private void LFRCERPRVAM(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9AB1C40", Offset = "0x9AB0C40", VA = "0x189AB1C40", Slot = "80")]
		private void YBFOPHSDZYD(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9AB16A0", Offset = "0x9AB06A0", VA = "0x189AB16A0", Slot = "81")]
		private void SIZYBGYKLEW(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9AB0B40", Offset = "0x9AAFB40", VA = "0x189AB0B40", Slot = "82")]
		private void EHCHHLRCABA()
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
		public NfgoCommsNetwork PZRULZFXVSJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8B90", Offset = "0x9AA7B90", VA = "0x189AA8B90")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8D50", Offset = "0x9AA7D50", VA = "0x189AA8D50")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8EC0", Offset = "0x9AA7EC0", VA = "0x189AA8EC0")]
		private void RPAZPZVQDUE(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AB1E50", Offset = "0x9AB0E50", VA = "0x189AB1E50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class EUGAYECYEAS
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool ZOKGZCYZJOR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xE0C750", Offset = "0xE0B750", VA = "0x180E0C750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager PVJAJFWXGNR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager PISAQRJIBJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager DUKWDBJQYSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> RPAZPZVQDUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9AA90A0", Offset = "0x9AA80A0", VA = "0x189AA90A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9AA8F80", Offset = "0x9AA7F80", VA = "0x189AA8F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9AA9150", Offset = "0x9AA8150", VA = "0x189AA9150")]
		[RecRoom.NoEngine.Common.Preserve]
		public EUGAYECYEAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8F10", Offset = "0x9AA7F10", VA = "0x189AA8F10")]
		[GQJUYEPYYUG.Root]
		public static void FNZMCCTBUVD(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9AA9030", Offset = "0x9AA8030", VA = "0x189AA9030")]
		public void VOYIAUZAERR(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DUKWDBJQYSM : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float ONGIYSWJDYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate UVNCPWPTBZV;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCFC420", Offset = "0xCFB420", VA = "0x180CFC420", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCFC350", Offset = "0xCFB350", VA = "0x180CFC350", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9AA88F0", Offset = "0x9AA78F0", VA = "0x189AA88F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9AA8A40", Offset = "0x9AA7A40", VA = "0x189AA8A40", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9AA89A0", Offset = "0x9AA79A0", VA = "0x189AA89A0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9AA8AF0", Offset = "0x9AA7AF0", VA = "0x189AA8AF0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8800", Offset = "0x9AA7800", VA = "0x189AA8800", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8800", Offset = "0x9AA7800", VA = "0x189AA8800", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8880", Offset = "0x9AA7880", VA = "0x189AA8880")]
		public DUKWDBJQYSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8820", Offset = "0x9AA7820", VA = "0x189AA8820", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8840", Offset = "0x9AA7840", VA = "0x189AA8840", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9AA8860", Offset = "0x9AA7860", VA = "0x189AA8860", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "21")]
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
