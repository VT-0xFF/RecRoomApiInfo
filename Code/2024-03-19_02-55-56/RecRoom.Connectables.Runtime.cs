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
	public class LogRegistrationIndex : JEBMLOLOJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x60FFFC0", Offset = "0x60FEFC0", VA = "0x1860FFFC0", Slot = "4")]
		public override void PCEAKBMIBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
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
	public class _AssemblyIndex : GGAMJMDOFPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private HCDJNOEMFDF bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private HCDJNOEMFDF bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6101500", Offset = "0x6100500", VA = "0x186101500", Slot = "5")]
		public override void FECPPHBOIKG(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61016B0", Offset = "0x61006B0", VA = "0x1861016B0")]
		private void MMMABEIHAIP(LBOIHOEMEKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6101540", Offset = "0x6100540", VA = "0x186101540")]
		private void JKJFJAKLCJI(LBOIHOEMEKD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x61011C0", Offset = "0x61001C0", VA = "0x1861011C0", Slot = "6")]
		public override void BPJLBOBFIFD(LBOIHOEMEKD registry, [In] OFPCFOAIPIF filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "8")]
		public override void PKDINHKFILI(DOOENEHKPHI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6101820", Offset = "0x6100820", VA = "0x186101820")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class EOIBLGPAELL : GAKJHDKMINJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IAGDLGPAMEM : IEnumerable<LGANKBMHMJI>, IEnumerable, IEnumerator<LGANKBMHMJI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LGANKBMHMJI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private LAIJBGHHNPC localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public LAIJBGHHNPC <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EOIBLGPAELL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NBLMPAGPGLM <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private EJHDFOFGLLL.HFPKAHIJEOD <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private LGANKBMHMJI System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80FF60", Offset = "0x80EF60", VA = "0x18080FF60")]
		[DebuggerHidden]
		public IAGDLGPAMEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60FCDA0", Offset = "0x60FBDA0", VA = "0x1860FCDA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60FC8E0", Offset = "0x60FB8E0", VA = "0x1860FC8E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60FC8C0", Offset = "0x60FB8C0", VA = "0x1860FC8C0")]
		private void GFMFCNEFFMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x60FCD50", Offset = "0x60FBD50", VA = "0x1860FCD50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60FCCA0", Offset = "0x60FBCA0", VA = "0x1860FCCA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LGANKBMHMJI> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60FCCA0", Offset = "0x60FBCA0", VA = "0x1860FCCA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly LPCGADPJIJD DILBFCHMBNE;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly LPCGADPJIJD PBLFKECIBCB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly LPCGADPJIJD APNBCJLJJJF;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly LPCGADPJIJD HFJEJGBPHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BFAEJIBAKGA JEJDAOMFCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FMNONACNANH HFNBIIGEMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private GIMKJLJEGAM EFCCBECFLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private IIHAABNEEMO HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private IHAKCNDGDPL CIDOCLLBDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FJHHBFLIPMC OEMCDBOBCGA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CD220", Offset = "0x7CC220", VA = "0x1807CD220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA70", Offset = "0x7CBA70", VA = "0x1807CCA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI> DCCPCHMOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60F8F30", Offset = "0x60F7F30", VA = "0x1860F8F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60F9B40", Offset = "0x60F8B40", VA = "0x1860F9B40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI> MFPKNFDJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60FA120", Offset = "0x60F9120", VA = "0x1860FA120", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60FA1D0", Offset = "0x60F91D0", VA = "0x1860FA1D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI, LGANKBMHMJI> FDMEIOIGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60FA000", Offset = "0x60F9000", VA = "0x1860FA000", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60F89B0", Offset = "0x60F79B0", VA = "0x1860F89B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60FA3F0", Offset = "0x60F93F0", VA = "0x1860FA3F0")]
	public EOIBLGPAELL(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60F70F0", Offset = "0x60F60F0", VA = "0x1860F70F0", Slot = "11")]
	public void DPGLELIALOP(GameObject LNIPGKDIFCK, IHFCLEGKNHN IFGIBLFJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60F7360", Offset = "0x60F6360", VA = "0x1860F7360", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60F43B0", Offset = "0x60F33B0", VA = "0x1860F43B0", Slot = "21")]
	public bool LIAILMJNEDD(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60F6EE0", Offset = "0x60F5EE0", VA = "0x1860F6EE0")]
	private void DNBBPDPKPAL(LAIJBGHHNPC BECMPEIBBGC, LAIJBGHHNPC OACKOKHNKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60F6200", Offset = "0x60F5200", VA = "0x1860F6200")]
	private void AKFNIEPHOJH(LAIJBGHHNPC BECMPEIBBGC, LAIJBGHHNPC ICKADGMCDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60F5F80", Offset = "0x60F4F80", VA = "0x1860F5F80")]
	private void AFGBAABHDDL(LAIJBGHHNPC BECMPEIBBGC, LAIJBGHHNPC ICKADGMCDEI, LAIJBGHHNPC OACKOKHNKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60F76E0", Offset = "0x60F66E0", VA = "0x1860F76E0")]
	private void ELOPOJNFBNF(LAIJBGHHNPC BECMPEIBBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "12")]
	public void EKOOOFBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60F9BF0", Offset = "0x60F8BF0", VA = "0x1860F9BF0", Slot = "13")]
	public void PCEAKBMIBLF(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "14")]
	public void MMOHGFKLHKG(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60F6D80", Offset = "0x60F5D80", VA = "0x1860F6D80", Slot = "16")]
	public void DKLBFCIDBKJ(LGANKBMHMJI MINABKJIOJA, LGANKBMHMJI DHNODEGEGNG, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60F6C40", Offset = "0x60F5C40", VA = "0x1860F6C40")]
	public void DKLBFCIDBKJ(LAIJBGHHNPC ONPHKLFILKP, LAIJBGHHNPC DHNODEGEGNG, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60F9F70", Offset = "0x60F8F70", VA = "0x1860F9F70")]
	public void PJMEGCPOEME(LGANKBMHMJI MINABKJIOJA, float PEGEMKMKKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60F92C0", Offset = "0x60F82C0", VA = "0x1860F92C0", Slot = "17")]
	public void MBDPOKKDDJF(LGANKBMHMJI AJAFLFANKKB, int FIDOALOPDNL, LGANKBMHMJI KGILDOIHFKB, int FCECPJOOMHB, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60F67F0", Offset = "0x60F57F0", VA = "0x1860F67F0")]
	private float BNAMKGPLKAP(LAIJBGHHNPC ONPHKLFILKP, LAIJBGHHNPC MMPNPJILHCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60F9470", Offset = "0x60F8470", VA = "0x1860F9470")]
	public void MBDPOKKDDJF(LAIJBGHHNPC ONPHKLFILKP, LAIJBGHHNPC MMPNPJILHCD, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60F9410", Offset = "0x60F8410", VA = "0x1860F9410")]
	public void MBDPOKKDDJF(LAIJBGHHNPC ONPHKLFILKP, LAIJBGHHNPC MMPNPJILHCD, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI, float PEGEMKMKKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60F95A0", Offset = "0x60F85A0", VA = "0x1860F95A0", Slot = "18")]
	public void MIEOHPFGNLL(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60F8BD0", Offset = "0x60F7BD0", VA = "0x1860F8BD0")]
	public bool KBGFPAKLBEI(LAIJBGHHNPC JHPDAOFKDGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60F68A0", Offset = "0x60F58A0", VA = "0x1860F68A0", Slot = "15")]
	public void CCOJJEJLFKP(LGANKBMHMJI MINABKJIOJA, HashSet<LGANKBMHMJI> DPDBLKFDEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "19")]
	public JLLFKODPPOM MEAGBINGALE(bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "20")]
	public JLLFKODPPOM BLOICIIIJAG(HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60F9F00", Offset = "0x60F8F00", VA = "0x1860F9F00", Slot = "22")]
	public void PEKHEJKGDEN(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60FA0B0", Offset = "0x60F90B0", VA = "0x1860FA0B0", Slot = "23")]
	public void PLKKKNKCFGI(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60F9710", Offset = "0x60F8710", VA = "0x1860F9710", Slot = "24")]
	public void MJLKODHABBA(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60F6490", Offset = "0x60F5490", VA = "0x1860F6490")]
	private void BEMJDGGKEMO(LAIJBGHHNPC ONPHKLFILKP, LAIJBGHHNPC MMPNPJILHCD, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI, float PEGEMKMKKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60F9730", Offset = "0x60F8730", VA = "0x1860F9730")]
	private void MKGOBKENPGL(LAIJBGHHNPC ONPHKLFILKP, LAIJBGHHNPC DIMMPCLNOKP, Vector3 IFFNKCNEEAK, Quaternion KLEJIABFHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60F6420", Offset = "0x60F5420", VA = "0x1860F6420")]
	private void BCFJNBICCGD(LAIJBGHHNPC ONPHKLFILKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60F8860", Offset = "0x60F7860", VA = "0x1860F8860")]
	[IteratorStateMachine(typeof(IAGDLGPAMEM))]
	public IEnumerable<LGANKBMHMJI> JCMCIOPAHGJ(LAIJBGHHNPC JHPDAOFKDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60F83E0", Offset = "0x60F73E0", VA = "0x1860F83E0")]
	internal LGANKBMHMJI IPDLCDCACJO(LAIJBGHHNPC JHPDAOFKDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60F8E60", Offset = "0x60F7E60", VA = "0x1860F8E60")]
	internal LAIJBGHHNPC KDCIPMJIKKE(LGANKBMHMJI MINABKJIOJA)
	{
		return default(LAIJBGHHNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60F7E10", Offset = "0x60F6E10", VA = "0x1860F7E10")]
	private bool ILMGNANMOFH(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60F88F0", Offset = "0x60F78F0", VA = "0x1860F88F0")]
	private bool JDHMADPAMCD(ODHMCLAKNMJ OKABGGPDJIM, [Out] LGANKBMHMJI MMPNPJILHCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60F8520", Offset = "0x60F7520", VA = "0x1860F8520")]
	private LGANKBMHMJI IPDLCDCACJO(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60F7550", Offset = "0x60F6550", VA = "0x1860F7550")]
	private LGANKBMHMJI EFFNPPDGIJB(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60F8A60", Offset = "0x60F7A60", VA = "0x1860F8A60")]
	private LGANKBMHMJI JPMDGEGGPPJ(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60F14D0", Offset = "0x60F04D0", VA = "0x1860F14D0")]
	private static Guid IBGINIPIJON(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60F5E90", Offset = "0x60F4E90", VA = "0x1860F5E90")]
	private string AEGOPIOJADL(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60F7C80", Offset = "0x60F6C80", VA = "0x1860F7C80")]
	private void IDAOGONOOBD(LGANKBMHMJI ONPHKLFILKP, LGANKBMHMJI DIMMPCLNOKP, RigidTransform BDMNPGBMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60F5D00", Offset = "0x60F4D00", VA = "0x1860F5D00")]
	private void ABHJHKCLIML(LGANKBMHMJI DIMMPCLNOKP, LGANKBMHMJI ONPHKLFILKP, RigidTransform BDMNPGBMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60F8950", Offset = "0x60F7950", VA = "0x1860F8950")]
	private void JFJPBEBPBAO(LGANKBMHMJI OJFMLGNCJNN, LGANKBMHMJI ONPHKLFILKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60F6AB0", Offset = "0x60F5AB0", VA = "0x1860F6AB0")]
	private void CMBNHHEPKLN(LGANKBMHMJI ONPHKLFILKP, LGANKBMHMJI MMPNPJILHCD, RigidTransform BDMNPGBMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60F7B70", Offset = "0x60F6B70", VA = "0x1860F7B70")]
	private void FNIIBGHGAHJ(LAIJBGHHNPC JHPDAOFKDGB, LGANKBMHMJI MINABKJIOJA, LAIJBGHHNPC ICKADGMCDEI, LAIJBGHHNPC OACKOKHNKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x60F8FE0", Offset = "0x60F7FE0", VA = "0x1860F8FE0")]
	private void LCCIGAJFHCD(LAIJBGHHNPC JHPDAOFKDGB, LGANKBMHMJI MINABKJIOJA, LGANKBMHMJI AIPDFEPFBJG, LGANKBMHMJI LNBEBOHINAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GBBFDECDEOO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MGDKKDPLFIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ONGJLMJLNJA container;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public MGDKKDPLFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6100090", Offset = "0x60FF090", VA = "0x186100090")]
		internal EOIBLGPAELL LAAPBGLNICP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60FC600", Offset = "0x60FB600", VA = "0x1860FC600")]
	public static void MMNFCMCFOLO(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60FC5B0", Offset = "0x60FB5B0", VA = "0x1860FC5B0")]
	public static void BDLAPMCFFGK(ONGJLMJLNJA CNBEIAALEIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FHAIHFGFCPF : OGPKCFOFHOO, NHMNEFFHKCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly RigidbodyEx NKJKBALEEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly EOIBLGPAELL IBILNFMJFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly JMBIJFHHKKA MMKLEHCEJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FCEKBGCMEEF HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ELEAPHBEOMJ[] HIIFJJAMPFC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LAIJBGHHNPC ENLFEECHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1E0", Offset = "0x7BB1E0", VA = "0x1807BC1E0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(LAIJBGHHNPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LGANKBMHMJI HJDNKEAMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60FBF60", Offset = "0x60FAF60", VA = "0x1860FBF60", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LGANKBMHMJI JEJBLAFJAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60FA5C0", Offset = "0x60F95C0", VA = "0x1860FA5C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 KHGMDJAFHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60FA560", Offset = "0x60F9560", VA = "0x1860FA560", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Quaternion ODKKDJNDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60FBD10", Offset = "0x60FAD10", VA = "0x1860FBD10", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DBLADDIOBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x60FA460", Offset = "0x60F9460", VA = "0x1860FA460", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public IEnumerable<LGANKBMHMJI> AANNAEJIODB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60FA4D0", Offset = "0x60F94D0", VA = "0x1860FA4D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	[Obsolete]
	public bool BGHBKBJDBEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8828E0", Offset = "0x8818E0", VA = "0x1808828E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x882A00", Offset = "0x881A00", VA = "0x180882A00", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x60FC170", Offset = "0x60FB170", VA = "0x1860FC170", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GameObject NGDMKBHFJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x227AA90", Offset = "0x2279A90", VA = "0x18227AA90", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60FBE90", Offset = "0x60FAE90", VA = "0x1860FBE90", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Guid MGHAJNGEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x60FBFC0", Offset = "0x60FAFC0", VA = "0x1860FBFC0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IOOAHOJDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60FC0A0", Offset = "0x60FB0A0", VA = "0x1860FC0A0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EOKOMCHJAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private bool PHFGMBJFABL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x60FAB70", Offset = "0x60F9B70", VA = "0x1860FAB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event CEFOBKPKEOG HFIJHHDICGA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60FAB10", Offset = "0x60F9B10", VA = "0x1860FAB10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60FA720", Offset = "0x60F9720", VA = "0x1860FA720", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event CEFOBKPKEOG CLLMEOFGJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60FBCB0", Offset = "0x60FACB0", VA = "0x1860FBCB0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60FA500", Offset = "0x60F9500", VA = "0x1860FA500", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CEFOBKPKEOG DCAOGHFBOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60FA850", Offset = "0x60F9850", VA = "0x1860FA850", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60FB8C0", Offset = "0x60FA8C0", VA = "0x1860FB8C0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event LMPNDFJIFAO AJNAECADKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60FB820", Offset = "0x60FA820", VA = "0x1860FB820", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60FADC0", Offset = "0x60F9DC0", VA = "0x1860FADC0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60FBD90", Offset = "0x60FAD90", VA = "0x1860FBD90")]
	public FHAIHFGFCPF(LAIJBGHHNPC GDHPLPDIOBF, RigidbodyEx NKJKBALEEPO, JMBIJFHHKKA MMKLEHCEJEH, ELEAPHBEOMJ[] HIIFJJAMPFC, FCEKBGCMEEF HLIOAAOLCGJ, GAKJHDKMINJ IBILNFMJFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x60FBC30", Offset = "0x60FAC30", VA = "0x1860FBC30", Slot = "19")]
	public void NPKNANEJOGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "21")]
	public void MOANOAIGBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5F646C0", Offset = "0x5F636C0", VA = "0x185F646C0", Slot = "22")]
	public void KDPLINMFNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x60FA780", Offset = "0x60F9780", VA = "0x1860FA780", Slot = "20")]
	public void EBEKMFPLELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60FA900", Offset = "0x60F9900", VA = "0x1860FA900", Slot = "25")]
	public void GFGCAHCKEFH(int LAEMMMOGOPP, LGANKBMHMJI KGILDOIHFKB, int JAJDJOLLMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60FB060", Offset = "0x60FA060", VA = "0x1860FB060", Slot = "26")]
	public void KAOINPMDPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60FB130", Offset = "0x60FA130", VA = "0x1860FB130", Slot = "27")]
	public void LHEGBNOHPMG(int LAEMMMOGOPP, LGANKBMHMJI AJAFLFANKKB, int DPIMDEPPOED, [Optional] Vector3? BIAFJGKPABB, [Optional] Quaternion? DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60FA7D0", Offset = "0x60F97D0", VA = "0x1860FA7D0", Slot = "28")]
	public void EPPFCMNACPO(LGANKBMHMJI AJAFLFANKKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60FB410", Offset = "0x60FA410", VA = "0x1860FB410", Slot = "31")]
	public void MHNIBFHECHL(Vector3 KDANJHEKOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60FB920", Offset = "0x60FA920", VA = "0x1860FB920", Slot = "29")]
	public void NHBDNJLAOLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60FAE60", Offset = "0x60F9E60", VA = "0x1860FAE60", Slot = "30")]
	public void JJNNMOHGJDL(int GCDIELAOHNA, Vector3 HOOKHPGOOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60FACF0", Offset = "0x60F9CF0", VA = "0x1860FACF0", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int LAEMMMOGOPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60FABC0", Offset = "0x60F9BC0", VA = "0x1860FABC0", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int LAEMMMOGOPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x844DD0", Offset = "0x843DD0", VA = "0x180844DD0", Slot = "42")]
	public Color GetConnectionSlotColor(int LAEMMMOGOPP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60FA680", Offset = "0x60F9680", VA = "0x1860FA680", Slot = "43")]
	public bool CanConnectTo(int LAEMMMOGOPP, LGANKBMHMJI NMEKODGJMHB, int EIILILIJFCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "44")]
	public void ParentChanged(int LAEMMMOGOPP, LGANKBMHMJI NIBBICEEIFK, int JFNMODNEHEB, Vector3 NFAKKKFJFLA, Quaternion AJDJPAILLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "45")]
	public void ChildAdded(int LAEMMMOGOPP, LGANKBMHMJI EJIEDHJPDGG, int GLNJBJLNFGP, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "46")]
	public void ChildRemoved(int LAEMMMOGOPP, LGANKBMHMJI IEBPBBFMKMC, int NECLFPAKAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "47")]
	public void ConnectionModified(int LAEMMMOGOPP, LGANKBMHMJI KGILDOIHFKB, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60FBD70", Offset = "0x60FAD70", VA = "0x1860FBD70", Slot = "48")]
	public void RootChanged(LGANKBMHMJI MGJICKFEJDB, LGANKBMHMJI FHANKAIIAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60FA630", Offset = "0x60F9630", VA = "0x1860FA630", Slot = "23")]
	public void COPKOAJFMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60FA8B0", Offset = "0x60F98B0", VA = "0x1860FA8B0", Slot = "24")]
	public void GFDHINNADFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60FBC60", Offset = "0x60FAC60", VA = "0x1860FBC60")]
	private void OCIFKIFDLFI(bool MAFAEBIMLMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PMGKIFLEIJE(typeof(AHCGMFKEIPE), new string[] { })]
public class ICGAKPEMIKB : AHCGMFKEIPE, NIFPNAPKKPN
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class CLNMHJHNFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ICGAKPEMIKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EJHDFOFGLLL localIds;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CLNMHJHNFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60F51F0", Offset = "0x60F41F0", VA = "0x1860F51F0")]
		internal void KLNBFHIFFMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static readonly LPCGADPJIJD IJDHPGKKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[GMKIEKFMAIN]
	private NCFJIGPKFFO BGDNJKOICGK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public object DGENGOJBOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60FCE00", Offset = "0x60FBE00", VA = "0x1860FCE00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60FCE90", Offset = "0x60FBE90", VA = "0x1860FCE90", Slot = "6")]
	public void InitReferences(PAOGDAFANAL OEMCDBOBCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60FCEE0", Offset = "0x60FBEE0", VA = "0x1860FCEE0", Slot = "5")]
	public void JLCBKDMCOMA(EJHDFOFGLLL DBKPFOODGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ICGAKPEMIKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PMGKIFLEIJE(typeof(GAKJHDKMINJ), new string[] { "Ignore", "Mock" })]
public class FOMJBNHGPHA : GAKJHDKMINJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI> DCCPCHMOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60FC240", Offset = "0x60FB240", VA = "0x1860FC240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x60FC2F0", Offset = "0x60FB2F0", VA = "0x1860FC2F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI> MFPKNFDJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60FC450", Offset = "0x60FB450", VA = "0x1860FC450", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60FC500", Offset = "0x60FB500", VA = "0x1860FC500", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI, LGANKBMHMJI> FDMEIOIGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60FC3A0", Offset = "0x60FB3A0", VA = "0x1860FC3A0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60FC190", Offset = "0x60FB190", VA = "0x1860FC190", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "11")]
	public void DPGLELIALOP(GameObject LNIPGKDIFCK, IHFCLEGKNHN IFGIBLFJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "12")]
	public void EKOOOFBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "13")]
	public void PCEAKBMIBLF(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "14")]
	public void MMOHGFKLHKG(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "15")]
	public void CCOJJEJLFKP(LGANKBMHMJI MINABKJIOJA, HashSet<LGANKBMHMJI> DPDBLKFDEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "16")]
	public void DKLBFCIDBKJ(LGANKBMHMJI MINABKJIOJA, LGANKBMHMJI DHNODEGEGNG, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "17")]
	public void MBDPOKKDDJF(LGANKBMHMJI MINABKJIOJA, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "18")]
	public void MIEOHPFGNLL(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "19")]
	public JLLFKODPPOM MEAGBINGALE(bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7BB290", Offset = "0x7BA290", VA = "0x1807BB290", Slot = "20")]
	public JLLFKODPPOM BLOICIIIJAG(HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "21")]
	public bool LIAILMJNEDD(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "22")]
	public void PEKHEJKGDEN(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "23")]
	public void PLKKKNKCFGI(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "24")]
	public void MJLKODHABBA(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public FOMJBNHGPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LGANKBMHMJI : NHMNEFFHKCI, IEquatable<LGANKBMHMJI>
{
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface NHMNEFFHKCI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LGANKBMHMJI HJDNKEAMBKE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GameObject NGDMKBHFJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string JJGLPFPAGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Guid MGHAJNGEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	int IOOAHOJDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LAIJBGHHNPC ENLFEECHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EOKOMCHJAIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int LAEMMMOGOPP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int LAEMMMOGOPP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int LAEMMMOGOPP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int LAEMMMOGOPP, LGANKBMHMJI NMEKODGJMHB, int JJKINHMLDND);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int LAEMMMOGOPP, LGANKBMHMJI NIBBICEEIFK, int JFNMODNEHEB, Vector3 NFAKKKFJFLA, Quaternion AJDJPAILLGB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int LAEMMMOGOPP, LGANKBMHMJI EJIEDHJPDGG, int GLNJBJLNFGP, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int LAEMMMOGOPP, LGANKBMHMJI IEBPBBFMKMC, int NECLFPAKAEP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int LAEMMMOGOPP, LGANKBMHMJI KGILDOIHFKB, int CBKDIMKMFPO, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(LGANKBMHMJI MGJICKFEJDB, LGANKBMHMJI FHANKAIIAAD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[PFJACEDCDHI(DIENCAJKNHD.OMRoom)]
public interface GAKJHDKMINJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LGANKBMHMJI, LGANKBMHMJI> DCCPCHMOMAB;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LGANKBMHMJI, LGANKBMHMJI> MFPKNFDJHIG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LGANKBMHMJI, LGANKBMHMJI, LGANKBMHMJI> FDMEIOIGGMJ;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DPGLELIALOP(GameObject LNIPGKDIFCK, IHFCLEGKNHN IFGIBLFJIFO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EKOOOFBJPAE();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PCEAKBMIBLF(LGANKBMHMJI MINABKJIOJA);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MMOHGFKLHKG(LGANKBMHMJI MINABKJIOJA);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CCOJJEJLFKP(LGANKBMHMJI MINABKJIOJA, HashSet<LGANKBMHMJI> DPDBLKFDEMB);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DKLBFCIDBKJ(LGANKBMHMJI MINABKJIOJA, LGANKBMHMJI DHNODEGEGNG, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MBDPOKKDDJF(LGANKBMHMJI MINABKJIOJA, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MIEOHPFGNLL(LGANKBMHMJI MINABKJIOJA);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JLLFKODPPOM MEAGBINGALE(bool OLLLLPMEENK);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JLLFKODPPOM BLOICIIIJAG(HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool LIAILMJNEDD(ODHMCLAKNMJ OKABGGPDJIM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void PEKHEJKGDEN(JLLFKODPPOM AIAGFCPBNID);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void PLKKKNKCFGI(JLLFKODPPOM AIAGFCPBNID);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MJLKODHABBA(JLLFKODPPOM AIAGFCPBNID);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IIHAABNEEMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool BGIEHPPIPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LGANKBMHMJI JPMDGEGGPPJ(int OFDDBCDKICM);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LGANKBMHMJI EFFNPPDGIJB(Guid FPCMOCMDNGK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DECDMKBGOPB(LGANKBMHMJI MINABKJIOJA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHMNJIKNNCN();

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOKLPKLECDA(LGANKBMHMJI MMKLEHCEJEH);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[PFJACEDCDHI(DIENCAJKNHD.Application)]
public interface FCEKBGCMEEF
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PHFGMBJFABL(JMBIJFHHKKA MMKLEHCEJEH);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CKPLFDPPKCG(JMBIJFHHKKA MMKLEHCEJEH);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string OKIIELFOFHA(JMBIJFHHKKA MMKLEHCEJEH);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid NOHMLDGNKGM(JMBIJFHHKKA MMKLEHCEJEH);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EOHPPADAMLF(JMBIJFHHKKA MMKLEHCEJEH);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCJGKINNAFJ(JMBIJFHHKKA MMKLEHCEJEH);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public delegate void CEFOBKPKEOG(LGANKBMHMJI AJAFLFANKKB, int OKLEKLEAHNO, LGANKBMHMJI KGILDOIHFKB, int LMKFPPMLKMI, [Optional] Vector3? BIAFJGKPABB, [Optional] Quaternion? DIMGMKENOOP);
[Cpp2IlInjected.Token(Token = "0x2000012")]
public delegate void LMPNDFJIFAO(LGANKBMHMJI MGJICKFEJDB, LGANKBMHMJI FHANKAIIAAD);
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JMBIJFHHKKA : LGANKBMHMJI, NHMNEFFHKCI, IEquatable<LGANKBMHMJI>
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OGPKCFOFHOO : NHMNEFFHKCI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	LGANKBMHMJI JEJBLAFJAKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IEnumerable<LGANKBMHMJI> AANNAEJIODB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Vector3 KHGMDJAFHAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	Quaternion ODKKDJNDNPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DBLADDIOBHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool BGHBKBJDBEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event CEFOBKPKEOG HFIJHHDICGA;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event CEFOBKPKEOG CLLMEOFGJMD;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event CEFOBKPKEOG DCAOGHFBOPO;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event LMPNDFJIFAO AJNAECADKAD;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NPKNANEJOGJ();

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EBEKMFPLELC();

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MOANOAIGBFE();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void KDPLINMFNIH();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void COPKOAJFMKL();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GFDHINNADFA();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GFGCAHCKEFH(int LAEMMMOGOPP, LGANKBMHMJI KGILDOIHFKB, int JAJDJOLLMNF);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KAOINPMDPAI();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LHEGBNOHPMG(int LAEMMMOGOPP, LGANKBMHMJI AJAFLFANKKB, int DPIMDEPPOED, [Optional] Vector3? BIAFJGKPABB, [Optional] Quaternion? DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EPPFCMNACPO(LGANKBMHMJI AJAFLFANKKB);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NHBDNJLAOLK();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JJNNMOHGJDL(int GCDIELAOHNA, Vector3 HOOKHPGOOGE);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MHNIBFHECHL(Vector3 KDANJHEKOIA);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ELEAPHBEOMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Vector3 GBFPEHPCJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IHFCLEGKNHN
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool OGGMLEMEBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	PIBPCHLLMBF LHMMDMLOLOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ConnectableConfigData : ScriptableObject, IHFCLEGKNHN
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		[FormerlySerializedAs("linkVisualPrefab")]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x835210", Offset = "0x834210", VA = "0x180835210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public PIBPCHLLMBF LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60F52E0", Offset = "0x60F42E0", VA = "0x1860F52E0")]
		public static ConnectableConfigData DMIHKPCOCKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x60F5390", Offset = "0x60F4390", VA = "0x1860F5390")]
		public ConnectableConfigData(LegacyConnectableLinkVisual NGKPJOGILJG, bool IFFNNFKJMON)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JEOBBLCADLH : IEquatable<JEOBBLCADLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public LGANKBMHMJI MINABKJIOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int FNPIHHBPLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int CBKDIMKMFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public Vector3 BIAFJGKPABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public Quaternion DIMGMKENOOP;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60FDFD0", Offset = "0x60FCFD0", VA = "0x1860FDFD0")]
	public JEOBBLCADLH(LGANKBMHMJI MINABKJIOJA, int FNPIHHBPLCJ, int CBKDIMKMFPO, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60FDF30", Offset = "0x60FCF30", VA = "0x1860FDF30")]
	public JEOBBLCADLH(LGANKBMHMJI MINABKJIOJA, int FNPIHHBPLCJ, int CBKDIMKMFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x60FE030", Offset = "0x60FD030", VA = "0x1860FE030")]
	public JEOBBLCADLH(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60FDAC0", Offset = "0x60FCAC0", VA = "0x1860FDAC0", Slot = "4")]
	public bool Equals(JEOBBLCADLH PJNBIAFGNNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60FDB70", Offset = "0x60FCB70", VA = "0x1860FDB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[UnityEngine.Scripting.Preserve]
public class IJJFHPEHEIA : EMPOOBCBOPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform NJKBLELAEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private PIBPCHLLMBF EAKLLFGCOBM;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5C11810", Offset = "0x5C10810", VA = "0x185C11810", Slot = "4")]
	public void DPGLELIALOP(Transform NJKBLELAEGN, PIBPCHLLMBF EAKLLFGCOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x60FD9A0", Offset = "0x60FC9A0", VA = "0x1860FD9A0", Slot = "5")]
	public PIBPCHLLMBF JHPLLMGKIOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x60FDA70", Offset = "0x60FCA70", VA = "0x1860FDA70", Slot = "6")]
	public void OPCPLJLHNAJ(PIBPCHLLMBF NJCNIEJOEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public IJJFHPEHEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal class ANPIPNFDDKF : IDisposable, AGDEGDDIHLO
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class NEAMCJOJCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LGANKBMHMJI oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LGANKBMHMJI newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public NEAMCJOJCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6101060", Offset = "0x6100060", VA = "0x186101060")]
		internal bool HMPMJKDDGLG(LBAKOKIKILE node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly MPDDDHBMIOA MMDJPLOKEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private MNLJDOMJJBC NGEGDDLINKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private DEPJLNELJHN HNGAAMFJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private bool IFFNNFKJMON;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public LBAKOKIKILE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x60ED9B0", Offset = "0x60EC9B0", VA = "0x1860ED9B0")]
	public bool LKDCEFFHFEF([In] GEGLHNFAABK ELANMAGHLLI, bool NCDBHBJIIDA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x60EE660", Offset = "0x60ED660", VA = "0x1860EE660")]
	private bool LIHMEKIOBJK([In] GEGLHNFAABK ELANMAGHLLI, bool NCDBHBJIIDA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x60F0240", Offset = "0x60EF240", VA = "0x1860F0240")]
	public ANPIPNFDDKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x60ED240", Offset = "0x60EC240", VA = "0x1860ED240", Slot = "5")]
	public void DPGLELIALOP(GAKJHDKMINJ JDIOCIOLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x60EE4C0", Offset = "0x60ED4C0", VA = "0x1860EE4C0", Slot = "17")]
	public void JOHANFGCFLF(MBLHFJEKEBO ADABDJONAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x60EDE20", Offset = "0x60ECE20", VA = "0x1860EDE20", Slot = "12")]
	public void ILCAJGADHEB(Func<LGANKBMHMJI, bool> ADBPHPFECEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x60EDE30", Offset = "0x60ECE30", VA = "0x1860EDE30")]
	private void ILCAJGADHEB(MPDDDHBMIOA PENNBKHEEFF, Func<LGANKBMHMJI, bool> ADBPHPFECEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x60F00A0", Offset = "0x60EF0A0", VA = "0x1860F00A0", Slot = "11")]
	public void NPFMMABPLBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x60EBE00", Offset = "0x60EAE00", VA = "0x1860EBE00", Slot = "8")]
	public bool BEDFPHNGAKA(LGANKBMHMJI CJCKPKJNOND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x60EF750", Offset = "0x60EE750", VA = "0x1860EF750")]
	private bool LOIKJIHHFJH(LGANKBMHMJI JEJDCEIFKPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60F0190", Offset = "0x60EF190", VA = "0x1860F0190")]
	private static bool PFGOMDCAONJ(LGANKBMHMJI JEJDCEIFKPG, MPDDDHBMIOA AMEDBGNPNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60ECE50", Offset = "0x60EBE50", VA = "0x1860ECE50")]
	private void DDOAOONJHFB(Transform EGHGEHDHAGI, MPDDDHBMIOA ILBDIEEGPPJ, MPDDDHBMIOA[] PHJNJFBLFFB, LGANKBMHMJI FHJIGEHADDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60EFE20", Offset = "0x60EEE20", VA = "0x1860EFE20")]
	private JEOBBLCADLH MBIDACHAOGB(Transform INOGAFAGFHD, JEOBBLCADLH ENDHILFOMEA)
	{
		return default(JEOBBLCADLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x60EEEC0", Offset = "0x60EDEC0", VA = "0x1860EEEC0")]
	private static bool LKGENDFOOLG(MPDDDHBMIOA AMEDBGNPNHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60F00C0", Offset = "0x60EF0C0", VA = "0x1860F00C0")]
	private string OKIIELFOFHA(LGANKBMHMJI MINABKJIOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x60ED310", Offset = "0x60EC310", VA = "0x1860ED310")]
	private string EOHPPADAMLF(LGANKBMHMJI MINABKJIOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60EB7E0", Offset = "0x60EA7E0", VA = "0x1860EB7E0")]
	private void ACALKIPLJED([In] GEGLHNFAABK ELANMAGHLLI, bool LAFOEMFOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x60EBFD0", Offset = "0x60EAFD0", VA = "0x1860EBFD0")]
	private void BFFIAIDLJAK(LGANKBMHMJI ONPHKLFILKP, bool LAFOEMFOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x60EC880", Offset = "0x60EB880", VA = "0x1860EC880")]
	private void CPLMDBHMJPA(LGANKBMHMJI DLMNOHILJBB, int DPIMDEPPOED, LGANKBMHMJI DIMMPCLNOKP, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP, bool LAFOEMFOPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x60EF150", Offset = "0x60EE150", VA = "0x1860EF150")]
	private void LNOJEPNMLLC(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP, bool DIOJBPHIOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x60EB700", Offset = "0x60EA700", VA = "0x1860EB700", Slot = "9")]
	public bool ACACBIBJKPB(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x60EDAD0", Offset = "0x60ECAD0", VA = "0x1860EDAD0")]
	private bool HIPAEKLABEP(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x60EED40", Offset = "0x60EDD40", VA = "0x1860EED40")]
	private static void LJBPMMHGAIJ(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP, MPDDDHBMIOA OJIIDNFCNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x60EDD00", Offset = "0x60ECD00", VA = "0x1860EDD00")]
	private void IDAOGONOOBD(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60EE450", Offset = "0x60ED450", VA = "0x1860EE450")]
	private void JLIKECELIOI(MPDDDHBMIOA PENNBKHEEFF, LGANKBMHMJI AIPDFEPFBJG, LGANKBMHMJI LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60EE3E0", Offset = "0x60ED3E0", VA = "0x1860EE3E0")]
	private void JLIKECELIOI(LGANKBMHMJI MINABKJIOJA, LGANKBMHMJI AIPDFEPFBJG, LGANKBMHMJI LNBEBOHINAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60EE4F0", Offset = "0x60ED4F0", VA = "0x1860EE4F0")]
	private void LCCIGAJFHCD(LGANKBMHMJI MINABKJIOJA, LGANKBMHMJI AIPDFEPFBJG, LGANKBMHMJI LNBEBOHINAM, bool MFKAOOGPGCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60EE560", Offset = "0x60ED560", VA = "0x1860EE560")]
	private void LCCIGAJFHCD(MPDDDHBMIOA HLMIIECLDOF, LGANKBMHMJI FHJIGEHADDE, LGANKBMHMJI FHANKAIIAAD, bool MFKAOOGPGCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x60EB5E0", Offset = "0x60EA5E0", VA = "0x1860EB5E0")]
	private void ABHJHKCLIML(LGANKBMHMJI ONPHKLFILKP, int DPIMDEPPOED, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x60EE280", Offset = "0x60ED280", VA = "0x1860EE280")]
	private void JFJPBEBPBAO(LBAKOKIKILE MMPNPJILHCD, LBAKOKIKILE NCMJIJFCDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x60EE120", Offset = "0x60ED120", VA = "0x1860EE120", Slot = "18")]
	public LGANKBMHMJI JEICNOGMHDN(LGANKBMHMJI MINABKJIOJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60EC1A0", Offset = "0x60EB1A0", VA = "0x1860EC1A0", Slot = "13")]
	public void CCOJJEJLFKP(LGANKBMHMJI MINABKJIOJA, HashSet<LGANKBMHMJI> BPKGLHEEOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60EC640", Offset = "0x60EB640", VA = "0x1860EC640", Slot = "14")]
	public List<LGANKBMHMJI> CPJIDADBHMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60EF080", Offset = "0x60EE080", VA = "0x1860EF080")]
	protected LBAKOKIKILE LNNOFKNOGOD(LBAKOKIKILE PENNBKHEEFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60ED910", Offset = "0x60EC910", VA = "0x1860ED910")]
	protected MPDDDHBMIOA[] FLNAAOOGNBG(MPDDDHBMIOA AMEDBGNPNHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60EEC30", Offset = "0x60EDC30", VA = "0x1860EEC30")]
	protected bool LIIDBLHANFP(LGANKBMHMJI MINABKJIOJA, [Out] MPDDDHBMIOA PENNBKHEEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x60EFF70", Offset = "0x60EEF70", VA = "0x1860EFF70", Slot = "15")]
	public bool MGKPIIPCDHH(LGANKBMHMJI MINABKJIOJA, [Out] JEOBBLCADLH PPEPLGKFOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x60ED2D0", Offset = "0x60EC2D0", VA = "0x1860ED2D0")]
	protected MPDDDHBMIOA EMNELEDHDDC(JEOBBLCADLH KBELPHPCFNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x60EC550", Offset = "0x60EB550", VA = "0x1860EC550", Slot = "10")]
	public bool CFOANDKKBKH(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x60ED380", Offset = "0x60EC380", VA = "0x1860ED380")]
	private bool FDBELNJALFG(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x60EDA00", Offset = "0x60ECA00", VA = "0x1860EDA00")]
	private static bool HFAOFFLIADJ(MPDDDHBMIOA KFIHGIKIGEP, JEOBBLCADLH HJPLPOBGOHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x60ED9B0", Offset = "0x60EC9B0", VA = "0x1860ED9B0", Slot = "7")]
	private bool GKALLJGEPIJ([In] GEGLHNFAABK ELANMAGHLLI, bool NCDBHBJIIDA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[UnityEngine.Scripting.Preserve]
internal class CLFJEEFCHFE : GAKJHDKMINJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly ONGJLMJLNJA CNBEIAALEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly DEPJLNELJHN HNGAAMFJMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly EMHHCCFGCGH MFFOLNMGIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly AOFGKEBNIPC MFMELDEDJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly AGDEGDDIHLO AIAGFCPBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal IKLAOBGJAMB HLIOAAOLCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal KCAJPNCBGDG MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal MNLJDOMJJBC BBABINCKIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal bool IFFNNFKJMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool JMDKAIODIEE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool MNNHCHOMPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x17305B0", Offset = "0x172F5B0", VA = "0x1817305B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x17305C0", Offset = "0x172F5C0", VA = "0x1817305C0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool CLLGOADBCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x17305F0", Offset = "0x172F5F0", VA = "0x1817305F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x17305A0", Offset = "0x172F5A0", VA = "0x1817305A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI> DCCPCHMOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60F4210", Offset = "0x60F3210", VA = "0x1860F4210", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60F4940", Offset = "0x60F3940", VA = "0x1860F4940", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI> MFPKNFDJHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x60F4B60", Offset = "0x60F3B60", VA = "0x1860F4B60", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60F4BC0", Offset = "0x60F3BC0", VA = "0x1860F4BC0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LGANKBMHMJI, LGANKBMHMJI, LGANKBMHMJI> FDMEIOIGGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x60F4A50", Offset = "0x60F3A50", VA = "0x1860F4A50", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60F41B0", Offset = "0x60F31B0", VA = "0x1860F41B0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x60F4E00", Offset = "0x60F3E00", VA = "0x1860F4E00")]
	public CLFJEEFCHFE(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x60F3890", Offset = "0x60F2890", VA = "0x1860F3890", Slot = "11")]
	public void DPGLELIALOP(GameObject LNIPGKDIFCK, IHFCLEGKNHN IFGIBLFJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x60F3E60", Offset = "0x60F2E60", VA = "0x1860F3E60", Slot = "25")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x60F3F00", Offset = "0x60F2F00", VA = "0x1860F3F00", Slot = "12")]
	public void EKOOOFBJPAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x60F49A0", Offset = "0x60F39A0", VA = "0x1860F49A0", Slot = "13")]
	public void PCEAKBMIBLF(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x60F4150", Offset = "0x60F3150", VA = "0x1860F4150", Slot = "14")]
	public void MMOHGFKLHKG(LGANKBMHMJI MINABKJIOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x60F43B0", Offset = "0x60F33B0", VA = "0x1860F43B0", Slot = "21")]
	public bool LIAILMJNEDD(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x60F43C0", Offset = "0x60F33C0", VA = "0x1860F43C0")]
	internal bool LIHMEKIOBJK([In] GEGLHNFAABK ELANMAGHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x60F3F50", Offset = "0x60F2F50", VA = "0x1860F3F50")]
	internal bool FDBELNJALFG([In] GEGLHNFAABK ELANMAGHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60F3FE0", Offset = "0x60F2FE0", VA = "0x1860F3FE0")]
	internal bool GLNNAIKEHGF([In] GEGLHNFAABK ELANMAGHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60F45C0", Offset = "0x60F35C0", VA = "0x1860F45C0")]
	internal bool MDNBENOIALA([In] GEGLHNFAABK ELANMAGHLLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60F4C20", Offset = "0x60F3C20", VA = "0x1860F4C20")]
	internal void PODHGNNNOPO(LGANKBMHMJI MINABKJIOJA, int LDKNGCLOIBI, bool NCDBHBJIIDA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60F4150", Offset = "0x60F3150", VA = "0x1860F4150")]
	internal bool IIBLBKALOGA(LGANKBMHMJI NJMJBMFLOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x60F4270", Offset = "0x60F3270", VA = "0x1860F4270")]
	internal bool KLAPCFDKBKB(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x60F3580", Offset = "0x60F2580", VA = "0x1860F3580", Slot = "15")]
	public void CCOJJEJLFKP(LGANKBMHMJI MINABKJIOJA, HashSet<LGANKBMHMJI> DPDBLKFDEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x60F3680", Offset = "0x60F2680", VA = "0x1860F3680", Slot = "16")]
	public void DKLBFCIDBKJ(LGANKBMHMJI PKIFBFKKIHF, LGANKBMHMJI DHNODEGEGNG, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x60F4480", Offset = "0x60F3480", VA = "0x1860F4480", Slot = "17")]
	public void MBDPOKKDDJF(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x60F4730", Offset = "0x60F3730", VA = "0x1860F4730", Slot = "18")]
	public void MIEOHPFGNLL(LGANKBMHMJI DLMNOHILJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x60F4040", Offset = "0x60F3040", VA = "0x1860F4040")]
	public void IGCHJEKCOPH([Optional] OACGBNGEOME NAPEBHCGEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x60F49C0", Offset = "0x60F39C0", VA = "0x1860F49C0", Slot = "22")]
	public void PEKHEJKGDEN(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x60F4710", Offset = "0x60F3710", VA = "0x1860F4710", Slot = "19")]
	public JLLFKODPPOM MEAGBINGALE(bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x60F3560", Offset = "0x60F2560", VA = "0x1860F3560", Slot = "20")]
	public JLLFKODPPOM BLOICIIIJAG(HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x60F4900", Offset = "0x60F3900", VA = "0x1860F4900", Slot = "24")]
	public void MJLKODHABBA(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x60F4AB0", Offset = "0x60F3AB0", VA = "0x1860F4AB0", Slot = "23")]
	public void PLKKKNKCFGI(JLLFKODPPOM AIAGFCPBNID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class DEPJLNELJHN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly ILKJIPKENIK<LGANKBMHMJI, LGANKBMHMJI> DCCPCHMOMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly ILKJIPKENIK<LGANKBMHMJI, LGANKBMHMJI> MFPKNFDJHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly OOEBNDBPJGI<LGANKBMHMJI, LGANKBMHMJI, LGANKBMHMJI> FDMEIOIGGMJ;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x60F5590", Offset = "0x60F4590", VA = "0x1860F5590")]
	public DEPJLNELJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
	public void DPGLELIALOP(CLFJEEFCHFE JDIOCIOLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x60F54B0", Offset = "0x60F44B0", VA = "0x1860F54B0")]
	public void MNCIKOLOPFJ(LGANKBMHMJI MMPNPJILHCD, LGANKBMHMJI ONPHKLFILKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x60F5450", Offset = "0x60F4450", VA = "0x1860F5450")]
	public void ADPKKDCOHPE(LGANKBMHMJI MMPNPJILHCD, LGANKBMHMJI ONPHKLFILKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x60F5510", Offset = "0x60F4510", VA = "0x1860F5510")]
	public void ODDGLEAFAIH(LGANKBMHMJI OJFMLGNCJNN, LGANKBMHMJI DIMMPCLNOKP, LGANKBMHMJI ONPHKLFILKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal class EMHHCCFGCGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private CLFJEEFCHFE JDIOCIOLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private KCAJPNCBGDG MPJONFIJKNC;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public EMHHCCFGCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x60F5930", Offset = "0x60F4930", VA = "0x1860F5930")]
	public void DPGLELIALOP(CLFJEEFCHFE JDIOCIOLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x60F5A60", Offset = "0x60F4A60", VA = "0x1860F5A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x60F5AE0", Offset = "0x60F4AE0", VA = "0x1860F5AE0")]
	private void LCHGOCPHOLG(OACGBNGEOME JAPHEDILMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x60F5A70", Offset = "0x60F4A70", VA = "0x1860F5A70")]
	private void EGPINLNLFKI(OACGBNGEOME CPLHIIENLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x60F5C00", Offset = "0x60F4C00", VA = "0x1860F5C00")]
	public void PFODCCHOEOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x60F5B00", Offset = "0x60F4B00", VA = "0x1860F5B00")]
	public void LHMFDMHMENM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DGHJEOEMLAH
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DEGBBGPOHGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public ONGJLMJLNJA container;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public DEGBBGPOHGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x60F53E0", Offset = "0x60F43E0", VA = "0x1860F53E0")]
		internal CLFJEEFCHFE LAAPBGLNICP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x60F5730", Offset = "0x60F4730", VA = "0x1860F5730")]
	public static void MMNFCMCFOLO(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x60F56B0", Offset = "0x60F46B0", VA = "0x1860F56B0")]
	public static void BDLAPMCFFGK(ONGJLMJLNJA CNBEIAALEIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[UnityEngine.Scripting.Preserve]
internal class AKBKJJELKGD : IDisposable, MNLJDOMJJBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly Dictionary<int, PIBPCHLLMBF> LOMECPGNHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly MBLHFJEKEBO GFBHFNBHNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private EMPOOBCBOPK MJBFHIJEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private AGDEGDDIHLO AIAGFCPBNID;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x60EB500", Offset = "0x60EA500", VA = "0x1860EB500")]
	public AKBKJJELKGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x60EAF60", Offset = "0x60E9F60", VA = "0x1860EAF60", Slot = "7")]
	public void DPGLELIALOP(AGDEGDDIHLO AIAGFCPBNID, EMPOOBCBOPK MJBFHIJEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x60EB150", Offset = "0x60EA150", VA = "0x1860EB150", Slot = "5")]
	public void LBOEMMGOBAH(LBAKOKIKILE JCFJCMFBIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60EB390", Offset = "0x60EA390", VA = "0x1860EB390", Slot = "9")]
	public void NGHNNAJNOHE(LBAKOKIKILE LHGAJJLBNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60EADA0", Offset = "0x60E9DA0", VA = "0x1860EADA0", Slot = "8")]
	public void AMGDEDMDMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x60EAA50", Offset = "0x60E9A50", VA = "0x1860EAA50", Slot = "10")]
	public void AFEJPBFNGKE(LBAKOKIKILE HGKDIDHNFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x60EA980", Offset = "0x60E9980", VA = "0x1860EA980", Slot = "11")]
	public void AAEGFCICJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x60EAFA0", Offset = "0x60E9FA0", VA = "0x1860EAFA0")]
	private bool IIFKHALIHFL(LBAKOKIKILE IAFMBOFHOEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class AOFGKEBNIPC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	internal struct IHMDHGCDIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly MPDDDHBMIOA HFOJDJFANKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly HashSet<Guid> LEMCGCLIJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ODHMCLAKNMJ IFECODFKLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly ODHMCLAKNMJ ICOFCEOKCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly bool OLLLLPMEENK;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool FGMLEAOGNPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x60FD470", Offset = "0x60FC470", VA = "0x1860FD470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x60FD930", Offset = "0x60FC930", VA = "0x1860FD930")]
		public IHMDHGCDIAF(MPDDDHBMIOA HFOJDJFANKL, HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK, [Optional] ODHMCLAKNMJ IFECODFKLAH, [Optional] ODHMCLAKNMJ ICOFCEOKCGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x60FD7C0", Offset = "0x60FC7C0", VA = "0x1860FD7C0")]
		public ODHMCLAKNMJ PAKOMNGHIKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x60FD700", Offset = "0x60FC700", VA = "0x1860FD700")]
		private ODHMCLAKNMJ OLBCJPIOCNG([Out] ODHMCLAKNMJ PMDLHCLGAGO, [Out] ODHMCLAKNMJ DHMLABACDME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x60FD0C0", Offset = "0x60FC0C0", VA = "0x1860FD0C0")]
		private ODHMCLAKNMJ ALIHNMGBIEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x60FD590", Offset = "0x60FC590", VA = "0x1860FD590")]
		private void MEGONHCHFDF(ODHMCLAKNMJ EAIMDIODFAA, ODHMCLAKNMJ MFHIHDBFMGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x60FD2B0", Offset = "0x60FC2B0", VA = "0x1860FD2B0")]
		private void DJLHKCPDPGC(ODHMCLAKNMJ PMDLHCLGAGO, ODHMCLAKNMJ DHMLABACDME)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private CLFJEEFCHFE JDIOCIOLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private AGDEGDDIHLO AIAGFCPBNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private MNLJDOMJJBC NGEGDDLINKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private KCAJPNCBGDG MPJONFIJKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool GFLCDGPGFEF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool GHJIEOJMBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x60F1510", Offset = "0x60F0510", VA = "0x1860F1510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool MNNHCHOMPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x60F1340", Offset = "0x60F0340", VA = "0x1860F1340")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x60F1300", Offset = "0x60F0300", VA = "0x1860F1300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x60F1290", Offset = "0x60F0290", VA = "0x1860F1290")]
	public void DPGLELIALOP(CLFJEEFCHFE JDIOCIOLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x60F2780", Offset = "0x60F1780", VA = "0x1860F2780")]
	public JLLFKODPPOM MEAGBINGALE(bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x60F06F0", Offset = "0x60EF6F0", VA = "0x1860F06F0")]
	public JLLFKODPPOM BLOICIIIJAG(HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x60F2EB0", Offset = "0x60F1EB0", VA = "0x1860F2EB0")]
	public void PEKHEJKGDEN(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x60F2F40", Offset = "0x60F1F40", VA = "0x1860F2F40")]
	public void PLKKKNKCFGI(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x60F2500", Offset = "0x60F1500", VA = "0x1860F2500")]
	public void LBBNLGGLKJH(JLLFKODPPOM AIAGFCPBNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x60F0D30", Offset = "0x60EFD30", VA = "0x1860F0D30")]
	private void CCHDGMCEGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x60F2CC0", Offset = "0x60F1CC0", VA = "0x1860F2CC0")]
	private ODHMCLAKNMJ MPOLCPLEHDC(MPDDDHBMIOA PENNBKHEEFF, bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x60F1040", Offset = "0x60F0040", VA = "0x1860F1040")]
	private static void CNHLINMKJDF(MPDDDHBMIOA PENNBKHEEFF, bool OLLLLPMEENK, ODHMCLAKNMJ OKABGGPDJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x60F22E0", Offset = "0x60F12E0", VA = "0x1860F22E0")]
	private void KMGOBJAELEL(MPDDDHBMIOA PENNBKHEEFF, bool OLLLLPMEENK, ODHMCLAKNMJ OKABGGPDJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60F0410", Offset = "0x60EF410", VA = "0x1860F0410")]
	private ODHMCLAKNMJ ABPCLMABLPN(MPDDDHBMIOA HFOJDJFANKL, HashSet<Guid> LEMCGCLIJMC, bool OLLLLPMEENK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x60F2FE0", Offset = "0x60F1FE0", VA = "0x1860F2FE0")]
	private bool PMDMBAJAJGC(JLLFKODPPOM DFDOGLFBGNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x60F1560", Offset = "0x60F0560", VA = "0x1860F1560")]
	private bool ILMGNANMOFH(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x60F1320", Offset = "0x60F0320", VA = "0x1860F1320")]
	private bool GAKHGIMBHDF(JLLFKODPPOM AIAGFCPBNID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x60F0F20", Offset = "0x60EFF20", VA = "0x1860F0F20")]
	private static bool CMOMILJAAHG(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x60F2530", Offset = "0x60F1530", VA = "0x1860F2530")]
	public static bool LIAILMJNEDD(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x60F1BD0", Offset = "0x60F0BD0", VA = "0x1860F1BD0")]
	private LGANKBMHMJI IPDLCDCACJO(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x60F2160", Offset = "0x60F1160", VA = "0x1860F2160")]
	private LGANKBMHMJI JPMDGEGGPPJ(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x60F1360", Offset = "0x60F0360", VA = "0x1860F1360")]
	private LGANKBMHMJI HDPFJGFIADI(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x60F14D0", Offset = "0x60F04D0", VA = "0x1860F14D0")]
	private static Guid IBGINIPIJON(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x60F04A0", Offset = "0x60EF4A0", VA = "0x1860F04A0")]
	private string AEGOPIOJADL(ODHMCLAKNMJ OKABGGPDJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x60F0590", Offset = "0x60EF590", VA = "0x1860F0590")]
	private bool BKJNNDNBNNF(MPDDDHBMIOA PENNBKHEEFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x60F1F00", Offset = "0x60F0F00", VA = "0x1860F1F00")]
	private static void JBGAPBJAPJH(MPDDDHBMIOA HFOJDJFANKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public AOFGKEBNIPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct GEGLHNFAABK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public LGANKBMHMJI ONPHKLFILKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public LGANKBMHMJI MMPNPJILHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int DPIMDEPPOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int JAJDJOLLMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Vector3 BIAFJGKPABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Quaternion DIMGMKENOOP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public JEOBBLCADLH EFJGJKPECDK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x60FC780", Offset = "0x60FB780", VA = "0x1860FC780")]
		get
		{
			return default(JEOBBLCADLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JEOBBLCADLH FLHJONGEGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60FC820", Offset = "0x60FB820", VA = "0x1860FC820")]
		get
		{
			return default(JEOBBLCADLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x60FC850", Offset = "0x60FB850", VA = "0x1860FC850")]
	public GEGLHNFAABK(LGANKBMHMJI ONPHKLFILKP, LGANKBMHMJI MMPNPJILHCD, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface AGDEGDDIHLO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	LBAKOKIKILE NGBMMOKFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPGLELIALOP(GAKJHDKMINJ JDIOCIOLNIG);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LKDCEFFHFEF([In] GEGLHNFAABK ELANMAGHLLI, bool NCDBHBJIIDA = true);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEDFPHNGAKA(LGANKBMHMJI CJCKPKJNOND);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ACACBIBJKPB(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CFOANDKKBKH(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NPFMMABPLBP();

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILCAJGADHEB(Func<LGANKBMHMJI, bool> ADBPHPFECEM);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCOJJEJLFKP(LGANKBMHMJI MINABKJIOJA, HashSet<LGANKBMHMJI> BPKGLHEEOHK);

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<LGANKBMHMJI> CPJIDADBHMI();

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MGKPIIPCDHH(LGANKBMHMJI MINABKJIOJA, [Out] JEOBBLCADLH PPEPLGKFOEJ);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JOHANFGCFLF(MBLHFJEKEBO ADABDJONAPD);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal delegate bool MBLHFJEKEBO(LBAKOKIKILE PENNBKHEEFF);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LBAKOKIKILE
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	LGANKBMHMJI LPJFKFNJHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LBAKOKIKILE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JEOBBLCADLH OAPPICHBFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool GBBPBJKCIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface PIBPCHLLMBF
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPDECBGGCGL(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LDCAMEILANN(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIKABMBAFBH(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KLGNOPCDJAD(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PIBPCHLLMBF Instantiate(Transform NJKBLELAEGN);

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CCMBCIBACJB();
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EMPOOBCBOPK
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPGLELIALOP(Transform NJKBLELAEGN, PIBPCHLLMBF EAKLLFGCOBM);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIBPCHLLMBF JHPLLMGKIOJ();

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPCPLJLHNAJ(PIBPCHLLMBF NJCNIEJOEMA);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface IKLAOBGJAMB : IIHAABNEEMO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGGLPAPMKKK(Guid MFKOMJODHGJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface MNLJDOMJJBC
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LBOEMMGOBAH(LBAKOKIKILE JCFJCMFBIPB);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DPGLELIALOP(AGDEGDDIHLO AIAGFCPBNID, EMPOOBCBOPK OMFDDHBFBBK);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AMGDEDMDMHH();

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGHNNAJNOHE(LBAKOKIKILE LHGAJJLBNHO);

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AFEJPBFNGKE(LBAKOKIKILE HGKDIDHNFLM);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AAEGFCICJOA();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal class MPDDDHBMIOA : LBAKOKIKILE
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CGOKOOHGOAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JEOBBLCADLH nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public MPDDDHBMIOA foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public CGOKOOHGOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x60F3430", Offset = "0x60F2430", VA = "0x1860F3430")]
		internal bool EDFBIPCHDJA(LBAKOKIKILE x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private JEOBBLCADLH PPEPLGKFOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public LinkedList<MPDDDHBMIOA> AEADNLPNBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private MPDDDHBMIOA JNKAEDKHEPM;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public JEOBBLCADLH OAPPICHBFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x33820F0", Offset = "0x33810F0", VA = "0x1833820F0", Slot = "6")]
		get
		{
			return default(JEOBBLCADLH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6100F80", Offset = "0x60FFF80", VA = "0x186100F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private MPDDDHBMIOA MMPNPJILHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6100410", Offset = "0x60FF410", VA = "0x186100410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LBAKOKIKILE APJKJHMNMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BC230", Offset = "0x7BB230", VA = "0x1807BC230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public LGANKBMHMJI LPJFKFNJHGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool GBBPBJKCIPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x61007B0", Offset = "0x60FF7B0", VA = "0x1861007B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FOCLNBGNOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6100740", Offset = "0x60FF740", VA = "0x186100740", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	protected MPDDDHBMIOA HLMIIECLDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6100790", Offset = "0x60FF790", VA = "0x186100790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6100FB0", Offset = "0x60FFFB0", VA = "0x186100FB0")]
	public MPDDDHBMIOA(JEOBBLCADLH BBLHIMGFAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x61005F0", Offset = "0x60FF5F0", VA = "0x1861005F0")]
	public MPDDDHBMIOA EPJFLKIHBEG(JEOBBLCADLH PDDMAAGGIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6100140", Offset = "0x60FF140", VA = "0x186100140")]
	public MPDDDHBMIOA AAPLDGPFBJD(JEOBBLCADLH PMLFHPJACMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x6100C30", Offset = "0x60FFC30", VA = "0x186100C30")]
	public MPDDDHBMIOA JOBFLKKFIPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x61002C0", Offset = "0x60FF2C0", VA = "0x1861002C0")]
	public void BGPDDONPEEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x61007C0", Offset = "0x60FF7C0", VA = "0x1861007C0")]
	public MPDDDHBMIOA IHPGNCJFPKM(JEOBBLCADLH DIMMPCLNOKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6100E20", Offset = "0x60FFE20", VA = "0x186100E20")]
	private static void JOHANFGCFLF(MPDDDHBMIOA JCGCKIOEGPI, MBLHFJEKEBO ODMOFOFBMIL, bool DJBCIDMDNFL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6100E10", Offset = "0x60FFE10", VA = "0x186100E10", Slot = "9")]
	public void JOHANFGCFLF(MBLHFJEKEBO ADABDJONAPD, bool MFKAOOGPGCA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6100870", Offset = "0x60FF870", VA = "0x186100870")]
	public static string JKCLFDMDBPM(MPDDDHBMIOA JCGCKIOEGPI, int CJOODCGGDJB = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x61004F0", Offset = "0x60FF4F0", VA = "0x1861004F0")]
	public static MPDDDHBMIOA EMNELEDHDDC(MPDDDHBMIOA JCGCKIOEGPI, JEOBBLCADLH CGBAKFFCCPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KCAJPNCBGDG
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool GHJIEOJMBGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool BGIEHPPIPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<OACGBNGEOME> LCHGOCPHOLG;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<OACGBNGEOME> EGPINLNLFKI;

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(CLFJEEFCHFE JDIOCIOLNIG);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(LGANKBMHMJI PKIFBFKKIHF, LGANKBMHMJI DHNODEGEGNG, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(JLLFKODPPOM LIAGGIEAMKA, [Optional] OACGBNGEOME NAPEBHCGEJO);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, KCAJPNCBGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private CLFJEEFCHFE JDIOCIOLNIG;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool GHJIEOJMBGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x60FFDC0", Offset = "0x60FEDC0", VA = "0x1860FFDC0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BGIEHPPIPPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x60FFE20", Offset = "0x60FEE20", VA = "0x1860FFE20", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<OACGBNGEOME> LCHGOCPHOLG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x60FFD10", Offset = "0x60FED10", VA = "0x1860FFD10", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x60FFF10", Offset = "0x60FEF10", VA = "0x1860FFF10", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<OACGBNGEOME> EGPINLNLFKI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x60FFC60", Offset = "0x60FEC60", VA = "0x1860FFC60", Slot = "17")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x60FFE60", Offset = "0x60FEE60", VA = "0x1860FFE60", Slot = "18")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC440", Offset = "0x7BB440", VA = "0x1807BC440", Slot = "21")]
		public void SetManager(CLFJEEFCHFE JDIOCIOLNIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x60FFC30", Offset = "0x60FEC30", VA = "0x1860FFC30")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x60FE9B0", Offset = "0x60FD9B0", VA = "0x1860FE9B0", Slot = "25")]
		public void RequestMasterConnectNodes(LGANKBMHMJI AJAFLFANKKB, int DPIMDEPPOED, LGANKBMHMJI KGILDOIHFKB, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x60FEAE0", Offset = "0x60FDAE0", VA = "0x1860FEAE0", Slot = "26")]
		public void RequestMasterDisconnectNode(LGANKBMHMJI CJCKPKJNOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60FEBA0", Offset = "0x60FDBA0", VA = "0x1860FEBA0", Slot = "22")]
		public void RequestMasterModifyNode(LGANKBMHMJI PKIFBFKKIHF, LGANKBMHMJI DHNODEGEGNG, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60FECD0", Offset = "0x60FDCD0", VA = "0x1860FECD0", Slot = "23")]
		public void RequestMasterReparentNodes(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x60FEE00", Offset = "0x60FDE00", VA = "0x1860FEE00", Slot = "27")]
		public void RequestMasterReparentToRoot(LGANKBMHMJI DLMNOHILJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60FE880", Offset = "0x60FD880", VA = "0x1860FE880", Slot = "24")]
		public void RequestDeserializeConnectableGraph(JLLFKODPPOM LIAGGIEAMKA, [Optional] OACGBNGEOME NAPEBHCGEJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x60FF1E0", Offset = "0x60FE1E0", VA = "0x1860FF1E0")]
		[PLKEJOMOLAM]
		private void RpcMasterConnectNodes(LGANKBMHMJI AJAFLFANKKB, int DPIMDEPPOED, LGANKBMHMJI KGILDOIHFKB, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x60FF4A0", Offset = "0x60FE4A0", VA = "0x1860FF4A0")]
		[PLKEJOMOLAM]
		private void RpcMasterDisconnectNode(LGANKBMHMJI CJCKPKJNOND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60FF7E0", Offset = "0x60FE7E0", VA = "0x1860FF7E0")]
		[PLKEJOMOLAM]
		private void RpcMasterReparentNodes(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60FF5E0", Offset = "0x60FE5E0", VA = "0x1860FF5E0")]
		[PLKEJOMOLAM]
		private void RpcMasterModifyNode(LGANKBMHMJI PKIFBFKKIHF, LGANKBMHMJI DHNODEGEGNG, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x60FEFD0", Offset = "0x60FDFD0", VA = "0x1860FEFD0")]
		[PLKEJOMOLAM]
		private void RpcConnectNodes(LGANKBMHMJI AJAFLFANKKB, int DPIMDEPPOED, LGANKBMHMJI KGILDOIHFKB, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP, EDMKOLIOPOO PNNNONPCCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x60FF150", Offset = "0x60FE150", VA = "0x1860FF150")]
		[PLKEJOMOLAM]
		private void RpcDisconnectNode(LGANKBMHMJI CJCKPKJNOND, EDMKOLIOPOO PNNNONPCCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x60FFB30", Offset = "0x60FEB30", VA = "0x1860FFB30")]
		[PLKEJOMOLAM]
		private void RpcReparentNodes(LGANKBMHMJI DLMNOHILJBB, int EALAGJNJLNP, LGANKBMHMJI DIMMPCLNOKP, int JFNMODNEHEB, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP, EDMKOLIOPOO PNNNONPCCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x60FFA70", Offset = "0x60FEA70", VA = "0x1860FFA70")]
		[PLKEJOMOLAM]
		private void RpcModifyNode(LGANKBMHMJI PKIFBFKKIHF, int DPIMDEPPOED, int JAJDJOLLMNF, Vector3 BIAFJGKPABB, Quaternion DIMGMKENOOP, EDMKOLIOPOO PNNNONPCCPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x60FF110", Offset = "0x60FE110", VA = "0x1860FF110")]
		[PLKEJOMOLAM]
		private void RpcDeserializeConnectableGraph(JLLFKODPPOM AIAGFCPBNID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F50", Offset = "0x7D6F50", VA = "0x1807D7F50")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, PIBPCHLLMBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x60FE580", Offset = "0x60FD580", VA = "0x1860FE580", Slot = "4")]
		private void HOAGJNFBGMN(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x60FE310", Offset = "0x60FD310", VA = "0x1860FE310", Slot = "5")]
		private void GIAIDNCKDKE(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x60FE770", Offset = "0x60FD770", VA = "0x1860FE770", Slot = "6")]
		private void OOAOPNCBFNO(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x60FE0C0", Offset = "0x60FD0C0", VA = "0x1860FE0C0", Slot = "7")]
		private void BEGPHHCONJN(LGANKBMHMJI KGILDOIHFKB, JEOBBLCADLH ONPHKLFILKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x60FE700", Offset = "0x60FD700", VA = "0x1860FE700", Slot = "8")]
		private PIBPCHLLMBF NKBGIJEMIEK(Transform NJKBLELAEGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x60FE2B0", Offset = "0x60FD2B0", VA = "0x1860FE2B0", Slot = "9")]
		private void DPNAIJEJMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FOINKPLEAPJ
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2790AA0", Offset = "0x278FAA0", VA = "0x182790AA0")]
	public static MDKCONPIEID<T> GLANAOBGPOO<T>(this ONGJLMJLNJA CNBEIAALEIM)
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
