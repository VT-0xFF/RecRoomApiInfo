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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7836D00", Offset = "0x7835700", VA = "0x187836D00", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x783DF70", Offset = "0x783C970", VA = "0x18783DF70", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x783D950", Offset = "0x783C350", VA = "0x18783D950")]
		private void IPCGMJBOKKK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x783DAC0", Offset = "0x783C4C0", VA = "0x18783DAC0")]
		private void PENEIAJNJEJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x783DC30", Offset = "0x783C630", VA = "0x18783DC30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x783DFB0", Offset = "0x783C9B0", VA = "0x18783DFB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JNANBHFPFOO : ACOCDKHPBHE, BLJGGMGKPKC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class ANFFDNPPJKB : IEnumerable<HDFGDHKNPJK>, IEnumerable, IEnumerator<HDFGDHKNPJK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HDFGDHKNPJK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ECEDHFIPBHO localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public ECEDHFIPBHO <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JNANBHFPFOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private HOECEAHHGFN <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private KFKFMJGCIBC <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private KFKFMJGCIBC.IMPPFOKKJCM <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HDFGDHKNPJK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE17BE0", Offset = "0xE165E0", VA = "0x180E17BE0")]
		[DebuggerHidden]
		public ANFFDNPPJKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7829590", Offset = "0x7827F90", VA = "0x187829590", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7829130", Offset = "0x7827B30", VA = "0x187829130", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7829110", Offset = "0x7827B10", VA = "0x187829110")]
		private void JKNFIIFCPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x78290F0", Offset = "0x7827AF0", VA = "0x1878290F0")]
		private void EKCCALBOGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7829540", Offset = "0x7827F40", VA = "0x187829540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7829490", Offset = "0x7827E90", VA = "0x187829490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HDFGDHKNPJK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7829490", Offset = "0x7827E90", VA = "0x187829490", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IGPOKFBANKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public JNANBHFPFOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CPOHCFHANCE nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public IGPOKFBANKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x782D3C0", Offset = "0x782BDC0", VA = "0x18782D3C0")]
		internal object EPAKEJFPCBB(CPOHCFHANCE x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class PEENNNJHGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public CPOHCFHANCE child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IGPOKFBANKI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public PEENNNJHGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x783CBC0", Offset = "0x783B5C0", VA = "0x18783CBC0")]
		internal object CJBKCAOMLHB((CPOHCFHANCE child, CPOHCFHANCE nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LMPJBEBLCLM MEDDGMFGHAE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly LMPJBEBLCLM DAKOPMIBCJA;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LMPJBEBLCLM NJODIDCHAFP;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LMPJBEBLCLM NLLJKPMBLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private EHPGPOEMLFF EHBNPBDGJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private CIBKLKDAMDL JBPNNEGFBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PDMBJJLECEJ DCLOGLGKJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LAEAJFANGEH MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private JHFDFCPCPEN LKAEOCKNCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IMMINFICOAN GNJMKKKJHPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xB915D0", Offset = "0xB8FFD0", VA = "0x180B915D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB909D0", Offset = "0xB8F3D0", VA = "0x180B909D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OJPFNIKDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK> OIPKDLLKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7832EE0", Offset = "0x78318E0", VA = "0x187832EE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7834490", Offset = "0x7832E90", VA = "0x187834490", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK> NEAGNFGIGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7832240", Offset = "0x7830C40", VA = "0x187832240", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7833770", Offset = "0x7832170", VA = "0x187833770", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK, HDFGDHKNPJK> EPGODLOOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7831C80", Offset = "0x7830680", VA = "0x187831C80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7832190", Offset = "0x7830B90", VA = "0x187832190", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x78357D0", Offset = "0x78341D0", VA = "0x1878357D0")]
	public JNANBHFPFOO(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7831D30", Offset = "0x7830730", VA = "0x187831D30", Slot = "12")]
	public void ELAEPFFNBKM(GameObject IHDAMAGFMLN, FBPCNIFMEHF LHKEBEELHCP, HDLKJEEPFBF OGBHHOBCGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7831FA0", Offset = "0x78309A0", VA = "0x187831FA0", Slot = "26")]
	public void FCBNDJLJLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7831A20", Offset = "0x7830420", VA = "0x187831A20", Slot = "22")]
	public bool CMLFLMLOICP(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x78328E0", Offset = "0x78312E0", VA = "0x1878328E0")]
	private void HDBAEDALPEI(ECEDHFIPBHO LBFJPLFDAIC, ECEDHFIPBHO BOBHAPCJHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7830E30", Offset = "0x782F830", VA = "0x187830E30")]
	private void ACNNKDHMLFM(ECEDHFIPBHO LBFJPLFDAIC, ECEDHFIPBHO CHKOMFBFDNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7835240", Offset = "0x7833C40", VA = "0x187835240")]
	private void PHHEMOONJKO(ECEDHFIPBHO LBFJPLFDAIC, ECEDHFIPBHO CHKOMFBFDNI, ECEDHFIPBHO BOBHAPCJHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7834710", Offset = "0x7833110", VA = "0x187834710")]
	private void OKJEEJJEDHG(ECEDHFIPBHO LBFJPLFDAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "13")]
	public void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7831510", Offset = "0x782FF10", VA = "0x187831510", Slot = "14")]
	public void BLLBFFICICF(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "15")]
	public void BAPLINGHHOO(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7832430", Offset = "0x7830E30", VA = "0x187832430", Slot = "17")]
	public void GEOJLGIPNDK(HDFGDHKNPJK DJGPAELJDPJ, HDFGDHKNPJK OEEJKHHMHGC, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x78322F0", Offset = "0x7830CF0", VA = "0x1878322F0")]
	public void GEOJLGIPNDK(ECEDHFIPBHO CGGKEPFNHFP, ECEDHFIPBHO OEEJKHHMHGC, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7832AF0", Offset = "0x78314F0", VA = "0x187832AF0")]
	public void HEADBDCNCDM(HDFGDHKNPJK DJGPAELJDPJ, float EOLODPHLAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x78331C0", Offset = "0x7831BC0", VA = "0x1878331C0", Slot = "18")]
	public void JIMPHMLKHOA(HDFGDHKNPJK GENDILBKJDE, int CJBNJEHBJLP, HDFGDHKNPJK LHAJHKEIOAB, int NJKJNNKPFFG, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7832830", Offset = "0x7831230", VA = "0x187832830")]
	private float HCOBMGCCOKF(ECEDHFIPBHO CGGKEPFNHFP, ECEDHFIPBHO HGBJMKAPAJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7833080", Offset = "0x7831A80", VA = "0x187833080")]
	public void JIMPHMLKHOA(ECEDHFIPBHO CGGKEPFNHFP, ECEDHFIPBHO HGBJMKAPAJA, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, bool PMKMBHOEPGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x78354A0", Offset = "0x7833EA0", VA = "0x1878354A0", Slot = "19")]
	public void PIFGAKOOKLP(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7831810", Offset = "0x7830210", VA = "0x187831810", Slot = "16")]
	public void CEACBGOBHGL(HDFGDHKNPJK DJGPAELJDPJ, HashSet<HDFGDHKNPJK> PBOFCILFHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "20")]
	public HBPNKIEKBJJ DDEIHDAPEDO(bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "21")]
	public HBPNKIEKBJJ GFEAMKHJHFI(HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7831A70", Offset = "0x7830470", VA = "0x187831A70", Slot = "23")]
	public void DBJFIADLFDM(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7835610", Offset = "0x7834010", VA = "0x187835610", Slot = "24")]
	public void PLIBBCINMHN(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7831AE0", Offset = "0x78304E0", VA = "0x187831AE0", Slot = "25")]
	public void DIDHMPGLFHJ(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7833410", Offset = "0x7831E10", VA = "0x187833410")]
	private void JPMMHNCDMLC(ECEDHFIPBHO CGGKEPFNHFP, ECEDHFIPBHO HGBJMKAPAJA, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL, float EOLODPHLAFO, bool PMKMBHOEPGN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7833890", Offset = "0x7832290", VA = "0x187833890")]
	private void LMKPMJACIBO(ECEDHFIPBHO CGGKEPFNHFP, ECEDHFIPBHO MGKDKKMCMAL, Vector3 GHOLIOPECPJ, Quaternion BOFAHJJKKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7833820", Offset = "0x7832220", VA = "0x187833820")]
	private void KEMPBEMHCPH(ECEDHFIPBHO CGGKEPFNHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7832F90", Offset = "0x7831990", VA = "0x187832F90")]
	[IteratorStateMachine(typeof(ANFFDNPPJKB))]
	public IEnumerable<HDFGDHKNPJK> HOMMAEIIBGN(ECEDHFIPBHO CEJEEJJKEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x78313E0", Offset = "0x782FDE0", VA = "0x1878313E0")]
	internal HDFGDHKNPJK APNIAKCJIFI(ECEDHFIPBHO CEJEEJJKEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7832590", Offset = "0x7830F90", VA = "0x187832590")]
	internal ECEDHFIPBHO GKKBKOOBGLM(HDFGDHKNPJK DJGPAELJDPJ)
	{
		return default(ECEDHFIPBHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7834CB0", Offset = "0x78336B0", VA = "0x187834CB0")]
	private bool PDFNOIOFIJJ(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7834430", Offset = "0x7832E30", VA = "0x187834430")]
	private bool MJHDAHDPBGC(CPOHCFHANCE HPKAFPMNGAI, [Out] HDFGDHKNPJK HGBJMKAPAJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7831050", Offset = "0x782FA50", VA = "0x187831050")]
	private HDFGDHKNPJK APNIAKCJIFI(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7831B00", Offset = "0x7830500", VA = "0x187831B00")]
	private HDFGDHKNPJK EBAHAHOCBML(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7834540", Offset = "0x7832F40", VA = "0x187834540")]
	private HDFGDHKNPJK OFIKOCMEFFF(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7832B80", Offset = "0x7831580", VA = "0x187832B80")]
	private static Guid HGFGGOOBKLK(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7833320", Offset = "0x7831D20", VA = "0x187833320")]
	private string JPBKPLCIAHG(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7832D50", Offset = "0x7831750", VA = "0x187832D50")]
	private void HOBGOOMEDAL(HDFGDHKNPJK CGGKEPFNHFP, HDFGDHKNPJK MGKDKKMCMAL, RigidTransform LMHMPOPBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7832BC0", Offset = "0x78315C0", VA = "0x187832BC0")]
	private void HNOGFPPDMIL(HDFGDHKNPJK MGKDKKMCMAL, HDFGDHKNPJK CGGKEPFNHFP, RigidTransform LMHMPOPBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7833020", Offset = "0x7831A20", VA = "0x187833020")]
	private void IPFCKLDPLFK(HDFGDHKNPJK ENJCJLCMMGG, HDFGDHKNPJK CGGKEPFNHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7834B20", Offset = "0x7833520", VA = "0x187834B20")]
	private void PBNILMBCLJJ(HDFGDHKNPJK CGGKEPFNHFP, HDFGDHKNPJK HGBJMKAPAJA, RigidTransform LMHMPOPBLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7832720", Offset = "0x7831120", VA = "0x187832720")]
	private void GPDHENEPLNI(ECEDHFIPBHO CEJEEJJKEJL, HDFGDHKNPJK DJGPAELJDPJ, ECEDHFIPBHO CHKOMFBFDNI, ECEDHFIPBHO BOBHAPCJHCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x78341B0", Offset = "0x7832BB0", VA = "0x1878341B0")]
	private void MJCGONMGHMI(ECEDHFIPBHO CEJEEJJKEJL, HDFGDHKNPJK DJGPAELJDPJ, HDFGDHKNPJK CCJAAPCCMMC, HDFGDHKNPJK GEFPNKBJEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CINKOJHFLJN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KCGAOCIMOFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LKOLOODKMPF container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public KCGAOCIMOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7835840", Offset = "0x7834240", VA = "0x187835840")]
		internal JNANBHFPFOO BAAMJMGBEEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x782C4F0", Offset = "0x782AEF0", VA = "0x18782C4F0")]
	public static void JFCPBCPEPBD(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x782C4A0", Offset = "0x782AEA0", VA = "0x18782C4A0")]
	public static void BHFBIALNGNI(LKOLOODKMPF MCJDMILNGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class CFFEOFNGBIP : DEMPBLOIBON, NDGFLPMDFHK
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly RigidbodyEx JCJHLOEIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly JNANBHFPFOO BKOPOPFENPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GDNEBHBFCBF AMNPLDGGEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HGJCDLEDAPA MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly KHFKLKDMFDP[] HJEFHCFIFDN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(ECEDHFIPBHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HDFGDHKNPJK OJCADHMHMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x782B370", Offset = "0x7829D70", VA = "0x18782B370", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HDFGDHKNPJK GCHJGNBOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x78297A0", Offset = "0x78281A0", VA = "0x1878297A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 DEMELBHEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7829C70", Offset = "0x7828670", VA = "0x187829C70", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion LEFPFOMCPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x782B040", Offset = "0x7829A40", VA = "0x18782B040", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AJNFOKAANIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x782A770", Offset = "0x7829170", VA = "0x18782A770", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HDFGDHKNPJK> JAEKPGBKADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x782AB50", Offset = "0x7829550", VA = "0x18782AB50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool HBAFJJHMGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBAD050", Offset = "0xBABA50", VA = "0x180BAD050", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBB3370", Offset = "0xBB1D70", VA = "0x180BB3370", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x782B570", Offset = "0x7829F70", VA = "0x18782B570", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject OJFCLDLGCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x782B290", Offset = "0x7829C90", VA = "0x18782B290", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x782B2B0", Offset = "0x7829CB0", VA = "0x18782B2B0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid MEIMOMLEJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x782B3D0", Offset = "0x7829DD0", VA = "0x18782B3D0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CAIEGLGCBBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x782B4B0", Offset = "0x7829EB0", VA = "0x18782B4B0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JOHHJBCGBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PDOKBDIPBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x782AB00", Offset = "0x7829500", VA = "0x18782AB00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HBBMECDEDOE AOJBNECOLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x782A290", Offset = "0x7828C90", VA = "0x18782A290", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x782A2F0", Offset = "0x7828CF0", VA = "0x18782A2F0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HBBMECDEDOE NIDGBIKPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x782AA20", Offset = "0x7829420", VA = "0x18782AA20", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x782ABD0", Offset = "0x78295D0", VA = "0x18782ABD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event HBBMECDEDOE GLCFPHNJCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x782AC30", Offset = "0x7829630", VA = "0x18782AC30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x782A970", Offset = "0x7829370", VA = "0x18782A970", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event PELEMOBDHCJ CFIPFENKPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x782A7E0", Offset = "0x78291E0", VA = "0x18782A7E0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x782A880", Offset = "0x7829280", VA = "0x18782A880", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x782B190", Offset = "0x7829B90", VA = "0x18782B190")]
	public CFFEOFNGBIP(ECEDHFIPBHO OHLJFNOIPDI, RigidbodyEx JCJHLOEIIFO, GDNEBHBFCBF AMNPLDGGEHO, KHFKLKDMFDP[] HJEFHCFIFDN, HGJCDLEDAPA MPDODANMFLG, ACOCDKHPBHE BKOPOPFENPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x782A350", Offset = "0x7828D50", VA = "0x18782A350", Slot = "19")]
	public void GMJBMKIKLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "21")]
	public void AFDBFOOLCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x75C6DB0", Offset = "0x75C57B0", VA = "0x1875C6DB0", Slot = "22")]
	public void GPCPCJCLGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x782AB80", Offset = "0x7829580", VA = "0x18782AB80", Slot = "20")]
	public void MBHBHBLMGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7829FE0", Offset = "0x78289E0", VA = "0x187829FE0", Slot = "25")]
	public void CMJJOADEHFF(int JMPPAOJDMIG, HDFGDHKNPJK LHAJHKEIOAB, int LBMDILEAJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x782AF70", Offset = "0x7829970", VA = "0x18782AF70", Slot = "26")]
	public void OIGHKKHOICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x782AC90", Offset = "0x7829690", VA = "0x18782AC90", Slot = "27")]
	public void OEELHBHKNNC(int JMPPAOJDMIG, HDFGDHKNPJK GENDILBKJDE, int JIOGGGKAMKC, [Optional] Vector3? HANPHDMFJOE, [Optional] Quaternion? DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x782AA80", Offset = "0x7829480", VA = "0x18782AA80", Slot = "28")]
	public void KIAHPONEDOL(HDFGDHKNPJK GENDILBKJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7829860", Offset = "0x7828260", VA = "0x187829860", Slot = "31")]
	public void BMIKMONEGHO(Vector3 JIAFONBOEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7829CD0", Offset = "0x78286D0", VA = "0x187829CD0", Slot = "29")]
	public void CGCOHOMEACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x782A380", Offset = "0x7828D80", VA = "0x18782A380", Slot = "30")]
	public void GNOLALHGBKE(int DOAKEFBOPIA, Vector3 OBJAOKLALFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x782A6A0", Offset = "0x78290A0", VA = "0x18782A6A0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int JMPPAOJDMIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x782A570", Offset = "0x7828F70", VA = "0x18782A570", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int JMPPAOJDMIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB860A0", Offset = "0xB84AA0", VA = "0x180B860A0", Slot = "42")]
	public Color GetConnectionSlotColor(int JMPPAOJDMIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x782A1F0", Offset = "0x7828BF0", VA = "0x18782A1F0", Slot = "43")]
	public bool CanConnectTo(int JMPPAOJDMIG, HDFGDHKNPJK EGLGDFJONPO, int PDEONIHKPKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "44")]
	public void ParentChanged(int JMPPAOJDMIG, HDFGDHKNPJK OFBCOCPIEGF, int DAHHOIGOKHO, Vector3 OCNFCGKCNBE, Quaternion LKIAGMEKNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "45")]
	public void ChildAdded(int JMPPAOJDMIG, HDFGDHKNPJK MIFNOGPPAJG, int JBPEOBLCEPI, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "46")]
	public void ChildRemoved(int JMPPAOJDMIG, HDFGDHKNPJK CFHJBNCKLMO, int FHPOOLIAPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "47")]
	public void ConnectionModified(int JMPPAOJDMIG, HDFGDHKNPJK LHAJHKEIOAB, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x782B0F0", Offset = "0x7829AF0", VA = "0x18782B0F0", Slot = "48")]
	public void RootChanged(HDFGDHKNPJK BMKNDLPAFIF, HDFGDHKNPJK MJLILJKPHCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x782A9D0", Offset = "0x78293D0", VA = "0x18782A9D0", Slot = "23")]
	public void JEDHAPEAMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x782A920", Offset = "0x7829320", VA = "0x18782A920", Slot = "24")]
	public void IBLNNMHKDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x782B0A0", Offset = "0x7829AA0", VA = "0x18782B0A0")]
	private void PMOIMGDEFMB(bool LGKIBFLINEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(OHEOMMICBDN), new string[] { })]
public class MIJKFEDHIHG : OHEOMMICBDN, OMHPDBDDEHH, HDFHGFMLGCI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AAFGNAPCOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AAFGNAPCOKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[DependsOn]
	private GGNDFGLFDOH OADJGMBHLBP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object KCBNJLBMNEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x783A420", Offset = "0x7838E20", VA = "0x18783A420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x783A4B0", Offset = "0x7838EB0", VA = "0x18783A4B0", Slot = "5")]
	private void HOMBBOJBDKL(LBHNIGEPODB GNJMKKKJHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1073A10", Offset = "0x1072410", VA = "0x181073A10", Slot = "6")]
	private void MOKMDAMCMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public MIJKFEDHIHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(ACOCDKHPBHE), new string[] { "Ignore", "Mock" })]
public class KGLABBGPAGF : ACOCDKHPBHE, BLJGGMGKPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OJPFNIKDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK> OIPKDLLKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7835B00", Offset = "0x7834500", VA = "0x187835B00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7835C60", Offset = "0x7834660", VA = "0x187835C60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK> NEAGNFGIGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7835A50", Offset = "0x7834450", VA = "0x187835A50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7835BB0", Offset = "0x78345B0", VA = "0x187835BB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK, HDFGDHKNPJK> EPGODLOOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x78358F0", Offset = "0x78342F0", VA = "0x1878358F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x78359A0", Offset = "0x78343A0", VA = "0x1878359A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "26")]
	public void FCBNDJLJLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "12")]
	public void ELAEPFFNBKM(GameObject IHDAMAGFMLN, FBPCNIFMEHF LHKEBEELHCP, HDLKJEEPFBF BDAGANJGJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "13")]
	public void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "14")]
	public void BLLBFFICICF(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "15")]
	public void BAPLINGHHOO(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "16")]
	public void CEACBGOBHGL(HDFGDHKNPJK DJGPAELJDPJ, HashSet<HDFGDHKNPJK> PBOFCILFHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "17")]
	public void GEOJLGIPNDK(HDFGDHKNPJK DJGPAELJDPJ, HDFGDHKNPJK OEEJKHHMHGC, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "18")]
	public void JIMPHMLKHOA(HDFGDHKNPJK DJGPAELJDPJ, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "19")]
	public void PIFGAKOOKLP(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "20")]
	public HBPNKIEKBJJ DDEIHDAPEDO(bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070", Slot = "21")]
	public HBPNKIEKBJJ GFEAMKHJHFI(HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9F7930", Offset = "0x9F6330", VA = "0x1809F7930", Slot = "22")]
	public bool CMLFLMLOICP(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "23")]
	public void DBJFIADLFDM(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "24")]
	public void PLIBBCINMHN(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "25")]
	public void DIDHMPGLFHJ(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KGLABBGPAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HDFGDHKNPJK : NDGFLPMDFHK, IEquatable<HDFGDHKNPJK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NDGFLPMDFHK
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HDFGDHKNPJK OJCADHMHMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform GKBGOMKDLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject OJFCLDLGCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string HFKDIDMKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid MEIMOMLEJLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int CAIEGLGCBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ECEDHFIPBHO FKCNNLDLMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JOHHJBCGBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int JMPPAOJDMIG);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int JMPPAOJDMIG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int JMPPAOJDMIG);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int JMPPAOJDMIG, HDFGDHKNPJK EGLGDFJONPO, int MKDCIJBBHBK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int JMPPAOJDMIG, HDFGDHKNPJK OFBCOCPIEGF, int DAHHOIGOKHO, Vector3 OCNFCGKCNBE, Quaternion LKIAGMEKNLG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int JMPPAOJDMIG, HDFGDHKNPJK MIFNOGPPAJG, int JBPEOBLCEPI, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int JMPPAOJDMIG, HDFGDHKNPJK CFHJBNCKLMO, int FHPOOLIAPLL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int JMPPAOJDMIG, HDFGDHKNPJK LHAJHKEIOAB, int KMLJMGFPHCI, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HDFGDHKNPJK BMKNDLPAFIF, HDFGDHKNPJK MJLILJKPHCB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface ACOCDKHPBHE : BLJGGMGKPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OJPFNIKDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HDFGDHKNPJK, HDFGDHKNPJK> OIPKDLLKJDD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HDFGDHKNPJK, HDFGDHKNPJK> NEAGNFGIGIN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HDFGDHKNPJK, HDFGDHKNPJK, HDFGDHKNPJK> EPGODLOOLOO;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ELAEPFFNBKM(GameObject IHDAMAGFMLN, FBPCNIFMEHF LHKEBEELHCP, HDLKJEEPFBF FEDGKILNODD);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IPDLKHCHONO();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BLLBFFICICF(HDFGDHKNPJK DJGPAELJDPJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BAPLINGHHOO(HDFGDHKNPJK DJGPAELJDPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CEACBGOBHGL(HDFGDHKNPJK DJGPAELJDPJ, HashSet<HDFGDHKNPJK> PBOFCILFHPF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void GEOJLGIPNDK(HDFGDHKNPJK DJGPAELJDPJ, HDFGDHKNPJK OEEJKHHMHGC, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JIMPHMLKHOA(HDFGDHKNPJK DJGPAELJDPJ, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PIFGAKOOKLP(HDFGDHKNPJK DJGPAELJDPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HBPNKIEKBJJ DDEIHDAPEDO(bool MIOHNJENAMC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HBPNKIEKBJJ GFEAMKHJHFI(HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CMLFLMLOICP(CPOHCFHANCE HPKAFPMNGAI);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DBJFIADLFDM(HBPNKIEKBJJ FHMFCJGBAIP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PLIBBCINMHN(HBPNKIEKBJJ FHMFCJGBAIP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DIDHMPGLFHJ(HBPNKIEKBJJ FHMFCJGBAIP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LAEAJFANGEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HDFGDHKNPJK OFIKOCMEFFF(int AHEDOMAFPKK);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HDFGDHKNPJK EBAHAHOCBML(Guid KDFONBDLDCD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIGBDJPHMAH(HDFGDHKNPJK DJGPAELJDPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DAACMCDEBLB();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACDLAMDGFJP(HDFGDHKNPJK AMNPLDGGEHO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface HGJCDLEDAPA
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDOKBDIPBDE(GDNEBHBFCBF AMNPLDGGEHO);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBBHMPMHCDF(GDNEBHBFCBF AMNPLDGGEHO);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LFBIKOJFIEK(GDNEBHBFCBF AMNPLDGGEHO);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GFHPPBCEHNH(GDNEBHBFCBF AMNPLDGGEHO);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DBDENJJOCDL(GDNEBHBFCBF AMNPLDGGEHO);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILKNDHALFOE(GDNEBHBFCBF AMNPLDGGEHO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void HBBMECDEDOE(HDFGDHKNPJK GENDILBKJDE, int NHJOMKHMMOD, HDFGDHKNPJK LHAJHKEIOAB, int KPFHHHNHCPA, [Optional] Vector3? HANPHDMFJOE, [Optional] Quaternion? DBKLCNGPLJK);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void PELEMOBDHCJ(HDFGDHKNPJK BMKNDLPAFIF, HDFGDHKNPJK MJLILJKPHCB);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GDNEBHBFCBF : HDFGDHKNPJK, NDGFLPMDFHK, IEquatable<HDFGDHKNPJK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DEMPBLOIBON : NDGFLPMDFHK
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HDFGDHKNPJK GCHJGNBOHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HDFGDHKNPJK> JAEKPGBKADL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 DEMELBHEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion LEFPFOMCPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AJNFOKAANIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HBAFJJHMGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event HBBMECDEDOE AOJBNECOLIK;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event HBBMECDEDOE NIDGBIKPFNP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event HBBMECDEDOE GLCFPHNJCGB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event PELEMOBDHCJ CFIPFENKPNG;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GMJBMKIKLGO();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MBHBHBLMGNA();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AFDBFOOLCKM();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GPCPCJCLGLI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JEDHAPEAMGA();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IBLNNMHKDCC();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CMJJOADEHFF(int JMPPAOJDMIG, HDFGDHKNPJK LHAJHKEIOAB, int LBMDILEAJJD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OIGHKKHOICI();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OEELHBHKNNC(int JMPPAOJDMIG, HDFGDHKNPJK GENDILBKJDE, int JIOGGGKAMKC, [Optional] Vector3? HANPHDMFJOE, [Optional] Quaternion? DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void KIAHPONEDOL(HDFGDHKNPJK GENDILBKJDE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CGCOHOMEACD();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GNOLALHGBKE(int DOAKEFBOPIA, Vector3 OBJAOKLALFD);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BMIKMONEGHO(Vector3 JIAFONBOEBM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KHFKLKDMFDP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 LFNCNBGJNEL
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
public interface FBPCNIFMEHF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool FIPINNLGMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DILFIMLEJLO CAAGPPFPANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, FBPCNIFMEHF
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
			[Cpp2IlInjected.Address(RVA = "0xA45A60", Offset = "0xA44460", VA = "0x180A45A60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DILFIMLEJLO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x782C670", Offset = "0x782B070", VA = "0x18782C670")]
		public static ConnectableConfigData PIDJABAPJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x782C730", Offset = "0x782B130", VA = "0x18782C730")]
		public ConnectableConfigData(LegacyConnectableLinkVisual MLHDIFDPPDM, bool JOIEOLCNPEP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FIJEAGLAICL : IEquatable<FIJEAGLAICL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public HDFGDHKNPJK DJGPAELJDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int PICEKPEFJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int KMLJMGFPHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 HANPHDMFJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion DBKLCNGPLJK;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x782D060", Offset = "0x782BA60", VA = "0x18782D060")]
	public FIJEAGLAICL(HDFGDHKNPJK DJGPAELJDPJ, int PICEKPEFJLJ, int KMLJMGFPHCI, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x782CF40", Offset = "0x782B940", VA = "0x18782CF40")]
	public FIJEAGLAICL(HDFGDHKNPJK DJGPAELJDPJ, int PICEKPEFJLJ, int KMLJMGFPHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x782CFE0", Offset = "0x782B9E0", VA = "0x18782CFE0")]
	public FIJEAGLAICL(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x782CAD0", Offset = "0x782B4D0", VA = "0x18782CAD0", Slot = "4")]
	public bool Equals(FIJEAGLAICL OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x782CB80", Offset = "0x782B580", VA = "0x18782CB80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class BGEBLFPILMK : IMBHNBBPJJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform GBIMAJCBFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DILFIMLEJLO CDHBLCMFLJF;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x72525B0", Offset = "0x7250FB0", VA = "0x1872525B0", Slot = "4")]
	public void ELAEPFFNBKM(Transform GBIMAJCBFCJ, DILFIMLEJLO CDHBLCMFLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7829670", Offset = "0x7828070", VA = "0x187829670", Slot = "5")]
	public DILFIMLEJLO EDJHGEMNNHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7829730", Offset = "0x7828130", VA = "0x187829730", Slot = "6")]
	public void JIKHOGFFGNA(DILFIMLEJLO LNJHCGLLHMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public BGEBLFPILMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class MAIACCCJIGN : IDisposable, EJFBKBAAOJP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AIAEOLHHPAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HDFGDHKNPJK oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HDFGDHKNPJK newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public AIAEOLHHPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7829030", Offset = "0x7827A30", VA = "0x187829030")]
		internal bool KDICDKFKEIB(FCMLHCMIJCI node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly IOAHHKEHNEB GFAKDDJHNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private NEOBJJPKLBO PFIHLMODIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DEKGFEPOHJC DMPOELGMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool JOIEOLCNPEP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly LMPJBEBLCLM PNEIPJIFHEI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public FCMLHCMIJCI LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7836EA0", Offset = "0x78358A0", VA = "0x187836EA0")]
	public bool PJAIONLMHMB([In] IBOCIOOPEED DFPGGEDGGGN, bool CLFGFJFDBDH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7839980", Offset = "0x7838380", VA = "0x187839980")]
	private bool NEJACOBMPCN([In] IBOCIOOPEED DFPGGEDGGGN, bool CLFGFJFDBDH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x783A250", Offset = "0x7838C50", VA = "0x18783A250")]
	public MAIACCCJIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7837780", Offset = "0x7836180", VA = "0x187837780", Slot = "5")]
	public void ELAEPFFNBKM(ACOCDKHPBHE GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7836EB0", Offset = "0x78358B0", VA = "0x187836EB0", Slot = "17")]
	public void ABDJJIOFDNF(PKIJIODDJEL PCKPGHHEKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7838C30", Offset = "0x7837630", VA = "0x187838C30", Slot = "12")]
	public void LLFNNAILHCA(Func<HDFGDHKNPJK, bool> CCGKCDAEDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7838B00", Offset = "0x7837500", VA = "0x187838B00")]
	private void LLFNNAILHCA(IOAHHKEHNEB ABACLNNLPOO, Func<HDFGDHKNPJK, bool> CCGKCDAEDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7837AA0", Offset = "0x78364A0", VA = "0x187837AA0", Slot = "11")]
	public void FCHLGHNDCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7839F40", Offset = "0x7838940", VA = "0x187839F40", Slot = "8")]
	public bool NJLCLDOLOLH(HDFGDHKNPJK CKANMJMANKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7838150", Offset = "0x7836B50", VA = "0x187838150")]
	private bool JIJNFMLNOMG(HDFGDHKNPJK PCIFHLBKHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7837830", Offset = "0x7836230", VA = "0x187837830")]
	private static bool EMOBGNLLHFN(HDFGDHKNPJK PCIFHLBKHGO, IOAHHKEHNEB JAPKHFLIFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7838DB0", Offset = "0x78377B0", VA = "0x187838DB0")]
	private void MNFNCCOELCB(Transform JNMJIFDMKAJ, IOAHHKEHNEB MFCFODDGCGE, IOAHHKEHNEB[] GKGKEOCMDLF, HDFGDHKNPJK PHJHDIFBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7837080", Offset = "0x7835A80", VA = "0x187837080")]
	private FIJEAGLAICL BICIBCEJNOF(Transform JCFGPAMEKDF, FIJEAGLAICL KCKFGOLBLBO)
	{
		return default(FIJEAGLAICL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x78378E0", Offset = "0x78362E0", VA = "0x1878378E0")]
	private static bool FAEMEKIMAPF(IOAHHKEHNEB JAPKHFLIFNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x783A130", Offset = "0x7838B30", VA = "0x18783A130", Slot = "9")]
	public bool PAKJFLCEEEI(HDFGDHKNPJK EDHINAOKKGJ, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x78388B0", Offset = "0x78372B0", VA = "0x1878388B0")]
	private bool KEGDEBCCKIB(HDFGDHKNPJK EDHINAOKKGJ, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7837AC0", Offset = "0x78364C0", VA = "0x187837AC0")]
	private static void FMHKAHHKPOB(HDFGDHKNPJK EDHINAOKKGJ, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK, IOAHHKEHNEB HKJFJGJHKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7837D60", Offset = "0x7836760", VA = "0x187837D60")]
	private void HOBGOOMEDAL(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x78371D0", Offset = "0x7835BD0", VA = "0x1878371D0")]
	private void CAPOFCAECED(IOAHHKEHNEB ABACLNNLPOO, HDFGDHKNPJK CCJAAPCCMMC, HDFGDHKNPJK GEFPNKBJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7837240", Offset = "0x7835C40", VA = "0x187837240")]
	private void CAPOFCAECED(HDFGDHKNPJK DJGPAELJDPJ, HDFGDHKNPJK CCJAAPCCMMC, HDFGDHKNPJK GEFPNKBJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7838C40", Offset = "0x7837640", VA = "0x187838C40")]
	private void MJCGONMGHMI(HDFGDHKNPJK DJGPAELJDPJ, HDFGDHKNPJK CCJAAPCCMMC, HDFGDHKNPJK GEFPNKBJEJD, bool NMBCCNCGDEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7838CB0", Offset = "0x78376B0", VA = "0x187838CB0")]
	private void MJCGONMGHMI(IOAHHKEHNEB MHHKOMDGDID, HDFGDHKNPJK PHJHDIFBEGD, HDFGDHKNPJK MJLILJKPHCB, bool NMBCCNCGDEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7837C40", Offset = "0x7836640", VA = "0x187837C40")]
	private void HNOGFPPDMIL(HDFGDHKNPJK CGGKEPFNHFP, int JIOGGGKAMKC, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7837F50", Offset = "0x7836950", VA = "0x187837F50")]
	private void IPFCKLDPLFK(FCMLHCMIJCI HGBJMKAPAJA, FCMLHCMIJCI GEHFOIOBJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7836EE0", Offset = "0x78358E0", VA = "0x187836EE0", Slot = "18")]
	public HDFGDHKNPJK AEGFIHLPAFL(HDFGDHKNPJK DJGPAELJDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x78372B0", Offset = "0x7835CB0", VA = "0x1878372B0", Slot = "13")]
	public void CEACBGOBHGL(HDFGDHKNPJK DJGPAELJDPJ, HashSet<HDFGDHKNPJK> JIDAMBJDJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7839740", Offset = "0x7838140", VA = "0x187839740", Slot = "14")]
	public List<HDFGDHKNPJK> NEIIHMFENMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7839F50", Offset = "0x7838950", VA = "0x187839F50")]
	protected FCMLHCMIJCI OEMBGNBOOPA(FCMLHCMIJCI ABACLNNLPOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x78380B0", Offset = "0x7836AB0", VA = "0x1878380B0")]
	protected IOAHHKEHNEB[] JHIPIKHFAKK(IOAHHKEHNEB JAPKHFLIFNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x783A020", Offset = "0x7838A20", VA = "0x18783A020")]
	protected bool OMPAANKNCOF(HDFGDHKNPJK DJGPAELJDPJ, [Out] IOAHHKEHNEB ABACLNNLPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7837650", Offset = "0x7836050", VA = "0x187837650", Slot = "15")]
	public bool DHCIIBIKKMK(HDFGDHKNPJK DJGPAELJDPJ, [Out] FIJEAGLAICL HPAAICICKJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7837040", Offset = "0x7835A40", VA = "0x187837040")]
	protected IOAHHKEHNEB BHHPBOJKJNA(FIJEAGLAICL AMELFIIGBMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7838850", Offset = "0x7837250", VA = "0x187838850", Slot = "10")]
	public bool JJMIDFGNHOB(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x78391A0", Offset = "0x7837BA0", VA = "0x1878391A0")]
	private bool NAMJAMGLEPD(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7837E80", Offset = "0x7836880", VA = "0x187837E80")]
	private static bool ILHDDHPLIOJ(IOAHHKEHNEB HABAPLLDAPP, FIJEAGLAICL AHGFKAJGNHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7836EA0", Offset = "0x78358A0", VA = "0x187836EA0", Slot = "7")]
	private bool AAOKJNOCKEH([In] IBOCIOOPEED DFPGGEDGGGN, bool CLFGFJFDBDH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class INEMKJCEBDM : ACOCDKHPBHE, BLJGGMGKPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly LKOLOODKMPF MCJDMILNGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly DEKGFEPOHJC DMPOELGMLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly KJCILBJEIBK AOJIOMFIMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly ONJAFLDMGKD DHEEJHNLEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly EJFBKBAAOJP FHMFCJGBAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal NJKGOHLMPPL MPDODANMFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal HMLGMJFGLOM HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal NEOBJJPKLBO IGGJHHJNJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool JOIEOLCNPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool NKJKJFPAACB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool AEMJMBDBBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB8DB90", Offset = "0xB8C590", VA = "0x180B8DB90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x119D850", Offset = "0x119C250", VA = "0x18119D850")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool IFMEABDJOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xE9F2A0", Offset = "0xE9DCA0", VA = "0x180E9F2A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x24AAB40", Offset = "0x24A9540", VA = "0x1824AAB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OJPFNIKDIFM
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9C8410", Offset = "0x9C6E10", VA = "0x1809C8410", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK> OIPKDLLKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x782F2C0", Offset = "0x782DCC0", VA = "0x18782F2C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x782F980", Offset = "0x782E380", VA = "0x18782F980", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK> NEAGNFGIGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x782EEB0", Offset = "0x782D8B0", VA = "0x18782EEB0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x782F630", Offset = "0x782E030", VA = "0x18782F630", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HDFGDHKNPJK, HDFGDHKNPJK, HDFGDHKNPJK> EPGODLOOLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x782E5E0", Offset = "0x782CFE0", VA = "0x18782E5E0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x782EE50", Offset = "0x782D850", VA = "0x18782EE50", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x782FEA0", Offset = "0x782E8A0", VA = "0x18782FEA0")]
	public INEMKJCEBDM(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x782E780", Offset = "0x782D180", VA = "0x18782E780", Slot = "12")]
	public void ELAEPFFNBKM(GameObject IHDAMAGFMLN, FBPCNIFMEHF LHKEBEELHCP, HDLKJEEPFBF FEDGKILNODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x782ED80", Offset = "0x782D780", VA = "0x18782ED80", Slot = "26")]
	public void FCBNDJLJLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x782F470", Offset = "0x782DE70", VA = "0x18782F470", Slot = "13")]
	public void IPDLKHCHONO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x782E230", Offset = "0x782CC30", VA = "0x18782E230", Slot = "14")]
	public void BLLBFFICICF(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x782E1D0", Offset = "0x782CBD0", VA = "0x18782E1D0", Slot = "15")]
	public void BAPLINGHHOO(HDFGDHKNPJK DJGPAELJDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x782E340", Offset = "0x782CD40", VA = "0x18782E340", Slot = "22")]
	public bool CMLFLMLOICP(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x782F870", Offset = "0x782E270", VA = "0x18782F870")]
	internal bool NAMJAMGLEPD([In] IBOCIOOPEED DFPGGEDGGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x782F320", Offset = "0x782DD20", VA = "0x18782F320")]
	internal bool IDMOJOCOKKK([In] IBOCIOOPEED DFPGGEDGGGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x782F690", Offset = "0x782E090", VA = "0x18782F690")]
	internal void LNKKNDIOMCM(HDFGDHKNPJK DJGPAELJDPJ, int BINMOIKNKCH, bool CLFGFJFDBDH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x782E1D0", Offset = "0x782CBD0", VA = "0x18782E1D0")]
	internal bool CLKGMAMOIIB(HDFGDHKNPJK POOAMIKBAHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x782E640", Offset = "0x782D040", VA = "0x18782E640")]
	internal bool EIEKMGBGLMP(HDFGDHKNPJK EDHINAOKKGJ, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x782E250", Offset = "0x782CC50", VA = "0x18782E250", Slot = "16")]
	public void CEACBGOBHGL(HDFGDHKNPJK DJGPAELJDPJ, HashSet<HDFGDHKNPJK> PBOFCILFHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x782EF10", Offset = "0x782D910", VA = "0x18782EF10", Slot = "17")]
	public void GEOJLGIPNDK(HDFGDHKNPJK EDHINAOKKGJ, HDFGDHKNPJK OEEJKHHMHGC, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x782F4F0", Offset = "0x782DEF0", VA = "0x18782F4F0", Slot = "18")]
	public void JIMPHMLKHOA(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x782FC30", Offset = "0x782E630", VA = "0x18782FC30", Slot = "19")]
	public void PIFGAKOOKLP(HDFGDHKNPJK BDHMHLGFFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x782F9E0", Offset = "0x782E3E0", VA = "0x18782F9E0")]
	public void OFMFOFLCMBE([Optional] OCJFFNMJNLC FKKLIBCNCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x782E390", Offset = "0x782CD90", VA = "0x18782E390", Slot = "23")]
	public void DBJFIADLFDM(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x782E420", Offset = "0x782CE20", VA = "0x18782E420", Slot = "20")]
	public HBPNKIEKBJJ DDEIHDAPEDO(bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x782F120", Offset = "0x782DB20", VA = "0x18782F120", Slot = "21")]
	public HBPNKIEKBJJ GFEAMKHJHFI(HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x782E5A0", Offset = "0x782CFA0", VA = "0x18782E5A0", Slot = "25")]
	public void DIDHMPGLFHJ(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x782FDF0", Offset = "0x782E7F0", VA = "0x18782FDF0", Slot = "24")]
	public void PLIBBCINMHN(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class DEKGFEPOHJC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly KKHFJLAMDJE<HDFGDHKNPJK, HDFGDHKNPJK> OIPKDLLKJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly KKHFJLAMDJE<HDFGDHKNPJK, HDFGDHKNPJK> NEAGNFGIGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly EEJMHJNKCID<HDFGDHKNPJK, HDFGDHKNPJK, HDFGDHKNPJK> EPGODLOOLOO;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x782C8C0", Offset = "0x782B2C0", VA = "0x18782C8C0")]
	public DEKGFEPOHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060")]
	public void ELAEPFFNBKM(INEMKJCEBDM GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x782C7E0", Offset = "0x782B1E0", VA = "0x18782C7E0")]
	public void FMLAIMOCOMC(HDFGDHKNPJK HGBJMKAPAJA, HDFGDHKNPJK CGGKEPFNHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x782C780", Offset = "0x782B180", VA = "0x18782C780")]
	public void CDECIKHCHBL(HDFGDHKNPJK HGBJMKAPAJA, HDFGDHKNPJK CGGKEPFNHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x782C840", Offset = "0x782B240", VA = "0x18782C840")]
	public void GMHNFINNLMC(HDFGDHKNPJK ENJCJLCMMGG, HDFGDHKNPJK MGKDKKMCMAL, HDFGDHKNPJK CGGKEPFNHFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KJCILBJEIBK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private INEMKJCEBDM GIGHOMPCPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HMLGMJFGLOM HFDCCFJAOJK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KJCILBJEIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7835E30", Offset = "0x7834830", VA = "0x187835E30")]
	public void ELAEPFFNBKM(INEMKJCEBDM GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7835D10", Offset = "0x7834710", VA = "0x187835D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x78360F0", Offset = "0x7834AF0", VA = "0x1878360F0")]
	private void NBDOPCCGFMH(JKHDNFMHOCD LNFLFPBOJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7836080", Offset = "0x7834A80", VA = "0x187836080")]
	private void MKPFIJIGANH(OCJFFNMJNLC BADMLBFMHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7835D20", Offset = "0x7834720", VA = "0x187835D20")]
	public void EBEJBBEHLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7835F70", Offset = "0x7834970", VA = "0x187835F70")]
	public void HPALJGNFGDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KLBDHBCHBOM
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JCGFHOBDAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LKOLOODKMPF container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public JCGFHOBDAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7830DC0", Offset = "0x782F7C0", VA = "0x187830DC0")]
		internal INEMKJCEBDM BAAMJMGBEEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x78361B0", Offset = "0x7834BB0", VA = "0x1878361B0")]
	public static void JFCPBCPEPBD(LKOLOODKMPF MCJDMILNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7836130", Offset = "0x7834B30", VA = "0x187836130")]
	public static void BHFBIALNGNI(LKOLOODKMPF MCJDMILNGAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class IMINAKJNFBI : IDisposable, NEOBJJPKLBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, DILFIMLEJLO> KNFJNLKONBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PKIJIODDJEL IHBDOCPBFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private IMBHNBBPJJJ JEEFCHKEHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private EJFBKBAAOJP FHMFCJGBAIP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker BEKLOGEKJOF;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x782E0F0", Offset = "0x782CAF0", VA = "0x18782E0F0")]
	public IMINAKJNFBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x782DD20", Offset = "0x782C720", VA = "0x18782DD20", Slot = "7")]
	public void ELAEPFFNBKM(EJFBKBAAOJP FHMFCJGBAIP, IMBHNBBPJJJ JEEFCHKEHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x782D930", Offset = "0x782C330", VA = "0x18782D930", Slot = "5")]
	public void BCPHDBDMKNM(FCMLHCMIJCI AGNHNMOICNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x782DF20", Offset = "0x782C920", VA = "0x18782DF20", Slot = "9")]
	public void OLFJDHHMGLG(FCMLHCMIJCI OJPPJJPCIIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x782DD60", Offset = "0x782C760", VA = "0x18782DD60", Slot = "8")]
	public void JJKLDJJAMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x782D430", Offset = "0x782BE30", VA = "0x18782D430", Slot = "10")]
	public void ACGKFBCLLLO(FCMLHCMIJCI FJDMALLNCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x782D780", Offset = "0x782C180", VA = "0x18782D780", Slot = "11")]
	public void ADJAIHHIMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x782DB70", Offset = "0x782C570", VA = "0x18782DB70")]
	private bool BDIFPJEKHCH(FCMLHCMIJCI NFLJGFIFAHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class ONJAFLDMGKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct PFLKBEILJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly IOAHHKEHNEB EAEEMJMLIAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> MHMBKHBJHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly CPOHCFHANCE MDGONCCFCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly CPOHCFHANCE ABFKJMHDPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool MIOHNJENAMC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool JNFEKANECAH
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x783CE10", Offset = "0x783B810", VA = "0x18783CE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x783D6D0", Offset = "0x783C0D0", VA = "0x18783D6D0")]
		public PFLKBEILJMD(IOAHHKEHNEB EAEEMJMLIAN, HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC, [Optional] CPOHCFHANCE MDGONCCFCHI, [Optional] CPOHCFHANCE ABFKJMHDPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x783D530", Offset = "0x783BF30", VA = "0x18783D530")]
		public CPOHCFHANCE CFLEALCFLNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x783D2B0", Offset = "0x783BCB0", VA = "0x18783D2B0")]
		private CPOHCFHANCE BGMDOBIBBLP([Out] CPOHCFHANCE DMFEOGCPIOE, [Out] CPOHCFHANCE NBOPGPGJMEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x783D090", Offset = "0x783BA90", VA = "0x18783D090")]
		private CPOHCFHANCE BCCAKKLPGIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x783CF20", Offset = "0x783B920", VA = "0x18783CF20")]
		private void APINOJJCGCL(CPOHCFHANCE GFFGFMINPBA, CPOHCFHANCE NBPLHKAOABO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x783D370", Offset = "0x783BD70", VA = "0x18783D370")]
		private void CDPHFANAMLF(CPOHCFHANCE DMFEOGCPIOE, CPOHCFHANCE NBOPGPGJMEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private INEMKJCEBDM GIGHOMPCPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private EJFBKBAAOJP FHMFCJGBAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NEOBJJPKLBO PFIHLMODIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private HMLGMJFGLOM HFDCCFJAOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool NBJGLGCCIPA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LBIIPLIALKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x783B920", Offset = "0x783A320", VA = "0x18783B920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool AEMJMBDBBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x783B770", Offset = "0x783A170", VA = "0x18783B770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x783C150", Offset = "0x783AB50", VA = "0x18783C150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x783B170", Offset = "0x7839B70", VA = "0x18783B170")]
	public void ELAEPFFNBKM(INEMKJCEBDM GIGHOMPCPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x783ADE0", Offset = "0x78397E0", VA = "0x18783ADE0")]
	public HBPNKIEKBJJ DDEIHDAPEDO(bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x783B5D0", Offset = "0x7839FD0", VA = "0x18783B5D0")]
	public HBPNKIEKBJJ GFEAMKHJHFI(HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x783AD50", Offset = "0x7839750", VA = "0x18783AD50")]
	public void DBJFIADLFDM(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x783C7D0", Offset = "0x783B1D0", VA = "0x18783C7D0")]
	public void PLIBBCINMHN(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x783CB20", Offset = "0x783B520", VA = "0x18783CB20")]
	public void PPCDEPFCFDP(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x783A8C0", Offset = "0x78392C0", VA = "0x18783A8C0")]
	private void CKBJPDMKILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x783B4E0", Offset = "0x7839EE0", VA = "0x18783B4E0")]
	private CPOHCFHANCE GCMNMPIIKIE(IOAHHKEHNEB ABACLNNLPOO, bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x783C870", Offset = "0x783B270", VA = "0x18783C870")]
	private static void POBELNABPOL(IOAHHKEHNEB ABACLNNLPOO, bool MIOHNJENAMC, CPOHCFHANCE HPKAFPMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x783AF50", Offset = "0x7839950", VA = "0x18783AF50")]
	private void EIECNHJHAIH(IOAHHKEHNEB ABACLNNLPOO, bool MIOHNJENAMC, CPOHCFHANCE HPKAFPMNGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x783BF40", Offset = "0x783A940", VA = "0x18783BF40")]
	private CPOHCFHANCE MNIFGHHNPFC(IOAHHKEHNEB EAEEMJMLIAN, HashSet<Guid> MHMBKHBJHFG, bool MIOHNJENAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x783BCC0", Offset = "0x783A6C0", VA = "0x18783BCC0")]
	private bool KFHPGFFCNAK(HBPNKIEKBJJ EGFMJLFDFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x783C170", Offset = "0x783AB70", VA = "0x18783C170")]
	private bool PDFNOIOFIJJ(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x783AAA0", Offset = "0x78394A0", VA = "0x18783AAA0")]
	private bool CLINAAAPBGC(HBPNKIEKBJJ FHMFCJGBAIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x783B3D0", Offset = "0x7839DD0", VA = "0x18783B3D0")]
	private static bool FLFJLEHLFME(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x783AAC0", Offset = "0x78394C0", VA = "0x18783AAC0")]
	public static bool CMLFLMLOICP(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x783A570", Offset = "0x7838F70", VA = "0x18783A570")]
	private HDFGDHKNPJK APNIAKCJIFI(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x783BFD0", Offset = "0x783A9D0", VA = "0x18783BFD0")]
	private HDFGDHKNPJK OFIKOCMEFFF(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x783B790", Offset = "0x783A190", VA = "0x18783B790")]
	private HDFGDHKNPJK GMJODANAMOF(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7832B80", Offset = "0x7831580", VA = "0x187832B80")]
	private static Guid HGFGGOOBKLK(CPOHCFHANCE HPKAFPMNGAI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x783BBD0", Offset = "0x783A5D0", VA = "0x18783BBD0")]
	private string JPBKPLCIAHG(CPOHCFHANCE HPKAFPMNGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x783B1E0", Offset = "0x7839BE0", VA = "0x18783B1E0")]
	private bool FLBAOOFMBIH(IOAHHKEHNEB ABACLNNLPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x783B970", Offset = "0x783A370", VA = "0x18783B970")]
	private static void HBFKKKMNJCE(IOAHHKEHNEB EAEEMJMLIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public ONJAFLDMGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct IBOCIOOPEED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HDFGDHKNPJK CGGKEPFNHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HDFGDHKNPJK HGBJMKAPAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int JIOGGGKAMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int LBMDILEAJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 HANPHDMFJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion DBKLCNGPLJK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FIJEAGLAICL CDAKMHFOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x782D280", Offset = "0x782BC80", VA = "0x18782D280")]
		get
		{
			return default(FIJEAGLAICL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FIJEAGLAICL DADMKEEDHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x782D320", Offset = "0x782BD20", VA = "0x18782D320")]
		get
		{
			return default(FIJEAGLAICL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x782D350", Offset = "0x782BD50", VA = "0x18782D350")]
	public IBOCIOOPEED(HDFGDHKNPJK CGGKEPFNHFP, HDFGDHKNPJK HGBJMKAPAJA, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface EJFBKBAAOJP
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	FCMLHCMIJCI LKAEGJLGAIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELAEPFFNBKM(ACOCDKHPBHE GIGHOMPCPHH);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJAIONLMHMB([In] IBOCIOOPEED DFPGGEDGGGN, bool CLFGFJFDBDH = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NJLCLDOLOLH(HDFGDHKNPJK CKANMJMANKH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PAKJFLCEEEI(HDFGDHKNPJK EDHINAOKKGJ, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JJMIDFGNHOB(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCHLGHNDCBL();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LLFNNAILHCA(Func<HDFGDHKNPJK, bool> CCGKCDAEDBP);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CEACBGOBHGL(HDFGDHKNPJK DJGPAELJDPJ, HashSet<HDFGDHKNPJK> JIDAMBJDJEM);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HDFGDHKNPJK> NEIIHMFENMC();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DHCIIBIKKMK(HDFGDHKNPJK DJGPAELJDPJ, [Out] FIJEAGLAICL HPAAICICKJE);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ABDJJIOFDNF(PKIJIODDJEL PCKPGHHEKOC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool PKIJIODDJEL(FCMLHCMIJCI ABACLNNLPOO);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface FCMLHCMIJCI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HDFGDHKNPJK OBKFJLDCJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	FCMLHCMIJCI LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	FIJEAGLAICL EBNOKKDIJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MNDJEFGKLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DILFIMLEJLO
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCFABLNPBJM(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DNGMEKPHHIG(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCOJOKIAEBJ(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LHLBMHHIPIC(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DILFIMLEJLO Instantiate(Transform GBIMAJCBFCJ);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEJCAAOAKNK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface IMBHNBBPJJJ
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELAEPFFNBKM(Transform GBIMAJCBFCJ, DILFIMLEJLO CDHBLCMFLJF);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DILFIMLEJLO EDJHGEMNNHN();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIKHOGFFGNA(DILFIMLEJLO LNJHCGLLHMK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NJKGOHLMPPL : LAEAJFANGEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FMNHNAEAKAC();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PMODNMNBIBG(Guid HGHGJGKJMGN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NEOBJJPKLBO
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCPHDBDMKNM(FCMLHCMIJCI AGNHNMOICNH);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ELAEPFFNBKM(EJFBKBAAOJP FHMFCJGBAIP, IMBHNBBPJJJ EHLLDMJIJIN);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JJKLDJJAMIH();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLFJDHHMGLG(FCMLHCMIJCI OJPPJJPCIIF);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACGKFBCLLLO(FCMLHCMIJCI FJDMALLNCJH);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ADJAIHHIMEC();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class IOAHHKEHNEB : FCMLHCMIJCI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class LKANEJOLDJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public FIJEAGLAICL nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IOAHHKEHNEB foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LKANEJOLDJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x78363B0", Offset = "0x7834DB0", VA = "0x1878363B0")]
		internal bool GACCIPGJKIG(FCMLHCMIJCI x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private FIJEAGLAICL HPAAICICKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<IOAHHKEHNEB> OOHHONMBFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private IOAHHKEHNEB HODHJFEEPNK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FIJEAGLAICL EBNOKKDIJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x119D1E0", Offset = "0x119BBE0", VA = "0x18119D1E0", Slot = "6")]
		get
		{
			return default(FIJEAGLAICL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x119D050", Offset = "0x119BA50", VA = "0x18119D050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private IOAHHKEHNEB HGBJMKAPAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x78308C0", Offset = "0x782F2C0", VA = "0x1878308C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FCMLHCMIJCI LKNIONJKNBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HDFGDHKNPJK OBKFJLDCJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MNDJEFGKLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7830860", Offset = "0x782F260", VA = "0x187830860", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MDJFGHILPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7830870", Offset = "0x782F270", VA = "0x187830870", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected IOAHHKEHNEB MHHKOMDGDID
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7830A50", Offset = "0x782F450", VA = "0x187830A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7830D10", Offset = "0x782F710", VA = "0x187830D10")]
	public IOAHHKEHNEB(FIJEAGLAICL DKGILAFJNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7830A70", Offset = "0x782F470", VA = "0x187830A70")]
	public IOAHHKEHNEB JLIGOJPFBFL(FIJEAGLAICL PADKHJJHJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x78306E0", Offset = "0x782F0E0", VA = "0x1878306E0")]
	public IOAHHKEHNEB CNNEGEIJGHP(FIJEAGLAICL PEHKDLCCPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7830500", Offset = "0x782EF00", VA = "0x187830500")]
	public IOAHHKEHNEB CBCJJMKDJJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7830BC0", Offset = "0x782F5C0", VA = "0x187830BC0")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x78309A0", Offset = "0x782F3A0", VA = "0x1878309A0")]
	public IOAHHKEHNEB GPGMGFCHOLK(FIJEAGLAICL MGKDKKMCMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7830290", Offset = "0x782EC90", VA = "0x187830290")]
	private static void ABDJJIOFDNF(IOAHHKEHNEB BEMKJCCBIBF, PKIJIODDJEL AJHDOLGFFAB, bool AOGCHHDAMNB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x78303F0", Offset = "0x782EDF0", VA = "0x1878303F0", Slot = "9")]
	public void ABDJJIOFDNF(PKIJIODDJEL PCKPGHHEKOC, bool NMBCCNCGDEH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7830400", Offset = "0x782EE00", VA = "0x187830400")]
	public static IOAHHKEHNEB BHHPBOJKJNA(IOAHHKEHNEB BEMKJCCBIBF, FIJEAGLAICL HMOGNNPNAEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface HMLGMJFGLOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LBIIPLIALKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<JKHDNFMHOCD> NBDOPCCGFMH;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<OCJFFNMJNLC> MKPFIJIGANH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JCFABLNPBJM(INEMKJCEBDM GIGHOMPCPHH, HDLKJEEPFBF BDAGANJGJBM);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GEOJLGIPNDK(HDFGDHKNPJK EDHINAOKKGJ, HDFGDHKNPJK OEEJKHHMHGC, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JIMPHMLKHOA(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MFPIIPHMCKO(HBPNKIEKBJJ DPFJFJAEPPP, [Optional] OCJFFNMJNLC FKKLIBCNCOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class EIDHHFHMHEO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type ABBLELNBDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x782C9E0", Offset = "0x782B3E0", VA = "0x18782C9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object LALLOKGAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x782CA40", Offset = "0x782B440", VA = "0x18782CA40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x782CA80", Offset = "0x782B480", VA = "0x18782CA80")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class CGLEIHJMDDH : HMLGMJFGLOM, IDisposable, AFCPKHOLOCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private INEMKJCEBDM GIGHOMPCPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private HDLKJEEPFBF FEDGKILNODD;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LBIIPLIALKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x782B9B0", Offset = "0x782A3B0", VA = "0x18782B9B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool JMJBJHPCHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x782B840", Offset = "0x782A240", VA = "0x18782B840", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private PhotonView IJBEGIODOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x782B720", Offset = "0x782A120", VA = "0x18782B720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<JKHDNFMHOCD> NBDOPCCGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x782B7B0", Offset = "0x782A1B0", VA = "0x18782B7B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x782BD00", Offset = "0x782A700", VA = "0x18782BD00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<OCJFFNMJNLC> MKPFIJIGANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x782B630", Offset = "0x782A030", VA = "0x18782B630", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x782B590", Offset = "0x7829F90", VA = "0x18782B590", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x782BA10", Offset = "0x782A410", VA = "0x18782BA10", Slot = "10")]
	public void JCFABLNPBJM(INEMKJCEBDM GIGHOMPCPHH, HDLKJEEPFBF FEDGKILNODD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x782B6D0", Offset = "0x782A0D0", VA = "0x18782B6D0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x782B880", Offset = "0x782A280", VA = "0x18782B880", Slot = "11")]
	public void GEOJLGIPNDK(HDFGDHKNPJK EDHINAOKKGJ, HDFGDHKNPJK OEEJKHHMHGC, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x782BAA0", Offset = "0x782A4A0", VA = "0x18782BAA0", Slot = "12")]
	public void JIMPHMLKHOA(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x782BBD0", Offset = "0x782A5D0", VA = "0x18782BBD0", Slot = "13")]
	public void MFPIIPHMCKO(HBPNKIEKBJJ DPFJFJAEPPP, [Optional] OCJFFNMJNLC FKKLIBCNCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x782BFD0", Offset = "0x782A9D0", VA = "0x18782BFD0")]
	[PNCGNEFDPOJ]
	private void RpcMasterReparentNodes(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x782BDD0", Offset = "0x782A7D0", VA = "0x18782BDD0")]
	[PNCGNEFDPOJ]
	private void RpcMasterModifyNode(HDFGDHKNPJK EDHINAOKKGJ, HDFGDHKNPJK OEEJKHHMHGC, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x782C3A0", Offset = "0x782ADA0", VA = "0x18782C3A0")]
	[PNCGNEFDPOJ]
	private void RpcReparentNodes(HDFGDHKNPJK BDHMHLGFFBL, int NGLKEDDKAHJ, HDFGDHKNPJK MGKDKKMCMAL, int DAHHOIGOKHO, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK, JGLKNDJAEKA HENNFNJLPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x782C2E0", Offset = "0x782ACE0", VA = "0x18782C2E0")]
	[PNCGNEFDPOJ]
	private void RpcModifyNode(HDFGDHKNPJK EDHINAOKKGJ, int JIOGGGKAMKC, int LBMDILEAJJD, Vector3 HANPHDMFJOE, Quaternion DBKLCNGPLJK, JGLKNDJAEKA HENNFNJLPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x782BD90", Offset = "0x782A790", VA = "0x18782BD90")]
	[PNCGNEFDPOJ]
	private void RpcDeserializeConnectableGraph(HBPNKIEKBJJ FHMFCJGBAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public CGLEIHJMDDH()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DILFIMLEJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7836A20", Offset = "0x7835420", VA = "0x187836A20", Slot = "4")]
		private void PBMGKEHGFOE(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x78366E0", Offset = "0x78350E0", VA = "0x1878366E0", Slot = "5")]
		private void EIDCHGLEGHJ(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7836BA0", Offset = "0x78355A0", VA = "0x187836BA0", Slot = "6")]
		private void PFHEPJFKIHJ(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x78364F0", Offset = "0x7834EF0", VA = "0x1878364F0", Slot = "7")]
		private void EDNLKBECENF(HDFGDHKNPJK LHAJHKEIOAB, FIJEAGLAICL CGGKEPFNHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7836950", Offset = "0x7835350", VA = "0x187836950", Slot = "8")]
		private DILFIMLEJLO EIKHEFIJPIP(Transform GBIMAJCBFCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x78369C0", Offset = "0x78353C0", VA = "0x1878369C0", Slot = "9")]
		private void EOBDFNLHDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9AE050", Offset = "0x9ACA50", VA = "0x1809AE050")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NOPCHOHMJNA
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x37F37A0", Offset = "0x37F21A0", VA = "0x1837F37A0")]
	public static FBAMCBHHODK<T> JINDICAPEDP<T>(this LKOLOODKMPF MCJDMILNGAL)
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
