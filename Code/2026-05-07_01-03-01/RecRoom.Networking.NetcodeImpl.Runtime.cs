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
		[Cpp2IlInjected.Address(RVA = "0x9939FE0", Offset = "0x99389E0", VA = "0x189939FE0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29F5EA0", Offset = "0x29F48A0", VA = "0x1829F5EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class HVFCFCFDHNM : SYVXMVIVSMY, HDXFMLHGFWA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[DefaultMember("Item")]
		private class YKKHLHTEHVV : VZZVUJOFUEN
		{
			[Cpp2IlInjected.Token(Token = "0x17000017")]
			public byte TGDROJCJTNL
			{
				[Cpp2IlInjected.Token(Token = "0x600004F")]
				[Cpp2IlInjected.Address(RVA = "0xD28710", Offset = "0xD27110", VA = "0x180D28710", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xDDC880", Offset = "0xDDB280", VA = "0x180DDC880")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int TNCIAZFLYKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xDF0AD0", Offset = "0xDEF4D0", VA = "0x180DF0AD0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xDF0A00", Offset = "0xDEF400", VA = "0x180DF0A00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object CCOAMSFLWRN
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x91792C0", Offset = "0x9177CC0", VA = "0x1891792C0")]
			public YKKHLHTEHVV(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9939FA0", Offset = "0x99389A0", VA = "0x189939FA0", Slot = "7")]
			public bool IAMPTCAGJIA(byte a, [Out] object b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ClientState IRPAJSSHDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly Stopwatch QCQRAWCKWYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int DKRFIKQXANV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private Deque<YKKHLHTEHVV> QAIRITZQFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Deque<Action> GICABCFZQXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private DGGDXSNNWDX CXYEGXOMRFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private XVNVAXEZCRZ MJJONTTKONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool UGPEFKYDIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool CLEUPWUNKLD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public INetworkManager FAOVIIZVLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport TEKTDVEMLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9934A20", Offset = "0x9933420", VA = "0x189934A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState JMOGAOLIVKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9935610", Offset = "0x9934010", VA = "0x189935610", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9935130", Offset = "0x9933B30", VA = "0x189935130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OBLYGFALMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public DGGDXSNNWDX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public XVNVAXEZCRZ XBEDGBSZWDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private AWTHKFEHXLT LBSJLBWKTAD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9934E50", Offset = "0x9933850", VA = "0x189934E50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GPAEVOFPUCH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9932160", Offset = "0x9930B60", VA = "0x189932160", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9932160", Offset = "0x9930B60", VA = "0x189932160", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD75C70", Offset = "0xD74670", VA = "0x180D75C70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9932860", Offset = "0x9931260", VA = "0x189932860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception FVMFOCZHHWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BDUBWMRIMRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool BKHHWFVBFRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x99334C0", Offset = "0x9931EC0", VA = "0x1899334C0", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x99369D0", Offset = "0x99353D0", VA = "0x1899369D0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xCDBAB0", Offset = "0xCDA4B0", VA = "0x180CDBAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2D0", Offset = "0xCD9CD0", VA = "0x180CDB2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x99350E0", Offset = "0x9933AE0", VA = "0x1899350E0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double BQXUUPASKOS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9934340", Offset = "0x9932D40", VA = "0x189934340")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int URLNDODXFES
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9933470", Offset = "0x9931E70", VA = "0x189933470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9934240", Offset = "0x9932C40", VA = "0x189934240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int ONCGLEBHNVC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9935630", Offset = "0x9934030", VA = "0x189935630")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public QOLRJJUHWXN TPTWEBAKSQF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x99333D0", Offset = "0x9931DD0", VA = "0x1899333D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xF930E0", Offset = "0xF91AE0", VA = "0x180F930E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99350B0", Offset = "0x9933AB0", VA = "0x1899350B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> NXPMPDFOVRH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9936A30", Offset = "0x9935430", VA = "0x189936A30", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9934650", Offset = "0x9933050", VA = "0x189934650", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> XLPMIKKPUQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9935000", Offset = "0x9933A00", VA = "0x189935000", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x99327B0", Offset = "0x99311B0", VA = "0x1899327B0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9936FA0", Offset = "0x99359A0", VA = "0x189936FA0")]
		public HVFCFCFDHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9931E60", Offset = "0x9930860", VA = "0x189931E60")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9932C60", Offset = "0x9931660", VA = "0x189932C60")]
		private void EUVAWECXDYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9933370", Offset = "0x9931D70", VA = "0x189933370")]
		private void GTTCGHCTPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9932980", Offset = "0x9931380", VA = "0x189932980")]
		public bool EKOJRVGZPFD(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9933420", Offset = "0x9931E20", VA = "0x189933420")]
		public bool HGTCIUCQXTI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9934E80", Offset = "0x9933880", VA = "0x189934E80")]
		public void RMPMWEPEJXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9936AE0", Offset = "0x99354E0", VA = "0x189936AE0")]
		public void ZETHCNPUFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9933180", Offset = "0x9931B80", VA = "0x189933180")]
		public void FKRUBDBENNS(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99364B0", Offset = "0x9934EB0", VA = "0x1899364B0")]
		public void WWMLLCIZSYQ(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9935690", Offset = "0x9934090", VA = "0x189935690")]
		public void URXDBQZOSHP(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9936740", Offset = "0x9935140", VA = "0x189936740")]
		public void XQIXCNAGDPI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9932470", Offset = "0x9930E70", VA = "0x189932470")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99362C0", Offset = "0x9934CC0", VA = "0x1899362C0")]
		public int WUPATQAEFXK(VZZVUJOFUEN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9935E60", Offset = "0x9934860", VA = "0x189935E60")]
		public bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9935160", Offset = "0x9933B60", VA = "0x189935160")]
		public bool TXELKWRQCPY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9933DA0", Offset = "0x99327A0", VA = "0x189933DA0")]
		internal bool KEPRVKUVTGC([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9933B40", Offset = "0x9932540", VA = "0x189933B40")]
		internal bool KDMLUGQZJVK([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9934480", Offset = "0x9932E80", VA = "0x189934480")]
		private void OAVXNJTWMAP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9932560", Offset = "0x9930F60", VA = "0x189932560")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9932660", Offset = "0x9931060", VA = "0x189932660", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99340E0", Offset = "0x9932AE0", VA = "0x1899340E0")]
		private void KXKLJYSADZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9934B30", Offset = "0x9933530", VA = "0x189934B30")]
		private void RAWZXEKQJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9934390", Offset = "0x9932D90", VA = "0x189934390")]
		private void NLZDULQOQVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9934700", Offset = "0x9933100", VA = "0x189934700")]
		private void PNWWEBAIAPC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9935880", Offset = "0x9934280", VA = "0x189935880")]
		private void UTXSJFMIQSN(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B1CA00", Offset = "0x3B1B400", VA = "0x183B1CA00")]
		private void BOCDAOXTXNP<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9934ED0", Offset = "0x99338D0", VA = "0x189934ED0")]
		private void RVUFECEGSGI(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9935BF0", Offset = "0x99345F0", VA = "0x189935BF0")]
		private void VRFMZCRQJYV(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9933B10", Offset = "0x9932510", VA = "0x189933B10")]
		private void JAURAIDPHQJ(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9931940", Offset = "0x9930340", VA = "0x189931940")]
		private void CPUCMVTNTMC(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9932E80", Offset = "0x9931880", VA = "0x189932E80")]
		private void EVLSEGFOZMO(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9933510", Offset = "0x9931F10", VA = "0x189933510")]
		private void IKGMDLXTVWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9933880", Offset = "0x9932280", VA = "0x189933880")]
		private void IOLDNYATWSF(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9932AA0", Offset = "0x99314A0", VA = "0x189932AA0")]
		private void ETGFKRDKXTN(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x99321C0", Offset = "0x9930BC0", VA = "0x1899321C0")]
		private void DKSZEYRKPVJ(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9933FC0", Offset = "0x99329C0", VA = "0x189933FC0")]
		private void KFOWGHWZQDV(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9935D10", Offset = "0x9934710", VA = "0x189935D10")]
		private void VRFMZCRQJYV(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9935B10", Offset = "0x9934510", VA = "0x189935B10")]
		private void VNJFVPTRKXD(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9933A10", Offset = "0x9932410", VA = "0x189933A10")]
		private void IVRQOEAMQLV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9936BA0", Offset = "0x99355A0", VA = "0x189936BA0")]
		private void ZTRXZXWGXLJ(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99321B0", Offset = "0x9930BB0", VA = "0x1899321B0")]
		[CompilerGenerated]
		private void DCOANQQZORN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class DGGDXSNNWDX : JNIVCIZIPSX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private HVFCFCFDHNM FXQPHRSBZCK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static string SNLRDKYBUZL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static Func<string, string> OGJELKEBEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int PRNXYUBUDZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private string NJVBPQSYZOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private ObscuredInt TIZEUNKTPZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private bool? WEGAOFFGCRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private string PRGWZFVUTEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ulong RDHCGMWKHNJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public int VZGFRITWCRW
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool YGQTCBCFMPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xE6DD30", Offset = "0xE6C730", VA = "0x180E6DD30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xEB1710", Offset = "0xEB0110", VA = "0x180EB1710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool RRDPNHVLJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9930A80", Offset = "0x992F480", VA = "0x189930A80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> WGBOWOOJHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string THNLHEJYJZS
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9930830", Offset = "0x992F230", VA = "0x189930830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int STGMMRKFBAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x99307E0", Offset = "0x992F1E0", VA = "0x1899307E0", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9930B10", Offset = "0x992F510", VA = "0x189930B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VZILQGRGRTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x19AE0A0", Offset = "0x19ACAA0", VA = "0x1819AE0A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x19AE120", Offset = "0x19ACB20", VA = "0x1819AE120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BKOXDIVFKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x99309C0", Offset = "0x992F3C0", VA = "0x1899309C0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string BCRPWJINWZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9930920", Offset = "0x992F320", VA = "0x189930920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string NSNBBKFRWXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9930F90", Offset = "0x992F990", VA = "0x189930F90", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool LOEQAMEDLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object FXJSDKHMUOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong HJYRPWSOFES
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x99307C0", Offset = "0x992F1C0", VA = "0x1899307C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99310E0", Offset = "0x992FAE0", VA = "0x1899310E0")]
		internal DGGDXSNNWDX(HVFCFCFDHNM a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99310A0", Offset = "0x992FAA0", VA = "0x1899310A0")]
		internal DGGDXSNNWDX(HVFCFCFDHNM a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9931120", Offset = "0x992FB20", VA = "0x189931120")]
		internal DGGDXSNNWDX(HVFCFCFDHNM a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9930FF0", Offset = "0x992F9F0", VA = "0x189930FF0", Slot = "16")]
		public bool TXPQVQIAOHQ(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9930E70", Offset = "0x992F870", VA = "0x189930E70")]
		public NetworkedPlayerData POOIGMJLFVK()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9930B80", Offset = "0x992F580", VA = "0x189930B80")]
		internal void OZOMSBPHAWI([In] NetworkedPlayerData playerData, bool a = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class XVNVAXEZCRZ : AWTHKFEHXLT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HVFCFCFDHNM FXQPHRSBZCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Dictionary<object, object> JICSHVOINRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal Dictionary<int, DGGDXSNNWDX> QIXQCPGLBZH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public byte DFGAAQKITZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9939520", Offset = "0x9937F20", VA = "0x189939520", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool TANBQALYWQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xE70C80", Offset = "0xE6F680", VA = "0x180E70C80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Dictionary<object, object> WGBOWOOJHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public DGGDXSNNWDX[] EDYKELPYRMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public DGGDXSNNWDX[] GTIKPHMGGQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2C0", Offset = "0xCD9CC0", VA = "0x180CDB2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public DGGDXSNNWDX[] HDFMTTLTDBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DGGDXSNNWDX[] SGWIAIAVJAU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int MJQNOBUAIGY
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEA8A40", Offset = "0xEA7440", VA = "0x180EA8A40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1A9A900", Offset = "0x1A99300", VA = "0x181A9A900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9939E10", Offset = "0x9938810", VA = "0x189939E10")]
		public XVNVAXEZCRZ(HVFCFCFDHNM a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9939C00", Offset = "0x9938600", VA = "0x189939C00", Slot = "8")]
		public bool XAOPRJTXCFH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9939B50", Offset = "0x9938550", VA = "0x189939B50", Slot = "7")]
		public bool TXPQVQIAOHQ(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9939C60", Offset = "0x9938660", VA = "0x189939C60")]
		internal bool ZCNMCLBFLVI([In] NetworkedPlayerData playerData, bool a, [Out] DGGDXSNNWDX b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9939570", Offset = "0x9937F70", VA = "0x189939570")]
		internal void PIIJOGMELEV(ulong a, [Out] DGGDXSNNWDX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9939710", Offset = "0x9938110", VA = "0x189939710")]
		internal void RCMCUMQSLGC([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9939100", Offset = "0x9937B00", VA = "0x189939100")]
		private void AORRILBSJSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class WTJJGMLMXED : YHGHLVNQMBX, GIWROPIUCYR, RZOXWQLLXKJ, THRNSHIZZRL, JBWIPJPYTPJ, PGZUXXIKBWU, HQIVWAVMPUY, HDXFMLHGFWA, CCOMIRDRRSB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HVFCFCFDHNM FXQPHRSBZCK;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int URLNDODXFES
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9937F60", Offset = "0x9936960", VA = "0x189937F60", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int VXSCVTSQSQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int VIUXZCQAHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9937760", Offset = "0x9936160", VA = "0x189937760", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int OBLYGFALMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x99386F0", Offset = "0x99370F0", VA = "0x1899386F0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool XXKVZJBOJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xDE6AE0", Offset = "0xDE54E0", VA = "0x180DE6AE0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9938920", Offset = "0x9937320", VA = "0x189938920", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int HCVIRNYRRGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x99383D0", Offset = "0x9936DD0", VA = "0x1899383D0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9937BB0", Offset = "0x99365B0", VA = "0x189937BB0", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9938980", Offset = "0x9937380", VA = "0x189938980", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x99379C0", Offset = "0x99363C0", VA = "0x1899379C0", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool ATFDINOZHHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x99377D0", Offset = "0x99361D0", VA = "0x1899377D0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x99386A0", Offset = "0x99370A0", VA = "0x1899386A0", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9938FF0", Offset = "0x99379F0", VA = "0x189938FF0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int JCXFDFGCCTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9937810", Offset = "0x9936210", VA = "0x189937810", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int QDJMMEDTCRH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9937FF0", Offset = "0x99369F0", VA = "0x189937FF0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public JNIVCIZIPSX JXZBVLEPNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9938C20", Offset = "0x9937620", VA = "0x189938C20", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9938AD0", Offset = "0x99374D0", VA = "0x189938AD0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int DFGAAQKITZK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x99385A0", Offset = "0x9936FA0", VA = "0x1899385A0", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string SNLRDKYBUZL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9938D50", Offset = "0x9937750", VA = "0x189938D50", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> OGJELKEBEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9938E60", Offset = "0x9937860", VA = "0x189938E60", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public QOLRJJUHWXN TPTWEBAKSQF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9937DD0", Offset = "0x99367D0", VA = "0x189937DD0", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9938CA0", Offset = "0x99376A0", VA = "0x189938CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9937FC0", Offset = "0x99369C0", VA = "0x189937FC0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float HQPFACGNYVP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12AFDD0", Offset = "0x12AE7D0", VA = "0x1812AFDD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A779A0", Offset = "0x1A763A0", VA = "0x181A779A0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override SYVXMVIVSMY VTIAYBVPVXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9938450", Offset = "0x9936E50", VA = "0x189938450", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x99388E0", Offset = "0x99372E0", VA = "0x1899388E0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9938120", Offset = "0x9936B20", VA = "0x189938120", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long JBCXXGEZEAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9938610", Offset = "0x9937010", VA = "0x189938610", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long SGHGDBQEDHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x99383C0", Offset = "0x9936DC0", VA = "0x1899383C0", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<VZZVUJOFUEN> SEULJHVNYJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x99379E0", Offset = "0x99363E0", VA = "0x1899379E0", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9937690", Offset = "0x9936090", VA = "0x189937690", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<JNIVCIZIPSX> ABBOYDVOWWF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9938A20", Offset = "0x9937420", VA = "0x189938A20", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9938830", Offset = "0x9937230", VA = "0x189938830", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9938530", Offset = "0x9936F30", VA = "0x189938530")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9939010", Offset = "0x9937A10", VA = "0x189939010")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public WTJJGMLMXED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9937D30", Offset = "0x9936730", VA = "0x189937D30", Slot = "21")]
		public void FKRUBDBENNS(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9938BF0", Offset = "0x99375F0", VA = "0x189938BF0", Slot = "23")]
		public void URXDBQZOSHP(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9937E20", Offset = "0x9936820", VA = "0x189937E20", Slot = "27")]
		public void HBDIHWPLQAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9937870", Offset = "0x9936270", VA = "0x189937870", Slot = "47")]
		public bool CYAFZGEFHRF(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9937890", Offset = "0x9936290", VA = "0x189937890", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x99378C0", Offset = "0x99362C0", VA = "0x1899378C0", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9938D00", Offset = "0x9937700", VA = "0x189938D00", Slot = "22")]
		public void WWMLLCIZSYQ(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9938240", Offset = "0x9936C40", VA = "0x189938240", Slot = "75")]
		public JNIVCIZIPSX LFTZYTJFMLB(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9938620", Offset = "0x9937020", VA = "0x189938620", Slot = "74")]
		public JNIVCIZIPSX QPJFGSUGGOJ(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9937C10", Offset = "0x9936610", VA = "0x189937C10", Slot = "76")]
		public JNIVCIZIPSX ENKLWSKEEBX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9938340", Offset = "0x9936D40", VA = "0x189938340", Slot = "18")]
		public bool MTDTBHVFAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9938F60", Offset = "0x9937960", VA = "0x189938F60", Slot = "77")]
		public IReadOnlyList<JNIVCIZIPSX> ZXOGAFLDDTP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9938EC0", Offset = "0x99378C0", VA = "0x189938EC0", Slot = "78")]
		public IReadOnlyList<JNIVCIZIPSX> YENVYXZQREK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x99389A0", Offset = "0x99373A0", VA = "0x1899389A0", Slot = "45")]
		public bool TXELKWRQCPY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9938460", Offset = "0x9936E60", VA = "0x189938460", Slot = "20")]
		public void OLHQCGTYEQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9938CB0", Offset = "0x99376B0", VA = "0x189938CB0", Slot = "62")]
		public bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9938D30", Offset = "0x9937730", VA = "0x189938D30", Slot = "28")]
		public void XQIXCNAGDPI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9938CE0", Offset = "0x99376E0", VA = "0x189938CE0", Slot = "30")]
		public int WUPATQAEFXK(VZZVUJOFUEN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9937A90", Offset = "0x9936490", VA = "0x189937A90", Slot = "79")]
		public bool EKOJRVGZPFD(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9938090", Offset = "0x9936A90", VA = "0x189938090", Slot = "17")]
		public float KCLCQUXXBMW(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9937D70", Offset = "0x9936770", VA = "0x189937D70", Slot = "8")]
		public override void FRYZBTPERVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9938710", Offset = "0x9937110", VA = "0x189938710", Slot = "73")]
		public void SENIMATDESJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9937F60", Offset = "0x9936960", VA = "0x189937F60", Slot = "87")]
		public int XIGGYNIAFOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9938110", Offset = "0x9936B10", VA = "0x189938110", Slot = "11")]
		private void KKSMJMJKXHM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9937740", Offset = "0x9936140", VA = "0x189937740", Slot = "12")]
		private void APVACTKKHRF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9938330", Offset = "0x9936D30", VA = "0x189938330", Slot = "25")]
		private void LWPCRAHAONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9937FE0", Offset = "0x99369E0", VA = "0x189937FE0", Slot = "26")]
		private void JQSOIHLJAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9937D10", Offset = "0x9936710", VA = "0x189937D10", Slot = "31")]
		private void EOOJGMFQRND(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9938690", Offset = "0x9937090", VA = "0x189938690", Slot = "32")]
		private void QXFFXIHUUSI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9938C90", Offset = "0x9937690", VA = "0x189938C90", Slot = "48")]
		private void VNXJDMRHKVV(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9937750", Offset = "0x9936150", VA = "0x189937750", Slot = "49")]
		private void AWZOWCJUFEE(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9937D50", Offset = "0x9936750", VA = "0x189937D50", Slot = "50")]
		private void FMXKMLTJGDS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x99383A0", Offset = "0x9936DA0", VA = "0x1899383A0", Slot = "51")]
		private void MTTXSNZSFFJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9938230", Offset = "0x9936C30", VA = "0x189938230", Slot = "52")]
		private void LEWBVIXRQXN(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9938600", Offset = "0x9937000", VA = "0x189938600", Slot = "53")]
		private IDisposable PHLGALIIVWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x99383B0", Offset = "0x9936DB0", VA = "0x1899383B0", Slot = "54")]
		private bool MUUEVSRIBNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9938F50", Offset = "0x9937950", VA = "0x189938F50", Slot = "55")]
		private void ZKPJYKBTNRR(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9937D20", Offset = "0x9936720", VA = "0x189937D20", Slot = "57")]
		private void ESJUYANHFET(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9938820", Offset = "0x9937220", VA = "0x189938820", Slot = "58")]
		private void SHBRABYUEOG(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9937D60", Offset = "0x9936760", VA = "0x189937D60", Slot = "80")]
		private void FNUUCUYQGYJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9938D20", Offset = "0x9937720", VA = "0x189938D20", Slot = "81")]
		private void XLHSWRBIBIA(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9938100", Offset = "0x9936B00", VA = "0x189938100", Slot = "82")]
		private void KGSNNUHRIQI()
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
		public NfgoCommsNetwork XPRMXOUDCLB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9931230", Offset = "0x992FC30", VA = "0x189931230")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9931440", Offset = "0x992FE40", VA = "0x189931440")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x99313F0", Offset = "0x992FDF0", VA = "0x1899313F0")]
		private void CVJBDBXGDXI(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99371C0", Offset = "0x9935BC0", VA = "0x1899371C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
		public NetworkManagerBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VDFACKRMLRS
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool OSHGBPNDZZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xD28710", Offset = "0xD27110", VA = "0x180D28710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xDDC880", Offset = "0xDDB280", VA = "0x180DDC880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager FAOVIIZVLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager PDTUVNZNMVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager GZVDHGCUOFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<NetworkManager, bool> CVJBDBXGDXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9937440", Offset = "0x9935E40", VA = "0x189937440")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9937390", Offset = "0x9935D90", VA = "0x189937390")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x99375D0", Offset = "0x9935FD0", VA = "0x1899375D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public VDFACKRMLRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9937560", Offset = "0x9935F60", VA = "0x189937560")]
		[ONTQUCAGRJW.Root]
		public static void RRMGVEZSOHJ(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x99374F0", Offset = "0x9935EF0", VA = "0x1899374F0")]
		public void OVOPVECAJYF(NetworkManager a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GZVDHGCUOFA : INetworkManager, INetworkUpdateSystem
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float FNHLFQKGLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private CustomMessagingManager.HandleNamedMessageDelegate TERPTXJJRCB;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ulong LocalClientId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xD3D590", Offset = "0xD3BF90", VA = "0x180D3D590", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCDB270", Offset = "0xCD9C70", VA = "0x180CDB270", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCDB290", Offset = "0xCD9C90", VA = "0x180CDB290", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x99316A0", Offset = "0x99300A0", VA = "0x1899316A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x99317F0", Offset = "0x99301F0", VA = "0x1899317F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9931750", Offset = "0x9930150", VA = "0x189931750", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x99318A0", Offset = "0x99302A0", VA = "0x1899318A0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x99315B0", Offset = "0x992FFB0", VA = "0x1899315B0", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x99315B0", Offset = "0x992FFB0", VA = "0x1899315B0", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9931630", Offset = "0x9930030", VA = "0x189931630")]
		public GZVDHGCUOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x99315D0", Offset = "0x992FFD0", VA = "0x1899315D0", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x99315F0", Offset = "0x992FFF0", VA = "0x1899315F0", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9931610", Offset = "0x9930010", VA = "0x189931610", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "21")]
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
