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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5D20", Offset = "0x7CF4920", VA = "0x187CF5D20", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x220C1E0", Offset = "0x220ADE0", VA = "0x18220C1E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CF82E0", Offset = "0x7CF6EE0", VA = "0x187CF82E0")]
		private void HNLBFOBJPNI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CF8450", Offset = "0x7CF7050", VA = "0x187CF8450")]
		private void PHGCFAENFGI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CF85C0", Offset = "0x7CF71C0", VA = "0x187CF85C0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CF88F0", Offset = "0x7CF74F0", VA = "0x187CF88F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class EHADOKJHMJP : FCFPLIECMLG, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class JLPFCCBLDIO : IEnumerable<GGIOAHEJDLJ>, IEnumerable, IEnumerator<GGIOAHEJDLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private GGIOAHEJDLJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GBGGLBKJJPC localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GBGGLBKJJPC <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EHADOKJHMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private BNNLGKNFBBF <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private EDFFLPPIDFO <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private EDFFLPPIDFO.MHCMEALLHEL <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private GGIOAHEJDLJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public JLPFCCBLDIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7CECE80", Offset = "0x7CEBA80", VA = "0x187CECE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CECA20", Offset = "0x7CEB620", VA = "0x187CECA20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC9E0", Offset = "0x7CEB5E0", VA = "0x187CEC9E0")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7CECA00", Offset = "0x7CEB600", VA = "0x187CECA00")]
		private void JKFKJAKKDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7CECE30", Offset = "0x7CEBA30", VA = "0x187CECE30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7CECD80", Offset = "0x7CEB980", VA = "0x187CECD80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GGIOAHEJDLJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7CECD80", Offset = "0x7CEB980", VA = "0x187CECD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LNGHAHHCIGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public EHADOKJHMJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public FBOLJECIJIH nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LNGHAHHCIGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF54A0", Offset = "0x7CF40A0", VA = "0x187CF54A0")]
		internal object CJJNKMOOIOB(FBOLJECIJIH x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MKPNGNJEPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FBOLJECIJIH child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LNGHAHHCIGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MKPNGNJEPCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6170", Offset = "0x7CF4D70", VA = "0x187CF6170")]
		internal object BPBKAILOIPC((FBOLJECIJIH child, FBOLJECIJIH nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly JPIBGNDAFKP BBFDLPPKFHL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly JPIBGNDAFKP OJALKCOKGJB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly JPIBGNDAFKP AIEDDEFJPMH;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly JPIBGNDAFKP EPOBOIPEOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private AHNOMBGEGCI IAEGKNBNPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private OGJOONKMAFC GNNAEMCNMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CGHCFDJMGCD PDHGPFOGKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LFBGCEKCIJO ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AFLKGGANELK BAJMAFHHPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private EELOJCDDLBJ HDFGLHEIKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly BJBGLOOCAAJ PFNBNJEHPGE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA24790", Offset = "0xA23390", VA = "0x180A24790", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA24680", Offset = "0xA23280", VA = "0x180A24680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GBEIDDOLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> BMHFCNIEJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB990", Offset = "0x7CEA590", VA = "0x187CEB990", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8430", Offset = "0x7CE7030", VA = "0x187CE8430", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> CDOFOAKLIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA470", Offset = "0x7CE9070", VA = "0x187CEA470", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8EC0", Offset = "0x7CE7AC0", VA = "0x187CE8EC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ, GGIOAHEJDLJ> DGEDJEFLDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEB130", Offset = "0x7CE9D30", VA = "0x187CEB130", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CE71F0", Offset = "0x7CE5DF0", VA = "0x187CE71F0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7CEBB90", Offset = "0x7CEA790", VA = "0x187CEBB90")]
	public EHADOKJHMJP(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAD30", Offset = "0x7CE9930", VA = "0x187CEAD30", Slot = "12")]
	public void LEIJOMGLGOC(GameObject AOALCMHDOFP, DPOIJADHPLA AHIBPIAFKHI, CJIPBDANJGM MONEFJFBDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9430", Offset = "0x7CE8030", VA = "0x187CE9430", Slot = "26")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB620", Offset = "0x7CEA220", VA = "0x187CEB620", Slot = "22")]
	public bool OEBCBCADPLG(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9C20", Offset = "0x7CE8820", VA = "0x187CE9C20")]
	private void GPGCNKMKHIJ(GBGGLBKJJPC MNEAGHKMEKN, GBGGLBKJJPC AHOAACEFKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8810", Offset = "0x7CE7410", VA = "0x187CE8810")]
	private void DLOJDPCPMOA(GBGGLBKJJPC MNEAGHKMEKN, GBGGLBKJJPC HNPNPGADLFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7CE81D0", Offset = "0x7CE6DD0", VA = "0x187CE81D0")]
	private void DDFANLPCHKP(GBGGLBKJJPC MNEAGHKMEKN, GBGGLBKJJPC HNPNPGADLFL, GBGGLBKJJPC AHOAACEFKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7B90", Offset = "0x7CE6790", VA = "0x187CE7B90")]
	private void BEADCDIOCJG(GBGGLBKJJPC MNEAGHKMEKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "13")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA930", Offset = "0x7CE9530", VA = "0x187CEA930", Slot = "14")]
	public void KHPGHNAFBFC(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "15")]
	public void BFGPHHDGACD(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB1E0", Offset = "0x7CE9DE0", VA = "0x187CEB1E0", Slot = "17")]
	public void NJEOPPDELLP(GGIOAHEJDLJ GGCJLICHELN, GGIOAHEJDLJ JEMJJKEPHBL, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB340", Offset = "0x7CE9F40", VA = "0x187CEB340")]
	public void NJEOPPDELLP(GBGGLBKJJPC DIMLHDJJHIH, GBGGLBKJJPC JEMJJKEPHBL, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA1D0", Offset = "0x7CE8DD0", VA = "0x187CEA1D0")]
	public void JDDEHHGPHMK(GGIOAHEJDLJ GGCJLICHELN, float HKEPCDNIKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8C20", Offset = "0x7CE7820", VA = "0x187CE8C20", Slot = "18")]
	public void FCNODMBHNPO(GGIOAHEJDLJ HKFBIFJDMIG, int IIPIOEIEJDI, GGIOAHEJDLJ JKOJPMPOPEI, int MAIDPEGMKAI, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7CE84E0", Offset = "0x7CE70E0", VA = "0x187CE84E0")]
	private float DHCADFIJNIJ(GBGGLBKJJPC DIMLHDJJHIH, GBGGLBKJJPC LIPFJJEAFCE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8D80", Offset = "0x7CE7980", VA = "0x187CE8D80")]
	public void FCNODMBHNPO(GBGGLBKJJPC DIMLHDJJHIH, GBGGLBKJJPC LIPFJJEAFCE, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL, bool ONAHCLGDFGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAFC0", Offset = "0x7CE9BC0", VA = "0x187CEAFC0", Slot = "19")]
	public void LIOBJJJPLGO(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA260", Offset = "0x7CE8E60", VA = "0x187CEA260", Slot = "16")]
	public void KBJIMBLJAOE(GGIOAHEJDLJ GGCJLICHELN, HashSet<GGIOAHEJDLJ> KJMPGAELJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "20")]
	public JBANPOMFHOI FEFHPKEINGI(bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "21")]
	public JBANPOMFHOI NBIIHCCIJDI(HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9FB0", Offset = "0x7CE8BB0", VA = "0x187CE9FB0", Slot = "23")]
	public void HECNACGGDCH(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9620", Offset = "0x7CE8220", VA = "0x187CE9620", Slot = "24")]
	public void GAOLBJNEAOJ(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA1B0", Offset = "0x7CE8DB0", VA = "0x187CEA1B0", Slot = "25")]
	public void IGJDGJPDAAI(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA520", Offset = "0x7CE9120", VA = "0x187CEA520")]
	private void KEABJEHFABA(GBGGLBKJJPC DIMLHDJJHIH, GBGGLBKJJPC LIPFJJEAFCE, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL, float HKEPCDNIKBH, bool ONAHCLGDFGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE72A0", Offset = "0x7CE5EA0", VA = "0x187CE72A0")]
	private void BDLLPDOGCHE(GBGGLBKJJPC DIMLHDJJHIH, GBGGLBKJJPC JHPFPLHIKAH, Vector3 MICNLECKIBH, Quaternion HNIPNOOHHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7180", Offset = "0x7CE5D80", VA = "0x187CE7180")]
	private void AICCDNOCBPK(GBGGLBKJJPC DIMLHDJJHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB480", Offset = "0x7CEA080", VA = "0x187CEB480")]
	[IteratorStateMachine(typeof(JLPFCCBLDIO))]
	public IEnumerable<GGIOAHEJDLJ> NPGNCKHMLPM(GBGGLBKJJPC EAOPNGFGOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8F70", Offset = "0x7CE7B70", VA = "0x187CE8F70")]
	internal GGIOAHEJDLJ FPDPPNIMEOE(GBGGLBKJJPC EAOPNGFGOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEA020", Offset = "0x7CE8C20", VA = "0x187CEA020")]
	internal GBGGLBKJJPC HJHFJNBEOIM(GGIOAHEJDLJ GGCJLICHELN)
	{
		return default(GBGGLBKJJPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9690", Offset = "0x7CE8290", VA = "0x187CE9690")]
	private bool GGAOCJLCFJC(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8170", Offset = "0x7CE6D70", VA = "0x187CE8170")]
	private bool BNFJGMKHABP(FBOLJECIJIH GAPFGOJCKND, [Out] GGIOAHEJDLJ LIPFJJEAFCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7CE90A0", Offset = "0x7CE7CA0", VA = "0x187CE90A0")]
	private GGIOAHEJDLJ FPDPPNIMEOE(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB670", Offset = "0x7CEA270", VA = "0x187CEB670")]
	private GGIOAHEJDLJ OFJHLOBBOJP(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7CE7FA0", Offset = "0x7CE6BA0", VA = "0x187CE7FA0")]
	private GGIOAHEJDLJ BGKCMPKJCGK(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4D90", Offset = "0x7CE3990", VA = "0x187CE4D90")]
	private static Guid DPMMFDCPPJD(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7CEAC40", Offset = "0x7CE9840", VA = "0x187CEAC40")]
	private string LBLMNJJJHMN(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB800", Offset = "0x7CEA400", VA = "0x187CEB800")]
	private void OHEGCBEFGCD(GGIOAHEJDLJ DIMLHDJJHIH, GGIOAHEJDLJ JHPFPLHIKAH, RigidTransform OGGBJDJMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7CE9E20", Offset = "0x7CE8A20", VA = "0x187CE9E20")]
	private void HDMJOBCBJKE(GGIOAHEJDLJ JHPFPLHIKAH, GGIOAHEJDLJ DIMLHDJJHIH, RigidTransform OGGBJDJMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8BC0", Offset = "0x7CE77C0", VA = "0x187CE8BC0")]
	private void EEONBHELNHO(GGIOAHEJDLJ FGKFJDBOFLH, GGIOAHEJDLJ DIMLHDJJHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8A30", Offset = "0x7CE7630", VA = "0x187CE8A30")]
	private void EDPGHICDHKE(GGIOAHEJDLJ DIMLHDJJHIH, GGIOAHEJDLJ LIPFJJEAFCE, RigidTransform OGGBJDJMOGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEB510", Offset = "0x7CEA110", VA = "0x187CEB510")]
	private void ODBCICBGOKN(GBGGLBKJJPC EAOPNGFGOCP, GGIOAHEJDLJ GGCJLICHELN, GBGGLBKJJPC HNPNPGADLFL, GBGGLBKJJPC AHOAACEFKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE8590", Offset = "0x7CE7190", VA = "0x187CE8590")]
	private void DJDOBAAFLMN(GBGGLBKJJPC EAOPNGFGOCP, GGIOAHEJDLJ GGCJLICHELN, GGIOAHEJDLJ OIEKKJCCFCH, GGIOAHEJDLJ GPGDAHNKOCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CNEHNLOGCDO
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HDDPCAMKHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PFGPAPHADOM container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HDDPCAMKHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC0E0", Offset = "0x7CEACE0", VA = "0x187CEC0E0")]
		internal EHADOKJHMJP OACPCJGKAJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7CE47C0", Offset = "0x7CE33C0", VA = "0x187CE47C0")]
	public static void BIBNNPJAABO(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4770", Offset = "0x7CE3370", VA = "0x187CE4770")]
	public static void ABEMCJCIHAK(PFGPAPHADOM MHCMGFKMEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KOFKDIMPGDH : LOPBLENFGMC, DKHLLILKPEO
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx KBHNLJCJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly EHADOKJHMJP ACLAFJMMMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly CFJBNDJKMBE CHFBAKHAMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NBLGLNKBGEL ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly JFEKMGIAAOB[] FGFLKHCLNOC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(GBGGLBKJJPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GGIOAHEJDLJ EBOAKBONBHF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF41B0", Offset = "0x7CF2DB0", VA = "0x187CF41B0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GGIOAHEJDLJ AFMJLMJBFED
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3280", Offset = "0x7CF1E80", VA = "0x187CF3280", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 MALFGOHMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF38D0", Offset = "0x7CF24D0", VA = "0x187CF38D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion LOEOAODPIDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3730", Offset = "0x7CF2330", VA = "0x187CF3730", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EMBHKDCOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3340", Offset = "0x7CF1F40", VA = "0x187CF3340", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<GGIOAHEJDLJ> NBOMOJAEMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3020", Offset = "0x7CF1C20", VA = "0x187CF3020", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool FAAFCLLNDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xCBAD60", Offset = "0xCB9960", VA = "0x180CBAD60", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCEF8C0", Offset = "0xCEE4C0", VA = "0x180CEF8C0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7CF43C0", Offset = "0x7CF2FC0", VA = "0x187CF43C0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject OPELENGGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7CF40C0", Offset = "0x7CF2CC0", VA = "0x187CF40C0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7CF40E0", Offset = "0x7CF2CE0", VA = "0x187CF40E0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid PJNGAHHFJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4210", Offset = "0x7CF2E10", VA = "0x187CF4210", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KDHLLAPOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CF42F0", Offset = "0x7CF2EF0", VA = "0x187CF42F0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GLPALCNDKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool PLHJIOBGLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3830", Offset = "0x7CF2430", VA = "0x187CF3830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event MFHDCJKEDBA PBOAHLIJFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3A00", Offset = "0x7CF2600", VA = "0x187CF3A00", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7CF25C0", Offset = "0x7CF11C0", VA = "0x187CF25C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event MFHDCJKEDBA JOLALFPECON
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3E70", Offset = "0x7CF2A70", VA = "0x187CF3E70", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3680", Offset = "0x7CF2280", VA = "0x187CF3680", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event MFHDCJKEDBA NMBMILGEJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3220", Offset = "0x7CF1E20", VA = "0x187CF3220", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7CF30F0", Offset = "0x7CF1CF0", VA = "0x187CF30F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event JCKLDFGAGMM INKJAOOMMAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3790", Offset = "0x7CF2390", VA = "0x187CF3790", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7CF3050", Offset = "0x7CF1C50", VA = "0x187CF3050", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3FC0", Offset = "0x7CF2BC0", VA = "0x187CF3FC0")]
	public KOFKDIMPGDH(GBGGLBKJJPC AEIJGHPBELE, RigidbodyEx KBHNLJCJFLC, CFJBNDJKMBE CHFBAKHAMFM, JFEKMGIAAOB[] FGFLKHCLNOC, NBLGLNKBGEL ECPFHMDENEE, FCFPLIECMLG ACLAFJMMMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7CF31F0", Offset = "0x7CF1DF0", VA = "0x187CF31F0", Slot = "19")]
	public void DJGFNKKBNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "21")]
	public void POOAAKCGKCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7A31470", Offset = "0x7A30070", VA = "0x187A31470", Slot = "22")]
	public void PIAKJNDCEHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7CF36E0", Offset = "0x7CF22E0", VA = "0x187CF36E0", Slot = "20")]
	public void KDHJHGHKFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3A60", Offset = "0x7CF2660", VA = "0x187CF3A60", Slot = "25")]
	public void OBBNMGJDIKI(int MEAMNLGJGEA, GGIOAHEJDLJ JKOJPMPOPEI, int DOAEKANJDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3930", Offset = "0x7CF2530", VA = "0x187CF3930", Slot = "26")]
	public void MBBOJCFNAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2D40", Offset = "0x7CF1940", VA = "0x187CF2D40", Slot = "27")]
	public void BGGPHNNJKMK(int MEAMNLGJGEA, GGIOAHEJDLJ HKFBIFJDMIG, int KAFANFFPAML, [Optional] Vector3? OJMBGNDBNBO, [Optional] Quaternion? NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3400", Offset = "0x7CF2000", VA = "0x187CF3400", Slot = "28")]
	public void GKOFOKBHNCG(GGIOAHEJDLJ HKFBIFJDMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2930", Offset = "0x7CF1530", VA = "0x187CF2930", Slot = "31")]
	public void BEHCHJDBCMG(Vector3 NGEKICKNMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2620", Offset = "0x7CF1220", VA = "0x187CF2620", Slot = "29")]
	public void AJEGBFIECOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3C70", Offset = "0x7CF2870", VA = "0x187CF3C70", Slot = "30")]
	public void OIICPLHMBLE(int EMMACFPOKFB, Vector3 JGJDJFGJGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7CF35B0", Offset = "0x7CF21B0", VA = "0x187CF35B0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int MEAMNLGJGEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3480", Offset = "0x7CF2080", VA = "0x187CF3480", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int MEAMNLGJGEA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xC989C0", Offset = "0xC975C0", VA = "0x180C989C0", Slot = "42")]
	public Color GetConnectionSlotColor(int MEAMNLGJGEA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3150", Offset = "0x7CF1D50", VA = "0x187CF3150", Slot = "43")]
	public bool CanConnectTo(int MEAMNLGJGEA, GGIOAHEJDLJ CFFANPCJGJC, int FKCBINKANNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "44")]
	public void ParentChanged(int MEAMNLGJGEA, GGIOAHEJDLJ LPEGIHGDJBE, int CDMCNBHNHPP, Vector3 FHOMMMINPAE, Quaternion MPBECANEJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "45")]
	public void ChildAdded(int MEAMNLGJGEA, GGIOAHEJDLJ OFCKAOKOMJM, int JHEMBHFMGBI, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "46")]
	public void ChildRemoved(int MEAMNLGJGEA, GGIOAHEJDLJ LBJHOOAHALM, int OHPAHKGHGLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "47")]
	public void ConnectionModified(int MEAMNLGJGEA, GGIOAHEJDLJ JKOJPMPOPEI, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3F20", Offset = "0x7CF2B20", VA = "0x187CF3F20", Slot = "48")]
	public void RootChanged(GGIOAHEJDLJ FKEIALOEBOB, GGIOAHEJDLJ KNFMAIFJPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7CF33B0", Offset = "0x7CF1FB0", VA = "0x187CF33B0", Slot = "23")]
	public void GJNHFLLOLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3880", Offset = "0x7CF2480", VA = "0x187CF3880", Slot = "24")]
	public void LIFENIAIBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7CF3ED0", Offset = "0x7CF2AD0", VA = "0x187CF3ED0")]
	private void PPIHKAIBHPM(bool LOLLFIDKPFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(FAIJCKGPCBG), new string[] { })]
public class LFBIJOLEKAJ : FAIJCKGPCBG, CBLCJDEAFID, JOOIONMMMGO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JGNBMKIDLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public JGNBMKIDLDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private FIMFJKLCIEC BNLGIODIEPM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object GNKAEKDJHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CF53A0", Offset = "0x7CF3FA0", VA = "0x187CF53A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5350", Offset = "0x7CF3F50", VA = "0x187CF5350", Slot = "5")]
	private void KKNLMKKOOCF(OLKHLOEBPJH PFNBNJEHPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x11FF100", Offset = "0x11FDD00", VA = "0x1811FF100", Slot = "6")]
	private void OLKMBFKLKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LFBIJOLEKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(FCFPLIECMLG), new string[] { "Ignore", "Mock" })]
public class GMNIOKHMDHH : FCFPLIECMLG, IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool GBEIDDOLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> BMHFCNIEJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7CEC030", Offset = "0x7CEAC30", VA = "0x187CEC030", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBD70", Offset = "0x7CEA970", VA = "0x187CEBD70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> CDOFOAKLIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBED0", Offset = "0x7CEAAD0", VA = "0x187CEBED0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBE20", Offset = "0x7CEAA20", VA = "0x187CEBE20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ, GGIOAHEJDLJ> DGEDJEFLDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBF80", Offset = "0x7CEAB80", VA = "0x187CEBF80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBCC0", Offset = "0x7CEA8C0", VA = "0x187CEBCC0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "26")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "12")]
	public void LEIJOMGLGOC(GameObject AOALCMHDOFP, DPOIJADHPLA AHIBPIAFKHI, CJIPBDANJGM JMDMDFHNKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "13")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "14")]
	public void KHPGHNAFBFC(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "15")]
	public void BFGPHHDGACD(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "16")]
	public void KBJIMBLJAOE(GGIOAHEJDLJ GGCJLICHELN, HashSet<GGIOAHEJDLJ> KJMPGAELJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "17")]
	public void NJEOPPDELLP(GGIOAHEJDLJ GGCJLICHELN, GGIOAHEJDLJ JEMJJKEPHBL, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "18")]
	public void FCNODMBHNPO(GGIOAHEJDLJ GGCJLICHELN, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "19")]
	public void LIOBJJJPLGO(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "20")]
	public JBANPOMFHOI FEFHPKEINGI(bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "21")]
	public JBANPOMFHOI NBIIHCCIJDI(HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "22")]
	public bool OEBCBCADPLG(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "23")]
	public void HECNACGGDCH(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "24")]
	public void GAOLBJNEAOJ(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "25")]
	public void IGJDGJPDAAI(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public GMNIOKHMDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GGIOAHEJDLJ : DKHLLILKPEO, IEquatable<GGIOAHEJDLJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DKHLLILKPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GGIOAHEJDLJ EBOAKBONBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform FPIONCNEDML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject OPELENGGFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string AJPMCBKCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid PJNGAHHFJEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int KDHLLAPOBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GBGGLBKJJPC OGHKMNDPJNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool GLPALCNDKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int MEAMNLGJGEA);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int MEAMNLGJGEA);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int MEAMNLGJGEA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int MEAMNLGJGEA, GGIOAHEJDLJ CFFANPCJGJC, int MJLFFOIPDJJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int MEAMNLGJGEA, GGIOAHEJDLJ LPEGIHGDJBE, int CDMCNBHNHPP, Vector3 FHOMMMINPAE, Quaternion MPBECANEJEK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int MEAMNLGJGEA, GGIOAHEJDLJ OFCKAOKOMJM, int JHEMBHFMGBI, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int MEAMNLGJGEA, GGIOAHEJDLJ LBJHOOAHALM, int OHPAHKGHGLF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int MEAMNLGJGEA, GGIOAHEJDLJ JKOJPMPOPEI, int ILLEMBBBFOL, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(GGIOAHEJDLJ FKEIALOEBOB, GGIOAHEJDLJ KNFMAIFJPNB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface FCFPLIECMLG : IDOBMNBOACG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool GBEIDDOLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> BMHFCNIEJMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> CDOFOAKLIPA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<GGIOAHEJDLJ, GGIOAHEJDLJ, GGIOAHEJDLJ> DGEDJEFLDMC;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LEIJOMGLGOC(GameObject AOALCMHDOFP, DPOIJADHPLA AHIBPIAFKHI, CJIPBDANJGM OFHOFBPPJIA);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJCBLGMIGNH();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KHPGHNAFBFC(GGIOAHEJDLJ GGCJLICHELN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BFGPHHDGACD(GGIOAHEJDLJ GGCJLICHELN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KBJIMBLJAOE(GGIOAHEJDLJ GGCJLICHELN, HashSet<GGIOAHEJDLJ> KJMPGAELJPJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NJEOPPDELLP(GGIOAHEJDLJ GGCJLICHELN, GGIOAHEJDLJ JEMJJKEPHBL, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void FCNODMBHNPO(GGIOAHEJDLJ GGCJLICHELN, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LIOBJJJPLGO(GGIOAHEJDLJ GGCJLICHELN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JBANPOMFHOI FEFHPKEINGI(bool KJNDHIOAIPC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JBANPOMFHOI NBIIHCCIJDI(HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool OEBCBCADPLG(FBOLJECIJIH GAPFGOJCKND);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HECNACGGDCH(JBANPOMFHOI LLNCHDMNCFN);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GAOLBJNEAOJ(JBANPOMFHOI LLNCHDMNCFN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IGJDGJPDAAI(JBANPOMFHOI LLNCHDMNCFN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LFBGCEKCIJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GGIOAHEJDLJ BGKCMPKJCGK(int LOPGNPCCEFP);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GGIOAHEJDLJ OFJHLOBBOJP(Guid JMJGIFKJOOK);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HCILBMFKIBA(GGIOAHEJDLJ GGCJLICHELN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AMAOBDOMPKJ();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKDFCIFFPJJ(GGIOAHEJDLJ CHFBAKHAMFM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface NBLGLNKBGEL
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PLHJIOBGLJB(CFJBNDJKMBE CHFBAKHAMFM);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCIKMMONHPD(CFJBNDJKMBE CHFBAKHAMFM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string JKKJPHDNAKG(CFJBNDJKMBE CHFBAKHAMFM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OEIONHEFJJI(CFJBNDJKMBE CHFBAKHAMFM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int AEHFOBPEMDB(CFJBNDJKMBE CHFBAKHAMFM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LLJNIKJGKFO(CFJBNDJKMBE CHFBAKHAMFM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void MFHDCJKEDBA(GGIOAHEJDLJ HKFBIFJDMIG, int GMFHLMHNPJL, GGIOAHEJDLJ JKOJPMPOPEI, int OPIAELBNGOK, [Optional] Vector3? OJMBGNDBNBO, [Optional] Quaternion? NLIEJICFCBB);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void JCKLDFGAGMM(GGIOAHEJDLJ FKEIALOEBOB, GGIOAHEJDLJ KNFMAIFJPNB);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CFJBNDJKMBE : GGIOAHEJDLJ, DKHLLILKPEO, IEquatable<GGIOAHEJDLJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LOPBLENFGMC : DKHLLILKPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	GGIOAHEJDLJ AFMJLMJBFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<GGIOAHEJDLJ> NBOMOJAEMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 MALFGOHMFNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion LOEOAODPIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EMBHKDCOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FAAFCLLNDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MFHDCJKEDBA PBOAHLIJFKC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event MFHDCJKEDBA JOLALFPECON;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event MFHDCJKEDBA NMBMILGEJAD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event JCKLDFGAGMM INKJAOOMMAL;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DJGFNKKBNHD();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KDHJHGHKFGC();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void POOAAKCGKCC();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PIAKJNDCEHO();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void GJNHFLLOLFN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LIFENIAIBNO();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OBBNMGJDIKI(int MEAMNLGJGEA, GGIOAHEJDLJ JKOJPMPOPEI, int DOAEKANJDLD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MBBOJCFNAFN();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BGGPHNNJKMK(int MEAMNLGJGEA, GGIOAHEJDLJ HKFBIFJDMIG, int KAFANFFPAML, [Optional] Vector3? OJMBGNDBNBO, [Optional] Quaternion? NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GKOFOKBHNCG(GGIOAHEJDLJ HKFBIFJDMIG);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void AJEGBFIECOA();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void OIICPLHMBLE(int EMMACFPOKFB, Vector3 JGJDJFGJGGN);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BEHCHJDBCMG(Vector3 NGEKICKNMGE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JFEKMGIAAOB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 GPKEHDAHAAN
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
public interface DPOIJADHPLA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MBKIPICJPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	GJFJNBHMHNH LFFHODKMGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, DPOIJADHPLA
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
			[Cpp2IlInjected.Address(RVA = "0xA6B040", Offset = "0xA69C40", VA = "0x180A6B040", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public GJFJNBHMHNH LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4940", Offset = "0x7CE3540", VA = "0x187CE4940")]
		public static ConnectableConfigData KKGLNDJJDCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4A00", Offset = "0x7CE3600", VA = "0x187CE4A00")]
		public ConnectableConfigData(LegacyConnectableLinkVisual COMOFAANIDB, bool EENIHIIPAOI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HELDOBHLLAH : IEquatable<HELDOBHLLAH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public GGIOAHEJDLJ GGCJLICHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int HCPPMGFJDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int ILLEMBBBFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 OJMBGNDBNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion NLIEJICFCBB;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC720", Offset = "0x7CEB320", VA = "0x187CEC720")]
	public HELDOBHLLAH(GGIOAHEJDLJ GGCJLICHELN, int HCPPMGFJDNL, int ILLEMBBBFOL, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC600", Offset = "0x7CEB200", VA = "0x187CEC600")]
	public HELDOBHLLAH(GGIOAHEJDLJ GGCJLICHELN, int HCPPMGFJDNL, int ILLEMBBBFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC6A0", Offset = "0x7CEB2A0", VA = "0x187CEC6A0")]
	public HELDOBHLLAH(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC190", Offset = "0x7CEAD90", VA = "0x187CEC190", Slot = "4")]
	public bool Equals(HELDOBHLLAH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC240", Offset = "0x7CEAE40", VA = "0x187CEC240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class BOKGGJECBGL : PJKLNMKAAOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform NMIBCHFJGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private GJFJNBHMHNH JNFFGFODAGO;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x76A87B0", Offset = "0x76A73B0", VA = "0x1876A87B0", Slot = "4")]
	public void LEIJOMGLGOC(Transform NMIBCHFJGAE, GJFJNBHMHNH JNFFGFODAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3B70", Offset = "0x7CE2770", VA = "0x187CE3B70", Slot = "5")]
	public GJFJNBHMHNH MNIAPGFHBFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3B00", Offset = "0x7CE2700", VA = "0x187CE3B00", Slot = "6")]
	public void DKOIGMCJNIL(GJFJNBHMHNH OMFFBIABODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BOKGGJECBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KEICCCONFFL : IDisposable, NOKEJGBCBOE
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class GLALPMHCLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public GGIOAHEJDLJ oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public GGIOAHEJDLJ newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GLALPMHCLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7CEBC00", Offset = "0x7CEA800", VA = "0x187CEBC00")]
		internal bool JKOFJAHPFGL(OLKEDAALELH node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly CBKCDBLGDLM DAKMDHNACOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PDLOBHNABMH DMHFHCIEDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private HNJHFIOAFEL OJHGNMCGJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool EENIHIIPAOI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly JPIBGNDAFKP LONKNJJEGBH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public OLKEDAALELH MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE3C0", Offset = "0x7CECFC0", VA = "0x187CEE3C0")]
	public bool GMCIGCMCEPH([In] APDKDOEMJFH PEDMEJIDLNB, bool GNDLEOGBFBN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF3B0", Offset = "0x7CEDFB0", VA = "0x187CEF3B0")]
	private bool KPKLADHDDOK([In] APDKDOEMJFH PEDMEJIDLNB, bool GNDLEOGBFBN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0310", Offset = "0x7CEEF10", VA = "0x187CF0310")]
	public KEICCCONFFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFBC0", Offset = "0x7CEE7C0", VA = "0x187CEFBC0", Slot = "5")]
	public void LEIJOMGLGOC(FCFPLIECMLG GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDB70", Offset = "0x7CEC770", VA = "0x187CEDB70", Slot = "17")]
	public void CLJPCIIHPDA(NIKAFOIACLJ LKGGIMHKLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7CED090", Offset = "0x7CEBC90", VA = "0x187CED090", Slot = "12")]
	public void AAJJLDCBMHA(Func<GGIOAHEJDLJ, bool> HMGPGIANECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7CECF60", Offset = "0x7CEBB60", VA = "0x187CECF60")]
	private void AAJJLDCBMHA(CBKCDBLGDLM PBOIPJOJPLG, Func<GGIOAHEJDLJ, bool> HMGPGIANECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFDF0", Offset = "0x7CEE9F0", VA = "0x187CEFDF0", Slot = "11")]
	public void NBHJKDFBPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE740", Offset = "0x7CED340", VA = "0x187CEE740", Slot = "8")]
	public bool JDNGDLLEODP(GGIOAHEJDLJ HHLDEOFGCJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7CED2E0", Offset = "0x7CEBEE0", VA = "0x187CED2E0")]
	private bool CAKMAKDFDAJ(GGIOAHEJDLJ HMLJAHDDABA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFD40", Offset = "0x7CEE940", VA = "0x187CEFD40")]
	private static bool MAHNKJJBALG(GGIOAHEJDLJ HMLJAHDDABA, CBKCDBLGDLM BICBAMABOCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDC70", Offset = "0x7CEC870", VA = "0x187CEDC70")]
	private void DINLCJDOFHI(Transform HIGDIOEBAPL, CBKCDBLGDLM OOJDBBABLKL, CBKCDBLGDLM[] CKBPJKGLGIN, GGIOAHEJDLJ DKICEBLJNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFE10", Offset = "0x7CEEA10", VA = "0x187CEFE10")]
	private HELDOBHLLAH NLIMKOGIBHJ(Transform OKMHBBPOCFI, HELDOBHLLAH GOOCDLPGBPP)
	{
		return default(HELDOBHLLAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF1F0", Offset = "0x7CEDDF0", VA = "0x187CEF1F0")]
	private static bool KMDAGAPHENA(CBKCDBLGDLM BICBAMABOCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE6E0", Offset = "0x7CED2E0", VA = "0x187CEE6E0", Slot = "9")]
	public bool ICLAHMOCNKM(GGIOAHEJDLJ LELCHKKKCMO, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF970", Offset = "0x7CEE570", VA = "0x187CEF970")]
	private bool LCNCBCNJGFJ(GGIOAHEJDLJ LELCHKKKCMO, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7CED9F0", Offset = "0x7CEC5F0", VA = "0x187CED9F0")]
	private static void CCBDCJENABH(GGIOAHEJDLJ LELCHKKKCMO, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB, CBKCDBLGDLM CGHKNILJIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFF60", Offset = "0x7CEEB60", VA = "0x187CEFF60")]
	private void OHEGCBEFGCD(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE4E0", Offset = "0x7CED0E0", VA = "0x187CEE4E0")]
	private void HCMEOOEIELI(CBKCDBLGDLM PBOIPJOJPLG, GGIOAHEJDLJ OIEKKJCCFCH, GGIOAHEJDLJ GPGDAHNKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE550", Offset = "0x7CED150", VA = "0x187CEE550")]
	private void HCMEOOEIELI(GGIOAHEJDLJ GGCJLICHELN, GGIOAHEJDLJ OIEKKJCCFCH, GGIOAHEJDLJ GPGDAHNKOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE050", Offset = "0x7CECC50", VA = "0x187CEE050")]
	private void DJDOBAAFLMN(GGIOAHEJDLJ GGCJLICHELN, GGIOAHEJDLJ OIEKKJCCFCH, GGIOAHEJDLJ GPGDAHNKOCH, bool EPHELGLFELA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE0C0", Offset = "0x7CECCC0", VA = "0x187CEE0C0")]
	private void DJDOBAAFLMN(CBKCDBLGDLM HMGDINOCJAI, GGIOAHEJDLJ DKICEBLJNLA, GGIOAHEJDLJ KNFMAIFJPNB, bool EPHELGLFELA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE5C0", Offset = "0x7CED1C0", VA = "0x187CEE5C0")]
	private void HDMJOBCBJKE(GGIOAHEJDLJ DIMLHDJJHIH, int KAFANFFPAML, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE1C0", Offset = "0x7CECDC0", VA = "0x187CEE1C0")]
	private void EEONBHELNHO(OLKEDAALELH LIPFJJEAFCE, OLKEDAALELH DPCDKDDDJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7CEF090", Offset = "0x7CEDC90", VA = "0x187CEF090", Slot = "18")]
	public GGIOAHEJDLJ KLIDOBJMBFK(GGIOAHEJDLJ GGCJLICHELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE750", Offset = "0x7CED350", VA = "0x187CEE750", Slot = "13")]
	public void KBJIMBLJAOE(GGIOAHEJDLJ GGCJLICHELN, HashSet<GGIOAHEJDLJ> EJOIEPGDFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7CED0A0", Offset = "0x7CEBCA0", VA = "0x187CED0A0", Slot = "14")]
	public List<GGIOAHEJDLJ> BMEFFKJDOHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7CEDBA0", Offset = "0x7CEC7A0", VA = "0x187CEDBA0")]
	protected OLKEDAALELH DDHJGLKNAID(OLKEDAALELH PBOIPJOJPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE320", Offset = "0x7CECF20", VA = "0x187CEE320")]
	protected CBKCDBLGDLM[] FDKKKKELFGH(CBKCDBLGDLM BICBAMABOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE3D0", Offset = "0x7CECFD0", VA = "0x187CEE3D0")]
	protected bool HAFDHPAIOHH(GGIOAHEJDLJ GGCJLICHELN, [Out] CBKCDBLGDLM PBOIPJOJPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0080", Offset = "0x7CEEC80", VA = "0x187CF0080", Slot = "15")]
	public bool OIGCLEGOEFP(GGIOAHEJDLJ GGCJLICHELN, [Out] HELDOBHLLAH NJADCMEGEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7CF01B0", Offset = "0x7CEEDB0", VA = "0x187CF01B0")]
	protected CBKCDBLGDLM PHGNNIFFECO(HELDOBHLLAH IONOINBELGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7CF01F0", Offset = "0x7CEEDF0", VA = "0x187CF01F0", Slot = "10")]
	public bool PPAIKKEPGDC(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7CEEAF0", Offset = "0x7CED6F0", VA = "0x187CEEAF0")]
	private bool KLGOPFCOODN(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7CEFC70", Offset = "0x7CEE870", VA = "0x187CEFC70")]
	private static bool LGKBIFNKIGP(CBKCDBLGDLM DDLJCJAHFMD, HELDOBHLLAH GIHLJIIOOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7CEE3C0", Offset = "0x7CECFC0", VA = "0x187CEE3C0", Slot = "7")]
	private bool HBFLLLHADIO([In] APDKDOEMJFH PEDMEJIDLNB, bool GNDLEOGBFBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class KKMGDONHMBI : FCFPLIECMLG, IDOBMNBOACG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly PFGPAPHADOM MHCMGFKMEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly HNJHFIOAFEL OJHGNMCGJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly MLEDOHGGFLE APAHCHFLHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly DCDBLNIKBBI JDCOILLAEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly NOKEJGBCBOE LLNCHDMNCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal DMGGJOFINJM ECPFHMDENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal IBGFIHDABMG DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal PDLOBHNABMH ABPNCCBNMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool EENIHIIPAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool DIHMHNABCJF;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool MFOKJAPNHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA70560", Offset = "0xA6F160", VA = "0x180A70560")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA70570", Offset = "0xA6F170", VA = "0x180A70570")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PHEIOPHLIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x11D2920", Offset = "0x11D1520", VA = "0x1811D2920", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x277A1A0", Offset = "0x2778DA0", VA = "0x18277A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool GBEIDDOLJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> BMHFCNIEJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7CF2170", Offset = "0x7CF0D70", VA = "0x187CF2170", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7CF05A0", Offset = "0x7CEF1A0", VA = "0x187CF05A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ> CDOFOAKLIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7CF0F80", Offset = "0x7CEFB80", VA = "0x187CF0F80", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7CF08C0", Offset = "0x7CEF4C0", VA = "0x187CF08C0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GGIOAHEJDLJ, GGIOAHEJDLJ, GGIOAHEJDLJ> DGEDJEFLDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7CF1A40", Offset = "0x7CF0640", VA = "0x187CF1A40", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7CF04E0", Offset = "0x7CEF0E0", VA = "0x187CF04E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF21D0", Offset = "0x7CF0DD0", VA = "0x187CF21D0")]
	public KKMGDONHMBI(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1260", Offset = "0x7CEFE60", VA = "0x187CF1260", Slot = "12")]
	public void LEIJOMGLGOC(GameObject AOALCMHDOFP, DPOIJADHPLA AHIBPIAFKHI, CJIPBDANJGM OFHOFBPPJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0920", Offset = "0x7CEF520", VA = "0x187CF0920", Slot = "26")]
	public void GADHGOIPMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1E90", Offset = "0x7CF0A90", VA = "0x187CF1E90", Slot = "13")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0FE0", Offset = "0x7CEFBE0", VA = "0x187CF0FE0", Slot = "14")]
	public void KHPGHNAFBFC(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0540", Offset = "0x7CEF140", VA = "0x187CF0540", Slot = "15")]
	public void BFGPHHDGACD(GGIOAHEJDLJ GGCJLICHELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7CF2120", Offset = "0x7CF0D20", VA = "0x187CF2120", Slot = "22")]
	public bool OEBCBCADPLG(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1150", Offset = "0x7CEFD50", VA = "0x187CF1150")]
	internal bool KLGOPFCOODN([In] APDKDOEMJFH PEDMEJIDLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1000", Offset = "0x7CEFC00", VA = "0x187CF1000")]
	internal bool KKLBHDDHBHK([In] APDKDOEMJFH PEDMEJIDLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0CA0", Offset = "0x7CEF8A0", VA = "0x187CF0CA0")]
	internal void ILPLOINCJLL(GGIOAHEJDLJ GGCJLICHELN, int DNPHBFLDDID, bool GNDLEOGBFBN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0540", Offset = "0x7CEF140", VA = "0x187CF0540")]
	internal bool OOEJAIKIHCB(GGIOAHEJDLJ ABFJHPAPNOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0AA0", Offset = "0x7CEF6A0", VA = "0x187CF0AA0")]
	internal bool GODPLNNGEHE(GGIOAHEJDLJ LELCHKKKCMO, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0E80", Offset = "0x7CEFA80", VA = "0x187CF0E80", Slot = "16")]
	public void KBJIMBLJAOE(GGIOAHEJDLJ GGCJLICHELN, HashSet<GGIOAHEJDLJ> KJMPGAELJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1F10", Offset = "0x7CF0B10", VA = "0x187CF1F10", Slot = "17")]
	public void NJEOPPDELLP(GGIOAHEJDLJ LELCHKKKCMO, GGIOAHEJDLJ JEMJJKEPHBL, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0600", Offset = "0x7CEF200", VA = "0x187CF0600", Slot = "18")]
	public void FCNODMBHNPO(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1870", Offset = "0x7CF0470", VA = "0x187CF1870", Slot = "19")]
	public void LIOBJJJPLGO(GGIOAHEJDLJ HBBGIEOFIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1C40", Offset = "0x7CF0840", VA = "0x187CF1C40")]
	public void NJBFDOIKPLK([Optional] BJCCECIKIFB GCBAKMPBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0BD0", Offset = "0x7CEF7D0", VA = "0x187CF0BD0", Slot = "23")]
	public void HECNACGGDCH(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0740", Offset = "0x7CEF340", VA = "0x187CF0740", Slot = "20")]
	public JBANPOMFHOI FEFHPKEINGI(bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7CF1AA0", Offset = "0x7CF06A0", VA = "0x187CF1AA0", Slot = "21")]
	public JBANPOMFHOI NBIIHCCIJDI(HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7CF0C60", Offset = "0x7CEF860", VA = "0x187CF0C60", Slot = "25")]
	public void IGJDGJPDAAI(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7CF09F0", Offset = "0x7CEF5F0", VA = "0x187CF09F0", Slot = "24")]
	public void GAOLBJNEAOJ(JBANPOMFHOI LLNCHDMNCFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class HNJHFIOAFEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly BICCMPNJHAK<GGIOAHEJDLJ, GGIOAHEJDLJ> BMHFCNIEJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly BICCMPNJHAK<GGIOAHEJDLJ, GGIOAHEJDLJ> CDOFOAKLIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly LPMMAPNCNDE<GGIOAHEJDLJ, GGIOAHEJDLJ, GGIOAHEJDLJ> DGEDJEFLDMC;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC8C0", Offset = "0x7CEB4C0", VA = "0x187CEC8C0")]
	public HNJHFIOAFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	public void LEIJOMGLGOC(KKMGDONHMBI GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC800", Offset = "0x7CEB400", VA = "0x187CEC800")]
	public void ELHNPOFDFCB(GGIOAHEJDLJ LIPFJJEAFCE, GGIOAHEJDLJ DIMLHDJJHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC860", Offset = "0x7CEB460", VA = "0x187CEC860")]
	public void JFKFOMNKCKJ(GGIOAHEJDLJ LIPFJJEAFCE, GGIOAHEJDLJ DIMLHDJJHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7CEC780", Offset = "0x7CEB380", VA = "0x187CEC780")]
	public void BODDDFOHPPE(GGIOAHEJDLJ FGKFJDBOFLH, GGIOAHEJDLJ JHPFPLHIKAH, GGIOAHEJDLJ DIMLHDJJHIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class MLEDOHGGFLE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private KKMGDONHMBI GMBCCEAGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private IBGFIHDABMG DKIFPHGKANK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public MLEDOHGGFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6660", Offset = "0x7CF5260", VA = "0x187CF6660")]
	public void LEIJOMGLGOC(KKMGDONHMBI GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6430", Offset = "0x7CF5030", VA = "0x187CF6430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF67A0", Offset = "0x7CF53A0", VA = "0x187CF67A0")]
	private void OPMIMDPGIJD(LDINANBBIGL EOHMOFMBNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7CF63C0", Offset = "0x7CF4FC0", VA = "0x187CF63C0")]
	private void DLMJAAPMNAA(BJCCECIKIFB NJCDGENKHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6440", Offset = "0x7CF5040", VA = "0x187CF6440")]
	public void GHGFJKDKDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7CF6550", Offset = "0x7CF5150", VA = "0x187CF6550")]
	public void KGMDFACCNJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class BLDGCIJNCIP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OCMFCFCECMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public PFGPAPHADOM container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public OCMFCFCECMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7CF67E0", Offset = "0x7CF53E0", VA = "0x187CF67E0")]
		internal KKMGDONHMBI OACPCJGKAJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3900", Offset = "0x7CE2500", VA = "0x187CE3900")]
	public static void BIBNNPJAABO(PFGPAPHADOM MHCMGFKMEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3880", Offset = "0x7CE2480", VA = "0x187CE3880")]
	public static void ABEMCJCIHAK(PFGPAPHADOM MHCMGFKMEEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class OOFBGPJCJJE : IDisposable, PDLOBHNABMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, GJFJNBHMHNH> KJDNNGDCCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NIKAFOIACLJ IKHDFEJDINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PJKLNMKAAOE OMPONBMFDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NOKEJGBCBOE LLNCHDMNCFN;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker MHGCGECNALM;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7EB0", Offset = "0x7CF6AB0", VA = "0x187CF7EB0")]
	public OOFBGPJCJJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7800", Offset = "0x7CF6400", VA = "0x187CF7800", Slot = "7")]
	public void LEIJOMGLGOC(NOKEJGBCBOE LLNCHDMNCFN, PJKLNMKAAOE OMPONBMFDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7840", Offset = "0x7CF6440", VA = "0x187CF7840", Slot = "5")]
	public void LKCHIKMMAIL(OLKEDAALELH FLHGBHJICIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7190", Offset = "0x7CF5D90", VA = "0x187CF7190", Slot = "9")]
	public void GDMOGBELOEF(OLKEDAALELH BBNDNLBJEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7C90", Offset = "0x7CF6890", VA = "0x187CF7C90", Slot = "8")]
	public void PLANNFEKJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7CF74B0", Offset = "0x7CF60B0", VA = "0x187CF74B0", Slot = "10")]
	public void IAJMJAGPECL(OLKEDAALELH HPFBMBJDBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7AE0", Offset = "0x7CF66E0", VA = "0x187CF7AE0", Slot = "11")]
	public void OCODHMPKHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7CF7300", Offset = "0x7CF5F00", VA = "0x187CF7300")]
	private bool HCDLGIEKEIK(OLKEDAALELH IJDADKHAHCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class DCDBLNIKBBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct OMIILDAFPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly CBKCDBLGDLM KOPGLAKHJPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> IGPBDBLEJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly FBOLJECIJIH HKCFELKEELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly FBOLJECIJIH KNFBFLNCKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool KJNDHIOAIPC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool FKIDBAHMDKN
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7CF69F0", Offset = "0x7CF55F0", VA = "0x187CF69F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7120", Offset = "0x7CF5D20", VA = "0x187CF7120")]
		public OMIILDAFPPN(CBKCDBLGDLM KOPGLAKHJPA, HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC, [Optional] FBOLJECIJIH HKCFELKEELJ, [Optional] FBOLJECIJIH KNFBFLNCKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6850", Offset = "0x7CF5450", VA = "0x187CF6850")]
		public FBOLJECIJIH BLPDEIDOFHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6EF0", Offset = "0x7CF5AF0", VA = "0x187CF6EF0")]
		private FBOLJECIJIH JOONFEIEJGD([Out] FBOLJECIJIH NAAMOFNENFC, [Out] FBOLJECIJIH JPOFGLCEEHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6CD0", Offset = "0x7CF58D0", VA = "0x187CF6CD0")]
		private FBOLJECIJIH JAONCNLLGFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6FB0", Offset = "0x7CF5BB0", VA = "0x187CF6FB0")]
		private void MBLFKFOHKBH(FBOLJECIJIH LBEBCEMPDIJ, FBOLJECIJIH KIHBPMDFEOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7CF6B10", Offset = "0x7CF5710", VA = "0x187CF6B10")]
		private void CPLGFOENINE(FBOLJECIJIH NAAMOFNENFC, FBOLJECIJIH JPOFGLCEEHE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private KKMGDONHMBI GMBCCEAGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NOKEJGBCBOE LLNCHDMNCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private PDLOBHNABMH DMHFHCIEDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private IBGFIHDABMG DKIFPHGKANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool KALJEPGNOLC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FDAOEFJCPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE67D0", Offset = "0x7CE53D0", VA = "0x187CE67D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool MFOKJAPNHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4A50", Offset = "0x7CE3650", VA = "0x187CE4A50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7CE6130", Offset = "0x7CE4D30", VA = "0x187CE6130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7CE65C0", Offset = "0x7CE51C0", VA = "0x187CE65C0")]
	public void LEIJOMGLGOC(KKMGDONHMBI GMBCCEAGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4DD0", Offset = "0x7CE39D0", VA = "0x187CE4DD0")]
	public JBANPOMFHOI FEFHPKEINGI(bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6630", Offset = "0x7CE5230", VA = "0x187CE6630")]
	public JBANPOMFHOI NBIIHCCIJDI(HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5C20", Offset = "0x7CE4820", VA = "0x187CE5C20")]
	public void HECNACGGDCH(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5520", Offset = "0x7CE4120", VA = "0x187CE5520")]
	public void GAOLBJNEAOJ(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6E60", Offset = "0x7CE5A60", VA = "0x187CE6E60")]
	public void OLOCKLGKGAJ(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6150", Offset = "0x7CE4D50", VA = "0x187CE6150")]
	private void JMNPMBFNGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5CB0", Offset = "0x7CE48B0", VA = "0x187CE5CB0")]
	private FBOLJECIJIH HKHGLGIMKDC(CBKCDBLGDLM PBOIPJOJPLG, bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE5EE0", Offset = "0x7CE4AE0", VA = "0x187CE5EE0")]
	private static void HNBBIFBEEHB(CBKCDBLGDLM PBOIPJOJPLG, bool KJNDHIOAIPC, FBOLJECIJIH GAPFGOJCKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6820", Offset = "0x7CE5420", VA = "0x187CE6820")]
	private void NJMOMPGOMFH(CBKCDBLGDLM PBOIPJOJPLG, bool KJNDHIOAIPC, FBOLJECIJIH GAPFGOJCKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4A70", Offset = "0x7CE3670", VA = "0x187CE4A70")]
	private FBOLJECIJIH ADHMGHHEELP(CBKCDBLGDLM KOPGLAKHJPA, HashSet<Guid> IGPBDBLEJKM, bool KJNDHIOAIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4F40", Offset = "0x7CE3B40", VA = "0x187CE4F40")]
	private bool FHJJHDLJGLM(JBANPOMFHOI EMNFIFLHCBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE55C0", Offset = "0x7CE41C0", VA = "0x187CE55C0")]
	private bool GGAOCJLCFJC(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7CE70F0", Offset = "0x7CE5CF0", VA = "0x187CE70F0")]
	private bool PNOIGAPFLLD(JBANPOMFHOI LLNCHDMNCFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4C80", Offset = "0x7CE3880", VA = "0x187CE4C80")]
	private static bool BPKDPPDEPLI(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6BD0", Offset = "0x7CE57D0", VA = "0x187CE6BD0")]
	public static bool OEBCBCADPLG(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7CE51D0", Offset = "0x7CE3DD0", VA = "0x187CE51D0")]
	private GGIOAHEJDLJ FPDPPNIMEOE(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4B00", Offset = "0x7CE3700", VA = "0x187CE4B00")]
	private GGIOAHEJDLJ BGKCMPKJCGK(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6A40", Offset = "0x7CE5640", VA = "0x187CE6A40")]
	private GGIOAHEJDLJ NMIJJCOBBGC(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4D90", Offset = "0x7CE3990", VA = "0x187CE4D90")]
	private static Guid DPMMFDCPPJD(FBOLJECIJIH GAPFGOJCKND)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7CE64D0", Offset = "0x7CE50D0", VA = "0x187CE64D0")]
	private string LBLMNJJJHMN(FBOLJECIJIH GAPFGOJCKND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6340", Offset = "0x7CE4F40", VA = "0x187CE6340")]
	private bool LBHJFAKPAEG(CBKCDBLGDLM PBOIPJOJPLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7CE6E90", Offset = "0x7CE5A90", VA = "0x187CE6E90")]
	private static void PHJKCCBDCBH(CBKCDBLGDLM KOPGLAKHJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public DCDBLNIKBBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct APDKDOEMJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public GGIOAHEJDLJ DIMLHDJJHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public GGIOAHEJDLJ LIPFJJEAFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KAFANFFPAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int DOAEKANJDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 OJMBGNDBNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion NLIEJICFCBB;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HELDOBHLLAH FOLIFAHCKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3770", Offset = "0x7CE2370", VA = "0x187CE3770")]
		get
		{
			return default(HELDOBHLLAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HELDOBHLLAH EAOJJHBPHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3740", Offset = "0x7CE2340", VA = "0x187CE3740")]
		get
		{
			return default(HELDOBHLLAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3810", Offset = "0x7CE2410", VA = "0x187CE3810")]
	public APDKDOEMJFH(GGIOAHEJDLJ DIMLHDJJHIH, GGIOAHEJDLJ LIPFJJEAFCE, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NOKEJGBCBOE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	OLKEDAALELH MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEIJOMGLGOC(FCFPLIECMLG GMBCCEAGHDM);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GMCIGCMCEPH([In] APDKDOEMJFH PEDMEJIDLNB, bool GNDLEOGBFBN = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JDNGDLLEODP(GGIOAHEJDLJ HHLDEOFGCJA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ICLAHMOCNKM(GGIOAHEJDLJ LELCHKKKCMO, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PPAIKKEPGDC(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NBHJKDFBPBN();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AAJJLDCBMHA(Func<GGIOAHEJDLJ, bool> HMGPGIANECN);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KBJIMBLJAOE(GGIOAHEJDLJ GGCJLICHELN, HashSet<GGIOAHEJDLJ> EJOIEPGDFKJ);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<GGIOAHEJDLJ> BMEFFKJDOHH();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool OIGCLEGOEFP(GGIOAHEJDLJ GGCJLICHELN, [Out] HELDOBHLLAH NJADCMEGEHB);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CLJPCIIHPDA(NIKAFOIACLJ LKGGIMHKLEG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool NIKAFOIACLJ(OLKEDAALELH PBOIPJOJPLG);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface OLKEDAALELH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	GGIOAHEJDLJ OJNFNCJFGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	OLKEDAALELH AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HELDOBHLLAH PINGMKHMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool MIADIMGDFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GJFJNBHMHNH
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFFHNKPMBNJ(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCHIPIMOFIG(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCHOMKLENMA(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NFFCLINPLKC(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GJFJNBHMHNH Instantiate(Transform NMIBCHFJGAE);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMAAGOMLOEN();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface PJKLNMKAAOE
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LEIJOMGLGOC(Transform NMIBCHFJGAE, GJFJNBHMHNH JNFFGFODAGO);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GJFJNBHMHNH MNIAPGFHBFD();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DKOIGMCJNIL(GJFJNBHMHNH OMFFBIABODI);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface DMGGJOFINJM : LFBGCEKCIJO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBOLNFBODII();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDHCEEPPDKN(Guid OAKDFCIMAJM);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface PDLOBHNABMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKCHIKMMAIL(OLKEDAALELH FLHGBHJICIK);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEIJOMGLGOC(NOKEJGBCBOE LLNCHDMNCFN, PJKLNMKAAOE EIKCJGDHMPK);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLANNFEKJPN();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GDMOGBELOEF(OLKEDAALELH BBNDNLBJEBF);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IAJMJAGPECL(OLKEDAALELH HPFBMBJDBIL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCODHMPKHPL();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class CBKCDBLGDLM : OLKEDAALELH
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PMNCINOHPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public HELDOBHLLAH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CBKCDBLGDLM foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public PMNCINOHPBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7CF7F90", Offset = "0x7CF6B90", VA = "0x187CF7F90")]
		internal bool IPAIAPFDHHB(OLKEDAALELH x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private HELDOBHLLAH NJADCMEGEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<CBKCDBLGDLM> JCKAMMHMPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private CBKCDBLGDLM GFJGGMDENLM;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HELDOBHLLAH PINGMKHMHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x13CEFE0", Offset = "0x13CDBE0", VA = "0x1813CEFE0", Slot = "6")]
		get
		{
			return default(HELDOBHLLAH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x13CF700", Offset = "0x13CE300", VA = "0x1813CF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private CBKCDBLGDLM LIPFJJEAFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3C40", Offset = "0x7CE2840", VA = "0x187CE3C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OLKEDAALELH AJPFGIFICJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA247E0", Offset = "0xA233E0", VA = "0x180A247E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GGIOAHEJDLJ OJNFNCJFGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MIADIMGDFEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7CE4500", Offset = "0x7CE3100", VA = "0x187CE4500", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FCPPEJCMPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7CE44B0", Offset = "0x7CE30B0", VA = "0x187CE44B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected CBKCDBLGDLM HMGDINOCJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE3E90", Offset = "0x7CE2A90", VA = "0x187CE3E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7CE46C0", Offset = "0x7CE32C0", VA = "0x187CE46C0")]
	public CBKCDBLGDLM(HELDOBHLLAH MMNEGPOOEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4360", Offset = "0x7CE2F60", VA = "0x187CE4360")]
	public CBKCDBLGDLM LAIHPFGHOIE(HELDOBHLLAH IMCKKHENKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CE41E0", Offset = "0x7CE2DE0", VA = "0x187CE41E0")]
	public CBKCDBLGDLM IMKIOBHMDFI(HELDOBHLLAH AOPDHFCIJFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3EB0", Offset = "0x7CE2AB0", VA = "0x187CE3EB0")]
	public CBKCDBLGDLM HMCNGGMNMHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4090", Offset = "0x7CE2C90", VA = "0x187CE4090")]
	public void ILJKHADAMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7CE4510", Offset = "0x7CE3110", VA = "0x187CE4510")]
	public CBKCDBLGDLM OAEJNILHEEP(HELDOBHLLAH JHPFPLHIKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3D20", Offset = "0x7CE2920", VA = "0x187CE3D20")]
	private static void CLJPCIIHPDA(CBKCDBLGDLM JEPHDOCKBPG, NIKAFOIACLJ JLJMNCGIOCA, bool NBGEMFALIBC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7CE3E80", Offset = "0x7CE2A80", VA = "0x187CE3E80", Slot = "9")]
	public void CLJPCIIHPDA(NIKAFOIACLJ LKGGIMHKLEG, bool EPHELGLFELA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7CE45C0", Offset = "0x7CE31C0", VA = "0x187CE45C0")]
	public static CBKCDBLGDLM PHGNNIFFECO(CBKCDBLGDLM JEPHDOCKBPG, HELDOBHLLAH DBBBOPDIFFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface IBGFIHDABMG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool FDAOEFJCPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<LDINANBBIGL> OPMIMDPGIJD;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<BJCCECIKIFB> DLMJAAPMNAA;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GFFHNKPMBNJ(KKMGDONHMBI GMBCCEAGHDM, CJIPBDANJGM JMDMDFHNKAF);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NJEOPPDELLP(GGIOAHEJDLJ LELCHKKKCMO, GGIOAHEJDLJ JEMJJKEPHBL, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FCNODMBHNPO(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IGIFMMJOCOE(JBANPOMFHOI EGAAAAFDAOP, [Optional] BJCCECIKIFB GCBAKMPBFCC);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class MEDNEHPMAEI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type JKOHHHGJLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5F00", Offset = "0x7CF4B00", VA = "0x187CF5F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object LBPNLDGACAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5EC0", Offset = "0x7CF4AC0", VA = "0x187CF5EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5F60", Offset = "0x7CF4B60", VA = "0x187CF5F60")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class LEBMHGPJAHE : IBGFIHDABMG, IDisposable, KMNPOEKIMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private KKMGDONHMBI GMBCCEAGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CJIPBDANJGM OFHOFBPPJIA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool FDAOEFJCPOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7CF49C0", Offset = "0x7CF35C0", VA = "0x187CF49C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool IDBGBOKLOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4480", Offset = "0x7CF3080", VA = "0x187CF4480", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView EEPDIJAKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4B50", Offset = "0x7CF3750", VA = "0x187CF4B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<LDINANBBIGL> OPMIMDPGIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4770", Offset = "0x7CF3370", VA = "0x187CF4770", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4800", Offset = "0x7CF3400", VA = "0x187CF4800", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BJCCECIKIFB> DLMJAAPMNAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF43E0", Offset = "0x7CF2FE0", VA = "0x187CF43E0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7CF4510", Offset = "0x7CF3110", VA = "0x187CF4510", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7CF46E0", Offset = "0x7CF32E0", VA = "0x187CF46E0", Slot = "10")]
	public void GFFHNKPMBNJ(KKMGDONHMBI GMBCCEAGHDM, CJIPBDANJGM OFHOFBPPJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7CF44C0", Offset = "0x7CF30C0", VA = "0x187CF44C0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4A20", Offset = "0x7CF3620", VA = "0x187CF4A20", Slot = "11")]
	public void NJEOPPDELLP(GGIOAHEJDLJ LELCHKKKCMO, GGIOAHEJDLJ JEMJJKEPHBL, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7CF45B0", Offset = "0x7CF31B0", VA = "0x187CF45B0", Slot = "12")]
	public void FCNODMBHNPO(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4890", Offset = "0x7CF3490", VA = "0x187CF4890", Slot = "13")]
	public void IGIFMMJOCOE(JBANPOMFHOI EGAAAAFDAOP, [Optional] BJCCECIKIFB GCBAKMPBFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4E20", Offset = "0x7CF3A20", VA = "0x187CF4E20")]
	[CHIJNBOPIHK]
	private void RpcMasterReparentNodes(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4C20", Offset = "0x7CF3820", VA = "0x187CF4C20")]
	[CHIJNBOPIHK]
	private void RpcMasterModifyNode(GGIOAHEJDLJ LELCHKKKCMO, GGIOAHEJDLJ JEMJJKEPHBL, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5220", Offset = "0x7CF3E20", VA = "0x187CF5220")]
	[CHIJNBOPIHK]
	private void RpcReparentNodes(GGIOAHEJDLJ HBBGIEOFIMI, int KOCLONOPCPP, GGIOAHEJDLJ JHPFPLHIKAH, int CDMCNBHNHPP, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB, EEIJICMJMPB NLLELGKGOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7CF5130", Offset = "0x7CF3D30", VA = "0x187CF5130")]
	[CHIJNBOPIHK]
	private void RpcModifyNode(GGIOAHEJDLJ LELCHKKKCMO, int KAFANFFPAML, int DOAEKANJDLD, Vector3 OJMBGNDBNBO, Quaternion NLIEJICFCBB, EEIJICMJMPB NLLELGKGOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7CF4BE0", Offset = "0x7CF37E0", VA = "0x187CF4BE0")]
	[CHIJNBOPIHK]
	private void RpcDeserializeConnectableGraph(JBANPOMFHOI LLNCHDMNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LEBMHGPJAHE()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, GJFJNBHMHNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5510", Offset = "0x7CF4110", VA = "0x187CF5510", Slot = "4")]
		private void ABOACKHEIIL(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5690", Offset = "0x7CF4290", VA = "0x187CF5690", Slot = "5")]
		private void CKBMKEMPDCD(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5900", Offset = "0x7CF4500", VA = "0x187CF5900", Slot = "6")]
		private void GBHBLNNFENK(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5A60", Offset = "0x7CF4660", VA = "0x187CF5A60", Slot = "7")]
		private void OAJIGJLNMCO(GGIOAHEJDLJ JKOJPMPOPEI, HELDOBHLLAH DIMLHDJJHIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5CB0", Offset = "0x7CF48B0", VA = "0x187CF5CB0", Slot = "8")]
		private GJFJNBHMHNH OJPKAMPNCHH(Transform NMIBCHFJGAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CF5C50", Offset = "0x7CF4850", VA = "0x187CF5C50", Slot = "9")]
		private void OEBJOPAPJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class MDDKELIFKJK
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEC30", Offset = "0x3BAD830", VA = "0x183BAEC30")]
	public static MDGDCMCLGCB<T> PHLBKHHMPIL<T>(this PFGPAPHADOM MHCMGFKMEEN)
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
