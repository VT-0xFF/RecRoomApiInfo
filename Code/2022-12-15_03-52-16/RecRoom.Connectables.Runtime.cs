using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.ObjectModel.Connectables;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[Preserve]
public class JJMMJGPJMJE : KHLFGBCHPJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private Transform HJLACGOIJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NMHMDBFHOBL KKMCOADLCAG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3153280", Offset = "0x3151C80", VA = "0x183153280", Slot = "4")]
	public void OIEJOMHJJDA(Transform HJLACGOIJCA, NMHMDBFHOBL KKMCOADLCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x51F5B60", Offset = "0x51F4560", VA = "0x1851F5B60", Slot = "5")]
	public NMHMDBFHOBL AAMLBALCMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public JJMMJGPJMJE()
	{
	}
}
namespace RecRoom.ObjectModel.Connectables
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DAINLFLPADL(OHEDAGNNHJA.Connectables)]
	public sealed class OMConnectableManager : IHBAODPGPGM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class IGBMEIOJKDK : IEnumerable<OKOJNEBFOCP>, IEnumerable, IEnumerator<OKOJNEBFOCP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private OKOJNEBFOCP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private NIALADIPDNC localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public NIALADIPDNC <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public OMConnectableManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private CLJEHOFLHAA <objects>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private OKKOFBJCFMA.JCEGJGKGBBH <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private OKOJNEBFOCP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675AC0", VA = "0x1806770C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8E9410", Offset = "0x8E7E10", VA = "0x1808E9410")]
			[DebuggerHidden]
			public IGBMEIOJKDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x51F56D0", Offset = "0x51F40D0", VA = "0x1851F56D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x51F52B0", Offset = "0x51F3CB0", VA = "0x1851F52B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x51F5730", Offset = "0x51F4130", VA = "0x1851F5730")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x51F5690", Offset = "0x51F4090", VA = "0x1851F5690", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x51F55E0", Offset = "0x51F3FE0", VA = "0x1851F55E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<OKOJNEBFOCP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x51F55E0", Offset = "0x51F3FE0", VA = "0x1851F55E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly FGGEJMNNOEE LAEOPKAJMLP;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FGGEJMNNOEE FNLBOAPPJMJ;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly FGGEJMNNOEE BNDKKCMGCDH;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly FGGEJMNNOEE LKBLEIEBFLM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly FGGEJMNNOEE CLPPHKNBKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private ALNELIOAEHM HBIMMJCLEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private OPAKLFEDMAA BFIDBOCPJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KLEAMHNNPIE NBJJAAKBODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PNINELHDCOE OMJELDHKGJM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const int PHKJOICPFLL = 0;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const int EJDBDBEAPKD = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EGGANIJGBAJ GOCENLCAMDB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OKJAKPPJFHO
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6540", VA = "0x1809F7B40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9F7CE0", Offset = "0x9F66E0", VA = "0x1809F7CE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x5203CF0", Offset = "0x52026F0", VA = "0x185203CF0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5202B80", Offset = "0x5201580", VA = "0x185202B80", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5203C50", Offset = "0x5202650", VA = "0x185203C50", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x5203B90", Offset = "0x5202590", VA = "0x185203B90", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5205680", Offset = "0x5204080", VA = "0x185205680", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5201BE0", Offset = "0x52005E0", VA = "0x185201BE0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5205BD0", Offset = "0x52045D0", VA = "0x185205BD0")]
		public OMConnectableManager(PEGEFOEHCCC IGFHDABHNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5205230", Offset = "0x5203C30", VA = "0x185205230", Slot = "11")]
		public void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x52025A0", Offset = "0x5200FA0", VA = "0x1852025A0", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x51F4560", Offset = "0x51F2F60", VA = "0x1851F4560", Slot = "22")]
		public bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x52027A0", Offset = "0x52011A0", VA = "0x1852027A0")]
		private void ECJPEHKGLKD(NIALADIPDNC KHFJHKDEPOA, NIALADIPDNC CFCDMOHCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5205780", Offset = "0x5204180", VA = "0x185205780")]
		private void PNDKHINKPFK(NIALADIPDNC KHFJHKDEPOA, NIALADIPDNC EDCJDKGNJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5204B10", Offset = "0x5203510", VA = "0x185204B10")]
		private void MLPGHOGOJLP(NIALADIPDNC KHFJHKDEPOA, NIALADIPDNC EDCJDKGNJGI, NIALADIPDNC CFCDMOHCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5200870", Offset = "0x51FF270", VA = "0x185200870")]
		private void ADBFLMMPKEN(NIALADIPDNC KHFJHKDEPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "12")]
		public void LJKNPIDDPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5204200", Offset = "0x5202C00", VA = "0x185204200", Slot = "13")]
		public void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x52024C0", Offset = "0x5200EC0", VA = "0x1852024C0", Slot = "14")]
		public void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5201990", Offset = "0x5200390", VA = "0x185201990", Slot = "16")]
		public void CGHCFBCONPF(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP PNLBBPCBPJE, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x52017B0", Offset = "0x52001B0", VA = "0x1852017B0")]
		public void CGHCFBCONPF(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC PNLBBPCBPJE, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5204860", Offset = "0x5203260", VA = "0x185204860", Slot = "17")]
		public void MFDADFOIKLM(OKOJNEBFOCP FIGBCGFFKBJ, int GMOPDPNGPBB, OKOJNEBFOCP IDDEHLJHNOC, int ECICKIFMNCG, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5204AA0", Offset = "0x52034A0", VA = "0x185204AA0")]
		public void MFDADFOIKLM(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC LFAIGCEGCPL, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5200E10", Offset = "0x51FF810", VA = "0x185200E10", Slot = "18")]
		public void APCLKPGJCEA(OKOJNEBFOCP JEDGMEJHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5203320", Offset = "0x5201D20", VA = "0x185203320", Slot = "19")]
		public bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5203410", Offset = "0x5201E10", VA = "0x185203410")]
		public bool FNHCPJEHDGF(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5204ED0", Offset = "0x52038D0", VA = "0x185204ED0", Slot = "15")]
		public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "20")]
		public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "21")]
		public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5202010", Offset = "0x5200A10", VA = "0x185202010", Slot = "23")]
		public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5201000", Offset = "0x51FFA00", VA = "0x185201000", Slot = "24")]
		public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5203C30", Offset = "0x5202630", VA = "0x185203C30", Slot = "25")]
		public void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5201C80", Offset = "0x5200680", VA = "0x185201C80")]
		private void CLDAIALGBFF(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC LFAIGCEGCPL, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5203660", Offset = "0x5202060", VA = "0x185203660")]
		private void GCEAEGHJIPE(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC EBIGGMLCEAF, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5203250", Offset = "0x5201C50", VA = "0x185203250")]
		private void FJDLCEFNEME(NIALADIPDNC IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x52051A0", Offset = "0x5203BA0", VA = "0x1852051A0")]
		[IteratorStateMachine(typeof(IGBMEIOJKDK))]
		public IEnumerable<OKOJNEBFOCP> NLDMPJJFBGO(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5202440", Offset = "0x5200E40", VA = "0x185202440")]
		internal OKOJNEBFOCP DBJBMECPPCB(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5201070", Offset = "0x51FFA70", VA = "0x185201070")]
		internal NIALADIPDNC BIKIJJFPJAP(OKOJNEBFOCP JEDGMEJHFGK)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5202C20", Offset = "0x5201620", VA = "0x185202C20")]
		private bool FEOEGBONOGC(IPKEJDBNDEC EOJBPKALALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5202080", Offset = "0x5200A80", VA = "0x185202080")]
		private bool CPJAIDCOIFN(IPKEJDBNDEC EOJBPKALALP, out OKOJNEBFOCP LFAIGCEGCPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x52020E0", Offset = "0x5200AE0", VA = "0x1852020E0")]
		private OKOJNEBFOCP DBJBMECPPCB(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5201610", Offset = "0x5200010", VA = "0x185201610")]
		private OKOJNEBFOCP CEPPIOMAHBF(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5201480", Offset = "0x51FFE80", VA = "0x185201480")]
		private OKOJNEBFOCP CDAOLMNGKBP(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x51FB7B0", Offset = "0x51FA1B0", VA = "0x1851FB7B0")]
		private static Guid MHBJBMODMBJ(IPKEJDBNDEC EOJBPKALALP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5202AA0", Offset = "0x52014A0", VA = "0x185202AA0")]
		private string EOJABIALLKL(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5204070", Offset = "0x5202A70", VA = "0x185204070")]
		private void KNGJPBMEKFC(OKOJNEBFOCP IMDKOHMGEGA, OKOJNEBFOCP EBIGGMLCEAF, RigidTransform MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5201160", Offset = "0x51FFB60", VA = "0x185201160")]
		private void BOENFJKPGMA(OKOJNEBFOCP EBIGGMLCEAF, OKOJNEBFOCP IMDKOHMGEGA, RigidTransform MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5205720", Offset = "0x5204120", VA = "0x185205720")]
		private void PIOBJKHFGOD(OKOJNEBFOCP KOEBMFNDCDN, OKOJNEBFOCP IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x52012F0", Offset = "0x51FFCF0", VA = "0x1852012F0")]
		private void CAHIPBAOHAO(OKOJNEBFOCP IMDKOHMGEGA, OKOJNEBFOCP LFAIGCEGCPL, RigidTransform MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5203D90", Offset = "0x5202790", VA = "0x185203D90")]
		private void JPNLBMFEDKD(NIALADIPDNC KLCGNDEDAPD, OKOJNEBFOCP JEDGMEJHFGK, NIALADIPDNC EDCJDKGNJGI, NIALADIPDNC CFCDMOHCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5204540", Offset = "0x5202F40", VA = "0x185204540")]
		private void LKMFEEAPCKA(NIALADIPDNC KLCGNDEDAPD, OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IJGGALHFCGI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LIPFNCIEGLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public PEGEFOEHCCC container;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LIPFNCIEGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x51F5DF0", Offset = "0x51F47F0", VA = "0x1851F5DF0")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x51F57C0", Offset = "0x51F41C0", VA = "0x1851F57C0")]
	public static void OKCGDBBMIAE(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51F5750", Offset = "0x51F4150", VA = "0x1851F5750")]
	public static void HCLGOPAGKIM(PEGEFOEHCCC IGFHDABHNLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HAEJCFKABJJ : IICAMGGJJNC, AMEJFCPFPAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly RigidbodyEx FHCKPPNILHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly OMConnectableManager DHJAKBDIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly LHMBBJKNPDI FFMNGIOPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly ECCOODIKAKJ NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly LNPKCEGMEFM[] OLAEKPIDBOB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NIALADIPDNC CDCHGJINIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1384020", Offset = "0x1382A20", VA = "0x181384020", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(NIALADIPDNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OKOJNEBFOCP NOACAMDIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OKOJNEBFOCP CNDFBIIJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x51F31D0", Offset = "0x51F1BD0", VA = "0x1851F31D0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OKOJNEBFOCP JJJHPDGFMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x51F2730", Offset = "0x51F1130", VA = "0x1851F2730", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 HONBKEOHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x51F2A90", Offset = "0x51F1490", VA = "0x1851F2A90", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion INJAKMAKCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51F2D00", Offset = "0x51F1700", VA = "0x1851F2D00", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LMOIKHBNEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x51F2FF0", Offset = "0x51F19F0", VA = "0x1851F2FF0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<OKOJNEBFOCP> IJIEGILBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x51F2970", Offset = "0x51F1370", VA = "0x1851F2970", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool GMIGCPFPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F7B40", Offset = "0x9F6540", VA = "0x1809F7B40", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9F7CE0", Offset = "0x9F66E0", VA = "0x1809F7CE0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x51F33F0", Offset = "0x51F1DF0", VA = "0x1851F33F0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x51F3160", Offset = "0x51F1B60", VA = "0x1851F3160", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x51F3180", Offset = "0x51F1B80", VA = "0x1851F3180", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid DADEPEKMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x51F32C0", Offset = "0x51F1CC0", VA = "0x1851F32C0", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MBHJFOLEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x51F33A0", Offset = "0x51F1DA0", VA = "0x1851F33A0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DKKKOJNAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool KBGCGPFEIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x51F2E10", Offset = "0x51F1810", VA = "0x1851F2E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MNDJHOAPIBF MACPKEBHOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x51F2820", Offset = "0x51F1220", VA = "0x1851F2820", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x51F1FA0", Offset = "0x51F09A0", VA = "0x1851F1FA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MNDJHOAPIBF MOPDNAHNMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x51F2EC0", Offset = "0x51F18C0", VA = "0x1851F2EC0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x51F1F50", Offset = "0x51F0950", VA = "0x1851F1F50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MNDJHOAPIBF PBEFKDLNBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x51F2070", Offset = "0x51F0A70", VA = "0x1851F2070", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x51F1930", Offset = "0x51F0330", VA = "0x1851F1930", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event PLNJGDCELKP FCPIJPKBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x51F17F0", Offset = "0x51F01F0", VA = "0x1851F17F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x51F2D70", Offset = "0x51F1770", VA = "0x1851F2D70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x51F3080", Offset = "0x51F1A80", VA = "0x1851F3080")]
	public HAEJCFKABJJ(NIALADIPDNC EHLCJHMJBBP, RigidbodyEx FHCKPPNILHO, LHMBBJKNPDI FFMNGIOPDCC, LNPKCEGMEFM[] OLAEKPIDBOB, ECCOODIKAKJ NBJJAAKBODP, IHBAODPGPGM DHJAKBDIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x51F2F10", Offset = "0x51F1910", VA = "0x1851F2F10", Slot = "20")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "22")]
	public void GFHALMIKJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x51F2870", Offset = "0x51F1270", VA = "0x1851F2870", Slot = "23")]
	public void JFHFEDABDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x51F3010", Offset = "0x51F1A10", VA = "0x1851F3010", Slot = "21")]
	public void PMIJFIGEABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x51F19E0", Offset = "0x51F03E0", VA = "0x1851F19E0", Slot = "26")]
	public void EFEKJOBOGCE(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51F1FF0", Offset = "0x51F09F0", VA = "0x1851F1FF0", Slot = "27")]
	public void GHDBODICNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51F1C30", Offset = "0x51F0630", VA = "0x1851F1C30", Slot = "28")]
	public void EIJNJFKEGHA(int EBNBMBEOMKP, OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, [Optional] Vector3? GDILIOHLNNI, [Optional] Quaternion? HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x51F2A10", Offset = "0x51F1410", VA = "0x1851F2A10", Slot = "29")]
	public void JKECLMBIAPM(OKOJNEBFOCP FIGBCGFFKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51F20C0", Offset = "0x51F0AC0", VA = "0x1851F20C0", Slot = "32")]
	public void GOGFEIDLBDA(Vector3 BECIPDCMBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51F1530", Offset = "0x51EFF30", VA = "0x1851F1530", Slot = "30")]
	public void BCADEKFLALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x51F2B00", Offset = "0x51F1500", VA = "0x1851F2B00", Slot = "31")]
	public void KMFFIGCDCMN(int EBBLFLFCHFB, Vector3 EOJNMKIFHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x51F2600", Offset = "0x51F1000", VA = "0x1851F2600", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51F24C0", Offset = "0x51F0EC0", VA = "0x1851F24C0", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x17CA0F0", Offset = "0x17C8AF0", VA = "0x1817CA0F0", Slot = "43")]
	public Color GetConnectionSlotColor(int EBNBMBEOMKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x51F1890", Offset = "0x51F0290", VA = "0x1851F1890", Slot = "44")]
	public bool CanConnectTo(int EBNBMBEOMKP, OKOJNEBFOCP NCFHOBEDKHL, int BCBMLFMIALA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "45")]
	public void ParentChanged(int EBNBMBEOMKP, OKOJNEBFOCP DHBEDIHFIAN, int KOJFFNPKENB, Vector3 DMDBIJHOHIJ, Quaternion PJDANGLLKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "46")]
	public void ChildAdded(int EBNBMBEOMKP, OKOJNEBFOCP CPJKMEIJGID, int NLFIDJLEDPC, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "47")]
	public void ChildRemoved(int EBNBMBEOMKP, OKOJNEBFOCP HGIPAGJIMDK, int DKIHCBGOPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "48")]
	public void ConnectionModified(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51F3060", Offset = "0x51F1A60", VA = "0x1851F3060", Slot = "49")]
	public void RootChanged(OKOJNEBFOCP OKAGMHACBGC, OKOJNEBFOCP DEGGONGNNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x51F2F40", Offset = "0x51F1940", VA = "0x1851F2F40")]
	public bool PEGCDPIHGIH(OKOJNEBFOCP OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x51F1980", Offset = "0x51F0380", VA = "0x1851F1980", Slot = "24")]
	public void DJIACPONHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51F2E60", Offset = "0x51F1860", VA = "0x1851F2E60", Slot = "25")]
	public void NHCBKIIPOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x51F2CA0", Offset = "0x51F16A0", VA = "0x1851F2CA0")]
	private void LBLPDEBDJFH(bool LELJAOIMNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51F26D0", Offset = "0x51F10D0", VA = "0x1851F26D0")]
	private RigidbodyEx HEKLNEIOEDG(OKOJNEBFOCP FFMNGIOPDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DHKIICMHACJ(typeof(HGCBJKAFPHC), new string[] { })]
public class JDCNJOLKIFM : HGCBJKAFPHC, GOJCOOFCPOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[CJONPMHNDBN]
	private KMGAJCBNKGB NBJJAAKBODP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object LELEHIFPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x51F5990", Offset = "0x51F4390", VA = "0x1851F5990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51F5A30", Offset = "0x51F4430", VA = "0x1851F5A30", Slot = "6")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x51F5A80", Offset = "0x51F4480", VA = "0x1851F5A80", Slot = "5")]
	public void OOJCBHBPOMO(OKKOFBJCFMA FEELJHFMNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public JDCNJOLKIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DHKIICMHACJ(typeof(IHBAODPGPGM), new string[] { "Ignore", "Mock" })]
public class PLOMIBJDGHB : IHBAODPGPGM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5206330", Offset = "0x5204D30", VA = "0x185206330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5206150", Offset = "0x5204B50", VA = "0x185206150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5206290", Offset = "0x5204C90", VA = "0x185206290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x52061F0", Offset = "0x5204BF0", VA = "0x1852061F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x52063D0", Offset = "0x5204DD0", VA = "0x1852063D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x52060B0", Offset = "0x5204AB0", VA = "0x1852060B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "11")]
	public void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "12")]
	public void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "13")]
	public void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "14")]
	public void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "15")]
	public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "16")]
	public void CGHCFBCONPF(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP PNLBBPCBPJE, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "17")]
	public void MFDADFOIKLM(OKOJNEBFOCP JEDGMEJHFGK, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "18")]
	public void APCLKPGJCEA(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "19")]
	public bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "20")]
	public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67E170", Offset = "0x67CB70", VA = "0x18067E170", Slot = "21")]
	public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "22")]
	public bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "23")]
	public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "24")]
	public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "25")]
	public void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public PLOMIBJDGHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KNLEKNIBFEP : GDILIKAPCAN, NMHMDBFHOBL, IDisposable
{
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ConnectableLinkVisual : MonoBehaviour, KNLEKNIBFEP, GDILIKAPCAN, NMHMDBFHOBL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Entity EBPNONDMOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Entity NHIGGOACGGE;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity HNDMIFGDFBE
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x160DE10", Offset = "0x160C810", VA = "0x18160DE10", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity PAJBHIKEKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x12DA6B0", Offset = "0x12D90B0", VA = "0x1812DA6B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x51EA1B0", Offset = "0x51E8BB0", VA = "0x1851EA1B0", Slot = "4")]
		private void DKNEMBDOCPM(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x51EA410", Offset = "0x51E8E10", VA = "0x1851EA410", Slot = "5")]
		private void HHGLCIEBHAP(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x51EA740", Offset = "0x51E9140", VA = "0x1851EA740", Slot = "6")]
		private void MJKOGJFBIDD(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x51EA9A0", Offset = "0x51E93A0", VA = "0x1851EA9A0", Slot = "7")]
		private void NJACFOBPFGE(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x51EABD0", Offset = "0x51E95D0", VA = "0x1851EABD0", Slot = "8")]
		private GDILIKAPCAN ONBPIBIPFKE(Transform HJLACGOIJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x51EAB70", Offset = "0x51E9570", VA = "0x1851EAB70", Slot = "9")]
		private void NLGDCIENBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x51EA6C0", Offset = "0x51E90C0", VA = "0x1851EA6C0")]
		private void KMNEKDAGPNL(ref Entity FLADPKIONGF, Entity MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x51EA6D0", Offset = "0x51E90D0", VA = "0x1851EA6D0", Slot = "14")]
		private void LABDKGMEJIF(float3 EOJNMKIFHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x51EA930", Offset = "0x51E9330", VA = "0x1851EA930", Slot = "13")]
		private void NGIBEEIHCNI(float3 EOJNMKIFHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x51EA340", Offset = "0x51E8D40", VA = "0x1851EA340", Slot = "15")]
		private void FIOLGFOELJB(out float3 LJECKBCMELA, out float3 EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x51EA270", Offset = "0x51E8C70", VA = "0x1851EA270", Slot = "16")]
		private void FEMEABCNLLC(float3 LJECKBCMELA, float3 EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x51EA150", Offset = "0x51E8B50", VA = "0x1851EA150", Slot = "17")]
		private void DADFAGLGPGE(Color LJECKBCMELA, Color EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x51EAC50", Offset = "0x51E9650", VA = "0x1851EAC50", Slot = "18")]
		private NMHMDBFHOBL PNOMOIHIDOM(Transform HJLACGOIJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x51EACD0", Offset = "0x51E96D0", VA = "0x1851EACD0", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xEC9410", Offset = "0xEC7E10", VA = "0x180EC9410")]
		public ConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OKOJNEBFOCP : AMEJFCPFPAA, IEquatable<OKOJNEBFOCP>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface AMEJFCPFPAA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	OKOJNEBFOCP CNDFBIIJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DADEPEKMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int MBHJFOLEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NIALADIPDNC CDCHGJINIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DKKKOJNAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int EBNBMBEOMKP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int EBNBMBEOMKP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int EBNBMBEOMKP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int EBNBMBEOMKP, OKOJNEBFOCP NCFHOBEDKHL, int BFNJMEPLIAP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int EBNBMBEOMKP, OKOJNEBFOCP DHBEDIHFIAN, int KOJFFNPKENB, Vector3 DMDBIJHOHIJ, Quaternion PJDANGLLKLG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int EBNBMBEOMKP, OKOJNEBFOCP CPJKMEIJGID, int NLFIDJLEDPC, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int EBNBMBEOMKP, OKOJNEBFOCP HGIPAGJIMDK, int DKIHCBGOPAI);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int KMDIEJDGEIP, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(OKOJNEBFOCP OKAGMHACBGC, OKOJNEBFOCP DEGGONGNNIP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[LOICNDEPMOJ(HIFIKBEHMNK.OMRoom)]
public interface IHBAODPGPGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LJKNPIDDPEM();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CGHCFBCONPF(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP PNLBBPCBPJE, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MFDADFOIKLM(OKOJNEBFOCP JEDGMEJHFGK, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void APCLKPGJCEA(OKOJNEBFOCP JEDGMEJHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KLEAMHNNPIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CKJBFOGMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OKOJNEBFOCP CDAOLMNGKBP(int POCAAILBFLC);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OKOJNEBFOCP CEPPIOMAHBF(Guid OOOMOACKLHC);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool INKPHOCDAOO(OKOJNEBFOCP JEDGMEJHFGK, out Guid GDIIAHJOKME);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JDADCMMNNMO(OKOJNEBFOCP JEDGMEJHFGK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MNDLFEIPKFA();

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HFLHBFHAMFE(OKOJNEBFOCP FFMNGIOPDCC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[LOICNDEPMOJ(HIFIKBEHMNK.Application)]
public interface ECCOODIKAKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBGCGPFEIII(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PABMIKNGMBO(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MHCHBKFLKKI(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid EEIKJMEALGA(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JIIDPOMOIME(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGGFJMFALHA(OKOJNEBFOCP FFMNGIOPDCC, Action<CJIONLFKLCG> EDBBHNLOENN);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ABJPENBOPJP(OKOJNEBFOCP FFMNGIOPDCC, Action<CJIONLFKLCG> EDBBHNLOENN);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OCMOOIHCNFH(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NMBAIJNMLPF(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HFLHBFHAMFE(LHMBBJKNPDI FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FKOFNEMGINM(LHMBBJKNPDI FFMNGIOPDCC, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEHGOGKEFEN(LHMBBJKNPDI FFMNGIOPDCC, object HKLDIENGNNB);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	RigidbodyEx HEKLNEIOEDG(OKOJNEBFOCP FFMNGIOPDCC);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OEPFFFMEFHC EKIJFMDMCPK(LHMBBJKNPDI JOOJGLPIMBB, string AIGAKEKDKHM, bool BKMGNMEJDHA, CHJIMJFFBGO EENAIJIEBAF, Action ONHFNOPIIKL);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AKEAMDFHIAJ(IICAMGGJJNC PNADJGGBJBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void MNDJHOAPIBF(OKOJNEBFOCP FIGBCGFFKBJ, int ODFOEGNJOGF, OKOJNEBFOCP IDDEHLJHNOC, int NJKGPPKNEID, [Optional] Vector3? GDILIOHLNNI, [Optional] Quaternion? HIMAIGGLOGC);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void PLNJGDCELKP(OKOJNEBFOCP OKAGMHACBGC, OKOJNEBFOCP DEGGONGNNIP);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate bool OHJCFNLKBOG(int EBNBMBEOMKP, OKOJNEBFOCP NCFHOBEDKHL, int BCBMLFMIALA);
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LHMBBJKNPDI : OKOJNEBFOCP, AMEJFCPFPAA, IEquatable<OKOJNEBFOCP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IICAMGGJJNC JHGMMLCOACP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IICAMGGJJNC : AMEJFCPFPAA
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	OKOJNEBFOCP NOACAMDIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OKOJNEBFOCP JJJHPDGFMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	IEnumerable<OKOJNEBFOCP> IJIEGILBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 HONBKEOHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Quaternion INJAKMAKCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool LMOIKHBNEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool GMIGCPFPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MNDJHOAPIBF MACPKEBHOHL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MNDJHOAPIBF MOPDNAHNMAH;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MNDJHOAPIBF PBEFKDLNBFO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event PLNJGDCELKP FCPIJPKBGIA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NOMIHBFFLNG();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PMIJFIGEABJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GFHALMIKJAE();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JFHFEDABDDO();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DJIACPONHDF();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NHCBKIIPOHL();

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EFEKJOBOGCE(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GHDBODICNOB();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EIJNJFKEGHA(int EBNBMBEOMKP, OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, [Optional] Vector3? GDILIOHLNNI, [Optional] Quaternion? HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JKECLMBIAPM(OKOJNEBFOCP FIGBCGFFKBJ);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BCADEKFLALJ();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KMFFIGCDCMN(int EBBLFLFCHFB, Vector3 EOJNMKIFHNO);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GOGFEIDLBDA(Vector3 BECIPDCMBPD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LNPKCEGMEFM
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Vector3 PBLMADKHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LIAJIIJJKHJ
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool MFFKNNEFCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	KNLEKNIBFEP EAKHAJMKPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	KNLEKNIBFEP LJKHKAIJEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CreateAssetMenu]
	public class ConnectableConfigData : ScriptableObject, LIAJIIJJKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private ConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private ConnectableLinkVisual objectModelLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x6918D0", Offset = "0x6902D0", VA = "0x1806918D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public KNLEKNIBFEP LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public KNLEKNIBFEP ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6902E0", VA = "0x1806918E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x51EA060", Offset = "0x51E8A60", VA = "0x1851EA060")]
		public static ConnectableConfigData PHFCPGGCCJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x51EA100", Offset = "0x51E8B00", VA = "0x1851EA100")]
		public ConnectableConfigData(ConnectableLinkVisual EACLNDDEIHM, bool PPLEJNAOJGI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct FLFPBJIEAPK : IEquatable<FLFPBJIEAPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public OKOJNEBFOCP JEDGMEJHFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public int EBAABILDMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int KMDIEJDGEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector3 GDILIOHLNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Quaternion HIMAIGGLOGC;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x51F1470", Offset = "0x51EFE70", VA = "0x1851F1470")]
	public FLFPBJIEAPK(OKOJNEBFOCP JEDGMEJHFGK, int EBAABILDMOD, int KMDIEJDGEIP, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x51F13B0", Offset = "0x51EFDB0", VA = "0x1851F13B0")]
	public FLFPBJIEAPK(OKOJNEBFOCP JEDGMEJHFGK, int EBAABILDMOD, int KMDIEJDGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x51F1420", Offset = "0x51EFE20", VA = "0x1851F1420")]
	public FLFPBJIEAPK(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x51F0F00", Offset = "0x51EF900", VA = "0x1851F0F00", Slot = "4")]
	public bool Equals(FLFPBJIEAPK OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x51F0FA0", Offset = "0x51EF9A0", VA = "0x1851F0FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
public class BADDDNFHHJL : FLIFEJHGKGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Transform HJLACGOIJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private GDILIKAPCAN KKMCOADLCAG;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3153280", Offset = "0x3151C80", VA = "0x183153280", Slot = "4")]
	public void OIEJOMHJJDA(Transform HJLACGOIJCA, GDILIKAPCAN KKMCOADLCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x51E93D0", Offset = "0x51E7DD0", VA = "0x1851E93D0", Slot = "5")]
	public GDILIKAPCAN AAMLBALCMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x51E9420", Offset = "0x51E7E20", VA = "0x1851E9420", Slot = "6")]
	public void LHICMFEONDP(GDILIKAPCAN DKHKLBFKJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public BADDDNFHHJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal class DFJPCCPKAED : IDisposable, OFAAHBABBKD
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PDNNFBPHOKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OKOJNEBFOCP oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OKOJNEBFOCP newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public PDNNFBPHOKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5205C40", Offset = "0x5204640", VA = "0x185205C40")]
		internal bool <NotifyRootChangedRecurse>b__0(MMHEHNGHKHL node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly DKHGAALDMFL IOMCIHJBABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private IIGNMKGCDKK DKBKHCPKCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private KLFMMPLFPEB GLIGCLJIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private bool PPLEJNAOJGI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public MMHEHNGHKHL AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x51EB760", Offset = "0x51EA160", VA = "0x1851EB760")]
	public bool BLPDDJNNIAJ(in DNCNIKEBCFI JIHCLPECHIB, bool EHOIGELLJPC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x51EE830", Offset = "0x51ED230", VA = "0x1851EE830")]
	private bool PELODFOECIP(in DNCNIKEBCFI JIHCLPECHIB, bool EHOIGELLJPC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x51EC120", Offset = "0x51EAB20", VA = "0x1851EC120", Slot = "8")]
	public bool HEJDLKFAHKI(OKOJNEBFOCP MCIGJNMJJIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x51EB180", Offset = "0x51E9B80", VA = "0x1851EB180")]
	private bool BHFEHDPEDLC(OKOJNEBFOCP LBPNFPHBBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51EBC30", Offset = "0x51EA630", VA = "0x1851EBC30")]
	private static bool EMEFGGHHNLP(OKOJNEBFOCP LBPNFPHBBEJ, DKHGAALDMFL NBCIPPOMHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x51EC300", Offset = "0x51EAD00", VA = "0x1851EC300")]
	private void HLDDPJPHFKI(Transform FFNPCMLEJIK, DKHGAALDMFL OGOJPJEOAPA, DKHGAALDMFL[] EPGHKFNBHNP, OKOJNEBFOCP LFLOFJCEDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x51EBE60", Offset = "0x51EA860", VA = "0x1851EBE60")]
	private FLFPBJIEAPK FPJMLFNNFCA(Transform GLLGMGLMIJM, FLFPBJIEAPK COKPBKBDKLD)
	{
		return default(FLFPBJIEAPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x51EB9B0", Offset = "0x51EA3B0", VA = "0x1851EB9B0")]
	private static bool CJHGIPDIICO(DKHGAALDMFL NBCIPPOMHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x51EDB20", Offset = "0x51EC520", VA = "0x1851EDB20")]
	private string MHCHBKFLKKI(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x51ED4F0", Offset = "0x51EBEF0", VA = "0x1851ED4F0")]
	private string JIIDPOMOIME(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x51EF110", Offset = "0x51EDB10", VA = "0x1851EF110")]
	private void PHKCLCHAGLC(in DNCNIKEBCFI JIHCLPECHIB, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x51EAFB0", Offset = "0x51E99B0", VA = "0x1851EAFB0")]
	private void ABJANMCLFPP(OKOJNEBFOCP IMDKOHMGEGA, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x51EC810", Offset = "0x51EB210", VA = "0x1851EC810")]
	private void IJGELJNLKAG(OKOJNEBFOCP FENIHKAOGCI, int AAJBCEMEGHA, OKOJNEBFOCP EBIGGMLCEAF, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51EE160", Offset = "0x51ECB60", VA = "0x1851EE160")]
	private void NNMJPPCMMPE(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, bool HNCECPFLCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51EBB50", Offset = "0x51EA550", VA = "0x1851EBB50", Slot = "9")]
	public bool DDLHAJKIAGE(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x51EF8B0", Offset = "0x51EE2B0", VA = "0x1851EF8B0")]
	private bool PLNNGOJIKJF(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x51EBCE0", Offset = "0x51EA6E0", VA = "0x1851EBCE0")]
	private static void FIMPMMCGPJB(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, DKHGAALDMFL LIPMMGJPKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x51ED7B0", Offset = "0x51EC1B0", VA = "0x1851ED7B0")]
	private void KNGJPBMEKFC(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x51EC730", Offset = "0x51EB130", VA = "0x1851EC730")]
	private void IIGPMAGLIKO(DKHGAALDMFL ELOCLFMIMAL, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x51EC7A0", Offset = "0x51EB1A0", VA = "0x1851EC7A0")]
	private void IIGPMAGLIKO(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x51ED9E0", Offset = "0x51EC3E0", VA = "0x1851ED9E0")]
	private void LKMFEEAPCKA(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH, bool NPBOCMDCJPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x51ED8D0", Offset = "0x51EC2D0", VA = "0x1851ED8D0")]
	private void LKMFEEAPCKA(DKHGAALDMFL COMPFMNMPEI, OKOJNEBFOCP LFLOFJCEDOO, OKOJNEBFOCP DEGGONGNNIP, bool NPBOCMDCJPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x51EB7B0", Offset = "0x51EA1B0", VA = "0x1851EB7B0")]
	private void BOENFJKPGMA(OKOJNEBFOCP IMDKOHMGEGA, int AAJBCEMEGHA, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x51EF750", Offset = "0x51EE150", VA = "0x1851EF750")]
	private void PIOBJKHFGOD(MMHEHNGHKHL LFAIGCEGCPL, MMHEHNGHKHL KALAGBODNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x51EBFF0", Offset = "0x51EA9F0", VA = "0x1851EBFF0", Slot = "13")]
	public void GNBPJFHFHNC(OKOJNEBFOCP JEDGMEJHFGK, out Vector3 GDILIOHLNNI, out Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x51EDCF0", Offset = "0x51EC6F0", VA = "0x1851EDCF0", Slot = "14")]
	public OKOJNEBFOCP NAFNJGJKKEK(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x51EDE20", Offset = "0x51EC820", VA = "0x1851EDE20", Slot = "15")]
	public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> DDDNIOCKBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x51ED5A0", Offset = "0x51EBFA0", VA = "0x1851ED5A0", Slot = "16")]
	public List<OKOJNEBFOCP> KHPGDFHINKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x51ED420", Offset = "0x51EBE20", VA = "0x1851ED420")]
	protected MMHEHNGHKHL JEIECNACPEP(MMHEHNGHKHL ELOCLFMIMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x51EB9E0", Offset = "0x51EA3E0", VA = "0x1851EB9E0")]
	protected DKHGAALDMFL[] CJMOBHCBKPN(DKHGAALDMFL NBCIPPOMHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x51ECE00", Offset = "0x51EB800", VA = "0x1851ECE00")]
	protected bool IJNELDPKHKL(OKOJNEBFOCP JEDGMEJHFGK, out DKHGAALDMFL ELOCLFMIMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x51EDBF0", Offset = "0x51EC5F0", VA = "0x1851EDBF0", Slot = "17")]
	public bool MOJGDFCMJHE(OKOJNEBFOCP JEDGMEJHFGK, out FLFPBJIEAPK FOJEJMNBCOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x51ED560", Offset = "0x51EBF60", VA = "0x1851ED560")]
	protected DKHGAALDMFL KCDNLPOEHHI(FLFPBJIEAPK BDEFMHHFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x51EB8C0", Offset = "0x51EA2C0", VA = "0x1851EB8C0", Slot = "10")]
	public bool CDCKHJBBGPH(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x51ECED0", Offset = "0x51EB8D0", VA = "0x1851ECED0")]
	private bool IPLHCPIKMLE(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x51EBA80", Offset = "0x51EA480", VA = "0x1851EBA80")]
	private static bool DBPDMALAMOM(DKHGAALDMFL CNABIFICNJB, FLFPBJIEAPK CAKBJJFNHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x51EFB40", Offset = "0x51EE540", VA = "0x1851EFB40")]
	public DFJPCCPKAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x51EE7A0", Offset = "0x51ED1A0", VA = "0x1851EE7A0", Slot = "5")]
	public void OIEJOMHJJDA(IHBAODPGPGM HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x51EF0E0", Offset = "0x51EDAE0", VA = "0x1851EF0E0", Slot = "19")]
	public void PGIMMCFLBOJ(MEDCGBEMCOB ONHFNOPIIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x51EF0D0", Offset = "0x51EDAD0", VA = "0x1851EF0D0", Slot = "12")]
	public void PFLCLFLMCFP(Func<OKOJNEBFOCP, bool> DPNAHJMIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x51EEDA0", Offset = "0x51ED7A0", VA = "0x1851EEDA0")]
	private void PFLCLFLMCFP(DKHGAALDMFL ELOCLFMIMAL, Func<OKOJNEBFOCP, bool> DPNAHJMIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x51EDB00", Offset = "0x51EC500", VA = "0x1851EDB00", Slot = "11")]
	public void LPCLMLEHOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x51EB760", Offset = "0x51EA160", VA = "0x1851EB760", Slot = "7")]
	private bool IPPCMHKNBOA(in DNCNIKEBCFI JIHCLPECHIB, bool EHOIGELLJPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Preserve]
internal class HFBDMALPJBF : IHBAODPGPGM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly PEGEFOEHCCC IGFHDABHNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly KLFMMPLFPEB GLIGCLJIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly NOCIFNCPLBK GCPJAJMKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly NCDFGJCEFPL PLNODCMOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly OFAAHBABBKD HOHEJAGNDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GGIFJLOMMKD NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal NOJKDOFCOEE IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal IIGNMKGCDKK JPEPFPPEFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal bool PPLEJNAOJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private bool ENKKOELMOOE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JKLONLNGCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1165700", Offset = "0x1164100", VA = "0x181165700")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xEF7850", Offset = "0xEF6250", VA = "0x180EF7850")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xBF8470", Offset = "0xBF6E70", VA = "0x180BF8470", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x160DDC0", Offset = "0x160C7C0", VA = "0x18160DDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x51F3DD0", Offset = "0x51F27D0", VA = "0x1851F3DD0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x51F3BC0", Offset = "0x51F25C0", VA = "0x1851F3BC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x51F3D70", Offset = "0x51F2770", VA = "0x1851F3D70", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x51F3CD0", Offset = "0x51F26D0", VA = "0x1851F3CD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x51F4F10", Offset = "0x51F3910", VA = "0x1851F4F10", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x51F39D0", Offset = "0x51F23D0", VA = "0x1851F39D0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x51F4F70", Offset = "0x51F3970", VA = "0x1851F4F70")]
	public HFBDMALPJBF(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x51F48D0", Offset = "0x51F32D0", VA = "0x1851F48D0", Slot = "11")]
	public void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x51F3B20", Offset = "0x51F2520", VA = "0x1851F3B20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x51F4510", Offset = "0x51F2F10", VA = "0x1851F4510", Slot = "12")]
	public void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x51F43B0", Offset = "0x51F2DB0", VA = "0x1851F43B0", Slot = "13")]
	public void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x51F3AC0", Offset = "0x51F24C0", VA = "0x1851F3AC0", Slot = "14")]
	public void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x51F4560", Offset = "0x51F2F60", VA = "0x1851F4560", Slot = "22")]
	public bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x51F4E50", Offset = "0x51F3850", VA = "0x1851F4E50")]
	internal bool PELODFOECIP(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x51F3FD0", Offset = "0x51F29D0", VA = "0x1851F3FD0")]
	internal bool IPLHCPIKMLE(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x51F3F70", Offset = "0x51F2970", VA = "0x1851F3F70")]
	internal bool HHCJMLAKDFP(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x51F3E30", Offset = "0x51F2830", VA = "0x1851F3E30")]
	internal bool HFNOCICBEHE(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x51F41D0", Offset = "0x51F2BD0", VA = "0x1851F41D0")]
	internal void KNNNJEDJLJP(OKOJNEBFOCP JEDGMEJHFGK, int FHMNGDCHOLD, bool EHOIGELLJPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x51F3AC0", Offset = "0x51F24C0", VA = "0x1851F3AC0")]
	internal bool GLHGAFNOFEJ(OKOJNEBFOCP MADBLMMGOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x51F40A0", Offset = "0x51F2AA0", VA = "0x1851F40A0")]
	internal bool KDAEKHKDAFM(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x51F46B0", Offset = "0x51F30B0", VA = "0x1851F46B0", Slot = "15")]
	public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x51F3680", Offset = "0x51F2080", VA = "0x1851F3680", Slot = "16")]
	public void CGHCFBCONPF(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x51F43D0", Offset = "0x51F2DD0", VA = "0x1851F43D0")]
	public void LGPFCNGACPA(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x51F3C70", Offset = "0x51F2670", VA = "0x1851F3C70")]
	public void GALJJDMJFEJ(OKOJNEBFOCP MCIGJNMJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x51F3890", Offset = "0x51F2290", VA = "0x1851F3890")]
	public void CGHCFBCONPF(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x51F4570", Offset = "0x51F2F70", VA = "0x1851F4570", Slot = "17")]
	public void MFDADFOIKLM(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x51F3410", Offset = "0x51F1E10", VA = "0x1851F3410", Slot = "18")]
	public void APCLKPGJCEA(OKOJNEBFOCP FENIHKAOGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x51F3C20", Offset = "0x51F2620", VA = "0x1851F3C20", Slot = "19")]
	public bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x51F47B0", Offset = "0x51F31B0", VA = "0x1851F47B0")]
	public void NONMHFBMLKD([Optional] CJIONLFKLCG CKNDOEDFOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x51F3A30", Offset = "0x51F2430", VA = "0x1851F3A30", Slot = "23")]
	public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x51F4080", Offset = "0x51F2A80", VA = "0x1851F4080", Slot = "20")]
	public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x51F4060", Offset = "0x51F2A60", VA = "0x1851F4060", Slot = "21")]
	public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x51F3D30", Offset = "0x51F2730", VA = "0x1851F3D30", Slot = "25")]
	public void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x51F35D0", Offset = "0x51F1FD0", VA = "0x1851F35D0", Slot = "24")]
	public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class KLFMMPLFPEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly global::HHFONFHJAEB<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly global::HHFONFHJAEB<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly global::PKFHEEKPKKD<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x51F5CF0", Offset = "0x51F46F0", VA = "0x1851F5CF0")]
	public KLFMMPLFPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
	public void OIEJOMHJJDA(HFBDMALPJBF HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x51F5C90", Offset = "0x51F4690", VA = "0x1851F5C90")]
	public void OFMFKDMEJJO(OKOJNEBFOCP LFAIGCEGCPL, OKOJNEBFOCP IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x51F5BB0", Offset = "0x51F45B0", VA = "0x1851F5BB0")]
	public void DMKDBMJCDNE(OKOJNEBFOCP LFAIGCEGCPL, OKOJNEBFOCP IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x51F5C10", Offset = "0x51F4610", VA = "0x1851F5C10")]
	public void IEOCHONAEIA(OKOJNEBFOCP KOEBMFNDCDN, OKOJNEBFOCP EBIGGMLCEAF, OKOJNEBFOCP IMDKOHMGEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class NOCIFNCPLBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private HFBDMALPJBF HKMONJIHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private NOJKDOFCOEE IFOIKAOPFOA;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public NOCIFNCPLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x51FFB50", Offset = "0x51FE550", VA = "0x1851FFB50")]
	public void OIEJOMHJJDA(HFBDMALPJBF HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x51FF9C0", Offset = "0x51FE3C0", VA = "0x1851FF9C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x51FF8A0", Offset = "0x51FE2A0", VA = "0x1851FF8A0")]
	private void AGMHAHKPAMK(CJIONLFKLCG PAIIMNGOMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x51FFAE0", Offset = "0x51FE4E0", VA = "0x1851FFAE0")]
	private void GEADGMGMOHG(CJIONLFKLCG MMDPCAIEINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x51FF8C0", Offset = "0x51FE2C0", VA = "0x1851FF8C0")]
	public void BPEIFCBCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x51FF9D0", Offset = "0x51FE3D0", VA = "0x1851FF9D0")]
	public void FKLGEKPPDOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class DCHLIFNBAJF
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GBOBONECECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PEGEFOEHCCC container;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public GBOBONECECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x51F14D0", Offset = "0x51EFED0", VA = "0x1851F14D0")]
		internal HFBDMALPJBF <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x51EADB0", Offset = "0x51E97B0", VA = "0x1851EADB0")]
	public static void OKCGDBBMIAE(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x51EAD30", Offset = "0x51E9730", VA = "0x1851EAD30")]
	public static void HCLGOPAGKIM(PEGEFOEHCCC IGFHDABHNLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[Preserve]
internal class CPGBMACDCBA : IDisposable, IIGNMKGCDKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly Dictionary<int, GDILIKAPCAN> KFKMAAENNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly MEDCGBEMCOB FEHODHGCBCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private FLIFEJHGKGO GKHJOKGNPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private OFAAHBABBKD HOHEJAGNDDK;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x51E9F90", Offset = "0x51E8990", VA = "0x1851E9F90")]
	public CPGBMACDCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x51E99C0", Offset = "0x51E83C0", VA = "0x1851E99C0", Slot = "7")]
	public void OIEJOMHJJDA(OFAAHBABBKD HOHEJAGNDDK, FLIFEJHGKGO GKHJOKGNPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x51E9470", Offset = "0x51E7E70", VA = "0x1851E9470", Slot = "5")]
	public void CLFNLAOPCHN(MMHEHNGHKHL OEHGOIINOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x51E9850", Offset = "0x51E8250", VA = "0x1851E9850", Slot = "9")]
	public void NOGNNJFIDLG(MMHEHNGHKHL CFFOKEIIBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x51E9A00", Offset = "0x51E8400", VA = "0x1851E9A00", Slot = "8")]
	public void ONOFHCMJGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x51E9C70", Offset = "0x51E8670", VA = "0x1851E9C70", Slot = "10")]
	public void PGFEINBGJPI(MMHEHNGHKHL IPMDKFFOGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x51E9BB0", Offset = "0x51E85B0", VA = "0x1851E9BB0", Slot = "11")]
	public void OOMHDACJDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x51E96B0", Offset = "0x51E80B0", VA = "0x1851E96B0")]
	private bool DCFHICMLAKB(MMHEHNGHKHL AFNHKCHCFAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal class NCDFGJCEFPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal struct OKAKKINGJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly DKHGAALDMFL AFNICFHKIBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly HashSet<Guid> NPKNNHDIDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly IPKEJDBNDEC IGDDCCKDHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly IPKEJDBNDEC ICHNNNFPMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly bool CJCAEDNHBOC;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool CGDAKLCELPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5200070", Offset = "0x51FEA70", VA = "0x185200070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5200800", Offset = "0x51FF200", VA = "0x185200800")]
		public OKAKKINGJGD(DKHGAALDMFL AFNICFHKIBD, HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC, [Optional] IPKEJDBNDEC IGDDCCKDHCG, [Optional] IPKEJDBNDEC ICHNNNFPMOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5200180", Offset = "0x51FEB80", VA = "0x185200180")]
		public IPKEJDBNDEC HGEKGOKJCDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x51FFFB0", Offset = "0x51FE9B0", VA = "0x1851FFFB0")]
		private IPKEJDBNDEC FCKHNAHBLOG(out IPKEJDBNDEC JHHAKPKDDNE, out IPKEJDBNDEC LICGBFNIAKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x52002E0", Offset = "0x51FECE0", VA = "0x1852002E0")]
		private IPKEJDBNDEC IHECFBPBFEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5200680", Offset = "0x51FF080", VA = "0x185200680")]
		private void OFIKEEJGAHH(IPKEJDBNDEC MLFDBJOGIFO, IPKEJDBNDEC GBAABBAEBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x52004E0", Offset = "0x51FEEE0", VA = "0x1852004E0")]
		private void MPELEKCLLNC(IPKEJDBNDEC JHHAKPKDDNE, IPKEJDBNDEC LICGBFNIAKG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private HFBDMALPJBF HKMONJIHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private OFAAHBABBKD HOHEJAGNDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private IIGNMKGCDKK DKBKHCPKCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NOJKDOFCOEE IFOIKAOPFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool HBGEABJOELM;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool IMJAHDDOHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x51F9BF0", Offset = "0x51F85F0", VA = "0x1851F9BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JKLONLNGCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x51F8930", Offset = "0x51F7330", VA = "0x1851F8930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x51FB4D0", Offset = "0x51F9ED0", VA = "0x1851FB4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x51FBA90", Offset = "0x51FA490", VA = "0x1851FBA90")]
	public void OIEJOMHJJDA(HFBDMALPJBF HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x51FACB0", Offset = "0x51F96B0", VA = "0x1851FACB0")]
	public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x51FA4F0", Offset = "0x51F8EF0", VA = "0x1851FA4F0")]
	public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x51F9140", Offset = "0x51F7B40", VA = "0x1851F9140")]
	public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x51F8AE0", Offset = "0x51F74E0", VA = "0x1851F8AE0")]
	public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x51F9110", Offset = "0x51F7B10", VA = "0x1851F9110")]
	public void CHHGHIAELMK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x51F8950", Offset = "0x51F7350", VA = "0x1851F8950")]
	private void BCAPODGCCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x51FA280", Offset = "0x51F8C80", VA = "0x1851FA280")]
	private IPKEJDBNDEC GDFFIBDCAII(DKHGAALDMFL ELOCLFMIMAL, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x51F8E90", Offset = "0x51F7890", VA = "0x1851F8E90")]
	private static void CGFDICLIABL(DKHGAALDMFL ELOCLFMIMAL, bool CJCAEDNHBOC, IPKEJDBNDEC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x51F9520", Offset = "0x51F7F20", VA = "0x1851F9520")]
	private void EFDPBPELAMD(DKHGAALDMFL ELOCLFMIMAL, bool CJCAEDNHBOC, IPKEJDBNDEC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x51FA460", Offset = "0x51F8E60", VA = "0x1851FA460")]
	private IPKEJDBNDEC HDODLOEHOMH(DKHGAALDMFL AFNICFHKIBD, HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x51F9720", Offset = "0x51F8120", VA = "0x1851F9720")]
	private bool EHMAIDHAFIA(BMHGMDONJJK DPOIAAJKCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x51F9C40", Offset = "0x51F8640", VA = "0x1851F9C40")]
	private bool FEOEGBONOGC(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x51FBB00", Offset = "0x51FA500", VA = "0x1851FBB00")]
	private bool PAAJIMKGNMK(BMHGMDONJJK HOHEJAGNDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x51F99A0", Offset = "0x51F83A0", VA = "0x1851F99A0")]
	private static bool EKABCGMOCFM(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x51FB4F0", Offset = "0x51F9EF0", VA = "0x1851FB4F0")]
	public static bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x51F91D0", Offset = "0x51F7BD0", VA = "0x1851F91D0")]
	private OKOJNEBFOCP DBJBMECPPCB(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x51F8D00", Offset = "0x51F7700", VA = "0x1851F8D00")]
	private OKOJNEBFOCP CDAOLMNGKBP(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x51F8B80", Offset = "0x51F7580", VA = "0x1851F8B80")]
	private OKOJNEBFOCP BLBIBFOGNCM(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x51FB7B0", Offset = "0x51FA1B0", VA = "0x1851FB7B0")]
	private static Guid MHBJBMODMBJ(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x51F9B10", Offset = "0x51F8510", VA = "0x1851F9B10")]
	private string EOJABIALLKL(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x51FB370", Offset = "0x51F9D70", VA = "0x1851FB370")]
	private bool KLPIOPAFNHL(DKHGAALDMFL ELOCLFMIMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x51FB7F0", Offset = "0x51FA1F0", VA = "0x1851FB7F0")]
	private static void NPNJGHOKPEF(DKHGAALDMFL AFNICFHKIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public NCDFGJCEFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public sealed class NDBLCDOFLCB : IICAMGGJJNC, AMEJFCPFPAA
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private const string JAMICMJCHFL = "Parented";

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string GNEHEBCHIDN = "ConnectableHierarchyIsSelected";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GameObject EHEABJNEALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly IHBAODPGPGM DHJAKBDIMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LHMBBJKNPDI FFMNGIOPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LNPKCEGMEFM[] OLAEKPIDBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly ECCOODIKAKJ NBJJAAKBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private List<OKOJNEBFOCP> JOBMKGHHFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private OEPFFFMEFHC CDFGFBIENBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private Vector3 ELIHMIEAMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Quaternion NDIEBGHEIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool GKDCJGJJKKB;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public OKOJNEBFOCP NOACAMDIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676B20", VA = "0x180678120", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OKOJNEBFOCP CNDFBIIJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x67DD80", Offset = "0x67C780", VA = "0x18067DD80", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x914880", Offset = "0x913280", VA = "0x180914880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 HONBKEOHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x51FE140", Offset = "0x51FCB40", VA = "0x1851FE140", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x11DC310", Offset = "0x11DAD10", VA = "0x1811DC310")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion INJAKMAKCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x51FE3B0", Offset = "0x51FCDB0", VA = "0x1851FE3B0", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x15D9730", Offset = "0x15D8130", VA = "0x1815D9730")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IANGGKLPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xC2E890", Offset = "0xC2D290", VA = "0x180C2E890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xC2EE30", Offset = "0xC2D830", VA = "0x180C2EE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LMOIKHBNEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x51FE830", Offset = "0x51FD230", VA = "0x1851FE830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OKOJNEBFOCP JJJHPDGFMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6B36A0", Offset = "0x6B20A0", VA = "0x1806B36A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x913EA0", Offset = "0x9128A0", VA = "0x180913EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool KBGCGPFEIII
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x51FE530", Offset = "0x51FCF30", VA = "0x1851FE530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx KPIIJANPMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x51FE350", Offset = "0x51FCD50", VA = "0x1851FE350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<OKOJNEBFOCP> IJIEGILBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x67E570", Offset = "0x67CF70", VA = "0x18067E570", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GMIGCPFPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x51FD080", Offset = "0x51FBA80", VA = "0x1851FD080", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x51FDEC0", Offset = "0x51FC8C0", VA = "0x1851FDEC0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x51FF880", Offset = "0x51FE280", VA = "0x1851FF880", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x51FF5F0", Offset = "0x51FDFF0", VA = "0x1851FF5F0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid DADEPEKMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x51FF750", Offset = "0x51FE150", VA = "0x1851FF750", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MBHJFOLEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x51FF830", Offset = "0x51FE230", VA = "0x1851FF830", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NIALADIPDNC CDCHGJINIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x51FF640", Offset = "0x51FE040", VA = "0x1851FF640", Slot = "39")]
		get
		{
			return default(NIALADIPDNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DKKKOJNAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x67AD00", Offset = "0x679700", VA = "0x18067AD00", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MNDJHOAPIBF MACPKEBHOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x51FDF80", Offset = "0x51FC980", VA = "0x1851FDF80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x51FCFE0", Offset = "0x51FB9E0", VA = "0x1851FCFE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MNDJHOAPIBF MOPDNAHNMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x51FE5A0", Offset = "0x51FCFA0", VA = "0x1851FE5A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x51FCF40", Offset = "0x51FB940", VA = "0x1851FCF40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MNDJHOAPIBF PBEFKDLNBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x51FD770", Offset = "0x51FC170", VA = "0x1851FD770", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x51FC8C0", Offset = "0x51FB2C0", VA = "0x1851FC8C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PLNJGDCELKP FCPIJPKBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x51FC200", Offset = "0x51FAC00", VA = "0x1851FC200", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x51FE420", Offset = "0x51FCE20", VA = "0x1851FE420", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x51FDE60", Offset = "0x51FC860", VA = "0x1851FDE60")]
	private RigidbodyEx HEKLNEIOEDG(OKOJNEBFOCP FFMNGIOPDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x51FF500", Offset = "0x51FDF00", VA = "0x1851FF500")]
	public NDBLCDOFLCB(GameObject EHEABJNEALG, LHMBBJKNPDI FFMNGIOPDCC, LNPKCEGMEFM[] OLAEKPIDBOB, ECCOODIKAKJ NBJJAAKBODP, IHBAODPGPGM DHJAKBDIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x51FE640", Offset = "0x51FD040", VA = "0x1851FE640", Slot = "20")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x51FD4C0", Offset = "0x51FBEC0", VA = "0x1851FD4C0", Slot = "22")]
	public void GFHALMIKJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x51FE020", Offset = "0x51FCA20", VA = "0x1851FE020", Slot = "23")]
	public void JFHFEDABDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x51FE840", Offset = "0x51FD240", VA = "0x1851FE840", Slot = "21")]
	public void PMIJFIGEABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x51FD520", Offset = "0x51FBF20", VA = "0x1851FD520")]
	private void GGEFIKNKMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x51FC2A0", Offset = "0x51FACA0", VA = "0x1851FC2A0")]
	private void BONBJGNPNEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x51FC960", Offset = "0x51FB360", VA = "0x1851FC960", Slot = "24")]
	public void DJIACPONHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x51FE580", Offset = "0x51FCF80", VA = "0x1851FE580", Slot = "25")]
	public void NHCBKIIPOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x51FC980", Offset = "0x51FB380", VA = "0x1851FC980", Slot = "26")]
	public void EFEKJOBOGCE(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x51FD6D0", Offset = "0x51FC0D0", VA = "0x1851FD6D0", Slot = "27")]
	public void GHDBODICNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x51FCBF0", Offset = "0x51FB5F0", VA = "0x1851FCBF0", Slot = "28")]
	public void EIJNJFKEGHA(int EBNBMBEOMKP, OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, [Optional] Vector3? GDILIOHLNNI, [Optional] Quaternion? HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x51FE0A0", Offset = "0x51FCAA0", VA = "0x1851FE0A0", Slot = "29")]
	public void JKECLMBIAPM(OKOJNEBFOCP FIGBCGFFKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x51FD0D0", Offset = "0x51FBAD0", VA = "0x1851FD0D0")]
	private void GAIKGICPHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x51FE1B0", Offset = "0x51FCBB0", VA = "0x1851FE1B0", Slot = "31")]
	public void KMFFIGCDCMN(int EBBLFLFCHFB, Vector3 EOJNMKIFHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x51FD810", Offset = "0x51FC210", VA = "0x1851FD810", Slot = "32")]
	public void GOGFEIDLBDA(Vector3 BECIPDCMBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x51FBB20", Offset = "0x51FA520", VA = "0x1851FBB20", Slot = "30")]
	public void BCADEKFLALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x51FDD90", Offset = "0x51FC790", VA = "0x1851FDD90", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x51FDC50", Offset = "0x51FC650", VA = "0x1851FDC50", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x17CA0F0", Offset = "0x17C8AF0", VA = "0x1817CA0F0", Slot = "43")]
	public Color GetConnectionSlotColor(int EBNBMBEOMKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x51FC450", Offset = "0x51FAE50", VA = "0x1851FC450", Slot = "44")]
	public bool CanConnectTo(int EBNBMBEOMKP, OKOJNEBFOCP NCFHOBEDKHL, int BCBMLFMIALA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x51FE790", Offset = "0x51FD190", VA = "0x1851FE790")]
	public bool PEGCDPIHGIH(OKOJNEBFOCP OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x51FE8D0", Offset = "0x51FD2D0", VA = "0x1851FE8D0", Slot = "45")]
	public void ParentChanged(int EBNBMBEOMKP, OKOJNEBFOCP DHBEDIHFIAN, int KOJFFNPKENB, Vector3 DMDBIJHOHIJ, Quaternion PJDANGLLKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x51FC4F0", Offset = "0x51FAEF0", VA = "0x1851FC4F0", Slot = "46")]
	public void ChildAdded(int EBNBMBEOMKP, OKOJNEBFOCP CPJKMEIJGID, int NLFIDJLEDPC, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x51FC6A0", Offset = "0x51FB0A0", VA = "0x1851FC6A0", Slot = "47")]
	public void ChildRemoved(int EBNBMBEOMKP, OKOJNEBFOCP HGIPAGJIMDK, int DKIHCBGOPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x51FC760", Offset = "0x51FB160", VA = "0x1851FC760", Slot = "48")]
	public void ConnectionModified(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x51FF4A0", Offset = "0x51FDEA0", VA = "0x1851FF4A0", Slot = "49")]
	public void RootChanged(OKOJNEBFOCP OKAGMHACBGC, OKOJNEBFOCP DEGGONGNNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x51FE4C0", Offset = "0x51FCEC0", VA = "0x1851FE4C0")]
	private void MOGOJKNHGAO(CJIONLFKLCG EDBBHNLOENN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal struct DNCNIKEBCFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public OKOJNEBFOCP IMDKOHMGEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public OKOJNEBFOCP LFAIGCEGCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int AAJBCEMEGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public int EBNEMFKPDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Vector3 GDILIOHLNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Quaternion HIMAIGGLOGC;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public FLFPBJIEAPK GLIFCBPLADF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x51F0D80", Offset = "0x51EF780", VA = "0x1851F0D80")]
		get
		{
			return default(FLFPBJIEAPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FLFPBJIEAPK DEFCOEMOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x51F0E20", Offset = "0x51EF820", VA = "0x1851F0E20")]
		get
		{
			return default(FLFPBJIEAPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x51F0E90", Offset = "0x51EF890", VA = "0x1851F0E90")]
	public DNCNIKEBCFI(OKOJNEBFOCP IMDKOHMGEGA, OKOJNEBFOCP LFAIGCEGCPL, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface OFAAHBABBKD
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	MMHEHNGHKHL AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIEJOMHJJDA(IHBAODPGPGM HKMONJIHHIH);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BLPDDJNNIAJ(in DNCNIKEBCFI JIHCLPECHIB, bool EHOIGELLJPC = true);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HEJDLKFAHKI(OKOJNEBFOCP MCIGJNMJJIG);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DDLHAJKIAGE(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CDCKHJBBGPH(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPCLMLEHOAE();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFLCLFLMCFP(Func<OKOJNEBFOCP, bool> DPNAHJMIHBE);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GNBPJFHFHNC(OKOJNEBFOCP JEDGMEJHFGK, out Vector3 GDILIOHLNNI, out Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OKOJNEBFOCP NAFNJGJKKEK(OKOJNEBFOCP JEDGMEJHFGK);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> DDDNIOCKBFD);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	List<OKOJNEBFOCP> KHPGDFHINKH();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MOJGDFCMJHE(OKOJNEBFOCP JEDGMEJHFGK, out FLFPBJIEAPK FOJEJMNBCOM);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PGIMMCFLBOJ(MEDCGBEMCOB ONHFNOPIIKL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal delegate bool MEDCGBEMCOB(MMHEHNGHKHL ELOCLFMIMAL);
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface MMHEHNGHKHL
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	OKOJNEBFOCP NOACAMDIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	int BJCALIGFKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int JHMKKLIJODB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Vector3 NJNDKGHCJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Quaternion MAIIAOAIBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	MMHEHNGHKHL HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	MMHEHNGHKHL AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	FLFPBJIEAPK KLLKDAPFJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	bool DHFEEDJEGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool GAKPFGOKFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PGIMMCFLBOJ(MEDCGBEMCOB ONHFNOPIIKL, bool NPBOCMDCJPH = true);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MMHEHNGHKHL KCDNLPOEHHI(FLFPBJIEAPK JJHBJCHAHFL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface GDILIKAPCAN
{
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFEPEMKMGAF(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIMPKLODEPB(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIOFIGKOIJD(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABJGBFPCLPO(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GDILIKAPCAN Instantiate(Transform HJLACGOIJCA);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGPEMOPMMCE();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FLIFEJHGKGO
{
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIEJOMHJJDA(Transform HJLACGOIJCA, GDILIKAPCAN KKMCOADLCAG);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GDILIKAPCAN AAMLBALCMHN();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHICMFEONDP(GDILIKAPCAN DKHKLBFKJHL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface GGIFJLOMMKD : KLEAMHNNPIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJAFEEHJKHN(Guid DBGPJJMMAIB);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface IIGNMKGCDKK
{
	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLFNLAOPCHN(MMHEHNGHKHL OEHGOIINOPJ);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIEJOMHJJDA(OFAAHBABBKD HOHEJAGNDDK, FLIFEJHGKGO BNDCLBMJDKF);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ONOFHCMJGIJ();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NOGNNJFIDLG(MMHEHNGHKHL CFFOKEIIBKO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGFEINBGJPI(MMHEHNGHKHL IPMDKFFOGEL);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OOMHDACJDCA();
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal class DKHGAALDMFL : MMHEHNGHKHL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class LNHMKKPONJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FLFPBJIEAPK nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DKHGAALDMFL foundNode;

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LNHMKKPONJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x51F5E90", Offset = "0x51F4890", VA = "0x1851F5E90")]
		internal bool <FindNode>b__0(MMHEHNGHKHL x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private FLFPBJIEAPK FOJEJMNBCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public LinkedList<DKHGAALDMFL> KEPEEEPLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private DKHGAALDMFL NAHNEMIIEDG;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public FLFPBJIEAPK KLLKDAPFJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x2F8A480", Offset = "0x2F88E80", VA = "0x182F8A480", Slot = "16")]
		get
		{
			return default(FLFPBJIEAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x51F0680", Offset = "0x51EF080", VA = "0x1851F0680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private DKHGAALDMFL LFAIGCEGCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675AD0", VA = "0x1806770D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x51EFED0", Offset = "0x51EE8D0", VA = "0x1851EFED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public MMHEHNGHKHL HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6770D0", Offset = "0x675AD0", VA = "0x1806770D0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public OKOJNEBFOCP NOACAMDIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x678AC0", Offset = "0x6774C0", VA = "0x180678AC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x697130", Offset = "0x695B30", VA = "0x180697130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int BJCALIGFKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x678BD0", Offset = "0x6775D0", VA = "0x180678BD0", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x71B410", Offset = "0x719E10", VA = "0x18071B410", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int JHMKKLIJODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x692C90", Offset = "0x691690", VA = "0x180692C90", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x71B320", Offset = "0x719D20", VA = "0x18071B320", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 NJNDKGHCJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x14C5010", Offset = "0x14C3A10", VA = "0x1814C5010", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x14C5030", Offset = "0x14C3A30", VA = "0x1814C5030", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion MAIIAOAIBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1543F20", Offset = "0x1542920", VA = "0x181543F20", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4D2FE50", Offset = "0x4D2E850", VA = "0x184D2FE50", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool DHFEEDJEGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x96E1A0", Offset = "0x96CBA0", VA = "0x18096E1A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GAKPFGOKFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x51EFCB0", Offset = "0x51EE6B0", VA = "0x1851EFCB0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected DKHGAALDMFL COMPFMNMPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x51F0130", Offset = "0x51EEB30", VA = "0x1851F0130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MMHEHNGHKHL AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x51F0130", Offset = "0x51EEB30", VA = "0x1851F0130", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x51F0B40", Offset = "0x51EF540", VA = "0x1851F0B40")]
	public DKHGAALDMFL(FLFPBJIEAPK MILJEHDAFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x51F0760", Offset = "0x51EF160", VA = "0x1851F0760")]
	public DKHGAALDMFL OPJJCFHECII(FLFPBJIEAPK LJDBDONGGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x51EFFB0", Offset = "0x51EE9B0", VA = "0x1851EFFB0")]
	public DKHGAALDMFL ILDGPHJKKOK(FLFPBJIEAPK FCCMFDFBMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x51EFD00", Offset = "0x51EE700", VA = "0x1851EFD00")]
	public DKHGAALDMFL EMIFMEAGDDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x51F08A0", Offset = "0x51EF2A0", VA = "0x1851F08A0")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x51F06B0", Offset = "0x51EF0B0", VA = "0x1851F06B0")]
	public DKHGAALDMFL MCJNECDJBOA(FLFPBJIEAPK EBIGGMLCEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x51F09F0", Offset = "0x51EF3F0", VA = "0x1851F09F0")]
	private static void PGIMMCFLBOJ(DKHGAALDMFL PCMPADLEGBP, MEDCGBEMCOB OECIEBPBJFM, bool NAEEAKOGBDO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x51F09E0", Offset = "0x51EF3E0", VA = "0x1851F09E0", Slot = "19")]
	public void PGIMMCFLBOJ(MEDCGBEMCOB ONHFNOPIIKL, bool NPBOCMDCJPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x51F0150", Offset = "0x51EEB50", VA = "0x1851F0150")]
	public static string KABCHDDLAJE(DKHGAALDMFL PCMPADLEGBP, int IFJOKNDLBML = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x51F0650", Offset = "0x51EF050", VA = "0x1851F0650", Slot = "20")]
	public MMHEHNGHKHL KCDNLPOEHHI(FLFPBJIEAPK JJHBJCHAHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x51F0540", Offset = "0x51EEF40", VA = "0x1851F0540")]
	public static DKHGAALDMFL KCDNLPOEHHI(DKHGAALDMFL PCMPADLEGBP, FLFPBJIEAPK JJHBJCHAHFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface NOJKDOFCOEE
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool IMJAHDDOHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool CKJBFOGMGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event Action<CJIONLFKLCG> AGMHAHKPAMK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event Action<CJIONLFKLCG> GEADGMGMOHG;

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(HFBDMALPJBF HKMONJIHHIH);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestMasterModifyNode(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void RequestMasterReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void RequestMasterReparentToRoot(OKOJNEBFOCP FENIHKAOGCI);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void RequestDeserializeConnectableGraph(BMHGMDONJJK FCBBNEOJGMK, [Optional] CJIONLFKLCG CKNDOEDFOCI);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, NOJKDOFCOEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private HFBDMALPJBF HKMONJIHHIH;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool IMJAHDDOHLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x51F7560", Offset = "0x51F5F60", VA = "0x1851F7560", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool CKJBFOGMGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x51F75C0", Offset = "0x51F5FC0", VA = "0x1851F75C0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<CJIONLFKLCG> AGMHAHKPAMK
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x51F74C0", Offset = "0x51F5EC0", VA = "0x1851F74C0", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x51F76B0", Offset = "0x51F60B0", VA = "0x1851F76B0", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<CJIONLFKLCG> GEADGMGMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x51F7420", Offset = "0x51F5E20", VA = "0x1851F7420", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x51F7610", Offset = "0x51F6010", VA = "0x1851F7610", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A0", Offset = "0x67CFA0", VA = "0x18067E5A0", Slot = "22")]
		public void SetManager(HFBDMALPJBF HKMONJIHHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x51F73F0", Offset = "0x51F5DF0", VA = "0x1851F73F0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x51F60F0", Offset = "0x51F4AF0", VA = "0x1851F60F0", Slot = "23")]
		public void RequestMasterConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x51F6220", Offset = "0x51F4C20", VA = "0x1851F6220", Slot = "24")]
		public void RequestMasterDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x51F62F0", Offset = "0x51F4CF0", VA = "0x1851F62F0", Slot = "25")]
		public void RequestMasterModifyNode(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x51F6420", Offset = "0x51F4E20", VA = "0x1851F6420", Slot = "26")]
		public void RequestMasterReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x51F6550", Offset = "0x51F4F50", VA = "0x1851F6550", Slot = "27")]
		public void RequestMasterReparentToRoot(OKOJNEBFOCP FENIHKAOGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x51F5FC0", Offset = "0x51F49C0", VA = "0x1851F5FC0", Slot = "28")]
		public void RequestDeserializeConnectableGraph(BMHGMDONJJK FCBBNEOJGMK, [Optional] CJIONLFKLCG CKNDOEDFOCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x51F6940", Offset = "0x51F5340", VA = "0x1851F6940")]
		[MNIDOGALBOE]
		private void RpcMasterConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x51F6C10", Offset = "0x51F5610", VA = "0x1851F6C10")]
		[MNIDOGALBOE]
		private void RpcMasterDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x51F6F70", Offset = "0x51F5970", VA = "0x1851F6F70")]
		[MNIDOGALBOE]
		private void RpcMasterReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x51F6D60", Offset = "0x51F5760", VA = "0x1851F6D60")]
		[MNIDOGALBOE]
		private void RpcMasterModifyNode(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x51F6720", Offset = "0x51F5120", VA = "0x1851F6720")]
		[MNIDOGALBOE]
		private void RpcConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x51F68B0", Offset = "0x51F52B0", VA = "0x1851F68B0")]
		[MNIDOGALBOE]
		private void RpcDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x51F72E0", Offset = "0x51F5CE0", VA = "0x1851F72E0")]
		[MNIDOGALBOE]
		private void RpcReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x51F7210", Offset = "0x51F5C10", VA = "0x1851F7210")]
		[MNIDOGALBOE]
		private void RpcModifyNode(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x51F6870", Offset = "0x51F5270", VA = "0x1851F6870")]
		[MNIDOGALBOE]
		private void RpcDeserializeConnectableGraph(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xFE5520", Offset = "0xFE3F20", VA = "0x180FE5520")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OEGLGAKMBDK
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x35DD7B0", Offset = "0x35DC1B0", VA = "0x1835DD7B0")]
	public static global::IAMONJMDPOO<T> EILBEEBKLNE<T>(this PEGEFOEHCCC IGFHDABHNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OEPFFFMEFHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DNJGGIFCOKL();

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMNEKDAGPNL(bool MAKFNMHIJIF);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DLFGEGDFLBL : OEPFFFMEFHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly global::FNIGJFEEAKB<bool> PJGOPPMNMAI;

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x51F0CB0", Offset = "0x51EF6B0", VA = "0x1851F0CB0")]
	public DLFGEGDFLBL(GMODMBJNKFK JOOJGLPIMBB, string AIGAKEKDKHM, bool BKMGNMEJDHA, CHJIMJFFBGO LMCDHLMJNAF, [Optional] Action ONHFNOPIIKL, [Optional] LBJJDFCIAGJ COAKGGNKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x51F0BE0", Offset = "0x51EF5E0", VA = "0x1851F0BE0", Slot = "4")]
	public bool DNJGGIFCOKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x51F0C50", Offset = "0x51EF650", VA = "0x1851F0C50", Slot = "5")]
	public void KMNEKDAGPNL(bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x51F0C30", Offset = "0x51EF630", VA = "0x1851F0C30", Slot = "6")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class INLKLJDBECB
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const string IFFKIHOMMPN = "The connectable subgraph being deserialized is corrupt.";

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public const string OJIIHJCHNDP = "The connectable subgraph failed to deserialize, even though it passed the corruption check.";
}
namespace RRAssemblyIndex.RecRoom.Connectables.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[Preserve]
	internal class _RRAssemblyIndex : AHAHNEIKLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x678B40", Offset = "0x677540", VA = "0x180678B40")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x52064F0", Offset = "0x5204EF0", VA = "0x1852064F0", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5206670", Offset = "0x5205070", VA = "0x185206670", Slot = "4")]
		public sealed override void GBDHAHIIBFE()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MDBMMECDLKK
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static byte[] GADOFMLHAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static int HEJKOBPMNOJ;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static int HLKLMDMLFLE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static BigInteger DBAKCFGFCLA;

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x51F7AA0", Offset = "0x51F64A0", VA = "0x1851F7AA0")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x51F7750", Offset = "0x51F6150", VA = "0x1851F7750")]
	public static string FCKPDHOJNPG(byte[] PPJLGCLGPJE, bool KMFFDGBHCMI)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
