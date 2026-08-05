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
	[Cpp2IlInjected.Address(RVA = "0x849CA0", Offset = "0x8482A0", VA = "0x180849CA0", Slot = "4")]
	public void OIEJOMHJJDA(Transform HJLACGOIJCA, NMHMDBFHOBL KKMCOADLCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54DF5E0", Offset = "0x54DDBE0", VA = "0x1854DF5E0", Slot = "5")]
	public NMHMDBFHOBL AAMLBALCMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x706850", Offset = "0x704E50", VA = "0x180706850", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7BB650", Offset = "0x7B9C50", VA = "0x1807BB650")]
			[DebuggerHidden]
			public IGBMEIOJKDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x54DF150", Offset = "0x54DD750", VA = "0x1854DF150", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x54DED30", Offset = "0x54DD330", VA = "0x1854DED30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x54DF1B0", Offset = "0x54DD7B0", VA = "0x1854DF1B0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x54DF110", Offset = "0x54DD710", VA = "0x1854DF110", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x54DF060", Offset = "0x54DD660", VA = "0x1854DF060", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<OKOJNEBFOCP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x54DF060", Offset = "0x54DD660", VA = "0x1854DF060", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8ADEE0", Offset = "0x8AC4E0", VA = "0x1808ADEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x54ED770", Offset = "0x54EBD70", VA = "0x1854ED770", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x54EC600", Offset = "0x54EAC00", VA = "0x1854EC600", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x54ED6D0", Offset = "0x54EBCD0", VA = "0x1854ED6D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x54ED610", Offset = "0x54EBC10", VA = "0x1854ED610", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x54EF100", Offset = "0x54ED700", VA = "0x1854EF100", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x54EB660", Offset = "0x54E9C60", VA = "0x1854EB660", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x54EF650", Offset = "0x54EDC50", VA = "0x1854EF650")]
		public OMConnectableManager(PEGEFOEHCCC IGFHDABHNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x54EECB0", Offset = "0x54ED2B0", VA = "0x1854EECB0", Slot = "11")]
		public void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x54EC020", Offset = "0x54EA620", VA = "0x1854EC020", Slot = "26")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x54DDFE0", Offset = "0x54DC5E0", VA = "0x1854DDFE0", Slot = "22")]
		public bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x54EC220", Offset = "0x54EA820", VA = "0x1854EC220")]
		private void ECJPEHKGLKD(NIALADIPDNC KHFJHKDEPOA, NIALADIPDNC CFCDMOHCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x54EF200", Offset = "0x54ED800", VA = "0x1854EF200")]
		private void PNDKHINKPFK(NIALADIPDNC KHFJHKDEPOA, NIALADIPDNC EDCJDKGNJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x54EE590", Offset = "0x54ECB90", VA = "0x1854EE590")]
		private void MLPGHOGOJLP(NIALADIPDNC KHFJHKDEPOA, NIALADIPDNC EDCJDKGNJGI, NIALADIPDNC CFCDMOHCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x54EA2F0", Offset = "0x54E88F0", VA = "0x1854EA2F0")]
		private void ADBFLMMPKEN(NIALADIPDNC KHFJHKDEPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "12")]
		public void LJKNPIDDPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x54EDC80", Offset = "0x54EC280", VA = "0x1854EDC80", Slot = "13")]
		public void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54EBF40", Offset = "0x54EA540", VA = "0x1854EBF40", Slot = "14")]
		public void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54EB410", Offset = "0x54E9A10", VA = "0x1854EB410", Slot = "16")]
		public void CGHCFBCONPF(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP PNLBBPCBPJE, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x54EB230", Offset = "0x54E9830", VA = "0x1854EB230")]
		public void CGHCFBCONPF(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC PNLBBPCBPJE, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x54EE2E0", Offset = "0x54EC8E0", VA = "0x1854EE2E0", Slot = "17")]
		public void MFDADFOIKLM(OKOJNEBFOCP FIGBCGFFKBJ, int GMOPDPNGPBB, OKOJNEBFOCP IDDEHLJHNOC, int ECICKIFMNCG, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54EE520", Offset = "0x54ECB20", VA = "0x1854EE520")]
		public void MFDADFOIKLM(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC LFAIGCEGCPL, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x54EA890", Offset = "0x54E8E90", VA = "0x1854EA890", Slot = "18")]
		public void APCLKPGJCEA(OKOJNEBFOCP JEDGMEJHFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x54ECDA0", Offset = "0x54EB3A0", VA = "0x1854ECDA0", Slot = "19")]
		public bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x54ECE90", Offset = "0x54EB490", VA = "0x1854ECE90")]
		public bool FNHCPJEHDGF(NIALADIPDNC KLCGNDEDAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x54EE950", Offset = "0x54ECF50", VA = "0x1854EE950", Slot = "15")]
		public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "20")]
		public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "21")]
		public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x54EBA90", Offset = "0x54EA090", VA = "0x1854EBA90", Slot = "23")]
		public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x54EAA80", Offset = "0x54E9080", VA = "0x1854EAA80", Slot = "24")]
		public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x54ED6B0", Offset = "0x54EBCB0", VA = "0x1854ED6B0", Slot = "25")]
		public void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x54EB700", Offset = "0x54E9D00", VA = "0x1854EB700")]
		private void CLDAIALGBFF(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC LFAIGCEGCPL, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x54ED0E0", Offset = "0x54EB6E0", VA = "0x1854ED0E0")]
		private void GCEAEGHJIPE(NIALADIPDNC IMDKOHMGEGA, NIALADIPDNC EBIGGMLCEAF, Vector3 PBENCDOOEDL, Quaternion AILLHFOOINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x54ECCD0", Offset = "0x54EB2D0", VA = "0x1854ECCD0")]
		private void FJDLCEFNEME(NIALADIPDNC IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x54EEC20", Offset = "0x54ED220", VA = "0x1854EEC20")]
		[IteratorStateMachine(typeof(IGBMEIOJKDK))]
		public IEnumerable<OKOJNEBFOCP> NLDMPJJFBGO(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x54EBEC0", Offset = "0x54EA4C0", VA = "0x1854EBEC0")]
		internal OKOJNEBFOCP DBJBMECPPCB(NIALADIPDNC KLCGNDEDAPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x54EAAF0", Offset = "0x54E90F0", VA = "0x1854EAAF0")]
		internal NIALADIPDNC BIKIJJFPJAP(OKOJNEBFOCP JEDGMEJHFGK)
		{
			return default(NIALADIPDNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x54EC6A0", Offset = "0x54EACA0", VA = "0x1854EC6A0")]
		private bool FEOEGBONOGC(IPKEJDBNDEC EOJBPKALALP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x54EBB00", Offset = "0x54EA100", VA = "0x1854EBB00")]
		private bool CPJAIDCOIFN(IPKEJDBNDEC EOJBPKALALP, out OKOJNEBFOCP LFAIGCEGCPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54EBB60", Offset = "0x54EA160", VA = "0x1854EBB60")]
		private OKOJNEBFOCP DBJBMECPPCB(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x54EB090", Offset = "0x54E9690", VA = "0x1854EB090")]
		private OKOJNEBFOCP CEPPIOMAHBF(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x54EAF00", Offset = "0x54E9500", VA = "0x1854EAF00")]
		private OKOJNEBFOCP CDAOLMNGKBP(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x54E5230", Offset = "0x54E3830", VA = "0x1854E5230")]
		private static Guid MHBJBMODMBJ(IPKEJDBNDEC EOJBPKALALP)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x54EC520", Offset = "0x54EAB20", VA = "0x1854EC520")]
		private string EOJABIALLKL(IPKEJDBNDEC EOJBPKALALP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x54EDAF0", Offset = "0x54EC0F0", VA = "0x1854EDAF0")]
		private void KNGJPBMEKFC(OKOJNEBFOCP IMDKOHMGEGA, OKOJNEBFOCP EBIGGMLCEAF, RigidTransform MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x54EABE0", Offset = "0x54E91E0", VA = "0x1854EABE0")]
		private void BOENFJKPGMA(OKOJNEBFOCP EBIGGMLCEAF, OKOJNEBFOCP IMDKOHMGEGA, RigidTransform MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x54EF1A0", Offset = "0x54ED7A0", VA = "0x1854EF1A0")]
		private void PIOBJKHFGOD(OKOJNEBFOCP KOEBMFNDCDN, OKOJNEBFOCP IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x54EAD70", Offset = "0x54E9370", VA = "0x1854EAD70")]
		private void CAHIPBAOHAO(OKOJNEBFOCP IMDKOHMGEGA, OKOJNEBFOCP LFAIGCEGCPL, RigidTransform MHADNCFDEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x54ED810", Offset = "0x54EBE10", VA = "0x1854ED810")]
		private void JPNLBMFEDKD(NIALADIPDNC KLCGNDEDAPD, OKOJNEBFOCP JEDGMEJHFGK, NIALADIPDNC EDCJDKGNJGI, NIALADIPDNC CFCDMOHCLML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x54EDFC0", Offset = "0x54EC5C0", VA = "0x1854EDFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LIPFNCIEGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x54DF870", Offset = "0x54DDE70", VA = "0x1854DF870")]
		internal OMConnectableManager <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x54DF240", Offset = "0x54DD840", VA = "0x1854DF240")]
	public static void OKCGDBBMIAE(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x54DF1D0", Offset = "0x54DD7D0", VA = "0x1854DF1D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C670", Offset = "0x73AC70", VA = "0x18073C670", Slot = "39")]
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
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OKOJNEBFOCP CNDFBIIJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x54DCC50", Offset = "0x54DB250", VA = "0x1854DCC50", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OKOJNEBFOCP JJJHPDGFMNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x54DC1B0", Offset = "0x54DA7B0", VA = "0x1854DC1B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 HONBKEOHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x54DC510", Offset = "0x54DAB10", VA = "0x1854DC510", Slot = "15")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion INJAKMAKCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x54DC780", Offset = "0x54DAD80", VA = "0x1854DC780", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LMOIKHBNEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x54DCA70", Offset = "0x54DB070", VA = "0x1854DCA70", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<OKOJNEBFOCP> IJIEGILBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x54DC3F0", Offset = "0x54DA9F0", VA = "0x1854DC3F0", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x8ADED0", Offset = "0x8AC4D0", VA = "0x1808ADED0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8ADEE0", Offset = "0x8AC4E0", VA = "0x1808ADEE0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x54DCE70", Offset = "0x54DB470", VA = "0x1854DCE70", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54DCBE0", Offset = "0x54DB1E0", VA = "0x1854DCBE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x54DCC00", Offset = "0x54DB200", VA = "0x1854DCC00", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid DADEPEKMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x54DCD40", Offset = "0x54DB340", VA = "0x1854DCD40", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MBHJFOLEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x54DCE20", Offset = "0x54DB420", VA = "0x1854DCE20", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool DKKKOJNAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool KBGCGPFEIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x54DC890", Offset = "0x54DAE90", VA = "0x1854DC890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MNDJHOAPIBF MACPKEBHOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54DC2A0", Offset = "0x54DA8A0", VA = "0x1854DC2A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x54DBA20", Offset = "0x54DA020", VA = "0x1854DBA20", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MNDJHOAPIBF MOPDNAHNMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x54DC940", Offset = "0x54DAF40", VA = "0x1854DC940", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x54DB9D0", Offset = "0x54D9FD0", VA = "0x1854DB9D0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MNDJHOAPIBF PBEFKDLNBFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x54DBAF0", Offset = "0x54DA0F0", VA = "0x1854DBAF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x54DB3B0", Offset = "0x54D99B0", VA = "0x1854DB3B0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event PLNJGDCELKP FCPIJPKBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x54DB270", Offset = "0x54D9870", VA = "0x1854DB270", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x54DC7F0", Offset = "0x54DADF0", VA = "0x1854DC7F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x54DCB00", Offset = "0x54DB100", VA = "0x1854DCB00")]
	public HAEJCFKABJJ(NIALADIPDNC EHLCJHMJBBP, RigidbodyEx FHCKPPNILHO, LHMBBJKNPDI FFMNGIOPDCC, LNPKCEGMEFM[] OLAEKPIDBOB, ECCOODIKAKJ NBJJAAKBODP, IHBAODPGPGM DHJAKBDIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x54DC990", Offset = "0x54DAF90", VA = "0x1854DC990", Slot = "20")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "22")]
	public void GFHALMIKJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x54DC2F0", Offset = "0x54DA8F0", VA = "0x1854DC2F0", Slot = "23")]
	public void JFHFEDABDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54DCA90", Offset = "0x54DB090", VA = "0x1854DCA90", Slot = "21")]
	public void PMIJFIGEABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x54DB460", Offset = "0x54D9A60", VA = "0x1854DB460", Slot = "26")]
	public void EFEKJOBOGCE(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54DBA70", Offset = "0x54DA070", VA = "0x1854DBA70", Slot = "27")]
	public void GHDBODICNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54DB6B0", Offset = "0x54D9CB0", VA = "0x1854DB6B0", Slot = "28")]
	public void EIJNJFKEGHA(int EBNBMBEOMKP, OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, [Optional] Vector3? GDILIOHLNNI, [Optional] Quaternion? HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x54DC490", Offset = "0x54DAA90", VA = "0x1854DC490", Slot = "29")]
	public void JKECLMBIAPM(OKOJNEBFOCP FIGBCGFFKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x54DBB40", Offset = "0x54DA140", VA = "0x1854DBB40", Slot = "32")]
	public void GOGFEIDLBDA(Vector3 BECIPDCMBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x54DAFB0", Offset = "0x54D95B0", VA = "0x1854DAFB0", Slot = "30")]
	public void BCADEKFLALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x54DC580", Offset = "0x54DAB80", VA = "0x1854DC580", Slot = "31")]
	public void KMFFIGCDCMN(int EBBLFLFCHFB, Vector3 EOJNMKIFHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x54DC080", Offset = "0x54DA680", VA = "0x1854DC080", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x54DBF40", Offset = "0x54DA540", VA = "0x1854DBF40", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x25BBCF0", Offset = "0x25BA2F0", VA = "0x1825BBCF0", Slot = "43")]
	public Color GetConnectionSlotColor(int EBNBMBEOMKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x54DB310", Offset = "0x54D9910", VA = "0x1854DB310", Slot = "44")]
	public bool CanConnectTo(int EBNBMBEOMKP, OKOJNEBFOCP NCFHOBEDKHL, int BCBMLFMIALA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "45")]
	public void ParentChanged(int EBNBMBEOMKP, OKOJNEBFOCP DHBEDIHFIAN, int KOJFFNPKENB, Vector3 DMDBIJHOHIJ, Quaternion PJDANGLLKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "46")]
	public void ChildAdded(int EBNBMBEOMKP, OKOJNEBFOCP CPJKMEIJGID, int NLFIDJLEDPC, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "47")]
	public void ChildRemoved(int EBNBMBEOMKP, OKOJNEBFOCP HGIPAGJIMDK, int DKIHCBGOPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "48")]
	public void ConnectionModified(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54DCAE0", Offset = "0x54DB0E0", VA = "0x1854DCAE0", Slot = "49")]
	public void RootChanged(OKOJNEBFOCP OKAGMHACBGC, OKOJNEBFOCP DEGGONGNNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x54DC9C0", Offset = "0x54DAFC0", VA = "0x1854DC9C0")]
	public bool PEGCDPIHGIH(OKOJNEBFOCP OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x54DB400", Offset = "0x54D9A00", VA = "0x1854DB400", Slot = "24")]
	public void DJIACPONHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x54DC8E0", Offset = "0x54DAEE0", VA = "0x1854DC8E0", Slot = "25")]
	public void NHCBKIIPOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x54DC720", Offset = "0x54DAD20", VA = "0x1854DC720")]
	private void LBLPDEBDJFH(bool LELJAOIMNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x54DC150", Offset = "0x54DA750", VA = "0x1854DC150")]
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
		[Cpp2IlInjected.Address(RVA = "0x54DF410", Offset = "0x54DDA10", VA = "0x1854DF410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x54DF4B0", Offset = "0x54DDAB0", VA = "0x1854DF4B0", Slot = "6")]
	public void NDFJIGFEFMN(PFKGIHKPIGG GOCENLCAMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x54DF500", Offset = "0x54DDB00", VA = "0x1854DF500", Slot = "5")]
	public void OOJCBHBPOMO(OKKOFBJCFMA FEELJHFMNCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x54EFDB0", Offset = "0x54EE3B0", VA = "0x1854EFDB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x54EFBD0", Offset = "0x54EE1D0", VA = "0x1854EFBD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x54EFD10", Offset = "0x54EE310", VA = "0x1854EFD10", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x54EFC70", Offset = "0x54EE270", VA = "0x1854EFC70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x54EFE50", Offset = "0x54EE450", VA = "0x1854EFE50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x54EFB30", Offset = "0x54EE130", VA = "0x1854EFB30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "11")]
	public void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "12")]
	public void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "13")]
	public void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "14")]
	public void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "15")]
	public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "16")]
	public void CGHCFBCONPF(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP PNLBBPCBPJE, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "17")]
	public void MFDADFOIKLM(OKOJNEBFOCP JEDGMEJHFGK, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "18")]
	public void APCLKPGJCEA(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "19")]
	public bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "20")]
	public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290", Slot = "21")]
	public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "22")]
	public bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "23")]
	public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "24")]
	public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "25")]
	public void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "20")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x728EC0", Offset = "0x7274C0", VA = "0x180728EC0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Entity PAJBHIKEKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "11")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7226A0", Offset = "0x720CA0", VA = "0x1807226A0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x54D3C30", Offset = "0x54D2230", VA = "0x1854D3C30", Slot = "4")]
		private void DKNEMBDOCPM(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x54D3E90", Offset = "0x54D2490", VA = "0x1854D3E90", Slot = "5")]
		private void HHGLCIEBHAP(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x54D41C0", Offset = "0x54D27C0", VA = "0x1854D41C0", Slot = "6")]
		private void MJKOGJFBIDD(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x54D4420", Offset = "0x54D2A20", VA = "0x1854D4420", Slot = "7")]
		private void NJACFOBPFGE(OKOJNEBFOCP IDDEHLJHNOC, FLFPBJIEAPK IMDKOHMGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x54D4650", Offset = "0x54D2C50", VA = "0x1854D4650", Slot = "8")]
		private GDILIKAPCAN ONBPIBIPFKE(Transform HJLACGOIJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x54D45F0", Offset = "0x54D2BF0", VA = "0x1854D45F0", Slot = "9")]
		private void NLGDCIENBEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x54D4140", Offset = "0x54D2740", VA = "0x1854D4140")]
		private void KMNEKDAGPNL(ref Entity FLADPKIONGF, Entity MAKFNMHIJIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x54D4150", Offset = "0x54D2750", VA = "0x1854D4150", Slot = "14")]
		private void LABDKGMEJIF(float3 EOJNMKIFHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x54D43B0", Offset = "0x54D29B0", VA = "0x1854D43B0", Slot = "13")]
		private void NGIBEEIHCNI(float3 EOJNMKIFHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x54D3DC0", Offset = "0x54D23C0", VA = "0x1854D3DC0", Slot = "15")]
		private void FIOLGFOELJB(out float3 LJECKBCMELA, out float3 EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x54D3CF0", Offset = "0x54D22F0", VA = "0x1854D3CF0", Slot = "16")]
		private void FEMEABCNLLC(float3 LJECKBCMELA, float3 EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x54D3BD0", Offset = "0x54D21D0", VA = "0x1854D3BD0", Slot = "17")]
		private void DADFAGLGPGE(Color LJECKBCMELA, Color EAJAFIHJLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x54D46D0", Offset = "0x54D2CD0", VA = "0x1854D46D0", Slot = "18")]
		private NMHMDBFHOBL PNOMOIHIDOM(Transform HJLACGOIJCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x54D4750", Offset = "0x54D2D50", VA = "0x1854D4750", Slot = "19")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x731A70", Offset = "0x730070", VA = "0x180731A70")]
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
			[Cpp2IlInjected.Address(RVA = "0x7834A0", Offset = "0x781AA0", VA = "0x1807834A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public KNLEKNIBFEP LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public KNLEKNIBFEP ObjectModelLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x681C00", Offset = "0x680200", VA = "0x180681C00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x54D3AE0", Offset = "0x54D20E0", VA = "0x1854D3AE0")]
		public static ConnectableConfigData PHFCPGGCCJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x54D3B80", Offset = "0x54D2180", VA = "0x1854D3B80")]
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
	[Cpp2IlInjected.Address(RVA = "0x54DAEF0", Offset = "0x54D94F0", VA = "0x1854DAEF0")]
	public FLFPBJIEAPK(OKOJNEBFOCP JEDGMEJHFGK, int EBAABILDMOD, int KMDIEJDGEIP, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x54DAE30", Offset = "0x54D9430", VA = "0x1854DAE30")]
	public FLFPBJIEAPK(OKOJNEBFOCP JEDGMEJHFGK, int EBAABILDMOD, int KMDIEJDGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x54DAEA0", Offset = "0x54D94A0", VA = "0x1854DAEA0")]
	public FLFPBJIEAPK(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x54DA980", Offset = "0x54D8F80", VA = "0x1854DA980", Slot = "4")]
	public bool Equals(FLFPBJIEAPK OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x54DAA20", Offset = "0x54D9020", VA = "0x1854DAA20", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x849CA0", Offset = "0x8482A0", VA = "0x180849CA0", Slot = "4")]
	public void OIEJOMHJJDA(Transform HJLACGOIJCA, GDILIKAPCAN KKMCOADLCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x54D2E50", Offset = "0x54D1450", VA = "0x1854D2E50", Slot = "5")]
	public GDILIKAPCAN AAMLBALCMHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x54D2EA0", Offset = "0x54D14A0", VA = "0x1854D2EA0", Slot = "6")]
	public void LHICMFEONDP(GDILIKAPCAN DKHKLBFKJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public PDNNFBPHOKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x54EF6C0", Offset = "0x54EDCC0", VA = "0x1854EF6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54D51E0", Offset = "0x54D37E0", VA = "0x1854D51E0")]
	public bool BLPDDJNNIAJ(in DNCNIKEBCFI JIHCLPECHIB, bool EHOIGELLJPC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x54D82B0", Offset = "0x54D68B0", VA = "0x1854D82B0")]
	private bool PELODFOECIP(in DNCNIKEBCFI JIHCLPECHIB, bool EHOIGELLJPC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54D5BA0", Offset = "0x54D41A0", VA = "0x1854D5BA0", Slot = "8")]
	public bool HEJDLKFAHKI(OKOJNEBFOCP MCIGJNMJJIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x54D4C00", Offset = "0x54D3200", VA = "0x1854D4C00")]
	private bool BHFEHDPEDLC(OKOJNEBFOCP LBPNFPHBBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54D56B0", Offset = "0x54D3CB0", VA = "0x1854D56B0")]
	private static bool EMEFGGHHNLP(OKOJNEBFOCP LBPNFPHBBEJ, DKHGAALDMFL NBCIPPOMHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x54D5D80", Offset = "0x54D4380", VA = "0x1854D5D80")]
	private void HLDDPJPHFKI(Transform FFNPCMLEJIK, DKHGAALDMFL OGOJPJEOAPA, DKHGAALDMFL[] EPGHKFNBHNP, OKOJNEBFOCP LFLOFJCEDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x54D58E0", Offset = "0x54D3EE0", VA = "0x1854D58E0")]
	private FLFPBJIEAPK FPJMLFNNFCA(Transform GLLGMGLMIJM, FLFPBJIEAPK COKPBKBDKLD)
	{
		return default(FLFPBJIEAPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54D5430", Offset = "0x54D3A30", VA = "0x1854D5430")]
	private static bool CJHGIPDIICO(DKHGAALDMFL NBCIPPOMHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x54D75A0", Offset = "0x54D5BA0", VA = "0x1854D75A0")]
	private string MHCHBKFLKKI(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x54D6F70", Offset = "0x54D5570", VA = "0x1854D6F70")]
	private string JIIDPOMOIME(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x54D8B90", Offset = "0x54D7190", VA = "0x1854D8B90")]
	private void PHKCLCHAGLC(in DNCNIKEBCFI JIHCLPECHIB, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x54D4A30", Offset = "0x54D3030", VA = "0x1854D4A30")]
	private void ABJANMCLFPP(OKOJNEBFOCP IMDKOHMGEGA, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x54D6290", Offset = "0x54D4890", VA = "0x1854D6290")]
	private void IJGELJNLKAG(OKOJNEBFOCP FENIHKAOGCI, int AAJBCEMEGHA, OKOJNEBFOCP EBIGGMLCEAF, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, bool HEOPHCHJMAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x54D7BE0", Offset = "0x54D61E0", VA = "0x1854D7BE0")]
	private void NNMJPPCMMPE(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, bool HNCECPFLCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x54D55D0", Offset = "0x54D3BD0", VA = "0x1854D55D0", Slot = "9")]
	public bool DDLHAJKIAGE(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x54D9330", Offset = "0x54D7930", VA = "0x1854D9330")]
	private bool PLNNGOJIKJF(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x54D5760", Offset = "0x54D3D60", VA = "0x1854D5760")]
	private static void FIMPMMCGPJB(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, DKHGAALDMFL LIPMMGJPKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x54D7230", Offset = "0x54D5830", VA = "0x1854D7230")]
	private void KNGJPBMEKFC(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x54D61B0", Offset = "0x54D47B0", VA = "0x1854D61B0")]
	private void IIGPMAGLIKO(DKHGAALDMFL ELOCLFMIMAL, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x54D6220", Offset = "0x54D4820", VA = "0x1854D6220")]
	private void IIGPMAGLIKO(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x54D7460", Offset = "0x54D5A60", VA = "0x1854D7460")]
	private void LKMFEEAPCKA(OKOJNEBFOCP JEDGMEJHFGK, OKOJNEBFOCP KKDHDLLKPGN, OKOJNEBFOCP EBNAKIGKECH, bool NPBOCMDCJPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x54D7350", Offset = "0x54D5950", VA = "0x1854D7350")]
	private void LKMFEEAPCKA(DKHGAALDMFL COMPFMNMPEI, OKOJNEBFOCP LFLOFJCEDOO, OKOJNEBFOCP DEGGONGNNIP, bool NPBOCMDCJPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x54D5230", Offset = "0x54D3830", VA = "0x1854D5230")]
	private void BOENFJKPGMA(OKOJNEBFOCP IMDKOHMGEGA, int AAJBCEMEGHA, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x54D91D0", Offset = "0x54D77D0", VA = "0x1854D91D0")]
	private void PIOBJKHFGOD(MMHEHNGHKHL LFAIGCEGCPL, MMHEHNGHKHL KALAGBODNPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x54D5A70", Offset = "0x54D4070", VA = "0x1854D5A70", Slot = "13")]
	public void GNBPJFHFHNC(OKOJNEBFOCP JEDGMEJHFGK, out Vector3 GDILIOHLNNI, out Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x54D7770", Offset = "0x54D5D70", VA = "0x1854D7770", Slot = "14")]
	public OKOJNEBFOCP NAFNJGJKKEK(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x54D78A0", Offset = "0x54D5EA0", VA = "0x1854D78A0", Slot = "15")]
	public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> DDDNIOCKBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x54D7020", Offset = "0x54D5620", VA = "0x1854D7020", Slot = "16")]
	public List<OKOJNEBFOCP> KHPGDFHINKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x54D6EA0", Offset = "0x54D54A0", VA = "0x1854D6EA0")]
	protected MMHEHNGHKHL JEIECNACPEP(MMHEHNGHKHL ELOCLFMIMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x54D5460", Offset = "0x54D3A60", VA = "0x1854D5460")]
	protected DKHGAALDMFL[] CJMOBHCBKPN(DKHGAALDMFL NBCIPPOMHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x54D6880", Offset = "0x54D4E80", VA = "0x1854D6880")]
	protected bool IJNELDPKHKL(OKOJNEBFOCP JEDGMEJHFGK, out DKHGAALDMFL ELOCLFMIMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x54D7670", Offset = "0x54D5C70", VA = "0x1854D7670", Slot = "17")]
	public bool MOJGDFCMJHE(OKOJNEBFOCP JEDGMEJHFGK, out FLFPBJIEAPK FOJEJMNBCOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x54D6FE0", Offset = "0x54D55E0", VA = "0x1854D6FE0")]
	protected DKHGAALDMFL KCDNLPOEHHI(FLFPBJIEAPK BDEFMHHFPMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x54D5340", Offset = "0x54D3940", VA = "0x1854D5340", Slot = "10")]
	public bool CDCKHJBBGPH(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x54D6950", Offset = "0x54D4F50", VA = "0x1854D6950")]
	private bool IPLHCPIKMLE(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x54D5500", Offset = "0x54D3B00", VA = "0x1854D5500")]
	private static bool DBPDMALAMOM(DKHGAALDMFL CNABIFICNJB, FLFPBJIEAPK CAKBJJFNHIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x54D95C0", Offset = "0x54D7BC0", VA = "0x1854D95C0")]
	public DFJPCCPKAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x54D8220", Offset = "0x54D6820", VA = "0x1854D8220", Slot = "5")]
	public void OIEJOMHJJDA(IHBAODPGPGM HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x54D8B60", Offset = "0x54D7160", VA = "0x1854D8B60", Slot = "19")]
	public void PGIMMCFLBOJ(MEDCGBEMCOB ONHFNOPIIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x54D8B50", Offset = "0x54D7150", VA = "0x1854D8B50", Slot = "12")]
	public void PFLCLFLMCFP(Func<OKOJNEBFOCP, bool> DPNAHJMIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x54D8820", Offset = "0x54D6E20", VA = "0x1854D8820")]
	private void PFLCLFLMCFP(DKHGAALDMFL ELOCLFMIMAL, Func<OKOJNEBFOCP, bool> DPNAHJMIHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x54D7580", Offset = "0x54D5B80", VA = "0x1854D7580", Slot = "11")]
	public void LPCLMLEHOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x54D51E0", Offset = "0x54D37E0", VA = "0x1854D51E0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x722510", Offset = "0x720B10", VA = "0x180722510")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x722680", Offset = "0x720C80", VA = "0x180722680")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool OKJAKPPJFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x1156030", Offset = "0x1154630", VA = "0x181156030", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1156370", Offset = "0x1154970", VA = "0x181156370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> CEANFDAHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x54DD850", Offset = "0x54DBE50", VA = "0x1854DD850", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x54DD640", Offset = "0x54DBC40", VA = "0x1854DD640", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP> GCLMAEDFBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x54DD7F0", Offset = "0x54DBDF0", VA = "0x1854DD7F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x54DD750", Offset = "0x54DBD50", VA = "0x1854DD750", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<OKOJNEBFOCP, OKOJNEBFOCP, OKOJNEBFOCP> ELCOKFFGBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x54DE990", Offset = "0x54DCF90", VA = "0x1854DE990", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x54DD450", Offset = "0x54DBA50", VA = "0x1854DD450", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x54DE9F0", Offset = "0x54DCFF0", VA = "0x1854DE9F0")]
	public HFBDMALPJBF(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x54DE350", Offset = "0x54DC950", VA = "0x1854DE350", Slot = "11")]
	public void OIEJOMHJJDA(GameObject EHEABJNEALG, LIAJIIJJKHJ GJGBECCMKIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x54DD5A0", Offset = "0x54DBBA0", VA = "0x1854DD5A0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x54DDF90", Offset = "0x54DC590", VA = "0x1854DDF90", Slot = "12")]
	public void LJKNPIDDPEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x54DDE30", Offset = "0x54DC430", VA = "0x1854DDE30", Slot = "13")]
	public void KOEBKPOFGOP(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x54DD540", Offset = "0x54DBB40", VA = "0x1854DD540", Slot = "14")]
	public void DIAMOLMPOPF(OKOJNEBFOCP JEDGMEJHFGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x54DDFE0", Offset = "0x54DC5E0", VA = "0x1854DDFE0", Slot = "22")]
	public bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x54DE8D0", Offset = "0x54DCED0", VA = "0x1854DE8D0")]
	internal bool PELODFOECIP(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x54DDA50", Offset = "0x54DC050", VA = "0x1854DDA50")]
	internal bool IPLHCPIKMLE(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x54DD9F0", Offset = "0x54DBFF0", VA = "0x1854DD9F0")]
	internal bool HHCJMLAKDFP(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x54DD8B0", Offset = "0x54DBEB0", VA = "0x1854DD8B0")]
	internal bool HFNOCICBEHE(in DNCNIKEBCFI JIHCLPECHIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x54DDC50", Offset = "0x54DC250", VA = "0x1854DDC50")]
	internal void KNNNJEDJLJP(OKOJNEBFOCP JEDGMEJHFGK, int FHMNGDCHOLD, bool EHOIGELLJPC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x54DD540", Offset = "0x54DBB40", VA = "0x1854DD540")]
	internal bool GLHGAFNOFEJ(OKOJNEBFOCP MADBLMMGOPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x54DDB20", Offset = "0x54DC120", VA = "0x1854DDB20")]
	internal bool KDAEKHKDAFM(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x54DE130", Offset = "0x54DC730", VA = "0x1854DE130", Slot = "15")]
	public void NJIAHCMEIOK(OKOJNEBFOCP JEDGMEJHFGK, HashSet<OKOJNEBFOCP> INFCBDOCMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x54DD100", Offset = "0x54DB700", VA = "0x1854DD100", Slot = "16")]
	public void CGHCFBCONPF(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x54DDE50", Offset = "0x54DC450", VA = "0x1854DDE50")]
	public void LGPFCNGACPA(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x54DD6F0", Offset = "0x54DBCF0", VA = "0x1854DD6F0")]
	public void GALJJDMJFEJ(OKOJNEBFOCP MCIGJNMJJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x54DD310", Offset = "0x54DB910", VA = "0x1854DD310")]
	public void CGHCFBCONPF(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x54DDFF0", Offset = "0x54DC5F0", VA = "0x1854DDFF0", Slot = "17")]
	public void MFDADFOIKLM(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x54DCE90", Offset = "0x54DB490", VA = "0x1854DCE90", Slot = "18")]
	public void APCLKPGJCEA(OKOJNEBFOCP FENIHKAOGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x54DD6A0", Offset = "0x54DBCA0", VA = "0x1854DD6A0", Slot = "19")]
	public bool FNHCPJEHDGF(OKOJNEBFOCP JEDGMEJHFGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x54DE230", Offset = "0x54DC830", VA = "0x1854DE230")]
	public void NONMHFBMLKD([Optional] CJIONLFKLCG CKNDOEDFOCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x54DD4B0", Offset = "0x54DBAB0", VA = "0x1854DD4B0", Slot = "23")]
	public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x54DDB00", Offset = "0x54DC100", VA = "0x1854DDB00", Slot = "20")]
	public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x54DDAE0", Offset = "0x54DC0E0", VA = "0x1854DDAE0", Slot = "21")]
	public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x54DD7B0", Offset = "0x54DBDB0", VA = "0x1854DD7B0", Slot = "25")]
	public void GMGNCFOEAOG(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x54DD050", Offset = "0x54DB650", VA = "0x1854DD050", Slot = "24")]
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
	[Cpp2IlInjected.Address(RVA = "0x54DF770", Offset = "0x54DDD70", VA = "0x1854DF770")]
	public KLFMMPLFPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920")]
	public void OIEJOMHJJDA(HFBDMALPJBF HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x54DF710", Offset = "0x54DDD10", VA = "0x1854DF710")]
	public void OFMFKDMEJJO(OKOJNEBFOCP LFAIGCEGCPL, OKOJNEBFOCP IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x54DF630", Offset = "0x54DDC30", VA = "0x1854DF630")]
	public void DMKDBMJCDNE(OKOJNEBFOCP LFAIGCEGCPL, OKOJNEBFOCP IMDKOHMGEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x54DF690", Offset = "0x54DDC90", VA = "0x1854DF690")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public NOCIFNCPLBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x54E95D0", Offset = "0x54E7BD0", VA = "0x1854E95D0")]
	public void OIEJOMHJJDA(HFBDMALPJBF HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x54E9440", Offset = "0x54E7A40", VA = "0x1854E9440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x54E9320", Offset = "0x54E7920", VA = "0x1854E9320")]
	private void AGMHAHKPAMK(CJIONLFKLCG PAIIMNGOMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x54E9560", Offset = "0x54E7B60", VA = "0x1854E9560")]
	private void GEADGMGMOHG(CJIONLFKLCG MMDPCAIEINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x54E9340", Offset = "0x54E7940", VA = "0x1854E9340")]
	public void BPEIFCBCBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x54E9450", Offset = "0x54E7A50", VA = "0x1854E9450")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public GBOBONECECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x54DAF50", Offset = "0x54D9550", VA = "0x1854DAF50")]
		internal HFBDMALPJBF <BindServices>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x54D4830", Offset = "0x54D2E30", VA = "0x1854D4830")]
	public static void OKCGDBBMIAE(PEGEFOEHCCC IGFHDABHNLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x54D47B0", Offset = "0x54D2DB0", VA = "0x1854D47B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x54D3A10", Offset = "0x54D2010", VA = "0x1854D3A10")]
	public CPGBMACDCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x54D3440", Offset = "0x54D1A40", VA = "0x1854D3440", Slot = "7")]
	public void OIEJOMHJJDA(OFAAHBABBKD HOHEJAGNDDK, FLIFEJHGKGO GKHJOKGNPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x54D2EF0", Offset = "0x54D14F0", VA = "0x1854D2EF0", Slot = "5")]
	public void CLFNLAOPCHN(MMHEHNGHKHL OEHGOIINOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x54D32D0", Offset = "0x54D18D0", VA = "0x1854D32D0", Slot = "9")]
	public void NOGNNJFIDLG(MMHEHNGHKHL CFFOKEIIBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x54D3480", Offset = "0x54D1A80", VA = "0x1854D3480", Slot = "8")]
	public void ONOFHCMJGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x54D36F0", Offset = "0x54D1CF0", VA = "0x1854D36F0", Slot = "10")]
	public void PGFEINBGJPI(MMHEHNGHKHL IPMDKFFOGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x54D3630", Offset = "0x54D1C30", VA = "0x1854D3630", Slot = "11")]
	public void OOMHDACJDCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x54D3130", Offset = "0x54D1730", VA = "0x1854D3130")]
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
			[Cpp2IlInjected.Address(RVA = "0x54E9AF0", Offset = "0x54E80F0", VA = "0x1854E9AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x54EA280", Offset = "0x54E8880", VA = "0x1854EA280")]
		public OKAKKINGJGD(DKHGAALDMFL AFNICFHKIBD, HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC, [Optional] IPKEJDBNDEC IGDDCCKDHCG, [Optional] IPKEJDBNDEC ICHNNNFPMOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x54E9C00", Offset = "0x54E8200", VA = "0x1854E9C00")]
		public IPKEJDBNDEC HGEKGOKJCDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x54E9A30", Offset = "0x54E8030", VA = "0x1854E9A30")]
		private IPKEJDBNDEC FCKHNAHBLOG(out IPKEJDBNDEC JHHAKPKDDNE, out IPKEJDBNDEC LICGBFNIAKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x54E9D60", Offset = "0x54E8360", VA = "0x1854E9D60")]
		private IPKEJDBNDEC IHECFBPBFEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x54EA100", Offset = "0x54E8700", VA = "0x1854EA100")]
		private void OFIKEEJGAHH(IPKEJDBNDEC MLFDBJOGIFO, IPKEJDBNDEC GBAABBAEBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x54E9F60", Offset = "0x54E8560", VA = "0x1854E9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x54E3670", Offset = "0x54E1C70", VA = "0x1854E3670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool JKLONLNGCKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x54E23B0", Offset = "0x54E09B0", VA = "0x1854E23B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x54E4F50", Offset = "0x54E3550", VA = "0x1854E4F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x54E5510", Offset = "0x54E3B10", VA = "0x1854E5510")]
	public void OIEJOMHJJDA(HFBDMALPJBF HKMONJIHHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6A8920", Offset = "0x6A6F20", VA = "0x1806A8920", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x54E4730", Offset = "0x54E2D30", VA = "0x1854E4730")]
	public BMHGMDONJJK KANMMNCOFAC(bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x54E3F70", Offset = "0x54E2570", VA = "0x1854E3F70")]
	public BMHGMDONJJK JCICJMBAFOJ(HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x54E2BC0", Offset = "0x54E11C0", VA = "0x1854E2BC0")]
	public void CMIDOJEDPOK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x54E2560", Offset = "0x54E0B60", VA = "0x1854E2560")]
	public void BGILDJCJNOL(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x54E2B90", Offset = "0x54E1190", VA = "0x1854E2B90")]
	public void CHHGHIAELMK(BMHGMDONJJK HOHEJAGNDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x54E23D0", Offset = "0x54E09D0", VA = "0x1854E23D0")]
	private void BCAPODGCCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x54E3D00", Offset = "0x54E2300", VA = "0x1854E3D00")]
	private IPKEJDBNDEC GDFFIBDCAII(DKHGAALDMFL ELOCLFMIMAL, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x54E2910", Offset = "0x54E0F10", VA = "0x1854E2910")]
	private static void CGFDICLIABL(DKHGAALDMFL ELOCLFMIMAL, bool CJCAEDNHBOC, IPKEJDBNDEC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x54E2FA0", Offset = "0x54E15A0", VA = "0x1854E2FA0")]
	private void EFDPBPELAMD(DKHGAALDMFL ELOCLFMIMAL, bool CJCAEDNHBOC, IPKEJDBNDEC EOJBPKALALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x54E3EE0", Offset = "0x54E24E0", VA = "0x1854E3EE0")]
	private IPKEJDBNDEC HDODLOEHOMH(DKHGAALDMFL AFNICFHKIBD, HashSet<Guid> NPKNNHDIDHE, bool CJCAEDNHBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x54E31A0", Offset = "0x54E17A0", VA = "0x1854E31A0")]
	private bool EHMAIDHAFIA(BMHGMDONJJK DPOIAAJKCMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x54E36C0", Offset = "0x54E1CC0", VA = "0x1854E36C0")]
	private bool FEOEGBONOGC(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x54E5580", Offset = "0x54E3B80", VA = "0x1854E5580")]
	private bool PAAJIMKGNMK(BMHGMDONJJK HOHEJAGNDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x54E3420", Offset = "0x54E1A20", VA = "0x1854E3420")]
	private static bool EKABCGMOCFM(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x54E4F70", Offset = "0x54E3570", VA = "0x1854E4F70")]
	public static bool LPNKEOEDBND(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x54E2C50", Offset = "0x54E1250", VA = "0x1854E2C50")]
	private OKOJNEBFOCP DBJBMECPPCB(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x54E2780", Offset = "0x54E0D80", VA = "0x1854E2780")]
	private OKOJNEBFOCP CDAOLMNGKBP(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x54E2600", Offset = "0x54E0C00", VA = "0x1854E2600")]
	private OKOJNEBFOCP BLBIBFOGNCM(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x54E5230", Offset = "0x54E3830", VA = "0x1854E5230")]
	private static Guid MHBJBMODMBJ(IPKEJDBNDEC EOJBPKALALP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x54E3590", Offset = "0x54E1B90", VA = "0x1854E3590")]
	private string EOJABIALLKL(IPKEJDBNDEC EOJBPKALALP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x54E4DF0", Offset = "0x54E33F0", VA = "0x1854E4DF0")]
	private bool KLPIOPAFNHL(DKHGAALDMFL ELOCLFMIMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x54E5270", Offset = "0x54E3870", VA = "0x1854E5270")]
	private static void NPNJGHOKPEF(DKHGAALDMFL AFNICFHKIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x706620", Offset = "0x704C20", VA = "0x180706620", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OKOJNEBFOCP CNDFBIIJFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7EA8F0", Offset = "0x7E8EF0", VA = "0x1807EA8F0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x84E450", Offset = "0x84CA50", VA = "0x18084E450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Vector3 HONBKEOHFNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x54E7BC0", Offset = "0x54E61C0", VA = "0x1854E7BC0", Slot = "15")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FD1920", Offset = "0x1FCFF20", VA = "0x181FD1920")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Quaternion INJAKMAKCML
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x54E7E30", Offset = "0x54E6430", VA = "0x1854E7E30", Slot = "16")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x23CBBF0", Offset = "0x23CA1F0", VA = "0x1823CBBF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IANGGKLPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B27E0", Offset = "0x9B0DE0", VA = "0x1809B27E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x84E440", Offset = "0x84CA40", VA = "0x18084E440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool LMOIKHBNEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x54E82B0", Offset = "0x54E68B0", VA = "0x1854E82B0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OKOJNEBFOCP JJJHPDGFMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x744A80", Offset = "0x743080", VA = "0x180744A80", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x744B40", Offset = "0x743140", VA = "0x180744B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private bool KBGCGPFEIII
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x54E7FB0", Offset = "0x54E65B0", VA = "0x1854E7FB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private RigidbodyEx KPIIJANPMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x54E7DD0", Offset = "0x54E63D0", VA = "0x1854E7DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<OKOJNEBFOCP> IJIEGILBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x679E00", Offset = "0x678400", VA = "0x180679E00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GMIGCPFPLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x54E6B00", Offset = "0x54E5100", VA = "0x1854E6B00", Slot = "18")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x54E7940", Offset = "0x54E5F40", VA = "0x1854E7940", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Transform DACDPJCIAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x54E9300", Offset = "0x54E7900", VA = "0x1854E9300", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GameObject LPLGJEFNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public string FACJFEGFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x54E9070", Offset = "0x54E7670", VA = "0x1854E9070", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Guid DADEPEKMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x54E91D0", Offset = "0x54E77D0", VA = "0x1854E91D0", Slot = "37")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MBHJFOLEHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x54E92B0", Offset = "0x54E78B0", VA = "0x1854E92B0", Slot = "38")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NIALADIPDNC CDCHGJINIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x54E90C0", Offset = "0x54E76C0", VA = "0x1854E90C0", Slot = "39")]
		get
		{
			return default(NIALADIPDNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DKKKOJNAOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x677260", Offset = "0x675860", VA = "0x180677260", Slot = "40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event MNDJHOAPIBF MACPKEBHOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x54E7A00", Offset = "0x54E6000", VA = "0x1854E7A00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x54E6A60", Offset = "0x54E5060", VA = "0x1854E6A60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event MNDJHOAPIBF MOPDNAHNMAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x54E8020", Offset = "0x54E6620", VA = "0x1854E8020", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x54E69C0", Offset = "0x54E4FC0", VA = "0x1854E69C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event MNDJHOAPIBF PBEFKDLNBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x54E71F0", Offset = "0x54E57F0", VA = "0x1854E71F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x54E6340", Offset = "0x54E4940", VA = "0x1854E6340", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event PLNJGDCELKP FCPIJPKBGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x54E5C80", Offset = "0x54E4280", VA = "0x1854E5C80", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x54E7EA0", Offset = "0x54E64A0", VA = "0x1854E7EA0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x54E78E0", Offset = "0x54E5EE0", VA = "0x1854E78E0")]
	private RigidbodyEx HEKLNEIOEDG(OKOJNEBFOCP FFMNGIOPDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x54E8F80", Offset = "0x54E7580", VA = "0x1854E8F80")]
	public NDBLCDOFLCB(GameObject EHEABJNEALG, LHMBBJKNPDI FFMNGIOPDCC, LNPKCEGMEFM[] OLAEKPIDBOB, ECCOODIKAKJ NBJJAAKBODP, IHBAODPGPGM DHJAKBDIMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x54E80C0", Offset = "0x54E66C0", VA = "0x1854E80C0", Slot = "20")]
	public void NOMIHBFFLNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x54E6F40", Offset = "0x54E5540", VA = "0x1854E6F40", Slot = "22")]
	public void GFHALMIKJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x54E7AA0", Offset = "0x54E60A0", VA = "0x1854E7AA0", Slot = "23")]
	public void JFHFEDABDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x54E82C0", Offset = "0x54E68C0", VA = "0x1854E82C0", Slot = "21")]
	public void PMIJFIGEABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x54E6FA0", Offset = "0x54E55A0", VA = "0x1854E6FA0")]
	private void GGEFIKNKMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x54E5D20", Offset = "0x54E4320", VA = "0x1854E5D20")]
	private void BONBJGNPNEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x54E63E0", Offset = "0x54E49E0", VA = "0x1854E63E0", Slot = "24")]
	public void DJIACPONHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x54E8000", Offset = "0x54E6600", VA = "0x1854E8000", Slot = "25")]
	public void NHCBKIIPOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x54E6400", Offset = "0x54E4A00", VA = "0x1854E6400", Slot = "26")]
	public void EFEKJOBOGCE(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x54E7150", Offset = "0x54E5750", VA = "0x1854E7150", Slot = "27")]
	public void GHDBODICNOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x54E6670", Offset = "0x54E4C70", VA = "0x1854E6670", Slot = "28")]
	public void EIJNJFKEGHA(int EBNBMBEOMKP, OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, [Optional] Vector3? GDILIOHLNNI, [Optional] Quaternion? HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x54E7B20", Offset = "0x54E6120", VA = "0x1854E7B20", Slot = "29")]
	public void JKECLMBIAPM(OKOJNEBFOCP FIGBCGFFKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x54E6B50", Offset = "0x54E5150", VA = "0x1854E6B50")]
	private void GAIKGICPHFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x54E7C30", Offset = "0x54E6230", VA = "0x1854E7C30", Slot = "31")]
	public void KMFFIGCDCMN(int EBBLFLFCHFB, Vector3 EOJNMKIFHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x54E7290", Offset = "0x54E5890", VA = "0x1854E7290", Slot = "32")]
	public void GOGFEIDLBDA(Vector3 BECIPDCMBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x54E55A0", Offset = "0x54E3BA0", VA = "0x1854E55A0", Slot = "30")]
	public void BCADEKFLALJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x54E7810", Offset = "0x54E5E10", VA = "0x1854E7810", Slot = "42")]
	public Vector3 GetConnectionSlotPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x54E76D0", Offset = "0x54E5CD0", VA = "0x1854E76D0", Slot = "41")]
	public Vector3 GetConnectionSlotLocalPosition(int EBNBMBEOMKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x25BBCF0", Offset = "0x25BA2F0", VA = "0x1825BBCF0", Slot = "43")]
	public Color GetConnectionSlotColor(int EBNBMBEOMKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x54E5ED0", Offset = "0x54E44D0", VA = "0x1854E5ED0", Slot = "44")]
	public bool CanConnectTo(int EBNBMBEOMKP, OKOJNEBFOCP NCFHOBEDKHL, int BCBMLFMIALA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x54E8210", Offset = "0x54E6810", VA = "0x1854E8210")]
	public bool PEGCDPIHGIH(OKOJNEBFOCP OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x54E8350", Offset = "0x54E6950", VA = "0x1854E8350", Slot = "45")]
	public void ParentChanged(int EBNBMBEOMKP, OKOJNEBFOCP DHBEDIHFIAN, int KOJFFNPKENB, Vector3 DMDBIJHOHIJ, Quaternion PJDANGLLKLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x54E5F70", Offset = "0x54E4570", VA = "0x1854E5F70", Slot = "46")]
	public void ChildAdded(int EBNBMBEOMKP, OKOJNEBFOCP CPJKMEIJGID, int NLFIDJLEDPC, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x54E6120", Offset = "0x54E4720", VA = "0x1854E6120", Slot = "47")]
	public void ChildRemoved(int EBNBMBEOMKP, OKOJNEBFOCP HGIPAGJIMDK, int DKIHCBGOPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x54E61E0", Offset = "0x54E47E0", VA = "0x1854E61E0", Slot = "48")]
	public void ConnectionModified(int EBNBMBEOMKP, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x54E8F20", Offset = "0x54E7520", VA = "0x1854E8F20", Slot = "49")]
	public void RootChanged(OKOJNEBFOCP OKAGMHACBGC, OKOJNEBFOCP DEGGONGNNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x54E7F40", Offset = "0x54E6540", VA = "0x1854E7F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x54DA800", Offset = "0x54D8E00", VA = "0x1854DA800")]
		get
		{
			return default(FLFPBJIEAPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public FLFPBJIEAPK DEFCOEMOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x54DA8A0", Offset = "0x54D8EA0", VA = "0x1854DA8A0")]
		get
		{
			return default(FLFPBJIEAPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x54DA910", Offset = "0x54D8F10", VA = "0x1854DA910")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
		public LNHMKKPONJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x54DF910", Offset = "0x54DDF10", VA = "0x1854DF910")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C33AF0", Offset = "0x3C320F0", VA = "0x183C33AF0", Slot = "16")]
		get
		{
			return default(FLFPBJIEAPK);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x54DA100", Offset = "0x54D8700", VA = "0x1854DA100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private DKHGAALDMFL LFAIGCEGCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x54D9950", Offset = "0x54D7F50", VA = "0x1854D9950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public MMHEHNGHKHL HDIMMFJBNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x694B00", Offset = "0x693100", VA = "0x180694B00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public OKOJNEBFOCP NOACAMDIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6BA620", Offset = "0x6B8C20", VA = "0x1806BA620", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x71E880", Offset = "0x71CE80", VA = "0x18071E880", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public int BJCALIGFKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6BA600", Offset = "0x6B8C00", VA = "0x1806BA600", Slot = "6")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6BA610", Offset = "0x6B8C10", VA = "0x1806BA610", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int JHMKKLIJODB
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x83C6A0", Offset = "0x83ACA0", VA = "0x18083C6A0", Slot = "8")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x83C690", Offset = "0x83AC90", VA = "0x18083C690", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 NJNDKGHCJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x22B7950", Offset = "0x22B5F50", VA = "0x1822B7950", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x22B7970", Offset = "0x22B5F70", VA = "0x1822B7970", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Quaternion MAIIAOAIBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x15AEDF0", Offset = "0x15AD3F0", VA = "0x1815AEDF0", Slot = "12")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x15AEE40", Offset = "0x15AD440", VA = "0x1815AEE40", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool DHFEEDJEGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x110F3A0", Offset = "0x110D9A0", VA = "0x18110F3A0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool GAKPFGOKFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x54D9730", Offset = "0x54D7D30", VA = "0x1854D9730", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	protected DKHGAALDMFL COMPFMNMPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x54D9BB0", Offset = "0x54D81B0", VA = "0x1854D9BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MMHEHNGHKHL AMKPOIHFDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x54D9BB0", Offset = "0x54D81B0", VA = "0x1854D9BB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x54DA5C0", Offset = "0x54D8BC0", VA = "0x1854DA5C0")]
	public DKHGAALDMFL(FLFPBJIEAPK MILJEHDAFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x54DA1E0", Offset = "0x54D87E0", VA = "0x1854DA1E0")]
	public DKHGAALDMFL OPJJCFHECII(FLFPBJIEAPK LJDBDONGGEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x54D9A30", Offset = "0x54D8030", VA = "0x1854D9A30")]
	public DKHGAALDMFL ILDGPHJKKOK(FLFPBJIEAPK FCCMFDFBMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x54D9780", Offset = "0x54D7D80", VA = "0x1854D9780")]
	public DKHGAALDMFL EMIFMEAGDDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x54DA320", Offset = "0x54D8920", VA = "0x1854DA320")]
	public void PGHHBKOCHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x54DA130", Offset = "0x54D8730", VA = "0x1854DA130")]
	public DKHGAALDMFL MCJNECDJBOA(FLFPBJIEAPK EBIGGMLCEAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x54DA470", Offset = "0x54D8A70", VA = "0x1854DA470")]
	private static void PGIMMCFLBOJ(DKHGAALDMFL PCMPADLEGBP, MEDCGBEMCOB OECIEBPBJFM, bool NAEEAKOGBDO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x54DA460", Offset = "0x54D8A60", VA = "0x1854DA460", Slot = "19")]
	public void PGIMMCFLBOJ(MEDCGBEMCOB ONHFNOPIIKL, bool NPBOCMDCJPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x54D9BD0", Offset = "0x54D81D0", VA = "0x1854D9BD0")]
	public static string KABCHDDLAJE(DKHGAALDMFL PCMPADLEGBP, int IFJOKNDLBML = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x54DA0D0", Offset = "0x54D86D0", VA = "0x1854DA0D0", Slot = "20")]
	public MMHEHNGHKHL KCDNLPOEHHI(FLFPBJIEAPK JJHBJCHAHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x54D9FC0", Offset = "0x54D85C0", VA = "0x1854D9FC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x54E0FE0", Offset = "0x54DF5E0", VA = "0x1854E0FE0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool CKJBFOGMGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x54E1040", Offset = "0x54DF640", VA = "0x1854E1040", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<CJIONLFKLCG> AGMHAHKPAMK
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x54E0F40", Offset = "0x54DF540", VA = "0x1854E0F40", Slot = "16")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x54E1130", Offset = "0x54DF730", VA = "0x1854E1130", Slot = "17")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<CJIONLFKLCG> GEADGMGMOHG
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x54E0EA0", Offset = "0x54DF4A0", VA = "0x1854E0EA0", Slot = "18")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x54E1090", Offset = "0x54DF690", VA = "0x1854E1090", Slot = "19")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x731D00", Offset = "0x730300", VA = "0x180731D00", Slot = "22")]
		public void SetManager(HFBDMALPJBF HKMONJIHHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x54E0E70", Offset = "0x54DF470", VA = "0x1854E0E70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x54DFB70", Offset = "0x54DE170", VA = "0x1854DFB70", Slot = "23")]
		public void RequestMasterConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x54DFCA0", Offset = "0x54DE2A0", VA = "0x1854DFCA0", Slot = "24")]
		public void RequestMasterDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x54DFD70", Offset = "0x54DE370", VA = "0x1854DFD70", Slot = "25")]
		public void RequestMasterModifyNode(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x54DFEA0", Offset = "0x54DE4A0", VA = "0x1854DFEA0", Slot = "26")]
		public void RequestMasterReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x54DFFD0", Offset = "0x54DE5D0", VA = "0x1854DFFD0", Slot = "27")]
		public void RequestMasterReparentToRoot(OKOJNEBFOCP FENIHKAOGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x54DFA40", Offset = "0x54DE040", VA = "0x1854DFA40", Slot = "28")]
		public void RequestDeserializeConnectableGraph(BMHGMDONJJK FCBBNEOJGMK, [Optional] CJIONLFKLCG CKNDOEDFOCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x54E03C0", Offset = "0x54DE9C0", VA = "0x1854E03C0")]
		[MNIDOGALBOE]
		private void RpcMasterConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x54E0690", Offset = "0x54DEC90", VA = "0x1854E0690")]
		[MNIDOGALBOE]
		private void RpcMasterDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x54E09F0", Offset = "0x54DEFF0", VA = "0x1854E09F0")]
		[MNIDOGALBOE]
		private void RpcMasterReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x54E07E0", Offset = "0x54DEDE0", VA = "0x1854E07E0")]
		[MNIDOGALBOE]
		private void RpcMasterModifyNode(OKOJNEBFOCP MIDPMAJHMNG, OKOJNEBFOCP PNLBBPCBPJE, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x54E01A0", Offset = "0x54DE7A0", VA = "0x1854E01A0")]
		[MNIDOGALBOE]
		private void RpcConnectNodes(OKOJNEBFOCP FIGBCGFFKBJ, int AAJBCEMEGHA, OKOJNEBFOCP IDDEHLJHNOC, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x54E0330", Offset = "0x54DE930", VA = "0x1854E0330")]
		[MNIDOGALBOE]
		private void RpcDisconnectNode(OKOJNEBFOCP MCIGJNMJJIG, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x54E0D60", Offset = "0x54DF360", VA = "0x1854E0D60")]
		[MNIDOGALBOE]
		private void RpcReparentNodes(OKOJNEBFOCP FENIHKAOGCI, int DFJJFGGOJMC, OKOJNEBFOCP EBIGGMLCEAF, int KOJFFNPKENB, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x54E0C90", Offset = "0x54DF290", VA = "0x1854E0C90")]
		[MNIDOGALBOE]
		private void RpcModifyNode(OKOJNEBFOCP MIDPMAJHMNG, int AAJBCEMEGHA, int EBNEMFKPDBH, Vector3 GDILIOHLNNI, Quaternion HIMAIGGLOGC, KBNDJNJPHBN LCEDEIOBEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x54E02F0", Offset = "0x54DE8F0", VA = "0x1854E02F0")]
		[MNIDOGALBOE]
		private void RpcDeserializeConnectableGraph(BMHGMDONJJK HOHEJAGNDDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xF9CD30", Offset = "0xF9B330", VA = "0x180F9CD30")]
		public LegacyConnectableNetworking()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class OEGLGAKMBDK
{
	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x409A120", Offset = "0x4098720", VA = "0x18409A120")]
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
	[Cpp2IlInjected.Address(RVA = "0x54DA730", Offset = "0x54D8D30", VA = "0x1854DA730")]
	public DLFGEGDFLBL(GMODMBJNKFK JOOJGLPIMBB, string AIGAKEKDKHM, bool BKMGNMEJDHA, CHJIMJFFBGO LMCDHLMJNAF, [Optional] Action ONHFNOPIIKL, [Optional] LBJJDFCIAGJ COAKGGNKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x54DA660", Offset = "0x54D8C60", VA = "0x1854DA660", Slot = "4")]
	public bool DNJGGIFCOKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x54DA6D0", Offset = "0x54D8CD0", VA = "0x1854DA6D0", Slot = "5")]
	public void KMNEKDAGPNL(bool MAKFNMHIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x54DA6B0", Offset = "0x54D8CB0", VA = "0x1854DA6B0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x750020", Offset = "0x74E620", VA = "0x180750020")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x54EFF70", Offset = "0x54EE570", VA = "0x1854EFF70", Slot = "6")]
		public sealed override void FHBOKNJGNHA(JGIPCDLBHLE ONHFNOPIIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x54F00F0", Offset = "0x54EE6F0", VA = "0x1854F00F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
	public MDBMMECDLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x54E1520", Offset = "0x54DFB20", VA = "0x1854E1520")]
	private static string LLKJKMBGMPE(byte[] LKLEFAIICIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x54E11D0", Offset = "0x54DF7D0", VA = "0x1854E11D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A82D0", Offset = "0x6A68D0", VA = "0x1806A82D0")]
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
