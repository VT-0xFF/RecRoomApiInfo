using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x77483D0", Offset = "0x77477D0", VA = "0x1877483D0", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x774DEC0", Offset = "0x774D2C0", VA = "0x18774DEC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x774D8A0", Offset = "0x774CCA0", VA = "0x18774D8A0")]
		private void LBKELEMAONI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x774DA10", Offset = "0x774CE10", VA = "0x18774DA10")]
		private void OCLIAJDDJMI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x774DB80", Offset = "0x774CF80", VA = "0x18774DB80", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x774DF00", Offset = "0x774D300", VA = "0x18774DF00")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class AMEKCMIPPNJ : BMBNOGPPDPH, AOPBNJCLOCO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EGIEHOBEPID : IEnumerable<KKNCCCEMNOG>, IEnumerable, IEnumerator<KKNCCCEMNOG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private KKNCCCEMNOG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PMMHELJLBHE localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PMMHELJLBHE <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AMEKCMIPPNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private IKEEOMDEEKE <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LIMNPKPCKCA <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private LIMNPKPCKCA.IOHAIJPDOOF <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private KKNCCCEMNOG System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDDEBA0", Offset = "0xDDDFA0", VA = "0x180DDEBA0")]
		[DebuggerHidden]
		public EGIEHOBEPID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7740520", Offset = "0x773F920", VA = "0x187740520", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x77400C0", Offset = "0x773F4C0", VA = "0x1877400C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77400A0", Offset = "0x773F4A0", VA = "0x1877400A0")]
		private void KNMHCFDKFOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7740080", Offset = "0x773F480", VA = "0x187740080")]
		private void CHDBNOFNPHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77404D0", Offset = "0x773F8D0", VA = "0x1877404D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7740420", Offset = "0x773F820", VA = "0x187740420", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<KKNCCCEMNOG> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7740420", Offset = "0x773F820", VA = "0x187740420", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JBALAMFNJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AMEKCMIPPNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JHKBPFFCGFI nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public JBALAMFNJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7745A20", Offset = "0x7744E20", VA = "0x187745A20")]
		internal object CIJNFDEMHGF(JHKBPFFCGFI x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DNPGIAHDAJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JHKBPFFCGFI child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public JBALAMFNJAM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DNPGIAHDAJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x773F090", Offset = "0x773E490", VA = "0x18773F090")]
		internal object AOBDBEOBGMG((JHKBPFFCGFI child, JHKBPFFCGFI nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly ABDDJEPKCOD CMEIKJMKCKJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly ABDDJEPKCOD PKBNKPFJOCC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly ABDDJEPKCOD OELBGEABCII;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly ABDDJEPKCOD MPIOKMHLPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private OKGILCANLGB CEKIKEFBKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BPJLABPLMDN PANHPCJJMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private GGPNACIJLGA PAIMEDMADND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private PFFCDNFCAMM MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private DAOJAABEEPG HFBBADPBDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BFCKDANBBPP OOCDOIMOCDA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB3E920", Offset = "0xB3DD20", VA = "0x180B3E920", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB3DF90", Offset = "0xB3D390", VA = "0x180B3DF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OKBCHGLIFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG> EPHKHEIEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x773BEA0", Offset = "0x773B2A0", VA = "0x18773BEA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x773B9E0", Offset = "0x773ADE0", VA = "0x18773B9E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG> FLNKGOFLDKN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x773BDA0", Offset = "0x773B1A0", VA = "0x18773BDA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x773D880", Offset = "0x773CC80", VA = "0x18773D880", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG, KKNCCCEMNOG> JBPPFBAINPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x773CBE0", Offset = "0x773BFE0", VA = "0x18773CBE0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x773C330", Offset = "0x773B730", VA = "0x18773C330", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x773E820", Offset = "0x773DC20", VA = "0x18773E820")]
	public AMEKCMIPPNJ(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x773D080", Offset = "0x773C480", VA = "0x18773D080", Slot = "12")]
	public void MBHBIOMKKEG(GameObject MKMGIAEJNDJ, NGDOBHIMKJK NIIKKCABFNL, NNDNOOKBAAE BAFEKABAJGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x773BF50", Offset = "0x773B350", VA = "0x18773BF50", Slot = "26")]
	public void GBFOCOOFFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x773BE50", Offset = "0x773B250", VA = "0x18773BE50", Slot = "22")]
	public bool FNKJPPDCPHJ(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x773A790", Offset = "0x7739B90", VA = "0x18773A790")]
	private void CFACOLNOAGB(PMMHELJLBHE OOGHJIBAIJJ, PMMHELJLBHE LIFDAHDCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x773E4B0", Offset = "0x773D8B0", VA = "0x18773E4B0")]
	private void PJMMJMFECCO(PMMHELJLBHE OOGHJIBAIJJ, PMMHELJLBHE NNKHMHOBGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x773CE20", Offset = "0x773C220", VA = "0x18773CE20")]
	private void LOFGHLHBKAA(PMMHELJLBHE OOGHJIBAIJJ, PMMHELJLBHE NNKHMHOBGKM, PMMHELJLBHE LIFDAHDCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7739E40", Offset = "0x7739240", VA = "0x187739E40")]
	private void AGCNBJEPLOO(PMMHELJLBHE OOGHJIBAIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "13")]
	public void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x773BA90", Offset = "0x773AE90", VA = "0x18773BA90", Slot = "14")]
	public void ELBDPICAHPN(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "15")]
	public void FMMHPGGGKFG(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x773E210", Offset = "0x773D610", VA = "0x18773E210", Slot = "17")]
	public void PGNKCECHOPI(KKNCCCEMNOG HEOGBODIMIF, KKNCCCEMNOG OCOMBLKBHGN, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x773E370", Offset = "0x773D770", VA = "0x18773E370")]
	public void PGNKCECHOPI(PMMHELJLBHE KIGPNOGAENI, PMMHELJLBHE OCOMBLKBHGN, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x773B950", Offset = "0x773AD50", VA = "0x18773B950")]
	public void EJBNBOOGFAC(KKNCCCEMNOG HEOGBODIMIF, float KDIMAMFLKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x773C5D0", Offset = "0x773B9D0", VA = "0x18773C5D0", Slot = "18")]
	public void JFAPNEBJOJA(KKNCCCEMNOG LNDJNOGCFFI, int OHPIAEEEPMF, KKNCCCEMNOG GKDLIMGFOBG, int GFCMMIPDDLN, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x773B8A0", Offset = "0x773ACA0", VA = "0x18773B8A0")]
	private float EGIKEHNDGGP(PMMHELJLBHE KIGPNOGAENI, PMMHELJLBHE PBIFOHNGFLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x773C730", Offset = "0x773BB30", VA = "0x18773C730")]
	public void JFAPNEBJOJA(PMMHELJLBHE KIGPNOGAENI, PMMHELJLBHE PBIFOHNGFLL, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, bool EMICADJMLNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x773D930", Offset = "0x773CD30", VA = "0x18773D930", Slot = "19")]
	public void NHPBBOCFMFF(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x773A290", Offset = "0x7739690", VA = "0x18773A290", Slot = "16")]
	public void ALJOAIBDGHO(KKNCCCEMNOG HEOGBODIMIF, HashSet<KKNCCCEMNOG> BLFINHBKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "20")]
	public BOIIODNOJMF JLLKFOCBCLJ(bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "21")]
	public BOIIODNOJMF AFLPBDMMJBI(HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x773C3E0", Offset = "0x773B7E0", VA = "0x18773C3E0", Slot = "23")]
	public void ICOIMOIBOCK(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x773A720", Offset = "0x7739B20", VA = "0x18773A720", Slot = "24")]
	public void CEIGIBJOPJL(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x773B3B0", Offset = "0x773A7B0", VA = "0x18773B3B0", Slot = "25")]
	public void DNIPNFFDIID(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x773C870", Offset = "0x773BC70", VA = "0x18773C870")]
	private void JPIBNLMEKOH(PMMHELJLBHE KIGPNOGAENI, PMMHELJLBHE PBIFOHNGFLL, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI, float KDIMAMFLKGH, bool EMICADJMLNJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x773AA90", Offset = "0x7739E90", VA = "0x18773AA90")]
	private void DDBCNMGOAJA(PMMHELJLBHE KIGPNOGAENI, PMMHELJLBHE DPOGHMAJNAL, Vector3 PFOFJFECKOD, Quaternion HKMKFJAMILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x773C560", Offset = "0x773B960", VA = "0x18773C560")]
	private void JDPDCCEFOHG(PMMHELJLBHE KIGPNOGAENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x773A4A0", Offset = "0x77398A0", VA = "0x18773A4A0")]
	[IteratorStateMachine(typeof(EGIEHOBEPID))]
	public IEnumerable<KKNCCCEMNOG> AMCFNEGMHDF(PMMHELJLBHE MBPEAJOCCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x773B3D0", Offset = "0x773A7D0", VA = "0x18773B3D0")]
	internal KKNCCCEMNOG DOMAEABGGCE(PMMHELJLBHE MBPEAJOCCID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x773CC90", Offset = "0x773C090", VA = "0x18773CC90")]
	internal PMMHELJLBHE LJKAABFJMCD(KKNCCCEMNOG HEOGBODIMIF)
	{
		return default(PMMHELJLBHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x773D2F0", Offset = "0x773C6F0", VA = "0x18773D2F0")]
	private bool MFMLPCBCOKF(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x773C140", Offset = "0x773B540", VA = "0x18773C140")]
	private bool HAJIAGLHAJA(JHKBPFFCGFI DBBKCMNDDPN, [Out] KKNCCCEMNOG PBIFOHNGFLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x773B510", Offset = "0x773A910", VA = "0x18773B510")]
	private KKNCCCEMNOG DOMAEABGGCE(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x773A530", Offset = "0x7739930", VA = "0x18773A530")]
	private KKNCCCEMNOG BLMHMBLNINP(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x773E040", Offset = "0x773D440", VA = "0x18773E040")]
	private KKNCCCEMNOG PFNPKDNOKDM(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x773A250", Offset = "0x7739650", VA = "0x18773A250")]
	private static Guid ALDOMLACLCB(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x773A9A0", Offset = "0x7739DA0", VA = "0x18773A9A0")]
	private string CNHJJPMPGNE(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x773DAA0", Offset = "0x773CEA0", VA = "0x18773DAA0")]
	private void NLENIPMLHJL(KKNCCCEMNOG KIGPNOGAENI, KKNCCCEMNOG DPOGHMAJNAL, RigidTransform GBOPGIHMHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x773DEB0", Offset = "0x773D2B0", VA = "0x18773DEB0")]
	private void OGJBJCILBOO(KKNCCCEMNOG DPOGHMAJNAL, KKNCCCEMNOG KIGPNOGAENI, RigidTransform GBOPGIHMHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x773A6C0", Offset = "0x7739AC0", VA = "0x18773A6C0")]
	private void BMAAAJDGANJ(KKNCCCEMNOG GJHMCJPCNJC, KKNCCCEMNOG KIGPNOGAENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x773C1A0", Offset = "0x773B5A0", VA = "0x18773C1A0")]
	private void HJKLAGHJICG(KKNCCCEMNOG KIGPNOGAENI, KKNCCCEMNOG PBIFOHNGFLL, RigidTransform GBOPGIHMHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x773C450", Offset = "0x773B850", VA = "0x18773C450")]
	private void JBMNFHJJFEG(PMMHELJLBHE MBPEAJOCCID, KKNCCCEMNOG HEOGBODIMIF, PMMHELJLBHE NNKHMHOBGKM, PMMHELJLBHE LIFDAHDCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x773DC30", Offset = "0x773D030", VA = "0x18773DC30")]
	private void NNPCMFGGPMO(PMMHELJLBHE MBPEAJOCCID, KKNCCCEMNOG HEOGBODIMIF, KKNCCCEMNOG DFJCJGGBHDF, KKNCCCEMNOG IMHLCBJKIGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class FGFPPMCFNJN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OINBEFDOMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NPIEGGOELNH container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public OINBEFDOMLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x774D4A0", Offset = "0x774C8A0", VA = "0x18774D4A0")]
		internal AMEKCMIPPNJ KLIOPKLICFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7740600", Offset = "0x773FA00", VA = "0x187740600")]
	public static void GOKIHGAMJJL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7740780", Offset = "0x773FB80", VA = "0x187740780")]
	public static void HOILNKLIMCL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KGJJJCPDKPA : MEHHNOCDBMD, JNKNHBPCKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx GFMEDDDNANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly AMEKCMIPPNJ IPFIENPMHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HEIDPOKJENB CMDDOLDEIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly AMDHOAEAHIF MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LPHLAAOFGLP[] MPLEJGLAPGN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PMMHELJLBHE GCAGKJECMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(PMMHELJLBHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KKNCCCEMNOG ODALBGEBIIH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7747660", Offset = "0x7746A60", VA = "0x187747660", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KKNCCCEMNOG GCCKNGEEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7745C60", Offset = "0x7745060", VA = "0x187745C60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 OMCNNKAKHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7746730", Offset = "0x7745B30", VA = "0x187746730", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion PHJCEIJCBIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7745A90", Offset = "0x7744E90", VA = "0x187745A90", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MLGPLLPIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7746370", Offset = "0x7745770", VA = "0x187746370", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<KKNCCCEMNOG> HONLDEKNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7746FE0", Offset = "0x77463E0", VA = "0x187746FE0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool PEBJCIAGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB54C40", Offset = "0xB54040", VA = "0x180B54C40", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBA19A0", Offset = "0xBA0DA0", VA = "0x180BA19A0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7747870", Offset = "0x7746C70", VA = "0x187747870", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject JAHMEOIAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2C8A350", Offset = "0x2C89750", VA = "0x182C8A350", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7747590", Offset = "0x7746990", VA = "0x187747590", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid DDNICLNLEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77476C0", Offset = "0x7746AC0", VA = "0x1877476C0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PCPKFEEFEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x77477A0", Offset = "0x7746BA0", VA = "0x1877477A0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PGMDFNOPCPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool OBFJIPMBMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7746430", Offset = "0x7745830", VA = "0x187746430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MPFABJLDDKO HKHLCDFFDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x77466D0", Offset = "0x7745AD0", VA = "0x1877466D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7746E80", Offset = "0x7746280", VA = "0x187746E80", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MPFABJLDDKO AGECICJNONJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7745D20", Offset = "0x7745120", VA = "0x187745D20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7746EE0", Offset = "0x77462E0", VA = "0x187746EE0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MPFABJLDDKO HJDAOKMBJOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7745E00", Offset = "0x7745200", VA = "0x187745E00", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7747010", Offset = "0x7746410", VA = "0x187747010", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JDNADPJDEEP BPFADEGINDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7746F40", Offset = "0x7746340", VA = "0x187746F40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7745AF0", Offset = "0x7744EF0", VA = "0x187745AF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7747490", Offset = "0x7746890", VA = "0x187747490")]
	public KGJJJCPDKPA(PMMHELJLBHE NFJLMELBBOO, RigidbodyEx GFMEDDDNANC, HEIDPOKJENB CMDDOLDEIHP, LPHLAAOFGLP[] MPLEJGLAPGN, AMDHOAEAHIF MFCHJJKNFDE, BMBNOGPPDPH IPFIENPMHKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7745B90", Offset = "0x7744F90", VA = "0x187745B90", Slot = "19")]
	public void CBNFMMEJBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "21")]
	public void FKMHJDDEKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74F1810", Offset = "0x74F0C10", VA = "0x1874F1810", Slot = "22")]
	public void OGGDBKDPEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7747350", Offset = "0x7746750", VA = "0x187747350", Slot = "20")]
	public void OJDEIJAKKMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7747070", Offset = "0x7746470", VA = "0x187747070", Slot = "25")]
	public void OBCNPGAOIBD(int KALOBJNNMEK, KKNCCCEMNOG GKDLIMGFOBG, int KFPNFJLGLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7747280", Offset = "0x7746680", VA = "0x187747280", Slot = "26")]
	public void OBMMLMIPLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7746790", Offset = "0x7745B90", VA = "0x187746790", Slot = "27")]
	public void KBHMNJDBLJO(int KALOBJNNMEK, KKNCCCEMNOG LNDJNOGCFFI, int CNAHANKPAGM, [Optional] Vector3? IJIFEJOGMGA, [Optional] Quaternion? BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7745D80", Offset = "0x7745180", VA = "0x187745D80", Slot = "28")]
	public void FGIIPOEAAKD(KKNCCCEMNOG LNDJNOGCFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7746A70", Offset = "0x7745E70", VA = "0x187746A70", Slot = "31")]
	public void LDBDCEFDEMC(Vector3 FFDNKLLODHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7746060", Offset = "0x7745460", VA = "0x187746060", Slot = "29")]
	public void HGDNHDDGJGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7746480", Offset = "0x7745880", VA = "0x187746480", Slot = "30")]
	public void IIJEGHDGDIL(int KDCAMOIGIMA, Vector3 FPPHNHEFIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7745F90", Offset = "0x7745390", VA = "0x187745F90", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int KALOBJNNMEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7745E60", Offset = "0x7745260", VA = "0x187745E60", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int KALOBJNNMEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB32790", Offset = "0xB31B90", VA = "0x180B32790", Slot = "42")]
	public Color GetConnectionSlotColor(int KALOBJNNMEK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7745BC0", Offset = "0x7744FC0", VA = "0x187745BC0", Slot = "43")]
	public bool CanConnectTo(int KALOBJNNMEK, KKNCCCEMNOG FMIGMJPEJDF, int BIMNMAELMOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "44")]
	public void ParentChanged(int KALOBJNNMEK, KKNCCCEMNOG IGPPAFDHJPB, int OAMJKLFFHGN, Vector3 BLBPOKFPLPI, Quaternion FIKDNIICMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "45")]
	public void ChildAdded(int KALOBJNNMEK, KKNCCCEMNOG GAHFFEBCDCO, int NMGOLLIJMJM, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "46")]
	public void ChildRemoved(int KALOBJNNMEK, KKNCCCEMNOG DJDPNFBAGGC, int HIMFLKJIBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "47")]
	public void ConnectionModified(int KALOBJNNMEK, KKNCCCEMNOG GKDLIMGFOBG, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x77473F0", Offset = "0x77467F0", VA = "0x1877473F0", Slot = "48")]
	public void RootChanged(KKNCCCEMNOG GENNCHICFDN, KKNCCCEMNOG BKCMGFPIHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x77463E0", Offset = "0x77457E0", VA = "0x1877463E0", Slot = "23")]
	public void IHGJOHEPKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7746680", Offset = "0x7745A80", VA = "0x187746680", Slot = "24")]
	public void JFHDOMIFBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x77473A0", Offset = "0x77467A0", VA = "0x1877473A0")]
	private void ONHFHINPFJJ(bool DHFIFEEKCMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(NLBDEMKGHJN), new string[] { })]
public class MKPICGEOHNC : NLBDEMKGHJN, HNDDMAHOBCN, AMKGLADJPMK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class IPOKBOCDLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IPOKBOCDLJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private PLHNNKHPMOC CLKKBOEEKDJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object EIHKFPDHEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x774A6B0", Offset = "0x7749AB0", VA = "0x18774A6B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x774A660", Offset = "0x7749A60", VA = "0x18774A660", Slot = "5")]
	private void GBNLIKPCGPH(INNCJKBLPNO OOCDOIMOCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x104C660", Offset = "0x104BA60", VA = "0x18104C660", Slot = "6")]
	private void IKBMCJJKAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public MKPICGEOHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(BMBNOGPPDPH), new string[] { "Ignore", "Mock" })]
public class NMNAKJLNCEM : BMBNOGPPDPH, AOPBNJCLOCO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OKBCHGLIFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG> EPHKHEIEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x774AAD0", Offset = "0x7749ED0", VA = "0x18774AAD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x774A970", Offset = "0x7749D70", VA = "0x18774A970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG> FLNKGOFLDKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x774AA20", Offset = "0x7749E20", VA = "0x18774AA20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x774ACE0", Offset = "0x774A0E0", VA = "0x18774ACE0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG, KKNCCCEMNOG> JBPPFBAINPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x774AC30", Offset = "0x774A030", VA = "0x18774AC30", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x774AB80", Offset = "0x7749F80", VA = "0x18774AB80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "26")]
	public void GBFOCOOFFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "12")]
	public void MBHBIOMKKEG(GameObject MKMGIAEJNDJ, NGDOBHIMKJK NIIKKCABFNL, NNDNOOKBAAE POBHAPJDNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "13")]
	public void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "14")]
	public void ELBDPICAHPN(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "15")]
	public void FMMHPGGGKFG(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "16")]
	public void ALJOAIBDGHO(KKNCCCEMNOG HEOGBODIMIF, HashSet<KKNCCCEMNOG> BLFINHBKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "17")]
	public void PGNKCECHOPI(KKNCCCEMNOG HEOGBODIMIF, KKNCCCEMNOG OCOMBLKBHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "18")]
	public void JFAPNEBJOJA(KKNCCCEMNOG HEOGBODIMIF, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "19")]
	public void NHPBBOCFMFF(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "20")]
	public BOIIODNOJMF JLLKFOCBCLJ(bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "21")]
	public BOIIODNOJMF AFLPBDMMJBI(HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "22")]
	public bool FNKJPPDCPHJ(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "23")]
	public void ICOIMOIBOCK(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "24")]
	public void CEIGIBJOPJL(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "25")]
	public void DNIPNFFDIID(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public NMNAKJLNCEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KKNCCCEMNOG : JNKNHBPCKDC, IEquatable<KKNCCCEMNOG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JNKNHBPCKDC
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KKNCCCEMNOG ODALBGEBIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform GFBMHFBKABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject JAHMEOIAOPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid DDNICLNLEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int PCPKFEEFEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PMMHELJLBHE GCAGKJECMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool PGMDFNOPCPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int KALOBJNNMEK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int KALOBJNNMEK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int KALOBJNNMEK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int KALOBJNNMEK, KKNCCCEMNOG FMIGMJPEJDF, int NBDEFOOMJBF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int KALOBJNNMEK, KKNCCCEMNOG IGPPAFDHJPB, int OAMJKLFFHGN, Vector3 BLBPOKFPLPI, Quaternion FIKDNIICMHH);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int KALOBJNNMEK, KKNCCCEMNOG GAHFFEBCDCO, int NMGOLLIJMJM, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int KALOBJNNMEK, KKNCCCEMNOG DJDPNFBAGGC, int HIMFLKJIBOB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int KALOBJNNMEK, KKNCCCEMNOG GKDLIMGFOBG, int JOFMIKBJAOL, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(KKNCCCEMNOG GENNCHICFDN, KKNCCCEMNOG BKCMGFPIHML);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface BMBNOGPPDPH : AOPBNJCLOCO
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OKBCHGLIFFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KKNCCCEMNOG, KKNCCCEMNOG> EPHKHEIEOKH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KKNCCCEMNOG, KKNCCCEMNOG> FLNKGOFLDKN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<KKNCCCEMNOG, KKNCCCEMNOG, KKNCCCEMNOG> JBPPFBAINPH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MBHBIOMKKEG(GameObject MKMGIAEJNDJ, NGDOBHIMKJK NIIKKCABFNL, NNDNOOKBAAE EIBHCBFMPCA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NABACIPFMBC();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELBDPICAHPN(KKNCCCEMNOG HEOGBODIMIF);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FMMHPGGGKFG(KKNCCCEMNOG HEOGBODIMIF);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ALJOAIBDGHO(KKNCCCEMNOG HEOGBODIMIF, HashSet<KKNCCCEMNOG> BLFINHBKNKD);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGNKCECHOPI(KKNCCCEMNOG HEOGBODIMIF, KKNCCCEMNOG OCOMBLKBHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JFAPNEBJOJA(KKNCCCEMNOG HEOGBODIMIF, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHPBBOCFMFF(KKNCCCEMNOG HEOGBODIMIF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	BOIIODNOJMF JLLKFOCBCLJ(bool DDACIFLPAFN);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	BOIIODNOJMF AFLPBDMMJBI(HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FNKJPPDCPHJ(JHKBPFFCGFI DBBKCMNDDPN);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ICOIMOIBOCK(BOIIODNOJMF GJFMFEGOIPL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CEIGIBJOPJL(BOIIODNOJMF GJFMFEGOIPL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DNIPNFFDIID(BOIIODNOJMF GJFMFEGOIPL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PFFCDNFCAMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GJFIDCOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KKNCCCEMNOG PFNPKDNOKDM(int MFMEBDAKEIK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KKNCCCEMNOG BLMHMBLNINP(Guid KEFMCEHPFAF);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IECKKBECCPL(KKNCCCEMNOG HEOGBODIMIF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LNJDNANBJFN();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CFCPDCAMCPP(KKNCCCEMNOG CMDDOLDEIHP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface AMDHOAEAHIF
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OBFJIPMBMNA(HEIDPOKJENB CMDDOLDEIHP);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBJHGDOCDHL(HEIDPOKJENB CMDDOLDEIHP);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string PMMPAIILNNO(HEIDPOKJENB CMDDOLDEIHP);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CPDBMJLPONM(HEIDPOKJENB CMDDOLDEIHP);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int PHKMJJLCMGN(HEIDPOKJENB CMDDOLDEIHP);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFKBJIIFIPM(HEIDPOKJENB CMDDOLDEIHP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void MPFABJLDDKO(KKNCCCEMNOG LNDJNOGCFFI, int JNJBNIKKPGC, KKNCCCEMNOG GKDLIMGFOBG, int LKHMFGOMIFK, [Optional] Vector3? IJIFEJOGMGA, [Optional] Quaternion? BLHNAIBPMCB);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JDNADPJDEEP(KKNCCCEMNOG GENNCHICFDN, KKNCCCEMNOG BKCMGFPIHML);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HEIDPOKJENB : KKNCCCEMNOG, JNKNHBPCKDC, IEquatable<KKNCCCEMNOG>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MEHHNOCDBMD : JNKNHBPCKDC
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KKNCCCEMNOG GCCKNGEEGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<KKNCCCEMNOG> HONLDEKNOFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 OMCNNKAKHOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion PHJCEIJCBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MLGPLLPIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PEBJCIAGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MPFABJLDDKO HKHLCDFFDBH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MPFABJLDDKO AGECICJNONJ;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MPFABJLDDKO HJDAOKMBJOO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JDNADPJDEEP BPFADEGINDE;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CBNFMMEJBDH();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OJDEIJAKKMA();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FKMHJDDEKJG();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OGGDBKDPEMD();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IHGJOHEPKPA();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JFHDOMIFBDM();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OBCNPGAOIBD(int KALOBJNNMEK, KKNCCCEMNOG GKDLIMGFOBG, int KFPNFJLGLMD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OBMMLMIPLMM();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KBHMNJDBLJO(int KALOBJNNMEK, KKNCCCEMNOG LNDJNOGCFFI, int CNAHANKPAGM, [Optional] Vector3? IJIFEJOGMGA, [Optional] Quaternion? BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FGIIPOEAAKD(KKNCCCEMNOG LNDJNOGCFFI);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HGDNHDDGJGA();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IIJEGHDGDIL(int KDCAMOIGIMA, Vector3 FPPHNHEFIKD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LDBDCEFDEMC(Vector3 FFDNKLLODHE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LPHLAAOFGLP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 CPNDFMAHKFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface NGDOBHIMKJK
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool HAMEIHEJLOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DBCOEAPIDGM OKCGDHFOMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, NGDOBHIMKJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA110A0", Offset = "0xA104A0", VA = "0x180A110A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DBCOEAPIDGM LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x773E980", Offset = "0x773DD80", VA = "0x18773E980")]
		public static ConnectableConfigData CMCCFEMPMIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x773EA40", Offset = "0x773DE40", VA = "0x18773EA40")]
		public ConnectableConfigData(LegacyConnectableLinkVisual GOKIJAGDOIJ, bool DJLIFGCEPFH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DLOHNIAGBIK : IEquatable<DLOHNIAGBIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public KKNCCCEMNOG HEOGBODIMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int LEGHOJDPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JOFMIKBJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 IJIFEJOGMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion BLHNAIBPMCB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x773EFB0", Offset = "0x773E3B0", VA = "0x18773EFB0")]
	public DLOHNIAGBIK(KKNCCCEMNOG HEOGBODIMIF, int LEGHOJDPODF, int JOFMIKBJAOL, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x773EF10", Offset = "0x773E310", VA = "0x18773EF10")]
	public DLOHNIAGBIK(KKNCCCEMNOG HEOGBODIMIF, int LEGHOJDPODF, int JOFMIKBJAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x773F010", Offset = "0x773E410", VA = "0x18773F010")]
	public DLOHNIAGBIK(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x773EA90", Offset = "0x773DE90", VA = "0x18773EA90", Slot = "4")]
	public bool Equals(DLOHNIAGBIK JAPIEEBOJEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x773EB40", Offset = "0x773DF40", VA = "0x18773EB40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class AKCIBFPHMEH : IKJIEKGJJEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform NPHMCHFKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DBCOEAPIDGM HNACMOPNDHN;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7176F90", Offset = "0x7176390", VA = "0x187176F90", Slot = "4")]
	public void MBHBIOMKKEG(Transform NPHMCHFKJHC, DBCOEAPIDGM HNACMOPNDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7739D70", Offset = "0x7739170", VA = "0x187739D70", Slot = "5")]
	public DBCOEAPIDGM IOEBOHPMDON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7739D00", Offset = "0x7739100", VA = "0x187739D00", Slot = "6")]
	public void AABDIFHNGGN(DBCOEAPIDGM JPLGACKBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public AKCIBFPHMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class IPMLBBJDCKI : IDisposable, NCMADPJKEDE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LOICDOFIHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public KKNCCCEMNOG oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public KKNCCCEMNOG newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public LOICDOFIHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7747AF0", Offset = "0x7746EF0", VA = "0x187747AF0")]
		internal bool EDPBGDLOEKJ(GMLGDOIBOAM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly GNLHGBNDBED BHHLJGOGIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GDIPLAJGFNB EGPOMIHIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private LCPCGPCBFDH PLEEBMIEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DJLIFGCEPFH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly ABDDJEPKCOD GBDOHJOHPNK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public GMLGDOIBOAM OFMCPLOCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7744A80", Offset = "0x7743E80", VA = "0x187744A80")]
	public bool MCKDPCKGGGE([In] PDOJMOPNEDJ AMHCLKHIFKH, bool MIHLLFLOPIA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7743CE0", Offset = "0x77430E0", VA = "0x187743CE0")]
	private bool FDFALCGBOIB([In] PDOJMOPNEDJ AMHCLKHIFKH, bool MIHLLFLOPIA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7745850", Offset = "0x7744C50", VA = "0x187745850")]
	public IPMLBBJDCKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x77449D0", Offset = "0x7743DD0", VA = "0x1877449D0", Slot = "5")]
	public void MBHBIOMKKEG(BMBNOGPPDPH ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x77439E0", Offset = "0x7742DE0", VA = "0x1877439E0", Slot = "17")]
	public void DEGMEDAMKFL(CMGPBPJJPDC FJLFOAFFGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x77447C0", Offset = "0x7743BC0", VA = "0x1877447C0", Slot = "12")]
	public void JEDLOEOPMIE(Func<KKNCCCEMNOG, bool> AGOELBDOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7744690", Offset = "0x7743A90", VA = "0x187744690")]
	private void JEDLOEOPMIE(GNLHGBNDBED JOMDOBIKCNM, Func<KKNCCCEMNOG, bool> AGOELBDOOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x77448E0", Offset = "0x7743CE0", VA = "0x1877448E0", Slot = "11")]
	public void LICJNDKMBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7743970", Offset = "0x7742D70", VA = "0x187743970", Slot = "8")]
	public bool COKNNFLEBEA(KKNCCCEMNOG IMHKDGPCAMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7744A90", Offset = "0x7743E90", VA = "0x187744A90")]
	private bool MEKMGPNOJOE(KKNCCCEMNOG BPAEKCBIOAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7742C40", Offset = "0x7742040", VA = "0x187742C40")]
	private static bool BANHAIBJEGE(KKNCCCEMNOG BPAEKCBIOAL, GNLHGBNDBED DGKJFJBOOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7743580", Offset = "0x7742980", VA = "0x187743580")]
	private void CGGEONJMDBE(Transform GHEOKHAIFBI, GNLHGBNDBED DLGEOBMFAEB, GNLHGBNDBED[] DJFKOAMCLDA, KKNCCCEMNOG JPAHBMDFKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x77442A0", Offset = "0x77436A0", VA = "0x1877442A0")]
	private DLOHNIAGBIK FEAIBAGAALI(Transform GHIMLGOJIMA, DLOHNIAGBIK FPIBJDKKIHM)
	{
		return default(DLOHNIAGBIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7743AE0", Offset = "0x7742EE0", VA = "0x187743AE0")]
	private static bool EKAOENFHHLF(GNLHGBNDBED DGKJFJBOOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7744630", Offset = "0x7743A30", VA = "0x187744630", Slot = "9")]
	public bool IGNIEAACBDE(KKNCCCEMNOG OIBNDLEFKOO, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7745190", Offset = "0x7744590", VA = "0x187745190")]
	private bool NHPPGIJGBAE(KKNCCCEMNOG OIBNDLEFKOO, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7742CF0", Offset = "0x77420F0", VA = "0x187742CF0")]
	private static void BHEMNJHHKFO(KKNCCCEMNOG OIBNDLEFKOO, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB, GNLHGBNDBED IGFDLBBACHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x77453E0", Offset = "0x77447E0", VA = "0x1877453E0")]
	private void NLENIPMLHJL(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x77445C0", Offset = "0x77439C0", VA = "0x1877445C0")]
	private void HOCJODJOCFG(GNLHGBNDBED JOMDOBIKCNM, KKNCCCEMNOG DFJCJGGBHDF, KKNCCCEMNOG IMHLCBJKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7744550", Offset = "0x7743950", VA = "0x187744550")]
	private void HOCJODJOCFG(KKNCCCEMNOG HEOGBODIMIF, KKNCCCEMNOG DFJCJGGBHDF, KKNCCCEMNOG IMHLCBJKIGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7745600", Offset = "0x7744A00", VA = "0x187745600")]
	private void NNPCMFGGPMO(KKNCCCEMNOG HEOGBODIMIF, KKNCCCEMNOG DFJCJGGBHDF, KKNCCCEMNOG IMHLCBJKIGA, bool MLMEBHGMAEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7745500", Offset = "0x7744900", VA = "0x187745500")]
	private void NNPCMFGGPMO(GNLHGBNDBED FDNIDHBNFHE, KKNCCCEMNOG JPAHBMDFKME, KKNCCCEMNOG BKCMGFPIHML, bool MLMEBHGMAEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7745670", Offset = "0x7744A70", VA = "0x187745670")]
	private void OGJBJCILBOO(KKNCCCEMNOG KIGPNOGAENI, int CNAHANKPAGM, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7743420", Offset = "0x7742820", VA = "0x187743420")]
	private void BMAAAJDGANJ(GMLGDOIBOAM PBIFOHNGFLL, GMLGDOIBOAM CBCIEAKDCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x77443F0", Offset = "0x77437F0", VA = "0x1877443F0", Slot = "18")]
	public KKNCCCEMNOG HGHDAJCMAOG(KKNCCCEMNOG HEOGBODIMIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x77428A0", Offset = "0x7741CA0", VA = "0x1877428A0", Slot = "13")]
	public void ALJOAIBDGHO(KKNCCCEMNOG HEOGBODIMIF, HashSet<KKNCCCEMNOG> IIDKMNMACFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x77425C0", Offset = "0x77419C0", VA = "0x1877425C0", Slot = "14")]
	public List<KKNCCCEMNOG> AELHELMGAMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7744900", Offset = "0x7743D00", VA = "0x187744900")]
	protected GMLGDOIBOAM LOLGMCKKDLM(GMLGDOIBOAM JOMDOBIKCNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7742800", Offset = "0x7741C00", VA = "0x187742800")]
	protected GNLHGBNDBED[] AKCBJFCIBFJ(GNLHGBNDBED DGKJFJBOOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x77447D0", Offset = "0x7743BD0", VA = "0x1877447D0")]
	protected bool LFOLGPMMDGF(KKNCCCEMNOG HEOGBODIMIF, [Out] GNLHGBNDBED JOMDOBIKCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7742490", Offset = "0x7741890", VA = "0x187742490", Slot = "15")]
	public bool AAKOAPEADOF(KKNCCCEMNOG HEOGBODIMIF, [Out] DLOHNIAGBIK ECGPMMJGOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7743CA0", Offset = "0x77430A0", VA = "0x187743CA0")]
	protected GNLHGBNDBED EMHCGLJKHOA(DLOHNIAGBIK EEEAPHJLOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7743980", Offset = "0x7742D80", VA = "0x187743980", Slot = "10")]
	public bool DBHHCGBCNKJ(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7742E70", Offset = "0x7742270", VA = "0x187742E70")]
	private bool BKDMJBJCLHB(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7743A10", Offset = "0x7742E10", VA = "0x187743A10")]
	private static bool EIBKFFMBKDJ(GNLHGBNDBED CHBFJCBGOHC, DLOHNIAGBIK PPMDEPBMGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7744A80", Offset = "0x7743E80", VA = "0x187744A80", Slot = "7")]
	private bool MBNKGPOHAJK([In] PDOJMOPNEDJ AMHCLKHIFKH, bool MIHLLFLOPIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class MHOKLIPHOGA : BMBNOGPPDPH, AOPBNJCLOCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly NPIEGGOELNH PHDMEDCBLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly LCPCGPCBFDH PLEEBMIEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly HPCHLEJMCDO EGAOBCANNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly OHMMFIEPAJG HCKNPFCAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly NCMADPJKEDE GJFMFEGOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal IKIOFFKOFHI MFCHJJKNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal BAFLPJJFEEE AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal GDIPLAJGFNB MPLHJDEDPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool DJLIFGCEPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool ECMDDAHJCAL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MAMDLKCJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB3A530", Offset = "0xB39930", VA = "0x180B3A530")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1160B70", Offset = "0x115FF70", VA = "0x181160B70")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FNCFKFPOBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x103ED30", Offset = "0x103E130", VA = "0x18103ED30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x243B6F0", Offset = "0x243AAF0", VA = "0x18243B6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OKBCHGLIFFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG> EPHKHEIEOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7748DF0", Offset = "0x77481F0", VA = "0x187748DF0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7748CC0", Offset = "0x77480C0", VA = "0x187748CC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG> FLNKGOFLDKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7748D40", Offset = "0x7748140", VA = "0x187748D40", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7749C70", Offset = "0x7749070", VA = "0x187749C70", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<KKNCCCEMNOG, KKNCCCEMNOG, KKNCCCEMNOG> JBPPFBAINPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x77492D0", Offset = "0x77486D0", VA = "0x1877492D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7748F20", Offset = "0x7748320", VA = "0x187748F20", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x774A270", Offset = "0x7749670", VA = "0x18774A270")]
	public MHOKLIPHOGA(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7749510", Offset = "0x7748910", VA = "0x187749510", Slot = "12")]
	public void MBHBIOMKKEG(GameObject MKMGIAEJNDJ, NGDOBHIMKJK NIIKKCABFNL, NNDNOOKBAAE EIBHCBFMPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7748E50", Offset = "0x7748250", VA = "0x187748E50", Slot = "26")]
	public void GBFOCOOFFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7749CD0", Offset = "0x77490D0", VA = "0x187749CD0", Slot = "13")]
	public void NABACIPFMBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7748D20", Offset = "0x7748120", VA = "0x187748D20", Slot = "14")]
	public void ELBDPICAHPN(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7748810", Offset = "0x7747C10", VA = "0x187748810", Slot = "15")]
	public void FMMHPGGGKFG(KKNCCCEMNOG HEOGBODIMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7748DA0", Offset = "0x77481A0", VA = "0x187748DA0", Slot = "22")]
	public bool FNKJPPDCPHJ(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7748870", Offset = "0x7747C70", VA = "0x187748870")]
	internal bool BKDMJBJCLHB([In] PDOJMOPNEDJ AMHCLKHIFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7749B20", Offset = "0x7748F20", VA = "0x187749B20")]
	internal bool MDFIMIACLJF([In] PDOJMOPNEDJ AMHCLKHIFKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7749330", Offset = "0x7748730", VA = "0x187749330")]
	internal void LDEDGCOOFAP(KKNCCCEMNOG HEOGBODIMIF, int ENINCAGCFGL, bool MIHLLFLOPIA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7748810", Offset = "0x7747C10", VA = "0x187748810")]
	internal bool BKACIGCMDPK(KKNCCCEMNOG LPNAGNAKPIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7749F20", Offset = "0x7749320", VA = "0x187749F20")]
	internal bool NLFDCAOCFKN(KKNCCCEMNOG OIBNDLEFKOO, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7748710", Offset = "0x7747B10", VA = "0x187748710", Slot = "16")]
	public void ALJOAIBDGHO(KKNCCCEMNOG HEOGBODIMIF, HashSet<KKNCCCEMNOG> BLFINHBKNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x774A060", Offset = "0x7749460", VA = "0x18774A060", Slot = "17")]
	public void PGNKCECHOPI(KKNCCCEMNOG OIBNDLEFKOO, KKNCCCEMNOG OCOMBLKBHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7749010", Offset = "0x7748410", VA = "0x187749010", Slot = "18")]
	public void JFAPNEBJOJA(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7749D50", Offset = "0x7749150", VA = "0x187749D50", Slot = "19")]
	public void NHPBBOCFMFF(KKNCCCEMNOG DMLOKDENBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7748A70", Offset = "0x7747E70", VA = "0x187748A70")]
	public void DOEEIAFEDFC([Optional] LJGCKELMKNN KKLJLIFJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7748F80", Offset = "0x7748380", VA = "0x187748F80", Slot = "23")]
	public void ICOIMOIBOCK(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7749150", Offset = "0x7748550", VA = "0x187749150", Slot = "20")]
	public BOIIODNOJMF JLLKFOCBCLJ(bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7748570", Offset = "0x7747970", VA = "0x187748570", Slot = "21")]
	public BOIIODNOJMF AFLPBDMMJBI(HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7748A30", Offset = "0x7747E30", VA = "0x187748A30", Slot = "25")]
	public void DNIPNFFDIID(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7748980", Offset = "0x7747D80", VA = "0x187748980", Slot = "24")]
	public void CEIGIBJOPJL(BOIIODNOJMF GJFMFEGOIPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class LCPCGPCBFDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly ABNIGPKKHEA<KKNCCCEMNOG, KKNCCCEMNOG> EPHKHEIEOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly ABNIGPKKHEA<KKNCCCEMNOG, KKNCCCEMNOG> FLNKGOFLDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly IEAHLFMOJAO<KKNCCCEMNOG, KKNCCCEMNOG, KKNCCCEMNOG> JBPPFBAINPH;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x77479D0", Offset = "0x7746DD0", VA = "0x1877479D0")]
	public LCPCGPCBFDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340")]
	public void MBHBIOMKKEG(MHOKLIPHOGA ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7747970", Offset = "0x7746D70", VA = "0x187747970")]
	public void POHKICNGJFN(KKNCCCEMNOG PBIFOHNGFLL, KKNCCCEMNOG KIGPNOGAENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7747890", Offset = "0x7746C90", VA = "0x187747890")]
	public void AEHMPPMBBIK(KKNCCCEMNOG PBIFOHNGFLL, KKNCCCEMNOG KIGPNOGAENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x77478F0", Offset = "0x7746CF0", VA = "0x1877478F0")]
	public void LDJLLFBIKBB(KKNCCCEMNOG GJHMCJPCNJC, KKNCCCEMNOG DPOGHMAJNAL, KKNCCCEMNOG KIGPNOGAENI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HPCHLEJMCDO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private MHOKLIPHOGA ECPDNOJCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BAFLPJJFEEE AAHFLKJGFKB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public HPCHLEJMCDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x77418F0", Offset = "0x7740CF0", VA = "0x1877418F0")]
	public void MBHBIOMKKEG(MHOKLIPHOGA ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x77416C0", Offset = "0x7740AC0", VA = "0x1877416C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7741AA0", Offset = "0x7740EA0", VA = "0x187741AA0")]
	private void OEBEBAMIIOO(HEAAFFHJEKN EJFMLPKGCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7741A30", Offset = "0x7740E30", VA = "0x187741A30")]
	private void NPBMHCLOOPL(LJGCKELMKNN FACDEDPCGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x77417E0", Offset = "0x7740BE0", VA = "0x1877417E0")]
	public void LHFILNMKKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x77416D0", Offset = "0x7740AD0", VA = "0x1877416D0")]
	public void IGLAPFNGNIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class GKEOLOCJGGB
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IHPDAJEFDGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public NPIEGGOELNH container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public IHPDAJEFDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7741AE0", Offset = "0x7740EE0", VA = "0x187741AE0")]
		internal MHOKLIPHOGA KLIOPKLICFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7740910", Offset = "0x773FD10", VA = "0x187740910")]
	public static void GOKIHGAMJJL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7740B10", Offset = "0x773FF10", VA = "0x187740B10")]
	public static void HOILNKLIMCL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class ECELLCHMKHH : IDisposable, GDIPLAJGFNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, DBCOEAPIDGM> ODNAGNHGNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CMGPBPJJPDC AAMHJGINLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private IKJIEKGJJEN MNDBHEOGHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private NCMADPJKEDE GJFMFEGOIPL;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker DPBPKNFGLDM;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x773FFA0", Offset = "0x773F3A0", VA = "0x18773FFA0")]
	public ECELLCHMKHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x773FA40", Offset = "0x773EE40", VA = "0x18773FA40", Slot = "7")]
	public void MBHBIOMKKEG(NCMADPJKEDE GJFMFEGOIPL, IKJIEKGJJEN MNDBHEOGHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x773F2E0", Offset = "0x773E6E0", VA = "0x18773F2E0", Slot = "5")]
	public void BBAGOJJJOIN(GMLGDOIBOAM KMMAEFICMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x773FDD0", Offset = "0x773F1D0", VA = "0x18773FDD0", Slot = "9")]
	public void NDIIJBJLIIH(GMLGDOIBOAM JGPPKOFOPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x773F520", Offset = "0x773E920", VA = "0x18773F520", Slot = "8")]
	public void BCJNCPKCAEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x773FA80", Offset = "0x773EE80", VA = "0x18773FA80", Slot = "10")]
	public void NCHPDOCAKEK(GMLGDOIBOAM IFOADPDJGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x773F6E0", Offset = "0x773EAE0", VA = "0x18773F6E0", Slot = "11")]
	public void CKJMJLBCAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x773F890", Offset = "0x773EC90", VA = "0x18773F890")]
	private bool KBLGIINNDNK(GMLGDOIBOAM OCKNOGIDPFP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class OHMMFIEPAJG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct IKGOHLALNAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly GNLHGBNDBED AHNFNFHOLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> GJLLAOGHPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly JHKBPFFCGFI NADKGPHEMJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly JHKBPFFCGFI HPCIOPKMGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool DDACIFLPAFN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool BGFEJMBPPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x77420A0", Offset = "0x77414A0", VA = "0x1877420A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7742420", Offset = "0x7741820", VA = "0x187742420")]
		public IKGOHLALNAE(GNLHGBNDBED AHNFNFHOLGI, HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN, [Optional] JHKBPFFCGFI NADKGPHEMJN, [Optional] JHKBPFFCGFI HPCIOPKMGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7742280", Offset = "0x7741680", VA = "0x187742280")]
		public JHKBPFFCGFI LMGGAKIACNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x77421C0", Offset = "0x77415C0", VA = "0x1877421C0")]
		private JHKBPFFCGFI IIIDAAMABAB([Out] JHKBPFFCGFI NJOMPOFAIKG, [Out] JHKBPFFCGFI JNGMIJJOPBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7741D10", Offset = "0x7741110", VA = "0x187741D10")]
		private JHKBPFFCGFI CAEPIAAKOPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7741F30", Offset = "0x7741330", VA = "0x187741F30")]
		private void GFHBPNCNOAG(JHKBPFFCGFI ONDBBBOKPCH, JHKBPFFCGFI LIAHAFIDOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7741B50", Offset = "0x7740F50", VA = "0x187741B50")]
		private void BFGHMHFOGAD(JHKBPFFCGFI NJOMPOFAIKG, JHKBPFFCGFI JNGMIJJOPBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly ABDDJEPKCOD LEMJHEDOKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private MHOKLIPHOGA ECPDNOJCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NCMADPJKEDE GJFMFEGOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GDIPLAJGFNB EGPOMIHIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private BAFLPJJFEEE AAHFLKJGFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool MBFNOFCAJIK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KGIHKLIJKCD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x774C590", Offset = "0x774B990", VA = "0x18774C590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool MAMDLKCJJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x774BED0", Offset = "0x774B2D0", VA = "0x18774BED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x774D410", Offset = "0x774C810", VA = "0x18774D410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x774C9E0", Offset = "0x774BDE0", VA = "0x18774C9E0")]
	public void MBHBIOMKKEG(MHOKLIPHOGA ECPDNOJCJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x774C5E0", Offset = "0x774B9E0", VA = "0x18774C5E0")]
	public BOIIODNOJMF JLLKFOCBCLJ(bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x774AD90", Offset = "0x774A190", VA = "0x18774AD90")]
	public BOIIODNOJMF AFLPBDMMJBI(HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x774C180", Offset = "0x774B580", VA = "0x18774C180")]
	public void ICOIMOIBOCK(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x774B830", Offset = "0x774AC30", VA = "0x18774B830")]
	public void CEIGIBJOPJL(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x774D3E0", Offset = "0x774C7E0", VA = "0x18774D3E0")]
	public void PHEEBEIGCBL(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x774C3A0", Offset = "0x774B7A0", VA = "0x18774C3A0")]
	private void IIHALMBCPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x774AF30", Offset = "0x774A330", VA = "0x18774AF30")]
	private JHKBPFFCGFI AJALEKPAINN(GNLHGBNDBED JOMDOBIKCNM, bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x774B5E0", Offset = "0x774A9E0", VA = "0x18774B5E0")]
	private static void BGGFCDFDEPO(GNLHGBNDBED JOMDOBIKCNM, bool DDACIFLPAFN, JHKBPFFCGFI DBBKCMNDDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x774B3C0", Offset = "0x774A7C0", VA = "0x18774B3C0")]
	private void BFAFILCLLBB(GNLHGBNDBED JOMDOBIKCNM, bool DDACIFLPAFN, JHKBPFFCGFI DBBKCMNDDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x774D0C0", Offset = "0x774C4C0", VA = "0x18774D0C0")]
	private JHKBPFFCGFI MGKNCPLLGCB(GNLHGBNDBED AHNFNFHOLGI, HashSet<Guid> GJLLAOGHPHH, bool DDACIFLPAFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x774C750", Offset = "0x774BB50", VA = "0x18774C750")]
	private bool LDLIBLJADBA(BOIIODNOJMF FDMNLPKAGEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x774CA50", Offset = "0x774BE50", VA = "0x18774CA50")]
	private bool MFMLPCBCOKF(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x774B8D0", Offset = "0x774ACD0", VA = "0x18774B8D0")]
	private bool CNGKPPBIHAE(BOIIODNOJMF GJFMFEGOIPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x774D150", Offset = "0x774C550", VA = "0x18774D150")]
	private static bool OBFFILDGONO(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x774BEF0", Offset = "0x774B2F0", VA = "0x18774BEF0")]
	public static bool FNKJPPDCPHJ(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x774B9E0", Offset = "0x774ADE0", VA = "0x18774B9E0")]
	private KKNCCCEMNOG DOMAEABGGCE(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x774D260", Offset = "0x774C660", VA = "0x18774D260")]
	private KKNCCCEMNOG PFNPKDNOKDM(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x774C210", Offset = "0x774B610", VA = "0x18774C210")]
	private KKNCCCEMNOG IGPDECDCHOE(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x773A250", Offset = "0x7739650", VA = "0x18773A250")]
	private static Guid ALDOMLACLCB(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x774B8F0", Offset = "0x774ACF0", VA = "0x18774B8F0")]
	private string CNHJJPMPGNE(JHKBPFFCGFI DBBKCMNDDPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x774BD40", Offset = "0x774B140", VA = "0x18774BD40")]
	private bool ELDOEINOFBI(GNLHGBNDBED JOMDOBIKCNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x774B160", Offset = "0x774A560", VA = "0x18774B160")]
	private static void BBAGEOGMLCI(GNLHGBNDBED AHNFNFHOLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public OHMMFIEPAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct PDOJMOPNEDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public KKNCCCEMNOG KIGPNOGAENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public KKNCCCEMNOG PBIFOHNGFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int CNAHANKPAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KFPNFJLGLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 IJIFEJOGMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion BLHNAIBPMCB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DLOHNIAGBIK ODLAELADLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x774D550", Offset = "0x774C950", VA = "0x18774D550")]
		get
		{
			return default(DLOHNIAGBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DLOHNIAGBIK JOKKMBNPADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x774D5F0", Offset = "0x774C9F0", VA = "0x18774D5F0")]
		get
		{
			return default(DLOHNIAGBIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x774D620", Offset = "0x774CA20", VA = "0x18774D620")]
	public PDOJMOPNEDJ(KKNCCCEMNOG KIGPNOGAENI, KKNCCCEMNOG PBIFOHNGFLL, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NCMADPJKEDE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	GMLGDOIBOAM OFMCPLOCJBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHBIOMKKEG(BMBNOGPPDPH ECPDNOJCJEA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MCKDPCKGGGE([In] PDOJMOPNEDJ AMHCLKHIFKH, bool MIHLLFLOPIA = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool COKNNFLEBEA(KKNCCCEMNOG IMHKDGPCAMH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IGNIEAACBDE(KKNCCCEMNOG OIBNDLEFKOO, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DBHHCGBCNKJ(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LICJNDKMBNO();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JEDLOEOPMIE(Func<KKNCCCEMNOG, bool> AGOELBDOOKK);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ALJOAIBDGHO(KKNCCCEMNOG HEOGBODIMIF, HashSet<KKNCCCEMNOG> IIDKMNMACFD);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<KKNCCCEMNOG> AELHELMGAMB();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AAKOAPEADOF(KKNCCCEMNOG HEOGBODIMIF, [Out] DLOHNIAGBIK ECGPMMJGOBC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DEGMEDAMKFL(CMGPBPJJPDC FJLFOAFFGHE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool CMGPBPJJPDC(GMLGDOIBOAM JOMDOBIKCNM);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface GMLGDOIBOAM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	KKNCCCEMNOG OIALPBMJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GMLGDOIBOAM DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DLOHNIAGBIK PMCIOJLBGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool CBIDFEGEAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DBCOEAPIDGM
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AEJOPFDILPE(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKLDBLJLCJI(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEBDHCGCNKH(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEFEPHECMBM(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DBCOEAPIDGM Instantiate(Transform NPHMCHFKJHC);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DPGGICHIMDD();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IKJIEKGJJEN
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBHBIOMKKEG(Transform NPHMCHFKJHC, DBCOEAPIDGM HNACMOPNDHN);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DBCOEAPIDGM IOEBOHPMDON();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AABDIFHNGGN(DBCOEAPIDGM JPLGACKBNKM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface IKIOFFKOFHI : PFFCDNFCAMM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAJDBDINJKN();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JANMLBOHGEB(Guid EPPHOMAKDFP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GDIPLAJGFNB
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBAGOJJJOIN(GMLGDOIBOAM KMMAEFICMKD);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBHBIOMKKEG(NCMADPJKEDE GJFMFEGOIPL, IKJIEKGJJEN NDIEJFEOCLM);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCJNCPKCAEG();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDIIJBJLIIH(GMLGDOIBOAM JGPPKOFOPDN);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NCHPDOCAKEK(GMLGDOIBOAM IFOADPDJGKN);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CKJMJLBCAMD();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class GNLHGBNDBED : GMLGDOIBOAM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FGPFCNHKKKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DLOHNIAGBIK nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GNLHGBNDBED foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public FGPFCNHKKKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x77407D0", Offset = "0x773FBD0", VA = "0x1877407D0")]
		internal bool KFFHJJJPBNH(GMLGDOIBOAM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DLOHNIAGBIK ECGPMMJGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<GNLHGBNDBED> CJOIABOADLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private GNLHGBNDBED FBAEFPCEPPF;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DLOHNIAGBIK PMCIOJLBGHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1160DB0", Offset = "0x11601B0", VA = "0x181160DB0", Slot = "6")]
		get
		{
			return default(DLOHNIAGBIK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1160B40", Offset = "0x115FF40", VA = "0x181160B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private GNLHGBNDBED PBIFOHNGFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7741530", Offset = "0x7740930", VA = "0x187741530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GMLGDOIBOAM DHHOIDHGNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KKNCCCEMNOG OIALPBMJEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CBIDFEGEAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x77410D0", Offset = "0x77404D0", VA = "0x1877410D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ABHEFMJJJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7741430", Offset = "0x7740830", VA = "0x187741430", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected GNLHGBNDBED FDNIDHBNFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7741410", Offset = "0x7740810", VA = "0x187741410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7741610", Offset = "0x7740A10", VA = "0x187741610")]
	public GNLHGBNDBED(DLOHNIAGBIK JNLMINFIFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7740B90", Offset = "0x773FF90", VA = "0x187740B90")]
	public GNLHGBNDBED AFKMCGFGABH(DLOHNIAGBIK IEJBPDKIEKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7740CE0", Offset = "0x77400E0", VA = "0x187740CE0")]
	public GNLHGBNDBED BEJKHGAKIGE(DLOHNIAGBIK BGCMNCBHHID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x77410E0", Offset = "0x77404E0", VA = "0x1877410E0")]
	public GNLHGBNDBED FBDLIPAFCGJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x77412C0", Offset = "0x77406C0", VA = "0x1877412C0")]
	public void GAPBPDEBKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7741480", Offset = "0x7740880", VA = "0x187741480")]
	public GNLHGBNDBED HNBHOLDGCEL(DLOHNIAGBIK DPOGHMAJNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7740E70", Offset = "0x7740270", VA = "0x187740E70")]
	private static void DEGMEDAMKFL(GNLHGBNDBED PKAFCMFEIBM, CMGPBPJJPDC MEOMIMDGMJF, bool JOAEAOLINFE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7740E60", Offset = "0x7740260", VA = "0x187740E60", Slot = "9")]
	public void DEGMEDAMKFL(CMGPBPJJPDC FJLFOAFFGHE, bool MLMEBHGMAEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7740FD0", Offset = "0x77403D0", VA = "0x187740FD0")]
	public static GNLHGBNDBED EMHCGLJKHOA(GNLHGBNDBED PKAFCMFEIBM, DLOHNIAGBIK GIAJMOKNHBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface BAFLPJJFEEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool KGIHKLIJKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool GJFIDCOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<HEAAFFHJEKN> OEBEBAMIIOO;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<LJGCKELMKNN> NPBMHCLOOPL;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AEJOPFDILPE(MHOKLIPHOGA ECPDNOJCJEA, NNDNOOKBAAE POBHAPJDNFL);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PGNKCECHOPI(KKNCCCEMNOG OIBNDLEFKOO, KKNCCCEMNOG OCOMBLKBHGN, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFAPNEBJOJA(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OJOBEJPDIEG(BOIIODNOJMF CLGCAABJAOM, [Optional] LJGCKELMKNN KKLJLIFJDMA);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BEGEFHCECPN
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type PONMJFHCNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x773E890", Offset = "0x773DC90", VA = "0x18773E890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x773E940", Offset = "0x773DD40", VA = "0x18773E940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x773E8F0", Offset = "0x773DCF0", VA = "0x18773E8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class ACNDKBLDEJN : BAFLPJJFEEE, IDisposable, MABBDEHLNIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private MHOKLIPHOGA ECPDNOJCJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NNDNOOKBAAE EIBHCBFMPCA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KGIHKLIJKCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7739200", Offset = "0x7738600", VA = "0x187739200", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GJFIDCOACBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7738F60", Offset = "0x7738360", VA = "0x187738F60", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView AIGALBLONIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7738FA0", Offset = "0x77383A0", VA = "0x187738FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<HEAAFFHJEKN> OEBEBAMIIOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7739260", Offset = "0x7738660", VA = "0x187739260", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7738ED0", Offset = "0x77382D0", VA = "0x187738ED0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<LJGCKELMKNN> NPBMHCLOOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7739030", Offset = "0x7738430", VA = "0x187739030", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x77392F0", Offset = "0x77386F0", VA = "0x1877392F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7738DF0", Offset = "0x77381F0", VA = "0x187738DF0", Slot = "10")]
	public void AEJOPFDILPE(MHOKLIPHOGA ECPDNOJCJEA, NNDNOOKBAAE EIBHCBFMPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7738E80", Offset = "0x7738280", VA = "0x187738E80", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x77394C0", Offset = "0x77388C0", VA = "0x1877394C0", Slot = "11")]
	public void PGNKCECHOPI(KKNCCCEMNOG OIBNDLEFKOO, KKNCCCEMNOG OCOMBLKBHGN, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x77390D0", Offset = "0x77384D0", VA = "0x1877390D0", Slot = "12")]
	public void JFAPNEBJOJA(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7739390", Offset = "0x7738790", VA = "0x187739390", Slot = "13")]
	public void OJOBEJPDIEG(BOIIODNOJMF CLGCAABJAOM, [Optional] LJGCKELMKNN KKLJLIFJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7739830", Offset = "0x7738C30", VA = "0x187739830")]
	[KBGKKNFCDLD]
	private void RpcMasterReparentNodes(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7739630", Offset = "0x7738A30", VA = "0x187739630")]
	[KBGKKNFCDLD]
	private void RpcMasterModifyNode(KKNCCCEMNOG OIBNDLEFKOO, KKNCCCEMNOG OCOMBLKBHGN, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7739C00", Offset = "0x7739000", VA = "0x187739C00")]
	[KBGKKNFCDLD]
	private void RpcReparentNodes(KKNCCCEMNOG DMLOKDENBEJ, int EDKMMFKEIPO, KKNCCCEMNOG DPOGHMAJNAL, int OAMJKLFFHGN, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB, EBOPHAEFBGB BFCBEJLLHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7739B40", Offset = "0x7738F40", VA = "0x187739B40")]
	[KBGKKNFCDLD]
	private void RpcModifyNode(KKNCCCEMNOG OIBNDLEFKOO, int CNAHANKPAGM, int KFPNFJLGLMD, Vector3 IJIFEJOGMGA, Quaternion BLHNAIBPMCB, EBOPHAEFBGB BFCBEJLLHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x77395F0", Offset = "0x77389F0", VA = "0x1877395F0")]
	[KBGKKNFCDLD]
	private void RpcDeserializeConnectableGraph(BOIIODNOJMF GJFMFEGOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public ACNDKBLDEJN()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DBCOEAPIDGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7748250", Offset = "0x7747650", VA = "0x187748250", Slot = "4")]
		private void PIEPAIGAGPK(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7747F60", Offset = "0x7747360", VA = "0x187747F60", Slot = "5")]
		private void NFLCMBFOFII(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7747C10", Offset = "0x7747010", VA = "0x187747C10", Slot = "6")]
		private void GHPKIPPJODA(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7747D70", Offset = "0x7747170", VA = "0x187747D70", Slot = "7")]
		private void JDPGIFEJNHF(KKNCCCEMNOG GKDLIMGFOBG, DLOHNIAGBIK KIGPNOGAENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x77481E0", Offset = "0x77475E0", VA = "0x1877481E0", Slot = "8")]
		private DBCOEAPIDGM OMENDOCGCJN(Transform NPHMCHFKJHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7747BB0", Offset = "0x7746FB0", VA = "0x187747BB0", Slot = "9")]
		private void ECJGBADFLAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DKFFBFPJICI
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3418470", Offset = "0x3417870", VA = "0x183418470")]
	public static GAJFFLGDNBD<T> INABFDNKCNA<T>(this NPIEGGOELNH PHDMEDCBLHH)
	{
		return null;
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
