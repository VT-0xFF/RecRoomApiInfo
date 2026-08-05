using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x840EB10", Offset = "0x840D510", VA = "0x18840EB10", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2402EF0", Offset = "0x24018F0", VA = "0x182402EF0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84135F0", Offset = "0x8411FF0", VA = "0x1884135F0")]
		private void OFEEGALAMNF(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8413480", Offset = "0x8411E80", VA = "0x188413480")]
		private void HGLHGGKJMAE(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8413760", Offset = "0x8412160", VA = "0x188413760", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8413AA0", Offset = "0x84124A0", VA = "0x188413AA0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class EDLNNBGBNNC : AHMMOJBKLHN, AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class MEGKAGHGJEB : IEnumerable<HHPAEHKCMCF>, IEnumerable, IEnumerator<HHPAEHKCMCF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HHPAEHKCMCF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private IJNJMBEMEOM localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IJNJMBEMEOM <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EDLNNBGBNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LHOENBPGPCA <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private BKGDNKOLHBO <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BKGDNKOLHBO.AFJOOCLLNNL <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HHPAEHKCMCF System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public MEGKAGHGJEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84111A0", Offset = "0x840FBA0", VA = "0x1884111A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8410D20", Offset = "0x840F720", VA = "0x188410D20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8410D00", Offset = "0x840F700", VA = "0x188410D00")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8411080", Offset = "0x840FA80", VA = "0x188411080")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8411150", Offset = "0x840FB50", VA = "0x188411150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84110A0", Offset = "0x840FAA0", VA = "0x1884110A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HHPAEHKCMCF> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84110A0", Offset = "0x840FAA0", VA = "0x1884110A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BFGNHJJEDMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public EDLNNBGBNNC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public GCMIEOKPPGI nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BFGNHJJEDMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8401140", Offset = "0x83FFB40", VA = "0x188401140")]
		internal object KADFIJFBHAL(GCMIEOKPPGI x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MBACBBJIJFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GCMIEOKPPGI child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BFGNHJJEDMM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MBACBBJIJFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8410AB0", Offset = "0x840F4B0", VA = "0x188410AB0")]
		internal object JBHCHMKODGD((GCMIEOKPPGI child, GCMIEOKPPGI nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly OLFEOKKCIEG JNHKKPEAJDI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly OLFEOKKCIEG HJCMGAEMDED;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly OLFEOKKCIEG ADIAKDGCHCM;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly OLFEOKKCIEG CCGCAFCBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private LGMIKJJLGHL DMJPELMPIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private BBKILMFCMED KAJADHIAMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private DOOPGKEPAJL GBFBFEHDDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OAFKFNBCEHC ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private LLFKLOBKKPA HCGCAILEBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private LGBDMHJCAGD NPOHMHFHHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly FIILDCLBJJB NBEKNJIPGOI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xABA920", Offset = "0xAB9320", VA = "0x180ABA920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JMPNPOPMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF> CJOJNFMGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84026C0", Offset = "0x84010C0", VA = "0x1884026C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8401D10", Offset = "0x8400710", VA = "0x188401D10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF> FHLKKPKCKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8401F40", Offset = "0x8400940", VA = "0x188401F40", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8402160", Offset = "0x8400B60", VA = "0x188402160", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF, HHPAEHKCMCF> CKMEFKMPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8405820", Offset = "0x8404220", VA = "0x188405820", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8401700", Offset = "0x8400100", VA = "0x188401700", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x84061A0", Offset = "0x8404BA0", VA = "0x1884061A0")]
	public EDLNNBGBNNC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x8402DA0", Offset = "0x84017A0", VA = "0x188402DA0", Slot = "12")]
	public void GFALNPPLGKO(GameObject FNCBMCHNDJI, BJCFDCCCDJC IALHFPFINMH, OKJGGGOAAFN FPJMIEGHFGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x84059D0", Offset = "0x84043D0", VA = "0x1884059D0", Slot = "26")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8404790", Offset = "0x8403190", VA = "0x188404790", Slot = "22")]
	public bool KECAAHKFCCH(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8405310", Offset = "0x8403D10", VA = "0x188405310")]
	private void MGNJPHABNKA(IJNJMBEMEOM NKMAHCLJBGF, IJNJMBEMEOM BPIHCBPFOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8403030", Offset = "0x8401A30", VA = "0x188403030")]
	private void GHBNCKNJNEH(IJNJMBEMEOM NKMAHCLJBGF, IJNJMBEMEOM GCHDKHFAPMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8404170", Offset = "0x8402B70", VA = "0x188404170")]
	private void IJOGGDLFNLF(IJNJMBEMEOM NKMAHCLJBGF, IJNJMBEMEOM GCHDKHFAPMO, IJNJMBEMEOM BPIHCBPFOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8402800", Offset = "0x8401200", VA = "0x188402800")]
	private void EFKKKKFJFNC(IJNJMBEMEOM NKMAHCLJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8405520", Offset = "0x8403F20", VA = "0x188405520", Slot = "14")]
	public void NFFNLBFBLBL(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "15")]
	public void JJGBLGDOBGN(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8402350", Offset = "0x8400D50", VA = "0x188402350", Slot = "17")]
	public void COCEBKJOEPO(HHPAEHKCMCF GJKJHAMHLOA, HHPAEHKCMCF AGGICKLBDMO, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8402210", Offset = "0x8400C10", VA = "0x188402210")]
	public void COCEBKJOEPO(IJNJMBEMEOM FPJMMEGHFEH, IJNJMBEMEOM AGGICKLBDMO, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84058D0", Offset = "0x84042D0", VA = "0x1884058D0")]
	public void OADINBALMAG(HHPAEHKCMCF GJKJHAMHLOA, float OELEAGMCOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8401A70", Offset = "0x8400470", VA = "0x188401A70", Slot = "18")]
	public void BFCOGFNNHBI(HHPAEHKCMCF JLOOGDGGEPE, int EOPELHGGFBM, HHPAEHKCMCF EDDAAOKHMHO, int KIAEAFPJOOD, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84043D0", Offset = "0x8402DD0", VA = "0x1884043D0")]
	private float JADLKFBBABL(IJNJMBEMEOM FPJMMEGHFEH, IJNJMBEMEOM AEMEEJKFKNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8401BD0", Offset = "0x84005D0", VA = "0x188401BD0")]
	public void BFCOGFNNHBI(IJNJMBEMEOM FPJMMEGHFEH, IJNJMBEMEOM AEMEEJKFKNN, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON, bool NMFJAOIDLKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8401FF0", Offset = "0x84009F0", VA = "0x188401FF0", Slot = "19")]
	public void CDAOEGDNAHK(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84024B0", Offset = "0x8400EB0", VA = "0x1884024B0", Slot = "16")]
	public void DAHBEDLMDAJ(HHPAEHKCMCF GJKJHAMHLOA, HashSet<HHPAEHKCMCF> LCPAHNBPGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "20")]
	public GBFAPFIPMIB HEBIIBKCODP(bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "21")]
	public GBFAPFIPMIB ECPLGNNDFHI(HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8404720", Offset = "0x8403120", VA = "0x188404720", Slot = "23")]
	public void KDHLCCBHPMC(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8405BC0", Offset = "0x84045C0", VA = "0x188405BC0", Slot = "24")]
	public void PGOIIJHMIDI(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8403250", Offset = "0x8401C50", VA = "0x188403250", Slot = "25")]
	public void GKHEBNIFPCP(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8405C30", Offset = "0x8404630", VA = "0x188405C30")]
	private void PJPEJOFKFLD(IJNJMBEMEOM FPJMMEGHFEH, IJNJMBEMEOM AEMEEJKFKNN, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON, float OELEAGMCOIE, bool NMFJAOIDLKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8403870", Offset = "0x8402270", VA = "0x188403870")]
	private void IILHLKOJHON(IJNJMBEMEOM FPJMMEGHFEH, IJNJMBEMEOM CCBBLDBOMGE, Vector3 AIOBIOOBAEK, Quaternion ECCDGFAJEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8405960", Offset = "0x8404360", VA = "0x188405960")]
	private void OHBIINFFIIF(IJNJMBEMEOM FPJMMEGHFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8402770", Offset = "0x8401170", VA = "0x188402770")]
	[IteratorStateMachine(typeof(MEGKAGHGJEB))]
	public IEnumerable<HHPAEHKCMCF> EFAILOFHHCD(IJNJMBEMEOM EFILDLEHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8404E30", Offset = "0x8403830", VA = "0x188404E30")]
	internal HHPAEHKCMCF MEMAENLDGFM(IJNJMBEMEOM EFILDLEHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x84047E0", Offset = "0x84031E0", VA = "0x1884047E0")]
	internal IJNJMBEMEOM KKFOADNNIIP(HHPAEHKCMCF GJKJHAMHLOA)
	{
		return default(IJNJMBEMEOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x84032D0", Offset = "0x8401CD0", VA = "0x1884032D0")]
	private bool HEBFBBMFCDK(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8403270", Offset = "0x8401C70", VA = "0x188403270")]
	private bool HDALBKFEIKG(GCMIEOKPPGI ADCKJPAFCJG, [Out] HHPAEHKCMCF AEMEEJKFKNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8404F60", Offset = "0x8403960", VA = "0x188404F60")]
	private HHPAEHKCMCF MEMAENLDGFM(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8401DC0", Offset = "0x84007C0", VA = "0x188401DC0")]
	private HHPAEHKCMCF BOLMBCJIBMK(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8404C50", Offset = "0x8403650", VA = "0x188404C50")]
	private HHPAEHKCMCF LGBPDGEGCHG(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x84017B0", Offset = "0x84001B0", VA = "0x1884017B0")]
	private static Guid AEEEBGNMCBE(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8404B60", Offset = "0x8403560", VA = "0x188404B60")]
	private string LFIFHMOCIKH(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8404590", Offset = "0x8402F90", VA = "0x188404590")]
	private void KBDADGEAOGL(HHPAEHKCMCF FPJMMEGHFEH, HHPAEHKCMCF CCBBLDBOMGE, RigidTransform FPHHDIIPPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x84049D0", Offset = "0x84033D0", VA = "0x1884049D0")]
	private void KPLJNFFFIBK(HHPAEHKCMCF CCBBLDBOMGE, HHPAEHKCMCF FPJMMEGHFEH, RigidTransform FPHHDIIPPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8404970", Offset = "0x8403370", VA = "0x188404970")]
	private void KLOMCJPPLLD(HHPAEHKCMCF MMDPHPBLADN, HHPAEHKCMCF FPJMMEGHFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8402C10", Offset = "0x8401610", VA = "0x188402C10")]
	private void GDNIGNLCLKJ(HHPAEHKCMCF FPJMMEGHFEH, HHPAEHKCMCF AEMEEJKFKNN, RigidTransform FPHHDIIPPFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8404480", Offset = "0x8402E80", VA = "0x188404480")]
	private void JOFICABKKBD(IJNJMBEMEOM EFILDLEHGNL, HHPAEHKCMCF GJKJHAMHLOA, IJNJMBEMEOM GCHDKHFAPMO, IJNJMBEMEOM BPIHCBPFOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x84017F0", Offset = "0x84001F0", VA = "0x1884017F0")]
	private void AOFMIICHMJI(IJNJMBEMEOM EFILDLEHGNL, HHPAEHKCMCF GJKJHAMHLOA, HHPAEHKCMCF DCPJFGFGAIL, HHPAEHKCMCF AMFLFGLLLNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HNLEJGPAPJD
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class PEFDNJEEELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JBJKIIKOACK container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PEFDNJEEELE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84131A0", Offset = "0x8411BA0", VA = "0x1884131A0")]
		internal EDLNNBGBNNC AGFGKAPFNII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x840A6F0", Offset = "0x84090F0", VA = "0x18840A6F0")]
	public static void IOJGAAPHCDH(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x840A6A0", Offset = "0x84090A0", VA = "0x18840A6A0")]
	public static void BGGIEJDONLJ(JBJKIIKOACK KLIEGJHNGPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MAIENPDLIAI : CHOADOCIDFJ, IACJMAOGLNB
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx OPGHIHFJADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EDLNNBGBNNC IEBDGIGPKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly FJFKJFAIPAO ENMPEJHMDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly JAHDIOOLCCH ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HNNHEFGMMHM[] FBJGCGKHEJB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(IJNJMBEMEOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HHPAEHKCMCF LGLHCOMLFME
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8410890", Offset = "0x840F290", VA = "0x188410890", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HHPAEHKCMCF OBOGBBECDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84102A0", Offset = "0x840ECA0", VA = "0x1884102A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 EOMHMMIJHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x840F1B0", Offset = "0x840DBB0", VA = "0x18840F1B0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion IJGFBFFEDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x840F0B0", Offset = "0x840DAB0", VA = "0x18840F0B0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KMMDDHAJFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x840F700", Offset = "0x840E100", VA = "0x18840F700", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HHPAEHKCMCF> MLOIOGLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8410500", Offset = "0x840EF00", VA = "0x188410500", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool EBNNEHHJNOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xDD31C0", Offset = "0xDD1BC0", VA = "0x180DD31C0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8410A90", Offset = "0x840F490", VA = "0x188410A90", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject DKIONLOHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84107B0", Offset = "0x840F1B0", VA = "0x1884107B0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84107D0", Offset = "0x840F1D0", VA = "0x1884107D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid OFABONJFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84108F0", Offset = "0x840F2F0", VA = "0x1884108F0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FHPGCJDNDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84109D0", Offset = "0x840F3D0", VA = "0x1884109D0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool JICIPIJNHGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool JLMGBOEIMAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8410360", Offset = "0x840ED60", VA = "0x188410360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JBJHPLJIIBH PLNGDJHPFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x840FB50", Offset = "0x840E550", VA = "0x18840FB50", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8410450", Offset = "0x840EE50", VA = "0x188410450", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JBJHPLJIIBH NIEFOKOEJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x840F6A0", Offset = "0x840E0A0", VA = "0x18840F6A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x840FE30", Offset = "0x840E830", VA = "0x18840FE30", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JBJHPLJIIBH AHKKEKBLMEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x840FAA0", Offset = "0x840E4A0", VA = "0x18840FAA0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x840FE90", Offset = "0x840E890", VA = "0x18840FE90", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JICGJOKNNDL LKPLOHILPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84103B0", Offset = "0x840EDB0", VA = "0x1884103B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8410200", Offset = "0x840EC00", VA = "0x188410200", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x84106B0", Offset = "0x840F0B0", VA = "0x1884106B0")]
	public MAIENPDLIAI(IJNJMBEMEOM KKGNPJDBLLP, RigidbodyEx OPGHIHFJADP, FJFKJFAIPAO ENMPEJHMDCL, HNNHEFGMMHM[] FBJGCGKHEJB, JAHDIOOLCCH ADCMGLPBECA, AHMMOJBKLHN IEBDGIGPKMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x840FDB0", Offset = "0x840E7B0", VA = "0x18840FDB0", Slot = "19")]
	public void JEALAPEIAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "21")]
	public void OPPAMIKDDAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8111D20", Offset = "0x8110720", VA = "0x188111D20", Slot = "22")]
	public void MGDFAAIOIHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x840FB00", Offset = "0x840E500", VA = "0x18840FB00", Slot = "20")]
	public void GLFALCCJJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x840EEA0", Offset = "0x840D8A0", VA = "0x18840EEA0", Slot = "25")]
	public void AHIHDBEPIIJ(int LFLAFOEIDJL, HHPAEHKCMCF EDDAAOKHMHO, int DNKKAAGGMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8410530", Offset = "0x840EF30", VA = "0x188410530", Slot = "26")]
	public void POJBIIBDCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x840F7C0", Offset = "0x840E1C0", VA = "0x18840F7C0", Slot = "27")]
	public void GBNGHMPOAOO(int LFLAFOEIDJL, HHPAEHKCMCF JLOOGDGGEPE, int KNNJNIOKKIJ, [Optional] Vector3? PFFEHHLOEJF, [Optional] Quaternion? EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x840F620", Offset = "0x840E020", VA = "0x18840F620", Slot = "28")]
	public void EGBMHAALMLC(HHPAEHKCMCF JLOOGDGGEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x840F210", Offset = "0x840DC10", VA = "0x18840F210", Slot = "31")]
	public void DKFKJAADGGL(Vector3 OOFHIMMNDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x840FEF0", Offset = "0x840E8F0", VA = "0x18840FEF0", Slot = "29")]
	public void LKMDGBCIIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x840ECB0", Offset = "0x840D6B0", VA = "0x18840ECB0", Slot = "30")]
	public void AAPHNCFFCAK(int KABGMIEBEFC, Vector3 FNPMGHGMCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x840FCE0", Offset = "0x840E6E0", VA = "0x18840FCE0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int LFLAFOEIDJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x840FBB0", Offset = "0x840E5B0", VA = "0x18840FBB0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int LFLAFOEIDJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xB11E80", Offset = "0xB10880", VA = "0x180B11E80", Slot = "42")]
	public Color GetConnectionSlotColor(int LFLAFOEIDJL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x840F110", Offset = "0x840DB10", VA = "0x18840F110", Slot = "43")]
	public bool CanConnectTo(int LFLAFOEIDJL, HHPAEHKCMCF EKBBJBNGNEF, int KIGGGGLCMNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "44")]
	public void ParentChanged(int LFLAFOEIDJL, HHPAEHKCMCF AEAJDOPBFHP, int PCKNHNFNILF, Vector3 CNILBNJLAEG, Quaternion HCEMDGLPANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "45")]
	public void ChildAdded(int LFLAFOEIDJL, HHPAEHKCMCF ONLNCMMGFOC, int ELKHBBAFJPK, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "46")]
	public void ChildRemoved(int LFLAFOEIDJL, HHPAEHKCMCF DHILDNPNHGP, int PGHLBPBBCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "47")]
	public void ConnectionModified(int LFLAFOEIDJL, HHPAEHKCMCF EDDAAOKHMHO, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8410600", Offset = "0x840F000", VA = "0x188410600", Slot = "48")]
	public void RootChanged(HHPAEHKCMCF FECHHJHCIDM, HHPAEHKCMCF EBPGFCLMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x84104B0", Offset = "0x840EEB0", VA = "0x1884104B0", Slot = "23")]
	public void PABNPLBBLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x840FDE0", Offset = "0x840E7E0", VA = "0x18840FDE0", Slot = "24")]
	public void KAKEAKGFFGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x840F770", Offset = "0x840E170", VA = "0x18840F770")]
	private void FKPPACPIJDL(bool FJLKHHLGCCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(OCLKHLGLJND), new string[] { })]
public class BGFAOFMEBHH : OCLKHLGLJND, PEEGHCFEFBD, EMJENJLEJEA
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DGCLEPCMCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DGCLEPCMCAO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private APDCEAFFJDE FDFGEPPACCC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object EEDECEBKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8401200", Offset = "0x83FFC00", VA = "0x188401200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x84011B0", Offset = "0x83FFBB0", VA = "0x1884011B0", Slot = "5")]
	private void EBAJCGMAKEG(BDGILPFNAIO NBEKNJIPGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1366D10", Offset = "0x1365710", VA = "0x181366D10", Slot = "6")]
	private void DFFGDBKCJGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BGFAOFMEBHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(AHMMOJBKLHN), new string[] { "Ignore", "Mock" })]
public class PANPJKHKJOD : AHMMOJBKLHN, AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JMPNPOPMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF> CJOJNFMGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8412510", Offset = "0x8410F10", VA = "0x188412510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8412300", Offset = "0x8410D00", VA = "0x188412300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF> FHLKKPKCKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84123B0", Offset = "0x8410DB0", VA = "0x1884123B0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8412460", Offset = "0x8410E60", VA = "0x188412460", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF, HHPAEHKCMCF> CKMEFKMPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84125C0", Offset = "0x8410FC0", VA = "0x1884125C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8412250", Offset = "0x8410C50", VA = "0x188412250", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "26")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
	public void GFALNPPLGKO(GameObject FNCBMCHNDJI, BJCFDCCCDJC IALHFPFINMH, OKJGGGOAAFN GIBCNHFDFDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "14")]
	public void NFFNLBFBLBL(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "15")]
	public void JJGBLGDOBGN(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "16")]
	public void DAHBEDLMDAJ(HHPAEHKCMCF GJKJHAMHLOA, HashSet<HHPAEHKCMCF> LCPAHNBPGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "17")]
	public void COCEBKJOEPO(HHPAEHKCMCF GJKJHAMHLOA, HHPAEHKCMCF AGGICKLBDMO, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "18")]
	public void BFCOGFNNHBI(HHPAEHKCMCF GJKJHAMHLOA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "19")]
	public void CDAOEGDNAHK(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "20")]
	public GBFAPFIPMIB HEBIIBKCODP(bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "21")]
	public GBFAPFIPMIB ECPLGNNDFHI(HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "22")]
	public bool KECAAHKFCCH(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "23")]
	public void KDHLCCBHPMC(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "24")]
	public void PGOIIJHMIDI(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "25")]
	public void GKHEBNIFPCP(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PANPJKHKJOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HHPAEHKCMCF : IACJMAOGLNB, IEquatable<HHPAEHKCMCF>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IACJMAOGLNB
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HHPAEHKCMCF LGLHCOMLFME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform AJEDGAAHNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject DKIONLOHAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string DDPJMHMICBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid OFABONJFCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int FHPGCJDNDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	IJNJMBEMEOM ECPMBNENECC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JICIPIJNHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int LFLAFOEIDJL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int LFLAFOEIDJL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int LFLAFOEIDJL);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int LFLAFOEIDJL, HHPAEHKCMCF EKBBJBNGNEF, int DKBJCHGGAJE);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int LFLAFOEIDJL, HHPAEHKCMCF AEAJDOPBFHP, int PCKNHNFNILF, Vector3 CNILBNJLAEG, Quaternion HCEMDGLPANJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int LFLAFOEIDJL, HHPAEHKCMCF ONLNCMMGFOC, int ELKHBBAFJPK, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int LFLAFOEIDJL, HHPAEHKCMCF DHILDNPNHGP, int PGHLBPBBCGB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int LFLAFOEIDJL, HHPAEHKCMCF EDDAAOKHMHO, int MNOJAFHFIHG, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HHPAEHKCMCF FECHHJHCIDM, HHPAEHKCMCF EBPGFCLMNGA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface AHMMOJBKLHN : AOOPFNOOKFO
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool JMPNPOPMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HHPAEHKCMCF, HHPAEHKCMCF> CJOJNFMGLHP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HHPAEHKCMCF, HHPAEHKCMCF> FHLKKPKCKJB;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HHPAEHKCMCF, HHPAEHKCMCF, HHPAEHKCMCF> CKMEFKMPKLH;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GFALNPPLGKO(GameObject FNCBMCHNDJI, BJCFDCCCDJC IALHFPFINMH, OKJGGGOAAFN HJKLBLDJBCI);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DBIPLKHEHMB();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NFFNLBFBLBL(HHPAEHKCMCF GJKJHAMHLOA);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JJGBLGDOBGN(HHPAEHKCMCF GJKJHAMHLOA);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DAHBEDLMDAJ(HHPAEHKCMCF GJKJHAMHLOA, HashSet<HHPAEHKCMCF> LCPAHNBPGMM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void COCEBKJOEPO(HHPAEHKCMCF GJKJHAMHLOA, HHPAEHKCMCF AGGICKLBDMO, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BFCOGFNNHBI(HHPAEHKCMCF GJKJHAMHLOA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CDAOEGDNAHK(HHPAEHKCMCF GJKJHAMHLOA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GBFAPFIPMIB HEBIIBKCODP(bool LJGMEOGMFEE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	GBFAPFIPMIB ECPLGNNDFHI(HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KECAAHKFCCH(GCMIEOKPPGI ADCKJPAFCJG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KDHLCCBHPMC(GBFAPFIPMIB HNPPIOOOPNL);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PGOIIJHMIDI(GBFAPFIPMIB HNPPIOOOPNL);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GKHEBNIFPCP(GBFAPFIPMIB HNPPIOOOPNL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OAFKFNBCEHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HHPAEHKCMCF LGBPDGEGCHG(int KHJLFNFMIIH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HHPAEHKCMCF BOLMBCJIBMK(Guid EKFNMMGLDBE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ACCIFMNDPHB(HHPAEHKCMCF GJKJHAMHLOA);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JAMICJHKDNH();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOKLNGILDHG(HHPAEHKCMCF ENMPEJHMDCL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface JAHDIOOLCCH
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLMGBOEIMAL(FJFKJFAIPAO ENMPEJHMDCL);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JOBKJINHAAK(FJFKJFAIPAO ENMPEJHMDCL);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string NHGONELCODL(FJFKJFAIPAO ENMPEJHMDCL);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CGHPKINIDON(FJFKJFAIPAO ENMPEJHMDCL);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ODBGAFPFFPK(FJFKJFAIPAO ENMPEJHMDCL);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JJLIMOFKLIN(FJFKJFAIPAO ENMPEJHMDCL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void JBJHPLJIIBH(HHPAEHKCMCF JLOOGDGGEPE, int DNNFOIJCHOC, HHPAEHKCMCF EDDAAOKHMHO, int BEAKIAILPKO, [Optional] Vector3? PFFEHHLOEJF, [Optional] Quaternion? EJIAAHNMHLL);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JICGJOKNNDL(HHPAEHKCMCF FECHHJHCIDM, HHPAEHKCMCF EBPGFCLMNGA);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FJFKJFAIPAO : HHPAEHKCMCF, IACJMAOGLNB, IEquatable<HHPAEHKCMCF>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CHOADOCIDFJ : IACJMAOGLNB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HHPAEHKCMCF OBOGBBECDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HHPAEHKCMCF> MLOIOGLBGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 EOMHMMIJHIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion IJGFBFFEDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool KMMDDHAJFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EBNNEHHJNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JBJHPLJIIBH PLNGDJHPFIC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event JBJHPLJIIBH NIEFOKOEJNF;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event JBJHPLJIIBH AHKKEKBLMEI;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JICGJOKNNDL LKPLOHILPDB;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JEALAPEIAJO();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GLFALCCJJDG();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OPPAMIKDDAI();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MGDFAAIOIHB();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PABNPLBBLIE();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KAKEAKGFFGF();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void AHIHDBEPIIJ(int LFLAFOEIDJL, HHPAEHKCMCF EDDAAOKHMHO, int DNKKAAGGMPL);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void POJBIIBDCNK();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GBNGHMPOAOO(int LFLAFOEIDJL, HHPAEHKCMCF JLOOGDGGEPE, int KNNJNIOKKIJ, [Optional] Vector3? PFFEHHLOEJF, [Optional] Quaternion? EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EGBMHAALMLC(HHPAEHKCMCF JLOOGDGGEPE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LKMDGBCIIFH();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AAPHNCFFCAK(int KABGMIEBEFC, Vector3 FNPMGHGMCGE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DKFKJAADGGL(Vector3 OOFHIMMNDGB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HNNHEFGMMHM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 PCLOHAGOMAP
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
public interface BJCFDCCCDJC
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CKIMFAAGCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	AJLOENGFMPO LEFAKMDHNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, BJCFDCCCDJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public AJLOENGFMPO LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84015F0", Offset = "0x83FFFF0", VA = "0x1884015F0")]
		public static ConnectableConfigData FHJDLLMGHNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x84016B0", Offset = "0x84000B0", VA = "0x1884016B0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual LBEDKCPIMHK, bool KHPMOPPGHHF)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct ACOJPGCKDBL : IEquatable<ACOJPGCKDBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HHPAEHKCMCF GJKJHAMHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int CKOENHFPFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int MNOJAFHFIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 PFFEHHLOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion EJIAAHNMHLL;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x83FEDF0", Offset = "0x83FD7F0", VA = "0x1883FEDF0")]
	public ACOJPGCKDBL(HHPAEHKCMCF GJKJHAMHLOA, int CKOENHFPFNP, int MNOJAFHFIHG, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x83FEEE0", Offset = "0x83FD8E0", VA = "0x1883FEEE0")]
	public ACOJPGCKDBL(HHPAEHKCMCF GJKJHAMHLOA, int CKOENHFPFNP, int MNOJAFHFIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x83FEE50", Offset = "0x83FD850", VA = "0x1883FEE50")]
	public ACOJPGCKDBL(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x83FE980", Offset = "0x83FD380", VA = "0x1883FE980", Slot = "4")]
	public bool Equals(ACOJPGCKDBL GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x83FEA30", Offset = "0x83FD430", VA = "0x1883FEA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class JFJODBLHIFG : ELGCPFFKNDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform HALOMIKDIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private AJLOENGFMPO EPKGNIPOEEL;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7D7D4C0", Offset = "0x7D7BEC0", VA = "0x187D7D4C0", Slot = "4")]
	public void GFALNPPLGKO(Transform HALOMIKDIAH, AJLOENGFMPO EPKGNIPOEEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x840AC30", Offset = "0x8409630", VA = "0x18840AC30", Slot = "5")]
	public AJLOENGFMPO JMMPMMOLPIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x840ACF0", Offset = "0x84096F0", VA = "0x18840ACF0", Slot = "6")]
	public void MGMBFKFKIIO(AJLOENGFMPO IOOGIKGCIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JFJODBLHIFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JMBLELOBGEB : IDisposable, MMGPOPKBFLN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IDOJLLAOGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HHPAEHKCMCF oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HHPAEHKCMCF newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IDOJLLAOGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x840A870", Offset = "0x8409270", VA = "0x18840A870")]
		internal bool KIAGHJGEMEL(IHEPHLEJEED node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly PCCLDEJFBPE NCJDFJKPCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private KPCCOIABNPL IOBGLICCFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MPHEJDGJJJG LEDABCFBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool KHPMOPPGHHF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly OLFEOKKCIEG DFMIEGIOLMH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IHEPHLEJEED GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x840C6C0", Offset = "0x840B0C0", VA = "0x18840C6C0")]
	public bool FGGODCIPEOB([In] HDFNECGDCJM BLPDDGCLNPE, bool LPJEIEEOPNL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x840AD60", Offset = "0x8409760", VA = "0x18840AD60")]
	private bool AAIDOAFINCJ([In] HDFNECGDCJM BLPDDGCLNPE, bool LPJEIEEOPNL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x840E130", Offset = "0x840CB30", VA = "0x18840E130")]
	public JMBLELOBGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x840C780", Offset = "0x840B180", VA = "0x18840C780", Slot = "5")]
	public void GFALNPPLGKO(AHMMOJBKLHN KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x840B910", Offset = "0x840A310", VA = "0x18840B910", Slot = "17")]
	public void CLJLCHGCIGL(IEKEBEOHMMO AEPCPKCINPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x840DF20", Offset = "0x840C920", VA = "0x18840DF20", Slot = "12")]
	public void OONPCGOFAAG(Func<HHPAEHKCMCF, bool> FDBEAKIOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x840DF30", Offset = "0x840C930", VA = "0x18840DF30")]
	private void OONPCGOFAAG(PCCLDEJFBPE MNHKIMAOFNO, Func<HHPAEHKCMCF, bool> FDBEAKIOHLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x840C460", Offset = "0x840AE60", VA = "0x18840C460", Slot = "11")]
	public void EBMIOOCCGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x840C6B0", Offset = "0x840B0B0", VA = "0x18840C6B0", Slot = "8")]
	public bool FGAFONOINPI(HHPAEHKCMCF DFJHFDOPCFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x840CBD0", Offset = "0x840B5D0", VA = "0x18840CBD0")]
	private bool KCFCAAFIGFE(HHPAEHKCMCF DKHFGIGBJDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x840C6D0", Offset = "0x840B0D0", VA = "0x18840C6D0")]
	private static bool FPBBGHKDGFF(HHPAEHKCMCF DKHFGIGBJDF, PCCLDEJFBPE OGMDPDIDPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x840D6D0", Offset = "0x840C0D0", VA = "0x18840D6D0")]
	private void LPBDKCLGIJO(Transform HNONDEIMFCI, PCCLDEJFBPE IFEFPAHNMMM, PCCLDEJFBPE[] LNDLAMIHEIK, HHPAEHKCMCF LNNKFPPKBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x840B320", Offset = "0x8409D20", VA = "0x18840B320")]
	private ACOJPGCKDBL ADDNBMHFBHM(Transform DLJGBMHLEEG, ACOJPGCKDBL LOOMHABNNIG)
	{
		return default(ACOJPGCKDBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x840DB20", Offset = "0x840C520", VA = "0x18840DB20")]
	private static bool OIGNLFLKNOD(PCCLDEJFBPE OGMDPDIDPDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x840C940", Offset = "0x840B340", VA = "0x18840C940", Slot = "9")]
	public bool HFKAAHKIHPI(HHPAEHKCMCF GFKFABOANPF, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x840B6C0", Offset = "0x840A0C0", VA = "0x18840B6C0")]
	private bool BHPAFEBBJHL(HHPAEHKCMCF GFKFABOANPF, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x840D550", Offset = "0x840BF50", VA = "0x18840D550")]
	private static void LAICNFHLDGB(HHPAEHKCMCF GFKFABOANPF, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL, PCCLDEJFBPE HBDHLLJCICM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x840CAB0", Offset = "0x840B4B0", VA = "0x18840CAB0")]
	private void KBDADGEAOGL(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x840B470", Offset = "0x8409E70", VA = "0x18840B470")]
	private void AKNBHNOGAOA(PCCLDEJFBPE MNHKIMAOFNO, HHPAEHKCMCF DCPJFGFGAIL, HHPAEHKCMCF AMFLFGLLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x840B4E0", Offset = "0x8409EE0", VA = "0x18840B4E0")]
	private void AKNBHNOGAOA(HHPAEHKCMCF GJKJHAMHLOA, HHPAEHKCMCF DCPJFGFGAIL, HHPAEHKCMCF AMFLFGLLLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x840B650", Offset = "0x840A050", VA = "0x18840B650")]
	private void AOFMIICHMJI(HHPAEHKCMCF GJKJHAMHLOA, HHPAEHKCMCF DCPJFGFGAIL, HHPAEHKCMCF AMFLFGLLLNF, bool HDCFEKHDKHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x840B550", Offset = "0x8409F50", VA = "0x18840B550")]
	private void AOFMIICHMJI(PCCLDEJFBPE FAIGKPPBFHA, HHPAEHKCMCF LNNKFPPKBMM, HHPAEHKCMCF EBPGFCLMNGA, bool HDCFEKHDKHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x840D430", Offset = "0x840BE30", VA = "0x18840D430")]
	private void KPLJNFFFIBK(HHPAEHKCMCF FPJMMEGHFEH, int KNNJNIOKKIJ, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x840D2D0", Offset = "0x840BCD0", VA = "0x18840D2D0")]
	private void KLOMCJPPLLD(IHEPHLEJEED AEMEEJKFKNN, IHEPHLEJEED PJBMHKMINDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x840C480", Offset = "0x840AE80", VA = "0x18840C480", Slot = "18")]
	public HHPAEHKCMCF EDKLIEKLIPF(HHPAEHKCMCF GJKJHAMHLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x840BF80", Offset = "0x840A980", VA = "0x18840BF80", Slot = "13")]
	public void DAHBEDLMDAJ(HHPAEHKCMCF GJKJHAMHLOA, HashSet<HHPAEHKCMCF> AIHDEPJAPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x840DCE0", Offset = "0x840C6E0", VA = "0x18840DCE0", Slot = "14")]
	public List<HHPAEHKCMCF> ONMKLDEODHJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x840C5E0", Offset = "0x840AFE0", VA = "0x18840C5E0")]
	protected IHEPHLEJEED EIHHCOKIEBO(IHEPHLEJEED MNHKIMAOFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x840BEE0", Offset = "0x840A8E0", VA = "0x18840BEE0")]
	protected PCCLDEJFBPE[] DAAKJLOKGFJ(PCCLDEJFBPE OGMDPDIDPDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x840C830", Offset = "0x840B230", VA = "0x18840C830")]
	protected bool HCDOEFCNBAG(HHPAEHKCMCF GJKJHAMHLOA, [Out] PCCLDEJFBPE MNHKIMAOFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x840C330", Offset = "0x840AD30", VA = "0x18840C330", Slot = "15")]
	public bool DEFNCPKDJDA(HHPAEHKCMCF GJKJHAMHLOA, [Out] ACOJPGCKDBL DNOHIEFBPAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x840C9A0", Offset = "0x840B3A0", VA = "0x18840C9A0")]
	protected PCCLDEJFBPE IMOCGILMLIK(ACOJPGCKDBL ELNGAFJOCDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x840DAC0", Offset = "0x840C4C0", VA = "0x18840DAC0", Slot = "10")]
	public bool NFBCNLHIPHE(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x840B940", Offset = "0x840A340", VA = "0x18840B940")]
	private bool COBBOGDBBCI(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x840C9E0", Offset = "0x840B3E0", VA = "0x18840C9E0")]
	private static bool JBPOPKLLAOH(PCCLDEJFBPE BKHMDNNILMN, ACOJPGCKDBL OJMHOBMMFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x840C6C0", Offset = "0x840B0C0", VA = "0x18840C6C0", Slot = "7")]
	private bool OEPFGJADBJM([In] HDFNECGDCJM BLPDDGCLNPE, bool LPJEIEEOPNL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class ANBOOAPNFCA : AHMMOJBKLHN, AOOPFNOOKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly JBJKIIKOACK KLIEGJHNGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly MPHEJDGJJJG LEDABCFBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly EIEHCAOJMEC HKIDFANONME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly EHKJDICOICH BPMBJEPAAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly MMGPOPKBFLN HNPPIOOOPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal DDFGBOEFLCD ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal POFFMOLDGHP EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal KPCCOIABNPL EALMCGFIDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool KHPMOPPGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool MHJPFKGNIPC;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OCPPDCKCMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xB00350", Offset = "0xAFED50", VA = "0x180B00350")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xB00360", Offset = "0xAFED60", VA = "0x180B00360")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7A0", Offset = "0xB2E1A0", VA = "0x180B2F7A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xB2F860", Offset = "0xB2E260", VA = "0x180B2F860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JMPNPOPMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF> CJOJNFMGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x83FFAE0", Offset = "0x83FE4E0", VA = "0x1883FFAE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x83FF370", Offset = "0x83FDD70", VA = "0x1883FF370", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF> FHLKKPKCKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x83FF3D0", Offset = "0x83FDDD0", VA = "0x1883FF3D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x83FF5F0", Offset = "0x83FDFF0", VA = "0x1883FF5F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HHPAEHKCMCF, HHPAEHKCMCF, HHPAEHKCMCF> CKMEFKMPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8400A70", Offset = "0x83FF470", VA = "0x188400A70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x83FEF80", Offset = "0x83FD980", VA = "0x1883FEF80", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8400C50", Offset = "0x83FF650", VA = "0x188400C50")]
	public ANBOOAPNFCA(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x83FFE30", Offset = "0x83FE830", VA = "0x1883FFE30", Slot = "12")]
	public void GFALNPPLGKO(GameObject FNCBMCHNDJI, BJCFDCCCDJC IALHFPFINMH, OKJGGGOAAFN HJKLBLDJBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8400AD0", Offset = "0x83FF4D0", VA = "0x188400AD0", Slot = "26")]
	public void PFOGGBNCDDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x83FFA60", Offset = "0x83FE460", VA = "0x1883FFA60", Slot = "13")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8400A50", Offset = "0x83FF450", VA = "0x188400A50", Slot = "14")]
	public void NFFNLBFBLBL(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x84007D0", Offset = "0x83FF1D0", VA = "0x1884007D0", Slot = "15")]
	public void JJGBLGDOBGN(HHPAEHKCMCF GJKJHAMHLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x84008C0", Offset = "0x83FF2C0", VA = "0x1884008C0", Slot = "22")]
	public bool KECAAHKFCCH(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x83FF650", Offset = "0x83FE050", VA = "0x1883FF650")]
	internal bool COBBOGDBBCI([In] HDFNECGDCJM BLPDDGCLNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x83FFB40", Offset = "0x83FE540", VA = "0x1883FFB40")]
	internal bool DPHJABINAPA([In] HDFNECGDCJM BLPDDGCLNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x84005F0", Offset = "0x83FEFF0", VA = "0x1884005F0")]
	internal void JEKAJNLOEMK(HHPAEHKCMCF GJKJHAMHLOA, int NGKPBKNNDLF, bool LPJEIEEOPNL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x84007D0", Offset = "0x83FF1D0", VA = "0x1884007D0")]
	internal bool MMAPNHPBDPH(HHPAEHKCMCF JJLACJPCILE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8400910", Offset = "0x83FF310", VA = "0x188400910")]
	internal bool LKCELGDBKLB(HHPAEHKCMCF GFKFABOANPF, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x83FF970", Offset = "0x83FE370", VA = "0x1883FF970", Slot = "16")]
	public void DAHBEDLMDAJ(HHPAEHKCMCF GJKJHAMHLOA, HashSet<HHPAEHKCMCF> LCPAHNBPGMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x83FF760", Offset = "0x83FE160", VA = "0x1883FF760", Slot = "17")]
	public void COCEBKJOEPO(HHPAEHKCMCF GFKFABOANPF, HHPAEHKCMCF AGGICKLBDMO, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x83FF230", Offset = "0x83FDC30", VA = "0x1883FF230", Slot = "18")]
	public void BFCOGFNNHBI(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x83FF430", Offset = "0x83FDE30", VA = "0x1883FF430", Slot = "19")]
	public void CDAOEGDNAHK(HHPAEHKCMCF MDAEGCHGBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x83FEFE0", Offset = "0x83FD9E0", VA = "0x1883FEFE0")]
	public void ALLOLDHEDEC([Optional] FNAEIBBBBBE IFAOOLBLKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8400830", Offset = "0x83FF230", VA = "0x188400830", Slot = "23")]
	public void KDHLCCBHPMC(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8400470", Offset = "0x83FEE70", VA = "0x188400470", Slot = "20")]
	public GBFAPFIPMIB HEBIIBKCODP(bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x83FFC90", Offset = "0x83FE690", VA = "0x1883FFC90", Slot = "21")]
	public GBFAPFIPMIB ECPLGNNDFHI(HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8400430", Offset = "0x83FEE30", VA = "0x188400430", Slot = "25")]
	public void GKHEBNIFPCP(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8400BA0", Offset = "0x83FF5A0", VA = "0x188400BA0", Slot = "24")]
	public void PGOIIJHMIDI(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class MPHEJDGJJJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FONIFJMDCJB<HHPAEHKCMCF, HHPAEHKCMCF> CJOJNFMGLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FONIFJMDCJB<HHPAEHKCMCF, HHPAEHKCMCF> FHLKKPKCKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly KPOLDAAHPLJ<HHPAEHKCMCF, HHPAEHKCMCF, HHPAEHKCMCF> CKMEFKMPKLH;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x84113C0", Offset = "0x840FDC0", VA = "0x1884113C0")]
	public MPHEJDGJJJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	public void GFALNPPLGKO(ANBOOAPNFCA KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x84112E0", Offset = "0x840FCE0", VA = "0x1884112E0")]
	public void LEOMNFHOAME(HHPAEHKCMCF AEMEEJKFKNN, HHPAEHKCMCF FPJMMEGHFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8411280", Offset = "0x840FC80", VA = "0x188411280")]
	public void GFIIBIENKJM(HHPAEHKCMCF AEMEEJKFKNN, HHPAEHKCMCF FPJMMEGHFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8411340", Offset = "0x840FD40", VA = "0x188411340")]
	public void LKKAABBPGOP(HHPAEHKCMCF MMDPHPBLADN, HHPAEHKCMCF CCBBLDBOMGE, HHPAEHKCMCF FPJMMEGHFEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class EIEHCAOJMEC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private ANBOOAPNFCA KFMMGFEJHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private POFFMOLDGHP EHCDEMFECBB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EIEHCAOJMEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x84089A0", Offset = "0x84073A0", VA = "0x1884089A0")]
	public void GFALNPPLGKO(ANBOOAPNFCA KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8408880", Offset = "0x8407280", VA = "0x188408880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8408AE0", Offset = "0x84074E0", VA = "0x188408AE0")]
	private void ICBEEOMBAPD(AFPDBFALGFB MCNJLDELGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8408B20", Offset = "0x8407520", VA = "0x188408B20")]
	private void LBGOLLLEDMC(FNAEIBBBBBE ABEOEBEFJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8408B90", Offset = "0x8407590", VA = "0x188408B90")]
	public void NOKIKIDNKFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x8408890", Offset = "0x8407290", VA = "0x188408890")]
	public void FGFDNMEKIML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CFMPLIPHKDO
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CPMHLICCNOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JBJKIIKOACK container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CPMHLICCNOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8401580", Offset = "0x83FFF80", VA = "0x188401580")]
		internal ANBOOAPNFCA AGFGKAPFNII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8401380", Offset = "0x83FFD80", VA = "0x188401380")]
	public static void IOJGAAPHCDH(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8401300", Offset = "0x83FFD00", VA = "0x188401300")]
	public static void BGGIEJDONLJ(JBJKIIKOACK KLIEGJHNGPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class NLOMJEKANFG : IDisposable, KPCCOIABNPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, AJLOENGFMPO> DPCKAPGBDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly IEKEBEOHMMO HPILOGHEJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ELGCPFFKNDA HAFACPIKFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private MMGPOPKBFLN HNPPIOOOPNL;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker EOEAFJNMBFB;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8412170", Offset = "0x8410B70", VA = "0x188412170")]
	public NLOMJEKANFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8411C30", Offset = "0x8410630", VA = "0x188411C30", Slot = "7")]
	public void GFALNPPLGKO(MMGPOPKBFLN HNPPIOOOPNL, ELGCPFFKNDA HAFACPIKFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x84119F0", Offset = "0x84103F0", VA = "0x1884119F0", Slot = "5")]
	public void FEMKIDFKEHE(IHEPHLEJEED IDIHOAPJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8411FA0", Offset = "0x84109A0", VA = "0x188411FA0", Slot = "9")]
	public void LFIABFOCCFG(IHEPHLEJEED LHNBHDFKEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x84114E0", Offset = "0x840FEE0", VA = "0x1884114E0", Slot = "8")]
	public void BCNNMGAHKDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x84116A0", Offset = "0x84100A0", VA = "0x1884116A0", Slot = "10")]
	public void BELNINELIHO(IHEPHLEJEED AEFHNOHOPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8411C70", Offset = "0x8410670", VA = "0x188411C70", Slot = "11")]
	public void GGLKOBCKMBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8411DF0", Offset = "0x84107F0", VA = "0x188411DF0")]
	private bool HOAJNGEKFAG(IHEPHLEJEED AFDFHFKFCKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class EHKJDICOICH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct HGCHJGCLPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly PCCLDEJFBPE LHAGHJCACPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> MFAMGNHENEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly GCMIEOKPPGI IEDMKAKMPMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly GCMIEOKPPGI BAOEMHKEPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool LJGMEOGMFEE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool KGJHBPKDDLD
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8409D70", Offset = "0x8408770", VA = "0x188409D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x840A630", Offset = "0x8409030", VA = "0x18840A630")]
		public HGCHJGCLPHJ(PCCLDEJFBPE LHAGHJCACPG, HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE, [Optional] GCMIEOKPPGI IEDMKAKMPMB, [Optional] GCMIEOKPPGI BAOEMHKEPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x840A040", Offset = "0x8408A40", VA = "0x18840A040")]
		public GCMIEOKPPGI GCGCKFHBJPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x840A570", Offset = "0x8408F70", VA = "0x18840A570")]
		private GCMIEOKPPGI KPNJGHNJGME([Out] GCMIEOKPPGI JHHHLLKAMBE, [Out] GCMIEOKPPGI OFJDBHBLIMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x840A350", Offset = "0x8408D50", VA = "0x18840A350")]
		private GCMIEOKPPGI IPAODAFEDBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x840A1E0", Offset = "0x8408BE0", VA = "0x18840A1E0")]
		private void GFCEFLLLIPN(GCMIEOKPPGI KMNAJAPOEHL, GCMIEOKPPGI CEMFAGDCAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8409E80", Offset = "0x8408880", VA = "0x188409E80")]
		private void FJBEHHAMOKB(GCMIEOKPPGI JHHHLLKAMBE, GCMIEOKPPGI OFJDBHBLIMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private ANBOOAPNFCA KFMMGFEJHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MMGPOPKBFLN HNPPIOOOPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private KPCCOIABNPL IOBGLICCFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private POFFMOLDGHP EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool BPEGNECHGKG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KIJCGGAJKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8406CA0", Offset = "0x84056A0", VA = "0x188406CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool OCPPDCKCMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x84084A0", Offset = "0x8406EA0", VA = "0x1884084A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8406CF0", Offset = "0x84056F0", VA = "0x188406CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8406F90", Offset = "0x8405990", VA = "0x188406F90")]
	public void GFALNPPLGKO(ANBOOAPNFCA KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8407670", Offset = "0x8406070", VA = "0x188407670")]
	public GBFAPFIPMIB HEBIIBKCODP(bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8406B00", Offset = "0x8405500", VA = "0x188406B00")]
	public GBFAPFIPMIB ECPLGNNDFHI(HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x8407AD0", Offset = "0x84064D0", VA = "0x188407AD0")]
	public void KDHLCCBHPMC(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8408770", Offset = "0x8407170", VA = "0x188408770")]
	public void PGOIIJHMIDI(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8406210", Offset = "0x8404C10", VA = "0x188406210")]
	public void BEHMMMOCDCA(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8406360", Offset = "0x8404D60", VA = "0x188406360")]
	private void CCNAIPFHLJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8408060", Offset = "0x8406A60", VA = "0x188408060")]
	private GCMIEOKPPGI MAPCGMIPNEJ(PCCLDEJFBPE MNHKIMAOFNO, bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x84084C0", Offset = "0x8406EC0", VA = "0x1884084C0")]
	private static void NPHCIFCKLOM(PCCLDEJFBPE MNHKIMAOFNO, bool LJGMEOGMFEE, GCMIEOKPPGI ADCKJPAFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x84066D0", Offset = "0x84050D0", VA = "0x1884066D0")]
	private void CMGONGLONMH(PCCLDEJFBPE MNHKIMAOFNO, bool LJGMEOGMFEE, GCMIEOKPPGI ADCKJPAFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x84077E0", Offset = "0x84061E0", VA = "0x1884077E0")]
	private GCMIEOKPPGI JBGBJHMJKHA(PCCLDEJFBPE LHAGHJCACPG, HashSet<Guid> MFAMGNHENEM, bool LJGMEOGMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x8406D10", Offset = "0x8405710", VA = "0x188406D10")]
	private bool FDPCKGCDBKI(GBFAPFIPMIB HKJGLGIGIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x8407000", Offset = "0x8405A00", VA = "0x188407000")]
	private bool HEBFBBMFCDK(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8406AE0", Offset = "0x84054E0", VA = "0x188406AE0")]
	private bool DDJHFAGIEEC(GBFAPFIPMIB HNPPIOOOPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x8406240", Offset = "0x8404C40", VA = "0x188406240")]
	private static bool BPPOHMBGMGB(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x8407B60", Offset = "0x8406560", VA = "0x188407B60")]
	public static bool KECAAHKFCCH(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8408150", Offset = "0x8406B50", VA = "0x188408150")]
	private HHPAEHKCMCF MEMAENLDGFM(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x8407EE0", Offset = "0x84068E0", VA = "0x188407EE0")]
	private HHPAEHKCMCF LGBPDGEGCHG(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x8406540", Offset = "0x8404F40", VA = "0x188406540")]
	private HHPAEHKCMCF CEAPCCIMLID(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x84017B0", Offset = "0x84001B0", VA = "0x1884017B0")]
	private static Guid AEEEBGNMCBE(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x8407DF0", Offset = "0x84067F0", VA = "0x188407DF0")]
	private string LFIFHMOCIKH(GCMIEOKPPGI ADCKJPAFCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x84068F0", Offset = "0x84052F0", VA = "0x1884068F0")]
	private bool CNMFKCEGCED(PCCLDEJFBPE MNHKIMAOFNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8407870", Offset = "0x8406270", VA = "0x188407870")]
	private static void KAOIEANOPNO(PCCLDEJFBPE LHAGHJCACPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EHKJDICOICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct HDFNECGDCJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HHPAEHKCMCF FPJMMEGHFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public HHPAEHKCMCF AEMEEJKFKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KNNJNIOKKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int DNKKAAGGMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 PFFEHHLOEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion EJIAAHNMHLL;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ACOJPGCKDBL EJBFGGIIGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8409C30", Offset = "0x8408630", VA = "0x188409C30")]
		get
		{
			return default(ACOJPGCKDBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public ACOJPGCKDBL CBKOFHJJOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8409CD0", Offset = "0x84086D0", VA = "0x188409CD0")]
		get
		{
			return default(ACOJPGCKDBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8409D00", Offset = "0x8408700", VA = "0x188409D00")]
	public HDFNECGDCJM(HHPAEHKCMCF FPJMMEGHFEH, HHPAEHKCMCF AEMEEJKFKNN, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface MMGPOPKBFLN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IHEPHLEJEED GLKLCNOCKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFALNPPLGKO(AHMMOJBKLHN KFMMGFEJHFC);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGGODCIPEOB([In] HDFNECGDCJM BLPDDGCLNPE, bool LPJEIEEOPNL = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGAFONOINPI(HHPAEHKCMCF DFJHFDOPCFJ);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HFKAAHKIHPI(HHPAEHKCMCF GFKFABOANPF, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NFBCNLHIPHE(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBMIOOCCGKD();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OONPCGOFAAG(Func<HHPAEHKCMCF, bool> FDBEAKIOHLO);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DAHBEDLMDAJ(HHPAEHKCMCF GJKJHAMHLOA, HashSet<HHPAEHKCMCF> AIHDEPJAPAF);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HHPAEHKCMCF> ONMKLDEODHJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DEFNCPKDJDA(HHPAEHKCMCF GJKJHAMHLOA, [Out] ACOJPGCKDBL DNOHIEFBPAK);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CLJLCHGCIGL(IEKEBEOHMMO AEPCPKCINPI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool IEKEBEOHMMO(IHEPHLEJEED MNHKIMAOFNO);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IHEPHLEJEED
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HHPAEHKCMCF KPEHBFMGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IHEPHLEJEED AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	ACOJPGCKDBL KAHBDGKHLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HHECCOAHKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface AJLOENGFMPO
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHEJPJMHOBO(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFBNBBLLACK(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGNLJGCMJJJ(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCJPCPKFOGD(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AJLOENGFMPO Instantiate(Transform HALOMIKDIAH);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIIFCIMJIKL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface ELGCPFFKNDA
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFALNPPLGKO(Transform HALOMIKDIAH, AJLOENGFMPO EPKGNIPOEEL);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AJLOENGFMPO JMMPMMOLPIL();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGMBFKFKIIO(AJLOENGFMPO IOOGIKGCIOF);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DDFGBOEFLCD : OAFKFNBCEHC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOGJICHIEDE();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FIAAPBFKODN(Guid FJFCHHLHHFI);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KPCCOIABNPL
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEMKIDFKEHE(IHEPHLEJEED IDIHOAPJNLC);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFALNPPLGKO(MMGPOPKBFLN HNPPIOOOPNL, ELGCPFFKNDA OIHEKDALELM);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCNNMGAHKDA();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFIABFOCCFG(IHEPHLEJEED LHNBHDFKEBK);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BELNINELIHO(IHEPHLEJEED AEFHNOHOPOL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GGLKOBCKMBL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class PCCLDEJFBPE : IHEPHLEJEED
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JAKALEKLOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public ACOJPGCKDBL nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public PCCLDEJFBPE foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JAKALEKLOLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x840A930", Offset = "0x8409330", VA = "0x18840A930")]
		internal bool GJMABKNLINL(IHEPHLEJEED x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private ACOJPGCKDBL DNOHIEFBPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<PCCLDEJFBPE> CFJCMLOIJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private PCCLDEJFBPE OGKLFKCEKJL;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public ACOJPGCKDBL KAHBDGKHLPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x157ACB0", Offset = "0x15796B0", VA = "0x18157ACB0", Slot = "6")]
		get
		{
			return default(ACOJPGCKDBL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x157AE70", Offset = "0x1579870", VA = "0x18157AE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private PCCLDEJFBPE AEMEEJKFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8412CC0", Offset = "0x84116C0", VA = "0x188412CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IHEPHLEJEED AJFLBGMINPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HHPAEHKCMCF KPEHBFMGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HHECCOAHKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8412670", Offset = "0x8411070", VA = "0x188412670", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JOMIDKGDIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x84130A0", Offset = "0x8411AA0", VA = "0x1884130A0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected PCCLDEJFBPE FAIGKPPBFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8412EA0", Offset = "0x84118A0", VA = "0x188412EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x84130F0", Offset = "0x8411AF0", VA = "0x1884130F0")]
	public PCCLDEJFBPE(ACOJPGCKDBL GLDONADPPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x8412680", Offset = "0x8411080", VA = "0x188412680")]
	public PCCLDEJFBPE CBDIIGPKEMJ(ACOJPGCKDBL HCIHEKIADPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8412880", Offset = "0x8411280", VA = "0x188412880")]
	public PCCLDEJFBPE CGEHMOLNINJ(ACOJPGCKDBL MOEAPJJLNBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8412EC0", Offset = "0x84118C0", VA = "0x188412EC0")]
	public PCCLDEJFBPE MCKODPOBNPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8412B70", Offset = "0x8411570", VA = "0x188412B70")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x84127D0", Offset = "0x84111D0", VA = "0x1884127D0")]
	public PCCLDEJFBPE CBLBLJAMJCE(ACOJPGCKDBL CCBBLDBOMGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8412A00", Offset = "0x8411400", VA = "0x188412A00")]
	private static void CLJLCHGCIGL(PCCLDEJFBPE DCPINCKPIBL, IEKEBEOHMMO BEINHMMJKLL, bool MIEGFFOCFLP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8412B60", Offset = "0x8411560", VA = "0x188412B60", Slot = "9")]
	public void CLJLCHGCIGL(IEKEBEOHMMO AEPCPKCINPI, bool HDCFEKHDKHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8412DA0", Offset = "0x84117A0", VA = "0x188412DA0")]
	public static PCCLDEJFBPE IMOCGILMLIK(PCCLDEJFBPE DCPINCKPIBL, ACOJPGCKDBL NOFEOODMCFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface POFFMOLDGHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool KIJCGGAJKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<AFPDBFALGFB> ICBEEOMBAPD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<FNAEIBBBBBE> LBGOLLLEDMC;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LHEJPJMHOBO(ANBOOAPNFCA KFMMGFEJHFC, OKJGGGOAAFN GIBCNHFDFDN);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COCEBKJOEPO(HHPAEHKCMCF GFKFABOANPF, HHPAEHKCMCF AGGICKLBDMO, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BFCOGFNNHBI(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CHDMBEPFNPM(GBFAPFIPMIB DKPKFLCIIEC, [Optional] FNAEIBBBBBE IFAOOLBLKDP);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class BDHKBEHGNAI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type EMHLKEMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8401040", Offset = "0x83FFA40", VA = "0x188401040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object FLGHCDNLMND
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x84010A0", Offset = "0x83FFAA0", VA = "0x1884010A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x84010E0", Offset = "0x83FFAE0", VA = "0x1884010E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class EPHKFIIGGPP : POFFMOLDGHP, IDisposable, GLOPBJKODMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private ANBOOAPNFCA KFMMGFEJHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private OKJGGGOAAFN HJKLBLDJBCI;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool KIJCGGAJKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x84091F0", Offset = "0x8407BF0", VA = "0x1884091F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x84090D0", Offset = "0x8407AD0", VA = "0x1884090D0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView NCDGODKJFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8409110", Offset = "0x8407B10", VA = "0x188409110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<AFPDBFALGFB> ICBEEOMBAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8409420", Offset = "0x8407E20", VA = "0x188409420", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8409250", Offset = "0x8407C50", VA = "0x188409250", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FNAEIBBBBBE> LBGOLLLEDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x84092F0", Offset = "0x8407CF0", VA = "0x1884092F0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8408CA0", Offset = "0x84076A0", VA = "0x188408CA0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x8409390", Offset = "0x8407D90", VA = "0x188409390", Slot = "10")]
	public void LHEJPJMHOBO(ANBOOAPNFCA KFMMGFEJHFC, OKJGGGOAAFN HJKLBLDJBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x84091A0", Offset = "0x8407BA0", VA = "0x1884091A0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8408FA0", Offset = "0x84079A0", VA = "0x188408FA0", Slot = "11")]
	public void COCEBKJOEPO(HHPAEHKCMCF GFKFABOANPF, HHPAEHKCMCF AGGICKLBDMO, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x8408D40", Offset = "0x8407740", VA = "0x188408D40", Slot = "12")]
	public void BFCOGFNNHBI(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8408E70", Offset = "0x8407870", VA = "0x188408E70", Slot = "13")]
	public void CHDMBEPFNPM(GBFAPFIPMIB DKPKFLCIIEC, [Optional] FNAEIBBBBBE IFAOOLBLKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8409700", Offset = "0x8408100", VA = "0x188409700")]
	[OANEHPBACDO]
	private void RpcMasterReparentNodes(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8409500", Offset = "0x8407F00", VA = "0x188409500")]
	[OANEHPBACDO]
	private void RpcMasterModifyNode(HHPAEHKCMCF GFKFABOANPF, HHPAEHKCMCF AGGICKLBDMO, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8409B00", Offset = "0x8408500", VA = "0x188409B00")]
	[OANEHPBACDO]
	private void RpcReparentNodes(HHPAEHKCMCF MDAEGCHGBKA, int ONLAJOGNFGE, HHPAEHKCMCF CCBBLDBOMGE, int PCKNHNFNILF, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL, MEEBGCNEDOD PHCKGOPPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8409A10", Offset = "0x8408410", VA = "0x188409A10")]
	[OANEHPBACDO]
	private void RpcModifyNode(HHPAEHKCMCF GFKFABOANPF, int KNNJNIOKKIJ, int DNKKAAGGMPL, Vector3 PFFEHHLOEJF, Quaternion EJIAAHNMHLL, MEEBGCNEDOD PHCKGOPPKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x84094C0", Offset = "0x8407EC0", VA = "0x1884094C0")]
	[OANEHPBACDO]
	private void RpcDeserializeConnectableGraph(GBFAPFIPMIB HNPPIOOOPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EPHKFIIGGPP()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, AJLOENGFMPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x840E920", Offset = "0x840D320", VA = "0x18840E920", Slot = "4")]
		private void KDPFPGJJCGE(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x840E6B0", Offset = "0x840D0B0", VA = "0x18840E6B0", Slot = "5")]
		private void HEGNINCHDFD(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x840E300", Offset = "0x840CD00", VA = "0x18840E300", Slot = "6")]
		private void ALNFHDPHMJC(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x840E460", Offset = "0x840CE60", VA = "0x18840E460", Slot = "7")]
		private void BNFKKEEFDPH(HHPAEHKCMCF EDDAAOKHMHO, ACOJPGCKDBL FPJMMEGHFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x840EAA0", Offset = "0x840D4A0", VA = "0x18840EAA0", Slot = "8")]
		private AJLOENGFMPO NPKMCLFMLLE(Transform HALOMIKDIAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x840E650", Offset = "0x840D050", VA = "0x18840E650", Slot = "9")]
		private void DAKJJHFIIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class ABFKIDLIFEB
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x32D1C70", Offset = "0x32D0670", VA = "0x1832D1C70")]
	public static BCDNLCPFEAG<T> PCGKOLEDNGO<T>(this JBJKIIKOACK KLIEGJHNGPK)
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
