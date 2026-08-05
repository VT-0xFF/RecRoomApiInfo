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
		[Cpp2IlInjected.Address(RVA = "0x9A9CF50", Offset = "0x9A9B950", VA = "0x189A9CF50", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD61BA0", Offset = "0xD605A0", VA = "0x180D61BA0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(byte);
				}
				[Cpp2IlInjected.Token(Token = "0x6000050")]
				[Cpp2IlInjected.Address(RVA = "0xE2FFA0", Offset = "0xE2E9A0", VA = "0x180E2FFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public int TNCIAZFLYKB
			{
				[Cpp2IlInjected.Token(Token = "0x6000051")]
				[Cpp2IlInjected.Address(RVA = "0xE26DB0", Offset = "0xE257B0", VA = "0x180E26DB0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000052")]
				[Cpp2IlInjected.Address(RVA = "0xE26CE0", Offset = "0xE256E0", VA = "0x180E26CE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public object CCOAMSFLWRN
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000054")]
				[Cpp2IlInjected.Address(RVA = "0xD11E10", Offset = "0xD10810", VA = "0x180D11E10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x92EA0E0", Offset = "0x92E8AE0", VA = "0x1892EA0E0")]
			public YKKHLHTEHVV(byte a, int b, object c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9A9CF10", Offset = "0x9A9B910", VA = "0x189A9CF10", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private LiteNetLibTransport TEKTDVEMLKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9A97A10", Offset = "0x9A96410", VA = "0x189A97A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ClientState JMOGAOLIVKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9A98600", Offset = "0x9A97000", VA = "0x189A98600", Slot = "4")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9A98120", Offset = "0x9A96B20", VA = "0x189A98120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OBLYGFALMNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD0C6C0", Offset = "0xD0B0C0", VA = "0x180D0C6C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public DGGDXSNNWDX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD14260", Offset = "0xD12C60", VA = "0x180D14260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public XVNVAXEZCRZ XBEDGBSZWDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private AWTHKFEHXLT LBSJLBWKTAD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9A97E40", Offset = "0x9A96840", VA = "0x189A97E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool GPAEVOFPUCH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9A95250", Offset = "0x9A93C50", VA = "0x189A95250", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x9A95250", Offset = "0x9A93C50", VA = "0x189A95250", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xDAEE20", Offset = "0xDAD820", VA = "0x180DAEE20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9A95950", Offset = "0x9A94350", VA = "0x189A95950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Exception FVMFOCZHHWF
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD0E8F0", Offset = "0xD0D2F0", VA = "0x180D0E8F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD0EB00", Offset = "0xD0D500", VA = "0x180D0EB00", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BDUBWMRIMRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool BKHHWFVBFRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9A96580", Offset = "0x9A94F80", VA = "0x189A96580", Slot = "14")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A999B0", Offset = "0x9A983B0", VA = "0x189A999B0", Slot = "15")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD14AB0", Offset = "0xD134B0", VA = "0x180D14AB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xD142D0", Offset = "0xD12CD0", VA = "0x180D142D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9A980D0", Offset = "0x9A96AD0", VA = "0x189A980D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public double BQXUUPASKOS
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9A973F0", Offset = "0x9A95DF0", VA = "0x189A973F0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public int URLNDODXFES
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9A96530", Offset = "0x9A94F30", VA = "0x189A96530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9A972F0", Offset = "0x9A95CF0", VA = "0x189A972F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public int ONCGLEBHNVC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9A98620", Offset = "0x9A97020", VA = "0x189A98620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public QOLRJJUHWXN TPTWEBAKSQF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9A96490", Offset = "0x9A94E90", VA = "0x189A96490", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xFD2430", Offset = "0xFD0E30", VA = "0x180FD2430")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9A980A0", Offset = "0x9A96AA0", VA = "0x189A980A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string, long> NXPMPDFOVRH
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9A99A10", Offset = "0x9A98410", VA = "0x189A99A10", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9A976C0", Offset = "0x9A960C0", VA = "0x189A976C0", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState, ClientState> XLPMIKKPUQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9A97FF0", Offset = "0x9A969F0", VA = "0x189A97FF0", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9A958A0", Offset = "0x9A942A0", VA = "0x189A958A0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A99F70", Offset = "0x9A98970", VA = "0x189A99F70")]
		public HVFCFCFDHNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A94F50", Offset = "0x9A93950", VA = "0x189A94F50")]
		public bool Connect(object appSettings)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A95D40", Offset = "0x9A94740", VA = "0x189A95D40")]
		private void EUVAWECXDYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A96430", Offset = "0x9A94E30", VA = "0x189A96430")]
		private void GTTCGHCTPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A95A70", Offset = "0x9A94470", VA = "0x189A95A70")]
		public bool EKOJRVGZPFD(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A964E0", Offset = "0x9A94EE0", VA = "0x189A964E0")]
		public bool HGTCIUCQXTI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A97E70", Offset = "0x9A96870", VA = "0x189A97E70")]
		public void RMPMWEPEJXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A99AC0", Offset = "0x9A984C0", VA = "0x189A99AC0")]
		public void ZETHCNPUFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9A96240", Offset = "0x9A94C40", VA = "0x189A96240")]
		public void FKRUBDBENNS(List<object> a, int b = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A99490", Offset = "0x9A97E90", VA = "0x189A99490")]
		public void WWMLLCIZSYQ(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A98680", Offset = "0x9A97080", VA = "0x189A98680")]
		public void URXDBQZOSHP(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A99720", Offset = "0x9A98120", VA = "0x189A99720")]
		public void XQIXCNAGDPI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9A95560", Offset = "0x9A93F60", VA = "0x189A95560")]
		public object Deserialize(NativeArray<byte> src)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9A992A0", Offset = "0x9A97CA0", VA = "0x189A992A0")]
		public int WUPATQAEFXK(VZZVUJOFUEN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A98E50", Offset = "0x9A97850", VA = "0x189A98E50")]
		public bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A98150", Offset = "0x9A96B50", VA = "0x189A98150")]
		public bool TXELKWRQCPY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A96E50", Offset = "0x9A95850", VA = "0x189A96E50")]
		internal bool KEPRVKUVTGC([In] NetworkedPlayerData playerData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A96BF0", Offset = "0x9A955F0", VA = "0x189A96BF0")]
		internal bool KDMLUGQZJVK([In] NetworkedRoomData roomData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A97530", Offset = "0x9A95F30", VA = "0x189A97530")]
		private void OAVXNJTWMAP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A95650", Offset = "0x9A94050", VA = "0x189A95650")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A95750", Offset = "0x9A94150", VA = "0x189A95750", Slot = "17")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A97190", Offset = "0x9A95B90", VA = "0x189A97190")]
		private void KXKLJYSADZD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9A97B20", Offset = "0x9A96520", VA = "0x189A97B20")]
		private void RAWZXEKQJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A97440", Offset = "0x9A95E40", VA = "0x189A97440")]
		private void NLZDULQOQVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A97770", Offset = "0x9A96170", VA = "0x189A97770")]
		private void PNWWEBAIAPC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A98870", Offset = "0x9A97270", VA = "0x189A98870")]
		private void UTXSJFMIQSN(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B30BA0", Offset = "0x3B2F5A0", VA = "0x183B30BA0")]
		private void BOCDAOXTXNP<a>(NetworkEventCode a, FastBufferReader b) where a : INetworkSerializable, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A97EC0", Offset = "0x9A968C0", VA = "0x189A97EC0")]
		private void RVUFECEGSGI(byte a, int b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A98BE0", Offset = "0x9A975E0", VA = "0x189A98BE0")]
		private void VRFMZCRQJYV(ulong a, FastBufferReader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A96BC0", Offset = "0x9A955C0", VA = "0x189A96BC0")]
		private void JAURAIDPHQJ(byte a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A94A30", Offset = "0x9A93430", VA = "0x189A94A30")]
		private void CPUCMVTNTMC(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A95F50", Offset = "0x9A94950", VA = "0x189A95F50")]
		private void EVLSEGFOZMO(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A965D0", Offset = "0x9A94FD0", VA = "0x189A965D0")]
		private void IKGMDLXTVWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A96940", Offset = "0x9A95340", VA = "0x189A96940")]
		private void IOLDNYATWSF(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9A95B90", Offset = "0x9A94590", VA = "0x189A95B90")]
		private void ETGFKRDKXTN(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9A952B0", Offset = "0x9A93CB0", VA = "0x189A952B0")]
		private void DKSZEYRKPVJ(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A97070", Offset = "0x9A95A70", VA = "0x189A97070")]
		private void KFOWGHWZQDV(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9A98D00", Offset = "0x9A97700", VA = "0x189A98D00")]
		private void VRFMZCRQJYV(YKKHLHTEHVV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A98B00", Offset = "0x9A97500", VA = "0x189A98B00")]
		private void VNJFVPTRKXD(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A96AC0", Offset = "0x9A954C0", VA = "0x189A96AC0")]
		private void IVRQOEAMQLV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9A99B80", Offset = "0x9A98580", VA = "0x189A99B80")]
		private void ZTRXZXWGXLJ(DisconnectCause a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9A952A0", Offset = "0x9A93CA0", VA = "0x189A952A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool YGQTCBCFMPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xEA53F0", Offset = "0xEA3DF0", VA = "0x180EA53F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xEE9480", Offset = "0xEE7E80", VA = "0x180EE9480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool RRDPNHVLJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9A93B70", Offset = "0x9A92570", VA = "0x189A93B70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Dictionary<object, object> WGBOWOOJHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9A93920", Offset = "0x9A92320", VA = "0x189A93920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int STGMMRKFBAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9A938D0", Offset = "0x9A922D0", VA = "0x189A938D0", Slot = "9")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9A93C00", Offset = "0x9A92600", VA = "0x189A93C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VZILQGRGRTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1A0D830", Offset = "0x1A0C230", VA = "0x181A0D830", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1A0D8B0", Offset = "0x1A0C2B0", VA = "0x181A0D8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BKOXDIVFKAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9A93AB0", Offset = "0x9A924B0", VA = "0x189A93AB0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string BCRPWJINWZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0", Slot = "17")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9A93A10", Offset = "0x9A92410", VA = "0x189A93A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string NSNBBKFRWXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x9A94080", Offset = "0x9A92A80", VA = "0x189A94080", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool LOEQAMEDLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public object FXJSDKHMUOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xD0E930", Offset = "0xD0D330", VA = "0x180D0E930", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD0E910", Offset = "0xD0D310", VA = "0x180D0E910", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal ulong HJYRPWSOFES
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD0E8F0", Offset = "0xD0D2F0", VA = "0x180D0E8F0")]
			get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9A938B0", Offset = "0x9A922B0", VA = "0x189A938B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9A941D0", Offset = "0x9A92BD0", VA = "0x189A941D0")]
		internal DGGDXSNNWDX(HVFCFCFDHNM a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9A94190", Offset = "0x9A92B90", VA = "0x189A94190")]
		internal DGGDXSNNWDX(HVFCFCFDHNM a, bool b, ulong c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9A94210", Offset = "0x9A92C10", VA = "0x189A94210")]
		internal DGGDXSNNWDX(HVFCFCFDHNM a, bool b, [In] NetworkedPlayerData networkedPlayerData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9A940E0", Offset = "0x9A92AE0", VA = "0x189A940E0", Slot = "16")]
		public bool TXPQVQIAOHQ(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9A93F60", Offset = "0x9A92960", VA = "0x189A93F60")]
		public NetworkedPlayerData POOIGMJLFVK()
		{
			return default(NetworkedPlayerData);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9A93C70", Offset = "0x9A92670", VA = "0x189A93C70")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A9C4A0", Offset = "0x9A9AEA0", VA = "0x189A9C4A0", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool TANBQALYWQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEA8300", Offset = "0xEA6D00", VA = "0x180EA8300", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public DGGDXSNNWDX[] EDYKELPYRMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCE0", Offset = "0xD0B6E0", VA = "0x180D0CCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public DGGDXSNNWDX[] GTIKPHMGGQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xD14330", Offset = "0xD12D30", VA = "0x180D14330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xD142C0", Offset = "0xD12CC0", VA = "0x180D142C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public DGGDXSNNWDX[] HDFMTTLTDBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD14260", Offset = "0xD12C60", VA = "0x180D14260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xD14280", Offset = "0xD12C80", VA = "0x180D14280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DGGDXSNNWDX[] SGWIAIAVJAU
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xD106A0", Offset = "0xD0F0A0", VA = "0x180D106A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int MJQNOBUAIGY
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xEFA630", Offset = "0xEF9030", VA = "0x180EFA630")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8070", Offset = "0x1AC6A70", VA = "0x181AC8070")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9A9CD80", Offset = "0x9A9B780", VA = "0x189A9CD80")]
		public XVNVAXEZCRZ(HVFCFCFDHNM a, [In] NetworkedRoomData roomData, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9A9CB70", Offset = "0x9A9B570", VA = "0x189A9CB70", Slot = "8")]
		public bool XAOPRJTXCFH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9A9CAC0", Offset = "0x9A9B4C0", VA = "0x189A9CAC0", Slot = "7")]
		public bool TXPQVQIAOHQ(Dictionary<object, object> a, [Optional] Dictionary<object, object> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9A9CBD0", Offset = "0x9A9B5D0", VA = "0x189A9CBD0")]
		internal bool ZCNMCLBFLVI([In] NetworkedPlayerData playerData, bool a, [Out] DGGDXSNNWDX b, bool c = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C4F0", Offset = "0x9A9AEF0", VA = "0x189A9C4F0")]
		internal void PIIJOGMELEV(ulong a, [Out] DGGDXSNNWDX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C680", Offset = "0x9A9B080", VA = "0x189A9C680")]
		internal void RCMCUMQSLGC([In] NetworkedRoomData roomData, bool a = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C0B0", Offset = "0x9A9AAB0", VA = "0x189A9C0B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A9AF30", Offset = "0x9A99930", VA = "0x189A9AF30", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int VXSCVTSQSQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int VIUXZCQAHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A730", Offset = "0x9A99130", VA = "0x189A9A730", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public int OBLYGFALMNF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B6C0", Offset = "0x9A9A0C0", VA = "0x189A9B6C0", Slot = "24")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool XXKVZJBOJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xE1CD70", Offset = "0xE1B770", VA = "0x180E1CD70", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public double FDWSQFUVLVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B8F0", Offset = "0x9A9A2F0", VA = "0x189A9B8F0", Slot = "34")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public int HCVIRNYRRGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B3A0", Offset = "0x9A99DA0", VA = "0x189A9B3A0", Slot = "35")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool HTAVRBTTHTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9A9AB80", Offset = "0x9A99580", VA = "0x189A9AB80", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool QCMQRXBGJQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B950", Offset = "0x9A9A350", VA = "0x189A9B950", Slot = "40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A990", Offset = "0x9A99390", VA = "0x189A9A990", Slot = "41")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool ATFDINOZHHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A7A0", Offset = "0x9A991A0", VA = "0x189A9A7A0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B670", Offset = "0x9A9A070", VA = "0x189A9B670", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BFA0", Offset = "0x9A9A9A0", VA = "0x189A9BFA0", Slot = "65")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int JCXFDFGCCTQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A7E0", Offset = "0x9A991E0", VA = "0x189A9A7E0", Slot = "66")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int QDJMMEDTCRH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9A9AFC0", Offset = "0x9A999C0", VA = "0x189A9AFC0", Slot = "67")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public JNIVCIZIPSX JXZBVLEPNLB
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BBF0", Offset = "0x9A9A5F0", VA = "0x189A9BBF0", Slot = "68")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BAA0", Offset = "0x9A9A4A0", VA = "0x189A9BAA0", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int DFGAAQKITZK
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B570", Offset = "0x9A99F70", VA = "0x189A9B570", Slot = "70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string SNLRDKYBUZL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BD20", Offset = "0x9A9A720", VA = "0x189A9BD20", Slot = "71")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Func<string, string> OGJELKEBEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BE20", Offset = "0x9A9A820", VA = "0x189A9BE20", Slot = "72")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public QOLRJJUHWXN TPTWEBAKSQF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9A9ADA0", Offset = "0x9A997A0", VA = "0x189A9ADA0", Slot = "83")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool XODKJJIQPOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x9A9BC70", Offset = "0x9A9A670", VA = "0x189A9BC70", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x9A9AF90", Offset = "0x9A99990", VA = "0x189A9AF90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override float HQPFACGNYVP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x12DE700", Offset = "0x12DD100", VA = "0x1812DE700", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x1AA5220", Offset = "0x1AA3C20", VA = "0x181AA5220", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override SYVXMVIVSMY VTIAYBVPVXB
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xD0E900", Offset = "0xD0D300", VA = "0x180D0E900", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool XHYYIVEOFJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B420", Offset = "0x9A99E20", VA = "0x189A9B420", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B8B0", Offset = "0x9A9A2B0", VA = "0x189A9B8B0", Slot = "37")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string FCRDZFKYZMZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B0F0", Offset = "0x9A99AF0", VA = "0x189A9B0F0", Slot = "84")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public long JBCXXGEZEAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B5E0", Offset = "0x9A99FE0", VA = "0x189A9B5E0", Slot = "85")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public long SGHGDBQEDHR
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B390", Offset = "0x9A99D90", VA = "0x189A9B390", Slot = "86")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<VZZVUJOFUEN> SEULJHVNYJA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A9B0", Offset = "0x9A993B0", VA = "0x189A9A9B0", Slot = "59")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A660", Offset = "0x9A99060", VA = "0x189A9A660", Slot = "60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<JNIVCIZIPSX> ABBOYDVOWWF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B9F0", Offset = "0x9A9A3F0", VA = "0x189A9B9F0", Slot = "63")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9A9B800", Offset = "0x9A9A200", VA = "0x189A9B800", Slot = "64")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B500", Offset = "0x9A99F00", VA = "0x189A9B500")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BFC0", Offset = "0x9A9A9C0", VA = "0x189A9BFC0")]
		[RecRoom.DataLayer.Attributes.Preserve]
		public WTJJGMLMXED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AD00", Offset = "0x9A99700", VA = "0x189A9AD00", Slot = "21")]
		public void FKRUBDBENNS(List<object> a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BBC0", Offset = "0x9A9A5C0", VA = "0x189A9BBC0", Slot = "23")]
		public void URXDBQZOSHP(object a, int b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9A9ADF0", Offset = "0x9A997F0", VA = "0x189A9ADF0", Slot = "27")]
		public void HBDIHWPLQAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A840", Offset = "0x9A99240", VA = "0x189A9A840", Slot = "47")]
		public bool CYAFZGEFHRF(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A860", Offset = "0x9A99260", VA = "0x189A9A860", Slot = "29")]
		public object Deserialize(NativeArray<byte> data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A890", Offset = "0x9A99290", VA = "0x189A9A890", Slot = "46")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BCD0", Offset = "0x9A9A6D0", VA = "0x189A9BCD0", Slot = "22")]
		public void WWMLLCIZSYQ(int a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B210", Offset = "0x9A99C10", VA = "0x189A9B210", Slot = "75")]
		public JNIVCIZIPSX LFTZYTJFMLB(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B5F0", Offset = "0x9A99FF0", VA = "0x189A9B5F0", Slot = "74")]
		public JNIVCIZIPSX QPJFGSUGGOJ(int a, bool b = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9A9ABE0", Offset = "0x9A995E0", VA = "0x189A9ABE0", Slot = "76")]
		public JNIVCIZIPSX ENKLWSKEEBX(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B310", Offset = "0x9A99D10", VA = "0x189A9B310", Slot = "18")]
		public bool MTDTBHVFAVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BF10", Offset = "0x9A9A910", VA = "0x189A9BF10", Slot = "77")]
		public IReadOnlyList<JNIVCIZIPSX> ZXOGAFLDDTP(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BE70", Offset = "0x9A9A870", VA = "0x189A9BE70", Slot = "78")]
		public IReadOnlyList<JNIVCIZIPSX> YENVYXZQREK(bool a = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B970", Offset = "0x9A9A370", VA = "0x189A9B970", Slot = "45")]
		public bool TXELKWRQCPY(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B430", Offset = "0x9A99E30", VA = "0x189A9B430", Slot = "20")]
		public void OLHQCGTYEQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BC80", Offset = "0x9A9A680", VA = "0x189A9BC80", Slot = "62")]
		public bool WDVHFRRPINS(byte a, object b, BJJNNDTQGRE c, RRNetworkDelivery d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BD00", Offset = "0x9A9A700", VA = "0x189A9BD00", Slot = "28")]
		public void XQIXCNAGDPI(object a, NativeList<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BCB0", Offset = "0x9A9A6B0", VA = "0x189A9BCB0", Slot = "30")]
		public int WUPATQAEFXK(VZZVUJOFUEN a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AA60", Offset = "0x9A99460", VA = "0x189A9AA60", Slot = "79")]
		public bool EKOJRVGZPFD(JNIVCIZIPSX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B060", Offset = "0x9A99A60", VA = "0x189A9B060", Slot = "17")]
		public float KCLCQUXXBMW(bool a, int b = 1)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AD40", Offset = "0x9A99740", VA = "0x189A9AD40", Slot = "8")]
		public override void FRYZBTPERVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B6E0", Offset = "0x9A9A0E0", VA = "0x189A9B6E0", Slot = "73")]
		public void SENIMATDESJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AF30", Offset = "0x9A99930", VA = "0x189A9AF30", Slot = "87")]
		public int XIGGYNIAFOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B0E0", Offset = "0x9A99AE0", VA = "0x189A9B0E0", Slot = "11")]
		private void KKSMJMJKXHM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A710", Offset = "0x9A99110", VA = "0x189A9A710", Slot = "12")]
		private void APVACTKKHRF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B300", Offset = "0x9A99D00", VA = "0x189A9B300", Slot = "25")]
		private void LWPCRAHAONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AFB0", Offset = "0x9A999B0", VA = "0x189A9AFB0", Slot = "26")]
		private void JQSOIHLJAEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9A9ACE0", Offset = "0x9A996E0", VA = "0x189A9ACE0", Slot = "31")]
		private void EOOJGMFQRND(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B660", Offset = "0x9A9A060", VA = "0x189A9B660", Slot = "32")]
		private void QXFFXIHUUSI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BC60", Offset = "0x9A9A660", VA = "0x189A9BC60", Slot = "48")]
		private void VNXJDMRHKVV(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A720", Offset = "0x9A99120", VA = "0x189A9A720", Slot = "49")]
		private void AWZOWCJUFEE(Action<bool> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AD20", Offset = "0x9A99720", VA = "0x189A9AD20", Slot = "50")]
		private void FMXKMLTJGDS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B370", Offset = "0x9A99D70", VA = "0x189A9B370", Slot = "51")]
		private void MTTXSNZSFFJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B200", Offset = "0x9A99C00", VA = "0x189A9B200", Slot = "52")]
		private void LEWBVIXRQXN(object a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B5D0", Offset = "0x9A99FD0", VA = "0x189A9B5D0", Slot = "53")]
		private IDisposable PHLGALIIVWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B380", Offset = "0x9A99D80", VA = "0x189A9B380", Slot = "54")]
		private bool MUUEVSRIBNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BF00", Offset = "0x9A9A900", VA = "0x189A9BF00", Slot = "55")]
		private void ZKPJYKBTNRR(StringBuilder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9A9ACF0", Offset = "0x9A996F0", VA = "0x189A9ACF0", Slot = "57")]
		private void ESJUYANHFET(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B7F0", Offset = "0x9A9A1F0", VA = "0x189A9B7F0", Slot = "58")]
		private void SHBRABYUEOG(Action<string, long> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9A9AD30", Offset = "0x9A99730", VA = "0x189A9AD30", Slot = "80")]
		private void FNUUCUYQGYJ(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BCF0", Offset = "0x9A9A6F0", VA = "0x189A9BCF0", Slot = "81")]
		private void XLHSWRBIBIA(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9A9B0D0", Offset = "0x9A99AD0", VA = "0x189A9B0D0", Slot = "82")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9A94320", Offset = "0x9A92D20", VA = "0x189A94320")]
		public void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9A94530", Offset = "0x9A92F30", VA = "0x189A94530")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9A944E0", Offset = "0x9A92EE0", VA = "0x189A944E0")]
		private void CVJBDBXGDXI(NetworkManager a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4B0", Offset = "0xD08EB0", VA = "0x180D0A4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A9A190", Offset = "0x9A98B90", VA = "0x189A9A190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4B0", Offset = "0xD08EB0", VA = "0x180D0A4B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD61BA0", Offset = "0xD605A0", VA = "0x180D61BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xE2FFA0", Offset = "0xE2E9A0", VA = "0x180E2FFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public NetworkManager FAOVIIZVLCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD0B7E0", Offset = "0xD0A1E0", VA = "0x180D0B7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public NetworkManager PDTUVNZNMVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD11E20", Offset = "0xD10820", VA = "0x180D11E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD0B7F0", Offset = "0xD0A1F0", VA = "0x180D0B7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public INetworkManager GZVDHGCUOFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9A9A410", Offset = "0x9A98E10", VA = "0x189A9A410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x9A9A360", Offset = "0x9A98D60", VA = "0x189A9A360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A5A0", Offset = "0x9A98FA0", VA = "0x189A9A5A0")]
		[RecRoom.NoEngine.Common.Preserve]
		public VDFACKRMLRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A530", Offset = "0x9A98F30", VA = "0x189A9A530")]
		[ONTQUCAGRJW.Root]
		public static void RRMGVEZSOHJ(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A4C0", Offset = "0x9A98EC0", VA = "0x189A9A4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD76980", Offset = "0xD75380", VA = "0x180D76980", Slot = "8")]
			get
			{
				return default(ulong);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DeferMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xD14270", Offset = "0xD12C70", VA = "0x180D14270", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xD14290", Offset = "0xD12C90", VA = "0x180D14290", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool IsConnectedClient
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ulong> OnClientDisconnectCallback
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9A94790", Offset = "0x9A93190", VA = "0x189A94790", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9A948E0", Offset = "0x9A932E0", VA = "0x189A948E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action OnIncommingMessagesProcessed
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x9A94840", Offset = "0x9A93240", VA = "0x189A94840", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9A94990", Offset = "0x9A93390", VA = "0x189A94990", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9A946A0", Offset = "0x9A930A0", VA = "0x189A946A0", Slot = "12")]
		public double GetLocalTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9A946A0", Offset = "0x9A930A0", VA = "0x189A946A0", Slot = "13")]
		public double GetServerTime()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "14")]
		public int GetRoundTripTime()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4D0", Offset = "0xD08ED0", VA = "0x180D0A4D0", Slot = "15")]
		public NetworkConfig GetNetworkConfig()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "16")]
		public void SendAllOutgoingMessages(bool processDeferredMessages = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "17")]
		public void ClearOutgoingMessages(bool deferredOnly = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "18")]
		public void ProcessIncommingMessages()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9A94720", Offset = "0x9A93120", VA = "0x189A94720")]
		public GZVDHGCUOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9A946C0", Offset = "0x9A930C0", VA = "0x189A946C0", Slot = "22")]
		public void NetworkUpdate(NetworkUpdateStage updateStage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9A946E0", Offset = "0x9A930E0", VA = "0x189A946E0", Slot = "19")]
		public void RegisterNamedMessageHandler(NamedMessageType name, CustomMessagingManager.HandleNamedMessageDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9A94700", Offset = "0x9A93100", VA = "0x189A94700", Slot = "20")]
		public void UnregisterNamedMessageHandler(NamedMessageType name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "21")]
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
