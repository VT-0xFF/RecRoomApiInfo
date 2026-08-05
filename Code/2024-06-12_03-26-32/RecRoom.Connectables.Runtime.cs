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
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6815D20", Offset = "0x6814920", VA = "0x186815D20", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
	public class _AssemblyIndex : IPFMOKLMBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private CKEMOIBJBPA bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private CKEMOIBJBPA bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x681F840", Offset = "0x681E440", VA = "0x18681F840", Slot = "5")]
		public override void JGJIGEFNIIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x681F880", Offset = "0x681E480", VA = "0x18681F880")]
		private void MNGJLCJEIMO(FKPMNNCCCMF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x681F9F0", Offset = "0x681E5F0", VA = "0x18681F9F0")]
		private void NGHNNPAOMHI(FKPMNNCCCMF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x681F510", Offset = "0x681E110", VA = "0x18681F510", Slot = "6")]
		public override void GILNKLKCLKE(FKPMNNCCCMF registry, [In] OLGFJANFKOO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "8")]
		public override void NFNLBHNCOKJ(JNBPEJFJHHP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x681FB60", Offset = "0x681E760", VA = "0x18681FB60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NKAJJBPDDGJ : HDJCLLLLKDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class NPIJHHHBLCC : IEnumerable<BMJIPLJCFGK>, IEnumerable, IEnumerator<BMJIPLJCFGK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BMJIPLJCFGK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private PHLHMBGDJPB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PHLHMBGDJPB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NKAJJBPDDGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private AGDKOLPOPCA <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HDPBPBEDBGP.FIOAKJBMLOE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private BMJIPLJCFGK System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public NPIJHHHBLCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x681BCC0", Offset = "0x681A8C0", VA = "0x18681BCC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x681B800", Offset = "0x681A400", VA = "0x18681B800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x681B7E0", Offset = "0x681A3E0", VA = "0x18681B7E0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x681BC70", Offset = "0x681A870", VA = "0x18681BC70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x681BBC0", Offset = "0x681A7C0", VA = "0x18681BBC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BMJIPLJCFGK> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x681BBC0", Offset = "0x681A7C0", VA = "0x18681BBC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class EBNJFGIGEBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public NKAJJBPDDGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public JDFEKFKGGLB nodeData;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public EBNJFGIGEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x680B2F0", Offset = "0x6809EF0", VA = "0x18680B2F0")]
		internal object DGCPLMNMALH(JDFEKFKGGLB x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MJJHHOLGDLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JDFEKFKGGLB child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EBNJFGIGEBJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MJJHHOLGDLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6815EC0", Offset = "0x6814AC0", VA = "0x186815EC0")]
		internal object LDCABGHOAEA((JDFEKFKGGLB child, JDFEKFKGGLB nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly KEDKJKIEEGM IOIKIJHBDGK;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly KEDKJKIEEGM GKEPCIIAKED;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly KEDKJKIEEGM HCKBPNBFDNB;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KEDKJKIEEGM IKGLGAPBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GMFOIJLKJDI GPIOOMJBDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private PKFMNIKNNCC BCEHGAICLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PEGAAPFIEAN AGNKGOPBMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LIDJIPFBGMF KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private BIJLCBNDPDM FPCOEIJKNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly CCBGJDFEGLG KIDLIDBBLGN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8555A0", Offset = "0x8541A0", VA = "0x1808555A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x854F90", Offset = "0x853B90", VA = "0x180854F90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BCEDANCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK> NOAGIKFPAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6819150", Offset = "0x6817D50", VA = "0x186819150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6818C80", Offset = "0x6817880", VA = "0x186818C80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK> ILCLLLKLIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6819640", Offset = "0x6818240", VA = "0x186819640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x681A820", Offset = "0x6819420", VA = "0x18681A820", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK, BMJIPLJCFGK> AHCBNNJEDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6817A80", Offset = "0x6816680", VA = "0x186817A80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6818750", Offset = "0x6817350", VA = "0x186818750", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x681B170", Offset = "0x6819D70", VA = "0x18681B170")]
	public NKAJJBPDDGJ(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6817810", Offset = "0x6816410", VA = "0x186817810", Slot = "12")]
	public void EHHLDMLDHNI(GameObject OLFFLDPKCIP, MDKPOGDIBIF OEKJGEGBIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68174E0", Offset = "0x68160E0", VA = "0x1868174E0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6819200", Offset = "0x6817E00", VA = "0x186819200", Slot = "22")]
	public bool HNPHFNDKNAA(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68171C0", Offset = "0x6815DC0", VA = "0x1868171C0")]
	private void CKLNKEEDMHL(PHLHMBGDJPB MNPBNAFDPPE, PHLHMBGDJPB DHDIBHGECBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x681A3C0", Offset = "0x6818FC0", VA = "0x18681A3C0")]
	private void NBHEJOCENHB(PHLHMBGDJPB MNPBNAFDPPE, PHLHMBGDJPB PLJBAOFKPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6816A30", Offset = "0x6815630", VA = "0x186816A30")]
	private void AIPINNJMGEM(PHLHMBGDJPB MNPBNAFDPPE, PHLHMBGDJPB PLJBAOFKPBF, PHLHMBGDJPB DHDIBHGECBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x681ABF0", Offset = "0x68197F0", VA = "0x18681ABF0")]
	private void PPBHHOFOOCA(PHLHMBGDJPB MNPBNAFDPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "13")]
	public void NBJEMGDMOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6818340", Offset = "0x6816F40", VA = "0x186818340", Slot = "14")]
	public void FHCDBNBHAOK(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "15")]
	public void CHBCOEBOKCE(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6819970", Offset = "0x6818570", VA = "0x186819970", Slot = "17")]
	public void MJPBPBLNGAA(BMJIPLJCFGK LOAHLPFCCII, BMJIPLJCFGK MPHPLMBFENG, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6819AD0", Offset = "0x68186D0", VA = "0x186819AD0")]
	public void MJPBPBLNGAA(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB MPHPLMBFENG, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68195B0", Offset = "0x68181B0", VA = "0x1868195B0")]
	public void JGHAHEEPMCN(BMJIPLJCFGK LOAHLPFCCII, float GOMEDJNNMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6817010", Offset = "0x6815C10", VA = "0x186817010", Slot = "18")]
	public void BADPIOIMFKG(BMJIPLJCFGK EOCCHBGNEHC, int HCLPKEDHGNP, BMJIPLJCFGK NLJDANLCAML, int NOKAAOLAMFF, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x681A5E0", Offset = "0x68191E0", VA = "0x18681A5E0")]
	private float NFBIKEHIDIF(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB GPMGJNAOOEP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6816EE0", Offset = "0x6815AE0", VA = "0x186816EE0")]
	public void BADPIOIMFKG(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB GPMGJNAOOEP, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6816E80", Offset = "0x6815A80", VA = "0x186816E80")]
	public void BADPIOIMFKG(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB GPMGJNAOOEP, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP, float GOMEDJNNMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6818FC0", Offset = "0x6817BC0", VA = "0x186818FC0", Slot = "19")]
	public void GPPNBMBHLKA(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6818D30", Offset = "0x6817930", VA = "0x186818D30")]
	public bool GPMFKOLODNH(PHLHMBGDJPB FFODPEFFKPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x681A1B0", Offset = "0x6818DB0", VA = "0x18681A1B0", Slot = "16")]
	public void MNKCJFAJKKI(BMJIPLJCFGK LOAHLPFCCII, HashSet<BMJIPLJCFGK> LAJLABHGMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "20")]
	public APOKBMPMKIC HEPGNAKJHPD(bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "21")]
	public APOKBMPMKIC MFIGJOKCNHI(HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6817B30", Offset = "0x6816730", VA = "0x186817B30", Slot = "23")]
	public void FAGLGFBKGGE(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68177A0", Offset = "0x68163A0", VA = "0x1868177A0", Slot = "24")]
	public void EDPDJABDIDB(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6819130", Offset = "0x6817D30", VA = "0x186819130", Slot = "25")]
	public void HJIIBMFIFBI(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6819250", Offset = "0x6817E50", VA = "0x186819250")]
	private void HPMJLFPLIEC(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB GPMGJNAOOEP, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP, float GOMEDJNNMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6818800", Offset = "0x6817400", VA = "0x186818800")]
	private void FPNANKOFIOE(PHLHMBGDJPB EJMCPAEEGJH, PHLHMBGDJPB IAAJMIGCLIP, Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6818650", Offset = "0x6817250", VA = "0x186818650")]
	private void FHIMFJOGOFA(PHLHMBGDJPB EJMCPAEEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68186C0", Offset = "0x68172C0", VA = "0x1868186C0")]
	[IteratorStateMachine(typeof(NPIJHHHBLCC))]
	public IEnumerable<BMJIPLJCFGK> FHPMPENKMOA(PHLHMBGDJPB FFODPEFFKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6817F40", Offset = "0x6816B40", VA = "0x186817F40")]
	internal BMJIPLJCFGK FCHGKFBKCPJ(PHLHMBGDJPB FFODPEFFKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x68176D0", Offset = "0x68162D0", VA = "0x1868176D0")]
	internal PHLHMBGDJPB EAKGCJIPOED(BMJIPLJCFGK LOAHLPFCCII)
	{
		return default(PHLHMBGDJPB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6819C10", Offset = "0x6818810", VA = "0x186819C10")]
	private bool MKGHAOPAAIH(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6818C20", Offset = "0x6817820", VA = "0x186818C20")]
	private bool GDANKOLOCCI(JDFEKFKGGLB BGLILLMPOMB, [Out] BMJIPLJCFGK GPMGJNAOOEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6817BA0", Offset = "0x68167A0", VA = "0x186817BA0")]
	private BMJIPLJCFGK FCHGKFBKCPJ(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x68196F0", Offset = "0x68182F0", VA = "0x1868196F0")]
	private BMJIPLJCFGK KNNEFKLPLJD(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6816CA0", Offset = "0x68158A0", VA = "0x186816CA0")]
	private BMJIPLJCFGK AOIMDJCDHDB(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x680C7D0", Offset = "0x680B3D0", VA = "0x18680C7D0")]
	private static Guid HIGAGLHPFKD(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6819880", Offset = "0x6818480", VA = "0x186819880")]
	private string MBKBBLAHEFJ(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x681AA60", Offset = "0x6819660", VA = "0x18681AA60")]
	private void PMJCNKJGAMD(BMJIPLJCFGK EJMCPAEEGJH, BMJIPLJCFGK IAAJMIGCLIP, RigidTransform BFJLHHOANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x681A8D0", Offset = "0x68194D0", VA = "0x18681A8D0")]
	private void PFCOKENGJBL(BMJIPLJCFGK IAAJMIGCLIP, BMJIPLJCFGK EJMCPAEEGJH, RigidTransform BFJLHHOANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6817160", Offset = "0x6815D60", VA = "0x186817160")]
	private void BNEJPJJMIHI(BMJIPLJCFGK PPDINOJPANB, BMJIPLJCFGK EJMCPAEEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x681A690", Offset = "0x6819290", VA = "0x18681A690")]
	private void OKDHIIHIJLD(BMJIPLJCFGK EJMCPAEEGJH, BMJIPLJCFGK GPMGJNAOOEP, RigidTransform BFJLHHOANID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68173D0", Offset = "0x6815FD0", VA = "0x1868173D0")]
	private void DCAOHGINNIO(PHLHMBGDJPB FFODPEFFKPK, BMJIPLJCFGK LOAHLPFCCII, PHLHMBGDJPB PLJBAOFKPBF, PHLHMBGDJPB DHDIBHGECBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6818070", Offset = "0x6816C70", VA = "0x186818070")]
	private void FEOCJAHEJAE(PHLHMBGDJPB FFODPEFFKPK, BMJIPLJCFGK LOAHLPFCCII, BMJIPLJCFGK AJACNKIAHFM, BMJIPLJCFGK GDOEEPFFCLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MJNIDCKPJHN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class JEEJAHCMEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public LLIMAHMFNLB container;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public JEEJAHCMEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6812640", Offset = "0x6811240", VA = "0x186812640")]
		internal NKAJJBPDDGJ HDCMCHGJEJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6816110", Offset = "0x6814D10", VA = "0x186816110")]
	public static void AEHLFOFDHHE(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6816290", Offset = "0x6814E90", VA = "0x186816290")]
	public static void EHCLGOPIIDH(LLIMAHMFNLB INBELNINGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class FNACGEOHGIA : AHELNHDDIJO, GFBFHKHPHOG
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx DFNINMKDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly NKAJJBPDDGJ HOMLIEJLBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EABEKNHGBPK COCFIOPJCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly MGOJDBEPFFL KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly CEPNNFDFCGC[] BANBCKOCLLG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(PHLHMBGDJPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BMJIPLJCFGK EADDOHGOIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6811D20", Offset = "0x6810920", VA = "0x186811D20", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMJIPLJCFGK KIFMAADPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x68110B0", Offset = "0x680FCB0", VA = "0x1868110B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 LDCPNDFCHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6810C80", Offset = "0x680F880", VA = "0x186810C80", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion GGHFDNBLELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6811050", Offset = "0x680FC50", VA = "0x186811050", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LEEECBOPEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6810360", Offset = "0x680EF60", VA = "0x186810360", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<BMJIPLJCFGK> EKPJFFFABLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6811180", Offset = "0x680FD80", VA = "0x186811180", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool BCAPELFJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B01D0", Offset = "0x9AEDD0", VA = "0x1809B01D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9B02F0", Offset = "0x9AEEF0", VA = "0x1809B02F0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6811F30", Offset = "0x6810B30", VA = "0x186811F30", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject KNJFPDLIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x251CC70", Offset = "0x251B870", VA = "0x18251CC70", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6811C50", Offset = "0x6810850", VA = "0x186811C50", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid JPHLLGNFCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6811D80", Offset = "0x6810980", VA = "0x186811D80", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FOJKALFNLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6811E60", Offset = "0x6810A60", VA = "0x186811E60", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BFAMFMAFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool NCNDJPNCMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6811680", Offset = "0x6810280", VA = "0x186811680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event BDHPGOINDCG OMDNBEPLGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x68111B0", Offset = "0x680FDB0", VA = "0x1868111B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6811120", Offset = "0x680FD20", VA = "0x186811120", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event BDHPGOINDCG FFKBNEGAPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6810190", Offset = "0x680ED90", VA = "0x186810190", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68106E0", Offset = "0x680F2E0", VA = "0x1868106E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BDHPGOINDCG CKLKACOGADA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6810C20", Offset = "0x680F820", VA = "0x186810C20", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6811620", Offset = "0x6810220", VA = "0x186811620", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event KMHNBFJLKBB KPPKHJEOBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6811A00", Offset = "0x6810600", VA = "0x186811A00", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6810220", Offset = "0x680EE20", VA = "0x186810220", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6811B50", Offset = "0x6810750", VA = "0x186811B50")]
	public FNACGEOHGIA(PHLHMBGDJPB NKMEKLOOCFN, RigidbodyEx DFNINMKDEHN, EABEKNHGBPK COCFIOPJCNB, CEPNNFDFCGC[] BANBCKOCLLG, MGOJDBEPFFL KHAIJLCNIAO, HDJCLLLLKDO HOMLIEJLBCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68101F0", Offset = "0x680EDF0", VA = "0x1868101F0", Slot = "19")]
	public void BECEGOJLPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "21")]
	public void MIOFAIEGDEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x667D160", Offset = "0x667BD60", VA = "0x18667D160", Slot = "22")]
	public void LGFOHNKHIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68116D0", Offset = "0x68102D0", VA = "0x1868116D0", Slot = "20")]
	public void NBMNJOJAEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x68117F0", Offset = "0x68103F0", VA = "0x1868117F0", Slot = "25")]
	public void OOOAIJLBNNK(int BEPKAGFNBCJ, BMJIPLJCFGK NLJDANLCAML, int ELAPHGOKJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6810F80", Offset = "0x680FB80", VA = "0x186810F80", Slot = "26")]
	public void KCJOCINGMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6810740", Offset = "0x680F340", VA = "0x186810740", Slot = "27")]
	public void GKENNBGMGEH(int BEPKAGFNBCJ, BMJIPLJCFGK EOCCHBGNEHC, int OBICEIIPFBK, [Optional] Vector3? MLKHGOLMFMA, [Optional] Quaternion? APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6811770", Offset = "0x6810370", VA = "0x186811770", Slot = "28")]
	public void OJHLLFHBFBH(BMJIPLJCFGK EOCCHBGNEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6811210", Offset = "0x680FE10", VA = "0x186811210", Slot = "31")]
	public void LMMAFLEOGED(Vector3 JNKAAKHCHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68103D0", Offset = "0x680EFD0", VA = "0x1868103D0", Slot = "29")]
	public void EINFHOCCMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6810D80", Offset = "0x680F980", VA = "0x186810D80", Slot = "30")]
	public void KAIEKKBAENA(int OPDMGNJCACB, Vector3 CILJGBPKAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6810B50", Offset = "0x680F750", VA = "0x186810B50", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int BEPKAGFNBCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6810A20", Offset = "0x680F620", VA = "0x186810A20", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int BEPKAGFNBCJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8AD290", Offset = "0x8ABE90", VA = "0x1808AD290", Slot = "42")]
	public Color GetConnectionSlotColor(int BEPKAGFNBCJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68102C0", Offset = "0x680EEC0", VA = "0x1868102C0", Slot = "43")]
	public bool CanConnectTo(int BEPKAGFNBCJ, BMJIPLJCFGK AFJIBOCPKBI, int MBIMHABIOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "44")]
	public void ParentChanged(int BEPKAGFNBCJ, BMJIPLJCFGK NFOPMDNBLEH, int FCOIGFPAOML, Vector3 MBNKPDMHFKO, Quaternion PHLIKLFFBNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "45")]
	public void ChildAdded(int BEPKAGFNBCJ, BMJIPLJCFGK NJCLPNJBEFA, int LOGBONPPJIP, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "46")]
	public void ChildRemoved(int BEPKAGFNBCJ, BMJIPLJCFGK JOCLFKPAJIE, int FOKJIEJDBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "47")]
	public void ConnectionModified(int BEPKAGFNBCJ, BMJIPLJCFGK NLJDANLCAML, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6811AA0", Offset = "0x68106A0", VA = "0x186811AA0", Slot = "48")]
	public void RootChanged(BMJIPLJCFGK LBODMLKDHMP, BMJIPLJCFGK HBAIDPLACMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6811720", Offset = "0x6810320", VA = "0x186811720", Slot = "23")]
	public void NJHNGPJAIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6810D30", Offset = "0x680F930", VA = "0x186810D30", Slot = "24")]
	public void JJIPHBBCLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6810CE0", Offset = "0x680F8E0", VA = "0x186810CE0")]
	private void IELBOCKCEGL(bool PHDMFNJBIPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[IGNIBOOGGBF(typeof(IIEIDIJGFMF), new string[] { })]
public class BHDDOAJHIIA : IIEIDIJGFMF, ILBMAEJLCCN
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class NMMGPFFGOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public BHDDOAJHIIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HDPBPBEDBGP localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public NMMGPFFGOGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x681B6F0", Offset = "0x681A2F0", VA = "0x18681B6F0")]
		internal void IOPPNGALCNO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[JNNAEKGLFBL]
	private CMJJBPKNOGM DIPPLEBBBBE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object BLANOHFGBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x680A430", Offset = "0x6809030", VA = "0x18680A430", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x680A3E0", Offset = "0x6808FE0", VA = "0x18680A3E0", Slot = "6")]
	public void InitReferences(OIDPNHHGIAF KIDLIDBBLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x680A270", Offset = "0x6808E70", VA = "0x18680A270", Slot = "5")]
	public void FHECANLGHKE(HDPBPBEDBGP OCMEKIBCJIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BHDDOAJHIIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[IGNIBOOGGBF(typeof(HDJCLLLLKDO), new string[] { "Ignore", "Mock" })]
public class GMEHLFODNPC : HDJCLLLLKDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool BCEDANCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK> NOAGIKFPAAH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6812160", Offset = "0x6810D60", VA = "0x186812160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x68120B0", Offset = "0x6810CB0", VA = "0x1868120B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK> ILCLLLKLIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6812210", Offset = "0x6810E10", VA = "0x186812210", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x68122C0", Offset = "0x6810EC0", VA = "0x1868122C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK, BMJIPLJCFGK> AHCBNNJEDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6811F50", Offset = "0x6810B50", VA = "0x186811F50", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6812000", Offset = "0x6810C00", VA = "0x186812000", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "12")]
	public void EHHLDMLDHNI(GameObject OLFFLDPKCIP, MDKPOGDIBIF OEKJGEGBIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "13")]
	public void NBJEMGDMOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "14")]
	public void FHCDBNBHAOK(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "15")]
	public void CHBCOEBOKCE(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "16")]
	public void MNKCJFAJKKI(BMJIPLJCFGK LOAHLPFCCII, HashSet<BMJIPLJCFGK> LAJLABHGMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "17")]
	public void MJPBPBLNGAA(BMJIPLJCFGK LOAHLPFCCII, BMJIPLJCFGK MPHPLMBFENG, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "18")]
	public void BADPIOIMFKG(BMJIPLJCFGK LOAHLPFCCII, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "19")]
	public void GPPNBMBHLKA(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "20")]
	public APOKBMPMKIC HEPGNAKJHPD(bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "21")]
	public APOKBMPMKIC MFIGJOKCNHI(HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "22")]
	public bool HNPHFNDKNAA(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "23")]
	public void FAGLGFBKGGE(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "24")]
	public void EDPDJABDIDB(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "25")]
	public void HJIIBMFIFBI(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public GMEHLFODNPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BMJIPLJCFGK : GFBFHKHPHOG, IEquatable<BMJIPLJCFGK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GFBFHKHPHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BMJIPLJCFGK EADDOHGOIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject KNJFPDLIBGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string JBJAOBKIEOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid JPHLLGNFCCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int FOJKALFNLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PHLHMBGDJPB BEHACKJMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BFAMFMAFMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int BEPKAGFNBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int BEPKAGFNBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int BEPKAGFNBCJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int BEPKAGFNBCJ, BMJIPLJCFGK AFJIBOCPKBI, int BNCFBDPAMNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int BEPKAGFNBCJ, BMJIPLJCFGK NFOPMDNBLEH, int FCOIGFPAOML, Vector3 MBNKPDMHFKO, Quaternion PHLIKLFFBNH);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int BEPKAGFNBCJ, BMJIPLJCFGK NJCLPNJBEFA, int LOGBONPPJIP, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int BEPKAGFNBCJ, BMJIPLJCFGK JOCLFKPAJIE, int FOKJIEJDBII);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int BEPKAGFNBCJ, BMJIPLJCFGK NLJDANLCAML, int EBFDDCKJJOO, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(BMJIPLJCFGK LBODMLKDHMP, BMJIPLJCFGK HBAIDPLACMA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[PDLAMBIDAOD(DJPDPGDGFEF.OMRoom)]
public interface HDJCLLLLKDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BCEDANCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<BMJIPLJCFGK, BMJIPLJCFGK> NOAGIKFPAAH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<BMJIPLJCFGK, BMJIPLJCFGK> ILCLLLKLIJD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<BMJIPLJCFGK, BMJIPLJCFGK, BMJIPLJCFGK> AHCBNNJEDCE;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHHLDMLDHNI(GameObject OLFFLDPKCIP, MDKPOGDIBIF OEKJGEGBIHM);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NBJEMGDMOCC();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHCDBNBHAOK(BMJIPLJCFGK LOAHLPFCCII);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CHBCOEBOKCE(BMJIPLJCFGK LOAHLPFCCII);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MNKCJFAJKKI(BMJIPLJCFGK LOAHLPFCCII, HashSet<BMJIPLJCFGK> LAJLABHGMND);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MJPBPBLNGAA(BMJIPLJCFGK LOAHLPFCCII, BMJIPLJCFGK MPHPLMBFENG, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BADPIOIMFKG(BMJIPLJCFGK LOAHLPFCCII, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GPPNBMBHLKA(BMJIPLJCFGK LOAHLPFCCII);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	APOKBMPMKIC HEPGNAKJHPD(bool FKNDKNKBEFP);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	APOKBMPMKIC MFIGJOKCNHI(HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HNPHFNDKNAA(JDFEKFKGGLB BGLILLMPOMB);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FAGLGFBKGGE(APOKBMPMKIC ENLPGHMPOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EDPDJABDIDB(APOKBMPMKIC ENLPGHMPOPJ);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HJIIBMFIFBI(APOKBMPMKIC ENLPGHMPOPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LIDJIPFBGMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KLKLLOMFGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMJIPLJCFGK AOIMDJCDHDB(int GDJJHAJNKNO);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BMJIPLJCFGK KNNEFKLPLJD(Guid MAHHEHENKNL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LCGDKIOPCJF(BMJIPLJCFGK LOAHLPFCCII);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ICHEFINCMHB();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MBFJGCKBAGB(BMJIPLJCFGK COCFIOPJCNB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[PDLAMBIDAOD(DJPDPGDGFEF.Application)]
public interface MGOJDBEPFFL
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCNDJPNCMJE(EABEKNHGBPK COCFIOPJCNB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCPKLLENGIN(EABEKNHGBPK COCFIOPJCNB);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DBIBPAPBOLM(EABEKNHGBPK COCFIOPJCNB);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OPPKBLNKICC(EABEKNHGBPK COCFIOPJCNB);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DLADNBEAFLJ(EABEKNHGBPK COCFIOPJCNB);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MLGHKFNIHHC(EABEKNHGBPK COCFIOPJCNB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void BDHPGOINDCG(BMJIPLJCFGK EOCCHBGNEHC, int BHAJMHACKMA, BMJIPLJCFGK NLJDANLCAML, int FMMJEGDBHDL, [Optional] Vector3? MLKHGOLMFMA, [Optional] Quaternion? APICIONBBGJ);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void KMHNBFJLKBB(BMJIPLJCFGK LBODMLKDHMP, BMJIPLJCFGK HBAIDPLACMA);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EABEKNHGBPK : BMJIPLJCFGK, GFBFHKHPHOG, IEquatable<BMJIPLJCFGK>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface AHELNHDDIJO : GFBFHKHPHOG
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BMJIPLJCFGK KIFMAADPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<BMJIPLJCFGK> EKPJFFFABLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 LDCPNDFCHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion GGHFDNBLELO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool LEEECBOPEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool BCAPELFJKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event BDHPGOINDCG OMDNBEPLGLD;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event BDHPGOINDCG FFKBNEGAPPE;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event BDHPGOINDCG CKLKACOGADA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event KMHNBFJLKBB KPPKHJEOBCJ;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BECEGOJLPJN();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NBMNJOJAEEO();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MIOFAIEGDEE();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LGFOHNKHIFD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NJHNGPJAIMC();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JJIPHBBCLOL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OOOAIJLBNNK(int BEPKAGFNBCJ, BMJIPLJCFGK NLJDANLCAML, int ELAPHGOKJON);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KCJOCINGMAK();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GKENNBGMGEH(int BEPKAGFNBCJ, BMJIPLJCFGK EOCCHBGNEHC, int OBICEIIPFBK, [Optional] Vector3? MLKHGOLMFMA, [Optional] Quaternion? APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OJHLLFHBFBH(BMJIPLJCFGK EOCCHBGNEHC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EINFHOCCMLG();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KAIEKKBAENA(int OPDMGNJCACB, Vector3 CILJGBPKAKN);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LMMAFLEOGED(Vector3 JNKAAKHCHLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CEPNNFDFCGC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 MONAOEHEOBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MDKPOGDIBIF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool LJFGMGOKOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DHLFGMOGFPB ALENDJACNCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, MDKPOGDIBIF
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
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x90BF40", Offset = "0x90AB40", VA = "0x18090BF40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public DHLFGMOGFPB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x680A530", Offset = "0x6809130", VA = "0x18680A530")]
		public static ConnectableConfigData JBCOKGPDNMH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x680A5F0", Offset = "0x68091F0", VA = "0x18680A5F0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual MDKKDKLOJKC, bool KKMJHCAJODP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MLNAELNLPCD : IEquatable<MLNAELNLPCD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BMJIPLJCFGK LOAHLPFCCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int MBCOCMLNCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int EBFDDCKJJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 MLKHGOLMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion APICIONBBGJ;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x68168A0", Offset = "0x68154A0", VA = "0x1868168A0")]
	public MLNAELNLPCD(BMJIPLJCFGK LOAHLPFCCII, int MBCOCMLNCKC, int EBFDDCKJJOO, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6816900", Offset = "0x6815500", VA = "0x186816900")]
	public MLNAELNLPCD(BMJIPLJCFGK LOAHLPFCCII, int MBCOCMLNCKC, int EBFDDCKJJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x68169A0", Offset = "0x68155A0", VA = "0x1868169A0")]
	public MLNAELNLPCD(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6816420", Offset = "0x6815020", VA = "0x186816420", Slot = "4")]
	public bool Equals(MLNAELNLPCD OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x68164D0", Offset = "0x68150D0", VA = "0x1868164D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class MLJGPLOJODD : LDNKNKAEFIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform KHIOEALLADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private DHLFGMOGFPB BCFJNIMNAMN;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x631CA60", Offset = "0x631B660", VA = "0x18631CA60", Slot = "4")]
	public void EHHLDMLDHNI(Transform KHIOEALLADK, DHLFGMOGFPB BCFJNIMNAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x68162E0", Offset = "0x6814EE0", VA = "0x1868162E0", Slot = "5")]
	public DHLFGMOGFPB IGPDBGANPLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x68163B0", Offset = "0x6814FB0", VA = "0x1868163B0", Slot = "6")]
	public void NBJLKEHJJDD(DHLFGMOGFPB LCGIMJLMBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public MLJGPLOJODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class OBGHFLGHAEA : IDisposable, OCECMPDPJNG
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PICKNPCJFBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BMJIPLJCFGK oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BMJIPLJCFGK newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public PICKNPCJFBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x681F2B0", Offset = "0x681DEB0", VA = "0x18681F2B0")]
		internal bool NGCHDFFMIEB(NKCHJCNEEJJ node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly LFCCKPAOBHF MAMMEGADNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private IDMDPMOGIAN MHLGALBCNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IJAMBFNPBFI NMIGDBGJOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool KKMJHCAJODP;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly KEDKJKIEEGM DNMKIIMHAFP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public NKCHJCNEEJJ MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x681D210", Offset = "0x681BE10", VA = "0x18681D210")]
	public bool GKCNMNHCPOE([In] NMKMDCEKJJP IMCLGJBJJKP, bool OBKFCLGINLF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x681D4D0", Offset = "0x681C0D0", VA = "0x18681D4D0")]
	private bool ICEIOPABEOG([In] NMKMDCEKJJP IMCLGJBJJKP, bool OBKFCLGINLF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x681F0E0", Offset = "0x681DCE0", VA = "0x18681F0E0")]
	public OBGHFLGHAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x681C230", Offset = "0x681AE30", VA = "0x18681C230", Slot = "5")]
	public void EHHLDMLDHNI(HDJCLLLLKDO DJIBBLNPCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x681EA80", Offset = "0x681D680", VA = "0x18681EA80", Slot = "17")]
	public void NJONLHBADDC(ENDBJPAOEME LHMNAJJOJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x681E250", Offset = "0x681CE50", VA = "0x18681E250", Slot = "12")]
	public void MDLDFIOBINB(Func<BMJIPLJCFGK, bool> MDOBNEPCKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x681E260", Offset = "0x681CE60", VA = "0x18681E260")]
	private void MDLDFIOBINB(LFCCKPAOBHF LNFMEAPGAAK, Func<BMJIPLJCFGK, bool> MDOBNEPCKEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x681D220", Offset = "0x681BE20", VA = "0x18681D220", Slot = "11")]
	public void GJCIOJDPEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x681C0C0", Offset = "0x681ACC0", VA = "0x18681C0C0", Slot = "8")]
	public bool BJLGDHONFGB(BMJIPLJCFGK FJFNDKJALBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x681C2C0", Offset = "0x681AEC0", VA = "0x18681C2C0")]
	private bool FEJNBAHOJEI(BMJIPLJCFGK OKNCHAEEEOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x681DAA0", Offset = "0x681C6A0", VA = "0x18681DAA0")]
	private static bool IIPPMMJAMNM(BMJIPLJCFGK OKNCHAEEEOC, LFCCKPAOBHF ABJKPOCFMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x681DB50", Offset = "0x681C750", VA = "0x18681DB50")]
	private void JBFOLHNAPGC(Transform JJAHNPANAFB, LFCCKPAOBHF BPNFNCFJGAC, LFCCKPAOBHF[] PNBABDLKPMN, BMJIPLJCFGK BCJFLLFLPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x681BD20", Offset = "0x681A920", VA = "0x18681BD20")]
	private MLNAELNLPCD APKAJINEBDC(Transform MBHIAIPBBIO, MLNAELNLPCD OELPJMKPJJJ)
	{
		return default(MLNAELNLPCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x681D310", Offset = "0x681BF10", VA = "0x18681D310")]
	private static bool HPBAPJAAGPN(LFCCKPAOBHF ABJKPOCFMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x681DF90", Offset = "0x681CB90", VA = "0x18681DF90", Slot = "9")]
	public bool KDHOHENCEGH(BMJIPLJCFGK CLPBEMLBMPB, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x681BE70", Offset = "0x681AA70", VA = "0x18681BE70")]
	private bool BAADLNJCKEL(BMJIPLJCFGK CLPBEMLBMPB, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x681E030", Offset = "0x681CC30", VA = "0x18681E030")]
	private static void LLCHBPKNDHL(BMJIPLJCFGK CLPBEMLBMPB, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ, LFCCKPAOBHF HMOEEHCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x681EEF0", Offset = "0x681DAF0", VA = "0x18681EEF0")]
	private void PMJCNKJGAMD(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x681EE80", Offset = "0x681DA80", VA = "0x18681EE80")]
	private void PMBNMGMNGPP(LFCCKPAOBHF LNFMEAPGAAK, BMJIPLJCFGK AJACNKIAHFM, BMJIPLJCFGK GDOEEPFFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x681EE10", Offset = "0x681DA10", VA = "0x18681EE10")]
	private void PMBNMGMNGPP(BMJIPLJCFGK LOAHLPFCCII, BMJIPLJCFGK AJACNKIAHFM, BMJIPLJCFGK GDOEEPFFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x681C9D0", Offset = "0x681B5D0", VA = "0x18681C9D0")]
	private void FEOCJAHEJAE(BMJIPLJCFGK LOAHLPFCCII, BMJIPLJCFGK AJACNKIAHFM, BMJIPLJCFGK GDOEEPFFCLG, bool MFLHCGPFFCL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x681CA40", Offset = "0x681B640", VA = "0x18681CA40")]
	private void FEOCJAHEJAE(LFCCKPAOBHF BLPDMPJLPPJ, BMJIPLJCFGK BCJFLLFLPDG, BMJIPLJCFGK HBAIDPLACMA, bool MFLHCGPFFCL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x681ECF0", Offset = "0x681D8F0", VA = "0x18681ECF0")]
	private void PFCOKENGJBL(BMJIPLJCFGK EJMCPAEEGJH, int OBICEIIPFBK, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x681C0D0", Offset = "0x681ACD0", VA = "0x18681C0D0")]
	private void BNEJPJJMIHI(NKCHJCNEEJJ GPMGJNAOOEP, NKCHJCNEEJJ KKECFBJAAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x681E920", Offset = "0x681D520", VA = "0x18681E920", Slot = "18")]
	public BMJIPLJCFGK NEJGINBHCDP(BMJIPLJCFGK LOAHLPFCCII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x681E4A0", Offset = "0x681D0A0", VA = "0x18681E4A0", Slot = "13")]
	public void MNKCJFAJKKI(BMJIPLJCFGK LOAHLPFCCII, HashSet<BMJIPLJCFGK> HEBECBNGCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x681EAB0", Offset = "0x681D6B0", VA = "0x18681EAB0", Slot = "14")]
	public List<BMJIPLJCFGK> PCPNKPMDNDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x681E850", Offset = "0x681D450", VA = "0x18681E850")]
	protected NKCHJCNEEJJ NCOKHIAONAN(NKCHJCNEEJJ LNFMEAPGAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x681E1B0", Offset = "0x681CDB0", VA = "0x18681E1B0")]
	protected LFCCKPAOBHF[] LLJPLMLCHME(LFCCKPAOBHF ABJKPOCFMIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x681E390", Offset = "0x681CF90", VA = "0x18681E390")]
	protected bool MHNCMGCEJJC(BMJIPLJCFGK LOAHLPFCCII, [Out] LFCCKPAOBHF LNFMEAPGAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x681D0E0", Offset = "0x681BCE0", VA = "0x18681D0E0", Slot = "15")]
	public bool FOJKHBIIBJF(BMJIPLJCFGK LOAHLPFCCII, [Out] MLNAELNLPCD EJOCDKGHCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x681DFF0", Offset = "0x681CBF0", VA = "0x18681DFF0")]
	protected LFCCKPAOBHF KGNNNOHDBBI(MLNAELNLPCD JEOIDFCEIIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x681DF30", Offset = "0x681CB30", VA = "0x18681DF30", Slot = "10")]
	public bool JMJOANFGOGM(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x681CB40", Offset = "0x681B740", VA = "0x18681CB40")]
	private bool FHFJCLAEFKN(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x681D240", Offset = "0x681BE40", VA = "0x18681D240")]
	private static bool HEJILGGLDDP(LFCCKPAOBHF BLDJKPDFJKA, MLNAELNLPCD BKANBCCPAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x681D210", Offset = "0x681BE10", VA = "0x18681D210", Slot = "7")]
	private bool GEKHFAPKLKP([In] NMKMDCEKJJP IMCLGJBJJKP, bool OBKFCLGINLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class FLPDKEMJJAK : HDJCLLLLKDO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly LLIMAHMFNLB INBELNINGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly IJAMBFNPBFI NMIGDBGJOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly NMHPIGMCGOE PJNICEMFNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly EFFKIOBMCDB NILIBLGEEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly OCECMPDPJNG ENLPGHMPOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal CDDGLFDKGBE KHAIJLCNIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal GFPEKNFOLEM MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal IDMDPMOGIAN DEDLFJHIIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool KKMJHCAJODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool HAGDECJJNPN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FBCCLEDGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90B380", Offset = "0x909F80", VA = "0x18090B380")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1907060", Offset = "0x1905C60", VA = "0x181907060")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x90B360", Offset = "0x909F60", VA = "0x18090B360", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1907040", Offset = "0x1905C40", VA = "0x181907040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BCEDANCFCHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK> NOAGIKFPAAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x680F660", Offset = "0x680E260", VA = "0x18680F660", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x680F3D0", Offset = "0x680DFD0", VA = "0x18680F3D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK> ILCLLLKLIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x680F7D0", Offset = "0x680E3D0", VA = "0x18680F7D0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x680FD40", Offset = "0x680E940", VA = "0x18680FD40", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BMJIPLJCFGK, BMJIPLJCFGK, BMJIPLJCFGK> AHCBNNJEDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x680F1D0", Offset = "0x680DDD0", VA = "0x18680F1D0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x680F370", Offset = "0x680DF70", VA = "0x18680F370", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x680FDA0", Offset = "0x680E9A0", VA = "0x18680FDA0")]
	public FLPDKEMJJAK(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x680EC10", Offset = "0x680D810", VA = "0x18680EC10", Slot = "12")]
	public void EHHLDMLDHNI(GameObject OLFFLDPKCIP, MDKPOGDIBIF OEKJGEGBIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x680E970", Offset = "0x680D570", VA = "0x18680E970", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x680FC90", Offset = "0x680E890", VA = "0x18680FC90", Slot = "13")]
	public void NBJEMGDMOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x680F2C0", Offset = "0x680DEC0", VA = "0x18680F2C0", Slot = "14")]
	public void FHCDBNBHAOK(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x680E910", Offset = "0x680D510", VA = "0x18680E910", Slot = "15")]
	public void CHBCOEBOKCE(BMJIPLJCFGK LOAHLPFCCII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x680F6C0", Offset = "0x680E2C0", VA = "0x18680F6C0", Slot = "22")]
	public bool HNPHFNDKNAA(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x680F710", Offset = "0x680E310", VA = "0x18680F710")]
	internal bool ICEIOPABEOG([In] NMKMDCEKJJP IMCLGJBJJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x680F2E0", Offset = "0x680DEE0", VA = "0x18680F2E0")]
	internal bool FHFJCLAEFKN([In] NMKMDCEKJJP IMCLGJBJJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x680FCE0", Offset = "0x680E8E0", VA = "0x18680FCE0")]
	internal bool NHOIPOMFLBD([In] NMKMDCEKJJP IMCLGJBJJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x680EA10", Offset = "0x680D610", VA = "0x18680EA10")]
	internal bool EAJELDEMHED([In] NMKMDCEKJJP IMCLGJBJJKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x680E4E0", Offset = "0x680D0E0", VA = "0x18680E4E0")]
	internal void AFFIMDJOFFB(BMJIPLJCFGK LOAHLPFCCII, int AGJFKIBNKLO, bool OBKFCLGINLF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x680E910", Offset = "0x680D510", VA = "0x18680E910")]
	internal bool ICOJJNCAJDB(BMJIPLJCFGK NECMONALJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x680F830", Offset = "0x680E430", VA = "0x18680F830")]
	internal bool LKMKIAAFFME(BMJIPLJCFGK CLPBEMLBMPB, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x680FB90", Offset = "0x680E790", VA = "0x18680FB90", Slot = "16")]
	public void MNKCJFAJKKI(BMJIPLJCFGK LOAHLPFCCII, HashSet<BMJIPLJCFGK> LAJLABHGMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x680F980", Offset = "0x680E580", VA = "0x18680F980", Slot = "17")]
	public void MJPBPBLNGAA(BMJIPLJCFGK CLPBEMLBMPB, BMJIPLJCFGK MPHPLMBFENG, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x680E6C0", Offset = "0x680D2C0", VA = "0x18680E6C0", Slot = "18")]
	public void BADPIOIMFKG(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x680F430", Offset = "0x680E030", VA = "0x18680F430", Slot = "19")]
	public void GPPNBMBHLKA(BMJIPLJCFGK IMEDOAGIBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x680E800", Offset = "0x680D400", VA = "0x18680E800")]
	public void BPDPLCBAKMH([Optional] KNCDGANFFJE HOHHMKBFEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x680F230", Offset = "0x680DE30", VA = "0x18680F230", Slot = "23")]
	public void FAGLGFBKGGE(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x680F600", Offset = "0x680E200", VA = "0x18680F600", Slot = "20")]
	public APOKBMPMKIC HEPGNAKJHPD(bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x680F960", Offset = "0x680E560", VA = "0x18680F960", Slot = "21")]
	public APOKBMPMKIC MFIGJOKCNHI(HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x680F620", Offset = "0x680E220", VA = "0x18680F620", Slot = "25")]
	public void HJIIBMFIFBI(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x680EB60", Offset = "0x680D760", VA = "0x18680EB60", Slot = "24")]
	public void EDPDJABDIDB(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class IJAMBFNPBFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly FFKNAOPGKON<BMJIPLJCFGK, BMJIPLJCFGK> NOAGIKFPAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly FFKNAOPGKON<BMJIPLJCFGK, BMJIPLJCFGK> ILCLLLKLIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly FLLHEFAEBCL<BMJIPLJCFGK, BMJIPLJCFGK, BMJIPLJCFGK> AHCBNNJEDCE;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6812520", Offset = "0x6811120", VA = "0x186812520")]
	public IJAMBFNPBFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	public void EHHLDMLDHNI(FLPDKEMJJAK DJIBBLNPCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6812460", Offset = "0x6811060", VA = "0x186812460")]
	public void LAEHOLKCEOE(BMJIPLJCFGK GPMGJNAOOEP, BMJIPLJCFGK EJMCPAEEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68124C0", Offset = "0x68110C0", VA = "0x1868124C0")]
	public void LEDAEJCMLNE(BMJIPLJCFGK GPMGJNAOOEP, BMJIPLJCFGK EJMCPAEEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x68123E0", Offset = "0x6810FE0", VA = "0x1868123E0")]
	public void HNGIMJDBNFA(BMJIPLJCFGK PPDINOJPANB, BMJIPLJCFGK IAAJMIGCLIP, BMJIPLJCFGK EJMCPAEEGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NMHPIGMCGOE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private FLPDKEMJJAK DJIBBLNPCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private GFPEKNFOLEM MPCOPBMLEML;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public NMHPIGMCGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x681B260", Offset = "0x6819E60", VA = "0x18681B260")]
	public void EHHLDMLDHNI(FLPDKEMJJAK DJIBBLNPCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x681B250", Offset = "0x6819E50", VA = "0x18681B250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x681B490", Offset = "0x681A090", VA = "0x18681B490")]
	private void KNELPDOAFKP(KNCDGANFFJE KBMFHBINANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x681B1E0", Offset = "0x6819DE0", VA = "0x18681B1E0")]
	private void CHPMBEFKLID(KNCDGANFFJE NKDOGHODHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x681B4B0", Offset = "0x681A0B0", VA = "0x18681B4B0")]
	public void MDICAFDEMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x681B390", Offset = "0x6819F90", VA = "0x18681B390")]
	public void HIKFIIKJLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JLGDBGGHEIK
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HMCODHKAMIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LLIMAHMFNLB container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public HMCODHKAMIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6812370", Offset = "0x6810F70", VA = "0x186812370")]
		internal FLPDKEMJJAK HDCMCHGJEJE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68126F0", Offset = "0x68112F0", VA = "0x1868126F0")]
	public static void AEHLFOFDHHE(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x68128F0", Offset = "0x68114F0", VA = "0x1868128F0")]
	public static void EHCLGOPIIDH(LLIMAHMFNLB INBELNINGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class DHEOLOKGBHE : IDisposable, IDMDPMOGIAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, DHLFGMOGFPB> EADILAKKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly ENDBJPAOEME EHPAAJEEFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private LDNKNKAEFIN MFMCKPDJLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private OCECMPDPJNG ENLPGHMPOPJ;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x680B210", Offset = "0x6809E10", VA = "0x18680B210")]
	public DHEOLOKGBHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x680A640", Offset = "0x6809240", VA = "0x18680A640", Slot = "7")]
	public void EHHLDMLDHNI(OCECMPDPJNG ENLPGHMPOPJ, LDNKNKAEFIN MFMCKPDJLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x680A7F0", Offset = "0x68093F0", VA = "0x18680A7F0", Slot = "5")]
	public void HKBOPMIBFGK(NKCHJCNEEJJ DDABIOHJLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x680A680", Offset = "0x6809280", VA = "0x18680A680", Slot = "9")]
	public void FIJEJMELKHO(NKCHJCNEEJJ BGOAMGIKKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x680B050", Offset = "0x6809C50", VA = "0x18680B050", Slot = "8")]
	public void MKKODCFINAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x680AC40", Offset = "0x6809840", VA = "0x18680AC40", Slot = "10")]
	public void IMLCKEHMDOO(NKCHJCNEEJJ PPJBHIAEOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x680AF90", Offset = "0x6809B90", VA = "0x18680AF90", Slot = "11")]
	public void KLIHOGGJIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x680AA90", Offset = "0x6809690", VA = "0x18680AA90")]
	private bool ICPKAIMHBKA(NKCHJCNEEJJ LGIJFEHDJIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class EFFKIOBMCDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct KCBKLABDGAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly LFCCKPAOBHF FGEEDPJGNCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> APJNHPBNNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly JDFEKFKGGLB HCABCGBAJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly JDFEKFKGGLB NJHGBENNJOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool FKNDKNKBEFP;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool DPKJMAKGLAI
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6812970", Offset = "0x6811570", VA = "0x186812970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6813240", Offset = "0x6811E40", VA = "0x186813240")]
		public KCBKLABDGAC(LFCCKPAOBHF FGEEDPJGNCK, HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP, [Optional] JDFEKFKGGLB HCABCGBAJBD, [Optional] JDFEKFKGGLB NJHGBENNJOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x68130A0", Offset = "0x6811CA0", VA = "0x1868130A0")]
		public JDFEKFKGGLB PLFEAILJDFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6812C00", Offset = "0x6811800", VA = "0x186812C00")]
		private JDFEKFKGGLB GLGCNHJFNCB([Out] JDFEKFKGGLB BLHDBBFAFPF, [Out] JDFEKFKGGLB DNIJLLAKMIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6812CC0", Offset = "0x68118C0", VA = "0x186812CC0")]
		private JDFEKFKGGLB LEICLKFPBHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6812A90", Offset = "0x6811690", VA = "0x186812A90")]
		private void FGIFOLJJCAM(JDFEKFKGGLB FGFFFLLDPLJ, JDFEKFKGGLB OPMIPOONFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6812EE0", Offset = "0x6811AE0", VA = "0x186812EE0")]
		private void OOEIMNPKAJE(JDFEKFKGGLB BLHDBBFAFPF, JDFEKFKGGLB DNIJLLAKMIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private FLPDKEMJJAK DJIBBLNPCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private OCECMPDPJNG ENLPGHMPOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private IDMDPMOGIAN MHLGALBCNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GFPEKNFOLEM MPCOPBMLEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool FMLGLDKIBGH;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PIAKOMMJLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x680CAA0", Offset = "0x680B6A0", VA = "0x18680CAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool FBCCLEDGOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x680D3A0", Offset = "0x680BFA0", VA = "0x18680D3A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x680B930", Offset = "0x680A530", VA = "0x18680B930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x680BD60", Offset = "0x680A960", VA = "0x18680BD60")]
	public void EHHLDMLDHNI(FLPDKEMJJAK DJIBBLNPCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x680C250", Offset = "0x680AE50", VA = "0x18680C250")]
	public APOKBMPMKIC HEPGNAKJHPD(bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x680D4B0", Offset = "0x680C0B0", VA = "0x18680D4B0")]
	public APOKBMPMKIC MFIGJOKCNHI(HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x680BDD0", Offset = "0x680A9D0", VA = "0x18680BDD0")]
	public void FAGLGFBKGGE(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x680BCC0", Offset = "0x680A8C0", VA = "0x18680BCC0")]
	public void EDPDJABDIDB(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x680CC70", Offset = "0x680B870", VA = "0x18680CC70")]
	public void JDABKPKCLHL(APOKBMPMKIC ENLPGHMPOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x680CF50", Offset = "0x680BB50", VA = "0x18680CF50")]
	private void LGBGPJFHAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x680B4E0", Offset = "0x680A0E0", VA = "0x18680B4E0")]
	private JDFEKFKGGLB BLLJEGLACAC(LFCCKPAOBHF LNFMEAPGAAK, bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x680BA70", Offset = "0x680A670", VA = "0x18680BA70")]
	private static void DEOFNMKBCLN(LFCCKPAOBHF LNFMEAPGAAK, bool FKNDKNKBEFP, JDFEKFKGGLB BGLILLMPOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x680B710", Offset = "0x680A310", VA = "0x18680B710")]
	private void CJLNNJODBKE(LFCCKPAOBHF LNFMEAPGAAK, bool FKNDKNKBEFP, JDFEKFKGGLB BGLILLMPOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x680C1C0", Offset = "0x680ADC0", VA = "0x18680C1C0")]
	private JDFEKFKGGLB FGNJDHGJPIF(LFCCKPAOBHF FGEEDPJGNCK, HashSet<Guid> APJNHPBNNOK, bool FKNDKNKBEFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x680CCA0", Offset = "0x680B8A0", VA = "0x18680CCA0")]
	private bool JLCPCOKPJGE(APOKBMPMKIC HJEAEGOGKGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x680DB40", Offset = "0x680C740", VA = "0x18680DB40")]
	private bool MKGHAOPAAIH(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x680CF30", Offset = "0x680BB30", VA = "0x18680CF30")]
	private bool KNFLANIGOOH(APOKBMPMKIC ENLPGHMPOPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x680B950", Offset = "0x680A550", VA = "0x18680B950")]
	private static bool DCDBDFMPPMO(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x680C810", Offset = "0x680B410", VA = "0x18680C810")]
	public static bool HNPHFNDKNAA(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x680BE60", Offset = "0x680AA60", VA = "0x18680BE60")]
	private BMJIPLJCFGK FCHGKFBKCPJ(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x680B360", Offset = "0x6809F60", VA = "0x18680B360")]
	private BMJIPLJCFGK AOIMDJCDHDB(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x680E1B0", Offset = "0x680CDB0", VA = "0x18680E1B0")]
	private BMJIPLJCFGK PBBMDNPHHHK(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x680C7D0", Offset = "0x680B3D0", VA = "0x18680C7D0")]
	private static Guid HIGAGLHPFKD(JDFEKFKGGLB BGLILLMPOMB)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x680D3C0", Offset = "0x680BFC0", VA = "0x18680D3C0")]
	private string MBKBBLAHEFJ(JDFEKFKGGLB BGLILLMPOMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x680CAF0", Offset = "0x680B6F0", VA = "0x18680CAF0")]
	private bool JCILLFMINGF(LFCCKPAOBHF LNFMEAPGAAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x680D140", Offset = "0x680BD40", VA = "0x18680D140")]
	private static void LIJPMOLMPEJ(LFCCKPAOBHF FGEEDPJGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EFFKIOBMCDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct NMKMDCEKJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public BMJIPLJCFGK EJMCPAEEGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public BMJIPLJCFGK GPMGJNAOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int OBICEIIPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int ELAPHGOKJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 MLKHGOLMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion APICIONBBGJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MLNAELNLPCD BICPFHJHFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x681B5B0", Offset = "0x681A1B0", VA = "0x18681B5B0")]
		get
		{
			return default(MLNAELNLPCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MLNAELNLPCD DJEGDEKFJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x681B650", Offset = "0x681A250", VA = "0x18681B650")]
		get
		{
			return default(MLNAELNLPCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x681B680", Offset = "0x681A280", VA = "0x18681B680")]
	public NMKMDCEKJJP(BMJIPLJCFGK EJMCPAEEGJH, BMJIPLJCFGK GPMGJNAOOEP, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface OCECMPDPJNG
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NKCHJCNEEJJ MOHNEGNCIIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHHLDMLDHNI(HDJCLLLLKDO DJIBBLNPCFA);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GKCNMNHCPOE([In] NMKMDCEKJJP IMCLGJBJJKP, bool OBKFCLGINLF = true);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BJLGDHONFGB(BMJIPLJCFGK FJFNDKJALBM);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KDHOHENCEGH(BMJIPLJCFGK CLPBEMLBMPB, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JMJOANFGOGM(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GJCIOJDPEFJ();

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MDLDFIOBINB(Func<BMJIPLJCFGK, bool> MDOBNEPCKEE);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNKCJFAJKKI(BMJIPLJCFGK LOAHLPFCCII, HashSet<BMJIPLJCFGK> HEBECBNGCBK);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<BMJIPLJCFGK> PCPNKPMDNDO();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FOJKHBIIBJF(BMJIPLJCFGK LOAHLPFCCII, [Out] MLNAELNLPCD EJOCDKGHCMA);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NJONLHBADDC(ENDBJPAOEME LHMNAJJOJLL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool ENDBJPAOEME(NKCHJCNEEJJ LNFMEAPGAAK);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface NKCHJCNEEJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BMJIPLJCFGK EANCOJOAJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NKCHJCNEEJJ MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MLNAELNLPCD LBPGCEFIDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BJIMONDOFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface DHLFGMOGFPB : CEFCNCGOBKL.DLMBKIJCCPM
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOJMDOFEJMG(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNDIIPBOILJ(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CMLBMPNFEKG(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BKEIEAJLEGA(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DHLFGMOGFPB Instantiate(Transform KHIOEALLADK);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IICIADDLCDE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LDNKNKAEFIN
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHHLDMLDHNI(Transform KHIOEALLADK, DHLFGMOGFPB BCFJNIMNAMN);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DHLFGMOGFPB IGPDBGANPLH();

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NBJLKEHJJDD(DHLFGMOGFPB LCGIMJLMBIL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CDDGLFDKGBE : LIDJIPFBGMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLJKDGKCBAO(Guid JJHKGEBFNIG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface IDMDPMOGIAN
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKBOPMIBFGK(NKCHJCNEEJJ DDABIOHJLDJ);

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHHLDMLDHNI(OCECMPDPJNG ENLPGHMPOPJ, LDNKNKAEFIN MEICLHFEEHL);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKKODCFINAC();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FIJEJMELKHO(NKCHJCNEEJJ BGOAMGIKKFH);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IMLCKEHMDOO(NKCHJCNEEJJ PPJBHIAEOPG);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KLIHOGGJIFH();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class LFCCKPAOBHF : NKCHJCNEEJJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FDGNKOBKCIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public MLNAELNLPCD nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LFCCKPAOBHF foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public FDGNKOBKCIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x680E3B0", Offset = "0x680CFB0", VA = "0x18680E3B0")]
		internal bool LCMPNCCGLFJ(NKCHJCNEEJJ x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private MLNAELNLPCD EJOCDKGHCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<LFCCKPAOBHF> ENJDMAIPEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private LFCCKPAOBHF FKDGFPFMPCG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MLNAELNLPCD LBPGCEFIDDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3874290", Offset = "0x3872E90", VA = "0x183874290", Slot = "6")]
		get
		{
			return default(MLNAELNLPCD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6813630", Offset = "0x6812230", VA = "0x186813630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private LFCCKPAOBHF GPMGJNAOOEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6813300", Offset = "0x6811F00", VA = "0x186813300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NKCHJCNEEJJ MHBJGCIDGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x843320", Offset = "0x841F20", VA = "0x180843320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BMJIPLJCFGK EANCOJOAJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BJIMONDOFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6813840", Offset = "0x6812440", VA = "0x186813840", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PCEAPMCMJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x68132B0", Offset = "0x6811EB0", VA = "0x1868132B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected LFCCKPAOBHF BLPDMPJLPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6813610", Offset = "0x6812210", VA = "0x186813610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6813D60", Offset = "0x6812960", VA = "0x186813D60")]
	public LFCCKPAOBHF(MLNAELNLPCD HHOCLHGANHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6813950", Offset = "0x6812550", VA = "0x186813950")]
	public LFCCKPAOBHF LEMHFMODGPL(MLNAELNLPCD KELPAPMPBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x68133E0", Offset = "0x6811FE0", VA = "0x1868133E0")]
	public LFCCKPAOBHF FEGFLJLMAED(MLNAELNLPCD DMDKDMBPMNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6813660", Offset = "0x6812260", VA = "0x186813660")]
	public LFCCKPAOBHF IFPALOLJLCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6813C10", Offset = "0x6812810", VA = "0x186813C10")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6813560", Offset = "0x6812160", VA = "0x186813560")]
	public LFCCKPAOBHF FEPFKAFJNPM(MLNAELNLPCD IAAJMIGCLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6813AA0", Offset = "0x68126A0", VA = "0x186813AA0")]
	private static void NJONLHBADDC(LFCCKPAOBHF OOIPAEGEMDO, ENDBJPAOEME PIJDNDPDOCK, bool OAPJHCPIGID = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6813C00", Offset = "0x6812800", VA = "0x186813C00", Slot = "9")]
	public void NJONLHBADDC(ENDBJPAOEME LHMNAJJOJLL, bool MFLHCGPFFCL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6813850", Offset = "0x6812450", VA = "0x186813850")]
	public static LFCCKPAOBHF KGNNNOHDBBI(LFCCKPAOBHF OOIPAEGEMDO, MLNAELNLPCD FLANCDBJKLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface GFPEKNFOLEM
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool PIAKOMMJLBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KLKLLOMFGIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<KNCDGANFFJE> KNELPDOAFKP;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<KNCDGANFFJE> CHPMBEFKLID;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(FLPDKEMJJAK DJIBBLNPCFA);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(BMJIPLJCFGK CLPBEMLBMPB, BMJIPLJCFGK MPHPLMBFENG, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(APOKBMPMKIC GMKKIMJFDBL, [Optional] KNCDGANFFJE HOHHMKBFEKO);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, GFPEKNFOLEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private FLPDKEMJJAK DJIBBLNPCFA;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool PIAKOMMJLBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6815B20", Offset = "0x6814720", VA = "0x186815B20", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool KLKLLOMFGIF
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6815B80", Offset = "0x6814780", VA = "0x186815B80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<KNCDGANFFJE> KNELPDOAFKP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6815A70", Offset = "0x6814670", VA = "0x186815A70", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6815C70", Offset = "0x6814870", VA = "0x186815C70", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<KNCDGANFFJE> CHPMBEFKLID
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x68159C0", Offset = "0x68145C0", VA = "0x1868159C0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6815BC0", Offset = "0x68147C0", VA = "0x186815BC0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x843310", Offset = "0x841F10", VA = "0x180843310", Slot = "19")]
		public void SetManager(FLPDKEMJJAK DJIBBLNPCFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6815990", Offset = "0x6814590", VA = "0x186815990")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6814710", Offset = "0x6813310", VA = "0x186814710", Slot = "23")]
		public void RequestMasterConnectNodes(BMJIPLJCFGK EOCCHBGNEHC, int OBICEIIPFBK, BMJIPLJCFGK NLJDANLCAML, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6814840", Offset = "0x6813440", VA = "0x186814840", Slot = "24")]
		public void RequestMasterDisconnectNode(BMJIPLJCFGK FJFNDKJALBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6814900", Offset = "0x6813500", VA = "0x186814900", Slot = "20")]
		public void RequestMasterModifyNode(BMJIPLJCFGK CLPBEMLBMPB, BMJIPLJCFGK MPHPLMBFENG, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6814A30", Offset = "0x6813630", VA = "0x186814A30", Slot = "21")]
		public void RequestMasterReparentNodes(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6814B60", Offset = "0x6813760", VA = "0x186814B60", Slot = "25")]
		public void RequestMasterReparentToRoot(BMJIPLJCFGK IMEDOAGIBAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x68145E0", Offset = "0x68131E0", VA = "0x1868145E0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(APOKBMPMKIC GMKKIMJFDBL, [Optional] KNCDGANFFJE HOHHMKBFEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6814F40", Offset = "0x6813B40", VA = "0x186814F40")]
		[IAAIPICNCCF]
		private void RpcMasterConnectNodes(BMJIPLJCFGK EOCCHBGNEHC, int OBICEIIPFBK, BMJIPLJCFGK NLJDANLCAML, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6815200", Offset = "0x6813E00", VA = "0x186815200")]
		[IAAIPICNCCF]
		private void RpcMasterDisconnectNode(BMJIPLJCFGK FJFNDKJALBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6815540", Offset = "0x6814140", VA = "0x186815540")]
		[IAAIPICNCCF]
		private void RpcMasterReparentNodes(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6815340", Offset = "0x6813F40", VA = "0x186815340")]
		[IAAIPICNCCF]
		private void RpcMasterModifyNode(BMJIPLJCFGK CLPBEMLBMPB, BMJIPLJCFGK MPHPLMBFENG, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6814D30", Offset = "0x6813930", VA = "0x186814D30")]
		[IAAIPICNCCF]
		private void RpcConnectNodes(BMJIPLJCFGK EOCCHBGNEHC, int OBICEIIPFBK, BMJIPLJCFGK NLJDANLCAML, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ, JKIIIIOMOEA EKNBEPGDHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6814EB0", Offset = "0x6813AB0", VA = "0x186814EB0")]
		[IAAIPICNCCF]
		private void RpcDisconnectNode(BMJIPLJCFGK FJFNDKJALBM, JKIIIIOMOEA EKNBEPGDHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6815890", Offset = "0x6814490", VA = "0x186815890")]
		[IAAIPICNCCF]
		private void RpcReparentNodes(BMJIPLJCFGK IMEDOAGIBAL, int LGNMGKCNMBO, BMJIPLJCFGK IAAJMIGCLIP, int FCOIGFPAOML, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ, JKIIIIOMOEA EKNBEPGDHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x68157D0", Offset = "0x68143D0", VA = "0x1868157D0")]
		[IAAIPICNCCF]
		private void RpcModifyNode(BMJIPLJCFGK CLPBEMLBMPB, int OBICEIIPFBK, int ELAPHGOKJON, Vector3 MLKHGOLMFMA, Quaternion APICIONBBGJ, JKIIIIOMOEA EKNBEPGDHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6814E70", Offset = "0x6813A70", VA = "0x186814E70")]
		[IAAIPICNCCF]
		private void RpcDeserializeConnectableGraph(APOKBMPMKIC ENLPGHMPOPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x85FF60", Offset = "0x85EB60", VA = "0x18085FF60")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, DHLFGMOGFPB, CEFCNCGOBKL.DLMBKIJCCPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6814400", Offset = "0x6813000", VA = "0x186814400", Slot = "4")]
		private void NMFCIBNDNBC(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6813E10", Offset = "0x6812A10", VA = "0x186813E10", Slot = "5")]
		private void AHFLONNCKJC(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6814280", Offset = "0x6812E80", VA = "0x186814280", Slot = "6")]
		private void GINDPNKPHOG(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6814090", Offset = "0x6812C90", VA = "0x186814090", Slot = "7")]
		private void GCKKOAKLHPB(BMJIPLJCFGK NLJDANLCAML, MLNAELNLPCD EJMCPAEEGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6814390", Offset = "0x6812F90", VA = "0x186814390", Slot = "8")]
		private DHLFGMOGFPB HJDGJLGJFEI(Transform KHIOEALLADK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6814580", Offset = "0x6813180", VA = "0x186814580", Slot = "9")]
		private void PBBMBMPBDDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NINDJBJLBIA
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2C9F5B0", Offset = "0x2C9E1B0", VA = "0x182C9F5B0")]
	public static GJEKFLNDBGF<T> CCDKGNDAADA<T>(this LLIMAHMFNLB INBELNINGBJ)
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
