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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C71850", Offset = "0x7C70250", VA = "0x187C71850", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x21CF550", Offset = "0x21CDF50", VA = "0x1821CF550", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C79980", Offset = "0x7C78380", VA = "0x187C79980")]
		private void LNHKNJMKPNK(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C79810", Offset = "0x7C78210", VA = "0x187C79810")]
		private void LEGOBPIAIHA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C79AF0", Offset = "0x7C784F0", VA = "0x187C79AF0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C79E30", Offset = "0x7C78830", VA = "0x187C79E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NDAMCIEPIJA : NJFENKJHKPO, IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class INHAMHHBGNB : IEnumerable<HCFLGOPIIBP>, IEnumerable, IEnumerator<HCFLGOPIIBP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HCFLGOPIIBP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private ENAPEPFMDAJ localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ENAPEPFMDAJ <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NDAMCIEPIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private LIEJCDBGGEG <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private KAGMCHPMLPA <childEntities>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private KAGMCHPMLPA.ADLEKPBOAHP <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private HCFLGOPIIBP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xF1BA30", Offset = "0xF1A430", VA = "0x180F1BA30")]
		[DebuggerHidden]
		public INHAMHHBGNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E760", Offset = "0x7C6D160", VA = "0x187C6E760", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E2E0", Offset = "0x7C6CCE0", VA = "0x187C6E2E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E2C0", Offset = "0x7C6CCC0", VA = "0x187C6E2C0")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E640", Offset = "0x7C6D040", VA = "0x187C6E640")]
		private void NODCBNAELMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E710", Offset = "0x7C6D110", VA = "0x187C6E710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E660", Offset = "0x7C6D060", VA = "0x187C6E660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HCFLGOPIIBP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E660", Offset = "0x7C6D060", VA = "0x187C6E660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class HHCHBMIEKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NDAMCIEPIJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public INHHIPBBNEG nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HHCHBMIEKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D3C0", Offset = "0x7C6BDC0", VA = "0x187C6D3C0")]
		internal object ALJEHNDAGIE(INHHIPBBNEG x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BMACNLFECPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public INHHIPBBNEG child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public HHCHBMIEKCC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BMACNLFECPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7C64DA0", Offset = "0x7C637A0", VA = "0x187C64DA0")]
		internal object BAHJIKDJGCB((INHHIPBBNEG child, INHHIPBBNEG nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly COJJKFBGGKB DJKIDCPLGPD;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly COJJKFBGGKB DAKJPKCPDGM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly COJJKFBGGKB DKJIEIGHGBO;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly COJJKFBGGKB KPNGHEIJOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CIKMOHIBDEH PIIHCJAEIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MPJMMKIMNOF HFNJMFEEMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private CAADPBPBGFN AJDHBNGEIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private DAICDJOIDCC FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AENANBBBHCL GLAIAEOPOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private PMOEPKGMOEK MIFCFCLAJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly PGOCJGJDHJC CCGCAONCGHG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA17BD0", Offset = "0xA165D0", VA = "0x180A17BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OCGEPKIAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP> EHCMIKKCIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C75C80", Offset = "0x7C74680", VA = "0x187C75C80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C75BD0", Offset = "0x7C745D0", VA = "0x187C75BD0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP> JNPHJHFNNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C75480", Offset = "0x7C73E80", VA = "0x187C75480", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C76250", Offset = "0x7C74C50", VA = "0x187C76250", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP, HCFLGOPIIBP> FAHEKHHMJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C775C0", Offset = "0x7C75FC0", VA = "0x187C775C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C74FA0", Offset = "0x7C739A0", VA = "0x187C74FA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C78860", Offset = "0x7C77260", VA = "0x187C78860")]
	public NDAMCIEPIJA(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C74C80", Offset = "0x7C73680", VA = "0x187C74C80", Slot = "12")]
	public void DBILOAODCDE(GameObject HNGFDIJGINB, ALIMKLIALCB IHABGLIIKNE, ILJICCEHOHM GAMOJFHOMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C77B90", Offset = "0x7C76590", VA = "0x187C77B90", Slot = "26")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C74850", Offset = "0x7C73250", VA = "0x187C74850", Slot = "22")]
	public bool BKECCFCEJAN(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C780F0", Offset = "0x7C76AF0", VA = "0x187C780F0")]
	private void OHKFBCLCAIE(ENAPEPFMDAJ NPFDLEBGDFC, ENAPEPFMDAJ DHMKEFMFLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C759B0", Offset = "0x7C743B0", VA = "0x187C759B0")]
	private void FGEOIBEHAJK(ENAPEPFMDAJ NPFDLEBGDFC, ENAPEPFMDAJ FGELOGPCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C77D80", Offset = "0x7C76780", VA = "0x187C77D80")]
	private void NIDNCJJFHGK(ENAPEPFMDAJ NPFDLEBGDFC, ENAPEPFMDAJ FGELOGPCHNG, ENAPEPFMDAJ DHMKEFMFLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C78300", Offset = "0x7C76D00", VA = "0x187C78300")]
	private void OLIKJCMOKCH(ENAPEPFMDAJ NPFDLEBGDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "13")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C756B0", Offset = "0x7C740B0", VA = "0x187C756B0", Slot = "14")]
	public void EPIAMCEAEFP(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "15")]
	public void IAJHDKMEFKB(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C76840", Offset = "0x7C75240", VA = "0x187C76840", Slot = "17")]
	public void IMHJALKEMHE(HCFLGOPIIBP CGJBEMKJPKN, HCFLGOPIIBP MFOGENNLKAB, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C76700", Offset = "0x7C75100", VA = "0x187C76700")]
	public void IMHJALKEMHE(ENAPEPFMDAJ GBGDJHDAECJ, ENAPEPFMDAJ MFOGENNLKAB, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C761C0", Offset = "0x7C74BC0", VA = "0x187C761C0")]
	public void HHLPKLPLJAO(HCFLGOPIIBP CGJBEMKJPKN, float MHEMELNGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C751E0", Offset = "0x7C73BE0", VA = "0x187C751E0", Slot = "18")]
	public void EIONIHAOGCP(HCFLGOPIIBP INDFOIADBGE, int DKCGCDGDBOO, HCFLGOPIIBP ECGLFIAHLIJ, int HOHNBCDNKBK, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C77FE0", Offset = "0x7C769E0", VA = "0x187C77FE0")]
	private float ODKKCDAMAIM(ENAPEPFMDAJ GBGDJHDAECJ, ENAPEPFMDAJ EAGGHBKHKHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C75340", Offset = "0x7C73D40", VA = "0x187C75340")]
	public void EIONIHAOGCP(ENAPEPFMDAJ GBGDJHDAECJ, ENAPEPFMDAJ EAGGHBKHKHF, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD, bool ALJBOINGFEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C74B10", Offset = "0x7C73510", VA = "0x187C74B10", Slot = "19")]
	public void CNMFPBECPOG(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C75D30", Offset = "0x7C74730", VA = "0x187C75D30", Slot = "16")]
	public void GBHCABHEJPN(HCFLGOPIIBP CGJBEMKJPKN, HashSet<HCFLGOPIIBP> DOACJJGBIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "20")]
	public HCKEKAGNNBL FCGDJJEKOBH(bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "21")]
	public HCKEKAGNNBL LMNEAFEMEAC(HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C74250", Offset = "0x7C72C50", VA = "0x187C74250", Slot = "23")]
	public void APNCIAIGPFB(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C748A0", Offset = "0x7C732A0", VA = "0x187C748A0", Slot = "24")]
	public void BKIHIJCNEJM(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C74230", Offset = "0x7C72C30", VA = "0x187C74230", Slot = "25")]
	public void ALNLGKINFDJ(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C76300", Offset = "0x7C74D00", VA = "0x187C76300")]
	private void IMHDEKEMOND(ENAPEPFMDAJ GBGDJHDAECJ, ENAPEPFMDAJ EAGGHBKHKHF, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD, float MHEMELNGBHJ, bool ALJBOINGFEL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C769A0", Offset = "0x7C753A0", VA = "0x187C769A0")]
	private void JDOHKLBPMJC(ENAPEPFMDAJ GBGDJHDAECJ, ENAPEPFMDAJ FEIPCFECKLD, Vector3 ANDPKFCEGDK, Quaternion MCCAAFGCCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7C74030", Offset = "0x7C72A30", VA = "0x187C74030")]
	private void ADJICHJMFJC(ENAPEPFMDAJ GBGDJHDAECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C74F10", Offset = "0x7C73910", VA = "0x187C74F10")]
	[IteratorStateMachine(typeof(INHAMHHBGNB))]
	public IEnumerable<HCFLGOPIIBP> DDGIMEDIFBP(ENAPEPFMDAJ MBIJJAIIOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C776D0", Offset = "0x7C760D0", VA = "0x187C776D0")]
	internal HCFLGOPIIBP MIBHMNPMGOB(ENAPEPFMDAJ MBIJJAIIOHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7C75050", Offset = "0x7C73A50", VA = "0x187C75050")]
	internal ENAPEPFMDAJ DJKLHMDONLD(HCFLGOPIIBP CGJBEMKJPKN)
	{
		return default(ENAPEPFMDAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C742C0", Offset = "0x7C72CC0", VA = "0x187C742C0")]
	private bool BECPIGLIKOG(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C77670", Offset = "0x7C76070", VA = "0x187C77670")]
	private bool MGOHOJMJDEO(INHHIPBBNEG FENDIEDGFFH, [Out] HCFLGOPIIBP EAGGHBKHKHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7C77800", Offset = "0x7C76200", VA = "0x187C77800")]
	private HCFLGOPIIBP MIBHMNPMGOB(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C75530", Offset = "0x7C73F30", VA = "0x187C75530")]
	private HCFLGOPIIBP ENPNFIOJNPH(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C73E60", Offset = "0x7C72860", VA = "0x187C73E60")]
	private HCFLGOPIIBP ACLLEDLCFHF(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BB50", Offset = "0x7C6A550", VA = "0x187C6BB50")]
	private static Guid LNJGKCMODBO(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C74A20", Offset = "0x7C73420", VA = "0x187C74A20")]
	private string CAIOBJIMDFH(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C772A0", Offset = "0x7C75CA0", VA = "0x187C772A0")]
	private void JMALBMIJGGF(HCFLGOPIIBP GBGDJHDAECJ, HCFLGOPIIBP FEIPCFECKLD, RigidTransform MCMAFBKNOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C740A0", Offset = "0x7C72AA0", VA = "0x187C740A0")]
	private void AEDHJMGNDGE(HCFLGOPIIBP FEIPCFECKLD, HCFLGOPIIBP GBGDJHDAECJ, RigidTransform MCMAFBKNOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C78090", Offset = "0x7C76A90", VA = "0x187C78090")]
	private void OHDHHIPBGCK(HCFLGOPIIBP OGLNHOKFGHC, HCFLGOPIIBP GBGDJHDAECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C77430", Offset = "0x7C75E30", VA = "0x187C77430")]
	private void LJPIAOEHJFN(HCFLGOPIIBP GBGDJHDAECJ, HCFLGOPIIBP EAGGHBKHKHF, RigidTransform MCMAFBKNOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C74910", Offset = "0x7C73310", VA = "0x187C74910")]
	private void BNEEMEBLMAC(ENAPEPFMDAJ MBIJJAIIOHD, HCFLGOPIIBP CGJBEMKJPKN, ENAPEPFMDAJ FGELOGPCHNG, ENAPEPFMDAJ DHMKEFMFLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C75F40", Offset = "0x7C74940", VA = "0x187C75F40")]
	private void GFAOPNANENF(ENAPEPFMDAJ MBIJJAIIOHD, HCFLGOPIIBP CGJBEMKJPKN, HCFLGOPIIBP EOFFGOPJBCD, HCFLGOPIIBP PCAJKGLMDAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PKPABNGFFEN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GALOMFGPABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public MHGNCMHMEKD container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GALOMFGPABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A1F0", Offset = "0x7C68BF0", VA = "0x187C6A1F0")]
		internal NDAMCIEPIJA HGFJPDLBIBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C79430", Offset = "0x7C77E30", VA = "0x187C79430")]
	public static void FJIEOAFCGFA(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C795B0", Offset = "0x7C77FB0", VA = "0x187C795B0")]
	public static void LFBHFCDHJFP(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class MFECBIGHFHD : BEGFMBJJCNO, APMLPNJMKGE
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly RigidbodyEx OGMEFONHICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly NDAMCIEPIJA BEANOICFNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly KEPDJLOABHE MMCPAPOGIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly BKMGNMCMEFL FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly DOOMFJDMLIC[] GHFFNGODEMI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(ENAPEPFMDAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HCFLGOPIIBP NAEPPEPILFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7C735C0", Offset = "0x7C71FC0", VA = "0x187C735C0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HCFLGOPIIBP AGEHOOIOKCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7C728A0", Offset = "0x7C712A0", VA = "0x187C728A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 ECKMHODCKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C73240", Offset = "0x7C71C40", VA = "0x187C73240", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion FNPJHHHBFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C71A90", Offset = "0x7C70490", VA = "0x187C71A90", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool MGFAKCEOGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C71C50", Offset = "0x7C70650", VA = "0x187C71C50", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<HCFLGOPIIBP> FABIOFKDOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C72510", Offset = "0x7C70F10", VA = "0x187C72510", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool EIDGBIMFBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xCA7110", Offset = "0xCA5B10", VA = "0x180CA7110", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCDBBB0", Offset = "0xCDA5B0", VA = "0x180CDBBB0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C737C0", Offset = "0x7C721C0", VA = "0x187C737C0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject MIGFNEFDENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C734E0", Offset = "0x7C71EE0", VA = "0x187C734E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C73500", Offset = "0x7C71F00", VA = "0x187C73500", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid BCBNPFMJDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7C73620", Offset = "0x7C72020", VA = "0x187C73620", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int HANEDBFHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C73700", Offset = "0x7C72100", VA = "0x187C73700", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool NFBBFHHHIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool HNPGBPIODPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C72660", Offset = "0x7C71060", VA = "0x187C72660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event LKBIACAFMMD OCJCOCLLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7C73130", Offset = "0x7C71B30", VA = "0x187C73130", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C71AF0", Offset = "0x7C704F0", VA = "0x187C71AF0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LKBIACAFMMD HMAJPFKCOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7C730D0", Offset = "0x7C71AD0", VA = "0x187C730D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C73190", Offset = "0x7C71B90", VA = "0x187C73190", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LKBIACAFMMD FANKDIEEMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C71BF0", Offset = "0x7C705F0", VA = "0x187C71BF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7C722B0", Offset = "0x7C70CB0", VA = "0x187C722B0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BFAJHMBLGKJ HKHCHIIDOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C732A0", Offset = "0x7C71CA0", VA = "0x187C732A0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7C719F0", Offset = "0x7C703F0", VA = "0x187C719F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7C733E0", Offset = "0x7C71DE0", VA = "0x187C733E0")]
	public MFECBIGHFHD(ENAPEPFMDAJ PIIGBAMEEMF, RigidbodyEx OGMEFONHICP, KEPDJLOABHE MMCPAPOGIOK, DOOMFJDMLIC[] GHFFNGODEMI, BKMGNMCMEFL FLJMNPJIKOM, NJFENKJHKPO BEANOICFNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C71FA0", Offset = "0x7C709A0", VA = "0x187C71FA0", Slot = "19")]
	public void FHOCOEECEGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "21")]
	public void PDCHBELLKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79BB680", Offset = "0x79BA080", VA = "0x1879BB680", Slot = "22")]
	public void PLHIANKEOME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C731F0", Offset = "0x7C71BF0", VA = "0x187C731F0", Slot = "20")]
	public void OAPJNMIFIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C720A0", Offset = "0x7C70AA0", VA = "0x187C720A0", Slot = "25")]
	public void GHDMOPHJHIF(int IHLHDIAIIPD, HCFLGOPIIBP ECGLFIAHLIJ, int DFLKPKAHKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7C71FD0", Offset = "0x7C709D0", VA = "0x187C71FD0", Slot = "26")]
	public void FNHLJEGBDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C71CC0", Offset = "0x7C706C0", VA = "0x187C71CC0", Slot = "27")]
	public void EKFOHEJAMAA(int IHLHDIAIIPD, HCFLGOPIIBP INDFOIADBGE, int KDCGKELBLCC, [Optional] Vector3? GEJHLHLCIPD, [Optional] Quaternion? BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C72540", Offset = "0x7C70F40", VA = "0x187C72540", Slot = "28")]
	public void JCGIJCOLPFJ(HCFLGOPIIBP INDFOIADBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7C72C70", Offset = "0x7C71670", VA = "0x187C72C70", Slot = "31")]
	public void MKHHPIKGKGO(Vector3 NDEOEKIANDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C72960", Offset = "0x7C71360", VA = "0x187C72960", Slot = "29")]
	public void MHFBOFOIMCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7C726B0", Offset = "0x7C710B0", VA = "0x187C726B0", Slot = "30")]
	public void LAHLDELIIAH(int MNFHMLCLFEB, Vector3 NHKLJJMEOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C72440", Offset = "0x7C70E40", VA = "0x187C72440", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int IHLHDIAIIPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C72310", Offset = "0x7C70D10", VA = "0x187C72310", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int IHLHDIAIIPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xC84CB0", Offset = "0xC836B0", VA = "0x180C84CB0", Slot = "42")]
	public Color GetConnectionSlotColor(int IHLHDIAIIPD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7C71B50", Offset = "0x7C70550", VA = "0x187C71B50", Slot = "43")]
	public bool CanConnectTo(int IHLHDIAIIPD, HCFLGOPIIBP DLHMGBDGIMJ, int AGCDLBBCAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "44")]
	public void ParentChanged(int IHLHDIAIIPD, HCFLGOPIIBP DDLIBBHDFJF, int FFMJPLOCDMC, Vector3 PDBANFDKLEO, Quaternion KDINDMAAFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "45")]
	public void ChildAdded(int IHLHDIAIIPD, HCFLGOPIIBP LJHLINFLGOA, int PGLMMCPDGLF, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "46")]
	public void ChildRemoved(int IHLHDIAIIPD, HCFLGOPIIBP CJBEIIKCIHC, int MBGOGHEJOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "47")]
	public void ConnectionModified(int IHLHDIAIIPD, HCFLGOPIIBP ECGLFIAHLIJ, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C73340", Offset = "0x7C71D40", VA = "0x187C73340", Slot = "48")]
	public void RootChanged(HCFLGOPIIBP CGLIJIPKKCB, HCFLGOPIIBP APMLNANHOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C72610", Offset = "0x7C71010", VA = "0x187C72610", Slot = "23")]
	public void JFCDDCFGLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C73080", Offset = "0x7C71A80", VA = "0x187C73080", Slot = "24")]
	public void MLCPKGGBJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7C725C0", Offset = "0x7C70FC0", VA = "0x187C725C0")]
	private void JFBPIDDEHBE(bool BKHMFKGHGNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(ABKJDDLGCGM), new string[] { })]
public class GPGJOFLCHKC : ABKJDDLGCGM, JEKAABCJIBE, HKKELALCKCD
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DAJDPJEMDBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DAJDPJEMDBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[DependsOn]
	private DABNPIKGAJE MKNDHMJOBPH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object OIODALOOOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C6C990", Offset = "0x7C6B390", VA = "0x187C6C990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C940", Offset = "0x7C6B340", VA = "0x187C6C940", Slot = "5")]
	private void LAICDJPNDMA(FKFJNEKJHIE CCGCAONCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x11DFC50", Offset = "0x11DE650", VA = "0x1811DFC50", Slot = "6")]
	private void CBBMFAEKICE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GPGJOFLCHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(NJFENKJHKPO), new string[] { "Ignore", "Mock" })]
public class KIFDPPCBGDM : NJFENKJHKPO, IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool OCGEPKIAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP> EHCMIKKCIDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EB90", Offset = "0x7C6D590", VA = "0x187C6EB90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EAE0", Offset = "0x7C6D4E0", VA = "0x187C6EAE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP> JNPHJHFNNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EA30", Offset = "0x7C6D430", VA = "0x187C6EA30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC40", Offset = "0x7C6D640", VA = "0x187C6EC40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP, HCFLGOPIIBP> FAHEKHHMJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6ECF0", Offset = "0x7C6D6F0", VA = "0x187C6ECF0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E980", Offset = "0x7C6D380", VA = "0x187C6E980", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "26")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "12")]
	public void DBILOAODCDE(GameObject HNGFDIJGINB, ALIMKLIALCB IHABGLIIKNE, ILJICCEHOHM HHNKNLGOCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "13")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "14")]
	public void EPIAMCEAEFP(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "15")]
	public void IAJHDKMEFKB(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "16")]
	public void GBHCABHEJPN(HCFLGOPIIBP CGJBEMKJPKN, HashSet<HCFLGOPIIBP> DOACJJGBIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "17")]
	public void IMHJALKEMHE(HCFLGOPIIBP CGJBEMKJPKN, HCFLGOPIIBP MFOGENNLKAB, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "18")]
	public void EIONIHAOGCP(HCFLGOPIIBP CGJBEMKJPKN, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "19")]
	public void CNMFPBECPOG(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "20")]
	public HCKEKAGNNBL FCGDJJEKOBH(bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "21")]
	public HCKEKAGNNBL LMNEAFEMEAC(HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "22")]
	public bool BKECCFCEJAN(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "23")]
	public void APNCIAIGPFB(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "24")]
	public void BKIHIJCNEJM(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "25")]
	public void ALNLGKINFDJ(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public KIFDPPCBGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HCFLGOPIIBP : APMLPNJMKGE, IEquatable<HCFLGOPIIBP>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface APMLPNJMKGE
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HCFLGOPIIBP NAEPPEPILFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform OIBPIKEGOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MIGFNEFDENP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string HMKINKIIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid BCBNPFMJDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int HANEDBFHLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ENAPEPFMDAJ IEABHEICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NFBBFHHHIAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int IHLHDIAIIPD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int IHLHDIAIIPD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int IHLHDIAIIPD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int IHLHDIAIIPD, HCFLGOPIIBP DLHMGBDGIMJ, int NFLLEGDDFPC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int IHLHDIAIIPD, HCFLGOPIIBP DDLIBBHDFJF, int FFMJPLOCDMC, Vector3 PDBANFDKLEO, Quaternion KDINDMAAFNF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int IHLHDIAIIPD, HCFLGOPIIBP LJHLINFLGOA, int PGLMMCPDGLF, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int IHLHDIAIIPD, HCFLGOPIIBP CJBEIIKCIHC, int MBGOGHEJOJM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int IHLHDIAIIPD, HCFLGOPIIBP ECGLFIAHLIJ, int CLIJNEAHMFE, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(HCFLGOPIIBP CGLIJIPKKCB, HCFLGOPIIBP APMLNANHOKA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface NJFENKJHKPO : IIAKOCKOOML
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool OCGEPKIAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<HCFLGOPIIBP, HCFLGOPIIBP> EHCMIKKCIDM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<HCFLGOPIIBP, HCFLGOPIIBP> JNPHJHFNNGG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<HCFLGOPIIBP, HCFLGOPIIBP, HCFLGOPIIBP> FAHEKHHMJIN;

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DBILOAODCDE(GameObject HNGFDIJGINB, ALIMKLIALCB IHABGLIIKNE, ILJICCEHOHM NMLOLPLBMJC);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FPILOHDMIEH();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EPIAMCEAEFP(HCFLGOPIIBP CGJBEMKJPKN);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IAJHDKMEFKB(HCFLGOPIIBP CGJBEMKJPKN);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GBHCABHEJPN(HCFLGOPIIBP CGJBEMKJPKN, HashSet<HCFLGOPIIBP> DOACJJGBIBO);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IMHJALKEMHE(HCFLGOPIIBP CGJBEMKJPKN, HCFLGOPIIBP MFOGENNLKAB, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EIONIHAOGCP(HCFLGOPIIBP CGJBEMKJPKN, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void CNMFPBECPOG(HCFLGOPIIBP CGJBEMKJPKN);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HCKEKAGNNBL FCGDJJEKOBH(bool CLMHEOCCDHE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	HCKEKAGNNBL LMNEAFEMEAC(HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool BKECCFCEJAN(INHHIPBBNEG FENDIEDGFFH);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void APNCIAIGPFB(HCKEKAGNNBL MAHFLPOCDJP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BKIHIJCNEJM(HCKEKAGNNBL MAHFLPOCDJP);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ALNLGKINFDJ(HCKEKAGNNBL MAHFLPOCDJP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DAICDJOIDCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCFLGOPIIBP ACLLEDLCFHF(int EKENJLJPGDD);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HCFLGOPIIBP ENPNFIOJNPH(Guid FFBLPGKGBAA);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FIHOMAMCKLO(HCFLGOPIIBP CGJBEMKJPKN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BLCNDGFKDAA();

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NIPEBNPPIJE(HCFLGOPIIBP MMCPAPOGIOK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface BKMGNMCMEFL
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNPGBPIODPE(KEPDJLOABHE MMCPAPOGIOK);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JIGEIKPJMBD(KEPDJLOABHE MMCPAPOGIOK);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FJIDIDCPMIN(KEPDJLOABHE MMCPAPOGIOK);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid GGCCAPMKBKD(KEPDJLOABHE MMCPAPOGIOK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int CPMPCIKBLNG(KEPDJLOABHE MMCPAPOGIOK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NOPFGJNGEEH(KEPDJLOABHE MMCPAPOGIOK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void LKBIACAFMMD(HCFLGOPIIBP INDFOIADBGE, int CPMOEMIAMAE, HCFLGOPIIBP ECGLFIAHLIJ, int BNNKPJJLMNK, [Optional] Vector3? GEJHLHLCIPD, [Optional] Quaternion? BDPCKMPOLMM);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BFAJHMBLGKJ(HCFLGOPIIBP CGLIJIPKKCB, HCFLGOPIIBP APMLNANHOKA);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface KEPDJLOABHE : HCFLGOPIIBP, APMLPNJMKGE, IEquatable<HCFLGOPIIBP>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BEGFMBJJCNO : APMLPNJMKGE
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HCFLGOPIIBP AGEHOOIOKCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<HCFLGOPIIBP> FABIOFKDOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 ECKMHODCKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion FNPJHHHBFIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MGFAKCEOGOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool EIDGBIMFBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event LKBIACAFMMD OCJCOCLLCEL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event LKBIACAFMMD HMAJPFKCOHP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event LKBIACAFMMD FANKDIEEMPJ;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BFAJHMBLGKJ HKHCHIIDOCJ;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void FHOCOEECEGJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OAPJNMIFIFA();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void PDCHBELLKKH();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PLHIANKEOME();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JFCDDCFGLEC();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MLCPKGGBJNC();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GHDMOPHJHIF(int IHLHDIAIIPD, HCFLGOPIIBP ECGLFIAHLIJ, int DFLKPKAHKJI);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FNHLJEGBDEM();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EKFOHEJAMAA(int IHLHDIAIIPD, HCFLGOPIIBP INDFOIADBGE, int KDCGKELBLCC, [Optional] Vector3? GEJHLHLCIPD, [Optional] Quaternion? BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JCGIJCOLPFJ(HCFLGOPIIBP INDFOIADBGE);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MHFBOFOIMCH();

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LAHLDELIIAH(int MNFHMLCLFEB, Vector3 NHKLJJMEOLP);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MKHHPIKGKGO(Vector3 NDEOEKIANDD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DOOMFJDMLIC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 EIAKFGKJHDL
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
public interface ALIMKLIALCB
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KLGHHNKBMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	MJAAFHKHPBA BINHGNEILKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, ALIMKLIALCB
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
			[Cpp2IlInjected.Address(RVA = "0xA62AE0", Offset = "0xA614E0", VA = "0x180A62AE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public MJAAFHKHPBA LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C65F70", Offset = "0x7C64970", VA = "0x187C65F70")]
		public static ConnectableConfigData KNKKMGNDPAH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C66030", Offset = "0x7C64A30", VA = "0x187C66030")]
		public ConnectableConfigData(LegacyConnectableLinkVisual DIPCLABHFCL, bool CKBIJLGPFKO)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NEHEEDGBPJM : IEquatable<NEHEEDGBPJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public HCFLGOPIIBP CGJBEMKJPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int MFGDHAHMLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int CLIJNEAHMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector3 GEJHLHLCIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Quaternion BDPCKMPOLMM;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C78D50", Offset = "0x7C77750", VA = "0x187C78D50")]
	public NEHEEDGBPJM(HCFLGOPIIBP CGJBEMKJPKN, int MFGDHAHMLOE, int CLIJNEAHMFE, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C78DB0", Offset = "0x7C777B0", VA = "0x187C78DB0")]
	public NEHEEDGBPJM(HCFLGOPIIBP CGJBEMKJPKN, int MFGDHAHMLOE, int CLIJNEAHMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C78E50", Offset = "0x7C77850", VA = "0x187C78E50")]
	public NEHEEDGBPJM(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C788D0", Offset = "0x7C772D0", VA = "0x187C788D0", Slot = "4")]
	public bool Equals(NEHEEDGBPJM NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C78980", Offset = "0x7C77380", VA = "0x187C78980", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class OKNCLECNPLL : BGAHJGBIHAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform MNINMACDPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private MJAAFHKHPBA HPJPMBAABJE;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x762FDD0", Offset = "0x762E7D0", VA = "0x18762FDD0", Slot = "4")]
	public void DBILOAODCDE(Transform MNINMACDPEC, MJAAFHKHPBA HPJPMBAABJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7C79370", Offset = "0x7C77D70", VA = "0x187C79370", Slot = "5")]
	public MJAAFHKHPBA LILPEKKBLNF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C79300", Offset = "0x7C77D00", VA = "0x187C79300", Slot = "6")]
	public void JMGODKPKENH(MJAAFHKHPBA FFNKHFBDMGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public OKNCLECNPLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class EHGHLNBGPPD : IDisposable, GHMNOIOEKGJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EIECFMDAMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public HCFLGOPIIBP oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public HCFLGOPIIBP newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EIECFMDAMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A130", Offset = "0x7C68B30", VA = "0x187C6A130")]
		internal bool ALBGDFIIJLM(CPDLBAPHGOM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly EAKFDKJNBMJ IGECKNINHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DEBOPKOJBAN OLIGPBHCMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MFLAFMEFHBE GKEBBNCFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private bool CKBIJLGPFKO;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly COJJKFBGGKB NKJCOOILLFH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CPDLBAPHGOM PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C67CA0", Offset = "0x7C666A0", VA = "0x187C67CA0")]
	public bool GHLNABOIDBJ([In] JIGBLMEHDDK HPGIDELCODH, bool EBMALGKEHFO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C66E90", Offset = "0x7C65890", VA = "0x187C66E90")]
	private bool AGNPOFHALNL([In] JIGBLMEHDDK HPGIDELCODH, bool EBMALGKEHFO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C69F60", Offset = "0x7C68960", VA = "0x187C69F60")]
	public EHGHLNBGPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7C67B90", Offset = "0x7C66590", VA = "0x187C67B90", Slot = "5")]
	public void DBILOAODCDE(NJFENKJHKPO BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7C67450", Offset = "0x7C65E50", VA = "0x187C67450", Slot = "17")]
	public void AILDLHALCNC(BOBCJIHPBJK DMDJELFGCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7C675D0", Offset = "0x7C65FD0", VA = "0x187C675D0", Slot = "12")]
	public void ANAGOEIKKKN(Func<HCFLGOPIIBP, bool> DFEDJMJGKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7C674A0", Offset = "0x7C65EA0", VA = "0x187C674A0")]
	private void ANAGOEIKKKN(EAKFDKJNBMJ DGGBJNBEMBF, Func<HCFLGOPIIBP, bool> DFEDJMJGKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7C67480", Offset = "0x7C65E80", VA = "0x187C67480", Slot = "11")]
	public void AJMPGHDEJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7C69BD0", Offset = "0x7C685D0", VA = "0x187C69BD0", Slot = "8")]
	public bool LOOJNLPBPOD(HCFLGOPIIBP KOOJFJIKEMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7C69020", Offset = "0x7C67A20", VA = "0x187C69020")]
	private bool KEPNNAOLHJE(HCFLGOPIIBP AHCOLALHCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7C69970", Offset = "0x7C68370", VA = "0x187C69970")]
	private static bool KNHFDAADNEH(HCFLGOPIIBP AHCOLALHCOK, EAKFDKJNBMJ ECCGBJNIHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7C67CB0", Offset = "0x7C666B0", VA = "0x187C67CB0")]
	private void EMGPJGCPFDB(Transform KPEMMNNJNON, EAKFDKJNBMJ HJNPMLGODCD, EAKFDKJNBMJ[] OGMCKAPCLCO, HCFLGOPIIBP EIPNLAMJIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7C678D0", Offset = "0x7C662D0", VA = "0x187C678D0")]
	private NEHEEDGBPJM CAPIKDNDGGG(Transform LBDPDIDCDIK, NEHEEDGBPJM PGPOPLGGIJC)
	{
		return default(NEHEEDGBPJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7C66BB0", Offset = "0x7C655B0", VA = "0x187C66BB0")]
	private static bool AADKIPEIJJI(EAKFDKJNBMJ ECCGBJNIHBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7C67C40", Offset = "0x7C66640", VA = "0x187C67C40", Slot = "9")]
	public bool DJKMLOGAAOI(HCFLGOPIIBP MPIMMPKKKDI, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7C69720", Offset = "0x7C68120", VA = "0x187C69720")]
	private bool KHONOBDOEJE(HCFLGOPIIBP MPIMMPKKKDI, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7C67710", Offset = "0x7C66110", VA = "0x187C67710")]
	private static void BPJLIADOGHL(HCFLGOPIIBP MPIMMPKKKDI, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM, EAKFDKJNBMJ PINMNAHNKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7C68E30", Offset = "0x7C67830", VA = "0x187C68E30")]
	private void JMALBMIJGGF(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7C69AF0", Offset = "0x7C684F0", VA = "0x187C69AF0")]
	private void LCIICNOKANA(EAKFDKJNBMJ DGGBJNBEMBF, HCFLGOPIIBP EOFFGOPJBCD, HCFLGOPIIBP PCAJKGLMDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7C69B60", Offset = "0x7C68560", VA = "0x187C69B60")]
	private void LCIICNOKANA(HCFLGOPIIBP CGJBEMKJPKN, HCFLGOPIIBP EOFFGOPJBCD, HCFLGOPIIBP PCAJKGLMDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7C684E0", Offset = "0x7C66EE0", VA = "0x187C684E0")]
	private void GFAOPNANENF(HCFLGOPIIBP CGJBEMKJPKN, HCFLGOPIIBP EOFFGOPJBCD, HCFLGOPIIBP PCAJKGLMDAK, bool MJMDKFAHIJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7C68550", Offset = "0x7C66F50", VA = "0x187C68550")]
	private void GFAOPNANENF(EAKFDKJNBMJ ALPBGLGCPNB, HCFLGOPIIBP EIPNLAMJIMI, HCFLGOPIIBP APMLNANHOKA, bool MJMDKFAHIJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7C66D70", Offset = "0x7C65770", VA = "0x187C66D70")]
	private void AEDHJMGNDGE(HCFLGOPIIBP GBGDJHDAECJ, int KDCGKELBLCC, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C69D40", Offset = "0x7C68740", VA = "0x187C69D40")]
	private void OHDHHIPBGCK(CPDLBAPHGOM EAGGHBKHKHF, CPDLBAPHGOM FLGGKNFKKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7C69BE0", Offset = "0x7C685E0", VA = "0x187C69BE0", Slot = "18")]
	public HCFLGOPIIBP OCKEFGKOCCK(HCFLGOPIIBP CGJBEMKJPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7C68140", Offset = "0x7C66B40", VA = "0x187C68140", Slot = "13")]
	public void GBHCABHEJPN(HCFLGOPIIBP CGJBEMKJPKN, HashSet<HCFLGOPIIBP> LNKPNIHGDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7C68650", Offset = "0x7C67050", VA = "0x187C68650", Slot = "14")]
	public List<HCFLGOPIIBP> HNLHHMPOBLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7C69A20", Offset = "0x7C68420", VA = "0x187C69A20")]
	protected CPDLBAPHGOM KOPGBKHLODI(CPDLBAPHGOM DGGBJNBEMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7C680A0", Offset = "0x7C66AA0", VA = "0x187C680A0")]
	protected EAKFDKJNBMJ[] EOMNKIBMLDJ(EAKFDKJNBMJ ECCGBJNIHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7C67A20", Offset = "0x7C66420", VA = "0x187C67A20")]
	protected bool CDMJINOPMBD(HCFLGOPIIBP CGJBEMKJPKN, [Out] EAKFDKJNBMJ DGGBJNBEMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C675E0", Offset = "0x7C65FE0", VA = "0x187C675E0", Slot = "15")]
	public bool BHKKDPHAMFL(HCFLGOPIIBP CGJBEMKJPKN, [Out] NEHEEDGBPJM CHOCAAFJANO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C67890", Offset = "0x7C66290", VA = "0x187C67890")]
	protected EAKFDKJNBMJ BPLJOCGDPAI(NEHEEDGBPJM DFFGGNMJIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7C67B30", Offset = "0x7C66530", VA = "0x187C67B30", Slot = "10")]
	public bool DBALEBPDAKD(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7C68890", Offset = "0x7C67290", VA = "0x187C68890")]
	private bool HOICEELAOHB(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C68F50", Offset = "0x7C67950", VA = "0x187C68F50")]
	private static bool JPNNFJMENFF(EAKFDKJNBMJ CDOBBDEOHLJ, NEHEEDGBPJM DINIEBCCBAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7C67CA0", Offset = "0x7C666A0", VA = "0x187C67CA0", Slot = "7")]
	private bool DMCCFGJGFMF([In] JIGBLMEHDDK HPGIDELCODH, bool EBMALGKEHFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class LDHNKOAKMMM : NJFENKJHKPO, IIAKOCKOOML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly MHGNCMHMEKD DJGDNAKMFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly MFLAFMEFHBE GKEBBNCFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly MGNBOEJOFPJ KMAEOKJODJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly GMDPOIDPFOE NIADPLCOLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly GHMNOIOEKGJ MAHFLPOCDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal LDEONPIPDDN FLJMNPJIKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal LNDBPCADFNI JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal DEBOPKOJBAN DNAEJBJGBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal bool CKBIJLGPFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool EDMKJHJBBOL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool HNOBHCPGDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE20", Offset = "0xA5B820", VA = "0x180A5CE20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA5CE30", Offset = "0xA5B830", VA = "0x180A5CE30")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MCFAHADANHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x11BDF20", Offset = "0x11BC920", VA = "0x1811BDF20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2744B10", Offset = "0x2743510", VA = "0x182744B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool OCGEPKIAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP> EHCMIKKCIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FBB0", Offset = "0x7C6E5B0", VA = "0x187C6FBB0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FAD0", Offset = "0x7C6E4D0", VA = "0x187C6FAD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP> JNPHJHFNNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F8D0", Offset = "0x7C6E2D0", VA = "0x187C6F8D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FD60", Offset = "0x7C6E760", VA = "0x187C6FD60", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HCFLGOPIIBP, HCFLGOPIIBP, HCFLGOPIIBP> FAHEKHHMJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C70700", Offset = "0x7C6F100", VA = "0x187C70700", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F730", Offset = "0x7C6E130", VA = "0x187C6F730", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C70A80", Offset = "0x7C6F480", VA = "0x187C70A80")]
	public LDHNKOAKMMM(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F130", Offset = "0x7C6DB30", VA = "0x187C6F130", Slot = "12")]
	public void DBILOAODCDE(GameObject HNGFDIJGINB, ALIMKLIALCB IHABGLIIKNE, ILJICCEHOHM NMLOLPLBMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C70760", Offset = "0x7C6F160", VA = "0x187C70760", Slot = "26")]
	public void NEAHCMEBFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FB30", Offset = "0x7C6E530", VA = "0x187C6FB30", Slot = "13")]
	public void FPILOHDMIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F930", Offset = "0x7C6E330", VA = "0x187C6F930", Slot = "14")]
	public void EPIAMCEAEFP(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FD00", Offset = "0x7C6E700", VA = "0x187C6FD00", Slot = "15")]
	public void IAJHDKMEFKB(HCFLGOPIIBP CGJBEMKJPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EE70", Offset = "0x7C6D870", VA = "0x187C6EE70", Slot = "22")]
	public bool BKECCFCEJAN(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FF10", Offset = "0x7C6E910", VA = "0x187C6FF10")]
	internal bool HOICEELAOHB([In] JIGBLMEHDDK HPGIDELCODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FDC0", Offset = "0x7C6E7C0", VA = "0x187C6FDC0")]
	internal bool HLKFIIMFIGK([In] JIGBLMEHDDK HPGIDELCODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7C70370", Offset = "0x7C6ED70", VA = "0x187C70370")]
	internal void LEPBKELNAEK(HCFLGOPIIBP CGJBEMKJPKN, int OICGIMJOJFP, bool EBMALGKEHFO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FD00", Offset = "0x7C6E700", VA = "0x187C6FD00")]
	internal bool GNDMOJAABAC(HCFLGOPIIBP CHJHBNIDAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7C70230", Offset = "0x7C6EC30", VA = "0x187C70230")]
	internal bool JJOMAIDGADC(HCFLGOPIIBP MPIMMPKKKDI, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6FC10", Offset = "0x7C6E610", VA = "0x187C6FC10", Slot = "16")]
	public void GBHCABHEJPN(HCFLGOPIIBP CGJBEMKJPKN, HashSet<HCFLGOPIIBP> DOACJJGBIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7C70020", Offset = "0x7C6EA20", VA = "0x187C70020", Slot = "17")]
	public void IMHJALKEMHE(HCFLGOPIIBP MPIMMPKKKDI, HCFLGOPIIBP MFOGENNLKAB, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F790", Offset = "0x7C6E190", VA = "0x187C6F790", Slot = "18")]
	public void EIONIHAOGCP(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EF70", Offset = "0x7C6D970", VA = "0x187C6EF70", Slot = "19")]
	public void CNMFPBECPOG(HCFLGOPIIBP NBLHMJJKGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7C70830", Offset = "0x7C6F230", VA = "0x187C70830")]
	public void NELHJLHEKEL([Optional] GBDECDHLMJN AAODDPFBIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDE0", Offset = "0x7C6D7E0", VA = "0x187C6EDE0", Slot = "23")]
	public void APNCIAIGPFB(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F950", Offset = "0x7C6E350", VA = "0x187C6F950", Slot = "20")]
	public HCKEKAGNNBL FCGDJJEKOBH(bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7C70550", Offset = "0x7C6EF50", VA = "0x187C70550", Slot = "21")]
	public HCKEKAGNNBL LMNEAFEMEAC(HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDA0", Offset = "0x7C6D7A0", VA = "0x187C6EDA0", Slot = "25")]
	public void ALNLGKINFDJ(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EEC0", Offset = "0x7C6D8C0", VA = "0x187C6EEC0", Slot = "24")]
	public void BKIHIJCNEJM(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class MFLAFMEFHBE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly KGOFKGCFJHJ<HCFLGOPIIBP, HCFLGOPIIBP> EHCMIKKCIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly KGOFKGCFJHJ<HCFLGOPIIBP, HCFLGOPIIBP> JNPHJHFNNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly AHMKLKJJKLJ<HCFLGOPIIBP, HCFLGOPIIBP, HCFLGOPIIBP> FAHEKHHMJIN;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7C73920", Offset = "0x7C72320", VA = "0x187C73920")]
	public MFLAFMEFHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
	public void DBILOAODCDE(LDHNKOAKMMM BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C738C0", Offset = "0x7C722C0", VA = "0x187C738C0")]
	public void KJJDNLINPGC(HCFLGOPIIBP EAGGHBKHKHF, HCFLGOPIIBP GBGDJHDAECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7C737E0", Offset = "0x7C721E0", VA = "0x187C737E0")]
	public void FDNDJOHCOIB(HCFLGOPIIBP EAGGHBKHKHF, HCFLGOPIIBP GBGDJHDAECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C73840", Offset = "0x7C72240", VA = "0x187C73840")]
	public void JIEALJDCDGC(HCFLGOPIIBP OGLNHOKFGHC, HCFLGOPIIBP FEIPCFECKLD, HCFLGOPIIBP GBGDJHDAECJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class MGNBOEJOFPJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private LDHNKOAKMMM BPDOIFAEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private LNDBPCADFNI JEJFACEGMCJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public MGNBOEJOFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C73A40", Offset = "0x7C72440", VA = "0x187C73A40")]
	public void DBILOAODCDE(LDHNKOAKMMM BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7C73B80", Offset = "0x7C72580", VA = "0x187C73B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C73CA0", Offset = "0x7C726A0", VA = "0x187C73CA0")]
	private void JAGHHJBBGBC(PGNMDKGFDBN BJBHFAMODGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C73CE0", Offset = "0x7C726E0", VA = "0x187C73CE0")]
	private void JIDLHFGGFEH(GBDECDHLMJN GKJDHMPBADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C73D50", Offset = "0x7C72750", VA = "0x187C73D50")]
	public void KFHHKPOKMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C73B90", Offset = "0x7C72590", VA = "0x187C73B90")]
	public void IBGNGOMJCIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NNLNIKJOOJN
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NEMMDMHCJLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public MHGNCMHMEKD container;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NEMMDMHCJLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7C78ED0", Offset = "0x7C778D0", VA = "0x187C78ED0")]
		internal LDHNKOAKMMM HGFJPDLBIBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C79080", Offset = "0x7C77A80", VA = "0x187C79080")]
	public static void FJIEOAFCGFA(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7C79280", Offset = "0x7C77C80", VA = "0x187C79280")]
	public static void LFBHFCDHJFP(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class HKKHKJBDFPB : IDisposable, DEBOPKOJBAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly Dictionary<int, MJAAFHKHPBA> PBKHHBMCJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly BOBCJIHPBJK BFAMLAHAIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private BGAHJGBIHAD MIIHDODFGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private GHMNOIOEKGJ MAHFLPOCDJP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static ProfilerMarker CMLHAIGDGLO;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E0F0", Offset = "0x7C6CAF0", VA = "0x187C6E0F0")]
	public HKKHKJBDFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D670", Offset = "0x7C6C070", VA = "0x187C6D670", Slot = "7")]
	public void DBILOAODCDE(GHMNOIOEKGJ MAHFLPOCDJP, BGAHJGBIHAD MIIHDODFGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D430", Offset = "0x7C6BE30", VA = "0x187C6D430", Slot = "5")]
	public void CIPGPAMFCAG(CPDLBAPHGOM DCKIGCDHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DA20", Offset = "0x7C6C420", VA = "0x187C6DA20", Slot = "9")]
	public void JCBGJEGIKJP(CPDLBAPHGOM LFANOBCFNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D860", Offset = "0x7C6C260", VA = "0x187C6D860", Slot = "8")]
	public void FOHJBOEPOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DD40", Offset = "0x7C6C740", VA = "0x187C6DD40", Slot = "10")]
	public void PKHOHMIPGJE(CPDLBAPHGOM JCKINDIJDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6D6B0", Offset = "0x7C6C0B0", VA = "0x187C6D6B0", Slot = "11")]
	public void EGNEOCHPECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6DB90", Offset = "0x7C6C590", VA = "0x187C6DB90")]
	private bool OBDINNFKFHM(CPDLBAPHGOM COCHOILMLGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class GMDPOIDPFOE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct HCMNMKHLHHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly EAKFDKJNBMJ NMEGPNIMAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly HashSet<Guid> ALJNIFEINHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly INHHIPBBNEG FMKAHHPGALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly INHHIPBBNEG EJCMOCGCMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly bool CLMHEOCCDHE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool LLNGEELLHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7C6CE80", Offset = "0x7C6B880", VA = "0x187C6CE80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D350", Offset = "0x7C6BD50", VA = "0x187C6D350")]
		public HCMNMKHLHHC(EAKFDKJNBMJ NMEGPNIMAIA, HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE, [Optional] INHHIPBBNEG FMKAHHPGALE, [Optional] INHHIPBBNEG EJCMOCGCMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CF90", Offset = "0x7C6B990", VA = "0x187C6CF90")]
		public INHHIPBBNEG PGPOMLMDCHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CA90", Offset = "0x7C6B490", VA = "0x187C6CA90")]
		private INHHIPBBNEG EPKPBAKPKPC([Out] INHHIPBBNEG OIDOLDELNAF, [Out] INHHIPBBNEG NDJPDBEJDPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D130", Offset = "0x7C6BB30", VA = "0x187C6D130")]
		private INHHIPBBNEG POCLFNEGFGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CD10", Offset = "0x7C6B710", VA = "0x187C6CD10")]
		private void ONFHPBBLAFL(INHHIPBBNEG NOELMMOLFBC, INHHIPBBNEG OLMOGLNFOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7C6CB50", Offset = "0x7C6B550", VA = "0x187C6CB50")]
		private void NNOFGAJDKDF(INHHIPBBNEG OIDOLDELNAF, INHHIPBBNEG NDJPDBEJDPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private LDHNKOAKMMM BPDOIFAEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GHMNOIOEKGJ MAHFLPOCDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private DEBOPKOJBAN OLIGPBHCMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private LNDBPCADFNI JEJFACEGMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private bool DPFMDKCHCBC;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool LKPIKMGHCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BCA0", Offset = "0x7C6A6A0", VA = "0x187C6BCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool HNOBHCPGDNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7C6A420", Offset = "0x7C68E20", VA = "0x187C6A420")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7C6AB60", Offset = "0x7C69560", VA = "0x187C6AB60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AFD0", Offset = "0x7C699D0", VA = "0x187C6AFD0")]
	public void DBILOAODCDE(LDHNKOAKMMM BPDOIFAEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B2F0", Offset = "0x7C69CF0", VA = "0x187C6B2F0")]
	public HCKEKAGNNBL FCGDJJEKOBH(bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B9B0", Offset = "0x7C6A3B0", VA = "0x187C6B9B0")]
	public HCKEKAGNNBL LMNEAFEMEAC(HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A440", Offset = "0x7C68E40", VA = "0x187C6A440")]
	public void APNCIAIGPFB(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AE10", Offset = "0x7C69810", VA = "0x187C6AE10")]
	public void BKIHIJCNEJM(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AEB0", Offset = "0x7C698B0", VA = "0x187C6AEB0")]
	public void BMGNEONONPH(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B460", Offset = "0x7C69E60", VA = "0x187C6B460")]
	private void FINLKBENOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B6D0", Offset = "0x7C6A0D0", VA = "0x187C6B6D0")]
	private INHHIPBBNEG KLHJNPOIKBH(EAKFDKJNBMJ DGGBJNBEMBF, bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B040", Offset = "0x7C69A40", VA = "0x187C6B040")]
	private static void EMCOFCLPGOP(EAKFDKJNBMJ DGGBJNBEMBF, bool CLMHEOCCDHE, INHHIPBBNEG FENDIEDGFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C040", Offset = "0x7C6AA40", VA = "0x187C6C040")]
	private void NGBBDAOOLJK(EAKFDKJNBMJ DGGBJNBEMBF, bool CLMHEOCCDHE, INHHIPBBNEG FENDIEDGFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B640", Offset = "0x7C6A040", VA = "0x187C6B640")]
	private INHHIPBBNEG IIEEPHJJILK(EAKFDKJNBMJ NMEGPNIMAIA, HashSet<Guid> ALJNIFEINHK, bool CLMHEOCCDHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C260", Offset = "0x7C6AC60", VA = "0x187C6C260")]
	private bool NJBACJPAPLI(HCKEKAGNNBL EHNACAKKDHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A4D0", Offset = "0x7C68ED0", VA = "0x187C6A4D0")]
	private bool BECPIGLIKOG(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AB40", Offset = "0x7C69540", VA = "0x187C6AB40")]
	private bool BEKAOFBIFPH(HCKEKAGNNBL MAHFLPOCDJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BB90", Offset = "0x7C6A590", VA = "0x187C6BB90")]
	private static bool MBOKFPOFNFK(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AB80", Offset = "0x7C69580", VA = "0x187C6AB80")]
	public static bool BKECCFCEJAN(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BCF0", Offset = "0x7C6A6F0", VA = "0x187C6BCF0")]
	private HCFLGOPIIBP MIBHMNPMGOB(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7C6A2A0", Offset = "0x7C68CA0", VA = "0x187C6A2A0")]
	private HCFLGOPIIBP ACLLEDLCFHF(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C740", Offset = "0x7C6B140", VA = "0x187C6C740")]
	private HCFLGOPIIBP PJLKOGCGODJ(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7C6BB50", Offset = "0x7C6A550", VA = "0x187C6BB50")]
	private static Guid LNJGKCMODBO(INHHIPBBNEG FENDIEDGFFH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AEE0", Offset = "0x7C698E0", VA = "0x187C6AEE0")]
	private string CAIOBJIMDFH(INHHIPBBNEG FENDIEDGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7C6B7C0", Offset = "0x7C6A1C0", VA = "0x187C6B7C0")]
	private bool LEDKKECCDBP(EAKFDKJNBMJ DGGBJNBEMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x7C6C4E0", Offset = "0x7C6AEE0", VA = "0x187C6C4E0")]
	private static void PCCNPECJEHC(EAKFDKJNBMJ NMEGPNIMAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public GMDPOIDPFOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct JIGBLMEHDDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public HCFLGOPIIBP GBGDJHDAECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public HCFLGOPIIBP EAGGHBKHKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KDCGKELBLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int DFLKPKAHKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector3 GEJHLHLCIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Quaternion BDPCKMPOLMM;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NEHEEDGBPJM ONBBLCJODCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E840", Offset = "0x7C6D240", VA = "0x187C6E840")]
		get
		{
			return default(NEHEEDGBPJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NEHEEDGBPJM AFAPIJNEGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E8E0", Offset = "0x7C6D2E0", VA = "0x187C6E8E0")]
		get
		{
			return default(NEHEEDGBPJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C6E910", Offset = "0x7C6D310", VA = "0x187C6E910")]
	public JIGBLMEHDDK(HCFLGOPIIBP GBGDJHDAECJ, HCFLGOPIIBP EAGGHBKHKHF, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface GHMNOIOEKGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CPDLBAPHGOM PFOPMMBCMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBILOAODCDE(NJFENKJHKPO BPDOIFAEGPF);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GHLNABOIDBJ([In] JIGBLMEHDDK HPGIDELCODH, bool EBMALGKEHFO = true);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LOOJNLPBPOD(HCFLGOPIIBP KOOJFJIKEMH);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DJKMLOGAAOI(HCFLGOPIIBP MPIMMPKKKDI, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DBALEBPDAKD(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AJMPGHDEJOL();

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ANAGOEIKKKN(Func<HCFLGOPIIBP, bool> DFEDJMJGKHK);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GBHCABHEJPN(HCFLGOPIIBP CGJBEMKJPKN, HashSet<HCFLGOPIIBP> LNKPNIHGDCA);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<HCFLGOPIIBP> HNLHHMPOBLE();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool BHKKDPHAMFL(HCFLGOPIIBP CGJBEMKJPKN, [Out] NEHEEDGBPJM CHOCAAFJANO);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AILDLHALCNC(BOBCJIHPBJK DMDJELFGCKJ);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool BOBCJIHPBJK(CPDLBAPHGOM DGGBJNBEMBF);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface CPDLBAPHGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	HCFLGOPIIBP HEJPBCMCOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CPDLBAPHGOM IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	NEHEEDGBPJM KGJMMJDIBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BBPFNDLDOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MJAAFHKHPBA
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBAOHJPBOCM(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ);

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCMJBDADIPP(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBIJGNCDAPP(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIBBMAENNIO(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJAAFHKHPBA Instantiate(Transform MNINMACDPEC);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EFCPNMLOGFP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BGAHJGBIHAD
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBILOAODCDE(Transform MNINMACDPEC, MJAAFHKHPBA HPJPMBAABJE);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJAAFHKHPBA LILPEKKBLNF();

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMGODKPKENH(MJAAFHKHPBA FFNKHFBDMGP);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LDEONPIPDDN : DAICDJOIDCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DANJKCPNKFM();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OFLBAPAKEDC(Guid OIEHHJHKJEF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DEBOPKOJBAN
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CIPGPAMFCAG(CPDLBAPHGOM DCKIGCDHCPH);

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBILOAODCDE(GHMNOIOEKGJ MAHFLPOCDJP, BGAHJGBIHAD DKDALONLHHB);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOHJBOEPOBJ();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCBGJEGIKJP(CPDLBAPHGOM LFANOBCFNAB);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKHOHMIPGJE(CPDLBAPHGOM JCKINDIJDEL);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGNEOCHPECK();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class EAKFDKJNBMJ : CPDLBAPHGOM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NNBOAPPEBJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public NEHEEDGBPJM nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public EAKFDKJNBMJ foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NNBOAPPEBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F40", Offset = "0x7C77940", VA = "0x187C78F40")]
		internal bool NLJFDKLPBCL(CPDLBAPHGOM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NEHEEDGBPJM CHOCAAFJANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public LinkedList<EAKFDKJNBMJ> JKFFEFAGBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private EAKFDKJNBMJ JBEPKADPDDO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NEHEEDGBPJM KGJMMJDIBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x13A1870", Offset = "0x13A0270", VA = "0x1813A1870", Slot = "6")]
		get
		{
			return default(NEHEEDGBPJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x13A1A90", Offset = "0x13A0490", VA = "0x1813A1A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private EAKFDKJNBMJ EAGGHBKHKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C66A20", Offset = "0x7C65420", VA = "0x187C66A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public CPDLBAPHGOM IOJNNDJMALL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public HCFLGOPIIBP HEJPBCMCOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BBPFNDLDOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7C669F0", Offset = "0x7C653F0", VA = "0x187C669F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FCJGFNMHADC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C666D0", Offset = "0x7C650D0", VA = "0x187C666D0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected EAKFDKJNBMJ ALPBGLGCPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C66A00", Offset = "0x7C65400", VA = "0x187C66A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C66B00", Offset = "0x7C65500", VA = "0x187C66B00")]
	public EAKFDKJNBMJ(NEHEEDGBPJM PMFKLNPEEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C66580", Offset = "0x7C64F80", VA = "0x187C66580")]
	public EAKFDKJNBMJ HLEAELBHIOH(NEHEEDGBPJM LCJODHICOLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C66720", Offset = "0x7C65120", VA = "0x187C66720")]
	public EAKFDKJNBMJ KEIDEBIODPD(NEHEEDGBPJM DOIFGMMLBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C662F0", Offset = "0x7C64CF0", VA = "0x187C662F0")]
	public EAKFDKJNBMJ DAAFLACHELB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C668A0", Offset = "0x7C652A0", VA = "0x187C668A0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C664D0", Offset = "0x7C64ED0", VA = "0x187C664D0")]
	public EAKFDKJNBMJ ELANGCKAKBE(NEHEEDGBPJM FEIPCFECKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C66080", Offset = "0x7C64A80", VA = "0x187C66080")]
	private static void AILDLHALCNC(EAKFDKJNBMJ MNIOMKLNNBA, BOBCJIHPBJK GNLEPFMJLKI, bool HMANDFKABOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C661E0", Offset = "0x7C64BE0", VA = "0x187C661E0", Slot = "9")]
	public void AILDLHALCNC(BOBCJIHPBJK DMDJELFGCKJ, bool MJMDKFAHIJJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C661F0", Offset = "0x7C64BF0", VA = "0x187C661F0")]
	public static EAKFDKJNBMJ BPLJOCGDPAI(EAKFDKJNBMJ MNIOMKLNNBA, NEHEEDGBPJM HJNAPPEIGAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface LNDBPCADFNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool LKPIKMGHCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<PGNMDKGFDBN> JAGHHJBBGBC;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<GBDECDHLMJN> JIDLHFGGFEH;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBAOHJPBOCM(LDHNKOAKMMM BPDOIFAEGPF, ILJICCEHOHM HHNKNLGOCJF);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IMHJALKEMHE(HCFLGOPIIBP MPIMMPKKKDI, HCFLGOPIIBP MFOGENNLKAB, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EIONIHAOGCP(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DNNNAPNMNDL(HCKEKAGNNBL NAEJFGJJJAL, [Optional] GBDECDHLMJN AAODDPFBIMN);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class IGNGBIPBJAG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public static Type GLEDFKBBOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E210", Offset = "0x7C6CC10", VA = "0x187C6E210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public static object FDCAMNOGINK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E1D0", Offset = "0x7C6CBD0", VA = "0x187C6E1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6E270", Offset = "0x7C6CC70", VA = "0x187C6E270")]
		[CompilerGenerated]
		internal set
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal class CJOCPKDBDCP : LNDBPCADFNI, IDisposable, GFGJDKEOOAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private LDHNKOAKMMM BPDOIFAEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private ILJICCEHOHM NMLOLPLBMJC;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LKPIKMGHCJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C65700", Offset = "0x7C64100", VA = "0x187C65700", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool AEEFIAPJAME
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C65120", Offset = "0x7C63B20", VA = "0x187C65120", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private RRNetworkView GIDGEBJOFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C652E0", Offset = "0x7C63CE0", VA = "0x187C652E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<PGNMDKGFDBN> JAGHHJBBGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C65090", Offset = "0x7C63A90", VA = "0x187C65090", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C65670", Offset = "0x7C64070", VA = "0x187C65670", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<GBDECDHLMJN> JIDLHFGGFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C64FF0", Offset = "0x7C639F0", VA = "0x187C64FF0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C65760", Offset = "0x7C64160", VA = "0x187C65760", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C655E0", Offset = "0x7C63FE0", VA = "0x187C655E0", Slot = "10")]
	public void JBAOHJPBOCM(LDHNKOAKMMM BPDOIFAEGPF, ILJICCEHOHM NMLOLPLBMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C65290", Offset = "0x7C63C90", VA = "0x187C65290", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C654B0", Offset = "0x7C63EB0", VA = "0x187C654B0", Slot = "11")]
	public void IMHJALKEMHE(HCFLGOPIIBP MPIMMPKKKDI, HCFLGOPIIBP MFOGENNLKAB, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C65380", Offset = "0x7C63D80", VA = "0x187C65380", Slot = "12")]
	public void EIONIHAOGCP(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C65160", Offset = "0x7C63B60", VA = "0x187C65160", Slot = "13")]
	public void DNNNAPNMNDL(HCKEKAGNNBL NAEJFGJJJAL, [Optional] GBDECDHLMJN AAODDPFBIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C65A40", Offset = "0x7C64440", VA = "0x187C65A40")]
	[PHDGLGOMNMM]
	private void RpcMasterReparentNodes(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C65840", Offset = "0x7C64240", VA = "0x187C65840")]
	[PHDGLGOMNMM]
	private void RpcMasterModifyNode(HCFLGOPIIBP MPIMMPKKKDI, HCFLGOPIIBP MFOGENNLKAB, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C65E40", Offset = "0x7C64840", VA = "0x187C65E40")]
	[PHDGLGOMNMM]
	private void RpcReparentNodes(HCFLGOPIIBP NBLHMJJKGAG, int KEKIPIEOIBF, HCFLGOPIIBP FEIPCFECKLD, int FFMJPLOCDMC, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM, ANACEAMGMLK HIHBOLDEJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C65D50", Offset = "0x7C64750", VA = "0x187C65D50")]
	[PHDGLGOMNMM]
	private void RpcModifyNode(HCFLGOPIIBP MPIMMPKKKDI, int KDCGKELBLCC, int DFLKPKAHKJI, Vector3 GEJHLHLCIPD, Quaternion BDPCKMPOLMM, ANACEAMGMLK HIHBOLDEJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7C65800", Offset = "0x7C64200", VA = "0x187C65800")]
	[PHDGLGOMNMM]
	private void RpcDeserializeConnectableGraph(HCKEKAGNNBL MAHFLPOCDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public CJOCPKDBDCP()
	{
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, MJAAFHKHPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C71190", Offset = "0x7C6FB90", VA = "0x187C71190", Slot = "4")]
		private void JDMCGLBBIHB(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C715D0", Offset = "0x7C6FFD0", VA = "0x187C715D0", Slot = "5")]
		private void NNCPNJHJLIE(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C71030", Offset = "0x7C6FA30", VA = "0x187C71030", Slot = "6")]
		private void IEMBBAHFAKP(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C71310", Offset = "0x7C6FD10", VA = "0x187C71310", Slot = "7")]
		private void LPDEBAGDLGF(HCFLGOPIIBP ECGLFIAHLIJ, NEHEEDGBPJM GBGDJHDAECJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C71500", Offset = "0x7C6FF00", VA = "0x187C71500", Slot = "8")]
		private MJAAFHKHPBA MAIBJIMEEJK(Transform MNINMACDPEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C71570", Offset = "0x7C6FF70", VA = "0x187C71570", Slot = "9")]
		private void MKABPLMOCEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class DDBDHACIHCN
{
	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x38A1C60", Offset = "0x38A0660", VA = "0x1838A1C60")]
	public static MEAIPPKGLPN<T> HCKEONIAIDH<T>(this MHGNCMHMEKD DJGDNAKMFCE)
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
